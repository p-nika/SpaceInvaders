using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpaceInvaders.Figures;

namespace SpaceInvaders.DefaultConfiguration.Interfaces
{
    internal interface IAlienOrder
    {
        public RenderedFigure GetAlienOnRow(int row, int x, int y);
    }
}
