using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace lesson12.Types
{
    public class Json : Manager
    {
        public override List<Person> read(string path)
        {
            string fileName = path;
            string jsonString = File.ReadAllText(fileName);
            List<Person>? per = JsonSerializer.Deserialize<List<Person>>(jsonString)!;
            return per;
        }

        public override void write(List<Person> lst)
        {
            string s = JsonSerializer.Serialize(lst);
            StreamWriter wjson = new StreamWriter("../../../file.json");
            wjson.Write(s);
            wjson.Close();
        }
    }
}
