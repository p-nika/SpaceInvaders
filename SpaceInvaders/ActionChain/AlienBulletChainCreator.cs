using SpaceInvaders.ActionChain.BulletChain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders.ActionChain
{
    internal static class AlienBulletChainCreator
    {
        public static BulletChainHandler CreateBulletChain()
        {
            return GenericChainCreator<BulletChainHandler, BulletChainHandlers>.GetInstance()
                .CreateHandler(BulletChainHandlers.BulletPlayerContact)
                .WithHandler(BulletChainHandlers.BulletObstacleContact)
                .WithHandler(BulletChainHandlers.BulletOutOfBounds)
                .GetResult();
        }
    }
}
