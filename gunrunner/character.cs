using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace gunrunner
{
    class character
    {
        public int hp, maxhp;
        public float velocityX, maxvelocityX, velocityY;
        public Vector2 position;
        public Texture2D charskin;
        List<Component> compoList;
        public void Fall(GameTime gameTime)
        {
            velocityY += (float)gameTime.ElapsedGameTime.TotalSeconds * 50;
        }
        public bool FloorCollisionCheck()
        {
            return true;
        }
        public virtual void Update(GameTime gameTime)
        {

            if (FloorCollisionCheck()==false)
            {
                this.Fall(gameTime);
            }
            position.X += (float)gameTime.ElapsedGameTime.TotalSeconds * velocityX;
            position.Y += (float)gameTime.ElapsedGameTime.TotalSeconds * velocityY;

        }

        public void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Draw(charskin, position, Color.White);
        }
        public void AddComponent(Component c)
        {
            compoList.Add(c);
        }
        public void RemoveComponent(Component c)
        {

        }
        public character()
        {
            compoList = new List<Component>();
        }
    }
}
