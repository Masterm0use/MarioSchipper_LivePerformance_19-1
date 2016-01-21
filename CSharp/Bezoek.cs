using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;


namespace LivePerformance2016.CSharp
{
    [Serializable]
    public class Bezoek
    {
        
        public int ID { get; }
        public DateTime DatumStart { get; }
        public DateTime DatumEind { get; set; }
        public List<Waarneming> Waarnemingen { get; set; }

        public Bezoek(int iD, DateTime datumStart, DateTime datumEind)
        {
            ID = iD;
            DatumStart = datumStart;
            DatumEind = datumEind;
        }

        public void AddWaarneming(Waarneming waarneming)
        {
            Waarnemingen.Add(waarneming);
        }
    }
}
