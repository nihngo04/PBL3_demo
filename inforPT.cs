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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PBL3
{
    public partial class inforPT : Form
    {
        private string? _HLVId = null;

        public inforPT()
        {
            InitializeComponent();
        }
        public inforPT(string HLVId) : this()
        {
            _HLVId = HLVId;
            LoadPTData(HLVId);
        }
        private void LoadPTData(string HLVId)
        {
            string query = "SELECT * FROM Huan_luyen_vien WHERE Ma_HLV = @Ma_HLV";
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@Ma_HLV", HLVId)
            };
            DataTable dt = DBHelper.Instance.GetRecord(query, parameters);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                txtmaso.Text = row["Ma_HLV"].ToString();
                txtName.Text = row["Ho_ten"].ToString();
                txtChuyenmon.Text = row["Chuyen_mon"].ToString();
                txtKinhnghiem.Text = row["Kinh_nghiem"].ToString();
                txtLuong.Text = row["Luong"].ToString();
            }
        }
        private void bt_savePT_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các trường nhập liệu
            string maHLV = txtmaso.Text.Trim();
            string hoTen = txtName.Text.Trim();
            string chuyenMon = txtChuyenmon.Text.Trim();
            string kinhNghiem = txtKinhnghiem.Text.Trim();
            float luong = float.Parse(txtLuong.Text.Trim());

            // Tạo kết nối đến cơ sở dữ liệu
            if (!string.IsNullOrEmpty(_HLVId))
            {
                string query = "UPDATE Huan_luyen_vien SET Ma_HLV = @Ma_HLV, Ho_ten = @Ho_ten, Chuyen_mon = @Chuyen_mon, Kinh_nghiem = @Kinh_nghiem, Luong = @Luong WHERE Ma_HLV = @Ma_HLV";
                SqlParameter[] parameters = new SqlParameter[]
                {
            new SqlParameter("@Ma_HLV", maHLV),
            new SqlParameter("@Ho_ten", hoTen),
            new SqlParameter("@Chuyen_mon", chuyenMon),
            new SqlParameter("@Kinh_nghiem", kinhNghiem),
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
                string query = "INSERT INTO Huan_luyen_vien (Ma_HLV, Ho_ten, Chuyen_mon, Kinh_nghiem, Luong) " +
                               "VALUES (@Ma_HLV, @Ho_ten, @Chuyen_mon, @Kinh_nghiem, @Luong)";
                SqlParameter[] parameters = new SqlParameter[]
                {
            new SqlParameter("@Ma_HLV", maHLV),
            new SqlParameter("@Ho_ten", hoTen),
            new SqlParameter("@Chuyen_mon", chuyenMon),
            new SqlParameter("@Kinh_nghiem", kinhNghiem),
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

        private void btcancel_Click(object sender, EventArgs e)
        {
            // Đóng form khi nhấn nút Cancel
            this.Close();
        }
    }
}
