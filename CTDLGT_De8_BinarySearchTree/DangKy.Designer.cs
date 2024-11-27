using System.Security.Principal;

namespace CTDLGT_De8_BinarySearchTree
{
    partial class DangKy
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangKy));
            Account = new TextBox();
            AccountName = new Label();
            SignIn = new Label();
            panel2 = new Panel();
            Password = new TextBox();
            PasswordNo = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            MaXT = new ToolTip(components);
            signinButton = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // Account
            // 
            Account.BackColor = SystemColors.ControlLightLight;
            Account.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Account.ForeColor = SystemColors.ActiveCaptionText;
            Account.Location = new Point(41, 105);
            Account.Multiline = true;
            Account.Name = "Account";
            Account.Size = new Size(483, 43);
            Account.TabIndex = 3;
            // 
            // AccountName
            // 
            AccountName.AutoSize = true;
            AccountName.Font = new Font("Tahoma", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AccountName.ForeColor = Color.White;
            AccountName.Location = new Point(39, 57);
            AccountName.Name = "AccountName";
            AccountName.Size = new Size(207, 34);
            AccountName.TabIndex = 1;
            AccountName.Text = "Tên tài khoản";
            // 
            // SignIn
            // 
            SignIn.AutoSize = true;
            SignIn.Font = new Font("Tahoma", 18F, FontStyle.Bold);
            SignIn.ForeColor = Color.White;
            SignIn.Location = new Point(30, 0);
            SignIn.Name = "SignIn";
            SignIn.Size = new Size(187, 43);
            SignIn.TabIndex = 0;
            SignIn.Text = "ĐĂNG KÝ";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(Password);
            panel2.Controls.Add(Account);
            panel2.Controls.Add(PasswordNo);
            panel2.Controls.Add(AccountName);
            panel2.Controls.Add(SignIn);
            panel2.Location = new Point(151, 251);
            panel2.Name = "panel2";
            panel2.Size = new Size(785, 267);
            panel2.TabIndex = 1;
            // 
            // Password
            // 
            Password.BackColor = SystemColors.ControlLightLight;
            Password.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Password.ForeColor = SystemColors.ActiveCaptionText;
            Password.Location = new Point(41, 222);
            Password.Multiline = true;
            Password.Name = "Password";
            Password.Size = new Size(483, 43);
            Password.TabIndex = 4;
            // 
            // PasswordNo
            // 
            PasswordNo.AutoSize = true;
            PasswordNo.Font = new Font("Tahoma", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PasswordNo.ForeColor = Color.White;
            PasswordNo.Location = new Point(39, 172);
            PasswordNo.Name = "PasswordNo";
            PasswordNo.Size = new Size(147, 34);
            PasswordNo.TabIndex = 2;
            PasswordNo.Text = "Mật khẩu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(177, 214);
            label2.Name = "label2";
            label2.Size = new Size(238, 34);
            label2.TabIndex = 7;
            label2.Text = "Chào mừng bạn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Tahoma", 10F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(190, 550);
            label3.Name = "label3";
            label3.Size = new Size(265, 24);
            label3.TabIndex = 5;
            label3.Text = "Nhập mã xác thực cấp từ HR";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ControlLightLight;
            textBox1.Font = new Font("Tahoma", 10F);
            textBox1.ForeColor = SystemColors.ActiveCaptionText;
            textBox1.Location = new Point(463, 542);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(212, 43);
            textBox1.TabIndex = 5;
            MaXT.SetToolTip(textBox1, "Nhập \"CTDLGT-DE8\"");
            // 
            // MaXT
            // 
            MaXT.AutoPopDelay = 5000;
            MaXT.InitialDelay = 200;
            MaXT.ReshowDelay = 100;
            MaXT.ToolTipIcon = ToolTipIcon.Info;
            MaXT.ToolTipTitle = "Hướng dẫn";
            // 
            // signinButton
            // 
            signinButton.BackColor = Color.LightCyan;
            signinButton.FlatStyle = FlatStyle.Popup;
            signinButton.Font = new Font("Tahoma", 11F, FontStyle.Bold);
            signinButton.ForeColor = Color.SteelBlue;
            signinButton.Location = new Point(192, 603);
            signinButton.Name = "signinButton";
            signinButton.Size = new Size(125, 42);
            signinButton.TabIndex = 8;
            signinButton.Text = "Đăng ký";
            signinButton.UseVisualStyleBackColor = false;
            signinButton.Click += signinButton_Click;
            // 
            // DangKy
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1600, 900);
            Controls.Add(signinButton);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel2);
            Name = "DangKy";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DangKy";
            MaXT.SetToolTip(this, "Nhập \"CTDLGT-DE8\"");
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox Account;
        private Label AccountName;
        private Label SignIn;
        private Panel panel2;
        private TextBox Password;
        private Label PasswordNo;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private ToolTip MaXT;
        private Button signinButton;
    }
}