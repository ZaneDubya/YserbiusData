using XPT.Generic.Maps;
using XPT.Twinion.Entities;

namespace XPT.Twinion.Maps {
    class TwMap21 : TwMap {
        protected override int MapIndex => 21;
        protected override int MapID => 0x0901;
        protected override int RandomEncounterChance => 9;
        protected override int RandomEncounterExtraCount => 1;

        private const int HURT = 1;
        private const int HOCUS_PASS = 1;
        private const int FAERLUN = 2;
        private const int HOCUS_BAT = 3;
        private const int HOCUS_NEWT = 4;
        protected override void FnEvent01(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 9, 1, 113, EAST);
        }
        protected override void FnEvent02(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 9, 1, 22, WEST);
        }
        protected override void FnEvent03(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "All ye who enter here, abandon hope.");
            TELEPORT(player, type, doMsgs, 9, 2, 119, NORTH);
        }
        protected override void FnEvent04(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 9, 1, 240, EAST);
        }
        protected override void FnEvent05(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "This portal has markings similar to the great dragon's lair above.");
            TELEPORT(player, type, doMsgs, 8, 1, 239, WEST);
        }
        protected override void FnEvent06(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 9, 1, 15, NORTH);
        }
        protected override void FnEvent07(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You enter the Cup and Sorcerer banquet hall. Students and instructors dine here.");
        }
        protected override void FnEvent08(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, DUNGEON, INSTRUCTOR) == 1) {
                SHOW_TEXT(player, type, doMsgs, "The classroom is empty.");
            }
            else {
                MOD_EXP(player, type, doMsgs, 20000);
                SET_FLAG(player, type, doMsgs, DUNGEON, INSTRUCTOR, 1);
                SHOW_TEXT(player, type, doMsgs, "You observe a wise old mage teaching his craft. His lessons are very helpful.");
            }
        }
        protected override void FnEvent09(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "The guard nods and goes back to his work.");
        }
        protected override void FnEvent0A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "The library is silent as students concentrate on their tomes.");
        }
        protected override void FnEvent0B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "The administrative clerks are hard at work.");
        }
        protected override void FnEvent0C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, PARTY, FAERLUN) == 1) {
                CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
                SHOW_TEXT(player, type, doMsgs, "The door swings open.");
            }
            else {
                BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
                SHOW_TEXT(player, type, doMsgs, "A note on the door from the town clerk reads:");
                SHOW_TEXT(player, type, doMsgs, "'Faerlun, I'll be back after lunch.'");
            }
        }
        protected override void FnEvent0D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You throw a few coins into the well for luck.");
            MOD_GOLD(player, type, doMsgs,  - 100);
        }
        protected override void FnEvent0E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You marvel at the splendor of this wizard's home.");
        }
        protected override void FnEvent10(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "To the west is the Alchemy Shop; to the east, the Armory.");
        }
        protected override void FnEvent11(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You enter a modest home.");
        }
        protected override void FnEvent12(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, ELFRANGER);
            SHOW_TEXT(player, type, doMsgs, "You pass a resident tending the garden where the wizards grow ingredients for their spells.");
        }
        protected override void FnEvent13(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "To the west you see the General Store; to the east, the Magic Shop.");
        }
        protected override void FnEvent14(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "A sign reads -");
            SHOW_TEXT(player, type, doMsgs, "'See the town clerk for information on training.'");
        }
        protected override void FnEvent15(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Hocus Pocus Stables");
        }
        protected override void FnEvent16(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "A plaque reads -");
            SHOW_TEXT(player, type, doMsgs, "'Items at the shops are not free.'");
        }
        protected override void FnEvent17(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You step into a pool of lava.");
            DAMAGE(player, type, doMsgs, MAX_HEALTH(player, type, doMsgs));
        }
        protected override void FnEvent18(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "The pit is bottomless.");
            DAMAGE(player, type, doMsgs, MAX_HEALTH(player, type, doMsgs));
        }
        protected override void FnEvent19(TwPlayerServer player, MapEventType type, bool doMsgs) {
            NO_HEAL_ZONE(player, type, doMsgs);
            if ((GET_FLAG(player, type, doMsgs, ROOM, HURT) == 0)) {
                SHOW_TEXT(player, type, doMsgs, "The mystical waters weaken you.");
                DAMAGE(player, type, doMsgs, MAX_HEALTH(player, type, doMsgs) / 4);
                SET_FLAG(player, type, doMsgs, ROOM, HURT, 1);
            }
        }
        protected override void FnEvent1A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Hocus Pocus Herb Garden");
        }
        protected override void FnEvent1B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
        }
        protected override void FnEvent1C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (USED_SKILL(player, type, doMsgs, DETECT_SKILL) >= 10 || USED_SPELL(player, type, doMsgs, TRUE_SEEING_SPELL) >= 1 || USED_ITEM(player, type, doMsgs, HELMOFWISDOM, HELMOFWISDOM) || USED_ITEM(player, type, doMsgs, VALKYRIESHELM, VALKYRIESHELM) || USED_ITEM(player, type, doMsgs, RINGOFTHIEVES, RINGOFTHIEVES) || USED_ITEM(player, type, doMsgs, CRYSTALBALL, CRYSTALBALL)) {
                SHOW_TEXT(player, type, doMsgs, "A passageway appears.");
                PLACE_WALL_ITEM(player, type, doMsgs, DOOR, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
                CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
            }
            else {
                BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
            }
        }
        protected override void FnEvent1E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, HUMANTHIEF);
            if (GET_FLAG(player, type, doMsgs, DUNGEON, ALCHEMY) == 1) {
                SHOW_TEXT(player, type, doMsgs, "You find nothing you need.");
            }
            else {
                SET_FLAG(player, type, doMsgs, DUNGEON, ALCHEMY, 1);
                MOD_GOLD(player, type, doMsgs,  - 20000);
                GIVE_ITEM(player, type, doMsgs, MANAAMPHORA);
                GIVE_ITEM(player, type, doMsgs, HEALAMPHORA);
                SHOW_TEXT(player, type, doMsgs, "The shopkeeper is happy to take your gold.");
            }
        }
        protected override void FnEvent1F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, ORCKNIGHT);
            if (GET_FLAG(player, type, doMsgs, DUNGEON, ARMORY) == 1) {
                SHOW_TEXT(player, type, doMsgs, "The armorer is busy forging new weapons.");
            }
            else {
                SET_FLAG(player, type, doMsgs, DUNGEON, ARMORY, 1);
                MOD_GOLD(player, type, doMsgs,  - 5000);
                GIVE_ITEM(player, type, doMsgs, ARCHEDDEATH);
                GIVE_ITEM(player, type, doMsgs, STAFFOFTHEMAGUS);
                GIVE_ITEM(player, type, doMsgs, BOWOFFLAMES);
                SHOW_TEXT(player, type, doMsgs, "You exchange your gold for weapons.");
            }
        }
        protected override void FnEvent20(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, TROLLCLERIC);
            if (GET_FLAG(player, type, doMsgs, DUNGEON, GENERAL) == 1) {
                SHOW_TEXT(player, type, doMsgs, "The shopkeeper is too busy to help you.");
            }
            else {
                SET_FLAG(player, type, doMsgs, DUNGEON, GENERAL, 1);
                MOD_GOLD(player, type, doMsgs,  - 10000);
                GIVE_ITEM(player, type, doMsgs, AMULETOFPROTECTION);
                GIVE_ITEM(player, type, doMsgs, PIPESOFENCHANTMENT);
                GIVE_ITEM(player, type, doMsgs, FREEDOMRING);
                SHOW_TEXT(player, type, doMsgs, "You decide on some helpful items.");
            }
        }
        protected override void FnEvent21(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, HALFLINGCLERIC);
            if (GET_FLAG(player, type, doMsgs, DUNGEON, MAGIC_SHOP) == 1) {
                SHOW_TEXT(player, type, doMsgs, "You have already made your purchase.");
            }
            else {
                SET_FLAG(player, type, doMsgs, DUNGEON, MAGIC_SHOP, 1);
                MOD_GOLD(player, type, doMsgs,  - 25000);
                GIVE_ITEM(player, type, doMsgs, SYMBOLOFDEATH);
                GIVE_ITEM(player, type, doMsgs, PUMMELSCROLL);
                SHOW_TEXT(player, type, doMsgs, "You purchase scrolls.");
            }
        }
        protected override void FnEvent22(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, DUNGEON, HOCUS_GOLD) == 1) {
                SHOW_TEXT(player, type, doMsgs, "The building is empty.");
            }
            else {
                SET_FLAG(player, type, doMsgs, DUNGEON, HOCUS_GOLD, 1);
                MOD_GOLD(player, type, doMsgs, 25000);
                SHOW_TEXT(player, type, doMsgs, "You discover a lost quest bag filled with gold.");
            }
        }
        protected override void FnEvent23(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, DUNGEON, HOCUS_SCROLL) == 1) {
                SHOW_TEXT(player, type, doMsgs, "The room is empty.");
            }
            else {
                SET_FLAG(player, type, doMsgs, DUNGEON, HOCUS_SCROLL, 1);
                GIVE_ITEM(player, type, doMsgs, BLOODSCROLL);
                GIVE_ITEM(player, type, doMsgs, SCORCHEDSCROLL);
                GIVE_ITEM(player, type, doMsgs, SOVEREIGNSCROLL);
                SHOW_TEXT(player, type, doMsgs, "A search yields scrolls.");
            }
        }
        protected override void FnEvent24(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "A strange magical aura drains your mana.");
            MOD_MANA(player, type, doMsgs,  - 300);
        }
        protected override void FnEvent25(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "The acolytes of Nisym Temple restore your mana free of charge.");
            MOD_MANA(player, type, doMsgs, 10000);
        }
        protected override void FnEvent26(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, HALFLINGRANGER);
            SHOW_TEXT(player, type, doMsgs, "'Welcome to the Talisman Inn. I have taken payment for your accommodations. You will find your health improved after your brief rest.'");
            HEAL(player, type, doMsgs, MAX_HEALTH(player, type, doMsgs));
            MOD_GOLD(player, type, doMsgs,  - 1000);
        }
        protected override void FnEvent27(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, DWARFKNIGHT);
            SET_FLAG(player, type, doMsgs, PARTY, HOCUS_PASS, 1);
            SHOW_TEXT(player, type, doMsgs, "The clerk greets you.");
            SHOW_TEXT(player, type, doMsgs, "'Hail! I've been expecting you.");
            SHOW_TEXT(player, type, doMsgs, "Word has been sent to the training area guard. You will now be granted access.'");
        }
        protected override void FnEvent28(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, HUMANWIZARD);
            if (GET_FLAG(player, type, doMsgs, DUNGEON, HOCUS_DONE) == 1) {
                SET_FLAG(player, type, doMsgs, PARTY, FAERLUN, 1);
                CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
                PLACE_WALL_ITEM(player, type, doMsgs, DOOR, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
                SHOW_TEXT(player, type, doMsgs, "Ah! You have found my items! Now walk alone through the door to the east for your promised reward.");
            }
            else if (GET_FLAG(player, type, doMsgs, DUNGEON, HOCUS_DONE) == 2) {
                SET_FLAG(player, type, doMsgs, PARTY, FAERLUN, 1);
                CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
                PLACE_WALL_ITEM(player, type, doMsgs, DOOR, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
                SHOW_TEXT(player, type, doMsgs, "Try again, my friend. The path is tricky, but very rewarding.");
            }
            else {
                if (HAS_ITEM(player, type, doMsgs, DRAGONSSKIN)) {
                    SET_FLAG(player, type, doMsgs, PARTY, FAERLUN, 1);
                    BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
                    TAKE_ITEM(player, type, doMsgs, DRAGONSSKIN);
                    MOD_GOLD(player, type, doMsgs, 10000);
                    SHOW_TEXT(player, type, doMsgs, "'Hail, brave adventurers!  My name is Faerlun.");
                    SHOW_TEXT(player, type, doMsgs, "What an interesting dragon skin you've found! Let's do a little swap, shall we?");
                    SHOW_TEXT(player, type, doMsgs, "I'll take the skin. You take this gold.");
                    SHOW_TEXT(player, type, doMsgs, "Now that you are here, maybe you can help me find the wing of a bat and eye of a newt.");
                    SHOW_TEXT(player, type, doMsgs, "These items you will find in Hocus Pocus.");
                    SHOW_TEXT(player, type, doMsgs, "By the way, do NOT leave the village until you find them.");
                    SHOW_TEXT(player, type, doMsgs, "Bring them to me and I will show you the way to a challenge of great reward.'");
                }
                else {
                    SET_FLAG(player, type, doMsgs, PARTY, FAERLUN, 1);
                    BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
                    SHOW_TEXT(player, type, doMsgs, "'Hail, adventurers. My name is Faerlun and I could use some assistance.");
                    SHOW_TEXT(player, type, doMsgs, "For an experiment I am doing, I seek the wing of a bat and the eye of a newt.");
                    SHOW_TEXT(player, type, doMsgs, "Do NOT leave Hocus Pocus until you find these items.");
                    SHOW_TEXT(player, type, doMsgs, "In exchange for your help, I will show you the way to a challenge of great reward.'");
                }
            }
        }
        protected override void FnEvent29(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, PARTY, HOCUS_PASS) == 1 && GET_FLAG(player, type, doMsgs, PARTY, FAERLUN) == 1) {
                CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
                PLACE_WALL_ITEM(player, type, doMsgs, DOOR, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
                SHOW_TEXT(player, type, doMsgs, "The guard notes your name on the list and allows you access.");
            }
            else {
                BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
            }
        }
        protected override void FnEvent2A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, DWARFWIZARD);
            if (GET_FLAG(player, type, doMsgs, PARTY, FAERLUN) == 1 && GET_FLAG(player, type, doMsgs, PARTY, HOCUS_PASS) == 1 && GET_FLAG(player, type, doMsgs, PARTY, HOCUS_BAT) == 1) {
                SET_FLAG(player, type, doMsgs, DUNGEON, HOCUS_DONE, 1);
                SET_FLAG(player, type, doMsgs, PARTY, FAERLUN, 0);
                SET_FLAG(player, type, doMsgs, PARTY, HOCUS_PASS, 0);
                SET_FLAG(player, type, doMsgs, PARTY, HOCUS_BAT, 0);
                SHOW_TEXT(player, type, doMsgs, "You meet Morai, who hands you a vial.");
                SHOW_TEXT(player, type, doMsgs, "She explains 'I see that you have found the bat wings. Now, this eye of newt will complete Faerlun's needs.'");
                SHOW_TEXT(player, type, doMsgs, "You pocket the vial and leave.");
            }
            else if (GET_FLAG(player, type, doMsgs, PARTY, FAERLUN) == 1 && GET_FLAG(player, type, doMsgs, PARTY, HOCUS_PASS) == 1) {
                SET_FLAG(player, type, doMsgs, PARTY, HOCUS_NEWT, 1);
                SHOW_TEXT(player, type, doMsgs, "You meet Morai, who hands you a vial.");
                SHOW_TEXT(player, type, doMsgs, "'Take this eye of newt back to Faerlun. It is part of what he needs for his studies.'");
                SHOW_TEXT(player, type, doMsgs, "You pocket the vial and leave.");
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "Morai is concentrating on her studies.");
            }
        }
        protected override void FnEvent2B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, GREMLINWIZARD);
            if (GET_FLAG(player, type, doMsgs, PARTY, FAERLUN) == 1 && GET_FLAG(player, type, doMsgs, PARTY, HOCUS_PASS) == 1 && GET_FLAG(player, type, doMsgs, PARTY, HOCUS_NEWT) == 1) {
                SET_FLAG(player, type, doMsgs, DUNGEON, HOCUS_DONE, 1);
                SET_FLAG(player, type, doMsgs, PARTY, FAERLUN, 0);
                SET_FLAG(player, type, doMsgs, PARTY, HOCUS_PASS, 0);
                SET_FLAG(player, type, doMsgs, PARTY, HOCUS_NEWT, 0);
                SHOW_TEXT(player, type, doMsgs, "Keoana greets you. Noticing the eye of newt you carry, she hands you a vial of bat wings.");
                SHOW_TEXT(player, type, doMsgs, "She says, 'Faerlun will be pleased that you have found his ingredients.'");
            }
            else if (GET_FLAG(player, type, doMsgs, PARTY, FAERLUN) == 1 && GET_FLAG(player, type, doMsgs, PARTY, HOCUS_PASS) == 1) {
                SET_FLAG(player, type, doMsgs, PARTY, HOCUS_BAT, 1);
                SHOW_TEXT(player, type, doMsgs, "Keoana smiles as you enter.");
                SHOW_TEXT(player, type, doMsgs, "'Faerlun is in need of these bat wings. Please take them to him so that he may complete his studies.'");
                SHOW_TEXT(player, type, doMsgs, "You nod and pocket the vial.");
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "Keoana ignores you.");
            }
        }
        protected override void FnEvent2C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, GNOMEWIZARD);
            if (GET_FLAG(player, type, doMsgs, DUNGEON, HOCUS_SPELL) == 1) {
                SHOW_TEXT(player, type, doMsgs, "Taemen nods as you pass.");
            }
            else {
                if (GUILD(player, type, doMsgs) == KNIGHT) {
                    SET_FLAG(player, type, doMsgs, DUNGEON, HOCUS_SPELL, 1);
                    GIVE_SPELL(player, type, doMsgs, REFRESH_SPELL, 1);
                    SHOW_TEXT(player, type, doMsgs, "Taemen teaches you the Refresh spell.");
                }
                else if (GUILD(player, type, doMsgs) == RANGER) {
                    SET_FLAG(player, type, doMsgs, DUNGEON, HOCUS_SPELL, 1);
                    GIVE_SPELL(player, type, doMsgs, HAIL_SPELL, 1);
                    SHOW_TEXT(player, type, doMsgs, "Taemen teaches you how to cast the Hail spell.");
                }
                else {
                    SET_FLAG(player, type, doMsgs, DUNGEON, HOCUS_SPELL, 1);
                    GIVE_SPELL(player, type, doMsgs, DISSIPATE_SPELL, 1);
                    SHOW_TEXT(player, type, doMsgs, "Taemen teaches you the Dissipate spell.");
                }
            }
        }
        protected override void FnEvent2D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, HUMANWIZARD);
            if (GET_FLAG(player, type, doMsgs, DUNGEON, HOCUS_SKILL) == 1) {
                SHOW_TEXT(player, type, doMsgs, "Saronel nods as you pass through.");
            }
            else {
                SET_FLAG(player, type, doMsgs, DUNGEON, HOCUS_SKILL, 1);
                MOD_STAT(player, type, doMsgs, AGILITY, 2);
                MOD_STAT(player, type, doMsgs, DEFENSE, 1);
                SHOW_TEXT(player, type, doMsgs, "'Greetings my friends. I am Saronel. I've gotten word that you are doing fine in your studies of the ways of a mage.'");
                SHOW_TEXT(player, type, doMsgs, "With that he raises his arms and in a flash you sense your defenses improve.");
                SHOW_TEXT(player, type, doMsgs, "'Continue your journey. Hopefully my gift will aid you on your way.'");
            }
        }
        protected override void FnEvent2E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, NIGHTELFWARRIOR);
            if (GET_FLAG(player, type, doMsgs, DUNGEON, HOCUS_MAZE) == 1) {
                SHOW_TEXT(player, type, doMsgs, "Geadiax nods as you pass.");
            }
            else {
                if (GUILD(player, type, doMsgs) == CLERIC || GUILD(player, type, doMsgs) == WIZARD) {
                    SET_FLAG(player, type, doMsgs, DUNGEON, HOCUS_MAZE, 1);
                    GIVE_SPELL(player, type, doMsgs, BLAST_SPELL, 1);
                    GIVE_ITEM(player, type, doMsgs, JEWELEDBREASTPLATE);
                    GIVE_ITEM(player, type, doMsgs, PRIESTLYGARB);
                    MOD_EXP(player, type, doMsgs, 700000);
                    SHOW_TEXT(player, type, doMsgs, "Geadiax congratulates you on successfully completing your challenge.");
                    SHOW_TEXT(player, type, doMsgs, "He raises his arms and magically endows you with the Blast spell and presents you with fine gifts.");
                    SHOW_TEXT(player, type, doMsgs, "You find the experience most rewarding.");
                }
                else if (GUILD(player, type, doMsgs) == BARBARIAN) {
                    SET_FLAG(player, type, doMsgs, DUNGEON, HOCUS_MAZE, 1);
                    GIVE_ITEM(player, type, doMsgs, SPIKEDSHIELD);
                    MOD_SKILL(player, type, doMsgs, MARTIAL_ARTS_SKILL, 1);
                    MOD_EXP(player, type, doMsgs, 700000);
                    SHOW_TEXT(player, type, doMsgs, "Geadiax congratulates you on successfully completing your challenge.");
                    SHOW_TEXT(player, type, doMsgs, "He raises his arms and magically endows you with the Martial Arts skill and presents you with a fine gift.");
                    SHOW_TEXT(player, type, doMsgs, "You find the experience most rewarding.");
                }
                else {
                    SET_FLAG(player, type, doMsgs, DUNGEON, HOCUS_MAZE, 1);
                    GIVE_ITEM(player, type, doMsgs, TWOHANDEDSWORD);
                    GIVE_ITEM(player, type, doMsgs, DEGREEOFVENGEANCE);
                    MOD_SKILL(player, type, doMsgs, DEFLECT_MAGIC_SKILL, 1);
                    MOD_EXP(player, type, doMsgs, 700000);
                    SHOW_TEXT(player, type, doMsgs, "Geadiax congratulates you on successfully completing your challenge.");
                    SHOW_TEXT(player, type, doMsgs, "He raises his arms and magically endows you with a skill to deflect magic and presents you with fine gifts.");
                    SHOW_TEXT(player, type, doMsgs, "You find the experience most rewarding.");
                }
            }
        }
        protected override void FnEvent2F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You open a book which you find on one of the tables.");
            SHOW_TEXT(player, type, doMsgs, "'Harken, ye, to the report of a great door maze in Hocus Pocus. Yet unto this day, no one has discovered the hiding place of Geadiax, verily I say unto ye.");
            SHOW_TEXT(player, type, doMsgs, "Tis rumored that he has imprisoned powerful monsters within, to keep the likes such as ye from discovering his whereabouts.'");
        }
        protected override void FnEvent30(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "The wizards test what you have learned.");
            if (HAS_ITEM(player, type, doMsgs, HEALAMPHORA)) {
                SET_BOOTY(player, type, doMsgs, SCROLLOFSAFETY, 0, 0, 0, 0, 2000);
            }
            else {
                SET_BOOTY(player, type, doMsgs, HEALAMPHORA, MANARESTORE, SHAMANSCROLL, 0, 0, 5000);
            }
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 19);
                GET_MONSTER(player, type, doMsgs, 02, 28);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 8);
                GET_MONSTER(player, type, doMsgs, 02, 11);
                GET_MONSTER(player, type, doMsgs, 05, 36);
                GET_MONSTER(player, type, doMsgs, 06, 37);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 10);
                GET_MONSTER(player, type, doMsgs, 02, 11);
                GET_MONSTER(player, type, doMsgs, 03, 8);
                GET_MONSTER(player, type, doMsgs, 04, 9);
                GET_MONSTER(player, type, doMsgs, 05, 38);
                GET_MONSTER(player, type, doMsgs, 06, 28);
            }
        }
        protected override void FnEvent31(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "The instructors decide to evaluate your spellcasting abilities.");
            if (HAS_ITEM(player, type, doMsgs, ZEUSSCROLL)) {
                SET_BOOTY(player, type, doMsgs, BOOMERANGSCROLL, AURASCROLL, BASALTSCROLL, 0, 0, 2000);
            }
            else {
                SET_BOOTY(player, type, doMsgs, ZEUSSCROLL, AURASCROLL, BLOODSCROLL, 0, 0, 3000);
            }
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 25);
                GET_MONSTER(player, type, doMsgs, 02, 33);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 25);
                GET_MONSTER(player, type, doMsgs, 02, 25);
                GET_MONSTER(player, type, doMsgs, 03, 32);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 25);
                GET_MONSTER(player, type, doMsgs, 02, 25);
                GET_MONSTER(player, type, doMsgs, 03, 26);
                GET_MONSTER(player, type, doMsgs, 04, 26);
                GET_MONSTER(player, type, doMsgs, 05, 27);
            }
        }
        protected override void FnEvent32(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You prepare to show your instructors what you have learned.");
            if (HAS_ITEM(player, type, doMsgs, SYMBOLOFDEATH)) {
                SET_BOOTY(player, type, doMsgs, REFRESHALLSCROLL, CRYSTALSCROLL, 0, 0, 0, 2000);
            }
            else {
                SET_BOOTY(player, type, doMsgs, SYMBOLOFDEATH, SCROLLOFWIND, HEALALLPOTION, 0, 0, 3000);
            }
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 28);
                GET_MONSTER(player, type, doMsgs, 02, 35);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 21);
                GET_MONSTER(player, type, doMsgs, 02, 22);
                GET_MONSTER(player, type, doMsgs, 05, 28);
                GET_MONSTER(player, type, doMsgs, 06, 19);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 36);
                GET_MONSTER(player, type, doMsgs, 02, 37);
                GET_MONSTER(player, type, doMsgs, 03, 38);
                GET_MONSTER(player, type, doMsgs, 04, 39);
                GET_MONSTER(player, type, doMsgs, 05, 17);
                GET_MONSTER(player, type, doMsgs, 06, 28);
            }
        }
        protected override void FnEvent33(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You are given the chance to practice your spellcasting.");
            SET_BOOTY(player, type, doMsgs, MANDRAKESTAFF, CURATIVEELIXIR, RUNECHART, 0, 0, 2000);
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 3);
                GET_MONSTER(player, type, doMsgs, 02, 5);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 1);
                GET_MONSTER(player, type, doMsgs, 02, 2);
                GET_MONSTER(player, type, doMsgs, 05, 3);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 3);
                GET_MONSTER(player, type, doMsgs, 02, 4);
                GET_MONSTER(player, type, doMsgs, 03, 2);
                GET_MONSTER(player, type, doMsgs, 05, 30);
                GET_MONSTER(player, type, doMsgs, 06, 30);
            }
        }
        protected override void FnEvent34(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "The training hall provides you with battles to test your abilities.");
            if (HAS_ITEM(player, type, doMsgs, LIFEGIVER)) {
                SET_BOOTY(player, type, doMsgs, BINDINGTALISMAN, JADEDRING, 0, 0, 0, 2000);
            }
            else if (!HAS_ITEM(player, type, doMsgs, MANARESTORE)) {
                SET_BOOTY(player, type, doMsgs, LIFEGIVER, MANARESTORE, HEALALLPOTION, 0, 0, 2000);
            }
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 12);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 12);
                GET_MONSTER(player, type, doMsgs, 02, 13);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 15);
                GET_MONSTER(player, type, doMsgs, 02, 15);
                GET_MONSTER(player, type, doMsgs, 03, 16);
                GET_MONSTER(player, type, doMsgs, 04, 34);
            }
        }
        protected override void FnEvent35(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "A stranded Erebus Fiend pounces on you!");
            SET_BOOTY(player, type, doMsgs, PLATINUMBAR, RINGOFTHIEVES, 0, 0, 0, 10000);
            GET_MONSTER(player, type, doMsgs, 01, 40);
        }
        protected override void FnEvent36(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You disturb a secret meeting.");
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 28);
                GET_MONSTER(player, type, doMsgs, 05, 6);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 21);
                GET_MONSTER(player, type, doMsgs, 02, 23);
                GET_MONSTER(player, type, doMsgs, 05, 30);
                GET_MONSTER(player, type, doMsgs, 06, 6);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 36);
                GET_MONSTER(player, type, doMsgs, 02, 37);
                GET_MONSTER(player, type, doMsgs, 03, 6);
                GET_MONSTER(player, type, doMsgs, 04, 6);
                GET_MONSTER(player, type, doMsgs, 05, 32);
                GET_MONSTER(player, type, doMsgs, 06, 33);
            }
        }
        protected override void FnEvent37(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 8);
                GET_MONSTER(player, type, doMsgs, 02, 11);
                GET_MONSTER(player, type, doMsgs, 06, 35);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 9);
                GET_MONSTER(player, type, doMsgs, 02, 9);
                GET_MONSTER(player, type, doMsgs, 05, 11);
                GET_MONSTER(player, type, doMsgs, 06, 11);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 9);
                GET_MONSTER(player, type, doMsgs, 02, 9);
                GET_MONSTER(player, type, doMsgs, 03, 10);
                GET_MONSTER(player, type, doMsgs, 04, 10);
                GET_MONSTER(player, type, doMsgs, 05, 35);
                GET_MONSTER(player, type, doMsgs, 06, 35);
            }
        }
        protected override void FnEvent38(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                SHOW_TEXT(player, type, doMsgs, "Proceed through the portal for your final test.");
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "You must proceed through the door in single file.");
                TELEPORT(player, type, doMsgs, 9, 1, 254, EAST);
            }
        }
        protected override void FnEvent39(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SET_FLAG(player, type, doMsgs, DUNGEON, HOCUS_DONE, 2);
            SET_FLAG(player, type, doMsgs, PARTY, FAERLUN, 0);
            SET_FLAG(player, type, doMsgs, PARTY, HOCUS_PASS, 0);
        }
        protected override void FnEvent3A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You see a sign on the door reading, 'DO NOT ENTER'.");
        }
    }
}
