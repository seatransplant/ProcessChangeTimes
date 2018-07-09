using System;
using System.Collections.Generic;
using static BlockedItems.ValidationFunctions;

namespace BlockedItems
{
   public class ProcessHistories
   {
      #region Change Records
      public class ChangeRecord
      {
         public string Who;
         public DateTime When;
         public string JIRAChangeField;
         public string OldValue;
         public string NewValue;
         public string Reason;
         public DateTime ExpectedUnblockDate = DateTime.MinValue;
         public bool IsStatusBlocked = false;
         public bool IsStatusChangeRecord = false;
      }

      public class ChangedCollection : ChangeRecord
      {
         private List<ChangeRecord> records = new List<ChangeRecord>();
         private int reasonChanged = 0;
         private int unblockedDateChanged = 0;
         private int blockedTimes = 0;

         public ChangeRecord GetChangeRecord(int value)
         {
            return records[value];
         }

         public ChangeRecord GetLastChangeRecord
         {
            get
            {
               if (records.Count != 0)
                  return records[records.Count - 1];
               else
                  return null;
            }
         }

         public ChangeRecord GetLastBlockedRecord
         {
            get
            {

               ChangeRecord response = null;
               if (records.Count != 0)
               {
                  for (int value = records.Count - 1; value != -1; value--)
                  {
                     System.Diagnostics.Debug.WriteLine(String.Format("{0} record {1}", value, records[value].IsStatusBlocked));
                     if (records[value].IsStatusBlocked)
                     {
                        response = records[value];
                        break;
                     }
                  }
               }
               return response;
            }
         }

         public ChangeRecord AddChangeRecord
         {
            set
            {

               ChangeRecord lastBlocked = GetLastBlockedRecord;

               records.Add(value);


               if (records.Count != 0 & value.IsStatusBlocked)
               {
                  /*
                   * If there isn't a prior blocked record, then this is the first time it's blocked
                   * therefore there aren't any other records which need to be checked
                   * 
                   */
                  if (lastBlocked != null)
                  {
                     string lastReason = lastBlocked.Reason;
                     DateTime lastDate = lastBlocked.ExpectedUnblockDate;
                     bool lastIsStatusBlocked = GetLastChangeRecord.IsStatusBlocked;

                     if (lastDate != value.ExpectedUnblockDate)
                        unblockedDateChanged++;

                     if (lastReason != value.Reason)
                        reasonChanged++;

                     if (lastIsStatusBlocked != value.IsStatusBlocked)
                        blockedTimes++;
                  }
                  else
                     blockedTimes++;
               }
            }
         }

         public int NumberOfTimesReasonChanged
         {
            get { return reasonChanged; }
         }

         public int NumberOfTimesUnblockedDateChanged
         {
            get
            {
               return unblockedDateChanged;
            }
         }

         public int NumberOfTimesBlocked
         {
            get
            { return blockedTimes; }
         }

         public int NumberOfBlockingRecords
         {
            get
            {
               if (records != null)
                  return records.Count;
               else
                  return 0;
            }
         }

         public List<ChangeRecord> ReturnAllBlockerRecords
         {
            get
            {
               List<ChangeRecord> blocker = new List<ChangeRecord>();

               foreach (ChangeRecord value in records)
                  if (value.IsStatusBlocked)
                     blocker.Add(value);

               return blocker;
            }
         }

         public List<ChangeRecord> ReturnAllStatusChangeRecords
         {
            get
            {
               List<ChangeRecord> statusRecords = new List<ChangeRecord>();

               foreach (ChangeRecord value in records)
                  if (value.IsStatusChangeRecord)
                     statusRecords.Add(value);

               return statusRecords;
            }
         }
         public List<ChangeRecord> ReturnAllChangeRecords
         {
            get
            {
               return records;
            }
         }

      }
      #endregion

#pragma warning disable IDE1006 // Naming Styles
      public class ExportIssueHeader
      {
         public string self { get; set; }
         public string key { get; set; }
         public string summary { get; set; }
         public string assigneeName { get; set; }
         //public bool showBlockedOnly { get; set; }
         public string currentStatus { get; set; }
         public int numberOfSprints = 0;
         public int blockedStatusChanges = 0;
         public int blockedUnblockDateChanges = 0;
      }
#pragma warning restore IDE1006 // Naming Styles

