using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace Gojo
{
	[TestFixture(Platform.Android)]
	[TestFixture(Platform.iOS)]
	public class Tests
	{
		IApp app;
		Platform platform;

		public Tests(Platform platform)
		{
			this.platform = platform;
		}

		[SetUp]
		public void BeforeEachTest()
		{
			app = AppInitializer.StartApp(platform);
			app.Screenshot("App Launched");
		}

		[Test]
		public void Repl()
		{
			app.Repl();
		}

		[Test]
		public void DemoHospitalFiveMoments()
		{
			app.Tap("login_username");
			app.Screenshot("Let's start by Tapping on the 'Email' Text Field");
			app.EnterText("demo@gojo.com");
			app.Screenshot("Then we entered our 'Email', 'demo@gojo.com'");
			app.Tap("login_password");
			app.Screenshot("And we Tapped on on the 'password' Text Field");
			app.EnterText("smartlink");
			app.Screenshot("Next we entered our password, 'smartlink'");
			app.Tap("login_button");
			app.Screenshot("Then we Tapped on 'login' Button");

			app.Tap("home_start_session_button");
			app.Screenshot("We Tapped on the 'Start Session'");
			app.Tap("Demo Hospital - Five Moments");
			app.Screenshot("Then we Tapped on 'Demo Hospital - Five Moments'");

			app.Tap("activity_observation_type_select_type");
			app.Screenshot("Next we Tapped on the 'Plus' Icon");
			app.Tap("dialog_double_button_ok_button");
			app.Screenshot("Then we Tapped on 'PPE'");

			app.Tap("Clinic");
			app.Screenshot("We Tapped on 'Clinic'");
			app.Tap("Doctor");
			app.Screenshot("");
			app.Tap("In Room");

			app.Tap("Airborne");
			app.Tap("activity_session_tab_save_observation");
		}


	}
}
