using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gunrunner
{
    class World
    {
        robot MC;

        public void Update(GameTime gameTime)
        {
            MC.Update(gameTime);
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            MC.Draw(spriteBatch);
        }

        public World(ContentManager contentManager)
        {
            MC = new robot(contentManager, Vector2.Zero);
        }
    }
}
