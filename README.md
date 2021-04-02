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
2. Enter **./nunit3-console.exe "path to the project"**.  The project will be in \Swag-Labs-Tester\Swag-Labs-Tester\bin\Debug.  This will run the tests and generate an XML file of the results.
<img src="https://user-images.githubusercontent.com/62182071/113373538-0c142d80-9339-11eb-8464-89e4e2bf2d71.png">
3. After the test have completed change directories in powershell to the ReportUnit/tools directory
<img src="https://user-images.githubusercontent.com/62182071/113373667-60b7a880-9339-11eb-95b1-b77c991fadb5.png">
4. In powershell enter **reportunit.exe "Path to the NUnit.ConsoleRunner/tools directory"**
<img src="https://user-images.githubusercontent.com/62182071/113373894-dd4a8700-9339-11eb-92b4-76fbdcb7e977.png">
5. An HTML file will be generated from the XML file called TestReport.
<img src="https://user-images.githubusercontent.com/62182071/113373979-066b1780-933a-11eb-8b53-dfacf3b13c61.png">

### Screenshots of each console command and test results.  Also post screenshots of the reports.
