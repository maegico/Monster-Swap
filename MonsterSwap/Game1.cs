#region Using Statements
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.GamerServices;
using System.IO;
#endregion

namespace MonsterSwap
{
	/// <summary>
	/// This is the main type for your game
	/// </summary>
	public class Game1 : Game
	{
        //jm
		public GraphicsDeviceManager graphics;
		public SpriteBatch spriteBatch;
        public GameObject gameObject;
        
        //Font
        public SpriteFont font;
        public Vector2 fontVector2;
        
        //Background
        public Texture2D backgroundMenu;
        public Texture2D backgroundGame;
        public Texture2D backgroundPause;
        public Texture2D backgroundGameOver;
        public Texture2D backgroundGameWon;


        //Player
		public Texture2D player;
        public Texture2D p1Walk1;
        public Texture2D p1Walk2;
        public Texture2D p1Walk3;
        public Texture2D player2;
        public Texture2D player3;
        public int x = 0;
        public double walkingAnimation = 0;
        
        public Character character;
        public int lives;
        public bool redo;
        public int end;

        protected int hiScore;
        public string map;
        public int level;

        ///////////////player2
        public Texture2D p2Walk1;
        public Texture2D p2Walk2;
        ///////////////player3
        public Texture2D p3Walk1;
        public Texture2D p3Walk2;
        
        //Enemies
		public int nEnemies;
		public Texture2D enemy;
        public Texture2D enemy2;
        public Texture2D flyingEnemyA1;
        public Texture2D flyingEnemyA2;
        public List<Enemy> enemies;
        
        //Blocks or Tiles
        public int nBlocks;
        public List<Tile> tiles;
        public List<int> tileReset;
        public Texture2D b1;
        public Texture2D b2;
        public Texture2D b3;
        public Texture2D b4;
        public Texture2D eggCollectible;
        public Texture2D eggGoal;
        public Rectangle eggRectangle;
        public int reset;
        public bool useMap;
        
        //Input State
		public KeyboardState kStateCurrent;
		public KeyboardState kStatePrevious;
		public MouseState mState;

        //Map editor object
        //public MapEditorTool o_MapEditorTool;
	    public Random rand = new Random();

        public IState state;
        public GameState gameState;

		public Game1()
			: base()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            //Windows width and height
            graphics.PreferredBackBufferWidth = 64 * 12;
            graphics.PreferredBackBufferHeight = 64 * 8;
            gameObject = new GameObject(0, 0, 64 * 12, 64 * 8);
            //o_MapEditorTool = new MapEditorTool();
            nBlocks = 12;
            lives = 15;
            redo = false;
            end = 0;
            reset = 0;
            hiScore = 0;
            level = 1;

            state = new MenuState();
            state.SetGame(this);

            gameState = new GameState();
            useMap = false;
        }

		/// <summary>
		/// Allows the game to perform any initialization it needs to before starting to run.
		/// This is where it can query for any required services and load any non-graphic
		/// related content.  Calling base.Initialize will enumerate through any components
		/// and initialize them as well.
		/// </summary>
		protected override void Initialize()
		{
			// Initialize the position to be centered vertically
			int width = graphics.GraphicsDevice.PresentationParameters.BackBufferWidth;
			int height = graphics.GraphicsDevice.PresentationParameters.BackBufferHeight;
            //List of enemies, currently one
            enemies = new List<Enemy>();
			nEnemies = 2;
            //sets position of character
            character = new Character(64*4, 64*6, 64, 64);
            tiles = new List<Tile>();
            tileReset = new List<int>();
			
			base.Initialize();
		}

