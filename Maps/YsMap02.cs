#pragma warning disable
using XPT.WorldData;

namespace XPT.Scripts.Maps {
    class YserMap02 : AMapScript {
        protected override int MapIndex => 2;
        
        public YserMap02() {
            MapEvent01 = FnTOMINES_01;
            MapEvent02 = FnTOTREAS_02;
            MapEvent03 = FnKEYDOOR_03;
            MapEvent04 = FnKEYMESSG_04;
            MapEvent05 = FnLKPKDOOR_05;
            MapEvent06 = FnLKPKMESG_06;
            MapEvent07 = FnSTRDOOR_07;
            MapEvent08 = FnSTRMESSG_08;
            MapEvent09 = FnGOLDENC_09;
            MapEvent0A = FnSTAIRS_0A;
            MapEvent0B = FnPALKEYEN_0B;
            MapEvent0C = FnTELEPORT_0C;
            MapEvent0D = FnLOWMNSTR_0D;
            MapEvent0E = FnMODMNSTR_0E;
            MapEvent0F = FnSTRMNST_0F;
            MapEvent10 = FnBADMNSTR_10;
            MapEvent11 = FnMESSAGEA_11;
            MapEvent12 = FnMESSAGEB_12;
            MapEvent13 = FnTELEMESS_13;
            MapEvent14 = FnSTRSMESS_14;
            MapEvent15 = FnSTRSTLPT_15;
            MapEvent16 = FnREGDOOR_16;
            MapEvent17 = FnNPCCHATA_17;
            MapEvent18 = FnNPCCHATB_18;
            MapEvent19 = FnNPCCHATC_19;
            MapEvent1A = FnNPCCHATD_1A;
            MapEvent1B = FnNPCCHATE_1B;
            MapEvent1C = FnKEYDRA_1C;
            MapEvent1D = FnLKPKDRA_1D;
            MapEvent1E = FnSTRNGDRA_1E;
            MapEvent1F = FnREGDORA_1F;
        }
        
        // === Strings ================================================
        private const string String03FC = "Cleowyn's Key has unlocked the door.";
        private const string String0421 = "The door is locked.  Something special is needed to open this door.";
        private const string String0465 = "The tapestry shows a message in runes...";
        private const string String048E = "A certain Key unlocks my series of doors.";
        private const string String04B8 = "Cleowyn's Lockpick has unlocked the door.";
        private const string String04E2 = "The door is locked.";
        private const string String04F6 = "There are runes on the tapestry...";
        private const string String0519 = "A certain Lockpick opens my series of doors.";
        private const string String0546 = "The door has been forced open.";
        private const string String0565 = "The door is currently impassable.";
        private const string String0587 = "The tapestry has runes...";
        private const string String05A1 = "A hero of strength may open my series of doors.";
        private const string String05D1 = "Aside from angry Rogues, the room is empty.";
        private const string String05FD = "A Rogue drops gold coins on the floor as the villains draw their weapons.";
        private const string String0647 = "The room is empty. Almost.";
        private const string String0662 = "A Key in the shape of a Palace lies in a corner, if you can get to it.";
        private const string String06A9 = "You encounter Rogues.";
        private const string String06BF = "If you are skilled enough, you may find teleports that speed your way to various levels of this dungeon.";
        private const string String0728 = "The Rogues snarl at you.";
        private const string String0741 = "They attack!";
        private const string String074E = "This gateway leads to THE MINES.";
        private const string String076F = "This gateway leads to THE HALL OF DOORS.";
        private const string String0798 = "There is a teleport to the north.";
        private const string String07BA = "There are stairs to the west through the gateway.";
        private const string String07EC = "As you open the door, you hear locks click throughout the dungeon.";
        private const string String082F = "The door is currently impassable.";
        private const string String0851 = "You encounter an Elf Ranger.";
        private const string String086E = "You must solve the mystery of the linked Vestibule doors to continue farther down into the dungeon.";
        private const string String08D2 = "The Elf Ranger decides you are not worthy of his time and leaves.";
        private const string String0914 = "You encounter a Human Wizard.";
        private const string String0932 = "Centuries ago, Twinion was a thriving port town, ruled by the Galabryan dynasty. The kings welcomed all races and Guilds to the island. When the volcano Yserbius erupted, it almost buried Twinion under lava. If only we could find some way off this island!";
        private const string String0A32 = "The Human Wizard falls into a deep trance and refuses to talk.";
        private const string String0A71 = "You encounter a Gremlin Thief.";
        private const string String0A90 = "King Cleowyn created a clever maze of squares to discourage thieves and invaders. Mind you, no invaders ever thought Twinion rich enough to be worth their effort.";
        private const string String0B33 = "The Gremlin Thief slips into a shadow and disappears.";
        private const string String0B69 = "You encounter an Orc Knight.";
        private const string String0B86 = "The richness of fine armor and weapons in this dungeon baffles me. I've heard rumors that skilled dwarfs once crafted such armory, but the rogue dwarfs you encounter nowadays have no talent for such expert metallurgy.";
        private const string String0C60 = "The Orc Knight smiles politely and shoos you away.";
        private const string String0C93 = "You encounter an Elf Cleric.";
        private const string String0CB0 = "I have visited King Cleowyn's throne room, and what a disappointment it was. Not much treasure there and too many dead things. Perhaps I missed something.";
        private const string String0D4B = "The Elf Cleric is too engrossed in his prayers to talk with you.";
        private const string String0D8C = "Cleowyn's Key unlocks the door.";
        private const string String0DAC = "The door is locked.";
        private const string String0DC0 = "Cleowyn's Lockpick has unlocked the door.";
        private const string String0DEA = "The door is locked.  It looks like something special is needed to open this door.";
        private const string String0E3C = "You manage to force open the door.";
        private const string String0E5F = "The door is currently impassable.";
        private const string String0E81 = "As you open the door, you hear locks click throughout the dungeon.";
        private const string String0EC4 = "The door is currently impassable.";
        
