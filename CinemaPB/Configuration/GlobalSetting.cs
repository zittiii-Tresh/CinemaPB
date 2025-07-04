using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaPB.Configuration
{
    public static class GlobalSetting
    {
        public static string GetConnectionString()
        {

            return @"Data Source = PAGALING\SQLEXPRESS;Initial Catalog = CinemaDB;Integrated Security = True;";
            //return @"Data Source = LAPTOP-FC9GSM04\SQLEXPRESS;Initial Catalog = CinemaDB;Integrated Security = True;";
        }
    }
}
