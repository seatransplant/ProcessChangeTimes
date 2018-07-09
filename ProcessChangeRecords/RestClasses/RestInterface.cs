using System;

namespace RestWinYouTube
{
    static class RestInterface
    {
        public static string MakeJSONRequest(string RequestURI, AuthenticationType aType, AuthenticationTechnique aTech, string _UserName, string _Password)
        {
            string sResponse = string.Empty;
            try
            {
            RestClient rClient = new RestClient
            {
               EndPoint = RequestURI,
               AuthType = aType,
               AuthTech = aTech,
               UserName = _UserName,
               UserPassword = _Password
            };

            System.Diagnostics.Debug.Write("Calling Object");
                sResponse = rClient.MakeRequest();

                System.Diagnostics.Debug.Write("Call Completed Successfully");
            }
            catch (Exception ex)
            {
                sResponse = ex.Message;
                System.Diagnostics.Debug.Write("Call Failed: " + sResponse);
                throw ex;
            }

            return sResponse;
        }
    }
}
