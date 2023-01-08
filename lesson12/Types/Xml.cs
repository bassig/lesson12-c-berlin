using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace lesson12.Types
{
    public class Xml : Manager
    {
        public override List<Person> read(string path)
        {
            XmlSerializer ser = new(typeof(List<Person>));
            StreamReader r = new StreamReader(path);
            List<Person>? per = (List<Person>)ser.Deserialize(r);
            return per;
        }

        public override void write(List<Person> lst)
        {
            StreamWriter w = new StreamWriter("../../../XmlFile.xml");
            XmlSerializer ser = new XmlSerializer(typeof(List<Person>));
            ser.Serialize(w, lst);
            w.Close();
        }
    }
}
