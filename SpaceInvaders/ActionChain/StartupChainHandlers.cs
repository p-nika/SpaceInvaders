using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders.ActionChain
{
    internal enum StartupChainHandlers
    {
        AlienTransitionMove,
        AlienTransitionState,
        CanvasCreation,
        PlayerCreation,
        RenderCanvas,
        RenderPlayer,
        CreateObstacles,
        RenderObstacles,
        UfoHandler,
        AlienCombatHandler,
        CreateScoreBoard,
        RenderScoreBoard,
        CreateHeartBoard,
        RenderHeartBoard,
        FinishGame,
    }
}
