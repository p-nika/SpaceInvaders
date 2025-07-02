using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpaceInvaders.Figures;
using SpaceInvaders.Figures.ConcreteFigures;

namespace SpaceInvaders.ActionChain.StartupChain
{
    internal class CanvasCreation : StartupChainHandler
    {
        public override void Execute()
        {
            GameState gameState = GameState.GetInstance();
            int currentHeight = ApplicationEnvironment.CanvasParameters.TOP_OFFSET;
            int currentWidth = ApplicationEnvironment.CanvasParameters.LEFT_OFFSET;
            gameState.Aliens = new PictureBoxRenderedAlien[ApplicationEnvironment.CanvasParameters.ALIEN_ROW_COUNT, ApplicationEnvironment.CanvasParameters.ALIEN_COLUMN_COUNT];
            for (int i = 0; i < ApplicationEnvironment.CanvasParameters.ALIEN_ROW_COUNT; i++)
            {
                for (int j = 0; j < ApplicationEnvironment.CanvasParameters.ALIEN_COLUMN_COUNT; j++)
                {
                    gameState.Aliens[i, j] = (PictureBoxRenderedAlien)ApplicationEnvironment.AlienOrder.GetAlienOnRow(i, currentWidth, currentHeight);
                    currentWidth += ApplicationEnvironment.CanvasParameters.VERTICAL_OFFSET;
                }
                currentHeight += ApplicationEnvironment.CanvasParameters.HORIZONTAL_OFFSET;
                currentWidth = ApplicationEnvironment.CanvasParameters.LEFT_OFFSET;
            }
            base.Execute();
        }
    }
}
