using System.Runtime.InteropServices;

namespace CSharpist.MyTimer.Library
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto, Pack = 1)]
    public struct Timer
    {
        private static int minute;
        private static int second;

        public static int Minute
        {
            get => minute;

            set => minute = value >= 0 ? value : 0;
        }

        public static int Second
        {
            get => second;

            set
            {
                if (value >= 0 && value <= 59)
                {
                    second = value;
                }
                else
                {
                    second = 0;
                    minute++;
                }
            }
        }

        public Timer()
        {
            Minute = 0;
            Second = 0;
        }

        public Timer(int minute, int second)
        {
            Minute = minute;
            Second = second;
        }

        public string Displaying()
        {
            Second++;
            Thread.Sleep(1000);
            return $"{Minute}:{Second}";
        }
    }
}