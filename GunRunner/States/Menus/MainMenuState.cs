using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using GunRunner_v2;
using GunRunner_v3.States;

namespace gunrunner.try2
{
    class MainMenuState : MenuState,IGameState
    {
        private IGameState _activeState;

        public MainMenuState()
        {
            _activeState = this;
        }

        public IGameState ActiveState()
        {
            return _activeState;
        }

        public void Draw(GameTime gameTime)
        {
            base.Draw();
        }

        public void Update(GameTime gameTime)
        {
            if (KeyboardMaster.IsKeyPressed(Keys.Escape))
                _activeState = null;
            base.Update();
        }
    }
}
