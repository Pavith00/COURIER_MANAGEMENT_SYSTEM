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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ProjectNew
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Username.Visible = false;
            Passwords.Visible = false;

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            

            if (txtusername.Text == "")
            {
                Username.Text = "*Please Enter User Name";

            }
            if (txtpassword.Text == "")
            {
                Passwords.Text = "*Please Enter Password";
            }
            else
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-D1KEAHC\SQLEXPRESS;Initial Catalog=VisualStudioProject;Integrated Security=True");
                using (SqlCommand cmd = new SqlCommand("SELECT password FROM login WHERE username = @username", conn))
                {
                    try
                    {
                        conn.Open();
                        cmd.Parameters.AddWithValue("@username",txtusername.Text);
                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            string abc = result.ToString();
                            if
                            (txtpassword.Text == abc)
                            {
                                if (abc == "ADMIN")
                                {
                                    Home home = new Home();
                                    home.ShowDialog();
                                    txtpassword.Clear();
                                    Username.Text = "";
                                    Passwords.Text = "";
                                }
                                else
                                {
                                    Order home = new Order();
                                    home.ShowDialog();
                                    txtpassword.Clear();
                                    Username.Text = "";
                                    Passwords.Text = "";
                                }
                            }
                            else
                            {
                                Passwords.Text = "*Invalid password";
                                txtpassword.Clear();
                            }
                        }
                        else
                        {
                            Username.Visible = true;
                            Passwords.Visible = true;
                            Username.Text = "*Invalid User Name";
                            Passwords.Text = "*Invalid Password";
                            txtusername.Clear();
                            txtpassword.Clear();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(" " + ex);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
