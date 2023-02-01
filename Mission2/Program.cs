// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int Prompt(string message)
{
  System.Console.WriteLine($"{message} ");
  int res = Convert.ToInt32(Console.ReadLine());
  return res;
}

int a = Prompt("Введите число: ");
int CountDigit(int a) // функция и ее имя
{
  int count = 0; // инициализируем счетчик
  while (a > 0)  //условие - пока a > 0, будем a/10. Например 256/10=25 целочисленное, 25/10=2
  {
    a = a / 10;   // сокращенно a/=10 // уменьшием наше значение, пока остаток от целочисленного не станет равен 0
    count++; // увеличиваем счетчик
  }
  return count; // выводим результат сколько разрядов в числе
}
System.Console.WriteLine($"Цифр в числе {a} - {CountDigit(a)}"); //CountDigit(a) - вызывает метод 