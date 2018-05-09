#pragma warning disable
using XPT.WorldData;

namespace XPT.Scripts.Maps {
    class YserMap27 : AMapScript {
        // === Strings ================================================
        private const string String03FC = "A Gateway back to the Labyrinth.";
        private const string String041D = "Gate to the entrance of Arnakkian's Arena.";
        private const string String0448 = "Gate to the Red Arena Staging Area.";
        private const string String046C = "Gate to the Blue Arena Staging Area.";
        private const string String0491 = "Gate to the Green Arena Staging Area.";
        private const string String04B7 = "Gate to the Yellow Arena Staging Area.";
        private const string String04DE = "In the time when Arnakkian bestrode the land of Twinion, a Great Arena was built where the bravest warriors and wisest mages could challenge each other in deadly battle.";
        private const string String0588 = "You stand in the nexus of the Arena.  Doorways lead to the four team staging areas.";
        private const string String05DC = "Carved on a recessed stone, you find a roster from a Arnakkian-era private guild.  None of the names are recognizable. ";
        
        // === Functions ================================================
        protected override MapEventHandler MapEvent01 => FnGATEWAYA_01;
        private void FnGATEWAYA_01(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String03FC); // A Gateway back to the Labyrinth.
            L0010: SetMoveMap(party, 0x36, 0x01, 0x3F, 0x00);
            L002A: return; // RETURN;
        }

        protected override MapEventHandler MapEvent02 => FnXOVERA_02;
        private void FnXOVERA_02(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetMoveMap(party, 0x36, 0x02, 0x57, 0x02);
            L001E: return; // RETURN;
        }

        protected override MapEventHandler MapEvent03 => FnXOVERB_03;
        private void FnXOVERB_03(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String041D); // Gate to the entrance of Arnakkian's Arena.
            L0010: SetMoveMap(party, 0x36, 0x02, 0x51, 0x00);
            L002A: return; // RETURN;
        }

        protected override MapEventHandler MapEvent04 => FnAREAA_04;
        private void FnAREAA_04(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0448); // Gate to the Red Arena Staging Area.
            L0010: SetMoveMap(party, 0x36, 0x02, 0x33, 0x03);
            L002B: return; // RETURN;
        }

        protected override MapEventHandler MapEvent05 => FnAREAB_05;
        private void FnAREAB_05(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String046C); // Gate to the Blue Arena Staging Area.
            L0010: SetMoveMap(party, 0x36, 0x02, 0xC3, 0x03);
            L002B: return; // RETURN;
        }

        protected override MapEventHandler MapEvent06 => FnAREAC_06;
        private void FnAREAC_06(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0491); // Gate to the Green Arena Staging Area.
            L0010: SetMoveMap(party, 0x36, 0x02, 0xCC, 0x03);
            L002B: return; // RETURN;
        }

        protected override MapEventHandler MapEvent07 => FnAREAD_07;
        private void FnAREAD_07(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String04B7); // Gate to the Yellow Arena Staging Area.
            L0010: SetMoveMap(party, 0x36, 0x02, 0x3C, 0x03);
            L002B: return; // RETURN;
        }

        protected override MapEventHandler MapEvent09 => FnARENTEXT_09;
        private void FnARENTEXT_09(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String04DE); // In the time when Arnakkian bestrode the land of Twinion, a Great Arena was built where the bravest warriors and wisest mages could challenge each other in deadly battle.
            L0010: ShowMessage(party, String0588); // You stand in the nexus of the Arena.  Doorways lead to the four team staging areas.
            L001D: return; // RETURN;
        }

        protected override MapEventHandler MapEvent0A => FnWAITTEXT_0A;
        private void FnWAITTEXT_0A(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String05DC); // Carved on a recessed stone, you find a roster from a Arnakkian-era private guild.  None of the names are recognizable. 
            L0010: return; // RETURN;
        }

    }
}
