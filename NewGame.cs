using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace NewGameTemplate
{
    public class NewGame : Game
    {
        private readonly GraphicsDevice graphicsDevice;

        public NewGame()
        {
            var graphicsDeviceManager = new GraphicsDeviceManager(this);
            graphicsDevice = graphicsDeviceManager.GraphicsDevice;
        }

        protected override void Draw(GameTime gameTime)
        {
            graphicsDevice.Clear(Color.CornflowerBlue);
        }
    }
}
