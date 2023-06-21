using ДЗ_22._Юніт_тестування_класу;

namespace Tests
{
    public class StringManipulatorTests
    {
        [Fact]
        public void ConcatenateStrings_ShoouldReturnCorrectString()
        {
            StringManipulator stringManipulator = new StringManipulator();

            string result1 = stringManipulator.ConcatenateStrings("1111", "2222");
            string result2 = stringManipulator.ConcatenateStrings("Hello", "World");

            Assert.Equal("11112222", result1);
            Assert.Equal("HelloWorld", result2);
        }

        [Fact]
        public void GetStringLength_ShoouldReturnCorrectValue()
        {
            StringManipulator stringManipulator = new StringManipulator();

            int result1 = stringManipulator.GetStringLength("1111");
            int result2 = stringManipulator.GetStringLength("Hello");

            Assert.Equal(4, result1);
            Assert.Equal(5, result2);
        }

        [Fact]
        public void ReverseString_ShoouldReturnCorrectString()
        {
            StringManipulator stringManipulator = new StringManipulator();

            string result1 = stringManipulator.ReverseString("1112");
            string result2 = stringManipulator.ReverseString("Hello");

            Assert.Equal("2111", result1);
            Assert.Equal("olleH", result2);
        }

        [Fact]
        public void IsPalindrome_ShoouldReturnCorrectBool()
        {
            StringManipulator stringManipulator = new StringManipulator();

            bool result1 = stringManipulator.IsPalindrome("2112");
            bool result2 = stringManipulator.IsPalindrome("Hello");

            Assert.Equal(true, result1);
            Assert.Equal(false, result2);
        }
    }
}