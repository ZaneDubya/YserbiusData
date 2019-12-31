using XPT.Generic.Maps;
using XPT.Twinion.Entities;

namespace XPT.Twinion.Maps {
    class TwMap14 : TwMap {
        protected override int MapIndex => 14;
        protected override int MapID => 0x0601;
        protected override int RandomEncounterChance => 10;
        protected override int RandomEncounterExtraCount => 2;

        private const int DETECTED_DOOR = 1;
        private const int KEEPPIT = 2;
        private const int TROUGH = 3;
        protected override void FnEvent01(TwPlayerServer player, MapEventType type, bool doMsgs) {
            CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
        }
        protected override void FnEvent02(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "A voice from the shadows whispers, 'Ah, another adventurer seeking to be the Queen's Champion, no doubt.");
            SHOW_TEXT(player, type, doMsgs, "One tip, youngling, there's a magical force that returns most Quest items back to where they came should you accidentally drop them.'");
        }
        protected override void FnEvent03(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 6, 1, 40, WEST);
        }
        protected override void FnEvent04(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You step into the hot lava.");
            DamXit(player, type, doMsgs);
        }
        protected override void FnEvent05(TwPlayerServer player, MapEventType type, bool doMsgs) {
            FntnPic(player, type, doMsgs);
            SHOW_TEXT(player, type, doMsgs, "The sweet waters of the Fountain of Nectar restore your mana.");
            MOD_MANA(player, type, doMsgs, 10000);
        }
        protected override void FnEvent06(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Pass through this portal to Tipekans.");
            TELEPORT(player, type, doMsgs, 7, 1, 32, EAST);
        }
        protected override void FnEvent07(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, ROOM, KEEPPIT) == 0) {
                SHOW_TEXT(player, type, doMsgs, "The pit isn't as deep as you feared, but you injure your ankle.");
                DAMAGE(player, type, doMsgs, MAX_HEALTH(player, type, doMsgs) / 10);
                SET_FLAG(player, type, doMsgs, ROOM, KEEPPIT, 1);
            }
        }
        protected override void FnEvent08(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, DWARFWIZARD);
            SHOW_TEXT(player, type, doMsgs, "You see a dwarf shaking her head. She turns to you and says, 'The graveyard is very dark. You must rely upon your wits and skills to get you through.");
            SHOW_TEXT(player, type, doMsgs, "Having something that sheds a little light for you wouldn't hurt, either.'");
        }
        protected override void FnEvent09(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((USED_SKILL(player, type, doMsgs, DETECT_SKILL) >= 6 || USED_SPELL(player, type, doMsgs, TRUE_SEEING_SPELL) || USED_ITEM(player, type, doMsgs, HELMOFWISDOM, HELMOFWISDOM) || USED_ITEM(player, type, doMsgs, VALKYRIESHELM, VALKYRIESHELM) || USED_ITEM(player, type, doMsgs, RINGOFTHIEVES, RINGOFTHIEVES) || USED_ITEM(player, type, doMsgs, CRYSTALBALL, CRYSTALBALL)) || (FLAG_ON(player, type, doMsgs, ROOM, DETECTED_DOOR))) {
                SET_FLAG(player, type, doMsgs, ROOM, DETECTED_DOOR, 1);
                if (USED_ITEM(player, type, doMsgs, BLUELOCKPICK, BLUELOCKPICK) || USED_ITEM(player, type, doMsgs, HELMOFGUILE, HELMOFGUILE) || USED_SKILL(player, type, doMsgs, LOCKPICK_SKILL) >= 6) {
                    DoorHere(player, type, doMsgs);
                    WallClear(player, type, doMsgs);
                    SHOW_TEXT(player, type, doMsgs, "You successfully pick the lock.");
                }
                else {
                    WallBlock(player, type, doMsgs);
                    DoorHere(player, type, doMsgs);
                    SHOW_TEXT(player, type, doMsgs, "A locked door appears in the wall.");
                }
            }
            else {
                WallBlock(player, type, doMsgs);
            }
        }
        protected override void FnEvent0A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 6, 1, 13, EAST);
        }
        protected override void FnEvent0B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 6, 1, 210, SOUTH);
        }
        protected override void FnEvent0C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 5, 1, 70, EAST);
        }
        protected override void FnEvent0D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 6, 1, 72, NORTH);
        }
        protected override void FnEvent0E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GUILD(player, type, doMsgs) == BARBARIAN) {
                if (HAS_ITEM(player, type, doMsgs, SKELETONKEY)) {
                    SHOW_TEXT(player, type, doMsgs, "The room is empty.");
                }
                else if (GET_FLAG(player, type, doMsgs, DUNGEON, ARMORY_ITEM) == 1) {
                    GIVE_ITEM(player, type, doMsgs, SKELETONKEY);
                    SHOW_TEXT(player, type, doMsgs, "You find a key which may open seemingly impassable doors in your race to finish Queen Aeowyn's Map Quest.");
                    SHOW_TEXT(player, type, doMsgs, "The key is made of bone and features a skull and crossed arm bones.");
                }
                else {
                    GIVE_ITEM(player, type, doMsgs, SKELETONKEY);
                    SHOW_TEXT(player, type, doMsgs, "Your Guildmaster left you a special key that will give you access to magical armor.");
                    SHOW_TEXT(player, type, doMsgs, "The key is made of bone. The grasp is shaped like a skull and the shaft like two crossed, bony arms.");
                }
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "The room is bare.");
            }
        }
        protected override void FnEvent0F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You walk into a lair.");
            if (HAS_ITEM(player, type, doMsgs, SCROLLOFDEATH)) {
                SET_BOOTY(player, type, doMsgs, BLUELOCKPICK, SCROLLOFTHESUN, 0, 0, 0, 1000);
            }
            else {
                SET_BOOTY(player, type, doMsgs, BLUELOCKPICK, SCROLLOFDEATH, CURATIVEELIXIR, 0, 0, 3000);
            }
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 1);
                GET_MONSTER(player, type, doMsgs, 02, 25);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 2);
                GET_MONSTER(player, type, doMsgs, 02, 3);
                GET_MONSTER(player, type, doMsgs, 06, 1);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 2);
                GET_MONSTER(player, type, doMsgs, 02, 2);
                GET_MONSTER(player, type, doMsgs, 03, 3);
                GET_MONSTER(player, type, doMsgs, 04, 4);
                GET_MONSTER(player, type, doMsgs, 05, 27);
            }
        }
        protected override void FnEvent10(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, HALFLINGCLERIC);
            SHOW_TEXT(player, type, doMsgs, "A cleric pulls you aside and whispers, 'It is rumored that there are areas in the dungeon that can be accessed only by certain races or guilds.'");
        }
        protected override void FnEvent11(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GUILD(player, type, doMsgs) == BARBARIAN) {
                SHOW_TEXT(player, type, doMsgs, "A sign on the door says, 'BARBARIANS ONLY.'");
                DoorHere(player, type, doMsgs);
                WallClear(player, type, doMsgs);
            }
            else {
                WallBlock(player, type, doMsgs);
            }
        }
        protected override void FnEvent12(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "A sign reads 'This path leads to Lake Despair.'");
            TELEPORT(player, type, doMsgs, 5, 1, 16, NORTH);
        }
        protected override void FnEvent13(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "The opening of the ground may have affected the stability of the walls.");
            WallClear(player, type, doMsgs);
        }
        protected override void FnEvent14(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "While admiring the plaques you are attacked.");
            if (HAS_ITEM(player, type, doMsgs, MANARESTORE)) {
                SET_BOOTY(player, type, doMsgs, MANAELIXIR, SHAMANSCROLL, 0, 0, 0, 1500);
            }
            else {
                SET_BOOTY(player, type, doMsgs, MANARESTORE, SCROLLOFTHESUN, 0, 0, 0, 3000);
            }
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 8);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 5);
                GET_MONSTER(player, type, doMsgs, 02, 7);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 5);
                GET_MONSTER(player, type, doMsgs, 02, 6);
                GET_MONSTER(player, type, doMsgs, 04, 7);
                GET_MONSTER(player, type, doMsgs, 05, 9);
                GET_MONSTER(player, type, doMsgs, 06, 9);
            }
        }
        protected override void FnEvent15(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You see a plaque on the wall. 'Welcome to the Gallery. Our ancient plaques are informative as well as decorative.'");
        }
        protected override void FnEvent16(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You fall into the Snake Pit and to your death.");
            DamXit(player, type, doMsgs);
        }
        protected override void FnEvent17(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You have entered the Cloister. Enjoy your respite on your way to the Gallery.");
        }
        protected override void FnEvent18(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You are attacked by raptors!");
            if (HAS_ITEM(player, type, doMsgs, HEALALLPOTION)) {
                SET_BOOTY(player, type, doMsgs, ELIXIROFHEALTH, SCROLLOFPROTECTION, RINGOFTHIEVES, 0, 0, 1500);
            }
            else {
                SET_BOOTY(player, type, doMsgs, HEALALLPOTION, CURSEDSCROLL, HALOSCROLL, RINGOFTHIEVES, 0, 3000);
            }
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 15);
                GET_MONSTER(player, type, doMsgs, 05, 32);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 15);
                GET_MONSTER(player, type, doMsgs, 02, 17);
                GET_MONSTER(player, type, doMsgs, 06, 32);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 16);
                GET_MONSTER(player, type, doMsgs, 02, 16);
                GET_MONSTER(player, type, doMsgs, 03, 17);
                GET_MONSTER(player, type, doMsgs, 04, 17);
                GET_MONSTER(player, type, doMsgs, 06, 32);
            }
        }
        protected override void FnEvent19(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Dark Alley awaits the unwary traveler. Step cautiously as you wander through the darkness.");
            TELEPORT(player, type, doMsgs, 5, 1, 182, SOUTH);
        }
        protected override void FnEvent1B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "To the Vineyard.");
            TELEPORT(player, type, doMsgs, 4, 1, 57, SOUTH);
        }
        protected override void FnEvent1C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You find a scrap of paper on the floor with a lost and found message: 'Reward offered for the return of a jeweled lockpick to Tipekans.'");
        }
        protected override void FnEvent1D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "To the Statuary");
            TELEPORT(player, type, doMsgs, 5, 1, 199, EAST);
        }
        protected override void FnEvent1F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (USED_SKILL(player, type, doMsgs, DETECT_SKILL) >= 6 || USED_SPELL(player, type, doMsgs, TRUE_SEEING_SPELL) || USED_ITEM(player, type, doMsgs, HELMOFWISDOM, HELMOFWISDOM) || USED_ITEM(player, type, doMsgs, VALKYRIESHELM, VALKYRIESHELM) || USED_ITEM(player, type, doMsgs, RINGOFTHIEVES, RINGOFTHIEVES) || USED_ITEM(player, type, doMsgs, CRYSTALBALL, CRYSTALBALL)) {
                SHOW_TEXT(player, type, doMsgs, "A door appears in the wall.");
                DoorHere(player, type, doMsgs);
                WallClear(player, type, doMsgs);
            }
            else {
                WallBlock(player, type, doMsgs);
            }
        }
        protected override void FnEvent20(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 5, 1, 8, SOUTH);
            SHOW_TEXT(player, type, doMsgs, "To the Vault");
        }
        protected override void FnEvent21(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Some of the walls appear to have been reconstructed.");
        }
        protected override void FnEvent22(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (RACE(player, type, doMsgs) == HUMAN) {
                SHOW_TEXT(player, type, doMsgs, "The message on the plaque says, 'Use Tyndil's payment first.'");
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "The plaque is worn and unreadable.");
            }
        }
        protected override void FnEvent23(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (RACE(player, type, doMsgs) == DWARF) {
                SHOW_TEXT(player, type, doMsgs, "The message on the plaque says, 'Save your Coral for last.'");
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "The plaque is cracked down the center.");
            }
        }
        protected override void FnEvent24(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (RACE(player, type, doMsgs) == HALFLING) {
                SHOW_TEXT(player, type, doMsgs, "The message on the plaque says, 'Use your Ebony before your Opal.'");
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "You cannot read the plaque.");
            }
        }
        protected override void FnEvent25(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "The eerie sounds coming from the Graveyard make you wonder if you should step through this teleport.");
            TELEPORT(player, type, doMsgs, 5, 3, 15, WEST);
        }
        protected override void FnEvent26(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Through this teleport you will find the Breezeway.");
            TELEPORT(player, type, doMsgs, 4, 1, 128, NORTH);
        }
        protected override void FnEvent27(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HAS_ITEM(player, type, doMsgs, RUBYLOCKPICK)) {
                if (PARTY_COUNT(player, type, doMsgs) == 1) {
                    CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
                }
                else {
                    BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
                    SHOW_TEXT(player, type, doMsgs, "'Alone I said! It took me a long time to tunnel through this wall and it's only large enough for one!'");
                }
            }
            else {
                BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
                SHOW_TEXT(player, type, doMsgs, "Smirk grabs you by the collar before you can sneak through the door. 'Have you no sense? Return when you have the item I desire!'");
            }
        }
        protected override void FnEvent28(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (RACE(player, type, doMsgs) == TROLL) {
                SHOW_TEXT(player, type, doMsgs, "The message on the plaque says, 'Don't give up your Pearl until last.'");
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "This plaque appears chipped.");
            }
        }
        protected override void FnEvent29(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GUILD(player, type, doMsgs) == RANGER) {
                if (HAS_ITEM(player, type, doMsgs, SKELETONKEY)) {
                    SHOW_TEXT(player, type, doMsgs, "The room is empty.");
                }
                else if (GET_FLAG(player, type, doMsgs, DUNGEON, ARMORY_ITEM) == 1) {
                    GIVE_ITEM(player, type, doMsgs, SKELETONKEY);
                    SHOW_TEXT(player, type, doMsgs, "You find a key which may open seemingly impassable doors in your race to finish Queen Aeowyn's Map Quest.");
                    SHOW_TEXT(player, type, doMsgs, "The key is made of bone and features a skull and crossed arm bones.");
                }
                else {
                    GIVE_ITEM(player, type, doMsgs, SKELETONKEY);
                    SHOW_TEXT(player, type, doMsgs, "Your Guildmaster left you a special key that will give you access to magical armor.");
                    SHOW_TEXT(player, type, doMsgs, "The key is made of bone. The grasp is shaped like a skull and the shaft like two crossed, bony arms.");
                }
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "The room is bare.");
            }
        }
        protected override void FnEvent2A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GUILD(player, type, doMsgs) == RANGER) {
                SHOW_TEXT(player, type, doMsgs, "A sign on the door says, 'RANGERS ONLY.'");
                DoorHere(player, type, doMsgs);
                WallClear(player, type, doMsgs);
            }
            else {
                WallBlock(player, type, doMsgs);
            }
        }
        protected override void FnEvent2B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            FntnPic(player, type, doMsgs);
            if (GUILD(player, type, doMsgs) == WIZARD) {
                if (GET_SKILL(player, type, doMsgs, ARCHERY_SKILL) == 0) {
                    MOD_SKILL(player, type, doMsgs, ARCHERY_SKILL, 1);
                    SHOW_TEXT(player, type, doMsgs, "Journey's End Fountain endows you with the Archery skill.");
                }
                else {
                    Jtxt(player, type, doMsgs);
                }
            }
            else if (GUILD(player, type, doMsgs) == KNIGHT || GUILD(player, type, doMsgs) == THIEF || GUILD(player, type, doMsgs) == RANGER) {
                if (GET_SKILL(player, type, doMsgs, ATHLETICS_SKILL) == 0) {
                    MOD_SKILL(player, type, doMsgs, ATHLETICS_SKILL, 1);
                    SHOW_TEXT(player, type, doMsgs, "Journey's End Fountain endows you with the Athletics skill.");
                }
                else {
                    Jtxt(player, type, doMsgs);
                }
            }
            else if (GUILD(player, type, doMsgs) == CLERIC) {
                if ((GET_FLAG(player, type, doMsgs, DUNGEON, BLESSCLERIC) == 0)) {
                    GIVE_SPELL(player, type, doMsgs, BLESS_SPELL, 1);
                    SET_FLAG(player, type, doMsgs, DUNGEON, BLESSCLERIC, 1);
                    SHOW_TEXT(player, type, doMsgs, "Journey's End Fountain endows you with the Bless spell.");
                }
                else {
                    Jtxt(player, type, doMsgs);
                }
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "Journey's End Fountain is dry.");
            }
        }
        protected override void FnEvent2C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, TROLLKNIGHT);
            SHOW_TEXT(player, type, doMsgs, "You meet a Cavalier who says, 'I've heard tell of a special lantern that has proven very helpful in opening a certain door.");
            SHOW_TEXT(player, type, doMsgs, "The door is somewhere in the dark, or so I'm told.'");
        }
        protected override void FnEvent2D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (USED_ITEM(player, type, doMsgs, RUBYLOCKPICK, RUBYLOCKPICK)) {
                WallClear(player, type, doMsgs);
                DoorHere(player, type, doMsgs);
                SHOW_TEXT(player, type, doMsgs, "Smirk waves you inside.");
            }
            else {
                WallBlock(player, type, doMsgs);
                SHOW_TEXT(player, type, doMsgs, "The entrance to Smirk's Emporium is locked.");
            }
        }
        protected override void FnEvent2E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 7, 1, 218, NORTH);
        }
        protected override void FnEvent2F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (RACE(player, type, doMsgs) == GNOME) {
                SHOW_TEXT(player, type, doMsgs, "The message on the plaque says, 'Use Syrene's payment as your last choice.'");
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "The plaque is worn and unreadable.");
            }
        }
        protected override void FnEvent30(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, ROOM, TROUGH) == 0) {
                FntnPic(player, type, doMsgs);
                SHOW_TEXT(player, type, doMsgs, "The stagnant waters of the Trough are poisonous!");
                SET_PM(player, type, doMsgs, POISON, 10, MAX_HEALTH(player, type, doMsgs) / 10);
                SET_FLAG(player, type, doMsgs, ROOM, TROUGH, 1);
            }
        }
        protected override void FnEvent31(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, HALFLINGCLERIC);
            SHOW_TEXT(player, type, doMsgs, "A monk breaks his silence and whispers, 'Search well, for there are places in the dungeon where your attributes can be enhanced.'");
        }
        protected override void FnEvent32(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HAS_ITEM(player, type, doMsgs, LUMINOUSLANTERN)) {
                TAKE_ITEM(player, type, doMsgs, LUMINOUSLANTERN);
                GIVE_ITEM(player, type, doMsgs, SNAKECHARM);
                SHOW_TEXT(player, type, doMsgs, "The Luminous Lantern fades and disappears as you catch a glimpse of a magical talisman.");
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "The room is too dark for you to see. A portable light would prove most useful here,");
            }
        }
        protected override void FnEvent33(TwPlayerServer player, MapEventType type, bool doMsgs) {
            NO_JOIN(player, type, doMsgs);
            SHOW_PICTURE(player, type, doMsgs, HALFLINGTHIEF);
            if (HAS_ITEM(player, type, doMsgs, RUBYLOCKPICK)) {
                SHOW_TEXT(player, type, doMsgs, "I see you have brought the lockpick.  Continue through the door to the east alone and you will find your promised reward.");
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "Smirk cautions you not to go beyond this point without the lockpick.");
            }
        }
        protected override void FnEvent34(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (RACE(player, type, doMsgs) == ORC) {
                SHOW_TEXT(player, type, doMsgs, "The message on the plaque says, 'If given a choice, use the Opal second.'");
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "The plaque is cracked down the center.");
            }
        }
        protected override void FnEvent35(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (RACE(player, type, doMsgs) == ELF) {
                SHOW_TEXT(player, type, doMsgs, "The message on the plaque says, 'Use your Opal before your Coral.'");
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "The etchings on the plaque are unintelligible.");
            }
        }
        protected override void FnEvent36(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (RACE(player, type, doMsgs) == GREMLIN) {
                SHOW_TEXT(player, type, doMsgs, "The message on the plaque says, 'Use Tyndil's payment third.'");
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "You see nothing of interest on the plaque.");
            }
        }
        protected override void FnEvent37(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 6, 1, 161, WEST);
        }
        protected override void FnEvent38(TwPlayerServer player, MapEventType type, bool doMsgs) {
            FntnPic(player, type, doMsgs);
            SHOW_TEXT(player, type, doMsgs, "Equestrian Fountain rejuvenates your health and mana.");
            HealFtn(player, type, doMsgs);
        }
        protected override void FnEvent39(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, TROLLKNIGHT);
            SHOW_TEXT(player, type, doMsgs, "'Once you have the four map pieces the Queen seeks, make sure you know the order of the jewels before you seek your reward.");
            SHOW_TEXT(player, type, doMsgs, "Three clues are available for each race. I have found two and am now after the third. You must read all three clues, or you will not be rewarded.'");
        }
        protected override void FnEvent3A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (USED_ITEM(player, type, doMsgs, RUBYLOCKPICK, RUBYLOCKPICK)) {
                SHOW_TEXT(player, type, doMsgs, "You are killed by Smirk who mistakes you for a robber.");
                DamXit(player, type, doMsgs);
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "Back door to Smirk's Emporium.");
                WallBlock(player, type, doMsgs);
            }
        }
        protected override void FnEvent3B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, HALFLINGKNIGHT);
            SHOW_TEXT(player, type, doMsgs, "'I was told that in this area there are hidden rooms. A few rooms are available only to specific guilds.");
            SHOW_TEXT(player, type, doMsgs, "Beyond one hidden door is a second secretive door. That door leads to... Well, I think you should discover where that door leads.'");
        }
        protected override void FnEvent3C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HAS_ITEM(player, type, doMsgs, LIFEJACKET)) {
                SET_BOOTY(player, type, doMsgs, BERSERKERTALISMAN, CHAINMAIL, 0, 0, 0, 1000);
            }
            else {
                SET_BOOTY(player, type, doMsgs, LIFEJACKET, 0, 0, 0, 0, 3000);
                SHOW_TEXT(player, type, doMsgs, "You see a group of monsters tearing at a life jacket.");
            }
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 2);
                GET_MONSTER(player, type, doMsgs, 02, 7);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 1);
                GET_MONSTER(player, type, doMsgs, 02, 3);
                GET_MONSTER(player, type, doMsgs, 05, 7);
                GET_MONSTER(player, type, doMsgs, 06, 8);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 3);
                GET_MONSTER(player, type, doMsgs, 02, 3);
                GET_MONSTER(player, type, doMsgs, 03, 1);
                GET_MONSTER(player, type, doMsgs, 04, 1);
                GET_MONSTER(player, type, doMsgs, 05, 8);
                GET_MONSTER(player, type, doMsgs, 06, 9);
            }
        }
        protected override void FnEvent3D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You can see it's a long, hard climb up to Cliffhanger.");
            TELEPORT(player, type, doMsgs, 4, 1, 127, WEST);
        }
        protected override void FnEvent40(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "The Wine Cellar is dark and damp.");
        }
        protected override void FnEvent41(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 20);
                GET_MONSTER(player, type, doMsgs, 02, 26);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 26);
                GET_MONSTER(player, type, doMsgs, 02, 26);
                GET_MONSTER(player, type, doMsgs, 03, 39);
                GET_MONSTER(player, type, doMsgs, 04, 40);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 21);
                GET_MONSTER(player, type, doMsgs, 02, 38);
                GET_MONSTER(player, type, doMsgs, 04, 38);
                GET_MONSTER(player, type, doMsgs, 05, 39);
                GET_MONSTER(player, type, doMsgs, 06, 40);
            }
        }
        protected override void FnEvent42(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 15);
                GET_MONSTER(player, type, doMsgs, 02, 32);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 16);
                GET_MONSTER(player, type, doMsgs, 02, 17);
                GET_MONSTER(player, type, doMsgs, 06, 11);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 16);
                GET_MONSTER(player, type, doMsgs, 02, 16);
                GET_MONSTER(player, type, doMsgs, 03, 17);
                GET_MONSTER(player, type, doMsgs, 05, 14);
                GET_MONSTER(player, type, doMsgs, 06, 10);
            }
        }
        protected override void FnEvent43(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 14);
                GET_MONSTER(player, type, doMsgs, 02, 28);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 13);
                GET_MONSTER(player, type, doMsgs, 02, 14);
                GET_MONSTER(player, type, doMsgs, 04, 31);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 13);
                GET_MONSTER(player, type, doMsgs, 02, 13);
                GET_MONSTER(player, type, doMsgs, 03, 14);
                GET_MONSTER(player, type, doMsgs, 04, 14);
                GET_MONSTER(player, type, doMsgs, 06, 33);
            }
        }
        protected override void FnEvent44(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 29);
                GET_MONSTER(player, type, doMsgs, 02, 29);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 1, 6);
                GET_MONSTER(player, type, doMsgs, 2, 7);
                GET_MONSTER(player, type, doMsgs, 6, 36);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 3) {
                GET_MONSTER(player, type, doMsgs, 1, 5);
                GET_MONSTER(player, type, doMsgs, 2, 6);
                GET_MONSTER(player, type, doMsgs, 3, 21);
                GET_MONSTER(player, type, doMsgs, 4, 19);
                GET_MONSTER(player, type, doMsgs, 5, 20);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 1, 5);
                GET_MONSTER(player, type, doMsgs, 2, 6);
                GET_MONSTER(player, type, doMsgs, 3, 37);
                GET_MONSTER(player, type, doMsgs, 4, 38);
                GET_MONSTER(player, type, doMsgs, 5, 40);
                GET_MONSTER(player, type, doMsgs, 6, 40);
            }
        }
        protected override void FnEvent45(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 1);
                GET_MONSTER(player, type, doMsgs, 02, 1);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 2);
                GET_MONSTER(player, type, doMsgs, 02, 2);
                GET_MONSTER(player, type, doMsgs, 06, 15);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 2);
                GET_MONSTER(player, type, doMsgs, 02, 3);
                GET_MONSTER(player, type, doMsgs, 03, 16);
                GET_MONSTER(player, type, doMsgs, 04, 17);
            }
        }
        protected override void FnEvent46(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 1, 20);
                GET_MONSTER(player, type, doMsgs, 2, 40);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 1, 21);
                GET_MONSTER(player, type, doMsgs, 2, 21);
                GET_MONSTER(player, type, doMsgs, 3, 23);
                GET_MONSTER(player, type, doMsgs, 6, 40);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 3) {
                GET_MONSTER(player, type, doMsgs, 1, 35);
                GET_MONSTER(player, type, doMsgs, 2, 38);
                GET_MONSTER(player, type, doMsgs, 3, 37);
                GET_MONSTER(player, type, doMsgs, 5, 22);
                GET_MONSTER(player, type, doMsgs, 6, 24);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 1, 23);
                GET_MONSTER(player, type, doMsgs, 2, 39);
                GET_MONSTER(player, type, doMsgs, 3, 36);
                GET_MONSTER(player, type, doMsgs, 4, 36);
                GET_MONSTER(player, type, doMsgs, 5, 34);
                GET_MONSTER(player, type, doMsgs, 6, 34);
            }
        }
        private void Jtxt(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "The waters of Journey's End Fountain are refreshing.");
        }
        private void WallClear(TwPlayerServer player, MapEventType type, bool doMsgs) {
            CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
        }
        private void FntnPic(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, FOUNTAIN);
        }
        private void DamXit(TwPlayerServer player, MapEventType type, bool doMsgs) {
            DAMAGE(player, type, doMsgs, MAX_HEALTH(player, type, doMsgs));
            EXIT_DUNGEON(player, type, doMsgs);
        }
        private void WallBlock(TwPlayerServer player, MapEventType type, bool doMsgs) {
            BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
        }
        private void DoorHere(TwPlayerServer player, MapEventType type, bool doMsgs) {
            PLACE_WALL_ITEM(player, type, doMsgs, DOOR, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
        }
        private void HealFtn(TwPlayerServer player, MapEventType type, bool doMsgs) {
            HEAL(player, type, doMsgs, MAX_HEALTH(player, type, doMsgs));
            MOD_MANA(player, type, doMsgs, 10000);
        }
    }
}
