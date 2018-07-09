using System;
using System.IO;
using System.Net;


namespace RestWinYouTube
{
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

   public enum AuthenticationTechnique
   {
      None,
      RollYourOwn,
      NetworkCredential
   }

   #endregion


   class RestClient
   {
      public string EndPoint { get; set; }
      public HttpVerb HttpMethod { get; set; }
      public AuthenticationType AuthType { get; set; }
      public AuthenticationTechnique AuthTech { get; set; }
      public string UserName { get; set; }
      public string UserPassword { get; set; }


      public RestClient()
      {
         EndPoint = String.Empty;
         HttpMethod = HttpVerb.GET;
         AuthType = AuthenticationType.None;
         AuthTech = AuthenticationTechnique.None;
         UserName = string.Empty;
         UserPassword = string.Empty;
      }

      public string MakeRequest()
      {
         string strResponseValue = string.Empty;

         WebRequest request = WebRequest.Create(EndPoint);
         request.Method = HttpMethod.ToString();

         if (AuthType == AuthenticationType.Basic)
         {
            string authUser = System.Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes(UserName + ":" + UserPassword));
            string authHeader = AuthType.ToString() + " " + authUser;
            request.Headers.Add("Authorization", authHeader);
         }
         HttpWebResponse response = null;

         try
         {
            response = (HttpWebResponse)request.GetResponse();

            using (Stream responseStream = response.GetResponseStream())
            {
               if (responseStream != null)
               {
                  using (StreamReader reader = new StreamReader(responseStream))
                  {
                     strResponseValue = reader.ReadToEnd();
                  }
               }
            }
         }
         catch (Exception ex)
         {
            strResponseValue = "{\"errorMessages\":[\"" + ex.Message.ToString() + "\"],\"errors\":{}}";
         }
         finally
         { if (response != null) response.Dispose(); }

         return strResponseValue;
      }

   }
}
