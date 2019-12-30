using XPT.Generic.Maps;
using XPT.Twinion.Entities;

namespace XPT.Twinion.Maps {
    class TwMap15 : TwMap {
        protected override int MapIndex => 15;
        protected override int MapID => 0x0602;
        protected override int RandomEncounterChance => 10;
        protected override int RandomEncounterExtraCount => 0;

        protected override void FnEvent01(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (RACE() == GNOME) {
                GuildDoor(player, type, doMsgs);
            }
        }
        protected override void FnEvent02(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (USED_SKILL(player, type, doMsgs, DETECT_SKILL) >= 6 || USED_SPELL(player, type, doMsgs, TRUE_SEEING_SPELL) || USED_ITEM(player, type, doMsgs, HELMOFWISDOM, HELMOFWISDOM) || USED_ITEM(player, type, doMsgs, VALKYRIESHELM, VALKYRIESHELM) || USED_ITEM(player, type, doMsgs, RINGOFTHIEVES, RINGOFTHIEVES) || USED_ITEM(player, type, doMsgs, CRYSTALBALL, CRYSTALBALL)) {
                SHOW_TEXT(player, type, doMsgs, "You spot a hidden door.");
                DoorHere(player, type, doMsgs);
                WallClear(player, type, doMsgs);
            }
            else {
                WallBlock(player, type, doMsgs);
            }
        }
        protected override void FnEvent03(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 6, 3, 164, NORTH);
        }
        protected override void FnEvent04(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short itemA = 0;
            short life = 0;
            if (HAS_ITEM(player, type, doMsgs, RODOFTHESERPENT) || HAS_ITEM(player, type, doMsgs, SERPENTSFANG)) {
                BootyStr(player, type, doMsgs);
            }
            else {
                switch (GUILD()) {
                    case KNIGHT:
                    case THIEF:
                    case WIZARD:
                        itemA = SERPENTSFANG;
                        break;
                    default:
                        itemA = RODOFTHESERPENT;
                        break;
                }
                switch (HERE()) {
                    case 21:
                        life = HALFLING;
                        break;
                    case 30:
                        life = HUMAN;
                        break;
                    case 163:
                        life = ORC;
                        break;
                    case 201:
                        life = DWARF;
                        break;
                }
                if (RACE() == life) {
                    SET_BOOTY(player, type, doMsgs, itemA, BLUELOCKPICK, ELIXIROFHEALTH, 0, 0, 3000);
                }
                else {
                    BootyStr(player, type, doMsgs);
                }
            }
            switch (PARTY_COUNT()) {
                case 1:
                    GET_MONSTER(player, type, doMsgs, 01, 9);
                    GET_MONSTER(player, type, doMsgs, 02, 30);
                    break;
                case 2:
                    GET_MONSTER(player, type, doMsgs, 01, 9);
                    GET_MONSTER(player, type, doMsgs, 02, 9);
                    GET_MONSTER(player, type, doMsgs, 05, 5);
                    break;
                default:
                    GET_MONSTER(player, type, doMsgs, 01, 9);
                    GET_MONSTER(player, type, doMsgs, 02, 9);
                    GET_MONSTER(player, type, doMsgs, 05, 27);
                    GET_MONSTER(player, type, doMsgs, 06, 27);
                    break;
            }
        }
        protected override void FnEvent05(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (RACE() == HALFLING) {
                SHOW_TEXT(player, type, doMsgs, "Use Kalydor's payment first.");
            }
        }
        protected override void FnEvent06(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (RACE() == HALFLING) {
                GuildDoor(player, type, doMsgs);
            }
        }
        protected override void FnEvent07(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "The clutter of spent crystal balls littering the ground reminds you that many times a door can be detected by using magic.");
        }
        protected override void FnEvent08(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 6, 3, 47, WEST);
        }
        protected override void FnEvent09(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short life;
            switch (HERE()) {
                case 34:
                    life = GNOME;
                    break;
                case 91:
                    life = TROLL;
                    break;
                case 116:
                    life = GREMLIN;
                    break;
                case 204:
                    life = ELF;
                    break;
            }
            if (HAS_ITEM(player, type, doMsgs, LEATHERMAP)) {
                EmptyRoom(player, type, doMsgs);
            }
            else if (RACE() == life) {
                if (!GET_FLAG(player, type, doMsgs, DUNGEON, LEATHER_MAP)) {
                    SET_FLAG(player, type, doMsgs, DUNGEON, LEATHER_MAP, 1);
                    MOD_EXP(player, type, doMsgs, 200000);
                    GlimpseMap(player, type, doMsgs);
                }
                else {
                    GlimpseMap(player, type, doMsgs);
                }
            }
            else {
                EmptyRoom(player, type, doMsgs);
            }
        }
        protected override void FnEvent0A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 6, 3, 11, EAST);
        }
        protected override void FnEvent0B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 6, 3, 74, WEST);
        }
        protected override void FnEvent0C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            CLEAR_WALL(player, type, doMsgs, HERE(), FACING());
        }
        protected override void FnEvent0D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (RACE() == HUMAN) {
                SHOW_TEXT(player, type, doMsgs, "Use the Topaz before the Ebony.");
            }
        }
        protected override void FnEvent0E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "A group of vicious monsters appears to guard this area.");
        }
        protected override void FnEvent0F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, HALFLINGCLERIC);
            SHOW_TEXT(player, type, doMsgs, "With a gleam in his eyes, a halfling approaches you.");
            SHOW_TEXT(player, type, doMsgs, "'Well! It took me a lot of crystal balls to find out that most of these secret passages are actually illusionary walls!");
            SHOW_TEXT(player, type, doMsgs, "But not all was in vain, I did find some secret doors and they led me..well, I'll let you find that out. I wonder who built this place.'");
            SHOW_TEXT(player, type, doMsgs, "With that, he returns to contemplating his maps.");
        }
        protected override void FnEvent10(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (RACE() == HUMAN) {
                GuildDoor(player, type, doMsgs);
            }
        }
        protected override void FnEvent11(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (RACE() == ORC) {
                HealFtn(player, type, doMsgs);
                SHOW_TEXT(player, type, doMsgs, "The waters of Orc Spring refresh and invigorate you.");
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "The waters of Orc Spring have no affect.");
            }
        }
        protected override void FnEvent12(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (RACE() == DWARF) {
                HealFtn(player, type, doMsgs);
                SHOW_TEXT(player, type, doMsgs, "The waters of Dwarf Spring refresh and invigorate you.");
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "The waters of Dwarf Spring have no affect.");
            }
        }
        protected override void FnEvent13(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 6, 3, 126, EAST);
        }
        protected override void FnEvent14(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, GNOMEWIZARD);
            SHOW_TEXT(player, type, doMsgs, "A gnome with a merry gleam in his eye greets your with a chuckle. 'You are much too serious, my friend! Keep searching, you will find what you seek, I swear!'");
            SHOW_TEXT(player, type, doMsgs, "He becomes serious for a moment and says, 'Ah, the wonders and dangers that await you. Within the depths I have seen feuding dragons, each on opposite sides of a tunnel.");
            SHOW_TEXT(player, type, doMsgs, "Magic permeates that place, so be sure you are protected. There is also a place called Hopeless Hallways and...wait, I shall let you return to your search. That story can wait.'");
            SHOW_TEXT(player, type, doMsgs, "With that he chuckles and walks away.");
        }
        protected override void FnEvent17(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 6, 3, 106, NORTH);
        }
        protected override void FnEvent18(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, ROOM, HORSE) == 0) {
                DAMAGE(player, type, doMsgs, MAX_HEALTH() / 4);
                SHOW_TEXT(player, type, doMsgs, "A herd of horses stampedes past your party, injuring you.");
                SET_FLAG(player, type, doMsgs, ROOM, HORSE, 1);
            }
        }
        protected override void FnEvent19(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (RACE() == TROLL) {
                GuildDoor(player, type, doMsgs);
            }
        }
        protected override void FnEvent1A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SET_BOOTY(player, type, doMsgs, SILVERBAR, READTRACKSTALISMAN, 0, 0, 0, 2000);
            SHOW_TEXT(player, type, doMsgs, "A band of adventurers bickers over treasure.");
            if (PARTY_COUNT() == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 21);
                GET_MONSTER(player, type, doMsgs, 02, 33);
            }
            else if (PARTY_COUNT() == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 21);
                GET_MONSTER(player, type, doMsgs, 02, 22);
                GET_MONSTER(player, type, doMsgs, 05, 33);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 35);
                GET_MONSTER(player, type, doMsgs, 02, 36);
                GET_MONSTER(player, type, doMsgs, 03, 37);
                GET_MONSTER(player, type, doMsgs, 04, 38);
                GET_MONSTER(player, type, doMsgs, 05, 39);
                GET_MONSTER(player, type, doMsgs, 06, 40);
            }
        }
        protected override void FnEvent1B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            MOD_GOLD(player, type, doMsgs,  - 2000);
            SHOW_TEXT(player, type, doMsgs, "Your pockets feel lighter because your horse lost.");
        }
        protected override void FnEvent1C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, DWARFTHIEF);
            SHOW_TEXT(player, type, doMsgs, "'I found a place deep in the dungeon where babble rules. After exploring the place for quite some time, I stumbled upon some wall switches.");
            SHOW_TEXT(player, type, doMsgs, "Walking into a wall changes its switch. I would still be down there if I hadn't figured out what words I was supposed to spell.'");
        }
        protected override void FnEvent1D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, HUMANBARBARIAN);
            SHOW_TEXT(player, type, doMsgs, "'A word of warning from a seasoned soldier -");
            SHOW_TEXT(player, type, doMsgs, "Deep in the dungeon is a place where Harmony and Chaos are united.");
            SHOW_TEXT(player, type, doMsgs, "Do not be overly concerned about being weakened by a burned hand. Eventually, it will be healed and you will receive a great blessing.'");
        }
        protected override void FnEvent1E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 6, 3, 35, WEST);
        }
        protected override void FnEvent1F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, DWARFWIZARD);
            SHOW_TEXT(player, type, doMsgs, "'I've been wandering for days here and in the adjoining Rat Race. I feel like some mouse being led through a maze!");
            SHOW_TEXT(player, type, doMsgs, "My fellow mages have warned me that I must find the two places open only to members of my Race.");
            SHOW_TEXT(player, type, doMsgs, "Until I find them, I will not be able to get into the nether regions of this dungeon.'");
        }
        protected override void FnEvent21(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (RACE() == GREMLIN) {
                GuildDoor(player, type, doMsgs);
            }
        }
        protected override void FnEvent22(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SET_BOOTY(player, type, doMsgs, STONEOFTHEMAGI, LIFEGIVER, 0, 0, 0, 2000);
            SHOW_TEXT(player, type, doMsgs, "Adventurers trick you into joining a battle and then turn on you.");
            if (PARTY_COUNT() == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 35);
                GET_MONSTER(player, type, doMsgs, 02, 35);
            }
            else if (PARTY_COUNT() == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 15);
                GET_MONSTER(player, type, doMsgs, 02, 17);
                GET_MONSTER(player, type, doMsgs, 04, 16);
                GET_MONSTER(player, type, doMsgs, 06, 40);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 15);
                GET_MONSTER(player, type, doMsgs, 02, 17);
                GET_MONSTER(player, type, doMsgs, 04, 16);
                GET_MONSTER(player, type, doMsgs, 05, 39);
                GET_MONSTER(player, type, doMsgs, 06, 40);
            }
        }
        protected override void FnEvent23(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (RACE() == ORC) {
                GuildDoor(player, type, doMsgs);
            }
        }
        protected override void FnEvent24(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (RACE() == ORC) {
                SHOW_TEXT(player, type, doMsgs, "Use Syrene's payment first.");
            }
        }
        protected override void FnEvent25(TwPlayerServer player, MapEventType type, bool doMsgs) {
            MOD_MANA(player, type, doMsgs,  - 200);
            SHOW_TEXT(player, type, doMsgs, "Your long journey has taken a toll on you and you feel your mana decrease.");
        }
        protected override void FnEvent27(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (RACE() == ELF) {
                HealFtn(player, type, doMsgs);
                SHOW_TEXT(player, type, doMsgs, "The waters of Elf Spring refresh and invigorate you.");
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "The waters of Elf Spring have no affect.");
            }
        }
        protected override void FnEvent29(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 6, 3, 175, WEST);
        }
        protected override void FnEvent2C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SET_BOOTY(player, type, doMsgs, SCROLLOFTHESUN, AMULETOFPROTECTION, 0, 0, 0, 2000);
            SHOW_TEXT(player, type, doMsgs, "Dragons turn toward you and attack!");
            if (PARTY_COUNT() == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 12);
                GET_MONSTER(player, type, doMsgs, 02, 28);
            }
            else if (PARTY_COUNT() == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 11);
                GET_MONSTER(player, type, doMsgs, 02, 11);
                GET_MONSTER(player, type, doMsgs, 05, 28);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 11);
                GET_MONSTER(player, type, doMsgs, 02, 11);
                GET_MONSTER(player, type, doMsgs, 03, 28);
                GET_MONSTER(player, type, doMsgs, 04, 29);
                GET_MONSTER(player, type, doMsgs, 05, 29);
            }
        }
        protected override void FnEvent2D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 6, 3, 185, SOUTH);
        }
        protected override void FnEvent2E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (RACE() == ELF) {
                GuildDoor(player, type, doMsgs);
            }
        }
        protected override void FnEvent2F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (RACE() == DWARF) {
                GuildDoor(player, type, doMsgs);
            }
        }
        protected override void FnEvent30(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (RACE() == DWARF) {
                SHOW_TEXT(player, type, doMsgs, "Use the Topaz before the Ebony.");
            }
        }
        protected override void FnEvent35(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, DUNGEON, UNIVERSAL) == 1) {
                HealFtn(player, type, doMsgs);
                SHOW_TEXT(player, type, doMsgs, "The sparkling waters of Universal Spring refresh and invigorate you.");
            }
            else {
                SET_FLAG(player, type, doMsgs, DUNGEON, UNIVERSAL, 1);
                HealFtn(player, type, doMsgs);
                if (GUILD() == BARBARIAN || GUILD() == KNIGHT) {
                    GIVE_SPELL(player, type, doMsgs, RESIST_SPELL, 1);
                    SHOW_TEXT(player, type, doMsgs, "The sparkling waters of Universal Spring endow you with the Resist spell.");
                }
                else {
                    GIVE_SPELL(player, type, doMsgs, POISON_CLOUD_SPELL, 1);
                    SHOW_TEXT(player, type, doMsgs, "The sparkling waters of Universal Spring endow you with the Poison Cloud spell.");
                }
            }
        }
        protected override void FnEvent36(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 6, 3, 241, WEST);
        }
        protected override void FnEvent37(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, DUNGEON, TRACK) == 1) {
                SHOW_TEXT(player, type, doMsgs, "You find an empty quest bag.");
            }
            else {
                MOD_GOLD(player, type, doMsgs, 50000);
                SET_FLAG(player, type, doMsgs, DUNGEON, TRACK, 1);
                SHOW_TEXT(player, type, doMsgs, "Congratulations, your horse finished first. You collect your winnings.");
            }
        }
        protected override void FnEvent39(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (USED_SKILL(player, type, doMsgs, DETECT_SKILL) >= 6 || USED_SPELL(player, type, doMsgs, TRUE_SEEING_SPELL) || USED_ITEM(player, type, doMsgs, HELMOFWISDOM, HELMOFWISDOM) || USED_ITEM(player, type, doMsgs, VALKYRIESHELM, VALKYRIESHELM) || USED_ITEM(player, type, doMsgs, RINGOFTHIEVES, RINGOFTHIEVES) || USED_ITEM(player, type, doMsgs, CRYSTALBALL, CRYSTALBALL) || FLAG_ON(player, type, doMsgs, ROOM, DETECTED_DOOR)) {
                SET_FLAG(player, type, doMsgs, ROOM, DETECTED_DOOR, 1);
                if (USED_ITEM(player, type, doMsgs, BLUELOCKPICK, BLUELOCKPICK) || USED_ITEM(player, type, doMsgs, HELMOFGUILE, HELMOFGUILE) || USED_SKILL(player, type, doMsgs, LOCKPICK_SKILL) >= 8) {
                    SHOW_TEXT(player, type, doMsgs, "You successfully unlock the door.");
                    DoorHere(player, type, doMsgs);
                    WallClear(player, type, doMsgs);
                }
                else {
                    WallBlock(player, type, doMsgs);
                    DoorHere(player, type, doMsgs);
                    SHOW_TEXT(player, type, doMsgs, "You see a door appear in the wall, but it is locked.");
                }
            }
            else {
                WallBlock(player, type, doMsgs);
            }
        }
        protected override void FnEvent3C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (RACE() == GNOME) {
                HealFtn(player, type, doMsgs);
                SHOW_TEXT(player, type, doMsgs, "The waters of Gnome Spring refresh and invigorate you.");
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "The waters of Gnome Spring have no affect.");
            }
        }
        protected override void FnEvent3E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, ROOM, POTION) == 0) {
                if (HAS_ITEM(player, type, doMsgs, HEALALLPOTION)) {
                    TAKE_ITEM(player, type, doMsgs, HEALALLPOTION);
                    SHOW_TEXT(player, type, doMsgs, "You stumble while searching the dark room, and one of your potions crashes to the floor.");
                }
                else {
                    DAMAGE(player, type, doMsgs, MAX_HEALTH() / 10);
                    SHOW_TEXT(player, type, doMsgs, "You fall clumsily in the dark room and manage to hurt yourself.");
                    SET_FLAG(player, type, doMsgs, ROOM, POTION, 1);
                }
            }
        }
        protected override void FnEvent3F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT() == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 19);
            }
            else if (PARTY_COUNT() == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 15);
                GET_MONSTER(player, type, doMsgs, 02, 15);
                GET_MONSTER(player, type, doMsgs, 05, 20);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 16);
                GET_MONSTER(player, type, doMsgs, 02, 31);
                GET_MONSTER(player, type, doMsgs, 03, 33);
                GET_MONSTER(player, type, doMsgs, 05, 33);
                GET_MONSTER(player, type, doMsgs, 06, 34);
            }
        }
        protected override void FnEvent40(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT() == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 6);
                GET_MONSTER(player, type, doMsgs, 02, 23);
            }
            else if (PARTY_COUNT() == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 30);
                GET_MONSTER(player, type, doMsgs, 02, 30);
                GET_MONSTER(player, type, doMsgs, 05, 24);
                GET_MONSTER(player, type, doMsgs, 06, 21);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 7);
                GET_MONSTER(player, type, doMsgs, 02, 7);
                GET_MONSTER(player, type, doMsgs, 03, 21);
                GET_MONSTER(player, type, doMsgs, 05, 38);
            }
        }
        protected override void FnEvent42(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT() == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 3);
            }
            else if (PARTY_COUNT() == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 2);
                GET_MONSTER(player, type, doMsgs, 02, 4);
                GET_MONSTER(player, type, doMsgs, 05, 26);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 2);
                GET_MONSTER(player, type, doMsgs, 02, 2);
                GET_MONSTER(player, type, doMsgs, 03, 1);
                GET_MONSTER(player, type, doMsgs, 04, 1);
                GET_MONSTER(player, type, doMsgs, 06, 26);
            }
        }
        protected override void FnEvent43(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT() == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 6);
                GET_MONSTER(player, type, doMsgs, 02, 6);
            }
            else if (PARTY_COUNT() == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 6);
                GET_MONSTER(player, type, doMsgs, 02, 6);
                GET_MONSTER(player, type, doMsgs, 06, 27);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 6);
                GET_MONSTER(player, type, doMsgs, 02, 6);
                GET_MONSTER(player, type, doMsgs, 05, 27);
                GET_MONSTER(player, type, doMsgs, 06, 27);
            }
        }
        protected override void FnEvent44(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT() == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 16);
                GET_MONSTER(player, type, doMsgs, 02, 25);
            }
            else if (PARTY_COUNT() == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 15);
                GET_MONSTER(player, type, doMsgs, 02, 16);
                GET_MONSTER(player, type, doMsgs, 03, 31);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 16);
                GET_MONSTER(player, type, doMsgs, 02, 16);
                GET_MONSTER(player, type, doMsgs, 03, 31);
                GET_MONSTER(player, type, doMsgs, 04, 31);
                GET_MONSTER(player, type, doMsgs, 05, 36);
                GET_MONSTER(player, type, doMsgs, 06, 37);
            }
        }
        private void GuildDoor(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, DUNGEON, ARMORY_ITEM) == 1 && USED_ITEM(player, type, doMsgs, SKELETONKEY, SKELETONKEY)) {
                SHOW_TEXT(player, type, doMsgs, "The door springs open.");
                WallClear(player, type, doMsgs);
            }
            else {
                WallBlock(player, type, doMsgs);
                SHOW_TEXT(player, type, doMsgs, "You see a skull and crossbones scratched into the door.");
            }
        }
        private void EmptyRoom(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "The room is empty.");
        }
        private void GlimpseMap(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You glimpse a scrap of leather on the floor.");
            SHOW_TEXT(player, type, doMsgs, "It is a Leather Map and is one of the four Queen Aeowyn sent you to find.");
            GIVE_ITEM(player, type, doMsgs, LEATHERMAP);
        }
        private void HealFtn(TwPlayerServer player, MapEventType type, bool doMsgs) {
            HEAL(player, type, doMsgs, MAX_HEALTH());
            MOD_MANA(player, type, doMsgs, 10000);
        }
        private void DoorHere(TwPlayerServer player, MapEventType type, bool doMsgs) {
            PLACE_WALL_ITEM(player, type, doMsgs, DOOR, HERE(), FACING());
        }
        private void WallBlock(TwPlayerServer player, MapEventType type, bool doMsgs) {
            BLOCK_WALL(player, type, doMsgs, HERE(), FACING());
        }
        private void WallClear(TwPlayerServer player, MapEventType type, bool doMsgs) {
            CLEAR_WALL(player, type, doMsgs, HERE(), FACING());
        }
        private void BootyStr(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SET_BOOTY(player, type, doMsgs, BLUELOCKPICK, ELIXIROFHEALTH, 0, 0, 0, 1500);
        }
    }
}
