using SpaceInvaders.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders.ActionChain.StartupChain
{
    internal class CreateObstacles : StartupChainHandler
    {
        public override void Execute()
        {
            GameState gameState = GameState.GetInstance();
            
            for (int i = 0; i < ApplicationEnvironment.ObstacleParameters.OBSTACLE_NUMBER; i++)
            {
                gameState.ObstacleBlocks.AddRange(
                    ObstacleCreator.CreateObstacle(
                    ApplicationEnvironment.ObstacleParameters.OBSTACLE_START_X + i * ApplicationEnvironment.ObstacleParameters.OBSTACLE_PADDING,
                    ApplicationEnvironment.ObstacleParameters.OBSTACLE_START_Y));
            }
            base.Execute();
        }
    }
}
