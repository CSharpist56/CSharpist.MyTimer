using Timer = CSharpist.MyTimer.Library.Timer;

namespace CSharpist.MyTimer.CLI
{
    internal struct Program
    {
        private static Timer timer = new Timer();

        private static void Init()
        {
            Console.TreatControlCAsInput = false;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Title = "MyTimer";

            Console.Clear();
        }

        private static void Main()
        {
            Init();

            Thread thread = new Thread(ShowTimer);
            thread.Start();

            Exit();
        }

        private static void ShowTimer()
        {
            while (true)
            {
                Console.CursorLeft = 40;

                Console.WriteLine($"Timer: {timer.Displaying()}");
            }
        }

        private static void Exit()
        {
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}