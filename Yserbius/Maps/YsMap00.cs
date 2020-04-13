#pragma warning disable
using System.Collections.Generic;
using XPT.Games.Generic.Entities;
using XPT.Games.Generic.Maps;
using XPT.Games.Yserbius;
using XPT.Games.Yserbius.Entities;

namespace XPT.Games.Yserbius.Maps {
    class YserMap00 : YsMap {
        public override int MapIndex => 0;
        protected override int RandomEncounterChance => 0;
        protected override int RandomEncounterExtraCount => 0;

        public YserMap00() {
            MapEvent01 = FnTOMINES_01;
            MapEvent02 = FnTOTREAS_02;
            MapEvent03 = FnTOSOLDQU_03;
            MapEvent04 = FnEXITDUNG_04;
            MapEvent05 = FnDOORMESA_05;
            MapEvent06 = FnDOORMESB_06;
            MapEvent07 = FnDOORMESC_07;
            MapEvent08 = FnDOORMESD_08;
            MapEvent09 = FnTELEPORT_09;
            MapEvent0A = FnTELEMESS_0A;
            MapEvent0B = FnDOORMESS_0B;
            MapEvent0C = FnPRTYPORT_0C;
            MapEvent0D = FnNOJOIN_0D;
        }
        
        // === Strings ================================================
        private const string String03FC = "The gateway leads to THE MINES.";
        private const string String041C = "The gateway leads to THE HALL OF DOORS.";
        private const string String0444 = "The gateway leads to THE SOLDIERS  QUARTERS.";
        private const string String0471 = "The gateway is the DUNGEON EXIT.";
        private const string String0492 = "Hail, conquering HERO OF YSERBIUS!";
        private const string String04B5 = "All of Twinion bows to your prominence!!";
        private const string String04DE = "There is a teleport in the west wall.";
        private const string String0504 = "This room contains the gateway to the Labyrinth.";
        private const string String0535 = "The Thieves' Key unlocks this door!";
        private const string String0559 = "This room contains the gateway to the Labyrinth.";
        private const string String058A = "The Thieves' Key is needed to unlock this door.";
        private const string String05BA = "The Thieves' Key is needed to unlock this door.";
        private const string String05EA = "Only heroes of the twentieth level or higher may venture beyond this door.";
        private const string String0635 = "Good Journeys, brave hero.";
        private const string String0650 = "Only heroes of the twentieth level or higher may venture beyond this door.";
        
        // === Functions ================================================
        private void FnTOMINES_01(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x01, 0x02, 0xFD, 0x03, type);
            L001E: return; // RETURN;
        }

        private void FnTOTREAS_02(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x01, 0x04, 0x10, 0x02, type);
            L001E: return; // RETURN;
        }

        private void FnTOSOLDQU_03(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x01, 0x06, 0x0F, 0x01, type);
            L001E: return; // RETURN;
        }

        private void FnEXITDUNG_04(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ExitDungeon(player, false, type);
            L000B: return; // RETURN;
        }

        private void FnDOORMESA_05(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String03FC); // The gateway leads to THE MINES.
            L0010: return; // RETURN;
        }

        private void FnDOORMESB_06(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String041C); // The gateway leads to THE HALL OF DOORS.
            L0010: return; // RETURN;
        }

        private void FnDOORMESC_07(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String0444); // The gateway leads to THE SOLDIERS  QUARTERS.
            L0010: return; // RETURN;
        }

        private void FnDOORMESD_08(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String0471); // The gateway is the DUNGEON EXIT.
            L0010: ax = IsFlagOn(player, FlagTypeDungeon, YsIndexes.FlagDefeatedEnLiKil);
            L0023: if (JumpEqual) goto L003F;
            L0025: ShowMessage(player, doMsgs, String0492); // Hail, conquering HERO OF YSERBIUS!
            L0032: ShowMessage(player, doMsgs, String04B5); // All of Twinion bows to your prominence!!
            L003F: return; // RETURN;
        }

        private void FnTELEPORT_09(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x33, 0x01, 0x5D, 0x00, type);
            L001D: return; // RETURN;
        }

        private void FnTELEMESS_0A(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String04DE); // There is a teleport in the west wall.
            L0010: return; // RETURN;
        }

        private void FnDOORMESS_0B(YsPlayerServer player, MapEventType type, bool doMsgs) {
            ShowMessage(player, doMsgs, String0504); // This room contains the gateway to the Labyrinth.
            // party level check:
            if (CheckLevel(player, 20) == 0) {
                ShowMessage(player, doMsgs, String05EA); // Only heroes of the twentieth level or higher may venture beyond this door.
                return;
            }
            // check if this player has already unlocked the door:
            if (Compare(GetFlag(player, FlagTypeDungeon, YsIndexes.FlagUnlockedLabyrinthDoor), 0x0001)) {
                if (player.IsPartyLeader) {
                    ShowMessage(player, doMsgs, "The door is unlocked. The Labyrinth is open to you.");
                    SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
                }
                else {
                    ShowMessage(player, doMsgs, "You previously unlocked this door. When you lead a party, it will open for you.");
                }
                return;
            }
            // we haven't already unlocked the door. Check for thieves' key:
            if (HasItem(player, YsIndexes.ItemThievesKey) == 1) {
                if (player.IsPartyLeader) {
                    ShowMessage(player, doMsgs, "The Thieves' Key unlocks this door! The Labyrinth is now open to you.");
                    SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
                }
                else {
                    ShowMessage(player, doMsgs, "The Thieves' Key unlocks this door! When you lead a party, it will open for you.");
                }
                ShowMessage(player, doMsgs, "You notice that your pack seems much lighter. To your surprise, Cleowyn's vestments and a number of keys have disappeared.");
                SetFlag(player, FlagTypeDungeon, YsIndexes.FlagUnlockedLabyrinthDoor, 0x01);
                RemoveItem(player, YsIndexes.ItemThievesKey);
                RemoveItem(player, YsIndexes.ItemKingCleowynsLockpick);
                RemoveItem(player, YsIndexes.ItemKingCleowynsKey);
                RemoveItem(player, YsIndexes.ItemKeyToCleowynsPalace);
                RemoveItem(player, YsIndexes.ItemKingsDomicileKey);
                RemoveItem(player, YsIndexes.ItemLavaKey);
                RemoveItem(player, YsIndexes.ItemKingsRing);
                SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
                return;
            }
            // door is locked, no thieves' key:
            ShowMessage(player, doMsgs, String05BA); // The Thieves' Key is needed to unlock this door.
        }

        private void FnPRTYPORT_0C(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckLevel(player, 0x0014);
            L0011: if (JumpEqual) goto L0022;
            L0013: ShowMessage(player, doMsgs, String0635); // Good Journeys, brave hero.
            L0020: goto L0049;
            L0022: ShowMessage(player, doMsgs, String0650); // Only heroes of the twentieth level or higher may venture beyond this door.
            L002F: TeleportParty(player, 0x01, 0x01, 0x02, 0x00, type);
            L0049: return; // RETURN;
        }

        private void FnNOJOIN_0D(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetNoJoinArea(player);
            L000B: return; // RETURN;
        }

    }
}
