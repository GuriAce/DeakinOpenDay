using Foundation;
using System;
using UIKit;

namespace DeakinOpenDay
{
    public partial class TaskDetailViewController : UITableViewController
    {
		
		Chore currentTask { get; set; }
		public TableViewController Delegate { get; set; } 
		public override void ViewWillAppear(bool animated)
		{
			base.ViewWillAppear(animated);
			TitleText.Text = currentTask.Name;
			NotesText.Text = currentTask.Notes;
			DoneSwitch.On = currentTask.Done;
		}

		// this will be called before the view is displayed
		public void SetTask(TableViewController d, Chore task)
		{
			Delegate = d;
			currentTask = task;
		}// will be used to Save, Delete later


		public TaskDetailViewController (IntPtr handle) : base (handle)

		        {
        }



		public override void ViewDidLoad()
		{
			

		}

		public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
		{
			if (segue.Identifier == "TaskSegue")
			{ // set in Storyboard
				var navctlr = segue.DestinationViewController as TaskDetailViewController;
				if (navctlr != null)
				{
					var source = TableView.Source as RootTableSource;
					var rowPath = TableView.IndexPathForSelectedRow;
					var item = source.GetItem(rowPath.Row);
					navctlr.SetTask(this, item); // to be defined on the TaskDetailViewController
				}
			}
		}

		void SetTask(TaskDetailViewController taskDetailViewController, Chore item)
		{
			throw new NotImplementedException();
		}


}
}