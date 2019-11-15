using System;

namespace StringReverse.lib
{
    public class StringUtility
    {
        public string Reverse(string str)
        {
            char[] inputArray = str.ToCharArray();
            for (int i = 0, j = inputArray.Length - 1; i < inputArray.Length / 2; i++, j--)
            {
                char temp = inputArray[i];
                inputArray[i] = inputArray[j];
                inputArray[j] = temp;
            }
            return new string(inputArray);
        }
    }
}