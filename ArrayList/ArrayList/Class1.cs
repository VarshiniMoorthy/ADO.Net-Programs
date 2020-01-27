using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ArrayList
{
    class Class1
    {
        static string adminName = ConfigurationManager.appSetting["username"].ToString();
        static string adminPassword = ConfigurationManager.appSetting["123"].ToString();

    }
}
