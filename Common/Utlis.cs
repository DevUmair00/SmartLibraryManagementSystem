using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Library_Management_System.Common
{
    internal class Utlis
    {
        public static string GET_DB_Connection_String()
        {
            return "Server=localhost;Database=SmartLibraryDB;Trusted_Connection=true;TrustServerCertificate=True";
        }
    }
}

