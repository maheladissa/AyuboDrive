namespace Ayubo_drive
{
    partial class Package
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
            this.bt_search = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Updat = new System.Windows.Forms.Button();
            this.Insert = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rb_dt = new System.Windows.Forms.RadioButton();
            this.rb_lt = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_vtype = new System.Windows.Forms.ComboBox();
            this.vTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ayuboDriveDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ayubo_DriveDataSet = new Ayubo_drive.Ayubo_DriveDataSet();
            this.txt_pkgname = new System.Windows.Forms.TextBox();
            this.txt_pkgid = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_maxh = new System.Windows.Forms.TextBox();
            this.txt_ehc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_maxdays = new System.Windows.Forms.TextBox();
            this.txt_edc = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_ammo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_exkmc = new System.Windows.Forms.TextBox();
            this.txt_maxd = new System.Windows.Forms.TextBox();
            this.v_TypeTableAdapter = new Ayubo_drive.Ayubo_DriveDataSetTableAdapters.V_TypeTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ayuboDriveDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ayubo_DriveDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_search
            // 
            this.bt_search.Location = new System.Drawing.Point(285, 63);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(30, 22);
            this.bt_search.TabIndex = 39;
            this.bt_search.Text = "🔎";
            this.bt_search.UseVisualStyleBackColor = true;
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(636, 233);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 38;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Updat
            // 
            this.Updat.Location = new System.Drawing.Point(636, 164);
            this.Updat.Name = "Updat";
            this.Updat.Size = new System.Drawing.Size(75, 23);
            this.Updat.TabIndex = 37;
            this.Updat.Text = "Update";
            this.Updat.UseVisualStyleBackColor = true;
            this.Updat.Click += new System.EventHandler(this.Updat_Click);
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(636, 95);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(75, 23);
            this.Insert.TabIndex = 36;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rb_dt);
            this.panel1.Controls.Add(this.rb_lt);
            this.panel1.Location = new System.Drawing.Point(445, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 17);
            this.panel1.TabIndex = 32;
            // 
            // rb_dt
            // 
            this.rb_dt.AutoSize = true;
            this.rb_dt.Location = new System.Drawing.Point(0, 0);
            this.rb_dt.Name = "rb_dt";
            this.rb_dt.Size = new System.Drawing.Size(69, 17);
            this.rb_dt.TabIndex = 6;
            this.rb_dt.TabStop = true;
            this.rb_dt.Text = "Day Tour";
            this.rb_dt.UseVisualStyleBackColor = true;
            this.rb_dt.CheckedChanged += new System.EventHandler(this.rb_dt_CheckedChanged);
            // 
            // rb_lt
            // 
            this.rb_lt.AutoSize = true;
            this.rb_lt.Location = new System.Drawing.Point(72, 0);
            this.rb_lt.Name = "rb_lt";
            this.rb_lt.Size = new System.Drawing.Size(74, 17);
            this.rb_lt.TabIndex = 7;
            this.rb_lt.TabStop = true;
            this.rb_lt.Text = "Long Tour";
            this.rb_lt.UseVisualStyleBackColor = true;
            this.rb_lt.CheckedChanged += new System.EventHandler(this.rb_lt_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(341, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Package Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(341, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Vehicle Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Package Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(256, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(226, 31);
            this.label10.TabIndex = 23;
            this.label10.Text = "Package Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Package ID";
            // 
            // cb_vtype
            // 
            this.cb_vtype.DataSource = this.vTypeBindingSource;
            this.cb_vtype.DisplayMember = "vtype_name";
            this.cb_vtype.FormattingEnabled = true;
            this.cb_vtype.Location = new System.Drawing.Point(445, 64);
            this.cb_vtype.Name = "cb_vtype";
            this.cb_vtype.Size = new System.Drawing.Size(163, 21);
            this.cb_vtype.TabIndex = 20;
            this.cb_vtype.ValueMember = "vtype_id";
            // 
            // vTypeBindingSource
            // 
            this.vTypeBindingSource.DataMember = "V_Type";
            this.vTypeBindingSource.DataSource = this.ayuboDriveDataSetBindingSource;
            // 
            // ayuboDriveDataSetBindingSource
            // 
            this.ayuboDriveDataSetBindingSource.DataSource = this.ayubo_DriveDataSet;
            this.ayuboDriveDataSetBindingSource.Position = 0;
            // 
            // ayubo_DriveDataSet
            // 
            this.ayubo_DriveDataSet.DataSetName = "Ayubo_DriveDataSet";
            this.ayubo_DriveDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_pkgname
            // 
            this.txt_pkgname.Location = new System.Drawing.Point(117, 102);
            this.txt_pkgname.Name = "txt_pkgname";
            this.txt_pkgname.Size = new System.Drawing.Size(168, 20);
            this.txt_pkgname.TabIndex = 18;
            // 
            // txt_pkgid
            // 
            this.txt_pkgid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_pkgid.Location = new System.Drawing.Point(117, 64);
            this.txt_pkgid.MaxLength = 20;
            this.txt_pkgid.Name = "txt_pkgid";
            this.txt_pkgid.Size = new System.Drawing.Size(168, 20);
            this.txt_pkgid.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_ammo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_exkmc);
            this.groupBox1.Controls.Add(this.txt_maxd);
            this.groupBox1.Location = new System.Drawing.Point(17, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(591, 164);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Billing";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txt_maxh);
            this.panel2.Controls.Add(this.txt_ehc);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(9, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(582, 39);
            this.panel2.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Maximum Hours";
            // 
            // txt_maxh
            // 
            this.txt_maxh.Location = new System.Drawing.Point(142, 7);
            this.txt_maxh.Name = "txt_maxh";
            this.txt_maxh.Size = new System.Drawing.Size(100, 20);
            this.txt_maxh.TabIndex = 1;
            // 
            // txt_ehc
            // 
            this.txt_ehc.Location = new System.Drawing.Point(423, 7);
            this.txt_ehc.Name = "txt_ehc";
            this.txt_ehc.Size = new System.Drawing.Size(100, 20);
            this.txt_ehc.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(315, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Extra Hour Charge";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.txt_maxdays);
            this.panel3.Controls.Add(this.txt_edc);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Location = new System.Drawing.Point(9, 48);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(582, 39);
            this.panel3.TabIndex = 41;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(34, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Maximum Days";
            // 
            // txt_maxdays
            // 
            this.txt_maxdays.Location = new System.Drawing.Point(142, 7);
            this.txt_maxdays.Name = "txt_maxdays";
            this.txt_maxdays.Size = new System.Drawing.Size(100, 20);
            this.txt_maxdays.TabIndex = 1;
            // 
            // txt_edc
            // 
            this.txt_edc.Location = new System.Drawing.Point(423, 7);
            this.txt_edc.Name = "txt_edc";
            this.txt_edc.Size = new System.Drawing.Size(100, 20);
            this.txt_edc.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(315, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Extra Day Charge";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(324, 133);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Ammount";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(324, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Extra KM Charge";
            // 
            // txt_ammo
            // 
            this.txt_ammo.Location = new System.Drawing.Point(432, 130);
            this.txt_ammo.Name = "txt_ammo";
            this.txt_ammo.Size = new System.Drawing.Size(100, 20);
            this.txt_ammo.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Maximum Distance";
            // 
            // txt_exkmc
            // 
            this.txt_exkmc.Location = new System.Drawing.Point(432, 20);
            this.txt_exkmc.Name = "txt_exkmc";
            this.txt_exkmc.Size = new System.Drawing.Size(100, 20);
            this.txt_exkmc.TabIndex = 0;
            // 
            // txt_maxd
            // 
            this.txt_maxd.Location = new System.Drawing.Point(151, 20);
            this.txt_maxd.Name = "txt_maxd";
            this.txt_maxd.Size = new System.Drawing.Size(100, 20);
            this.txt_maxd.TabIndex = 0;
            // 
            // v_TypeTableAdapter
            // 
            this.v_TypeTableAdapter.ClearBeforeFill = true;
            // 
            // Package
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 327);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_search);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Updat);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_vtype);
            this.Controls.Add(this.txt_pkgname);
            this.Controls.Add(this.txt_pkgid);
            this.Name = "Package";
            this.Text = "Package";
            this.Load += new System.EventHandler(this.Package_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ayuboDriveDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ayubo_DriveDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_search;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Updat;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rb_dt;
        private System.Windows.Forms.RadioButton rb_lt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_vtype;
        private System.Windows.Forms.TextBox txt_pkgname;
        private System.Windows.Forms.TextBox txt_pkgid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_maxh;
        private System.Windows.Forms.TextBox txt_maxd;
        private System.Windows.Forms.BindingSource ayuboDriveDataSetBindingSource;
        private Ayubo_DriveDataSet ayubo_DriveDataSet;
        private System.Windows.Forms.BindingSource vTypeBindingSource;
        private Ayubo_DriveDataSetTableAdapters.V_TypeTableAdapter v_TypeTableAdapter;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_ammo;
        private System.Windows.Forms.TextBox txt_exkmc;
        private System.Windows.Forms.TextBox txt_ehc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_maxdays;
        private System.Windows.Forms.TextBox txt_edc;
        private System.Windows.Forms.Label label13;

    }
}