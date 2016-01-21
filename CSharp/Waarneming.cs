using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance2016.CSharp
{
    public enum Cat {Va, Ti, Ni};
    [Serializable]
    public class Waarneming
    {
        public int ID { get; }
        public Cat Cat { get; }
        public int LocX { get; }
        public int LocY { get; }
        public Diersoort Diersoort { get; }

        public Waarneming(Cat cat, int locX, int locY, Diersoort diersoort)
        {
            //ID = id;
            Cat = cat;
            LocX = locX;
            LocY = locY;
            Diersoort = diersoort;
        }

        public override string ToString()
        {
            return Diersoort.ToString();
        }
    }
}
