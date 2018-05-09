namespace ZCF.Scripts.Maps {
    class YserMap18 : ACanoMapScript {
        // === Strings ================================================
        private const string String03FC = "You step into molten lava and your flesh burns.";
        private const string String042C = "The Lava Key opens the door.";
        private const string String0449 = "The door is locked. It requires a special key.";
        private const string String0478 = "Half-starved Rogues eye you hungrily.";
        private const string String049E = "A smirking Barbarian dangles a glowing red key in your face.";
        private const string String04DB = "You sip from the Fountain of Hot Ice, but nothing happens.";
        private const string String0516 = "You sip from the Fountain of Hot Ice and feel your Health restored.";
        private const string String055A = "The door lock opens easily.";
        private const string String0576 = "The door is locked.";
        private const string String058A = "Angry Sabertooth Lions roar at you.";
        private const string String05AE = "The lion lair you enter is littered with gold.";
        private const string String05DD = "You step into a Wyvern den.";
        private const string String05F9 = "Gold coins are stuck to a Wyvern's scales.";
        private const string String0624 = "You discover a Knights' sanctuary.";
        private const string String0647 = "A Knight drops a lockpick on the floor.";
        private const string String066F = "This room is a Cleric stronghold.";
        private const string String0691 = "A Cleric shows off a wand to his associates.";
        private const string String06BE = "You step into a nest of Pincer Cobras.";
        private const string String06E5 = "In a snake nest is a shining prism.";
        private const string String0709 = "You interrupt a Wizards' coven.";
        private const string String0729 = "The chief Wizard of the coven wears a round breastplate.";
        private const string String0762 = "Rogue Rangers use this place as a safehold.";
        private const string String078E = "A sly Ranger hides something inside his jacket.";
        private const string String07BE = "Rogue Barbarians have a wrestling center here.";
        private const string String07ED = "A Barbarian throws a heavy mace aside to swing at you.";
        private const string String0824 = "There is a teleport in the north wall.";
        private const string String084B = "There is a teleport in the south wall.";
        private const string String0872 = "There is a teleport in the east wall.";
        private const string String0898 = "There is a teleport in the south wall.";
        private const string String08BF = "The heat of the adjacent lava weakens you.";
        private const string String08EA = "You encounter a Troll Knight.";
        private const string String0908 = "The only way to get out of this basement area is to go through the lava field. Touching the lava is deadly, as you might expect. However, even if you pass safely through the lava field, the great heat of the lava will sap your strength.";
        private const string String09F5 = "The Troll Knight scowls angrily, causing you to leave her alone.";
        private const string String0A36 = "You encounter a Dwarf Thief.";
        private const string String0A53 = "I know there is a short cut through the lava field. If you can find the correct key, you will be able to use the short cut. The key also will lead you to riches.";
        private const string String0AF5 = "The Dwarf Thief runs away.";
        private const string String0B10 = "You encounter a Halfling Ranger.";
        private const string String0B31 = "The dwarves who built Cleowyn's Palace transported precious metals and building blocks up to the top level by means of a teleport. I believe the teleport is somewhere in this area.";
        private const string String0BE6 = "The Halfling Ranger faints from heat stroke.";
        private const string String0C13 = "You encounter a Gremlin Cleric.";
        private const string String0C33 = "Deep in the dungeon are the Pillow Labyrinths. They were formed from pillow lava that spilled into the sea. The labyrinth is formed from the hollow interior of the lava.";
        private const string String0CDD = "The Gremlin Cleric is deep in meditation and does not answer you.";
        
        // === Functions ================================================
        private override MapEventHandler MapEvent01 => TELEPORT_01;
        private void TELEPORT_01(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetMoveMap(party, 0x02, 0x40, 0x03, 0x05);
            L001E: // RETURN;
        }

        private override MapEventHandler MapEvent02 => TELEPORT_02;
        private void TELEPORT_02(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetMoveMap(party, 0x01, 0x78, 0x01, 0x04);
            L001E: // RETURN;
        }

        private override MapEventHandler MapEvent03 => TELEPORT_03;
        private void TELEPORT_03(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetMoveMap(party, 0x03, 0xF1, 0x02, 0x05);
            L001E: // RETURN;
        }

        private override MapEventHandler MapEvent04 => TELEPORT_04;
        private void TELEPORT_04(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetMoveMap(party, 0x00, 0x96, 0x02, 0x05);
            L001D: // RETURN;
        }

        private override MapEventHandler MapEvent05 => LAVA_05;
        private void LAVA_05(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = GetNextTile20(party);
            L000A: SetMove38(party, ax, 0x02);
            L0018: ShowMessage(party, String03FC); // You step into molten lava and your flesh burns.
            L0025: ax = GetMaxHits74(party);
            L002C: DoDamage90(party, ax);
            L0036: // RETURN;
        }

        private override MapEventHandler MapEvent13 => SPKEYDOR_13;
        private void SPKEYDOR_13(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = UsedItem54(party, 0xE2, 0xE2);
            L0016: if (result.equal) goto L0063;
            L0018: ax = GetFacing24(party);
            L001F: PushStack(ax);
            L0020: ax = GetNextTile20(party);
            L0027: PushStack(ax);
            L0028: Push(01);
            L002C: SetUnblocked30(party);
            L0036: Push(01);
            L003A: ax = GetFacing24(party);
            L0041: PushStack(ax);
            L0042: ax = GetNextTile20(party);
            L0049: PushStack(ax);
            L004A: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L0054: ShowMessage(party, String042C); // The Lava Key opens the door.
            L0061: goto L00AB;
            L0063: ax = GetFacing24(party);
            L006A: PushStack(ax);
            L006B: ax = GetNextTile20(party);
            L0072: PushStack(ax);
            L0073: Push(01);
            L0077: SetUnblocked30(party);
            L0081: PushStack(0x00);
            L0084: ax = GetFacing24(party);
            L008B: PushStack(ax);
            L008C: ax = GetNextTile20(party);
            L0093: PushStack(ax);
            L0094: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L009E: ShowMessage(party, String0449); // The door is locked. It requires a special key.
            L00AB: // RETURN;
        }

        private override MapEventHandler MapEvent14 => KEYENC_14;
        private void KEYENC_14(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem50(party, 0xE2);
            L0011: if (result.equal) goto L0041;
            L0013: ShowMessage(party, String0478); // Half-starved Rogues eye you hungrily.
            L0020: AddTreasure(party, 0x1388, 0x00, 0x00, 0x00, 0x00, 0xCF);
            L003F: goto L006D;
            L0041: AddTreasure(party, 0x1F40, 0x00, 0x00, 0x00, 0x00, 0xE2);
            L0060: ShowMessage(party, String049E); // A smirking Barbarian dangles a glowing red key in your face.
            L006D: ax = PartyCount(party);
            L0075: compare(ax, 0x0001);
            L0078: if (result.notequal) goto L00A1;
            L007A: AddEncounter(party, 0x27, 0x01);
            L008C: AddEncounter(party, 0x28, 0x05);
            L009E: goto L01BC;
            L00A1: ax = PartyCount(party);
            L00A9: compare(ax, 0x0002);
            L00AC: if (result.notequal) goto L00E7;
            L00AE: AddEncounter(party, 0x26, 0x01);
            L00C0: AddEncounter(party, 0x27, 0x02);
            L00D2: AddEncounter(party, 0x28, 0x05);
            L00E4: goto L01BC;
            L00E7: ax = PartyCount(party);
            L00EF: compare(ax, 0x0003);
            L00F2: if (result.notequal) goto L0150;
            L00F4: AddEncounter(party, 0x26, 0x01);
            L0106: AddEncounter(party, 0x27, 0x02);
            L0118: AddEncounter(party, 0x27, 0x03);
            L012A: AddEncounter(party, 0x28, 0x05);
            L013C: AddEncounter(party, 0x28, 0x06);
            L014E: goto L01BC;
            L0150: AddEncounter(party, 0x26, 0x01);
            L0162: AddEncounter(party, 0x27, 0x02);
            L0174: AddEncounter(party, 0x28, 0x03);
            L0186: AddEncounter(party, 0x28, 0x04);
            L0198: AddEncounter(party, 0x28, 0x05);
            L01AA: AddEncounter(party, 0x28, 0x06);
            L01BC: // RETURN;
        }

        private override MapEventHandler MapEvent15 => FOUNHLTH_15;
        private void FOUNHLTH_15(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x01, 0x01);
            L0014: compare(ax, 0x0001);
            L0017: if (result.notequal) goto L0035;
            L0019: ShowPortrait(party, 0x0042);
            L0026: ShowMessage(party, String04DB); // You sip from the Fountain of Hot Ice, but nothing happens.
            L0033: goto L0071;
            L0035: AddHealth94(party, 0x07D0);
            L0042: SetState00(party, 0x01, 0x01, 0x01);
            L0057: ShowPortrait(party, 0x0042);
            L0064: ShowMessage(party, String0516); // You sip from the Fountain of Hot Ice and feel your Health restored.
            L0071: // RETURN;
        }

        private override MapEventHandler MapEvent16 => LKPKDOOR_16;
        private void LKPKDOOR_16(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = UsedItem54(party, 0xC2, 0xC4);
            L0016: if (result.notequal) goto L0029;
            L0018: ax = UsedSkill58(party, 0x0E) // returns 0 if did not use, compares to 2nd op if did use;
            L0024: compare(ax, 0x0008);
            L0027: if (result.below) goto L0074;
            L0029: Push(01);
            L002D: ax = GetFacing24(party);
            L0034: PushStack(ax);
            L0035: ax = GetNextTile20(party);
            L003C: PushStack(ax);
            L003D: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L0047: ax = GetFacing24(party);
            L004E: PushStack(ax);
            L004F: ax = GetNextTile20(party);
            L0056: PushStack(ax);
            L0057: Push(01);
            L005B: SetUnblocked30(party);
            L0065: ShowMessage(party, String055A); // The door lock opens easily.
            L0072: goto L009E;
            L0074: PushStack(0x00);
            L0077: ax = GetFacing24(party);
            L007E: PushStack(ax);
            L007F: ax = GetNextTile20(party);
            L0086: PushStack(ax);
            L0087: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L0091: ShowMessage(party, String0576); // The door is locked.
            L009E: // RETURN;
        }

        private override MapEventHandler MapEvent17 => GOLDAENC_17;
        private void GOLDAENC_17(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x02, 0x3B);
            L0014: compare(ax, 0x0001);
            L0017: if (result.notequal) goto L0047;
            L0019: ShowMessage(party, String058A); // Angry Sabertooth Lions roar at you.
            L0026: AddTreasure(party, 0x07D0, 0x00, 0x00, 0x00, 0x00, 0xCF);
            L0045: goto L008A;
            L0047: AddTreasure(party, 0x2710, 0x00, 0x00, 0xB9, 0xD0, 0xD0);
            L0068: SetState00(party, 0x02, 0x3B, 0x01);
            L007D: ShowMessage(party, String05AE); // The lion lair you enter is littered with gold.
            L008A: ax = PartyCount(party);
            L0092: compare(ax, 0x0001);
            L0095: if (result.notequal) goto L00AC;
            L0097: AddEncounter(party, 0x1B, 0x01);
            L00A9: goto L016D;
            L00AC: ax = PartyCount(party);
            L00B4: compare(ax, 0x0002);
            L00B7: if (result.notequal) goto L00E0;
            L00B9: AddEncounter(party, 0x1B, 0x01);
            L00CB: AddEncounter(party, 0x1B, 0x02);
            L00DD: goto L016D;
            L00E0: ax = PartyCount(party);
            L00E8: compare(ax, 0x0003);
            L00EB: if (result.notequal) goto L0125;
            L00ED: AddEncounter(party, 0x1B, 0x01);
            L00FF: AddEncounter(party, 0x1B, 0x02);
            L0111: AddEncounter(party, 0x1B, 0x03);
            L0123: goto L016D;
            L0125: AddEncounter(party, 0x1B, 0x01);
            L0137: AddEncounter(party, 0x1B, 0x02);
            L0149: AddEncounter(party, 0x1B, 0x03);
            L015B: AddEncounter(party, 0x1B, 0x04);
            L016D: // RETURN;
        }

        private override MapEventHandler MapEvent18 => GOLDBENC_18;
        private void GOLDBENC_18(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x02, 0x3C);
            L0014: compare(ax, 0x0001);
            L0017: if (result.notequal) goto L0047;
            L0019: ShowMessage(party, String05DD); // You step into a Wyvern den.
            L0026: AddTreasure(party, 0x1B58, 0x00, 0x00, 0x00, 0x00, 0xD0);
            L0045: goto L0089;
            L0047: AddTreasure(party, 0x2EE0, 0x00, 0x00, 0x00, 0xB9, 0xB4);
            L0067: SetState00(party, 0x02, 0x3C, 0x01);
            L007C: ShowMessage(party, String05F9); // Gold coins are stuck to a Wyvern's scales.
            L0089: ax = PartyCount(party);
            L0091: compare(ax, 0x0001);
            L0094: if (result.notequal) goto L00AB;
            L0096: AddEncounter(party, 0x1F, 0x01);
            L00A8: goto L016C;
            L00AB: ax = PartyCount(party);
            L00B3: compare(ax, 0x0002);
            L00B6: if (result.notequal) goto L00DF;
            L00B8: AddEncounter(party, 0x1F, 0x01);
            L00CA: AddEncounter(party, 0x1F, 0x02);
            L00DC: goto L016C;
            L00DF: ax = PartyCount(party);
            L00E7: compare(ax, 0x0003);
            L00EA: if (result.notequal) goto L0124;
            L00EC: AddEncounter(party, 0x1F, 0x01);
            L00FE: AddEncounter(party, 0x1F, 0x02);
            L0110: AddEncounter(party, 0x1F, 0x05);
            L0122: goto L016C;
            L0124: AddEncounter(party, 0x1F, 0x01);
            L0136: AddEncounter(party, 0x1F, 0x02);
            L0148: AddEncounter(party, 0x1F, 0x04);
            L015A: AddEncounter(party, 0x1F, 0x06);
            L016C: // RETURN;
        }

        private override MapEventHandler MapEvent19 => ITEMAENC_19;
        private void ITEMAENC_19(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem50(party, 0xC4);
            L0011: if (result.equal) goto L0041;
            L0013: ShowMessage(party, String0624); // You discover a Knights' sanctuary.
            L0020: AddTreasure(party, 0x0BB8, 0x00, 0x00, 0x00, 0x00, 0xB7);
            L003F: goto L006E;
            L0041: AddTreasure(party, 0x2328, 0x00, 0x00, 0x00, 0xD0, 0xC4);
            L0061: ShowMessage(party, String0647); // A Knight drops a lockpick on the floor.
            L006E: ax = PartyCount(party);
            L0076: compare(ax, 0x0001);
            L0079: if (result.notequal) goto L0090;
            L007B: AddEncounter(party, 0x23, 0x01);
            L008D: goto L0187;
            L0090: ax = PartyCount(party);
            L0098: compare(ax, 0x0002);
            L009B: if (result.notequal) goto L00C4;
            L009D: AddEncounter(party, 0x23, 0x01);
            L00AF: AddEncounter(party, 0x24, 0x02);
            L00C1: goto L0187;
            L00C4: ax = PartyCount(party);
            L00CC: compare(ax, 0x0003);
            L00CF: if (result.notequal) goto L011B;
            L00D1: AddEncounter(party, 0x23, 0x01);
            L00E3: AddEncounter(party, 0x23, 0x02);
            L00F5: AddEncounter(party, 0x24, 0x03);
            L0107: AddEncounter(party, 0x24, 0x04);
            L0119: goto L0187;
            L011B: AddEncounter(party, 0x23, 0x01);
            L012D: AddEncounter(party, 0x24, 0x02);
            L013F: AddEncounter(party, 0x24, 0x03);
            L0151: AddEncounter(party, 0x23, 0x04);
            L0163: AddEncounter(party, 0x23, 0x05);
            L0175: AddEncounter(party, 0x24, 0x06);
            L0187: // RETURN;
        }

        private override MapEventHandler MapEvent1A => ITEMBENC_1A;
        private void ITEMBENC_1A(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem50(party, 0xC9);
            L0011: if (result.equal) goto L0042;
            L0013: ShowMessage(party, String066F); // This room is a Cleric stronghold.
            L0020: AddTreasure(party, 0x07D0, 0x00, 0x00, 0x00, 0xCB, 0xB2);
            L0040: goto L006F;
            L0042: AddTreasure(party, 0x2710, 0x00, 0x00, 0x00, 0xCD, 0xC9);
            L0062: ShowMessage(party, String0691); // A Cleric shows off a wand to his associates.
            L006F: ax = PartyCount(party);
            L0077: compare(ax, 0x0001);
            L007A: if (result.notequal) goto L0091;
            L007C: AddEncounter(party, 0x25, 0x01);
            L008E: goto L0188;
            L0091: ax = PartyCount(party);
            L0099: compare(ax, 0x0002);
            L009C: if (result.notequal) goto L00C5;
            L009E: AddEncounter(party, 0x25, 0x01);
            L00B0: AddEncounter(party, 0x25, 0x02);
            L00C2: goto L0188;
            L00C5: ax = PartyCount(party);
            L00CD: compare(ax, 0x0003);
            L00D0: if (result.notequal) goto L011C;
            L00D2: AddEncounter(party, 0x25, 0x01);
            L00E4: AddEncounter(party, 0x25, 0x02);
            L00F6: AddEncounter(party, 0x25, 0x05);
            L0108: AddEncounter(party, 0x25, 0x05);
            L011A: goto L0188;
            L011C: AddEncounter(party, 0x25, 0x01);
            L012E: AddEncounter(party, 0x25, 0x02);
            L0140: AddEncounter(party, 0x25, 0x03);
            L0152: AddEncounter(party, 0x25, 0x04);
            L0164: AddEncounter(party, 0x25, 0x05);
            L0176: AddEncounter(party, 0x25, 0x06);
            L0188: // RETURN;
        }

        private override MapEventHandler MapEvent1B => ITEMCENC_1B;
        private void ITEMCENC_1B(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem50(party, 0xBE);
            L0011: if (result.equal) goto L0041;
            L0013: ShowMessage(party, String06BE); // You step into a nest of Pincer Cobras.
            L0020: AddTreasure(party, 0x1388, 0x00, 0x00, 0x00, 0x00, 0xB7);
            L003F: goto L006E;
            L0041: AddTreasure(party, 0x2710, 0x00, 0x00, 0x00, 0xD0, 0xBE);
            L0061: ShowMessage(party, String06E5); // In a snake nest is a shining prism.
            L006E: ax = PartyCount(party);
            L0076: compare(ax, 0x0001);
            L0079: if (result.notequal) goto L00A2;
            L007B: AddEncounter(party, 0x1D, 0x01);
            L008D: AddEncounter(party, 0x1E, 0x05);
            L009F: goto L0165;
            L00A2: ax = PartyCount(party);
            L00AA: compare(ax, 0x0002);
            L00AD: if (result.notequal) goto L00F9;
            L00AF: AddEncounter(party, 0x1E, 0x01);
            L00C1: AddEncounter(party, 0x1D, 0x02);
            L00D3: AddEncounter(party, 0x1D, 0x03);
            L00E5: AddEncounter(party, 0x1E, 0x04);
            L00F7: goto L0165;
            L00F9: AddEncounter(party, 0x1D, 0x01);
            L010B: AddEncounter(party, 0x1D, 0x02);
            L011D: AddEncounter(party, 0x1D, 0x03);
            L012F: AddEncounter(party, 0x1D, 0x04);
            L0141: AddEncounter(party, 0x1E, 0x05);
            L0153: AddEncounter(party, 0x1E, 0x06);
            L0165: // RETURN;
        }

        private override MapEventHandler MapEvent1C => ARMRAENC_1C;
        private void ARMRAENC_1C(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem50(party, 0x82);
            L0011: if (result.equal) goto L0042;
            L0013: ShowMessage(party, String0709); // You interrupt a Wizards' coven.
            L0020: AddTreasure(party, 0x03E8, 0x00, 0x00, 0x00, 0xAA, 0xB9);
            L0040: goto L006F;
            L0042: AddTreasure(party, 0x1770, 0x00, 0x00, 0x00, 0xB9, 0x82);
            L0062: ShowMessage(party, String0729); // The chief Wizard of the coven wears a round breastplate.
            L006F: ax = PartyCount(party);
            L0077: compare(ax, 0x0001);
            L007A: if (result.notequal) goto L00A3;
            L007C: AddEncounter(party, 0x28, 0x01);
            L008E: AddEncounter(party, 0x28, 0x02);
            L00A0: goto L0166;
            L00A3: ax = PartyCount(party);
            L00AB: compare(ax, 0x0002);
            L00AE: if (result.notequal) goto L00FA;
            L00B0: AddEncounter(party, 0x28, 0x01);
            L00C2: AddEncounter(party, 0x28, 0x02);
            L00D4: AddEncounter(party, 0x28, 0x05);
            L00E6: AddEncounter(party, 0x28, 0x06);
            L00F8: goto L0166;
            L00FA: AddEncounter(party, 0x28, 0x01);
            L010C: AddEncounter(party, 0x28, 0x02);
            L011E: AddEncounter(party, 0x28, 0x03);
            L0130: AddEncounter(party, 0x28, 0x04);
            L0142: AddEncounter(party, 0x28, 0x05);
            L0154: AddEncounter(party, 0x28, 0x06);
            L0166: // RETURN;
        }

        private override MapEventHandler MapEvent1D => MAGICENC_1D;
        private void MAGICENC_1D(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem50(party, 0x9E);
            L0011: if (result.equal) goto L0042;
            L0013: ShowMessage(party, String0762); // Rogue Rangers use this place as a safehold.
            L0020: AddTreasure(party, 0x07D0, 0x00, 0x00, 0x00, 0xB6, 0xB8);
            L0040: goto L006F;
            L0042: AddTreasure(party, 0x1770, 0x00, 0x00, 0x00, 0xD0, 0x9E);
            L0062: ShowMessage(party, String078E); // A sly Ranger hides something inside his jacket.
            L006F: ax = PartyCount(party);
            L0077: compare(ax, 0x0001);
            L007A: if (result.notequal) goto L00A3;
            L007C: AddEncounter(party, 0x20, 0x01);
            L008E: AddEncounter(party, 0x21, 0x05);
            L00A0: goto L0166;
            L00A3: ax = PartyCount(party);
            L00AB: compare(ax, 0x0002);
            L00AE: if (result.notequal) goto L00FA;
            L00B0: AddEncounter(party, 0x20, 0x01);
            L00C2: AddEncounter(party, 0x21, 0x02);
            L00D4: AddEncounter(party, 0x21, 0x03);
            L00E6: AddEncounter(party, 0x20, 0x04);
            L00F8: goto L0166;
            L00FA: AddEncounter(party, 0x20, 0x01);
            L010C: AddEncounter(party, 0x20, 0x02);
            L011E: AddEncounter(party, 0x21, 0x03);
            L0130: AddEncounter(party, 0x21, 0x04);
            L0142: AddEncounter(party, 0x21, 0x05);
            L0154: AddEncounter(party, 0x20, 0x06);
            L0166: // RETURN;
        }

        private override MapEventHandler MapEvent1E => WEAPAENC_1E;
        private void WEAPAENC_1E(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem50(party, 0x29);
            L0011: if (result.equal) goto L0041;
            L0013: ShowMessage(party, String07BE); // Rogue Barbarians have a wrestling center here.
            L0020: AddTreasure(party, 0x1B58, 0x00, 0x00, 0x00, 0x00, 0xAD);
            L003F: goto L006E;
            L0041: AddTreasure(party, 0x2328, 0x00, 0x00, 0x00, 0xB7, 0x29);
            L0061: ShowMessage(party, String07ED); // A Barbarian throws a heavy mace aside to swing at you.
            L006E: ax = PartyCount(party);
            L0076: compare(ax, 0x0001);
            L0079: if (result.notequal) goto L00A2;
            L007B: AddEncounter(party, 0x26, 0x01);
            L008D: AddEncounter(party, 0x27, 0x05);
            L009F: goto L0165;
            L00A2: ax = PartyCount(party);
            L00AA: compare(ax, 0x0002);
            L00AD: if (result.notequal) goto L00F9;
            L00AF: AddEncounter(party, 0x27, 0x01);
            L00C1: AddEncounter(party, 0x26, 0x02);
            L00D3: AddEncounter(party, 0x26, 0x03);
            L00E5: AddEncounter(party, 0x27, 0x06);
            L00F7: goto L0165;
            L00F9: AddEncounter(party, 0x26, 0x01);
            L010B: AddEncounter(party, 0x26, 0x02);
            L011D: AddEncounter(party, 0x27, 0x03);
            L012F: AddEncounter(party, 0x27, 0x04);
            L0141: AddEncounter(party, 0x26, 0x05);
            L0153: AddEncounter(party, 0x26, 0x06);
            L0165: // RETURN;
        }

        private override MapEventHandler MapEvent1F => STRMNSTR_1F;
        private void STRMNSTR_1F(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = PartyCount(party);
            L000B: compare(ax, 0x0001);
            L000E: if (result.notequal) goto L0049;
            L0010: AddEncounter(party, 0x19, 0x01);
            L0022: AddEncounter(party, 0x19, 0x02);
            L0034: AddEncounter(party, 0x1A, 0x03);
            L0046: goto L0188;
            L0049: ax = PartyCount(party);
            L0051: compare(ax, 0x0002);
            L0054: if (result.notequal) goto L00A1;
            L0056: AddEncounter(party, 0x1A, 0x01);
            L0068: AddEncounter(party, 0x1A, 0x02);
            L007A: AddEncounter(party, 0x19, 0x03);
            L008C: AddEncounter(party, 0x19, 0x04);
            L009E: goto L0188;
            L00A1: ax = PartyCount(party);
            L00A9: compare(ax, 0x0003);
            L00AC: if (result.notequal) goto L011C;
            L00AE: AddEncounter(party, 0x19, 0x01);
            L00C0: AddEncounter(party, 0x1A, 0x02);
            L00D2: AddEncounter(party, 0x19, 0x03);
            L00E4: AddEncounter(party, 0x1A, 0x04);
            L00F6: AddEncounter(party, 0x19, 0x05);
            L0108: AddEncounter(party, 0x1A, 0x05);
            L011A: goto L0188;
            L011C: AddEncounter(party, 0x19, 0x01);
            L012E: AddEncounter(party, 0x19, 0x02);
            L0140: AddEncounter(party, 0x1A, 0x03);
            L0152: AddEncounter(party, 0x1A, 0x04);
            L0164: AddEncounter(party, 0x1A, 0x05);
            L0176: AddEncounter(party, 0x1A, 0x06);
            L0188: // RETURN;
        }

        private override MapEventHandler MapEvent25 => TELMESSA_25;
        private void TELMESSA_25(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0824); // There is a teleport in the north wall.
            L0010: // RETURN;
        }

        private override MapEventHandler MapEvent26 => TELMESSB_26;
        private void TELMESSB_26(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String084B); // There is a teleport in the south wall.
            L0010: // RETURN;
        }

        private override MapEventHandler MapEvent27 => TELMESSC_27;
        private void TELMESSC_27(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0872); // There is a teleport in the east wall.
            L0010: // RETURN;
        }

        private override MapEventHandler MapEvent28 => TELMESSD_28;
        private void TELMESSD_28(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0898); // There is a teleport in the south wall.
            L0010: // RETURN;
        }

        private override MapEventHandler MapEvent29 => LAVAMESS_29;
        private void LAVAMESS_29(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String08BF); // The heat of the adjacent lava weakens you.
            L0010: DoDamage90(party, 0x0005);
            L001D: // RETURN;
        }

        private override MapEventHandler MapEvent2A => NPCCHATA_2A;
        private void NPCCHATA_2A(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String08EA); // You encounter a Troll Knight.
            L0010: ShowPortrait(party, 0x001B);
            L001D: ax = UnknownFunctionEC(party, 0x000F);
            L002A: compare(ax, 0x000C);
            L002D: if (result.unsigned_greater_than) goto L003E;
            L002F: ShowMessage(party, String0908); // The only way to get out of this basement area is to go through the lava field. Touching the lava is deadly, as you might expect. However, even if you pass safely through the lava field, the great heat of the lava will sap your strength.
            L003C: goto L004B;
            L003E: ShowMessage(party, String09F5); // The Troll Knight scowls angrily, causing you to leave her alone.
            L004B: // RETURN;
        }

        private override MapEventHandler MapEvent2B => NPCCHATB_2B;
        private void NPCCHATB_2B(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0A36); // You encounter a Dwarf Thief.
            L0010: ShowPortrait(party, 0x0023);
            L001D: ax = UnknownFunctionEC(party, 0x000F);
            L002A: compare(ax, 0x0009);
            L002D: if (result.unsigned_greater_than) goto L003E;
            L002F: ShowMessage(party, String0A53); // I know there is a short cut through the lava field. If you can find the correct key, you will be able to use the short cut. The key also will lead you to riches.
            L003C: goto L004B;
            L003E: ShowMessage(party, String0AF5); // The Dwarf Thief runs away.
            L004B: // RETURN;
        }

        private override MapEventHandler MapEvent2C => NPCCHATC_2C;
        private void NPCCHATC_2C(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0B10); // You encounter a Halfling Ranger.
            L0010: ShowPortrait(party, 0x0021);
            L001D: ax = UnknownFunctionEC(party, 0x000F);
            L002A: compare(ax, 0x0007);
            L002D: if (result.unsigned_greater_than) goto L003E;
            L002F: ShowMessage(party, String0B31); // The dwarves who built Cleowyn's Palace transported precious metals and building blocks up to the top level by means of a teleport. I believe the teleport is somewhere in this area.
            L003C: goto L004B;
            L003E: ShowMessage(party, String0BE6); // The Halfling Ranger faints from heat stroke.
            L004B: // RETURN;
        }

        private override MapEventHandler MapEvent2D => NPCCHATD_2D;
        private void NPCCHATD_2D(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0C13); // You encounter a Gremlin Cleric.
            L0010: ShowPortrait(party, 0x002A);
            L001D: ax = UnknownFunctionEC(party, 0x000F);
            L002A: compare(ax, 0x000C);
            L002D: if (result.unsigned_greater_than) goto L003E;
            L002F: ShowMessage(party, String0C33); // Deep in the dungeon are the Pillow Labyrinths. They were formed from pillow lava that spilled into the sea. The labyrinth is formed from the hollow interior of the lava.
            L003C: goto L004B;
            L003E: ShowMessage(party, String0CDD); // The Gremlin Cleric is deep in meditation and does not answer you.
            L004B: // RETURN;
        }

    }
}
