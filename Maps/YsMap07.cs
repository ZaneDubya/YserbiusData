#pragma warning disable
using System.Collections.Generic;
using XPT.Legacy;
using XPT.Legacy.Entities;

namespace XPT.Legacy.Maps {
    class YserMap07 : AMapScripted {
        protected override int MapIndex => 7;
        protected override int RandomEncounterChance => 10;
        protected override int RandomEncounterExtraCount => 0;

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
        private void FnSTRSTELE_01(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x01, 0x03, 0x97, 0x02, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnSTRSTELE_02(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x03, 0x01, 0x1F, 0x01, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnLKPKDOOR_03(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasUsedItem(player, 0xC1, 0xC4);
            L0016: if (JumpNotEqual) goto L0029;
            L0018: Compare(HasUsedSkill(player, 0x0E), 0x0006);
            L0027: if (JumpBelow) goto L0074;
            L0029: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0047: SetWallItem(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L0065: ShowMessage(player, isForwardMove, String03FC); // You succeeded at opening the locked door.
            L0072: goto L009E;
            L0074: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0091: ShowMessage(player, isForwardMove, String0426); // The door is locked.
            L009E: return; // RETURN;
        }

        private void FnLKPKDOOR_04(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasUsedItem(player, 0xBF, 0xC4);
            L0016: if (JumpNotEqual) goto L0029;
            L0018: Compare(HasUsedSkill(player, 0x0E), 0x0001);
            L0027: if (JumpBelow) goto L0046;
            L0029: DamagePlayer(player, 0x0096);
            L0036: ShowMessage(player, isForwardMove, String043A); // Your attempt to open the door springs a trap. Dozens of darts attack you.
            L0043: goto L00D0;
            L0046: ax = HasUsedItem(player, 0xD9, 0xD9);
            L0059: if (JumpEqual) goto L00A6;
            L005B: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0079: SetWallItem(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L0097: ShowMessage(player, isForwardMove, String0484); // The key unlocked the massive door, bypassing a well hidden trap.
            L00A4: goto L00D0;
            L00A6: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L00C3: ShowMessage(player, isForwardMove, String04C5); // The Palace doors are locked.  Only the Palace key will open these doors.
            L00D0: return; // RETURN;
        }

        private void FnRUNESIGN_05(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, isForwardMove, String050E); // Runes can be seen on the tapestry...
            L0010: ShowRunes(player, String0533); // None shall pass save one who holds the Key to the Palace.
            L001D: return; // RETURN;
        }

        private void FnTOPALACA_06(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x02, 0x06, 0x03, 0x01, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnLOWMNSTR_07(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L0025;
            L0010: AddEncounter(player, 0x01, 0x19);
            L0022: goto L00E6;
            L0025: Compare(PartyCount(player), 0x0002);
            L0030: if (JumpNotEqual) goto L0059;
            L0032: AddEncounter(player, 0x01, 0x1A);
            L0044: AddEncounter(player, 0x02, 0x1C);
            L0056: goto L00E6;
            L0059: Compare(PartyCount(player), 0x0003);
            L0064: if (JumpNotEqual) goto L009E;
            L0066: AddEncounter(player, 0x01, 0x1A);
            L0078: AddEncounter(player, 0x02, 0x1A);
            L008A: AddEncounter(player, 0x03, 0x1B);
            L009C: goto L00E6;
            L009E: AddEncounter(player, 0x01, 0x19);
            L00B0: AddEncounter(player, 0x02, 0x1C);
            L00C2: AddEncounter(player, 0x03, 0x1B);
            L00D4: AddEncounter(player, 0x04, 0x1A);
            L00E6: return; // RETURN;
        }

        private void FnMEDMNSTR_08(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L0037;
            L0010: AddEncounter(player, 0x01, 0x1E);
            L0022: AddEncounter(player, 0x02, 0x20);
            L0034: goto L0176;
            L0037: Compare(PartyCount(player), 0x0002);
            L0042: if (JumpNotEqual) goto L008F;
            L0044: AddEncounter(player, 0x01, 0x1F);
            L0056: AddEncounter(player, 0x02, 0x1F);
            L0068: AddEncounter(player, 0x03, 0x1E);
            L007A: AddEncounter(player, 0x04, 0x21);
            L008C: goto L0176;
            L008F: Compare(PartyCount(player), 0x0003);
            L009A: if (JumpNotEqual) goto L010A;
            L009C: AddEncounter(player, 0x01, 0x1E);
            L00AE: AddEncounter(player, 0x02, 0x1F);
            L00C0: AddEncounter(player, 0x03, 0x1E);
            L00D2: AddEncounter(player, 0x04, 0x1F);
            L00E4: AddEncounter(player, 0x05, 0x20);
            L00F6: AddEncounter(player, 0x06, 0x20);
            L0108: goto L0176;
            L010A: AddEncounter(player, 0x01, 0x22);
            L011C: AddEncounter(player, 0x02, 0x22);
            L012E: AddEncounter(player, 0x03, 0x22);
            L0140: AddEncounter(player, 0x04, 0x22);
            L0152: AddEncounter(player, 0x05, 0x22);
            L0164: AddEncounter(player, 0x06, 0x22);
            L0176: return; // RETURN;
        }

        private void FnSTRMNSTR_09(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L0025;
            L0010: AddEncounter(player, 0x01, 0x23);
            L0022: goto L012E;
            L0025: Compare(PartyCount(player), 0x0002);
            L0030: if (JumpNotEqual) goto L0059;
            L0032: AddEncounter(player, 0x01, 0x24);
            L0044: AddEncounter(player, 0x02, 0x24);
            L0056: goto L012E;
            L0059: Compare(PartyCount(player), 0x0003);
            L0064: if (JumpNotEqual) goto L00C2;
            L0066: AddEncounter(player, 0x01, 0x24);
            L0078: AddEncounter(player, 0x02, 0x24);
            L008A: AddEncounter(player, 0x03, 0x23);
            L009C: AddEncounter(player, 0x04, 0x23);
            L00AE: AddEncounter(player, 0x05, 0x26);
            L00C0: goto L012E;
            L00C2: AddEncounter(player, 0x01, 0x28);
            L00D4: AddEncounter(player, 0x02, 0x25);
            L00E6: AddEncounter(player, 0x03, 0x23);
            L00F8: AddEncounter(player, 0x04, 0x27);
            L010A: AddEncounter(player, 0x05, 0x24);
            L011C: AddEncounter(player, 0x06, 0x28);
            L012E: return; // RETURN;
        }

        private void FnSTRSMESA_0A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, isForwardMove, String056D); // The stairs through the west gateway lead up a level.
            L0010: return; // RETURN;
        }

        private void FnSTRSMESB_0B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, isForwardMove, String05A2); // Through the north gateway are stairs going up to the next level.
            L0010: return; // RETURN;
        }

