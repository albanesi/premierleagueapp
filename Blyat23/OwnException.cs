using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blyat23
{
    class OwnException : Exception
    {
        public OwnException()
        {
            MessageBox.Show("Textfeld darf nicht leer sein");
        }

        public OwnException(string message) : base(message)
        {
           
            
        }
    }
}
