namespace XPT.Twinion.Maps {
    class TwMap01 : TwMap {
        protected override int MapIndex => 1;
        protected override int MapID => 0x0102;
        protected override int RandomEncounterChance => 15;
        protected override int RandomEncounterExtraCount => 1;

        protected override void FnEvent01(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "The Door Reads: 'To Main Entrance.'");
            TELEPORT(player, type, doMsgs, 1, 1, 131, EAST);
        }
        protected override void FnEvent02(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "This will take you to the Gauntlet!");
            TELEPORT(player, type, doMsgs, 1, 3, 212, NORTH);
        }
        protected override void FnEvent03(TwPlayerServer player, MapEventType type, bool doMsgs) {
            CLEAR_WALL(player, type, doMsgs, HERE(), FACING());
            SHOW_TEXT(player, type, doMsgs, "HAIL! This is Gauntlet Gauche. Swirling waters and magical pits will be your guides to the gauntlet sought in Gauntlet Droit.");
            SHOW_TEXT(player, type, doMsgs, "A magical Gauntlet has been thrown down in the Coil Maze. This path will offer you a second ingress to that phase.");
        }
        protected override void FnEvent04(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 1, 2, 245, EAST);
        }
        protected override void FnEvent05(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short teleportroom;
            switch (HERE()) {
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
            TELEPORT(player, type, doMsgs, 1, 2, teleportroom, SOUTH);
        }
        protected override void FnEvent06(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "ONE WAY");
        }
        protected override void FnEvent07(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (USED_ITEM(player, type, doMsgs, GREENLOCKPICK, BLUELOCKPICK) || USED_SKILL(player, type, doMsgs, LOCKPICK_SKILL) > 1) {
                SHOW_TEXT(player, type, doMsgs, "You've picked the lock. Proceed.");
                CLEAR_WALL(player, type, doMsgs, HERE(), FACING());
            }
            else {
                BLOCK_WALL(player, type, doMsgs, HERE(), FACING());
                SHOW_TEXT(player, type, doMsgs, "A locked door impedes your progress here.");
            }
        }
        protected override void FnEvent08(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GUILD() == THIEF) {
                if (USED_ITEM(player, type, doMsgs, GREENLOCKPICK, BLUELOCKPICK) || USED_SKILL(player, type, doMsgs, LOCKPICK_SKILL) > 1) {
                    SHOW_TEXT(player, type, doMsgs, "Well done, sly thief. You may proceed.");
                    CLEAR_WALL(player, type, doMsgs, HERE(), FACING());
                }
                else {
                    BLOCK_WALL(player, type, doMsgs, HERE(), FACING());
                    SHOW_TEXT(player, type, doMsgs, "A locked door impedes your progress here.");
                }
            }
            else {
                BLOCK_WALL(player, type, doMsgs, HERE(), FACING());
                SHOW_TEXT(player, type, doMsgs, "Only a masterful thief can open this door.");
            }
        }
        protected override void FnEvent0A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            NO_JOIN();
        }
        protected override void FnEvent0B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Small pinholes of light seep through the cracks in the wall here.");
            if (USED_SKILL(player, type, doMsgs, DETECT_SKILL) >= 1 || USED_SPELL(player, type, doMsgs, TRUE_SEEING_SPELL) || USED_ITEM(player, type, doMsgs, CRYSTALBALL, CRYSTALBALL) || USED_ITEM(player, type, doMsgs, VALKYRIESHELM, VALKYRIESHELM) || USED_ITEM(player, type, doMsgs, RINGOFTHIEVES, RINGOFTHIEVES) || USED_ITEM(player, type, doMsgs, HELMOFWISDOM, HELMOFWISDOM)) {
                PLACE_WALL_ITEM(player, type, doMsgs, DOOR, HERE(), FACING());
                SHOW_TEXT(player, type, doMsgs, "You've uncovered a hidden door!");
                CLEAR_WALL(player, type, doMsgs, HERE(), FACING());
            }
            else {
                BLOCK_WALL(player, type, doMsgs, HERE(), FACING());
                REMOVE_WALL_ITEM(player, type, doMsgs, HERE(), FACING());
            }
        }
        protected override void FnEvent0C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT() == 1) {
                CLEAR_WALL(player, type, doMsgs, HERE(), FACING());
                SHOW_TEXT(player, type, doMsgs, "You hear roaring waters on the other side of this gateway.");
            }
            else {
                BLOCK_WALL(player, type, doMsgs, HERE(), FACING());
                SHOW_TEXT(player, type, doMsgs, "The narrow door forces you to disband and enter alone.");
            }
        }
        protected override void FnEvent0D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short pfv;
            pfv = GET_FLAG(player, type, doMsgs, PARTY, BATSCAVE);
            switch (HERE()) {
                case 94:
                    NO_MAPS();
                    if (pfv <= 94 && pfv != 0) {
                        BatText(player, type, doMsgs);
                    }
                    else {
                        GET_MONSTER(player, type, doMsgs, 1, 7);
                    }
                    break;
                case 79:
                    NO_MAPS();
                    if (pfv <= 79 && pfv != 0) {
                        BatText(player, type, doMsgs);
                    }
                    else {
                        GET_MONSTER(player, type, doMsgs, 1, 7);
                    }
                    break;
                case 63:
                    NO_MAPS();
                    if (pfv <= 63 && pfv != 0) {
                        BatText(player, type, doMsgs);
                    }
                    else {
                        GET_MONSTER(player, type, doMsgs, 1, 3);
                    }
                    break;
                case 46:
                    TorchTxt(player, type, doMsgs);
                    if (pfv <= 46 && pfv != 0) {
                        BatText(player, type, doMsgs);
                    }
                    else {
                        GET_MONSTER(player, type, doMsgs, 1, 7);
                    }
                    break;
                case 47:
                    TorchTxt(player, type, doMsgs);
                    if (pfv == 47 && pfv != 0) {
                        BatText(player, type, doMsgs);
                    }
                    else {
                        GET_MONSTER(player, type, doMsgs, 1, 3);
                    }
                    break;
            }
            SET_FLAG(player, type, doMsgs, PARTY, BATSCAVE, HERE());
        }
        private void TorchTxt(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Flickering torches offer dim light, allowing you to see your way from here.");
        }
        private void BatText(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "The bats seem to have calmed down here.");
        }
        protected override void FnEvent0E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            NO_MAPS();
            if (!GET_FLAG(player, type, doMsgs, ROOM, SPRUNGTRAP)) {
                DAMAGE(player, type, doMsgs, MAX_HEALTH(),  / , 6);
                if (HEALTH() > 0) {
                    SHOW_TEXT(player, type, doMsgs, "You must wade through a pool of guano here. The noxious odors are damaging to you.");
                    SET_FLAG(player, type, doMsgs, ROOM, SPRUNGTRAP, 1);
                }
            }
        }
        protected override void FnEvent0F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SET_FLAG(player, type, doMsgs, PARTY, BATSCAVE, 100);
            SHOW_TEXT(player, type, doMsgs, "Eastward, an ornate hallway has been infested with various kinds of bats. They cling to the ceiling and issue shrill chirps to the point of madness.");
            SHOW_TEXT(player, type, doMsgs, "A thick layer of leathery wings blocks out the light in the eastern hall. You will be unable to map the area. Proceed with caution!");
        }
        protected override void FnEvent10(TwPlayerServer player, MapEventType type, bool doMsgs) {
            NO_MAPS();
            if (!GET_FLAG(player, type, doMsgs, DUNGEON, BATCAVE)) {
                SHOW_TEXT(player, type, doMsgs, "A stash of booty and coins comprises the bats' treasure room.");
                GIVE_ITEM(player, type, doMsgs, AXE);
                GIVE_ITEM(player, type, doMsgs, BUCKLER);
                GIVE_ITEM(player, type, doMsgs, GREENLOCKPICK);
                GIVE_ITEM(player, type, doMsgs, HEALPOTION);
                MOD_GOLD(player, type, doMsgs, 300);
                MOD_EXP(player, type, doMsgs, 250);
                SET_FLAG(player, type, doMsgs, DUNGEON, BATCAVE, 1);
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "There's nothing more here.");
            }
        }
        protected override void FnEvent11(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (!GET_FLAG(player, type, doMsgs, PARTY, READPITMESS)) {
                SHOW_TEXT(player, type, doMsgs, "The floor is filled with glowing pits. These will provide you with shortcuts to various areas of this level.");
                SHOW_TEXT(player, type, doMsgs, "Continue, if you dare to chance it.");
                SET_FLAG(player, type, doMsgs, PARTY, READPITMESS, 1);
            }
        }
        protected override void FnEvent12(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short pfv;
            pfv = GET_FLAG(player, type, doMsgs, PARTY, NPCINHALL);
            if (STATE() != HERE()) {
                if (pfv == 0) {
                    pfv = 1;
                }
                switch (pfv) {
                    case 1:
                        PicShow(player, type, doMsgs);
                        SHOW_TEXT(player, type, doMsgs, "'Greetings to you! This is one of two mazes which comprise the Gauntlet quest.");
                        SHOW_TEXT(player, type, doMsgs, "Explore the area thoroughly, there are many shortcuts to help you here.'");
                        pfv = 2;
                        break;
                    case 2:
                        PicShow(player, type, doMsgs);
                        SHOW_TEXT(player, type, doMsgs, "'Might I be of service again?");
                        SHOW_TEXT(player, type, doMsgs, "In the north is a series of pits that will offer you rapid progression.");
                        SHOW_TEXT(player, type, doMsgs, "The bats in the north east are horrible, but rewarding.'");
                        pfv = 3;
                        break;
                    case 3:
                        PicShow(player, type, doMsgs);
                        SHOW_TEXT(player, type, doMsgs, "'You want more info?...Hmmm, let's see...ah yes! How could I have forgotten!");
                        SHOW_TEXT(player, type, doMsgs, "Find your way to the south and east. The Snake River will grant you a quick way to the Coil Maze.'");
                        pfv = 4;
                        default:
                            PicShow(player, type, doMsgs);
                            SHOW_TEXT(player, type, doMsgs, "'I can offer you no more advice. It's up to you which path you choose. But in time, all things come upon themselves.'");
                            pfv = 1;
                            break;
                    }
                    SET_FLAG(player, type, doMsgs, PARTY, NPCINHALL, pfv);
                    SET_STATE(player, type, doMsgs, HERE());
                }
            }
            private void PicShow(TwPlayerServer player, MapEventType type, bool doMsgs) {
                SHOW_PICTURE(player, type, doMsgs, HUMANWIZARD);
            }
            protected override void FnEvent13(TwPlayerServer player, MapEventType type, bool doMsgs) {
                if (!GET_FLAG(player, type, doMsgs, DUNGEON, THIEFBOOTY) || GET_FLAG(player, type, doMsgs, DUNGEON, THIEFBOOTY) != 2 && GET_FLAG(player, type, doMsgs, DUNGEON, THIEFBOOTY) != HERE()) {
                    SHOW_TEXT(player, type, doMsgs, "You come across a stash of useful items!");
                    if (GUILD() == THIEF) {
                        GIVE_ITEM(player, type, doMsgs, SHORTBOW);
                        GIVE_ITEM(player, type, doMsgs, CRYSTALBALL);
                        GIVE_ITEM(player, type, doMsgs, BERSERKERTALISMAN);
                        GIVE_ITEM(player, type, doMsgs, HEALPOTION);
                        MOD_GOLD(player, type, doMsgs, 250);
                        MOD_EXP(player, type, doMsgs, 100);
                    }
                    else {
                        GIVE_ITEM(player, type, doMsgs, MANAPOTION);
                        GIVE_ITEM(player, type, doMsgs, HEALPOTION);
                        MOD_GOLD(player, type, doMsgs, 100);
                        MOD_EXP(player, type, doMsgs, 50);
                    }
                    if (GET_FLAG(player, type, doMsgs, DUNGEON, THIEFBOOTY) == 230) {
                        SET_FLAG(player, type, doMsgs, DUNGEON, THIEFBOOTY, 2);
                    }
                    else {
                        SET_FLAG(player, type, doMsgs, DUNGEON, THIEFBOOTY, HERE());
                    }
                }
                else {
                    SHOW_TEXT(player, type, doMsgs, "There's nothing more here.");
                }
            }
            protected override void FnEvent14(TwPlayerServer player, MapEventType type, bool doMsgs) {
                if (!GET_FLAG(player, type, doMsgs, DUNGEON, THIEFBOOTY) || GET_FLAG(player, type, doMsgs, DUNGEON, THIEFBOOTY) != 2 && GET_FLAG(player, type, doMsgs, DUNGEON, THIEFBOOTY) != HERE()) {
                    SHOW_TEXT(player, type, doMsgs, "You come across a stash of useful items!");
                    if (GUILD() == THIEF) {
                        GIVE_ITEM(player, type, doMsgs, HAWKSEYE);
                        GIVE_ITEM(player, type, doMsgs, SCROLLOFTHESUN);
                        GIVE_ITEM(player, type, doMsgs, TRANCETALISMAN);
                        GIVE_ITEM(player, type, doMsgs, HEALPOTION);
                        MOD_GOLD(player, type, doMsgs, 250);
                        MOD_EXP(player, type, doMsgs, 100);
                    }
                    else {
                        GIVE_ITEM(player, type, doMsgs, MANAPOTION);
                        GIVE_ITEM(player, type, doMsgs, HEALPOTION);
                        MOD_GOLD(player, type, doMsgs, 100);
                        MOD_EXP(player, type, doMsgs, 50);
                    }
                    if (GET_FLAG(player, type, doMsgs, DUNGEON, THIEFBOOTY) == 159) {
                        SET_FLAG(player, type, doMsgs, DUNGEON, THIEFBOOTY, 2);
                    }
                    else {
                        SET_FLAG(player, type, doMsgs, DUNGEON, THIEFBOOTY, HERE());
                    }
                }
                else {
                    SHOW_TEXT(player, type, doMsgs, "There's nothing more here.");
                }
            }
            protected override void FnEvent15(TwPlayerServer player, MapEventType type, bool doMsgs) {
                GET_MONSTER(player, type, doMsgs, 01, 30);
                GET_MONSTER(player, type, doMsgs, 02, 29);
            }
            protected override void FnEvent16(TwPlayerServer player, MapEventType type, bool doMsgs) {
                GET_MONSTER(player, type, doMsgs, 01, 34);
                GET_MONSTER(player, type, doMsgs, 02, 35);
            }
            protected override void FnEvent17(TwPlayerServer player, MapEventType type, bool doMsgs) {
                short i;
                if (!GET_FLAG(player, type, doMsgs, PARTY, PFBATTLE)) {
                    SET_BOOTY(player, type, doMsgs, HEALPOTION, CRYSTALBALL, 0, 0, 0, 25);
                    for (i = 1; i <= 2; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 39);
                    }
                    SET_FLAG(player, type, doMsgs, PARTY, PFBATTLE, 1);
                }
                else if (GET_FLAG(player, type, doMsgs, PARTY, PFBATTLE) == 1) {
                    for (i = 1; i <= 3; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 26);
                    }
                    SET_FLAG(player, type, doMsgs, PARTY, PFBATTLE, 2);
                }
                else if (GET_FLAG(player, type, doMsgs, PARTY, PFBATTLE) == 2) {
                    for (i = 1; i <= 5; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 32);
                    }
                    SET_FLAG(player, type, doMsgs, PARTY, PFBATTLE, 0);
                }
            }
            protected override void FnEvent18(TwPlayerServer player, MapEventType type, bool doMsgs) {
                short i;
                switch (PARTY_COUNT()) {
                    case 1:
                        GET_MONSTER(player, type, doMsgs, 1, 38);
                        break;
                    case 2:
                        for (i = 1; i <= 3; i++) {
                            GET_MONSTER(player, type, doMsgs, i, 25);
                        }
                        break;
                    default:
                        for (i = 1; i <= 5; i++) {
                            GET_MONSTER(player, type, doMsgs, i, 35);
                        }
                        break;
                }
            }
            protected override void FnEvent19(TwPlayerServer player, MapEventType type, bool doMsgs) {
                TELEPORT(player, type, doMsgs, 1, 2, 15, WEST);
            }
            protected override void FnEvent1A(TwPlayerServer player, MapEventType type, bool doMsgs) {
                SHOW_PICTURE(player, type, doMsgs, FOUNTAIN);
                SHOW_TEXT(player, type, doMsgs, "The magical waters are refreshing.");
                HEAL(player, type, doMsgs, HEALTH());
            }
            protected override void FnEvent1B(TwPlayerServer player, MapEventType type, bool doMsgs) {
                SHOW_PICTURE(player, type, doMsgs, FOUNTAIN);
                SHOW_TEXT(player, type, doMsgs, "Clear blue waters restore your mana!");
                MOD_MANA(player, type, doMsgs, 100);
            }
            protected override void FnEvent1C(TwPlayerServer player, MapEventType type, bool doMsgs) {
                short pfv;
                if (GET_FLAG(player, type, doMsgs, PARTY, BIZARRE) == 50 && !GET_FLAG(player, type, doMsgs, DUNGEON, WIERDO)) {
                    SHOW_TEXT(player, type, doMsgs, "You've done something bizarre! Here's your reward!");
                    GIVE_ITEM(player, type, doMsgs, GAUNTLETSOFMERCY);
                    GIVE_ITEM(player, type, doMsgs, SILVERBAR);
                    MOD_EXP(player, type, doMsgs, 1000);
                    MOD_GOLD(player, type, doMsgs, 1000);
                    SET_FLAG(player, type, doMsgs, DUNGEON, WIERDO, 1);
                }
                else {
                    pfv = GET_FLAG(player, type, doMsgs, PARTY, BIZARRE);
                    pfv = pfv++;
                    SET_FLAG(player, type, doMsgs, PARTY, BIZARRE, pfv);
                }
            }
            protected override void FnEvent1D(TwPlayerServer player, MapEventType type, bool doMsgs) {
                short portroom;
                short face;
                short ww;
                ww = GET_FLAG(player, type, doMsgs, PARTY, WHICHWAY);
                SHOW_TEXT(player, type, doMsgs, "The magic waters pull you onward!");
                if (ww == 1) {
                    switch (HERE()) {
                        case 236:
                            portroom = 252;
                            face = SOUTH;
                            break;
                        case 252:
                            portroom = 253;
                            face = EAST;
                            break;
                        case 253:
                            portroom = 237;
                            face = NORTH;
                            break;
                        case 237:
                            portroom = 221;
                            face = NORTH;
                            break;
                        case 221:
                            portroom = 222;
                            face = EAST;
                            break;
                        case 222:
                            portroom = 238;
                            face = SOUTH;
                            break;
                        case 238:
                            portroom = 254;
                            face = SOUTH;
                            break;
                        case 254:
                            portroom = 255;
                            face = EAST;
                            break;
                        case 255:
                            portroom = 239;
                            face = NORTH;
                            break;
                        case 239:
                            portroom = 223;
                            face = NORTH;
                            break;
                    }
                    ROTATE(player, type, doMsgs, face);
                    TELEPORT(player, type, doMsgs, 1, 2, portroom, face);
                }
                else if (ww == 2) {
                    switch (HERE()) {
                        case 236:
                            portroom = 220;
                            face = NORTH;
                            break;
                        case 252:
                            portroom = 236;
                            face = NORTH;
                            break;
                        case 253:
                            portroom = 252;
                            face = WEST;
                            break;
                        case 237:
                            portroom = 253;
                            face = SOUTH;
                            break;
                        case 221:
                            portroom = 237;
                            face = SOUTH;
                            break;
                        case 222:
                            portroom = 221;
                            face = WEST;
                            break;
                        case 238:
                            portroom = 222;
                            face = NORTH;
                            break;
                        case 254:
                            portroom = 238;
                            face = NORTH;
                            break;
                        case 255:
                            portroom = 254;
                            face = WEST;
                            break;
                        case 239:
                            portroom = 255;
                            face = SOUTH;
                            break;
                    }
                    ROTATE(player, type, doMsgs, face);
                    TELEPORT(player, type, doMsgs, 1, 2, portroom, face);
                }
            }
            protected override void FnEvent1E(TwPlayerServer player, MapEventType type, bool doMsgs) {
                special10(player, type, doMsgs);
                SET_FLAG(player, type, doMsgs, PARTY, WHICHWAY, 1);
                SHOW_TEXT(player, type, doMsgs, "An unstable platform forces you to stand alone at the western edge of Snake River.");
            }
            protected override void FnEvent1F(TwPlayerServer player, MapEventType type, bool doMsgs) {
                TELEPORT(player, type, doMsgs, 1, 2, 0, SOUTH);
            }
            protected override void FnEvent20(TwPlayerServer player, MapEventType type, bool doMsgs) {
                TELEPORT(player, type, doMsgs, 1, 2, 145, NORTH);
            }
            protected override void FnEvent21(TwPlayerServer player, MapEventType type, bool doMsgs) {
                special10(player, type, doMsgs);
                SET_FLAG(player, type, doMsgs, PARTY, WHICHWAY, 2);
                SHOW_TEXT(player, type, doMsgs, "You are at the eastern end of Snake River.");
            }
            private void RiverTxt(TwPlayerServer player, MapEventType type, bool doMsgs) {
                SHOW_TEXT(player, type, doMsgs, "Magical forces hurl water southward and around the bend. The overwhelming noise is hypnotic and painful.");
            }
            protected override void FnEvent22(TwPlayerServer player, MapEventType type, bool doMsgs) {
                RiverTxt(player, type, doMsgs);
            }
            protected override void FnEvent23(TwPlayerServer player, MapEventType type, bool doMsgs) {
                RiverTxt(player, type, doMsgs);
            }
            protected override void FnEvent24(TwPlayerServer player, MapEventType type, bool doMsgs) {
                TELEPORT(player, type, doMsgs, 1, 2, 2, WEST);
            }
            protected override void FnEvent25(TwPlayerServer player, MapEventType type, bool doMsgs) {
                SET_STATE(player, type, doMsgs, 0);
            }
            protected override void FnEvent26(TwPlayerServer player, MapEventType type, bool doMsgs) {
                SHOW_TEXT(player, type, doMsgs, "Look at me again to gain more information!");
                if (GET_FLAG(player, type, doMsgs, PARTY, LOCKEDDOOR) == 0) {
                    SHOW_TEXT(player, type, doMsgs, "The door to the west is locked, but no lockpick can help you here! You must learn to use what is at hand in a more creative fashion.");
                    SET_FLAG(player, type, doMsgs, PARTY, LOCKEDDOOR, 1);
                }
                else if (GET_FLAG(player, type, doMsgs, PARTY, LOCKEDDOOR) == 1) {
                    SHOW_TEXT(player, type, doMsgs, "You must use something...something that could hack the lock off the door. Do not constrain yourself from using your belongings in a new way!");
                    SET_FLAG(player, type, doMsgs, PARTY, LOCKEDDOOR, 2);
                }
                else if (GET_FLAG(player, type, doMsgs, PARTY, LOCKEDDOOR) == 2) {
                    SHOW_TEXT(player, type, doMsgs, "Use a weapon, a sword or an axe, some form of blade or bludgeon, and you will be able to knock the lock off.");
                    SET_FLAG(player, type, doMsgs, PARTY, LOCKEDDOOR, 0);
                }
            }
            protected override void FnEvent27(TwPlayerServer player, MapEventType type, bool doMsgs) {
                if (USED_ITEM(player, type, doMsgs, SHORTSWORD, DISRUPTOR)) {
                    SHOW_TEXT(player, type, doMsgs, "You've broken the lock! You may now enter and gain experience from your actions!");
                    CLEAR_WALL(player, type, doMsgs, HERE(), FACING());
                }
            }
            protected override void FnEvent28(TwPlayerServer player, MapEventType type, bool doMsgs) {
                if (!GET_FLAG(player, type, doMsgs, DUNGEON, BROKEDOOR)) {
                    SHOW_TEXT(player, type, doMsgs, "Well done! Gain in experience and line your pockets with gold! Remember, there are more ways to use what you have than you remember.");
                    MOD_EXP(player, type, doMsgs, 200);
                    MOD_GOLD(player, type, doMsgs, 100);
                    SET_FLAG(player, type, doMsgs, DUNGEON, BROKEDOOR, 1);
                }
                else {
                    SHOW_TEXT(player, type, doMsgs, "You've gained all you can from this test. You are welcome to bash the magical lock as often as you wish.");
                }
            }
            protected override void FnEvent29(TwPlayerServer player, MapEventType type, bool doMsgs) {
                SHOW_TEXT(player, type, doMsgs, "Look at me again to gain more information!");
                if (GET_FLAG(player, type, doMsgs, PARTY, FIREDOOR) == 0) {
                    SHOW_TEXT(player, type, doMsgs, "The door to the east is locked, but no lockpick can help you here! You must learn to use what is at hand in a more creative fashion.");
                    SET_FLAG(player, type, doMsgs, PARTY, FIREDOOR, 1);
                }
                else if (GET_FLAG(player, type, doMsgs, PARTY, FIREDOOR) == 1) {
                    SHOW_TEXT(player, type, doMsgs, "You must use something...something that could fire the lock off the door. Do not constrain yourself from using your belongings in a new way!");
                    SET_FLAG(player, type, doMsgs, PARTY, FIREDOOR, 2);
                }
                else if (GET_FLAG(player, type, doMsgs, PARTY, FIREDOOR) == 2) {
                    SHOW_TEXT(player, type, doMsgs, "Use a scroll that would cast a magical force, capable of incinerating or blowing the door away!");
                    SET_FLAG(player, type, doMsgs, PARTY, FIREDOOR, 0);
                }
            }
            protected override void FnEvent2A(TwPlayerServer player, MapEventType type, bool doMsgs) {
                if (USED_ITEM(player, type, doMsgs, SHAMANSCROLL, SHAMANSCROLL) || USED_ITEM(player, type, doMsgs, PUMMELSCROLL, PUMMELSCROLL) || USED_ITEM(player, type, doMsgs, CRYSTALSCROLL, CRYSTALSCROLL) || USED_ITEM(player, type, doMsgs, SCROLLOFWIND, SCROLLOFWIND) || USED_ITEM(player, type, doMsgs, BOWOFFLAMES, BOWOFFLAMES) || USED_ITEM(player, type, doMsgs, AEGISDDRACO, AEGISDDRACO) || USED_ITEM(player, type, doMsgs, NEROSLYRE, NEROSLYRE) || USED_ITEM(player, type, doMsgs, SCROLLOFTHESUN, SCROLLOFTHESUN) || USED_ITEM(player, type, doMsgs, SCORCHEDSCROLL, SCORCHEDSCROLL)) {
                    SHOW_TEXT(player, type, doMsgs, "You've incinerated the door! Now you may enter and gain wisdom from your accomplishment.");
                    CLEAR_WALL(player, type, doMsgs, HERE(), FACING());
                }
                else {
                    BLOCK_WALL(player, type, doMsgs, HERE(), FACING());
                }
            }
            protected override void FnEvent2B(TwPlayerServer player, MapEventType type, bool doMsgs) {
                if (!GET_FLAG(player, type, doMsgs, DUNGEON, FLAMEDOOR)) {
                    SHOW_TEXT(player, type, doMsgs, "Well done! Gain in experience and line your pockets with gold! Remember, there are more ways to use what you have than you remember.");
                    MOD_EXP(player, type, doMsgs, 200);
                    MOD_GOLD(player, type, doMsgs, 100);
                    SET_FLAG(player, type, doMsgs, DUNGEON, FLAMEDOOR, 1);
                }
                else {
                    SHOW_TEXT(player, type, doMsgs, "You've gained all you can from this test. You are welcome to destroy the magical door as often as you wish.");
                }
            }
            protected override void FnEvent2C(TwPlayerServer player, MapEventType type, bool doMsgs) {
                short pfv;
                pfv = GET_FLAG(player, type, doMsgs, PARTY, NPC2INHALL);
                if (STATE() != HERE()) {
                    if (pfv == 0) {
                        pfv = 1;
                    }
                    switch (pfv) {
                        case 1:
                            SHOW_PICTURE(player, type, doMsgs, DWARFWIZARD);
                            SHOW_TEXT(player, type, doMsgs, "You pass by a dwarf regaling some companions. 'I was trying to find a way across Lake Deluge or Desperate - something like that.");
                            SHOW_TEXT(player, type, doMsgs, "Anyway, I stepped on a spot and I tell you, if I hadn't had the Life Jacket, I wouldn't be here today!'");
                            pfv = 2;
                            break;
                        case 2:
                            SHOW_PICTURE(player, type, doMsgs, GNOMEBARBARIAN);
                            SHOW_TEXT(player, type, doMsgs, "A barbarian is lamenting with a companion over something he lost. 'I know I had it not long ago! That knight told us we needed the key to enter those secret rooms.");
                            SHOW_TEXT(player, type, doMsgs, "We must find it! Hmmm, we did search that place on Lake Despair. Let's try looking back there.'");
                            SHOW_TEXT(player, type, doMsgs, "With that, they hurry off to other adventures.");
                            pfv = 3;
                            break;
                        default:
                            SHOW_PICTURE(player, type, doMsgs, HALFLINGTHIEF);
                            SHOW_TEXT(player, type, doMsgs, "A thief emerges from the shadows, 'There's an area in the Night Elves' Domain where the magic used to construct the walls will drive you to the fringe of madness!");
                            SHOW_TEXT(player, type, doMsgs, "Never have I seen the likes of these magical walls. I saw nothing, yet my path was blocked! Fret not, there is a hidden exit...though I fear this is not the last of the nightmare.");
                            pfv = 1;
                            break;
                    }
                    SET_FLAG(player, type, doMsgs, PARTY, NPC2INHALL, pfv);
                    SET_STATE(player, type, doMsgs, HERE());
                }
            }
        }
    }
