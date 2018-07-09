namespace BlockedItems
{
   partial class SolutionParent
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
         this.pickFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.postJSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.postStoryChangesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.postSprintChangesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.menuStrip1.SuspendLayout();
         this.SuspendLayout();
         // 
         // menuStrip1
         // 
         this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pickFormToolStripMenuItem});
         this.menuStrip1.Location = new System.Drawing.Point(0, 0);
         this.menuStrip1.Name = "menuStrip1";
         this.menuStrip1.Size = new System.Drawing.Size(800, 24);
         this.menuStrip1.TabIndex = 1;
         this.menuStrip1.Text = "menuStrip1";
         // 
         // pickFormToolStripMenuItem
         // 
         this.pickFormToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem,
            this.postJSONToolStripMenuItem});
         this.pickFormToolStripMenuItem.Name = "pickFormToolStripMenuItem";
         this.pickFormToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
         this.pickFormToolStripMenuItem.Text = "Pick Form";
         // 
         // mainToolStripMenuItem
         // 
         this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
         this.mainToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
         this.mainToolStripMenuItem.Text = "Main";
         this.mainToolStripMenuItem.Click += new System.EventHandler(this.mainToolStripMenuItem_Click);
         // 
         // postJSONToolStripMenuItem
         // 
         this.postJSONToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.postStoryChangesToolStripMenuItem,
            this.postSprintChangesToolStripMenuItem});
         this.postJSONToolStripMenuItem.Name = "postJSONToolStripMenuItem";
         this.postJSONToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
         this.postJSONToolStripMenuItem.Text = "Post JSON";
         // 
         // postStoryChangesToolStripMenuItem
         // 
         this.postStoryChangesToolStripMenuItem.Name = "postStoryChangesToolStripMenuItem";
         this.postStoryChangesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
         this.postStoryChangesToolStripMenuItem.Text = "Post Story Changes";
         this.postStoryChangesToolStripMenuItem.Click += new System.EventHandler(this.postStoryChangesToolStripMenuItem_Click);
         // 
         // postSprintChangesToolStripMenuItem
         // 
         this.postSprintChangesToolStripMenuItem.Name = "postSprintChangesToolStripMenuItem";
         this.postSprintChangesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
         this.postSprintChangesToolStripMenuItem.Text = "Post Sprint Changes";
         this.postSprintChangesToolStripMenuItem.Click += new System.EventHandler(this.postSprintChangesToolStripMenuItem_Click);
         // 
         // SolutionParent
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.menuStrip1);
         this.IsMdiContainer = true;
         this.MainMenuStrip = this.menuStrip1;
         this.Name = "SolutionParent";
         this.Text = "Form1";
         this.menuStrip1.ResumeLayout(false);
         this.menuStrip1.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.MenuStrip menuStrip1;
      private System.Windows.Forms.ToolStripMenuItem pickFormToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem mainToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem postJSONToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem postStoryChangesToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem postSprintChangesToolStripMenuItem;
   }
}