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
            this.EventName = new System.Windows.Forms.TextBox();
            this.EventPlace = new System.Windows.Forms.TextBox();
            this.Start_Date = new System.Windows.Forms.DateTimePicker();
            this.S_T_Hours = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.S_T_Minutes = new System.Windows.Forms.TextBox();
            this.A_P_M = new System.Windows.Forms.ComboBox();
            this.End_Date = new System.Windows.Forms.DateTimePicker();
            this.Time_Now = new System.Windows.Forms.Label();
            this.Done = new System.Windows.Forms.Label();
            this.yesDone = new System.Windows.Forms.RadioButton();
            this.noDone = new System.Windows.Forms.RadioButton();
            this.ReminderTimePicker = new System.Windows.Forms.DateTimePicker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // EventName
            // 
            this.EventName.BackColor = System.Drawing.Color.White;
            this.EventName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.EventName.Location = new System.Drawing.Point(362, 30);
            this.EventName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EventName.Name = "EventName";
            this.EventName.Size = new System.Drawing.Size(212, 32);
            this.EventName.TabIndex = 1;
            this.EventName.Text = "Event\'s Name";
            this.EventName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EventName.UseWaitCursor = true;
            this.EventName.Click += new System.EventHandler(this.textBox1_Click);
            this.EventName.TextChanged += new System.EventHandler(this.EventName_TextChanged);
            // 
            // EventPlace
            // 
            this.EventPlace.BackColor = System.Drawing.Color.White;
            this.EventPlace.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventPlace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.EventPlace.Location = new System.Drawing.Point(360, 81);
            this.EventPlace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EventPlace.Name = "EventPlace";
            this.EventPlace.Size = new System.Drawing.Size(214, 32);
            this.EventPlace.TabIndex = 3;
            this.EventPlace.Text = "Location";
            this.EventPlace.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EventPlace.UseWaitCursor = true;
            this.EventPlace.Click += new System.EventHandler(this.textBox2_Click);
            this.EventPlace.TextChanged += new System.EventHandler(this.EventPlace_TextChanged);
            // 
            // Start_Date
            // 
            this.Start_Date.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Start_Date.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Start_Date.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Start_Date.Location = new System.Drawing.Point(362, 138);
            this.Start_Date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Start_Date.Name = "Start_Date";
            this.Start_Date.Size = new System.Drawing.Size(212, 32);
            this.Start_Date.TabIndex = 5;
            this.Start_Date.Value = new System.DateTime(2017, 12, 3, 0, 0, 0, 0);
            this.Start_Date.ValueChanged += new System.EventHandler(this.Start_Date_ValueChanged);
            // 
            // S_T_Hours
            // 
            this.S_T_Hours.BackColor = System.Drawing.Color.White;
            this.S_T_Hours.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S_T_Hours.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.S_T_Hours.Location = new System.Drawing.Point(362, 191);
            this.S_T_Hours.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(409, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = ":";
            this.label5.UseWaitCursor = true;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // S_T_Minutes
            // 
            this.S_T_Minutes.BackColor = System.Drawing.Color.White;
            this.S_T_Minutes.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S_T_Minutes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.S_T_Minutes.Location = new System.Drawing.Point(436, 191);
            this.S_T_Minutes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.S_T_Minutes.MaxLength = 2;
            this.S_T_Minutes.Name = "S_T_Minutes";
            this.S_T_Minutes.Size = new System.Drawing.Size(35, 32);
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
            this.A_P_M.BackColor = System.Drawing.Color.White;
            this.A_P_M.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A_P_M.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.A_P_M.FormattingEnabled = true;
            this.A_P_M.Items.AddRange(new object[] {
            "am",
            "pm"});
            this.A_P_M.Location = new System.Drawing.Point(484, 191);
            this.A_P_M.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.A_P_M.Name = "A_P_M";
            this.A_P_M.Size = new System.Drawing.Size(90, 32);
            this.A_P_M.TabIndex = 10;
            this.A_P_M.Text = "AM/PM";
            this.A_P_M.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // End_Date
            // 
            this.End_Date.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.End_Date.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.End_Date.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.End_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.End_Date.Location = new System.Drawing.Point(362, 246);
            this.End_Date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.End_Date.Name = "End_Date";
            this.End_Date.Size = new System.Drawing.Size(212, 32);
            this.End_Date.TabIndex = 12;
            this.End_Date.Value = new System.DateTime(2017, 12, 3, 0, 0, 0, 0);
            this.End_Date.ValueChanged += new System.EventHandler(this.End_Date_ValueChanged);
            // 
            // Time_Now
            // 
            this.Time_Now.AutoSize = true;
            this.Time_Now.BackColor = System.Drawing.Color.Transparent;
            this.Time_Now.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Time_Now.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time_Now.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Time_Now.Location = new System.Drawing.Point(479, 412);
            this.Time_Now.Name = "Time_Now";
            this.Time_Now.Size = new System.Drawing.Size(65, 27);
            this.Time_Now.TabIndex = 17;
            this.Time_Now.Text = "Timer";
            this.Time_Now.Click += new System.EventHandler(this.label7_Click);
            // 
            // Done
            // 
            this.Done.AutoSize = true;
            this.Done.BackColor = System.Drawing.Color.Transparent;
            this.Done.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Done.ForeColor = System.Drawing.Color.White;
            this.Done.Location = new System.Drawing.Point(357, 339);
            this.Done.Name = "Done";
            this.Done.Size = new System.Drawing.Size(78, 25);
            this.Done.TabIndex = 19;
            this.Done.Text = "Done ?";
            // 
            // yesDone
            // 
            this.yesDone.AutoSize = true;
            this.yesDone.BackColor = System.Drawing.Color.Transparent;
            this.yesDone.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yesDone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.yesDone.Location = new System.Drawing.Point(451, 339);
            this.yesDone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.noDone.BackColor = System.Drawing.Color.Transparent;
            this.noDone.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noDone.ForeColor = System.Drawing.Color.DarkRed;
            this.noDone.Location = new System.Drawing.Point(525, 339);
            this.noDone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.noDone.Name = "noDone";
            this.noDone.Size = new System.Drawing.Size(49, 25);
            this.noDone.TabIndex = 21;
            this.noDone.TabStop = true;
            this.noDone.Text = "no";
            this.noDone.UseVisualStyleBackColor = false;
            this.noDone.CheckedChanged += new System.EventHandler(this.noDonoe_CheckedChanged);
            // 
            // ReminderTimePicker
            // 
            this.ReminderTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReminderTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ReminderTimePicker.Location = new System.Drawing.Point(362, 304);
            this.ReminderTimePicker.Name = "ReminderTimePicker";
            this.ReminderTimePicker.Size = new System.Drawing.Size(212, 30);
            this.ReminderTimePicker.TabIndex = 24;
            this.ReminderTimePicker.ValueChanged += new System.EventHandler(this.txtremdate_ValueChanged);
            this.ReminderTimePicker.Leave += new System.EventHandler(this.ReminderTimePicker_Leave);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFormToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(45, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newFormToolStripMenuItem
            // 
            this.newFormToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.newFormToolStripMenuItem.Name = "newFormToolStripMenuItem";
            this.newFormToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.newFormToolStripMenuItem.Text = "new Form";
            this.newFormToolStripMenuItem.Click += new System.EventHandler(this.newFormToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMeToolStripMenuItem});
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutMeToolStripMenuItem
            // 
            this.aboutMeToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.aboutMeToolStripMenuItem.Name = "aboutMeToolStripMenuItem";
            this.aboutMeToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.aboutMeToolStripMenuItem.Text = "About Us";
            this.aboutMeToolStripMenuItem.Click += new System.EventHandler(this.aboutMeToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(809, 28);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::Events_Scheduler.Properties.Resources.submit_button;
            this.pictureBox9.Location = new System.Drawing.Point(362, 399);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(58, 43);
            this.pictureBox9.TabIndex = 34;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::Events_Scheduler.Properties.Resources.clear_button;
            this.pictureBox8.Location = new System.Drawing.Point(269, 399);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(55, 40);
            this.pictureBox8.TabIndex = 33;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Ivory;
            this.pictureBox7.Image = global::Events_Scheduler.Properties.Resources.lilgirl;
            this.pictureBox7.Location = new System.Drawing.Point(-87, 27);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(339, 451);
            this.pictureBox7.TabIndex = 32;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::Events_Scheduler.Properties.Resources.reminder;
            this.pictureBox6.Location = new System.Drawing.Point(269, 283);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(47, 47);
            this.pictureBox6.TabIndex = 31;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::Events_Scheduler.Properties.Resources.end_date;
            this.pictureBox5.Location = new System.Drawing.Point(269, 224);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(47, 49);
            this.pictureBox5.TabIndex = 30;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::Events_Scheduler.Properties.Resources.start_time;
            this.pictureBox4.Location = new System.Drawing.Point(269, 171);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(47, 47);
            this.pictureBox4.TabIndex = 29;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Events_Scheduler.Properties.Resources.start_date;
            this.pictureBox3.Location = new System.Drawing.Point(269, 114);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(47, 51);
            this.pictureBox3.TabIndex = 28;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Events_Scheduler.Properties.Resources.tryyyy;
            this.pictureBox2.Location = new System.Drawing.Point(269, 60);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 48);
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Events_Scheduler.Properties.Resources.penn_color;
            this.pictureBox1.Location = new System.Drawing.Point(269, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 42);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // AddingEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(809, 470);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ReminderTimePicker);
            this.Controls.Add(this.noDone);
            this.Controls.Add(this.yesDone);
            this.Controls.Add(this.Done);
            this.Controls.Add(this.Time_Now);
            this.Controls.Add(this.End_Date);
            this.Controls.Add(this.A_P_M);
            this.Controls.Add(this.S_T_Minutes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.S_T_Hours);
            this.Controls.Add(this.Start_Date);
            this.Controls.Add(this.EventPlace);
            this.Controls.Add(this.EventName);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddingEvent";
            this.Text = "Add An Event";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddingEvent_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EventName;
        private System.Windows.Forms.TextBox EventPlace;
        private System.Windows.Forms.DateTimePicker Start_Date;
        private System.Windows.Forms.TextBox S_T_Hours;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox S_T_Minutes;
        private System.Windows.Forms.ComboBox A_P_M;
        private System.Windows.Forms.DateTimePicker End_Date;
        private System.Windows.Forms.Label Time_Now;
        private System.Windows.Forms.RadioButton noDone;
        private System.Windows.Forms.RadioButton yesDone;
        private System.Windows.Forms.Label Done;
        private System.Windows.Forms.DateTimePicker ReminderTimePicker;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMeToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
    }
}

