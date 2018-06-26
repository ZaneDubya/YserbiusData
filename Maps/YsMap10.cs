#pragma warning disable
using XPT.WorldData;

namespace XPT.Scripts.Yserbius.Maps {
    class YserMap10 : AMapScripted {
        protected override int MapIndex => 10;
        
        public YserMap10() {
            MapEvent01 = FnSTRSTELE_01;
            MapEvent02 = FnKEYDOOR_02;
            MapEvent03 = FnSCEPTENC_03;
            MapEvent04 = FnITEMBENC_04;
            MapEvent05 = FnITEMCENC_05;
            MapEvent06 = FnGOLDAENC_06;
            MapEvent07 = FnGOLDBENC_07;
            MapEvent08 = FnSTRMNSTR_08;
            MapEvent09 = FnTUFMNSTR_09;
            MapEvent0A = FnVTFMNSTR_0A;
            MapEvent0B = FnSTRSMESS_0B;
            MapEvent0C = FnNPCCHATA_0C;
            MapEvent0D = FnNPCCHATB_0D;
        }
        
        // === Strings ================================================
        private const string String03FC = "The I Rune Key unlocked the massive door.";
        private const string String0426 = "The door is locked.  It can be opened by a special key.";
        private const string String045E = "The room has been ransacked.";
        private const string String047B = "The I Rune Key mysteriously vanishes as you move forward.";
        private const string String04B5 = "The beating of leathery wings overhead alerts you to your great danger. On the floor is the Scepter of King Cleowyn.";
        private const string String052A = "You are dwarfed by the Giants who surround you.";
        private const string String055A = "A Giant holds a gleaming prism in his hand.";
        private const string String0586 = "You interrupt Minotaurs butting their heads together.";
        private const string String05BC = "The lead Minotaur you encounter carries a shield that appears to weep.";
        private const string String0603 = "Black Widows unweave an empty sack.";
        private const string String0627 = "As you reach down to take a coin purse on the ground, you become entangled in a sticky web.";
        private const string String0683 = "King Cleowyn's favorite pets still guard his secrets long after their master has died.";
        private const string String06DA = "There are stairs through the north gateway.";
        private const string String0706 = "A dying Troll Knight lies on the floor.";
        private const string String072E = "Cleowyn's Crown is the final treasure needed to placate the dead king's spirit. Return the king's possessions quickly or suffer his eternal wrath.";
        private const string String07C1 = "The Troll Knight tries to say something, but falls unconscious.";
        private const string String0801 = "A Gremlin Cleric sits on the floor, holding a thick book in her hands.";
        private const string String0848 = "The wizard Arnakkian desired immortality above all else. It is whispered that he trapped one of the Elementals and bade it obey his will and make him live forever. I believe Arnakkian got his wish, but the Elemental buried the wizard's castle under lava in revenge.";
        private const string String0952 = "The Gremlin Cleric ignores your questions as he becomes engrossed in his book.";
        
