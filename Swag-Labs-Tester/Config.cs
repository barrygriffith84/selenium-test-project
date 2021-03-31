using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swag_Labs_Tester
{
    //A static class to hold any strings needed for tests like usernames, passwords, or error messages the site will return.
    public static class Config
    {
        public static string BaseURL = "http://www.saucedemo.com/";

        public static class Credentials
        {
            //Working credentials to log into the site
            public static class Valid
            {
                public static string Username = "standard_user";
                public static string Password = "secret_sauce";
            }

            //Credentials that should fail a log in attempt
            public static class Invalid
            {
                public static string Username = "bad_user_name";
                public static string Password = "bad_pass";
            }

            //Credentials that are valid, but the user is locked out of the website by the admin
            public static class LockedOut
            {
                public static string Username = "locked_out_user";
                public static string Password = "secret_sauce";
            }
        }

        //The Item Total, Tax, and Total on the checkout-step-two page when every item is in the cart
        public static class FullCart
        {
            public static string ItemTotal = "Item total: $129.94";
            public static string Tax = "Tax: $10.40";
            public static string Total = "Total: $140.34";
        }

        //Any error messages the site returns
        public static class ErrorMessages
        {
            //Error messages from the log in page
            public static string BlankUsername = "Epic sadface: Username is required";
            public static string BlankPassword = "Epic sadface: Password is required";
            public static string InvalidLogin = "Epic sadface: Username and password do not match any user in this service";
            public static string LockedOutUser = "Epic sadface: Sorry, this user has been locked out.";

            //Error messages for the CheckoutStepOne form
            public static string BlankFirstName = "Error: First Name is required";
            public static string BlankLastName = "Error: Last Name is required";
            public static string BlankPostalCode = "Error: Postal Code is required";
        }
    }
}
