using SpaceInvaders.Figures.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders.DefaultConfiguration.Interfaces
{
    internal interface IBulletChooser
    {
        public BulletType ChooseBullet();
    }
}
