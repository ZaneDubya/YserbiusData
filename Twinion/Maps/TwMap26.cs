using XPT.Generic.Maps;
using XPT.Twinion.Entities;

namespace XPT.Twinion.Maps {
    class TwMap26 : TwMap {
        protected override int MapIndex => 26;
        protected override int MapID => 0x0B01;
        protected override int RandomEncounterChance => 10;
        protected override int RandomEncounterExtraCount => 0;

        private const int POISON_ME = 1;
        private const int TELE = 2;
        protected override void FnEvent01(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 11, 1, 57, NORTH);
        }
        protected override void FnEvent02(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, DUNGEON, TB) == 1 || GET_FLAG(player, type, doMsgs, DUNGEON, TC) == 1 || GET_FLAG(player, type, doMsgs, DUNGEON, TD) == 1) {
                TELEPORT(player, type, doMsgs, 11, 1, 130, NORTH);
            }
            else {
                SET_FLAG(player, type, doMsgs, DUNGEON, TA, 1);
                TELEPORT(player, type, doMsgs, 11, 1, 130, NORTH);
            }
        }
        protected override void FnEvent03(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, DUNGEON, TA) == 1 || GET_FLAG(player, type, doMsgs, DUNGEON, TC) == 1 || GET_FLAG(player, type, doMsgs, DUNGEON, TD) == 1) {
                TELEPORT(player, type, doMsgs, 11, 2, 234, EAST);
            }
            else {
                SET_FLAG(player, type, doMsgs, DUNGEON, TB, 1);
                TELEPORT(player, type, doMsgs, 11, 2, 234, EAST);
            }
        }
        protected override void FnEvent04(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, DUNGEON, TA) == 1 || GET_FLAG(player, type, doMsgs, DUNGEON, TB) == 1 || GET_FLAG(player, type, doMsgs, DUNGEON, TD) == 1) {
                TELEPORT(player, type, doMsgs, 11, 2, 93, WEST);
            }
            else {
                SET_FLAG(player, type, doMsgs, DUNGEON, TC, 1);
                TELEPORT(player, type, doMsgs, 11, 2, 93, WEST);
            }
        }
        protected override void FnEvent05(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, DUNGEON, TA) == 1 || GET_FLAG(player, type, doMsgs, DUNGEON, TB) == 1 || GET_FLAG(player, type, doMsgs, DUNGEON, TC) == 1) {
                TELEPORT(player, type, doMsgs, 11, 2, 47, WEST);
            }
            else {
                SET_FLAG(player, type, doMsgs, DUNGEON, TD, 1);
                TELEPORT(player, type, doMsgs, 11, 2, 47, WEST);
            }
        }
        protected override void FnEvent06(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                if (GET_FLAG(player, type, doMsgs, DUNGEON, HELLBATTLE) == 3 || GET_FLAG(player, type, doMsgs, DUNGEON, GUARD) == 3) {
                    TELEPORT(player, type, doMsgs, 11, 2, 241, EAST);
                }
                else {
                    TELEPORT(player, type, doMsgs, 11, 1, 57, NORTH);
                }
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "Proceed in single file.");
                WallBlock(player, type, doMsgs);
            }
        }
        protected override void FnEvent07(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GET_FLAG(player, type, doMsgs, ROOM, TELE) == 0)) {
                if (GUILD(player, type, doMsgs) == CLERIC || GUILD(player, type, doMsgs) == THIEF || GUILD(player, type, doMsgs) == KNIGHT) {
                    switch (HERE(player, type, doMsgs)) {
                        case 31:
                            TELEPORT(player, type, doMsgs, 11, 2, 103, SOUTH);
                            break;
                        case 115:
                            TELEPORT(player, type, doMsgs, 11, 2, 148, EAST);
                            break;
                        case 172:
                            TELEPORT(player, type, doMsgs, 11, 1, 76, SOUTH);
                            break;
                        case 180:
                            TELEPORT(player, type, doMsgs, 11, 1, 127, WEST);
                            break;
                    }
                }
                SET_FLAG(player, type, doMsgs, ROOM, TELE, 1);
            }
        }
        protected override void FnEvent08(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GUILD(player, type, doMsgs) == RANGER || GUILD(player, type, doMsgs) == THIEF) {
                Entmsg(player, type, doMsgs);
                TELEPORT(player, type, doMsgs, 11, 4, 181, NORTH);
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "The portal to your fate lies elsewhere.");
            }
        }
        protected override void FnEvent09(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You slide down a lava tube.");
            TELEPORT(player, type, doMsgs, 11, 1, 127, WEST);
        }
        protected override void FnEvent0A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GET_FLAG(player, type, doMsgs, ROOM, TELE) == 0)) {
                if (GUILD(player, type, doMsgs) == RANGER || GUILD(player, type, doMsgs) == WIZARD || GUILD(player, type, doMsgs) == BARBARIAN) {
                    switch (HERE(player, type, doMsgs)) {
                        case 43:
                            TELEPORT(player, type, doMsgs, 11, 2, 103, SOUTH);
                            break;
                        case 148:
                            TELEPORT(player, type, doMsgs, 11, 2, 148, EAST);
                            break;
                        case 138:
                            TELEPORT(player, type, doMsgs, 11, 1, 76, SOUTH);
                            break;
                        case 194:
                            TELEPORT(player, type, doMsgs, 11, 1, 127, WEST);
                            break;
                    }
                }
                SET_FLAG(player, type, doMsgs, ROOM, TELE, 1);
            }
        }
        protected override void FnEvent0B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, DUNGEON, HELLBATTLE) == 3 || GET_FLAG(player, type, doMsgs, DUNGEON, GUARD) == 3) {
                TELEPORT(player, type, doMsgs, 11, 1, 0, EAST);
            }
            else {
                TELEPORT(player, type, doMsgs, 11, 2, 35, NORTH);
            }
        }
        protected override void FnEvent0C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "An overheated potion explodes and sends you flying.");
            TELEPORT(player, type, doMsgs, 11, 2, 50, EAST);
        }
        protected override void FnEvent0D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 11, 2, 240, NORTH);
        }
        protected override void FnEvent0E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 11, 1, 40, SOUTH);
        }
        protected override void FnEvent0F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "The constant crashing of waves appears to be making the walls crumble.");
        }
        protected override void FnEvent10(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 11, 4, 187, NORTH);
        }
        protected override void FnEvent11(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 11, 1, 157, SOUTH);
            SHOW_TEXT(player, type, doMsgs, "You are caught in a whirlpool.");
        }
        protected override void FnEvent12(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "A flood of water carries you off.");
            TELEPORT(player, type, doMsgs, 11, 2, 184, WEST);
        }
        protected override void FnEvent13(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, DUNGEON, THORZIL) == 1) {
                TELEPORT(player, type, doMsgs, 11, 2, 43, NORTH);
            }
            else {
                TELEPORT(player, type, doMsgs, 11, 2, 164, EAST);
            }
        }
        protected override void FnEvent14(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 11, 1, 173, EAST);
        }
        protected override void FnEvent15(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 11, 1, 174, EAST);
            SHOW_TEXT(player, type, doMsgs, "You are caught in a whirlpool.");
        }
        protected override void FnEvent16(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 11, 4, 69, EAST);
        }
        protected override void FnEvent17(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 11, 1, 175, NORTH);
        }
        protected override void FnEvent18(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "A hurricane force wind catapults you.");
            TELEPORT(player, type, doMsgs, 11, 1, 58, SOUTH);
        }
        protected override void FnEvent19(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You stare ahead in disbelief as a crashing wave sweeps other adventurers to their deaths.");
        }
        protected override void FnEvent1A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GUILD(player, type, doMsgs) == CLERIC || GUILD(player, type, doMsgs) == KNIGHT) {
                Entmsg(player, type, doMsgs);
                TELEPORT(player, type, doMsgs, 11, 4, 181, EAST);
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "The portal to your fate lies elsewhere.");
            }
        }
        protected override void FnEvent1B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 11, 1, 241, NORTH);
        }
        protected override void FnEvent1C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 11, 2, 164, EAST);
        }
        protected override void FnEvent1D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 11, 2, 176, NORTH);
        }
        protected override void FnEvent1E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            NO_HEAL_ZONE(player, type, doMsgs);
            if ((GET_FLAG(player, type, doMsgs, ROOM, TELE) == 0)) {
                SHOW_TEXT(player, type, doMsgs, "You slip on a loose rock and are injured.");
                DAMAGE(player, type, doMsgs, MAX_HEALTH(player, type, doMsgs) / 2);
                SET_FLAG(player, type, doMsgs, ROOM, TELE, 1);
            }
        }
        protected override void FnEvent1F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GUILD(player, type, doMsgs) == RANGER || GUILD(player, type, doMsgs) == WIZARD || GUILD(player, type, doMsgs) == BARBARIAN) {
                NO_HEAL_ZONE(player, type, doMsgs);
                if ((GET_FLAG(player, type, doMsgs, ROOM, TELE) == 0)) {
                    SHOW_TEXT(player, type, doMsgs, "Molten lava sears you.");
                    DamQuarter(player, type, doMsgs);
                    SET_FLAG(player, type, doMsgs, ROOM, TELE, 1);
                }
            }
        }
        protected override void FnEvent20(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GUILD(player, type, doMsgs) == CLERIC || GUILD(player, type, doMsgs) == THIEF || GUILD(player, type, doMsgs) == KNIGHT) {
                NO_HEAL_ZONE(player, type, doMsgs);
                if ((GET_FLAG(player, type, doMsgs, ROOM, TELE) == 0)) {
                    SHOW_TEXT(player, type, doMsgs, "Molten lava sears you.");
                    DamQuarter(player, type, doMsgs);
                    SET_FLAG(player, type, doMsgs, ROOM, TELE, 1);
                }
            }
        }
        protected override void FnEvent21(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You fall to your death in the lava.");
            DamXit(player, type, doMsgs);
        }
        protected override void FnEvent22(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GUILD(player, type, doMsgs) == CLERIC || GUILD(player, type, doMsgs) == THIEF || GUILD(player, type, doMsgs) == KNIGHT) {
                NO_HEAL_ZONE(player, type, doMsgs);
                if ((GET_FLAG(player, type, doMsgs, ROOM, TELE) == 0)) {
                    SHOW_TEXT(player, type, doMsgs, "The turbulence of the water weakens you.");
                    DamQuarter(player, type, doMsgs);
                    SET_FLAG(player, type, doMsgs, ROOM, TELE, 1);
                }
            }
        }
        protected override void FnEvent23(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GUILD(player, type, doMsgs) == RANGER || GUILD(player, type, doMsgs) == WIZARD || GUILD(player, type, doMsgs) == BARBARIAN) {
                NO_HEAL_ZONE(player, type, doMsgs);
                if ((GET_FLAG(player, type, doMsgs, ROOM, TELE) == 0)) {
                    SHOW_TEXT(player, type, doMsgs, "The turbulence of the water weakens you.");
                    DamQuarter(player, type, doMsgs);
                    SET_FLAG(player, type, doMsgs, ROOM, TELE, 1);
                }
            }
        }
        protected override void FnEvent24(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "A violent wave crashes against you.");
            DamXit(player, type, doMsgs);
        }
        protected override void FnEvent25(TwPlayerServer player, MapEventType type, bool doMsgs) {
            NO_HEAL_ZONE(player, type, doMsgs);
            if ((GET_FLAG(player, type, doMsgs, ROOM, TELE) == 0)) {
                SHOW_TEXT(player, type, doMsgs, "You feel a ferocious bite on your leg.");
                DAMAGE(player, type, doMsgs, MAX_HEALTH(player, type, doMsgs) / 2);
                SET_FLAG(player, type, doMsgs, ROOM, TELE, 1);
            }
        }
        protected override void FnEvent26(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, DUNGEON, TA) == 1 || GET_FLAG(player, type, doMsgs, DUNGEON, TB) == 1 || GET_FLAG(player, type, doMsgs, DUNGEON, TC) == 1 || GET_FLAG(player, type, doMsgs, DUNGEON, TD) == 1) {
                WallClear(player, type, doMsgs);
                PLACE_WALL_ITEM(player, type, doMsgs, DOOR, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
            }
            else {
                WallBlock(player, type, doMsgs);
            }
        }
        protected override void FnEvent27(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, WRAITH);
            SHOW_TEXT(player, type, doMsgs, "'Argggh! I died in one of these fountains, yet the party just there was unharmed.'");
        }
        protected override void FnEvent28(TwPlayerServer player, MapEventType type, bool doMsgs) {
            WallClear(player, type, doMsgs);
        }
        protected override void FnEvent29(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You push against the dam and the rocks move.");
            WallClear(player, type, doMsgs);
        }
        protected override void FnEvent2A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "If you have correctly thrown the switches, continue alone through the teleport to the south. To continue searching for the switches, walk through the portal to the east.");
        }
        protected override void FnEvent2B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Pluthros has imprisoned Celestia.  She holds the medallion which will aid in his defeat.  Chaos and Harmony are working against each other to possess this medallion.");
            SHOW_TEXT(player, type, doMsgs, "Both must find and set three switches in the correct order.  These switches will either lock or open Celestia's cell.");
            SHOW_TEXT(player, type, doMsgs, "Beware!  There are many switches, choose wisely!");
            SET_FLAG(player, type, doMsgs, DUNGEON, TA, 0);
            SET_FLAG(player, type, doMsgs, DUNGEON, TB, 0);
            SET_FLAG(player, type, doMsgs, DUNGEON, TC, 0);
            SET_FLAG(player, type, doMsgs, DUNGEON, TD, 0);
            SET_FLAG(player, type, doMsgs, DUNGEON, HELLBATTLE, 0);
            SET_FLAG(player, type, doMsgs, DUNGEON, GUARD, 0);
            SET_FLAG(player, type, doMsgs, DUNGEON, DEMONIA, 0);
        }
        protected override void FnEvent2C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Master Switch Area.  Beyond the teleport, all lock switches will be reset.");
        }
        protected override void FnEvent2D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 11, 1, 244, NORTH);
        }
        protected override void FnEvent2E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GET_FLAG(player, type, doMsgs, DUNGEON, HEAVENFTNSIX) == 0)) {
                SHOW_PICTURE(player, type, doMsgs, GUARDIANPRAXIS);
                SHOW_TEXT(player, type, doMsgs, "Worthy adventurers!  Be it known that Thorzil has been seen wreaking havoc with the fountains.");
                SHOW_TEXT(player, type, doMsgs, "We hear he hides a worthy treasure, one that will aid in the killing of the Dralkarian Juvalad who reigns over us.  Explore and find him!");
            }
        }
        protected override void FnEvent2F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Beware all who walk through this door.  Malos has controlled the elements and has created havoc along these paths.  It is rumored that he hides the one thing that will do him harm.");
        }
        protected override void FnEvent30(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, DUNGEON, HEAVENFTNC) == 0 && GET_FLAG(player, type, doMsgs, DUNGEON, HEAVENFTND) == 0 && GET_FLAG(player, type, doMsgs, DUNGEON, HEAVENFTNE) == 0) {
                SET_FLAG(player, type, doMsgs, DUNGEON, HEAVENFTND, 1);
            }
        }
        protected override void FnEvent31(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, DUNGEON, HEAVENFTNC) == 0 && GET_FLAG(player, type, doMsgs, DUNGEON, HEAVENFTND) == 0 && GET_FLAG(player, type, doMsgs, DUNGEON, HEAVENFTNE) == 0) {
                SET_FLAG(player, type, doMsgs, DUNGEON, HEAVENFTNC, 1);
            }
        }
        protected override void FnEvent32(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, DUNGEON, HEAVENFTNC) == 0 && GET_FLAG(player, type, doMsgs, DUNGEON, HEAVENFTND) == 0 && GET_FLAG(player, type, doMsgs, DUNGEON, HEAVENFTNE) == 0) {
                SET_FLAG(player, type, doMsgs, DUNGEON, HEAVENFTNE, 1);
            }
        }
        protected override void FnEvent33(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (ALIGN(player, type, doMsgs) == HARMONY) {
                SHOW_PICTURE(player, type, doMsgs, EREBUSFIEND);
                SHOW_TEXT(player, type, doMsgs, "You slip by the sleeping guard and throw the lock switch on the wall.");
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "You find the room empty.");
            }
        }
        protected override void FnEvent34(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (ALIGN(player, type, doMsgs) == HARMONY) {
                SHOW_PICTURE(player, type, doMsgs, STONEGOLEM);
                SHOW_TEXT(player, type, doMsgs, "The guard quickly draws his weapon and slashes you. As he laughs at his success, you reach behind him and throw the lock switch.");
                DAMAGE(player, type, doMsgs, MAX_HEALTH(player, type, doMsgs) / 5);
                if ((GET_FLAG(player, type, doMsgs, DUNGEON, GUARD) == 1) && (GET_FLAG(player, type, doMsgs, DUNGEON, TC) == 1 || GET_FLAG(player, type, doMsgs, DUNGEON, TA) == 1)) {
                    SET_FLAG(player, type, doMsgs, DUNGEON, GUARD, 2);
                }
                else if ((GET_FLAG(player, type, doMsgs, DUNGEON, GUARD) == 0) && (GET_FLAG(player, type, doMsgs, DUNGEON, TD) == 1 || GET_FLAG(player, type, doMsgs, DUNGEON, TB) == 1)) {
                    SET_FLAG(player, type, doMsgs, DUNGEON, GUARD, 1);
                }
                else {
                    SET_FLAG(player, type, doMsgs, DUNGEON, GUARD, 5);
                }
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "You rest in the empty room.");
            }
        }
        protected override void FnEvent35(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GUILD(player, type, doMsgs) == WIZARD || GUILD(player, type, doMsgs) == RANGER) {
                if (GET_FLAG(player, type, doMsgs, DUNGEON, IFLAME) == 1) {
                    if (HAS_ITEM(player, type, doMsgs, ICEFLAME)) {
                        SHOW_TEXT(player, type, doMsgs, "You find nothing unusual in the alcove.");
                    }
                    else {
                        SHOW_TEXT(player, type, doMsgs, "Malos has again attempted to hide the Ice Flame.");
                        GIVE_ITEM(player, type, doMsgs, ICEFLAME);
                    }
                }
                else {
                    SET_FLAG(player, type, doMsgs, DUNGEON, IFLAME, 1);
                    MOD_EXP(player, type, doMsgs, 750000);
                    GIVE_ITEM(player, type, doMsgs, ICEFLAME);
                    SHOW_TEXT(player, type, doMsgs, "You see the sparkle of a weapon embedded in the crusted lava. It surprises you how easily the weapon comes free and you recall a rumor about a special weapon that might aid you in defeating the Dralkarian Malos.");
                }
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "You find nothing unusual in the alcove.");
            }
        }
        protected override void FnEvent36(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (ALIGN(player, type, doMsgs) == HARMONY) {
                SHOW_PICTURE(player, type, doMsgs, GNOMEBARBARIAN);
                SHOW_TEXT(player, type, doMsgs, "As you reach behind the guard to throw the lock switch, he lunges forward and wounds you.");
                DamQuarter(player, type, doMsgs);
                if ((GET_FLAG(player, type, doMsgs, DUNGEON, GUARD) == 2) && (GET_FLAG(player, type, doMsgs, DUNGEON, TC) == 1 || GET_FLAG(player, type, doMsgs, DUNGEON, TB) == 1)) {
                    SET_FLAG(player, type, doMsgs, DUNGEON, GUARD, 3);
                }
                else if ((GET_FLAG(player, type, doMsgs, DUNGEON, GUARD) == 0) && (GET_FLAG(player, type, doMsgs, DUNGEON, TA) == 1)) {
                    SET_FLAG(player, type, doMsgs, DUNGEON, GUARD, 1);
                }
                else if ((GET_FLAG(player, type, doMsgs, DUNGEON, GUARD) == 1) && (GET_FLAG(player, type, doMsgs, DUNGEON, TD) == 1)) {
                    SET_FLAG(player, type, doMsgs, DUNGEON, GUARD, 2);
                }
                else {
                    SET_FLAG(player, type, doMsgs, DUNGEON, GUARD, 5);
                }
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "You find the room empty.");
            }
        }
        protected override void FnEvent37(TwPlayerServer player, MapEventType type, bool doMsgs) {
            FntnPic(player, type, doMsgs);
            HealFtn(player, type, doMsgs);
            if (ALIGN(player, type, doMsgs) == HARMONY) {
                SET_FLAG(player, type, doMsgs, DUNGEON, DEMONIA, 1);
                SHOW_TEXT(player, type, doMsgs, "The restorative but turbulent waters of Demonia Fountain cause your weapon to glow with the colors of the rainbow.");
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "The turbulent waters of Demonia Fountain heal your wounds and restore your mana.");
            }
        }
        protected override void FnEvent38(TwPlayerServer player, MapEventType type, bool doMsgs) {
            FntnPic(player, type, doMsgs);
            if (GET_FLAG(player, type, doMsgs, DUNGEON, HEAVENFTNE) == 1 || GET_FLAG(player, type, doMsgs, DUNGEON, HEAVENFTNC) == 1) {
                SHOW_TEXT(player, type, doMsgs, "The crystal blue waters of Paradise Fountain heal and restore you.");
                HealFtn(player, type, doMsgs);
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "Thorzil's trap causes the fountain to collapse around you.");
                DamXit(player, type, doMsgs);
            }
        }
        protected override void FnEvent39(TwPlayerServer player, MapEventType type, bool doMsgs) {
            FntnPic(player, type, doMsgs);
            if (GET_FLAG(player, type, doMsgs, DUNGEON, HEAVENFTNE) == 1 || GET_FLAG(player, type, doMsgs, DUNGEON, HEAVENFTNC) == 1) {
                SHOW_TEXT(player, type, doMsgs, "You cannot avoid the death trap set by Thorzil!");
                DamXit(player, type, doMsgs);
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "The fresh waters of Lingolf Fountain heal you and restore your mana.  There is no sign of Thorzil.");
                HealFtn(player, type, doMsgs);
            }
        }
        protected override void FnEvent3A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, ROOM, POISON_ME) == 0) {
                FntnPic(player, type, doMsgs);
                SET_FLAG(player, type, doMsgs, DUNGEON, HEAVENFTNFOUR, 1);
                SHOW_TEXT(player, type, doMsgs, "The caustic waters of the fountain have been poisoned.");
                OuchFtn(player, type, doMsgs);
            }
        }
        protected override void FnEvent3B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, ROOM, POISON_ME) == 0) {
                FntnPic(player, type, doMsgs);
                SHOW_TEXT(player, type, doMsgs, "The poisoned waters make you ill.");
                OuchFtn(player, type, doMsgs);
                if (GET_FLAG(player, type, doMsgs, DUNGEON, HEAVENFTNSIX) == 1 && GET_FLAG(player, type, doMsgs, DUNGEON, HEAVENFTNTHREE) == 1 && GET_FLAG(player, type, doMsgs, DUNGEON, HEAVENFTNFOUR) == 1) {
                    SET_FLAG(player, type, doMsgs, DUNGEON, FTNONOFF, 1);
                    SHOW_TEXT(player, type, doMsgs, "You hear the sound of flowing water where none was before.");
                }
            }
        }
        protected override void FnEvent3C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "The calm waters rejuvenate you.");
            HealFtn(player, type, doMsgs);
        }
        protected override void FnEvent3D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, DUNGEON, FTNONOFF) == 1) {
                FntnPic(player, type, doMsgs);
                SET_FLAG(player, type, doMsgs, DUNGEON, HEAVENFTNFIVE, 1);
                if (GET_FLAG(player, type, doMsgs, DUNGEON, HEAVENFTNTWO) == 1 && GET_FLAG(player, type, doMsgs, DUNGEON, HEAVENFTNTHREE) == 1 && GET_FLAG(player, type, doMsgs, DUNGEON, HEAVENFTNFOUR) == 1 && GET_FLAG(player, type, doMsgs, DUNGEON, HEAVENFTNFIVE) == 1 && GET_FLAG(player, type, doMsgs, DUNGEON, HEAVENFTNSIX) == 1 && GET_FLAG(player, type, doMsgs, DUNGEON, HEAVENFTNC) == 1) {
                    SHOW_TEXT(player, type, doMsgs, "You find Thorzil hiding in the fountain and nab him.  In order to spare his life, he offers to activate the portal to his poison stash and promises you a sure fire method of defeating Juvalad.");
                    SET_FLAG(player, type, doMsgs, DUNGEON, THORZIL, 1);
                }
                else {
                    if (GET_FLAG(player, type, doMsgs, ROOM, POISON_ME) == 0) {
                        SHOW_TEXT(player, type, doMsgs, "The waters have already been poisoned.");
                        OuchFtn(player, type, doMsgs);
                    }
                }
            }
        }
        protected override void FnEvent3E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            FntnPic(player, type, doMsgs);
            SHOW_TEXT(player, type, doMsgs, "The cool waters of Elysia Fountain soothe you.");
            HealFtn(player, type, doMsgs);
        }
        protected override void FnEvent3F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GET_FLAG(player, type, doMsgs, ROOM, TELE) == 0)) {
                FntnPic(player, type, doMsgs);
                SHOW_TEXT(player, type, doMsgs, "You step into a fountain with discolored waters and feel your health diminish.");
                DamQuarter(player, type, doMsgs);
                SET_FLAG(player, type, doMsgs, ROOM, TELE, 1);
            }
        }
        protected override void FnEvent40(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You see what once was a fountain and sense impending danger.");
        }
        protected override void FnEvent41(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SET_FLAG(player, type, doMsgs, DUNGEON, FTNONOFF, 0);
            SHOW_TEXT(player, type, doMsgs, "The destruction of the fountain reminds you of Thorzil.");
            SHOW_TEXT(player, type, doMsgs, "Some fountains seem unnaturally quiet all of a sudden.");
        }
        protected override void FnEvent42(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You attack the guards in order to throw the lock switch in the room.");
            if (ALIGN(player, type, doMsgs) == CHAOS) {
                if ((GET_FLAG(player, type, doMsgs, DUNGEON, HELLBATTLE) == 2) && (GET_FLAG(player, type, doMsgs, DUNGEON, TC) == 1 || GET_FLAG(player, type, doMsgs, DUNGEON, TB) == 1)) {
                    SET_FLAG(player, type, doMsgs, DUNGEON, HELLBATTLE, 3);
                }
                else if ((GET_FLAG(player, type, doMsgs, DUNGEON, HELLBATTLE) == 0) && (GET_FLAG(player, type, doMsgs, DUNGEON, TA) == 1)) {
                    SET_FLAG(player, type, doMsgs, DUNGEON, HELLBATTLE, 1);
                }
                else if ((GET_FLAG(player, type, doMsgs, DUNGEON, HELLBATTLE) == 1) && (GET_FLAG(player, type, doMsgs, DUNGEON, TD) == 1)) {
                    SET_FLAG(player, type, doMsgs, DUNGEON, HELLBATTLE, 2);
                }
                else {
                    SET_FLAG(player, type, doMsgs, DUNGEON, HELLBATTLE, 5);
                }
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "Your attempt to throw the lock switch is futile.");
            }
            if (PARTY_COUNT(player, type, doMsgs) == 1 || PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 8);
                GET_MONSTER(player, type, doMsgs, 02, 8);
                GET_MONSTER(player, type, doMsgs, 03, 9);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 8);
                GET_MONSTER(player, type, doMsgs, 02, 9);
                GET_MONSTER(player, type, doMsgs, 03, 10);
                GET_MONSTER(player, type, doMsgs, 04, 10);
            }
        }
        protected override void FnEvent43(TwPlayerServer player, MapEventType type, bool doMsgs) {
            Entmsg(player, type, doMsgs);
        }
        protected override void FnEvent44(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (ALIGN(player, type, doMsgs) == CHAOS) {
                SHOW_TEXT(player, type, doMsgs, "You are attacked by the guards! However, you manage to throw the switch on the wall.");
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "The lock switch is blocked by the guards who attack.");
            }
            if (PARTY_COUNT(player, type, doMsgs) == 1 || PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 3);
                GET_MONSTER(player, type, doMsgs, 02, 6);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 3);
                GET_MONSTER(player, type, doMsgs, 02, 6);
                GET_MONSTER(player, type, doMsgs, 03, 14);
                GET_MONSTER(player, type, doMsgs, 04, 15);
            }
        }
        protected override void FnEvent45(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1 || PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 32);
                GET_MONSTER(player, type, doMsgs, 02, 32);
                GET_MONSTER(player, type, doMsgs, 05, 33);
                GET_MONSTER(player, type, doMsgs, 06, 33);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 32);
                GET_MONSTER(player, type, doMsgs, 02, 32);
                GET_MONSTER(player, type, doMsgs, 03, 33);
                GET_MONSTER(player, type, doMsgs, 04, 33);
                GET_MONSTER(player, type, doMsgs, 05, 34);
                GET_MONSTER(player, type, doMsgs, 06, 34);
            }
        }
        protected override void FnEvent46(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 18);
                GET_MONSTER(player, type, doMsgs, 02, 25);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 18);
                GET_MONSTER(player, type, doMsgs, 02, 18);
                GET_MONSTER(player, type, doMsgs, 03, 25);
                GET_MONSTER(player, type, doMsgs, 04, 26);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 18);
                GET_MONSTER(player, type, doMsgs, 02, 18);
                GET_MONSTER(player, type, doMsgs, 03, 25);
                GET_MONSTER(player, type, doMsgs, 04, 26);
                GET_MONSTER(player, type, doMsgs, 06, 27);
            }
        }
        protected override void FnEvent47(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (ALIGN(player, type, doMsgs) == CHAOS) {
                SHOW_TEXT(player, type, doMsgs, "You quickly spot the lock switch on the wall and throw it before the guards attack.");
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "The guards spot you and block the lock switch.");
            }
            if (PARTY_COUNT(player, type, doMsgs) == 1 || PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 1);
                GET_MONSTER(player, type, doMsgs, 02, 1);
                GET_MONSTER(player, type, doMsgs, 05, 3);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 2);
                GET_MONSTER(player, type, doMsgs, 02, 2);
                GET_MONSTER(player, type, doMsgs, 03, 3);
                GET_MONSTER(player, type, doMsgs, 04, 3);
            }
        }
        protected override void FnEvent48(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 21);
                GET_MONSTER(player, type, doMsgs, 02, 22);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 22);
                GET_MONSTER(player, type, doMsgs, 02, 23);
                GET_MONSTER(player, type, doMsgs, 05, 35);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 22);
                GET_MONSTER(player, type, doMsgs, 02, 23);
                GET_MONSTER(player, type, doMsgs, 03, 36);
                GET_MONSTER(player, type, doMsgs, 04, 36);
                GET_MONSTER(player, type, doMsgs, 05, 37);
            }
        }
        protected override void FnEvent49(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1 || PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 5);
                GET_MONSTER(player, type, doMsgs, 02, 35);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 5);
                GET_MONSTER(player, type, doMsgs, 02, 6);
                GET_MONSTER(player, type, doMsgs, 03, 35);
                GET_MONSTER(player, type, doMsgs, 04, 36);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 5);
                GET_MONSTER(player, type, doMsgs, 02, 5);
                GET_MONSTER(player, type, doMsgs, 03, 6);
                GET_MONSTER(player, type, doMsgs, 04, 6);
                GET_MONSTER(player, type, doMsgs, 05, 36);
                GET_MONSTER(player, type, doMsgs, 06, 37);
            }
        }
        protected override void FnEvent4A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, DUNGEON, FTNONOFF) == 1) {
                FntnPic(player, type, doMsgs);
                if (GET_FLAG(player, type, doMsgs, DUNGEON, HEAVENFTNE) == 1 || GET_FLAG(player, type, doMsgs, DUNGEON, HEAVENFTNC) == 1) {
                    SHOW_TEXT(player, type, doMsgs, "The crystal blue waters of the fountain heal and restore you.");
                    HealFtn(player, type, doMsgs);
                }
                else {
                    SHOW_TEXT(player, type, doMsgs, "Thorzil's trap causes the fountain to collapse around you.");
                    DamXit(player, type, doMsgs);
                }
            }
        }
        protected override void FnEvent4C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HAS_ITEM(player, type, doMsgs, HEALALLPOTION)) {
                SET_BOOTY(player, type, doMsgs, HEALALLPOTION, ELIXIROFHEALTH, MANAELIXIR, 0, 0, 750);
            }
            else {
                SET_BOOTY(player, type, doMsgs, HEALALLPOTION, HEALALLPOTION, MANARESTORE, 0, 0, 1000);
            }
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 15);
                GET_MONSTER(player, type, doMsgs, 02, 17);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 15);
                GET_MONSTER(player, type, doMsgs, 02, 15);
                GET_MONSTER(player, type, doMsgs, 05, 26);
                GET_MONSTER(player, type, doMsgs, 06, 16);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 15);
                GET_MONSTER(player, type, doMsgs, 02, 15);
                GET_MONSTER(player, type, doMsgs, 03, 16);
                GET_MONSTER(player, type, doMsgs, 04, 16);
                GET_MONSTER(player, type, doMsgs, 06, 17);
            }
        }
        protected override void FnEvent4D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 1);
                GET_MONSTER(player, type, doMsgs, 02, 3);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 1);
                GET_MONSTER(player, type, doMsgs, 02, 1);
                GET_MONSTER(player, type, doMsgs, 05, 2);
                GET_MONSTER(player, type, doMsgs, 06, 3);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 1);
                GET_MONSTER(player, type, doMsgs, 02, 1);
                GET_MONSTER(player, type, doMsgs, 03, 2);
                GET_MONSTER(player, type, doMsgs, 05, 3);
                GET_MONSTER(player, type, doMsgs, 06, 3);
            }
        }
        protected override void FnEvent4E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You fall into a bottomless pit.");
            DamXit(player, type, doMsgs);
        }
        private void DamXit(TwPlayerServer player, MapEventType type, bool doMsgs) {
            DAMAGE(player, type, doMsgs, MAX_HEALTH(player, type, doMsgs));
        }
        private void FntnPic(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, FOUNTAIN);
        }
        private void WallClear(TwPlayerServer player, MapEventType type, bool doMsgs) {
            CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
        }
        private void WallBlock(TwPlayerServer player, MapEventType type, bool doMsgs) {
            BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
        }
        private void DamQuarter(TwPlayerServer player, MapEventType type, bool doMsgs) {
            DAMAGE(player, type, doMsgs, MAX_HEALTH(player, type, doMsgs) / 4);
            NO_HEAL_ZONE(player, type, doMsgs);
        }
        private void HealFtn(TwPlayerServer player, MapEventType type, bool doMsgs) {
            HEAL(player, type, doMsgs, MAX_HEALTH(player, type, doMsgs));
            MOD_MANA(player, type, doMsgs, 10000);
        }
        private void OuchFtn(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SET_PM(player, type, doMsgs, POISON, 5, MAX_HEALTH(player, type, doMsgs) / 5);
            SET_FLAG(player, type, doMsgs, ROOM, POISON_ME, 1);
        }
        private void Entmsg(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Enter to meet your Fate!");
        }
        protected override void FnEvent50(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You watch in horror as the lava engulfs the party ahead.");
        }
        protected override void FnEvent51(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, DUNGEON, HEAVENFTNFOUR) == 1 && GET_FLAG(player, type, doMsgs, DUNGEON, HEAVENFTNSIX) == 1 && GET_FLAG(player, type, doMsgs, DUNGEON, HEAVENFTNTHREE) == 1) {
                if ((GET_FLAG(player, type, doMsgs, DUNGEON, HEAVENFTNONE) == 0)) {
                    SHOW_PICTURE(player, type, doMsgs, DWARFWIZARD);
                    SHOW_TEXT(player, type, doMsgs, "'Please help me! I've been injured. My payment will be a secret that you need to know.'");
                    SHOW_TEXT(player, type, doMsgs, "You aid the ailing dwarf and listen to her story...");
                    SHOW_TEXT(player, type, doMsgs, "'I've heard that the guardians here use magic to hide some of the fountains from Thorzil. They reappear from time to time and you must visit them!'");
                    SET_FLAG(player, type, doMsgs, DUNGEON, HEAVENFTNONE, 1);
                }
            }
        }
        protected override void FnEvent52(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, DUNGEON, HELLBATTLE) == 5 || GET_FLAG(player, type, doMsgs, DUNGEON, GUARD) == 5) {
                SHOW_TEXT(player, type, doMsgs, "As you turn to leave your hear the hideous laughter of Pluthros.");
                SHOW_TEXT(player, type, doMsgs, "'Fools! You will never complete your task! I have again foiled your attempt at the correct switches!'");
            }
        }
    }
}
