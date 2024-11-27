namespace CTDLGT_De8_BinarySearchTree
{
    partial class DangNhap
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            panel1 = new Panel();
            Password = new TextBox();
            Account = new TextBox();
            PasswordNo = new Label();
            AccountName = new Label();
            SignIn = new Label();
            CreateNewAccount = new Label();
            signinButton = new Button();
            ExampleUserName = new ToolTip(components);
            ExamplePassword = new ToolTip(components);
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(Password);
            panel1.Controls.Add(Account);
            panel1.Controls.Add(PasswordNo);
            panel1.Controls.Add(AccountName);
            panel1.Controls.Add(SignIn);
            panel1.Location = new Point(121, 251);
            panel1.Name = "panel1";
            panel1.Size = new Size(785, 267);
            panel1.TabIndex = 0;
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
            ExamplePassword.SetToolTip(Password, "Mật khẩu là '123456'");
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
            ExampleUserName.SetToolTip(Account, "Tên đăng nhập là \"User123\"");
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
            // AccountName
            // 
            AccountName.AutoSize = true;
            AccountName.Font = new Font("Tahoma", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AccountName.ForeColor = Color.White;
            AccountName.Location = new Point(39, 57);
            AccountName.Name = "AccountName";
            AccountName.Size = new Size(225, 34);
            AccountName.TabIndex = 1;
            AccountName.Text = "Tên đăng nhập";
            // 
            // SignIn
            // 
            SignIn.AutoSize = true;
            SignIn.Font = new Font("Tahoma", 18F, FontStyle.Bold);
            SignIn.ForeColor = Color.White;
            SignIn.Location = new Point(30, 0);
            SignIn.Name = "SignIn";
            SignIn.Size = new Size(243, 43);
            SignIn.TabIndex = 0;
            SignIn.Text = "ĐĂNG NHẬP";
            // 
            // CreateNewAccount
            // 
            CreateNewAccount.AutoSize = true;
            CreateNewAccount.BackColor = Color.Transparent;
            CreateNewAccount.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            CreateNewAccount.ForeColor = SystemColors.ButtonHighlight;
            CreateNewAccount.Location = new Point(162, 600);
            CreateNewAccount.Name = "CreateNewAccount";
            CreateNewAccount.Size = new Size(305, 25);
            CreateNewAccount.TabIndex = 6;
            CreateNewAccount.Text = "Nhân viên mới? Tạo tài khoản tại đây";
            CreateNewAccount.Click += CreateNewAccount_Click;
            // 
            // signinButton
            // 
            signinButton.BackColor = Color.LightCyan;
            signinButton.FlatStyle = FlatStyle.Popup;
            signinButton.Font = new Font("Tahoma", 11F, FontStyle.Bold);
            signinButton.ForeColor = Color.SteelBlue;
            signinButton.Location = new Point(162, 547);
            signinButton.Name = "signinButton";
            signinButton.Size = new Size(154, 50);
            signinButton.TabIndex = 5;
            signinButton.Text = "Đăng nhập";
            signinButton.UseVisualStyleBackColor = false;
            signinButton.Click += signinButton_Click;
            // 
            // ExampleUserName
            // 
            ExampleUserName.AutoPopDelay = 5000;
            ExampleUserName.InitialDelay = 100;
            ExampleUserName.ReshowDelay = 200;
            ExampleUserName.ToolTipIcon = ToolTipIcon.Info;
            ExampleUserName.ToolTipTitle = "Hướng dẫn";
            // 
            // ExamplePassword
            // 
            ExamplePassword.AutoPopDelay = 5000;
            ExamplePassword.InitialDelay = 100;
            ExamplePassword.ReshowDelay = 200;
            ExamplePassword.ToolTipIcon = ToolTipIcon.Info;
            ExamplePassword.ToolTipTitle = "Hướng dẫn";
            // 
            // DangNhap
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1600, 900);
            Controls.Add(CreateNewAccount);
            Controls.Add(panel1);
            Controls.Add(signinButton);
            DoubleBuffered = true;
            Name = "DangNhap";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label PasswordNo;
        private Label AccountName;
        private Label SignIn;
        private TextBox Account;
        private TextBox Password;
        private Button signinButton;
        private Label CreateNewAccount;
        private ToolTip ExampleUserName;
        private ToolTip ExamplePassword;
    }
}
