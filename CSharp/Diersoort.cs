using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance2016.CSharp
{
    [Serializable]
    public class Diersoort
    {
        
        //public int ID { get; }
        public string Naam { get;}
        public string Afkorting { get; set; }
        public DateTime BroedPeriodeVan { get; set; }
        public DateTime BroedPeriodeTot { get; set; }
        public int ReqNummer { get; }

        public Diersoort(string naam, string afkorting, DateTime broedPeriodeVan, DateTime broedPeriodeTot, int reqNummer)
        {
            //ID = iD;
            Naam = naam;
            Afkorting = afkorting;
            BroedPeriodeVan = broedPeriodeVan;
            BroedPeriodeTot = broedPeriodeTot;
            ReqNummer = reqNummer;
        }

        public override string ToString()
        {
            return Naam;
        }
    }
}
