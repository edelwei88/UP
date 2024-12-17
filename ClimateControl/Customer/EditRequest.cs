using DBController;
using DBController.Models;
using System.Xml;

namespace ClimateControl.Customer
{
    public partial class EditRequest : Form
    {
        Database db;
        int userID;
        List<Request> requests;
        Dictionary<int, string> types;
        Dictionary<int, string> models;

        public EditRequest(Database db, string login)
        {
            InitializeComponent();
            this.db = db;
            userID = db.GetUserIdByLogin(login);
            requests = db.GetAllRequests().Where(req => req.clientData.Key == userID && req.completionDate == null && req.requestStatus.Key != 3).ToList();

            types = db.GetTechTypes();
            models = new();

            foreach (var request in requests)
                comboBoxRequest.Items.Add(request.requestID);
            if (comboBoxRequest.Items.Count > 0)
                comboBoxRequest.SelectedIndex = 0;

            foreach (var type in types)
                comboBoxTechType.Items.Add(type.Value);
        }

        private void EditRequest_Load(object sender, EventArgs e)
        {
            if (requests.Count == 0)
            {
                MessageBox.Show("Заявок нет", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
                return;
            }

            comboBoxRequest_SelectionChangeCommitted(sender, e);
        }

        private void comboBoxRequest_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var req = requests.First(req => req.requestID == int.Parse(comboBoxRequest.Text));

            labelStartDate.Text = "Дата заявки: " + req.startDate.ToLocalTime().Date.ToString("dd.MM.yyyy");
            labelRequestStatus.Text = "Статус завки: " + req.requestStatus.Value;
            labelMasterName.Text = "Имя мастера: " + (req.masterData.HasValue ? req.masterData.Value.Value : "Нет");

            comboBoxTechType.SelectedItem = req.techType.Value;
            comboBoxTechType_SelectionChangeCommitted(sender, e);

            comboBoxTechModel.SelectedItem = req.techModel.Value;

            richTextBox.Text = req.problemDescription;
        }

        private void comboBoxTechType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBoxTechModel.Items.Clear();
            models = db.GetTechModelsByType(types.First(type => type.Value == comboBoxTechType.Text));

            foreach (var model in models)
                comboBoxTechModel.Items.Add(model.Value);
            comboBoxTechModel.SelectedIndex = 0;

        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            db.EditRequest(int.Parse(comboBoxRequest.Text), richTextBox.Text, models.First(model => model.Value == comboBoxTechModel.Text).Key);
            MessageBox.Show("Заявка успешно отредактирована", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void buttonClose_Click(object sender, EventArgs e)
            => Close();
    }
}
