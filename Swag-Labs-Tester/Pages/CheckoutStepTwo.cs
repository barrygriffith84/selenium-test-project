using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Swag_Labs_Tester.Pages
{
    class CheckoutStepTwo
    {
        public CheckoutStepTwo()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        //Quantity of first item in the cart
        [FindsBy(How = How.CssSelector, Using = "#checkout_summary_container > div > div.cart_list > div.cart_item > div.summary_quantity")]
        public IWebElement Quantity { get; set; }

        //Payment information.  Should always be "SauceCard #31337"
        [FindsBy(How = How.CssSelector, Using = "#checkout_summary_container > div > div.summary_info > div:nth-child(2)")]
        public IWebElement PaymentInfo { get; set; }

        //Shipping Information.  Should always be "FREE PONY EXPRESS DELIVERY!"
        [FindsBy(How = How.CssSelector, Using = "#checkout_summary_container > div > div.summary_info > div:nth-child(4)")]
        public IWebElement ShippingInfo { get; set; }

        //The subtotal of the items in the cart before tax.  Use Object.Text to get the amount.  Example string from Object.Text: "Item total: $29.99" 
        [FindsBy(How = How.CssSelector, Using = "#checkout_summary_container > div > div.summary_info > div.summary_subtotal_label")]
        public IWebElement ItemTotal { get; set; }

        //The tax amount for the items in the cart.  Use Object.Text to get the amount.  Example string from Object.Text: "Tax: $2.40" 
        [FindsBy(How = How.CssSelector, Using = "#checkout_summary_container > div > div.summary_info > div.summary_tax_label")]
        public IWebElement Tax { get; set; }

        //The total after tax for the items in the cart.  Use Object.Text to get the amount.  Example string from Object.Text: "Total: $32.39" 
        [FindsBy(How = How.CssSelector, Using = "#checkout_summary_container > div > div.summary_info > div.summary_total_label")]
        public IWebElement Total { get; set; }

        //Cancel button
        [FindsBy(How = How.CssSelector, Using = "#checkout_summary_container > div > div.summary_info > div.cart_footer > a.cart_cancel_link.btn_secondary")]
        public IWebElement CancelBtn { get; set; }

        //Finish button
        [FindsBy(How = How.CssSelector, Using = "#checkout_summary_container > div > div.summary_info > div.cart_footer > a.btn_action.cart_button")]
        public IWebElement FinishBtn { get; set; }


    }
}
