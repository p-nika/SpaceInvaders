using System.Security.Cryptography.Xml;
using SpaceInvaders.Figures;
using SpaceInvaders.Figures.ConcreteFigures;
using SpaceInvaders.Figures.Factories;
using SpaceInvaders.ActionChain;
using SpaceInvaders.ActionChain.BulletChain;
using SpaceInvaders.ActionChain.StartupChain;

namespace SpaceInvaders
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.Controls.Clear();
            this.Load += Form1_Load;
            this.KeyDown += Form1_KeyDown;
        }

        private void Form1_KeyDown(object? sender, KeyEventArgs e)
        {
            ApplicationEnvironment.PlayerControlHandler.HandlePlayerControls(e.KeyCode);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GameState gameState = GameState.GetInstance();
            gameState.GameView = this;
            GenericChainCreator<StartupChainHandler, StartupChainHandlers>.GetInstance()
                     .CreateHandler(StartupChainHandlers.CanvasCreation)
                     .WithHandler(StartupChainHandlers.RenderCanvas)
                     .WithHandler(StartupChainHandlers.AlienTransitionState)
                     .WithHandler(StartupChainHandlers.AlienTransitionMove)
                     .WithHandler(StartupChainHandlers.PlayerCreation)
                     .WithHandler(StartupChainHandlers.RenderPlayer)
                     .WithHandler(StartupChainHandlers.FinishGame)
                     .WithHandler(StartupChainHandlers.CreateObstacles)
                     .WithHandler(StartupChainHandlers.RenderObstacles)
                     .WithHandler(StartupChainHandlers.CreateScoreBoard)
                     .WithHandler(StartupChainHandlers.RenderScoreBoard)
                     .WithHandler(StartupChainHandlers.CreateHeartBoard)
                     .WithHandler(StartupChainHandlers.RenderHeartBoard)
                     .WithHandler(StartupChainHandlers.UfoHandler)
                     .WithHandler(StartupChainHandlers.AlienCombatHandler)
                     .GetResult()
                     .Execute();
        }

        public void ResetForm()
        {
            this.Controls.Clear();
            InitializeComponent();
        }
    }
}
