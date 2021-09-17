using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITestSample
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
        }

        [Test]
        public void WelcomeTextIsDisplayed()
        {

            app.WaitForElement(c => c.Marked("EntryPhoneNumber"));
            app.EnterText(c => c.Marked("EntryPhoneNumber"), "1234567890");

            app.Tap(c => c.Marked("ValidateButton"));
            AppResult[] results = app.WaitForElement(c => c.Marked("ResultLabel"));
            Assert.IsTrue(results.Any());

            
        }
    }
}
