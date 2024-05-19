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
    public partial class Parcel : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-D1KEAHC\SQLEXPRESS;Initial Catalog=VisualStudioProject;Integrated Security=True");

        public Parcel()
        {
            InitializeComponent();
        }

        

        private bool ValidateInput()
        {
            
            if (TCodeTextBox.Text.Length!= 4)
            {
                MessageBox.Show("Invalid Tracking code.");
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
                cmd.CommandText = "select * from Parcels";
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
            string ToDelete = TCodeTextBox.Text.Trim();

            if (!string.IsNullOrEmpty(ToDelete))
            {
                try
                {
                    if (ValidateInput())
                    {
                        conn.Open();
                        SqlCommand cmd = conn.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "DELETE FROM Parcels WHERE [Tracking Code]='" + TCodeTextBox.Text + "'";
                        int rowsAffected = cmd.ExecuteNonQuery();
                        conn.Close();
                        if (rowsAffected > 0)
                        {
                            disp_data();
                            MessageBox.Show("Record Deleted Successfully");
                        }
                        else
                        {
                            MessageBox.Show("No matching record found with the given Tracking Code.");
                        }
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
                MessageBox.Show("Please enter a Tracking Code to delete.");
            }
        }
    

        

        private void Parcel_Load(object sender, EventArgs e)
        {
            disp_data();
            PopulateVehicleComboBox();
            PopulateSenderComboBox();
            PopulateEmployeeComboBox();
        }

        private void PopulateVehicleComboBox()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT Plate_No FROM Vehicles";
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    VehiclecomboBox.Items.Add(dr["Plate_No"].ToString());
                }

                conn.Close();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }

        }

        private void PopulateSenderComboBox()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT [National Id] FROM Customers";
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    SendercomboBox.Items.Add(dr["National Id"].ToString());
                }

                conn.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();
            }
        }

        private void PopulateEmployeeComboBox()
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
                    EmpIDcomboBox.Items.Add(dr["ID"].ToString());
                }

                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();
            }
        }

        private void DestinationtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            string ToDelete = deleteTextbox.Text.Trim();

            if (!string.IsNullOrEmpty(ToDelete))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "DELETE FROM Parcels WHERE [Tracking Code]='" + deleteTextbox.Text + "'";
                    int rowsAffected = cmd.ExecuteNonQuery();
                    conn.Close();
                    if (rowsAffected > 0)
                    {
                        disp_data();
                        MessageBox.Show("Record Deleted Successfully");
                    }
                    else
                    {
                        MessageBox.Show("No matching record found with the given Tracking Code.");
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
                MessageBox.Show("Please enter a Tracking Code to delete.");
            }
            deleteTextbox.Text = "";
        }

        private void btnInsert_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (ValidateInput())
                {
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO Parcels VALUES('" + DescriptionTextBox.Text + "','" + TCodeTextBox.Text + "','" + VehiclecomboBox.Text + "','" + SendercomboBox.Text + "','" + EmpIDcomboBox.Text + "','" + RecepienttextBox.Text + "','" + DestinationtextBox.Text + "','" + float.Parse(WeightTextBox.Text) + "','" + LengthTextbox.Text + "')";
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    DescriptionTextBox.Text = "";
                    TCodeTextBox.Text = "";
                    VehiclecomboBox.Text = "";
                    SendercomboBox.Text = "";
                    EmpIDcomboBox.Text = "";
                    RecepienttextBox.Text = "";
                    DestinationtextBox.Text = "";
                    WeightTextBox.Text = "";
                    LengthTextbox.Text = "";

                    disp_data();
                    MessageBox.Show("Record Inserted Successfully!");
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        /*private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            
            try
            {
                MessageBox.Show("You can edit employee Id. Enter a Tracking Code");
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;


                cmd.CommandText = "UPDATE Parcels SET [Employee ID]=@emp WHERE  [Tracking Code] = @Code";

                cmd.Parameters.AddWithValue("@Code", TCodeTextBox.Text);
                cmd.Parameters.AddWithValue("@desc", DescriptionTextBox.Text);
                cmd.Parameters.AddWithValue("@Vehicle", VehiclecomboBox.Text);
                cmd.Parameters.AddWithValue("@send", SendercomboBox.Text);
                cmd.Parameters.AddWithValue("@resp", RecepienttextBox.Text);
                cmd.Parameters.AddWithValue("@des", DestinationtextBox.Text);
                cmd.Parameters.AddWithValue("@w", WeightTextBox.Text);
                cmd.Parameters.AddWithValue("@l", LengthTextbox.Text);
                cmd.Parameters.AddWithValue("@emp", EmpIDcomboBox.Text);

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

        private void btnDisplay_Click_1(object sender, EventArgs e)
        {
            disp_data();
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            try
            {
                string nicToSelect = SearchTextBox.Text.Trim();

                if (string.IsNullOrEmpty(nicToSelect))
                {
                    MessageBox.Show("Enter The Tracking Code");
                }
                else
                {
                    
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from Parcels where [Tracking Code]='" + SearchTextBox.Text + "'";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    conn.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            SearchTextBox.Text = "";
        }

        private void deleteTextbox_enter(object sender, EventArgs e)
        {
            if (deleteTextbox.Text == "Enter a Tracking Code")
            {
                deleteTextbox.Text = "";
                deleteTextbox.ForeColor = Color.Black;

            }
        }

        private void deleteTextbox_leave(object sender, EventArgs e)
        {
            if (deleteTextbox.Text == "")
            {
                deleteTextbox.Text = "Enter a Tracking Code";
                deleteTextbox.ForeColor = Color.Silver;

            }
        }

        private void SearchTextBox_enter(object sender, EventArgs e)
        {
            if (SearchTextBox.Text == "Enter a Tracking Code")
            {
                SearchTextBox.Text = "";
                SearchTextBox.ForeColor = Color.Black;

            }
        }

        private void SearchTextBox_leave(object sender, EventArgs e)
        {
            if (SearchTextBox.Text == "")
            {
                SearchTextBox.Text = "Enter a Tracking Code";
                SearchTextBox.ForeColor = Color.Silver;

            }
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
