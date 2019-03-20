using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _5kyu
{
    [TestClass]
    public class SimplePigLatinTest
    {
        [TestMethod]
        [DataRow("Pig latin is cool", "igPay atinlay siay oolcay")]
        [DataRow("This is my string", "hisTay siay ymay tringsay")]
        public void PigIt_should_success(string input, string expected)
        {
            Assert.AreEqual(expected, SimplePigLatin.PigIt(input));
        }
    }
}
