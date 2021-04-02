# Swag Labs Selenium Tests

## Overview
Automated NUnit tests written using Selenium in C#.  The project will test log in, checkout form, and shopping cart functionality at www.saucedemo.com.  The testing will be done using NUnit with NUnit Console Runner to automatically generate an XML report of the tests and ReportUnit to convert the XML report to HTML.  Selenium will also take a screenshot of each completed test and save it to a Screenshots folder.

## Video Walkthrough
Coming soon

## Installation Instructions
1.  Clone down the repository
2.  In Nuget Package Manager install the following: 
    - Selenium.WebDriver.ChromeDriver
    - NUnit
    - NUnit.ConsoleRunner
    - NUnit3TestAdapter
    - Selenium.Support
    - Selenium.Webdriver
    - DotNetSeleniumExtras.PageObjects
    
## Walkthrough
### Run the test through Console Runner
1. In file explorer navigate to \Swag-Labs-Tester\packages\NUnit.ConsoleRunner.3.12.0\tools then click File and open Powershell with administration privileges.
<img src="https://user-images.githubusercontent.com/62182071/113372354-7ecfd980-9336-11eb-8099-c85eac310be9.png">
2. Enter ** ./nunit3-console.exe "path to the project" **.  The project will be in \Swag-Labs-Tester\Swag-Labs-Tester\bin\Debug.  This will run the tests and generate an XML file of the results.
<img src="https://user-images.githubusercontent.com/62182071/113373538-0c142d80-9339-11eb-8464-89e4e2bf2d71.png">
3. After the test have completed change directories in powershell to the ** ReportUnit\tools ** directory
<img src="https://user-images.githubusercontent.com/62182071/113374439-27803800-933b-11eb-9177-b0913298612b.png">
4. In powershell enter ** reportunit.exe "Path to the NUnit.ConsoleRunner/tools directory" **
<img src="https://user-images.githubusercontent.com/62182071/113374298-d53f1700-933a-11eb-867a-54ca4b00de08.png">
5. An HTML file will be generated from the XML file called TestReport.
<img src="https://user-images.githubusercontent.com/62182071/113374129-5ea21980-933a-11eb-8527-b47a670197a3.png">

### Tests
The code will run 8 tests.  There are four authentication tests-- one to check the log in with an invalid username, one with an invalid password, one with the credentials of a user that's been locked out of the system, and one with valid credentials.  There are then three tests checkout form tests-- one where the name field is left blank, one where the last name field is left blank, and one where the ZIP code is left blank.  The final test is a shopping cart test where every item for sale on the site will be added to the cart and the item total, tax, and after-tax total will be checked to make sure the calculations are correct.  Screenshots will be taken of each test and saved in a Screenshots folder.
