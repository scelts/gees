namespace LandingRateMonitor
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
            this.LandingRateLabel = new System.Windows.Forms.Label();
            this.timerClose = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // LandingRateLabel
            // 
            this.LandingRateLabel.BackColor = System.Drawing.Color.White;
            this.LandingRateLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LandingRateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LandingRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LandingRateLabel.Location = new System.Drawing.Point(0, 0);
            this.LandingRateLabel.Name = "LandingRateLabel";
            this.LandingRateLabel.Size = new System.Drawing.Size(228, 97);
            this.LandingRateLabel.TabIndex = 0;
            this.LandingRateLabel.Text = "label1";
            this.LandingRateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerClose
            // 
            this.timerClose.Interval = 5000;
            this.timerClose.Tick += new System.EventHandler(this.timerClose_Tick);
            // 
            // LRMDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(228, 97);
            this.ControlBox = false;
            this.Controls.Add(this.LandingRateLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 50);
            this.Name = "LRMDisplay";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "LRMDisplay";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.LRMDisplay_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LandingRateLabel;
        private System.Windows.Forms.Timer timerClose;
    }
}