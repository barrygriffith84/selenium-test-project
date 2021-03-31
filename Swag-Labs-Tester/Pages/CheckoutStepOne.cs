using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Swag_Labs_Tester.Pages
{
    class CheckoutStepOne
    {
        public CheckoutStepOne()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        //First Name Input
        [FindsBy(How = How.Id, Using = "first-name")]
        public IWebElement FirstNameInput { get; set; }

        //Last Name Input
        [FindsBy(How = How.Id, Using = "last-name")]
        public IWebElement LastNameInput { get; set; }

        //Zip Code Input
        [FindsBy(How = How.Id, Using = "postal-code")]
        public IWebElement ZipInput { get; set; }

        //Continue Button
        [FindsBy(How = How.CssSelector, Using = "#checkout_info_container > div > form > div.checkout_buttons > input")]
        public IWebElement ContinueBtn { get; set; }

        //Cancel Button
        [FindsBy(How = How.CssSelector, Using = "#checkout_info_container > div > form > div.checkout_buttons > a")]
        public IWebElement CancelBtn { get; set; }

        //Error message
        [FindsBy(How = How.CssSelector, Using = "#checkout_info_container > div > form > h3")]
        public IWebElement FormErrorMessage { get; set; }
    }
}
