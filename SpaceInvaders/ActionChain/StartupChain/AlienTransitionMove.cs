using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders.ActionChain.StartupChain
{
    internal class AlienTransitionMove : StartupChainHandler
    {
        public override void Execute()
        {
            GameState gameState = GameState.GetInstance();
            new Thread(() =>
            {
                int direction = 1;
                int rightMove = 0;
                int downMove = 0;
                while (gameState.GameRunning)
                {
                    foreach (var item in gameState.Aliens)
                    {
                        Point currentLocation = item.GetLocation();
                        if (rightMove == ApplicationEnvironment.CanvasParameters.RIGHT_MOVE_LIMIT)
                        {
                            item.Move(currentLocation.X, currentLocation.Y + ApplicationEnvironment.CanvasParameters.HORIZONTAL_OFFSET);
                        }
                        else
                        {
                            item.Move(currentLocation.X + direction * ApplicationEnvironment.CanvasParameters.MOVE_DELTA, currentLocation.Y);
                        }
                    }
                    if (rightMove == ApplicationEnvironment.CanvasParameters.RIGHT_MOVE_LIMIT)
                    {
                        rightMove = 0;
                        direction *= -1;
                        downMove++;
                    }
                    else
                    {
                        rightMove++;
                    }
                    if (downMove == ApplicationEnvironment.CanvasParameters.DOWN_MOVE_LIMIT)
                    {
                        gameState.GameRunning = false;
                    }
                    Thread.Sleep(ApplicationEnvironment.CanvasParameters.TRANSITION_DELAY);
                }
            }).Start();
            base.Execute();
        }
    }
}
