using SpaceInvaders.Figures.ConcreteFigures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders.ActionChain.StartupChain
{
    internal class CreateScoreBoard : StartupChainHandler
    {
        public override void Execute()
        {
            GameState.GetInstance().ScoreBoard = new ScoreBoard();
            base.Execute();
        }
    }
}
