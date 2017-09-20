using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            if (flag == 1) 
            {
                fG.Clear(Color.Black);
                fG.FillEllipse(whiteBrush, 250,100,10,10);
                fG.FillEllipse(whiteBrush, 295, 150, 10, 10);
                fG.FillEllipse(whiteBrush, 345, 175, 10, 10);
                fG.FillEllipse(whiteBrush, 380, 135, 10, 10);




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
