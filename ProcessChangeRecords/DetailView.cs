using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static BlockedItems.ProcessHistories;
using static BlockedItems.ValidationFunctions;

namespace BlockedItems
{
   public partial class DetailView : Form
   {

      #region declaration and initialization
      private TMobile_INFUOPS_Schema.Issue singleIssue = null;
      private UserCredentails userCreds = null;
      private string BaseURL = string.Empty;
      ChangedCollection changes = new ChangedCollection();
      ExportJSON SendJSON = new ExportJSON();
      #endregion

      #region accessors form creation
      public string URLPrefix
      {
         set { BaseURL = value; }
      }
      public UserCredentails LoginCredentials
      {
         set
         {
            userCreds = value;
            if (singleIssue != null)
               PopulateForm();
         }
      }
      public TMobile_INFUOPS_Schema.Issue DetailItem
      {
         set
         {
            singleIssue = value;
            if (userCreds != null)
               PopulateForm();
         }
      }
      public DetailView()
      {
         InitializeComponent();
      }
      #endregion

      #region accessors from history processing
      public string HistoryRecord
      {
         get
         {
            return HistoryData.Items[HistoryData.Items.Count - 1].ToString();
         }
         set
         {
            HistoryData.Items.Add(value);
         }
      }
      public ListViewItem BlockedListRecord
      {
         set
         {
            BlockedList.Items.Add(value);
         }
      }
      #endregion




      private void PopulateForm()
      {
         string checkValue = string.Empty;
         GeneralFunctions retrieveJSON = new GeneralFunctions();

         if (singleIssue != null)
         {

            TMobile_INFUOPS_Schema.Fields fields = singleIssue.fields;
            IssueType.Text = fields.issuetype.name;
            JIRAKey.Text = singleIssue.key;
            JIRAStatus.Text = fields.status.name;
            if (fields.resolution != null)
               JIRAStatus.Text = string.Format("Resolution: {0} on {1}", fields.resolution.name, fields.resolutiondate);
            else
               JIRAStatus.Text = fields.status.name;

            if (fields.assignee != null)
               JIRAAssignee.Text = ValidationFunctions.IsNullString(fields.assignee.emailAddress);

            // 10004 - Sprints
            // 10006 - Epic Link
            // 11200 - Initiative Link
            if (!PullEpic(IsNullString(fields.customfield_10006), retrieveJSON)) // PullInitative is inherent when pulling the epic.
               PullInitiative(IsNullString(fields.customfield_11200), retrieveJSON);


            if (fields.customfield_10004 != null)
            {
               NumberOfSprints.Text = String.Format("{0} Sprints", IsNullString(fields.customfield_10004.Length));
               foreach (string value in fields.customfield_10004)
                  SprintList.Items.Add(SprintName(value));
            }
            else
               NumberOfSprints.Text = "Not in a sprint.";

            if (singleIssue.changelog != null)
            {
               ProcessHistories ph = new ProcessHistories();
               changes = ph.ShowChangeLogs(singleIssue, this);
               BlockedHeader.Text = String.Format("Change Records {0}. Switched into Blocked State {3} times; Reason Changed {1} times; Unblocked Date Changed {2}",
                  changes.NumberOfBlockingRecords, changes.NumberOfTimesReasonChanged, changes.NumberOfTimesUnblockedDateChanged, changes.NumberOfTimesBlocked);

            }
            else
               ShowNoChangeLog.Visible = true;
         }
         else
         {
            MessageBox.Show("No issue provided.", "Unable to open Detail", MessageBoxButtons.OK);
            this.Close();
         }
      }


      private bool PullEpic(string checkValue, GeneralFunctions retrieveJSON)
      {
         bool response = false;

         if (checkValue != string.Empty)
         {
            string URI = string.Format("{0}issue/{1}?fields=summary,customfield_11200", BaseURL, checkValue);
            RestResponse restResponse = new RestResponse();
            restResponse = retrieveJSON.ExecuteJSONRequest(URI, userCreds);
            if (restResponse.RestCallSuccessful)
            {
               retrieveJSON.DebugOutputValue = "Successful Detail Call";
               EpicInitative.Rootobject epicInitative = new EpicInitative.Rootobject();
               epicInitative = JsonConvert.DeserializeObject<EpicInitative.Rootobject>(restResponse.RestCallResponse);
               EpicInformation.Text = String.Format("Epic: {0}:{1}", epicInitative.key, epicInitative.fields.summary);
               PullInitiative(IsNullString(epicInitative.fields.customfield_11200), retrieveJSON);
               response = true;
            }
         }
         else
            EpicInformation.Text = "No Epic";

         return response;
      }

      private void PullInitiative(string checkValue, GeneralFunctions retrieveJSON)
      {
         if (checkValue != String.Empty)
            try
            {
               string URI = string.Format("{0}issue/{1}", BaseURL, checkValue);
               RestResponse restResponse = retrieveJSON.ExecuteJSONRequest(URI, userCreds);
               if (restResponse.RestCallSuccessful)
               {
                  retrieveJSON.DebugOutputValue = "Initiative Call Successful";
                  TMobile_INFUOPS_Schema.Issue initative = JsonConvert.DeserializeObject<TMobile_INFUOPS_Schema.Issue>(restResponse.RestCallResponse);
                  Initiative.Text = String.Format("Initative: {0}:{1}", initative.key, initative.fields.summary);
               }

            }
            catch (Exception ex)
            { retrieveJSON.DebugOutputValue = ex.Message; }
         else
            Initiative.Text = "No Initative";
      }


      private void JSONIZE_Click(object sender, EventArgs e)
      {

         ExportJSON SendJSON = new ExportJSON();
         ProcessHistories ph = new ProcessHistories();

         SendJSON = ph.SetupJSONExport(JSONBlocked.Checked, singleIssue, changes);
         string SendIt = JsonConvert.SerializeObject(SendJSON);
         Clipboard.SetText(SendIt);

         System.Diagnostics.Debug.WriteLine("Sent to Clipboard");
      }
   }

}
