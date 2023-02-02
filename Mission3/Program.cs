//Задача 2: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
//4 -> 24
//5 -> 120

int Prompt(string message)
{
  System.Console.Write($"{message} > ");
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}

int Factorial(int n)//Факториал - математическая функция. Применяется в комбинаторике. Означает что 1*2*3*4... 
{
  int prod = 1;
  for (int i = 1; i <= n; i++)
  {
    prod = prod * i;
  }
  return prod;
}
int number = Prompt("Введите число");

int fakt = Factorial(number);
System.Console.WriteLine($"Произведение (факториал) числа {number} = {fakt}");