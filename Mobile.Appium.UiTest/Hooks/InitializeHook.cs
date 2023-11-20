using Mobile.Appium.UiTest.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile.Appium.UiTest.Hooks
{
    [Binding]
    class InitializeHook
    {
        private readonly ScenarioContext _scenarioContext;

        public InitializeHook(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [BeforeScenario]
        public void Initialize()
        {
            AppiumDriver appiumdriver = new AppiumDriver();
            appiumdriver.InitializeAppium();
        }
    }
}
