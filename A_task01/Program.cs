/* Программа,принимающая на вход  два числа и выдающая 
большее из этих чисел.*/

Console.WriteLine("Введите первое число");
string number1 = Console.ReadLine() ?? "";
Console.WriteLine("Введите второе число");
string number2 = Console.ReadLine() ?? "";
int num1 = Convert.ToInt32(number1);
int num2 = Convert.ToInt32(number2);

if (num1 > num2)
{
    Console.WriteLine($"Число {num1} больше числа {num2}");
}
else
{
    Console.WriteLine($"Число {num2} больше числа {num1}");
}
if (num1 == num2)
{
    Console.WriteLine($"Число {num2} равно числу {num1}");
}