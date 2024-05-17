using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3
{
    public partial class inforInvoice : Form
    {
        public inforInvoice()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}

/*using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlClient;
using System.ComponentModel.Design;

namespace PBL3
{
    public partial class GymDataForm : Form
    {
        string s = @"Data Source=LAPTOP-IL246S2S\SQLEXPRESS01;Initial Catalog=DEMO_GYMSYSTEM;Integrated Security=True";
        SqlConnection con;
        SqlDataAdapter adt;
        private DataTable Member, PT, Recep, Machine;
        private DataTable[] tabData;
        private int currentTabIndex;
        public GymDataForm()
        {
            InitializeComponent();
            InitializeTabControl();
            LoadDataFromDatabase();
        }
        private void LoadDataFromDatabase()
        {
            using (SqlConnection con = new SqlConnection(s))
            {
                con.Open();
                string queryMem = "SELECT * FROM Khach";
                using (SqlCommand commandMem = new SqlCommand(queryMem, con))
                {
                    SqlDataAdapter adapterMem = new SqlDataAdapter(commandMem);
                    Member = new DataTable();
                    adapterMem.Fill(Member);
                }
                string queryPT = "SELECT * FROM Huan_luyen_vien";
                using (SqlCommand commandPT = new SqlCommand(queryPT, con))
                {
                    SqlDataAdapter adapterPT = new SqlDataAdapter(commandPT);
                    PT = new DataTable();
                    adapterPT.Fill(PT);
                }
                string queryRecep = "select * from Nhan_vien_le_tan";
                using (SqlCommand commandRecep = new SqlCommand(queryRecep, con))
                {
                    SqlDataAdapter adapterRecep = new SqlDataAdapter(commandRecep);
                    Recep = new DataTable();
                    adapterRecep.Fill(Recep);
                }
                string queryMachine = "select * from May_tap";
                using (SqlCommand commandMachine = new SqlCommand(queryMachine, con))
                {
                    SqlDataAdapter adapterMachine = new SqlDataAdapter(commandMachine);
                    Machine = new DataTable();
                    adapterMachine.Fill(Machine);
                }
            }
            DGV_Mem.DataSource = Member;
            DGV_PT.DataSource = PT;
            DGV_Recep.DataSource = Recep;
            DGV_Machine.DataSource = Machine;
        }
        private void InitializeTabControl()
        {
            tabControlGym.SelectedIndexChanged += TabControl1_SelectedIndexChanged;
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlGym.SelectedTab == tabMem)
            {
                DGV_Mem.DataSource = Member;
            }
            else if (tabControlGym.SelectedTab == tabPT)
            {
                DGV_PT.DataSource = PT;
            }
            else if (tabControlGym.SelectedTab == tabReceptiionist)
            {
                DGV_Recep.DataSource = Recep;
            }
            else if (tabControlGym.SelectedTab == tabMachine)
            {
                DGV_Machine.DataSource = Machine;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Mem_Add_Click(object sender, EventArgs e)
        {
            addMember addmen = new addMember();
            addmen.ShowDialog(); // Sử dụng ShowDialog để đảm bảo form mới hiển thị và chờ đợi cho đến khi nó đóng lại
            LoadDataFromDatabase();
        }

        private void bt_soluongkhach_Click(object sender, EventArgs e)
        {
            int numberOfMembers = Member.Rows.Count;
            MessageBox.Show("Số lượng khách hàng: " + numberOfMembers.ToString(), "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void addReceptionist_Click(object sender, EventArgs e)
        {
            addRecep addRecep = new addRecep();
            addRecep.ShowDialog();
            LoadDataFromDatabase();
        }

        private void addPT_Click(object sender, EventArgs e)
        {
            addPT addPT = new addPT();
            addPT.ShowDialog();
            LoadDataFromDatabase();
        }

        private void btnDeleteRecep_Click(object sender, EventArgs e)
        {
            if (DGV_Recep.SelectedRows.Count > 0)
            {
                // Lấy dòng được chọn
                DataGridViewRow selectedRow = DGV_Recep.SelectedRows[0];

                // Lấy khóa chính của dòng được chọn
                string maLT = selectedRow.Cells["ID_khach"].Value.ToString();

                // Xác nhận việc xóa
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dòng này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Thực hiện truy vấn SQL DELETE để xóa dữ liệu từ bảng cơ sở dữ liệu
                    using (SqlConnection connection = new SqlConnection(s))
                    {
                        connection.Open();
                        string query = "DELETE FROM Khach WHERE ID_khach = @ID_khach";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@ID_khach", maLT);
                            command.ExecuteNonQuery();
                        }
                    }

                    // Cập nhật lại nguồn dữ liệu của DataGridView để hiển thị các thay đổi mới
                    LoadDataFromDatabase();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng trước khi thực hiện xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        *//*private void btn_updateRecep_Click(object sender, EventArgs e)
        {
            // Lặp qua từng dòng trong DataGridView để cập nhật thông tin
            foreach (DataGridViewRow row in DGV_Recep.Rows)
            {
                // Kiểm tra nếu dòng không phải là dòng mới
                if (!row.IsNewRow)
                {
                    // Lấy thông tin từ các ô trong dòng
                    string maRecep = row.Cells["Ma_le_tan"].Value != null ? row.Cells["Ma_le_tan"].Value.ToString() : "";
                    string hoTen = row.Cells["Ho_ten"].Value != null ? row.Cells["Ho_ten"].Value.ToString() : "";
                    string chuyenMon = row.Cells["Chuyen_mon"].Value != null ? row.Cells["Chuyen_mon"].Value.ToString() : "";
                    decimal luong = 0;
                    if (row.Cells["Luong"].Value != null && decimal.TryParse(row.Cells["Luong"].Value.ToString(), out luong))
                    {
                        // Thực hiện truy vấn SQL UPDATE để cập nhật thông tin nhân viên lễ tân
                        using (SqlConnection connection = new SqlConnection(s))
                        {
                            connection.Open();
                            string query = "UPDATE Nhan_vien_le_tan SET Ho_ten = @Ho_ten, Chuyen_mon = @Chuyen_mon, Luong = @Luong WHERE Ma_le_tan = @Ma_Recep";
                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@Ho_ten", hoTen);
                                command.Parameters.AddWithValue("@Chuyen_mon", chuyenMon);
                                command.Parameters.AddWithValue("@Luong", luong);
                                command.Parameters.AddWithValue("@Ma_Recep", maRecep);
                                command.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }

            // Sau khi cập nhật, thông báo cho người dùng biết rằng dữ liệu đã được cập nhật thành công
            MessageBox.Show("Thông tin nhân viên lễ tân đã được cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }*//*
        private void btn_updateRecep_Click(object sender, EventArgs e)
        {
            // Lặp qua từng dòng trong DataGridView để cập nhật thông tin
            foreach (DataGridViewRow row in DGV_Recep.SelectedRows)
            {
                // Kiểm tra nếu dòng không phải là dòng mới và có giá trị khóa chính
                if (row.Cells["Ma_le_tan"].Value != null)
                {
                    // Lấy thông tin từ các ô trong dòng
                    string maRecep = row.Cells["Ma_le_tan"].Value.ToString();
                    string hoTen = row.Cells["Ho_ten"].Value != null ? row.Cells["Ho_ten"].Value.ToString() : "";
                    string chuyenMon = row.Cells["Chuyen_mon"].Value != null ? row.Cells["Chuyen_mon"].Value.ToString() : "";

                    // Thực hiện truy vấn SQL UPDATE để cập nhật thông tin nhân viên lễ tân
                    using (SqlConnection connection = new SqlConnection(s))
                    {
                        connection.Open();
                        string query = "UPDATE Nhan_vien_le_tan SET Ho_ten = @Ho_ten, Chuyen_mon = @Chuyen_mon WHERE Ma_le_tan = @Ma_Recep";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Ho_ten", hoTen);
                            command.Parameters.AddWithValue("@Chuyen_mon", chuyenMon);
                            command.Parameters.AddWithValue("@Ma_Recep", maRecep);
                            command.ExecuteNonQuery();
                        }
                    }
                }
                else
                {
                    // Nếu dòng không có giá trị khóa chính, báo lỗi và dừng cập nhật
                    MessageBox.Show("Cập nhật thông tin thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LoadDataFromDatabase();
                    return;
                }
            }

            // Sau khi cập nhật, thông báo cho người dùng biết rằng dữ liệu đã được cập nhật thành công
            MessageBox.Show("Thông tin nhân viên lễ tân đã được cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_Mem_Del_Click(object sender, EventArgs e)
        {
            if (DGV_Mem.SelectedRows.Count > 0)
            {
                // Lấy dòng được chọn
                DataGridViewRow selectedRow = DGV_Mem.SelectedRows[0];

                // Lấy khóa chính của dòng được chọn
                string maPT = selectedRow.Cells["ID_khach"].Value.ToString();

                // Xác nhận việc xóa
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dòng này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Thực hiện truy vấn SQL DELETE để xóa dữ liệu từ bảng cơ sở dữ liệu
                    using (SqlConnection connection = new SqlConnection(s))
                    {
                        connection.Open();
                        string query = "DELETE FROM Khach WHERE ID_khach = @ID_khach";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@ID_khach", maPT);
                            command.ExecuteNonQuery();
                        }
                    }

                    // Cập nhật lại nguồn dữ liệu của DataGridView để hiển thị các thay đổi mới
                    LoadDataFromDatabase();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng trước khi thực hiện xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_PT_del_Click(object sender, EventArgs e)
        {
            if (DGV_PT.SelectedRows.Count > 0)
            {
                // Lấy dòng được chọn
                DataGridViewRow selectedRow = DGV_PT.SelectedRows[0];

                // Lấy khóa chính của dòng được chọn
                string maPT = selectedRow.Cells["Ma_HLV"].Value.ToString();

                // Xác nhận việc xóa
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dòng này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Thực hiện truy vấn SQL DELETE để xóa dữ liệu từ bảng cơ sở dữ liệu
                    using (SqlConnection connection = new SqlConnection(s))
                    {
                        connection.Open();
                        string query = "DELETE FROM Huan_luyen_vien WHERE Ma_HLV = @Ma_HLV";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Ma_HLV", maPT);
                            command.ExecuteNonQuery();
                        }
                    }

                    // Cập nhật lại nguồn dữ liệu của DataGridView để hiển thị các thay đổi mới
                    LoadDataFromDatabase();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng trước khi thực hiện xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_Mem_Update_Click(object sender, EventArgs e)
        {
            bool hasError = false; // Biến để kiểm tra xem có lỗi không

            // Lặp qua từng dòng trong DataGridView để cập nhật thông tin
            foreach (DataGridViewRow row in DGV_Mem.SelectedRows)
            {
                // Kiểm tra nếu dòng không phải là dòng mới và có giá trị cho khóa chính "ID_khach"
                if (!row.IsNewRow && row.Cells["ID_khach"].Value != null && !string.IsNullOrEmpty(row.Cells["ID_khach"].Value.ToString()))
                {
                    // Lấy thông tin từ các ô trong dòng
                    string idKhach = row.Cells["ID_khach"].Value.ToString();
                    string maGoiTap = row.Cells["Ma_goi_tap"].Value != null ? row.Cells["Ma_goi_tap"].Value.ToString() : "";
                    string maHLV = row.Cells["Ma_HLV"].Value != null ? row.Cells["Ma_HLV"].Value.ToString() : "";
                    string hoTen = row.Cells["Ho_ten"].Value != null ? row.Cells["Ho_ten"].Value.ToString() : "";
                    string ngaySinh = row.Cells["Ngay_sinh"].Value != null ? row.Cells["Ngay_sinh"].Value.ToString() : "";
                    string gioiTinh = row.Cells["Gioi_tinh"].Value != null ? row.Cells["Gioi_tinh"].Value.ToString() : "";
                    string soDienThoai = row.Cells["So_dien_thoai"].Value != null ? row.Cells["So_dien_thoai"].Value.ToString() : "";
                    string email = row.Cells["Email"].Value != null ? row.Cells["Email"].Value.ToString() : "";
                    string ngayThamGia = row.Cells["Ngay_tham_gia"].Value != null ? row.Cells["Ngay_tham_gia"].Value.ToString() : "";
                    string diaChi = row.Cells["Dia_chi"].Value != null ? row.Cells["Dia_chi"].Value.ToString() : "";

                    // Thực hiện truy vấn SQL UPDATE để cập nhật thông tin thành viên trong bảng [Khach]
                    using (SqlConnection connection = new SqlConnection(s))
                    {
                        connection.Open();
                        string query = "UPDATE Khach SET Ma_goi_tap = @Ma_goi_tap, Ma_HLV = @Ma_HLV, Ho_ten = @Ho_ten, Ngay_sinh = @Ngay_sinh, Gioi_tinh = @Gioi_tinh, So_dien_thoai = @So_dien_thoai, Email = @Email, Ngay_tham_gia = @Ngay_tham_gia, Dia_chi = @Dia_chi WHERE ID_khach = @ID_khach";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Ma_goi_tap", maGoiTap);
                            command.Parameters.AddWithValue("@Ma_HLV", maHLV);
                            command.Parameters.AddWithValue("@Ho_ten", hoTen);
                            command.Parameters.AddWithValue("@Ngay_sinh", ngaySinh);
                            command.Parameters.AddWithValue("@Gioi_tinh", gioiTinh);
                            command.Parameters.AddWithValue("@So_dien_thoai", soDienThoai);
                            command.Parameters.AddWithValue("@Email", email);
                            command.Parameters.AddWithValue("@Ngay_tham_gia", ngayThamGia);
                            command.Parameters.AddWithValue("@Dia_chi", diaChi);
                            command.Parameters.AddWithValue("@ID_khach", idKhach);
                            command.ExecuteNonQuery();
                        }
                    }
                }
                else if (!row.IsNewRow)
                {
                    // Nếu dòng không có giá trị cho khóa chính, đặt biến hasError thành true
                    hasError = true;
                    // Hiển thị thông báo lỗi
                    MessageBox.Show("Dòng nhập vào thiếu thông tin khóa chính!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Kiểm tra xem có lỗi không trước khi hiển thị thông báo thành công
            if (!hasError)
            {
                // Sau khi cập nhật, thông báo cho người dùng biết rằng dữ liệu đã được cập nhật thành công
                MessageBox.Show("Thông tin thành viên đã được cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_PT_Update_Click_Click(object sender, EventArgs e)
        {

            // Lặp qua từng dòng trong DataGridView để cập nhật thông tin
            foreach (DataGridViewRow row in DGV_PT.SelectedRows)
            {
                // Kiểm tra nếu dòng không phải là dòng mới và có giá trị cho khóa chính "Ma_HLV"
                if (!row.IsNewRow && row.Cells["Ma_HLV"].Value != null && !string.IsNullOrEmpty(row.Cells["Ma_HLV"].Value.ToString()))
                {
                    // Lấy thông tin từ các ô trong dòng
                    string maHLV = row.Cells["Ma_HLV"].Value.ToString();
                    string hoTen = row.Cells["Ho_ten"].Value != null ? row.Cells["Ho_ten"].Value.ToString() : "";
                    string chuyenMon = row.Cells["Chuyen_mon"].Value != null ? row.Cells["Chuyen_mon"].Value.ToString() : "";
                    string kinhNghiem = row.Cells["Kinh_nghiem"].Value != null ? row.Cells["Kinh_nghiem"].Value.ToString() : "";
                    int luong = 0;
                    {
                        // Thực hiện truy vấn SQL UPDATE để cập nhật thông tin huấn luyện viên trong bảng [Huan_luyen_vien]
                        using (SqlConnection connection = new SqlConnection(s))
                        {
                            connection.Open();
                            string query = "UPDATE [Huan_luyen_vien] SET Ho_ten = @Ho_ten, Chuyen_mon = @Chuyen_mon, Kinh_nghiem = @Kinh_nghiem, Luong = @Luong WHERE Ma_HLV = @Ma_HLV";
                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@Ho_ten", hoTen);
                                command.Parameters.AddWithValue("@Chuyen_mon", chuyenMon);
                                command.Parameters.AddWithValue("@Kinh_nghiem", kinhNghiem);
                                command.Parameters.AddWithValue("@Luong", luong);
                                command.Parameters.AddWithValue("@Ma_HLV", maHLV);
                                command.ExecuteNonQuery();
                            }
                        }
                    }

                }
                else
                {
                    // Nếu dòng không có giá trị khóa chính, báo lỗi và dừng cập nhật
                    MessageBox.Show("Cập nhật thông tin thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LoadDataFromDatabase();
                    return;
                }
            }

            // Sau khi cập nhật, thông báo cho người dùng biết rằng dữ liệu đã được cập nhật thành công
            MessageBox.Show("Thông tin huán luyện viên đã được cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

     
    }
}


*/