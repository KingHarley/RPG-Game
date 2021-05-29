using System;

namespace GameObject
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

        public virtual void Speak()
        {
            Console.WriteLine("Blurg");
        }
    }
}