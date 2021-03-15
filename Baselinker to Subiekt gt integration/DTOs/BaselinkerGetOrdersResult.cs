using System.Collections.Generic;

namespace Baselinker_to_Subiekt_gt_integration
{
    class BaselinkerGetOrdersResult
    {
        public string status;
        public string error_code;
        public string error_message;
        public List <BaselinkerOrder> orders;
    }
}
