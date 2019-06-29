using System;
using System.Collections.Generic;
using System.Text;

namespace zoo.Classes
{
	abstract class Animal
	{
        public string Species { get; set; }
        public string Size { get; set; }
        public string Environment { get; set; }
        public int LifeSpan { get; set; }

        public virtual string Talk()
        {
            return "I make the sound of silence.";
        }

    }
}
