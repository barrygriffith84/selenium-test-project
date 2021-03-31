using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Swag_Labs_Tester.Pages;
using System.IO;

namespace Swag_Labs_Tester
{
    public static class Actions
    {
        //Add all of the products on the products page to the cart
        public static void AddAllItemsToCart()
        {
            Products prod = new Products();

            prod.BackpackAddToCartBtn.Click();
            prod.BoltShirtAddToCartBtn.Click();
            prod.OnesieAddToCartBtn.Click();
            prod.LightAddToCartBtn.Click();
            prod.JacketAddToCartBtn.Click();
            prod.RedShirtAddToCartBtn.Click();
        }

        //Only add the backpack to the cart
        public static void AddBackPackToCart()
        {
            Products prod = new Products();

            prod.BackpackAddToCartBtn.Click();
        }

        //Fill out the First Name, Last Name, and Postal Code during the checkout process
        public static void FillOutStepOneAndSubmit(string firstName, string lastName, string zip)
        {
            CheckoutStepOne stepOne = new CheckoutStepOne();

            stepOne.FirstNameInput.Clear();
            stepOne.FirstNameInput.SendKeys(firstName);
            stepOne.LastNameInput.Clear();
            stepOne.LastNameInput.SendKeys(lastName);
            stepOne.ZipInput.Clear();
            stepOne.ZipInput.SendKeys(zip);
            stepOne.ContinueBtn.Click();
        }

        //Opens the webdriver, navigates to http//www.saucedemo.com, and maximizes the browser window
        public static void InitializeDriver()
        {
            Driver.driver.Navigate().GoToUrl(Config.BaseURL);
            Driver.driver.Manage().Window.Maximize();
        }

        //Fills out the log in form and submits
        public static void LogIn(string username, string password)
        {
            Authorization authPage = new Authorization();

            authPage.NameInput.Clear();
            authPage.NameInput.SendKeys(username);
            authPage.PasswordInput.Clear();
            authPage.PasswordInput.SendKeys(password);
            authPage.LoginBtn.Click();
        }

        //Take a screenshot of the current page in the webdriver.  The title parameter is a string that will name the image.  Returns as a PNG.
        public static void TakeScreenShot(string title)
        {
            string screenshotDirectory = Directory.GetCurrentDirectory() + @"\screenshots";

            Screenshot screenshot = ((ITakesScreenshot)Driver.driver).GetScreenshot();
            
            //Creates a directory to store the screenshots if one does not exist
            if (!Directory.Exists(screenshotDirectory))
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + @"\screenshots");
            }

            screenshot.SaveAsFile(Directory.GetCurrentDirectory() + @"\screenshots\" + title + ".png");
          
        }
      

    }
}
