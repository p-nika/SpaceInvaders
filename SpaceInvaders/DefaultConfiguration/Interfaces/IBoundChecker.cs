using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders.DefaultConfiguration.Interfaces
{
    internal interface IBoundChecker
    {
        public bool CheckBounds(int x, int y);
    }
}
