using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SpaceInvasion
{
	public class SplashScreen : GameScreen
	{
		private Texture2D _tImage;
		private string _sPath;

		public SplashScreen ()
		{
		}

		public override void LoadContent()
		{
			base.LoadContent ();

			_sPath = "sheet";
			_tImage = _oContent.Load<Texture2D> (_sPath);
		}

		public override void UnloadContent()
		{
			base.UnloadContent ();
		}

		public override void Update(GameTime gameTime)
		{
			base.Update (gameTime);
		}

		public override void Draw(SpriteBatch spriteBatch)
		{
			base.Draw (spriteBatch);

			spriteBatch.Draw (_tImage, Vector2.Zero, Color.White);
		}
	}
}

