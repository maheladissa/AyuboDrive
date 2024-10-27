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
    public partial class Longtour : Form
    {
        public Longtour()
        {
            InitializeComponent();
        }
        double exkmchar;
        double exdayc;
        private void Search_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=DESKTOP-IJHPBC7;Initial Catalog=Ayubo Drive;Integrated Security=True");
            string qry = "Select * from package where pack_id='" + txt_packid.Text + "';";
            cn.Open();
            SqlCommand cmd = new SqlCommand(qry, cn);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                lbl_pname.Text = dr["pack_name"].ToString();
                lbl_pammount.Text = dr["ammount"].ToString();
                lbl_maxkm.Text = dr["max_km"].ToString();
                lbl_maxday.Text = dr["max_days"].ToString();
                lbl_exdaych.Text = dr["ex_dr"].ToString();
                lbl_ekmCha.Text = dr["ex_kr"].ToString();


            }
            else
            {
                MessageBox.Show("Package Not Available");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime stime = dt_start.Value;
            DateTime etime = dt_end.Value;
            TimeSpan ts = etime - stime;
            int tothrs = ts.Days;
            lbl_tothr.Text = tothrs.ToString();
            double hrch = double.Parse(lbl_exdaych.Text);
            int maxhrs = int.Parse(lbl_maxday.Text);
            if (tothrs > maxhrs)
            {
                int exhr = tothrs - maxhrs;
                lbl_exhr.Text = exhr.ToString();
                exdayc = exhr * hrch;
                lbl_extdaycharge.Text = exdayc.ToString();
            }
            else
            {
                lbl_extdaycharge.Text = "00.00";
                lbl_exhr.Text = "0000";
            }
        }

        private void btn_calKm_Click(object sender, EventArgs e)
        {
            int skm = int.Parse(txt_skm.Text);
            int ekm = int.Parse(txt_ekm.Text);
            int tkm = ekm - skm;
            lbl_totkm.Text = tkm.ToString();
            double kmch = double.Parse(lbl_ekmCha.Text);
            int maxkm = int.Parse(lbl_maxkm.Text);
            if (tkm > maxkm)
            {
                int exkm = tkm - maxkm;
                lbl_exkm.Text = exkm.ToString();
                exkmchar = exkm * kmch;
                lbl_exkmchar.Text = exkmchar.ToString();
            }
            else
            {
                lbl_exkmchar.Text = "00.00";
                lbl_exkm.Text = "0000";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int skm = int.Parse(txt_skm.Text);
            int ekm = int.Parse(txt_ekm.Text);
            int tkm = ekm - skm;
            lbl_totkm.Text = tkm.ToString();
            double kmch = double.Parse(lbl_exdaych.Text);
            int maxkm = int.Parse(lbl_maxkm.Text);
            if (tkm > maxkm)
            {
                int exkm = tkm - maxkm;
                lbl_exkm.Text = exkm.ToString();
                exkmchar = exkm * kmch;
                lbl_exkmchar.Text = exkmchar.ToString();
            }
            else
            {
                lbl_exkmchar.Text = "00.00";
                lbl_exkm.Text = "0000";
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            double ammo = double.Parse(lbl_pammount.Text) + exkmchar + exdayc;
            lbl_tammount.Text = ammo.ToString();
        }
    }
}
