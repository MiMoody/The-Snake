using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Snake
{
    public partial class The_Snake_Field : Form
    {
        Point[] snakeCoordinates;
        string snakeDirection = "Up";
        int snakeLenght = 1;
        int score;
        int clicksBtn = 0;
        SolidBrush backColor_Field;
        SolidBrush snakeColor;
        SolidBrush paintProduction;
        Point Production;
        Random randomCoordinatesProduction;
        public The_Snake_Field()
        {
            InitializeComponent();
            snakeCoordinates = new Point[1000];
            playField.Image = new Bitmap(playField.Width, playField.Height);
            backColor_Field = new SolidBrush(Color.FromArgb( 255,255,192));
            snakeColor = new SolidBrush(Color.Black);
            paintProduction = new SolidBrush(Color.Green);
            for (int i = 0; i < snakeLenght; i++)
            {
                snakeCoordinates[i].X = 250;
                snakeCoordinates[i].Y = 250 + i * 10;
            }
            randomCoordinatesProduction = new Random();
            Production.X = randomCoordinatesProduction.Next(0, 50) * 10;
            Production.Y = randomCoordinatesProduction.Next(0, 50) * 10;

        }

        private void updateField_Tick(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(playField.Image);
            g.FillRectangle(backColor_Field,0,0,playField.Width,playField.Height);

            g.FillEllipse(paintProduction, Production.X, Production.Y, 10, 10);

            for (int i=0; i<snakeLenght;i++)
            {
                g.FillEllipse(snakeColor, snakeCoordinates[i].X, snakeCoordinates[i].Y, 10, 10);
            }
            for (int i = snakeCoordinates.Length - 2; i >= 0; i--)
            {
                snakeCoordinates[i + 1].X = snakeCoordinates[i].X;
                snakeCoordinates[i + 1].Y = snakeCoordinates[i].Y;
            }

            if (snakeDirection == "Left")
            {
                snakeCoordinates[0].X -= 10;
            }
            if (snakeDirection == "Right")
            {
                snakeCoordinates[0].X += 10;
            }
            if (snakeDirection == "Up")
            {
                snakeCoordinates[0].Y -= 10;
            }
            if (snakeDirection == "Down")
            {
                snakeCoordinates[0].Y += 10;
            }
            if(snakeLenght>snakeCoordinates.Length-3)
            {
                snakeLenght = snakeCoordinates.Length - 3;
            }
            for (int i = 1; i < snakeLenght; i++)
            {
                if (snakeCoordinates[0].X == snakeCoordinates[i].X && snakeCoordinates[0].Y == snakeCoordinates[i].Y)
                {
                    updateField.Enabled = false;
                    OpenClass.Count = score;
                    this.Visible = false;
                    Lose lose = new Lose();
                    lose.ShowDialog();
                    this.Close();
                }
            }
                        
            if (Production.X == snakeCoordinates[0].X && Production.Y == snakeCoordinates[0].Y)
            {
                if (updateField.Interval>=150)
                {
                    updateField.Interval -= 50;
                }
                if (updateField.Interval <= 100 && updateField.Interval >= 60)
                {
                    updateField.Interval -= 8;
                }
                if (updateField.Interval <= 52 && updateField.Interval > 20)
                {
                    updateField.Interval -= 5;
                }

                snakeLenght++;
                score += 10;
                
                Production.X = randomCoordinatesProduction.Next(0, 50) * 10;
                Production.Y = randomCoordinatesProduction.Next(0, 50) * 10;
            }
            if (OpenClass.mode)
            {
                if (snakeCoordinates[0].X < 0 || snakeCoordinates[0].Y < 0 || snakeCoordinates[0].X > playField.Width - 10 || snakeCoordinates[0].Y > playField.Height - 10)
                {
                    updateField.Enabled = false;
                    OpenClass.Count = score;
                    this.Visible = false;
                    Lose lose = new Lose();
                    lose.ShowDialog();
                    this.Close();

                }
            }
            else
            {
                if (snakeCoordinates[0].X < 0)
                {
                    snakeCoordinates[0].X +=playField.Width;
                }
                if (snakeCoordinates[0].X > playField.Width)
                {
                    snakeCoordinates[0].X -= playField.Width;
                }
                if (snakeCoordinates[0].Y > playField.Height)
                {
                    snakeCoordinates[0].Y -= playField.Height;
                }
                if (snakeCoordinates[0].Y < 0)
                {
                    snakeCoordinates[0].Y += playField.Height;
                }


            }
            if(score > OpenClass.record_)
            {
                OpenClass.record_ = score;
            }
            forScore.Text = Convert.ToString(score);
            playField.Invalidate();

        }

        private void The_Snake_Field_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up)
            {
                snakeDirection = "Up";
            }
            if (e.KeyCode == Keys.Down)
            {
                snakeDirection = "Down";
            }
            if (e.KeyCode == Keys.Left)
            {
                snakeDirection = "Left";
            }
            if (e.KeyCode == Keys.Right)
            {
                snakeDirection = "Right";
            }
            if (e.KeyCode == Keys.Escape)
            {
                updateField.Stop();
                this.Close();
                mainMenu mainMenu = new mainMenu();
                mainMenu.Visible = true;
            }
            if (e.KeyCode == Keys.Space)
            {
                ++clicksBtn;
                switch (clicksBtn)
                {
                    case 1:
                        updateField.Stop();
                        break;
                    case 2:
                        updateField.Start();
                        break;
                }
                if (clicksBtn == 2)
                {
                    clicksBtn = 0;
                }



            }


        }

        private void The_Snake_Field_Load(object sender, EventArgs e)
        {
            ControlBox = false;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(500, 150);
        }
    }
}
