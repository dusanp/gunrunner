using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gunrunner
{
    class Gun:Component
    {
        public Gun(character c):base(c)
        {
            parent = c;
        }
    }
}
