using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Windows.Threading;

namespace Blyat23
{
    public partial class Form1 : Form, ShowTheGifs
    {
        Player[] players = new Player[3];
        PathToPicture PathToPictures;
        Picture[] pictures = new Picture[3];
        Random random = new Random();
        int bly;
        int rightAnswers = 0;
        int falseAnswers = 0;

        DispatcherTimer dispatcherTimer = new DispatcherTimer();
      

        public Form1()//Initialize  everything and show the first picture
        {
            bly = random.Next(3);
            InitializeComponent();
            Initilazie();
            PathToPictures.InitlizeEverything();
            ShowPictures.ShowThePictures(pictureBox1, pictures[bly].PathToPicture);
        }
       

        private void Button1_Click(object sender, EventArgs e)
        {
           
                dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
                dispatcherTimer.Interval = new TimeSpan(0, 0, 4);   //fire after 3 seconds
            
                if (pictures[bly].name == textBox1.Text) //if the answer is correct
                {
                    
                    rightAnswers++; //rightanswers get +1
                    refreshRandom(); // it refreshes the random
                    textBox1.Clear(); //clears the textbox
                    pictureBox2.Visible = true; //shows picturebox2
                    ShowTheRighGif(); //shows the gif for the right answers

                }
                else
                {
               
                    falseAnswers++; // fâlseanswers get+1
                    refreshRandom(); // it refreshes the random
                    textBox1.Clear(); // clears the textbox
                    pictureBox2.Visible = true;//shows picturebox2
                ShowTheWrongGif();//shows the gif for the right answers
            }
            
        }
        private void Initilazie() // creates new Players, 
        {
            players[0] = new Player("Granit", "Xhaka");
            players[1] = new Player("Pierre-Emerick", "Aubameyang");
            players[2] = new Player("Sergio", "Aguero");
            pictures[0] = new Picture("Download.jpg", players[0].Fullname());
            pictures[1] = new Picture("Download (1).jpg", players[1].Fullname());
            pictures[2] = new Picture("Download (2).jpg", players[2].Fullname());
            PathToPictures = new PathToPicture(players, pictures);
        }
        public void refreshRandom()
        {
            bly = random.Next(3);
        }

        public void ShowTheRighGif()
        {
         
            pictureBox2.Load(@"C:\Users\alban\source\repos\Blyat23\Blyat23\bin\Debug\tenor.gif");
            
         
            dispatcherTimer.Start();

        }

        public void ShowTheWrongGif()
        {
            pictureBox2.Load(@"C:\Users\alban\source\repos\Blyat23\Blyat23\bin\Debug\image.gif");
            dispatcherTimer.Start();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Sie hatten " + rightAnswers + " richtige Antworten");
            MessageBox.Show("Sie hatten " + falseAnswers + " flasche Antworten");
        }
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            ShowPictures.ShowThePictures(pictureBox1, pictures[bly].PathToPicture);
            dispatcherTimer.Stop();
        }

    }
}
