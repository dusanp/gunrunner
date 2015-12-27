using Microsoft.Xna.Framework.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gunrunner
{
    class Gun:Component
    {
        public Gun(ContentManager contentManager, character c):base(contentManager,c)
        {
            parent = c;
        }
    }
}
