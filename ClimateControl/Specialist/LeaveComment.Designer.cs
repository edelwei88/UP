namespace ClimateControl.Specialist
{
    partial class LeaveComment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeaveComment));
            buttonClose = new Button();
            labelRequest = new Label();
            comboBoxComment = new ComboBox();
            richTextBox1 = new RichTextBox();
            buttonLeaveComment = new Button();
            label1 = new Label();
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
            labelRequest.Location = new Point(12, 134);
            labelRequest.Name = "labelRequest";
            labelRequest.Size = new Size(59, 21);
            labelRequest.TabIndex = 1;
            labelRequest.Text = "Заявка";
            // 
            // comboBoxComment
            // 
            comboBoxComment.FormattingEnabled = true;
            comboBoxComment.Location = new Point(12, 158);
            comboBoxComment.Name = "comboBoxComment";
            comboBoxComment.Size = new Size(118, 29);
            comboBoxComment.TabIndex = 2;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 227);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(456, 301);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // buttonLeaveComment
            // 
            buttonLeaveComment.Location = new Point(12, 563);
            buttonLeaveComment.Name = "buttonLeaveComment";
            buttonLeaveComment.Size = new Size(190, 37);
            buttonLeaveComment.TabIndex = 4;
            buttonLeaveComment.Text = "Оставить комментарий";
            buttonLeaveComment.UseVisualStyleBackColor = true;
            buttonLeaveComment.Click += buttonLeaveComment_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(143, 84);
            label1.Name = "label1";
            label1.Size = new Size(178, 21);
            label1.TabIndex = 5;
            label1.Text = "Оставить комментарий";
            // 
            // LeaveComment
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(193, 176, 152);
            ClientSize = new Size(480, 613);
            Controls.Add(label1);
            Controls.Add(buttonLeaveComment);
            Controls.Add(richTextBox1);
            Controls.Add(comboBoxComment);
            Controls.Add(labelRequest);
            Controls.Add(buttonClose);
            Font = new Font("Segoe UI", 12F);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "LeaveComment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Оставить комментарий";
            Load += LeaveComment_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonClose;
        private Label labelRequest;
        private ComboBox comboBoxComment;
        private RichTextBox richTextBox1;
        private Button buttonLeaveComment;
        private Label label1;
    }
}