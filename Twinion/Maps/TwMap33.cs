using XPT.Generic.Maps;
using XPT.Twinion.Entities;

namespace XPT.Twinion.Maps {
    class TwMap33 : TwMap {
        protected override int MapIndex => 33;
        protected override int MapID => 0x0D02;
        protected override int RandomEncounterChance => 5;
        protected override int RandomEncounterExtraCount => 2;

        private const int SEEN_IT = 0;
        private const int DONE_IT = 1;
        private const int LETTER_STR_POS = 0;
        private const int NUMBER_STR_POS = 0;
        private const int CAROUSEL_REVS = 1;
        private const int MONST_WIMPY_GRDS = 25;
        private const int MONST_MAJOR_DOMO = 26;
        private const int MONST_OGRESS = 27;
        private const int MONST_FAKE_CHOR = 28;
        private const int MONST_NEXUS_1 = 29;
        private const int MONST_NEXUS_2 = 30;
        private const int MONST_NEXUS_3 = 31;
        private const int MONST_NEXUS_4 = 32;
        private const int MONST_MIRRHALL_A = 33;
        private const int MONST_MIRRHALL_B = 34;
        private const int MONST_MIRRHALL_C = 35;
        private const int MONST_VORTEX_1 = 36;
        private const int MONST_VORTEX_2 = 37;
        private const int MONST_VORTEX_3 = 38;
        private const int MONST_PENALTY = 39;
        private const int MONST_TWISTY = 13;
        private const int SHADAX_KILLED_BIT = 1;
        private const int CHISS_KILLED_BIT = 2;
        private const int CHORONZAR_KILLED_BIT = 4;
        private const int GAOLER_KILLED_BIT = 8;
        private const int VORTEX_SQUARE = 0;
        private const int VORTEX_FACING = 1;
        private const int TWISTY_COUNT = 2;
        private const int CHOR_TAUNT = 3;
        private const int TOWER_DISKS1 = 4;
        private const int TOWER_DISKS2 = 5;
        private const int TOWER_DISKS3 = 6;
        private const int CAROUSEL_CTRL = 7;
        private const int EASTER_EGG = 8;
        private const int COASTER_STOPPING = 9;
        private const int FAKE_CHOR_KILLED = 10;
        private const int CHOR_GHOST_SEEN = 11;
        private const int FAKE_CHOR_SEEN = 12;
        private const int CAROUSEL_CNT = 25;
        private const int MAJOR_DOMO = 26;
        private const int OGRESS_KILLED = 27;
        private const int NEXUS_PUZZLE = 29;
        private const int VORTEX_COUNT = 30;
        private static int CHORONZAR_PIC = (10 + HUMANBARBARIAN - 1);
        private static int MAJORDOMO_PIC = (18 + HUMANBARBARIAN - 1);
        private static int ARCHITECT_PIC = (13 + HUMANBARBARIAN - 1);
        private static int HANDMAIDEN_PIC = (3 + HUMANBARBARIAN - 1);
        private static int ALCHEMIST_PIC = (25 + HUMANBARBARIAN - 1);
        private static int MASTERPUZZLER_PIC = (22 + HUMANBARBARIAN - 1);
        private static int PRISONER1_PIC = (4 + HUMANBARBARIAN - 1);
        private static int PRISONER2_PIC = (6 + HUMANBARBARIAN - 1);
        private static int PRISONER3_PIC = (9 + HUMANBARBARIAN - 1);
        string aStr = "ANOMIE";
        string bStr = "BEWILDERMENT";
        string cStr = "CONFUSION";
        string dStr = "DESPAIR";
        string eStr = "ENNUI";
        string fStr = "FATALISM";
        string gStr = "GRIEF";
        string hStr = "HOPELESSNESS";
        string menageDescDefault = "There is a pile of moldering bones here, bound by rusty chains.";
        string menageDescPrisoner = "A wild-eyed, delirious prisoner is slumped in the corner, confined by a glowing neck-manacle.";
        string menageRescueThanks = "The prisoner rises, bows deeply, and thanks you.";
        string menageTwistyClue = "'I am Shelia, erstwhile architect to His Madness. I was ordered to design the chambers of this maze to be indistinguishable. But a number of them have unique features. As for the rest, perhaps a clever party could mark them also...'";
        string menageDoorsClue = "'I am Gravus, a Master Puzzlemaker. I created the traps here. The Puzzlers' Code prohibits divulging solutions, but listen: At least one door speaks the truth, and at least one lies. But first you must raise The Tower.";
        string menageAlchemyClue = "'Choronzar has been performing alchemical experiments using the precious metals. If you can complete these experiments perhaps they will help you defeat him.'";
        string menageBottleClue = "'I was taken with my lady Naomi from her chamber room on the very eve of her wedding. Twas awful! Now Choronzar's stolen her spirit and locked it in a bottle so we can never leave! One of the other prisoners told me it was tossed into The Vortex.'";
        string menageWeird1 = "'... it's a ramshonkle junkycam ...'";
        string menageWeird2 = "'... flowing with and curling in ... it doesn't make any go ...'";
        string menageWeird3 = "'... she was a beautiful lad ...'";
        string menageWeird4 = "'... the three-eyed man in the kingdom of the blind ... ' the brabham and the braugham ...'";
        string menageWeird5 = "'... giant meteor, KILL ME NOW ...'";
        string menageWeird6 = "'... a godzillion ... killyajolts ... a hundred jillion killyazolts ... '";
        string menageWeird7 = "'... is points-of-light happy? .... no, points-of-light is not happy ...'";
        string door1Str = "The middle door does not lead to the maze.";
        string door2Str = "I do not lead to the maze.";
        string door3Str = "'I lead to the maze.'";
        string redHerring = "Pushing the BIG RED BUTTON opens the door to the Easter Egg.";
        string majorDomo1 = "As you step through the archway a bald, portly, little man in coat and tails hails you. 'Greetings', he beams, 'and welcome to the Halfway House! I am the Major Domo.'";
        string majorDomo2 = "The Major Domo falls into step with you. 'You look tired,' he observes, 'but you've come the right place!' He pauses to blot at his brow with a flannel kerchief. 'The pools will have you feeling right in a jiffy!'";
        string majorDomo3 = "The Major Domo continues: 'You mustn't give up, you know. A real adventurer NEVER gives up. Surrender is expressly forbidden by the Hero's Creed and reflects very poorly upon one's ancestry.'";
        string majorDomo4 = "'And besides, you're halfway there! That's why we call this place the Halfway House, after all.  It's all downhill from here!'";
        string majorDomo5 = "The Major Domo prattles on: 'So take your time, catch your breath, and steel yourself for the glorious battles to come. Farewell!'";
        private void SixMonst(TwPlayerServer player, MapEventType type, bool doMsgs, int monster) {
            int i = 0;
            int num = 0;
            switch (PARTY_COUNT(player, type, doMsgs)) {
                case 1:
                    num = 2;
                    break;
                case 2:
                    num = 3;
                    break;
                case 3:
                    num = 5;
                    break;
                case 4:
                default:
                    num = 6;
                    break;
            }
            for (i = 1; i <= num; i++) {
                GET_MONSTER(player, type, doMsgs, i, monster);
            }
        }
        protected override void FnEvent01(TwPlayerServer player, MapEventType type, bool doMsgs) {
            NO_JOIN(player, type, doMsgs);
            if (PARTY_COUNT(player, type, doMsgs) > 1) {
                SHOW_TEXT(player, type, doMsgs, "The coaster cars are only big enough for one of you at a time.");
                SET_FLAG(player, type, doMsgs, PARTY, COASTER_STOPPING, 0);
                TELEPORT(player, type, doMsgs, 13, 2, 222, NORTH);
            }
            switch (HERE(player, type, doMsgs)) {
                case 235:
                    ROTATE(player, type, doMsgs, EAST);
                    TELEPORT(player, type, doMsgs, 13, 2, 236, EAST);
                    break;
                case 236:
                    TELEPORT(player, type, doMsgs, 13, 2, 237, EAST);
                    break;
                case 237:
                    SET_FLAG(player, type, doMsgs, PARTY, COASTER_STOPPING, 1);
                    TELEPORT(player, type, doMsgs, 13, 2, 238, EAST);
                    break;
                case 238:
                    BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), EAST);
                    BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), WEST);
                    if (FLAG_ON(player, type, doMsgs, PARTY, COASTER_STOPPING)) {
                        SHOW_TEXT(player, type, doMsgs, "The coaster stops.");
                        SET_FLAG(player, type, doMsgs, PARTY, COASTER_STOPPING, 0);
                        TELEPORT(player, type, doMsgs, 13, 2, 222, NORTH);
                    }
                    else if (HAS_ITEM(player, type, doMsgs, FUNHOUSEKEY)) {
                        SHOW_TEXT(player, type, doMsgs, "You twist the Funhouse Key in the keyhole. With a lurch the car begins to rumble forward along the rails.");
                        TELEPORT(player, type, doMsgs, 13, 2, 239, EAST);
                    }
                    break;
                case 239:
                    TELEPORT(player, type, doMsgs, 13, 1, 118, NORTH);
                    break;
                case 251:
                    ROTATE(player, type, doMsgs, NORTH);
                    TELEPORT(player, type, doMsgs, 13, 2, 235, NORTH);
                    break;
                case 252:
                case 253:
                case 254:
                case 255:
                    TELEPORT(player, type, doMsgs, 13, 2, HERE(player, type, doMsgs) - 1, WEST);
                    break;
            }
        }
        protected override void FnEvent03(TwPlayerServer player, MapEventType type, bool doMsgs) {
            switch (FACING(player, type, doMsgs)) {
                case NORTH:
                    SHOW_TEXT(player, type, doMsgs, "WELCOME TO THE FUNHOUSE!!!");
                    SHOW_TEXT(player, type, doMsgs, "Rules of the Establishment:");
                    SHOW_TEXT(player, type, doMsgs, "1. No spitting.");
                    SHOW_TEXT(player, type, doMsgs, "2. No cussing.");
                    SHOW_TEXT(player, type, doMsgs, "3. Please don't feed the monsters!");
                    SHOW_TEXT(player, type, doMsgs, "     -- the Management");
                    break;
                case SOUTH:
                    SHOW_TEXT(player, type, doMsgs, "The roller coaster is here.");
                    break;
                default:
                    break;
            }
        }
        protected override void FnEvent04(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int square = 245;
            int picture = 0;
            SHOW_TEXT(player, type, doMsgs, "The magic mirror twists and warps your reflection.");
            switch (HERE(player, type, doMsgs)) {
                case 138:
                    picture = GNOMEBARBARIAN;
                    break;
                case 139:
                    picture = ORCBARBARIAN;
                    break;
                case 154:
                    picture = ELFBARBARIAN;
                    break;
                case 171:
                    picture = HUMANBARBARIAN;
                    square = 54;
                    break;
                case 187:
                    picture = ORCKNIGHT;
                    break;
                case 190:
                    picture = TROLLKNIGHT;
                    break;
                case 204:
                    picture = DWARFKNIGHT;
                    break;
                case 207:
                    picture = HALFLINGKNIGHT;
                    break;
                case 219:
                    picture = ORCRANGER;
                    break;
                case 221:
                    picture = ELFRANGER;
                    break;
                default:
                    break;
            }
            SHOW_PICTURE(player, type, doMsgs, picture);
            TELEPORT(player, type, doMsgs, 13, 2, square, SOUTH);
        }
        protected override void FnEvent05(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int cntFlag = 0;
            NO_JOIN(player, type, doMsgs);
            if (PARTY_COUNT(player, type, doMsgs) > 1) {
                SHOW_TEXT(player, type, doMsgs, "The horse you are riding is only big enough for one. You lose your grip!");
                TELEPORT(player, type, doMsgs, 13, 2, 141, WEST);
            }
            if (FLAG_OFF(player, type, doMsgs, PARTY, CAROUSEL_CTRL)) {
                cntFlag = GET_FLAG(player, type, doMsgs, PARTY, CAROUSEL_CNT);
                switch ((HERE(player, type, doMsgs) << 8) + FACING(player, type, doMsgs)) {
                    case ((141 << 8) + WEST):
                        if (cntFlag > 0) {
                            cntFlag--;
                            SET_FLAG(player, type, doMsgs, PARTY, CAROUSEL_CNT, cntFlag);
                            ROTATE(player, type, doMsgs, SOUTH);
                            TELEPORT(player, type, doMsgs, 13, 2, 157, SOUTH);
                        }
                        else {
                            SHOW_TEXT(player, type, doMsgs, "The ride ends.");
                            TELEPORT(player, type, doMsgs, 13, 2, 140, WEST);
                        }
                        break;
                    case ((141 << 8) + SOUTH):
                    case ((141 << 8) + EAST):
                    case ((141 << 8) + NORTH):
                        ROTATE(player, type, doMsgs, SOUTH);
                        TELEPORT(player, type, doMsgs, 13, 2, 157, SOUTH);
                        break;
                    case ((142 << 8) + WEST):
                        TELEPORT(player, type, doMsgs, 13, 2, 141, WEST);
                        break;
                    case ((143 << 8) + NORTH):
                        ROTATE(player, type, doMsgs, WEST);
                        TELEPORT(player, type, doMsgs, 13, 2, 142, WEST);
                        break;
                    case ((157 << 8) + SOUTH):
                        TELEPORT(player, type, doMsgs, 13, 2, 173, SOUTH);
                        break;
                    case ((159 << 8) + NORTH):
                        TELEPORT(player, type, doMsgs, 13, 2, 143, NORTH);
                        break;
                    case ((173 << 8) + SOUTH):
                        ROTATE(player, type, doMsgs, EAST);
                        TELEPORT(player, type, doMsgs, 13, 2, 174, EAST);
                        break;
                    case ((174 << 8) + EAST):
                        TELEPORT(player, type, doMsgs, 13, 2, 175, EAST);
                        break;
                    case ((175 << 8) + EAST):
                        SHOW_TEXT(player, type, doMsgs, "You reach for the brass ring, but it's stuck.");
                        ROTATE(player, type, doMsgs, NORTH);
                        TELEPORT(player, type, doMsgs, 13, 2, 159, NORTH);
                        break;
                    default:
                        break;
                }
            }
        }
        protected override void FnEvent06(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (!HAS_ITEM(player, type, doMsgs, BRASSRING)) {
                SHOW_TEXT(player, type, doMsgs, "With a mighty tug you dislodge the brass ring from the armature.");
                GIVE_ITEM(player, type, doMsgs, BRASSRING);
            }
        }
        protected override void FnEvent07(TwPlayerServer player, MapEventType type, bool doMsgs) {
            string str = string.Empty;
            if (GET_FLAG(player, type, doMsgs, PARTY, CAROUSEL_CTRL) == 0) {
                SHOW_TEXT(player, type, doMsgs, "You throw the rusty knife switch.");
                SET_FLAG(player, type, doMsgs, PARTY, CAROUSEL_CTRL, 1);
            }
        }
        protected override void FnEvent08(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (FLAG_ON(player, type, doMsgs, ROOM, DONE_IT)) {
                TELEPORT(player, type, doMsgs, 13, 2, 194, NORTH);
            }
            else if (USED_ITEM(player, type, doMsgs, NAOMISKEY, NAOMISKEY)) {
                SET_FLAG(player, type, doMsgs, ROOM, DONE_IT, 1);
                SHOW_TEXT(player, type, doMsgs, "You unlock the door.");
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "This door requires a special key.");
            }
        }
        protected override void FnEvent09(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 13, 2, 103, WEST);
        }
        protected override void FnEvent0A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            BLOCK_FLOOR(player, type, doMsgs, HERE(player, type, doMsgs));
        }
        protected override void FnEvent0B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HEALTH(player, type, doMsgs) != MAX_HEALTH(player, type, doMsgs)) {
                SHOW_TEXT(player, type, doMsgs, "The cool water invigorates you.");
                HEAL(player, type, doMsgs, MAX_HEALTH(player, type, doMsgs));
            }
        }
        protected override void FnEvent0C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "The fizzy water refreshes you.");
            MOD_MANA(player, type, doMsgs, 30000);
        }
        protected override void FnEvent0D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 13, 2, 48, EAST);
        }
        protected override void FnEvent0E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int flag = 0;
            string strPtr = string.Empty;
            flag = GET_FLAG(player, type, doMsgs, PARTY, MAJOR_DOMO);
            if (flag <= 4) {
                SHOW_PICTURE(player, type, doMsgs, MAJORDOMO_PIC);
            }
            switch (flag) {
                case 0:
                    strPtr = majorDomo1;
                    break;
                case 1:
                    strPtr = majorDomo2;
                    break;
                case 2:
                    strPtr = majorDomo3;
                    break;
                case 3:
                    strPtr = majorDomo4;
                    break;
                case 4:
                    strPtr = majorDomo5;
                    break;
            }
            if (strPtr != null) {
                flag++;
                SET_FLAG(player, type, doMsgs, PARTY, MAJOR_DOMO, flag);
                SHOW_TEXT(player, type, doMsgs, strPtr);
            }
        }
        protected override void FnEvent10(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, PARTY, MAJOR_DOMO) == 6) {
                SHOW_TEXT(player, type, doMsgs, "The Major Domo spies you. His eyes widen and he begins to shake with rage. 'No no no! You musn't give up, whatever you do! Show some pluck, some spirit, some gumption for heaven's sake!' He begins to whack at you with an andiron.");
                SET_FLAG(player, type, doMsgs, PARTY, MAJOR_DOMO, 7);
                GET_MONSTER(player, type, doMsgs, 01, MONST_MAJOR_DOMO);
            }
        }
        protected override void FnEvent11(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int switchFlag = 0;
            int destSquare = 0;
            int destFacing = 0;
            switchFlag = HERE(player, type, doMsgs);
            switchFlag <<= 8;
            switchFlag += FACING(player, type, doMsgs);
            switch (switchFlag) {
                case ((48 << 8) + NORTH):
                    destSquare = 117;
                    destFacing = SOUTH;
                    break;
                case ((48 << 8) + EAST):
                    destSquare = 48;
                    destFacing = EAST;
                    break;
                case ((48 << 8) + WEST):
                    destSquare = 65;
                    destFacing = SOUTH;
                    break;
                case ((64 << 8) + EAST):
                    destSquare = 160;
                    destFacing = WEST;
                    break;
                case ((64 << 8) + SOUTH):
                    destSquare = 101;
                    destFacing = NORTH;
                    break;
                case ((64 << 8) + WEST):
                    destSquare = 112;
                    destFacing = SOUTH;
                    break;
                case ((112 << 8) + NORTH):
                    destSquare = 102;
                    destFacing = NORTH;
                    break;
                case ((112 << 8) + EAST):
                    destSquare = 116;
                    destFacing = EAST;
                    break;
                case ((112 << 8) + WEST):
                    destSquare = 119;
                    destFacing = WEST;
                    break;
                case ((128 << 8) + EAST):
                    destSquare = 64;
                    destFacing = NORTH;
                    break;
                case ((128 << 8) + SOUTH):
                    destSquare = 112;
                    destFacing = WEST;
                    break;
                case ((128 << 8) + WEST):
                    destSquare = 144;
                    destFacing = WEST;
                    break;
                case ((144 << 8) + NORTH):
                    destSquare = 160;
                    destFacing = NORTH;
                    break;
                case ((144 << 8) + EAST):
                    destSquare = 117;
                    destFacing = WEST;
                    break;
                case ((144 << 8) + WEST):
                    destSquare = 48;
                    destFacing = SOUTH;
                    break;
                case ((160 << 8) + EAST):
                    destSquare = 128;
                    destFacing = NORTH;
                    break;
                case ((160 << 8) + SOUTH):
                    destSquare = 144;
                    destFacing = SOUTH;
                    break;
                case ((160 << 8) + WEST):
                    destSquare = 101;
                    destFacing = SOUTH;
                    break;
                case ((116 << 8) + NORTH):
                    destSquare = 128;
                    destFacing = NORTH;
                    break;
                case ((116 << 8) + SOUTH):
                    destSquare = 119;
                    destFacing = WEST;
                    break;
                case ((116 << 8) + WEST):
                    destSquare = 48;
                    destFacing = EAST;
                    break;
                case ((117 << 8) + NORTH):
                    destSquare = 117;
                    destFacing = SOUTH;
                    break;
                case ((117 << 8) + EAST):
                    destSquare = 102;
                    destFacing = SOUTH;
                    break;
                case ((117 << 8) + SOUTH):
                    destSquare = 160;
                    destFacing = WEST;
                    break;
                case ((101 << 8) + NORTH):
                    destSquare = 116;
                    destFacing = NORTH;
                    break;
                case ((101 << 8) + SOUTH):
                    destSquare = 64;
                    destFacing = NORTH;
                    break;
                case ((101 << 8) + WEST):
                    destSquare = 128;
                    destFacing = EAST;
                    break;
                case ((102 << 8) + NORTH):
                    destSquare = 144;
                    destFacing = SOUTH;
                    break;
                case ((102 << 8) + EAST):
                    destSquare = 117;
                    destFacing = SOUTH;
                    break;
                case ((102 << 8) + SOUTH):
                    destSquare = 2;
                    destFacing = SOUTH;
                    break;
                case ((118 << 8) + NORTH):
                    destSquare = 128;
                    destFacing = NORTH;
                    break;
                case ((118 << 8) + SOUTH):
                    destSquare = 144;
                    destFacing = SOUTH;
                    break;
                case ((118 << 8) + WEST):
                    destSquare = 117;
                    destFacing = NORTH;
                    break;
                case ((119 << 8) + NORTH):
                    destSquare = 101;
                    destFacing = NORTH;
                    break;
                case ((119 << 8) + EAST):
                    destSquare = 11;
                    destFacing = WEST;
                    break;
                case ((119 << 8) + SOUTH):
                    destSquare = 48;
                    destFacing = EAST;
                    break;
                case ((11 << 8) + NORTH):
                    destSquare = 31;
                    destFacing = NORTH;
                    break;
                case ((11 << 8) + EAST):
                    destSquare = 102;
                    destFacing = WEST;
                    break;
                case ((11 << 8) + WEST):
                    destSquare = 27;
                    destFacing = EAST;
                    break;
                case ((27 << 8) + EAST):
                    destSquare = 116;
                    destFacing = EAST;
                    break;
                case ((27 << 8) + SOUTH):
                    destSquare = 118;
                    destFacing = NORTH;
                    break;
                case ((27 << 8) + WEST):
                    destSquare = 30;
                    destFacing = NORTH;
                    break;
                case ((14 << 8) + NORTH):
                    destSquare = 64;
                    destFacing = WEST;
                    break;
                case ((14 << 8) + EAST):
                    destSquare = 79;
                    destFacing = WEST;
                    break;
                case ((14 << 8) + WEST):
                    destSquare = 128;
                    destFacing = EAST;
                    break;
                case ((30 << 8) + EAST):
                    destSquare = 15;
                    destFacing = WEST;
                    break;
                case ((30 << 8) + SOUTH):
                    destSquare = 144;
                    destFacing = EAST;
                    break;
                case ((30 << 8) + WEST):
                    destSquare = 11;
                    destFacing = WEST;
                    break;
                case ((15 << 8) + NORTH):
                    destSquare = 48;
                    destFacing = EAST;
                    break;
                case ((15 << 8) + EAST):
                    destSquare = 15;
                    destFacing = WEST;
                    break;
                case ((15 << 8) + WEST):
                    destSquare = 102;
                    destFacing = NORTH;
                    break;
                case ((31 << 8) + EAST):
                    destSquare = 27;
                    destFacing = EAST;
                    break;
                case ((31 << 8) + SOUTH):
                    destSquare = 160;
                    destFacing = NORTH;
                    break;
                case ((31 << 8) + WEST):
                    destSquare = 30;
                    destFacing = WEST;
                    break;
                case ((78 << 8) + NORTH):
                    destSquare = 112;
                    destFacing = SOUTH;
                    break;
                case ((78 << 8) + SOUTH):
                    destSquare = 27;
                    destFacing = NORTH;
                    break;
                case ((78 << 8) + WEST):
                    destSquare = 30;
                    destFacing = WEST;
                    break;
                case ((79 << 8) + NORTH):
                    destSquare = 15;
                    destFacing = SOUTH;
                    break;
                case ((79 << 8) + EAST):
                    destSquare = 85;
                    destFacing = NORTH;
                    break;
                case ((79 << 8) + SOUTH):
                    destSquare = 160;
                    destFacing = WEST;
                    break;
                default:
                    destSquare = 222;
                    destFacing = SOUTH;
                    break;
            }
            TELEPORT(player, type, doMsgs, 13, 2, destSquare, destFacing);
        }
        protected override void FnEvent12(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "A sign on the wall proclaims 'This way to the Ogress!'");
        }
        protected override void FnEvent13(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (FLAG_OFF(player, type, doMsgs, PARTY, OGRESS_KILLED)) {
                SET_FLAG(player, type, doMsgs, PARTY, OGRESS_KILLED, 1);
                SHOW_TEXT(player, type, doMsgs, "Squatting in a pile of refuse is a repulsive, mottle-skinned creature. 'Ah!' she gurgles, smacking her rubbery lips, 'You must be dinner!'");
                SET_BOOTY(player, type, doMsgs, 0, 0, 0, 0, 0, 0);
                GET_MONSTER(player, type, doMsgs, 01, MONST_OGRESS);
            }
        }
        protected override void FnEvent14(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 13, 2, 164, EAST);
        }
        protected override void FnEvent15(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 13, 2, 164, EAST);
        }
        protected override void FnEvent16(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SixMonst(player, type, doMsgs, MONST_WIMPY_GRDS);
        }
        protected override void FnEvent17(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int flag = 0;
            flag = GET_FLAG(player, type, doMsgs, PARTY, FAKE_CHOR_SEEN);
            switch (HERE(player, type, doMsgs)) {
                case 165:
                    if (((flag & 1) == 0)) {
                        SHOW_TEXT(player, type, doMsgs, "Ahead of you through the layers of smoke you see a massive golden throne.");
                        flag |= 1;
                    }
                    break;
                case 166:
                    if (((flag & 2) == 0)) {
                        SHOW_TEXT(player, type, doMsgs, "As you draw closer you make out an insoucient figure lounging on the throne, dressed in jester's motley.");
                        flag |= 2;
                    }
                    break;
                case 167:
                    if (((flag & 4) == 0)) {
                        SHOW_TEXT(player, type, doMsgs, "The crazed figure on the throne stands, stares at you briefly, then prances off to the southeast, cackling like a lunatic. He dives into a pit and vanishes.");
                        flag |= 4;
                    }
                    break;
            }
            SET_FLAG(player, type, doMsgs, PARTY, FAKE_CHOR_SEEN, flag);
        }
        protected override void FnEvent18(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "The boiling lava scorches you mildly.");
            DAMAGE(player, type, doMsgs, 1);
        }
        protected override void FnEvent19(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "The brackish water offends your nostrils.");
        }
        protected override void FnEvent1A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            switch (HERE(player, type, doMsgs)) {
                case 4:
                case 6:
                case 8:
                case 10:
                case 68:
                case 70:
                case 72:
                default:
                    TELEPORT(player, type, doMsgs, 13, 2, 222, NORTH);
                    break;
            }
        }
        protected override void FnEvent1B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            switch (HERE(player, type, doMsgs)) {
                case 201:
                    TELEPORT(player, type, doMsgs, 13, 2, 218, SOUTH);
                    break;
                case 202:
                default:
                    TELEPORT(player, type, doMsgs, 13, 2, 185, NORTH);
                    break;
            }
        }
        protected override void FnEvent1C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (FLAG_OFF(player, type, doMsgs, PARTY, FAKE_CHOR_KILLED)) {
                SET_FLAG(player, type, doMsgs, PARTY, FAKE_CHOR_KILLED, 1);
                SHOW_TEXT(player, type, doMsgs, "You set upon Choronzar as he scurries away. 'No!,' he squeals, 'you can't do this!'");
                GET_MONSTER(player, type, doMsgs, 01, MONST_FAKE_CHOR);
            }
        }
        protected override void FnEvent1D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (FLAG_OFF(player, type, doMsgs, ROOM, SEEN_IT)) {
                SET_FLAG(player, type, doMsgs, ROOM, SEEN_IT, 1);
                SHOW_TEXT(player, type, doMsgs, "A golden sarcophagus of regal dimensions glows dully in the torchlight. Upon further inspection you notice a ring-shaped indentation in the lid.");
            }
            if (USED_ITEM(player, type, doMsgs, BRASSRING, BRASSRING)) {
                if (FLAG_OFF(player, type, doMsgs, ROOM, DONE_IT)) {
                    SET_FLAG(player, type, doMsgs, ROOM, DONE_IT, 1);
                }
                SHOW_TEXT(player, type, doMsgs, "You place the Brass Ring in the indentation. There is a hissing sound and a flash of intense white light, then the Brass Ring is gone. A portal has opened to the west!");
                TAKE_ITEM(player, type, doMsgs, BRASSRING);
                HIDE_WALL(player, type, doMsgs, HERE(player, type, doMsgs), WEST);
                CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), WEST);
                SET_FLAG(player, type, doMsgs, PARTY, TOWER_DISKS1, 1);
                SET_FLAG(player, type, doMsgs, PARTY, TOWER_DISKS2, 2);
                SET_FLAG(player, type, doMsgs, PARTY, TOWER_DISKS3, 4);
            }
        }
        protected override void FnEvent1E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int thisFlag = 0;
            int targFlag = 0;
            int thisFlagOff = 0;
            int targFlagOff = 100;
            int thisBits = 0x01;
            int thatBits = 0x01;
            int switchFlag = 0;
            switchFlag = HERE(player, type, doMsgs);
            switch (switchFlag) {
                case 214:
                    thisFlagOff = 0;
                    break;
                case 230:
                    thisFlagOff = 1;
                    break;
                case 246:
                    thisFlagOff = 2;
                    break;
            }
            thisFlag = GET_FLAG(player, type, doMsgs, PARTY, TOWER_DISKS1 + thisFlagOff);
            if (USED_ITEM(player, type, doMsgs, FUNHOUSEKEY, FUNHOUSEKEY)) {
                switchFlag <<= 8;
                switchFlag |= FACING(player, type, doMsgs);
                switch (switchFlag) {
                    case ((214 << 8) | SOUTH):
                        targFlagOff = 1;
                        break;
                    case ((230 << 8) | NORTH):
                        targFlagOff = 0;
                        break;
                    case ((230 << 8) | SOUTH):
                        targFlagOff = 2;
                        break;
                    case ((246 << 8) | NORTH):
                        targFlagOff = 1;
                        break;
                }
                if (targFlagOff != 100) {
                    targFlag = GET_FLAG(player, type, doMsgs, PARTY, TOWER_DISKS1 + targFlagOff);
                    thisFlag |= 0x8;
                    while (((thisFlag & thisBits) == 0))
                        thisBits <<= 1;
                        thisFlag &= 0x07;
                        thisBits &= 0x07;
                        targFlag |= 0x8;
                        while (((targFlag & thatBits) == 0))
                            thatBits <<= 1;
                            targFlag &= 0x07;
                            thatBits &= 0x07;
                            if ((thisBits != 0) && ((thatBits == 0) || (thisBits < thatBits))) {
                                switch (thisBits) {
                                    case 1:
                                        SHOW_TEXT(player, type, doMsgs, "The small wooden disk spins into the air and lands gracefully on the next peg.");
                                        break;
                                    case 2:
                                        SHOW_TEXT(player, type, doMsgs, "The medium wooden disk spins into the air and lands gracefully on the next peg.");
                                        break;
                                    case 3:
                                        SHOW_TEXT(player, type, doMsgs, "The large wooden disk spins into the air and lands gracefully on the next peg.");
                                        break;
                                }
                                targFlag |= thisBits;
                                thisFlag &= ~thisBits;
                                SET_FLAG(player, type, doMsgs, PARTY, TOWER_DISKS1 + thisFlagOff, thisFlag);
                                SET_FLAG(player, type, doMsgs, PARTY, TOWER_DISKS1 + targFlagOff, targFlag);
                                SET_FLAG(player, type, doMsgs, ROOM, SEEN_IT, 0);
                            }
                        }
                    }
                    if (FLAG_OFF(player, type, doMsgs, ROOM, SEEN_IT)) {
                        SET_FLAG(player, type, doMsgs, ROOM, SEEN_IT, 1);
                        SHOW_TEXT(player, type, doMsgs, "There is an iron peg sticking up from the floor here. Impaled on the peg you see:");
                        if (thisFlag == 0) {
                            SHOW_TEXT(player, type, doMsgs, "Nothing.");
                        }
                        else if (thisFlag == 0x07) {
                            SHOW_TEXT(player, type, doMsgs, "All three wooden disks -- the completed Tower of Annoy!");
                        }
                        else {
                            if (IsTrue(thisFlag & 0x4)) {
                                SHOW_TEXT(player, type, doMsgs, "A large wooden disk.");
                            }
                            if (IsTrue(thisFlag & 0x2)) {
                                SHOW_TEXT(player, type, doMsgs, "A medium-sized wooden disk.");
                            }
                            if (IsTrue(thisFlag & 0x1)) {
                                SHOW_TEXT(player, type, doMsgs, "A small wooden disk.");
                            }
                        }
                    }
                }
                protected override void FnEvent1F(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    if (FLAG_OFF(player, type, doMsgs, PARTY, EASTER_EGG)) {
                        SHOW_TEXT(player, type, doMsgs, "You plunge to your doom.");
                        DAMAGE(player, type, doMsgs, MAX_HEALTH(player, type, doMsgs));
                    }
                }
                protected override void FnEvent20(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    string strPtr = string.Empty;
                    int flagOff = 0;
                    int flag = 0;
                    switch (HERE(player, type, doMsgs)) {
                        case 214:
                            strPtr = door1Str;
                            flagOff = 0;
                            break;
                        case 230:
                            strPtr = door2Str;
                            flagOff = 1;
                            break;
                        case 246:
                            strPtr = door3Str;
                            flagOff = 2;
                            break;
                    }
                    if (FLAG_OFF(player, type, doMsgs, ROOM, SEEN_IT)) {
                        SET_FLAG(player, type, doMsgs, ROOM, SEEN_IT, 1);
                        SHOW_TEXT(player, type, doMsgs, "A sepuchral voice speaks from the door:");
                        SHOW_TEXT(player, type, doMsgs, strPtr);
                    }
                    flag = GET_FLAG(player, type, doMsgs, PARTY, TOWER_DISKS1 + flagOff);
                    if (flag == 0x07) {
                        switch (flagOff) {
                            case 0:
                                TELEPORT(player, type, doMsgs, 13, 2, 176, SOUTH);
                                break;
                            case 1:
                            case 2:
                                TELEPORT(player, type, doMsgs, 13, 2, 245, SOUTH);
                                break;
                        }
                    }
                }
                protected override void FnEvent21(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    int flag = 0;
                    if (((GET_FLAG(player, type, doMsgs, DUNGEON, CHOR_NPC_KILLED) & CHORONZAR_KILLED_BIT) == 0)) {
                        flag = GET_FLAG(player, type, doMsgs, PARTY, CHOR_TAUNT);
                        if (flag <= 1) {
                            SHOW_PICTURE(player, type, doMsgs, CHORONZAR_PIC);
                        }
                        switch (flag) {
                            case 0:
                                SHOW_TEXT(player, type, doMsgs, "The door across the chasm opens and a strange figure in red and green jester's motley capers through. 'How delightful! % It is SO rare these days that I entertain mortals. %%' He grins and cocks his head, jingling the bells on his cap.");
                                SHOW_TEXT(player, type, doMsgs, "'You needn't look so crestfallen...surely you didn't mistake my little simulacrum for the real thing! %' He giggles to himself and stares vacantly into the distance for a moment.");
                                SHOW_TEXT(player, type, doMsgs, "You've created quite a stir here in my household %, and I'm sure you are MOST charming -- for mortals %% -- but I really MUST insist that you leave now.");
                                SHOW_TEXT(player, type, doMsgs, "I have plans -- so MANY plans %% -- and I simply can't allow any interference from the likes of you.  I trust you know the way out. % Good Bye! %%'");
                                break;
                            case 1:
                                SHOW_TEXT(player, type, doMsgs, "Choronzar's face twists into a rictus of rage. 'What!?! ^', he shrieks. 'Still here!? ^' Frothy flecks of spittle fly from his lips.");
                                SHOW_TEXT(player, type, doMsgs, "'You poor, pathetic mortals. %^ How strange it must be to crawl about the surface of your dirty world, knowing that you are doomed to die -- like a condemned criminal who knows not when the executioner will call.");
                                SHOW_TEXT(player, type, doMsgs, "You realize the cause is hopeless, yet you persist!' He sighs. 'So be it. % Continue on if you must, for the Riddle Room is far beyond your puny powers of comprehension. ^%' He whirls abruptly and stalks away through the door to the West.");
                                break;
                        }
                        SET_FLAG(player, type, doMsgs, PARTY, CHOR_TAUNT, ++flag);
                    }
                }
                protected override void FnEvent22(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    TELEPORT(player, type, doMsgs, 13, 2, 230, EAST);
                }
                protected override void FnEvent23(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    switch (HERE(player, type, doMsgs)) {
                        case 242:
                            TELEPORT(player, type, doMsgs, 13, 2, 123, NORTH);
                            break;
                        case 29:
                            TELEPORT(player, type, doMsgs, 13, 2, 22, NORTH);
                            break;
                        default:
                            TELEPORT(player, type, doMsgs, 13, 2, 245, SOUTH);
                            break;
                    }
                }
                protected override void FnEvent25(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    SHOW_TEXT(player, type, doMsgs, "A gleaming platinum plaque set into the floor reads: 'Riddle me this: I am He who lurks at the end of Life. Mine is the power to alter that which came before Me.'");
                }
                protected override void FnEvent26(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    int monster = 0;
                    switch (HERE(player, type, doMsgs)) {
                        case 122:
                        case 88:
                        case 56:
                        case 26:
                        case 28:
                        case 62:
                        case 94:
                        case 124:
                            monster = MONST_NEXUS_1;
                            break;
                        case 121:
                        case 72:
                        case 40:
                        case 10:
                        case 13:
                        case 63:
                        case 95:
                        case 125:
                            monster = MONST_NEXUS_2;
                            break;
                        case 120:
                        case 71:
                        case 24:
                        case 9:
                        case 12:
                        case 47:
                        case 111:
                        case 126:
                            monster = MONST_NEXUS_3;
                            break;
                        case 104:
                        case 55:
                        case 25:
                        case 8:
                        case 29:
                        case 46:
                        case 127:
                        case 110:
                            monster = MONST_NEXUS_4;
                            break;
                        default:
                            break;
                    }
                    SixMonst(player, type, doMsgs, monster);
                }
                protected override void FnEvent27(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    int flag = 0;
                    int i = 0;
                    int treasure = 0;
                    int square = 0;
                    int facing = 0;
                    NO_MAPS(player, type, doMsgs);
                    SHOW_TEXT(player, type, doMsgs, "You continue to tumble through the Vortex, buffeted by gusts of stale wind.");
                    flag = GET_FLAG(player, type, doMsgs, PARTY, VORTEX_COUNT);
                    SET_FLAG(player, type, doMsgs, PARTY, VORTEX_COUNT, flag + 1);
                    switch (flag % 9) {
                        case 0:
                            square = 38;
                            facing = NORTH;
                            break;
                        case 1:
                            square = 7;
                            facing = WEST;
                            break;
                        case 2:
                            square = 21;
                            facing = EAST;
                            break;
                        case 3:
                            square = 5;
                            facing = EAST;
                            break;
                        case 4:
                            square = 22;
                            facing = NORTH;
                            break;
                        case 5:
                            square = 39;
                            facing = WEST;
                            break;
                        case 6:
                            square = 23;
                            facing = WEST;
                            break;
                        case 7:
                            square = 37;
                            facing = EAST;
                            break;
                        case 8:
                        default:
                            square = 6;
                            facing = SOUTH;
                            break;
                    }
                    if (HERE(player, type, doMsgs) == 6) {
                        PLACE_WALL_ITEM(player, type, doMsgs, GATEWAY, 6, NORTH);
                    }
                    else {
                        REMOVE_WALL_ITEM(player, type, doMsgs, 6, NORTH);
                    }
                    SET_FLAG(player, type, doMsgs, PARTY, VORTEX_SQUARE, square);
                    SET_FLAG(player, type, doMsgs, PARTY, VORTEX_FACING, facing);
                    if ((flag != 0) && (flag % 7) == 0) {
                        treasure = SPIRITBOTTLE;
                    }
                    else {
                        treasure = CUREPOTION;
                    }
                    flag %= 3;
                    SET_BOOTY(player, type, doMsgs, CUREPOTION, CUREPOTION, CUREPOTION, treasure, CUREPOTION, 0);
                    for (i = 1; i <= (PARTY_COUNT(player, type, doMsgs) + 1); i++) {
                        GET_MONSTER(player, type, doMsgs, i, MONST_VORTEX_1 + flag);
                    }
                }
                protected override void FnEvent28(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    string strPtr1 = string.Empty;
                    string strPtr2 = string.Empty;
                    if (USED_ITEM(player, type, doMsgs, HACKSAWBLADE, HACKSAWBLADE) && FLAG_OFF(player, type, doMsgs, ROOM, DONE_IT)) {
                        SET_FLAG(player, type, doMsgs, ROOM, DONE_IT, 1);
                        SHOW_TEXT(player, type, doMsgs, "With a CRACK the shackles burst open in a shower of sparks.  The Hacksaw Blade has been ruined as well.");
                        TAKE_ITEM(player, type, doMsgs, HACKSAWBLADE);
                        switch (HERE(player, type, doMsgs)) {
                            case 0:
                                strPtr1 = menageRescueThanks;
                                break;
                            case 16:
                                strPtr1 = menageTwistyClue;
                                break;
                            case 18:
                                strPtr1 = menageBottleClue;
                                break;
                            case 20:
                                strPtr1 = menageRescueThanks;
                                break;
                            case 36:
                                strPtr1 = menageAlchemyClue;
                                break;
                            case 49:
                                strPtr1 = menageDoorsClue;
                                break;
                            case 50:
                                strPtr1 = menageRescueThanks;
                                break;
                            default:
                                break;
                        }
                    }
                    else if (FLAG_OFF(player, type, doMsgs, ROOM, SEEN_IT)) {
                        SET_FLAG(player, type, doMsgs, ROOM, SEEN_IT, 1);
                        switch (HERE(player, type, doMsgs)) {
                            case 0:
                                SHOW_PICTURE(player, type, doMsgs, PRISONER1_PIC);
                                strPtr1 = menageDescPrisoner;
                                strPtr2 = menageWeird1;
                                break;
                            case 16:
                                SHOW_PICTURE(player, type, doMsgs, ARCHITECT_PIC);
                                strPtr1 = menageDescPrisoner;
                                strPtr2 = menageWeird2;
                                break;
                            case 18:
                                SHOW_PICTURE(player, type, doMsgs, HANDMAIDEN_PIC);
                                strPtr1 = menageDescPrisoner;
                                strPtr2 = menageWeird3;
                                break;
                            case 20:
                                SHOW_PICTURE(player, type, doMsgs, PRISONER2_PIC);
                                strPtr1 = menageDescPrisoner;
                                strPtr2 = menageWeird4;
                                break;
                            case 36:
                                SHOW_PICTURE(player, type, doMsgs, ALCHEMIST_PIC);
                                strPtr1 = menageDescPrisoner;
                                strPtr2 = menageWeird5;
                                break;
                            case 49:
                                SHOW_PICTURE(player, type, doMsgs, MASTERPUZZLER_PIC);
                                strPtr1 = menageDescPrisoner;
                                strPtr2 = menageWeird6;
                                break;
                            case 50:
                                SHOW_PICTURE(player, type, doMsgs, PRISONER3_PIC);
                                strPtr1 = menageDescPrisoner;
                                strPtr2 = menageWeird7;
                                break;
                            default:
                                strPtr1 = menageDescDefault;
                                break;
                        }
                    }
                    if (strPtr1 != null) {
                        SHOW_TEXT(player, type, doMsgs, strPtr1);
                    }
                    if (strPtr2 != null) {
                        SHOW_TEXT(player, type, doMsgs, "As if in a feverish dream, the prisoner cries out:");
                        SHOW_TEXT(player, type, doMsgs, strPtr2);
                    }
                }
                protected override void FnEvent29(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    TELEPORT(player, type, doMsgs, 13, 2, 101, NORTH);
                }
                protected override void FnEvent2A(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    SET_FLAG(player, type, doMsgs, PARTY, CAROUSEL_CNT, CAROUSEL_REVS);
                }
                protected override void FnEvent2B(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    SixMonst(player, type, doMsgs, MONST_MIRRHALL_A);
                }
                protected override void FnEvent2C(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    SixMonst(player, type, doMsgs, MONST_MIRRHALL_B);
                }
                protected override void FnEvent2D(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    SixMonst(player, type, doMsgs, MONST_MIRRHALL_C);
                }
                protected override void FnEvent2F(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    string strPtr = string.Empty;
                    int nexFlags1 = 0;
                    int square = -1;
                    nexFlags1 = GET_FLAG(player, type, doMsgs, PARTY, NEXUS_PUZZLE);
                    if (nexFlags1 == 0) {
                        switch (HERE(player, type, doMsgs)) {
                            case 106:
                                square = 123;
                                strPtr = aStr;
                                break;
                            case 89:
                                square = 123;
                                strPtr = bStr;
                                break;
                            case 57:
                                square = 123;
                                strPtr = cStr;
                                break;
                            case 42:
                                square = 123;
                                strPtr = dStr;
                                break;
                            case 44:
                                strPtr = eStr;
                                CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
                                break;
                            case 61:
                                square = 123;
                                strPtr = fStr;
                                break;
                            case 93:
                                square = 123;
                                strPtr = gStr;
                                break;
                            case 108:
                                square = 123;
                                strPtr = hStr;
                                break;
                            default:
                                break;
                        }
                        if (square !=  - 1) {
                            TELEPORT(player, type, doMsgs, 13, 2, square, NORTH);
                        }
                    }
                    if (strPtr != null) {
                        SHOW_TEXT(player, type, doMsgs, "Above the door a stone tablet reads:");
                        SHOW_TEXT(player, type, doMsgs, strPtr);
                    }
                }
                protected override void FnEvent30(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    TELEPORT(player, type, doMsgs, 13, 2, 242, WEST);
                }
                protected override void FnEvent32(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
                }
                protected override void FnEvent33(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
                    TELEPORT(player, type, doMsgs, 13, 2, GET_FLAG(player, type, doMsgs, PARTY, VORTEX_SQUARE), GET_FLAG(player, type, doMsgs, PARTY, VORTEX_FACING));
                }
                protected override void FnEvent34(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    TELEPORT(player, type, doMsgs, 13, 2, 222, SOUTH);
                }
                protected override void FnEvent35(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    NO_MAPS(player, type, doMsgs);
                    SHOW_TEXT(player, type, doMsgs, "From the darkness above you Choronzar's voice whispers, 'Good guess! % Too bad it was WRONG. %% Welcome to the Penalty Box...'");
                    SixMonst(player, type, doMsgs, MONST_PENALTY);
                }
                protected override void FnEvent36(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    TELEPORT(player, type, doMsgs, 13, 2, 171, NORTH);
                }
                protected override void FnEvent37(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    TELEPORT(player, type, doMsgs, 13, 2, 222, EAST);
                }
                protected override void FnEvent38(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    SHOW_TEXT(player, type, doMsgs, "A wooden sign hanging from the ceiling reads:");
                    SHOW_TEXT(player, type, doMsgs, "'HALL OF MIRRORS.");
                    SHOW_TEXT(player, type, doMsgs, "These mirrors show thine own face,");
                    SHOW_TEXT(player, type, doMsgs, "Distorted and impure.");
                    SHOW_TEXT(player, type, doMsgs, "But seek the dour countenance,");
                    SHOW_TEXT(player, type, doMsgs, "Brow girdled with azure.'");
                }
                protected override void FnEvent39(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    int twistyCnt = 0;
                    NO_MAPS(player, type, doMsgs);
                    if (HERE(player, type, doMsgs) == 48) {
                        SET_FLAG(player, type, doMsgs, PARTY, MAJOR_DOMO, 6);
                    }
                    if (FLAG_OFF(player, type, doMsgs, ROOM, DONE_IT)) {
                        twistyCnt = GET_FLAG(player, type, doMsgs, PARTY, TWISTY_COUNT);
                        if (USED_SKILL(player, type, doMsgs, DETECT_SKILL) >= 1) {
                            SHOW_TEXT(player, type, doMsgs, "Your search reveals monsters!");
                            SixMonst(player, type, doMsgs, MONST_TWISTY);
                            SET_FLAG(player, type, doMsgs, ROOM, DONE_IT, 1);
                        }
                        else {
                            twistyCnt++;
                            if (((twistyCnt % 5) == 0) || ((twistyCnt % 7) == 0)) {
                                SET_BOOTY(player, type, doMsgs, MANAAMPHORA, HEALAMPHORA, CUREPOTION, HACKSAWBLADE, 0, 0);
                                SixMonst(player, type, doMsgs, MONST_TWISTY);
                                SET_FLAG(player, type, doMsgs, ROOM, DONE_IT, 1);
                            }
                        }
                        SET_FLAG(player, type, doMsgs, PARTY, TWISTY_COUNT, twistyCnt);
                    }
                }
                protected override void FnEvent3A(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    NO_MAPS(player, type, doMsgs);
                }
                protected override void FnEvent3C(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    NO_MAPS(player, type, doMsgs);
                    if (FLAG_OFF(player, type, doMsgs, ROOM, SEEN_IT)) {
                        SET_FLAG(player, type, doMsgs, ROOM, SEEN_IT, 1);
                        SHOW_TEXT(player, type, doMsgs, "An exquisitely delicate egg of opal and white gold rests atop a polished marble dais. Congratulations! You have found the Easter Egg.");
                        GIVE_ITEM(player, type, doMsgs, EASTEREGG);
                    }
                }
                protected override void FnEvent3D(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    SHOW_TEXT(player, type, doMsgs, "This is a massive throne carved from a single block of polished obsidian. It is inlaid with strange, beautiful sigils in delicate silver filigree.");
                }
                protected override void FnEvent3E(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    if (FLAG_OFF(player, type, doMsgs, PARTY, CHOR_GHOST_SEEN)) {
                        SET_FLAG(player, type, doMsgs, PARTY, CHOR_GHOST_SEEN, 1);
                        SHOW_TEXT(player, type, doMsgs, "Wailing piteously, the spirit of Choronzar drifts from his fallen body into the tomb.");
                    }
                }
                protected override void FnEvent3F(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    TELEPORT(player, type, doMsgs, 13, 2, 227, WEST);
                }
                protected override void FnEvent40(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    int item = 0;
                    int flag = 0;
                    if (FLAG_OFF(player, type, doMsgs, ROOM, DONE_IT)) {
                        SET_FLAG(player, type, doMsgs, ROOM, DONE_IT, 1);
                        flag = GET_FLAG(player, type, doMsgs, DUNGEON, FUN_BAR_COUNT);
                        if (flag < 100) {
                            switch (HERE(player, type, doMsgs)) {
                                case 215:
                                    item = SILVERBAR;
                                    break;
                                case 216:
                                    item = GOLDBAR;
                                    break;
                                case 231:
                                    item = SLIVERBAR;
                                    break;
                                case 247:
                                    item = PRICELESSBAR;
                                    break;
                                case 248:
                                default:
                                    item = PLATINUMBAR;
                                    break;
                            }
                            SHOW_TEXT(player, type, doMsgs, "This vast stack of ingots seems virtually inexhaustible.");
                            GIVE_ITEM(player, type, doMsgs, item);
                            GIVE_ITEM(player, type, doMsgs, item);
                            GIVE_ITEM(player, type, doMsgs, item);
                            GIVE_ITEM(player, type, doMsgs, item);
                            GIVE_ITEM(player, type, doMsgs, item);
                            flag += 5;
                        }
                        SET_FLAG(player, type, doMsgs, DUNGEON, FUN_BAR_COUNT, flag);
                    }
                }
                protected override void FnEvent41(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    if (FLAG_OFF(player, type, doMsgs, ROOM, DONE_IT)) {
                        if (USED_ITEM(player, type, doMsgs, JESTERSCAP, JESTERSCAP)) {
                            SET_FLAG(player, type, doMsgs, ROOM, DONE_IT, 1);
                        }
                    }
                    else {
                        if (USED_ITEM(player, type, doMsgs, PRICELESSBAR, PRICELESSBAR)) {
                            SET_FLAG(player, type, doMsgs, PARTY, EASTER_EGG, 1);
                        }
                    }
                }
                protected override void FnEvent43(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    SHOW_RUNES(player, type, doMsgs, "The Tower disks are controlled by the Funhouse Key.");
                }
            }
        }
