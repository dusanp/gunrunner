using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using LilyPath;
using GunRunner_v2.States.Transitions;

namespace gunrunner.try2
{
    class GameMaster:Game
    {
        public static GameMaster Self;
        private IGameState _state;
        public GraphicsDeviceManager graphics;
        public SpriteBatch spriteBatch;
        public DrawBatch drawBatch;
        public SpriteFont CourierNew;

        public GameMaster()
        {
            graphics = new GraphicsDeviceManager(this);
            Self = this;
            Content.RootDirectory = "Content";
        }
        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            _state = new BlackoutTransitionState(new MainMenuState(), new GameState(),1000);
            spriteBatch = new SpriteBatch(GraphicsDevice);
            drawBatch = new DrawBatch(GraphicsDevice);
            CourierNew = Content.Load<SpriteFont>("Courier New");
        }

        #region Load/Unload
        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {

        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            spriteBatch.Dispose();
            drawBatch.Dispose();
        }
        #endregion

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            _state.Update(gameTime);
            _state = _state.ActiveState();
            if (_state == null) Exit();
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.White);
            spriteBatch.Begin(blendState: BlendState.AlphaBlend);
            drawBatch.Begin();
            _state.Draw(gameTime);
            spriteBatch.End();
            drawBatch.End();
        }
    }
}
