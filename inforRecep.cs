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
using PBL3.DB;

namespace PBL3
{
    public partial class inforRecep : Form
    {
        private string? _LTId = null;
        public inforRecep()
        {
            InitializeComponent();
        }

        public inforRecep(string LTId) : this()
        {
            _LTId = LTId;
            LoadRecepData(LTId);
        }

        private void LoadRecepData(string LTId)
        {
            string query = "SELECT * FROM Nhan_vien_le_tan WHERE Ma_le_tan = @Ma_le_tan";
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@Ma_le_tan", LTId)
            };
            DataTable dt = DBHelper.Instance.GetRecord(query, parameters);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                txtMaLT.Text = row["Ma_le_tan"].ToString();
                txtName.Text = row["Ho_ten"].ToString();
                txtChuyenmon.Text = row["Chuyen_mon"].ToString();
                txtSalary.Text = row["Luong"].ToString();
            }
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các trường nhập liệu
            string maLT = txtMaLT.Text.Trim();
            string hoTen = txtName.Text.Trim();
            string chuyenMon = txtChuyenmon.Text.Trim();
            float luong = float.Parse(txtSalary.Text.Trim());

            // Tạo kết nối đến cơ sở dữ liệu
            if (!string.IsNullOrEmpty(_LTId))
            {
                string query = "UPDATE Nhan_vien_le_tan SET Ma_le_tan = @Ma_le_tan, Ho_ten = @Ho_ten, Chuyen_mon = @Chuyen_mon, Luong = @Luong WHERE Ma_le_tan = @Ma_le_tan";
                SqlParameter[] parameters = new SqlParameter[]
                {
            new SqlParameter("@Ma_le_tan", maLT),
            new SqlParameter("@Ho_ten", hoTen),
            new SqlParameter("@Chuyen_mon", chuyenMon),
            new SqlParameter("@Luong", luong)
                };

                try
                {
                    DBHelper.Instance.ExecuteDB(query, parameters);
                    MessageBox.Show("Data updated successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                // Insert new record
                string query = "INSERT INTO Nhan_vien_le_tan (Ma_le_tan, Ho_ten, Chuyen_mon, Luong) " +
                               "VALUES (@Ma_le_tan, @Ho_ten, @Chuyen_mon, @Luong)";
                SqlParameter[] parameters = new SqlParameter[]
                {
            new SqlParameter("@Ma_HLV", maLT),
            new SqlParameter("@Ho_ten", hoTen),
            new SqlParameter("@Chuyen_mon", chuyenMon),
            new SqlParameter("@Luong", luong)
                };

                try
                {
                    DBHelper.Instance.ExecuteDB(query, parameters);
                    MessageBox.Show("Data saved successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        /*private void bt_save_Click(object sender, EventArgs e)
        {
            // Retrieve data from input fields
            string maLT = txtMaLT.Text.Trim();
            string hoten = txtName.Text;
            string chuyenmon = txtChuyenmon.Text;
            string luong = txtSalary.Text;

            // Establish connection
            using (SqlConnection connection = new SqlConnection(strCon))
            {
                // Prepare SQL query
                string query = "INSERT INTO Nhan_vien_le_tan (Ma_le_tan, Ho_ten, Chuyen_mon, Luong) " +
                               "VALUES (@Ma_le_tan, @Ho_ten, @Chuyen_mon, @Luong)";

                // Create SQL command with parameters
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters
                    command.Parameters.AddWithValue("@Ma_le_tan", maLT);
                    command.Parameters.AddWithValue("@Ho_ten", hoten);
                    command.Parameters.AddWithValue("@Chuyen_mon", chuyenmon);
                    command.Parameters.AddWithValue("@Luong", luong);


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
        }*/

        private void btcancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
