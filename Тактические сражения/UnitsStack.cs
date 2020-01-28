using System;
using System.Collections.Generic;
using System.Text;

namespace Тактические_сражения
{
    public class UnitsStack
    {
        public string Name_of_stack { get; }
        public int Count { get; }
        public Unit Unit { get; }
        public UnitsStack(Unit unit,string noc,int count)
        {
            Unit = unit;
            Name_of_stack = noc;
            Count = count;
        }
        public UnitsStack()
        {

        }

    }
}
