using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MonsterSwap
{
    public class GameObject
    {
        Rectangle position;
        Texture2D texture;
        //assigns the position and size of objects
        public GameObject(int x, int y, int width, int height)
        {
            position = new Rectangle(x,y,width,height);
        }
        //draws the objects
        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, Color.White);
        }

        public Rectangle Position
        {
            get { return position; }
            set { position = value; }
        }

        public Texture2D Texture
        {
            get { return texture; }
            set { texture = value; }
        }

        public int X
        {
            get { return position.X; }
            set { position.X = value; }
        }

        public int Y
        {
            get { return position.Y; }
            set { position.Y = value; }
        }
    }
}
