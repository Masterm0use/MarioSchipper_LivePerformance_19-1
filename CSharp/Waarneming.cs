using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance2016.CSharp
{
    public class Waarneming
    {
        private int _id;
        private string _type;
        private int _LocX;
        private int _LoxY;
        private DateTime _tijdGespot;

        public int iD { get; }
        public string type { get; set; }
        public int locX { get; set; }
        public int locY { get; set; }
        public DateTime tijdgespot { get; set; }

        public Waarneming(int iD, string type, int locX, int locY)
        {
            this._id = iD;
            this._LocX = locX;
            this._LoxY = locY;
            this._type = type;
            this._tijdGespot = DateTime.Now;
            ;
        }
    }
}
