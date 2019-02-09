using Microsoft.VisualStudio.TestTools.UnitTesting;
using _6kyu;

namespace _6kyuTests.ReverseOrRotate
{
    [TestClass]
    public class RevrotTest
    {
        private string _anyStr ;
        private int _size ;


        [TestMethod]
        public void size_equal_zero_should_return_empty()
        {
            var anyStr = "1234";

            GivenSizeAndStr(anyStr , 0);

            ReturnShouldEqual(string.Empty);
        }

        [TestMethod]
        public void size_greater_than_length_should_return_empty()
        {
            var anyStr = "1234";

            GivenSizeAndStr(anyStr, anyStr.Length+1);

            ReturnShouldEqual(string.Empty);
        }

        [TestMethod]
        public void should_return_coorect_string()
        {
            var anyStr = "733049910872815764";
            var size = 5;          
            GivenSizeAndStr(anyStr, size);

            ReturnShouldEqual("330479108928157");
        }

        private void GivenSizeAndStr(string anyStr, int size)
        {
            _size = size;
            _anyStr = anyStr;
        }

        private void ReturnShouldEqual(string expected)
        {
            Assert.AreEqual(expected, Revrot.RevRot(_anyStr, _size));
        }
    }
}
