using System;


namespace Engine.GameObject
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

        public override void Spawn()
        {
            Console.WriteLine("A wild rat appears!");
        }

        public override void DeSpawn()
        {
            Console.WriteLine("The rat was slain!");
        }
    }
}