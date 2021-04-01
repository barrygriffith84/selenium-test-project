using NUnit.Framework;
using Swag_Labs_Tester.Pages;
using System.Threading;

namespace Swag_Labs_Tester
{
    public class Tests
    {
        Authorization auth = new Authorization();
        Products products = new Products();
        Cart cart = new Cart();
        CheckoutStepOne checkout1 = new CheckoutStepOne();
        CheckoutStepTwo checkout2 = new CheckoutStepTwo();

        [OneTimeSetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();
        }

        //Test to see if the error message from the locked out user is the the expected error message stored in Config.ErrorMessages.LockedOutUser
        [Test, Order(1)]
        public void LockedOutLogin()
        {
            Actions.LogIn(Config.Credentials.LockedOut.Username, Config.Credentials.LockedOut.Password);

            Actions.TakeScreenShot("LockedOutUser");

            Thread.Sleep(4000);

            Assert.AreEqual(Config.ErrorMessages.LockedOutUser, auth.ErrorHeader.Text);
        }

        //Try to log in with an invalid username and valid password
        [Test, Order(0)]
        public void InvalidUsername()
        {
            Actions.LogIn(Config.Credentials.Invalid.Username, Config.Credentials.Valid.Password);

            Actions.TakeScreenShot("InvalidUsername");

            Thread.Sleep(4000);

            Assert.AreEqual(Config.ErrorMessages.InvalidLogin, auth.ErrorHeader.Text);
        }

        //Try to log in with a valid username and invalid password
        [Test, Order(2)]
        public void InvalidPassword()
        {
            Actions.LogIn(Config.Credentials.Valid.Username, Config.Credentials.Invalid.Password);

            Actions.TakeScreenShot("InvalidPassword");

            Thread.Sleep(4000);

            Assert.AreEqual(Config.ErrorMessages.InvalidLogin, auth.ErrorHeader.Text);
        }

        //Log into the site with valid credentials
        [Test, Order(3)]
        public void ValidLogin()
        {
            Actions.LogIn(Config.Credentials.Valid.Username, Config.Credentials.Valid.Password);

            Actions.TakeScreenShot("ValidCredentials");

            Thread.Sleep(4000);

            Assert.AreEqual("https://www.saucedemo.com/inventory.html", Driver.driver.Url);
        }
        
        //Test checkout form with blank first name
        [Test, Order(4)]
        public void EmptyFirstName()
        {
            Driver.driver.Navigate().GoToUrl("https://www.saucedemo.com/checkout-step-one.html");

            checkout1.FirstNameInput.Clear();
            checkout1.LastNameInput.Clear();
            checkout1.LastNameInput.SendKeys("Doe");
            checkout1.ZipInput.Clear();
            checkout1.ZipInput.SendKeys("12345");
            checkout1.ContinueBtn.Click();

            Thread.Sleep(4000);

            Actions.TakeScreenShot("EmptyFirstName");


            Assert.AreEqual(Config.ErrorMessages.BlankFirstName, checkout1.FormErrorMessage.Text);
        }

        //Test checkout form with blank last name
        [Test, Order(5)]
        public void EmptyLastName()
        {
            Driver.driver.Navigate().GoToUrl("https://www.saucedemo.com/checkout-step-one.html");

            checkout1.FirstNameInput.Clear();
            checkout1.FirstNameInput.SendKeys("John");
            checkout1.LastNameInput.Clear();
            checkout1.ZipInput.Clear();
            checkout1.ZipInput.SendKeys("12345");
            checkout1.ContinueBtn.Click();

            Actions.TakeScreenShot("EmptyLastName");

            Thread.Sleep(4000);

            Assert.AreEqual(Config.ErrorMessages.BlankLastName, checkout1.FormErrorMessage.Text);
        }

        //Test checkout form with blank postal code
        [Test, Order(6)]
        public void EmptyPostalCode()
        {
            Driver.driver.Navigate().GoToUrl("https://www.saucedemo.com/checkout-step-one.html");

            checkout1.FirstNameInput.Clear();
            checkout1.FirstNameInput.SendKeys("John");
            checkout1.LastNameInput.Clear();
            checkout1.LastNameInput.SendKeys("Doe");
            checkout1.ZipInput.Clear();

            checkout1.ContinueBtn.Click();

            Actions.TakeScreenShot("EmptyPostalCode");


            Thread.Sleep(4000);

            Assert.AreEqual(Config.ErrorMessages.BlankPostalCode, checkout1.FormErrorMessage.Text);
        }

        //Add every product to the cart and checks the item total, tax, and total calculations, then checks for successful completion of the order.
        [Test, Order(7)]
        public void ShoppingCartTotal()
        {
            Driver.driver.Navigate().GoToUrl("https://www.saucedemo.com/inventory.html");
            Actions.AddAllItemsToCart();
            products.ShoppingCartLink.Click();
            cart.CheckoutBtn.Click();
            Actions.FillOutStepOneAndSubmit("John", "Doe", "55555");

            Actions.TakeScreenShot("ShoppingCartTotal");


            Thread.Sleep(4000);

            //Checks the item total, tax, and total
            Assert.AreEqual(Config.FullCart.ItemTotal, checkout2.ItemTotal.Text);
            Assert.AreEqual(Config.FullCart.Tax, checkout2.Tax.Text);
            Assert.AreEqual(Config.FullCart.Total, checkout2.Total.Text);

            checkout2.FinishBtn.Click();

            //Checks the successful completion of the order by checking the URL.
            Assert.AreEqual("https://www.saucedemo.com/checkout-complete.html", Driver.driver.Url);
        }

        //Close the webdriver after the test is completed
        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}
