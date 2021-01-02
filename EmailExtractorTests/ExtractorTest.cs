using EmailExtractor;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailExtractorTests
{
    [TestClass]
    public class ExtractorTest
    {
        Extractor extractor;
        [TestInitialize]
        public void Init() { extractor = new(); }
        [TestMethod]
        public void NoEmailsExtract()
        {
            string message = "hello, i am a string without emails";
            var result = extractor.GetEmailsFromMessage(message);
            Assert.AreEqual(0, result.Count);

            message = string.Empty;
            result = extractor.GetEmailsFromMessage(message);
            Assert.AreEqual(0, result.Count);

            message = null;
            result = extractor.GetEmailsFromMessage(message);
            Assert.AreEqual(0, result.Count);

             message = "Iam@notemail";
             result = extractor.GetEmailsFromMessage(message);
            Assert.AreEqual(0, result.Count);

            message = "@mail.notmail";
            result = extractor.GetEmailsFromMessage(message);
            Assert.AreEqual(0, result.Count);

            message = " \t\t  @t.email";
            result = extractor.GetEmailsFromMessage(message);
            Assert.AreEqual(0, result.Count);
        }
        [TestMethod]
        public void InvalidEMails()
        {

            var message = "myEmail:il@mail.ru";
            var result = extractor.GetEmailsFromMessage(message);
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("il@mail.ru", result[0]);

            message = "multiplyAt@@mail.com";
            result = extractor.GetEmailsFromMessage(message);
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("multiplyAt@mail.com", result[0]);
        }
        [TestMethod]
        public void OneValidEmail()
        {
            var message = "_MaksimAnatolevich44@mail.ru";
            var result = extractor.GetEmailsFromMessage(message);
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(message, result[0]);

            message = "\"actualemail!#$%^&*::;withSpecials\" @mail.info.ru.com";
            result = extractor.GetEmailsFromMessage(message);
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(message.Replace(" ",""), result[0]);
        }
        [TestMethod]
        public void ManyValidEmails()
        {
            var message = "igorMann@ mail.ru second email: igorok@bk.com";
            var result = extractor.GetEmailsFromMessage(message);
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual("igorMann@mail.ru", result[0]);
            Assert.AreEqual("igorok@bk.com", result[1]);

            message = "shakhmardan28@gmail.com участвую Искренне надеюсь выиграть Apple Watch. Чудеса случаются) shakhmardan28@gmail.com";
            result = extractor.GetEmailsFromMessage(message);
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("shakhmardan28@gmail.com", result[0]);

            message = "shakhmardan28@gmail.com участвую Искренне vselenstiyNagibator3000@mpei.ru надеюсь выиграть Apple Watch. Чудеса случаются) shakhmardan28@gmail.com";
            result = extractor.GetEmailsFromMessage(message);
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual("shakhmardan28@gmail.com", result[0]);
            Assert.AreEqual("vselenstiyNagibator3000@mpei.ru", result[1]);

            message = "shakhmardan28@gmail.com участвую Искренне \"v;;;selenst\"iyNagibator3000@mpei.ru";
            result = extractor.GetEmailsFromMessage(message);
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual("shakhmardan28@gmail.com", result[0]);
            Assert.AreEqual("iyNagibator3000@mpei.ru", result[1]);
        }
        [TestMethod]
        public void ManyInvalidEmails()
        {
            var message = "asdoijf  :igorMann@mail.ru,,,,igorok@bk.com";
            var result = extractor.GetEmailsFromMessage(message);
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual("igorMann@mail.ru", result[0]);
            Assert.AreEqual("igorok@bk.com", result[1]);
        }
    }
}
