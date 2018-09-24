using System;
using System.Collections.Generic;
using System.IO;

namespace the_project
{
    //                                                       *************   be creative   *************
    class Program
    {
        static void Main(string[] args)
        {
            List<Card> TheDeck = new List<Card>();//all the cards will go here

            TheDeck = Blue.MakeCards("blue cards.txt", TheDeck, "Blue");
            TestDeckContens(TheDeck);
            Console.ReadKey();
        }
        static void TestDeckContens(List<Card> a)//for my testing
        {
            foreach(Card c in a)
            {
                Console.WriteLine(c.name);
                Console.WriteLine(c.points);
                foreach(int i in c.price)
                {
                Console.Write(i+" ");
                }
                Console.WriteLine();
            }
        }
        
    }
}
