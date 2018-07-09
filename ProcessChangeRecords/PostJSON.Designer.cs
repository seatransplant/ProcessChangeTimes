namespace BlockedItems
{
   partial class PostJSON
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
         this.JQLWarning = new System.Windows.Forms.ToolTip(this.components);
         this.POSTGrouping = new System.Windows.Forms.GroupBox();
         this.EditItemGroupBox = new System.Windows.Forms.GroupBox();
         this.UpdatePriority = new System.Windows.Forms.ComboBox();
         this.label18 = new System.Windows.Forms.Label();
         this.UpdatedSuccessfully = new System.Windows.Forms.Label();
         this.UpdateEpicLinksCombo = new System.Windows.Forms.ComboBox();
         this.label15 = new System.Windows.Forms.Label();
         this.EditIssueKey = new System.Windows.Forms.TextBox();
         this.label14 = new System.Windows.Forms.Label();
         this.PostUpdate = new System.Windows.Forms.Button();
         this.UpdateSummary = new System.Windows.Forms.TextBox();
         this.label4 = new System.Windows.Forms.Label();
         this.UpdateDescription = new System.Windows.Forms.TextBox();
         this.Unassign = new System.Windows.Forms.CheckBox();
         this.UpdateAssignee = new System.Windows.Forms.TextBox();
         this.label8 = new System.Windows.Forms.Label();
         this.UpdateReporter = new System.Windows.Forms.TextBox();
         this.label10 = new System.Windows.Forms.Label();
         this.label11 = new System.Windows.Forms.Label();
         this.SelectOperation = new System.Windows.Forms.GroupBox();
         this.CreateItem = new System.Windows.Forms.RadioButton();
         this.EditItem = new System.Windows.Forms.RadioButton();
         this.SelectUserType = new System.Windows.Forms.GroupBox();
         this.UseNTID = new System.Windows.Forms.RadioButton();
         this.UseEmail = new System.Windows.Forms.RadioButton();
         this.CreateItemGroupBox = new System.Windows.Forms.GroupBox();
         this.CreatePriority = new System.Windows.Forms.ComboBox();
         this.label17 = new System.Windows.Forms.Label();
         this.CreateEpicLinksCombo = new System.Windows.Forms.ComboBox();
         this.label16 = new System.Windows.Forms.Label();
         this.CreatedSuccessfully = new System.Windows.Forms.Label();
         this.CreateSummary = new System.Windows.Forms.TextBox();
         this.CreateDescription = new System.Windows.Forms.TextBox();
         this.PostCreate = new System.Windows.Forms.Button();
         this.label12 = new System.Windows.Forms.Label();
         this.label13 = new System.Windows.Forms.Label();
         this.CreateAssignee = new System.Windows.Forms.TextBox();
         this.label9 = new System.Windows.Forms.Label();
         this.label6 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.CreateReporter = new System.Windows.Forms.TextBox();
         this.ReporterIsAssignee = new System.Windows.Forms.CheckBox();
         this.CreateProject = new System.Windows.Forms.TextBox();
         this.IssueTypeSelector = new System.Windows.Forms.ComboBox();
         this.label7 = new System.Windows.Forms.Label();
         this.UseTMobileQA = new System.Windows.Forms.RadioButton();
         this.ReturnedJSON = new System.Windows.Forms.TextBox();
         this.GoMain = new System.Windows.Forms.Button();
         this.SelectorGroup = new System.Windows.Forms.GroupBox();
         this.panel1 = new System.Windows.Forms.Panel();
         this.Choose661 = new System.Windows.Forms.Button();
         this.PopulateBlockedMine = new System.Windows.Forms.Button();
         this.PopulateBlockedAOP = new System.Windows.Forms.Button();
         this.PopulateInitiative = new System.Windows.Forms.Button();
         this.PopulateNoInit = new System.Windows.Forms.Button();
         this.label3 = new System.Windows.Forms.Label();
         this.SearchURI = new System.Windows.Forms.Button();
         this.ExecutionURI = new System.Windows.Forms.TextBox();
         this.SearchButton = new System.Windows.Forms.Button();
         this.JIRAKeyValue = new System.Windows.Forms.TextBox();
         this.UseKeyValue = new System.Windows.Forms.RadioButton();
         this.UseTMobile = new System.Windows.Forms.RadioButton();
         this.UseSeaTransplant = new System.Windows.Forms.RadioButton();
         this.PasswordField = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.UserNameField = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.POSTGrouping.SuspendLayout();
         this.EditItemGroupBox.SuspendLayout();
         this.SelectOperation.SuspendLayout();
         this.SelectUserType.SuspendLayout();
         this.CreateItemGroupBox.SuspendLayout();
         this.SelectorGroup.SuspendLayout();
         this.panel1.SuspendLayout();
         this.SuspendLayout();
         // 
         // JQLWarning
         // 
         this.JQLWarning.IsBalloon = true;
         this.JQLWarning.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
         this.JQLWarning.ToolTipTitle = "JQL Validation";
         // 
         // POSTGrouping
         // 
         this.POSTGrouping.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
         this.POSTGrouping.Controls.Add(this.EditItemGroupBox);
         this.POSTGrouping.Controls.Add(this.SelectOperation);
         this.POSTGrouping.Controls.Add(this.SelectUserType);
         this.POSTGrouping.Controls.Add(this.CreateItemGroupBox);
         this.POSTGrouping.Location = new System.Drawing.Point(31, 291);
         this.POSTGrouping.Name = "POSTGrouping";
         this.POSTGrouping.Size = new System.Drawing.Size(1117, 303);
         this.POSTGrouping.TabIndex = 26;
         this.POSTGrouping.TabStop = false;
         this.POSTGrouping.Text = "Edit/Create Issue";
         this.JQLWarning.SetToolTip(this.POSTGrouping, "You cannot edit an issue found by JQL or Filter");
         // 
         // EditItemGroupBox
         // 
         this.EditItemGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
         this.EditItemGroupBox.Controls.Add(this.UpdatePriority);
         this.EditItemGroupBox.Controls.Add(this.label18);
         this.EditItemGroupBox.Controls.Add(this.UpdatedSuccessfully);
         this.EditItemGroupBox.Controls.Add(this.UpdateEpicLinksCombo);
         this.EditItemGroupBox.Controls.Add(this.label15);
         this.EditItemGroupBox.Controls.Add(this.EditIssueKey);
         this.EditItemGroupBox.Controls.Add(this.label14);
         this.EditItemGroupBox.Controls.Add(this.PostUpdate);
         this.EditItemGroupBox.Controls.Add(this.UpdateSummary);
         this.EditItemGroupBox.Controls.Add(this.label4);
         this.EditItemGroupBox.Controls.Add(this.UpdateDescription);
         this.EditItemGroupBox.Controls.Add(this.Unassign);
         this.EditItemGroupBox.Controls.Add(this.UpdateAssignee);
         this.EditItemGroupBox.Controls.Add(this.label8);
         this.EditItemGroupBox.Controls.Add(this.UpdateReporter);
         this.EditItemGroupBox.Controls.Add(this.label10);
         this.EditItemGroupBox.Controls.Add(this.label11);
         this.EditItemGroupBox.Enabled = false;
         this.EditItemGroupBox.Location = new System.Drawing.Point(582, 12);
         this.EditItemGroupBox.Name = "EditItemGroupBox";
         this.EditItemGroupBox.Size = new System.Drawing.Size(449, 285);
         this.EditItemGroupBox.TabIndex = 41;
         this.EditItemGroupBox.TabStop = false;
         this.EditItemGroupBox.Text = "Edit Item";
         // 
         // UpdatePriority
         // 
         this.UpdatePriority.FormattingEnabled = true;
         this.UpdatePriority.Location = new System.Drawing.Point(81, 182);
         this.UpdatePriority.Name = "UpdatePriority";
         this.UpdatePriority.Size = new System.Drawing.Size(121, 21);
         this.UpdatePriority.TabIndex = 39;
         // 
         // label18
         // 
         this.label18.AutoSize = true;
         this.label18.Location = new System.Drawing.Point(13, 185);
         this.label18.Name = "label18";
         this.label18.Size = new System.Drawing.Size(38, 13);
         this.label18.TabIndex = 55;
         this.label18.Text = "Priority";
         // 
         // UpdatedSuccessfully
         // 
         this.UpdatedSuccessfully.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
         this.UpdatedSuccessfully.AutoSize = true;
         this.UpdatedSuccessfully.Location = new System.Drawing.Point(160, 256);
         this.UpdatedSuccessfully.Name = "UpdatedSuccessfully";
         this.UpdatedSuccessfully.Size = new System.Drawing.Size(0, 13);
         this.UpdatedSuccessfully.TabIndex = 51;
         // 
         // UpdateEpicLinksCombo
         // 
         this.UpdateEpicLinksCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
         this.UpdateEpicLinksCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
         this.UpdateEpicLinksCombo.FormattingEnabled = true;
         this.UpdateEpicLinksCombo.Location = new System.Drawing.Point(81, 154);
         this.UpdateEpicLinksCombo.Name = "UpdateEpicLinksCombo";
         this.UpdateEpicLinksCombo.Size = new System.Drawing.Size(351, 21);
         this.UpdateEpicLinksCombo.TabIndex = 38;
         // 
         // label15
         // 
         this.label15.AutoSize = true;
         this.label15.Location = new System.Drawing.Point(10, 157);
         this.label15.Name = "label15";
         this.label15.Size = new System.Drawing.Size(51, 13);
         this.label15.TabIndex = 44;
         this.label15.Text = "Epic Link";
         // 
         // EditIssueKey
         // 
         this.EditIssueKey.BackColor = System.Drawing.SystemColors.Info;
         this.EditIssueKey.Location = new System.Drawing.Point(81, 19);
         this.EditIssueKey.Name = "EditIssueKey";
         this.EditIssueKey.Size = new System.Drawing.Size(91, 20);
         this.EditIssueKey.TabIndex = 43;
         this.EditIssueKey.TabStop = false;
         // 
         // label14
         // 
         this.label14.AutoSize = true;
         this.label14.Location = new System.Drawing.Point(7, 22);
         this.label14.Name = "label14";
         this.label14.Size = new System.Drawing.Size(53, 13);
         this.label14.TabIndex = 42;
         this.label14.Text = "Edit Issue";
         // 
         // PostUpdate
         // 
         this.PostUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
         this.PostUpdate.Location = new System.Drawing.Point(13, 254);
         this.PostUpdate.Name = "PostUpdate";
         this.PostUpdate.Size = new System.Drawing.Size(75, 23);
         this.PostUpdate.TabIndex = 40;
         this.PostUpdate.Text = "Update";
         this.PostUpdate.UseVisualStyleBackColor = true;
         this.PostUpdate.Click += new System.EventHandler(this.PostUpdates_Click);
         // 
         // UpdateSummary
         // 
         this.UpdateSummary.BackColor = System.Drawing.SystemColors.Window;
         this.UpdateSummary.Location = new System.Drawing.Point(81, 51);
         this.UpdateSummary.Name = "UpdateSummary";
         this.UpdateSummary.Size = new System.Drawing.Size(351, 20);
         this.UpdateSummary.TabIndex = 33;
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(10, 104);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(48, 13);
         this.label4.TabIndex = 40;
         this.label4.Text = "Reporter";
         // 
         // UpdateDescription
         // 
         this.UpdateDescription.BackColor = System.Drawing.SystemColors.Window;
         this.UpdateDescription.Location = new System.Drawing.Point(81, 76);
         this.UpdateDescription.Name = "UpdateDescription";
         this.UpdateDescription.Size = new System.Drawing.Size(351, 20);
         this.UpdateDescription.TabIndex = 34;
         // 
         // Unassign
         // 
         this.Unassign.AutoSize = true;
         this.Unassign.Location = new System.Drawing.Point(288, 126);
         this.Unassign.Name = "Unassign";
         this.Unassign.Size = new System.Drawing.Size(70, 17);
         this.Unassign.TabIndex = 37;
         this.Unassign.Text = "Unassign";
         this.Unassign.UseVisualStyleBackColor = true;
         this.Unassign.CheckedChanged += new System.EventHandler(this.Unassign_CheckedChanged);
         this.Unassign.CheckStateChanged += new System.EventHandler(this.Unassign_CheckStateChanged);
         // 
         // UpdateAssignee
         // 
         this.UpdateAssignee.Location = new System.Drawing.Point(81, 127);
         this.UpdateAssignee.Name = "UpdateAssignee";
         this.UpdateAssignee.Size = new System.Drawing.Size(201, 20);
         this.UpdateAssignee.TabIndex = 36;
         // 
         // label8
         // 
         this.label8.AutoSize = true;
         this.label8.Location = new System.Drawing.Point(10, 54);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(50, 13);
         this.label8.TabIndex = 32;
         this.label8.Text = "Summary";
         // 
         // UpdateReporter
         // 
         this.UpdateReporter.Location = new System.Drawing.Point(81, 101);
         this.UpdateReporter.Name = "UpdateReporter";
         this.UpdateReporter.Size = new System.Drawing.Size(269, 20);
         this.UpdateReporter.TabIndex = 35;
         // 
         // label10
         // 
         this.label10.AutoSize = true;
         this.label10.Location = new System.Drawing.Point(10, 79);
         this.label10.Name = "label10";
         this.label10.Size = new System.Drawing.Size(60, 13);
         this.label10.TabIndex = 34;
         this.label10.Text = "Description";
         // 
         // label11
         // 
         this.label11.AutoSize = true;
         this.label11.Location = new System.Drawing.Point(10, 130);
         this.label11.Name = "label11";
         this.label11.Size = new System.Drawing.Size(50, 13);
         this.label11.TabIndex = 35;
         this.label11.Text = "Assignee";
         // 
         // SelectOperation
         // 
         this.SelectOperation.Controls.Add(this.CreateItem);
         this.SelectOperation.Controls.Add(this.EditItem);
         this.SelectOperation.Location = new System.Drawing.Point(6, 23);
         this.SelectOperation.Name = "SelectOperation";
         this.SelectOperation.Size = new System.Drawing.Size(102, 100);
         this.SelectOperation.TabIndex = 38;
         this.SelectOperation.TabStop = false;
         this.SelectOperation.Text = "Operation";
         // 
         // CreateItem
         // 
         this.CreateItem.AutoSize = true;
         this.CreateItem.Checked = true;
         this.CreateItem.Location = new System.Drawing.Point(6, 19);
         this.CreateItem.Name = "CreateItem";
         this.CreateItem.Size = new System.Drawing.Size(79, 17);
         this.CreateItem.TabIndex = 22;
         this.CreateItem.TabStop = true;
         this.CreateItem.Text = "Create Item";
         this.CreateItem.UseVisualStyleBackColor = true;
         this.CreateItem.CheckedChanged += new System.EventHandler(this.CreateItem_CheckedChanged);
         // 
         // EditItem
         // 
         this.EditItem.AutoSize = true;
         this.EditItem.Location = new System.Drawing.Point(6, 42);
         this.EditItem.Name = "EditItem";
         this.EditItem.Size = new System.Drawing.Size(66, 17);
         this.EditItem.TabIndex = 18;
         this.EditItem.TabStop = true;
         this.EditItem.Text = "Edit Item";
         this.EditItem.UseVisualStyleBackColor = true;
         this.EditItem.CheckedChanged += new System.EventHandler(this.EditItem_CheckedChanged);
         // 
         // SelectUserType
         // 
         this.SelectUserType.Controls.Add(this.UseNTID);
         this.SelectUserType.Controls.Add(this.UseEmail);
         this.SelectUserType.Location = new System.Drawing.Point(6, 134);
         this.SelectUserType.Name = "SelectUserType";
         this.SelectUserType.Size = new System.Drawing.Size(101, 73);
         this.SelectUserType.TabIndex = 37;
         this.SelectUserType.TabStop = false;
         this.SelectUserType.Text = "User IDs";
         // 
         // UseNTID
         // 
         this.UseNTID.AutoSize = true;
         this.UseNTID.Checked = true;
         this.UseNTID.Location = new System.Drawing.Point(15, 19);
         this.UseNTID.Name = "UseNTID";
         this.UseNTID.Size = new System.Drawing.Size(73, 17);
         this.UseNTID.TabIndex = 28;
         this.UseNTID.TabStop = true;
         this.UseNTID.Tag = "";
         this.UseNTID.Text = "Use NTID";
         this.UseNTID.UseVisualStyleBackColor = true;
         // 
         // UseEmail
         // 
         this.UseEmail.AutoSize = true;
         this.UseEmail.Location = new System.Drawing.Point(15, 42);
         this.UseEmail.Name = "UseEmail";
         this.UseEmail.Size = new System.Drawing.Size(72, 17);
         this.UseEmail.TabIndex = 29;
         this.UseEmail.Text = "Use Email";
         this.UseEmail.UseVisualStyleBackColor = true;
         // 
         // CreateItemGroupBox
         // 
         this.CreateItemGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
         this.CreateItemGroupBox.Controls.Add(this.CreatePriority);
         this.CreateItemGroupBox.Controls.Add(this.label17);
         this.CreateItemGroupBox.Controls.Add(this.CreateEpicLinksCombo);
         this.CreateItemGroupBox.Controls.Add(this.label16);
         this.CreateItemGroupBox.Controls.Add(this.CreatedSuccessfully);
         this.CreateItemGroupBox.Controls.Add(this.CreateSummary);
         this.CreateItemGroupBox.Controls.Add(this.CreateDescription);
         this.CreateItemGroupBox.Controls.Add(this.PostCreate);
         this.CreateItemGroupBox.Controls.Add(this.label12);
         this.CreateItemGroupBox.Controls.Add(this.label13);
         this.CreateItemGroupBox.Controls.Add(this.CreateAssignee);
         this.CreateItemGroupBox.Controls.Add(this.label9);
         this.CreateItemGroupBox.Controls.Add(this.label6);
         this.CreateItemGroupBox.Controls.Add(this.label5);
         this.CreateItemGroupBox.Controls.Add(this.CreateReporter);
         this.CreateItemGroupBox.Controls.Add(this.ReporterIsAssignee);
         this.CreateItemGroupBox.Controls.Add(this.CreateProject);
         this.CreateItemGroupBox.Controls.Add(this.IssueTypeSelector);
         this.CreateItemGroupBox.Controls.Add(this.label7);
         this.CreateItemGroupBox.Location = new System.Drawing.Point(125, 12);
         this.CreateItemGroupBox.Name = "CreateItemGroupBox";
         this.CreateItemGroupBox.Size = new System.Drawing.Size(435, 285);
         this.CreateItemGroupBox.TabIndex = 11;
         this.CreateItemGroupBox.TabStop = false;
         this.CreateItemGroupBox.Text = "Create Item";
         // 
         // CreatePriority
         // 
         this.CreatePriority.FormattingEnabled = true;
         this.CreatePriority.Location = new System.Drawing.Point(79, 216);
         this.CreatePriority.Name = "CreatePriority";
         this.CreatePriority.Size = new System.Drawing.Size(121, 21);
         this.CreatePriority.TabIndex = 31;
         // 
         // label17
         // 
         this.label17.AutoSize = true;
         this.label17.Location = new System.Drawing.Point(11, 219);
         this.label17.Name = "label17";
         this.label17.Size = new System.Drawing.Size(38, 13);
         this.label17.TabIndex = 53;
         this.label17.Text = "Priority";
         // 
         // CreateEpicLinksCombo
         // 
         this.CreateEpicLinksCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
         this.CreateEpicLinksCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
         this.CreateEpicLinksCombo.FormattingEnabled = true;
         this.CreateEpicLinksCombo.Location = new System.Drawing.Point(79, 187);
         this.CreateEpicLinksCombo.Name = "CreateEpicLinksCombo";
         this.CreateEpicLinksCombo.Size = new System.Drawing.Size(351, 21);
         this.CreateEpicLinksCombo.TabIndex = 30;
         // 
         // label16
         // 
         this.label16.AutoSize = true;
         this.label16.Location = new System.Drawing.Point(11, 190);
         this.label16.Name = "label16";
         this.label16.Size = new System.Drawing.Size(51, 13);
         this.label16.TabIndex = 51;
         this.label16.Text = "Epic Link";
         // 
         // CreatedSuccessfully
         // 
         this.CreatedSuccessfully.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
         this.CreatedSuccessfully.AutoSize = true;
         this.CreatedSuccessfully.Location = new System.Drawing.Point(160, 256);
         this.CreatedSuccessfully.Name = "CreatedSuccessfully";
         this.CreatedSuccessfully.Size = new System.Drawing.Size(0, 13);
         this.CreatedSuccessfully.TabIndex = 50;
         // 
         // CreateSummary
         // 
         this.CreateSummary.BackColor = System.Drawing.Color.Cyan;
         this.CreateSummary.Location = new System.Drawing.Point(79, 68);
         this.CreateSummary.Name = "CreateSummary";
         this.CreateSummary.Size = new System.Drawing.Size(351, 20);
         this.CreateSummary.TabIndex = 25;
         this.CreateSummary.Text = "{Summary Required}";
         this.CreateSummary.TextChanged += new System.EventHandler(this.CreateSummary_TextChanged);
         this.CreateSummary.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CreateProject_KeyDown);
         this.CreateSummary.Leave += new System.EventHandler(this.CreateSummary_Leave);
         // 
         // CreateDescription
         // 
         this.CreateDescription.BackColor = System.Drawing.SystemColors.Window;
         this.CreateDescription.Location = new System.Drawing.Point(79, 92);
         this.CreateDescription.Name = "CreateDescription";
         this.CreateDescription.Size = new System.Drawing.Size(351, 20);
         this.CreateDescription.TabIndex = 26;
         // 
         // PostCreate
         // 
         this.PostCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
         this.PostCreate.Location = new System.Drawing.Point(14, 254);
         this.PostCreate.Name = "PostCreate";
         this.PostCreate.Size = new System.Drawing.Size(75, 23);
         this.PostCreate.TabIndex = 32;
         this.PostCreate.Text = "Create";
         this.PostCreate.UseVisualStyleBackColor = true;
         this.PostCreate.Click += new System.EventHandler(this.PostUpdates_Click);
         // 
         // label12
         // 
         this.label12.AutoSize = true;
         this.label12.Location = new System.Drawing.Point(11, 71);
         this.label12.Name = "label12";
         this.label12.Size = new System.Drawing.Size(50, 13);
         this.label12.TabIndex = 48;
         this.label12.Text = "Summary";
         // 
         // label13
         // 
         this.label13.AutoSize = true;
         this.label13.Location = new System.Drawing.Point(11, 95);
         this.label13.Name = "label13";
         this.label13.Size = new System.Drawing.Size(60, 13);
         this.label13.TabIndex = 49;
         this.label13.Text = "Description";
         // 
         // CreateAssignee
         // 
         this.CreateAssignee.Location = new System.Drawing.Point(79, 161);
         this.CreateAssignee.Name = "CreateAssignee";
         this.CreateAssignee.Size = new System.Drawing.Size(351, 20);
         this.CreateAssignee.TabIndex = 29;
         // 
         // label9
         // 
         this.label9.AutoSize = true;
         this.label9.Location = new System.Drawing.Point(11, 164);
         this.label9.Name = "label9";
         this.label9.Size = new System.Drawing.Size(50, 13);
         this.label9.TabIndex = 45;
         this.label9.Text = "Assignee";
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Location = new System.Drawing.Point(11, 47);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(40, 13);
         this.label6.TabIndex = 43;
         this.label6.Text = "Project";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(11, 119);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(48, 13);
         this.label5.TabIndex = 42;
         this.label5.Text = "Reporter";
         // 
         // CreateReporter
         // 
         this.CreateReporter.Location = new System.Drawing.Point(79, 116);
         this.CreateReporter.Name = "CreateReporter";
         this.CreateReporter.Size = new System.Drawing.Size(351, 20);
         this.CreateReporter.TabIndex = 27;
         // 
         // ReporterIsAssignee
         // 
         this.ReporterIsAssignee.AutoSize = true;
         this.ReporterIsAssignee.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
         this.ReporterIsAssignee.Location = new System.Drawing.Point(79, 140);
         this.ReporterIsAssignee.Name = "ReporterIsAssignee";
         this.ReporterIsAssignee.Size = new System.Drawing.Size(144, 17);
         this.ReporterIsAssignee.TabIndex = 28;
         this.ReporterIsAssignee.Text = "Set Assignee to Reporter";
         this.ReporterIsAssignee.UseVisualStyleBackColor = true;
         this.ReporterIsAssignee.CheckStateChanged += new System.EventHandler(this.ReporterIsAssignee_CheckedChanged);
         // 
         // CreateProject
         // 
         this.CreateProject.BackColor = System.Drawing.Color.Cyan;
         this.CreateProject.Location = new System.Drawing.Point(79, 44);
         this.CreateProject.Name = "CreateProject";
         this.CreateProject.Size = new System.Drawing.Size(351, 20);
         this.CreateProject.TabIndex = 24;
         this.CreateProject.Text = "{Project Required}";
         this.CreateProject.TextChanged += new System.EventHandler(this.CreateProject_TextChanged);
         this.CreateProject.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CreateProject_KeyDown);
         this.CreateProject.Leave += new System.EventHandler(this.CreateProject_Leave);
         // 
         // IssueTypeSelector
         // 
         this.IssueTypeSelector.FormattingEnabled = true;
         this.IssueTypeSelector.Location = new System.Drawing.Point(79, 19);
         this.IssueTypeSelector.Name = "IssueTypeSelector";
         this.IssueTypeSelector.Size = new System.Drawing.Size(248, 21);
         this.IssueTypeSelector.TabIndex = 23;
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Location = new System.Drawing.Point(11, 23);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(59, 13);
         this.label7.TabIndex = 11;
         this.label7.Text = "Issue Type";
         // 
         // UseTMobileQA
         // 
         this.UseTMobileQA.AutoSize = true;
         this.UseTMobileQA.Location = new System.Drawing.Point(838, 23);
         this.UseTMobileQA.Name = "UseTMobileQA";
         this.UseTMobileQA.Size = new System.Drawing.Size(84, 17);
         this.UseTMobileQA.TabIndex = 25;
         this.UseTMobileQA.Text = "T-Mobile QA";
         this.UseTMobileQA.UseVisualStyleBackColor = true;
         this.UseTMobileQA.CheckedChanged += new System.EventHandler(this.UseTMobileQA_Checked);
         // 
         // ReturnedJSON
         // 
         this.ReturnedJSON.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.ReturnedJSON.Location = new System.Drawing.Point(31, 152);
         this.ReturnedJSON.Multiline = true;
         this.ReturnedJSON.Name = "ReturnedJSON";
         this.ReturnedJSON.Size = new System.Drawing.Size(1113, 122);
         this.ReturnedJSON.TabIndex = 20;
         // 
         // GoMain
         // 
         this.GoMain.Location = new System.Drawing.Point(1087, 18);
         this.GoMain.Name = "GoMain";
         this.GoMain.Size = new System.Drawing.Size(75, 23);
         this.GoMain.TabIndex = 21;
         this.GoMain.Text = "GoMain";
         this.GoMain.UseVisualStyleBackColor = true;
         this.GoMain.Click += new System.EventHandler(this.GoMain_Click);
         // 
         // SelectorGroup
         // 
         this.SelectorGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.SelectorGroup.Controls.Add(this.panel1);
         this.SelectorGroup.Controls.Add(this.label3);
         this.SelectorGroup.Controls.Add(this.SearchURI);
         this.SelectorGroup.Controls.Add(this.ExecutionURI);
         this.SelectorGroup.Controls.Add(this.SearchButton);
         this.SelectorGroup.Controls.Add(this.JIRAKeyValue);
         this.SelectorGroup.Controls.Add(this.UseKeyValue);
         this.SelectorGroup.Location = new System.Drawing.Point(31, 49);
         this.SelectorGroup.Name = "SelectorGroup";
         this.SelectorGroup.Size = new System.Drawing.Size(1137, 97);
         this.SelectorGroup.TabIndex = 24;
         this.SelectorGroup.TabStop = false;
         this.SelectorGroup.Text = "WhatToLookFor";
         // 
         // panel1
         // 
         this.panel1.Controls.Add(this.Choose661);
         this.panel1.Controls.Add(this.PopulateBlockedMine);
         this.panel1.Controls.Add(this.PopulateBlockedAOP);
         this.panel1.Controls.Add(this.PopulateInitiative);
         this.panel1.Controls.Add(this.PopulateNoInit);
         this.panel1.Location = new System.Drawing.Point(217, 21);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(814, 37);
         this.panel1.TabIndex = 13;
         // 
         // Choose661
         // 
         this.Choose661.Location = new System.Drawing.Point(183, 4);
         this.Choose661.Name = "Choose661";
         this.Choose661.Size = new System.Drawing.Size(160, 23);
         this.Choose661.TabIndex = 12;
         this.Choose661.Text = "Populate STOR-661";
         this.Choose661.UseVisualStyleBackColor = true;
         this.Choose661.Click += new System.EventHandler(this.Choose661_Click);
         // 
         // PopulateBlockedMine
         // 
         this.PopulateBlockedMine.Location = new System.Drawing.Point(714, 4);
         this.PopulateBlockedMine.Name = "PopulateBlockedMine";
         this.PopulateBlockedMine.Size = new System.Drawing.Size(97, 23);
         this.PopulateBlockedMine.TabIndex = 13;
         this.PopulateBlockedMine.Text = "661";
         this.PopulateBlockedMine.UseVisualStyleBackColor = true;
         this.PopulateBlockedMine.Click += new System.EventHandler(this.PopulateBlockedMine_Click);
         // 
         // PopulateBlockedAOP
         // 
         this.PopulateBlockedAOP.Location = new System.Drawing.Point(537, 4);
         this.PopulateBlockedAOP.Name = "PopulateBlockedAOP";
         this.PopulateBlockedAOP.Size = new System.Drawing.Size(160, 23);
         this.PopulateBlockedAOP.TabIndex = 2;
         this.PopulateBlockedAOP.Text = "Populate a Blocked Story AOP";
         this.PopulateBlockedAOP.UseVisualStyleBackColor = true;
         this.PopulateBlockedAOP.Click += new System.EventHandler(this.PopulateBlockedAOP_Click);
         // 
         // PopulateInitiative
         // 
         this.PopulateInitiative.Location = new System.Drawing.Point(360, 3);
         this.PopulateInitiative.Name = "PopulateInitiative";
         this.PopulateInitiative.Size = new System.Drawing.Size(160, 25);
         this.PopulateInitiative.TabIndex = 11;
         this.PopulateInitiative.Text = "Populate an Initiative Story";
         this.PopulateInitiative.UseVisualStyleBackColor = true;
         this.PopulateInitiative.Click += new System.EventHandler(this.PopulateInitiative_Click);
         // 
         // PopulateNoInit
         // 
         this.PopulateNoInit.Location = new System.Drawing.Point(4, 4);
         this.PopulateNoInit.Name = "PopulateNoInit";
         this.PopulateNoInit.Size = new System.Drawing.Size(162, 23);
         this.PopulateNoInit.TabIndex = 10;
         this.PopulateNoInit.Text = "Populate a Non-Initative Story";
         this.PopulateNoInit.UseVisualStyleBackColor = true;
         this.PopulateNoInit.Click += new System.EventHandler(this.PopulateNoInit_Click);
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(7, 67);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(76, 13);
         this.label3.TabIndex = 9;
         this.label3.Text = "Execution URI";
         // 
         // SearchURI
         // 
         this.SearchURI.Location = new System.Drawing.Point(1056, 62);
         this.SearchURI.Name = "SearchURI";
         this.SearchURI.Size = new System.Drawing.Size(75, 23);
         this.SearchURI.TabIndex = 17;
         this.SearchURI.Text = "Search URI";
         this.SearchURI.UseVisualStyleBackColor = true;
         this.SearchURI.Click += new System.EventHandler(this.SearchURI_Click);
         // 
         // ExecutionURI
         // 
         this.ExecutionURI.Location = new System.Drawing.Point(111, 64);
         this.ExecutionURI.Name = "ExecutionURI";
         this.ExecutionURI.Size = new System.Drawing.Size(920, 20);
         this.ExecutionURI.TabIndex = 9;
         // 
         // SearchButton
         // 
         this.SearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.SearchButton.Location = new System.Drawing.Point(1056, 25);
         this.SearchButton.Name = "SearchButton";
         this.SearchButton.Size = new System.Drawing.Size(75, 23);
         this.SearchButton.TabIndex = 14;
         this.SearchButton.Text = "Search";
         this.SearchButton.UseVisualStyleBackColor = true;
         this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
         // 
         // JIRAKeyValue
         // 
         this.JIRAKeyValue.Location = new System.Drawing.Point(111, 21);
         this.JIRAKeyValue.Name = "JIRAKeyValue";
         this.JIRAKeyValue.Size = new System.Drawing.Size(100, 20);
         this.JIRAKeyValue.TabIndex = 6;
         this.JIRAKeyValue.Text = "INFUOP-1076";
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
         // 
         // UseTMobile
         // 
         this.UseTMobile.AutoSize = true;
         this.UseTMobile.Location = new System.Drawing.Point(936, 23);
         this.UseTMobile.Name = "UseTMobile";
         this.UseTMobile.Size = new System.Drawing.Size(66, 17);
         this.UseTMobile.TabIndex = 19;
         this.UseTMobile.Text = "T-Mobile";
         this.UseTMobile.UseVisualStyleBackColor = true;
         this.UseTMobile.CheckedChanged += new System.EventHandler(this.UseTMobile_Checked);
         // 
         // UseSeaTransplant
         // 
         this.UseSeaTransplant.AutoSize = true;
         this.UseSeaTransplant.Location = new System.Drawing.Point(719, 22);
         this.UseSeaTransplant.Name = "UseSeaTransplant";
         this.UseSeaTransplant.Size = new System.Drawing.Size(94, 17);
         this.UseSeaTransplant.TabIndex = 18;
         this.UseSeaTransplant.Text = "SeaTransplant";
         this.UseSeaTransplant.UseVisualStyleBackColor = true;
         this.UseSeaTransplant.CheckedChanged += new System.EventHandler(this.UseSeaTransplant_Checked);
         // 
         // PasswordField
         // 
         this.PasswordField.Location = new System.Drawing.Point(396, 22);
         this.PasswordField.Name = "PasswordField";
         this.PasswordField.PasswordChar = '*';
         this.PasswordField.Size = new System.Drawing.Size(292, 20);
         this.PasswordField.TabIndex = 17;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(336, 22);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(53, 13);
         this.label2.TabIndex = 23;
         this.label2.Text = "Password";
         // 
         // UserNameField
         // 
         this.UserNameField.Location = new System.Drawing.Point(95, 22);
         this.UserNameField.Name = "UserNameField";
         this.UserNameField.Size = new System.Drawing.Size(200, 20);
         this.UserNameField.TabIndex = 16;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(28, 22);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(60, 13);
         this.label1.TabIndex = 22;
         this.label1.Text = "User Name";
         // 
         // PostJSON
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.SystemColors.Info;
         this.ClientSize = new System.Drawing.Size(1185, 607);
         this.Controls.Add(this.POSTGrouping);
         this.Controls.Add(this.UseTMobileQA);
         this.Controls.Add(this.ReturnedJSON);
         this.Controls.Add(this.GoMain);
         this.Controls.Add(this.SelectorGroup);
         this.Controls.Add(this.UseTMobile);
         this.Controls.Add(this.UseSeaTransplant);
         this.Controls.Add(this.PasswordField);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.UserNameField);
         this.Controls.Add(this.label1);
         this.Name = "PostJSON";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "Search";
         this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
         this.POSTGrouping.ResumeLayout(false);
         this.EditItemGroupBox.ResumeLayout(false);
         this.EditItemGroupBox.PerformLayout();
         this.SelectOperation.ResumeLayout(false);
         this.SelectOperation.PerformLayout();
         this.SelectUserType.ResumeLayout(false);
         this.SelectUserType.PerformLayout();
         this.CreateItemGroupBox.ResumeLayout(false);
         this.CreateItemGroupBox.PerformLayout();
         this.SelectorGroup.ResumeLayout(false);
         this.SelectorGroup.PerformLayout();
         this.panel1.ResumeLayout(false);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion
      private System.Windows.Forms.ToolTip JQLWarning;
      private System.Windows.Forms.RadioButton UseTMobileQA;
      private System.Windows.Forms.TextBox ReturnedJSON;
      private System.Windows.Forms.Button GoMain;
      private System.Windows.Forms.GroupBox SelectorGroup;
      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.Button Choose661;
      private System.Windows.Forms.Button PopulateBlockedMine;
      private System.Windows.Forms.Button PopulateBlockedAOP;
      private System.Windows.Forms.Button PopulateInitiative;
      private System.Windows.Forms.Button PopulateNoInit;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Button SearchURI;
      private System.Windows.Forms.TextBox ExecutionURI;
      private System.Windows.Forms.Button SearchButton;
      private System.Windows.Forms.TextBox JIRAKeyValue;
      private System.Windows.Forms.RadioButton UseKeyValue;
      private System.Windows.Forms.RadioButton UseTMobile;
      private System.Windows.Forms.RadioButton UseSeaTransplant;
      private System.Windows.Forms.TextBox PasswordField;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TextBox UserNameField;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.GroupBox POSTGrouping;
      private System.Windows.Forms.GroupBox SelectOperation;
      private System.Windows.Forms.RadioButton CreateItem;
      private System.Windows.Forms.RadioButton EditItem;
      private System.Windows.Forms.Button PostCreate;
      private System.Windows.Forms.GroupBox SelectUserType;
      private System.Windows.Forms.RadioButton UseNTID;
      private System.Windows.Forms.RadioButton UseEmail;
      private System.Windows.Forms.Label label11;
      private System.Windows.Forms.Label label10;
      private System.Windows.Forms.Label label8;
      private System.Windows.Forms.TextBox UpdateAssignee;
      private System.Windows.Forms.GroupBox CreateItemGroupBox;
      private System.Windows.Forms.CheckBox ReporterIsAssignee;
      private System.Windows.Forms.TextBox CreateProject;
      private System.Windows.Forms.TextBox UpdateReporter;
      private System.Windows.Forms.ComboBox IssueTypeSelector;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.TextBox UpdateSummary;
      private System.Windows.Forms.TextBox UpdateDescription;
      private System.Windows.Forms.CheckBox Unassign;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.TextBox CreateReporter;
      private System.Windows.Forms.GroupBox EditItemGroupBox;
      private System.Windows.Forms.TextBox CreateSummary;
      private System.Windows.Forms.TextBox CreateDescription;
      private System.Windows.Forms.Label label12;
      private System.Windows.Forms.Label label13;
      private System.Windows.Forms.TextBox CreateAssignee;
      private System.Windows.Forms.Label label9;
      private System.Windows.Forms.Button PostUpdate;
      private System.Windows.Forms.TextBox EditIssueKey;
      private System.Windows.Forms.Label label14;
      private System.Windows.Forms.Label CreatedSuccessfully;
      private System.Windows.Forms.ComboBox UpdateEpicLinksCombo;
      private System.Windows.Forms.Label label15;
      private System.Windows.Forms.Label UpdatedSuccessfully;
      private System.Windows.Forms.ComboBox CreateEpicLinksCombo;
      private System.Windows.Forms.Label label16;
      private System.Windows.Forms.ComboBox UpdatePriority;
      private System.Windows.Forms.Label label18;
      private System.Windows.Forms.ComboBox CreatePriority;
      private System.Windows.Forms.Label label17;
   }
}

