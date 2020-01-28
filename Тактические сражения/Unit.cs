using System;
using System.Collections.Generic;
using System.Text;

namespace Тактические_сражения
{
    public class Unit
    {
        protected string Name { get; }
        public int HitPoints { get; }
        protected int Attack { get; }
        protected int Defence { get; }
        protected int Damage { get; }
        protected double Intiative { get; }
        public Unit(string Name,int HP,int Attack,int Defence,int Damage,double Intiative)
        {
            this.Name = Name;
            HitPoints = HP;
            this.Attack = Attack;
            this.Defence = Defence;
            this.Damage = Damage;
            this.Intiative = Intiative;
        }
    }
}
