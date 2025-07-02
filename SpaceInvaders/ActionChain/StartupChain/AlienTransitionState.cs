using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders.ActionChain.StartupChain
{
    internal class AlienTransitionState : StartupChainHandler
    {
        public override void Execute()
        {
            GameState gameState = GameState.GetInstance();
            new Thread(() =>
            {
                while (gameState.GameRunning)
                {
                    foreach (var item in gameState.Aliens)
                    {
                        item.ChangeState();
                    }
                    Thread.Sleep(ApplicationEnvironment.CanvasParameters.TRANSITION_DELAY);
                }
            }).Start();
            base.Execute();
        }
    }
}
