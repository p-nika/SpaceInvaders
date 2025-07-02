using SpaceInvaders.Figures.ConcreteFigures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders.Figures.Factories
{
    internal class UfoFactory : IFigureFactory
    {
        public RenderedFigure CreateFigure(int x, int y)
        {
            return new Ufo(x, y);
        }
    }
}
