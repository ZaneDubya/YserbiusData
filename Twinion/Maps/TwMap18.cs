using XPT.Generic.Maps;
using XPT.Twinion.Entities;

namespace XPT.Twinion.Maps {
    class TwMap18 : TwMap {
        protected override int MapIndex => 18;
        protected override int MapID => 0x0702;
        protected override int RandomEncounterChance => 0;
        protected override int RandomEncounterExtraCount => 0;

        protected override void FnEvent01(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 25);
                GET_MONSTER(player, type, doMsgs, 02, 25);
                GET_MONSTER(player, type, doMsgs, 03, 25);
                GET_MONSTER(player, type, doMsgs, 04, 25);
                GET_MONSTER(player, type, doMsgs, 05, 1);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 25);
                GET_MONSTER(player, type, doMsgs, 02, 25);
                GET_MONSTER(player, type, doMsgs, 03, 25);
                GET_MONSTER(player, type, doMsgs, 05, 5);
                GET_MONSTER(player, type, doMsgs, 06, 7);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 25);
                GET_MONSTER(player, type, doMsgs, 02, 25);
                GET_MONSTER(player, type, doMsgs, 03, 4);
                GET_MONSTER(player, type, doMsgs, 04, 7);
                GET_MONSTER(player, type, doMsgs, 05, 8);
                GET_MONSTER(player, type, doMsgs, 06, 9);
            }
        }
        protected override void FnEvent02(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 2);
                GET_MONSTER(player, type, doMsgs, 02, 14);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 3);
                GET_MONSTER(player, type, doMsgs, 02, 5);
                GET_MONSTER(player, type, doMsgs, 03, 14);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 4);
                GET_MONSTER(player, type, doMsgs, 02, 7);
                GET_MONSTER(player, type, doMsgs, 03, 8);
                GET_MONSTER(player, type, doMsgs, 04, 13);
                GET_MONSTER(player, type, doMsgs, 05, 17);
                GET_MONSTER(player, type, doMsgs, 06, 19);
            }
        }
        protected override void FnEvent03(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "The Snake Charm rattles at the Giant Asp as you approach.");
            SHOW_TEXT(player, type, doMsgs, "'Kill me if you can, foolish mortals-s-s.'");
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 1);
                GET_MONSTER(player, type, doMsgs, 05, 24);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 3);
                GET_MONSTER(player, type, doMsgs, 02, 6);
                GET_MONSTER(player, type, doMsgs, 06, 24);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 3);
                GET_MONSTER(player, type, doMsgs, 02, 4);
                GET_MONSTER(player, type, doMsgs, 04, 8);
                GET_MONSTER(player, type, doMsgs, 05, 10);
                GET_MONSTER(player, type, doMsgs, 06, 24);
            }
        }
        protected override void FnEvent04(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 14);
                GET_MONSTER(player, type, doMsgs, 02, 19);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 14);
                GET_MONSTER(player, type, doMsgs, 02, 17);
                GET_MONSTER(player, type, doMsgs, 03, 21);
                GET_MONSTER(player, type, doMsgs, 05, 23);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 13);
                GET_MONSTER(player, type, doMsgs, 02, 14);
                GET_MONSTER(player, type, doMsgs, 03, 19);
                GET_MONSTER(player, type, doMsgs, 05, 20);
                GET_MONSTER(player, type, doMsgs, 06, 22);
            }
        }
        protected override void FnEvent05(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 11);
                GET_MONSTER(player, type, doMsgs, 02, 16);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 11);
                GET_MONSTER(player, type, doMsgs, 02, 12);
                GET_MONSTER(player, type, doMsgs, 04, 16);
                GET_MONSTER(player, type, doMsgs, 06, 21);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 10);
                GET_MONSTER(player, type, doMsgs, 02, 13);
                GET_MONSTER(player, type, doMsgs, 04, 16);
                GET_MONSTER(player, type, doMsgs, 05, 20);
                GET_MONSTER(player, type, doMsgs, 06, 22);
            }
        }
        protected override void FnEvent06(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 23);
                GET_MONSTER(player, type, doMsgs, 02, 11);
                GET_MONSTER(player, type, doMsgs, 05, 25);
                GET_MONSTER(player, type, doMsgs, 06, 25);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 7);
                GET_MONSTER(player, type, doMsgs, 02, 22);
                GET_MONSTER(player, type, doMsgs, 03, 25);
                GET_MONSTER(player, type, doMsgs, 05, 15);
                GET_MONSTER(player, type, doMsgs, 06, 12);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 8);
                GET_MONSTER(player, type, doMsgs, 02, 10);
                GET_MONSTER(player, type, doMsgs, 03, 12);
                GET_MONSTER(player, type, doMsgs, 04, 15);
                GET_MONSTER(player, type, doMsgs, 05, 20);
                GET_MONSTER(player, type, doMsgs, 06, 21);
            }
        }
        protected override void FnEvent07(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 18);
                GET_MONSTER(player, type, doMsgs, 02, 17);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 8);
                GET_MONSTER(player, type, doMsgs, 02, 8);
                GET_MONSTER(player, type, doMsgs, 04, 17);
                GET_MONSTER(player, type, doMsgs, 06, 19);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 8);
                GET_MONSTER(player, type, doMsgs, 02, 8);
                GET_MONSTER(player, type, doMsgs, 04, 18);
                GET_MONSTER(player, type, doMsgs, 05, 19);
                GET_MONSTER(player, type, doMsgs, 06, 19);
            }
        }
        protected override void FnEvent08(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HAS_ITEM(player, type, doMsgs, SNAKECHARM)) {
                if (GET_FLAG(player, type, doMsgs, DUNGEON, RUBY) == 1) {
                    if (HAS_ITEM(player, type, doMsgs, RUBYLOCKPICK)) {
                        SHOW_TEXT(player, type, doMsgs, "You find nothing of interest.");
                        TAKE_ITEM(player, type, doMsgs, SNAKECHARM);
                    }
                    else {
                        SHOW_TEXT(player, type, doMsgs, "You find a brilliant, red Ruby Lockpick.");
                        SHOW_TEXT(player, type, doMsgs, "Your Snake Charm falls to the ground and shatters.");
                        GIVE_ITEM(player, type, doMsgs, RUBYLOCKPICK);
                        TAKE_ITEM(player, type, doMsgs, SNAKECHARM);
                    }
                }
                else {
                    SHOW_TEXT(player, type, doMsgs, "You discover the treasure trove of the Giant Asp and what it fought so hard to protect.");
                    SHOW_TEXT(player, type, doMsgs, "As you lean forward to grab a glowing red Ruby Lockpick, the 25,000 in gold and the other assorted treasures, your Snake Charm falls to the ground and shatters.");
                    GIVE_ITEM(player, type, doMsgs, RUBYLOCKPICK);
                    GIVE_ITEM(player, type, doMsgs, HEALAMPHORA);
                    GIVE_ITEM(player, type, doMsgs, THIEVESFLUTE);
                    GIVE_ITEM(player, type, doMsgs, SYMBOLOFDEATH);
                    MOD_EXP(player, type, doMsgs, 50000);
                    MOD_GOLD(player, type, doMsgs, 25000);
                    TAKE_ITEM(player, type, doMsgs, SNAKECHARM);
                    SET_FLAG(player, type, doMsgs, DUNGEON, RUBY, 01);
                }
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "You find nothing of interest.");
            }
        }
        protected override void FnEvent09(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 17);
                GET_MONSTER(player, type, doMsgs, 02, 18);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 17);
                GET_MONSTER(player, type, doMsgs, 02, 19);
                GET_MONSTER(player, type, doMsgs, 03, 19);
                GET_MONSTER(player, type, doMsgs, 04, 20);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 19);
                GET_MONSTER(player, type, doMsgs, 02, 19);
                GET_MONSTER(player, type, doMsgs, 03, 20);
                GET_MONSTER(player, type, doMsgs, 05, 21);
                GET_MONSTER(player, type, doMsgs, 06, 23);
            }
        }
        protected override void FnEvent0A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 4, 1, 241, EAST);
        }
        protected override void FnEvent0B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Opening the door to the south reveals a shaft lined with rough walls. You use the notches as footholds to climb to the top.");
        }
        protected override void FnEvent0C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 2);
                GET_MONSTER(player, type, doMsgs, 02, 6);
                GET_MONSTER(player, type, doMsgs, 03, 13);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 1);
                GET_MONSTER(player, type, doMsgs, 02, 4);
                GET_MONSTER(player, type, doMsgs, 03, 6);
                GET_MONSTER(player, type, doMsgs, 04, 14);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 4);
                GET_MONSTER(player, type, doMsgs, 02, 7);
                GET_MONSTER(player, type, doMsgs, 03, 8);
                GET_MONSTER(player, type, doMsgs, 04, 14);
                GET_MONSTER(player, type, doMsgs, 05, 19);
                GET_MONSTER(player, type, doMsgs, 06, 19);
            }
        }
        protected override void FnEvent0D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 14);
                GET_MONSTER(player, type, doMsgs, 02, 19);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 23);
                GET_MONSTER(player, type, doMsgs, 02, 22);
                GET_MONSTER(player, type, doMsgs, 04, 21);
                GET_MONSTER(player, type, doMsgs, 06, 14);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 20);
                GET_MONSTER(player, type, doMsgs, 02, 19);
                GET_MONSTER(player, type, doMsgs, 03, 19);
                GET_MONSTER(player, type, doMsgs, 04, 20);
                GET_MONSTER(player, type, doMsgs, 05, 14);
            }
        }
        protected override void FnEvent0E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 12);
                GET_MONSTER(player, type, doMsgs, 02, 16);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 16);
                GET_MONSTER(player, type, doMsgs, 02, 15);
                GET_MONSTER(player, type, doMsgs, 03, 12);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 12);
                GET_MONSTER(player, type, doMsgs, 02, 15);
                GET_MONSTER(player, type, doMsgs, 03, 15);
                GET_MONSTER(player, type, doMsgs, 04, 16);
            }
        }
        protected override void FnEvent0F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You see a warning sign -");
            SHOW_TEXT(player, type, doMsgs, "'Proceed at your own risk!!!'");
            SHOW_TEXT(player, type, doMsgs, "'If you don't have THE powerful talisman - you'll know what it is when it saves your worthless lives - go no further!'");
        }
        protected override void FnEvent10(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 5, 3, 17, SOUTH);
        }
        protected override void FnEvent11(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, GNOMEBARBARIAN);
            SHOW_TEXT(player, type, doMsgs, "An exhausted Barbarian sighs, 'This place isn't the Rat Race Track, is it?");
            SHOW_TEXT(player, type, doMsgs, "I got a great tip from an Elf Thief about a special weapon to be found in a Rat Race or Race Track or Tracking Race Rats or something like that.");
            SHOW_TEXT(player, type, doMsgs, "Just my luck! All I found while I was searching was a curious piece of leather.'");
        }
        protected override void FnEvent12(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, MEDUSA);
            SHOW_TEXT(player, type, doMsgs, "A medusa studies you with icy eyes.");
            SHOW_TEXT(player, type, doMsgs, "'If I had more time I'd kill you, but I seek greater reward.");
            SHOW_TEXT(player, type, doMsgs, "Rumor of a dragon feud has reached me, and I must be off.");
            SHOW_TEXT(player, type, doMsgs, "I will leave you as food for my pets.'");
        }
        protected override void FnEvent13(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
                SHOW_TEXT(player, type, doMsgs, "Wicked hisses issue forth from the other side.");
            }
            else {
                BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
                SHOW_TEXT(player, type, doMsgs, "You must squeeze through this narrow opening one at a time.");
            }
        }
        protected override void FnEvent14(TwPlayerServer player, MapEventType type, bool doMsgs) {
            NO_JOIN(player, type, doMsgs);
        }
        protected override void FnEvent15(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((HAS_ITEM(player, type, doMsgs, SNAKECHARM) == 0)) {
                SHOW_TEXT(player, type, doMsgs, "The Giant Asp laughs at your feeble attempts to kill him.");
                SHOW_TEXT(player, type, doMsgs, "'You are not protected by that curs-s-sed S-s-snake Charm!'");
                SHOW_TEXT(player, type, doMsgs, "The Giant Asp slays you with one mighty blow.");
                DAMAGE(player, type, doMsgs, MAX_HEALTH(player, type, doMsgs));
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "The Giant Asp sees your Snake Charm and shrinks back.");
                SHOW_TEXT(player, type, doMsgs, "'Curs-s-se you and that curs-s-sed S-s-snake Charm!");
                SHOW_TEXT(player, type, doMsgs, "Follow me if you dare, mortals-s-s.'");
            }
        }
    }
}
