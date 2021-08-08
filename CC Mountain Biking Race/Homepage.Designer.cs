
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            this.lbl1 = new System.Windows.Forms.Label();
            this.listvRiderSearch = new System.Windows.Forms.ListView();
            this.txbRiderSearch = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.allCompetitorResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addRiderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRaceTimesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listvScoreBoard = new System.Windows.Forms.ListView();
            this.cbxLegs = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.SandyBrown;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl1.Location = new System.Drawing.Point(178, 42);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(512, 32);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Cross Country Mountain Biking Race";
            // 
            // listvRiderSearch
            // 
            this.listvRiderSearch.BackColor = System.Drawing.Color.SeaShell;
            this.listvRiderSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listvRiderSearch.ForeColor = System.Drawing.Color.SaddleBrown;
            this.listvRiderSearch.FullRowSelect = true;
            this.listvRiderSearch.HideSelection = false;
            this.listvRiderSearch.Location = new System.Drawing.Point(171, 166);
            this.listvRiderSearch.Name = "listvRiderSearch";
            this.listvRiderSearch.Size = new System.Drawing.Size(192, 333);
            this.listvRiderSearch.TabIndex = 23;
            this.listvRiderSearch.UseCompatibleStateImageBehavior = false;
            this.listvRiderSearch.SelectedIndexChanged += new System.EventHandler(this.ListvRiderSearch_SelectedIndexChanged);
            // 
            // txbRiderSearch
            // 
            this.txbRiderSearch.BackColor = System.Drawing.Color.SeaShell;
            this.txbRiderSearch.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txbRiderSearch.Location = new System.Drawing.Point(172, 102);
            this.txbRiderSearch.Name = "txbRiderSearch";
            this.txbRiderSearch.Size = new System.Drawing.Size(192, 22);
            this.txbRiderSearch.TabIndex = 24;
            this.txbRiderSearch.TextChanged += new System.EventHandler(this.FilterName_TextChanged);
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.SandyBrown;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.SeaShell;
            this.lblName.Location = new System.Drawing.Point(11, 100);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(150, 28);
            this.lblName.TabIndex = 25;
            this.lblName.Text = "Search Rider:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // allCompetitorResultsToolStripMenuItem
            // 
            this.allCompetitorResultsToolStripMenuItem.ForeColor = System.Drawing.Color.SaddleBrown;
            this.allCompetitorResultsToolStripMenuItem.Name = "allCompetitorResultsToolStripMenuItem";
            this.allCompetitorResultsToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.allCompetitorResultsToolStripMenuItem.Text = "All Competitor Results";
            this.allCompetitorResultsToolStripMenuItem.Click += new System.EventHandler(this.AllCompetitorResultsToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SandyBrown;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRiderToolStripMenuItem,
            this.addRaceTimesToolStripMenuItem,
            this.allCompetitorResultsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(886, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addRiderToolStripMenuItem
            // 
            this.addRiderToolStripMenuItem.ForeColor = System.Drawing.Color.SaddleBrown;
            this.addRiderToolStripMenuItem.Name = "addRiderToolStripMenuItem";
            this.addRiderToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.addRiderToolStripMenuItem.Text = "Add Rider";
            this.addRiderToolStripMenuItem.Click += new System.EventHandler(this.AddRiderToolStripMenuItem_Click_1);
            // 
            // addRaceTimesToolStripMenuItem
            // 
            this.addRaceTimesToolStripMenuItem.ForeColor = System.Drawing.Color.SaddleBrown;
            this.addRaceTimesToolStripMenuItem.Name = "addRaceTimesToolStripMenuItem";
            this.addRaceTimesToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.addRaceTimesToolStripMenuItem.Text = "Add Rider Times";
            this.addRaceTimesToolStripMenuItem.Click += new System.EventHandler(this.AddRaceTimesToolStripMenuItem_Click_1);
            // 
            // listvScoreBoard
            // 
            this.listvScoreBoard.BackColor = System.Drawing.Color.SeaShell;
            this.listvScoreBoard.Enabled = false;
            this.listvScoreBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listvScoreBoard.ForeColor = System.Drawing.Color.SaddleBrown;
            this.listvScoreBoard.HideSelection = false;
            this.listvScoreBoard.Location = new System.Drawing.Point(396, 166);
            this.listvScoreBoard.Name = "listvScoreBoard";
            this.listvScoreBoard.Size = new System.Drawing.Size(475, 333);
            this.listvScoreBoard.TabIndex = 28;
            this.listvScoreBoard.UseCompatibleStateImageBehavior = false;
            // 
            // cbxLegs
            // 
            this.cbxLegs.BackColor = System.Drawing.Color.SeaShell;
            this.cbxLegs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLegs.ForeColor = System.Drawing.Color.SaddleBrown;
            this.cbxLegs.FormattingEnabled = true;
            this.cbxLegs.Items.AddRange(new object[] {
            "Leg 1",
            "Leg 2",
            "Leg 3",
            "Leg 4"});
            this.cbxLegs.Location = new System.Drawing.Point(664, 101);
            this.cbxLegs.Name = "cbxLegs";
            this.cbxLegs.Size = new System.Drawing.Size(191, 24);
            this.cbxLegs.TabIndex = 29;
            this.cbxLegs.SelectedIndexChanged += new System.EventHandler(this.CbxLegs_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SandyBrown;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaShell;
            this.label1.Location = new System.Drawing.Point(392, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 28);
            this.label1.TabIndex = 27;
            this.label1.Text = "Leg Results:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(668, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Select Legs";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel2.Location = new System.Drawing.Point(390, 162);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(487, 343);
            this.panel2.TabIndex = 31;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel1.Location = new System.Drawing.Point(166, 162);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 343);
            this.panel1.TabIndex = 32;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel3.Location = new System.Drawing.Point(167, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(202, 31);
            this.panel3.TabIndex = 33;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel4.Location = new System.Drawing.Point(658, 97);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(203, 33);
            this.panel4.TabIndex = 34;
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(886, 539);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxLegs);
            this.Controls.Add(this.listvScoreBoard);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txbRiderSearch);
            this.Controls.Add(this.listvRiderSearch);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Homepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.ToolStripMenuItem allCompetitorResultsToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ListView listvScoreBoard;
        private System.Windows.Forms.ComboBox cbxLegs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem addRiderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRaceTimesToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}

