#pragma warning disable
using System.Collections.Generic;
using XPT.Games.Generic.Entities;
using XPT.Games.Generic.Maps;
using XPT.Games.Yserbius;
using XPT.Games.Yserbius.Entities;

namespace XPT.Games.Yserbius.Maps {
    class YserMap10 : YsMap {
        public override int MapIndex => 10;
        protected override int RandomEncounterChance => 10;
        protected override int RandomEncounterExtraCount => 0;

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
        private void FnSTRSTELE_01(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x03, 0x01, 0xCD, 0x02, type);
            L001E: return; // RETURN;
        }

        private void FnKEYDOOR_02(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasUsedItem(player, type, ref doMsgs, YsIndexes.ItemRuneVowelKeyI, YsIndexes.ItemRuneVowelKeyI);
            L0016: if (JumpEqual) goto L0063;
            L0018: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0036: SetWallItem(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L0054: ShowMessage(player, doMsgs, String03FC); // The I Rune Key unlocked the massive door.
            L0061: goto L008D;
            L0063: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0080: ShowMessage(player, doMsgs, String0426); // The door is locked.  It can be opened by a special key.
            L008D: return; // RETURN;
        }

        private void FnSCEPTENC_03(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, YsIndexes.ItemCleowynsSceptre);
            L0011: if (JumpEqual) goto L0041;
            L0013: ShowMessage(player, doMsgs, String045E); // The room has been ransacked.
            L0020: AddTreasure(player, 0x01F4, 0x00, 0x00, 0x00, 0x00, 0xCF);
            L003F: goto L0086;
            L0041: AddTreasure(player, 0x1B58, 0x00, 0x00, 0x00, 0x00, YsIndexes.ItemCleowynsSceptre);
            L0060: RemoveItem(player, YsIndexes.ItemRuneVowelKeyI);
            L006C: ShowMessage(player, doMsgs, String047B); // The I Rune Key mysteriously vanishes as you move forward.
            L0079: ShowMessage(player, doMsgs, String04B5); // The beating of leathery wings overhead alerts you to your great danger. On the floor is the Scepter of King Cleowyn.
            L0086: Compare(PartyCount(player), 0x0001);
            L0091: if (JumpEqual) goto L00A0;
            L0093: Compare(PartyCount(player), 0x0002);
            L009E: if (JumpNotEqual) goto L00D9;
            L00A0: AddEncounter(player, 0x01, 0x24);
            L00B2: AddEncounter(player, 0x02, 0x25);
            L00C4: AddEncounter(player, 0x03, 0x24);
            L00D6: goto L019C;
            L00D9: Compare(PartyCount(player), 0x0003);
            L00E4: if (JumpNotEqual) goto L0130;
            L00E6: AddEncounter(player, 0x01, 0x24);
            L00F8: AddEncounter(player, 0x02, 0x24);
            L010A: AddEncounter(player, 0x03, 0x25);
            L011C: AddEncounter(player, 0x04, 0x25);
            L012E: goto L019C;
            L0130: AddEncounter(player, 0x01, 0x26);
            L0142: AddEncounter(player, 0x02, 0x26);
            L0154: AddEncounter(player, 0x03, 0x27);
            L0166: AddEncounter(player, 0x04, 0x27);
            L0178: AddEncounter(player, 0x05, 0x28);
            L018A: AddEncounter(player, 0x06, 0x28);
            L019C: return; // RETURN;
        }

