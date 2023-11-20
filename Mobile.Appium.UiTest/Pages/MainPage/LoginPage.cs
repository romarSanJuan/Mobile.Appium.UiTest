using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace Mobile.Appium.UiTest.Pages.MainPage
{
    class LoginPage
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "Element Locator")]
        private IWebElement btnLogin { get; set; }

        [FindsBy(How = How.Id, Using = "Element Locator")]
        private IWebElement txtPassword { get; set; }

        [FindsBy(How = How.Id, Using = "Element Locator")]
        private IWebElement txtUserName { get; set; }

        public void InputEmail(string userEmail)
        {
            txtUserName.SendKeys(userEmail);
        }

        public void InputPassword(string userPassworrd)
        {
            txtPassword.SendKeys(userPassworrd);
        }

        public void SelectLoginButton()
        {
            btnLogin.Click();
        }
    }
}
