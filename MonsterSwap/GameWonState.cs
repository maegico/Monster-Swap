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
    class GameWonState: IState
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
            game.gameObject.Texture = game.backgroundGameWon;
            game.gameObject.Draw(game.spriteBatch);
            game.fontVector2 = new Vector2(game.GraphicsDevice.Viewport.Width / 2 - 150, game.GraphicsDevice.Viewport.Height/2 - 70);
            game.spriteBatch.DrawString(game.font, "Press c to go to back to the Main Menu.", game.fontVector2, Color.Crimson);
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
