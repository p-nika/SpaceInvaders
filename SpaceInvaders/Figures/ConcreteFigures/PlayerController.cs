using SpaceInvaders.Figures.Enums;
using SpaceInvaders.Properties;
using SpaceInvaders.ActionChain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders.Figures.ConcreteFigures
{
    internal class PlayerController : PictureBoxRenderedFigure, IThrowable
    {
        private int livesLeft = ApplicationEnvironment.PlayerParameters.LIVES;
        public Bullet PlayerBullet { get; set; }
        private int Score { get; set; }
        public PlayerController(int x, int y) : base(x, y)
        {
            view.Size = new Size(ApplicationEnvironment.PlayerParameters.PLAYER_WIDTH, ApplicationEnvironment.PlayerParameters.PLAYER_HEIGHT);
            view.Image = Resources.player;
        }

        public override void Die()
        {
            livesLeft--;
            GameState gameState = GameState.GetInstance();
            gameState.HeartBoard.RemoveHeart();
            if (livesLeft == 0)
            {
                gameState.GameRunning = false;
                base.Die();
            }
        }

        public void Throw()
        {
            Bullet bullet = new Bullet(view.Location.X, view.Location.Y, BulletType.PlayerBullet);
            bullet.MoveBullet(0, -10);
            this.PlayerBullet = bullet;
            PlayerBulletChainCreator.CreateBulletChain().Execute(bullet);
        }

        public void AddScore(int score)
        {
            this.Score += score;
            GameState.GetInstance().ScoreBoard.UpdateScore(this.Score);
        }
    }
}
