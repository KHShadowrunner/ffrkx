﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class LightDivine : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20910001; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.WHITE_MAGE; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Healing; } }
        public override double Multiplier { get { return 50; } }
        public override string Name { get { return "Light Divine"; } }
    }
}
