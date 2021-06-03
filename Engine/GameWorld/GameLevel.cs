using System;
using System.Collections.Generic;
using Engine.GameObject;

namespace Engine.GameWorld
{
    public class GameLevel
    {
        public List<Monster> monsters { get; }

        public GameLevel()
        {
            List<Monster> newMonsters = new List<Monster>();
            monsters = newMonsters;
        }

        public void AddMonster(Monster m)
        {
            if(m != null)
            {
                monsters.Add(m);
            }
        }
    }
}