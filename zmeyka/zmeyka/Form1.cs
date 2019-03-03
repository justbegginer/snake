using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zmeyka
{
    public partial class Form1 : Form
    {
        int xCordinate = 0;
        int yCordinate = 0;
        int firstAppleX = 0;
        int firstAppleY = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Paint(object sender, PaintEventArgs e)
        {
            Random random = new Random();
            int firstNumber = random.Next(50,GameArea.Width-50);
            if (xCordinate==0)
            {
                xCordinate = firstNumber;
            }
            int secondNumber = random.Next(50,GameArea.Height-50);
            if (yCordinate == 0)
            {
                yCordinate = secondNumber;
            }
            Graphics canvas = e.Graphics;
            canvas.FillEllipse(Brushes.LimeGreen, new RectangleF(xCordinate, yCordinate, 50 , 50));
            int firstAppleXRandom = random.Next(10, GameArea.Width - 10);
            if (firstAppleX==0)
            {
                firstAppleX = firstAppleXRandom;
            }
            int firstAppleYRandom = random.Next(10, GameArea.Height - 10);
            if (firstAppleY==0)
            {
                firstAppleY = firstAppleYRandom;
            }
            Graphics apple = e.Graphics;
            apple.FillEllipse(Brushes.BlueViolet, new RectangleF(firstAppleX,firstAppleY,10,10));
        }

        private void KeyDown0(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode==Keys.Up)
            {
                yCordinate -= 10;                
            }
            else if (e.KeyCode == Keys.Down)
            {
                yCordinate += 10;
            }
            else if (e.KeyCode == Keys.Left)
            {
                xCordinate -= 10;
            }
            else if (e.KeyCode == Keys.Right)
            {
                xCordinate += 10;

            }
            GameArea.Invalidate();
            if (xCordinate < 0 | xCordinate>GameArea.Width-50 | yCordinate<0 | yCordinate>GameArea.Height-50)
            {
                MessageBox.Show("ты сломался");
                //GameArea.Invalidate();
            }
        }
    }
}
