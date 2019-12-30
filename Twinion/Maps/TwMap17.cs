using XPT.Generic.Maps;
using XPT.Twinion.Entities;

namespace XPT.Twinion.Maps {
    class TwMap17 : TwMap {
        protected override int MapIndex => 17;
        protected override int MapID => 0x0701;
        protected override int RandomEncounterChance => 12;
        protected override int RandomEncounterExtraCount => 0;

        protected override void FnEvent01(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, DUNGEON, TNEPRES) == 1 || GET_FLAG(player, type, doMsgs, DUNGEON, TNEPRES) == 2) {
                TAKE_ITEM(player, type, doMsgs, TNEPRESKEY);
            }
            else {
                if (HAS_ITEM(player, type, doMsgs, TNEPRESKEY)) {
                    SHOW_PICTURE(player, type, doMsgs, DWARFTHIEF);
                    GIVE_ITEM(player, type, doMsgs, PUMMELSCROLL);
                    SET_FLAG(player, type, doMsgs, DUNGEON, TNEPRES, 1);
                    SHOW_TEXT(player, type, doMsgs, "You meet a watchman.");
                    SHOW_TEXT(player, type, doMsgs, "'Greetings, adventurers! You've found your way to Tipekans.");
                    SHOW_TEXT(player, type, doMsgs, "Our laws require me to take your Tnepres Key. In exchange, however, I will register you for unlimited passage to our town.");
                    SHOW_TEXT(player, type, doMsgs, "As a first time visitor, please accept this welcome scroll.");
                    SHOW_TEXT(player, type, doMsgs, "May your journey be safe and profitable.'");
                    TAKE_ITEM(player, type, doMsgs, TNEPRESKEY);
                }
                else {
                    SHOW_PICTURE(player, type, doMsgs, DWARFTHIEF);
                    switch (HERE()) {
                        case 6:
                            BLOCK_WALL(player, type, doMsgs, HERE(), EAST);
                            break;
                        case 49:
                            BLOCK_WALL(player, type, doMsgs, HERE(), WEST);
                            break;
                    }
                    SHOW_TEXT(player, type, doMsgs, "The thief says, 'You have no key for passage. Return when you have the proper item.");
                    SHOW_TEXT(player, type, doMsgs, "It would certainly be amazing if such as you could find the right item.'");
                }
            }
        }
        protected override void FnEvent02(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, GNOMETHIEF);
            SHOW_TEXT(player, type, doMsgs, "You bump into a young thief.");
            SHOW_TEXT(player, type, doMsgs, "'Tis a far better thing to be understood than to be heard!");
            SHOW_TEXT(player, type, doMsgs, "Confused?  Confounded?  Is there no one who knows a good clue when he hears it?'");
        }
        protected override void FnEvent03(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 7, 1, 212, NORTH);
        }
        protected override void FnEvent04(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Vile creatures rise from the Snake Pit to attack you.");
            if (HAS_ITEM(player, type, doMsgs, HOLLOWEDNUNCHUKAS)) {
                SET_BOOTY(player, type, doMsgs, CUREALLPOTION, SILVERBAR, 0, 0, 0, 2000);
            }
            else {
                SET_BOOTY(player, type, doMsgs, HOLLOWEDNUNCHUKAS, HARMSWAY, 0, 0, 0, 2000);
            }
            if (PARTY_COUNT() == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 39);
                GET_MONSTER(player, type, doMsgs, 02, 5);
            }
            else if (PARTY_COUNT() == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 39);
                GET_MONSTER(player, type, doMsgs, 02, 39);
                GET_MONSTER(player, type, doMsgs, 03, 25);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 39);
                GET_MONSTER(player, type, doMsgs, 02, 39);
                GET_MONSTER(player, type, doMsgs, 03, 25);
                GET_MONSTER(player, type, doMsgs, 04, 25);
                GET_MONSTER(player, type, doMsgs, 05, 5);
                GET_MONSTER(player, type, doMsgs, 06, 5);
            }
        }
        protected override void FnEvent05(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (USED_SKILL(player, type, doMsgs, DETECT_SKILL) >= 6 || USED_SPELL(player, type, doMsgs, TRUE_SEEING_SPELL) || USED_ITEM(player, type, doMsgs, HELMOFWISDOM, HELMOFWISDOM) || USED_ITEM(player, type, doMsgs, VALKYRIESHELM, VALKYRIESHELM) || USED_ITEM(player, type, doMsgs, RINGOFTHIEVES, RINGOFTHIEVES) || USED_ITEM(player, type, doMsgs, CRYSTALBALL, CRYSTALBALL)) {
                SHOW_TEXT(player, type, doMsgs, "You discover a door in the wall.");
                PlaceDoor(player, type, doMsgs);
                WallClear(player, type, doMsgs);
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "You notice strange markings resembling a code on the wall.");
                WallBlock(player, type, doMsgs);
            }
        }
        protected override void FnEvent06(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short i = 0;
            SHOW_TEXT(player, type, doMsgs, "You step into a dark alley.");
            SHOW_TEXT(player, type, doMsgs, "The cold steel of a thief's stiletto in your back cuts your odds of surviving this ambush!");
            DAMAGE(player, type, doMsgs, HEALTH() / 3);
            for (i = 1; i <= 2; i++) {
                GET_MONSTER(player, type, doMsgs, i, 40);
            }
        }
        protected override void FnEvent07(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "To the Ballroom");
            TELEPORT(player, type, doMsgs, 4, 1, 172, SOUTH);
        }
        protected override void FnEvent08(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT() == 1) {
                SHOW_TEXT(player, type, doMsgs, "You may rejoin your party.");
            }
            else {
                TELEPORT(player, type, doMsgs, 7, 1, 59, EAST);
            }
        }
        protected override void FnEvent09(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_STAT(player, type, doMsgs, STRENGTH) >= 19) {
                WallClear(player, type, doMsgs);
                PlaceDoor(player, type, doMsgs);
                SHOW_TEXT(player, type, doMsgs, "The stubborn door finally yields, and you push it open.");
            }
            else {
                WallBlock(player, type, doMsgs);
                SHOW_TEXT(player, type, doMsgs, "You lack the strength to push open the door.");
            }
        }
        protected override void FnEvent0A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "To the Cellar");
            TELEPORT(player, type, doMsgs, 6, 1, 21, NORTH);
        }
        protected override void FnEvent0B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, DUNGEON, ROPE_FLAG) == 1) {
                if (PARTY_COUNT() == 1) {
                    WallClear(player, type, doMsgs);
                    PlaceDoor(player, type, doMsgs);
                    SHOW_TEXT(player, type, doMsgs, "Your clever exchange of lockpicks now offers you a secret entrance into the Ballroom.");
                }
                else {
                    WallBlock(player, type, doMsgs);
                    SHOW_TEXT(player, type, doMsgs, "You must proceed alone through this door.");
                }
            }
            else {
                WallBlock(player, type, doMsgs);
            }
        }
        protected override void FnEvent0C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Fumes momentarily overcome you, leeching away your spellcasting ability.");
            MOD_MANA(player, type, doMsgs,  - 300);
        }
        protected override void FnEvent0D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 7, 1, 245, WEST);
        }
        protected override void FnEvent0E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 7, 1, 113, NORTH);
        }
        protected override void FnEvent0F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 7, 1, 53, NORTH);
        }
        protected override void FnEvent10(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You disturb a sleeping thief.");
            SHOW_TEXT(player, type, doMsgs, "He gets revenge by deftly picking your pocket and fleeing.");
            MOD_GOLD(player, type, doMsgs,  - 1000);
        }
        protected override void FnEvent11(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, GNOMEWIZARD);
            SHOW_TEXT(player, type, doMsgs, "An angry wizard grabs you by the lapel.");
            SHOW_TEXT(player, type, doMsgs, "'I was turned away from the Cartography Shop because I only had three pieces of a map. I must keep searching!'");
        }
        protected override void FnEvent12(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HAS_ITEM(player, type, doMsgs, SAPPHIRELOCKPICK)) {
                WallClear(player, type, doMsgs);
                PlaceDoor(player, type, doMsgs);
                SHOW_TEXT(player, type, doMsgs, "The glow from the Sapphire Lockpick reveals a door.");
            }
            else {
                WallBlock(player, type, doMsgs);
                SHOW_TEXT(player, type, doMsgs, "You see footprints leading to the wall and disappearing, but you have no way through the obviously solid wall.");
            }
        }
        protected override void FnEvent13(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You find a note from a fellow adventurer -");
            SHOW_TEXT(player, type, doMsgs, "'My journey was fruitless because I lacked an Emerald Lockpick.'");
        }
        protected override void FnEvent14(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 7, 1, 234, WEST);
        }
        protected override void FnEvent15(TwPlayerServer player, MapEventType type, bool doMsgs) {
            NO_JOIN();
            SHOW_TEXT(player, type, doMsgs, "You walk through the passage and step confidently onto Tipekans' Bridge.");
            if (PARTY_COUNT() > 1) {
                SHOW_TEXT(player, type, doMsgs, "The bridge collapses under the weight of your party and you plunge to your death.");
                DAMAGE(player, type, doMsgs, MAX_HEALTH());
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "You manage to grab hold of an extending beam as the bridge collapses beneath you. The door here, unfortunately, is sealed forever shut.");
                SHOW_TEXT(player, type, doMsgs, "As you try to swing back across, you lose your grip and hurl downwards into darkness!");
                SHOW_TEXT(player, type, doMsgs, "Some mystical winds grab your body and pull you off into the Cloister!");
                TELEPORT(player, type, doMsgs, 6, 1, 89, SOUTH);
            }
        }
        protected override void FnEvent16(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (USED_ITEM(player, type, doMsgs, DIAMONDLOCKPICK, DIAMONDLOCKPICK)) {
                WallClear(player, type, doMsgs);
                PlaceDoor(player, type, doMsgs);
                SHOW_TEXT(player, type, doMsgs, "You open the door with your Diamond Lockpick.");
            }
            else {
                WallBlock(player, type, doMsgs);
                SHOW_TEXT(player, type, doMsgs, "The locked door has a diamond-shaped keyhole.");
            }
        }
        protected override void FnEvent17(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 7, 1, 57, NORTH);
        }
        protected override void FnEvent18(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, DUNGEON, SNAKESKIN_MAP) == 1) {
                if (HAS_ITEM(player, type, doMsgs, SNAKESKINMAP)) {
                    SHOW_TEXT(player, type, doMsgs, "You find nothing of interest. Your Ruby Lockpick suddenly crumbles into dust.");
                    TAKE_ITEM(player, type, doMsgs, RUBYLOCKPICK);
                }
                else {
                    GIVE_ITEM(player, type, doMsgs, SNAKESKINMAP);
                    SHOW_TEXT(player, type, doMsgs, "You find a map hastily drawn on a piece of snakeskin.");
                    SHOW_TEXT(player, type, doMsgs, "The Snakeskin Map must be one of the four the Queen sent you to find.");
                    SHOW_TEXT(player, type, doMsgs, "Your Ruby Lockpick mysteriously crumbles into dust.");
                    TAKE_ITEM(player, type, doMsgs, RUBYLOCKPICK);
                }
            }
            else {
                GIVE_ITEM(player, type, doMsgs, SNAKESKINMAP);
                GIVE_ITEM(player, type, doMsgs, BARBARIANSHELM);
                GIVE_ITEM(player, type, doMsgs, HELMOFWISDOM);
                GIVE_ITEM(player, type, doMsgs, ZEUSSCROLL);
                MOD_EXP(player, type, doMsgs, 200000);
                SET_FLAG(player, type, doMsgs, DUNGEON, SNAKESKIN_MAP, 1);
                SHOW_TEXT(player, type, doMsgs, "You find a map hastily drawn on a piece of snakeskin.");
                SHOW_TEXT(player, type, doMsgs, "The Snakeskin Map must be one of the four Queen Aeowyn has sent you to find.");
                SHOW_TEXT(player, type, doMsgs, "Your Ruby Lockpick mysteriously crumbles into dust.");
                TAKE_ITEM(player, type, doMsgs, RUBYLOCKPICK);
            }
        }
        protected override void FnEvent19(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "On the floor you find a page from an old journal.");
            SHOW_TEXT(player, type, doMsgs, "It recounts the story of an adventurer who gained great wisdom by discovering a map piece.");
        }
        protected override void FnEvent1A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, DUNGEON, ROPE_FLAG) == 1) {
                if (HAS_ITEM(player, type, doMsgs, ROPE)) {
                    SHOW_TEXT(player, type, doMsgs, "A wandering band of thieves overcomes you. They steal your lockpick.");
                    TAKE_ITEM(player, type, doMsgs, SAPPHIRELOCKPICK);
                }
                else if (HAS_ITEM(player, type, doMsgs, SAPPHIRELOCKPICK)) {
                    GIVE_ITEM(player, type, doMsgs, ROPE);
                    SHOW_TEXT(player, type, doMsgs, "You are attacked by thieves who bind you with rope.");
                    SHOW_TEXT(player, type, doMsgs, "The leader pilfers your lockpick.");
                    SHOW_TEXT(player, type, doMsgs, "You eventually manage to free yourself, and you tuck the rope away.");
                    TAKE_ITEM(player, type, doMsgs, SAPPHIRELOCKPICK);
                }
            }
            else {
                if (HAS_ITEM(player, type, doMsgs, SAPPHIRELOCKPICK)) {
                    TAKE_ITEM(player, type, doMsgs, SAPPHIRELOCKPICK);
                    MOD_EXP(player, type, doMsgs, 50000);
                    SET_FLAG(player, type, doMsgs, DUNGEON, ROPE_FLAG, 1);
                    SHOW_TEXT(player, type, doMsgs, "You are attacked by thieves who bind you with rope.");
                    SHOW_TEXT(player, type, doMsgs, "The leader pilfers your lockpick.");
                    SHOW_TEXT(player, type, doMsgs, "You eventually manage to free yourself, and you tuck the rope away.");
                    GIVE_ITEM(player, type, doMsgs, ROPE);
                }
                else {
                    SHOW_TEXT(player, type, doMsgs, "A wandering band of thieves ignores you since you have nothing of value.");
                }
            }
        }
        protected override void FnEvent1B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 7, 1, 199, EAST);
        }
        protected override void FnEvent1C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, TROLLRANGER);
            if (HAS_ITEM(player, type, doMsgs, DIAMONDLOCKPICK)) {
                GIVE_ITEM(player, type, doMsgs, SAPPHIRELOCKPICK);
                SHOW_TEXT(player, type, doMsgs, "A Troll Ranger drags you into the shadows.");
                SHOW_TEXT(player, type, doMsgs, "'I assume you found the note about the Emerald Lockpick I left by the entrance.");
                SHOW_TEXT(player, type, doMsgs, "Congratulations on your success so far!");
                SHOW_TEXT(player, type, doMsgs, "My reward for helping you is the Diamond Lockpick you possess - or used to possess, anyway.");
                SHOW_TEXT(player, type, doMsgs, "Take this Sapphire Lockpick in exchange. Though less valuable, it has the magical property to help you see things not readily apparent to the eye.'");
                TAKE_ITEM(player, type, doMsgs, DIAMONDLOCKPICK);
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "A Troll Ranger twirls a sparkling blue lockpick.");
                SHOW_TEXT(player, type, doMsgs, "'I left a note by the entrance. It concerns an Emerald Lockpick.");
                SHOW_TEXT(player, type, doMsgs, "Heed its warning well, and you will be well rewarded.'");
            }
        }
        protected override void FnEvent1D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "In the distance you hear the wail of a madman -");
            SHOW_TEXT(player, type, doMsgs, "'Hither and yonder I have searched! Nowhere, nowhere could I find that lovely little map writ large upon a parchment!'");
        }
        protected override void FnEvent1E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 7, 1, 28, NORTH);
        }
        protected override void FnEvent1F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 7, 1, 151, EAST);
        }
        protected override void FnEvent20(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, GREMLINCLERIC);
            if ((HAS_ITEM(player, type, doMsgs, EMERALDLOCKPICK)) && (GET_FLAG(player, type, doMsgs, DUNGEON, TNEPRES) == 1 || GET_FLAG(player, type, doMsgs, DUNGEON, TNEPRES) == 2)) {
                GIVE_ITEM(player, type, doMsgs, DIAMONDLOCKPICK);
                SHOW_TEXT(player, type, doMsgs, "A Gremlin Cleric slaps you resoundingly on the back.");
                SHOW_TEXT(player, type, doMsgs, "'Well done! You've found my lost Emerald Lockpick.");
                SHOW_TEXT(player, type, doMsgs, "I can't thank you enough for helping me!");
                SHOW_TEXT(player, type, doMsgs, "Please accept this Diamond Lockpick for your troubles.'");
                TAKE_ITEM(player, type, doMsgs, EMERALDLOCKPICK);
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "A Gremlin Cleric is searching in the dust.");
                SHOW_TEXT(player, type, doMsgs, "'I lost my beautiful Emerald Lockpick.");
                SHOW_TEXT(player, type, doMsgs, "If you retrieve it, I will reward you most handsomely.");
                SHOW_TEXT(player, type, doMsgs, "Remember, however, that you must be a registered visitor to Tipekans.'");
            }
        }
        protected override void FnEvent21(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, HALFLINGKNIGHT);
            SHOW_TEXT(player, type, doMsgs, "An exasperated Halfling waves a piece of leather.");
            SHOW_TEXT(player, type, doMsgs, "'The Races! What an aptly named place it was, since only certain races can enter certain rooms.");
            SHOW_TEXT(player, type, doMsgs, "I wish I had discovered that fact sooner. But, eventually, I did find the two doors for my race.'");
        }
        protected override void FnEvent22(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, DUNGEON, TNEPRES) == 0) {
                WallBlock(player, type, doMsgs);
            }
        }
        protected override void FnEvent23(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You overhear two thieves talking about how clever Sneer, Smug and Smirk are in preventing bothersome adventurers from gaining access into the center of Tipekans.");
        }
        protected override void FnEvent24(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, DWARFKNIGHT);
            SHOW_TEXT(player, type, doMsgs, "A Dwarf Knight walks up to you. He rubs his head.");
            SHOW_TEXT(player, type, doMsgs, "'I'm looking for a temple to take care of this wound!");
            SHOW_TEXT(player, type, doMsgs, "My journey has taken me to a strange place. Not one wall did I see, yet I could not advance. It was pure pandemonium.'");
        }
        protected override void FnEvent25(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, DUNGEON, TNEPRES) == 1) {
                GIVE_ITEM(player, type, doMsgs, PLATINUMBAR);
                GIVE_ITEM(player, type, doMsgs, THIEVESFLUTE);
                GIVE_ITEM(player, type, doMsgs, HEALAMPHORA);
                SET_FLAG(player, type, doMsgs, DUNGEON, TNEPRES, 2);
                SHOW_TEXT(player, type, doMsgs, "You find a secret hiding place in which the thieves of Tipekans store their ill-gotten goods.");
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "What used to be a hiding place for stolen loot is now empty.");
            }
        }
        protected override void FnEvent26(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 7, 1, 125, NORTH);
        }
        protected override void FnEvent27(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, FOUNTAIN);
            HEAL(player, type, doMsgs, MAX_HEALTH());
            MOD_MANA(player, type, doMsgs, 10000);
            SHOW_TEXT(player, type, doMsgs, "The cascading waters of Viper Fountain heal your wounds and restore your mana.");
        }
        protected override void FnEvent28(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You stumble upon a weird assortment of scavengers.");
            if (HAS_ITEM(player, type, doMsgs, SCROLLOFDEATH)) {
                SET_BOOTY(player, type, doMsgs, CRYSTALSCROLL, LEATHERJACKET, 0, 0, 0, 1000);
            }
            else {
                SET_BOOTY(player, type, doMsgs, SCROLLOFDEATH, LEATHERJACKET, 0, 0, 0, 2500);
            }
            if (PARTY_COUNT() == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 33);
                GET_MONSTER(player, type, doMsgs, 02, 34);
            }
            else if (PARTY_COUNT() == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 33);
                GET_MONSTER(player, type, doMsgs, 02, 34);
                GET_MONSTER(player, type, doMsgs, 03, 5);
                GET_MONSTER(player, type, doMsgs, 04, 24);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 33);
                GET_MONSTER(player, type, doMsgs, 02, 33);
                GET_MONSTER(player, type, doMsgs, 03, 4);
                GET_MONSTER(player, type, doMsgs, 04, 39);
                GET_MONSTER(player, type, doMsgs, 05, 30);
                GET_MONSTER(player, type, doMsgs, 06, 31);
            }
        }
        protected override void FnEvent29(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, WRAITH);
            SHOW_TEXT(player, type, doMsgs, "You surprise a wraith who seems to be dancing.");
            SHOW_TEXT(player, type, doMsgs, "'Oh! You startled me. I was just recalling the wondrous sounds of music that used to fill these corridors.");
            SHOW_TEXT(player, type, doMsgs, "I was sure there was a door somewhere along here to the Ballroom.'");
        }
        protected override void FnEvent2A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "A flash of steel is quickly doused as you near a shadowy alley.");
        }
        protected override void FnEvent2B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT() == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 16);
                GET_MONSTER(player, type, doMsgs, 02, 18);
            }
            else if (PARTY_COUNT() == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 16);
                GET_MONSTER(player, type, doMsgs, 02, 15);
                GET_MONSTER(player, type, doMsgs, 03, 19);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 16);
                GET_MONSTER(player, type, doMsgs, 02, 16);
                GET_MONSTER(player, type, doMsgs, 03, 19);
                GET_MONSTER(player, type, doMsgs, 04, 35);
                GET_MONSTER(player, type, doMsgs, 05, 37);
            }
        }
        protected override void FnEvent2C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT() == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 9);
                GET_MONSTER(player, type, doMsgs, 02, 7);
            }
            else if (PARTY_COUNT() == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 7);
                GET_MONSTER(player, type, doMsgs, 02, 23);
                GET_MONSTER(player, type, doMsgs, 05, 9);
                GET_MONSTER(player, type, doMsgs, 06, 11);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 29);
                GET_MONSTER(player, type, doMsgs, 02, 29);
                GET_MONSTER(player, type, doMsgs, 04, 32);
                GET_MONSTER(player, type, doMsgs, 06, 32);
            }
        }
        protected override void FnEvent2D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT() == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 26);
                GET_MONSTER(player, type, doMsgs, 02, 28);
            }
            else if (PARTY_COUNT() == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 28);
                GET_MONSTER(player, type, doMsgs, 02, 28);
                GET_MONSTER(player, type, doMsgs, 05, 26);
                GET_MONSTER(player, type, doMsgs, 06, 26);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 28);
                GET_MONSTER(player, type, doMsgs, 02, 28);
                GET_MONSTER(player, type, doMsgs, 03, 5);
                GET_MONSTER(player, type, doMsgs, 04, 5);
                GET_MONSTER(player, type, doMsgs, 06, 26);
            }
        }
        protected override void FnEvent2E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT() == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 13);
                GET_MONSTER(player, type, doMsgs, 02, 33);
            }
            else if (PARTY_COUNT() == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 12);
                GET_MONSTER(player, type, doMsgs, 02, 13);
                GET_MONSTER(player, type, doMsgs, 03, 14);
                GET_MONSTER(player, type, doMsgs, 04, 14);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 12);
                GET_MONSTER(player, type, doMsgs, 02, 13);
                GET_MONSTER(player, type, doMsgs, 03, 33);
                GET_MONSTER(player, type, doMsgs, 05, 34);
                GET_MONSTER(player, type, doMsgs, 06, 34);
            }
        }
        protected override void FnEvent2F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT() == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 19);
                GET_MONSTER(player, type, doMsgs, 02, 37);
            }
            else if (PARTY_COUNT() == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 18);
                GET_MONSTER(player, type, doMsgs, 02, 16);
                GET_MONSTER(player, type, doMsgs, 03, 19);
                GET_MONSTER(player, type, doMsgs, 04, 37);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 19);
                GET_MONSTER(player, type, doMsgs, 02, 19);
                GET_MONSTER(player, type, doMsgs, 04, 38);
                GET_MONSTER(player, type, doMsgs, 05, 17);
                GET_MONSTER(player, type, doMsgs, 06, 15);
            }
        }
        protected override void FnEvent30(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT() == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 6);
                GET_MONSTER(player, type, doMsgs, 02, 9);
            }
            else if (PARTY_COUNT() == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 6);
                GET_MONSTER(player, type, doMsgs, 02, 8);
                GET_MONSTER(player, type, doMsgs, 04, 28);
                GET_MONSTER(player, type, doMsgs, 05, 11);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 28);
                GET_MONSTER(player, type, doMsgs, 02, 29);
                GET_MONSTER(player, type, doMsgs, 04, 8);
                GET_MONSTER(player, type, doMsgs, 05, 32);
                GET_MONSTER(player, type, doMsgs, 06, 32);
            }
        }
        protected override void FnEvent31(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT() == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 28);
                GET_MONSTER(player, type, doMsgs, 02, 37);
            }
            else if (PARTY_COUNT() == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 28);
                GET_MONSTER(player, type, doMsgs, 02, 28);
                GET_MONSTER(player, type, doMsgs, 03, 26);
                GET_MONSTER(player, type, doMsgs, 04, 37);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 28);
                GET_MONSTER(player, type, doMsgs, 02, 28);
                GET_MONSTER(player, type, doMsgs, 03, 38);
                GET_MONSTER(player, type, doMsgs, 05, 26);
                GET_MONSTER(player, type, doMsgs, 06, 26);
            }
        }
        protected override void FnEvent32(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short i = 0;
            switch (PARTY_COUNT()) {
                case 1:
                    GET_MONSTER(player, type, doMsgs, 01, 27);
                    GET_MONSTER(player, type, doMsgs, 02, 35);
                    break;
                case 2:
                    GET_MONSTER(player, type, doMsgs, 01, 35);
                    GET_MONSTER(player, type, doMsgs, 02, 36);
                    GET_MONSTER(player, type, doMsgs, 05, 27);
                    GET_MONSTER(player, type, doMsgs, 06, 27);
                    break;
                default:
                    for (i = 1; i <= 2; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 36);
                    }
                    for (i = 3; i <= 4; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 35);
                    }
                    for (i = 5; i <= 6; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 27);
                    }
                    break;
            }
        }
        protected override void FnEvent33(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "An unsturdy bridge leads eastward towards an ancient door covered in lichens. The fragile bridge creaks warningly as you approach.");
        }
        private void WallBlock(TwPlayerServer player, MapEventType type, bool doMsgs) {
            BLOCK_WALL(player, type, doMsgs, HERE(), FACING());
        }
        private void WallClear(TwPlayerServer player, MapEventType type, bool doMsgs) {
            CLEAR_WALL(player, type, doMsgs, HERE(), FACING());
        }
        private void PlaceDoor(TwPlayerServer player, MapEventType type, bool doMsgs) {
            PLACE_WALL_ITEM(player, type, doMsgs, DOOR, HERE(), FACING());
        }
    }
}
