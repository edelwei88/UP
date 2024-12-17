using Newtonsoft.Json;
using System.ComponentModel;

namespace ClimateControl
{
    public partial class History : Form
    {
        List<UserData>? data;

        private void FillDataGridView()
        {
            const string path = @".\logger.dat";

            if (!File.Exists(path))
                return;
            if (File.ReadAllLines(path).Length == 0)
                return;

            data = JsonConvert.DeserializeObject<List<UserData>>(File.ReadAllText(path));

            if (data == null)
                return;

            dataGridView1.Columns.Add("Login", "Логин");
            dataGridView1.Columns.Add("Result", "Результат");
            dataGridView1.Columns.Add("Date", "Время входа");


            for (int i = 0; i < 2; i++)
                dataGridView1.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;

            foreach (var el in data)
                dataGridView1.Rows.Add(el.Login, el.Result ? "Успешно" : "Неуспешно", el.LoginDateTime.ToLocalTime());

            dataGridView1.Sort(dataGridView1.Columns[2], ListSortDirection.Descending);

            comboBoxLoginFilter.Items.Add("");
            foreach (var item in data)
                if (!comboBoxLoginFilter.Items.Contains(item.Login))
                    comboBoxLoginFilter.Items.Add(item.Login);

        }

        public History()
        {
            InitializeComponent();
            data = new List<UserData>();
            FillDataGridView();
            labelCount.Text = dataGridView1.Rows.Count + " из " + dataGridView1.Rows.Count;
        }

        private void buttonClose_Click(object sender, EventArgs e)
            => Close();

        private void comboBoxLoginFilter_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBoxLoginFilter.SelectedItem == null)
                return;

            dataGridView1.ClearSelection();
            foreach (DataGridViewRow r in dataGridView1.Rows)
                if (comboBoxLoginFilter.SelectedItem.ToString() == "")
                    dataGridView1.Rows[r.Index].Visible = true;
                else if (r.Cells[0].Value.ToString() == comboBoxLoginFilter.SelectedItem.ToString())
                    dataGridView1.Rows[r.Index].Visible = true;
                else dataGridView1.Rows[r.Index].Visible = false;

            labelCount.Text = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Visible) + " из " + dataGridView1.Rows.Count;
        }
    }
}
