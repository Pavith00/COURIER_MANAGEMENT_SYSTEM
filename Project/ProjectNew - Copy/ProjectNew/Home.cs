using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectNew
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            loardForm(new Dashboard());
        }



        private void btnCustomer_Click(object sender, EventArgs e)
        {
            loardForm(new Customer());

        }

        public void loardForm(object Form)
        {

            if(this.Mainpanel.Controls.Count > 0) 
                this.Mainpanel.Controls.RemoveAt(0);
            Form f=Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.Mainpanel.Controls.Add(f);
            this.Mainpanel.Tag = f;
            f.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void btnParcel_Click(object sender, EventArgs e)
        {
            loardForm(new Parcel());
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            loardForm(new Staff());
        }

        private void btnVehicle_Click(object sender, EventArgs e)
        {
            loardForm(new Vehicle());
        }

        private void btnBranches_Click(object sender, EventArgs e)
        {
            loardForm(new Branches());
        }

        private void panelCancel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
                WindowState = FormWindowState.Minimized;
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            loardForm(new Dashboard());
        }

        private void Mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DS_Click(object sender, EventArgs e)
        {
            loardForm(new Delivery());
        }
    }
}
