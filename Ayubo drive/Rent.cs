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
    public partial class Rent : Form
    {
        double driver_rate;
        double ammount;
        int now;
        int nom;
        int nod;

        public Rent()
        {
            InitializeComponent();
        }


        private void Calculate_Click(object sender, EventArgs e)
        {
            DateTime enddate= end.Value;
            DateTime startdate= start.Value;
            nod= (enddate.Date-startdate.Date).Days;
            if (nod >= 0)
            {
                lbl_days.Text = nod.ToString();
                

                if (nod >= 30)
                {
                    nom = nod / 30;
                    nod = (nod - nom * 30);
                    now = nod / 7;
                    nod = (nod - now * 7);
                    lbl_mon.Text = nom.ToString();
                    lbl_wee.Text = now.ToString();
                    lbl_dats.Text = nod.ToString();
                }
                else if (nod >= 7)
                {
                    nom = 0;
                    now = nod / 7;
                    nod = (nod - now * 7);
                    lbl_mon.Text = nom.ToString();
                    lbl_wee.Text = now.ToString();
                    lbl_dats.Text = nod.ToString();

                }
                else if (nod >= 0)
                {
                    nom = 0;
                    now = 0;
                    lbl_mon.Text = nom.ToString();
                    lbl_wee.Text = now.ToString();
                    lbl_dats.Text = nod.ToString();
                }
            }
            else
            {
                MessageBox.Show("Error");
            }

            }
        

        private void Rent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ayubo_DriveDataSet.V_Type' table. You can move, or remove it, as needed.
            this.v_TypeTableAdapter.Fill(this.ayubo_DriveDataSet.V_Type);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=DESKTOP-IJHPBC7;Initial Catalog=Ayubo Drive;Integrated Security=True");
            string qry = "Select * from vehical where reg_num='" + txt_regnum.Text + "';";
            cn.Open();
            SqlCommand cmd = new SqlCommand(qry, cn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                cb_type.SelectedValue = dr["vtype_id"];
            }
            else{
                MessageBox.Show("Vehical Not Available");
            }
            SqlConnection cn1 = new SqlConnection("Data Source=DESKTOP-IJHPBC7;Initial Catalog=Ayubo Drive;Integrated Security=True");
            string qry1 = "Select * from v_type where vtype_id='" + cb_type.SelectedValue + "';";
            cn1.Open();
            SqlCommand cmd1 = new SqlCommand(qry1, cn1);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            if (dr1.Read())
            {
                lbl_dr.Text = dr1["d_rent"].ToString();
                lbl_mr.Text = dr1["m_rent"].ToString();
                lbl_wr.Text = dr1["w_rent"].ToString();
            }
            else
            {
  
            }

            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {
                driver_rate = 1500;
            }
            else
            {
                driver_rate = 0;
            }
            double dr = double.Parse(lbl_dr.Text);
            double wr = double.Parse(lbl_wr.Text);
            double mr = double.Parse(lbl_mr.Text);
            ammount = dr * nod + wr * now + mr * nom + (driver_rate *int.Parse(lbl_days.Text));
            lbl_ammount.Text = ammount.ToString();


        }

       
        }
    }

