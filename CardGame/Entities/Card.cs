using CardGame.Common.Interfaces;
using System;
using static CardGame.Common.EnumConstants;

namespace CardGame.Entities
{
    /// <summary>
    /// Accepts enum for different types of cards
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="U"></typeparam>
    public class Card<T, U> : ICard
        where T : Enum
        where U : Enum
    {
        private T Value { get; set; }
        private U Suite { get; set; }

        public Card(T value, U suite)
        {
            Value = value;
            Suite = suite;
        }

        /// <summary>
        /// Override method for ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Card : " + Value + " of " + Suite;
        }
    }
}
