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
    public partial class Lose : Form
    {
        public Lose()
        {
            InitializeComponent();
        }


        private void Lose_Load(object sender, EventArgs e)
        {
            ControlBox = false;
            score.Text = Convert.ToString(OpenClass.Count);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(500, 150);
            Properties.Settings.Default.records = OpenClass.record_;
            Properties.Settings.Default.Save();
            record.Text= Convert.ToString(OpenClass.record_);
        }

     
        private void continueGam_Click(object sender, EventArgs e)
        {
            this.Hide();
            The_Snake_Field theSnake_NormalMode = new The_Snake_Field();
            theSnake_NormalMode.ShowDialog();
            this.Close();
        }

        private void finishGan_Click(object sender, EventArgs e)
        {
            mainMenu menu = new mainMenu();
            menu.Visible = true;
            this.Close();
        }
    }
}
