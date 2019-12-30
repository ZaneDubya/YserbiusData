using XPT.Generic.Maps;
using XPT.Twinion.Entities;

namespace XPT.Twinion.Maps {
    class TwMap28 : TwMap {
        protected override int MapIndex => 28;
        protected override int MapID => 0x0B03;
        protected override int RandomEncounterChance => 5;
        protected override int RandomEncounterExtraCount => 2;

        protected override void FnEvent01(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Astral material permeates this place");
        }
        protected override void FnEvent02(TwPlayerServer player, MapEventType type, bool doMsgs) {
            CLEAR_WALL(player, type, doMsgs, HERE(), FACING());
        }
        protected override void FnEvent03(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "This teleport is riddled with archaic markings.");
            TELEPORT(player, type, doMsgs, 11, 4, 60, NORTH);
        }
        protected override void FnEvent05(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short itemA = 0;
            short itemB = 0;
            short manapts = 0;
            short pool;
            pool = GET_FLAG(player, type, doMsgs, DUNGEON, POOLNUMBER);
            DamageBy6(player, type, doMsgs);
            if (HEALTH() > 0) {
                NoSpellZone(player, type, doMsgs);
                switch (HERE()) {
                    case 2:
                        pool = 1;
                        itemA = GOLDBAR;
                        itemB = SPIKEDSHIELD;
                        break;
                    case 3:
                        pool = 2;
                        itemA = SLIVERBAR;
                        itemB = TWOHANDEDSWORD;
                        manapts = 1000;
                        break;
                    case 6:
                        pool = 3;
                        itemA = NIGHTELFHELM;
                        itemB = MANAAMPHORA;
                        manapts = 3000;
                        break;
                    case 22:
                        pool = 4;
                        itemA = IRONCUTLASS;
                        itemB = BUCKLER;
                        manapts =  - 350;
                        break;
                }
                if (GET_FLAG(player, type, doMsgs, DUNGEON, POOLNUMBER) == pool) {
                    SHOW_TEXT(player, type, doMsgs, "The clear waters let you see treasure in the pool's bottom.");
                    GIVE_ITEM(player, type, doMsgs, itemA);
                    GIVE_ITEM(player, type, doMsgs, itemB);
                    MOD_MANA(player, type, doMsgs, manapts);
                    pool++;
                    SET_FLAG(player, type, doMsgs, DUNGEON, POOLNUMBER, pool);
                }
                else {
                    SHOW_TEXT(player, type, doMsgs, "The pool's waters are cloudy, perhaps they will be clear later.");
                }
            }
        }
        protected override void FnEvent06(TwPlayerServer player, MapEventType type, bool doMsgs) {
            NoSpellZone(player, type, doMsgs);
            NO_HEAL_ZONE();
            if (!GET_FLAG(player, type, doMsgs, ROOM, SPRUNGTRAP)) {
                DAMAGE(player, type, doMsgs, HEALTH() / 8);
                SHOW_TEXT(player, type, doMsgs, "The seething lava scorches you.");
                SprungTrap(player, type, doMsgs);
            }
        }
        protected override void FnEvent07(TwPlayerServer player, MapEventType type, bool doMsgs) {
            BLOCK_WALL(player, type, doMsgs, HERE(), FACING());
        }
        protected override void FnEvent09(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "To Astelligus!");
            TELEPORT(player, type, doMsgs, 11, 4, 114, EAST);
        }
        protected override void FnEvent0A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short i;
            if (!GET_FLAG(player, type, doMsgs, DUNGEON, DIDASTRAL)) {
                if (HAS_ITEM(player, type, doMsgs, NIMBUSOFTHEFATES)) {
                    Nothing(player, type, doMsgs);
                }
                else {
                    SHOW_TEXT(player, type, doMsgs, "The Nimbus of the Fates is in a glass case on the southern wall. You need only defeat those who guard it.");
                }
            }
            switch (PARTY_COUNT()) {
                case 1:
                case 2:
                    for (i = 1; i <= 2; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 40);
                    }
                    break;
                default:
                    for (i = 1; i <= 5; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 40);
                    }
                    break;
            }
        }
        protected override void FnEvent0B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (!GET_FLAG(player, type, doMsgs, DUNGEON, DIDASTRAL)) {
                if (HAS_ITEM(player, type, doMsgs, NIMBUSOFTHEFATES)) {
                    Nothing(player, type, doMsgs);
                }
                else if (!HAS_ITEM(player, type, doMsgs, NIMBUSOFTHEFATES)) {
                    SHOW_TEXT(player, type, doMsgs, "You take the Nimbus of the Fates.");
                    SHOW_TEXT(player, type, doMsgs, "With it, you may face Astelligus.");
                    GIVE_ITEM(player, type, doMsgs, NIMBUSOFTHEFATES);
                    if (!GET_FLAG(player, type, doMsgs, DUNGEON, GOTASTRALITEM) || GET_FLAG(player, type, doMsgs, DUNGEON, GOTASTRALITEM) == 1) {
                        SHOW_TEXT(player, type, doMsgs, "Gain in experience from your accomplishment!");
                        MOD_EXP(player, type, doMsgs, 650000);
                        SET_FLAG(player, type, doMsgs, DUNGEON, GOTASTRALITEM, 2);
                    }
                }
            }
            else {
                Nothing(player, type, doMsgs);
            }
        }
        protected override void FnEvent0C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short port1;
            short port2;
            short facing1;
            short facing2;
            Compass(player, type, doMsgs);
            if (PARTY_LEADER()) {
                switch (FACING()) {
                    case NORTH:
                        port1 = 153;
                        port2 = 157;
                        facing1 = EAST;
                        facing2 = NORTH;
                        break;
                    case SOUTH:
                        port1 = 217;
                        if ((GET_FLAG(player, type, doMsgs, DUNGEON, GOTASTRALITEM) == 2) || (HAS_ITEM(player, type, doMsgs, NIMBUSOFTHEFATES))) {
                            if (GET_FLAG(player, type, doMsgs, PARTY, WHEREWEREYOU) == HERE()) {
                                port2 = 157;
                            }
                            else {
                                port2 = 222;
                            }
                        }
                        facing1 = WEST;
                        facing2 = SOUTH;
                        break;
                    case EAST:
                        port1 = 217;
                        port2 = 157;
                        facing1 = EAST;
                        facing2 = NORTH;
                        break;
                    case WEST:
                        if ((GET_FLAG(player, type, doMsgs, DUNGEON, GOTASTRALITEM) <= 1) || (!HAS_ITEM(player, type, doMsgs, NIMBUSOFTHEFATES))) {
                            if (GET_FLAG(player, type, doMsgs, PARTY, WHEREWEREYOU) == HERE()) {
                                port1 = 232;
                            }
                            else {
                                port1 = 217;
                            }
                        }
                        port2 = 153;
                        facing1 = NORTH;
                        facing2 = WEST;
                        break;
                }
                if (GET_FLAG(player, type, doMsgs, DUNGEON, GOTASTRALITEM) <= 1 || !HAS_ITEM(player, type, doMsgs, NIMBUSOFTHEFATES)) {
                    TELEPORT(player, type, doMsgs, 11, 3, port1, facing1);
                }
                else if (HAS_ITEM(player, type, doMsgs, NIMBUSOFTHEFATES)) {
                    TELEPORT(player, type, doMsgs, 11, 3, port2, facing2);
                }
            }
        }
        protected override void FnEvent0D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short port1;
            short port2;
            short facing1;
            short facing2;
            Compass(player, type, doMsgs);
            switch (FACING()) {
                case WEST:
                    port1 = 153;
                    port2 = 157;
                    facing1 = EAST;
                    facing2 = NORTH;
                    break;
                case EAST:
                    port2 = 153;
                    if (GET_FLAG(player, type, doMsgs, PARTY, WHEREWEREYOU) == 255) {
                        port1 = 157;
                    }
                    else {
                        port1 = 217;
                    }
                    facing1 = WEST;
                    facing2 = SOUTH;
                    break;
                case SOUTH:
                    port1 = 237;
                    port2 = 157;
                    facing1 = EAST;
                    facing2 = NORTH;
                    break;
                case NORTH:
                    if (GET_FLAG(player, type, doMsgs, PARTY, WHEREWEREYOU) == 255) {
                        port2 = 172;
                    }
                    else {
                        port2 = 207;
                    }
                    port1 = 153;
                    facing1 = NORTH;
                    facing2 = WEST;
                    break;
            }
            if (GET_FLAG(player, type, doMsgs, DUNGEON, GOTASTRALITEM) <= 1 || !HAS_ITEM(player, type, doMsgs, NIMBUSOFTHEFATES)) {
                TELEPORT(player, type, doMsgs, 11, 3, port1, facing1);
            }
            else {
                TELEPORT(player, type, doMsgs, 11, 3, port2, facing2);
            }
        }
        protected override void FnEvent0E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short port1;
            short port2;
            short facing1;
            short facing2;
            Compass(player, type, doMsgs);
            switch (FACING()) {
                case SOUTH:
                    port1 = 232;
                    port2 = 157;
                    facing1 = EAST;
                    facing2 = NORTH;
                    break;
                case NORTH:
                    port2 = 217;
                    if (GET_FLAG(player, type, doMsgs, PARTY, WHEREWEREYOU) == 255) {
                        port1 = 168;
                    }
                    else {
                        port1 = 153;
                    }
                    facing1 = WEST;
                    facing2 = SOUTH;
                    break;
                case EAST:
                    port1 = 217;
                    port2 = 157;
                    facing1 = EAST;
                    facing2 = NORTH;
                    break;
                case WEST:
                    port1 = 222;
                    port2 = 153;
                    facing1 = NORTH;
                    facing2 = WEST;
                    break;
            }
            if (GET_FLAG(player, type, doMsgs, DUNGEON, GOTASTRALITEM) <= 1 || !HAS_ITEM(player, type, doMsgs, NIMBUSOFTHEFATES)) {
                TELEPORT(player, type, doMsgs, 11, 3, port1, facing1);
            }
            else {
                TELEPORT(player, type, doMsgs, 11, 3, port2, facing2);
            }
        }
        protected override void FnEvent0F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short port1;
            short port2;
            short facing1;
            short facing2;
            Compass(player, type, doMsgs);
            switch (FACING()) {
                case NORTH:
                    port1 = 232;
                    port2 = 157;
                    facing1 = EAST;
                    facing2 = NORTH;
                    break;
                case SOUTH:
                    port2 = 157;
                    if (GET_FLAG(player, type, doMsgs, PARTY, WHEREWEREYOU) == 255) {
                        port1 = 198;
                    }
                    else {
                        port1 = 158;
                    }
                    facing1 = WEST;
                    facing2 = SOUTH;
                    break;
                case EAST:
                    port1 = 157;
                    if (GET_FLAG(player, type, doMsgs, PARTY, WHEREWEREYOU) == 255) {
                        port2 = 175;
                    }
                    else {
                        port2 = 232;
                    }
                    facing1 = WEST;
                    facing2 = SOUTH;
                    break;
                case WEST:
                    port1 = 187;
                    port2 = 228;
                    facing1 = NORTH;
                    facing2 = WEST;
                    break;
            }
            if (GET_FLAG(player, type, doMsgs, DUNGEON, GOTASTRALITEM) <= 1 || !HAS_ITEM(player, type, doMsgs, NIMBUSOFTHEFATES)) {
                TELEPORT(player, type, doMsgs, 11, 3, port1, facing1);
            }
            else {
                TELEPORT(player, type, doMsgs, 11, 3, port2, facing2);
            }
        }
        protected override void FnEvent10(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short port1;
            short port2;
            short facing1;
            short facing2;
            Compass(player, type, doMsgs);
            switch (FACING()) {
                case NORTH:
                    port1 = 172;
                    port2 = 183;
                    facing1 = EAST;
                    facing2 = NORTH;
                    break;
                case SOUTH:
                    port2 = 198;
                    port1 = 213;
                    facing1 = WEST;
                    facing2 = SOUTH;
                    break;
                case EAST:
                    port1 = 157;
                    if (GET_FLAG(player, type, doMsgs, PARTY, WHEREWEREYOU) == 255) {
                        port2 = 175;
                    }
                    else {
                        port2 = 153;
                    }
                    facing1 = WEST;
                    facing2 = SOUTH;
                    break;
                case WEST:
                    port1 = 187;
                    port2 = 237;
                    facing1 = NORTH;
                    facing2 = WEST;
                    break;
            }
            if (GET_FLAG(player, type, doMsgs, DUNGEON, GOTASTRALITEM) <= 1 || !HAS_ITEM(player, type, doMsgs, NIMBUSOFTHEFATES)) {
                TELEPORT(player, type, doMsgs, 11, 3, port1, facing1);
            }
            else {
                TELEPORT(player, type, doMsgs, 11, 3, port2, facing2);
            }
        }
        protected override void FnEvent11(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SET_FLAG(player, type, doMsgs, PARTY, WHEREWEREYOU, HERE());
            TELEPORT(player, type, doMsgs, 11, 3, 228, NORTH);
        }
        protected override void FnEvent12(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (!GET_FLAG(player, type, doMsgs, DUNGEON, GUARDIAN)) {
                SET_BOOTY(player, type, doMsgs, PHOSPHORESCENTBLADE, HEALAMPHORA, HEALAMPHORA, MANAAMPHORA, 0, 15000);
            }
            SHOW_TEXT(player, type, doMsgs, "'You shall not pass!'");
            GET_MONSTER(player, type, doMsgs, 01, 39);
        }
        protected override void FnEvent13(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short i;
            for (i = 1; i <= 2; i++) {
                GET_MONSTER(player, type, doMsgs, i, 38);
            }
        }
        protected override void FnEvent14(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short i;
            if (HERE() == 190) {
                if (!HAS_ITEM(player, type, doMsgs, EYEOFCIRCINUS)) {
                    SET_BOOTY(player, type, doMsgs, EYEOFCIRCINUS, MANAAMPHORA, SPIRITUALARMOR, 0, 0, 3000);
                    SHOW_TEXT(player, type, doMsgs, "Guardians of the Winds defend the Eye; the compass that will guide you towards the Nimbus.");
                }
                if (!GET_FLAG(player, type, doMsgs, DUNGEON, GOTASTRALITEM)) {
                    SET_FLAG(player, type, doMsgs, DUNGEON, GOTASTRALITEM, 1);
                }
            }
            if (PARTY_COUNT() < 3) {
                for (i = 1; i <= 3; i++) {
                    GET_MONSTER(player, type, doMsgs, i, 36);
                }
            }
            else {
                for (i = 1; i <= 6; i++) {
                    GET_MONSTER(player, type, doMsgs, i, 36);
                }
            }
        }
        protected override void FnEvent15(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short i;
            SHOW_TEXT(player, type, doMsgs, "Restless entities battle eternally here.");
            if (PARTY_COUNT() < 3) {
                for (i = 1; i <= 3; i++) {
                    GET_MONSTER(player, type, doMsgs, i, 35);
                }
            }
            else {
                for (i = 1; i <= 5; i++) {
                    GET_MONSTER(player, type, doMsgs, i, 35);
                }
            }
        }
        protected override void FnEvent16(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (!GET_FLAG(player, type, doMsgs, ROOM, SPRUNGTRAP)) {
                SHOW_TEXT(player, type, doMsgs, "An astral wind rips through you.");
                DAMAGE(player, type, doMsgs, HEALTH() / 8);
                SprungTrap(player, type, doMsgs);
            }
        }
        protected override void FnEvent17(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (!GET_FLAG(player, type, doMsgs, PARTY, METWRAITH)) {
                SHOW_PICTURE(player, type, doMsgs, WRAITH);
                SHOW_TEXT(player, type, doMsgs, "'The Wind Knights hath no fury in this domain! The four winds here are reversed!'");
                SET_FLAG(player, type, doMsgs, PARTY, METWRAITH, 1);
            }
        }
        protected override void FnEvent18(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (!GET_FLAG(player, type, doMsgs, PARTY, METNIGHTELF)) {
                SHOW_PICTURE(player, type, doMsgs, NIGHTELFWARRIOR);
                SHOW_TEXT(player, type, doMsgs, "'Feuding entities battle the winds. Direction is the key to the portals here.");
                SHOW_TEXT(player, type, doMsgs, "I offer you this, the first letter of each direction is visible when you see in the past!");
                SHOW_TEXT(player, type, doMsgs, "Do not think that you must move in a different direction each move the second time through...see in the past!'");
                SET_FLAG(player, type, doMsgs, PARTY, METNIGHTELF, 1);
            }
        }
        protected override void FnEvent19(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short i;
            switch (PARTY_COUNT()) {
                case 1:
                case 2:
                    for (i = 1; i <= 2; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 33);
                    }
                    break;
                default:
                    for (i = 1; i <= 5; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 34);
                    }
                    break;
            }
        }
        protected override void FnEvent1A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, FOUNTAIN);
            SHOW_TEXT(player, type, doMsgs, "The Fountain of Faith speaks: ");
            SHOW_TEXT(player, type, doMsgs, "'See in the past...past tense of SEE!'");
            HEAL(player, type, doMsgs, MAX_HEALTH());
        }
        protected override void FnEvent1B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (!GET_FLAG(player, type, doMsgs, ROOM, SPRUNGTRAP)) {
                SHOW_PICTURE(player, type, doMsgs, FOUNTAIN);
                SHOW_TEXT(player, type, doMsgs, "The Fountain of Lies ");
                SHOW_TEXT(player, type, doMsgs, "whispers: 'See in the past? Ha! Look towards the future!'");
                DAMAGE(player, type, doMsgs, HEALTH() / 8);
                SET_PM(player, type, doMsgs, POISON, 10, 250);
                SprungTrap(player, type, doMsgs);
            }
        }
        protected override void FnEvent1C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (!GET_FLAG(player, type, doMsgs, ROOM, SPRUNGTRAP)) {
                SHOW_TEXT(player, type, doMsgs, "Noxious gas fills the room");
                DAMAGE(player, type, doMsgs, MAX_HEALTH() / 6);
                SET_PM(player, type, doMsgs, POISON, 5, 250);
                SprungTrap(player, type, doMsgs);
            }
        }
        protected override void FnEvent1D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short mn = 0;
            short mn2 = 0;
            short pfv;
            short itemA = 0;
            short itemB = 0;
            short itemC = 0;
            short gps = 0;
            short g2 = 0;
            pfv = GET_FLAG(player, type, doMsgs, PARTY, FIGHT_ME);
            if (pfv < 1) {
                pfv = 1;
            }
            switch (pfv) {
                case 1:
                    mn = 32;
                    mn2 = 31;
                    g2 = 2;
                    pfv = 2;
                    if (!GET_FLAG(player, type, doMsgs, DUNGEON, AMPHORAENCS)) {
                        itemA = HEALAMPHORA;
                        itemB = MANAAMPHORA;
                        itemC = MIDNIGHTAEGIS;
                        SET_FLAG(player, type, doMsgs, DUNGEON, AMPHORAENCS, 1);
                    }
                    gps = 5000;
                    break;
                case 2:
                    mn = 2;
                    mn2 = 1;
                    g2 = 2;
                    pfv = 3;
                    itemA = BLACKBLADE;
                    gps = 2500;
                    break;
                case 3:
                    g2 = 2;
                    pfv = 4;
                    if (GET_FLAG(player, type, doMsgs, DUNGEON, AMPHORAENCS) == 1) {
                        SHOW_TEXT(player, type, doMsgs, "Powerful beasts battle here for amphoras!!");
                        mn = 31;
                        mn2 = 30;
                        itemA = HEALAMPHORA;
                        itemB = HEALAMPHORA;
                        itemC = HEALAMPHORA;
                        SET_FLAG(player, type, doMsgs, DUNGEON, AMPHORAENCS, 2);
                    }
                    else {
                        mn = 32;
                        mn2 = 32;
                        itemA = HEALALLPOTION;
                        itemB = TWOHANDEDSWORD;
                    }
                    break;
                case 4:
                    mn = 5;
                    mn2 = 5;
                    pfv = 5;
                    itemA = MANAAMPHORA;
                    itemB = MANARESTORE;
                    gps = 2500;
                    break;
                case 5:
                    mn = 3;
                    mn2 = 3;
                    g2 = 2;
                    pfv = 2;
                    break;
            }
            SET_BOOTY(player, type, doMsgs, itemA, itemB, itemC, 0, 0, gps);
            GET_MONSTER(player, type, doMsgs, 01, mn);
            if (g2 != 0) {
                GET_MONSTER(player, type, doMsgs, g2, mn2);
            }
            SET_FLAG(player, type, doMsgs, PARTY, FIGHT_ME, pfv);
        }
        protected override void FnEvent1E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Screams of some ghostly spirit echo within these walls.");
        }
        protected override void FnEvent1F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Hail all who seek Corpeus of the Physical plane.");
            SHOW_TEXT(player, type, doMsgs, "This pathway will lead to his Hall.");
        }
        protected override void FnEvent20(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You can taste the stale air that fills this area. The floor here is covered with stagnant pools of strange liquids.");
            if (!GET_FLAG(player, type, doMsgs, DUNGEON, POOLNUMBER)) {
                SET_FLAG(player, type, doMsgs, DUNGEON, POOLNUMBER, 1);
            }
        }
        protected override void FnEvent21(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (!GET_FLAG(player, type, doMsgs, ROOM, SPRUNGTRAP)) {
                SHOW_TEXT(player, type, doMsgs, "The heat overwhelms you here.");
                DAMAGE(player, type, doMsgs, HEALTH() / 8);
                SprungTrap(player, type, doMsgs);
            }
        }
        protected override void FnEvent22(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short i;
            if (GET_FLAG(player, type, doMsgs, PARTY, LAVA_A) == 1 || HAS_ITEM(player, type, doMsgs, GAUNTLETSOFMERCY) || HAS_ITEM(player, type, doMsgs, SKULLAEGIS)) {
                SET_BOOTY(player, type, doMsgs, SAMURAISWORD, 0, 0, 0, 0, 2000);
            }
            else {
                SET_BOOTY(player, type, doMsgs, GAUNTLETSOFMERCY, SKULLAEGIS, TRACKERSMASK, 0, 0, 1000);
            }
            switch (PARTY_COUNT()) {
                case 1:
                case 2:
                    for (i = 1; i <= 2; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 25);
                    }
                    break;
                default:
                    for (i = 1; i <= 5; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 25);
                    }
                    break;
            }
        }
        protected override void FnEvent23(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short i;
            switch (PARTY_COUNT()) {
                case 1:
                case 2:
                    for (i = 1; i <= 2; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 22);
                    }
                    break;
                default:
                    for (i = 1; i <= 5; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 22);
                    }
                    break;
            }
        }
        protected override void FnEvent24(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short i;
            switch (PARTY_COUNT()) {
                case 1:
                    for (i = 1; i <= 2; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 23);
                    }
                    break;
                default:
                    for (i = 1; i <= 3; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 23);
                    }
                    break;
            }
        }
        protected override void FnEvent25(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short i;
            switch (PARTY_COUNT()) {
                case 1:
                case 2:
                    for (i = 1; i <= 2; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 24);
                    }
                    break;
                default:
                    for (i = 1; i <= 5; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 24);
                    }
                    break;
            }
        }
        protected override void FnEvent26(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short i;
            if (!GET_FLAG(player, type, doMsgs, DUNGEON, GOTPHYSITEM)) {
                SET_BOOTY(player, type, doMsgs, REALITYSRAMPART, 0, 0, 0, 0, 15000);
            }
            else if (!HAS_ITEM(player, type, doMsgs, REALITYSRAMPART)) {
                SET_BOOTY(player, type, doMsgs, REALITYSRAMPART, 0, 0, 0, 0, 3500);
            }
            switch (PARTY_COUNT()) {
                case 1:
                    for (i = 1; i <= 2; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 30);
                    }
                    GET_MONSTER(player, type, doMsgs, 6, 26);
                    break;
                case 2:
                    for (i = 1; i <= 3; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 30);
                    }
                    GET_MONSTER(player, type, doMsgs, 6, 26);
                    break;
                default:
                    NoSpellZone(player, type, doMsgs);
                    for (i = 1; i <= 4; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 30);
                    }
                    GET_MONSTER(player, type, doMsgs, 6, 26);
                    break;
            }
        }
        protected override void FnEvent27(TwPlayerServer player, MapEventType type, bool doMsgs) {
            switch (STATE()) {
                case 1:
                    SHOW_TEXT(player, type, doMsgs, "The flickering torches cast eerie shadows.");
                    break;
                default:
                    SHOW_TEXT(player, type, doMsgs, "Jeweled torch-lamps are affixed to the walls here as switches. Each has three settings. You must know the pattern to set the correct sequence.");
                    NEXT_STATE();
                    break;
            }
        }
        protected override void FnEvent2A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short i;
            switch (PARTY_COUNT()) {
                case 1:
                    for (i = 1; i <= 2; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 30);
                    }
                    break;
                case 2:
                    for (i = 1; i <= 4; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 30);
                    }
                    break;
                default:
                    for (i = 1; i <= 6; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 30);
                    }
                    break;
            }
        }
        protected override void FnEvent2B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short i;
            switch (PARTY_COUNT()) {
                case 1:
                    for (i = 1; i <= 2; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 28);
                    }
                    break;
                case 2:
                    for (i = 1; i <= 4; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 28);
                    }
                    break;
                default:
                    for (i = 1; i <= 6; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 28);
                    }
                    break;
            }
        }
        protected override void FnEvent2C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short i;
            switch (PARTY_COUNT()) {
                case 1:
                    for (i = 1; i <= 2; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 29);
                    }
                    break;
                case 2:
                    for (i = 1; i <= 3; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 29);
                    }
                    break;
                default:
                    for (i = 1; i <= 5; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 29);
                    }
                    break;
            }
        }
        protected override void FnEvent2D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "To Corpeus.");
        }
        protected override void FnEvent2E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "TO TORCH ROOM");
            TELEPORT(player, type, doMsgs, 11, 3, 24, EAST);
        }
        protected override void FnEvent2F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short portnumber;
            short compass;
            short wall;
            short coord;
            portnumber = GET_FLAG(player, type, doMsgs, DUNGEON, SWITCHESSET);
            NO_JOIN();
            switch (HERE()) {
                case 161:
                    portnumber = 1;
                    wall = WEST;
                    compass = EAST;
                    coord = 50;
                    break;
                case 145:
                    portnumber = 2;
                    wall = EAST;
                    compass = WEST;
                    coord = 74;
                    break;
                case 129:
                    portnumber = 3;
                    wall = WEST;
                    compass = EAST;
                    coord = 123;
                    break;
                case 113:
                    portnumber = 4;
                    wall = EAST;
                    compass = EAST;
                    coord = 115;
                    break;
            }
            if (GET_FLAG(player, type, doMsgs, DUNGEON, SWITCHESSET) >= portnumber) {
                SHOW_TEXT(player, type, doMsgs, "A magical portal appears in the wall!");
                PLACE_WALL_ITEM(player, type, doMsgs, GATEWAY, HERE(), wall);
                if (PARTY_COUNT() == 1) {
                    TELEPORT(player, type, doMsgs, 11, 3, coord, compass);
                }
                else {
                    SHOW_TEXT(player, type, doMsgs, "You must enter alone!");
                }
            }
            else {
                REMOVE_WALL_ITEM(player, type, doMsgs, HERE(), wall);
                Nothing(player, type, doMsgs);
            }
        }
        protected override void FnEvent31(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, FOUNTAIN);
            if (!GET_FLAG(player, type, doMsgs, DUNGEON, PHYSFNT)) {
                SHOW_TEXT(player, type, doMsgs, "The Fountain of Corpeus raises your physical prowess and enhances your agility!");
                MOD_STAT(player, type, doMsgs, STRENGTH, 1);
                MOD_STAT(player, type, doMsgs, AGILITY, 2);
                SET_FLAG(player, type, doMsgs, DUNGEON, PHYSFNT, 1);
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "The waters heal you.");
                HEAL(player, type, doMsgs, MAX_HEALTH());
            }
        }
        protected override void FnEvent32(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short trap;
            trap = GET_FLAG(player, type, doMsgs, PARTY, CASETRAP2);
            if (!GET_FLAG(player, type, doMsgs, ROOM, SPRUNGTRAP)) {
                if (GUILD() == THIEF || GUILD() == RANGER) {
                    SHOW_TEXT(player, type, doMsgs, "Your keen senses allow you to avoid a devastating trap.");
                }
                else {
                    switch (trap) {
                        case 1:
                            DAMAGE(player, type, doMsgs, HEALTH() / 6);
                            NoMapsZone(player, type, doMsgs);
                            NoSpellZone(player, type, doMsgs);
                            SHOW_TEXT(player, type, doMsgs, "The torch here explodes with fire!");
                            trap++;
                            break;
                        case 2:
                            DAMAGE(player, type, doMsgs, HEALTH() - 2000);
                            SET_PM(player, type, doMsgs, POISON, 15, 100);
                            PoisTxt(player, type, doMsgs);
                            trap++;
                            break;
                        case 3:
                            DAMAGE(player, type, doMsgs, HEALTH() / 2);
                            FlameTxt(player, type, doMsgs);
                            trap++;
                            break;
                        case 4:
                            SET_PM(player, type, doMsgs, PARALYSIS, 10, 0);
                            MOD_MANA(player, type, doMsgs,  - 2000);
                            while HAS_ITEM(player, type, doMsgs, ZEUSSCROLL)TAKE_ITEM(player, type, doMsgs, ZEUSSCROLL);
                            SHOW_TEXT(player, type, doMsgs, "You clumsily set off a gas trap.");
                            trap++;
                            break;
                        case 5:
                            SHOW_TEXT(player, type, doMsgs, "A refreshing shower of magical waters is a nice change to these fiendish traps!");
                            MOD_MANA(player, type, doMsgs, 200);
                            HEAL(player, type, doMsgs, MAX_HEALTH() / 4);
                            CLEAR_PM(player, type, doMsgs, POISON);
                            CLEAR_PM(player, type, doMsgs, PARALYSIS);
                            CLEAR_PM(player, type, doMsgs, PETRIFY);
                            trap++;
                            break;
                        default:
                            DamageBy6(player, type, doMsgs);
                            NO_HEAL_ZONE();
                            trap = 1;
                            NoSpellZone(player, type, doMsgs);
                            SHOW_TEXT(player, type, doMsgs, "A mental blast of power is thrust upon you!");
                            break;
                    }
                }
                SET_FLAG(player, type, doMsgs, PARTY, CASETRAP2, trap);
                SprungTrap(player, type, doMsgs);
            }
        }
        protected override void FnEvent36(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, GNOMEWIZARD);
            short flag;
            short switches;
            switches = GET_FLAG(player, type, doMsgs, DUNGEON, SPOKEWITHGRATOK);
            switch (HERE()) {
                case 98:
                    flag = 1;
                    if (switches < flag) {
                        SHOW_TEXT(player, type, doMsgs, "'Ahh, welcome to the Physical path. I am Gratok, allow me to guide you.");
                        SHOW_TEXT(player, type, doMsgs, "Go now to the west then to the south. Search the walls for the portals. I will see you there.'");
                    }
                    break;
                case 177:
                    flag = 2;
                    if (switches < flag) {
                        SHOW_TEXT(player, type, doMsgs, "'We meet again. Now, northward, portals here will open when you have completed certain actions.");
                        SHOW_TEXT(player, type, doMsgs, "Remember to search the walls!'");
                        if (!GET_FLAG(player, type, doMsgs, DUNGEON, SWITCHESSET)) {
                            SET_FLAG(player, type, doMsgs, DUNGEON, SWITCHESSET, 1);
                        }
                    }
                    break;
                case 55:
                    flag = 3;
                    if (switches < flag) {
                        SHOW_TEXT(player, type, doMsgs, "'Servitude is my destiny now. For I had created this pathway in honor of Corpeus. Now I am doomed to help those who would seek him.'");
                    }
                    break;
                case 87:
                    flag = 4;
                    if (switches <= flag) {
                        SHOW_TEXT(player, type, doMsgs, "'Well done. You must find the room where torches are switches. Set them as I say, then return to the starting hallway.");
                        SHOW_TEXT(player, type, doMsgs, "Time follows death from life'");
                    }
                    break;
                case 118:
                    flag = 5;
                    if (switches <= flag) {
                        SHOW_TEXT(player, type, doMsgs, "'Time wastes. Past the Guardians to the east of stagnation lies the torch room. You must know the combination to proceed there.'");
                    }
                    break;
                case 11:
                    if ((GET_FLAG(player, type, doMsgs, DUNGEON, GOTPHYSITEM) == 1) || (GET_FLAG(player, type, doMsgs, DUNGEON, GOTPHYSITEM) == 2)) {
                        SHOW_TEXT(player, type, doMsgs, "'WELL DONE! Off you go to the next phase. Water leads to magic sands.'");
                        SET_FLAG(player, type, doMsgs, DUNGEON, GOTPHYSITEM, 2);
                    }
                    break;
                case 26:
                    flag = switches;
                    if (!GET_FLAG(player, type, doMsgs, DUNGEON, GOTPHYSITEM)) {
                        SHOW_TEXT(player, type, doMsgs, "'You must try again. This portal will take you to the start of this level.'");
                    }
                    else {
                        SHOW_TEXT(player, type, doMsgs, "Now you may enter the torch room again.");
                    }
                    break;
                case 224:
                    flag = 8;
                    if (switches <= flag) {
                        SHOW_TEXT(player, type, doMsgs, "'Onward! You've earned the next series by conquering the Hall.");
                        SHOW_TEXT(player, type, doMsgs, "Magic lava leads to death.'");
                    }
                    break;
            }
            if (switches < flag) {
                SET_FLAG(player, type, doMsgs, DUNGEON, SPOKEWITHGRATOK, flag);
                Default(player, type, doMsgs);
            }
            else {
                Default(player, type, doMsgs);
            }
        }
        private void Default(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "'Do as I say. My familiars will guide you.'");
        }
        protected override void FnEvent37(TwPlayerServer player, MapEventType type, bool doMsgs) {
            DamageBy6(player, type, doMsgs);
            NoSpellZone(player, type, doMsgs);
            SHOW_TEXT(player, type, doMsgs, "The magical fluids drain you.");
        }
        protected override void FnEvent38(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short i;
            SHOW_TEXT(player, type, doMsgs, "Medusas guard this gateway!");
            switch (PARTY_COUNT()) {
                case 1:
                    for (i = 1; i <= 2; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 27);
                    }
                    break;
                case 2:
                    for (i = 1; i <= 3; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 27);
                    }
                    break;
                default:
                    for (i = 1; i <= 5; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 27);
                    }
                    break;
            }
        }
        protected override void FnEvent39(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short i;
            switch (PARTY_COUNT()) {
                case 1:
                case 2:
                    for (i = 1; i <= 2; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 19);
                    }
                    break;
                default:
                    for (i = 1; i <= 5; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 19);
                    }
                    break;
            }
        }
        protected override void FnEvent3A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "This hallway is laden with traps. You are powerless and confused.");
            NoMapsZone(player, type, doMsgs);
            NoSpellZone(player, type, doMsgs);
            short trap;
            short item;
            trap = GET_FLAG(player, type, doMsgs, PARTY, CASETRAP);
            Compass(player, type, doMsgs);
            if (!GET_FLAG(player, type, doMsgs, ROOM, SPRUNGTRAP)) {
                if (GUILD() == THIEF) {
                    SHOW_TEXT(player, type, doMsgs, "You manage to avoid the trap!");
                }
                else {
                    switch (trap) {
                        case 1:
                            DAMAGE(player, type, doMsgs, HEALTH() / 6);
                            SET_PM(player, type, doMsgs, POISON, 5, 100);
                            PoisTxt(player, type, doMsgs);
                            trap++;
                            break;
                        case 2:
                            DAMAGE(player, type, doMsgs, 350);
                            FlameTxt(player, type, doMsgs);
                            trap++;
                            break;
                        default:
                            DAMAGE(player, type, doMsgs, HEALTH() / 8);
                            MOD_MANA(player, type, doMsgs,  - 150);
                            trap = 1;
                            SHOW_TEXT(player, type, doMsgs, "A whirlwind of magic rushes through the hallway draining and dragging you!");
                            TELEPORT(player, type, doMsgs, 11, 3, HERE(), EAST);
                            break;
                    }
                }
                SET_FLAG(player, type, doMsgs, PARTY, CASETRAP, trap);
                SprungTrap(player, type, doMsgs);
            }
        }
        protected override void FnEvent3B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            Compass(player, type, doMsgs);
            NoMapsZone(player, type, doMsgs);
            if (!GET_FLAG(player, type, doMsgs, ROOM, SPRUNGTRAP)) {
                switch (FACING()) {
                    case NORTH:
                        ROTATE(player, type, doMsgs, EAST);
                        break;
                    case SOUTH:
                        ROTATE(player, type, doMsgs, EAST);
                        ROTATE(player, type, doMsgs, SOUTH);
                        ROTATE(player, type, doMsgs, NORTH);
                        TELEPORT(player, type, doMsgs, 11, 3, HERE(), NORTH);
                        break;
                    case WEST:
                        ROTATE(player, type, doMsgs, NORTH);
                        ROTATE(player, type, doMsgs, SOUTH);
                        ROTATE(player, type, doMsgs, EAST);
                        break;
                    case EAST:
                        TELEPORT(player, type, doMsgs, 11, 3, HERE(), NORTH);
                        break;
                }
                SprungTrap(player, type, doMsgs);
                if (HERE() == 179) {
                    if (!GET_FLAG(player, type, doMsgs, PARTY, INHALLWAY)) {
                        RemainText(player, type, doMsgs);
                        SHOW_TEXT(player, type, doMsgs, "Back to the beginning! You must try again.");
                        TELEPORT(player, type, doMsgs, 11, 3, 123, EAST);
                    }
                }
            }
        }
        protected override void FnEvent3C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            NoMapsZone(player, type, doMsgs);
            SHOW_TEXT(player, type, doMsgs, "This hallway is of lethal cunning. Only the most ingenious and powerful heroes will survive.");
            if (!GET_FLAG(player, type, doMsgs, PARTY, INHALLWAY)) {
                SET_FLAG(player, type, doMsgs, PARTY, INHALLWAY, 1);
                SHOW_PICTURE(player, type, doMsgs, GNOMEWIZARD);
                SHOW_TEXT(player, type, doMsgs, "'I can not help you here. I offer you this warning:'");
                RemainText(player, type, doMsgs);
                SHOW_TEXT(player, type, doMsgs, "'Farewell!'");
            }
        }
        protected override void FnEvent3D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            BLOCK_WALL(player, type, doMsgs, HERE(), FACING());
            SHOW_TEXT(player, type, doMsgs, "An unseen force holds you back!");
        }
        protected override void FnEvent3E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short flag;
            short ai;
            short wwy;
            wwy = GET_FLAG(player, type, doMsgs, PARTY, WHEREWEREYOU);
            ai = GET_FLAG(player, type, doMsgs, DUNGEON, GOTASTRALITEM);
            NoMapsZone(player, type, doMsgs);
            if (PARTY_LEADER()) {
                if ((ai <= 1) || (!HAS_ITEM(player, type, doMsgs, NIMBUSOFTHEFATES))) {
                    switch (HERE()) {
                        case 228:
                            flag = 236;
                            break;
                        case 232:
                            flag = 228;
                            break;
                        case 217:
                            flag = 232;
                            break;
                        case 153:
                            flag = 217;
                            break;
                        case 157:
                            flag = 153;
                            break;
                    }
                }
                else if (ai >= 2) {
                    switch (HERE()) {
                        case 228:
                            flag = 236;
                            break;
                        case 232:
                            flag = 153;
                            break;
                        case 217:
                            flag = 0;
                            break;
                        case 153:
                            flag = 157;
                            break;
                        case 157:
                            flag = 228;
                            break;
                    }
                }
                if (wwy == 255 || wwy != flag) {
                    SET_FLAG(player, type, doMsgs, PARTY, WHEREWEREYOU, 255);
                }
                else if (GET_FLAG(player, type, doMsgs, PARTY, WHEREWEREYOU) == flag) {
                    SET_FLAG(player, type, doMsgs, PARTY, WHEREWEREYOU, HERE());
                }
            }
        }
        private void FlameTxt(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "A dragon's face carved on the wall here animates and spews forth dragon's breath!");
        }
        private void PoisTxt(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Deadly poisons drip onto you from above.");
        }
        private void Compass(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GUILD() == RANGER || HAS_ITEM(player, type, doMsgs, EYEOFCIRCINUS)) {
                switch (FACING()) {
                    case NORTH:
                        SHOW_TEXT(player, type, doMsgs, "North");
                        break;
                    case WEST:
                        SHOW_TEXT(player, type, doMsgs, "West");
                        break;
                    case EAST:
                        SHOW_TEXT(player, type, doMsgs, "East");
                        break;
                    case SOUTH:
                        SHOW_TEXT(player, type, doMsgs, "South");
                        break;
                }
            }
        }
        private void RemainText(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "'You must remain in this hallway until your task has been completed!'");
        }
        private void Center(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "-Center-");
        }
        private void SprungTrap(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SET_FLAG(player, type, doMsgs, ROOM, SPRUNGTRAP, 1);
        }
        private void DamageBy6(TwPlayerServer player, MapEventType type, bool doMsgs) {
            DAMAGE(player, type, doMsgs, MAX_HEALTH() / 6);
        }
        private void Nothing(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "There is nothing here.");
        }
        private void NoSpellZone(TwPlayerServer player, MapEventType type, bool doMsgs) {
            NO_SPELL();
            NO_SKILL();
        }
        private void NoMapsZone(TwPlayerServer player, MapEventType type, bool doMsgs) {
            NO_MAPS();
        }
        protected override void FnEvent3F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SET_FLAG(player, type, doMsgs, DUNGEON, GUARDIAN, 1);
        }
        protected override void FnEvent40(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short switchA;
            short valueA;
            short valueB;
            switchA = GET_FLAG(player, type, doMsgs, PARTY, TORCH1);
            switch (switchA) {
                case 1:
                    SHOW_TEXT(player, type, doMsgs, "DEATH");
                    valueA = 3;
                    valueB = 0;
                    switchA = 2;
                    break;
                case 2:
                    SHOW_TEXT(player, type, doMsgs, "WATER");
                    valueA = 0;
                    valueB = 6;
                    switchA = 3;
                    break;
                default:
                    Center(player, type, doMsgs);
                    valueA = 0;
                    valueB = 0;
                    switchA = 1;
                    break;
            }
            SET_FLAG(player, type, doMsgs, PARTY, DEATHW, valueA);
            SET_FLAG(player, type, doMsgs, PARTY, WATERW, valueB);
            SET_FLAG(player, type, doMsgs, PARTY, TORCH1, switchA);
        }
        protected override void FnEvent41(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short switchA;
            short valueA;
            short valueB;
            switchA = GET_FLAG(player, type, doMsgs, PARTY, TORCH2);
            switch (switchA) {
                case 1:
                    SHOW_TEXT(player, type, doMsgs, "LIFE");
                    valueA = 5;
                    valueB = 0;
                    switchA = 2;
                    break;
                case 2:
                    SHOW_TEXT(player, type, doMsgs, "SANDS");
                    valueA = 0;
                    valueB = 10;
                    switchA = 3;
                    break;
                default:
                    Center(player, type, doMsgs);
                    valueA = 0;
                    valueB = 0;
                    switchA = 1;
                    break;
            }
            SET_FLAG(player, type, doMsgs, PARTY, LIFEW, valueA);
            SET_FLAG(player, type, doMsgs, PARTY, SANDSW, valueB);
            SET_FLAG(player, type, doMsgs, PARTY, TORCH2, switchA);
        }
        protected override void FnEvent42(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short switchA;
            short valueA;
            short valueB;
            switchA = GET_FLAG(player, type, doMsgs, PARTY, TORCH3);
            switch (switchA) {
                case 1:
                    SHOW_TEXT(player, type, doMsgs, "TO");
                    valueA = 8;
                    valueB = 0;
                    switchA = 2;
                    break;
                case 2:
                    SHOW_TEXT(player, type, doMsgs, "FOLLOWS");
                    valueA = 0;
                    valueB = 2;
                    switchA = 3;
                    break;
                default:
                    Center(player, type, doMsgs);
                    valueA = 0;
                    valueB = 0;
                    switchA = 1;
                    break;
            }
            SET_FLAG(player, type, doMsgs, PARTY, TOW, valueA);
            SET_FLAG(player, type, doMsgs, PARTY, FOLLOWSW, valueB);
            SET_FLAG(player, type, doMsgs, PARTY, TORCH3, switchA);
        }
        protected override void FnEvent43(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short switchA;
            short valueA;
            short valueB;
            switchA = GET_FLAG(player, type, doMsgs, PARTY, TORCH4);
            switch (switchA) {
                case 1:
                    SHOW_TEXT(player, type, doMsgs, "TIME");
                    valueA = 1;
                    valueB = 0;
                    switchA = 2;
                    break;
                case 2:
                    SHOW_TEXT(player, type, doMsgs, "MAGIC");
                    valueA = 0;
                    valueB = 9;
                    switchA = 3;
                    break;
                default:
                    Center(player, type, doMsgs);
                    valueA = 0;
                    valueB = 0;
                    switchA = 1;
                    break;
            }
            SET_FLAG(player, type, doMsgs, PARTY, TIMEW, valueA);
            SET_FLAG(player, type, doMsgs, PARTY, MAGICW, valueB);
            SET_FLAG(player, type, doMsgs, PARTY, TORCH4, switchA);
        }
        protected override void FnEvent44(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short switchA;
            short valueA;
            short valueB;
            switchA = GET_FLAG(player, type, doMsgs, PARTY, TORCH5);
            switch (switchA) {
                case 1:
                    SHOW_TEXT(player, type, doMsgs, "LAVA");
                    valueA = 11;
                    valueB = 0;
                    switchA = 2;
                    break;
                case 2:
                    SHOW_TEXT(player, type, doMsgs, "FROM");
                    valueA = 0;
                    valueB = 4;
                    switchA = 3;
                    break;
                default:
                    Center(player, type, doMsgs);
                    valueA = 0;
                    valueB = 0;
                    switchA = 1;
                    break;
            }
            SET_FLAG(player, type, doMsgs, PARTY, LAVAW, valueA);
            SET_FLAG(player, type, doMsgs, PARTY, FROMW, valueB);
            SET_FLAG(player, type, doMsgs, PARTY, TORCH5, switchA);
        }
        protected override void FnEvent45(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short switchA;
            short valueA;
            short valueB;
            switchA = GET_FLAG(player, type, doMsgs, PARTY, TORCH6);
            switch (switchA) {
                case 1:
                    SHOW_TEXT(player, type, doMsgs, "OF");
                    valueA = 12;
                    valueB = 0;
                    switchA = 2;
                    break;
                case 2:
                    SHOW_TEXT(player, type, doMsgs, "LEADS");
                    valueA = 0;
                    valueB = 7;
                    switchA = 3;
                    break;
                default:
                    Center(player, type, doMsgs);
                    valueA = 0;
                    valueB = 0;
                    switchA = 1;
                    break;
            }
            SET_FLAG(player, type, doMsgs, PARTY, OFW, valueA);
            SET_FLAG(player, type, doMsgs, PARTY, LEADSW, valueB);
            SET_FLAG(player, type, doMsgs, PARTY, TORCH6, switchA);
        }
        protected override void FnEvent46(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short setupport;
            short flag;
            flag = 0;
            setupport = GET_FLAG(player, type, doMsgs, PARTY, DEATHW);
             + GET_FLAG(player, type, doMsgs, PARTY, WATERW);
             + GET_FLAG(player, type, doMsgs, PARTY, LIFEW);
             + GET_FLAG(player, type, doMsgs, PARTY, SANDSW);
             + GET_FLAG(player, type, doMsgs, PARTY, TOW);
             + GET_FLAG(player, type, doMsgs, PARTY, FOLLOWSW);
             + GET_FLAG(player, type, doMsgs, PARTY, TIMEW);
             + GET_FLAG(player, type, doMsgs, PARTY, MAGICW);
             + GET_FLAG(player, type, doMsgs, PARTY, LAVAW);
             + GET_FLAG(player, type, doMsgs, PARTY, FROMW);
             + GET_FLAG(player, type, doMsgs, PARTY, OFW);
             + GET_FLAG(player, type, doMsgs, PARTY, LEADSW);
            switch (setupport) {
                case 15:
                    flag = 2;
                    break;
                case 40:
                    flag = 3;
                    break;
                case 38:
                    flag = 4;
                    break;
                default:
                    flag = 1;
                    break;
            }
            if (GET_FLAG(player, type, doMsgs, DUNGEON, SWITCHESSET) < flag) {
                SET_FLAG(player, type, doMsgs, DUNGEON, SWITCHESSET, flag);
            }
            SHOW_TEXT(player, type, doMsgs, "This portal is the only way back to the start of this level. Use it only if you have set the switches.");
            TELEPORT(player, type, doMsgs, 11, 3, 1, SOUTH);
        }
        protected override void FnEvent47(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (!GET_FLAG(player, type, doMsgs, DUNGEON, GOTPHYSITEM)) {
                MOD_EXP(player, type, doMsgs, 650000);
                SHOW_TEXT(player, type, doMsgs, "Gain experience for your accomplishment!");
                SET_FLAG(player, type, doMsgs, DUNGEON, GOTPHYSITEM, 1);
            }
        }
        protected override void FnEvent48(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (!GET_FLAG(player, type, doMsgs, DUNGEON, GOTPHYSITEM)) {
                TELEPORT(player, type, doMsgs, 11, 3, 1, SOUTH);
            }
            else {
                CLEAR_WALL(player, type, doMsgs, HERE(), FACING());
                HIDE_WALL(player, type, doMsgs, HERE(), FACING());
            }
        }
        protected override void FnEvent4B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, DUNGEON, SPOKEWITHGRATOK) >= 4) {
                CLEAR_WALL(player, type, doMsgs, HERE(), FACING());
                PLACE_WALL_ITEM(player, type, doMsgs, PORTAL, HERE(), FACING());
                SHOW_TEXT(player, type, doMsgs, "Magical words emblazoned on the door glow as you approach: 'Torch Room'.");
            }
            else {
                BLOCK_WALL(player, type, doMsgs, HERE(), FACING());
                SHOW_TEXT(player, type, doMsgs, "The door is sealed...you will be told when to return to the Torch Room.");
            }
        }
    }
}
