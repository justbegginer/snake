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
        int snakeWidth = 50;
        int snakeHeigth = 50;
        int yCordinate = 0;
        int firstAppleX = 0;
        int firstAppleY = 0;
        int score = 0;
        List<int> tailXCoordinate = new List<int>();
        List<int> tailYCoordinate = new List<int>(); 
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
            canvas.FillEllipse(Brushes.LimeGreen, new RectangleF(xCordinate, yCordinate, snakeWidth , snakeHeigth));
            GenerateApples();
            Graphics apple = e.Graphics;
            apple.FillEllipse(Brushes.BlueViolet, new RectangleF(firstAppleX,firstAppleY,10,10));
        }
        private void ArrayOfSnakeDetails()
        {

        }
        private void GenerateApples()
        {
            text.Text=Convert.ToString(score);
            Random random = new Random();
            int firstAppleXRandom = random.Next(10, GameArea.Width - 10);
            if (firstAppleX == 0)
            {
                firstAppleX = firstAppleXRandom;
            }
            int firstAppleYRandom = random.Next(10, GameArea.Height - 10);
            if (firstAppleY == 0)
            {
                firstAppleY = firstAppleYRandom;
            }
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
                MessageBox.Show("ты сломался ");

                //GameArea.Invalidate();
            }
            ApplesEating();
        }
        private void ApplesEating()
        {
            if (new Rectangle(xCordinate,yCordinate,50,50).IntersectsWith(new Rectangle(firstAppleX,firstAppleY,10,10)))
            {

                MessageBox.Show("Ням");
                score++;
                firstAppleX = 0;
                firstAppleY = 0;
                GenerateApples();
                GameArea.Invalidate();
            }
        }
        private void GenerateRandomForTail()
        {
            Random random = new Random();
            int computerChoice = random.Next(0,3);
            switch(computerChoice)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
            }
        }
        private void GenerateTail(int xCordinateForTail , int yCordinateForTail )
        {
            
        }
    }
}
