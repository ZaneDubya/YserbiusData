using XPT.Generic.Maps;
using XPT.Twinion.Entities;

namespace XPT.Twinion.Maps {
    class TwMap03 : TwMap {
        protected override int MapIndex => 3;
        protected override int MapID => 0x0201;
        protected override int RandomEncounterChance => 12;
        protected override int RandomEncounterExtraCount => 0;

        private const int NPCINCORNER = 1;
        private const int MET_ELF = 2;
        private const int WENTTHRU = 3;
        private const int BEENROBBED = 4;
        private const int WESTENTRANCE = 5;
        private const int GULPEDWATER = 1;
        private const int SPRUNGTRAP = 2;
        protected override void FnEvent01(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "This portal leads back to the main entrance.");
            TELEPORT(player, type, doMsgs, 1, 1, 71, SOUTH);
        }
        protected override void FnEvent02(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You see another room through the east door.");
            TELEPORT(player, type, doMsgs, 2, 2, 160, EAST);
        }
        protected override void FnEvent03(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Another hall leads west through this door.");
            TELEPORT(player, type, doMsgs, 2, 3, 175, WEST);
        }
        protected override void FnEvent04(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "This may lead back to whence you came....");
            TELEPORT(player, type, doMsgs, 2, 2, 240, EAST);
        }
        protected override void FnEvent05(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "This must take you somewhere important....");
            TELEPORT(player, type, doMsgs, 2, 1, 85, NORTH);
        }
        protected override void FnEvent06(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GET_FLAG(player, type, doMsgs, ROOM, SPRUNGTRAP) == 0)) {
                SHOW_TEXT(player, type, doMsgs, "This portal will send you to the next level of the Queen's tests.");
                SET_FLAG(player, type, doMsgs, ROOM, SPRUNGTRAP, 1);
            }
            TELEPORT(player, type, doMsgs, 3, 1, 136, NORTH);
        }
        protected override void FnEvent07(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_RUNES(player, type, doMsgs, "You see a teleport.");
            TELEPORT(player, type, doMsgs, 2, 1, 7, WEST);
        }
        protected override void FnEvent08(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_RUNES(player, type, doMsgs, "You see a teleport.");
            TELEPORT(player, type, doMsgs, 2, 1, 9, EAST);
        }
        protected override void FnEvent09(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Where does this lead, you wonder...");
            TELEPORT(player, type, doMsgs, 2, 1, 0, WEST);
        }
        protected override void FnEvent0A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_RUNES(player, type, doMsgs, "BEHOLD: Here is the Twinion aqueduct, built by her majesty Queen Aeowyn for her loyal subjects' benefit. Long live the Queen!");
        }
        protected override void FnEvent0B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_RUNES(player, type, doMsgs, "DO NOT ENTER!");
        }
        protected override void FnEvent0C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_RUNES(player, type, doMsgs, "WRONG WAY!!!");
        }
        protected override void FnEvent0D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_RUNES(player, type, doMsgs, "For your own sake, can't you read??? TURN BACK!!");
        }
        protected override void FnEvent0E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_RUNES(player, type, doMsgs, "Okay, fine...don't listen to the warnings but see if I warn you again not to do something!!!");
        }
        protected override void FnEvent0F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GET_FLAG(player, type, doMsgs, DUNGEON, I_QUEST_LEFT) == 0)) {
                SHOW_TEXT(player, type, doMsgs, "Well done! Onward to more adventure...");
                SET_FLAG(player, type, doMsgs, DUNGEON, I_QUEST_LEFT, 1);
            }
        }
        protected override void FnEvent10(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GET_FLAG(player, type, doMsgs, DUNGEON, I_QUEST_RIGHT) == 0)) {
                SHOW_TEXT(player, type, doMsgs, "Well done! Onward to greater tests...");
                SET_FLAG(player, type, doMsgs, DUNGEON, I_QUEST_RIGHT, 1);
            }
        }
        protected override void FnEvent11(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Sounds of flowing water echo and cascade all around you, as you enter the corridors of the Aqueduct.");
        }
        protected override void FnEvent12(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "The water in the magical Aqueduct rushes by in a fierce torrent...");
        }
        protected override void FnEvent13(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "The treacherous undertow quickly pulls you under, drowning you as it has done so many others.");
            DAMAGE(player, type, doMsgs, MAX_HEALTH(player, type, doMsgs));
        }
        protected override void FnEvent14(TwPlayerServer player, MapEventType type, bool doMsgs) {
            NO_HEAL_ZONE(player, type, doMsgs);
            if ((GET_FLAG(player, type, doMsgs, ROOM, SPRUNGTRAP) == 0)) {
                if ((GET_FLAG(player, type, doMsgs, DUNGEON, KILLEDAQUEUS) == 0)) {
                    SHOW_TEXT(player, type, doMsgs, "The force of the Aqueduct's waters pound violently against your body...");
                    DAMAGE(player, type, doMsgs, MAX_HEALTH(player, type, doMsgs) / 8 + 1);
                    if (HEALTH(player, type, doMsgs) <= 0) {
                        SHOW_TEXT(player, type, doMsgs, "You have been drowned by the force.");
                    }
                }
                else {
                    SHOW_TEXT(player, type, doMsgs, "You've defeated Aqueus! You may travel safely through these waters.");
                }
                SET_FLAG(player, type, doMsgs, ROOM, SPRUNGTRAP, 1);
            }
        }
        private void PutDoor(TwPlayerServer player, MapEventType type, bool doMsgs) {
            PLACE_WALL_ITEM(player, type, doMsgs, DOOR, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
        }
        private void RoomSet(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SET_FLAG(player, type, doMsgs, ROOM, GULPEDWATER, 1);
        }
        private void WallBlock(TwPlayerServer player, MapEventType type, bool doMsgs) {
            BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
        }
        private void WallClear(TwPlayerServer player, MapEventType type, bool doMsgs) {
            CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
        }
        protected override void FnEvent15(TwPlayerServer player, MapEventType type, bool doMsgs) {
            BLOCK_FLOOR(player, type, doMsgs, HERE(player, type, doMsgs));
        }
        protected override void FnEvent16(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "The Aqueduct's current seems particularly violent and dangerous to the east...");
        }
        protected override void FnEvent17(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "This bridge seems stable enough... However, the water rushing below your feet makes you nervous.");
        }
        protected override void FnEvent18(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                if (GET_FLAG(player, type, doMsgs, DUNGEON, KILLEDAQUEUS) == 1) {
                    WallClear(player, type, doMsgs);
                    SHOW_TEXT(player, type, doMsgs, "Enter here, now that you've conquered Lord Aqueus.");
                }
                else {
                    WallBlock(player, type, doMsgs);
                    SHOW_TEXT(player, type, doMsgs, "Seek the protector of this Aqueduct in the west. His magic blocks your forward path.");
                }
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "You must pass through alone.");
                WallBlock(player, type, doMsgs);
            }
        }
        protected override void FnEvent19(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (USED_SKILL(player, type, doMsgs, DETECT_SKILL) >= 6 || USED_SPELL(player, type, doMsgs, TRUE_SEEING_SPELL) || USED_ITEM(player, type, doMsgs, HELMOFWISDOM, HELMOFWISDOM) || USED_ITEM(player, type, doMsgs, VALKYRIESHELM, VALKYRIESHELM) || USED_ITEM(player, type, doMsgs, RINGOFTHIEVES, RINGOFTHIEVES) || USED_ITEM(player, type, doMsgs, CRYSTALBALL, CRYSTALBALL)) {
                SHOW_TEXT(player, type, doMsgs, "You've located a secret passageway!!");
                WallClear(player, type, doMsgs);
                PutDoor(player, type, doMsgs);
            }
            else {
                WallBlock(player, type, doMsgs);
                SHOW_TEXT(player, type, doMsgs, "There seems to be a subtle draft coming from a nearby wall.");
            }
        }
        protected override void FnEvent1A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, DUNGEON, ONE_AND_THREE_DONE) == 2) {
                SHOW_TEXT(player, type, doMsgs, "You've passed here before! Onward with you!");
                WallClear(player, type, doMsgs);
            }
            else if (GET_FLAG(player, type, doMsgs, DUNGEON, ONE_AND_THREE_DONE) == 1) {
                SHOW_TEXT(player, type, doMsgs, "A female voice whispers: 'You've so far passed our test with high marks.");
                SHOW_TEXT(player, type, doMsgs, "Let's see how well you finish it.'");
                WallClear(player, type, doMsgs);
                PutDoor(player, type, doMsgs);
                MOD_EXP(player, type, doMsgs, 2500);
                SET_FLAG(player, type, doMsgs, DUNGEON, ONE_AND_THREE_DONE, 2);
            }
            else if (GET_FLAG(player, type, doMsgs, DUNGEON, I_QUEST_RIGHT) == 3 && GET_FLAG(player, type, doMsgs, DUNGEON, I_QUEST_LEFT) == 3) {
                SHOW_TEXT(player, type, doMsgs, "A woman's voice carries on the wind: 'You have completed enough to carry forward.");
                SHOW_TEXT(player, type, doMsgs, "I pray thee, complete more and return later.'");
                WallClear(player, type, doMsgs);
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "A woman's voice carries on the wind: 'Come back when you've done more of this quest.'");
                WallBlock(player, type, doMsgs);
            }
        }
        protected override void FnEvent1B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, PARTY, WENTTHRU) == 1) {
                SHOW_TEXT(player, type, doMsgs, "Now, to your reward for this trial...");
                WallClear(player, type, doMsgs);
                PutDoor(player, type, doMsgs);
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "Continue northward through the rest of this corner, my heroes...");
                WallBlock(player, type, doMsgs);
            }
        }
        protected override void FnEvent1C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                if ((GET_FLAG(player, type, doMsgs, DUNGEON, I_QUEST_LEFT) == 0) && (GET_FLAG(player, type, doMsgs, DUNGEON, I_QUEST_RIGHT) == 0)) {
                    SHOW_TEXT(player, type, doMsgs, "This direction is open to you.");
                    WallClear(player, type, doMsgs);
                }
                else if (FLAG_ON(player, type, doMsgs, DUNGEON, I_QUEST_RIGHT) && (GET_FLAG(player, type, doMsgs, DUNGEON, I_QUEST_LEFT) == 0)) {
                    SHOW_TEXT(player, type, doMsgs, "The eastern door is sealed shut.");
                    BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), EAST);
                    CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), SOUTH);
                }
                else if (FLAG_ON(player, type, doMsgs, DUNGEON, I_QUEST_LEFT) && (GET_FLAG(player, type, doMsgs, DUNGEON, I_QUEST_RIGHT) == 0)) {
                    SHOW_TEXT(player, type, doMsgs, "The southern door is sealed shut.");
                    BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), SOUTH);
                    CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), EAST);
                }
                else {
                    SHOW_TEXT(player, type, doMsgs, "The doors are sealed.");
                    WallBlock(player, type, doMsgs);
                }
            }
            else {
                WallBlock(player, type, doMsgs);
                SHOW_TEXT(player, type, doMsgs, "You must start from here alone.");
            }
        }
        protected override void FnEvent1D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, ELFBARBARIAN);
            if ((GET_FLAG(player, type, doMsgs, PARTY, MET_ELF) == 0)) {
                SHOW_TEXT(player, type, doMsgs, "You encounter a soaking wet elf, wringing out her clothes. 'Her majesty's idea of draining the River of Eternity is a good one, albeit a bit late for my brother.'");
                SET_FLAG(player, type, doMsgs, PARTY, MET_ELF, 1);
            }
            else if (GET_FLAG(player, type, doMsgs, PARTY, MET_ELF) == 1) {
                SHOW_TEXT(player, type, doMsgs, "'Beware of the strong currents of this vile water.'");
                SET_FLAG(player, type, doMsgs, PARTY, MET_ELF, 2);
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "The elf stares blankly at the waters.");
            }
        }
        protected override void FnEvent1E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short mn = 0;
            short mn2 = 0;
            short mn3 = 0;
            short mn4 = 0;
            short g2 = 0;
            short g3 = 0;
            short g4 = 0;
            switch (PARTY_COUNT(player, type, doMsgs)) {
                case 1:
                    mn = 37;
                    mn2 = 37;
                    g2 = 2;
                    break;
                case 2:
                    mn = 37;
                    mn2 = 37;
                    mn3 = 38;
                    g2 = 2;
                    g3 = 4;
                    break;
                default:
                    mn = 33;
                    mn2 = 33;
                    mn3 = 38;
                    mn4 = 38;
                    g2 = 2;
                    g3 = 5;
                    g4 = 6;
                    break;
            }
            GET_MONSTER(player, type, doMsgs, 01, mn);
            if (g2 != 0) {
                GET_MONSTER(player, type, doMsgs, g2, mn2);
                if (g3 != 0) {
                    GET_MONSTER(player, type, doMsgs, g3, mn3);
                    if (g4 != 0) {
                        GET_MONSTER(player, type, doMsgs, g4, mn4);
                    }
                }
            }
        }
        protected override void FnEvent1F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short mn = 0;
            short mn2 = 0;
            short mn3 = 0;
            short mn4 = 0;
            short g2 = 0;
            short g3 = 0;
            short g4 = 0;
            switch (PARTY_COUNT(player, type, doMsgs)) {
                case 1:
                    mn = 34;
                    mn2 = 36;
                    g2 = 5;
                    break;
                case 2:
                    mn = 34;
                    mn2 = 36;
                    mn3 = 35;
                    g2 = 2;
                    g3 = 5;
                    break;
                default:
                    mn = 35;
                    mn2 = 35;
                    mn3 = 35;
                    mn4 = 36;
                    g2 = 2;
                    g3 = 3;
                    g4 = 4;
                    break;
            }
            GET_MONSTER(player, type, doMsgs, 01, mn);
            if (g2 != 0) {
                GET_MONSTER(player, type, doMsgs, g2, mn2);
                if (g3 != 0) {
                    GET_MONSTER(player, type, doMsgs, g3, mn3);
                    if (g4 != 0) {
                        GET_MONSTER(player, type, doMsgs, g4, mn4);
                    }
                }
            }
        }
        protected override void FnEvent20(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short i = 0;
            if (HERE(player, type, doMsgs) == 228) {
                SET_BOOTY(player, type, doMsgs, REDLOCKPICK, 0, 0, 0, 0, 100);
            }
            for (i = 1; i <= 3; i++) {
                GET_MONSTER(player, type, doMsgs, i, 5);
            }
        }
        protected override void FnEvent21(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short mn = 0;
            short mn2 = 0;
            short mn3 = 0;
            short g2 = 0;
            short g3 = 0;
            switch (PARTY_COUNT(player, type, doMsgs)) {
                case 1:
                    mn = 3;
                    mn2 = 3;
                    g2 = 2;
                    break;
                case 2:
                    mn = 3;
                    mn2 = 4;
                    g2 = 2;
                    break;
                default:
                    mn = 3;
                    mn2 = 4;
                    mn3 = 5;
                    g2 = 2;
                    g3 = 6;
                    break;
            }
            GET_MONSTER(player, type, doMsgs, 01, mn);
            if (g2 != 0) {
                GET_MONSTER(player, type, doMsgs, g2, mn2);
                if (g3 != 0) {
                    GET_MONSTER(player, type, doMsgs, g3, mn3);
                }
            }
        }
        protected override void FnEvent22(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 37);
                GET_MONSTER(player, type, doMsgs, 02, 37);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 37);
                GET_MONSTER(player, type, doMsgs, 02, 37);
                GET_MONSTER(player, type, doMsgs, 03, 38);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 33);
                GET_MONSTER(player, type, doMsgs, 02, 33);
                GET_MONSTER(player, type, doMsgs, 03, 38);
                GET_MONSTER(player, type, doMsgs, 04, 38);
            }
        }
        protected override void FnEvent23(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short i = 0;
            SHOW_TEXT(player, type, doMsgs, "You approach a band of Warriors, who howl furiously as they charge you with axes held high.");
            switch (PARTY_COUNT(player, type, doMsgs)) {
                case 1:
                    for (i = 1; i <= 3; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 38);
                    }
                    break;
                default:
                    for (i = 1; i <= 6; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 38);
                    }
                    break;
            }
        }
        protected override void FnEvent24(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "A party of adventurers springs at you!");
            switch (PARTY_COUNT(player, type, doMsgs)) {
                case 1:
                    GET_MONSTER(player, type, doMsgs, 01, 10);
                    GET_MONSTER(player, type, doMsgs, 02, 18);
                    break;
                case 2:
                    GET_MONSTER(player, type, doMsgs, 01, 10);
                    GET_MONSTER(player, type, doMsgs, 02, 18);
                    GET_MONSTER(player, type, doMsgs, 05, 23);
                    GET_MONSTER(player, type, doMsgs, 06, 27);
                    break;
                default:
                    GET_MONSTER(player, type, doMsgs, 01, 10);
                    GET_MONSTER(player, type, doMsgs, 02, 18);
                    GET_MONSTER(player, type, doMsgs, 03, 23);
                    GET_MONSTER(player, type, doMsgs, 04, 27);
                    GET_MONSTER(player, type, doMsgs, 05, 12);
                    GET_MONSTER(player, type, doMsgs, 06, 31);
                }
            }
            protected override void FnEvent25(TwPlayerServer player, MapEventType type, bool doMsgs) {
                SHOW_TEXT(player, type, doMsgs, "Some worthy opponents challenge you to combat...");
                GET_MONSTER(player, type, doMsgs, 01, 15);
                GET_MONSTER(player, type, doMsgs, 02, 21);
                GET_MONSTER(player, type, doMsgs, 03, 22);
                GET_MONSTER(player, type, doMsgs, 04, 23);
            }
            protected override void FnEvent26(TwPlayerServer player, MapEventType type, bool doMsgs) {
                short itemA = 0;
                if ((GET_FLAG(player, type, doMsgs, DUNGEON, NPCGIFTONE) == 0)) {
                    SHOW_PICTURE(player, type, doMsgs, ORCRANGER);
                    SHOW_TEXT(player, type, doMsgs, "'Well done! You managed to complete that simple maze of doors.  A gift of experience, gold and booty is yours.'");
                    SET_FLAG(player, type, doMsgs, DUNGEON, NPCGIFTONE, 1);
                    switch (GUILD(player, type, doMsgs)) {
                        case BARBARIAN:
                            itemA = STONECLUB;
                            break;
                        case KNIGHT:
                            itemA = CHAINMAIL;
                            break;
                        case RANGER:
                            itemA = CHAINMAIL;
                            break;
                        case THIEF:
                            itemA = BLOODSHIELD;
                            break;
                        case CLERIC:
                            itemA = FREEDOMRING;
                            break;
                        case WIZARD:
                            itemA = QUARTERSTAFF;
                            break;
                    }
                    GIVE_ITEM(player, type, doMsgs, itemA);
                    MOD_GOLD(player, type, doMsgs, 500);
                    MOD_EXP(player, type, doMsgs, 400);
                }
                else {
                    SHOW_TEXT(player, type, doMsgs, "The ranger is gone.");
                }
            }
            protected override void FnEvent27(TwPlayerServer player, MapEventType type, bool doMsgs) {
                if ((GET_FLAG(player, type, doMsgs, PARTY, BEENROBBED) == 0)) {
                    SHOW_TEXT(player, type, doMsgs, "A nimble thief lifts a sack of gold from you.");
                    SHOW_TEXT(player, type, doMsgs, "'Hmmm, what a lovely purse! Perchance I will find its twin once I've dispensed with you!'");
                    MOD_GOLD(player, type, doMsgs,  - 500);
                    GET_MONSTER(player, type, doMsgs, 01, 25);
                }
            }
            protected override void FnEvent28(TwPlayerServer player, MapEventType type, bool doMsgs) {
                if (GET_FLAG(player, type, doMsgs, PARTY, NPCINCORNER) == 0) {
                    SHOW_PICTURE(player, type, doMsgs, HALFLINGTHIEF);
                    SHOW_TEXT(player, type, doMsgs, "A dying thief lies on the floor. 'Forgive my brethren. They know only to survive...'");
                    SHOW_TEXT(player, type, doMsgs, "He then collapses, dead.");
                    SET_FLAG(player, type, doMsgs, PARTY, NPCINCORNER, 1);
                }
                else {
                    SHOW_TEXT(player, type, doMsgs, "'You have done this...murderers!!!!!'");
                    SET_BOOTY(player, type, doMsgs, KATANA, NUNCHUKAS, 0, 0, 0, 2000);
                    GET_MONSTER(player, type, doMsgs, 01, 26);
                    GET_MONSTER(player, type, doMsgs, 02, 26);
                    GET_MONSTER(player, type, doMsgs, 05, 25);
                    GET_MONSTER(player, type, doMsgs, 06, 40);
                }
            }
            protected override void FnEvent29(TwPlayerServer player, MapEventType type, bool doMsgs) {
                short i = 0;
                if (GET_FLAG(player, type, doMsgs, DUNGEON, NPCGIFTONE) <= 1) {
                    SHOW_PICTURE(player, type, doMsgs, HALFLINGTHIEF);
                    SHOW_TEXT(player, type, doMsgs, "'How lovely, what marvelous gold you had...'");
                    MOD_GOLD(player, type, doMsgs,  - 250);
                    SHOW_TEXT(player, type, doMsgs, "'A thousand gratitudes for your generosity.'");
                    SET_FLAG(player, type, doMsgs, DUNGEON, NPCGIFTONE, 2);
                }
                else if (GET_FLAG(player, type, doMsgs, DUNGEON, NPCGIFTONE) == 2) {
                    SHOW_TEXT(player, type, doMsgs, "A familiar pickpocket is here with some of his friends. Now's your chance!");
                    SET_BOOTY(player, type, doMsgs, LONGSWORD, TRANCETALISMAN, 0, 0, 0, 250);
                    SET_FLAG(player, type, doMsgs, DUNGEON, NPCGIFTONE, 3);
                }
                for (i = 1; i <= 3; i++) {
                    GET_MONSTER(player, type, doMsgs, i, 26);
                }
            }
            protected override void FnEvent2A(TwPlayerServer player, MapEventType type, bool doMsgs) {
                SHOW_PICTURE(player, type, doMsgs, ELFBARBARIAN);
                SHOW_TEXT(player, type, doMsgs, "The elf you met earlier is here, now drying out from her travels.");
                if ((GET_FLAG(player, type, doMsgs, PARTY, MET_ELF) == 0) || GET_FLAG(player, type, doMsgs, PARTY, MET_ELF) == 2) {
                    SHOW_TEXT(player, type, doMsgs, "'Hmm...if right were first, left would be worse... If left were before, the bridge would lead thru the door... Very confusing...'");
                    SET_FLAG(player, type, doMsgs, PARTY, MET_ELF, 3);
                }
                else if (GET_FLAG(player, type, doMsgs, PARTY, MET_ELF) == 3) {
                    SHOW_TEXT(player, type, doMsgs, "'I guess you must do one of the other rooms on this level first. Then come back here to go on.'");
                }
                else {
                    SHOW_TEXT(player, type, doMsgs, "She pays no attention to you.");
                    SET_FLAG(player, type, doMsgs, PARTY, MET_ELF, 2);
                }
            }
            protected override void FnEvent2B(TwPlayerServer player, MapEventType type, bool doMsgs) {
                if ((GET_FLAG(player, type, doMsgs, ROOM, GULPEDWATER) == 0)) {
                    SHOW_PICTURE(player, type, doMsgs, DWARFKNIGHT);
                    SHOW_TEXT(player, type, doMsgs, "'You dare think you can challenge me...you with your puny stature? Away with you!!'");
                    SHOW_TEXT(player, type, doMsgs, "So saying, this massive knight flies into a rage, critically wounding all in his path as he marches off.");
                    DAMAGE(player, type, doMsgs, MAX_HEALTH(player, type, doMsgs) / 2);
                    if (HEALTH(player, type, doMsgs) <= 0) {
                        SHOW_TEXT(player, type, doMsgs, "You have died.");
                        DungXit(player, type, doMsgs);
                    }
                    DAMAGE(player, type, doMsgs, HEALTH(player, type, doMsgs) / 2);
                    RoomSet(player, type, doMsgs);
                }
            }
            protected override void FnEvent2C(TwPlayerServer player, MapEventType type, bool doMsgs) {
                SHOW_PICTURE(player, type, doMsgs, DWARFTHIEF);
                SHOW_TEXT(player, type, doMsgs, "A nimble thief steps from the shadows in front of you.");
                if (GET_FLAG(player, type, doMsgs, DUNGEON, GOTSCAR) == 1) {
                    SHOW_TEXT(player, type, doMsgs, "The thief glances in your direction, sees his mark, and ignores you.");
                }
                else if (FLAG_ON(player, type, doMsgs, DUNGEON, I_QUEST_RIGHT) == 1 && FLAG_ON(player, type, doMsgs, DUNGEON, I_QUEST_LEFT) == 1 || GET_FLAG(player, type, doMsgs, DUNGEON, KILLEDAQUEUS) == 1) {
                    SET_FLAG(player, type, doMsgs, DUNGEON, ONE_AND_THREE_DONE, 1);
                    SHOW_TEXT(player, type, doMsgs, "'A scar for you to prove you've done this task. Pray thee, continue south.'");
                    DAMAGE(player, type, doMsgs, HEALTH(player, type, doMsgs) / 10);
                    SET_FLAG(player, type, doMsgs, DUNGEON, GOTSCAR, 1);
                }
                else {
                    SHOW_TEXT(player, type, doMsgs, "'AH HA! Too much gold in your purse! Allow me...");
                    MOD_GOLD(player, type, doMsgs,  - 300);
                    SHOW_TEXT(player, type, doMsgs, "Complete the tasks at hand before you attempt the quests east of here!'");
                    DAMAGE(player, type, doMsgs, HEALTH(player, type, doMsgs) / 2);
                    TELEPORT(player, type, doMsgs, 2, 1, 121, NORTH);
                }
            }
            protected override void FnEvent2D(TwPlayerServer player, MapEventType type, bool doMsgs) {
                NO_HEAL_ZONE(player, type, doMsgs);
                if ((GET_FLAG(player, type, doMsgs, ROOM, GULPEDWATER) == 0)) {
                    ROTATE(player, type, doMsgs, EAST);
                    SHOW_TEXT(player, type, doMsgs, "The swirling currents here batter and sting your body.");
                    DAMAGE(player, type, doMsgs, MAX_HEALTH(player, type, doMsgs) / 4 + 1);
                    if (HEALTH(player, type, doMsgs) <= 0) {
                        SHOW_TEXT(player, type, doMsgs, "You have been drowned by the force.");
                        DungXit(player, type, doMsgs);
                    }
                    RoomSet(player, type, doMsgs);
                }
            }
            protected override void FnEvent2E(TwPlayerServer player, MapEventType type, bool doMsgs) {
                if (USED_SKILL(player, type, doMsgs, LOCKPICK_SKILL) == 12 || USED_ITEM(player, type, doMsgs, HELMOFGUILE, HELMOFGUILE) || USED_ITEM(player, type, doMsgs, REDLOCKPICK, BLUELOCKPICK)) {
                    SHOW_TEXT(player, type, doMsgs, "You unlock the door.");
                    WallClear(player, type, doMsgs);
                }
                else {
                    WallBlock(player, type, doMsgs);
                    SHOW_TEXT(player, type, doMsgs, "An impressive lock bars this shortcut from you.");
                }
            }
            protected override void FnEvent2F(TwPlayerServer player, MapEventType type, bool doMsgs) {
                SHOW_TEXT(player, type, doMsgs, "Ah, an easy task, but necessary all the same.");
                SET_FLAG(player, type, doMsgs, PARTY, WENTTHRU, 1);
            }
            protected override void FnEvent30(TwPlayerServer player, MapEventType type, bool doMsgs) {
                NO_SPELL(player, type, doMsgs);
                if (GET_FLAG(player, type, doMsgs, DUNGEON, I_QUEST_LEFT) == 1) {
                    SET_FLAG(player, type, doMsgs, DUNGEON, I_QUEST_LEFT, 2);
                    Iquest(player, type, doMsgs);
                }
                else if (GET_FLAG(player, type, doMsgs, DUNGEON, I_QUEST_RIGHT) == 1) {
                    SET_FLAG(player, type, doMsgs, DUNGEON, I_QUEST_RIGHT, 2);
                    Iquest(player, type, doMsgs);
                }
            }
            private void Iquest(TwPlayerServer player, MapEventType type, bool doMsgs) {
                SHOW_TEXT(player, type, doMsgs, "You are granted experience and gold for your completion of this side.");
                MOD_EXP(player, type, doMsgs, 1200);
                MOD_GOLD(player, type, doMsgs, 750);
            }
            protected override void FnEvent31(TwPlayerServer player, MapEventType type, bool doMsgs) {
                if (PARTY_COUNT(player, type, doMsgs) == 1) {
                    if (GET_FLAG(player, type, doMsgs, DUNGEON, DIDPATH) == 1 || GET_FLAG(player, type, doMsgs, DUNGEON, DIDPATH) == 2) {
                        SHOW_TEXT(player, type, doMsgs, "A door appears in the wall!");
                        SHOW_TEXT(player, type, doMsgs, "The magical gate has recognized the marks of your achievements.");
                        WallClear(player, type, doMsgs);
                    }
                    else {
                        SHOW_TEXT(player, type, doMsgs, "Return here, once you've completed what must be done elsewhere.");
                    }
                }
                else {
                    WallBlock(player, type, doMsgs);
                    SHOW_TEXT(player, type, doMsgs, "You must proceed alone.");
                }
            }
            protected override void FnEvent32(TwPlayerServer player, MapEventType type, bool doMsgs) {
                if (GET_FLAG(player, type, doMsgs, DUNGEON, UPPERROPE) == 1) {
                    SHOW_TEXT(player, type, doMsgs, "There is nothing here.");
                }
                else {
                    SHOW_TEXT(player, type, doMsgs, "You find a coil of rope here. You'd better tuck it away for safe keeping.");
                    GIVE_ITEM(player, type, doMsgs, ROPE);
                    SET_FLAG(player, type, doMsgs, DUNGEON, UPPERROPE, 1);
                }
            }
            protected override void FnEvent33(TwPlayerServer player, MapEventType type, bool doMsgs) {
                SET_FLAG(player, type, doMsgs, PARTY, BEENROBBED, 1);
            }
            protected override void FnEvent34(TwPlayerServer player, MapEventType type, bool doMsgs) {
                if (USED_ITEM(player, type, doMsgs, GREENLOCKPICK, BLUELOCKPICK) || USED_SKILL(player, type, doMsgs, LOCKPICK_SKILL) > 4 || USED_ITEM(player, type, doMsgs, HELMOFGUILE, HELMOFGUILE)) {
                    WallClear(player, type, doMsgs);
                    SHOW_TEXT(player, type, doMsgs, "You manage to pick the rusty lock.");
                }
                else {
                    WallBlock(player, type, doMsgs);
                    SHOW_TEXT(player, type, doMsgs, "An iron door with a rusty lock blocks your way here.");
                }
            }
            protected override void FnEvent35(TwPlayerServer player, MapEventType type, bool doMsgs) {
                short flag = 0;
                switch (HERE(player, type, doMsgs)) {
                    case 228:
                        flag = 1;
                        break;
                    case 235:
                        flag = 2;
                        break;
                }
                SET_FLAG(player, type, doMsgs, PARTY, WESTENTRANCE, flag);
            }
            protected override void FnEvent36(TwPlayerServer player, MapEventType type, bool doMsgs) {
                short flag = 0;
                switch (HERE(player, type, doMsgs)) {
                    case 216:
                    case 234:
                        flag = 2;
                        break;
                    case 213:
                    case 230:
                        flag = 1;
                        break;
                }
                if (GET_FLAG(player, type, doMsgs, PARTY, WESTENTRANCE) >= flag) {
                    PutDoor(player, type, doMsgs);
                    WallClear(player, type, doMsgs);
                    SHOW_TEXT(player, type, doMsgs, "As long as you remain in this map, you may use this door. Upon leaving the map, it will vanish.");
                    switch (HERE(player, type, doMsgs)) {
                        case 216:
                        case 234:
                            SHOW_TEXT(player, type, doMsgs, "You must re-enter the area east of here to to make the door reappear.");
                            break;
                        case 213:
                        case 230:
                            SHOW_TEXT(player, type, doMsgs, "You must enter the maze south of here to open it again!");
                            break;
                    }
                }
            }
            protected override void FnEvent37(TwPlayerServer player, MapEventType type, bool doMsgs) {
                NO_JOIN(player, type, doMsgs);
                SHOW_TEXT(player, type, doMsgs, "You cannot join together here.");
            }
            protected override void FnEvent38(TwPlayerServer player, MapEventType type, bool doMsgs) {
                byte where = 0;
                where = HERE(player, type, doMsgs);
                 + 16;
                if (PARTY_COUNT(player, type, doMsgs) > 1) {
                    TELEPORT(player, type, doMsgs, 2, 1, where, SOUTH);
                }
            }
        }
    }
