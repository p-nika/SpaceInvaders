using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders.ActionChain.StartupChain
{
    internal class FinishGame : StartupChainHandler
    {
        public override void Execute()
        {
            GameState gameState = GameState.GetInstance();
            new Thread(() =>
            {
                while (gameState.GameRunning)
                {
                    Thread.Sleep(ApplicationEnvironment.CanvasParameters.TRANSITION_DELAY);
                }
                gameState.GameView.BeginInvoke(() => { gameState.GameView.ResetForm(); });
            }).Start();
            base.Execute();
        }
    }
}
