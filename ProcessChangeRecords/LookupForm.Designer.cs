namespace BlockedItems
{
   partial class LookupForm
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
         this.splitContainer1 = new System.Windows.Forms.SplitContainer();
         this.btnLaunchPostJSON = new System.Windows.Forms.Button();
         this.ExportProgressBar = new NewProgressBar();
         this.groupBox2 = new System.Windows.Forms.GroupBox();
         this.StartAt = new System.Windows.Forms.TextBox();
         this.label5 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.MaxRecords = new System.Windows.Forms.TextBox();
         this.panel1 = new System.Windows.Forms.Panel();
         this.Choose661 = new System.Windows.Forms.Button();
         this.PopulateBlockedMine = new System.Windows.Forms.Button();
         this.PopulateBlockedAOP = new System.Windows.Forms.Button();
         this.PopulateInitiative = new System.Windows.Forms.Button();
         this.PopulateNoInit = new System.Windows.Forms.Button();
         this.JQLValue = new System.Windows.Forms.TextBox();
         this.UseJQL = new System.Windows.Forms.RadioButton();
         this.label3 = new System.Windows.Forms.Label();
         this.SearchURI = new System.Windows.Forms.Button();
         this.ExecutionURI = new System.Windows.Forms.TextBox();
         this.FilterID = new System.Windows.Forms.TextBox();
         this.SearchButton = new System.Windows.Forms.Button();
         this.UseFilter = new System.Windows.Forms.RadioButton();
         this.BlockedOnly = new System.Windows.Forms.CheckBox();
         this.CheckChangeLog = new System.Windows.Forms.CheckBox();
         this.JIRAKeyValue = new System.Windows.Forms.TextBox();
         this.UseKeyValue = new System.Windows.Forms.RadioButton();
         this.UseTMobile = new System.Windows.Forms.RadioButton();
         this.ShowNoBlocked = new System.Windows.Forms.Label();
         this.UseSeaTransplant = new System.Windows.Forms.RadioButton();
         this.PasswordField = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.UserNameField = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.groupBox3 = new System.Windows.Forms.GroupBox();
         this.AllHistoryRecordsJSON = new System.Windows.Forms.RadioButton();
         this.BlockedChangeRecordsOnlyJSON = new System.Windows.Forms.RadioButton();
         this.JSONNoHistoryRecords = new System.Windows.Forms.RadioButton();
         this.ExportAllRecords = new System.Windows.Forms.Button();
         this.DetailChangeLog = new System.Windows.Forms.CheckBox();
         this.ShowItemDetails = new System.Windows.Forms.Button();
         this.ReturnedJSON = new System.Windows.Forms.TextBox();
         this.ListOfResults = new System.Windows.Forms.ListView();
         this.JiraKey = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.Summary = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.BlockedReason = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.JQLWarning = new System.Windows.Forms.ToolTip(this.components);
         ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
         this.splitContainer1.Panel1.SuspendLayout();
         this.splitContainer1.Panel2.SuspendLayout();
         this.splitContainer1.SuspendLayout();
         this.groupBox2.SuspendLayout();
         this.panel1.SuspendLayout();
         this.groupBox1.SuspendLayout();
         this.groupBox3.SuspendLayout();
         this.SuspendLayout();
         // 
         // splitContainer1
         // 
         this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.splitContainer1.Location = new System.Drawing.Point(11, 12);
         this.splitContainer1.Name = "splitContainer1";
         this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
         // 
         // splitContainer1.Panel1
         // 
         this.splitContainer1.Panel1.Controls.Add(this.btnLaunchPostJSON);
         this.splitContainer1.Panel1.Controls.Add(this.ExportProgressBar);
         this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
         this.splitContainer1.Panel1.Controls.Add(this.UseTMobile);
         this.splitContainer1.Panel1.Controls.Add(this.ShowNoBlocked);
         this.splitContainer1.Panel1.Controls.Add(this.UseSeaTransplant);
         this.splitContainer1.Panel1.Controls.Add(this.PasswordField);
         this.splitContainer1.Panel1.Controls.Add(this.label2);
         this.splitContainer1.Panel1.Controls.Add(this.UserNameField);
         this.splitContainer1.Panel1.Controls.Add(this.label1);
         // 
         // splitContainer1.Panel2
         // 
         this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
         this.splitContainer1.Panel2.Controls.Add(this.DetailChangeLog);
         this.splitContainer1.Panel2.Controls.Add(this.ShowItemDetails);
         this.splitContainer1.Panel2.Controls.Add(this.ReturnedJSON);
         this.splitContainer1.Panel2.Controls.Add(this.ListOfResults);
         this.splitContainer1.Size = new System.Drawing.Size(1162, 741);
         this.splitContainer1.SplitterDistance = 277;
         this.splitContainer1.TabIndex = 4;
         // 
         // btnLaunchPostJSON
         // 
         this.btnLaunchPostJSON.BackColor = System.Drawing.SystemColors.Info;
         this.btnLaunchPostJSON.Location = new System.Drawing.Point(1096, 12);
         this.btnLaunchPostJSON.Name = "btnLaunchPostJSON";
         this.btnLaunchPostJSON.Size = new System.Drawing.Size(19, 23);
         this.btnLaunchPostJSON.TabIndex = 15;
         this.btnLaunchPostJSON.Text = ">>";
         this.btnLaunchPostJSON.UseVisualStyleBackColor = false;
         this.btnLaunchPostJSON.Click += new System.EventHandler(this.BtnLaunchPostJSON_Click);
         // 
         // ExportProgressBar
         // 
         this.ExportProgressBar.ForeColor = System.Drawing.Color.Magenta;
         this.ExportProgressBar.Gradient = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
         this.ExportProgressBar.Inset = 5;
         this.ExportProgressBar.Location = new System.Drawing.Point(36, 243);
         this.ExportProgressBar.Name = "ExportProgressBar";
         this.ExportProgressBar.Size = new System.Drawing.Size(1064, 23);
         this.ExportProgressBar.Step = 1;
         this.ExportProgressBar.TabIndex = 11;
         this.ExportProgressBar.Visible = false;
         // 
         // groupBox2
         // 
         this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.groupBox2.Controls.Add(this.StartAt);
         this.groupBox2.Controls.Add(this.label5);
         this.groupBox2.Controls.Add(this.label4);
         this.groupBox2.Controls.Add(this.MaxRecords);
         this.groupBox2.Controls.Add(this.panel1);
         this.groupBox2.Controls.Add(this.JQLValue);
         this.groupBox2.Controls.Add(this.UseJQL);
         this.groupBox2.Controls.Add(this.label3);
         this.groupBox2.Controls.Add(this.SearchURI);
         this.groupBox2.Controls.Add(this.ExecutionURI);
         this.groupBox2.Controls.Add(this.FilterID);
         this.groupBox2.Controls.Add(this.SearchButton);
         this.groupBox2.Controls.Add(this.UseFilter);
         this.groupBox2.Controls.Add(this.BlockedOnly);
         this.groupBox2.Controls.Add(this.CheckChangeLog);
         this.groupBox2.Controls.Add(this.JIRAKeyValue);
         this.groupBox2.Controls.Add(this.UseKeyValue);
         this.groupBox2.Location = new System.Drawing.Point(12, 39);
         this.groupBox2.Name = "groupBox2";
         this.groupBox2.Size = new System.Drawing.Size(1137, 198);
         this.groupBox2.TabIndex = 14;
         this.groupBox2.TabStop = false;
         this.groupBox2.Text = "WhatToLookFor";
         // 
         // StartAt
         // 
         this.StartAt.Anchor = System.Windows.Forms.AnchorStyles.Right;
         this.StartAt.Location = new System.Drawing.Point(1094, 63);
         this.StartAt.Name = "StartAt";
         this.StartAt.Size = new System.Drawing.Size(30, 20);
         this.StartAt.TabIndex = 17;
         this.StartAt.Text = "0";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(1059, 66);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(29, 13);
         this.label5.TabIndex = 16;
         this.label5.Text = "Start";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(1061, 91);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(27, 13);
         this.label4.TabIndex = 15;
         this.label4.Text = "Max";
         // 
         // MaxRecords
         // 
         this.MaxRecords.Anchor = System.Windows.Forms.AnchorStyles.Right;
         this.MaxRecords.Location = new System.Drawing.Point(1094, 86);
         this.MaxRecords.Name = "MaxRecords";
         this.MaxRecords.Size = new System.Drawing.Size(30, 20);
         this.MaxRecords.TabIndex = 14;
         this.MaxRecords.Text = "50";
         // 
         // panel1
         // 
         this.panel1.Controls.Add(this.Choose661);
         this.panel1.Controls.Add(this.PopulateBlockedMine);
         this.panel1.Controls.Add(this.PopulateBlockedAOP);
         this.panel1.Controls.Add(this.PopulateInitiative);
         this.panel1.Controls.Add(this.PopulateNoInit);
         this.panel1.Location = new System.Drawing.Point(365, 21);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(351, 100);
         this.panel1.TabIndex = 13;
         // 
         // Choose661
         // 
         this.Choose661.Location = new System.Drawing.Point(181, 4);
         this.Choose661.Name = "Choose661";
         this.Choose661.Size = new System.Drawing.Size(160, 23);
         this.Choose661.TabIndex = 4;
         this.Choose661.Text = "Populate STOR-661";
         this.Choose661.UseVisualStyleBackColor = true;
         this.Choose661.Click += new System.EventHandler(this.Choose661_Click);
         // 
         // PopulateBlockedMine
         // 
         this.PopulateBlockedMine.Location = new System.Drawing.Point(181, 65);
         this.PopulateBlockedMine.Name = "PopulateBlockedMine";
         this.PopulateBlockedMine.Size = new System.Drawing.Size(160, 23);
         this.PopulateBlockedMine.TabIndex = 3;
         this.PopulateBlockedMine.Text = "661";
         this.PopulateBlockedMine.UseVisualStyleBackColor = true;
         this.PopulateBlockedMine.Click += new System.EventHandler(this.PopulateBlockedMine_Click);
         // 
         // PopulateBlockedAOP
         // 
         this.PopulateBlockedAOP.Location = new System.Drawing.Point(5, 65);
         this.PopulateBlockedAOP.Name = "PopulateBlockedAOP";
         this.PopulateBlockedAOP.Size = new System.Drawing.Size(160, 23);
         this.PopulateBlockedAOP.TabIndex = 2;
         this.PopulateBlockedAOP.Text = "Populate a Blocked Story AOP";
         this.PopulateBlockedAOP.UseVisualStyleBackColor = true;
         this.PopulateBlockedAOP.Click += new System.EventHandler(this.PopulateBlockedAOP_Click);
         // 
         // PopulateInitiative
         // 
         this.PopulateInitiative.Location = new System.Drawing.Point(5, 33);
         this.PopulateInitiative.Name = "PopulateInitiative";
         this.PopulateInitiative.Size = new System.Drawing.Size(160, 25);
         this.PopulateInitiative.TabIndex = 1;
         this.PopulateInitiative.Text = "Populate an Initiative Story";
         this.PopulateInitiative.UseVisualStyleBackColor = true;
         this.PopulateInitiative.Click += new System.EventHandler(this.PopulateInitiative_Click);
         // 
         // PopulateNoInit
         // 
         this.PopulateNoInit.Location = new System.Drawing.Point(4, 4);
         this.PopulateNoInit.Name = "PopulateNoInit";
         this.PopulateNoInit.Size = new System.Drawing.Size(162, 23);
         this.PopulateNoInit.TabIndex = 0;
         this.PopulateNoInit.Text = "Populate a Non-Initative Story";
         this.PopulateNoInit.UseVisualStyleBackColor = true;
         this.PopulateNoInit.Click += new System.EventHandler(this.PopulateNoInit_Click);
         // 
         // JQLValue
         // 
         this.JQLValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.JQLValue.Location = new System.Drawing.Point(111, 135);
         this.JQLValue.Name = "JQLValue";
         this.JQLValue.Size = new System.Drawing.Size(920, 20);
         this.JQLValue.TabIndex = 11;
         this.JQLWarning.SetToolTip(this.JQLValue, " JQL is not validated prior to execution");
         this.JQLValue.TextChanged += new System.EventHandler(this.JQLValue_TextChanged);
         // 
         // UseJQL
         // 
         this.UseJQL.AutoSize = true;
         this.UseJQL.Location = new System.Drawing.Point(10, 136);
         this.UseJQL.Name = "UseJQL";
         this.UseJQL.Size = new System.Drawing.Size(66, 17);
         this.UseJQL.TabIndex = 10;
         this.UseJQL.TabStop = true;
         this.UseJQL.Text = "Use JQL";
         this.UseJQL.UseVisualStyleBackColor = true;
         this.UseJQL.CheckedChanged += new System.EventHandler(this.UseJQL_CheckedChanged);
         // 
         // label3
         // 
         this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(7, 166);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(76, 13);
         this.label3.TabIndex = 9;
         this.label3.Text = "Execution URI";
         // 
         // SearchURI
         // 
         this.SearchURI.Anchor = System.Windows.Forms.AnchorStyles.Right;
         this.SearchURI.Location = new System.Drawing.Point(1050, 161);
         this.SearchURI.Name = "SearchURI";
         this.SearchURI.Size = new System.Drawing.Size(75, 23);
         this.SearchURI.TabIndex = 8;
         this.SearchURI.Text = "Search URI";
         this.SearchURI.UseVisualStyleBackColor = true;
         this.SearchURI.Click += new System.EventHandler(this.SearchURI_Click);
         // 
         // ExecutionURI
         // 
         this.ExecutionURI.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.ExecutionURI.Location = new System.Drawing.Point(111, 163);
         this.ExecutionURI.Name = "ExecutionURI";
         this.ExecutionURI.Size = new System.Drawing.Size(920, 20);
         this.ExecutionURI.TabIndex = 7;
         // 
         // FilterID
         // 
         this.FilterID.Location = new System.Drawing.Point(111, 48);
         this.FilterID.Name = "FilterID";
         this.FilterID.Size = new System.Drawing.Size(100, 20);
         this.FilterID.TabIndex = 6;
         this.FilterID.Text = "22004";
         // 
         // SearchButton
         // 
         this.SearchButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
         this.SearchButton.Location = new System.Drawing.Point(1056, 25);
         this.SearchButton.Name = "SearchButton";
         this.SearchButton.Size = new System.Drawing.Size(75, 23);
         this.SearchButton.TabIndex = 4;
         this.SearchButton.Text = "Search";
         this.SearchButton.UseVisualStyleBackColor = true;
         this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
         // 
         // UseFilter
         // 
         this.UseFilter.AutoSize = true;
         this.UseFilter.Location = new System.Drawing.Point(10, 49);
         this.UseFilter.Name = "UseFilter";
         this.UseFilter.Size = new System.Drawing.Size(69, 17);
         this.UseFilter.TabIndex = 5;
         this.UseFilter.TabStop = true;
         this.UseFilter.Text = "Use Filter";
         this.UseFilter.UseVisualStyleBackColor = true;
         this.UseFilter.CheckedChanged += new System.EventHandler(this.UseFilter_CheckedChanged);
         // 
         // BlockedOnly
         // 
         this.BlockedOnly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.BlockedOnly.AutoSize = true;
         this.BlockedOnly.Location = new System.Drawing.Point(815, 45);
         this.BlockedOnly.Name = "BlockedOnly";
         this.BlockedOnly.Size = new System.Drawing.Size(147, 17);
         this.BlockedOnly.TabIndex = 4;
         this.BlockedOnly.Text = "Show Only Blocked Items";
         this.BlockedOnly.UseVisualStyleBackColor = true;
         // 
         // CheckChangeLog
         // 
         this.CheckChangeLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.CheckChangeLog.AutoSize = true;
         this.CheckChangeLog.Checked = true;
         this.CheckChangeLog.CheckState = System.Windows.Forms.CheckState.Checked;
         this.CheckChangeLog.Location = new System.Drawing.Point(815, 23);
         this.CheckChangeLog.Name = "CheckChangeLog";
         this.CheckChangeLog.Size = new System.Drawing.Size(122, 17);
         this.CheckChangeLog.TabIndex = 3;
         this.CheckChangeLog.Text = "Include Change Log";
         this.CheckChangeLog.UseVisualStyleBackColor = true;
         this.CheckChangeLog.CheckedChanged += new System.EventHandler(this.CheckChangeLog_CheckedChanged);
         // 
         // JIRAKeyValue
         // 
         this.JIRAKeyValue.Location = new System.Drawing.Point(111, 21);
         this.JIRAKeyValue.Name = "JIRAKeyValue";
         this.JIRAKeyValue.Size = new System.Drawing.Size(100, 20);
         this.JIRAKeyValue.TabIndex = 2;
         this.JIRAKeyValue.Text = "INFAOP-445";
         this.JIRAKeyValue.TextChanged += new System.EventHandler(this.JIRAKeyValue_TextChanged);
         // 
         // UseKeyValue
         // 
         this.UseKeyValue.AutoSize = true;
         this.UseKeyValue.Checked = true;
         this.UseKeyValue.Location = new System.Drawing.Point(10, 24);
         this.UseKeyValue.Name = "UseKeyValue";
         this.UseKeyValue.Size = new System.Drawing.Size(95, 17);
         this.UseKeyValue.TabIndex = 1;
         this.UseKeyValue.TabStop = true;
         this.UseKeyValue.Text = "Use Key Value";
         this.UseKeyValue.UseVisualStyleBackColor = true;
         this.UseKeyValue.CheckedChanged += new System.EventHandler(this.UseKeyValue_CheckedChanged);
         // 
         // UseTMobile
         // 
         this.UseTMobile.AutoSize = true;
         this.UseTMobile.Location = new System.Drawing.Point(819, 12);
         this.UseTMobile.Name = "UseTMobile";
         this.UseTMobile.Size = new System.Drawing.Size(66, 17);
         this.UseTMobile.TabIndex = 13;
         this.UseTMobile.Text = "T-Mobile";
         this.UseTMobile.UseVisualStyleBackColor = true;
         this.UseTMobile.CheckedChanged += new System.EventHandler(this.UseTMobile_Checked);
         // 
         // ShowNoBlocked
         // 
         this.ShowNoBlocked.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.ShowNoBlocked.AutoSize = true;
         this.ShowNoBlocked.BackColor = System.Drawing.SystemColors.MenuHighlight;
         this.ShowNoBlocked.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.ShowNoBlocked.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.ShowNoBlocked.ForeColor = System.Drawing.SystemColors.ControlLightLight;
         this.ShowNoBlocked.Location = new System.Drawing.Point(386, 240);
         this.ShowNoBlocked.Name = "ShowNoBlocked";
         this.ShowNoBlocked.Size = new System.Drawing.Size(332, 18);
         this.ShowNoBlocked.TabIndex = 6;
         this.ShowNoBlocked.Text = "No Blocked Items were found in the search";
         this.ShowNoBlocked.Visible = false;
         // 
         // UseSeaTransplant
         // 
         this.UseSeaTransplant.AutoSize = true;
         this.UseSeaTransplant.Location = new System.Drawing.Point(700, 12);
         this.UseSeaTransplant.Name = "UseSeaTransplant";
         this.UseSeaTransplant.Size = new System.Drawing.Size(94, 17);
         this.UseSeaTransplant.TabIndex = 12;
         this.UseSeaTransplant.Text = "SeaTransplant";
         this.UseSeaTransplant.UseVisualStyleBackColor = true;
         this.UseSeaTransplant.CheckedChanged += new System.EventHandler(this.UseSeaTransplant_Checked);
         // 
         // PasswordField
         // 
         this.PasswordField.Location = new System.Drawing.Point(377, 12);
         this.PasswordField.Name = "PasswordField";
         this.PasswordField.PasswordChar = '*';
         this.PasswordField.Size = new System.Drawing.Size(292, 20);
         this.PasswordField.TabIndex = 11;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(317, 12);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(53, 13);
         this.label2.TabIndex = 10;
         this.label2.Text = "Password";
         // 
         // UserNameField
         // 
         this.UserNameField.Location = new System.Drawing.Point(76, 12);
         this.UserNameField.Name = "UserNameField";
         this.UserNameField.Size = new System.Drawing.Size(200, 20);
         this.UserNameField.TabIndex = 9;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(9, 12);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(60, 13);
         this.label1.TabIndex = 8;
         this.label1.Text = "User Name";
         // 
         // groupBox1
         // 
         this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
         this.groupBox1.Controls.Add(this.groupBox3);
         this.groupBox1.Controls.Add(this.ExportAllRecords);
         this.groupBox1.Location = new System.Drawing.Point(22, 396);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(1127, 58);
         this.groupBox1.TabIndex = 10;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Export Results to JSON";
         // 
         // groupBox3
         // 
         this.groupBox3.Controls.Add(this.AllHistoryRecordsJSON);
         this.groupBox3.Controls.Add(this.BlockedChangeRecordsOnlyJSON);
         this.groupBox3.Controls.Add(this.JSONNoHistoryRecords);
         this.groupBox3.Location = new System.Drawing.Point(7, 19);
         this.groupBox3.Name = "groupBox3";
         this.groupBox3.Size = new System.Drawing.Size(368, 33);
         this.groupBox3.TabIndex = 10;
         this.groupBox3.TabStop = false;
         // 
         // AllHistoryRecordsJSON
         // 
         this.AllHistoryRecordsJSON.AutoSize = true;
         this.AllHistoryRecordsJSON.Location = new System.Drawing.Point(248, 10);
         this.AllHistoryRecordsJSON.Name = "AllHistoryRecordsJSON";
         this.AllHistoryRecordsJSON.Size = new System.Drawing.Size(114, 17);
         this.AllHistoryRecordsJSON.TabIndex = 2;
         this.AllHistoryRecordsJSON.TabStop = true;
         this.AllHistoryRecordsJSON.Text = "All History Records";
         this.AllHistoryRecordsJSON.UseVisualStyleBackColor = true;
         // 
         // BlockedChangeRecordsOnlyJSON
         // 
         this.BlockedChangeRecordsOnlyJSON.AutoSize = true;
         this.BlockedChangeRecordsOnlyJSON.Location = new System.Drawing.Point(135, 10);
         this.BlockedChangeRecordsOnlyJSON.Name = "BlockedChangeRecordsOnlyJSON";
         this.BlockedChangeRecordsOnlyJSON.Size = new System.Drawing.Size(107, 17);
         this.BlockedChangeRecordsOnlyJSON.TabIndex = 1;
         this.BlockedChangeRecordsOnlyJSON.TabStop = true;
         this.BlockedChangeRecordsOnlyJSON.Text = "Blocked Records";
         this.BlockedChangeRecordsOnlyJSON.UseVisualStyleBackColor = true;
         // 
         // JSONNoHistoryRecords
         // 
         this.JSONNoHistoryRecords.AutoSize = true;
         this.JSONNoHistoryRecords.Location = new System.Drawing.Point(7, 10);
         this.JSONNoHistoryRecords.Name = "JSONNoHistoryRecords";
         this.JSONNoHistoryRecords.Size = new System.Drawing.Size(117, 17);
         this.JSONNoHistoryRecords.TabIndex = 0;
         this.JSONNoHistoryRecords.TabStop = true;
         this.JSONNoHistoryRecords.Text = "No History Records";
         this.JSONNoHistoryRecords.UseVisualStyleBackColor = true;
         // 
         // ExportAllRecords
         // 
         this.ExportAllRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.ExportAllRecords.Location = new System.Drawing.Point(993, 19);
         this.ExportAllRecords.Name = "ExportAllRecords";
         this.ExportAllRecords.Size = new System.Drawing.Size(117, 23);
         this.ExportAllRecords.TabIndex = 9;
         this.ExportAllRecords.Text = "Export All Records";
         this.ExportAllRecords.UseVisualStyleBackColor = true;
         this.ExportAllRecords.Click += new System.EventHandler(this.ExportAllRecords_Click);
         // 
         // DetailChangeLog
         // 
         this.DetailChangeLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.DetailChangeLog.AutoSize = true;
         this.DetailChangeLog.Checked = true;
         this.DetailChangeLog.CheckState = System.Windows.Forms.CheckState.Checked;
         this.DetailChangeLog.Location = new System.Drawing.Point(1015, 260);
         this.DetailChangeLog.Name = "DetailChangeLog";
         this.DetailChangeLog.Size = new System.Drawing.Size(114, 17);
         this.DetailChangeLog.TabIndex = 8;
         this.DetailChangeLog.Text = "Detail Change Log";
         this.DetailChangeLog.UseVisualStyleBackColor = true;
         // 
         // ShowItemDetails
         // 
         this.ShowItemDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.ShowItemDetails.Enabled = false;
         this.ShowItemDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
         this.ShowItemDetails.Location = new System.Drawing.Point(1015, 283);
         this.ShowItemDetails.Name = "ShowItemDetails";
         this.ShowItemDetails.Size = new System.Drawing.Size(117, 41);
         this.ShowItemDetails.TabIndex = 7;
         this.ShowItemDetails.Text = "Select an item";
         this.ShowItemDetails.UseVisualStyleBackColor = true;
         this.ShowItemDetails.Click += new System.EventHandler(this.ShowItemDetails_Click);
         // 
         // ReturnedJSON
         // 
         this.ReturnedJSON.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.ReturnedJSON.Location = new System.Drawing.Point(19, 16);
         this.ReturnedJSON.Multiline = true;
         this.ReturnedJSON.Name = "ReturnedJSON";
         this.ReturnedJSON.Size = new System.Drawing.Size(1113, 220);
         this.ReturnedJSON.TabIndex = 5;
         // 
         // ListOfResults
         // 
         this.ListOfResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.ListOfResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.JiraKey,
            this.Status,
            this.Summary,
            this.BlockedReason});
         this.ListOfResults.GridLines = true;
         this.ListOfResults.HideSelection = false;
         this.ListOfResults.Location = new System.Drawing.Point(19, 258);
         this.ListOfResults.MultiSelect = false;
         this.ListOfResults.Name = "ListOfResults";
         this.ListOfResults.Size = new System.Drawing.Size(981, 131);
         this.ListOfResults.TabIndex = 4;
         this.ListOfResults.UseCompatibleStateImageBehavior = false;
         this.ListOfResults.View = System.Windows.Forms.View.Details;
         this.ListOfResults.ItemActivate += new System.EventHandler(this.ListOfResults_Click);
         this.ListOfResults.SelectedIndexChanged += new System.EventHandler(this.ListOfResults_Click);
         this.ListOfResults.Click += new System.EventHandler(this.ListOfResults_Click);
         // 
         // JiraKey
         // 
         this.JiraKey.Text = "JIRA Key";
         this.JiraKey.Width = 100;
         // 
         // Status
         // 
         this.Status.Text = "Status";
         this.Status.Width = 100;
         // 
         // Summary
         // 
         this.Summary.Text = "Summary";
         this.Summary.Width = 400;
         // 
         // BlockedReason
         // 
         this.BlockedReason.Text = "Blocked Reason";
         this.BlockedReason.Width = 200;
         // 
         // JQLWarning
         // 
         this.JQLWarning.IsBalloon = true;
         this.JQLWarning.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
         this.JQLWarning.ToolTipTitle = "JQL Validation";
         // 
         // LookupForm
         // 
         this.AcceptButton = this.SearchButton;
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1185, 759);
         this.Controls.Add(this.splitContainer1);
         this.Name = "LookupForm";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "Search";
         this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
         this.Load += new System.EventHandler(this.Main_Load);
         this.splitContainer1.Panel1.ResumeLayout(false);
         this.splitContainer1.Panel1.PerformLayout();
         this.splitContainer1.Panel2.ResumeLayout(false);
         this.splitContainer1.Panel2.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
         this.splitContainer1.ResumeLayout(false);
         this.groupBox2.ResumeLayout(false);
         this.groupBox2.PerformLayout();
         this.panel1.ResumeLayout(false);
         this.groupBox1.ResumeLayout(false);
         this.groupBox3.ResumeLayout(false);
         this.groupBox3.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.SplitContainer splitContainer1;
      private System.Windows.Forms.GroupBox groupBox2;
      private System.Windows.Forms.TextBox JQLValue;
      private System.Windows.Forms.RadioButton UseJQL;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Button SearchURI;
      private System.Windows.Forms.TextBox ExecutionURI;
      private System.Windows.Forms.TextBox FilterID;
      private System.Windows.Forms.Button SearchButton;
      private System.Windows.Forms.RadioButton UseFilter;
      private System.Windows.Forms.CheckBox BlockedOnly;
      private System.Windows.Forms.CheckBox CheckChangeLog;
      private System.Windows.Forms.TextBox JIRAKeyValue;
      private System.Windows.Forms.RadioButton UseKeyValue;
      private System.Windows.Forms.RadioButton UseTMobile;
      private System.Windows.Forms.RadioButton UseSeaTransplant;
      private System.Windows.Forms.TextBox PasswordField;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TextBox UserNameField;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label ShowNoBlocked;
      private System.Windows.Forms.TextBox ReturnedJSON;
      private System.Windows.Forms.ListView ListOfResults;
      private System.Windows.Forms.ColumnHeader JiraKey;
      private System.Windows.Forms.ColumnHeader Status;
      private System.Windows.Forms.ColumnHeader Summary;
      private System.Windows.Forms.ToolTip JQLWarning;
      private System.Windows.Forms.Button ShowItemDetails;
      private System.Windows.Forms.ColumnHeader BlockedReason;
      private System.Windows.Forms.CheckBox DetailChangeLog;
      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.Button PopulateBlockedAOP;
      private System.Windows.Forms.Button PopulateInitiative;
      private System.Windows.Forms.Button PopulateNoInit;
      private System.Windows.Forms.Button PopulateBlockedMine;
      private System.Windows.Forms.Button Choose661;
      private System.Windows.Forms.Button ExportAllRecords;
      private System.Windows.Forms.TextBox StartAt;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.TextBox MaxRecords;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.GroupBox groupBox3;
      private System.Windows.Forms.RadioButton AllHistoryRecordsJSON;
      private System.Windows.Forms.RadioButton BlockedChangeRecordsOnlyJSON;
      private System.Windows.Forms.RadioButton JSONNoHistoryRecords;
      //      private System.Windows.Forms.ProgressBar ExportProgressBar;
      private NewProgressBar ExportProgressBar;
      private System.Windows.Forms.Button btnLaunchPostJSON;
   }
}

