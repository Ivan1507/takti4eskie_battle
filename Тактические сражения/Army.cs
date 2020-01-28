using System;
using System.Collections.Generic;
using System.Text;

namespace Тактические_сражения
{
    public class Army
    {
        public int Count { get; }
        public string Name { get; }
        private Dictionary<string,UnitsStack> stacks;
        public void Add(BattleUnitsStack stack)
        {
            if (Count == 6)
            {
                throw new Exception("Количество стеков не должно превышать 6");
            }
            stacks.Add(stack.Name_of_stack,stack);
        }
        public bool Remove(string name)
        {
            if (!stacks.TryGetValue(name, out var stack))
                return false;
            stacks.Remove(name);
            return true;

        }
       

    }
}
