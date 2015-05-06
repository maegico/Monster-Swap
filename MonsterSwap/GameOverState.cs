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
    public class GameOverState: IState
    {
        Game1 game;
        GameTime gameTime;

        public void SetGame(Game1 _game)
        {
            game = _game;

            int n = 0;
            foreach (Tile t in game.tiles)
            {
                t.R = new Rectangle(game.tileReset[n], t.R.Y, t.R.Width, t.R.Height);
                n++;
            }
            game.character.Position = new Rectangle(64 * 4, 64 * 6 - 1, 64, 64);
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
            game.gameObject.Texture = game.backgroundGameOver;
            game.gameObject.Draw(game.spriteBatch);
            game.fontVector2 = new Vector2(game.GraphicsDevice.Viewport.Width / 2 - 150, game.GraphicsDevice.Viewport.Height / 2 + 150);
            game.spriteBatch.DrawString(game.font, "Press C to Go Back to the Main Menu.", game.fontVector2, Color.Red);   //                  Game Over\n\n\n
        }
        public void Input()
        {
            game.kStateCurrent = Keyboard.GetState();
            game.mState = Mouse.GetState();

            if (game.kStateCurrent.IsKeyDown(Keys.C))
            {
                game.state = new MenuState();
                game.state.SetGame(game);
            }
        }
    }
}
