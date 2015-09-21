using System;
using System.IO;
using System.Reflection;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace SpaceInvasion
{
	/// <summary>
	/// This is the main type for your game
	/// </summary>
	public class Game1 : Microsoft.Xna.Framework.Game
	{
		GraphicsDeviceManager graphics;
		SpriteBatch spriteBatch;

		public Game1()
		{
			graphics = new GraphicsDeviceManager(this);

			Content.RootDirectory = "Content";

			graphics.IsFullScreen = true;
			graphics.PreferredBackBufferWidth = 800;
			graphics.PreferredBackBufferHeight = 480;
			graphics.SupportedOrientations = DisplayOrientation.LandscapeLeft | DisplayOrientation.LandscapeRight;
		}

		/// <summary>
		/// Allows the game to perform any initialization it needs to before starting to run.
		/// This is where it can query for any required services and load any non-graphic
		/// related content.  Calling base.Initialize will enumerate through any components
		/// and initialize them as well.
		/// </summary>
		protected override void Initialize()
		{
			//CheckForRequiredFiles();

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
			/*
			ScreenManager.Instance.GraphicsDevice = GraphicsDevice;
			ScreenManager.Instance.SpriteBatch = spriteBatch;
			//ScreenManager.Instance.GameWindow = this.Window;
			ScreenManager.Instance.GameWindow = (AndroidGameWindow)this.Window;
			ScreenManager.Instance.Dimensions = new Vector2(GraphicsDevice.Viewport.Width, GraphicsDevice.Viewport.Height);
			ScreenManager.Instance.LoadContent(Content);

			Camera2D.Instance.Initialize();
			*/
		}

		protected override void UnloadContent()
		{
			//ScreenManager.Instance.UnloadContent();
		}

		/// <summary>
		/// Allows the game to run logic such as updating the world,
		/// checking for collisions, gathering input, and playing audio.
		/// </summary>
		/// <param name="gameTime">Provides a snapshot of timing values.</param>
		protected override void Update(GameTime gameTime)
		{
			if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
			{
				if (AskBeforeExit())
					Exit();
			}

			//ScreenManager.Instance.Update(gameTime);
			/* Update the camera after updating the screen so the camera "follows" the player */
			//Camera2D.Instance.Update(gameTime);

			base.Update(gameTime);
		}

		/// <summary>
		/// This is called when the game should draw itself.
		/// </summary>
		/// <param name="gameTime">Provides a snapshot of timing values.</param>
		protected override void Draw(GameTime gameTime)
		{
			GraphicsDevice.Clear(Color.Black);

			/*
                Using SpriteSortMode.Deferred below.
                SpriteSortMode.BackToFont and SpriteSortMode.FrontToBack was causing issues when drawing sprites
            */
			//spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend, null, null, null, null, Camera2D.Instance.Transformation);

			//ScreenManager.Instance.Draw(spriteBatch);

			//spriteBatch.End();

			base.Draw(gameTime);
		}

		public bool AskBeforeExit()
		{
			// TODO: Add a dialog asking the user if they would like to exit 

			return true;
		}
	}
}
