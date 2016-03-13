using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Lab7
{
	partial class HomeController : UIViewController
	{
		public HomeController (IntPtr handle) : base (handle)
		{
		}
		public override void ViewDidLoad()
		{
			// on page load we will show the current user's First Name
			var currentUser = "John";
			lblWelcome.Text = "Welcome, " + currentUser;
		}
	}
}
