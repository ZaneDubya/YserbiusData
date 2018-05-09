namespace ZCF.Scripts.Maps {
    class YserMap07 : ACanoMapScript {
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
        private override MapEventHandler MapEvent01 => FnSTRSTELE_01;
        private void FnSTRSTELE_01(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetMoveMap(party, 0x02, 0x97, 0x03, 0x01);
            L001E: // RETURN;
        }

        private override MapEventHandler MapEvent02 => FnSTRSTELE_02;
        private void FnSTRSTELE_02(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetMoveMap(party, 0x01, 0x1F, 0x01, 0x03);
            L001E: // RETURN;
        }

        private override MapEventHandler MapEvent03 => FnLKPKDOOR_03;
        private void FnLKPKDOOR_03(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = UsedItem54(party, 0xC1, 0xC4);
            L0016: if (result.notequal) goto L0029;
            L0018: ax = UsedSkill58(party, 0x0E) // returns 0 if did not use, compares to 2nd op if did use;
            L0024: compare(ax, 0x0006);
            L0027: if (result.below) goto L0074;
            L0029: Push(01);
            L002D: ax = GetFacing24(party);
            L0034: PushStack(ax);
            L0035: ax = GetNextTile20(party);
            L003C: PushStack(ax);
            L003D: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L0047: ax = GetFacing24(party);
            L004E: PushStack(ax);
            L004F: ax = GetNextTile20(party);
            L0056: PushStack(ax);
            L0057: Push(01);
            L005B: SetUnblocked30(party);
            L0065: ShowMessage(party, String03FC); // You succeeded at opening the locked door.
            L0072: goto L009E;
            L0074: PushStack(0x00);
            L0077: ax = GetFacing24(party);
            L007E: PushStack(ax);
            L007F: ax = GetNextTile20(party);
            L0086: PushStack(ax);
            L0087: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L0091: ShowMessage(party, String0426); // The door is locked.
            L009E: // RETURN;
        }

        private override MapEventHandler MapEvent04 => FnLKPKDOOR_04;
        private void FnLKPKDOOR_04(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = UsedItem54(party, 0xBF, 0xC4);
            L0016: if (result.notequal) goto L0029;
            L0018: ax = UsedSkill58(party, 0x0E) // returns 0 if did not use, compares to 2nd op if did use;
            L0024: compare(ax, 0x0001);
            L0027: if (result.below) goto L0046;
            L0029: DoDamage90(party, 0x0096);
            L0036: ShowMessage(party, String043A); // Your attempt to open the door springs a trap. Dozens of darts attack you.
            L0043: goto L00D0;
            L0046: ax = UsedItem54(party, 0xD9, 0xD9);
            L0059: if (result.equal) goto L00A6;
            L005B: Push(01);
            L005F: ax = GetFacing24(party);
            L0066: PushStack(ax);
            L0067: ax = GetNextTile20(party);
            L006E: PushStack(ax);
            L006F: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L0079: ax = GetFacing24(party);
            L0080: PushStack(ax);
            L0081: ax = GetNextTile20(party);
            L0088: PushStack(ax);
            L0089: Push(01);
            L008D: SetUnblocked30(party);
            L0097: ShowMessage(party, String0484); // The key unlocked the massive door, bypassing a well hidden trap.
            L00A4: goto L00D0;
            L00A6: PushStack(0x00);
            L00A9: ax = GetFacing24(party);
            L00B0: PushStack(ax);
            L00B1: ax = GetNextTile20(party);
            L00B8: PushStack(ax);
            L00B9: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L00C3: ShowMessage(party, String04C5); // The Palace doors are locked.  Only the Palace key will open these doors.
            L00D0: // RETURN;
        }

        private override MapEventHandler MapEvent05 => FnRUNESIGN_05;
        private void FnRUNESIGN_05(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String050E); // Runes can be seen on the tapestry...
            L0010: ShowRunes(party, String0533); // None shall pass save one who holds the Key to the Palace.
            L001D: // RETURN;
        }

        private override MapEventHandler MapEvent06 => FnTOPALACA_06;
        private void FnTOPALACA_06(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetMoveMap(party, 0x01, 0x03, 0x06, 0x02);
            L001E: // RETURN;
        }

        private override MapEventHandler MapEvent07 => FnLOWMNSTR_07;
        private void FnLOWMNSTR_07(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = PartyCount(party);
            L000B: compare(ax, 0x0001);
            L000E: if (result.notequal) goto L0025;
            L0010: AddEncounter(party, 0x19, 0x01);
            L0022: goto L00E6;
            L0025: ax = PartyCount(party);
            L002D: compare(ax, 0x0002);
            L0030: if (result.notequal) goto L0059;
            L0032: AddEncounter(party, 0x1A, 0x01);
            L0044: AddEncounter(party, 0x1C, 0x02);
            L0056: goto L00E6;
            L0059: ax = PartyCount(party);
            L0061: compare(ax, 0x0003);
            L0064: if (result.notequal) goto L009E;
            L0066: AddEncounter(party, 0x1A, 0x01);
            L0078: AddEncounter(party, 0x1A, 0x02);
            L008A: AddEncounter(party, 0x1B, 0x03);
            L009C: goto L00E6;
            L009E: AddEncounter(party, 0x19, 0x01);
            L00B0: AddEncounter(party, 0x1C, 0x02);
            L00C2: AddEncounter(party, 0x1B, 0x03);
            L00D4: AddEncounter(party, 0x1A, 0x04);
            L00E6: // RETURN;
        }

        private override MapEventHandler MapEvent08 => FnMEDMNSTR_08;
        private void FnMEDMNSTR_08(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = PartyCount(party);
            L000B: compare(ax, 0x0001);
            L000E: if (result.notequal) goto L0037;
            L0010: AddEncounter(party, 0x1E, 0x01);
            L0022: AddEncounter(party, 0x20, 0x02);
            L0034: goto L0176;
            L0037: ax = PartyCount(party);
            L003F: compare(ax, 0x0002);
            L0042: if (result.notequal) goto L008F;
            L0044: AddEncounter(party, 0x1F, 0x01);
            L0056: AddEncounter(party, 0x1F, 0x02);
            L0068: AddEncounter(party, 0x1E, 0x03);
            L007A: AddEncounter(party, 0x21, 0x04);
            L008C: goto L0176;
            L008F: ax = PartyCount(party);
            L0097: compare(ax, 0x0003);
            L009A: if (result.notequal) goto L010A;
            L009C: AddEncounter(party, 0x1E, 0x01);
            L00AE: AddEncounter(party, 0x1F, 0x02);
            L00C0: AddEncounter(party, 0x1E, 0x03);
            L00D2: AddEncounter(party, 0x1F, 0x04);
            L00E4: AddEncounter(party, 0x20, 0x05);
            L00F6: AddEncounter(party, 0x20, 0x06);
            L0108: goto L0176;
            L010A: AddEncounter(party, 0x22, 0x01);
            L011C: AddEncounter(party, 0x22, 0x02);
            L012E: AddEncounter(party, 0x22, 0x03);
            L0140: AddEncounter(party, 0x22, 0x04);
            L0152: AddEncounter(party, 0x22, 0x05);
            L0164: AddEncounter(party, 0x22, 0x06);
            L0176: // RETURN;
        }

        private override MapEventHandler MapEvent09 => FnSTRMNSTR_09;
        private void FnSTRMNSTR_09(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = PartyCount(party);
            L000B: compare(ax, 0x0001);
            L000E: if (result.notequal) goto L0025;
            L0010: AddEncounter(party, 0x23, 0x01);
            L0022: goto L012E;
            L0025: ax = PartyCount(party);
            L002D: compare(ax, 0x0002);
            L0030: if (result.notequal) goto L0059;
            L0032: AddEncounter(party, 0x24, 0x01);
            L0044: AddEncounter(party, 0x24, 0x02);
            L0056: goto L012E;
            L0059: ax = PartyCount(party);
            L0061: compare(ax, 0x0003);
            L0064: if (result.notequal) goto L00C2;
            L0066: AddEncounter(party, 0x24, 0x01);
            L0078: AddEncounter(party, 0x24, 0x02);
            L008A: AddEncounter(party, 0x23, 0x03);
            L009C: AddEncounter(party, 0x23, 0x04);
            L00AE: AddEncounter(party, 0x26, 0x05);
            L00C0: goto L012E;
            L00C2: AddEncounter(party, 0x28, 0x01);
            L00D4: AddEncounter(party, 0x25, 0x02);
            L00E6: AddEncounter(party, 0x23, 0x03);
            L00F8: AddEncounter(party, 0x27, 0x04);
            L010A: AddEncounter(party, 0x24, 0x05);
            L011C: AddEncounter(party, 0x28, 0x06);
            L012E: // RETURN;
        }

        private override MapEventHandler MapEvent0A => FnSTRSMESA_0A;
        private void FnSTRSMESA_0A(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String056D); // The stairs through the west gateway lead up a level.
            L0010: // RETURN;
        }

        private override MapEventHandler MapEvent0B => FnSTRSMESB_0B;
        private void FnSTRSMESB_0B(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String05A2); // Through the north gateway are stairs going up to the next level.
            L0010: // RETURN;
        }

        private override MapEventHandler MapEvent0C => FnSTRSMESC_0C;
        private void FnSTRSMESC_0C(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String05E3); // The stairs to the east lead downstairs.
            L0010: // RETURN;
        }

        private override MapEventHandler MapEvent0D => FnSTRSMESD_0D;
        private void FnSTRSMESD_0D(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String060B); // The stairs past the north gateway go down a level.
            L0010: // RETURN;
        }

        private override MapEventHandler MapEvent0E => FnGATEMESS_0E;
        private void FnGATEMESS_0E(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String063E); // The gateway leads to THE PALACE OF KING CLEOWYN.
            L0010: // RETURN;
        }

        private override MapEventHandler MapEvent0F => FnTOPALACB_0F;
        private void FnTOPALACB_0F(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetMoveMap(party, 0x01, 0x04, 0x06, 0x02);
            L001E: // RETURN;
        }

        private override MapEventHandler MapEvent10 => FnNPCCHATA_10;
        private void FnNPCCHATA_10(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String066F); // You encounter a Dwarf Thief.
            L0010: ShowPortrait(party, 0x0023);
            L001D: ax = UnknownFunctionEC(party, 0x000F);
            L002A: compare(ax, 0x000B);
            L002D: if (result.unsigned_greater_than) goto L003E;
            L002F: ShowMessage(party, String068C); // The palace doors are locked. Somewhere on the first level is the object that will open these doors.
            L003C: goto L004B;
            L003E: ShowMessage(party, String06F0); // The Dwarf Thief is too busy removing darts from his leather shield to answer you.
            L004B: // RETURN;
        }

        private override MapEventHandler MapEvent11 => FnNPCCHATB_11;
        private void FnNPCCHATB_11(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0742); // You encounter a Halfling Ranger.
            L0010: ShowPortrait(party, 0x0021);
            L001D: ax = UnknownFunctionEC(party, 0x000F);
            L002A: compare(ax, 0x0008);
            L002D: if (result.unsigned_greater_than) goto L003E;
            L002F: ShowMessage(party, String0763); // I know there are three secret areas on this level, but they cannot be entered from this corridor.
            L003C: goto L004B;
            L003E: ShowMessage(party, String07C5); // The Halfling Ranger waves you away in annoyance.
            L004B: // RETURN;
        }

        private override MapEventHandler MapEvent12 => FnNPCCHATC_12;
        private void FnNPCCHATC_12(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String07F6); // You encounter a Dwarf Wizard.
            L0010: ShowPortrait(party, 0x002C);
            L001D: ax = UnknownFunctionEC(party, 0x000F);
            L002A: compare(ax, 0x000C);
            L002D: if (result.unsigned_greater_than) goto L003E;
            L002F: ShowMessage(party, String0814); // Not all traps should be by-passed. I fell through one and, after some nosing around and polishing off some bothersome rogues and monsters, found a most useful key.
            L003C: goto L004B;
            L003E: ShowMessage(party, String08B8); // The Dwarf Wizard disappears in a puff of smoke.
            L004B: // RETURN;
        }

        private override MapEventHandler MapEvent13 => FnNPCCHATD_13;
        private void FnNPCCHATD_13(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String08E8); // You encounter an Orc Knight.
            L0010: ShowPortrait(party, 0x001A);
            L001D: ax = UnknownFunctionEC(party, 0x000F);
            L002A: compare(ax, 0x0007);
            L002D: if (result.unsigned_greater_than) goto L003E;
            L002F: ShowMessage(party, String0905); // King Cleowyn's Palace is an evil place, filled with the spirits of the tormented dead.  A cleric told me to look for an asymmetry in the Palace if I wished to learn the truth about the dead king.
            L003C: goto L004B;
            L003E: ShowMessage(party, String09C9); // The Orc Knight pretends not to hear you.
            L004B: // RETURN;
        }

        private override MapEventHandler MapEvent14 => FnSTRSTELE_14;
        private void FnSTRSTELE_14(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetMoveMap(party, 0x02, 0x97, 0x03, 0x01);
            L001E: // RETURN;
        }

        private override MapEventHandler MapEvent15 => FnSTRSTELE_15;
        private void FnSTRSTELE_15(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetMoveMap(party, 0x01, 0x1F, 0x01, 0x03);
            L001E: // RETURN;
        }

        private override MapEventHandler MapEvent16 => FnNPCCHATE_16;
        private void FnNPCCHATE_16(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String09F2); // You encounter a Halfling Cleric.
            L0010: ShowPortrait(party, 0x0029);
            L001D: ax = UnknownFunctionEC(party, 0x000F);
            L002A: compare(ax, 0x000D);
            L002D: if (result.unsigned_greater_than) goto L004B;
            L002F: ShowMessage(party, String0A13); // On the next level down you will find a dwarf by the name of Deldwinn.  He guards the entrance to King Cleowyn's Apartments.
            L003C: ShowMessage(party, String0A8F); // Do not try to fight Deldwinn, for he is enchanted and cannot be killed by mortals.
            L0049: goto L0058;
            L004B: ShowMessage(party, String0AE2); // The Halfling Cleric mumbles his prayers.
            L0058: // RETURN;
        }

    }
}
