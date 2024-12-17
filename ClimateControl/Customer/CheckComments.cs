using DBController;
using System;
using System.Collections.Generic;
using DBController.Models;

namespace ClimateControl.Customer
{
    public partial class CheckComments : Form
    {
        Database db;
        int userID;
        List<Request> requests;
        Dictionary<int, Comment> comments;
        public CheckComments(Database db, string login)
        {
            InitializeComponent();

            this.db = db;
            userID = db.GetUserIdByLogin(login);
            requests = db.GetAllRequests().Where(req => req.clientData.Key == userID).ToList();
            comments = db.GetAllComments();

            dataGridView.Columns.Add("Comment", "Комментарий");

            foreach (Request request in requests)
                comboBoxRequests.Items.Add(request.requestID);
            if (comboBoxRequests.Items.Count > 0)
                comboBoxRequests.SelectedIndex = 0;
        }

        private void CheckComments_Load(object sender, EventArgs e)
        {
            if (requests.Count == 0)
            {
                MessageBox.Show("Нет заявок", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
                return;
            }

            comboBox1_SelectionChangeCommitted(sender, e);
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();

            foreach (var comment in comments.Where(com => com.Value.RequestID == int.Parse(comboBoxRequests.Text)).ToDictionary())
                dataGridView.Rows.Add(comment.Value.Message);

            labelCount.Text = dataGridView.Rows.Count.ToString() + " из " + dataGridView.Rows.Count.ToString();
        }

        private void buttonClose_Click(object sender, EventArgs e)
            => Close();
    }
}
