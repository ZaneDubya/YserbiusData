using XPT.Games.Generic.Constants;
using XPT.Games.Generic.Maps;
using XPT.Games.Twinion.Entities;

namespace XPT.Games.Twinion.Maps {
    /// <summary>
    /// L2: Twinion's Falls
    /// </summary>
    class TwMap04 : TwMap {
        public override int MapIndex => 4;
        public override int MapID => 0x0202;
        protected override int RandomEncounterChance => 12;
        protected override int RandomEncounterExtraCount => 1;

        private const int METGUARD = 1;
        private const int HALFTHIEF = 2;
        private const int WESTSIDE = 3;
        private const int EASTSIDE = 4;
        private const int GOODBOOTY = 7;
        private const int IRONSWORD = 8;
        private const int CLUBIT = 9;
        private const int FIGHT25 = 10;
        private const int METCLERIC = 11;
        private const int SPRUNGTRAP = 1;
        private void WallBlock(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
        }
        protected override void FnEvent01(TwPlayerServer player, MapEventType type, bool doMsgs) {
            DisableHealing(player, type, doMsgs);
            if ((GetFlag(player, type, doMsgs, FlagTypeTile, SPRUNGTRAP) == 0)) {
                if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.KILLEDAQUEUS) == 0)) {
                    ShowText(player, type, doMsgs, "The rushing waters pummel your body.");
                    DoDamage(player, type, doMsgs, GetHealthMax(player, type, doMsgs) / 8 + 1);
                    if (GetHealthCurrent(player, type, doMsgs) <= 0) {
                        ShowText(player, type, doMsgs, "You have been drowned by the force.");
                    }
                }
                else {
                    ShowText(player, type, doMsgs, "You've defeated Aqueus! You may travel safely through these waters now.");
                }
                SetFlag(player, type, doMsgs, FlagTypeTile, SPRUNGTRAP, 1);
            }
        }
        private void SpringTrap(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetFlag(player, type, doMsgs, FlagTypeTile, SPRUNGTRAP, 1);
        }
        protected override void FnEvent02(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "The magical force of the pump propels you southeastward and slams you squarely into a wall.");
            DoDamage(player, type, doMsgs, GetHealthCurrent(player, type, doMsgs) / 2);
            TeleportParty(player, type, doMsgs, 2, 2, 170, Direction.East);
        }
        protected override void FnEvent03(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetTileBlock(player, type, doMsgs, GetTile(player, type, doMsgs));
        }
        protected override void FnEvent04(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "To the other shore...");
            TeleportParty(player, type, doMsgs, 2, 2, 189, Direction.East);
        }
        protected override void FnEvent05(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Closer and closer you go.");
            TeleportParty(player, type, doMsgs, 2, 2, 3, Direction.East);
        }
        protected override void FnEvent06(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetTile(player, type, doMsgs) == 53) && ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.DIDPATH) == 0) || GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.DIDPATH) == 1)) {
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.DIDPATH, 2);
                ModifyExperience(player, type, doMsgs, 2000);
                ModifyGold(player, type, doMsgs, 1200);
                ShowText(player, type, doMsgs, "Take this experience and these coins to aid thee in thy travels!");
            }
            ShowText(player, type, doMsgs, "And yet one step further along the path.");
            TeleportParty(player, type, doMsgs, 2, 2, 224, Direction.East);
        }
        protected override void FnEvent07(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Westward takes you back to the main Aqueduct.");
            TeleportParty(player, type, doMsgs, 2, 1, 255, Direction.West);
        }
        protected override void FnEvent08(TwPlayerServer player, MapEventType type, bool doMsgs) {
            WallBlock(player, type, doMsgs);
            ShowPortrait(player, type, doMsgs, DWARFKNIGHT);
            ShowText(player, type, doMsgs, "A magical wall bars you from moving any closer to the prisoner in the southern cell.");
        }
        protected override void FnEvent09(TwPlayerServer player, MapEventType type, bool doMsgs) {
            WallBlock(player, type, doMsgs);
            ShowPortrait(player, type, doMsgs, TROLLRANGER);
            ShowText(player, type, doMsgs, "A mystical force prevents access southward to another prisoner in the Aqueduct's cells.");
        }
        protected override void FnEvent0A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            WallBlock(player, type, doMsgs);
            ShowPortrait(player, type, doMsgs, COELUS);
            ShowText(player, type, doMsgs, "A hulking beast is imprisoned southward behind some unseen forces of magic.");
        }
        protected override void FnEvent0B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            WallBlock(player, type, doMsgs);
            ShowText(player, type, doMsgs, "An unseen force holds you back.");
        }
        protected override void FnEvent0C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "BEHOLD: This tower was built by Queen Aeowyn to control the force of the Aqueduct as it leaves this place. Hail her Royal Highness!");
        }
        protected override void FnEvent0D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "This path leads back whence you came.");
            TeleportParty(player, type, doMsgs, 2, 1, 175, Direction.West);
        }
        protected override void FnEvent0E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Do not forsake your loyal friends.");
            ShowText(player, type, doMsgs, "WARNING: DO NOT READ THIS SIGN!");
        }
        protected override void FnEvent0F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "For true friendship can bridge time...");
            ShowText(player, type, doMsgs, "I'M TELLING YOU - STOP READING THIS!");
        }
        protected override void FnEvent10(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Personal sacrifice will send your friends forward.");
            ShowText(player, type, doMsgs, "I CAN'T BELIEVE YOU DON'T LISTEN TO ME!");
            ShowText(player, type, doMsgs, "Obviously some vandalish rogues have been at these signs.");
        }
        protected override void FnEvent11(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Well done!  Westward now and hurry. You're almost to the end of the Proving Grounds!");
            if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.DIDPATH) == 0)) {
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.DIDPATH, 1);
            }
        }
        protected override void FnEvent12(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.CROSSBRIDGE) == 1) {
                ClearTileBlock(player, type, doMsgs, 142);
                ClearTileBlock(player, type, doMsgs, 126);
                ClearTileBlock(player, type, doMsgs, 158);
                SetFloorItem(player, type, doMsgs, 1, 142);
                SetFloorItem(player, type, doMsgs, 1, 126);
                SetFloorItem(player, type, doMsgs, 1, 158);
                ShowText(player, type, doMsgs, "You stand midway between the two watch towers. The view really is quite magnificent.");
                ShowText(player, type, doMsgs, "Invisible forces keep you from falling off the bridge into the icy waters below.");
                SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.West);
                SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.East);
            }
            else {
                ShowText(player, type, doMsgs, "You stand directly below a narrow bridge that spans the Aqueduct. Eastward is a great waterfall that pours from the side of the volcano.");
            }
        }
        protected override void FnEvent13(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "This majestic meeting hall bustles with commerce.");
            ShowText(player, type, doMsgs, "The walls reverberate with the din of haggling and betrayal.");
        }
        protected override void FnEvent14(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "None of the merchants wishes to deal with you.");
            ShowText(player, type, doMsgs, "Perhaps another time, when you have items worth their interest.");
        }
        protected override void FnEvent15(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (UsedItem(player, type, ref doMsgs, CROSSKEY, CROSSKEY)) {
                ShowText(player, type, doMsgs, "The Cross Key easily unlocks the door.");
                ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                SetWallItem(player, type, doMsgs, DOOR, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
            }
            else {
                ShowText(player, type, doMsgs, "A strange keyhole, marked with an X, obviously suggests that a special key is needed to unlock this door.");
            }
        }
        protected override void FnEvent16(TwPlayerServer player, MapEventType type, bool doMsgs) {
            DisablePartyJoining(player, type, doMsgs);
            if (GetFlag(player, type, doMsgs, FlagTypeParty, METGUARD) == 0) {
                ShowPortrait(player, type, doMsgs, DWARFKNIGHT);
                ShowText(player, type, doMsgs, "One of the Queen's Guard is here.");
                ShowText(player, type, doMsgs, "'Away with you.  I have no time to waste with the likes of you.'");
                SetFlag(player, type, doMsgs, FlagTypeParty, METGUARD, 1);
            }
            else if (GetFlag(player, type, doMsgs, FlagTypeParty, METGUARD) == 1) {
                ShowPortrait(player, type, doMsgs, DWARFKNIGHT);
                ShowText(player, type, doMsgs, "The guard is still here.");
                ShowText(player, type, doMsgs, "'What now?  Stop bothering me or I shall be forced to remove you.'");
                SetFlag(player, type, doMsgs, FlagTypeParty, METGUARD, 2);
            }
            else if (GetFlag(player, type, doMsgs, FlagTypeParty, METGUARD) == 2) {
                ShowText(player, type, doMsgs, "'ENOUGH! Have at you!'");
                SetFlag(player, type, doMsgs, FlagTypeParty, METGUARD, 0);
                AddEncounter(player, type, doMsgs, 01, 30);
            }
        }
        protected override void FnEvent17(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, GNOMEWIZARD);
            ShowText(player, type, doMsgs, "You notice a variety of levers on the wall here.");
            ShowText(player, type, doMsgs, "'Welcome to the tower! Don't play with the switches, please.  And please be careful on the bridge.'");
            SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.CROSSBRIDGE, 1);
            ClearTileBlock(player, type, doMsgs, 142);
            ClearTileBlock(player, type, doMsgs, 126);
            ClearTileBlock(player, type, doMsgs, 158);
            SetFloorItem(player, type, doMsgs, 1, 142);
            SetFloorItem(player, type, doMsgs, 1, 126);
            SetFloorItem(player, type, doMsgs, 1, 158);
        }
        protected override void FnEvent18(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.SETDUCTSWITCH) == 0)) {
                Change(player, type, doMsgs);
                ShowText(player, type, doMsgs, "You hear the sounds of locking mechanisms being released by the opening of the sluice gates; as if some doors off to the west are now unlocked!");
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.SETDUCTSWITCH, 1);
            }
            else {
                Change(player, type, doMsgs);
                ShowText(player, type, doMsgs, "The sluice gates have been closed, slowing the waters' flow. A low rumbling sound can be heard as though some mechanism has just been locked down again.");
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.SETDUCTSWITCH, 0);
            }
        }
        private void Change(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You fiddle with the various switches here against the watchman's advice. Upon hitting an odd-shaped lever, you hear the sound of the Aqueduct change.");
        }
        protected override void FnEvent19(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetFlag(player, type, doMsgs, FlagTypeParty, CLUBIT) == 0)) {
                SetTreasure(player, type, doMsgs, LONGBOW, ROUNDSHIELD, 0, 0, 0, 500);
            }
            ShowText(player, type, doMsgs, "Rogues rush at you from the shadows.");
            SetFlag(player, type, doMsgs, FlagTypeParty, CLUBIT, 1);
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 28);
                AddEncounter(player, type, doMsgs, 05, 29);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 28);
                AddEncounter(player, type, doMsgs, 02, 28);
                AddEncounter(player, type, doMsgs, 05, 29);
            }
        }
        protected override void FnEvent1A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetFlag(player, type, doMsgs, FlagTypeParty, FIGHT25) == 0)) {
                SetTreasure(player, type, doMsgs, LONGSWORD, ELIXIROFHEALTH, 0, 0, 0, 1000);
            }
            ShowText(player, type, doMsgs, "Assassins!!");
            SetFlag(player, type, doMsgs, FlagTypeParty, FIGHT25, 1);
            ModifyGold(player, type, doMsgs,  - 1000);
            DoDamage(player, type, doMsgs, GetHealthCurrent(player, type, doMsgs) / 6);
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 33);
                AddEncounter(player, type, doMsgs, 05, 34);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 33);
                AddEncounter(player, type, doMsgs, 02, 33);
                AddEncounter(player, type, doMsgs, 05, 34);
                AddEncounter(player, type, doMsgs, 06, 34);
            }
        }
        protected override void FnEvent1B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "As you enter the prisoner's cell, he turns to make his escape by force.");
            AddEncounter(player, type, doMsgs, 01, 26);
        }
        protected override void FnEvent1C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, ELFRANGER);
            ShowText(player, type, doMsgs, "'Fools! Fools! Do you think the waters always run! Mad, mad, mad, ahahahhahah!!'");
            ShowText(player, type, doMsgs, "Obviously this prisoner is insane.");
        }
        protected override void FnEvent1D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "A tiny door is visible to the west. You should be able to make it through.");
            ShowText(player, type, doMsgs, "The Coelus here, however, is another story.");
            AddEncounter(player, type, doMsgs, 01, 40);
        }
        protected override void FnEvent1E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetFlag(player, type, doMsgs, FlagTypeParty, METCLERIC) == 0)) {
                SetFlag(player, type, doMsgs, FlagTypeParty, METCLERIC, 1);
                ShowPortrait(player, type, doMsgs, ELFCLERIC);
                ShowText(player, type, doMsgs, "'Hmm...these foul spinning squares confuse and confound me. I do not understand how to defeat them.'");
            }
            else {
                ShowText(player, type, doMsgs, "The Cleric has wandered off.");
            }
        }
        protected override void FnEvent1F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.GAVE_INFO) == 0)) {
                if (GetFlag(player, type, doMsgs, FlagTypeParty, METCLERIC) == 1) {
                    Ranger(player, type, doMsgs);
                    ShowText(player, type, doMsgs, "You tell the Ranger where you recently saw a confused Cleric.");
                    ShowText(player, type, doMsgs, "'Excellent! I shall search there for him. My gratitude to you, good friend. Here, presents for your help.'");
                    ShowText(player, type, doMsgs, "He then marches off.");
                    ModifyGold(player, type, doMsgs, 100);
                    GiveItem(player, type, doMsgs, ELIXIROFHEALTH);
                    SetFlag(player, type, doMsgs, FlagTypeParty, METCLERIC, 2);
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.GAVE_INFO, 1);
                }
                else if ((GetFlag(player, type, doMsgs, FlagTypeParty, METCLERIC) == 0)) {
                    Ranger(player, type, doMsgs);
                    ShowText(player, type, doMsgs, "'Well, never mind then.' The Ranger turns and walks away.");
                }
            }
        }
        private void Ranger(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, ELFRANGER);
            ShowText(player, type, doMsgs, "'Pardon me, did you happen to see a Cleric friend of mine?  I'm afraid he gets confused quite easily.'");
        }
        protected override void FnEvent20(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, HUMANTHIEF);
            ShowText(player, type, doMsgs, "A sopping wet thief is here.");
            ShowText(player, type, doMsgs, "'I say, that blasted Aqueduct is frigid today. There must be a way to regulate the water's flow.'");
        }
        protected override void FnEvent21(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetFlag(player, type, doMsgs, FlagTypeTile, SPRUNGTRAP) == 0)) {
                switch (GetFacing(player, type, doMsgs)) {
                    case Direction.North:
                        SetFacing(player, type, doMsgs, Direction.West);
                        break;
                    case Direction.South:
                        SetFacing(player, type, doMsgs, Direction.West);
                        break;
                    case Direction.East:
                        SetFacing(player, type, doMsgs, Direction.South);
                        break;
                    case Direction.West:
                        SetFacing(player, type, doMsgs, Direction.East);
                        break;
                }
                SetFlag(player, type, doMsgs, FlagTypeTile, SPRUNGTRAP, 1);
            }
        }
        protected override void FnEvent22(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int i = 0;
            ShowText(player, type, doMsgs, "Vicious creatures surround you!");
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 39);
                AddEncounter(player, type, doMsgs, 05, 40);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 38);
                AddEncounter(player, type, doMsgs, 02, 39);
                AddEncounter(player, type, doMsgs, 05, 40);
            }
            else if (GetPartyCount(player, type, doMsgs) == 3) {
                AddEncounter(player, type, doMsgs, 01, 38);
                for (i = 2; i <= 3; i++) {
                    AddEncounter(player, type, doMsgs, i, 39);
                }
                for (i = 4; i <= 6; i++) {
                    AddEncounter(player, type, doMsgs, i, 40);
                }
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 38);
                AddEncounter(player, type, doMsgs, 02, 38);
                AddEncounter(player, type, doMsgs, 03, 39);
                AddEncounter(player, type, doMsgs, 04, 39);
                AddEncounter(player, type, doMsgs, 05, 40);
                AddEncounter(player, type, doMsgs, 06, 40);
            }
        }
        protected override void FnEvent23(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetFlag(player, type, doMsgs, FlagTypeParty, IRONSWORD) == 0)) {
                SetTreasure(player, type, doMsgs, IRONCUTLASS, ELIXIROFHEALTH, 0, 0, 0, 600);
            }
            ShowText(player, type, doMsgs, "'Kill the intruders!'");
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
                AddEncounter(player, type, doMsgs, 01, 31);
                AddEncounter(player, type, doMsgs, 02, 32);
                AddEncounter(player, type, doMsgs, 03, 32);
                AddEncounter(player, type, doMsgs, 05, 31);
                AddEncounter(player, type, doMsgs, 06, 31);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 31);
                AddEncounter(player, type, doMsgs, 02, 31);
                AddEncounter(player, type, doMsgs, 03, 32);
                AddEncounter(player, type, doMsgs, 04, 32);
                AddEncounter(player, type, doMsgs, 05, 32);
                AddEncounter(player, type, doMsgs, 06, 31);
            }
        }
        protected override void FnEvent24(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, HUMANTHIEF);
            ShowText(player, type, doMsgs, "A familiar traveler is here and is now dry.");
            ShowText(player, type, doMsgs, "'Hello there! I see you've managed to get yourself saturated in these waters too!'");
        }
        protected override void FnEvent25(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetFlag(player, type, doMsgs, FlagTypeParty, GOODBOOTY) == 0)) {
                SetTreasure(player, type, doMsgs, SPEAR, ROUNDSHIELD, BERSERKERTALISMAN, 0, 0, 1000);
            }
            ShowText(player, type, doMsgs, "Large beasts turn to challenge you as you stumble into their lair.");
            SetFlag(player, type, doMsgs, FlagTypeParty, GOODBOOTY, 1);
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 39);
                AddEncounter(player, type, doMsgs, 05, 40);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 38);
                AddEncounter(player, type, doMsgs, 02, 39);
                AddEncounter(player, type, doMsgs, 05, 40);
            }
            else if (GetPartyCount(player, type, doMsgs) == 3) {
                AddEncounter(player, type, doMsgs, 01, 38);
                AddEncounter(player, type, doMsgs, 02, 39);
                AddEncounter(player, type, doMsgs, 03, 39);
                AddEncounter(player, type, doMsgs, 05, 40);
                AddEncounter(player, type, doMsgs, 06, 40);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 38);
                AddEncounter(player, type, doMsgs, 02, 39);
                AddEncounter(player, type, doMsgs, 03, 40);
                AddEncounter(player, type, doMsgs, 04, 40);
                AddEncounter(player, type, doMsgs, 05, 40);
                AddEncounter(player, type, doMsgs, 06, 40);
            }
        }
        protected override void FnEvent26(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int flag = 0;
            int flag2 = 0;
            switch (GetTile(player, type, doMsgs)) {
                case 199:
                    flag = WESTSIDE;
                    flag2 = EASTSIDE;
                    break;
                case 201:
                    flag = EASTSIDE;
                    flag2 = WESTSIDE;
                    break;
            }
            if ((GetFlag(player, type, doMsgs, FlagTypeParty, flag) == 0) || (GetFlag(player, type, doMsgs, FlagTypeParty, flag2) == 0)) {
                Dwarf(player, type, doMsgs);
                ShowText(player, type, doMsgs, "A wizard here ponders a message on the wall: 'How do you keep an adventurer busy???'");
                if (GetTile(player, type, doMsgs) == 199) {
                    ShowText(player, type, doMsgs, "'See 2 east...hmmm.'");
                }
                else {
                    ShowText(player, type, doMsgs, "'See 2 west...hmmm.'");
                }
                SetFlag(player, type, doMsgs, FlagTypeParty, flag2, 1);
            }
            else if (GetFlag(player, type, doMsgs, FlagTypeParty, flag) == 1) {
                Dwarf(player, type, doMsgs);
                ShowText(player, type, doMsgs, "'I don't understand! I was just here!!'");
                ShowText(player, type, doMsgs, "'Strangely enough, so were you!!'");
                SetFlag(player, type, doMsgs, FlagTypeParty, flag2, 2);
                SetFlag(player, type, doMsgs, FlagTypeParty, flag, 3);
            }
            else if (GetFlag(player, type, doMsgs, FlagTypeParty, flag) == 2) {
                SetFlag(player, type, doMsgs, FlagTypeParty, flag, 3);
                if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.DIDJOKEPAIR) == 1) {
                    Disappear(player, type, doMsgs);
                }
                else {
                    Dwarf(player, type, doMsgs);
                    ShowText(player, type, doMsgs, "'Aha! Now I get it! Such a simple puzzle, it eluded me at first! Learn from this that all is not as challenging as you may think!'");
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.DIDJOKEPAIR, 1);
                    ModifyExperience(player, type, doMsgs, 750);
                }
            }
            else if (GetFlag(player, type, doMsgs, FlagTypeParty, flag) == 3 || GetFlag(player, type, doMsgs, FlagTypeParty, flag2) == 3) {
                Disappear(player, type, doMsgs);
            }
        }
        private void Dwarf(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, DWARFWIZARD);
        }
        private void Disappear(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "The wall message and the wizard have vanished.");
        }
        protected override void FnEvent28(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetFlag(player, type, doMsgs, FlagTypeParty, HALFTHIEF) == 0)) {
                ShowPortrait(player, type, doMsgs, HALFLINGTHIEF);
                ShowText(player, type, doMsgs, "A familiar looking thief lifts some more of your gold!");
                ShowText(player, type, doMsgs, "'Ahhh...this is quite generous! Thank you again for the offering!'");
                ModifyGold(player, type, doMsgs,  - 500);
                SetFlag(player, type, doMsgs, FlagTypeParty, HALFTHIEF, 1);
            }
            else {
                ShowText(player, type, doMsgs, "The thief has wandered off to loot other parties.");
            }
        }
        protected override void FnEvent29(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HasItem(player, type, doMsgs, CROSSKEY)) {
                ShowText(player, type, doMsgs, "Corpses litter the floor here, stripped of all their belongings. Seeing their fallen friends, other rogues attack!");
            }
            else {
                ShowText(player, type, doMsgs, "An 'X' is carved on the end of an ornate key that dangles on the rogue leader's neck.");
                SetTreasure(player, type, doMsgs, CROSSKEY, 0, 0, 0, 0, 150);
            }
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 36);
                AddEncounter(player, type, doMsgs, 05, 37);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 36);
                AddEncounter(player, type, doMsgs, 02, 35);
                AddEncounter(player, type, doMsgs, 05, 37);
            }
            else if (GetPartyCount(player, type, doMsgs) == 3) {
                AddEncounter(player, type, doMsgs, 01, 36);
                AddEncounter(player, type, doMsgs, 02, 36);
                AddEncounter(player, type, doMsgs, 03, 35);
                AddEncounter(player, type, doMsgs, 04, 35);
                AddEncounter(player, type, doMsgs, 06, 37);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 35);
                AddEncounter(player, type, doMsgs, 02, 35);
                AddEncounter(player, type, doMsgs, 03, 36);
                AddEncounter(player, type, doMsgs, 04, 36);
                AddEncounter(player, type, doMsgs, 05, 35);
                AddEncounter(player, type, doMsgs, 06, 37);
            }
        }
        protected override void FnEvent2A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.SETDUCTSWITCH) == 1) {
                ShowText(player, type, doMsgs, "The switch you set to open the sluice gates has released the pressure locks on this door!");
                ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                SetWallItem(player, type, doMsgs, DOOR, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
            }
            else {
                ShowText(player, type, doMsgs, "The doors are sealed shut and no lock is visible. Further examination reveals a lever mechanism concealed in the walls.");
                ShowText(player, type, doMsgs, "Perhaps there is a trigger somewhere that will unlock this door.");
            }
        }
        protected override void FnEvent2B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.DIDPATH) == 1 || GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.DIDPATH) == 2 || IsFlagOn(player, type, doMsgs, FlagTypeDungeon, TwIndexes.SETDUCTSWITCH)) {
                    if (IsFlagOn(player, type, doMsgs, FlagTypeDungeon, TwIndexes.SETDUCTSWITCH) && (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.DIDPATH) == 0)) {
                        ShowText(player, type, doMsgs, "There's a second way to the egress you are nearing. You need not seek it now; but return, and find the more profitable path later.");
                    }
                    else {
                        ShowText(player, type, doMsgs, "The door opens for those who have completed the sluice quest.");
                    }
                    ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                    SetWallItem(player, type, doMsgs, DOOR, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                }
                else {
                    ShowText(player, type, doMsgs, "Only those who solve the sluice and proceed alone may enter here.");
                    WallBlock(player, type, doMsgs);
                }
            }
            else {
                WallBlock(player, type, doMsgs);
                ShowText(player, type, doMsgs, "You must approach alone! You will know when you've found the way to unlock this door.");
            }
        }
        protected override void FnEvent2C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "The waterfall drags you out of the dungeon and dumps you into the sea.");
            ExitDungeon(player, type, doMsgs);
        }
        protected override void FnEvent2D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.CROSSBRIDGE) == 1) {
                SetWallInvisible(player, type, doMsgs, 126, Direction.North);
                ClearWallBlock(player, type, doMsgs, 126, Direction.North);
                SetWallInvisible(player, type, doMsgs, 158, Direction.South);
                ClearWallBlock(player, type, doMsgs, 158, Direction.South);
                ClearTileBlock(player, type, doMsgs, 142);
                ClearTileBlock(player, type, doMsgs, 126);
                ClearTileBlock(player, type, doMsgs, 158);
                SetFloorItem(player, type, doMsgs, 1, 142);
                SetFloorItem(player, type, doMsgs, 1, 126);
                SetFloorItem(player, type, doMsgs, 1, 158);
                ShowText(player, type, doMsgs, "You stand at one end of the bridge.");
                ShowText(player, type, doMsgs, "Invisible walls keep you from falling off the bridge into the freezing waters below.");
                SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.West);
                SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.East);
            }
            else {
                ShowText(player, type, doMsgs, "You see the base of a watch tower to the south.");
                ShowText(player, type, doMsgs, "A bridge spans the Aqueduct overhead.");
                SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.South);
                ClearWallInvisible(player, type, doMsgs, 158, Direction.South);
                ClearWallInvisible(player, type, doMsgs, 126, Direction.North);
                if ((GetFlag(player, type, doMsgs, FlagTypeTile, SPRUNGTRAP) == 0)) {
                    ShowText(player, type, doMsgs, "The rushing waters pummel your body.");
                    DoDamage(player, type, doMsgs, GetHealthMax(player, type, doMsgs) / 4);
                    SpringTrap(player, type, doMsgs);
                }
            }
        }
        protected override void FnEvent2E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.CROSSBRIDGE) == 1) {
                SetWallInvisible(player, type, doMsgs, 158, Direction.South);
                ClearWallBlock(player, type, doMsgs, 158, Direction.South);
                SetWallInvisible(player, type, doMsgs, 126, Direction.North);
                ClearWallBlock(player, type, doMsgs, 126, Direction.North);
                ClearTileBlock(player, type, doMsgs, 142);
                ClearTileBlock(player, type, doMsgs, 126);
                ClearTileBlock(player, type, doMsgs, 158);
                SetFloorItem(player, type, doMsgs, 1, 142);
                SetFloorItem(player, type, doMsgs, 1, 126);
                SetFloorItem(player, type, doMsgs, 1, 158);
                ShowText(player, type, doMsgs, "You stand at one end of the bridge.");
                ShowText(player, type, doMsgs, "Invisible walls keep you from falling off the bridge into the freezing waters below.");
                SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.West);
                SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.East);
            }
            else {
                ShowText(player, type, doMsgs, "You see the base of a watch tower to the north.");
                ShowText(player, type, doMsgs, "A bridge spans the Aqueduct overhead.");
                ClearWallInvisible(player, type, doMsgs, 158, Direction.South);
                ClearWallInvisible(player, type, doMsgs, 126, Direction.North);
                SetWallBlock(player, type, doMsgs, 126, Direction.North);
                SetWallBlock(player, type, doMsgs, 158, Direction.South);
                if ((GetFlag(player, type, doMsgs, FlagTypeTile, SPRUNGTRAP) == 0)) {
                    ShowText(player, type, doMsgs, "The rushing waters pummel your body.");
                    DoDamage(player, type, doMsgs, GetHealthMax(player, type, doMsgs) / 4);
                    SpringTrap(player, type, doMsgs);
                }
            }
        }
        protected override void FnEvent2F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.CROSSBRIDGE, 0);
        }
        protected override void FnEvent30(TwPlayerServer player, MapEventType type, bool doMsgs) {
            DisableHealing(player, type, doMsgs);
            ClearWallInvisible(player, type, doMsgs, 158, Direction.South);
            ClearWallInvisible(player, type, doMsgs, 126, Direction.North);
            SetWallBlock(player, type, doMsgs, 126, Direction.North);
            SetWallBlock(player, type, doMsgs, 158, Direction.South);
            if ((GetFlag(player, type, doMsgs, FlagTypeTile, SPRUNGTRAP) == 0)) {
                ShowText(player, type, doMsgs, "The rushing waters pummel your body.");
                DoDamage(player, type, doMsgs, GetHealthMax(player, type, doMsgs) / 4);
                SpringTrap(player, type, doMsgs);
            }
        }
        protected override void FnEvent31(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.MERCHANT) == 0)) {
                if (GetGuild(player, type, doMsgs) == THIEF || GetGuild(player, type, doMsgs) == WIZARD) {
                    GiveSpell(player, type, doMsgs, PETRIFY_SPELL, 1);
                    ShowPortrait(player, type, doMsgs, GNOMEWIZARD);
                    ModifyGold(player, type, doMsgs,  - 1000);
                    ShowText(player, type, doMsgs, "An honorable merchant offers you a taste of his drink in exchange for some gold.");
                    ShowText(player, type, doMsgs, "As you sip the thick grog, you learn the petrify spell!!");
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.MERCHANT, 1);
                }
            }
            else if (GetHealthCurrent(player, type, doMsgs) < GetHealthMax(player, type, doMsgs)) {
                ShowPortrait(player, type, doMsgs, GNOMEWIZARD);
                ShowText(player, type, doMsgs, "'A trifle of gold for a sup of health? Tis a fair lot, m'good champion.' You feel your health and mana restored!");
                ModifyGold(player, type, doMsgs,  - 100);
                ModifyMana(player, type, doMsgs, 2000);
                ModifyHealth(player, type, doMsgs, GetHealthMax(player, type, doMsgs));
            }
        }
        protected override void FnEvent32(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int spell = 0;
            if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.FNTN) == 0)) {
                if (GetGuild(player, type, doMsgs) == CLERIC || GetGuild(player, type, doMsgs) == WIZARD || GetGuild(player, type, doMsgs) == RANGER) {
                    switch (GetGuild(player, type, doMsgs)) {
                        case CLERIC:
                            spell = AURA_SPELL;
                            break;
                        case WIZARD:
                            spell = REFRESH_SPELL;
                            break;
                        case RANGER:
                            spell = HEAL_SPELL;
                            GiveSpell(player, type, doMsgs, RESIST_SPELL, 1);
                            break;
                    }
                    GiveSpell(player, type, doMsgs, spell, 1);
                    ShowPortrait(player, type, doMsgs, FOUNTAIN);
                    ShowText(player, type, doMsgs, "Gleaming rays of light pour from this fountain. You drink of its sweet waters and gain new powers.");
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.FNTN, 1);
                }
                else {
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.FNTN, 1);
                    HealUs(player, type, doMsgs);
                }
            }
            else {
                HealUs(player, type, doMsgs);
            }
        }
        private void HealUs(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, FOUNTAIN);
            ShowText(player, type, doMsgs, "The waters offer limited refreshment, but nothing more.");
            ModifyHealth(player, type, doMsgs, GetHealthMax(player, type, doMsgs) / 4);
        }
        protected override void FnEvent33(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.RESIST) == 0)) {
                if (GetGuild(player, type, doMsgs) == CLERIC || GetGuild(player, type, doMsgs) == WIZARD) {
                    GiveSpell(player, type, doMsgs, RESIST_SPELL, 1);
                    ShowPortrait(player, type, doMsgs, FOUNTAIN);
                    ShowText(player, type, doMsgs, "Sour waters turn into sweet nectar as you learn how to resist the elements.");
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.RESIST, 1);
                }
                else if (GetGuild(player, type, doMsgs) == RANGER) {
                    ShowPortrait(player, type, doMsgs, FOUNTAIN);
                    ShowText(player, type, doMsgs, "Radiant waters enlighten you with a new spell!");
                    GiveSpell(player, type, doMsgs, AURA_SPELL, 1);
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.RESIST, 1);
                }
            }
            else {
                ShowPortrait(player, type, doMsgs, FOUNTAIN);
                ShowText(player, type, doMsgs, "A dry well is all that greets you here.");
            }
        }
        protected override void FnEvent34(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HasUsedSkill(player, type, ref doMsgs, LOCKPICK_SKILL) >= 6 || UsedItem(player, type, ref doMsgs, HELMOFGUILE, HELMOFGUILE) || UsedItem(player, type, ref doMsgs, GREENLOCKPICK, BLUELOCKPICK)) {
                ShowText(player, type, doMsgs, "You managed to pick the lock!");
                ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
            }
            else {
                ShowText(player, type, doMsgs, "A very stubborn lock impedes your progress here.");
                SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
            }
        }
        protected override void FnEvent35(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ClearWallItem(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
            ShowText(player, type, doMsgs, "An illusionary door vanishes as you approach!");
        }
    }
}
