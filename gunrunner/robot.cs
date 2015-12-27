using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

namespace gunrunner
{
    class robot: character
    {
        
        public void HandleInput()
        {
            if (Keyboard.GetState().IsKeyDown(Keys.A)&& Keyboard.GetState().IsKeyDown(Keys.D)) { velocityX = 0; }
            else if (Keyboard.GetState().IsKeyDown(Keys.A)) { velocityX = -1 * maxvelocityX; }
            else if (Keyboard.GetState().IsKeyDown(Keys.D)) { velocityX = maxvelocityX; }
            else { velocityX = 0; }
        }
        public override void Update(GameTime gameTime)
        {
            HandleInput();
            base.Update(gameTime);
        }
        public robot (ContentManager contentManager, Vector2 p)
        {
            this.charskin = contentManager.Load<Texture2D>("MC_torsoS");
            maxhp = 100;
            hp = maxhp;
            position = p;
            maxvelocityX = 200;
            velocityX = 0;
            
        }
    }
}
