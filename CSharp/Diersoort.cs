using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance2016.CSharp
{
    public class Diersoort
    {
        private int _id;
        private string _afkorting;
        private string _vogelsoort;
        private DateTime _broedPeriodeVan;
        private DateTime _broedPeriodeTot;

        public int iD { get; }
        private string vogelsoort { get; set; }
        private string afkorting { get; set; }
        public DateTime broedPeriodeVan { get; set; }
        public DateTime broedPeriodeTot { get; set; }

        public Diersoort(int iD, string vogelsoort, string afkorting, DateTime broedPeriodeVan, DateTime broedPeriodeTot)
        {
            this._id = iD;
            this._vogelsoort = vogelsoort;
            this._afkorting = afkorting;
            this._broedPeriodeVan = broedPeriodeVan;
            this._broedPeriodeTot = broedPeriodeTot;
        }
    }
}
