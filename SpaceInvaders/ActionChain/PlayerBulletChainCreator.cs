using SpaceInvaders.ActionChain.BulletChain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders.ActionChain
{
    internal static class PlayerBulletChainCreator
    {
        public static BulletChainHandler CreateBulletChain()
        {
            return GenericChainCreator<BulletChainHandler, BulletChainHandlers>.GetInstance()
                .CreateHandler(BulletChainHandlers.BulletAlienContact)
                .WithHandler(BulletChainHandlers.BulletObstacleContact)
                .WithHandler(BulletChainHandlers.BulletUfoContact)
                .WithHandler(BulletChainHandlers.BulletOutOfBounds)
                .GetResult();
        }
    }
}
