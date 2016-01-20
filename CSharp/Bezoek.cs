using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance2016.CSharp
{
    public class Bezoek
    {
        private int _id;
        private DateTime _datumStart;
        private DateTime _datumEind;

        public int iD { get; }
        public DateTime datumStart { get; set; }
        public DateTime datumEind { get; set; }

        public Bezoek(int iD, DateTime datumStart, DateTime datumEind)
        {
            this._id = iD;
            this._datumStart = datumStart;
            this._datumEind = datumEind;
        }
    }
}
