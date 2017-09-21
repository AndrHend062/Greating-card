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
namespace Greating_card
{
    public partial class card : Form
    {

        int flag = 0;
        public card()
        {
            InitializeComponent();

          

        }

        private void card_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics fG = this.CreateGraphics();
            fG.Clear(Color.White);
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            SolidBrush redBrush = new SolidBrush(Color.Red);
            Pen drawPen = new Pen(Color.Yellow, 20);
            Pen starPen = new Pen(Color.White, 1);

            if (flag == 1) 
            {
                fG.Clear(Color.Black);
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
                Thread.Sleep(500);
                fG.DrawLine(starPen, 255, 105, 300, 155); //left top
                Thread.Sleep(500);
                fG.DrawLine(starPen, 295, 150, 350, 180);
                Thread.Sleep(500);
                fG.DrawLine(starPen, 350, 180, 385, 140);
                Thread.Sleep(500);
                fG.DrawLine(starPen, 385, 140, 425, 75);
                fG.DrawLine(starPen, 350, 180, 305, 250);// bottem of U to Mid
                fG.DrawLine(starPen, 305, 250, 315, 315); //big to mid 
                fG.DrawLine(starPen, 315, 315, 240, 240); // big to hip 
                fG.DrawLine(starPen, 315, 315, 170, 330); //big to low leg 
                fG.DrawLine(starPen, 170, 330, 115, 350);
                fG.DrawLine(starPen, 300, 155, 240, 240); //left side
                fG.DrawLine(starPen, 75, 285, 75, 285); // uppy leg 


                flag = -1;
            }
            else 
            {
                fG.DrawRectangle(drawPen, 5, 5, 470, 200);
                fG.FillRectangle(blackBrush, 0, 200, 490, 200);

                fG.FillRectangle(redBrush, 10, 5,465, 300);
                flag += 1;
            }


        }
    }
}
