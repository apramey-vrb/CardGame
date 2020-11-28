using CardGame.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CardGame.Entities
{
    /// <summary>
    /// Class for Deck with any type of Suite and Values whose type is enum
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="U"></typeparam>
    public class Deck<T, U> : IDeck<T, U>
        where T : Enum 
        where U : Enum
    {
        public Stack<Card<T,U>> Cards { get; set; }

        public Deck()
        {           
            Cards = RefreshDeck();
            Cards = ShuffleDeck(Cards);
        }              

        /// <summary>
        /// Picks top most card from card deck
        /// </summary>
        /// <param name="cards"></param>
        /// <returns></returns>
        public Card<T, U> PlayACard(Stack<Card<T, U>> cards)
        {
            if (cards.Count == 0)
                throw new Exception("Deck Empty!");
            return cards.Pop();            
        }

        /// <summary>
        /// Shuffles card deck randomly
        /// </summary>
        /// <param name="cards"></param>
        /// <returns></returns>
        public Stack<Card<T, U>> ShuffleDeck(Stack<Card<T, U>> cards)
        {
            if (cards.Count == 0)
                throw new Exception("Deck Empty!");
            Random random = new Random();
            cards = new Stack<Card<T, U>>(cards.OrderBy(card => random.Next()));
            Console.WriteLine(cards.Count + " cards shuffled from deck.");
            return cards;
        }

        /// <summary>
        /// Creates a new card deck
        /// </summary>
        /// <returns></returns>
        public Stack<Card<T, U>> RefreshDeck()
        {
            Stack<Card<T, U>> cards = new Stack<Card<T, U>>();
            foreach (U suite in Enum.GetValues(typeof(U)))
            {
                foreach (T card in Enum.GetValues(typeof(T)))
                {
                    cards.Push(new Card<T, U>(card, suite));
                }
            }
            Console.WriteLine("You have a new deck with " + cards.Count + " cards!");
            return cards;
        }
    }   
}
