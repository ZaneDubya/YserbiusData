using XPT.Games.Generic.Constants;
using XPT.Games.Generic.Maps;
using XPT.Games.Twinion.Entities;

namespace XPT.Games.Twinion.Maps {
    /// <summary>
    /// L1: Gauntlet Gauche
    /// </summary>
    class TwMap01 : TwMap {
        public override int MapIndex => 1;
        public override int MapID => 0x0102;
        protected override int RandomEncounterChance => 15;
        protected override int RandomEncounterExtraCount => 1;

        private const int WHICHWAY = 1;
        private const int BATSCAVE = 2;
        private const int READPITMESS = 3;
        private const int BIZARRE = 4;
        private const int NPCINHALL = 5;
        private const int PFBATTLE = 6;
        private const int LOCKEDDOOR = 7;
        private const int FIREDOOR = 8;
        private const int NPC2INHALL = 9;
        private const int SPRUNGTRAP = 1;

        protected override void FnEvent01(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "The Door Reads: 'To Main Entrance.'");
            TeleportParty(player, type, doMsgs, 1, 1, 131, Direction.East);
        }

        protected override void FnEvent02(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "This will take you to the Gauntlet!");
            TeleportParty(player, type, doMsgs, 1, 3, 212, Direction.North);
        }

        protected override void FnEvent03(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
            ShowText(player, type, doMsgs, "HAIL! This is Gauntlet Gauche. Swirling waters and magical pits will be your guides to the gauntlet sought in Gauntlet Droit.");
            ShowText(player, type, doMsgs, "A magical Gauntlet has been thrown down in the Coil Maze. This path will offer you a second ingress to that phase.");
        }

        protected override void FnEvent04(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 1, 2, 245, Direction.East);
        }

        protected override void FnEvent05(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int teleportroom = 0;
            switch (GetTile(player, type, doMsgs)) {
                case 9:
                    teleportroom = 15;
                    break;
                case 25:
                    teleportroom = 127;
                    break;
                case 41:
                    teleportroom = 191;
                    break;
                case 8:
                    teleportroom = 0;
                    break;
                case 24:
                    teleportroom = 112;
                    break;
                case 40:
                    teleportroom = 240;
                    break;
            }
            TeleportParty(player, type, doMsgs, 1, 2, teleportroom, Direction.South);
        }

        protected override void FnEvent06(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "ONE WAY");
        }

        protected override void FnEvent07(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (UsedItem(player, type, ref doMsgs, GREENLOCKPICK, BLUELOCKPICK) || HasUsedSkill(player, type, ref doMsgs, LOCKPICK_SKILL) > 1) {
                ShowText(player, type, doMsgs, "You've picked the lock. Proceed.");
                ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
            }
            else {
                SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                ShowText(player, type, doMsgs, "A locked door impedes your progress here.");
            }
        }

        protected override void FnEvent08(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetGuild(player, type, doMsgs) == THIEF) {
                if (UsedItem(player, type, ref doMsgs, GREENLOCKPICK, BLUELOCKPICK) || HasUsedSkill(player, type, ref doMsgs, LOCKPICK_SKILL) > 1) {
                    ShowText(player, type, doMsgs, "Well done, sly thief. You may proceed.");
                    ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                }
                else {
                    SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                    ShowText(player, type, doMsgs, "A locked door impedes your progress here.");
                }
            }
            else {
                SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                ShowText(player, type, doMsgs, "Only a party led by a masterful thief can open this door.");
            }
        }

        protected override void FnEvent0A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            DisablePartyJoining(player, type, doMsgs);
        }

        protected override void FnEvent0B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Small pinholes of light seep through the cracks in the wall here.");
            if ((HasUsedSkill(player, type, ref doMsgs, DETECT_SKILL) >= 1) || (HasUsedSpell(player, type, ref doMsgs, TRUE_SEEING_SPELL) >= 1) || UsedItem(player, type, ref doMsgs, CRYSTALBALL, CRYSTALBALL) || UsedItem(player, type, ref doMsgs, VALKYRIESHELM, VALKYRIESHELM) || UsedItem(player, type, ref doMsgs, RINGOFTHIEVES, RINGOFTHIEVES) || UsedItem(player, type, ref doMsgs, HELMOFWISDOM, HELMOFWISDOM)) {
                SetWallItem(player, type, doMsgs, DOOR, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                ShowText(player, type, doMsgs, "You've uncovered a hidden door!");
                ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
            }
            else {
                SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                ClearWallItem(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
            }
        }

        protected override void FnEvent0C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                ShowText(player, type, doMsgs, "You hear roaring waters on the other side of this gateway.");
            }
            else {
                SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                ShowText(player, type, doMsgs, "The narrow door forces you to disband and enter alone.");
            }
        }

        protected override void FnEvent0D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int pfv = 0;
            pfv = GetFlag(player, type, doMsgs, FlagTypeParty, BATSCAVE);
            switch (GetTile(player, type, doMsgs)) {
                case 94:
                    DisableAutomaps(player, type, doMsgs);
                    if (pfv <= 94 && pfv != 0) {
                        BatText(player, type, doMsgs);
                    }
                    else {
                        AddEncounter(player, type, doMsgs, 1, 7);
                    }
                    break;
                case 79:
                    DisableAutomaps(player, type, doMsgs);
                    if (pfv <= 79 && pfv != 0) {
                        BatText(player, type, doMsgs);
                    }
                    else {
                        AddEncounter(player, type, doMsgs, 1, 7);
                    }
                    break;
                case 63:
                    DisableAutomaps(player, type, doMsgs);
                    if (pfv <= 63 && pfv != 0) {
                        BatText(player, type, doMsgs);
                    }
                    else {
                        AddEncounter(player, type, doMsgs, 1, 3);
                    }
                    break;
                case 46:
                    TorchTxt(player, type, doMsgs);
                    if (pfv <= 46 && pfv != 0) {
                        BatText(player, type, doMsgs);
                    }
                    else {
                        AddEncounter(player, type, doMsgs, 1, 7);
                    }
                    break;
                case 47:
                    TorchTxt(player, type, doMsgs);
                    if (pfv == 47 && pfv != 0) {
                        BatText(player, type, doMsgs);
                    }
                    else {
                        AddEncounter(player, type, doMsgs, 1, 3);
                    }
                    break;
            }
            SetFlag(player, type, doMsgs, FlagTypeParty, BATSCAVE, GetTile(player, type, doMsgs));
        }

        private void TorchTxt(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Flickering torches offer dim light, allowing you to see your way from here.");
        }

        private void BatText(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "The bats seem to have calmed down here.");
        }

        protected override void FnEvent0E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            DisableAutomaps(player, type, doMsgs);
            if ((GetFlag(player, type, doMsgs, FlagTypeTile, SPRUNGTRAP) == 0)) {
                DoDamage(player, type, doMsgs, GetHealthMax(player, type, doMsgs) / 6);
                if (GetHealthCurrent(player, type, doMsgs) > 0) {
                    ShowText(player, type, doMsgs, "You must wade through a pool of guano here. The noxious odors are damaging to you.");
                    SetFlag(player, type, doMsgs, FlagTypeTile, SPRUNGTRAP, 1);
                }
            }
        }

        protected override void FnEvent0F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetFlag(player, type, doMsgs, FlagTypeParty, BATSCAVE, 100);
            ShowText(player, type, doMsgs, "Eastward, an ornate hallway has been infested with various kinds of bats. They cling to the ceiling and issue shrill chirps to the point of madness.");
            ShowText(player, type, doMsgs, "A thick layer of leathery wings blocks out the light in the eastern hall. You will be unable to map the area. Proceed with caution!");
        }

        protected override void FnEvent10(TwPlayerServer player, MapEventType type, bool doMsgs) {
            DisableAutomaps(player, type, doMsgs);
            if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.BATCAVE) == 0)) {
                ShowText(player, type, doMsgs, "A stash of booty and coins comprises the bats' treasure room.");
                GiveItem(player, type, doMsgs, AXE);
                GiveItem(player, type, doMsgs, BUCKLER);
                GiveItem(player, type, doMsgs, GREENLOCKPICK);
                GiveItem(player, type, doMsgs, HEALPOTION);
                ModifyGold(player, type, doMsgs, 300);
                ModifyExperience(player, type, doMsgs, 250);
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.BATCAVE, 1);
            }
            else {
                ShowText(player, type, doMsgs, "There's nothing more here.");
            }
        }

        protected override void FnEvent11(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetFlag(player, type, doMsgs, FlagTypeParty, READPITMESS) == 0)) {
                ShowText(player, type, doMsgs, "The floor is filled with glowing pits. These will provide you with shortcuts to various areas of this level.");
                ShowText(player, type, doMsgs, "Continue, if you dare to chance it.");
                SetFlag(player, type, doMsgs, FlagTypeParty, READPITMESS, 1);
            }
        }

        protected override void FnEvent12(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int pfv = 0;
            pfv = GetFlag(player, type, doMsgs, FlagTypeParty, NPCINHALL);
            if (GetTileState(player, type, doMsgs) != GetTile(player, type, doMsgs)) {
                if (pfv == 0) {
                    pfv = 1;
                }
                switch (pfv) {
                    case 1:
                        PicShow(player, type, doMsgs);
                        ShowText(player, type, doMsgs, "'Greetings to you! This is one of two mazes which comprise the Gauntlet quest.");
                        ShowText(player, type, doMsgs, "Explore the area thoroughly, there are many shortcuts to help you here.'");
                        pfv = 2;
                        break;
                    case 2:
                        PicShow(player, type, doMsgs);
                        ShowText(player, type, doMsgs, "'Might I be of service again?");
                        ShowText(player, type, doMsgs, "In the north is a series of pits that will offer you rapid progression.");
                        ShowText(player, type, doMsgs, "The bats in the north east are horrible, but rewarding.'");
                        pfv = 3;
                        break;
                    case 3:
                        PicShow(player, type, doMsgs);
                        ShowText(player, type, doMsgs, "'You want more info?...Hmmm, let's see...ah yes! How could I have forgotten!");
                        ShowText(player, type, doMsgs, "Find your way to the south and east. The Snake River will grant you a quick way to the Coil Maze.'");
                        pfv = 4;
                        break;
                    default:
                        PicShow(player, type, doMsgs);
                        ShowText(player, type, doMsgs, "'I can offer you no more advice. It's up to you which path you choose. But in time, all things come upon themselves.'");
                        pfv = 1;
                        break;
                }
                SetFlag(player, type, doMsgs, FlagTypeParty, NPCINHALL, pfv);
                SetTileState(player, type, doMsgs, GetTile(player, type, doMsgs));
            }
        }

        private void PicShow(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, HUMANWIZARD);
        }

        protected override void FnEvent13(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.THIEFBOOTY) == 0) || GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.THIEFBOOTY) != 2 && GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.THIEFBOOTY) != GetTile(player, type, doMsgs)) {
                ShowText(player, type, doMsgs, "You come across a stash of useful items!");
                if (GetGuild(player, type, doMsgs) == THIEF) {
                    GiveItem(player, type, doMsgs, SHORTBOW);
                    GiveItem(player, type, doMsgs, CRYSTALBALL);
                    GiveItem(player, type, doMsgs, BERSERKERTALISMAN);
                    GiveItem(player, type, doMsgs, HEALPOTION);
                    ModifyGold(player, type, doMsgs, 250);
                    ModifyExperience(player, type, doMsgs, 100);
                }
                else {
                    GiveItem(player, type, doMsgs, MANAPOTION);
                    GiveItem(player, type, doMsgs, HEALPOTION);
                    ModifyGold(player, type, doMsgs, 100);
                    ModifyExperience(player, type, doMsgs, 50);
                }
                if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.THIEFBOOTY) == 230) {
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.THIEFBOOTY, 2);
                }
                else {
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.THIEFBOOTY, GetTile(player, type, doMsgs));
                }
            }
            else {
                ShowText(player, type, doMsgs, "There's nothing more here.");
            }
        }

        protected override void FnEvent14(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.THIEFBOOTY) == 0) || GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.THIEFBOOTY) != 2 && GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.THIEFBOOTY) != GetTile(player, type, doMsgs)) {
                ShowText(player, type, doMsgs, "You come across a stash of useful items!");
                if (GetGuild(player, type, doMsgs) == THIEF) {
                    GiveItem(player, type, doMsgs, HAWKSEYE);
                    GiveItem(player, type, doMsgs, SCROLLOFTHESUN);
                    GiveItem(player, type, doMsgs, TRANCETALISMAN);
                    GiveItem(player, type, doMsgs, HEALPOTION);
                    ModifyGold(player, type, doMsgs, 250);
                    ModifyExperience(player, type, doMsgs, 100);
                }
                else {
                    GiveItem(player, type, doMsgs, MANAPOTION);
                    GiveItem(player, type, doMsgs, HEALPOTION);
                    ModifyGold(player, type, doMsgs, 100);
                    ModifyExperience(player, type, doMsgs, 50);
                }
                if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.THIEFBOOTY) == 159) {
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.THIEFBOOTY, 2);
                }
                else {
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.THIEFBOOTY, GetTile(player, type, doMsgs));
                }
            }
            else {
                ShowText(player, type, doMsgs, "There's nothing more here.");
            }
        }

        protected override void FnEvent15(TwPlayerServer player, MapEventType type, bool doMsgs) {
            AddEncounter(player, type, doMsgs, 01, 30);
            AddEncounter(player, type, doMsgs, 02, 29);
        }

        protected override void FnEvent16(TwPlayerServer player, MapEventType type, bool doMsgs) {
            AddEncounter(player, type, doMsgs, 01, 34);
            AddEncounter(player, type, doMsgs, 02, 35);
        }

        protected override void FnEvent17(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int i = 0;
            if ((GetFlag(player, type, doMsgs, FlagTypeParty, PFBATTLE) == 0)) {
                SetTreasure(player, type, doMsgs, HEALPOTION, CRYSTALBALL, 0, 0, 0, 25);
                for (i = 1; i <= 2; i++) {
                    AddEncounter(player, type, doMsgs, i, 39);
                }
                SetFlag(player, type, doMsgs, FlagTypeParty, PFBATTLE, 1);
            }
            else if (GetFlag(player, type, doMsgs, FlagTypeParty, PFBATTLE) == 1) {
                for (i = 1; i <= 3; i++) {
                    AddEncounter(player, type, doMsgs, i, 26);
                }
                SetFlag(player, type, doMsgs, FlagTypeParty, PFBATTLE, 2);
            }
            else if (GetFlag(player, type, doMsgs, FlagTypeParty, PFBATTLE) == 2) {
                for (i = 1; i <= 5; i++) {
                    AddEncounter(player, type, doMsgs, i, 32);
                }
                SetFlag(player, type, doMsgs, FlagTypeParty, PFBATTLE, 0);
            }
        }

        protected override void FnEvent18(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int i = 0;
            switch (GetPartyCount(player, type, doMsgs)) {
                case 1:
                    AddEncounter(player, type, doMsgs, 1, 38);
                    break;
                case 2:
                    for (i = 1; i <= 3; i++) {
                        AddEncounter(player, type, doMsgs, i, 25);
                    }
                    break;
                default:
                    for (i = 1; i <= 5; i++) {
                        AddEncounter(player, type, doMsgs, i, 35);
                    }
                    break;
            }
        }

        protected override void FnEvent19(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 1, 2, 15, Direction.West);
        }

        protected override void FnEvent1A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, FOUNTAIN);
            ShowText(player, type, doMsgs, "The magical waters are refreshing.");
            ModifyHealth(player, type, doMsgs, GetHealthCurrent(player, type, doMsgs));
        }

        protected override void FnEvent1B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, FOUNTAIN);
            ShowText(player, type, doMsgs, "Clear blue waters restore your mana!");
            ModifyMana(player, type, doMsgs, 100);
        }

        protected override void FnEvent1C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int pfv = 0;
            if (GetFlag(player, type, doMsgs, FlagTypeParty, BIZARRE) == 50 && (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.WIERDO) == 0)) {
                ShowText(player, type, doMsgs, "You've done something bizarre! Here's your reward!");
                GiveItem(player, type, doMsgs, GAUNTLETSOFMERCY);
                GiveItem(player, type, doMsgs, SILVERBAR);
                ModifyExperience(player, type, doMsgs, 1000);
                ModifyGold(player, type, doMsgs, 1000);
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.WIERDO, 1);
            }
            else {
                pfv = GetFlag(player, type, doMsgs, FlagTypeParty, BIZARRE);
                pfv = pfv++;
                SetFlag(player, type, doMsgs, FlagTypeParty, BIZARRE, pfv);
            }
        }

        protected override void FnEvent1D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int portroom = 0;
            Direction face = 0;
            int ww = 0;
            ww = GetFlag(player, type, doMsgs, FlagTypeParty, WHICHWAY);
            ShowText(player, type, doMsgs, "The magic waters pull you onward!");
            if (ww == 1) {
                switch (GetTile(player, type, doMsgs)) {
                    case 236:
                        portroom = 252;
                        face = Direction.South;
                        break;
                    case 252:
                        portroom = 253;
                        face = Direction.East;
                        break;
                    case 253:
                        portroom = 237;
                        face = Direction.North;
                        break;
                    case 237:
                        portroom = 221;
                        face = Direction.North;
                        break;
                    case 221:
                        portroom = 222;
                        face = Direction.East;
                        break;
                    case 222:
                        portroom = 238;
                        face = Direction.South;
                        break;
                    case 238:
                        portroom = 254;
                        face = Direction.South;
                        break;
                    case 254:
                        portroom = 255;
                        face = Direction.East;
                        break;
                    case 255:
                        portroom = 239;
                        face = Direction.North;
                        break;
                    case 239:
                        portroom = 223;
                        face = Direction.North;
                        break;
                }
                SetFacing(player, type, doMsgs, face);
                TeleportParty(player, type, doMsgs, 1, 2, portroom, face);
            }
            else if (ww == 2) {
                switch (GetTile(player, type, doMsgs)) {
                    case 236:
                        portroom = 220;
                        face = Direction.North;
                        break;
                    case 252:
                        portroom = 236;
                        face = Direction.North;
                        break;
                    case 253:
                        portroom = 252;
                        face = Direction.West;
                        break;
                    case 237:
                        portroom = 253;
                        face = Direction.South;
                        break;
                    case 221:
                        portroom = 237;
                        face = Direction.South;
                        break;
                    case 222:
                        portroom = 221;
                        face = Direction.West;
                        break;
                    case 238:
                        portroom = 222;
                        face = Direction.North;
                        break;
                    case 254:
                        portroom = 238;
                        face = Direction.North;
                        break;
                    case 255:
                        portroom = 254;
                        face = Direction.West;
                        break;
                    case 239:
                        portroom = 255;
                        face = Direction.South;
                        break;
                }
                SetFacing(player, type, doMsgs, face);
                TeleportParty(player, type, doMsgs, 1, 2, portroom, face);
            }
        }

        protected override void FnEvent1E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            FnEvent0A(player, type, doMsgs);
            SetFlag(player, type, doMsgs, FlagTypeParty, WHICHWAY, 1);
            ShowText(player, type, doMsgs, "An unstable platform forces you to stand alone at the western edge of Snake River.");
        }

        protected override void FnEvent1F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 1, 2, 0, Direction.South);
        }

        protected override void FnEvent20(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 1, 2, 145, Direction.North);
        }

        protected override void FnEvent21(TwPlayerServer player, MapEventType type, bool doMsgs) {
            FnEvent0A(player, type, doMsgs);
            SetFlag(player, type, doMsgs, FlagTypeParty, WHICHWAY, 2);
            ShowText(player, type, doMsgs, "You are at the eastern end of Snake River.");
        }

        private void RiverTxt(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Magical forces hurl water southward and around the bend. The overwhelming noise is hypnotic and painful.");
        }

        protected override void FnEvent22(TwPlayerServer player, MapEventType type, bool doMsgs) {
            RiverTxt(player, type, doMsgs);
        }

        protected override void FnEvent23(TwPlayerServer player, MapEventType type, bool doMsgs) {
            RiverTxt(player, type, doMsgs);
        }

        protected override void FnEvent24(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 1, 2, 2, Direction.West);
        }

        protected override void FnEvent25(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetTileState(player, type, doMsgs, 0);
        }

        protected override void FnEvent26(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Look at me again to gain more information!");
            if (GetFlag(player, type, doMsgs, FlagTypeParty, LOCKEDDOOR) == 0) {
                ShowText(player, type, doMsgs, "The door to the west is locked, but no lockpick can help you here! You must learn to use what is at hand in a more creative fashion.");
                SetFlag(player, type, doMsgs, FlagTypeParty, LOCKEDDOOR, 1);
            }
            else if (GetFlag(player, type, doMsgs, FlagTypeParty, LOCKEDDOOR) == 1) {
                ShowText(player, type, doMsgs, "You must use something...something that could hack the lock off the door. Do not constrain yourself from using your belongings in a new way!");
                SetFlag(player, type, doMsgs, FlagTypeParty, LOCKEDDOOR, 2);
            }
            else if (GetFlag(player, type, doMsgs, FlagTypeParty, LOCKEDDOOR) == 2) {
                ShowText(player, type, doMsgs, "Use a weapon, a sword or an axe, some form of blade or bludgeon, and you will be able to knock the lock off.");
                SetFlag(player, type, doMsgs, FlagTypeParty, LOCKEDDOOR, 0);
            }
        }

        protected override void FnEvent27(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (UsedItem(player, type, ref doMsgs, SHORTSWORD, DISRUPTOR)) {
                ShowText(player, type, doMsgs, "You've broken the lock! You may now enter and gain experience from your actions!");
                ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
            }
        }

        protected override void FnEvent28(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.BROKEDOOR) == 0)) {
                ShowText(player, type, doMsgs, "Well done! Gain in experience and line your pockets with gold! Remember, there are more ways to use what you have than you remember.");
                ModifyExperience(player, type, doMsgs, 200);
                ModifyGold(player, type, doMsgs, 100);
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.BROKEDOOR, 1);
            }
            else {
                ShowText(player, type, doMsgs, "You've gained all you can from this test. You are welcome to bash the magical lock as often as you wish.");
            }
        }

        protected override void FnEvent29(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Look at me again to gain more information!");
            if (GetFlag(player, type, doMsgs, FlagTypeParty, FIREDOOR) == 0) {
                ShowText(player, type, doMsgs, "The door to the east is locked, but no lockpick can help you here! You must learn to use what is at hand in a more creative fashion.");
                SetFlag(player, type, doMsgs, FlagTypeParty, FIREDOOR, 1);
            }
            else if (GetFlag(player, type, doMsgs, FlagTypeParty, FIREDOOR) == 1) {
                ShowText(player, type, doMsgs, "You must use something...something that could fire the lock off the door. Do not constrain yourself from using your belongings in a new way!");
                SetFlag(player, type, doMsgs, FlagTypeParty, FIREDOOR, 2);
            }
            else if (GetFlag(player, type, doMsgs, FlagTypeParty, FIREDOOR) == 2) {
                ShowText(player, type, doMsgs, "Use a scroll that would cast a magical force, capable of incinerating or blowing the door away!");
                SetFlag(player, type, doMsgs, FlagTypeParty, FIREDOOR, 0);
            }
        }

        protected override void FnEvent2A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (UsedItem(player, type, ref doMsgs, SHAMANSCROLL, SHAMANSCROLL) || UsedItem(player, type, ref doMsgs, PUMMELSCROLL, PUMMELSCROLL) || UsedItem(player, type, ref doMsgs, CRYSTALSCROLL, CRYSTALSCROLL) || UsedItem(player, type, ref doMsgs, SCROLLOFWIND, SCROLLOFWIND) || UsedItem(player, type, ref doMsgs, BOWOFFLAMES, BOWOFFLAMES) || UsedItem(player, type, ref doMsgs, AEGISDDRACO, AEGISDDRACO) || UsedItem(player, type, ref doMsgs, NEROSLYRE, NEROSLYRE) || UsedItem(player, type, ref doMsgs, SCROLLOFTHESUN, SCROLLOFTHESUN) || UsedItem(player, type, ref doMsgs, SCORCHEDSCROLL, SCORCHEDSCROLL)) {
                ShowText(player, type, doMsgs, "You've incinerated the door! Now you may enter and gain wisdom from your accomplishment.");
                ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
            }
            else {
                SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
            }
        }

        protected override void FnEvent2B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.FLAMEDOOR) == 0)) {
                ShowText(player, type, doMsgs, "Well done! Gain in experience and line your pockets with gold! Remember, there are more ways to use what you have than you remember.");
                ModifyExperience(player, type, doMsgs, 200);
                ModifyGold(player, type, doMsgs, 100);
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.FLAMEDOOR, 1);
            }
            else {
                ShowText(player, type, doMsgs, "You've gained all you can from this test. You are welcome to destroy the magical door as often as you wish.");
            }
        }

        protected override void FnEvent2C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int pfv = 0;
            pfv = GetFlag(player, type, doMsgs, FlagTypeParty, NPC2INHALL);
            if (GetTileState(player, type, doMsgs) != GetTile(player, type, doMsgs)) {
                if (pfv == 0) {
                    pfv = 1;
                }
                switch (pfv) {
                    case 1:
                        ShowPortrait(player, type, doMsgs, DWARFWIZARD);
                        ShowText(player, type, doMsgs, "You pass by a dwarf regaling some companions. 'I was trying to find a way across Lake Deluge or Desperate - something like that.");
                        ShowText(player, type, doMsgs, "Anyway, I stepped on a spot and I tell you, if I hadn't had the Life Jacket, I wouldn't be here today!'");
                        pfv = 2;
                        break;
                    case 2:
                        ShowPortrait(player, type, doMsgs, GNOMEBARBARIAN);
                        ShowText(player, type, doMsgs, "A barbarian is lamenting with a companion over something he lost. 'I know I had it not long ago! That knight told us we needed the key to enter those secret rooms.");
                        ShowText(player, type, doMsgs, "We must find it! Hmmm, we did search that place on Lake Despair. Let's try looking back there.'");
                        ShowText(player, type, doMsgs, "With that, they hurry off to other adventures.");
                        pfv = 3;
                        break;
                    default:
                        ShowPortrait(player, type, doMsgs, HALFLINGTHIEF);
                        ShowText(player, type, doMsgs, "A thief emerges from the shadows, 'There's an area in the Night Elves' Domain where the magic used to construct the walls will drive you to the fringe of madness!");
                        ShowText(player, type, doMsgs, "Never have I seen the likes of these magical walls. I saw nothing, yet my path was blocked! Fret not, there is a hidden exit...though I fear this is not the last of the nightmare.");
                        pfv = 1;
                        break;
                }
                SetFlag(player, type, doMsgs, FlagTypeParty, NPC2INHALL, pfv);
                SetTileState(player, type, doMsgs, GetTile(player, type, doMsgs));
            }
        }
    }
}
