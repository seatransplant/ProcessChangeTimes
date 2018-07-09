using Newtonsoft.Json;
using RestWinYouTube;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestWinYouTube
{
#pragma warning disable IDE1006 // Naming Styles
   public class SeaTransplant_JIRA_Schema
   {



      public class RootObject
      {
         public string expand { get; set; }
         public int startAt { get; set; }
         public int maxResults { get; set; }
         public int total { get; set; }
         public Issue[] issues { get; set; }
      }

      public class Issue
      {
         public string expand { get; set; }
         public string id { get; set; }
         public string self { get; set; }
         public string key { get; set; }
         public Fields fields { get; set; }
      }

      public class Fields
      {
         public Issuetype issuetype { get; set; }
         public int? timespent { get; set; }
         public object customfield_10270 { get; set; }
         public string customfield_10271 { get; set; }
         public object customfield_10272 { get; set; }
         public Project project { get; set; }
         public object customfield_10273 { get; set; }
         public string customfield_10110 { get; set; }
         public Fixversion[] fixVersions { get; set; }
         public int? aggregatetimespent { get; set; }
         public object customfield_10111 { get; set; }
         public Resolution resolution { get; set; }
         public object customfield_10112 { get; set; }
         public string[] customfield_10113 { get; set; }
         public string customfield_10114 { get; set; }
         public string customfield_10104 { get; set; }
         public string customfield_10105 { get; set; }
         public string customfield_10106 { get; set; }
         public string customfield_10107 { get; set; }
         public string customfield_10108 { get; set; }
         public string customfield_10109 { get; set; }
         public DateTime? resolutiondate { get; set; }
         public int workratio { get; set; }
         public object lastViewed { get; set; }
         public Watches watches { get; set; }
         public DateTime created { get; set; }
         public object customfield_10261 { get; set; }
         public Priority priority { get; set; }
         public object customfield_10100 { get; set; }
         public string customfield_10101 { get; set; }
         public string customfield_10102 { get; set; }
         public object customfield_10267 { get; set; }
         public object[] labels { get; set; }
         public string customfield_10103 { get; set; }
         public object customfield_10258 { get; set; }
         public int? timeestimate { get; set; }
         public int? aggregatetimeoriginalestimate { get; set; }
         public object[] versions { get; set; }
         public Issuelink[] issuelinks { get; set; }
         public Assignee assignee { get; set; }
         public DateTime updated { get; set; }
         public Status status { get; set; }
         public Component[] components { get; set; }
         public int? timeoriginalestimate { get; set; }
         public string description { get; set; }
         public object customfield_10256 { get; set; }
         public string customfield_10257 { get; set; }
         public string customfield_10006 { get; set; }
         public object customfield_10007 { get; set; }
         public object security { get; set; }
         public int? aggregatetimeestimate { get; set; }
         public string summary { get; set; }
         public Creator creator { get; set; }
         public Subtask[] subtasks { get; set; }
         public Reporter reporter { get; set; }
         public Aggregateprogress aggregateprogress { get; set; }
         public string customfield_10000 { get; set; }
         public object customfield_10001 { get; set; }
         public object customfield_10002 { get; set; }
         public object customfield_10200 { get; set; }
         public float? customfield_10115 { get; set; }
         public Customfield_10237 customfield_10237 { get; set; }
         public string environment { get; set; }
         public string duedate { get; set; }
         public Progress progress { get; set; }
         public Votes votes { get; set; }
      }

      public class Issuetype
      {
         public string self { get; set; }
         public string id { get; set; }
         public string description { get; set; }
         public string iconUrl { get; set; }
         public string name { get; set; }
         public bool subtask { get; set; }
         public int avatarId { get; set; }
      }

      public class Project
      {
         public string self { get; set; }
         public string id { get; set; }
         public string key { get; set; }
         public string name { get; set; }
         public string projectTypeKey { get; set; }
         public Avatarurls avatarUrls { get; set; }
      }

      public class Avatarurls
      {
         public string _48x48 { get; set; }
         public string _24x24 { get; set; }
         public string _16x16 { get; set; }
         public string _32x32 { get; set; }
      }

      public class Resolution
      {
         public string self { get; set; }
         public string id { get; set; }
         public string description { get; set; }
         public string name { get; set; }
      }

      public class Watches
      {
         public string self { get; set; }
         public int watchCount { get; set; }
         public bool isWatching { get; set; }
      }

      public class Priority
      {
         public string self { get; set; }
         public string iconUrl { get; set; }
         public string name { get; set; }
         public string id { get; set; }
      }

      public class Assignee
      {
         public string self { get; set; }
         public string name { get; set; }
         public string key { get; set; }

         public string accountId { get; set; }
         public string emailAddress { get; set; }
         public Avatarurls1 avatarUrls { get; set; }
         public string displayName { get; set; }
         public bool active { get; set; }
         public string timeZone { get; set; }
      }

      public class Avatarurls1
      {
         public string _48x48 { get; set; }
         public string _24x24 { get; set; }
         public string _16x16 { get; set; }
         public string _32x32 { get; set; }
      }

      public class Status
      {
         public string self { get; set; }
         public string description { get; set; }
         public string iconUrl { get; set; }
         public string name { get; set; }
         public string id { get; set; }
         public Statuscategory statusCategory { get; set; }
      }

      public class Statuscategory
      {
         public string self { get; set; }
         public int id { get; set; }
         public string key { get; set; }
         public string colorName { get; set; }
         public string name { get; set; }
      }

      public class Creator
      {
         public string self { get; set; }
         public string name { get; set; }
         public string key { get; set; }
         public string accountId { get; set; }
         public string emailAddress { get; set; }
         public Avatarurls2 avatarUrls { get; set; }
         public string displayName { get; set; }
         public bool active { get; set; }
         public string timeZone { get; set; }
      }

      public class Avatarurls2
      {
         public string _48x48 { get; set; }
         public string _24x24 { get; set; }
         public string _16x16 { get; set; }
         public string _32x32 { get; set; }
      }

      public class Reporter
      {
         public string self { get; set; }
         public string name { get; set; }
         public string key { get; set; }
         public string accountId { get; set; }
         public string emailAddress { get; set; }
         public Avatarurls3 avatarUrls { get; set; }
         public string displayName { get; set; }
         public bool active { get; set; }
         public string timeZone { get; set; }
      }

      public class Avatarurls3
      {
         public string _48x48 { get; set; }
         public string _24x24 { get; set; }
         public string _16x16 { get; set; }
         public string _32x32 { get; set; }
      }

      public class Aggregateprogress
      {
         public int progress { get; set; }
         public int total { get; set; }
         public int percent { get; set; }
      }

      public class Customfield_10237
      {
         public string self { get; set; }
         public string value { get; set; }
         public string id { get; set; }
      }

      public class Progress
      {
         public int progress { get; set; }
         public int total { get; set; }
         public int percent { get; set; }
      }

      public class Votes
      {
         public string self { get; set; }
         public int votes { get; set; }
         public bool hasVoted { get; set; }
      }

      public class Fixversion
      {
         public string self { get; set; }
         public string id { get; set; }
         public string description { get; set; }
         public string name { get; set; }
         public bool archived { get; set; }
         public bool released { get; set; }
         public string releaseDate { get; set; }
      }

      public class Issuelink
      {
         public string id { get; set; }
         public string self { get; set; }
         public Type type { get; set; }
         public Outwardissue outwardIssue { get; set; }
         public Inwardissue inwardIssue { get; set; }
      }

      public class Type
      {
         public string id { get; set; }
         public string name { get; set; }
         public string inward { get; set; }
         public string outward { get; set; }
         public string self { get; set; }
      }

      public class Outwardissue
      {
         public string id { get; set; }
         public string key { get; set; }
         public string self { get; set; }
         public Fields1 fields { get; set; }
      }

      public class Fields1
      {
         public string summary { get; set; }
         public Status1 status { get; set; }
         public Priority1 priority { get; set; }
         public Issuetype1 issuetype { get; set; }
      }

      public class Status1
      {
         public string self { get; set; }
         public string description { get; set; }
         public string iconUrl { get; set; }
         public string name { get; set; }
         public string id { get; set; }
         public Statuscategory1 statusCategory { get; set; }
      }

      public class Statuscategory1
      {
         public string self { get; set; }
         public int id { get; set; }
         public string key { get; set; }
         public string colorName { get; set; }
         public string name { get; set; }
      }

      public class Priority1
      {
         public string self { get; set; }
         public string iconUrl { get; set; }
         public string name { get; set; }
         public string id { get; set; }
      }

      public class Issuetype1
      {
         public string self { get; set; }
         public string id { get; set; }
         public string description { get; set; }
         public string iconUrl { get; set; }
         public string name { get; set; }
         public bool subtask { get; set; }
         public int avatarId { get; set; }
      }

      public class Inwardissue
      {
         public string id { get; set; }
         public string key { get; set; }
         public string self { get; set; }
         public Fields2 fields { get; set; }
      }

      public class Fields2
      {
         public string summary { get; set; }
         public Status2 status { get; set; }
         public Priority2 priority { get; set; }
         public Issuetype2 issuetype { get; set; }
      }

      public class Status2
      {
         public string self { get; set; }
         public string description { get; set; }
         public string iconUrl { get; set; }
         public string name { get; set; }
         public string id { get; set; }
         public Statuscategory2 statusCategory { get; set; }
      }

      public class Statuscategory2
      {
         public string self { get; set; }
         public int id { get; set; }
         public string key { get; set; }
         public string colorName { get; set; }
         public string name { get; set; }
      }

      public class Priority2
      {
         public string self { get; set; }
         public string iconUrl { get; set; }
         public string name { get; set; }
         public string id { get; set; }
      }

      public class Issuetype2
      {
         public string self { get; set; }
         public string id { get; set; }
         public string description { get; set; }
         public string iconUrl { get; set; }
         public string name { get; set; }
         public bool subtask { get; set; }
         public int avatarId { get; set; }
      }

      public class Component
      {
         public string self { get; set; }
         public string id { get; set; }
         public string name { get; set; }
      }

      public class Subtask
      {
         public string id { get; set; }
         public string key { get; set; }
         public string self { get; set; }
         public Fields3 fields { get; set; }
      }

      public class Fields3
      {
         public string summary { get; set; }
         public Status3 status { get; set; }
         public Priority3 priority { get; set; }
         public Issuetype3 issuetype { get; set; }
      }

      public class Status3
      {
         public string self { get; set; }
         public string description { get; set; }
         public string iconUrl { get; set; }
         public string name { get; set; }
         public string id { get; set; }
         public Statuscategory3 statusCategory { get; set; }
      }

      public class Statuscategory3
      {
         public string self { get; set; }
         public int id { get; set; }
         public string key { get; set; }
         public string colorName { get; set; }
         public string name { get; set; }
      }

      public class Priority3
      {
         public string self { get; set; }
         public string iconUrl { get; set; }
         public string name { get; set; }
         public string id { get; set; }
      }

      public class Issuetype3
      {
         public string self { get; set; }
         public string id { get; set; }
         public string description { get; set; }
         public string iconUrl { get; set; }
         public string name { get; set; }
         public bool subtask { get; set; }
         public int avatarId { get; set; }
      }

   }
#pragma warning restore IDE1006 // Naming Styles



}

