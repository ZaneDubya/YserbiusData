using XPT.Games.Generic.Constants;
using XPT.Games.Generic.Maps;
using XPT.Games.Twinion.Entities;

namespace XPT.Games.Twinion.Maps {
    class TwMap09 : TwMap {
        public override int MapIndex => 9;
        public override int MapID => 0x0402;
        protected override int RandomEncounterChance => 15;
        protected override int RandomEncounterExtraCount => 0;

        private const int BRICK_ZAP = 1;
        protected override void FnEvent01(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, DWARFWIZARD);
            ShowText(player, type, doMsgs, "You come across an aging magician. 'Be sure to open all doors in the dungeon. I have learned many a spell by being curious.'");
        }
        protected override void FnEvent02(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, FOUNTAIN);
            ShowText(player, type, doMsgs, "Windward Fountain restores your mana.");
            ModifyMana(player, type, doMsgs, 10000);
        }
        protected override void FnEvent03(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, GREMLINWIZARD);
            ShowText(player, type, doMsgs, "A wizard rushes by you laughing and shouting, 'Now they will all be clueless.'");
        }
        protected override void FnEvent04(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "A sign on the wall reminds you, 'Some rooms should be accessed only by certain guilds, races or alignments. Oft times you could lose something of value by not heeding a warning.'");
        }
        protected override void FnEvent05(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetRace(player, type, doMsgs) == HUMAN) {
                ShowText(player, type, doMsgs, "The message on the plaque says 'Use the Pearl third.'");
            }
            else {
                ShowText(player, type, doMsgs, "Runes in the Human tongue are etched here.");
            }
        }
        protected override void FnEvent06(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetRace(player, type, doMsgs) == HALFLING) {
                ShowText(player, type, doMsgs, "The message on the plaque says 'If given a choice, use the Pearl second.'");
            }
            else {
                ShowText(player, type, doMsgs, "You see a royal insignia of the Halflings.");
            }
        }
        protected override void FnEvent07(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, HUMANBARBARIAN);
            ShowText(player, type, doMsgs, "You see a badly wounded barbarian. 'Heed my words... grave robbing can be hazardous to your health.'");
        }
        protected override void FnEvent08(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetRace(player, type, doMsgs) == GREMLIN) {
                ShowText(player, type, doMsgs, "The message on the plaque says 'If given a choice, use the Pearl first.'");
            }
            else {
                ShowText(player, type, doMsgs, "The etchings on the plaque seem familiar.");
            }
        }
        protected override void FnEvent09(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetRace(player, type, doMsgs) == ELF) {
                ShowText(player, type, doMsgs, "The message on the plaque says 'Use Dabelais' payment first.'");
            }
            else {
                ShowText(player, type, doMsgs, "Elven runes abound here.");
            }
        }
        protected override void FnEvent0A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetRace(player, type, doMsgs) == TROLL) {
                ShowText(player, type, doMsgs, "The message on the plaque says 'Use Dabelais' payment second.'");
            }
            else {
                ShowText(player, type, doMsgs, "You don't understand the language on the plaque.");
            }
        }
        protected override void FnEvent0B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 4, 2, 162, Direction.South);
        }
        protected override void FnEvent0C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HasUsedSkill(player, type, ref doMsgs, DETECT_SKILL) >= 6 || HasUsedSpell(player, type, ref doMsgs, TRUE_SEEING_SPELL) >= 1 || UsedItem(player, type, ref doMsgs, HELMOFWISDOM, HELMOFWISDOM) || UsedItem(player, type, ref doMsgs, VALKYRIESHELM, VALKYRIESHELM) || UsedItem(player, type, ref doMsgs, RINGOFTHIEVES, RINGOFTHIEVES) || UsedItem(player, type, ref doMsgs, CRYSTALBALL, CRYSTALBALL)) {
                ShowText(player, type, doMsgs, "A door suddenly appears.");
                DoorHere(player, type, doMsgs);
                WallClear(player, type, doMsgs);
            }
            else {
                WallBlock(player, type, doMsgs);
            }
        }
        protected override void FnEvent0D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "As the winds swirl around, you hear a ghostly voice whispering something about benevolent spirits endowing you with certain attributes.");
        }
        protected override void FnEvent0E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetRace(player, type, doMsgs) == ORC) {
                ShowText(player, type, doMsgs, "The message on the plaque says 'Use the Coral before the Topaz.'");
            }
            else {
                ShowText(player, type, doMsgs, "Some guttural language pervades here.");
            }
        }
        protected override void FnEvent0F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetRace(player, type, doMsgs) == GNOME) {
                ShowText(player, type, doMsgs, "The message on the plaque says 'If given a choice, use the Opal third.'");
            }
            else {
                ShowText(player, type, doMsgs, "Only Gnomes can read this.");
            }
        }
        protected override void FnEvent10(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (UsedItem(player, type, ref doMsgs, MAZEKEY, MAZEKEY)) {
                WallClear(player, type, doMsgs);
                DoorHere(player, type, doMsgs);
                ShowText(player, type, doMsgs, "The Maze Key opens the door.");
            }
            else {
                WallBlock(player, type, doMsgs);
                ShowText(player, type, doMsgs, "The door is locked. Engraved on the lock are the words -");
                ShowText(player, type, doMsgs, "'Manufactured by");
                ShowText(player, type, doMsgs, "Aeowyn's Slateworks.");
                ShowText(player, type, doMsgs, "Zembolinee Bromerique,");
                ShowText(player, type, doMsgs, "Esquire.'");
            }
        }
        protected override void FnEvent11(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetRace(player, type, doMsgs) == DWARF) {
                ShowText(player, type, doMsgs, "The message on the plaque says 'Use Tyndil's payment first.'");
            }
            else {
                ShowText(player, type, doMsgs, "Ah, you recognize but don't understand the Dwarven runes.");
            }
        }
        protected override void FnEvent12(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, DWARFTHIEF);
            ShowText(player, type, doMsgs, "Flashing his black and white shield at you the thief states, 'It's aMAZEing how this shield guards against the dangers of this maze.'");
        }
        protected override void FnEvent13(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 4, 2, 185, Direction.West);
        }
        protected override void FnEvent14(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HasItem(player, type, doMsgs, HARMONYSGUARDIAN) || HasItem(player, type, doMsgs, CHAOSGUARDIAN)) {
                ShowText(player, type, doMsgs, "Your guardian protects you from the mist.");
            }
            else {
                ShowText(player, type, doMsgs, "A mist surrounds you absorbing some of your mana.");
                ModifyMana(player, type, doMsgs,  - 100);
            }
        }
        protected override void FnEvent15(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You stop and contemplate your luck in having found items which assist you in locating secret passages. These items have become handy.");
        }
        protected override void FnEvent16(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.SLATE_MAP) == 1) {
                if (HasItem(player, type, doMsgs, SLATEMAP)) {
                    EmptyRoom(player, type, doMsgs);
                    ItemTake(player, type, doMsgs);
                }
                else {
                    GiveItem(player, type, doMsgs, SLATEMAP);
                    MapPieceTxt(player, type, doMsgs);
                    ItemTake(player, type, doMsgs);
                }
            }
            else {
                if (HasItem(player, type, doMsgs, MAZEKEY)) {
                    GiveItem(player, type, doMsgs, SLATEMAP);
                    ModifyExperience(player, type, doMsgs, 200000);
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.SLATE_MAP, 1);
                    MapPieceTxt(player, type, doMsgs);
                    ItemTake(player, type, doMsgs);
                }
                else {
                    EmptyRoom(player, type, doMsgs);
                }
            }
        }
        protected override void FnEvent17(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 4, 2, 208, Direction.North);
        }
        protected override void FnEvent18(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You wander past a group of adventurers all lugging ropes and you wonder about their destination.");
        }
        protected override void FnEvent19(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 4, 2, 255, Direction.West);
        }
        protected override void FnEvent1A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, HALFLINGKNIGHT);
            ShowText(player, type, doMsgs, "You pass a knight who, as he hurries by, calls out - ");
            ShowText(player, type, doMsgs, "'I have traversed the Night Elves' Domain and have found the locations of Snicker's three brothers. Now off to find the item they desire!'");
        }
        protected override void FnEvent1B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 4, 1, 170, Direction.North);
        }
        protected override void FnEvent1D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HasItem(player, type, doMsgs, STONEOFAWARENESS)) {
                WallClear(player, type, doMsgs);
                DoorHere(player, type, doMsgs);
                ShowText(player, type, doMsgs, "The Stone of Awareness makes a door visible.");
            }
            else {
                WallBlock(player, type, doMsgs);
            }
        }
        protected override void FnEvent1E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 4, 2, 33, Direction.East);
        }
        protected override void FnEvent1F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, FOUNTAIN);
            ModifyHealth(player, type, doMsgs, GetHealthMax(player, type, doMsgs));
            ShowText(player, type, doMsgs, "The waters of Leeward Fountain heal your wounds.");
        }
        protected override void FnEvent21(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, DWARFKNIGHT);
            ShowText(player, type, doMsgs, "You pass a lost knight who toys with a stone.");
            ShowText(player, type, doMsgs, "The knight suddenly snarls at you, 'This is not it!");
            ShowText(player, type, doMsgs, "The stone I seek will let me find what is otherwise undetectable in this area of the dungeon!'");
        }
        protected override void FnEvent22(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 4, 2, 233, Direction.East);
        }
        protected override void FnEvent23(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, TROLLCLERIC);
            ShowText(player, type, doMsgs, "You stumble upon a cleric who says gravely, 'Not all fountains are good for your health.'");
        }
        protected override void FnEvent25(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 4, 2, 227, Direction.East);
        }
        protected override void FnEvent26(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You come across a worn journal telling an adventurer's story about becoming more skilled after scaling cliffs.");
        }
        protected override void FnEvent27(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HasItem(player, type, doMsgs, STONEOFAWARENESS)) {
                SetTreasure(player, type, doMsgs, SCROLLOFTHESUN, ELIXIROFHEALTH, 0, 0, 0, 1500);
                ShowText(player, type, doMsgs, "Golems attack you for your stone.");
            }
            else {
                SetTreasure(player, type, doMsgs, STONEOFAWARENESS, 0, 0, 0, 0, 3500);
                ShowText(player, type, doMsgs, "You see golems looking at a stone.");
            }
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 13);
                AddEncounter(player, type, doMsgs, 02, 12);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 11);
                AddEncounter(player, type, doMsgs, 02, 12);
                AddEncounter(player, type, doMsgs, 06, 14);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 11);
                AddEncounter(player, type, doMsgs, 02, 11);
                AddEncounter(player, type, doMsgs, 03, 13);
                AddEncounter(player, type, doMsgs, 05, 29);
                AddEncounter(player, type, doMsgs, 06, 30);
            }
        }
        protected override void FnEvent28(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.CHAOS_MAZE) == 1) {
                EmptyRoom(player, type, doMsgs);
            }
            else {
                if (GetAlignment(player, type, doMsgs) == CHAOS) {
                    ModifyGold(player, type, doMsgs, 25000);
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.CHAOS_MAZE, 1);
                    ShowText(player, type, doMsgs, "You find a bag with 25,000 gold pieces.");
                    GiveItem(player, type, doMsgs, LANCEOFDARKNESS);
                    GiveItem(player, type, doMsgs, GLASSBOW);
                }
                else {
                    ModifyGold(player, type, doMsgs,  - 2000);
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.CHAOS_MAZE, 1);
                    ShowText(player, type, doMsgs, "You are jumped by chaotic adventurers who steal 2,000 gold pieces.");
                }
            }
        }
        protected override void FnEvent29(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HasItem(player, type, doMsgs, CHAOSGUARDIAN) || HasItem(player, type, doMsgs, HARMONYSGUARDIAN)) {
                WallClear(player, type, doMsgs);
                DoorHere(player, type, doMsgs);
                ShowText(player, type, doMsgs, "The fog lifts and you see the door to the Tool Shed.");
            }
            else {
                WallBlock(player, type, doMsgs);
            }
        }
        protected override void FnEvent2A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HasItem(player, type, doMsgs, TNEPRESKEY)) {
                SetTreasure(player, type, doMsgs, REFRESHSCROLL, BLESSPOTION, 0, 0, 0, 1500);
                ShowText(player, type, doMsgs, "Nasty looking monsters attack you for your key.");
            }
            else {
                SetTreasure(player, type, doMsgs, TNEPRESKEY, MANAELIXIR, BLESSPOTION, 0, 0, 3000);
                ShowText(player, type, doMsgs, "Vicious monsters stand guard over an S-shaped key.");
            }
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 1);
                AddEncounter(player, type, doMsgs, 02, 4);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 2);
                AddEncounter(player, type, doMsgs, 02, 27);
                AddEncounter(player, type, doMsgs, 06, 5);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 2);
                AddEncounter(player, type, doMsgs, 02, 2);
                AddEncounter(player, type, doMsgs, 04, 3);
                AddEncounter(player, type, doMsgs, 05, 26);
                AddEncounter(player, type, doMsgs, 06, 27);
            }
        }
        protected override void FnEvent2C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HasItem(player, type, doMsgs, CHAOSGUARDIAN) || HasItem(player, type, doMsgs, HARMONYSGUARDIAN)) {
                WallClear(player, type, doMsgs);
                DoorHere(player, type, doMsgs);
                ShowText(player, type, doMsgs, "The fog lifts and you see the door to the Gardener's Shed.");
            }
            else {
                WallBlock(player, type, doMsgs);
            }
        }
        protected override void FnEvent2D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HARMONY_MAZE) == 1) {
                EmptyRoom(player, type, doMsgs);
            }
            else {
                if (GetAlignment(player, type, doMsgs) == HARMONY) {
                    ModifyGold(player, type, doMsgs, 25000);
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HARMONY_MAZE, 1);
                    ShowText(player, type, doMsgs, "You find a bag with 25,000 gold pieces.");
                    GiveItem(player, type, doMsgs, PEACEMAKER);
                    GiveItem(player, type, doMsgs, HEAVENSWRATH);
                }
                else {
                    ModifyGold(player, type, doMsgs,  - 2000);
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HARMONY_MAZE, 1);
                    ShowText(player, type, doMsgs, "You are jumped by harmonic adventurers who steal 2,000 gold pieces.");
                }
            }
        }
        protected override void FnEvent2E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HasItem(player, type, doMsgs, HARMONYSGUARDIAN) || HasItem(player, type, doMsgs, CHAOSGUARDIAN)) {
                ShowText(player, type, doMsgs, "Your guardian protects you from injury.");
            }
            else {
                if (GetFlag(player, type, doMsgs, FlagTypeTile, BRICK_ZAP) == 0) {
                    DoDamage(player, type, doMsgs, GetHealthMax(player, type, doMsgs) / 5);
                    ShowText(player, type, doMsgs, "A loose brick falls from the maze wall and injures you.");
                    SetFlag(player, type, doMsgs, FlagTypeTile, BRICK_ZAP, 1);
                }
            }
        }
        protected override void FnEvent2F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ModifyHealth(player, type, doMsgs, GetHealthMax(player, type, doMsgs));
            ModifyMana(player, type, doMsgs, 10000);
            ShowText(player, type, doMsgs, "The swirling waters of the Whirlwind Pool increase your health and mana.");
        }
        protected override void FnEvent30(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Inside a quest bag you find a scribbled note to another adventurer...");
            ShowText(player, type, doMsgs, "'Rumor has it that treasure might still be hidden in a safe.'");
        }
        protected override void FnEvent31(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HasItem(player, type, doMsgs, HARMONYSGUARDIAN)) {
                SetTreasure(player, type, doMsgs, CURATIVEELIXIR, MANAELIXIR, 0, 0, 0, 1000);
            }
            else {
                if (GetAlignment(player, type, doMsgs) == HARMONY) {
                    SetTreasure(player, type, doMsgs, HARMONYSGUARDIAN, CUREALLPOTION, MANAELIXIR, 0, 0, 3000);
                    ShowText(player, type, doMsgs, "You see a shield on the floor, but the way is blocked.");
                }
                else {
                    ModifyExperience(player, type, doMsgs,  - 5000);
                    SetTreasure(player, type, doMsgs, MANAPOTION, 0, 0, 0, 0, 1);
                    ShowText(player, type, doMsgs, "You lose experience for not heeding warnings.");
                }
            }
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 6);
                AddEncounter(player, type, doMsgs, 02, 8);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 7);
                AddEncounter(player, type, doMsgs, 02, 7);
                AddEncounter(player, type, doMsgs, 06, 9);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 7);
                AddEncounter(player, type, doMsgs, 02, 7);
                AddEncounter(player, type, doMsgs, 04, 8);
                AddEncounter(player, type, doMsgs, 05, 8);
                AddEncounter(player, type, doMsgs, 06, 28);
            }
        }
        protected override void FnEvent32(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, HALFLINGRANGER);
            ShowText(player, type, doMsgs, "'Excuse me? I'm trying to find the Ballroom. I must be completely lost.");
            ShowText(player, type, doMsgs, "Oh, if you ever find yourself in the Ballroom, make sure you have your musical key ready.'");
        }
        protected override void FnEvent33(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HasItem(player, type, doMsgs, CHAOSGUARDIAN)) {
                SetTreasure(player, type, doMsgs, CURATIVEELIXIR, MANAELIXIR, 0, 0, 0, 1000);
            }
            else {
                if (GetAlignment(player, type, doMsgs) == CHAOS) {
                    SetTreasure(player, type, doMsgs, CHAOSGUARDIAN, CUREALLPOTION, MANAELIXIR, 0, 0, 3000);
                    ShowText(player, type, doMsgs, "You see a shield on the floor, but the way to it is blocked.");
                }
                else {
                    ModifyExperience(player, type, doMsgs,  - 5000);
                    SetTreasure(player, type, doMsgs, MANAPOTION, 0, 0, 0, 0, 1);
                    ShowText(player, type, doMsgs, "You lose experience for not heeding warnings.");
                }
            }
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 6);
                AddEncounter(player, type, doMsgs, 02, 8);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 7);
                AddEncounter(player, type, doMsgs, 02, 7);
                AddEncounter(player, type, doMsgs, 06, 9);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 7);
                AddEncounter(player, type, doMsgs, 02, 7);
                AddEncounter(player, type, doMsgs, 04, 8);
                AddEncounter(player, type, doMsgs, 05, 8);
                AddEncounter(player, type, doMsgs, 06, 28);
            }
        }
        protected override void FnEvent34(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "The door to the north bears a sign - 'Harmony Only.' The door to the west bears a sign - 'Chaos Only.'");
        }
        protected override void FnEvent35(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetAlignment(player, type, doMsgs) == HARMONY) {
                ShowText(player, type, doMsgs, "A secret message for Harmonics only is posted on the door. 'Do not enter the Tool Shed.'");
            }
        }
        protected override void FnEvent36(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetAlignment(player, type, doMsgs) == CHAOS) {
                ShowText(player, type, doMsgs, "A secret message for Chaotics only is posted on the door. 'Do not enter the Gardener's Shed.'");
            }
        }
        protected override void FnEvent37(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 34);
                AddEncounter(player, type, doMsgs, 02, 39);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 17);
                AddEncounter(player, type, doMsgs, 02, 34);
                AddEncounter(player, type, doMsgs, 06, 36);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 17);
                AddEncounter(player, type, doMsgs, 02, 33);
                AddEncounter(player, type, doMsgs, 03, 37);
                AddEncounter(player, type, doMsgs, 04, 38);
                AddEncounter(player, type, doMsgs, 05, 37);
            }
        }
        protected override void FnEvent38(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 1);
                AddEncounter(player, type, doMsgs, 02, 8);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 8);
                AddEncounter(player, type, doMsgs, 02, 9);
                AddEncounter(player, type, doMsgs, 06, 26);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 26);
                AddEncounter(player, type, doMsgs, 02, 26);
                AddEncounter(player, type, doMsgs, 03, 27);
                AddEncounter(player, type, doMsgs, 05, 8);
                AddEncounter(player, type, doMsgs, 06, 28);
            }
        }
        protected override void FnEvent39(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 10);
                AddEncounter(player, type, doMsgs, 02, 13);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 11);
                AddEncounter(player, type, doMsgs, 02, 13);
                AddEncounter(player, type, doMsgs, 05, 40);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 11);
                AddEncounter(player, type, doMsgs, 02, 13);
                AddEncounter(player, type, doMsgs, 04, 14);
                AddEncounter(player, type, doMsgs, 05, 31);
                AddEncounter(player, type, doMsgs, 06, 40);
            }
        }
        protected override void FnEvent3A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 39);
                AddEncounter(player, type, doMsgs, 02, 17);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 17);
                AddEncounter(player, type, doMsgs, 02, 17);
                AddEncounter(player, type, doMsgs, 03, 19);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 17);
                AddEncounter(player, type, doMsgs, 02, 17);
                AddEncounter(player, type, doMsgs, 03, 19);
                AddEncounter(player, type, doMsgs, 04, 34);
                AddEncounter(player, type, doMsgs, 06, 35);
            }
        }
        protected override void FnEvent3B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 8);
                AddEncounter(player, type, doMsgs, 02, 12);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 8);
                AddEncounter(player, type, doMsgs, 02, 9);
                AddEncounter(player, type, doMsgs, 03, 13);
                AddEncounter(player, type, doMsgs, 04, 30);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 9);
                AddEncounter(player, type, doMsgs, 02, 29);
                AddEncounter(player, type, doMsgs, 03, 13);
                AddEncounter(player, type, doMsgs, 05, 28);
                AddEncounter(player, type, doMsgs, 06, 16);
            }
        }
        protected override void FnEvent3C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 1);
                AddEncounter(player, type, doMsgs, 02, 2);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 1);
                AddEncounter(player, type, doMsgs, 02, 1);
                AddEncounter(player, type, doMsgs, 05, 2);
                AddEncounter(player, type, doMsgs, 06, 3);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 2);
                AddEncounter(player, type, doMsgs, 02, 2);
                AddEncounter(player, type, doMsgs, 04, 27);
                AddEncounter(player, type, doMsgs, 05, 4);
                AddEncounter(player, type, doMsgs, 06, 25);
            }
        }
        protected override void FnEvent3D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 39);
                AddEncounter(player, type, doMsgs, 02, 39);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 16);
                AddEncounter(player, type, doMsgs, 02, 16);
                AddEncounter(player, type, doMsgs, 03, 17);
                AddEncounter(player, type, doMsgs, 04, 18);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 36);
                AddEncounter(player, type, doMsgs, 02, 21);
                AddEncounter(player, type, doMsgs, 03, 20);
                AddEncounter(player, type, doMsgs, 05, 28);
                AddEncounter(player, type, doMsgs, 06, 8);
            }
        }
        protected override void FnEvent3E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 23);
                AddEncounter(player, type, doMsgs, 02, 13);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 29);
                AddEncounter(player, type, doMsgs, 02, 29);
                AddEncounter(player, type, doMsgs, 05, 23);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 29);
                AddEncounter(player, type, doMsgs, 02, 29);
                AddEncounter(player, type, doMsgs, 03, 30);
                AddEncounter(player, type, doMsgs, 05, 24);
                AddEncounter(player, type, doMsgs, 06, 38);
            }
        }
        private void MapPieceTxt(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You find a Map etched on a piece of slate. It must be one of the four maps Queen Aeowyn sent you to find.");
            ShowText(player, type, doMsgs, "Your Maze Key and Stone of Awareness dissipate as you grab it.");
        }
        private void WallClear(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
        }
        private void WallBlock(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
        }
        private void DoorHere(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetWallItem(player, type, doMsgs, DOOR, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
        }
        private void ItemTake(TwPlayerServer player, MapEventType type, bool doMsgs) {
            RemoveItem(player, type, doMsgs, MAZEKEY);
            RemoveItem(player, type, doMsgs, STONEOFAWARENESS);
        }
        private void DamXit(TwPlayerServer player, MapEventType type, bool doMsgs) {
            DoDamage(player, type, doMsgs, GetHealthMax(player, type, doMsgs));
        }
        private void EmptyRoom(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "The room is empty.");
        }
    }
}
