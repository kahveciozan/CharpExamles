using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExamples.Extensions
{
    // This class has a extentions method for "string"
    // We do not hace access to the STRING CLASS we are extending it.
    public static class StringExtension
    {
        public static int FindWordIndex(this string sentence, string wordToFind)
        {
            int indexFound = sentence.IndexOf(wordToFind);
            return indexFound;
        }

    }   
}
