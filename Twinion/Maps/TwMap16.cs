using XPT.Generic.Maps;
using XPT.Twinion.Entities;

namespace XPT.Twinion.Maps {
    class TwMap16 : TwMap {
        protected override int MapIndex => 16;
        protected override int MapID => 0x0603;
        protected override int RandomEncounterChance => 10;
        protected override int RandomEncounterExtraCount => 0;

        private const int DETECTED_DOOR = 1;
        private const int HURT = 2;
        protected override void FnEvent01(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (RACE(player, type, doMsgs) == GREMLIN) {
                GuildDoor(player, type, doMsgs);
            }
        }
        protected override void FnEvent02(TwPlayerServer player, MapEventType type, bool doMsgs) {
            CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
        }
        protected override void FnEvent03(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (USED_SKILL(player, type, doMsgs, DETECT_SKILL) >= 6 || USED_SPELL(player, type, doMsgs, TRUE_SEEING_SPELL) || USED_ITEM(player, type, doMsgs, HELMOFWISDOM, HELMOFWISDOM) || USED_ITEM(player, type, doMsgs, VALKYRIESHELM, VALKYRIESHELM) || USED_ITEM(player, type, doMsgs, RINGOFTHIEVES, RINGOFTHIEVES) || USED_ITEM(player, type, doMsgs, CRYSTALBALL, CRYSTALBALL)) {
                SHOW_TEXT(player, type, doMsgs, "You find a cleverly disguised door.");
                DoorHere(player, type, doMsgs);
                WallClear(player, type, doMsgs);
            }
            else {
                WallBlock(player, type, doMsgs);
            }
        }
        protected override void FnEvent04(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You are surprised by a group of monsters who attack!");
        }
        protected override void FnEvent05(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 6, 2, 160, EAST);
        }
        protected override void FnEvent06(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GET_FLAG(player, type, doMsgs, DUNGEON, LEATHER_MAP) == 0)) {
                SHOW_PICTURE(player, type, doMsgs, ELFBARBARIAN);
                SHOW_TEXT(player, type, doMsgs, "'At last! I've found my weapon, a clue and a map piece!'");
                SHOW_TEXT(player, type, doMsgs, "The elf looks at you with a broad grin, 'It's my fourth and final piece you know. Now all I have to do is find my way out of here.'");
                SHOW_TEXT(player, type, doMsgs, "She slips a Skeleton Key into her bag and turns to leave. 'Good luck in your search!'");
            }
        }
        protected override void FnEvent07(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (RACE(player, type, doMsgs) == GREMLIN) {
                SHOW_TEXT(player, type, doMsgs, "Use the Ebony before the Coral.");
            }
        }
        protected override void FnEvent08(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int itemA = 0;
            int life = 0;
            if (HAS_ITEM(player, type, doMsgs, RODOFTHESERPENT) || HAS_ITEM(player, type, doMsgs, SERPENTSFANG)) {
                BootyStr(player, type, doMsgs);
            }
            else {
                switch (GUILD(player, type, doMsgs)) {
                    case KNIGHT:
                    case THIEF:
                    case WIZARD:
                        itemA = SERPENTSFANG;
                        break;
                    default:
                        itemA = RODOFTHESERPENT;
                        break;
                }
                switch (HERE(player, type, doMsgs)) {
                    case 24:
                        life = GREMLIN;
                        break;
                    case 97:
                        life = ELF;
                        break;
                    case 138:
                        life = GNOME;
                        break;
                    case 214:
                        life = TROLL;
                        break;
                }
                if (RACE(player, type, doMsgs) == life) {
                    SET_BOOTY(player, type, doMsgs, itemA, BLUELOCKPICK, ELIXIROFHEALTH, 0, 0, 3000);
                }
                else {
                    BootyStr(player, type, doMsgs);
                }
            }
            switch (PARTY_COUNT(player, type, doMsgs)) {
                case 1:
                    GET_MONSTER(player, type, doMsgs, 01, 26);
                    break;
                case 2:
                    GET_MONSTER(player, type, doMsgs, 01, 2);
                    GET_MONSTER(player, type, doMsgs, 02, 2);
                    GET_MONSTER(player, type, doMsgs, 05, 25);
                    break;
                default:
                    GET_MONSTER(player, type, doMsgs, 01, 2);
                    GET_MONSTER(player, type, doMsgs, 02, 2);
                    GET_MONSTER(player, type, doMsgs, 05, 25);
                    GET_MONSTER(player, type, doMsgs, 06, 26);
                    break;
            }
        }
        protected override void FnEvent09(TwPlayerServer player, MapEventType type, bool doMsgs) {
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
        protected override void FnEvent0A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, FOUNTAIN);
            if (GUILD(player, type, doMsgs) == BARBARIAN || GUILD(player, type, doMsgs) == CLERIC || GUILD(player, type, doMsgs) == RANGER || GUILD(player, type, doMsgs) == KNIGHT) {
                if ((GET_SKILL(player, type, doMsgs, STAFF_SKILL) == 0)) {
                    HealFtn(player, type, doMsgs);
                    MOD_SKILL(player, type, doMsgs, STAFF_SKILL, 1);
                    SHOW_TEXT(player, type, doMsgs, "The crystal waters of Unity Fountain teach you the Staff skill.");
                }
                else {
                    SHOW_TEXT(player, type, doMsgs, "The crystal waters of Unity Fountain heal and restore mana for all races.");
                    HealFtn(player, type, doMsgs);
                }
            }
            else if (GUILD(player, type, doMsgs) == WIZARD) {
                if ((GET_FLAG(player, type, doMsgs, DUNGEON, BLESSWIZ) == 0)) {
                    HealFtn(player, type, doMsgs);
                    GIVE_SPELL(player, type, doMsgs, BLESS_SPELL, 1);
                    SET_FLAG(player, type, doMsgs, DUNGEON, BLESSWIZ, 1);
                    SHOW_TEXT(player, type, doMsgs, "The crystal waters of Unity Fountain teach you the Bless spell.");
                }
                else {
                    HealFtn(player, type, doMsgs);
                    SHOW_TEXT(player, type, doMsgs, "The crystal waters of Unity Fountain heal and restore mana for all races.");
                }
            }
            else if (GUILD(player, type, doMsgs) == THIEF) {
                if ((GET_SKILL(player, type, doMsgs, RUNE_READING_SKILL) == 0)) {
                    HealFtn(player, type, doMsgs);
                    MOD_SKILL(player, type, doMsgs, RUNE_READING_SKILL, 1);
                    SHOW_TEXT(player, type, doMsgs, "The crystal waters of Unity Fountain teaches you the Rune Reading skill.");
                }
                else {
                    HealFtn(player, type, doMsgs);
                    SHOW_TEXT(player, type, doMsgs, "The crystal waters of Unity Fountain heal and restore mana for all races.");
                }
            }
        }
        protected override void FnEvent0B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GET_FLAG(player, type, doMsgs, DUNGEON, LEATHER_MAP) == 0)) {
                SHOW_PICTURE(player, type, doMsgs, GREMLINTHIEF);
                SHOW_TEXT(player, type, doMsgs, "A thief emerges from the shadows.");
                SHOW_TEXT(player, type, doMsgs, "'Psssst...let me give you some advice. Some of the walls in these rooms have been weakened. Just push and see!'");
                SHOW_TEXT(player, type, doMsgs, "As he walks off winking, he looks back and says, 'Oh, I hope you visited Snicker again. He has appropriated a Ring of Thieves which will come in handy in here. It will show you unseen pathways.'");
            }
        }
        protected override void FnEvent0C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GET_FLAG(player, type, doMsgs, DUNGEON, LEATHER_MAP) == 0)) {
                SHOW_PICTURE(player, type, doMsgs, DWARFWIZARD);
                SHOW_TEXT(player, type, doMsgs, "'Hehehehehe!  A champion you wish to be, yet things you must learn. Some doors here are to deceive, not to open. Learn it well.");
                SHOW_TEXT(player, type, doMsgs, "By the way, you did bring your reforged Skeleton Key with you, didn't you?'");
            }
        }
        protected override void FnEvent0D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (RACE(player, type, doMsgs) == HUMAN) {
                GuildDoor(player, type, doMsgs);
            }
        }
        protected override void FnEvent0E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 6, 2, 32, EAST);
        }
        protected override void FnEvent0F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, DWARFTHIEF);
            SHOW_TEXT(player, type, doMsgs, "'My brother thief forgot to mention that neither word uses the first letter.");
            SHOW_TEXT(player, type, doMsgs, "The second and last are most important.");
            SHOW_TEXT(player, type, doMsgs, "Oh, and the one that uses the last also lacks two letters. But it will become obvious to you when time and place are right.'");
        }
        protected override void FnEvent10(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, HALFLINGRANGER);
            SHOW_TEXT(player, type, doMsgs, "'Ah-h-h! This dungeon has driven me half-mad!");
            SHOW_TEXT(player, type, doMsgs, "Further down I found this nexus area that was nothing but doors, doors, doors!");
            SHOW_TEXT(player, type, doMsgs, "Fortunately, almost all that opened - notice I say 'almost' - required no special key or lockpick or skill.");
            SHOW_TEXT(player, type, doMsgs, "Still, if I could get my hands around the neck of the maniac who designed that place, I would... Oh, how I would love to squeeze and squeeze until the eyes popped out!'");
        }
        protected override void FnEvent11(TwPlayerServer player, MapEventType type, bool doMsgs) {
            NO_HEAL_ZONE(player, type, doMsgs);
            if ((GET_FLAG(player, type, doMsgs, ROOM, HURT) == 0)) {
                DAMAGE(player, type, doMsgs, MAX_HEALTH(player, type, doMsgs) / 4);
                SHOW_TEXT(player, type, doMsgs, "You feel nauseous as you step through the stagnant puddle of water.");
                SET_FLAG(player, type, doMsgs, ROOM, HURT, 1);
            }
        }
        protected override void FnEvent13(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int life = 0;
            switch (HERE(player, type, doMsgs)) {
                case 58:
                    life = HUMAN;
                    break;
                case 177:
                    life = HALFLING;
                    break;
                case 220:
                    life = ORC;
                    break;
                case 87:
                    life = DWARF;
                    break;
            }
            if (HAS_ITEM(player, type, doMsgs, LEATHERMAP)) {
                EmptyRoom(player, type, doMsgs);
            }
            else if (RACE(player, type, doMsgs) == life) {
                if ((GET_FLAG(player, type, doMsgs, DUNGEON, LEATHER_MAP) == 0)) {
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
        protected override void FnEvent16(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 6, 2, 105, SOUTH);
        }
        protected override void FnEvent17(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SET_BOOTY(player, type, doMsgs, SHIELDINGSCROLL, MANAELIXIR, 0, 0, 0, 2500);
            SHOW_TEXT(player, type, doMsgs, "You feel a chill as you stumble upon ice monsters.");
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 17);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 14);
                GET_MONSTER(player, type, doMsgs, 02, 14);
                GET_MONSTER(player, type, doMsgs, 03, 31);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 13);
                GET_MONSTER(player, type, doMsgs, 02, 14);
                GET_MONSTER(player, type, doMsgs, 03, 31);
                GET_MONSTER(player, type, doMsgs, 05, 32);
                GET_MONSTER(player, type, doMsgs, 06, 32);
            }
        }
        protected override void FnEvent19(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (RACE(player, type, doMsgs) == ELF) {
                GuildDoor(player, type, doMsgs);
            }
        }
        protected override void FnEvent1A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (RACE(player, type, doMsgs) == DWARF) {
                GuildDoor(player, type, doMsgs);
            }
        }
        protected override void FnEvent1F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (RACE(player, type, doMsgs) == ELF) {
                SHOW_TEXT(player, type, doMsgs, "Use the Coral third.");
            }
        }
        protected override void FnEvent21(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, FOUNTAIN);
            if (RACE(player, type, doMsgs) == GREMLIN) {
                HealFtn(player, type, doMsgs);
                SHOW_TEXT(player, type, doMsgs, "The waters of Gremlin Fountain refresh you and restore your mana.");
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "The waters of Gremlin Fountain have no affect.");
            }
        }
        protected override void FnEvent25(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (RACE(player, type, doMsgs) == GNOME) {
                GuildDoor(player, type, doMsgs);
            }
        }
        protected override void FnEvent28(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (RACE(player, type, doMsgs) == GNOME) {
                SHOW_TEXT(player, type, doMsgs, "Use the Ebony before the Coral.");
            }
        }
        protected override void FnEvent2B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, FOUNTAIN);
            if (RACE(player, type, doMsgs) == HALFLING) {
                HealFtn(player, type, doMsgs);
                SHOW_TEXT(player, type, doMsgs, "The waters of Halfling Fountain refresh and replenish you.");
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "The waters of Halfling Fountain have no affect.");
            }
        }
        protected override void FnEvent2D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 6, 1, 89, SOUTH);
        }
        protected override void FnEvent2F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 6, 3, 11, EAST);
        }
        protected override void FnEvent30(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, FOUNTAIN);
            if (RACE(player, type, doMsgs) == TROLL) {
                HealFtn(player, type, doMsgs);
                SHOW_TEXT(player, type, doMsgs, "The waters of Troll Fountain invigorate you and restore your mana.");
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "The waters of Troll Fountain have no affect.");
            }
        }
        protected override void FnEvent31(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, FOUNTAIN);
            if (RACE(player, type, doMsgs) == HUMAN) {
                HealFtn(player, type, doMsgs);
                SHOW_TEXT(player, type, doMsgs, "The waters of Human Fountain rejuvenate you.");
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "The waters of Human Fountain have no affect.");
            }
        }
        protected override void FnEvent33(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 6, 2, 160, EAST);
        }
        protected override void FnEvent35(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (RACE(player, type, doMsgs) == HALFLING) {
                GuildDoor(player, type, doMsgs);
            }
        }
        protected override void FnEvent38(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SET_BOOTY(player, type, doMsgs, SCROLLOFTHESUN, CURATIVEELIXIR, 0, 0, 0, 1500);
            SHOW_TEXT(player, type, doMsgs, "As you approach a battle, the combatants turn and attack you.");
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 5);
                GET_MONSTER(player, type, doMsgs, 02, 36);
                GET_MONSTER(player, type, doMsgs, 06, 36);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 5);
                GET_MONSTER(player, type, doMsgs, 02, 6);
                GET_MONSTER(player, type, doMsgs, 05, 20);
                GET_MONSTER(player, type, doMsgs, 06, 36);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 27);
                GET_MONSTER(player, type, doMsgs, 02, 27);
                GET_MONSTER(player, type, doMsgs, 03, 28);
                GET_MONSTER(player, type, doMsgs, 05, 35);
                GET_MONSTER(player, type, doMsgs, 06, 37);
            }
        }
        protected override void FnEvent39(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (RACE(player, type, doMsgs) == TROLL) {
                GuildDoor(player, type, doMsgs);
            }
        }
        protected override void FnEvent3A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (RACE(player, type, doMsgs) == TROLL) {
                SHOW_TEXT(player, type, doMsgs, "Use the Opal before the Coral.");
            }
        }
        protected override void FnEvent3E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (RACE(player, type, doMsgs) == ORC) {
                GuildDoor(player, type, doMsgs);
            }
        }
        protected override void FnEvent45(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You watch as passers-by clutch their magic-casting rings and uncover secret passages.");
        }
        protected override void FnEvent46(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "A party of lost adventurers arguing about directions turns and attacks.");
            if (HAS_ITEM(player, type, doMsgs, SCROLLOFDEATH)) {
                SET_BOOTY(player, type, doMsgs, SILVERBAR, BASALTSCROLL, ELIXIROFHEALTH, 0, 0, 2000);
            }
            else {
                SET_BOOTY(player, type, doMsgs, SOLDIERSFLAIL, SCROLLOFDEATH, ELIXIROFHEALTH, 0, 0, 3000);
            }
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 20);
                GET_MONSTER(player, type, doMsgs, 05, 29);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 34);
                GET_MONSTER(player, type, doMsgs, 02, 36);
                GET_MONSTER(player, type, doMsgs, 03, 36);
                GET_MONSTER(player, type, doMsgs, 06, 24);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 34);
                GET_MONSTER(player, type, doMsgs, 02, 36);
                GET_MONSTER(player, type, doMsgs, 03, 37);
                GET_MONSTER(player, type, doMsgs, 05, 39);
                GET_MONSTER(player, type, doMsgs, 06, 40);
            }
        }
        protected override void FnEvent48(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 31);
                GET_MONSTER(player, type, doMsgs, 02, 33);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 17);
                GET_MONSTER(player, type, doMsgs, 02, 13);
                GET_MONSTER(player, type, doMsgs, 06, 32);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 13);
                GET_MONSTER(player, type, doMsgs, 02, 14);
                GET_MONSTER(player, type, doMsgs, 03, 18);
                GET_MONSTER(player, type, doMsgs, 05, 32);
                GET_MONSTER(player, type, doMsgs, 06, 32);
            }
        }
        protected override void FnEvent49(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 3);
                GET_MONSTER(player, type, doMsgs, 02, 1);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 3);
                GET_MONSTER(player, type, doMsgs, 02, 3);
                GET_MONSTER(player, type, doMsgs, 03, 2);
                GET_MONSTER(player, type, doMsgs, 04, 1);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 2);
                GET_MONSTER(player, type, doMsgs, 02, 2);
                GET_MONSTER(player, type, doMsgs, 05, 25);
                GET_MONSTER(player, type, doMsgs, 06, 1);
            }
        }
        protected override void FnEvent4A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 11);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 9);
                GET_MONSTER(player, type, doMsgs, 02, 9);
                GET_MONSTER(player, type, doMsgs, 05, 12);
                GET_MONSTER(player, type, doMsgs, 06, 30);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 9);
                GET_MONSTER(player, type, doMsgs, 02, 9);
                GET_MONSTER(player, type, doMsgs, 03, 12);
                GET_MONSTER(player, type, doMsgs, 05, 30);
                GET_MONSTER(player, type, doMsgs, 06, 30);
            }
        }
        protected override void FnEvent4B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 3);
                GET_MONSTER(player, type, doMsgs, 02, 22);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 3);
                GET_MONSTER(player, type, doMsgs, 02, 3);
                GET_MONSTER(player, type, doMsgs, 03, 20);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 2);
                GET_MONSTER(player, type, doMsgs, 02, 2);
                GET_MONSTER(player, type, doMsgs, 03, 21);
                GET_MONSTER(player, type, doMsgs, 04, 23);
            }
        }
        protected override void FnEvent4D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 22);
                GET_MONSTER(player, type, doMsgs, 02, 36);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 20);
                GET_MONSTER(player, type, doMsgs, 02, 21);
                GET_MONSTER(player, type, doMsgs, 03, 29);
                GET_MONSTER(player, type, doMsgs, 04, 29);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 34);
                GET_MONSTER(player, type, doMsgs, 02, 35);
                GET_MONSTER(player, type, doMsgs, 05, 39);
                GET_MONSTER(player, type, doMsgs, 06, 40);
            }
        }
        protected override void FnEvent4E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 6);
                GET_MONSTER(player, type, doMsgs, 02, 3);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 1);
                GET_MONSTER(player, type, doMsgs, 02, 3);
                GET_MONSTER(player, type, doMsgs, 05, 6);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 6);
                GET_MONSTER(player, type, doMsgs, 02, 6);
                GET_MONSTER(player, type, doMsgs, 03, 5);
                GET_MONSTER(player, type, doMsgs, 05, 2);
                GET_MONSTER(player, type, doMsgs, 06, 3);
            }
        }
        protected override void FnEvent4F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 8);
                GET_MONSTER(player, type, doMsgs, 02, 29);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 8);
                GET_MONSTER(player, type, doMsgs, 02, 8);
                GET_MONSTER(player, type, doMsgs, 03, 24);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 8);
                GET_MONSTER(player, type, doMsgs, 02, 8);
                GET_MONSTER(player, type, doMsgs, 03, 9);
                GET_MONSTER(player, type, doMsgs, 05, 22);
                GET_MONSTER(player, type, doMsgs, 06, 24);
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
        private void GlimpseMap(TwPlayerServer player, MapEventType type, bool doMsgs) {
            GIVE_ITEM(player, type, doMsgs, LEATHERMAP);
            SHOW_TEXT(player, type, doMsgs, "You glimpse a scrap of leather on the floor.");
            SHOW_TEXT(player, type, doMsgs, "It is a Leather Map and is one of the four Queen Aeowyn sent you to find.");
        }
        private void EmptyRoom(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "The room is empty.");
        }
        private void HealFtn(TwPlayerServer player, MapEventType type, bool doMsgs) {
            HEAL(player, type, doMsgs, MAX_HEALTH(player, type, doMsgs));
            MOD_MANA(player, type, doMsgs, 10000);
        }
        private void WallClear(TwPlayerServer player, MapEventType type, bool doMsgs) {
            CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
        }
        private void WallBlock(TwPlayerServer player, MapEventType type, bool doMsgs) {
            BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
        }
        private void BootyStr(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SET_BOOTY(player, type, doMsgs, ELIXIROFHEALTH, BLUELOCKPICK, 0, 0, 0, 1500);
        }
        private void DoorHere(TwPlayerServer player, MapEventType type, bool doMsgs) {
            PLACE_WALL_ITEM(player, type, doMsgs, DOOR, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
        }
    }
}
