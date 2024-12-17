namespace ClimateControl.Operator
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
            buttonExtend = new Button();
            labelCount = new Label();
            comboBoxSpecialist = new ComboBox();
            dateTimePicker = new DateTimePicker();
            labelFilter = new Label();
            textBoxFilter = new TextBox();
            label1 = new Label();
            labelAverage = new Label();
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
            dataGridView.Location = new Point(12, 138);
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
            buttonSetMaster.Location = new Point(12, 572);
            buttonSetMaster.Name = "buttonSetMaster";
            buttonSetMaster.Size = new Size(373, 53);
            buttonSetMaster.TabIndex = 2;
            buttonSetMaster.Text = "Назначить специалиста";
            buttonSetMaster.UseVisualStyleBackColor = true;
            buttonSetMaster.Click += buttonSetMaster_Click;
            // 
            // buttonExtend
            // 
            buttonExtend.Location = new Point(395, 572);
            buttonExtend.Name = "buttonExtend";
            buttonExtend.Size = new Size(373, 53);
            buttonExtend.TabIndex = 3;
            buttonExtend.Text = "Изменить дату";
            buttonExtend.UseVisualStyleBackColor = true;
            buttonExtend.Click += buttonExtend_Click;
            // 
            // labelCount
            // 
            labelCount.AutoSize = true;
            labelCount.Location = new Point(683, 472);
            labelCount.Name = "labelCount";
            labelCount.Size = new Size(85, 21);
            labelCount.TabIndex = 4;
            labelCount.Text = "labelCount";
            // 
            // comboBoxSpecialist
            // 
            comboBoxSpecialist.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSpecialist.FormattingEnabled = true;
            comboBoxSpecialist.Location = new Point(12, 537);
            comboBoxSpecialist.MaxDropDownItems = 100;
            comboBoxSpecialist.Name = "comboBoxSpecialist";
            comboBoxSpecialist.Size = new Size(373, 29);
            comboBoxSpecialist.TabIndex = 5;
            // 
            // dateTimePicker
            // 
            dateTimePicker.CustomFormat = "";
            dateTimePicker.Format = DateTimePickerFormat.Short;
            dateTimePicker.Location = new Point(395, 537);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(373, 29);
            dateTimePicker.TabIndex = 7;
            // 
            // labelFilter
            // 
            labelFilter.AutoSize = true;
            labelFilter.Location = new Point(12, 472);
            labelFilter.Name = "labelFilter";
            labelFilter.Size = new Size(63, 21);
            labelFilter.TabIndex = 8;
            labelFilter.Text = "Фильтр";
            // 
            // textBoxFilter
            // 
            textBoxFilter.Location = new Point(12, 502);
            textBoxFilter.Name = "textBoxFilter";
            textBoxFilter.Size = new Size(756, 29);
            textBoxFilter.TabIndex = 9;
            textBoxFilter.TextChanged += textBoxFilter_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(372, 72);
            label1.Name = "label1";
            label1.Size = new Size(60, 21);
            label1.TabIndex = 10;
            label1.Text = "Заявки";
            // 
            // labelAverage
            // 
            labelAverage.AutoSize = true;
            labelAverage.Location = new Point(12, 114);
            labelAverage.Name = "labelAverage";
            labelAverage.Size = new Size(70, 21);
            labelAverage.TabIndex = 11;
            labelAverage.Text = "labelAvg";
            // 
            // Requests
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(193, 176, 152);
            ClientSize = new Size(780, 635);
            Controls.Add(labelAverage);
            Controls.Add(label1);
            Controls.Add(textBoxFilter);
            Controls.Add(labelFilter);
            Controls.Add(dateTimePicker);
            Controls.Add(comboBoxSpecialist);
            Controls.Add(labelCount);
            Controls.Add(buttonExtend);
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
        private Button buttonExtend;
        private Label labelCount;
        private ComboBox comboBoxSpecialist;
        private DateTimePicker dateTimePicker;
        private Label labelFilter;
        private TextBox textBoxFilter;
        private Label label1;
        private Label labelAverage;
    }
}