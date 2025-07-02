using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders.ActionChain.StartupChain
{
    internal class RenderHeartBoard : StartupChainHandler
    {
        public override void Execute()
        {
            GameState.GetInstance().HeartBoard.Render();
            base.Execute();
        }
    }
}
