namespace ClimateControl.Specialist
{
    partial class OrderRepairPart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderRepairPart));
            buttonClose = new Button();
            labelRequest = new Label();
            comboBoxRequests = new ComboBox();
            richTextBox1 = new RichTextBox();
            buttonLeaveComment = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(12, 12);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(118, 37);
            buttonClose.TabIndex = 0;
            buttonClose.Text = "Назад";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // labelRequest
            // 
            labelRequest.AutoSize = true;
            labelRequest.Location = new Point(12, 154);
            labelRequest.Name = "labelRequest";
            labelRequest.Size = new Size(59, 21);
            labelRequest.TabIndex = 1;
            labelRequest.Text = "Заявка";
            // 
            // comboBoxRequests
            // 
            comboBoxRequests.FormattingEnabled = true;
            comboBoxRequests.Location = new Point(12, 178);
            comboBoxRequests.Name = "comboBoxRequests";
            comboBoxRequests.Size = new Size(131, 29);
            comboBoxRequests.TabIndex = 2;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 245);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(456, 228);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // buttonLeaveComment
            // 
            buttonLeaveComment.Location = new Point(12, 508);
            buttonLeaveComment.Name = "buttonLeaveComment";
            buttonLeaveComment.Size = new Size(190, 37);
            buttonLeaveComment.TabIndex = 4;
            buttonLeaveComment.Text = "Заказать деталь";
            buttonLeaveComment.UseVisualStyleBackColor = true;
            buttonLeaveComment.Click += buttonOrderRepairPart_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 221);
            label1.Name = "label1";
            label1.Size = new Size(131, 21);
            label1.TabIndex = 5;
            label1.Text = "Название детали";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(184, 92);
            label2.Name = "label2";
            label2.Size = new Size(125, 21);
            label2.TabIndex = 6;
            label2.Text = "Заказать деталь";
            // 
            // OrderRepairPart
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(193, 176, 152);
            ClientSize = new Size(480, 557);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonLeaveComment);
            Controls.Add(richTextBox1);
            Controls.Add(comboBoxRequests);
            Controls.Add(labelRequest);
            Controls.Add(buttonClose);
            Font = new Font("Segoe UI", 12F);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "OrderRepairPart";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Заказать деталь";
            Load += OrderRepairPart_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonClose;
        private Label labelRequest;
        private ComboBox comboBoxRequests;
        private RichTextBox richTextBox1;
        private Button buttonLeaveComment;
        private Label label1;
        private Label label2;
    }
}