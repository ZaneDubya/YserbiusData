using XPT.Generic.Maps;
using XPT.Twinion.Entities;

namespace XPT.Twinion.Maps {
    class TwMap22 : TwMap {
        protected override int MapIndex => 22;
        protected override int MapID => 0x0902;
        protected override int RandomEncounterChance => 0;
        protected override int RandomEncounterExtraCount => 2;

        private const int DOORA = 1;
        private const int DOORB = 2;
        private const int DOORC = 3;
        private const int DOORD = 4;
        private const int CLERICDOORA = 5;
        private const int CLERICDOORB = 6;
        private const int CLERICDOORC = 7;
        private const int CLERICDOORD = 8;
        private const int PITTWO = 9;
        private const int PITTHREE = 10;
        private const int PITFOUR = 11;
        private const int PITFIVE = 12;
        private const int PITSIX = 13;
        protected override void FnEvent01(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 8, 1, 160, EAST);
        }
        protected override void FnEvent03(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 9, 2, 0, EAST);
        }
        protected override void FnEvent04(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_RUNES(player, type, doMsgs, "The path to glory lies eastward.");
        }
        protected override void FnEvent05(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 9, 2, 4, EAST);
        }
        protected override void FnEvent06(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_RUNES(player, type, doMsgs, "The second path points east.");
        }
        protected override void FnEvent07(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 9, 2, 8, EAST);
        }
        protected override void FnEvent08(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_RUNES(player, type, doMsgs, "A third path is to the east.");
        }
        protected override void FnEvent09(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 9, 2, 12, EAST);
        }
        protected override void FnEvent0A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_RUNES(player, type, doMsgs, "Behold, the last path awaits you.");
        }
        protected override void FnEvent0B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 9, 2, 233, EAST);
        }
        protected override void FnEvent0C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "This pit is particularly fatal.");
            DAMAGE(player, type, doMsgs, MAX_HEALTH(player, type, doMsgs));
        }
        protected override void FnEvent0D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "The pit you step on is an illusion.");
        }
        protected override void FnEvent0E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 9, 2, 121, NORTH);
        }
        protected override void FnEvent0F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, DUNGEON, GETUNITYRING) == 1) {
                SHOW_TEXT(player, type, doMsgs, "I am the lamp.");
                if (USED_SKILL(player, type, doMsgs, DETECT_SKILL) >= 12 || USED_SPELL(player, type, doMsgs, TRUE_SEEING_SPELL) || USED_ITEM(player, type, doMsgs, HELMOFWISDOM, HELMOFWISDOM) || USED_ITEM(player, type, doMsgs, VALKYRIESHELM, VALKYRIESHELM) || USED_ITEM(player, type, doMsgs, RINGOFTHIEVES, RINGOFTHIEVES) || USED_ITEM(player, type, doMsgs, CRYSTALBALL, CRYSTALBALL)) {
                    SHOW_TEXT(player, type, doMsgs, "Throwing a trip mechanism opens a secret entrance.");
                    CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), SOUTH);
                    PLACE_WALL_ITEM(player, type, doMsgs, DOOR, HERE(player, type, doMsgs), SOUTH);
                }
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "I am the lamp.");
            }
        }
        protected override void FnEvent10(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 9, 2, 50, NORTH);
        }
        protected override void FnEvent11(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Walk to the next door southeast of here.");
            SHOW_TEXT(player, type, doMsgs, "Do not leave the map until you have the ring.");
            SET_FLAG(player, type, doMsgs, PARTY, CLERICDOORA, 1);
        }
        protected override void FnEvent12(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 9, 2, 100, EAST);
        }
        protected override void FnEvent13(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "The next door is to the southeast.");
            SET_FLAG(player, type, doMsgs, PARTY, CLERICDOORB, 1);
        }
        protected override void FnEvent14(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "The next door is west northwest.");
            SET_FLAG(player, type, doMsgs, PARTY, CLERICDOORC, 1);
        }
        protected override void FnEvent15(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You must find the last door on your own!");
            SET_FLAG(player, type, doMsgs, PARTY, CLERICDOORD, 1);
        }
        protected override void FnEvent16(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 9, 2, 180, SOUTH);
        }
        protected override void FnEvent17(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, DUNGEON, NPCENDCHAT) == 1) {
                SHOW_TEXT(player, type, doMsgs, "The door unlocks as you approach.");
                SET_FLAG(player, type, doMsgs, PARTY, DOORA, 1);
                CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), NORTH);
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "Nothing you try opens the door.");
            }
        }
        protected override void FnEvent18(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GET_FLAG(player, type, doMsgs, DUNGEON, OPENDOORB) == 1) || (GET_FLAG(player, type, doMsgs, DUNGEON, OPENDOORC) == 1) || (GET_FLAG(player, type, doMsgs, DUNGEON, OPENDOORD) == 1)) {
                SHOW_TEXT(player, type, doMsgs, "The door swings open.");
                SET_FLAG(player, type, doMsgs, PARTY, DOORB, 1);
                CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), WEST);
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "The door does not budge.");
            }
        }
        protected override void FnEvent19(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, DUNGEON, OPENDOORC) == 1) {
                SHOW_TEXT(player, type, doMsgs, "The lock on the door clicks open.");
                SET_FLAG(player, type, doMsgs, PARTY, DOORC, 1);
                CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), EAST);
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "You push against the door, but nothing happens.");
            }
        }
        protected override void FnEvent1A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, DUNGEON, OPENDOORD) == 1) {
                SHOW_TEXT(player, type, doMsgs, "The doorknob twists easily at your touch.");
                SET_FLAG(player, type, doMsgs, PARTY, DOORD, 1);
                CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), WEST);
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "The heavy door will not move.");
            }
        }
        protected override void FnEvent1B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (FLAG_ON(player, type, doMsgs, DUNGEON, UNITYRINGTHREE)) {
                if (USED_ITEM(player, type, doMsgs, REDLOCKPICK, BLUELOCKPICK) || USED_ITEM(player, type, doMsgs, HELMOFGUILE, HELMOFGUILE) || USED_SKILL(player, type, doMsgs, LOCKPICK_SKILL) >= 10) {
                    CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
                    SHOW_TEXT(player, type, doMsgs, "The lock pops open at your deft touch.");
                }
                else {
                    BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
                    SHOW_TEXT(player, type, doMsgs, "The door lock looks particularly nasty.");
                }
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "Finish Concordia and you may pass.");
            }
        }
        protected override void FnEvent1C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, DUNGEON, NPCKEYCLUE) == 1) {
                SHOW_TEXT(player, type, doMsgs, "The words of the Elf Cleric come to mind as you stare at the star-shaped keyhole in the door.");
                SHOW_TEXT(player, type, doMsgs, "A brilliant glow effuses from the keyhole.");
                SHOW_TEXT(player, type, doMsgs, "Then there is a click, and the door opens.");
                CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), SOUTH);
            }
            else if (GET_FLAG(player, type, doMsgs, DUNGEON, UNITYRINGTHREE) == 1) {
                SHOW_TEXT(player, type, doMsgs, "The star-shaped keyhole glows and the lock clicks open.");
                CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), SOUTH);
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "The keyhole in the door is shaped like a radiant star.");
            }
        }
        protected override void FnEvent1D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (FLAG_ON(player, type, doMsgs, DUNGEON, EASTQUESTDONE)) {
                SHOW_TEXT(player, type, doMsgs, "The room is empty.");
            }
            else {
                SHOW_PICTURE(player, type, doMsgs, HALFLINGCLERIC);
                SHOW_TEXT(player, type, doMsgs, "A Halfling Cleric bows politely.");
                SHOW_TEXT(player, type, doMsgs, "'From south to north four times the pathway eastward lies.");
                SHOW_TEXT(player, type, doMsgs, "Farthest east and north is your reward.");
                SHOW_TEXT(player, type, doMsgs, "But once may the brave heart succeed and then the way is forever closed.'");
            }
        }
        protected override void FnEvent1E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (FLAG_ON(player, type, doMsgs, DUNGEON, EASTQUESTDONE)) {
                SHOW_TEXT(player, type, doMsgs, "You see a torn robe on the floor.");
            }
            else {
                SHOW_PICTURE(player, type, doMsgs, TROLLCLERIC);
                SHOW_TEXT(player, type, doMsgs, "A Troll Cleric approaches.");
                SHOW_TEXT(player, type, doMsgs, "'Beyond the many doors is a quest that will test the bravest of heroes.");
                SHOW_TEXT(player, type, doMsgs, "Find my fellow clerics to start the quest.");
                SHOW_TEXT(player, type, doMsgs, "Also, know that the nature of pits may change as you succeed.'");
            }
        }
        protected override void FnEvent1F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (FLAG_ON(player, type, doMsgs, DUNGEON, EASTQUESTDONE)) {
                SHOW_TEXT(player, type, doMsgs, "The room is bare.");
            }
            else {
                SHOW_PICTURE(player, type, doMsgs, ELFCLERIC);
                SHOW_TEXT(player, type, doMsgs, "An Elf Cleric steps out of the shadows.");
                if (FLAG_ON(player, type, doMsgs, DUNGEON, NPCKEYCLUE)) {
                    SHOW_TEXT(player, type, doMsgs, "'Back again? I said to look for the star-hole door.'");
                }
                else {
                    SHOW_TEXT(player, type, doMsgs, "'I give you the key to the star-hole door. Think of the shining sun and the way to the quest will be open.'");
                    SET_FLAG(player, type, doMsgs, DUNGEON, NPCKEYCLUE, 1);
                }
            }
        }
        protected override void FnEvent20(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (FLAG_ON(player, type, doMsgs, DUNGEON, EASTQUESTDONE)) {
                SHOW_TEXT(player, type, doMsgs, "In the distance you hear the growl of monsters.");
            }
            else {
                SHOW_PICTURE(player, type, doMsgs, ELFCLERIC);
                if (FLAG_ON(player, type, doMsgs, DUNGEON, NPCENDCHAT)) {
                    SHOW_TEXT(player, type, doMsgs, "'As I said earlier, the first door will now open for you.'");
                }
                else {
                    SHOW_TEXT(player, type, doMsgs, "You interrupt the meditations of an Elf Cleric.");
                    SHOW_TEXT(player, type, doMsgs, "'The first door will now open for you.'");
                    SET_FLAG(player, type, doMsgs, DUNGEON, NPCENDCHAT, 1);
                }
            }
        }
        protected override void FnEvent21(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Know that the next door is now open.");
            SET_FLAG(player, type, doMsgs, DUNGEON, OPENDOORB, 1);
        }
        protected override void FnEvent22(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Know that the next door is now open.");
            SET_FLAG(player, type, doMsgs, DUNGEON, OPENDOORC, 1);
            SET_FLAG(player, type, doMsgs, DUNGEON, OPENDOORB, 0);
        }
        protected override void FnEvent23(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Know that the next door is now open.");
            SET_FLAG(player, type, doMsgs, DUNGEON, OPENDOORD, 1);
            SET_FLAG(player, type, doMsgs, DUNGEON, OPENDOORC, 0);
        }
        protected override void FnEvent24(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GET_FLAG(player, type, doMsgs, DUNGEON, EASTQUESTDONE) == 0)) {
                SET_FLAG(player, type, doMsgs, DUNGEON, EASTQUESTDONE, 1);
                SHOW_PICTURE(player, type, doMsgs, FOUNTAIN);
                SHOW_TEXT(player, type, doMsgs, "The acid waters of the Fountain of the Bitter End at first burn your mouth.");
                SHOW_TEXT(player, type, doMsgs, "After a moment the acid taste changes to sweet water.");
                SHOW_TEXT(player, type, doMsgs, "You have transformed the Fountain of the Bitter End into the Fountain of the Better End.");
                SHOW_TEXT(player, type, doMsgs, "You feel ready to take on whole armies.");
                MOD_STAT(player, type, doMsgs, INITIATIVE, 3);
                MOD_STAT(player, type, doMsgs, AGILITY, 2);
                MOD_EXP(player, type, doMsgs, 750000);
                SET_FLAG(player, type, doMsgs, DUNGEON, OPENDOORB, 2);
                SET_FLAG(player, type, doMsgs, DUNGEON, OPENDOORC, 2);
                SET_FLAG(player, type, doMsgs, DUNGEON, OPENDOORD, 2);
                SET_FLAG(player, type, doMsgs, DUNGEON, NPCKEYCLUE, 2);
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "The Fountain of the Better End is dry.");
            }
        }
        protected override void FnEvent25(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 22);
                GET_MONSTER(player, type, doMsgs, 02, 21);
                GET_MONSTER(player, type, doMsgs, 06, 27);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 30);
                GET_MONSTER(player, type, doMsgs, 02, 31);
                GET_MONSTER(player, type, doMsgs, 03, 29);
                GET_MONSTER(player, type, doMsgs, 06, 26);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 3);
                GET_MONSTER(player, type, doMsgs, 02, 3);
                GET_MONSTER(player, type, doMsgs, 03, 36);
                GET_MONSTER(player, type, doMsgs, 04, 37);
                GET_MONSTER(player, type, doMsgs, 05, 24);
                GET_MONSTER(player, type, doMsgs, 06, 24);
            }
        }
        protected override void FnEvent26(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 27);
                GET_MONSTER(player, type, doMsgs, 02, 28);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 35);
                GET_MONSTER(player, type, doMsgs, 02, 36);
                GET_MONSTER(player, type, doMsgs, 06, 12);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 3) {
                GET_MONSTER(player, type, doMsgs, 01, 32);
                GET_MONSTER(player, type, doMsgs, 02, 34);
                GET_MONSTER(player, type, doMsgs, 03, 34);
                GET_MONSTER(player, type, doMsgs, 04, 32);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 32);
                GET_MONSTER(player, type, doMsgs, 02, 34);
                GET_MONSTER(player, type, doMsgs, 03, 34);
                GET_MONSTER(player, type, doMsgs, 04, 32);
                GET_MONSTER(player, type, doMsgs, 05, 40);
            }
        }
        protected override void FnEvent27(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1 || PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 31);
                GET_MONSTER(player, type, doMsgs, 02, 29);
                GET_MONSTER(player, type, doMsgs, 05, 13);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 3) {
                GET_MONSTER(player, type, doMsgs, 01, 18);
                GET_MONSTER(player, type, doMsgs, 02, 19);
                GET_MONSTER(player, type, doMsgs, 03, 19);
                GET_MONSTER(player, type, doMsgs, 05, 26);
                GET_MONSTER(player, type, doMsgs, 06, 28);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 23);
                GET_MONSTER(player, type, doMsgs, 02, 23);
                GET_MONSTER(player, type, doMsgs, 03, 31);
                GET_MONSTER(player, type, doMsgs, 04, 30);
                GET_MONSTER(player, type, doMsgs, 05, 26);
                GET_MONSTER(player, type, doMsgs, 06, 26);
            }
        }
        protected override void FnEvent28(TwPlayerServer player, MapEventType type, bool doMsgs) {
            CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
        }
        protected override void FnEvent29(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 29);
                GET_MONSTER(player, type, doMsgs, 02, 26);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 29);
                GET_MONSTER(player, type, doMsgs, 02, 29);
                GET_MONSTER(player, type, doMsgs, 05, 26);
                GET_MONSTER(player, type, doMsgs, 06, 26);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 29);
                GET_MONSTER(player, type, doMsgs, 02, 29);
                GET_MONSTER(player, type, doMsgs, 03, 29);
                GET_MONSTER(player, type, doMsgs, 04, 29);
                GET_MONSTER(player, type, doMsgs, 05, 26);
                GET_MONSTER(player, type, doMsgs, 06, 26);
            }
        }
        protected override void FnEvent2A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 32);
                GET_MONSTER(player, type, doMsgs, 02, 32);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 32);
                GET_MONSTER(player, type, doMsgs, 02, 32);
                GET_MONSTER(player, type, doMsgs, 05, 34);
                GET_MONSTER(player, type, doMsgs, 06, 34);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 32);
                GET_MONSTER(player, type, doMsgs, 02, 32);
                GET_MONSTER(player, type, doMsgs, 03, 33);
                GET_MONSTER(player, type, doMsgs, 04, 34);
                GET_MONSTER(player, type, doMsgs, 06, 34);
            }
        }
        protected override void FnEvent2B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 32);
                GET_MONSTER(player, type, doMsgs, 02, 4);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 32);
                GET_MONSTER(player, type, doMsgs, 02, 32);
                GET_MONSTER(player, type, doMsgs, 04, 37);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 3) {
                GET_MONSTER(player, type, doMsgs, 01, 32);
                GET_MONSTER(player, type, doMsgs, 02, 32);
                GET_MONSTER(player, type, doMsgs, 03, 37);
                GET_MONSTER(player, type, doMsgs, 04, 37);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 34);
                GET_MONSTER(player, type, doMsgs, 02, 34);
                GET_MONSTER(player, type, doMsgs, 03, 36);
                GET_MONSTER(player, type, doMsgs, 04, 36);
                GET_MONSTER(player, type, doMsgs, 05, 38);
                GET_MONSTER(player, type, doMsgs, 06, 38);
            }
        }
        protected override void FnEvent2C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 32);
                GET_MONSTER(player, type, doMsgs, 02, 33);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 34);
                GET_MONSTER(player, type, doMsgs, 02, 34);
                GET_MONSTER(player, type, doMsgs, 05, 35);
                GET_MONSTER(player, type, doMsgs, 06, 9);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 3) {
                GET_MONSTER(player, type, doMsgs, 01, 33);
                GET_MONSTER(player, type, doMsgs, 02, 33);
                GET_MONSTER(player, type, doMsgs, 03, 35);
                GET_MONSTER(player, type, doMsgs, 04, 35);
                GET_MONSTER(player, type, doMsgs, 05, 34);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 38);
                GET_MONSTER(player, type, doMsgs, 02, 38);
                GET_MONSTER(player, type, doMsgs, 03, 38);
                GET_MONSTER(player, type, doMsgs, 04, 38);
                GET_MONSTER(player, type, doMsgs, 05, 24);
                GET_MONSTER(player, type, doMsgs, 06, 24);
            }
        }
        protected override void FnEvent2D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 35);
                GET_MONSTER(player, type, doMsgs, 02, 9);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 35);
                GET_MONSTER(player, type, doMsgs, 02, 3);
                GET_MONSTER(player, type, doMsgs, 05, 7);
                GET_MONSTER(player, type, doMsgs, 06, 9);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 4);
                GET_MONSTER(player, type, doMsgs, 02, 4);
                GET_MONSTER(player, type, doMsgs, 03, 5);
                GET_MONSTER(player, type, doMsgs, 04, 5);
                GET_MONSTER(player, type, doMsgs, 05, 24);
                GET_MONSTER(player, type, doMsgs, 06, 24);
            }
        }
        protected override void FnEvent2E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 38);
                GET_MONSTER(player, type, doMsgs, 02, 38);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 38);
                GET_MONSTER(player, type, doMsgs, 02, 38);
                GET_MONSTER(player, type, doMsgs, 05, 39);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 1);
                GET_MONSTER(player, type, doMsgs, 02, 5);
                GET_MONSTER(player, type, doMsgs, 03, 38);
                GET_MONSTER(player, type, doMsgs, 04, 38);
                GET_MONSTER(player, type, doMsgs, 05, 39);
                GET_MONSTER(player, type, doMsgs, 06, 40);
            }
        }
        protected override void FnEvent2F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 32);
                GET_MONSTER(player, type, doMsgs, 02, 33);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 33);
                GET_MONSTER(player, type, doMsgs, 02, 34);
                GET_MONSTER(player, type, doMsgs, 05, 33);
                GET_MONSTER(player, type, doMsgs, 06, 34);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 34);
                GET_MONSTER(player, type, doMsgs, 02, 34);
                GET_MONSTER(player, type, doMsgs, 03, 33);
                GET_MONSTER(player, type, doMsgs, 04, 33);
                GET_MONSTER(player, type, doMsgs, 05, 35);
                GET_MONSTER(player, type, doMsgs, 06, 35);
            }
        }
        protected override void FnEvent30(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, DUNGEON, UNITYRINGTHREE) || HAS_ITEM(player, type, doMsgs, UNITYRING)) {
                SHOW_TEXT(player, type, doMsgs, "The floor of the room is bare.");
            }
            else {
                GIVE_ITEM(player, type, doMsgs, UNITYRING);
                GIVE_ITEM(player, type, doMsgs, TWINBOLTS);
                MOD_EXP(player, type, doMsgs, 350000);
                SHOW_TEXT(player, type, doMsgs, "On the floor is a ring bearing the ");
                SHOW_TEXT(player, type, doMsgs, "linked symbols of Chaos and Harmony.");
                SHOW_TEXT(player, type, doMsgs, "You place the Unity Ring on your finger.");
            }
        }
        protected override void FnEvent31(TwPlayerServer player, MapEventType type, bool doMsgs) {
            NO_MAPS(player, type, doMsgs);
            if (HERE(player, type, doMsgs) == 224) {
                NO_JOIN(player, type, doMsgs);
            }
        }
        protected override void FnEvent32(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_LEADER(player, type, doMsgs)) {
                if (GET_FLAG(player, type, doMsgs, DUNGEON, OPENDOORD) == 1) {
                    SHOW_TEXT(player, type, doMsgs, "The pit swallows you up and spits you out at...");
                    TELEPORT(player, type, doMsgs, 7, 1, 32, EAST);
                }
                else {
                    SHOW_TEXT(player, type, doMsgs, "The pit is only a painted illusion.");
                }
            }
        }
        protected override void FnEvent33(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, DUNGEON, OPENDOORC) == 1) {
                SHOW_TEXT(player, type, doMsgs, "An endless pit to death...");
                DAMAGE(player, type, doMsgs, MAX_HEALTH(player, type, doMsgs));
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "The pit you step on is a simple illusion.");
            }
        }
        protected override void FnEvent34(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_LEADER(player, type, doMsgs)) {
                if (GET_FLAG(player, type, doMsgs, DUNGEON, OPENDOORB) == 1) {
                    SHOW_TEXT(player, type, doMsgs, "This pit leads to...");
                    TELEPORT(player, type, doMsgs, 9, 2, 120, WEST);
                }
                else {
                    SHOW_TEXT(player, type, doMsgs, "The pit is a simple illusion.");
                }
            }
        }
        protected override void FnEvent35(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_LEADER(player, type, doMsgs)) {
                if (GET_FLAG(player, type, doMsgs, DUNGEON, OPENDOORD) == 1) {
                    SHOW_TEXT(player, type, doMsgs, "The pit is just an illusion.");
                }
                else {
                    SHOW_TEXT(player, type, doMsgs, "The pit drops you off at...");
                    TELEPORT(player, type, doMsgs, 6, 2, 48, EAST);
                }
            }
        }
        protected override void FnEvent36(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_LEADER(player, type, doMsgs)) {
                if (GET_FLAG(player, type, doMsgs, DUNGEON, OPENDOORC) == 1) {
                    SHOW_TEXT(player, type, doMsgs, "You step on an illusionary pit.");
                }
                else {
                    SHOW_TEXT(player, type, doMsgs, "The pit is a far step to...");
                    TELEPORT(player, type, doMsgs, 5, 2, 247, NORTH);
                }
            }
        }
        protected override void FnEvent37(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_LEADER(player, type, doMsgs)) {
                if ((GET_FLAG(player, type, doMsgs, DUNGEON, OPENDOORC) == 1) || (GET_FLAG(player, type, doMsgs, DUNGEON, OPENDOORD) == 1)) {
                    SHOW_TEXT(player, type, doMsgs, "The pit is a clever illusion.");
                }
                else {
                    SHOW_TEXT(player, type, doMsgs, "You step into an endless pit to...");
                    TELEPORT(player, type, doMsgs, 1, 1, 204, EAST);
                }
            }
        }
        protected override void FnEvent38(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_LEADER(player, type, doMsgs)) {
                if ((GET_FLAG(player, type, doMsgs, DUNGEON, OPENDOORB) == 1) || (GET_FLAG(player, type, doMsgs, DUNGEON, OPENDOORD) == 1)) {
                    SHOW_TEXT(player, type, doMsgs, "The pit is an illusion.");
                }
                else {
                    SHOW_TEXT(player, type, doMsgs, "The pit you step into leads...");
                    TELEPORT(player, type, doMsgs, 3, 2, 82, EAST);
                }
            }
        }
        protected override void FnEvent39(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "A return to Dragon's Ire.");
            TELEPORT(player, type, doMsgs, 8, 1, 160, EAST);
        }
        protected override void FnEvent3A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Hocus Pocus is just ahead.");
            TELEPORT(player, type, doMsgs, 9, 1, 167, SOUTH);
        }
        protected override void FnEvent3B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "In the distance you hear babbling.");
            TELEPORT(player, type, doMsgs, 10, 1, 88, NORTH);
        }
        protected override void FnEvent3C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Step through to Concordia.");
            TELEPORT(player, type, doMsgs, 10, 2, 225, NORTH);
        }
        protected override void FnEvent3D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Pandemonium awaits!");
            TELEPORT(player, type, doMsgs, 10, 3, 159, WEST);
        }
        protected override void FnEvent3E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, DUNGEON, EASTQUESTDONE) == 1) {
                SHOW_TEXT(player, type, doMsgs, "Who hath tasted of the Fountain of the Better End may no longer pass.");
                BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), EAST);
            }
            else {
                if (PARTY_COUNT(player, type, doMsgs) == 1) {
                    SHOW_TEXT(player, type, doMsgs, "Pass through the door.");
                    CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), EAST);
                }
                else {
                    SHOW_TEXT(player, type, doMsgs, "One adventurer at a time may pass through this door.");
                }
            }
        }
        protected override void FnEvent3F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "The pit drops you into darkness.");
            TELEPORT(player, type, doMsgs, 5, 3, 103, NORTH);
        }
        protected override void FnEvent40(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "This pit leads to...");
            TELEPORT(player, type, doMsgs, 9, 2, 41, WEST);
        }
        protected override void FnEvent41(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "The pit is an endless abyss to...");
            TELEPORT(player, type, doMsgs, 5, 2, 189, NORTH);
        }
        protected override void FnEvent42(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, PARTY, CLERICDOORA) == 1) {
                SHOW_TEXT(player, type, doMsgs, "On the door is a picture of a Cleric.");
                CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), WEST);
            }
        }
        protected override void FnEvent43(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, PARTY, CLERICDOORB) == 1) {
                SHOW_TEXT(player, type, doMsgs, "On the door is a picture of a Cleric.");
                CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), SOUTH);
            }
        }
        protected override void FnEvent44(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, PARTY, CLERICDOORC) == 1) {
                SHOW_TEXT(player, type, doMsgs, "On the door is a picture of a Cleric.");
                CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), EAST);
            }
        }
        protected override void FnEvent45(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, PARTY, CLERICDOORD) == 1) {
                SHOW_TEXT(player, type, doMsgs, "On the door is a picture of a Cleric.");
                CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), SOUTH);
            }
        }
        protected override void FnEvent46(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, DUNGEON, OPENDOORB) == 1) {
                SHOW_TEXT(player, type, doMsgs, "Proceed.");
                CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), WEST);
            }
        }
    }
}
