using NLog;
using NLog.Web;

namespace API.Infrastructure.Logging
{
    public class MyLogger : ILog
    {
        private static readonly ILogger Logger = NLogBuilder.ConfigureNLog("nlog.config").GetCurrentClassLogger();

        public void Information(string message)  
        {  
            Logger.Info(message);  
        }  
  
        public void Warning(string message)  
        {  
            Logger.Warn(message);  
        }  
  
        public void Debug(string message)  
        {  
            Logger.Debug(message);  
        }  
  
        public void Error(string message)  
        {  
            Logger.Error(message);  
        }  
    }
}