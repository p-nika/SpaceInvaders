using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpaceInvaders.Figures.ConcreteFigures;
using SpaceInvaders.Figures.Enums;
using SpaceInvaders.Figures.Factories;

namespace SpaceInvaders.ActionChain.StartupChain
{
    internal class PlayerCreation : StartupChainHandler
    {
        public override void Execute()
        {
            GameState gameState = GameState.GetInstance();
            gameState.Player = (PlayerController)FigureCreator.FillFactories().CreateFigure(
                FigureTypes.PlayerController,
                ApplicationEnvironment.PlayerParameters.PLAYER_START_X,
                ApplicationEnvironment.PlayerParameters.PLAYER_START_Y);
            base.Execute();
        }
    }
}
