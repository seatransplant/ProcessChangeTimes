using System;
using System.Windows.Forms;
using static BlockedItems.ProcessHistories;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace BlockedItems
{
   public partial class LookupForm : Form
   {

      private enum RequestServer
      {
         Cloud,
         TMobile
      }
      private UserCredentails UserLoginCredentials;
      //private SeaTransplant_JIRA_Schema.RootObject jSeaTransplant;
      private class ExportJSONList
      {
         private List<ExportJSON> ListOfJSONs = new List<ExportJSON>();

         public void AddJSON(ExportJSON value)
         {
            ListOfJSONs.Add(value);
         }

         public int Count
         {
            get
            {
               return ListOfJSONs.Count;
            }
         }

         public List<ExportJSON> Values
         {
            get
            {
               return ListOfJSONs;
            }
         }
      }
      private TMobile_INFUOPS_Schema.RootObject jTMobile;
      private TMobile_INFUOPS_Schema.Issue jSingleIssue;
      private string BaseURI;

      private RequestServer rs = RequestServer.TMobile;

      public LookupForm()
      {
         InitializeComponent();
#if DEBUG
         UseTMobile.Checked = true;
#endif
      }

      #region UIEvents
      private void UseSeaTransplant_Checked(object sender, EventArgs e)
      {
         if (UseSeaTransplant.Checked)
         {
            BaseURI = "https://seatransplant.atlassian.net/rest/api/2/";
            UserNameField.Text = "kodacoda@live.com";
            PasswordField.Text = "@ndyR0se!";
            // Leave Until Implemented rs = RequestServer.Cloud;
            // TODO: Wire to cloud
         }
      }
      private void UseTMobile_Checked(object sender, EventArgs e)
      {
         if (UseTMobile.Checked)
         {
            BaseURI = "https://jira.t-mobile.com/rest/api/2/";
            UserNameField.Text = "scostan";
#if DEBUG
            PasswordField.Text = "BECU8108!";
#else
            txtPassword.Text = String.Empty;
#endif
            rs = RequestServer.TMobile;
         }
      }

      private void CheckChangeLog_CheckedChanged(object sender, EventArgs e)
      {
         DetailChangeLog.Checked = CheckChangeLog.Checked;
      }

      private void JIRAKeyValue_TextChanged(object sender, EventArgs e)
      {
         UseKeyValue.Checked = true;

      }


      private void ListOfResults_Click(object sender, EventArgs e)
      {
         DebugOutputValue = string.Format("Clicked ListOfResults {0}", ListOfResults.SelectedIndices.Count);
         if (ListOfResults.SelectedIndices.Count != 0)
         {
            ShowItemDetails.Text = String.Format("Show Details for {0}", ListOfResults.SelectedItems[0].Text);
            ShowItemDetails.Enabled = true;
         }

      }

      private void UseFilter_CheckedChanged(object sender, EventArgs e)
      {
         CheckChangeLog.Enabled = false;
         CheckChangeLog.Checked = false;
      }

      private void UseKeyValue_CheckedChanged(object sender, EventArgs e)
      {
         CheckChangeLog.Enabled = true;
      }

      private void UseJQL_CheckedChanged(object sender, EventArgs e)
      {
         CheckChangeLog.Enabled = false;
         CheckChangeLog.Checked = false;
      }

      private void JQLValue_TextChanged(object sender, EventArgs e)
      {
         UseJQL.Checked = true;
      }

      private void PopulateNoInit_Click(object sender, EventArgs e)
      {
         JIRAKeyValue.Text = "INFAOP-406";
      }

      private void PopulateInitiative_Click(object sender, EventArgs e)
      {
         JIRAKeyValue.Text = "INFAOP-643";
      }

      private void PopulateBlockedAOP_Click(object sender, EventArgs e)
      {
         JIRAKeyValue.Text = "INFAOP-445";
      }

      private void PopulateBlockedMine_Click(object sender, EventArgs e)
      {
         JIRAKeyValue.Text = "INFUOP-988";
         SearchButton_Click(sender, e);
         ShowItemDetails_Click(sender, e);
      }

      private void Choose661_Click(object sender, EventArgs e)
      {
         JIRAKeyValue.Text = "STOR-661";
         SearchButton_Click(sender, e);
         ShowItemDetails_Click(sender, e);


      }
      #endregion
      public string DebugOutputValue
      {
         set { System.Diagnostics.Debug.Write(value + Environment.NewLine); }
      }

      public string JSONOutputValue
      {
         set
         {
            JSONOutput(value);
            DebugOutputValue = value;
         }
      }

      public void ResetFormFieldsForRequest()
      {
         ListOfResults.Items.Clear();
         ListOfResults.Refresh();
         JSONOutput(string.Empty);

         ShowItemDetails.Enabled = false;
         ShowItemDetails.Text = "Select an item";

      }

      public void JSONOutput(string Display)
      {
         ReturnedJSON.Text = Display;
         ReturnedJSON.Refresh();

      }



      private void SearchButton_Click(object sender, EventArgs e)
      {
         string targetURI = BaseURI;
         ExportProgressBar.Visible = false;
         JSONOutput("Calling JIRA");

         if (UseJQL.Checked)
         {
            targetURI += "search?jql=" + JQLValue.Text.ToString();
         }
         else
         {
            if (UseFilter.Checked)
            {
               targetURI += "search/?jql=filter=" + FilterID.Text.ToString();
               if (BlockedOnly.Checked)
                  targetURI += " AND Status = Blocked";
               if (CheckChangeLog.Checked)
               {
                  CheckChangeLog.Checked = false;
                  JSONOutput("Calling JIRA - Unable to Check Change Log on a filter");
               }
            }
            else if (UseKeyValue.Checked)
               targetURI += "issue/" + JIRAKeyValue.Text;

            if (CheckChangeLog.Checked)
               targetURI += "?expand=changelog";
         }

         if (!UseKeyValue.Checked)
         {
            int value = Convert.ToInt16(MaxRecords.Text);
            if (value < 0)
            {
               value = 50;
               MaxRecords.Text = "50";
            }
            targetURI += string.Format("&maxResults={0}", value);

            value = Convert.ToInt16(StartAt.Text);
            if (value < 0)
            {
               value = 0;
               StartAt.Text = "0";
            }

            targetURI += string.Format("&startAt={0}", value);
         }

         ExecutionURI.Text = targetURI;
         ExecutionURI.Refresh();

         SearchURI_Click(sender, e);
      }

      private void SearchURI_Click(object sender, EventArgs e)
      {
         ExportProgressBar.Visible = false;
         if (ExecutionURI.Text != string.Empty)
         {
            ResetFormFieldsForRequest();
            UserLoginCredentials = new UserCredentails
            {
               UserName = UserNameField.Text.ToString(),
               Password = PasswordField.Text.ToString()
            };

            GeneralFunctions generalFunctions = new GeneralFunctions();
            RestResponse restResponse = new RestResponse();
            JSONOutputValue = "Calling ExecuteJSONRequest";
            try
            {

               restResponse = generalFunctions.ExecuteJSONRequest(ExecutionURI.Text, UserLoginCredentials);
               if (restResponse.RestCallSuccessful)
               {
                  JSONOutputValue = restResponse.RestCallResponse;
                  if (rs == RequestServer.TMobile)
                     try
                     {
                        if (ProcessTMobile_INFUOPS())
                        {
                           DebugOutputValue = "Completed. Displaying";

                           if (jTMobile != null)
                              LoadTMobileListView();
                           else
                           {
                              AddToList(jSingleIssue);
                              ListOfResults.Items[0].Selected = true;
                           }

                           ShowWarningInformation();
                        }
                     }
                     catch (Exception ex)
                     {
                        DebugOutputValue = ex.Message;
                     }
               }
               else
                  JSONOutputValue = restResponse.RestCallException.Message;
            }
            catch (Exception ex)
            { DebugOutputValue = ex.Message; }
         }
      }


      #region TMobileSpecific
      private bool ProcessTMobile_INFUOPS()
      {

         string JSONOutput = ReturnedJSON.Text.ToString();
         bool Response = false;

         DebugOutputValue = "In ProcessTMobile";
         jTMobile = null;
         jSingleIssue = null;

         if (ExecutionURI.Text.ToString().IndexOf("/issue/") == -1)
         {
            DebugOutputValue = "Non-Issue Process";
            jTMobile = TMobile_INFUOPS_Interface.ProcessINFUOP_Issues(this, JSONOutput);
            if (jTMobile == null || jTMobile.issues == null)
               DebugOutputValue = "No Records Returned";
            else
               Response = true;
         }
         else
         {
            DebugOutputValue = "Single Issue, deserializing";
            jSingleIssue = TMobile_INFUOPS_Interface.DeserializeJSONINFUOPSingle(this, JSONOutput);
            if (jSingleIssue == null)
               DebugOutputValue = "No Records Returned";
            else
            {
               jTMobile = new TMobile_INFUOPS_Schema.RootObject
               {
                  maxResults = 1,
                  startAt = 1,
                  total = 1,
                  issues = new TMobile_INFUOPS_Schema.Issue[] { jSingleIssue }
               };
               Response = true;
            }
         }

         return Response;
      }

      private void ShowWarningInformation()
      {
         if (BlockedOnly.Checked && ListOfResults.Items.Count == 0)
            ShowNoBlocked.Visible = true;
         else
            ShowNoBlocked.Visible = false;
      }

      private void LoadTMobileListView()
      {
         foreach (TMobile_INFUOPS_Schema.Issue value in jTMobile.issues)
         {
            if (value.fields.parent != null)
            {
               DebugOutputValue = value.fields.parent.ToString();
            }
            AddToList(value);
         }
      }

      private void AddToList(TMobile_INFUOPS_Schema.Issue value)
      {

         /* FOR TESTING ONLY
         string SprintValue;
         if (value.fields.customfield_10004.Length != 0)
            foreach (string SprintValueSegment in value.fields.customfield_10004)
               SprintValue = GeneralFunctions.SprintName(SprintValueSegment);
               */

         //ListOfResults.Items.Add("Column1Text").SubItems.AddRange(new string[] { "col1;row1", "col2;row1" });

         // Todo issue.changelog.histories.Length
         // todo issue.fields.customfield_21004.Length
         if (!BlockedOnly.Checked || BlockedOnly.Checked && value.fields.status.name == "Blocked")
         {
            string BlockedReasons = string.Empty;

            if (value.fields.customfield_21004 != null)
            {
               foreach (TMobile_INFUOPS_Schema.Customfield_21004 item in value.fields.customfield_21004)
               {
                  if (BlockedReasons != String.Empty)
                  {
                     BlockedReasons = "{Multiple} " + BlockedReasons;
                     break;
                  }
                  else
                     BlockedReasons += item.value.ToString() + Environment.NewLine;
               }
            }
            ListOfResults.Items.Add(value.key.ToString()).SubItems.AddRange(new string[] { value.fields.status.name, value.fields.summary, BlockedReasons });
         }
      }
      #endregion


      private void ShowItemDetails_Click(object sender, EventArgs e)
      {
         TMobile_INFUOPS_Schema.Issue jDetail;
         RestResponse restResponse = null;

         ExportProgressBar.Visible = false;
         if (DetailChangeLog.Checked == false)
         {
            if (jSingleIssue != null)
               jDetail = jSingleIssue;
            else
               jDetail = jTMobile.issues[ListOfResults.SelectedItems[0].Index];
         }
         else if (CheckChangeLog.Checked == true)           // This can only be checked if it is a single issue.
            jDetail = jSingleIssue;
         else
         {
            int ListIndex = 0;
            ListIndex = ListOfResults.SelectedItems[0].Index;
            restResponse = PullChangeRecord(jTMobile.issues[ListIndex].self);
            jDetail = TMobile_INFUOPS_Interface.DeserializeJSONINFUOPSingle(this, restResponse.RestCallResponse);
         }
         if (jDetail != null)
         {
            DetailView detail = new DetailView
            {
               LoginCredentials = UserLoginCredentials,
               URLPrefix = BaseURI,
               DetailItem = jDetail
            };
            DebugOutputValue = "Showing the Detail View";
            detail.ShowDialog();
            DebugOutputValue = "Detail View Closed";
         }
         else
            MessageBox.Show("No Detail Record Retured", "Detail Record", MessageBoxButtons.OK);
      }

      private RestResponse PullChangeRecord(string itemURL)
      {
         GeneralFunctions generalFunctions = new GeneralFunctions();
         RestResponse restResponse = new RestResponse();

         string targetURI = String.Format("{0}?expand=changelog", itemURL);

         restResponse = generalFunctions.ExecuteJSONRequest(targetURI, UserLoginCredentials);
         return restResponse;
      }


      private void ExportAllRecords_Click(object sender, EventArgs e)
      {
         ExportJSON specificIssue = new ExportJSON();
         ProcessHistories history = new ProcessHistories();
         string itemJQL = string.Empty;
         string targetURI = string.Empty;
         RestResponse restResponse = null;
         TMobile_INFUOPS_Schema.Issue jDetail;
         GeneralFunctions gf = new GeneralFunctions();
         ExportJSONList exportJSONList = new ExportJSONList();

         try
         {
            ExportProgressBar.Maximum = jTMobile.issues.Length;
            ExportProgressBar.ForeColor = System.Drawing.Color.Magenta;
            ExportProgressBar.Gradient = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            ExportProgressBar.Style = ProgressBarStyle.Blocks;
            ExportProgressBar.Value = 0;
            ExportProgressBar.Visible = true;

            this.Enabled = false;
            foreach (TMobile_INFUOPS_Schema.Issue issue in jTMobile.issues)
            {
               ExportProgressBar.Value += 1;

               if (issue.changelog == null & !JSONNoHistoryRecords.Checked)
               {
                  targetURI = String.Format("{0}?expand=changelog", issue.self);

                  restResponse = gf.ExecuteJSONRequest(targetURI, UserLoginCredentials, false);
                  jDetail = TMobile_INFUOPS_Interface.DeserializeJSONINFUOPSingle(this, restResponse.RestCallResponse);
               }
               else
                  jDetail = issue;

               if (jDetail != null)
               {
                  specificIssue = history.SetupJSONExport(BlockedChangeRecordsOnlyJSON.Checked, jDetail, history.ShowChangeLogs(jDetail, null));
                  if (specificIssue != null)
                     if (!BlockedChangeRecordsOnlyJSON.Checked)                     // If we are showing all history records
                        exportJSONList.AddJSON(specificIssue);                      // then add the record
                     else if (specificIssue.BlockRecords.Count != 0)                // Since we are only showing blocked records
                        exportJSONList.AddJSON(specificIssue);                      // add only if the specific issue has a blocked item

               }
            }

            if (exportJSONList.Count != 0)
            {
               string SendIt = JsonConvert.SerializeObject(exportJSONList);
               Clipboard.SetText(SendIt);
               DebugOutputValue = "Sent to Clipboard";
            }
            ExportProgressBar.ForeColor = System.Drawing.Color.Green;
            ExportProgressBar.Style = ProgressBarStyle.Marquee;
            ExportProgressBar.Gradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
         }
         catch (Exception ex)
         {
            System.Diagnostics.Debug.WriteLine(ex.Message);
         }

         this.Enabled = true;
      }

      private void Main_Load(object sender, EventArgs e)
      {

      }

      private void BtnLaunchPostJSON_Click(object sender, EventArgs e)
      {
         PostJSON x = new PostJSON();
         x.Show();
      }
   }



}

