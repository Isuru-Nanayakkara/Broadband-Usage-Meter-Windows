namespace Broadband_Usage_Meter
{
    partial class frmMeters
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
            this.lblPeakTitle = new System.Windows.Forms.Label();
            this.lblPeakPercentage = new System.Windows.Forms.Label();
            this.lblPeakRemainingData = new System.Windows.Forms.Label();
            this.lblTotalRemainingData = new System.Windows.Forms.Label();
            this.lblTotalPercentage = new System.Windows.Forms.Label();
            this.lblTotalTitle = new System.Windows.Forms.Label();
            this.pgbTotal = new Broadband_Usage_Meter.BIProgressBar();
            this.pgbPeak = new Broadband_Usage_Meter.BIProgressBar();
            this.SuspendLayout();
            // 
            // lblPeakTitle
            // 
            this.lblPeakTitle.AutoSize = true;
            this.lblPeakTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeakTitle.Location = new System.Drawing.Point(12, 28);
            this.lblPeakTitle.Name = "lblPeakTitle";
            this.lblPeakTitle.Size = new System.Drawing.Size(40, 16);
            this.lblPeakTitle.TabIndex = 0;
            this.lblPeakTitle.Text = "Peak";
            // 
            // lblPeakPercentage
            // 
            this.lblPeakPercentage.AutoSize = true;
            this.lblPeakPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeakPercentage.Location = new System.Drawing.Point(271, 28);
            this.lblPeakPercentage.Name = "lblPeakPercentage";
            this.lblPeakPercentage.Size = new System.Drawing.Size(41, 16);
            this.lblPeakPercentage.TabIndex = 2;
            this.lblPeakPercentage.Text = "100%";
            // 
            // lblPeakRemainingData
            // 
            this.lblPeakRemainingData.AutoSize = true;
            this.lblPeakRemainingData.Location = new System.Drawing.Point(201, 8);
            this.lblPeakRemainingData.Name = "lblPeakRemainingData";
            this.lblPeakRemainingData.Size = new System.Drawing.Size(64, 13);
            this.lblPeakRemainingData.TabIndex = 3;
            this.lblPeakRemainingData.Text = "100 GB Left";
            this.lblPeakRemainingData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalRemainingData
            // 
            this.lblTotalRemainingData.AutoSize = true;
            this.lblTotalRemainingData.Location = new System.Drawing.Point(201, 62);
            this.lblTotalRemainingData.Name = "lblTotalRemainingData";
            this.lblTotalRemainingData.Size = new System.Drawing.Size(64, 13);
            this.lblTotalRemainingData.TabIndex = 7;
            this.lblTotalRemainingData.Text = "100 GB Left";
            this.lblTotalRemainingData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalPercentage
            // 
            this.lblTotalPercentage.AutoSize = true;
            this.lblTotalPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPercentage.Location = new System.Drawing.Point(271, 82);
            this.lblTotalPercentage.Name = "lblTotalPercentage";
            this.lblTotalPercentage.Size = new System.Drawing.Size(41, 16);
            this.lblTotalPercentage.TabIndex = 6;
            this.lblTotalPercentage.Text = "100%";
            // 
            // lblTotalTitle
            // 
            this.lblTotalTitle.AutoSize = true;
            this.lblTotalTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTitle.Location = new System.Drawing.Point(12, 82);
            this.lblTotalTitle.Name = "lblTotalTitle";
            this.lblTotalTitle.Size = new System.Drawing.Size(39, 16);
            this.lblTotalTitle.TabIndex = 4;
            this.lblTotalTitle.Text = "Total";
            // 
            // pgbTotal
            // 
            this.pgbTotal.Location = new System.Drawing.Point(58, 78);
            this.pgbTotal.Name = "pgbTotal";
            this.pgbTotal.Size = new System.Drawing.Size(207, 23);
            this.pgbTotal.TabIndex = 9;
            // 
            // pgbPeak
            // 
            this.pgbPeak.Location = new System.Drawing.Point(58, 24);
            this.pgbPeak.Name = "pgbPeak";
            this.pgbPeak.Size = new System.Drawing.Size(207, 23);
            this.pgbPeak.TabIndex = 8;
            // 
            // frmMeters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 113);
            this.ControlBox = false;
            this.Controls.Add(this.pgbTotal);
            this.Controls.Add(this.pgbPeak);
            this.Controls.Add(this.lblTotalRemainingData);
            this.Controls.Add(this.lblTotalPercentage);
            this.Controls.Add(this.lblTotalTitle);
            this.Controls.Add(this.lblPeakRemainingData);
            this.Controls.Add(this.lblPeakPercentage);
            this.Controls.Add(this.lblPeakTitle);
            this.MaximizeBox = false;
            this.Name = "frmMeters";
            this.Load += new System.EventHandler(this.frmMeters_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPeakTitle;
        private System.Windows.Forms.Label lblPeakPercentage;
        private System.Windows.Forms.Label lblPeakRemainingData;
        private System.Windows.Forms.Label lblTotalRemainingData;
        private System.Windows.Forms.Label lblTotalPercentage;
        private System.Windows.Forms.Label lblTotalTitle;
        private BIProgressBar pgbPeak;
        private BIProgressBar pgbTotal;
    }
}

