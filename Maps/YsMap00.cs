#pragma warning disable
using XPT.WorldData;

namespace XPT.Scripts.Maps {
    class YserMap00 : AMapScript {
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
        protected override MapEventHandler MapEvent01 => FnTOMINES_01;
        private void FnTOMINES_01(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetMoveMap(party, 0x01, 0x02, 0xFD, 0x03);
            L001E: return; // RETURN;
        }

        protected override MapEventHandler MapEvent02 => FnTOTREAS_02;
        private void FnTOTREAS_02(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetMoveMap(party, 0x01, 0x04, 0x10, 0x02);
            L001E: return; // RETURN;
        }

        protected override MapEventHandler MapEvent03 => FnTOSOLDQU_03;
        private void FnTOSOLDQU_03(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetMoveMap(party, 0x01, 0x06, 0x0F, 0x01);
            L001E: return; // RETURN;
        }

        protected override MapEventHandler MapEvent04 => FnEXITDUNG_04;
        private void FnEXITDUNG_04(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ExitDungeon(party);
            L000B: return; // RETURN;
        }

        protected override MapEventHandler MapEvent05 => FnDOORMESA_05;
        private void FnDOORMESA_05(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String03FC); // The gateway leads to THE MINES.
            L0010: return; // RETURN;
        }

        protected override MapEventHandler MapEvent06 => FnDOORMESB_06;
        private void FnDOORMESB_06(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String041C); // The gateway leads to THE HALL OF DOORS.
            L0010: return; // RETURN;
        }

        protected override MapEventHandler MapEvent07 => FnDOORMESC_07;
        private void FnDOORMESC_07(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0444); // The gateway leads to THE SOLDIERS  QUARTERS.
            L0010: return; // RETURN;
        }

        protected override MapEventHandler MapEvent08 => FnDOORMESD_08;
        private void FnDOORMESD_08(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0471); // The gateway is the DUNGEON EXIT.
            L0010: ax = CheckState08(party, 0x02, 0x6A);
            L0023: if (CompareResultEqual) goto L003F;
            L0025: ShowMessage(party, String0492); // Hail, conquering HERO OF YSERBIUS!
            L0032: ShowMessage(party, String04B5); // All of Twinion bows to your prominence!!
            L003F: return; // RETURN;
        }

        protected override MapEventHandler MapEvent09 => FnTELEPORT_09;
        private void FnTELEPORT_09(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetMoveMap(party, 0x33, 0x01, 0x5D, 0x00);
            L001D: return; // RETURN;
        }

        protected override MapEventHandler MapEvent0A => FnTELEMESS_0A;
        private void FnTELEMESS_0A(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String04DE); // There is a teleport in the west wall.
            L0010: return; // RETURN;
        }

        protected override MapEventHandler MapEvent0B => FnDOORMESS_0B;
        private void FnDOORMESS_0B(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckLevel44(party, 0x0014);
            L0011: if (!CompareResultEqual) goto L0016;
            L0013: goto L011F;
            L0016: ax = CheckState04(party, 0x02, 0x78);
            L0027: Compare(ax, 0x0001);
            L002A: if (!CompareResultEqual) goto L005A;
            L002C: ShowMessage(party, String0504); // This room contains the gateway to the Labyrinth.
            L0039: PushStack(0x01);
            L003D: ax = GetFacing24(party);
            L0044: PushStack(ax);
            L0045: ax = GetNextTile20(party);
            L004C: PushStack(ax);
            L004D: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L0057: goto L011D;
            L005A: ax = HasItem50(party, 0xFB);
            L0068: if (!CompareResultEqual) goto L006D;
            L006A: goto L0110;
            L006D: ShowMessage(party, String0535); // The Thieves' Key unlocks this door!
            L007A: ShowMessage(party, String0559); // This room contains the gateway to the Labyrinth.
            L0087: SetState00(party, 0x02, 0x78, 0x01);
            L009C: RemoveItem4C(party, 0xFB);
            L00A8: RemoveItem4C(party, 0xD2);
            L00B4: RemoveItem4C(party, 0xD3);
            L00C0: RemoveItem4C(party, 0xD9);
            L00CC: RemoveItem4C(party, 0xE1);
            L00D8: RemoveItem4C(party, 0xE2);
            L00E4: RemoveItem4C(party, 0xF8);
            L00F0: PushStack(0x01);
            L00F4: ax = GetFacing24(party);
            L00FB: PushStack(ax);
            L00FC: ax = GetNextTile20(party);
            L0103: PushStack(ax);
            L0104: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L010E: goto L011D;
            L0110: ShowMessage(party, String058A); // The Thieves' Key is needed to unlock this door.
            L011D: goto L0156;
            L011F: ShowMessage(party, String05BA); // The Thieves' Key is needed to unlock this door.
            L012C: ShowMessage(party, String05EA); // Only heroes of the twentieth level or higher may venture beyond this door.
            L0139: PushStack(0x00);
            L013C: ax = GetFacing24(party);
            L0143: PushStack(ax);
            L0144: ax = GetNextTile20(party);
            L014B: PushStack(ax);
            L014C: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L0156: return; // RETURN;
        }

        protected override MapEventHandler MapEvent0C => FnPRTYPORT_0C;
        private void FnPRTYPORT_0C(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckLevel44(party, 0x0014);
            L0011: if (CompareResultEqual) goto L0022;
            L0013: ShowMessage(party, String0635); // Good Journeys, brave hero.
            L0020: goto L0049;
            L0022: ShowMessage(party, String0650); // Only heroes of the twentieth level or higher may venture beyond this door.
            L002F: SetMoveMap(party, 0x01, 0x01, 0x02, 0x00);
            L0049: return; // RETURN;
        }

        protected override MapEventHandler MapEvent0D => FnNOJOIN_0D;
        private void FnNOJOIN_0D(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TileIsNoJoinArea(party);
            L000B: return; // RETURN;
        }

    }
}
