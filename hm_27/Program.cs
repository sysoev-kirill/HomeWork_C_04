//  Задача 27: Напишите программу, которая принимает на вход число и выдаёт
//  сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число:  ");
int num = Convert.ToInt32(Console.ReadLine());

int PlusNumber(int number)
{
   int sum = 0;

   for (int i = 0; i < number; number /= 10)
   {
      sum = sum + number % 10;
   }
   return (sum);
}
int result = PlusNumber(num);

Console.Write($"{num} => {result} ");