using XPT.Games.Generic.Constants;
using XPT.Games.Generic.Maps;
using XPT.Games.Twinion.Entities;

namespace XPT.Games.Twinion.Maps {
    class TwMap16 : TwMap {
        public override int MapIndex => 16;
        public override int MapID => 0x0603;
        protected override int RandomEncounterChance => 10;
        protected override int RandomEncounterExtraCount => 0;

        private const int DETECTED_DOOR = 1;
        private const int HURT = 2;
        protected override void FnEvent01(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetRace(player, type, doMsgs) == GREMLIN) {
                GuildDoor(player, type, doMsgs);
            }
        }
        protected override void FnEvent02(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
        }
        protected override void FnEvent03(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HasUsedSkill(player, type, ref doMsgs, DETECT_SKILL) >= 6 || HasUsedSpell(player, type, ref doMsgs, TRUE_SEEING_SPELL) >= 1 || UsedItem(player, type, ref doMsgs, HELMOFWISDOM, HELMOFWISDOM) || UsedItem(player, type, ref doMsgs, VALKYRIESHELM, VALKYRIESHELM) || UsedItem(player, type, ref doMsgs, RINGOFTHIEVES, RINGOFTHIEVES) || UsedItem(player, type, ref doMsgs, CRYSTALBALL, CRYSTALBALL)) {
                ShowText(player, type, doMsgs, "You find a cleverly disguised door.");
                DoorHere(player, type, doMsgs);
                WallClear(player, type, doMsgs);
            }
            else {
                WallBlock(player, type, doMsgs);
            }
        }
        protected override void FnEvent04(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You are surprised by a group of monsters who attack!");
        }
        protected override void FnEvent05(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 6, 2, 160, Direction.East);
        }
        protected override void FnEvent06(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.LEATHER_MAP) == 0)) {
                ShowPortrait(player, type, doMsgs, ELFBARBARIAN);
                ShowText(player, type, doMsgs, "'At last! I've found my weapon, a clue and a map piece!'");
                ShowText(player, type, doMsgs, "The elf looks at you with a broad grin, 'It's my fourth and final piece you know. Now all I have to do is find my way out of here.'");
                ShowText(player, type, doMsgs, "She slips a Skeleton Key into her bag and turns to leave. 'Good luck in your search!'");
            }
        }
        protected override void FnEvent07(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetRace(player, type, doMsgs) == GREMLIN) {
                ShowText(player, type, doMsgs, "Use the Ebony before the Coral.");
            }
        }
        protected override void FnEvent08(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int itemA = 0;
            int life = 0;
            if (HasItem(player, type, doMsgs, RODOFTHESERPENT) || HasItem(player, type, doMsgs, SERPENTSFANG)) {
                BootyStr(player, type, doMsgs);
            }
            else {
                switch (GetGuild(player, type, doMsgs)) {
                    case KNIGHT:
                    case THIEF:
                    case WIZARD:
                        itemA = SERPENTSFANG;
                        break;
                    default:
                        itemA = RODOFTHESERPENT;
                        break;
                }
                switch (GetTile(player, type, doMsgs)) {
                    case 24:
                        life = GREMLIN;
                        break;
                    case 97:
                        life = ELF;
                        break;
                    case 138:
                        life = GNOME;
                        break;
                    case 214:
                        life = TROLL;
                        break;
                }
                if (GetRace(player, type, doMsgs) == life) {
                    SetTreasure(player, type, doMsgs, itemA, BLUELOCKPICK, ELIXIROFHEALTH, 0, 0, 3000);
                }
                else {
                    BootyStr(player, type, doMsgs);
                }
            }
            switch (GetPartyCount(player, type, doMsgs)) {
                case 1:
                    AddEncounter(player, type, doMsgs, 01, 26);
                    break;
                case 2:
                    AddEncounter(player, type, doMsgs, 01, 2);
                    AddEncounter(player, type, doMsgs, 02, 2);
                    AddEncounter(player, type, doMsgs, 05, 25);
                    break;
                default:
                    AddEncounter(player, type, doMsgs, 01, 2);
                    AddEncounter(player, type, doMsgs, 02, 2);
                    AddEncounter(player, type, doMsgs, 05, 25);
                    AddEncounter(player, type, doMsgs, 06, 26);
                    break;
            }
        }
        protected override void FnEvent09(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HasUsedSkill(player, type, ref doMsgs, DETECT_SKILL) >= 6 || HasUsedSpell(player, type, ref doMsgs, TRUE_SEEING_SPELL) >= 1 || UsedItem(player, type, ref doMsgs, HELMOFWISDOM, HELMOFWISDOM) || UsedItem(player, type, ref doMsgs, VALKYRIESHELM, VALKYRIESHELM) || UsedItem(player, type, ref doMsgs, RINGOFTHIEVES, RINGOFTHIEVES) || UsedItem(player, type, ref doMsgs, CRYSTALBALL, CRYSTALBALL) || IsFlagOn(player, type, doMsgs, FlagTypeTile, DETECTED_DOOR)) {
                SetFlag(player, type, doMsgs, FlagTypeTile, DETECTED_DOOR, 1);
                if (UsedItem(player, type, ref doMsgs, BLUELOCKPICK, BLUELOCKPICK) || UsedItem(player, type, ref doMsgs, HELMOFGUILE, HELMOFGUILE) || HasUsedSkill(player, type, ref doMsgs, LOCKPICK_SKILL) >= 8) {
                    ShowText(player, type, doMsgs, "You successfully unlock the door.");
                    DoorHere(player, type, doMsgs);
                    WallClear(player, type, doMsgs);
                }
                else {
                    WallBlock(player, type, doMsgs);
                    DoorHere(player, type, doMsgs);
                    ShowText(player, type, doMsgs, "You see a door appear in the wall, but it is locked.");
                }
            }
            else {
                WallBlock(player, type, doMsgs);
            }
        }
        protected override void FnEvent0A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, FOUNTAIN);
            if (GetGuild(player, type, doMsgs) == BARBARIAN || GetGuild(player, type, doMsgs) == CLERIC || GetGuild(player, type, doMsgs) == RANGER || GetGuild(player, type, doMsgs) == KNIGHT) {
                if ((GetSkill(player, type, doMsgs, STAFF_SKILL) == 0)) {
                    HealFtn(player, type, doMsgs);
                    SetSkill(player, type, doMsgs, STAFF_SKILL, 1);
                    ShowText(player, type, doMsgs, "The crystal waters of Unity Fountain teach you the Staff skill.");
                }
                else {
                    ShowText(player, type, doMsgs, "The crystal waters of Unity Fountain heal and restore mana for all races.");
                    HealFtn(player, type, doMsgs);
                }
            }
            else if (GetGuild(player, type, doMsgs) == WIZARD) {
                if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.BLESSWIZ) == 0)) {
                    HealFtn(player, type, doMsgs);
                    GiveSpell(player, type, doMsgs, BLESS_SPELL, 1);
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.BLESSWIZ, 1);
                    ShowText(player, type, doMsgs, "The crystal waters of Unity Fountain teach you the Bless spell.");
                }
                else {
                    HealFtn(player, type, doMsgs);
                    ShowText(player, type, doMsgs, "The crystal waters of Unity Fountain heal and restore mana for all races.");
                }
            }
            else if (GetGuild(player, type, doMsgs) == THIEF) {
                if ((GetSkill(player, type, doMsgs, RUNE_READING_SKILL) == 0)) {
                    HealFtn(player, type, doMsgs);
                    SetSkill(player, type, doMsgs, RUNE_READING_SKILL, 1);
                    ShowText(player, type, doMsgs, "The crystal waters of Unity Fountain teaches you the Rune Reading skill.");
                }
                else {
                    HealFtn(player, type, doMsgs);
                    ShowText(player, type, doMsgs, "The crystal waters of Unity Fountain heal and restore mana for all races.");
                }
            }
        }
        protected override void FnEvent0B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.LEATHER_MAP) == 0)) {
                ShowPortrait(player, type, doMsgs, GREMLINTHIEF);
                ShowText(player, type, doMsgs, "A thief emerges from the shadows.");
                ShowText(player, type, doMsgs, "'Psssst...let me give you some advice. Some of the walls in these rooms have been weakened. Just push and see!'");
                ShowText(player, type, doMsgs, "As he walks off winking, he looks back and says, 'Oh, I hope you visited Snicker again. He has appropriated a Ring of Thieves which will come in handy in here. It will show you unseen pathways.'");
            }
        }
        protected override void FnEvent0C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.LEATHER_MAP) == 0)) {
                ShowPortrait(player, type, doMsgs, DWARFWIZARD);
                ShowText(player, type, doMsgs, "'Hehehehehe!  A champion you wish to be, yet things you must learn. Some doors here are to deceive, not to open. Learn it well.");
                ShowText(player, type, doMsgs, "By the way, you did bring your reforged Skeleton Key with you, didn't you?'");
            }
        }
        protected override void FnEvent0D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetRace(player, type, doMsgs) == HUMAN) {
                GuildDoor(player, type, doMsgs);
            }
        }
        protected override void FnEvent0E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 6, 2, 32, Direction.East);
        }
        protected override void FnEvent0F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, DWARFTHIEF);
            ShowText(player, type, doMsgs, "'My brother thief forgot to mention that neither word uses the first letter.");
            ShowText(player, type, doMsgs, "The second and last are most important.");
            ShowText(player, type, doMsgs, "Oh, and the one that uses the last also lacks two letters. But it will become obvious to you when time and place are right.'");
        }
        protected override void FnEvent10(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, HALFLINGRANGER);
            ShowText(player, type, doMsgs, "'Ah-h-h! This dungeon has driven me half-mad!");
            ShowText(player, type, doMsgs, "Further down I found this nexus area that was nothing but doors, doors, doors!");
            ShowText(player, type, doMsgs, "Fortunately, almost all that opened - notice I say 'almost' - required no special key or lockpick or skill.");
            ShowText(player, type, doMsgs, "Still, if I could get my hands around the neck of the maniac who designed that place, I would... Oh, how I would love to squeeze and squeeze until the eyes popped out!'");
        }
        protected override void FnEvent11(TwPlayerServer player, MapEventType type, bool doMsgs) {
            DisableHealing(player, type, doMsgs);
            if ((GetFlag(player, type, doMsgs, FlagTypeTile, HURT) == 0)) {
                DoDamage(player, type, doMsgs, GetHealthMax(player, type, doMsgs) / 4);
                ShowText(player, type, doMsgs, "You feel nauseous as you step through the stagnant puddle of water.");
                SetFlag(player, type, doMsgs, FlagTypeTile, HURT, 1);
            }
        }
        protected override void FnEvent13(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int life = 0;
            switch (GetTile(player, type, doMsgs)) {
                case 58:
                    life = HUMAN;
                    break;
                case 177:
                    life = HALFLING;
                    break;
                case 220:
                    life = ORC;
                    break;
                case 87:
                    life = DWARF;
                    break;
            }
            if (HasItem(player, type, doMsgs, LEATHERMAP)) {
                EmptyRoom(player, type, doMsgs);
            }
            else if (GetRace(player, type, doMsgs) == life) {
                if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.LEATHER_MAP) == 0)) {
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.LEATHER_MAP, 1);
                    ModifyExperience(player, type, doMsgs, 200000);
                    GlimpseMap(player, type, doMsgs);
                }
                else {
                    GlimpseMap(player, type, doMsgs);
                }
            }
            else {
                EmptyRoom(player, type, doMsgs);
            }
        }
        protected override void FnEvent16(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 6, 2, 105, Direction.South);
        }
        protected override void FnEvent17(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetTreasure(player, type, doMsgs, SHIELDINGSCROLL, MANAELIXIR, 0, 0, 0, 2500);
            ShowText(player, type, doMsgs, "You feel a chill as you stumble upon ice monsters.");
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 17);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 14);
                AddEncounter(player, type, doMsgs, 02, 14);
                AddEncounter(player, type, doMsgs, 03, 31);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 13);
                AddEncounter(player, type, doMsgs, 02, 14);
                AddEncounter(player, type, doMsgs, 03, 31);
                AddEncounter(player, type, doMsgs, 05, 32);
                AddEncounter(player, type, doMsgs, 06, 32);
            }
        }
        protected override void FnEvent19(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetRace(player, type, doMsgs) == ELF) {
                GuildDoor(player, type, doMsgs);
            }
        }
        protected override void FnEvent1A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetRace(player, type, doMsgs) == DWARF) {
                GuildDoor(player, type, doMsgs);
            }
        }
        protected override void FnEvent1F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetRace(player, type, doMsgs) == ELF) {
                ShowText(player, type, doMsgs, "Use the Coral third.");
            }
        }
        protected override void FnEvent21(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, FOUNTAIN);
            if (GetRace(player, type, doMsgs) == GREMLIN) {
                HealFtn(player, type, doMsgs);
                ShowText(player, type, doMsgs, "The waters of Gremlin Fountain refresh you and restore your mana.");
            }
            else {
                ShowText(player, type, doMsgs, "The waters of Gremlin Fountain have no affect.");
            }
        }
        protected override void FnEvent25(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetRace(player, type, doMsgs) == GNOME) {
                GuildDoor(player, type, doMsgs);
            }
        }
        protected override void FnEvent28(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetRace(player, type, doMsgs) == GNOME) {
                ShowText(player, type, doMsgs, "Use the Ebony before the Coral.");
            }
        }
        protected override void FnEvent2B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, FOUNTAIN);
            if (GetRace(player, type, doMsgs) == HALFLING) {
                HealFtn(player, type, doMsgs);
                ShowText(player, type, doMsgs, "The waters of Halfling Fountain refresh and replenish you.");
            }
            else {
                ShowText(player, type, doMsgs, "The waters of Halfling Fountain have no affect.");
            }
        }
        protected override void FnEvent2D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 6, 1, 89, Direction.South);
        }
        protected override void FnEvent2F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 6, 3, 11, Direction.East);
        }
        protected override void FnEvent30(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, FOUNTAIN);
            if (GetRace(player, type, doMsgs) == TROLL) {
                HealFtn(player, type, doMsgs);
                ShowText(player, type, doMsgs, "The waters of Troll Fountain invigorate you and restore your mana.");
            }
            else {
                ShowText(player, type, doMsgs, "The waters of Troll Fountain have no affect.");
            }
        }
        protected override void FnEvent31(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, FOUNTAIN);
            if (GetRace(player, type, doMsgs) == HUMAN) {
                HealFtn(player, type, doMsgs);
                ShowText(player, type, doMsgs, "The waters of Human Fountain rejuvenate you.");
            }
            else {
                ShowText(player, type, doMsgs, "The waters of Human Fountain have no affect.");
            }
        }
        protected override void FnEvent33(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 6, 2, 160, Direction.East);
        }
        protected override void FnEvent35(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetRace(player, type, doMsgs) == HALFLING) {
                GuildDoor(player, type, doMsgs);
            }
        }
        protected override void FnEvent38(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetTreasure(player, type, doMsgs, SCROLLOFTHESUN, CURATIVEELIXIR, 0, 0, 0, 1500);
            ShowText(player, type, doMsgs, "As you approach a battle, the combatants turn and attack you.");
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 5);
                AddEncounter(player, type, doMsgs, 02, 36);
                AddEncounter(player, type, doMsgs, 06, 36);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 5);
                AddEncounter(player, type, doMsgs, 02, 6);
                AddEncounter(player, type, doMsgs, 05, 20);
                AddEncounter(player, type, doMsgs, 06, 36);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 27);
                AddEncounter(player, type, doMsgs, 02, 27);
                AddEncounter(player, type, doMsgs, 03, 28);
                AddEncounter(player, type, doMsgs, 05, 35);
                AddEncounter(player, type, doMsgs, 06, 37);
            }
        }
        protected override void FnEvent39(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetRace(player, type, doMsgs) == TROLL) {
                GuildDoor(player, type, doMsgs);
            }
        }
        protected override void FnEvent3A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetRace(player, type, doMsgs) == TROLL) {
                ShowText(player, type, doMsgs, "Use the Opal before the Coral.");
            }
        }
        protected override void FnEvent3E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetRace(player, type, doMsgs) == ORC) {
                GuildDoor(player, type, doMsgs);
            }
        }
        protected override void FnEvent45(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You watch as passers-by clutch their magic-casting rings and uncover secret passages.");
        }
        protected override void FnEvent46(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "A party of lost adventurers arguing about directions turns and attacks.");
            if (HasItem(player, type, doMsgs, SCROLLOFDEATH)) {
                SetTreasure(player, type, doMsgs, SILVERBAR, BASALTSCROLL, ELIXIROFHEALTH, 0, 0, 2000);
            }
            else {
                SetTreasure(player, type, doMsgs, SOLDIERSFLAIL, SCROLLOFDEATH, ELIXIROFHEALTH, 0, 0, 3000);
            }
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 20);
                AddEncounter(player, type, doMsgs, 05, 29);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 34);
                AddEncounter(player, type, doMsgs, 02, 36);
                AddEncounter(player, type, doMsgs, 03, 36);
                AddEncounter(player, type, doMsgs, 06, 24);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 34);
                AddEncounter(player, type, doMsgs, 02, 36);
                AddEncounter(player, type, doMsgs, 03, 37);
                AddEncounter(player, type, doMsgs, 05, 39);
                AddEncounter(player, type, doMsgs, 06, 40);
            }
        }
        protected override void FnEvent48(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 31);
                AddEncounter(player, type, doMsgs, 02, 33);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 17);
                AddEncounter(player, type, doMsgs, 02, 13);
                AddEncounter(player, type, doMsgs, 06, 32);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 13);
                AddEncounter(player, type, doMsgs, 02, 14);
                AddEncounter(player, type, doMsgs, 03, 18);
                AddEncounter(player, type, doMsgs, 05, 32);
                AddEncounter(player, type, doMsgs, 06, 32);
            }
        }
        protected override void FnEvent49(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 3);
                AddEncounter(player, type, doMsgs, 02, 1);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 3);
                AddEncounter(player, type, doMsgs, 02, 3);
                AddEncounter(player, type, doMsgs, 03, 2);
                AddEncounter(player, type, doMsgs, 04, 1);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 2);
                AddEncounter(player, type, doMsgs, 02, 2);
                AddEncounter(player, type, doMsgs, 05, 25);
                AddEncounter(player, type, doMsgs, 06, 1);
            }
        }
        protected override void FnEvent4A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 11);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 9);
                AddEncounter(player, type, doMsgs, 02, 9);
                AddEncounter(player, type, doMsgs, 05, 12);
                AddEncounter(player, type, doMsgs, 06, 30);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 9);
                AddEncounter(player, type, doMsgs, 02, 9);
                AddEncounter(player, type, doMsgs, 03, 12);
                AddEncounter(player, type, doMsgs, 05, 30);
                AddEncounter(player, type, doMsgs, 06, 30);
            }
        }
        protected override void FnEvent4B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 3);
                AddEncounter(player, type, doMsgs, 02, 22);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 3);
                AddEncounter(player, type, doMsgs, 02, 3);
                AddEncounter(player, type, doMsgs, 03, 20);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 2);
                AddEncounter(player, type, doMsgs, 02, 2);
                AddEncounter(player, type, doMsgs, 03, 21);
                AddEncounter(player, type, doMsgs, 04, 23);
            }
        }
        protected override void FnEvent4D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 22);
                AddEncounter(player, type, doMsgs, 02, 36);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 20);
                AddEncounter(player, type, doMsgs, 02, 21);
                AddEncounter(player, type, doMsgs, 03, 29);
                AddEncounter(player, type, doMsgs, 04, 29);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 34);
                AddEncounter(player, type, doMsgs, 02, 35);
                AddEncounter(player, type, doMsgs, 05, 39);
                AddEncounter(player, type, doMsgs, 06, 40);
            }
        }
        protected override void FnEvent4E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 6);
                AddEncounter(player, type, doMsgs, 02, 3);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 1);
                AddEncounter(player, type, doMsgs, 02, 3);
                AddEncounter(player, type, doMsgs, 05, 6);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 6);
                AddEncounter(player, type, doMsgs, 02, 6);
                AddEncounter(player, type, doMsgs, 03, 5);
                AddEncounter(player, type, doMsgs, 05, 2);
                AddEncounter(player, type, doMsgs, 06, 3);
            }
        }
        protected override void FnEvent4F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 8);
                AddEncounter(player, type, doMsgs, 02, 29);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 8);
                AddEncounter(player, type, doMsgs, 02, 8);
                AddEncounter(player, type, doMsgs, 03, 24);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 8);
                AddEncounter(player, type, doMsgs, 02, 8);
                AddEncounter(player, type, doMsgs, 03, 9);
                AddEncounter(player, type, doMsgs, 05, 22);
                AddEncounter(player, type, doMsgs, 06, 24);
            }
        }
        private void GuildDoor(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.ARMORY_ITEM) == 1 && UsedItem(player, type, ref doMsgs, SKELETONKEY, SKELETONKEY)) {
                ShowText(player, type, doMsgs, "The door springs open.");
                WallClear(player, type, doMsgs);
            }
            else {
                WallBlock(player, type, doMsgs);
                ShowText(player, type, doMsgs, "You see a skull and crossbones scratched into the door.");
            }
        }
        private void GlimpseMap(TwPlayerServer player, MapEventType type, bool doMsgs) {
            GiveItem(player, type, doMsgs, LEATHERMAP);
            ShowText(player, type, doMsgs, "You glimpse a scrap of leather on the floor.");
            ShowText(player, type, doMsgs, "It is a Leather Map and is one of the four Queen Aeowyn sent you to find.");
        }
        private void EmptyRoom(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "The room is empty.");
        }
        private void HealFtn(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ModifyHealth(player, type, doMsgs, GetHealthMax(player, type, doMsgs));
            ModifyMana(player, type, doMsgs, 10000);
        }
        private void WallClear(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
        }
        private void WallBlock(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
        }
        private void BootyStr(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetTreasure(player, type, doMsgs, ELIXIROFHEALTH, BLUELOCKPICK, 0, 0, 0, 1500);
        }
        private void DoorHere(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetWallItem(player, type, doMsgs, DOOR, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
        }
    }
}
