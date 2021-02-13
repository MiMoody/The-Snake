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
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
        }
       
        private void mainMenu_Load(object sender, EventArgs e)
        {

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(500, 150);
            ControlBox = false;
            OpenClass.record_ = 0;
            OpenClass.record_=  Properties.Settings.Default.records;
               
        }

        private void normalMode_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            OpenClass.mode = true;
            The_Snake_Field theSnake_NormalMode = new The_Snake_Field();
            theSnake_NormalMode.ShowDialog();
            
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void freeMode_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            OpenClass.mode = false;
            The_Snake_Field theSnake_NormalMode = new The_Snake_Field();
            theSnake_NormalMode.ShowDialog();
            

        }
    }
}
