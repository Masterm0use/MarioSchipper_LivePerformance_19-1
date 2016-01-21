using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance2016.CSharp
{
    [Serializable]
    public class Waarneming
    {
        public int ID { get; }
        public Type Type { get; }
        public int LocX { get; }
        public int LocY { get; }
        public Diersoort Diersoort { get; }

        public Waarneming(int id, Type type, int locX, int locY, Diersoort diersoort)
        {
            ID = id;
            Type = type;
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
