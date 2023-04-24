using CSharpExamples;

class Program
{


    static void Main(string[] args)
    {
        // declare variables
        Console.WriteLine(" --- Declaring Variables ---");
        int age = 25;
        int x = 17, y = 18, z = 19;
        string fullName = "Michael Jordan";
        double weight = 300D, weight2 = 250d;               // We can write lower case or upper case.
        long distance = 10L;
        char gender = 'F';
        float playerDistanceAtZ = 11.565433f;
        decimal playerWorth = 1000.000M;
        GenderType genderType = GenderType.Male;

        Console.WriteLine($"Player's Age: {age}");
        Console.WriteLine($"X: {x} y: {y} z: {z}");

        // single dimensional arrays
        Console.WriteLine(" --- Declaring Singe Arrays ---");
        int[] ages = new int[3];
        ages[0] = 12;
        ages[1] = 14;
        ages[2] = 16;
        Console.WriteLine($"{ages[0]} {ages[1]} {ages[2]}");

        int[] birthDates = new int[] { 1990, 1991, 1992, 1993, 1994, 1995, 1996, 1997, 1998 };
        Console.WriteLine($"{birthDates[0]} {birthDates[1]} {birthDates[2]} {birthDates[8]}");


        // double dimensional arrays [rows, colums]
        Console.WriteLine(" --- Declaring Double Arrays ---");
        string[,] people = new string[,] {
                                            {"Michael","Joe","Amanda" },
                                            {"Stave","Vanesa","Elon" },
                                            {"Messi","Ronaldo","Salah" }
                                         };
        Console.WriteLine($"{people[2, 2]}");
        Console.WriteLine($"{people[0, 2]}");
        Console.WriteLine($"{people[0, 0]}");


        //Reference vs Value Types
        Console.WriteLine(" --- Reference vs Value Types ---");
        int secondPlayerAge = 55;

        Console.WriteLine($"Before V -> SecondPlayerAge: {secondPlayerAge}");
        ValueTypeTesting(secondPlayerAge);
        Console.WriteLine($"After V-> SecondPlayerAge: {secondPlayerAge}");

        int[] secondSetOfAges = new int[] { 12, 13, 14 };
        Console.WriteLine($"Before R-> SecondPlayerAge: {secondSetOfAges[0]}");
        ReferenceTypeTesting(secondSetOfAges);
        Console.WriteLine($"After R-> SecondPlayerAge: {secondSetOfAges[0]}");


        // Operators Class
        Operators o1 = new Operators();
        ConsoleClass c1 = new ConsoleClass();

    }

    public static void ValueTypeTesting(int newAge)                    // integer are value type
    {
        newAge = 89;
        Console.WriteLine(newAge);

    }
    public static void ReferenceTypeTesting(int[] ages)                 // arrays are reference types
    {
        if (ages.Length > 0)
        {
            ages[0] = 89;
        }

    }

    enum GenderType : uint
    {
        Male = 0,
        Famale = 1,
        NotProvided = 2
    }
}
