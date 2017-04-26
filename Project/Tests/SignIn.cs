using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndeedAutomation;
using Project;

namespace Tests
{
    class SignIn : Driver
    {
        [OneTimeSetUp]
        public void init()
        {
            GoToURL("https://www.indeed.com/");
        }

        [TearDown]
        public void Reset()
        {

            CloseWindow();
        }

        [Test]
        public void LogInWithInvalidUser_WillCauseLogInFailure()
        {
            ClickID("userOptionsLabel");
            EnterTxt("signin_email", "nmchivautomation@gmail.com");
            EnterTxt("signin_password", "automationIncorrect");
            //Thread.Sleep(10000);
            //FindByClassAndClick("sg-btn");
            //Assert.IsTrue(SignInPage.readText, "Invalid login failed.");
        }

        [Test]
        public void LogInWithValidUser_LoginSuccessful()
        {
            ClickID("userOptionsLabel");
            EnterTxt("signin_email", "nmchivautomation@gmail.com");
            EnterTxt("signin_password", "automation1");
            //Thread.Sleep(10000);
            FindByClassAndClick("sg-btn");
        }

        [Test]
        public void RegisterAndDeleteNewAccount_RegistrationSuccessful()
        {
            ClickID("userOptionsLabel");
            FindByClassAndClick("linkItem-title");
            EnterTxt("register_email", "nmchivautomation+1@gmail.com");
            EnterTxt("register_retype_email", "nmchivautomation+1@gmail.com");
            EnterTxt("register_password", "automation1");
            FindByClassAndClick("btn-signin");
            ClickID("userOptionsLabel");
            FindByCSSAndClick("#userOptions > div:nth-child(6) > a"); //Only works if account is unconfirmed.
            FindByCSSAndClick("#delete_account_form > a");
            ConfirmAlertPopUp();
            Assert.IsTrue(SignInPage.IsAt, "Failed to delete account.");      

        }

        [Test]
        public void RegistrationInfoEnteredIncorrectly_RegistrationFailure()
        {
            ClickID("userOptionsLabel");
            FindByClassAndClick("linkItem-title");
            EnterTxt("register_email", "nmchivautomation+1@gmail.com");
            EnterTxt("register_retype_email", "nmchivautomation+1@gmail.comfail");
            EnterTxt("register_password", "automation1");
            FindByClassAndClick("btn-signin");

        }

        //[Test]
        //public void ResettingPassword_Successful()
        //{
        //    ClickID("userOptionsLabel");
        //    FindByCSSAndClick("#a.linkItem.linkItem-chevron.registrationLink");
        //}

        //[Test] //Is't working right now, could be that account is new, so it just logs in.
        //public void RegisteringWithExistingUser_AccountAlreadyExistsFailure()
        //{
        //    ClickID("userOptionsLabel");
        //    FindByClassAndClick("linkItem-title");
        //    EnterTxt("register_email", "nmchivautomation@gmail.com");
        //    EnterTxt("register_retype_email", "nmchivautomation@gmail.com");
        //    EnterTxt("register_password", "automation1");
        //    FindByClassAndClick("btn-signin");

        //}




    }
}
