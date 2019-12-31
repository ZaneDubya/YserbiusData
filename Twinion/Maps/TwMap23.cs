using XPT.Generic.Maps;
using XPT.Twinion.Entities;

namespace XPT.Twinion.Maps {
    class TwMap23 : TwMap {
        protected override int MapIndex => 23;
        protected override int MapID => 0x0A01;
        protected override int RandomEncounterChance => 12;
        protected override int RandomEncounterExtraCount => 2;

        protected override void FnEvent01(TwPlayerServer player, MapEventType type, bool doMsgs) {
            CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
            PLACE_WALL_ITEM(player, type, doMsgs, PORTAL, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
        }
        protected override void FnEvent02(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                short picture = 0;
                short flagname = 0;
                short nextflag = 0;
                short tile = 0;
                tile = HERE(player, type, doMsgs);
                switch (tile) {
                    case 74:
                        picture = HUMANBARBARIAN;
                        flagname = LEARNEDGREMLIN;
                        nextflag = LEARNEDHUMAN;
                        SHOW_TEXT(player, type, doMsgs, "'Babble is surely what is to be had if you take the words at face value.");
                        SHOW_TEXT(player, type, doMsgs, "You now know the Common tongue.'");
                        break;
                    case 75:
                        picture = ORCRANGER;
                        flagname = LEARNEDGNOME;
                        nextflag = LEARNEDORC;
                        SHOW_TEXT(player, type, doMsgs, "'The letters are the keys; the switches set the words; you must spell inside the words.");
                        SHOW_TEXT(player, type, doMsgs, "You now know Orc.'");
                        break;
                    case 90:
                        picture = ELFBARBARIAN;
                        flagname = LEARNEDHUMAN;
                        nextflag = LEARNEDELF;
                        SHOW_TEXT(player, type, doMsgs, "'This mountain of lava sets one stage; the other has befriended thee.");
                        SHOW_TEXT(player, type, doMsgs, "You are now fluent with the Elven tongue.'");
                        break;
                    case 91:
                        picture = TROLLKNIGHT;
                        flagname = LEARNEDORC;
                        nextflag = LEARNEDTROLL;
                        SHOW_TEXT(player, type, doMsgs, "'Ignore the last till second; see the second first.");
                        SHOW_TEXT(player, type, doMsgs, "You are now the Troll language incarnate.'");
                        break;
                    case 106:
                        picture = DWARFWIZARD;
                        flagname = LEARNEDELF;
                        nextflag = LEARNEDDWARF;
                        SHOW_TEXT(player, type, doMsgs, "'With hallowed halls the dead king lies, his offspring now rules the mount.");
                        SHOW_TEXT(player, type, doMsgs, "You now know Dwarf.'");
                        break;
                    case 107:
                        picture = HALFLINGKNIGHT;
                        flagname = LEARNEDTROLL;
                        nextflag = LEARNEDHALF;
                        SHOW_TEXT(player, type, doMsgs, "'As the last, let the good Queen shine; in a second the lava spouts.");
                        SHOW_TEXT(player, type, doMsgs, "You are now able to mumble Halfling.'");
                        break;
                    case 122:
                        picture = GNOMEBARBARIAN;
                        flagname = LEARNEDDWARF;
                        nextflag = LEARNEDGNOME;
                        SHOW_TEXT(player, type, doMsgs, "'Read it friend, two names are there if only you can see the clues.");
                        SHOW_TEXT(player, type, doMsgs, "You now know Gnome.'");
                        break;
                    case 123:
                        picture = GREMLINTHIEF;
                        flagname = LEARNEDHALF;
                        nextflag = LEARNEDGREMLIN;
                        SHOW_TEXT(player, type, doMsgs, "'The King is dead; long live the Queen!");
                        SHOW_TEXT(player, type, doMsgs, "You now speak Gremlin - but only when you must.'");
                        break;
                }
                SHOW_PICTURE(player, type, doMsgs, picture);
                if (GET_FLAG(player, type, doMsgs, DUNGEON, flagname) == 1) {
                    if (!GET_FLAG(player, type, doMsgs, DUNGEON, nextflag)) {
                        SET_FLAG(player, type, doMsgs, DUNGEON, nextflag, 1);
                    }
                    SET_FLAG(player, type, doMsgs, DUNGEON, flagname, 2);
                }
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "You must enter the room alone.");
                TELEPORT(player, type, doMsgs, 10, 1, 120, WEST);
            }
        }
        protected override void FnEvent0A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 10, 1, 136, EAST);
        }
        protected override void FnEvent0B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Enter now the legacy of babel's nexus.");
            SET_FLAG(player, type, doMsgs, PARTY, FOTEREBUS, 1);
        }
        protected override void FnEvent0C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Back to the upper level.");
            TELEPORT(player, type, doMsgs, 9, 2, 120, WEST);
        }
        protected override void FnEvent0D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short picture = 0;
            short flagname = 0;
            short nextflag = 0;
            short tally = 0;
            tally = GET_FLAG(player, type, doMsgs, DUNGEON, LEARNEDHUMAN);
             + GET_FLAG(player, type, doMsgs, DUNGEON, LEARNEDDWARF);
             + GET_FLAG(player, type, doMsgs, DUNGEON, LEARNEDGNOME);
             + GET_FLAG(player, type, doMsgs, DUNGEON, LEARNEDGREMLIN);
             + GET_FLAG(player, type, doMsgs, DUNGEON, LEARNEDELF);
             + GET_FLAG(player, type, doMsgs, DUNGEON, LEARNEDTROLL);
             + GET_FLAG(player, type, doMsgs, DUNGEON, LEARNEDORC);
             + GET_FLAG(player, type, doMsgs, DUNGEON, LEARNEDHALF);
            switch (HERE(player, type, doMsgs)) {
                case 83:
                    picture = HUMANBARBARIAN;
                    flagname = LEARNEDHUMAN;
                    nextflag = LEARNEDELF;
                    SHOW_TEXT(player, type, doMsgs, "A Human is here.");
                    break;
                case 0:
                    picture = ORCRANGER;
                    flagname = LEARNEDORC;
                    nextflag = LEARNEDTROLL;
                    SHOW_TEXT(player, type, doMsgs, "An Orc is here.");
                    break;
                case 81:
                    picture = TROLLKNIGHT;
                    flagname = LEARNEDTROLL;
                    nextflag = LEARNEDHALF;
                    SHOW_TEXT(player, type, doMsgs, "A Troll is here.");
                    break;
                case 160:
                    picture = ELFBARBARIAN;
                    flagname = LEARNEDELF;
                    nextflag = LEARNEDDWARF;
                    SHOW_TEXT(player, type, doMsgs, "An Elf is here.");
                    break;
                case 133:
                    picture = HALFLINGKNIGHT;
                    flagname = LEARNEDHALF;
                    nextflag = LEARNEDGREMLIN;
                    SHOW_TEXT(player, type, doMsgs, "A Halfling is here.");
                    break;
                case 50:
                    picture = GREMLINTHIEF;
                    flagname = LEARNEDGREMLIN;
                    nextflag = LEARNEDHUMAN;
                    SHOW_TEXT(player, type, doMsgs, "A Gremlin is here.");
                    break;
                case 147:
                    picture = DWARFWIZARD;
                    flagname = LEARNEDDWARF;
                    nextflag = LEARNEDGNOME;
                    SHOW_TEXT(player, type, doMsgs, "A Dwarf Wizard is here.");
                    break;
                case 96:
                    picture = GNOMEBARBARIAN;
                    flagname = LEARNEDGNOME;
                    nextflag = LEARNEDORC;
                    SHOW_TEXT(player, type, doMsgs, "A Gnome is here.");
                    break;
            }
            SHOW_PICTURE(player, type, doMsgs, picture);
            if (tally == 16) {
                SHOW_TEXT(player, type, doMsgs, "'You know all that you need. Go to the northeast room. Find your fate and unlock the gate.'");
            }
            else if (FLAG_ON(player, type, doMsgs, DUNGEON, flagname)) {
                if (!GET_FLAG(player, type, doMsgs, DUNGEON, nextflag)) {
                    RaceText(player, type, doMsgs);
                    SHOW_TEXT(player, type, doMsgs, "lies the teleport that will take you to the next scholar. Go, it will now be unlocked.'");
                }
                else {
                    SHOW_TEXT(player, type, doMsgs, "'I can do nothing more for you. Learn all of the languages; then read the plaques in the northeast.'");
                }
            }
            else {
                switch (RACE(player, type, doMsgs)) {
                    case HUMAN:
                        SHOW_TEXT(player, type, doMsgs, "nemo me impune lacessit");
                        break;
                    case ELF:
                        SHOW_TEXT(player, type, doMsgs, "fortuna favet fortibus");
                        break;
                    case DWARF:
                        SHOW_TEXT(player, type, doMsgs, "vox populi, vox Dei");
                        break;
                    case TROLL:
                        SHOW_TEXT(player, type, doMsgs, "vox et praeterea nihil");
                        break;
                    case GNOME:
                        SHOW_TEXT(player, type, doMsgs, "quem Deus vult perdere, prius dementat");
                        break;
                    case HALFLING:
                        SHOW_TEXT(player, type, doMsgs, "lasciate ogni speranza");
                        break;
                    case ORC:
                        SHOW_TEXT(player, type, doMsgs, "finis coronat opus");
                        break;
                    case GREMLIN:
                        SHOW_TEXT(player, type, doMsgs, "flat justitia, ruat coelum");
                    }
                }
            }
            private void RaceText(TwPlayerServer player, MapEventType type, bool doMsgs) {
                switch (HERE(player, type, doMsgs)) {
                    case 83:
                        SHOW_TEXT(player, type, doMsgs, "'To the southeast ");
                        break;
                    case 0:
                        SHOW_TEXT(player, type, doMsgs, "'Go to the northeast ");
                        break;
                    case 81:
                        SHOW_TEXT(player, type, doMsgs, "'Somewhere in the center ");
                        break;
                    case 160:
                        SHOW_TEXT(player, type, doMsgs, "'Now, just south of the scholar's rooms ");
                        break;
                    case 133:
                        SHOW_TEXT(player, type, doMsgs, "'One south of where we are ");
                        break;
                    case 50:
                        SHOW_TEXT(player, type, doMsgs, "'At the southern edge ");
                        break;
                    case 147:
                        SHOW_TEXT(player, type, doMsgs, "'In the northwest ");
                        break;
                    case 96:
                        SHOW_TEXT(player, type, doMsgs, "'In the east ");
                        break;
                }
            }
            protected override void FnEvent15(TwPlayerServer player, MapEventType type, bool doMsgs) {
                short flagname = 0;
                short compass1 = 0;
                short compass2 = 0;
                short totile = 0;
                short tile = 0;
                tile = HERE(player, type, doMsgs);
                switch (tile) {
                    case 238:
                        flagname = LEARNEDHUMAN;
                        compass1 = WEST;
                        compass2 = WEST;
                        totile = 90;
                        SHOW_TEXT(player, type, doMsgs, "HUMAN");
                        break;
                    case 250:
                        flagname = LEARNEDGREMLIN;
                        compass1 = SOUTH;
                        compass2 = WEST;
                        totile = 74;
                        SHOW_TEXT(player, type, doMsgs, "GREMLIN");
                        break;
                    case 149:
                        flagname = LEARNEDHALF;
                        compass1 = EAST;
                        compass2 = EAST;
                        totile = 123;
                        SHOW_TEXT(player, type, doMsgs, "HALFLING");
                        break;
                    case 53:
                        flagname = LEARNEDDWARF;
                        compass1 = WEST;
                        compass2 = WEST;
                        totile = 122;
                        SHOW_TEXT(player, type, doMsgs, "DWARF");
                        break;
                    case 119:
                        flagname = LEARNEDTROLL;
                        compass1 = SOUTH;
                        compass2 = EAST;
                        totile = 107;
                        SHOW_TEXT(player, type, doMsgs, "TROLL");
                        break;
                    case 27:
                        flagname = LEARNEDORC;
                        compass1 = NORTH;
                        compass2 = EAST;
                        totile = 91;
                        SHOW_TEXT(player, type, doMsgs, "ORC");
                        break;
                    case 93:
                        flagname = LEARNEDGNOME;
                        compass1 = NORTH;
                        compass2 = EAST;
                        totile = 75;
                        SHOW_TEXT(player, type, doMsgs, "GNOME");
                        break;
                    case 139:
                        flagname = LEARNEDELF;
                        compass1 = SOUTH;
                        compass2 = WEST;
                        totile = 106;
                        SHOW_TEXT(player, type, doMsgs, "ELF");
                        break;
                }
                if (GET_FLAG(player, type, doMsgs, DUNGEON, flagname) == 1) {
                    PLACE_WALL_ITEM(player, type, doMsgs, GATEWAY, HERE(player, type, doMsgs), compass1);
                    SHOW_TEXT(player, type, doMsgs, "A gateway is here.");
                    TELEPORT(player, type, doMsgs, 10, 1, totile, compass2);
                }
                else {
                    SHOW_TEXT(player, type, doMsgs, "This portal will lead to the name marked upon it. Return once you are told by those that babble in the west.");
                    SHOW_TEXT(player, type, doMsgs, "At present, it will only take you to the heart of this maze.");
                    TELEPORT(player, type, doMsgs, 10, 1, 88, NORTH);
                }
            }
            protected override void FnEvent1D(TwPlayerServer player, MapEventType type, bool doMsgs) {
                if (GET_FLAG(player, type, doMsgs, DUNGEON, ENDGAMETELE) == 1) {
                    if (PARTY_COUNT(player, type, doMsgs) == 1) {
                        SHOW_TEXT(player, type, doMsgs, "This wall glows with power, beckoning you to enter.");
                        CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
                        TELEPORT(player, type, doMsgs, 10, 1, 22, NORTH);
                    }
                    else {
                        SHOW_TEXT(player, type, doMsgs, "Alone! You must use this gateway alone.");
                        TELEPORT(player, type, doMsgs, 10, 1, 184, EAST);
                    }
                }
            }
            protected override void FnEvent1E(TwPlayerServer player, MapEventType type, bool doMsgs) {
                if (GET_FLAG(player, type, doMsgs, DUNGEON, LEARNEDHUMAN) == 2) {
                    short switchA = 0;
                    short valueA = 0;
                    short valueB = 0;
                    switchA = GET_FLAG(player, type, doMsgs, PARTY, SWITCH30);
                    switch (switchA) {
                        case 1:
                            SHOW_TEXT(player, type, doMsgs, "EREBUS");
                            valueA = 1;
                            valueB = 0;
                            switchA = 2;
                            break;
                        case 2:
                            SHOW_TEXT(player, type, doMsgs, "MAGMA");
                            valueA = 0;
                            valueB = 1;
                            switchA = 3;
                            break;
                        default:
                            OffText(player, type, doMsgs);
                            valueA = 0;
                            valueB = 0;
                            switchA = 1;
                            break;
                    }
                    SET_FLAG(player, type, doMsgs, PARTY, EREBUSW, valueA);
                    SET_FLAG(player, type, doMsgs, PARTY, MAGMAW, valueB);
                    SET_FLAG(player, type, doMsgs, PARTY, SWITCH30, switchA);
                }
                else {
                    SHOW_TEXT(player, type, doMsgs, "sculpsit");
                }
            }
            protected override void FnEvent1F(TwPlayerServer player, MapEventType type, bool doMsgs) {
                if (GET_FLAG(player, type, doMsgs, DUNGEON, LEARNEDHALF) == 2) {
                    short switchA = 0;
                    short valueA = 0;
                    short valueB = 0;
                    switchA = GET_FLAG(player, type, doMsgs, PARTY, SWITCH31);
                    switch (switchA) {
                        case 1:
                            SHOW_TEXT(player, type, doMsgs, "ASP");
                            valueA = 1;
                            valueB = 0;
                            switchA++;
                            break;
                        case 2:
                            SHOW_TEXT(player, type, doMsgs, "LONGBOW");
                            valueA = 0;
                            valueB = 1;
                            switchA++;
                            break;
                        default:
                            OffText(player, type, doMsgs);
                            valueA = 0;
                            valueB = 0;
                            switchA = 1;
                            break;
                    }
                    SET_FLAG(player, type, doMsgs, PARTY, ASPW, valueA);
                    SET_FLAG(player, type, doMsgs, PARTY, LONGBOWW, valueB);
                    SET_FLAG(player, type, doMsgs, PARTY, SWITCH31, switchA);
                }
                else {
                    SHOW_TEXT(player, type, doMsgs, "tant mieux");
                }
            }
            protected override void FnEvent20(TwPlayerServer player, MapEventType type, bool doMsgs) {
                if (GET_FLAG(player, type, doMsgs, DUNGEON, LEARNEDDWARF) == 2) {
                    short switchA = 0;
                    short valueA = 0;
                    short valueB = 0;
                    switchA = GET_FLAG(player, type, doMsgs, PARTY, SWITCH32);
                    switch (switchA) {
                        case 1:
                            SHOW_TEXT(player, type, doMsgs, "ELEMENTAL");
                            valueA = 1;
                            valueB = 0;
                            switchA++;
                            break;
                        case 2:
                            SHOW_TEXT(player, type, doMsgs, "ISLAND");
                            valueA = 0;
                            valueB = 1;
                            switchA++;
                            break;
                        default:
                            OffText(player, type, doMsgs);
                            valueA = 0;
                            valueB = 0;
                            switchA = 1;
                            break;
                    }
                    SET_FLAG(player, type, doMsgs, PARTY, ELEMENTALW, valueA);
                    SET_FLAG(player, type, doMsgs, PARTY, ISLANDW, valueB);
                    SET_FLAG(player, type, doMsgs, PARTY, SWITCH32, switchA);
                }
                else {
                    SHOW_TEXT(player, type, doMsgs, "obiit");
                }
            }
            protected override void FnEvent21(TwPlayerServer player, MapEventType type, bool doMsgs) {
                if (GET_FLAG(player, type, doMsgs, DUNGEON, LEARNEDGNOME) == 2) {
                    short switchA = 0;
                    short valueA = 0;
                    short valueB = 0;
                    switchA = GET_FLAG(player, type, doMsgs, PARTY, SWITCH33);
                    switch (switchA) {
                        case 1:
                            SHOW_TEXT(player, type, doMsgs, "HARMONY");
                            valueA = 1;
                            valueB = 0;
                            switchA++;
                            break;
                        case 2:
                            SHOW_TEXT(player, type, doMsgs, "GUILD");
                            valueA = 0;
                            valueB = 1;
                            switchA++;
                            break;
                        default:
                            OffText(player, type, doMsgs);
                            valueA = 0;
                            valueB = 0;
                            switchA = 1;
                            break;
                    }
                    SET_FLAG(player, type, doMsgs, PARTY, HARMONYW, valueA);
                    SET_FLAG(player, type, doMsgs, PARTY, GUILDW, valueB);
                    SET_FLAG(player, type, doMsgs, PARTY, SWITCH33, switchA);
                }
                else {
                    SHOW_TEXT(player, type, doMsgs, "peccavi");
                }
            }
            protected override void FnEvent22(TwPlayerServer player, MapEventType type, bool doMsgs) {
                if (GET_FLAG(player, type, doMsgs, DUNGEON, LEARNEDGREMLIN) == 2) {
                    short switchA = 0;
                    short valueA = 0;
                    short valueB = 0;
                    switchA = GET_FLAG(player, type, doMsgs, PARTY, SWITCH34);
                    switch (switchA) {
                        case 1:
                            SHOW_TEXT(player, type, doMsgs, "CHAOTIC");
                            valueA = 1;
                            valueB = 0;
                            switchA++;
                            break;
                        case 2:
                            SHOW_TEXT(player, type, doMsgs, "MYTH");
                            valueA = 0;
                            valueB = 1;
                            switchA++;
                            break;
                        default:
                            OffText(player, type, doMsgs);
                            valueA = 0;
                            valueB = 0;
                            switchA = 1;
                            break;
                    }
                    SET_FLAG(player, type, doMsgs, PARTY, CHAOTICW, valueA);
                    SET_FLAG(player, type, doMsgs, PARTY, MYTHW, valueB);
                    SET_FLAG(player, type, doMsgs, PARTY, SWITCH34, switchA);
                }
                else {
                    SHOW_TEXT(player, type, doMsgs, "l'onconnu");
                }
            }
            protected override void FnEvent23(TwPlayerServer player, MapEventType type, bool doMsgs) {
                if (GET_FLAG(player, type, doMsgs, DUNGEON, LEARNEDORC) == 2) {
                    short switchA = 0;
                    short valueA = 0;
                    short valueB = 0;
                    switchA = GET_FLAG(player, type, doMsgs, PARTY, SWITCH35);
                    switch (switchA) {
                        case 1:
                            SHOW_TEXT(player, type, doMsgs, "VOLCANO");
                            valueA = 1;
                            valueB = 0;
                            switchA++;
                            break;
                        case 2:
                            SHOW_TEXT(player, type, doMsgs, "ABYSS");
                            valueA = 0;
                            valueB = 1;
                            switchA++;
                            break;
                        default:
                            OffText(player, type, doMsgs);
                            valueA = 0;
                            valueB = 0;
                            switchA = 1;
                            break;
                    }
                    SET_FLAG(player, type, doMsgs, PARTY, VOLCANOW, valueA);
                    SET_FLAG(player, type, doMsgs, PARTY, ABYSSW, valueB);
                    SET_FLAG(player, type, doMsgs, PARTY, SWITCH35, switchA);
                }
                else {
                    SHOW_TEXT(player, type, doMsgs, "fiat lux");
                }
            }
            protected override void FnEvent24(TwPlayerServer player, MapEventType type, bool doMsgs) {
                if (GET_FLAG(player, type, doMsgs, DUNGEON, LEARNEDTROLL) == 2) {
                    short switchA = 0;
                    short valueA = 0;
                    short valueB = 0;
                    switchA = GET_FLAG(player, type, doMsgs, PARTY, SWITCH36);
                    switch (switchA) {
                        case 1:
                            SHOW_TEXT(player, type, doMsgs, "TWINION");
                            valueA = 1;
                            valueB = 0;
                            switchA++;
                            break;
                        case 2:
                            SHOW_TEXT(player, type, doMsgs, "LEGEND");
                            valueA = 0;
                            valueB = 1;
                            switchA++;
                            break;
                        default:
                            OffText(player, type, doMsgs);
                            valueA = 0;
                            valueB = 0;
                            switchA = 1;
                            break;
                    }
                    SET_FLAG(player, type, doMsgs, PARTY, TWINIONW, valueA);
                    SET_FLAG(player, type, doMsgs, PARTY, LEGENDW, valueB);
                    SET_FLAG(player, type, doMsgs, PARTY, SWITCH36, switchA);
                }
                else {
                    SHOW_TEXT(player, type, doMsgs, "a priori");
                }
            }
            protected override void FnEvent25(TwPlayerServer player, MapEventType type, bool doMsgs) {
                if (GET_FLAG(player, type, doMsgs, DUNGEON, LEARNEDELF) == 2) {
                    short switchA = 0;
                    short valueA = 0;
                    short valueB = 0;
                    switchA = GET_FLAG(player, type, doMsgs, PARTY, SWITCH37);
                    switch (switchA) {
                        case 1:
                            SHOW_TEXT(player, type, doMsgs, "WIZARD");
                            valueA = 1;
                            valueB = 0;
                            switchA++;
                            break;
                        case 2:
                            SHOW_TEXT(player, type, doMsgs, "PALACE");
                            valueA = 0;
                            valueB = 1;
                            switchA++;
                            break;
                        default:
                            OffText(player, type, doMsgs);
                            valueA = 0;
                            valueB = 0;
                            switchA = 1;
                            break;
                    }
                    SET_FLAG(player, type, doMsgs, PARTY, WIZARDW, valueA);
                    SET_FLAG(player, type, doMsgs, PARTY, PALACEW, valueB);
                    SET_FLAG(player, type, doMsgs, PARTY, SWITCH37, switchA);
                }
                else {
                    SHOW_TEXT(player, type, doMsgs, "ad finem");
                }
            }
            private void OffText(TwPlayerServer player, MapEventType type, bool doMsgs) {
                SHOW_TEXT(player, type, doMsgs, "-OFF-");
            }
            protected override void FnEvent26(TwPlayerServer player, MapEventType type, bool doMsgs) {
                if (!GET_FLAG(player, type, doMsgs, DUNGEON, SPELLEDBOTH)) {
                    short i = 0;
                    short word = 0;
                    short valueA = 0;
                    short valueB = 0;
                    word = GET_FLAG(player, type, doMsgs, DUNGEON, SPELLINGWORD);
                    if (word == 0) {
                        word = 1;
                    }
                    switch (word) {
                        case 2:
                            valueB = GET_FLAG(player, type, doMsgs, PARTY, ELEMENTALW);
                             + GET_FLAG(player, type, doMsgs, PARTY, CHAOTICW);
                             + GET_FLAG(player, type, doMsgs, PARTY, MAGMAW);
                             + GET_FLAG(player, type, doMsgs, PARTY, PALACEW);
                             + GET_FLAG(player, type, doMsgs, PARTY, VOLCANOW);
                             + GET_FLAG(player, type, doMsgs, PARTY, LONGBOWW);
                             + GET_FLAG(player, type, doMsgs, PARTY, HARMONYW);
                             + GET_FLAG(player, type, doMsgs, PARTY, TWINIONW);
                            if (valueB == 6) {
                                SHOW_TEXT(player, type, doMsgs, "Your experience increases along with your gold and your strength!");
                                MOD_GOLD(player, type, doMsgs, 250000);
                                MOD_STAT(player, type, doMsgs, STRENGTH, 3);
                                MOD_EXP(player, type, doMsgs, 750000);
                                SET_FLAG(player, type, doMsgs, DUNGEON, SPELLINGWORD, 3);
                                SET_FLAG(player, type, doMsgs, DUNGEON, SPELLEDBOTH, 1);
                                PLACE_FLOOR_ITEM(player, type, doMsgs, PIT, 11);
                                for (i = 39; i <= 46; i++) {
                                    SET_FLAG(player, type, doMsgs, DUNGEON, i, 4);
                                }
                                for (i = 23; i <= 31; i++) {
                                    REMOVE_WALL_ITEM(player, type, doMsgs, i, SOUTH);
                                }
                                SpelledEm(player, type, doMsgs);
                            }
                            else {
                                NadaQue(player, type, doMsgs);
                            }
                            break;
                        case 1:
                            valueA = GET_FLAG(player, type, doMsgs, PARTY, MYTHW);
                             + GET_FLAG(player, type, doMsgs, PARTY, ISLANDW);
                             + GET_FLAG(player, type, doMsgs, PARTY, LEGENDW);
                             + GET_FLAG(player, type, doMsgs, PARTY, EREBUSW);
                             + GET_FLAG(player, type, doMsgs, PARTY, ABYSSW);
                             + GET_FLAG(player, type, doMsgs, PARTY, WIZARDW);
                             + GET_FLAG(player, type, doMsgs, PARTY, GUILDW);
                             + GET_FLAG(player, type, doMsgs, PARTY, ASPW);
                            if (valueA == 8) {
                                SHOW_TEXT(player, type, doMsgs, "You've set the first word. On to the next. Here's a taste of experience, gold and a little initiative!");
                                MOD_STAT(player, type, doMsgs, INITIATIVE, 3);
                                MOD_GOLD(player, type, doMsgs, 175000);
                                MOD_EXP(player, type, doMsgs, 700000);
                                SET_FLAG(player, type, doMsgs, DUNGEON, SPELLINGWORD, 2);
                            }
                            else {
                                NadaQue(player, type, doMsgs);
                            }
                            break;
                    }
                }
                else {
                    SpelledEm(player, type, doMsgs);
                }
            }
            private void SpelledEm(TwPlayerServer player, MapEventType type, bool doMsgs) {
                SHOW_TEXT(player, type, doMsgs, "You've spelled the words. Now through the exit and onward to your Fate!");
            }
            private void NadaQue(TwPlayerServer player, MapEventType type, bool doMsgs) {
                SHOW_TEXT(player, type, doMsgs, "Nothing happens.");
            }
            protected override void FnEvent27(TwPlayerServer player, MapEventType type, bool doMsgs) {
                if (GET_FLAG(player, type, doMsgs, DUNGEON, SPELLEDBOTH) == 1) {
                    if (PARTY_COUNT(player, type, doMsgs) == 1) {
                        SHOW_TEXT(player, type, doMsgs, "The magical winds sweep you up and pull you down through the opening into Concordia.");
                        TELEPORT(player, type, doMsgs, 10, 2, 225, EAST);
                    }
                    else {
                        SHOW_TEXT(player, type, doMsgs, "You may enter only if alone!");
                        PLACE_FLOOR_ITEM(player, type, doMsgs, NO_OBJECT, 11);
                    }
                }
                else {
                    PLACE_FLOOR_ITEM(player, type, doMsgs, NO_OBJECT, 11);
                }
            }
            protected override void FnEvent28(TwPlayerServer player, MapEventType type, bool doMsgs) {
                short i = 0;
                if (!GET_FLAG(player, type, doMsgs, DUNGEON, KNOWSALL)) {
                    if (PARTY_COUNT(player, type, doMsgs) != 1) {
                        SHOW_TEXT(player, type, doMsgs, "Only alone may you pass through.");
                        TELEPORT(player, type, doMsgs, 10, 1, 6, EAST);
                    }
                    else if (GET_FLAG(player, type, doMsgs, DUNGEON, SPELLEDBOTH) == 1) {
                        SHOW_TEXT(player, type, doMsgs, "You have already solved this puzzle!");
                        SHOW_TEXT(player, type, doMsgs, "Proceed to your exit.");
                        PLACE_FLOOR_ITEM(player, type, doMsgs, PIT, 11);
                        for (i = 23; i <= 31; i++) {
                            REMOVE_WALL_ITEM(player, type, doMsgs, i, SOUTH);
                        }
                    }
                    else {
                        short flagcount = 0;
                        flagcount = GET_FLAG(player, type, doMsgs, DUNGEON, LEARNEDHUMAN);
                         + GET_FLAG(player, type, doMsgs, DUNGEON, LEARNEDGNOME);
                         + GET_FLAG(player, type, doMsgs, DUNGEON, LEARNEDHALF);
                         + GET_FLAG(player, type, doMsgs, DUNGEON, LEARNEDTROLL);
                         + GET_FLAG(player, type, doMsgs, DUNGEON, LEARNEDORC);
                         + GET_FLAG(player, type, doMsgs, DUNGEON, LEARNEDGREMLIN);
                         + GET_FLAG(player, type, doMsgs, DUNGEON, LEARNEDELF);
                         + GET_FLAG(player, type, doMsgs, DUNGEON, LEARNEDDWARF);
                        if ((flagcount == 16) || (GET_FLAG(player, type, doMsgs, DUNGEON, KNOWSALL) == 1)) {
                            if (!GET_FLAG(player, type, doMsgs, DUNGEON, KNOWSALL)) {
                                SET_FLAG(player, type, doMsgs, DUNGEON, KNOWSALL, 1);
                            }
                            SHOW_TEXT(player, type, doMsgs, "You have proven your knowledge of the major languages. Now read the plaques and set the switches. Then you may proceed.");
                        }
                        else {
                            SHOW_TEXT(player, type, doMsgs, "You need to learn more about languages before you can tackle this puzzle.");
                        }
                    }
                }
            }
            protected override void FnEvent29(TwPlayerServer player, MapEventType type, bool doMsgs) {
                if (!GET_FLAG(player, type, doMsgs, PARTY, SEENWRAITH)) {
                    SHOW_PICTURE(player, type, doMsgs, WRAITH);
                    SHOW_TEXT(player, type, doMsgs, "'Beware! Beware! The traps here are of fiendish conception! They change whence you step them again although they are the same tile! Beware!'");
                    SET_FLAG(player, type, doMsgs, PARTY, SEENWRAITH, 1);
                }
            }
            protected override void FnEvent2A(TwPlayerServer player, MapEventType type, bool doMsgs) {
                short i = 0;
                short pl = 0;
                if (PARTY_LEVEL(player, type, doMsgs, 35)) {
                    pl = 1;
                }
                SHOW_TEXT(player, type, doMsgs, "Night Elf berserkers scream wildly as they attack.");
                if (HAS_ITEM(player, type, doMsgs, BLACKBLADE)) {
                    SET_BOOTY(player, type, doMsgs, ELIXIROFHEALTH, NIGHTELFHELM, 0, 0, 0, 1000);
                }
                else {
                    SET_BOOTY(player, type, doMsgs, BLACKBLADE, 0, 0, 0, 0, 1500);
                }
                switch (pl) {
                    case 1:
                        for (i = 1; i <= 2; i++) {
                            GET_MONSTER(player, type, doMsgs, i, 36);
                        }
                        for (i = 5; i <= 6; i++) {
                            GET_MONSTER(player, type, doMsgs, i, 37);
                        }
                        break;
                    default:
                        for (i = 1; i <= 2; i++) {
                            GET_MONSTER(player, type, doMsgs, i, 36);
                        }
                        for (i = 5; i <= 6; i++) {
                            GET_MONSTER(player, type, doMsgs, i, 37);
                        }
                        break;
                }
            }
            protected override void FnEvent2B(TwPlayerServer player, MapEventType type, bool doMsgs) {
                if (!GET_FLAG(player, type, doMsgs, PARTY, FOTEREBUS)) {
                    short i = 0;
                    SHOW_TEXT(player, type, doMsgs, "Two Erebus fiends hiss as you approach.");
                    for (i = 1; i <= 2; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 40);
                    }
                }
            }
            protected override void FnEvent2C(TwPlayerServer player, MapEventType type, bool doMsgs) {
                short i = 0;
                SHOW_TEXT(player, type, doMsgs, "Hulking Kaalroths launch a fierce magical attack.");
                switch (PARTY_COUNT(player, type, doMsgs)) {
                    case 1:
                        for (i = 1; i <= 2; i++) {
                            GET_MONSTER(player, type, doMsgs, i, 28);
                        }
                        break;
                    case 2:
                        for (i = 1; i <= 3; i++) {
                            GET_MONSTER(player, type, doMsgs, i, 28);
                        }
                        break;
                    default:
                        for (i = 1; i <= 4; i++) {
                            GET_MONSTER(player, type, doMsgs, i, 28);
                        }
                        for (i = 5; i <= 6; i++) {
                            GET_MONSTER(player, type, doMsgs, i, 29);
                        }
                        break;
                }
            }
            protected override void FnEvent2D(TwPlayerServer player, MapEventType type, bool doMsgs) {
                short i = 0;
                SHOW_TEXT(player, type, doMsgs, "'You've slain many of our friends. It is your time now!'");
                for (i = 1; i <= 2; i++) {
                    GET_MONSTER(player, type, doMsgs, i, 26);
                }
            }
            protected override void FnEvent2E(TwPlayerServer player, MapEventType type, bool doMsgs) {
                short i = 0;
                if (GET_FLAG(player, type, doMsgs, PARTY, MIXEDONE) == 2) {
                    SHOW_TEXT(player, type, doMsgs, "Wizards and their servants are tending the fallen Golems you killed!");
                    switch (PARTY_COUNT(player, type, doMsgs)) {
                        case 1:
                            GET_MONSTER(player, type, doMsgs, 1, 25);
                            for (i = 5; i <= 6; i++) {
                                GET_MONSTER(player, type, doMsgs, i, 30);
                            }
                            break;
                        case 2:
                            for (i = 1; i <= 2; i++) {
                                GET_MONSTER(player, type, doMsgs, i, 25);
                            }
                            for (i = 5; i <= 6; i++) {
                                GET_MONSTER(player, type, doMsgs, i, 30);
                            }
                            break;
                        default:
                            for (i = 1; i <= 4; i++) {
                                GET_MONSTER(player, type, doMsgs, i, 25);
                            }
                            for (i = 5; i <= 6; i++) {
                                GET_MONSTER(player, type, doMsgs, i, 30);
                            }
                            break;
                    }
                }
                else if (GET_FLAG(player, type, doMsgs, PARTY, MIXEDONE) == 1) {
                    SHOW_TEXT(player, type, doMsgs, "Huge golems lumber forward to block your path.");
                    for (i = 1; i <= 3; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 25);
                    }
                }
                else {
                    SHOW_TEXT(player, type, doMsgs, "The floor here shows traces of recent activity by huge creatures.");
                    SET_FLAG(player, type, doMsgs, PARTY, MIXEDONE, 1);
                }
            }
            protected override void FnEvent2F(TwPlayerServer player, MapEventType type, bool doMsgs) {
                if (GET_FLAG(player, type, doMsgs, DUNGEON, LEARNEDELF) == 1) {
                    SHOW_TEXT(player, type, doMsgs, "An eerie sense of magic surrounds you.");
                    SHOW_TEXT(player, type, doMsgs, "Something is different! You'd better check this area again.");
                }
            }
            protected override void FnEvent30(TwPlayerServer player, MapEventType type, bool doMsgs) {
                short i = 0;
                SHOW_TEXT(player, type, doMsgs, "A horde of Golems stir to life as they sense your approach!");
                for (i = 1; i <= 4; i++) {
                    GET_MONSTER(player, type, doMsgs, i, 31);
                }
            }
            protected override void FnEvent31(TwPlayerServer player, MapEventType type, bool doMsgs) {
                short i = 0;
                SHOW_TEXT(player, type, doMsgs, "Babbling rogues, driven mad from their quests, see you as their next prey.");
                switch (PARTY_COUNT(player, type, doMsgs)) {
                    case 1:
                        GET_MONSTER(player, type, doMsgs, 1, 32);
                        GET_MONSTER(player, type, doMsgs, 2, 33);
                        break;
                    case 2:
                        for (i = 1; i <= 2; i++) {
                            GET_MONSTER(player, type, doMsgs, i, 32);
                        }
                        for (i = 5; i <= 6; i++) {
                            GET_MONSTER(player, type, doMsgs, i, 33);
                        }
                        break;
                    default:
                        for (i = 1; i <= 4; i++) {
                            GET_MONSTER(player, type, doMsgs, i, 32);
                        }
                        for (i = 5; i <= 6; i++) {
                            GET_MONSTER(player, type, doMsgs, i, 33);
                        }
                        break;
                }
            }
            protected override void FnEvent32(TwPlayerServer player, MapEventType type, bool doMsgs) {
                short i = 0;
                if (GET_FLAG(player, type, doMsgs, PARTY, ROGUES) == 1) {
                    SHOW_TEXT(player, type, doMsgs, "'OUT! Keep out of our domain!'");
                    switch (PARTY_COUNT(player, type, doMsgs)) {
                        case 1:
                            for (i = 1; i <= 2; i++) {
                                GET_MONSTER(player, type, doMsgs, i, 34);
                            }
                            break;
                        case 2:
                            for (i = 1; i <= 4; i++) {
                                GET_MONSTER(player, type, doMsgs, i, 34);
                            }
                            break;
                        default:
                            for (i = 1; i <= 6; i++) {
                                GET_MONSTER(player, type, doMsgs, i, 34);
                            }
                            break;
                    }
                }
                else {
                    SHOW_PICTURE(player, type, doMsgs, NIGHTELFWARRIOR);
                    SHOW_TEXT(player, type, doMsgs, "A Night Elf warrior holds his forces at the ready.");
                    SHOW_TEXT(player, type, doMsgs, "'Leave this place and do not return. Abandon your quest for our Dralkarians.");
                    SHOW_TEXT(player, type, doMsgs, "This shall be your only warning.'");
                    SET_FLAG(player, type, doMsgs, PARTY, ROGUES, 1);
                }
            }
            protected override void FnEvent33(TwPlayerServer player, MapEventType type, bool doMsgs) {
                short i = 0;
                SHOW_TEXT(player, type, doMsgs, "More Night Elves have been called to defend their domain.");
                switch (PARTY_COUNT(player, type, doMsgs)) {
                    case 1:
                        for (i = 1; i <= 2; i++) {
                            GET_MONSTER(player, type, doMsgs, i, 35);
                        }
                        break;
                    case 2:
                        for (i = 1; i <= 4; i++) {
                            GET_MONSTER(player, type, doMsgs, i, 35);
                        }
                        break;
                    default:
                        for (i = 1; i <= 6; i++) {
                            GET_MONSTER(player, type, doMsgs, i, 35);
                        }
                        break;
                }
            }
            protected override void FnEvent34(TwPlayerServer player, MapEventType type, bool doMsgs) {
                SHOW_TEXT(player, type, doMsgs, "Babbling creatures begin feuding and draw you into their fray.");
                GET_MONSTER(player, type, doMsgs, 01, 37);
                GET_MONSTER(player, type, doMsgs, 02, 38);
            }
            protected override void FnEvent35(TwPlayerServer player, MapEventType type, bool doMsgs) {
                short i = 0;
                SHOW_TEXT(player, type, doMsgs, "A slew of bats rush through this hallway.");
                switch (PARTY_COUNT(player, type, doMsgs)) {
                    case 1:
                        for (i = 1; i <= 2; i++) {
                            GET_MONSTER(player, type, doMsgs, i, 39);
                        }
                        break;
                    case 2:
                        for (i = 1; i <= 4; i++) {
                            GET_MONSTER(player, type, doMsgs, i, 39);
                        }
                        break;
                    default:
                        for (i = 1; i <= 6; i++) {
                            GET_MONSTER(player, type, doMsgs, i, 39);
                        }
                        break;
                }
            }
            protected override void FnEvent36(TwPlayerServer player, MapEventType type, bool doMsgs) {
                short trap = 0;
                short item = 0;
                trap = GET_FLAG(player, type, doMsgs, PARTY, CASETRAP);
                if (!GET_FLAG(player, type, doMsgs, ROOM, SPRUNGTRAP)) {
                    switch (trap) {
                        case 1:
                            DAMAGE(player, type, doMsgs, HEALTH(player, type, doMsgs) / 6);
                            SET_PM(player, type, doMsgs, POISON, 15, 100);
                            NO_SPELL(player, type, doMsgs);
                            SHOW_TEXT(player, type, doMsgs, "You spring a trap laced with poisoned darts.");
                            trap++;
                            break;
                        case 2:
                            DAMAGE(player, type, doMsgs, HEALTH(player, type, doMsgs) / 5);
                            SHOW_TEXT(player, type, doMsgs, "You trigger some mage's trap. A cloud of acid surrounds you!!");
                            MOD_GOLD(player, type, doMsgs,  - 2000);
                            trap++;
                            break;
                        case 3:
                            DAMAGE(player, type, doMsgs, HEALTH(player, type, doMsgs) / 4);
                            SHOW_TEXT(player, type, doMsgs, "Fireballs slam into you as you set off another fiendish trap.");
                            trap++;
                            break;
                        case 4:
                            SET_PM(player, type, doMsgs, POISON, 15, 200);
                            MOD_MANA(player, type, doMsgs,  - 500);
                            while (HAS_ITEM(player, type, doMsgs, CURATIVEELIXIR))
                                TAKE_ITEM(player, type, doMsgs, CURATIVEELIXIR);
                                SHOW_TEXT(player, type, doMsgs, "You clumsily set off a gas trap.");
                                trap++;
                                break;
                            default:
                                DAMAGE(player, type, doMsgs, MAX_HEALTH(player, type, doMsgs) / 5);
                                NO_HEAL_ZONE(player, type, doMsgs);
                                trap = 1;
                                NO_SPELL(player, type, doMsgs);
                                SHOW_TEXT(player, type, doMsgs, "A fierce whirlwind strikes you from some unseen sorcerer's hand!");
                                break;
                        }
                        SET_FLAG(player, type, doMsgs, PARTY, CASETRAP, trap);
                        SET_FLAG(player, type, doMsgs, ROOM, SPRUNGTRAP, 1);
                        SET_FLAG(player, type, doMsgs, PARTY, FOTEREBUS, 0);
                    }
                }
                protected override void FnEvent37(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    short i = 0;
                    SHOW_TEXT(player, type, doMsgs, "Well-trained Night Elves guard these corridors.");
                    switch (PARTY_COUNT(player, type, doMsgs)) {
                        case 1:
                            for (i = 1; i <= 3; i++) {
                                GET_MONSTER(player, type, doMsgs, i, 34);
                            }
                            break;
                        case 2:
                            for (i = 1; i <= 2; i++) {
                                GET_MONSTER(player, type, doMsgs, i, 34);
                            }
                            for (i = 5; i <= 6; i++) {
                                GET_MONSTER(player, type, doMsgs, i, 34);
                            }
                            break;
                        default:
                            for (i = 1; i <= 6; i++) {
                                GET_MONSTER(player, type, doMsgs, i, 34);
                            }
                            break;
                    }
                }
                protected override void FnEvent38(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    SHOW_PICTURE(player, type, doMsgs, DWARFKNIGHT);
                    SHOW_TEXT(player, type, doMsgs, "An ancient Knight whispers, 'The leader must be removed to see the summit. And even though the spells of royalty be at the end, they shall be the first.'");
                }
                protected override void FnEvent39(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    SHOW_PICTURE(player, type, doMsgs, ORCRANGER);
                    SHOW_TEXT(player, type, doMsgs, "'The nine switches are used to open the way down to the next area. You must learn which switches to turn on.");
                    SHOW_TEXT(player, type, doMsgs, "Having the nine switches set in unison will unlock the way for you.'");
                }
                protected override void FnEvent3A(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    SHOW_PICTURE(player, type, doMsgs, FOUNTAIN);
                    SHOW_TEXT(player, type, doMsgs, "The cool waters satisfy and enrich you.");
                    HEAL(player, type, doMsgs, MAX_HEALTH(player, type, doMsgs));
                    MOD_MANA(player, type, doMsgs, 2500);
                }
                protected override void FnEvent3B(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    short flag = 0;
                    short racecheck = 0;
                    racecheck = RACE(player, type, doMsgs);
                    switch (racecheck) {
                        case HUMAN:
                            flag = LEARNEDHUMAN;
                            break;
                        case ELF:
                            flag = LEARNEDELF;
                            break;
                        case DWARF:
                            flag = LEARNEDDWARF;
                            break;
                        case GNOME:
                            flag = LEARNEDGNOME;
                            break;
                        case ORC:
                            flag = LEARNEDORC;
                            break;
                        case TROLL:
                            flag = LEARNEDTROLL;
                            break;
                        case HALFLING:
                            flag = LEARNEDHALF;
                            break;
                        case GREMLIN:
                            flag = LEARNEDGREMLIN;
                            break;
                    }
                    if (!GET_FLAG(player, type, doMsgs, DUNGEON, flag)) {
                        SET_FLAG(player, type, doMsgs, DUNGEON, flag, 1);
                    }
                    if (HAS_ITEM(player, type, doMsgs, JESTERSCAP) && !GET_FLAG(player, type, doMsgs, DUNGEON, CHOR_NPC_KILLED)) {
                        SHOW_TEXT(player, type, doMsgs, "A maniacal fiend appears; removes an item you stole from him; and kills you outright.");
                        while (HAS_ITEM(player, type, doMsgs, JESTERSCAP))
                            TAKE_ITEM(player, type, doMsgs, JESTERSCAP);
                            MOD_GOLD(player, type, doMsgs,  - 10000);
                            DAMAGE(player, type, doMsgs, MAX_HEALTH(player, type, doMsgs));
                        }
                    }
                    protected override void FnEvent3C(TwPlayerServer player, MapEventType type, bool doMsgs) {
                        SHOW_TEXT(player, type, doMsgs, "The door glows with a magical force.");
                        if (PARTY_COUNT(player, type, doMsgs) == 1) {
                            SHOW_TEXT(player, type, doMsgs, "You may proceed alone.");
                            CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
                        }
                        else {
                            SHOW_TEXT(player, type, doMsgs, "You must enter here one at a time.");
                            BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
                        }
                    }
                }
            }
