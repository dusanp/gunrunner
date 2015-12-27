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
            velocityY += (float)gameTime.ElapsedGameTime.TotalSeconds * 200;
        }
        public bool FloorCollisionCheck(List<floor> floorList)
        {
            bool a = false;
                foreach (floor f in floorList)
                {
                if ((position.X + charskin.Width > f.position.X && position.X < f.position.X + f.charskin.Width) && (position.Y + charskin.Height >= f.position.Y&& position.Y + charskin.Height <= f.position.Y+f.charskin.Height))
                {
                    a = true;
                }
                }
            return a;
        }
        public virtual void Update(GameTime gameTime, List<floor> floorList)
        {

            if (FloorCollisionCheck(floorList)==false)
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
            spritebatch.Draw(charskin, position, Color.White);
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
        public character()
        {
            compoList = new List<Component>();
        }
    }
}
