using XPT.Generic.Maps;
using XPT.Twinion.Entities;

namespace XPT.Twinion.Maps {
    class TwMap31 : TwMap {
        protected override int MapIndex => 31;
        protected override int MapID => 0x0C02;
        protected override int RandomEncounterChance => 0;
        protected override int RandomEncounterExtraCount => 0;

        protected override void FnEvent01(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Each of these four portals offers the passer-by an exotic weapon from a past visitor to this domain.");
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                if (HAS_ITEM(player, type, doMsgs, SWORDOFARES) || HAS_ITEM(player, type, doMsgs, BOWOFEOS) || HAS_ITEM(player, type, doMsgs, GAEASFLAIL) || HAS_ITEM(player, type, doMsgs, NEPTUNESTRIDENT)) {
                    SHOW_TEXT(player, type, doMsgs, "You cannot enter here, you already have one of the weapons of the Gods.");
                    BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
                }
                else {
                    SHOW_TEXT(player, type, doMsgs, "Enter, and claim one of the four artifacts for your reward. You may only have one!");
                    SHOW_TEXT(player, type, doMsgs, "Arm yourself with whichever artifact you choose before you challenge she who threatens the Gateway's existence.");
                    WallClear(player, type, doMsgs);
                }
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "Be off!! Only one Hero may enter here at a time!");
                BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
            }
        }
        protected override void FnEvent02(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HAS_ITEM(player, type, doMsgs, SWORDOFARES)) {
                AssaultTxt(player, type, doMsgs);
                TELEPORT(player, type, doMsgs, 12, 2, 68, NORTH);
            }
            else {
                AdvTxt(player, type, doMsgs);
                WallClear(player, type, doMsgs);
            }
        }
        protected override void FnEvent03(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HAS_ITEM(player, type, doMsgs, BOWOFEOS)) {
                AssaultTxt(player, type, doMsgs);
                TELEPORT(player, type, doMsgs, 12, 2, 64, NORTH);
            }
            else {
                AdvTxt(player, type, doMsgs);
                WallClear(player, type, doMsgs);
            }
        }
        protected override void FnEvent04(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HAS_ITEM(player, type, doMsgs, NEPTUNESTRIDENT)) {
                AssaultTxt(player, type, doMsgs);
                TELEPORT(player, type, doMsgs, 12, 2, 67, NORTH);
            }
            else {
                AdvTxt(player, type, doMsgs);
                WallClear(player, type, doMsgs);
            }
        }
        protected override void FnEvent05(TwPlayerServer player, MapEventType type, bool doMsgs) {
            PLACE_WALL_ITEM(player, type, doMsgs, PORTAL, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
            WallClear(player, type, doMsgs);
        }
        protected override void FnEvent06(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HAS_ITEM(player, type, doMsgs, GAEASFLAIL)) {
                AssaultTxt(player, type, doMsgs);
                TELEPORT(player, type, doMsgs, 12, 2, 65, NORTH);
            }
            else {
                AdvTxt(player, type, doMsgs);
                WallClear(player, type, doMsgs);
            }
        }
        protected override void FnEvent07(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short itemA = 0;
            switch (HERE(player, type, doMsgs)) {
                case 252:
                    itemA = GAEASFLAIL;
                    GaeasText(player, type, doMsgs);
                    break;
                case 234:
                    itemA = SWORDOFARES;
                    AresText(player, type, doMsgs);
                    break;
                case 203:
                    itemA = BOWOFEOS;
                    EosText(player, type, doMsgs);
                    break;
                case 221:
                    itemA = NEPTUNESTRIDENT;
                    NeptunesTxt(player, type, doMsgs);
                    break;
            }
            if (!HAS_ITEM(player, type, doMsgs, itemA)) {
                GIVE_ITEM(player, type, doMsgs, itemA);
            }
        }
        protected override void FnEvent08(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "WARNING: This will only take you back to the Keepers room. You must retrace your steps or take a different path to proceed from there.");
            TELEPORT(player, type, doMsgs, 12, 2, 0, EAST);
        }
        protected override void FnEvent0A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Pure Dissemination lies through this portal.");
            TELEPORT(player, type, doMsgs, 12, 1, 255, WEST);
        }
        protected override void FnEvent0B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, PARTY, LASTBATTLE) == 1) {
                SHOW_TEXT(player, type, doMsgs, "Before you, now mad with power and muttering spells upon spells, hovers Aeowyn. Using the Rings of Fate, she is trying to manipulate the Gateway of Immortality. Shaping its destination and purpose.");
                SHOW_TEXT(player, type, doMsgs, "She scorns you as you approach, 'FOOL! MORTAL! You were so easily subdued; so quick to crave the power I offered; you lost sight of yourself and succumbed to my desires.");
                SHOW_TEXT(player, type, doMsgs, "You shall learn the price of your ignorance! For only now, at the end do you understand. Had you kept the rings, had you breached the seal alone, then you may have had this power. But now, I WILL DESTROY YOU!'");
                SHOW_TEXT(player, type, doMsgs, "Aeowyn conjures four guardsmen to her aid, as well as summoning from their entombment, the five Dralkarians...");
                GET_MONSTER(player, type, doMsgs, 01, QUEENSGUARDONE);
                GET_MONSTER(player, type, doMsgs, 02, QUEENSGUARDTWO);
                GET_MONSTER(player, type, doMsgs, 03, QUEENSGUARDTHREE);
                GET_MONSTER(player, type, doMsgs, 04, QUEENSGUARDFOUR);
                GET_MONSTER(player, type, doMsgs, 05, DRAKSNUMBER);
                GET_MONSTER(player, type, doMsgs, 06, QUEENSNUMBER);
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "Guardians of the Gateway are summoned to its defense as you attempt to gain access to its secrets.");
                GET_MONSTER(player, type, doMsgs, 01, QUEENSGUARDONE);
                GET_MONSTER(player, type, doMsgs, 02, QUEENSGUARDTWO);
                GET_MONSTER(player, type, doMsgs, 03, QUEENSGUARDTHREE);
                GET_MONSTER(player, type, doMsgs, 04, QUEENSGUARDFOUR);
                GET_MONSTER(player, type, doMsgs, 05, DRAKSNUMBER);
            }
        }
        protected override void FnEvent0C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "An illusionary door fades away as you approach.");
            REMOVE_WALL_ITEM(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
            BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
        }
        protected override void FnEvent0D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short trap = 0;
            trap = GET_FLAG(player, type, doMsgs, PARTY, CASETRAP2);
            if (!GET_FLAG(player, type, doMsgs, ROOM, SPRUNGTRAP)) {
                switch (trap) {
                    case 1:
                        DAMAGE(player, type, doMsgs, HEALTH(player, type, doMsgs) / 3);
                        NoMapsZone(player, type, doMsgs);
                        NoSpellZone(player, type, doMsgs);
                        SHOW_TEXT(player, type, doMsgs, "Evil winds rip through you, mauling you horribly.");
                        trap++;
                        break;
                    case 2:
                        DAMAGE(player, type, doMsgs, HEALTH(player, type, doMsgs) - 2000);
                        SET_PM(player, type, doMsgs, POISON, 15, 100);
                        SHOW_TEXT(player, type, doMsgs, "Poisoned gas strangles you as it dissipates.");
                        trap++;
                        break;
                    case 3:
                        DAMAGE(player, type, doMsgs, HEALTH(player, type, doMsgs) / 4);
                        SHOW_TEXT(player, type, doMsgs, "A flash of magical light blinds you temporarily; causing you damage.");
                        trap++;
                        break;
                    case 4:
                        MOD_MANA(player, type, doMsgs,  - 2000);
                        while (HAS_ITEM(player, type, doMsgs, ZEUSSCROLL))
                            TAKE_ITEM(player, type, doMsgs, ZEUSSCROLL);
                            while (HAS_ITEM(player, type, doMsgs, SOVEREIGNSCROLL))
                                TAKE_ITEM(player, type, doMsgs, SOVEREIGNSCROLL);
                                SHOW_TEXT(player, type, doMsgs, "Mystical currents from an ancient snare steal from and damage you.");
                                trap++;
                                break;
                            case 5:
                                SHOW_TEXT(player, type, doMsgs, "A blast of fire greets you at this next snare.");
                                MOD_MANA(player, type, doMsgs,  - 200);
                                DAMAGE(player, type, doMsgs, MAX_HEALTH(player, type, doMsgs) / 4);
                                trap++;
                                break;
                            default:
                                DAMAGE(player, type, doMsgs, HEALTH(player, type, doMsgs) / 3);
                                NO_HEAL_ZONE(player, type, doMsgs);
                                trap = 1;
                                NoSpellZone(player, type, doMsgs);
                                SHOW_TEXT(player, type, doMsgs, "Evil laughter echoes off the walls as yet another snare harms you.");
                                break;
                        }
                        SET_FLAG(player, type, doMsgs, PARTY, CASETRAP2, trap);
                        SprungTrap(player, type, doMsgs);
                    }
                }
                protected override void FnEvent0E(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    if (!GET_FLAG(player, type, doMsgs, DUNGEON, WONTHISGAME)) {
                        SET_FLAG(player, type, doMsgs, DUNGEON, ENDGAMETELE, 2);
                        SHOW_TEXT(player, type, doMsgs, "You've defeated the Queen; preventing the her from threatening all the Portals that interconnect throughout this world and others.");
                        SHOW_TEXT(player, type, doMsgs, "Now, take these boosts to your attributes and to your wealths of knowledge and gold. You have restored the system to its rightful balance.");
                        SHOW_TEXT(player, type, doMsgs, "In time, when you are ready, the portal will grant you access to new planes of existence! But that, is another story...");
                        SET_FLAG(player, type, doMsgs, DUNGEON, WONTHISGAME, 1);
                        SET_FLAG(player, type, doMsgs, DUNGEON, WINNER, 1);
                        MOD_EXP(player, type, doMsgs, 7500000);
                        MOD_GOLD(player, type, doMsgs, 2000000);
                        MOD_STAT(player, type, doMsgs, STRENGTH, 3);
                        MOD_STAT(player, type, doMsgs, AGILITY, 3);
                        MOD_STAT(player, type, doMsgs, DEFENSE, 3);
                        MOD_STAT(player, type, doMsgs, INITIATIVE, 3);
                        if (GUILD(player, type, doMsgs) != WIZARD) {
                            SHOW_TEXT(player, type, doMsgs, "You are bestowed with a new spell!");
                            GIVE_SPELL(player, type, doMsgs, DEATH_DARTS_SPELL, 6);
                        }
                        else {
                            SHOW_TEXT(player, type, doMsgs, "Mighty sorcerer, gain knowledge to control life from death.");
                            GIVE_SPELL(player, type, doMsgs, RESUSCITATE_SPELL, 6);
                        }
                    }
                    else {
                        SHOW_TEXT(player, type, doMsgs, "The portal glows with power. You may enter it now, but it will not take you to your true destination yet.");
                        SHOW_TEXT(player, type, doMsgs, "The future has taken root in the present. All will be explained... with Yserbius III!!%%");
                    }
                }
                protected override void FnEvent0F(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    SHOW_TEXT(player, type, doMsgs, "Here you must go, but only after you've retrieved one of the mystic artifacts that travelers of this portal have left as gifts.");
                    TELEPORT(player, type, doMsgs, 12, 2, 232, SOUTH);
                }
                protected override void FnEvent10(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    NO_JOIN(player, type, doMsgs);
                }
                protected override void FnEvent12(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    short i = 0;
                    special21(player, type, doMsgs);
                    if (GET_FLAG(player, type, doMsgs, PARTY, STORMGIANT) != HERE(player, type, doMsgs)) {
                        if (PARTY_COUNT(player, type, doMsgs) == 1) {
                            SHOW_TEXT(player, type, doMsgs, "An ominous force stands before you!");
                            if (HAS_ITEM(player, type, doMsgs, STATUEOFSTORMGIANT) && GET_FLAG(player, type, doMsgs, PARTY, IMHERE) != HERE(player, type, doMsgs) && !GET_FLAG(player, type, doMsgs, DUNGEON, ONLYONCE)) {
                                WallClear(player, type, doMsgs);
                                SET_FLAG(player, type, doMsgs, DUNGEON, ONLYONCE, 1);
                                SHOW_TEXT(player, type, doMsgs, "Using one of the mystical statues, you turn into a Storm Giant and kill them all!");
                                MOD_GOLD(player, type, doMsgs, 10000);
                                GIVE_ITEM(player, type, doMsgs, PHOSPHORESCENTBLADE);
                                GIVE_ITEM(player, type, doMsgs, HEALAMPHORA);
                                GIVE_ITEM(player, type, doMsgs, ZEUSSCROLL);
                                SET_FLAG(player, type, doMsgs, PARTY, IMHERE, HERE(player, type, doMsgs));
                            }
                        }
                        else if (GET_FLAG(player, type, doMsgs, PARTY, IMHERE) != HERE(player, type, doMsgs)) {
                            SHOW_TEXT(player, type, doMsgs, "Had you been alone and with their talisman, you may have stood a chance!");
                            for (i = 1; i <= 4; i++) {
                                GET_MONSTER(player, type, doMsgs, i, STORMGIANTS);
                            }
                            SET_FLAG(player, type, doMsgs, PARTY, IMHERE, HERE(player, type, doMsgs));
                        }
                        SET_FLAG(player, type, doMsgs, PARTY, STORMGIANT, HERE(player, type, doMsgs));
                    }
                }
                protected override void FnEvent15(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    NO_MAPS(player, type, doMsgs);
                    if (!GET_FLAG(player, type, doMsgs, ROOM, SPRUNGTRAP)) {
                        switch (FACING(player, type, doMsgs)) {
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
                protected override void FnEvent16(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    NO_MAPS(player, type, doMsgs);
                    if (!GET_FLAG(player, type, doMsgs, ROOM, SPRUNGTRAP)) {
                        switch (FACING(player, type, doMsgs)) {
                            case NORTH:
                                ROTATE(player, type, doMsgs, SOUTH);
                                ROTATE(player, type, doMsgs, WEST);
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
                                TELEPORT(player, type, doMsgs, 12, 2, HERE(player, type, doMsgs), EAST);
                                SprungTrap(player, type, doMsgs);
                                break;
                        }
                    }
                }
                protected override void FnEvent17(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    NO_MAPS(player, type, doMsgs);
                    NoSpellZone(player, type, doMsgs);
                    NO_JOIN(player, type, doMsgs);
                    if (PARTY_COUNT(player, type, doMsgs) == 1) {
                        if (!GET_FLAG(player, type, doMsgs, DUNGEON, KILLEDQUEEN)) {
                            SHOW_TEXT(player, type, doMsgs, "Those who hath not faced the mad Queen must lead, lest your efforts are futile. You are one that may lead!");
                            SET_FLAG(player, type, doMsgs, PARTY, LASTBATTLE, 1);
                            TELEPORT(player, type, doMsgs, 12, 2, 104, EAST);
                        }
                        else {
                            SHOW_TEXT(player, type, doMsgs, "You have already defeated the Queen, you cannot face that which is no more.");
                            SET_FLAG(player, type, doMsgs, PARTY, LASTBATTLE, 0);
                            TELEPORT(player, type, doMsgs, 12, 2, 104, EAST);
                        }
                    }
                    else {
                        SHOW_TEXT(player, type, doMsgs, "Step forth ALONE!");
                        TELEPORT(player, type, doMsgs, 12, 2, 119, NORTH);
                    }
                }
                protected override void FnEvent19(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    if (!GET_FLAG(player, type, doMsgs, PARTY, KEEPER)) {
                        SHOW_TEXT(player, type, doMsgs, "The statue of an ancient guardian greets you here. It writhes to life as you approach: 'Hail to thee! I am Chrysagorn, Keeper of the Portal and Servant to the Fates.");
                        SHOW_TEXT(player, type, doMsgs, "I have been imprisoned here in granite by the mad Queen! Her powers are farther reaching than you dare imagine. With the five rings, she is now trying to gain control of the Gateway.");
                        SHOW_TEXT(player, type, doMsgs, "I cannot defend the Gate from her powers, you must destroy her or all of time shall fold in upon itself. Our fate will be sealed in oblivion's tomb.'");
                        SHOW_TEXT(player, type, doMsgs, "The statue begins to crumble as you watch, 'Go! defeat her! I can no longer protect...' but its too late, the statue explodes into dust flying across the room and damaging you.");
                        DAMAGE(player, type, doMsgs, HEALTH(player, type, doMsgs) / 5);
                        SET_FLAG(player, type, doMsgs, PARTY, KEEPER, 1);
                    }
                }
                protected override void FnEvent1A(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    BLOCK_FLOOR(player, type, doMsgs, HERE(player, type, doMsgs));
                }
                protected override void FnEvent1F(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    short i = 0;
                    SHOW_TEXT(player, type, doMsgs, "Eos' servants form from the morning mists which permeate this place.");
                    for (i = 1; i <= 2; i++) {
                        GET_MONSTER(player, type, doMsgs, i, EOSBATTLE);
                    }
                }
                protected override void FnEvent20(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    short i = 0;
                    SHOW_TEXT(player, type, doMsgs, "Descendents of Gaea rise from the earthen floor to challenge you!");
                    for (i = 1; i <= 2; i++) {
                        GET_MONSTER(player, type, doMsgs, i, GAEABATTLE);
                    }
                }
                protected override void FnEvent21(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    short i = 0;
                    SHOW_TEXT(player, type, doMsgs, "Ancient servants of Neptune rise from the waters and bar your way!");
                    for (i = 1; i <= 2; i++) {
                        GET_MONSTER(player, type, doMsgs, i, NEPTUNEBATTLE);
                    }
                }
                protected override void FnEvent22(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    short i = 0;
                    SHOW_TEXT(player, type, doMsgs, "Masters of Warfare, students of Ares, ambush you!");
                    for (i = 1; i <= 2; i++) {
                        GET_MONSTER(player, type, doMsgs, i, ARESBATTLE);
                    }
                }
                protected override void FnEvent23(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    SET_STATE(player, type, doMsgs, 0);
                }
                protected override void FnEvent24(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    short i = 0;
                    if (STATE(player, type, doMsgs) != HERE(player, type, doMsgs)) {
                        SET_STATE(player, type, doMsgs, HERE(player, type, doMsgs));
                        switch (PARTY_COUNT(player, type, doMsgs)) {
                            case 1:
                                GET_MONSTER(player, type, doMsgs, 01, HALLGUARD1);
                                GET_MONSTER(player, type, doMsgs, 02, HALLGUARD1);
                                break;
                            case 2:
                                for (i = 1; i <= 3; i++) {
                                    GET_MONSTER(player, type, doMsgs, i, HALLGUARD1);
                                }
                                break;
                            default:
                                for (i = 1; i <= 5; i++) {
                                    GET_MONSTER(player, type, doMsgs, i, HALLGUARD1);
                                }
                                break;
                        }
                    }
                }
                protected override void FnEvent25(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    if (!GET_FLAG(player, type, doMsgs, DUNGEON, HALLOFDOOM)) {
                        SET_FLAG(player, type, doMsgs, DUNGEON, HALLOFDOOM, 1);
                    }
                    SHOW_TEXT(player, type, doMsgs, "This enormous hallway is adorned with precious jewels and artworks in every crevice. Golden statues in the images of greater deities and gods who hath passed this way line either side of the hall.");
                    SHOW_TEXT(player, type, doMsgs, "A challenge of outrageous proportions guards this passageway before you. Northward, two rows of beasts and man stand as guardians to the ultimate Gateway.");
                }
                protected override void FnEvent26(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    short i = 0;
                    if (STATE(player, type, doMsgs) != HERE(player, type, doMsgs)) {
                        SET_STATE(player, type, doMsgs, HERE(player, type, doMsgs));
                        switch (PARTY_COUNT(player, type, doMsgs)) {
                            case 1:
                                GET_MONSTER(player, type, doMsgs, 01, HALLGUARD2);
                                GET_MONSTER(player, type, doMsgs, 02, HALLGUARD2);
                                break;
                            case 2:
                                for (i = 1; i <= 3; i++) {
                                    GET_MONSTER(player, type, doMsgs, i, HALLGUARD2);
                                }
                                break;
                            default:
                                for (i = 1; i <= 5; i++) {
                                    GET_MONSTER(player, type, doMsgs, i, HALLGUARD2);
                                }
                                break;
                        }
                    }
                }
                protected override void FnEvent27(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    if (USED_ITEM(player, type, doMsgs, NEPTUNESTRIDENT, NEPTUNESTRIDENT)) {
                        SHOW_TEXT(player, type, doMsgs, "The lava before you swirls into a wading pool! Neptune himself has used such power to bypass these foul snares.");
                        ClearMe(player, type, doMsgs);
                    }
                    else if (USED_ITEM(player, type, doMsgs, GAEASFLAIL, GAEASFLAIL)) {
                        SHOW_TEXT(player, type, doMsgs, "The lava hardens into solid rock! Gaea herself has used such powers to pass safely by such traps!");
                        ClearMe(player, type, doMsgs);
                    }
                    else if (USED_ITEM(player, type, doMsgs, BOWOFEOS, BOWOFEOS)) {
                        SHOW_TEXT(player, type, doMsgs, "Dawn's light shines bright upon the bow forming a golden arch across the lava!");
                        ClearMe(player, type, doMsgs);
                    }
                    else if (USED_ITEM(player, type, doMsgs, SWORDOFARES, SWORDOFARES)) {
                        SHOW_TEXT(player, type, doMsgs, "The sword summons a powerful Ice Elemental! The elemental sinks into the lava, quenching the raging war between fire and ice!");
                        ClearMe(player, type, doMsgs);
                    }
                    else if (USED_ITEM(player, type, doMsgs, SHORTSWORD, UNITYRING)) {
                        SHOW_TEXT(player, type, doMsgs, "The lava resumes its form.");
                        SET_FLAG(player, type, doMsgs, PARTY, USEDNEPTRI, 0);
                    }
                    else {
                        SHOW_TEXT(player, type, doMsgs, "A vile pool of molten lava bubbles violently before you. You must find a way to alter this pool of sure death.");
                    }
                }
                private void ClearMe(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    SET_FLAG(player, type, doMsgs, PARTY, USEDNEPTRI, 1);
                    switch (HERE(player, type, doMsgs)) {
                        case 160:
                        case 192:
                            CLEAR_FLOOR(player, type, doMsgs, 176);
                            PLACE_FLOOR_ITEM(player, type, doMsgs, WATER, 176);
                            break;
                        default:
                            CLEAR_FLOOR(player, type, doMsgs, 85);
                            PLACE_FLOOR_ITEM(player, type, doMsgs, WATER, 85);
                            break;
                    }
                }
                protected override void FnEvent28(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    if (GET_FLAG(player, type, doMsgs, PARTY, USEDNEPTRI) == 1) {
                        SHOW_TEXT(player, type, doMsgs, "The magic sustains the pool, allowing you to safely pass.");
                    }
                    else {
                        SHOW_TEXT(player, type, doMsgs, "The lava scorches and torments your body. The magical fluids then hurl you across the maze...");
                        DAMAGE(player, type, doMsgs, HEALTH(player, type, doMsgs) - 100);
                        TELEPORT(player, type, doMsgs, 12, 2, 191, SOUTH);
                    }
                }
                protected override void FnEvent29(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    short i = 0;
                    if (STATE(player, type, doMsgs) != HERE(player, type, doMsgs)) {
                        SET_STATE(player, type, doMsgs, HERE(player, type, doMsgs));
                        switch (PARTY_COUNT(player, type, doMsgs)) {
                            case 1:
                                GET_MONSTER(player, type, doMsgs, 01, HALLGUARD3);
                                GET_MONSTER(player, type, doMsgs, 02, HALLGUARD3);
                                break;
                            case 2:
                                for (i = 1; i <= 3; i++) {
                                    GET_MONSTER(player, type, doMsgs, i, HALLGUARD3);
                                }
                                break;
                            default:
                                for (i = 1; i <= 5; i++) {
                                    GET_MONSTER(player, type, doMsgs, i, HALLGUARD3);
                                }
                                break;
                        }
                    }
                }
                protected override void FnEvent2A(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    short i = 0;
                    if (STATE(player, type, doMsgs) != HERE(player, type, doMsgs)) {
                        SET_STATE(player, type, doMsgs, HERE(player, type, doMsgs));
                        switch (PARTY_COUNT(player, type, doMsgs)) {
                            case 1:
                                GET_MONSTER(player, type, doMsgs, 01, HALLGUARD4);
                                GET_MONSTER(player, type, doMsgs, 02, HALLGUARD4);
                                break;
                            case 2:
                                for (i = 1; i <= 3; i++) {
                                    GET_MONSTER(player, type, doMsgs, i, HALLGUARD4);
                                }
                                break;
                            default:
                                for (i = 1; i <= 5; i++) {
                                    GET_MONSTER(player, type, doMsgs, i, HALLGUARD4);
                                }
                                break;
                        }
                    }
                }
                protected override void FnEvent2B(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    short i = 0;
                    if (STATE(player, type, doMsgs) != HERE(player, type, doMsgs)) {
                        SET_STATE(player, type, doMsgs, HERE(player, type, doMsgs));
                        switch (PARTY_COUNT(player, type, doMsgs)) {
                            case 1:
                                GET_MONSTER(player, type, doMsgs, 01, HALLGUARD5);
                                GET_MONSTER(player, type, doMsgs, 02, HALLGUARD5);
                                break;
                            case 2:
                                for (i = 1; i <= 3; i++) {
                                    GET_MONSTER(player, type, doMsgs, i, HALLGUARD5);
                                }
                                break;
                            default:
                                for (i = 1; i <= 5; i++) {
                                    GET_MONSTER(player, type, doMsgs, i, HALLGUARD5);
                                }
                                break;
                        }
                    }
                }
                protected override void FnEvent2C(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    if (!GET_FLAG(player, type, doMsgs, PARTY, IHAVETHEFLAIL)) {
                        if (USED_ITEM(player, type, doMsgs, GAEASFLAIL, GAEASFLAIL)) {
                            SHOW_TEXT(player, type, doMsgs, "The pit before you congeals into a solid earthen floor! Gaea's power is obvious concerning the nature of things.");
                            SET_FLAG(player, type, doMsgs, PARTY, USEDGAEAFLAIL, 1);
                            switch (HERE(player, type, doMsgs)) {
                                case 23:
                                case 55:
                                    CLEAR_FLOOR(player, type, doMsgs, 39);
                                    PLACE_FLOOR_ITEM(player, type, doMsgs, NO_OBJECT, 39);
                                    break;
                            }
                        }
                        else if (USED_ITEM(player, type, doMsgs, SHORTSWORD, UNITYRING)) {
                            SHOW_TEXT(player, type, doMsgs, "The pit remains open.");
                            SET_FLAG(player, type, doMsgs, PARTY, USEDGAEAFLAIL, 0);
                        }
                        else {
                            SHOW_TEXT(player, type, doMsgs, "An eerie black pit stretches deep into the earth here. Echoes of your every sound are barely audible whispers by the time they return.");
                        }
                    }
                }
                protected override void FnEvent2D(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    if (!GET_FLAG(player, type, doMsgs, PARTY, IHAVETHEFLAIL)) {
                        if (GET_FLAG(player, type, doMsgs, PARTY, USEDGAEAFLAIL) == 1) {
                            SHOW_TEXT(player, type, doMsgs, "The flail keeps the earth intact, allowing you to safely pass.");
                        }
                        else {
                            SHOW_TEXT(player, type, doMsgs, "The pit swallows you whole, this magical snare does not kill you, however, but you are swept away through the maze.");
                            DAMAGE(player, type, doMsgs, HEALTH(player, type, doMsgs) - 100);
                            TELEPORT(player, type, doMsgs, 12, 2, 222, EAST);
                        }
                    }
                }
                protected override void FnEvent2E(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    if (!HAS_ITEM(player, type, doMsgs, GAEASFLAIL)) {
                        SET_FLAG(player, type, doMsgs, PARTY, IHAVETHEFLAIL, 1);
                    }
                }
                protected override void FnEvent32(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    SHOW_TEXT(player, type, doMsgs, "An ancient portal carved of pure magic and wrought with precious gemstones stands guard here.");
                    if (PARTY_COUNT(player, type, doMsgs) == 1) {
                        if ((GET_FLAG(player, type, doMsgs, DUNGEON, HALLOFDOOM) == 1) && (HAS_ITEM(player, type, doMsgs, SWORDOFARES) || HAS_ITEM(player, type, doMsgs, BOWOFEOS) || HAS_ITEM(player, type, doMsgs, GAEASFLAIL) || HAS_ITEM(player, type, doMsgs, NEPTUNESTRIDENT))) {
                            SHOW_TEXT(player, type, doMsgs, "The ancient crystals merge into a teleport, allowing you to gain quick access to the Gateway's heart.");
                            TELEPORT(player, type, doMsgs, 12, 2, 205, NORTH);
                        }
                        else {
                            SHOW_TEXT(player, type, doMsgs, "Here you will enter the ancient Gods' treasure room.");
                            TELEPORT(player, type, doMsgs, 12, 2, 219, SOUTH);
                        }
                    }
                    else {
                        SHOW_TEXT(player, type, doMsgs, "Be off!! Only one Hero may enter here at a time!");
                        ROTATE(player, type, doMsgs, EAST);
                    }
                }
                protected override void FnEvent33(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    SET_FLAG(player, type, doMsgs, DUNGEON, ONLYONCE, 0);
                    SHOW_TEXT(player, type, doMsgs, "From here you enter the heart of The Gateway.");
                    TELEPORT(player, type, doMsgs, 12, 2, 246, EAST);
                }
                protected override void FnEvent34(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    if (!HAS_ITEM(player, type, doMsgs, STATUEOFSTORMGIANT)) {
                        GIVE_ITEM(player, type, doMsgs, STATUEOFSTORMGIANT);
                        SHOW_TEXT(player, type, doMsgs, "You pick up an odd statue. Perhaps it will protect you when you are alone.");
                    }
                    switch (HERE(player, type, doMsgs)) {
                        case 238:
                            SHOW_TEXT(player, type, doMsgs, "A jeweled carving depicts a band of travelers journeying through an ancient dungeon in search of some great treasure.");
                            break;
                        case 222:
                            SHOW_TEXT(player, type, doMsgs, "This carving shows four ancient fragments brought unto themselves, forming some magical piece that allows access into a dark kingdom.");
                            break;
                        case 206:
                            SHOW_TEXT(player, type, doMsgs, "Here you see a myriad of images strewn across various puzzles and hordes of vile creatures that scorn the travelers as they seek the treasure.");
                            break;
                        case 190:
                            if (FLAG_ON(player, type, doMsgs, DUNGEON, KILLEDQUEEN)) {
                                SHOW_TEXT(player, type, doMsgs, "Emblazoned in the stones you see your own image slaying the mad Queen and eventually entering the mystical Gateway of Immortality.");
                            }
                            else {
                                SHOW_TEXT(player, type, doMsgs, "Shadowy, incoherent images flash across the stones as though some part of future history is yet to be completed.");
                            }
                            break;
                    }
                }
                protected override void FnEvent35(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    TELEPORT(player, type, doMsgs, 12, 2, 150, WEST);
                    SHOW_TEXT(player, type, doMsgs, "To the last pathway of challenge. From there you will ultimately meet your Fate.");
                }
                protected override void FnEvent36(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    NO_MAPS(player, type, doMsgs);
                }
                protected override void FnEvent37(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    if (!GET_FLAG(player, type, doMsgs, DUNGEON, FINISHEDGAME)) {
                        SET_FLAG(player, type, doMsgs, DUNGEON, FINISHEDGAME, 1);
                        SHOW_TEXT(player, type, doMsgs, "An eerie, shimmering portal hangs before you. This is the Gateway...the ingress into new adventures and future history.");
                        SHOW_TEXT(player, type, doMsgs, "You will come back here in time, when you feel you are ready for new challenges and greater travels. Until then, you must rest and restore your drained powers for that day.");
                        SHOW_TEXT(player, type, doMsgs, "There is a place, guarded by Shaddax, the Keeper, you must journey there and unravel the riddles placed in your path by some vile deity that inhabits another dimension.");
                        SHOW_TEXT(player, type, doMsgs, "That is your task for now, you may return here when time dictates! Go now, seek Shaddax...you may find the entrance through Dragon's Ire! Go, brave champion!");
                        TELEPORT(player, type, doMsgs, 1, 1, 3, SOUTH);
                    }
                    else {
                        SHOW_TEXT(player, type, doMsgs, "The portal is here; but the future is not yours to see...yet.");
                        TELEPORT(player, type, doMsgs, 1, 1, 3, SOUTH);
                    }
                }
                private void AdvTxt(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    SHOW_TEXT(player, type, doMsgs, "This portal will offer you no advancement without the proper artifact.");
                }
                private void AssaultTxt(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    SHOW_TEXT(player, type, doMsgs, "Through here you begin the final assault.");
                }
                private void WallClear(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
                }
                private void AresText(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    SHOW_TEXT(player, type, doMsgs, "Ares had visited this place many moons ago. As his mark, he left behind a legend that clever Night Elf craftsmen emblazoned with ancient runes upon this jeweled blade.");
                }
                private void NeptunesTxt(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    SHOW_TEXT(player, type, doMsgs, "Lord Neptune, Master of the Wind and the Sea, used this Trident to command the waters that now surround Twinion to swirl into fury; crashing down upon his enemies. Its power is now yours to borrow.");
                }
                private void GaeasText(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    SHOW_TEXT(player, type, doMsgs, "Gaea had exhausted herself in many travels, but her pleasures here have always been her favorite. She filled herself with energies and moved on to a new adventure via the Portal.");
                    SHOW_TEXT(player, type, doMsgs, "Her flail now remains as her mark, and is offered to you to defend the Portal from abuse.");
                }
                private void EosText(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    SHOW_TEXT(player, type, doMsgs, "Dawn shall come! Eos brings the sun, and the first arch of gold was wrought into this magnificent bow in honor of this goddess.");
                    SHOW_TEXT(player, type, doMsgs, "Now the Bow of Eos, shall be your light and guide past the snares that await you along the paths to the Portal.");
                }
                private void NoMapsZone(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    NO_MAPS(player, type, doMsgs);
                }
                private void NoSpellZone(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    NO_SPELL(player, type, doMsgs);
                }
                private void SprungTrap(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    SET_FLAG(player, type, doMsgs, ROOM, SPRUNGTRAP, 1);
                }
            }
        }
