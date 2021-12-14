using StringManipulation.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("UnitTests")]

namespace StringManipulation
{
    /// <summary>
    /// Contains methods to reverse the word order in a string or a char array.
    /// </summary>
    internal class SentenceReverser
    {
        /// <summary>
        /// Reverses the word order in a char array.
        /// </summary>
        /// <param name="sentenceToReverse">The char array to be reversed.</param>
        /// <param name="separator">A character that is used to separate the distinct words. Space by default.</param>
        /// <returns>A new character array that has the word order reversed.</returns>
        /// <exception cref="NullSentenceToReverseException"></exception>
        internal char[] ReverseSentence(char[] sentenceToReverse, char separator = ' ')
        {
            if (sentenceToReverse == null)
                throw new NullSentenceToReverseException();
            if (sentenceToReverse.Length == 0 || sentenceToReverse.Length == 1)
                return sentenceToReverse;

            var copy = GetCopy(sentenceToReverse);
            int lastIndex = sentenceToReverse.Length - 1;
            int lastReversedAt = 0;

            for (int currentIndex = 0; currentIndex <= lastIndex; currentIndex++)
            {
                if (copy[currentIndex] == separator)
                {
                    ReverseSpecific(copy, lastReversedAt, currentIndex - 1);
                    lastReversedAt = currentIndex + 1;
                }
            }

            ReverseSpecific(copy, lastReversedAt, lastIndex );
            ReverseSpecific(copy, 0, lastIndex);
            return copy;
        }

        /// <summary>
        /// Creates a deep copy of the passed char array.
        /// </summary>
        /// <returns>The created deep copy.</returns>
        private char[] GetCopy(char[] arrayToReverse)
        {
            var copy = new char[arrayToReverse.Length];
            for (int currentIndex = 0; currentIndex < arrayToReverse.Length; currentIndex++)
                copy[currentIndex] = arrayToReverse[currentIndex];
            return copy;
        }

        /// <summary>
        /// Reverses the word order in a string.
        /// </summary>
        /// <param name="sentenceToReverse">The string to be reversed.</param>
        /// <param name="separator">A character that is used to separate the distinct words. Space by default.</param>
        /// <returns>A new string that has the word order reversed.</returns>
        /// <exception cref="NullSentenceToReverseException"></exception>
        internal string ReverseSentence(string sentenceToReverse, char separator = ' ')
        {
            var reversedSentence = ReverseSentence(sentenceToReverse.ToCharArray(), separator);
            return new string(reversedSentence);
        }

        /// <summary>
        /// Reverses a specified part of a passed char array.
        /// </summary>
        /// <param name="leftIndex">The left index of the part that needs to be reversed.</param>
        /// <param name="rightIndex">The right index of the part that needs to be reversed.</param>
        private void ReverseSpecific(char[] arrayToReverse, int leftIndex, int rightIndex)
        {
            while(leftIndex < rightIndex)
            {
                var temp = arrayToReverse[leftIndex];
                arrayToReverse[leftIndex] = arrayToReverse[rightIndex];
                arrayToReverse[rightIndex] = temp;
                leftIndex++;
                rightIndex--;
            }
        }
    }
}