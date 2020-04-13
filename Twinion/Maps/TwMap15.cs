using XPT.Games.Generic.Constants;
using XPT.Games.Generic.Maps;
using XPT.Games.Twinion.Entities;

namespace XPT.Games.Twinion.Maps {
    class TwMap15 : TwMap {
        public override int MapIndex => 15;
        public override int MapID => 0x0602;
        protected override int RandomEncounterChance => 10;
        protected override int RandomEncounterExtraCount => 0;

        private const int DETECTED_DOOR = 1;
        private const int HORSE = 2;
        private const int POTION = 3;
        protected override void FnEvent01(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetRace(player, type, doMsgs) == GNOME) {
                GuildDoor(player, type, doMsgs);
            }
        }
        protected override void FnEvent02(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HasUsedSkill(player, type, ref doMsgs, DETECT_SKILL) >= 6 || HasUsedSpell(player, type, ref doMsgs, TRUE_SEEING_SPELL) >= 1 || UsedItem(player, type, ref doMsgs, HELMOFWISDOM, HELMOFWISDOM) || UsedItem(player, type, ref doMsgs, VALKYRIESHELM, VALKYRIESHELM) || UsedItem(player, type, ref doMsgs, RINGOFTHIEVES, RINGOFTHIEVES) || UsedItem(player, type, ref doMsgs, CRYSTALBALL, CRYSTALBALL)) {
                ShowText(player, type, doMsgs, "You spot a hidden door.");
                DoorHere(player, type, doMsgs);
                WallClear(player, type, doMsgs);
            }
            else {
                WallBlock(player, type, doMsgs);
            }
        }
        protected override void FnEvent03(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 6, 3, 164, Direction.North);
        }
        protected override void FnEvent04(TwPlayerServer player, MapEventType type, bool doMsgs) {
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
                    case 21:
                        life = HALFLING;
                        break;
                    case 30:
                        life = HUMAN;
                        break;
                    case 163:
                        life = ORC;
                        break;
                    case 201:
                        life = DWARF;
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
                    AddEncounter(player, type, doMsgs, 01, 9);
                    AddEncounter(player, type, doMsgs, 02, 30);
                    break;
                case 2:
                    AddEncounter(player, type, doMsgs, 01, 9);
                    AddEncounter(player, type, doMsgs, 02, 9);
                    AddEncounter(player, type, doMsgs, 05, 5);
                    break;
                default:
                    AddEncounter(player, type, doMsgs, 01, 9);
                    AddEncounter(player, type, doMsgs, 02, 9);
                    AddEncounter(player, type, doMsgs, 05, 27);
                    AddEncounter(player, type, doMsgs, 06, 27);
                    break;
            }
        }
        protected override void FnEvent05(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetRace(player, type, doMsgs) == HALFLING) {
                ShowText(player, type, doMsgs, "Use Kalydor's payment first.");
            }
        }
        protected override void FnEvent06(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetRace(player, type, doMsgs) == HALFLING) {
                GuildDoor(player, type, doMsgs);
            }
        }
        protected override void FnEvent07(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "The clutter of spent crystal balls littering the ground reminds you that many times a door can be detected by using magic.");
        }
        protected override void FnEvent08(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 6, 3, 47, Direction.West);
        }
        protected override void FnEvent09(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int life = 0;
            switch (GetTile(player, type, doMsgs)) {
                case 34:
                    life = GNOME;
                    break;
                case 91:
                    life = TROLL;
                    break;
                case 116:
                    life = GREMLIN;
                    break;
                case 204:
                    life = ELF;
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
        protected override void FnEvent0A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 6, 3, 11, Direction.East);
        }
        protected override void FnEvent0B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 6, 3, 74, Direction.West);
        }
        protected override void FnEvent0C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
        }
        protected override void FnEvent0D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetRace(player, type, doMsgs) == HUMAN) {
                ShowText(player, type, doMsgs, "Use the Topaz before the Ebony.");
            }
        }
        protected override void FnEvent0E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "A group of vicious monsters appears to guard this area.");
        }
        protected override void FnEvent0F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, HALFLINGCLERIC);
            ShowText(player, type, doMsgs, "With a gleam in his eyes, a halfling approaches you.");
            ShowText(player, type, doMsgs, "'Well! It took me a lot of crystal balls to find out that most of these secret passages are actually illusionary walls!");
            ShowText(player, type, doMsgs, "But not all was in vain, I did find some secret doors and they led me..well, I'll let you find that out. I wonder who built this place.'");
            ShowText(player, type, doMsgs, "With that, he returns to contemplating his maps.");
        }
        protected override void FnEvent10(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetRace(player, type, doMsgs) == HUMAN) {
                GuildDoor(player, type, doMsgs);
            }
        }
        protected override void FnEvent11(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetRace(player, type, doMsgs) == ORC) {
                HealFtn(player, type, doMsgs);
                ShowText(player, type, doMsgs, "The waters of Orc Spring refresh and invigorate you.");
            }
            else {
                ShowText(player, type, doMsgs, "The waters of Orc Spring have no affect.");
            }
        }
        protected override void FnEvent12(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetRace(player, type, doMsgs) == DWARF) {
                HealFtn(player, type, doMsgs);
                ShowText(player, type, doMsgs, "The waters of Dwarf Spring refresh and invigorate you.");
            }
            else {
                ShowText(player, type, doMsgs, "The waters of Dwarf Spring have no affect.");
            }
        }
        protected override void FnEvent13(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 6, 3, 126, Direction.East);
        }
        protected override void FnEvent14(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, GNOMEWIZARD);
            ShowText(player, type, doMsgs, "A gnome with a merry gleam in his eye greets your with a chuckle. 'You are much too serious, my friend! Keep searching, you will find what you seek, I swear!'");
            ShowText(player, type, doMsgs, "He becomes serious for a moment and says, 'Ah, the wonders and dangers that await you. Within the depths I have seen feuding dragons, each on opposite sides of a tunnel.");
            ShowText(player, type, doMsgs, "Magic permeates that place, so be sure you are protected. There is also a place called Hopeless Hallways and...wait, I shall let you return to your search. That story can wait.'");
            ShowText(player, type, doMsgs, "With that he chuckles and walks away.");
        }
        protected override void FnEvent17(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 6, 3, 106, Direction.North);
        }
        protected override void FnEvent18(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeTile, HORSE) == 0) {
                DoDamage(player, type, doMsgs, GetHealthMax(player, type, doMsgs) / 4);
                ShowText(player, type, doMsgs, "A herd of horses stampedes past your party, injuring you.");
                SetFlag(player, type, doMsgs, FlagTypeTile, HORSE, 1);
            }
        }
        protected override void FnEvent19(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetRace(player, type, doMsgs) == TROLL) {
                GuildDoor(player, type, doMsgs);
            }
        }
        protected override void FnEvent1A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetTreasure(player, type, doMsgs, SILVERBAR, READTRACKSTALISMAN, 0, 0, 0, 2000);
            ShowText(player, type, doMsgs, "A band of adventurers bickers over treasure.");
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 21);
                AddEncounter(player, type, doMsgs, 02, 33);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 21);
                AddEncounter(player, type, doMsgs, 02, 22);
                AddEncounter(player, type, doMsgs, 05, 33);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 35);
                AddEncounter(player, type, doMsgs, 02, 36);
                AddEncounter(player, type, doMsgs, 03, 37);
                AddEncounter(player, type, doMsgs, 04, 38);
                AddEncounter(player, type, doMsgs, 05, 39);
                AddEncounter(player, type, doMsgs, 06, 40);
            }
        }
        protected override void FnEvent1B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ModifyGold(player, type, doMsgs,  - 2000);
            ShowText(player, type, doMsgs, "Your pockets feel lighter because your horse lost.");
        }
        protected override void FnEvent1C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, DWARFTHIEF);
            ShowText(player, type, doMsgs, "'I found a place deep in the dungeon where babble rules. After exploring the place for quite some time, I stumbled upon some wall switches.");
            ShowText(player, type, doMsgs, "Walking into a wall changes its switch. I would still be down there if I hadn't figured out what words I was supposed to spell.'");
        }
        protected override void FnEvent1D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, HUMANBARBARIAN);
            ShowText(player, type, doMsgs, "'A word of warning from a seasoned soldier -");
            ShowText(player, type, doMsgs, "Deep in the dungeon is a place where Harmony and Chaos are united.");
            ShowText(player, type, doMsgs, "Do not be overly concerned about being weakened by a burned hand. Eventually, it will be healed and you will receive a great blessing.'");
        }
        protected override void FnEvent1E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 6, 3, 35, Direction.West);
        }
        protected override void FnEvent1F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, DWARFWIZARD);
            ShowText(player, type, doMsgs, "'I've been wandering for days here and in the adjoining Rat Race. I feel like some mouse being led through a maze!");
            ShowText(player, type, doMsgs, "My fellow mages have warned me that I must find the two places open only to members of my Race.");
            ShowText(player, type, doMsgs, "Until I find them, I will not be able to get into the nether regions of this dungeon.'");
        }
        protected override void FnEvent21(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetRace(player, type, doMsgs) == GREMLIN) {
                GuildDoor(player, type, doMsgs);
            }
        }
        protected override void FnEvent22(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetTreasure(player, type, doMsgs, STONEOFTHEMAGI, LIFEGIVER, 0, 0, 0, 2000);
            ShowText(player, type, doMsgs, "Adventurers trick you into joining a battle and then turn on you.");
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 35);
                AddEncounter(player, type, doMsgs, 02, 35);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 15);
                AddEncounter(player, type, doMsgs, 02, 17);
                AddEncounter(player, type, doMsgs, 04, 16);
                AddEncounter(player, type, doMsgs, 06, 40);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 15);
                AddEncounter(player, type, doMsgs, 02, 17);
                AddEncounter(player, type, doMsgs, 04, 16);
                AddEncounter(player, type, doMsgs, 05, 39);
                AddEncounter(player, type, doMsgs, 06, 40);
            }
        }
        protected override void FnEvent23(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetRace(player, type, doMsgs) == ORC) {
                GuildDoor(player, type, doMsgs);
            }
        }
        protected override void FnEvent24(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetRace(player, type, doMsgs) == ORC) {
                ShowText(player, type, doMsgs, "Use Syrene's payment first.");
            }
        }
        protected override void FnEvent25(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ModifyMana(player, type, doMsgs,  - 200);
            ShowText(player, type, doMsgs, "Your long journey has taken a toll on you and you feel your mana decrease.");
        }
        protected override void FnEvent27(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetRace(player, type, doMsgs) == ELF) {
                HealFtn(player, type, doMsgs);
                ShowText(player, type, doMsgs, "The waters of Elf Spring refresh and invigorate you.");
            }
            else {
                ShowText(player, type, doMsgs, "The waters of Elf Spring have no affect.");
            }
        }
        protected override void FnEvent29(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 6, 3, 175, Direction.West);
        }
        protected override void FnEvent2C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetTreasure(player, type, doMsgs, SCROLLOFTHESUN, AMULETOFPROTECTION, 0, 0, 0, 2000);
            ShowText(player, type, doMsgs, "Dragons turn toward you and attack!");
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 12);
                AddEncounter(player, type, doMsgs, 02, 28);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 11);
                AddEncounter(player, type, doMsgs, 02, 11);
                AddEncounter(player, type, doMsgs, 05, 28);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 11);
                AddEncounter(player, type, doMsgs, 02, 11);
                AddEncounter(player, type, doMsgs, 03, 28);
                AddEncounter(player, type, doMsgs, 04, 29);
                AddEncounter(player, type, doMsgs, 05, 29);
            }
        }
        protected override void FnEvent2D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 6, 3, 185, Direction.South);
        }
        protected override void FnEvent2E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetRace(player, type, doMsgs) == ELF) {
                GuildDoor(player, type, doMsgs);
            }
        }
        protected override void FnEvent2F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetRace(player, type, doMsgs) == DWARF) {
                GuildDoor(player, type, doMsgs);
            }
        }
        protected override void FnEvent30(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetRace(player, type, doMsgs) == DWARF) {
                ShowText(player, type, doMsgs, "Use the Topaz before the Ebony.");
            }
        }
        protected override void FnEvent35(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.UNIVERSAL) == 1) {
                HealFtn(player, type, doMsgs);
                ShowText(player, type, doMsgs, "The sparkling waters of Universal Spring refresh and invigorate you.");
            }
            else {
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.UNIVERSAL, 1);
                HealFtn(player, type, doMsgs);
                if (GetGuild(player, type, doMsgs) == BARBARIAN || GetGuild(player, type, doMsgs) == KNIGHT) {
                    GiveSpell(player, type, doMsgs, RESIST_SPELL, 1);
                    ShowText(player, type, doMsgs, "The sparkling waters of Universal Spring endow you with the Resist spell.");
                }
                else {
                    GiveSpell(player, type, doMsgs, POISON_CLOUD_SPELL, 1);
                    ShowText(player, type, doMsgs, "The sparkling waters of Universal Spring endow you with the Poison Cloud spell.");
                }
            }
        }
        protected override void FnEvent36(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 6, 3, 241, Direction.West);
        }
        protected override void FnEvent37(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.TRACK) == 1) {
                ShowText(player, type, doMsgs, "You find an empty quest bag.");
            }
            else {
                ModifyGold(player, type, doMsgs, 50000);
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.TRACK, 1);
                ShowText(player, type, doMsgs, "Congratulations, your horse finished first. You collect your winnings.");
            }
        }
        protected override void FnEvent39(TwPlayerServer player, MapEventType type, bool doMsgs) {
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
        protected override void FnEvent3C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetRace(player, type, doMsgs) == GNOME) {
                HealFtn(player, type, doMsgs);
                ShowText(player, type, doMsgs, "The waters of Gnome Spring refresh and invigorate you.");
            }
            else {
                ShowText(player, type, doMsgs, "The waters of Gnome Spring have no affect.");
            }
        }
        protected override void FnEvent3E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeTile, POTION) == 0) {
                if (HasItem(player, type, doMsgs, HEALALLPOTION)) {
                    RemoveItem(player, type, doMsgs, HEALALLPOTION);
                    ShowText(player, type, doMsgs, "You stumble while searching the dark room, and one of your potions crashes to the floor.");
                }
                else {
                    DoDamage(player, type, doMsgs, GetHealthMax(player, type, doMsgs) / 10);
                    ShowText(player, type, doMsgs, "You fall clumsily in the dark room and manage to hurt yourself.");
                    SetFlag(player, type, doMsgs, FlagTypeTile, POTION, 1);
                }
            }
        }
        protected override void FnEvent3F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 19);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 15);
                AddEncounter(player, type, doMsgs, 02, 15);
                AddEncounter(player, type, doMsgs, 05, 20);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 16);
                AddEncounter(player, type, doMsgs, 02, 31);
                AddEncounter(player, type, doMsgs, 03, 33);
                AddEncounter(player, type, doMsgs, 05, 33);
                AddEncounter(player, type, doMsgs, 06, 34);
            }
        }
        protected override void FnEvent40(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 6);
                AddEncounter(player, type, doMsgs, 02, 23);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 30);
                AddEncounter(player, type, doMsgs, 02, 30);
                AddEncounter(player, type, doMsgs, 05, 24);
                AddEncounter(player, type, doMsgs, 06, 21);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 7);
                AddEncounter(player, type, doMsgs, 02, 7);
                AddEncounter(player, type, doMsgs, 03, 21);
                AddEncounter(player, type, doMsgs, 05, 38);
            }
        }
        protected override void FnEvent42(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 3);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 2);
                AddEncounter(player, type, doMsgs, 02, 4);
                AddEncounter(player, type, doMsgs, 05, 26);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 2);
                AddEncounter(player, type, doMsgs, 02, 2);
                AddEncounter(player, type, doMsgs, 03, 1);
                AddEncounter(player, type, doMsgs, 04, 1);
                AddEncounter(player, type, doMsgs, 06, 26);
            }
        }
        protected override void FnEvent43(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 6);
                AddEncounter(player, type, doMsgs, 02, 6);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 6);
                AddEncounter(player, type, doMsgs, 02, 6);
                AddEncounter(player, type, doMsgs, 06, 27);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 6);
                AddEncounter(player, type, doMsgs, 02, 6);
                AddEncounter(player, type, doMsgs, 05, 27);
                AddEncounter(player, type, doMsgs, 06, 27);
            }
        }
        protected override void FnEvent44(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 16);
                AddEncounter(player, type, doMsgs, 02, 25);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 15);
                AddEncounter(player, type, doMsgs, 02, 16);
                AddEncounter(player, type, doMsgs, 03, 31);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 16);
                AddEncounter(player, type, doMsgs, 02, 16);
                AddEncounter(player, type, doMsgs, 03, 31);
                AddEncounter(player, type, doMsgs, 04, 31);
                AddEncounter(player, type, doMsgs, 05, 36);
                AddEncounter(player, type, doMsgs, 06, 37);
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
        private void EmptyRoom(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "The room is empty.");
        }
        private void GlimpseMap(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You glimpse a scrap of leather on the floor.");
            ShowText(player, type, doMsgs, "It is a Leather Map and is one of the four Queen Aeowyn sent you to find.");
            GiveItem(player, type, doMsgs, LEATHERMAP);
        }
        private void HealFtn(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ModifyHealth(player, type, doMsgs, GetHealthMax(player, type, doMsgs));
            ModifyMana(player, type, doMsgs, 10000);
        }
        private void DoorHere(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetWallItem(player, type, doMsgs, DOOR, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
        }
        private void WallBlock(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
        }
        private void WallClear(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
        }
        private void BootyStr(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetTreasure(player, type, doMsgs, BLUELOCKPICK, ELIXIROFHEALTH, 0, 0, 0, 1500);
        }
    }
}
