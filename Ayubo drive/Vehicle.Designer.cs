namespace Ayubo_drive
{
    partial class Vehicle
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
            this.txt_regnum = new System.Windows.Forms.TextBox();
            this.txt_vmodel = new System.Windows.Forms.TextBox();
            this.txt_seatcap = new System.Windows.Forms.TextBox();
            this.txt_vbrand = new System.Windows.Forms.TextBox();
            this.cb_vtype = new System.Windows.Forms.ComboBox();
            this.vTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ayubo_DriveDataSet = new Ayubo_drive.Ayubo_DriveDataSet();
            this.cb_ftype = new System.Windows.Forms.ComboBox();
            this.rb_avai = new System.Windows.Forms.RadioButton();
            this.rb_noavil = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rb_ac = new System.Windows.Forms.RadioButton();
            this.rb_nac = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Insert = new System.Windows.Forms.Button();
            this.Updat = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.v_TypeTableAdapter = new Ayubo_drive.Ayubo_DriveDataSetTableAdapters.V_TypeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ayubo_DriveDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_regnum
            // 
            this.txt_regnum.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_regnum.Location = new System.Drawing.Point(190, 54);
            this.txt_regnum.MaxLength = 20;
            this.txt_regnum.Name = "txt_regnum";
            this.txt_regnum.Size = new System.Drawing.Size(163, 20);
            this.txt_regnum.TabIndex = 1;
            // 
            // txt_vmodel
            // 
            this.txt_vmodel.Location = new System.Drawing.Point(190, 130);
            this.txt_vmodel.Name = "txt_vmodel";
            this.txt_vmodel.Size = new System.Drawing.Size(163, 20);
            this.txt_vmodel.TabIndex = 3;
            // 
            // txt_seatcap
            // 
            this.txt_seatcap.Location = new System.Drawing.Point(190, 320);
            this.txt_seatcap.Name = "txt_seatcap";
            this.txt_seatcap.Size = new System.Drawing.Size(163, 20);
            this.txt_seatcap.TabIndex = 10;
            // 
            // txt_vbrand
            // 
            this.txt_vbrand.Location = new System.Drawing.Point(190, 92);
            this.txt_vbrand.Name = "txt_vbrand";
            this.txt_vbrand.Size = new System.Drawing.Size(163, 20);
            this.txt_vbrand.TabIndex = 2;
            // 
            // cb_vtype
            // 
            this.cb_vtype.DataSource = this.vTypeBindingSource;
            this.cb_vtype.DisplayMember = "vtype_name";
            this.cb_vtype.FormattingEnabled = true;
            this.cb_vtype.Location = new System.Drawing.Point(190, 168);
            this.cb_vtype.Name = "cb_vtype";
            this.cb_vtype.Size = new System.Drawing.Size(163, 21);
            this.cb_vtype.TabIndex = 4;
            this.cb_vtype.ValueMember = "vtype_id";
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
            // cb_ftype
            // 
            this.cb_ftype.FormattingEnabled = true;
            this.cb_ftype.Items.AddRange(new object[] {
            "Diesel",
            "Petrol"});
            this.cb_ftype.Location = new System.Drawing.Point(190, 206);
            this.cb_ftype.Name = "cb_ftype";
            this.cb_ftype.Size = new System.Drawing.Size(163, 21);
            this.cb_ftype.TabIndex = 5;
            // 
            // rb_avai
            // 
            this.rb_avai.AutoSize = true;
            this.rb_avai.Location = new System.Drawing.Point(0, 0);
            this.rb_avai.Name = "rb_avai";
            this.rb_avai.Size = new System.Drawing.Size(68, 17);
            this.rb_avai.TabIndex = 6;
            this.rb_avai.TabStop = true;
            this.rb_avai.Text = "Available";
            this.rb_avai.UseVisualStyleBackColor = true;
            // 
            // rb_noavil
            // 
            this.rb_noavil.AutoSize = true;
            this.rb_noavil.Location = new System.Drawing.Point(72, 0);
            this.rb_noavil.Name = "rb_noavil";
            this.rb_noavil.Size = new System.Drawing.Size(88, 17);
            this.rb_noavil.TabIndex = 7;
            this.rb_noavil.TabStop = true;
            this.rb_noavil.Text = "Not Available";
            this.rb_noavil.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(190, 355);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(199, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Registration  Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Vehicle Brand";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vehicle Model";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Seating Capacity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Vehicle Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fule Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Availability";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 285);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Airconditioned";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rb_avai);
            this.panel1.Controls.Add(this.rb_noavil);
            this.panel1.Location = new System.Drawing.Point(190, 243);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 17);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rb_ac);
            this.panel2.Controls.Add(this.rb_nac);
            this.panel2.Location = new System.Drawing.Point(190, 281);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(163, 17);
            this.panel2.TabIndex = 8;
            // 
            // rb_ac
            // 
            this.rb_ac.AutoSize = true;
            this.rb_ac.Location = new System.Drawing.Point(0, 0);
            this.rb_ac.Name = "rb_ac";
            this.rb_ac.Size = new System.Drawing.Size(43, 17);
            this.rb_ac.TabIndex = 8;
            this.rb_ac.TabStop = true;
            this.rb_ac.Text = "Yes";
            this.rb_ac.UseVisualStyleBackColor = true;
            // 
            // rb_nac
            // 
            this.rb_nac.AutoSize = true;
            this.rb_nac.Location = new System.Drawing.Point(72, 0);
            this.rb_nac.Name = "rb_nac";
            this.rb_nac.Size = new System.Drawing.Size(39, 17);
            this.rb_nac.TabIndex = 9;
            this.rb_nac.TabStop = true;
            this.rb_nac.Text = "No";
            this.rb_nac.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 361);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Registration Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(114, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(276, 31);
            this.label10.TabIndex = 5;
            this.label10.Text = "Vehicle Registration";
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(20, 410);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(75, 23);
            this.Insert.TabIndex = 12;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // Updat
            // 
            this.Updat.Location = new System.Drawing.Point(182, 410);
            this.Updat.Name = "Updat";
            this.Updat.Size = new System.Drawing.Size(75, 23);
            this.Updat.TabIndex = 13;
            this.Updat.Text = "Update";
            this.Updat.UseVisualStyleBackColor = true;
            this.Updat.Click += new System.EventHandler(this.Updat_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(344, 410);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 15;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(359, 52);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(30, 23);
            this.Search.TabIndex = 16;
            this.Search.Text = "🔎";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.search_Click);
            // 
            // v_TypeTableAdapter
            // 
            this.v_TypeTableAdapter.ClearBeforeFill = true;
            // 
            // Vehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 481);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Updat);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cb_ftype);
            this.Controls.Add(this.cb_vtype);
            this.Controls.Add(this.txt_vbrand);
            this.Controls.Add(this.txt_seatcap);
            this.Controls.Add(this.txt_vmodel);
            this.Controls.Add(this.txt_regnum);
            this.Name = "Vehicle";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ayubo_DriveDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_regnum;
        private System.Windows.Forms.TextBox txt_vmodel;
        private System.Windows.Forms.TextBox txt_seatcap;
        private System.Windows.Forms.TextBox txt_vbrand;
        private System.Windows.Forms.ComboBox cb_ftype;
        private System.Windows.Forms.RadioButton rb_avai;
        private System.Windows.Forms.RadioButton rb_noavil;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rb_ac;
        private System.Windows.Forms.RadioButton rb_nac;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Button Updat;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.ComboBox cb_vtype;
        private System.Windows.Forms.Button Search;
        private Ayubo_DriveDataSet ayubo_DriveDataSet;
        private System.Windows.Forms.BindingSource vTypeBindingSource;
        private Ayubo_DriveDataSetTableAdapters.V_TypeTableAdapter v_TypeTableAdapter;
    }
}

