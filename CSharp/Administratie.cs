using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using LivePerformance2016.CSharp.Data;

namespace LivePerformance2016.CSharp
{
    public partial class Administratie
    {
        public List<TelGebied> TelGebieden { get; set; }
        public List<Project> Projecten { get; set; }
        public List<Diersoort> Diersoorts { get; }
        public List<Bezoek> Bezoeken { get; }
        public List<Type> Types { get; private set; }
        //Is gemaakt om te testen.
        private String filenaam = @"C:\Users\Mastermouse\Desktop\waarnemingen.xml";

        public Administratie()
        {
            TelGebieden = new List<TelGebied>();
            Projecten = new List<Project>();
            Diersoorts = new List<Diersoort>();
            Types = new List<Type>();
            Bezoeken = new List<Bezoek>();
            ProjectData();
            VogelData();
            KaartData(true);
            SerialHelper.SerializeObject(this.Bezoeken, this.filenaam);
            SerialHelper.Deserialize(this.filenaam);

            //refresh(database);
        }

        private void refresh(bool database)
        {
            if (database)
            {
                KaartData(true);
            }
            else
            {
                KaartData(false);
            }
        }

        private void FindVogel()
        {
            
        }

        private void KaartData(bool useDatabase)
        {
            TelGebieden.Clear();

            if (useDatabase)
            {
                Database data = new Database();
                TelGebieden = data.GetAllTelgebied();
            }
            else
            {
                TelGebied telGebied = new TelGebied(1,"Veldmap" ,@"C: \Users\Mastermouse\Documents\GitHub\MarioSchipper_LivePerformance_19-1\Gebieden\lege_veldkaart.png");
                TelGebieden.Add(telGebied);
            }
        }

        public Diersoort Findvogel(string vogelnaam )
        {
            foreach (Diersoort d  in Diersoorts)
            {
                if (vogelnaam == d.Naam)
                {
                    return d;
                }
            }
            return null;
        }

        private void ProjectData()
        {
            //database alle projecten ophalen
            Projecten.Clear();

            Database data = new Database();
            Projecten = data.GetAllProjecten();
        }


        private void VogelData()
        {
            var reader = new StreamReader(File.OpenRead(@"C:\Users\Mastermouse\Documents\GitHub\MarioSchipper_LivePerformance_19-1\Gebieden\data\broedvogels.csv"));

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(';');

                var naam = values[0];
                var afkorting = values[1];
                var startBroeden = DateTime.Parse(values[2]);
                var eindBroeden = DateTime.Parse(values[3]);
                var punten = Convert.ToInt32(values[4]);

                Diersoorts.Add(new Diersoort(naam, afkorting, startBroeden, eindBroeden, punten));
            }
        }
    }
}

