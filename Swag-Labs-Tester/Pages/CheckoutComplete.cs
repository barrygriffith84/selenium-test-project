using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace Swag_Labs_Tester.Pages
{
    class CheckoutComplete
    {
        public CheckoutComplete()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        //Header for complete order page.  Text is "THANK YOU FOR YOUR ORDER"
        [FindsBy(How = How.CssSelector, Using = "#checkout_complete_container > h2")]
        public IWebElement CompleteHeader { get; set; }

        //Sub heading after completed order.  Text is "Your order has been dispatched, and will arrive just as fast as the pony can get there!"
        [FindsBy(How = How.CssSelector, Using = "#checkout_complete_container > h2")]
        public IWebElement CompleteSubHeader { get; set; }

        //Sauce Labs Pony Express image that shows up on complete order page.
        [FindsBy(How = How.CssSelector, Using = "#checkout_complete_container > img")]
        public IWebElement PonyExpressImg { get; set; }

    }
}
