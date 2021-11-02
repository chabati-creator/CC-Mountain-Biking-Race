
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
            this.lvRiderDetails = new System.Windows.Forms.ListView();
            this.cbxSchool = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbRiderSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFilterRiders = new System.Windows.Forms.Button();
            this.cbxAge = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nudAge = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddRider
            // 
            this.btnAddRider.Location = new System.Drawing.Point(963, 285);
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
            this.lblFilterRiders.Location = new System.Drawing.Point(460, 24);
            this.lblFilterRiders.Name = "lblFilterRiders";
            this.lblFilterRiders.Size = new System.Drawing.Size(145, 29);
            this.lblFilterRiders.TabIndex = 30;
            this.lblFilterRiders.Text = "Filter Riders";
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
            this.lvRiderDetails.Location = new System.Drawing.Point(344, 80);
            this.lvRiderDetails.Name = "lvRiderDetails";
            this.lvRiderDetails.Size = new System.Drawing.Size(777, 158);
            this.lvRiderDetails.TabIndex = 32;
            this.lvRiderDetails.UseCompatibleStateImageBehavior = false;
            // 
            // cbxSchool
            // 
            this.cbxSchool.BackColor = System.Drawing.Color.SeaShell;
            this.cbxSchool.FormattingEnabled = true;
            this.cbxSchool.Location = new System.Drawing.Point(126, 171);
            this.cbxSchool.Name = "cbxSchool";
            this.cbxSchool.Size = new System.Drawing.Size(121, 24);
            this.cbxSchool.TabIndex = 34;
            this.cbxSchool.Text = "Select Option";
            this.cbxSchool.SelectedIndexChanged += new System.EventHandler(this.cbxSchool_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 22);
            this.label3.TabIndex = 35;
            this.label3.Text = "School:";
            // 
            // txbRiderSearch
            // 
            this.txbRiderSearch.BackColor = System.Drawing.Color.SeaShell;
            this.txbRiderSearch.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txbRiderSearch.Location = new System.Drawing.Point(126, 92);
            this.txbRiderSearch.Name = "txbRiderSearch";
            this.txbRiderSearch.Size = new System.Drawing.Size(121, 22);
            this.txbRiderSearch.TabIndex = 36;
            this.txbRiderSearch.TextChanged += new System.EventHandler(this.FilterTxt_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 22);
            this.label1.TabIndex = 37;
            this.label1.Text = "Name:";
            // 
            // btnFilterRiders
            // 
            this.btnFilterRiders.Location = new System.Drawing.Point(89, 220);
            this.btnFilterRiders.Name = "btnFilterRiders";
            this.btnFilterRiders.Size = new System.Drawing.Size(158, 31);
            this.btnFilterRiders.TabIndex = 39;
            this.btnFilterRiders.Text = "Filter Riders";
            this.btnFilterRiders.UseVisualStyleBackColor = true;
            this.btnFilterRiders.Click += new System.EventHandler(this.btnFilterRiders_Click);
            // 
            // cbxAge
            // 
            this.cbxAge.BackColor = System.Drawing.Color.SeaShell;
            this.cbxAge.FormattingEnabled = true;
            this.cbxAge.Location = new System.Drawing.Point(126, 132);
            this.cbxAge.Name = "cbxAge";
            this.cbxAge.Size = new System.Drawing.Size(121, 24);
            this.cbxAge.TabIndex = 31;
            this.cbxAge.Text = "Select Option";
            this.cbxAge.SelectedIndexChanged += new System.EventHandler(this.cbxAge_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 22);
            this.label4.TabIndex = 33;
            this.label4.Text = "Age:";
            // 
            // nudAge
            // 
            this.nudAge.BackColor = System.Drawing.Color.SeaShell;
            this.nudAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAge.ForeColor = System.Drawing.Color.SaddleBrown;
            this.nudAge.Location = new System.Drawing.Point(257, 132);
            this.nudAge.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudAge.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudAge.Name = "nudAge";
            this.nudAge.Size = new System.Drawing.Size(81, 27);
            this.nudAge.TabIndex = 38;
            this.nudAge.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // DBFilterRiders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 351);
            this.Controls.Add(this.btnFilterRiders);
            this.Controls.Add(this.nudAge);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbRiderSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxSchool);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lvRiderDetails);
            this.Controls.Add(this.cbxAge);
            this.Controls.Add(this.lblFilterRiders);
            this.Controls.Add(this.btnAddRider);
            this.Name = "DBFilterRiders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FilterRiders";
            this.Load += new System.EventHandler(this.DBFilterRiders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddRider;
        private System.Windows.Forms.Label lblFilterRiders;
        private System.Windows.Forms.ListView lvRiderDetails;
        private System.Windows.Forms.ComboBox cbxSchool;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbRiderSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFilterRiders;
        private System.Windows.Forms.ComboBox cbxAge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudAge;
    }
}