
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblHeading2 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLegs = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.bttnUpdate = new System.Windows.Forms.Button();
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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(241, 23);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(437, 29);
            this.lblHeading.TabIndex = 3;
            this.lblHeading.Text = "Cross Country Mountain Biking Race";
            // 
            // lblHeading2
            // 
            this.lblHeading2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading2.Location = new System.Drawing.Point(46, 62);
            this.lblHeading2.Name = "lblHeading2";
            this.lblHeading2.Size = new System.Drawing.Size(832, 49);
            this.lblHeading2.TabIndex = 4;
            this.lblHeading2.Text = "Please enter the rider\'s race results such as their start and end times for a spe" +
    "cific leg";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(46, 123);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(125, 20);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Search Rider:";
            // 
            // lblLegs
            // 
            this.lblLegs.AutoSize = true;
            this.lblLegs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLegs.Location = new System.Drawing.Point(46, 285);
            this.lblLegs.Name = "lblLegs";
            this.lblLegs.Size = new System.Drawing.Size(115, 20);
            this.lblLegs.TabIndex = 14;
            this.lblLegs.Text = "Choose Leg:";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnd.Location = new System.Drawing.Point(46, 408);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(94, 20);
            this.lblEnd.TabIndex = 17;
            this.lblEnd.Text = "End Time:";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.Location = new System.Drawing.Point(46, 352);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(103, 20);
            this.lblStart.TabIndex = 18;
            this.lblStart.Text = "Start Time:";
            // 
            // bttnUpdate
            // 
            this.bttnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnUpdate.Location = new System.Drawing.Point(305, 450);
            this.bttnUpdate.Name = "bttnUpdate";
            this.bttnUpdate.Size = new System.Drawing.Size(193, 32);
            this.bttnUpdate.TabIndex = 21;
            this.bttnUpdate.Text = "Update";
            this.bttnUpdate.UseVisualStyleBackColor = true;
            this.bttnUpdate.Click += new System.EventHandler(this.BttnUpdate_Click);
            // 
            // bttnDismiss
            // 
            this.bttnDismiss.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnDismiss.Location = new System.Drawing.Point(532, 450);
            this.bttnDismiss.Name = "bttnDismiss";
            this.bttnDismiss.Size = new System.Drawing.Size(217, 32);
            this.bttnDismiss.TabIndex = 22;
            this.bttnDismiss.Text = "Dismiss";
            this.bttnDismiss.UseVisualStyleBackColor = true;
            this.bttnDismiss.Click += new System.EventHandler(this.BttnDismiss_Click);
            // 
            // listvSearch
            // 
            this.listvSearch.HideSelection = false;
            this.listvSearch.Location = new System.Drawing.Point(40, 161);
            this.listvSearch.Name = "listvSearch";
            this.listvSearch.Size = new System.Drawing.Size(838, 100);
            this.listvSearch.TabIndex = 23;
            this.listvSearch.UseCompatibleStateImageBehavior = false;
            this.listvSearch.SelectedIndexChanged += new System.EventHandler(this.ListvSearch_SelectedIndexChanged);
            // 
            // txbSearch
            // 
            this.txbSearch.Location = new System.Drawing.Point(191, 123);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(232, 22);
            this.txbSearch.TabIndex = 24;
            this.txbSearch.TextChanged += new System.EventHandler(this.FilterTxt_TextChanged);
            // 
            // rbttn1
            // 
            this.rbttn1.AutoSize = true;
            this.rbttn1.Location = new System.Drawing.Point(7, 17);
            this.rbttn1.Name = "rbttn1";
            this.rbttn1.Size = new System.Drawing.Size(65, 21);
            this.rbttn1.TabIndex = 0;
            this.rbttn1.TabStop = true;
            this.rbttn1.Text = "Leg 1";
            this.rbttn1.UseVisualStyleBackColor = true;
            this.rbttn1.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rbttn2
            // 
            this.rbttn2.AutoSize = true;
            this.rbttn2.Location = new System.Drawing.Point(78, 17);
            this.rbttn2.Name = "rbttn2";
            this.rbttn2.Size = new System.Drawing.Size(65, 21);
            this.rbttn2.TabIndex = 1;
            this.rbttn2.TabStop = true;
            this.rbttn2.Text = "Leg 2";
            this.rbttn2.UseVisualStyleBackColor = true;
            // 
            // rbttn3
            // 
            this.rbttn3.AutoSize = true;
            this.rbttn3.Location = new System.Drawing.Point(145, 17);
            this.rbttn3.Name = "rbttn3";
            this.rbttn3.Size = new System.Drawing.Size(65, 21);
            this.rbttn3.TabIndex = 2;
            this.rbttn3.TabStop = true;
            this.rbttn3.Text = "Leg 3";
            this.rbttn3.UseVisualStyleBackColor = true;
            // 
            // rbttn4
            // 
            this.rbttn4.AutoSize = true;
            this.rbttn4.Location = new System.Drawing.Point(212, 17);
            this.rbttn4.Name = "rbttn4";
            this.rbttn4.Size = new System.Drawing.Size(65, 21);
            this.rbttn4.TabIndex = 3;
            this.rbttn4.TabStop = true;
            this.rbttn4.Text = "Leg 4";
            this.rbttn4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbttn4);
            this.groupBox1.Controls.Add(this.rbttn3);
            this.groupBox1.Controls.Add(this.rbttn2);
            this.groupBox1.Controls.Add(this.rbttn1);
            this.groupBox1.Location = new System.Drawing.Point(181, 272);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 53);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.CustomFormat = "HH:mm:ss";
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartTime.Location = new System.Drawing.Point(181, 352);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.ShowUpDown = true;
            this.dtpStartTime.Size = new System.Drawing.Size(200, 22);
            this.dtpStartTime.TabIndex = 25;
            this.dtpStartTime.Value = new System.DateTime(2021, 6, 23, 12, 2, 34, 0);
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.CustomFormat = "HH:mm:ss";
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEndTime.Location = new System.Drawing.Point(181, 408);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.ShowUpDown = true;
            this.dtpEndTime.Size = new System.Drawing.Size(200, 22);
            this.dtpEndTime.TabIndex = 25;
            this.dtpEndTime.Value = new System.DateTime(2021, 6, 23, 12, 2, 41, 0);
            // 
            // RiderTimes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 503);
            this.Controls.Add(this.dtpEndTime);
            this.Controls.Add(this.dtpStartTime);
            this.Controls.Add(this.listvSearch);
            this.Controls.Add(this.txbSearch);
            this.Controls.Add(this.bttnDismiss);
            this.Controls.Add(this.bttnUpdate);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblLegs);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblHeading2);
            this.Controls.Add(this.lblHeading);
            this.Name = "RiderTimes";
            this.Text = "RiderTimes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Button bttnUpdate;
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
    }
}