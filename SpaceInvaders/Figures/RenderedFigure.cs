using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders.Figures
{
    internal abstract class RenderedFigure
    {
        public abstract void Die();
        public abstract void Render();
        public abstract void Move(int x, int y);
        public abstract Point GetLocation();
    }
}
