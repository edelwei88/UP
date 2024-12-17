namespace ClimateControl.Customer
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
            buttonCreateQuery = new Button();
            buttonEditQuery = new Button();
            buttonClose = new Button();
            pictureBox1 = new PictureBox();
            labelName = new Label();
            labelRole = new Label();
            buttonCheckComments = new Button();
            buttonQRCode = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonCreateQuery
            // 
            buttonCreateQuery.Font = new Font("Segoe UI", 12F);
            buttonCreateQuery.Location = new Point(12, 184);
            buttonCreateQuery.Name = "buttonCreateQuery";
            buttonCreateQuery.Size = new Size(270, 60);
            buttonCreateQuery.TabIndex = 0;
            buttonCreateQuery.Text = "Создать заявку";
            buttonCreateQuery.UseVisualStyleBackColor = true;
            buttonCreateQuery.Click += buttonCreateQuery_Click;
            // 
            // buttonEditQuery
            // 
            buttonEditQuery.Font = new Font("Segoe UI", 12F);
            buttonEditQuery.Location = new Point(12, 250);
            buttonEditQuery.Name = "buttonEditQuery";
            buttonEditQuery.Size = new Size(270, 60);
            buttonEditQuery.TabIndex = 1;
            buttonEditQuery.Text = "Отредактировать заявку";
            buttonEditQuery.UseVisualStyleBackColor = true;
            buttonEditQuery.Click += buttonEditQuery_Click;
            // 
            // buttonClose
            // 
            buttonClose.Font = new Font("Segoe UI", 12F);
            buttonClose.Location = new Point(12, 448);
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
            labelRole.Size = new Size(90, 15);
            labelRole.TabIndex = 5;
            labelRole.Text = "Роль: Заказчик";
            // 
            // buttonCheckComments
            // 
            buttonCheckComments.Font = new Font("Segoe UI", 12F);
            buttonCheckComments.Location = new Point(12, 316);
            buttonCheckComments.Name = "buttonCheckComments";
            buttonCheckComments.Size = new Size(270, 60);
            buttonCheckComments.TabIndex = 6;
            buttonCheckComments.Text = "Посмотреть комментарии";
            buttonCheckComments.UseVisualStyleBackColor = true;
            buttonCheckComments.Click += buttonCheckComments_Click;
            // 
            // buttonQRCode
            // 
            buttonQRCode.Font = new Font("Segoe UI", 12F);
            buttonQRCode.Location = new Point(12, 382);
            buttonQRCode.Name = "buttonQRCode";
            buttonQRCode.Size = new Size(270, 60);
            buttonQRCode.TabIndex = 7;
            buttonQRCode.Text = "QR-Код";
            buttonQRCode.UseVisualStyleBackColor = true;
            buttonQRCode.Click += buttonQRCode_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(193, 176, 152);
            ClientSize = new Size(294, 520);
            Controls.Add(buttonQRCode);
            Controls.Add(buttonCheckComments);
            Controls.Add(labelRole);
            Controls.Add(labelName);
            Controls.Add(pictureBox1);
            Controls.Add(buttonClose);
            Controls.Add(buttonEditQuery);
            Controls.Add(buttonCreateQuery);
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

        private Button buttonCreateQuery;
        private Button buttonEditQuery;
        private Button buttonClose;
        private PictureBox pictureBox1;
        private Label labelName;
        private Label labelRole;
        private Button buttonCheckComments;
        private Button buttonQRCode;
    }
}