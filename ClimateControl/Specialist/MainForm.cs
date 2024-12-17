using DBController;
namespace ClimateControl.Specialist
{
    public partial class MainForm : Form
    {
        Database db;
        readonly string login;

        public MainForm(Database db, string login)
        {
            InitializeComponent();
            this.db = db;
            this.login = login;

            var name = db.GetUserNameByLogin(login).Split(' ');
            labelName.Text = "ФИ: " + name[0] + ' ' + name[1];
        }

        private void buttonClose_Click(object sender, EventArgs e)
            => Close();

        private void buttonManageRequests_Click(object sender, EventArgs e)
        {
            using (var form = new ManageRequests(db, login))
            {
                Hide();
                form.ShowDialog();
                Show();
            }

        }

        private void buttonCreateComment_Click(object sender, EventArgs e)
        {
            using (var form = new LeaveComment(db, login))
            {
                Hide();
                form.ShowDialog();
                Show();
            }
        }

        private void buttonOrderRepairParts_Click(object sender, EventArgs e)
        {
            using (var form = new OrderRepairPart(db, login))
            {
                Hide();
                form.ShowDialog();
                Show();
            }
        }
    }
}
