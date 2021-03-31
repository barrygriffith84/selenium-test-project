using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Swag_Labs_Tester.Pages
{
    class Products
    {
        public Products()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        //Product sort drop down
        [FindsBy(How = How.CssSelector, Using = "#inventory_filter_container > select")]
        public IWebElement ProductSortDropDown { get; set; }

        //Shopping Cart Link
        [FindsBy(How = How.CssSelector, Using = "#shopping_cart_container > a")]
        public IWebElement ShoppingCartLink { get; set; }

        //Backpack
        [FindsBy(How = How.CssSelector, Using = "#item_4_img_link > img")]
        public IWebElement BackpackImage { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#inventory_container > div > div:nth-child(1) > div.pricebar > button")]
        public IWebElement BackpackAddToCartBtn { get; set; }

        //Bolt Shirt
        [FindsBy(How = How.CssSelector, Using = "#item_1_img_link > img")]
        public IWebElement BoltShirtImage { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#inventory_container > div > div:nth-child(3) > div.pricebar > button")]
        public IWebElement BoltShirtAddToCartBtn { get; set; }

        //Bike Light
        [FindsBy(How = How.CssSelector, Using = "#item_0_img_link > img")]
        public IWebElement LightImage { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#inventory_container > div > div:nth-child(2) > div.pricebar > button")]
        public IWebElement LightAddToCartBtn { get; set; }

        //Fleece Jacket
        [FindsBy(How = How.CssSelector, Using = "#item_5_img_link > img")]
        public IWebElement JacketImage { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#inventory_container > div > div:nth-child(4) > div.pricebar > button")]
        public IWebElement JacketAddToCartBtn { get; set; }

        //Onesie
        [FindsBy(How = How.CssSelector, Using = "#item_2_img_link > img")]
        public IWebElement OnesieImage { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#inventory_container > div > div:nth-child(5) > div.pricebar > button")]
        public IWebElement OnesieAddToCartBtn { get; set; }

        //Red Shirt
        [FindsBy(How = How.CssSelector, Using = "#item_3_img_link > img")]
        public IWebElement RedShirtImage { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#inventory_container > div > div:nth-child(6) > div.pricebar > button")]
        public IWebElement RedShirtAddToCartBtn { get; set; }
    }
}
