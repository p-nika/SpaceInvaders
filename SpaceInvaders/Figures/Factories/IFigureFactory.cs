using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders.Figures.Factories
{
    internal interface IFigureFactory
    {
        public abstract RenderedFigure CreateFigure(int x, int y);
    }
}
