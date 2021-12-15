using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    public static class StringManipulator
    {
        private static SentenceReverser _sentenceReverser = new SentenceReverser();
        /// <summary>
        /// Creates a new string with reversed word order from the passed string.
        /// </summary>
        /// <param name="separator">The separator that is used to distinguish one word from another.</param>
        /// <returns>The created string.</returns>
        public static string GetReverseSentence(this string sentenceToReverse, char separator = ' ')
        {
            return _sentenceReverser.ReverseSentence(sentenceToReverse, separator);
        }

        /// <summary>
        /// Creates a new string with reversed word order from the passed char array.
        /// </summary>
        /// <param name="separator">The separator that is used to distinguish one word from another.</param>
        /// <returns>The created char array.</returns>
        public static char[] GetReverseSentence(this char[] sentenceToReverse, char separator = ' ')
        {
            return _sentenceReverser.ReverseSentence(sentenceToReverse, separator);
        }

        /// <summary>
        /// Reverses the word order in the passed char array.
        /// </summary>
        /// <param name="separator">The separator that is used to distinguish one word from another.</param>
        public static void ReverseSentence(this char[] sentenceToReverse, char separator = ' ')
        {
            var reversedSentence = _sentenceReverser.ReverseSentence(sentenceToReverse, separator);
            for (int currentIndex = 0; currentIndex < sentenceToReverse.Length; currentIndex++)
                sentenceToReverse[currentIndex] = reversedSentence[currentIndex];
        }
    }
}