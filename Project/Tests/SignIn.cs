using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndeedAutomation;

namespace Tests
{
    class SignIn : Driver
    {
        [OneTimeSetUp]
        public void init()
        {
            GoToURL("https://www.indeed.com/");
        }

        //[TearDown]
        //public void Reset()
        //{

        //    CloseWindow();
        //}

        [Test]
        public void LogInWithInvalidUser_WillCauseLogInFailure()
        {
            ClickID("userOptionsLabel");
            EnterTxt("signin_email", "nmchivautomation@gmail.com");
            EnterTxt("signin_password", "automationIncorrect");
            //Thread.Sleep(10000);
            FindByClassAndClick("sg-btn");
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

        public void RegisterNewAccount_Successful()
        {

        }



    }
}
