using System;
using Engine.GameObject;

namespace Engine.GameWorld
{
    public class GameLevelOne : GameLevel
    {
        public GameLevelOne(){}

        public void StartUp()
        {
            Monster ratOne = new Rat();
            this.AddMonster(ratOne);
            Console.WriteLine("Welcome to the game!");
        }
    }
}