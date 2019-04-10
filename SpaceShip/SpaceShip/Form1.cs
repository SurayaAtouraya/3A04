using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SpaceShip
{
    public partial class form1 : Form
    {
        System.Media.SoundPlayer play = new System.Media.SoundPlayer();
        public form1()
        {
            InitializeComponent();
            play.SoundLocation  = "hypnotize.wav";
            play.Play();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Start_Click(object sender, EventArgs e)
        {
            Process.Start("SpaceShip_Game.exe");
            Application.Exit();
        }

        private void Setting_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.ShowDialog();
            this.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void form1_Load(object sender, EventArgs e)
        {

        }
    }
}
