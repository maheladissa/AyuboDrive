using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Ayubo_drive
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=DESKTOP-IJHPBC7;Initial Catalog=Ayubo Drive;Integrated Security=True");
            string qry = "insert into Customer (CusID,First_name,Last_name,Address,Contact_No) values ('" + txt_cusID.Text + "','" + txt_fname.Text + "','" + txt_lname.Text + "','" + txt_Addr.Text + "','" + txt_cont.Text + "');";
            cn.Open();
            SqlCommand cmd = new SqlCommand(qry, cn);
            int i = cmd.ExecuteNonQuery();
            if (i == 1)
            {
                MessageBox.Show("Success");
                txt_cusID.Text = "";
                txt_fname.Text = "";
                txt_lname.Text = "";
                txt_Addr.Text = "";
                txt_cont.Text = "";
                
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void Updat_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=DESKTOP-IJHPBC7;Initial Catalog=Ayubo Drive;Integrated Security=True");
            string qry = "UPDATE Customer SET CusID='" + txt_cusID.Text + "', First_name='" + txt_fname.Text + "', last_name='" + txt_lname.Text + "', Address='" + txt_Addr.Text + "', Contact_No='" + txt_cont.Text +"';";
            cn.Open();
            SqlCommand cmd = new SqlCommand(qry, cn);
            int i = cmd.ExecuteNonQuery();
            if (i == 1)
            {
                MessageBox.Show("Success");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=DESKTOP-IJHPBC7;Initial Catalog=Ayubo Drive;Integrated Security=True");
            string qry = "Delete from Customer where cusID='" + txt_cusID.Text + "';";
            cn.Open();
            SqlCommand cmd = new SqlCommand(qry, cn);
            int i = cmd.ExecuteNonQuery();
            if (i == 1)
            {
                MessageBox.Show("Success");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=DESKTOP-IJHPBC7;Initial Catalog=Ayubo Drive;Integrated Security=True");
            string qry = "Select * from customer where CusID='" + txt_cusID.Text + "';";
            cn.Open();
            SqlCommand cmd = new SqlCommand(qry, cn);
            SqlDataReader dr = cmd.ExecuteReader();
            
            if (dr.Read())
            {
                txt_fname.Text = dr["First_name"].ToString();
                txt_lname.Text = dr["Last_name"].ToString();
                txt_Addr.Text = dr["Address"].ToString();
                txt_cont.Text = dr["Contact_No"].ToString();
            }
            else
            {
                MessageBox.Show("Customer Not Available");
            }
        }
    }
}
