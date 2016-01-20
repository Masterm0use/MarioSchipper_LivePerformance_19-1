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
        public void InsertProject(Project project)
        {
            using (OracleConnection connection = Connection)
            {
                string Update = "insert into project values(PROJECT_FCSEQ.nextval, :TELGEBIEDID, :NAAM, :BESCHRIJVING, :DATUMSTART, :DATUMEIND)";
                using (OracleCommand command = new OracleCommand(Update, connection))
                {
                    command.Parameters.Add(new OracleParameter("TELGEBIEDID", project.iD));
                    command.Parameters.Add(new OracleParameter("NAAM", project.naam));
                    command.Parameters.Add(new OracleParameter("BESCHRIJVING", project.beschrijving));
                    command.Parameters.Add(new OracleParameter("DATUMSTART", project.datumStart));
                    command.Parameters.Add(new OracleParameter("DATUMEIND", project.datumEind));

                    command.ExecuteNonQuery();
                }
            }
        }

        public void InsertWaarneming(Waarneming waarneming)
        {
            using (OracleConnection connection = Connection)
            {
                string Update = "insert into WAARNEMING values(WAARNEMING_FCSEQ.nextval, :BEZOEKID, :DIERENSOORTID, :TYPE, :LOCX, :LOCY, :TijdGespot)";
                using (OracleCommand command = new OracleCommand(Update, connection))
                {
                    command.Parameters.Add(new OracleParameter("BEZOEKID", waarneming.iD));
                    command.Parameters.Add(new OracleParameter("DIERENSOORTID", waarneming.iD));
                    command.Parameters.Add(new OracleParameter("TYPE", waarneming.type));
                    command.Parameters.Add(new OracleParameter("LOCX", waarneming.locX));
                    command.Parameters.Add(new OracleParameter("LOCY", waarneming.locY));
                    command.Parameters.Add(new OracleParameter("TijdGespot", waarneming.tijdgespot));

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
