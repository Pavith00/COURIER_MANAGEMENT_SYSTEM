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
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjectNew
{
    public partial class Order : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-D1KEAHC\SQLEXPRESS;Initial Catalog=VisualStudioProject;Integrated Security=True");

        public Order()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PopulateEmpComboBox()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT ID FROM EMPLOYEES";
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    empCombo.Items.Add(dr["ID"].ToString());
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }

        }

        private void Order_Load(object sender, EventArgs e)
        {
            PopulateEmpComboBox();
            PopulateTrackingpComboBox();
        }

        private void PopulateTrackingpComboBox()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT [Tracking Code] FROM parcels";
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    TrackingCombo.Items.Add(dr["Tracking Code"].ToString());
                }

                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();
            }

        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                string del;
                if (delivered.Checked == true)
                {
                    del = "Delivered";
                }
                else if(delayDeliverd.Checked == true) 
                {
                    del = "Delayed";
                }
                else
                {
                    del = "undelivered";
                }
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO Ordertable VALUES('" + empCombo.Text + "','" + TrackingCombo.Text + "','" + del + "')";
                cmd.ExecuteNonQuery();
                conn.Close();
                TrackingCombo.Text = "";
                empCombo.Text = "";
                
                MessageBox.Show("Record Saved Successfully!");
            
            }catch(Exception ex)
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
                    cmd.CommandText = "DELETE FROM Ordertable WHERE empID='" + deleteTextbox.Text + "'";
                    int rowsAffected = cmd.ExecuteNonQuery();
                    conn.Close();
                    if (rowsAffected > 0)
                    {
                        
                        MessageBox.Show("Record Deleted Successfully");
                    }
                    else
                    {
                        MessageBox.Show("No matching record.");
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

        private void deleteTextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
