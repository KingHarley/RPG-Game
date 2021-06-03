using System;

namespace Engine.GameObject
{
    public class Monster
    {
        public int CurrentHitPoints { get; set; }
        public int MaxHitPoints { get; set; }
        public int Damage { get; set; }

        public Monster()
        {
            CurrentHitPoints = 0;
            MaxHitPoints = 0;
            Damage = 0;
        }

        public void Attacked()
        {
            Speak();
            if(CurrentHitPoints <= 0)
            {
                DeSpawn();
            }
        }

        public virtual void Speak()
        {
            Console.WriteLine("Blurg");
        }


        public virtual void Spawn()
        {
            Console.WriteLine("A wild monster appears!");
        }

        public virtual void DeSpawn()
        {
            Console.WriteLine("The monster was slain");
        }
    }
}