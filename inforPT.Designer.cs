namespace PBL3
{
    partial class inforPT
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtName = new TextBox();
            txtLuong = new TextBox();
            txtmaso = new TextBox();
            txtChuyenmon = new RichTextBox();
            txtKinhnghiem = new RichTextBox();
            btcancel = new Button();
            bt_savePT = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 77);
            label1.Name = "label1";
            label1.Size = new Size(70, 25);
            label1.TabIndex = 0;
            label1.Text = "Họ tên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 232);
            label2.Name = "label2";
            label2.Size = new Size(67, 25);
            label2.TabIndex = 1;
            label2.Text = "Lương:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(472, 83);
            label3.Name = "label3";
            label3.Size = new Size(65, 25);
            label3.TabIndex = 2;
            label3.Text = "Mã số:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(424, 134);
            label4.Name = "label4";
            label4.Size = new Size(115, 25);
            label4.TabIndex = 3;
            label4.Text = "Kinh nghiệm:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(81, 137);
            label5.Name = "label5";
            label5.Size = new Size(117, 25);
            label5.TabIndex = 4;
            label5.Text = "Chuyên môn:";
            // 
            // txtName
            // 
            txtName.Location = new Point(202, 74);
            txtName.Name = "txtName";
            txtName.Size = new Size(194, 31);
            txtName.TabIndex = 5;
            // 
            // txtLuong
            // 
            txtLuong.Location = new Point(204, 229);
            txtLuong.Name = "txtLuong";
            txtLuong.Size = new Size(194, 31);
            txtLuong.TabIndex = 7;
            // 
            // txtmaso
            // 
            txtmaso.Location = new Point(543, 77);
            txtmaso.Name = "txtmaso";
            txtmaso.Size = new Size(120, 31);
            txtmaso.TabIndex = 8;
            // 
            // txtChuyenmon
            // 
            txtChuyenmon.Location = new Point(204, 134);
            txtChuyenmon.Name = "txtChuyenmon";
            txtChuyenmon.Size = new Size(192, 71);
            txtChuyenmon.TabIndex = 9;
            txtChuyenmon.Text = "";
            // 
            // txtKinhnghiem
            // 
            txtKinhnghiem.Location = new Point(545, 131);
            txtKinhnghiem.Name = "txtKinhnghiem";
            txtKinhnghiem.Size = new Size(192, 74);
            txtKinhnghiem.TabIndex = 10;
            txtKinhnghiem.Text = "";
            // 
            // btcancel
            // 
            btcancel.Location = new Point(437, 348);
            btcancel.Name = "btcancel";
            btcancel.Size = new Size(102, 39);
            btcancel.TabIndex = 28;
            btcancel.Text = "Cancel";
            btcancel.UseVisualStyleBackColor = true;
            btcancel.Click += btcancel_Click;
            // 
            // bt_savePT
            // 
            bt_savePT.Location = new Point(250, 348);
            bt_savePT.Name = "bt_savePT";
            bt_savePT.Size = new Size(102, 39);
            bt_savePT.TabIndex = 27;
            bt_savePT.Text = "Save";
            bt_savePT.UseVisualStyleBackColor = true;
            bt_savePT.Click += bt_savePT_Click;
            // 
            // addPT
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btcancel);
            Controls.Add(bt_savePT);
            Controls.Add(txtKinhnghiem);
            Controls.Add(txtChuyenmon);
            Controls.Add(txtmaso);
            Controls.Add(txtLuong);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "addPT";
            Text = "Thêm PT";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtName;
        private TextBox txtLuong;
        private TextBox txtmaso;
        private RichTextBox txtChuyenmon;
        private RichTextBox txtKinhnghiem;
        private Button btcancel;
        private Button bt_savePT;
    }
}