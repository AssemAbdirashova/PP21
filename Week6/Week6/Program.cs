using System;

namespace Week6
{
    class Program
    {
        public static void Das(Gamestate gameState)
            {
            bool IsAlive = true;
            while (IsAlive && !gameState.Gameover())
            {
                gameState.Draw();

                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
                gameState.PressedKey(consoleKeyInfo);

            }
}
    static void Main(string[] args)
        {
            bool IsAlive = true;
            Console.SetWindowSize(40, 40);
            Console.SetBufferSize(40, 40);
            Console.CursorVisible = false;
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.Clear();
            Gamestate gameState = new Gamestate();

            Das(gameState);
            if (gameState.Gameover())
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.SetCursorPosition(18, 18);
                Console.Write("YOU DIED!");
                Console.CursorVisible = false;
            }
           
            
            //if(gameState.w.body[0].X== gameState.b.body[0].X && gameState.w.body[0].X == gameState.b.body[0].X)

           
        }
    }
}