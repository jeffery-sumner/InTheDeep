﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InTheDeep
{
    class Item
    {
        public string Name { get; private set; }
        public int Quanity { get; private set; }

        public Item(string name, int quanity)
        {
            Name = name;
            Quanity = quanity;
        }
    }
}