        private void FnITEMBENC_04(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0xBD);
            L0011: if (JumpEqual) goto L0041;
            L0013: AddTreasure(player, 0x00C8, 0x00, 0x00, 0x00, 0x00, 0xB7);
            L0032: ShowMessage(player, doMsgs, String052A); // You are dwarfed by the Giants who surround you.
            L003F: goto L006E;
            L0041: AddTreasure(player, 0x0BB8, 0x00, 0x00, 0x00, 0xCF, 0xBD);
            L0061: ShowMessage(player, doMsgs, String055A); // A Giant holds a gleaming prism in his hand.
            L006E: Compare(PartyCount(player), 0x0001);
            L0079: if (JumpEqual) goto L0088;
            L007B: Compare(PartyCount(player), 0x0002);
            L0086: if (JumpNotEqual) goto L00AF;
            L0088: AddEncounter(player, 0x01, 0x1E);
            L009A: AddEncounter(player, 0x02, 0x1F);
            L00AC: goto L013C;
            L00AF: Compare(PartyCount(player), 0x0003);
            L00BA: if (JumpNotEqual) goto L00F4;
            L00BC: AddEncounter(player, 0x01, 0x1F);
            L00CE: AddEncounter(player, 0x02, 0x1F);
            L00E0: AddEncounter(player, 0x03, 0x20);
            L00F2: goto L013C;
            L00F4: AddEncounter(player, 0x01, 0x1F);
            L0106: AddEncounter(player, 0x02, 0x1F);
            L0118: AddEncounter(player, 0x03, 0x20);
            L012A: AddEncounter(player, 0x04, 0x20);
            L013C: return; // RETURN;
        }

        private void FnITEMCENC_05(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0x56);
            L0011: if (JumpEqual) goto L0041;
            L0013: ShowMessage(player, doMsgs, String0586); // You interrupt Minotaurs butting their heads together.
            L0020: AddTreasure(player, 0x0064, 0x00, 0x00, 0x00, 0x00, 0xCD);
            L003F: goto L006D;
            L0041: AddTreasure(player, 0x02EE, 0x00, 0x00, 0x00, 0x00, 0x56);
            L0060: ShowMessage(player, doMsgs, String05BC); // The lead Minotaur you encounter carries a shield that appears to weep.
            L006D: Compare(PartyCount(player), 0x0001);
            L0078: if (JumpEqual) goto L0087;
            L007A: Compare(PartyCount(player), 0x0002);
            L0085: if (JumpNotEqual) goto L00AE;
            L0087: AddEncounter(player, 0x01, 0x01);
            L0099: AddEncounter(player, 0x02, 0x02);
            L00AB: goto L013B;
            L00AE: Compare(PartyCount(player), 0x0003);
            L00B9: if (JumpNotEqual) goto L00F3;
            L00BB: AddEncounter(player, 0x01, 0x01);
            L00CD: AddEncounter(player, 0x02, 0x02);
            L00DF: AddEncounter(player, 0x03, 0x03);
            L00F1: goto L013B;
            L00F3: AddEncounter(player, 0x01, 0x01);
            L0105: AddEncounter(player, 0x02, 0x02);
            L0117: AddEncounter(player, 0x03, 0x03);
            L0129: AddEncounter(player, 0x04, 0x04);
            L013B: return; // RETURN;
        }

        private void FnGOLDAENC_06(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, FlagTypeDungeon, YsIndexes.FlagSecretRoom3Gold), 0x0001);
            L0017: if (JumpNotEqual) goto L0047;
            L0019: AddTreasure(player, 0x00AF, 0x00, 0x00, 0x00, 0x00, 0xB6);
            L0038: ShowMessage(player, doMsgs, String0603); // Black Widows unweave an empty sack.
            L0045: goto L0088;
            L0047: AddTreasure(player, 0x1770, 0x00, 0x00, 0x00, 0x00, 0xB7);
            L0066: SetFlag(player, FlagTypeDungeon, YsIndexes.FlagSecretRoom3Gold, 0x01);
            L007B: ShowMessage(player, doMsgs, String0627); // As you reach down to take a coin purse on the ground, you become entangled in a sticky web.
            L0088: Compare(PartyCount(player), 0x0001);
            L0093: if (JumpEqual) goto L00A2;
            L0095: Compare(PartyCount(player), 0x0002);
            L00A0: if (JumpNotEqual) goto L00C9;
            L00A2: AddEncounter(player, 0x01, 0x19);
            L00B4: AddEncounter(player, 0x02, 0x1A);
            L00C6: goto L0156;
            L00C9: Compare(PartyCount(player), 0x0003);
            L00D4: if (JumpNotEqual) goto L010E;
            L00D6: AddEncounter(player, 0x01, 0x19);
            L00E8: AddEncounter(player, 0x02, 0x1A);
            L00FA: AddEncounter(player, 0x03, 0x19);
            L010C: goto L0156;
            L010E: AddEncounter(player, 0x01, 0x1C);
            L0120: AddEncounter(player, 0x02, 0x1C);
            L0132: AddEncounter(player, 0x03, 0x1C);
            L0144: AddEncounter(player, 0x04, 0x1C);
            L0156: return; // RETURN;
        }

        private void FnGOLDBENC_07(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, FlagTypeDungeon, YsIndexes.FlagSecretRoom3Gold2), 0x0001);
            L0017: if (JumpNotEqual) goto L003A;
            L0019: AddTreasure(player, 0x00C8, 0x00, 0x00, 0x00, 0x00, 0xCF);
            L0038: goto L006E;
            L003A: AddTreasure(player, 0x2134, 0x00, 0x00, 0x00, 0x00, 0xCF);
            L0059: SetFlag(player, FlagTypeDungeon, YsIndexes.FlagSecretRoom3Gold2, 0x01);
            L006E: ShowMessage(player, doMsgs, String0683); // King Cleowyn's favorite pets still guard his secrets long after their master has died.
            L007B: Compare(PartyCount(player), 0x0001);
            L0086: if (JumpEqual) goto L0095;
            L0088: Compare(PartyCount(player), 0x0002);
            L0093: if (JumpNotEqual) goto L00BC;
            L0095: AddEncounter(player, 0x01, 0x23);
            L00A7: AddEncounter(player, 0x02, 0x24);
            L00B9: goto L015B;
            L00BC: Compare(PartyCount(player), 0x0003);
            L00C7: if (JumpNotEqual) goto L0101;
            L00C9: AddEncounter(player, 0x01, 0x23);
            L00DB: AddEncounter(player, 0x02, 0x23);
            L00ED: AddEncounter(player, 0x03, 0x24);
            L00FF: goto L015B;
            L0101: AddEncounter(player, 0x01, 0x24);
            L0113: AddEncounter(player, 0x02, 0x24);
            L0125: AddEncounter(player, 0x03, 0x23);
            L0137: AddEncounter(player, 0x04, 0x23);
            L0149: AddEncounter(player, 0x05, 0x23);
            L015B: return; // RETURN;
        }

        private void FnSTRMNSTR_08(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpEqual) goto L001D;
            L0010: Compare(PartyCount(player), 0x0002);
            L001B: if (JumpNotEqual) goto L0056;
            L001D: AddEncounter(player, 0x01, 0x1A);
            L002F: AddEncounter(player, 0x02, 0x1A);
            L0041: AddEncounter(player, 0x03, 0x1A);
            L0053: goto L0119;
            L0056: Compare(PartyCount(player), 0x0003);
            L0061: if (JumpNotEqual) goto L00AD;
            L0063: AddEncounter(player, 0x01, 0x1C);
            L0075: AddEncounter(player, 0x02, 0x1C);
            L0087: AddEncounter(player, 0x03, 0x1B);
            L0099: AddEncounter(player, 0x04, 0x1B);
            L00AB: goto L0119;
            L00AD: AddEncounter(player, 0x01, 0x1C);
            L00BF: AddEncounter(player, 0x02, 0x1C);
            L00D1: AddEncounter(player, 0x03, 0x1C);
            L00E3: AddEncounter(player, 0x04, 0x1C);
            L00F5: AddEncounter(player, 0x05, 0x1B);
            L0107: AddEncounter(player, 0x06, 0x1B);
            L0119: return; // RETURN;
        }

        private void FnTUFMNSTR_09(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpEqual) goto L001D;
            L0010: Compare(PartyCount(player), 0x0002);
            L001B: if (JumpNotEqual) goto L0068;
            L001D: AddEncounter(player, 0x01, 0x1F);
            L002F: AddEncounter(player, 0x02, 0x1E);
            L0041: AddEncounter(player, 0x03, 0x1F);
            L0053: AddEncounter(player, 0x04, 0x1E);
            L0065: goto L014F;
            L0068: Compare(PartyCount(player), 0x0003);
            L0073: if (JumpNotEqual) goto L00E3;
            L0075: AddEncounter(player, 0x01, 0x20);
            L0087: AddEncounter(player, 0x02, 0x20);
            L0099: AddEncounter(player, 0x03, 0x1F);
            L00AB: AddEncounter(player, 0x04, 0x1F);
            L00BD: AddEncounter(player, 0x05, 0x20);
            L00CF: AddEncounter(player, 0x06, 0x20);
            L00E1: goto L014F;
            L00E3: AddEncounter(player, 0x01, 0x1D);
            L00F5: AddEncounter(player, 0x02, 0x1D);
            L0107: AddEncounter(player, 0x03, 0x1D);
            L0119: AddEncounter(player, 0x04, 0x1D);
            L012B: AddEncounter(player, 0x05, 0x1C);
            L013D: AddEncounter(player, 0x06, 0x1C);
            L014F: return; // RETURN;
        }

        private void FnVTFMNSTR_0A(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpEqual) goto L001D;
            L0010: Compare(PartyCount(player), 0x0002);
            L001B: if (JumpNotEqual) goto L0044;
            L001D: AddEncounter(player, 0x01, 0x23);
            L002F: AddEncounter(player, 0x02, 0x24);
            L0041: goto L00F5;
            L0044: Compare(PartyCount(player), 0x0003);
            L004F: if (JumpNotEqual) goto L0089;
            L0051: AddEncounter(player, 0x01, 0x24);
            L0063: AddEncounter(player, 0x02, 0x25);
            L0075: AddEncounter(player, 0x03, 0x26);
            L0087: goto L00F5;
            L0089: AddEncounter(player, 0x01, 0x27);
            L009B: AddEncounter(player, 0x02, 0x27);
            L00AD: AddEncounter(player, 0x03, 0x26);
            L00BF: AddEncounter(player, 0x04, 0x26);
            L00D1: AddEncounter(player, 0x05, 0x28);
            L00E3: AddEncounter(player, 0x06, 0x28);
            L00F5: return; // RETURN;
        }

        private void FnSTRSMESS_0B(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String06DA); // There are stairs through the north gateway.
            L0010: return; // RETURN;
        }

        private void FnNPCCHATA_0C(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String0706); // A dying Troll Knight lies on the floor.
            L0010: ShowPortrait(player, 0x001B);
            L001D: Compare(GetRandom(0x000F), 0x000A);
            L002D: if (JumpAbove) goto L003E;
            L002F: ShowMessage(player, doMsgs, String072E); // Cleowyn's Crown is the final treasure needed to placate the dead king's spirit. Return the king's possessions quickly or suffer his eternal wrath.
            L003C: goto L004B;
            L003E: ShowMessage(player, doMsgs, String07C1); // The Troll Knight tries to say something, but falls unconscious.
            L004B: return; // RETURN;
        }

        private void FnNPCCHATB_0D(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String0801); // A Gremlin Cleric sits on the floor, holding a thick book in her hands.
            L0010: ShowPortrait(player, 0x002A);
            L001D: Compare(GetRandom(0x000F), 0x000A);
            L002D: if (JumpAbove) goto L003E;
            L002F: ShowMessage(player, doMsgs, String0848); // The wizard Arnakkian desired immortality above all else. It is whispered that he trapped one of the Elementals and bade it obey his will and make him live forever. I believe Arnakkian got his wish, but the Elemental buried the wizard's castle under lava in revenge.
            L003C: goto L004B;
            L003E: ShowMessage(player, doMsgs, String0952); // The Gremlin Cleric ignores your questions as he becomes engrossed in his book.
            L004B: return; // RETURN;
        }

    }
}
