System.Console.WriteLine("Введите количество строк и столбцов");

int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[n,n];


for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(0, 10);
        System.Console.Write(matrix[i,j] + " ");
    }
    System.Console.WriteLine();
}
void firstLast (int[,] matrix)
{
int leng = n-1;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int box = matrix[0,i];
        matrix[0,i] = matrix[leng,i];
        matrix[leng,i] = box;
    }
}
firstLast(matrix);

System.Console.WriteLine();

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        System.Console.Write(matrix[i,j] + " ");
    }
    System.Console.WriteLine();
}