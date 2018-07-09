using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlockedItems
{
   public partial class SolutionParent : Form
   {
      public SolutionParent()
      {
         InitializeComponent();
      }


      private void mainToolStripMenuItem_Click(object sender, EventArgs e)
      {
         LookupForm lookupForm = new LookupForm
         {
            MdiParent = this
         };
         lookupForm.Show();
      }

      private void postStoryChangesToolStripMenuItem_Click(object sender, EventArgs e)
      {
         PostJSON postJSON = new PostJSON
         {
            MdiParent = this
         };
         postJSON.Show();

      }

      private void postSprintChangesToolStripMenuItem_Click(object sender, EventArgs e)
      {
         PostSprintChanges postSprintChanges = new PostSprintChanges
         {
            MdiParent = this
         };
         postSprintChanges.Show();
   }
}
}
