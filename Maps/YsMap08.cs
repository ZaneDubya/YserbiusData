namespace ZCF.Scripts.Maps {
    class YserMap08 : ACanoMapScript {
        // === Strings ================================================
        private const string String03FC = "The O Rune Key unlocked the door.";
        private const string String041E = "The door is locked. It requires a special key.";
        private const string String044D = "Skeletons on the floor stir to life.";
        private const string String0472 = "Among the bones on the floor are pieces of gold. The bones begin to move.";
        private const string String04BC = "A clutch of Large-Uns growl at you.";
        private const string String04E0 = "A Large-Un tosses a piece of wood aside as he and his friends attack.";
        private const string String0526 = "You have interrupted a Lizardite religious service.";
        private const string String055A = "As you enter the room, the O Rune Key vanishes.";
        private const string String058A = "You see a Lizardite proudly wearing the Crown of King Cleowyn.";
        private const string String05C9 = "You run into the living skeletons of King Cleowyn's guards.";
        private const string String0605 = "One of the skeletons approaching you holds a piece of paper in its bony hand.";
        private const string String0653 = "Reptilian bodies stir as you draw near.";
        private const string String067B = "The stairs through the west gateway lead down a level.";
        private const string String06B2 = "A Human Wizard teleports into the room you occupy.";
        private const string String06E5 = "Be careful when you find the way to open the door that leads to the nether depths of this dungeon.";
        private const string String0748 = "All quest items from Cleowyn's Palace levels will be stripped from you.";
        private const string String0790 = "But if you are indeed ready to enter the lower depths, you will no longer need Cleowyn's toys.";
        private const string String07EF = "The Human Wizard smiles sheepishly and teleports somewhere else.";
        private const string String0830 = "You encounter a sleepy Troll Knight.";
        private const string String0855 = "The Galabryan kings brought the great wizard Arnakkian Slowfoot to Twinion. The island grew famous and rich thanks to this wizard.";
        private const string String08D8 = "But the wizard had his own schemes, and soon he and good King Leowyn Galabryan were at loggerheads. Supposedly, the wizard had the king assassinated.";
        private const string String096E = "The Troll Knight blinks at you dumbly and falls asleep.";
        
        // === Functions ================================================
        private override MapEventHandler MapEvent01 => FnSTRSTELE_01;
        private void FnSTRSTELE_01(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetMoveMap(party, 0x03, 0xC2, 0x01, 0x03);
            L001E: // RETURN;
        }

        private override MapEventHandler MapEvent02 => FnKEYDOOR_02;
        private void FnKEYDOOR_02(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = UsedItem54(party, 0xDA, 0xDA);
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
            L0054: ShowMessage(party, String03FC); // The O Rune Key unlocked the door.
            L0061: goto L008D;
            L0063: PushStack(0x00);
            L0066: ax = GetFacing24(party);
            L006D: PushStack(ax);
            L006E: ax = GetNextTile20(party);
            L0075: PushStack(ax);
            L0076: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L0080: ShowMessage(party, String041E); // The door is locked. It requires a special key.
            L008D: // RETURN;
        }

        private override MapEventHandler MapEvent03 => FnGOLDAENC_03;
        private void FnGOLDAENC_03(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x02, 0x18);
            L0014: compare(ax, 0x0001);
            L0017: if (result.notequal) goto L0047;
            L0019: ShowMessage(party, String044D); // Skeletons on the floor stir to life.
            L0026: AddTreasure(party, 0x03E8, 0x00, 0x00, 0x00, 0x00, 0xB6);
            L0045: goto L0088;
            L0047: AddTreasure(party, 0x1388, 0x00, 0x00, 0x00, 0x00, 0xCF);
            L0066: SetState00(party, 0x02, 0x18, 0x01);
            L007B: ShowMessage(party, String0472); // Among the bones on the floor are pieces of gold. The bones begin to move.
            L0088: ax = PartyCount(party);
            L0090: compare(ax, 0x0001);
            L0093: if (result.notequal) goto L00AA;
            L0095: AddEncounter(party, 0x01, 0x01);
            L00A7: goto L0144;
            L00AA: ax = PartyCount(party);
            L00B2: compare(ax, 0x0002);
            L00B5: if (result.equal) goto L00C4;
            L00B7: ax = PartyCount(party);
            L00BF: compare(ax, 0x0003);
            L00C2: if (result.notequal) goto L00FC;
            L00C4: AddEncounter(party, 0x02, 0x01);
            L00D6: AddEncounter(party, 0x04, 0x02);
            L00E8: AddEncounter(party, 0x06, 0x03);
            L00FA: goto L0144;
            L00FC: AddEncounter(party, 0x01, 0x01);
            L010E: AddEncounter(party, 0x02, 0x02);
            L0120: AddEncounter(party, 0x03, 0x03);
            L0132: AddEncounter(party, 0x04, 0x04);
            L0144: // RETURN;
        }

        private override MapEventHandler MapEvent04 => FnGOLDBENC_04;
        private void FnGOLDBENC_04(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem50(party, 0xC6);
            L0011: if (result.equal) goto L0041;
            L0013: ShowMessage(party, String04BC); // A clutch of Large-Uns growl at you.
            L0020: AddTreasure(party, 0x07D0, 0x00, 0x00, 0x00, 0x00, 0xD1);
            L003F: goto L006D;
            L0041: AddTreasure(party, 0x1770, 0x00, 0x00, 0x00, 0x00, 0xC6);
            L0060: ShowMessage(party, String04E0); // A Large-Un tosses a piece of wood aside as he and his friends attack.
            L006D: ax = PartyCount(party);
            L0075: compare(ax, 0x0001);
            L0078: if (result.notequal) goto L00A1;
            L007A: AddEncounter(party, 0x19, 0x01);
            L008C: AddEncounter(party, 0x1A, 0x02);
            L009E: goto L0198;
            L00A1: ax = PartyCount(party);
            L00A9: compare(ax, 0x0002);
            L00AC: if (result.notequal) goto L00E7;
            L00AE: AddEncounter(party, 0x19, 0x01);
            L00C0: AddEncounter(party, 0x1A, 0x02);
            L00D2: AddEncounter(party, 0x19, 0x03);
            L00E4: goto L0198;
            L00E7: ax = PartyCount(party);
            L00EF: compare(ax, 0x0003);
            L00F2: if (result.notequal) goto L013E;
            L00F4: AddEncounter(party, 0x1A, 0x01);
            L0106: AddEncounter(party, 0x1A, 0x02);
            L0118: AddEncounter(party, 0x1B, 0x03);
            L012A: AddEncounter(party, 0x1B, 0x04);
            L013C: goto L0198;
            L013E: AddEncounter(party, 0x1B, 0x01);
            L0150: AddEncounter(party, 0x1B, 0x02);
            L0162: AddEncounter(party, 0x1B, 0x03);
            L0174: AddEncounter(party, 0x1B, 0x04);
            L0186: AddEncounter(party, 0x1C, 0x05);
            L0198: // RETURN;
        }

        private override MapEventHandler MapEvent05 => FnCROWN_05;
        private void FnCROWN_05(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem50(party, 0x69);
            L0011: if (result.equal) goto L0041;
            L0013: ShowMessage(party, String0526); // You have interrupted a Lizardite religious service.
            L0020: AddTreasure(party, 0x01F4, 0x00, 0x00, 0x00, 0x00, 0xD0);
            L003F: goto L0087;
            L0041: AddTreasure(party, 0x07D0, 0x00, 0x00, 0x00, 0xCF, 0x69);
            L0061: RemoveItem4C(party, 0xDA);
            L006D: ShowMessage(party, String055A); // As you enter the room, the O Rune Key vanishes.
            L007A: ShowMessage(party, String058A); // You see a Lizardite proudly wearing the Crown of King Cleowyn.
            L0087: ax = PartyCount(party);
            L008F: compare(ax, 0x0001);
            L0092: if (result.notequal) goto L00BB;
            L0094: AddEncounter(party, 0x21, 0x01);
            L00A6: AddEncounter(party, 0x21, 0x02);
            L00B8: goto L018B;
            L00BB: ax = PartyCount(party);
            L00C3: compare(ax, 0x0002);
            L00C6: if (result.equal) goto L00D5;
            L00C8: ax = PartyCount(party);
            L00D0: compare(ax, 0x0003);
            L00D3: if (result.notequal) goto L011F;
            L00D5: AddEncounter(party, 0x21, 0x01);
            L00E7: AddEncounter(party, 0x21, 0x02);
            L00F9: AddEncounter(party, 0x21, 0x03);
            L010B: AddEncounter(party, 0x21, 0x05);
            L011D: goto L018B;
            L011F: AddEncounter(party, 0x21, 0x01);
            L0131: AddEncounter(party, 0x21, 0x02);
            L0143: AddEncounter(party, 0x21, 0x03);
            L0155: AddEncounter(party, 0x21, 0x04);
            L0167: AddEncounter(party, 0x21, 0x05);
            L0179: AddEncounter(party, 0x21, 0x06);
            L018B: // RETURN;
        }

        private override MapEventHandler MapEvent06 => FnITEMBENC_06;
        private void FnITEMBENC_06(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem50(party, 0xBB);
            L0011: if (result.equal) goto L0041;
            L0013: ShowMessage(party, String05C9); // You run into the living skeletons of King Cleowyn's guards.
            L0020: AddTreasure(party, 0x0320, 0x00, 0x00, 0x00, 0x00, 0xBC);
            L003F: goto L006D;
            L0041: AddTreasure(party, 0x1B58, 0x00, 0x00, 0x00, 0x00, 0xBB);
            L0060: ShowMessage(party, String0605); // One of the skeletons approaching you holds a piece of paper in its bony hand.
            L006D: ax = PartyCount(party);
            L0075: compare(ax, 0x0001);
            L0078: if (result.notequal) goto L008F;
            L007A: AddEncounter(party, 0x15, 0x01);
            L008C: goto L0129;
            L008F: ax = PartyCount(party);
            L0097: compare(ax, 0x0002);
            L009A: if (result.equal) goto L00A9;
            L009C: ax = PartyCount(party);
            L00A4: compare(ax, 0x0003);
            L00A7: if (result.notequal) goto L00E1;
            L00A9: AddEncounter(party, 0x15, 0x01);
            L00BB: AddEncounter(party, 0x16, 0x02);
            L00CD: AddEncounter(party, 0x17, 0x03);
            L00DF: goto L0129;
            L00E1: AddEncounter(party, 0x15, 0x01);
            L00F3: AddEncounter(party, 0x17, 0x02);
            L0105: AddEncounter(party, 0x16, 0x03);
            L0117: AddEncounter(party, 0x18, 0x04);
            L0129: // RETURN;
        }

        private override MapEventHandler MapEvent07 => FnITEMCENC_07;
        private void FnITEMCENC_07(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem50(party, 0x64);
            L0011: if (result.equal) goto L0065;
            L0013: ax = HasItem50(party, 0x94);
            L0021: if (result.equal) goto L0044;
            L0023: AddTreasure(party, 0x01F4, 0x00, 0x00, 0x00, 0x00, 0xBD);
            L0042: goto L0063;
            L0044: AddTreasure(party, 0x07D0, 0x00, 0x00, 0x00, 0x00, 0x94);
            L0063: goto L00B6;
            L0065: ax = HasItem50(party, 0x94);
            L0073: if (result.equal) goto L0096;
            L0075: AddTreasure(party, 0x07D0, 0x00, 0x00, 0x00, 0x00, 0x64);
            L0094: goto L00B6;
            L0096: AddTreasure(party, 0x07D0, 0x00, 0x00, 0x00, 0x64, 0x94);
            L00B6: ShowMessage(party, String0653); // Reptilian bodies stir as you draw near.
            L00C3: ax = PartyCount(party);
            L00CB: compare(ax, 0x0001);
            L00CE: if (result.notequal) goto L00E5;
            L00D0: AddEncounter(party, 0x23, 0x01);
            L00E2: goto L017F;
            L00E5: ax = PartyCount(party);
            L00ED: compare(ax, 0x0002);
            L00F0: if (result.equal) goto L00FF;
            L00F2: ax = PartyCount(party);
            L00FA: compare(ax, 0x0003);
            L00FD: if (result.notequal) goto L0137;
            L00FF: AddEncounter(party, 0x23, 0x01);
            L0111: AddEncounter(party, 0x23, 0x02);
            L0123: AddEncounter(party, 0x23, 0x03);
            L0135: goto L017F;
            L0137: AddEncounter(party, 0x23, 0x01);
            L0149: AddEncounter(party, 0x23, 0x02);
            L015B: AddEncounter(party, 0x23, 0x03);
            L016D: AddEncounter(party, 0x23, 0x04);
            L017F: // RETURN;
        }

        private override MapEventHandler MapEvent08 => FnSTRMNSTR_08;
        private void FnSTRMNSTR_08(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = PartyCount(party);
            L000B: compare(ax, 0x0001);
            L000E: if (result.notequal) goto L0037;
            L0010: AddEncounter(party, 0x19, 0x01);
            L0022: AddEncounter(party, 0x1A, 0x02);
            L0034: goto L0152;
            L0037: ax = PartyCount(party);
            L003F: compare(ax, 0x0002);
            L0042: if (result.notequal) goto L007D;
            L0044: AddEncounter(party, 0x19, 0x01);
            L0056: AddEncounter(party, 0x1A, 0x02);
            L0068: AddEncounter(party, 0x19, 0x03);
            L007A: goto L0152;
            L007D: ax = PartyCount(party);
            L0085: compare(ax, 0x0003);
            L0088: if (result.notequal) goto L00E6;
            L008A: AddEncounter(party, 0x1A, 0x01);
            L009C: AddEncounter(party, 0x1A, 0x02);
            L00AE: AddEncounter(party, 0x1B, 0x03);
            L00C0: AddEncounter(party, 0x1B, 0x04);
            L00D2: AddEncounter(party, 0x1C, 0x05);
            L00E4: goto L0152;
            L00E6: AddEncounter(party, 0x1B, 0x01);
            L00F8: AddEncounter(party, 0x1B, 0x02);
            L010A: AddEncounter(party, 0x1B, 0x03);
            L011C: AddEncounter(party, 0x1B, 0x04);
            L012E: AddEncounter(party, 0x1C, 0x05);
            L0140: AddEncounter(party, 0x1C, 0x06);
            L0152: // RETURN;
        }

        private override MapEventHandler MapEvent09 => FnTUFMNSTR_09;
        private void FnTUFMNSTR_09(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = PartyCount(party);
            L000B: compare(ax, 0x0001);
            L000E: if (result.notequal) goto L0025;
            L0010: AddEncounter(party, 0x21, 0x01);
            L0022: goto L010A;
            L0025: ax = PartyCount(party);
            L002D: compare(ax, 0x0002);
            L0030: if (result.notequal) goto L0059;
            L0032: AddEncounter(party, 0x21, 0x01);
            L0044: AddEncounter(party, 0x21, 0x02);
            L0056: goto L010A;
            L0059: ax = PartyCount(party);
            L0061: compare(ax, 0x0003);
            L0064: if (result.notequal) goto L00B0;
            L0066: AddEncounter(party, 0x21, 0x01);
            L0078: AddEncounter(party, 0x21, 0x02);
            L008A: AddEncounter(party, 0x21, 0x03);
            L009C: AddEncounter(party, 0x21, 0x04);
            L00AE: goto L010A;
            L00B0: AddEncounter(party, 0x21, 0x01);
            L00C2: AddEncounter(party, 0x21, 0x02);
            L00D4: AddEncounter(party, 0x21, 0x03);
            L00E6: AddEncounter(party, 0x21, 0x04);
            L00F8: AddEncounter(party, 0x21, 0x05);
            L010A: // RETURN;
        }

        private override MapEventHandler MapEvent0A => FnSTRSMESS_0A;
        private void FnSTRSMESS_0A(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String067B); // The stairs through the west gateway lead down a level.
            L0010: // RETURN;
        }

        private override MapEventHandler MapEvent0B => FnNPCCHATA_0B;
        private void FnNPCCHATA_0B(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String06B2); // A Human Wizard teleports into the room you occupy.
            L0010: ShowPortrait(party, 0x002B);
            L001D: ax = UnknownFunctionEC(party, 0x000F);
            L002A: compare(ax, 0x000B);
            L002D: if (result.unsigned_greater_than) goto L0058;
            L002F: ShowMessage(party, String06E5); // Be careful when you find the way to open the door that leads to the nether depths of this dungeon.
            L003C: ShowMessage(party, String0748); // All quest items from Cleowyn's Palace levels will be stripped from you.
            L0049: ShowMessage(party, String0790); // But if you are indeed ready to enter the lower depths, you will no longer need Cleowyn's toys.
            L0056: goto L0065;
            L0058: ShowMessage(party, String07EF); // The Human Wizard smiles sheepishly and teleports somewhere else.
            L0065: // RETURN;
        }

        private override MapEventHandler MapEvent0C => FnNPCCHATB_0C;
        private void FnNPCCHATB_0C(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0830); // You encounter a sleepy Troll Knight.
            L0010: ShowPortrait(party, 0x001B);
            L001D: ax = UnknownFunctionEC(party, 0x000F);
            L002A: compare(ax, 0x0009);
            L002D: if (result.unsigned_greater_than) goto L004B;
            L002F: ShowMessage(party, String0855); // The Galabryan kings brought the great wizard Arnakkian Slowfoot to Twinion. The island grew famous and rich thanks to this wizard.
            L003C: ShowMessage(party, String08D8); // But the wizard had his own schemes, and soon he and good King Leowyn Galabryan were at loggerheads. Supposedly, the wizard had the king assassinated.
            L0049: goto L0058;
            L004B: ShowMessage(party, String096E); // The Troll Knight blinks at you dumbly and falls asleep.
            L0058: // RETURN;
        }

    }
}
