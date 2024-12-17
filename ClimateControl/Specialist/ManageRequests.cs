using DBController;
using DBController.Models;
using System.Text;

namespace ClimateControl.Specialist
{
    public partial class ManageRequests : Form
    {
        Database db;
        int userID;
        List<Request> requests;


        private void UpdateLabelCount()
            => labelCount.Text = dataGridView.Rows.GetRowCount(DataGridViewElementStates.Visible).ToString() + " из " + dataGridView.Rows.Count;

        public ManageRequests(Database db, string login)
        {
            InitializeComponent();

            this.db = db;
            userID = db.GetUserIdByLogin(login);
            requests = db.GetAllRequests().Where(req => req.masterData.HasValue && req.masterData.Value.Key == userID).ToList();

            dataGridView.Columns.Add("requestID", "Номер заявки");
            dataGridView.Columns.Add("startDate", "Дата начала");
            dataGridView.Columns.Add("problemDescription", "Описание проблемы");
            dataGridView.Columns.Add("completionDate", "Дата окончания");
            dataGridView.Columns.Add("requestStatus", "Статус заявки");
            dataGridView.Columns.Add("techModel", "Модель техники");
            dataGridView.Columns.Add("master", "Имя мастера");
            dataGridView.Columns.Add("client", "Имя клиента");

            foreach (var req in requests)
                dataGridView.Rows.Add(req.requestID, req.startDate.ToLocalTime().ToString("dd.MM.yyyy"), req.problemDescription, req.completionDate.HasValue ? req.completionDate.Value.ToLocalTime().ToString("dd.MM.yyyy") : "Нет", req.requestStatus.Value, req.techModel.Value, req.masterData.Value.Value, req.clientData.Value);
            UpdateLabelCount();

        }
        private void ManageRequests_Load(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count == 0)
            {
                MessageBox.Show("Заявок нет", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
                return;
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
            => Close();

        private void buttonFinish_Click(object sender, EventArgs e)
        {
            dataGridView.SelectedCells[4].Value = "Готова к выдаче";
            db.FinishRequest((int)dataGridView.SelectedCells[0].Value);
        }

        private void buttonCreateReport_Click(object sender, EventArgs e)
        {
            string path = $".\\report_for_{dataGridView.SelectedCells[0].Value}";
            if (File.Exists(path))
            {
                MessageBox.Show("Отчет уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                using (var str = File.Create(path))
                {
                    foreach (DataGridViewCell cell in dataGridView.SelectedCells)
                    {
                        byte[] data = new UTF8Encoding(true).GetBytes(cell.Value.ToString() + "\n\r");
                        str.Write(data, 0, data.Length);
                    }
                }
                MessageBox.Show("Отчет успешно создан", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
