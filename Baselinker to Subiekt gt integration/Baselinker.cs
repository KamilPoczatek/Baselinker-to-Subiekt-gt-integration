using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net.Http;
using System.Threading.Tasks;

namespace Baselinker_to_Subiekt_gt_integration
{
    class Baselinker
    {
        private readonly string url = ConfigurationManager.AppSettings[ConfigNames.baselinkerURL];
        private readonly string token = ConfigurationManager.AppSettings[ConfigNames.baselinkerToken];
        private static readonly HttpClient client = new HttpClient();

        public async Task<string> APIRequst(string method, string parameters)
        {
            var values = new Dictionary<string, string>
            {
                { "token", token },
                { "method", method },
                { "parameters", parameters }
            };

            var content = new FormUrlEncodedContent(values);
            var response = await client.PostAsync(url, content);
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<BaselinkerOrder> GetOrder(string orderId)
        {
            var result = JsonConvert.DeserializeObject<BaselinkerGetOrdersResult>
                (await APIRequst(BaselinkerMethods.getOrders, " { \"order_id\": " + orderId + " }"));

            if (!string.IsNullOrEmpty(result.error_code))
                throw new HttpRequestException(result.error_message);

            if (result.orders.Count != 1)
                throw new ArgumentException("No existing order");

            return result.orders[0];       
        }
    }
}
