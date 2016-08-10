using System;
using Foundation;
using MediaPlayer;
using UIKit;

namespace DeakinOpenDay
{
	public partial class FirstViewController : UIViewController
	{

		MPMoviePlayerController moviePlayer;






		public FirstViewController() : base ("FirstViewController", null)
		{
		}

		partial void UIButton13_TouchUpInside(UIButton sender)
		{
			

			{
				moviePlayer = new MPMoviePlayerController(NSUrl.FromFilename("OpenDay.mp4"));
				//Video Referrence


				View.AddSubview(moviePlayer.View);
				moviePlayer.SetFullscreen(true, true);
				moviePlayer.Play();
			};
		}

		protected FirstViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.

		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}

		public override bool ShouldAutorotateToInterfaceOrientation(UIInterfaceOrientation toInterfaceOrientation)
		{
			// Return true for supported orientations
			return (toInterfaceOrientation != UIInterfaceOrientation.PortraitUpsideDown);
		}
	}
}

