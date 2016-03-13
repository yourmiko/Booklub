using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Lab7
{
	partial class LoginController : UIViewController
	{
		public LoginController (IntPtr handle) : base (handle)
		{
			// set the title of your App here
			Title= "My Login App";
		}

		partial void BtnLogin_TouchUpInside (UIButton sender)
		{
			// to prevent the user from clicking on the button multiple times,
			// I will hide by login button when it is clicked on till all the processing is complete
			btnLogin.Hidden = true;
			var email = txtEmail.Text;
			var password = txtPassword.Text;
			var error = "Enter a valid E-mail Address and Password";
			var alert = new UIAlertView();
			// write logic such that if the username is “INTE” and the password is “4051”
			// the user will move on to the next page,
			// otherwise you will display an alert pop-up/error message
			if (email == "INTE" && password == "4051" )
			{

				// navigate to the welcome page, this is sample code for redirecting to another page
				// note: "home" is the StoryBoard ID of the HomeController
				var home = Storyboard.InstantiateViewController("home") as HomeController;
				NavigationController.PushViewController (home, true);
			}
			else
			{
				alert = new UIAlertView("Login Failed", error, null, "OK");
				alert.Show();
			}
			// now I will display my login button
			btnLogin.Hidden = false;
		}
	}
}
