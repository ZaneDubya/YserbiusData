#pragma warning disable
using XPT.WorldData;

namespace XPT.Scripts.Maps {
    class YserMap07 : AMapScripted {
        protected override int MapIndex => 7;
        
        public YserMap07() {
            MapEvent01 = FnSTRSTELE_01;
            MapEvent02 = FnSTRSTELE_02;
            MapEvent03 = FnLKPKDOOR_03;
            MapEvent04 = FnLKPKDOOR_04;
            MapEvent05 = FnRUNESIGN_05;
            MapEvent06 = FnTOPALACA_06;
            MapEvent07 = FnLOWMNSTR_07;
            MapEvent08 = FnMEDMNSTR_08;
            MapEvent09 = FnSTRMNSTR_09;
            MapEvent0A = FnSTRSMESA_0A;
            MapEvent0B = FnSTRSMESB_0B;
            MapEvent0C = FnSTRSMESC_0C;
            MapEvent0D = FnSTRSMESD_0D;
            MapEvent0E = FnGATEMESS_0E;
            MapEvent0F = FnTOPALACB_0F;
            MapEvent10 = FnNPCCHATA_10;
            MapEvent11 = FnNPCCHATB_11;
            MapEvent12 = FnNPCCHATC_12;
            MapEvent13 = FnNPCCHATD_13;
            MapEvent14 = FnSTRSTELE_14;
            MapEvent15 = FnSTRSTELE_15;
            MapEvent16 = FnNPCCHATE_16;
        }
        
        // === Strings ================================================
        private const string String03FC = "You succeeded at opening the locked door.";
        private const string String0426 = "The door is locked.";
        private const string String043A = "Your attempt to open the door springs a trap. Dozens of darts attack you.";
        private const string String0484 = "The key unlocked the massive door, bypassing a well hidden trap.";
        private const string String04C5 = "The Palace doors are locked.  Only the Palace key will open these doors.";
        private const string String050E = "Runes can be seen on the tapestry...";
        private const string String0533 = "None shall pass save one who holds the Key to the Palace.";
        private const string String056D = "The stairs through the west gateway lead up a level.";
        private const string String05A2 = "Through the north gateway are stairs going up to the next level.";
        private const string String05E3 = "The stairs to the east lead downstairs.";
        private const string String060B = "The stairs past the north gateway go down a level.";
        private const string String063E = "The gateway leads to THE PALACE OF KING CLEOWYN.";
        private const string String066F = "You encounter a Dwarf Thief.";
        private const string String068C = "The palace doors are locked. Somewhere on the first level is the object that will open these doors.";
        private const string String06F0 = "The Dwarf Thief is too busy removing darts from his leather shield to answer you.";
        private const string String0742 = "You encounter a Halfling Ranger.";
        private const string String0763 = "I know there are three secret areas on this level, but they cannot be entered from this corridor.";
        private const string String07C5 = "The Halfling Ranger waves you away in annoyance.";
        private const string String07F6 = "You encounter a Dwarf Wizard.";
        private const string String0814 = "Not all traps should be by-passed. I fell through one and, after some nosing around and polishing off some bothersome rogues and monsters, found a most useful key.";
        private const string String08B8 = "The Dwarf Wizard disappears in a puff of smoke.";
        private const string String08E8 = "You encounter an Orc Knight.";
        private const string String0905 = "King Cleowyn's Palace is an evil place, filled with the spirits of the tormented dead.  A cleric told me to look for an asymmetry in the Palace if I wished to learn the truth about the dead king.";
        private const string String09C9 = "The Orc Knight pretends not to hear you.";
        private const string String09F2 = "You encounter a Halfling Cleric.";
        private const string String0A13 = "On the next level down you will find a dwarf by the name of Deldwinn.  He guards the entrance to King Cleowyn's Apartments.";
        private const string String0A8F = "Do not try to fight Deldwinn, for he is enchanted and cannot be killed by mortals.";
        private const string String0AE2 = "The Halfling Cleric mumbles his prayers.";
        
        // === Functions ================================================
        private void FnSTRSTELE_01(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportPartyBC(party, 0x01, 0x03, 0x97, 0x02);
            L001E: return; // RETURN;
        }

        private void FnSTRSTELE_02(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportPartyBC(party, 0x03, 0x01, 0x1F, 0x01);
            L001E: return; // RETURN;
        }

