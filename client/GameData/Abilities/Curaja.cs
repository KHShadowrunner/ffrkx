﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.Abilities
{
    class Curaja : FFRKInspector.GameData.Ability
    {
        public override uint AbilityId { get { return 30121004; } }
        public override SchemaConstants.AbilityCategory Category { get { return SchemaConstants.AbilityCategory.WhiteMagic; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Holy; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Healing; } }
        public override double Multiplier { get { return 105; } }
        public override string Name { get { return "Curaja"; } }
        public override int Rarity { get { return 4; } }
    }
}
