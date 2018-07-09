namespace BlockedItems
{
   partial class DetailView
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
         this.IssueType = new System.Windows.Forms.Label();
         this.JIRAKey = new System.Windows.Forms.Label();
         this.JIRAStatus = new System.Windows.Forms.Label();
         this.JIRAAssignee = new System.Windows.Forms.Label();
         this.ItemCreated = new System.Windows.Forms.Label();
         this.NumberOfSprints = new System.Windows.Forms.Label();
         this.Initiative = new System.Windows.Forms.Label();
         this.EpicInformation = new System.Windows.Forms.Label();
         this.ShowNoChangeLog = new System.Windows.Forms.Label();
         this.SprintList = new System.Windows.Forms.ListView();
         this.HistoryData = new System.Windows.Forms.ListBox();
         this.BlockedHeader = new System.Windows.Forms.Label();
         this.BlockedList = new System.Windows.Forms.ListView();
         this.BlockedReason = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.UnblockTarget = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.WhoChanged = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.ChangeDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.JSONIZE = new System.Windows.Forms.Button();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.JSONBlocked = new System.Windows.Forms.RadioButton();
         this.JSONAllStatus = new System.Windows.Forms.RadioButton();
         this.groupBox1.SuspendLayout();
         this.SuspendLayout();
         // 
         // IssueType
         // 
         this.IssueType.AutoSize = true;
         this.IssueType.Location = new System.Drawing.Point(13, 26);
         this.IssueType.Name = "IssueType";
         this.IssueType.Size = new System.Drawing.Size(59, 13);
         this.IssueType.TabIndex = 0;
         this.IssueType.Text = "Issue Type";
         // 
         // JIRAKey
         // 
         this.JIRAKey.AutoSize = true;
         this.JIRAKey.Location = new System.Drawing.Point(13, 43);
         this.JIRAKey.Name = "JIRAKey";
         this.JIRAKey.Size = new System.Drawing.Size(53, 13);
         this.JIRAKey.TabIndex = 1;
         this.JIRAKey.Text = "Issue Key";
         // 
         // JIRAStatus
         // 
         this.JIRAStatus.AutoSize = true;
         this.JIRAStatus.Location = new System.Drawing.Point(137, 26);
         this.JIRAStatus.Name = "JIRAStatus";
         this.JIRAStatus.Size = new System.Drawing.Size(37, 13);
         this.JIRAStatus.TabIndex = 2;
         this.JIRAStatus.Text = "Status";
         // 
         // JIRAAssignee
         // 
         this.JIRAAssignee.AutoSize = true;
         this.JIRAAssignee.Location = new System.Drawing.Point(137, 42);
         this.JIRAAssignee.Name = "JIRAAssignee";
         this.JIRAAssignee.Size = new System.Drawing.Size(50, 13);
         this.JIRAAssignee.TabIndex = 4;
         this.JIRAAssignee.Text = "Assignee";
         // 
         // ItemCreated
         // 
         this.ItemCreated.AutoSize = true;
         this.ItemCreated.Location = new System.Drawing.Point(483, 26);
         this.ItemCreated.Name = "ItemCreated";
         this.ItemCreated.Size = new System.Drawing.Size(0, 13);
         this.ItemCreated.TabIndex = 5;
         // 
         // NumberOfSprints
         // 
         this.NumberOfSprints.AutoSize = true;
         this.NumberOfSprints.Location = new System.Drawing.Point(16, 105);
         this.NumberOfSprints.Name = "NumberOfSprints";
         this.NumberOfSprints.Size = new System.Drawing.Size(103, 13);
         this.NumberOfSprints.TabIndex = 7;
         this.NumberOfSprints.Text = "Number of Sprints: 0";
         // 
         // Initiative
         // 
         this.Initiative.AutoSize = true;
         this.Initiative.Location = new System.Drawing.Point(660, 25);
         this.Initiative.Name = "Initiative";
         this.Initiative.Size = new System.Drawing.Size(63, 13);
         this.Initiative.TabIndex = 10;
         this.Initiative.Text = "No Initiative";
         // 
         // EpicInformation
         // 
         this.EpicInformation.AutoSize = true;
         this.EpicInformation.Location = new System.Drawing.Point(660, 42);
         this.EpicInformation.Name = "EpicInformation";
         this.EpicInformation.Size = new System.Drawing.Size(45, 13);
         this.EpicInformation.TabIndex = 11;
         this.EpicInformation.Text = "No Epic";
         // 
         // ShowNoChangeLog
         // 
         this.ShowNoChangeLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.ShowNoChangeLog.AutoSize = true;
         this.ShowNoChangeLog.BackColor = System.Drawing.SystemColors.MenuHighlight;
         this.ShowNoChangeLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.ShowNoChangeLog.Font = new System.Drawing.Font("Tele-GroteskHal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.ShowNoChangeLog.ForeColor = System.Drawing.SystemColors.ControlLightLight;
         this.ShowNoChangeLog.Location = new System.Drawing.Point(925, 26);
         this.ShowNoChangeLog.MaximumSize = new System.Drawing.Size(120, 0);
         this.ShowNoChangeLog.Name = "ShowNoChangeLog";
         this.ShowNoChangeLog.Size = new System.Drawing.Size(115, 32);
         this.ShowNoChangeLog.TabIndex = 12;
         this.ShowNoChangeLog.Text = "Change Log not retrieved";
         this.ShowNoChangeLog.Visible = false;
         // 
         // SprintList
         // 
         this.SprintList.Location = new System.Drawing.Point(22, 125);
         this.SprintList.Name = "SprintList";
         this.SprintList.Size = new System.Drawing.Size(118, 165);
         this.SprintList.TabIndex = 13;
         this.SprintList.UseCompatibleStateImageBehavior = false;
         this.SprintList.View = System.Windows.Forms.View.List;
         // 
         // HistoryData
         // 
         this.HistoryData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.HistoryData.FormattingEnabled = true;
         this.HistoryData.Location = new System.Drawing.Point(20, 303);
         this.HistoryData.Name = "HistoryData";
         this.HistoryData.Size = new System.Drawing.Size(1025, 316);
         this.HistoryData.TabIndex = 14;
         // 
         // BlockedHeader
         // 
         this.BlockedHeader.AutoSize = true;
         this.BlockedHeader.Location = new System.Drawing.Point(175, 105);
         this.BlockedHeader.Name = "BlockedHeader";
         this.BlockedHeader.Size = new System.Drawing.Size(101, 13);
         this.BlockedHeader.TabIndex = 15;
         this.BlockedHeader.Text = "Item Never Blocked";
         // 
         // BlockedList
         // 
         this.BlockedList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.BlockedReason,
            this.UnblockTarget,
            this.WhoChanged,
            this.ChangeDate});
         this.BlockedList.GridLines = true;
         this.BlockedList.Location = new System.Drawing.Point(178, 125);
         this.BlockedList.Name = "BlockedList";
         this.BlockedList.Size = new System.Drawing.Size(752, 165);
         this.BlockedList.TabIndex = 16;
         this.BlockedList.UseCompatibleStateImageBehavior = false;
         this.BlockedList.View = System.Windows.Forms.View.Details;
         // 
         // BlockedReason
         // 
         this.BlockedReason.Text = "Blocked Reason";
         this.BlockedReason.Width = 135;
         // 
         // UnblockTarget
         // 
         this.UnblockTarget.Text = "Expected Unblocked Date";
         this.UnblockTarget.Width = 211;
         // 
         // WhoChanged
         // 
         this.WhoChanged.Text = "ChangedBy";
         this.WhoChanged.Width = 150;
         // 
         // ChangeDate
         // 
         this.ChangeDate.Text = "Change Date";
         this.ChangeDate.Width = 250;
         // 
         // JSONIZE
         // 
         this.JSONIZE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.JSONIZE.Location = new System.Drawing.Point(10, 130);
         this.JSONIZE.Name = "JSONIZE";
         this.JSONIZE.Size = new System.Drawing.Size(83, 23);
         this.JSONIZE.TabIndex = 17;
         this.JSONIZE.Text = "Export";
         this.JSONIZE.UseVisualStyleBackColor = true;
         this.JSONIZE.Click += new System.EventHandler(this.JSONIZE_Click);
         // 
         // groupBox1
         // 
         this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.groupBox1.Controls.Add(this.JSONBlocked);
         this.groupBox1.Controls.Add(this.JSONAllStatus);
         this.groupBox1.Controls.Add(this.JSONIZE);
         this.groupBox1.Location = new System.Drawing.Point(937, 125);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(103, 165);
         this.groupBox1.TabIndex = 18;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "JSON Output";
         // 
         // JSONBlocked
         // 
         this.JSONBlocked.AutoSize = true;
         this.JSONBlocked.Location = new System.Drawing.Point(7, 44);
         this.JSONBlocked.Name = "JSONBlocked";
         this.JSONBlocked.Size = new System.Drawing.Size(64, 17);
         this.JSONBlocked.TabIndex = 19;
         this.JSONBlocked.TabStop = true;
         this.JSONBlocked.Text = "Blocked";
         this.JSONBlocked.UseVisualStyleBackColor = true;
         // 
         // JSONAllStatus
         // 
         this.JSONAllStatus.AutoSize = true;
         this.JSONAllStatus.Checked = true;
         this.JSONAllStatus.Location = new System.Drawing.Point(7, 20);
         this.JSONAllStatus.Name = "JSONAllStatus";
         this.JSONAllStatus.Size = new System.Drawing.Size(80, 17);
         this.JSONAllStatus.TabIndex = 18;
         this.JSONAllStatus.TabStop = true;
         this.JSONAllStatus.Text = "All Statuses";
         this.JSONAllStatus.UseVisualStyleBackColor = true;
         // 
         // DetailView
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1067, 644);
         this.Controls.Add(this.groupBox1);
         this.Controls.Add(this.BlockedList);
         this.Controls.Add(this.BlockedHeader);
         this.Controls.Add(this.HistoryData);
         this.Controls.Add(this.SprintList);
         this.Controls.Add(this.ShowNoChangeLog);
         this.Controls.Add(this.EpicInformation);
         this.Controls.Add(this.Initiative);
         this.Controls.Add(this.NumberOfSprints);
         this.Controls.Add(this.ItemCreated);
         this.Controls.Add(this.JIRAAssignee);
         this.Controls.Add(this.JIRAStatus);
         this.Controls.Add(this.JIRAKey);
         this.Controls.Add(this.IssueType);
         this.Name = "DetailView";
         this.Text = "DetailView";
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label IssueType;
      private System.Windows.Forms.Label JIRAKey;
      private System.Windows.Forms.Label JIRAStatus;
      private System.Windows.Forms.Label JIRAAssignee;
      private System.Windows.Forms.Label ItemCreated;
      private System.Windows.Forms.Label NumberOfSprints;
      private System.Windows.Forms.Label Initiative;
      private System.Windows.Forms.Label EpicInformation;
      private System.Windows.Forms.Label ShowNoChangeLog;
      private System.Windows.Forms.ListView SprintList;
      private System.Windows.Forms.ListBox HistoryData;
      private System.Windows.Forms.Label BlockedHeader;
      private System.Windows.Forms.ListView BlockedList;
      private System.Windows.Forms.ColumnHeader BlockedReason;
      private System.Windows.Forms.ColumnHeader UnblockTarget;
      private System.Windows.Forms.ColumnHeader ChangeDate;
      private System.Windows.Forms.ColumnHeader WhoChanged;
      private System.Windows.Forms.Button JSONIZE;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.RadioButton JSONBlocked;
      private System.Windows.Forms.RadioButton JSONAllStatus;
   }
}