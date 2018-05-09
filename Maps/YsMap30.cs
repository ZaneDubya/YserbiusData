namespace ZCF.Scripts.Maps {
    class YserMap30 : ACanoMapScript {
        // === Strings ================================================
        private const string String03FC = "The River of Eternity taps your life energy.";
        private const string String0429 = "You have died.";
        private const string String0438 = "Only the bravest adventurers explore the River for hidden passages.";
        private const string String047C = "Your Cyclops' Mine Key makes the tapestry translucent, revealing new passages to the southwest.";
        private const string String04DC = "The tapestry glows with the image of a Cyclops.";
        private const string String050C = "Your Dwarf Mine Key activated this platform.";
        private const string String0539 = "Your Hidden Mine Key makes the wall become transparent.";
        private const string String0571 = "There is something strange about this wall.";
        private const string String059D = "You locate a hidden door in the wall.";
        private const string String05C3 = "You locate a hidden door in the wall.";
        private const string String05E9 = "You locate a hidden door in the wall.";
        private const string String060F = "A band of dwarves moves out of the shadows.";
        private const string String063B = "The leader steps forward, his eyes fixed on the blue metal.";
        private const string String0677 = "'This magnificent blue treasure you hold can certainly do YOU no good.  Perhaps we may offer you a TRADE to remove this rock from your hands.'";
        private const string String0706 = "A key appears from beneath his pack.";
        private const string String072B = "'We offer you this key to our kingdom in return.'";
        private const string String075D = "A beam of bluish sunshine filters down from the surface above and reflects on a ceremonial dwarven rock.";
        private const string String07C6 = "You fall into a lava pit and die.";
        private const string String07E8 = "This gate leads to DWARF KINGDOM.";
        private const string String080A = "This gate leads to RIVERS END.";
        private const string String0829 = "Hobgoblins appear from the surrounding walls.";
        private const string String0857 = "The air is heavy with the scent of burnt flesh.";
        private const string String0887 = "You wander into a renegade adventurer camp.";
        private const string String08B3 = "A den of manticores is disturbed.";
        private const string String08D5 = "Stone fragments litter the floor.";
        private const string String08F7 = "A huge Cyclops appears from behind large boulders.";
        private const string String092A = "You encounter adventurers slaying a dragon.  They do not welcome your intrusion.";
        private const string String097B = "Creatures fight over a stone key.";
        private const string String099D = "Creatures fight over a green tree-shaped key";
        private const string String09CA = "Your full health is restored by the ancient waters of RoundBrook Fountain.";
        private const string String0A15 = "You feel all your health restored after sipping from JasperStone Fountain.";
        private const string String0A60 = "The waters of RockyFlat Fountain restores your health.";
        private const string String0A97 = "Your mana is recharged by drinking the magical waters of Omar Fountain.";
        private const string String0ADF = "Your magical powers are recharged by the heated steams of Venivor Geyser.";
        private const string String0B29 = "Your mana is increased in a whirlpool at the edge of the river.";
        private const string String0B69 = "A message is inscribed on the wall -- ";
        private const string String0B90 = "The Tapestry of the Moons requires a spectrum of color to open.";
        private const string String0BD0 = "A gust of wind from caverns above catches your attention.";
        private const string String0C0A = "'I am Zephyr.  ";
        private const string String0C1A = "'Only the FlexSword can bend against the Wind Elemental's gail.'";
        private const string String0C5B = "A collection of runes reveals a message -- ";
        private const string String0C87 = "It is said that the Dwarves can build magnificent creations and vessels out of golden threads.";
        private const string String0CE6 = "Written in blood on the wall is the message -- ";
        private const string String0D16 = "Acquire the Sunbeam Key at the Dwarf Ceremonial Rock to access the Dwarf Kingdom.";
        
        // === Functions ================================================
        private override MapEventHandler MapEvent01 => FnRIVER_01;
        private void FnRIVER_01(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String03FC); // The River of Eternity taps your life energy.
            L0010: UnknownFunctionC4(party);
            L0018: ax = GetMaxHits74(party);
            L001F: bx = 0x0004;
            L0022: dx = ax % bx; ax = ax / bx; // (signed, dx = quotient)
            L0025: DoDamage90(party, ax);
            L002F: ax = GetCurrentHits70(party);
            L0036: RefreshCompareFlags(ax);
            L0038: if (result.unsigned_greater_than) goto L0047;
            L003A: ShowMessage(party, String0429); // You have died.
            L0047: ax = HasItem50(party, 0xD5);
            L0055: if (result.notequal) goto L006C;
            L0057: ax = CheckState04(party, 0x02, 0x6D);
            L0068: RefreshCompareFlags(ax);
            L006A: if (result.equal) goto L007E;
            L006C: SetMove38(party, 0x00, 0x9C);
            L007C: goto L008F;
            L007E: SetMove38(party, 0x03, 0x9C);
            L008F: // RETURN;
        }

        private override MapEventHandler MapEvent02 => FnRIVRBANK_02;
        private void FnRIVRBANK_02(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0438); // Only the bravest adventurers explore the River for hidden passages.
            L0010: // RETURN;
        }

        private override MapEventHandler MapEvent03 => FnSTEPCYCL_03;
        private void FnSTEPCYCL_03(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem50(party, 0xD6);
            L0011: if (result.notequal) goto L0028;
            L0013: ax = CheckState04(party, 0x02, 0x6E);
            L0024: RefreshCompareFlags(ax);
            L0026: if (result.equal) goto L0071;
            L0028: Push(01);
            L002C: PushStack(0x00);
            L002F: ax = GetNextTile20(party);
            L0036: PushStack(ax);
            L0037: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L0041: RemoveItem4C(party, 0xD6);
            L004D: SetState00(party, 0x02, 0x6E, 0x01);
            L0062: ShowMessage(party, String047C); // Your Cyclops' Mine Key makes the tapestry translucent, revealing new passages to the southwest.
            L006F: goto L007E;
            L0071: ShowMessage(party, String04DC); // The tapestry glows with the image of a Cyclops.
            L007E: // RETURN;
        }

        private override MapEventHandler MapEvent04 => FnSTEPMINE_04;
        private void FnSTEPMINE_04(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem50(party, 0xD5);
            L0011: if (result.notequal) goto L0028;
            L0013: ax = CheckState04(party, 0x02, 0x6D);
            L0024: RefreshCompareFlags(ax);
            L0026: if (result.equal) goto L0068;
            L0028: RemoveItem4C(party, 0xD5);
            L0034: SetState00(party, 0x02, 0x6D, 0x01);
            L0049: SetMove38(party, 0x00, 0x9C);
            L0059: ShowMessage(party, String050C); // Your Dwarf Mine Key activated this platform.
            L0066: goto L0079;
            L0068: SetMove38(party, 0x03, 0x9C);
            L0079: // RETURN;
        }

        private override MapEventHandler MapEvent05 => FnSTEPHIDE_05;
        private void FnSTEPHIDE_05(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem50(party, 0xD7);
            L0011: if (result.notequal) goto L0028;
            L0013: ax = CheckState04(party, 0x02, 0x6F);
            L0024: RefreshCompareFlags(ax);
            L0026: if (result.equal) goto L0076;
            L0028: RemoveItem4C(party, 0xD7);
            L0034: SetState00(party, 0x02, 0x6F, 0x01);
            L0049: Push(01);
            L004D: ax = GetFacing24(party);
            L0054: PushStack(ax);
            L0055: ax = GetNextTile20(party);
            L005C: PushStack(ax);
            L005D: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L0067: ShowMessage(party, String0539); // Your Hidden Mine Key makes the wall become transparent.
            L0074: goto L0083;
            L0076: ShowMessage(party, String0571); // There is something strange about this wall.
            L0083: // RETURN;
        }

        private override MapEventHandler MapEvent06 => FnASENDB_06;
        private void FnASENDB_06(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetMoveMap(party, 0x02, 0xCC, 0x02, 0x38);
            L001E: // RETURN;
        }

        private override MapEventHandler MapEvent09 => FnDSENDC_09;
        private void FnDSENDC_09(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetMoveMap(party, 0x00, 0xE1, 0x02, 0x38);
            L001D: // RETURN;
        }

        private override MapEventHandler MapEvent0A => FnESENDF_0A;
        private void FnESENDF_0A(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetMoveMap(party, 0x00, 0xFD, 0x02, 0x38);
            L001D: // RETURN;
        }

        private override MapEventHandler MapEvent0C => FnSECDOORA_0C;
        private void FnSECDOORA_0C(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = UsedSkill58(party, 0x0D) // returns 0 if did not use, compares to 2nd op if did use;
            L000F: compare(ax, 0x000B);
            L0012: if (result.above or result.equal) goto L0029;
            L0014: ax = UsedItem54(party, 0xBE, 0xBE);
            L0027: if (result.equal) goto L0072;
            L0029: ShowMessage(party, String059D); // You locate a hidden door in the wall.
            L0036: ax = GetFacing24(party);
            L003D: PushStack(ax);
            L003E: ax = GetNextTile20(party);
            L0045: PushStack(ax);
            L0046: Push(01);
            L004A: SetUnblocked30(party);
            L0054: Push(01);
            L0058: ax = GetFacing24(party);
            L005F: PushStack(ax);
            L0060: ax = GetNextTile20(party);
            L0067: PushStack(ax);
            L0068: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L0072: // RETURN;
        }

        private override MapEventHandler MapEvent0D => FnSECDOORB_0D;
        private void FnSECDOORB_0D(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = UsedSkill58(party, 0x0D) // returns 0 if did not use, compares to 2nd op if did use;
            L000F: compare(ax, 0x000B);
            L0012: if (result.above or result.equal) goto L0029;
            L0014: ax = UsedItem54(party, 0xBE, 0xBE);
            L0027: if (result.equal) goto L0072;
            L0029: ShowMessage(party, String05C3); // You locate a hidden door in the wall.
            L0036: ax = GetFacing24(party);
            L003D: PushStack(ax);
            L003E: ax = GetNextTile20(party);
            L0045: PushStack(ax);
            L0046: Push(01);
            L004A: SetUnblocked30(party);
            L0054: Push(01);
            L0058: ax = GetFacing24(party);
            L005F: PushStack(ax);
            L0060: ax = GetNextTile20(party);
            L0067: PushStack(ax);
            L0068: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L0072: // RETURN;
        }

        private override MapEventHandler MapEvent0E => FnSECDOORC_0E;
        private void FnSECDOORC_0E(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = UsedSkill58(party, 0x0D) // returns 0 if did not use, compares to 2nd op if did use;
            L000F: compare(ax, 0x000B);
            L0012: if (result.above or result.equal) goto L0029;
            L0014: ax = UsedItem54(party, 0xBE, 0xBE);
            L0027: if (result.equal) goto L0074;
            L0029: ShowMessage(party, String05E9); // You locate a hidden door in the wall.
            L0036: ax = GetFacing24(party);
            L003D: PushStack(ax);
            L003E: ax = GetNextTile20(party);
            L0045: PushStack(ax);
            L0046: Push(01);
            L004A: SetUnblocked30(party);
            L0054: Push(01);
            L0058: ax = GetFacing24(party);
            L005F: PushStack(ax);
            L0060: ax = GetNextTile20(party);
            L0067: PushStack(ax);
            L0068: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L0072: goto L0091;
            L0074: PushStack(0x00);
            L0077: ax = GetFacing24(party);
            L007E: PushStack(ax);
            L007F: ax = GetNextTile20(party);
            L0086: PushStack(ax);
            L0087: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L0091: // RETURN;
        }

        private override MapEventHandler MapEvent0F => FnGSENDH_0F;
        private void FnGSENDH_0F(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetMoveMap(party, 0x00, 0x02, 0x02, 0x38);
            L001D: // RETURN;
        }

        private override MapEventHandler MapEvent11 => FnISENDJ_11;
        private void FnISENDJ_11(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetMoveMap(party, 0x02, 0x60, 0x02, 0x38);
            L001E: // RETURN;
        }

        private override MapEventHandler MapEvent14 => FnSUNBEAM_14;
        private void FnSUNBEAM_14(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem50(party, 0xEF);
            L0011: if (result.equal) goto L007B;
            L0013: ShowPortrait(party, 0x001C);
            L0020: ShowMessage(party, String060F); // A band of dwarves moves out of the shadows.
            L002D: ShowMessage(party, String063B); // The leader steps forward, his eyes fixed on the blue metal.
            L003A: ShowMessage(party, String0677); // 'This magnificent blue treasure you hold can certainly do YOU no good.  Perhaps we may offer you a TRADE to remove this rock from your hands.'
            L0047: ShowMessage(party, String0706); // A key appears from beneath his pack.
            L0054: ShowMessage(party, String072B); // 'We offer you this key to our kingdom in return.'
            L0061: RemoveItem4C(party, 0xEF);
            L006D: GiveItem48(party, 0xD4);
            L0079: goto L0088;
            L007B: ShowMessage(party, String075D); // A beam of bluish sunshine filters down from the surface above and reflects on a ceremonial dwarven rock.
            L0088: // RETURN;
        }

        private override MapEventHandler MapEvent15 => FnLAVA_15;
        private void FnLAVA_15(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String07C6); // You fall into a lava pit and die.
            L0010: ax = GetMaxHits74(party);
            L0017: DoDamage90(party, ax);
            L0021: // RETURN;
        }

        private override MapEventHandler MapEvent16 => FnGATEA_16;
        private void FnGATEA_16(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String07E8); // This gate leads to DWARF KINGDOM.
            L0010: SetMoveMap(party, 0x00, 0x3F, 0x01, 0x38);
            L002A: // RETURN;
        }

        private override MapEventHandler MapEvent17 => FnGATEB_17;
        private void FnGATEB_17(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String080A); // This gate leads to RIVERS END.
            L0010: SetMoveMap(party, 0x00, 0x0B, 0x03, 0x38);
            L002A: // RETURN;
        }

        private override MapEventHandler MapEvent18 => Fn_18;
        private void Fn_18(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0829); // Hobgoblins appear from the surrounding walls.
            L0010: AddEncounter(party, 0x24, 0x01);
            L0022: AddEncounter(party, 0x24, 0x02);
            L0034: AddEncounter(party, 0x0E, 0x03);
            L0046: AddEncounter(party, 0x0E, 0x04);
            L0058: AddEncounter(party, 0x25, 0x05);
            L006A: AddEncounter(party, 0x25, 0x06);
            L007C: // RETURN;
        }

        private override MapEventHandler MapEvent19 => FnENCB_19;
        private void FnENCB_19(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0857); // The air is heavy with the scent of burnt flesh.
            L0010: AddEncounter(party, 0x12, 0x01);
            L0022: AddEncounter(party, 0x12, 0x02);
            L0034: AddEncounter(party, 0x28, 0x03);
            L0046: AddEncounter(party, 0x28, 0x04);
            L0058: AddEncounter(party, 0x15, 0x05);
            L006A: AddEncounter(party, 0x15, 0x06);
            L007C: // RETURN;
        }

        private override MapEventHandler MapEvent1A => FnENCC_1A;
        private void FnENCC_1A(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0887); // You wander into a renegade adventurer camp.
            L0010: AddEncounter(party, 0x1E, 0x01);
            L0022: AddEncounter(party, 0x19, 0x02);
            L0034: AddEncounter(party, 0x1C, 0x03);
            L0046: AddEncounter(party, 0x05, 0x04);
            L0058: AddEncounter(party, 0x03, 0x05);
            L006A: AddEncounter(party, 0x03, 0x06);
            L007C: // RETURN;
        }

        private override MapEventHandler MapEvent1B => FnENCD_1B;
        private void FnENCD_1B(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String08B3); // A den of manticores is disturbed.
            L0010: AddEncounter(party, 0x18, 0x01);
            L0022: AddEncounter(party, 0x18, 0x02);
            L0034: AddEncounter(party, 0x19, 0x03);
            L0046: AddEncounter(party, 0x19, 0x04);
            L0058: AddEncounter(party, 0x1A, 0x05);
            L006A: AddEncounter(party, 0x04, 0x06);
            L007C: // RETURN;
        }

        private override MapEventHandler MapEvent1C => FnENCE_1C;
        private void FnENCE_1C(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String08D5); // Stone fragments litter the floor.
            L0010: AddEncounter(party, 0x11, 0x01);
            L0022: AddEncounter(party, 0x11, 0x02);
            L0034: AddEncounter(party, 0x10, 0x03);
            L0046: AddEncounter(party, 0x10, 0x04);
            L0058: AddEncounter(party, 0x16, 0x05);
            L006A: AddEncounter(party, 0x22, 0x06);
            L007C: // RETURN;
        }

        private override MapEventHandler MapEvent1D => FnENCF_1D;
        private void FnENCF_1D(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x0B, 0x01);
            L0015: AddEncounter(party, 0x0B, 0x02);
            L0027: AddEncounter(party, 0x0C, 0x03);
            L0039: AddEncounter(party, 0x0C, 0x04);
            L004B: AddEncounter(party, 0x1F, 0x05);
            L005D: AddEncounter(party, 0x1F, 0x05);
            L006F: // RETURN;
        }

        private override MapEventHandler MapEvent1E => FnENCG_1E;
        private void FnENCG_1E(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x0F, 0x01);
            L0015: AddEncounter(party, 0x10, 0x02);
            L0027: AddEncounter(party, 0x26, 0x03);
            L0039: AddEncounter(party, 0x18, 0x04);
            L004B: AddEncounter(party, 0x27, 0x05);
            L005D: AddEncounter(party, 0x28, 0x06);
            L006F: // RETURN;
        }

        private override MapEventHandler MapEvent1F => FnENCH_1F;
        private void FnENCH_1F(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String08F7); // A huge Cyclops appears from behind large boulders.
            L0010: AddEncounter(party, 0x0E, 0x01);
            L0022: AddEncounter(party, 0x0E, 0x02);
            L0034: AddEncounter(party, 0x21, 0x03);
            L0046: ax = HasItem50(party, 0xF1);
            L0054: if (result.equal) goto L0078;
            L0056: AddTreasure(party, 0x09C4, 0x00, 0x00, 0x00, 0xD0, 0xC6);
            L0076: goto L0097;
            L0078: AddTreasure(party, 0x2710, 0x00, 0x00, 0x00, 0x00, 0xF1);
            L0097: // RETURN;
        }

        private override MapEventHandler MapEvent20 => FnENCI_20;
        private void FnENCI_20(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x17, 0x01);
            L0015: AddEncounter(party, 0x17, 0x02);
            L0027: AddEncounter(party, 0x14, 0x05);
            L0039: AddEncounter(party, 0x14, 0x06);
            L004B: // RETURN;
        }

        private override MapEventHandler MapEvent21 => FnENCJ_21;
        private void FnENCJ_21(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x23, 0x01);
            L0015: AddEncounter(party, 0x23, 0x02);
            L0027: AddEncounter(party, 0x1F, 0x03);
            L0039: AddEncounter(party, 0x1F, 0x04);
            L004B: AddEncounter(party, 0x14, 0x05);
            L005D: AddEncounter(party, 0x14, 0x06);
            L006F: // RETURN;
        }

        private override MapEventHandler MapEvent22 => FnENCK_22;
        private void FnENCK_22(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x18, 0x01);
            L0015: AddEncounter(party, 0x18, 0x02);
            L0027: AddEncounter(party, 0x22, 0x03);
            L0039: AddEncounter(party, 0x26, 0x04);
            L004B: // RETURN;
        }

        private override MapEventHandler MapEvent23 => FnENCL_23;
        private void FnENCL_23(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x1F, 0x01);
            L0015: AddEncounter(party, 0x1F, 0x02);
            L0027: AddEncounter(party, 0x0A, 0x03);
            L0039: AddEncounter(party, 0x0A, 0x04);
            L004B: AddEncounter(party, 0x16, 0x05);
            L005D: AddEncounter(party, 0x16, 0x05);
            L006F: // RETURN;
        }

        private override MapEventHandler MapEvent24 => FnENCM_24;
        private void FnENCM_24(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String092A); // You encounter adventurers slaying a dragon.  They do not welcome your intrusion.
            L0010: AddEncounter(party, 0x19, 0x01);
            L0022: AddEncounter(party, 0x1B, 0x02);
            L0034: AddEncounter(party, 0x1D, 0x03);
            L0046: AddEncounter(party, 0x03, 0x04);
            L0058: AddEncounter(party, 0x05, 0x05);
            L006A: AddEncounter(party, 0x16, 0x05);
            L007C: // RETURN;
        }

        private override MapEventHandler MapEvent25 => FnENCN_25;
        private void FnENCN_25(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x23, 0x01);
            L0015: AddEncounter(party, 0x23, 0x02);
            L0027: AddEncounter(party, 0x12, 0x03);
            L0039: AddEncounter(party, 0x12, 0x04);
            L004B: AddEncounter(party, 0x22, 0x05);
            L005D: ax = HasItem50(party, 0xD5);
            L006B: if (result.equal) goto L008F;
            L006D: AddTreasure(party, 0x07D0, 0x00, 0x00, 0x00, 0xB7, 0x98);
            L008D: goto L00BB;
            L008F: ShowMessage(party, String097B); // Creatures fight over a stone key.
            L009C: AddTreasure(party, 0x2710, 0x00, 0x00, 0x00, 0x00, 0xD5);
            L00BB: // RETURN;
        }

        private override MapEventHandler MapEvent26 => FnENCO_26;
        private void FnENCO_26(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x23, 0x01);
            L0015: AddEncounter(party, 0x23, 0x02);
            L0027: AddEncounter(party, 0x12, 0x03);
            L0039: AddEncounter(party, 0x12, 0x04);
            L004B: AddEncounter(party, 0x22, 0x05);
            L005D: ax = HasItem50(party, 0xD8);
            L006B: if (result.equal) goto L008E;
            L006D: AddTreasure(party, 0x07D0, 0x00, 0x00, 0x00, 0x00, 0xD0);
            L008C: goto L00BA;
            L008E: ShowMessage(party, String099D); // Creatures fight over a green tree-shaped key
            L009B: AddTreasure(party, 0x2328, 0x00, 0x00, 0x00, 0x00, 0xD8);
            L00BA: // RETURN;
        }

        private override MapEventHandler MapEvent27 => FnHEALFA_27;
        private void FnHEALFA_27(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(party, 0x0042);
            L0010: ax = GetMaxHits74(party);
            L0017: AddHealth94(party, ax);
            L0021: ShowMessage(party, String09CA); // Your full health is restored by the ancient waters of RoundBrook Fountain.
            L002E: // RETURN;
        }

        private override MapEventHandler MapEvent28 => FnHEALFB_28;
        private void FnHEALFB_28(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(party, 0x0042);
            L0010: ax = GetMaxHits74(party);
            L0017: AddHealth94(party, ax);
            L0021: ShowMessage(party, String0A15); // You feel all your health restored after sipping from JasperStone Fountain.
            L002E: // RETURN;
        }

        private override MapEventHandler MapEvent29 => FnHEALFC_29;
        private void FnHEALFC_29(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(party, 0x0042);
            L0010: ax = GetMaxHits74(party);
            L0017: AddHealth94(party, ax);
            L0021: ShowMessage(party, String0A60); // The waters of RockyFlat Fountain restores your health.
            L002E: // RETURN;
        }

        private override MapEventHandler MapEvent2A => FnMANAFA_2A;
        private void FnMANAFA_2A(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(party, 0x0042);
            L0010: AddMana(party, 0x07D0);
            L001D: ShowMessage(party, String0A97); // Your mana is recharged by drinking the magical waters of Omar Fountain.
            L002A: // RETURN;
        }

        private override MapEventHandler MapEvent2B => FnMANAFB_2B;
        private void FnMANAFB_2B(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddMana(party, 0x07D0);
            L0010: ShowMessage(party, String0ADF); // Your magical powers are recharged by the heated steams of Venivor Geyser.
            L001D: // RETURN;
        }

        private override MapEventHandler MapEvent2C => FnMANAFC_2C;
        private void FnMANAFC_2C(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddMana(party, 0x07D0);
            L0010: ShowMessage(party, String0B29); // Your mana is increased in a whirlpool at the edge of the river.
            L001D: // RETURN;
        }

        private override MapEventHandler MapEvent2D => FnCLUEA_2D;
        private void FnCLUEA_2D(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0B69); // A message is inscribed on the wall -- 
            L0010: ShowRunes(party, String0B90); // The Tapestry of the Moons requires a spectrum of color to open.
            L001D: // RETURN;
        }

        private override MapEventHandler MapEvent2E => FnCLUEB_2E;
        private void FnCLUEB_2E(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0BD0); // A gust of wind from caverns above catches your attention.
            L0010: ShowMessage(party, String0C0A); // 'I am Zephyr.  
            L001D: ShowMessage(party, String0C1A); // 'Only the FlexSword can bend against the Wind Elemental's gail.'
            L002A: // RETURN;
        }

        private override MapEventHandler MapEvent2F => FnCLUEC_2F;
        private void FnCLUEC_2F(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0C5B); // A collection of runes reveals a message -- 
            L0010: ShowRunes(party, String0C87); // It is said that the Dwarves can build magnificent creations and vessels out of golden threads.
            L001D: // RETURN;
        }

        private override MapEventHandler MapEvent30 => FnCLUED_30;
        private void FnCLUED_30(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0CE6); // Written in blood on the wall is the message -- 
            L0010: ShowRunes(party, String0D16); // Acquire the Sunbeam Key at the Dwarf Ceremonial Rock to access the Dwarf Kingdom.
            L001D: // RETURN;
        }

    }
}
