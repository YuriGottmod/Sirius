using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sirius.formsPages
{
    public partial class StartPosition : Form
    {
        public StartPosition()
        {
            InitializeComponent();
        }

        

        private void btnMenu_Click(object sender, EventArgs e)
        {
            //выход в меню
            Menu mainMenu = new Menu();
            mainMenu.Show();
            this.Hide();
        }

        private void btnOtparavkaKonvoi_Click(object sender, EventArgs e)
        {
            //отправиться с конвоем

        }

        private void btnOtparvkaSolo_Click(object sender, EventArgs e)
        {
            //отправиться одному
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            string path = @"save.txt";   // путь к файлу

            string text = "1"; // строка для записи

            // запись в файл
            using (FileStream fstream = new FileStream(path, FileMode.OpenOrCreate))
            {
                // преобразуем строку в байты
                byte[] buffer = Encoding.Default.GetBytes(text);
                // запись массива байтов в файл
                await fstream.WriteAsync(buffer, 0, buffer.Length);
            }
        }
    }
}
