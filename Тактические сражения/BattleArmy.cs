using System;
using System.Collections.Generic;
using System.Text;

namespace Тактические_сражения
{
    class BattleArmy:Army
    {
        private Dictionary<string, BattleUnitsStack> stacks=new Dictionary<string, BattleUnitsStack>();
        private Dictionary<string, Army> armys = new Dictionary<string, Army>();
        public void AddStackToArmy()
        {
            Console.WriteLine("\nВведите название армии");
            var t = Console.ReadLine();
            if (t == null || armys.ContainsKey(t))
            {
                Console.WriteLine("\nАрмии с таким названием не существует");
            }
            if (armys.Count == 6)
            {
                Console.WriteLine("В этой армии макисмальное количество стеков");
                return;
            }
            Console.WriteLine("\nВведите название стека");
            var r = Console.ReadLine();
            if (r == null || stacks.ContainsKey(r))
            {
                Console.WriteLine("\nТакого стека не существует");
            }
            armys[t].Add(stacks[r]);
            Console.WriteLine("\nСтек успешно добавлен в армию");
        }
        public void Remove()
        {
            Console.WriteLine("\nВведите название армии");
            var t = Console.ReadLine();
            if (t == null || armys.ContainsKey(t))
            {
                Console.WriteLine("\nТакой армии не существует");
            }
            Console.WriteLine("\nВведите название стека");
            var r = Console.ReadLine();
            Console.WriteLine(armys[t].Remove(r) ? "\nСтек успешно удален" : "\nВ этой армии нет стека с таким названием");

        }
    }
}
