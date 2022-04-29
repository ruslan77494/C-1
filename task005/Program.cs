/*Напишите прогу которая на вход принимает одно число (N) а на выходе показывает все целые числа в промежутке от -N ДО N*/

Console.WriteLine(" Пожалуйста введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
for (int i = - number; i <= number; i++)
{
    Console.Write(i);
    if (i != number)
    {
        Console.Write(",");
    }
}



