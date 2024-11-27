using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTDLGT_De8_BinarySearchTree
{
    public partial class DangKy : Form
    {
        Label missingValue = new Label();
        public DangKy()
        {
            InitializeComponent();
            EnableDoubleBuffering();
            missingValue.AutoSize = true;
            missingValue.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            missingValue.BackColor = Color.Transparent;
            missingValue.ForeColor = Color.OrangeRed;
            missingValue.Location = new Point(400, 603);
            missingValue.Name = "missingValue";
            missingValue.Size = new Size(305, 25);
            missingValue.TabIndex = 2;
            this.Controls.Add(missingValue);
            missingValue.Hide();
        }

        private void Register(string username, string password)
        {
            // Thêm tài khoản mới vào SharedData
            SignInAccount.Accounts.Add((username, password));
        }
        public void EnableDoubleBuffering()
        {
            this.DoubleBuffered = true; // Kích hoạt Double Buffering
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();
        }

        private void signinButton_Click(object sender, EventArgs e)
        {

            
            if (Account.Text.Trim().Equals("") || Password.Text.Trim().Equals(""))
            {
                missingValue.Text = "Vui lòng nhập đủ tên và mật khẩu";
                missingValue.BringToFront();
                missingValue.Show();
            }
            else
            {
                if (textBox1.Text.Trim().Equals("CTDLGT-DE8"))
                {
                    Register(Account.Text.Trim(), Password.Text.Trim());
                    DialogResult done = MessageBox.Show("Đăng ký thành công. Hãy thử quay về đăng nhập", "Đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if(done == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
                else
                {
                    missingValue.Hide();
                    missingValue.Text = "Mã xác thực không chính xác!";
                    missingValue.BringToFront();
                    missingValue.Show();
                }

            }            
        }
    }
    public static class SignInAccount
    {
        // Danh sách lưu trữ tài khoản
        public static List<(string Username, string Password)> Accounts = new List<(string, string)>
        {
            ("User123", "123456") // Tài khoản mặc định
        };
    }
}
