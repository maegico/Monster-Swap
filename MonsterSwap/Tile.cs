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
    public class Tile
    {
        public Rectangle m_Rectangle;
        public String m_sFileName;
        public Texture2D m_Texture2D;
        public int m_nSize = 64;

        public Tile(String fileName)
        {
            m_sFileName = fileName;
            m_Rectangle = new Rectangle(0, 0, m_nSize, m_nSize);
            
        }

        public Rectangle R
        {
            get
            {
                return m_Rectangle;
            }
            set
            {
                m_Rectangle = value;
            }
        }

        public Texture2D T
        {
            get { return m_Texture2D; }
            set { m_Texture2D = value; }
        }

        public bool CheckCollision(GameObject gameObject, Texture2D b)
        {
            {
                if (gameObject.Position.Intersects(this.R) && this.T != b)
                {

                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
