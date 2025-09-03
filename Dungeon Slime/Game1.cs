using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGameLibrary;

namespace Dungeon_Slime
{
    public class Game1 : Core
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private Texture2D _logo;

        public Game1(): base("Dungeon Slime", 1280, 720, false)
        {
            
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _logo = Content.Load<Texture2D>("images/logo");
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {

            GraphicsDevice.Clear(Color.CornflowerBlue);


            Rectangle iconSourceRect = new Rectangle(0, 0, 128, 128);
            Rectangle wordmarkSourceRect = new Rectangle(150, 34, 458, 58);
            SpriteBatch.Begin(SpriteSortMode.FrontToBack);
            SpriteBatch.Draw(
                _logo,
                new Vector2
                (
                    (Window.ClientBounds.Width) * 0.5f,
                    (Window.ClientBounds.Height) * 0.5f
       
                ),
                iconSourceRect,   // source rectangle
                Color.Blue * 1f,    // Colour
                MathHelper.ToRadians(0),   // Rotation
                new Vector2
                (
                    iconSourceRect.Width / 2,
                    iconSourceRect.Height /2
                    
                ),   // Origin
                new Vector2
                (
                   1.5f,
                   1f
                ),   // Scale
                SpriteEffects.None,   // effects
                1.0f    // layer depth
            );


            SpriteBatch.Draw(
                _logo,
                new Vector2
                (
                    (Window.ClientBounds.Width) * 0.5f,
                    (Window.ClientBounds.Height) * 0.5f

                ),
                wordmarkSourceRect,   // source rectangle
                Color.Blue * 0.5f,    // Colour
                MathHelper.ToRadians(0),   // Rotation
                new Vector2
                (
                    wordmarkSourceRect.Width / 2,
                    wordmarkSourceRect.Height / 2

                ),   // Origin
                new Vector2
                (
                   1.5f,
                   1f
                ),   // Scale
                SpriteEffects.None,   // effects
                0.0f    // layer depth
            );



            SpriteBatch.End();
            

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
