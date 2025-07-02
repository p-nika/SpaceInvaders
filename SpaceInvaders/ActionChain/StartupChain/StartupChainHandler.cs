using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders.ActionChain.StartupChain
{
    internal abstract class StartupChainHandler : IChainHandler
    {
        protected IChainHandler NextHandler;

        public IChainHandler SetHandler(IChainHandler handler)
        {
            NextHandler = handler;
            return handler;
        }

        public virtual void Execute()
        {
            if (NextHandler != null)
            {
                ((StartupChainHandler)NextHandler).Execute();
            }
        }
    }
}
