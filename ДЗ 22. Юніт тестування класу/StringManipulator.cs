
namespace ДЗ_22._Юніт_тестування_класу
{
    public class StringManipulator
    {
        public string ConcatenateStrings(string str1, string str2)
        {
            return str1 + str2;
        }

        public int GetStringLength(string str)
        {
            return str.Length;
        }

        public string ReverseString(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public bool IsPalindrome(string str)
        {
            string reversedStr = ReverseString(str);
            return str.Equals(reversedStr, StringComparison.OrdinalIgnoreCase);
        }
    }
}
