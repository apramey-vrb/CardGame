using CardGame.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Common.Interfaces
{
    public interface IDeck<T, U>
        where T : Enum
        where U : Enum
    {
        Card<T,U> PlayACard(Stack<Card<T, U>> cards);
        Stack<Card<T, U>> ShuffleDeck(Stack<Card<T, U>> cards);
        Stack<Card<T, U>> RefreshDeck();
    }
}
