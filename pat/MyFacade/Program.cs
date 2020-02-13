using System;

namespace MyFacade
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = "User is Oleg";
            DbProvider dbProvider = new DbProvider() { Data = data };
            LogProvider logProvider = new LogProvider() { Log = data.ToLower() };
            NotifyProvider notifyProvider = new NotifyProvider() { Notify = data.ToUpper() };

            NsiUserDataFacade nsiUserDataFacade = new NsiUserDataFacade(dbProvider, logProvider, notifyProvider);
            nsiUserDataFacade.SaveNsiUserData();
            nsiUserDataFacade.SaveNsiUserDataWithNotify();

        }


        #region Subsistems
        public class DbProvider {

            public string Data { get;set; }
            public void SaveData() { Console.WriteLine($"{Data} - Save to DB"); }
        }

        public class LogProvider
        {
            public string Log { get; set; }
            public void LogDataToFile() { Console.WriteLine($"{Log} - Log Save to File"); }
            public void LogDataToGrayLog() { Console.WriteLine($"{Log} - Log Save to GrayLog"); }
        }

        public class NotifyProvider
        {
            public string Notify { get; set; }
            public void SendNotify() { Console.WriteLine($"{Notify} - Send notify to User"); }
        }

        #endregion

        #region Facade

        public class NsiUserDataFacade
        {
            DbProvider _dbProvider;
            LogProvider _logProvider;
            NotifyProvider _notifyProvider;

            public NsiUserDataFacade(DbProvider dbProvider, LogProvider logProvider, NotifyProvider notifyProvider)
            {
                _dbProvider = dbProvider;
                _logProvider = logProvider;
                _notifyProvider = notifyProvider;
            }

            public void SaveNsiUserData()
            {
                _dbProvider.SaveData();
                _logProvider.LogDataToFile();
                _logProvider.LogDataToGrayLog();
            }

            public void SaveNsiUserDataWithNotify()
            {
                SaveNsiUserData();
                _notifyProvider.SendNotify();
            }
        }

        #endregion
    }
}
