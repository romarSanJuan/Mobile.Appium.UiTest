using Mobile.Appium.UiTest.Pages.MainPage;
using OpenQA.Selenium;

namespace Mobile.Appium.UiTest.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        private IWebDriver driver;
        LoginPage loginPage;

        public CalculatorStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }

        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            loginPage = new LoginPage(driver);
            loginPage.InputEmail("email");
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {

        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {

        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {

        }
    }
}