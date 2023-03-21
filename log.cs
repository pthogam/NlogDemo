




using NlogDemo;


namespace NlogDemo
{
    public class log
    {
        
        Logger logger = LogManager. GetCurrentClassLogger();

        public void logdebugThemessage(string message)
        {
            logger.Debug(message);
        }
        public void Logerrormessage(string message)
        {
            logger.Error(message);
        }
        public void Loginfomessage(string message)
        {
            logger.Info(message);

        }
        
     
        
    }
}

