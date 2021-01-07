﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

class Radio_Button
{

    static IWebDriver driver = new ChromeDriver();
    static IAlert alert;
    static IWebElement image;
    static void Main()
    {

        string url = "https://testing.todorvachev.com/special-elements/alert-box/";

        driver.Navigate().GoToUrl(url);

        alert = driver.SwitchTo().Alert();

        Console.WriteLine(alert.Text);

        alert.Accept();

        image = driver.FindElement(By.CssSelector("#post-119 > div > figure > img"));

try
        {
            if (image.Displayed)
            {
                Console.WriteLine("The alert was successfuly accepted and we can see the image!");
            }
        }
        catch (NoSuchElementException)
        {
            Console.WriteLine("Something went wrong!!");
        }
        Thread.Sleep(3000);

        driver.Quit();
    }
}