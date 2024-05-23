﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;

namespace HolesGame
{

    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
      

        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        SpriteFont GameFont;
        Hero theHero;

        int TimeSinceLastHoleSpawned = 0;
        int WaitTime = 3000; //new hole every 3 seconds
        Random rng = new Random();
        List<Holes> Holes = new List<Holes>(); 
        

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            theHero = new Hero();
            
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
            theHero.LoadContent(Content);
            GameFont = Content.Load<SpriteFont>(@"MyFont");
            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            theHero.Update(gameTime); //call the hero object Update method

            base.Update(gameTime);
            //Run the hero update method
            
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue); //feel free to change this colour!

            spriteBatch.Begin();

            theHero.Draw(spriteBatch); //call the hero object draw method


            spriteBatch.DrawString(GameFont, "Survived for " + (int)gameTime.TotalGameTime.TotalSeconds + " seconds", new Vector2(0, 0), Color.Black);

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
