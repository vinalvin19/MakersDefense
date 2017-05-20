﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakersDefense
{
    class Level
    {
        private readonly Invader[] _invaders;
        public Tower[] Towers { get; set; }

        public Level (Invader[] invaders)
        {
            _invaders = invaders;
        }

        public bool Play()
        {
            // run until all invaders are neutralized or reach the end of map
            int remainingInvaders = _invaders.Length;

            while (remainingInvaders > 0)
            {
                // each tower has opportunity to fire on invaders
                foreach (Tower tower in Towers)
                {
                    tower.FireOnInvaders(_invaders);
                }

                // count and move the invaders that are still active
                remainingInvaders = 0;
                foreach (Invader invader in _invaders)
                {
                    if (invader.IsActive)
                    {
                        invader.Move();

                        if (invader.HasScored)
                        {
                            return false;
                        }

                        remainingInvaders++;
                    }
                }
            }
            return true;
        }
    }
}
