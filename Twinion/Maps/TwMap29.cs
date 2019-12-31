using XPT.Generic.Maps;
using XPT.Twinion.Entities;

namespace XPT.Twinion.Maps {
    class TwMap29 : TwMap {
        protected override int MapIndex => 29;
        protected override int MapID => 0x0B04;
        protected override int RandomEncounterChance => 0;
        protected override int RandomEncounterExtraCount => 0;

        private const int GOTTEXT = 1;
        private const int DRAKFIGHT = 2;
        private const int SPRUNGTRAP = 1;
        protected override void FnEvent01(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You manage to move through the astral material.");
        }
        protected override void FnEvent02(TwPlayerServer player, MapEventType type, bool doMsgs) {
            NO_SPELL(player, type, doMsgs);
            NO_SKILL(player, type, doMsgs);
            NO_MANA_ZONE(player, type, doMsgs);
            MOD_MANA(player, type, doMsgs,  - 200);
            if ((GET_FLAG(player, type, doMsgs, ROOM, SPRUNGTRAP) == 0)) {
                if (ALIGN(player, type, doMsgs) == HARMONY) {
                    DAMAGE(player, type, doMsgs, MAX_HEALTH(player, type, doMsgs) / 8);
                    SHOW_TEXT(player, type, doMsgs, "The vile evil that sustains this pocket of Ashakkar here drains life from you!");
                }
                else {
                    SHOW_TEXT(player, type, doMsgs, "You thrive on the vicious forces that exist here.");
                    HEAL(player, type, doMsgs, HEALTH(player, type, doMsgs) / 3);
                    MOD_MANA(player, type, doMsgs, 200);
                }
                SprungTrap(player, type, doMsgs);
            }
        }
        protected override void FnEvent03(TwPlayerServer player, MapEventType type, bool doMsgs) {
            NO_SPELL(player, type, doMsgs);
            NO_SKILL(player, type, doMsgs);
            NO_MANA_ZONE(player, type, doMsgs);
            MOD_MANA(player, type, doMsgs,  - 200);
            if ((GET_FLAG(player, type, doMsgs, ROOM, SPRUNGTRAP) == 0)) {
                if (ALIGN(player, type, doMsgs) == CHAOS) {
                    DAMAGE(player, type, doMsgs, HEALTH(player, type, doMsgs) / 8);
                    SHOW_TEXT(player, type, doMsgs, "Your struggle against the forces in this piece of Enakkar twists and drains your energy.");
                }
                else {
                    SHOW_TEXT(player, type, doMsgs, "You feel revived and refreshed as you travel through this segment of Enakkar.");
                    HEAL(player, type, doMsgs, HEALTH(player, type, doMsgs) / 3);
                    MOD_MANA(player, type, doMsgs, 200);
                }
                SprungTrap(player, type, doMsgs);
            }
        }
        protected override void FnEvent04(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GET_FLAG(player, type, doMsgs, ROOM, SPRUNGTRAP) == 0)) {
                DAMAGE(player, type, doMsgs, HEALTH(player, type, doMsgs) / 3);
                SHOW_TEXT(player, type, doMsgs, "The forces of Fire sear and singe you as you travel through some small part of the Elemental plane.");
                SprungTrap(player, type, doMsgs);
            }
        }
        protected override void FnEvent05(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GET_FLAG(player, type, doMsgs, ROOM, SPRUNGTRAP) == 0)) {
                DAMAGE(player, type, doMsgs, HEALTH(player, type, doMsgs) / 3);
                SHOW_TEXT(player, type, doMsgs, "The Waters here drench you with ominous force.");
                SprungTrap(player, type, doMsgs);
            }
        }
        protected override void FnEvent06(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int i = 0;
            SHOW_TEXT(player, type, doMsgs, "Violent forces whip into a fury of vorticies; forming an arsenal of Planar Guardians who prevent transgressions!!");
            for (i = 1; i <= 4; i++) {
                GET_MONSTER(player, type, doMsgs, i, 39);
            }
            for (i = 5; i <= 6; i++) {
                GET_MONSTER(player, type, doMsgs, i, 40);
            }
        }
        protected override void FnEvent07(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GET_FLAG(player, type, doMsgs, PARTY, GOTTEXT) == 0)) {
                SHOW_TEXT(player, type, doMsgs, "A splendor of sculptures and jewels decorate this elaborate setting.  For you have come into Corpeus' re-creation of his home.");
                SHOW_TEXT(player, type, doMsgs, "This is a semblance of the Physical Plane.");
                SET_FLAG(player, type, doMsgs, PARTY, GOTTEXT, 1);
            }
        }
        protected override void FnEvent08(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GET_FLAG(player, type, doMsgs, PARTY, GOTTEXT) == 0)) {
                SHOW_TEXT(player, type, doMsgs, "Pillars of pure light shoot upwards into oblivion, setting this space ablaze with Juvalad magic.");
                SHOW_TEXT(player, type, doMsgs, "This is a semblance of the plane Enakkar!");
                SET_FLAG(player, type, doMsgs, PARTY, GOTTEXT, 1);
            }
        }
        protected override void FnEvent09(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GET_FLAG(player, type, doMsgs, PARTY, GOTTEXT) == 0)) {
                SHOW_TEXT(player, type, doMsgs, "Violent waves of lava cascade against the astral shores as fire and brimstone fly in Pluthros' throne room.");
                SHOW_TEXT(player, type, doMsgs, "This is a semblance of the plane Ashakkar!");
                SET_FLAG(player, type, doMsgs, PARTY, GOTTEXT, 1);
            }
        }
        protected override void FnEvent0A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GET_FLAG(player, type, doMsgs, PARTY, GOTTEXT) == 0)) {
                SHOW_TEXT(player, type, doMsgs, "The four corners of creation scorn at each other in Malos' domain.");
                SHOW_TEXT(player, type, doMsgs, "This is a semblance of the Elemental Plane.");
                SET_FLAG(player, type, doMsgs, PARTY, GOTTEXT, 1);
            }
        }
        protected override void FnEvent0B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
            SHOW_TEXT(player, type, doMsgs, "Turbulent forces impede you from going any further in this direction.");
        }
        protected override void FnEvent0C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You can just make out a distant plane ahead of you...perhaps you can reach it through here.");
        }
        protected override void FnEvent0D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "A maginficent likeness of some powerful demigod stands here as guardian to this chamber.");
        }
        protected override void FnEvent0E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            NO_MANA_ZONE(player, type, doMsgs);
            if (GET_FLAG(player, type, doMsgs, PARTY, DRAKFIGHT) == 1) {
                if ((GET_FLAG(player, type, doMsgs, DUNGEON, KILLEDMALOS) == 0)) {
                    SHOW_TEXT(player, type, doMsgs, "Malos weaves magical mists as he speaks at you, 'You dare to challenge the Guardian of the Elements! I shall not be so easy to defeat!");
                    SHOW_TEXT(player, type, doMsgs, "My ring shall be yours if you can conquer the Elements!'");
                    BootySet(player, type, doMsgs);
                    TextAtThrone(player, type, doMsgs);
                }
                switch (PARTY_COUNT(player, type, doMsgs)) {
                    case 1:
                        GET_MONSTER(player, type, doMsgs, 01, 35);
                        break;
                    case 2:
                        GET_MONSTER(player, type, doMsgs, 01, 38);
                        GET_MONSTER(player, type, doMsgs, 05, 35);
                        break;
                    default:
                        GET_MONSTER(player, type, doMsgs, 01, 38);
                        GET_MONSTER(player, type, doMsgs, 02, 6);
                        GET_MONSTER(player, type, doMsgs, 06, 35);
                        break;
                }
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "The Dralkarian Lord of the Elements is not here.");
            }
        }
        protected override void FnEvent0F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (ALIGN(player, type, doMsgs) == CHAOS) {
                if (GUILD(player, type, doMsgs) != WIZARD || GUILD(player, type, doMsgs) != CLERIC) {
                    NO_SPELL(player, type, doMsgs);
                    NO_MANA_ZONE(player, type, doMsgs);
                    SHOW_TEXT(player, type, doMsgs, "Juvalad strips you of the ability to use magic! Your alignment opposes his own!");
                }
                else {
                    SHOW_TEXT(player, type, doMsgs, "Your alignment has weakened your magic; but your devotion lets you retain your spells, your skills though are useless!");
                    NO_MANA_ZONE(player, type, doMsgs);
                    NO_SKILL(player, type, doMsgs);
                }
            }
            if (GET_FLAG(player, type, doMsgs, PARTY, DRAKFIGHT) == 1) {
                if ((GET_FLAG(player, type, doMsgs, DUNGEON, KILLEDJUVALAD) == 0)) {
                    SHOW_TEXT(player, type, doMsgs, "Juvalad rises before you, 'Foul fool! Do you not know death, when you see it? Die now and curse in vain!'");
                    TextAtThrone(player, type, doMsgs);
                    BootySet(player, type, doMsgs);
                }
                switch (PARTY_COUNT(player, type, doMsgs)) {
                    case 1:
                        GET_MONSTER(player, type, doMsgs, 01, 36);
                        break;
                    case 2:
                        GET_MONSTER(player, type, doMsgs, 01, 38);
                        GET_MONSTER(player, type, doMsgs, 05, 36);
                        break;
                    default:
                        GET_MONSTER(player, type, doMsgs, 01, 38);
                        GET_MONSTER(player, type, doMsgs, 02, 6);
                        GET_MONSTER(player, type, doMsgs, 06, 36);
                        break;
                }
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "The Dralkarian Lord of Enakkar is not here.");
            }
        }
        protected override void FnEvent10(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (ALIGN(player, type, doMsgs) == HARMONY) {
                SHOW_TEXT(player, type, doMsgs, "Your alignment opposes Pluthros'!");
                if (GUILD(player, type, doMsgs) != WIZARD || GUILD(player, type, doMsgs) != CLERIC) {
                    NO_SPELL(player, type, doMsgs);
                    NO_MANA_ZONE(player, type, doMsgs);
                    SHOW_TEXT(player, type, doMsgs, "For that, he strips your ability to use magic! ");
                }
                else {
                    SHOW_TEXT(player, type, doMsgs, "For that, he has weakened your magic; but your devotion let's you retain your spells! Your skills, however, are useless!");
                    NO_MANA_ZONE(player, type, doMsgs);
                    NO_SKILL(player, type, doMsgs);
                }
            }
            if (GET_FLAG(player, type, doMsgs, PARTY, DRAKFIGHT) == 1) {
                if ((GET_FLAG(player, type, doMsgs, DUNGEON, KILLEDPLUTHROS) == 0)) {
                    SHOW_TEXT(player, type, doMsgs, "Pluthros offers a resonating cry as you approach, 'You do not know of the prophecies! You are not one of the followers!");
                    SHOW_TEXT(player, type, doMsgs, "Now I shall teach you the price of incredulity!'");
                    BootySet(player, type, doMsgs);
                    TextAtThrone(player, type, doMsgs);
                }
                switch (PARTY_COUNT(player, type, doMsgs)) {
                    case 1:
                        GET_MONSTER(player, type, doMsgs, 01, 34);
                        break;
                    case 2:
                        GET_MONSTER(player, type, doMsgs, 01, 38);
                        GET_MONSTER(player, type, doMsgs, 05, 34);
                        break;
                    default:
                        GET_MONSTER(player, type, doMsgs, 01, 38);
                        GET_MONSTER(player, type, doMsgs, 02, 6);
                        GET_MONSTER(player, type, doMsgs, 06, 34);
                        break;
                }
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "The Dralkarian Lord of Ashakkar is not here.");
            }
        }
        protected override void FnEvent11(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, PARTY, DRAKFIGHT) == 1) {
                if ((GET_FLAG(player, type, doMsgs, DUNGEON, KILLEDASTELLIGUS) == 0)) {
                    SHOW_TEXT(player, type, doMsgs, "Astelligus roars as you near his throne room, 'Damn you to Ashakkar! Your intrusion shall be short lived! I shall send you on your way to the next life!'");
                    TextAtThrone(player, type, doMsgs);
                    BootySet(player, type, doMsgs);
                }
                switch (PARTY_COUNT(player, type, doMsgs)) {
                    case 1:
                        GET_MONSTER(player, type, doMsgs, 01, 33);
                        break;
                    case 2:
                        GET_MONSTER(player, type, doMsgs, 01, 38);
                        GET_MONSTER(player, type, doMsgs, 05, 33);
                        break;
                    default:
                        GET_MONSTER(player, type, doMsgs, 01, 38);
                        GET_MONSTER(player, type, doMsgs, 02, 6);
                        GET_MONSTER(player, type, doMsgs, 06, 33);
                        break;
                }
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "The Dralkarian Lord of the Astral plane is not here.");
            }
        }
        protected override void FnEvent13(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "A glowing portal here will send you back to the Main Entrance. You will not be able to return lest you traverse the pathway here again!");
            TELEPORT(player, type, doMsgs, 1, 1, 14, NORTH);
        }
        protected override void FnEvent14(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int flag = 0;
            int portroom1 = 0;
            int portroom2 = 0;
            int f1 = 0;
            int f2 = 0;
            switch (HERE(player, type, doMsgs)) {
                case 30:
                    flag = KILLEDCORPEUS;
                    portroom1 = 14;
                    portroom2 = 46;
                    f1 = NORTH;
                    f2 = SOUTH;
                    break;
                case 168:
                    flag = KILLEDASTELLIGUS;
                    portroom1 = 152;
                    portroom2 = 184;
                    f1 = NORTH;
                    f2 = SOUTH;
                    break;
                case 17:
                    flag = KILLEDJUVALAD;
                    portroom1 = 1;
                    portroom2 = 2;
                    f1 = NORTH;
                    f2 = SOUTH;
                    break;
                case 255:
                    flag = KILLEDPLUTHROS;
                    portroom1 = 254;
                    portroom2 = 239;
                    f1 = SOUTH;
                    f2 = NORTH;
                    break;
                case 225:
                    flag = KILLEDMALOS;
                    portroom1 = 160;
                    portroom2 = 210;
                    f1 = WEST;
                    f2 = NORTH;
                    break;
            }
            if ((PARTY_COUNT(player, type, doMsgs) == 1) && ((GET_FLAG(player, type, doMsgs, DUNGEON, flag) == 0) || GET_FLAG(player, type, doMsgs, DUNGEON, flag) == 2)) {
                if ((GET_FLAG(player, type, doMsgs, DUNGEON, flag) == 0)) {
                    SET_FLAG(player, type, doMsgs, PARTY, DRAKFIGHT, 1);
                }
                TELEPORT(player, type, doMsgs, 11, 4, portroom1, f1);
                SHOW_TEXT(player, type, doMsgs, "You are pulled into the antechamber of the throne room. You must not leave this realm, lest your efforts are wasted!");
            }
            else if (PARTY_COUNT(player, type, doMsgs) > 1) {
                TELEPORT(player, type, doMsgs, 11, 4, portroom2, f2);
                SHOW_TEXT(player, type, doMsgs, "You cannot step here together. Disband and return.");
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "Nothing happens.");
            }
        }
        protected override void FnEvent15(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int item = 0;
            int portlvl = 0;
            int portroom = 0;
            int f1 = 0;
            switch (HERE(player, type, doMsgs)) {
                case 14:
                    item = REALITYSRAMPART;
                    portlvl = 3;
                    portroom = 16;
                    f1 = EAST;
                    break;
                case 254:
                    item = HOPESFURY;
                    portlvl = 2;
                    portroom = 241;
                    f1 = NORTH;
                    break;
                case 160:
                    item = ICEFLAME;
                    portlvl = 2;
                    portroom = 175;
                    f1 = NORTH;
                    break;
                case 1:
                    item = FLASKOFSHADOWFALL;
                    portlvl = 2;
                    portroom = 40;
                    f1 = NORTH;
                    break;
                case 120:
                    item = NIMBUSOFTHEFATES;
                    portlvl = 3;
                    portroom = 240;
                    f1 = EAST;
                    break;
            }
            if (GET_FLAG(player, type, doMsgs, PARTY, DRAKFIGHT) == 1) {
                if (HAS_ITEM(player, type, doMsgs, item)) {
                    SHOW_TEXT(player, type, doMsgs, "In front of you sits an enormous throne, where one of the Dralkarians ponders Fate.");
                    SHOW_TEXT(player, type, doMsgs, "As he notices you, he spots something you're carrying and beckons you forth with an evil grin.");
                }
                else {
                    switch (HERE(player, type, doMsgs)) {
                        case 14:
                            SHOW_TEXT(player, type, doMsgs, "Corpeus bellows at you, 'Without the Rampart, you have no defense. Away, come again once you've found my Reality!'");
                            break;
                        case 254:
                            SHOW_TEXT(player, type, doMsgs, "Pluthros scorns you, 'Hath you no Hope? No Fury? Do not trouble me again without some sign of these!'");
                            break;
                        case 160:
                            SHOW_TEXT(player, type, doMsgs, "Malos screeches at you, 'Have you no wisdom? Dost thou truly believe your puny weapons could defeat the elements? Another, will surely offer me challenge.'");
                            break;
                        case 1:
                            SHOW_TEXT(player, type, doMsgs, "Juvalad sighs in disgust, 'Your efforts are wasted here! Back to Tribulations with you! You can not survive without the Flask.");
                            break;
                        case 120:
                            SHOW_TEXT(player, type, doMsgs, "Astelligus' voice echoes across the great void:");
                            SHOW_TEXT(player, type, doMsgs, "'Puny mortal...you fail to honor me with the proper artifact. Seek the Nimbus, and return, you will make for interesting prey!'");
                            break;
                    }
                    SHOW_TEXT(player, type, doMsgs, "His magics swirl around you and hurl you through a vortex, back to the pathway.");
                    DAMAGE(player, type, doMsgs, HEALTH(player, type, doMsgs) - 10);
                    TELEPORT(player, type, doMsgs, 11, portlvl, portroom, f1);
                }
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "Away! You've left this domain and re-entered. You must remain here once you've started until you've killed the Dralk or died trying!");
                SHOW_TEXT(player, type, doMsgs, "The Dralk sends you to the entrance of His home!");
                switch (HERE(player, type, doMsgs)) {
                    case 160:
                        TELEPORT(player, type, doMsgs, 11, 4, 181, WEST);
                        break;
                    case 14:
                        TELEPORT(player, type, doMsgs, 11, 4, 75, EAST);
                        break;
                    case 1:
                        TELEPORT(player, type, doMsgs, 11, 4, 69, WEST);
                        break;
                    case 254:
                        TELEPORT(player, type, doMsgs, 11, 4, 187, EAST);
                        break;
                    case 120:
                        TELEPORT(player, type, doMsgs, 11, 4, 125, WEST);
                        break;
                }
            }
        }
        protected override void FnEvent16(TwPlayerServer player, MapEventType type, bool doMsgs) {
            BLOCK_FLOOR(player, type, doMsgs, HERE(player, type, doMsgs));
        }
        protected override void FnEvent17(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GET_FLAG(player, type, doMsgs, PARTY, GOTTEXT) == 0)) {
                SHOW_TEXT(player, type, doMsgs, "An enormous void of darkness and surreal images haunts your vision now that you've stepped into a piece of Astelligus' home.");
                SHOW_TEXT(player, type, doMsgs, "This is a semblance of the Astral plane.");
                SET_FLAG(player, type, doMsgs, PARTY, GOTTEXT, 1);
            }
        }
        protected override void FnEvent18(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GUILD(player, type, doMsgs) == WIZARD || GUILD(player, type, doMsgs) == CLERIC || GUILD(player, type, doMsgs) == RANGER || GUILD(player, type, doMsgs) == THIEF) {
                SHOW_TEXT(player, type, doMsgs, "Your prowess with magic allows you to retain your abilities; but not to restore your mana!!!");
                NO_MANA_ZONE(player, type, doMsgs);
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "Your magical powers are feeble and lack the discipline of a Wizard or Cleric. Your magics are useless here!");
                NO_SPELL(player, type, doMsgs);
                NO_MANA_ZONE(player, type, doMsgs);
            }
            if (GET_FLAG(player, type, doMsgs, PARTY, DRAKFIGHT) == 1) {
                if ((GET_FLAG(player, type, doMsgs, DUNGEON, KILLEDCORPEUS) == 0)) {
                    SHOW_TEXT(player, type, doMsgs, "Corpeus is here. His voice shakes the great hall: 'Puny mortal. You dare come to challenge me? For my ring, you must take my life. For your attempt, I will take yours!'");
                    BootySet(player, type, doMsgs);
                    TextAtThrone(player, type, doMsgs);
                }
                switch (PARTY_COUNT(player, type, doMsgs)) {
                    case 1:
                        GET_MONSTER(player, type, doMsgs, 01, 37);
                        break;
                    case 2:
                        GET_MONSTER(player, type, doMsgs, 01, 38);
                        GET_MONSTER(player, type, doMsgs, 05, 37);
                        break;
                    default:
                        GET_MONSTER(player, type, doMsgs, 01, 38);
                        GET_MONSTER(player, type, doMsgs, 02, 6);
                        GET_MONSTER(player, type, doMsgs, 06, 37);
                        break;
                }
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "The Dralkarian Lord of the Physical plane is not here.");
            }
        }
        protected override void FnEvent19(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int flag = 0;
            int itemA = 0;
            switch (HERE(player, type, doMsgs)) {
                case 104:
                    flag = KILLEDASTELLIGUS;
                    itemA = NIMBUSOFTHEFATES;
                    break;
                case 15:
                    flag = KILLEDCORPEUS;
                    itemA = REALITYSRAMPART;
                    break;
                case 0:
                    flag = KILLEDJUVALAD;
                    itemA = FLASKOFSHADOWFALL;
                    break;
                case 161:
                    flag = KILLEDMALOS;
                    itemA = ICEFLAME;
                    break;
                case 238:
                    flag = KILLEDPLUTHROS;
                    itemA = HOPESFURY;
                    break;
            }
            if (HAS_ITEM(player, type, doMsgs, DRALKARIANRING) && (GET_FLAG(player, type, doMsgs, DUNGEON, flag) == 0)) {
                TAKE_ITEM(player, type, doMsgs, itemA);
                MOD_EXP(player, type, doMsgs, 1250000);
                SHOW_TEXT(player, type, doMsgs, "The mystical device that aided you in the demise of this Dralk has also vanished!");
                SET_FLAG(player, type, doMsgs, DUNGEON, flag, 1);
                TpSpecial(player, type, doMsgs);
            }
            else if (GET_FLAG(player, type, doMsgs, DUNGEON, flag) == 2) {
                SHOW_TEXT(player, type, doMsgs, "You've passed here before! Live on and remember the Dralk as he was!");
                TpSpecial(player, type, doMsgs);
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "You must continue, for the Dralk's ring and his embodiment are gone from here.");
                TpSpecial(player, type, doMsgs);
            }
        }
        protected override void FnEvent1A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            NO_SPELL(player, type, doMsgs);
            int flagtotal = 0;
            flagtotal = GET_FLAG(player, type, doMsgs, DUNGEON, KILLEDASTELLIGUS);
             + GET_FLAG(player, type, doMsgs, DUNGEON, KILLEDPLUTHROS);
             + GET_FLAG(player, type, doMsgs, DUNGEON, KILLEDMALOS);
             + GET_FLAG(player, type, doMsgs, DUNGEON, KILLEDJUVALAD);
             + GET_FLAG(player, type, doMsgs, DUNGEON, KILLEDCORPEUS);
            if (HAS_ITEM(player, type, doMsgs, DRALKARIANRING)) {
                TAKE_ITEM(player, type, doMsgs, DRALKARIANRING);
                MOD_EXP(player, type, doMsgs, 1000000);
                if (flagtotal <= 4) {
                    SHOW_PICTURE(player, type, doMsgs, QUEENAEOWYN);
                    SHOW_TEXT(player, type, doMsgs, "'My Great Champion! You've returned one of the Dralk's Rings! This will ensure us the power to enter the final phase of this most grand design!");
                    SHOW_TEXT(player, type, doMsgs, "With each ring, I can use its power to increase your wisdom. Reap the benefits of the services you have sewn!");
                    SHOW_TEXT(player, type, doMsgs, "Quickly now, with each passing Dralk we step closer to finding the nexus of immortality. Onward, return once you've conquered the next Dralk!'");
                }
                else {
                    SHOW_PICTURE(player, type, doMsgs, QUEENAEOWYN);
                    SHOW_TEXT(player, type, doMsgs, "As the Queen takes the fifth ring from your grasp, the forces here explode in a violent shockwave, throwing you to the ground.");
                    SHOW_TEXT(player, type, doMsgs, "Aeowyn is absorbed in a fiery light of pure magic, she hovers and offers an evil laugh!");
                    SHOW_TEXT(player, type, doMsgs, "'Did you truly believe I would share the greatest triumph with you! Your powers are no match for mine now! Away with you! Your faith in my friendship was your weakness! I alone shall breach The Gateway; I alone shall enter the next phase!'");
                    SHOW_TEXT(player, type, doMsgs, "Driven mad with power, Aeowyn hurls untamed forces upon you, stripping away parts of your attributes! A blast explodes on the southern wall, where a teleport will allow you escape.");
                    SHOW_TEXT(player, type, doMsgs, "The mad Queen, then dissipates into nothingness, only her evil laughter echoing as she heads off to The Gateway.");
                    DAMAGE(player, type, doMsgs, HEALTH(player, type, doMsgs) / 2);
                    TAKE_ITEM(player, type, doMsgs, STARBURST);
                    if ((GET_FLAG(player, type, doMsgs, DUNGEON, ENDGAMETELE) == 0)) {
                        MOD_STAT(player, type, doMsgs, STRENGTH,  - 1);
                        MOD_STAT(player, type, doMsgs, AGILITY,  - 2);
                        MOD_STAT(player, type, doMsgs, INITIATIVE,  - 2);
                        SET_FLAG(player, type, doMsgs, DUNGEON, ENDGAMETELE, 1);
                    }
                }
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "'My Champion, you must return the Dralks' rings to me! Without them we will never be able to enter the ultimate goal of our Quest!'");
                SHOW_TEXT(player, type, doMsgs, "The Queen conjurs a gateway behind you. 'Take this to the entrance, and try again! I will be here as long as possible...' She then returns to her magics and dismisses you.");
            }
        }
        protected override void FnEvent1B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Her Majesty hovers before you in a misty hue of grey-blue smoke. She is conjuring powerful forces to hold her presence here!");
            SHOW_TEXT(player, type, doMsgs, "Approach her to the north, and report!");
        }
        protected override void FnEvent1C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "This shall lead you out.");
            TELEPORT(player, type, doMsgs, 1, 1, 3, SOUTH);
        }
        private void BootySet(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SET_BOOTY(player, type, doMsgs, DRALKARIANRING, 0, 0, 0, 0, 200000);
        }
        private void SprungTrap(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SET_FLAG(player, type, doMsgs, ROOM, SPRUNGTRAP, 1);
        }
        private void TpSpecial(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 11, 4, 56, NORTH);
        }
        private void TextAtThrone(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "A wall slides silently shut behind you, trapping you in the Dralk's throne room.");
            SHOW_TEXT(player, type, doMsgs, "Brilliant crystals offset a stunning portal on the now closed egress!");
        }
    }
}
