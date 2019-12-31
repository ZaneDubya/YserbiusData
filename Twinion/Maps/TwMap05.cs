using XPT.Generic.Maps;
using XPT.Twinion.Entities;

namespace XPT.Twinion.Maps {
    class TwMap05 : TwMap {
        protected override int MapIndex => 5;
        protected override int MapID => 0x0203;
        protected override int RandomEncounterChance => 5;
        protected override int RandomEncounterExtraCount => 0;

        private const int PARTYTEXT = 1;
        private const int MADKNIGHT = 2;
        private const int SPRUNGTRAP = 1;
        protected override void FnEvent01(TwPlayerServer player, MapEventType type, bool doMsgs) {
            NO_HEAL_ZONE(player, type, doMsgs);
            if ((GET_FLAG(player, type, doMsgs, ROOM, SPRUNGTRAP) == 0)) {
                if ((GET_FLAG(player, type, doMsgs, DUNGEON, KILLEDAQUEUS) == 0)) {
                    SHOW_TEXT(player, type, doMsgs, "The strong currents twist and pound your body.");
                    DAMAGE(player, type, doMsgs, MAX_HEALTH(player, type, doMsgs) / 8 + 1);
                    if (HEALTH(player, type, doMsgs) <= 0) {
                        SHOW_TEXT(player, type, doMsgs, "You have been drowned by the force.");
                    }
                }
                else {
                    SHOW_TEXT(player, type, doMsgs, "You've defeated Aqueus! You may travel safely through these waters.");
                }
                SET_FLAG(player, type, doMsgs, ROOM, SPRUNGTRAP, 1);
            }
        }
        protected override void FnEvent02(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "The central Aqueduct lies through the east door.");
            TELEPORT(player, type, doMsgs, 2, 1, 160, EAST);
        }
        protected override void FnEvent03(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You have moved the column enough to squeeze by...but now you're not sure that was so wise.");
            CLEAR_FLOOR(player, type, doMsgs, HERE(player, type, doMsgs));
        }
        protected override void FnEvent04(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Churning magic pulls water from below and dumps it here. The thundering noise is painful.");
            SHOW_TEXT(player, type, doMsgs, "You feel you have acted unwisely...and you are proven correct as the force slams you against a very hard southern wall...");
            DAMAGE(player, type, doMsgs, MAX_HEALTH(player, type, doMsgs) / 2);
            if (HEALTH(player, type, doMsgs) <= 0) {
                SHOW_TEXT(player, type, doMsgs, "And kills you.");
                EXIT_DUNGEON(player, type, doMsgs);
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "And wounds you severely.");
                TELEPORT(player, type, doMsgs, 2, 3, 201, SOUTH);
            }
        }
        protected override void FnEvent05(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GET_FLAG(player, type, doMsgs, ROOM, SPRUNGTRAP) == 0)) {
                if (PARTY_COUNT(player, type, doMsgs) == 1) {
                    if (GET_FLAG(player, type, doMsgs, DUNGEON, LEARNEDCHANT) == 1) {
                        SHOW_TEXT(player, type, doMsgs, "Reciting the chant the old giant taught you causes the waters to part and allows you to proceed.");
                        CLEAR_FLOOR(player, type, doMsgs, HERE(player, type, doMsgs));
                        PLACE_FLOOR_ITEM(player, type, doMsgs, 0, HERE(player, type, doMsgs));
                    }
                    else {
                        SHOW_TEXT(player, type, doMsgs, "The powerful currents here dash you repeatedly against the rocky shore...");
                        SHOW_TEXT(player, type, doMsgs, "...and kill you.");
                        DAMAGE(player, type, doMsgs, MAX_HEALTH(player, type, doMsgs));
                        EXIT_DUNGEON(player, type, doMsgs);
                    }
                }
                else {
                    SHOW_TEXT(player, type, doMsgs, "The narrows here must be passed by only one of you at a time.");
                    TELEPORT(player, type, doMsgs, 2, 3, 73, NORTH);
                }
                SET_FLAG(player, type, doMsgs, ROOM, SPRUNGTRAP, 1);
            }
        }
        protected override void FnEvent06(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "The violent currents of a whirlpool drag you under the water, carrying you helplessly eastward.");
            TELEPORT(player, type, doMsgs, 2, 3, 143, EAST);
        }
        protected override void FnEvent07(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_RUNES(player, type, doMsgs, "To one of three.");
            TELEPORT(player, type, doMsgs, 2, 3, 226, NORTH);
        }
        protected override void FnEvent08(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_RUNES(player, type, doMsgs, "To two of three.");
            TELEPORT(player, type, doMsgs, 2, 3, 130, SOUTH);
        }
        protected override void FnEvent09(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_RUNES(player, type, doMsgs, "To three of three.");
            TELEPORT(player, type, doMsgs, 2, 3, 34, SOUTH);
        }
        protected override void FnEvent0A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Gateway back to this level's entrance.");
            TELEPORT(player, type, doMsgs, 2, 3, 175, EAST);
        }
        protected override void FnEvent0B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (USED_SKILL(player, type, doMsgs, DETECT_SKILL) >= 6 || USED_SPELL(player, type, doMsgs, TRUE_SEEING_SPELL) || USED_ITEM(player, type, doMsgs, HELMOFWISDOM, HELMOFWISDOM) || USED_ITEM(player, type, doMsgs, VALKYRIESHELM, VALKYRIESHELM) || USED_ITEM(player, type, doMsgs, RINGOFTHIEVES, RINGOFTHIEVES) || USED_ITEM(player, type, doMsgs, CRYSTALBALL, CRYSTALBALL)) {
                SHOW_TEXT(player, type, doMsgs, "Aha! A secret door!");
                PlaceDoor(player, type, doMsgs);
                WallClear(player, type, doMsgs);
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "There are scratches in the stones here.");
                WallBlock(player, type, doMsgs);
            }
        }
        protected override void FnEvent0C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "'WARNING: Area under construction. Caution must be observed when exploring the reservoir.'");
            SHOW_TEXT(player, type, doMsgs, " - Aeowyn, Queen of Twinion.");
        }
        protected override void FnEvent0D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Three teleports, three choices.");
            SHOW_RUNES(player, type, doMsgs, "I'm not telling you which ONE to choose.");
        }
        protected override void FnEvent0E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "'Will you never listen?'");
            SHOW_TEXT(player, type, doMsgs, "'Perhaps an old friend can help you cross the perilous waters to the northeast.'");
        }
        protected override void FnEvent0F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, DUNGEON, KILAM) == 1) {
                SHOW_TEXT(player, type, doMsgs, "This is a very stubborn door. You rap your fists on it, but to no avail.");
                SET_FLAG(player, type, doMsgs, DUNGEON, KILAM, 2);
            }
            else if (GET_FLAG(player, type, doMsgs, DUNGEON, KILAM) == 2) {
                SHOW_TEXT(player, type, doMsgs, "You again knock on the door in the hopes that something will open it.");
                SET_FLAG(player, type, doMsgs, DUNGEON, KILAM, 3);
            }
            else if (GET_FLAG(player, type, doMsgs, DUNGEON, KILAM) == 3) {
                SHOW_TEXT(player, type, doMsgs, "As you knock a third time, the door opens just as Kilam said it would!");
                PlaceDoor(player, type, doMsgs);
                WallClear(player, type, doMsgs);
            }
            else {
                WallBlock(player, type, doMsgs);
                PlaceDoor(player, type, doMsgs);
                SHOW_TEXT(player, type, doMsgs, "The door seems to be locked, but there's no lock to pick.");
            }
        }
        protected override void FnEvent10(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, DUNGEON, LEARNEDRHYME) == 1) {
                SHOW_TEXT(player, type, doMsgs, "The magic that bars the gate dissipates, allowing you access.");
                WallClear(player, type, doMsgs);
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "The Giant's chant doesn't work here. Perhaps you must learn a new chant from him.");
                WallBlock(player, type, doMsgs);
            }
        }
        protected override void FnEvent11(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "A high-vaulted ceiling stretches into darkness while the deafening roar of the water fills this chasm of a reservoir.");
            SHOW_TEXT(player, type, doMsgs, "To the northeast a spot of land is barely visible. To the northwest stretch the many pools of this eternal reservoir.");
        }
        protected override void FnEvent12(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "A magical force pumps the river into the reservoir. The noise is overpowering.");
        }
        protected override void FnEvent13(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You can barely make out four large columns in the center of the reservoir; they surround what seems to be the origin of the deafening noise.");
        }
        protected override void FnEvent14(TwPlayerServer player, MapEventType type, bool doMsgs) {
            PLACE_FLOOR_ITEM(player, type, doMsgs, WATER, 75);
            if ((GET_FLAG(player, type, doMsgs, DUNGEON, PARTYTEXT) == 0)) {
                SHOW_TEXT(player, type, doMsgs, "You've reached the other side of the reservoir.");
                if ((GET_FLAG(player, type, doMsgs, DUNGEON, SAVEDPARTY) == 0)) {
                    SHOW_TEXT(player, type, doMsgs, "Peering back towards the distant shore, you see a small party struggling near the pump in the center.");
                    SHOW_TEXT(player, type, doMsgs, "Perhaps you could go help them.");
                    SET_FLAG(player, type, doMsgs, PARTY, PARTYTEXT, 1);
                }
            }
        }
        protected override void FnEvent15(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, DUNGEON, ENDGAMETELE) == 1) {
                if (PARTY_COUNT(player, type, doMsgs) == 1) {
                    SHOW_TEXT(player, type, doMsgs, "Enter now. Your destiny awaits.");
                    TELEPORT(player, type, doMsgs, 2, 3, 210, NORTH);
                }
                else {
                    SHOW_TEXT(player, type, doMsgs, "You must be alone.");
                    if ((GET_FLAG(player, type, doMsgs, ROOM, SPRUNGTRAP) == 0)) {
                        ROTATE(player, type, doMsgs, EAST);
                        SprungTrap(player, type, doMsgs);
                    }
                }
            }
            else {
                FnEvent18(player, type, doMsgs);
                WallBlock(player, type, doMsgs);
            }
        }
        protected override void FnEvent16(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                SHOW_TEXT(player, type, doMsgs, "Now, through the north gateway! Be quick!");
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "I warned you to come alone!");
                DAMAGE(player, type, doMsgs, MAX_HEALTH(player, type, doMsgs) / 3);
                TELEPORT(player, type, doMsgs, 2, 3, 44, EAST);
            }
        }
        protected override void FnEvent17(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, DUNGEON, ENDGAMETELE) == 1) {
                SHOW_TEXT(player, type, doMsgs, "To the next nexus point.");
                TELEPORT(player, type, doMsgs, 3, 2, 0, SOUTH);
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "Treacherous fool...die in vain!");
                WallBlock(player, type, doMsgs);
                DAMAGE(player, type, doMsgs, MAX_HEALTH(player, type, doMsgs));
                EXIT_DUNGEON(player, type, doMsgs);
            }
        }
        protected override void FnEvent18(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You see another dazzling carving, similar to the one in some maze above.");
        }
        protected override void FnEvent19(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int itemA = 0;
            int itemB = 0;
            int itemC = 0;
            int i = 0;
            if ((GET_FLAG(player, type, doMsgs, DUNGEON, KILLEDAQUEUS) == 0)) {
                SHOW_TEXT(player, type, doMsgs, "A gold throne sits to the north; to reach it you need only defeat he who guards it!");
                SHOW_TEXT(player, type, doMsgs, "Lord Aqueus, an enormous giant, rises from his throne bellowing, 'You are no match for me, the Aqueduct's guardian.");
                SHOW_TEXT(player, type, doMsgs, "Come, let me teach you the price of ignorance!'");
                switch (GUILD(player, type, doMsgs)) {
                    case BARBARIAN:
                        itemA = BATTLEAXE;
                        itemB = SILVERBAR;
                        itemC = BREASTPLATE;
                        break;
                    case KNIGHT:
                        itemA = MORNINGSTAR;
                        itemB = ICESHIELD;
                        itemC = SILVERBAR;
                        break;
                    case RANGER:
                        itemA = SILVERBOW;
                        itemB = BERSERKERTALISMAN;
                        itemC = BLOODSHIELD;
                        break;
                    case THIEF:
                        itemA = VORANTISGAUNTLETS;
                        itemB = MEDITATIONCAP;
                        itemC = SACKCLOTHJACKET;
                        break;
                    case CLERIC:
                        itemA = NUNCHUKAS;
                        itemB = BLOODSHIELD;
                        itemC = SILVERBAR;
                        break;
                    case WIZARD:
                        itemA = HANDSOFTHEMAGI;
                        itemB = SACKCLOTHJACKET;
                        itemC = JADEDRING;
                        break;
                }
                SET_BOOTY(player, type, doMsgs, itemA, itemB, itemC, 0, 0, 2500);
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "Aqueus' successor rises to the challenge!");
                SET_BOOTY(player, type, doMsgs, HEALPOTION, HAWKSEYE, 0, 0, 0, 300);
            }
            switch (PARTY_COUNT(player, type, doMsgs)) {
                case 1:
                    GET_MONSTER(player, type, doMsgs, 01, 40);
                    break;
                case 2:
                    SHOW_TEXT(player, type, doMsgs, "Servants rush to his aide!");
                    GET_MONSTER(player, type, doMsgs, 01, 29);
                    GET_MONSTER(player, type, doMsgs, 02, 28);
                    GET_MONSTER(player, type, doMsgs, 06, 40);
                    break;
                default:
                    SHOW_TEXT(player, type, doMsgs, "Servants rush to his aide!");
                    for (i = 1; i <= 4; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 29);
                    }
                    GET_MONSTER(player, type, doMsgs, 5, 40);
                    break;
            }
        }
        protected override void FnEvent1A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, HILLGIANT);
            if (GET_FLAG(player, type, doMsgs, DUNGEON, LEARNEDCHANT) == 1) {
                if (GET_FLAG(player, type, doMsgs, DUNGEON, METJUBILAH) == 1) {
                    SHOW_TEXT(player, type, doMsgs, "Sartiq speaks again, 'Now you must learn the Rhyme. With it you may enter his throne room.'");
                    SHOW_TEXT(player, type, doMsgs, "Again the giant probes your mind, depositing a ritual chant to be used later.");
                    SHOW_TEXT(player, type, doMsgs, "'FACE HIM! DEFEAT HIM! AVENGE ME!!'");
                    SHOW_TEXT(player, type, doMsgs, "With that outburst, the last bit of life seeps from Sartiq's body.");
                    SET_FLAG(player, type, doMsgs, DUNGEON, LEARNEDRHYME, 1);
                    SET_FLAG(player, type, doMsgs, DUNGEON, METJUBILAH, 2);
                }
                else {
                    SHOW_TEXT(player, type, doMsgs, "'Leave me for now. Search for Malik south of here!'");
                }
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "An ancient, dying giant motions you to move closer.");
                SHOW_TEXT(player, type, doMsgs, "'Hear me, whoever you are.  Aqueus is across the reservoir, to the northeast.");
                SHOW_TEXT(player, type, doMsgs, "Listen to my chant, it will be useful!'");
                SHOW_TEXT(player, type, doMsgs, "Sartiq uses his magic to burn the chant into your mind.");
                SHOW_TEXT(player, type, doMsgs, "'The waters which guard his throne room will part with this ritual chant! All you need do is approach them!'");
                SET_FLAG(player, type, doMsgs, DUNGEON, LEARNEDCHANT, 1);
            }
        }
        protected override void FnEvent1B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int where = 0;
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                if ((GET_FLAG(player, type, doMsgs, DUNGEON, SAVEDPARTY) == 0)) {
                    SHOW_PICTURE(player, type, doMsgs, DWARFKNIGHT);
                    SHOW_TEXT(player, type, doMsgs, "A weary party fights the torrential waters nearby.");
                    SHOW_TEXT(player, type, doMsgs, "'You! Yes, you! Come, help us. Help!!!'");
                    SHOW_TEXT(player, type, doMsgs, "There must be something you can use to help them.");
                    if (USED_ITEM(player, type, doMsgs, ROPE, ROPE)) {
                        SHOW_TEXT(player, type, doMsgs, "By repeatedly tossing one end of the rope to the party, you manage to pull them one by one to safety.");
                        SHOW_TEXT(player, type, doMsgs, "When the last one is rescued, you fall back, exhausted.");
                        SHOW_TEXT(player, type, doMsgs, "The leader approaches: 'Hail, friend! We would surely have drowned in these torrents had it not been for your timely arrival.");
                        SHOW_TEXT(player, type, doMsgs, "Sorry you lost your rope in the waters.");
                        SHOW_TEXT(player, type, doMsgs, "Take these gifts as our gratitude. Hail`'");
                        SHOW_TEXT(player, type, doMsgs, "You feel wiser and wealthier.");
                        GIVE_ITEM(player, type, doMsgs, LONGSWORD);
                        GIVE_ITEM(player, type, doMsgs, SILVERBAR);
                        TAKE_ITEM(player, type, doMsgs, ROPE);
                        MOD_GOLD(player, type, doMsgs, 2000);
                        MOD_EXP(player, type, doMsgs, 2000);
                        SET_FLAG(player, type, doMsgs, DUNGEON, SAVEDPARTY, 1);
                    }
                    else if (USED_ITEM(player, type, doMsgs, SHORTSWORD, KEYOFC) || USED_ITEM(player, type, doMsgs, LIFEJACKET, UNITYRING)) {
                        SHOW_TEXT(player, type, doMsgs, "Your efforts are valiant but futile!");
                        SHOW_TEXT(player, type, doMsgs, "The party is swept away by the flood and vanishes into the murky depths.");
                        SET_FLAG(player, type, doMsgs, DUNGEON, SAVEDPARTY, 2);
                    }
                }
                else {
                    SHOW_TEXT(player, type, doMsgs, "The party is no longer here.");
                }
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "These torrential waters must be entered alone.");
                where = HERE(player, type, doMsgs);
                 - 1;
                TELEPORT(player, type, doMsgs, 2, 3, where, WEST);
            }
        }
        protected override void FnEvent1C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int mn = 0;
            int mn2 = 0;
            int mn3 = 0;
            int g2 = 0;
            int g3 = 0;
            SHOW_TEXT(player, type, doMsgs, "Young giants rush at you.");
            switch (PARTY_COUNT(player, type, doMsgs)) {
                case 1:
                    mn = 32;
                    mn2 = 32;
                    g2 = 2;
                    break;
                default:
                    mn = 32;
                    mn2 = 32;
                    mn3 = 31;
                    g2 = 2;
                    g3 = 6;
                    break;
            }
            GET_MONSTER(player, type, doMsgs, 01, mn);
            if (g2 != 0) {
                GET_MONSTER(player, type, doMsgs, g2, mn2);
                if (g3 != 0) {
                    GET_MONSTER(player, type, doMsgs, g3, mn3);
                }
            }
        }
        protected override void FnEvent1D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int mn = 0;
            int mn2 = 0;
            int mn3 = 0;
            int mn4 = 0;
            int g2 = 0;
            int g3 = 0;
            int g4 = 0;
            SHOW_TEXT(player, type, doMsgs, "Frustrated adventurers, unable to find a secret passage here, turn to attack you!");
            switch (PARTY_COUNT(player, type, doMsgs)) {
                case 1:
                    mn = 25;
                    mn2 = 26;
                    g2 = 5;
                    break;
                case 2:
                    mn = 25;
                    mn2 = 25;
                    mn3 = 30;
                    g2 = 2;
                    g3 = 4;
                    break;
                default:
                    mn = 30;
                    mn2 = 25;
                    mn3 = 27;
                    mn4 = 33;
                    g2 = 2;
                    g3 = 3;
                    g4 = 4;
                    break;
            }
            GET_MONSTER(player, type, doMsgs, 01, mn);
            if (g2 != 0) {
                GET_MONSTER(player, type, doMsgs, g2, mn2);
                if (g3 != 0) {
                    GET_MONSTER(player, type, doMsgs, g3, mn3);
                    if (g4 != 0) {
                        GET_MONSTER(player, type, doMsgs, g4, mn4);
                    }
                }
            }
        }
        protected override void FnEvent1E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int i = 0;
            switch (PARTY_COUNT(player, type, doMsgs)) {
                case 1:
                    for (i = 1; i <= 2; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 32);
                    }
                    break;
                case 2:
                    for (i = 1; i <= 4; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 32);
                    }
                    break;
                default:
                    for (i = 1; i <= 2; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 32);
                    }
                    for (i = 3; i <= 6; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 30);
                    }
                    break;
            }
        }
        protected override void FnEvent1F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, GNOMEWIZARD);
            SHOW_TEXT(player, type, doMsgs, "'These cursed walls keep sealing me in!");
            SHOW_TEXT(player, type, doMsgs, "Oh, I do wish there was a faster way through this maze of horrors and giants!'");
        }
        protected override void FnEvent20(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int i = 0;
            SHOW_TEXT(player, type, doMsgs, "Agents of Lord Aqueus charge you!");
            switch (PARTY_COUNT(player, type, doMsgs)) {
                case 1:
                    for (i = 1; i <= 2; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 28);
                    }
                    break;
                default:
                    for (i = 1; i <= 2; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 28);
                    }
                    for (i = 3; i <= 5; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 29);
                    }
                    break;
            }
        }
        protected override void FnEvent21(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int howold = 0;
            int i = 0;
            int giveem = 2;
            PLACE_FLOOR_ITEM(player, type, doMsgs, WATER, 127);
            if (PARTY_LEVEL(player, type, doMsgs, 12)) {
                giveem = 1;
            }
            switch (giveem) {
                case 1:
                    SET_BOOTY(player, type, doMsgs, ELIXIROFHEALTH, 0, 0, 0, 0, 500);
                    for (i = 1; i <= 6; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 35);
                    }
                    break;
                default:
                    for (i = 1; i <= 3; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 37);
                    }
                    break;
            }
        }
        protected override void FnEvent22(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GET_FLAG(player, type, doMsgs, PARTY, MADKNIGHT) == 0)) {
                SHOW_TEXT(player, type, doMsgs, "A mad adventurer attacks you in a berserker's rage.");
                GET_MONSTER(player, type, doMsgs, 01, 39);
                SET_FLAG(player, type, doMsgs, PARTY, MADKNIGHT, 1);
            }
        }
        protected override void FnEvent23(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, HALFLINGTHIEF);
            if ((GET_FLAG(player, type, doMsgs, DUNGEON, METJUBILAH) == 0) && GET_FLAG(player, type, doMsgs, DUNGEON, LEARNEDCHANT) == 1) {
                SHOW_TEXT(player, type, doMsgs, "You find the thief Malik and recite the chant, hoping he will understand.");
                SHOW_TEXT(player, type, doMsgs, "'Ah, you've found Sartiq! You must return, for your chant is not complete. He will teach you the rest when you return.'");
                SHOW_TEXT(player, type, doMsgs, "'Forgive me.' So saying, Malik draws his stiletto and quickly carves a curious mark in your arm.");
                SHOW_TEXT(player, type, doMsgs, "'Sartiq will trust you with the rest of the chant now. This mark will prove to him that you are an ally.'");
                SHOW_TEXT(player, type, doMsgs, "'The agents of Aqueus would have attacked rather than bear such a scar. Farewell!'");
                DAMAGE(player, type, doMsgs, HEALTH(player, type, doMsgs) / 5);
                SHOW_TEXT(player, type, doMsgs, "'Go, seek Sartiq again.'");
                SET_FLAG(player, type, doMsgs, DUNGEON, METJUBILAH, 1);
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "A strong thief stands here, as if waiting for a message.");
                SHOW_TEXT(player, type, doMsgs, "'Come again to me once you've found my friend.'");
                SHOW_TEXT(player, type, doMsgs, "'Away! Seek Sartiq to the north. Then, perchance, I will speak to you.'");
            }
        }
        protected override void FnEvent24(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, TROLLKNIGHT);
            SHOW_TEXT(player, type, doMsgs, "'There are many slippery traps and hidden doors here. If only I had a thief or a thief's toys.'");
        }
        protected override void FnEvent25(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GET_FLAG(player, type, doMsgs, DUNGEON, KILLEDAQUEUS) == 0)) {
                SET_FLAG(player, type, doMsgs, DUNGEON, KILLEDAQUEUS, 1);
            }
            SHOW_TEXT(player, type, doMsgs, "The throne room is decorated with marvelous carvings of precious jewels. No doubt the late Aqueus stole them from the river.");
        }
        protected override void FnEvent26(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GET_FLAG(player, type, doMsgs, DUNGEON, KILAM) == 0)) {
                SHOW_PICTURE(player, type, doMsgs, ELFRANGER);
                SHOW_TEXT(player, type, doMsgs, "'Good journeys to you. I wish you luck with these awful puzzles. What I know I shall share with you, for...say...these gold pieces?");
                SHOW_TEXT(player, type, doMsgs, "Excellent! In the northwest corner, a door there is very stubborn. Merely approach and knock three times, and it will open!");
                SHOW_TEXT(player, type, doMsgs, "Be on the lookout for a stern thief and an ancient giant. Together they will help you across the waters.'");
                MOD_GOLD(player, type, doMsgs,  - 1000);
                SET_FLAG(player, type, doMsgs, DUNGEON, KILAM, 1);
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "Kilam has left this area.");
            }
        }
        protected override void FnEvent27(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "A magical pillar stands guard against curious intruders.");
            if (GET_STAT(player, type, doMsgs, STRENGTH) >= 16) {
                SHOW_TEXT(player, type, doMsgs, "You manage to nudge the column enough to move forward.");
                WallClear(player, type, doMsgs);
                CLEAR_FLOOR(player, type, doMsgs, 120);
                CLEAR_FLOOR(player, type, doMsgs, 137);
                CLEAR_FLOOR(player, type, doMsgs, 152);
                CLEAR_FLOOR(player, type, doMsgs, 135);
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "You are unable to move the pillar's massive bulk.");
                WallBlock(player, type, doMsgs);
            }
        }
        protected override void FnEvent28(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Violent swirls of water crash against the northeastern shore.");
        }
        protected override void FnEvent29(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, DUNGEON, SAVEDPARTY) == 2) {
                SHOW_PICTURE(player, type, doMsgs, DWARFKNIGHT);
                SHOW_TEXT(player, type, doMsgs, "The party you thought you saw drown is here.");
                SHOW_TEXT(player, type, doMsgs, "They are badly hurt and huddled over one of their friends who appears to be dead.");
                SHOW_TEXT(player, type, doMsgs, "'YOU!! YOU!! You are responsible for Shalana's death because you didn't rescue us! I should slice you in half!'");
                SHOW_TEXT(player, type, doMsgs, "'You must try to do something to bring her back.'");
                if (USED_ITEM(player, type, doMsgs, RESUSCITATOR, RESUSCITATOR) || USED_ITEM(player, type, doMsgs, LIFEGIVER, LIFEGIVER) || USED_ITEM(player, type, doMsgs, HEARTFLAIL, HEARTFLAIL) || USED_SPELL(player, type, doMsgs, RESUSCITATE_SPELL)) {
                    SHOW_TEXT(player, type, doMsgs, "Your skills and knowledge revive the half-drowned Shalana.");
                    SHOW_TEXT(player, type, doMsgs, "The leader clasps your hand in thanks.");
                    SHOW_TEXT(player, type, doMsgs, "'Ah, friend, forgive my angry words.'");
                    SHOW_TEXT(player, type, doMsgs, "'Thank you for returning Shalana to me.'");
                    SHOW_TEXT(player, type, doMsgs, "'Take these gifts with my gratitude. Hail`'");
                    SHOW_TEXT(player, type, doMsgs, "You feel wiser and wealthier.");
                    GIVE_ITEM(player, type, doMsgs, CROSSBOW);
                    GIVE_ITEM(player, type, doMsgs, SILVERBAR);
                    TAKE_ITEM(player, type, doMsgs, ROPE);
                    MOD_GOLD(player, type, doMsgs, 2000);
                    MOD_EXP(player, type, doMsgs, 2000);
                    SET_FLAG(player, type, doMsgs, DUNGEON, SAVEDPARTY, 2);
                }
                else if (USED_ITEM(player, type, doMsgs, SHORTSWORD, MORNINGSTAR) || USED_ITEM(player, type, doMsgs, NUNCHUKAS, SCROLLOFDEATH) || USED_ITEM(player, type, doMsgs, AURASCROLL, BLESSPOTION) || USED_ITEM(player, type, doMsgs, HOPESFURY, UNITYRING)) {
                    SHOW_TEXT(player, type, doMsgs, "Your efforts are valiant but futile!");
                    SHOW_TEXT(player, type, doMsgs, "You fail to save the life of the girl.");
                    SHOW_TEXT(player, type, doMsgs, "The party leader wheels on you!");
                    SHOW_TEXT(player, type, doMsgs, "'NO! Damn you to Hades! Die now, you ignorant toad!!'");
                    SHOW_TEXT(player, type, doMsgs, "Though exhausted from their ordeal, the weary party has the strength to pummel you ferociously.");
                    SHOW_TEXT(player, type, doMsgs, "Abandoning you to the ghosts, they march off with their dead.");
                    SET_FLAG(player, type, doMsgs, DUNGEON, SAVEDPARTY, 3);
                    DamageBy2(player, type, doMsgs);
                }
            }
        }
        protected override void FnEvent2A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            FntnPic(player, type, doMsgs);
            switch (GUILD(player, type, doMsgs)) {
                case CLERIC:
                case WIZARD:
                    if ((GET_FLAG(player, type, doMsgs, DUNGEON, STORM) == 0)) {
                        GIVE_SPELL(player, type, doMsgs, STORM_WIND_SPELL, 1);
                        SET_FLAG(player, type, doMsgs, DUNGEON, STORM, 1);
                        CoolWater(player, type, doMsgs);
                    }
                    else {
                        Refresh(player, type, doMsgs);
                    }
                    break;
                default:
                    Refresh(player, type, doMsgs);
                    break;
            }
        }
        protected override void FnEvent2B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            FntnPic(player, type, doMsgs);
            switch (GUILD(player, type, doMsgs)) {
                case CLERIC:
                case WIZARD:
                    if ((GET_FLAG(player, type, doMsgs, DUNGEON, CURSED) == 0)) {
                        GIVE_SPELL(player, type, doMsgs, CURSE_SPELL, 1);
                        SET_FLAG(player, type, doMsgs, DUNGEON, CURSED, 1);
                        CoolWater(player, type, doMsgs);
                    }
                    else {
                        Refresh(player, type, doMsgs);
                    }
                    break;
                default:
                    Refresh(player, type, doMsgs);
                    break;
            }
        }
        protected override void FnEvent2C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            FntnPic(player, type, doMsgs);
            switch (GUILD(player, type, doMsgs)) {
                case KNIGHT:
                case WIZARD:
                    if ((GET_FLAG(player, type, doMsgs, DUNGEON, EFIELD) == 0)) {
                        GIVE_SPELL(player, type, doMsgs, ENERGY_FIELD_SPELL, 1);
                        SET_FLAG(player, type, doMsgs, DUNGEON, EFIELD, 1);
                        CoolWater(player, type, doMsgs);
                    }
                    else {
                        Refresh(player, type, doMsgs);
                    }
                    break;
                default:
                    Refresh(player, type, doMsgs);
                    break;
            }
        }
        protected override void FnEvent2D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            FntnPic(player, type, doMsgs);
            switch (GUILD(player, type, doMsgs)) {
                case KNIGHT:
                    if ((GET_FLAG(player, type, doMsgs, DUNGEON, SEETHEKNIGHT) == 0)) {
                        GIVE_SPELL(player, type, doMsgs, TRUE_SEEING_SPELL, 1);
                        SET_FLAG(player, type, doMsgs, DUNGEON, SEETHEKNIGHT, 1);
                        SHOW_TEXT(player, type, doMsgs, "The warm waters satisfy your thirst for knowledge with a new spell!");
                    }
                    else {
                        Refresh(player, type, doMsgs);
                    }
                    break;
                case CLERIC:
                    if ((GET_SKILL(player, type, doMsgs, CHANNEL_SKILL) == 0)) {
                        MOD_SKILL(player, type, doMsgs, CHANNEL_SKILL, 1);
                        SHOW_TEXT(player, type, doMsgs, "The warm waters satisfy your thirst for knowledge with a new skill!");
                    }
                    else {
                        Refresh(player, type, doMsgs);
                    }
                    break;
                default:
                    Refresh(player, type, doMsgs);
                    break;
            }
            FntnPic(player, type, doMsgs);
            switch (GUILD(player, type, doMsgs)) {
                case KNIGHT:
                case CLERIC:
                    if ((GET_SKILL(player, type, doMsgs, CHANNEL_SKILL) == 0)) {
                        MOD_SKILL(player, type, doMsgs, CHANNEL_SKILL, 1);
                        SHOW_TEXT(player, type, doMsgs, "The warm waters satisfy your thirst for knowledge with a new skill!");
                    }
                    else {
                        Refresh(player, type, doMsgs);
                    }
                    break;
                default:
                    Refresh(player, type, doMsgs);
                    break;
            }
        }
        protected override void FnEvent2E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            WallBlock(player, type, doMsgs);
            SHOW_TEXT(player, type, doMsgs, "The fierce torrents bar your way. You must find an alternate way across.");
        }
        protected override void FnEvent2F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (USED_ITEM(player, type, doMsgs, GREENLOCKPICK, BLUELOCKPICK) || USED_SKILL(player, type, doMsgs, LOCKPICK_SKILL) || USED_ITEM(player, type, doMsgs, HELMOFGUILE, HELMOFGUILE)) {
                SHOW_TEXT(player, type, doMsgs, "You've managed to unlock the gate.");
                WallClear(player, type, doMsgs);
            }
            else {
                WallBlock(player, type, doMsgs);
                SHOW_TEXT(player, type, doMsgs, "One well skilled with lockpicks may be able to open this magnificent gate.");
            }
        }
        private void FntnPic(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, FOUNTAIN);
        }
        private void SprungTrap(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SET_FLAG(player, type, doMsgs, ROOM, SPRUNGTRAP, 1);
        }
        private void WallBlock(TwPlayerServer player, MapEventType type, bool doMsgs) {
            BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
        }
        private void DamageBy2(TwPlayerServer player, MapEventType type, bool doMsgs) {
            DAMAGE(player, type, doMsgs, MAX_HEALTH(player, type, doMsgs) / 4);
        }
        private void CoolWater(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "The cool waters enlighten you with a new spell!");
        }
        private void Refresh(TwPlayerServer player, MapEventType type, bool doMsgs) {
            HEAL(player, type, doMsgs, MAX_HEALTH(player, type, doMsgs));
            MOD_MANA(player, type, doMsgs, 2000);
            SHOW_TEXT(player, type, doMsgs, "The waters are refreshing!");
        }
        private void WallClear(TwPlayerServer player, MapEventType type, bool doMsgs) {
            CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
        }
        private void PlaceDoor(TwPlayerServer player, MapEventType type, bool doMsgs) {
            PLACE_WALL_ITEM(player, type, doMsgs, DOOR, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
        }
        protected override void FnEvent30(TwPlayerServer player, MapEventType type, bool doMsgs) {
            PLACE_FLOOR_ITEM(player, type, doMsgs, WATER, 75);
            PLACE_FLOOR_ITEM(player, type, doMsgs, WATER, 91);
            PLACE_FLOOR_ITEM(player, type, doMsgs, WATER, 107);
            PLACE_FLOOR_ITEM(player, type, doMsgs, WATER, 124);
            PLACE_FLOOR_ITEM(player, type, doMsgs, WATER, 140);
            PLACE_FLOOR_ITEM(player, type, doMsgs, WATER, 141);
            PLACE_FLOOR_ITEM(player, type, doMsgs, WATER, 126);
            PLACE_FLOOR_ITEM(player, type, doMsgs, WATER, 127);
        }
    }
}
