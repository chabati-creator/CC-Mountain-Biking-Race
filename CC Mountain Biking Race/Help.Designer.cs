
namespace CC_Mountain_Biking_Race
{
    partial class Help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Help));
            this.lblHeading2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bttnDismiss = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeading2
            // 
            this.lblHeading2.BackColor = System.Drawing.Color.Chocolate;
            this.lblHeading2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading2.ForeColor = System.Drawing.Color.SeaShell;
            this.lblHeading2.Location = new System.Drawing.Point(87, 99);
            this.lblHeading2.Name = "lblHeading2";
            this.lblHeading2.Size = new System.Drawing.Size(468, 113);
            this.lblHeading2.TabIndex = 36;
            this.lblHeading2.Text = resources.GetString("lblHeading2.Text");
            this.lblHeading2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Chocolate;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaShell;
            this.label1.Location = new System.Drawing.Point(45, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(544, 38);
            this.label1.TabIndex = 37;
            this.label1.Text = "Welcome to the Cross Country Mountain Biking Race program";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bttnDismiss
            // 
            this.bttnDismiss.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnDismiss.ForeColor = System.Drawing.Color.SaddleBrown;
            this.bttnDismiss.Location = new System.Drawing.Point(222, 226);
            this.bttnDismiss.Name = "bttnDismiss";
            this.bttnDismiss.Size = new System.Drawing.Size(200, 32);
            this.bttnDismiss.TabIndex = 38;
            this.bttnDismiss.Text = "Dismiss";
            this.bttnDismiss.UseVisualStyleBackColor = true;
            this.bttnDismiss.Click += new System.EventHandler(this.bttnDismiss_Click);
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(648, 278);
            this.Controls.Add(this.bttnDismiss);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHeading2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Help";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Help";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHeading2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttnDismiss;
    }
}