// Задача 1: Напишите программу, которая принимает на вход число (А)
// и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int Prompt(string message) // 1. 
{
System.Console.Write($"{message} > "); //2.
int result = Convert.ToInt32(Console.ReadLine()); //3.
return result; //4.
}

int SumNumbers(int number) // на вход будет давать это число
{
int sum = 0;
for (int i = 1; i <= number; i++)
{
sum += i;
}
return sum; // нужно вернуть сумму
}

int SumNumbersGauss(int number)
{
return (number + 1)*number/2;
}

int number = Prompt("Введите число");
int sum = SumNumbers(number); 
System.Console.WriteLine($"Сумма чисел от 1 до {number} равна {sum}");
System.Console.WriteLine($"Сумма чисел по Гауссу от 1 до {number} равна {SumNumbersGauss(number)}");