using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project 
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
        public void SearchAJob()
            {
            EnterTxt("what", "software tester");
            ClearTxt("where");
            EnterTxt("where", "salt lake city, ut");
            ClickID("fj");
        }

        [Test]
        public void FindJobsLink()
        {
            ClickID("jobsLink");
            //    Assert.IsTrue("https://www.indeed.com/?hl=en")

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
        
    }
}
