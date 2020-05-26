using GiftreteWithBackground.PageObjects;
using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace GiftreteWithBackground.StepDefinitions
{
    [Binding]
    public class LoginWithBackgroundSteps
    {
        GiftreteBackgroundPage giftreteBackgroundPage;

        public LoginWithBackgroundSteps()
        {
            giftreteBackgroundPage = new GiftreteBackgroundPage();

        }

        [Given(@"I navigate to the website""(.*)""")]
        public void GivenINavigateToTheWebsite(string url)
        {
            giftreteBackgroundPage.Navigate(url);
        }


        [When(@"I click on Sign in")]
        public void WhenIClickOnSignIn()
        {
            giftreteBackgroundPage.SignIn();
        }
        
        [When(@"I enter my email ""(.*)""")]
        public void WhenIEnterMyEmail(string mail)
        {
            giftreteBackgroundPage.EmailAddress(mail);
        }
        
        [When(@"I enter my password ""(.*)""")]
        public void WhenIEnterMyPassword(string pword)
        {
            giftreteBackgroundPage.Password(pword);
        }

        [When(@"I click on Sign In bottun")]
        public void WhenIClickOnSignInBottun()
        {
            giftreteBackgroundPage.SignInBottun();
        }

        [When(@"I click on prifile image")]
        public void WhenIClickOnPrifileImage()
        {
            Thread.Sleep(1000);
            giftreteBackgroundPage.ProfileImage();
        }

        [When(@"I click on Logout")]
        public void WhenIClickOnLogout()
        {
            giftreteBackgroundPage.SignOut();
        }

        [Then(@"I should see message ""(.*)""")]
        public void ThenIShouldSeeMessage(string p0)
        {
            giftreteBackgroundPage.CheckSuccessMsgIsDisplayed();
        }


        [When(@"I click on community")]
        public void WhenIClickOnCommunity()
        {
            //Thread.Sleep(1000);
            giftreteBackgroundPage.Community();
        }

        [When(@"I click on profile name bottun")]
        public void WhenIClickOnProfileNameBottun()
        {
            giftreteBackgroundPage.ProfileNameBiottun();
        }

        [When(@"I click on logout bottun")]
        public void WhenIClickOnLogoutBottun()
        {
            giftreteBackgroundPage.SignOut();
        }


        [Then(@"I should see the message ""(.*)""")]
        public void ThenIShouldSeeTheMessage(string msg)
        {
            giftreteBackgroundPage.CheckSuccessMsgIsDisplayed();
        }

        [When(@"I click on Search")]
        public void WhenIClickOnSearch()
        {
            //Thread.Sleep(1000);
            giftreteBackgroundPage.Search();
        }

        [When(@"I click on profile bottun")]
        public void WhenIClickOnProfileBottun()
        {
            giftreteBackgroundPage.ProfileBottun();
        }

        [When(@"I click on Log bottun")]
        public void WhenIClickOnLogBottun()
        {
            giftreteBackgroundPage.SignOut();
        }

        [Then(@"message ""(.*)""")]
        public void ThenMessage(string p0)
        {
            //Thread.Sleep(1000);
            giftreteBackgroundPage.CheckSuccessMsgIsDisplayed();
        }
    }
}
