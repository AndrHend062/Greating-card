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
using System.Media;


namespace Greating_card
{
    public partial class card : Form
    {
        SoundPlayer upSound = new SoundPlayer(Properties.Resources.up);
        int flag = 0;
        public card()
        {
            InitializeComponent();

          

        }

        private void card_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics fG = this.CreateGraphics();
            Font arialFont = new Font("Arial", 10, FontStyle.Bold);
            Font georgiaFont = new Font("Georgia", 10, FontStyle.Bold);
            SolidBrush drawBrush = new SolidBrush(Color.Red);
            Graphics onScreen = this.CreateGraphics(); //Sets up on-screen graphics
            Bitmap bm = new Bitmap(this.Width, this.Height); //bitmap area size of whole screen
            Graphics offScreen = Graphics.FromImage(bm); //Sets off-screen graphics to the bitmap


            fG.Clear(Color.White);
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            SolidBrush redBrush = new SolidBrush(Color.Red);
            Pen drawPen = new Pen(Color.Yellow, 20);
            Pen starPen = new Pen(Color.White, 1);
            upSound.Play();
            if (flag == 1) 
            {
                fG.Clear(Color.Black); // draw stars 
                fG.FillEllipse(whiteBrush, 250,100,10,10);
                fG.FillEllipse(whiteBrush, 295, 150, 10, 10); // left lowwer u
                fG.FillEllipse(whiteBrush, 345, 175, 10, 10); // bothem of top U  
                fG.FillEllipse(whiteBrush, 380, 135, 10, 10); //
                fG.FillEllipse(whiteBrush, 420, 70, 10, 10); //top cirle
                fG.FillEllipse(whiteBrush, 300, 245, 10, 10); //middel
                fG.FillEllipse(whiteBrush, 305, 305, 30, 30); // big one
                fG.FillEllipse(whiteBrush, 235, 235, 10, 10);
                fG.FillEllipse(whiteBrush, 170, 245, 10, 10);
                fG.FillEllipse(whiteBrush, 165, 325, 10, 10); //leg 
                fG.FillEllipse(whiteBrush, 75, 285, 10, 10); //upy foot 
                fG.FillEllipse(whiteBrush, 110, 345, 10, 10);//foot 

                Thread.Sleep(500);// conect stars 
                fG.DrawLine(starPen, 255, 105, 300, 155); //left top
                Thread.Sleep(500);
                fG.DrawLine(starPen, 295, 150, 350, 180);
                Thread.Sleep(500);
                fG.DrawLine(starPen, 350, 180, 385, 140);
                Thread.Sleep(500);
                fG.DrawLine(starPen, 385, 140, 425, 75);
                Thread.Sleep(500);
                fG.DrawLine(starPen, 350, 180, 305, 250);// bottem of U to Mid
                Thread.Sleep(500);
                fG.DrawLine(starPen, 305, 250, 315, 315); //big to mid 
                Thread.Sleep(500);
                fG.DrawLine(starPen, 300, 155, 240, 240); //left side
                Thread.Sleep(500);
                fG.DrawLine(starPen, 315, 315, 240, 240); // big to hip 
                Thread.Sleep(500);
                fG.DrawLine(starPen, 315, 315, 170, 330); //big to low leg 
                Thread.Sleep(500);
                fG.DrawLine(starPen, 170, 330, 115, 350);
                Thread.Sleep(500);
                fG.DrawLine(starPen, 170, 250, 240, 240);
                Thread.Sleep(500);
                fG.DrawLine(starPen, 170, 250, 80, 290); // uppy leg 
                Thread.Sleep(1000);
                fG.DrawString("Virgo constellation ", georgiaFont, drawBrush, 50, 40);
                fG.DrawString("the virgo constellation is a latin word meaning virgin.  ", arialFont, drawBrush, 10, 400);
                Thread.Sleep(1000);
                fG.DrawString("the virgo constellation is the second largest constellation in the sky   ", arialFont, drawBrush, 10, 420);
                Thread.Sleep(1000);
                fG.FillRectangle(blackBrush, 0, 0, 400, 100);
                Thread.Sleep(100);
                fG.DrawString("Virgo constellation ", georgiaFont, drawBrush, 100, 40);

                upSound.Play();
                flag = -1;
            }
            else 
            {
                fG.DrawRectangle(drawPen, 5, 5, 470, 200);
                fG.FillRectangle(blackBrush, 0, 200, 490, 300);

                fG.FillRectangle(redBrush, 10, 5,465, 300);

                fG.DrawString("greetings  ", georgiaFont, blackBrush, 100, 40);
                fG.DrawString("this is a card   ", georgiaFont, blackBrush, 150, 40);
                flag += 1;
            }


        }
    }
}
