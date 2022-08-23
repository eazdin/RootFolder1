using Microsoft.VisualStudio.TestTools.UnitTesting;
using PageClassLib;
using RestSharp;
using System.Diagnostics;
using Newtonsoft.Json;

namespace PageClassTest
{
    [TestClass]
    public class UnitTest1
    { 
    private TestContext testContextInstance;
    public TestContext TestContext
    {
    get { return testContextInstance; }
    set { testContextInstance = value; }
     }
        [TestMethod]
        public void TestMethod1()
        {
        string r = APIClass1.GetMethod();
        TestContext.WriteLine("Get Method Output \n\n\n" +r);
        Assert.AreEqual("hi","hello","String not matched");
        }

         [TestMethod]
        public void TestMethod2()
        {
        string r = APIClass1.PostMethod();
        TestContext.WriteLine("Get Method Output \n\n\n" +r);
        Assert.AreEqual("hi","hi","String not matched");
        }

        [TestMethod]
        public void TestMethod3()
        {
        string r = APIClass1.PutMethod();
        TestContext.WriteLine("Get Method Output \n\n\n" +r);
        Assert.AreEqual("hi","hello","String not matched");
        }
    }
}
