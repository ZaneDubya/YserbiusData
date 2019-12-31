using XPT.Generic.Maps;
using XPT.Twinion.Entities;

namespace XPT.Twinion.Maps {
    class TwMap25 : TwMap {
        protected override int MapIndex => 25;
        protected override int MapID => 0x0A03;
        protected override int RandomEncounterChance => 15;
        protected override int RandomEncounterExtraCount => 2;

        private const int PANSTAR = 1;
        private const int PORT = 2;
        protected override void FnEvent01(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 10, 3, 159, SOUTH);
        }
        protected override void FnEvent02(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 11, 1, 175, NORTH);
            TAKE_ITEM(player, type, doMsgs, HOPESFURY);
            TAKE_ITEM(player, type, doMsgs, FLASKOFSHADOWFALL);
            TAKE_ITEM(player, type, doMsgs, NIMBUSOFTHEFATES);
            TAKE_ITEM(player, type, doMsgs, REALITYSRAMPART);
        }
        protected override void FnEvent03(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 10, 3, 46, NORTH);
        }
        protected override void FnEvent04(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 10, 3, 176, SOUTH);
        }
        protected override void FnEvent05(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 11, 3, 16, NORTH);
            TAKE_ITEM(player, type, doMsgs, ICEFLAME);
            TAKE_ITEM(player, type, doMsgs, HOPESFURY);
            TAKE_ITEM(player, type, doMsgs, FLASKOFSHADOWFALL);
            TAKE_ITEM(player, type, doMsgs, NIMBUSOFTHEFATES);
        }
        protected override void FnEvent06(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 10, 3, 172, NORTH);
        }
        protected override void FnEvent07(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 11, 1, 241, NORTH);
            TAKE_ITEM(player, type, doMsgs, ICEFLAME);
            TAKE_ITEM(player, type, doMsgs, HOPESFURY);
            TAKE_ITEM(player, type, doMsgs, NIMBUSOFTHEFATES);
            TAKE_ITEM(player, type, doMsgs, REALITYSRAMPART);
        }
        protected override void FnEvent08(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 10, 3, 110, WEST);
        }
        protected override void FnEvent09(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 11, 1, 40, SOUTH);
            TAKE_ITEM(player, type, doMsgs, ICEFLAME);
            TAKE_ITEM(player, type, doMsgs, FLASKOFSHADOWFALL);
            TAKE_ITEM(player, type, doMsgs, NIMBUSOFTHEFATES);
            TAKE_ITEM(player, type, doMsgs, REALITYSRAMPART);
        }
        protected override void FnEvent0A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 11, 3, 240, EAST);
            TAKE_ITEM(player, type, doMsgs, FLASKOFSHADOWFALL);
            TAKE_ITEM(player, type, doMsgs, ICEFLAME);
            TAKE_ITEM(player, type, doMsgs, HOPESFURY);
            TAKE_ITEM(player, type, doMsgs, REALITYSRAMPART);
        }
        protected override void FnEvent0B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You quickly jump out of the way of a falling boulder.");
            TELEPORT(player, type, doMsgs, 10, 3, 233, NORTH);
        }
        protected override void FnEvent0C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 10, 3, 19, EAST);
        }
        protected override void FnEvent0D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, ROOM, PORT) == 0) {
                if (GET_FLAG(player, type, doMsgs, PARTY, PANSTAR) == 1) {
                    TELEPORT(player, type, doMsgs, 10, 3, 35, WEST);
                    SET_FLAG(player, type, doMsgs, ROOM, PORT, 1);
                }
            }
        }
        protected override void FnEvent0E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 10, 3, 83, SOUTH);
        }
        protected override void FnEvent0F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, DUNGEON, PANHEAL) == 1) {
                SHOW_TEXT(player, type, doMsgs, "The alcove is empty.");
            }
            else {
                SET_FLAG(player, type, doMsgs, DUNGEON, PANHEAL, 1);
                GIVE_ITEM(player, type, doMsgs, HEALAMPHORA);
                GIVE_ITEM(player, type, doMsgs, HEALAMPHORA);
                GIVE_ITEM(player, type, doMsgs, SCORCHEDSCROLL);
                SHOW_TEXT(player, type, doMsgs, "Next to the obvious remains of a long time dead adventurer you are surprised to find some items intact.");
            }
        }
        protected override void FnEvent10(TwPlayerServer player, MapEventType type, bool doMsgs) {
            MOD_MANA(player, type, doMsgs,  - 200);
            SHOW_TEXT(player, type, doMsgs, "Your constant running into invisible walls has taken a toll on your mana.");
            BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), SOUTH);
        }
        protected override void FnEvent11(TwPlayerServer player, MapEventType type, bool doMsgs) {
            BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
        }
        protected override void FnEvent12(TwPlayerServer player, MapEventType type, bool doMsgs) {
            NO_SKILL(player, type, doMsgs);
            NO_SPELL(player, type, doMsgs);
        }
        protected override void FnEvent13(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, DUNGEON, PANSCROLL) == 1) {
                SHOW_TEXT(player, type, doMsgs, "You see nothing of interest here.");
            }
            else {
                SHOW_PICTURE(player, type, doMsgs, DWARFWIZARD);
                SET_FLAG(player, type, doMsgs, DUNGEON, PANSCROLL, 1);
                GIVE_ITEM(player, type, doMsgs, ZEUSSCROLL);
                GIVE_ITEM(player, type, doMsgs, PUMMELSCROLL);
                GIVE_ITEM(player, type, doMsgs, SHIELDINGSCROLL);
                MOD_GOLD(player, type, doMsgs,  - 10000);
                SHOW_TEXT(player, type, doMsgs, "You encounter a wizard selling scrolls.");
                SHOW_TEXT(player, type, doMsgs, "'I see that you will be in need of magic as you travel through this area.  I accept your payment for these scrolls. May they aid you in your journey.'");
            }
        }
        protected override void FnEvent14(TwPlayerServer player, MapEventType type, bool doMsgs) {
            BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), NORTH);
            BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), SOUTH);
            NO_HEAL_ZONE(player, type, doMsgs);
            if ((GET_FLAG(player, type, doMsgs, ROOM, PORT) == 0)) {
                SHOW_TEXT(player, type, doMsgs, "The water drains your energy as you wade through it.");
                DAMAGE(player, type, doMsgs, MAX_HEALTH(player, type, doMsgs) / 4);
                SET_FLAG(player, type, doMsgs, ROOM, PORT, 1);
            }
        }
        protected override void FnEvent16(TwPlayerServer player, MapEventType type, bool doMsgs) {
            BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), EAST);
            BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), WEST);
            NO_HEAL_ZONE(player, type, doMsgs);
            if ((GET_FLAG(player, type, doMsgs, ROOM, PORT) == 0)) {
                if (GUILD(player, type, doMsgs) == RANGER || GUILD(player, type, doMsgs) == CLERIC || GUILD(player, type, doMsgs) == WIZARD) {
                    SHOW_TEXT(player, type, doMsgs, "A water monster attacks you, but you manage to get away with minimal damage.");
                    DAMAGE(player, type, doMsgs, MAX_HEALTH(player, type, doMsgs) / 4);
                    SET_FLAG(player, type, doMsgs, ROOM, PORT, 1);
                }
            }
        }
        protected override void FnEvent18(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You fall into a bottomless pit.");
            DAMAGE(player, type, doMsgs, MAX_HEALTH(player, type, doMsgs));
        }
        protected override void FnEvent1A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), NORTH);
            BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), WEST);
            if (GET_FLAG(player, type, doMsgs, DUNGEON, PANMANA) == 1) {
                SHOW_TEXT(player, type, doMsgs, "The water flows briskly around you.");
            }
            else {
                SET_FLAG(player, type, doMsgs, DUNGEON, PANMANA, 1);
                GIVE_ITEM(player, type, doMsgs, MANAAMPHORA);
                SHOW_TEXT(player, type, doMsgs, "You see something bobbing in the water and grab it.");
            }
        }
        protected override void FnEvent1B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), NORTH);
            BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), SOUTH);
            NO_HEAL_ZONE(player, type, doMsgs);
            if ((GET_FLAG(player, type, doMsgs, ROOM, PORT) == 0)) {
                if (GUILD(player, type, doMsgs) == THIEF || GUILD(player, type, doMsgs) == BARBARIAN || GUILD(player, type, doMsgs) == KNIGHT) {
                    SHOW_TEXT(player, type, doMsgs, "A water monster attacks you, but you manage to get away with minimal damage.");
                    DAMAGE(player, type, doMsgs, MAX_HEALTH(player, type, doMsgs) / 4);
                    SET_FLAG(player, type, doMsgs, ROOM, PORT, 1);
                }
            }
        }
        protected override void FnEvent1D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HAS_ITEM(player, type, doMsgs, STARBURST)) {
                CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), NORTH);
            }
            else {
                BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), NORTH);
            }
        }
        protected override void FnEvent1E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), NORTH);
            BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), SOUTH);
            NO_HEAL_ZONE(player, type, doMsgs);
            if ((GET_FLAG(player, type, doMsgs, ROOM, PORT) == 0)) {
                SHOW_TEXT(player, type, doMsgs, "The heat of the surrounding lava makes you weak.");
                DAMAGE(player, type, doMsgs, MAX_HEALTH(player, type, doMsgs) / 4);
                SET_FLAG(player, type, doMsgs, ROOM, PORT, 1);
            }
        }
        protected override void FnEvent1F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), NORTH);
            BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), SOUTH);
            BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), EAST);
            if (GET_FLAG(player, type, doMsgs, DUNGEON, PANMONEY) == 1) {
                SHOW_TEXT(player, type, doMsgs, "You find nothing.");
            }
            else {
                SET_FLAG(player, type, doMsgs, DUNGEON, PANMONEY, 1);
                GIVE_ITEM(player, type, doMsgs, THIEFSSTILETTO);
                GIVE_ITEM(player, type, doMsgs, DRAGONSSTONE);
                GIVE_ITEM(player, type, doMsgs, PLATINUMBAR);
                GIVE_ITEM(player, type, doMsgs, RINGOFTHIEVES);
                SHOW_TEXT(player, type, doMsgs, "Protruding from the hardened lava you find a bag.  You free it and pocket the contents.");
            }
        }
        protected override void FnEvent20(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HAS_ITEM(player, type, doMsgs, STARBURST)) {
                CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), SOUTH);
            }
            else {
                BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), SOUTH);
            }
        }
        protected override void FnEvent21(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You see a sign on the door. 'Adventurers!  Proceed through this door individually if you possess the magical Starburst.'");
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                if (HAS_ITEM(player, type, doMsgs, STARBURST)) {
                    CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
                }
                else {
                    BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
                    SHOW_TEXT(player, type, doMsgs, "You must find the magical Starburst to gain entry.");
                }
            }
            else {
                BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
            }
        }
        protected override void FnEvent22(TwPlayerServer player, MapEventType type, bool doMsgs) {
            BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), NORTH);
            BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), WEST);
            NO_HEAL_ZONE(player, type, doMsgs);
            if ((GET_FLAG(player, type, doMsgs, ROOM, PORT) == 0)) {
                if (GUILD(player, type, doMsgs) == THIEF || GUILD(player, type, doMsgs) == BARBARIAN || GUILD(player, type, doMsgs) == KNIGHT) {
                    SHOW_TEXT(player, type, doMsgs, "Your heavy step causes a crack in the hardened lava and the still molten lava below splashes up and injures you.");
                    DAMAGE(player, type, doMsgs, MAX_HEALTH(player, type, doMsgs) / 4);
                    SET_FLAG(player, type, doMsgs, ROOM, PORT, 1);
                }
            }
        }
        protected override void FnEvent23(TwPlayerServer player, MapEventType type, bool doMsgs) {
            BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), NORTH);
            NO_HEAL_ZONE(player, type, doMsgs);
            if ((GET_FLAG(player, type, doMsgs, ROOM, PORT) == 0)) {
                if (GUILD(player, type, doMsgs) == RANGER || GUILD(player, type, doMsgs) == CLERIC || GUILD(player, type, doMsgs) == WIZARD) {
                    SHOW_TEXT(player, type, doMsgs, "Your heavy step causes a crack in the hardened lava and the still molten lava below splashes up and injures you.");
                    DAMAGE(player, type, doMsgs, MAX_HEALTH(player, type, doMsgs) / 4);
                    SET_FLAG(player, type, doMsgs, ROOM, PORT, 1);
                }
            }
        }
        protected override void FnEvent24(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "The swirling waters of Bedlam Whirlpool heal your wounds.");
            HEAL(player, type, doMsgs, MAX_HEALTH(player, type, doMsgs));
        }
        protected override void FnEvent25(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HAS_ITEM(player, type, doMsgs, STARBURST)) {
                BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), EAST);
            }
            else {
                CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), EAST);
            }
        }
        protected override void FnEvent26(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HAS_ITEM(player, type, doMsgs, STARBURST)) {
                SHOW_TEXT(player, type, doMsgs, "The crusted lava allows for easy passage.");
            }
            else {
                SHOW_PICTURE(player, type, doMsgs, ELFCLERIC);
                SHOW_TEXT(player, type, doMsgs, "You help a Cleric free his trapped foot from a crack in the lava. 'Thank you for helping me. Please accept this talisman with my gratitude. May it aid you in your travels.");
                SHOW_TEXT(player, type, doMsgs, "It has gotten me out of a few rocky situations.'");
                GIVE_ITEM(player, type, doMsgs, STARBURST);
            }
        }
        protected override void FnEvent29(TwPlayerServer player, MapEventType type, bool doMsgs) {
            BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), EAST);
            NO_HEAL_ZONE(player, type, doMsgs);
            if ((GET_FLAG(player, type, doMsgs, ROOM, PORT) == 0)) {
                SHOW_TEXT(player, type, doMsgs, "You cut yourself on the jagged rock wall.");
                DAMAGE(player, type, doMsgs, MAX_HEALTH(player, type, doMsgs) / 3);
                SET_FLAG(player, type, doMsgs, ROOM, PORT, 1);
            }
        }
        protected override void FnEvent2A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), SOUTH);
            BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), WEST);
            if (GET_FLAG(player, type, doMsgs, DUNGEON, PANLIFE) == 1) {
                SHOW_TEXT(player, type, doMsgs, "You see a hole in the wall.");
            }
            else {
                SET_FLAG(player, type, doMsgs, DUNGEON, PANLIFE, 1);
                SHOW_TEXT(player, type, doMsgs, "You see forgotten items resting on a ledge in the wall.");
                GIVE_ITEM(player, type, doMsgs, SYMBOLOFDEATH);
                GIVE_ITEM(player, type, doMsgs, SPIKEDSHIELD);
                GIVE_ITEM(player, type, doMsgs, LIFEGIVER);
                GIVE_ITEM(player, type, doMsgs, CUREALLPOTION);
            }
        }
        protected override void FnEvent2B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), NORTH);
            BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), EAST);
            BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), SOUTH);
            SHOW_TEXT(player, type, doMsgs, "The Lava Pool of Confusion restores your mana.");
            MOD_MANA(player, type, doMsgs, 10000);
        }
        protected override void FnEvent2C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HAS_ITEM(player, type, doMsgs, STARBURST)) {
                BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
                SHOW_TEXT(player, type, doMsgs, "You find that a boulder has blocked your path.");
                if ((USED_ITEM(player, type, doMsgs, STARBURST, STARBURST)) && (GUILD(player, type, doMsgs) == GNOME || GUILD(player, type, doMsgs) == ELF)) {
                    SET_FLAG(player, type, doMsgs, PARTY, PANSTAR, 1);
                    CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
                    SHOW_TEXT(player, type, doMsgs, "The magical Starburst shatters the boulder.");
                }
                else {
                    SHOW_TEXT(player, type, doMsgs, "You cannot budge the boulder.");
                }
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "The ground shows signs of damage from heavy boulders falling.");
                CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
            }
        }
        protected override void FnEvent2D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HAS_ITEM(player, type, doMsgs, STARBURST)) {
                BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
                SHOW_TEXT(player, type, doMsgs, "You find that a boulder has blocked your path.");
                if ((USED_ITEM(player, type, doMsgs, STARBURST, STARBURST)) && (GUILD(player, type, doMsgs) == ORC || GUILD(player, type, doMsgs) == GREMLIN)) {
                    SET_FLAG(player, type, doMsgs, PARTY, PANSTAR, 1);
                    CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
                    SHOW_TEXT(player, type, doMsgs, "The magical Starburst shatters the boulder.");
                }
                else {
                    SHOW_TEXT(player, type, doMsgs, "You cannot budge the boulder.");
                }
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "The ground shows signs of damage from heavy boulders falling.");
                CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
            }
        }
        protected override void FnEvent2E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HAS_ITEM(player, type, doMsgs, STARBURST)) {
                BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
                SHOW_TEXT(player, type, doMsgs, "You find that a boulder has blocked your path.");
                if ((USED_ITEM(player, type, doMsgs, STARBURST, STARBURST)) && (GUILD(player, type, doMsgs) == DWARF || GUILD(player, type, doMsgs) == TROLL)) {
                    SET_FLAG(player, type, doMsgs, PARTY, PANSTAR, 1);
                    CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
                    SHOW_TEXT(player, type, doMsgs, "The magical Starburst shatters the boulder.");
                }
                else {
                    SHOW_TEXT(player, type, doMsgs, "You cannot budge the boulder.");
                }
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "The ground shows signs of damage from heavy boulders falling.");
                CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
            }
        }
        protected override void FnEvent2F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HAS_ITEM(player, type, doMsgs, STARBURST)) {
                BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
                SHOW_TEXT(player, type, doMsgs, "You find that a boulder has blocked your path.");
                if ((USED_ITEM(player, type, doMsgs, STARBURST, STARBURST)) && (GUILD(player, type, doMsgs) == HALFLING || GUILD(player, type, doMsgs) == HUMAN)) {
                    SET_FLAG(player, type, doMsgs, PARTY, PANSTAR, 1);
                    CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
                    SHOW_TEXT(player, type, doMsgs, "The magical Starburst shatters the boulder.");
                }
                else {
                    SHOW_TEXT(player, type, doMsgs, "You cannot budge the boulder.");
                }
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "The ground shows signs of damage from heavy boulders falling.");
                CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
            }
        }
        protected override void FnEvent30(TwPlayerServer player, MapEventType type, bool doMsgs) {
            BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), NORTH);
            BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), WEST);
            if (GET_FLAG(player, type, doMsgs, DUNGEON, PANBUCKS) == 1) {
                SHOW_TEXT(player, type, doMsgs, "There is nothing but rubble on the ground.");
            }
            else {
                SET_FLAG(player, type, doMsgs, DUNGEON, PANBUCKS, 1);
                SHOW_TEXT(player, type, doMsgs, "Upon searching the alcove you move a rock and discover treasure.");
                GIVE_ITEM(player, type, doMsgs, TEMPEREDADAMANTINE);
                GIVE_ITEM(player, type, doMsgs, PLATINUMBAR);
                GIVE_ITEM(player, type, doMsgs, PRIESTSAMULET);
                GIVE_ITEM(player, type, doMsgs, CRYSTALBALL);
            }
        }
        protected override void FnEvent31(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, GNOMEWIZARD);
            SHOW_TEXT(player, type, doMsgs, "You encounter a Gnome Wizard who stops you in your path. ");
            SHOW_TEXT(player, type, doMsgs, "'This place is pandemonium.  My skills and spells are useless in places.'");
        }
        protected override void FnEvent32(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, STORMGIANT);
            SHOW_TEXT(player, type, doMsgs, "'You have come to the area where you must decide which path to follow in your search for each of the Dralkarians.  Guard well your magical Starburst for it will grant you passage to the portals.'");
            SHOW_TEXT(player, type, doMsgs, "'May your choices be wise and your journeys successful.'");
        }
        protected override void FnEvent33(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, GREMLINTHIEF);
            SHOW_TEXT(player, type, doMsgs, "A thief pulls you aside. 'Pssst....I found a way to walk over the lava.  Just be sure it's crusted over.  Shhhhh, don't tell a soul.'");
        }
        protected override void FnEvent34(TwPlayerServer player, MapEventType type, bool doMsgs) {
            BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), NORTH);
            BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), SOUTH);
            BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), WEST);
            SHOW_TEXT(player, type, doMsgs, "You see a hand written note on the back of a scroll.  It warns that what may harm one, may not harm another.");
        }
        protected override void FnEvent35(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, COMMONNIGHTELF);
            SHOW_TEXT(player, type, doMsgs, "'The time has come for you to begin your journey to meet the Dralkarians. You must travel through Pandemonium in order to seek the portals to the final paths. Of the 5 portals you shall make your choice.'");
        }
        protected override void FnEvent37(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 1);
                GET_MONSTER(player, type, doMsgs, 05, 2);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 1);
                GET_MONSTER(player, type, doMsgs, 02, 2);
                GET_MONSTER(player, type, doMsgs, 05, 3);
                GET_MONSTER(player, type, doMsgs, 06, 3);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 1);
                GET_MONSTER(player, type, doMsgs, 02, 1);
                GET_MONSTER(player, type, doMsgs, 03, 2);
                GET_MONSTER(player, type, doMsgs, 04, 2);
                GET_MONSTER(player, type, doMsgs, 05, 3);
            }
        }
        protected override void FnEvent38(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 32);
                GET_MONSTER(player, type, doMsgs, 02, 33);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 31);
                GET_MONSTER(player, type, doMsgs, 02, 31);
                GET_MONSTER(player, type, doMsgs, 03, 32);
                GET_MONSTER(player, type, doMsgs, 04, 33);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 31);
                GET_MONSTER(player, type, doMsgs, 02, 31);
                GET_MONSTER(player, type, doMsgs, 03, 33);
                GET_MONSTER(player, type, doMsgs, 04, 33);
                GET_MONSTER(player, type, doMsgs, 06, 34);
            }
        }
        protected override void FnEvent39(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 17);
                GET_MONSTER(player, type, doMsgs, 02, 19);
                GET_MONSTER(player, type, doMsgs, 06, 30);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 19);
                GET_MONSTER(player, type, doMsgs, 02, 20);
                GET_MONSTER(player, type, doMsgs, 05, 30);
                GET_MONSTER(player, type, doMsgs, 06, 28);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 17);
                GET_MONSTER(player, type, doMsgs, 02, 17);
                GET_MONSTER(player, type, doMsgs, 04, 30);
                GET_MONSTER(player, type, doMsgs, 05, 28);
                GET_MONSTER(player, type, doMsgs, 06, 29);
            }
        }
        protected override void FnEvent3A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 26);
                GET_MONSTER(player, type, doMsgs, 05, 38);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 26);
                GET_MONSTER(player, type, doMsgs, 02, 27);
                GET_MONSTER(player, type, doMsgs, 03, 28);
                GET_MONSTER(player, type, doMsgs, 04, 38);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 26);
                GET_MONSTER(player, type, doMsgs, 02, 26);
                GET_MONSTER(player, type, doMsgs, 04, 27);
                GET_MONSTER(player, type, doMsgs, 05, 37);
                GET_MONSTER(player, type, doMsgs, 06, 38);
            }
        }
        protected override void FnEvent3B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 39);
                GET_MONSTER(player, type, doMsgs, 05, 40);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 39);
                GET_MONSTER(player, type, doMsgs, 02, 39);
                GET_MONSTER(player, type, doMsgs, 03, 40);
                GET_MONSTER(player, type, doMsgs, 06, 25);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 40);
                GET_MONSTER(player, type, doMsgs, 02, 40);
                GET_MONSTER(player, type, doMsgs, 03, 39);
                GET_MONSTER(player, type, doMsgs, 05, 25);
                GET_MONSTER(player, type, doMsgs, 06, 25);
            }
        }
        protected override void FnEvent3C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), EAST);
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 1);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 1);
                GET_MONSTER(player, type, doMsgs, 02, 3);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 1);
                GET_MONSTER(player, type, doMsgs, 02, 4);
                GET_MONSTER(player, type, doMsgs, 05, 33);
                GET_MONSTER(player, type, doMsgs, 06, 33);
            }
        }
        protected override void FnEvent3D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 13);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 12);
                GET_MONSTER(player, type, doMsgs, 02, 13);
                GET_MONSTER(player, type, doMsgs, 03, 36);
                GET_MONSTER(player, type, doMsgs, 04, 36);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 12);
                GET_MONSTER(player, type, doMsgs, 02, 12);
                GET_MONSTER(player, type, doMsgs, 03, 13);
                GET_MONSTER(player, type, doMsgs, 04, 13);
                GET_MONSTER(player, type, doMsgs, 05, 36);
            }
        }
        protected override void FnEvent3E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                SHOW_TEXT(player, type, doMsgs, "Now you may proceed to pick the path of your choice.");
            }
            else {
                TELEPORT(player, type, doMsgs, 10, 3, 34, EAST);
            }
        }
        protected override void FnEvent3F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), NORTH);
        }
        protected override void FnEvent40(TwPlayerServer player, MapEventType type, bool doMsgs) {
            BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), EAST);
        }
        protected override void FnEvent41(TwPlayerServer player, MapEventType type, bool doMsgs) {
            BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), WEST);
        }
        protected override void FnEvent42(TwPlayerServer player, MapEventType type, bool doMsgs) {
            BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), SOUTH);
        }
        protected override void FnEvent43(TwPlayerServer player, MapEventType type, bool doMsgs) {
            BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), SOUTH);
            BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), WEST);
        }
        protected override void FnEvent44(TwPlayerServer player, MapEventType type, bool doMsgs) {
            BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), EAST);
            BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), WEST);
        }
        protected override void FnEvent45(TwPlayerServer player, MapEventType type, bool doMsgs) {
            BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), NORTH);
            BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), WEST);
        }
        protected override void FnEvent46(TwPlayerServer player, MapEventType type, bool doMsgs) {
            BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), NORTH);
            BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), SOUTH);
        }
        protected override void FnEvent47(TwPlayerServer player, MapEventType type, bool doMsgs) {
            BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), EAST);
            BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), SOUTH);
        }
        protected override void FnEvent48(TwPlayerServer player, MapEventType type, bool doMsgs) {
            BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), NORTH);
            BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), EAST);
        }
        protected override void FnEvent49(TwPlayerServer player, MapEventType type, bool doMsgs) {
            BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), NORTH);
            BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), SOUTH);
            BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), EAST);
        }
        protected override void FnEvent4A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), EAST);
            BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), SOUTH);
            BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), WEST);
        }
        protected override void FnEvent4B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), NORTH);
            BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), EAST);
            BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), WEST);
        }
        protected override void FnEvent4C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), NORTH);
            BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), SOUTH);
            BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), WEST);
        }
        protected override void FnEvent4D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HAS_ITEM(player, type, doMsgs, STARBURST)) {
                BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), WEST);
            }
            else {
                CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), WEST);
            }
        }
        protected override void FnEvent4E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HAS_ITEM(player, type, doMsgs, STARBURST)) {
                CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), SOUTH);
            }
            else {
                BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), SOUTH);
            }
        }
        protected override void FnEvent4F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HAS_ITEM(player, type, doMsgs, STARBURST)) {
                BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), WEST);
            }
            else {
                CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), WEST);
            }
        }
        protected override void FnEvent50(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HAS_ITEM(player, type, doMsgs, STARBURST)) {
                CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), SOUTH);
            }
            else {
                BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), SOUTH);
            }
        }
        protected override void FnEvent51(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HAS_ITEM(player, type, doMsgs, STARBURST)) {
                BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), EAST);
                CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), SOUTH);
            }
            else {
                CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), EAST);
                BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), SOUTH);
            }
        }
        protected override void FnEvent52(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HAS_ITEM(player, type, doMsgs, STARBURST)) {
                BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), SOUTH);
            }
            else {
                CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), SOUTH);
            }
        }
        protected override void FnEvent53(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HAS_ITEM(player, type, doMsgs, STARBURST)) {
                BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), NORTH);
            }
            else {
                CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), NORTH);
            }
        }
        protected override void FnEvent54(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Proceed through this door and accept the challenge of the elements in order to gain access to Malos, the Dralkarian who controls the elements. Be aware that all Quest items gained from other paths will be taken from you.");
        }
        protected override void FnEvent55(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Step through this door to overcome physical obstacles on your path to Corpeus, the Dralkarian who guards the gate. Be aware that all Quest items gained from other paths will be taken from you.");
        }
        protected override void FnEvent56(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "This door will lead you to the path through Enakkar in your search for the Dralkarian Juvalad. Be aware that all Quest items from other paths will be taken from you.");
        }
        protected override void FnEvent57(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Through this door is Ashakkar. Succeed in your quest and you will find the Dralkarian Pluthros.  Be aware that all Quest items from other paths will be taken from you.");
        }
        protected override void FnEvent58(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Inside, a portal will teleport you to the astral path in order to find the Dralkarian guard Astelligus. Be aware that all Quest items from other paths will be taken from you.");
        }
    }
}
