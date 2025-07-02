using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using SpaceInvaders.Figures;
using SpaceInvaders.Figures.ConcreteFigures;

namespace SpaceInvaders
{
    internal sealed class GameState
    {
        private GameState() { }

        private static GameState _instance;

        public PictureBoxRenderedAlien[,] Aliens { get; set; }

        public PlayerController Player { get; set; }

        public List<ObstacleBlock> ObstacleBlocks { get; set; } = new List<ObstacleBlock>();

        public Form1 GameView { get; set; }

        public bool GameRunning { get; set; } = true;

        public Ufo Ufo { get; set; }

        public ScoreBoard ScoreBoard { get; set; }

        public HeartBoard HeartBoard { get; set; }

        public static GameState GetInstance()
        {
            if (_instance == null)
            {
                _instance = new GameState();
            }

            return _instance;
        }
    }
}
