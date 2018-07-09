using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BlockedItems
{
   public class UserCredentails
   {
      public string UserName = String.Empty;
      public string Password = String.Empty;

      public AuthenticationTechnique AuthenticationTechniqueChosen = AuthenticationTechnique.None;
      public AuthenticationType AuthenticationTypeChosen = AuthenticationType.Basic;
   }

#pragma warning disable IDE1006 // Naming Styles
   public class EpicInitative
   {

      public class Rootobject
      {
         public string expand { get; set; }
         public string id { get; set; }
         public string self { get; set; }
         public string key { get; set; }
         public Fields fields { get; set; }
      }

      public class Fields
      {
         public string summary { get; set; }
         public string customfield_11200 { get; set; }
      }

   }
#pragma warning restore IDE1006 // Naming Styles

   public static class ValidationFunctions
   {
      public static string IsNullString(object value)
      {
         try
         {
            if (value == null)
               return string.Empty;
            else
               return value.ToString();
         }
         catch
         { return string.Empty; }
      }

      public static int IsNullInteger(object value)
      {
         try
         {
            if (value == null)
               return 0;
            else
               return (int)value;        }
         catch
         { return 0; }
      }

      public static string SprintName(string value)
      {
         int indexValue = value.IndexOf("name=") + 5;
         string startName = value.Substring(indexValue, value.IndexOf(",", indexValue) - indexValue);
         return startName;
      }


   }
   public class GeneralFunctions
   {
      public string DebugOutputValue
      {
         set { System.Diagnostics.Debug.Write(value + Environment.NewLine); }
      }

     // Regardless of the target, all will execute a standard JSON Request
      public RestResponse ExecuteJSONRequest(string TargetURI, UserCredentails credentails, bool WriteToClipboard = true, HttpVerb httpVerb = HttpVerb.GET, string JSONValue = null)
      {
         //JSONReponse reponse = new JSONReponse();
         RestResponse restResponse = new RestResponse();
         DebugOutputValue = "Calling Rest Interface";
         try
         {
            restResponse = RestInterface.MakeJSONRequest(TargetURI, credentails, httpVerb, JSONValue);
            //TODO: Stop Clipboard writing if large push
            if (restResponse.RestCallException == null)
            {
               string sResponse = restResponse.RestCallResponse;
               if (WriteToClipboard)
               {
                  DebugOutputValue = "Attempting to write output to clipboard";
                  Clipboard.SetText(sResponse);
                  DebugOutputValue = "Completed clipboard write";
               }
            }
            else
            {
               DebugOutputValue = "Error returned from call. Clearing clipboard";
               Clipboard.Clear();
               DebugOutputValue = "Cleared Clipboard. ";
            }
            return restResponse;
         }
         catch (Exception ex)
         {
            DebugOutputValue = "Call Failed: " + ex.ToString() + Environment.NewLine;
            restResponse.RestCallException = ex;
            restResponse.RestCallSuccessful = false;
            restResponse.RestCallResponse = ex.Message;
            return restResponse;
         }


      }

   }
}
public class NewProgressBar : ProgressBar
{

   private LinearGradientMode ControlGradient = LinearGradientMode.Vertical;
   private int RectInset = 2;

   [Category("Appearance")]
   [Browsable(true)]
   public LinearGradientMode Gradient
   {
      get
      {
         return ControlGradient;
      }

      set
      { ControlGradient = value; }
   }

   [Category("Appearance")]
   [Browsable(true)]
   public int  Inset
   {
      get
      {
         return RectInset;
      }

      set
      {
         if (value < 2)
            RectInset = 2;
         else if (value > this.Height - 2)
            RectInset = this.Height - 2;
         else
            RectInset = value;
      }
   }


   public NewProgressBar()
   {
      this.SetStyle(ControlStyles.UserPaint, true);
   }

   protected override void OnPaintBackground(PaintEventArgs pevent)
   {
      // None... Helps control the flicker.
   }

   protected override void OnPaint(PaintEventArgs e)
   {
      //const int inset = 2; // A single inset value to control teh sizing of the inner rect.

      using (Image offscreenImage = new Bitmap(this.Width, this.Height))
      {
         using (Graphics offscreen = Graphics.FromImage(offscreenImage))
         {
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);

            if (ProgressBarRenderer.IsSupported)
               ProgressBarRenderer.DrawHorizontalBar(offscreen, rect);

            rect.Inflate(new Size(-RectInset, -RectInset)); // Deflate inner rect.
            rect.Width = (int)(rect.Width * ((double)this.Value / this.Maximum));
            if (rect.Width == 0) rect.Width = 1; // Can't draw rec with width of 0.

            LinearGradientBrush brush = new LinearGradientBrush(rect, this.BackColor, this.ForeColor, ControlGradient);
            offscreen.FillRectangle(brush, RectInset, RectInset, rect.Width, rect.Height);

            e.Graphics.DrawImage(offscreenImage, 0, 0);
            offscreenImage.Dispose();
         }
      }
   }
}