#pragma warning disable
using XPT.WorldData;

namespace XPT.Scripts.Maps {
    class YserMap19 : AMapScript {
        protected override int MapIndex => 19;
        
        public YserMap19() {
            MapEvent01 = FnTELEPORT_01;
            MapEvent02 = FnTELEMESS_02;
            MapEvent03 = FnFOUNBLES_03;
            MapEvent04 = FnQUESTENC_04;
            MapEvent05 = FnLKPKDORZ_05;
            MapEvent06 = FnSTRDOOR_06;
            MapEvent0B = FnAVEMNSTR_0B;
            MapEvent0C = FnSTRMNSTR_0C;
            MapEvent0E = FnNPCCHATA_0E;
            MapEvent0F = FnNPCCHATB_0F;
        }
        
        // === Strings ================================================
        private const string String03FC = "There is a teleport in the west wall.";
        private const string String0422 = "You sip from the Fountain of Restoration, but nothing happens.";
        private const string String0461 = "You find the Fountain of Restoration and sip from it. You feel your Health greatly improve.";
        private const string String04BD = "Monsters attack you.";
        private const string String04D2 = "Among a horde of Nightmares and Cockatrices you spot armor and other items on the floor.";
        private const string String052B = "The door opens easily when you use the Lava Key.";
        private const string String055C = "This door cannot be unlocked without the Lava Key.";
        private const string String058F = "You manage to force the door open.";
        private const string String05B2 = "The door is stuck.";
        private const string String05C5 = "You encounter a Human Thief.";
        private const string String05E2 = "Find the Fountain of Tranquility if you are battle weary. Find it - if you can.";
        private const string String0632 = "The Human Thief cringes in terror and wraps herself up in a tight ball.";
        private const string String067A = "You encounter an Elf Barbarian.";
        private const string String069A = "A halfling thief told me of a wondrous world of four seasons deep in the heart of the dungeon. Of course, I did not believe him. Thieves are such liars.";
        private const string String0733 = "The Elf Barbarian dismisses you as useless baggage and heads off to find true heroes.";
        
        // === Functions ================================================
        private void FnTELEPORT_01(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportPartyBC(party, 0x05, 0x02, 0x00, 0x33);
            L001D: return; // RETURN;
        }

        private void FnTELEMESS_02(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String03FC); // There is a teleport in the west wall.
            L0010: return; // RETURN;
        }

        private void FnFOUNBLES_03(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = GetState(party, 0x02, 0x3D);
            L0014: Compare(ax, 0x0001);
            L0017: if (JumpNotEqual) goto L0035;
            L0019: ShowPortrait(party, 0x0042);
            L0026: ShowMessage(party, String0422); // You sip from the Fountain of Restoration, but nothing happens.
            L0033: goto L0080;
            L0035: SetState(party, 0x02, 0x3D, 0x01);
            L004A: ShowPortrait(party, 0x0042);
            L0057: ax = GetMaxHits74(party);
            L005E: PushStack(party, ax);
            L005F: ax = GetCurrentHits70(party);
            L0066: dx = PopStack(party);
            L0067: dx = dx - ax;
            L0069: HealPlayer94(party, dx);
            L0073: ShowMessage(party, String0461); // You find the Fountain of Restoration and sip from it. You feel your Health greatly improve.
            L0080: return; // RETURN;
        }

