namespace PBL3
{
    partial class inforInvoice
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtMaHoaDon;
        private ComboBox cbbMaGoiTap;
        private ComboBox cbbMaLeTan;
        private DateTimePicker dtpNgayXuatHoaDon;
        private TextBox txtTenKhachHang;
        private TextBox txtTenGoiTap;
        private DateTimePicker dtpThoiHan;
        private TextBox txtTenHLV;
        private TextBox txtThanhTien;
        private Button btnSave_Invoice;
        private Button btnCancel_Invoice;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtMaHoaDon = new TextBox();
            cbbMaGoiTap = new ComboBox();
            cbbMaLeTan = new ComboBox();
            dtpNgayXuatHoaDon = new DateTimePicker();
            txtTenKhachHang = new TextBox();
            txtTenGoiTap = new TextBox();
            dtpThoiHan = new DateTimePicker();
            txtTenHLV = new TextBox();
            txtThanhTien = new TextBox();
            btnSave_Invoice = new Button();
            btnCancel_Invoice = new Button();
            SuspendLayout();
            // 
            // txtMaHoaDon
            // 
            txtMaHoaDon.Location = new Point(130, 30);
            txtMaHoaDon.Name = "txtMaHoaDon";
            txtMaHoaDon.Size = new Size(200, 31);
            txtMaHoaDon.TabIndex = 0;
            // 
            // cbbMaGoiTap
            // 
            cbbMaGoiTap.FormattingEnabled = true;
            cbbMaGoiTap.Location = new Point(130, 70);
            cbbMaGoiTap.Name = "cbbMaGoiTap";
            cbbMaGoiTap.Size = new Size(200, 33);
            cbbMaGoiTap.TabIndex = 1;
            // 
            // cbbMaLeTan
            // 
            cbbMaLeTan.FormattingEnabled = true;
            cbbMaLeTan.Location = new Point(130, 110);
            cbbMaLeTan.Name = "cbbMaLeTan";
            cbbMaLeTan.Size = new Size(200, 33);
            cbbMaLeTan.TabIndex = 2;
            // 
            // dtpNgayXuatHoaDon
            // 
            dtpNgayXuatHoaDon.Location = new Point(130, 150);
            dtpNgayXuatHoaDon.Name = "dtpNgayXuatHoaDon";
            dtpNgayXuatHoaDon.Size = new Size(200, 31);
            dtpNgayXuatHoaDon.TabIndex = 3;
            // 
            // txtTenKhachHang
            // 
            txtTenKhachHang.Location = new Point(130, 190);
            txtTenKhachHang.Name = "txtTenKhachHang";
            txtTenKhachHang.Size = new Size(200, 31);
            txtTenKhachHang.TabIndex = 4;
            // 
            // txtTenGoiTap
            // 
            txtTenGoiTap.Location = new Point(130, 230);
            txtTenGoiTap.Name = "txtTenGoiTap";
            txtTenGoiTap.Size = new Size(200, 31);
            txtTenGoiTap.TabIndex = 5;
            // 
            // dtpThoiHan
            // 
            dtpThoiHan.Location = new Point(130, 270);
            dtpThoiHan.Name = "dtpThoiHan";
            dtpThoiHan.Size = new Size(200, 31);
            dtpThoiHan.TabIndex = 6;
            // 
            // txtTenHLV
            // 
            txtTenHLV.Location = new Point(130, 310);
            txtTenHLV.Name = "txtTenHLV";
            txtTenHLV.Size = new Size(200, 31);
            txtTenHLV.TabIndex = 7;
            // 
            // txtThanhTien
            // 
            txtThanhTien.Location = new Point(130, 350);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.Size = new Size(200, 31);
            txtThanhTien.TabIndex = 8;
            // 
            // btnSave_Invoice
            // 
            btnSave_Invoice.Location = new Point(130, 390);
            btnSave_Invoice.Name = "btnSave_Invoice";
            btnSave_Invoice.Size = new Size(75, 37);
            btnSave_Invoice.TabIndex = 9;
            btnSave_Invoice.Text = "Save";
            btnSave_Invoice.UseVisualStyleBackColor = true;
            // 
            // btnCancel_Invoice
            // 
            btnCancel_Invoice.Location = new Point(255, 390);
            btnCancel_Invoice.Name = "btnCancel_Invoice";
            btnCancel_Invoice.Size = new Size(75, 37);
            btnCancel_Invoice.TabIndex = 10;
            btnCancel_Invoice.Text = "Cancel";
            btnCancel_Invoice.UseVisualStyleBackColor = true;
            // 
            // inforInvoice
            // 
            ClientSize = new Size(697, 592);
            Controls.Add(txtMaHoaDon);
            Controls.Add(cbbMaGoiTap);
            Controls.Add(cbbMaLeTan);
            Controls.Add(dtpNgayXuatHoaDon);
            Controls.Add(txtTenKhachHang);
            Controls.Add(txtTenGoiTap);
            Controls.Add(dtpThoiHan);
            Controls.Add(txtTenHLV);
            Controls.Add(txtThanhTien);
            Controls.Add(btnSave_Invoice);
            Controls.Add(btnCancel_Invoice);
            Name = "inforInvoice";
            Text = "Thông tin hóa đơn";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
