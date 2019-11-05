using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blyat23
{
   public class Player
    {
        public string Name;
        public string Lastname;

        public Player()
        {
        }

        public Player(string nm, string lm)
        {
            Name = nm;
            Lastname = lm;
        }
        public string Fullname()
        {
            return Name + " " + Lastname;
        }
    }
}
