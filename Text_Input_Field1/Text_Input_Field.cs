using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

class Text_Input_Field
{
    static IWebDriver driver = new ChromeDriver();
    static IWebElement textBox;
    static void Main()
    {

        string url = "https://testing.todorvachev.com/special-elements/text-input-field/";



        driver.Navigate().GoToUrl(url);

        textBox = driver.FindElement(By.Name("username"));

        textBox.SendKeys("Test text");

        Thread.Sleep(3000);

        Console.WriteLine(textBox.GetAttribute("value"));
        Console.WriteLine(textBox.GetAttribute("maxlength"));

        //textBox.Clear();

        Thread.Sleep(3000);

        driver.Quit();


    }
}