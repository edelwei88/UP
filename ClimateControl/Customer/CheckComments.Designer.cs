namespace ClimateControl.Customer
{
    partial class CheckComments
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckComments));
            buttonClose = new Button();
            labelRequest = new Label();
            comboBoxRequests = new ComboBox();
            dataGridView = new DataGridView();
            labelCount = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // buttonClose
            // 
            buttonClose.Font = new Font("Segoe UI", 12F);
            buttonClose.Location = new Point(12, 12);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(89, 42);
            buttonClose.TabIndex = 0;
            buttonClose.Text = "Назад";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // labelRequest
            // 
            labelRequest.AutoSize = true;
            labelRequest.Font = new Font("Segoe UI", 12F);
            labelRequest.Location = new Point(12, 120);
            labelRequest.Name = "labelRequest";
            labelRequest.Size = new Size(59, 21);
            labelRequest.TabIndex = 1;
            labelRequest.Text = "Заявка";
            // 
            // comboBoxRequests
            // 
            comboBoxRequests.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRequests.Font = new Font("Segoe UI", 12F);
            comboBoxRequests.FormattingEnabled = true;
            comboBoxRequests.Location = new Point(12, 144);
            comboBoxRequests.Name = "comboBoxRequests";
            comboBoxRequests.Size = new Size(134, 29);
            comboBoxRequests.TabIndex = 2;
            comboBoxRequests.SelectionChangeCommitted += comboBox1_SelectionChangeCommitted;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(12, 230);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersVisible = false;
            dataGridView.Size = new Size(556, 223);
            dataGridView.TabIndex = 3;
            // 
            // labelCount
            // 
            labelCount.AutoSize = true;
            labelCount.Location = new Point(503, 456);
            labelCount.Name = "labelCount";
            labelCount.Size = new Size(65, 15);
            labelCount.TabIndex = 4;
            labelCount.Text = "labelCount";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(210, 76);
            label1.Name = "label1";
            label1.Size = new Size(178, 21);
            label1.TabIndex = 5;
            label1.Text = "Оставить комментарий";
            // 
            // CheckComments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(193, 176, 152);
            ClientSize = new Size(580, 488);
            Controls.Add(label1);
            Controls.Add(labelCount);
            Controls.Add(dataGridView);
            Controls.Add(comboBoxRequests);
            Controls.Add(labelRequest);
            Controls.Add(buttonClose);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "CheckComments";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Комментарии";
            Load += CheckComments_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonClose;
        private Label labelRequest;
        private ComboBox comboBoxRequests;
        private DataGridView dataGridView;
        private Label labelCount;
        private Label label1;
    }
}