using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpaceInvaders.DefaultConfiguration;
using SpaceInvaders.DefaultConfiguration.Interfaces;

namespace SpaceInvaders
{
    internal sealed class ApplicationEnvironment
    {
        private ApplicationEnvironment() { }
        public static IAlienOrder AlienOrder { get; } = new DefaultAlienOrder();
        public static IPlayerControlHandler PlayerControlHandler { get; } = new DefaultPlayerControlHandler();
        public static IBoundChecker BoundChecker { get; } = new DefaultBoundChecker();
        public static IBulletChooser BulletChooser { get; } = new DefaultBulletChooser();
        public static CanvasParameters CanvasParameters { get; } = new CanvasParameters();
        public static ObstacleParameters ObstacleParameters { get; } = new ObstacleParameters();
        public static UfoParameters UfoParameters { get; } = new UfoParameters();
        public static ApplicationBounds ApplicationBounds { get; } = new ApplicationBounds();
        public static AlienParameters AlienParameters { get; } = new AlienParameters();
        public static BulletParameters BulletParameters { get; } = new BulletParameters();
        public static PlayerParameters PlayerParameters { get; } = new PlayerParameters();
        public static ScoreBoardParameters ScoreBoardParameters { get; } = new ScoreBoardParameters();
        public static HeartBoardParameters HeartBoardParameters { get; } = new HeartBoardParameters();

    }
}
