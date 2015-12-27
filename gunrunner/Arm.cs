using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gunrunner
{
    class Arm:Component
    {
        public void HandleInput()
        {
            angle = (float)Math.Atan2(Mouse.GetState().Y-position.Y, Mouse.GetState().X - position.X); 
        }
        public override void Update(GameTime gameTime)
        {
            HandleInput();
            base.Update(gameTime);
        }
        public Arm(ContentManager contentManager, character c):base(contentManager,c)
        {
            parent = c;
            charskin = contentManager.Load<Texture2D>("rect_black");
            vectorToChar = new Vector2(40, 105);
            origin = new Vector2(0,5);
        }

    }
}
