namespace Gees
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.timerRead = new System.Windows.Forms.Timer(this.components);
            this.timerWait = new System.Windows.Forms.Timer(this.components);
            this.timerConnection = new System.Windows.Forms.Timer(this.components);
            this.backgroundConnector = new System.ComponentModel.BackgroundWorker();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.backgroundWorkerUpdate = new System.ComponentModel.BackgroundWorker();
            this.iconConnStatus = new FontAwesome.Sharp.IconPictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelConn = new System.Windows.Forms.Label();
            this.linkLabelUpdate = new System.Windows.Forms.LinkLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.iconGithub = new FontAwesome.Sharp.IconPictureBox();
            this.iconReddit = new FontAwesome.Sharp.IconPictureBox();
            this.iconFAS = new FontAwesome.Sharp.IconPictureBox();
            this.labelAbout = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonLandings = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.iconConnStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconGithub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconReddit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconFAS)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // timerRead
            // 
            this.timerRead.Interval = 10;
            this.timerRead.Tick += new System.EventHandler(this.timerRead_Tick);
            // 
            // timerWait
            // 
            this.timerWait.Interval = 2000;
            this.timerWait.Tick += new System.EventHandler(this.timerWait_Tick);
            // 
            // timerConnection
            // 
            this.timerConnection.Enabled = true;
            this.timerConnection.Tick += new System.EventHandler(this.timerConnection_Tick);
            // 
            // backgroundConnector
            // 
            this.backgroundConnector.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundConnector_DoWork);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Landing Rate Monitor";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            // 
            // backgroundWorkerUpdate
            // 
            this.backgroundWorkerUpdate.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerUpdate_DoWork);
            this.backgroundWorkerUpdate.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerUpdate_RunWorkerCompleted);
            // 
            // iconConnStatus
            // 
            this.iconConnStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.iconConnStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.iconConnStatus.BackgroundImage = global::Gees.Properties.Resources.disconnected;
            this.iconConnStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.iconConnStatus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconConnStatus.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconConnStatus.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconConnStatus.Location = new System.Drawing.Point(3, 3);
            this.iconConnStatus.Name = "iconConnStatus";
            this.iconConnStatus.Size = new System.Drawing.Size(32, 32);
            this.iconConnStatus.TabIndex = 14;
            this.iconConnStatus.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.label3.Location = new System.Drawing.Point(3, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Gees";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelConn
            // 
            this.labelConn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelConn.AutoSize = true;
            this.labelConn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.labelConn.Location = new System.Drawing.Point(41, 9);
            this.labelConn.Name = "labelConn";
            this.labelConn.Size = new System.Drawing.Size(181, 20);
            this.labelConn.TabIndex = 15;
            this.labelConn.Text = "No Running Sim Detected";
            this.labelConn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // linkLabelUpdate
            // 
            this.linkLabelUpdate.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.linkLabelUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelUpdate.AutoSize = true;
            this.linkLabelUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelUpdate.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.linkLabelUpdate.Location = new System.Drawing.Point(91, 0);
            this.linkLabelUpdate.Name = "linkLabelUpdate";
            this.linkLabelUpdate.Size = new System.Drawing.Size(130, 20);
            this.linkLabelUpdate.TabIndex = 8;
            this.linkLabelUpdate.TabStop = true;
            this.linkLabelUpdate.Text = "Updates Available";
            this.linkLabelUpdate.Visible = false;
            this.linkLabelUpdate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelUpdate_LinkClicked);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.button2.Location = new System.Drawing.Point(307, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 36);
            this.button2.TabIndex = 9;
            this.button2.Text = "Quit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Find me in the system tray";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.labelVersion.Location = new System.Drawing.Point(3, 0);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(82, 19);
            this.labelVersion.TabIndex = 14;
            this.labelVersion.Text = "labelVersion";
            // 
            // iconGithub
            // 
            this.iconGithub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.iconGithub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconGithub.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconGithub.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconGithub.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconGithub.Location = new System.Drawing.Point(89, 3);
            this.iconGithub.Name = "iconGithub";
            this.iconGithub.Size = new System.Drawing.Size(32, 32);
            this.iconGithub.TabIndex = 11;
            this.iconGithub.TabStop = false;
            this.iconGithub.Click += new System.EventHandler(this.iconGithub_Click);
            // 
            // iconReddit
            // 
            this.iconReddit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.iconReddit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconReddit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconReddit.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconReddit.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconReddit.Location = new System.Drawing.Point(127, 3);
            this.iconReddit.Name = "iconReddit";
            this.iconReddit.Size = new System.Drawing.Size(32, 32);
            this.iconReddit.TabIndex = 12;
            this.iconReddit.TabStop = false;
            this.iconReddit.Click += new System.EventHandler(this.iconReddit_LinkClicked);
            // 
            // iconFAS
            // 
            this.iconFAS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.iconFAS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconFAS.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconFAS.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconFAS.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconFAS.Location = new System.Drawing.Point(165, 3);
            this.iconFAS.Name = "iconFAS";
            this.iconFAS.Size = new System.Drawing.Size(32, 34);
            this.iconFAS.TabIndex = 13;
            this.iconFAS.TabStop = false;
            this.iconFAS.Click += new System.EventHandler(this.iconFAS_Click);
            // 
            // labelAbout
            // 
            this.labelAbout.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelAbout.AutoSize = true;
            this.labelAbout.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.labelAbout.Location = new System.Drawing.Point(8, 87);
            this.labelAbout.Name = "labelAbout";
            this.labelAbout.Size = new System.Drawing.Size(375, 46);
            this.labelAbout.TabIndex = 6;
            this.labelAbout.Text = "In game landing analysis for Microsoft Flight Simulator 2020";
            this.labelAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelAbout, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel4, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel5, 0, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(402, 330);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.88439F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.11561F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel4.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.button2, 2, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(8, 8);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(386, 76);
            this.tableLayoutPanel4.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.button1.Location = new System.Drawing.Point(271, 3);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(76, 36);
            this.button1.TabIndex = 10;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonLandings
            // 
            this.buttonLandings.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonLandings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.buttonLandings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLandings.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLandings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.buttonLandings.Location = new System.Drawing.Point(3, 3);
            this.buttonLandings.Name = "buttonLandings";
            this.buttonLandings.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonLandings.Size = new System.Drawing.Size(80, 36);
            this.buttonLandings.TabIndex = 11;
            this.buttonLandings.Text = "Landings";
            this.buttonLandings.UseVisualStyleBackColor = false;
            this.buttonLandings.Click += new System.EventHandler(this.buttonLandings_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.buttonLandings);
            this.flowLayoutPanel1.Controls.Add(this.iconGithub);
            this.flowLayoutPanel1.Controls.Add(this.iconReddit);
            this.flowLayoutPanel1.Controls.Add(this.iconFAS);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(8, 166);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(386, 40);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.checkBox1);
            this.flowLayoutPanel2.Controls.Add(this.numericUpDown1);
            this.flowLayoutPanel2.Controls.Add(this.button1);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(8, 212);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(386, 40);
            this.flowLayoutPanel2.TabIndex = 15;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.labelVersion);
            this.flowLayoutPanel3.Controls.Add(this.linkLabelUpdate);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(8, 136);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(386, 24);
            this.flowLayoutPanel3.TabIndex = 16;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.iconConnStatus);
            this.flowLayoutPanel4.Controls.Add(this.labelConn);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(8, 258);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(386, 34);
            this.flowLayoutPanel4.TabIndex = 17;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.label1);
            this.flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(8, 298);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(386, 24);
            this.flowLayoutPanel5.TabIndex = 18;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = global::Gees.Properties.Settings.Default.AutoClose;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Gees.Properties.Settings.Default, "AutoClose", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.checkBox1.Location = new System.Drawing.Point(3, 9);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBox1.Size = new System.Drawing.Size(200, 24);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Auto close after seconds: ";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numericUpDown1.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::Gees.Properties.Settings.Default, "CloseAfter", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numericUpDown1.Location = new System.Drawing.Point(209, 7);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(56, 27);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = global::Gees.Properties.Settings.Default.CloseAfter;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(402, 330);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.ShowInTaskbar = false;
            this.Text = "MSFS 2020 Landing Rate Monitor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.iconConnStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconGithub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconReddit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconFAS)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerRead;
        private System.Windows.Forms.Timer timerWait;
        private System.Windows.Forms.Timer timerConnection;
        private System.ComponentModel.BackgroundWorker backgroundConnector;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.ComponentModel.BackgroundWorker backgroundWorkerUpdate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconPictureBox iconConnStatus;
        private System.Windows.Forms.Label labelConn;
        private System.Windows.Forms.LinkLabel linkLabelUpdate;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconGithub;
        private FontAwesome.Sharp.IconPictureBox iconReddit;
        private FontAwesome.Sharp.IconPictureBox iconFAS;
        private System.Windows.Forms.Label labelAbout;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Button buttonLandings;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
    }
}

