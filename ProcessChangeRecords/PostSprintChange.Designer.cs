namespace BlockedItems
{
   partial class PostSprintChanges 
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
         this.SelectedSprintName = new System.Windows.Forms.Label();
         this.UpdatedSuccessfully = new System.Windows.Forms.Label();
         this.EditSprintID = new System.Windows.Forms.TextBox();
         this.label14 = new System.Windows.Forms.Label();
         this.PostUpdate = new System.Windows.Forms.Button();
         this.UpdateSprintName = new System.Windows.Forms.TextBox();
         this.label8 = new System.Windows.Forms.Label();
         this.UseTMobileQA = new System.Windows.Forms.RadioButton();
         this.ReturnedJSON = new System.Windows.Forms.TextBox();
         this.SelectorGroup = new System.Windows.Forms.GroupBox();
         this.SprintListing = new System.Windows.Forms.ListView();
         this.SprintKey = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.SprintName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.SprintStart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.label3 = new System.Windows.Forms.Label();
         this.SearchURI = new System.Windows.Forms.Button();
         this.ExecutionURI = new System.Windows.Forms.TextBox();
         this.SearchButton = new System.Windows.Forms.Button();
         this.UseTMobile = new System.Windows.Forms.RadioButton();
         this.PasswordField = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.UserNameField = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.UseSeaTransplant = new System.Windows.Forms.RadioButton();
         this.POSTGrouping.SuspendLayout();
         this.EditItemGroupBox.SuspendLayout();
         this.SelectorGroup.SuspendLayout();
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
         this.POSTGrouping.BackColor = System.Drawing.SystemColors.ControlDarkDark;
         this.POSTGrouping.Controls.Add(this.EditItemGroupBox);
         this.POSTGrouping.Location = new System.Drawing.Point(31, 455);
         this.POSTGrouping.Name = "POSTGrouping";
         this.POSTGrouping.Size = new System.Drawing.Size(1117, 200);
         this.POSTGrouping.TabIndex = 26;
         this.POSTGrouping.TabStop = false;
         this.POSTGrouping.Text = "(Unavailable) Edit Sprint";
         this.JQLWarning.SetToolTip(this.POSTGrouping, "You cannot edit an issue found by JQL or Filter");
         // 
         // EditItemGroupBox
         // 
         this.EditItemGroupBox.Controls.Add(this.SelectedSprintName);
         this.EditItemGroupBox.Controls.Add(this.UpdatedSuccessfully);
         this.EditItemGroupBox.Controls.Add(this.EditSprintID);
         this.EditItemGroupBox.Controls.Add(this.label14);
         this.EditItemGroupBox.Controls.Add(this.PostUpdate);
         this.EditItemGroupBox.Controls.Add(this.UpdateSprintName);
         this.EditItemGroupBox.Controls.Add(this.label8);
         this.EditItemGroupBox.Enabled = false;
         this.EditItemGroupBox.Location = new System.Drawing.Point(12, 30);
         this.EditItemGroupBox.Name = "EditItemGroupBox";
         this.EditItemGroupBox.Size = new System.Drawing.Size(554, 122);
         this.EditItemGroupBox.TabIndex = 41;
         this.EditItemGroupBox.TabStop = false;
         this.EditItemGroupBox.Text = "Edit Item";
         // 
         // SelectedSprintName
         // 
         this.SelectedSprintName.AutoSize = true;
         this.SelectedSprintName.Location = new System.Drawing.Point(214, 18);
         this.SelectedSprintName.Name = "SelectedSprintName";
         this.SelectedSprintName.Size = new System.Drawing.Size(35, 13);
         this.SelectedSprintName.TabIndex = 56;
         this.SelectedSprintName.Text = "label5";
         // 
         // UpdatedSuccessfully
         // 
         this.UpdatedSuccessfully.AutoSize = true;
         this.UpdatedSuccessfully.Location = new System.Drawing.Point(160, 80);
         this.UpdatedSuccessfully.Name = "UpdatedSuccessfully";
         this.UpdatedSuccessfully.Size = new System.Drawing.Size(0, 13);
         this.UpdatedSuccessfully.TabIndex = 51;
         // 
         // EditSprintID
         // 
         this.EditSprintID.BackColor = System.Drawing.SystemColors.Info;
         this.EditSprintID.Location = new System.Drawing.Point(117, 15);
         this.EditSprintID.Name = "EditSprintID";
         this.EditSprintID.Size = new System.Drawing.Size(91, 20);
         this.EditSprintID.TabIndex = 43;
         this.EditSprintID.TabStop = false;
         // 
         // label14
         // 
         this.label14.AutoSize = true;
         this.label14.Location = new System.Drawing.Point(10, 22);
         this.label14.Name = "label14";
         this.label14.Size = new System.Drawing.Size(53, 13);
         this.label14.TabIndex = 42;
         this.label14.Text = "Edit Issue";
         // 
         // PostUpdate
         // 
         this.PostUpdate.Location = new System.Drawing.Point(13, 80);
         this.PostUpdate.Name = "PostUpdate";
         this.PostUpdate.Size = new System.Drawing.Size(75, 23);
         this.PostUpdate.TabIndex = 40;
         this.PostUpdate.Text = "Update";
         this.PostUpdate.UseVisualStyleBackColor = true;
         this.PostUpdate.Click += new System.EventHandler(this.PostUpdates_Click);
         // 
         // UpdateSprintName
         // 
         this.UpdateSprintName.BackColor = System.Drawing.SystemColors.Window;
         this.UpdateSprintName.Location = new System.Drawing.Point(117, 47);
         this.UpdateSprintName.Name = "UpdateSprintName";
         this.UpdateSprintName.Size = new System.Drawing.Size(351, 20);
         this.UpdateSprintName.TabIndex = 33;
         // 
         // label8
         // 
         this.label8.AutoSize = true;
         this.label8.Location = new System.Drawing.Point(10, 50);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(90, 13);
         this.label8.TabIndex = 32;
         this.label8.Text = "New Sprint Name";
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
         this.ReturnedJSON.Location = new System.Drawing.Point(31, 327);
         this.ReturnedJSON.Multiline = true;
         this.ReturnedJSON.Name = "ReturnedJSON";
         this.ReturnedJSON.Size = new System.Drawing.Size(1113, 122);
         this.ReturnedJSON.TabIndex = 20;
         // 
         // SelectorGroup
         // 
         this.SelectorGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.SelectorGroup.Controls.Add(this.SprintListing);
         this.SelectorGroup.Controls.Add(this.label3);
         this.SelectorGroup.Controls.Add(this.SearchURI);
         this.SelectorGroup.Controls.Add(this.ExecutionURI);
         this.SelectorGroup.Controls.Add(this.SearchButton);
         this.SelectorGroup.Location = new System.Drawing.Point(31, 49);
         this.SelectorGroup.Name = "SelectorGroup";
         this.SelectorGroup.Size = new System.Drawing.Size(1137, 272);
         this.SelectorGroup.TabIndex = 24;
         this.SelectorGroup.TabStop = false;
         this.SelectorGroup.Text = "WhatToLookFor";
         // 
         // SprintListing
         // 
         this.SprintListing.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SprintKey,
            this.SprintName,
            this.SprintStart});
         this.SprintListing.GridLines = true;
         this.SprintListing.Location = new System.Drawing.Point(12, 25);
         this.SprintListing.Name = "SprintListing";
         this.SprintListing.Size = new System.Drawing.Size(1019, 215);
         this.SprintListing.TabIndex = 18;
         this.SprintListing.UseCompatibleStateImageBehavior = false;
         this.SprintListing.View = System.Windows.Forms.View.Details;
         this.SprintListing.SelectedIndexChanged += new System.EventHandler(this.SprintListing_SelectedIndexChanged);
         // 
         // SprintKey
         // 
         this.SprintKey.Text = "Sprint Key";
         this.SprintKey.Width = 135;
         // 
         // SprintName
         // 
         this.SprintName.Text = "Sprint Name";
         this.SprintName.Width = 211;
         // 
         // SprintStart
         // 
         this.SprintStart.Text = "Sprint Start";
         this.SprintStart.Width = 150;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(7, 249);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(76, 13);
         this.label3.TabIndex = 9;
         this.label3.Text = "Execution URI";
         // 
         // SearchURI
         // 
         this.SearchURI.Location = new System.Drawing.Point(1042, 239);
         this.SearchURI.Name = "SearchURI";
         this.SearchURI.Size = new System.Drawing.Size(75, 23);
         this.SearchURI.TabIndex = 17;
         this.SearchURI.Text = "Search URI";
         this.SearchURI.UseVisualStyleBackColor = true;
         this.SearchURI.Click += new System.EventHandler(this.SearchURI_Click);
         // 
         // ExecutionURI
         // 
         this.ExecutionURI.Location = new System.Drawing.Point(111, 246);
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
         // PostSprintChanges
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.SystemColors.ActiveCaption;
         this.ClientSize = new System.Drawing.Size(1185, 661);
         this.Controls.Add(this.POSTGrouping);
         this.Controls.Add(this.UseTMobileQA);
         this.Controls.Add(this.ReturnedJSON);
         this.Controls.Add(this.SelectorGroup);
         this.Controls.Add(this.UseTMobile);
         this.Controls.Add(this.UseSeaTransplant);
         this.Controls.Add(this.PasswordField);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.UserNameField);
         this.Controls.Add(this.label1);
         this.Name = "PostSprintChanges";
         this.Text = "Search";
         this.TopMost = true;
         this.POSTGrouping.ResumeLayout(false);
         this.EditItemGroupBox.ResumeLayout(false);
         this.EditItemGroupBox.PerformLayout();
         this.SelectorGroup.ResumeLayout(false);
         this.SelectorGroup.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion
      private System.Windows.Forms.ToolTip JQLWarning;
      private System.Windows.Forms.RadioButton UseTMobileQA;
      private System.Windows.Forms.TextBox ReturnedJSON;
      private System.Windows.Forms.GroupBox SelectorGroup;
      private System.Windows.Forms.Button SearchButton;
      private System.Windows.Forms.RadioButton UseTMobile;
      private System.Windows.Forms.TextBox PasswordField;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TextBox UserNameField;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.GroupBox POSTGrouping;
      private System.Windows.Forms.Label label8;
      private System.Windows.Forms.TextBox UpdateSprintName;
      private System.Windows.Forms.GroupBox EditItemGroupBox;
      private System.Windows.Forms.Button PostUpdate;
      private System.Windows.Forms.TextBox EditSprintID;
      private System.Windows.Forms.Label label14;
      private System.Windows.Forms.Label UpdatedSuccessfully;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Button SearchURI;
      private System.Windows.Forms.TextBox ExecutionURI;
      private System.Windows.Forms.RadioButton UseSeaTransplant;
      private System.Windows.Forms.ListView SprintListing;
      private System.Windows.Forms.ColumnHeader SprintKey;
      private System.Windows.Forms.ColumnHeader SprintName;
      private System.Windows.Forms.ColumnHeader SprintStart;
      private System.Windows.Forms.Label SelectedSprintName;
   }
}

