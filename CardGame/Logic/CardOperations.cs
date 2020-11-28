using CardGame.Entities;
using CardGame.Extensions;
using System;
using static CardGame.Common.EnumConstants;

namespace CardGame.Logic
{    
    /// <summary>
    /// All type of simple card operations takes place here.   
    /// </summary>
    public class CardOperations
    {
        /// <summary>
        /// Starting point for card operations.
        /// </summary>
        public static void Init()
        {
            Deck<CardValueEnum, SuiteEnum> cardDeck = new Deck<CardValueEnum, SuiteEnum>();
            try
            {
                while (true)
                {
                    byte gameOption = DisplayExtensions.ShowMenu<MenuOptionsEnum>();                    
                    
                    switch (gameOption)
                    {
                        case (byte)MenuOptionsEnum.PLAY:
                            Console.WriteLine(cardDeck.PlayACard(cardDeck.Cards).ToString());
                            break;
                        case (byte)MenuOptionsEnum.SHUFFLE:
                            if (cardDeck.Cards.Count == 1)
                                Console.WriteLine("Only one card present. No need to shuffle.");
                            else
                                cardDeck.ShuffleDeck(cardDeck.Cards);
                            break;
                        case (byte)MenuOptionsEnum.REFRESH:
                            cardDeck = new Deck<CardValueEnum, SuiteEnum>();
                            break;
                        case (byte)MenuOptionsEnum.EXIT:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("You selected wrong option.");
                            break;
                    }

                    if (cardDeck.Cards.Count == 0)
                    {
                        Console.WriteLine("Deck empty. Do you wish to refresh the deck? (Y/N)");
                        if ('Y'.Equals(Convert.ToChar(Console.ReadLine().ToUpper())))
                            cardDeck.Cards = cardDeck.RefreshDeck();
                        else
                            continue;
                    }
                }
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nDo you wish to start new game? (Y/N)");
                if ('Y'.Equals(Convert.ToChar(Console.ReadLine().ToUpper())))
                {
                    Init();
                }
                else
                {
                    Environment.Exit(0);
                }
            }                         
        }        
    }
}
