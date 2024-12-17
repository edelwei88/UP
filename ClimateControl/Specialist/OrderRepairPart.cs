using DBController;
using DBController.Models;

namespace ClimateControl.Specialist
{
    public partial class OrderRepairPart : Form
    {
        Database db;
        int userID;
        List<Request> requests;

        public OrderRepairPart(Database db, string login)
        {
            InitializeComponent();
            this.db = db;
            userID = db.GetUserIdByLogin(login);
            requests = db.GetAllRequests().Where(req => req.masterData.HasValue && req.masterData.Value.Key == userID).ToList();

            foreach (Request req in requests)
                comboBoxRequests.Items.Add(req.requestID);
            if (comboBoxRequests.Items.Count > 0)
                comboBoxRequests.SelectedIndex = 0;
        }

        private void OrderRepairPart_Load(object sender, EventArgs e)
        {
            if (requests.Count == 0)
            {
                MessageBox.Show("У вас нет заявок", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
                return;
            }
        }

        private void buttonOrderRepairPart_Click(object sender, EventArgs e)
        {
            db.OrderRepairPart(int.Parse(comboBoxRequests.Text), richTextBox1.Text);
            MessageBox.Show("Деталь успешно заказана", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void buttonClose_Click(object sender, EventArgs e)
            => Close();
    }
}
