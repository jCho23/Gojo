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
			app.EnterText("demo@gojo.com");
			app.Tap("login_password");
			app.EnterText("smartlink");
			app.Tap("login_button");

			app.Tap("home_start_session_button");
			app.Tap("Demo Hospital - Five Moments");

			app.Tap("activity_observation_type_select_type");
			app.Tap("dialog_double_button_ok_button")

		}

	}
}
