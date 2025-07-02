using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders.Figures
{
    internal abstract class PictureBoxRenderedAlien : PictureBoxRenderedFigure, IStateChangeable
    { 
        protected PictureBoxRenderedAlien(int x, int y) : base(x, y)
        {
            view.Size = new Size(ApplicationEnvironment.AlienParameters.ALIEN_WIDTH, ApplicationEnvironment.AlienParameters.ALIEN_HEIGHT);
        }

        public override void Die()
        {
            this.view.Image = ApplicationEnvironment.AlienParameters.ALIEN_KILL_IMAGE;
            Thread.Sleep(200);
            base.Die();
        }

        public abstract void ChangeState();
    }
}
