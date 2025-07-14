using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using System.Drawing;
namespace OperatorEntryApp
{
    public partial class MainForm : Form
    {
        private int _userId;
        private string _fullName;
        private string _role; // admin mi user mı
        private string connectionString = ConfigurationManager.ConnectionStrings["Haier_DB"].ConnectionString;
        private LoginForm _loginForm; // geri dönmek için
        public MainForm(LoginForm loginForm,int userId, string fullName, string role)
        {
            InitializeComponent();
            _userId = userId;
            _fullName = fullName;
            _role = role;
            _loginForm = loginForm; // geri dönmek için
            txtProductBarcode.MaxLength = 8; // 8den fazla girilmesin
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            timerClock.Start();
            UpdateRecentEntries();
            lblWelcome.Text = $"Welcome, {_fullName}";
            lblUserId.Text = $"User ID: {_userId}";
            lblRole.Text = $"Role: {_role}";
            txtProductBarcode.Focus();

            // Sadece admin yetkili kişiler için register butonunu göster
            if (_role.ToLower() == "supervisor" || _role.ToLower() == "engineer")
            {
                btnRegister.Visible = true;
            }
            else
            {
                btnRegister.Visible = false;
            }
        }

        private void UpdateRecentEntries()
        {
            lvRecentEntries.Items.Clear(); // Temizle

            // Kolonlar sadece bir kez eklenmeli
            if (lvRecentEntries.Columns.Count == 0)
            {
                lvRecentEntries.Columns.Add("Barcode", 120);
                lvRecentEntries.Columns.Add("Supplier Code", 120);
                lvRecentEntries.Columns.Add("Time", 100);
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"SELECT TOP 5 ProductBarcode, SupplierCode, Timestamp 
                             FROM UserInputs 
                             WHERE UserId = @userId 
                             ORDER BY Timestamp DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", _userId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string barcode = reader["ProductBarcode"].ToString();
                                string supplier = reader["SupplierCode"].ToString();
                                string time = Convert.ToDateTime(reader["Timestamp"]).ToString("HH:mm:ss");

                                ListViewItem item = new ListViewItem(barcode);
                                item.SubItems.Add(supplier);
                                item.SubItems.Add(time);

                                lvRecentEntries.Items.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load recent entries.\n" + ex.Message);
            }
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            string barcode = txtProductBarcode.Text.Trim();
            string supplierCode = txtSupplierCode.Text.Trim();

            if (string.IsNullOrEmpty(barcode) || string.IsNullOrEmpty(supplierCode))
            {
                MessageBox.Show("Please fill in both Supplier Code and Barcode.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (barcode.Length > 8)
            {
                MessageBox.Show("Product barcode must not exceed 8 characters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "INSERT INTO UserInputs (ProductBarcode, SupplierCode, UserId, Timestamp) " +
                                   "VALUES (@barcode, @supplierCode, @userId, @timestamp)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@barcode", barcode);
                        cmd.Parameters.AddWithValue("@supplierCode", supplierCode);
                        cmd.Parameters.AddWithValue("@userId", _userId);
                        cmd.Parameters.AddWithValue("@timestamp", DateTime.Now);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Data saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateRecentEntries(); // Yeni veriyi listeye ekle
                txtProductBarcode.Clear();
                txtSupplierCode.Clear();
                txtProductBarcode.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while saving data:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtProductBarcode.Clear();
            txtSupplierCode.Clear();
        }

        // admin buton
        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm(this);
            registerForm.Show();   
            this.Hide();           // MainForm'u geçici olarak gizle
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _loginForm.Show();  // Ana formu tekrar göster
            this.Close();      // Kayıt formunu kapat
        }

        private void pictureBoxUserSettings_Click(object sender, EventArgs e)
        {
            this.Hide(); // MainForm'u gizle

            UserSettingsForm userSettingsForm = new UserSettingsForm(this, _userId, _fullName, _role);
            userSettingsForm.ShowDialog();

            this.Show(); // Ayarlar formu kapanınca geri göster
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnSave_MouseEnter(object sender, EventArgs e)
        {
            btnSave.BackColor = Color.LightGreen; // hover olduğunda yeşil
        }

        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            btnSave.BackColor = Color.SteelBlue; // eski rengine dön
        }
    }
}
