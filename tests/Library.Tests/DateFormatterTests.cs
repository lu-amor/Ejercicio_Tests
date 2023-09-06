using NUnit.Framework;
namespace TestDateFormat
{
    public class DateFormatterTests
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestCorrectDate()
        {
            const string expected = "1997-11-10";
            const string testDate = "10/11/1997";
            Assert.That(DateFormatter.ChangeFormat(testDate), Is.EqualTo(expected));
        }

        [Test]
        public void TestIncorrectDate()
        {
            const string testDate2 = "";
            bool result = DateFormatter.CheckFormat(testDate2);
            Assert.False(result);
        }

        [Test]
        public void TestNullDate()
        {
            const string testDate3 = "";
            bool result = DateFormatter.CheckFormat(testDate3);
            Assert.False(result);
        }
    }
}