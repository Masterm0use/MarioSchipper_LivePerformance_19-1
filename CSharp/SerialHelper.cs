using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance2016.CSharp
{
    public class SerialHelper
    {
        /// <summary>
        /// Serialze alle objecten in de list bezoeken.
        /// </summary>
        /// <param name="list">Lijst van de bezoeken</param>
        /// <param name="fileName">Bestandsnaam</param>
        public static void SerializeObject(List<Bezoek> list, string fileName)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, list);
            stream.Close();
        }
        /// <summary>
        /// Deserialize de opgegeven file en zet het om naar een list van bezoeken.
        /// </summary>
        /// <param name="fileName">Bestandsnaam</param>
        /// <returns>Een list van bezoeken</returns>
        public static List<Bezoek> Deserialize(string fileName)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read);
            List<Bezoek> list = (List<Bezoek>)formatter.Deserialize(stream);
            stream.Close();
            return list;
        }
    }
}
