namespace Launcher
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.mainMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newMeetingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainIcon
            // 
            this.mainIcon.ContextMenuStrip = this.mainMenu;
            this.mainIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("mainIcon.Icon")));
            this.mainIcon.Text = "Google Meet Launcher";
            this.mainIcon.Visible = true;
            this.mainIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.newMeetingToolStripMenuItem, this.exitToolStripMenuItem });
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(146, 48);
            // 
            // newMeetingToolStripMenuItem
            // 
            this.newMeetingToolStripMenuItem.Name = "newMeetingToolStripMenuItem";
            this.newMeetingToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.newMeetingToolStripMenuItem.Text = "New Meeting";
            this.newMeetingToolStripMenuItem.Click += new System.EventHandler(this.newMeetingToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Google Meeting Launcher";
            this.ShowInTaskbar = false;
            this.Text = "Google Meeting Launcher";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.mainMenu.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ContextMenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem newMeetingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;

        private System.Windows.Forms.NotifyIcon mainIcon;

        #endregion
    }
}