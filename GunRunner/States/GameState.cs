using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using GunRunner_v2;
using LilyPath;

namespace gunrunner.try2
{
    class GameState : IGameState
    {
        private IGameState _activeState;
        private Level _level;

        public GameState()
        {
            _activeState = this;
        }
        
        public IGameState ActiveState()
        {
            return _activeState;
        }

        public void Update(GameTime gameTime)
        {
            if (KeyboardMaster.IsKeyPressed(Keys.Escape))
                _activeState = new PauseMenuState(this);
        }

        public void Draw(GameTime gameTime)
        {
            GameMaster.Self.drawBatch.DrawLine(new Pen(Color.Black,5), new Vector2(), new Vector2(100, 100));

            //first draw backgrounds
            //then tiles
            //then characters
            //then bullets
            //then shades
            
        }


    }
}
