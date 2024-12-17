using DBController;
using DBController.Enums;
using CaptchaGen.NetCore;
using Newtonsoft.Json;
using ExecLib;

namespace ClimateControl
{
    public partial class Authorization : Form
    {
        private int loginAttempts = 0;
        private string currentCaptcha = string.Empty;
        private readonly Database db;
        private System.Windows.Forms.Timer blockTimer;

       

        private Image GetCaptchaImage(string captchaCode, int height, int width, int fontSize)
        {
            using (Stream imgStream = ImageFactory.BuildImage(captchaCode, height, width, fontSize, 10, System.Drawing.Imaging.ImageFormat.Bmp))
            {
                return Bitmap.FromStream(imgStream);
            }
        }

        private void RefreshCaptcha()
        {
            currentCaptcha = Exec.GenerateCaptchaString(4);
            pictureBoxCaptcha.Image = GetCaptchaImage(currentCaptcha, pictureBoxCaptcha.Height, pictureBoxCaptcha.Width, 24);
            CheckCaptcha();
        }

        private void CheckCaptcha()
        {
            if (loginAttempts != 0 && textBoxCaptcha.Text == currentCaptcha)
                buttonLogin.Enabled = true;
            else
                buttonLogin.Enabled = false;
        }

        private void BlockLogin()
        {
            buttonLogin.Enabled = false;
            textBoxCaptcha.Enabled = false;
            buttonRefreshCaptcha.Enabled = false;
            blockTimer.Start();
        }
        private void BlockTimer_Tick(object? sender, EventArgs e)
        {
            buttonLogin.Enabled = true;
            textBoxCaptcha.Enabled = true;
            buttonRefreshCaptcha.Enabled = true;
            RefreshCaptcha();
            blockTimer.Stop();
        }

        private void BlockLoginCompletely()
        {
            textBoxLogin.Enabled = false;
            textBoxPassword.Enabled = false;
            buttonShowPassword.Enabled = false;
            textBoxCaptcha.Enabled = false;
            buttonRefreshCaptcha.Enabled = false;
            buttonLogin.Enabled = false;
        }

        private void Log(string login, bool result)
        {
            List<UserData>? data = new List<UserData>();
            const string path = @".\logger.dat";
            var loginTime = DateTime.Now;

            if (!File.Exists(path))
                File.Create(path).Close();

            if (File.ReadAllText(path).Length != 0)
                data = JsonConvert.DeserializeObject<List<UserData>>(File.ReadAllText(path));
            if (data == null)
                return;

            data.Add(new UserData(loginTime, login, result));
            File.WriteAllText(path, JsonConvert.SerializeObject(data, Formatting.Indented));
        }
        private void RefreshForm()
        {
            loginAttempts = 0;
            textBoxLogin.Text = string.Empty;
            textBoxPassword.Text = string.Empty;
            textBoxCaptcha.Text = string.Empty;
            labelCaptcha.Visible = false;
            textBoxCaptcha.Visible = false;
            pictureBoxCaptcha.Visible = false;
            buttonRefreshCaptcha.Visible = false;
            buttonLogin.Enabled = true;
        }

        //Открыть форму соответственно типу пользователя
        private void OpenMainForm(User userType, string login)
        {
            switch (userType)
            {
                case User.Customer:
                    using (var form = new Customer.MainForm(db, login))
                    {
                        Hide();
                        form.ShowDialog();
                        RefreshForm();
                        Show();
                    }
                    break;
                case User.Specialist:
                    using (var form = new Specialist.MainForm(db, login))
                    {
                        Hide();
                        form.ShowDialog();
                        RefreshForm();
                        Show();
                    }
                    break;
                case User.Operator:
                    using (var form = new Operator.MainForm(db, login))
                    {
                        Hide();
                        form.ShowDialog();
                        RefreshForm();
                        Show();
                    }
                    break;
                case User.Manager:
                    using (var form = new Manager.MainForm(db, login))
                    {
                        Hide();
                        form.ShowDialog();
                        RefreshForm();
                        Show();
                    }
                    break;
            }
        }

        public Authorization()
        {
            InitializeComponent();
            db = new("Server=localhost\\SQLEXPRESS;Database=ClimateControl;Trusted_Connection=true;TrustServerCertificate=true");
            blockTimer = new System.Windows.Forms.Timer();
            blockTimer.Interval = 180000;
            blockTimer.Tick += BlockTimer_Tick;
        }

        private void buttonShowPassword_Click(object sender, EventArgs e)
            => textBoxPassword.UseSystemPasswordChar = !textBoxPassword.UseSystemPasswordChar;

        private void buttonRefreshCaptcha_Click(object sender, EventArgs e)
            => RefreshCaptcha();

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var login = textBoxLogin.Text;
            var password = textBoxPassword.Text;

            if (login == string.Empty || password == string.Empty)
            {
                MessageBox.Show("Введите логин и пароль.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                User user = db.Auth(login, password);
                switch (loginAttempts)
                {
                    case 0:
                        if (user != User.None)
                        {
                            Log(login, true);
                            OpenMainForm(user, login);
                        }
                        else
                        {
                            Log(login, false);
                            MessageBox.Show("Неправильный логин или пароль! Введите капчу!", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            labelCaptcha.Visible = true;
                            textBoxCaptcha.Visible = true;
                            pictureBoxCaptcha.Visible = true;
                            buttonRefreshCaptcha.Visible = true;
                            RefreshCaptcha();
                            loginAttempts++;
                        }
                        break;
                    case 1:
                        if (user != User.None && currentCaptcha == textBoxCaptcha.Text)
                        {
                            Log(login, true);
                            OpenMainForm(user, login);
                        }
                        else
                        {
                            Log(login, false);
                            MessageBox.Show("Неправильный логин или пароль! Вход заблокирован на 3 минуты!", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            BlockLogin();
                            loginAttempts++;
                        }
                        break;
                    case 2:
                        if (user != User.None && currentCaptcha == textBoxCaptcha.Text)
                        {
                            Log(login, true);
                            OpenMainForm(user, login);
                        }
                        else
                        {
                            Log(login, false);
                            MessageBox.Show("Неправильный логин или пароль! Вход заблокирован!", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            BlockLoginCompletely();
                            loginAttempts++;
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void textBoxCaptcha_TextChanged(object sender, EventArgs e)
            => CheckCaptcha();

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            using (var form = new History())
            {
                form.ShowDialog();
            }
        }
    }
}

