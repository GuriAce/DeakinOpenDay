using Foundation;
using System;
using UIKit;
using System.Collections.Generic;

namespace DeakinOpenDay
{
	public partial class TableViewController : UITableViewController
	{
		



		List<Chore> chores;
		public TableViewController(IntPtr handle) : base(handle)
		{

		}

		public override void ViewDidLoad()
		{
			chores = new List<Chore> {
	  new Chore {Name="Groceries", Notes="Buy bread, cheese, apples", Done=false},
	  new Chore {Name="Devices", Notes="Buy Nexus, Galaxy, Droid", Done=false}
			}; ;
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.

			AddButton.Clicked += (sender, e) => CreateTask();

		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}


		public void CreateTask()
		{
			// first, add the task to the underlying data
			var newId = chores[chores.Count - 1].Id + 1;
			var newChore = new Chore { Id = newId };
			chores.Add(newChore);

			// then open the detail view to edit it
			var detail = Storyboard.InstantiateViewController("detail") as TaskDetailViewController;
			detail.SetTask(this, newChore);
			NavigationController.PushViewController(detail, true);
		}

		public override void ViewWillAppear(bool animated)
		{
			base.ViewWillAppear(animated);

			TableView.Source = new RootTableSource(chores.ToArray());
		}





	}
}