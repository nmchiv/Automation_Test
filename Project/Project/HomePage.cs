using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IndeedAutomation 
{
    class HomePage : Program
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
        public void UserCanSearchAJob()
            {
            EnterTxt("what", "software tester");
            ClearTxt("where");
            EnterTxt("where", "salt lake city, ut");
            ClickID("fj");
            ClickID("prime-popover-close-button");
            Assert.IsTrue(JobsPage.IsAt, "Failed to navigate to the search page.");
        }

        [Test]
        public void FindJobsLink()
        {
            ClickID("jobsLink");

        }

    [Test]
        public void FindResumesLink()
        {
            ClickID("rezLink");
        }

        [Test]
        public void FindEmployers()
        {
            ClickID("empLink");
        }

        [Test]  
        public void UploadResume()
        {
            
        }

        [Test]
        public void LogIn()
        {
            ClickID("userOptionsLabel");
            EnterTxt("signin_email", "nmchivautomation@gmail.com");
            EnterTxt("signin_password", "automation1");
            Thread.Sleep(10000);
            FindByClassAndClick("sg-btn");

        }

        [Test]  
        public void TestToTest()
        {

        }
        
    }
}
