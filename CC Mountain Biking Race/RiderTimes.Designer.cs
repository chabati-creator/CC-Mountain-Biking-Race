
using System;

namespace CC_Mountain_Biking_Race
{
    partial class RiderTimes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RiderTimes));
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblHeading2 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLegs = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.bttnDismiss = new System.Windows.Forms.Button();
            this.listvSearch = new System.Windows.Forms.ListView();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.rbttn1 = new System.Windows.Forms.RadioButton();
            this.rbttn2 = new System.Windows.Forms.RadioButton();
            this.rbttn3 = new System.Windows.Forms.RadioButton();
            this.rbttn4 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bttnUpdate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.BackColor = System.Drawing.Color.SandyBrown;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblHeading.Location = new System.Drawing.Point(233, 19);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(512, 32);
            this.lblHeading.TabIndex = 3;
            this.lblHeading.Text = "Cross Country Mountain Biking Race";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHeading2
            // 
            this.lblHeading2.BackColor = System.Drawing.Color.Chocolate;
            this.lblHeading2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading2.ForeColor = System.Drawing.Color.SeaShell;
            this.lblHeading2.Location = new System.Drawing.Point(100, 63);
            this.lblHeading2.Name = "lblHeading2";
            this.lblHeading2.Size = new System.Drawing.Size(676, 41);
            this.lblHeading2.TabIndex = 4;
            this.lblHeading2.Text = "Select a rider and the leg they are entering in. Enter the rider\'s race results s" +
    "uch as their start and end times using the dropdowns.\r\n";
            this.lblHeading2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.SandyBrown;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.SeaShell;
            this.lblName.Location = new System.Drawing.Point(101, 120);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(109, 28);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Search Rider:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLegs
            // 
            this.lblLegs.BackColor = System.Drawing.Color.SandyBrown;
            this.lblLegs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLegs.ForeColor = System.Drawing.Color.SeaShell;
            this.lblLegs.Location = new System.Drawing.Point(101, 329);
            this.lblLegs.Name = "lblLegs";
            this.lblLegs.Size = new System.Drawing.Size(109, 28);
            this.lblLegs.TabIndex = 14;
            this.lblLegs.Text = "Choose Leg:";
            this.lblLegs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEnd
            // 
            this.lblEnd.BackColor = System.Drawing.Color.SandyBrown;
            this.lblEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnd.ForeColor = System.Drawing.Color.SeaShell;
            this.lblEnd.Location = new System.Drawing.Point(101, 429);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(109, 28);
            this.lblEnd.TabIndex = 17;
            this.lblEnd.Text = "End Time:";
            this.lblEnd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStart
            // 
            this.lblStart.BackColor = System.Drawing.Color.SandyBrown;
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.ForeColor = System.Drawing.Color.SeaShell;
            this.lblStart.Location = new System.Drawing.Point(101, 380);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(109, 28);
            this.lblStart.TabIndex = 18;
            this.lblStart.Text = "Start Time:";
            this.lblStart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bttnDismiss
            // 
            this.bttnDismiss.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnDismiss.ForeColor = System.Drawing.Color.SaddleBrown;
            this.bttnDismiss.Location = new System.Drawing.Point(441, 486);
            this.bttnDismiss.Name = "bttnDismiss";
            this.bttnDismiss.Size = new System.Drawing.Size(200, 32);
            this.bttnDismiss.TabIndex = 22;
            this.bttnDismiss.Text = "Dismiss";
            this.bttnDismiss.UseVisualStyleBackColor = true;
            this.bttnDismiss.Click += new System.EventHandler(this.BttnDismiss_Click);
            // 
            // listvSearch
            // 
            this.listvSearch.BackColor = System.Drawing.Color.SeaShell;
            this.listvSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listvSearch.ForeColor = System.Drawing.Color.SaddleBrown;
            this.listvSearch.FullRowSelect = true;
            this.listvSearch.HideSelection = false;
            this.listvSearch.Location = new System.Drawing.Point(105, 164);
            this.listvSearch.Name = "listvSearch";
            this.listvSearch.Size = new System.Drawing.Size(664, 139);
            this.listvSearch.TabIndex = 23;
            this.listvSearch.UseCompatibleStateImageBehavior = false;
            this.listvSearch.SelectedIndexChanged += new System.EventHandler(this.ListvSearch_SelectedIndexChanged);
            // 
            // txbSearch
            // 
            this.txbSearch.BackColor = System.Drawing.Color.SeaShell;
            this.txbSearch.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txbSearch.Location = new System.Drawing.Point(236, 123);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(200, 22);
            this.txbSearch.TabIndex = 24;
            this.txbSearch.TextChanged += new System.EventHandler(this.FilterTxt_TextChanged);
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
            this.rbttn1.CheckedChanged += new System.EventHandler(this.Bttn_CheckedChanged);
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
            this.rbttn2.CheckedChanged += new System.EventHandler(this.Bttn_CheckedChanged);
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
            this.rbttn3.CheckedChanged += new System.EventHandler(this.Bttn_CheckedChanged);
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
            this.rbttn4.CheckedChanged += new System.EventHandler(this.Bttn_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SandyBrown;
            this.groupBox1.Controls.Add(this.rbttn4);
            this.groupBox1.Controls.Add(this.rbttn3);
            this.groupBox1.Controls.Add(this.rbttn2);
            this.groupBox1.Controls.Add(this.rbttn1);
            this.groupBox1.Location = new System.Drawing.Point(232, 318);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 43);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.CalendarForeColor = System.Drawing.Color.SaddleBrown;
            this.dtpStartTime.CustomFormat = "HH:mm:ss";
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartTime.Location = new System.Drawing.Point(236, 384);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.ShowUpDown = true;
            this.dtpStartTime.Size = new System.Drawing.Size(200, 22);
            this.dtpStartTime.TabIndex = 25;
            this.dtpStartTime.Value = new System.DateTime(2021, 6, 23, 12, 2, 34, 0);
            this.dtpStartTime.ValueChanged += new System.EventHandler(this.DtpValueChanged);
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.CalendarForeColor = System.Drawing.Color.SaddleBrown;
            this.dtpEndTime.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtpEndTime.CalendarTitleForeColor = System.Drawing.Color.SaddleBrown;
            this.dtpEndTime.CustomFormat = "HH:mm:ss";
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndTime.Location = new System.Drawing.Point(5, 4);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.ShowUpDown = true;
            this.dtpEndTime.Size = new System.Drawing.Size(200, 22);
            this.dtpEndTime.TabIndex = 25;
            this.dtpEndTime.Value = new System.DateTime(2021, 6, 23, 12, 2, 41, 0);
            this.dtpEndTime.ValueChanged += new System.EventHandler(this.DtpValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel1.Location = new System.Drawing.Point(232, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 28);
            this.panel1.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel2.Location = new System.Drawing.Point(100, 157);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(676, 153);
            this.panel2.TabIndex = 27;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel3.Location = new System.Drawing.Point(232, 380);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(210, 28);
            this.panel3.TabIndex = 28;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel4.Controls.Add(this.dtpEndTime);
            this.panel4.Location = new System.Drawing.Point(232, 429);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(210, 28);
            this.panel4.TabIndex = 29;
            // 
            // bttnUpdate
            // 
            this.bttnUpdate.BackColor = System.Drawing.Color.SandyBrown;
            this.bttnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnUpdate.ForeColor = System.Drawing.Color.SeaShell;
            this.bttnUpdate.Location = new System.Drawing.Point(214, 486);
            this.bttnUpdate.Name = "bttnUpdate";
            this.bttnUpdate.Size = new System.Drawing.Size(200, 32);
            this.bttnUpdate.TabIndex = 21;
            this.bttnUpdate.Text = "Update";
            this.bttnUpdate.UseVisualStyleBackColor = false;
            this.bttnUpdate.Click += new System.EventHandler(this.BttnUpdate_Click);
            // 
            // RiderTimes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(871, 539);
            this.Controls.Add(this.dtpStartTime);
            this.Controls.Add(this.listvSearch);
            this.Controls.Add(this.txbSearch);
            this.Controls.Add(this.bttnDismiss);
            this.Controls.Add(this.bttnUpdate);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblLegs);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblHeading2);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RiderTimes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RiderTimes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblHeading2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLegs;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Button bttnDismiss;
        private System.Windows.Forms.ListView listvSearch;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.RadioButton rbttn1;
        private System.Windows.Forms.RadioButton rbttn2;
        private System.Windows.Forms.RadioButton rbttn3;
        private System.Windows.Forms.RadioButton rbttn4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button bttnUpdate;
    }
}