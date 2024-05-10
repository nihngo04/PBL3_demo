using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3
{
    public partial class addPT : Form
    {
        public addPT()
        {
            InitializeComponent();
        }

        String strCon = @"Data Source=LAPTOP-IL246S2S\SQLEXPRESS01;Initial Catalog=DEMO_GYMSYSTEM;Integrated Security=True;";
        SqlConnection sqlCon = null;
        private void bt_savePT_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các trường nhập liệu
            string maHLV = txtmaso.Text.Trim();
            string hoTen = txtName.Text.Trim();
            string chuyenMon = txtChuyenmon.Text.Trim();
            string kinhNghiem = txtKinhnghiem.Text.Trim();
            decimal luong = Convert.ToDecimal(txtLuong.Text.Trim()); // Chuyển đổi dữ liệu nhập liệu sang kiểu decimal

            // Tạo kết nối đến cơ sở dữ liệu
            using (SqlConnection connection = new SqlConnection(strCon))
            {
                // Câu lệnh SQL thêm dữ liệu vào bảng HLV
                string query = "INSERT INTO Huan_luyen_vien (Ma_HLV, Ho_ten, Chuyen_mon, Kinh_nghiem, Luong) " +
                               "VALUES (@Ma_HLV, @Ho_ten, @Chuyen_mon, @Kinh_nghiem, @Luong)";

                // Tạo và thực thi câu lệnh SQL
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Thêm tham số vào câu lệnh SQL
                    command.Parameters.AddWithValue("@Ma_HLV", maHLV);
                    command.Parameters.AddWithValue("@Ho_ten", hoTen);
                    command.Parameters.AddWithValue("@Chuyen_mon", chuyenMon);
                    command.Parameters.AddWithValue("@Kinh_nghiem", kinhNghiem);
                    command.Parameters.AddWithValue("@Luong", luong);

                    try
                    {
                        // Mở kết nối đến cơ sở dữ liệu và thực thi câu lệnh
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Thêm thành công!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }
        }

        private void btcancel_Click(object sender, EventArgs e)
        {
            // Đóng form khi nhấn nút Cancel
            this.Close();
        }
    }
}
