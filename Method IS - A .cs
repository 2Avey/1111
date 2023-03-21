using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLight
{
    class Proram
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight(100, 50);
            Barbarian barbarian = new Barbarian(100, 1, 20, 2);

            barbarian.TakeDamage(100);
            knight.TakeDamage(70);

            barbarian.ShowInfo();
            knight.ShowInfo();
        }
    }
    class Warrior
    {
        protected int Health; 
        protected int Armor; 
        protected int Damage;

        public Warrior(int health, int armor, int damage)
        {
            Health= health;
            Armor= armor;
            Damage= damage;
        }

        public void TakeDamage (int damage)
        {
            Health -= damage - Armor;
        }
        public void ShowInfo()
        {
            Console.WriteLine(Health);
        }
    }
    
    
    class Knight: Warrior
    {
        public Knight(int health, int damage) : base(health, 10, damage) { }
        public void Pray()
        {
            Armor += 2;
        }
    }
    class Barbarian: Warrior
    {
        public int AttackSpeed;

        public Barbarian(int health, int armor, int damage, int attackSpeed) : base(health, armor, damage * attackSpeed)
        {
            AttackSpeed = attackSpeed;


        }
        public void Waagh() 
        { 
            Armor -= 2;
            Health += 16;
        }
    }
}
