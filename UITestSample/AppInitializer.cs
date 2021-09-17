using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITestSample
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp.Android.Debug().ApkFile("../../../UITest1.Android/bin/Debug/com.companyname.uitest1.apk").StartApp();
            }
            return ConfigureApp.iOS.AppBundle("../../..UITest1.iOS/bin/iPhoneSimulator/Debug/UITest1.iOS.app").StartApp();
        }
    }
}