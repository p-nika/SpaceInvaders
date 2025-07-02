using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpaceInvaders.Figures.Enums;

namespace SpaceInvaders.Figures.ConcreteFigures
{
    internal class ObstacleBlock : PictureBoxRenderedFigure, IStateChangeable
    {
        private int hitTaken;
        private readonly ObstacleBlockType blockType;
        public ObstacleBlock(int x, int y, ObstacleBlockType blockType) : base(x, y)
        {
            view.Size = new Size(ApplicationEnvironment.ObstacleParameters.OBSTACLE_BLOCK_WIDTH, ApplicationEnvironment.ObstacleParameters.OBSTACLE_BLOCK_HEIGHT);
            view.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(blockType.ToString())!;
            this.blockType = blockType;
        }

        public void ChangeState()
        {
            hitTaken++;
            if(hitTaken == 4)
            {
                Die();
                return;
            }
            view.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject($"{blockType.ToString()}Broken{hitTaken}")!;
        }
    }
}
