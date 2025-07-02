using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpaceInvaders.Figures.Enums;

namespace SpaceInvaders.Figures.Factories
{
    internal class FigureCreator
    {
        private readonly Dictionary<FigureTypes, IFigureFactory> _factories;

        private FigureCreator()
        {
            _factories = [];
            foreach (FigureTypes enumValue in Enum.GetValues(typeof(FigureTypes)))
            {
                var type = Type.GetType($"{typeof(IFigureFactory).Namespace}.{Enum.GetName(typeof(FigureTypes), enumValue)}Factory");
                _factories.Add(enumValue, (IFigureFactory)Activator.CreateInstance(type!)!);
            }
        }

        public static FigureCreator FillFactories() => new FigureCreator();

        public RenderedFigure CreateFigure(FigureTypes figure, int x, int y)
        {
            return _factories[figure].CreateFigure(x, y);
        }
    }
}
