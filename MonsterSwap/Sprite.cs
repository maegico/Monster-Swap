using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace MonsterSwap
{
    class Sprite
    {
        //Position of the sprite
        public Vector2 mPosition = new Vector2(0, 0);

        //Texture of the sprite
        private Texture2D SpriteTexture;

        //Asset name for the sprite to be loaded
        public string AssetName;

        //Size of the sprite
        public Rectangle Size;

        //Used for scaling the size of the sprite
        private float Scale = 1.0f;
        public float scale
        {
            get { return Scale; }
            set
            {
                Scale = value;
                //recalculate the size with the new scale
                Size = new Rectangle(0, 0, (int)(SpriteTexture.Width * Scale),
                    (int)(SpriteTexture.Height * Scale));
            }
        }

        //Loading the texture for the sprite
        public void LoadContent(ContentManager theContentManager, string theAssetName)
        {
            SpriteTexture = theContentManager.Load<Texture2D>(theAssetName);
            AssetName = theAssetName;
            Size = new Rectangle(0, 0, (int)(SpriteTexture.Width * Scale),
                (int)(SpriteTexture.Height * Scale));
        }

        //Draws the sprite to the screen
        public void Draw(SpriteBatch theSpriteBatch)
        {
            theSpriteBatch.Draw(SpriteTexture, mPosition,
                new Rectangle(0, 0, SpriteTexture.Width, SpriteTexture.Height),
                Color.White, 0.0f, Vector2.Zero, Scale, SpriteEffects.None, 0);
        }

        //Update sprite location and speed
        public void Update(GameTime theGameTime, Vector2 theSpeed, Vector2 theDirection)
        {
            #region Problem code
            /*mPosition += theDirection * theSpeed *
                (float)theGameTime.ElapsedGameTime.TotalSeconds;*/
            #endregion
        }
    }
}
