
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
            this.btnAddRiderName = new System.Windows.Forms.Button();
            this.btnUpdateRiderName = new System.Windows.Forms.Button();
            this.btnDeleteRider = new System.Windows.Forms.Button();
            this.cCMountainBikingDBDataSet = new CC_Mountain_Biking_Race.CCMountainBikingDBDataSet();
            this.lblRiderName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudAge = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbSurname = new System.Windows.Forms.TextBox();
            this.txbSchool = new System.Windows.Forms.TextBox();
            this.chbLeg1 = new System.Windows.Forms.CheckBox();
            this.chbLeg2 = new System.Windows.Forms.CheckBox();
            this.chbLeg3 = new System.Windows.Forms.CheckBox();
            this.chbLeg4 = new System.Windows.Forms.CheckBox();
            this.btnAddRiderTimes = new System.Windows.Forms.Button();
            this.lstvRiderDetails = new System.Windows.Forms.ListView();
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
            this.lstRiderDetails.Location = new System.Drawing.Point(30, 286);
            this.lstRiderDetails.Name = "lstRiderDetails";
            this.lstRiderDetails.Size = new System.Drawing.Size(468, 116);
            this.lstRiderDetails.TabIndex = 1;
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
            // chbLeg1
            // 
            this.chbLeg1.AutoSize = true;
            this.chbLeg1.Location = new System.Drawing.Point(154, 200);
            this.chbLeg1.Name = "chbLeg1";
            this.chbLeg1.Size = new System.Drawing.Size(66, 21);
            this.chbLeg1.TabIndex = 23;
            this.chbLeg1.Text = "Leg 1";
            this.chbLeg1.UseVisualStyleBackColor = true;
            // 
            // chbLeg2
            // 
            this.chbLeg2.AutoSize = true;
            this.chbLeg2.Location = new System.Drawing.Point(154, 218);
            this.chbLeg2.Name = "chbLeg2";
            this.chbLeg2.Size = new System.Drawing.Size(66, 21);
            this.chbLeg2.TabIndex = 24;
            this.chbLeg2.Text = "Leg 2";
            this.chbLeg2.UseVisualStyleBackColor = true;
            // 
            // chbLeg3
            // 
            this.chbLeg3.AutoSize = true;
            this.chbLeg3.Location = new System.Drawing.Point(154, 236);
            this.chbLeg3.Name = "chbLeg3";
            this.chbLeg3.Size = new System.Drawing.Size(66, 21);
            this.chbLeg3.TabIndex = 25;
            this.chbLeg3.Text = "Leg 3";
            this.chbLeg3.UseVisualStyleBackColor = true;
            // 
            // chbLeg4
            // 
            this.chbLeg4.AutoSize = true;
            this.chbLeg4.Location = new System.Drawing.Point(154, 254);
            this.chbLeg4.Name = "chbLeg4";
            this.chbLeg4.Size = new System.Drawing.Size(66, 21);
            this.chbLeg4.TabIndex = 26;
            this.chbLeg4.Text = "Leg 4";
            this.chbLeg4.UseVisualStyleBackColor = true;
            // 
            // btnAddRiderTimes
            // 
            this.btnAddRiderTimes.Location = new System.Drawing.Point(532, 371);
            this.btnAddRiderTimes.Name = "btnAddRiderTimes";
            this.btnAddRiderTimes.Size = new System.Drawing.Size(158, 31);
            this.btnAddRiderTimes.TabIndex = 27;
            this.btnAddRiderTimes.Text = "Add Rider Times";
            this.btnAddRiderTimes.UseVisualStyleBackColor = true;
            this.btnAddRiderTimes.Click += new System.EventHandler(this.btnAddRiderTimes_Click);
            // 
            // lstvRiderDetails
            // 
            this.lstvRiderDetails.BackColor = System.Drawing.Color.SeaShell;
            this.lstvRiderDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstvRiderDetails.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lstvRiderDetails.FullRowSelect = true;
            this.lstvRiderDetails.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstvRiderDetails.HideSelection = false;
            this.lstvRiderDetails.LabelWrap = false;
            this.lstvRiderDetails.Location = new System.Drawing.Point(338, 136);
            this.lstvRiderDetails.Name = "lstvRiderDetails";
            this.lstvRiderDetails.Size = new System.Drawing.Size(469, 139);
            this.lstvRiderDetails.TabIndex = 28;
            this.lstvRiderDetails.UseCompatibleStateImageBehavior = false;
            // 
            // CCMountainBikingRaceDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 531);
            this.Controls.Add(this.lstvRiderDetails);
            this.Controls.Add(this.btnAddRiderTimes);
            this.Controls.Add(this.chbLeg4);
            this.Controls.Add(this.chbLeg3);
            this.Controls.Add(this.chbLeg2);
            this.Controls.Add(this.chbLeg1);
            this.Controls.Add(this.txbSchool);
            this.Controls.Add(this.txbSurname);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudAge);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDeleteRider);
            this.Controls.Add(this.lblRiderName);
            this.Controls.Add(this.btnUpdateRiderName);
            this.Controls.Add(this.btnAddRiderName);
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
        private System.Windows.Forms.Button btnAddRiderName;
        private System.Windows.Forms.Button btnUpdateRiderName;
        private System.Windows.Forms.Button btnDeleteRider;
        private System.Windows.Forms.Label lblRiderName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudAge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbSurname;
        private System.Windows.Forms.TextBox txbSchool;
        private System.Windows.Forms.CheckBox chbLeg1;
        private System.Windows.Forms.CheckBox chbLeg2;
        private System.Windows.Forms.CheckBox chbLeg3;
        private System.Windows.Forms.CheckBox chbLeg4;
        private System.Windows.Forms.Button btnAddRiderTimes;
        private System.Windows.Forms.ListView lstvRiderDetails;
    }
}