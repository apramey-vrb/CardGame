using System;

namespace CardGame.Extensions
{
    public static class DisplayExtensions
    {
        /// <summary>
        /// Static method to display menu options
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static byte ShowMenu<T>()
            where T : Enum
        {
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Please choose an option : ");
            foreach(T menu in Enum.GetValues(typeof(T)))
            {
                Console.WriteLine(EnumExtensions.GetDescription<T>(menu));
            }
            return Convert.ToByte(Console.ReadLine());
        }
    }
}
