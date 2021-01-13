using Katabasis;

namespace MyGame
{
    internal class MyGame : Game
    {
        private Color _clearColor;

        public MyGame()
        {
            _clearColor = Color.Red;
        }

        protected override void Update(GameTime gameTime)
        {
            _clearColor.G = _clearColor.G == 255 ? 0 : (byte)(_clearColor.G + 1);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(_clearColor);
        }
    }
}
