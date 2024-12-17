namespace ClimateControl.Customer
{
    partial class EditRequest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditRequest));
            comboBoxRequest = new ComboBox();
            label1 = new Label();
            buttonEdit = new Button();
            labelStartDate = new Label();
            richTextBox = new RichTextBox();
            labelRequestStatus = new Label();
            labelMasterName = new Label();
            comboBoxTechType = new ComboBox();
            comboBoxTechModel = new ComboBox();
            labelTechType = new Label();
            labelTechModel = new Label();
            buttonClose = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // comboBoxRequest
            // 
            comboBoxRequest.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRequest.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxRequest.FormattingEnabled = true;
            comboBoxRequest.Location = new Point(12, 133);
            comboBoxRequest.Name = "comboBoxRequest";
            comboBoxRequest.Size = new Size(120, 29);
            comboBoxRequest.TabIndex = 0;
            comboBoxRequest.SelectionChangeCommitted += comboBoxRequest_SelectionChangeCommitted;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 109);
            label1.Name = "label1";
            label1.Size = new Size(110, 21);
            label1.TabIndex = 1;
            label1.Text = "Номер заявки";
            // 
            // buttonEdit
            // 
            buttonEdit.Font = new Font("Segoe UI", 12F);
            buttonEdit.Location = new Point(12, 434);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(135, 36);
            buttonEdit.TabIndex = 2;
            buttonEdit.Text = "Редактировать";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // labelStartDate
            // 
            labelStartDate.AutoSize = true;
            labelStartDate.Font = new Font("Segoe UI", 12F);
            labelStartDate.Location = new Point(12, 174);
            labelStartDate.Name = "labelStartDate";
            labelStartDate.Size = new Size(107, 21);
            labelStartDate.TabIndex = 3;
            labelStartDate.Text = "labelStartDate";
            // 
            // richTextBox
            // 
            richTextBox.Font = new Font("Segoe UI", 12F);
            richTextBox.Location = new Point(438, 262);
            richTextBox.Name = "richTextBox";
            richTextBox.Size = new Size(350, 208);
            richTextBox.TabIndex = 4;
            richTextBox.Text = "";
            // 
            // labelRequestStatus
            // 
            labelRequestStatus.AutoSize = true;
            labelRequestStatus.Font = new Font("Segoe UI", 12F);
            labelRequestStatus.Location = new Point(12, 213);
            labelRequestStatus.Name = "labelRequestStatus";
            labelRequestStatus.Size = new Size(141, 21);
            labelRequestStatus.TabIndex = 6;
            labelRequestStatus.Text = "labelRequestStatus";
            // 
            // labelMasterName
            // 
            labelMasterName.AutoSize = true;
            labelMasterName.Font = new Font("Segoe UI", 12F);
            labelMasterName.Location = new Point(12, 255);
            labelMasterName.Name = "labelMasterName";
            labelMasterName.Size = new Size(91, 21);
            labelMasterName.TabIndex = 7;
            labelMasterName.Text = "labelMaster";
            // 
            // comboBoxTechType
            // 
            comboBoxTechType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTechType.Font = new Font("Segoe UI", 12F);
            comboBoxTechType.FormattingEnabled = true;
            comboBoxTechType.Location = new Point(438, 148);
            comboBoxTechType.MaxDropDownItems = 100;
            comboBoxTechType.Name = "comboBoxTechType";
            comboBoxTechType.Size = new Size(350, 29);
            comboBoxTechType.TabIndex = 8;
            comboBoxTechType.SelectionChangeCommitted += comboBoxTechType_SelectionChangeCommitted;
            // 
            // comboBoxTechModel
            // 
            comboBoxTechModel.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTechModel.Font = new Font("Segoe UI", 12F);
            comboBoxTechModel.FormattingEnabled = true;
            comboBoxTechModel.Location = new Point(438, 213);
            comboBoxTechModel.MaxDropDownItems = 100;
            comboBoxTechModel.Name = "comboBoxTechModel";
            comboBoxTechModel.Size = new Size(350, 29);
            comboBoxTechModel.TabIndex = 9;
            // 
            // labelTechType
            // 
            labelTechType.AutoSize = true;
            labelTechType.Font = new Font("Segoe UI", 12F);
            labelTechType.Location = new Point(438, 124);
            labelTechType.Name = "labelTechType";
            labelTechType.Size = new Size(98, 21);
            labelTechType.TabIndex = 10;
            labelTechType.Text = "Вид техники";
            // 
            // labelTechModel
            // 
            labelTechModel.AutoSize = true;
            labelTechModel.Font = new Font("Segoe UI", 12F);
            labelTechModel.Location = new Point(438, 189);
            labelTechModel.Name = "labelTechModel";
            labelTechModel.Size = new Size(144, 21);
            labelTechModel.TabIndex = 11;
            labelTechModel.Text = "Название прибора";
            // 
            // buttonClose
            // 
            buttonClose.Font = new Font("Segoe UI", 12F);
            buttonClose.Location = new Point(12, 12);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(91, 42);
            buttonClose.TabIndex = 12;
            buttonClose.Text = "Назад";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(308, 60);
            label2.Name = "label2";
            label2.Size = new Size(187, 21);
            label2.TabIndex = 13;
            label2.Text = "Отредактировать заявку";
            // 
            // EditRequest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(193, 176, 152);
            ClientSize = new Size(800, 481);
            Controls.Add(label2);
            Controls.Add(buttonClose);
            Controls.Add(labelTechModel);
            Controls.Add(labelTechType);
            Controls.Add(comboBoxTechModel);
            Controls.Add(comboBoxTechType);
            Controls.Add(labelMasterName);
            Controls.Add(labelRequestStatus);
            Controls.Add(richTextBox);
            Controls.Add(labelStartDate);
            Controls.Add(buttonEdit);
            Controls.Add(label1);
            Controls.Add(comboBoxRequest);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "EditRequest";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Отредактировать заявку";
            Load += EditRequest_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxRequest;
        private Label label1;
        private Button buttonEdit;
        private Label labelStartDate;
        private RichTextBox richTextBox;
        private Label labelRequestStatus;
        private Label labelMasterName;
        private ComboBox comboBoxTechType;
        private ComboBox comboBoxTechModel;
        private Label labelTechType;
        private Label labelTechModel;
        private Button buttonClose;
        private Label label2;
    }
}