namespace CSharpExamples.OOP
{
    // Classes, Constructors, Instances, Methods, Properties, Access Modifier & Compositon
    internal class ObjectOrientedPrograming
    {
        public ObjectOrientedPrograming()
        {
            Console.WriteLine(" -- OOP - Object Oriented Programing -- ");

            int id = 1;
            string email = "michaelJordan@gmail.com";
            string firstName = "Micheal";
            string lastName = "Jordan";

            // Creating 1st Player
            Player player1 = new Player(id, email, firstName, lastName);

            Console.WriteLine($"Player Full Name: {player1.FullName}");

            player1.FindEnemiesInCloseProximity();
            string firstNameWithFirstLast = player1.FirstNameWithFirstLastCharacter;

            // Creating 2nd Player
            Player player2 = new Player(++id, email + "_2");

            // Creating 3rd Player
            Player player3 = new Player(++id, email + "_3", "Stave", "Jobs");
            player3.MovePlayer(new Vector3(3f, 5f, 10f));
            Console.WriteLine($"Player 3 Id: {player3.UserId}");

        }

    }
}

// Object -> Player
// User Id (User Object)
// Email (string)
// Full Name (string)
// First Nane (string)
// Last Name (string)
// Move(Vector3) -> Method
// Rotate(Vector3) -> Methıd
// User (User Object)

// public
// private
// protected
