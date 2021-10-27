
namespace CC_Mountain_Biking_Race
{
    partial class CCMountainBikingRaceDBAddRiderTimes
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
            this.btnDeleteRider = new System.Windows.Forms.Button();
            this.btnUpdateEndTime = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txbRiderSearch = new System.Windows.Forms.TextBox();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.lvRiderDetails = new System.Windows.Forms.ListView();
            this.lblRiderName = new System.Windows.Forms.Label();
            this.btnAddRider = new System.Windows.Forms.Button();
            this.btnAddEndTime = new System.Windows.Forms.Button();
            this.lvRiderTimes = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lblDetailsTimes
            // 
            this.lblDetailsTimes.AutoSize = true;
            this.lblDetailsTimes.Location = new System.Drawing.Point(26, 327);
            this.lblDetailsTimes.Name = "lblDetailsTimes";
            this.lblDetailsTimes.Size = new System.Drawing.Size(72, 17);
            this.lblDetailsTimes.TabIndex = 14;
            this.lblDetailsTimes.Text = "End Time:";
            // 
            // btnDeleteRider
            // 
            this.btnDeleteRider.Location = new System.Drawing.Point(639, 327);
            this.btnDeleteRider.Name = "btnDeleteRider";
            this.btnDeleteRider.Size = new System.Drawing.Size(151, 31);
            this.btnDeleteRider.TabIndex = 22;
            this.btnDeleteRider.Text = "Delete End Time";
            this.btnDeleteRider.UseVisualStyleBackColor = true;
            this.btnDeleteRider.Click += new System.EventHandler(this.btnDeleteRider_Click);
            // 
            // btnUpdateEndTime
            // 
            this.btnUpdateEndTime.Location = new System.Drawing.Point(455, 327);
            this.btnUpdateEndTime.Name = "btnUpdateEndTime";
            this.btnUpdateEndTime.Size = new System.Drawing.Size(169, 31);
            this.btnUpdateEndTime.TabIndex = 21;
            this.btnUpdateEndTime.Text = "Update End Time";
            this.btnUpdateEndTime.UseVisualStyleBackColor = true;
            this.btnUpdateEndTime.Click += new System.EventHandler(this.btnUpdateEndTime_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(301, 21);
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
            this.dtpEndTime.Location = new System.Drawing.Point(114, 327);
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
            this.btnAddRider.Location = new System.Drawing.Point(674, 385);
            this.btnAddRider.Name = "btnAddRider";
            this.btnAddRider.Size = new System.Drawing.Size(116, 31);
            this.btnAddRider.TabIndex = 31;
            this.btnAddRider.Text = "Add Rider";
            this.btnAddRider.UseVisualStyleBackColor = true;
            this.btnAddRider.Click += new System.EventHandler(this.btnAddRider_Click);
            // 
            // btnAddEndTime
            // 
            this.btnAddEndTime.Location = new System.Drawing.Point(325, 327);
            this.btnAddEndTime.Name = "btnAddEndTime";
            this.btnAddEndTime.Size = new System.Drawing.Size(116, 31);
            this.btnAddEndTime.TabIndex = 32;
            this.btnAddEndTime.Text = "Add End Time";
            this.btnAddEndTime.UseVisualStyleBackColor = true;
            this.btnAddEndTime.Click += new System.EventHandler(this.btnAddEndTime_Click);
            // 
            // lvRiderTimes
            // 
            this.lvRiderTimes.BackColor = System.Drawing.Color.SeaShell;
            this.lvRiderTimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvRiderTimes.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lvRiderTimes.FullRowSelect = true;
            this.lvRiderTimes.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvRiderTimes.HideSelection = false;
            this.lvRiderTimes.LabelWrap = false;
            this.lvRiderTimes.Location = new System.Drawing.Point(810, 133);
            this.lvRiderTimes.Name = "lvRiderTimes";
            this.lvRiderTimes.Size = new System.Drawing.Size(243, 158);
            this.lvRiderTimes.TabIndex = 33;
            this.lvRiderTimes.UseCompatibleStateImageBehavior = false;
            // 
            // CCMountainBikingRaceDBAddRiderTimes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 450);
            this.Controls.Add(this.lvRiderTimes);
            this.Controls.Add(this.btnAddEndTime);
            this.Controls.Add(this.btnAddRider);
            this.Controls.Add(this.lblRiderName);
            this.Controls.Add(this.lvRiderDetails);
            this.Controls.Add(this.dtpEndTime);
            this.Controls.Add(this.txbRiderSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDeleteRider);
            this.Controls.Add(this.btnUpdateEndTime);
            this.Controls.Add(this.lblDetailsTimes);
            this.Name = "CCMountainBikingRaceDBAddRiderTimes";
            this.Text = "AddRiderTimes";
            this.Load += new System.EventHandler(this.CCMountainBikingRaceDBAddRiderTimes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDetailsTimes;
        private System.Windows.Forms.Button btnDeleteRider;
        private System.Windows.Forms.Button btnUpdateEndTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbRiderSearch;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private System.Windows.Forms.ListView lvRiderDetails;
        private System.Windows.Forms.Label lblRiderName;
        private System.Windows.Forms.Button btnAddRider;
        private System.Windows.Forms.Button btnAddEndTime;
        private System.Windows.Forms.ListView lvRiderTimes;
    }
}