﻿using IronXL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson12.Types
{
    internal class Excel : Manager
    {
        public override List<Person> read(string path)
        {
            throw new NotImplementedException();

        }

        public override void write(List<Person> lst)
        {
            throw new NotImplementedException();
        }
    }
}
