namespace ClimateControl.Customer
{
    partial class CreateRequest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateRequest));
            richTextBox = new RichTextBox();
            buttonClose = new Button();
            labelProblemDescription = new Label();
            labelTechType = new Label();
            comboBoxTechType = new ComboBox();
            labelTechModel = new Label();
            comboBoxTechModel = new ComboBox();
            buttonSendQuery = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // richTextBox
            // 
            richTextBox.Font = new Font("Segoe UI", 12F);
            richTextBox.Location = new Point(12, 149);
            richTextBox.Name = "richTextBox";
            richTextBox.Size = new Size(431, 141);
            richTextBox.TabIndex = 0;
            richTextBox.Text = "";
            // 
            // buttonClose
            // 
            buttonClose.Font = new Font("Segoe UI", 12F);
            buttonClose.Location = new Point(12, 12);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(80, 50);
            buttonClose.TabIndex = 1;
            buttonClose.Text = "Назад";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // labelProblemDescription
            // 
            labelProblemDescription.AutoSize = true;
            labelProblemDescription.Font = new Font("Segoe UI", 12F);
            labelProblemDescription.Location = new Point(12, 125);
            labelProblemDescription.Name = "labelProblemDescription";
            labelProblemDescription.Size = new Size(159, 21);
            labelProblemDescription.TabIndex = 2;
            labelProblemDescription.Text = "Описание проблемы";
            // 
            // labelTechType
            // 
            labelTechType.AutoSize = true;
            labelTechType.Font = new Font("Segoe UI", 12F);
            labelTechType.Location = new Point(12, 309);
            labelTechType.Name = "labelTechType";
            labelTechType.Size = new Size(98, 21);
            labelTechType.TabIndex = 3;
            labelTechType.Text = "Вид техники";
            // 
            // comboBoxTechType
            // 
            comboBoxTechType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTechType.Font = new Font("Segoe UI", 12F);
            comboBoxTechType.FormattingEnabled = true;
            comboBoxTechType.Location = new Point(12, 333);
            comboBoxTechType.Name = "comboBoxTechType";
            comboBoxTechType.Size = new Size(431, 29);
            comboBoxTechType.TabIndex = 4;
            comboBoxTechType.SelectionChangeCommitted += comboBoxTechType_SelectionChangeCommitted;
            // 
            // labelTechModel
            // 
            labelTechModel.AutoSize = true;
            labelTechModel.Font = new Font("Segoe UI", 12F);
            labelTechModel.Location = new Point(12, 386);
            labelTechModel.Name = "labelTechModel";
            labelTechModel.Size = new Size(144, 21);
            labelTechModel.TabIndex = 5;
            labelTechModel.Text = "Название прибора";
            // 
            // comboBoxTechModel
            // 
            comboBoxTechModel.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTechModel.Font = new Font("Segoe UI", 12F);
            comboBoxTechModel.FormattingEnabled = true;
            comboBoxTechModel.Location = new Point(12, 410);
            comboBoxTechModel.Name = "comboBoxTechModel";
            comboBoxTechModel.Size = new Size(431, 29);
            comboBoxTechModel.TabIndex = 6;
            // 
            // buttonSendQuery
            // 
            buttonSendQuery.Font = new Font("Segoe UI", 12F);
            buttonSendQuery.Location = new Point(12, 496);
            buttonSendQuery.Name = "buttonSendQuery";
            buttonSendQuery.Size = new Size(431, 49);
            buttonSendQuery.TabIndex = 7;
            buttonSendQuery.Text = "Отправить заявку";
            buttonSendQuery.UseVisualStyleBackColor = true;
            buttonSendQuery.Click += buttonSendQuery_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(169, 76);
            label1.Name = "label1";
            label1.Size = new Size(119, 21);
            label1.TabIndex = 8;
            label1.Text = "Создать заявку";
            // 
            // CreateRequest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(193, 176, 152);
            ClientSize = new Size(455, 557);
            Controls.Add(label1);
            Controls.Add(buttonSendQuery);
            Controls.Add(comboBoxTechModel);
            Controls.Add(labelTechModel);
            Controls.Add(comboBoxTechType);
            Controls.Add(labelTechType);
            Controls.Add(labelProblemDescription);
            Controls.Add(buttonClose);
            Controls.Add(richTextBox);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "CreateRequest";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Создать заявку";
            Load += CreateQuery_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox;
        private Button buttonClose;
        private Label labelProblemDescription;
        private Label labelTechType;
        private ComboBox comboBoxTechType;
        private Label labelTechModel;
        private ComboBox comboBoxTechModel;
        private Button buttonSendQuery;
        private Label label1;
    }
}