        private void FnLKPKDOOR_03(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = UsedItem54(party, 0xC1, 0xC4);
            L0016: if (JumpNotEqual) goto L0029;
            L0018: ax = UsedSkill58(party, 0x0E); // returns 0 if did not use, compares to 2nd op if did use;
            L0024: Compare(ax, 0x0006);
            L0027: if (JumpBelow) goto L0074;
            L0029: PushStack(party, 0x01);
            L002D: ax = GetFacing24(party);
            L0034: PushStack(party, ax);
            L0035: ax = GetCurrentTile20(party);
            L003C: PushStack(party, ax);
            L003D: SetWallPassable2C(party, PopStack(party), PopStack(party), PopStack(party));
            L0047: ax = GetFacing24(party);
            L004E: PushStack(party, ax);
            L004F: ax = GetCurrentTile20(party);
            L0056: PushStack(party, ax);
            L0057: PushStack(party, 0x01);
            L005B: SetWallObject30(party, PopStack(party), PopStack(party), PopStack(party));
            L0065: ShowMessage(party, String03FC); // You succeeded at opening the locked door.
            L0072: goto L009E;
            L0074: PushStack(party, 0x00);
            L0077: ax = GetFacing24(party);
            L007E: PushStack(party, ax);
            L007F: ax = GetCurrentTile20(party);
            L0086: PushStack(party, ax);
            L0087: SetWallPassable2C(party, PopStack(party), PopStack(party), PopStack(party));
            L0091: ShowMessage(party, String0426); // The door is locked.
            L009E: return; // RETURN;
        }

        private void FnLKPKDOOR_04(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = UsedItem54(party, 0xBF, 0xC4);
            L0016: if (JumpNotEqual) goto L0029;
            L0018: ax = UsedSkill58(party, 0x0E); // returns 0 if did not use, compares to 2nd op if did use;
            L0024: Compare(ax, 0x0001);
            L0027: if (JumpBelow) goto L0046;
            L0029: DamagePlayer90(party, 0x0096);
            L0036: ShowMessage(party, String043A); // Your attempt to open the door springs a trap. Dozens of darts attack you.
            L0043: goto L00D0;
            L0046: ax = UsedItem54(party, 0xD9, 0xD9);
            L0059: if (JumpEqual) goto L00A6;
            L005B: PushStack(party, 0x01);
            L005F: ax = GetFacing24(party);
            L0066: PushStack(party, ax);
            L0067: ax = GetCurrentTile20(party);
            L006E: PushStack(party, ax);
            L006F: SetWallPassable2C(party, PopStack(party), PopStack(party), PopStack(party));
            L0079: ax = GetFacing24(party);
            L0080: PushStack(party, ax);
            L0081: ax = GetCurrentTile20(party);
            L0088: PushStack(party, ax);
            L0089: PushStack(party, 0x01);
            L008D: SetWallObject30(party, PopStack(party), PopStack(party), PopStack(party));
            L0097: ShowMessage(party, String0484); // The key unlocked the massive door, bypassing a well hidden trap.
            L00A4: goto L00D0;
            L00A6: PushStack(party, 0x00);
            L00A9: ax = GetFacing24(party);
            L00B0: PushStack(party, ax);
            L00B1: ax = GetCurrentTile20(party);
            L00B8: PushStack(party, ax);
            L00B9: SetWallPassable2C(party, PopStack(party), PopStack(party), PopStack(party));
            L00C3: ShowMessage(party, String04C5); // The Palace doors are locked.  Only the Palace key will open these doors.
            L00D0: return; // RETURN;
        }

        private void FnRUNESIGN_05(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String050E); // Runes can be seen on the tapestry...
            L0010: ShowRunes(party, String0533); // None shall pass save one who holds the Key to the Palace.
            L001D: return; // RETURN;
        }

        private void FnTOPALACA_06(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportPartyBC(party, 0x02, 0x06, 0x03, 0x01);
            L001E: return; // RETURN;
        }

