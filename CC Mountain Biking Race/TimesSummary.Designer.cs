
namespace CC_Mountain_Biking_Race
{
    partial class TimesSummary
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.bttnDismiss = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblHeading.Location = new System.Drawing.Point(173, 26);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(330, 29);
            this.lblHeading.TabIndex = 4;
            this.lblHeading.Text = "Start / End Times Summary";
            // 
            // bttnDismiss
            // 
            this.bttnDismiss.BackColor = System.Drawing.Color.SandyBrown;
            this.bttnDismiss.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnDismiss.ForeColor = System.Drawing.Color.SeaShell;
            this.bttnDismiss.Location = new System.Drawing.Point(247, 159);
            this.bttnDismiss.Name = "bttnDismiss";
            this.bttnDismiss.Size = new System.Drawing.Size(183, 37);
            this.bttnDismiss.TabIndex = 16;
            this.bttnDismiss.Text = "Dismiss";
            this.bttnDismiss.UseVisualStyleBackColor = false;
            this.bttnDismiss.Click += new System.EventHandler(this.bttnDismiss_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.richTextBox1.Location = new System.Drawing.Point(76, 73);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(531, 64);
            this.richTextBox1.TabIndex = 36;
            this.richTextBox1.Text = "";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel3.Location = new System.Drawing.Point(70, 66);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(546, 80);
            this.panel3.TabIndex = 37;
            // 
            // TimesSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(675, 207);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.bttnDismiss);
            this.Controls.Add(this.lblHeading);
            this.Name = "TimesSummary";
            this.Text = "TimesSummary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button bttnDismiss;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel3;
    }
}