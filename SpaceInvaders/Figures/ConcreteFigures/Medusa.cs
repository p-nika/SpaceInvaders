using SpaceInvaders.Figures.Enums;
using SpaceInvaders.Properties;
using SpaceInvaders.ActionChain;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders.Figures.ConcreteFigures
{
    internal class Medusa : PictureBoxRenderedAlien, IThrowable
    {
        private bool currentState;

        public Medusa(int x, int y) : base(x, y)
        {
            view.Image = Resources.alien20_1;
        }
        public override void ChangeState()
        {
            view.Image = currentState ? Resources.alien20 : Resources.alien20_1;
            currentState = !currentState;
        }

        public void Throw()
        {
            Bullet bullet = new Bullet(view.Location.X, view.Location.Y, ApplicationEnvironment.BulletChooser.ChooseBullet());
            bullet.MoveBullet(0, 10);
            AlienBulletChainCreator.CreateBulletChain().Execute(bullet);
        }
    }
}
