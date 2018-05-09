namespace ZCF.Scripts.Maps {
    class YserMap27 : ACanoMapScript {
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
        private override MapEventHandler MapEvent01 => GATEWAYA_01;
        private void GATEWAYA_01(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String03FC); // A Gateway back to the Labyrinth.
            L0010: SetMoveMap(party, 0x00, 0x3F, 0x01, 0x36);
            L002A: // RETURN;
        }

        private override MapEventHandler MapEvent02 => XOVERA_02;
        private void XOVERA_02(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetMoveMap(party, 0x02, 0x57, 0x02, 0x36);
            L001E: // RETURN;
        }

        private override MapEventHandler MapEvent03 => XOVERB_03;
        private void XOVERB_03(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String041D); // Gate to the entrance of Arnakkian's Arena.
            L0010: SetMoveMap(party, 0x00, 0x51, 0x02, 0x36);
            L002A: // RETURN;
        }

        private override MapEventHandler MapEvent04 => AREAA_04;
        private void AREAA_04(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0448); // Gate to the Red Arena Staging Area.
            L0010: SetMoveMap(party, 0x03, 0x33, 0x02, 0x36);
            L002B: // RETURN;
        }

        private override MapEventHandler MapEvent05 => AREAB_05;
        private void AREAB_05(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String046C); // Gate to the Blue Arena Staging Area.
            L0010: SetMoveMap(party, 0x03, 0xC3, 0x02, 0x36);
            L002B: // RETURN;
        }

        private override MapEventHandler MapEvent06 => AREAC_06;
        private void AREAC_06(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0491); // Gate to the Green Arena Staging Area.
            L0010: SetMoveMap(party, 0x03, 0xCC, 0x02, 0x36);
            L002B: // RETURN;
        }

        private override MapEventHandler MapEvent07 => AREAD_07;
        private void AREAD_07(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String04B7); // Gate to the Yellow Arena Staging Area.
            L0010: SetMoveMap(party, 0x03, 0x3C, 0x02, 0x36);
            L002B: // RETURN;
        }

        private override MapEventHandler MapEvent09 => ARENTEXT_09;
        private void ARENTEXT_09(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String04DE); // In the time when Arnakkian bestrode the land of Twinion, a Great Arena was built where the bravest warriors and wisest mages could challenge each other in deadly battle.
            L0010: ShowMessage(party, String0588); // You stand in the nexus of the Arena.  Doorways lead to the four team staging areas.
            L001D: // RETURN;
        }

        private override MapEventHandler MapEvent0A => WAITTEXT_0A;
        private void WAITTEXT_0A(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String05DC); // Carved on a recessed stone, you find a roster from a Arnakkian-era private guild.  None of the names are recognizable. 
            L0010: // RETURN;
        }

    }
}
