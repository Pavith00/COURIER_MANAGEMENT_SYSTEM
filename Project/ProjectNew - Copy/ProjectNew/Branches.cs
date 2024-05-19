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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjectNew
{
    public partial class Branches : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-D1KEAHC\SQLEXPRESS;Initial Catalog=VisualStudioProject;Integrated Security=True");

        public Branches()
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
                    cmd.CommandText = "INSERT INTO Branch VALUES('" + nameTextBox.Text + "','" + CodeTextBox.Text + "','" + phone_numberTextBox.Text + "','" + emailTextBox.Text + "','" + addressTextBox.Text + "','" + NotetextBox.Text + "')";
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    nameTextBox.Text = "";
                    phone_numberTextBox.Text = "";
                    emailTextBox.Text = "";
                    addressTextBox.Text = "";
                    CodeTextBox.Text = "";
                    NotetextBox.Text = "";

                    disp_data();
                    MessageBox.Show("Record Inserted Successfully!");
                }
            }
            catch (Exception ex)
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
            if (CodeTextBox.Text.Length !=4)
            {
                MessageBox.Show("Invalid Branch Code.");
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
                cmd.CommandText = "select * from Branch";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }
            

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string codeToDelete = deleteTextBox.Text.Trim();

            if (!string.IsNullOrEmpty(codeToDelete))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "DELETE FROM Branch WHERE [Branch  Code] ='" + deleteTextBox.Text + "'";
                    int rowsAffected = cmd.ExecuteNonQuery();
                    conn.Close();
                    if (rowsAffected > 0)
                    {
                        disp_data();
                        MessageBox.Show("Record Deleted Successfully");
                    }
                    else
                    {
                        MessageBox.Show("No matching record found with the given Branch Code.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter a Branch Code to delete.");
                conn.Close();
            }
            deleteTextBox.Text = "";
        }
        

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;


                cmd.CommandText = "UPDATE branch SET NAME=@Name,[PHONE NUMBER]=@Phone,EMAIL=@email,ADDRESS=@Address,NOTE=@Note WHERE [Branch Code] = @Branch";

                cmd.Parameters.AddWithValue("@Branch", CodeTextBox.Text);
                cmd.Parameters.AddWithValue("@Note", NotetextBox.Text);
                cmd.Parameters.AddWithValue("@Name", nameTextBox.Text);
                cmd.Parameters.AddWithValue("@Phone", phone_numberTextBox.Text);
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
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string codeToSelect = SearchTextBox.Text.Trim();

                if (string.IsNullOrEmpty(codeToSelect))
                {
                    MessageBox.Show("Select a Branch Code");
                }
                else
                {
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from Branch where [Branch  Code] ='" + SearchTextBox.Text + "'";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    conn.Close();
                }
                conn.Close();
            }
            catch (Exception ex)
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

        private void Branches_Load(object sender, EventArgs e)
        {
            disp_data();
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void phone_numberLabel_Click(object sender, EventArgs e)
        {

        }

        private void emailLabel_Click(object sender, EventArgs e)
        {

        }

        private void addressLabel_Click(object sender, EventArgs e)
        {

        }

        private void lblNote_Click(object sender, EventArgs e)
        {

        }

        private void CodeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CodeLabel_Click(object sender, EventArgs e)
        {

        }

        private void phone_numberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NotetextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void deleteTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void deleteTextbox_enter(object sender, EventArgs e)
        {
            if (deleteTextBox.Text == "Select a Branch Code")
            {
                deleteTextBox.Text = "";
                deleteTextBox.ForeColor = Color.Black;

            }
        }

        private void deleteTextbox_leave(object sender, EventArgs e)
        {
            if (deleteTextBox.Text == "")
            {
                deleteTextBox.Text = "Select a Branch Code";
                deleteTextBox.ForeColor = Color.Silver;

            }
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchTextBox_enter(object sender, EventArgs e)
        {
            if (SearchTextBox.Text == "Select A Branch code")
            {
                SearchTextBox.Text = "";
                SearchTextBox.ForeColor = Color.Black;

            }
        }

        private void SearchTextBox_leave(object sender, EventArgs e)
        {
            if (SearchTextBox.Text == "")
            {
                SearchTextBox.Text = "Select A Branch code";
                SearchTextBox.ForeColor = Color.Silver;

            }
        }
    }
}
