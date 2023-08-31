//[--------------------Task1------------------------]


Console.WriteLine("Введите количество строк");
string rowsString = Console.ReadLine();
Console.WriteLine("Введите количество столбцов");
string columnsString = Console.ReadLine();

int countRows = int.Parse(rowsString);
int countColumns = int.Parse(columnsString);
int sum = 0;

int[,] matrx = new int[countRows, countColumns];

Random rand = new Random();

for (int i = 0; i < countRows; i++)
{
    for (int j = 0; j < countColumns; j++)
    {
        matrx[i, j] = rand.Next(20);
        sum += matrx[i, j];
        Console.Write(" " + matrx[i, j]);
    }
    Console.Write("\n");
}
Console.Write($"\nСумма: {sum} \n");

//[--------------------Task2------------------------]

int[,] matrx2 = new int[countRows, countColumns];
int[,] matrx3 = new int[countRows, countColumns];

Console.Write("\n");
for (int i = 0; i < countRows; i++)
{
    for (int j = 0; j < countColumns; j++)
    {
        matrx2[i, j] = rand.Next(20);
        sum += matrx2[i, j];
        Console.Write(" " + matrx2[i, j]);
    }
    Console.Write("\n");
}

Console.Write("\n");
for (int i = 0; i < countRows; i++)
{
    for (int j = 0; j < countColumns; j++)
    {
        matrx3[i, j] = matrx[i, j] + matrx2[i, j];
        Console.Write(" " + matrx3[i, j]);
    }
    Console.Write("\n");
}