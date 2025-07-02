using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpaceInvaders.Figures.Enums;

namespace SpaceInvaders.Figures.ConcreteFigures
{
    internal class Bullet : PictureBoxRenderedFigure
    {
        public Bullet(int x, int y, BulletType bulletType) : base(x, y)
        {
            this.view.SizeMode = PictureBoxSizeMode.Zoom;
            this.view.Size = new Size(ApplicationEnvironment.BulletParameters.BULLET_WIDTH, ApplicationEnvironment.BulletParameters.BULLET_HEIGHT);
            this.view.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(bulletType.ToString())!;
        }
        public override void Die()
        {
            this.IsAlive = false;
            base.Die();
        }

        public void MoveBullet(int xDelta, int yDelta)
        {
            this.Render();
            new Thread(() =>
            {
                while (IsAlive)
                {
                    Point currentLocation = this.GetLocation();
                    this.Move(currentLocation.X + xDelta, currentLocation.Y + yDelta);
                    Thread.Sleep(50);
                }
            }).Start();
        }
    }
}
