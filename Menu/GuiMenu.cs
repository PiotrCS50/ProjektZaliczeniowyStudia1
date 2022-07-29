using System;

namespace Menu
{
    public class GuiMenu
    {
        public string[] elementy = new string[0];

        public void WpiszDane(string[] elementy)
        {
            if(elementy != null)
            {
                this.elementy = elementy;
            }
        }

        public int OtworzMenu()
        {
            int wybrany = 0;
            ConsoleKeyInfo key;
            ConsoleColor KolorBazowy = Console.BackgroundColor;
            do
            {
                Console.SetCursorPosition(2, 13);
                for (int i = 0; i < elementy.Length; i++)
                {
                    if (i == wybrany)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                    }
                    Console.WriteLine(elementy[i].PadRight(20));
                }
                key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.DownArrow && wybrany < elementy.Length - 1) wybrany++;
                else if (key.Key == ConsoleKey.UpArrow && wybrany > 0) wybrany--;
                else if (key.Key == ConsoleKey.Escape) wybrany = -1;
            } while (key.Key != ConsoleKey.Escape && key.Key != ConsoleKey.Enter);
            return wybrany;
        }
    }
}
