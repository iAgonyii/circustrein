﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircustreinV2
{
    public class Animal
    {
        public Diet Diet { get; set; }
        public Size Size { get; set; }

        public Animal(Diet Diet, Size Size)
        {
            this.Diet = Diet;
            this.Size = Size;
        }

        public override string ToString()
        {
            return "Animal/" + Diet.ToString() + "/" + Size.ToString();
        }
    }
}
