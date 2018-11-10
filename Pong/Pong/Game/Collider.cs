﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Pong.Framework.Common;
using Pong.Framework.Game;
using Pong.Menus;

namespace Pong.Game
{
    internal abstract class Collider : IDrawableCollideable
    {
        protected int XPos;
        protected int YPos;
        protected int Width;
        protected int Height;

        protected bool IsSquare;

        protected Collider(bool isSquare)
        {
            this.IsSquare = isSquare;
        }

        public Rectangle GetBoundingBox()
        {
            return new Rectangle(this.XPos, this.YPos, this.Width, this.Height);
        }

        public virtual void Draw(SpriteBatch b)
        {
            b.Draw(this.IsSquare ? AssetManager.SquareTexture : AssetManager.CircleTexture, new Rectangle(this.XPos, this.YPos, this.Width, this.Height), null, Color.White);
        }

        public virtual void Update()
        {
        }
    }
}
