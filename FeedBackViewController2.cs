using Foundation;
using System;
using UIKit;
using MessageUI;

namespace DeakinOpenDay
{
	public partial class FeedBackViewController2 : UIViewController
	{


		MFMailComposeViewController mailController;
		public FeedBackViewController2(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			// wire up the send-mail compose view controller
			{
				if (MFMailComposeViewController.CanSendMail)
				{

					var to = new string[] { "enquire@deakin.com.au" };

					if (MFMailComposeViewController.CanSendMail)
					{
						mailController = new MFMailComposeViewController();
						mailController.SetToRecipients(to);
						mailController.SetSubject("Deakin Open Day");
						mailController.SetMessageBody("Enquire", false);
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