using SpaceInvaders.Figures;
using SpaceInvaders.Figures.ConcreteFigures;
using SpaceInvaders.ActionChain.StartupChain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders.ActionChain.BulletChain
{
    internal class BulletAlienContact : BulletChainHandler
    {
        public override void Execute(Bullet bullet)
        {
            GameState gameState = GameState.GetInstance();
            List<PictureBoxRenderedAlien> aliens = gameState.Aliens.Cast<PictureBoxRenderedAlien>().ToList();
            new Thread(() =>
            {
                while (bullet.IsAlive)
                {
                    aliens.ForEach((alien) =>
                    {
                        if (alien.IsAlive && alien.GetBounds().IntersectsWith(bullet.GetBounds()))
                        {
                            bullet.Die();
                            alien.Die();
                            gameState.Player.AddScore(ApplicationEnvironment.AlienParameters.ALIEN_KILL_SCORE);
                        }
                    });
                }
            }).Start();
            base.Execute(bullet);
        }
    }
}
