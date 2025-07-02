using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders.DefaultConfiguration.Interfaces
{
    internal interface IPlayerControlHandler
    {
        public void HandlePlayerControls(Keys key);
    }
}
