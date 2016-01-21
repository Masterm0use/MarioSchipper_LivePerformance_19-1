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
        public List<Project> GetAllProjecten()
        {
            List<Project> projectlist = new List<Project>();
            using (OracleConnection connection = Connection)
            {
                string query = "SELECT * FROM Project";
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            projectlist.Add(CreateProjectFromReader(reader));
                        }
                    }
                }
            }
            return projectlist;
        }

        public List<TelGebied> GetAllTelgebied()
        {
            List<TelGebied> telGebiedlist = new List<TelGebied>();
            using (OracleConnection connection = Connection)
            {
                string query = "SELECT * FROM TELGEBIED";
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            telGebiedlist.Add(CreateTelgebiedFromReader(reader));
                        }
                    }
                }
            }
            return telGebiedlist;
        }
    }
}
