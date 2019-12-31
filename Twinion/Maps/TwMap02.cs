using XPT.Generic.Maps;
using XPT.Twinion.Entities;

namespace XPT.Twinion.Maps {
    class TwMap02 : TwMap {
        protected override int MapIndex => 2;
        protected override int MapID => 0x0103;
        protected override int RandomEncounterChance => 15;
        protected override int RandomEncounterExtraCount => 0;

        protected override void FnEvent01(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Through here is the Main Entrance.");
            TELEPORT(player, type, doMsgs, 1, 1, 140, WEST);
        }
        protected override void FnEvent02(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 1, 3, 159, SOUTH);
        }
        protected override void FnEvent03(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Now, enter the Coil Maze, and retrieve the Gauntlet.");
            TELEPORT(player, type, doMsgs, 1, 3, 247, WEST);
        }
        protected override void FnEvent04(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "To the North side....");
            TELEPORT(player, type, doMsgs, 1, 3, 155, NORTH);
        }
        protected override void FnEvent05(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "The sign here reads: The gauntlet has been thrown down in the Coil Maze.");
            SHOW_TEXT(player, type, doMsgs, "Now you must return it to its birth place, to solve this quest and complete this most simple phase.");
        }
        protected override void FnEvent06(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Depart not from the path which Fate has assigned you! You shall come full circle in time. And begin here what ends asunder.");
        }
        protected override void FnEvent07(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "This way to the Great Egress.");
        }
        protected override void FnEvent08(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "The Great Egress...");
        }
        protected override void FnEvent09(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "As you see, not all teleports lead to a different dungeon.");
        }
        protected override void FnEvent0B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                if (HAS_ITEM(player, type, doMsgs, LAVAGLOVE) || GET_FLAG(player, type, doMsgs, DUNGEON, LAVAQUEST) == 2) {
                    short teleportroom = 0;
                    TAKE_ITEM(player, type, doMsgs, LAVAGLOVE);
                    SHOW_TEXT(player, type, doMsgs, "You've won the challenge of the Gauntlet. I shall send you to its end.");
                    switch (GUILD(player, type, doMsgs)) {
                        case BARBARIAN:
                            teleportroom = 31;
                            break;
                        case KNIGHT:
                            teleportroom = 47;
                            break;
                        case RANGER:
                            teleportroom = 63;
                            break;
                        case THIEF:
                            teleportroom = 79;
                            break;
                        case WIZARD:
                            teleportroom = 95;
                            break;
                        case CLERIC:
                            teleportroom = 111;
                            break;
                    }
                    TELEPORT(player, type, doMsgs, 1, 3, teleportroom, EAST);
                }
                else {
                    SHOW_TEXT(player, type, doMsgs, "A wind whistles, 'Bring me the gauntlet from the maze south of here....'");
                    TELEPORT(player, type, doMsgs, 1, 3, 120, EAST);
                }
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "A forceful wind pushes your party back from the ancient forge. It howls, 'You must each step forth alone!'");
                TELEPORT(player, type, doMsgs, 1, 3, 120, EAST);
            }
        }
        protected override void FnEvent0C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Here you enter the Coils of the Maze...");
        }
        protected override void FnEvent0D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, FOUNTAIN);
            if (PARTY_LEVEL(player, type, doMsgs, 10)) {
                Nothing(player, type, doMsgs);
            }
            else if (HEALTH(player, type, doMsgs) < MAX_HEALTH(player, type, doMsgs)) {
                SHOW_TEXT(player, type, doMsgs, "The refreshing waters heal your wounds.");
                HEAL(player, type, doMsgs, MAX_HEALTH(player, type, doMsgs));
            }
            else {
                Nothing(player, type, doMsgs);
            }
        }
        private void Nothing(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "The fountain does nothing for you.");
        }
        protected override void FnEvent0F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (!GET_FLAG(player, type, doMsgs, DUNGEON, FIRSTQUEST)) {
                short skill = 0;
                short spell = 0;
                short itemA = 0;
                switch (HERE(player, type, doMsgs)) {
                    case 31:
                        SHOW_TEXT(player, type, doMsgs, "Well done, great Barbarian!");
                        skill = ARCHERY_SKILL;
                        spell = STORM_WIND_SPELL;
                        itemA = GREENLOCKPICK;
                        break;
                    case 47:
                        SHOW_TEXT(player, type, doMsgs, "Well done, noble Knight!");
                        skill = CHANNEL_SKILL;
                        spell = CURSE_SPELL;
                        itemA = CRYSTALBALL;
                        break;
                    case 63:
                        SHOW_TEXT(player, type, doMsgs, "Well done, loyal Ranger!");
                        skill = INTIMIDATE_SKILL;
                        spell = PETRIFY_SPELL;
                        itemA = CROSSBOW;
                        break;
                    case 79:
                        SHOW_TEXT(player, type, doMsgs, "Well done, master Thief!");
                        skill = ARCHERY_SKILL;
                        spell = BACKFIRE_SPELL;
                        itemA = LEATHERJACKET;
                        break;
                    case 95:
                        SHOW_TEXT(player, type, doMsgs, "Well done, master Wizard!");
                        skill = DEFLECT_MAGIC_SKILL;
                        spell = HEAL_SPELL;
                        itemA = QUARTERSTAFF;
                        break;
                    case 111:
                        SHOW_TEXT(player, type, doMsgs, "Well done, devout Cleric!");
                        skill = RUNE_READING_SKILL;
                        spell = LIGHTNING_SPELL;
                        itemA = QUARTERSTAFF;
                        break;
                }
                SET_FLAG(player, type, doMsgs, DUNGEON, FIRSTQUEST, 1);
                SET_FLAG(player, type, doMsgs, DUNGEON, LAVAQUEST, 2);
                SHOW_TEXT(player, type, doMsgs, "Take this spell and this skill as rewards for your questing; and gain experience from your actions.");
                MOD_EXP(player, type, doMsgs, 1000);
                MOD_SKILL(player, type, doMsgs, skill, 1);
                GIVE_SPELL(player, type, doMsgs, spell, 1);
                GIVE_ITEM(player, type, doMsgs, itemA);
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "You've already received your rewards.");
            }
        }
        protected override void FnEvent14(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short i = 0;
            if (HAS_ITEM(player, type, doMsgs, READTRACKSTALISMAN)) {
                SHOW_TEXT(player, type, doMsgs, "Mages hurl magic at you!");
            }
            else {
                SET_BOOTY(player, type, doMsgs, READTRACKSTALISMAN, 0, 0, 0, 0, 35);
                SHOW_TEXT(player, type, doMsgs, "You come across some ancient Wizards!");
            }
            switch (PARTY_COUNT(player, type, doMsgs)) {
                case 1:
                    GET_MONSTER(player, type, doMsgs, 01, 27);
                    break;
                case 2:
                    for (i = 1; i <= 3; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 27);
                    }
                    break;
                default:
                    SHOW_TEXT(player, type, doMsgs, "And their familiars!");
                    for (i = 1; i <= 2; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 34);
                    }
                    for (i = 3; i <= 4; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 27);
                    }
                    break;
            }
        }
        protected override void FnEvent15(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short i = 0;
            if (HAS_ITEM(player, type, doMsgs, CRYSTALBALL)) {
                SHOW_TEXT(player, type, doMsgs, "Some Berserkers turn to attack!");
            }
            else {
                SET_BOOTY(player, type, doMsgs, CRYSTALBALL, 0, 0, 0, 0, 100);
                SHOW_TEXT(player, type, doMsgs, "Berserkers fighting over a spherical crystal draw you into the fray!");
            }
            switch (PARTY_COUNT(player, type, doMsgs)) {
                case 1:
                    GET_MONSTER(player, type, doMsgs, 01, 31);
                    break;
                case 2:
                    for (i = 1; i <= 2; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 32);
                    }
                    break;
                default:
                    for (i = 1; i <= 2; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 32);
                    }
                    for (i = 3; i <= 4; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 33);
                    }
                    break;
            }
        }
        protected override void FnEvent16(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short i = 0;
            if (HAS_ITEM(player, type, doMsgs, HEALPOTION)) {
                SHOW_TEXT(player, type, doMsgs, "You encounter some novice adventurers.");
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "Wizards and Brigands traveling together challenge you to combat!  The wager is your life for their potion!");
                SET_BOOTY(player, type, doMsgs, HEALPOTION, 0, 0, 0, 0, 100);
            }
            switch (PARTY_COUNT(player, type, doMsgs)) {
                case 1:
                    GET_MONSTER(player, type, doMsgs, 01, 25);
                    break;
                case 2:
                    GET_MONSTER(player, type, doMsgs, 1, 25);
                    GET_MONSTER(player, type, doMsgs, 2, 26);
                    break;
                default:
                    for (i = 1; i <= 2; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 26);
                    }
                    for (i = 5; i <= 6; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 25);
                    }
                    break;
            }
        }
        protected override void FnEvent17(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short i = 0;
            switch (PARTY_COUNT(player, type, doMsgs)) {
                case 1:
                    GET_MONSTER(player, type, doMsgs, 01, 35);
                    break;
                case 2:
                    for (i = 1; i <= 2; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 35);
                    }
                    break;
                default:
                    for (i = 1; i <= 2; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 25);
                    }
                    for (i = 3; i <= 5; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 35);
                    }
                    break;
            }
        }
        protected override void FnEvent18(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HAS_ITEM(player, type, doMsgs, TELEPORTPASS)) {
                SHOW_TEXT(player, type, doMsgs, "Young thieves jump you!");
            }
            else {
                SET_BOOTY(player, type, doMsgs, TELEPORTPASS, 0, 0, 0, 0, 100);
                SHOW_TEXT(player, type, doMsgs, "A thief tucks a sheet of paper under his jacket as he and his colleagues hear you approach.");
            }
            if (PARTY_COUNT(player, type, doMsgs) == 1 || PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 35);
                GET_MONSTER(player, type, doMsgs, 02, 34);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 34);
                GET_MONSTER(player, type, doMsgs, 02, 35);
                GET_MONSTER(player, type, doMsgs, 03, 36);
                GET_MONSTER(player, type, doMsgs, 04, 37);
            }
        }
        protected override void FnEvent19(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Small pinholes of light seep through the cracks in the wall here.");
            if (USED_SKILL(player, type, doMsgs, DETECT_SKILL) >= 3 || USED_SPELL(player, type, doMsgs, TRUE_SEEING_SPELL) || USED_ITEM(player, type, doMsgs, CRYSTALBALL, CRYSTALBALL) || USED_ITEM(player, type, doMsgs, VALKYRIESHELM, VALKYRIESHELM) || USED_ITEM(player, type, doMsgs, RINGOFTHIEVES, RINGOFTHIEVES) || USED_ITEM(player, type, doMsgs, HELMOFWISDOM, HELMOFWISDOM)) {
                PLACE_WALL_ITEM(player, type, doMsgs, DOOR, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
                SHOW_TEXT(player, type, doMsgs, "You've uncovered a hidden door!");
                CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
            }
            else {
                BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
                REMOVE_WALL_ITEM(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
            }
        }
        protected override void FnEvent1A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short i = 0;
            if (HAS_ITEM(player, type, doMsgs, LAVAGLOVE)) {
                SHOW_TEXT(player, type, doMsgs, "Rogues rush out at you from the shadows.");
                SET_BOOTY(player, type, doMsgs, LONGSWORD, HEALPOTION, 0, 0, 0, 250);
            }
            else if (GET_FLAG(player, type, doMsgs, DUNGEON, LAVAQUEST) == 2 || !GET_FLAG(player, type, doMsgs, DUNGEON, LAVAQUEST)) {
                SHOW_TEXT(player, type, doMsgs, "You spot the Lava Glove on the rogue leader's hand, as he signals his henchmen to attack!");
                SET_BOOTY(player, type, doMsgs, LAVAGLOVE, MANAELIXIR, ELIXIROFHEALTH, 0, 0, 1000);
            }
            else if (!HAS_ITEM(player, type, doMsgs, LAVAGLOVE)) {
                SHOW_TEXT(player, type, doMsgs, "You spot the Lava Glove on the rogue leader's hand, as he signals his henchmen to attack!");
                SET_BOOTY(player, type, doMsgs, LAVAGLOVE, HEALPOTION, 0, 0, 0, 250);
            }
            switch (PARTY_COUNT(player, type, doMsgs)) {
                case 1:
                    GET_MONSTER(player, type, doMsgs, 01, 26);
                    GET_MONSTER(player, type, doMsgs, 05, 37);
                    break;
                case 2:
                    GET_MONSTER(player, type, doMsgs, 01, 26);
                    GET_MONSTER(player, type, doMsgs, 02, 28);
                    GET_MONSTER(player, type, doMsgs, 06, 37);
                    break;
                default:
                    for (i = 1; i <= 4; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 26);
                    }
                    GET_MONSTER(player, type, doMsgs, 5, 29);
                    GET_MONSTER(player, type, doMsgs, 6, 37);
                    break;
            }
        }
        protected override void FnEvent1B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, DUNGEON, ENDGAMETELE) == 1) {
                SHOW_TEXT(player, type, doMsgs, "This is the nexus point from where you start your final journey...");
                TELEPORT(player, type, doMsgs, 2, 3, 255, NORTH);
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "What a magnificent carving, you must come back and examine it more closely when you have time.");
                SHOW_TEXT(player, type, doMsgs, "But right now there's too much to do.");
            }
        }
        protected override void FnEvent1C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            REMOVE_WALL_ITEM(player, type, doMsgs, 157, WEST);
            REMOVE_WALL_ITEM(player, type, doMsgs, 124, WEST);
        }
        protected override void FnEvent1D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (!GET_FLAG(player, type, doMsgs, PARTY, BEENHERE)) {
                SHOW_TEXT(player, type, doMsgs, "Swords and sorcery come rushing at you!");
            }
            else if (GET_FLAG(player, type, doMsgs, PARTY, BEENHERE) == 1) {
                SHOW_TEXT(player, type, doMsgs, "Duelists and Wizards attack as you approach.");
                SET_BOOTY(player, type, doMsgs, BROADSWORD, QUARTERSTAFF, 0, 0, 0, 200);
            }
            if (PARTY_COUNT(player, type, doMsgs) == 1 || PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 38);
                GET_MONSTER(player, type, doMsgs, 05, 39);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 39);
                GET_MONSTER(player, type, doMsgs, 02, 40);
                GET_MONSTER(player, type, doMsgs, 03, 38);
                GET_MONSTER(player, type, doMsgs, 04, 39);
            }
        }
        protected override void FnEvent1E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (!GET_FLAG(player, type, doMsgs, ROOM, GOTFLAG)) {
                short i = 0;
                i = GET_FLAG(player, type, doMsgs, PARTY, BEENHERE);
                if (i <= 1) {
                    i++;
                    SET_FLAG(player, type, doMsgs, PARTY, BEENHERE, i);
                }
                SET_FLAG(player, type, doMsgs, ROOM, GOTFLAG, 1);
            }
        }
        protected override void FnEvent1F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "This seems an odd place for a teleport.");
            TELEPORT(player, type, doMsgs, 1, 3, 123, SOUTH);
        }
        protected override void FnEvent20(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 1, 3, 152, WEST);
        }
        protected override void FnEvent21(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Into the corner with you.");
            TELEPORT(player, type, doMsgs, 1, 3, 240, EAST);
        }
        protected override void FnEvent22(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 1, 3, 250, NORTH);
        }
        protected override void FnEvent23(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_RUNES(player, type, doMsgs, "The Gauntlet is a useful item. But first you must enter the coils to retrieve it.");
        }
        protected override void FnEvent24(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "The rewards are worthwhile, if you are careful and search all the corners.");
        }
        protected override void FnEvent25(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Welcome to the southern half of The Gauntlet.");
            SHOW_TEXT(player, type, doMsgs, "Feel free to explore the coils while you are here.");
        }
        protected override void FnEvent26(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_RUNES(player, type, doMsgs, "They can be found to the north by going east and south of where you are.");
        }
        protected override void FnEvent27(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "There must be a portal tucked away in some distant corner.");
        }
        protected override void FnEvent28(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_RUNES(player, type, doMsgs, "To the northeast, there lies such a portal.");
        }
        protected override void FnEvent29(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Westward, an ancient foundry, now extinct, lies at the bottom of a shaft. It was here that the Lava Glove was born...and here it must return once you've retrieved it.");
        }
        protected override void FnEvent2A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (USED_ITEM(player, type, doMsgs, GREENLOCKPICK, BLUELOCKPICK) || USED_SKILL(player, type, doMsgs, LOCKPICK_SKILL) > 1) {
                SHOW_TEXT(player, type, doMsgs, "You've picked the lock. Proceed.");
                CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
            }
            else {
                BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
                SHOW_TEXT(player, type, doMsgs, "A locked door impedes your progress here.");
            }
        }
        protected override void FnEvent2B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HAS_ITEM(player, type, doMsgs, LAVAGLOVE) && !GET_FLAG(player, type, doMsgs, DUNGEON, LAVAQUEST)) {
                SET_FLAG(player, type, doMsgs, DUNGEON, LAVAQUEST, 1);
                SHOW_TEXT(player, type, doMsgs, "Well done! Now, to the ancient foundry near the heart of this level. You must step onto the foundry in the center to return the Gauntlet!");
                SHOW_TEXT(player, type, doMsgs, "Hurry, your rewards await!");
            }
        }
        protected override void FnEvent2C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Magical waters spill out of the southern portal here; culminating in a small puddle on the floor.");
        }
        protected override void FnEvent2D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                SHOW_TEXT(player, type, doMsgs, "To the Snake River.");
                TELEPORT(player, type, doMsgs, 1, 2, 223, WEST);
            }
            else {
                TELEPORT(player, type, doMsgs, 1, 3, HERE(player, type, doMsgs), NORTH);
                SHOW_TEXT(player, type, doMsgs, "Your party must split and enter this narrow portal one by one to proceed.");
            }
        }
    }
}
