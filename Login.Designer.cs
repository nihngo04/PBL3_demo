namespace PBL3
{
    partial class Login
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
            btlogin = new Button();
            txtUsername = new TextBox();
            txtPass = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btcancel = new Button();
            SuspendLayout();
            // 
            // btlogin
            // 
            btlogin.Location = new Point(102, 345);
            btlogin.Name = "btlogin";
            btlogin.Size = new Size(108, 38);
            btlogin.TabIndex = 0;
            btlogin.Text = "Login";
            btlogin.UseVisualStyleBackColor = true;
            btlogin.Click += btlogin_Click;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.HighlightText;
            txtUsername.Location = new Point(119, 157);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(204, 31);
            txtUsername.TabIndex = 1;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(119, 251);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(204, 31);
            txtPass.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(119, 118);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 3;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(119, 212);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // btcancel
            // 
            btcancel.Location = new Point(236, 345);
            btcancel.Name = "btcancel";
            btcancel.Size = new Size(108, 38);
            btcancel.TabIndex = 5;
            btcancel.Text = "Cancel";
            btcancel.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(412, 496);
            Controls.Add(btcancel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPass);
            Controls.Add(txtUsername);
            Controls.Add(btlogin);
            Name = "Login";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btlogin;
        private TextBox txtUsername;
        private TextBox txtPass;
        private Label label1;
        private Label label2;
        private Button btcancel;
    }
}