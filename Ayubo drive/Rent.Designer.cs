namespace Ayubo_drive
{
    partial class Rent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Calculate = new System.Windows.Forms.Button();
            this.end = new System.Windows.Forms.DateTimePicker();
            this.start = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.vTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ayubo_DriveDataSet = new Ayubo_drive.Ayubo_DriveDataSet();
            this.v_TypeTableAdapter = new Ayubo_drive.Ayubo_DriveDataSetTableAdapters.V_TypeTableAdapter();
            this.lbl_days = new System.Windows.Forms.Label();
            this.lable4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_regnum = new System.Windows.Forms.TextBox();
            this.cb_type = new System.Windows.Forms.ComboBox();
            this.vTypeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_mon = new System.Windows.Forms.Label();
            this.Weeks = new System.Windows.Forms.Label();
            this.lbl_wee = new System.Windows.Forms.Label();
            this.lable7 = new System.Windows.Forms.Label();
            this.lbl_dats = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_dr = new System.Windows.Forms.Label();
            this.lbl_wr = new System.Windows.Forms.Label();
            this.lbl_mr = new System.Windows.Forms.Label();
            this.lbl_ammount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ayubo_DriveDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vTypeBindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(322, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rent Calculation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rent Date";
            // 
            // Calculate
            // 
            this.Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculate.Location = new System.Drawing.Point(15, 129);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(351, 34);
            this.Calculate.TabIndex = 7;
            this.Calculate.Text = "Calculate Number Of Days";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // end
            // 
            this.end.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.end.Location = new System.Drawing.Point(97, 62);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(98, 20);
            this.end.TabIndex = 6;
            // 
            // start
            // 
            this.start.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.start.Location = new System.Drawing.Point(97, 25);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(98, 20);
            this.start.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Return Date";
            // 
            // vTypeBindingSource
            // 
            this.vTypeBindingSource.DataMember = "V_Type";
            this.vTypeBindingSource.DataSource = this.ayubo_DriveDataSet;
            // 
            // ayubo_DriveDataSet
            // 
            this.ayubo_DriveDataSet.DataSetName = "Ayubo_DriveDataSet";
            this.ayubo_DriveDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_TypeTableAdapter
            // 
            this.v_TypeTableAdapter.ClearBeforeFill = true;
            // 
            // lbl_days
            // 
            this.lbl_days.AutoSize = true;
            this.lbl_days.BackColor = System.Drawing.SystemColors.Info;
            this.lbl_days.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_days.Location = new System.Drawing.Point(130, 104);
            this.lbl_days.Name = "lbl_days";
            this.lbl_days.Size = new System.Drawing.Size(44, 16);
            this.lbl_days.TabIndex = 8;
            this.lbl_days.Text = "            ";
            // 
            // lable4
            // 
            this.lable4.AutoSize = true;
            this.lable4.Location = new System.Drawing.Point(12, 104);
            this.lable4.Name = "lable4";
            this.lable4.Size = new System.Drawing.Size(112, 13);
            this.lable4.TabIndex = 9;
            this.lable4.Text = "Total Number Of Days";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Invoice No";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(281, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Monthly Rate";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(281, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "Weekly Rate";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(281, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "Daily Rate";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(31, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 16);
            this.label11.TabIndex = 11;
            this.label11.Text = "Type";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(34, 93);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(79, 17);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "With Driver";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(248, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 35);
            this.button1.TabIndex = 13;
            this.button1.Text = "Calculate Total Ammount";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(31, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Reg No";
            // 
            // txt_regnum
            // 
            this.txt_regnum.Location = new System.Drawing.Point(103, 24);
            this.txt_regnum.Name = "txt_regnum";
            this.txt_regnum.Size = new System.Drawing.Size(121, 20);
            this.txt_regnum.TabIndex = 14;
            // 
            // cb_type
            // 
            this.cb_type.DataSource = this.vTypeBindingSource1;
            this.cb_type.DisplayMember = "vtype_name";
            this.cb_type.FormattingEnabled = true;
            this.cb_type.Location = new System.Drawing.Point(103, 56);
            this.cb_type.Name = "cb_type";
            this.cb_type.Size = new System.Drawing.Size(121, 21);
            this.cb_type.TabIndex = 15;
            this.cb_type.ValueMember = "vtype_id";
            // 
            // vTypeBindingSource1
            // 
            this.vTypeBindingSource1.DataMember = "V_Type";
            this.vTypeBindingSource1.DataSource = this.ayubo_DriveDataSet;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(224, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(22, 22);
            this.button2.TabIndex = 16;
            this.button2.Text = "🔎";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.start);
            this.groupBox1.Controls.Add(this.end);
            this.groupBox1.Controls.Add(this.Calculate);
            this.groupBox1.Controls.Add(this.lable4);
            this.groupBox1.Controls.Add(this.lbl_days);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbl_mon);
            this.groupBox1.Controls.Add(this.Weeks);
            this.groupBox1.Controls.Add(this.lbl_wee);
            this.groupBox1.Controls.Add(this.lable7);
            this.groupBox1.Controls.Add(this.lbl_dats);
            this.groupBox1.Location = new System.Drawing.Point(12, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 185);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Date Calculation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(220, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Months";
            // 
            // lbl_mon
            // 
            this.lbl_mon.AutoSize = true;
            this.lbl_mon.BackColor = System.Drawing.SystemColors.Info;
            this.lbl_mon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mon.Location = new System.Drawing.Point(313, 26);
            this.lbl_mon.Name = "lbl_mon";
            this.lbl_mon.Size = new System.Drawing.Size(53, 20);
            this.lbl_mon.TabIndex = 10;
            this.lbl_mon.Text = "           ";
            // 
            // Weeks
            // 
            this.Weeks.AutoSize = true;
            this.Weeks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Weeks.Location = new System.Drawing.Point(219, 62);
            this.Weeks.Name = "Weeks";
            this.Weeks.Size = new System.Drawing.Size(51, 16);
            this.Weeks.TabIndex = 10;
            this.Weeks.Text = "Weeks";
            // 
            // lbl_wee
            // 
            this.lbl_wee.AutoSize = true;
            this.lbl_wee.BackColor = System.Drawing.SystemColors.Info;
            this.lbl_wee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_wee.Location = new System.Drawing.Point(313, 62);
            this.lbl_wee.Name = "lbl_wee";
            this.lbl_wee.Size = new System.Drawing.Size(53, 20);
            this.lbl_wee.TabIndex = 10;
            this.lbl_wee.Text = "           ";
            // 
            // lable7
            // 
            this.lable7.AutoSize = true;
            this.lable7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable7.Location = new System.Drawing.Point(219, 97);
            this.lable7.Name = "lable7";
            this.lable7.Size = new System.Drawing.Size(40, 16);
            this.lable7.TabIndex = 10;
            this.lable7.Text = "Days";
            // 
            // lbl_dats
            // 
            this.lbl_dats.AutoSize = true;
            this.lbl_dats.BackColor = System.Drawing.SystemColors.Info;
            this.lbl_dats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dats.Location = new System.Drawing.Point(313, 97);
            this.lbl_dats.Name = "lbl_dats";
            this.lbl_dats.Size = new System.Drawing.Size(53, 20);
            this.lbl_dats.TabIndex = 10;
            this.lbl_dats.Text = "           ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_ammount);
            this.groupBox2.Controls.Add(this.lbl_mr);
            this.groupBox2.Controls.Add(this.lbl_wr);
            this.groupBox2.Controls.Add(this.lbl_dr);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cb_type);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txt_regnum);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(427, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(464, 185);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ammount Calculation";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(31, 156);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 16);
            this.label12.TabIndex = 17;
            this.label12.Text = "Ammount";
            // 
            // lbl_dr
            // 
            this.lbl_dr.AutoSize = true;
            this.lbl_dr.BackColor = System.Drawing.SystemColors.Info;
            this.lbl_dr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_dr.Location = new System.Drawing.Point(378, 25);
            this.lbl_dr.Name = "lbl_dr";
            this.lbl_dr.Size = new System.Drawing.Size(76, 17);
            this.lbl_dr.TabIndex = 18;
            this.lbl_dr.Text = "                 ";
            // 
            // lbl_wr
            // 
            this.lbl_wr.AutoSize = true;
            this.lbl_wr.BackColor = System.Drawing.SystemColors.Info;
            this.lbl_wr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_wr.Location = new System.Drawing.Point(378, 59);
            this.lbl_wr.Name = "lbl_wr";
            this.lbl_wr.Size = new System.Drawing.Size(76, 17);
            this.lbl_wr.TabIndex = 19;
            this.lbl_wr.Text = "                 ";
            // 
            // lbl_mr
            // 
            this.lbl_mr.AutoSize = true;
            this.lbl_mr.BackColor = System.Drawing.SystemColors.Info;
            this.lbl_mr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_mr.Location = new System.Drawing.Point(378, 93);
            this.lbl_mr.Name = "lbl_mr";
            this.lbl_mr.Size = new System.Drawing.Size(76, 17);
            this.lbl_mr.TabIndex = 20;
            this.lbl_mr.Text = "                 ";
            // 
            // lbl_ammount
            // 
            this.lbl_ammount.AutoSize = true;
            this.lbl_ammount.BackColor = System.Drawing.SystemColors.Info;
            this.lbl_ammount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_ammount.Location = new System.Drawing.Point(101, 156);
            this.lbl_ammount.Name = "lbl_ammount";
            this.lbl_ammount.Size = new System.Drawing.Size(120, 17);
            this.lbl_ammount.TabIndex = 20;
            this.lbl_ammount.Text = "                            ";
            // 
            // Rent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 275);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Rent";
            this.Text = "Rent";
            this.Load += new System.EventHandler(this.Rent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ayubo_DriveDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vTypeBindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.DateTimePicker end;
        private System.Windows.Forms.DateTimePicker start;
        private System.Windows.Forms.Label label5;
        private Ayubo_DriveDataSet ayubo_DriveDataSet;
        private System.Windows.Forms.BindingSource vTypeBindingSource;
        private Ayubo_DriveDataSetTableAdapters.V_TypeTableAdapter v_TypeTableAdapter;
        private System.Windows.Forms.Label lbl_days;
        private System.Windows.Forms.Label lable4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_regnum;
        private System.Windows.Forms.ComboBox cb_type;
        private System.Windows.Forms.BindingSource vTypeBindingSource1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_mon;
        private System.Windows.Forms.Label Weeks;
        private System.Windows.Forms.Label lbl_wee;
        private System.Windows.Forms.Label lable7;
        private System.Windows.Forms.Label lbl_dats;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_mr;
        private System.Windows.Forms.Label lbl_wr;
        private System.Windows.Forms.Label lbl_dr;
        private System.Windows.Forms.Label lbl_ammount;
    }
}