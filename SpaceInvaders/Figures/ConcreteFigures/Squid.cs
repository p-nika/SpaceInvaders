using SpaceInvaders.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders.Figures.ConcreteFigures
{
    internal class Squid : PictureBoxRenderedAlien
    {
        private bool currentState = false;
        public Squid(int x, int y) : base(x, y)
        {
            view.Image = Resources.alien10_1;
        }
        public override void ChangeState()
        {
            view.Image = currentState ? Resources.alien10 : Resources.alien10_1;
            currentState = !currentState;
        }
    }
}
