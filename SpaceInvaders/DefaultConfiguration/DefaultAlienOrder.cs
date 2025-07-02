using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpaceInvaders.DefaultConfiguration.Interfaces;
using SpaceInvaders.Figures;
using SpaceInvaders.Figures.Enums;
using SpaceInvaders.Figures.Factories;

namespace SpaceInvaders.DefaultConfiguration
{
    internal class DefaultAlienOrder : IAlienOrder
    {
        public RenderedFigure GetAlienOnRow(int row, int x, int y)
        {
            switch (row)
            {
                case 0:
                    return FigureCreator.FillFactories().CreateFigure(FigureTypes.Medusa, x, y);
                case 1:
                case 2:
                    return FigureCreator.FillFactories().CreateFigure(FigureTypes.Bug, x, y);
                case 3:
                case 4:
                    return FigureCreator.FillFactories().CreateFigure(FigureTypes.Squid, x, y);
                default:
                    return null;
            }
        }
    }
}
