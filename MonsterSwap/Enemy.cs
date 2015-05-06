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
    public class Enemy: GameObject
    {
        //jm
        public Enemy(int x, int y, int width, int height)
            : base(x, y, width, height)
        {
        }

        public bool CheckCollision(GameObject gameObject)
        {
             {
                 if (gameObject.Position.Intersects(this.Position))
                 {
                     return true;
                 }
                 else
                 {
                     return false;
                 }
             }
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);
        }
    }
}
