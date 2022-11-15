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
using Sirius.formsPages;
using System.IO;

namespace Sirius
{
    public partial class Menu : Form
    {
        SoundPlayer sp;
        public Menu()
        {
            InitializeComponent();
            sp = new SoundPlayer("menuThem.wav");
            sp.PlayLooping();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены что хотите выйти?", "Выйти", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            StartPosition startPosition = new StartPosition();
            startPosition.Show();

            Predistoria predistoria = new Predistoria();
            predistoria.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sp.Stop();
        }

        private async void btnLoad_Click(object sender, EventArgs e)
        {
            string path = @"save.txt";   // путь к файлу

            // чтение из файла
            using (FileStream fstream = File.OpenRead(path))
            {
                // выделяем массив для считывания данных из файла
                byte[] buffer = new byte[fstream.Length];
                // считываем данные
                await fstream.ReadAsync(buffer, 0, buffer.Length);
                // декодируем байты в строку
                string textFromFile = Encoding.Default.GetString(buffer);

                switch(textFromFile)
                {
                    case "1":
                        StartPosition startPosition = new StartPosition();
                        startPosition.Show();
                        this.Hide();
                        break;
                    default:
                        break;
                }
            }

        }
    }
}
