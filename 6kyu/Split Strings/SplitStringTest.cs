using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _6kyu.Split_Strings
{
    [TestClass]
    public class SplitStringTest
    {
        [TestMethod]
        public void odd_length_should_success()
        {
            var expected = new string[] { "ab", "c_" };
            var actual = SplitString.Solution("abc");
            var condition = expected.Equals(actual);
            CollectionAssert.AreEqual(expected,actual);

        }

        [TestMethod]
        public void even_length_should_success()
        {
            CollectionAssert.AreEqual(new string[] { "ab", "cd", "ef" }, SplitString.Solution("abcdef"));
        }
    }
}
