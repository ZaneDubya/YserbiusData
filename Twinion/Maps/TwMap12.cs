using XPT.Games.Generic.Constants;
using XPT.Games.Generic.Maps;
using XPT.Games.Twinion.Entities;

namespace XPT.Games.Twinion.Maps {
    class TwMap12 : TwMap {
        public override int MapIndex => 12;
        public override int MapID => 0x0502;
        protected override int RandomEncounterChance => 15;
        protected override int RandomEncounterExtraCount => 1;

        protected override void FnEvent01(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 5, 2, 240, Direction.North);
        }
        protected override void FnEvent02(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You enter a room where golems await you.");
            if (HasItem(player, type, doMsgs, MANARESTORE) || HasItem(player, type, doMsgs, GAUNTLETSOFMERCY)) {
                SetTreasure(player, type, doMsgs, MANDRAKESTAFF, SCROLLOFPROTECTION, 0, 0, 0, 1500);
            }
            else {
                SetTreasure(player, type, doMsgs, MANARESTORE, GAUNTLETSOFMERCY, 0, 0, 0, 3000);
            }
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 7);
                AddEncounter(player, type, doMsgs, 02, 8);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 7);
                AddEncounter(player, type, doMsgs, 02, 9);
                AddEncounter(player, type, doMsgs, 06, 9);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 7);
                AddEncounter(player, type, doMsgs, 02, 7);
                AddEncounter(player, type, doMsgs, 03, 8);
                AddEncounter(player, type, doMsgs, 05, 9);
                AddEncounter(player, type, doMsgs, 06, 9);
            }
        }
        protected override void FnEvent04(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "A bard sings his tale in the Cloister.");
            ShowText(player, type, doMsgs, "If true, continue south. If false, walk west.");
        }
        protected override void FnEvent05(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 5, 2, 93, Direction.South);
        }
        protected override void FnEvent06(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 5, 2, 165, Direction.North);
        }
        protected override void FnEvent07(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 5, 2, 69, Direction.West);
        }
        protected override void FnEvent08(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int itemA = 0;
            int race = 0;
            race = GetRace(player, type, doMsgs);
            switch (race) {
                case HUMAN:
                    itemA = CORAL;
                    break;
                default:
                    itemA = OPAL;
                    break;
            }
            if (HasItem(player, type, doMsgs, itemA) || GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.PATHWAYDONE) == 1) {
                ShowText(player, type, doMsgs, "Tyndil is not in his office.");
            }
            else {
                GiveItem(player, type, doMsgs, itemA);
                ShowPortrait(player, type, doMsgs, GNOMEWIZARD);
                ShowText(player, type, doMsgs, "The crafty Tyndil invites you into his office.");
                ShowText(player, type, doMsgs, "'I offer a precious token in exchange for a mere glance at your map pieces. Thank you!'");
            }
        }
        protected override void FnEvent09(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int itemA = 0;
            int race = 0;
            race = GetRace(player, type, doMsgs);
            switch (race) {
                case GREMLIN:
                case GNOME:
                    itemA = CORAL;
                    break;
                default:
                    itemA = TOPAZ;
                    break;
            }
            if (HasItem(player, type, doMsgs, itemA) || GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.PATHWAYDONE) == 1) {
                ShowText(player, type, doMsgs, "Kalydor is not in his office.");
            }
            else {
                ShowPortrait(player, type, doMsgs, ORCKNIGHT);
                GiveItem(player, type, doMsgs, itemA);
                ShowText(player, type, doMsgs, "Kalydor's excitement is obvious.");
                ShowText(player, type, doMsgs, "'Take this precious bauble in exchange for one look at your map pieces. Ah, yes, very good!'");
            }
        }
        protected override void FnEvent0A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "This portal will send you to the Main Entrance.");
            TeleportParty(player, type, doMsgs, 1, 1, 204, Direction.North);
        }
        protected override void FnEvent0B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int itemA = 0;
            int itemB = SHORTSWORD;
            int itemC = 0;
            int itemD = 0;
            int itemE = UNITYRING;
            int tile = 0;
            if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.PATHWAYDONE) == 0)) {
                if (GetPartyCount(player, type, doMsgs) == 1 && GetRace(player, type, doMsgs) == GNOME) {
                    tile = GetTile(player, type, doMsgs);
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
                    if (UsedItem(player, type, ref doMsgs, itemB, itemC) || UsedItem(player, type, ref doMsgs, itemD, itemE)) {
                        DamXit(player, type, doMsgs);
                    }
                    else if (UsedItem(player, type, ref doMsgs, itemA, itemA)) {
                        ClearWallBlock(player, type, doMsgs, tile, Direction.West);
                        SetWallItem(player, type, doMsgs, DOOR, tile, Direction.West);
                        ShowText(player, type, doMsgs, "You've unlocked this door!");
                        ShowText(player, type, doMsgs, "Now proceed to the next lock.");
                    }
                    else {
                        ShowText(player, type, doMsgs, "Use the correct token to unlock this door.");
                        WallBlock(player, type, doMsgs);
                    }
                }
                else {
                    ShowText(player, type, doMsgs, "'Intrepid Gnome, if you have read the secret clues, use your tokens as the keys.'");
                    WallBlock(player, type, doMsgs);
                }
            }
            else {
                ShowText(player, type, doMsgs, "The doors remain open for you.");
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
            if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.PATHWAYDONE) == 0)) {
                if (GetPartyCount(player, type, doMsgs) == 1 && GetRace(player, type, doMsgs) == HALFLING) {
                    tile = GetTile(player, type, doMsgs);
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
                    if (UsedItem(player, type, ref doMsgs, itemB, itemC) || UsedItem(player, type, ref doMsgs, itemD, itemE)) {
                        DamXit(player, type, doMsgs);
                    }
                    else if (UsedItem(player, type, ref doMsgs, itemA, itemA)) {
                        ClearWallBlock(player, type, doMsgs, tile, Direction.West);
                        SetWallItem(player, type, doMsgs, DOOR, tile, Direction.West);
                        ShowText(player, type, doMsgs, "You've unlocked this door!");
                        ShowText(player, type, doMsgs, "Now proceed to the next lock.");
                    }
                    else {
                        ShowText(player, type, doMsgs, "Use the correct token to unlock this door.");
                        WallBlock(player, type, doMsgs);
                    }
                }
                else {
                    ShowText(player, type, doMsgs, "'Worthy Halfling, if you have read the secret clues, use your tokens as the keys.'");
                    WallBlock(player, type, doMsgs);
                }
            }
            else {
                ShowText(player, type, doMsgs, "The doors remain open for you.");
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
            if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.PATHWAYDONE) == 0)) {
                if (GetPartyCount(player, type, doMsgs) == 1 && GetRace(player, type, doMsgs) == ORC) {
                    tile = GetTile(player, type, doMsgs);
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
                    if (UsedItem(player, type, ref doMsgs, itemB, itemC) || UsedItem(player, type, ref doMsgs, itemD, itemE)) {
                        DamXit(player, type, doMsgs);
                    }
                    else if (UsedItem(player, type, ref doMsgs, itemA, itemA)) {
                        ClearWallBlock(player, type, doMsgs, tile, Direction.West);
                        SetWallItem(player, type, doMsgs, DOOR, tile, Direction.West);
                        ShowText(player, type, doMsgs, "You've unlocked this door!");
                        ShowText(player, type, doMsgs, "Now proceed to the next lock.");
                    }
                    else {
                        ShowText(player, type, doMsgs, "Use the correct token to unlock this door.");
                        WallBlock(player, type, doMsgs);
                    }
                }
                else {
                    ShowText(player, type, doMsgs, "'Brave Orc, if you have read the secret clues, use your tokens as the keys.'");
                    WallBlock(player, type, doMsgs);
                }
            }
            else {
                ShowText(player, type, doMsgs, "The doors remain open for you.");
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
            if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.PATHWAYDONE) == 0)) {
                if (GetPartyCount(player, type, doMsgs) == 1 && GetRace(player, type, doMsgs) == TROLL) {
                    tile = GetTile(player, type, doMsgs);
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
                    if (UsedItem(player, type, ref doMsgs, itemB, itemC) || UsedItem(player, type, ref doMsgs, itemD, itemE)) {
                        DamXit(player, type, doMsgs);
                    }
                    else if (UsedItem(player, type, ref doMsgs, itemA, itemA)) {
                        ClearWallBlock(player, type, doMsgs, tile, Direction.West);
                        SetWallItem(player, type, doMsgs, DOOR, tile, Direction.West);
                        ShowText(player, type, doMsgs, "You've unlocked this door!");
                        ShowText(player, type, doMsgs, "Now proceed to the next lock.");
                    }
                    else {
                        ShowText(player, type, doMsgs, "Use the correct token to unlock this door.");
                        WallBlock(player, type, doMsgs);
                    }
                }
                else {
                    ShowText(player, type, doMsgs, "'Courageous Troll, if you have read the secret clues, use the tokens as the keys.'");
                    WallBlock(player, type, doMsgs);
                }
            }
            else {
                ShowText(player, type, doMsgs, "The doors remain open for you.");
                WallClear(player, type, doMsgs);
            }
        }
        protected override void FnEvent0F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, DWARFWIZARD);
            ShowText(player, type, doMsgs, "Xanith smiles as you draw near.");
            ShowText(player, type, doMsgs, "'I see you have mastered my riddles. To the west are some doors. Proceed alone through the door designated for your race.'");
            ShowText(player, type, doMsgs, "'You must use your tokens in the order you were told, lest dire consequences befall you!'");
        }
        protected override void FnEvent10(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Angel Fountain is in Cliffhanger. If true, continue south. If false, walk north.");
        }
        protected override void FnEvent11(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 5, 3, 47, Direction.North);
            ShowText(player, type, doMsgs, "To the Graveyard.");
        }
        protected override void FnEvent12(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "The Emerald Lockpick is exchanged for the Diamond Lockpick. If true, take the door to the south. If false, take the door to the east.");
        }
        protected override void FnEvent13(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.PATHWAYDONE) == 0)) {
                ShowPortrait(player, type, doMsgs, QUEENAEOWYN);
                ShowText(player, type, doMsgs, "Queen Aeowyn materializes in the room.");
                ShowText(player, type, doMsgs, "'Greetings, my Champion. Now we may bond these fragments together in this magical space.'");
                ShowText(player, type, doMsgs, "Aeowyn examines the pieces closely and then arranges them on the floor in a peculiar order.");
                ShowText(player, type, doMsgs, "'Ahh...look!' You watch as the tokens release their magical properties and fuse together the map pieces.");
                ShowText(player, type, doMsgs, "'Now, take this map and use it as the key through the northern gateway opposite the Night Elves' portal in the Main Entrance.");
                ShowText(player, type, doMsgs, "Fare thee well.' The Queen then vanishes.");
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.PATHWAYDONE, 1);
                RemoveItem(player, type, doMsgs, LEATHERMAP);
                RemoveItem(player, type, doMsgs, PARCHMENTMAP);
                RemoveItem(player, type, doMsgs, SLATEMAP);
                RemoveItem(player, type, doMsgs, SNAKESKINMAP);
                RemoveItem(player, type, doMsgs, CORAL);
                RemoveItem(player, type, doMsgs, EBONY);
                RemoveItem(player, type, doMsgs, OPAL);
                RemoveItem(player, type, doMsgs, PEARL);
                RemoveItem(player, type, doMsgs, TOPAZ);
                GiveItem(player, type, doMsgs, WHOLEMAP);
                ModifyExperience(player, type, doMsgs, 2500000);
            }
            else {
                ShowText(player, type, doMsgs, "A quiet breezes wafts through this area.");
            }
        }
        protected override void FnEvent14(TwPlayerServer player, MapEventType type, bool doMsgs) {
            DisableSpells(player, type, doMsgs);
            if (GetPartyCount(player, type, doMsgs) > 1) {
                int racecheck = 0;
                int tile = 0;
                racecheck = GetRace(player, type, doMsgs);
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
                ShowText(player, type, doMsgs, "You must enter here alone!");
                TeleportParty(player, type, doMsgs, 5, 2, tile, Direction.East);
            }
        }
        protected override void FnEvent15(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int itemA = 0;
            int itemB = SHORTSWORD;
            int itemC = 0;
            int itemD = 0;
            int itemE = UNITYRING;
            int tile = 0;
            if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.PATHWAYDONE) == 0)) {
                if (GetPartyCount(player, type, doMsgs) == 1 && GetRace(player, type, doMsgs) == ELF) {
                    tile = GetTile(player, type, doMsgs);
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
                    if (UsedItem(player, type, ref doMsgs, itemB, itemC) || UsedItem(player, type, ref doMsgs, itemD, itemE)) {
                        DamXit(player, type, doMsgs);
                    }
                    else if (UsedItem(player, type, ref doMsgs, itemA, itemA)) {
                        ClearWallBlock(player, type, doMsgs, tile, Direction.West);
                        SetWallItem(player, type, doMsgs, DOOR, tile, Direction.West);
                        ShowText(player, type, doMsgs, "You've unlocked this door!");
                        ShowText(player, type, doMsgs, "Proceed.");
                    }
                    else {
                        ShowText(player, type, doMsgs, "Use the correct token to unlock this door.");
                        WallBlock(player, type, doMsgs);
                    }
                }
                else {
                    ShowText(player, type, doMsgs, "'Fearless Elf, if you have read the secret clues, use your tokens as the keys.'");
                    WallBlock(player, type, doMsgs);
                }
            }
            else {
                ShowText(player, type, doMsgs, "The doors remain open for you.");
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
            if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.PATHWAYDONE) == 0)) {
                if (GetPartyCount(player, type, doMsgs) == 1 && GetRace(player, type, doMsgs) == DWARF) {
                    tile = GetTile(player, type, doMsgs);
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
                    if (UsedItem(player, type, ref doMsgs, itemB, itemC) || UsedItem(player, type, ref doMsgs, itemD, itemE)) {
                        DamXit(player, type, doMsgs);
                    }
                    else if (UsedItem(player, type, ref doMsgs, itemA, itemA)) {
                        ClearWallBlock(player, type, doMsgs, tile, Direction.West);
                        SetWallItem(player, type, doMsgs, DOOR, tile, Direction.West);
                        ShowText(player, type, doMsgs, "You've unlocked this door!");
                        ShowText(player, type, doMsgs, "Proceed.");
                    }
                    else {
                        ShowText(player, type, doMsgs, "Use the correct token to unlock this door.");
                        WallBlock(player, type, doMsgs);
                    }
                }
                else {
                    ShowText(player, type, doMsgs, "'Valiant Dwarf, if you have read the secret clues, use your tokens as the keys.'");
                    WallBlock(player, type, doMsgs);
                }
            }
            else {
                ShowText(player, type, doMsgs, "The doors remain open for you.");
                WallClear(player, type, doMsgs);
            }
        }
        protected override void FnEvent17(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 5, 3, 233, Direction.South);
            ShowText(player, type, doMsgs, "To the Graveyard.");
        }
        protected override void FnEvent18(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "The Vault is found in Twinion Keep. If true, continue east. If false, walk west.");
        }
        protected override void FnEvent19(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 5, 2, 151, Direction.North);
        }
        protected override void FnEvent1A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int itemA = 0;
            int itemB = SHORTSWORD;
            int itemC = 0;
            int itemD = 0;
            int itemE = UNITYRING;
            int tile = 0;
            if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.PATHWAYDONE) == 0)) {
                if (GetPartyCount(player, type, doMsgs) == 1 && GetRace(player, type, doMsgs) == GREMLIN) {
                    tile = GetTile(player, type, doMsgs);
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
                    if (UsedItem(player, type, ref doMsgs, itemB, itemC) || UsedItem(player, type, ref doMsgs, itemD, itemE)) {
                        DamXit(player, type, doMsgs);
                    }
                    else if (UsedItem(player, type, ref doMsgs, itemA, itemA)) {
                        ClearWallBlock(player, type, doMsgs, tile, Direction.West);
                        SetWallItem(player, type, doMsgs, DOOR, tile, Direction.West);
                        ShowText(player, type, doMsgs, "You've unlocked this door!");
                        ShowText(player, type, doMsgs, "Proceed.");
                    }
                    else {
                        ShowText(player, type, doMsgs, "Use the correct token to unlock this door.");
                        WallBlock(player, type, doMsgs);
                    }
                }
                else {
                    ShowText(player, type, doMsgs, "'Hardy Gremlin, if you have read the secret clues, use your tokens as the keys.'");
                    WallBlock(player, type, doMsgs);
                }
            }
            else {
                ShowText(player, type, doMsgs, "The doors remain open for you.");
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
            if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.PATHWAYDONE) == 0)) {
                if (GetPartyCount(player, type, doMsgs) == 1 && GetRace(player, type, doMsgs) == HUMAN) {
                    tile = GetTile(player, type, doMsgs);
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
                    if (UsedItem(player, type, ref doMsgs, itemB, itemC) || UsedItem(player, type, ref doMsgs, itemD, itemE)) {
                        DamXit(player, type, doMsgs);
                    }
                    else if (UsedItem(player, type, ref doMsgs, itemA, itemA)) {
                        ClearWallBlock(player, type, doMsgs, tile, Direction.West);
                        SetWallItem(player, type, doMsgs, DOOR, tile, Direction.West);
                        ShowText(player, type, doMsgs, "You've unlocked this door!");
                        ShowText(player, type, doMsgs, "Proceed.");
                    }
                    else {
                        ShowText(player, type, doMsgs, "Use the correct token to unlock this door.");
                        WallBlock(player, type, doMsgs);
                    }
                }
                else {
                    ShowText(player, type, doMsgs, "'Adventurous Human, if you have read the secret clues, use the tokens as the keys.'");
                    WallBlock(player, type, doMsgs);
                }
            }
            else {
                ShowText(player, type, doMsgs, "The doors remain open for you.");
                WallClear(player, type, doMsgs);
            }
        }
        protected override void FnEvent1C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "To go back and search for your clues, exit here.");
        }
        protected override void FnEvent1E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 5, 2, 33, Direction.North);
        }
        protected override void FnEvent23(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "The musty smell of old maps is overpowering. You sense your mana being leeched away.");
            ModifyMana(player, type, doMsgs,  - 200);
        }
        protected override void FnEvent28(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "The only way to Race Track is from Rat Race. If true, continue north. If false, walk east.");
        }
        protected override void FnEvent29(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 5, 2, 194, Direction.East);
        }
        protected override void FnEvent2A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 5, 2, 59, Direction.South);
        }
        protected override void FnEvent2F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Harmonics should visit the Tool Shed for a reward. If true, continue west. If false, walk east.");
        }
        protected override void FnEvent34(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Smug owns a Pawn Shop. If true, continue west. If false, walk south.");
        }
        protected override void FnEvent39(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "A book on the table reads, 'Futility is the price you pay for returning to the Cartography Shop ere you know the riddles' answers.'");
        }
        protected override void FnEvent3A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "A path of correct answers will lead you directly to the Cartographer.");
        }
        protected override void FnEvent3C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 5, 2, 45, Direction.South);
        }
        protected override void FnEvent3D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HasUsedSkill(player, type, ref doMsgs, DETECT_SKILL) >= 8 || HasUsedSpell(player, type, ref doMsgs, TRUE_SEEING_SPELL) >= 1 || UsedItem(player, type, ref doMsgs, HELMOFWISDOM, HELMOFWISDOM) || UsedItem(player, type, ref doMsgs, VALKYRIESHELM, VALKYRIESHELM) || UsedItem(player, type, ref doMsgs, RINGOFTHIEVES, RINGOFTHIEVES) || UsedItem(player, type, ref doMsgs, CRYSTALBALL, CRYSTALBALL)) {
                ShowText(player, type, doMsgs, "A secret door is revealed.");
                SetWallItem(player, type, doMsgs, DOOR, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                WallClear(player, type, doMsgs);
            }
            else {
                WallBlock(player, type, doMsgs);
            }
        }
        protected override void FnEvent3E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 5, 2, 35, Direction.West);
        }
        protected override void FnEvent3F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int itemA = 0;
            int race = 0;
            race = GetRace(player, type, doMsgs);
            switch (race) {
                case ORC:
                case TROLL:
                    itemA = CORAL;
                    break;
                default:
                    itemA = EBONY;
                    break;
            }
            if (HasItem(player, type, doMsgs, itemA) || GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.PATHWAYDONE) == 1) {
                ShowText(player, type, doMsgs, "Dabelais is not in his office.");
            }
            else {
                GiveItem(player, type, doMsgs, itemA);
                ShowPortrait(player, type, doMsgs, ELFCLERIC);
                ShowText(player, type, doMsgs, "Dabelais looks up and says, 'Accept this token as payment for showing me your map pieces.'");
            }
        }
        protected override void FnEvent41(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int itemA = 0;
            int race = 0;
            race = GetRace(player, type, doMsgs);
            switch (race) {
                case DWARF:
                case ELF:
                    itemA = CORAL;
                    break;
                default:
                    itemA = PEARL;
                    break;
            }
            if (HasItem(player, type, doMsgs, itemA) || GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.PATHWAYDONE) == 1) {
                ShowText(player, type, doMsgs, "Syrene is not in her office.");
            }
            else {
                ShowPortrait(player, type, doMsgs, ORCRANGER);
                GiveItem(player, type, doMsgs, itemA);
                ShowText(player, type, doMsgs, "Syrene greets you. 'Adventurers, I offer a token for a glance at your map pieces.'");
            }
        }
        protected override void FnEvent42(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Unity Fountain is found in Rat Race. If true, continue east. If false, walk west.");
        }
        protected override void FnEvent43(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Fellowship Fountain is found in the Armory. If true, continue south. If false, walk north.");
        }
        protected override void FnEvent44(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 5, 2, 15, Direction.South);
        }
        protected override void FnEvent45(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 5, 2, 88, Direction.South);
        }
        protected override void FnEvent46(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "To the Graveyard.");
            TeleportParty(player, type, doMsgs, 5, 3, 225, Direction.West);
        }
        protected override void FnEvent47(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, FOUNTAIN);
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.NSTAR) == 1) {
                ShowText(player, type, doMsgs, "The twinkling waters of NorthStar Fountain restore your mana.");
                ModifyMana(player, type, doMsgs, 10000);
            }
            else {
                ModifyMana(player, type, doMsgs, 10000);
                ModAttribute(player, type, doMsgs, INITIATIVE, 2);
                ModAttribute(player, type, doMsgs, STRENGTH, 1);
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.NSTAR, 1);
                ShowText(player, type, doMsgs, "The twinkling waters of NorthStar Fountain restore your mana and increase your Strength and Initiative.");
            }
        }
        protected override void FnEvent4B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 26);
                AddEncounter(player, type, doMsgs, 02, 31);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 27);
                AddEncounter(player, type, doMsgs, 02, 27);
                AddEncounter(player, type, doMsgs, 03, 31);
                AddEncounter(player, type, doMsgs, 06, 30);
            }
        }
        protected override void FnEvent4D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 6);
                AddEncounter(player, type, doMsgs, 02, 7);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 6);
                AddEncounter(player, type, doMsgs, 02, 6);
                AddEncounter(player, type, doMsgs, 03, 7);
                AddEncounter(player, type, doMsgs, 04, 40);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 9);
                AddEncounter(player, type, doMsgs, 02, 9);
                AddEncounter(player, type, doMsgs, 03, 25);
                AddEncounter(player, type, doMsgs, 04, 25);
                AddEncounter(player, type, doMsgs, 05, 11);
            }
        }
        protected override void FnEvent4F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 35);
                AddEncounter(player, type, doMsgs, 02, 27);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 35);
                AddEncounter(player, type, doMsgs, 02, 36);
                AddEncounter(player, type, doMsgs, 03, 28);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 35);
                AddEncounter(player, type, doMsgs, 02, 36);
                AddEncounter(player, type, doMsgs, 03, 29);
                AddEncounter(player, type, doMsgs, 04, 30);
            }
        }
        protected override void FnEvent50(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 6);
                AddEncounter(player, type, doMsgs, 02, 36);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 6);
                AddEncounter(player, type, doMsgs, 02, 5);
                AddEncounter(player, type, doMsgs, 03, 14);
                AddEncounter(player, type, doMsgs, 05, 32);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 8);
                AddEncounter(player, type, doMsgs, 02, 8);
                AddEncounter(player, type, doMsgs, 03, 25);
                AddEncounter(player, type, doMsgs, 04, 25);
                AddEncounter(player, type, doMsgs, 05, 32);
                AddEncounter(player, type, doMsgs, 06, 32);
            }
        }
        private void DamXit(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You failed to use the correct item.");
            DoDamage(player, type, doMsgs, GetHealthMax(player, type, doMsgs));
        }
        private void WallBlock(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
        }
        private void WallClear(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
        }
    }
}
