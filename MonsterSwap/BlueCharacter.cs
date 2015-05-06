using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace MonsterSwap
{
    class BlueCharacter : Sprite
    {

        ///To Implement, first initialize in Initialize method in Game1
        ///Then call classe's LoadContent in Game1 LoadContent
        ///Then call classe's Update in Game1 Update
        ///Finally Call Draw in Game1 Draw

        Game1 game;

        public BlueCharacter(Game1 _game)
        {
            game = _game;
        }

        //determines the direction of movement
        Vector2 Direction = Vector2.Zero;

        //determines the rate of movement
        Vector2 Speed = Vector2.Zero;

        //determines the position the sprite starts
        //int StartingPosition = 0;


        //constant values for the character
        const string BLUECHARACTERASSET = "Textures/Character1small1";//file name for texture
        const int STARTPOSITION_X = 64;
        const int STARTPOSITION_Y = (64 * 6);
        const int BLUECHARACTERSPEED = 32;
        //these are constant for all characters
        const int MOVE_UP = -1;
        const int MOVE_DOWN = 1;
        const int MOVE_LEFT = -1;
        const int MOVE_RIGHT = 1;

        bool jumping;
        double jumpspeed = 0;

        //Loads Texture + Position
        public void LoadContent(ContentManager theContentManager)
        {
            mPosition = new Vector2(STARTPOSITION_X, STARTPOSITION_Y);
            base.LoadContent(theContentManager, BLUECHARACTERASSET);
        }

        //Updates Location + Speed
        public void Update(GameTime theGameTime)
        {
            #region Extra Movement
            //UpdateMovement(aCurrentKeyboardState);
            //UpdateJump(aCurrentKeyboardState);
            #endregion

            //attempting to intigrate character tile movment
            game.kStateCurrent = Keyboard.GetState();
            game.mState = Mouse.GetState();

            //method controling horizontal movmement
            UpdateMovement(game.kStateCurrent);

            //method controling vertical movement
            UpdateJump(game.kStateCurrent, theGameTime);


            //quitting and pausing 
            if (game.kStateCurrent.IsKeyDown(Keys.Escape))
            {
                game.state = new PauseState();
                game.state.SetGame(game);
            }
            game.kStatePrevious = game.kStateCurrent;


            //changing charcters
            if (game.kStateCurrent.IsKeyDown(Keys.Up))
            {
                game.x = 1;

            }
            if (game.kStateCurrent.IsKeyDown(Keys.Right))
            {
                game.x = 0;

            }
            if (game.kStateCurrent.IsKeyDown(Keys.Left))
            {
                game.x = 2;
            }
            game.kStatePrevious = game.kStateCurrent;



            foreach (Enemy e in game.enemies)
            {
                e.Position = new Rectangle(e.Position.X - 2, e.Position.Y, e.Position.Width, e.Position.Height);
            }

            base.Update(theGameTime, Speed, Direction);
        }

        //method controling horizontal movmement
        public void UpdateMovement(KeyboardState CurrentKey)
        {
            if (CurrentKey.IsKeyDown(Keys.A))
            {
                for (int t = 0; t < game.tiles.Count; t++)
                {
                    game.tiles[t].m_Rectangle = new Rectangle(game.tiles[t].m_Rectangle.X++, game.tiles[t].m_Rectangle.Y, game.tiles[t].m_Rectangle.Width, game.tiles[t].m_Rectangle.Height);
                }

                foreach (Enemy e in game.enemies)
                {
                    e.Position = new Rectangle(e.Position.X + 8, e.Position.Y, e.Position.Width, e.Position.Height);
                }
                foreach (Tile tile in game.tiles)
                {
                    if (game.tiles[0].R.X < 0)
                    {
                        game.walkingAnimation += 0.00005;
                    }
                    if (game.walkingAnimation <= 4)
                    {
                        game.walkingAnimation += 0.00005;
                    }

                    if (game.walkingAnimation > 4)
                    {
                        game.walkingAnimation = 0;
                    }
                    tile.R = new Rectangle(tile.R.X + 8, tile.R.Y, tile.R.Width, tile.R.Height);
                    game.eggRectangle = new Rectangle(game.eggRectangle.X + 8, game.eggRectangle.Y, game.eggRectangle.Width, game.eggRectangle.Height);
                    if (tile.T == game.b1 ||
                        tile.T == game.b2 ||
                        tile.T == game.b3)
                    {
                        if (tile.m_Rectangle.Intersects(game.character.Position))
                            tile.R = new Rectangle(tile.R.X + 8, tile.R.Y, tile.R.Width, tile.R.Height);
                        if (tile.T == game.b1 ||
                            tile.T == game.b2 ||
                            tile.T == game.b3)
                        {
                            if (tile.m_Rectangle.Intersects(game.character.Position))
                            {
                                tile.R = new Rectangle(tile.R.X - 8, tile.R.Y, tile.R.Width, tile.R.Height);

                                game.eggRectangle = new Rectangle(game.eggRectangle.X - 8, game.eggRectangle.Y, game.eggRectangle.Width, game.eggRectangle.Height);
                                foreach (Tile t in game.tiles)
                                {
                                    t.R = new Rectangle(t.R.X - 8, t.R.Y, t.R.Width, t.R.Height);
                                }
                            }



                        }
                    }
                }
            }
            else if (CurrentKey.IsKeyDown(Keys.D))
            {
                foreach (Enemy e in game.enemies)
                {
                    e.Position = new Rectangle(e.Position.X - 8, e.Position.Y, e.Position.Width, e.Position.Height);
                }
                foreach (Tile tile in game.tiles)
                {
                    if (game.tiles[game.tiles.Count - 2].R.X > 64 * 12)
                    {

                        game.walkingAnimation += 0.00005;
                    }
                    if (game.walkingAnimation <= 4)
                    {
                        game.walkingAnimation += 0.00005;
                    }

                    if (game.walkingAnimation > 4)
                    {
                        game.walkingAnimation = 0;
                    }

                    tile.R = new Rectangle(tile.R.X - 8, tile.R.Y, tile.R.Width, tile.R.Height);

                    game.eggRectangle = new Rectangle(game.eggRectangle.X - 8, game.eggRectangle.Y, game.eggRectangle.Width, game.eggRectangle.Height);
                    if (tile.T == game.b1 ||
                        tile.T == game.b2 ||
                        tile.T == game.b3)
                    {
                        if (tile.m_Rectangle.Intersects(game.character.Position))
                            tile.R = new Rectangle(tile.R.X - 8, tile.R.Y, tile.R.Width, tile.R.Height);
                        if (tile.T == game.b1 ||
                            tile.T == game.b2 ||
                            tile.T == game.b3)
                        {
                            if (tile.m_Rectangle.Intersects(game.character.Position))
                            {
                                tile.R = new Rectangle(tile.R.X + 8, tile.R.Y, tile.R.Width, tile.R.Height);

                                foreach (Tile t in game.tiles)
                                {
                                    t.R = new Rectangle(t.R.X + 8, t.R.Y, t.R.Width, t.R.Height);
                                }
                            }
                        }
                    }
                }
            }
        }

        //method controling vertical movement
        public void UpdateJump(KeyboardState CurrentKey, GameTime gameTime)
        {
            if (jumping)
            {
                game.character.Y -= (int)jumpspeed;
                jumpspeed -= .5; //decrement

                if (jumpspeed == 0)
                    jumping = false;
            }
            else
            {
                if (CurrentKey.IsKeyDown(Keys.Space) && game.Collision() && !jumping)
                {
                    jumping = true;
                    jumpspeed = 24;//speed
                }
            }
        }
    }
}
