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

            Console.ReadLine();
        }



    }
}
