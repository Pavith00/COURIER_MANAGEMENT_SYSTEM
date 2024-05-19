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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjectNew
{
    public partial class Vehicle : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-D1KEAHC\SQLEXPRESS;Initial Catalog=VisualStudioProject;Integrated Security=True");

        public Vehicle()
        {
            InitializeComponent();
        }

        private void Vehicle_Load(object sender, EventArgs e)
        {
            disp_data();
            PopulateDriverIdComboBox();
            PopulateDriverComboBox();


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
                    cmd.CommandText = "INSERT INTO Vehicles VALUES('" + nameTextBox.Text + "','" + ModelTextBox.Text + "','" + PLNumbTextBox.Text + "','" + driver_idcomboBox.Text + "','" + driverCombobox.Text + "','" + PNtextBox.Text + "')";
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    nameTextBox.Text = "";
                    PLNumbTextBox.Text = "";
                    driver_idcomboBox.Text = "";
                    driverCombobox.Text = "";
                    ModelTextBox.Text = "";
                    PNtextBox.Text = ""; 
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
            
            string phonePattern = @"^\d{10}$"; // Assumes a 10-digit phone number
            if (!Regex.IsMatch(PNtextBox.Text, phonePattern))
            {
                MessageBox.Show("Please enter a valid 10-digit phone number.");
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
                cmd.CommandText = "select * from Vehicles";
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
            string plnToDelete = deleteTextbox.Text.Trim();

            if (!string.IsNullOrEmpty(plnToDelete))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "DELETE FROM Vehicles WHERE Plate_No='" + deleteTextbox.Text + "'";
                    int rowsAffected = cmd.ExecuteNonQuery();
                    conn.Close();
                    if (rowsAffected > 0)
                    {
                        disp_data();
                        MessageBox.Show("Record Deleted Successfully");
                    }
                    else
                    {
                        MessageBox.Show("No matching record found with the given Plate Number.");
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
                MessageBox.Show("Please enter a Plate Number to delete.");
            }
            
            deleteTextbox.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;


                cmd.CommandText = "UPDATE Vehicles SET NAME = @Name,Model = @Model,PHONE=@PNumb,DRIVER=@driver,DRIVER_ID=@driver_id WHERE  Plate_No = @pLNumb";


                cmd.Parameters.AddWithValue("@Model", ModelTextBox.Text);
                cmd.Parameters.AddWithValue("@Name", nameTextBox.Text);
                cmd.Parameters.AddWithValue("@plNumb", PLNumbTextBox.Text);
                cmd.Parameters.AddWithValue("@PNumb", PNtextBox.Text);
                cmd.Parameters.AddWithValue("@driver", driverCombobox.Text);
                cmd.Parameters.AddWithValue("@driver_id", driver_idcomboBox.Text);

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
                string plnToSelect = SearchTextBox.Text.Trim();

                if (string.IsNullOrEmpty(plnToSelect))
                {
                    MessageBox.Show("Select a Plate Number");
                }
                else
                {
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from Vehicles where Plate_No='" + SearchTextBox.Text + "'";
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

        private void PopulateDriverComboBox()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT [First Name] FROM Employees";
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    driverCombobox.Items.Add(dr["First Name"].ToString());
                }

                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();
            }
        }

        private void PopulateDriverIdComboBox()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT ID FROM Employees";
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    driver_idcomboBox.Items.Add(dr["ID"].ToString());
                }

                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();
            }
        }

        private void deleteTextbox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void deleteTextbox_enter(object sender, EventArgs e)
        {
            if (deleteTextbox.Text == "Enter A Plate Number")
            {
                deleteTextbox.Text = "";
                deleteTextbox.ForeColor = Color.Black;

            }
        }

        private void deleteTextbox_leave(object sender, EventArgs e)
        {
            if (deleteTextbox.Text == "")
            {
                deleteTextbox.Text = "Enter A Plate Number";
                deleteTextbox.ForeColor = Color.Silver;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();

        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchTextBox_enter(object sender, EventArgs e)
        {
            if (SearchTextBox.Text == "Enter A Plate Number")
            {
                SearchTextBox.Text = "";
                SearchTextBox.ForeColor = Color.Black;

            }
        }

        private void SearchTextBox_leave(object sender, EventArgs e)
        {
            if (SearchTextBox.Text == "")
            {
                SearchTextBox.Text = "Enter A Plate Number";
                SearchTextBox.ForeColor = Color.Silver;

            }
        }
    }
}