      public class ExportJSON
      {
         public ExportIssueHeader ExportIssue = new ExportIssueHeader();
         public List<ChangeRecord> StatusChangeRecords;
         public List<ChangeRecord> BlockRecords;
         public List<ChangeRecord> AllChangeRecords;
      }

      public ChangedCollection ShowChangeLogs(TMobile_INFUOPS_Schema.Issue singleIssue, DetailView caller = null)
      {
         string[] subItems;
         ChangedCollection blockers = new ChangedCollection();

         if (singleIssue.changelog != null)
         {
            foreach (TMobile_INFUOPS_Schema.History historyRecord in singleIssue.changelog.histories)
            {
               ProcessHistories ph = new ProcessHistories();

               foreach (ChangeRecord currentBlocked in ProcessHistoryRecord(blockers, historyRecord, caller)) //, ref currentBlocked);
               {
                  if (caller != null && currentBlocked.IsStatusBlocked)
                  {
                     System.Windows.Forms.ListViewItem newItem = new System.Windows.Forms.ListViewItem
                     {
                        Text = currentBlocked.Reason
                     };
                     subItems = new string[] { currentBlocked.ExpectedUnblockDate.ToShortDateString(), currentBlocked.Who, currentBlocked.When.ToString() };
                     if (currentBlocked.ExpectedUnblockDate == DateTime.MinValue)
                        subItems[0] = string.Empty;
                     newItem.SubItems.AddRange(subItems);
                     caller.BlockedListRecord = newItem;
                  }
                  blockers.AddChangeRecord = currentBlocked;
               }
            }
         }
         return blockers;
      }
      //TODO This should return a set of records. If it's just a status change it doesn't seem to show up if there are multiple changes at the same time.

      public List<ChangeRecord> ProcessHistoryRecord(ChangedCollection blockers, TMobile_INFUOPS_Schema.History historyRecord, DetailView caller = null)//, ref ChangeRecord currentBlocked)
      {
         ChangeRecord currentRecord = null;
         ChangeRecord blockedRecord = null;
         List<ChangeRecord> records = new List<ChangeRecord>();
         //List<ChangeRecord> historyRecords = new List<ChangeRecord>();

         foreach (TMobile_INFUOPS_Schema.Item historyDetail in historyRecord.items)
         {
            currentRecord = ProcessChangeRecord(blockers.GetLastChangeRecord, historyRecord, historyDetail, blockedRecord, blockers.ReturnAllChangeRecords.Count, caller);
            if (currentRecord != null)
               if (currentRecord.IsStatusBlocked)
                  blockedRecord = currentRecord;
               else
               {
                  records.Add(currentRecord);
                  currentRecord = null;
               }
         }

         if (currentRecord != null && currentRecord.IsStatusBlocked)
            records.Add(currentRecord);

         //         if (currentRecord != null && currentRecord.IsStatusBlocked && currentRecord.ExpectedUnblockDate == DateTime.MinValue)
         //            currentRecord.IsStatusBlocked = false;

         return records;
      }

