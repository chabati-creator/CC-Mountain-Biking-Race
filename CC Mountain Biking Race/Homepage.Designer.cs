
namespace CC_Mountain_Biking_Race
{
    partial class Homepage
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.listvRiderSearch = new System.Windows.Forms.ListView();
            this.txbRiderSearch = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.riderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRiderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRaceTimesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allCompetitorResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rtbIndScoreboard = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(213, 45);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(437, 29);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Cross Country Mountain Biking Race";
            // 
            // listvRiderSearch
            // 
            this.listvRiderSearch.HideSelection = false;
            this.listvRiderSearch.Location = new System.Drawing.Point(184, 139);
            this.listvRiderSearch.Name = "listvRiderSearch";
            this.listvRiderSearch.Size = new System.Drawing.Size(180, 289);
            this.listvRiderSearch.TabIndex = 23;
            this.listvRiderSearch.UseCompatibleStateImageBehavior = false;
            this.listvRiderSearch.SelectedIndexChanged += new System.EventHandler(this.ListvRiderSearch_SelectedIndexChanged);
            // 
            // txbRiderSearch
            // 
            this.txbRiderSearch.Location = new System.Drawing.Point(184, 97);
            this.txbRiderSearch.Name = "txbRiderSearch";
            this.txbRiderSearch.Size = new System.Drawing.Size(180, 22);
            this.txbRiderSearch.TabIndex = 24;
            this.txbRiderSearch.TextChanged += new System.EventHandler(this.FilterName_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(33, 97);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(125, 20);
            this.lblName.TabIndex = 25;
            this.lblName.Text = "Search Rider:";
            // 
            // riderToolStripMenuItem
            // 
            this.riderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRiderToolStripMenuItem,
            this.addRaceTimesToolStripMenuItem});
            this.riderToolStripMenuItem.Name = "riderToolStripMenuItem";
            this.riderToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.riderToolStripMenuItem.Text = "Rider";
            // 
            // addRiderToolStripMenuItem
            // 
            this.addRiderToolStripMenuItem.Name = "addRiderToolStripMenuItem";
            this.addRiderToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addRiderToolStripMenuItem.Text = "Add Rider";
            this.addRiderToolStripMenuItem.Click += new System.EventHandler(this.AddRiderToolStripMenuItem_Click);
            // 
            // addRaceTimesToolStripMenuItem
            // 
            this.addRaceTimesToolStripMenuItem.Name = "addRaceTimesToolStripMenuItem";
            this.addRaceTimesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addRaceTimesToolStripMenuItem.Text = "Add RiderTimes";
            this.addRaceTimesToolStripMenuItem.Click += new System.EventHandler(this.AddRaceTimesToolStripMenuItem_Click);
            // 
            // allCompetitorResultsToolStripMenuItem
            // 
            this.allCompetitorResultsToolStripMenuItem.Name = "allCompetitorResultsToolStripMenuItem";
            this.allCompetitorResultsToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.allCompetitorResultsToolStripMenuItem.Text = "All Competitor Results";
            this.allCompetitorResultsToolStripMenuItem.Click += new System.EventHandler(this.AllCompetitorResultsToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.riderToolStripMenuItem,
            this.allCompetitorResultsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(883, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rtbIndScoreboard
            // 
            this.rtbIndScoreboard.Location = new System.Drawing.Point(390, 139);
            this.rtbIndScoreboard.Name = "rtbIndScoreboard";
            this.rtbIndScoreboard.Size = new System.Drawing.Size(358, 289);
            this.rtbIndScoreboard.TabIndex = 26;
            this.rtbIndScoreboard.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(471, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Individual Scoreboard";
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 440);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbIndScoreboard);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txbRiderSearch);
            this.Controls.Add(this.listvRiderSearch);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Homepage";
            this.Text = "Homepage";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.ListView listvRiderSearch;
        private System.Windows.Forms.TextBox txbRiderSearch;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ToolStripMenuItem riderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRiderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRaceTimesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allCompetitorResultsToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.RichTextBox rtbIndScoreboard;
        private System.Windows.Forms.Label label1;
    }
}

