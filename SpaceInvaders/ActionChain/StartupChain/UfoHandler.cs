using SpaceInvaders.Figures.ConcreteFigures;
using SpaceInvaders.Figures.Enums;
using SpaceInvaders.Figures.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders.ActionChain.StartupChain
{
    internal class UfoHandler : StartupChainHandler
    {
        public override void Execute()
        {
            GameState gameState = GameState.GetInstance();
            new Thread(() =>
            {
                while (gameState.GameRunning)
                {
                    Random rand = new Random();
                    int result = rand.Next(0, 100);
                    if (result < ApplicationEnvironment.UfoParameters.UFO_PROBABILITY)
                    {
                        Ufo ufo = (Ufo)FigureCreator.FillFactories().CreateFigure(FigureTypes.Ufo, ApplicationEnvironment.UfoParameters.UFO_START_X, ApplicationEnvironment.UfoParameters.UFO_START_Y);
                        ufo.Render();
                        gameState.Ufo = ufo;
                        while (ufo.IsAlive)
                        {
                            Point location = ufo.GetLocation();
                            if (ApplicationEnvironment.BoundChecker.CheckBounds(location.X, location.Y))
                            {
                                ufo.Move(location.X - ApplicationEnvironment.UfoParameters.UFO_DELTA, location.Y);
                                Thread.Sleep(ApplicationEnvironment.UfoParameters.UFO_TRANSITION_DELAY);
                            }
                            else
                            {
                                ufo.Die();
                            }
                        }
                    }
                    Thread.Sleep(ApplicationEnvironment.CanvasParameters.TRANSITION_DELAY);
                }
            }).Start();
            base.Execute();
        }
    }
}
