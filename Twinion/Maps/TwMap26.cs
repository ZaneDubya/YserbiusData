using XPT.Games.Generic.Constants;
using XPT.Games.Generic.Maps;
using XPT.Games.Twinion.Entities;

namespace XPT.Games.Twinion.Maps {
    class TwMap26 : TwMap {
        public override int MapIndex => 26;
        public override int MapID => 0x0B01;
        protected override int RandomEncounterChance => 10;
        protected override int RandomEncounterExtraCount => 0;

        private const int POISON_ME = 1;
        private const int TELE = 2;
        protected override void FnEvent01(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 11, 1, 57, Direction.North);
        }
        protected override void FnEvent02(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.TB) == 1 || GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.TC) == 1 || GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.TD) == 1) {
                TeleportParty(player, type, doMsgs, 11, 1, 130, Direction.North);
            }
            else {
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.TA, 1);
                TeleportParty(player, type, doMsgs, 11, 1, 130, Direction.North);
            }
        }
        protected override void FnEvent03(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.TA) == 1 || GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.TC) == 1 || GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.TD) == 1) {
                TeleportParty(player, type, doMsgs, 11, 2, 234, Direction.East);
            }
            else {
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.TB, 1);
                TeleportParty(player, type, doMsgs, 11, 2, 234, Direction.East);
            }
        }
        protected override void FnEvent04(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.TA) == 1 || GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.TB) == 1 || GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.TD) == 1) {
                TeleportParty(player, type, doMsgs, 11, 2, 93, Direction.West);
            }
            else {
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.TC, 1);
                TeleportParty(player, type, doMsgs, 11, 2, 93, Direction.West);
            }
        }
        protected override void FnEvent05(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.TA) == 1 || GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.TB) == 1 || GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.TC) == 1) {
                TeleportParty(player, type, doMsgs, 11, 2, 47, Direction.West);
            }
            else {
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.TD, 1);
                TeleportParty(player, type, doMsgs, 11, 2, 47, Direction.West);
            }
        }
        protected override void FnEvent06(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HELLBATTLE) == 3 || GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.GUARD) == 3) {
                    TeleportParty(player, type, doMsgs, 11, 2, 241, Direction.East);
                }
                else {
                    TeleportParty(player, type, doMsgs, 11, 1, 57, Direction.North);
                }
            }
            else {
                ShowText(player, type, doMsgs, "Proceed in single file.");
                WallBlock(player, type, doMsgs);
            }
        }
        protected override void FnEvent07(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetFlag(player, type, doMsgs, FlagTypeTile, TELE) == 0)) {
                if (GetGuild(player, type, doMsgs) == CLERIC || GetGuild(player, type, doMsgs) == THIEF || GetGuild(player, type, doMsgs) == KNIGHT) {
                    switch (GetTile(player, type, doMsgs)) {
                        case 31:
                            TeleportParty(player, type, doMsgs, 11, 2, 103, Direction.South);
                            break;
                        case 115:
                            TeleportParty(player, type, doMsgs, 11, 2, 148, Direction.East);
                            break;
                        case 172:
                            TeleportParty(player, type, doMsgs, 11, 1, 76, Direction.South);
                            break;
                        case 180:
                            TeleportParty(player, type, doMsgs, 11, 1, 127, Direction.West);
                            break;
                    }
                }
                SetFlag(player, type, doMsgs, FlagTypeTile, TELE, 1);
            }
        }
        protected override void FnEvent08(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetGuild(player, type, doMsgs) == RANGER || GetGuild(player, type, doMsgs) == THIEF) {
                Entmsg(player, type, doMsgs);
                TeleportParty(player, type, doMsgs, 11, 4, 181, Direction.North);
            }
            else {
                ShowText(player, type, doMsgs, "The portal to your fate lies elsewhere.");
            }
        }
        protected override void FnEvent09(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You slide down a lava tube.");
            TeleportParty(player, type, doMsgs, 11, 1, 127, Direction.West);
        }
        protected override void FnEvent0A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetFlag(player, type, doMsgs, FlagTypeTile, TELE) == 0)) {
                if (GetGuild(player, type, doMsgs) == RANGER || GetGuild(player, type, doMsgs) == WIZARD || GetGuild(player, type, doMsgs) == BARBARIAN) {
                    switch (GetTile(player, type, doMsgs)) {
                        case 43:
                            TeleportParty(player, type, doMsgs, 11, 2, 103, Direction.South);
                            break;
                        case 148:
                            TeleportParty(player, type, doMsgs, 11, 2, 148, Direction.East);
                            break;
                        case 138:
                            TeleportParty(player, type, doMsgs, 11, 1, 76, Direction.South);
                            break;
                        case 194:
                            TeleportParty(player, type, doMsgs, 11, 1, 127, Direction.West);
                            break;
                    }
                }
                SetFlag(player, type, doMsgs, FlagTypeTile, TELE, 1);
            }
        }
        protected override void FnEvent0B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HELLBATTLE) == 3 || GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.GUARD) == 3) {
                TeleportParty(player, type, doMsgs, 11, 1, 0, Direction.East);
            }
            else {
                TeleportParty(player, type, doMsgs, 11, 2, 35, Direction.North);
            }
        }
        protected override void FnEvent0C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "An overheated potion explodes and sends you flying.");
            TeleportParty(player, type, doMsgs, 11, 2, 50, Direction.East);
        }
        protected override void FnEvent0D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 11, 2, 240, Direction.North);
        }
        protected override void FnEvent0E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 11, 1, 40, Direction.South);
        }
        protected override void FnEvent0F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "The constant crashing of waves appears to be making the walls crumble.");
        }
        protected override void FnEvent10(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 11, 4, 187, Direction.North);
        }
        protected override void FnEvent11(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 11, 1, 157, Direction.South);
            ShowText(player, type, doMsgs, "You are caught in a whirlpool.");
        }
        protected override void FnEvent12(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "A flood of water carries you off.");
            TeleportParty(player, type, doMsgs, 11, 2, 184, Direction.West);
        }
        protected override void FnEvent13(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.THORZIL) == 1) {
                TeleportParty(player, type, doMsgs, 11, 2, 43, Direction.North);
            }
            else {
                TeleportParty(player, type, doMsgs, 11, 2, 164, Direction.East);
            }
        }
        protected override void FnEvent14(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 11, 1, 173, Direction.East);
        }
        protected override void FnEvent15(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 11, 1, 174, Direction.East);
            ShowText(player, type, doMsgs, "You are caught in a whirlpool.");
        }
        protected override void FnEvent16(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 11, 4, 69, Direction.East);
        }
        protected override void FnEvent17(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 11, 1, 175, Direction.North);
        }
        protected override void FnEvent18(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "A hurricane force wind catapults you.");
            TeleportParty(player, type, doMsgs, 11, 1, 58, Direction.South);
        }
        protected override void FnEvent19(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You stare ahead in disbelief as a crashing wave sweeps other adventurers to their deaths.");
        }
        protected override void FnEvent1A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetGuild(player, type, doMsgs) == CLERIC || GetGuild(player, type, doMsgs) == KNIGHT) {
                Entmsg(player, type, doMsgs);
                TeleportParty(player, type, doMsgs, 11, 4, 181, Direction.East);
            }
            else {
                ShowText(player, type, doMsgs, "The portal to your fate lies elsewhere.");
            }
        }
        protected override void FnEvent1B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 11, 1, 241, Direction.North);
        }
        protected override void FnEvent1C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 11, 2, 164, Direction.East);
        }
        protected override void FnEvent1D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 11, 2, 176, Direction.North);
        }
        protected override void FnEvent1E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            DisableHealing(player, type, doMsgs);
            if ((GetFlag(player, type, doMsgs, FlagTypeTile, TELE) == 0)) {
                ShowText(player, type, doMsgs, "You slip on a loose rock and are injured.");
                DoDamage(player, type, doMsgs, GetHealthMax(player, type, doMsgs) / 2);
                SetFlag(player, type, doMsgs, FlagTypeTile, TELE, 1);
            }
        }
        protected override void FnEvent1F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetGuild(player, type, doMsgs) == RANGER || GetGuild(player, type, doMsgs) == WIZARD || GetGuild(player, type, doMsgs) == BARBARIAN) {
                DisableHealing(player, type, doMsgs);
                if ((GetFlag(player, type, doMsgs, FlagTypeTile, TELE) == 0)) {
                    ShowText(player, type, doMsgs, "Molten lava sears you.");
                    DamQuarter(player, type, doMsgs);
                    SetFlag(player, type, doMsgs, FlagTypeTile, TELE, 1);
                }
            }
        }
        protected override void FnEvent20(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetGuild(player, type, doMsgs) == CLERIC || GetGuild(player, type, doMsgs) == THIEF || GetGuild(player, type, doMsgs) == KNIGHT) {
                DisableHealing(player, type, doMsgs);
                if ((GetFlag(player, type, doMsgs, FlagTypeTile, TELE) == 0)) {
                    ShowText(player, type, doMsgs, "Molten lava sears you.");
                    DamQuarter(player, type, doMsgs);
                    SetFlag(player, type, doMsgs, FlagTypeTile, TELE, 1);
                }
            }
        }
        protected override void FnEvent21(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You fall to your death in the lava.");
            DamXit(player, type, doMsgs);
        }
        protected override void FnEvent22(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetGuild(player, type, doMsgs) == CLERIC || GetGuild(player, type, doMsgs) == THIEF || GetGuild(player, type, doMsgs) == KNIGHT) {
                DisableHealing(player, type, doMsgs);
                if ((GetFlag(player, type, doMsgs, FlagTypeTile, TELE) == 0)) {
                    ShowText(player, type, doMsgs, "The turbulence of the water weakens you.");
                    DamQuarter(player, type, doMsgs);
                    SetFlag(player, type, doMsgs, FlagTypeTile, TELE, 1);
                }
            }
        }
        protected override void FnEvent23(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetGuild(player, type, doMsgs) == RANGER || GetGuild(player, type, doMsgs) == WIZARD || GetGuild(player, type, doMsgs) == BARBARIAN) {
                DisableHealing(player, type, doMsgs);
                if ((GetFlag(player, type, doMsgs, FlagTypeTile, TELE) == 0)) {
                    ShowText(player, type, doMsgs, "The turbulence of the water weakens you.");
                    DamQuarter(player, type, doMsgs);
                    SetFlag(player, type, doMsgs, FlagTypeTile, TELE, 1);
                }
            }
        }
        protected override void FnEvent24(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "A violent wave crashes against you.");
            DamXit(player, type, doMsgs);
        }
        protected override void FnEvent25(TwPlayerServer player, MapEventType type, bool doMsgs) {
            DisableHealing(player, type, doMsgs);
            if ((GetFlag(player, type, doMsgs, FlagTypeTile, TELE) == 0)) {
                ShowText(player, type, doMsgs, "You feel a ferocious bite on your leg.");
                DoDamage(player, type, doMsgs, GetHealthMax(player, type, doMsgs) / 2);
                SetFlag(player, type, doMsgs, FlagTypeTile, TELE, 1);
            }
        }
        protected override void FnEvent26(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.TA) == 1 || GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.TB) == 1 || GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.TC) == 1 || GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.TD) == 1) {
                WallClear(player, type, doMsgs);
                SetWallItem(player, type, doMsgs, DOOR, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
            }
            else {
                WallBlock(player, type, doMsgs);
            }
        }
        protected override void FnEvent27(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, WRAITH);
            ShowText(player, type, doMsgs, "'Argggh! I died in one of these fountains, yet the party just there was unharmed.'");
        }
        protected override void FnEvent28(TwPlayerServer player, MapEventType type, bool doMsgs) {
            WallClear(player, type, doMsgs);
        }
        protected override void FnEvent29(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You push against the dam and the rocks move.");
            WallClear(player, type, doMsgs);
        }
        protected override void FnEvent2A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "If you have correctly thrown the switches, continue alone through the teleport to the south. To continue searching for the switches, walk through the portal to the east.");
        }
        protected override void FnEvent2B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Pluthros has imprisoned Celestia.  She holds the medallion which will aid in his defeat.  Chaos and Harmony are working against each other to possess this medallion.");
            ShowText(player, type, doMsgs, "Both must find and set three switches in the correct order.  These switches will either lock or open Celestia's cell.");
            ShowText(player, type, doMsgs, "Beware!  There are many switches, choose wisely!");
            SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.TA, 0);
            SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.TB, 0);
            SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.TC, 0);
            SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.TD, 0);
            SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HELLBATTLE, 0);
            SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.GUARD, 0);
            SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.DEMONIA, 0);
        }
        protected override void FnEvent2C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Master Switch Area.  Beyond the teleport, all lock switches will be reset.");
        }
        protected override void FnEvent2D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 11, 1, 244, Direction.North);
        }
        protected override void FnEvent2E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HEAVENFTNSIX) == 0)) {
                ShowPortrait(player, type, doMsgs, GUARDIANPRAXIS);
                ShowText(player, type, doMsgs, "Worthy adventurers!  Be it known that Thorzil has been seen wreaking havoc with the fountains.");
                ShowText(player, type, doMsgs, "We hear he hides a worthy treasure, one that will aid in the killing of the Dralkarian Juvalad who reigns over us.  Explore and find him!");
            }
        }
        protected override void FnEvent2F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Beware all who walk through this door.  Malos has controlled the elements and has created havoc along these paths.  It is rumored that he hides the one thing that will do him harm.");
        }
        protected override void FnEvent30(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HEAVENFTNC) == 0 && GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HEAVENFTND) == 0 && GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HEAVENFTNE) == 0) {
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HEAVENFTND, 1);
            }
        }
        protected override void FnEvent31(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HEAVENFTNC) == 0 && GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HEAVENFTND) == 0 && GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HEAVENFTNE) == 0) {
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HEAVENFTNC, 1);
            }
        }
        protected override void FnEvent32(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HEAVENFTNC) == 0 && GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HEAVENFTND) == 0 && GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HEAVENFTNE) == 0) {
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HEAVENFTNE, 1);
            }
        }
        protected override void FnEvent33(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetAlignment(player, type, doMsgs) == HARMONY) {
                ShowPortrait(player, type, doMsgs, EREBUSFIEND);
                ShowText(player, type, doMsgs, "You slip by the sleeping guard and throw the lock switch on the wall.");
            }
            else {
                ShowText(player, type, doMsgs, "You find the room empty.");
            }
        }
        protected override void FnEvent34(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetAlignment(player, type, doMsgs) == HARMONY) {
                ShowPortrait(player, type, doMsgs, STONEGOLEM);
                ShowText(player, type, doMsgs, "The guard quickly draws his weapon and slashes you. As he laughs at his success, you reach behind him and throw the lock switch.");
                DoDamage(player, type, doMsgs, GetHealthMax(player, type, doMsgs) / 5);
                if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.GUARD) == 1) && (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.TC) == 1 || GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.TA) == 1)) {
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.GUARD, 2);
                }
                else if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.GUARD) == 0) && (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.TD) == 1 || GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.TB) == 1)) {
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.GUARD, 1);
                }
                else {
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.GUARD, 5);
                }
            }
            else {
                ShowText(player, type, doMsgs, "You rest in the empty room.");
            }
        }
        protected override void FnEvent35(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetGuild(player, type, doMsgs) == WIZARD || GetGuild(player, type, doMsgs) == RANGER) {
                if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.IFLAME) == 1) {
                    if (HasItem(player, type, doMsgs, ICEFLAME)) {
                        ShowText(player, type, doMsgs, "You find nothing unusual in the alcove.");
                    }
                    else {
                        ShowText(player, type, doMsgs, "Malos has again attempted to hide the Ice Flame.");
                        GiveItem(player, type, doMsgs, ICEFLAME);
                    }
                }
                else {
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.IFLAME, 1);
                    ModifyExperience(player, type, doMsgs, 750000);
                    GiveItem(player, type, doMsgs, ICEFLAME);
                    ShowText(player, type, doMsgs, "You see the sparkle of a weapon embedded in the crusted lava. It surprises you how easily the weapon comes free and you recall a rumor about a special weapon that might aid you in defeating the Dralkarian Malos.");
                }
            }
            else {
                ShowText(player, type, doMsgs, "You find nothing unusual in the alcove.");
            }
        }
        protected override void FnEvent36(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetAlignment(player, type, doMsgs) == HARMONY) {
                ShowPortrait(player, type, doMsgs, GNOMEBARBARIAN);
                ShowText(player, type, doMsgs, "As you reach behind the guard to throw the lock switch, he lunges forward and wounds you.");
                DamQuarter(player, type, doMsgs);
                if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.GUARD) == 2) && (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.TC) == 1 || GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.TB) == 1)) {
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.GUARD, 3);
                }
                else if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.GUARD) == 0) && (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.TA) == 1)) {
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.GUARD, 1);
                }
                else if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.GUARD) == 1) && (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.TD) == 1)) {
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.GUARD, 2);
                }
                else {
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.GUARD, 5);
                }
            }
            else {
                ShowText(player, type, doMsgs, "You find the room empty.");
            }
        }
        protected override void FnEvent37(TwPlayerServer player, MapEventType type, bool doMsgs) {
            FntnPic(player, type, doMsgs);
            HealFtn(player, type, doMsgs);
            if (GetAlignment(player, type, doMsgs) == HARMONY) {
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.DEMONIA, 1);
                ShowText(player, type, doMsgs, "The restorative but turbulent waters of Demonia Fountain cause your weapon to glow with the colors of the rainbow.");
            }
            else {
                ShowText(player, type, doMsgs, "The turbulent waters of Demonia Fountain heal your wounds and restore your mana.");
            }
        }
        protected override void FnEvent38(TwPlayerServer player, MapEventType type, bool doMsgs) {
            FntnPic(player, type, doMsgs);
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HEAVENFTNE) == 1 || GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HEAVENFTNC) == 1) {
                ShowText(player, type, doMsgs, "The crystal blue waters of Paradise Fountain heal and restore you.");
                HealFtn(player, type, doMsgs);
            }
            else {
                ShowText(player, type, doMsgs, "Thorzil's trap causes the fountain to collapse around you.");
                DamXit(player, type, doMsgs);
            }
        }
        protected override void FnEvent39(TwPlayerServer player, MapEventType type, bool doMsgs) {
            FntnPic(player, type, doMsgs);
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HEAVENFTNE) == 1 || GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HEAVENFTNC) == 1) {
                ShowText(player, type, doMsgs, "You cannot avoid the death trap set by Thorzil!");
                DamXit(player, type, doMsgs);
            }
            else {
                ShowText(player, type, doMsgs, "The fresh waters of Lingolf Fountain heal you and restore your mana.  There is no sign of Thorzil.");
                HealFtn(player, type, doMsgs);
            }
        }
        protected override void FnEvent3A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeTile, POISON_ME) == 0) {
                FntnPic(player, type, doMsgs);
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HEAVENFTNFOUR, 1);
                ShowText(player, type, doMsgs, "The caustic waters of the fountain have been poisoned.");
                OuchFtn(player, type, doMsgs);
            }
        }
        protected override void FnEvent3B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeTile, POISON_ME) == 0) {
                FntnPic(player, type, doMsgs);
                ShowText(player, type, doMsgs, "The poisoned waters make you ill.");
                OuchFtn(player, type, doMsgs);
                if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HEAVENFTNSIX) == 1 && GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HEAVENFTNTHREE) == 1 && GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HEAVENFTNFOUR) == 1) {
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.FTNONOFF, 1);
                    ShowText(player, type, doMsgs, "You hear the sound of flowing water where none was before.");
                }
            }
        }
        protected override void FnEvent3C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "The calm waters rejuvenate you.");
            HealFtn(player, type, doMsgs);
        }
        protected override void FnEvent3D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.FTNONOFF) == 1) {
                FntnPic(player, type, doMsgs);
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HEAVENFTNFIVE, 1);
                if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HEAVENFTNTWO) == 1 && GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HEAVENFTNTHREE) == 1 && GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HEAVENFTNFOUR) == 1 && GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HEAVENFTNFIVE) == 1 && GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HEAVENFTNSIX) == 1 && GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HEAVENFTNC) == 1) {
                    ShowText(player, type, doMsgs, "You find Thorzil hiding in the fountain and nab him.  In order to spare his life, he offers to activate the portal to his poison stash and promises you a sure fire method of defeating Juvalad.");
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.THORZIL, 1);
                }
                else {
                    if (GetFlag(player, type, doMsgs, FlagTypeTile, POISON_ME) == 0) {
                        ShowText(player, type, doMsgs, "The waters have already been poisoned.");
                        OuchFtn(player, type, doMsgs);
                    }
                }
            }
        }
        protected override void FnEvent3E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            FntnPic(player, type, doMsgs);
            ShowText(player, type, doMsgs, "The cool waters of Elysia Fountain soothe you.");
            HealFtn(player, type, doMsgs);
        }
        protected override void FnEvent3F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetFlag(player, type, doMsgs, FlagTypeTile, TELE) == 0)) {
                FntnPic(player, type, doMsgs);
                ShowText(player, type, doMsgs, "You step into a fountain with discolored waters and feel your health diminish.");
                DamQuarter(player, type, doMsgs);
                SetFlag(player, type, doMsgs, FlagTypeTile, TELE, 1);
            }
        }
        protected override void FnEvent40(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You see what once was a fountain and sense impending danger.");
        }
        protected override void FnEvent41(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.FTNONOFF, 0);
            ShowText(player, type, doMsgs, "The destruction of the fountain reminds you of Thorzil.");
            ShowText(player, type, doMsgs, "Some fountains seem unnaturally quiet all of a sudden.");
        }
        protected override void FnEvent42(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You attack the guards in order to throw the lock switch in the room.");
            if (GetAlignment(player, type, doMsgs) == CHAOS) {
                if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HELLBATTLE) == 2) && (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.TC) == 1 || GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.TB) == 1)) {
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HELLBATTLE, 3);
                }
                else if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HELLBATTLE) == 0) && (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.TA) == 1)) {
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HELLBATTLE, 1);
                }
                else if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HELLBATTLE) == 1) && (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.TD) == 1)) {
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HELLBATTLE, 2);
                }
                else {
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HELLBATTLE, 5);
                }
            }
            else {
                ShowText(player, type, doMsgs, "Your attempt to throw the lock switch is futile.");
            }
            if (GetPartyCount(player, type, doMsgs) == 1 || GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 8);
                AddEncounter(player, type, doMsgs, 02, 8);
                AddEncounter(player, type, doMsgs, 03, 9);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 8);
                AddEncounter(player, type, doMsgs, 02, 9);
                AddEncounter(player, type, doMsgs, 03, 10);
                AddEncounter(player, type, doMsgs, 04, 10);
            }
        }
        protected override void FnEvent43(TwPlayerServer player, MapEventType type, bool doMsgs) {
            Entmsg(player, type, doMsgs);
        }
        protected override void FnEvent44(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetAlignment(player, type, doMsgs) == CHAOS) {
                ShowText(player, type, doMsgs, "You are attacked by the guards! However, you manage to throw the switch on the wall.");
            }
            else {
                ShowText(player, type, doMsgs, "The lock switch is blocked by the guards who attack.");
            }
            if (GetPartyCount(player, type, doMsgs) == 1 || GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 3);
                AddEncounter(player, type, doMsgs, 02, 6);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 3);
                AddEncounter(player, type, doMsgs, 02, 6);
                AddEncounter(player, type, doMsgs, 03, 14);
                AddEncounter(player, type, doMsgs, 04, 15);
            }
        }
        protected override void FnEvent45(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1 || GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 32);
                AddEncounter(player, type, doMsgs, 02, 32);
                AddEncounter(player, type, doMsgs, 05, 33);
                AddEncounter(player, type, doMsgs, 06, 33);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 32);
                AddEncounter(player, type, doMsgs, 02, 32);
                AddEncounter(player, type, doMsgs, 03, 33);
                AddEncounter(player, type, doMsgs, 04, 33);
                AddEncounter(player, type, doMsgs, 05, 34);
                AddEncounter(player, type, doMsgs, 06, 34);
            }
        }
        protected override void FnEvent46(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 18);
                AddEncounter(player, type, doMsgs, 02, 25);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 18);
                AddEncounter(player, type, doMsgs, 02, 18);
                AddEncounter(player, type, doMsgs, 03, 25);
                AddEncounter(player, type, doMsgs, 04, 26);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 18);
                AddEncounter(player, type, doMsgs, 02, 18);
                AddEncounter(player, type, doMsgs, 03, 25);
                AddEncounter(player, type, doMsgs, 04, 26);
                AddEncounter(player, type, doMsgs, 06, 27);
            }
        }
        protected override void FnEvent47(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetAlignment(player, type, doMsgs) == CHAOS) {
                ShowText(player, type, doMsgs, "You quickly spot the lock switch on the wall and throw it before the guards attack.");
            }
            else {
                ShowText(player, type, doMsgs, "The guards spot you and block the lock switch.");
            }
            if (GetPartyCount(player, type, doMsgs) == 1 || GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 1);
                AddEncounter(player, type, doMsgs, 02, 1);
                AddEncounter(player, type, doMsgs, 05, 3);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 2);
                AddEncounter(player, type, doMsgs, 02, 2);
                AddEncounter(player, type, doMsgs, 03, 3);
                AddEncounter(player, type, doMsgs, 04, 3);
            }
        }
        protected override void FnEvent48(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 21);
                AddEncounter(player, type, doMsgs, 02, 22);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 22);
                AddEncounter(player, type, doMsgs, 02, 23);
                AddEncounter(player, type, doMsgs, 05, 35);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 22);
                AddEncounter(player, type, doMsgs, 02, 23);
                AddEncounter(player, type, doMsgs, 03, 36);
                AddEncounter(player, type, doMsgs, 04, 36);
                AddEncounter(player, type, doMsgs, 05, 37);
            }
        }
        protected override void FnEvent49(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1 || GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 5);
                AddEncounter(player, type, doMsgs, 02, 35);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 5);
                AddEncounter(player, type, doMsgs, 02, 6);
                AddEncounter(player, type, doMsgs, 03, 35);
                AddEncounter(player, type, doMsgs, 04, 36);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 5);
                AddEncounter(player, type, doMsgs, 02, 5);
                AddEncounter(player, type, doMsgs, 03, 6);
                AddEncounter(player, type, doMsgs, 04, 6);
                AddEncounter(player, type, doMsgs, 05, 36);
                AddEncounter(player, type, doMsgs, 06, 37);
            }
        }
        protected override void FnEvent4A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.FTNONOFF) == 1) {
                FntnPic(player, type, doMsgs);
                if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HEAVENFTNE) == 1 || GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HEAVENFTNC) == 1) {
                    ShowText(player, type, doMsgs, "The crystal blue waters of the fountain heal and restore you.");
                    HealFtn(player, type, doMsgs);
                }
                else {
                    ShowText(player, type, doMsgs, "Thorzil's trap causes the fountain to collapse around you.");
                    DamXit(player, type, doMsgs);
                }
            }
        }
        protected override void FnEvent4C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HasItem(player, type, doMsgs, HEALALLPOTION)) {
                SetTreasure(player, type, doMsgs, HEALALLPOTION, ELIXIROFHEALTH, MANAELIXIR, 0, 0, 750);
            }
            else {
                SetTreasure(player, type, doMsgs, HEALALLPOTION, HEALALLPOTION, MANARESTORE, 0, 0, 1000);
            }
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 15);
                AddEncounter(player, type, doMsgs, 02, 17);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 15);
                AddEncounter(player, type, doMsgs, 02, 15);
                AddEncounter(player, type, doMsgs, 05, 26);
                AddEncounter(player, type, doMsgs, 06, 16);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 15);
                AddEncounter(player, type, doMsgs, 02, 15);
                AddEncounter(player, type, doMsgs, 03, 16);
                AddEncounter(player, type, doMsgs, 04, 16);
                AddEncounter(player, type, doMsgs, 06, 17);
            }
        }
        protected override void FnEvent4D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 1);
                AddEncounter(player, type, doMsgs, 02, 3);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 1);
                AddEncounter(player, type, doMsgs, 02, 1);
                AddEncounter(player, type, doMsgs, 05, 2);
                AddEncounter(player, type, doMsgs, 06, 3);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 1);
                AddEncounter(player, type, doMsgs, 02, 1);
                AddEncounter(player, type, doMsgs, 03, 2);
                AddEncounter(player, type, doMsgs, 05, 3);
                AddEncounter(player, type, doMsgs, 06, 3);
            }
        }
        protected override void FnEvent4E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You fall into a bottomless pit.");
            DamXit(player, type, doMsgs);
        }
        private void DamXit(TwPlayerServer player, MapEventType type, bool doMsgs) {
            DoDamage(player, type, doMsgs, GetHealthMax(player, type, doMsgs));
        }
        private void FntnPic(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, FOUNTAIN);
        }
        private void WallClear(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
        }
        private void WallBlock(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
        }
        private void DamQuarter(TwPlayerServer player, MapEventType type, bool doMsgs) {
            DoDamage(player, type, doMsgs, GetHealthMax(player, type, doMsgs) / 4);
            DisableHealing(player, type, doMsgs);
        }
        private void HealFtn(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ModifyHealth(player, type, doMsgs, GetHealthMax(player, type, doMsgs));
            ModifyMana(player, type, doMsgs, 10000);
        }
        private void OuchFtn(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetDebuff(player, type, doMsgs, POISON, 5, GetHealthMax(player, type, doMsgs) / 5);
            SetFlag(player, type, doMsgs, FlagTypeTile, POISON_ME, 1);
        }
        private void Entmsg(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Enter to meet your Fate!");
        }
        protected override void FnEvent50(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You watch in horror as the lava engulfs the party ahead.");
        }
        protected override void FnEvent51(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HEAVENFTNFOUR) == 1 && GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HEAVENFTNSIX) == 1 && GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HEAVENFTNTHREE) == 1) {
                if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HEAVENFTNONE) == 0)) {
                    ShowPortrait(player, type, doMsgs, DWARFWIZARD);
                    ShowText(player, type, doMsgs, "'Please help me! I've been injured. My payment will be a secret that you need to know.'");
                    ShowText(player, type, doMsgs, "You aid the ailing dwarf and listen to her story...");
                    ShowText(player, type, doMsgs, "'I've heard that the guardians here use magic to hide some of the fountains from Thorzil. They reappear from time to time and you must visit them!'");
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HEAVENFTNONE, 1);
                }
            }
        }
        protected override void FnEvent52(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HELLBATTLE) == 5 || GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.GUARD) == 5) {
                ShowText(player, type, doMsgs, "As you turn to leave your hear the hideous laughter of Pluthros.");
                ShowText(player, type, doMsgs, "'Fools! You will never complete your task! I have again foiled your attempt at the correct switches!'");
            }
        }
    }
}
