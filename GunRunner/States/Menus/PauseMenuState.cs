using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using GunRunner_v2;
using GunRunner_v3.States;

namespace gunrunner.try2
{
    class PauseMenuState : MenuState, IGameState
    {
        private GameState _gameState;
        private IGameState _activeState;

        public PauseMenuState(GameState gameState)
        {
            _gameState = gameState;
            _activeState = this;
        }

        public IGameState ActiveState()
        {
            throw new NotImplementedException();
        }

        public void Draw(GameTime gameTime) 
        {
            _gameState.Draw(gameTime); //draw, but dont update
            base.Draw();
        }

        public void Update(GameTime gameTime)
        {
            if (KeyboardMaster.IsKeyPressed(Keys.Escape))
                _activeState = _gameState;

            base.Update();
        }
    }
}
