using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpaceInvaders.DefaultConfiguration.Interfaces;

namespace SpaceInvaders.DefaultConfiguration
{
    internal class DefaultPlayerControlHandler : IPlayerControlHandler
    {
        public void HandlePlayerControls(Keys key)
        {
            GameState gameState = GameState.GetInstance();
            Point playerLocation = gameState.Player.GetLocation();
            if (key == Keys.Right && playerLocation.X + ApplicationEnvironment.CanvasParameters.PLAYER_MOVE_DELTA <= ApplicationEnvironment.CanvasParameters.PLAYER_RIGHT_BOUND)
            {
                gameState.Player.Move(playerLocation.X + ApplicationEnvironment.CanvasParameters.PLAYER_MOVE_DELTA, playerLocation.Y);
            }
            else if (key == Keys.Left && playerLocation.X - ApplicationEnvironment.CanvasParameters.PLAYER_MOVE_DELTA >= ApplicationEnvironment.CanvasParameters.PLAYER_LEFT_BOUND)
            {
                gameState.Player.Move(playerLocation.X - ApplicationEnvironment.CanvasParameters.PLAYER_MOVE_DELTA, playerLocation.Y);
            }
            if (key == Keys.Space && (gameState.Player.PlayerBullet == null || !gameState.Player.PlayerBullet.IsAlive))
            {
                gameState.Player.Throw();
            }
        }
    }
}
