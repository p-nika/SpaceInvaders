using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders.DefaultConfiguration
{
    internal class AlienParameters
    {
        public readonly int ALIEN_WIDTH = 30;
        public readonly int ALIEN_HEIGHT = 40;
        public readonly int THROW_PROBABILITY = 1;
        public readonly int ALIEN_KILL_SCORE = 25;
        public readonly Bitmap ALIEN_KILL_IMAGE = Properties.Resources.explode;
    }
}