        private void FnQUESTENC_04(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem50(party, 0x81);
            L0011: if (JumpEqual) goto L0043;
            L0013: AddTreasure(party, 0x01F4, 0x00, 0x00, 0xBD, 0xA5, 0xCD);
            L0034: ShowMessage(party, String04BD); // Monsters attack you.
            L0041: goto L0071;
            L0043: AddTreasure(party, 0x03E8, 0x00, 0x00, 0xA2, 0xD0, 0x81);
            L0064: ShowMessage(party, String04D2); // Among a horde of Nightmares and Cockatrices you spot armor and other items on the floor.
            L0071: ax = PartyCount(party);
            L0079: Compare(ax, 0x0001);
            L007C: if (JumpNotEqual) goto L00B7;
            L007E: AddEncounter(party, 0x01, 0x26);
            L0090: AddEncounter(party, 0x02, 0x26);
            L00A2: AddEncounter(party, 0x06, 0x23);
            L00B4: goto L01E4;
            L00B7: ax = PartyCount(party);
            L00BF: Compare(ax, 0x0002);
            L00C2: if (JumpNotEqual) goto L010F;
            L00C4: AddEncounter(party, 0x01, 0x27);
            L00D6: AddEncounter(party, 0x02, 0x27);
            L00E8: AddEncounter(party, 0x05, 0x24);
            L00FA: AddEncounter(party, 0x06, 0x24);
            L010C: goto L01E4;
            L010F: ax = PartyCount(party);
            L0117: Compare(ax, 0x0003);
            L011A: if (JumpNotEqual) goto L0178;
            L011C: AddEncounter(party, 0x01, 0x26);
            L012E: AddEncounter(party, 0x02, 0x27);
            L0140: AddEncounter(party, 0x03, 0x28);
            L0152: AddEncounter(party, 0x04, 0x23);
            L0164: AddEncounter(party, 0x05, 0x24);
            L0176: goto L01E4;
            L0178: AddEncounter(party, 0x01, 0x23);
            L018A: AddEncounter(party, 0x02, 0x26);
            L019C: AddEncounter(party, 0x03, 0x24);
            L01AE: AddEncounter(party, 0x04, 0x27);
            L01C0: AddEncounter(party, 0x05, 0x25);
            L01D2: AddEncounter(party, 0x06, 0x28);
            L01E4: return; // RETURN;
        }

        private void FnLKPKDORZ_05(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = UsedItem54(party, 0xE2, 0xE2);
            L0016: if (JumpEqual) goto L0063;
            L0018: PushStack(party, 0x01);
            L001C: ax = GetFacing24(party);
            L0023: PushStack(party, ax);
            L0024: ax = GetCurrentTile20(party);
            L002B: PushStack(party, ax);
            L002C: SetWallPassable2C(party, PopStack(party), PopStack(party), PopStack(party));
            L0036: ax = GetFacing24(party);
            L003D: PushStack(party, ax);
            L003E: ax = GetCurrentTile20(party);
            L0045: PushStack(party, ax);
            L0046: PushStack(party, 0x01);
            L004A: SetWallObject30(party, PopStack(party), PopStack(party), PopStack(party));
            L0054: ShowMessage(party, String052B); // The door opens easily when you use the Lava Key.
            L0061: goto L008D;
            L0063: PushStack(party, 0x00);
            L0066: ax = GetFacing24(party);
            L006D: PushStack(party, ax);
            L006E: ax = GetCurrentTile20(party);
            L0075: PushStack(party, ax);
            L0076: SetWallPassable2C(party, PopStack(party), PopStack(party), PopStack(party));
            L0080: ShowMessage(party, String055C); // This door cannot be unlocked without the Lava Key.
            L008D: return; // RETURN;
        }

        private void FnSTRDOOR_06(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckStrengthA4(party);
            L000F: Compare(ax, 0x000E);
            L0012: if (JumpBelow) goto L005F;
            L0014: ShowMessage(party, String058F); // You manage to force the door open.
            L0021: ax = GetFacing24(party);
            L0028: PushStack(party, ax);
            L0029: ax = GetCurrentTile20(party);
            L0030: PushStack(party, ax);
            L0031: PushStack(party, 0x01);
            L0035: SetWallObject30(party, PopStack(party), PopStack(party), PopStack(party));
            L003F: PushStack(party, 0x01);
            L0043: ax = GetFacing24(party);
            L004A: PushStack(party, ax);
            L004B: ax = GetCurrentTile20(party);
            L0052: PushStack(party, ax);
            L0053: SetWallPassable2C(party, PopStack(party), PopStack(party), PopStack(party));
            L005D: goto L0089;
            L005F: ShowMessage(party, String05B2); // The door is stuck.
            L006C: PushStack(party, 0x00);
            L006F: ax = GetFacing24(party);
            L0076: PushStack(party, ax);
            L0077: ax = GetCurrentTile20(party);
            L007E: PushStack(party, ax);
            L007F: SetWallPassable2C(party, PopStack(party), PopStack(party), PopStack(party));
            L0089: return; // RETURN;
        }

