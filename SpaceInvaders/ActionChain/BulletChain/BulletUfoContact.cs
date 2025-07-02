using SpaceInvaders.Figures.ConcreteFigures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders.ActionChain.BulletChain
{
    internal class BulletUfoContact : BulletChainHandler
    {
        public override void Execute(Bullet bullet)
        {
            GameState gameState = GameState.GetInstance();
            new Thread(() =>
            {
                while (bullet.IsAlive)
                {
                    if (gameState.Ufo != null && gameState.Ufo.IsAlive && gameState.Ufo.GetBounds().IntersectsWith(bullet.GetBounds()))
                    {
                        gameState.Ufo.Die();
                        bullet.Die();
                        gameState.Player.AddScore(ApplicationEnvironment.UfoParameters.UFO_KILL_SCORE);
                    }
                }
            }).Start();
            base.Execute(bullet);
        }
    }
}
