using CSharpExamples.OOP;
using System;
using System.Collections.Generic;       // Collections uses this namespace
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExamples
{
    internal class Collections
    {
        public Collections()
        {
            Console.WriteLine("###  COLLECTIONS - LIST  ###");

            // Examples
            List<Player> players = new List<Player>();
            players.Add(new Player(1, "ozan.kahveci15@gmail.com"));
            players.Add(new Player(2, "ozan.kahveci15@gmail.com"));
            players.Add(new Player(3, "ozan.kahveci15@gmail.com"));
            players.Add(new Player(4, "ozan.kahveci15@gmail.com"));


            List<Player> secondSetOfPlayers = new List<Player>()
            {
                new Player(5, "micheal@kahveci.com"),
                new Player(6, "micheal@kahveci.com"),
                new Player(7, "micheal@kahveci.com")
,            };

            Console.WriteLine($"Player id: {players[3].Id} "+ $"and email:  {players[3].Email}");


            // Using Foreach
            Console.WriteLine("--  \nUsing Foreach  --");
            foreach (Player p in players)
            {
                Console.WriteLine($"Player id: {p.Id} " + $"and email:  {p.Email}");
            }



            Console.WriteLine("\n###  COLLECTIONS -   ###");


        }



    }
}



// Collections are represent group of objects.
// It provides a wat to create and manage a group to numeric types.

// 1.Dictionaries, 2.Stacks, 3.Queues
