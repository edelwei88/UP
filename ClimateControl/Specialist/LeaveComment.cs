using DBController;
using DBController.Models;

namespace ClimateControl.Specialist
{
    public partial class LeaveComment : Form
    {
        Database db;
        int userID;
        List<Request> requests;

        public LeaveComment(Database db, string login)
        {
            InitializeComponent();
            this.db = db;
            userID = db.GetUserIdByLogin(login);
            requests = db.GetAllRequests().Where(req => req.masterData.HasValue && req.masterData.Value.Key == userID).ToList();

            foreach (Request req in requests)
                comboBoxComment.Items.Add(req.requestID);
            if (comboBoxComment.Items.Count > 0)
                comboBoxComment.SelectedIndex = 0;
        }

        private void LeaveComment_Load(object sender, EventArgs e)
        {
            if (requests.Count == 0)
            {
                MessageBox.Show("У вас нет заказов", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        private void buttonLeaveComment_Click(object sender, EventArgs e)
        {
            db.CreateComment(int.Parse(comboBoxComment.Text), richTextBox1.Text);
            MessageBox.Show("Комментарий успешно оставлен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void buttonClose_Click(object sender, EventArgs e)
            => Close();
    }
}
