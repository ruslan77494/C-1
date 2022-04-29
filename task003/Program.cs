/*3. Напишите программу,которая будет выдавать название дня недели по зодонному номеру.
3-> cреда
5-> пятница
*/

Console.WriteLine("Пожалуста Введите число:  ");

int number = Convert.ToInt32(Console.ReadLine());
switch (number)
{
      case 1:
      {
             System.Console.WriteLine("Пн");
             break;
      } 
      case 2:
     {
             System.Console.WriteLine("Вт");
             break;
     }
     case 3:
           {
             System.Console.WriteLine("Ср");
             break;
           }
     default:
      {
              System.Console.WriteLine("Всего 7 дней в недели! ");
             break;
      }
}


