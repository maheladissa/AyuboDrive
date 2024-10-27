using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Ayubo_drive
{
    public partial class Vehicle : Form
    {
        public Vehicle()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ayubo_DriveDataSet.V_Type' table. You can move, or remove it, as needed.
            this.v_TypeTableAdapter.Fill(this.ayubo_DriveDataSet.V_Type);
            cb_vtype.ValueMember = "vtype_id";
            cb_vtype.DisplayMember = "vtype_name";

        }

        private void Insert_Click(object sender, EventArgs e)
        {
            if (txt_regnum.Text == "")
            {
                MessageBox.Show("Error");
            }
            else if(txt_vbrand.Text=="")
            {
                MessageBox.Show("Error");
            }

            string avi;
            if (rb_avai.Checked == true)
            {
                avi = "Available";
            }
            else if (rb_noavil.Checked == true)
            {
                avi = "Not Available";
            }
            else {
                avi = "";
            }

            string ac;
            if (rb_avai.Checked == true)
            {
                ac = "Airconditioned";
            }
            else if (rb_noavil.Checked == true)
            {
                ac = "Not Airconditioned";
            }
            else
            {
                ac = "";
            }
            SqlConnection cn = new SqlConnection("Data Source=DESKTOP-IJHPBC7;Initial Catalog=Ayubo Drive;Integrated Security=True");
            string qry = "insert into vehical (reg_num,v_brand,v_model,v_type,f_type,availability,airconditioned,seatingcap,reg_date) values ('" + txt_regnum.Text + "','" + txt_vbrand.Text + "','" + txt_vmodel.Text + "','" + cb_vtype.SelectedValue + "','" + cb_ftype.SelectedItem + "','" +avi+ "','" +ac+ "','" + int.Parse(txt_seatcap.Text) + "','" + dateTimePicker1.Value + "');";
            cn.Open();
            SqlCommand cmd=new SqlCommand(qry,cn);
            int i =cmd.ExecuteNonQuery();
            if (i==1){
                MessageBox.Show("Success");
                txt_regnum.Text = "";
                txt_seatcap.Text = "";
                txt_vbrand.Text = "";
                txt_vmodel.Text="";
                rb_ac.Checked = false;
                rb_avai.Checked = false;
                rb_nac.Checked = false;
                rb_noavil.Checked = false;
                cb_vtype.Text = "";
                cb_ftype.Text = "";
            }
            else
            {
                MessageBox.Show("Error");
            }

        }

        private void Updat_Click(object sender, EventArgs e)
        {

            if (txt_regnum.Text == "")
            {
                MessageBox.Show("Error");
            }
            else if (txt_vbrand.Text == "")
            {
                MessageBox.Show("Error");
            }

            string avi;
            if (rb_avai.Checked == true)
            {
                avi = "Available";
            }
            else if (rb_noavil.Checked == true)
            {
                avi = "Not Available";
            }
            else
            {
                avi = "";
            }

            string ac;
            if (rb_avai.Checked == true)
            {
                ac = "Airconditioned";
            }
            else if (rb_noavil.Checked == true)
            {
                ac = "Not Airconditioned";
            }
            else
            {
                ac = "";
            }


            SqlConnection cn = new SqlConnection("Data Source=DESKTOP-IJHPBC7;Initial Catalog=Ayubo Drive;Integrated Security=True");
            string qry = "UPDATE Vehicle SET v_brand='" + txt_vbrand.Text + "', v_model='" + txt_vmodel.Text + "', v_type='" + cb_vtype.SelectedItem + "', f_type='" + cb_ftype.SelectedItem + "', availability='" +avi+"', airconditioned='" +ac+"', seatingcap='" + int.Parse(txt_seatcap.Text) +"', reg_date='" + dateTimePicker1.Value + "'where reg_num='" + txt_regnum.Text + "';";
            cn.Open();
           SqlCommand cmd=new SqlCommand(qry,cn);
            int i =cmd.ExecuteNonQuery();
            if (i==1){
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
            string qry = "Delete from vehical where reg_num='"+txt_regnum.Text+"';";
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

        private void View_Click(object sender, EventArgs e)
        {
            
        }

        private void search_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=DESKTOP-IJHPBC7;Initial Catalog=Ayubo Drive;Integrated Security=True");
            string qry = "Select * from vehical where reg_num='" + txt_regnum.Text + "';";
            cn.Open();
            SqlCommand cmd = new SqlCommand(qry, cn);
            SqlDataReader dr = cmd.ExecuteReader();
            string avi;
            string ac;
            if (dr.Read())
            {
                txt_regnum.Text= dr["reg_num"].ToString();
                txt_vmodel.Text = dr["v_model"].ToString();
                txt_vbrand.Text=dr["v_brand"].ToString();
                txt_seatcap.Text = dr["seatingcap"].ToString();
                cb_ftype.SelectedItem = dr["f_type"];
                cb_vtype.SelectedValue = dr["vtype_id"];
                dateTimePicker1.Value = Convert.ToDateTime(dr["reg_date"]);
                avi = dr["availability"].ToString();
                if(avi=="available")
                {
                    rb_avai.Checked = true;
                }
                else
                {
                    rb_noavil.Checked = true;
                }
                ac = dr["airconditioned"].ToString();
                if (ac == "Airconditioned")
                {
                    rb_ac.Checked = true;
                }
                else
                {
                    rb_nac.Checked = true;
                }
            }
            else{
                MessageBox.Show("Vehical Not Available");
            }


            }

        }
    }

