using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson12
{
    public abstract class Manager
    {
        public  abstract List<Person> read(string path);
        public abstract void write(List<Person> lst);
    }
}
