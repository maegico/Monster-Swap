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
    public class PauseState: IState
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
            game.GraphicsDevice.Clear(Color.Black);
            game.fontVector2 = new Vector2(game.GraphicsDevice.Viewport.Width / 2 - 100, game.GraphicsDevice.Viewport.Height / 2 - 100);
            game.spriteBatch.DrawString(game.font, "Do You Want to Continue?\n\nY: Yes  N: No", game.fontVector2, Color.White);
        }
        public void Input()
        {
            game.kStateCurrent = Keyboard.GetState();
            game.mState = Mouse.GetState();

            if (game.kStateCurrent.IsKeyDown(Keys.N))
            {
                game.state = new GameOverState();
                game.state.SetGame(game);
            }
            if (game.kStateCurrent.IsKeyDown(Keys.Y))
            {
                game.state = game.gameState;
                game.state.SetGame(game);
            }
        }
    }
}
