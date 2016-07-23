using Microsoft.Xna.Framework;

namespace gunrunner.try2
{
    interface IGameState
    {
        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        void Update(GameTime gameTime);

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        void Draw(GameTime gameTime);

        /// <summary>
        /// Set to null to Exit.
        /// </summary>
        /// <returns></returns>
        IGameState ActiveState();
    }
}
