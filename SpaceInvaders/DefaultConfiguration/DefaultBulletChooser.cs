using SpaceInvaders.DefaultConfiguration.Interfaces;
using SpaceInvaders.Figures.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders.DefaultConfiguration
{
    internal class DefaultBulletChooser : IBulletChooser
    {
        public BulletType ChooseBullet()
        {
            Random rand = new Random();
            if (rand.Next(0, 2) > 0)
            {
                return BulletType.LeftBolt;
            }
            else
            {
                return BulletType.RightBolt;
            }

        }
    }
}
