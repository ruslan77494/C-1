/*1. Напишите программу,которая на вход принимает два числа и проверяет,является ли первое число квадратом второго.
a = 5; b = 25 -> да
a = 2; b = 10 -> нет
*/






int a = Convert.ToInt32(Console.ReadLine());

int b = Convert.ToInt32(Console.ReadLine());
if (a * a == b)
{
    Console.WriteLine("Число является квадратным корнем ");
}
else
{
    Console.WriteLine("Число не является квадратным корнем ");
}
    

