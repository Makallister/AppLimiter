namespace AppLimiter
{
    partial class MainScreen
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
            this.NewRestriction = new System.Windows.Forms.Button();
            this.EditRestriction = new System.Windows.Forms.Button();
            this.ManageWorker = new System.Windows.Forms.Button();
            this.ViewUsage = new System.Windows.Forms.Button();
            this.MainScreenMenuStrip = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notificationSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.warningSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainScreenMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewRestriction
            // 
            this.NewRestriction.Location = new System.Drawing.Point(53, 90);
            this.NewRestriction.Name = "NewRestriction";
            this.NewRestriction.Size = new System.Drawing.Size(153, 23);
            this.NewRestriction.TabIndex = 0;
            this.NewRestriction.Text = "Create New restriction";
            this.NewRestriction.UseVisualStyleBackColor = true;
            this.NewRestriction.Click += new System.EventHandler(this.NewRestriction_Click);
            // 
            // EditRestriction
            // 
            this.EditRestriction.Location = new System.Drawing.Point(53, 136);
            this.EditRestriction.Name = "EditRestriction";
            this.EditRestriction.Size = new System.Drawing.Size(153, 23);
            this.EditRestriction.TabIndex = 1;
            this.EditRestriction.Text = "Edit Restriction";
            this.EditRestriction.UseVisualStyleBackColor = true;
            // 
            // ManageWorker
            // 
            this.ManageWorker.Location = new System.Drawing.Point(53, 179);
            this.ManageWorker.Name = "ManageWorker";
            this.ManageWorker.Size = new System.Drawing.Size(153, 23);
            this.ManageWorker.TabIndex = 2;
            this.ManageWorker.Text = "Manage Workers";
            this.ManageWorker.UseVisualStyleBackColor = true;
            // 
            // ViewUsage
            // 
            this.ViewUsage.Location = new System.Drawing.Point(53, 228);
            this.ViewUsage.Name = "ViewUsage";
            this.ViewUsage.Size = new System.Drawing.Size(153, 23);
            this.ViewUsage.TabIndex = 3;
            this.ViewUsage.Text = "View Restricted Usage";
            this.ViewUsage.UseVisualStyleBackColor = true;
            // 
            // MainScreenMenuStrip
            // 
            this.MainScreenMenuStrip.Dock = System.Windows.Forms.DockStyle.Right;
            this.MainScreenMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.MainScreenMenuStrip.Location = new System.Drawing.Point(572, 0);
            this.MainScreenMenuStrip.Name = "MainScreenMenuStrip";
            this.MainScreenMenuStrip.Size = new System.Drawing.Size(67, 434);
            this.MainScreenMenuStrip.TabIndex = 4;
            this.MainScreenMenuStrip.Text = "MenuStrip";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notificationSettingsToolStripMenuItem,
            this.warningSettingsToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(54, 19);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // notificationSettingsToolStripMenuItem
            // 
            this.notificationSettingsToolStripMenuItem.Name = "notificationSettingsToolStripMenuItem";
            this.notificationSettingsToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.notificationSettingsToolStripMenuItem.Text = "Notification Settings";
            // 
            // warningSettingsToolStripMenuItem
            // 
            this.warningSettingsToolStripMenuItem.Name = "warningSettingsToolStripMenuItem";
            this.warningSettingsToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.warningSettingsToolStripMenuItem.Text = "Warning Settings";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 434);
            this.Controls.Add(this.ViewUsage);
            this.Controls.Add(this.ManageWorker);
            this.Controls.Add(this.EditRestriction);
            this.Controls.Add(this.NewRestriction);
            this.Controls.Add(this.MainScreenMenuStrip);
            this.Name = "MainScreen";
            this.Text = "AppLimiter";
            this.MainScreenMenuStrip.ResumeLayout(false);
            this.MainScreenMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewRestriction;
        private System.Windows.Forms.Button EditRestriction;
        private System.Windows.Forms.Button ManageWorker;
        private System.Windows.Forms.Button ViewUsage;
        private System.Windows.Forms.MenuStrip MainScreenMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notificationSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem warningSettingsToolStripMenuItem;
    }
}

