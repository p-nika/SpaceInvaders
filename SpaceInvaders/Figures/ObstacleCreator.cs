using SpaceInvaders.Figures.ConcreteFigures;
using SpaceInvaders.Figures.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders.Figures
{
    internal class ObstacleCreator
    {
        public static List<ObstacleBlock> CreateObstacle(int topLeftX, int topLeftY)
        {
            int width = ApplicationEnvironment.ObstacleParameters.OBSTACLE_BLOCK_WIDTH;
            int height = ApplicationEnvironment.ObstacleParameters.OBSTACLE_BLOCK_HEIGHT;
            List<ObstacleBlock> obstacleBlocks = [];
            obstacleBlocks.Add(new ObstacleBlock(topLeftX, topLeftY, ObstacleBlockType.BottomLeftCorner));
            obstacleBlocks.Add(new ObstacleBlock(topLeftX + width, topLeftY, ObstacleBlockType.Block));
            obstacleBlocks.Add(new ObstacleBlock(topLeftX, topLeftY + height, ObstacleBlockType.Block));
            obstacleBlocks.Add(new ObstacleBlock(topLeftX, topLeftY + 2 * height, ObstacleBlockType.Block));
            obstacleBlocks.Add(new ObstacleBlock(topLeftX + 2 * width, topLeftY, ObstacleBlockType.Block));
            obstacleBlocks.Add(new ObstacleBlock(topLeftX + 3 * width, topLeftY, ObstacleBlockType.BottomRightCorner));
            obstacleBlocks.Add(new ObstacleBlock(topLeftX + 3 * width, topLeftY + height, ObstacleBlockType.Block));
            obstacleBlocks.Add(new ObstacleBlock(topLeftX + 3 * width, topLeftY + 2 * height, ObstacleBlockType.Block));
            obstacleBlocks.Add(new ObstacleBlock(topLeftX + width, topLeftY + height, ObstacleBlockType.TopLeftCorner));
            obstacleBlocks.Add(new ObstacleBlock(topLeftX + 2 * width, topLeftY + height, ObstacleBlockType.TopRightCorner));
            return obstacleBlocks;
        }
    }
}
