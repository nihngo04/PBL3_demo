using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.DB; // Đảm bảo bạn đã thêm namespace cho DBHelper

namespace PBL3
{
    public partial class GymDataForm : Form
    {
        private DataTable Member, PT, Recep, Machine, Invoice, Pack;
        private DataTable[] tabData;
        private int currentTabIndex;

        public GymDataForm()
        {
            InitializeComponent();
            InitializeTabControl();
            LoadDataFromDatabase();
            InitializeSortComboBox_Menber();
            InitializeSortComboBox_PT();
            InitializeSortComboBox_Recep();
        }

        private void LoadDataFromDatabase()
        {
            Member = DBHelper.Instance.GetRecord("SELECT * FROM Khach");
            PT = DBHelper.Instance.GetRecord("SELECT * FROM Huan_luyen_vien");
            Recep = DBHelper.Instance.GetRecord("SELECT * FROM Nhan_vien_le_tan");
            Machine = DBHelper.Instance.GetRecord("SELECT * FROM May_tap");
            Pack = DBHelper.Instance.GetRecord("SELECT * FROM Goi_tap");
            Invoice = DBHelper.Instance.GetRecord("SELECT * FROM Hoa_don");
            DGV_Mem.DataSource = Member;
            DGV_PT.DataSource = PT;
            DGV_Recep.DataSource = Recep;
            DGV_Machine.DataSource = Machine;
            DGV_Pack.DataSource = Pack;
            DGV_Invoice.DataSource = Invoice;
        }

        private void InitializeTabControl()
        {
            tabControlGym.SelectedIndexChanged += TabControl1_SelectedIndexChanged;
        }

        private void InitializeSortComboBox_Menber()
        {
            cbbSort.Items.Add("ID_khach");
            cbbSort.Items.Add("Ho_ten");
            cbbSort.Items.Add("Ngay_sinh");
            cbbSort.Items.Add("So_dien_thoai");
            cbbSort.Items.Add("Email");
            cbbSort.Items.Add("Gioi_tinh");
            cbbSort.Items.Add("Ma_goi_tap");
            cbbSort.Items.Add("Ngay_tham_gia");
            cbbSort.Items.Add("Ma_HLV");
            cbbSort.Items.Add("Dia_chi");
        }

