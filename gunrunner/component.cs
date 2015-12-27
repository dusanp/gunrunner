using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gunrunner
{
    class Component
    {
        public Vector2 vectorToChar, position, origin;
        public Texture2D charskin;
        public character parent;
        public float angle;

        public virtual void Update(GameTime gameTime)
        {

            position = parent.position + vectorToChar;

        }

        public void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Draw(charskin, position, null, Color.White, angle, origin, 1f,SpriteEffects.None,0);
        }
        public Component(ContentManager contentManager, character c)
        {
            parent = c;
            angle = 0;
        }
    }
}
