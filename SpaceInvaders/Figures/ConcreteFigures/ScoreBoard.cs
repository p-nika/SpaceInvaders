using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceInvaders.Figures.ConcreteFigures
{
    internal class ScoreBoard
    {
        private readonly Label label;
        public ScoreBoard()
        {
            this.label = new Label();
            label.Text = "Score: 0";
            label.Size = new Size(ApplicationEnvironment.ScoreBoardParameters.SCOREBOARD_WIDTH, ApplicationEnvironment.ScoreBoardParameters.SCOREBOARD_HEIGHT);
            label.Location = new Point(ApplicationEnvironment.ScoreBoardParameters.SCOREBOARD_X, ApplicationEnvironment.ScoreBoardParameters.SCOREBOARD_Y);
            label.ForeColor = ApplicationEnvironment.ScoreBoardParameters.SCOREBOARD_COLOR;
            label.Font = new Font(label.Font.FontFamily, ApplicationEnvironment.ScoreBoardParameters.SCOREBOARD_FONT_SIZE);
        }

        public void UpdateScore(int score)
        {
            label.BeginInvoke(() => { label.Text = $"Score: {score}"; });
        }

        public void Render()
        {
            GameState gameState = GameState.GetInstance();
            gameState.GameView.BeginInvoke(() => { gameState.GameView.Controls.Add(label); });
        }
    }
}
