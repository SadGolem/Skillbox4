int n = 10;
bool[] petry = new bool[n];


Random rand = new Random();

for (int i = 0; i < n; i++)
{
    petry[i] = rand.Next(2) == 0 ? true : false;

    if (petry[i])
        Console.Write(" |" + "B" + "| ");
    else
        Console.Write(" |" + " " + "| ");
}
while (petry.Contains(true))
{
    Console.WriteLine("\nНажмите, чтобы продолжить...");
    Console.ReadLine();

    for (int i = 1; i < n-1; i++)
    {
        if (petry[i + 1] && petry[i - 1])
        {
            petry[i] = false;
            Console.WriteLine($"\nБактерия {i} умерла от недостатка еды.\n");
        }
        else
        {
            petry[i + 1] = rand.Next(2) == 0;
            petry[i - 1] = rand.Next(2) == 0;
        }

        if (!petry[i + 1] && !petry[i - 1])
        {
            petry[i] = false;
            Console.WriteLine($"\nБактерия {i} умерла от недостатка внимания.\n");
        }
        else
        {
            petry[i + 1] = rand.Next(2) == 0 ;
            petry[i - 1] = rand.Next(2) == 0;
        }
    }
    for (int i = 0; i < n; i++)
    {
        if (petry[i])
            Console.Write(" |" + "B" + "| ");
        else
            Console.Write(" |" + " " + "| ");
    }
}

