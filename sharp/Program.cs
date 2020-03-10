using System;
using System.Linq;

namespace sharp
{
    class Program
    {
        class Rect
        {
            public int Width;
            public int Height;
            public Rect(int w, int h)
            {
                this.Width = w;
                this.Height = h;
            }
            public int Area()
            {
                return this.Width * this.Height;            
            }
        }

        static void Main(string[] args)
        {
            int t, i;
          
int[,] table = new int[3, 4];
            for (t = 0; t < 3; ++t)
            {
                for (i = 0; i < 4; ++i)
                {
                    table[t, i] = (t * 4) + i + 1;
                    Console.Write(table[t, i] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
