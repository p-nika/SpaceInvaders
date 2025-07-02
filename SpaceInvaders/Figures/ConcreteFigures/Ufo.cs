using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders.Figures.ConcreteFigures
{
    internal class Ufo : PictureBoxRenderedFigure
    {
        public Ufo(int x, int y) : base(x, y)
        {
            view.Image = Properties.Resources.ufo;
            view.Size = new Size(ApplicationEnvironment.UfoParameters.UFO_WIDTH, ApplicationEnvironment.UfoParameters.UFO_HEIGHT);
        }
    }
}
