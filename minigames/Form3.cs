using System;
using System.Windows.Forms;

namespace minigames
{
    public partial class RecordsForm : Form
    {
        public RecordsForm()
        {
            InitializeComponent();
            SetupDataGridViewColumns();
            WireUpEvents();
        }

        private void SetupDataGridViewColumns()
        {
            // Очищаем существующие колонки
            dgvRecords.Columns.Clear();

            // Добавляем колонки
            dgvRecords.Columns.Add("Position", "Место");
            dgvRecords.Columns.Add("PlayerName", "Игрок");
            dgvRecords.Columns.Add("Score", "Очки");
            dgvRecords.Columns.Add("Date", "Дата");

            // Настраиваем ширину колонок
            dgvRecords.Columns["Position"].Width = 60;
            dgvRecords.Columns["PlayerName"].Width = 150;
            dgvRecords.Columns["Score"].Width = 80;
            dgvRecords.Columns["Date"].Width = 120;
        }

        private void WireUpEvents()
        {
            btnClose.Click += BtnClose_Click;
            Load += RecordsForm_Load;
        }

        private void RecordsForm_Load(object sender, EventArgs e)
        {
            // Метод для загрузки данных из БД
            LoadRecordsFromDatabase();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LoadRecordsFromDatabase()
        {
            // Очищаем существующие данные
            dgvRecords.Rows.Clear();

            // Здесь будет код для загрузки данных из БД
            // Пример:
            // var records = DatabaseService.GetRecords();
            // foreach (var record in records)
            // {
            //     dgvRecords.Rows.Add(record.Position, record.PlayerName, 
            //                        record.Score, record.Date.ToString("dd.MM.yyyy"));
            // }

            // Временный заглушка для тестирования
            dgvRecords.Rows.Add(1, "Тестовый игрок", 1000, DateTime.Now.ToString("dd.MM.yyyy"));
        }
    }
}