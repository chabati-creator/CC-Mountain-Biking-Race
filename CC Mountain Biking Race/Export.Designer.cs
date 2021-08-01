
namespace CC_Mountain_Biking_Race
{
    partial class Export
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.bttnDismiss = new System.Windows.Forms.Button();
            this.lblHeading2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl1.Location = new System.Drawing.Point(121, 35);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(88, 29);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "Export";
            // 
            // bttnDismiss
            // 
            this.bttnDismiss.BackColor = System.Drawing.Color.SandyBrown;
            this.bttnDismiss.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnDismiss.ForeColor = System.Drawing.Color.SeaShell;
            this.bttnDismiss.Location = new System.Drawing.Point(76, 171);
            this.bttnDismiss.Name = "bttnDismiss";
            this.bttnDismiss.Size = new System.Drawing.Size(188, 37);
            this.bttnDismiss.TabIndex = 37;
            this.bttnDismiss.Text = "Dismiss";
            this.bttnDismiss.UseVisualStyleBackColor = false;
            this.bttnDismiss.Click += new System.EventHandler(this.bttnDismiss_Click);
            // 
            // lblHeading2
            // 
            this.lblHeading2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading2.ForeColor = System.Drawing.Color.Peru;
            this.lblHeading2.Location = new System.Drawing.Point(24, 78);
            this.lblHeading2.Name = "lblHeading2";
            this.lblHeading2.Size = new System.Drawing.Size(297, 72);
            this.lblHeading2.TabIndex = 38;
            this.lblHeading2.Text = "All Competitor Results has been successfully exported to the AllCompetitorResults" +
    ".txt";
            this.lblHeading2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Export
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(336, 233);
            this.Controls.Add(this.lblHeading2);
            this.Controls.Add(this.bttnDismiss);
            this.Controls.Add(this.lbl1);
            this.Name = "Export";
            this.Text = "Expoert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button bttnDismiss;
        private System.Windows.Forms.Label lblHeading2;
    }
}