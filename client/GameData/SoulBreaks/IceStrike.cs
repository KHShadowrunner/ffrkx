﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class IceStrike : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 22200001; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.EDEA; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Ice; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Magical; } }
        public override double Multiplier { get { return 2.37; } }
        public override string Name { get { return "Ice Strike"; } }
        public override int NumberOfHits { get { return 6; } }
    }
}
