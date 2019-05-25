using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _6kyu.Split_Strings
{
    [TestClass]
    public class TowerBuilderTest
    {
        [TestMethod]
        public void BasicTests()
        {
            Assert.AreEqual(string.Join(",", new[] { "*" }), string.Join(",", TowerBuilder.Build(1)));
            Assert.AreEqual(string.Join(",", new[] { " * ", "***" }), string.Join(",", TowerBuilder.Build(2)));
            Assert.AreEqual(string.Join(",", new[] { "  *  ", " *** ", "*****" }), string.Join(",", TowerBuilder.Build(3)));
        }


    }
}