        // === Functions ================================================
        private void FnSTRSTELE_01(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(party, 0x03, 0x01, 0xCD, 0x02, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnKEYDOOR_02(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasUsedItem(party, 0xDC, 0xDC);
            L0016: if (JumpEqual) goto L0063;
            L0018: SetWallPassable(party, GetCurrentTile(party), GetFacing(party), 0x01);
            L0036: SetWallObject(party, 0x01, GetCurrentTile(party), GetFacing(party));
            L0054: ShowMessage(party, String03FC); // The I Rune Key unlocked the massive door.
            L0061: goto L008D;
            L0063: SetWallPassable(party, GetCurrentTile(party), GetFacing(party), 0x00);
            L0080: ShowMessage(party, String0426); // The door is locked.  It can be opened by a special key.
            L008D: return; // RETURN;
        }

        private void FnSCEPTENC_03(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(party, 0xE3);
            L0011: if (JumpEqual) goto L0041;
            L0013: ShowMessage(party, String045E); // The room has been ransacked.
            L0020: AddTreasure(party, 0x01F4, 0x00, 0x00, 0x00, 0x00, 0xCF);
            L003F: goto L0086;
            L0041: AddTreasure(party, 0x1B58, 0x00, 0x00, 0x00, 0x00, 0xE3);
            L0060: RemoveItem(party, 0xDC);
            L006C: ShowMessage(party, String047B); // The I Rune Key mysteriously vanishes as you move forward.
            L0079: ShowMessage(party, String04B5); // The beating of leathery wings overhead alerts you to your great danger. On the floor is the Scepter of King Cleowyn.
            L0086: ax = PartyCount(party);
            L008E: Compare(ax, 0x0001);
            L0091: if (JumpEqual) goto L00A0;
            L0093: ax = PartyCount(party);
            L009B: Compare(ax, 0x0002);
            L009E: if (JumpNotEqual) goto L00D9;
            L00A0: AddEncounter(party, 0x01, 0x24);
            L00B2: AddEncounter(party, 0x02, 0x25);
            L00C4: AddEncounter(party, 0x03, 0x24);
            L00D6: goto L019C;
            L00D9: ax = PartyCount(party);
            L00E1: Compare(ax, 0x0003);
            L00E4: if (JumpNotEqual) goto L0130;
            L00E6: AddEncounter(party, 0x01, 0x24);
            L00F8: AddEncounter(party, 0x02, 0x24);
            L010A: AddEncounter(party, 0x03, 0x25);
            L011C: AddEncounter(party, 0x04, 0x25);
            L012E: goto L019C;
            L0130: AddEncounter(party, 0x01, 0x26);
            L0142: AddEncounter(party, 0x02, 0x26);
            L0154: AddEncounter(party, 0x03, 0x27);
            L0166: AddEncounter(party, 0x04, 0x27);
            L0178: AddEncounter(party, 0x05, 0x28);
            L018A: AddEncounter(party, 0x06, 0x28);
            L019C: return; // RETURN;
        }

        private void FnITEMBENC_04(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(party, 0xBD);
            L0011: if (JumpEqual) goto L0041;
            L0013: AddTreasure(party, 0x00C8, 0x00, 0x00, 0x00, 0x00, 0xB7);
            L0032: ShowMessage(party, String052A); // You are dwarfed by the Giants who surround you.
            L003F: goto L006E;
            L0041: AddTreasure(party, 0x0BB8, 0x00, 0x00, 0x00, 0xCF, 0xBD);
            L0061: ShowMessage(party, String055A); // A Giant holds a gleaming prism in his hand.
            L006E: ax = PartyCount(party);
            L0076: Compare(ax, 0x0001);
            L0079: if (JumpEqual) goto L0088;
            L007B: ax = PartyCount(party);
            L0083: Compare(ax, 0x0002);
            L0086: if (JumpNotEqual) goto L00AF;
            L0088: AddEncounter(party, 0x01, 0x1E);
            L009A: AddEncounter(party, 0x02, 0x1F);
            L00AC: goto L013C;
            L00AF: ax = PartyCount(party);
            L00B7: Compare(ax, 0x0003);
            L00BA: if (JumpNotEqual) goto L00F4;
            L00BC: AddEncounter(party, 0x01, 0x1F);
            L00CE: AddEncounter(party, 0x02, 0x1F);
            L00E0: AddEncounter(party, 0x03, 0x20);
            L00F2: goto L013C;
            L00F4: AddEncounter(party, 0x01, 0x1F);
            L0106: AddEncounter(party, 0x02, 0x1F);
            L0118: AddEncounter(party, 0x03, 0x20);
            L012A: AddEncounter(party, 0x04, 0x20);
            L013C: return; // RETURN;
        }

        private void FnITEMCENC_05(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(party, 0x56);
            L0011: if (JumpEqual) goto L0041;
            L0013: ShowMessage(party, String0586); // You interrupt Minotaurs butting their heads together.
            L0020: AddTreasure(party, 0x0064, 0x00, 0x00, 0x00, 0x00, 0xCD);
            L003F: goto L006D;
            L0041: AddTreasure(party, 0x02EE, 0x00, 0x00, 0x00, 0x00, 0x56);
            L0060: ShowMessage(party, String05BC); // The lead Minotaur you encounter carries a shield that appears to weep.
            L006D: ax = PartyCount(party);
            L0075: Compare(ax, 0x0001);
            L0078: if (JumpEqual) goto L0087;
            L007A: ax = PartyCount(party);
            L0082: Compare(ax, 0x0002);
            L0085: if (JumpNotEqual) goto L00AE;
            L0087: AddEncounter(party, 0x01, 0x01);
            L0099: AddEncounter(party, 0x02, 0x02);
            L00AB: goto L013B;
            L00AE: ax = PartyCount(party);
            L00B6: Compare(ax, 0x0003);
            L00B9: if (JumpNotEqual) goto L00F3;
            L00BB: AddEncounter(party, 0x01, 0x01);
            L00CD: AddEncounter(party, 0x02, 0x02);
            L00DF: AddEncounter(party, 0x03, 0x03);
            L00F1: goto L013B;
            L00F3: AddEncounter(party, 0x01, 0x01);
            L0105: AddEncounter(party, 0x02, 0x02);
            L0117: AddEncounter(party, 0x03, 0x03);
            L0129: AddEncounter(party, 0x04, 0x04);
            L013B: return; // RETURN;
        }

        private void FnGOLDAENC_06(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = GetState(party, 0x02, 0x1C);
            L0014: Compare(ax, 0x0001);
            L0017: if (JumpNotEqual) goto L0047;
            L0019: AddTreasure(party, 0x00AF, 0x00, 0x00, 0x00, 0x00, 0xB6);
            L0038: ShowMessage(party, String0603); // Black Widows unweave an empty sack.
            L0045: goto L0088;
            L0047: AddTreasure(party, 0x1770, 0x00, 0x00, 0x00, 0x00, 0xB7);
            L0066: SetState(party, 0x02, 0x1C, 0x01);
            L007B: ShowMessage(party, String0627); // As you reach down to take a coin purse on the ground, you become entangled in a sticky web.
            L0088: ax = PartyCount(party);
            L0090: Compare(ax, 0x0001);
            L0093: if (JumpEqual) goto L00A2;
            L0095: ax = PartyCount(party);
            L009D: Compare(ax, 0x0002);
            L00A0: if (JumpNotEqual) goto L00C9;
            L00A2: AddEncounter(party, 0x01, 0x19);
            L00B4: AddEncounter(party, 0x02, 0x1A);
            L00C6: goto L0156;
            L00C9: ax = PartyCount(party);
            L00D1: Compare(ax, 0x0003);
            L00D4: if (JumpNotEqual) goto L010E;
            L00D6: AddEncounter(party, 0x01, 0x19);
            L00E8: AddEncounter(party, 0x02, 0x1A);
            L00FA: AddEncounter(party, 0x03, 0x19);
            L010C: goto L0156;
            L010E: AddEncounter(party, 0x01, 0x1C);
            L0120: AddEncounter(party, 0x02, 0x1C);
            L0132: AddEncounter(party, 0x03, 0x1C);
            L0144: AddEncounter(party, 0x04, 0x1C);
            L0156: return; // RETURN;
        }

        private void FnGOLDBENC_07(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = GetState(party, 0x02, 0x1D);
            L0014: Compare(ax, 0x0001);
            L0017: if (JumpNotEqual) goto L003A;
            L0019: AddTreasure(party, 0x00C8, 0x00, 0x00, 0x00, 0x00, 0xCF);
            L0038: goto L006E;
            L003A: AddTreasure(party, 0x2134, 0x00, 0x00, 0x00, 0x00, 0xCF);
            L0059: SetState(party, 0x02, 0x1D, 0x01);
            L006E: ShowMessage(party, String0683); // King Cleowyn's favorite pets still guard his secrets long after their master has died.
            L007B: ax = PartyCount(party);
            L0083: Compare(ax, 0x0001);
            L0086: if (JumpEqual) goto L0095;
            L0088: ax = PartyCount(party);
            L0090: Compare(ax, 0x0002);
            L0093: if (JumpNotEqual) goto L00BC;
            L0095: AddEncounter(party, 0x01, 0x23);
            L00A7: AddEncounter(party, 0x02, 0x24);
            L00B9: goto L015B;
            L00BC: ax = PartyCount(party);
            L00C4: Compare(ax, 0x0003);
            L00C7: if (JumpNotEqual) goto L0101;
            L00C9: AddEncounter(party, 0x01, 0x23);
            L00DB: AddEncounter(party, 0x02, 0x23);
            L00ED: AddEncounter(party, 0x03, 0x24);
            L00FF: goto L015B;
            L0101: AddEncounter(party, 0x01, 0x24);
            L0113: AddEncounter(party, 0x02, 0x24);
            L0125: AddEncounter(party, 0x03, 0x23);
            L0137: AddEncounter(party, 0x04, 0x23);
            L0149: AddEncounter(party, 0x05, 0x23);
            L015B: return; // RETURN;
        }

        private void FnSTRMNSTR_08(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = PartyCount(party);
            L000B: Compare(ax, 0x0001);
            L000E: if (JumpEqual) goto L001D;
            L0010: ax = PartyCount(party);
            L0018: Compare(ax, 0x0002);
            L001B: if (JumpNotEqual) goto L0056;
            L001D: AddEncounter(party, 0x01, 0x1A);
            L002F: AddEncounter(party, 0x02, 0x1A);
            L0041: AddEncounter(party, 0x03, 0x1A);
            L0053: goto L0119;
            L0056: ax = PartyCount(party);
            L005E: Compare(ax, 0x0003);
            L0061: if (JumpNotEqual) goto L00AD;
            L0063: AddEncounter(party, 0x01, 0x1C);
            L0075: AddEncounter(party, 0x02, 0x1C);
            L0087: AddEncounter(party, 0x03, 0x1B);
            L0099: AddEncounter(party, 0x04, 0x1B);
            L00AB: goto L0119;
            L00AD: AddEncounter(party, 0x01, 0x1C);
            L00BF: AddEncounter(party, 0x02, 0x1C);
            L00D1: AddEncounter(party, 0x03, 0x1C);
            L00E3: AddEncounter(party, 0x04, 0x1C);
            L00F5: AddEncounter(party, 0x05, 0x1B);
            L0107: AddEncounter(party, 0x06, 0x1B);
            L0119: return; // RETURN;
        }

        private void FnTUFMNSTR_09(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = PartyCount(party);
            L000B: Compare(ax, 0x0001);
            L000E: if (JumpEqual) goto L001D;
            L0010: ax = PartyCount(party);
            L0018: Compare(ax, 0x0002);
            L001B: if (JumpNotEqual) goto L0068;
            L001D: AddEncounter(party, 0x01, 0x1F);
            L002F: AddEncounter(party, 0x02, 0x1E);
            L0041: AddEncounter(party, 0x03, 0x1F);
            L0053: AddEncounter(party, 0x04, 0x1E);
            L0065: goto L014F;
            L0068: ax = PartyCount(party);
            L0070: Compare(ax, 0x0003);
            L0073: if (JumpNotEqual) goto L00E3;
            L0075: AddEncounter(party, 0x01, 0x20);
            L0087: AddEncounter(party, 0x02, 0x20);
            L0099: AddEncounter(party, 0x03, 0x1F);
            L00AB: AddEncounter(party, 0x04, 0x1F);
            L00BD: AddEncounter(party, 0x05, 0x20);
            L00CF: AddEncounter(party, 0x06, 0x20);
            L00E1: goto L014F;
            L00E3: AddEncounter(party, 0x01, 0x1D);
            L00F5: AddEncounter(party, 0x02, 0x1D);
            L0107: AddEncounter(party, 0x03, 0x1D);
            L0119: AddEncounter(party, 0x04, 0x1D);
            L012B: AddEncounter(party, 0x05, 0x1C);
            L013D: AddEncounter(party, 0x06, 0x1C);
            L014F: return; // RETURN;
        }

        private void FnVTFMNSTR_0A(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = PartyCount(party);
            L000B: Compare(ax, 0x0001);
            L000E: if (JumpEqual) goto L001D;
            L0010: ax = PartyCount(party);
            L0018: Compare(ax, 0x0002);
            L001B: if (JumpNotEqual) goto L0044;
            L001D: AddEncounter(party, 0x01, 0x23);
            L002F: AddEncounter(party, 0x02, 0x24);
            L0041: goto L00F5;
            L0044: ax = PartyCount(party);
            L004C: Compare(ax, 0x0003);
            L004F: if (JumpNotEqual) goto L0089;
            L0051: AddEncounter(party, 0x01, 0x24);
            L0063: AddEncounter(party, 0x02, 0x25);
            L0075: AddEncounter(party, 0x03, 0x26);
            L0087: goto L00F5;
            L0089: AddEncounter(party, 0x01, 0x27);
            L009B: AddEncounter(party, 0x02, 0x27);
            L00AD: AddEncounter(party, 0x03, 0x26);
            L00BF: AddEncounter(party, 0x04, 0x26);
            L00D1: AddEncounter(party, 0x05, 0x28);
            L00E3: AddEncounter(party, 0x06, 0x28);
            L00F5: return; // RETURN;
        }

        private void FnSTRSMESS_0B(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String06DA); // There are stairs through the north gateway.
            L0010: return; // RETURN;
        }

        private void FnNPCCHATA_0C(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0706); // A dying Troll Knight lies on the floor.
            L0010: ShowPortrait(party, 0x001B);
            L001D: ax = GetRandom(party, 0x000F);
            L002A: Compare(ax, 0x000A);
            L002D: if (JumpAbove) goto L003E;
            L002F: ShowMessage(party, String072E); // Cleowyn's Crown is the final treasure needed to placate the dead king's spirit. Return the king's possessions quickly or suffer his eternal wrath.
            L003C: goto L004B;
            L003E: ShowMessage(party, String07C1); // The Troll Knight tries to say something, but falls unconscious.
            L004B: return; // RETURN;
        }

        private void FnNPCCHATB_0D(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0801); // A Gremlin Cleric sits on the floor, holding a thick book in her hands.
            L0010: ShowPortrait(party, 0x002A);
            L001D: ax = GetRandom(party, 0x000F);
            L002A: Compare(ax, 0x000A);
            L002D: if (JumpAbove) goto L003E;
            L002F: ShowMessage(party, String0848); // The wizard Arnakkian desired immortality above all else. It is whispered that he trapped one of the Elementals and bade it obey his will and make him live forever. I believe Arnakkian got his wish, but the Elemental buried the wizard's castle under lava in revenge.
            L003C: goto L004B;
            L003E: ShowMessage(party, String0952); // The Gremlin Cleric ignores your questions as he becomes engrossed in his book.
            L004B: return; // RETURN;
        }

    }
}
