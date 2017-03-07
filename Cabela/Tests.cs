using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using System.Threading;

namespace Cabela
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
		public void FirstTest()
		{
			app.Tap("hunting");
			Thread.Sleep(30000);
			app.Screenshot("We tapped on 'Hunting'");
			app.Back();
			app.Screenshot("Tapped back to get out of 'Hunting'");

			app.Tap("shooting");
			Thread.Sleep(30000);
			app.Screenshot("We tapped on 'Shooting'");
			app.Back();
			app.Screenshot("Tapped back to get out of 'Shooting'");

			app.Tap("fishing");
			Thread.Sleep(30000);
			app.Screenshot("We tapped on 'Fishing'");
			app.Back();
			app.Screenshot("Tapped back to get out of 'Fishing'");

			app.Tap("clothing");
			Thread.Sleep(30000);
			app.Screenshot("We tapped on 'Clothing'");
			app.Back();
			app.Screenshot("Tapped back to get out of 'Clothing'");

			app.Tap("footwear");
			Thread.Sleep(30000);
			app.Screenshot("We tapped on 'Footwear'");
			app.Back();
			app.Screenshot("Tapped back to get out of 'Footwear'");

			app.Tap("camping");
			Thread.Sleep(30000);
			app.Screenshot("We tapped on 'Camping'");
			app.Back();
			app.Screenshot("Tapped back to get out of 'Camping'");

			app.Tap("search");
			app.Screenshot("Tapped on Search Button");

			app.EnterText("Microsoft");
			Thread.Sleep(30000);
			app.Screenshot("We wrote our search, 'Microsoft'");
			app.PressEnter();
			app.Screenshot("We tapped enter to perform our search");

			app.Tap("more");
			Thread.Sleep(30000);
			app.Screenshot("We Tapped on 'More' tab");

			app.Tap("MyAccount_More");
			Thread.Sleep(30000);
			app.Screenshot("Tapped on our account to see more information");
	
			app.Tap("offers");
			Thread.Sleep(30000);
			app.Screenshot("We tapped on 'Offers'");
		}

	}
}
