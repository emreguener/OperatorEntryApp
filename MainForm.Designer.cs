namespace OperatorEntryApp
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
            this.components = new System.ComponentModel.Container();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.txtSupplierCode = new System.Windows.Forms.TextBox();
            this.txtProductBarcode = new System.Windows.Forms.TextBox();
            this.lblProductBarcode = new System.Windows.Forms.Label();
            this.lblUserId = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblSupplierCode = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panelUser = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblClock = new System.Windows.Forms.Label();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.lblRecentEntries = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lvRecentEntries = new System.Windows.Forms.ListView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxUserSettings = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.panelUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserSettings)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWelcome.ForeColor = System.Drawing.Color.DimGray;
            this.lblWelcome.Location = new System.Drawing.Point(21, 181);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(98, 23);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "lblWelcome";
            // 
            // txtSupplierCode
            // 
            this.txtSupplierCode.Location = new System.Drawing.Point(525, 101);
            this.txtSupplierCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSupplierCode.Name = "txtSupplierCode";
            this.txtSupplierCode.Size = new System.Drawing.Size(289, 30);
            this.txtSupplierCode.TabIndex = 1;
            // 
            // txtProductBarcode
            // 
            this.txtProductBarcode.Location = new System.Drawing.Point(525, 182);
            this.txtProductBarcode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductBarcode.Name = "txtProductBarcode";
            this.txtProductBarcode.Size = new System.Drawing.Size(289, 30);
            this.txtProductBarcode.TabIndex = 2;
            // 
            // lblProductBarcode
            // 
            this.lblProductBarcode.AutoSize = true;
            this.lblProductBarcode.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductBarcode.ForeColor = System.Drawing.Color.DimGray;
            this.lblProductBarcode.Location = new System.Drawing.Point(367, 189);
            this.lblProductBarcode.Name = "lblProductBarcode";
            this.lblProductBarcode.Size = new System.Drawing.Size(141, 23);
            this.lblProductBarcode.TabIndex = 4;
            this.lblProductBarcode.Text = "Product Barcode:";
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUserId.ForeColor = System.Drawing.Color.DimGray;
            this.lblUserId.Location = new System.Drawing.Point(21, 216);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(64, 23);
            this.lblUserId.TabIndex = 5;
            this.lblUserId.Text = "User Id";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.SteelBlue;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(775, 32);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(84, 33);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.SteelBlue;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(562, 259);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(84, 33);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblSupplierCode
            // 
            this.lblSupplierCode.AutoSize = true;
            this.lblSupplierCode.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSupplierCode.ForeColor = System.Drawing.Color.DimGray;
            this.lblSupplierCode.Location = new System.Drawing.Point(367, 108);
            this.lblSupplierCode.Name = "lblSupplierCode";
            this.lblSupplierCode.Size = new System.Drawing.Size(121, 23);
            this.lblSupplierCode.TabIndex = 9;
            this.lblSupplierCode.Text = "Supplier Code:";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRegister.ForeColor = System.Drawing.Color.Black;
            this.btnRegister.Location = new System.Drawing.Point(677, 259);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(137, 33);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "REGISTER";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Visible = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(12, 32);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(84, 33);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panelUser
            // 
            this.panelUser.Controls.Add(this.lblRole);
            this.panelUser.Controls.Add(this.label1);
            this.panelUser.Controls.Add(this.pictureBoxUserSettings);
            this.panelUser.Controls.Add(this.btnBack);
            this.panelUser.Controls.Add(this.lblWelcome);
            this.panelUser.Controls.Add(this.lblUserId);
            this.panelUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelUser.Location = new System.Drawing.Point(0, 0);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(242, 524);
            this.panelUser.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(21, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "My Account";
            // 
            // lblClock
            // 
            this.lblClock.AutoSize = true;
            this.lblClock.Location = new System.Drawing.Point(281, 42);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(69, 23);
            this.lblClock.TabIndex = 13;
            this.lblClock.Text = "lblClock";
            // 
            // timerClock
            // 
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // lblRecentEntries
            // 
            this.lblRecentEntries.AutoSize = true;
            this.lblRecentEntries.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRecentEntries.ForeColor = System.Drawing.Color.DimGray;
            this.lblRecentEntries.Location = new System.Drawing.Point(315, 317);
            this.lblRecentEntries.Name = "lblRecentEntries";
            this.lblRecentEntries.Size = new System.Drawing.Size(122, 23);
            this.lblRecentEntries.TabIndex = 13;
            this.lblRecentEntries.Text = "Recent Entries:";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRole.ForeColor = System.Drawing.Color.DimGray;
            this.lblRole.Location = new System.Drawing.Point(21, 251);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(43, 23);
            this.lblRole.TabIndex = 13;
            this.lblRole.Text = "Role";
            // 
            // lvRecentEntries
            // 
            this.lvRecentEntries.FullRowSelect = true;
            this.lvRecentEntries.GridLines = true;
            this.lvRecentEntries.HideSelection = false;
            this.lvRecentEntries.Location = new System.Drawing.Point(443, 317);
            this.lvRecentEntries.Name = "lvRecentEntries";
            this.lvRecentEntries.Size = new System.Drawing.Size(371, 188);
            this.lvRecentEntries.TabIndex = 15;
            this.lvRecentEntries.UseCompatibleStateImageBehavior = false;
            this.lvRecentEntries.View = System.Windows.Forms.View.Details;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::OperatorEntryApp.Properties.Resources._4237837;
            this.pictureBox2.Location = new System.Drawing.Point(285, 86);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(61, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OperatorEntryApp.Properties.Resources.barcode;
            this.pictureBox1.Location = new System.Drawing.Point(285, 167);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxUserSettings
            // 
            this.pictureBoxUserSettings.Image = global::OperatorEntryApp.Properties.Resources.user_icon;
            this.pictureBoxUserSettings.Location = new System.Drawing.Point(12, 86);
            this.pictureBoxUserSettings.Name = "pictureBoxUserSettings";
            this.pictureBoxUserSettings.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxUserSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUserSettings.TabIndex = 11;
            this.pictureBoxUserSettings.TabStop = false;
            this.pictureBoxUserSettings.Click += new System.EventHandler(this.pictureBoxUserSettings_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(443, 259);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 33);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.MouseEnter += new System.EventHandler(this.btnSave_MouseEnter);
            this.btnSave.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(894, 524);
            this.Controls.Add(this.lvRecentEntries);
            this.Controls.Add(this.lblRecentEntries);
            this.Controls.Add(this.lblClock);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelUser);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lblSupplierCode);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblProductBarcode);
            this.Controls.Add(this.txtProductBarcode);
            this.Controls.Add(this.txtSupplierCode);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelUser.ResumeLayout(false);
            this.panelUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserSettings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.TextBox txtSupplierCode;
        private System.Windows.Forms.TextBox txtProductBarcode;
        private System.Windows.Forms.Label lblProductBarcode;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblSupplierCode;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.PictureBox pictureBoxUserSettings;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblRecentEntries;
        private System.Windows.Forms.ListView lvRecentEntries;
    }
}