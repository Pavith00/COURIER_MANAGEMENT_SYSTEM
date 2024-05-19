using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectNew
{
    public partial class Staff : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-D1KEAHC\SQLEXPRESS;Initial Catalog=VisualStudioProject;Integrated Security=True");

        public Staff()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateInput())
                {
                    int PNumb = int.Parse(phone_numberTextBox.Text);
                    DateTime BDate = DateTime.Parse(dateTimePicker1.Text);
                    string sex;
                    if (radioButtonFemale.Checked == true)
                    {
                        sex = "Female";
                    }
                    else
                    {
                        sex = "Male";
                    }

                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO Employees VALUES('" + IdTextBox.Text + "','" + fnameTextBox.Text + "','" + lnameTextBox.Text + "','" + BDate + "','" + sex + "','" + BIdtextBox.Text + "','" + phone_numberTextBox.Text + "','" + emailTextBox.Text + "','" + addressTextBox.Text + "')";
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    fnameTextBox.Text = "";
                    lnameTextBox.Text = "";
                    phone_numberTextBox.Text = "";
                    emailTextBox.Text = "";
                    BIdtextBox.Text = "";
                    addressTextBox.Text = "";
                    IdTextBox.Text = "";
                    disp_data();
                    MessageBox.Show("Record Inserted Successfully!");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }
        private bool ValidateInput()
        {
            // Email validation using a regular expression
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";
            if (!Regex.IsMatch(emailTextBox.Text, emailPattern))
            {
                MessageBox.Show("Please enter a valid email address.");
                return false;
            }

            // Phone number validation using a regular expression
            string phonePattern = @"^\d{10}$"; // Assumes a 10-digit phone number
            if (!Regex.IsMatch(phone_numberTextBox.Text, phonePattern))
            {
                MessageBox.Show("Please enter a valid 10-digit phone number.");
                return false;
            }
            if (IdTextBox.Text.Length!=5)
            {
                MessageBox.Show("Invalid Employee ID.");
                return false;
            }

            if (BIdtextBox.Text.Length != 4)
            {
                MessageBox.Show("Invalid Branch ID.");
                return false;
            }

            if ( emailTextBox.Text.Length > 100 || addressTextBox.Text.Length > 100)
            {
                MessageBox.Show("Input length exceeds maximum allowed length.");
                return false;
            }

            return true;
        }

        public void disp_data()
        {
            try
            {

                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Employees";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
            }catch (Exception ex)
            {
                MessageBox.Show(Text, ex.Message);
                conn.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string ToDelete = deleteTextbox.Text.Trim();

            if (!string.IsNullOrEmpty(ToDelete))
            {
                try
                {

                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "DELETE FROM Employees WHERE ID='" + deleteTextbox.Text + "'";
                    int rowsAffected = cmd.ExecuteNonQuery();
                    conn.Close();
                    if (rowsAffected > 0)
                    {
                        disp_data();
                        MessageBox.Show("Record Deleted Successfully");
                    }
                    else
                    {
                        MessageBox.Show("No matching record found with the given NIC.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Please enter a Employee ID to delete.");
            }
            deleteTextbox.Text = "";
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            disp_data();
        }

        /*private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE Employees SET ID ='" + IdTextBox.Text + "'WHERE [FIRST NAME]='" + fnameTextBox.Text + "'";
                int rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();

                if (rowsAffected > 0)
                {
                    disp_data();
                    MessageBox.Show("Record Updated Successfully");
                }
                else
                {
                    MessageBox.Show("No matching record found with the given criteria.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }*/

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string nicToSelect = SearchTextBox.Text.Trim();

                if (string.IsNullOrEmpty(nicToSelect))
                {
                    MessageBox.Show("Select a Employee ID");
                }
                else
                {
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from Employees where ID='" + SearchTextBox.Text + "'";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    conn.Close();
                    conn.Close();
                }
                }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
            SearchTextBox.Text = "";
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            disp_data();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {/*
            string imageloaction = "";
            try
            {
                OpenFileDialog file = new OpenFileDialog();
                file.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All files(*.*)|*.* ";
                if(file.ShowDialog() == DialogResult.OK) 
                {
                    imageloaction = file.FileName.ToString(); 
                    image1.ImageLocation= imageloaction;
                
                }


            }
            catch(Exception ex)
            {
                MessageBox.Show("Error has Occured"+ex);
            }*/
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButtonFemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BIdLabel_Click(object sender, EventArgs e)
        {

        }

        private void BIdtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void birthdateLabel_Click(object sender, EventArgs e)
        {

        }

        private void lnameLabel_Click(object sender, EventArgs e)
        {

        }

        private void lnameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void sexLabel_Click(object sender, EventArgs e)
        {

        }

        private void IdLabel_Click(object sender, EventArgs e)
        {

        }

        private void IdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void fnameLabel_Click(object sender, EventArgs e)
        {

        }

        private void fnameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void phone_numberLabel_Click(object sender, EventArgs e)
        {

        }

        private void phone_numberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailLabel_Click(object sender, EventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addressLabel_Click(object sender, EventArgs e)
        {

        }

        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void deleteTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void deleteTextbox_enter(object sender, EventArgs e)
        {
            if (deleteTextbox.Text == "Enter A Employee ID")
            {
                deleteTextbox.Text = "";
                deleteTextbox.ForeColor = Color.Black;

            }
        }

        private void deleteTextbox_leave(object sender, EventArgs e)
        {
            if (deleteTextbox.Text == "")
            {
                deleteTextbox.Text = "Enter A Employee ID";
                deleteTextbox.ForeColor = Color.Silver;

            }
        }

        private void SearchTextBox_enter(object sender, EventArgs e)
        {
            if (SearchTextBox.Text == "Enter A Employee ID")
            {
                SearchTextBox.Text = "";
                SearchTextBox.ForeColor = Color.Black;

            }
        }

        private void SearchTextBox_leave(object sender, EventArgs e)
        {
            if (SearchTextBox.Text == "")
            {
                SearchTextBox.Text = "Enter A Employee ID";
                SearchTextBox.ForeColor = Color.Silver;

            }
        }

        private void deleteTextbox_Leave_1(object sender, EventArgs e)
        {

        }
    }
}
