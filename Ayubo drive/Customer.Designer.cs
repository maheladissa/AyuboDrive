namespace Ayubo_drive
{
    partial class Customer
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
            this.v_TypeTableAdapter = new Ayubo_drive.Ayubo_DriveDataSetTableAdapters.V_TypeTableAdapter();
            this.Delete = new System.Windows.Forms.Button();
            this.Updat = new System.Windows.Forms.Button();
            this.Insert = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.vTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ayubo_DriveDataSet = new Ayubo_drive.Ayubo_DriveDataSet();
            this.txt_fname = new System.Windows.Forms.TextBox();
            this.txt_Addr = new System.Windows.Forms.TextBox();
            this.txt_lname = new System.Windows.Forms.TextBox();
            this.txt_cusID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_cont = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.vTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ayubo_DriveDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // v_TypeTableAdapter
            // 
            this.v_TypeTableAdapter.ClearBeforeFill = true;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(346, 268);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 38;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Updat
            // 
            this.Updat.Location = new System.Drawing.Point(184, 268);
            this.Updat.Name = "Updat";
            this.Updat.Size = new System.Drawing.Size(75, 23);
            this.Updat.TabIndex = 37;
            this.Updat.Text = "Update";
            this.Updat.UseVisualStyleBackColor = true;
            this.Updat.Click += new System.EventHandler(this.Updat_Click);
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(22, 268);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(75, 23);
            this.Insert.TabIndex = 36;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(355, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 23);
            this.button1.TabIndex = 39;
            this.button1.Text = "🔎";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(80, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(306, 31);
            this.label10.TabIndex = 25;
            this.label10.Text = "Customer Registration";
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
            // txt_fname
            // 
            this.txt_fname.Location = new System.Drawing.Point(186, 92);
            this.txt_fname.Name = "txt_fname";
            this.txt_fname.Size = new System.Drawing.Size(163, 20);
            this.txt_fname.TabIndex = 18;
            // 
            // txt_Addr
            // 
            this.txt_Addr.Location = new System.Drawing.Point(186, 168);
            this.txt_Addr.Multiline = true;
            this.txt_Addr.Name = "txt_Addr";
            this.txt_Addr.Size = new System.Drawing.Size(163, 48);
            this.txt_Addr.TabIndex = 34;
            // 
            // txt_lname
            // 
            this.txt_lname.Location = new System.Drawing.Point(186, 130);
            this.txt_lname.Name = "txt_lname";
            this.txt_lname.Size = new System.Drawing.Size(163, 20);
            this.txt_lname.TabIndex = 19;
            // 
            // txt_cusID
            // 
            this.txt_cusID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_cusID.Location = new System.Drawing.Point(186, 54);
            this.txt_cusID.MaxLength = 20;
            this.txt_cusID.Name = "txt_cusID";
            this.txt_cusID.Size = new System.Drawing.Size(163, 20);
            this.txt_cusID.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Customer ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Contact No";
            // 
            // txt_cont
            // 
            this.txt_cont.Location = new System.Drawing.Point(185, 228);
            this.txt_cont.Name = "txt_cont";
            this.txt_cont.Size = new System.Drawing.Size(163, 20);
            this.txt_cont.TabIndex = 19;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 312);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Updat);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_fname);
            this.Controls.Add(this.txt_Addr);
            this.Controls.Add(this.txt_cont);
            this.Controls.Add(this.txt_lname);
            this.Controls.Add(this.txt_cusID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "Customer";
            this.Text = "Customer";
            ((System.ComponentModel.ISupportInitialize)(this.vTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ayubo_DriveDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Ayubo_DriveDataSetTableAdapters.V_TypeTableAdapter v_TypeTableAdapter;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Updat;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.BindingSource vTypeBindingSource;
        private Ayubo_DriveDataSet ayubo_DriveDataSet;
        private System.Windows.Forms.TextBox txt_fname;
        private System.Windows.Forms.TextBox txt_Addr;
        private System.Windows.Forms.TextBox txt_lname;
        private System.Windows.Forms.TextBox txt_cusID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_cont;
    }
}