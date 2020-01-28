using System;

namespace Тактические_сражения
{
    class Program
    {
 
        static void Main(string[] args)
        {
            Unit unit = new Unit("Фурия", 16, 5, 3, 5 - 7, 16);
            UnitsStack units = new UnitsStack(unit,"НЕжить",7);
            var army = new Army();
             

        }
    }
}
