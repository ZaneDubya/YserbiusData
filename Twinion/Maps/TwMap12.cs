using XPT.Generic.Maps;
using XPT.Twinion.Entities;

namespace XPT.Twinion.Maps {
    class TwMap12 : TwMap {
        protected override int MapIndex => 12;
        protected override int MapID => 0x0502;
        protected override int RandomEncounterChance => 15;
        protected override int RandomEncounterExtraCount => 1;

        protected override void FnEvent01(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 5, 2, 240, NORTH);
        }
        protected override void FnEvent02(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You enter a room where golems await you.");
            if (HAS_ITEM(player, type, doMsgs, MANARESTORE) || HAS_ITEM(player, type, doMsgs, GAUNTLETSOFMERCY)) {
                SET_BOOTY(player, type, doMsgs, MANDRAKESTAFF, SCROLLOFPROTECTION, 0, 0, 0, 1500);
            }
            else {
                SET_BOOTY(player, type, doMsgs, MANARESTORE, GAUNTLETSOFMERCY, 0, 0, 0, 3000);
            }
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 7);
                GET_MONSTER(player, type, doMsgs, 02, 8);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 7);
                GET_MONSTER(player, type, doMsgs, 02, 9);
                GET_MONSTER(player, type, doMsgs, 06, 9);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 7);
                GET_MONSTER(player, type, doMsgs, 02, 7);
                GET_MONSTER(player, type, doMsgs, 03, 8);
                GET_MONSTER(player, type, doMsgs, 05, 9);
                GET_MONSTER(player, type, doMsgs, 06, 9);
            }
        }
        protected override void FnEvent04(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "A bard sings his tale in the Cloister.");
            SHOW_TEXT(player, type, doMsgs, "If true, continue south. If false, walk west.");
        }
        protected override void FnEvent05(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 5, 2, 93, SOUTH);
        }
        protected override void FnEvent06(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 5, 2, 165, NORTH);
        }
        protected override void FnEvent07(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 5, 2, 69, WEST);
        }
        protected override void FnEvent08(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int itemA = 0;
            int race = 0;
            race = RACE(player, type, doMsgs);
            switch (race) {
                case HUMAN:
                    itemA = CORAL;
                    break;
                default:
                    itemA = OPAL;
                    break;
            }
            if (HAS_ITEM(player, type, doMsgs, itemA) || GET_FLAG(player, type, doMsgs, DUNGEON, PATHWAYDONE) == 1) {
                SHOW_TEXT(player, type, doMsgs, "Tyndil is not in his office.");
            }
            else {
                GIVE_ITEM(player, type, doMsgs, itemA);
                SHOW_PICTURE(player, type, doMsgs, GNOMEWIZARD);
                SHOW_TEXT(player, type, doMsgs, "The crafty Tyndil invites you into his office.");
                SHOW_TEXT(player, type, doMsgs, "'I offer a precious token in exchange for a mere glance at your map pieces. Thank you!'");
            }
        }
        protected override void FnEvent09(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int itemA = 0;
            int race = 0;
            race = RACE(player, type, doMsgs);
            switch (race) {
                case GREMLIN:
                case GNOME:
                    itemA = CORAL;
                    break;
                default:
                    itemA = TOPAZ;
                    break;
            }
            if (HAS_ITEM(player, type, doMsgs, itemA) || GET_FLAG(player, type, doMsgs, DUNGEON, PATHWAYDONE) == 1) {
                SHOW_TEXT(player, type, doMsgs, "Kalydor is not in his office.");
            }
            else {
                SHOW_PICTURE(player, type, doMsgs, ORCKNIGHT);
                GIVE_ITEM(player, type, doMsgs, itemA);
                SHOW_TEXT(player, type, doMsgs, "Kalydor's excitement is obvious.");
                SHOW_TEXT(player, type, doMsgs, "'Take this precious bauble in exchange for one look at your map pieces. Ah, yes, very good!'");
            }
        }
        protected override void FnEvent0A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "This portal will send you to the Main Entrance.");
            TELEPORT(player, type, doMsgs, 1, 1, 204, NORTH);
        }
        protected override void FnEvent0B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int itemA = 0;
            int itemB = SHORTSWORD;
            int itemC = 0;
            int itemD = 0;
            int itemE = UNITYRING;
            int tile = 0;
            if ((GET_FLAG(player, type, doMsgs, DUNGEON, PATHWAYDONE) == 0)) {
                if (PARTY_COUNT(player, type, doMsgs) == 1 && RACE(player, type, doMsgs) == GNOME) {
                    tile = HERE(player, type, doMsgs);
                    switch (tile) {
                        case 116:
                            itemA = EBONY;
                            itemC = PEARL;
                            itemD = OPAL;
                            break;
                        case 115:
                            itemA = CORAL;
                            itemC = LIFEJACKET;
                            itemD = TOPAZ;
                            break;
                        case 114:
                            itemA = OPAL;
                            itemC = EBONY;
                            itemD = SPIRITBOTTLE;
                            break;
                        case 113:
                            itemA = PEARL;
                            itemC = TOPAZ;
                            itemD = EBONY;
                            break;
                    }
                    if (USED_ITEM(player, type, doMsgs, itemB, itemC) || USED_ITEM(player, type, doMsgs, itemD, itemE)) {
                        DamXit(player, type, doMsgs);
                    }
                    else if (USED_ITEM(player, type, doMsgs, itemA, itemA)) {
                        CLEAR_WALL(player, type, doMsgs, tile, WEST);
                        PLACE_WALL_ITEM(player, type, doMsgs, DOOR, tile, WEST);
                        SHOW_TEXT(player, type, doMsgs, "You've unlocked this door!");
                        SHOW_TEXT(player, type, doMsgs, "Now proceed to the next lock.");
                    }
                    else {
                        SHOW_TEXT(player, type, doMsgs, "Use the correct token to unlock this door.");
                        WallBlock(player, type, doMsgs);
                    }
                }
                else {
                    SHOW_TEXT(player, type, doMsgs, "'Intrepid Gnome, if you have read the secret clues, use your tokens as the keys.'");
                    WallBlock(player, type, doMsgs);
                }
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "The doors remain open for you.");
                WallClear(player, type, doMsgs);
            }
        }
        protected override void FnEvent0C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int itemA = 0;
            int itemB = SHORTSWORD;
            int itemC = 0;
            int itemD = 0;
            int itemE = UNITYRING;
            int tile = 0;
            if ((GET_FLAG(player, type, doMsgs, DUNGEON, PATHWAYDONE) == 0)) {
                if (PARTY_COUNT(player, type, doMsgs) == 1 && RACE(player, type, doMsgs) == HALFLING) {
                    tile = HERE(player, type, doMsgs);
                    switch (tile) {
                        case 68:
                            itemA = TOPAZ;
                            itemC = CORAL;
                            itemD = PEARL;
                            break;
                        case 67:
                            itemA = PEARL;
                            itemC = TOPAZ;
                            itemD = EBONY;
                            break;
                        case 66:
                            itemA = EBONY;
                            itemC = PEARL;
                            itemD = OPAL;
                            break;
                        case 65:
                            itemA = OPAL;
                            itemC = EBONY;
                            itemD = SPIRITBOTTLE;
                            break;
                    }
                    if (USED_ITEM(player, type, doMsgs, itemB, itemC) || USED_ITEM(player, type, doMsgs, itemD, itemE)) {
                        DamXit(player, type, doMsgs);
                    }
                    else if (USED_ITEM(player, type, doMsgs, itemA, itemA)) {
                        CLEAR_WALL(player, type, doMsgs, tile, WEST);
                        PLACE_WALL_ITEM(player, type, doMsgs, DOOR, tile, WEST);
                        SHOW_TEXT(player, type, doMsgs, "You've unlocked this door!");
                        SHOW_TEXT(player, type, doMsgs, "Now proceed to the next lock.");
                    }
                    else {
                        SHOW_TEXT(player, type, doMsgs, "Use the correct token to unlock this door.");
                        WallBlock(player, type, doMsgs);
                    }
                }
                else {
                    SHOW_TEXT(player, type, doMsgs, "'Worthy Halfling, if you have read the secret clues, use your tokens as the keys.'");
                    WallBlock(player, type, doMsgs);
                }
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "The doors remain open for you.");
                WallClear(player, type, doMsgs);
            }
        }
        protected override void FnEvent0D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int itemA = 0;
            int itemB = SHORTSWORD;
            int itemC = 0;
            int itemD = 0;
            int itemE = UNITYRING;
            int tile = 0;
            if ((GET_FLAG(player, type, doMsgs, DUNGEON, PATHWAYDONE) == 0)) {
                if (PARTY_COUNT(player, type, doMsgs) == 1 && RACE(player, type, doMsgs) == ORC) {
                    tile = HERE(player, type, doMsgs);
                    switch (tile) {
                        case 84:
                            itemA = PEARL;
                            itemC = TOPAZ;
                            itemD = EBONY;
                            break;
                        case 83:
                            itemA = OPAL;
                            itemC = EBONY;
                            itemD = SPIRITBOTTLE;
                            break;
                        case 82:
                            itemA = CORAL;
                            itemC = LIFEJACKET;
                            itemD = TOPAZ;
                            break;
                        case 81:
                            itemA = TOPAZ;
                            itemC = CORAL;
                            itemD = PEARL;
                            break;
                    }
                    if (USED_ITEM(player, type, doMsgs, itemB, itemC) || USED_ITEM(player, type, doMsgs, itemD, itemE)) {
                        DamXit(player, type, doMsgs);
                    }
                    else if (USED_ITEM(player, type, doMsgs, itemA, itemA)) {
                        CLEAR_WALL(player, type, doMsgs, tile, WEST);
                        PLACE_WALL_ITEM(player, type, doMsgs, DOOR, tile, WEST);
                        SHOW_TEXT(player, type, doMsgs, "You've unlocked this door!");
                        SHOW_TEXT(player, type, doMsgs, "Now proceed to the next lock.");
                    }
                    else {
                        SHOW_TEXT(player, type, doMsgs, "Use the correct token to unlock this door.");
                        WallBlock(player, type, doMsgs);
                    }
                }
                else {
                    SHOW_TEXT(player, type, doMsgs, "'Brave Orc, if you have read the secret clues, use your tokens as the keys.'");
                    WallBlock(player, type, doMsgs);
                }
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "The doors remain open for you.");
                WallClear(player, type, doMsgs);
            }
        }
        protected override void FnEvent0E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int itemA = 0;
            int itemB = SHORTSWORD;
            int itemC = 0;
            int itemD = 0;
            int itemE = UNITYRING;
            int tile = 0;
            if ((GET_FLAG(player, type, doMsgs, DUNGEON, PATHWAYDONE) == 0)) {
                if (PARTY_COUNT(player, type, doMsgs) == 1 && RACE(player, type, doMsgs) == TROLL) {
                    tile = HERE(player, type, doMsgs);
                    switch (tile) {
                        case 100:
                            itemA = OPAL;
                            itemC = EBONY;
                            itemD = SPIRITBOTTLE;
                            break;
                        case 99:
                            itemA = CORAL;
                            itemC = LIFEJACKET;
                            itemD = TOPAZ;
                            break;
                        case 98:
                            itemA = TOPAZ;
                            itemC = CORAL;
                            itemD = PEARL;
                            break;
                        case 97:
                            itemA = PEARL;
                            itemC = TOPAZ;
                            itemD = EBONY;
                            break;
                    }
                    if (USED_ITEM(player, type, doMsgs, itemB, itemC) || USED_ITEM(player, type, doMsgs, itemD, itemE)) {
                        DamXit(player, type, doMsgs);
                    }
                    else if (USED_ITEM(player, type, doMsgs, itemA, itemA)) {
                        CLEAR_WALL(player, type, doMsgs, tile, WEST);
                        PLACE_WALL_ITEM(player, type, doMsgs, DOOR, tile, WEST);
                        SHOW_TEXT(player, type, doMsgs, "You've unlocked this door!");
                        SHOW_TEXT(player, type, doMsgs, "Now proceed to the next lock.");
                    }
                    else {
                        SHOW_TEXT(player, type, doMsgs, "Use the correct token to unlock this door.");
                        WallBlock(player, type, doMsgs);
                    }
                }
                else {
                    SHOW_TEXT(player, type, doMsgs, "'Courageous Troll, if you have read the secret clues, use the tokens as the keys.'");
                    WallBlock(player, type, doMsgs);
                }
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "The doors remain open for you.");
                WallClear(player, type, doMsgs);
            }
        }
        protected override void FnEvent0F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, DWARFWIZARD);
            SHOW_TEXT(player, type, doMsgs, "Xanith smiles as you draw near.");
            SHOW_TEXT(player, type, doMsgs, "'I see you have mastered my riddles. To the west are some doors. Proceed alone through the door designated for your race.'");
            SHOW_TEXT(player, type, doMsgs, "'You must use your tokens in the order you were told, lest dire consequences befall you!'");
        }
        protected override void FnEvent10(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Angel Fountain is in Cliffhanger. If true, continue south. If false, walk north.");
        }
        protected override void FnEvent11(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 5, 3, 47, NORTH);
            SHOW_TEXT(player, type, doMsgs, "To the Graveyard.");
        }
        protected override void FnEvent12(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "The Emerald Lockpick is exchanged for the Diamond Lockpick. If true, take the door to the south. If false, take the door to the east.");
        }
        protected override void FnEvent13(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GET_FLAG(player, type, doMsgs, DUNGEON, PATHWAYDONE) == 0)) {
                SHOW_PICTURE(player, type, doMsgs, QUEENAEOWYN);
                SHOW_TEXT(player, type, doMsgs, "Queen Aeowyn materializes in the room.");
                SHOW_TEXT(player, type, doMsgs, "'Greetings, my Champion. Now we may bond these fragments together in this magical space.'");
                SHOW_TEXT(player, type, doMsgs, "Aeowyn examines the pieces closely and then arranges them on the floor in a peculiar order.");
                SHOW_TEXT(player, type, doMsgs, "'Ahh...look!' You watch as the tokens release their magical properties and fuse together the map pieces.");
                SHOW_TEXT(player, type, doMsgs, "'Now, take this map and use it as the key through the northern gateway opposite the Night Elves' portal in the Main Entrance.");
                SHOW_TEXT(player, type, doMsgs, "Fare thee well.' The Queen then vanishes.");
                SET_FLAG(player, type, doMsgs, DUNGEON, PATHWAYDONE, 1);
                TAKE_ITEM(player, type, doMsgs, LEATHERMAP);
                TAKE_ITEM(player, type, doMsgs, PARCHMENTMAP);
                TAKE_ITEM(player, type, doMsgs, SLATEMAP);
                TAKE_ITEM(player, type, doMsgs, SNAKESKINMAP);
                TAKE_ITEM(player, type, doMsgs, CORAL);
                TAKE_ITEM(player, type, doMsgs, EBONY);
                TAKE_ITEM(player, type, doMsgs, OPAL);
                TAKE_ITEM(player, type, doMsgs, PEARL);
                TAKE_ITEM(player, type, doMsgs, TOPAZ);
                GIVE_ITEM(player, type, doMsgs, WHOLEMAP);
                MOD_EXP(player, type, doMsgs, 2500000);
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "A quiet breezes wafts through this area.");
            }
        }
        protected override void FnEvent14(TwPlayerServer player, MapEventType type, bool doMsgs) {
            NO_SPELL(player, type, doMsgs);
            if (PARTY_COUNT(player, type, doMsgs) > 1) {
                int racecheck = 0;
                int tile = 0;
                racecheck = RACE(player, type, doMsgs);
                switch (racecheck) {
                    case HALFLING:
                        tile = 68;
                        break;
                    case ORC:
                        tile = 84;
                        break;
                    case TROLL:
                        tile = 100;
                        break;
                    case GNOME:
                        tile = 116;
                        break;
                    case ELF:
                        tile = 132;
                        break;
                    case DWARF:
                        tile = 148;
                        break;
                    case GREMLIN:
                        tile = 164;
                        break;
                    case HUMAN:
                        tile = 180;
                        break;
                }
                SHOW_TEXT(player, type, doMsgs, "You must enter here alone!");
                TELEPORT(player, type, doMsgs, 5, 2, tile, EAST);
            }
        }
        protected override void FnEvent15(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int itemA = 0;
            int itemB = SHORTSWORD;
            int itemC = 0;
            int itemD = 0;
            int itemE = UNITYRING;
            int tile = 0;
            if ((GET_FLAG(player, type, doMsgs, DUNGEON, PATHWAYDONE) == 0)) {
                if (PARTY_COUNT(player, type, doMsgs) == 1 && RACE(player, type, doMsgs) == ELF) {
                    tile = HERE(player, type, doMsgs);
                    switch (tile) {
                        case 132:
                            itemA = EBONY;
                            itemC = PEARL;
                            itemD = OPAL;
                            break;
                        case 131:
                            itemA = OPAL;
                            itemC = EBONY;
                            itemD = SPIRITBOTTLE;
                            break;
                        case 130:
                            itemA = CORAL;
                            itemC = LIFEJACKET;
                            itemD = TOPAZ;
                            break;
                        case 129:
                            itemA = TOPAZ;
                            itemC = CORAL;
                            itemD = PEARL;
                            break;
                    }
                    if (USED_ITEM(player, type, doMsgs, itemB, itemC) || USED_ITEM(player, type, doMsgs, itemD, itemE)) {
                        DamXit(player, type, doMsgs);
                    }
                    else if (USED_ITEM(player, type, doMsgs, itemA, itemA)) {
                        CLEAR_WALL(player, type, doMsgs, tile, WEST);
                        PLACE_WALL_ITEM(player, type, doMsgs, DOOR, tile, WEST);
                        SHOW_TEXT(player, type, doMsgs, "You've unlocked this door!");
                        SHOW_TEXT(player, type, doMsgs, "Proceed.");
                    }
                    else {
                        SHOW_TEXT(player, type, doMsgs, "Use the correct token to unlock this door.");
                        WallBlock(player, type, doMsgs);
                    }
                }
                else {
                    SHOW_TEXT(player, type, doMsgs, "'Fearless Elf, if you have read the secret clues, use your tokens as the keys.'");
                    WallBlock(player, type, doMsgs);
                }
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "The doors remain open for you.");
                WallClear(player, type, doMsgs);
            }
        }
        protected override void FnEvent16(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int itemA = 0;
            int itemB = SHORTSWORD;
            int itemC = 0;
            int itemD = 0;
            int itemE = UNITYRING;
            int tile = 0;
            if ((GET_FLAG(player, type, doMsgs, DUNGEON, PATHWAYDONE) == 0)) {
                if (PARTY_COUNT(player, type, doMsgs) == 1 && RACE(player, type, doMsgs) == DWARF) {
                    tile = HERE(player, type, doMsgs);
                    switch (tile) {
                        case 148:
                            itemA = OPAL;
                            itemC = EBONY;
                            itemD = SPIRITBOTTLE;
                            break;
                        case 147:
                            itemA = TOPAZ;
                            itemC = CORAL;
                            itemD = PEARL;
                            break;
                        case 146:
                            itemA = EBONY;
                            itemC = PEARL;
                            itemD = OPAL;
                            break;
                        case 145:
                            itemA = CORAL;
                            itemC = LIFEJACKET;
                            itemD = TOPAZ;
                            break;
                    }
                    if (USED_ITEM(player, type, doMsgs, itemB, itemC) || USED_ITEM(player, type, doMsgs, itemD, itemE)) {
                        DamXit(player, type, doMsgs);
                    }
                    else if (USED_ITEM(player, type, doMsgs, itemA, itemA)) {
                        CLEAR_WALL(player, type, doMsgs, tile, WEST);
                        PLACE_WALL_ITEM(player, type, doMsgs, DOOR, tile, WEST);
                        SHOW_TEXT(player, type, doMsgs, "You've unlocked this door!");
                        SHOW_TEXT(player, type, doMsgs, "Proceed.");
                    }
                    else {
                        SHOW_TEXT(player, type, doMsgs, "Use the correct token to unlock this door.");
                        WallBlock(player, type, doMsgs);
                    }
                }
                else {
                    SHOW_TEXT(player, type, doMsgs, "'Valiant Dwarf, if you have read the secret clues, use your tokens as the keys.'");
                    WallBlock(player, type, doMsgs);
                }
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "The doors remain open for you.");
                WallClear(player, type, doMsgs);
            }
        }
        protected override void FnEvent17(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 5, 3, 233, SOUTH);
            SHOW_TEXT(player, type, doMsgs, "To the Graveyard.");
        }
        protected override void FnEvent18(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "The Vault is found in Twinion Keep. If true, continue east. If false, walk west.");
        }
        protected override void FnEvent19(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 5, 2, 151, NORTH);
        }
        protected override void FnEvent1A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int itemA = 0;
            int itemB = SHORTSWORD;
            int itemC = 0;
            int itemD = 0;
            int itemE = UNITYRING;
            int tile = 0;
            if ((GET_FLAG(player, type, doMsgs, DUNGEON, PATHWAYDONE) == 0)) {
                if (PARTY_COUNT(player, type, doMsgs) == 1 && RACE(player, type, doMsgs) == GREMLIN) {
                    tile = HERE(player, type, doMsgs);
                    switch (tile) {
                        case 164:
                            itemA = PEARL;
                            itemC = TOPAZ;
                            itemD = EBONY;
                            break;
                        case 163:
                            itemA = EBONY;
                            itemC = PEARL;
                            itemD = OPAL;
                            break;
                        case 162:
                            itemA = OPAL;
                            itemC = EBONY;
                            itemD = SPIRITBOTTLE;
                            break;
                        case 161:
                            itemA = CORAL;
                            itemC = LIFEJACKET;
                            itemD = TOPAZ;
                            break;
                    }
                    if (USED_ITEM(player, type, doMsgs, itemB, itemC) || USED_ITEM(player, type, doMsgs, itemD, itemE)) {
                        DamXit(player, type, doMsgs);
                    }
                    else if (USED_ITEM(player, type, doMsgs, itemA, itemA)) {
                        CLEAR_WALL(player, type, doMsgs, tile, WEST);
                        PLACE_WALL_ITEM(player, type, doMsgs, DOOR, tile, WEST);
                        SHOW_TEXT(player, type, doMsgs, "You've unlocked this door!");
                        SHOW_TEXT(player, type, doMsgs, "Proceed.");
                    }
                    else {
                        SHOW_TEXT(player, type, doMsgs, "Use the correct token to unlock this door.");
                        WallBlock(player, type, doMsgs);
                    }
                }
                else {
                    SHOW_TEXT(player, type, doMsgs, "'Hardy Gremlin, if you have read the secret clues, use your tokens as the keys.'");
                    WallBlock(player, type, doMsgs);
                }
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "The doors remain open for you.");
                WallClear(player, type, doMsgs);
            }
        }
        protected override void FnEvent1B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int itemA = 0;
            int itemB = SHORTSWORD;
            int itemC = 0;
            int itemD = 0;
            int itemE = UNITYRING;
            int tile = 0;
            if ((GET_FLAG(player, type, doMsgs, DUNGEON, PATHWAYDONE) == 0)) {
                if (PARTY_COUNT(player, type, doMsgs) == 1 && RACE(player, type, doMsgs) == HUMAN) {
                    tile = HERE(player, type, doMsgs);
                    switch (tile) {
                        case 180:
                            itemA = CORAL;
                            itemC = LIFEJACKET;
                            itemD = TOPAZ;
                            break;
                        case 179:
                            itemA = TOPAZ;
                            itemC = CORAL;
                            itemD = PEARL;
                            break;
                        case 178:
                            itemA = PEARL;
                            itemC = TOPAZ;
                            itemD = EBONY;
                            break;
                        case 177:
                            itemA = EBONY;
                            itemC = PEARL;
                            itemD = OPAL;
                            break;
                    }
                    if (USED_ITEM(player, type, doMsgs, itemB, itemC) || USED_ITEM(player, type, doMsgs, itemD, itemE)) {
                        DamXit(player, type, doMsgs);
                    }
                    else if (USED_ITEM(player, type, doMsgs, itemA, itemA)) {
                        CLEAR_WALL(player, type, doMsgs, tile, WEST);
                        PLACE_WALL_ITEM(player, type, doMsgs, DOOR, tile, WEST);
                        SHOW_TEXT(player, type, doMsgs, "You've unlocked this door!");
                        SHOW_TEXT(player, type, doMsgs, "Proceed.");
                    }
                    else {
                        SHOW_TEXT(player, type, doMsgs, "Use the correct token to unlock this door.");
                        WallBlock(player, type, doMsgs);
                    }
                }
                else {
                    SHOW_TEXT(player, type, doMsgs, "'Adventurous Human, if you have read the secret clues, use the tokens as the keys.'");
                    WallBlock(player, type, doMsgs);
                }
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "The doors remain open for you.");
                WallClear(player, type, doMsgs);
            }
        }
        protected override void FnEvent1C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "To go back and search for your clues, exit here.");
        }
        protected override void FnEvent1E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 5, 2, 33, NORTH);
        }
        protected override void FnEvent23(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "The musty smell of old maps is overpowering. You sense your mana being leeched away.");
            MOD_MANA(player, type, doMsgs,  - 200);
        }
        protected override void FnEvent28(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "The only way to Race Track is from Rat Race. If true, continue north. If false, walk east.");
        }
        protected override void FnEvent29(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 5, 2, 194, EAST);
        }
        protected override void FnEvent2A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 5, 2, 59, SOUTH);
        }
        protected override void FnEvent2F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Harmonics should visit the Tool Shed for a reward. If true, continue west. If false, walk east.");
        }
        protected override void FnEvent34(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Smug owns a Pawn Shop. If true, continue west. If false, walk south.");
        }
        protected override void FnEvent39(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "A book on the table reads, 'Futility is the price you pay for returning to the Cartography Shop ere you know the riddles' answers.'");
        }
        protected override void FnEvent3A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "A path of correct answers will lead you directly to the Cartographer.");
        }
        protected override void FnEvent3C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 5, 2, 45, SOUTH);
        }
        protected override void FnEvent3D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (USED_SKILL(player, type, doMsgs, DETECT_SKILL) >= 8 || USED_SPELL(player, type, doMsgs, TRUE_SEEING_SPELL) >= 1 || USED_ITEM(player, type, doMsgs, HELMOFWISDOM, HELMOFWISDOM) || USED_ITEM(player, type, doMsgs, VALKYRIESHELM, VALKYRIESHELM) || USED_ITEM(player, type, doMsgs, RINGOFTHIEVES, RINGOFTHIEVES) || USED_ITEM(player, type, doMsgs, CRYSTALBALL, CRYSTALBALL)) {
                SHOW_TEXT(player, type, doMsgs, "A secret door is revealed.");
                PLACE_WALL_ITEM(player, type, doMsgs, DOOR, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
                WallClear(player, type, doMsgs);
            }
            else {
                WallBlock(player, type, doMsgs);
            }
        }
        protected override void FnEvent3E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 5, 2, 35, WEST);
        }
        protected override void FnEvent3F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int itemA = 0;
            int race = 0;
            race = RACE(player, type, doMsgs);
            switch (race) {
                case ORC:
                case TROLL:
                    itemA = CORAL;
                    break;
                default:
                    itemA = EBONY;
                    break;
            }
            if (HAS_ITEM(player, type, doMsgs, itemA) || GET_FLAG(player, type, doMsgs, DUNGEON, PATHWAYDONE) == 1) {
                SHOW_TEXT(player, type, doMsgs, "Dabelais is not in his office.");
            }
            else {
                GIVE_ITEM(player, type, doMsgs, itemA);
                SHOW_PICTURE(player, type, doMsgs, ELFCLERIC);
                SHOW_TEXT(player, type, doMsgs, "Dabelais looks up and says, 'Accept this token as payment for showing me your map pieces.'");
            }
        }
        protected override void FnEvent41(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int itemA = 0;
            int race = 0;
            race = RACE(player, type, doMsgs);
            switch (race) {
                case DWARF:
                case ELF:
                    itemA = CORAL;
                    break;
                default:
                    itemA = PEARL;
                    break;
            }
            if (HAS_ITEM(player, type, doMsgs, itemA) || GET_FLAG(player, type, doMsgs, DUNGEON, PATHWAYDONE) == 1) {
                SHOW_TEXT(player, type, doMsgs, "Syrene is not in her office.");
            }
            else {
                SHOW_PICTURE(player, type, doMsgs, ORCRANGER);
                GIVE_ITEM(player, type, doMsgs, itemA);
                SHOW_TEXT(player, type, doMsgs, "Syrene greets you. 'Adventurers, I offer a token for a glance at your map pieces.'");
            }
        }
        protected override void FnEvent42(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Unity Fountain is found in Rat Race. If true, continue east. If false, walk west.");
        }
        protected override void FnEvent43(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Fellowship Fountain is found in the Armory. If true, continue south. If false, walk north.");
        }
        protected override void FnEvent44(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 5, 2, 15, SOUTH);
        }
        protected override void FnEvent45(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 5, 2, 88, SOUTH);
        }
        protected override void FnEvent46(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "To the Graveyard.");
            TELEPORT(player, type, doMsgs, 5, 3, 225, WEST);
        }
        protected override void FnEvent47(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, FOUNTAIN);
            if (GET_FLAG(player, type, doMsgs, DUNGEON, NSTAR) == 1) {
                SHOW_TEXT(player, type, doMsgs, "The twinkling waters of NorthStar Fountain restore your mana.");
                MOD_MANA(player, type, doMsgs, 10000);
            }
            else {
                MOD_MANA(player, type, doMsgs, 10000);
                MOD_STAT(player, type, doMsgs, INITIATIVE, 2);
                MOD_STAT(player, type, doMsgs, STRENGTH, 1);
                SET_FLAG(player, type, doMsgs, DUNGEON, NSTAR, 1);
                SHOW_TEXT(player, type, doMsgs, "The twinkling waters of NorthStar Fountain restore your mana and increase your Strength and Initiative.");
            }
        }
        protected override void FnEvent4B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 26);
                GET_MONSTER(player, type, doMsgs, 02, 31);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 27);
                GET_MONSTER(player, type, doMsgs, 02, 27);
                GET_MONSTER(player, type, doMsgs, 03, 31);
                GET_MONSTER(player, type, doMsgs, 06, 30);
            }
        }
        protected override void FnEvent4D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 6);
                GET_MONSTER(player, type, doMsgs, 02, 7);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 6);
                GET_MONSTER(player, type, doMsgs, 02, 6);
                GET_MONSTER(player, type, doMsgs, 03, 7);
                GET_MONSTER(player, type, doMsgs, 04, 40);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 9);
                GET_MONSTER(player, type, doMsgs, 02, 9);
                GET_MONSTER(player, type, doMsgs, 03, 25);
                GET_MONSTER(player, type, doMsgs, 04, 25);
                GET_MONSTER(player, type, doMsgs, 05, 11);
            }
        }
        protected override void FnEvent4F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 35);
                GET_MONSTER(player, type, doMsgs, 02, 27);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 35);
                GET_MONSTER(player, type, doMsgs, 02, 36);
                GET_MONSTER(player, type, doMsgs, 03, 28);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 35);
                GET_MONSTER(player, type, doMsgs, 02, 36);
                GET_MONSTER(player, type, doMsgs, 03, 29);
                GET_MONSTER(player, type, doMsgs, 04, 30);
            }
        }
        protected override void FnEvent50(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 6);
                GET_MONSTER(player, type, doMsgs, 02, 36);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 6);
                GET_MONSTER(player, type, doMsgs, 02, 5);
                GET_MONSTER(player, type, doMsgs, 03, 14);
                GET_MONSTER(player, type, doMsgs, 05, 32);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 8);
                GET_MONSTER(player, type, doMsgs, 02, 8);
                GET_MONSTER(player, type, doMsgs, 03, 25);
                GET_MONSTER(player, type, doMsgs, 04, 25);
                GET_MONSTER(player, type, doMsgs, 05, 32);
                GET_MONSTER(player, type, doMsgs, 06, 32);
            }
        }
        private void DamXit(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You failed to use the correct item.");
            DAMAGE(player, type, doMsgs, MAX_HEALTH(player, type, doMsgs));
        }
        private void WallBlock(TwPlayerServer player, MapEventType type, bool doMsgs) {
            BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
        }
        private void WallClear(TwPlayerServer player, MapEventType type, bool doMsgs) {
            CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
        }
    }
}
