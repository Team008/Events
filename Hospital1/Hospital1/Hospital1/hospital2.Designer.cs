namespace Hospital1
{
    partial class hospital2
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
            this.txtspec = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(41, 28);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(220, 20);
            this.txtid.TabIndex = 0;
            this.txtid.Text = "Enter ID";
            this.txtid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtid.Click += new System.EventHandler(this.clickid);
            this.txtid.TextChanged += new System.EventHandler(this.txtid_TextChanged);
            this.txtid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keypress_id);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(41, 123);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(220, 20);
            this.txtname.TabIndex = 1;
            this.txtname.Text = "Enter Name";
            this.txtname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtname.Click += new System.EventHandler(this.clickname);
            // 
            // txtspec
            // 
            this.txtspec.Location = new System.Drawing.Point(41, 211);
            this.txtspec.Name = "txtspec";
            this.txtspec.Size = new System.Drawing.Size(220, 20);
            this.txtspec.TabIndex = 2;
            this.txtspec.Text = "Enter Speciality";
            this.txtspec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtspec.Click += new System.EventHandler(this.clickspec);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(192, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "SUBMIT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Hospital1.Properties.Resources.elshantadr;
            this.pictureBox2.Location = new System.Drawing.Point(356, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(226, 221);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(53, 270);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // hospital2
            // 
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(610, 314);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtspec);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtid);
            this.Name = "hospital2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox drid;
        private System.Windows.Forms.TextBox drname;
        private System.Windows.Forms.TextBox drspeciality;
       
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtspec;
        private System.Windows.Forms.Button btnsub;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button2;
    }
}