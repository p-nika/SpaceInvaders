using SpaceInvaders.Figures.ConcreteFigures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders.ActionChain.BulletChain
{
    internal class BulletPlayerContact : BulletChainHandler
    {
        public override void Execute(Bullet bullet)
        {
            GameState gameState = GameState.GetInstance();
            new Thread(() =>
            {
                while (bullet.IsAlive)
                {
                    if (gameState.Player.GetBounds().IntersectsWith(bullet.GetBounds()))
                    {
                        gameState.Player.Die();
                        bullet.Die();
                    }
                }
            }).Start();
            base.Execute(bullet);
        }
    }
}
