using XPT.Games.Generic.Constants;
using XPT.Games.Generic.Maps;
using XPT.Games.Twinion.Entities;

namespace XPT.Games.Twinion.Maps {
    /// <summary>
    /// L2: Queen's Aqueduct
    /// </summary>
    class TwMap03 : TwMap {
        public override int MapIndex => 3;
        public override int MapID => 0x0201;
        protected override int RandomEncounterChance => 12;
        protected override int RandomEncounterExtraCount => 0;

        private const int NPCINCORNER = 1;
        private const int MET_ELF = 2;
        private const int WENTTHRU = 3;
        private const int BEENROBBED = 4;
        private const int WESTENTRANCE = 5;
        private const int GULPEDWATER = 1;
        private const int SPRUNGTRAP = 2;
        protected override void FnEvent01(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "This portal leads back to the main entrance.");
            TeleportParty(player, type, doMsgs, 1, 1, 71, Direction.South);
        }
        protected override void FnEvent02(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You see another room through the east door.");
            TeleportParty(player, type, doMsgs, 2, 2, 160, Direction.East);
        }
        protected override void FnEvent03(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Another hall leads west through this door.");
            TeleportParty(player, type, doMsgs, 2, 3, 175, Direction.West);
        }
        protected override void FnEvent04(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "This may lead back to whence you came....");
            TeleportParty(player, type, doMsgs, 2, 2, 240, Direction.East);
        }
        protected override void FnEvent05(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "This must take you somewhere important....");
            TeleportParty(player, type, doMsgs, 2, 1, 85, Direction.North);
        }
        protected override void FnEvent06(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetFlag(player, type, doMsgs, FlagTypeTile, SPRUNGTRAP) == 0)) {
                ShowText(player, type, doMsgs, "This portal will send you to the next level of the Queen's tests.");
                SetFlag(player, type, doMsgs, FlagTypeTile, SPRUNGTRAP, 1);
            }
            TeleportParty(player, type, doMsgs, 3, 1, 136, Direction.North);
        }
        protected override void FnEvent07(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowRunes(player, type, ref doMsgs, "You see a teleport.");
            TeleportParty(player, type, doMsgs, 2, 1, 7, Direction.West);
        }
        protected override void FnEvent08(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowRunes(player, type, ref doMsgs, "You see a teleport.");
            TeleportParty(player, type, doMsgs, 2, 1, 9, Direction.East);
        }
        protected override void FnEvent09(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Where does this lead, you wonder...");
            TeleportParty(player, type, doMsgs, 2, 1, 0, Direction.West);
        }
        protected override void FnEvent0A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowRunes(player, type, ref doMsgs, "BEHOLD: Here is the Twinion aqueduct, built by her majesty Queen Aeowyn for her loyal subjects' benefit. Long live the Queen!");
        }
        protected override void FnEvent0B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowRunes(player, type, ref doMsgs, "DO NOT ENTER!");
        }
        protected override void FnEvent0C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowRunes(player, type, ref doMsgs, "WRONG WAY!!!");
        }
        protected override void FnEvent0D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowRunes(player, type, ref doMsgs, "For your own sake, can't you read??? TURN BACK!!");
        }
        protected override void FnEvent0E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowRunes(player, type, ref doMsgs, "Okay, fine...don't listen to the warnings but see if I warn you again not to do something!!!");
        }
        protected override void FnEvent0F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.I_QUEST_LEFT) == 0)) {
                ShowText(player, type, doMsgs, "Well done! Onward to more adventure...");
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.I_QUEST_LEFT, 1);
            }
        }
        protected override void FnEvent10(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.I_QUEST_RIGHT) == 0)) {
                ShowText(player, type, doMsgs, "Well done! Onward to greater tests...");
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.I_QUEST_RIGHT, 1);
            }
        }
        protected override void FnEvent11(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Sounds of flowing water echo and cascade all around you, as you enter the corridors of the Aqueduct.");
        }
        protected override void FnEvent12(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "The water in the magical Aqueduct rushes by in a fierce torrent...");
        }
        protected override void FnEvent13(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "The treacherous undertow quickly pulls you under, drowning you as it has done so many others.");
            DoDamage(player, type, doMsgs, GetHealthMax(player, type, doMsgs));
        }
        protected override void FnEvent14(TwPlayerServer player, MapEventType type, bool doMsgs) {
            DisableHealing(player, type, doMsgs);
            if ((GetFlag(player, type, doMsgs, FlagTypeTile, SPRUNGTRAP) == 0)) {
                if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.KILLEDAQUEUS) == 0)) {
                    ShowText(player, type, doMsgs, "The force of the Aqueduct's waters pound violently against your body...");
                    DoDamage(player, type, doMsgs, GetHealthMax(player, type, doMsgs) / 8 + 1);
                    if (GetHealthCurrent(player, type, doMsgs) <= 0) {
                        ShowText(player, type, doMsgs, "You have been drowned by the force.");
                    }
                }
                else {
                    ShowText(player, type, doMsgs, "You've defeated Aqueus! You may travel safely through these waters.");
                }
                SetFlag(player, type, doMsgs, FlagTypeTile, SPRUNGTRAP, 1);
            }
        }
        private void PutDoor(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetWallItem(player, type, doMsgs, DOOR, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
        }
        private void RoomSet(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetFlag(player, type, doMsgs, FlagTypeTile, GULPEDWATER, 1);
        }
        private void WallBlock(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
        }
        private void WallClear(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
        }
        protected override void FnEvent15(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetTileBlock(player, type, doMsgs, GetTile(player, type, doMsgs));
        }
        protected override void FnEvent16(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "The Aqueduct's current seems particularly violent and dangerous to the east...");
        }
        protected override void FnEvent17(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "This bridge seems stable enough... However, the water rushing below your feet makes you nervous.");
        }
        protected override void FnEvent18(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.KILLEDAQUEUS) == 1) {
                    WallClear(player, type, doMsgs);
                    ShowText(player, type, doMsgs, "Enter here, now that you've conquered Lord Aqueus.");
                }
                else {
                    WallBlock(player, type, doMsgs);
                    ShowText(player, type, doMsgs, "Seek the protector of this Aqueduct in the west. His magic blocks your forward path.");
                }
            }
            else {
                ShowText(player, type, doMsgs, "You must pass through alone.");
                WallBlock(player, type, doMsgs);
            }
        }
        protected override void FnEvent19(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((HasUsedSkill(player, type, ref doMsgs, DETECT_SKILL) >= 6) || (HasUsedSpell(player, type, ref doMsgs, TRUE_SEEING_SPELL) >= 1) || UsedItem(player, type, ref doMsgs, HELMOFWISDOM, HELMOFWISDOM) || UsedItem(player, type, ref doMsgs, VALKYRIESHELM, VALKYRIESHELM) || UsedItem(player, type, ref doMsgs, RINGOFTHIEVES, RINGOFTHIEVES) || UsedItem(player, type, ref doMsgs, CRYSTALBALL, CRYSTALBALL)) {
                ShowText(player, type, doMsgs, "You've located a secret passageway!!");
                WallClear(player, type, doMsgs);
                PutDoor(player, type, doMsgs);
            }
            else {
                WallBlock(player, type, doMsgs);
                ShowText(player, type, doMsgs, "There seems to be a subtle draft coming from a nearby wall.");
            }
        }
        protected override void FnEvent1A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.ONE_AND_THREE_DONE) == 2) {
                ShowText(player, type, doMsgs, "You've passed here before! Onward with you!");
                WallClear(player, type, doMsgs);
            }
            else if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.ONE_AND_THREE_DONE) == 1) {
                ShowText(player, type, doMsgs, "A female voice whispers: 'You've so far passed our test with high marks.");
                ShowText(player, type, doMsgs, "Let's see how well you finish it.'");
                WallClear(player, type, doMsgs);
                PutDoor(player, type, doMsgs);
                ModifyExperience(player, type, doMsgs, 2500);
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.ONE_AND_THREE_DONE, 2);
            }
            else if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.I_QUEST_RIGHT) == 3 && GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.I_QUEST_LEFT) == 3) {
                ShowText(player, type, doMsgs, "A woman's voice carries on the wind: 'You have completed enough to carry forward.");
                ShowText(player, type, doMsgs, "I pray thee, complete more and return later.'");
                WallClear(player, type, doMsgs);
            }
            else {
                ShowText(player, type, doMsgs, "A woman's voice carries on the wind: 'Come back when you've done more of this quest.'");
                WallBlock(player, type, doMsgs);
            }
        }
        protected override void FnEvent1B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeParty, WENTTHRU) == 1) {
                ShowText(player, type, doMsgs, "Now, to your reward for this trial...");
                WallClear(player, type, doMsgs);
                PutDoor(player, type, doMsgs);
            }
            else {
                ShowText(player, type, doMsgs, "Continue northward through the rest of this corner, my heroes...");
                WallBlock(player, type, doMsgs);
            }
        }
        protected override void FnEvent1C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.I_QUEST_LEFT) == 0) && (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.I_QUEST_RIGHT) == 0)) {
                    ShowText(player, type, doMsgs, "This direction is open to you.");
                    WallClear(player, type, doMsgs);
                }
                else if (IsFlagOn(player, type, doMsgs, FlagTypeDungeon, TwIndexes.I_QUEST_RIGHT) && (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.I_QUEST_LEFT) == 0)) {
                    ShowText(player, type, doMsgs, "The eastern door is sealed shut.");
                    SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.East);
                    ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.South);
                }
                else if (IsFlagOn(player, type, doMsgs, FlagTypeDungeon, TwIndexes.I_QUEST_LEFT) && (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.I_QUEST_RIGHT) == 0)) {
                    ShowText(player, type, doMsgs, "The southern door is sealed shut.");
                    SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.South);
                    ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.East);
                }
                else {
                    ShowText(player, type, doMsgs, "The doors are sealed.");
                    WallBlock(player, type, doMsgs);
                }
            }
            else {
                WallBlock(player, type, doMsgs);
                ShowText(player, type, doMsgs, "You must start from here alone.");
            }
        }
        protected override void FnEvent1D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, ELFBARBARIAN);
            if ((GetFlag(player, type, doMsgs, FlagTypeParty, MET_ELF) == 0)) {
                ShowText(player, type, doMsgs, "You encounter a soaking wet elf, wringing out her clothes. 'Her majesty's idea of draining the River of Eternity is a good one, albeit a bit late for my brother.'");
                SetFlag(player, type, doMsgs, FlagTypeParty, MET_ELF, 1);
            }
            else if (GetFlag(player, type, doMsgs, FlagTypeParty, MET_ELF) == 1) {
                ShowText(player, type, doMsgs, "'Beware of the strong currents of this vile water.'");
                SetFlag(player, type, doMsgs, FlagTypeParty, MET_ELF, 2);
            }
            else {
                ShowText(player, type, doMsgs, "The elf stares blankly at the waters.");
            }
        }
        protected override void FnEvent1E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int mn = 0;
            int mn2 = 0;
            int mn3 = 0;
            int mn4 = 0;
            int g2 = 0;
            int g3 = 0;
            int g4 = 0;
            switch (GetPartyCount(player, type, doMsgs)) {
                case 1:
                    mn = 37;
                    mn2 = 37;
                    g2 = 2;
                    break;
                case 2:
                    mn = 37;
                    mn2 = 37;
                    mn3 = 38;
                    g2 = 2;
                    g3 = 4;
                    break;
                default:
                    mn = 33;
                    mn2 = 33;
                    mn3 = 38;
                    mn4 = 38;
                    g2 = 2;
                    g3 = 5;
                    g4 = 6;
                    break;
            }
            AddEncounter(player, type, doMsgs, 01, mn);
            if (g2 != 0) {
                AddEncounter(player, type, doMsgs, g2, mn2);
                if (g3 != 0) {
                    AddEncounter(player, type, doMsgs, g3, mn3);
                    if (g4 != 0) {
                        AddEncounter(player, type, doMsgs, g4, mn4);
                    }
                }
            }
        }
        protected override void FnEvent1F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int mn = 0;
            int mn2 = 0;
            int mn3 = 0;
            int mn4 = 0;
            int g2 = 0;
            int g3 = 0;
            int g4 = 0;
            switch (GetPartyCount(player, type, doMsgs)) {
                case 1:
                    mn = 34;
                    mn2 = 36;
                    g2 = 5;
                    break;
                case 2:
                    mn = 34;
                    mn2 = 36;
                    mn3 = 35;
                    g2 = 2;
                    g3 = 5;
                    break;
                default:
                    mn = 35;
                    mn2 = 35;
                    mn3 = 35;
                    mn4 = 36;
                    g2 = 2;
                    g3 = 3;
                    g4 = 4;
                    break;
            }
            AddEncounter(player, type, doMsgs, 01, mn);
            if (g2 != 0) {
                AddEncounter(player, type, doMsgs, g2, mn2);
                if (g3 != 0) {
                    AddEncounter(player, type, doMsgs, g3, mn3);
                    if (g4 != 0) {
                        AddEncounter(player, type, doMsgs, g4, mn4);
                    }
                }
            }
        }
        protected override void FnEvent20(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int i = 0;
            if (GetTile(player, type, doMsgs) == 228) {
                SetTreasure(player, type, doMsgs, REDLOCKPICK, 0, 0, 0, 0, 100);
            }
            for (i = 1; i <= 3; i++) {
                AddEncounter(player, type, doMsgs, i, 5);
            }
        }
        protected override void FnEvent21(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int mn = 0;
            int mn2 = 0;
            int mn3 = 0;
            int g2 = 0;
            int g3 = 0;
            switch (GetPartyCount(player, type, doMsgs)) {
                case 1:
                    mn = 3;
                    mn2 = 3;
                    g2 = 2;
                    break;
                case 2:
                    mn = 3;
                    mn2 = 4;
                    g2 = 2;
                    break;
                default:
                    mn = 3;
                    mn2 = 4;
                    mn3 = 5;
                    g2 = 2;
                    g3 = 6;
                    break;
            }
            AddEncounter(player, type, doMsgs, 01, mn);
            if (g2 != 0) {
                AddEncounter(player, type, doMsgs, g2, mn2);
                if (g3 != 0) {
                    AddEncounter(player, type, doMsgs, g3, mn3);
                }
            }
        }
        protected override void FnEvent22(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 37);
                AddEncounter(player, type, doMsgs, 02, 37);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 37);
                AddEncounter(player, type, doMsgs, 02, 37);
                AddEncounter(player, type, doMsgs, 03, 38);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 33);
                AddEncounter(player, type, doMsgs, 02, 33);
                AddEncounter(player, type, doMsgs, 03, 38);
                AddEncounter(player, type, doMsgs, 04, 38);
            }
        }
        protected override void FnEvent23(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int i = 0;
            ShowText(player, type, doMsgs, "You approach a band of Warriors, who howl furiously as they charge you with axes held high.");
            switch (GetPartyCount(player, type, doMsgs)) {
                case 1:
                    for (i = 1; i <= 3; i++) {
                        AddEncounter(player, type, doMsgs, i, 38);
                    }
                    break;
                default:
                    for (i = 1; i <= 6; i++) {
                        AddEncounter(player, type, doMsgs, i, 38);
                    }
                    break;
            }
        }
        protected override void FnEvent24(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "A party of adventurers springs at you!");
            switch (GetPartyCount(player, type, doMsgs)) {
                case 1:
                    AddEncounter(player, type, doMsgs, 01, 10);
                    AddEncounter(player, type, doMsgs, 02, 18);
                    break;
                case 2:
                    AddEncounter(player, type, doMsgs, 01, 10);
                    AddEncounter(player, type, doMsgs, 02, 18);
                    AddEncounter(player, type, doMsgs, 05, 23);
                    AddEncounter(player, type, doMsgs, 06, 27);
                    break;
                default:
                    AddEncounter(player, type, doMsgs, 01, 10);
                    AddEncounter(player, type, doMsgs, 02, 18);
                    AddEncounter(player, type, doMsgs, 03, 23);
                    AddEncounter(player, type, doMsgs, 04, 27);
                    AddEncounter(player, type, doMsgs, 05, 12);
                    AddEncounter(player, type, doMsgs, 06, 31);
                    break;
                }
            }
            protected override void FnEvent25(TwPlayerServer player, MapEventType type, bool doMsgs) {
                ShowText(player, type, doMsgs, "Some worthy opponents challenge you to combat...");
                AddEncounter(player, type, doMsgs, 01, 15);
                AddEncounter(player, type, doMsgs, 02, 21);
                AddEncounter(player, type, doMsgs, 03, 22);
                AddEncounter(player, type, doMsgs, 04, 23);
            }
            protected override void FnEvent26(TwPlayerServer player, MapEventType type, bool doMsgs) {
                int itemA = 0;
                if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.NPCGIFTONE) == 0)) {
                    ShowPortrait(player, type, doMsgs, ORCRANGER);
                    ShowText(player, type, doMsgs, "'Well done! You managed to complete that simple maze of doors.  A gift of experience, gold and booty is yours.'");
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.NPCGIFTONE, 1);
                    switch (GetGuild(player, type, doMsgs)) {
                        case BARBARIAN:
                            itemA = STONECLUB;
                            break;
                        case KNIGHT:
                            itemA = CHAINMAIL;
                            break;
                        case RANGER:
                            itemA = CHAINMAIL;
                            break;
                        case THIEF:
                            itemA = BLOODSHIELD;
                            break;
                        case CLERIC:
                            itemA = FREEDOMRING;
                            break;
                        case WIZARD:
                            itemA = QUARTERSTAFF;
                            break;
                    }
                    GiveItem(player, type, doMsgs, itemA);
                    ModifyGold(player, type, doMsgs, 500);
                    ModifyExperience(player, type, doMsgs, 400);
                }
                else {
                    ShowText(player, type, doMsgs, "The ranger is gone.");
                }
            }
            protected override void FnEvent27(TwPlayerServer player, MapEventType type, bool doMsgs) {
                if ((GetFlag(player, type, doMsgs, FlagTypeParty, BEENROBBED) == 0)) {
                    ShowText(player, type, doMsgs, "A nimble thief lifts a sack of gold from you.");
                    ShowText(player, type, doMsgs, "'Hmmm, what a lovely purse! Perchance I will find its twin once I've dispensed with you!'");
                    ModifyGold(player, type, doMsgs,  - 500);
                    AddEncounter(player, type, doMsgs, 01, 25);
                }
            }
            protected override void FnEvent28(TwPlayerServer player, MapEventType type, bool doMsgs) {
                if (GetFlag(player, type, doMsgs, FlagTypeParty, NPCINCORNER) == 0) {
                    ShowPortrait(player, type, doMsgs, HALFLINGTHIEF);
                    ShowText(player, type, doMsgs, "A dying thief lies on the floor. 'Forgive my brethren. They know only to survive...'");
                    ShowText(player, type, doMsgs, "He then collapses, dead.");
                    SetFlag(player, type, doMsgs, FlagTypeParty, NPCINCORNER, 1);
                }
                else {
                    ShowText(player, type, doMsgs, "'You have done this...murderers!!!!!'");
                    SetTreasure(player, type, doMsgs, KATANA, NUNCHUKAS, 0, 0, 0, 2000);
                    AddEncounter(player, type, doMsgs, 01, 26);
                    AddEncounter(player, type, doMsgs, 02, 26);
                    AddEncounter(player, type, doMsgs, 05, 25);
                    AddEncounter(player, type, doMsgs, 06, 40);
                }
            }
            protected override void FnEvent29(TwPlayerServer player, MapEventType type, bool doMsgs) {
                int i = 0;
                if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.NPCGIFTONE) <= 1) {
                    ShowPortrait(player, type, doMsgs, HALFLINGTHIEF);
                    ShowText(player, type, doMsgs, "'How lovely, what marvelous gold you had...'");
                    ModifyGold(player, type, doMsgs,  - 250);
                    ShowText(player, type, doMsgs, "'A thousand gratitudes for your generosity.'");
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.NPCGIFTONE, 2);
                }
                else if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.NPCGIFTONE) == 2) {
                    ShowText(player, type, doMsgs, "A familiar pickpocket is here with some of his friends. Now's your chance!");
                    SetTreasure(player, type, doMsgs, LONGSWORD, TRANCETALISMAN, 0, 0, 0, 250);
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.NPCGIFTONE, 3);
                }
                for (i = 1; i <= 3; i++) {
                    AddEncounter(player, type, doMsgs, i, 26);
                }
            }
            protected override void FnEvent2A(TwPlayerServer player, MapEventType type, bool doMsgs) {
                ShowPortrait(player, type, doMsgs, ELFBARBARIAN);
                ShowText(player, type, doMsgs, "The elf you met earlier is here, now drying out from her travels.");
                if ((GetFlag(player, type, doMsgs, FlagTypeParty, MET_ELF) == 0) || GetFlag(player, type, doMsgs, FlagTypeParty, MET_ELF) == 2) {
                    ShowText(player, type, doMsgs, "'Hmm...if right were first, left would be worse... If left were before, the bridge would lead thru the door... Very confusing...'");
                    SetFlag(player, type, doMsgs, FlagTypeParty, MET_ELF, 3);
                }
                else if (GetFlag(player, type, doMsgs, FlagTypeParty, MET_ELF) == 3) {
                    ShowText(player, type, doMsgs, "'I guess you must do one of the other rooms on this level first. Then come back here to go on.'");
                }
                else {
                    ShowText(player, type, doMsgs, "She pays no attention to you.");
                    SetFlag(player, type, doMsgs, FlagTypeParty, MET_ELF, 2);
                }
            }
            protected override void FnEvent2B(TwPlayerServer player, MapEventType type, bool doMsgs) {
                if ((GetFlag(player, type, doMsgs, FlagTypeTile, GULPEDWATER) == 0)) {
                    ShowPortrait(player, type, doMsgs, DWARFKNIGHT);
                    ShowText(player, type, doMsgs, "'You dare think you can challenge me...you with your puny stature? Away with you!!'");
                    ShowText(player, type, doMsgs, "So saying, this massive knight flies into a rage, critically wounding all in his path as he marches off.");
                    DoDamage(player, type, doMsgs, GetHealthMax(player, type, doMsgs) / 2);
                    if (GetHealthCurrent(player, type, doMsgs) <= 0) {
                        ShowText(player, type, doMsgs, "You have died.");
                        // DungXit(player, type, doMsgs);
                    }
                    DoDamage(player, type, doMsgs, GetHealthCurrent(player, type, doMsgs) / 2);
                    RoomSet(player, type, doMsgs);
                }
            }
            protected override void FnEvent2C(TwPlayerServer player, MapEventType type, bool doMsgs) {
                ShowPortrait(player, type, doMsgs, DWARFTHIEF);
                ShowText(player, type, doMsgs, "A nimble thief steps from the shadows in front of you.");
                if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.GOTSCAR) == 1) {
                    ShowText(player, type, doMsgs, "The thief glances in your direction, sees his mark, and ignores you.");
                }
                else if (IsFlagOn(player, type, doMsgs, FlagTypeDungeon, TwIndexes.I_QUEST_RIGHT) && IsFlagOn(player, type, doMsgs, FlagTypeDungeon, TwIndexes.I_QUEST_LEFT) || GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.KILLEDAQUEUS) == 1) {
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.ONE_AND_THREE_DONE, 1);
                    ShowText(player, type, doMsgs, "'A scar for you to prove you've done this task. Pray thee, continue south.'");
                    DoDamage(player, type, doMsgs, GetHealthCurrent(player, type, doMsgs) / 10);
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.GOTSCAR, 1);
                }
                else {
                    ShowText(player, type, doMsgs, "'AH HA! Too much gold in your purse! Allow me...");
                    ModifyGold(player, type, doMsgs,  - 300);
                    ShowText(player, type, doMsgs, "Complete the tasks at hand before you attempt the quests east of here!'");
                    DoDamage(player, type, doMsgs, GetHealthCurrent(player, type, doMsgs) / 2);
                    TeleportParty(player, type, doMsgs, 2, 1, 121, Direction.North);
                }
            }
            protected override void FnEvent2D(TwPlayerServer player, MapEventType type, bool doMsgs) {
                DisableHealing(player, type, doMsgs);
                if ((GetFlag(player, type, doMsgs, FlagTypeTile, GULPEDWATER) == 0)) {
                    SetFacing(player, type, doMsgs, Direction.East);
                    ShowText(player, type, doMsgs, "The swirling currents here batter and sting your body.");
                    DoDamage(player, type, doMsgs, GetHealthMax(player, type, doMsgs) / 4 + 1);
                    if (GetHealthCurrent(player, type, doMsgs) <= 0) {
                        ShowText(player, type, doMsgs, "You have been drowned by the force.");
                        // DungXit(player, type, doMsgs);
                    }
                    RoomSet(player, type, doMsgs);
                }
            }
            protected override void FnEvent2E(TwPlayerServer player, MapEventType type, bool doMsgs) {
                if (HasUsedSkill(player, type, ref doMsgs, LOCKPICK_SKILL) == 12 || UsedItem(player, type, ref doMsgs, HELMOFGUILE, HELMOFGUILE) || UsedItem(player, type, ref doMsgs, REDLOCKPICK, BLUELOCKPICK)) {
                    ShowText(player, type, doMsgs, "You unlock the door.");
                    WallClear(player, type, doMsgs);
                }
                else {
                    WallBlock(player, type, doMsgs);
                    ShowText(player, type, doMsgs, "An impressive lock bars this shortcut from you.");
                }
            }
            protected override void FnEvent2F(TwPlayerServer player, MapEventType type, bool doMsgs) {
                ShowText(player, type, doMsgs, "Ah, an easy task, but necessary all the same.");
                SetFlag(player, type, doMsgs, FlagTypeParty, WENTTHRU, 1);
            }
            protected override void FnEvent30(TwPlayerServer player, MapEventType type, bool doMsgs) {
                DisableSpells(player, type, doMsgs);
                if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.I_QUEST_LEFT) == 1) {
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.I_QUEST_LEFT, 2);
                    Iquest(player, type, doMsgs);
                }
                else if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.I_QUEST_RIGHT) == 1) {
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.I_QUEST_RIGHT, 2);
                    Iquest(player, type, doMsgs);
                }
            }
            private void Iquest(TwPlayerServer player, MapEventType type, bool doMsgs) {
                ShowText(player, type, doMsgs, "You are granted experience and gold for your completion of this side.");
                ModifyExperience(player, type, doMsgs, 1200);
                ModifyGold(player, type, doMsgs, 750);
            }
            protected override void FnEvent31(TwPlayerServer player, MapEventType type, bool doMsgs) {
                if (GetPartyCount(player, type, doMsgs) == 1) {
                    if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.DIDPATH) == 1 || GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.DIDPATH) == 2) {
                        ShowText(player, type, doMsgs, "A door appears in the wall!");
                        ShowText(player, type, doMsgs, "The magical gate has recognized the marks of your achievements.");
                        WallClear(player, type, doMsgs);
                    }
                    else {
                        ShowText(player, type, doMsgs, "Return here, once you've completed what must be done elsewhere.");
                    }
                }
                else {
                    WallBlock(player, type, doMsgs);
                    ShowText(player, type, doMsgs, "You must proceed alone.");
                }
            }
            protected override void FnEvent32(TwPlayerServer player, MapEventType type, bool doMsgs) {
                if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.UPPERROPE) == 1) {
                    ShowText(player, type, doMsgs, "There is nothing here.");
                }
                else {
                    ShowText(player, type, doMsgs, "You find a coil of rope here. You'd better tuck it away for safe keeping.");
                    GiveItem(player, type, doMsgs, ROPE);
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.UPPERROPE, 1);
                }
            }
            protected override void FnEvent33(TwPlayerServer player, MapEventType type, bool doMsgs) {
                SetFlag(player, type, doMsgs, FlagTypeParty, BEENROBBED, 1);
            }
            protected override void FnEvent34(TwPlayerServer player, MapEventType type, bool doMsgs) {
                if (UsedItem(player, type, ref doMsgs, GREENLOCKPICK, BLUELOCKPICK) || HasUsedSkill(player, type, ref doMsgs, LOCKPICK_SKILL) > 4 || UsedItem(player, type, ref doMsgs, HELMOFGUILE, HELMOFGUILE)) {
                    WallClear(player, type, doMsgs);
                    ShowText(player, type, doMsgs, "You manage to pick the rusty lock.");
                }
                else {
                    WallBlock(player, type, doMsgs);
                    ShowText(player, type, doMsgs, "An iron door with a rusty lock blocks your way here.");
                }
            }
            protected override void FnEvent35(TwPlayerServer player, MapEventType type, bool doMsgs) {
                int flag = 0;
                switch (GetTile(player, type, doMsgs)) {
                    case 228:
                        flag = 1;
                        break;
                    case 235:
                        flag = 2;
                        break;
                }
                SetFlag(player, type, doMsgs, FlagTypeParty, WESTENTRANCE, flag);
            }
            protected override void FnEvent36(TwPlayerServer player, MapEventType type, bool doMsgs) {
                int flag = 0;
                switch (GetTile(player, type, doMsgs)) {
                    case 216:
                    case 234:
                        flag = 2;
                        break;
                    case 213:
                    case 230:
                        flag = 1;
                        break;
                }
                if (GetFlag(player, type, doMsgs, FlagTypeParty, WESTENTRANCE) >= flag) {
                    PutDoor(player, type, doMsgs);
                    WallClear(player, type, doMsgs);
                    ShowText(player, type, doMsgs, "As long as you remain in this map, you may use this door. Upon leaving the map, it will vanish.");
                    switch (GetTile(player, type, doMsgs)) {
                        case 216:
                        case 234:
                            ShowText(player, type, doMsgs, "You must re-enter the area east of here to to make the door reappear.");
                            break;
                        case 213:
                        case 230:
                            ShowText(player, type, doMsgs, "You must enter the maze south of here to open it again!");
                            break;
                    }
                }
            }
            protected override void FnEvent37(TwPlayerServer player, MapEventType type, bool doMsgs) {
                DisablePartyJoining(player, type, doMsgs);
                ShowText(player, type, doMsgs, "You cannot join together here.");
            }
            protected override void FnEvent38(TwPlayerServer player, MapEventType type, bool doMsgs) {
                int where = 0;
                where = GetTile(player, type, doMsgs) + 16;
                if (GetPartyCount(player, type, doMsgs) > 1) {
                    TeleportParty(player, type, doMsgs, 2, 1, where, Direction.South);
                }
            }
        }
    }
