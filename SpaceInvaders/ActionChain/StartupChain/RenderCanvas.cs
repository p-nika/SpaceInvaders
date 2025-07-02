using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders.ActionChain.StartupChain
{
    internal class RenderCanvas : StartupChainHandler
    {
        public override void Execute()
        {
            GameState gameState = GameState.GetInstance();
            foreach (var item in gameState.Aliens)
            {
                item.Render();
            }
            base.Execute();
        }
    }
}
