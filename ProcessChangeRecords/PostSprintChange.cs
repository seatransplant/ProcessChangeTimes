using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;

namespace BlockedItems
{
   public partial class PostSprintChanges : Form
   {

      private enum RequestServer
      {
         Cloud,
         TMobile
      }
      private UserCredentails UserLoginCredentials;
      //private SeaTransplant_JIRA_Schema.RootObject jSeaTransplant;


      private string BaseAgileURI;


      private RequestServer rs = RequestServer.TMobile;
      public PostSprintChanges()
      {
         InitializeComponent();
#if DEBUG
         UseTMobile.Checked = true;
#endif
      }


      private void GatherSprintValues(string itemTypeJson)
      {
         if (rs == RequestServer.TMobile)
            try
            {
               TMobile_INFUOPS_Interface.DeserializeItemType issueDeserializeItemType = new TMobile_INFUOPS_Interface.DeserializeItemType();
               List<TMobile_INFUOPS_Schema.SprintValue> issueTypes = issueDeserializeItemType.ProcessINFUOP_SprintValues(itemTypeJson);
               if (issueTypes != null)
               {
                  // Specify each item type that could be created
                  foreach (TMobile_INFUOPS_Schema.SprintValue value in issueTypes)
                  {
                     ListViewItem newItem = new ListViewItem
                     {
                        Text = value.id.ToString()
                     };

                     string[] subItems = new string[] { value.name, value.startDate.ToString() };
                     newItem.SubItems.AddRange(subItems);
                     SprintListing.Items.Add(newItem);
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
;

      }

      #region UIEvents
      private void UseSeaTransplant_Checked(object sender, EventArgs e)
      {
         if (UseSeaTransplant.Checked)
         {
            BaseAgileURI = "https://seatransplant.atlassian.net/rest/agile/latest/";
            UserNameField.Text = "kodacoda@live.com";
            PasswordField.Text = "@ndyR0se!";
            // Leave Until Implemented rs = RequestServer.Cloud;
            // TODO: Wire to cloud
            SearchButton_Click(sender, e);
         }
      }

      private void UseTMobileQA_Checked(object sender, EventArgs e)
      {
         if (UseTMobileQA.Checked)
         {
            BaseAgileURI = "https://jiraqat.t-mobile.com/rest/agile/latest/";
            UserNameField.Text = ConfigurationManager.AppSettings["QAUserName"];
#if DEBUG
            PasswordField.Text = ConfigurationManager.AppSettings["QAPassword"]; ;
#else
            txtPassword.Text = String.Empty;
#endif
            rs = RequestServer.TMobile;
            SearchButton_Click(sender, e);
         }
      }


      private void UseTMobile_Checked(object sender, EventArgs e)
      {
         if (UseTMobile.Checked)
         {
            BaseAgileURI = "https://jira.t-mobile.com/rest/agile/latest/";
            UserNameField.Text = ConfigurationManager.AppSettings["ProdUser"].ToString();
#if DEBUG
            PasswordField.Text = ConfigurationManager.AppSettings["ProdPassword"];
#else
            txtPassword.Text = String.Empty;
#endif

            rs = RequestServer.TMobile;
            SearchButton_Click(sender, e);
         }
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
         string targetURI = BaseAgileURI;
         JSONOutput("Calling JIRA");
         targetURI += "board/656/sprint";

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
                  GatherSprintValues(restResponse.RestCallResponse);
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
         UpdatedSuccessfully.Text = "";


         JSONOutput(string.Empty);
         UserLoginCredentials = new UserCredentails
         {
            UserName = UserNameField.Text,
            Password = PasswordField.Text
         };

         string JIRAURL = String.Concat(BaseAgileURI, "sprint/");
         JIRAURL += EditSprintID.Text;

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
               httpVerb = HttpVerb.PUT;

               restResponse = generalFunctions.ExecuteJSONRequest(JIRAURL, UserLoginCredentials, false, httpVerb, JIRAPostString);
               if (restResponse.RestCallSuccessful)
                  UpdatedSuccessfully.Text = "Successfully updated " + EditSprintID.Text;
               else
                  JSONOutputValue = string.Format("FAILED: {0}", restResponse.RestCallResponse);
            }
           
            catch (Exception ex)
            { DebugOutputValue = ex.Message; }
         }
      }


      private string GenerateJIRAExecuteString()
      {
         string ExecuteString = @"{""fields"":{";
         ExecuteString += String.Format(@",""name"":""{0}""", UpdateSprintName.Text);

         return ExecuteString;
      }






      private void SprintListing_SelectedIndexChanged(object sender, EventArgs e)
      {
         DebugOutputValue = string.Format("Clicked ListOfResults {0}", SprintListing.SelectedIndices.Count);
         if (SprintListing.SelectedIndices.Count != 0)
         {
            SelectedSprintName.Text = String.Format("Show Details for {0}", SprintListing.SelectedItems[0].SubItems[1].Text);
            EditSprintID.Text = SprintListing.SelectedItems[0].Text;
            UpdateSprintName.Enabled = true;
            EditItemGroupBox.Enabled = true;
         }

         else
         {
            EditSprintID.Text = String.Empty;
            SelectedSprintName.Text = String.Empty;
            UpdateSprintName.Enabled = false;
            EditItemGroupBox.Enabled = false;
         }
      }
   }
}







