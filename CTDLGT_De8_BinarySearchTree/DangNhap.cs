using System.Xml.Linq;

namespace CTDLGT_De8_BinarySearchTree
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
            EnableDoubleBuffering();
        }

        
        public bool CheckSignIn(string username, string password)
        {
            return SignInAccount.Accounts.Any(account => account.Username.Equals(username)&& account.Password.Equals(password));
        }
        private void signinButton_Click(object sender, EventArgs e)
        {
            if(CheckSignIn(Account.Text.Trim(), Password.Text.Trim()))
            {
                DanhSachHoaDon f = new DanhSachHoaDon();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else if (Account.Text.Trim().Equals("") || Password.Text.Trim().Equals(""))
            {
                Label missingValue = new Label();
                missingValue.AutoSize = true;
                missingValue.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
                missingValue.BackColor = Color.Transparent;
                missingValue.ForeColor = Color.OrangeRed;
                missingValue.Location = new Point(330, 547);
                missingValue.Name = "missingValue";
                missingValue.Size = new Size(305, 25);
                missingValue.TabIndex = 2;
                missingValue.Text = "Vui lòng nhập đủ tên và mật khẩu";
                this.Controls.Add(missingValue);
                missingValue.BringToFront();
                missingValue.Show();
            }
            else
            {
                MessageBox.Show("Tài khoản không tồn tại hoặc sai mật khẩu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void EnableDoubleBuffering()
        {
            this.DoubleBuffered = true; // Kích hoạt Double Buffering
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();
        }
        private async void CreateNewAccount_Click(object sender, EventArgs e)
        {
            Label loading = new Label();
            loading.Text = "Loading...";
            loading.Font = new Font("Tahoma", 14);
            loading.ForeColor = Color.Black;
            loading.AutoSize = true;
            loading.Location = new Point(2*(this.Width)/ 5, this.Height / 2);
            DangKy f = new DangKy();           
            this.Controls.Add(loading);
            loading.BringToFront();
            loading.Show();
            
            await Task.Delay(1500); // Giả lập thời gian xử lý nặng
            this.Hide();
            f.ShowDialog();
            this.Controls.Remove(loading); // Gỡ thông báo sau khi hoàn tất
            this.Show();
            // Hiển thị form sau khi tác vụ hoàn thành
        }
    }
}
