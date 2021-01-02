using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;
using EmailExtractor;

namespace EmailExtractorTests
{
    [TestClass]
    public class SbExtensionsTest
    {
        StringBuilder testSb;
        [TestInitialize]
        public void Init()
        {
            testSb = new();
        }
        [TestMethod]
        public void ReplaceSpecialBySpaceTest()
        {
            //check empty builder
            testSb.ReplaceSpecialBySpace();
            Assert.AreEqual(testSb.ToString(), string.Empty);

            //check method without quote support
            testSb.Append("\"la%^:this is quote!:\"la:(la")
                .ReplaceSpecialBySpace(true);
            Assert.AreEqual(testSb.ToString(), " la   this is quote   la  la");
            testSb.Clear();

            //check method with quote support
            testSb.Append("\"la%^:this is quote!:\"la:(la")
                .ReplaceSpecialBySpace(false);
            Assert.AreEqual(testSb.ToString(), "\"la%^:this is quote!:\"la  la");

            testSb.Clear();

            //quote in begin and end
            testSb.Append("\"::!$# abs\" tex:t where@@need replace^sym(())ls\"qu@#ote in*( end\"")
                .ReplaceSpecialBySpace();
            Assert.AreEqual(testSb.ToString(), "\"::!$# abs\" tex:t where@@need replace^sym(())ls\"qu@#ote in*( end\"");

            testSb.Clear();

            //ignore semicolumn and et
            testSb.Append("@@@ ;;; ::*($# @ dfoos ((,,,.. ;; @ a")
                .ReplaceSpecialBySpace(exclude: "@;");
            Assert.AreEqual(testSb.ToString(), "@@@ ;;;        @ dfoos         ;; @ a");
        }
        [TestMethod]
        public void ReplaceWhiteSpaceAroundEtTest()
        {
            //one @ in string
            testSb.Append("value: lol \t\t\t@  \n\n \t  kek .cheburek.ru.com.info ")
                .ReplaceWhiteSpaceAroundAt();
            Assert.AreEqual(testSb.ToString(), "value: lol@kek .cheburek.ru.com.info ");

            testSb.Clear();

            //many @ in string 
            testSb.Append("@ instart \n\t\n @ message.com@git not \t\t only@ \n\t your @@@@ in end of @\t\n")
                .ReplaceWhiteSpaceAroundAt();
            Assert.AreEqual(testSb.ToString(), "@instart@message.com@git not \t\t only@your@@@@in end of@");
        }
        [TestMethod]
        public void RemoveDuplicateAtTest()
        {
            testSb.Append("")
               .RemoveDuplicateAt();
            Assert.AreEqual(string.Empty, testSb.ToString());

            testSb.Append("ococ   \t@.com")
              .RemoveDuplicateAt();
            Assert.AreEqual("ococ   \t@.com", testSb.ToString());

            testSb.Clear();

            testSb.Append("multi@@@ @.com.ru")
            .RemoveDuplicateAt();
            Assert.AreEqual("multi@ @.com.ru", testSb.ToString());
        }
    }
}
