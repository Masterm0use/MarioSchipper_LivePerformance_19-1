using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance2016.CSharp
{
    public class TelGebied
    {
        private int _id;
        private string _naam;
        private string _pathMap;

        public int iD { get; }
        public string naam { get; set; }
        public string pathMap { get; }

        public TelGebied(int iD, string naam, string beschrijving, string pathMap)
        {
            this._id = iD;
            this._naam = naam;
            this._pathMap = pathMap;
        }
    }
}
