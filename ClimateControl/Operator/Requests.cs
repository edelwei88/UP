using DBController;
using DBController.Models;
using ExecLib;

namespace ClimateControl.Operator
{
    public partial class Requests : Form
    {
        Database db;
        List<Request> requests;
        Dictionary<int, string> specialists;
        
        private void UpdateLabelCount()
            => labelCount.Text = dataGridView.Rows.GetRowCount(DataGridViewElementStates.Visible).ToString() + " из " + dataGridView.Rows.Count;

        public Requests(Database db)
        {
            InitializeComponent();

            this.db = db;
            requests = db.GetAllRequests().ToList();

            specialists = db.GetAllSpecialists();
            foreach (var spec in specialists)
                comboBoxSpecialist.Items.Add(spec.Value);
            if (comboBoxSpecialist.Items.Count > 0)
                comboBoxSpecialist.SelectedIndex = 0;


            dataGridView.Columns.Add("requestID", "Номер заявки");
            dataGridView.Columns.Add("startDate", "Дата начала");
            dataGridView.Columns.Add("problemDescription", "Описание проблемы");
            dataGridView.Columns.Add("completionDate", "Дата окончания");
            dataGridView.Columns.Add("requestStatus", "Статус заявки");
            dataGridView.Columns.Add("techModel", "Модель техники");
            dataGridView.Columns.Add("master", "Имя специалиста");
            dataGridView.Columns.Add("client", "Имя клиента");

            foreach (var req in requests)
                dataGridView.Rows.Add(req.requestID, req.startDate.ToLocalTime().ToString("dd.MM.yyyy"), req.problemDescription, req.completionDate.HasValue ? req.completionDate.Value.ToLocalTime().ToString("dd.MM.yyyy") : "Нет", req.requestStatus.Value, req.techModel.Value, req.masterData.HasValue ? req.masterData.Value.Value : "Нет", req.clientData.Value);

            UpdateLabelCount();
            labelAverage.Text = $"Среднее время выполнения заявок: {Exec.GetAvgTime(requests)} дней";
        }

        private void Requests_Load(object sender, EventArgs e)
        {
            if (requests.Count == 0)
            {
                MessageBox.Show("Заявок нет", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
            => Close();

        private void buttonSetMaster_Click(object sender, EventArgs e)
        {
            db.SetMasterForRequest((int)dataGridView.SelectedCells[0].Value, specialists.First(spec => spec.Value == comboBoxSpecialist.Text).Key);
            dataGridView.SelectedCells[6].Value = comboBoxSpecialist.Text;
        }

        private void buttonExtend_Click(object sender, EventArgs e)
        {
            db.SetDateForRequest((int)dataGridView.SelectedCells[0].Value, dateTimePicker.Value);
            dataGridView.SelectedCells[3].Value = dateTimePicker.Value.Date.ToString("dd.MM.yyyy");
        }

        private void textBoxFilter_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView.Rows.Count; i++)
                dataGridView.Rows[i].Visible = textBoxFilter.Text.Split(',').Select(str => str.Trim()).All(str => dataGridView.Rows[i].Cells.Cast<DataGridViewCell>().Any(str2 => str2.Value.ToString().Contains(str)));
            UpdateLabelCount();
        }
    }
}
