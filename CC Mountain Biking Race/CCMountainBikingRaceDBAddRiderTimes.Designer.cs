
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
            this.btnAddEndTime = new System.Windows.Forms.Button();
            this.lblDetailsTimes = new System.Windows.Forms.Label();
            this.lstRiderDetails = new System.Windows.Forms.ListBox();
            this.btnDeleteRider = new System.Windows.Forms.Button();
            this.btnUpdateEndTime = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txbRiderSearch = new System.Windows.Forms.TextBox();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnAddEndTime
            // 
            this.btnAddEndTime.Location = new System.Drawing.Point(319, 263);
            this.btnAddEndTime.Name = "btnAddEndTime";
            this.btnAddEndTime.Size = new System.Drawing.Size(116, 31);
            this.btnAddEndTime.TabIndex = 18;
            this.btnAddEndTime.Text = "Add End Time";
            this.btnAddEndTime.UseVisualStyleBackColor = true;
            // 
            // lblDetailsTimes
            // 
            this.lblDetailsTimes.AutoSize = true;
            this.lblDetailsTimes.Location = new System.Drawing.Point(25, 263);
            this.lblDetailsTimes.Name = "lblDetailsTimes";
            this.lblDetailsTimes.Size = new System.Drawing.Size(72, 17);
            this.lblDetailsTimes.TabIndex = 14;
            this.lblDetailsTimes.Text = "End Time:";
            // 
            // lstRiderDetails
            // 
            this.lstRiderDetails.FormattingEnabled = true;
            this.lstRiderDetails.ItemHeight = 16;
            this.lstRiderDetails.Location = new System.Drawing.Point(12, 127);
            this.lstRiderDetails.Name = "lstRiderDetails";
            this.lstRiderDetails.Size = new System.Drawing.Size(468, 116);
            this.lstRiderDetails.TabIndex = 13;
            // 
            // btnDeleteRider
            // 
            this.btnDeleteRider.Location = new System.Drawing.Point(638, 263);
            this.btnDeleteRider.Name = "btnDeleteRider";
            this.btnDeleteRider.Size = new System.Drawing.Size(151, 31);
            this.btnDeleteRider.TabIndex = 22;
            this.btnDeleteRider.Text = "Delete End Time";
            this.btnDeleteRider.UseVisualStyleBackColor = true;
            // 
            // btnUpdateEndTime
            // 
            this.btnUpdateEndTime.Location = new System.Drawing.Point(454, 263);
            this.btnUpdateEndTime.Name = "btnUpdateEndTime";
            this.btnUpdateEndTime.Size = new System.Drawing.Size(169, 31);
            this.btnUpdateEndTime.TabIndex = 21;
            this.btnUpdateEndTime.Text = "Update End Time";
            this.btnUpdateEndTime.UseVisualStyleBackColor = true;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(210, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 31);
            this.button1.TabIndex = 24;
            this.button1.Text = "Search Rider";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txbRiderSearch
            // 
            this.txbRiderSearch.BackColor = System.Drawing.Color.SeaShell;
            this.txbRiderSearch.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txbRiderSearch.Location = new System.Drawing.Point(12, 95);
            this.txbRiderSearch.Name = "txbRiderSearch";
            this.txbRiderSearch.Size = new System.Drawing.Size(192, 22);
            this.txbRiderSearch.TabIndex = 25;
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.CalendarForeColor = System.Drawing.Color.SaddleBrown;
            this.dtpEndTime.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtpEndTime.CalendarTitleForeColor = System.Drawing.Color.SaddleBrown;
            this.dtpEndTime.CustomFormat = "HH:mm:ss";
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndTime.Location = new System.Drawing.Point(113, 263);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.ShowUpDown = true;
            this.dtpEndTime.Size = new System.Drawing.Size(200, 22);
            this.dtpEndTime.TabIndex = 26;
            this.dtpEndTime.Value = new System.DateTime(2021, 6, 23, 12, 2, 41, 0);
            // 
            // CCMountainBikingRaceDBAddRiderTimes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtpEndTime);
            this.Controls.Add(this.txbRiderSearch);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDeleteRider);
            this.Controls.Add(this.btnUpdateEndTime);
            this.Controls.Add(this.btnAddEndTime);
            this.Controls.Add(this.lblDetailsTimes);
            this.Controls.Add(this.lstRiderDetails);
            this.Name = "CCMountainBikingRaceDBAddRiderTimes";
            this.Text = "CCMountainBikingRaceDBAddRiderTimes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddEndTime;
        private System.Windows.Forms.Label lblDetailsTimes;
        private System.Windows.Forms.ListBox lstRiderDetails;
        private System.Windows.Forms.Button btnDeleteRider;
        private System.Windows.Forms.Button btnUpdateEndTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txbRiderSearch;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
    }
}