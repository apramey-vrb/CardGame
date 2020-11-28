using System.ComponentModel;

namespace CardGame.Common
{
    public class EnumConstants
    {
        public enum SuiteEnum
        {
            CLUB,
            HEART,
            SPADE,
            DIAMOND
        }

        public enum CardValueEnum
        {
            ACE = 1,    
            TWO,
            THREE,
            FOUR,
            FIVE,
            SIX,
            SEVEN,
            EIGHT,
            NINE,
            TEN,
            JACK, 
            QUEEN,
            KING           
        }

        public enum MenuOptionsEnum
        {    
            [Description("1. Play A Card")]
            PLAY = 1,
            [Description("2. Shuffle Deck")]
            SHUFFLE,
            [Description("3. Refresh Deck")]
            REFRESH,
            [Description("4. Exit Game")]
            EXIT
        }
    }
}
