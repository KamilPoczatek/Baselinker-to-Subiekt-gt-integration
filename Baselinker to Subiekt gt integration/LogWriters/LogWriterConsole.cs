using System;

namespace Baselinker_to_Subiekt_gt_integration
{
    class LogWriterConsole : LogWriter
    {
        public override void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
