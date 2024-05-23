using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolesGame
{
    class Holes : GameObject
    {
        public Holes(Vector2 spawnlocation)
        {
            Location = spawnlocation;
        }
        public override void LoadContent(ContentManager Content)
        {
            Texture = Content.Load<Texture2D>(@"Hole");
        }

    }
}
