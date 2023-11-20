using BoDi;
using Mobile.Appium.UiTest.Drivers;
using NUnit.Framework;

namespace Mobile.Appium.UiTest.TestFixtures
{
    public abstract class BaseTextFixture
    {
        private readonly IObjectContainer _objectContainer;

        public BaseTextFixture(IObjectContainer iObjectContainer)
        {
            _objectContainer = iObjectContainer;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            AppiumDriver.StartApp();
        }

        [TearDown]
        public void Cleanup()
        {

        }

    }
}