        private void FnLOWMNSTR_07(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = PartyCount(party);
            L000B: Compare(ax, 0x0001);
            L000E: if (JumpNotEqual) goto L0025;
            L0010: AddEncounter(party, 0x01, 0x19);
            L0022: goto L00E6;
            L0025: ax = PartyCount(party);
            L002D: Compare(ax, 0x0002);
            L0030: if (JumpNotEqual) goto L0059;
            L0032: AddEncounter(party, 0x01, 0x1A);
            L0044: AddEncounter(party, 0x02, 0x1C);
            L0056: goto L00E6;
            L0059: ax = PartyCount(party);
            L0061: Compare(ax, 0x0003);
            L0064: if (JumpNotEqual) goto L009E;
            L0066: AddEncounter(party, 0x01, 0x1A);
            L0078: AddEncounter(party, 0x02, 0x1A);
            L008A: AddEncounter(party, 0x03, 0x1B);
            L009C: goto L00E6;
            L009E: AddEncounter(party, 0x01, 0x19);
            L00B0: AddEncounter(party, 0x02, 0x1C);
            L00C2: AddEncounter(party, 0x03, 0x1B);
            L00D4: AddEncounter(party, 0x04, 0x1A);
            L00E6: return; // RETURN;
        }

        private void FnMEDMNSTR_08(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = PartyCount(party);
            L000B: Compare(ax, 0x0001);
            L000E: if (JumpNotEqual) goto L0037;
            L0010: AddEncounter(party, 0x01, 0x1E);
            L0022: AddEncounter(party, 0x02, 0x20);
            L0034: goto L0176;
            L0037: ax = PartyCount(party);
            L003F: Compare(ax, 0x0002);
            L0042: if (JumpNotEqual) goto L008F;
            L0044: AddEncounter(party, 0x01, 0x1F);
            L0056: AddEncounter(party, 0x02, 0x1F);
            L0068: AddEncounter(party, 0x03, 0x1E);
            L007A: AddEncounter(party, 0x04, 0x21);
            L008C: goto L0176;
            L008F: ax = PartyCount(party);
            L0097: Compare(ax, 0x0003);
            L009A: if (JumpNotEqual) goto L010A;
            L009C: AddEncounter(party, 0x01, 0x1E);
            L00AE: AddEncounter(party, 0x02, 0x1F);
            L00C0: AddEncounter(party, 0x03, 0x1E);
            L00D2: AddEncounter(party, 0x04, 0x1F);
            L00E4: AddEncounter(party, 0x05, 0x20);
            L00F6: AddEncounter(party, 0x06, 0x20);
            L0108: goto L0176;
            L010A: AddEncounter(party, 0x01, 0x22);
            L011C: AddEncounter(party, 0x02, 0x22);
            L012E: AddEncounter(party, 0x03, 0x22);
            L0140: AddEncounter(party, 0x04, 0x22);
            L0152: AddEncounter(party, 0x05, 0x22);
            L0164: AddEncounter(party, 0x06, 0x22);
            L0176: return; // RETURN;
        }

        private void FnSTRMNSTR_09(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = PartyCount(party);
            L000B: Compare(ax, 0x0001);
            L000E: if (JumpNotEqual) goto L0025;
            L0010: AddEncounter(party, 0x01, 0x23);
            L0022: goto L012E;
            L0025: ax = PartyCount(party);
            L002D: Compare(ax, 0x0002);
            L0030: if (JumpNotEqual) goto L0059;
            L0032: AddEncounter(party, 0x01, 0x24);
            L0044: AddEncounter(party, 0x02, 0x24);
            L0056: goto L012E;
            L0059: ax = PartyCount(party);
            L0061: Compare(ax, 0x0003);
            L0064: if (JumpNotEqual) goto L00C2;
            L0066: AddEncounter(party, 0x01, 0x24);
            L0078: AddEncounter(party, 0x02, 0x24);
            L008A: AddEncounter(party, 0x03, 0x23);
            L009C: AddEncounter(party, 0x04, 0x23);
            L00AE: AddEncounter(party, 0x05, 0x26);
            L00C0: goto L012E;
            L00C2: AddEncounter(party, 0x01, 0x28);
            L00D4: AddEncounter(party, 0x02, 0x25);
            L00E6: AddEncounter(party, 0x03, 0x23);
            L00F8: AddEncounter(party, 0x04, 0x27);
            L010A: AddEncounter(party, 0x05, 0x24);
            L011C: AddEncounter(party, 0x06, 0x28);
            L012E: return; // RETURN;
        }

