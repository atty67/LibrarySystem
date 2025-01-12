using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using MySQL.Data;

namespace LibrarySystem
{
    public partial class LogIn : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Matthew\OneDrive\Documents\InventoryLibrary.mdf;Integrated Security=True;Connect Timeout=30");
        public LogIn()
        {
            InitializeComponent();

        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            SignUp signp = new SignUp();
            signp.Show();
            this.Hide();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (showPass.Checked)
            {
                typePass.PasswordChar = '\0';
            }
            else
            {
                typePass.PasswordChar = '•';
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (typeUser.Text == "" || typePass.Text == "")
            {
                MessageBox.Show("Please fill all blank fields!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(connect.State != ConnectionState.Open)
                {
                    try 
                    {
                        connect.Open();
                        String selectData = "SELECT * FROM admins_new WHERE username = @username AND password = @pass";
                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@username", typeUser.Text);
                            cmd.Parameters.AddWithValue("@pass", typePass.Text);
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable Table = new DataTable();
                            adapter.Fill(Table);

                            if(Table.Rows.Count >= 1)
                            {
                                MessageBox.Show("Logged In Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information); 

                                Dashboard mf = new Dashboard();
                                mf.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Username/Password!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Error Connecting: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }

            }
        }

        private void typePass_TextChanged(object sender, EventArgs e)
        {
            typePass.PasswordChar = '•';
        }

        private void typeUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
