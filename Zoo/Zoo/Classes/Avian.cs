using System;
using System.Collections.Generic;
using System.Text;

namespace zoo.Classes
{
    abstract class Avian : Animal
    {
        public bool CanFly { get; set; }
        public int WingSpan { get; set; }

    }
}
