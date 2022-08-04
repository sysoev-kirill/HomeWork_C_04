// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число:  ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень числа:  ");
int pow = Convert.ToInt32(Console.ReadLine());


int PowerNumber(int number, int power)
{
   int sum = 1;
   for (int i = 0; i < power; i++)
   {
      sum = sum * number;
   }
   return sum;
}

int result = PowerNumber(num, pow);
Console.Write($"{num}, {pow} => {result} ");