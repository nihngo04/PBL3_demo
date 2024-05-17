namespace PBL3
{
    partial class inforRecep
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
            txtName = new TextBox();
            txtSalary = new TextBox();
            txtChuyenmon = new RichTextBox();
            btcancel = new Button();
            bt_save = new Button();
            label4 = new Label();
            label5 = new Label();
            txtMaLT = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(106, 64);
            label1.Name = "label1";
            label1.Size = new Size(93, 25);
            label1.TabIndex = 0;
            label1.Text = "Họ và tên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(106, 252);
            label2.Name = "label2";
            label2.Size = new Size(103, 25);
            label2.TabIndex = 1;
            label2.Text = "Mức lương:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(106, 127);
            label3.Name = "label3";
            label3.Size = new Size(117, 25);
            label3.TabIndex = 2;
            label3.Text = "Chuyên môn:";
            // 
            // txtName
            // 
            txtName.Location = new Point(239, 58);
            txtName.Name = "txtName";
            txtName.Size = new Size(223, 31);
            txtName.TabIndex = 3;
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(239, 249);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(223, 31);
            txtSalary.TabIndex = 4;
            // 
            // txtChuyenmon
            // 
            txtChuyenmon.Location = new Point(239, 115);
            txtChuyenmon.Name = "txtChuyenmon";
            txtChuyenmon.Size = new Size(223, 96);
            txtChuyenmon.TabIndex = 5;
            txtChuyenmon.Text = "";
            // 
            // btcancel
            // 
            btcancel.Location = new Point(438, 354);
            btcancel.Name = "btcancel";
            btcancel.Size = new Size(102, 39);
            btcancel.TabIndex = 26;
            btcancel.Text = "Cancel";
            btcancel.UseVisualStyleBackColor = true;
            btcancel.Click += btcancel_Click;
            // 
            // bt_save
            // 
            bt_save.Location = new Point(249, 354);
            bt_save.Name = "bt_save";
            bt_save.Size = new Size(102, 39);
            bt_save.TabIndex = 25;
            bt_save.Text = "Save";
            bt_save.UseVisualStyleBackColor = true;
            bt_save.Click += bt_save_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(468, 252);
            label4.Name = "label4";
            label4.Size = new Size(49, 25);
            label4.TabIndex = 27;
            label4.Text = "VND";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(510, 58);
            label5.Name = "label5";
            label5.Size = new Size(65, 25);
            label5.TabIndex = 28;
            label5.Text = "Mã số:";
            // 
            // txtMaLT
            // 
            txtMaLT.Location = new Point(581, 58);
            txtMaLT.Name = "txtMaLT";
            txtMaLT.Size = new Size(112, 31);
            txtMaLT.TabIndex = 29;
            // 
            // addRecep
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtMaLT);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btcancel);
            Controls.Add(bt_save);
            Controls.Add(txtChuyenmon);
            Controls.Add(txtSalary);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "addRecep";
            Text = "Thêm nhân viên";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtName;
        private TextBox txtSalary;
        private RichTextBox txtChuyenmon;
        private Button btcancel;
        private Button bt_save;
        private Label label4;
        private Label label5;
        private TextBox txtMaLT;
    }
}