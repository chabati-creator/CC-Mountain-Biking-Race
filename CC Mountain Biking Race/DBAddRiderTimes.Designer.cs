
namespace CC_Mountain_Biking_Race
{
    partial class DBAddRiderTimes
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
            this.lblDetailsTimes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbRiderSearch = new System.Windows.Forms.TextBox();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.lvRiderDetails = new System.Windows.Forms.ListView();
            this.lblRiderName = new System.Windows.Forms.Label();
            this.btnAddRider = new System.Windows.Forms.Button();
            this.btnAddEndTime = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbttn4 = new System.Windows.Forms.RadioButton();
            this.rbttn3 = new System.Windows.Forms.RadioButton();
            this.rbttn2 = new System.Windows.Forms.RadioButton();
            this.rbttn1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDetailsTimes
            // 
            this.lblDetailsTimes.AutoSize = true;
            this.lblDetailsTimes.Location = new System.Drawing.Point(32, 378);
            this.lblDetailsTimes.Name = "lblDetailsTimes";
            this.lblDetailsTimes.Size = new System.Drawing.Size(72, 17);
            this.lblDetailsTimes.TabIndex = 14;
            this.lblDetailsTimes.Text = "End Time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(450, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 29);
            this.label2.TabIndex = 23;
            this.label2.Text = "Add Rider Times";
            // 
            // txbRiderSearch
            // 
            this.txbRiderSearch.BackColor = System.Drawing.Color.SeaShell;
            this.txbRiderSearch.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txbRiderSearch.Location = new System.Drawing.Point(132, 96);
            this.txbRiderSearch.Name = "txbRiderSearch";
            this.txbRiderSearch.Size = new System.Drawing.Size(226, 22);
            this.txbRiderSearch.TabIndex = 25;
            this.txbRiderSearch.TextChanged += new System.EventHandler(this.FilterTxt_TextChanged);
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.CalendarForeColor = System.Drawing.Color.SaddleBrown;
            this.dtpEndTime.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtpEndTime.CalendarTitleForeColor = System.Drawing.Color.SaddleBrown;
            this.dtpEndTime.CustomFormat = "HH:mm:ss";
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndTime.Location = new System.Drawing.Point(120, 378);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.ShowUpDown = true;
            this.dtpEndTime.Size = new System.Drawing.Size(200, 22);
            this.dtpEndTime.TabIndex = 26;
            this.dtpEndTime.Value = new System.DateTime(2021, 6, 23, 12, 2, 41, 0);
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
            this.lvRiderDetails.Location = new System.Drawing.Point(12, 133);
            this.lvRiderDetails.Name = "lvRiderDetails";
            this.lvRiderDetails.Size = new System.Drawing.Size(792, 158);
            this.lvRiderDetails.TabIndex = 29;
            this.lvRiderDetails.UseCompatibleStateImageBehavior = false;
            this.lvRiderDetails.SelectedIndexChanged += new System.EventHandler(this.lvRiderDetails_SelectedIndexChanged);
            // 
            // lblRiderName
            // 
            this.lblRiderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRiderName.Location = new System.Drawing.Point(8, 96);
            this.lblRiderName.Name = "lblRiderName";
            this.lblRiderName.Size = new System.Drawing.Size(122, 22);
            this.lblRiderName.TabIndex = 30;
            this.lblRiderName.Text = "Search Rider:";
            // 
            // btnAddRider
            // 
            this.btnAddRider.Location = new System.Drawing.Point(688, 376);
            this.btnAddRider.Name = "btnAddRider";
            this.btnAddRider.Size = new System.Drawing.Size(116, 31);
            this.btnAddRider.TabIndex = 31;
            this.btnAddRider.Text = "Add Rider";
            this.btnAddRider.UseVisualStyleBackColor = true;
            this.btnAddRider.Click += new System.EventHandler(this.btnAddRider_Click);
            // 
            // btnAddEndTime
            // 
            this.btnAddEndTime.Location = new System.Drawing.Point(341, 371);
            this.btnAddEndTime.Name = "btnAddEndTime";
            this.btnAddEndTime.Size = new System.Drawing.Size(116, 31);
            this.btnAddEndTime.TabIndex = 32;
            this.btnAddEndTime.Text = "Add End Time";
            this.btnAddEndTime.UseVisualStyleBackColor = true;
            this.btnAddEndTime.Click += new System.EventHandler(this.btnAddEndTime_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.rbttn4);
            this.groupBox1.Controls.Add(this.rbttn3);
            this.groupBox1.Controls.Add(this.rbttn2);
            this.groupBox1.Controls.Add(this.rbttn1);
            this.groupBox1.Location = new System.Drawing.Point(126, 309);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 43);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            // 
            // rbttn4
            // 
            this.rbttn4.AutoSize = true;
            this.rbttn4.ForeColor = System.Drawing.Color.SaddleBrown;
            this.rbttn4.Location = new System.Drawing.Point(212, 17);
            this.rbttn4.Name = "rbttn4";
            this.rbttn4.Size = new System.Drawing.Size(65, 21);
            this.rbttn4.TabIndex = 3;
            this.rbttn4.TabStop = true;
            this.rbttn4.Text = "Leg 4";
            this.rbttn4.UseVisualStyleBackColor = true;
            // 
            // rbttn3
            // 
            this.rbttn3.AutoSize = true;
            this.rbttn3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.rbttn3.Location = new System.Drawing.Point(145, 17);
            this.rbttn3.Name = "rbttn3";
            this.rbttn3.Size = new System.Drawing.Size(65, 21);
            this.rbttn3.TabIndex = 2;
            this.rbttn3.TabStop = true;
            this.rbttn3.Text = "Leg 3";
            this.rbttn3.UseVisualStyleBackColor = true;
            // 
            // rbttn2
            // 
            this.rbttn2.AutoSize = true;
            this.rbttn2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.rbttn2.Location = new System.Drawing.Point(78, 17);
            this.rbttn2.Name = "rbttn2";
            this.rbttn2.Size = new System.Drawing.Size(65, 21);
            this.rbttn2.TabIndex = 1;
            this.rbttn2.TabStop = true;
            this.rbttn2.Text = "Leg 2";
            this.rbttn2.UseVisualStyleBackColor = true;
            // 
            // rbttn1
            // 
            this.rbttn1.AutoSize = true;
            this.rbttn1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.rbttn1.Location = new System.Drawing.Point(7, 17);
            this.rbttn1.Name = "rbttn1";
            this.rbttn1.Size = new System.Drawing.Size(65, 21);
            this.rbttn1.TabIndex = 0;
            this.rbttn1.TabStop = true;
            this.rbttn1.Text = "Leg 1";
            this.rbttn1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "Choose Leg:";
            // 
            // DBAddRiderTimes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAddEndTime);
            this.Controls.Add(this.lvRiderDetails);
            this.Controls.Add(this.btnAddRider);
            this.Controls.Add(this.lblRiderName);
            this.Controls.Add(this.dtpEndTime);
            this.Controls.Add(this.txbRiderSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDetailsTimes);
            this.Name = "DBAddRiderTimes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddRiderTimes";
            this.Load += new System.EventHandler(this.CCMountainBikingRaceDBAddRiderTimes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDetailsTimes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbRiderSearch;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private System.Windows.Forms.ListView lvRiderDetails;
        private System.Windows.Forms.Label lblRiderName;
        private System.Windows.Forms.Button btnAddRider;
        private System.Windows.Forms.Button btnAddEndTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbttn4;
        private System.Windows.Forms.RadioButton rbttn3;
        private System.Windows.Forms.RadioButton rbttn2;
        private System.Windows.Forms.RadioButton rbttn1;
        private System.Windows.Forms.Label label1;
    }
}