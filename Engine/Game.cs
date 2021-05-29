using System;

namespace Engine
{
    public class Game
    {

        private Player playerOne;
        public void Load()
        {
            playerOne = new Player();
        }

        public string Input()
        {
            return Console.ReadLine();
        }

        public void Output(string s)
        {
            Console.WriteLine(s);
        }
    }



}