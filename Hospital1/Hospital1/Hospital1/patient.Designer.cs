namespace Hospital1
{
    partial class patient
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
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtdrid = new System.Windows.Forms.TextBox();
            this.txtdiesase = new System.Windows.Forms.TextBox();
            this.txtdate = new System.Windows.Forms.DateTimePicker();
            this.btnsub = new System.Windows.Forms.Button();
            this.txthr = new System.Windows.Forms.TextBox();
            this.txtmn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(12, 37);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(200, 20);
            this.txtid.TabIndex = 2;
            this.txtid.Text = "Enter ID";
            this.txtid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtid.Click += new System.EventHandler(this.clid);
            this.txtid.TextChanged += new System.EventHandler(this.txtid_TextChanged);
            this.txtid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.press);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(12, 86);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(200, 20);
            this.txtname.TabIndex = 1;
            this.txtname.Text = "Enter Name";
            this.txtname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtname.Click += new System.EventHandler(this.clname);
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            // 
            // txtdrid
            // 
            this.txtdrid.Location = new System.Drawing.Point(13, 190);
            this.txtdrid.Name = "txtdrid";
            this.txtdrid.Size = new System.Drawing.Size(200, 20);
            this.txtdrid.TabIndex = 2;
            this.txtdrid.Text = "DoctorID";
            this.txtdrid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtdrid.Click += new System.EventHandler(this.cldrid);
            // 
            // txtdiesase
            // 
            this.txtdiesase.Location = new System.Drawing.Point(12, 141);
            this.txtdiesase.Name = "txtdiesase";
            this.txtdiesase.Size = new System.Drawing.Size(200, 20);
            this.txtdiesase.TabIndex = 3;
            this.txtdiesase.Text = "DIsease Type";
            this.txtdiesase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtdiesase.Click += new System.EventHandler(this.cldisease);
            // 
            // txtdate
            // 
            this.txtdate.Location = new System.Drawing.Point(13, 235);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(200, 20);
            this.txtdate.TabIndex = 4;
            this.txtdate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnsub
            // 
            this.btnsub.Location = new System.Drawing.Point(314, 272);
            this.btnsub.Name = "btnsub";
            this.btnsub.Size = new System.Drawing.Size(154, 23);
            this.btnsub.TabIndex = 5;
            this.btnsub.Text = "Submit";
            this.btnsub.UseVisualStyleBackColor = true;
            this.btnsub.Click += new System.EventHandler(this.btnsub_Click);
            // 
            // txthr
            // 
            this.txthr.Location = new System.Drawing.Point(87, 269);
            this.txthr.Name = "txthr";
            this.txthr.Size = new System.Drawing.Size(41, 20);
            this.txthr.TabIndex = 6;
            this.txthr.Text = "HR";
            this.txthr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txthr.Click += new System.EventHandler(this.clhr);
            this.txthr.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtmn
            // 
            this.txtmn.Location = new System.Drawing.Point(150, 269);
            this.txtmn.Name = "txtmn";
            this.txtmn.Size = new System.Drawing.Size(46, 20);
            this.txtmn.TabIndex = 7;
            this.txtmn.Text = "MN";
            this.txtmn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtmn.Click += new System.EventHandler(this.clmn);
            this.txtmn.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Enter Time";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hospital1.Properties.Resources.patientheyadeh;
            this.pictureBox1.Location = new System.Drawing.Point(293, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 218);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(233, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(527, 307);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmn);
            this.Controls.Add(this.txthr);
            this.Controls.Add(this.btnsub);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.txtdiesase);
            this.Controls.Add(this.txtdrid);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtid);
            this.Name = "patient";
            this.Text = "patient";
            this.Load += new System.EventHandler(this.patient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtdrid;
        private System.Windows.Forms.TextBox txtdiesase;
        private System.Windows.Forms.DateTimePicker txtdate;
        private System.Windows.Forms.Button btnsub;
        private System.Windows.Forms.TextBox txthr;
        private System.Windows.Forms.TextBox txtmn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}