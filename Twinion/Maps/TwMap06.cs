namespace XPT.Twinion.Maps {
    class TwMap06 : TwMap {
        protected override int MapIndex => 6;
        protected override int MapID => 0x0301;
        protected override int RandomEncounterChance => 5;
        protected override int RandomEncounterExtraCount => 2;

        protected override void FnEvent01(TwPlayerServer player, MapEventType type, bool doMsgs) {
            BLOCK_FLOOR(player, type, doMsgs, HERE());
        }
        protected override void FnEvent02(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "To the first Arena.");
            TELEPORT(player, type, doMsgs, 3, 1, 15, SOUTH);
        }
        protected override void FnEvent03(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "To the second Arena.");
            TELEPORT(player, type, doMsgs, 3, 1, 0, EAST);
        }
        protected override void FnEvent04(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "To the third Arena.");
            TELEPORT(player, type, doMsgs, 3, 1, 208, EAST);
        }
        protected override void FnEvent05(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "To the fourth Arena.");
            TELEPORT(player, type, doMsgs, 3, 1, 207, SOUTH);
        }
        protected override void FnEvent06(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "To the way out.");
            TELEPORT(player, type, doMsgs, 3, 1, 124, SOUTH);
        }
        protected override void FnEvent07(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "This leads to the Queen's Palace.");
            if (GET_FLAG(player, type, doMsgs, DUNGEON, TOTAL) < 4) {
                SHOW_TEXT(player, type, doMsgs, "There are more Arenas to complete when you feel ready. You may proceed now.");
            }
            TELEPORT(player, type, doMsgs, 3, 2, 128, EAST);
        }
        protected override void FnEvent08(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GUILD() != THIEF) {
                if (GET_STAT(player, type, doMsgs, STRENGTH) >= 18) {
                    SHOW_TEXT(player, type, doMsgs, "You're strong enough to move the column and get around it.");
                    special39(player, type, doMsgs);
                }
                else {
                    BLOCK_WALL(player, type, doMsgs, HERE(), FACING());
                }
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "Your abilities will allow you to squeeze through a narrow gap between the columns.");
                special39(player, type, doMsgs);
            }
        }
        protected override void FnEvent09(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GUILD() == WIZARD || GUILD() == CLERIC) {
                SHOW_TEXT(player, type, doMsgs, "Blessed are the Magi! For your wisdom is obvious; this magical pillar slides away allowing you to pass.");
                special40(player, type, doMsgs);
            }
            else if (GUILD() == THIEF) {
                SHOW_TEXT(player, type, doMsgs, "Your abilities will allow you to squeeze through a narrow gap between the columns.");
                special40(player, type, doMsgs);
            }
            else {
                BLOCK_WALL(player, type, doMsgs, HERE(), FACING());
            }
        }
        protected override void FnEvent0A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You plummet to your death!");
            DAMAGE(player, type, doMsgs, MAX_HEALTH());
        }
        protected override void FnEvent0B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short tally;
            int exps = 0;;
            tally = GET_FLAG(player, type, doMsgs, DUNGEON, QUADRANTA);
             + GET_FLAG(player, type, doMsgs, DUNGEON, QUADRANTB);
             + GET_FLAG(player, type, doMsgs, DUNGEON, QUADRANTC);
             + GET_FLAG(player, type, doMsgs, DUNGEON, QUADRANTD);
            if (GET_FLAG(player, type, doMsgs, DUNGEON, TOTAL) < tally) {
                SHOW_TEXT(player, type, doMsgs, "Well done! Proceed to the exit. The end of these Proving Grounds is near!");
                switch (tally) {
                    case 1:
                        exps = 15000;
                        break;
                    case 2:
                        exps = 15000;
                        break;
                    case 3:
                        exps = 15000;
                        break;
                    case 4:
                        exps = 15000;
                        break;
                }
                SET_FLAG(player, type, doMsgs, DUNGEON, TOTAL, tally);
                MOD_EXP(player, type, doMsgs, exps);
                ClearDoor(player, type, doMsgs);
                SHOW_TEXT(player, type, doMsgs, "Your accomplishment deserves the attributed reward. This experience will aid you in reaching the next level.");
            }
            else if (GET_FLAG(player, type, doMsgs, DUNGEON, TOTAL) == tally && GET_FLAG(player, type, doMsgs, DUNGEON, TOTAL) < 4) {
                ClearDoor(player, type, doMsgs);
                SHOW_TEXT(player, type, doMsgs, "There are more Arenas to complete when you feel ready. You may proceed now.");
            }
            else {
                ClearDoor(player, type, doMsgs);
                SHOW_TEXT(player, type, doMsgs, "There's nothing more for you here.");
            }
        }
        private void ClearDoor(TwPlayerServer player, MapEventType type, bool doMsgs) {
            CLEAR_WALL(player, type, doMsgs, HERE(), FACING());
            PLACE_WALL_ITEM(player, type, doMsgs, DOOR, HERE(), FACING());
        }
        protected override void FnEvent0C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short i;
            SHOW_TEXT(player, type, doMsgs, "Magi hurl spells at you!");
            if (PARTY_COUNT() == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 39);
                GET_MONSTER(player, type, doMsgs, 05, 40);
            }
            else if (PARTY_COUNT() == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 39);
                GET_MONSTER(player, type, doMsgs, 02, 39);
                GET_MONSTER(player, type, doMsgs, 05, 40);
            }
            else if (PARTY_COUNT() == 3) {
                for (i = 1; i <= 3; i++) {
                    GET_MONSTER(player, type, doMsgs, i, 39);
                }
                for (i = 5; i <= 6; i++) {
                    GET_MONSTER(player, type, doMsgs, i, 40);
                }
            }
            else {
                for (i = 1; i <= 3; i++) {
                    GET_MONSTER(player, type, doMsgs, i, 39);
                }
                for (i = 4; i <= 6; i++) {
                    GET_MONSTER(player, type, doMsgs, i, 40);
                }
            }
        }
        protected override void FnEvent0D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short i;
            SHOW_TEXT(player, type, doMsgs, "Arrows rain down upon you from an attacking party of Archers.");
            if (PARTY_COUNT() == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 31);
                GET_MONSTER(player, type, doMsgs, 05, 32);
            }
            else if (PARTY_COUNT() == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 31);
                GET_MONSTER(player, type, doMsgs, 02, 31);
                GET_MONSTER(player, type, doMsgs, 05, 32);
            }
            else if (PARTY_COUNT() == 3) {
                for (i = 1; i <= 2; i++) {
                    GET_MONSTER(player, type, doMsgs, i, 31);
                }
                for (i = 3; i <= 5; i++) {
                    GET_MONSTER(player, type, doMsgs, i, 32);
                }
            }
            else {
                for (i = 1; i <= 3; i++) {
                    GET_MONSTER(player, type, doMsgs, i, 32);
                }
                for (i = 4; i <= 6; i++) {
                    GET_MONSTER(player, type, doMsgs, i, 31);
                }
            }
        }
        protected override void FnEvent0E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Quarrelsome thieves charge you.");
            if (PARTY_COUNT() == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 35);
                GET_MONSTER(player, type, doMsgs, 05, 36);
            }
            else if (PARTY_COUNT() == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 35);
                GET_MONSTER(player, type, doMsgs, 02, 36);
                GET_MONSTER(player, type, doMsgs, 05, 37);
            }
            else if (PARTY_COUNT() == 3) {
                GET_MONSTER(player, type, doMsgs, 01, 35);
                GET_MONSTER(player, type, doMsgs, 02, 35);
                GET_MONSTER(player, type, doMsgs, 03, 36);
                GET_MONSTER(player, type, doMsgs, 05, 37);
                GET_MONSTER(player, type, doMsgs, 06, 36);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 35);
                GET_MONSTER(player, type, doMsgs, 02, 35);
                GET_MONSTER(player, type, doMsgs, 03, 36);
                GET_MONSTER(player, type, doMsgs, 04, 36);
                GET_MONSTER(player, type, doMsgs, 05, 37);
                GET_MONSTER(player, type, doMsgs, 06, 37);
            }
        }
        protected override void FnEvent0F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (!GET_FLAG(player, type, doMsgs, DUNGEON, QUADRANTA)) {
                SET_FLAG(player, type, doMsgs, DUNGEON, QUADRANTA, 1);
            }
            SHOW_TEXT(player, type, doMsgs, "A party of warriors intend to prevent you from completing this arena.");
            if (PARTY_COUNT() == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 30);
                GET_MONSTER(player, type, doMsgs, 05, 40);
            }
            else if (PARTY_COUNT() == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 30);
                GET_MONSTER(player, type, doMsgs, 02, 28);
                GET_MONSTER(player, type, doMsgs, 05, 33);
            }
            else if (PARTY_COUNT() == 3) {
                GET_MONSTER(player, type, doMsgs, 01, 33);
                GET_MONSTER(player, type, doMsgs, 02, 29);
                GET_MONSTER(player, type, doMsgs, 03, 39);
                GET_MONSTER(player, type, doMsgs, 05, 40);
                GET_MONSTER(player, type, doMsgs, 06, 28);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 38);
                GET_MONSTER(player, type, doMsgs, 02, 39);
                GET_MONSTER(player, type, doMsgs, 03, 40);
                GET_MONSTER(player, type, doMsgs, 04, 33);
                GET_MONSTER(player, type, doMsgs, 05, 33);
                GET_MONSTER(player, type, doMsgs, 06, 33);
            }
        }
        protected override void FnEvent10(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, HUMANWIZARD);
            SHOW_TEXT(player, type, doMsgs, "A nervous wizard chatters at you.");
            SHOW_TEXT(player, type, doMsgs, "'There are so many of them. So many...");
            SHOW_TEXT(player, type, doMsgs, "She said I would get great rewards for doing all four, but I know that only one would suffice.'");
        }
        protected override void FnEvent11(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Knights and their squires charge you.");
            short i;
            switch (PARTY_COUNT()) {
                case 1:
                    GET_MONSTER(player, type, doMsgs, 01, 34);
                    GET_MONSTER(player, type, doMsgs, 05, 27);
                    break;
                case 2:
                    for (i = 1; i <= 3; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 34);
                    }
                    break;
                default:
                    for (i = 1; i <= 3; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 27);
                    }
                    for (i = 4; i <= 6; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 34);
                    }
                    break;
            }
        }
        protected override void FnEvent12(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Gladiators and scavenging rogues take the offensive.");
            short i;
            switch (PARTY_COUNT()) {
                case 1:
                    GET_MONSTER(player, type, doMsgs, 01, 25);
                    GET_MONSTER(player, type, doMsgs, 05, 25);
                    break;
                case 2:
                    for (i = 1; i <= 3; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 26);
                    }
                    break;
                default:
                    for (i = 1; i <= 4; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 25);
                    }
                    for (i = 5; i <= 6; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 26);
                    }
                    break;
            }
        }
        protected override void FnEvent13(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "A hulking colossus towers over you.");
            short i;
            switch (PARTY_COUNT()) {
                case 1:
                    GET_MONSTER(player, type, doMsgs, 01, 38);
                    break;
                case 2:
                    for (i = 1; i <= 2; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 38);
                    }
                    break;
                default:
                    for (i = 1; i <= 4; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 38);
                    }
                    break;
            }
        }
        protected override void FnEvent14(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (!GET_FLAG(player, type, doMsgs, DUNGEON, QUADRANTB)) {
                SET_FLAG(player, type, doMsgs, DUNGEON, QUADRANTB, 1);
            }
            SHOW_TEXT(player, type, doMsgs, "An odd array of mage and muscle stands before you.");
            if (PARTY_COUNT() == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 38);
                GET_MONSTER(player, type, doMsgs, 05, 40);
            }
            else if (PARTY_COUNT() == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 38);
                GET_MONSTER(player, type, doMsgs, 02, 39);
                GET_MONSTER(player, type, doMsgs, 05, 40);
            }
            else if (PARTY_COUNT() == 3) {
                GET_MONSTER(player, type, doMsgs, 01, 38);
                GET_MONSTER(player, type, doMsgs, 02, 38);
                GET_MONSTER(player, type, doMsgs, 03, 39);
                GET_MONSTER(player, type, doMsgs, 05, 40);
                GET_MONSTER(player, type, doMsgs, 06, 40);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 38);
                GET_MONSTER(player, type, doMsgs, 02, 38);
                GET_MONSTER(player, type, doMsgs, 03, 40);
                GET_MONSTER(player, type, doMsgs, 04, 40);
                GET_MONSTER(player, type, doMsgs, 05, 39);
                GET_MONSTER(player, type, doMsgs, 06, 39);
            }
        }
        protected override void FnEvent15(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "A roster listing various guilds and names is posted here. Hmmm..your name does not appear on the list!");
        }
        protected override void FnEvent16(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT() == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 29);
                GET_MONSTER(player, type, doMsgs, 05, 32);
            }
            else if (PARTY_COUNT() == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 29);
                GET_MONSTER(player, type, doMsgs, 02, 32);
                GET_MONSTER(player, type, doMsgs, 05, 34);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 29);
                GET_MONSTER(player, type, doMsgs, 02, 32);
                GET_MONSTER(player, type, doMsgs, 03, 34);
                GET_MONSTER(player, type, doMsgs, 04, 39);
            }
        }
        protected override void FnEvent17(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Warring gladiators challenge you.");
            if (PARTY_COUNT() == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 3);
                GET_MONSTER(player, type, doMsgs, 05, 26);
            }
            else if (PARTY_COUNT() == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 3);
                GET_MONSTER(player, type, doMsgs, 02, 3);
                GET_MONSTER(player, type, doMsgs, 05, 26);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 26);
                GET_MONSTER(player, type, doMsgs, 02, 3);
                GET_MONSTER(player, type, doMsgs, 03, 3);
                GET_MONSTER(player, type, doMsgs, 04, 26);
                GET_MONSTER(player, type, doMsgs, 05, 26);
                GET_MONSTER(player, type, doMsgs, 06, 3);
            }
        }
        protected override void FnEvent18(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Swords and sorcery are unleashed against you.");
            if (PARTY_COUNT() == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 4);
                GET_MONSTER(player, type, doMsgs, 05, 7);
            }
            else if (PARTY_COUNT() == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 4);
                GET_MONSTER(player, type, doMsgs, 02, 7);
                GET_MONSTER(player, type, doMsgs, 05, 7);
            }
            else if (PARTY_COUNT() == 3) {
                GET_MONSTER(player, type, doMsgs, 01, 4);
                GET_MONSTER(player, type, doMsgs, 02, 4);
                GET_MONSTER(player, type, doMsgs, 03, 7);
                GET_MONSTER(player, type, doMsgs, 05, 7);
                GET_MONSTER(player, type, doMsgs, 06, 7);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 4);
                GET_MONSTER(player, type, doMsgs, 02, 4);
                GET_MONSTER(player, type, doMsgs, 03, 4);
                GET_MONSTER(player, type, doMsgs, 04, 4);
                GET_MONSTER(player, type, doMsgs, 05, 7);
                GET_MONSTER(player, type, doMsgs, 06, 7);
            }
        }
        protected override void FnEvent19(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (!GET_FLAG(player, type, doMsgs, DUNGEON, QUADRANTC)) {
                SET_FLAG(player, type, doMsgs, DUNGEON, QUADRANTC, 1);
            }
            SHOW_TEXT(player, type, doMsgs, "The air is filled with bursts of magic as a party of enchanters attacks.");
            if (PARTY_COUNT() == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 16);
                GET_MONSTER(player, type, doMsgs, 05, 20);
            }
            else if (PARTY_COUNT() == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 16);
                GET_MONSTER(player, type, doMsgs, 02, 20);
                GET_MONSTER(player, type, doMsgs, 05, 23);
            }
            else if (PARTY_COUNT() == 3) {
                GET_MONSTER(player, type, doMsgs, 01, 16);
                GET_MONSTER(player, type, doMsgs, 02, 23);
                GET_MONSTER(player, type, doMsgs, 03, 20);
                GET_MONSTER(player, type, doMsgs, 05, 23);
                GET_MONSTER(player, type, doMsgs, 06, 16);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 16);
                GET_MONSTER(player, type, doMsgs, 02, 16);
                GET_MONSTER(player, type, doMsgs, 03, 23);
                GET_MONSTER(player, type, doMsgs, 04, 23);
                GET_MONSTER(player, type, doMsgs, 05, 20);
                GET_MONSTER(player, type, doMsgs, 06, 20);
            }
        }
        protected override void FnEvent1A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Undead magi encircle you!");
            if (PARTY_COUNT() == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 17);
                GET_MONSTER(player, type, doMsgs, 05, 17);
            }
            else if (PARTY_COUNT() == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 17);
                GET_MONSTER(player, type, doMsgs, 02, 19);
                GET_MONSTER(player, type, doMsgs, 05, 19);
            }
            else if (PARTY_COUNT() == 3) {
                GET_MONSTER(player, type, doMsgs, 01, 17);
                GET_MONSTER(player, type, doMsgs, 02, 17);
                GET_MONSTER(player, type, doMsgs, 03, 19);
                GET_MONSTER(player, type, doMsgs, 05, 19);
                GET_MONSTER(player, type, doMsgs, 06, 19);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 17);
                GET_MONSTER(player, type, doMsgs, 02, 17);
                GET_MONSTER(player, type, doMsgs, 03, 19);
                GET_MONSTER(player, type, doMsgs, 04, 19);
                GET_MONSTER(player, type, doMsgs, 05, 17);
                GET_MONSTER(player, type, doMsgs, 06, 19);
            }
        }
        protected override void FnEvent1B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short i;
            SHOW_TEXT(player, type, doMsgs, "Spirits of magi and bones of thieves charge you.");
            if (PARTY_COUNT() == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 21);
                GET_MONSTER(player, type, doMsgs, 05, 13);
            }
            else if (PARTY_COUNT() == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 13);
                GET_MONSTER(player, type, doMsgs, 02, 21);
                GET_MONSTER(player, type, doMsgs, 05, 13);
            }
            else if (PARTY_COUNT() == 3) {
                for (i = 1; i <= 3; i++) {
                    GET_MONSTER(player, type, doMsgs, i, 13);
                }
                for (i = 5; i <= 6; i++) {
                    GET_MONSTER(player, type, doMsgs, i, 21);
                }
            }
            else {
                for (i = 1; i <= 3; i++) {
                    GET_MONSTER(player, type, doMsgs, i, 13);
                }
                for (i = 4; i <= 6; i++) {
                    GET_MONSTER(player, type, doMsgs, i, 21);
                }
            }
        }
        protected override void FnEvent1C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Long dead gladiators rise from the dust to attack you!");
            if (PARTY_COUNT() == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 11);
                GET_MONSTER(player, type, doMsgs, 05, 11);
            }
            else if (PARTY_COUNT() == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 11);
                GET_MONSTER(player, type, doMsgs, 02, 9);
                GET_MONSTER(player, type, doMsgs, 05, 9);
            }
            else if (PARTY_COUNT() == 3) {
                GET_MONSTER(player, type, doMsgs, 01, 11);
                GET_MONSTER(player, type, doMsgs, 02, 11);
                GET_MONSTER(player, type, doMsgs, 03, 9);
                GET_MONSTER(player, type, doMsgs, 05, 11);
                GET_MONSTER(player, type, doMsgs, 06, 9);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 9);
                GET_MONSTER(player, type, doMsgs, 02, 9);
                GET_MONSTER(player, type, doMsgs, 03, 11);
                GET_MONSTER(player, type, doMsgs, 04, 11);
                GET_MONSTER(player, type, doMsgs, 05, 9);
                GET_MONSTER(player, type, doMsgs, 06, 11);
            }
        }
        protected override void FnEvent1D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (!GET_FLAG(player, type, doMsgs, DUNGEON, QUADRANTD)) {
                SET_FLAG(player, type, doMsgs, DUNGEON, QUADRANTD, 1);
            }
            SHOW_TEXT(player, type, doMsgs, "Assorted undead heroes challenge you at this exit.");
            if (PARTY_COUNT() == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 9);
                GET_MONSTER(player, type, doMsgs, 05, 11);
            }
            else if (PARTY_COUNT() == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 9);
                GET_MONSTER(player, type, doMsgs, 02, 11);
                GET_MONSTER(player, type, doMsgs, 05, 21);
            }
            else if (PARTY_COUNT() == 3) {
                GET_MONSTER(player, type, doMsgs, 01, 9);
                GET_MONSTER(player, type, doMsgs, 02, 13);
                GET_MONSTER(player, type, doMsgs, 03, 17);
                GET_MONSTER(player, type, doMsgs, 05, 21);
                GET_MONSTER(player, type, doMsgs, 06, 21);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 9);
                GET_MONSTER(player, type, doMsgs, 02, 11);
                GET_MONSTER(player, type, doMsgs, 03, 13);
                GET_MONSTER(player, type, doMsgs, 04, 17);
                GET_MONSTER(player, type, doMsgs, 05, 21);
                GET_MONSTER(player, type, doMsgs, 06, 21);
            }
        }
        protected override void FnEvent1E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short time;
            SET_FLAG(player, type, doMsgs, DUNGEON, ARENASTASHA, 1);
            time = GET_FLAG(player, type, doMsgs, DUNGEON, ARENASTASHA);
             + GET_FLAG(player, type, doMsgs, DUNGEON, ARENASTASHB);
             + GET_FLAG(player, type, doMsgs, DUNGEON, ARENASTASHC);
             + GET_FLAG(player, type, doMsgs, DUNGEON, ARENASTASHD);
            if (GET_FLAG(player, type, doMsgs, DUNGEON, ITEMTOTAL) < time) {
                SET_FLAG(player, type, doMsgs, DUNGEON, ITEMTOTAL, time);
                SwitchCase(player, type, doMsgs);
            }
        }
        protected override void FnEvent1F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short time;
            SET_FLAG(player, type, doMsgs, DUNGEON, ARENASTASHB, 1);
            time = GET_FLAG(player, type, doMsgs, DUNGEON, ARENASTASHA);
             + GET_FLAG(player, type, doMsgs, DUNGEON, ARENASTASHB);
             + GET_FLAG(player, type, doMsgs, DUNGEON, ARENASTASHC);
             + GET_FLAG(player, type, doMsgs, DUNGEON, ARENASTASHD);
            if (GET_FLAG(player, type, doMsgs, DUNGEON, ITEMTOTAL) < time) {
                SET_FLAG(player, type, doMsgs, DUNGEON, ITEMTOTAL, time);
                SwitchCase(player, type, doMsgs);
            }
        }
        protected override void FnEvent20(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short time;
            SET_FLAG(player, type, doMsgs, DUNGEON, ARENASTASHC, 1);
            time = GET_FLAG(player, type, doMsgs, DUNGEON, ARENASTASHA);
             + GET_FLAG(player, type, doMsgs, DUNGEON, ARENASTASHB);
             + GET_FLAG(player, type, doMsgs, DUNGEON, ARENASTASHC);
             + GET_FLAG(player, type, doMsgs, DUNGEON, ARENASTASHD);
            if (GET_FLAG(player, type, doMsgs, DUNGEON, ITEMTOTAL) < time) {
                SET_FLAG(player, type, doMsgs, DUNGEON, ITEMTOTAL, time);
                SwitchCase(player, type, doMsgs);
            }
        }
        private void SwitchCase(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short ItemA;
            short ItemB;
            short ItemC;
            short ItemD;
            short gold;
            short time;
            time = GET_FLAG(player, type, doMsgs, DUNGEON, ITEMTOTAL);
            switch (time) {
                case 1:
                    ItemA = MANAELIXIR;
                    ItemB = BRONZEBATTLEAXE;
                    ItemC = WARHAT;
                    ItemD = GOLDBAR;
                    gold = 500;
                    break;
                case 2:
                    ItemA = ELIXIROFHEALTH;
                    ItemB = NINJASTICKS;
                    ItemC = HEADCHAINMAIL;
                    ItemD = BINDINGTALISMAN;
                    gold = 600;
                    break;
                case 3:
                    ItemA = FROSTBLADE;
                    ItemB = SCRIBESSALLET;
                    ItemC = SLIVERBAR;
                    ItemD = BREASTPLATE;
                    gold = 700;
                    break;
                case 4:
                    ItemA = MORNINGSTAR;
                    ItemB = SACKCLOTHJACKET;
                    ItemC = READTRACKSTALISMAN;
                    ItemD = CRYSTALBALL;
                    gold = 800;
                    break;
            }
            SHOW_TEXT(player, type, doMsgs, "You find some useful items.");
            GIVE_ITEM(player, type, doMsgs, ItemA);
            GIVE_ITEM(player, type, doMsgs, ItemB);
            GIVE_ITEM(player, type, doMsgs, ItemC);
            GIVE_ITEM(player, type, doMsgs, ItemD);
            MOD_GOLD(player, type, doMsgs, gold);
        }
        protected override void FnEvent21(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short time;
            SET_FLAG(player, type, doMsgs, DUNGEON, ARENASTASHD, 1);
            time = GET_FLAG(player, type, doMsgs, DUNGEON, ARENASTASHA);
             + GET_FLAG(player, type, doMsgs, DUNGEON, ARENASTASHB);
             + GET_FLAG(player, type, doMsgs, DUNGEON, ARENASTASHC);
             + GET_FLAG(player, type, doMsgs, DUNGEON, ARENASTASHD);
            if (GET_FLAG(player, type, doMsgs, DUNGEON, ITEMTOTAL) < time) {
                SET_FLAG(player, type, doMsgs, DUNGEON, ITEMTOTAL, time);
                SwitchCase(player, type, doMsgs);
            }
        }
        protected override void FnEvent22(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "The sounds of distant combats echo off the surrounding pillars as you enter the first Arena.");
        }
        protected override void FnEvent23(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Snarls from giants and orcish grunts greet you here in the second Arena.");
        }
        protected override void FnEvent24(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Bursts of magic light momentarily limn the silhouettes of the combatants in this third Arena.");
        }
        protected override void FnEvent25(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Anguished howls and death wails greet the wary visitor to this fourth Arena.");
        }
        protected override void FnEvent26(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "The huge columns of this room act more as barriers than supports.");
            SHOW_TEXT(player, type, doMsgs, "Through the gaps between columns you see bloody combats in what appear to be four different Arenas.");
        }
        protected override void FnEvent27(TwPlayerServer player, MapEventType type, bool doMsgs) {
            CLEAR_FLOOR(player, type, doMsgs, 139);
            CLEAR_FLOOR(player, type, doMsgs, 186);
            CLEAR_FLOOR(player, type, doMsgs, 199);
            CLEAR_FLOOR(player, type, doMsgs, 233);
            CLEAR_FLOOR(player, type, doMsgs, 176);
            CLEAR_FLOOR(player, type, doMsgs, 131);
            CLEAR_FLOOR(player, type, doMsgs, 64);
            CLEAR_FLOOR(player, type, doMsgs, 38);
            CLEAR_FLOOR(player, type, doMsgs, 56);
        }
        protected override void FnEvent28(TwPlayerServer player, MapEventType type, bool doMsgs) {
            CLEAR_FLOOR(player, type, doMsgs, 246);
            CLEAR_FLOOR(player, type, doMsgs, 200);
            CLEAR_FLOOR(player, type, doMsgs, 155);
            CLEAR_FLOOR(player, type, doMsgs, 75);
            CLEAR_FLOOR(player, type, doMsgs, 25);
            CLEAR_FLOOR(player, type, doMsgs, 101);
            CLEAR_FLOOR(player, type, doMsgs, 73);
        }
        protected override void FnEvent29(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GUILD() == RANGER) && (!GET_SKILL(player, type, doMsgs, REVERIE_SKILL))) {
                MOD_SKILL(player, type, doMsgs, REVERIE_SKILL, 1);
                Fountain(player, type, doMsgs);
            }
            else if ((GUILD() == THIEF) && (!GET_SKILL(player, type, doMsgs, REVERIE_SKILL))) {
                MOD_SKILL(player, type, doMsgs, REVERIE_SKILL, 1);
                Fountain(player, type, doMsgs);
            }
            else {
                NoFount(player, type, doMsgs);
            }
        }
        private void Fountain(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, FOUNTAIN);
            SHOW_TEXT(player, type, doMsgs, "A bubbling fountain offers knowledge and refreshment.");
            HEAL(player, type, doMsgs, MAX_HEALTH(),  / , 4);
        }
        private void NoFount(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, FOUNTAIN);
            SHOW_TEXT(player, type, doMsgs, "The waters offer you refreshment, but nothing more.");
        }
        protected override void FnEvent2A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GUILD() == WIZARD || GUILD() == CLERIC) {
                if (!GET_FLAG(player, type, doMsgs, DUNGEON, WIZFOUNTAIN)) {
                    GIVE_SPELL(player, type, doMsgs, HAIL_SPELL, 1);
                    Fountain(player, type, doMsgs);
                    SET_FLAG(player, type, doMsgs, DUNGEON, WIZFOUNTAIN, 1);
                }
            }
            else {
                NoFount(player, type, doMsgs);
            }
        }
        protected override void FnEvent2B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GUILD() == CLERIC) && (!GET_FLAG(player, type, doMsgs, DUNGEON, CLERICBACK))) {
                GIVE_SPELL(player, type, doMsgs, BACKFIRE_SPELL, 1);
                SET_FLAG(player, type, doMsgs, DUNGEON, CLERICBACK, 1);
                Fountain(player, type, doMsgs);
            }
            else {
                NoFount(player, type, doMsgs);
            }
        }
        protected override void FnEvent2C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, DUNGEON, TOTAL) < 4) {
                SHOW_TEXT(player, type, doMsgs, "There are more Arenas to complete when you feel ready. You may proceed for now.");
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "There's nothing more for you here.");
            }
        }
        protected override void FnEvent2D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            BLOCK_WALL(player, type, doMsgs, HERE(), FACING());
        }
        protected override void FnEvent2E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Markings here read- 'One way! To The Queen's Aqueduct.'");
            TELEPORT(player, type, doMsgs, 2, 1, 5, SOUTH);
        }
        protected override void FnEvent2F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "One way! Back to the Coliseum's Core.");
            TELEPORT(player, type, doMsgs, 3, 1, 136, SOUTH);
        }
    }
}
