// Напишите цикл, который принимает на вход два числа (А и В) и возводит число А в натуральную степень В
/*
Console.WriteLine("Ведите число А: ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число В: ");
int B = int.Parse(Console.ReadLine()!);

{
Console.WriteLine($"A в степени B = " + Math.Pow(A, B));
}
*/


// Напишите программу, которая принимает на вход число и выдает сумму цифр в числе
/*
Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

  int SumNumber(int numberN){
    
    int counter = Convert.ToString(numberN).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++){
      advance = numberN - numberN % 10;
      result = result + (numberN - advance);
      numberN = numberN / 10;
    }
   return result;
  }

int sumNumber = SumNumber(numberN);
Console.WriteLine("Сумма цифр в числе: " + sumNumber);
*/

// Напишите программу, которая задает массив из 8 рандомных элементов и выводит их на экран

int[] ar = FillArray();
PrintArray(ar);



int[] FillArray()
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,55);
    }
    return array;
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    Console.Write($"{arr[i]} " );
}