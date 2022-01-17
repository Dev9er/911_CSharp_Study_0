using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dul.Tests
{
    [TestClass]
    public class CreatorTest
    {
        [TestMethod]
        public void GetNameTest()
        {
            //[1] Arrange(����), Setup
            const string expected = "RedPlus";

            //[2] Act(����), Execute
            var actual = Creator.GetName();

            //[3] Assert(���), Verify
            Assert.AreEqual(expected, actual);
        }
    }
}

namespace Dul
{
    class CreatorOther
    {
        public static string GetName() => "RedPlus";
    }
    namespace Tests
    {
        [TestClass]
        public class CreatorTestOther
        {
            [TestMethod]
            public void GetNameTest()
            {
                //[1] Arrange(����), Setup
                const string expected = "RedPlus";

                //[2] Act(����), Execute
                var actual = CreatorOther.GetName();

                //[3] Assert(���), Verify
                Assert.AreEqual(expected, actual);
            }
        }
    }
}