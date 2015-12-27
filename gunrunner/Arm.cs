using Microsoft.Xna.Framework;
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
        public Arm(character c):base(c)
        {
            parent = c;
        }

    }
}
