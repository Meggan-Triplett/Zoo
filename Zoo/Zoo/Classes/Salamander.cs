using System;
using System.Collections.Generic;
using System.Text;
using zoo.Interfaces;

namespace zoo.Classes
{
    class Salamander : Amphibian, IEggsLayable
    {
        public bool BreatheThroughSkin { get; set; }

        public bool HasGills { get; set; }

        public int NumberOfEggs()
        {
            throw new NotImplementedException();
        }

        public string WeeksUntilHatch()
        {
            throw new NotImplementedException();
        }
    }
}