		/// <summary>
		/// LoadContent will be called once per game and is the place to load
		/// all of your content.
		/// </summary>
		protected override void LoadContent()
		{
			// Create a new SpriteBatch, which can be used to draw textures.
			spriteBatch = new SpriteBatch(GraphicsDevice);
            //background
            backgroundMenu = this.Content.Load<Texture2D>("Textures/CoverArt");
            backgroundGame = this.Content.Load <Texture2D>("Textures/MS Background");
            backgroundPause = this.Content.Load<Texture2D>("Textures/MS Background");
            backgroundGameOver = this.Content.Load<Texture2D>("Textures/YouDied");
            backgroundGameWon = this.Content.Load<Texture2D>("Textures/WinScreen");

			//Font
			font = this.Content.Load<SpriteFont>("SpriteFont1");
			//player
			player = this.Content.Load<Texture2D>("Textures/Character1small1");
            player2 = this.Content.Load<Texture2D>("Textures/Charater2small");
            player3 = this.Content.Load<Texture2D>("Textures/Character3fit");
            p1Walk1 = this.Content.Load<Texture2D>("Textures/fittedWalkingAction1");
            p1Walk2 = this.Content.Load<Texture2D>("Textures/fittedWalkingAction2");
            p1Walk3 = this.Content.Load<Texture2D>("Textures/fittedWalkingAction3");

            //player2
            p2Walk1 = this.Content.Load<Texture2D>("Textures/Character2Action1Fit");
            p2Walk2 = this.Content.Load<Texture2D>("Textures/Character2Action2Fit");
            //player3
            //p3Walk1 = this.Content.Load<Texture2D>("Textures/Character3WalkingAction1Fit");
            p3Walk2 = this.Content.Load<Texture2D>("Textures/Character3WalkingAction2Fit");
			//enemies
            enemy = this.Content.Load<Texture2D>("Textures/flyingEnemy");
            enemy2 = this.Content.Load<Texture2D>("Textures/flyingEnemy");
            flyingEnemyA1 = this.Content.Load<Texture2D>("Textures/flyingEnemyAction1fit");
            flyingEnemyA2 = this.Content.Load<Texture2D>("Textures/flyingEnemyAction2fit");

            //block
            b1 = this.Content.Load<Texture2D>("Textures/Tiles/finalBlock");
            b2 = this.Content.Load<Texture2D>("Textures/Tiles/finalBlock2");
            b3 = this.Content.Load<Texture2D>("Textures/Tiles/finalBlock3");
            b4 = this.Content.Load<Texture2D>("Textures/Tiles/BlockClear");
            //collectibles
            eggCollectible = this.Content.Load<Texture2D>("Textures/CharacterEgg");
            eggGoal = this.Content.Load<Texture2D>("Textures/BigCharacterEgg");
            eggRectangle = new Rectangle(64, 64 * 3, 200, 200);



			for (int i = 0; i < nEnemies; i++)
			{
                enemies.Add(new Enemy(GraphicsDevice.Viewport.Width, rand.Next(0, 64 * 6), 64, 64));
			}


            foreach (Enemy e in enemies)
            {
                e.Texture = enemy;
            }

            
            NewLevel();

            


		}

		/// <summary>
		/// UnloadContent will be called once per game and is the place to unload
		/// all content.
		/// </summary>
		protected override void UnloadContent()
		{
			// TODO: Unload any non ContentManager content here
		}

		/// <summary>
		/// Allows the game to run logic such as updating the world,
		/// checking for collisions, gathering input, and playing audio
		/// </summary>
		/// <param name="gameTime">Provides a snapshot of timing values.</param>
		protected override void Update(GameTime gameTime)
		{
			if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
				Exit();

            state.Update();

            //returns the character to the screen
            if (character.Position.X > this.GraphicsDevice.Viewport.Width - 64)
            {
                character.Position = new Rectangle(GraphicsDevice.Viewport.Width - 64, character.Position.Y, character.Position.Width, character.Position.Height);
            }

            if (character.Position.X < 0)
            {

                character.Position = new Rectangle(0, character.Position.Y, character.Position.Width, character.Position.Height);
            }
            bool col = false;
            if (Gravity())
            {
                for (int fall = 1; fall < 8; fall++)
                {
                    foreach (Tile t in tiles)
                    {
                        if (character.Position.Y + character.Position.Height == t.R.Y && t.T != b4 && t.T != eggCollectible)
                        {
                            if ((character.Position.X >= t.R.X && character.Position.X <= t.R.X + t.R.Width) || (character.Position.X + character.Position.Width >= t.R.X && character.Position.X + character.Position.Width <= t.R.X + t.R.Width) && t.T != b4)
                            {
                                col = true;
                                break;
                            }
                        }
                        else
                        {
                            col = false;
                        }
                    }
                    if (col)
                    {
                        character.Position = new Rectangle(character.Position.X, character.Position.Y, character.Position.Width, character.Position.Height);
                    }
                    else
                    {
                        character.Position = new Rectangle(character.Position.X, character.Position.Y + 1, character.Position.Width, character.Position.Height);
                    }
                }
            }

            if (character.Position.Y > GraphicsDevice.Viewport.Height)
            {
                lives--;
                if (lives <= 0)
                {
                    state = new GameOverState();
                    state.SetGame(this);
                }
                character.Position = new Rectangle(64 * 4, 0, 64, 64);
            }
			
			base.Update(gameTime);

            
		}

