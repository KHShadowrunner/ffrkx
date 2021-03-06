﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class Nekodamashi : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20260003; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.THIEF; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 1.3; } }
        public override string Name { get { return "Nekodamashi"; } }
    }
}
