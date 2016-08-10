using Foundation;
using System;
using UIKit;

namespace DeakinOpenDay
{
    public partial class TableViewController : UITableViewController
    {
        public TableViewController (IntPtr handle) : base (handle)
        {
        }

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			string[] items = new string[] { "Buildings", "Lecture Theatres", "Rooms", "Labs", "Female Tiolets", "Male Tiolets", "Disabled Tiolets", "Coffee", "Food", "Bars", "Uni Services", "Offices", "Offices", "Parking", "Sport", "Computers", "Study Spsce", "Shops", "ATMs","Accomadtion", "Landmarks", "Printing", "Vending Machines", "Transport", "Gates", "Microwaves", "H20", "Assignment Boxes", "Secret Places",};
			TableData.Source = new TableSource(items, this);
		}
    }
}