using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace Catchlab2
{
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        SoundEffectInstance sf = null;
        Dictionary<string, Texture2D> badges = new Dictionary<string, Texture2D>();

        public Game1()
        {
            //Activity.Track("displaying badges and sound effect playing");
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }


        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            AudioManager.SoundEffects = Loader.ContentLoad<SoundEffect>(Content, "Audio");
            AudioManager.Play(ref sf, "Badges_6");
            base.Initialize();
        }




        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            badges = Loader.ContentLoad<Texture2D>(Content, "Badges");


            // TODO: use this.Content to load your game content here
        }




        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }


        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }


        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();
            spriteBatch.Draw(badges["Badges_0"], new Vector2(20, 20), Color.White);
            spriteBatch.Draw(badges["Badges_1"], new Vector2(30, 130), Color.White);
            spriteBatch.Draw(badges["Badges_2"], new Vector2(40, 240), Color.White);
            spriteBatch.Draw(badges["Badges_3"], new Vector2(250, 50), Color.White);
            spriteBatch.Draw(badges["Badges_4"], new Vector2(360, 60), Color.White);
            spriteBatch.End();
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
