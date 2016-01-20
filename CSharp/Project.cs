using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance2016.CSharp
{
    public class Project
    {
        private int _id;
        private string _naam;
        private string _beschrijving;
        private DateTime _datumStart;
        private DateTime _datumEind;

        public int iD { get; }
        public string naam { get; set; }
        public string beschrijving { get; set; }
        public DateTime datumStart { get; set; }
        public DateTime datumEind { get; set; }

        public Project(int iD, string naam, string beschrijving, DateTime datumStart, DateTime datumEind)
        {
            this._id = iD;
            this._naam = naam;
            this._beschrijving = beschrijving;
            this._datumStart = datumStart;
            this._datumEind = datumEind;
        }

    }
}
