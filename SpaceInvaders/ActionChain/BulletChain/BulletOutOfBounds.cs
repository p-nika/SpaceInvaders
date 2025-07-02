using SpaceInvaders.Figures.ConcreteFigures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders.ActionChain.BulletChain
{
    internal class BulletOutOfBounds : BulletChainHandler
    {
        public override void Execute(Bullet bullet)
        {
            new Thread(() =>
            {
                while (bullet.IsAlive)
                {
                    if (!ApplicationEnvironment.BoundChecker.CheckBounds(bullet.GetLocation().X, bullet.GetLocation().Y))
                    {
                        bullet.Die();
                    }
                }
            }).Start();
            base.Execute(bullet);
        }
    }
}
