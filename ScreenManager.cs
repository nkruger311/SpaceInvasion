using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace SpaceInvasion
{
	public class ScreenManager
	{
		private static ScreenManager _oInstance;
		public Vector2 Dimensions { get; private set; }
		public ContentManager Content { get; private set; }

		private GameScreen _oCurrentScreen;

		public static ScreenManager Instance
		{
			get {
				if (_oInstance == null) {
					_oInstance = new ScreenManager ();
				}

				return _oInstance;
			}
		}

		public ScreenManager()
		{
			Dimensions = new Vector2(800, 480);
			_oCurrentScreen = new SplashScreen ();
		}

		public void LoadContent(ContentManager content)
		{
			this.Content = new ContentManager (content.ServiceProvider, "Content");
			_oCurrentScreen.LoadContent ();
		}

		public void UnloadContent()
		{
			_oCurrentScreen.UnloadContent ();
		}

		public void Update(GameTime gameTime)
		{
			_oCurrentScreen.Update (gameTime);
		}

		public void Draw(SpriteBatch spriteBatch)
		{
			_oCurrentScreen.Draw (spriteBatch);
		}
	}
}

