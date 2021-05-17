
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.riderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRiderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRaceTimesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allCompetitorResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.riderToolStripMenuItem,
            this.allCompetitorResultsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(654, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
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
            this.addRiderToolStripMenuItem.Click += new System.EventHandler(this.addRiderToolStripMenuItem_Click);
            // 
            // addRaceTimesToolStripMenuItem
            // 
            this.addRaceTimesToolStripMenuItem.Name = "addRaceTimesToolStripMenuItem";
            this.addRaceTimesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addRaceTimesToolStripMenuItem.Text = "Add RiderTimes";
            this.addRaceTimesToolStripMenuItem.Click += new System.EventHandler(this.addRaceTimesToolStripMenuItem_Click);
            // 
            // allCompetitorResultsToolStripMenuItem
            // 
            this.allCompetitorResultsToolStripMenuItem.Name = "allCompetitorResultsToolStripMenuItem";
            this.allCompetitorResultsToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.allCompetitorResultsToolStripMenuItem.Text = "All Competitor Results";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(110, 42);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(437, 29);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Cross Country Mountain Biking Race";
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 450);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Homepage";
            this.Text = "Homepage";
            this.Load += new System.EventHandler(this.Homepage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem riderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRiderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRaceTimesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allCompetitorResultsToolStripMenuItem;
        private System.Windows.Forms.Label lbl1;
    }
}

