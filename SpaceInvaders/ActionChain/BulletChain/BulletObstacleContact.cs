using SpaceInvaders.Figures.ConcreteFigures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders.ActionChain.BulletChain
{
    internal class BulletObstacleContact : BulletChainHandler
    {
        public override void Execute(Bullet bullet)
        {
            GameState gameState = GameState.GetInstance();
            new Thread(() =>
            {
                while (bullet.IsAlive)
                {
                    gameState.ObstacleBlocks.ForEach((block) =>
                    {
                        if (block.IsAlive && block.GetBounds().IntersectsWith(bullet.GetBounds()))
                        {
                            block.ChangeState();
                            bullet.Die();
                            if (!block.IsAlive)
                            {
                                gameState.Player.AddScore(ApplicationEnvironment.ObstacleParameters.OBSTACLE_KILL_SCORE);
                            }
                        }
                    });
                }
            }).Start();
            base.Execute(bullet);
        }
    }
}
