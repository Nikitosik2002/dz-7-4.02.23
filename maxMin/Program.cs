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

System.Console.WriteLine();
for (int i = 0; i < matrix.GetLength(0) ; i++)
{
    
    for (int j = 0; j < matrix.GetLength(1) - 1; j++)
    {

         for (int z = 0; z < matrix.GetLength(1) - 1; z++)
        {
            if (matrix[i, z] < matrix[i, z + 1]) 
            {
                int temp = 0;
                temp = matrix[i, z];
                matrix[i, z] = matrix[i, z + 1];
                matrix[i, z + 1] = temp;
            }

        }
    
    }
}



System.Console.WriteLine();
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        System.Console.Write(matrix[i,j] + " ");
    }
    System.Console.WriteLine();
}