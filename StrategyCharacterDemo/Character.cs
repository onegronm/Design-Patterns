﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyCharacterDemo
{
    public abstract class Character
    {
        public IWeaponBehavior weapon;

        public abstract void Fight();

        public void SetWeapon(IWeaponBehavior w)
        {
            this.weapon = w;
        }
    }
}
