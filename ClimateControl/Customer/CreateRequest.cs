using DBController;

namespace ClimateControl.Customer
{
    public partial class CreateRequest : Form
    {
        Database db;
        int userID;
        Dictionary<int, string> requstStatuses;
        Dictionary<int, string> types;
        Dictionary<int, string> models;

        public CreateRequest(Database db, string login)
        {
            InitializeComponent();

            this.db = db;
            requstStatuses = db.GetRequestStatuses();
            types = db.GetTechTypes();
            userID = db.GetUserIdByLogin(login);
            models = new();

            foreach (var type in types)
                comboBoxTechType.Items.Add(type.Value);
            comboBoxTechType.SelectedIndex = 0;
        }

        private void CreateQuery_Load(object sender, EventArgs e)
            => comboBoxTechType_SelectionChangeCommitted(sender, e);

        private void comboBoxTechType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBoxTechModel.Items.Clear();
            models = db.GetTechModelsByType(types.First(kvp => kvp.Value == comboBoxTechType.Text));

            foreach (var model in models)
                comboBoxTechModel.Items.Add(model.Value);
            comboBoxTechModel.SelectedIndex = 0;
        }

        private void buttonSendQuery_Click(object sender, EventArgs e)
        {
            if (richTextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Введите описание проблемы.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                db.CreateRequest(DateTime.Now, richTextBox.Text, null, 1, models.First(kvp => kvp.Value == comboBoxTechModel.Text).Key, null, userID);
                MessageBox.Show("Заявка успешно отправлена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
            => Close();
    }
}
