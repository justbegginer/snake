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
        List<Tail> Tail = new List<Tail>();
        //List<int> tailXCoordinate = new List<int>();
        //List<int> tailYCoordinate = new List<int>();
        //Tail snake_sTail = new Tail();
        string direction = "";
        public Form1()
        {
            InitializeComponent();
            //TimerWork.
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
            GenerateTail(canvas);
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
                direction = "up";
                //yCordinate -= 10;                
            }
            else if (e.KeyCode == Keys.Down)
            {
                direction = "down";
                //yCordinate += 10;
            }
            else if (e.KeyCode == Keys.Left)
            {
                direction = "left";
                //xCordinate -= 10;
            }
            else if (e.KeyCode == Keys.Right)
            {
                direction = "rigth";
                //xCordinate += 10;

            }
            GameArea.Invalidate();
            //if (xCordinate < 0 | xCordinate>GameArea.Width-50 | yCordinate<0 | yCordinate>GameArea.Height-50)
            //{
            //    MessageBox.Show("ты сломался ");               
            //}
            //ApplesEating();
        }
        //int intermidiate1 = 0, intermidiate2 = 0;
        private void ApplesEating()
        {
            if (new Rectangle(xCordinate,yCordinate,50,50).IntersectsWith(new Rectangle(firstAppleX,firstAppleY,10,10)))
            {
                score++;
                firstAppleX = 0;
                firstAppleY = 0;
                MessageBox.Show("Ням +"+Tail.Count);              
                GenerateApples();
                Tail partOfTail = new Tail(XcordinateForNewTail,YcordinateForNewTail);
                //РАБОЧЕЕ ДОБАВЛЕНИЕ ЭЛЕМЕНТА ИЗ СПИСКА
                //intermidiate1 += 10;
                //intermidiate2 += 10;
                Tail.Add(partOfTail);
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
        private void GenerateTail(Graphics canvas)
        {
            for (int counter = 0 ; counter<Tail.Count  ; counter++)
            {
                canvas.FillEllipse(Brushes.LimeGreen, new RectangleF(Tail[counter].X, Tail[counter].Y, snakeWidth, snakeHeigth));
            }
        }
        private void GenerateCordinateForTail()
        {
            switch (direction)
            {
                case "":

                    break;
                case "":
                    break;
                case "":
                    break;
                case "":
                    break;
            }
        }
        int XcordinateForNewTail=0, YcordinateForNewTail=0;
        private void WorkTimer(object sender, EventArgs e)
        {
            switch (direction)
            {
                case "up":
                    yCordinate -= 10;
                    break;
                case "down":
                    yCordinate += 10;
                    break;
                case "left":
                    xCordinate -=10;
                    break;
                case "rigth":
                    xCordinate += 10;
                    break;
                case "":
                    break;
            }
            GameArea.Invalidate();
            if (xCordinate < 0 | xCordinate > GameArea.Width - 50 | yCordinate < 0 | yCordinate > GameArea.Height - 50)
            {
                MessageBox.Show("ты сломался");
                //конец
            }
            ApplesEating();
        }
       

    }
    public class Tail
    {
        public int X;
        public int Y;
        public Tail(int x , int y)
        {
            X = x;
            Y = y;
        }
    }
}
