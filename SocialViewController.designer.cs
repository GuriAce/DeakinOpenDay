// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace DeakinOpenDay
{
    [Register ("SocialViewController")]
    partial class SocialViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton SendTweet { get; set; }

        [Action ("SendTweet_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void SendTweet_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (SendTweet != null) {
                SendTweet.Dispose ();
                SendTweet = null;
            }
        }
    }
}