using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;

namespace Mobile.Appium.UiTest.Drivers
{
    public class AppiumDriver
    {
        public AndroidDriver<AndroidElement> _driver { get; set;}

        public AndroidDriver<AndroidElement> InitializeAppium()
        {
            var appiumOptions = new AppiumOptions();
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.Udid, "89RKRO7DMNQK9PFI");
            appiumOptions.AddAdditionalCapability(AndroidMobileCapabilityType.AppPackage, "ch.erni.gilgen.mobile.dev");
            appiumOptions.AddAdditionalCapability(AndroidMobileCapabilityType.AppActivity, "crc64036933c158ef6a5a.MainActivity");

            return new AndroidDriver<AndroidElement>(new Uri("http://localhost:4723/wd/hub"), appiumOptions);
        }
    }
}
