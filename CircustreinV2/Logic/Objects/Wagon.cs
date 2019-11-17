using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircustreinV2
{
    class Wagon
    {
        const int maxPoints = 10;
        private List<Animal> animalsInWagon;

        public Wagon()
        {
            this.animalsInWagon = new List<Animal>();
        }
    }
}
