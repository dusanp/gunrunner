using Microsoft.Xna.Framework;
using GunRunner_v3.States;
using GunRunner_v2;
using Microsoft.Xna.Framework.Input;

namespace gunrunner.try2.States
{
    class SettingsMenuState : MenuState, IGameState
    {
        private IGameState _activeState;
        private IGameState _sourceState;
        public SettingsMenuState(IGameState sourceState)
        {
            _activeState = this;
            _sourceState = sourceState;
        }
        public IGameState ActiveState()
        {
            return _activeState;
        }

        public void Draw(GameTime gameTime)
        {
            //draw background
            base.Draw();
        }

        public void Update(GameTime gameTime)
        {
            if (KeyboardMaster.IsKeyPressed(Keys.Escape))
                _activeState = _sourceState;
            base.Update();
        }
    }
}
