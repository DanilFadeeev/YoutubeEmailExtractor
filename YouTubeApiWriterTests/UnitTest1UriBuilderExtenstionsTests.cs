using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace YouTubeApiWriterTests
{
    [TestClass]
    public class UnitTest1UriBuilderExtenstionsTests
    {
        [ClassInitialize()]
        public static void ClassInit(TestContext context) 
        {
            UriBuilder builder = new("a");
        }
        [TestMethod]
        public void ParamNullSending()
        {

        }
    }
}
