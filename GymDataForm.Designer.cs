namespace PBL3
{
    partial class GymDataForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            tabControlGym = new TabControl();
            tabMem = new TabPage();
            bt_soluongkhach = new Button();
            DGV_Mem = new DataGridView();
            btn_Mem_Add = new Button();
            btn_Mem_Update = new Button();
            btn_Mem_Del = new Button();
            tabPT = new TabPage();
            DGV_PT = new DataGridView();
            addPT = new Button();
            btn_PT_del = new Button();
            btn_PT_Update_Click = new Button();
            tabReceptiionist = new TabPage();
            DGV_Recep = new DataGridView();
            addReceptionist = new Button();
            btnDelete = new Button();
            btn_updateRecep = new Button();
            tabMachine = new TabPage();
            DGV_Machine = new DataGridView();
            comboBox7 = new ComboBox();
            comboBox8 = new ComboBox();
            btn_Mac_Sort = new Button();
            label5 = new Label();
            tab_Find = new TabPage();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabControlGym.SuspendLayout();
            tabMem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_Mem).BeginInit();
            tabPT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_PT).BeginInit();
            tabReceptiionist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_Recep).BeginInit();
            tabMachine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_Machine).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Handwriting", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(416, 67);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(317, 93);
            label1.TabIndex = 0;
            label1.Text = "NVGym";
            // 
            // tabControlGym
            // 
            tabControlGym.Controls.Add(tabMem);
            tabControlGym.Controls.Add(tabPT);
            tabControlGym.Controls.Add(tabReceptiionist);
            tabControlGym.Controls.Add(tabMachine);
            tabControlGym.Controls.Add(tab_Find);
            tabControlGym.Controls.Add(tabPage1);
            tabControlGym.Controls.Add(tabPage2);
            tabControlGym.Location = new Point(17, 253);
            tabControlGym.Margin = new Padding(4, 5, 4, 5);
            tabControlGym.Name = "tabControlGym";
            tabControlGym.SelectedIndex = 0;
            tabControlGym.Size = new Size(1266, 813);
            tabControlGym.TabIndex = 10;
            tabControlGym.SelectedIndexChanged += TabControl1_SelectedIndexChanged;
            // 
            // tabMem
            // 
            tabMem.BackColor = Color.LightCyan;
            tabMem.Controls.Add(bt_soluongkhach);
            tabMem.Controls.Add(DGV_Mem);
            tabMem.Controls.Add(btn_Mem_Add);
            tabMem.Controls.Add(btn_Mem_Update);
            tabMem.Controls.Add(btn_Mem_Del);
            tabMem.Location = new Point(4, 34);
            tabMem.Margin = new Padding(4, 5, 4, 5);
            tabMem.Name = "tabMem";
            tabMem.Padding = new Padding(4, 5, 4, 5);
            tabMem.Size = new Size(1258, 775);
            tabMem.TabIndex = 0;
            tabMem.Text = "Member";
            // 
            // bt_soluongkhach
            // 
            bt_soluongkhach.Location = new Point(270, 49);
            bt_soluongkhach.Name = "bt_soluongkhach";
            bt_soluongkhach.Size = new Size(178, 49);
            bt_soluongkhach.TabIndex = 8;
            bt_soluongkhach.Text = "Tổng số khách";
            bt_soluongkhach.UseVisualStyleBackColor = true;
            bt_soluongkhach.Click += bt_soluongkhach_Click;
            // 
            // DGV_Mem
            // 
            DGV_Mem.BackgroundColor = Color.White;
            DGV_Mem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Mem.Location = new Point(4, 117);
            DGV_Mem.Margin = new Padding(4, 5, 4, 5);
            DGV_Mem.Name = "DGV_Mem";
            DGV_Mem.RowHeadersWidth = 62;
            DGV_Mem.Size = new Size(1250, 658);
            DGV_Mem.TabIndex = 0;
            // 
            // btn_Mem_Add
            // 
            btn_Mem_Add.Font = new Font("Segoe UI", 20F);
            btn_Mem_Add.Location = new Point(81, 35);
            btn_Mem_Add.Margin = new Padding(4, 5, 4, 5);
            btn_Mem_Add.Name = "btn_Mem_Add";
            btn_Mem_Add.Size = new Size(158, 63);
            btn_Mem_Add.TabIndex = 7;
            btn_Mem_Add.Text = "Add";
            btn_Mem_Add.UseVisualStyleBackColor = true;
            btn_Mem_Add.Click += btn_Mem_Add_Click;
            // 
            // btn_Mem_Update
            // 
            btn_Mem_Update.Font = new Font("Segoe UI", 20F);
            btn_Mem_Update.Location = new Point(506, 35);
            btn_Mem_Update.Margin = new Padding(4, 5, 4, 5);
            btn_Mem_Update.Name = "btn_Mem_Update";
            btn_Mem_Update.Size = new Size(179, 63);
            btn_Mem_Update.TabIndex = 7;
            btn_Mem_Update.Text = "Update";
            btn_Mem_Update.UseVisualStyleBackColor = true;
            btn_Mem_Update.Click += btn_Mem_Update_Click;
            // 
            // btn_Mem_Del
            // 
            btn_Mem_Del.Font = new Font("Segoe UI", 20F);
            btn_Mem_Del.Location = new Point(961, 35);
            btn_Mem_Del.Margin = new Padding(4, 5, 4, 5);
            btn_Mem_Del.Name = "btn_Mem_Del";
            btn_Mem_Del.Size = new Size(175, 63);
            btn_Mem_Del.TabIndex = 7;
            btn_Mem_Del.Text = "Delete";
            btn_Mem_Del.UseVisualStyleBackColor = true;
            btn_Mem_Del.Click += btn_Mem_Del_Click;
            // 
            // tabPT
            // 
            tabPT.Controls.Add(DGV_PT);
            tabPT.Controls.Add(addPT);
            tabPT.Controls.Add(btn_PT_del);
            tabPT.Controls.Add(btn_PT_Update_Click);
            tabPT.Location = new Point(4, 34);
            tabPT.Margin = new Padding(4, 5, 4, 5);
            tabPT.Name = "tabPT";
            tabPT.Padding = new Padding(4, 5, 4, 5);
            tabPT.Size = new Size(1258, 775);
            tabPT.TabIndex = 1;
            tabPT.Text = "Personal Trainer";
            tabPT.UseVisualStyleBackColor = true;
            // 
            // DGV_PT
            // 
            DGV_PT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_PT.Location = new Point(4, 112);
            DGV_PT.Margin = new Padding(4, 5, 4, 5);
            DGV_PT.Name = "DGV_PT";
            DGV_PT.RowHeadersWidth = 62;
            DGV_PT.Size = new Size(1258, 658);
            DGV_PT.TabIndex = 11;
            // 
            // addPT
            // 
            addPT.Font = new Font("Segoe UI", 20F);
            addPT.Location = new Point(85, 30);
            addPT.Margin = new Padding(4, 5, 4, 5);
            addPT.Name = "addPT";
            addPT.Size = new Size(158, 63);
            addPT.TabIndex = 12;
            addPT.Text = "Add";
            addPT.UseVisualStyleBackColor = true;
            addPT.Click += addPT_Click;
            // 
            // btn_PT_del
            // 
            btn_PT_del.Font = new Font("Segoe UI", 20F);
            btn_PT_del.Location = new Point(965, 30);
            btn_PT_del.Margin = new Padding(4, 5, 4, 5);
            btn_PT_del.Name = "btn_PT_del";
            btn_PT_del.Size = new Size(175, 63);
            btn_PT_del.TabIndex = 14;
            btn_PT_del.Text = "Delete";
            btn_PT_del.UseVisualStyleBackColor = true;
            btn_PT_del.Click += btn_PT_del_Click;
            // 
            // btn_PT_Update_Click
            // 
            btn_PT_Update_Click.Font = new Font("Segoe UI", 20F);
            btn_PT_Update_Click.Location = new Point(510, 30);
            btn_PT_Update_Click.Margin = new Padding(4, 5, 4, 5);
            btn_PT_Update_Click.Name = "btn_PT_Update_Click";
            btn_PT_Update_Click.Size = new Size(179, 63);
            btn_PT_Update_Click.TabIndex = 13;
            btn_PT_Update_Click.Text = "Update";
            btn_PT_Update_Click.UseVisualStyleBackColor = true;
            btn_PT_Update_Click.Click += btn_PT_Update_Click_Click;
            // 
            // tabReceptiionist
            // 
            tabReceptiionist.Controls.Add(DGV_Recep);
            tabReceptiionist.Controls.Add(addReceptionist);
            tabReceptiionist.Controls.Add(btnDelete);
            tabReceptiionist.Controls.Add(btn_updateRecep);
            tabReceptiionist.Location = new Point(4, 34);
            tabReceptiionist.Margin = new Padding(4, 5, 4, 5);
            tabReceptiionist.Name = "tabReceptiionist";
            tabReceptiionist.Padding = new Padding(4, 5, 4, 5);
            tabReceptiionist.Size = new Size(1258, 775);
            tabReceptiionist.TabIndex = 2;
            tabReceptiionist.Text = "Receptionist";
            tabReceptiionist.UseVisualStyleBackColor = true;
            // 
            // DGV_Recep
            // 
            DGV_Recep.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Recep.Location = new Point(-4, 112);
            DGV_Recep.Margin = new Padding(4, 5, 4, 5);
            DGV_Recep.Name = "DGV_Recep";
            DGV_Recep.RowHeadersWidth = 62;
            DGV_Recep.Size = new Size(1258, 658);
            DGV_Recep.TabIndex = 11;
            // 
            // addReceptionist
            // 
            addReceptionist.Font = new Font("Segoe UI", 20F);
            addReceptionist.Location = new Point(77, 30);
            addReceptionist.Margin = new Padding(4, 5, 4, 5);
            addReceptionist.Name = "addReceptionist";
            addReceptionist.Size = new Size(158, 63);
            addReceptionist.TabIndex = 12;
            addReceptionist.Text = "Add";
            addReceptionist.UseVisualStyleBackColor = true;
            addReceptionist.Click += addReceptionist_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 20F);
            btnDelete.Location = new Point(957, 30);
            btnDelete.Margin = new Padding(4, 5, 4, 5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(175, 63);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDeleteRecep_Click;
            // 
            // btn_updateRecep
            // 
            btn_updateRecep.Font = new Font("Segoe UI", 20F);
            btn_updateRecep.Location = new Point(502, 30);
            btn_updateRecep.Margin = new Padding(4, 5, 4, 5);
            btn_updateRecep.Name = "btn_updateRecep";
            btn_updateRecep.Size = new Size(179, 63);
            btn_updateRecep.TabIndex = 13;
            btn_updateRecep.Text = "Update";
            btn_updateRecep.UseVisualStyleBackColor = true;
            btn_updateRecep.Click += btn_updateRecep_Click;
            // 
            // tabMachine
            // 
            tabMachine.Controls.Add(DGV_Machine);
            tabMachine.Controls.Add(comboBox7);
            tabMachine.Controls.Add(comboBox8);
            tabMachine.Controls.Add(btn_Mac_Sort);
            tabMachine.Controls.Add(label5);
            tabMachine.Location = new Point(4, 34);
            tabMachine.Margin = new Padding(4, 5, 4, 5);
            tabMachine.Name = "tabMachine";
            tabMachine.Padding = new Padding(4, 5, 4, 5);
            tabMachine.Size = new Size(1258, 775);
            tabMachine.TabIndex = 3;
            tabMachine.Text = "Machine";
            tabMachine.UseVisualStyleBackColor = true;
            // 
            // DGV_Machine
            // 
            DGV_Machine.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Machine.Location = new Point(0, 108);
            DGV_Machine.Margin = new Padding(4, 5, 4, 5);
            DGV_Machine.Name = "DGV_Machine";
            DGV_Machine.RowHeadersWidth = 62;
            DGV_Machine.Size = new Size(1074, 658);
            DGV_Machine.TabIndex = 18;
            // 
            // comboBox7
            // 
            comboBox7.Font = new Font("Segoe UI", 20F);
            comboBox7.FormattingEnabled = true;
            comboBox7.Location = new Point(473, 18);
            comboBox7.Margin = new Padding(4, 5, 4, 5);
            comboBox7.Name = "comboBox7";
            comboBox7.Size = new Size(263, 62);
            comboBox7.TabIndex = 16;
            // 
            // comboBox8
            // 
            comboBox8.Font = new Font("Segoe UI", 20F);
            comboBox8.FormattingEnabled = true;
            comboBox8.Location = new Point(177, 18);
            comboBox8.Margin = new Padding(4, 5, 4, 5);
            comboBox8.Name = "comboBox8";
            comboBox8.Size = new Size(263, 62);
            comboBox8.TabIndex = 17;
            // 
            // btn_Mac_Sort
            // 
            btn_Mac_Sort.Font = new Font("Segoe UI", 20F);
            btn_Mac_Sort.Location = new Point(851, 10);
            btn_Mac_Sort.Margin = new Padding(4, 5, 4, 5);
            btn_Mac_Sort.Name = "btn_Mac_Sort";
            btn_Mac_Sort.Size = new Size(214, 88);
            btn_Mac_Sort.TabIndex = 15;
            btn_Mac_Sort.Text = "Sort";
            btn_Mac_Sort.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F);
            label5.Location = new Point(26, 23);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(112, 54);
            label5.TabIndex = 13;
            label5.Text = "Filter";
            // 
            // tab_Find
            // 
            tab_Find.Location = new Point(4, 34);
            tab_Find.Margin = new Padding(4, 5, 4, 5);
            tab_Find.Name = "tab_Find";
            tab_Find.Padding = new Padding(4, 5, 4, 5);
            tab_Find.Size = new Size(1258, 775);
            tab_Find.TabIndex = 4;
            tab_Find.Text = "Find";
            tab_Find.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1258, 775);
            tabPage1.TabIndex = 5;
            tabPage1.Text = "Recept";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1258, 775);
            tabPage2.TabIndex = 6;
            tabPage2.Text = "Menbership package";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // GymDataForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1296, 1078);
            Controls.Add(tabControlGym);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "GymDataForm";
            Text = "Gym Management";
            tabControlGym.ResumeLayout(false);
            tabMem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGV_Mem).EndInit();
            tabPT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGV_PT).EndInit();
            tabReceptiionist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGV_Recep).EndInit();
            tabMachine.ResumeLayout(false);
            tabMachine.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_Machine).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TabControl tabControlGym;
        private TabPage tabMem;
        private TabPage tabPT;
        private Button btn_Mem_Del;
        private TabPage tabReceptiionist;
        private DataGridView DGV_Mem;
        private TabPage tabMachine;
        private DataGridView DGV_Machine;
        private ComboBox comboBox7;
        private ComboBox comboBox8;
        private Button btn_Mac_Sort;
        private Label label5;
        private Button btn_Mem_Add;
        private Button btn_Mem_Update;
        private TabPage tab_Find;
        private DataGridView DGV_PT;
        private Button addPT;
        private Button btn_PT_del;
        private Button btn_PT_Update_Click;
        private DataGridView DGV_Recep;
        private Button addReceptionist;
        private Button btnDelete;
        private Button btn_updateRecep;
        private Button bt_soluongkhach;
        private TabPage tabPage1;
        private TabPage tabPage2;
    }
}
