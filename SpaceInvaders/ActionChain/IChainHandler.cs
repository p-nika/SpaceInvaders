using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders.ActionChain
{
    internal interface IChainHandler
    {
        public IChainHandler SetHandler(IChainHandler handler);
    }
}
