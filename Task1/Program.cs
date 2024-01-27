using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Console.Write("Введіть перше число:");
double number1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введіть друге число:");
double number2 = Convert.ToDouble(Console.ReadLine());

double sum = number1+ number2;
Console.WriteLine($"Сума чисел:{sum}");
