
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Export));
            this.lbl1 = new System.Windows.Forms.Label();
            this.bttnDismiss = new System.Windows.Forms.Button();
            this.lblHeading2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.BackColor = System.Drawing.Color.SandyBrown;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl1.Location = new System.Drawing.Point(153, 49);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(122, 36);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "Export";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bttnDismiss
            // 
            this.bttnDismiss.BackColor = System.Drawing.Color.SandyBrown;
            this.bttnDismiss.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnDismiss.ForeColor = System.Drawing.Color.SeaShell;
            this.bttnDismiss.Location = new System.Drawing.Point(117, 208);
            this.bttnDismiss.Name = "bttnDismiss";
            this.bttnDismiss.Size = new System.Drawing.Size(188, 37);
            this.bttnDismiss.TabIndex = 37;
            this.bttnDismiss.Text = "Dismiss";
            this.bttnDismiss.UseVisualStyleBackColor = false;
            this.bttnDismiss.Click += new System.EventHandler(this.bttnDismiss_Click);
            // 
            // lblHeading2
            // 
            this.lblHeading2.BackColor = System.Drawing.Color.SeaShell;
            this.lblHeading2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblHeading2.Location = new System.Drawing.Point(64, 101);
            this.lblHeading2.Name = "lblHeading2";
            this.lblHeading2.Size = new System.Drawing.Size(297, 86);
            this.lblHeading2.TabIndex = 38;
            this.lblHeading2.Text = "All Competitor Results has been successfully exported to the AllCompetitorResults" +
    ".txt";
            this.lblHeading2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel3.Location = new System.Drawing.Point(57, 96);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(312, 95);
            this.panel3.TabIndex = 39;
            // 
            // Export
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(426, 280);
            this.Controls.Add(this.lblHeading2);
            this.Controls.Add(this.bttnDismiss);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Export";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Export";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button bttnDismiss;
        private System.Windows.Forms.Label lblHeading2;
        private System.Windows.Forms.Panel panel3;
    }
}