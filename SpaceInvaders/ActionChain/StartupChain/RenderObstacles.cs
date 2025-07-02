using SpaceInvaders.Figures.ConcreteFigures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders.ActionChain.StartupChain
{
    internal class RenderObstacles : StartupChainHandler
    {
        public override void Execute()
        {
            GameState gameState = GameState.GetInstance();
            gameState.ObstacleBlocks.ForEach((block) => { block.Render(); });
            base.Execute();
        }
    }
}
