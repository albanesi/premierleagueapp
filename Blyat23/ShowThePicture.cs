using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Blyat23
{
    class ShowPictures
    {
        public static void ShowThePictures(PictureBox pictureBox, string path)
        {
            pictureBox.Load(path);
            
        }
      
    }
}
