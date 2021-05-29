using System;


namespace GameObject
{
    public class Rat : Monster
    {
        public Rat () 
        {
            CurrentHitPoints = 2;
            MaxHitPoints = 2;
            Damage = 1;
        }

        public override void Speak()
        {
            Console.WriteLine("Squeeeee");
        }
    }
}