using System;
using System.IO;
using System.Media;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace minigames
{
    public partial class NicknameForm : Form
    {
        private static SoundPlayer _player;
        private static string _currentTrack;

        public NicknameForm()
        {
            InitializeComponent();
            this.Shown += (s, e) => PlaySoundtrack();
        }

        // Обработчики событий, которые объявлены в дизайнере
        private void NicknameTextBox_TextChanged(object sender, EventArgs e)
        {
            // Логика обработки изменения текста (если нужно)
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Логика обработки клика по label1 (если нужно)
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidateNickname())
                return;

            var mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private bool ValidateNickname()
        {
            string nickname = NicknameTextBox.Text.Trim();

            if (string.IsNullOrEmpty(nickname))
            {
                MessageBox.Show("Никнейм не может быть пустым!", "Ошибка",
                             MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Regex.IsMatch(nickname, @"^[a-zA-Z0-9]+$"))
            {
                MessageBox.Show("Допустимы только латинские буквы и цифры!", "Ошибка",
                             MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void PlaySoundtrack()
        {
            string audioPath = Path.Combine(Application.StartupPath, "music.wav");

            try
            {
                if (_player != null && _currentTrack == audioPath)
                    return;

                if (_player != null)
                {
                    _player.Stop();
                    _player.Dispose();
                }

                if (!File.Exists(audioPath))
                {
                    MessageBox.Show("Файл музыки не найден!", "Ошибка",
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _currentTrack = audioPath;
                _player = new SoundPlayer(audioPath);
                _player.PlayLooping();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка воспроизведения: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
            base.OnFormClosing(e);
        }
    }
}
