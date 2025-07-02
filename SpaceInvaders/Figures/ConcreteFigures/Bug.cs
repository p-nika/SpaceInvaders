using SpaceInvaders.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders.Figures.ConcreteFigures
{
    internal class Bug : PictureBoxRenderedAlien
    {
         private bool currentState;
        public Bug(int x, int y) : base(x, y)
        {
            view.Image = Resources.alien12;
        }

        public override void ChangeState()
        {
            view.Image = currentState ? Resources.alien12_1 : Resources.alien12;
            currentState = !currentState;
        }
    }
}
