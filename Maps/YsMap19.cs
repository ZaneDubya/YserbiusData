namespace ZCF.Scripts.Maps {
    class YserMap19 : ACanoMapScript {
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
        private override MapEventHandler MapEvent01 => TELEPORT_01;
        private void TELEPORT_01(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetMoveMap(party, 0x33, 0x00, 0x02, 0x05);
            L001D: // RETURN;
        }

        private override MapEventHandler MapEvent02 => TELEMESS_02;
        private void TELEMESS_02(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String03FC); // There is a teleport in the west wall.
            L0010: // RETURN;
        }

        private override MapEventHandler MapEvent03 => FOUNBLES_03;
        private void FOUNBLES_03(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x02, 0x3D);
            L0014: compare(ax, 0x0001);
            L0017: if (result.notequal) goto L0035;
            L0019: ShowPortrait(party, 0x0042);
            L0026: ShowMessage(party, String0422); // You sip from the Fountain of Restoration, but nothing happens.
            L0033: goto L0080;
            L0035: SetState00(party, 0x02, 0x3D, 0x01);
            L004A: ShowPortrait(party, 0x0042);
            L0057: ax = GetMaxHits74(party);
            L005E: PushStack(ax);
            L005F: ax = GetCurrentHits70(party);
            L0066: dx = PopStack();
            L0067: dx = dx - ax;
            L0069: AddHealth94(party, dx);
            L0073: ShowMessage(party, String0461); // You find the Fountain of Restoration and sip from it. You feel your Health greatly improve.
            L0080: // RETURN;
        }

        private override MapEventHandler MapEvent04 => QUESTENC_04;
        private void QUESTENC_04(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem50(party, 0x81);
            L0011: if (result.equal) goto L0043;
            L0013: AddTreasure(party, 0x01F4, 0x00, 0x00, 0xBD, 0xA5, 0xCD);
            L0034: ShowMessage(party, String04BD); // Monsters attack you.
            L0041: goto L0071;
            L0043: AddTreasure(party, 0x03E8, 0x00, 0x00, 0xA2, 0xD0, 0x81);
            L0064: ShowMessage(party, String04D2); // Among a horde of Nightmares and Cockatrices you spot armor and other items on the floor.
            L0071: ax = PartyCount(party);
            L0079: compare(ax, 0x0001);
            L007C: if (result.notequal) goto L00B7;
            L007E: AddEncounter(party, 0x26, 0x01);
            L0090: AddEncounter(party, 0x26, 0x02);
            L00A2: AddEncounter(party, 0x23, 0x06);
            L00B4: goto L01E4;
            L00B7: ax = PartyCount(party);
            L00BF: compare(ax, 0x0002);
            L00C2: if (result.notequal) goto L010F;
            L00C4: AddEncounter(party, 0x27, 0x01);
            L00D6: AddEncounter(party, 0x27, 0x02);
            L00E8: AddEncounter(party, 0x24, 0x05);
            L00FA: AddEncounter(party, 0x24, 0x06);
            L010C: goto L01E4;
            L010F: ax = PartyCount(party);
            L0117: compare(ax, 0x0003);
            L011A: if (result.notequal) goto L0178;
            L011C: AddEncounter(party, 0x26, 0x01);
            L012E: AddEncounter(party, 0x27, 0x02);
            L0140: AddEncounter(party, 0x28, 0x03);
            L0152: AddEncounter(party, 0x23, 0x04);
            L0164: AddEncounter(party, 0x24, 0x05);
            L0176: goto L01E4;
            L0178: AddEncounter(party, 0x23, 0x01);
            L018A: AddEncounter(party, 0x26, 0x02);
            L019C: AddEncounter(party, 0x24, 0x03);
            L01AE: AddEncounter(party, 0x27, 0x04);
            L01C0: AddEncounter(party, 0x25, 0x05);
            L01D2: AddEncounter(party, 0x28, 0x06);
            L01E4: // RETURN;
        }

        private override MapEventHandler MapEvent05 => LKPKDORZ_05;
        private void LKPKDORZ_05(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = UsedItem54(party, 0xE2, 0xE2);
            L0016: if (result.equal) goto L0063;
            L0018: Push(01);
            L001C: ax = GetFacing24(party);
            L0023: PushStack(ax);
            L0024: ax = GetNextTile20(party);
            L002B: PushStack(ax);
            L002C: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L0036: ax = GetFacing24(party);
            L003D: PushStack(ax);
            L003E: ax = GetNextTile20(party);
            L0045: PushStack(ax);
            L0046: Push(01);
            L004A: SetUnblocked30(party);
            L0054: ShowMessage(party, String052B); // The door opens easily when you use the Lava Key.
            L0061: goto L008D;
            L0063: PushStack(0x00);
            L0066: ax = GetFacing24(party);
            L006D: PushStack(ax);
            L006E: ax = GetNextTile20(party);
            L0075: PushStack(ax);
            L0076: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L0080: ShowMessage(party, String055C); // This door cannot be unlocked without the Lava Key.
            L008D: // RETURN;
        }

        private override MapEventHandler MapEvent06 => STRDOOR_06;
        private void STRDOOR_06(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckStrengthA4(party);
            L000F: compare(ax, 0x000E);
            L0012: if (result.below) goto L005F;
            L0014: ShowMessage(party, String058F); // You manage to force the door open.
            L0021: ax = GetFacing24(party);
            L0028: PushStack(ax);
            L0029: ax = GetNextTile20(party);
            L0030: PushStack(ax);
            L0031: Push(01);
            L0035: SetUnblocked30(party);
            L003F: Push(01);
            L0043: ax = GetFacing24(party);
            L004A: PushStack(ax);
            L004B: ax = GetNextTile20(party);
            L0052: PushStack(ax);
            L0053: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L005D: goto L0089;
            L005F: ShowMessage(party, String05B2); // The door is stuck.
            L006C: PushStack(0x00);
            L006F: ax = GetFacing24(party);
            L0076: PushStack(ax);
            L0077: ax = GetNextTile20(party);
            L007E: PushStack(ax);
            L007F: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L0089: // RETURN;
        }

        private override MapEventHandler MapEvent0B => AVEMNSTR_0B;
        private void AVEMNSTR_0B(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = PartyCount(party);
            L000B: compare(ax, 0x0001);
            L000E: if (result.notequal) goto L0025;
            L0010: AddEncounter(party, 0x1B, 0x02);
            L0022: goto L012E;
            L0025: ax = PartyCount(party);
            L002D: compare(ax, 0x0002);
            L0030: if (result.notequal) goto L006B;
            L0032: AddEncounter(party, 0x1C, 0x01);
            L0044: AddEncounter(party, 0x19, 0x02);
            L0056: AddEncounter(party, 0x18, 0x03);
            L0068: goto L012E;
            L006B: ax = PartyCount(party);
            L0073: compare(ax, 0x0003);
            L0076: if (result.notequal) goto L00C2;
            L0078: AddEncounter(party, 0x1B, 0x01);
            L008A: AddEncounter(party, 0x1C, 0x02);
            L009C: AddEncounter(party, 0x1A, 0x03);
            L00AE: AddEncounter(party, 0x19, 0x04);
            L00C0: goto L012E;
            L00C2: AddEncounter(party, 0x1A, 0x01);
            L00D4: AddEncounter(party, 0x1C, 0x02);
            L00E6: AddEncounter(party, 0x19, 0x03);
            L00F8: AddEncounter(party, 0x1B, 0x04);
            L010A: AddEncounter(party, 0x1D, 0x05);
            L011C: AddEncounter(party, 0x1A, 0x06);
            L012E: // RETURN;
        }

        private override MapEventHandler MapEvent0C => STRMNSTR_0C;
        private void STRMNSTR_0C(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = PartyCount(party);
            L000B: compare(ax, 0x0001);
            L000E: if (result.notequal) goto L0037;
            L0010: AddEncounter(party, 0x1E, 0x01);
            L0022: AddEncounter(party, 0x20, 0x02);
            L0034: goto L0152;
            L0037: ax = PartyCount(party);
            L003F: compare(ax, 0x0002);
            L0042: if (result.notequal) goto L007D;
            L0044: AddEncounter(party, 0x1E, 0x01);
            L0056: AddEncounter(party, 0x20, 0x02);
            L0068: AddEncounter(party, 0x20, 0x03);
            L007A: goto L0152;
            L007D: ax = PartyCount(party);
            L0085: compare(ax, 0x0003);
            L0088: if (result.notequal) goto L00E6;
            L008A: AddEncounter(party, 0x1E, 0x01);
            L009C: AddEncounter(party, 0x1E, 0x02);
            L00AE: AddEncounter(party, 0x20, 0x03);
            L00C0: AddEncounter(party, 0x20, 0x04);
            L00D2: AddEncounter(party, 0x1F, 0x05);
            L00E4: goto L0152;
            L00E6: AddEncounter(party, 0x1E, 0x01);
            L00F8: AddEncounter(party, 0x1E, 0x02);
            L010A: AddEncounter(party, 0x1F, 0x03);
            L011C: AddEncounter(party, 0x1F, 0x04);
            L012E: AddEncounter(party, 0x20, 0x05);
            L0140: AddEncounter(party, 0x20, 0x06);
            L0152: // RETURN;
        }

        private override MapEventHandler MapEvent0E => NPCCHATA_0E;
        private void NPCCHATA_0E(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String05C5); // You encounter a Human Thief.
            L0010: ShowPortrait(party, 0x0022);
            L001D: ax = UnknownFunctionEC(party, 0x000F);
            L002A: compare(ax, 0x000C);
            L002D: if (result.unsigned_greater_than) goto L003E;
            L002F: ShowMessage(party, String05E2); // Find the Fountain of Tranquility if you are battle weary. Find it - if you can.
            L003C: goto L004B;
            L003E: ShowMessage(party, String0632); // The Human Thief cringes in terror and wraps herself up in a tight ball.
            L004B: // RETURN;
        }

        private override MapEventHandler MapEvent0F => NPCCHATB_0F;
        private void NPCCHATB_0F(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String067A); // You encounter an Elf Barbarian.
            L0010: ShowPortrait(party, 0x0018);
            L001D: ax = UnknownFunctionEC(party, 0x000F);
            L002A: compare(ax, 0x0004);
            L002D: if (result.unsigned_greater_than) goto L003E;
            L002F: ShowMessage(party, String069A); // A halfling thief told me of a wondrous world of four seasons deep in the heart of the dungeon. Of course, I did not believe him. Thieves are such liars.
            L003C: goto L004B;
            L003E: ShowMessage(party, String0733); // The Elf Barbarian dismisses you as useless baggage and heads off to find true heroes.
            L004B: // RETURN;
        }

    }
}
