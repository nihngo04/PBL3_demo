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

namespace PBL3
{
    public partial class addRecep : Form
    {
        String strCon = @"Data Source=LAPTOP-IL246S2S\SQLEXPRESS01;Initial Catalog=DEMO_GYMSYSTEM;Integrated Security=True;";
        SqlConnection sqlCon = null;
        public addRecep()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bt_save_Click(object sender, EventArgs e)
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
        }

        private void btcancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
