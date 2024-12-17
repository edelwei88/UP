namespace ClimateControl.Manager
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
            buttonRequests = new Button();
            buttonClose = new Button();
            pictureBox1 = new PictureBox();
            labelName = new Label();
            labelRole = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonRequests
            // 
            buttonRequests.Font = new Font("Segoe UI", 12F);
            buttonRequests.Location = new Point(12, 316);
            buttonRequests.Name = "buttonRequests";
            buttonRequests.Size = new Size(270, 60);
            buttonRequests.TabIndex = 0;
            buttonRequests.Text = "Заявки";
            buttonRequests.UseVisualStyleBackColor = true;
            buttonRequests.Click += buttonCreateQuery_Click;
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
            labelRole.Size = new Size(98, 15);
            labelRole.TabIndex = 5;
            labelRole.Text = "Роль: Менеджер";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(193, 176, 152);
            ClientSize = new Size(294, 454);
            Controls.Add(labelRole);
            Controls.Add(labelName);
            Controls.Add(pictureBox1);
            Controls.Add(buttonClose);
            Controls.Add(buttonRequests);
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

        private Button buttonRequests;
        private Button buttonClose;
        private PictureBox pictureBox1;
        private Label labelName;
        private Label labelRole;
    }
}