﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class JechtShot : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20130004; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.TIDUS; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Water; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 2.63; } }
        public override string Name { get { return "Jecht Shot"; } }
        public override int NumberOfHits { get { return 3; } }
    }
}
