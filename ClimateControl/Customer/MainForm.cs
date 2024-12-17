using DBController;
namespace ClimateControl.Customer
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

        private void buttonCreateQuery_Click(object sender, EventArgs e)
        {
            using (var form = new CreateRequest(db, login))
            {
                Hide();
                form.ShowDialog();
                Show();
            }
        }

        private void buttonEditQuery_Click(object sender, EventArgs e)
        {
            using (var form = new EditRequest(db, login))
            {
                Hide();
                form.ShowDialog();
                Show();
            }
        }
        private void buttonCheckComments_Click(object sender, EventArgs e)
        {
            using (var form = new CheckComments(db, login))
            {
                Hide();
                form.ShowDialog();
                Show();
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
            => Close();

        private void buttonQRCode_Click(object sender, EventArgs e)
        {
            using (var form = new QRCode())
            {
                Hide();
                form.ShowDialog();
                Show();
            }
        }
    }
}
