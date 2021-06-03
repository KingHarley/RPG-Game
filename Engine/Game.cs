using System;
using System.Collections.Generic;
using Engine.GameWorld;

namespace Engine
{
    public class Game
    {

        private Player playerOne;
        public List<GameLevel> GameLevels;

        public Game()
        {
            GameLevels = new List<GameLevel>();
        }
        public void Load()
        {
            playerOne = new Player();
            GameLevelOne levelOne = new GameLevelOne();
            levelOne.StartUp();
            this.AddGameLevel(levelOne);
        }

        public string Input()
        {
            return Console.ReadLine();
        }

        public void Output(string s)
        {
            Console.WriteLine(s);
        }

        public void AddGameLevel(GameLevel level)
        {
            if(level != null)
            {
                GameLevels.Add(level);
            }
        }

        public void HandleInput(string input)
        {
            if(playerOne != null && GameLevels[0] != null)
            {
                if(GameLevels[0].monsters[0] != null)
                {
                    playerOne.Attack(GameLevels[0].monsters[0]);
                }
            }
        }
    }



}