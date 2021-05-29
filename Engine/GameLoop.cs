using System;

namespace Engine
{
    public class GameLoop
    {
        private Game _myGame;
        public bool isRunning { get; private set; }
        public string input { get; private set; }
        public void Load(Game gameObj)
        {
            _myGame = gameObj;
        }

        public int Start()
        {
            if (_myGame == null)
            {
                throw new ArgumentException("_myGame is not defined!");
            }
            
            isRunning = true;

            while(isRunning)
            {
                _myGame.Load();
                Console.Write("Input: ");
                input = _myGame.Input();
                if (String.Equals(input, "Exit"))
                {
                    break;
                }
            }
            return 0;
        }

        public void Stop()
        {
            isRunning = false;
        }
    }
}