        // === Functions ================================================
        private void FnTOMINES_01(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetMoveMap(party, 0x01, 0x02, 0x7F, 0x00);
            L001D: return; // RETURN;
        }

        private void FnTOTREAS_02(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetMoveMap(party, 0x01, 0x04, 0x05, 0x01);
            L001E: return; // RETURN;
        }

        private void FnKEYDOOR_03(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x02, 0x00);
            L0013: Compare(ax, 0x0001);
            L0016: if (!CompareResultEqual) goto L0063;
            L0018: ShowMessage(party, String03FC); // Cleowyn's Key has unlocked the door.
            L0025: ax = GetFacing24(party);
            L002C: PushStack(ax);
            L002D: ax = GetNextTile20(party);
            L0034: PushStack(ax);
            L0035: PushStack(0x01);
            L0039: SetUnblocked30(party);
            L0043: PushStack(0x01);
            L0047: ax = GetFacing24(party);
            L004E: PushStack(ax);
            L004F: ax = GetNextTile20(party);
            L0056: PushStack(ax);
            L0057: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L0061: goto L008D;
            L0063: ShowMessage(party, String0421); // The door is locked.  Something special is needed to open this door.
            L0070: PushStack(0x00);
            L0073: ax = GetFacing24(party);
            L007A: PushStack(ax);
            L007B: ax = GetNextTile20(party);
            L0082: PushStack(ax);
            L0083: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L008D: return; // RETURN;
        }

