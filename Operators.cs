namespace CSharpExamples
{
    public class Operators
    {
        public Operators()
        {
            Console.WriteLine("\n\n--- C# Operators ---");
            Arithmetic();
            Comparison();
        }

        // + = - / % ++ --
        private void Arithmetic()
        {
            Console.WriteLine("\n- Arithmetic Operators");
            int x = 12;
            x += 12;
            Console.WriteLine($"x: {x}");
            int y = x;
            y -= 12;
            Console.WriteLine($"y: {y}");


            int i = 0;
            Console.WriteLine($"i: {i++}");

            int j = 0;
            Console.WriteLine($"j: {++j}");
        }

        // == != > < >= <= ?
        private void Comparison()
        {
            Console.WriteLine("\n- Comprasion Operators");
            var tempVar = 2;
            int c = (2 == tempVar) ? 20 : 10;
            Console.WriteLine($"c: {c++}");

            int d = !(1 == tempVar || 1 == 1) ? 20 : 10;
            Console.WriteLine($"d: {d++}");

            int? k = null;
            int l = k ?? -1;               // If k is null then assing -1 to l
            Console.WriteLine($"l: {l}");  // output: -1
        }

    }
}