using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace LivePerformance2016.CSharp.Data
{
    public partial class Database
    {
        private static string dataUser = "dbi315883";
        private static string dataPass = "rFMhp3FfTN";
        private static string dataSrc = "//fhictora01.fhict.local:1521/fhictora";
        private static readonly string ConnectionString = "User Id=" + dataUser + ";Password=" + dataPass + ";Data Source=" + dataSrc + ";";


        public static OracleConnection Connection
        {
            get
            {
                OracleConnection connection = new OracleConnection(ConnectionString);
                connection.Open();
                return connection;
            }
        }
    }
}
