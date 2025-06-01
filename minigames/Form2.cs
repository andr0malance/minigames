using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minigames
{
    public partial class NicknameForm : Form
    {
        public NicknameForm()
        {
         PlaySoundtrack();         
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NicknameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nickname = NicknameTextBox.Text.Trim();

            // Проверка на пустоту
            if (string.IsNullOrEmpty(nickname))
            {
                MessageBox.Show("Никнейм не может быть пустым!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Проверка на латинские буквы и цифры
            if (!Regex.IsMatch(nickname, @"^[a-zA-Z0-9]+$"))
            {
                MessageBox.Show("Исключительно латиница и цифры!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MainForm mainForm = new MainForm();
            mainForm.Show(); 
            this.Hide();      
        }
        private void PlaySoundtrack()
        {
            string audioPath = "music.wav";

            if (!File.Exists(audioPath))
            {
                MessageBox.Show("Файл не найден!");
                return;
            }

            var player = new SoundPlayer(audioPath);
            player.PlayLooping();

        }

    }

    
}
