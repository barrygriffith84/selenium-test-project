using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Swag_Labs_Tester.Pages
{
    class Authorization
    {
        public Authorization()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.Name, Using = "user-name")]
        public IWebElement NameInput { get; set; }

        [FindsBy(How = How.Name, Using = "password")]
        public IWebElement PasswordInput { get; set; }

        [FindsBy(How = How.Id, Using = "login-button")]
        public IWebElement LoginBtn { get; set; }

        [FindsBy(How = How.CssSelector, Using = "body > div.login_wrapper > div.login_wrapper-inner > img")]
        public IWebElement Image { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#login_button_container > div > form > h3")]
        public IWebElement ErrorHeader { get; set; }
    }
}
