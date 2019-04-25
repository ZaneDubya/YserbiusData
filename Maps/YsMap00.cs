#pragma warning disable
using System.Collections.Generic;
using XPT.Legacy;
using XPT.Legacy.Entities;
using XPT.Legacy.Yserbius;

namespace XPT.Legacy.Maps {
    class YserMap00 : AMapScripted {
        protected override int MapIndex => 0;
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
        private void FnTOMINES_01(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x01, 0x02, 0xFD, 0x03, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnTOTREAS_02(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x01, 0x04, 0x10, 0x02, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnTOSOLDQU_03(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x01, 0x06, 0x0F, 0x01, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnEXITDUNG_04(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ExitDungeon(player, false, isForwardMove);
            L000B: return; // RETURN;
        }

        private void FnDOORMESA_05(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String03FC); // The gateway leads to THE MINES.
            L0010: return; // RETURN;
        }

        private void FnDOORMESB_06(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String041C); // The gateway leads to THE HALL OF DOORS.
            L0010: return; // RETURN;
        }

        private void FnDOORMESC_07(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0444); // The gateway leads to THE SOLDIERS  QUARTERS.
            L0010: return; // RETURN;
        }

        private void FnDOORMESD_08(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0471); // The gateway is the DUNGEON EXIT.
            L0010: ax = IsFlagOn(player, FlagTypeDungeon, FlagDefeatedEnLiKil);
            L0023: if (JumpEqual) goto L003F;
            L0025: ShowMessage(player, String0492); // Hail, conquering HERO OF YSERBIUS!
            L0032: ShowMessage(player, String04B5); // All of Twinion bows to your prominence!!
            L003F: return; // RETURN;
        }

        private void FnTELEPORT_09(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x33, 0x01, 0x5D, 0x00, isForwardMove);
            L001D: return; // RETURN;
        }

        private void FnTELEMESS_0A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String04DE); // There is a teleport in the west wall.
            L0010: return; // RETURN;
        }

        private void FnDOORMESS_0B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckLevel(player, 0x0014);
            L0011: if (JumpNotEqual) goto L0016;
            L0013: goto L011F;
            L0016: Compare(GetFlag(player, FlagTypeDungeon, FlagUnlockedLabrinthDoor), 0x0001);
            L002A: if (JumpNotEqual) goto L005A;
            L002C: ShowMessage(player, String0504); // This room contains the gateway to the Labyrinth.
            L0039: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0057: goto L011D;
            L005A: ax = HasItem(player, 0xFB);
            L0068: if (JumpNotEqual) goto L006D;
            L006A: goto L0110;
            L006D: ShowMessage(player, String0535); // The Thieves' Key unlocks this door!
            L007A: ShowMessage(player, String0559); // This room contains the gateway to the Labyrinth.
            L0087: SetFlag(player, FlagTypeDungeon, FlagUnlockedLabrinthDoor, 0x01);
            L009C: RemoveItem(player, 0xFB);
            L00A8: RemoveItem(player, 0xD2);
            L00B4: RemoveItem(player, 0xD3);
            L00C0: RemoveItem(player, 0xD9);
            L00CC: RemoveItem(player, 0xE1);
            L00D8: RemoveItem(player, 0xE2);
            L00E4: RemoveItem(player, 0xF8);
            L00F0: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L010E: goto L011D;
            L0110: ShowMessage(player, String058A); // The Thieves' Key is needed to unlock this door.
            L011D: goto L0156;
            L011F: ShowMessage(player, String05BA); // The Thieves' Key is needed to unlock this door.
            L012C: ShowMessage(player, String05EA); // Only heroes of the twentieth level or higher may venture beyond this door.
            L0139: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0156: return; // RETURN;
        }

        private void FnPRTYPORT_0C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckLevel(player, 0x0014);
            L0011: if (JumpEqual) goto L0022;
            L0013: ShowMessage(player, String0635); // Good Journeys, brave hero.
            L0020: goto L0049;
            L0022: ShowMessage(player, String0650); // Only heroes of the twentieth level or higher may venture beyond this door.
            L002F: TeleportParty(player, 0x01, 0x01, 0x02, 0x00, isForwardMove);
            L0049: return; // RETURN;
        }

        private void FnNOJOIN_0D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetNoJoinArea(player);
            L000B: return; // RETURN;
        }

    }
}
