using CSharpExamples.Interfaces;

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
            Console.WriteLine("\n -- PLAYER 1 ");
            Player player1 = new Player(id, email, firstName, lastName);
            Console.WriteLine($"Player Full Name: {player1.FullName}");
            player1.FindEnemiesInCloseProximity();
            string firstNameWithFirstLast = player1.FirstNameWithFirstLastCharacter;
            player1.Age = 3;
            Console.WriteLine($"Plyer 1 Age: {player1.Age}");

            // Creating 2nd Player
            Console.WriteLine("\n -- PLAYER 2 ");
            Player player2 = new Player(++id, email + "_2");

            // Creating 3rd Player
            Console.WriteLine("\n -- PLAYER 3 ");
            Player player3 = new Player(++id, email + "_3", "Stave", "Jobs");
            player3.MovePlayer(new Vector3(3f, 5f, 10f));
            Console.WriteLine($"Player 3 Id: {player3.Id}");
            player3.WhoAmI();

            // Convert a child object to a parant object
            Console.WriteLine("\n -- PLAYER 4 ");
            Player player4 = new Player(++id, email + "_4", "Clara", "Toner");
            User player4UserInfo = (User) player4;
            player4UserInfo.WhoAmI();
            Console.WriteLine("\n -- USER CASTING --");
            player4.WhoAmI();

            Console.WriteLine("\n -- PLAYER 5 ");
            IPlayer player5 = new Player(++id, email + "_5");
            player5.MovePlayer(new Vector3(0, 0, 0));

            Console.WriteLine("\n -- XBOX PLAYER ");
            IPlayer xboxPlayer = new XboxPlayer();
            xboxPlayer.MovePlayer(new Vector3(4,4,4));
            MovePlayers(new IPlayer[] {xboxPlayer, player5, player4, player3,player2,player1});
        }

        static void MovePlayers(IPlayer[] players)
        {
            foreach(IPlayer p in players)
            {
                p.MovePlayer(new Vector3(3, 4, 5));
            }
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
