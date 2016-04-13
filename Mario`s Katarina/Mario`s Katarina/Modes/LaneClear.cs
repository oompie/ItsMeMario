﻿using Mario_s_Lib;
using static Mario_s_Katarina.SpellsManager;
using static Mario_s_Katarina.Menus;
using static Mario_s_Katarina.RHandler;

namespace Mario_s_Katarina.Modes
{
    /// <summary>
    ///     This mode will run when the key of the orbwalker is pressed
    /// </summary>
    internal class LaneClear
    {
        /// <summary>
        ///     Put in here what you want to do when the mode is running
        /// </summary>
        public static void Execute()
        {
            if (!CastingR)
            {
                Q.TryToCast(Q.GetLastHitMinion(), LaneClearMenu);
                W.TryToCast(W.GetLastHitMinion(), LaneClearMenu);
                E.TryToCast(E.GetLastHitMinion(), LaneClearMenu);
            }
        }
    }
}