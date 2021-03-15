using System.Configuration;

namespace Baselinker_to_Subiekt_gt_integration
{
    abstract class LogWriter
    {
        public static LogWriter CreateLogWriter()
        {
            return (ConfigurationManager.AppSettings[ConfigNames.logMode]) switch
            {
                LogModes.console => new LogWriterConsole(),
                LogModes.file => new LogWriterFile(),
                _ => throw new ConfigurationErrorsException("Unsupported log mode"),
            };
        }

        public abstract void Log(string message);
    }
}
