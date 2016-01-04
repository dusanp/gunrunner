using Microsoft.Xna.Framework.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gunrunner
{
    public class Gun:Component
    {
        public Gun(ContentManager contentManager, Character c):base(contentManager,c)
        {
            parent = c;
        }
    }
}
