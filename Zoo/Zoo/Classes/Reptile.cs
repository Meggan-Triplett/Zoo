﻿using System;
using System.Collections.Generic;
using System.Text;

namespace zoo.Classes
{
    abstract class Reptile : Animal
    {
        public bool IsVenomous { get; set; }
        public string ScaleColor { get; set; }

    }
}
