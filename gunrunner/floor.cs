using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//TODO: prozatimni
namespace gunrunner
{
    public class Floor
    {
        public Vector2 position;
        public Texture2D charskin;
        Rectangle r;
        public void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Draw(charskin, position, Color.White);
        }
        public Floor(Vector2 p, Texture2D t)
        {
            position = p;
            charskin = t;
            r = new Rectangle((int)position.X,(int)position.Y,charskin.Width,charskin.Height);
            


        }
    }
}
