using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using PBL3.DB; // Đảm bảo bạn đã thêm using để sử dụng DBHelper

namespace PBL3
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btlogin_Click(object sender, EventArgs e)
        {
            string query = "SELECT COUNT(*) FROM TAI_KHOAN WHERE Ten_dang_nhap = @Ten_dang_nhap AND Mat_khau = @Mat_khau";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Ten_dang_nhap", txtUsername.Text.Trim()),
                new SqlParameter("@Mat_khau", txtPass.Text.Trim())
            };

            try
            {
                DataTable dt = DBHelper.Instance.GetRecord(query, parameters);
                int count = (int)dt.Rows[0][0];

                if (count > 0)
                {
                    // Đăng nhập thành công
                    GymDataForm home = new GymDataForm();
                    home.Show();
                    this.Hide();
                }
                else
                {
                    // Sai tên người dùng hoặc mật khẩu
                    MessageBox.Show("Incorrect Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Ghi nhật ký lỗi vào tệp log
                // LogException(ex);
            }
        }
    }
}


/*using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3
{
    public partial class Login : Form
    {
        private string connectionString = "Data Source=LAPTOP-IL246S2S\\SQLEXPRESS01;Initial Catalog=DEMO_GYMSYSTEM;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        public Login()
        {
            InitializeComponent();
        }

        private void btlogin_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM TAI_KHOAN WHERE Ten_dang_nhap = @Ten_dang_nhap AND Mat_khau = @Mat_khau";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Ten_dang_nhap", txtUsername.Text.Trim());
                        command.Parameters.AddWithValue("@Mat_khau", txtPass.Text.Trim());

                        int count = (int)command.ExecuteScalar();
                        if (count > 0)
                        {
                            // Đăng nhập thành công
                            GymDataForm home = new GymDataForm();
                            home.Show();
                            this.Hide();
                        }
                        else
                        {
                            // Sai tên người dùng hoặc mật khẩu
                            MessageBox.Show("Incorrect Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Ghi nhật ký lỗi vào tệp log
                    // LogException(ex);
                }
            }
        }

    }
}
*/