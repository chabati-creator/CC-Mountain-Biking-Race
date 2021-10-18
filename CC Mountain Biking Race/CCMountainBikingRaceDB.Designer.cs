
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
            this.lstEndTimes = new System.Windows.Forms.ListBox();
            this.lblDetailsTimes = new System.Windows.Forms.Label();
            this.btnAddRiderName = new System.Windows.Forms.Button();
            this.btnUpdateRiderName = new System.Windows.Forms.Button();
            this.btnDeleteRider = new System.Windows.Forms.Button();
            this.cCMountainBikingDBDataSet = new CC_Mountain_Biking_Race.CCMountainBikingDBDataSet();
            this.lstStartTimes = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddEndTime = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblRiderName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudAge = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.chlbx = new System.Windows.Forms.CheckedListBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbSurname = new System.Windows.Forms.TextBox();
            this.txbSchool = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.cCMountainBikingDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRiderDetails
            // 
            this.lblRiderDetails.AutoSize = true;
            this.lblRiderDetails.Location = new System.Drawing.Point(27, 9);
            this.lblRiderDetails.Name = "lblRiderDetails";
            this.lblRiderDetails.Size = new System.Drawing.Size(89, 17);
            this.lblRiderDetails.TabIndex = 0;
            this.lblRiderDetails.Text = "Rider Details\r\n";
            // 
            // lstRiderDetails
            // 
            this.lstRiderDetails.FormattingEnabled = true;
            this.lstRiderDetails.ItemHeight = 16;
            this.lstRiderDetails.Location = new System.Drawing.Point(30, 298);
            this.lstRiderDetails.Name = "lstRiderDetails";
            this.lstRiderDetails.Size = new System.Drawing.Size(328, 116);
            this.lstRiderDetails.TabIndex = 1;
            this.lstRiderDetails.SelectedIndexChanged += new System.EventHandler(this.lstRiderDetails_SelectedIndexChanged);
            // 
            // lstEndTimes
            // 
            this.lstEndTimes.FormattingEnabled = true;
            this.lstEndTimes.ItemHeight = 16;
            this.lstEndTimes.Location = new System.Drawing.Point(285, 480);
            this.lstEndTimes.Name = "lstEndTimes";
            this.lstEndTimes.Size = new System.Drawing.Size(119, 20);
            this.lstEndTimes.TabIndex = 3;
            // 
            // lblDetailsTimes
            // 
            this.lblDetailsTimes.AutoSize = true;
            this.lblDetailsTimes.Location = new System.Drawing.Point(27, 483);
            this.lblDetailsTimes.Name = "lblDetailsTimes";
            this.lblDetailsTimes.Size = new System.Drawing.Size(72, 17);
            this.lblDetailsTimes.TabIndex = 2;
            this.lblDetailsTimes.Text = "End Time:";
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
            // btnDeleteRider
            // 
            this.btnDeleteRider.Location = new System.Drawing.Point(364, 55);
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
            // lstStartTimes
            // 
            this.lstStartTimes.FormattingEnabled = true;
            this.lstStartTimes.ItemHeight = 16;
            this.lstStartTimes.Location = new System.Drawing.Point(285, 439);
            this.lstStartTimes.Name = "lstStartTimes";
            this.lstStartTimes.Size = new System.Drawing.Size(119, 20);
            this.lstStartTimes.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 439);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Start Time:";
            // 
            // btnAddEndTime
            // 
            this.btnAddEndTime.Location = new System.Drawing.Point(138, 471);
            this.btnAddEndTime.Name = "btnAddEndTime";
            this.btnAddEndTime.Size = new System.Drawing.Size(116, 31);
            this.btnAddEndTime.TabIndex = 11;
            this.btnAddEndTime.Text = "Add End Time";
            this.btnAddEndTime.UseVisualStyleBackColor = true;
            this.btnAddEndTime.Click += new System.EventHandler(this.btnAddEndTime_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(121, 480);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 28);
            this.textBox1.TabIndex = 12;
            // 
            // lblRiderName
            // 
            this.lblRiderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRiderName.Location = new System.Drawing.Point(26, 31);
            this.lblRiderName.Name = "lblRiderName";
            this.lblRiderName.Size = new System.Drawing.Size(122, 22);
            this.lblRiderName.TabIndex = 7;
            this.lblRiderName.Text = "Name:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "Surname:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 22);
            this.label3.TabIndex = 16;
            this.label3.Text = "School:";
            // 
            // nudAge
            // 
            this.nudAge.BackColor = System.Drawing.Color.SeaShell;
            this.nudAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAge.ForeColor = System.Drawing.Color.SaddleBrown;
            this.nudAge.Location = new System.Drawing.Point(154, 116);
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
            this.nudAge.Size = new System.Drawing.Size(162, 27);
            this.nudAge.TabIndex = 17;
            this.nudAge.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 22);
            this.label4.TabIndex = 18;
            this.label4.Text = "Age:";
            // 
            // chlbx
            // 
            this.chlbx.BackColor = System.Drawing.Color.SeaShell;
            this.chlbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chlbx.ForeColor = System.Drawing.Color.SaddleBrown;
            this.chlbx.FormattingEnabled = true;
            this.chlbx.Items.AddRange(new object[] {
            "Leg 1",
            "Leg 2",
            "Leg 3",
            "Leg 4"});
            this.chlbx.Location = new System.Drawing.Point(154, 191);
            this.chlbx.Name = "chlbx";
            this.chlbx.Size = new System.Drawing.Size(72, 89);
            this.chlbx.TabIndex = 19;
            // 
            // txbName
            // 
            this.txbName.BackColor = System.Drawing.Color.SeaShell;
            this.txbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbName.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txbName.Location = new System.Drawing.Point(154, 27);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(162, 28);
            this.txbName.TabIndex = 20;
            // 
            // txbSurname
            // 
            this.txbSurname.BackColor = System.Drawing.Color.SeaShell;
            this.txbSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSurname.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txbSurname.Location = new System.Drawing.Point(154, 73);
            this.txbSurname.Name = "txbSurname";
            this.txbSurname.Size = new System.Drawing.Size(162, 28);
            this.txbSurname.TabIndex = 21;
            // 
            // txbSchool
            // 
            this.txbSchool.BackColor = System.Drawing.Color.SeaShell;
            this.txbSchool.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSchool.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txbSchool.Location = new System.Drawing.Point(154, 155);
            this.txbSchool.Name = "txbSchool";
            this.txbSchool.Size = new System.Drawing.Size(162, 28);
            this.txbSchool.TabIndex = 22;
            // 
            // CCMountainBikingRaceDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 531);
            this.Controls.Add(this.txbSchool);
            this.Controls.Add(this.txbSurname);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.chlbx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudAge);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnAddEndTime);
            this.Controls.Add(this.lstStartTimes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteRider);
            this.Controls.Add(this.lblRiderName);
            this.Controls.Add(this.btnUpdateRiderName);
            this.Controls.Add(this.btnAddRiderName);
            this.Controls.Add(this.lstEndTimes);
            this.Controls.Add(this.lblDetailsTimes);
            this.Controls.Add(this.lstRiderDetails);
            this.Controls.Add(this.lblRiderDetails);
            this.Name = "CCMountainBikingRaceDB";
            this.Text = "CCMountainBikingRaceDB";
            this.Load += new System.EventHandler(this.CCMountainBikingRaceDB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cCMountainBikingDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRiderDetails;
        private System.Windows.Forms.ListBox lstRiderDetails;
        private CCMountainBikingDBDataSet cCMountainBikingDBDataSet;
        private System.Windows.Forms.Label lblDetailsTimes;
        private System.Windows.Forms.Button btnAddRiderName;
        private System.Windows.Forms.Button btnUpdateRiderName;
        private System.Windows.Forms.Button btnDeleteRider;
        private System.Windows.Forms.ListBox lstEndTimes;
        private System.Windows.Forms.ListBox lstStartTimes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddEndTime;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblRiderName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudAge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox chlbx;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbSurname;
        private System.Windows.Forms.TextBox txbSchool;
    }
}