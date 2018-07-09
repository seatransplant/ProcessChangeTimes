using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;
using static BlockedItems.ProcessHistories;

namespace BlockedItems
{
   public partial class PostJSON : Form
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

      private class EpicData
      {
         private string EpicKeyValue;
         private string EpicKeyName;

         public string EpicKey
         {
            get
            {
               return EpicKeyValue;
            }

            set
            {
               EpicKeyValue = value;
            }
         }

         public string EpicName
         {
            get
            {
               return EpicKeyName;
            }

            set
            {
               EpicKeyName = value;
            }
         }
      }

      private List<TMobile_INFUOPS_Schema.Issuetype> UsedIssuetypes = new List<TMobile_INFUOPS_Schema.Issuetype>();
      private List<EpicData> UpdateEpics = new List<EpicData>();
      private List<EpicData> CreateEpics = new List<EpicData>();
      private bool IgnoreTextChange = false;

      private string BaseURI;

      private RequestServer rs = RequestServer.TMobile;

      public PostJSON()
      {
         InitializeComponent();
#if DEBUG
         UseTMobile.Checked = true;
#endif
      }

      private void GatherItemTypes()
      {
         UserLoginCredentials = new UserCredentails
         {
            UserName = UserNameField.Text,
            Password = PasswordField.Text
         };

         GeneralFunctions generalFunctions = new GeneralFunctions();
         try
         {

            RestResponse restResponse = generalFunctions.ExecuteJSONRequest(String.Concat(BaseURI, "issuetype"), UserLoginCredentials);
            if (restResponse.RestCallSuccessful)
            {
               string itemTypeJson = restResponse.RestCallResponse;
               if (rs == RequestServer.TMobile)
                  try
                  {
                     TMobile_INFUOPS_Interface.DeserializeItemType issueDeserializeItemType = new TMobile_INFUOPS_Interface.DeserializeItemType();
                     List<TMobile_INFUOPS_Schema.Issuetype> issueTypes = issueDeserializeItemType.ProcessINFUOP_IssueTypes(itemTypeJson);
                     if (issueTypes != null)
                     {
                        // Specify each item type that could be created
                        foreach (TMobile_INFUOPS_Schema.Issuetype value in issueTypes)
                           switch (value.name)
                           {
                              case "Story":
                              case "Bug":
                              case "Task":
                              case "Kaizen":
                                 UsedIssuetypes.Add(value);
                                 break;
                              default:
                                 break;
                           }
                     }
                     else
                     {
                        DebugOutputValue = "No Item Types Returned.";
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

         if (UsedIssuetypes.Count != 0)
         {
            IssueTypeSelector.DataSource = UsedIssuetypes;
            IssueTypeSelector.DisplayMember = "name";
            IssueTypeSelector.ValueMember = "id";
         }

         CreatePriority.Items.Clear();
         CreatePriority.Items.Add("Critical");
         CreatePriority.Items.Add("Major");
         CreatePriority.Items.Add("Medium");
         CreatePriority.Items.Add("Minor");


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
            GatherItemTypes();
         }
      }

      private void UseTMobileQA_Checked(object sender, EventArgs e)
      {
         if (UseTMobileQA.Checked)
         {
            BaseURI = "https://jiraqat.t-mobile.com/rest/api/2/";
            UserNameField.Text = ConfigurationManager.AppSettings["QAUserName"];
#if DEBUG
            PasswordField.Text = ConfigurationManager.AppSettings["QAPassword"]; ;
#else
            txtPassword.Text = String.Empty;
#endif
            rs = RequestServer.TMobile;
            GatherItemTypes();
            GetEpics();

         }
      }


      private void UseTMobile_Checked(object sender, EventArgs e)
      {
         if (UseTMobile.Checked)
         {
            BaseURI = "https://jira.t-mobile.com/rest/api/2/";
            UserNameField.Text = ConfigurationManager.AppSettings["ProdUser"].ToString();
#if DEBUG
            PasswordField.Text = ConfigurationManager.AppSettings["ProdPassword"];
#else
            txtPassword.Text = String.Empty;
#endif

            rs = RequestServer.TMobile;
            GatherItemTypes();
            GetEpics();
         }
      }

      //private void CheckChangeLog_CheckedChanged(object sender, EventArgs e)
      //{
      //   DetailChangeLog.Checked = CheckChangeLog.Checked;
      //}

      private void JIRAKeyValue_TextChanged(object sender, EventArgs e)
      {
         UseKeyValue.Checked = true;

      }


      //private void ListOfResults_Click(object sender, EventArgs e)
      //{
      //   DebugOutputValue = string.Format("Clicked ListOfResults {0}", ListOfResults.SelectedIndices.Count);
      //   if (ListOfResults.SelectedIndices.Count != 0)
      //   {
      //      ShowItemDetails.Text = String.Format("Show Details for {0}", ListOfResults.SelectedItems[0].Text);
      //      ShowItemDetails.Enabled = true;
      //   }

      //}

      private void UseFilter_CheckedChanged(object sender, EventArgs e)
      {
         EditItem.Enabled = false;
         //CheckChangeLog.Enabled = false;
         //CheckChangeLog.Checked = false;
      }

      private void UseKeyValue_CheckedChanged(object sender, EventArgs e)
      {
         EditItem.Enabled = true;
         EditIssueKey.Text = UseKeyValue.Text;
         //CheckChangeLog.Enabled = true;
      }

      private void UseJQL_CheckedChanged(object sender, EventArgs e)
      {
         EditItem.Enabled = false;
         //CheckChangeLog.Enabled = false;
         //CheckChangeLog.Checked = false;
      }

      private void JQLValue_TextChanged(object sender, EventArgs e)
      {
         //        UseJQL.Checked = true;
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
         JIRAKeyValue.Text = "INFUOP-1061";
         SearchButton_Click(sender, e);
         //ShowItemDetails_Click(sender, e);
      }

      private void Choose661_Click(object sender, EventArgs e)
      {
         JIRAKeyValue.Text = "STOR-661";
         SearchButton_Click(sender, e);
         //ShowItemDetails_Click(sender, e);


      }
      #endregion
      public string DebugOutputValue
      {
         set { System.Diagnostics.Debug.Write(value + Environment.NewLine); }
      }

      public string JSONOutputValue
      {
         get
         {
            return ReturnedJSON.Text;
         }
         set
         {
            JSONOutput(value);
            DebugOutputValue = value;
         }
      }

      public void JSONOutput(string Display)
      {
         ReturnedJSON.Text = Display;
         ReturnedJSON.Refresh();
      }



      private void SearchButton_Click(object sender, EventArgs e)
      {
         string targetURI = BaseURI;
         JSONOutput("Calling JIRA");


         targetURI += "issue/" + JIRAKeyValue.Text;

         ExecutionURI.Text = targetURI;
         ExecutionURI.Refresh();

         SearchURI_Click(sender, e);
      }

      private void SearchURI_Click(object sender, EventArgs e)
      {
         //         if (EpicLink.Text != string.Empty)
         {
            JSONOutput(string.Empty);
            UserLoginCredentials = new UserCredentails
            {
               UserName = UserNameField.Text,
               Password = PasswordField.Text
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
                  EditItem.Checked = true;
               }
               else
                  JSONOutputValue = restResponse.RestCallException.Message;
            }
            catch (Exception ex)
            { DebugOutputValue = ex.Message; }
         }
      }


      private RestResponse PullChangeRecord(string itemURL)
      {
         GeneralFunctions generalFunctions = new GeneralFunctions();
         RestResponse restResponse = new RestResponse();

         string targetURI = String.Format("{0}?expand=changelog", itemURL);

         restResponse = generalFunctions.ExecuteJSONRequest(targetURI, UserLoginCredentials);
         return restResponse;
      }


      private void PostUpdates_Click(object sender, EventArgs e)
      {
         CreatedSuccessfully.Text = "";
         UpdatedSuccessfully.Text = "";

         if (CreateItem.Checked)
         {
            string ErrorMessages = string.Empty;
            if (CreateProject.Text.Contains("}") || CreateProject.Text == string.Empty)
               ErrorMessages += "Project Name is required for issue creation." + Environment.NewLine;
            if (CreateSummary.Text.Contains("}") || CreateSummary.Text == string.Empty)
               ErrorMessages += "Summary is required for issue creation." + Environment.NewLine;

            if (ErrorMessages != string.Empty)
            {
               MessageBox.Show(ErrorMessages, "Missing Data to create", MessageBoxButtons.OK, MessageBoxIcon.Hand);
               return;
            }
         }

         JSONOutput(string.Empty);
         UserLoginCredentials = new UserCredentails
         {
            UserName = UserNameField.Text,
            Password = PasswordField.Text
         };

         string JIRAURL = String.Concat(BaseURI, "issue/");
         if (EditItem.Checked)
            JIRAURL += EditIssueKey.Text;

         string JIRAPostString = GenerateJIRAExecuteString() + "}}";


         if (JIRAPostString == "}}")
            MessageBox.Show("No data was selected to update.");
         else
         {
            GeneralFunctions generalFunctions = new GeneralFunctions();
            RestResponse restResponse = new RestResponse();
            JSONOutputValue = "Calling ExecuteJSONRequest";
            try
            {

               HttpVerb httpVerb;
               if (EditItem.Checked)
                  httpVerb = HttpVerb.PUT;
               else
                  httpVerb = HttpVerb.POST;

               restResponse = generalFunctions.ExecuteJSONRequest(JIRAURL, UserLoginCredentials, false, httpVerb, JIRAPostString);
               if (restResponse.RestCallSuccessful)
               {
                  if (CreateItem.Checked)
                  {
                     EditIssueKey.Text = restResponse.RestCallResponse.Split(',')[1].Split(':')[1].Replace(@"""", "");
                     CreatedSuccessfully.Text = "Created " + EditIssueKey.Text;
                     EditItem.Checked = true;
                  }
                  else
                     UpdatedSuccessfully.Text = "Successfully updated " + EditIssueKey.Text;

                  JSONOutputValue = JIRAURL + Environment.NewLine + JIRAPostString + Environment.NewLine + restResponse.RestCallResponse;
               }
               else
               {
                  string ErrorMessage = string.Empty;

                  if (restResponse.RestCallResponse.Contains("400"))
                     ErrorMessage = Generate400Concerns(JIRAPostString, generalFunctions);

                  if (ErrorMessage != string.Empty)
                     restResponse.RestCallResponse = ErrorMessage;

                  JSONOutputValue = restResponse.RestCallException.Message + Environment.NewLine + restResponse.RestCallResponse +
                     Environment.NewLine + JIRAURL + Environment.NewLine + JIRAPostString;
                  Clipboard.SetText(JSONOutputValue);
               }
            }
            catch (Exception ex)
            { DebugOutputValue = ex.Message; }
         }
      }

      private string Generate400Concerns(string JIRAPostString, GeneralFunctions generalFunctions)
      {
         RestResponse restResponseProject = new RestResponse();
         string CreateErrorString = string.Empty;

         if (CreateItem.Checked)
         {
            restResponseProject = generalFunctions.ExecuteJSONRequest(String.Concat(BaseURI, "project/") + CreateProject.Text, UserLoginCredentials, false, HttpVerb.GET, JIRAPostString);
            if (restResponseProject.RestCallResponse.Contains("404"))
               CreateErrorString += "The project does not exist" + Environment.NewLine;
         }

         if (CreateItem.Checked)
            restResponseProject = generalFunctions.ExecuteJSONRequest(String.Concat(BaseURI, "user/") + CreateReporter.Text, UserLoginCredentials, false, HttpVerb.GET, JIRAPostString);
         else
            restResponseProject = generalFunctions.ExecuteJSONRequest(String.Concat(BaseURI, "user/") + UpdateReporter.Text, UserLoginCredentials, false, HttpVerb.GET, JIRAPostString);

         if (restResponseProject.RestCallResponse.Contains("404"))
         {
            CreateErrorString += "The reporter does not exist using ";
            if (UseNTID.Checked)
               CreateErrorString += "NT ID";
            else
               CreateErrorString += "Email";
            CreateErrorString += Environment.NewLine;
         }

         if (UpdateAssignee.Text != string.Empty)
         {
            if (CreateItem.Checked)
               restResponseProject = generalFunctions.ExecuteJSONRequest(String.Concat(BaseURI, "user/") + CreateAssignee.Text, UserLoginCredentials, false, HttpVerb.GET, JIRAPostString);
            else
               restResponseProject = generalFunctions.ExecuteJSONRequest(String.Concat(BaseURI, "user/") + UpdateAssignee.Text, UserLoginCredentials, false, HttpVerb.GET, JIRAPostString);
            if (restResponseProject.RestCallResponse.Contains("404"))
            {
               CreateErrorString += "The assignee does not exist using ";
               if (UseNTID.Checked)
                  CreateErrorString += "NT ID";
               else
                  CreateErrorString += "Email";
               CreateErrorString += Environment.NewLine;
            }
         }

         return CreateErrorString;
      }

      private string GenerateJIRAExecuteString()
      {
         string ExecuteString = string.Empty;
         string BaseExecuteString = @"{""fields"":{";
         if (CreateItem.Checked)
         {
            ExecuteString += BaseExecuteString;
            ExecuteString += String.Format(@"""project"":{{""key"":""{0}""}}", CreateProject.Text);
            ExecuteString += String.Format(@",""issuetype"":{{""id"":""{0}""}}", IssueTypeSelector.SelectedValue);
            ExecuteString += String.Format(@",""summary"":""{0}""", CreateSummary.Text);
            if (CreateReporter.Text != string.Empty)
            {
               if (UseNTID.Checked)
                  ExecuteString += String.Format(@",""reporter"":{{""name"":""{0}""}}", CreateReporter.Text);
               else
                  ExecuteString += String.Format(@",""reporter"":{{""emailAddress"":""{0}""}}", CreateReporter.Text);
            }
            if (ReporterIsAssignee.Checked)
            {
               if (UseNTID.Checked)
                  ExecuteString += String.Format(@",""assignee"":{{""name"":""{0}""}}", CreateReporter.Text);
               else
                  ExecuteString += String.Format(@",""assignee"":{{""emailAddress"":""{0}""}}", CreateReporter.Text);
            }
            else if (CreateAssignee.Text != string.Empty)
               if (UseNTID.Checked)
                  ExecuteString += String.Format(@",""assignee"":{{""name"":""{0}""}}", CreateAssignee.Text);
               else
                  ExecuteString += String.Format(@",""assignee"":{{""emailAddress"":""{0}""}}", CreateAssignee.Text);

            if (CreateDescription.Text != string.Empty)
               ExecuteString += String.Format(@",""description"":""{0}""", CreateDescription.Text);

            if (CreateEpicLinksCombo.SelectedValue.ToString() != "0")
               ExecuteString += String.Format(@",""customfield_10006"":""{0}""", CreateEpicLinksCombo.SelectedValue.ToString());

            ExecuteString += @",""priority"":[{""set"":{""name"":""" + CreatePriority.SelectedItem + @"""}}]";
         }
         else
         {
            ExecuteString += BaseExecuteString;
            if (UpdateSummary.Text != string.Empty)
               ExecuteString += String.Format(@"""summary"":""{0}""", UpdateSummary.Text);

            if (UpdateDescription.Text != string.Empty)
            {
               if (ExecuteString != BaseExecuteString)
                  ExecuteString += ",";

               ExecuteString += String.Format(@"""description"":""{0}""", UpdateDescription.Text);
            }
            if (UpdateReporter.Text != String.Empty)
            {
               if (ExecuteString != BaseExecuteString)
                  ExecuteString += ",";

               if (UseNTID.Checked)
                  ExecuteString += String.Format(@"""reporter"":{{""name"":""{0}""}}", UpdateReporter.Text);
               else
                  ExecuteString += String.Format(@"""reporter"":{{""emailAddress"":""{0}""}}", UpdateReporter.Text);
            }
            if (Unassign.Checked)
            {
               if (ExecuteString != BaseExecuteString)
                  ExecuteString += ",";

               ExecuteString += String.Format(@"""assignee"":{{""name"":""{0}""}}", "");
            }
            else if (UpdateAssignee.Text != String.Empty)
            {
               if (ExecuteString != BaseExecuteString)
                  ExecuteString += ",";

               if (UseNTID.Checked)
                  ExecuteString += String.Format(@"""assignee"":{{""name"":""{0}""}}", UpdateAssignee.Text);
               else
                  ExecuteString += String.Format(@"""assignee"":{{""emailAddress"":""{0}""}}", UpdateAssignee.Text);
            }

            if (UpdateEpicLinksCombo.SelectedValue.ToString() != "0")
            {
               if (ExecuteString != BaseExecuteString)
                  ExecuteString += ",";

               ExecuteString += String.Format(@"""customfield_10006"":""{0}""", UpdateEpicLinksCombo.SelectedValue.ToString());
            }

            if (UpdatePriority.SelectedValue.ToString() != string.Empty)
               ExecuteString += @",""priority"":[{""set"":{""name"":""" + UpdatePriority.SelectedValue + @"""}}]";
         }

         if (ExecuteString == BaseExecuteString)
            ExecuteString = string.Empty;
         return ExecuteString;
      }

      private void GoMain_Click(object sender, EventArgs e)
      {
         LookupForm x = new LookupForm();
         x.Show();
      }

      private void CreateItem_CheckedChanged(object sender, EventArgs e)
      {
         CreateItemGroupBox.Enabled = true;
         EditItemGroupBox.Enabled = false;
         CreateSummary.Text = "{Summary Required}";
      }

      private void EditItem_CheckedChanged(object sender, EventArgs e)
      {
         CreateItemGroupBox.Enabled = false;
         EditItemGroupBox.Enabled = true;
         if (EditIssueKey.Text == string.Empty)
            EditIssueKey.Text = JIRAKeyValue.Text;
      }

      private void ReporterIsAssignee_CheckedChanged(object sender, EventArgs e)
      {
         if (!ReporterIsAssignee.Checked)
            CreateAssignee.Text = string.Empty;

         CreateAssignee.Enabled = !ReporterIsAssignee.Checked;
      }

      private void Unassign_CheckStateChanged(object sender, EventArgs e)
      {
         UpdateAssignee.Enabled = !Unassign.Checked;
         if (!Unassign.Checked)
            UpdateAssignee.Text = "";
      }

      private void Unassign_CheckedChanged(object sender, EventArgs e)
      {
         UpdateAssignee.Text = "";
      }

      #region GetEpics

      private void GetEpics()
      {
         string targetURI = BaseURI;
         JSONOutput("Calling JIRA");

         targetURI = BaseURI + "search/?jql=filter=23817&maxResults=150";

         SearchEpics(targetURI);
      }

      private void SearchEpics(string targetURI)
      {
         UserLoginCredentials = new UserCredentails
         {
            UserName = UserNameField.Text.ToString(),
            Password = PasswordField.Text.ToString()
         };

         GeneralFunctions generalFunctions = new GeneralFunctions();
         RestResponse restResponse = new RestResponse();
         //JSONOutputValue = "Calling ExecuteJSONRequest";
         try
         {

            restResponse = generalFunctions.ExecuteJSONRequest(targetURI, UserLoginCredentials);
            if (restResponse.RestCallSuccessful)
            {
               //JSONOutputValue = restResponse.RestCallResponse;
               Clipboard.SetText(restResponse.RestCallResponse);
               try
               {
                  TMobile_INFUOPS_Schema.RootObject jTMobile = ProcessTMobile_INFUOPS(restResponse.RestCallResponse);
                  if (jTMobile != null)
                     LoadAndSetEpicList(jTMobile);
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

      private TMobile_INFUOPS_Schema.RootObject ProcessTMobile_INFUOPS(string JSONOutput)
      {

         TMobile_INFUOPS_Schema.RootObject jTMobile;

         DebugOutputValue = "In ProcessTMobile";
         jTMobile = null;

         DebugOutputValue = "Non-Issue Process";
         jTMobile = TMobile_INFUOPS_Interface.ProcessINFUOP_Issues(null, JSONOutput);
         if (jTMobile == null || jTMobile.issues == null)
            DebugOutputValue = "No Records Returned";
         return jTMobile;
      }

      private void LoadAndSetEpicList(TMobile_INFUOPS_Schema.RootObject jTMobile)
      {

         EpicData epicData;
         UpdateEpics.Add(new EpicData { EpicKey = "0", EpicName = "" });
         CreateEpics.Add(new EpicData { EpicKey = "0", EpicName = "" });

         foreach (TMobile_INFUOPS_Schema.Issue value in jTMobile.issues)
         {
            epicData = new EpicData
            {
               EpicKey = value.key,
               EpicName = value.fields.customfield_10005
            };
            UpdateEpics.Add(epicData);
            CreateEpics.Add(epicData);
         }

         UpdateEpicLinksCombo.DataSource = UpdateEpics;
         UpdateEpicLinksCombo.DisplayMember = "EpicName";
         UpdateEpicLinksCombo.ValueMember = "EpicKey";
         CreateEpicLinksCombo.DataSource = CreateEpics;
         CreateEpicLinksCombo.DisplayMember = "EpicName";
         CreateEpicLinksCombo.ValueMember = "EpicKey";
      }

      #endregion

      private void CreateProject_TextChanged(object sender, EventArgs e)
      {
         if (CreateProject.Text != string.Empty && !CreateProject.Text.Contains("}"))
            CreateProject.BackColor = System.Drawing.SystemColors.Window;
         else if (!IgnoreTextChange)
         {
            CreateProject.Text = "{Project Required}";
            CreateProject.BackColor = System.Drawing.Color.Cyan;
         }
         else
         {
            IgnoreTextChange = false;
            CreateSummary.BackColor = System.Drawing.Color.Cyan;
         }
      }

      private void CreateSummary_TextChanged(object sender, EventArgs e)
      {
         if (CreateSummary.Text != string.Empty && !CreateSummary.Text.Contains("}"))
            CreateSummary.BackColor = System.Drawing.SystemColors.Window;
         else if (!IgnoreTextChange)
         {
            CreateSummary.Text = "{Summary Required}";
            CreateSummary.BackColor = System.Drawing.Color.Cyan;
         }
         else
         {
            IgnoreTextChange = false;
            CreateSummary.BackColor = System.Drawing.Color.Cyan;
         }
      }

      private void CreateProject_KeyDown(object sender, KeyEventArgs e)
      {
         if (e.KeyCode.ToString() == "Delete")
            IgnoreTextChange = true;



      }

      private void CreateSummary_Leave(object sender, EventArgs e)
      {
         if (CreateSummary.Text == string.Empty)
            CreateSummary.Text = "{Summary Required}";
      }

      private void CreateProject_Leave(object sender, EventArgs e)
      {
         if (CreateProject.Text == string.Empty)
            CreateProject.Text = "{Project Required}";
      }
   }
}





