using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectNew
{
    public partial class Customer : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-D1KEAHC\SQLEXPRESS;Initial Catalog=VisualStudioProject;Integrated Security=True");

        public Customer()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateInput())
                {
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO Customers VALUES('" + nameTextBox.Text + "','" + IdTextBox.Text + "','" + phone_numberTextBox.Text + "','" + emailTextBox.Text + "','" + addressTextBox.Text + "')";
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    nameTextBox.Text = "";
                    phone_numberTextBox.Text = "";
                    emailTextBox.Text = "";
                    addressTextBox.Text = "";
                    IdTextBox.Text = "";
                    disp_data();
                    MessageBox.Show("Record Inserted Successfully!");
                    conn.Close();
                }
            }catch (Exception ex)
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
            if (IdTextBox.Text.Length > 11 || IdTextBox.Text.Length<10)
            {
                MessageBox.Show("Invalied National ID");
                return false;
            }

            if (emailTextBox.Text.Length > 100 || addressTextBox.Text.Length > 100)
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
                cmd.CommandText = "select * from Customers";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            string nicToDelete = deleteTextbox.Text.Trim();

            if (!string.IsNullOrEmpty(nicToDelete))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "DELETE FROM Customers WHERE [National Id]='" + deleteTextbox.Text + "'";
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
                }catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Please enter a NIC to delete.");
            }
            deleteTextbox.Text = "";
        }

        private void Customer_Load(object sender, EventArgs e)
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


                cmd.CommandText = "UPDATE Customers SET NAME = @Name WHERE  [National Id] = @NationalId";


                cmd.Parameters.AddWithValue("@NationalId", IdTextBox.Text);
                cmd.Parameters.AddWithValue("@Name", nameTextBox.Text);
                cmd.Parameters.AddWithValue("@PhoneNumber", phone_numberTextBox.Text);
                cmd.Parameters.AddWithValue("@Email", emailTextBox.Text);
                cmd.Parameters.AddWithValue("@Address", addressTextBox.Text);

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
                MessageBox.Show("An error occurred: " + ex.Message);
                conn.Close();
            }
        }*/

        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                string nicToSelect = SearchTextBox.Text.Trim();

                if (string.IsNullOrEmpty(nicToSelect))
                {
                    MessageBox.Show("Select a NIC");
                }
                else
                {
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from Customers where [National Id]='" + SearchTextBox.Text + "'";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                
                conn.Close();
            }catch(Exception ex)
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

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void deleteTextbox_Enter(object sender, EventArgs e)
        {
            if (deleteTextbox.Text == "Enter A National ID")
            {
                deleteTextbox.Text = "";
                deleteTextbox.ForeColor = Color.Black;

            }
        }

        private void deleteTextbox_Leave(object sender, EventArgs e)
        {
            if (deleteTextbox.Text == "")
            {
                deleteTextbox.Text = "Enter A National ID";
                deleteTextbox.ForeColor = Color.Silver;

            }
        }

        private void SearchTextBox_Enter(object sender, EventArgs e)
        {
            if (SearchTextBox.Text == "Enter A National ID")
            {
                SearchTextBox.Text = "";
                SearchTextBox.ForeColor = Color.Black;

            }
        }

        private void SearchTextBox_Leave(object sender, EventArgs e)
        {
            if (SearchTextBox.Text == "")
            {
                SearchTextBox.Text = "Enter A National ID";
                SearchTextBox.ForeColor = Color.Silver;

            }
        }

        private void IdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void deleteTextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
