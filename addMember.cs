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
    public partial class addMember : Form
    {
        public addMember()
        {
            InitializeComponent();
            AddItemsToPackageComboBox();
        }
        String strCon = @"Data Source=LAPTOP-IL246S2S\SQLEXPRESS01;Initial Catalog=DEMO_GYMSYSTEM;Integrated Security=True;";
        SqlConnection sqlCon = null;
        private void label10_Click(object sender, EventArgs e)
        {

        }
        private void AddItemsToPackageComboBox()
        {
            // Thêm các mục vào ComboBox cbbgoitap
            cbbgoitap.Items.Add("01 buổi");
            cbbgoitap.Items.Add("01 tháng");
            cbbgoitap.Items.Add("03 tháng");
            cbbgoitap.Items.Add("06 tháng");
            cbbgoitap.Items.Add("12 tháng");
        }


        private void btsave_Click(object sender, EventArgs e)
        {
            // Retrieve data from input fields
            string hoten = txthoten.Text;
            DateTime ngaysinh = dateTimePicker1.Value;
            string sdt = txtsdt.Text;
            string email = txtemail.Text;
            bool gioitinh = radioNam.Checked; // true nếu checked, false nếu không

            string goitap = cbbgoitap.SelectedItem.ToString();
            string magoitap = GetMaGoiTap(goitap);
            DateTime ngaythamgia = dateTimePicker2.Value;
            string HLV = txtHLV.Text;
            string diachi = richTextBox1.Text;

            // Establish connection
            using (SqlConnection connection = new SqlConnection(strCon))
            {
                // Prepare SQL query
                string query = "INSERT INTO Khach (Ho_ten, Ngay_sinh, So_dien_thoai, Email, Gioi_tinh, Ma_goi_tap, Ngay_tham_gia, Ma_HLV, Dia_chi) " +
                               "VALUES (@Ho_ten, @Ngay_sinh, @So_dien_thoai, @Email, @Gioi_tinh, @Ma_goi_tap, @Ngay_tham_gia, @Ma_HLV, @Dia_chi)";

                // Create SQL command with parameters
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters
                    command.Parameters.AddWithValue("@Ho_ten", hoten);
                    command.Parameters.AddWithValue("@Ngay_sinh", ngaysinh);
                    command.Parameters.AddWithValue("@So_dien_thoai", sdt);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Gioi_tinh", gioitinh);
                    command.Parameters.AddWithValue("@Ma_goi_tap", magoitap);
                    command.Parameters.AddWithValue("@Ngay_tham_gia", ngaythamgia);
                    command.Parameters.AddWithValue("@Ma_HLV", HLV);
                    command.Parameters.AddWithValue("@Dia_chi", diachi);

                    // Open connection and execute query
                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Data saved successfully!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
        private void btcancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private string GetMaGoiTap(string goiTap)
        {
            string maGoiTap = "";
            switch (goiTap)
            {
                case "01 tháng":
                    maGoiTap = "GT01";
                    break;
                case "03 tháng":
                    maGoiTap = "GT03";
                    break;
                case "06 tháng":
                    maGoiTap = "GT06";
                    break;
                case "12 tháng":
                    maGoiTap = "GT12";
                    break;
                case "01 buổi":
                    maGoiTap = "GT1N";
                    break;
                default: break;
            }
            return maGoiTap;
        }


    }
}