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

namespace ProjectNew
{
    public partial class Delivery : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-D1KEAHC\SQLEXPRESS;Initial Catalog=VisualStudioProject;Integrated Security=True");

        public Delivery()
        {
            InitializeComponent();
        }

        private void Delivery_Load(object sender, EventArgs e)
        {
            disp_data();
        }

        public void disp_data()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Ordertable";
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

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            disp_data();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                    cmd.CommandText = "DELETE FROM Ordertable WHERE Delivery_Status='" + deleteTextbox.Text + "'";
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

        private void deleteTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void deleteTextbox_enter(object sender, EventArgs e)
        {
            if (deleteTextbox.Text == "Enter a Delivery Status")
            {
                deleteTextbox.Text = "";
                deleteTextbox.ForeColor = Color.Black;

            }
        }

        private void deleteTextbox_leave(object sender, EventArgs e)
        {
            if (deleteTextbox.Text == "")
            {
                deleteTextbox.Text = "Enter a Delivery Status";
                deleteTextbox.ForeColor = Color.Silver;

            }
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            try
            {
                string plnToSelect = SearchTextBox.Text.Trim();

                if (string.IsNullOrEmpty(plnToSelect))
                {
                    MessageBox.Show("Select a Tracking Code");
                }
                else
                {
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from Ordertable where Tracking_code='" + SearchTextBox.Text + "'";
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

        private void btnDisplay_Click_1(object sender, EventArgs e)
        {
            disp_data();
        }
    }
}
