using System;

namespace Baselinker_to_Subiekt_gt_integration
{
    class Program
    {
        static void Main(string[] args)
        {
            LogWriter logWriter = LogWriter.CreateLogWriter();
            Baselinker baselinker = new Baselinker();

            logWriter.Log("Start");

            var order = baselinker.GetOrder("3059931").GetAwaiter().GetResult();





        }
    }
}
