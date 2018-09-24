using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace the_project
{
    abstract class Card
    {
        public string name;
        public int points;
        public int RandomNumber;
        public int[] price = new int[3];//the amout(2) is i place holder //the index is the type and the amount is how much you need
    }


    class Blue : Card
    {
        static public List<Card> blueCards = new List<Card>();//the cards you make will go here
        public Blue(int CardNum, string[] CardAtributs)
        {
            //making the cards
            name = CardAtributs[CardNum];
            points = Convert.ToInt32(CardAtributs[CardNum + 1]);
            string[] WillBePrice = CardAtributs[CardNum + 2].Split(" ");
            for (int i=0;i<price.Length;i++)
            {
                price[i] = Convert.ToInt32(WillBePrice[i]);
            }
            blueCards.Add(this);
        }

        static public List<Card> MakeCards(string FileName, List<Card> MyList, string CardType)
        {
            FileStream file = new FileStream(FileName, FileMode.OpenOrCreate);
            file.Close();//never forget to close the stream
            string[] CardAtributs = File.ReadAllText(FileName).Split('\n');
            switch (CardType.ToLower())
            {
                case "blue":
                    for (int i = 0; i < CardAtributs.Length; i += 3)//3 reprosents the the number of card atributs that are being asined
                    {
                        Card a = new Blue(i, CardAtributs);
                    }
                    return Blue.blueCards;
                default:
                    Exception prob = new Exception("this type of card does not exist");
                    throw prob;
            }
        }
    }
}
