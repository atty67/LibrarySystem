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
using 
namespace LibrarySystem
{
    public partial class SignUp : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Matthew\OneDrive\Documents\InventoryLibrary.mdf;Integrated Security=True;Connect Timeout=30");
        public SignUp()
        {
            InitializeComponent();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginhereBtn_Click(object sender, EventArgs e)
        {
            LogIn logn = new LogIn();
            logn.Show();
            this.Hide();
        }

        private void signupBtn_Click(object sender, EventArgs e)
        {
            if (typeEmail.Text == "" || typeUser.Text == "" || typePass.Text == "")
            {
                MessageBox.Show("Please fill all blank fields!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();
                        String checkUsername = "SELECT * FROM admins_new WHERE username = '"
                            + typeUser.Text.Trim() + "'";

                        using (SqlCommand checkuser = new SqlCommand(checkUsername, connect))
                        {
                            SqlDataAdapter adapter = new SqlDataAdapter(checkuser);
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            if (dt.Rows.Count >= 1)
                            {
                                MessageBox.Show(typeUser.Text + " is already exist", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO admins_new (email, username, password, date_created)" +
                                    "VALUES(@email, @username, @pass, @date)";

                                DateTime date = DateTime.Today;

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@email", typeEmail.Text.Trim());
                                    cmd.Parameters.AddWithValue("@username", typeUser.Text.Trim());
                                    cmd.Parameters.AddWithValue("@pass", typePass.Text.Trim());
                                    cmd.Parameters.AddWithValue("@date", date);

                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Registered Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    LogIn lgn = new LogIn();
                                    lgn.Show();
                                    this.Hide();
                                }
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Connecting in Database: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            if(showPass.Checked)
            {
                typePass.PasswordChar = '\0';
            }
            else
            {
                typePass.PasswordChar = '•';
            }
        }

        private void typePass_TextChanged(object sender, EventArgs e)
        {
            typePass.PasswordChar = '•';
        }

        private void typeUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
