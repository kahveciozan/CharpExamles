using CSharpExamples.Extensions;
using CSharpExamples.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExamples
{
    internal class ExtensionMethods
    {
        public ExtensionMethods()
        {
            Console.WriteLine(" ### C# Extension Features ###");
            
            // Usege of extended string class
            var wordToFind = "coding";
            int index =  "Hello my friend I love coding very much".FindWordIndex(wordToFind);
            Console.WriteLine($"I found word: {wordToFind} at index {index}");

            // Usege of extended XRRig
            XRRig picoXRRig = new XRRig("room", 0);
            Console.WriteLine($"\nWhat is my PICO space {picoXRRig.FindXRRigSpace()}");

            XRRig questProXRRig = new XRRig("stationary", 5);
            Console.WriteLine($"\nWhat is my Meta Quest Pro space {questProXRRig.FindXRRigSpace()}");

        }
    }
}


// Extension can come in handy when working with COLLIDERS & looking for NAMES 
