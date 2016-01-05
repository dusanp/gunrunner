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
    public class World
    {
        public robot MC;
        public List<Floor> floorList;

        public void Update(GameTime gameTime)
        {
            MC.Update(gameTime);
            if (Keyboard.GetState().IsKeyDown(Keys.R)) { MC.position = new Vector2(); MC.velocityY = 0; MC.velocityX = 0; }
        }
        public void Draw()
        {
            MC.Draw(Game1.spriteBatch);
            foreach (Floor f in floorList)
            {
                f.Draw(Game1.spriteBatch);
            }
        }

        public World(ContentManager contentManager)
        {
            MC = new robot(contentManager, Vector2.Zero);
            MC.AddComponent(new Arm(contentManager, MC));
            floorList = new List<Floor>();
            floorList.Add(new Floor(new Vector2(100, 400), contentManager.Load<Texture2D>("rect_black")));
            floorList.Add(new Floor(new Vector2(400, 400), contentManager.Load<Texture2D>("rect_black")));
            floorList.Add(new Floor(new Vector2(700, 450), contentManager.Load<Texture2D>("rect_black")));
            floorList.Add(new Floor(new Vector2(400, 200), contentManager.Load<Texture2D>("rect_black")));
            floorList.Add(new Floor(new Vector2(-200, 400), contentManager.Load<Texture2D>("rect_black")));
        }
        public List<Floor> returnFloors()
        {
            return floorList;
        }
    }
}
