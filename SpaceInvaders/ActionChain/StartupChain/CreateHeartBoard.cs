using SpaceInvaders.Figures.ConcreteFigures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders.ActionChain.StartupChain
{
    internal class CreateHeartBoard : StartupChainHandler
    {
        public override void Execute()
        {
            GameState.GetInstance().HeartBoard = new HeartBoard();
            base.Execute();
        }
    }
}
