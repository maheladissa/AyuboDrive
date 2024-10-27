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
    
    public partial class Package : Form
    {
        string type;
        string pkgid;
        string pname;
        object vtype;
        int mhrs;
        int mdays;
        int mkms;
        double exhr;
        double exdr;
        double exkr;
        double ammo;
        public Package()
        {
            InitializeComponent();
            
        }

        private void rb_dt_CheckedChanged(object sender, EventArgs e)
        {
            panel2.Enabled = true;
            panel3.Enabled = false;
        }

        private void rb_lt_CheckedChanged(object sender, EventArgs e)
        {
            panel3.Enabled = true;
            panel2.Enabled = false;
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            if (rb_dt.Checked == true)
            {
                type = "DT";
            }
            else if (rb_lt.Checked == true)
            {
                type = "LT";
            }
            else
            {
                type = "";
            }

            pkgid = txt_pkgid.Text;
            pname = txt_pkgname.Text;
            vtype = cb_vtype.SelectedValue;
            mhrs = string.IsNullOrEmpty(txt_maxh.Text) ? 0 : int.Parse(txt_maxh.Text);
            mdays = string.IsNullOrEmpty(txt_maxdays.Text) ? 0 : int.Parse(txt_maxdays.Text);
            mkms = int.Parse(txt_maxd.Text);
            exhr = string.IsNullOrEmpty(txt_ehc.Text) ? 0 : double.Parse(txt_ehc.Text);
            exdr = string.IsNullOrEmpty(txt_edc.Text) ? 0 : double.Parse(txt_edc.Text);
            exkr = double.Parse(txt_exkmc.Text);
            ammo = double.Parse(txt_ammo.Text);

            SqlConnection cn = new SqlConnection("Data Source=DESKTOP-IJHPBC7;Initial Catalog=Ayubo Drive;Integrated Security=True");
            string qry = "insert into Package values ('" + pkgid + "','" + pname + "','" + vtype + "','" + mhrs + "','" + mdays + "','" + mkms + "','" + ammo + "','" + exhr + "','" + exdr +"','"+exkr+"','"+type+ "');";
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

        private void Package_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ayubo_DriveDataSet.V_Type' table. You can move, or remove it, as needed.
            this.v_TypeTableAdapter.Fill(this.ayubo_DriveDataSet.V_Type);

        }

        private void Updat_Click(object sender, EventArgs e)
        {
            if (rb_dt.Checked == true)
            {
                type = "DT";
            }
            else if (rb_lt.Checked == true)
            {
                type = "LT";
            }
            else
            {
                type = "";
            }

            pkgid = txt_pkgid.Text;
            pname = txt_pkgname.Text;
            vtype = cb_vtype.SelectedValue;
            mhrs = string.IsNullOrEmpty(txt_maxh.Text) ? 0 : int.Parse(txt_maxh.Text);
            mdays = string.IsNullOrEmpty(txt_maxdays.Text) ? 0 : int.Parse(txt_maxdays.Text);
            mkms = int.Parse(txt_maxd.Text);
            exhr = string.IsNullOrEmpty(txt_ehc.Text) ? 0 : double.Parse(txt_ehc.Text);
            exdr = string.IsNullOrEmpty(txt_edc.Text) ? 0 : double.Parse(txt_edc.Text);
            exkr = double.Parse(txt_exkmc.Text);
            ammo = double.Parse(txt_ammo.Text);

            SqlConnection cn = new SqlConnection("Data Source=DESKTOP-IJHPBC7;Initial Catalog=Ayubo Drive;Integrated Security=True");
            string qry = "UPDATE Package SET pack_name='" + pname + "', vtype_id='" + vtype + "', max_hour='" + mhrs + "', max_days='" + mdays + "', max_km='" + mkms + "', ammount='" + ammo + "', ex_hr='" + exhr + "', ex_dr='" + exdr +"', ex_kr='"+exkr+"', pack_type='"+type+ "'where pack_id='" + pkgid + "';";
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
            string qry = "Delete from Package where pack_id='" + txt_pkgid.Text + "';";
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

        private void bt_search_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=DESKTOP-IJHPBC7;Initial Catalog=Ayubo Drive;Integrated Security=True");
            string qry = "Select * from Package where pack_id='" + txt_pkgid.Text + "';";
            cn.Open();
            SqlCommand cmd = new SqlCommand(qry, cn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txt_pkgname.Text= dr["pack_name"].ToString();
                cb_vtype.SelectedValue = dr["vtype_id"];
                txt_maxh.Text=dr["max_hour"].ToString();
                txt_maxdays.Text = dr["max_days"].ToString();
                txt_maxd.Text = dr["max_km"].ToString();
                txt_ammo.Text = dr["ammount"].ToString();
                txt_ehc.Text = Convert.ToString(dr["ex_hr"]);
                txt_edc.Text = dr["ex_dr"].ToString();
                txt_exkmc.Text = dr["ex_kr"].ToString();
                type = dr["pack_type"].ToString();
                if(type=="DT")
                {
                    rb_dt.Checked = true;
                }
                else
                {
                    rb_lt.Checked = true;
                }
                
            }
            else
            {
                MessageBox.Show("Package Not Available");
            }


            
        }
    }
}
