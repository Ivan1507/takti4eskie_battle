using System;
using System.Collections.Generic;
using System.Text;

namespace Тактические_сражения
{
    public class BattleUnitsStack: UnitsStack
    {
        public int CurrentHealth { get; private set; }
        public int CurrentUnits { get; private set; }
        private bool CanCounterAttack;

        public BattleUnitsStack(Unit unit,string name, int count):base(unit,name,count)
        {
            CurrentHealth = unit.HitPoints;
            CurrentUnits = count;
            CanCounterAttack = true;
        }
        public bool IsAlive()
        {
            return CurrentUnits>0;
        }
     
        
    }
}
