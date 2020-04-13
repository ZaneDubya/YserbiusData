using XPT.Games.Generic.Constants;
using XPT.Games.Generic.Maps;
using XPT.Games.Twinion.Entities;

namespace XPT.Games.Twinion.Maps {
    /// <summary>
    /// L3: The Coliseum
    /// </summary>
    class TwMap06 : TwMap {
        public override int MapIndex => 6;
        public override int MapID => 0x0301;
        protected override int RandomEncounterChance => 5;
        protected override int RandomEncounterExtraCount => 2;

        protected override void FnEvent01(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetTileBlock(player, type, doMsgs, GetTile(player, type, doMsgs));
        }
        protected override void FnEvent02(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "To the first Arena.");
            TeleportParty(player, type, doMsgs, 3, 1, 15, Direction.South);
        }
        protected override void FnEvent03(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "To the second Arena.");
            TeleportParty(player, type, doMsgs, 3, 1, 0, Direction.East);
        }
        protected override void FnEvent04(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "To the third Arena.");
            TeleportParty(player, type, doMsgs, 3, 1, 208, Direction.East);
        }
        protected override void FnEvent05(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "To the fourth Arena.");
            TeleportParty(player, type, doMsgs, 3, 1, 207, Direction.South);
        }
        protected override void FnEvent06(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "To the way out.");
            TeleportParty(player, type, doMsgs, 3, 1, 124, Direction.South);
        }
        protected override void FnEvent07(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "This leads to the Queen's Palace.");
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.TOTAL) < 4) {
                ShowText(player, type, doMsgs, "There are more Arenas to complete when you feel ready. You may proceed now.");
            }
            TeleportParty(player, type, doMsgs, 3, 2, 128, Direction.East);
        }
        protected override void FnEvent08(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetGuild(player, type, doMsgs) != THIEF) {
                if (GetAttribute(player, type, doMsgs, STRENGTH) >= 18) {
                    ShowText(player, type, doMsgs, "You're strong enough to move the column and get around it.");
                    FnEvent27(player, type, doMsgs);
                }
                else {
                    SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                }
            }
            else {
                ShowText(player, type, doMsgs, "Your abilities will allow you to squeeze through a narrow gap between the columns.");
                FnEvent27(player, type, doMsgs);
            }
        }
        protected override void FnEvent09(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetGuild(player, type, doMsgs) == WIZARD || GetGuild(player, type, doMsgs) == CLERIC) {
                ShowText(player, type, doMsgs, "Blessed are the Magi! For your wisdom is obvious; this magical pillar slides away allowing you to pass.");
                FnEvent28(player, type, doMsgs);
            }
            else if (GetGuild(player, type, doMsgs) == THIEF) {
                ShowText(player, type, doMsgs, "Your abilities will allow you to squeeze through a narrow gap between the columns.");
                FnEvent28(player, type, doMsgs);
            }
            else {
                SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
            }
        }
        protected override void FnEvent0A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You plummet to your death!");
            DoDamage(player, type, doMsgs, GetHealthMax(player, type, doMsgs));
        }
        protected override void FnEvent0B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int tally = 0;
            int exps = 0;
            tally = GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.QUADRANTA) + GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.QUADRANTB) + GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.QUADRANTC) + GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.QUADRANTD);
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.TOTAL) < tally) {
                ShowText(player, type, doMsgs, "Well done! Proceed to the exit. The end of these Proving Grounds is near!");
                switch (tally) {
                    case 1:
                        exps = 15000;
                        break;
                    case 2:
                        exps = 15000;
                        break;
                    case 3:
                        exps = 15000;
                        break;
                    case 4:
                        exps = 15000;
                        break;
                }
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.TOTAL, tally);
                ModifyExperience(player, type, doMsgs, exps);
                ClearDoor(player, type, doMsgs);
                ShowText(player, type, doMsgs, "Your accomplishment deserves the attributed reward. This experience will aid you in reaching the next level.");
            }
            else if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.TOTAL) == tally && GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.TOTAL) < 4) {
                ClearDoor(player, type, doMsgs);
                ShowText(player, type, doMsgs, "There are more Arenas to complete when you feel ready. You may proceed now.");
            }
            else {
                ClearDoor(player, type, doMsgs);
                ShowText(player, type, doMsgs, "There's nothing more for you here.");
            }
        }
        private void ClearDoor(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
            SetWallItem(player, type, doMsgs, DOOR, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
        }
        protected override void FnEvent0C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int i = 0;
            ShowText(player, type, doMsgs, "Magi hurl spells at you!");
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 39);
                AddEncounter(player, type, doMsgs, 05, 40);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 39);
                AddEncounter(player, type, doMsgs, 02, 39);
                AddEncounter(player, type, doMsgs, 05, 40);
            }
            else if (GetPartyCount(player, type, doMsgs) == 3) {
                for (i = 1; i <= 3; i++) {
                    AddEncounter(player, type, doMsgs, i, 39);
                }
                for (i = 5; i <= 6; i++) {
                    AddEncounter(player, type, doMsgs, i, 40);
                }
            }
            else {
                for (i = 1; i <= 3; i++) {
                    AddEncounter(player, type, doMsgs, i, 39);
                }
                for (i = 4; i <= 6; i++) {
                    AddEncounter(player, type, doMsgs, i, 40);
                }
            }
        }
        protected override void FnEvent0D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int i = 0;
            ShowText(player, type, doMsgs, "Arrows rain down upon you from an attacking party of Archers.");
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 31);
                AddEncounter(player, type, doMsgs, 05, 32);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 31);
                AddEncounter(player, type, doMsgs, 02, 31);
                AddEncounter(player, type, doMsgs, 05, 32);
            }
            else if (GetPartyCount(player, type, doMsgs) == 3) {
                for (i = 1; i <= 2; i++) {
                    AddEncounter(player, type, doMsgs, i, 31);
                }
                for (i = 3; i <= 5; i++) {
                    AddEncounter(player, type, doMsgs, i, 32);
                }
            }
            else {
                for (i = 1; i <= 3; i++) {
                    AddEncounter(player, type, doMsgs, i, 32);
                }
                for (i = 4; i <= 6; i++) {
                    AddEncounter(player, type, doMsgs, i, 31);
                }
            }
        }
        protected override void FnEvent0E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Quarrelsome thieves charge you.");
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 35);
                AddEncounter(player, type, doMsgs, 05, 36);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 35);
                AddEncounter(player, type, doMsgs, 02, 36);
                AddEncounter(player, type, doMsgs, 05, 37);
            }
            else if (GetPartyCount(player, type, doMsgs) == 3) {
                AddEncounter(player, type, doMsgs, 01, 35);
                AddEncounter(player, type, doMsgs, 02, 35);
                AddEncounter(player, type, doMsgs, 03, 36);
                AddEncounter(player, type, doMsgs, 05, 37);
                AddEncounter(player, type, doMsgs, 06, 36);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 35);
                AddEncounter(player, type, doMsgs, 02, 35);
                AddEncounter(player, type, doMsgs, 03, 36);
                AddEncounter(player, type, doMsgs, 04, 36);
                AddEncounter(player, type, doMsgs, 05, 37);
                AddEncounter(player, type, doMsgs, 06, 37);
            }
        }
        protected override void FnEvent0F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.QUADRANTA) == 0)) {
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.QUADRANTA, 1);
            }
            ShowText(player, type, doMsgs, "A party of warriors intend to prevent you from completing this arena.");
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 30);
                AddEncounter(player, type, doMsgs, 05, 40);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 30);
                AddEncounter(player, type, doMsgs, 02, 28);
                AddEncounter(player, type, doMsgs, 05, 33);
            }
            else if (GetPartyCount(player, type, doMsgs) == 3) {
                AddEncounter(player, type, doMsgs, 01, 33);
                AddEncounter(player, type, doMsgs, 02, 29);
                AddEncounter(player, type, doMsgs, 03, 39);
                AddEncounter(player, type, doMsgs, 05, 40);
                AddEncounter(player, type, doMsgs, 06, 28);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 38);
                AddEncounter(player, type, doMsgs, 02, 39);
                AddEncounter(player, type, doMsgs, 03, 40);
                AddEncounter(player, type, doMsgs, 04, 33);
                AddEncounter(player, type, doMsgs, 05, 33);
                AddEncounter(player, type, doMsgs, 06, 33);
            }
        }
        protected override void FnEvent10(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, HUMANWIZARD);
            ShowText(player, type, doMsgs, "A nervous wizard chatters at you.");
            ShowText(player, type, doMsgs, "'There are so many of them. So many...");
            ShowText(player, type, doMsgs, "She said I would get great rewards for doing all four, but I know that only one would suffice.'");
        }
        protected override void FnEvent11(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Knights and their squires charge you.");
            int i = 0;
            switch (GetPartyCount(player, type, doMsgs)) {
                case 1:
                    AddEncounter(player, type, doMsgs, 01, 34);
                    AddEncounter(player, type, doMsgs, 05, 27);
                    break;
                case 2:
                    for (i = 1; i <= 3; i++) {
                        AddEncounter(player, type, doMsgs, i, 34);
                    }
                    break;
                default:
                    for (i = 1; i <= 3; i++) {
                        AddEncounter(player, type, doMsgs, i, 27);
                    }
                    for (i = 4; i <= 6; i++) {
                        AddEncounter(player, type, doMsgs, i, 34);
                    }
                    break;
            }
        }
        protected override void FnEvent12(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Gladiators and scavenging rogues take the offensive.");
            int i = 0;
            switch (GetPartyCount(player, type, doMsgs)) {
                case 1:
                    AddEncounter(player, type, doMsgs, 01, 25);
                    AddEncounter(player, type, doMsgs, 05, 25);
                    break;
                case 2:
                    for (i = 1; i <= 3; i++) {
                        AddEncounter(player, type, doMsgs, i, 26);
                    }
                    break;
                default:
                    for (i = 1; i <= 4; i++) {
                        AddEncounter(player, type, doMsgs, i, 25);
                    }
                    for (i = 5; i <= 6; i++) {
                        AddEncounter(player, type, doMsgs, i, 26);
                    }
                    break;
            }
        }
        protected override void FnEvent13(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "A hulking colossus towers over you.");
            int i = 0;
            switch (GetPartyCount(player, type, doMsgs)) {
                case 1:
                    AddEncounter(player, type, doMsgs, 01, 38);
                    break;
                case 2:
                    for (i = 1; i <= 2; i++) {
                        AddEncounter(player, type, doMsgs, i, 38);
                    }
                    break;
                default:
                    for (i = 1; i <= 4; i++) {
                        AddEncounter(player, type, doMsgs, i, 38);
                    }
                    break;
            }
        }
        protected override void FnEvent14(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.QUADRANTB) == 0)) {
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.QUADRANTB, 1);
            }
            ShowText(player, type, doMsgs, "An odd array of mage and muscle stands before you.");
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 38);
                AddEncounter(player, type, doMsgs, 05, 40);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 38);
                AddEncounter(player, type, doMsgs, 02, 39);
                AddEncounter(player, type, doMsgs, 05, 40);
            }
            else if (GetPartyCount(player, type, doMsgs) == 3) {
                AddEncounter(player, type, doMsgs, 01, 38);
                AddEncounter(player, type, doMsgs, 02, 38);
                AddEncounter(player, type, doMsgs, 03, 39);
                AddEncounter(player, type, doMsgs, 05, 40);
                AddEncounter(player, type, doMsgs, 06, 40);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 38);
                AddEncounter(player, type, doMsgs, 02, 38);
                AddEncounter(player, type, doMsgs, 03, 40);
                AddEncounter(player, type, doMsgs, 04, 40);
                AddEncounter(player, type, doMsgs, 05, 39);
                AddEncounter(player, type, doMsgs, 06, 39);
            }
        }
        protected override void FnEvent15(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "A roster listing various guilds and names is posted here. Hmmm..your name does not appear on the list!");
        }
        protected override void FnEvent16(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 29);
                AddEncounter(player, type, doMsgs, 05, 32);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 29);
                AddEncounter(player, type, doMsgs, 02, 32);
                AddEncounter(player, type, doMsgs, 05, 34);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 29);
                AddEncounter(player, type, doMsgs, 02, 32);
                AddEncounter(player, type, doMsgs, 03, 34);
                AddEncounter(player, type, doMsgs, 04, 39);
            }
        }
        protected override void FnEvent17(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Warring gladiators challenge you.");
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 3);
                AddEncounter(player, type, doMsgs, 05, 26);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 3);
                AddEncounter(player, type, doMsgs, 02, 3);
                AddEncounter(player, type, doMsgs, 05, 26);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 26);
                AddEncounter(player, type, doMsgs, 02, 3);
                AddEncounter(player, type, doMsgs, 03, 3);
                AddEncounter(player, type, doMsgs, 04, 26);
                AddEncounter(player, type, doMsgs, 05, 26);
                AddEncounter(player, type, doMsgs, 06, 3);
            }
        }
        protected override void FnEvent18(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Swords and sorcery are unleashed against you.");
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 4);
                AddEncounter(player, type, doMsgs, 05, 7);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 4);
                AddEncounter(player, type, doMsgs, 02, 7);
                AddEncounter(player, type, doMsgs, 05, 7);
            }
            else if (GetPartyCount(player, type, doMsgs) == 3) {
                AddEncounter(player, type, doMsgs, 01, 4);
                AddEncounter(player, type, doMsgs, 02, 4);
                AddEncounter(player, type, doMsgs, 03, 7);
                AddEncounter(player, type, doMsgs, 05, 7);
                AddEncounter(player, type, doMsgs, 06, 7);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 4);
                AddEncounter(player, type, doMsgs, 02, 4);
                AddEncounter(player, type, doMsgs, 03, 4);
                AddEncounter(player, type, doMsgs, 04, 4);
                AddEncounter(player, type, doMsgs, 05, 7);
                AddEncounter(player, type, doMsgs, 06, 7);
            }
        }
        protected override void FnEvent19(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.QUADRANTC) == 0)) {
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.QUADRANTC, 1);
            }
            ShowText(player, type, doMsgs, "The air is filled with bursts of magic as a party of enchanters attacks.");
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 16);
                AddEncounter(player, type, doMsgs, 05, 20);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 16);
                AddEncounter(player, type, doMsgs, 02, 20);
                AddEncounter(player, type, doMsgs, 05, 23);
            }
            else if (GetPartyCount(player, type, doMsgs) == 3) {
                AddEncounter(player, type, doMsgs, 01, 16);
                AddEncounter(player, type, doMsgs, 02, 23);
                AddEncounter(player, type, doMsgs, 03, 20);
                AddEncounter(player, type, doMsgs, 05, 23);
                AddEncounter(player, type, doMsgs, 06, 16);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 16);
                AddEncounter(player, type, doMsgs, 02, 16);
                AddEncounter(player, type, doMsgs, 03, 23);
                AddEncounter(player, type, doMsgs, 04, 23);
                AddEncounter(player, type, doMsgs, 05, 20);
                AddEncounter(player, type, doMsgs, 06, 20);
            }
        }
        protected override void FnEvent1A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Undead magi encircle you!");
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 17);
                AddEncounter(player, type, doMsgs, 05, 17);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 17);
                AddEncounter(player, type, doMsgs, 02, 19);
                AddEncounter(player, type, doMsgs, 05, 19);
            }
            else if (GetPartyCount(player, type, doMsgs) == 3) {
                AddEncounter(player, type, doMsgs, 01, 17);
                AddEncounter(player, type, doMsgs, 02, 17);
                AddEncounter(player, type, doMsgs, 03, 19);
                AddEncounter(player, type, doMsgs, 05, 19);
                AddEncounter(player, type, doMsgs, 06, 19);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 17);
                AddEncounter(player, type, doMsgs, 02, 17);
                AddEncounter(player, type, doMsgs, 03, 19);
                AddEncounter(player, type, doMsgs, 04, 19);
                AddEncounter(player, type, doMsgs, 05, 17);
                AddEncounter(player, type, doMsgs, 06, 19);
            }
        }
        protected override void FnEvent1B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int i = 0;
            ShowText(player, type, doMsgs, "Spirits of magi and bones of thieves charge you.");
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 21);
                AddEncounter(player, type, doMsgs, 05, 13);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 13);
                AddEncounter(player, type, doMsgs, 02, 21);
                AddEncounter(player, type, doMsgs, 05, 13);
            }
            else if (GetPartyCount(player, type, doMsgs) == 3) {
                for (i = 1; i <= 3; i++) {
                    AddEncounter(player, type, doMsgs, i, 13);
                }
                for (i = 5; i <= 6; i++) {
                    AddEncounter(player, type, doMsgs, i, 21);
                }
            }
            else {
                for (i = 1; i <= 3; i++) {
                    AddEncounter(player, type, doMsgs, i, 13);
                }
                for (i = 4; i <= 6; i++) {
                    AddEncounter(player, type, doMsgs, i, 21);
                }
            }
        }
        protected override void FnEvent1C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Long dead gladiators rise from the dust to attack you!");
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 11);
                AddEncounter(player, type, doMsgs, 05, 11);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 11);
                AddEncounter(player, type, doMsgs, 02, 9);
                AddEncounter(player, type, doMsgs, 05, 9);
            }
            else if (GetPartyCount(player, type, doMsgs) == 3) {
                AddEncounter(player, type, doMsgs, 01, 11);
                AddEncounter(player, type, doMsgs, 02, 11);
                AddEncounter(player, type, doMsgs, 03, 9);
                AddEncounter(player, type, doMsgs, 05, 11);
                AddEncounter(player, type, doMsgs, 06, 9);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 9);
                AddEncounter(player, type, doMsgs, 02, 9);
                AddEncounter(player, type, doMsgs, 03, 11);
                AddEncounter(player, type, doMsgs, 04, 11);
                AddEncounter(player, type, doMsgs, 05, 9);
                AddEncounter(player, type, doMsgs, 06, 11);
            }
        }
        protected override void FnEvent1D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.QUADRANTD) == 0)) {
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.QUADRANTD, 1);
            }
            ShowText(player, type, doMsgs, "Assorted undead heroes challenge you at this exit.");
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 9);
                AddEncounter(player, type, doMsgs, 05, 11);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 9);
                AddEncounter(player, type, doMsgs, 02, 11);
                AddEncounter(player, type, doMsgs, 05, 21);
            }
            else if (GetPartyCount(player, type, doMsgs) == 3) {
                AddEncounter(player, type, doMsgs, 01, 9);
                AddEncounter(player, type, doMsgs, 02, 13);
                AddEncounter(player, type, doMsgs, 03, 17);
                AddEncounter(player, type, doMsgs, 05, 21);
                AddEncounter(player, type, doMsgs, 06, 21);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 9);
                AddEncounter(player, type, doMsgs, 02, 11);
                AddEncounter(player, type, doMsgs, 03, 13);
                AddEncounter(player, type, doMsgs, 04, 17);
                AddEncounter(player, type, doMsgs, 05, 21);
                AddEncounter(player, type, doMsgs, 06, 21);
            }
        }
        protected override void FnEvent1E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int time = 0;
            SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.ARENASTASHA, 1);
            time = GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.ARENASTASHA) + GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.ARENASTASHB) + GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.ARENASTASHC) + GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.ARENASTASHD);
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.ITEMTOTAL) < time) {
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.ITEMTOTAL, time);
                SwitchCase(player, type, doMsgs);
            }
        }
        protected override void FnEvent1F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int time = 0;
            SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.ARENASTASHB, 1);
            time = GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.ARENASTASHA) + GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.ARENASTASHB) + GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.ARENASTASHC) + GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.ARENASTASHD);
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.ITEMTOTAL) < time) {
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.ITEMTOTAL, time);
                SwitchCase(player, type, doMsgs);
            }
        }
        protected override void FnEvent20(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int time = 0;
            SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.ARENASTASHC, 1);
            time = GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.ARENASTASHA) + GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.ARENASTASHB) + GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.ARENASTASHC) + GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.ARENASTASHD);
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.ITEMTOTAL) < time) {
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.ITEMTOTAL, time);
                SwitchCase(player, type, doMsgs);
            }
        }
        private void SwitchCase(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int ItemA = 0;
            int ItemB = 0;
            int ItemC = 0;
            int ItemD = 0;
            int gold = 0;
            int time = 0;
            time = GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.ITEMTOTAL);
            switch (time) {
                case 1:
                    ItemA = MANAELIXIR;
                    ItemB = BRONZEBATTLEAXE;
                    ItemC = WARHAT;
                    ItemD = GOLDBAR;
                    gold = 500;
                    break;
                case 2:
                    ItemA = ELIXIROFHEALTH;
                    ItemB = NINJASTICKS;
                    ItemC = HEADCHAINMAIL;
                    ItemD = BINDINGTALISMAN;
                    gold = 600;
                    break;
                case 3:
                    ItemA = FROSTBLADE;
                    ItemB = SCRIBESSALLET;
                    ItemC = SLIVERBAR;
                    ItemD = BREASTPLATE;
                    gold = 700;
                    break;
                case 4:
                    ItemA = MORNINGSTAR;
                    ItemB = SACKCLOTHJACKET;
                    ItemC = READTRACKSTALISMAN;
                    ItemD = CRYSTALBALL;
                    gold = 800;
                    break;
            }
            ShowText(player, type, doMsgs, "You find some useful items.");
            GiveItem(player, type, doMsgs, ItemA);
            GiveItem(player, type, doMsgs, ItemB);
            GiveItem(player, type, doMsgs, ItemC);
            GiveItem(player, type, doMsgs, ItemD);
            ModifyGold(player, type, doMsgs, gold);
        }
        protected override void FnEvent21(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int time = 0;
            SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.ARENASTASHD, 1);
            time = GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.ARENASTASHA) + GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.ARENASTASHB) + GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.ARENASTASHC) + GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.ARENASTASHD);
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.ITEMTOTAL) < time) {
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.ITEMTOTAL, time);
                SwitchCase(player, type, doMsgs);
            }
        }
        protected override void FnEvent22(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "The sounds of distant combats echo off the surrounding pillars as you enter the first Arena.");
        }
        protected override void FnEvent23(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Snarls from giants and orcish grunts greet you here in the second Arena.");
        }
        protected override void FnEvent24(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Bursts of magic light momentarily limn the silhouettes of the combatants in this third Arena.");
        }
        protected override void FnEvent25(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Anguished howls and death wails greet the wary visitor to this fourth Arena.");
        }
        protected override void FnEvent26(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "The huge columns of this room act more as barriers than supports.");
            ShowText(player, type, doMsgs, "Through the gaps between columns you see bloody combats in what appear to be four different Arenas.");
        }
        protected override void FnEvent27(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ClearTileBlock(player, type, doMsgs, 139);
            ClearTileBlock(player, type, doMsgs, 186);
            ClearTileBlock(player, type, doMsgs, 199);
            ClearTileBlock(player, type, doMsgs, 233);
            ClearTileBlock(player, type, doMsgs, 176);
            ClearTileBlock(player, type, doMsgs, 131);
            ClearTileBlock(player, type, doMsgs, 64);
            ClearTileBlock(player, type, doMsgs, 38);
            ClearTileBlock(player, type, doMsgs, 56);
        }
        protected override void FnEvent28(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ClearTileBlock(player, type, doMsgs, 246);
            ClearTileBlock(player, type, doMsgs, 200);
            ClearTileBlock(player, type, doMsgs, 155);
            ClearTileBlock(player, type, doMsgs, 75);
            ClearTileBlock(player, type, doMsgs, 25);
            ClearTileBlock(player, type, doMsgs, 101);
            ClearTileBlock(player, type, doMsgs, 73);
        }
        protected override void FnEvent29(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetGuild(player, type, doMsgs) == RANGER) && ((GetSkill(player, type, doMsgs, REVERIE_SKILL) == 0))) {
                SetSkill(player, type, doMsgs, REVERIE_SKILL, 1);
                Fountain(player, type, doMsgs);
            }
            else if ((GetGuild(player, type, doMsgs) == THIEF) && ((GetSkill(player, type, doMsgs, REVERIE_SKILL) == 0))) {
                SetSkill(player, type, doMsgs, REVERIE_SKILL, 1);
                Fountain(player, type, doMsgs);
            }
            else {
                NoFount(player, type, doMsgs);
            }
        }
        private void Fountain(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, FOUNTAIN);
            ShowText(player, type, doMsgs, "A bubbling fountain offers knowledge and refreshment.");
            ModifyHealth(player, type, doMsgs, GetHealthMax(player, type, doMsgs) / 4);
        }
        private void NoFount(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, FOUNTAIN);
            ShowText(player, type, doMsgs, "The waters offer you refreshment, but nothing more.");
        }
        protected override void FnEvent2A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetGuild(player, type, doMsgs) == WIZARD || GetGuild(player, type, doMsgs) == CLERIC) {
                if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.WIZFOUNTAIN) == 0)) {
                    GiveSpell(player, type, doMsgs, HAIL_SPELL, 1);
                    Fountain(player, type, doMsgs);
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.WIZFOUNTAIN, 1);
                }
            }
            else {
                NoFount(player, type, doMsgs);
            }
        }
        protected override void FnEvent2B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetGuild(player, type, doMsgs) == CLERIC) && ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.CLERICBACK) == 0))) {
                GiveSpell(player, type, doMsgs, BACKFIRE_SPELL, 1);
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.CLERICBACK, 1);
                Fountain(player, type, doMsgs);
            }
            else {
                NoFount(player, type, doMsgs);
            }
        }
        protected override void FnEvent2C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.TOTAL) < 4) {
                ShowText(player, type, doMsgs, "There are more Arenas to complete when you feel ready. You may proceed for now.");
            }
            else {
                ShowText(player, type, doMsgs, "There's nothing more for you here.");
            }
        }
        protected override void FnEvent2D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
        }
        protected override void FnEvent2E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Markings here read- 'One way! To The Queen's Aqueduct.'");
            TeleportParty(player, type, doMsgs, 2, 1, 5, Direction.South);
        }
        protected override void FnEvent2F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "One way! Back to the Coliseum's Core.");
            TeleportParty(player, type, doMsgs, 3, 1, 136, Direction.South);
        }
    }
}
