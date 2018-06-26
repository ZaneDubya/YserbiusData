#pragma warning disable
using XPT.WorldData;

namespace XPT.Scripts.Yserbius.Maps {
    class YserMap00 : AMapScripted {
        protected override int MapIndex => 0;
        protected override int ChanceRandom => 0;

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
        private void FnTOMINES_01(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(party, 0x01, 0x02, 0xFD, 0x03, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnTOTREAS_02(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(party, 0x01, 0x04, 0x10, 0x02, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnTOSOLDQU_03(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(party, 0x01, 0x06, 0x0F, 0x01, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnEXITDUNG_04(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ExitDungeon(party, isForwardMove);
            L000B: return; // RETURN;
        }

        private void FnDOORMESA_05(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String03FC); // The gateway leads to THE MINES.
            L0010: return; // RETURN;
        }

        private void FnDOORMESB_06(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String041C); // The gateway leads to THE HALL OF DOORS.
            L0010: return; // RETURN;
        }

        private void FnDOORMESC_07(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0444); // The gateway leads to THE SOLDIERS  QUARTERS.
            L0010: return; // RETURN;
        }

        private void FnDOORMESD_08(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0471); // The gateway is the DUNGEON EXIT.
            L0010: ax = IsStateSet(party, 0x02, 0x6A);
            L0023: if (JumpEqual) goto L003F;
            L0025: ShowMessage(party, String0492); // Hail, conquering HERO OF YSERBIUS!
            L0032: ShowMessage(party, String04B5); // All of Twinion bows to your prominence!!
            L003F: return; // RETURN;
        }

        private void FnTELEPORT_09(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(party, 0x33, 0x01, 0x5D, 0x00, isForwardMove);
            L001D: return; // RETURN;
        }

        private void FnTELEMESS_0A(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String04DE); // There is a teleport in the west wall.
            L0010: return; // RETURN;
        }

        private void FnDOORMESS_0B(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckLevel(party, 0x0014);
            L0011: if (JumpNotEqual) goto L0016;
            L0013: goto L011F;
            L0016: ax = GetState(party, 0x02, 0x78);
            L0027: Compare(ax, 0x0001);
            L002A: if (JumpNotEqual) goto L005A;
            L002C: ShowMessage(party, String0504); // This room contains the gateway to the Labyrinth.
            L0039: PushStack(party, 0x01);
            L003D: ax = GetFacing(party);
            L0044: PushStack(party, ax);
            L0045: ax = GetCurrentTile(party);
            L004C: PushStack(party, ax);
            L004D: SetWallPassable(party, PopStack(party), PopStack(party), PopStack(party));
            L0057: goto L011D;
            L005A: ax = HasItem(party, 0xFB);
            L0068: if (JumpNotEqual) goto L006D;
            L006A: goto L0110;
            L006D: ShowMessage(party, String0535); // The Thieves' Key unlocks this door!
            L007A: ShowMessage(party, String0559); // This room contains the gateway to the Labyrinth.
            L0087: SetState(party, 0x02, 0x78, 0x01);
            L009C: RemoveItem(party, 0xFB);
            L00A8: RemoveItem(party, 0xD2);
            L00B4: RemoveItem(party, 0xD3);
            L00C0: RemoveItem(party, 0xD9);
            L00CC: RemoveItem(party, 0xE1);
            L00D8: RemoveItem(party, 0xE2);
            L00E4: RemoveItem(party, 0xF8);
            L00F0: PushStack(party, 0x01);
            L00F4: ax = GetFacing(party);
            L00FB: PushStack(party, ax);
            L00FC: ax = GetCurrentTile(party);
            L0103: PushStack(party, ax);
            L0104: SetWallPassable(party, PopStack(party), PopStack(party), PopStack(party));
            L010E: goto L011D;
            L0110: ShowMessage(party, String058A); // The Thieves' Key is needed to unlock this door.
            L011D: goto L0156;
            L011F: ShowMessage(party, String05BA); // The Thieves' Key is needed to unlock this door.
            L012C: ShowMessage(party, String05EA); // Only heroes of the twentieth level or higher may venture beyond this door.
            L0139: PushStack(party, 0x00);
            L013C: ax = GetFacing(party);
            L0143: PushStack(party, ax);
            L0144: ax = GetCurrentTile(party);
            L014B: PushStack(party, ax);
            L014C: SetWallPassable(party, PopStack(party), PopStack(party), PopStack(party));
            L0156: return; // RETURN;
        }

        private void FnPRTYPORT_0C(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckLevel(party, 0x0014);
            L0011: if (JumpEqual) goto L0022;
            L0013: ShowMessage(party, String0635); // Good Journeys, brave hero.
            L0020: goto L0049;
            L0022: ShowMessage(party, String0650); // Only heroes of the twentieth level or higher may venture beyond this door.
            L002F: TeleportParty(party, 0x01, 0x01, 0x02, 0x00, isForwardMove);
            L0049: return; // RETURN;
        }

        private void FnNOJOIN_0D(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetNoJoinArea(party);
            L000B: return; // RETURN;
        }

    }
}
