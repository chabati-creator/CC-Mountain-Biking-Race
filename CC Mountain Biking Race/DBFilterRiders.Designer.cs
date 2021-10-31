
namespace CC_Mountain_Biking_Race
{
    partial class DBFilterRiders
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
            this.lvRiderDetails = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddRider
            // 
            this.btnAddRider.Location = new System.Drawing.Point(757, 362);
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
            this.lblFilterRiders.Location = new System.Drawing.Point(376, 22);
            this.lblFilterRiders.Name = "lblFilterRiders";
            this.lblFilterRiders.Size = new System.Drawing.Size(145, 29);
            this.lblFilterRiders.TabIndex = 30;
            this.lblFilterRiders.Text = "Filter Riders";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(142, 92);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 31;
            // 
            // lvRiderDetails
            // 
            this.lvRiderDetails.BackColor = System.Drawing.Color.SeaShell;
            this.lvRiderDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvRiderDetails.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lvRiderDetails.FullRowSelect = true;
            this.lvRiderDetails.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvRiderDetails.HideSelection = false;
            this.lvRiderDetails.LabelWrap = false;
            this.lvRiderDetails.Location = new System.Drawing.Point(290, 92);
            this.lvRiderDetails.Name = "lvRiderDetails";
            this.lvRiderDetails.Size = new System.Drawing.Size(625, 158);
            this.lvRiderDetails.TabIndex = 32;
            this.lvRiderDetails.UseCompatibleStateImageBehavior = false;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 22);
            this.label4.TabIndex = 33;
            this.label4.Text = "Age:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(142, 134);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 22);
            this.label3.TabIndex = 35;
            this.label3.Text = "School:";
            // 
            // DBFilterRiders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lvRiderDetails);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblFilterRiders);
            this.Controls.Add(this.btnAddRider);
            this.Name = "DBFilterRiders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FilterRiders";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddRider;
        private System.Windows.Forms.Label lblFilterRiders;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListView lvRiderDetails;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
    }
}