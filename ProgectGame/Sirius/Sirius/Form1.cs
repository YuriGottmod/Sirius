using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Sirius
{
    public partial class Form1 : Form
    {
        private SoundPlayer _soundPlayer;
        public Form1()
        {
            InitializeComponent();
            _soundPlayer = new SoundPlayer("z_uk-truba.wav");
            _soundPlayer.Play();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            _soundPlayer.Stop();
            pictureBox1.Dispose();
            
            Menu mainMenu = new Menu();
            mainMenu.Show();
            this.Hide();
        }
    }
}
