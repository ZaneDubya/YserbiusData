using XPT.Generic.Maps;
using XPT.Twinion.Entities;

namespace XPT.Twinion.Maps {
    class TwMap13 : TwMap {
        protected override int MapIndex => 13;
        protected override int MapID => 0x0503;
        protected override int RandomEncounterChance => 0;
        protected override int RandomEncounterExtraCount => 2;

        private const int GRAVE_ZAP = 1;
        private const int RANDOMMONST = 1;
        protected override void FnEvent01(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 6, 1, 132, NORTH);
            SHOW_TEXT(player, type, doMsgs, "To Carriage House");
        }
        protected override void FnEvent02(TwPlayerServer player, MapEventType type, bool doMsgs) {
            NO_MAPS(player, type, doMsgs);
        }
        protected override void FnEvent03(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Darkness envelops you as you enter the Graveyard. You can barely read the sign which says, 'NorthEast Gate.'");
        }
        protected override void FnEvent04(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 7, 2, 75, WEST);
            SHOW_TEXT(player, type, doMsgs, "All that you can see on the door ahead is Sn k  P t.");
        }
        protected override void FnEvent05(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, DWARFWIZARD);
            SHOW_TEXT(player, type, doMsgs, "You meet Xanith the Cartographer, who is trying to map the cemetery.");
            SHOW_TEXT(player, type, doMsgs, "'Ah, more adventurers on the way to my shop! Have you mastered the dungeon thus far?");
            SHOW_TEXT(player, type, doMsgs, "I hope you've found the secret clues that equal the number of Snicker's brothers.");
            SHOW_TEXT(player, type, doMsgs, "If you have not, my assistants' payments will be of no value to you.'");
        }
        protected override void FnEvent06(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (USED_SKILL(player, type, doMsgs, DETECT_SKILL) >= 6 || USED_SPELL(player, type, doMsgs, TRUE_SEEING_SPELL) >= 1 || USED_ITEM(player, type, doMsgs, HELMOFWISDOM, HELMOFWISDOM) || USED_ITEM(player, type, doMsgs, VALKYRIESHELM, VALKYRIESHELM) || USED_ITEM(player, type, doMsgs, RINGOFTHIEVES, RINGOFTHIEVES) || USED_ITEM(player, type, doMsgs, CRYSTALBALL, CRYSTALBALL)) {
                SHOW_TEXT(player, type, doMsgs, "The tomb door opens.");
                DoorHere(player, type, doMsgs);
                WallClear(player, type, doMsgs);
            }
            else {
                WallBlock(player, type, doMsgs);
            }
        }
        protected override void FnEvent07(TwPlayerServer player, MapEventType type, bool doMsgs) {
            FnEvent02(player, type, doMsgs);
            SHOW_TEXT(player, type, doMsgs, "You see the NorthEast Gate to the East.");
        }
        protected override void FnEvent08(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, ORCRANGER);
            SHOW_TEXT(player, type, doMsgs, "A Gravedigger appears and wags a bony finger at you.");
            SHOW_TEXT(player, type, doMsgs, "'All tombs do not contain treasure, you know. Some harbor grave rewards.'");
        }
        protected override void FnEvent09(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Disturbed graveyard spirits attack you.");
            if (HAS_ITEM(player, type, doMsgs, TRACKERSMASK)) {
                SET_BOOTY(player, type, doMsgs, ELIXIROFHEALTH, HALOSCROLL, 0, 0, 0, 1500);
            }
            else {
                SET_BOOTY(player, type, doMsgs, TRACKERSMASK, MANAELIXIR, ELIXIROFHEALTH, 0, 0, 3000);
            }
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 3);
                GET_MONSTER(player, type, doMsgs, 05, 34);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 25);
                GET_MONSTER(player, type, doMsgs, 02, 27);
                GET_MONSTER(player, type, doMsgs, 03, 27);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 28);
                GET_MONSTER(player, type, doMsgs, 02, 11);
                GET_MONSTER(player, type, doMsgs, 03, 27);
                GET_MONSTER(player, type, doMsgs, 04, 8);
            }
        }
        protected override void FnEvent0A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            FnEvent02(player, type, doMsgs);
            SHOW_PICTURE(player, type, doMsgs, FOUNTAIN);
            HEAL(player, type, doMsgs, MAX_HEALTH(player, type, doMsgs));
            MOD_MANA(player, type, doMsgs, 10000);
            SHOW_TEXT(player, type, doMsgs, "Angel Fountain replenishes your Health and Mana.");
        }
        protected override void FnEvent0B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            FnEvent02(player, type, doMsgs);
            TELEPORT(player, type, doMsgs, 5, 3, 28, NORTH);
            SHOW_TEXT(player, type, doMsgs, "The shadows of death that clutch at you evaporate as you are spirited to safety.");
        }
        protected override void FnEvent0C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (USED_SKILL(player, type, doMsgs, DETECT_SKILL) >= 6 || USED_SPELL(player, type, doMsgs, TRUE_SEEING_SPELL) >= 1 || USED_ITEM(player, type, doMsgs, HELMOFWISDOM, HELMOFWISDOM) || USED_ITEM(player, type, doMsgs, VALKYRIESHELM, VALKYRIESHELM) || USED_ITEM(player, type, doMsgs, RINGOFTHIEVES, RINGOFTHIEVES) || USED_ITEM(player, type, doMsgs, CRYSTALBALL, CRYSTALBALL)) {
                SHOW_TEXT(player, type, doMsgs, "You discover a long forgotten door.");
                DoorHere(player, type, doMsgs);
                WallClear(player, type, doMsgs);
            }
            else {
                WallBlock(player, type, doMsgs);
            }
        }
        protected override void FnEvent0D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You disturb the souls of the entombed.");
            if (HAS_ITEM(player, type, doMsgs, LIGHTNINGROD) || HAS_ITEM(player, type, doMsgs, JADEDRING)) {
                SET_BOOTY(player, type, doMsgs, BINDINGTALISMAN, ICESHIELD, 0, 0, 0, 1000);
            }
            else {
                SET_BOOTY(player, type, doMsgs, JADEDRING, LIGHTNINGROD, LIFEGIVER, 0, 0, 3000);
            }
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 6);
                GET_MONSTER(player, type, doMsgs, 02, 34);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 2);
                GET_MONSTER(player, type, doMsgs, 02, 5);
                GET_MONSTER(player, type, doMsgs, 03, 28);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 2);
                GET_MONSTER(player, type, doMsgs, 02, 3);
                GET_MONSTER(player, type, doMsgs, 03, 25);
                GET_MONSTER(player, type, doMsgs, 05, 26);
                GET_MONSTER(player, type, doMsgs, 06, 28);
            }
        }
        protected override void FnEvent0E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            FnEvent02(player, type, doMsgs);
            if ((GET_FLAG(player, type, doMsgs, ROOM, GRAVE_ZAP) == 0)) {
                DAMAGE(player, type, doMsgs, HEALTH(player, type, doMsgs) / 4);
                SHOW_TEXT(player, type, doMsgs, "A clumsy fall into an open grave injures you.");
                SET_FLAG(player, type, doMsgs, ROOM, GRAVE_ZAP, 1);
            }
        }
        protected override void FnEvent0F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            FnEvent02(player, type, doMsgs);
            SHOW_TEXT(player, type, doMsgs, "Scattered bones are all that's left of looted tombs.");
        }
        protected override void FnEvent10(TwPlayerServer player, MapEventType type, bool doMsgs) {
            WallClear(player, type, doMsgs);
        }
        protected override void FnEvent11(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (USED_ITEM(player, type, doMsgs, BLUELOCKPICK, BLUELOCKPICK) || USED_ITEM(player, type, doMsgs, HELMOFGUILE, HELMOFGUILE) || USED_SKILL(player, type, doMsgs, LOCKPICK_SKILL) >= 11) {
                SHOW_TEXT(player, type, doMsgs, "You have successfully unlocked the tomb door.");
                DoorHere(player, type, doMsgs);
                WallClear(player, type, doMsgs);
            }
            else {
                WallBlock(player, type, doMsgs);
                DoorHere(player, type, doMsgs);
                SHOW_TEXT(player, type, doMsgs, "The door to the old tomb is locked.");
            }
        }
        protected override void FnEvent12(TwPlayerServer player, MapEventType type, bool doMsgs) {
            FnEvent02(player, type, doMsgs);
            SHOW_PICTURE(player, type, doMsgs, FOUNTAIN);
            if (GUILD(player, type, doMsgs) == BARBARIAN || GUILD(player, type, doMsgs) == KNIGHT || GUILD(player, type, doMsgs) == THIEF) {
                if ((GET_SKILL(player, type, doMsgs, FURTIVENESS_SKILL) == 0)) {
                    MOD_SKILL(player, type, doMsgs, FURTIVENESS_SKILL, 1);
                    SHOW_TEXT(player, type, doMsgs, "Skeletal Fountain gives you the Furtiveness Skill.");
                }
                else {
                    SHOW_TEXT(player, type, doMsgs, "The waters of Skeletal Fountain quench your thirst.");
                }
            }
            else if (GUILD(player, type, doMsgs) == RANGER || GUILD(player, type, doMsgs) == WIZARD) {
                if ((GET_SKILL(player, type, doMsgs, PICKPOCKET_SKILL) == 0)) {
                    MOD_SKILL(player, type, doMsgs, PICKPOCKET_SKILL, 1);
                    SHOW_TEXT(player, type, doMsgs, "Skeletal Fountain gives you the Pickpocket Skill.");
                }
                else {
                    SHOW_TEXT(player, type, doMsgs, "The waters of Skeletal Fountain quench your thirst.");
                }
            }
            else if (GUILD(player, type, doMsgs) == CLERIC) {
                if ((GET_FLAG(player, type, doMsgs, DUNGEON, REFRESHCLERIC) == 0)) {
                    GIVE_SPELL(player, type, doMsgs, REFRESH_SPELL, 1);
                    SET_FLAG(player, type, doMsgs, DUNGEON, REFRESHCLERIC, 1);
                    SHOW_TEXT(player, type, doMsgs, "Skeletal Fountain gives you the power to refresh your party.");
                }
                else {
                    SHOW_TEXT(player, type, doMsgs, "The waters of Skeletal Fountain quench your thirst.");
                }
            }
        }
        protected override void FnEvent13(TwPlayerServer player, MapEventType type, bool doMsgs) {
            FnEvent02(player, type, doMsgs);
            SHOW_TEXT(player, type, doMsgs, "The howling wind uproots you and carries you off.");
            TELEPORT(player, type, doMsgs, 5, 3, 202, NORTH);
        }
        protected override void FnEvent14(TwPlayerServer player, MapEventType type, bool doMsgs) {
            FnEvent02(player, type, doMsgs);
            int i = 0;
            if ((GET_FLAG(player, type, doMsgs, ROOM, GRAVE_ZAP) == 0)) {
                SHOW_TEXT(player, type, doMsgs, "Graverobbers, hearing your approach, ambush you. Sharp steel slices across your torso!");
                if (HEALTH(player, type, doMsgs) > 1000) {
                    DAMAGE(player, type, doMsgs, HEALTH(player, type, doMsgs) - 500);
                    SET_FLAG(player, type, doMsgs, ROOM, GRAVE_ZAP, 1);
                }
            }
            switch (PARTY_COUNT(player, type, doMsgs)) {
                case 1:
                    for (i = 1; i <= 3; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 23);
                    }
                    break;
                default:
                    for (i = 1; i <= 6; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 24);
                    }
                    break;
            }
        }
        protected override void FnEvent15(TwPlayerServer player, MapEventType type, bool doMsgs) {
            NO_MAPS(player, type, doMsgs);
            if (GET_FLAG(player, type, doMsgs, DUNGEON, SPIRIT) == 1) {
                SHOW_TEXT(player, type, doMsgs, "Searching the musty tomb unearths a few items concealed behind some rubble.");
                SHOW_TEXT(player, type, doMsgs, "You are rewarded for your insight.");
                if (GUILD(player, type, doMsgs) == WIZARD || GUILD(player, type, doMsgs) == CLERIC) {
                    MOD_EXP(player, type, doMsgs, 15000);
                    GIVE_ITEM(player, type, doMsgs, DIVININGROD);
                    GIVE_ITEM(player, type, doMsgs, PLATINUMBAR);
                    GIVE_ITEM(player, type, doMsgs, HEALALLPOTION);
                    SET_FLAG(player, type, doMsgs, DUNGEON, SPIRIT, 2);
                }
                else if (GUILD(player, type, doMsgs) == THIEF || GUILD(player, type, doMsgs) == RANGER) {
                    MOD_EXP(player, type, doMsgs, 15000);
                    GIVE_ITEM(player, type, doMsgs, LANCEOFDARKNESS);
                    GIVE_ITEM(player, type, doMsgs, PLATINUMBAR);
                    GIVE_ITEM(player, type, doMsgs, SYMBOLOFDEATH);
                    SET_FLAG(player, type, doMsgs, DUNGEON, SPIRIT, 2);
                }
                else if (GUILD(player, type, doMsgs) == BARBARIAN || GUILD(player, type, doMsgs) == KNIGHT) {
                    MOD_EXP(player, type, doMsgs, 15000);
                    GIVE_ITEM(player, type, doMsgs, MERCURYAXE);
                    GIVE_ITEM(player, type, doMsgs, PLATINUMBAR);
                    GIVE_ITEM(player, type, doMsgs, SOVEREIGNSCROLL);
                    SET_FLAG(player, type, doMsgs, DUNGEON, SPIRIT, 2);
                }
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "The tomb appears to be a good hiding place, but your search this time is futile.");
            }
        }
        protected override void FnEvent16(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HAS_ITEM(player, type, doMsgs, LUMINOUSLANTERN)) {
                SHOW_TEXT(player, type, doMsgs, "The torch flares, lighting your lantern. You catch a brief glimpse of the graveyard before the wind douses your flame.");
            }
            else {
                FnEvent02(player, type, doMsgs);
                SHOW_TEXT(player, type, doMsgs, "The torch does not cast enough illumination to light your path, nor can it be removed.");
                SHOW_TEXT(player, type, doMsgs, "A portable source of light would be particularly useful in the Graveyard.");
            }
        }
        protected override void FnEvent17(TwPlayerServer player, MapEventType type, bool doMsgs) {
            FnEvent02(player, type, doMsgs);
            SHOW_TEXT(player, type, doMsgs, "You become dizzy and sense that you are no longer inside the tomb.");
            TELEPORT(player, type, doMsgs, 5, 3, 69, EAST);
        }
        protected override void FnEvent18(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You stumble upon grave robbers ransacking a tomb.");
            if (HAS_ITEM(player, type, doMsgs, BOWOFFLAMES)) {
                SET_BOOTY(player, type, doMsgs, SILVERBAR, READTRACKSTALISMAN, 0, 0, 0, 1500);
            }
            else {
                SET_BOOTY(player, type, doMsgs, SILVERBAR, BOWOFFLAMES, BLOODSHIELD, 0, 0, 2500);
            }
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 24);
                GET_MONSTER(player, type, doMsgs, 02, 39);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 23);
                GET_MONSTER(player, type, doMsgs, 02, 24);
                GET_MONSTER(player, type, doMsgs, 03, 39);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 31);
                GET_MONSTER(player, type, doMsgs, 02, 35);
                GET_MONSTER(player, type, doMsgs, 03, 23);
                GET_MONSTER(player, type, doMsgs, 05, 24);
                GET_MONSTER(player, type, doMsgs, 06, 27);
            }
        }
        protected override void FnEvent19(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You encounter scavengers.");
            if (HAS_ITEM(player, type, doMsgs, SCROLLOFDEATH)) {
                SET_BOOTY(player, type, doMsgs, SILVERBAR, SHAMANSCROLL, 0, 0, 0, 1000);
            }
            else {
                SET_BOOTY(player, type, doMsgs, SILVERBAR, SCROLLOFDEATH, SCROLLOFSAFETY, 0, 0, 2000);
            }
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 16);
                GET_MONSTER(player, type, doMsgs, 02, 29);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 15);
                GET_MONSTER(player, type, doMsgs, 02, 18);
                GET_MONSTER(player, type, doMsgs, 05, 19);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 15);
                GET_MONSTER(player, type, doMsgs, 02, 18);
                GET_MONSTER(player, type, doMsgs, 03, 30);
                GET_MONSTER(player, type, doMsgs, 04, 30);
                GET_MONSTER(player, type, doMsgs, 06, 33);
            }
        }
        protected override void FnEvent1A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            FnEvent02(player, type, doMsgs);
            SHOW_TEXT(player, type, doMsgs, "The worn tombstone bears the inscription, 'Wilthorg Zerium.'");
        }
        protected override void FnEvent1B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            FnEvent02(player, type, doMsgs);
            SHOW_TEXT(player, type, doMsgs, "You stumble upon the remains of Yartor Megilthorn.");
        }
        protected override void FnEvent1C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            FnEvent02(player, type, doMsgs);
            SHOW_TEXT(player, type, doMsgs, "The inscription on the tombstone has been eroded beyond recognition by the elements.");
        }
        protected override void FnEvent1D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int mn1 = 0;
            int mn2 = 0;
            int i = 0;
            int pfv = 0;
            pfv = GET_FLAG(player, type, doMsgs, PARTY, RANDOMMONST);
            switch (pfv) {
                case 1:
                    mn1 = 1;
                    mn2 = 5;
                    break;
                case 2:
                    mn1 = 15;
                    mn2 = 18;
                    break;
                case 3:
                    mn1 = 7;
                    mn2 = 8;
                    break;
                default:
                    mn1 = 21;
                    mn2 = 24;
                    break;
            }
            switch (PARTY_COUNT(player, type, doMsgs)) {
                case 1:
                    GET_MONSTER(player, type, doMsgs, 01, mn1);
                    break;
                case 2:
                    GET_MONSTER(player, type, doMsgs, 01, mn1);
                    GET_MONSTER(player, type, doMsgs, 02, mn2);
                    break;
                default:
                    for (i = 1; i <= 2; i++) {
                        GET_MONSTER(player, type, doMsgs, i, mn1);
                    }
                    for (i = 5; i <= 6; i++) {
                        GET_MONSTER(player, type, doMsgs, i, mn2);
                    }
                    break;
            }
        }
        protected override void FnEvent1E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HAS_ITEM(player, type, doMsgs, LUMINOUSLANTERN)) {
                SHOW_TEXT(player, type, doMsgs, "The magical aura emanating from the tomb lights your lantern for a brief moment.");
            }
            else {
                FnEvent02(player, type, doMsgs);
                SHOW_TEXT(player, type, doMsgs, "You overhear a group of adventurers discussing the strange flickering of their lantern in the tomb.");
            }
        }
        protected override void FnEvent1F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "The volcanic activity has weakened some of the walls and tomb doors in this area.");
            FnEvent02(player, type, doMsgs);
        }
        protected override void FnEvent20(TwPlayerServer player, MapEventType type, bool doMsgs) {
            FnEvent02(player, type, doMsgs);
            SHOW_TEXT(player, type, doMsgs, "A ghostly voice whispers, 'To the South you will meet four Spirits. Each will offer you a gift.");
            SHOW_TEXT(player, type, doMsgs, "Choose wisely for you will be able to accept only one gift. Once your decision is made, enter the door of your choice.'");
        }
        protected override void FnEvent21(TwPlayerServer player, MapEventType type, bool doMsgs) {
            FnEvent02(player, type, doMsgs);
            SHOW_TEXT(player, type, doMsgs, "The sorrowful wind whispers -");
            SHOW_TEXT(player, type, doMsgs, "'The Spirit to the East offers the gift of increased Strength.'");
        }
        protected override void FnEvent22(TwPlayerServer player, MapEventType type, bool doMsgs) {
            FnEvent02(player, type, doMsgs);
            SHOW_PICTURE(player, type, doMsgs, WRAITH);
            if (GET_FLAG(player, type, doMsgs, DUNGEON, SPIRIT) == 1 || GET_FLAG(player, type, doMsgs, DUNGEON, SPIRIT) == 2) {
                SHOW_TEXT(player, type, doMsgs, "You've already chosen your gift.");
            }
            else {
                SET_FLAG(player, type, doMsgs, DUNGEON, SPIRIT, 1);
                SHOW_TEXT(player, type, doMsgs, "The Spirit of a Warrior endows you with increased Strength.");
                MOD_STAT(player, type, doMsgs, STRENGTH, 2);
            }
        }
        protected override void FnEvent23(TwPlayerServer player, MapEventType type, bool doMsgs) {
            FnEvent02(player, type, doMsgs);
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                SHOW_TEXT(player, type, doMsgs, "You may rejoin your party.");
            }
            else {
                TELEPORT(player, type, doMsgs, 5, 3, 192, NORTH);
            }
        }
        protected override void FnEvent24(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (USED_ITEM(player, type, doMsgs, LUMINOUSLANTERN, LUMINOUSLANTERN)) {
                WallClear(player, type, doMsgs);
                DoorHere(player, type, doMsgs);
                SHOW_TEXT(player, type, doMsgs, "The Luminous Lantern glows feebly for a few moments.");
                SHOW_TEXT(player, type, doMsgs, "You barely detect a rusty bolt that locks the mildewed door.");
                SHOW_TEXT(player, type, doMsgs, "A moment later, the bolt is thrown and the door is open.");
            }
            else {
                WallBlock(player, type, doMsgs);
                SHOW_TEXT(player, type, doMsgs, "A locked door bars your way. Perhaps if you had a bit of light you could determine the cause.");
            }
        }
        protected override void FnEvent25(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "A large sign warns -");
            SHOW_TEXT(player, type, doMsgs, "'DO NOT ENTER unless you have all four map pieces or have completed the Queen's map quest. Proceed through this door alone and rejoin your party on the other side.'");
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                if ((HAS_ITEM(player, type, doMsgs, PARCHMENTMAP) && HAS_ITEM(player, type, doMsgs, SNAKESKINMAP) && HAS_ITEM(player, type, doMsgs, LEATHERMAP) && HAS_ITEM(player, type, doMsgs, SLATEMAP)) || (GET_FLAG(player, type, doMsgs, DUNGEON, PATHWAYDONE) == 1)) {
                    WallClear(player, type, doMsgs);
                    DoorHere(player, type, doMsgs);
                }
            }
            else {
                WallBlock(player, type, doMsgs);
                SHOW_TEXT(player, type, doMsgs, "Your entry is barred.");
            }
        }
        protected override void FnEvent26(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, GREMLINCLERIC);
            SHOW_TEXT(player, type, doMsgs, "'Word has it that pieces of the map are scattered throughout the levels of the dungeon.'");
        }
        protected override void FnEvent27(TwPlayerServer player, MapEventType type, bool doMsgs) {
            FnEvent02(player, type, doMsgs);
            SHOW_TEXT(player, type, doMsgs, "A haunted voice quavers -");
            SHOW_TEXT(player, type, doMsgs, "'The Spirit to the East will offer the gift of increased Defense.'");
        }
        protected override void FnEvent28(TwPlayerServer player, MapEventType type, bool doMsgs) {
            FnEvent02(player, type, doMsgs);
            SHOW_PICTURE(player, type, doMsgs, WRAITH);
            if (GET_FLAG(player, type, doMsgs, DUNGEON, SPIRIT) == 1 || GET_FLAG(player, type, doMsgs, DUNGEON, SPIRIT) == 2) {
                SHOW_TEXT(player, type, doMsgs, "You've already chosen your gift.");
            }
            else {
                SET_FLAG(player, type, doMsgs, DUNGEON, SPIRIT, 1);
                SHOW_TEXT(player, type, doMsgs, "The Spirit of a Guard endows you with increased Defense.");
                MOD_STAT(player, type, doMsgs, DEFENSE, 2);
            }
        }
        protected override void FnEvent29(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, DWARFKNIGHT);
            SHOW_TEXT(player, type, doMsgs, "'Trust the wrong thief with your goods and you may end up here permanently.'");
        }
        protected override void FnEvent2A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            FnEvent02(player, type, doMsgs);
            SHOW_TEXT(player, type, doMsgs, "A distant wraith wails -");
            SHOW_TEXT(player, type, doMsgs, "'The Spirit to the East blesses with the gift of increased Agility.'");
        }
        protected override void FnEvent2B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            FnEvent02(player, type, doMsgs);
            SHOW_PICTURE(player, type, doMsgs, WRAITH);
            if (GET_FLAG(player, type, doMsgs, DUNGEON, SPIRIT) == 1 || GET_FLAG(player, type, doMsgs, DUNGEON, SPIRIT) == 2) {
                SHOW_TEXT(player, type, doMsgs, "You've already chosen your gift.");
            }
            else {
                SET_FLAG(player, type, doMsgs, DUNGEON, SPIRIT, 1);
                SHOW_TEXT(player, type, doMsgs, "The Spirit of an Athlete endows you with increased Agility.");
                MOD_STAT(player, type, doMsgs, AGILITY, 2);
            }
        }
        protected override void FnEvent2C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            FnEvent02(player, type, doMsgs);
            SHOW_TEXT(player, type, doMsgs, "The ground gives way and you slide into The Crypt.");
            TELEPORT(player, type, doMsgs, 6, 1, 221, SOUTH);
        }
        protected override void FnEvent2D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HAS_ITEM(player, type, doMsgs, SKELETONKEY)) {
                SHOW_TEXT(player, type, doMsgs, "As you approach the portal to the Cartography Shop, your Skeleton Key tumbles to the ground and is lost in the mud.");
                TAKE_ITEM(player, type, doMsgs, SKELETONKEY);
                TELEPORT(player, type, doMsgs, 5, 2, 247, NORTH);
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "The portal marks the entrance to the Cartography Shop.");
                TELEPORT(player, type, doMsgs, 5, 2, 247, NORTH);
            }
        }
        protected override void FnEvent2E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            FnEvent02(player, type, doMsgs);
            SHOW_TEXT(player, type, doMsgs, "A nearby owl hoots -");
            SHOW_TEXT(player, type, doMsgs, "'The Spirit to the East can give you a gift that increases Initiative.'");
        }
        protected override void FnEvent2F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            FnEvent02(player, type, doMsgs);
            SHOW_PICTURE(player, type, doMsgs, WRAITH);
            if (GET_FLAG(player, type, doMsgs, DUNGEON, SPIRIT) == 1 || GET_FLAG(player, type, doMsgs, DUNGEON, SPIRIT) == 2) {
                SHOW_TEXT(player, type, doMsgs, "You've already chosen your gift.");
            }
            else {
                SET_FLAG(player, type, doMsgs, DUNGEON, SPIRIT, 1);
                SHOW_TEXT(player, type, doMsgs, "The Spirit of a Cavalier endows you with increased Initiative.");
                MOD_STAT(player, type, doMsgs, INITIATIVE, 2);
            }
        }
        protected override void FnEvent30(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You blink as you see a shadowy figure seemingly walking through a solid wall.");
            FnEvent02(player, type, doMsgs);
        }
        protected override void FnEvent31(TwPlayerServer player, MapEventType type, bool doMsgs) {
            FnEvent02(player, type, doMsgs);
            SHOW_PICTURE(player, type, doMsgs, FOUNTAIN);
            HEAL(player, type, doMsgs, MAX_HEALTH(player, type, doMsgs));
            SHOW_TEXT(player, type, doMsgs, "The waters of Twilight Fountain heal your wounds.");
        }
        protected override void FnEvent32(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 38);
                GET_MONSTER(player, type, doMsgs, 05, 39);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 20);
                GET_MONSTER(player, type, doMsgs, 02, 21);
                GET_MONSTER(player, type, doMsgs, 05, 38);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 36);
                GET_MONSTER(player, type, doMsgs, 02, 40);
                GET_MONSTER(player, type, doMsgs, 03, 38);
                GET_MONSTER(player, type, doMsgs, 04, 38);
            }
        }
        protected override void FnEvent33(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 23);
                GET_MONSTER(player, type, doMsgs, 05, 29);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 24);
                GET_MONSTER(player, type, doMsgs, 02, 24);
                GET_MONSTER(player, type, doMsgs, 04, 18);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 23);
                GET_MONSTER(player, type, doMsgs, 02, 40);
                GET_MONSTER(player, type, doMsgs, 03, 18);
                GET_MONSTER(player, type, doMsgs, 04, 16);
            }
        }
        protected override void FnEvent34(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 1);
                GET_MONSTER(player, type, doMsgs, 02, 34);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 3);
                GET_MONSTER(player, type, doMsgs, 02, 5);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 3);
                GET_MONSTER(player, type, doMsgs, 02, 4);
                GET_MONSTER(player, type, doMsgs, 05, 26);
                GET_MONSTER(player, type, doMsgs, 06, 26);
            }
        }
        protected override void FnEvent35(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1 || PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 6);
                GET_MONSTER(player, type, doMsgs, 02, 12);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 7);
                GET_MONSTER(player, type, doMsgs, 02, 6);
                GET_MONSTER(player, type, doMsgs, 03, 13);
                GET_MONSTER(player, type, doMsgs, 04, 10);
            }
        }
        protected override void FnEvent36(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 20);
                GET_MONSTER(player, type, doMsgs, 02, 39);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 24);
                GET_MONSTER(player, type, doMsgs, 02, 23);
                GET_MONSTER(player, type, doMsgs, 05, 39);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 24);
                GET_MONSTER(player, type, doMsgs, 02, 23);
                GET_MONSTER(player, type, doMsgs, 03, 36);
                GET_MONSTER(player, type, doMsgs, 04, 20);
                GET_MONSTER(player, type, doMsgs, 05, 32);
            }
        }
        protected override void FnEvent37(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You hear the sound of looting somewhere nearby.");
        }
        private void WallClear(TwPlayerServer player, MapEventType type, bool doMsgs) {
            CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
        }
        private void WallBlock(TwPlayerServer player, MapEventType type, bool doMsgs) {
            BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
        }
        private void DoorHere(TwPlayerServer player, MapEventType type, bool doMsgs) {
            PLACE_WALL_ITEM(player, type, doMsgs, DOOR, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
        }
        protected override void FnEvent38(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, DUNGEON, SPIRIT) == 1) {
                SHOW_TEXT(player, type, doMsgs, "A luminescent message magically appears on the door.");
                SHOW_TEXT(player, type, doMsgs, "'You have discovered the secret of the spirits and have received their blessing! Continue your search, champion. The graveyard offers passages to the clever.'");
            }
        }
        protected override void FnEvent39(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GET_FLAG(player, type, doMsgs, DUNGEON, SPIRIT) == 0)) {
                SHOW_PICTURE(player, type, doMsgs, TROLLKNIGHT);
                SHOW_TEXT(player, type, doMsgs, "'Ah, I see you haven't been blessed by the spirits yet!");
                SHOW_TEXT(player, type, doMsgs, "Walk cautiously, my friend. The graveyard is as dangerous as it is rewarding. The benevolent spirits await thee!'");
            }
        }
    }
}
