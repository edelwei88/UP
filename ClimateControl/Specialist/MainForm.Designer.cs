namespace ClimateControl.Specialist
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            buttonManageRequests = new Button();
            buttonCreateComment = new Button();
            buttonClose = new Button();
            pictureBox1 = new PictureBox();
            labelName = new Label();
            labelRole = new Label();
            buttonOrderRepairParts = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonManageRequests
            // 
            buttonManageRequests.Font = new Font("Segoe UI", 12F);
            buttonManageRequests.Location = new Point(12, 182);
            buttonManageRequests.Name = "buttonManageRequests";
            buttonManageRequests.Size = new Size(270, 60);
            buttonManageRequests.TabIndex = 0;
            buttonManageRequests.Text = "Список заявок";
            buttonManageRequests.UseVisualStyleBackColor = true;
            buttonManageRequests.Click += buttonManageRequests_Click;
            // 
            // buttonCreateComment
            // 
            buttonCreateComment.Font = new Font("Segoe UI", 12F);
            buttonCreateComment.Location = new Point(12, 248);
            buttonCreateComment.Name = "buttonCreateComment";
            buttonCreateComment.Size = new Size(270, 60);
            buttonCreateComment.TabIndex = 1;
            buttonCreateComment.Text = "Оставить комментарий";
            buttonCreateComment.UseVisualStyleBackColor = true;
            buttonCreateComment.Click += buttonCreateComment_Click;
            // 
            // buttonClose
            // 
            buttonClose.Font = new Font("Segoe UI", 12F);
            buttonClose.Location = new Point(12, 382);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(270, 60);
            buttonClose.TabIndex = 2;
            buttonClose.Text = "Выход";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.avatar;
            pictureBox1.InitialImage = Properties.Resources.avatar;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(118, 12);
            labelName.Name = "labelName";
            labelName.Size = new Size(64, 15);
            labelName.TabIndex = 4;
            labelName.Text = "labelName";
            // 
            // labelRole
            // 
            labelRole.AutoSize = true;
            labelRole.Location = new Point(118, 36);
            labelRole.Name = "labelRole";
            labelRole.Size = new Size(106, 15);
            labelRole.TabIndex = 5;
            labelRole.Text = "Роль: Специалист";
            // 
            // buttonOrderRepairParts
            // 
            buttonOrderRepairParts.Font = new Font("Segoe UI", 12F);
            buttonOrderRepairParts.Location = new Point(12, 314);
            buttonOrderRepairParts.Name = "buttonOrderRepairParts";
            buttonOrderRepairParts.Size = new Size(270, 60);
            buttonOrderRepairParts.TabIndex = 6;
            buttonOrderRepairParts.Text = "Заказать запчасти";
            buttonOrderRepairParts.UseVisualStyleBackColor = true;
            buttonOrderRepairParts.Click += buttonOrderRepairParts_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(193, 176, 152);
            ClientSize = new Size(294, 454);
            Controls.Add(buttonOrderRepairParts);
            Controls.Add(labelRole);
            Controls.Add(labelName);
            Controls.Add(pictureBox1);
            Controls.Add(buttonClose);
            Controls.Add(buttonCreateComment);
            Controls.Add(buttonManageRequests);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Главная";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonManageRequests;
        private Button buttonCreateComment;
        private Button buttonClose;
        private PictureBox pictureBox1;
        private Label labelName;
        private Label labelRole;
        private Button buttonOrderRepairParts;
    }
}