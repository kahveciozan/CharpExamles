using Microsoft.VisualBasic.FileIO;
using System.Globalization;

namespace CSharpExamples
{
    public class Strings
    {
        public Strings() 
        {
            // String joining
            string x = "Hello";
            string y = "World!";
            string helloWorld = x + " " + y;
            string helloWolrd2 = string.Concat(x, " ", y + " 2");

            // String interpolation
            string helloWolrd3 = $"{x} {y} from mars";

            // String replecement
            string planet = "jupiter"; ;
            string star = "     the moon    ";
            string sentence = $"I would love to see {planet}";
            Console.WriteLine("Sentence: "+ sentence);
            string modifiedSentence = sentence.Replace(planet, star);
            Console.WriteLine("Modified Sentecte: "+ modifiedSentence);

            // String trims 
            star = star.Trim();
            string modifiedSentence2 = sentence.Replace(planet, star);
            Console.WriteLine("Modified sentence 2: " +modifiedSentence2);

            // String chars
            char grabOneLetter = planet[1];

            int lengthOfPlanetWord = planet.Length; ;

            //Console.ReadLine();

            // Parsing And Casting Features
            Console.WriteLine("\n--- Parsing And Casting Features ---");
            // Parsing
            string ageStr = "36";
            string addedAgeStr = "10";

            int totalAge = int.Parse(ageStr) + int.Parse(addedAgeStr);

            string weightStr = "203,34";                                     // !!! I did not use '.' because of CALTURE issue
            string addedWeightStr = "12,26";                                 // If your PC has different CALURE. Use '.' instead od ','

            double totalWeight = double.Parse(weightStr) + double.Parse(addedWeightStr);

            Console.WriteLine($"New Age: {totalAge}");
            Console.WriteLine($"New Weight: {totalWeight}");

            // How to fix issues with inputs
            string weightStr2 = "200,345";
            bool didThisWork =  double.TryParse(weightStr2, out double newWeight);

            string moneyEarnedStr = "1000,53";
            bool didThisWorkADecimal = decimal.TryParse(moneyEarnedStr,
                NumberStyles.AllowCurrencySymbol | NumberStyles.AllowDecimalPoint,
                NumberFormatInfo.CurrentInfo, 
                out decimal moneyEarnedAsDecimal);

            Console.WriteLine($"Money Earned As Decimal: {moneyEarnedAsDecimal}");

            decimal roundUp = Math.Round(moneyEarnedAsDecimal, 0);
            //decimal roundMid = Math.Round(moneyEarnedAsDecimal, 0, MidpointRounding.ToZero);
            Console.WriteLine($"Rounded Up Money: {roundUp}");

            // Casting 
            int moneyEarnedAsInt = (int)moneyEarnedAsDecimal;
            float moneyEarnedAsFloat = (float)moneyEarnedAsDecimal;

            //Console.ReadLine();
        }



    }
}
