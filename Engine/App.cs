
namespace Engine
{
    public class App
    {
        private Game myGame = new Game();
        private GameLoop myGameLoop = new GameLoop();

        public int Start()
        {
            myGameLoop.Load(myGame);
            return myGameLoop.Start();
        }
    }
}