using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using PBL3.DB;

namespace PBL3
{
    public partial class inforMember : Form
    {
        private int? _khachId = null;

        public inforMember()
        {
            InitializeComponent();
            AddItemsToPackageComboBox();
        }
        public inforMember(int khachId) : this()
        {
            _khachId = khachId;
            LoadKhachData(khachId);
        }
        private void LoadKhachData(int khachId)
        {
            string query = "SELECT Ho_ten, Ngay_sinh, So_dien_thoai, Email, Gioi_tinh, Ma_goi_tap, Ngay_tham_gia, Ma_HLV, Dia_chi FROM Khach WHERE ID_khach = @ID_khach";
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@ID_khach", khachId)
            };
            DataTable dt = DBHelper.Instance.GetRecord(query, parameters);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                txthoten.Text = row["Ho_ten"].ToString();
                dateTimePicker1.Value = Convert.ToDateTime(row["Ngay_sinh"]);
                txtsdt.Text = row["So_dien_thoai"].ToString();
                txtemail.Text = row["Email"].ToString();
                string gioiTinh = row["Gioi_tinh"].ToString();
                radioNam.Checked = gioiTinh == "Nam";
                radioNu.Checked = gioiTinh == "Nu";
                string maGoiTap = row["Ma_goi_tap"].ToString();
                cbbgoitap.SelectedItem = GetGoiTapName(maGoiTap);
                dateTimePicker2.Value = Convert.ToDateTime(row["Ngay_tham_gia"]);
                txtHLV.Text = row["Ma_HLV"].ToString();
                richTextBox1.Text = row["Dia_chi"].ToString();
            }
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
            string hoten = txthoten.Text;
            DateTime ngaysinh = dateTimePicker1.Value;
            string sdt = txtsdt.Text;
            string email = txtemail.Text;
            string gioitinh = radioNam.Checked ? "Nam" : "Nu";
            string goitap = cbbgoitap.SelectedItem.ToString();
            string magoitap = GetMaGoiTap(goitap);
            DateTime ngaythamgia = dateTimePicker2.Value;
            string HLV = txtHLV.Text;
            string diachi = richTextBox1.Text;

            if (_khachId.HasValue)
            {
                // Update existing record
                string query = "UPDATE Khach SET Ho_ten = @Ho_ten, Ngay_sinh = @Ngay_sinh, So_dien_thoai = @So_dien_thoai, Email = @Email, Gioi_tinh = @Gioi_tinh, Ma_goi_tap = @Ma_goi_tap, Ngay_tham_gia = @Ngay_tham_gia, Ma_HLV = @Ma_HLV, Dia_chi = @Dia_chi WHERE ID_khach = @ID_khach";
                SqlParameter[] parameters = new SqlParameter[]
                {
                new SqlParameter("@Ho_ten", hoten),
                new SqlParameter("@Ngay_sinh", ngaysinh),
                new SqlParameter("@So_dien_thoai", sdt),
                new SqlParameter("@Email", email),
                new SqlParameter("@Gioi_tinh", gioitinh),
                new SqlParameter("@Ma_goi_tap", magoitap),
                new SqlParameter("@Ngay_tham_gia", ngaythamgia),
                new SqlParameter("@Ma_HLV", HLV),
                new SqlParameter("@Dia_chi", diachi),
                new SqlParameter("@ID_khach", _khachId.Value)
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
                string query = "INSERT INTO Khach (Ho_ten, Ngay_sinh, So_dien_thoai, Email, Gioi_tinh, Ma_goi_tap, Ngay_tham_gia, Ma_HLV, Dia_chi) " +
                               "VALUES (@Ho_ten, @Ngay_sinh, @So_dien_thoai, @Email, @Gioi_tinh, @Ma_goi_tap, @Ngay_tham_gia, @Ma_HLV, @Dia_chi)";
                SqlParameter[] parameters = new SqlParameter[]
                {
                new SqlParameter("@Ho_ten", hoten),
                new SqlParameter("@Ngay_sinh", ngaysinh),
                new SqlParameter("@So_dien_thoai", sdt),
                new SqlParameter("@Email", email),
                new SqlParameter("@Gioi_tinh", gioitinh),
                new SqlParameter("@Ma_goi_tap", magoitap),
                new SqlParameter("@Ngay_tham_gia", ngaythamgia),
                new SqlParameter("@Ma_HLV", HLV),
                new SqlParameter("@Dia_chi", diachi)
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
        private string GetGoiTapName(string maGoiTap)
        {
            string goiTap = "";
            switch (maGoiTap)
            {
                case "GT01":
                    goiTap = "01 tháng";
                    break;
                case "GT03":
                    goiTap = "03 tháng";
                    break;
                case "GT06":
                    goiTap = "06 tháng";
                    break;
                case "GT12":
                    goiTap = "12 tháng";
                    break;
                case "GT1N":
                    goiTap = "01 buổi";
                    break;
                default:
                    goiTap = "";
                    break;
            }
            return goiTap;
        }
    }
}