        private void InitializeSortComboBox_PT()
        {
            cbbSort_PT.Items.Add("Ma_HLV");
            cbbSort_PT.Items.Add("Ho_ten");
            cbbSort_PT.Items.Add("Chuyen_mon");
            cbbSort_PT.Items.Add("Kinh_nghiem");
            cbbSort_PT.Items.Add("Luong");

        }
        private void InitializeSortComboBox_Recep()
        {
            cbbSort_Recep.Items.Add("Ma_HLV");
            cbbSort_Recep.Items.Add("Ho_ten");
            cbbSort_Recep.Items.Add("Chuyen_mon");
            cbbSort_Recep.Items.Add("Luong");

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
            else if (tabControlGym.SelectedTab == tabInvoice)
            {
                DGV_Pack.DataSource = Invoice;
            }
            else if (tabControlGym.SelectedTab == tabPack)
            {
                DGV_Pack.DataSource = Pack;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Do nothing for now
        }

        private void btn_Mem_Add_Click(object sender, EventArgs e)
        {
            inforMember addmen = new inforMember();
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
            inforRecep addRecep = new inforRecep();
            addRecep.ShowDialog();
            LoadDataFromDatabase();
        }

        private void addPT_Click(object sender, EventArgs e)
        {
            inforPT addPT = new inforPT();
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
                    string query = "DELETE FROM Khach WHERE ID_khach = @ID_khach";
                    SqlParameter param = new SqlParameter("@ID_khach", maLT);
                    DBHelper.Instance.ExecuteDB(query, param);

                    // Cập nhật lại nguồn dữ liệu của DataGridView để hiển thị các thay đổi mới
                    LoadDataFromDatabase();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng trước khi thực hiện xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
                    string query = "DELETE FROM Khach WHERE ID_khach = @ID_khach";
                    SqlParameter param = new SqlParameter("@ID_khach", maPT);
                    DBHelper.Instance.ExecuteDB(query, param);

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
                    string query = "DELETE FROM Huan_luyen_vien WHERE Ma_HLV = @Ma_HLV";
                    SqlParameter param = new SqlParameter("@Ma_HLV", maPT);
                    DBHelper.Instance.ExecuteDB(query, param);

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
            if (DGV_Mem.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = DGV_Mem.SelectedRows[0];
                if (selectedRow.Cells["ID_khach"].Value != null)
                {
                    // Lấy ID_khach của dòng được chọn
                    int khachId = Convert.ToInt32(DGV_Mem.SelectedRows[0].Cells["ID_khach"].Value);

                    // Mở form inforMember với ID_khach để chỉnh sửa thông tin
                    inforMember editMemberForm = new inforMember(khachId);
                    editMemberForm.ShowDialog();

                    // Sau khi đóng form, tải lại dữ liệu để hiển thị các thay đổi mới
                    LoadDataFromDatabase();
                }
                else
                {
                    MessageBox.Show("Dòng được chọn không có thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một khách hàng để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btn_PT_Update_Click(object sender, EventArgs e)
        {
            if (DGV_PT.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = DGV_PT.SelectedRows[0];
                if (selectedRow.Cells["Ma_HLV"].Value != null)
                {

                    // Lấy ID_khach của dòng được chọn
                    string HLVId = DGV_PT.SelectedRows[0].Cells["Ma_HLV"].Value.ToString();

                    // Mở form inforMember với ID_khach để chỉnh sửa thông tin
                    inforPT editPTForm = new inforPT(HLVId);
                    editPTForm.ShowDialog();

                    // Sau khi đóng form, tải lại dữ liệu để hiển thị các thay đổi mới
                    LoadDataFromDatabase();
                }
                else
                {
                    MessageBox.Show("Dòng được chọn không có thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một huấn luyện viên để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btn_updateRecep_Click(object sender, EventArgs e)
        {
            if (DGV_Recep.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = DGV_Recep.SelectedRows[0];
                if (selectedRow.Cells["Ma_le_tan"].Value != null)
                {

                    // Lấy ID_khach của dòng được chọn
                    string LTId = DGV_Recep.SelectedRows[0].Cells["Ma_le_tan"].Value.ToString();

                    // Mở form inforMember với ID_khach để chỉnh sửa thông tin
                    inforRecep editRecepForm = new inforRecep(LTId);
                    editRecepForm.ShowDialog();

                    // Sau khi đóng form, tải lại dữ liệu để hiển thị các thay đổi mới
                    LoadDataFromDatabase();
                }
                else
                {
                    MessageBox.Show("Dòng được chọn không có thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một lễ tân để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Bắt đầu tạo truy vấn SQL tìm kiếm
            string query = @"
            SELECT * 
            FROM Khach
            WHERE 
                 ID_khach LIKE @Keyword OR
                 Ho_ten LIKE @Keyword OR 
                 Dia_chi LIKE @Keyword OR 
                 Gioi_tinh LIKE @Keyword OR 
                 So_dien_thoai LIKE @Keyword OR 
                 Email LIKE @Keyword OR 
                 Ma_goi_tap LIKE @Keyword OR 
                 Ma_HLV LIKE @Keyword";

            List<SqlParameter> parameters = new List<SqlParameter>
            {
            new SqlParameter("@Keyword", "%" + keyword + "%")
            };

            // Kiểm tra xem từ khóa có phải là một ngày hợp lệ hay không
            if (DateTime.TryParse(keyword, out DateTime dateValue))
            {
                query += " OR CONVERT(date, Ngay_sinh) = @DateValue OR CONVERT(date, Ngay_tham_gia) = @DateValue";
                parameters.Add(new SqlParameter("@DateValue", dateValue));
            }
            // Kiểm tra xem từ khóa có phải là một tháng hợp lệ hay không
            else if (int.TryParse(keyword, out int month) && month >= 1 && month <= 12)
            {
                query += " OR MONTH(Ngay_sinh) = @Month OR MONTH(Ngay_tham_gia) = @Month";
                parameters.Add(new SqlParameter("@Month", month));
            }
            // Kiểm tra xem từ khóa có phải là một năm hợp lệ hay không
            else if (int.TryParse(keyword, out int year))
            {
                query += " OR YEAR(Ngay_sinh) = @Year OR YEAR(Ngay_tham_gia) = @Year";
                parameters.Add(new SqlParameter("@Year", year));
            }

            try
            {
                DataTable searchResult = DBHelper.Instance.GetRecord(query, parameters.ToArray());
                DGV_Mem.DataSource = searchResult;

                if (searchResult.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy kết quả nào.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            string selectedColumn = cbbSort.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedColumn))
            {
                MessageBox.Show("Vui lòng chọn cột để sắp xếp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string query = $@"
            SELECT * 
            FROM Khach
            ORDER BY {selectedColumn}";

            try
            {
                DataTable sortedResult = DBHelper.Instance.GetRecord(query);
                DGV_Mem.DataSource = sortedResult;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_PT_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch_PT.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Bắt đầu tạo truy vấn SQL tìm kiếm
            string query = @"
            SELECT * 
            FROM Huan_luyen_vien
            WHERE 
                 Ma_HLV LIKE @Keyword OR
                 Ho_ten LIKE @Keyword OR 
                 Chuyen_mon LIKE @Keyword OR 
                 Kinh_nghiem LIKE @Keyword OR
                 Luong LIKE @Keyword "
                ;

            List<SqlParameter> parameters = new List<SqlParameter>
            {
            new SqlParameter("@Keyword", "%" + keyword + "%")
            };

            try
            {
                DataTable searchResult = DBHelper.Instance.GetRecord(query, parameters.ToArray());
                DGV_PT.DataSource = searchResult;

                if (searchResult.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy kết quả nào.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSort_PT_Click(object sender, EventArgs e)
        {
            string selectedColumn = cbbSort_PT.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedColumn))
            {
                MessageBox.Show("Vui lòng chọn cột để sắp xếp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string query = $@"
            SELECT * 
            FROM Huan_luyen_vien
            ORDER BY {selectedColumn}";

            try
            {
                DataTable sortedResult = DBHelper.Instance.GetRecord(query);
                DGV_PT.DataSource = sortedResult;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Recep_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch_Recep.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Bắt đầu tạo truy vấn SQL tìm kiếm
            string query = @"
            SELECT * 
            FROM Nhan_vien_le_tan
            WHERE 
                 Ma_le_tan LIKE @Keyword OR
                 Ho_ten LIKE @Keyword OR 
                 Chuyen_mon LIKE @Keyword OR 
                 Luong LIKE @Keyword "
                ;

            List<SqlParameter> parameters = new List<SqlParameter>
            {
            new SqlParameter("@Keyword", "%" + keyword + "%")
            };

            try
            {
                DataTable searchResult = DBHelper.Instance.GetRecord(query, parameters.ToArray());
                DGV_Recep.DataSource = searchResult;

                if (searchResult.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy kết quả nào.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSort_Recep_Click(object sender, EventArgs e)
        {
            string selectedColumn = cbbSort_Recep.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedColumn))
            {
                MessageBox.Show("Vui lòng chọn cột để sắp xếp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string query = $@"
            SELECT * 
            FROM Nhan_vien_le_tan
            ORDER BY {selectedColumn}";

            try
            {
                DataTable sortedResult = DBHelper.Instance.GetRecord(query);
                DGV_Recep.DataSource = sortedResult;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

