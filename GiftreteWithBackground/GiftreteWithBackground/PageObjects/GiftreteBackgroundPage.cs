using GiftreteWithBackground.Hooks;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace GiftreteWithBackground.PageObjects
{
    class GiftreteBackgroundPage
    {

        IWebDriver driver;

        public GiftreteBackgroundPage()
        {

            driver = Hook.driver;

        }

        IWebElement signIn => driver.FindElement(By.XPath("(//a[@href='/account/authentication?ref=1'])[1]"));

        IWebElement emailAddress => driver.FindElement(By.XPath("(//input[@type='email'])[1]"));

        IWebElement password => driver.FindElement(By.XPath("(//input[@type='password'])[1]"));

        IWebElement signInBottun => driver.FindElement(By.XPath("(//input[@type='submit'])[1]"));

        IWebElement profileImage => driver.FindElement(By.XPath("(//div[@class='ml--10 brd-rad brd-line4'])[1]"));

        IWebElement signOut => driver.FindElement(By.XPath("/html/body/div[1]/header[1]/div/div[2]/div/div[3]/ul/li[4]/ul/li[3]/a"));

        IWebElement successMsg => driver.FindElement(By.XPath("//a[@href='/account/forgot_password']"));

        IWebElement community => driver.FindElement(By.XPath("(//span[@class='mm-text'])[1]"));

        IWebElement profileNameBottun => driver.FindElement(By.XPath("(//div[@class='ml--10 brd-rad brd-line4'])[1]"));

        IWebElement search => driver.FindElement(By.XPath("(//a[@href='/post/search'])[1]"));

        IWebElement profileBottun => driver.FindElement(By.XPath("(//div[@class='ml--10 brd-rad brd-line4'])[1]"));

        public void ProfileBottun()
        {
            profileBottun.Click();
        }

        public void Search()
        {
            search.Click();
        }

        public void ProfileNameBiottun()
        {
            profileNameBottun.Click();
        }

        public void Community()
        {
            community.Click();
        }


        public void CheckSuccessMsgIsDisplayed()
        {
            Assert.IsTrue(successMsg.Displayed);
        }

        public void SignOut()
        {
            signOut.Click();
        }

        public void ProfileImage()
        {
            profileImage.Click();
        }


        public void Navigate(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void SignIn()
        {
            signIn.Click();
        }

        public void EmailAddress(string mail)
        {
            emailAddress.SendKeys(mail);
        }

        public void Password(string pword)
        {
            password.SendKeys(pword);
        }

        public void SignInBottun()
        {
            signInBottun.Click();
        }



    }
}
