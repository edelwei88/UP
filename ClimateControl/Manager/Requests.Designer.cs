namespace ClimateControl.Manager
{
    partial class Requests
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Requests));
            buttonClose = new Button();
            dataGridView = new DataGridView();
            buttonSetMaster = new Button();
            labelCount = new Label();
            comboBoxSpecialist = new ComboBox();
            labelFilter = new Label();
            textBoxFilter = new TextBox();
            comboBoxStatuses = new ComboBox();
            buttonSetStatus = new Button();
            buttonDelete = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
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
            // buttonSetMaster
            // 
            buttonSetMaster.Location = new Point(12, 610);
            buttonSetMaster.Name = "buttonSetMaster";
            buttonSetMaster.Size = new Size(262, 53);
            buttonSetMaster.TabIndex = 2;
            buttonSetMaster.Text = "Обработать";
            buttonSetMaster.UseVisualStyleBackColor = true;
            buttonSetMaster.Click += buttonSetMaster_Click;
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
            // comboBoxSpecialist
            // 
            comboBoxSpecialist.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSpecialist.FormattingEnabled = true;
            comboBoxSpecialist.Location = new Point(12, 575);
            comboBoxSpecialist.MaxDropDownItems = 100;
            comboBoxSpecialist.Name = "comboBoxSpecialist";
            comboBoxSpecialist.Size = new Size(262, 29);
            comboBoxSpecialist.TabIndex = 5;
            // 
            // labelFilter
            // 
            labelFilter.AutoSize = true;
            labelFilter.Location = new Point(12, 460);
            labelFilter.Name = "labelFilter";
            labelFilter.Size = new Size(63, 21);
            labelFilter.TabIndex = 8;
            labelFilter.Text = "Фильтр";
            // 
            // textBoxFilter
            // 
            textBoxFilter.Location = new Point(12, 490);
            textBoxFilter.Name = "textBoxFilter";
            textBoxFilter.Size = new Size(756, 29);
            textBoxFilter.TabIndex = 9;
            textBoxFilter.TextChanged += textBoxFilter_TextChanged;
            // 
            // comboBoxStatuses
            // 
            comboBoxStatuses.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStatuses.FormattingEnabled = true;
            comboBoxStatuses.Location = new Point(280, 575);
            comboBoxStatuses.MaxDropDownItems = 100;
            comboBoxStatuses.Name = "comboBoxStatuses";
            comboBoxStatuses.Size = new Size(262, 29);
            comboBoxStatuses.TabIndex = 10;
            // 
            // buttonSetStatus
            // 
            buttonSetStatus.Location = new Point(280, 610);
            buttonSetStatus.Name = "buttonSetStatus";
            buttonSetStatus.Size = new Size(262, 53);
            buttonSetStatus.TabIndex = 11;
            buttonSetStatus.Text = "Установить статус";
            buttonSetStatus.UseVisualStyleBackColor = true;
            buttonSetStatus.Click += buttonSetStatus_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(548, 610);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(220, 53);
            buttonDelete.TabIndex = 12;
            buttonDelete.Text = "Удалить заявку";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 551);
            label1.Name = "label1";
            label1.Size = new Size(95, 21);
            label1.TabIndex = 13;
            label1.Text = "Специалист";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(280, 551);
            label2.Name = "label2";
            label2.Size = new Size(57, 21);
            label2.TabIndex = 14;
            label2.Text = "Статус";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(345, 61);
            label3.Name = "label3";
            label3.Size = new Size(60, 21);
            label3.TabIndex = 15;
            label3.Text = "Заявки";
            // 
            // Requests
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(193, 176, 152);
            ClientSize = new Size(780, 683);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonDelete);
            Controls.Add(buttonSetStatus);
            Controls.Add(comboBoxStatuses);
            Controls.Add(textBoxFilter);
            Controls.Add(labelFilter);
            Controls.Add(comboBoxSpecialist);
            Controls.Add(labelCount);
            Controls.Add(buttonSetMaster);
            Controls.Add(dataGridView);
            Controls.Add(buttonClose);
            Font = new Font("Segoe UI", 12F);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Requests";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Заявки";
            Load += Requests_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonClose;
        private DataGridView dataGridView;
        private Button buttonSetMaster;
        private Label labelCount;
        private ComboBox comboBoxSpecialist;
        private Label labelFilter;
        private TextBox textBoxFilter;
        private ComboBox comboBoxStatuses;
        private Button buttonSetStatus;
        private Button buttonDelete;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}