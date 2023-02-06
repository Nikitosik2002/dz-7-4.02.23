System.Console.WriteLine("Введите количество строк ");
int m = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите количество столбцов ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m,n];


for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(0, 10);
        System.Console.Write(matrix[i,j] + " ");
    }
    System.Console.WriteLine();
}
 int min = 100000;
 int count = 0;

 for (int i = 0; i < matrix.GetLength(0); i++)
    {
         int summ = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            summ += matrix[i,j]; 
        }
        System.Console.WriteLine(summ);
        if (summ < min)
        {
            min = summ;
            count++;
        }
    }
System.Console.WriteLine("Наименьшая сумма элементов = " + min + " на строке под номером " + count);
System.Console.WriteLine();
    