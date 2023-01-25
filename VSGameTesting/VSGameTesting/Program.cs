using System;
class program
{
    static void Main()
    {
        int mode;

        Console.WriteLine("Modes: - Additon (1)\n - Subtraction (2)\n - Multiplication (3)\n - Division (4)");
        Console.Write("Set mode: ");
        mode = Convert.ToInt32(Console.ReadLine());

        setRange(mode);


    }
    static void setRange(int mode)
    {
        int result;
        int x, y;

        if (mode == 1)
        {
            x = randomise(1, 12);
            y = randomise(1, 12);
            result = x + y;
        }
        else if (mode == 2)
        {
            x = randomise(10, 999);
            y = randomise(1, 100);
            result = x - y;
        }
        else if (mode == 3)
        {
            x = randomise(1, 12);
            y = randomise(1, 12);
            result = x * y;
        }
        else if (mode == 4)
        {
            x = randomise(1, 144);
            y = randomise(1, 12);
            if (x % y == 0)
            {
                result = x / y;
            }
            else
            {
                setRange(mode);
            }
        }
    }

    static int randomise(int x, int y)
    {
        Random random = new Random();
        int z = random.Next(x, y);
        return z;
    }
}