        private void FnSTRSMESC_0C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, isForwardMove, String05E3); // The stairs to the east lead downstairs.
            L0010: return; // RETURN;
        }

        private void FnSTRSMESD_0D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, isForwardMove, String060B); // The stairs past the north gateway go down a level.
            L0010: return; // RETURN;
        }

        private void FnGATEMESS_0E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, isForwardMove, String063E); // The gateway leads to THE PALACE OF KING CLEOWYN.
            L0010: return; // RETURN;
        }

        private void FnTOPALACB_0F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x02, 0x06, 0x04, 0x01, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnNPCCHATA_10(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, isForwardMove, String066F); // You encounter a Dwarf Thief.
            L0010: ShowPortrait(player, 0x0023);
            L001D: Compare(GetRandom(0x000F), 0x000B);
            L002D: if (JumpAbove) goto L003E;
            L002F: ShowMessage(player, isForwardMove, String068C); // The palace doors are locked. Somewhere on the first level is the object that will open these doors.
            L003C: goto L004B;
            L003E: ShowMessage(player, isForwardMove, String06F0); // The Dwarf Thief is too busy removing darts from his leather shield to answer you.
            L004B: return; // RETURN;
        }

        private void FnNPCCHATB_11(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, isForwardMove, String0742); // You encounter a Halfling Ranger.
            L0010: ShowPortrait(player, 0x0021);
            L001D: Compare(GetRandom(0x000F), 0x0008);
            L002D: if (JumpAbove) goto L003E;
            L002F: ShowMessage(player, isForwardMove, String0763); // I know there are three secret areas on this level, but they cannot be entered from this corridor.
            L003C: goto L004B;
            L003E: ShowMessage(player, isForwardMove, String07C5); // The Halfling Ranger waves you away in annoyance.
            L004B: return; // RETURN;
        }

        private void FnNPCCHATC_12(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, isForwardMove, String07F6); // You encounter a Dwarf Wizard.
            L0010: ShowPortrait(player, 0x002C);
            L001D: Compare(GetRandom(0x000F), 0x000C);
            L002D: if (JumpAbove) goto L003E;
            L002F: ShowMessage(player, isForwardMove, String0814); // Not all traps should be by-passed. I fell through one and, after some nosing around and polishing off some bothersome rogues and monsters, found a most useful key.
            L003C: goto L004B;
            L003E: ShowMessage(player, isForwardMove, String08B8); // The Dwarf Wizard disappears in a puff of smoke.
            L004B: return; // RETURN;
        }

        private void FnNPCCHATD_13(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, isForwardMove, String08E8); // You encounter an Orc Knight.
            L0010: ShowPortrait(player, 0x001A);
            L001D: Compare(GetRandom(0x000F), 0x0007);
            L002D: if (JumpAbove) goto L003E;
            L002F: ShowMessage(player, isForwardMove, String0905); // King Cleowyn's Palace is an evil place, filled with the spirits of the tormented dead.  A cleric told me to look for an asymmetry in the Palace if I wished to learn the truth about the dead king.
            L003C: goto L004B;
            L003E: ShowMessage(player, isForwardMove, String09C9); // The Orc Knight pretends not to hear you.
            L004B: return; // RETURN;
        }

        private void FnSTRSTELE_14(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x01, 0x03, 0x97, 0x02, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnSTRSTELE_15(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x03, 0x01, 0x1F, 0x01, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnNPCCHATE_16(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, isForwardMove, String09F2); // You encounter a Halfling Cleric.
            L0010: ShowPortrait(player, 0x0029);
            L001D: Compare(GetRandom(0x000F), 0x000D);
            L002D: if (JumpAbove) goto L004B;
            L002F: ShowMessage(player, isForwardMove, String0A13); // On the next level down you will find a dwarf by the name of Deldwinn.  He guards the entrance to King Cleowyn's Apartments.
            L003C: ShowMessage(player, isForwardMove, String0A8F); // Do not try to fight Deldwinn, for he is enchanted and cannot be killed by mortals.
            L0049: goto L0058;
            L004B: ShowMessage(player, isForwardMove, String0AE2); // The Halfling Cleric mumbles his prayers.
            L0058: return; // RETURN;
        }

    }
}