        private void FnSTRSMESA_0A(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String056D); // The stairs through the west gateway lead up a level.
            L0010: return; // RETURN;
        }

        private void FnSTRSMESB_0B(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String05A2); // Through the north gateway are stairs going up to the next level.
            L0010: return; // RETURN;
        }

        private void FnSTRSMESC_0C(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String05E3); // The stairs to the east lead downstairs.
            L0010: return; // RETURN;
        }

        private void FnSTRSMESD_0D(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String060B); // The stairs past the north gateway go down a level.
            L0010: return; // RETURN;
        }

        private void FnGATEMESS_0E(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String063E); // The gateway leads to THE PALACE OF KING CLEOWYN.
            L0010: return; // RETURN;
        }

        private void FnTOPALACB_0F(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportPartyBC(party, 0x02, 0x06, 0x04, 0x01);
            L001E: return; // RETURN;
        }

        private void FnNPCCHATA_10(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String066F); // You encounter a Dwarf Thief.
            L0010: ShowPortrait(party, 0x0023);
            L001D: ax = GetRandom(party, 0x000F);
            L002A: Compare(ax, 0x000B);
            L002D: if (JumpAbove) goto L003E;
            L002F: ShowMessage(party, String068C); // The palace doors are locked. Somewhere on the first level is the object that will open these doors.
            L003C: goto L004B;
            L003E: ShowMessage(party, String06F0); // The Dwarf Thief is too busy removing darts from his leather shield to answer you.
            L004B: return; // RETURN;
        }

        private void FnNPCCHATB_11(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0742); // You encounter a Halfling Ranger.
            L0010: ShowPortrait(party, 0x0021);
            L001D: ax = GetRandom(party, 0x000F);
            L002A: Compare(ax, 0x0008);
            L002D: if (JumpAbove) goto L003E;
            L002F: ShowMessage(party, String0763); // I know there are three secret areas on this level, but they cannot be entered from this corridor.
            L003C: goto L004B;
            L003E: ShowMessage(party, String07C5); // The Halfling Ranger waves you away in annoyance.
            L004B: return; // RETURN;
        }

        private void FnNPCCHATC_12(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String07F6); // You encounter a Dwarf Wizard.
            L0010: ShowPortrait(party, 0x002C);
            L001D: ax = GetRandom(party, 0x000F);
            L002A: Compare(ax, 0x000C);
            L002D: if (JumpAbove) goto L003E;
            L002F: ShowMessage(party, String0814); // Not all traps should be by-passed. I fell through one and, after some nosing around and polishing off some bothersome rogues and monsters, found a most useful key.
            L003C: goto L004B;
            L003E: ShowMessage(party, String08B8); // The Dwarf Wizard disappears in a puff of smoke.
            L004B: return; // RETURN;
        }

        private void FnNPCCHATD_13(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String08E8); // You encounter an Orc Knight.
            L0010: ShowPortrait(party, 0x001A);
            L001D: ax = GetRandom(party, 0x000F);
            L002A: Compare(ax, 0x0007);
            L002D: if (JumpAbove) goto L003E;
            L002F: ShowMessage(party, String0905); // King Cleowyn's Palace is an evil place, filled with the spirits of the tormented dead.  A cleric told me to look for an asymmetry in the Palace if I wished to learn the truth about the dead king.
            L003C: goto L004B;
            L003E: ShowMessage(party, String09C9); // The Orc Knight pretends not to hear you.
            L004B: return; // RETURN;
        }

        private void FnSTRSTELE_14(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportPartyBC(party, 0x01, 0x03, 0x97, 0x02);
            L001E: return; // RETURN;
        }

        private void FnSTRSTELE_15(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportPartyBC(party, 0x03, 0x01, 0x1F, 0x01);
            L001E: return; // RETURN;
        }

        private void FnNPCCHATE_16(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String09F2); // You encounter a Halfling Cleric.
            L0010: ShowPortrait(party, 0x0029);
            L001D: ax = GetRandom(party, 0x000F);
            L002A: Compare(ax, 0x000D);
            L002D: if (JumpAbove) goto L004B;
            L002F: ShowMessage(party, String0A13); // On the next level down you will find a dwarf by the name of Deldwinn.  He guards the entrance to King Cleowyn's Apartments.
            L003C: ShowMessage(party, String0A8F); // Do not try to fight Deldwinn, for he is enchanted and cannot be killed by mortals.
            L0049: goto L0058;
            L004B: ShowMessage(party, String0AE2); // The Halfling Cleric mumbles his prayers.
            L0058: return; // RETURN;
        }

    }
}
