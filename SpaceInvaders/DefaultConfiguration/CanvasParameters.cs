using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders.DefaultConfiguration
{
    internal class CanvasParameters
    {
        public readonly int LEFT_OFFSET = 100;
        public readonly int TOP_OFFSET = 100;
        public readonly int HORIZONTAL_OFFSET = 50;
        public readonly int VERTICAL_OFFSET = 50;
        public readonly int ALIEN_ROW_COUNT = 5;
        public readonly int ALIEN_COLUMN_COUNT = 11;
        public readonly int RIGHT_MOVE_LIMIT = 15;
        public readonly int DOWN_MOVE_LIMIT = 6;
        public readonly int MOVE_DELTA = 20;
        public readonly int PLAYER_MOVE_DELTA = 10;
        public readonly int PLAYER_RIGHT_BOUND = 1000;
        public readonly int PLAYER_LEFT_BOUND = 100;
        public readonly int TRANSITION_DELAY = 1000;

    }
}
