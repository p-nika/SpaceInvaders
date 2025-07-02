using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders.ActionChain.StartupChain
{
    internal class RenderScoreBoard : StartupChainHandler
    {
        public override void Execute()
        {
            GameState.GetInstance().ScoreBoard.Render();
            base.Execute();
        }
    }
}
