using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance2016.CSharp
{
    public class TelGebied
    {
        public int ID { get; }
        public string Naam { get; }
        public string PathMap { get; }
        public List<Project> Projecten { get; }

        public TelGebied(int id, string naam, string pathMap)
        {
            ID = id;
            Naam = naam;
            PathMap = pathMap;
        }

        public void AddProject(Project project)
        {
            Projecten.Add(project);
        }

        public override string ToString()
        {
            return Naam;
        }
    }
}
