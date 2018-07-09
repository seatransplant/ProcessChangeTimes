using System;
using System.IO;
using System.Net;


namespace BlockedItems
{
   // ReSharper disable InconsistentNaming
   #region Enums
   public enum HttpVerb
   {
      GET,
      POST,
      PUT,
      DELETE
   }

   public enum AuthenticationType
   {
      None,
      Basic,
      NTLM
   }
   // ReSharper enable InconsistentNaming
   public enum AuthenticationTechnique
   {
      None,
      RollYourOwn,
      NetworkCredential
   }

   #endregion
   #region Classes
   public class RestClient
   {
      public string EndPoint { get; set; }
      public HttpVerb HttpMethod { get; set; }
      public AuthenticationType AuthType { get; set; }
      public AuthenticationTechnique AuthTech { get; set; }
      public string UserName { get; set; }
      public string UserPassword { get; set; }
      public string PostJSON { get; set; }

      public RestClient()
      {
         EndPoint = String.Empty;
         HttpMethod = HttpVerb.GET;
         AuthType = AuthenticationType.None;
         AuthTech = AuthenticationTechnique.None;
         UserName = string.Empty;
         UserPassword = string.Empty;
         PostJSON = string.Empty;
      }

      public RestResponse MakeRequest()
      {

         RestResponse restResponse = new RestResponse();

         WebRequest request = WebRequest.Create(EndPoint);
         request.Method = HttpMethod.ToString();

         if (AuthType == AuthenticationType.Basic)
         {
            string authUser = System.Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes(UserName + ":" + UserPassword));
            string authHeader = AuthType.ToString() + " " + authUser;
            request.Headers.Add("Authorization", authHeader);
         }


         if (request.Method != "GET" && PostJSON == string.Empty)
         {
            restResponse.RestCallSuccessful = false;
            restResponse.RestCallException = new InvalidOperationException(String.Format("{0} Request with No Data", request.Method));
            restResponse.RestCallResponse = string.Format("{\"errorMessages\":[\"" + "{0} Requests need items to change" + "\"],\"errors\":{}}", request.Method);
         }
         else if (request.Method !="GET")
         {
            request.ContentType = "application/json";
            using (StreamWriter swJSONPayload = new StreamWriter(request.GetRequestStream()))
            {
               swJSONPayload.Write(PostJSON);
               swJSONPayload.Close();
            }
         }
         // TODO why won't it do an edit


         if (PostJSON != string.Empty)
            System.Windows.Forms.Clipboard.SetText(PostJSON);

         HttpWebResponse response = null;

         if (restResponse.RestCallResponse == string.Empty)
         {
            try
            {
               response = (HttpWebResponse)request.GetResponse();

               using (Stream responseStream = response.GetResponseStream())
               {
                  if (responseStream != null)
                     using (
                     StreamReader reader = new StreamReader(responseStream))
                        restResponse.RestCallResponse = reader.ReadToEnd();
               }

               if (restResponse.RestCallResponse == string.Empty)
                  restResponse.RestCallResponse = Environment.NewLine + "Call was successful.";
               restResponse.RestCallSuccessful = true;
            }
            catch (Exception ex)
            {
               restResponse.RestCallException = ex;
               restResponse.RestCallResponse = "{\"errorMessages\":[\"" + ex.Message.ToString() + "\"],\"errors\":{}}";
            }
         }
         return restResponse;
      }

   }
   public class RestResponse
   {
      public bool RestCallSuccessful = false;
      public string RestCallResponse = string.Empty;
      public Exception RestCallException = null;
   }
   #endregion

   static class RestInterface
   {
      public static RestResponse MakeJSONRequest(string RequestURI, UserCredentails creds, HttpVerb httpVerb = HttpVerb.GET, string PostJSONValue = null)
      {
         string sResponse = string.Empty;
         RestResponse restResponse = new RestResponse();
         try
         {
            RestClient rClient = new RestClient
            {
               EndPoint = RequestURI,
               AuthType = creds.AuthenticationTypeChosen,
               AuthTech = creds.AuthenticationTechniqueChosen,
               UserName = creds.UserName,
               UserPassword = creds.Password
            };

            rClient.HttpMethod = httpVerb;
            if (PostJSONValue != null)
               rClient.PostJSON = PostJSONValue;

            System.Diagnostics.Debug.Write("Calling MakeRequest" + Environment.NewLine);
            restResponse = rClient.MakeRequest();

            System.Diagnostics.Debug.Write("Call Completed Successfully" + Environment.NewLine);
         }
         catch (Exception ex)
         {
            restResponse.RestCallException = ex;
            restResponse.RestCallResponse = ex.Message;

            System.Diagnostics.Debug.Write("Call Failed: " + restResponse.RestCallResponse + Environment.NewLine);
            throw;
         }

         return restResponse;
      }
   }

}
