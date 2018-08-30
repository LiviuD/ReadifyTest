using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReadifyTestServices
{
    public class ReverseWordService : IReverseWordService
    {
        /// <summary>
        /// Reverses the sentence.
        /// </summary>
        /// <param name="sentence">The sentence.</param>
        /// <returns>The sentenced with reverse words</returns>
        public string ReverseSentence(string sentence)
        {
            return sentence
                 .Split(' ')
                 .ToList()
                 .Select(w => ReverseWord(w))
                 .Aggregate((w1, w2) => $"{w1} {w2}");
        }

        private string ReverseWord(string word)
        {
            var sb = new StringBuilder(word);
            var i = 0;
            while (i < sb.Length / 2)
            {
                if (sb[i] != sb[sb.Length - i - 1])
                {
                    var temp = sb[i];
                    sb[i] = sb[sb.Length - i - 1];
                    sb[sb.Length - i - 1] = temp;
                }
                i++;
            }
            return sb.ToString();
        }
    }
}
