using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMenu
{
    public class GuiMenu
    {

        public string[] elementy = new string[0];
        int y, maxDl = 0;
        public void WpiszDane(string[] elementy, int y)
        {
            if (elementy != null)
            {
                this.elementy = elementy;
                this.y = y;
            }
        }

        public int OtworzMenu()
        {
            foreach (var element in elementy)
            {
                if (element.Length > maxDl)
                    maxDl = element.Length;
            }
            int wybrany = 0;
            ConsoleKeyInfo key;
            ConsoleColor KolorBazowy = Console.BackgroundColor;
            ConsoleColor KolorBazowyF = Console.ForegroundColor;
            do
            {
                Console.SetCursorPosition(0, y);
                for (int i = 0; i < elementy.Length; i++)
                {
                    if (i == wybrany)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    else
                    {
                        Console.BackgroundColor = KolorBazowy;
                        Console.ForegroundColor = KolorBazowyF;
                    }
                    Console.WriteLine(elementy[i].PadRight(maxDl));
                }
                key = Console.ReadKey(true);

                Console.BackgroundColor = KolorBazowy;
                Console.ForegroundColor = KolorBazowyF;
                if (key.Key == ConsoleKey.DownArrow && wybrany < elementy.Length - 1) wybrany++;
                else if (key.Key == ConsoleKey.UpArrow && wybrany > 0) wybrany--;
                else if (key.Key == ConsoleKey.Escape) wybrany = -1;
            } while (key.Key != ConsoleKey.Escape && key.Key != ConsoleKey.Enter);
            Console.Clear();
            return wybrany;
        }

    }
}
