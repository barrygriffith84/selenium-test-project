using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Swag_Labs_Tester.Pages
{
    class Cart
    {
        public Cart()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        //Continue Shopping Button
        [FindsBy(How = How.CssSelector, Using = "#cart_contents_container > div > div.cart_footer > a.btn_secondary")]
        public IWebElement ContinueShoppingBtn { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#cart_contents_container > div > div.cart_footer > a.btn_action.checkout_button")]
        public IWebElement CheckoutBtn { get; set; }
    }
}
