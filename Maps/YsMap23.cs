namespace ZCF.Scripts.Maps {
    class YserMap23 : ACanoMapScript {
        // === Strings ================================================
        private const string String03FC = "Runes on magic wall --";
        private const string String0413 = "Alchemy";
        private const string String041B = "Runes on magic wall --";
        private const string String0432 = "Reverie";
        private const string String043A = "Runes on magic wall --";
        private const string String0451 = "Netherworld";
        private const string String045D = "Runes on magic wall --";
        private const string String0474 = "Arcane";
        private const string String047B = "Runes on magic wall --";
        private const string String0492 = "Karma";
        private const string String0498 = "Runes on magic wall --";
        private const string String04AF = "Karma";
        private const string String04B5 = "Runes on magic wall --";
        private const string String04CC = "Incantation";
        private const string String04D8 = "Runes on magic wall --";
        private const string String04EF = "Archaic";
        private const string String04F7 = "Runes on magic wall --";
        private const string String050E = "Netherworld";
        private const string String051A = "Secrets follow when you spell that which powers time.";
        private const string String0550 = "The gate takes you back to the Labyrinth.";
        private const string String057A = "Runes on magic wall --";
        private const string String0591 = "Ethereal";
        private const string String059A = "Runes on magic wall --";
        private const string String05B1 = "Netherworld";
        private const string String05BD = "Runes on magic wall --";
        private const string String05D4 = "Luck";
        private const string String05D9 = "Runes on magic wall --";
        private const string String05F0 = "Illusion";
        private const string String05F9 = "Runes on magic wall --";
        private const string String0610 = "Invulnerable";
        private const string String061D = "Runes on magic wall --";
        private const string String0634 = "Karma";
        private const string String063A = "Runes on magic wall --";
        private const string String0651 = "Luminous";
        private const string String065A = "Those which haunt this castle must be spelled to find their master.";
        private const string String069E = "Runes on magic wall --";
        private const string String06B5 = "Dust";
        private const string String06BA = "Runes on magic wall --";
        private const string String06D1 = "Enchant";
        private const string String06D9 = "Runes on magic wall --";
        private const string String06F0 = "Magic";
        private const string String06F6 = "Runes on magic wall --";
        private const string String070D = "Ghouls";
        private const string String0714 = "Runes on magic wall --";
        private const string String072B = "Hex";
        private const string String072F = "Runes on magic wall --";
        private const string String0746 = "Obsession";
        private const string String0750 = "Runes on magic wall --";
        private const string String0767 = "Sorcery";
        private const string String076F = "Runes on magic wall --";
        private const string String0786 = "Talisman";
        private const string String078F = "Both Arnakkian and Enlikil have been identified.";
        private const string String07C0 = "The Ghost takes you to the Guardians.";
        private const string String07E6 = "The master of this castle must be identified before the ghost may take you to him.";
        private const string String0839 = "Runes on magic wall --";
        private const string String0850 = "Druid";
        private const string String0856 = "Runes on magic wall --";
        private const string String086D = "Runes";
        private const string String0873 = "Runes on magic wall --";
        private const string String088A = "Alchemist";
        private const string String0894 = "Runes on magic wall --";
        private const string String08AB = "Ghost";
        private const string String08B1 = "Runes on magic wall --";
        private const string String08C8 = "Orb";
        private const string String08CC = "Runes on magic wall --";
        private const string String08E3 = "Nexus";
        private const string String08E9 = "Runes on magic wall --";
        private const string String0900 = "Zzyzx";
        private const string String0906 = "Runes on magic wall --";
        private const string String091D = "Illusive";
        private const string String0926 = "Runes on magic wall --";
        private const string String093D = "Wizard";
        private const string String0944 = "Runes on magic wall --";
        private const string String095B = "Vision";
        private const string String0962 = "Runes on magic wall --";
        private const string String0979 = "Bewitch";
        private const string String0981 = "Runes on magic wall --";
        private const string String0998 = "Conjure";
        private const string String09A0 = "Runes on magic wall --";
        private const string String09B7 = "Powerful";
        private const string String09C0 = "Runes on magic wall --";
        private const string String09D7 = "Magus";
        private const string String09DD = "Runes on magic wall --";
        private const string String09F4 = "Jinx";
        private const string String09F9 = "Runes on magic wall --";
        private const string String0A10 = "Unspeller";
        private const string String0A1A = "Runes on magic wall --";
        private const string String0A31 = "XxxX";
        private const string String0A36 = "Runes on magic wall --";
        private const string String0A4D = "Youth";
        private const string String0A53 = "You fall into the pit and die.";
        private const string String0A72 = "A message is written on a scroll.";
        private const string String0A94 = "'To gain access to Arnakkian's Chamber, you must defeat his lich apprentices.'";
        private const string String0AE3 = "A Cleric appears..";
        private const string String0AF6 = "'Beyond the words lies the power of the earth.'";
        private const string String0B26 = "The Wizard Door opens.";
        private const string String0B3D = "The symbol of the Four Corners magically radiates from this door.";
        private const string String0B7F = "The spirit of Arnakkian Slowfoot appears.";
        private const string String0BA9 = "Apprentices of Arnakkian roam these passageways.";
        private const string String0BDA = "This gate returns you to MAGE'S OVERLOOK.";
        
        // === Functions ================================================
        private override MapEventHandler MapEvent01 => ATELEA_01;
        private void ATELEA_01(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String03FC); // Runes on magic wall --
            L0010: ShowRunes(party, String0413); // Alchemy
            L001D: SetMoveMap(party, 0x02, 0x8A, 0x02, 0x34);
            L0038: // RETURN;
        }

        private override MapEventHandler MapEvent02 => RTELEB_02;
        private void RTELEB_02(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String041B); // Runes on magic wall --
            L0010: ShowRunes(party, String0432); // Reverie
            L001D: SetMoveMap(party, 0x03, 0x38, 0x02, 0x34);
            L0038: // RETURN;
        }

        private override MapEventHandler MapEvent03 => NTELEC_03;
        private void NTELEC_03(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String043A); // Runes on magic wall --
            L0010: ShowRunes(party, String0451); // Netherworld
            L001D: SetState00(party, 0x02, 0x49, 0x02);
            L0032: SetMoveMap(party, 0x02, 0xE0, 0x02, 0x34);
            L004D: // RETURN;
        }

        private override MapEventHandler MapEvent04 => ATELED_04;
        private void ATELED_04(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String045D); // Runes on magic wall --
            L0010: ShowRunes(party, String0474); // Arcane
            L001D: SetMoveMap(party, 0x00, 0xF2, 0x02, 0x34);
            L0037: // RETURN;
        }

        private override MapEventHandler MapEvent05 => KTELEE_05;
        private void KTELEE_05(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String047B); // Runes on magic wall --
            L0010: ShowRunes(party, String0492); // Karma
            L001D: SetMoveMap(party, 0x03, 0xF5, 0x02, 0x34);
            L0038: // RETURN;
        }

        private override MapEventHandler MapEvent06 => KTELEF_06;
        private void KTELEF_06(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0498); // Runes on magic wall --
            L0010: ShowRunes(party, String04AF); // Karma
            L001D: SetMoveMap(party, 0x02, 0xE3, 0x02, 0x34);
            L0038: // RETURN;
        }

        private override MapEventHandler MapEvent07 => ITELEG_07;
        private void ITELEG_07(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String04B5); // Runes on magic wall --
            L0010: ShowRunes(party, String04CC); // Incantation
            L001D: SetMoveMap(party, 0x02, 0xCC, 0x02, 0x34);
            L0038: // RETURN;
        }

        private override MapEventHandler MapEvent08 => ATELEH_08;
        private void ATELEH_08(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x02, 0x49);
            L0014: compare(ax, 0x0002);
            L0017: if (result.notequal) goto L004E;
            L0019: ShowMessage(party, String04D8); // Runes on magic wall --
            L0026: ShowRunes(party, String04EF); // Archaic
            L0033: SetMoveMap(party, 0x02, 0xFA, 0x02, 0x34);
            L004E: // RETURN;
        }

        private override MapEventHandler MapEvent09 => NTELEI_09;
        private void NTELEI_09(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String04F7); // Runes on magic wall --
            L0010: ShowRunes(party, String050E); // Netherworld
            L001D: SetMoveMap(party, 0x00, 0x88, 0x02, 0x34);
            L0037: // RETURN;
        }

        private override MapEventHandler MapEvent0A => ARNKENCA_0A;
        private void ARNKENCA_0A(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetState00(party, 0x02, 0x52, 0x01);
            L0018: ShowMessage(party, String051A); // Secrets follow when you spell that which powers time.
            L0025: AddEncounter(party, 0x19, 0x01);
            L0037: AddEncounter(party, 0x19, 0x02);
            L0049: AddEncounter(party, 0x19, 0x03);
            L005B: AddEncounter(party, 0x12, 0x05);
            L006D: AddEncounter(party, 0x12, 0x06);
            L007F: AddTreasure(party, 0x01F4, 0x00, 0xCF, 0xCF, 0xC6, 0xC9);
            L00A1: // RETURN;
        }

        private override MapEventHandler MapEvent0C => TOENTRY_0C;
        private void TOENTRY_0C(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0550); // The gate takes you back to the Labyrinth.
            L0010: SetMoveMap(party, 0x02, 0x30, 0x02, 0x34);
            L002B: // RETURN;
        }

        private override MapEventHandler MapEvent0D => ETELEJ_0D;
        private void ETELEJ_0D(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String057A); // Runes on magic wall --
            L0010: ShowRunes(party, String0591); // Ethereal
            L001D: SetMoveMap(party, 0x02, 0xBB, 0x02, 0x34);
            L0038: // RETURN;
        }

        private override MapEventHandler MapEvent0E => NTELEK_0E;
        private void NTELEK_0E(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String059A); // Runes on magic wall --
            L0010: ShowRunes(party, String05B1); // Netherworld
            L001D: SetMoveMap(party, 0x02, 0xDA, 0x02, 0x34);
            L0038: // RETURN;
        }

        private override MapEventHandler MapEvent0F => LTELEL_0F;
        private void LTELEL_0F(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetState00(party, 0x02, 0x49, 0x03);
            L0018: ShowMessage(party, String05BD); // Runes on magic wall --
            L0025: ShowRunes(party, String05D4); // Luck
            L0032: SetMoveMap(party, 0x02, 0xB9, 0x02, 0x34);
            L004D: // RETURN;
        }

        private override MapEventHandler MapEvent10 => ITELEG_10;
        private void ITELEG_10(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x02, 0x49);
            L0014: compare(ax, 0x0003);
            L0017: if (result.notequal) goto L0050;
            L0019: ShowMessage(party, String05D9); // Runes on magic wall --
            L0026: ShowRunes(party, String05F0); // Illusion
            L0033: SetMoveMap(party, 0x02, 0xCC, 0x02, 0x34);
            L004E: goto L009B;
            L0050: ax = CheckState04(party, 0x02, 0x49);
            L0061: compare(ax, 0x0004);
            L0064: if (result.notequal) goto L009B;
            L0066: ShowMessage(party, String05F9); // Runes on magic wall --
            L0073: ShowRunes(party, String0610); // Invulnerable
            L0080: SetMoveMap(party, 0x02, 0xD8, 0x02, 0x34);
            L009B: // RETURN;
        }

        private override MapEventHandler MapEvent11 => KTELEL_11;
        private void KTELEL_11(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetState00(party, 0x02, 0x49, 0x04);
            L0018: ShowMessage(party, String061D); // Runes on magic wall --
            L0025: ShowRunes(party, String0634); // Karma
            L0032: SetMoveMap(party, 0x02, 0xB9, 0x02, 0x34);
            L004D: // RETURN;
        }

        private override MapEventHandler MapEvent12 => LTELEN_12;
        private void LTELEN_12(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String063A); // Runes on magic wall --
            L0010: ShowRunes(party, String0651); // Luminous
            L001D: SetMoveMap(party, 0x02, 0x6A, 0x02, 0x34);
            L0038: // RETURN;
        }

        private override MapEventHandler MapEvent13 => ENLKENCA_13;
        private void ENLKENCA_13(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetState00(party, 0x02, 0x53, 0x01);
            L0018: ShowMessage(party, String065A); // Those which haunt this castle must be spelled to find their master.
            L0025: AddEncounter(party, 0x19, 0x01);
            L0037: AddEncounter(party, 0x19, 0x02);
            L0049: AddEncounter(party, 0x19, 0x03);
            L005B: AddEncounter(party, 0x19, 0x04);
            L006D: AddEncounter(party, 0x19, 0x05);
            L007F: AddTreasure(party, 0x0064, 0x00, 0x00, 0x00, 0xCF, 0xD0);
            L009F: // RETURN;
        }

        private override MapEventHandler MapEvent15 => DTELEO_15;
        private void DTELEO_15(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetState00(party, 0x02, 0x49, 0x05);
            L0018: ShowMessage(party, String069E); // Runes on magic wall --
            L0025: ShowRunes(party, String06B5); // Dust
            L0032: SetMoveMap(party, 0x02, 0xB7, 0x02, 0x34);
            L004D: // RETURN;
        }

        private override MapEventHandler MapEvent16 => ETELEP_16;
        private void ETELEP_16(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String06BA); // Runes on magic wall --
            L0010: ShowRunes(party, String06D1); // Enchant
            L001D: SetMoveMap(party, 0x02, 0xD6, 0x02, 0x34);
            L0038: // RETURN;
        }

        private override MapEventHandler MapEvent17 => RTELEQ_17;
        private void RTELEQ_17(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String06D9); // Runes on magic wall --
            L0010: ShowRunes(party, String06F0); // Magic
            L001D: SetMoveMap(party, 0x03, 0xD0, 0x02, 0x34);
            L0038: // RETURN;
        }

        private override MapEventHandler MapEvent18 => GTELER_18;
        private void GTELER_18(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String06F6); // Runes on magic wall --
            L0010: ShowRunes(party, String070D); // Ghouls
            L001D: SetMoveMap(party, 0x00, 0x68, 0x02, 0x34);
            L0037: // RETURN;
        }

        private override MapEventHandler MapEvent19 => HTELES_19;
        private void HTELES_19(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0714); // Runes on magic wall --
            L0010: ShowRunes(party, String072B); // Hex
            L001D: SetMoveMap(party, 0x02, 0xAD, 0x02, 0x34);
            L0038: // RETURN;
        }

        private override MapEventHandler MapEvent1A => OTELET_1A;
        private void OTELET_1A(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String072F); // Runes on magic wall --
            L0010: ShowRunes(party, String0746); // Obsession
            L001D: SetMoveMap(party, 0x00, 0x7E, 0x02, 0x34);
            L0037: // RETURN;
        }

        private override MapEventHandler MapEvent1B => STELEU_1B;
        private void STELEU_1B(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0750); // Runes on magic wall --
            L0010: ShowRunes(party, String0767); // Sorcery
            L001D: SetMoveMap(party, 0x00, 0x5E, 0x02, 0x34);
            L0037: // RETURN;
        }

        private override MapEventHandler MapEvent1C => TTELEV_1C;
        private void TTELEV_1C(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String076F); // Runes on magic wall --
            L0010: ShowRunes(party, String0786); // Talisman
            L001D: SetMoveMap(party, 0x02, 0xC2, 0x02, 0x34);
            L0038: // RETURN;
        }

        private override MapEventHandler MapEvent1D => ARNAKEND_1D;
        private void ARNAKEND_1D(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x02, 0x52);
            L0014: RefreshCompareFlags(ax);
            L0016: if (result.equal) goto L0064;
            L0018: ax = CheckState04(party, 0x02, 0x53);
            L0029: RefreshCompareFlags(ax);
            L002B: if (result.equal) goto L0064;
            L002D: ShowMessage(party, String078F); // Both Arnakkian and Enlikil have been identified.
            L003A: ShowMessage(party, String07C0); // The Ghost takes you to the Guardians.
            L0047: SetMoveMap(party, 0x02, 0x56, 0x02, 0x33);
            L0062: goto L0071;
            L0064: ShowMessage(party, String07E6); // The master of this castle must be identified before the ghost may take you to him.
            L0071: // RETURN;
        }

        private override MapEventHandler MapEvent1E => DTELEX_1E;
        private void DTELEX_1E(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0839); // Runes on magic wall --
            L0010: ShowRunes(party, String0850); // Druid
            L001D: SetMoveMap(party, 0x02, 0x36, 0x02, 0x34);
            L0038: // RETURN;
        }

        private override MapEventHandler MapEvent1F => RTELEY_1F;
        private void RTELEY_1F(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0856); // Runes on magic wall --
            L0010: ShowRunes(party, String086D); // Runes
            L001D: SetMoveMap(party, 0x00, 0x3B, 0x02, 0x34);
            L0037: // RETURN;
        }

        private override MapEventHandler MapEvent20 => ATELEZ_20;
        private void ATELEZ_20(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0873); // Runes on magic wall --
            L0010: ShowRunes(party, String088A); // Alchemist
            L001D: SetMoveMap(party, 0x00, 0x2C, 0x02, 0x34);
            L0037: // RETURN;
        }

        private override MapEventHandler MapEvent21 => GTELEAA_21;
        private void GTELEAA_21(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0894); // Runes on magic wall --
            L0010: ShowRunes(party, String08AB); // Ghost
            L001D: SetMoveMap(party, 0x03, 0x3E, 0x02, 0x34);
            L0038: // RETURN;
        }

        private override MapEventHandler MapEvent22 => OTELEBB_22;
        private void OTELEBB_22(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String08B1); // Runes on magic wall --
            L0010: ShowRunes(party, String08C8); // Orb
            L001D: SetMoveMap(party, 0x00, 0x8E, 0x02, 0x34);
            L0037: // RETURN;
        }

        private override MapEventHandler MapEvent23 => NTELECC_23;
        private void NTELECC_23(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String08CC); // Runes on magic wall --
            L0010: ShowRunes(party, String08E3); // Nexus
            L001D: SetMoveMap(party, 0x02, 0xFD, 0x02, 0x34);
            L0038: // RETURN;
        }

        private override MapEventHandler MapEvent24 => DRAGENCA_24;
        private void DRAGENCA_24(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x1A, 0x01);
            L0015: AddEncounter(party, 0x1A, 0x02);
            L0027: AddEncounter(party, 0x1A, 0x03);
            L0039: AddEncounter(party, 0x1A, 0x04);
            L004B: AddEncounter(party, 0x1B, 0x05);
            L005D: AddTreasure(party, 0x0FA0, 0x00, 0x00, 0xD0, 0xC8, 0xC6);
            L007E: // RETURN;
        }

        private override MapEventHandler MapEvent25 => DRAGENCB_25;
        private void DRAGENCB_25(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x1C, 0x01);
            L0015: AddEncounter(party, 0x1C, 0x02);
            L0027: AddEncounter(party, 0x1C, 0x03);
            L0039: AddEncounter(party, 0x07, 0x05);
            L004B: AddEncounter(party, 0x09, 0x06);
            L005D: AddTreasure(party, 0x1F40, 0x00, 0xCF, 0xCF, 0xBC, 0xC7);
            L007F: // RETURN;
        }

        private override MapEventHandler MapEvent26 => ZTELEDD_26;
        private void ZTELEDD_26(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String08E9); // Runes on magic wall --
            L0010: ShowRunes(party, String0900); // Zzyzx
            L001D: SetState00(party, 0x02, 0x49, 0x01);
            L0032: SetMoveMap(party, 0x02, 0x27, 0x02, 0x34);
            L004D: // RETURN;
        }

        private override MapEventHandler MapEvent27 => ITELEG_27;
        private void ITELEG_27(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0906); // Runes on magic wall --
            L0010: ShowRunes(party, String091D); // Illusive
            L001D: SetMoveMap(party, 0x02, 0xCC, 0x02, 0x34);
            L0038: // RETURN;
        }

        private override MapEventHandler MapEvent28 => WTELEEE_28;
        private void WTELEEE_28(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x02, 0x49);
            L0014: compare(ax, 0x0001);
            L0017: if (result.notequal) goto L004E;
            L0019: ShowMessage(party, String0926); // Runes on magic wall --
            L0026: ShowRunes(party, String093D); // Wizard
            L0033: SetMoveMap(party, 0x02, 0xE6, 0x02, 0x34);
            L004E: // RETURN;
        }

        private override MapEventHandler MapEvent29 => VTELEWW_29;
        private void VTELEWW_29(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0944); // Runes on magic wall --
            L0010: ShowRunes(party, String095B); // Vision
            L001D: SetMoveMap(party, 0x01, 0x07, 0x02, 0x34);
            L0038: // RETURN;
        }

        private override MapEventHandler MapEvent2A => BTELEXX_2A;
        private void BTELEXX_2A(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0962); // Runes on magic wall --
            L0010: ShowRunes(party, String0979); // Bewitch
            L001D: SetMoveMap(party, 0x00, 0x1D, 0x02, 0x34);
            L0037: // RETURN;
        }

        private override MapEventHandler MapEvent2B => CTELEYY_2B;
        private void CTELEYY_2B(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0981); // Runes on magic wall --
            L0010: ShowRunes(party, String0998); // Conjure
            L001D: SetMoveMap(party, 0x02, 0xBD, 0x02, 0x34);
            L0038: // RETURN;
        }

        private override MapEventHandler MapEvent2C => PTELEZZ_2C;
        private void PTELEZZ_2C(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String09A0); // Runes on magic wall --
            L0010: ShowRunes(party, String09B7); // Powerful
            L001D: SetMoveMap(party, 0x33, 0x00, 0x02, 0x34);
            L0037: // RETURN;
        }

        private override MapEventHandler MapEvent2D => MTELEXX_2D;
        private void MTELEXX_2D(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String09C0); // Runes on magic wall --
            L0010: ShowRunes(party, String09D7); // Magus
            L001D: SetMoveMap(party, 0x00, 0x1D, 0x02, 0x34);
            L0037: // RETURN;
        }

        private override MapEventHandler MapEvent2E => JTELEYY_2E;
        private void JTELEYY_2E(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String09DD); // Runes on magic wall --
            L0010: ShowRunes(party, String09F4); // Jinx
            L001D: SetMoveMap(party, 0x02, 0xBD, 0x02, 0x34);
            L0038: // RETURN;
        }

        private override MapEventHandler MapEvent2F => UTELEWW_2F;
        private void UTELEWW_2F(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String09F9); // Runes on magic wall --
            L0010: ShowRunes(party, String0A10); // Unspeller
            L001D: SetMoveMap(party, 0x01, 0x07, 0x02, 0x34);
            L0038: // RETURN;
        }

        private override MapEventHandler MapEvent30 => XTELEWW_30;
        private void XTELEWW_30(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0A1A); // Runes on magic wall --
            L0010: ShowRunes(party, String0A31); // XxxX
            L001D: SetMoveMap(party, 0x01, 0x07, 0x02, 0x34);
            L0038: // RETURN;
        }

        private override MapEventHandler MapEvent31 => YTELEZZ_31;
        private void YTELEZZ_31(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0A36); // Runes on magic wall --
            L0010: ShowRunes(party, String0A4D); // Youth
            L001D: SetMoveMap(party, 0x33, 0x00, 0x02, 0x34);
            L0037: // RETURN;
        }

        private override MapEventHandler MapEvent32 => IENCA_32;
        private void IENCA_32(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x18, 0x01);
            L0015: AddEncounter(party, 0x18, 0x02);
            L0027: AddEncounter(party, 0x1E, 0x03);
            L0039: AddEncounter(party, 0x21, 0x05);
            L004B: // RETURN;
        }

        private override MapEventHandler MapEvent34 => WIZENCA_34;
        private void WIZENCA_34(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x1E, 0x01);
            L0015: AddEncounter(party, 0x1E, 0x02);
            L0027: AddEncounter(party, 0x18, 0x03);
            L0039: AddEncounter(party, 0x18, 0x04);
            L004B: AddEncounter(party, 0x21, 0x05);
            L005D: AddEncounter(party, 0x21, 0x06);
            L006F: AddTreasure(party, 0x0064, 0x00, 0x00, 0x00, 0xCF, 0xB4);
            L008F: // RETURN;
        }

        private override MapEventHandler MapEvent35 => WIZENCB_35;
        private void WIZENCB_35(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x1D, 0x01);
            L0015: AddEncounter(party, 0x1D, 0x02);
            L0027: AddEncounter(party, 0x1D, 0x03);
            L0039: AddEncounter(party, 0x1D, 0x04);
            L004B: AddEncounter(party, 0x18, 0x05);
            L005D: AddEncounter(party, 0x18, 0x06);
            L006F: AddTreasure(party, 0x0064, 0x00, 0x00, 0x00, 0xCF, 0xC6);
            L008F: // RETURN;
        }

        private override MapEventHandler MapEvent36 => WIZENCC_36;
        private void WIZENCC_36(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x1E, 0x01);
            L0015: AddEncounter(party, 0x1E, 0x02);
            L0027: AddEncounter(party, 0x18, 0x05);
            L0039: AddTreasure(party, 0x0064, 0x00, 0x00, 0x00, 0xCF, 0xC8);
            L0059: // RETURN;
        }

        private override MapEventHandler MapEvent37 => PIT_37;
        private void PIT_37(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0A53); // You fall into the pit and die.
            L0010: ax = GetMaxHits74(party);
            L0017: DoDamage90(party, ax);
            L0021: // RETURN;
        }

        private override MapEventHandler MapEvent38 => GHOSENCA_38;
        private void GHOSENCA_38(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x20, 0x01);
            L0015: AddEncounter(party, 0x20, 0x02);
            L0027: AddEncounter(party, 0x1F, 0x03);
            L0039: AddEncounter(party, 0x1F, 0x04);
            L004B: AddEncounter(party, 0x20, 0x06);
            L005D: AddTreasure(party, 0x0064, 0x00, 0x00, 0x00, 0xD1, 0xCF);
            L007D: // RETURN;
        }

        private override MapEventHandler MapEvent3B => TXTGHOSB_3B;
        private void TXTGHOSB_3B(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0A72); // A message is written on a scroll.
            L0010: ShowMessage(party, String0A94); // 'To gain access to Arnakkian's Chamber, you must defeat his lich apprentices.'
            L001D: // RETURN;
        }

        private override MapEventHandler MapEvent3D => TXTGHOST_3D;
        private void TXTGHOST_3D(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(party, 0x0029);
            L0010: ShowMessage(party, String0AE3); // A Cleric appears..
            L001D: ShowMessage(party, String0AF6); // 'Beyond the words lies the power of the earth.'
            L002A: // RETURN;
        }

        private override MapEventHandler MapEvent3E => ENDRENCA_3E;
        private void ENDRENCA_3E(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x1F, 0x01);
            L0015: AddEncounter(party, 0x20, 0x02);
            L0027: AddEncounter(party, 0x1F, 0x04);
            L0039: AddEncounter(party, 0x02, 0x05);
            L004B: AddEncounter(party, 0x02, 0x06);
            L005D: AddTreasure(party, 0x0064, 0x00, 0xCF, 0xCF, 0xD0, 0xD0);
            L007F: // RETURN;
        }

        private override MapEventHandler MapEvent41 => BADEXIT_41;
        private void BADEXIT_41(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x1E, 0x01);
            L0015: AddEncounter(party, 0x1E, 0x02);
            L0027: AddEncounter(party, 0x1E, 0x03);
            L0039: AddEncounter(party, 0x18, 0x04);
            L004B: AddEncounter(party, 0x19, 0x05);
            L005D: AddEncounter(party, 0x19, 0x06);
            L006F: // RETURN;
        }

        private override MapEventHandler MapEvent45 => ENTRENCA_45;
        private void ENTRENCA_45(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x24, 0x01);
            L0015: AddEncounter(party, 0x25, 0x02);
            L0027: AddEncounter(party, 0x22, 0x03);
            L0039: AddEncounter(party, 0x23, 0x06);
            L004B: // RETURN;
        }

        private override MapEventHandler MapEvent47 => LICHDOOR_47;
        private void LICHDOOR_47(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x01, 0x01);
            L0014: RefreshCompareFlags(ax);
            L0016: if (result.notequal) goto L001B;
            L0018: goto L00A5;
            L001B: ax = CheckState04(party, 0x01, 0x02);
            L002C: RefreshCompareFlags(ax);
            L002E: if (result.equal) goto L00A5;
            L0030: ax = CheckState04(party, 0x01, 0x03);
            L0041: RefreshCompareFlags(ax);
            L0043: if (result.equal) goto L00A5;
            L0045: ax = CheckState04(party, 0x01, 0x04);
            L0056: RefreshCompareFlags(ax);
            L0058: if (result.equal) goto L00A5;
            L005A: Push(01);
            L005E: ax = GetFacing24(party);
            L0065: PushStack(ax);
            L0066: ax = GetNextTile20(party);
            L006D: PushStack(ax);
            L006E: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L0078: ax = GetFacing24(party);
            L007F: PushStack(ax);
            L0080: ax = GetNextTile20(party);
            L0087: PushStack(ax);
            L0088: Push(01);
            L008C: SetUnblocked30(party);
            L0096: ShowMessage(party, String0B26); // The Wizard Door opens.
            L00A3: goto L00B2;
            L00A5: ShowMessage(party, String0B3D); // The symbol of the Four Corners magically radiates from this door.
            L00B2: // RETURN;
        }

        private override MapEventHandler MapEvent48 => ENTRENCD_48;
        private void ENTRENCD_48(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x19, 0x01);
            L0015: AddEncounter(party, 0x19, 0x02);
            L0027: AddEncounter(party, 0x18, 0x03);
            L0039: AddEncounter(party, 0x18, 0x04);
            L004B: AddEncounter(party, 0x19, 0x05);
            L005D: AddEncounter(party, 0x19, 0x06);
            L006F: // RETURN;
        }

        private override MapEventHandler MapEvent49 => LICHA_49;
        private void LICHA_49(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x19, 0x01);
            L0015: AddEncounter(party, 0x19, 0x02);
            L0027: AddEncounter(party, 0x27, 0x05);
            L0039: ax = CheckState04(party, 0x02, 0x8B);
            L004A: RefreshCompareFlags(ax);
            L004C: if (result.equal) goto L006E;
            L004E: AddTreasure(party, 0x0000, 0x00, 0x00, 0x00, 0x00, 0xCF);
            L006C: goto L00B3;
            L006E: SetState00(party, 0x02, 0x8B, 0x01);
            L0083: AddTreasure(party, 0x0000, 0x00, 0x00, 0x00, 0xB7, 0xD0);
            L00A2: AddExperience98(party, 0x00002710);
            L00B3: // RETURN;
        }

        private override MapEventHandler MapEvent4A => LICHB_4A;
        private void LICHB_4A(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x19, 0x01);
            L0015: AddEncounter(party, 0x19, 0x02);
            L0027: AddEncounter(party, 0x27, 0x05);
            L0039: ax = CheckState04(party, 0x02, 0x8C);
            L004A: RefreshCompareFlags(ax);
            L004C: if (result.equal) goto L006E;
            L004E: AddTreasure(party, 0x0000, 0x00, 0x00, 0x00, 0x00, 0xC6);
            L006C: goto L00B3;
            L006E: SetState00(party, 0x02, 0x8C, 0x01);
            L0083: AddTreasure(party, 0x0000, 0x00, 0x00, 0x00, 0xCD, 0xBD);
            L00A2: AddExperience98(party, 0x00002710);
            L00B3: // RETURN;
        }

        private override MapEventHandler MapEvent4B => LICHC_4B;
        private void LICHC_4B(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x19, 0x01);
            L0015: AddEncounter(party, 0x19, 0x02);
            L0027: AddEncounter(party, 0x27, 0x05);
            L0039: ax = CheckState04(party, 0x02, 0x8D);
            L004A: RefreshCompareFlags(ax);
            L004C: if (result.equal) goto L006E;
            L004E: AddTreasure(party, 0x0000, 0x00, 0x00, 0x00, 0x00, 0xD1);
            L006C: goto L00B3;
            L006E: SetState00(party, 0x02, 0x8D, 0x01);
            L0083: AddTreasure(party, 0x0000, 0x00, 0x00, 0x00, 0xC7, 0xB2);
            L00A2: AddExperience98(party, 0x00002710);
            L00B3: // RETURN;
        }

        private override MapEventHandler MapEvent4C => LICHD_4C;
        private void LICHD_4C(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x19, 0x01);
            L0015: AddEncounter(party, 0x19, 0x02);
            L0027: AddEncounter(party, 0x27, 0x05);
            L0039: ax = CheckState04(party, 0x02, 0x8E);
            L004A: RefreshCompareFlags(ax);
            L004C: if (result.equal) goto L006E;
            L004E: AddTreasure(party, 0x0000, 0x00, 0x00, 0x00, 0x00, 0xD0);
            L006C: goto L00B3;
            L006E: SetState00(party, 0x02, 0x8E, 0x01);
            L0083: AddTreasure(party, 0x0000, 0x00, 0x00, 0x00, 0xAC, 0xB7);
            L00A2: AddExperience98(party, 0x00002710);
            L00B3: // RETURN;
        }

        private override MapEventHandler MapEvent4D => LICHMAIN_4D;
        private void LICHMAIN_4D(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0B7F); // The spirit of Arnakkian Slowfoot appears.
            L0010: AddEncounter(party, 0x27, 0x01);
            L0022: AddEncounter(party, 0x27, 0x02);
            L0034: AddEncounter(party, 0x27, 0x03);
            L0046: AddEncounter(party, 0x27, 0x04);
            L0058: AddEncounter(party, 0x28, 0x05);
            L006A: ax = HasItem50(party, 0xF7);
            L0078: if (result.equal) goto L009A;
            L007A: AddTreasure(party, 0x0000, 0x00, 0x00, 0x00, 0x00, 0xCF);
            L0098: goto L00F6;
            L009A: AddTreasure(party, 0x0000, 0x00, 0x00, 0x50, 0x50, 0x2D);
            L00BA: ax = CheckState04(party, 0x02, 0x89);
            L00CB: RefreshCompareFlags(ax);
            L00CD: if (result.notequal) goto L00F6;
            L00CF: SetState00(party, 0x02, 0x89, 0x01);
            L00E4: AddExperience98(party, 0x000B71B0);
            L00F6: // RETURN;
        }

        private override MapEventHandler MapEvent4E => TXTLICH_4E;
        private void TXTLICH_4E(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0BA9); // Apprentices of Arnakkian roam these passageways.
            L0010: // RETURN;
        }

        private override MapEventHandler MapEvent4F => LABY_4F;
        private void LABY_4F(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetMoveMap(party, 0x00, 0x3F, 0x01, 0x34);
            L001D: // RETURN;
        }

        private override MapEventHandler MapEvent50 => TXTLABY_50;
        private void TXTLABY_50(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0BDA); // This gate returns you to MAGE'S OVERLOOK.
            L0010: // RETURN;
        }

        private override MapEventHandler MapEvent51 => SETLICHA_51;
        private void SETLICHA_51(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x01, 0x01);
            L0014: RefreshCompareFlags(ax);
            L0016: if (result.notequal) goto L002D;
            L0018: SetState00(party, 0x01, 0x01, 0x01);
            L002D: // RETURN;
        }

        private override MapEventHandler MapEvent52 => SETLICHB_52;
        private void SETLICHB_52(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x01, 0x02);
            L0014: RefreshCompareFlags(ax);
            L0016: if (result.notequal) goto L002D;
            L0018: SetState00(party, 0x01, 0x02, 0x01);
            L002D: // RETURN;
        }

        private override MapEventHandler MapEvent53 => SETLICHC_53;
        private void SETLICHC_53(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x01, 0x03);
            L0014: RefreshCompareFlags(ax);
            L0016: if (result.notequal) goto L002D;
            L0018: SetState00(party, 0x01, 0x03, 0x01);
            L002D: // RETURN;
        }

        private override MapEventHandler MapEvent54 => SETLICHD_54;
        private void SETLICHD_54(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x01, 0x04);
            L0014: RefreshCompareFlags(ax);
            L0016: if (result.notequal) goto L002D;
            L0018: SetState00(party, 0x01, 0x04, 0x01);
            L002D: // RETURN;
        }

    }
}
