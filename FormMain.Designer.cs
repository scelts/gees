namespace LandingRateMonitor
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
            this.iconDown = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconGithub = new FontAwesome.Sharp.IconPictureBox();
            this.iconReddit = new FontAwesome.Sharp.IconPictureBox();
            this.iconFAS = new FontAwesome.Sharp.IconPictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.iconConnStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconDown)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconGithub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconReddit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconFAS)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
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
            this.iconConnStatus.BackgroundImage = global::LandingRateMonitor.Properties.Resources.disconnected;
            this.iconConnStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.iconConnStatus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconConnStatus.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconConnStatus.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconConnStatus.Location = new System.Drawing.Point(3, 13);
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
            this.label3.Location = new System.Drawing.Point(3, 13);
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
            this.labelConn.Location = new System.Drawing.Point(43, 19);
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
            this.linkLabelUpdate.Location = new System.Drawing.Point(117, 12);
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
            this.button2.Location = new System.Drawing.Point(267, 11);
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
            this.label1.Location = new System.Drawing.Point(43, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Find me in the system tray";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // iconDown
            // 
            this.iconDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.iconDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.iconDown.Cursor = System.Windows.Forms.Cursors.Default;
            this.iconDown.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconDown.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconDown.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconDown.Location = new System.Drawing.Point(3, 13);
            this.iconDown.Name = "iconDown";
            this.iconDown.Size = new System.Drawing.Size(32, 32);
            this.iconDown.TabIndex = 17;
            this.iconDown.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.iconGithub);
            this.panel1.Controls.Add(this.linkLabelUpdate);
            this.panel1.Controls.Add(this.iconReddit);
            this.panel1.Controls.Add(this.iconFAS);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(8, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 34);
            this.panel1.TabIndex = 7;
            // 
            // iconGithub
            // 
            this.iconGithub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.iconGithub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconGithub.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconGithub.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconGithub.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconGithub.Location = new System.Drawing.Point(3, 3);
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
            this.iconReddit.Location = new System.Drawing.Point(41, 3);
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
            this.iconFAS.Location = new System.Drawing.Point(79, 3);
            this.iconFAS.Name = "iconFAS";
            this.iconFAS.Size = new System.Drawing.Size(32, 32);
            this.iconFAS.TabIndex = 13;
            this.iconFAS.TabStop = false;
            this.iconFAS.Click += new System.EventHandler(this.iconFAS_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.label4.Location = new System.Drawing.Point(8, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(323, 46);
            this.label4.TabIndex = 6;
            this.label4.Text = "In game landing analysis for Microsoft Flight Simulator 2020";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(362, 307);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel3.Controls.Add(this.iconDown, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(8, 240);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(346, 59);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.labelConn, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.iconConnStatus, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(8, 176);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(346, 58);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.88439F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.11561F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel4.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.button2, 2, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(8, 8);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(346, 58);
            this.tableLayoutPanel4.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.button1.Location = new System.Drawing.Point(166, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 36);
            this.button1.TabIndex = 10;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(362, 307);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.ShowInTaskbar = false;
            this.Text = "MSFS 2020 Landing Rate Monitor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.iconConnStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconDown)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconGithub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconReddit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconFAS)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
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
        private FontAwesome.Sharp.IconPictureBox iconDown;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconGithub;
        private FontAwesome.Sharp.IconPictureBox iconReddit;
        private FontAwesome.Sharp.IconPictureBox iconFAS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button button1;
    }
}

