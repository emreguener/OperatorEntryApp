using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
namespace OperatorEntryApp
{
    public partial class LoginForm : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["Haier_DB"].ConnectionString;


        public LoginForm()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtOperatorId.Text = "Enter User ID";
            txtOperatorId.ForeColor = Color.Gray;

            txtPassword.Text = "Enter Password";
            txtPassword.ForeColor = Color.Gray;
            txtPassword.UseSystemPasswordChar = false; // placeholder görünmesi için
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int userId;
            string password = txtPassword.Text.Trim();

            if (!int.TryParse(txtOperatorId.Text.Trim(), out userId))
            {
                lblMessage.Text = "User ID must be a number.";
                lblMessage.ForeColor = System.Drawing.Color.Red;
                return; //Hatalı girişte metot sonlanmalı dbye gönderilmemeli
            }

            // Şifreyi hashle
            string hashedPassword = ComputeSha256Hash(password);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT FullName, Role FROM Users WHERE UserId = @UserId AND Password = @Password";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    cmd.Parameters.AddWithValue("@Password", hashedPassword); // HASH EDİLMİŞ ŞİFREYİ DBYE GÖNDER

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read()) // başarılı giriş
                        {
                            string fullName = reader.GetString(0);
                            string role = reader.GetString(1);
                            Logger.Log($"Login successful", userId);
                            MainForm mainForm = new MainForm(this, userId, fullName, role);
                            mainForm.Show();
                            this.Hide();
                        }
                        else // başarısız giriş
                        {
                            Logger.Log("Login failed", userId);

                            txtOperatorId.Clear();
                            txtPassword.Clear();
                            txtOperatorId.Focus();

                            lblMessage.Visible = true;
                            lblMessage.Text = "Login failed. Invalid ID or Password.";
                            lblMessage.ForeColor = System.Drawing.Color.Red;
                        }
                    }
                }
            }
        }


        private string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                    builder.Append(b.ToString("x2"));
                return builder.ToString();
            }
        }
        private bool isPasswordVisible = false;
        private void picShowPassword_Click(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;
            txtPassword.UseSystemPasswordChar = !isPasswordVisible;
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick(); // Butona tıklanmış gibi davranır enter'e basınca
            }
         
        }

        private void txtOperatorId_Enter(object sender, EventArgs e)
        {
            if (txtOperatorId.Text == "Enter User ID")
            {
                txtOperatorId.Text = "";
                txtOperatorId.ForeColor = Color.Black;
            }
        }

        private void txtOperatorId_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOperatorId.Text))
            {
                txtOperatorId.Text = "Enter User ID";
                txtOperatorId.ForeColor = Color.Gray;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Enter Password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
                txtPassword.UseSystemPasswordChar = true; // gerçek şifre görünümü
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtPassword.UseSystemPasswordChar = false; // tekrar placeholder için kapat
                txtPassword.Text = "Enter Password";
                txtPassword.ForeColor = Color.Gray;
            }
        }

        private bool isMousePressed = false; // şifre gösterme için fare basılı mı kontrolü
        private void picShowPassword_MouseDown(object sender, MouseEventArgs e) // Fare basıldığında şifreyi göster
        {
            if (txtPassword.Text != "Enter Password")
            {
                isMousePressed = true;
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void picShowPassword_MouseUp(object sender, MouseEventArgs e) // Fare bırakıldığında şifreyi gizle
        {
            isMousePressed = false; 
            if (txtPassword.Text != "Enter Password")
                txtPassword.UseSystemPasswordChar = true;
        }

        private void picShowPassword_MouseMove(object sender, MouseEventArgs e) // Fare hareket ettiğinde şifreyi kontrol et eğer fare basılıysa ve fare PictureBox'ın dışında ise şifreyi gizle
        {
            if (isMousePressed)
            {
                // PictureBox'ın sınırları içinde mi
                Point cursorPos = picShowPassword.PointToClient(Cursor.Position);
                if (cursorPos.X < 0 || cursorPos.X > picShowPassword.Width || // pozisyonda sol üst köşe baz alınır (0,0)
                    cursorPos.Y < 0 || cursorPos.Y > picShowPassword.Height)
                {
                    isMousePressed = false;
                    if (txtPassword.Text != "Enter Password")
                        txtPassword.UseSystemPasswordChar = true;
                }
            }
        }
    }
}
