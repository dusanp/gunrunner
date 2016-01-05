using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace gunrunner
{
    public class Character
    {
        public int hp, maxhp;
        public float velocityX, maxvelocityX, velocityY;
        public Vector2 position, screenposition;
        public Texture2D charskin;
        List<Component> compoList;
        public void Fall(GameTime gameTime)
        {
            velocityY += (float)gameTime.ElapsedGameTime.TotalSeconds * 200;
        }
        public bool FloorCollisionCheck()
        {
            bool a = false;
                foreach (Floor f in Game1.world.floorList)
                {
                if ((position.X + charskin.Width > f.position.X && position.X < f.position.X + f.charskin.Width) && (position.Y + charskin.Height >= f.position.Y&& position.Y + charskin.Height <= f.position.Y+f.charskin.Height))
                {
                    a = true;
                }
                }
            return a;
        }
        public virtual void Update(GameTime gameTime)
        {

            if (FloorCollisionCheck() ==false)
            {
                this.Fall(gameTime);
            }
            else
            {
                if (velocityY > 0) { velocityY = 0; }
            }
            position.X += (float)gameTime.ElapsedGameTime.TotalSeconds * velocityX;
            position.Y += (float)gameTime.ElapsedGameTime.TotalSeconds * velocityY;
            foreach (Component c in compoList)
            {
                c.Update(gameTime);
            }

        }

        public void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Draw(charskin, screenposition, Color.White);
            foreach (Component c in compoList)
            {
                c.Draw(spritebatch);
            }
        }
        public void AddComponent(Component c)
        {
            compoList.Add(c);
        }
        public void RemoveComponent(Component c)
        {

        }
        public Character()
        {
            compoList = new List<Component>();
        }
    }
}
