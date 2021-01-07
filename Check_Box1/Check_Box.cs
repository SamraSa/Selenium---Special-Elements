using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

class Check_Box
{

    static IWebDriver driver = new ChromeDriver();
    static IWebElement check_Box;
    static void Main()
    {

        string url = "https://testing.todorvachev.com/special-elements/check-button-test-3/";
        string option = "1";
        driver.Navigate().GoToUrl(url);


        check_Box = driver.FindElement(By.CssSelector("#post-33 > div > p:nth-child(8) > input[type=\"checkbox\"]:nth-child(" + option + ")"));

        if (check_Box.GetAttribute("checked") == "true")
         {
             Console.WriteLine("The checkbox is checked!");
         }
         else
         {
             Console.WriteLine("The checkbox is NOT checked!");
             check_Box.Click();
            Thread.Sleep(3000);
        }
        

        /* Console.WriteLine(check_Box.GetAttribute("value"));

         option = "3";

         check_Box = driver.FindElement(By.CssSelector("#post-33 > div > p:nth-child(8) > input[type=\"checkbox\"]:nth-child(" + option + ")"));

         Console.WriteLine(check_Box.GetAttribute("value"));
        */
       // check_Box.Click();

        Thread.Sleep(3000);

        driver.Quit();
    }
}
