
namespace CC_Mountain_Biking_Race
{
    partial class CCMountainBikingRaceDB
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
            this.lblRiderDetails = new System.Windows.Forms.Label();
            this.lstRiderDetails = new System.Windows.Forms.ListBox();
            this.lstRiderTimes = new System.Windows.Forms.ListBox();
            this.lblDetailsTimes = new System.Windows.Forms.Label();
            this.btnAddRiderName = new System.Windows.Forms.Button();
            this.txtRiderName = new System.Windows.Forms.TextBox();
            this.btnUpdateRiderName = new System.Windows.Forms.Button();
            this.lblRiderName = new System.Windows.Forms.Label();
            this.btnDeleteRider = new System.Windows.Forms.Button();
            this.cCMountainBikingDBDataSet = new CC_Mountain_Biking_Race.CCMountainBikingDBDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.cCMountainBikingDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRiderDetails
            // 
            this.lblRiderDetails.AutoSize = true;
            this.lblRiderDetails.Location = new System.Drawing.Point(26, 142);
            this.lblRiderDetails.Name = "lblRiderDetails";
            this.lblRiderDetails.Size = new System.Drawing.Size(89, 17);
            this.lblRiderDetails.TabIndex = 0;
            this.lblRiderDetails.Text = "Rider Details\r\n";
            // 
            // lstRiderDetails
            // 
            this.lstRiderDetails.FormattingEnabled = true;
            this.lstRiderDetails.ItemHeight = 16;
            this.lstRiderDetails.Location = new System.Drawing.Point(29, 177);
            this.lstRiderDetails.Name = "lstRiderDetails";
            this.lstRiderDetails.Size = new System.Drawing.Size(328, 116);
            this.lstRiderDetails.TabIndex = 1;
            this.lstRiderDetails.SelectedIndexChanged += new System.EventHandler(this.lstRiderDetails_SelectedIndexChanged);
            // 
            // lstRiderTimes
            // 
            this.lstRiderTimes.FormattingEnabled = true;
            this.lstRiderTimes.ItemHeight = 16;
            this.lstRiderTimes.Location = new System.Drawing.Point(29, 342);
            this.lstRiderTimes.Name = "lstRiderTimes";
            this.lstRiderTimes.Size = new System.Drawing.Size(328, 116);
            this.lstRiderTimes.TabIndex = 3;
            // 
            // lblDetailsTimes
            // 
            this.lblDetailsTimes.AutoSize = true;
            this.lblDetailsTimes.Location = new System.Drawing.Point(26, 307);
            this.lblDetailsTimes.Name = "lblDetailsTimes";
            this.lblDetailsTimes.Size = new System.Drawing.Size(93, 17);
            this.lblDetailsTimes.TabIndex = 2;
            this.lblDetailsTimes.Text = "Details Times";
            // 
            // btnAddRiderName
            // 
            this.btnAddRiderName.Location = new System.Drawing.Point(364, 18);
            this.btnAddRiderName.Name = "btnAddRiderName";
            this.btnAddRiderName.Size = new System.Drawing.Size(116, 31);
            this.btnAddRiderName.TabIndex = 4;
            this.btnAddRiderName.Text = "Add Rider";
            this.btnAddRiderName.UseVisualStyleBackColor = true;
            this.btnAddRiderName.Click += new System.EventHandler(this.btnAddRider_Click);
            // 
            // txtRiderName
            // 
            this.txtRiderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRiderName.Location = new System.Drawing.Point(154, 17);
            this.txtRiderName.Name = "txtRiderName";
            this.txtRiderName.Size = new System.Drawing.Size(145, 28);
            this.txtRiderName.TabIndex = 5;
            // 
            // btnUpdateRiderName
            // 
            this.btnUpdateRiderName.Location = new System.Drawing.Point(486, 18);
            this.btnUpdateRiderName.Name = "btnUpdateRiderName";
            this.btnUpdateRiderName.Size = new System.Drawing.Size(169, 31);
            this.btnUpdateRiderName.TabIndex = 6;
            this.btnUpdateRiderName.Text = "Update Rider Name";
            this.btnUpdateRiderName.UseVisualStyleBackColor = true;
            this.btnUpdateRiderName.Click += new System.EventHandler(this.btnUpdateRiderName_Click);
            // 
            // lblRiderName
            // 
            this.lblRiderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRiderName.Location = new System.Drawing.Point(26, 18);
            this.lblRiderName.Name = "lblRiderName";
            this.lblRiderName.Size = new System.Drawing.Size(122, 22);
            this.lblRiderName.TabIndex = 7;
            this.lblRiderName.Text = "Rider Name:";
            // 
            // btnDeleteRider
            // 
            this.btnDeleteRider.Location = new System.Drawing.Point(364, 76);
            this.btnDeleteRider.Name = "btnDeleteRider";
            this.btnDeleteRider.Size = new System.Drawing.Size(116, 31);
            this.btnDeleteRider.TabIndex = 8;
            this.btnDeleteRider.Text = "Delete Rider";
            this.btnDeleteRider.UseVisualStyleBackColor = true;
            this.btnDeleteRider.Click += new System.EventHandler(this.btnDeleteRider_Click);
            // 
            // cCMountainBikingDBDataSet
            // 
            this.cCMountainBikingDBDataSet.DataSetName = "CCMountainBikingDBDataSet";
            this.cCMountainBikingDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CCMountainBikingRaceDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 531);
            this.Controls.Add(this.btnDeleteRider);
            this.Controls.Add(this.lblRiderName);
            this.Controls.Add(this.btnUpdateRiderName);
            this.Controls.Add(this.txtRiderName);
            this.Controls.Add(this.btnAddRiderName);
            this.Controls.Add(this.lstRiderTimes);
            this.Controls.Add(this.lblDetailsTimes);
            this.Controls.Add(this.lstRiderDetails);
            this.Controls.Add(this.lblRiderDetails);
            this.Name = "CCMountainBikingRaceDB";
            this.Text = "CCMountainBikingRaceDB";
            this.Load += new System.EventHandler(this.CCMountainBikingRaceDB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cCMountainBikingDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRiderDetails;
        private System.Windows.Forms.ListBox lstRiderDetails;
        private CCMountainBikingDBDataSet cCMountainBikingDBDataSet;
        private System.Windows.Forms.ListBox lstRiderTimes;
        private System.Windows.Forms.Label lblDetailsTimes;
        private System.Windows.Forms.Button btnAddRiderName;
        private System.Windows.Forms.TextBox txtRiderName;
        private System.Windows.Forms.Button btnUpdateRiderName;
        private System.Windows.Forms.Label lblRiderName;
        private System.Windows.Forms.Button btnDeleteRider;
    }
}