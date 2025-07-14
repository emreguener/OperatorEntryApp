using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace OperatorEntryApp
{
    public partial class UserSettingsForm : Form
    {
        private int _userId;
        private string _fullName;
        private string _role;
        private string connectionString = ConfigurationManager.ConnectionStrings["Haier_DB"].ConnectionString;
        MainForm _mainForm; // geri dönmek için

        public UserSettingsForm(MainForm mainForm, int userId, string fullName, string role)
        {
            InitializeComponent();
            _mainForm = mainForm;
            _userId = userId;
            _fullName = fullName;
            _role = role;
        }
        private void UserSettingsForm_Load(object sender, EventArgs e)
        {
            txtBoxCurrentPassword.UseSystemPasswordChar = true;
            txtBoxNewPassword.UseSystemPasswordChar = true;
            txtBoxConfirmNewPassword.UseSystemPasswordChar = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _mainForm.Show();
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string currentPassword = txtBoxCurrentPassword.Text.Trim();
            string newPassword = txtBoxNewPassword.Text.Trim();
            string confirmNewPassword = txtBoxConfirmNewPassword.Text.Trim();

            if (string.IsNullOrEmpty(currentPassword) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmNewPassword))
            {
                MessageBox.Show("Please fill in all fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPassword != confirmNewPassword)
            {
                MessageBox.Show("New password and confirmation do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string hashedCurrentPassword = ComputeSha256Hash(currentPassword);

            string hashedNewPassword = ComputeSha256Hash(newPassword);

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Bu ID ve şifreyle eşleşen kaç kullanıcı var
                    string checkQuery = "SELECT COUNT(*) FROM Users WHERE UserId = @userId AND Password = @currentPassword";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@userId", _userId);
                        checkCmd.Parameters.AddWithValue("@currentPassword", hashedCurrentPassword);

                        int count = (int)checkCmd.ExecuteScalar();
                        if (count == 0)
                        {
                            MessageBox.Show("Current password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtBoxCurrentPassword.Clear();
                            txtBoxCurrentPassword.Focus();
                            return;
                        }
                    }

                    // şifreyi güncelle
                    string updateQuery = "UPDATE Users SET Password = @newPassword WHERE UserId = @userId";
                    using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn))
                    {
                        updateCmd.Parameters.AddWithValue("@newPassword", hashedNewPassword);
                        updateCmd.Parameters.AddWithValue("@userId", _userId);

                        int rowsAffected = updateCmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Password updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                            _mainForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("Failed to update password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                    builder.Append(b.ToString("x2"));
                return builder.ToString();
            }
        }

        
    }
}
