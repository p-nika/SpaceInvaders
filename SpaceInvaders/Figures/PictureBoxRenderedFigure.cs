using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders.Figures
{
    internal abstract class PictureBoxRenderedFigure : RenderedFigure
    {
        protected PictureBox view;
        public bool IsAlive { get; set; } = true;

        protected PictureBoxRenderedFigure(int x, int y)
        {
            view = new PictureBox();
            view.Location = new Point(x, y);
            view.SizeMode = PictureBoxSizeMode.Zoom;
        }

        public override void Render()
        {
            GameState gameState = GameState.GetInstance();
            gameState.GameView.BeginInvoke(() => { gameState.GameView.Controls.Add(view); });
          
        }

        public override void Move(int x, int y)
        {
            GameState.GetInstance().GameView.BeginInvoke(() => { view.Location = new Point(x, y); });
        }

        public override Point GetLocation()
        {
            return view.Location;
        }

        public Rectangle GetBounds()
        {
            return view.Bounds;
        }

        public override void Die()
        {
            this.IsAlive = false;
            GameState gameState = GameState.GetInstance();
            gameState.GameView.BeginInvoke(() => { gameState.GameView.Controls.Remove(view); });
        }
    }
}
