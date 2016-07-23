using gunrunner.try2;
using System;
using Microsoft.Xna.Framework;
using LilyPath;

namespace GunRunner_v2.States.Transitions
{
    class BlackoutTransitionState : IGameState
    {
        private IGameState _targetState;
        private IGameState _sourceState;
        private IGameState _activeState;
        private IGameState _drawnState;
        private double? startMs;
        private double _fadeDuration;
        private float alpha = 0;

        public BlackoutTransitionState(IGameState sourceState, IGameState targetState, double fadeDuration = 1000)
        {
            _targetState = targetState;
            _sourceState = sourceState;
            _fadeDuration = fadeDuration;
            _activeState = this;
            _drawnState = sourceState;
        }

        public IGameState ActiveState()
        {
            return _activeState;
        }

        public void Draw(GameTime gameTime)//todo eliminate reinitialisation performance
        {
            _drawnState.Draw(gameTime);
            GameMaster.Self.drawBatch.FillRectangle(new SolidColorBrush(Color.Black * alpha), new Rectangle(0, 0, GameMaster.Self.GraphicsDevice.DisplayMode.Width, GameMaster.Self.GraphicsDevice.DisplayMode.Height));//todo fix displaymode
        }

        public void Update(GameTime gameTime)
        {
            if (startMs == null) startMs = gameTime.ElapsedGameTime.TotalMilliseconds;
            double durationMs = gameTime.TotalGameTime.TotalMilliseconds- startMs.Value;
            alpha = (float)(-2*Math.Abs((durationMs / _fadeDuration)-0.5)+1);
            if (durationMs > _fadeDuration / 2) _drawnState = _targetState;
            if (durationMs > _fadeDuration) _activeState = _targetState;
        }
    }
}
