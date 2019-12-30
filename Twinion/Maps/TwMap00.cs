using XPT.Generic.Maps;
using XPT.Twinion.Entities;

namespace XPT.Twinion.Maps {
    class TwMap00 : TwMap {
        protected override int MapIndex => 0;
        protected override int MapID => 0x0101;
        protected override int RandomEncounterChance => 0;
        protected override int RandomEncounterExtraCount => 0;

        protected override void FnEvent01(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "This Gateway leads out of the Dungeon.");
            EXIT_DUNGEON();
        }
        protected override void FnEvent02(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "The door is marked: 'To Gauntlet Gauche.'");
            TELEPORT(player, type, doMsgs, 1, 2, 127, WEST);
        }
        protected override void FnEvent03(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Herein lies Gauntlet Droit.");
            TELEPORT(player, type, doMsgs, 1, 3, 80, EAST);
        }
        protected override void FnEvent04(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "To the first level of Her Majesty's proving grounds...The Queen's Aqueduct.");
            TELEPORT(player, type, doMsgs, 2, 1, 248, NORTH);
        }
        protected override void FnEvent05(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Enter the Kingdom of the Night Elves... ");
            SHOW_TEXT(player, type, doMsgs, "               ....and beware.");
            TELEPORT(player, type, doMsgs, 4, 1, 240, NORTH);
        }
        protected override void FnEvent06(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Here you enter the Dralkarians' Lair.");
            TELEPORT(player, type, doMsgs, 8, 1, 112, EAST);
        }
        protected override void FnEvent07(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((PARTY_LEVEL(player, type, doMsgs, 12)) && (PARTY_COUNT() == 1)) {
                if (GET_FLAG(player, type, doMsgs, DUNGEON, DEEPPORTALS) == 1) {
                    FindStr(player, type, doMsgs);
                }
                else if (USED_ITEM(player, type, doMsgs, QUEENSKEY, QUEENSKEY)) {
                    SHOW_TEXT(player, type, doMsgs, "As you unlock the door with Her Majesty's key, the lock on the door as well as the key vanish!");
                    SHOW_TEXT(player, type, doMsgs, "Now the door will remain unlocked.");
                    SET_FLAG(player, type, doMsgs, DUNGEON, DEEPPORTALS, 1);
                    TAKE_ITEM(player, type, doMsgs, QUEENSKEY);
                    TAKE_ITEM(player, type, doMsgs, ROPE);
                    FindStr(player, type, doMsgs);
                }
                else {
                    SHOW_TEXT(player, type, doMsgs, "The Queen's key is needed to unlock this door.");
                    BLOCK_WALL(player, type, doMsgs, HERE(), FACING());
                }
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "Only more experienced heroes may venture beyond this gateway. And even then, you must enter alone!");
                BLOCK_WALL(player, type, doMsgs, HERE(), FACING());
            }
        }
        private void FindStr(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Find your fate in the portal east of here.");
            CLEAR_WALL(player, type, doMsgs, HERE(), EAST);
        }
        protected override void FnEvent08(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_LEVEL(player, type, doMsgs, 23)) {
                if (PARTY_COUNT() == 1) {
                    if (GET_FLAG(player, type, doMsgs, DUNGEON, DRAKSPORT) == 1 || GET_FLAG(player, type, doMsgs, DUNGEON, DRAKSPORT) == 2) {
                        NorthStr(player, type, doMsgs);
                    }
                    else if (!GET_FLAG(player, type, doMsgs, DUNGEON, DRAKSPORT) && HAS_ITEM(player, type, doMsgs, WHOLEMAP)) {
                        SHOW_TEXT(player, type, doMsgs, "Your map begins to glow with an eerie green light. The light then fades to red followed by blue and finally brilliant yellow.");
                        SHOW_TEXT(player, type, doMsgs, "The magical light of this most curious map dispels the door's magic!");
                        SHOW_TEXT(player, type, doMsgs, "The map, drained of its powers, crumbles into the nothingness from which it came.");
                        SET_FLAG(player, type, doMsgs, DUNGEON, DRAKSPORT, 1);
                        TAKE_ITEM(player, type, doMsgs, WHOLEMAP);
                        NorthStr(player, type, doMsgs);
                    }
                    else {
                        GenericStr(player, type, doMsgs);
                    }
                }
                else {
                    SHOW_TEXT(player, type, doMsgs, "You must journey northward alone!");
                    BLOCK_WALL(player, type, doMsgs, HERE(), FACING());
                }
            }
            else {
                GenericStr(player, type, doMsgs);
            }
        }
        private void GenericStr(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Destiny awaits. It will be here for you when you are ready.");
            BLOCK_WALL(player, type, doMsgs, HERE(), FACING());
        }
        private void NorthStr(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Northward lies the passage of Fate.");
            CLEAR_WALL(player, type, doMsgs, HERE(), FACING());
            PLACE_WALL_ITEM(player, type, doMsgs, DOOR, HERE(), FACING());
        }
        protected override void FnEvent09(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HAS_ITEM(player, type, doMsgs, JESTERSCAP) && !GET_FLAG(player, type, doMsgs, DUNGEON, CHOR_NPC_KILLED) & CHORONZAR_KILLED_BIT) {
                SHOW_TEXT(player, type, doMsgs, "A maniacal fiend appears; removes an item you stole from him; and kills you outright.");
                while HAS_ITEM(player, type, doMsgs, JESTERSCAP)TAKE_ITEM(player, type, doMsgs, JESTERSCAP);
                MOD_GOLD(player, type, doMsgs,  - 10000);
                DAMAGE(player, type, doMsgs, MAX_HEALTH());
                EXIT_DUNGEON();
            }
        }
        protected override void FnEvent0A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            CLEAR_WALL(player, type, doMsgs, HERE(), FACING());
            SHOW_TEXT(player, type, doMsgs, "Welcome, brave Champions. To the west lies Gauntlet Gauche: one of the two maps that interweave a simple quest.");
            SHOW_TEXT(player, type, doMsgs, "Eastward lies Gauntlet Droit. There you will find challenges and helpful friends to start you on your way.");
            SHOW_TEXT(player, type, doMsgs, "These two maps comprise the Gauntlet... A simple quest that you'd be wise to undertake before all else.");
        }
        protected override void FnEvent0B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            CLEAR_WALL(player, type, doMsgs, HERE(), FACING());
            SHOW_TEXT(player, type, doMsgs, "Northward is the entrance to the Queen's Proving Grounds. You begin there in Her Majesty's Aqueduct.");
            SHOW_TEXT(player, type, doMsgs, "That will start your ascent to greater challenges. Fare well wherever you fare.");
        }
        protected override void FnEvent0C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            NO_JOIN();
        }
        protected override void FnEvent0D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            NO_SPELL();
            if (PARTY_LEVEL(player, type, doMsgs, 23)) {
                if (GET_FLAG(player, type, doMsgs, DUNGEON, DRAKSPORT) == 1) {
                    SHOW_PICTURE(player, type, doMsgs, QUEENAEOWYN);
                    SHOW_TEXT(player, type, doMsgs, "The Queen is here:");
                    SHOW_TEXT(player, type, doMsgs, "'Loyal Champions! A magnificent achievement!");
                    SHOW_TEXT(player, type, doMsgs, "Now, as to the markings here at this secret entrance...");
                    SHOW_TEXT(player, type, doMsgs, "This will take you into the lowest depths!");
                    SHOW_TEXT(player, type, doMsgs, "Together, we will breach the gates of time and march into a new world of wonders! But only together.");
                    SHOW_TEXT(player, type, doMsgs, "Each of the vile deities whom the Night Elves worship wears a magical ring. You must get each ring from its owner!");
                    SHOW_TEXT(player, type, doMsgs, "Together, the rings are the keys that will allow us to enter the Portal of Time. And then, loyal Champions, I know not where we shall step through into Immortality.");
                    SHOW_TEXT(player, type, doMsgs, "Go, now! I shall be with thee! I will come to thee when I can. Fare thee well!'");
                    SET_FLAG(player, type, doMsgs, DUNGEON, DRAKSPORT, 2);
                }
                else if (!GET_FLAG(player, type, doMsgs, DUNGEON, FINISHEDGAME)) {
                    SHOW_TEXT(player, type, doMsgs, "Let us not dally...northward, onward to destiny.");
                }
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "Your experience is not suited for the horrors through here. Seek thee more knowledge then return.");
                TELEPORT(player, type, doMsgs, 1, 1, 206, SOUTH);
            }
        }
        protected override void FnEvent0E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            NO_MAPS();
        }
        protected override void FnEvent0F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            NO_JOIN();
            if (!GET_FLAG(player, type, doMsgs, DUNGEON, DEEPPORTALS)) {
                SHOW_TEXT(player, type, doMsgs, "Only more experienced heroes may venture beyond this gateway. And even then, you must have completed the Queen's proving grounds and acquired Her key!");
                TELEPORT(player, type, doMsgs, 1, 1, 200, EAST);
            }
        }
        protected override void FnEvent11(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 1, 1, 88, NORTH);
        }
        protected override void FnEvent12(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((PARTY_COUNT() == 1) && (PARTY_LEVEL(player, type, doMsgs, 35))) {
                if ((GET_FLAG(player, type, doMsgs, DUNGEON, ENDGAMETELE) == 1) || (GET_FLAG(player, type, doMsgs, DUNGEON, ENDGAMETELE) == 2)) {
                    PLACE_WALL_ITEM(player, type, doMsgs, DOOR, HERE(), FACING());
                    SHOW_TEXT(player, type, doMsgs, "A mystic portal appears, granting you an ingress to the chambers of time.");
                    CLEAR_WALL(player, type, doMsgs, HERE(), FACING());
                }
                else {
                    REMOVE_WALL_ITEM(player, type, doMsgs, DOOR, HERE());
                    BLOCK_WALL(player, type, doMsgs, HERE(), FACING());
                }
            }
            else {
                REMOVE_WALL_ITEM(player, type, doMsgs, DOOR, HERE());
                BLOCK_WALL(player, type, doMsgs, HERE(), FACING());
            }
        }
        protected override void FnEvent13(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT() == 1) {
                if ((GET_FLAG(player, type, doMsgs, DUNGEON, ENDGAMETELE) == 1) || (GET_FLAG(player, type, doMsgs, DUNGEON, ENDGAMETELE) == 2)) {
                    SHOW_TEXT(player, type, doMsgs, "Go from here to the depths of time! Enter into the deepest wells of your destiny! This will take you to the start of Dissemination.");
                    TELEPORT(player, type, doMsgs, 12, 1, 255, WEST);
                }
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "You must enter alone!");
                TELEPORT(player, type, doMsgs, 1, 1, 19, NORTH);
            }
        }
        protected override void FnEvent14(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT() == 1) {
                if (FLAG_ON(player, type, doMsgs, DUNGEON, TOTHEQUEEN)) {
                    SHOW_TEXT(player, type, doMsgs, "A portal forms in the wall before you! Iridescent light filters into the room, surrounding you with a vapor of magic.");
                    SHOW_TEXT(player, type, doMsgs, "THIS portal will take you into the final challenge...your Fate is at hand.");
                    TELEPORT(player, type, doMsgs, 12, 2, 255, WEST);
                }
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "In time, this ingress shall grant you passage; but only alone and after you've earned the right, may you proceed.");
                TELEPORT(player, type, doMsgs, 1, 1, 19, NORTH);
            }
        }
    }
}
