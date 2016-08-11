using Foundation;
using System;
using UIKit;
using MessageUI;

namespace DeakinOpenDay
{
    public partial class FeedBackViewController : UIViewController
    {
		MFMailComposeViewController mailController;
        public FeedBackViewController (IntPtr handle) : base (handle)
        {
        }

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			// wire up the send-mail compose view controller

			{
				if (MFMailComposeViewController.CanSendMail)
				{

					var to = new string[] { "john@doe.com" };

					if (MFMailComposeViewController.CanSendMail)
					{
						mailController = new MFMailComposeViewController();
						mailController.SetToRecipients(to);
						mailController.SetSubject("mail test");
						mailController.SetMessageBody("this is a test", false);
						mailController.Finished += (object s, MFComposeResultEventArgs args) =>
						{

							Console.WriteLine("result: " + args.Result.ToString()); // sent or cancelled

							BeginInvokeOnMainThread(() =>
							{
								args.Controller.DismissViewController(true, null);
							});
						};
					}

					this.PresentViewController(mailController, true, null);
				}
				else {
					new UIAlertView("Mail not supported", "Can't send mail from this device", null, "OK");
				}
			};
		}
    }
}