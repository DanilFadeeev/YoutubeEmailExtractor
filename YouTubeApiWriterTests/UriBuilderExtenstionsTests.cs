using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ApiWrapper.Utils;

namespace YouTubeApiWriterTests
{
    [TestClass]
    public class UriBuilderExtenstionsTests
    {
        class nullReturner : object { public override string ToString() { return null; } }
        class emptyStringReturner : object { public override string ToString() { return string.Empty; } }
        UriBuilder testBuilder;
        static nullReturner nullFromToString;
        static emptyStringReturner emptyStringFromTostring;
        [ClassInitialize]
        public static void InitOnlyOne(TestContext context)
        {
            nullFromToString = new nullReturner();
            emptyStringFromTostring = new emptyStringReturner();
        }
        [TestInitialize]
        public void InitForEveryTest()
        {
            testBuilder = new("https://google.com");
        }
        [TestMethod]
        public void AddQueryParamParamNullSending()
        {
            Assert.ThrowsException<ArgumentException>(() =>
            testBuilder.AddQueryParam("name", null));

            Assert.ThrowsException<ArgumentException>(() =>
            testBuilder.AddQueryParam("name", ""));

            Assert.ThrowsException<ArgumentException>(() =>
            testBuilder.AddQueryParam("", "lol"));

            Assert.ThrowsException<ArgumentException>(() =>
            testBuilder.AddQueryParam("name", nullFromToString));

            Assert.ThrowsException<ArgumentException>(() =>
            testBuilder.AddQueryParam(null, nullFromToString));

            Assert.ThrowsException<ArgumentException>(() =>
            testBuilder.AddQueryParam("name", emptyStringFromTostring));

            Assert.ThrowsException<ArgumentException>(() =>
            testBuilder.AddQueryParam(null, emptyStringFromTostring));
        }
        [TestMethod]
        public void CheckCorrectQueryParamsAdding()
        {
            string firstName = "firstParam", secondName = "secondParam";
            object firstValue = "firstValue", secondValue = 12345;

            Assert.AreEqual(testBuilder.Query, string.Empty);

            testBuilder.AddQueryParam(firstName, firstValue);
            Assert.AreEqual(testBuilder.Query, $"?{firstName}={firstValue}");

            testBuilder.AddQueryParam(secondName, secondValue);
            Assert.AreEqual(testBuilder.Query, $"?{firstName}={firstValue}&{secondName}={secondValue}");
        }
        [TestMethod]
        public void CheckClearMethod()
        {

            string firstName = "firstParam", firstValue = "firstValue";

            testBuilder.AddQueryParam(firstName, firstValue);
            Assert.AreEqual(testBuilder.Query, $"?{firstName}={firstValue}");

            testBuilder.ClearQuery();
            Assert.AreEqual(testBuilder.Query, string.Empty);

            testBuilder.AddQueryParam("test", 1431).ClearQuery()
                .AddQueryParam("test.test", "test").ClearQuery();

            Assert.AreEqual(testBuilder.Query, string.Empty);
        }
        [TestMethod]
        public void AddKeyMethodCheck()
        {
            Assert.AreEqual(string.Empty, testBuilder.Query);

            testBuilder.AddKey();

            Assert.IsTrue(testBuilder.Query.Contains("key="));
            Assert.IsTrue(testBuilder.Query.Length == 44);
        }
    }
}