        private void FnKEYMESSG_04(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0465); // The tapestry shows a message in runes...
            L0010: ShowRunes(party, String048E); // A certain Key unlocks my series of doors.
            L001D: return; // RETURN;
        }

        private void FnLKPKDOOR_05(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x02, 0x00);
            L0013: Compare(ax, 0x0002);
            L0016: if (!CompareResultEqual) goto L0063;
            L0018: ShowMessage(party, String04B8); // Cleowyn's Lockpick has unlocked the door.
            L0025: ax = GetFacing24(party);
            L002C: PushStack(ax);
            L002D: ax = GetNextTile20(party);
            L0034: PushStack(ax);
            L0035: PushStack(0x01);
            L0039: SetUnblocked30(party);
            L0043: PushStack(0x01);
            L0047: ax = GetFacing24(party);
            L004E: PushStack(ax);
            L004F: ax = GetNextTile20(party);
            L0056: PushStack(ax);
            L0057: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L0061: goto L008D;
            L0063: ShowMessage(party, String04E2); // The door is locked.
            L0070: PushStack(0x00);
            L0073: ax = GetFacing24(party);
            L007A: PushStack(ax);
            L007B: ax = GetNextTile20(party);
            L0082: PushStack(ax);
            L0083: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L008D: return; // RETURN;
        }

        private void FnLKPKMESG_06(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String04F6); // There are runes on the tapestry...
            L0010: ShowRunes(party, String0519); // A certain Lockpick opens my series of doors.
            L001D: return; // RETURN;
        }

        private void FnSTRDOOR_07(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x02, 0x00);
            L0013: Compare(ax, 0x0003);
            L0016: if (!CompareResultEqual) goto L0063;
            L0018: ShowMessage(party, String0546); // The door has been forced open.
            L0025: ax = GetFacing24(party);
            L002C: PushStack(ax);
            L002D: ax = GetNextTile20(party);
            L0034: PushStack(ax);
            L0035: PushStack(0x01);
            L0039: SetUnblocked30(party);
            L0043: PushStack(0x01);
            L0047: ax = GetFacing24(party);
            L004E: PushStack(ax);
            L004F: ax = GetNextTile20(party);
            L0056: PushStack(ax);
            L0057: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L0061: goto L008D;
            L0063: ShowMessage(party, String0565); // The door is currently impassable.
            L0070: PushStack(0x00);
            L0073: ax = GetFacing24(party);
            L007A: PushStack(ax);
            L007B: ax = GetNextTile20(party);
            L0082: PushStack(ax);
            L0083: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L008D: return; // RETURN;
        }

        private void FnSTRMESSG_08(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0587); // The tapestry has runes...
            L0010: ShowRunes(party, String05A1); // A hero of strength may open my series of doors.
            L001D: return; // RETURN;
        }

        private void FnGOLDENC_09(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x02, 0x05);
            L0014: Compare(ax, 0x0001);
            L0017: if (!CompareResultEqual) goto L0047;
            L0019: ShowMessage(party, String05D1); // Aside from angry Rogues, the room is empty.
            L0026: AddTreasure(party, 0x0014, 0x00, 0x00, 0x00, 0x00, 0xB5);
            L0045: goto L0088;
            L0047: AddTreasure(party, 0x01F4, 0x00, 0x00, 0x00, 0x00, 0xCE);
            L0066: SetState00(party, 0x02, 0x05, 0x01);
            L007B: ShowMessage(party, String05FD); // A Rogue drops gold coins on the floor as the villains draw their weapons.
            L0088: ax = PartyCount(party);
            L0090: Compare(ax, 0x0001);
            L0093: if (CompareResultEqual) goto L00A2;
            L0095: ax = PartyCount(party);
            L009D: Compare(ax, 0x0002);
            L00A0: if (!CompareResultEqual) goto L00B6;
            L00A2: AddEncounter(party, 0x01, 0x1A);
            L00B4: goto L00FE;
            L00B6: AddEncounter(party, 0x01, 0x1C);
            L00C8: AddEncounter(party, 0x02, 0x1A);
            L00DA: AddEncounter(party, 0x03, 0x19);
            L00EC: AddEncounter(party, 0x04, 0x1B);
            L00FE: return; // RETURN;
        }

        private void FnSTAIRS_0A(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetMoveMap(party, 0x02, 0x02, 0x01, 0x02);
            L001E: return; // RETURN;
        }

        private void FnPALKEYEN_0B(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem50(party, 0xD9);
            L0011: if (CompareResultEqual) goto L0042;
            L0013: AddTreasure(party, 0x01F4, 0x00, 0x00, 0x00, 0xBC, 0xCE);
            L0033: ShowMessage(party, String0647); // The room is empty. Almost.
            L0040: goto L006E;
            L0042: AddTreasure(party, 0x03E8, 0x00, 0x00, 0x00, 0x00, 0xD9);
            L0061: ShowMessage(party, String0662); // A Key in the shape of a Palace lies in a corner, if you can get to it.
            L006E: ax = PartyCount(party);
            L0076: Compare(ax, 0x0001);
            L0079: if (!CompareResultEqual) goto L0090;
            L007B: AddEncounter(party, 0x01, 0x21);
            L008D: goto L0151;
            L0090: ax = PartyCount(party);
            L0098: Compare(ax, 0x0002);
            L009B: if (!CompareResultEqual) goto L00C4;
            L009D: AddEncounter(party, 0x01, 0x25);
            L00AF: AddEncounter(party, 0x02, 0x21);
            L00C1: goto L0151;
            L00C4: ax = PartyCount(party);
            L00CC: Compare(ax, 0x0003);
            L00CF: if (!CompareResultEqual) goto L0109;
            L00D1: AddEncounter(party, 0x01, 0x21);
            L00E3: AddEncounter(party, 0x02, 0x21);
            L00F5: AddEncounter(party, 0x04, 0x25);
            L0107: goto L0151;
            L0109: AddEncounter(party, 0x01, 0x25);
            L011B: AddEncounter(party, 0x02, 0x25);
            L012D: AddEncounter(party, 0x03, 0x21);
            L013F: AddEncounter(party, 0x04, 0x21);
            L0151: return; // RETURN;
        }

        private void FnTELEPORT_0C(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetMoveMap(party, 0x04, 0x01, 0xF0, 0x03);
            L001E: return; // RETURN;
        }

        private void FnLOWMNSTR_0D(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String06A9); // You encounter Rogues.
            L0010: ax = UnknownFunctionEC(party, 0x000F);
            L001D: Compare(ax, 0x0006);
            L0020: if (CompareResultUnsignedGreaterThan) goto L0050;
            L0022: AddTreasure(party, 0x01F4, 0x00, 0x00, 0x00, 0x00, 0xB5);
            L0041: ShowMessage(party, String06BF); // If you are skilled enough, you may find teleports that speed your way to various levels of this dungeon.
            L004E: goto L008A;
            L0050: ShowMessage(party, String0728); // The Rogues snarl at you.
            L005D: ShowMessage(party, String0741); // They attack!
            L006A: AddTreasure(party, 0x03E8, 0x00, 0x00, 0x00, 0xBD, 0x03);
            L008A: ax = PartyCount(party);
            L0092: Compare(ax, 0x0001);
            L0095: if (CompareResultEqual) goto L00A4;
            L0097: ax = PartyCount(party);
            L009F: Compare(ax, 0x0002);
            L00A2: if (!CompareResultEqual) goto L00CA;
            L00A4: AddEncounter(party, 0x01, 0x1B);
            L00B6: AddEncounter(party, 0x02, 0x1A);
            L00C8: goto L0112;
            L00CA: AddEncounter(party, 0x01, 0x1C);
            L00DC: AddEncounter(party, 0x02, 0x1A);
            L00EE: AddEncounter(party, 0x03, 0x19);
            L0100: AddEncounter(party, 0x04, 0x1B);
            L0112: return; // RETURN;
        }

        private void FnMODMNSTR_0E(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = PartyCount(party);
            L000B: Compare(ax, 0x0001);
            L000E: if (!CompareResultEqual) goto L0024;
            L0010: AddEncounter(party, 0x01, 0x1D);
            L0022: goto L009F;
            L0024: ax = PartyCount(party);
            L002C: Compare(ax, 0x0002);
            L002F: if (!CompareResultEqual) goto L0057;
            L0031: AddEncounter(party, 0x01, 0x1D);
            L0043: AddEncounter(party, 0x02, 0x1E);
            L0055: goto L009F;
            L0057: AddEncounter(party, 0x01, 0x20);
            L0069: AddEncounter(party, 0x02, 0x1F);
            L007B: AddEncounter(party, 0x03, 0x1C);
            L008D: AddEncounter(party, 0x04, 0x1D);
            L009F: return; // RETURN;
        }

        private void FnSTRMNST_0F(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = PartyCount(party);
            L000B: Compare(ax, 0x0001);
            L000E: if (!CompareResultEqual) goto L0025;
            L0010: AddEncounter(party, 0x01, 0x21);
            L0022: goto L010A;
            L0025: ax = PartyCount(party);
            L002D: Compare(ax, 0x0002);
            L0030: if (!CompareResultEqual) goto L0059;
            L0032: AddEncounter(party, 0x01, 0x21);
            L0044: AddEncounter(party, 0x02, 0x22);
            L0056: goto L010A;
            L0059: ax = PartyCount(party);
            L0061: Compare(ax, 0x0003);
            L0064: if (!CompareResultEqual) goto L00B0;
            L0066: AddEncounter(party, 0x01, 0x21);
            L0078: AddEncounter(party, 0x02, 0x21);
            L008A: AddEncounter(party, 0x03, 0x23);
            L009C: AddEncounter(party, 0x04, 0x23);
            L00AE: goto L010A;
            L00B0: AddEncounter(party, 0x01, 0x24);
            L00C2: AddEncounter(party, 0x02, 0x24);
            L00D4: AddEncounter(party, 0x03, 0x23);
            L00E6: AddEncounter(party, 0x04, 0x23);
            L00F8: AddEncounter(party, 0x05, 0x22);
            L010A: return; // RETURN;
        }

        private void FnBADMNSTR_10(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = PartyCount(party);
            L000B: Compare(ax, 0x0001);
            L000E: if (!CompareResultEqual) goto L0037;
            L0010: AddEncounter(party, 0x01, 0x26);
            L0022: AddEncounter(party, 0x02, 0x26);
            L0034: goto L0164;
            L0037: ax = PartyCount(party);
            L003F: Compare(ax, 0x0002);
            L0042: if (!CompareResultEqual) goto L008F;
            L0044: AddEncounter(party, 0x01, 0x25);
            L0056: AddEncounter(party, 0x02, 0x25);
            L0068: AddEncounter(party, 0x03, 0x27);
            L007A: AddEncounter(party, 0x04, 0x27);
            L008C: goto L0164;
            L008F: ax = PartyCount(party);
            L0097: Compare(ax, 0x0003);
            L009A: if (!CompareResultEqual) goto L00F8;
            L009C: AddEncounter(party, 0x01, 0x26);
            L00AE: AddEncounter(party, 0x02, 0x26);
            L00C0: AddEncounter(party, 0x03, 0x27);
            L00D2: AddEncounter(party, 0x04, 0x27);
            L00E4: AddEncounter(party, 0x05, 0x28);
            L00F6: goto L0164;
            L00F8: AddEncounter(party, 0x01, 0x28);
            L010A: AddEncounter(party, 0x02, 0x28);
            L011C: AddEncounter(party, 0x03, 0x27);
            L012E: AddEncounter(party, 0x04, 0x27);
            L0140: AddEncounter(party, 0x05, 0x26);
            L0152: AddEncounter(party, 0x06, 0x25);
            L0164: return; // RETURN;
        }

        private void FnMESSAGEA_11(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetState00(party, 0x02, 0x00, 0x00);
            L0016: ShowMessage(party, String074E); // This gateway leads to THE MINES.
            L0023: return; // RETURN;
        }

        private void FnMESSAGEB_12(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetState00(party, 0x02, 0x00, 0x00);
            L0016: ShowMessage(party, String076F); // This gateway leads to THE HALL OF DOORS.
            L0023: return; // RETURN;
        }

        private void FnTELEMESS_13(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetState00(party, 0x02, 0x00, 0x03);
            L0017: ShowMessage(party, String0798); // There is a teleport to the north.
            L0024: return; // RETURN;
        }

        private void FnSTRSMESS_14(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetState00(party, 0x02, 0x00, 0x01);
            L0017: ShowMessage(party, String07BA); // There are stairs to the west through the gateway.
            L0024: return; // RETURN;
        }

        private void FnSTRSTLPT_15(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetMoveMap(party, 0x02, 0x02, 0x01, 0x02);
            L001E: return; // RETURN;
        }

        private void FnREGDOOR_16(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x02, 0x00);
            L0013: Compare(ax, 0x0004);
            L0016: if (!CompareResultEqual) goto L0063;
            L0018: ShowMessage(party, String07EC); // As you open the door, you hear locks click throughout the dungeon.
            L0025: ax = GetFacing24(party);
            L002C: PushStack(ax);
            L002D: ax = GetNextTile20(party);
            L0034: PushStack(ax);
            L0035: PushStack(0x01);
            L0039: SetUnblocked30(party);
            L0043: PushStack(0x01);
            L0047: ax = GetFacing24(party);
            L004E: PushStack(ax);
            L004F: ax = GetNextTile20(party);
            L0056: PushStack(ax);
            L0057: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L0061: goto L008D;
            L0063: ShowMessage(party, String082F); // The door is currently impassable.
            L0070: PushStack(0x00);
            L0073: ax = GetFacing24(party);
            L007A: PushStack(ax);
            L007B: ax = GetNextTile20(party);
            L0082: PushStack(ax);
            L0083: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L008D: return; // RETURN;
        }

        private void FnNPCCHATA_17(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0851); // You encounter an Elf Ranger.
            L0010: ShowPortrait(party, 0x001F);
            L001D: ax = UnknownFunctionEC(party, 0x000F);
            L002A: Compare(ax, 0x000B);
            L002D: if (CompareResultUnsignedGreaterThan) goto L003E;
            L002F: ShowMessage(party, String086E); // You must solve the mystery of the linked Vestibule doors to continue farther down into the dungeon.
            L003C: goto L004B;
            L003E: ShowMessage(party, String08D2); // The Elf Ranger decides you are not worthy of his time and leaves.
            L004B: return; // RETURN;
        }

        private void FnNPCCHATB_18(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0914); // You encounter a Human Wizard.
            L0010: ShowPortrait(party, 0x002B);
            L001D: ax = UnknownFunctionEC(party, 0x000F);
            L002A: Compare(ax, 0x0009);
            L002D: if (CompareResultUnsignedGreaterThan) goto L003E;
            L002F: ShowMessage(party, String0932); // Centuries ago, Twinion was a thriving port town, ruled by the Galabryan dynasty. The kings welcomed all races and Guilds to the island. When the volcano Yserbius erupted, it almost buried Twinion under lava. If only we could find some way off this island!
            L003C: goto L004B;
            L003E: ShowMessage(party, String0A32); // The Human Wizard falls into a deep trance and refuses to talk.
            L004B: return; // RETURN;
        }

        private void FnNPCCHATC_19(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0A71); // You encounter a Gremlin Thief.
            L0010: ShowPortrait(party, 0x0026);
            L001D: ax = UnknownFunctionEC(party, 0x000F);
            L002A: Compare(ax, 0x000A);
            L002D: if (CompareResultUnsignedGreaterThan) goto L003E;
            L002F: ShowMessage(party, String0A90); // King Cleowyn created a clever maze of squares to discourage thieves and invaders. Mind you, no invaders ever thought Twinion rich enough to be worth their effort.
            L003C: goto L004B;
            L003E: ShowMessage(party, String0B33); // The Gremlin Thief slips into a shadow and disappears.
            L004B: return; // RETURN;
        }

        private void FnNPCCHATD_1A(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0B69); // You encounter an Orc Knight.
            L0010: ShowPortrait(party, 0x001A);
            L001D: ax = UnknownFunctionEC(party, 0x000F);
            L002A: Compare(ax, 0x0008);
            L002D: if (CompareResultUnsignedGreaterThan) goto L003E;
            L002F: ShowMessage(party, String0B86); // The richness of fine armor and weapons in this dungeon baffles me. I've heard rumors that skilled dwarfs once crafted such armory, but the rogue dwarfs you encounter nowadays have no talent for such expert metallurgy.
            L003C: goto L004B;
            L003E: ShowMessage(party, String0C60); // The Orc Knight smiles politely and shoos you away.
            L004B: return; // RETURN;
        }

        private void FnNPCCHATE_1B(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0C93); // You encounter an Elf Cleric.
            L0010: ShowPortrait(party, 0x0027);
            L001D: ax = UnknownFunctionEC(party, 0x000F);
            L002A: Compare(ax, 0x0008);
            L002D: if (CompareResultUnsignedGreaterThan) goto L003E;
            L002F: ShowMessage(party, String0CB0); // I have visited King Cleowyn's throne room, and what a disappointment it was. Not much treasure there and too many dead things. Perhaps I missed something.
            L003C: goto L004B;
            L003E: ShowMessage(party, String0D4B); // The Elf Cleric is too engrossed in his prayers to talk with you.
            L004B: return; // RETURN;
        }

        private void FnKEYDRA_1C(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem50(party, 0xD3);
            L0011: if (CompareResultEqual) goto L0072;
            L0013: SetState00(party, 0x02, 0x00, 0x01);
            L0027: ShowMessage(party, String0D8C); // Cleowyn's Key unlocks the door.
            L0034: ax = GetFacing24(party);
            L003B: PushStack(ax);
            L003C: ax = GetNextTile20(party);
            L0043: PushStack(ax);
            L0044: PushStack(0x01);
            L0048: SetUnblocked30(party);
            L0052: PushStack(0x01);
            L0056: ax = GetFacing24(party);
            L005D: PushStack(ax);
            L005E: ax = GetNextTile20(party);
            L0065: PushStack(ax);
            L0066: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L0070: goto L009C;
            L0072: ShowMessage(party, String0DAC); // The door is locked.
            L007F: PushStack(0x00);
            L0082: ax = GetFacing24(party);
            L0089: PushStack(ax);
            L008A: ax = GetNextTile20(party);
            L0091: PushStack(ax);
            L0092: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L009C: return; // RETURN;
        }

        private void FnLKPKDRA_1D(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem50(party, 0xD2);
            L0011: if (CompareResultEqual) goto L0072;
            L0013: SetState00(party, 0x02, 0x00, 0x02);
            L0027: ShowMessage(party, String0DC0); // Cleowyn's Lockpick has unlocked the door.
            L0034: ax = GetFacing24(party);
            L003B: PushStack(ax);
            L003C: ax = GetNextTile20(party);
            L0043: PushStack(ax);
            L0044: PushStack(0x01);
            L0048: SetUnblocked30(party);
            L0052: PushStack(0x01);
            L0056: ax = GetFacing24(party);
            L005D: PushStack(ax);
            L005E: ax = GetNextTile20(party);
            L0065: PushStack(ax);
            L0066: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L0070: goto L009C;
            L0072: ShowMessage(party, String0DEA); // The door is locked.  It looks like something special is needed to open this door.
            L007F: PushStack(0x00);
            L0082: ax = GetFacing24(party);
            L0089: PushStack(ax);
            L008A: ax = GetNextTile20(party);
            L0091: PushStack(ax);
            L0092: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L009C: return; // RETURN;
        }

        private void FnSTRNGDRA_1E(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckStrengthA4(party);
            L000F: Compare(ax, 0x0012);
            L0012: if (CompareResultBelow) goto L0073;
            L0014: SetState00(party, 0x02, 0x00, 0x03);
            L0028: ShowMessage(party, String0E3C); // You manage to force open the door.
            L0035: ax = GetFacing24(party);
            L003C: PushStack(ax);
            L003D: ax = GetNextTile20(party);
            L0044: PushStack(ax);
            L0045: PushStack(0x01);
            L0049: SetUnblocked30(party);
            L0053: PushStack(0x01);
            L0057: ax = GetFacing24(party);
            L005E: PushStack(ax);
            L005F: ax = GetNextTile20(party);
            L0066: PushStack(ax);
            L0067: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L0071: goto L009D;
            L0073: ShowMessage(party, String0E5F); // The door is currently impassable.
            L0080: PushStack(0x00);
            L0083: ax = GetFacing24(party);
            L008A: PushStack(ax);
            L008B: ax = GetNextTile20(party);
            L0092: PushStack(ax);
            L0093: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L009D: return; // RETURN;
        }

        private void FnREGDORA_1F(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x02, 0x00);
            L0013: RefreshCompareFlags(ax);
            L0015: if (CompareResultEqual) goto L002C;
            L0017: ax = CheckState04(party, 0x02, 0x00);
            L0027: Compare(ax, 0x0004);
            L002A: if (!CompareResultEqual) goto L008B;
            L002C: SetState00(party, 0x02, 0x00, 0x04);
            L0040: ShowMessage(party, String0E81); // As you open the door, you hear locks click throughout the dungeon.
            L004D: ax = GetFacing24(party);
            L0054: PushStack(ax);
            L0055: ax = GetNextTile20(party);
            L005C: PushStack(ax);
            L005D: PushStack(0x01);
            L0061: SetUnblocked30(party);
            L006B: PushStack(0x01);
            L006F: ax = GetFacing24(party);
            L0076: PushStack(ax);
            L0077: ax = GetNextTile20(party);
            L007E: PushStack(ax);
            L007F: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L0089: goto L00B5;
            L008B: ShowMessage(party, String0EC4); // The door is currently impassable.
            L0098: PushStack(0x00);
            L009B: ax = GetFacing24(party);
            L00A2: PushStack(ax);
            L00A3: ax = GetNextTile20(party);
            L00AA: PushStack(ax);
            L00AB: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L00B5: return; // RETURN;
        }

    }
}
