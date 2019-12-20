namespace XPT.Twinion.Maps {
    class TwMap07 : TwMap {
        protected override int MapIndex => 7;
        protected override int MapID => 0x0302;
        protected override int RandomEncounterChance => 10;
        protected override int RandomEncounterExtraCount => 0;

        protected override void FnEvent01(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, DUNGEON, FINISHEDGAME) == 1) {
                SHOW_TEXT(player, type, doMsgs, "You see an empty, cracked throne.");
                SHOW_TEXT(player, type, doMsgs, "The Queen is no more.");
            }
            else {
                if (GET_FLAG(player, type, doMsgs, DUNGEON, DONEPROVING) == 1) {
                    SHOW_PICTURE(player, type, doMsgs, QUEENAEOWYN);
                    SHOW_TEXT(player, type, doMsgs, "A magnificent queen stands before you.");
                    SHOW_TEXT(player, type, doMsgs, "Her beauty and strength awe all who see her, woman and man alike. This is Queen Aeowyn.");
                    SHOW_TEXT(player, type, doMsgs, "'My champions, a key awaits you at the palace exit. Use it at the ancient gateway east of the main entrance.");
                    SHOW_TEXT(player, type, doMsgs, "Another portal will lead you to the depths of this volcano, where none has dared yet visit.");
                    SHOW_TEXT(player, type, doMsgs, "I require four pieces of an ancient map! I enjoin you with this task as a test of your loyalty.");
                    SHOW_TEXT(player, type, doMsgs, "Reveal your purpose to no one! Go now! Seek the Kingdom of the Night Elves.");
                    SHOW_TEXT(player, type, doMsgs, "I will meet you at your quest's end, that we may piece together the maps' meaning.'");
                    SHOW_TEXT(player, type, doMsgs, "With a royal wave of dismissal, Aeowyn weaves a spell of parting and vanishes.");
                    SET_FLAG(player, type, doMsgs, DUNGEON, DONEPROVING, 2);
                }
                else {
                    SHOW_TEXT(player, type, doMsgs, "Queen Aeowyn must be off looking for clues.");
                }
            }
        }
        private void WallBlock(TwPlayerServer player, MapEventType type, bool doMsgs) {
            BLOCK_WALL(player, type, doMsgs, HERE(), FACING());
        }
        protected override void FnEvent02(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "This leads back to the Coliseum.");
            TELEPORT(player, type, doMsgs, 3, 1, 127, NORTH);
        }
        protected override void FnEvent03(TwPlayerServer player, MapEventType type, bool doMsgs) {
            BLOCK_FLOOR(player, type, doMsgs, HERE());
        }
        protected override void FnEvent04(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "The warm waters soothe your pains.");
            HEAL(player, type, doMsgs, MAX_HEALTH());
        }
        protected override void FnEvent05(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, FOUNTAIN);
            SHOW_TEXT(player, type, doMsgs, "Elaborate fountains mark the entryway to Queen Aeowyn's throne room.");
        }
        protected override void FnEvent06(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You fall into a pit and are impaled on razor sharp spears.");
            DAMAGE(player, type, doMsgs, MAX_HEALTH());
        }
        protected override void FnEvent07(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (USED_ITEM(player, type, doMsgs, CROSSKEY, CROSSKEY)) {
                SHOW_TEXT(player, type, doMsgs, "The Cross Key unlocks the door!");
                CLEAR_WALL(player, type, doMsgs, HERE(), FACING());
                PLACE_WALL_ITEM(player, type, doMsgs, DOOR, HERE(), FACING());
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "The door's lock is marked with an X.");
                WallBlock(player, type, doMsgs);
            }
        }
        protected override void FnEvent08(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, DUNGEON, HINTEDATDOOR) == 1) {
                if (USED_SKILL(player, type, doMsgs, DETECT_SKILL) >= 9 || USED_SPELL(player, type, doMsgs, TRUE_SEEING_SPELL) || USED_ITEM(player, type, doMsgs, HELMOFWISDOM, HELMOFWISDOM) || USED_ITEM(player, type, doMsgs, VALKYRIESHELM, VALKYRIESHELM) || USED_ITEM(player, type, doMsgs, RINGOFTHIEVES, RINGOFTHIEVES) || USED_ITEM(player, type, doMsgs, CRYSTALBALL, CRYSTALBALL)) {
                    SHOW_TEXT(player, type, doMsgs, "You manage to find the marked stone the old thief mentioned. The door is now open.");
                    CLEAR_WALL(player, type, doMsgs, HERE(), FACING());
                    PLACE_WALL_ITEM(player, type, doMsgs, DOOR, HERE(), FACING());
                }
                else {
                    SHOW_TEXT(player, type, doMsgs, "The stone must be here somewhere.");
                    SHOW_TEXT(player, type, doMsgs, "Perhaps you are not skilled enough.");
                    WallBlock(player, type, doMsgs);
                }
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "Something seems out of place here, but you can't tell what.");
                WallBlock(player, type, doMsgs);
            }
        }
        protected override void FnEvent09(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, DUNGEON, HINTEDATDOOR) == 1) {
                SHOW_TEXT(player, type, doMsgs, "The old thief has slipped away into the shadows.");
            }
            else {
                SHOW_PICTURE(player, type, doMsgs, HUMANTHIEF);
                SHOW_TEXT(player, type, doMsgs, "An old thief stands to greet you.");
                SHOW_TEXT(player, type, doMsgs, "'Hail! You seem a bit puzzled and a lot lost.");
                SHOW_TEXT(player, type, doMsgs, "There's a wall to the southeast of here.");
                SHOW_TEXT(player, type, doMsgs, "There you'll find a stone that is marked with an ancient rune. Try detecting it to continue your way.'");
                SET_FLAG(player, type, doMsgs, DUNGEON, HINTEDATDOOR, 1);
            }
        }
        protected override void FnEvent0A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "The final problem!");
            SHOW_TEXT(player, type, doMsgs, "There are short and long pathways to the Queen's chambers.");
            SHOW_TEXT(player, type, doMsgs, "Each has its own reward. Only one need be solved to continue, but the more explored, the greater the rewards.");
        }
        protected override void FnEvent0B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_RUNES(player, type, doMsgs, "The Queen's Hall of Records.");
        }
        protected override void FnEvent0C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_RUNES(player, type, doMsgs, "Studies on Nature and Science.");
        }
        protected override void FnEvent0D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_RUNES(player, type, doMsgs, "Classical.");
        }
        protected override void FnEvent0E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_RUNES(player, type, doMsgs, "Irrelevant.");
        }
        protected override void FnEvent0F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            switch (HERE()) {
                case 49:
                    if (FACING() == NORTH) {
                        FlipStr(player, type, doMsgs);
                    }
                    break;
                case 50:
                    if (FACING() == SOUTH) {
                        SHOW_RUNES(player, type, doMsgs, "This book is entitled -CHESS-. It mentions how one space on a board belongs to whatever piece lands on it and captures it.");
                    }
                    break;
                case 34:
                    if (FACING() == SOUTH) {
                        SHOW_RUNES(player, type, doMsgs, "Another CHESS book- Bishop then Knight then Rook is how you march to face the King.");
                    }
                    break;
                case 33:
                    if (FACING() == NORTH) {
                        FlipStr(player, type, doMsgs);
                    }
                    break;
                case 17:
                    if (FACING() == SOUTH) {
                        SHOW_RUNES(player, type, doMsgs, "CHESS III- Changing from one piece to the next is the key to understanding the mastery of any arena.");
                    }
                    break;
                case 18:
                    if (FACING() == NORTH) {
                        FlipStr(player, type, doMsgs);
                    }
                    break;
            }
        }
        private void FlipStr(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You pull a large volume from the shelf and flip randomly through the pages.");
        }
        protected override void FnEvent10(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Guttural curses and howls of agony from a battlefield to the east chill your bones.");
        }
        protected override void FnEvent11(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (!GET_FLAG(player, type, doMsgs, DUNGEON, DIDFIREBALL)) {
                if (USED_ITEM(player, type, doMsgs, FLAMETONGUE, FLAMETONGUE) || USED_ITEM(player, type, doMsgs, FLAMEBLADE, FLAMEBLADE) || USED_ITEM(player, type, doMsgs, WRATHOFFAITH, WRATHOFFAITH) || USED_ITEM(player, type, doMsgs, STAFFOFJUSTICE, STAFFOFJUSTICE) || USED_ITEM(player, type, doMsgs, BOWOFFLAMES, BOWOFFLAMES) || USED_ITEM(player, type, doMsgs, AEGISDDRACO, AEGISDDRACO) || USED_ITEM(player, type, doMsgs, NEROSLYRE, NEROSLYRE) || USED_ITEM(player, type, doMsgs, SCROLLOFTHESUN, SCROLLOFTHESUN) || USED_ITEM(player, type, doMsgs, SCORCHEDSCROLL, SCORCHEDSCROLL)) {
                    switch (HERE()) {
                        case 9:
                            SHOW_TEXT(player, type, doMsgs, "The fireball travels down the corridor and fizzles.");
                            break;
                        case 24:
                            SHOW_TEXT(player, type, doMsgs, "You launch a fireball across the chasm.");
                            SHOW_TEXT(player, type, doMsgs, "In seconds it turns back upon you!");
                            DAMAGE(player, type, doMsgs, HEALTH(),  / , 6);
                            break;
                        case 25:
                            SHOW_TEXT(player, type, doMsgs, "The fireball flies over the chasm into darkness.");
                            SHOW_TEXT(player, type, doMsgs, "It then comes hurtling back at you, exploding before you can escape its wrath.");
                            DAMAGE(player, type, doMsgs, MAX_HEALTH(),  / , 8);
                            break;
                        case 41:
                            SHOW_TEXT(player, type, doMsgs, "You send a fireball hurtling across the chasm.");
                            SHOW_TEXT(player, type, doMsgs, "The booming report of an explosion alerts you that some trigger has been switched.");
                            SHOW_TEXT(player, type, doMsgs, "A bridge extends out from this edge of the chasm, allowing you to proceed.");
                            SET_FLAG(player, type, doMsgs, DUNGEON, DIDFIREBALL, 1);
                            CLEAR_FLOOR(player, type, doMsgs, 42);
                            PLACE_FLOOR_ITEM(player, type, doMsgs, 0, 42);
                            break;
                    }
                }
                else {
                    SHOW_TEXT(player, type, doMsgs, "The walls and floors here are scorched and charred with magical fire.");
                    SHOW_TEXT(player, type, doMsgs, "Perhaps you can send some light across the chasm to see if any burning clues are visible.");
                }
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "The bridge you triggered earlier has now vanished.");
                SET_FLAG(player, type, doMsgs, DUNGEON, DIDFIREBALL, 0);
                PLACE_FLOOR_ITEM(player, type, doMsgs, 1, 42);
            }
        }
        protected override void FnEvent12(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "'Travel through here at your own risk!' Signed-Lord Gnog.");
        }
        protected override void FnEvent13(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (!GET_FLAG(player, type, doMsgs, ROOM, SPRUNGTRAP)) {
                SHOW_TEXT(player, type, doMsgs, "You set off a poisonous gas trap!");
                SET_PM(player, type, doMsgs, POISON, 8, 70);
                SprungTrap(player, type, doMsgs);
            }
        }
        protected override void FnEvent14(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (!GET_FLAG(player, type, doMsgs, ROOM, SPRUNGTRAP)) {
                SHOW_TEXT(player, type, doMsgs, "Another trap is triggered, sending death darts tipped with poison showering down upon you.");
                SET_PM(player, type, doMsgs, POISON, 5, 60);
                DAMAGE(player, type, doMsgs, HEALTH(),  / , 6);
                SprungTrap(player, type, doMsgs);
            }
        }
        private void SprungTrap(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SET_FLAG(player, type, doMsgs, ROOM, SPRUNGTRAP, 1);
        }
        protected override void FnEvent16(TwPlayerServer player, MapEventType type, bool doMsgs) {
            NO_MAPS();
            SHOW_TEXT(player, type, doMsgs, "You are unable to map this area.");
        }
        protected override void FnEvent17(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You could have sworn there was a door here a second ago.");
            WallBlock(player, type, doMsgs);
            REMOVE_WALL_ITEM(player, type, doMsgs, HERE(), FACING());
        }
        protected override void FnEvent18(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (!GET_FLAG(player, type, doMsgs, ROOM, SPRUNGTRAP)) {
                switch (FACING()) {
                    case NORTH:
                        ROTATE(player, type, doMsgs, WEST);
                        SprungTrap(player, type, doMsgs);
                        break;
                    case SOUTH:
                        ROTATE(player, type, doMsgs, EAST);
                        SprungTrap(player, type, doMsgs);
                        break;
                    case EAST:
                        ROTATE(player, type, doMsgs, SOUTH);
                        SprungTrap(player, type, doMsgs);
                        break;
                    case WEST:
                        ROTATE(player, type, doMsgs, EAST);
                        SprungTrap(player, type, doMsgs);
                        break;
                }
            }
        }
        protected override void FnEvent19(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (!GET_FLAG(player, type, doMsgs, ROOM, SPRUNGTRAP)) {
                switch (FACING()) {
                    case NORTH:
                        ROTATE(player, type, doMsgs, SOUTH);
                        SprungTrap(player, type, doMsgs);
                        break;
                    case SOUTH:
                        ROTATE(player, type, doMsgs, WEST);
                        SprungTrap(player, type, doMsgs);
                        break;
                    case EAST:
                        ROTATE(player, type, doMsgs, NORTH);
                        SprungTrap(player, type, doMsgs);
                        break;
                    case WEST:
                        ROTATE(player, type, doMsgs, EAST);
                        SprungTrap(player, type, doMsgs);
                        break;
                }
            }
        }
        protected override void FnEvent1A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "'Hail, Queen Aeowyn! All would-be champions, approach and report.'");
        }
        protected override void FnEvent1B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "The air is thick with the stench of battle and death. This Arena overflows with those who would be the Queen's champions.");
        }
        protected override void FnEvent1C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "An enormous Barbarian stands over his most recent kill. He turns and charges at you!");
            GET_MONSTER(player, type, doMsgs, 01, 35);
        }
        protected override void FnEvent1D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "An ominous Wizard admires the fallen hero he just incinerated. He then fires a barrage of fireballs at you!");
            DAMAGE(player, type, doMsgs, HEALTH(),  / , 6);
            GET_MONSTER(player, type, doMsgs, 01, 36);
        }
        protected override void FnEvent1E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short i;
            if (!GET_FLAG(player, type, doMsgs, PARTY, QUEENGUARD)) {
                SHOW_PICTURE(player, type, doMsgs, DWARFKNIGHT);
                SHOW_TEXT(player, type, doMsgs, "One of the Queen's Guards is here. 'No stealing!'");
                SHOW_TEXT(player, type, doMsgs, "I'm sure you'll obey his wish!!");
                SET_FLAG(player, type, doMsgs, PARTY, QUEENGUARD, 1);
            }
            else if (GET_FLAG(player, type, doMsgs, PARTY, QUEENGUARD) == 1) {
                SHOW_PICTURE(player, type, doMsgs, DWARFKNIGHT);
                SHOW_TEXT(player, type, doMsgs, "The Guard is much more agitated. 'Be off with you! I've no kindness towards loitering fools.'");
                SET_FLAG(player, type, doMsgs, PARTY, QUEENGUARD, 2);
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "'ENOUGH! I have had enough of you!'");
                SHOW_TEXT(player, type, doMsgs, "'GUARDS!!!!!'");
                SET_BOOTY(player, type, doMsgs, LONGSWORD, CROSSBOW, ELIXIROFHEALTH, 0, 0, 0);
                for (i = 1; i <= 6; i++) {
                    GET_MONSTER(player, type, doMsgs, i, 40);
                }
                SET_FLAG(player, type, doMsgs, PARTY, QUEENGUARD, 0);
            }
        }
        protected override void FnEvent1F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "A mob prepares to attack!");
            GET_MONSTER(player, type, doMsgs, 01, 10);
            GET_MONSTER(player, type, doMsgs, 02, 11);
            GET_MONSTER(player, type, doMsgs, 03, 20);
            GET_MONSTER(player, type, doMsgs, 04, 17);
            GET_MONSTER(player, type, doMsgs, 05, 33);
            GET_MONSTER(player, type, doMsgs, 06, 33);
        }
        protected override void FnEvent20(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Young warriors leap at you!");
            GET_MONSTER(player, type, doMsgs, 01, 31);
            GET_MONSTER(player, type, doMsgs, 02, 32);
            GET_MONSTER(player, type, doMsgs, 03, 31);
            GET_MONSTER(player, type, doMsgs, 04, 32);
        }
        protected override void FnEvent21(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "A seasoned party launches an offensive!");
            GET_MONSTER(player, type, doMsgs, 01, 25);
            GET_MONSTER(player, type, doMsgs, 02, 26);
            GET_MONSTER(player, type, doMsgs, 03, 27);
            GET_MONSTER(player, type, doMsgs, 04, 28);
            GET_MONSTER(player, type, doMsgs, 05, 29);
            GET_MONSTER(player, type, doMsgs, 06, 30);
        }
        protected override void FnEvent22(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, DWARFKNIGHT);
            SHOW_TEXT(player, type, doMsgs, "This place offers a vantage point of the entire combat field.");
            SHOW_TEXT(player, type, doMsgs, "The Master of Arms grins broadly as you enter.");
            SHOW_TEXT(player, type, doMsgs, "'Here, look, see that? A wizard taking on a warrior!");
            SHOW_TEXT(player, type, doMsgs, "If that knight were better trained, he'd have known not to challenge while his sword was in its sheath!'");
        }
        protected override void FnEvent23(TwPlayerServer player, MapEventType type, bool doMsgs) {
            NO_MAPS();
            SHOW_TEXT(player, type, doMsgs, "The thieves who inhabit this area spring upon you!");
            GET_MONSTER(player, type, doMsgs, 01, 32);
            GET_MONSTER(player, type, doMsgs, 02, 32);
            GET_MONSTER(player, type, doMsgs, 03, 28);
            GET_MONSTER(player, type, doMsgs, 04, 28);
        }
        protected override void FnEvent24(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short i;
            if (GET_FLAG(player, type, doMsgs, PARTY, MONSTERA) == 0) {
                SHOW_TEXT(player, type, doMsgs, "Vicious beasts snarl at you.");
                if (PARTY_COUNT() < 3) {
                    for (i = 1; i <= 2; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 39);
                    }
                }
                else {
                    for (i = 1; i <= 5; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 39);
                    }
                }
                SET_FLAG(player, type, doMsgs, PARTY, MONSTERA, 1);
            }
            else if (GET_FLAG(player, type, doMsgs, PARTY, MONSTERA) == 1) {
                SHOW_TEXT(player, type, doMsgs, "Some passing adventurers notice the slain beasts here. They then challenge you to combat.");
                SET_BOOTY(player, type, doMsgs, IRONCUTLASS, HEALPOTION, 0, 0, 0, 250);
                for (i = 1; i <= 4; i++) {
                    GET_MONSTER(player, type, doMsgs, i, 36);
                }
                SET_FLAG(player, type, doMsgs, PARTY, MONSTERA, 2);
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "Corpses stripped of all possessions litter this area.");
                SET_FLAG(player, type, doMsgs, PARTY, MONSTERA, 0);
            }
        }
        protected override void FnEvent25(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short i;
            if (GET_FLAG(player, type, doMsgs, PARTY, MONSTERB) == 0) {
                SHOW_TEXT(player, type, doMsgs, "Vicious panthers growl as you approach.");
                for (i = 1; i <= 4; i++) {
                    GET_MONSTER(player, type, doMsgs, i, 38);
                }
                SET_FLAG(player, type, doMsgs, PARTY, MONSTERB, 1);
            }
            else if (GET_FLAG(player, type, doMsgs, PARTY, MONSTERB) == 1) {
                SHOW_TEXT(player, type, doMsgs, "Oozing slime coats the carcasses on the floor. The slime rears up as you approach!");
                for (i = 1; i <= 4; i++) {
                    GET_MONSTER(player, type, doMsgs, i, 37);
                }
                SET_FLAG(player, type, doMsgs, PARTY, MONSTERB, 2);
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "A slick, viscous fluid covers the area.");
                SET_FLAG(player, type, doMsgs, PARTY, MONSTERB, 0);
            }
        }
        protected override void FnEvent26(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, TROLLCLERIC);
            SHOW_TEXT(player, type, doMsgs, "'These walls are trickery. You need advice from one wiser than I. Beware of the dark dungeon rooms, for they are impossible to map!!'");
        }
        protected override void FnEvent27(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, FOUNTAIN);
            short timesused;
            timesused = 0;
            if (GET_FLAG(player, type, doMsgs, PARTY, HEALFOUNTAIN) < 3) {
                timesused = GET_FLAG(player, type, doMsgs, PARTY, MANAFOUNTAIN);
                SHOW_TEXT(player, type, doMsgs, "The magic of the cool waters heals your wounds.");
                HEAL(player, type, doMsgs, MAX_HEALTH());
                timesused++;
                SET_FLAG(player, type, doMsgs, PARTY, HEALFOUNTAIN, timesused);
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "The waters offer no refreshment.");
            }
        }
        protected override void FnEvent28(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, FOUNTAIN);
            short timesused;
            timesused = 0;
            if (GET_FLAG(player, type, doMsgs, PARTY, MANAFOUNTAIN) < 3) {
                timesused = GET_FLAG(player, type, doMsgs, PARTY, MANAFOUNTAIN);
                SHOW_TEXT(player, type, doMsgs, "The magic of the cool waters restores your mana.");
                MOD_MANA(player, type, doMsgs, 1000);
                timesused++;
                SET_FLAG(player, type, doMsgs, PARTY, MANAFOUNTAIN, timesused);
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "The waters offer no refreshment.");
            }
        }
        protected override void FnEvent29(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, GNOMEBARBARIAN);
            SHOW_TEXT(player, type, doMsgs, "--Lord Galabryan III--");
        }
        protected override void FnEvent2A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, DWARFKNIGHT);
            SHOW_TEXT(player, type, doMsgs, "--King Leowyn--");
        }
        protected override void FnEvent2B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, HUMANBARBARIAN);
            SHOW_TEXT(player, type, doMsgs, "--King Theowayen--");
        }
        protected override void FnEvent2C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, DWARFKNIGHT);
            SHOW_TEXT(player, type, doMsgs, "--King Cleowyn--");
        }
        protected override void FnEvent2D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, HUMANWIZARD);
            SHOW_TEXT(player, type, doMsgs, "--Arnakkian Slowfoot--");
        }
        protected override void FnEvent2E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, DUNGEON, FINISHEDGAME) == 1) {
                SHOW_PICTURE(player, type, doMsgs, QUEENAEOWYN);
                SHOW_TEXT(player, type, doMsgs, "  --Queen Aeowyn--");
                SHOW_TEXT(player, type, doMsgs, "--recently deceased--");
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "  Reserved for:");
                SHOW_TEXT(player, type, doMsgs, "--Queen Aeowyn--");
            }
        }
        protected override void FnEvent2F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Through here is the Corridor of Ancestry.");
            SHOW_TEXT(player, type, doMsgs, "The Queen's heritage shall not be forgotten.");
        }
        protected override void FnEvent34(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, DUNGEON, DONEPROVING) == 2) {
                SHOW_TEXT(player, type, doMsgs, "The waters become calm, allowing you to pass.");
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "A mystical force prevents you from moving freely, and sends you back to the floor.");
                TELEPORT(player, type, doMsgs, 3, 2, 142, EAST);
            }
        }
        protected override void FnEvent35(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You are confused and disoriented in this pitch black room.  The torchlight is diffused by some murky smoke.");
            SHOW_TEXT(player, type, doMsgs, "You are unable to map this area.");
            NO_MAPS();
        }
        protected override void FnEvent36(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, DUNGEON, DONEPROVING) == 2) {
                SHOW_TEXT(player, type, doMsgs, "This portal will take you to the main entrance.");
                if (HAS_ITEM(player, type, doMsgs, QUEENSKEY) || GET_FLAG(player, type, doMsgs, DUNGEON, DEEPPORTALS)) {
                    TELEPORT(player, type, doMsgs, 1, 1, 204, EAST);
                }
                else {
                    SHOW_TEXT(player, type, doMsgs, "In a glass case by the door is the key promised you by the Queen.");
                    GIVE_ITEM(player, type, doMsgs, QUEENSKEY);
                    TELEPORT(player, type, doMsgs, 1, 1, 204, EAST);
                }
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "Away! You cannot use this teleport!");
            }
        }
        protected override void FnEvent37(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, DUNGEON, ENDGAMETELE) == 1) {
                if (PARTY_COUNT() == 1) {
                    SHOW_TEXT(player, type, doMsgs, "You may proceed.");
                    TELEPORT(player, type, doMsgs, 3, 2, 189, EAST);
                }
            }
        }
        protected override void FnEvent38(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT() == 1) {
                SHOW_TEXT(player, type, doMsgs, "Onward you go to the next teleport.");
                TELEPORT(player, type, doMsgs, 4, 3, 0, SOUTH);
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "ALONE! ONLY ALONE MAY YOU PROCEED!!!");
                DAMAGE(player, type, doMsgs, MAX_HEALTH(),  / , 2);
                TELEPORT(player, type, doMsgs, 3, 2, 142, WEST);
            }
        }
        protected override void FnEvent39(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, DUNGEON, DIDFIREBALL) == 1) {
                SHOW_TEXT(player, type, doMsgs, "The trigger has released a drawbridge of sorts, allowing you to pass over the chasm.");
                CLEAR_FLOOR(player, type, doMsgs, 42);
                PLACE_FLOOR_ITEM(player, type, doMsgs, 0, 42);
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "You plummet to your death in the deep chasm.");
                DAMAGE(player, type, doMsgs, MAX_HEALTH());
            }
        }
        protected override void FnEvent3A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (USED_SKILL(player, type, doMsgs, DETECT_SKILL) >= 9 || USED_SPELL(player, type, doMsgs, TRUE_SEEING_SPELL) || USED_ITEM(player, type, doMsgs, HELMOFWISDOM, HELMOFWISDOM) || USED_ITEM(player, type, doMsgs, VALKYRIESHELM, VALKYRIESHELM) || USED_ITEM(player, type, doMsgs, RINGOFTHIEVES, RINGOFTHIEVES) || USED_ITEM(player, type, doMsgs, CRYSTALBALL, CRYSTALBALL)) {
                SHOW_TEXT(player, type, doMsgs, "You discern light seeping through the crack of a secret door!");
                PLACE_WALL_ITEM(player, type, doMsgs, DOOR, HERE(), FACING());
                CLEAR_WALL(player, type, doMsgs, HERE(), FACING());
            }
        }
        protected override void FnEvent3B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short flag = 0;;
            int exps = 0;;
            switch (HERE()) {
                case 94:
                    flag = DIDUPPERRIGHT;
                    exps = 25000;
                    break;
                case 57:
                    flag = DIDMIDDLEUP;
                    exps = 15000;
                    break;
                case 217:
                    flag = DIDMIDDLELOW;
                    exps = 20000;
                    break;
                case 234:
                    flag = DIDLOWERRIGHT;
                    exps = 25000;
                    break;
            }
            if (!GET_FLAG(player, type, doMsgs, DUNGEON, flag)) {
                SHOW_PICTURE(player, type, doMsgs, QUEENAEOWYN);
                TextStr(player, type, doMsgs);
                Queen(player, type, doMsgs);
                GiveWeapon(player, type, doMsgs);
                DoneProving(player, type, doMsgs);
                SET_FLAG(player, type, doMsgs, DUNGEON, flag, 1);
                MOD_EXP(player, type, doMsgs, exps);
            }
        }
        private void TextStr(TwPlayerServer player, MapEventType type, bool doMsgs) {
            switch (HERE()) {
                case 94:
                    SHOW_TEXT(player, type, doMsgs, "You've conquered the chasm, I grant you your reward!");
                    break;
                case 57:
                    SHOW_TEXT(player, type, doMsgs, "Well done! Did you enjoy the Hall of Ancestry!?!");
                    break;
                case 217:
                    SHOW_TEXT(player, type, doMsgs, "Impressive, how you managed to pass through the arena!");
                    break;
                case 234:
                    SHOW_TEXT(player, type, doMsgs, "The Gauntlet you ran was not as hard as some others!");
                    break;
            }
        }
        private void DoneProving(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (!GET_FLAG(player, type, doMsgs, DUNGEON, DONEPROVING)) {
                SET_FLAG(player, type, doMsgs, DUNGEON, DONEPROVING, 1);
            }
        }
        private void Queen(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Now, to my throne room, I will wait for you there!");
        }
        protected override void FnEvent3C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (!GET_FLAG(player, type, doMsgs, DUNGEON, WIZSPELL)) {
                if (GUILD() == WIZARD || GUILD() == THIEF) {
                    GIVE_SPELL(player, type, doMsgs, FIREBALL_SPELL, 1);
                    SHOW_PICTURE(player, type, doMsgs, FOUNTAIN);
                    SHOW_TEXT(player, type, doMsgs, "The steaming fountain's waters offer a powerful source of energy.");
                    SET_FLAG(player, type, doMsgs, DUNGEON, WIZSPELL, 1);
                }
                else {
                    SHOW_PICTURE(player, type, doMsgs, FOUNTAIN);
                    SHOW_TEXT(player, type, doMsgs, "You are scalded by the burning waters.");
                    DAMAGE(player, type, doMsgs, MAX_HEALTH(),  / , 6);
                }
            }
        }
        protected override void FnEvent3D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (!GET_FLAG(player, type, doMsgs, DUNGEON, LORDGNOG)) {
                SHOW_TEXT(player, type, doMsgs, "An elderly wizard sits here, poring over books.");
                SHOW_TEXT(player, type, doMsgs, "'We meet at last. My envoys have told me so much about you.");
                SHOW_TEXT(player, type, doMsgs, "They've helped me keep track of your achievements and failures.");
                SHOW_TEXT(player, type, doMsgs, "Have you enjoyed my traps? Ah, well, some do, some don't.");
                SHOW_TEXT(player, type, doMsgs, "Since you've found me, perhaps you'd like to try for a little revenge.");
                SHOW_TEXT(player, type, doMsgs, "Come! Let's get on with it.'");
                SET_BOOTY(player, type, doMsgs, MANDRAKESTAFF, TRANCETALISMAN, SLIVERBAR, 0, 0, 2000);
            }
            GET_MONSTER(player, type, doMsgs, 01, 34);
        }
        protected override void FnEvent3E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (!GET_FLAG(player, type, doMsgs, DUNGEON, LORDGNOG)) {
                SET_FLAG(player, type, doMsgs, DUNGEON, LORDGNOG, 1);
            }
        }
        protected override void FnEvent3F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "To the entrance of the palace.");
            TELEPORT(player, type, doMsgs, 3, 2, 128, EAST);
        }
    }
}
