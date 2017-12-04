namespace Events_Scheduler
{
    partial class AddingEvent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddingEvent));
            this.label1 = new System.Windows.Forms.Label();
            this.EventName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EventPlace = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Start_Date = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.S_T_Hours = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.S_T_Minutes = new System.Windows.Forms.TextBox();
            this.A_P_M = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.End_Date = new System.Windows.Forms.DateTimePicker();
            this.Submit_Btn = new System.Windows.Forms.Button();
            this.Time_Now = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Done = new System.Windows.Forms.Label();
            this.yesDone = new System.Windows.Forms.RadioButton();
            this.noDone = new System.Windows.Forms.RadioButton();
            this.claering = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            this.label1.UseWaitCursor = true;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // EventName
            // 
            this.EventName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.EventName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.EventName.Location = new System.Drawing.Point(172, 48);
            this.EventName.Name = "EventName";
            this.EventName.Size = new System.Drawing.Size(203, 32);
            this.EventName.TabIndex = 1;
            this.EventName.Text = "Enter Events\' name";
            this.EventName.UseWaitCursor = true;
            this.EventName.Click += new System.EventHandler(this.textBox1_Click);
            this.EventName.TextChanged += new System.EventHandler(this.EventName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Place :";
            this.label2.UseWaitCursor = true;
            // 
            // EventPlace
            // 
            this.EventPlace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.EventPlace.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventPlace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.EventPlace.Location = new System.Drawing.Point(172, 96);
            this.EventPlace.Name = "EventPlace";
            this.EventPlace.Size = new System.Drawing.Size(281, 32);
            this.EventPlace.TabIndex = 3;
            this.EventPlace.Text = "Enter Place The Event Will Be";
            this.EventPlace.UseWaitCursor = true;
            this.EventPlace.Click += new System.EventHandler(this.textBox2_Click);
            this.EventPlace.TextChanged += new System.EventHandler(this.EventPlace_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Start Day :";
            this.label3.UseWaitCursor = true;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Start_Date
            // 
            this.Start_Date.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Start_Date.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Start_Date.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start_Date.Location = new System.Drawing.Point(172, 150);
            this.Start_Date.Name = "Start_Date";
            this.Start_Date.Size = new System.Drawing.Size(224, 32);
            this.Start_Date.TabIndex = 5;
            this.Start_Date.Value = new System.DateTime(2017, 12, 3, 0, 0, 0, 0);
            this.Start_Date.ValueChanged += new System.EventHandler(this.Start_Date_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Start Time :";
            this.label4.UseWaitCursor = true;
            // 
            // S_T_Hours
            // 
            this.S_T_Hours.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.S_T_Hours.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S_T_Hours.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.S_T_Hours.Location = new System.Drawing.Point(172, 210);
            this.S_T_Hours.MaxLength = 2;
            this.S_T_Hours.Name = "S_T_Hours";
            this.S_T_Hours.Size = new System.Drawing.Size(35, 32);
            this.S_T_Hours.TabIndex = 7;
            this.S_T_Hours.Text = "HR";
            this.S_T_Hours.UseWaitCursor = true;
            this.S_T_Hours.Click += new System.EventHandler(this.textBox3_Click);
            this.S_T_Hours.TextChanged += new System.EventHandler(this.S_T_Hours_TextChanged);
            this.S_T_Hours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            this.S_T_Hours.Leave += new System.EventHandler(this.S_T_Hours_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label5.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(213, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = ":";
            this.label5.UseWaitCursor = true;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // S_T_Minutes
            // 
            this.S_T_Minutes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.S_T_Minutes.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S_T_Minutes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.S_T_Minutes.Location = new System.Drawing.Point(240, 210);
            this.S_T_Minutes.MaxLength = 2;
            this.S_T_Minutes.Name = "S_T_Minutes";
            this.S_T_Minutes.Size = new System.Drawing.Size(36, 32);
            this.S_T_Minutes.TabIndex = 9;
            this.S_T_Minutes.Text = "MN";
            this.S_T_Minutes.UseWaitCursor = true;
            this.S_T_Minutes.Click += new System.EventHandler(this.textBox4_Click);
            this.S_T_Minutes.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.S_T_Minutes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            this.S_T_Minutes.Leave += new System.EventHandler(this.S_T_Minutes_Leave);
            // 
            // A_P_M
            // 
            this.A_P_M.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.A_P_M.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A_P_M.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.A_P_M.FormattingEnabled = true;
            this.A_P_M.Items.AddRange(new object[] {
            "am",
            "pm"});
            this.A_P_M.Location = new System.Drawing.Point(308, 210);
            this.A_P_M.Name = "A_P_M";
            this.A_P_M.Size = new System.Drawing.Size(88, 32);
            this.A_P_M.TabIndex = 10;
            this.A_P_M.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "End Day :";
            this.label6.UseWaitCursor = true;
            // 
            // End_Date
            // 
            this.End_Date.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.End_Date.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.End_Date.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.End_Date.Location = new System.Drawing.Point(172, 268);
            this.End_Date.Name = "End_Date";
            this.End_Date.Size = new System.Drawing.Size(224, 32);
            this.End_Date.TabIndex = 12;
            this.End_Date.Value = new System.DateTime(2017, 12, 3, 0, 0, 0, 0);
            this.End_Date.ValueChanged += new System.EventHandler(this.End_Date_ValueChanged);
            // 
            // Submit_Btn
            // 
            this.Submit_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Submit_Btn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit_Btn.Location = new System.Drawing.Point(323, 320);
            this.Submit_Btn.Name = "Submit_Btn";
            this.Submit_Btn.Size = new System.Drawing.Size(130, 49);
            this.Submit_Btn.TabIndex = 16;
            this.Submit_Btn.Text = "Submit";
            this.Submit_Btn.UseVisualStyleBackColor = false;
            this.Submit_Btn.Click += new System.EventHandler(this.Submit_Btn_Click);
            // 
            // Time_Now
            // 
            this.Time_Now.AutoSize = true;
            this.Time_Now.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Time_Now.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Time_Now.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time_Now.ForeColor = System.Drawing.Color.Red;
            this.Time_Now.Location = new System.Drawing.Point(343, 408);
            this.Time_Now.Name = "Time_Now";
            this.Time_Now.Size = new System.Drawing.Size(65, 27);
            this.Time_Now.TabIndex = 17;
            this.Time_Now.Text = "Timer";
            this.Time_Now.Click += new System.EventHandler(this.label7_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(192, 408);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 27);
            this.label7.TabIndex = 18;
            this.label7.Text = "Time Now Is :";
            this.label7.Click += new System.EventHandler(this.label7_Click_1);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Done
            // 
            this.Done.AutoSize = true;
            this.Done.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Done.Location = new System.Drawing.Point(12, 337);
            this.Done.Name = "Done";
            this.Done.Size = new System.Drawing.Size(78, 25);
            this.Done.TabIndex = 19;
            this.Done.Text = "Done ?";
            // 
            // yesDone
            // 
            this.yesDone.AutoSize = true;
            this.yesDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.yesDone.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yesDone.Location = new System.Drawing.Point(98, 337);
            this.yesDone.Name = "yesDone";
            this.yesDone.Size = new System.Drawing.Size(56, 25);
            this.yesDone.TabIndex = 20;
            this.yesDone.TabStop = true;
            this.yesDone.Text = "yes";
            this.yesDone.UseVisualStyleBackColor = false;
            this.yesDone.CheckedChanged += new System.EventHandler(this.yesDone_CheckedChanged);
            // 
            // noDone
            // 
            this.noDone.AutoSize = true;
            this.noDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.noDone.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noDone.Location = new System.Drawing.Point(197, 337);
            this.noDone.Name = "noDone";
            this.noDone.Size = new System.Drawing.Size(49, 25);
            this.noDone.TabIndex = 21;
            this.noDone.TabStop = true;
            this.noDone.Text = "no";
            this.noDone.UseVisualStyleBackColor = false;
            this.noDone.CheckedChanged += new System.EventHandler(this.noDonoe_CheckedChanged);
            // 
            // claering
            // 
            this.claering.BackColor = System.Drawing.Color.Orchid;
            this.claering.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.claering.ForeColor = System.Drawing.Color.Aqua;
            this.claering.Location = new System.Drawing.Point(17, 389);
            this.claering.Name = "claering";
            this.claering.Size = new System.Drawing.Size(105, 46);
            this.claering.TabIndex = 22;
            this.claering.Text = "Clear  All";
            this.claering.UseVisualStyleBackColor = false;
            this.claering.Click += new System.EventHandler(this.claering_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkOrchid;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(721, 28);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.DarkViolet;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFormToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.Lime;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(45, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newFormToolStripMenuItem
            // 
            this.newFormToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.newFormToolStripMenuItem.Name = "newFormToolStripMenuItem";
            this.newFormToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.newFormToolStripMenuItem.Text = "new Form";
            this.newFormToolStripMenuItem.Click += new System.EventHandler(this.newFormToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.BackColor = System.Drawing.Color.DarkOrchid;
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMeToolStripMenuItem});
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.Lime;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutMeToolStripMenuItem
            // 
            this.aboutMeToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.aboutMeToolStripMenuItem.Name = "aboutMeToolStripMenuItem";
            this.aboutMeToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.aboutMeToolStripMenuItem.Text = "About Us";
            this.aboutMeToolStripMenuItem.Click += new System.EventHandler(this.aboutMeToolStripMenuItem_Click);
            // 
            // AddingEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.BackgroundImage = global::Events_Scheduler.Properties.Resources.concert_2527495_1280;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(721, 444);
            this.Controls.Add(this.claering);
            this.Controls.Add(this.noDone);
            this.Controls.Add(this.yesDone);
            this.Controls.Add(this.Done);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Time_Now);
            this.Controls.Add(this.Submit_Btn);
            this.Controls.Add(this.End_Date);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.A_P_M);
            this.Controls.Add(this.S_T_Minutes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.S_T_Hours);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Start_Date);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EventPlace);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EventName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AddingEvent";
            this.Text = "Add An Event";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EventName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EventPlace;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker Start_Date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox S_T_Hours;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox S_T_Minutes;
        private System.Windows.Forms.ComboBox A_P_M;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker End_Date;
        private System.Windows.Forms.Button Submit_Btn;
        private System.Windows.Forms.Label Time_Now;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.RadioButton noDone;
        private System.Windows.Forms.RadioButton yesDone;
        private System.Windows.Forms.Label Done;
        private System.Windows.Forms.Button claering;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMeToolStripMenuItem;
    }
}

