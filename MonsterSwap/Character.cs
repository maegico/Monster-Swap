using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.GamerServices;

namespace MonsterSwap
{
    public class Character: GameObject
    {
        public Character(int x, int y, int width, int height)
            :base(x, y, width, height)
        {
        }
    }
}
