namespace IxosTest2
{
    partial class frmPleaseWait
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
            this.pgbPercentDone = new System.Windows.Forms.ProgressBar();
            this.lblPleaseWait = new System.Windows.Forms.Label();
            this.lblOperation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pgbPercentDone
            // 
            this.pgbPercentDone.Location = new System.Drawing.Point(12, 196);
            this.pgbPercentDone.MarqueeAnimationSpeed = 30;
            this.pgbPercentDone.Name = "pgbPercentDone";
            this.pgbPercentDone.Size = new System.Drawing.Size(382, 24);
            this.pgbPercentDone.TabIndex = 0;
            // 
            // lblPleaseWait
            // 
            this.lblPleaseWait.AutoSize = true;
            this.lblPleaseWait.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPleaseWait.Location = new System.Drawing.Point(77, 41);
            this.lblPleaseWait.Name = "lblPleaseWait";
            this.lblPleaseWait.Size = new System.Drawing.Size(247, 42);
            this.lblPleaseWait.TabIndex = 1;
            this.lblPleaseWait.Text = "Please Wait...";
            // 
            // lblOperation
            // 
            this.lblOperation.AutoSize = true;
            this.lblOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperation.Location = new System.Drawing.Point(21, 116);
            this.lblOperation.Name = "lblOperation";
            this.lblOperation.Size = new System.Drawing.Size(374, 42);
            this.lblOperation.TabIndex = 2;
            this.lblOperation.Text = "DOING SOMETHING";
            // 
            // frmPleaseWait
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 252);
            this.Controls.Add(this.lblOperation);
            this.Controls.Add(this.lblPleaseWait);
            this.Controls.Add(this.pgbPercentDone);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPleaseWait";
            this.Text = "Please Wait";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pgbPercentDone;
        private System.Windows.Forms.Label lblPleaseWait;
        private System.Windows.Forms.Label lblOperation;
    }
}