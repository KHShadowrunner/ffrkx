﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.Abilities
{
    class BioGrenade : FFRKInspector.GameData.Ability
    {
        public override uint AbilityId { get { return 30261051; } }
        public override SchemaConstants.AbilityCategory Category { get { return SchemaConstants.AbilityCategory.Machinist; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Poison; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 1.2; } }
        public override string Name { get { return "Bio Grenade"; } }
        public override int Rarity { get { return 5; } }
        public override int NumberOfHits { get { return 2; } }
    }
}
