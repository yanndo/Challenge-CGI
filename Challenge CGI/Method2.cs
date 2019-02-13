using System;

namespace Challenge1
{
    class Method2
    {
        public void Two()
        {
            Console.WriteLine("-JS is very funny");
            int width = 20, height = 20;
            {
                int i, j;
                for (i = 1; i <= height; i++)
                {
                    for (j = 1; j <= width; j++)
                    {
                        if (i == 1 || i == height ||
                            j == 1 || j == width ||
                            j == (width - i + 1))
                            Console.Write("*");
                        else
                            Console.Write("-");
                    }
                    Console.WriteLine();
                }
                Console.ReadKey();
            }
        }
    }
}