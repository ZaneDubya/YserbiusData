using XPT.Games.Generic.Constants;
using XPT.Games.Generic.Maps;
using XPT.Games.Twinion.Entities;

namespace XPT.Games.Twinion.Maps {
    class TwMap23 : TwMap {
        public override int MapIndex => 23;
        public override int MapID => 0x0A01;
        protected override int RandomEncounterChance => 12;
        protected override int RandomEncounterExtraCount => 2;

        private const int MYTHW = 1;
        private const int ISLANDW = 2;
        private const int LEGENDW = 3;
        private const int EREBUSW = 4;
        private const int ABYSSW = 5;
        private const int WIZARDW = 6;
        private const int GUILDW = 7;
        private const int ASPW = 8;
        private const int MAGMAW = 9;
        private const int PALACEW = 10;
        private const int VOLCANOW = 11;
        private const int LONGBOWW = 12;
        private const int HARMONYW = 13;
        private const int TWINIONW = 14;
        private const int CHAOTICW = 15;
        private const int ELEMENTALW = 16;
        private const int SWITCH30 = 17;
        private const int SWITCH31 = 18;
        private const int SWITCH32 = 19;
        private const int SWITCH33 = 20;
        private const int SWITCH34 = 21;
        private const int SWITCH35 = 22;
        private const int SWITCH36 = 23;
        private const int SWITCH37 = 24;
        private const int CASETRAP = 25;
        private const int MIXEDONE = 26;
        private const int ROGUES = 27;
        private const int FOTEREBUS = 28;
        private const int SEENWRAITH = 29;
        private const int SPRUNGTRAP = 1;
        protected override void FnEvent01(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
            SetWallItem(player, type, doMsgs, PORTAL, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
        }
        protected override void FnEvent02(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                int picture = 0;
                int flagname = 0;
                int nextflag = 0;
                int tile = 0;
                tile = GetTile(player, type, doMsgs);
                switch (tile) {
                    case 74:
                        picture = HUMANBARBARIAN;
                        flagname = TwIndexes.LEARNEDGREMLIN;
                        nextflag = TwIndexes.LEARNEDHUMAN;
                        ShowText(player, type, doMsgs, "'Babble is surely what is to be had if you take the words at face value.");
                        ShowText(player, type, doMsgs, "You now know the Common tongue.'");
                        break;
                    case 75:
                        picture = ORCRANGER;
                        flagname = TwIndexes.LEARNEDGNOME;
                        nextflag = TwIndexes.LEARNEDORC;
                        ShowText(player, type, doMsgs, "'The letters are the keys; the switches set the words; you must spell inside the words.");
                        ShowText(player, type, doMsgs, "You now know Orc.'");
                        break;
                    case 90:
                        picture = ELFBARBARIAN;
                        flagname = TwIndexes.LEARNEDHUMAN;
                        nextflag = TwIndexes.LEARNEDELF;
                        ShowText(player, type, doMsgs, "'This mountain of lava sets one stage; the other has befriended thee.");
                        ShowText(player, type, doMsgs, "You are now fluent with the Elven tongue.'");
                        break;
                    case 91:
                        picture = TROLLKNIGHT;
                        flagname = TwIndexes.LEARNEDORC;
                        nextflag = TwIndexes.LEARNEDTROLL;
                        ShowText(player, type, doMsgs, "'Ignore the last till second; see the second first.");
                        ShowText(player, type, doMsgs, "You are now the Troll language incarnate.'");
                        break;
                    case 106:
                        picture = DWARFWIZARD;
                        flagname = TwIndexes.LEARNEDELF;
                        nextflag = TwIndexes.LEARNEDDWARF;
                        ShowText(player, type, doMsgs, "'With hallowed halls the dead king lies, his offspring now rules the mount.");
                        ShowText(player, type, doMsgs, "You now know Dwarf.'");
                        break;
                    case 107:
                        picture = HALFLINGKNIGHT;
                        flagname = TwIndexes.LEARNEDTROLL;
                        nextflag = TwIndexes.LEARNEDHALF;
                        ShowText(player, type, doMsgs, "'As the last, let the good Queen shine; in a second the lava spouts.");
                        ShowText(player, type, doMsgs, "You are now able to mumble Halfling.'");
                        break;
                    case 122:
                        picture = GNOMEBARBARIAN;
                        flagname = TwIndexes.LEARNEDDWARF;
                        nextflag = TwIndexes.LEARNEDGNOME;
                        ShowText(player, type, doMsgs, "'Read it friend, two names are there if only you can see the clues.");
                        ShowText(player, type, doMsgs, "You now know Gnome.'");
                        break;
                    case 123:
                        picture = GREMLINTHIEF;
                        flagname = TwIndexes.LEARNEDHALF;
                        nextflag = TwIndexes.LEARNEDGREMLIN;
                        ShowText(player, type, doMsgs, "'The King is dead; long live the Queen!");
                        ShowText(player, type, doMsgs, "You now speak Gremlin - but only when you must.'");
                        break;
                }
                ShowPortrait(player, type, doMsgs, picture);
                if (GetFlag(player, type, doMsgs, FlagTypeDungeon, flagname) == 1) {
                    if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, nextflag) == 0)) {
                        SetFlag(player, type, doMsgs, FlagTypeDungeon, nextflag, 1);
                    }
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, flagname, 2);
                }
            }
            else {
                ShowText(player, type, doMsgs, "You must enter the room alone.");
                TeleportParty(player, type, doMsgs, 10, 1, 120, Direction.West);
            }
        }
        protected override void FnEvent0A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 10, 1, 136, Direction.East);
        }
        protected override void FnEvent0B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Enter now the legacy of babel's nexus.");
            SetFlag(player, type, doMsgs, FlagTypeParty, FOTEREBUS, 1);
        }
        protected override void FnEvent0C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Back to the upper level.");
            TeleportParty(player, type, doMsgs, 9, 2, 120, Direction.West);
        }
        protected override void FnEvent0D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int picture = 0;
            int flagname = 0;
            int nextflag = 0;
            int tally = 0;
            tally = GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.LEARNEDHUMAN) + GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.LEARNEDDWARF) + GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.LEARNEDGNOME) + GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.LEARNEDGREMLIN) + GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.LEARNEDELF) + GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.LEARNEDTROLL) + GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.LEARNEDORC) + GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.LEARNEDHALF);
            switch (GetTile(player, type, doMsgs)) {
                case 83:
                    picture = HUMANBARBARIAN;
                    flagname = TwIndexes.LEARNEDHUMAN;
                    nextflag = TwIndexes.LEARNEDELF;
                    ShowText(player, type, doMsgs, "A Human is here.");
                    break;
                case 0:
                    picture = ORCRANGER;
                    flagname = TwIndexes.LEARNEDORC;
                    nextflag = TwIndexes.LEARNEDTROLL;
                    ShowText(player, type, doMsgs, "An Orc is here.");
                    break;
                case 81:
                    picture = TROLLKNIGHT;
                    flagname = TwIndexes.LEARNEDTROLL;
                    nextflag = TwIndexes.LEARNEDHALF;
                    ShowText(player, type, doMsgs, "A Troll is here.");
                    break;
                case 160:
                    picture = ELFBARBARIAN;
                    flagname = TwIndexes.LEARNEDELF;
                    nextflag = TwIndexes.LEARNEDDWARF;
                    ShowText(player, type, doMsgs, "An Elf is here.");
                    break;
                case 133:
                    picture = HALFLINGKNIGHT;
                    flagname = TwIndexes.LEARNEDHALF;
                    nextflag = TwIndexes.LEARNEDGREMLIN;
                    ShowText(player, type, doMsgs, "A Halfling is here.");
                    break;
                case 50:
                    picture = GREMLINTHIEF;
                    flagname = TwIndexes.LEARNEDGREMLIN;
                    nextflag = TwIndexes.LEARNEDHUMAN;
                    ShowText(player, type, doMsgs, "A Gremlin is here.");
                    break;
                case 147:
                    picture = DWARFWIZARD;
                    flagname = TwIndexes.LEARNEDDWARF;
                    nextflag = TwIndexes.LEARNEDGNOME;
                    ShowText(player, type, doMsgs, "A Dwarf Wizard is here.");
                    break;
                case 96:
                    picture = GNOMEBARBARIAN;
                    flagname = TwIndexes.LEARNEDGNOME;
                    nextflag = TwIndexes.LEARNEDORC;
                    ShowText(player, type, doMsgs, "A Gnome is here.");
                    break;
            }
            ShowPortrait(player, type, doMsgs, picture);
            if (tally == 16) {
                ShowText(player, type, doMsgs, "'You know all that you need. Go to the northeast room. Find your fate and unlock the gate.'");
            }
            else if (IsFlagOn(player, type, doMsgs, FlagTypeDungeon, flagname)) {
                if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, nextflag) == 0)) {
                    RaceText(player, type, doMsgs);
                    ShowText(player, type, doMsgs, "lies the teleport that will take you to the next scholar. Go, it will now be unlocked.'");
                }
                else {
                    ShowText(player, type, doMsgs, "'I can do nothing more for you. Learn all of the languages; then read the plaques in the northeast.'");
                }
            }
            else {
                switch (GetRace(player, type, doMsgs)) {
                    case HUMAN:
                        ShowText(player, type, doMsgs, "nemo me impune lacessit");
                        break;
                    case ELF:
                        ShowText(player, type, doMsgs, "fortuna favet fortibus");
                        break;
                    case DWARF:
                        ShowText(player, type, doMsgs, "vox populi, vox Dei");
                        break;
                    case TROLL:
                        ShowText(player, type, doMsgs, "vox et praeterea nihil");
                        break;
                    case GNOME:
                        ShowText(player, type, doMsgs, "quem Deus vult perdere, prius dementat");
                        break;
                    case HALFLING:
                        ShowText(player, type, doMsgs, "lasciate ogni speranza");
                        break;
                    case ORC:
                        ShowText(player, type, doMsgs, "finis coronat opus");
                        break;
                    case GREMLIN:
                        ShowText(player, type, doMsgs, "flat justitia, ruat coelum");
                        break;
                    }
                }
            }
            private void RaceText(TwPlayerServer player, MapEventType type, bool doMsgs) {
                switch (GetTile(player, type, doMsgs)) {
                    case 83:
                        ShowText(player, type, doMsgs, "'To the southeast ");
                        break;
                    case 0:
                        ShowText(player, type, doMsgs, "'Go to the northeast ");
                        break;
                    case 81:
                        ShowText(player, type, doMsgs, "'Somewhere in the center ");
                        break;
                    case 160:
                        ShowText(player, type, doMsgs, "'Now, just south of the scholar's rooms ");
                        break;
                    case 133:
                        ShowText(player, type, doMsgs, "'One south of where we are ");
                        break;
                    case 50:
                        ShowText(player, type, doMsgs, "'At the southern edge ");
                        break;
                    case 147:
                        ShowText(player, type, doMsgs, "'In the northwest ");
                        break;
                    case 96:
                        ShowText(player, type, doMsgs, "'In the east ");
                        break;
                }
            }
            protected override void FnEvent15(TwPlayerServer player, MapEventType type, bool doMsgs) {
                int flagname = 0;
            Direction compass1 = 0;
            Direction compass2 = 0;
                int totile = 0;
                int tile = 0;
                tile = GetTile(player, type, doMsgs);
                switch (tile) {
                    case 238:
                        flagname = TwIndexes.LEARNEDHUMAN;
                        compass1 = Direction.West;
                        compass2 = Direction.West;
                        totile = 90;
                        ShowText(player, type, doMsgs, "HUMAN");
                        break;
                    case 250:
                        flagname = TwIndexes.LEARNEDGREMLIN;
                        compass1 = Direction.South;
                        compass2 = Direction.West;
                        totile = 74;
                        ShowText(player, type, doMsgs, "GREMLIN");
                        break;
                    case 149:
                        flagname = TwIndexes.LEARNEDHALF;
                        compass1 = Direction.East;
                        compass2 = Direction.East;
                        totile = 123;
                        ShowText(player, type, doMsgs, "HALFLING");
                        break;
                    case 53:
                        flagname = TwIndexes.LEARNEDDWARF;
                        compass1 = Direction.West;
                        compass2 = Direction.West;
                        totile = 122;
                        ShowText(player, type, doMsgs, "DWARF");
                        break;
                    case 119:
                        flagname = TwIndexes.LEARNEDTROLL;
                        compass1 = Direction.South;
                        compass2 = Direction.East;
                        totile = 107;
                        ShowText(player, type, doMsgs, "TROLL");
                        break;
                    case 27:
                        flagname = TwIndexes.LEARNEDORC;
                        compass1 = Direction.North;
                        compass2 = Direction.East;
                        totile = 91;
                        ShowText(player, type, doMsgs, "ORC");
                        break;
                    case 93:
                        flagname = TwIndexes.LEARNEDGNOME;
                        compass1 = Direction.North;
                        compass2 = Direction.East;
                        totile = 75;
                        ShowText(player, type, doMsgs, "GNOME");
                        break;
                    case 139:
                        flagname = TwIndexes.LEARNEDELF;
                        compass1 = Direction.South;
                        compass2 = Direction.West;
                        totile = 106;
                        ShowText(player, type, doMsgs, "ELF");
                        break;
                }
                if (GetFlag(player, type, doMsgs, FlagTypeDungeon, flagname) == 1) {
                    SetWallItem(player, type, doMsgs, GATEWAY, GetTile(player, type, doMsgs), compass1);
                    ShowText(player, type, doMsgs, "A gateway is here.");
                    TeleportParty(player, type, doMsgs, 10, 1, totile, compass2);
                }
                else {
                    ShowText(player, type, doMsgs, "This portal will lead to the name marked upon it. Return once you are told by those that babble in the west.");
                    ShowText(player, type, doMsgs, "At present, it will only take you to the heart of this maze.");
                    TeleportParty(player, type, doMsgs, 10, 1, 88, Direction.North);
                }
            }
            protected override void FnEvent1D(TwPlayerServer player, MapEventType type, bool doMsgs) {
                if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.ENDGAMETELE) == 1) {
                    if (GetPartyCount(player, type, doMsgs) == 1) {
                        ShowText(player, type, doMsgs, "This wall glows with power, beckoning you to enter.");
                        ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                        TeleportParty(player, type, doMsgs, 10, 1, 22, Direction.North);
                    }
                    else {
                        ShowText(player, type, doMsgs, "Alone! You must use this gateway alone.");
                        TeleportParty(player, type, doMsgs, 10, 1, 184, Direction.East);
                    }
                }
            }
            protected override void FnEvent1E(TwPlayerServer player, MapEventType type, bool doMsgs) {
                if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.LEARNEDHUMAN) == 2) {
                    int switchA = 0;
                    int valueA = 0;
                    int valueB = 0;
                    switchA = GetFlag(player, type, doMsgs, FlagTypeParty, SWITCH30);
                    switch (switchA) {
                        case 1:
                            ShowText(player, type, doMsgs, "EREBUS");
                            valueA = 1;
                            valueB = 0;
                            switchA = 2;
                            break;
                        case 2:
                            ShowText(player, type, doMsgs, "MAGMA");
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
                    SetFlag(player, type, doMsgs, FlagTypeParty, EREBUSW, valueA);
                    SetFlag(player, type, doMsgs, FlagTypeParty, MAGMAW, valueB);
                    SetFlag(player, type, doMsgs, FlagTypeParty, SWITCH30, switchA);
                }
                else {
                    ShowText(player, type, doMsgs, "sculpsit");
                }
            }
            protected override void FnEvent1F(TwPlayerServer player, MapEventType type, bool doMsgs) {
                if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.LEARNEDHALF) == 2) {
                    int switchA = 0;
                    int valueA = 0;
                    int valueB = 0;
                    switchA = GetFlag(player, type, doMsgs, FlagTypeParty, SWITCH31);
                    switch (switchA) {
                        case 1:
                            ShowText(player, type, doMsgs, "ASP");
                            valueA = 1;
                            valueB = 0;
                            switchA++;
                            break;
                        case 2:
                            ShowText(player, type, doMsgs, "LONGBOW");
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
                    SetFlag(player, type, doMsgs, FlagTypeParty, ASPW, valueA);
                    SetFlag(player, type, doMsgs, FlagTypeParty, LONGBOWW, valueB);
                    SetFlag(player, type, doMsgs, FlagTypeParty, SWITCH31, switchA);
                }
                else {
                    ShowText(player, type, doMsgs, "tant mieux");
                }
            }
            protected override void FnEvent20(TwPlayerServer player, MapEventType type, bool doMsgs) {
                if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.LEARNEDDWARF) == 2) {
                    int switchA = 0;
                    int valueA = 0;
                    int valueB = 0;
                    switchA = GetFlag(player, type, doMsgs, FlagTypeParty, SWITCH32);
                    switch (switchA) {
                        case 1:
                            ShowText(player, type, doMsgs, "ELEMENTAL");
                            valueA = 1;
                            valueB = 0;
                            switchA++;
                            break;
                        case 2:
                            ShowText(player, type, doMsgs, "ISLAND");
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
                    SetFlag(player, type, doMsgs, FlagTypeParty, ELEMENTALW, valueA);
                    SetFlag(player, type, doMsgs, FlagTypeParty, ISLANDW, valueB);
                    SetFlag(player, type, doMsgs, FlagTypeParty, SWITCH32, switchA);
                }
                else {
                    ShowText(player, type, doMsgs, "obiit");
                }
            }
            protected override void FnEvent21(TwPlayerServer player, MapEventType type, bool doMsgs) {
                if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.LEARNEDGNOME) == 2) {
                    int switchA = 0;
                    int valueA = 0;
                    int valueB = 0;
                    switchA = GetFlag(player, type, doMsgs, FlagTypeParty, SWITCH33);
                    switch (switchA) {
                        case 1:
                            ShowText(player, type, doMsgs, "HARMONY");
                            valueA = 1;
                            valueB = 0;
                            switchA++;
                            break;
                        case 2:
                            ShowText(player, type, doMsgs, "GUILD");
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
                    SetFlag(player, type, doMsgs, FlagTypeParty, HARMONYW, valueA);
                    SetFlag(player, type, doMsgs, FlagTypeParty, GUILDW, valueB);
                    SetFlag(player, type, doMsgs, FlagTypeParty, SWITCH33, switchA);
                }
                else {
                    ShowText(player, type, doMsgs, "peccavi");
                }
            }
            protected override void FnEvent22(TwPlayerServer player, MapEventType type, bool doMsgs) {
                if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.LEARNEDGREMLIN) == 2) {
                    int switchA = 0;
                    int valueA = 0;
                    int valueB = 0;
                    switchA = GetFlag(player, type, doMsgs, FlagTypeParty, SWITCH34);
                    switch (switchA) {
                        case 1:
                            ShowText(player, type, doMsgs, "CHAOTIC");
                            valueA = 1;
                            valueB = 0;
                            switchA++;
                            break;
                        case 2:
                            ShowText(player, type, doMsgs, "MYTH");
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
                    SetFlag(player, type, doMsgs, FlagTypeParty, CHAOTICW, valueA);
                    SetFlag(player, type, doMsgs, FlagTypeParty, MYTHW, valueB);
                    SetFlag(player, type, doMsgs, FlagTypeParty, SWITCH34, switchA);
                }
                else {
                    ShowText(player, type, doMsgs, "l'onconnu");
                }
            }
            protected override void FnEvent23(TwPlayerServer player, MapEventType type, bool doMsgs) {
                if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.LEARNEDORC) == 2) {
                    int switchA = 0;
                    int valueA = 0;
                    int valueB = 0;
                    switchA = GetFlag(player, type, doMsgs, FlagTypeParty, SWITCH35);
                    switch (switchA) {
                        case 1:
                            ShowText(player, type, doMsgs, "VOLCANO");
                            valueA = 1;
                            valueB = 0;
                            switchA++;
                            break;
                        case 2:
                            ShowText(player, type, doMsgs, "ABYSS");
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
                    SetFlag(player, type, doMsgs, FlagTypeParty, VOLCANOW, valueA);
                    SetFlag(player, type, doMsgs, FlagTypeParty, ABYSSW, valueB);
                    SetFlag(player, type, doMsgs, FlagTypeParty, SWITCH35, switchA);
                }
                else {
                    ShowText(player, type, doMsgs, "fiat lux");
                }
            }
            protected override void FnEvent24(TwPlayerServer player, MapEventType type, bool doMsgs) {
                if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.LEARNEDTROLL) == 2) {
                    int switchA = 0;
                    int valueA = 0;
                    int valueB = 0;
                    switchA = GetFlag(player, type, doMsgs, FlagTypeParty, SWITCH36);
                    switch (switchA) {
                        case 1:
                            ShowText(player, type, doMsgs, "TWINION");
                            valueA = 1;
                            valueB = 0;
                            switchA++;
                            break;
                        case 2:
                            ShowText(player, type, doMsgs, "LEGEND");
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
                    SetFlag(player, type, doMsgs, FlagTypeParty, TWINIONW, valueA);
                    SetFlag(player, type, doMsgs, FlagTypeParty, LEGENDW, valueB);
                    SetFlag(player, type, doMsgs, FlagTypeParty, SWITCH36, switchA);
                }
                else {
                    ShowText(player, type, doMsgs, "a priori");
                }
            }
            protected override void FnEvent25(TwPlayerServer player, MapEventType type, bool doMsgs) {
                if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.LEARNEDELF) == 2) {
                    int switchA = 0;
                    int valueA = 0;
                    int valueB = 0;
                    switchA = GetFlag(player, type, doMsgs, FlagTypeParty, SWITCH37);
                    switch (switchA) {
                        case 1:
                            ShowText(player, type, doMsgs, "WIZARD");
                            valueA = 1;
                            valueB = 0;
                            switchA++;
                            break;
                        case 2:
                            ShowText(player, type, doMsgs, "PALACE");
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
                    SetFlag(player, type, doMsgs, FlagTypeParty, WIZARDW, valueA);
                    SetFlag(player, type, doMsgs, FlagTypeParty, PALACEW, valueB);
                    SetFlag(player, type, doMsgs, FlagTypeParty, SWITCH37, switchA);
                }
                else {
                    ShowText(player, type, doMsgs, "ad finem");
                }
            }
            private void OffText(TwPlayerServer player, MapEventType type, bool doMsgs) {
                ShowText(player, type, doMsgs, "-OFF-");
            }
            protected override void FnEvent26(TwPlayerServer player, MapEventType type, bool doMsgs) {
                if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.SPELLEDBOTH) == 0)) {
                    int i = 0;
                    int word = 0;
                    int valueA = 0;
                    int valueB = 0;
                    word = GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.SPELLINGWORD);
                    if (word == 0) {
                        word = 1;
                    }
                    switch (word) {
                        case 2:
                            valueB = GetFlag(player, type, doMsgs, FlagTypeParty, ELEMENTALW) + GetFlag(player, type, doMsgs, FlagTypeParty, CHAOTICW) + GetFlag(player, type, doMsgs, FlagTypeParty, MAGMAW) + GetFlag(player, type, doMsgs, FlagTypeParty, PALACEW) + GetFlag(player, type, doMsgs, FlagTypeParty, VOLCANOW) + GetFlag(player, type, doMsgs, FlagTypeParty, LONGBOWW) + GetFlag(player, type, doMsgs, FlagTypeParty, HARMONYW) + GetFlag(player, type, doMsgs, FlagTypeParty, TWINIONW);
                            if (valueB == 6) {
                                ShowText(player, type, doMsgs, "Your experience increases along with your gold and your strength!");
                                ModifyGold(player, type, doMsgs, 250000);
                                ModAttribute(player, type, doMsgs, STRENGTH, 3);
                                ModifyExperience(player, type, doMsgs, 750000);
                                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.SPELLINGWORD, 3);
                                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.SPELLEDBOTH, 1);
                                SetFloorItem(player, type, doMsgs, PIT, 11);
                                for (i = 39; i <= 46; i++) {
                                    SetFlag(player, type, doMsgs, FlagTypeDungeon, i, 4);
                                }
                                for (i = 23; i <= 31; i++) {
                                    ClearWallItem(player, type, doMsgs, i, Direction.South);
                                }
                                SpelledEm(player, type, doMsgs);
                            }
                            else {
                                NadaQue(player, type, doMsgs);
                            }
                            break;
                        case 1:
                            valueA = GetFlag(player, type, doMsgs, FlagTypeParty, MYTHW) + GetFlag(player, type, doMsgs, FlagTypeParty, ISLANDW) + GetFlag(player, type, doMsgs, FlagTypeParty, LEGENDW) + GetFlag(player, type, doMsgs, FlagTypeParty, EREBUSW) + GetFlag(player, type, doMsgs, FlagTypeParty, ABYSSW) + GetFlag(player, type, doMsgs, FlagTypeParty, WIZARDW) + GetFlag(player, type, doMsgs, FlagTypeParty, GUILDW) + GetFlag(player, type, doMsgs, FlagTypeParty, ASPW);
                            if (valueA == 8) {
                                ShowText(player, type, doMsgs, "You've set the first word. On to the next. Here's a taste of experience, gold and a little initiative!");
                                ModAttribute(player, type, doMsgs, INITIATIVE, 3);
                                ModifyGold(player, type, doMsgs, 175000);
                                ModifyExperience(player, type, doMsgs, 700000);
                                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.SPELLINGWORD, 2);
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
                ShowText(player, type, doMsgs, "You've spelled the words. Now through the exit and onward to your Fate!");
            }
            private void NadaQue(TwPlayerServer player, MapEventType type, bool doMsgs) {
                ShowText(player, type, doMsgs, "Nothing happens.");
            }
            protected override void FnEvent27(TwPlayerServer player, MapEventType type, bool doMsgs) {
                if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.SPELLEDBOTH) == 1) {
                    if (GetPartyCount(player, type, doMsgs) == 1) {
                        ShowText(player, type, doMsgs, "The magical winds sweep you up and pull you down through the opening into Concordia.");
                        TeleportParty(player, type, doMsgs, 10, 2, 225, Direction.East);
                    }
                    else {
                        ShowText(player, type, doMsgs, "You may enter only if alone!");
                        SetFloorItem(player, type, doMsgs, NO_OBJECT, 11);
                    }
                }
                else {
                    SetFloorItem(player, type, doMsgs, NO_OBJECT, 11);
                }
            }
            protected override void FnEvent28(TwPlayerServer player, MapEventType type, bool doMsgs) {
                int i = 0;
                if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.KNOWSALL) == 0)) {
                    if (GetPartyCount(player, type, doMsgs) != 1) {
                        ShowText(player, type, doMsgs, "Only alone may you pass through.");
                        TeleportParty(player, type, doMsgs, 10, 1, 6, Direction.East);
                    }
                    else if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.SPELLEDBOTH) == 1) {
                        ShowText(player, type, doMsgs, "You have already solved this puzzle!");
                        ShowText(player, type, doMsgs, "Proceed to your exit.");
                        SetFloorItem(player, type, doMsgs, PIT, 11);
                        for (i = 23; i <= 31; i++) {
                            ClearWallItem(player, type, doMsgs, i, Direction.South);
                        }
                    }
                    else {
                        int flagcount = 0;
                        flagcount = GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.LEARNEDHUMAN) + GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.LEARNEDGNOME) + GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.LEARNEDHALF) + GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.LEARNEDTROLL) + GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.LEARNEDORC) + GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.LEARNEDGREMLIN) + GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.LEARNEDELF) + GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.LEARNEDDWARF);
                        if ((flagcount == 16) || (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.KNOWSALL) == 1)) {
                            if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.KNOWSALL) == 0)) {
                                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.KNOWSALL, 1);
                            }
                            ShowText(player, type, doMsgs, "You have proven your knowledge of the major languages. Now read the plaques and set the switches. Then you may proceed.");
                        }
                        else {
                            ShowText(player, type, doMsgs, "You need to learn more about languages before you can tackle this puzzle.");
                        }
                    }
                }
            }
            protected override void FnEvent29(TwPlayerServer player, MapEventType type, bool doMsgs) {
                if ((GetFlag(player, type, doMsgs, FlagTypeParty, SEENWRAITH) == 0)) {
                    ShowPortrait(player, type, doMsgs, WRAITH);
                    ShowText(player, type, doMsgs, "'Beware! Beware! The traps here are of fiendish conception! They change whence you step them again although they are the same tile! Beware!'");
                    SetFlag(player, type, doMsgs, FlagTypeParty, SEENWRAITH, 1);
                }
            }
            protected override void FnEvent2A(TwPlayerServer player, MapEventType type, bool doMsgs) {
                int i = 0;
                int pl = 0;
                if (GetPartyLevel(player, type, doMsgs, 35)) {
                    pl = 1;
                }
                ShowText(player, type, doMsgs, "Night Elf berserkers scream wildly as they attack.");
                if (HasItem(player, type, doMsgs, BLACKBLADE)) {
                    SetTreasure(player, type, doMsgs, ELIXIROFHEALTH, NIGHTELFHELM, 0, 0, 0, 1000);
                }
                else {
                    SetTreasure(player, type, doMsgs, BLACKBLADE, 0, 0, 0, 0, 1500);
                }
                switch (pl) {
                    case 1:
                        for (i = 1; i <= 2; i++) {
                            AddEncounter(player, type, doMsgs, i, 36);
                        }
                        for (i = 5; i <= 6; i++) {
                            AddEncounter(player, type, doMsgs, i, 37);
                        }
                        break;
                    default:
                        for (i = 1; i <= 2; i++) {
                            AddEncounter(player, type, doMsgs, i, 36);
                        }
                        for (i = 5; i <= 6; i++) {
                            AddEncounter(player, type, doMsgs, i, 37);
                        }
                        break;
                }
            }
            protected override void FnEvent2B(TwPlayerServer player, MapEventType type, bool doMsgs) {
                if ((GetFlag(player, type, doMsgs, FlagTypeParty, FOTEREBUS) == 0)) {
                    int i = 0;
                    ShowText(player, type, doMsgs, "Two Erebus fiends hiss as you approach.");
                    for (i = 1; i <= 2; i++) {
                        AddEncounter(player, type, doMsgs, i, 40);
                    }
                }
            }
            protected override void FnEvent2C(TwPlayerServer player, MapEventType type, bool doMsgs) {
                int i = 0;
                ShowText(player, type, doMsgs, "Hulking Kaalroths launch a fierce magical attack.");
                switch (GetPartyCount(player, type, doMsgs)) {
                    case 1:
                        for (i = 1; i <= 2; i++) {
                            AddEncounter(player, type, doMsgs, i, 28);
                        }
                        break;
                    case 2:
                        for (i = 1; i <= 3; i++) {
                            AddEncounter(player, type, doMsgs, i, 28);
                        }
                        break;
                    default:
                        for (i = 1; i <= 4; i++) {
                            AddEncounter(player, type, doMsgs, i, 28);
                        }
                        for (i = 5; i <= 6; i++) {
                            AddEncounter(player, type, doMsgs, i, 29);
                        }
                        break;
                }
            }
            protected override void FnEvent2D(TwPlayerServer player, MapEventType type, bool doMsgs) {
                int i = 0;
                ShowText(player, type, doMsgs, "'You've slain many of our friends. It is your time now!'");
                for (i = 1; i <= 2; i++) {
                    AddEncounter(player, type, doMsgs, i, 26);
                }
            }
            protected override void FnEvent2E(TwPlayerServer player, MapEventType type, bool doMsgs) {
                int i = 0;
                if (GetFlag(player, type, doMsgs, FlagTypeParty, MIXEDONE) == 2) {
                    ShowText(player, type, doMsgs, "Wizards and their servants are tending the fallen Golems you killed!");
                    switch (GetPartyCount(player, type, doMsgs)) {
                        case 1:
                            AddEncounter(player, type, doMsgs, 1, 25);
                            for (i = 5; i <= 6; i++) {
                                AddEncounter(player, type, doMsgs, i, 30);
                            }
                            break;
                        case 2:
                            for (i = 1; i <= 2; i++) {
                                AddEncounter(player, type, doMsgs, i, 25);
                            }
                            for (i = 5; i <= 6; i++) {
                                AddEncounter(player, type, doMsgs, i, 30);
                            }
                            break;
                        default:
                            for (i = 1; i <= 4; i++) {
                                AddEncounter(player, type, doMsgs, i, 25);
                            }
                            for (i = 5; i <= 6; i++) {
                                AddEncounter(player, type, doMsgs, i, 30);
                            }
                            break;
                    }
                }
                else if (GetFlag(player, type, doMsgs, FlagTypeParty, MIXEDONE) == 1) {
                    ShowText(player, type, doMsgs, "Huge golems lumber forward to block your path.");
                    for (i = 1; i <= 3; i++) {
                        AddEncounter(player, type, doMsgs, i, 25);
                    }
                }
                else {
                    ShowText(player, type, doMsgs, "The floor here shows traces of recent activity by huge creatures.");
                    SetFlag(player, type, doMsgs, FlagTypeParty, MIXEDONE, 1);
                }
            }
            protected override void FnEvent2F(TwPlayerServer player, MapEventType type, bool doMsgs) {
                if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.LEARNEDELF) == 1) {
                    ShowText(player, type, doMsgs, "An eerie sense of magic surrounds you.");
                    ShowText(player, type, doMsgs, "Something is different! You'd better check this area again.");
                }
            }
            protected override void FnEvent30(TwPlayerServer player, MapEventType type, bool doMsgs) {
                int i = 0;
                ShowText(player, type, doMsgs, "A horde of Golems stir to life as they sense your approach!");
                for (i = 1; i <= 4; i++) {
                    AddEncounter(player, type, doMsgs, i, 31);
                }
            }
            protected override void FnEvent31(TwPlayerServer player, MapEventType type, bool doMsgs) {
                int i = 0;
                ShowText(player, type, doMsgs, "Babbling rogues, driven mad from their quests, see you as their next prey.");
                switch (GetPartyCount(player, type, doMsgs)) {
                    case 1:
                        AddEncounter(player, type, doMsgs, 1, 32);
                        AddEncounter(player, type, doMsgs, 2, 33);
                        break;
                    case 2:
                        for (i = 1; i <= 2; i++) {
                            AddEncounter(player, type, doMsgs, i, 32);
                        }
                        for (i = 5; i <= 6; i++) {
                            AddEncounter(player, type, doMsgs, i, 33);
                        }
                        break;
                    default:
                        for (i = 1; i <= 4; i++) {
                            AddEncounter(player, type, doMsgs, i, 32);
                        }
                        for (i = 5; i <= 6; i++) {
                            AddEncounter(player, type, doMsgs, i, 33);
                        }
                        break;
                }
            }
            protected override void FnEvent32(TwPlayerServer player, MapEventType type, bool doMsgs) {
                int i = 0;
                if (GetFlag(player, type, doMsgs, FlagTypeParty, ROGUES) == 1) {
                    ShowText(player, type, doMsgs, "'OUT! Keep out of our domain!'");
                    switch (GetPartyCount(player, type, doMsgs)) {
                        case 1:
                            for (i = 1; i <= 2; i++) {
                                AddEncounter(player, type, doMsgs, i, 34);
                            }
                            break;
                        case 2:
                            for (i = 1; i <= 4; i++) {
                                AddEncounter(player, type, doMsgs, i, 34);
                            }
                            break;
                        default:
                            for (i = 1; i <= 6; i++) {
                                AddEncounter(player, type, doMsgs, i, 34);
                            }
                            break;
                    }
                }
                else {
                    ShowPortrait(player, type, doMsgs, NIGHTELFWARRIOR);
                    ShowText(player, type, doMsgs, "A Night Elf warrior holds his forces at the ready.");
                    ShowText(player, type, doMsgs, "'Leave this place and do not return. Abandon your quest for our Dralkarians.");
                    ShowText(player, type, doMsgs, "This shall be your only warning.'");
                    SetFlag(player, type, doMsgs, FlagTypeParty, ROGUES, 1);
                }
            }
            protected override void FnEvent33(TwPlayerServer player, MapEventType type, bool doMsgs) {
                int i = 0;
                ShowText(player, type, doMsgs, "More Night Elves have been called to defend their domain.");
                switch (GetPartyCount(player, type, doMsgs)) {
                    case 1:
                        for (i = 1; i <= 2; i++) {
                            AddEncounter(player, type, doMsgs, i, 35);
                        }
                        break;
                    case 2:
                        for (i = 1; i <= 4; i++) {
                            AddEncounter(player, type, doMsgs, i, 35);
                        }
                        break;
                    default:
                        for (i = 1; i <= 6; i++) {
                            AddEncounter(player, type, doMsgs, i, 35);
                        }
                        break;
                }
            }
            protected override void FnEvent34(TwPlayerServer player, MapEventType type, bool doMsgs) {
                ShowText(player, type, doMsgs, "Babbling creatures begin feuding and draw you into their fray.");
                AddEncounter(player, type, doMsgs, 01, 37);
                AddEncounter(player, type, doMsgs, 02, 38);
            }
            protected override void FnEvent35(TwPlayerServer player, MapEventType type, bool doMsgs) {
                int i = 0;
                ShowText(player, type, doMsgs, "A slew of bats rush through this hallway.");
                switch (GetPartyCount(player, type, doMsgs)) {
                    case 1:
                        for (i = 1; i <= 2; i++) {
                            AddEncounter(player, type, doMsgs, i, 39);
                        }
                        break;
                    case 2:
                        for (i = 1; i <= 4; i++) {
                            AddEncounter(player, type, doMsgs, i, 39);
                        }
                        break;
                    default:
                        for (i = 1; i <= 6; i++) {
                            AddEncounter(player, type, doMsgs, i, 39);
                        }
                        break;
                }
            }
            protected override void FnEvent36(TwPlayerServer player, MapEventType type, bool doMsgs) {
                int trap = 0;
                trap = GetFlag(player, type, doMsgs, FlagTypeParty, CASETRAP);
                if ((GetFlag(player, type, doMsgs, FlagTypeTile, SPRUNGTRAP) == 0)) {
                    switch (trap) {
                        case 1:
                            DoDamage(player, type, doMsgs, GetHealthCurrent(player, type, doMsgs) / 6);
                            SetDebuff(player, type, doMsgs, POISON, 15, 100);
                            DisableSpells(player, type, doMsgs);
                            ShowText(player, type, doMsgs, "You spring a trap laced with poisoned darts.");
                            trap++;
                            break;
                        case 2:
                            DoDamage(player, type, doMsgs, GetHealthCurrent(player, type, doMsgs) / 5);
                            ShowText(player, type, doMsgs, "You trigger some mage's trap. A cloud of acid surrounds you!!");
                            ModifyGold(player, type, doMsgs,  - 2000);
                            trap++;
                            break;
                        case 3:
                            DoDamage(player, type, doMsgs, GetHealthCurrent(player, type, doMsgs) / 4);
                            ShowText(player, type, doMsgs, "Fireballs slam into you as you set off another fiendish trap.");
                            trap++;
                            break;
                        case 4:
                            SetDebuff(player, type, doMsgs, POISON, 15, 200);
                            ModifyMana(player, type, doMsgs,  - 500);
                            while (HasItem(player, type, doMsgs, CURATIVEELIXIR))
                                RemoveItem(player, type, doMsgs, CURATIVEELIXIR);
                                ShowText(player, type, doMsgs, "You clumsily set off a gas trap.");
                                trap++;
                                break;
                            default:
                                DoDamage(player, type, doMsgs, GetHealthMax(player, type, doMsgs) / 5);
                                DisableHealing(player, type, doMsgs);
                                trap = 1;
                                DisableSpells(player, type, doMsgs);
                                ShowText(player, type, doMsgs, "A fierce whirlwind strikes you from some unseen sorcerer's hand!");
                                break;
                        }
                        SetFlag(player, type, doMsgs, FlagTypeParty, CASETRAP, trap);
                        SetFlag(player, type, doMsgs, FlagTypeTile, SPRUNGTRAP, 1);
                        SetFlag(player, type, doMsgs, FlagTypeParty, FOTEREBUS, 0);
                    }
                }
                protected override void FnEvent37(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    int i = 0;
                    ShowText(player, type, doMsgs, "Well-trained Night Elves guard these corridors.");
                    switch (GetPartyCount(player, type, doMsgs)) {
                        case 1:
                            for (i = 1; i <= 3; i++) {
                                AddEncounter(player, type, doMsgs, i, 34);
                            }
                            break;
                        case 2:
                            for (i = 1; i <= 2; i++) {
                                AddEncounter(player, type, doMsgs, i, 34);
                            }
                            for (i = 5; i <= 6; i++) {
                                AddEncounter(player, type, doMsgs, i, 34);
                            }
                            break;
                        default:
                            for (i = 1; i <= 6; i++) {
                                AddEncounter(player, type, doMsgs, i, 34);
                            }
                            break;
                    }
                }
                protected override void FnEvent38(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    ShowPortrait(player, type, doMsgs, DWARFKNIGHT);
                    ShowText(player, type, doMsgs, "An ancient Knight whispers, 'The leader must be removed to see the summit. And even though the spells of royalty be at the end, they shall be the first.'");
                }
                protected override void FnEvent39(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    ShowPortrait(player, type, doMsgs, ORCRANGER);
                    ShowText(player, type, doMsgs, "'The nine switches are used to open the way down to the next area. You must learn which switches to turn on.");
                    ShowText(player, type, doMsgs, "Having the nine switches set in unison will unlock the way for you.'");
                }
                protected override void FnEvent3A(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    ShowPortrait(player, type, doMsgs, FOUNTAIN);
                    ShowText(player, type, doMsgs, "The cool waters satisfy and enrich you.");
                    ModifyHealth(player, type, doMsgs, GetHealthMax(player, type, doMsgs));
                    ModifyMana(player, type, doMsgs, 2500);
                }
                protected override void FnEvent3B(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    int flag = 0;
                    int racecheck = 0;
                    racecheck = GetRace(player, type, doMsgs);
                    switch (racecheck) {
                        case HUMAN:
                            flag = TwIndexes.LEARNEDHUMAN;
                            break;
                        case ELF:
                            flag = TwIndexes.LEARNEDELF;
                            break;
                        case DWARF:
                            flag = TwIndexes.LEARNEDDWARF;
                            break;
                        case GNOME:
                            flag = TwIndexes.LEARNEDGNOME;
                            break;
                        case ORC:
                            flag = TwIndexes.LEARNEDORC;
                            break;
                        case TROLL:
                            flag = TwIndexes.LEARNEDTROLL;
                            break;
                        case HALFLING:
                            flag = TwIndexes.LEARNEDHALF;
                            break;
                        case GREMLIN:
                            flag = TwIndexes.LEARNEDGREMLIN;
                            break;
                    }
                    if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, flag) == 0)) {
                        SetFlag(player, type, doMsgs, FlagTypeDungeon, flag, 1);
                    }
                    if (HasItem(player, type, doMsgs, JESTERSCAP) && (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.CHOR_NPC_KILLED) == 0)) {
                        ShowText(player, type, doMsgs, "A maniacal fiend appears; removes an item you stole from him; and kills you outright.");
                        while (HasItem(player, type, doMsgs, JESTERSCAP))
                            RemoveItem(player, type, doMsgs, JESTERSCAP);
                            ModifyGold(player, type, doMsgs,  - 10000);
                            DoDamage(player, type, doMsgs, GetHealthMax(player, type, doMsgs));
                        }
                    }
                    protected override void FnEvent3C(TwPlayerServer player, MapEventType type, bool doMsgs) {
                        ShowText(player, type, doMsgs, "The door glows with a magical force.");
                        if (GetPartyCount(player, type, doMsgs) == 1) {
                            ShowText(player, type, doMsgs, "You may proceed alone.");
                            ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                        }
                        else {
                            ShowText(player, type, doMsgs, "You must enter here one at a time.");
                            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                        }
                    }
                }
            }
