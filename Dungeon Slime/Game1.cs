using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGameLibrary;
using MonoGameLibrary.Graphics;

namespace Dungeon_Slime
{
    public class Game1 : Core
    {
        private AnimatedSprite _slime;
        private AnimatedSprite _bat;

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
            Texture2D atlasTexture = Content.Load<Texture2D>("images/atlas");

            //TextureAtlas atlas = new TextureAtlas(atlasTexture);
            //atlas.AddRegion("slime", 0, 0, 20, 20);
            //atlas.AddRegion("bat", 20, 0, 20, 20);

            TextureAtlas atlas = TextureAtlas.FromFile(Content, "images/atlas-definition.xml");
            //_slime = atlas.GetRegion("slime");
            //_bat = atlas.GetRegion("bat");


            _slime = atlas.CreatedAnimatedSprite("slime-animation");
            _slime.Scale = new Vector2(4.0f, 4.0f);

            _bat = atlas.CreatedAnimatedSprite("bat-animation");
            _bat.Scale = new Vector2(4.0f, 4.0f);

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            _slime.update(gameTime);
            _bat.update(gameTime);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {

            GraphicsDevice.Clear(Color.CornflowerBlue);


            SpriteBatch.Begin(samplerState: SamplerState.PointClamp);

            _slime.Draw(SpriteBatch, Vector2.One);
            _bat.Draw(SpriteBatch, new Vector2(_slime.Width + 10, 0));

            SpriteBatch.End();
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
