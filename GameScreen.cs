using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace SpaceInvasion
{
	public class GameScreen
	{
		protected ContentManager _oContent;
		public GameScreen ()
		{
		}

		public virtual void LoadContent()
		{
			_oContent = new ContentManager (ScreenManager.Instance.Content.ServiceProvider, "Content");
		}

		public virtual void UnloadContent()
		{
			_oContent.Unload ();
		}

		public virtual void Update(GameTime gameTime)
		{
			
		}

		public virtual void Draw(SpriteBatch spriteBatch)
		{
			
		}
	}
}