      private ChangeRecord ProcessChangeRecord(ChangeRecord LastBlockedInfo, TMobile_INFUOPS_Schema.History changeRecord,
         TMobile_INFUOPS_Schema.Item value, ChangeRecord info, int numberOfRecords, DetailView caller)
      {

         string OldValue = value.fromString;
         string NewValue = value.toString;
         string OutputFormat = "{3} @ {4} Changed {0} from {1} to {2}";

         if (IsNullString(OldValue) == string.Empty)
            OldValue = "{Blank}";

         if (NewValue == string.Empty)
            NewValue = "{Blank}";

         if (value.field == "Rank")
            OutputFormat = "{3} @ {4} Changed {2}";

         if (caller != null)
            caller.HistoryRecord = String.Format(OutputFormat, value.field, OldValue, NewValue, changeRecord.author.displayName, changeRecord.created.Date.ToString());

         switch (value.field)
         {
            case "status":
               if (NewValue == "Blocked")
               {
                  if (info == null)
                     info = ReturnInfoValue(LastBlockedInfo);

                  info.Who = changeRecord.author.displayName;
                  info.When = changeRecord.created;
                  info.Reason = string.Format("Changed Status from {0} to {1}", OldValue, NewValue);
                  info.IsStatusBlocked = true;
                  info.IsStatusChangeRecord = true;
               }
               else
               {
                  info = new ChangeRecord
                  {
                     Who = changeRecord.author.displayName,
                     When = changeRecord.created,
                     Reason = string.Format("Changed Status from {0} to {1}", OldValue, NewValue),
                     IsStatusChangeRecord = true
                  };
               }
               break;
            case "Blocked Reason":

               if (info == null)
                  info = ReturnInfoValue(LastBlockedInfo);
               else if (!info.IsStatusBlocked)
                  break;

               info.Who = changeRecord.author.displayName;
               info.When = changeRecord.created;
               info.Reason = NewValue;
               break;
            case "Expected Unblocked Date":

               if (value.toString != string.Empty)   // If the unblocked date is null (which is only reasonable for older records) it would otherwise throw an error.
               {
                  if (info == null)
                     info = ReturnInfoValue(LastBlockedInfo);
                  else if (!info.IsStatusBlocked)
                     break;

                  info.Who = changeRecord.author.displayName;
                  info.When = changeRecord.created;
                  info.ExpectedUnblockDate = Convert.ToDateTime(value.toString);
               }
               break;
            default:

               if (value.field == "Epic Link")
               {
                  if (changeRecord.author.displayName != "Costanzo, Stephen")
                     break;
               }
               info = new ChangeRecord()
               {
                  Who = changeRecord.author.displayName,
                  When = changeRecord.created,
                  Reason = string.Format("Changed {2} from {0} to {1}", OldValue, NewValue, value.field)
               };
               break;
         }

         if (info != null)
         {
            info.JIRAChangeField = value.field.ToString();
            info.OldValue = OldValue;
            info.NewValue = NewValue;
         }
         return info;

      }

      private ChangeRecord ReturnInfoValue(ChangeRecord LastBlockedInfo)
      {
         ChangeRecord info = new ChangeRecord();
         if (LastBlockedInfo != null)
         {
            info.Reason = LastBlockedInfo.Reason;
            info.ExpectedUnblockDate = LastBlockedInfo.ExpectedUnblockDate;
            info.IsStatusBlocked = true;
         }

         return info;
      }

      public ExportJSON SetupJSONExport(bool BlockerOnly, TMobile_INFUOPS_Schema.Issue issue, ChangedCollection change)
      {
         try
         {
            ExportIssueHeader exportIssueHeader = new ExportIssueHeader
            {
               self = issue.self,
               key = issue.key,
               summary = issue.fields.summary,
               assigneeName = issue.fields.assignee.displayName,
               currentStatus = issue.fields.status.name
               //showBlockedOnly = BlockerOnly
            };
            if (issue.fields.customfield_10004 != null)
               exportIssueHeader.numberOfSprints = issue.fields.customfield_10004.Length;
            else
               exportIssueHeader.numberOfSprints = 0;

            if (change != null)
            {
               exportIssueHeader.blockedStatusChanges = change.NumberOfTimesBlocked;
               exportIssueHeader.blockedUnblockDateChanges = change.NumberOfTimesUnblockedDateChanged;
            }

            if (BlockerOnly)
            {
               ExportJSON SendJSON = new ExportJSON
               {
                  ExportIssue = exportIssueHeader,
                  BlockRecords = change.ReturnAllBlockerRecords
               };
               return SendJSON;
            }
            else
            {
               ExportJSON SendJSON = new ExportJSON
               {
                  ExportIssue = exportIssueHeader,
                  StatusChangeRecords = change.ReturnAllStatusChangeRecords,
                  BlockRecords = change.ReturnAllBlockerRecords,
                  AllChangeRecords = change.ReturnAllChangeRecords
               };

               if (SendJSON.BlockRecords.Count == 0)
                  SendJSON.BlockRecords = null;

               if (SendJSON.StatusChangeRecords.Count == 0)
                  SendJSON.StatusChangeRecords = null;

               return SendJSON;
            }
         }
         catch (Exception ex)
         {
            System.Diagnostics.Debug.WriteLine(ex.Message);
            return null;
         }
      }
   }
}
