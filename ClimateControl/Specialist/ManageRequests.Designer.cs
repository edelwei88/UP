namespace ClimateControl.Specialist
{
    partial class ManageRequests
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageRequests));
            buttonClose = new Button();
            dataGridView = new DataGridView();
            buttonFinish = new Button();
            buttonCreateReport = new Button();
            labelCount = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(12, 12);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(98, 40);
            buttonClose.TabIndex = 0;
            buttonClose.Text = "Назад";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(12, 126);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersVisible = false;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(756, 328);
            dataGridView.TabIndex = 1;
            // 
            // buttonFinish
            // 
            buttonFinish.Location = new Point(12, 460);
            buttonFinish.Name = "buttonFinish";
            buttonFinish.Size = new Size(124, 53);
            buttonFinish.TabIndex = 2;
            buttonFinish.Text = "Завершить заявку";
            buttonFinish.UseVisualStyleBackColor = true;
            buttonFinish.Click += buttonFinish_Click;
            // 
            // buttonCreateReport
            // 
            buttonCreateReport.Location = new Point(142, 460);
            buttonCreateReport.Name = "buttonCreateReport";
            buttonCreateReport.Size = new Size(150, 53);
            buttonCreateReport.TabIndex = 3;
            buttonCreateReport.Text = "Создать отчет";
            buttonCreateReport.UseVisualStyleBackColor = true;
            buttonCreateReport.Click += buttonCreateReport_Click;
            // 
            // labelCount
            // 
            labelCount.AutoSize = true;
            labelCount.Location = new Point(683, 460);
            labelCount.Name = "labelCount";
            labelCount.Size = new Size(85, 21);
            labelCount.TabIndex = 4;
            labelCount.Text = "labelCount";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(342, 57);
            label1.Name = "label1";
            label1.Size = new Size(60, 21);
            label1.TabIndex = 5;
            label1.Text = "Заявки";
            // 
            // ManageRequests
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(193, 176, 152);
            ClientSize = new Size(780, 527);
            Controls.Add(label1);
            Controls.Add(labelCount);
            Controls.Add(buttonCreateReport);
            Controls.Add(buttonFinish);
            Controls.Add(dataGridView);
            Controls.Add(buttonClose);
            Font = new Font("Segoe UI", 12F);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "ManageRequests";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Заявки";
            Load += ManageRequests_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonClose;
        private DataGridView dataGridView;
        private Button buttonFinish;
        private Button buttonCreateReport;
        private Label labelCount;
        private Label label1;
    }
}