public static class SeaTransplantInterface
{
   #region DeSerialize_JIRA_SeaTransplant

   public static SeaTransplant_JIRA_Schema.RootObject ProcessSeaTransplant(Authenticating baseForm, string ExecutionURI, string JSONOutput)
   {
      SeaTransplant_JIRA_Schema.RootObject jSeaTransplant;


      jSeaTransplant = DeserializeJSONSeaTransplant(baseForm, JSONOutput);
      baseForm.DebugOutputValue = "Deserialize Completed";
      return jSeaTransplant;
   }

   private static SeaTransplant_JIRA_Schema.RootObject DeserializeJSONSeaTransplant(Authenticating baseForm, string sJSON)
   {

      try
      {
         baseForm.DebugOutputValue = "Deserializing JSON";
         SeaTransplant_JIRA_Schema.RootObject jPerson = JsonConvert.DeserializeObject<SeaTransplant_JIRA_Schema.RootObject>(sJSON);
         baseForm.DebugOutputValue = String.Format("Completed. Total Issues: {0}, Max Returned {1}", jPerson.total, jPerson.maxResults);
         return jPerson;
      }

      catch (Exception ex)
      {
         baseForm.DebugOutputValue = Environment.NewLine + ">>> ErrorDesearlizing:" + ex.Message.ToString();
         return null;
      }

   }

   public static SeaTransplant_JIRA_Schema.Issue DeserializeJSONSeaTransplantSingle(Authenticating baseForm, string sJSON)
   {
      try
      {
         baseForm.DebugOutputValue = "Deserializing JSON";
         SeaTransplant_JIRA_Schema.Issue jPerson = JsonConvert.DeserializeObject<SeaTransplant_JIRA_Schema.Issue>(sJSON);
         baseForm.DebugOutputValue = "Completed: " + jPerson.key.ToString();
         return jPerson;
      }

      catch (Exception ex)
      {
         baseForm.DebugOutputValue = Environment.NewLine + ">>> ErrorDesearlizing:" + ex.Message.ToString();
         return null;
      }


   }

   #endregion

}

