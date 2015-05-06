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
    public class GameState: IState
    {

        Game1 game;
        GameTime gameTime;
        BlueCharacter blue;

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

            foreach (Enemy e in game.enemies)
            {
                if (e.Position.X < -192)
                {
                    e.Position = new Rectangle(game.GraphicsDevice.Viewport.Width, game.rand.Next(0, 64 * 6), 64, 64);
                }
                if (e.CheckCollision(game.character))
                {
                    game.lives--;
                    e.Position = new Rectangle(e.Position.X, -128, e.Position.Width, e.Position.Height);

                    if (game.lives <= 0)
                    {
                        game.state = new GameOverState();
                        game.state.SetGame(game);
                    }
                }
            }
            Collecting();
            NewLevel();
            if(blue ==null)
                blue = new BlueCharacter(game);
            blue.Update(gameTime);
        }
        public void Draw()
        {
            game.gameObject.Texture = game.backgroundGame;
            game.gameObject.Draw(game.spriteBatch);
            if (game.x == 0)
            {
                game.character.Texture = game.player;

                if (game.walkingAnimation <= 1 && game.walkingAnimation > 0)
                {
                    game.character.Texture = game.p1Walk1;
                    
                }
                if (game.walkingAnimation <= 2 && game.walkingAnimation > 1)
                {
                    game.character.Texture = game.p1Walk2;
                    
                }
                if (game.walkingAnimation <= 3 && game.walkingAnimation > 2)
                {
                    game.character.Texture = game.p1Walk3;
                    
                }
                /////
                if (game.walkingAnimation <= 1 && game.walkingAnimation > 0)
                {
                    game.enemy = game.enemy2;

                }
                if (game.walkingAnimation <= 2 && game.walkingAnimation > 1)
                {
                    game.enemy = game.flyingEnemyA1;

                }
                if (game.walkingAnimation <= 3 && game.walkingAnimation > 2)
                {
                    game.enemy = game.flyingEnemyA1;

                }
            }
            if (game.x == 1)
            {
                game.character.Texture = game.player2;

                if (game.walkingAnimation <= 1 && game.walkingAnimation > 0)
                {
                    game.character.Texture = game.p2Walk1;
                }
                if (game.walkingAnimation <= 2 && game.walkingAnimation > 1)
                {
                    game.character.Texture = game.p2Walk2;
                }

                if (game.walkingAnimation <= 3 && game.walkingAnimation > 2)
                {
                    game.character.Texture = game.p2Walk1;
                }
            }
            if (game.x == 2)
            {
                game.character.Texture = game.player3;
                if (game.walkingAnimation <= 1 && game.walkingAnimation > 0)
                {
                    game.character.Texture = game.p3Walk2;
                }
                if (game.walkingAnimation <= 2 && game.walkingAnimation > 1)
                {
                    game.character.Texture = game.player3;
                }

                if (game.walkingAnimation <= 3 && game.walkingAnimation > 2)
                {
                    game.character.Texture = game.p3Walk2;
                }
            }
            game.spriteBatch.Draw(game.character.Texture, game.character.Position, Color.White);
            game.spriteBatch.DrawString(game.font, "Lives: " + game.lives, new Vector2(10, 10), Color.Black);
            game.spriteBatch.DrawString(game.font, "Score: " + game.HiScore, new Vector2(10, 30), Color.Black);
            game.spriteBatch.DrawString(game.font, "Level: " + game.level, new Vector2(game.GraphicsDevice.Viewport.Width/2 - 50, 10), Color.Black);


            
            for (int i = 0; i < game.tiles.Count - 1; i++)
            {
                game.spriteBatch.Draw(game.tiles[i].T, game.tiles[i].m_Rectangle, Color.White);
            }
            foreach (Enemy e in game.enemies)
            {
                game.spriteBatch.Draw(e.Texture, e.Position, Color.White);
            }

            /*
             * public void Draw()
        {
            game.gameObject.Texture = game.backgroundGame;
            game.gameObject.Draw(game.spriteBatch);
            if (game.x == 0)
            {
                game.character.Texture = game.player;

                if (game.walkingAnimation <= 1 && game.walkingAnimation > 0)
                {
                    game.character.Texture = game.p1Walk1;
                }
                if (game.walkingAnimation <= 2 && game.walkingAnimation > 1)
                {
                    game.character.Texture = game.p1Walk2;
                }
                if (game.walkingAnimation <= 3 && game.walkingAnimation > 2)
                {
                    game.character.Texture = game.p1Walk3;
                }
            }
            if (game.x == 1)
            {
                game.character.Texture = game.player2;

                if (game.walkingAnimation <= 1 && game.walkingAnimation > 0)
                {
                    game.character.Texture = game.p2Walk1;
                }
                if (game.walkingAnimation <= 2 && game.walkingAnimation > 1)
                {
                    game.character.Texture = game.p2Walk2;
                }

                if (game.walkingAnimation <= 3 && game.walkingAnimation > 2)
                {
                    game.character.Texture = game.p2Walk1;
                }
                
            }
            if (game.x == 2)
            {
                game.character.Texture = game.player3;
                if (game.walkingAnimation <= 1 && game.walkingAnimation > 0)
                {
                    game.character.Texture = game.p3Walk1;
                }
                if (game.walkingAnimation <= 2 && game.walkingAnimation > 1)
                {
                    game.character.Texture = game.p3Walk2;
                }

                if (game.walkingAnimation <= 3 && game.walkingAnimation > 2)
                {
                    game.character.Texture = game.p3Walk1;
                }
            }
             */
        }

        public void Collecting()
        {
            foreach (Tile t in game.tiles)
            {
                if (game.character.Position.Intersects(t.R) && t.T == game.eggCollectible)
                {
                    t.T = game.b4;
                    game.HiScore += 100;
                }
            }
        }

        public void NewLevel()
        {
            if (game.tiles[game.tiles.Count - 4].R.X <= 64 * 12)
            {
                if (game.level == 1)
                {
                    game.level = 2;
                }
                else if (game.level == 2)
                {
                    game.level = 3;
                }
                else
                {
                    game.level = 4;
                }
                while(game.tileReset.Count > 0)
                {
                    game.tileReset.Remove(game.tileReset[game.tileReset.Count - 1]);
                }
                while (game.tiles.Count > 0)
                {
                    game.tiles.Remove(game.tiles[game.tiles.Count - 1]);
                }
                game.NewLevel();
                int n = 0;
                foreach (Tile t in game.tiles)
                {
                    t.R = new Rectangle(game.tileReset[n], t.R.Y, t.R.Width, t.R.Height);
                    n++;
                }
                game.character.Position = new Rectangle(64 * 4, 64 * 6 - 1, 64, 64);
            }
        }
    }
}
