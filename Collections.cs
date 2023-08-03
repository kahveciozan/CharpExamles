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
#region LIST
            //------ LIST -------
            Console.WriteLine("###  COLLECTIONS - LIST  ###");
  
            List<Player> players = new List<Player>();
            players.Add(new Player(1));
            players.Add(new Player(2));
            players.Add(new Player(3));
            players.Add(new Player(4, "ozan.kahveci15@gmail.com"));

            List<Player> secondSetOfPlayers = new List<Player>()
            {
                new Player(5, "micheal@kahveci.com"),
                new Player(6, "micheal@kahveci.com"),
                new Player(7, "micheal@kahveci.com")
,           };

            Console.WriteLine($"Player id: {players[3].Id} "+ $"and email:  {players[3].Email}");
            // Using Foreach
            Console.WriteLine("--  \nUsing Foreach  --");
            foreach (Player p in players)
            {
                Console.WriteLine($"Player id: {p.Id} " + $"and email:  {p.Email}");
            }
#endregion

#region DICTIONARY
            // ------ DICTIONARIES -------
            Console.WriteLine("\n###  COLLECTIONS - DICTIONARIES  ###");

            Dictionary<int, Player> keyValuePlayers = new Dictionary<int, Player>();
            keyValuePlayers.Add(1, new Player(1));
            keyValuePlayers.Add(2, new Player(2));
            keyValuePlayers.Add(3, new Player(3));
            keyValuePlayers.Add(4, new Player(4));
            keyValuePlayers.Add(5, new Player(5));
            keyValuePlayers.Add(6, new Player(6, "micheal@kahveci.com"));

            foreach (int playerId in keyValuePlayers.Keys)
            {
                var player = keyValuePlayers[playerId];

                Console.WriteLine($"[KEYS] Player id: {player.Id}" + $" and email: {player.Email}"); 
            }


            foreach(Player p in keyValuePlayers.Values)
            {
                Console.WriteLine($"[VALUES] Player id: {p.Id}" + $" and email: {p.Email}");
            }

            bool doesSixExist =  keyValuePlayers.ContainsKey(6);
            bool doesSevenExist =  keyValuePlayers.ContainsKey(7);
            Console.WriteLine($"Does player 6 exits: {doesSixExist}");
            Console.WriteLine($"Does player 7 exits: {doesSevenExist}");

            if (!keyValuePlayers.ContainsKey(7))
            {
                keyValuePlayers.Add(7, new Player(7));
            }

            doesSevenExist = keyValuePlayers.ContainsKey(7);
            Console.WriteLine($"Does player 7 exits: {doesSevenExist}");

            keyValuePlayers.Remove(6);
            foreach (Player p in keyValuePlayers.Values)
            {
                Console.WriteLine($"[MODIFIED] Player id: {p.Id}" + $" and email: {p.Email}");
            }

            #endregion

#region STACKS and QUEUES
            // ------ STACKS ------- LIFO
            Console.WriteLine("\n### STACKS ###");

            Stack<Player> playerStack = new Stack<Player>();
            playerStack.Push(new Player(1));
            playerStack.Push(new Player(2));
            playerStack.Push(new Player(3));
            playerStack.Push(new Player(4));
            playerStack.Push(new Player(5));
            foreach(Player p in playerStack)
            {
                Console.WriteLine($"[STACK] Player id: {p.Id}" + $" and email: {p.Email}");
            }


            var popPlayer = playerStack.Pop();                                                                      // Removes and returns the object at the top of the Stack 
            Console.WriteLine($"[STACK - POP] Player id: {popPlayer.Id}" + $" and email: {popPlayer.Email}");
            foreach (Player p in playerStack)
            {
                Console.WriteLine($"[STACK] Player id: {p.Id}" + $" and email: {p.Email}");                         
            }


            var peekPlayer = playerStack.Peek();                                                                    // Returns the object at the top of stack without removing it
            Console.WriteLine($"[STACK - PEEK] Player id: {peekPlayer.Id}" + $" and email: {peekPlayer.Email}");
            foreach (Player p in playerStack)
            {
                Console.WriteLine($"[STACK] Player id: {p.Id}" + $" and email: {p.Email}");
            }


            // ------ QUEUES ----------- FIFO
            Console.WriteLine("\n### QUEUES ###");

            Queue<Player> playerQueue = new Queue<Player>();
            playerQueue.Enqueue(new Player(1));
            playerQueue.Enqueue(new Player(2));
            playerQueue.Enqueue(new Player(3));
            playerQueue.Enqueue(new Player(4));
            playerQueue.Enqueue(new Player(5));

            foreach(Player p in playerQueue)
            {
                Console.WriteLine($"[QUEUE] Player id: {p.Id}" + $" and email: {p.Email}");
            }

            var dequeuePlayer = playerQueue.Dequeue();
            Console.WriteLine($"[QUEUE- DEQUEUE] Player id: {dequeuePlayer.Id}" + $" and email: {dequeuePlayer.Email}");
            foreach (Player p in playerQueue)
            { 
                Console.WriteLine($"[QUEUE] Player id: {p.Id}" + $" and email: {p.Email}");
            }

            #endregion

        }
    }
}



// Collections are represent group of objects.
// It provides a wat to create and manage a group to numeric types.

// LIST
// Dictionaries:  DICTIONARY<TKEY, TVAL>

// Stacks: LIFO (Last In First Out)
// Queues FIFO (First In First Out) 
