void Zadacha47()
{
    Random random = new Random();
    int rows = random.Next(3,4);
    int columns = random.Next(3,4);
    Console.WriteLine ($"Массив вещественных чисел,округленный до 1го знака");
    double [,] numbers = new double [rows,columns];
FillArray (numbers);  
PrintArray (numbers);
}                                                                                      


void FillArray (double[,] numbers)
{
    Random random = new Random();
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i=0; i< rows; i++)
    {
        for(int j=0; j< columns; j++)
        {
            numbers[i,j] = random.Next (-100, 100);
            numbers [i,j] = numbers [i,j]/10; 
            

           
        }
    }
}

void PrintArray (double[,] numbers)
{   
    for (int i=0; i< numbers.GetLength(0); i++)
    {
        for(int j=0; j< numbers.GetLength(1); j++)
        {
           Console.Write(numbers[i,j]+ "\t");
        }
        Console.WriteLine();
    }
}  


//Zadacha47();



void Zadacha50()
{
    
    Random random = new Random();
    int rows = random.Next(3,6);
    int columns = random.Next(3,6);
    Console.WriteLine ("Задан массив");
    int [,] numbers = new int [rows,columns];
    FillArray1 (numbers);  
    PrintArray1 (numbers);
    Console.WriteLine("Введите номер строки:");
    int i= Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите номер столбца:");
    int j= Convert.ToInt32(Console.ReadLine());
    if( i<numbers.GetLength(0))
    {
        if(j< numbers.GetLength(1))
        {
            Console.WriteLine($"Значение ячейки массива: {numbers[i,j]}");
        }
        else
        {
        Console.WriteLine("Такой ячейки в массиве нет");
        }
    }
    else
    {
        Console.WriteLine("Такой ячейки в массиве нет");
    }
}
//Zadacha50();


void Zadacha52()
{
    Random random = new Random();
    int rows = random.Next(3,6);
    int columns = random.Next(3,6);
    int [,] numbers = new int[rows,columns];
    Console.WriteLine($"строк:{rows} столбцов:{columns}");
    FillArray1(numbers);
    PrintArray1(numbers);
    Console.WriteLine();
    ArithMeanArray(numbers);
}
void FillArray1 (int[,] numbers)
    {
      Random random = new Random();    
      int rows = numbers.GetLength(0);
      int columns = numbers.GetLength(1);
      for (int i=0; i< rows; i++)
      {
        for(int j=0; j< columns; j++)
        {
            numbers[i,j] = random.Next (-100, 100);
        }
      }
    }


void PrintArray1(int[,] numbers)
{   
    for (int i=0; i< numbers.GetLength(0); i++)
    {
        for(int j=0; j< numbers.GetLength(1); j++)
        {
           Console.Write(numbers[i,j]+ "\t");
        }
        Console.WriteLine();
    }
}  



void ArithMeanArray (int[,] numbers)
{
    double result =0;
    double sum=0;

    for(int j=0; j< numbers.GetLength(1); j++)
    {
        for (int i=0; i<numbers.GetLength(0); i++)
        {
            sum = sum + numbers[i,j];
        }
        result = sum/numbers.GetLength(0);
        Console.WriteLine (result);
        result = 0;
        sum = 0;
    }
        
      
}
//Zadacha52();
