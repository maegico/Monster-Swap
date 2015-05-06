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
    public class MenuState: IState
    {
        Game1 game;
        GameTime gameTime;

        public void SetGame(Game1 _game)
        {
            game = _game;
        }

        public void SetTime(GameTime _time)
        {
            gameTime = _time;
        }

        public void Update()
        {
            Input();
        }

        public void Draw()
        {
            game.gameObject.Texture = game.backgroundMenu;
            game.gameObject.Draw(game.spriteBatch);
            game.fontVector2 = new Vector2(game.GraphicsDevice.Viewport.Width / 2 - 130, game.GraphicsDevice.Viewport.Height  - 90);
            game.spriteBatch.DrawString(game.font, "Press Enter to Begin", game.fontVector2, Color.Brown);
            game.fontVector2 = new Vector2(game.GraphicsDevice.Viewport.Width / 2 - 130, game.GraphicsDevice.Viewport.Height - 40);
            game.spriteBatch.DrawString(game.font, "Made by: Sean, Wyatt, Jeremy, James.", game.fontVector2, Color.Crimson);
        }
        public void Input()
        {
            if (game.redo == true)
            {
                game.lives = 16;
                game.HiScore = 0;
            }

            else
            {
                game.lives = 15;
                game.HiScore = 0;
            }

            game.kStateCurrent = Keyboard.GetState();
            game.mState = Mouse.GetState();
            

            if (game.kStateCurrent.IsKeyDown(Keys.Enter))
            {
                game.state = game.gameState;
                game.state.SetGame(game);
            }
        }
    }
}