		/// <summary>
		/// This is called when the game should draw itself.
		/// </summary>
		/// <param name="gameTime">Provides a snapshot of timing values.</param>
		protected override void Draw(GameTime gameTime)
		{
			GraphicsDevice.Clear(Color.White);
            

			spriteBatch.Begin();

            state.Draw();

			spriteBatch.End();



			base.Draw(gameTime);

            
		}

        //Applies all of the instructions and images and uses what the current state
        #region Gravity, Collision, and Scrolling Methods

        public bool Gravity()
        {
            bool gravity = true;
            foreach (Tile t in tiles)
            {
                if (t.CheckCollision(character, b4))
                {
                    gravity = false;
                    break;
                }
            }
            return gravity;
        }

        public bool Collision()
        {
            bool collides = false;
            foreach (Tile t in tiles)
            {
                if (t.R.Top == character.Position.Bottom)
                {
                    collides = true;
                    break;
                }
            }

            return collides;
        }


        public void Scrolling()
        {

            StreamReader file = null;
            try
            {
                string line = null;
                if (File.Exists(@"./MapEditor/Binary/customMap.txt"))
                        file = new StreamReader(@"./MapEditor/Binary/customMap.txt");
                else
                {
                    if (level == 1)
                    {
                        file = new StreamReader(@"./Content/Map1.txt");
                    }
                    else if (level == 2)
                    {
                        file = new StreamReader(@"./Content/Map2.txt");
                    }
                    else
                    {
                        file = new StreamReader(@"./Content/Map3.txt");
                    }
                }
                int n = 0;
                for (int y = 0; y <= 7; y++)
                {
                    line = file.ReadLine();
                    for (int i = 0; i < end; i++)
                    {

                        switch (line[i])
                        {
                            case 'i':
                                tiles[n].T = b1;
                                break;
                            case 'b':
                                tiles[n].T = b2;
                                break;
                            case 'r':
                                tiles[n].T = b3;
                                break;
                            case 'e':
                                tiles[n].T = eggCollectible;
                                break;
                            default:
                                tiles[n].T = b4;
                                break;
                        }
                        n++;
                    }
                }
                tiles[tiles.Count - 1].T = b3;


                eggRectangle = new Rectangle(tiles[tiles.Count - 9].R.X, 64 * 3, 200, 200);
            }


            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                file.Close();
            }
        }

        public int HiScore
        {
            get { return hiScore; }
            set { hiScore = value; }
        }

        public void NewLevel()
        {
            StreamReader file = null;
            try
            {
                if (level == 1)
                {
                    file = new StreamReader(@"./Content/Map1.txt");
                }
                else if (level == 2)
                {
                    file = new StreamReader(@"./Content/Map2.txt");
                }
                else if (level == 3)
                {
                    file = new StreamReader(@"./Content/Map3.txt");
                }
                else
                {
                    state = new GameWonState();
                    state.SetGame(this);
                }
                string line = file.ReadLine();

                end = line.Length;

                for (int y = 0; y <= 7; y++)
                {
                    for (int x = 0; x < end; x++)
                    {
                        tiles.Add(new Tile(""));
                    }
                }
                tiles.Add(new Tile(""));

                //loading the assets from the list of tiles and assigning them a position
                Vector2 position = new Vector2();
                position = Vector2.Zero;

                for (int i = 0; i < tiles.Count; i++)
                {
                    int nIndex = -1;
                    for (int j = 0; j <= i; j++)
                    {
                        if (tiles[j].m_sFileName == tiles[i].m_sFileName)
                        {
                            nIndex = j;
                            break;
                        }
                    }
                    if (nIndex == -1)
                        tiles[i].m_Texture2D = this.Content.Load<Texture2D>(tiles[i].m_sFileName);
                    else
                    {
                        tiles[i].m_Texture2D = tiles[nIndex].m_Texture2D;
                    }
                    tiles[i].m_Rectangle.X = (int)position.X;
                    tiles[i].m_Rectangle.Y = (int)position.Y;
                    position.X += tiles[i].m_nSize;

                    if (position.X >= (tiles[i].m_nSize * line.Length)) //So we have an extra one on the edge of the screen
                    {
                        position.X = 0;
                        position.Y += tiles[i].m_nSize;
                    }
                }
                foreach (Tile t in tiles)
                {
                    tileReset.Add(t.R.X);
                }
                Scrolling();
            }
            catch (Exception)
            {
            }
            finally
            {
                if(file != null)
                    file.Close();
            }
        }

        #endregion
	}
}
