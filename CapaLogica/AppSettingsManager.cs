using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class AppSettingsManager
    {
        private readonly string KEY_MACHINE_APP_SETTINGS = "idMachine";
<<<<<<< HEAD
        private  readonly string HOST_SERVER_WEB_SOCKET = "hostWebSocket";

=======
        
>>>>>>> c43727964e747f043a8f74b635bb4754c83e7803
        public void SetIdMachine(int id)
        {
            ConfigurationManager.
                AppSettings
                .Set(KEY_MACHINE_APP_SETTINGS, Convert.ToString(id) );
        }

        public string GetIdMachineFromSettings()
        {
            string id = ConfigurationManager.AppSettings[KEY_MACHINE_APP_SETTINGS];
            return id;
        }
<<<<<<< HEAD


    
        public  string GetHostFromSettings()
        {
            string host = ConfigurationManager.AppSettings[HOST_SERVER_WEB_SOCKET];
            
            return host;
        }
=======
        
>>>>>>> c43727964e747f043a8f74b635bb4754c83e7803




    }
}
