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
    public partial class Dashboard : Form
    {
        private SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-D1KEAHC\SQLEXPRESS;Initial Catalog=VisualStudioProject;Integrated Security=True");

        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

            // Load the number of rows for Vehicle and Customer tables and display in labels
            int vehicleRowCount = GetRowCount("Vehicles");
            int customerRowCount = GetRowCount("Ordertable");
            int employeeRowCount = GetRowCount("Employees");

            lblEmployeeCount.Text = employeeRowCount.ToString();
            lblCustomerCount.Text = customerRowCount.ToString();
            lblVehicleCount.Text = vehicleRowCount.ToString();

            FillChart();
        }

        private int GetRowCount(string tableName)
        {
            int rowCount = 0;

            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT COUNT(*) FROM " + tableName;

                rowCount = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return rowCount;
        }

        void FillChart()
        {
            // Create a DataTable to store the data from your SQL query
            DataTable table = new DataTable();

            // Open the database connection
            conn.Open();

            // Define your SQL query and execute it using a SqlDataAdapter
            SqlDataAdapter da = new SqlDataAdapter("SELECT Delivery_Status, COUNT(empID) AS EmployeeCount FROM Ordertable GROUP BY Delivery_Status", conn);
            da.Fill(table);

            // Set the DataTable as the data source for your chart
            chart1.DataSource = table;

            // Close the database connection
            conn.Close();

            // Clear any existing series from the chart
            chart1.Series.Clear();

            // Add a new series to the chart
            chart1.Series.Add("EmployeeCount");

            // Set the X and Y value members for the series
            chart1.Series["EmployeeCount"].XValueMember = "Delivery_Status";
            chart1.Series["EmployeeCount"].YValueMembers = "EmployeeCount";

            // Set the chart type to Column
            chart1.Series["EmployeeCount"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            // Optionally, set the chart title
            chart1.Titles.Add("Delivery Status vs. Employee Count");

            // Refresh the chart to display the data
            chart1.DataBind();
        }


        private void lblVehicleCount_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void lblEmployeeCount_Click(object sender, EventArgs e)
        {

        }

        private void lblCustomerCount_Click(object sender, EventArgs e)
        {

        }
    }

    
}


    
