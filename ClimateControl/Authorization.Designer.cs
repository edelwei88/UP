namespace ClimateControl
{
    partial class Authorization
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization));
            textBoxLogin = new TextBox();
            textBoxPassword = new TextBox();
            labelLogin = new Label();
            labelPassword = new Label();
            buttonLogin = new Button();
            buttonShowPassword = new Button();
            textBoxCaptcha = new TextBox();
            labelCaptcha = new Label();
            pictureBoxCaptcha = new PictureBox();
            buttonRefreshCaptcha = new Button();
            buttonHistory = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCaptcha).BeginInit();
            SuspendLayout();
            // 
            // textBoxLogin
            // 
            textBoxLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxLogin.Location = new Point(12, 33);
            textBoxLogin.MaxLength = 100;
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(271, 29);
            textBoxLogin.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPassword.Location = new Point(12, 111);
            textBoxPassword.MaxLength = 100;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(271, 29);
            textBoxPassword.TabIndex = 1;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Segoe UI", 12F);
            labelLogin.Location = new Point(12, 9);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(54, 21);
            labelLogin.TabIndex = 2;
            labelLogin.Text = "Логин";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 12F);
            labelPassword.Location = new Point(12, 87);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(63, 21);
            labelPassword.TabIndex = 3;
            labelPassword.Text = "Пароль";
            // 
            // buttonLogin
            // 
            buttonLogin.Font = new Font("Segoe UI", 12F);
            buttonLogin.Location = new Point(12, 250);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(75, 45);
            buttonLogin.TabIndex = 4;
            buttonLogin.Text = "Войти";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // buttonShowPassword
            // 
            buttonShowPassword.Image = Properties.Resources.eye;
            buttonShowPassword.Location = new Point(289, 109);
            buttonShowPassword.Name = "buttonShowPassword";
            buttonShowPassword.Size = new Size(48, 32);
            buttonShowPassword.TabIndex = 5;
            buttonShowPassword.UseVisualStyleBackColor = true;
            buttonShowPassword.Click += buttonShowPassword_Click;
            // 
            // textBoxCaptcha
            // 
            textBoxCaptcha.Font = new Font("Segoe UI", 12F);
            textBoxCaptcha.Location = new Point(12, 193);
            textBoxCaptcha.MaxLength = 4;
            textBoxCaptcha.Name = "textBoxCaptcha";
            textBoxCaptcha.Size = new Size(106, 29);
            textBoxCaptcha.TabIndex = 6;
            textBoxCaptcha.Visible = false;
            textBoxCaptcha.TextChanged += textBoxCaptcha_TextChanged;
            // 
            // labelCaptcha
            // 
            labelCaptcha.AutoSize = true;
            labelCaptcha.Font = new Font("Segoe UI", 12F);
            labelCaptcha.Location = new Point(12, 169);
            labelCaptcha.Name = "labelCaptcha";
            labelCaptcha.Size = new Size(53, 21);
            labelCaptcha.TabIndex = 7;
            labelCaptcha.Text = "Капча";
            labelCaptcha.Visible = false;
            // 
            // pictureBoxCaptcha
            // 
            pictureBoxCaptcha.Location = new Point(124, 172);
            pictureBoxCaptcha.Name = "pictureBoxCaptcha";
            pictureBoxCaptcha.Size = new Size(159, 50);
            pictureBoxCaptcha.TabIndex = 8;
            pictureBoxCaptcha.TabStop = false;
            // 
            // buttonRefreshCaptcha
            // 
            buttonRefreshCaptcha.Image = Properties.Resources.refresh;
            buttonRefreshCaptcha.Location = new Point(289, 172);
            buttonRefreshCaptcha.Name = "buttonRefreshCaptcha";
            buttonRefreshCaptcha.Size = new Size(48, 50);
            buttonRefreshCaptcha.TabIndex = 9;
            buttonRefreshCaptcha.UseVisualStyleBackColor = true;
            buttonRefreshCaptcha.Visible = false;
            buttonRefreshCaptcha.Click += buttonRefreshCaptcha_Click;
            // 
            // buttonHistory
            // 
            buttonHistory.Location = new Point(373, 272);
            buttonHistory.Name = "buttonHistory";
            buttonHistory.Size = new Size(95, 23);
            buttonHistory.TabIndex = 10;
            buttonHistory.Text = "История входа";
            buttonHistory.UseVisualStyleBackColor = true;
            buttonHistory.Click += buttonHistory_Click;
            // 
            // Authorization
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(193, 176, 152);
            ClientSize = new Size(480, 307);
            Controls.Add(buttonHistory);
            Controls.Add(buttonRefreshCaptcha);
            Controls.Add(pictureBoxCaptcha);
            Controls.Add(labelCaptcha);
            Controls.Add(textBoxCaptcha);
            Controls.Add(buttonShowPassword);
            Controls.Add(buttonLogin);
            Controls.Add(labelPassword);
            Controls.Add(labelLogin);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxLogin);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Authorization";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Авторизация";
            ((System.ComponentModel.ISupportInitialize)pictureBoxCaptcha).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxLogin;
        private TextBox textBoxPassword;
        private Label labelLogin;
        private Label labelPassword;
        private Button buttonLogin;
        private Button buttonShowPassword;
        private TextBox textBoxCaptcha;
        private Label labelCaptcha;
        private PictureBox pictureBoxCaptcha;
        private Button buttonRefreshCaptcha;
        private Button buttonHistory;
    }
}
