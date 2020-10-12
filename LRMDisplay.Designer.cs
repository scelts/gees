namespace Gees
{
    partial class LRMDisplay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LRMDisplay));
            this.timerClose = new System.Windows.Forms.Timer(this.components);
            this.iconPictureFPM = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureGees = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureAirSpeed = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureWind = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelANG = new System.Windows.Forms.Label();
            this.labelWIND = new System.Windows.Forms.Label();
            this.labelAIRV = new System.Windows.Forms.Label();
            this.labelGEES = new System.Windows.Forms.Label();
            this.labelFPM = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureFPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureGees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureAirSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureWind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timerClose
            // 
            this.timerClose.Interval = 10000;
            this.timerClose.Tick += new System.EventHandler(this.timerClose_Tick);
            // 
            // iconPictureFPM
            // 
            this.iconPictureFPM.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.iconPictureFPM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.iconPictureFPM.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureFPM.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPictureFPM.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureFPM.Location = new System.Drawing.Point(25, 6);
            this.iconPictureFPM.Name = "iconPictureFPM";
            this.iconPictureFPM.Size = new System.Drawing.Size(32, 32);
            this.iconPictureFPM.TabIndex = 1;
            this.iconPictureFPM.TabStop = false;
            // 
            // iconPictureGees
            // 
            this.iconPictureGees.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.iconPictureGees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.iconPictureGees.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureGees.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPictureGees.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureGees.Location = new System.Drawing.Point(25, 50);
            this.iconPictureGees.Name = "iconPictureGees";
            this.iconPictureGees.Size = new System.Drawing.Size(32, 32);
            this.iconPictureGees.TabIndex = 2;
            this.iconPictureGees.TabStop = false;
            // 
            // iconPictureAirSpeed
            // 
            this.iconPictureAirSpeed.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.iconPictureAirSpeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.iconPictureAirSpeed.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureAirSpeed.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPictureAirSpeed.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureAirSpeed.Location = new System.Drawing.Point(25, 94);
            this.iconPictureAirSpeed.Name = "iconPictureAirSpeed";
            this.iconPictureAirSpeed.Size = new System.Drawing.Size(32, 32);
            this.iconPictureAirSpeed.TabIndex = 3;
            this.iconPictureAirSpeed.TabStop = false;
            // 
            // iconPictureWind
            // 
            this.iconPictureWind.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.iconPictureWind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.iconPictureWind.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("iconPictureWind.BackgroundImage")));
            this.iconPictureWind.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureWind.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPictureWind.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureWind.Location = new System.Drawing.Point(25, 138);
            this.iconPictureWind.Name = "iconPictureWind";
            this.iconPictureWind.Rotation = 45D;
            this.iconPictureWind.Size = new System.Drawing.Size(32, 32);
            this.iconPictureWind.TabIndex = 4;
            this.iconPictureWind.TabStop = false;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.iconPictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("iconPictureBox1.BackgroundImage")));
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.Location = new System.Drawing.Point(25, 182);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox1.TabIndex = 5;
            this.iconPictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.labelANG, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelWIND, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelAIRV, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelGEES, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.iconPictureFPM, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.iconPictureBox1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.iconPictureGees, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.iconPictureWind, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.iconPictureAirSpeed, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelFPM, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(343, 220);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // labelANG
            // 
            this.labelANG.AutoSize = true;
            this.labelANG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelANG.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelANG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.labelANG.Location = new System.Drawing.Point(63, 176);
            this.labelANG.Name = "labelANG";
            this.labelANG.Size = new System.Drawing.Size(277, 44);
            this.labelANG.TabIndex = 11;
            this.labelANG.Text = "1.53º left";
            this.labelANG.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelWIND
            // 
            this.labelWIND.AutoSize = true;
            this.labelWIND.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelWIND.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWIND.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.labelWIND.Location = new System.Drawing.Point(63, 132);
            this.labelWIND.Name = "labelWIND";
            this.labelWIND.Size = new System.Drawing.Size(277, 44);
            this.labelWIND.TabIndex = 10;
            this.labelWIND.Text = "8 kt";
            this.labelWIND.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelAIRV
            // 
            this.labelAIRV.AutoSize = true;
            this.labelAIRV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAIRV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAIRV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.labelAIRV.Location = new System.Drawing.Point(63, 88);
            this.labelAIRV.Name = "labelAIRV";
            this.labelAIRV.Size = new System.Drawing.Size(277, 44);
            this.labelAIRV.TabIndex = 9;
            this.labelAIRV.Text = "65 kt air; 63 kt ground";
            this.labelAIRV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelGEES
            // 
            this.labelGEES.AutoSize = true;
            this.labelGEES.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelGEES.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGEES.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.labelGEES.Location = new System.Drawing.Point(63, 44);
            this.labelGEES.Name = "labelGEES";
            this.labelGEES.Size = new System.Drawing.Size(277, 44);
            this.labelGEES.TabIndex = 8;
            this.labelGEES.Text = "1.22 G";
            this.labelGEES.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelFPM
            // 
            this.labelFPM.AutoSize = true;
            this.labelFPM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelFPM.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFPM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.labelFPM.Location = new System.Drawing.Point(63, 0);
            this.labelFPM.Name = "labelFPM";
            this.labelFPM.Size = new System.Drawing.Size(277, 44);
            this.labelFPM.TabIndex = 7;
            this.labelFPM.Text = "-125 fpm";
            this.labelFPM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(383, 220);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(343, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 220);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LRMDisplay
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(383, 220);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 50);
            this.Name = "LRMDisplay";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "LRMDisplay";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.LRMDisplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureFPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureGees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureAirSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureWind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerClose;
        private FontAwesome.Sharp.IconPictureBox iconPictureFPM;
        private FontAwesome.Sharp.IconPictureBox iconPictureGees;
        private FontAwesome.Sharp.IconPictureBox iconPictureAirSpeed;
        private FontAwesome.Sharp.IconPictureBox iconPictureWind;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelFPM;
        private System.Windows.Forms.Label labelGEES;
        private System.Windows.Forms.Label labelAIRV;
        private System.Windows.Forms.Label labelANG;
        private System.Windows.Forms.Label labelWIND;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}