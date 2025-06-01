using System;
using System.Windows.Forms;

namespace minigames
{
    public partial class GameSelectionForm : Form
    {
        public GameSelectionForm()
        {
            InitializeComponent();
            this.FormClosing += (s, e) => Application.Exit(); // Закрытие приложения при закрытии формы
        }

        private void btnSnake_Click(object sender, EventArgs e)
        {
            OpenForm(new SnakeGameForm());
        }

        private void btnTanks_Click(object sender, EventArgs e)
        {
            OpenForm(new TanksGameForm());
        }

        private void btnRacing_Click(object sender, EventArgs e)
        {
            OpenForm(new RacingGameForm());
        }

        private void btnArkanoid_Click(object sender, EventArgs e)
        {
            OpenForm(new ArkanoidForm());
        }

        private void btnTetris_Click(object sender, EventArgs e)
        {
            OpenForm(new TetrisForm());
        }

        private void OpenForm(Form newForm)
        {
            try
            {
                // Настройка новой формы
                newForm.FormClosing += (s, e) => this.Show(); // Показываем меню при закрытии игры

                this.Hide(); // Скрываем текущую форму
                newForm.Show(); // Показываем новую форму (не как диалог!)
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Show();
            }
        }

        // Добавляем кнопку "Назад" (если нужно вернуться к NicknameForm)
        private void btnBack_Click(object sender, EventArgs e)
        {
            var nicknameForm = new NicknameForm();
            nicknameForm.Show();
            this.Close(); // Закрываем текущую форму
        }
    }
}