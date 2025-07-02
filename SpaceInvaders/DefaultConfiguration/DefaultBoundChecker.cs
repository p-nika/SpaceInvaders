using System.Security.Cryptography.X509Certificates;
using SpaceInvaders.DefaultConfiguration.Interfaces;

namespace SpaceInvaders.DefaultConfiguration
{
    internal class DefaultBoundChecker : IBoundChecker
    {
        public bool CheckBounds(int x, int y)
        {
            return
            x >= ApplicationEnvironment.ApplicationBounds.LEFT_BOUND
            && x <= ApplicationEnvironment.ApplicationBounds.RIGHT_BOUND
            && y >= ApplicationEnvironment.ApplicationBounds.TOP_BOUND
            && y <= ApplicationEnvironment.ApplicationBounds.BOTTOM_BOUND;
        }
    }
}