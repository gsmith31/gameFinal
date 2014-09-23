using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace GameOne
{
    class Lightning : AutomatedSprite
    {
        public Lightning(Texture2D texture)
            :base(new SpriteSheet(texture, new Point(4, 0), 1.0f), new Vector2(600, 50), 
            new CollisionOffset(50, 0, 50, 50), new Vector2(-1f, 0),false)
        {
            Point frameSize = new Point(64, 26);
            spriteSheet.addSegment(frameSize, new Point(0, 0), new Point(3, 0), 0);
            
            spriteSheet.setCurrentSegment(0);
        }

        public override void Update(GameTime gameTime, Rectangle clientBounds)
        {
            base.Update(gameTime, clientBounds);
        }

        public override void Collision(Sprite otherSprite)
        {
            System.Diagnostics.Debug.WriteLine("Chicken Collision");
            position.X += 20f;
            speed *= -1;
        }
    }
    }

