using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blyat23
{
    class Picture
    {
        public string name;
        public string PathToPicture;

        public Picture(string path, string name)
        {
            PathToPicture = path;
            this.name = name;
        }
    }
}
