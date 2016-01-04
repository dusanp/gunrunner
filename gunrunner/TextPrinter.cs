using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gunrunner
{
    public class TextPrinter
    {
        SpriteFont CourierNew;
        public void drawText(string text, Vector2 position, SpriteBatch spriteBatch)
        {
            spriteBatch.DrawString(CourierNew, text, position, Color.Red);
        }
        public TextPrinter (ContentManager contentManager)
        {
            CourierNew = contentManager.Load<SpriteFont>("Courier New");

        }
    }
}
