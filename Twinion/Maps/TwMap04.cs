using XPT.Generic.Maps;
using XPT.Twinion.Entities;

namespace XPT.Twinion.Maps {
    class TwMap04 : TwMap {
        protected override int MapIndex => 4;
        protected override int MapID => 0x0202;
        protected override int RandomEncounterChance => 12;
        protected override int RandomEncounterExtraCount => 1;

        private const int METGUARD = 1;
        private const int HALFTHIEF = 2;
        private const int WESTSIDE = 3;
        private const int EASTSIDE = 4;
        private const int GOODBOOTY = 7;
        private const int IRONSWORD = 8;
        private const int CLUBIT = 9;
        private const int FIGHT25 = 10;
        private const int METCLERIC = 11;
        private const int SPRUNGTRAP = 1;
        private void WallBlock(TwPlayerServer player, MapEventType type, bool doMsgs) {
            BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
        }
        protected override void FnEvent01(TwPlayerServer player, MapEventType type, bool doMsgs) {
            NO_HEAL_ZONE(player, type, doMsgs);
            if ((GET_FLAG(player, type, doMsgs, ROOM, SPRUNGTRAP) == 0)) {
                if ((GET_FLAG(player, type, doMsgs, DUNGEON, KILLEDAQUEUS) == 0)) {
                    SHOW_TEXT(player, type, doMsgs, "The rushing waters pummel your body.");
                    DAMAGE(player, type, doMsgs, MAX_HEALTH(player, type, doMsgs) / 8 + 1);
                    if (HEALTH(player, type, doMsgs) <= 0) {
                        SHOW_TEXT(player, type, doMsgs, "You have been drowned by the force.");
                    }
                }
                else {
                    SHOW_TEXT(player, type, doMsgs, "You've defeated Aqueus! You may travel safely through these waters now.");
                }
                SET_FLAG(player, type, doMsgs, ROOM, SPRUNGTRAP, 1);
            }
        }
        private void SpringTrap(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SET_FLAG(player, type, doMsgs, ROOM, SPRUNGTRAP, 1);
        }
        protected override void FnEvent02(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "The magical force of the pump propels you southeastward and slams you squarely into a wall.");
            DAMAGE(player, type, doMsgs, HEALTH(player, type, doMsgs) / 2);
            TELEPORT(player, type, doMsgs, 2, 2, 170, EAST);
        }
        protected override void FnEvent03(TwPlayerServer player, MapEventType type, bool doMsgs) {
            BLOCK_FLOOR(player, type, doMsgs, HERE(player, type, doMsgs));
        }
        protected override void FnEvent04(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "To the other shore...");
            TELEPORT(player, type, doMsgs, 2, 2, 189, EAST);
        }
        protected override void FnEvent05(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Closer and closer you go.");
            TELEPORT(player, type, doMsgs, 2, 2, 3, EAST);
        }
        protected override void FnEvent06(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((HERE(player, type, doMsgs) == 53) && ((GET_FLAG(player, type, doMsgs, DUNGEON, DIDPATH) == 0) || GET_FLAG(player, type, doMsgs, DUNGEON, DIDPATH) == 1)) {
                SET_FLAG(player, type, doMsgs, DUNGEON, DIDPATH, 2);
                MOD_EXP(player, type, doMsgs, 2000);
                MOD_GOLD(player, type, doMsgs, 1200);
                SHOW_TEXT(player, type, doMsgs, "Take this experience and these coins to aid thee in thy travels!");
            }
            SHOW_TEXT(player, type, doMsgs, "And yet one step further along the path.");
            TELEPORT(player, type, doMsgs, 2, 2, 224, EAST);
        }
        protected override void FnEvent07(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Westward takes you back to the main Aqueduct.");
            TELEPORT(player, type, doMsgs, 2, 1, 255, WEST);
        }
        protected override void FnEvent08(TwPlayerServer player, MapEventType type, bool doMsgs) {
            WallBlock(player, type, doMsgs);
            SHOW_PICTURE(player, type, doMsgs, DWARFKNIGHT);
            SHOW_TEXT(player, type, doMsgs, "A magical wall bars you from moving any closer to the prisoner in the southern cell.");
        }
        protected override void FnEvent09(TwPlayerServer player, MapEventType type, bool doMsgs) {
            WallBlock(player, type, doMsgs);
            SHOW_PICTURE(player, type, doMsgs, TROLLRANGER);
            SHOW_TEXT(player, type, doMsgs, "A mystical force prevents access southward to another prisoner in the Aqueduct's cells.");
        }
        protected override void FnEvent0A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            WallBlock(player, type, doMsgs);
            SHOW_PICTURE(player, type, doMsgs, COELUS);
            SHOW_TEXT(player, type, doMsgs, "A hulking beast is imprisoned southward behind some unseen forces of magic.");
        }
        protected override void FnEvent0B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            WallBlock(player, type, doMsgs);
            SHOW_TEXT(player, type, doMsgs, "An unseen force holds you back.");
        }
        protected override void FnEvent0C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "BEHOLD: This tower was built by Queen Aeowyn to control the force of the Aqueduct as it leaves this place. Hail her Royal Highness!");
        }
        protected override void FnEvent0D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "This path leads back whence you came.");
            TELEPORT(player, type, doMsgs, 2, 1, 175, WEST);
        }
        protected override void FnEvent0E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Do not forsake your loyal friends.");
            SHOW_TEXT(player, type, doMsgs, "WARNING: DO NOT READ THIS SIGN!");
        }
        protected override void FnEvent0F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "For true friendship can bridge time...");
            SHOW_TEXT(player, type, doMsgs, "I'M TELLING YOU - STOP READING THIS!");
        }
        protected override void FnEvent10(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Personal sacrifice will send your friends forward.");
            SHOW_TEXT(player, type, doMsgs, "I CAN'T BELIEVE YOU DON'T LISTEN TO ME!");
            SHOW_TEXT(player, type, doMsgs, "Obviously some vandalish rogues have been at these signs.");
        }
        protected override void FnEvent11(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Well done!  Westward now and hurry. You're almost to the end of the Proving Grounds!");
            if ((GET_FLAG(player, type, doMsgs, DUNGEON, DIDPATH) == 0)) {
                SET_FLAG(player, type, doMsgs, DUNGEON, DIDPATH, 1);
            }
        }
        protected override void FnEvent12(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, DUNGEON, CROSSBRIDGE) == 1) {
                CLEAR_FLOOR(player, type, doMsgs, 142);
                CLEAR_FLOOR(player, type, doMsgs, 126);
                CLEAR_FLOOR(player, type, doMsgs, 158);
                PLACE_FLOOR_ITEM(player, type, doMsgs, 1, 142);
                PLACE_FLOOR_ITEM(player, type, doMsgs, 1, 126);
                PLACE_FLOOR_ITEM(player, type, doMsgs, 1, 158);
                SHOW_TEXT(player, type, doMsgs, "You stand midway between the two watch towers. The view really is quite magnificent.");
                SHOW_TEXT(player, type, doMsgs, "Invisible forces keep you from falling off the bridge into the icy waters below.");
                BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), WEST);
                BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), EAST);
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "You stand directly below a narrow bridge that spans the Aqueduct. Eastward is a great waterfall that pours from the side of the volcano.");
            }
        }
        protected override void FnEvent13(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "This majestic meeting hall bustles with commerce.");
            SHOW_TEXT(player, type, doMsgs, "The walls reverberate with the din of haggling and betrayal.");
        }
        protected override void FnEvent14(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "None of the merchants wishes to deal with you.");
            SHOW_TEXT(player, type, doMsgs, "Perhaps another time, when you have items worth their interest.");
        }
        protected override void FnEvent15(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (USED_ITEM(player, type, doMsgs, CROSSKEY, CROSSKEY)) {
                SHOW_TEXT(player, type, doMsgs, "The Cross Key easily unlocks the door.");
                CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
                PLACE_WALL_ITEM(player, type, doMsgs, DOOR, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "A strange keyhole, marked with an X, obviously suggests that a special key is needed to unlock this door.");
            }
        }
        protected override void FnEvent16(TwPlayerServer player, MapEventType type, bool doMsgs) {
            NO_JOIN(player, type, doMsgs);
            if (GET_FLAG(player, type, doMsgs, PARTY, METGUARD) == 0) {
                SHOW_PICTURE(player, type, doMsgs, DWARFKNIGHT);
                SHOW_TEXT(player, type, doMsgs, "One of the Queen's Guard is here.");
                SHOW_TEXT(player, type, doMsgs, "'Away with you.  I have no time to waste with the likes of you.'");
                SET_FLAG(player, type, doMsgs, PARTY, METGUARD, 1);
            }
            else if (GET_FLAG(player, type, doMsgs, PARTY, METGUARD) == 1) {
                SHOW_PICTURE(player, type, doMsgs, DWARFKNIGHT);
                SHOW_TEXT(player, type, doMsgs, "The guard is still here.");
                SHOW_TEXT(player, type, doMsgs, "'What now?  Stop bothering me or I shall be forced to remove you.'");
                SET_FLAG(player, type, doMsgs, PARTY, METGUARD, 2);
            }
            else if (GET_FLAG(player, type, doMsgs, PARTY, METGUARD) == 2) {
                SHOW_TEXT(player, type, doMsgs, "'ENOUGH! Have at you!'");
                SET_FLAG(player, type, doMsgs, PARTY, METGUARD, 0);
                GET_MONSTER(player, type, doMsgs, 01, 30);
            }
        }
        protected override void FnEvent17(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, GNOMEWIZARD);
            SHOW_TEXT(player, type, doMsgs, "You notice a variety of levers on the wall here.");
            SHOW_TEXT(player, type, doMsgs, "'Welcome to the tower! Don't play with the switches, please.  And please be careful on the bridge.'");
            SET_FLAG(player, type, doMsgs, DUNGEON, CROSSBRIDGE, 1);
            CLEAR_FLOOR(player, type, doMsgs, 142);
            CLEAR_FLOOR(player, type, doMsgs, 126);
            CLEAR_FLOOR(player, type, doMsgs, 158);
            PLACE_FLOOR_ITEM(player, type, doMsgs, 1, 142);
            PLACE_FLOOR_ITEM(player, type, doMsgs, 1, 126);
            PLACE_FLOOR_ITEM(player, type, doMsgs, 1, 158);
        }
        protected override void FnEvent18(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GET_FLAG(player, type, doMsgs, DUNGEON, SETDUCTSWITCH) == 0)) {
                Change(player, type, doMsgs);
                SHOW_TEXT(player, type, doMsgs, "You hear the sounds of locking mechanisms being released by the opening of the sluice gates; as if some doors off to the west are now unlocked!");
                SET_FLAG(player, type, doMsgs, DUNGEON, SETDUCTSWITCH, 1);
            }
            else {
                Change(player, type, doMsgs);
                SHOW_TEXT(player, type, doMsgs, "The sluice gates have been closed, slowing the waters' flow. A low rumbling sound can be heard as though some mechanism has just been locked down again.");
                SET_FLAG(player, type, doMsgs, DUNGEON, SETDUCTSWITCH, 0);
            }
        }
        private void Change(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You fiddle with the various switches here against the watchman's advice. Upon hitting an odd-shaped lever, you hear the sound of the Aqueduct change.");
        }
        protected override void FnEvent19(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GET_FLAG(player, type, doMsgs, PARTY, CLUBIT) == 0)) {
                SET_BOOTY(player, type, doMsgs, LONGBOW, ROUNDSHIELD, 0, 0, 0, 500);
            }
            SHOW_TEXT(player, type, doMsgs, "Rogues rush at you from the shadows.");
            SET_FLAG(player, type, doMsgs, PARTY, CLUBIT, 1);
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 28);
                GET_MONSTER(player, type, doMsgs, 05, 29);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 28);
                GET_MONSTER(player, type, doMsgs, 02, 28);
                GET_MONSTER(player, type, doMsgs, 05, 29);
            }
        }
        protected override void FnEvent1A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GET_FLAG(player, type, doMsgs, PARTY, FIGHT25) == 0)) {
                SET_BOOTY(player, type, doMsgs, LONGSWORD, ELIXIROFHEALTH, 0, 0, 0, 1000);
            }
            SHOW_TEXT(player, type, doMsgs, "Assassins!!");
            SET_FLAG(player, type, doMsgs, PARTY, FIGHT25, 1);
            MOD_GOLD(player, type, doMsgs,  - 1000);
            DAMAGE(player, type, doMsgs, HEALTH(player, type, doMsgs) / 6);
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 33);
                GET_MONSTER(player, type, doMsgs, 05, 34);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 33);
                GET_MONSTER(player, type, doMsgs, 02, 33);
                GET_MONSTER(player, type, doMsgs, 05, 34);
                GET_MONSTER(player, type, doMsgs, 06, 34);
            }
        }
        protected override void FnEvent1B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "As you enter the prisoner's cell, he turns to make his escape by force.");
            GET_MONSTER(player, type, doMsgs, 01, 26);
        }
        protected override void FnEvent1C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, ELFRANGER);
            SHOW_TEXT(player, type, doMsgs, "'Fools! Fools! Do you think the waters always run! Mad, mad, mad, ahahahhahah!!'");
            SHOW_TEXT(player, type, doMsgs, "Obviously this prisoner is insane.");
        }
        protected override void FnEvent1D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "A tiny door is visible to the west. You should be able to make it through.");
            SHOW_TEXT(player, type, doMsgs, "The Coelus here, however, is another story.");
            GET_MONSTER(player, type, doMsgs, 01, 40);
        }
        protected override void FnEvent1E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GET_FLAG(player, type, doMsgs, PARTY, METCLERIC) == 0)) {
                SET_FLAG(player, type, doMsgs, PARTY, METCLERIC, 1);
                SHOW_PICTURE(player, type, doMsgs, ELFCLERIC);
                SHOW_TEXT(player, type, doMsgs, "'Hmm...these foul spinning squares confuse and confound me. I do not understand how to defeat them.'");
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "The Cleric has wandered off.");
            }
        }
        protected override void FnEvent1F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GET_FLAG(player, type, doMsgs, DUNGEON, GAVE_INFO) == 0)) {
                if (GET_FLAG(player, type, doMsgs, PARTY, METCLERIC) == 1) {
                    Ranger(player, type, doMsgs);
                    SHOW_TEXT(player, type, doMsgs, "You tell the Ranger where you recently saw a confused Cleric.");
                    SHOW_TEXT(player, type, doMsgs, "'Excellent! I shall search there for him. My gratitude to you, good friend. Here, presents for your help.'");
                    SHOW_TEXT(player, type, doMsgs, "He then marches off.");
                    MOD_GOLD(player, type, doMsgs, 100);
                    GIVE_ITEM(player, type, doMsgs, ELIXIROFHEALTH);
                    SET_FLAG(player, type, doMsgs, PARTY, METCLERIC, 2);
                    SET_FLAG(player, type, doMsgs, DUNGEON, GAVE_INFO, 1);
                }
                else if ((GET_FLAG(player, type, doMsgs, PARTY, METCLERIC) == 0)) {
                    Ranger(player, type, doMsgs);
                    SHOW_TEXT(player, type, doMsgs, "'Well, never mind then.' The Ranger turns and walks away.");
                }
            }
        }
        private void Ranger(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, ELFRANGER);
            SHOW_TEXT(player, type, doMsgs, "'Pardon me, did you happen to see a Cleric friend of mine?  I'm afraid he gets confused quite easily.'");
        }
        protected override void FnEvent20(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, HUMANTHIEF);
            SHOW_TEXT(player, type, doMsgs, "A sopping wet thief is here.");
            SHOW_TEXT(player, type, doMsgs, "'I say, that blasted Aqueduct is frigid today. There must be a way to regulate the water's flow.'");
        }
        protected override void FnEvent21(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GET_FLAG(player, type, doMsgs, ROOM, SPRUNGTRAP) == 0)) {
                switch (FACING(player, type, doMsgs)) {
                    case NORTH:
                        ROTATE(player, type, doMsgs, WEST);
                        break;
                    case SOUTH:
                        ROTATE(player, type, doMsgs, WEST);
                        break;
                    case EAST:
                        ROTATE(player, type, doMsgs, SOUTH);
                        break;
                    case WEST:
                        ROTATE(player, type, doMsgs, EAST);
                        break;
                }
                SET_FLAG(player, type, doMsgs, ROOM, SPRUNGTRAP, 1);
            }
        }
        protected override void FnEvent22(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int i = 0;
            SHOW_TEXT(player, type, doMsgs, "Vicious creatures surround you!");
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 39);
                GET_MONSTER(player, type, doMsgs, 05, 40);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 38);
                GET_MONSTER(player, type, doMsgs, 02, 39);
                GET_MONSTER(player, type, doMsgs, 05, 40);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 3) {
                GET_MONSTER(player, type, doMsgs, 01, 38);
                for (i = 2; i <= 3; i++) {
                    GET_MONSTER(player, type, doMsgs, i, 39);
                }
                for (i = 4; i <= 6; i++) {
                    GET_MONSTER(player, type, doMsgs, i, 40);
                }
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 38);
                GET_MONSTER(player, type, doMsgs, 02, 38);
                GET_MONSTER(player, type, doMsgs, 03, 39);
                GET_MONSTER(player, type, doMsgs, 04, 39);
                GET_MONSTER(player, type, doMsgs, 05, 40);
                GET_MONSTER(player, type, doMsgs, 06, 40);
            }
        }
        protected override void FnEvent23(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GET_FLAG(player, type, doMsgs, PARTY, IRONSWORD) == 0)) {
                SET_BOOTY(player, type, doMsgs, IRONCUTLASS, ELIXIROFHEALTH, 0, 0, 0, 600);
            }
            SHOW_TEXT(player, type, doMsgs, "'Kill the intruders!'");
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 31);
                GET_MONSTER(player, type, doMsgs, 05, 32);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 31);
                GET_MONSTER(player, type, doMsgs, 02, 31);
                GET_MONSTER(player, type, doMsgs, 05, 32);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 3) {
                GET_MONSTER(player, type, doMsgs, 01, 31);
                GET_MONSTER(player, type, doMsgs, 02, 32);
                GET_MONSTER(player, type, doMsgs, 03, 32);
                GET_MONSTER(player, type, doMsgs, 05, 31);
                GET_MONSTER(player, type, doMsgs, 06, 31);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 31);
                GET_MONSTER(player, type, doMsgs, 02, 31);
                GET_MONSTER(player, type, doMsgs, 03, 32);
                GET_MONSTER(player, type, doMsgs, 04, 32);
                GET_MONSTER(player, type, doMsgs, 05, 32);
                GET_MONSTER(player, type, doMsgs, 06, 31);
            }
        }
        protected override void FnEvent24(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, HUMANTHIEF);
            SHOW_TEXT(player, type, doMsgs, "A familiar traveler is here and is now dry.");
            SHOW_TEXT(player, type, doMsgs, "'Hello there! I see you've managed to get yourself saturated in these waters too!'");
        }
        protected override void FnEvent25(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GET_FLAG(player, type, doMsgs, PARTY, GOODBOOTY) == 0)) {
                SET_BOOTY(player, type, doMsgs, SPEAR, ROUNDSHIELD, BERSERKERTALISMAN, 0, 0, 1000);
            }
            SHOW_TEXT(player, type, doMsgs, "Large beasts turn to challenge you as you stumble into their lair.");
            SET_FLAG(player, type, doMsgs, PARTY, GOODBOOTY, 1);
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 39);
                GET_MONSTER(player, type, doMsgs, 05, 40);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 38);
                GET_MONSTER(player, type, doMsgs, 02, 39);
                GET_MONSTER(player, type, doMsgs, 05, 40);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 3) {
                GET_MONSTER(player, type, doMsgs, 01, 38);
                GET_MONSTER(player, type, doMsgs, 02, 39);
                GET_MONSTER(player, type, doMsgs, 03, 39);
                GET_MONSTER(player, type, doMsgs, 05, 40);
                GET_MONSTER(player, type, doMsgs, 06, 40);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 38);
                GET_MONSTER(player, type, doMsgs, 02, 39);
                GET_MONSTER(player, type, doMsgs, 03, 40);
                GET_MONSTER(player, type, doMsgs, 04, 40);
                GET_MONSTER(player, type, doMsgs, 05, 40);
                GET_MONSTER(player, type, doMsgs, 06, 40);
            }
        }
        protected override void FnEvent26(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int flag = 0;
            int flag2 = 0;
            switch (HERE(player, type, doMsgs)) {
                case 199:
                    flag = WESTSIDE;
                    flag2 = EASTSIDE;
                    break;
                case 201:
                    flag = EASTSIDE;
                    flag2 = WESTSIDE;
                    break;
            }
            if ((GET_FLAG(player, type, doMsgs, PARTY, flag) == 0) || (GET_FLAG(player, type, doMsgs, PARTY, flag2) == 0)) {
                Dwarf(player, type, doMsgs);
                SHOW_TEXT(player, type, doMsgs, "A wizard here ponders a message on the wall: 'How do you keep an adventurer busy???'");
                if (HERE(player, type, doMsgs) == 199) {
                    SHOW_TEXT(player, type, doMsgs, "'See 2 east...hmmm.'");
                }
                else {
                    SHOW_TEXT(player, type, doMsgs, "'See 2 west...hmmm.'");
                }
                SET_FLAG(player, type, doMsgs, PARTY, flag2, 1);
            }
            else if (GET_FLAG(player, type, doMsgs, PARTY, flag) == 1) {
                Dwarf(player, type, doMsgs);
                SHOW_TEXT(player, type, doMsgs, "'I don't understand! I was just here!!'");
                SHOW_TEXT(player, type, doMsgs, "'Strangely enough, so were you!!'");
                SET_FLAG(player, type, doMsgs, PARTY, flag2, 2);
                SET_FLAG(player, type, doMsgs, PARTY, flag, 3);
            }
            else if (GET_FLAG(player, type, doMsgs, PARTY, flag) == 2) {
                SET_FLAG(player, type, doMsgs, PARTY, flag, 3);
                if (GET_FLAG(player, type, doMsgs, DUNGEON, DIDJOKEPAIR) == 1) {
                    Disappear(player, type, doMsgs);
                }
                else {
                    Dwarf(player, type, doMsgs);
                    SHOW_TEXT(player, type, doMsgs, "'Aha! Now I get it! Such a simple puzzle, it eluded me at first! Learn from this that all is not as challenging as you may think!'");
                    SET_FLAG(player, type, doMsgs, DUNGEON, DIDJOKEPAIR, 1);
                    MOD_EXP(player, type, doMsgs, 750);
                }
            }
            else if (GET_FLAG(player, type, doMsgs, PARTY, flag) == 3 || GET_FLAG(player, type, doMsgs, PARTY, flag2) == 3) {
                Disappear(player, type, doMsgs);
            }
        }
        private void Dwarf(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, DWARFWIZARD);
        }
        private void Disappear(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "The wall message and the wizard have vanished.");
        }
        protected override void FnEvent28(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GET_FLAG(player, type, doMsgs, PARTY, HALFTHIEF) == 0)) {
                SHOW_PICTURE(player, type, doMsgs, HALFLINGTHIEF);
                SHOW_TEXT(player, type, doMsgs, "A familiar looking thief lifts some more of your gold!");
                SHOW_TEXT(player, type, doMsgs, "'Ahhh...this is quite generous! Thank you again for the offering!'");
                MOD_GOLD(player, type, doMsgs,  - 500);
                SET_FLAG(player, type, doMsgs, PARTY, HALFTHIEF, 1);
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "The thief has wandered off to loot other parties.");
            }
        }
        protected override void FnEvent29(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HAS_ITEM(player, type, doMsgs, CROSSKEY)) {
                SHOW_TEXT(player, type, doMsgs, "Corpses litter the floor here, stripped of all their belongings. Seeing their fallen friends, other rogues attack!");
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "An 'X' is carved on the end of an ornate key that dangles on the rogue leader's neck.");
                SET_BOOTY(player, type, doMsgs, CROSSKEY, 0, 0, 0, 0, 150);
            }
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 36);
                GET_MONSTER(player, type, doMsgs, 05, 37);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 36);
                GET_MONSTER(player, type, doMsgs, 02, 35);
                GET_MONSTER(player, type, doMsgs, 05, 37);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 3) {
                GET_MONSTER(player, type, doMsgs, 01, 36);
                GET_MONSTER(player, type, doMsgs, 02, 36);
                GET_MONSTER(player, type, doMsgs, 03, 35);
                GET_MONSTER(player, type, doMsgs, 04, 35);
                GET_MONSTER(player, type, doMsgs, 06, 37);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 35);
                GET_MONSTER(player, type, doMsgs, 02, 35);
                GET_MONSTER(player, type, doMsgs, 03, 36);
                GET_MONSTER(player, type, doMsgs, 04, 36);
                GET_MONSTER(player, type, doMsgs, 05, 35);
                GET_MONSTER(player, type, doMsgs, 06, 37);
            }
        }
        protected override void FnEvent2A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, DUNGEON, SETDUCTSWITCH) == 1) {
                SHOW_TEXT(player, type, doMsgs, "The switch you set to open the sluice gates has released the pressure locks on this door!");
                CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
                PLACE_WALL_ITEM(player, type, doMsgs, DOOR, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "The doors are sealed shut and no lock is visible. Further examination reveals a lever mechanism concealed in the walls.");
                SHOW_TEXT(player, type, doMsgs, "Perhaps there is a trigger somewhere that will unlock this door.");
            }
        }
        protected override void FnEvent2B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                if (GET_FLAG(player, type, doMsgs, DUNGEON, DIDPATH) == 1 || GET_FLAG(player, type, doMsgs, DUNGEON, DIDPATH) == 2 || FLAG_ON(player, type, doMsgs, DUNGEON, SETDUCTSWITCH)) {
                    if (FLAG_ON(player, type, doMsgs, DUNGEON, SETDUCTSWITCH) && (GET_FLAG(player, type, doMsgs, DUNGEON, DIDPATH) == 0)) {
                        SHOW_TEXT(player, type, doMsgs, "There's a second way to the egress you are nearing. You need not seek it now; but return, and find the more profitable path later.");
                    }
                    else {
                        SHOW_TEXT(player, type, doMsgs, "The door opens for those who have completed the sluice quest.");
                    }
                    CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
                    PLACE_WALL_ITEM(player, type, doMsgs, DOOR, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
                }
                else {
                    SHOW_TEXT(player, type, doMsgs, "Only those who solve the sluice and proceed alone may enter here.");
                    WallBlock(player, type, doMsgs);
                }
            }
            else {
                WallBlock(player, type, doMsgs);
                SHOW_TEXT(player, type, doMsgs, "You must approach alone! You will know when you've found the way to unlock this door.");
            }
        }
        protected override void FnEvent2C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "The waterfall drags you out of the dungeon and dumps you into the sea.");
            EXIT_DUNGEON(player, type, doMsgs);
        }
        protected override void FnEvent2D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, DUNGEON, CROSSBRIDGE) == 1) {
                HIDE_WALL(player, type, doMsgs, 126, NORTH);
                CLEAR_WALL(player, type, doMsgs, 126, NORTH);
                HIDE_WALL(player, type, doMsgs, 158, SOUTH);
                CLEAR_WALL(player, type, doMsgs, 158, SOUTH);
                CLEAR_FLOOR(player, type, doMsgs, 142);
                CLEAR_FLOOR(player, type, doMsgs, 126);
                CLEAR_FLOOR(player, type, doMsgs, 158);
                PLACE_FLOOR_ITEM(player, type, doMsgs, 1, 142);
                PLACE_FLOOR_ITEM(player, type, doMsgs, 1, 126);
                PLACE_FLOOR_ITEM(player, type, doMsgs, 1, 158);
                SHOW_TEXT(player, type, doMsgs, "You stand at one end of the bridge.");
                SHOW_TEXT(player, type, doMsgs, "Invisible walls keep you from falling off the bridge into the freezing waters below.");
                BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), WEST);
                BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), EAST);
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "You see the base of a watch tower to the south.");
                SHOW_TEXT(player, type, doMsgs, "A bridge spans the Aqueduct overhead.");
                BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), SOUTH);
                SHOW_WALL(player, type, doMsgs, 158, SOUTH);
                SHOW_WALL(player, type, doMsgs, 126, NORTH);
                if ((GET_FLAG(player, type, doMsgs, ROOM, SPRUNGTRAP) == 0)) {
                    SHOW_TEXT(player, type, doMsgs, "The rushing waters pummel your body.");
                    DAMAGE(player, type, doMsgs, MAX_HEALTH(player, type, doMsgs) / 4);
                    SpringTrap(player, type, doMsgs);
                }
            }
        }
        protected override void FnEvent2E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, DUNGEON, CROSSBRIDGE) == 1) {
                HIDE_WALL(player, type, doMsgs, 158, SOUTH);
                CLEAR_WALL(player, type, doMsgs, 158, SOUTH);
                HIDE_WALL(player, type, doMsgs, 126, NORTH);
                CLEAR_WALL(player, type, doMsgs, 126, NORTH);
                CLEAR_FLOOR(player, type, doMsgs, 142);
                CLEAR_FLOOR(player, type, doMsgs, 126);
                CLEAR_FLOOR(player, type, doMsgs, 158);
                PLACE_FLOOR_ITEM(player, type, doMsgs, 1, 142);
                PLACE_FLOOR_ITEM(player, type, doMsgs, 1, 126);
                PLACE_FLOOR_ITEM(player, type, doMsgs, 1, 158);
                SHOW_TEXT(player, type, doMsgs, "You stand at one end of the bridge.");
                SHOW_TEXT(player, type, doMsgs, "Invisible walls keep you from falling off the bridge into the freezing waters below.");
                BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), WEST);
                BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), EAST);
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "You see the base of a watch tower to the north.");
                SHOW_TEXT(player, type, doMsgs, "A bridge spans the Aqueduct overhead.");
                SHOW_WALL(player, type, doMsgs, 158, SOUTH);
                SHOW_WALL(player, type, doMsgs, 126, NORTH);
                BLOCK_WALL(player, type, doMsgs, 126, NORTH);
                BLOCK_WALL(player, type, doMsgs, 158, SOUTH);
                if ((GET_FLAG(player, type, doMsgs, ROOM, SPRUNGTRAP) == 0)) {
                    SHOW_TEXT(player, type, doMsgs, "The rushing waters pummel your body.");
                    DAMAGE(player, type, doMsgs, MAX_HEALTH(player, type, doMsgs) / 4);
                    SpringTrap(player, type, doMsgs);
                }
            }
        }
        protected override void FnEvent2F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SET_FLAG(player, type, doMsgs, DUNGEON, CROSSBRIDGE, 0);
        }
        protected override void FnEvent30(TwPlayerServer player, MapEventType type, bool doMsgs) {
            NO_HEAL_ZONE(player, type, doMsgs);
            SHOW_WALL(player, type, doMsgs, 158, SOUTH);
            SHOW_WALL(player, type, doMsgs, 126, NORTH);
            BLOCK_WALL(player, type, doMsgs, 126, NORTH);
            BLOCK_WALL(player, type, doMsgs, 158, SOUTH);
            if ((GET_FLAG(player, type, doMsgs, ROOM, SPRUNGTRAP) == 0)) {
                SHOW_TEXT(player, type, doMsgs, "The rushing waters pummel your body.");
                DAMAGE(player, type, doMsgs, MAX_HEALTH(player, type, doMsgs) / 4);
                SpringTrap(player, type, doMsgs);
            }
        }
        protected override void FnEvent31(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GET_FLAG(player, type, doMsgs, DUNGEON, MERCHANT) == 0)) {
                if (GUILD(player, type, doMsgs) == THIEF || GUILD(player, type, doMsgs) == WIZARD) {
                    GIVE_SPELL(player, type, doMsgs, PETRIFY_SPELL, 1);
                    SHOW_PICTURE(player, type, doMsgs, GNOMEWIZARD);
                    MOD_GOLD(player, type, doMsgs,  - 1000);
                    SHOW_TEXT(player, type, doMsgs, "An honorable merchant offers you a taste of his drink in exchange for some gold.");
                    SHOW_TEXT(player, type, doMsgs, "As you sip the thick grog, you learn the petrify spell!!");
                    SET_FLAG(player, type, doMsgs, DUNGEON, MERCHANT, 1);
                }
            }
            else if (HEALTH(player, type, doMsgs) < MAX_HEALTH(player, type, doMsgs)) {
                SHOW_PICTURE(player, type, doMsgs, GNOMEWIZARD);
                SHOW_TEXT(player, type, doMsgs, "'A trifle of gold for a sup of health? Tis a fair lot, m'good champion.' You feel your health and mana restored!");
                MOD_GOLD(player, type, doMsgs,  - 100);
                MOD_MANA(player, type, doMsgs, 2000);
                HEAL(player, type, doMsgs, MAX_HEALTH(player, type, doMsgs));
            }
        }
        protected override void FnEvent32(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int spell = 0;
            if ((GET_FLAG(player, type, doMsgs, DUNGEON, FNTN) == 0)) {
                if (GUILD(player, type, doMsgs) == CLERIC || GUILD(player, type, doMsgs) == WIZARD || GUILD(player, type, doMsgs) == RANGER) {
                    switch (GUILD(player, type, doMsgs)) {
                        case CLERIC:
                            spell = AURA_SPELL;
                            break;
                        case WIZARD:
                            spell = REFRESH_SPELL;
                            break;
                        case RANGER:
                            spell = HEAL_SPELL;
                            GIVE_SPELL(player, type, doMsgs, RESIST_SPELL, 1);
                            break;
                    }
                    GIVE_SPELL(player, type, doMsgs, spell, 1);
                    SHOW_PICTURE(player, type, doMsgs, FOUNTAIN);
                    SHOW_TEXT(player, type, doMsgs, "Gleaming rays of light pour from this fountain. You drink of its sweet waters and gain new powers.");
                    SET_FLAG(player, type, doMsgs, DUNGEON, FNTN, 1);
                }
                else {
                    SET_FLAG(player, type, doMsgs, DUNGEON, FNTN, 1);
                    HealUs(player, type, doMsgs);
                }
            }
            else {
                HealUs(player, type, doMsgs);
            }
        }
        private void HealUs(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, FOUNTAIN);
            SHOW_TEXT(player, type, doMsgs, "The waters offer limited refreshment, but nothing more.");
            HEAL(player, type, doMsgs, MAX_HEALTH(player, type, doMsgs) / 4);
        }
        protected override void FnEvent33(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GET_FLAG(player, type, doMsgs, DUNGEON, RESIST) == 0)) {
                if (GUILD(player, type, doMsgs) == CLERIC || GUILD(player, type, doMsgs) == WIZARD) {
                    GIVE_SPELL(player, type, doMsgs, RESIST_SPELL, 1);
                    SHOW_PICTURE(player, type, doMsgs, FOUNTAIN);
                    SHOW_TEXT(player, type, doMsgs, "Sour waters turn into sweet nectar as you learn how to resist the elements.");
                    SET_FLAG(player, type, doMsgs, DUNGEON, RESIST, 1);
                }
                else if (GUILD(player, type, doMsgs) == RANGER) {
                    SHOW_PICTURE(player, type, doMsgs, FOUNTAIN);
                    SHOW_TEXT(player, type, doMsgs, "Radiant waters enlighten you with a new spell!");
                    GIVE_SPELL(player, type, doMsgs, AURA_SPELL, 1);
                    SET_FLAG(player, type, doMsgs, DUNGEON, RESIST, 1);
                }
            }
            else {
                SHOW_PICTURE(player, type, doMsgs, FOUNTAIN);
                SHOW_TEXT(player, type, doMsgs, "A dry well is all that greets you here.");
            }
        }
        protected override void FnEvent34(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (USED_SKILL(player, type, doMsgs, LOCKPICK_SKILL) >= 6 || USED_ITEM(player, type, doMsgs, HELMOFGUILE, HELMOFGUILE) || USED_ITEM(player, type, doMsgs, GREENLOCKPICK, BLUELOCKPICK)) {
                SHOW_TEXT(player, type, doMsgs, "You managed to pick the lock!");
                CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "A very stubborn lock impedes your progress here.");
                BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
            }
        }
        protected override void FnEvent35(TwPlayerServer player, MapEventType type, bool doMsgs) {
            REMOVE_WALL_ITEM(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
            SHOW_TEXT(player, type, doMsgs, "An illusionary door vanishes as you approach!");
        }
    }
}
