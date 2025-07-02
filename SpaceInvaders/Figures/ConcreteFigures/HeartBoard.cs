using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders.Figures.ConcreteFigures
{
    internal class HeartBoard
    {
        private readonly List<PictureBox> images = new List<PictureBox>();
        private int currentHeart;

        public HeartBoard()
        {
            for (int i = 0; i < ApplicationEnvironment.PlayerParameters.LIVES; i++)
            {
                PictureBox heartPicture = new PictureBox();
                heartPicture.Image = Properties.Resources.Heart;
                heartPicture.Size = new Size(ApplicationEnvironment.HeartBoardParameters.HEART_WIDTH, ApplicationEnvironment.HeartBoardParameters.HEART_HEIGHT);
                heartPicture.SizeMode = PictureBoxSizeMode.StretchImage;
                heartPicture.Location = new Point(ApplicationEnvironment.HeartBoardParameters.LEFT_X + i * heartPicture.Width, ApplicationEnvironment.HeartBoardParameters.LEFT_Y);
                images.Add(heartPicture);
            }
        }

        public void Render()
        {
            GameState gameState = GameState.GetInstance();
            foreach (PictureBox image in images)
            {
                gameState.GameView.BeginInvoke(() => { gameState.GameView.Controls.Add(image); });
            }
        }

        public void RemoveHeart()
        {
            GameState gameState = GameState.GetInstance();
            IAsyncResult result = gameState.GameView.BeginInvoke( () => { gameState.GameView.Controls.Remove(images[currentHeart]); });
            result.AsyncWaitHandle.WaitOne();
            currentHeart++;
        }
    }
}
