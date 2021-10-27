
namespace CC_Mountain_Biking_Race
{
    partial class FilterRiders
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
            this.btnAddRider = new System.Windows.Forms.Button();
            this.lblFilterRiders = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnAddRider
            // 
            this.btnAddRider.Location = new System.Drawing.Point(600, 356);
            this.btnAddRider.Name = "btnAddRider";
            this.btnAddRider.Size = new System.Drawing.Size(158, 31);
            this.btnAddRider.TabIndex = 29;
            this.btnAddRider.Text = "Add Rider";
            this.btnAddRider.UseVisualStyleBackColor = true;
            this.btnAddRider.Click += new System.EventHandler(this.btnAddRider_Click);
            // 
            // lblFilterRiders
            // 
            this.lblFilterRiders.AutoSize = true;
            this.lblFilterRiders.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterRiders.Location = new System.Drawing.Point(339, 19);
            this.lblFilterRiders.Name = "lblFilterRiders";
            this.lblFilterRiders.Size = new System.Drawing.Size(145, 29);
            this.lblFilterRiders.TabIndex = 30;
            this.lblFilterRiders.Text = "Filter Riders";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(147, 127);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 31;
            // 
            // FilterRiders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblFilterRiders);
            this.Controls.Add(this.btnAddRider);
            this.Name = "FilterRiders";
            this.Text = "FilterRiders";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddRider;
        private System.Windows.Forms.Label lblFilterRiders;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}