namespace ClimateControl
{
    partial class History
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(History));
            dataGridView1 = new DataGridView();
            buttonClose = new Button();
            labelCount = new Label();
            comboBoxLoginFilter = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView1.Size = new Size(360, 337);
            dataGridView1.TabIndex = 0;
            // 
            // buttonClose
            // 
            buttonClose.Font = new Font("Segoe UI", 12F);
            buttonClose.Location = new Point(12, 415);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(64, 34);
            buttonClose.TabIndex = 1;
            buttonClose.Text = "OK";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // labelCount
            // 
            labelCount.AutoSize = true;
            labelCount.Location = new Point(334, 352);
            labelCount.Name = "labelCount";
            labelCount.Size = new Size(37, 15);
            labelCount.TabIndex = 2;
            labelCount.Text = "0 из 0";
            // 
            // comboBoxLoginFilter
            // 
            comboBoxLoginFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxLoginFilter.FormattingEnabled = true;
            comboBoxLoginFilter.Location = new Point(240, 398);
            comboBoxLoginFilter.MaxDropDownItems = 100;
            comboBoxLoginFilter.Name = "comboBoxLoginFilter";
            comboBoxLoginFilter.Size = new Size(133, 23);
            comboBoxLoginFilter.TabIndex = 3;
            comboBoxLoginFilter.SelectionChangeCommitted += comboBoxLoginFilter_SelectionChangeCommitted;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(240, 380);
            label1.Name = "label1";
            label1.Size = new Size(133, 15);
            label1.TabIndex = 4;
            label1.Text = "Фильтрация по логину";
            // 
            // History
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(193, 176, 152);
            ClientSize = new Size(384, 461);
            Controls.Add(label1);
            Controls.Add(comboBoxLoginFilter);
            Controls.Add(labelCount);
            Controls.Add(buttonClose);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "History";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "История входа";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonClose;
        private Label labelCount;
        private ComboBox comboBoxLoginFilter;
        private Label label1;
    }
}