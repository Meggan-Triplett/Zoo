using System;
using System.Collections.Generic;
using System.Text;

namespace zoo.Classes
{
    abstract class Mammal: Animal
    {
        public bool WarmBlooded { get; set; }
        public string HairTexture { get; set; }

    }
}