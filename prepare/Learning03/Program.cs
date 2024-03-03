using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        bool toggle = true;
        DateTime startTime = DateTime.Now;

        while ((DateTime.Now - startTime).TotalSeconds < 5)
        {
            if (toggle)
            {
                Console.Write("+");
            }
            else
            {
                Console.Write("-");
            }

            toggle = !toggle;
            Thread.Sleep(500);
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop); // Move the cursor back to overwrite the previous character
        }

        // Clear the line
        Console.SetCursorPosition(0, Console.CursorTop);
        Console.Write(new string(' ', Console.WindowWidth));
        Console.SetCursorPosition(0, Console.CursorTop);
    }
}
