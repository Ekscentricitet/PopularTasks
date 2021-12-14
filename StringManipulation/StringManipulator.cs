using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    public static class StringManipulator
    {
        /// <summary>
        /// Reverses the words order in the passed string.
        /// </summary>
        /// <param name="separator">The separator that is used to distinguish one word from another.</param>
        /// <returns>A deep copy of the passed string with reversed word order.</returns>
        public static string ReverseSentence(this string sentenceToReverse, char separator = ' ')
        {
            var reverser = new SentenceReverser();
            return reverser.ReverseSentence(sentenceToReverse, separator);
        }

        /// <summary>
        /// Reverses the words order in the passed string.
        /// </summary>
        /// <param name="separator">The separator that is used to distinguish one word from another.</param>
        /// <returns>A deep copy of the passed string with reversed word order.</returns>
        public static char[] ReverseSentence(this char[] sentenceToReverse, char separator = ' ')
        {
            var reverser = new SentenceReverser();
            return reverser.ReverseSentence(sentenceToReverse, separator);
        }
    }
}
