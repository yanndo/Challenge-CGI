using System;

namespace Challenge1
{
    class Method1
    {
        public void One()
        {
            Console.WriteLine("JS is the best coach");
            int width = 20, height = 20;

            for (int i = 0; i <= height; i++)
            {
                for (int j = 0; j <= width; j++)
                {
                    if ((i == 0 || i == height) || (j == 0 || j == width))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("-");
                    }
                }

                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
