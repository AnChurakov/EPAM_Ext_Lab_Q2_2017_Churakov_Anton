using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Создайте иерархию  классов и  пропишите ключевые  методы для
//компьютерной игры(без реализации функционала)
//1.Игрок может передвигаться по прямоугольному полю размером
//Width на Height.
//2.На поле располагаются бонусы (яблоко, вишня и т.д.), которые
//игрок может подобрать для поднятия каких-либо характеристик.
//    За игроком охотятся монстры (волки, медведи и т.д.), которые
//могут передвигаться по карте по какому
//-либо алгоритму.
//4.На поле  располагаются препятствия  разных типов  (камни,
//деревья и т.д.), котор
//ые игрок и монстры должны обходить.
//Цель игры–собрать все бонусы
//и не быть «съеденным» монстрами

namespace Task04
{
    class Area
    {
         int Width { get; set; }
         int Height { get; set; }
         
        public Area(int Width, int Height)
        {
            this.Width = Width;
            this.Height = Height;
        }
    }

    class Enemy
    {
        int Attack { get; set; } //урон
        int SpeedAttack { get; set; }// скорость атаки
        int x { get; set; }
        int y { get; set; }
        
        public Enemy(int attack, int speedattack, int x, int y)
        {
            Attack = attack;
            SpeedAttack = speedattack;
            this.x = x;
            this.y = y;
        }

        public virtual int GetX(int x)
        {
            return x;
        }

        public virtual int GetY(int y)
        {
            return y;
        }

        public virtual int AttackPlayer(int attack)
        {
            return Attack;
        }

        public virtual int SpeedAttackEnemy(int speed)
        {
            return SpeedAttack;
        }
    }

    class Wolf : Enemy
    {
        public Wolf(int attack, int speedattack, int x, int y) : base(attack, speedattack, x, y)
        {
        }

        public override int AttackPlayer(int attack)
        {
            return base.AttackPlayer(attack);
        }

        public override int GetX(int x)
        {
            return base.GetX(x);
        }

        public override int GetY(int y)
        {
            return base.GetY(y);
        }

        public override int SpeedAttackEnemy(int speed)
        {
            return base.SpeedAttackEnemy(speed);
        }
    }
    
    class Player
    {
        int Health { get; set; }//здоровье 
        int x { get; set; }
        int y { get; set; }

        public Player(int health, int x, int y)
        {
            Health = health;
            this.x = x;
            this.y = y;
        }

        public int GetX(int x)
        {
            return x;
        }

        public int GetY(int y)
        {
            return y;
        }

        public int AddHealth(int bonus) //добавление здоровья игроку, если взял бонус
        {
            Health += bonus;
            return Health;
        }
    }

    class Bonus
    {
        string NameBonus { get; set; }
        int ValueBonus { get; set; }
        int x { get; set; }
        int y { get; set; }

        public Bonus(int x, int y, string NameBonus, int ValueBonus)
        {
            this.x = x;
            this.y = y;
            this.NameBonus = NameBonus;
            this.ValueBonus = ValueBonus;
        }

        public virtual int GetX()
        {
            return x;
        }

        public virtual int GetY()
        {
            return y;
        }

        public virtual string GetNameBonus()
        {
            return NameBonus;
        }

        public virtual int Value() //количество очков бонуса
        {
            return ValueBonus;
        }
    }

    class Apple : Bonus
    {
        public Apple(int x, int y, string NameBonus, int ValueBonus) : base(x, y, NameBonus, ValueBonus)
        {
        }

        public override string GetNameBonus()
        {
            return base.GetNameBonus();
        }

        public override int GetX()
        {
            return base.GetX();
        }

        public override int GetY()
        {
            return base.GetY();
        }

        public override int Value()
        {
            return base.Value();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
         
        }
    }
}
