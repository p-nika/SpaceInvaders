using SpaceInvaders.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders.ActionChain.StartupChain
{
    internal class AlienCombatHandler : StartupChainHandler
    {
        public override void Execute()
        {
            GameState gameState = GameState.GetInstance();
            foreach (PictureBoxRenderedAlien alien in gameState.Aliens)
            {
                Task.Run(() =>
                {
                    if (alien is IThrowable throwableAlien)
                    {
                        while (alien.IsAlive)
                        {
                            Random rand = new Random();
                            int result = rand.Next(0, 100);
                            if (result < ApplicationEnvironment.AlienParameters.THROW_PROBABILITY)
                            {
                                throwableAlien.Throw();
                            }
                            Thread.Sleep(ApplicationEnvironment.CanvasParameters.TRANSITION_DELAY);
                        }
                    }
                });
            }
            base.Execute();
        }
    }
}
