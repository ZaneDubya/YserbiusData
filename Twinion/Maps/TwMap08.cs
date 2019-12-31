using XPT.Generic.Maps;
using XPT.Twinion.Entities;

namespace XPT.Twinion.Maps {
    class TwMap08 : TwMap {
        protected override int MapIndex => 8;
        protected override int MapID => 0x0401;
        protected override int RandomEncounterChance => 5;
        protected override int RandomEncounterExtraCount => 1;

        private const int DETECTED_DOOR = 6;
        private const int SUNSET = 7;
        protected override void FnEvent01(TwPlayerServer player, MapEventType type, bool doMsgs) {
            FntnPic(player, type, doMsgs);
            if (GET_FLAG(player, type, doMsgs, DUNGEON, SNOWY) == 1) {
                TAKE_ITEM(player, type, doMsgs, ROPE);
                SHOW_TEXT(player, type, doMsgs, "The chill waters of Snowy Fountain are refreshing.");
                SHOW_TEXT(player, type, doMsgs, "Your rope falls into the water.");
            }
            else if (HAS_ITEM(player, type, doMsgs, ROPE)) {
                TAKE_ITEM(player, type, doMsgs, ROPE);
                SHOW_TEXT(player, type, doMsgs, "Your rope falls into the water.");
                SET_FLAG(player, type, doMsgs, DUNGEON, SNOWY, 1);
                if (GUILD(player, type, doMsgs) == BARBARIAN || GUILD(player, type, doMsgs) == RANGER || GUILD(player, type, doMsgs) == THIEF || GUILD(player, type, doMsgs) == WIZARD) {
                    if ((GET_SKILL(player, type, doMsgs, SWORDSMANSHIP_SKILL) == 0)) {
                        MOD_SKILL(player, type, doMsgs, SWORDSMANSHIP_SKILL, 1);
                    }
                    SHOW_TEXT(player, type, doMsgs, "The chill waters of Snowy Fountain enrich you with the Fencing skill.");
                }
                else if (GUILD(player, type, doMsgs) == CLERIC || GUILD(player, type, doMsgs) == KNIGHT) {
                    if ((GET_SKILL(player, type, doMsgs, CLUBS_AND_AXES_SKILL) == 0)) {
                        MOD_SKILL(player, type, doMsgs, CLUBS_AND_AXES_SKILL, 1);
                    }
                    SHOW_TEXT(player, type, doMsgs, "The chill waters of Snowy Fountain enrich you with the Clubs and Axes skill.");
                }
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "You must prove you have completed the Rope Quest to gain your skill.");
            }
        }
        protected override void FnEvent02(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 6, 1, 89, SOUTH);
        }
        protected override void FnEvent03(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You step into a stream of lava.");
            DamXit(player, type, doMsgs);
        }
        protected override void FnEvent04(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (USED_SKILL(player, type, doMsgs, DETECT_SKILL) >= 5 || USED_SPELL(player, type, doMsgs, TRUE_SEEING_SPELL) || USED_ITEM(player, type, doMsgs, HELMOFWISDOM, HELMOFWISDOM) || USED_ITEM(player, type, doMsgs, VALKYRIESHELM, VALKYRIESHELM) || USED_ITEM(player, type, doMsgs, RINGOFTHIEVES, RINGOFTHIEVES) || USED_ITEM(player, type, doMsgs, CRYSTALBALL, CRYSTALBALL)) {
                SHOW_TEXT(player, type, doMsgs, "You discover a hidden door.");
                DoorHere(player, type, doMsgs);
                WallClear(player, type, doMsgs);
            }
            else {
                WallBlock(player, type, doMsgs);
            }
        }
        protected override void FnEvent05(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You lose your footing and tumble down a slope, landing safely in the Infirmary.");
            TELEPORT(player, type, doMsgs, 5, 1, 61, WEST);
        }
        protected override void FnEvent06(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You step into a pit and fall to your death.");
            DamXit(player, type, doMsgs);
        }
        protected override void FnEvent07(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short teleportRoom = 0;
            if (HAS_ITEM(player, type, doMsgs, ROPE)) {
                if (FACING(player, type, doMsgs) == WEST) {
                    teleportRoom = HERE(player, type, doMsgs);
                     - 2;
                    WallBlock(player, type, doMsgs);
                    SHOW_TEXT(player, type, doMsgs, "By throwing the Rope over a protruding rock, you manage to swing across the pit.");
                    TELEPORT(player, type, doMsgs, 4, 1, teleportRoom, EAST);
                }
            }
            else if (USED_ITEM(player, type, doMsgs, SHORTSWORD, KEYOFC) || USED_ITEM(player, type, doMsgs, LIFEJACKET, UNITYRING)) {
                WallClear(player, type, doMsgs);
                SHOW_TEXT(player, type, doMsgs, "Nothing extraordinary happens.");
            }
            else {
                WallClear(player, type, doMsgs);
                SHOW_TEXT(player, type, doMsgs, "A pit blocks your passage to the west.");
                SHOW_TEXT(player, type, doMsgs, "You notice a protruding rock above the pit.");
            }
        }
        protected override void FnEvent08(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (USED_SKILL(player, type, doMsgs, DETECT_SKILL) >= 5 || USED_SPELL(player, type, doMsgs, TRUE_SEEING_SPELL) || USED_ITEM(player, type, doMsgs, HELMOFWISDOM, HELMOFWISDOM) || USED_ITEM(player, type, doMsgs, VALKYRIESHELM, VALKYRIESHELM) || USED_ITEM(player, type, doMsgs, RINGOFTHIEVES, RINGOFTHIEVES) || USED_ITEM(player, type, doMsgs, CRYSTALBALL, CRYSTALBALL) || FLAG_ON(player, type, doMsgs, ROOM, DETECTED_DOOR)) {
                SET_FLAG(player, type, doMsgs, ROOM, DETECTED_DOOR, 1);
                if (USED_ITEM(player, type, doMsgs, REDLOCKPICK, BLUELOCKPICK) || USED_ITEM(player, type, doMsgs, HELMOFGUILE, HELMOFGUILE) || USED_SKILL(player, type, doMsgs, LOCKPICK_SKILL) >= 6) {
                    SHOW_TEXT(player, type, doMsgs, "You successfully unlock the door.");
                    DoorHere(player, type, doMsgs);
                    WallClear(player, type, doMsgs);
                }
                else {
                    WallBlock(player, type, doMsgs);
                    DoorHere(player, type, doMsgs);
                    SHOW_TEXT(player, type, doMsgs, "You detect a hidden door, but it is locked.");
                }
            }
            else {
                WallBlock(player, type, doMsgs);
            }
        }
        protected override void FnEvent09(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You see a warning sign on the cliff.");
            SHOW_TEXT(player, type, doMsgs, "'DANGER! Loose rocks. Proceed at your own risk.'");
        }
        protected override void FnEvent0A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "The door to the Armory has seen many a traveler pass, each in search of the secret rooms inside.");
            TELEPORT(player, type, doMsgs, 4, 3, 64, SOUTH);
        }
        protected override void FnEvent0B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "The gateway leads to the Statuary.");
            TELEPORT(player, type, doMsgs, 5, 1, 238, WEST);
        }
        protected override void FnEvent0C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "A few walls in this area seem to have been altered by some construction.");
        }
        protected override void FnEvent0D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 6, 1, 72, NORTH);
            SHOW_TEXT(player, type, doMsgs, "To the Cellar");
        }
        protected override void FnEvent0E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "As you search the cave, you are startled by bats.");
            if (HAS_ITEM(player, type, doMsgs, PIPESOFENCHANTMENT)) {
                SET_BOOTY(player, type, doMsgs, READTRACKSTALISMAN, SCROLLOFPROTECTION, HALOSCROLL, 0, 0, 1000);
            }
            else {
                SET_BOOTY(player, type, doMsgs, PIPESOFENCHANTMENT, CRYSTALSCROLL, REFRESHALLSCROLL, 0, 0, 1500);
            }
            if (PARTY_COUNT(player, type, doMsgs) == 1 || PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 11);
                GET_MONSTER(player, type, doMsgs, 02, 11);
                GET_MONSTER(player, type, doMsgs, 05, 12);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 11);
                GET_MONSTER(player, type, doMsgs, 02, 12);
                GET_MONSTER(player, type, doMsgs, 03, 32);
                GET_MONSTER(player, type, doMsgs, 06, 33);
            }
        }
        protected override void FnEvent0F(TwPlayerServer player, MapEventType type, bool doMsgs) {
             {
                if (HAS_ITEM(player, type, doMsgs, FRONTDOORKEY)) {
                    SET_BOOTY(player, type, doMsgs, BERSERKERTALISMAN, ELIXIROFHEALTH, 0, 0, 0, 1000);
                    SHOW_TEXT(player, type, doMsgs, "You enter a cave crammed with hostile monsters.");
                }
                else {
                    SET_BOOTY(player, type, doMsgs, FRONTDOORKEY, HAWKSEYE, ELIXIROFHEALTH, 0, 0, 3000);
                    SHOW_TEXT(player, type, doMsgs, "You inadvertantly join a battle over a key.");
                }
            }
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 40);
                GET_MONSTER(player, type, doMsgs, 02, 22);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 40);
                GET_MONSTER(player, type, doMsgs, 02, 40);
                GET_MONSTER(player, type, doMsgs, 03, 22);
                GET_MONSTER(player, type, doMsgs, 04, 22);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 40);
                GET_MONSTER(player, type, doMsgs, 02, 40);
                GET_MONSTER(player, type, doMsgs, 03, 38);
                GET_MONSTER(player, type, doMsgs, 04, 38);
                GET_MONSTER(player, type, doMsgs, 05, 22);
                GET_MONSTER(player, type, doMsgs, 06, 22);
            }
        }
        protected override void FnEvent10(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GUILD(player, type, doMsgs) == THIEF) {
                SHOW_TEXT(player, type, doMsgs, "As you turn to leave, Snicker slips you a note saying - ");
                SHOW_TEXT(player, type, doMsgs, "'A dark and dangerous place hides your key to rewards.'");
            }
        }
        protected override void FnEvent12(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Path to Tipekans' Bridge.");
            TELEPORT(player, type, doMsgs, 7, 1, 161, EAST);
        }
        protected override void FnEvent14(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "On the the plaque you see OT.");
        }
        protected override void FnEvent15(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HAS_ITEM(player, type, doMsgs, MAZEKEY)) {
                EmptyRoom(player, type, doMsgs);
            }
            else {
                GIVE_ITEM(player, type, doMsgs, MAZEKEY);
                SHOW_TEXT(player, type, doMsgs, "In a corner of this otherwise empty room you find a key.");
                SHOW_TEXT(player, type, doMsgs, "The key bears the initials M.A.Z.E.");
            }
        }
        protected override void FnEvent16(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, DUNGEON, LABY_ONE_GOLD) == 0) {
                MOD_GOLD(player, type, doMsgs, 5000);
                SET_FLAG(player, type, doMsgs, DUNGEON, LABY_ONE_GOLD, 1);
                SHOW_TEXT(player, type, doMsgs, "You find 5,000 gold pieces behind a wooden vat, which was used to store the Vineyard grapes.");
            }
            else if (GET_FLAG(player, type, doMsgs, DUNGEON, LABY_ONE_GOLD) == 1 && GET_FLAG(player, type, doMsgs, DUNGEON, SLATE_MAP) == 1) {
                SET_FLAG(player, type, doMsgs, DUNGEON, LABY_ONE_GOLD, 2);
                GIVE_ITEM(player, type, doMsgs, NIGHTELFHELM);
                GIVE_ITEM(player, type, doMsgs, MIRROREDGEMSTONE);
                SHOW_TEXT(player, type, doMsgs, "You see a reflection in the light and pick up items an unlucky adventurer must have dropped.");
                SHOW_TEXT(player, type, doMsgs, "The items are useful, but are not particularly important to your quest.");
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "The room is empty except for some wooden vats.");
            }
        }
        protected override void FnEvent17(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GUILD(player, type, doMsgs) == KNIGHT) {
                if (HAS_ITEM(player, type, doMsgs, SKELETONKEY)) {
                    EmptyRoom(player, type, doMsgs);
                }
                else if (GET_FLAG(player, type, doMsgs, DUNGEON, ARMORY_ITEM) == 1) {
                    GIVE_ITEM(player, type, doMsgs, SKELETONKEY);
                    SHOW_TEXT(player, type, doMsgs, "You find a key which may open seemingly impassable doors in your race to finish Queen Aeowyn's Map Quest.");
                    Skey(player, type, doMsgs);
                }
                else {
                    GIVE_ITEM(player, type, doMsgs, SKELETONKEY);
                    SHOW_TEXT(player, type, doMsgs, "Your Guildmaster left you a special key that will give you access to magical armor.");
                    Skey(player, type, doMsgs);
                }
            }
            else {
                EmptyRoom(player, type, doMsgs);
            }
        }
        protected override void FnEvent18(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (USED_SKILL(player, type, doMsgs, DETECT_SKILL) >= 5 || USED_SPELL(player, type, doMsgs, TRUE_SEEING_SPELL) || USED_ITEM(player, type, doMsgs, HELMOFWISDOM, HELMOFWISDOM) || USED_ITEM(player, type, doMsgs, VALKYRIESHELM, VALKYRIESHELM) || USED_ITEM(player, type, doMsgs, RINGOFTHIEVES, RINGOFTHIEVES) || USED_ITEM(player, type, doMsgs, CRYSTALBALL, CRYSTALBALL)) {
                SHOW_TEXT(player, type, doMsgs, "A hidden door is revealed.");
                DoorHere(player, type, doMsgs);
                WallClear(player, type, doMsgs);
            }
            else {
                WallBlock(player, type, doMsgs);
            }
        }
        protected override void FnEvent1A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (USED_ITEM(player, type, doMsgs, RUBYLOCKPICK, RUBYLOCKPICK)) {
                SHOW_TEXT(player, type, doMsgs, "Sneer's guard hears you attempting to get in the back door and kills you.");
                DamXit(player, type, doMsgs);
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "You see the back door to Sneer's Pawn Shop.");
                WallBlock(player, type, doMsgs);
            }
        }
        protected override void FnEvent1B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, HALFLINGTHIEF);
            SHOW_TEXT(player, type, doMsgs, "Sneer looks you over and notices your Ruby Lockpick. He motions you to continue to the north.");
        }
        protected override void FnEvent1C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "On the plaque you see LALF.");
        }
        protected override void FnEvent1D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HAS_ITEM(player, type, doMsgs, KEYOFC)) {
                SHOW_TEXT(player, type, doMsgs, "The bard has already sung his tale.");
            }
            else {
                SHOW_PICTURE(player, type, doMsgs, ELFCLERIC);
                GIVE_ITEM(player, type, doMsgs, KEYOFC);
                SHOW_TEXT(player, type, doMsgs, "You meet a bard who is grateful for your attentiveness as he sings his tale. He expresses his gratitude with a gift of a special key.");
                SHOW_TEXT(player, type, doMsgs, "'Music will open new doors for you,' the bard says.");
            }
        }
        protected override void FnEvent1E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You disturb the spirits of long dead vintners.");
            if (HAS_ITEM(player, type, doMsgs, SCROLLOFSAFETY)) {
                SET_BOOTY(player, type, doMsgs, SCROLLOFTHESUN, BASALTSCROLL, 0, 0, 0, 1000);
            }
            else {
                SET_BOOTY(player, type, doMsgs, CURSEDSCROLL, SCROLLOFSAFETY, BLUELOCKPICK, 0, 0, 2000);
            }
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 1);
                GET_MONSTER(player, type, doMsgs, 02, 5);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 5);
                GET_MONSTER(player, type, doMsgs, 02, 29);
                GET_MONSTER(player, type, doMsgs, 05, 30);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 28);
                GET_MONSTER(player, type, doMsgs, 02, 27);
                GET_MONSTER(player, type, doMsgs, 04, 9);
                GET_MONSTER(player, type, doMsgs, 05, 30);
                GET_MONSTER(player, type, doMsgs, 06, 31);
            }
        }
        protected override void FnEvent20(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GUILD(player, type, doMsgs) == KNIGHT) {
                SHOW_TEXT(player, type, doMsgs, "A sign on the door says KNIGHTS ONLY.");
                DoorHere(player, type, doMsgs);
                WallClear(player, type, doMsgs);
            }
            else {
                WallBlock(player, type, doMsgs);
            }
        }
        protected override void FnEvent21(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (USED_ITEM(player, type, doMsgs, RUBYLOCKPICK, RUBYLOCKPICK)) {
                WallClear(player, type, doMsgs);
                DoorHere(player, type, doMsgs);
                SHOW_TEXT(player, type, doMsgs, "Sneer's is now open for business.");
            }
            else {
                WallBlock(player, type, doMsgs);
                SHOW_TEXT(player, type, doMsgs, "The entrance to Sneer's Pawn Shop is locked.");
            }
        }
        protected override void FnEvent22(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "On the plaque you see SRAHMC.");
        }
        protected override void FnEvent23(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You plunge into the pit and find yourself at the bottom of a secret shaft to the Vault.");
            TELEPORT(player, type, doMsgs, 5, 1, 135, SOUTH);
        }
        protected override void FnEvent24(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You congratulate yourself on your choice. But your confidence turns to alarm as you feel yourself approaching the Fringe of Madness.");
            TELEPORT(player, type, doMsgs, 5, 1, 139, EAST);
        }
        protected override void FnEvent25(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, HUMANBARBARIAN);
            SHOW_TEXT(player, type, doMsgs, "You meet an old seafarer.");
            SHOW_TEXT(player, type, doMsgs, "'Beware of Lake Despair, matey. Many a foolhardy adventurer has sunk into its treacherous depths.");
            SHOW_TEXT(player, type, doMsgs, "A special jacket helped me cross the lake once, but I lost it somewhere in the dungeon. Pity.'");
        }
        protected override void FnEvent26(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, TROLLRANGER);
            SHOW_TEXT(player, type, doMsgs, "You meet a friendly but puzzled ranger, 'This MUST be Clueless! Hmmm...I suspect a wizard has tampered with the clues in this area.' He shows you a parchment on which he has written SPAS.");
        }
        protected override void FnEvent27(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, WRAITH);
            SHOW_TEXT(player, type, doMsgs, "An apparition appears before you, 'I almost met my death while trying to squeeze past my stony friend who was concealing a shortcut to this place.");
            SHOW_TEXT(player, type, doMsgs, "However, my statuesque form encountered its demise elsewhere.'");
        }
        protected override void FnEvent29(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GUILD(player, type, doMsgs) == WIZARD) {
                if (HAS_ITEM(player, type, doMsgs, SKELETONKEY)) {
                    EmptyRoom(player, type, doMsgs);
                }
                else if (GET_FLAG(player, type, doMsgs, DUNGEON, ARMORY_ITEM) == 1) {
                    GIVE_ITEM(player, type, doMsgs, SKELETONKEY);
                    SHOW_TEXT(player, type, doMsgs, "You find a key which may open seemingly impassable doors in your race to finish Queen Aeowyn's Map Quest.");
                    Skey(player, type, doMsgs);
                }
                else {
                    GIVE_ITEM(player, type, doMsgs, SKELETONKEY);
                    SHOW_TEXT(player, type, doMsgs, "Your Guildmaster left you a special key that will give you access to magical armor.");
                    Skey(player, type, doMsgs);
                }
            }
            else {
                EmptyRoom(player, type, doMsgs);
            }
        }
        protected override void FnEvent2A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GUILD(player, type, doMsgs) == WIZARD) {
                SHOW_TEXT(player, type, doMsgs, "A sign on the door reads WIZARDS ONLY.");
                DoorHere(player, type, doMsgs);
                WallClear(player, type, doMsgs);
            }
            else {
                WallBlock(player, type, doMsgs);
            }
        }
        protected override void FnEvent2B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, HALFLINGTHIEF);
            if (GET_FLAG(player, type, doMsgs, DUNGEON, SNICKER) == 0) {
                SET_FLAG(player, type, doMsgs, DUNGEON, SNICKER, 1);
                MOD_GOLD(player, type, doMsgs,  - 1000);
                SHOW_TEXT(player, type, doMsgs, "You meet a thief named Snicker, 'Three brothers have I, and courtesy is very important to all of them. One will show you the true path to what you seek. But all are fond of red gems.");
                SHOW_TEXT(player, type, doMsgs, "In exchange for this information, you find your purse a little lighter.'");
            }
            else if (GET_FLAG(player, type, doMsgs, DUNGEON, SNICKER) == 1) {
                GIVE_ITEM(player, type, doMsgs, RINGOFTHIEVES);
                SET_FLAG(player, type, doMsgs, DUNGEON, SNICKER, 2);
                MOD_GOLD(player, type, doMsgs,  - 5000);
                SHOW_TEXT(player, type, doMsgs, "'Ah, my informants said you might return! You must learn to guard your pockets better. Since I've relieved you of your gold again, take this ring. It's magic will lead you to paths you might have missed without its magic.'");
            }
            else if (GET_FLAG(player, type, doMsgs, DUNGEON, SNICKER) == 2 && HAS_ITEM(player, type, doMsgs, KEYOFC)) {
                GIVE_ITEM(player, type, doMsgs, IRONCROWN);
                SET_FLAG(player, type, doMsgs, DUNGEON, SNICKER, 3);
                MOD_GOLD(player, type, doMsgs,  - 5000);
                SHOW_TEXT(player, type, doMsgs, "'Greetings! I have pil...acquired this from an adventurer who bragged about the protective properties of the crown. I've taken your gold, you might as well have it. I'm sure I'll happen upon another.'");
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "Snicker is busy helping himself to the goods of others.");
            }
        }
        protected override void FnEvent2C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You can hear the rushing waters of Lake Despair.");
            TELEPORT(player, type, doMsgs, 5, 1, 147, NORTH);
        }
        protected override void FnEvent2F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "A sign on the portal says, 'Entrance to the Gallery'.");
            TELEPORT(player, type, doMsgs, 6, 1, 195, WEST);
        }
        protected override void FnEvent32(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You lose your footing on a loose rock and your bag of gold falls to the ground.");
            SHOW_TEXT(player, type, doMsgs, "You manage to gather all but 1000 pieces, which fall through cracks in the floor.");
            MOD_GOLD(player, type, doMsgs,  - 1000);
        }
        protected override void FnEvent34(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, ROOM, SUNSET) == 0) {
                FntnPic(player, type, doMsgs);
                SHOW_TEXT(player, type, doMsgs, "The dark waters of Sunset Fountain poison you when you attempt to refresh yourself.");
                SET_PM(player, type, doMsgs, POISON, 5, MAX_HEALTH(player, type, doMsgs) / 10);
                SET_FLAG(player, type, doMsgs, ROOM, SUNSET, 1);
            }
        }
        protected override void FnEvent37(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "On the plaque you see EPRY.");
        }
        protected override void FnEvent38(TwPlayerServer player, MapEventType type, bool doMsgs) {
            FntnPic(player, type, doMsgs);
            if (GET_FLAG(player, type, doMsgs, DUNGEON, WINDY) == 1) {
                SHOW_TEXT(player, type, doMsgs, "The waters of Windy Fountain have no effect.");
                SHOW_TEXT(player, type, doMsgs, "The Key of C falls into the fountain.");
                TAKE_ITEM(player, type, doMsgs, KEYOFC);
            }
            else if (HAS_ITEM(player, type, doMsgs, KEYOFC)) {
                if (GUILD(player, type, doMsgs) == THIEF) {
                    TAKE_ITEM(player, type, doMsgs, KEYOFC);
                    SET_FLAG(player, type, doMsgs, DUNGEON, WINDY, 1);
                    MOD_SKILL(player, type, doMsgs, MARTIAL_ARTS_SKILL, 1);
                    SHOW_TEXT(player, type, doMsgs, "The waters of Windy Fountain endow you with the Martial Arts skill.");
                }
                else if (GUILD(player, type, doMsgs) == BARBARIAN || GUILD(player, type, doMsgs) == WIZARD) {
                    TAKE_ITEM(player, type, doMsgs, KEYOFC);
                    SET_FLAG(player, type, doMsgs, DUNGEON, WINDY, 1);
                    MOD_SKILL(player, type, doMsgs, INTIMIDATE_SKILL, 1);
                    SHOW_TEXT(player, type, doMsgs, "The waters of Windy Fountain give you the powers to intimidate your enemies.");
                }
                else if (GUILD(player, type, doMsgs) == RANGER || GUILD(player, type, doMsgs) == CLERIC) {
                    TAKE_ITEM(player, type, doMsgs, KEYOFC);
                    SET_FLAG(player, type, doMsgs, DUNGEON, WINDY, 1);
                    MOD_SKILL(player, type, doMsgs, BARD_SKILL, 1);
                    SHOW_TEXT(player, type, doMsgs, "The waters of Windy Fountain endow you with the Bard skill.");
                }
                else {
                    TAKE_ITEM(player, type, doMsgs, KEYOFC);
                    SET_FLAG(player, type, doMsgs, DUNGEON, WINDY, 1);
                    MOD_SKILL(player, type, doMsgs, ARCHERY_SKILL, 1);
                    SHOW_TEXT(player, type, doMsgs, "The waters of Windy Fountain aid in your proficiency with a bow.");
                }
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "A gift from a bard makes these waters magical.");
            }
        }
        protected override void FnEvent39(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (USED_ITEM(player, type, doMsgs, KEYOFC, KEYOFC)) {
                WallClear(player, type, doMsgs);
                DoorHere(player, type, doMsgs);
                SHOW_TEXT(player, type, doMsgs, "The Key of C unlocks this Ballroom door.");
            }
            else {
                WallBlock(player, type, doMsgs);
                SHOW_TEXT(player, type, doMsgs, "You see a musical note on the locked door.");
            }
        }
        protected override void FnEvent3B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            FntnPic(player, type, doMsgs);
            SHOW_TEXT(player, type, doMsgs, "The fresh waters of Sunrise Fountain restore your mana.");
            MOD_MANA(player, type, doMsgs, 5000);
        }
        protected override void FnEvent3C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Enter the Rat Race.");
            TELEPORT(player, type, doMsgs, 6, 3, 241, WEST);
        }
        protected override void FnEvent3D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            FntnPic(player, type, doMsgs);
            if (GET_FLAG(player, type, doMsgs, DUNGEON, MISTY) == 1) {
                TAKE_ITEM(player, type, doMsgs, FRONTDOORKEY);
                SHOW_TEXT(player, type, doMsgs, "The haze surrounding Misty Fountain has no further effect.");
                SHOW_TEXT(player, type, doMsgs, "The Front Door Key disappears.");
            }
            else if (HAS_ITEM(player, type, doMsgs, FRONTDOORKEY)) {
                TAKE_ITEM(player, type, doMsgs, FRONTDOORKEY);
                SHOW_TEXT(player, type, doMsgs, "The Front Door Key disappears.");
                SET_FLAG(player, type, doMsgs, DUNGEON, MISTY, 1);
                if (GUILD(player, type, doMsgs) == BARBARIAN || GUILD(player, type, doMsgs) == CLERIC || GUILD(player, type, doMsgs) == RANGER || GUILD(player, type, doMsgs) == WIZARD) {
                    GIVE_SPELL(player, type, doMsgs, TRUE_SEEING_SPELL, 1);
                    SHOW_TEXT(player, type, doMsgs, "The haze surrounding Misty Fountain empowers you with the True Seeing spell.");
                }
                else if (GUILD(player, type, doMsgs) == KNIGHT || GUILD(player, type, doMsgs) == THIEF) {
                    GIVE_SPELL(player, type, doMsgs, LIGHTNING_SPELL, 1);
                    SHOW_TEXT(player, type, doMsgs, "The haze surrounding Misty Fountain empowers you with the Lightning spell.");
                }
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "A door key will channel the powers in the haze.");
            }
        }
        protected override void FnEvent3E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Where music once played, battle sounds now rage.");
            if (HAS_ITEM(player, type, doMsgs, IRONRING)) {
                SET_BOOTY(player, type, doMsgs, SCROLLOFPROTECTION, HALOSCROLL, 0, 0, 0, 1000);
            }
            else {
                SET_BOOTY(player, type, doMsgs, IRONRING, AURASCROLL, SCROLLOFTHESUN, 0, 0, 3000);
            }
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 15);
                GET_MONSTER(player, type, doMsgs, 02, 21);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 15);
                GET_MONSTER(player, type, doMsgs, 02, 15);
                GET_MONSTER(player, type, doMsgs, 05, 21);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 15);
                GET_MONSTER(player, type, doMsgs, 02, 15);
                GET_MONSTER(player, type, doMsgs, 03, 19);
                GET_MONSTER(player, type, doMsgs, 05, 20);
                GET_MONSTER(player, type, doMsgs, 06, 22);
            }
        }
        protected override void FnEvent3F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "This is the Ingress to the Night Elves' Domain. The southern gateway will take you back to the Main Entrance.");
        }
        protected override void FnEvent40(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 1, 1, 222, NORTH);
        }
        protected override void FnEvent41(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (USED_ITEM(player, type, doMsgs, FRONTDOORKEY, FRONTDOORKEY)) {
                WallClear(player, type, doMsgs);
                DoorHere(player, type, doMsgs);
                SHOW_TEXT(player, type, doMsgs, "The Front Door Key opens the door.");
            }
            else {
                WallBlock(player, type, doMsgs);
                SHOW_TEXT(player, type, doMsgs, "The front door is locked.");
            }
        }
        protected override void FnEvent44(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You find a sheet of music with a song written in the key of C. The lyrics tell of two areas where race is the key to discovering treasure.");
        }
        protected override void FnEvent47(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 28);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 5);
                GET_MONSTER(player, type, doMsgs, 02, 29);
                GET_MONSTER(player, type, doMsgs, 03, 27);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 28);
                GET_MONSTER(player, type, doMsgs, 02, 29);
                GET_MONSTER(player, type, doMsgs, 03, 29);
                GET_MONSTER(player, type, doMsgs, 04, 30);
                GET_MONSTER(player, type, doMsgs, 06, 31);
            }
        }
        protected override void FnEvent48(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 11);
                GET_MONSTER(player, type, doMsgs, 02, 16);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 12);
                GET_MONSTER(player, type, doMsgs, 02, 17);
                GET_MONSTER(player, type, doMsgs, 06, 18);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 13);
                GET_MONSTER(player, type, doMsgs, 02, 14);
                GET_MONSTER(player, type, doMsgs, 03, 32);
                GET_MONSTER(player, type, doMsgs, 05, 15);
                GET_MONSTER(player, type, doMsgs, 06, 18);
            }
        }
        protected override void FnEvent49(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 25);
                GET_MONSTER(player, type, doMsgs, 02, 26);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 25);
                GET_MONSTER(player, type, doMsgs, 02, 25);
                GET_MONSTER(player, type, doMsgs, 05, 35);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 25);
                GET_MONSTER(player, type, doMsgs, 02, 25);
                GET_MONSTER(player, type, doMsgs, 03, 34);
                GET_MONSTER(player, type, doMsgs, 04, 34);
                GET_MONSTER(player, type, doMsgs, 06, 37);
            }
        }
        protected override void FnEvent4A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 1);
                GET_MONSTER(player, type, doMsgs, 02, 11);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 3);
                GET_MONSTER(player, type, doMsgs, 02, 1);
                GET_MONSTER(player, type, doMsgs, 06, 12);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 3);
                GET_MONSTER(player, type, doMsgs, 02, 1);
                GET_MONSTER(player, type, doMsgs, 03, 1);
                GET_MONSTER(player, type, doMsgs, 05, 12);
                GET_MONSTER(player, type, doMsgs, 06, 13);
            }
        }
        protected override void FnEvent4B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 36);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 34);
                GET_MONSTER(player, type, doMsgs, 02, 37);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 36);
                GET_MONSTER(player, type, doMsgs, 02, 36);
                GET_MONSTER(player, type, doMsgs, 03, 37);
                GET_MONSTER(player, type, doMsgs, 04, 37);
                GET_MONSTER(player, type, doMsgs, 05, 22);
            }
        }
        protected override void FnEvent4C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 20);
                GET_MONSTER(player, type, doMsgs, 05, 21);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 20);
                GET_MONSTER(player, type, doMsgs, 02, 22);
                GET_MONSTER(player, type, doMsgs, 03, 21);
                GET_MONSTER(player, type, doMsgs, 06, 40);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 20);
                GET_MONSTER(player, type, doMsgs, 02, 22);
                GET_MONSTER(player, type, doMsgs, 03, 22);
                GET_MONSTER(player, type, doMsgs, 05, 40);
                GET_MONSTER(player, type, doMsgs, 06, 40);
            }
        }
        private void Skey(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "The key is made of bone. The grasp is shaped like a skull and the shaft like two crossed, bony arms.");
        }
        private void EmptyRoom(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "The room is empty.");
        }
        private void DoorHere(TwPlayerServer player, MapEventType type, bool doMsgs) {
            PLACE_WALL_ITEM(player, type, doMsgs, DOOR, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
        }
        private void WallClear(TwPlayerServer player, MapEventType type, bool doMsgs) {
            CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
        }
        private void DamXit(TwPlayerServer player, MapEventType type, bool doMsgs) {
            DAMAGE(player, type, doMsgs, MAX_HEALTH(player, type, doMsgs));
        }
        private void WallBlock(TwPlayerServer player, MapEventType type, bool doMsgs) {
            BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
        }
        private void FntnPic(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, FOUNTAIN);
        }
    }
}
