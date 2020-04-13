using XPT.Games.Generic.Constants;
using XPT.Games.Generic.Maps;
using XPT.Games.Twinion.Entities;

namespace XPT.Games.Twinion.Maps {
    class TwMap13 : TwMap {
        public override int MapIndex => 13;
        public override int MapID => 0x0503;
        protected override int RandomEncounterChance => 0;
        protected override int RandomEncounterExtraCount => 2;

        private const int GRAVE_ZAP = 1;
        private const int RANDOMMONST = 1;
        protected override void FnEvent01(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 6, 1, 132, Direction.North);
            ShowText(player, type, doMsgs, "To Carriage House");
        }
        protected override void FnEvent02(TwPlayerServer player, MapEventType type, bool doMsgs) {
            DisableAutomaps(player, type, doMsgs);
        }
        protected override void FnEvent03(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Darkness envelops you as you enter the Graveyard. You can barely read the sign which says, 'NorthEast Gate.'");
        }
        protected override void FnEvent04(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 7, 2, 75, Direction.West);
            ShowText(player, type, doMsgs, "All that you can see on the door ahead is Sn k  P t.");
        }
        protected override void FnEvent05(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, DWARFWIZARD);
            ShowText(player, type, doMsgs, "You meet Xanith the Cartographer, who is trying to map the cemetery.");
            ShowText(player, type, doMsgs, "'Ah, more adventurers on the way to my shop! Have you mastered the dungeon thus far?");
            ShowText(player, type, doMsgs, "I hope you've found the secret clues that equal the number of Snicker's brothers.");
            ShowText(player, type, doMsgs, "If you have not, my assistants' payments will be of no value to you.'");
        }
        protected override void FnEvent06(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HasUsedSkill(player, type, ref doMsgs, DETECT_SKILL) >= 6 || HasUsedSpell(player, type, ref doMsgs, TRUE_SEEING_SPELL) >= 1 || UsedItem(player, type, ref doMsgs, HELMOFWISDOM, HELMOFWISDOM) || UsedItem(player, type, ref doMsgs, VALKYRIESHELM, VALKYRIESHELM) || UsedItem(player, type, ref doMsgs, RINGOFTHIEVES, RINGOFTHIEVES) || UsedItem(player, type, ref doMsgs, CRYSTALBALL, CRYSTALBALL)) {
                ShowText(player, type, doMsgs, "The tomb door opens.");
                DoorHere(player, type, doMsgs);
                WallClear(player, type, doMsgs);
            }
            else {
                WallBlock(player, type, doMsgs);
            }
        }
        protected override void FnEvent07(TwPlayerServer player, MapEventType type, bool doMsgs) {
            FnEvent02(player, type, doMsgs);
            ShowText(player, type, doMsgs, "You see the NorthEast Gate to the East.");
        }
        protected override void FnEvent08(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, ORCRANGER);
            ShowText(player, type, doMsgs, "A Gravedigger appears and wags a bony finger at you.");
            ShowText(player, type, doMsgs, "'All tombs do not contain treasure, you know. Some harbor grave rewards.'");
        }
        protected override void FnEvent09(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Disturbed graveyard spirits attack you.");
            if (HasItem(player, type, doMsgs, TRACKERSMASK)) {
                SetTreasure(player, type, doMsgs, ELIXIROFHEALTH, HALOSCROLL, 0, 0, 0, 1500);
            }
            else {
                SetTreasure(player, type, doMsgs, TRACKERSMASK, MANAELIXIR, ELIXIROFHEALTH, 0, 0, 3000);
            }
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 3);
                AddEncounter(player, type, doMsgs, 05, 34);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 25);
                AddEncounter(player, type, doMsgs, 02, 27);
                AddEncounter(player, type, doMsgs, 03, 27);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 28);
                AddEncounter(player, type, doMsgs, 02, 11);
                AddEncounter(player, type, doMsgs, 03, 27);
                AddEncounter(player, type, doMsgs, 04, 8);
            }
        }
        protected override void FnEvent0A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            FnEvent02(player, type, doMsgs);
            ShowPortrait(player, type, doMsgs, FOUNTAIN);
            ModifyHealth(player, type, doMsgs, GetHealthMax(player, type, doMsgs));
            ModifyMana(player, type, doMsgs, 10000);
            ShowText(player, type, doMsgs, "Angel Fountain replenishes your Health and Mana.");
        }
        protected override void FnEvent0B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            FnEvent02(player, type, doMsgs);
            TeleportParty(player, type, doMsgs, 5, 3, 28, Direction.North);
            ShowText(player, type, doMsgs, "The shadows of death that clutch at you evaporate as you are spirited to safety.");
        }
        protected override void FnEvent0C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HasUsedSkill(player, type, ref doMsgs, DETECT_SKILL) >= 6 || HasUsedSpell(player, type, ref doMsgs, TRUE_SEEING_SPELL) >= 1 || UsedItem(player, type, ref doMsgs, HELMOFWISDOM, HELMOFWISDOM) || UsedItem(player, type, ref doMsgs, VALKYRIESHELM, VALKYRIESHELM) || UsedItem(player, type, ref doMsgs, RINGOFTHIEVES, RINGOFTHIEVES) || UsedItem(player, type, ref doMsgs, CRYSTALBALL, CRYSTALBALL)) {
                ShowText(player, type, doMsgs, "You discover a long forgotten door.");
                DoorHere(player, type, doMsgs);
                WallClear(player, type, doMsgs);
            }
            else {
                WallBlock(player, type, doMsgs);
            }
        }
        protected override void FnEvent0D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You disturb the souls of the entombed.");
            if (HasItem(player, type, doMsgs, LIGHTNINGROD) || HasItem(player, type, doMsgs, JADEDRING)) {
                SetTreasure(player, type, doMsgs, BINDINGTALISMAN, ICESHIELD, 0, 0, 0, 1000);
            }
            else {
                SetTreasure(player, type, doMsgs, JADEDRING, LIGHTNINGROD, LIFEGIVER, 0, 0, 3000);
            }
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 6);
                AddEncounter(player, type, doMsgs, 02, 34);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 2);
                AddEncounter(player, type, doMsgs, 02, 5);
                AddEncounter(player, type, doMsgs, 03, 28);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 2);
                AddEncounter(player, type, doMsgs, 02, 3);
                AddEncounter(player, type, doMsgs, 03, 25);
                AddEncounter(player, type, doMsgs, 05, 26);
                AddEncounter(player, type, doMsgs, 06, 28);
            }
        }
        protected override void FnEvent0E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            FnEvent02(player, type, doMsgs);
            if ((GetFlag(player, type, doMsgs, FlagTypeTile, GRAVE_ZAP) == 0)) {
                DoDamage(player, type, doMsgs, GetHealthCurrent(player, type, doMsgs) / 4);
                ShowText(player, type, doMsgs, "A clumsy fall into an open grave injures you.");
                SetFlag(player, type, doMsgs, FlagTypeTile, GRAVE_ZAP, 1);
            }
        }
        protected override void FnEvent0F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            FnEvent02(player, type, doMsgs);
            ShowText(player, type, doMsgs, "Scattered bones are all that's left of looted tombs.");
        }
        protected override void FnEvent10(TwPlayerServer player, MapEventType type, bool doMsgs) {
            WallClear(player, type, doMsgs);
        }
        protected override void FnEvent11(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (UsedItem(player, type, ref doMsgs, BLUELOCKPICK, BLUELOCKPICK) || UsedItem(player, type, ref doMsgs, HELMOFGUILE, HELMOFGUILE) || HasUsedSkill(player, type, ref doMsgs, LOCKPICK_SKILL) >= 11) {
                ShowText(player, type, doMsgs, "You have successfully unlocked the tomb door.");
                DoorHere(player, type, doMsgs);
                WallClear(player, type, doMsgs);
            }
            else {
                WallBlock(player, type, doMsgs);
                DoorHere(player, type, doMsgs);
                ShowText(player, type, doMsgs, "The door to the old tomb is locked.");
            }
        }
        protected override void FnEvent12(TwPlayerServer player, MapEventType type, bool doMsgs) {
            FnEvent02(player, type, doMsgs);
            ShowPortrait(player, type, doMsgs, FOUNTAIN);
            if (GetGuild(player, type, doMsgs) == BARBARIAN || GetGuild(player, type, doMsgs) == KNIGHT || GetGuild(player, type, doMsgs) == THIEF) {
                if ((GetSkill(player, type, doMsgs, FURTIVENESS_SKILL) == 0)) {
                    SetSkill(player, type, doMsgs, FURTIVENESS_SKILL, 1);
                    ShowText(player, type, doMsgs, "Skeletal Fountain gives you the Furtiveness Skill.");
                }
                else {
                    ShowText(player, type, doMsgs, "The waters of Skeletal Fountain quench your thirst.");
                }
            }
            else if (GetGuild(player, type, doMsgs) == RANGER || GetGuild(player, type, doMsgs) == WIZARD) {
                if ((GetSkill(player, type, doMsgs, PICKPOCKET_SKILL) == 0)) {
                    SetSkill(player, type, doMsgs, PICKPOCKET_SKILL, 1);
                    ShowText(player, type, doMsgs, "Skeletal Fountain gives you the Pickpocket Skill.");
                }
                else {
                    ShowText(player, type, doMsgs, "The waters of Skeletal Fountain quench your thirst.");
                }
            }
            else if (GetGuild(player, type, doMsgs) == CLERIC) {
                if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.REFRESHCLERIC) == 0)) {
                    GiveSpell(player, type, doMsgs, REFRESH_SPELL, 1);
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.REFRESHCLERIC, 1);
                    ShowText(player, type, doMsgs, "Skeletal Fountain gives you the power to refresh your party.");
                }
                else {
                    ShowText(player, type, doMsgs, "The waters of Skeletal Fountain quench your thirst.");
                }
            }
        }
        protected override void FnEvent13(TwPlayerServer player, MapEventType type, bool doMsgs) {
            FnEvent02(player, type, doMsgs);
            ShowText(player, type, doMsgs, "The howling wind uproots you and carries you off.");
            TeleportParty(player, type, doMsgs, 5, 3, 202, Direction.North);
        }
        protected override void FnEvent14(TwPlayerServer player, MapEventType type, bool doMsgs) {
            FnEvent02(player, type, doMsgs);
            int i = 0;
            if ((GetFlag(player, type, doMsgs, FlagTypeTile, GRAVE_ZAP) == 0)) {
                ShowText(player, type, doMsgs, "Graverobbers, hearing your approach, ambush you. Sharp steel slices across your torso!");
                if (GetHealthCurrent(player, type, doMsgs) > 1000) {
                    DoDamage(player, type, doMsgs, GetHealthCurrent(player, type, doMsgs) - 500);
                    SetFlag(player, type, doMsgs, FlagTypeTile, GRAVE_ZAP, 1);
                }
            }
            switch (GetPartyCount(player, type, doMsgs)) {
                case 1:
                    for (i = 1; i <= 3; i++) {
                        AddEncounter(player, type, doMsgs, i, 23);
                    }
                    break;
                default:
                    for (i = 1; i <= 6; i++) {
                        AddEncounter(player, type, doMsgs, i, 24);
                    }
                    break;
            }
        }
        protected override void FnEvent15(TwPlayerServer player, MapEventType type, bool doMsgs) {
            DisableAutomaps(player, type, doMsgs);
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.SPIRIT) == 1) {
                ShowText(player, type, doMsgs, "Searching the musty tomb unearths a few items concealed behind some rubble.");
                ShowText(player, type, doMsgs, "You are rewarded for your insight.");
                if (GetGuild(player, type, doMsgs) == WIZARD || GetGuild(player, type, doMsgs) == CLERIC) {
                    ModifyExperience(player, type, doMsgs, 15000);
                    GiveItem(player, type, doMsgs, DIVININGROD);
                    GiveItem(player, type, doMsgs, PLATINUMBAR);
                    GiveItem(player, type, doMsgs, HEALALLPOTION);
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.SPIRIT, 2);
                }
                else if (GetGuild(player, type, doMsgs) == THIEF || GetGuild(player, type, doMsgs) == RANGER) {
                    ModifyExperience(player, type, doMsgs, 15000);
                    GiveItem(player, type, doMsgs, LANCEOFDARKNESS);
                    GiveItem(player, type, doMsgs, PLATINUMBAR);
                    GiveItem(player, type, doMsgs, SYMBOLOFDEATH);
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.SPIRIT, 2);
                }
                else if (GetGuild(player, type, doMsgs) == BARBARIAN || GetGuild(player, type, doMsgs) == KNIGHT) {
                    ModifyExperience(player, type, doMsgs, 15000);
                    GiveItem(player, type, doMsgs, MERCURYAXE);
                    GiveItem(player, type, doMsgs, PLATINUMBAR);
                    GiveItem(player, type, doMsgs, SOVEREIGNSCROLL);
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.SPIRIT, 2);
                }
            }
            else {
                ShowText(player, type, doMsgs, "The tomb appears to be a good hiding place, but your search this time is futile.");
            }
        }
        protected override void FnEvent16(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HasItem(player, type, doMsgs, LUMINOUSLANTERN)) {
                ShowText(player, type, doMsgs, "The torch flares, lighting your lantern. You catch a brief glimpse of the graveyard before the wind douses your flame.");
            }
            else {
                FnEvent02(player, type, doMsgs);
                ShowText(player, type, doMsgs, "The torch does not cast enough illumination to light your path, nor can it be removed.");
                ShowText(player, type, doMsgs, "A portable source of light would be particularly useful in the Graveyard.");
            }
        }
        protected override void FnEvent17(TwPlayerServer player, MapEventType type, bool doMsgs) {
            FnEvent02(player, type, doMsgs);
            ShowText(player, type, doMsgs, "You become dizzy and sense that you are no longer inside the tomb.");
            TeleportParty(player, type, doMsgs, 5, 3, 69, Direction.East);
        }
        protected override void FnEvent18(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You stumble upon grave robbers ransacking a tomb.");
            if (HasItem(player, type, doMsgs, BOWOFFLAMES)) {
                SetTreasure(player, type, doMsgs, SILVERBAR, READTRACKSTALISMAN, 0, 0, 0, 1500);
            }
            else {
                SetTreasure(player, type, doMsgs, SILVERBAR, BOWOFFLAMES, BLOODSHIELD, 0, 0, 2500);
            }
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 24);
                AddEncounter(player, type, doMsgs, 02, 39);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 23);
                AddEncounter(player, type, doMsgs, 02, 24);
                AddEncounter(player, type, doMsgs, 03, 39);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 31);
                AddEncounter(player, type, doMsgs, 02, 35);
                AddEncounter(player, type, doMsgs, 03, 23);
                AddEncounter(player, type, doMsgs, 05, 24);
                AddEncounter(player, type, doMsgs, 06, 27);
            }
        }
        protected override void FnEvent19(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You encounter scavengers.");
            if (HasItem(player, type, doMsgs, SCROLLOFDEATH)) {
                SetTreasure(player, type, doMsgs, SILVERBAR, SHAMANSCROLL, 0, 0, 0, 1000);
            }
            else {
                SetTreasure(player, type, doMsgs, SILVERBAR, SCROLLOFDEATH, SCROLLOFSAFETY, 0, 0, 2000);
            }
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 16);
                AddEncounter(player, type, doMsgs, 02, 29);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 15);
                AddEncounter(player, type, doMsgs, 02, 18);
                AddEncounter(player, type, doMsgs, 05, 19);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 15);
                AddEncounter(player, type, doMsgs, 02, 18);
                AddEncounter(player, type, doMsgs, 03, 30);
                AddEncounter(player, type, doMsgs, 04, 30);
                AddEncounter(player, type, doMsgs, 06, 33);
            }
        }
        protected override void FnEvent1A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            FnEvent02(player, type, doMsgs);
            ShowText(player, type, doMsgs, "The worn tombstone bears the inscription, 'Wilthorg Zerium.'");
        }
        protected override void FnEvent1B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            FnEvent02(player, type, doMsgs);
            ShowText(player, type, doMsgs, "You stumble upon the remains of Yartor Megilthorn.");
        }
        protected override void FnEvent1C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            FnEvent02(player, type, doMsgs);
            ShowText(player, type, doMsgs, "The inscription on the tombstone has been eroded beyond recognition by the elements.");
        }
        protected override void FnEvent1D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int mn1 = 0;
            int mn2 = 0;
            int i = 0;
            int pfv = 0;
            pfv = GetFlag(player, type, doMsgs, FlagTypeParty, RANDOMMONST);
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
            switch (GetPartyCount(player, type, doMsgs)) {
                case 1:
                    AddEncounter(player, type, doMsgs, 01, mn1);
                    break;
                case 2:
                    AddEncounter(player, type, doMsgs, 01, mn1);
                    AddEncounter(player, type, doMsgs, 02, mn2);
                    break;
                default:
                    for (i = 1; i <= 2; i++) {
                        AddEncounter(player, type, doMsgs, i, mn1);
                    }
                    for (i = 5; i <= 6; i++) {
                        AddEncounter(player, type, doMsgs, i, mn2);
                    }
                    break;
            }
        }
        protected override void FnEvent1E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HasItem(player, type, doMsgs, LUMINOUSLANTERN)) {
                ShowText(player, type, doMsgs, "The magical aura emanating from the tomb lights your lantern for a brief moment.");
            }
            else {
                FnEvent02(player, type, doMsgs);
                ShowText(player, type, doMsgs, "You overhear a group of adventurers discussing the strange flickering of their lantern in the tomb.");
            }
        }
        protected override void FnEvent1F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "The volcanic activity has weakened some of the walls and tomb doors in this area.");
            FnEvent02(player, type, doMsgs);
        }
        protected override void FnEvent20(TwPlayerServer player, MapEventType type, bool doMsgs) {
            FnEvent02(player, type, doMsgs);
            ShowText(player, type, doMsgs, "A ghostly voice whispers, 'To the South you will meet four Spirits. Each will offer you a gift.");
            ShowText(player, type, doMsgs, "Choose wisely for you will be able to accept only one gift. Once your decision is made, enter the door of your choice.'");
        }
        protected override void FnEvent21(TwPlayerServer player, MapEventType type, bool doMsgs) {
            FnEvent02(player, type, doMsgs);
            ShowText(player, type, doMsgs, "The sorrowful wind whispers -");
            ShowText(player, type, doMsgs, "'The Spirit to the East offers the gift of increased Strength.'");
        }
        protected override void FnEvent22(TwPlayerServer player, MapEventType type, bool doMsgs) {
            FnEvent02(player, type, doMsgs);
            ShowPortrait(player, type, doMsgs, WRAITH);
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.SPIRIT) == 1 || GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.SPIRIT) == 2) {
                ShowText(player, type, doMsgs, "You've already chosen your gift.");
            }
            else {
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.SPIRIT, 1);
                ShowText(player, type, doMsgs, "The Spirit of a Warrior endows you with increased Strength.");
                ModAttribute(player, type, doMsgs, STRENGTH, 2);
            }
        }
        protected override void FnEvent23(TwPlayerServer player, MapEventType type, bool doMsgs) {
            FnEvent02(player, type, doMsgs);
            if (GetPartyCount(player, type, doMsgs) == 1) {
                ShowText(player, type, doMsgs, "You may rejoin your party.");
            }
            else {
                TeleportParty(player, type, doMsgs, 5, 3, 192, Direction.North);
            }
        }
        protected override void FnEvent24(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (UsedItem(player, type, ref doMsgs, LUMINOUSLANTERN, LUMINOUSLANTERN)) {
                WallClear(player, type, doMsgs);
                DoorHere(player, type, doMsgs);
                ShowText(player, type, doMsgs, "The Luminous Lantern glows feebly for a few moments.");
                ShowText(player, type, doMsgs, "You barely detect a rusty bolt that locks the mildewed door.");
                ShowText(player, type, doMsgs, "A moment later, the bolt is thrown and the door is open.");
            }
            else {
                WallBlock(player, type, doMsgs);
                ShowText(player, type, doMsgs, "A locked door bars your way. Perhaps if you had a bit of light you could determine the cause.");
            }
        }
        protected override void FnEvent25(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "A large sign warns -");
            ShowText(player, type, doMsgs, "'DO NOT ENTER unless you have all four map pieces or have completed the Queen's map quest. Proceed through this door alone and rejoin your party on the other side.'");
            if (GetPartyCount(player, type, doMsgs) == 1) {
                if ((HasItem(player, type, doMsgs, PARCHMENTMAP) && HasItem(player, type, doMsgs, SNAKESKINMAP) && HasItem(player, type, doMsgs, LEATHERMAP) && HasItem(player, type, doMsgs, SLATEMAP)) || (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.PATHWAYDONE) == 1)) {
                    WallClear(player, type, doMsgs);
                    DoorHere(player, type, doMsgs);
                }
            }
            else {
                WallBlock(player, type, doMsgs);
                ShowText(player, type, doMsgs, "Your entry is barred.");
            }
        }
        protected override void FnEvent26(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, GREMLINCLERIC);
            ShowText(player, type, doMsgs, "'Word has it that pieces of the map are scattered throughout the levels of the dungeon.'");
        }
        protected override void FnEvent27(TwPlayerServer player, MapEventType type, bool doMsgs) {
            FnEvent02(player, type, doMsgs);
            ShowText(player, type, doMsgs, "A haunted voice quavers -");
            ShowText(player, type, doMsgs, "'The Spirit to the East will offer the gift of increased Defense.'");
        }
        protected override void FnEvent28(TwPlayerServer player, MapEventType type, bool doMsgs) {
            FnEvent02(player, type, doMsgs);
            ShowPortrait(player, type, doMsgs, WRAITH);
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.SPIRIT) == 1 || GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.SPIRIT) == 2) {
                ShowText(player, type, doMsgs, "You've already chosen your gift.");
            }
            else {
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.SPIRIT, 1);
                ShowText(player, type, doMsgs, "The Spirit of a Guard endows you with increased Defense.");
                ModAttribute(player, type, doMsgs, DEFENSE, 2);
            }
        }
        protected override void FnEvent29(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, DWARFKNIGHT);
            ShowText(player, type, doMsgs, "'Trust the wrong thief with your goods and you may end up here permanently.'");
        }
        protected override void FnEvent2A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            FnEvent02(player, type, doMsgs);
            ShowText(player, type, doMsgs, "A distant wraith wails -");
            ShowText(player, type, doMsgs, "'The Spirit to the East blesses with the gift of increased Agility.'");
        }
        protected override void FnEvent2B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            FnEvent02(player, type, doMsgs);
            ShowPortrait(player, type, doMsgs, WRAITH);
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.SPIRIT) == 1 || GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.SPIRIT) == 2) {
                ShowText(player, type, doMsgs, "You've already chosen your gift.");
            }
            else {
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.SPIRIT, 1);
                ShowText(player, type, doMsgs, "The Spirit of an Athlete endows you with increased Agility.");
                ModAttribute(player, type, doMsgs, AGILITY, 2);
            }
        }
        protected override void FnEvent2C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            FnEvent02(player, type, doMsgs);
            ShowText(player, type, doMsgs, "The ground gives way and you slide into The Crypt.");
            TeleportParty(player, type, doMsgs, 6, 1, 221, Direction.South);
        }
        protected override void FnEvent2D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HasItem(player, type, doMsgs, SKELETONKEY)) {
                ShowText(player, type, doMsgs, "As you approach the portal to the Cartography Shop, your Skeleton Key tumbles to the ground and is lost in the mud.");
                RemoveItem(player, type, doMsgs, SKELETONKEY);
                TeleportParty(player, type, doMsgs, 5, 2, 247, Direction.North);
            }
            else {
                ShowText(player, type, doMsgs, "The portal marks the entrance to the Cartography Shop.");
                TeleportParty(player, type, doMsgs, 5, 2, 247, Direction.North);
            }
        }
        protected override void FnEvent2E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            FnEvent02(player, type, doMsgs);
            ShowText(player, type, doMsgs, "A nearby owl hoots -");
            ShowText(player, type, doMsgs, "'The Spirit to the East can give you a gift that increases Initiative.'");
        }
        protected override void FnEvent2F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            FnEvent02(player, type, doMsgs);
            ShowPortrait(player, type, doMsgs, WRAITH);
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.SPIRIT) == 1 || GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.SPIRIT) == 2) {
                ShowText(player, type, doMsgs, "You've already chosen your gift.");
            }
            else {
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.SPIRIT, 1);
                ShowText(player, type, doMsgs, "The Spirit of a Cavalier endows you with increased Initiative.");
                ModAttribute(player, type, doMsgs, INITIATIVE, 2);
            }
        }
        protected override void FnEvent30(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You blink as you see a shadowy figure seemingly walking through a solid wall.");
            FnEvent02(player, type, doMsgs);
        }
        protected override void FnEvent31(TwPlayerServer player, MapEventType type, bool doMsgs) {
            FnEvent02(player, type, doMsgs);
            ShowPortrait(player, type, doMsgs, FOUNTAIN);
            ModifyHealth(player, type, doMsgs, GetHealthMax(player, type, doMsgs));
            ShowText(player, type, doMsgs, "The waters of Twilight Fountain heal your wounds.");
        }
        protected override void FnEvent32(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 38);
                AddEncounter(player, type, doMsgs, 05, 39);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 20);
                AddEncounter(player, type, doMsgs, 02, 21);
                AddEncounter(player, type, doMsgs, 05, 38);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 36);
                AddEncounter(player, type, doMsgs, 02, 40);
                AddEncounter(player, type, doMsgs, 03, 38);
                AddEncounter(player, type, doMsgs, 04, 38);
            }
        }
        protected override void FnEvent33(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 23);
                AddEncounter(player, type, doMsgs, 05, 29);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 24);
                AddEncounter(player, type, doMsgs, 02, 24);
                AddEncounter(player, type, doMsgs, 04, 18);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 23);
                AddEncounter(player, type, doMsgs, 02, 40);
                AddEncounter(player, type, doMsgs, 03, 18);
                AddEncounter(player, type, doMsgs, 04, 16);
            }
        }
        protected override void FnEvent34(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 1);
                AddEncounter(player, type, doMsgs, 02, 34);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 3);
                AddEncounter(player, type, doMsgs, 02, 5);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 3);
                AddEncounter(player, type, doMsgs, 02, 4);
                AddEncounter(player, type, doMsgs, 05, 26);
                AddEncounter(player, type, doMsgs, 06, 26);
            }
        }
        protected override void FnEvent35(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1 || GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 6);
                AddEncounter(player, type, doMsgs, 02, 12);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 7);
                AddEncounter(player, type, doMsgs, 02, 6);
                AddEncounter(player, type, doMsgs, 03, 13);
                AddEncounter(player, type, doMsgs, 04, 10);
            }
        }
        protected override void FnEvent36(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 20);
                AddEncounter(player, type, doMsgs, 02, 39);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 24);
                AddEncounter(player, type, doMsgs, 02, 23);
                AddEncounter(player, type, doMsgs, 05, 39);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 24);
                AddEncounter(player, type, doMsgs, 02, 23);
                AddEncounter(player, type, doMsgs, 03, 36);
                AddEncounter(player, type, doMsgs, 04, 20);
                AddEncounter(player, type, doMsgs, 05, 32);
            }
        }
        protected override void FnEvent37(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You hear the sound of looting somewhere nearby.");
        }
        private void WallClear(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
        }
        private void WallBlock(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
        }
        private void DoorHere(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetWallItem(player, type, doMsgs, DOOR, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
        }
        protected override void FnEvent38(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.SPIRIT) == 1) {
                ShowText(player, type, doMsgs, "A luminescent message magically appears on the door.");
                ShowText(player, type, doMsgs, "'You have discovered the secret of the spirits and have received their blessing! Continue your search, champion. The graveyard offers passages to the clever.'");
            }
        }
        protected override void FnEvent39(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.SPIRIT) == 0)) {
                ShowPortrait(player, type, doMsgs, TROLLKNIGHT);
                ShowText(player, type, doMsgs, "'Ah, I see you haven't been blessed by the spirits yet!");
                ShowText(player, type, doMsgs, "Walk cautiously, my friend. The graveyard is as dangerous as it is rewarding. The benevolent spirits await thee!'");
            }
        }
    }
}
