﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ayubo_drive
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form vhe = new Vehicle();
            vhe.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form rnt = new Rent();
            rnt.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form pkg = new Package();
            pkg.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form cus = new Customer();
            cus.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form ltc = new Longtour();
            ltc.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form dtc = new Daytour();
            dtc.ShowDialog();
        }

    }
}