        private void FnAVEMNSTR_0B(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = PartyCount(party);
            L000B: Compare(ax, 0x0001);
            L000E: if (JumpNotEqual) goto L0025;
            L0010: AddEncounter(party, 0x02, 0x1B);
            L0022: goto L012E;
            L0025: ax = PartyCount(party);
            L002D: Compare(ax, 0x0002);
            L0030: if (JumpNotEqual) goto L006B;
            L0032: AddEncounter(party, 0x01, 0x1C);
            L0044: AddEncounter(party, 0x02, 0x19);
            L0056: AddEncounter(party, 0x03, 0x18);
            L0068: goto L012E;
            L006B: ax = PartyCount(party);
            L0073: Compare(ax, 0x0003);
            L0076: if (JumpNotEqual) goto L00C2;
            L0078: AddEncounter(party, 0x01, 0x1B);
            L008A: AddEncounter(party, 0x02, 0x1C);
            L009C: AddEncounter(party, 0x03, 0x1A);
            L00AE: AddEncounter(party, 0x04, 0x19);
            L00C0: goto L012E;
            L00C2: AddEncounter(party, 0x01, 0x1A);
            L00D4: AddEncounter(party, 0x02, 0x1C);
            L00E6: AddEncounter(party, 0x03, 0x19);
            L00F8: AddEncounter(party, 0x04, 0x1B);
            L010A: AddEncounter(party, 0x05, 0x1D);
            L011C: AddEncounter(party, 0x06, 0x1A);
            L012E: return; // RETURN;
        }

        private void FnSTRMNSTR_0C(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = PartyCount(party);
            L000B: Compare(ax, 0x0001);
            L000E: if (JumpNotEqual) goto L0037;
            L0010: AddEncounter(party, 0x01, 0x1E);
            L0022: AddEncounter(party, 0x02, 0x20);
            L0034: goto L0152;
            L0037: ax = PartyCount(party);
            L003F: Compare(ax, 0x0002);
            L0042: if (JumpNotEqual) goto L007D;
            L0044: AddEncounter(party, 0x01, 0x1E);
            L0056: AddEncounter(party, 0x02, 0x20);
            L0068: AddEncounter(party, 0x03, 0x20);
            L007A: goto L0152;
            L007D: ax = PartyCount(party);
            L0085: Compare(ax, 0x0003);
            L0088: if (JumpNotEqual) goto L00E6;
            L008A: AddEncounter(party, 0x01, 0x1E);
            L009C: AddEncounter(party, 0x02, 0x1E);
            L00AE: AddEncounter(party, 0x03, 0x20);
            L00C0: AddEncounter(party, 0x04, 0x20);
            L00D2: AddEncounter(party, 0x05, 0x1F);
            L00E4: goto L0152;
            L00E6: AddEncounter(party, 0x01, 0x1E);
            L00F8: AddEncounter(party, 0x02, 0x1E);
            L010A: AddEncounter(party, 0x03, 0x1F);
            L011C: AddEncounter(party, 0x04, 0x1F);
            L012E: AddEncounter(party, 0x05, 0x20);
            L0140: AddEncounter(party, 0x06, 0x20);
            L0152: return; // RETURN;
        }

        private void FnNPCCHATA_0E(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String05C5); // You encounter a Human Thief.
            L0010: ShowPortrait(party, 0x0022);
            L001D: ax = GetRandom(party, 0x000F);
            L002A: Compare(ax, 0x000C);
            L002D: if (JumpAbove) goto L003E;
            L002F: ShowMessage(party, String05E2); // Find the Fountain of Tranquility if you are battle weary. Find it - if you can.
            L003C: goto L004B;
            L003E: ShowMessage(party, String0632); // The Human Thief cringes in terror and wraps herself up in a tight ball.
            L004B: return; // RETURN;
        }

        private void FnNPCCHATB_0F(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String067A); // You encounter an Elf Barbarian.
            L0010: ShowPortrait(party, 0x0018);
            L001D: ax = GetRandom(party, 0x000F);
            L002A: Compare(ax, 0x0004);
            L002D: if (JumpAbove) goto L003E;
            L002F: ShowMessage(party, String069A); // A halfling thief told me of a wondrous world of four seasons deep in the heart of the dungeon. Of course, I did not believe him. Thieves are such liars.
            L003C: goto L004B;
            L003E: ShowMessage(party, String0733); // The Elf Barbarian dismisses you as useless baggage and heads off to find true heroes.
            L004B: return; // RETURN;
        }

    }
}
