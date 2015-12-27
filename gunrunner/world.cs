using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gunrunner
{
    class World
    {
        robot MC;
        public List<floor> floorList;

        public void Update(GameTime gameTime)
        {
            MC.Update(gameTime, floorList);
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            MC.Draw(spriteBatch);
            foreach (floor f in floorList)
            {
                f.Draw(spriteBatch);
            }
        }

        public World(ContentManager contentManager)
        {
            MC = new robot(contentManager, Vector2.Zero);
            MC.AddComponent(new Arm(contentManager, MC));
            floorList = new List<floor>();
            floorList.Add(new floor(new Vector2(100, 400), contentManager.Load<Texture2D>("rect_black")));
            floorList.Add(new floor(new Vector2(400, 400), contentManager.Load<Texture2D>("rect_black")));
            floorList.Add(new floor(new Vector2(700, 450), contentManager.Load<Texture2D>("rect_black")));
            floorList.Add(new floor(new Vector2(400, 200), contentManager.Load<Texture2D>("rect_black")));
        }
        public List<floor> returnFloors()
        {
            return floorList;
        }
    }
}
