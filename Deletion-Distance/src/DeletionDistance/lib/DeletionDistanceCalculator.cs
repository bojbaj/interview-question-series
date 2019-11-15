using System.Collections.Generic;

namespace DeletionDistance.lib
{
    public class DeletionDistanceCalculator
    {
        public int CalculateDistance(string word1, string word2)
        {
            // if two string are same with shouldn't do anythong and the distance is 0
            if (word1.Equals(word2))
                return 0;

            // if one of two strings has zero length
            if (word1.Length == 0 || word2.Length == 0)
                return word1.Length + word2.Length;

            // if first word length is greater than second word, we should swap words
            // because we want to find all possible sub words in smaller word.
            if (word1.Length > word2.Length)
            {
                string temp = word2;
                word2 = word1;
                word1 = temp;
            }

            List<string> subWords = findSubWords(word1);
            string match = findMatch(word2, subWords);
            if (match.Length > 0)
                return word1.Length - match.Length
                        + word2.Length - match.Length;

            return word1.Length + word2.Length;
        }
        private List<string> findSubWords(string word)
        {
            List<string> subWords = new List<string>() { };

            // we decrease length until 1 ( not zero ) because of avoid full length sub word
            // and from max length to min length sorting
            for (int length = word.Length; length > 0; length--)
            {
                for (int start = 0; start <= word.Length - length; start++)
                {
                    subWords.Add(word.Substring(start, length));
                }
            }
            return subWords;
        }
        private string findMatch(string word, List<string> dict)
        {
            for (int length = word.Length; length >= 0; length--)
            {
                for (int start = 0; start <= word.Length - length; start++)
                {
                    int findedWordIndex = dict.IndexOf(word.Substring(start, length));
                    if (findedWordIndex >= 0)
                    {
                        return dict[findedWordIndex];
                    }
                }
            }
            return string.Empty;
        }
    }
}