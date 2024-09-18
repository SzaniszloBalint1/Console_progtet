namespace Console_feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.CursorVisible = false;
            int cursorX = Console.WindowWidth/2 ;
            int cursorY = Console.WindowHeight/2 ;
            ConsoleColor color = ConsoleColor.White;
            ConsoleColor color1 = ConsoleColor.Red;
            char currentChar = '█';

            bool running = true;

            while (running)
            {
                Console.SetCursorPosition(0, 0);
                Console.WriteLine($"X: {cursorX} Y: {cursorY} Karakter: {currentChar}");

               
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey(true);

                    switch (key.Key)
                    {
                        case ConsoleKey.Escape:
                            running = false;
                            break;
                        case ConsoleKey.UpArrow:
                            if (cursorY > 0) cursorY--;
                            Console.SetCursorPosition(cursorX, cursorY);
                            Console.ForegroundColor = color;
                            Console.Write(currentChar);
                            break;
                        case ConsoleKey.DownArrow:
                            if (cursorY < Console.WindowHeight - 1) cursorY++;
                            Console.SetCursorPosition(cursorX, cursorY);
                            Console.ForegroundColor = color;
                            Console.Write(currentChar);
                            break;
                        case ConsoleKey.LeftArrow:
                            if (cursorX > 0) cursorX--;
                            Console.SetCursorPosition(cursorX, cursorY);
                            Console.ForegroundColor = color1;
                            Console.Write(currentChar);
                            break;
                        case ConsoleKey.RightArrow:
                            if (cursorX < Console.WindowWidth - 1) cursorX++;
                            Console.SetCursorPosition(cursorX, cursorY);
                            Console.ForegroundColor = color1;
                            Console.Write(currentChar);
                            break;
                        
                        

                       
                    }
                }
            }
            Console.ResetColor();
            Console.Clear();

            int[] tomb = { 8, 9, 5, 4, 1 };
            int n = 5;

            Console.WriteLine("Összegzés tétel");
            int osszeg = 0;
            for (int i = 0; i < n; i++)
                osszeg = osszeg + tomb[i];

            Console.WriteLine("Összeg: " + osszeg);

            int[] t = { 9, 7, 3, 5, 4, 2, 6 };
            
            int ker = 5;
            Console.WriteLine("Eldöntés tétel");
            bool van = false;
            for (int i = 0; i < t.Length; i++)
                if (t[i] == ker)
                    van = true;

            Console.WriteLine("Igaz-e, hogy van 5-ös a tömbben?: {0}", van);





        }
    }
}
