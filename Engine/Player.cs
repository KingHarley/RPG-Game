using System;

namespace Engine
{
    public class Player
    {
        public int CurrentHitpoints { get; set; }
        public int MaximumHitpoints { get; set; }
        public int Gold { get; set; }
        public int Exp { get; set; }
        public int Level { get; set; }



        public Player(int hp, int gold)
        {
            CurrentHitpoints = hp;
            MaximumHitpoints = hp;
            Gold = gold;
            Exp = 0;
            Level = 1;
        }

        public Player()
        {
            CurrentHitpoints = 5;
            MaximumHitpoints = 5;
            Gold = 10;
            Exp = 0;
            Level = 1;
        }
        
    }
}