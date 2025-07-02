using SpaceInvaders.Figures.ConcreteFigures;
using SpaceInvaders.ActionChain.StartupChain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders.ActionChain.BulletChain
{
    internal class BulletChainHandler : IChainHandler
    {
        protected IChainHandler NextHandler;

        public IChainHandler SetHandler(IChainHandler handler)
        {
            NextHandler = handler;
            return handler;
        }

        public virtual void Execute(Bullet bullet)
        {
            if (NextHandler != null)
            {
                ((BulletChainHandler)NextHandler).Execute(bullet);
            }
        }
    }
}
