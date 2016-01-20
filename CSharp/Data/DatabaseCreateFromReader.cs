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
        private Project CreateProjectFromReader(OracleDataReader reader)
        {
            return new Project(
                Convert.ToInt32(reader["ID"]),
                Convert.ToString(reader["Naam"]),
                Convert.ToString(reader["Beschrijving"]),
                Convert.ToDateTime(reader["datumStart"]),
                Convert.ToDateTime(reader["datumEind"])
                );
        }

        private TelGebied CreateTelgebiedFromReader(OracleDataReader reader)
        {
            return new TelGebied(
                Convert.ToInt32(reader["ID"]),
                Convert.ToString(reader["Naam"]),
                Convert.ToString(reader["PathMap"])
                );
        }

    }
}
