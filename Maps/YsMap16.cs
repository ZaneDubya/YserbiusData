namespace ZCF.Scripts.Maps {
    class YserMap16 : ACanoMapScript {
        // === Strings ================================================
        private const string String03FC = "You found a trapdoor.";
        private const string String0412 = "You fall through a trapdoor.";
        private const string String042F = "You spot a trapdoor.";
        private const string String0444 = "You fall through a trapdoor.";
        private const string String0461 = "You detect a trapdoor.";
        private const string String0478 = "You fall through a trapdoor.";
        private const string String0495 = "You escape a trapdoor.";
        private const string String04AC = "You fall through a trapdoor.";
        private const string String04C9 = "You notice a trapdoor.";
        private const string String04E0 = "You fall through a trapdoor.";
        private const string String04FD = "There is a trapdoor in the floor.";
        private const string String051F = "You fall through a trapdoor.";
        private const string String053C = "You discover a trapdoor.";
        private const string String0555 = "You fall through a trapdoor.";
        private const string String0572 = "You detect a trapdoor.";
        private const string String0589 = "You fall through a trapdoor.";
        private const string String05A6 = "You spot a trapdoor.";
        private const string String05BB = "You fall through a trapdoor.";
        private const string String05D8 = "You detect a trapdoor.";
        private const string String05EF = "You fall through a trapdoor.";
        private const string String060C = "A trapdoor is in this room.";
        private const string String0628 = "You fall through a trapdoor.";
        private const string String0645 = "You sidestep a trapdoor.";
        private const string String065E = "You fall through a trapdoor.";
        private const string String067B = "You avoid a trapdoor.";
        private const string String0691 = "You fall through a trapdoor.";
        private const string String06AE = "You soon have the door unlocked.";
        private const string String06CF = "The door is locked.";
        private const string String06E3 = "Your aptitude at opening locks pays off.";
        private const string String070C = "The door is locked.";
        private const string String0720 = "You succeed at picking the door lock.";
        private const string String0746 = "The door is locked.";
        private const string String075A = "The door lock is no match for your skills.";
        private const string String0785 = "The door is locked.";
        private const string String0799 = "You deftly trip the door lock.";
        private const string String07B8 = "The door is locked.";
        private const string String07CC = "You quickly have the door open.";
        private const string String07EC = "The door is locked.";
        private const string String0800 = "You push on the door and open it.";
        private const string String0822 = "The door is stuck shut.";
        private const string String083A = "You force the door open by muscle power.";
        private const string String0863 = "The door is stuck shut.";
        private const string String087B = "The Domicile Key opens the door!";
        private const string String089C = "The door is locked.";
        private const string String08B0 = "You have spotted a secret door!";
        private const string String08D0 = "Clerics use this room as a sanctuary.";
        private const string String08F6 = "A scroll fall from a Cleric's robe.";
        private const string String091A = "Rogues use this room as a hideout.";
        private const string String093D = "A Barbarian drops some potions when she sees you.";
        private const string String096F = "You sense evil in the room.";
        private const string String098B = "You see a wand on the floor.";
        private const string String09A8 = "The stench of reptiles assails you.";
        private const string String09CC = "You hear hissing.";
        private const string String09DE = "Rogues surprise you.";
        private const string String09F3 = "A Knight drops a poleaxe as you approach.";
        private const string String0A1D = "Nightmares loom up before you.";
        private const string String0A3C = "A Nightmare throws a bow aside to attack.";
        private const string String0A66 = "You stumble on some Dwarf Knights.";
        private const string String0A89 = "The brilliant chainmail worn by a Knight blinds you.";
        private const string String0ABE = "You enter a den of thieves.";
        private const string String0ADA = "A Halfling Thief tries to wield a large shield.";
        private const string String0B0A = "The room is jammed with Rogues.";
        private const string String0B2A = "A Ranger wears the King's Domicile Key around his neck.";
        private const string String0B62 = "There is a teleport in the south wall.";
        private const string String0B89 = "There is a teleport to the south.";
        private const string String0BAB = "There is a teleport to the north.";
        private const string String0BCD = "Banshees haunt this room.";
        private const string String0BE7 = "Deinons protect a chest.";
        private const string String0C00 = "Stairs through the east gateway lead upstairs.";
        private const string String0C2F = "There are stairs to the north beyond the gateway.";
        private const string String0C61 = "There is an elevator platform to the north.";
        private const string String0C8D = "Stairs through the west gateway lead down a level.";
        private const string String0CC0 = "You encounter a Human Wizard.";
        private const string String0CDE = "This is the lowest level of Cleowyn's Palace, yet you are merely at the beginning of the dungeon proper.";
        private const string String0D47 = "The Human Wizard chortles softly.";
        private const string String0D69 = "You encounter a Gnome Thief.";
        private const string String0D86 = "In the king's quarters is an elevator that will lift you up to the King's Palace. Cleowyn used this elevator to  by-pass the traps around his throne.";
        private const string String0E1C = "The Gnome Thief tiptoes away as you draw near.";
        private const string String0E4B = "You encounter a Gnome Barbarian.";
        private const string String0E6C = "The name of the Elemental bound by the wizard Arnakkian is En-li-kil. This Elemental commands Time itself.";
        private const string String0ED7 = "The Gnome Barbarian warns you to stay away.";
        
        // === Functions ================================================
        private override MapEventHandler MapEvent01 => FnSTRSTELE_01;
        private void FnSTRSTELE_01(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetMoveMap(party, 0x03, 0xE0, 0x03, 0x03);
            L001E: // RETURN;
        }

        private override MapEventHandler MapEvent02 => FnSTRSTELE_02;
        private void FnSTRSTELE_02(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetMoveMap(party, 0x02, 0x8D, 0x01, 0x05);
            L001E: // RETURN;
        }

        private override MapEventHandler MapEvent03 => FnPLATFMUP_03;
        private void FnPLATFMUP_03(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetMoveMap(party, 0x03, 0xB4, 0x06, 0x02);
            L001E: // RETURN;
        }

        private override MapEventHandler MapEvent04 => FnTELPORTA_04;
        private void FnTELPORTA_04(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetMoveMap(party, 0x01, 0x68, 0x03, 0x01);
            L001E: // RETURN;
        }

        private override MapEventHandler MapEvent05 => FnTELEPORT_05;
        private void FnTELEPORT_05(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetMoveMap(party, 0x02, 0x24, 0x03, 0x03);
            L001E: // RETURN;
        }

        private override MapEventHandler MapEvent06 => FnTELPORTC_06;
        private void FnTELPORTC_06(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetMoveMap(party, 0x03, 0xAF, 0x02, 0x05);
            L001E: // RETURN;
        }

        private override MapEventHandler MapEvent07 => FnTRAPDORA_07;
        private void FnTRAPDORA_07(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = UsedSkill58(party, 0x0D) // returns 0 if did not use, compares to 2nd op if did use;
            L000F: compare(ax, 0x000A);
            L0012: if (result.above or result.equal) goto L0062;
            L0014: ax = UsedSpell64(party, 0x17); // returns 0 if did not use on map, level if used
            L0020: RefreshCompareFlags(ax);
            L0022: if (result.notequal) goto L0062;
            L0024: ax = UsedItem54(party, 0xA2, 0xA2);
            L0037: if (result.notequal) goto L0062;
            L0039: ax = UsedItem54(party, 0xBE, 0xBE);
            L004C: if (result.notequal) goto L0062;
            L004E: ax = CheckState08(party, 0x00, 0x01);
            L0060: if (result.equal) goto L0085;
            L0062: ShowMessage(party, String03FC); // You found a trapdoor.
            L006F: SetState00(party, 0x00, 0x01, 0x01);
            L0083: goto L00AC;
            L0085: SetMoveMap(party, 0x00, 0x89, 0x02, 0x05);
            L009F: ShowMessage(party, String0412); // You fall through a trapdoor.
            L00AC: // RETURN;
        }

        private override MapEventHandler MapEvent08 => FnTRAPDORB_08;
        private void FnTRAPDORB_08(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = UsedSkill58(party, 0x0D) // returns 0 if did not use, compares to 2nd op if did use;
            L000F: compare(ax, 0x000A);
            L0012: if (result.above or result.equal) goto L0062;
            L0014: ax = UsedSpell64(party, 0x17); // returns 0 if did not use on map, level if used
            L0020: RefreshCompareFlags(ax);
            L0022: if (result.notequal) goto L0062;
            L0024: ax = UsedItem54(party, 0xA2, 0xA2);
            L0037: if (result.notequal) goto L0062;
            L0039: ax = UsedItem54(party, 0xBE, 0xBE);
            L004C: if (result.notequal) goto L0062;
            L004E: ax = CheckState08(party, 0x00, 0x01);
            L0060: if (result.equal) goto L0085;
            L0062: ShowMessage(party, String042F); // You spot a trapdoor.
            L006F: SetState00(party, 0x00, 0x01, 0x01);
            L0083: goto L00AD;
            L0085: SetMoveMap(party, 0x01, 0x8C, 0x02, 0x05);
            L00A0: ShowMessage(party, String0444); // You fall through a trapdoor.
            L00AD: // RETURN;
        }

        private override MapEventHandler MapEvent09 => FnTRAPDORC_09;
        private void FnTRAPDORC_09(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = UsedSkill58(party, 0x0D) // returns 0 if did not use, compares to 2nd op if did use;
            L000F: compare(ax, 0x000A);
            L0012: if (result.above or result.equal) goto L0062;
            L0014: ax = UsedSpell64(party, 0x17); // returns 0 if did not use on map, level if used
            L0020: RefreshCompareFlags(ax);
            L0022: if (result.notequal) goto L0062;
            L0024: ax = UsedItem54(party, 0xA2, 0xA2);
            L0037: if (result.notequal) goto L0062;
            L0039: ax = UsedItem54(party, 0xBE, 0xBE);
            L004C: if (result.notequal) goto L0062;
            L004E: ax = CheckState08(party, 0x00, 0x01);
            L0060: if (result.equal) goto L0085;
            L0062: ShowMessage(party, String0461); // You detect a trapdoor.
            L006F: SetState00(party, 0x00, 0x01, 0x01);
            L0083: goto L00AD;
            L0085: SetMoveMap(party, 0x03, 0x91, 0x02, 0x05);
            L00A0: ShowMessage(party, String0478); // You fall through a trapdoor.
            L00AD: // RETURN;
        }

        private override MapEventHandler MapEvent0A => FnTRAPDORD_0A;
        private void FnTRAPDORD_0A(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = UsedSkill58(party, 0x0D) // returns 0 if did not use, compares to 2nd op if did use;
            L000F: compare(ax, 0x000A);
            L0012: if (result.above or result.equal) goto L0062;
            L0014: ax = UsedSpell64(party, 0x17); // returns 0 if did not use on map, level if used
            L0020: RefreshCompareFlags(ax);
            L0022: if (result.notequal) goto L0062;
            L0024: ax = UsedItem54(party, 0xA2, 0xA2);
            L0037: if (result.notequal) goto L0062;
            L0039: ax = UsedItem54(party, 0xBE, 0xBE);
            L004C: if (result.notequal) goto L0062;
            L004E: ax = CheckState08(party, 0x00, 0x01);
            L0060: if (result.equal) goto L0085;
            L0062: ShowMessage(party, String0495); // You escape a trapdoor.
            L006F: SetState00(party, 0x00, 0x01, 0x01);
            L0083: goto L00AD;
            L0085: SetMoveMap(party, 0x03, 0x9D, 0x02, 0x05);
            L00A0: ShowMessage(party, String04AC); // You fall through a trapdoor.
            L00AD: // RETURN;
        }

        private override MapEventHandler MapEvent0B => FnTRAPDORE_0B;
        private void FnTRAPDORE_0B(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = UsedSkill58(party, 0x0D) // returns 0 if did not use, compares to 2nd op if did use;
            L000F: compare(ax, 0x000A);
            L0012: if (result.above or result.equal) goto L0062;
            L0014: ax = UsedSpell64(party, 0x17); // returns 0 if did not use on map, level if used
            L0020: RefreshCompareFlags(ax);
            L0022: if (result.notequal) goto L0062;
            L0024: ax = UsedItem54(party, 0xA2, 0xA2);
            L0037: if (result.notequal) goto L0062;
            L0039: ax = UsedItem54(party, 0xBE, 0xBE);
            L004C: if (result.notequal) goto L0062;
            L004E: ax = CheckState08(party, 0x00, 0x01);
            L0060: if (result.equal) goto L0085;
            L0062: ShowMessage(party, String04C9); // You notice a trapdoor.
            L006F: SetState00(party, 0x00, 0x01, 0x01);
            L0083: goto L00AD;
            L0085: SetMoveMap(party, 0x03, 0xAB, 0x02, 0x05);
            L00A0: ShowMessage(party, String04E0); // You fall through a trapdoor.
            L00AD: // RETURN;
        }

        private override MapEventHandler MapEvent0C => FnTRAPDORF_0C;
        private void FnTRAPDORF_0C(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = UsedSkill58(party, 0x0D) // returns 0 if did not use, compares to 2nd op if did use;
            L000F: compare(ax, 0x000A);
            L0012: if (result.above or result.equal) goto L0062;
            L0014: ax = UsedSpell64(party, 0x17); // returns 0 if did not use on map, level if used
            L0020: RefreshCompareFlags(ax);
            L0022: if (result.notequal) goto L0062;
            L0024: ax = UsedItem54(party, 0xA2, 0xA2);
            L0037: if (result.notequal) goto L0062;
            L0039: ax = UsedItem54(party, 0xBE, 0xBE);
            L004C: if (result.notequal) goto L0062;
            L004E: ax = CheckState08(party, 0x00, 0x01);
            L0060: if (result.equal) goto L0085;
            L0062: ShowMessage(party, String04FD); // There is a trapdoor in the floor.
            L006F: SetState00(party, 0x00, 0x01, 0x01);
            L0083: goto L00AD;
            L0085: SetMoveMap(party, 0x02, 0xBA, 0x02, 0x05);
            L00A0: ShowMessage(party, String051F); // You fall through a trapdoor.
            L00AD: // RETURN;
        }

        private override MapEventHandler MapEvent0D => FnTRAPDORG_0D;
        private void FnTRAPDORG_0D(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = UsedSkill58(party, 0x0D) // returns 0 if did not use, compares to 2nd op if did use;
            L000F: compare(ax, 0x000A);
            L0012: if (result.above or result.equal) goto L0062;
            L0014: ax = UsedSpell64(party, 0x17); // returns 0 if did not use on map, level if used
            L0020: RefreshCompareFlags(ax);
            L0022: if (result.notequal) goto L0062;
            L0024: ax = UsedItem54(party, 0xA2, 0xA2);
            L0037: if (result.notequal) goto L0062;
            L0039: ax = UsedItem54(party, 0xBE, 0xBE);
            L004C: if (result.notequal) goto L0062;
            L004E: ax = CheckState08(party, 0x00, 0x01);
            L0060: if (result.equal) goto L0085;
            L0062: ShowMessage(party, String053C); // You discover a trapdoor.
            L006F: SetState00(party, 0x00, 0x01, 0x01);
            L0083: goto L00AD;
            L0085: SetMoveMap(party, 0x01, 0xBF, 0x02, 0x05);
            L00A0: ShowMessage(party, String0555); // You fall through a trapdoor.
            L00AD: // RETURN;
        }

        private override MapEventHandler MapEvent0E => FnTRAPDORH_0E;
        private void FnTRAPDORH_0E(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = UsedSkill58(party, 0x0D) // returns 0 if did not use, compares to 2nd op if did use;
            L000F: compare(ax, 0x000A);
            L0012: if (result.above or result.equal) goto L0062;
            L0014: ax = UsedSpell64(party, 0x17); // returns 0 if did not use on map, level if used
            L0020: RefreshCompareFlags(ax);
            L0022: if (result.notequal) goto L0062;
            L0024: ax = UsedItem54(party, 0xA2, 0xA2);
            L0037: if (result.notequal) goto L0062;
            L0039: ax = UsedItem54(party, 0xBE, 0xBE);
            L004C: if (result.notequal) goto L0062;
            L004E: ax = CheckState08(party, 0x00, 0x01);
            L0060: if (result.equal) goto L0085;
            L0062: ShowMessage(party, String0572); // You detect a trapdoor.
            L006F: SetState00(party, 0x00, 0x01, 0x01);
            L0083: goto L00AD;
            L0085: SetMoveMap(party, 0x02, 0xCA, 0x02, 0x05);
            L00A0: ShowMessage(party, String0589); // You fall through a trapdoor.
            L00AD: // RETURN;
        }

        private override MapEventHandler MapEvent0F => FnTRAPDORI_0F;
        private void FnTRAPDORI_0F(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = UsedSkill58(party, 0x0D) // returns 0 if did not use, compares to 2nd op if did use;
            L000F: compare(ax, 0x000A);
            L0012: if (result.above or result.equal) goto L0062;
            L0014: ax = UsedSpell64(party, 0x17); // returns 0 if did not use on map, level if used
            L0020: RefreshCompareFlags(ax);
            L0022: if (result.notequal) goto L0062;
            L0024: ax = UsedItem54(party, 0xA2, 0xA2);
            L0037: if (result.notequal) goto L0062;
            L0039: ax = UsedItem54(party, 0xBE, 0xBE);
            L004C: if (result.notequal) goto L0062;
            L004E: ax = CheckState08(party, 0x00, 0x01);
            L0060: if (result.equal) goto L0085;
            L0062: ShowMessage(party, String05A6); // You spot a trapdoor.
            L006F: SetState00(party, 0x00, 0x01, 0x01);
            L0083: goto L00AD;
            L0085: SetMoveMap(party, 0x01, 0xD6, 0x02, 0x05);
            L00A0: ShowMessage(party, String05BB); // You fall through a trapdoor.
            L00AD: // RETURN;
        }

        private override MapEventHandler MapEvent10 => FnTRAPDORJ_10;
        private void FnTRAPDORJ_10(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = UsedSkill58(party, 0x0D) // returns 0 if did not use, compares to 2nd op if did use;
            L000F: compare(ax, 0x000A);
            L0012: if (result.above or result.equal) goto L0062;
            L0014: ax = UsedSpell64(party, 0x17); // returns 0 if did not use on map, level if used
            L0020: RefreshCompareFlags(ax);
            L0022: if (result.notequal) goto L0062;
            L0024: ax = UsedItem54(party, 0xA2, 0xA2);
            L0037: if (result.notequal) goto L0062;
            L0039: ax = UsedItem54(party, 0xBE, 0xBE);
            L004C: if (result.notequal) goto L0062;
            L004E: ax = CheckState08(party, 0x00, 0x01);
            L0060: if (result.equal) goto L0085;
            L0062: ShowMessage(party, String05D8); // You detect a trapdoor.
            L006F: SetState00(party, 0x00, 0x01, 0x01);
            L0083: goto L00AD;
            L0085: SetMoveMap(party, 0x03, 0xD9, 0x02, 0x05);
            L00A0: ShowMessage(party, String05EF); // You fall through a trapdoor.
            L00AD: // RETURN;
        }

        private override MapEventHandler MapEvent11 => FnTRAPDORK_11;
        private void FnTRAPDORK_11(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = UsedSkill58(party, 0x0D) // returns 0 if did not use, compares to 2nd op if did use;
            L000F: compare(ax, 0x000A);
            L0012: if (result.above or result.equal) goto L0062;
            L0014: ax = UsedSpell64(party, 0x17); // returns 0 if did not use on map, level if used
            L0020: RefreshCompareFlags(ax);
            L0022: if (result.notequal) goto L0062;
            L0024: ax = UsedItem54(party, 0xA2, 0xA2);
            L0037: if (result.notequal) goto L0062;
            L0039: ax = UsedItem54(party, 0xBE, 0xBE);
            L004C: if (result.notequal) goto L0062;
            L004E: ax = CheckState08(party, 0x00, 0x01);
            L0060: if (result.equal) goto L0085;
            L0062: ShowMessage(party, String060C); // A trapdoor is in this room.
            L006F: SetState00(party, 0x00, 0x01, 0x01);
            L0083: goto L00AD;
            L0085: SetMoveMap(party, 0x01, 0xEC, 0x02, 0x05);
            L00A0: ShowMessage(party, String0628); // You fall through a trapdoor.
            L00AD: // RETURN;
        }

        private override MapEventHandler MapEvent12 => FnTRAPDORL_12;
        private void FnTRAPDORL_12(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = UsedSkill58(party, 0x0D) // returns 0 if did not use, compares to 2nd op if did use;
            L000F: compare(ax, 0x000A);
            L0012: if (result.above or result.equal) goto L0062;
            L0014: ax = UsedSpell64(party, 0x17); // returns 0 if did not use on map, level if used
            L0020: RefreshCompareFlags(ax);
            L0022: if (result.notequal) goto L0062;
            L0024: ax = UsedItem54(party, 0xA2, 0xA2);
            L0037: if (result.notequal) goto L0062;
            L0039: ax = UsedItem54(party, 0xBE, 0xBE);
            L004C: if (result.notequal) goto L0062;
            L004E: ax = CheckState08(party, 0x00, 0x01);
            L0060: if (result.equal) goto L0085;
            L0062: ShowMessage(party, String0645); // You sidestep a trapdoor.
            L006F: SetState00(party, 0x00, 0x01, 0x01);
            L0083: goto L00AC;
            L0085: SetMoveMap(party, 0x00, 0xF4, 0x02, 0x05);
            L009F: ShowMessage(party, String065E); // You fall through a trapdoor.
            L00AC: // RETURN;
        }

        private override MapEventHandler MapEvent13 => FnTRAPDORM_13;
        private void FnTRAPDORM_13(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = UsedSkill58(party, 0x0D) // returns 0 if did not use, compares to 2nd op if did use;
            L000F: compare(ax, 0x000A);
            L0012: if (result.above or result.equal) goto L0062;
            L0014: ax = UsedSpell64(party, 0x17); // returns 0 if did not use on map, level if used
            L0020: RefreshCompareFlags(ax);
            L0022: if (result.notequal) goto L0062;
            L0024: ax = UsedItem54(party, 0xA2, 0xA2);
            L0037: if (result.notequal) goto L0062;
            L0039: ax = UsedItem54(party, 0xBE, 0xBE);
            L004C: if (result.notequal) goto L0062;
            L004E: ax = CheckState08(party, 0x00, 0x01);
            L0060: if (result.equal) goto L0085;
            L0062: ShowMessage(party, String067B); // You avoid a trapdoor.
            L006F: SetState00(party, 0x00, 0x01, 0x01);
            L0083: goto L00AD;
            L0085: SetMoveMap(party, 0x02, 0xFD, 0x02, 0x05);
            L00A0: ShowMessage(party, String0691); // You fall through a trapdoor.
            L00AD: // RETURN;
        }

        private override MapEventHandler MapEvent14 => FnLKPKDORA_14;
        private void FnLKPKDORA_14(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = UsedItem54(party, 0xC1, 0xC4);
            L0016: if (result.notequal) goto L0029;
            L0018: ax = UsedSkill58(party, 0x0E) // returns 0 if did not use, compares to 2nd op if did use;
            L0024: compare(ax, 0x0006);
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
            L0065: ShowMessage(party, String06AE); // You soon have the door unlocked.
            L0072: goto L009E;
            L0074: PushStack(0x00);
            L0077: ax = GetFacing24(party);
            L007E: PushStack(ax);
            L007F: ax = GetNextTile20(party);
            L0086: PushStack(ax);
            L0087: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L0091: ShowMessage(party, String06CF); // The door is locked.
            L009E: // RETURN;
        }

        private override MapEventHandler MapEvent15 => FnLKPKDORB_15;
        private void FnLKPKDORB_15(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = UsedItem54(party, 0xC2, 0xC4);
            L0016: if (result.notequal) goto L0029;
            L0018: ax = UsedSkill58(party, 0x0E) // returns 0 if did not use, compares to 2nd op if did use;
            L0024: compare(ax, 0x0007);
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
            L0065: ShowMessage(party, String06E3); // Your aptitude at opening locks pays off.
            L0072: goto L009E;
            L0074: PushStack(0x00);
            L0077: ax = GetFacing24(party);
            L007E: PushStack(ax);
            L007F: ax = GetNextTile20(party);
            L0086: PushStack(ax);
            L0087: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L0091: ShowMessage(party, String070C); // The door is locked.
            L009E: // RETURN;
        }

        private override MapEventHandler MapEvent16 => FnLKPKDORC_16;
        private void FnLKPKDORC_16(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = UsedItem54(party, 0xC3, 0xC4);
            L0016: if (result.notequal) goto L0029;
            L0018: ax = UsedSkill58(party, 0x0E) // returns 0 if did not use, compares to 2nd op if did use;
            L0024: compare(ax, 0x0009);
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
            L0065: ShowMessage(party, String0720); // You succeed at picking the door lock.
            L0072: goto L009E;
            L0074: PushStack(0x00);
            L0077: ax = GetFacing24(party);
            L007E: PushStack(ax);
            L007F: ax = GetNextTile20(party);
            L0086: PushStack(ax);
            L0087: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L0091: ShowMessage(party, String0746); // The door is locked.
            L009E: // RETURN;
        }

        private override MapEventHandler MapEvent17 => FnKEYDOORA_17;
        private void FnKEYDOORA_17(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = UsedItem54(party, 0xC3, 0xC4);
            L0016: if (result.notequal) goto L003E;
            L0018: ax = UsedItem54(party, 0xE1, 0xE1);
            L002B: if (result.notequal) goto L003E;
            L002D: ax = UsedSkill58(party, 0x0E) // returns 0 if did not use, compares to 2nd op if did use;
            L0039: compare(ax, 0x000A);
            L003C: if (result.below) goto L0089;
            L003E: Push(01);
            L0042: ax = GetFacing24(party);
            L0049: PushStack(ax);
            L004A: ax = GetNextTile20(party);
            L0051: PushStack(ax);
            L0052: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L005C: ax = GetFacing24(party);
            L0063: PushStack(ax);
            L0064: ax = GetNextTile20(party);
            L006B: PushStack(ax);
            L006C: Push(01);
            L0070: SetUnblocked30(party);
            L007A: ShowMessage(party, String075A); // The door lock is no match for your skills.
            L0087: goto L00B3;
            L0089: PushStack(0x00);
            L008C: ax = GetFacing24(party);
            L0093: PushStack(ax);
            L0094: ax = GetNextTile20(party);
            L009B: PushStack(ax);
            L009C: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L00A6: ShowMessage(party, String0785); // The door is locked.
            L00B3: // RETURN;
        }

        private override MapEventHandler MapEvent18 => FnKEYDOORB_18;
        private void FnKEYDOORB_18(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = UsedItem54(party, 0xC3, 0xC4);
            L0016: if (result.notequal) goto L003E;
            L0018: ax = UsedItem54(party, 0xE1, 0xE1);
            L002B: if (result.notequal) goto L003E;
            L002D: ax = UsedSkill58(party, 0x0E) // returns 0 if did not use, compares to 2nd op if did use;
            L0039: compare(ax, 0x000B);
            L003C: if (result.below) goto L0089;
            L003E: Push(01);
            L0042: ax = GetFacing24(party);
            L0049: PushStack(ax);
            L004A: ax = GetNextTile20(party);
            L0051: PushStack(ax);
            L0052: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L005C: ax = GetFacing24(party);
            L0063: PushStack(ax);
            L0064: ax = GetNextTile20(party);
            L006B: PushStack(ax);
            L006C: Push(01);
            L0070: SetUnblocked30(party);
            L007A: ShowMessage(party, String0799); // You deftly trip the door lock.
            L0087: goto L00B3;
            L0089: PushStack(0x00);
            L008C: ax = GetFacing24(party);
            L0093: PushStack(ax);
            L0094: ax = GetNextTile20(party);
            L009B: PushStack(ax);
            L009C: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L00A6: ShowMessage(party, String07B8); // The door is locked.
            L00B3: // RETURN;
        }

        private override MapEventHandler MapEvent19 => FnKEYDOORC_19;
        private void FnKEYDOORC_19(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = UsedItem54(party, 0xC4, 0xC4);
            L0016: if (result.notequal) goto L003E;
            L0018: ax = UsedItem54(party, 0xE1, 0xE1);
            L002B: if (result.notequal) goto L003E;
            L002D: ax = UsedSkill58(party, 0x0E) // returns 0 if did not use, compares to 2nd op if did use;
            L0039: compare(ax, 0x000C);
            L003C: if (result.below) goto L0089;
            L003E: Push(01);
            L0042: ax = GetFacing24(party);
            L0049: PushStack(ax);
            L004A: ax = GetNextTile20(party);
            L0051: PushStack(ax);
            L0052: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L005C: ax = GetFacing24(party);
            L0063: PushStack(ax);
            L0064: ax = GetNextTile20(party);
            L006B: PushStack(ax);
            L006C: Push(01);
            L0070: SetUnblocked30(party);
            L007A: ShowMessage(party, String07CC); // You quickly have the door open.
            L0087: goto L00B3;
            L0089: PushStack(0x00);
            L008C: ax = GetFacing24(party);
            L0093: PushStack(ax);
            L0094: ax = GetNextTile20(party);
            L009B: PushStack(ax);
            L009C: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L00A6: ShowMessage(party, String07EC); // The door is locked.
            L00B3: // RETURN;
        }

        private override MapEventHandler MapEvent1A => FnSTRDOORA_1A;
        private void FnSTRDOORA_1A(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckStrengthA4(party);
            L000F: compare(ax, 0x000E);
            L0012: if (result.below) goto L005F;
            L0014: ShowMessage(party, String0800); // You push on the door and open it.
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
            L005F: ShowMessage(party, String0822); // The door is stuck shut.
            L006C: PushStack(0x00);
            L006F: ax = GetFacing24(party);
            L0076: PushStack(ax);
            L0077: ax = GetNextTile20(party);
            L007E: PushStack(ax);
            L007F: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L0089: // RETURN;
        }

        private override MapEventHandler MapEvent1B => FnSTRDOORB_1B;
        private void FnSTRDOORB_1B(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckStrengthA4(party);
            L000F: compare(ax, 0x0010);
            L0012: if (result.below) goto L005F;
            L0014: ShowMessage(party, String083A); // You force the door open by muscle power.
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
            L005F: ShowMessage(party, String0863); // The door is stuck shut.
            L006C: PushStack(0x00);
            L006F: ax = GetFacing24(party);
            L0076: PushStack(ax);
            L0077: ax = GetNextTile20(party);
            L007E: PushStack(ax);
            L007F: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L0089: // RETURN;
        }

        private override MapEventHandler MapEvent1C => FnITMDOORA_1C;
        private void FnITMDOORA_1C(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = UsedItem54(party, 0xE1, 0xE1);
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
            L0054: ShowMessage(party, String087B); // The Domicile Key opens the door!
            L0061: goto L008D;
            L0063: PushStack(0x00);
            L0066: ax = GetFacing24(party);
            L006D: PushStack(ax);
            L006E: ax = GetNextTile20(party);
            L0075: PushStack(ax);
            L0076: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L0080: ShowMessage(party, String089C); // The door is locked.
            L008D: // RETURN;
        }

        private override MapEventHandler MapEvent1D => FnDETCTDOR_1D;
        private void FnDETCTDOR_1D(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = UsedSkill58(party, 0x0D) // returns 0 if did not use, compares to 2nd op if did use;
            L000F: compare(ax, 0x000A);
            L0012: if (result.above or result.equal) goto L004E;
            L0014: ax = UsedSpell64(party, 0x17); // returns 0 if did not use on map, level if used
            L0020: RefreshCompareFlags(ax);
            L0022: if (result.notequal) goto L004E;
            L0024: ax = UsedItem54(party, 0xA2, 0xA2);
            L0037: if (result.notequal) goto L004E;
            L0039: ax = UsedItem54(party, 0xBE, 0xBE);
            L004C: if (result.equal) goto L0099;
            L004E: ShowMessage(party, String08B0); // You have spotted a secret door!
            L005B: ax = GetFacing24(party);
            L0062: PushStack(ax);
            L0063: ax = GetNextTile20(party);
            L006A: PushStack(ax);
            L006B: Push(01);
            L006F: SetUnblocked30(party);
            L0079: Push(01);
            L007D: ax = GetFacing24(party);
            L0084: PushStack(ax);
            L0085: ax = GetNextTile20(party);
            L008C: PushStack(ax);
            L008D: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L0097: goto L00B6;
            L0099: PushStack(0x00);
            L009C: ax = GetFacing24(party);
            L00A3: PushStack(ax);
            L00A4: ax = GetNextTile20(party);
            L00AB: PushStack(ax);
            L00AC: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L00B6: // RETURN;
        }

        private override MapEventHandler MapEvent1E => FnLFTROTA_1E;
        private void FnLFTROTA_1E(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState0C(party, 0x00, 0x02);
            L0015: if (result.notequal) goto L001A;
            L0017: goto L00C9;
            L001A: SetState00(party, 0x00, 0x02, 0x01);
            L002E: ax = GetFacing24(party);
            L0035: bx = ax;
            L0037: compare(bx, 0x03);
            L003A: if (result.unsigned_equal_or_less_than) goto L003F;
            L003C: goto L00C9;
            L003F: bx = bx * 2;
            L0041: goto mem[0x10CB+bx];
            L0046: PushStack(0x00);
            L0049: ax = GetNextTile20(party);
            L0050: SetMoveMap(party, PopStack(), ax, 0x01, 0x04);
            L0064: goto L00C9;
            L0066: Push(02);
            L006A: ax = GetNextTile20(party);
            L0071: SetMoveMap(party, PopStack(), ax, 0x01, 0x04);
            L0085: goto L00C9;
            L0087: Push(03);
            L008B: ax = GetNextTile20(party);
            L0092: SetMoveMap(party, PopStack(), ax, 0x01, 0x04);
            L00A6: goto L00C9;
            L00A8: Push(01);
            L00AC: ax = GetNextTile20(party);
            L00B3: SetMoveMap(party, PopStack(), ax, 0x01, 0x04);
            L00C7: goto L00C9;
            L00C9: // RETURN;
10CB  00CB        A8 10 66 10 87 10 46 10 
        }

        private override MapEventHandler MapEvent1F => FnLFTROTB_1F;
        private void FnLFTROTB_1F(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState0C(party, 0x00, 0x02);
            L0015: if (result.notequal) goto L001A;
            L0017: goto L00EF;
            L001A: SetState00(party, 0x00, 0x02, 0x01);
            L002E: ax = GetFacing24(party);
            L0035: bx = ax;
            L0037: compare(bx, 0x03);
            L003A: if (result.unsigned_equal_or_less_than) goto L003F;
            L003C: goto L00CA;
            L003F: bx = bx * 2;
            L0041: goto mem[0x11C4+bx];
            L0046: Push(02);
            L004A: ax = GetNextTile20(party);
            L0051: SetMoveMap(party, PopStack(), ax, 0x01, 0x04);
            L0065: goto L00EF;
            L0068: PushStack(0x00);
            L006B: ax = GetNextTile20(party);
            L0072: SetMoveMap(party, PopStack(), ax, 0x01, 0x04);
            L0086: goto L00EF;
            L0088: Push(01);
            L008C: ax = GetNextTile20(party);
            L0093: SetMoveMap(party, PopStack(), ax, 0x01, 0x04);
            L00A7: goto L00EF;
            L00A9: Push(03);
            L00AD: ax = GetNextTile20(party);
            L00B4: SetMoveMap(party, PopStack(), ax, 0x01, 0x04);
            L00C8: goto L00EF;
            L00CA: ax = GetFacing24(party);
            L00D1: PushStack(ax);
            L00D2: ax = GetNextTile20(party);
            L00D9: SetMoveMap(party, PopStack(), ax, 0x01, 0x04);
            L00ED: goto L00EF;
            L00EF: // RETURN;
11C4  00F1        7C 11 3B 11 5B 11 19 11 
        }

        private override MapEventHandler MapEvent20 => FnBACKROTL_20;
        private void FnBACKROTL_20(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState0C(party, 0x00, 0x02);
            L0015: if (result.notequal) goto L001A;
            L0017: goto L00EF;
            L001A: SetState00(party, 0x00, 0x02, 0x01);
            L002E: ax = GetFacing24(party);
            L0035: bx = ax;
            L0037: compare(bx, 0x03);
            L003A: if (result.unsigned_equal_or_less_than) goto L003F;
            L003C: goto L00CA;
            L003F: bx = bx * 2;
            L0041: goto mem[0x12BD+bx];
            L0046: Push(01);
            L004A: ax = GetNextTile20(party);
            L0051: SetMoveMap(party, PopStack(), ax, 0x01, 0x04);
            L0065: goto L00EF;
            L0068: Push(03);
            L006C: ax = GetNextTile20(party);
            L0073: SetMoveMap(party, PopStack(), ax, 0x01, 0x04);
            L0087: goto L00EF;
            L0089: PushStack(0x00);
            L008C: ax = GetNextTile20(party);
            L0093: SetMoveMap(party, PopStack(), ax, 0x01, 0x04);
            L00A7: goto L00EF;
            L00A9: Push(02);
            L00AD: ax = GetNextTile20(party);
            L00B4: SetMoveMap(party, PopStack(), ax, 0x01, 0x04);
            L00C8: goto L00EF;
            L00CA: ax = GetFacing24(party);
            L00D1: PushStack(ax);
            L00D2: ax = GetNextTile20(party);
            L00D9: SetMoveMap(party, PopStack(), ax, 0x01, 0x04);
            L00ED: goto L00EF;
            L00EF: // RETURN;
12BD  00F1        75 12 34 12 55 12 12 12 
        }

        private override MapEventHandler MapEvent21 => FnRTROTA_21;
        private void FnRTROTA_21(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState0C(party, 0x00, 0x02);
            L0015: if (result.notequal) goto L001A;
            L0017: goto L00EF;
            L001A: SetState00(party, 0x00, 0x02, 0x01);
            L002E: ax = GetFacing24(party);
            L0035: bx = ax;
            L0037: compare(bx, 0x03);
            L003A: if (result.unsigned_equal_or_less_than) goto L003F;
            L003C: goto L00CA;
            L003F: bx = bx * 2;
            L0041: goto mem[0x13B6+bx];
            L0046: Push(02);
            L004A: ax = GetNextTile20(party);
            L0051: SetMoveMap(party, PopStack(), ax, 0x01, 0x04);
            L0065: goto L00EF;
            L0068: PushStack(0x00);
            L006B: ax = GetNextTile20(party);
            L0072: SetMoveMap(party, PopStack(), ax, 0x01, 0x04);
            L0086: goto L00EF;
            L0088: Push(01);
            L008C: ax = GetNextTile20(party);
            L0093: SetMoveMap(party, PopStack(), ax, 0x01, 0x04);
            L00A7: goto L00EF;
            L00A9: Push(03);
            L00AD: ax = GetNextTile20(party);
            L00B4: SetMoveMap(party, PopStack(), ax, 0x01, 0x04);
            L00C8: goto L00EF;
            L00CA: ax = GetFacing24(party);
            L00D1: PushStack(ax);
            L00D2: ax = GetNextTile20(party);
            L00D9: SetMoveMap(party, PopStack(), ax, 0x01, 0x04);
            L00ED: goto L00EF;
            L00EF: // RETURN;
13B6  00F1        6E 13 2D 13 4D 13 0B 13 
        }

        private override MapEventHandler MapEvent22 => FnRTROTB_22;
        private void FnRTROTB_22(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState0C(party, 0x00, 0x02);
            L0015: if (result.notequal) goto L001A;
            L0017: goto L00EF;
            L001A: SetState00(party, 0x00, 0x02, 0x01);
            L002E: ax = GetFacing24(party);
            L0035: bx = ax;
            L0037: compare(bx, 0x03);
            L003A: if (result.unsigned_equal_or_less_than) goto L003F;
            L003C: goto L00CA;
            L003F: bx = bx * 2;
            L0041: goto mem[0x14AF+bx];
            L0046: PushStack(0x00);
            L0049: ax = GetNextTile20(party);
            L0050: SetMoveMap(party, PopStack(), ax, 0x01, 0x04);
            L0064: goto L00EF;
            L0067: Push(02);
            L006B: ax = GetNextTile20(party);
            L0072: SetMoveMap(party, PopStack(), ax, 0x01, 0x04);
            L0086: goto L00EF;
            L0088: Push(03);
            L008C: ax = GetNextTile20(party);
            L0093: SetMoveMap(party, PopStack(), ax, 0x01, 0x04);
            L00A7: goto L00EF;
            L00A9: Push(01);
            L00AD: ax = GetNextTile20(party);
            L00B4: SetMoveMap(party, PopStack(), ax, 0x01, 0x04);
            L00C8: goto L00EF;
            L00CA: ax = GetFacing24(party);
            L00D1: PushStack(ax);
            L00D2: ax = GetNextTile20(party);
            L00D9: SetMoveMap(party, PopStack(), ax, 0x01, 0x04);
            L00ED: goto L00EF;
            L00EF: // RETURN;
14AF  00F1        67 14 25 14 46 14 04 14 
        }

        private override MapEventHandler MapEvent25 => FnBADMNSTR_25;
        private void FnBADMNSTR_25(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = PartyCount(party);
            L000B: compare(ax, 0x0001);
            L000E: if (result.notequal) goto L0037;
            L0010: AddEncounter(party, 0x1F, 0x01);
            L0022: AddEncounter(party, 0x20, 0x02);
            L0034: goto L0152;
            L0037: ax = PartyCount(party);
            L003F: compare(ax, 0x0002);
            L0042: if (result.notequal) goto L007D;
            L0044: AddEncounter(party, 0x20, 0x01);
            L0056: AddEncounter(party, 0x20, 0x02);
            L0068: AddEncounter(party, 0x20, 0x03);
            L007A: goto L0152;
            L007D: ax = PartyCount(party);
            L0085: compare(ax, 0x0003);
            L0088: if (result.notequal) goto L00E6;
            L008A: AddEncounter(party, 0x1F, 0x01);
            L009C: AddEncounter(party, 0x20, 0x02);
            L00AE: AddEncounter(party, 0x21, 0x03);
            L00C0: AddEncounter(party, 0x1F, 0x05);
            L00D2: AddEncounter(party, 0x21, 0x06);
            L00E4: goto L0152;
            L00E6: AddEncounter(party, 0x21, 0x01);
            L00F8: AddEncounter(party, 0x21, 0x02);
            L010A: AddEncounter(party, 0x21, 0x03);
            L011C: AddEncounter(party, 0x21, 0x04);
            L012E: AddEncounter(party, 0x21, 0x05);
            L0140: AddEncounter(party, 0x21, 0x06);
            L0152: // RETURN;
        }

        private override MapEventHandler MapEvent28 => FnITEMAENC_28;
        private void FnITEMAENC_28(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem50(party, 0xB1);
            L0011: if (result.equal) goto L0041;
            L0013: AddTreasure(party, 0x01F4, 0x00, 0x00, 0x00, 0x00, 0xCE);
            L0032: ShowMessage(party, String08D0); // Clerics use this room as a sanctuary.
            L003F: goto L006E;
            L0041: AddTreasure(party, 0x0BB8, 0x00, 0x00, 0x00, 0xCF, 0xB1);
            L0061: ShowMessage(party, String08F6); // A scroll fall from a Cleric's robe.
            L006E: ax = PartyCount(party);
            L0076: compare(ax, 0x0001);
            L0079: if (result.notequal) goto L0090;
            L007B: AddEncounter(party, 0x25, 0x01);
            L008D: goto L0151;
            L0090: ax = PartyCount(party);
            L0098: compare(ax, 0x0002);
            L009B: if (result.notequal) goto L00C4;
            L009D: AddEncounter(party, 0x25, 0x01);
            L00AF: AddEncounter(party, 0x25, 0x02);
            L00C1: goto L0151;
            L00C4: ax = PartyCount(party);
            L00CC: compare(ax, 0x0003);
            L00CF: if (result.notequal) goto L0109;
            L00D1: AddEncounter(party, 0x25, 0x01);
            L00E3: AddEncounter(party, 0x25, 0x02);
            L00F5: AddEncounter(party, 0x25, 0x05);
            L0107: goto L0151;
            L0109: AddEncounter(party, 0x25, 0x01);
            L011B: AddEncounter(party, 0x25, 0x02);
            L012D: AddEncounter(party, 0x25, 0x05);
            L013F: AddEncounter(party, 0x25, 0x06);
            L0151: // RETURN;
        }

        private override MapEventHandler MapEvent29 => FnSPECITMB_29;
        private void FnSPECITMB_29(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem50(party, 0xCD);
            L0011: if (result.equal) goto L0041;
            L0013: AddTreasure(party, 0x004B, 0x00, 0x00, 0x00, 0x00, 0xCB);
            L0032: ShowMessage(party, String091A); // Rogues use this room as a hideout.
            L003F: goto L006E;
            L0041: AddTreasure(party, 0x0DAC, 0x00, 0x00, 0x00, 0xD0, 0xCD);
            L0061: ShowMessage(party, String093D); // A Barbarian drops some potions when she sees you.
            L006E: ax = PartyCount(party);
            L0076: compare(ax, 0x0001);
            L0079: if (result.notequal) goto L00A2;
            L007B: AddEncounter(party, 0x23, 0x01);
            L008D: AddEncounter(party, 0x23, 0x02);
            L009F: goto L0153;
            L00A2: ax = PartyCount(party);
            L00AA: compare(ax, 0x0002);
            L00AD: if (result.notequal) goto L00F9;
            L00AF: AddEncounter(party, 0x23, 0x01);
            L00C1: AddEncounter(party, 0x23, 0x02);
            L00D3: AddEncounter(party, 0x04, 0x05);
            L00E5: AddEncounter(party, 0x04, 0x06);
            L00F7: goto L0153;
            L00F9: AddEncounter(party, 0x23, 0x01);
            L010B: AddEncounter(party, 0x23, 0x02);
            L011D: AddEncounter(party, 0x23, 0x03);
            L012F: AddEncounter(party, 0x22, 0x05);
            L0141: AddEncounter(party, 0x22, 0x06);
            L0153: // RETURN;
        }

        private override MapEventHandler MapEvent2A => FnITEMCENC_2A;
        private void FnITEMCENC_2A(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem50(party, 0xCA);
            L0011: if (result.equal) goto L0041;
            L0013: AddTreasure(party, 0x00C8, 0x00, 0x00, 0x00, 0x00, 0xB6);
            L0032: ShowMessage(party, String096F); // You sense evil in the room.
            L003F: goto L006D;
            L0041: AddTreasure(party, 0x1388, 0x00, 0x00, 0x00, 0x00, 0xCA);
            L0060: ShowMessage(party, String098B); // You see a wand on the floor.
            L006D: ax = PartyCount(party);
            L0075: compare(ax, 0x0001);
            L0078: if (result.notequal) goto L00A1;
            L007A: AddEncounter(party, 0x19, 0x02);
            L008C: AddEncounter(party, 0x1B, 0x06);
            L009E: goto L0164;
            L00A1: ax = PartyCount(party);
            L00A9: compare(ax, 0x0002);
            L00AC: if (result.notequal) goto L00F8;
            L00AE: AddEncounter(party, 0x19, 0x01);
            L00C0: AddEncounter(party, 0x19, 0x02);
            L00D2: AddEncounter(party, 0x1B, 0x05);
            L00E4: AddEncounter(party, 0x1B, 0x06);
            L00F6: goto L0164;
            L00F8: AddEncounter(party, 0x1A, 0x01);
            L010A: AddEncounter(party, 0x1A, 0x02);
            L011C: AddEncounter(party, 0x19, 0x03);
            L012E: AddEncounter(party, 0x19, 0x04);
            L0140: AddEncounter(party, 0x1B, 0x05);
            L0152: AddEncounter(party, 0x1B, 0x06);
            L0164: // RETURN;
        }

        private override MapEventHandler MapEvent2B => FnITEMDECN_2B;
        private void FnITEMDECN_2B(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem50(party, 0x92);
            L0011: if (result.equal) goto L0041;
            L0013: AddTreasure(party, 0x02EE, 0x00, 0x00, 0x00, 0x00, 0xCF);
            L0032: ShowMessage(party, String09A8); // The stench of reptiles assails you.
            L003F: goto L006E;
            L0041: AddTreasure(party, 0x09C4, 0x00, 0x00, 0x00, 0xB7, 0x92);
            L0061: ShowMessage(party, String09CC); // You hear hissing.
            L006E: ax = PartyCount(party);
            L0076: compare(ax, 0x0001);
            L0079: if (result.notequal) goto L00A2;
            L007B: AddEncounter(party, 0x1C, 0x01);
            L008D: AddEncounter(party, 0x1E, 0x02);
            L009F: goto L0165;
            L00A2: ax = PartyCount(party);
            L00AA: compare(ax, 0x0002);
            L00AD: if (result.notequal) goto L00F9;
            L00AF: AddEncounter(party, 0x1C, 0x01);
            L00C1: AddEncounter(party, 0x1E, 0x02);
            L00D3: AddEncounter(party, 0x1C, 0x03);
            L00E5: AddEncounter(party, 0x1E, 0x04);
            L00F7: goto L0165;
            L00F9: AddEncounter(party, 0x1D, 0x01);
            L010B: AddEncounter(party, 0x1D, 0x02);
            L011D: AddEncounter(party, 0x1E, 0x03);
            L012F: AddEncounter(party, 0x1E, 0x04);
            L0141: AddEncounter(party, 0x1C, 0x05);
            L0153: AddEncounter(party, 0x1C, 0x06);
            L0165: // RETURN;
        }

        private override MapEventHandler MapEvent2C => FnWEAPAENC_2C;
        private void FnWEAPAENC_2C(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem50(party, 0x3A);
            L0011: if (result.equal) goto L0042;
            L0013: AddTreasure(party, 0x023F, 0x00, 0x00, 0x00, 0xCC, 0xCF);
            L0033: ShowMessage(party, String09DE); // Rogues surprise you.
            L0040: goto L006E;
            L0042: AddTreasure(party, 0x04B0, 0x00, 0x00, 0x00, 0x00, 0x3A);
            L0061: ShowMessage(party, String09F3); // A Knight drops a poleaxe as you approach.
            L006E: ax = PartyCount(party);
            L0076: compare(ax, 0x0001);
            L0079: if (result.notequal) goto L00A2;
            L007B: AddEncounter(party, 0x26, 0x01);
            L008D: AddEncounter(party, 0x27, 0x02);
            L009F: goto L01BD;
            L00A2: ax = PartyCount(party);
            L00AA: compare(ax, 0x0002);
            L00AD: if (result.notequal) goto L00E8;
            L00AF: AddEncounter(party, 0x26, 0x01);
            L00C1: AddEncounter(party, 0x27, 0x02);
            L00D3: AddEncounter(party, 0x25, 0x05);
            L00E5: goto L01BD;
            L00E8: ax = PartyCount(party);
            L00F0: compare(ax, 0x0003);
            L00F3: if (result.notequal) goto L0151;
            L00F5: AddEncounter(party, 0x26, 0x01);
            L0107: AddEncounter(party, 0x25, 0x02);
            L0119: AddEncounter(party, 0x27, 0x03);
            L012B: AddEncounter(party, 0x25, 0x05);
            L013D: AddEncounter(party, 0x27, 0x06);
            L014F: goto L01BD;
            L0151: AddEncounter(party, 0x26, 0x01);
            L0163: AddEncounter(party, 0x26, 0x02);
            L0175: AddEncounter(party, 0x24, 0x03);
            L0187: AddEncounter(party, 0x23, 0x04);
            L0199: AddEncounter(party, 0x27, 0x05);
            L01AB: AddEncounter(party, 0x25, 0x06);
            L01BD: // RETURN;
        }

        private override MapEventHandler MapEvent2D => FnWEAPBENC_2D;
        private void FnWEAPBENC_2D(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem50(party, 0x49);
            L0011: if (result.equal) goto L0041;
            L0013: AddTreasure(party, 0x0384, 0x00, 0x00, 0x00, 0x00, 0xC9);
            L0032: ShowMessage(party, String0A1D); // Nightmares loom up before you.
            L003F: goto L006E;
            L0041: AddTreasure(party, 0x1388, 0x00, 0x00, 0x00, 0xCB, 0x49);
            L0061: ShowMessage(party, String0A3C); // A Nightmare throws a bow aside to attack.
            L006E: ax = PartyCount(party);
            L0076: compare(ax, 0x0001);
            L0079: if (result.notequal) goto L0090;
            L007B: AddEncounter(party, 0x13, 0x01);
            L008D: goto L0151;
            L0090: ax = PartyCount(party);
            L0098: compare(ax, 0x0002);
            L009B: if (result.notequal) goto L00C4;
            L009D: AddEncounter(party, 0x13, 0x01);
            L00AF: AddEncounter(party, 0x14, 0x02);
            L00C1: goto L0151;
            L00C4: ax = PartyCount(party);
            L00CC: compare(ax, 0x0003);
            L00CF: if (result.notequal) goto L0109;
            L00D1: AddEncounter(party, 0x14, 0x01);
            L00E3: AddEncounter(party, 0x13, 0x02);
            L00F5: AddEncounter(party, 0x14, 0x03);
            L0107: goto L0151;
            L0109: AddEncounter(party, 0x13, 0x01);
            L011B: AddEncounter(party, 0x13, 0x02);
            L012D: AddEncounter(party, 0x14, 0x03);
            L013F: AddEncounter(party, 0x14, 0x04);
            L0151: // RETURN;
        }

        private override MapEventHandler MapEvent2E => FnARMRAENC_2E;
        private void FnARMRAENC_2E(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem50(party, 0x7F);
            L0011: if (result.equal) goto L0042;
            L0013: AddTreasure(party, 0x00C8, 0x00, 0x00, 0x00, 0x4F, 0x02);
            L0033: ShowMessage(party, String0A66); // You stumble on some Dwarf Knights.
            L0040: goto L006F;
            L0042: AddTreasure(party, 0x1770, 0x00, 0x00, 0x00, 0xCF, 0x7F);
            L0062: ShowMessage(party, String0A89); // The brilliant chainmail worn by a Knight blinds you.
            L006F: ax = PartyCount(party);
            L0077: compare(ax, 0x0001);
            L007A: if (result.notequal) goto L0091;
            L007C: AddEncounter(party, 0x28, 0x01);
            L008E: goto L0152;
            L0091: ax = PartyCount(party);
            L0099: compare(ax, 0x0002);
            L009C: if (result.notequal) goto L00C5;
            L009E: AddEncounter(party, 0x28, 0x01);
            L00B0: AddEncounter(party, 0x28, 0x02);
            L00C2: goto L0152;
            L00C5: ax = PartyCount(party);
            L00CD: compare(ax, 0x0003);
            L00D0: if (result.notequal) goto L010A;
            L00D2: AddEncounter(party, 0x28, 0x01);
            L00E4: AddEncounter(party, 0x28, 0x02);
            L00F6: AddEncounter(party, 0x28, 0x04);
            L0108: goto L0152;
            L010A: AddEncounter(party, 0x28, 0x01);
            L011C: AddEncounter(party, 0x28, 0x02);
            L012E: AddEncounter(party, 0x28, 0x03);
            L0140: AddEncounter(party, 0x28, 0x06);
            L0152: // RETURN;
        }

        private override MapEventHandler MapEvent2F => FnARMRBENC_2F;
        private void FnARMRBENC_2F(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem50(party, 0x5A);
            L0011: if (result.equal) goto L0040;
            L0013: AddTreasure(party, 0x0000, 0x00, 0x00, 0x00, 0x00, 0xCE);
            L0031: ShowMessage(party, String0ABE); // You enter a den of thieves.
            L003E: goto L006B;
            L0040: AddTreasure(party, 0x0000, 0x00, 0x00, 0x00, 0x00, 0x5A);
            L005E: ShowMessage(party, String0ADA); // A Halfling Thief tries to wield a large shield.
            L006B: ax = PartyCount(party);
            L0073: compare(ax, 0x0001);
            L0076: if (result.notequal) goto L00B0;
            L0078: AddEncounter(party, 0x24, 0x01);
            L008A: AddEncounter(party, 0x24, 0x02);
            L009C: AddEncounter(party, 0x24, 0x05);
            L00AE: goto L011C;
            L00B0: AddEncounter(party, 0x24, 0x01);
            L00C2: AddEncounter(party, 0x24, 0x02);
            L00D4: AddEncounter(party, 0x24, 0x03);
            L00E6: AddEncounter(party, 0x24, 0x04);
            L00F8: AddEncounter(party, 0x24, 0x05);
            L010A: AddEncounter(party, 0x24, 0x06);
            L011C: // RETURN;
        }

        private override MapEventHandler MapEvent30 => FnKEYENC_30;
        private void FnKEYENC_30(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem50(party, 0xE1);
            L0011: if (result.equal) goto L0042;
            L0013: AddTreasure(party, 0x03E8, 0x00, 0x00, 0x00, 0xB7, 0xCE);
            L0033: ShowMessage(party, String0B0A); // The room is jammed with Rogues.
            L0040: goto L006D;
            L0042: AddTreasure(party, 0x0000, 0x00, 0x00, 0x00, 0x00, 0xE1);
            L0060: ShowMessage(party, String0B2A); // A Ranger wears the King's Domicile Key around his neck.
            L006D: ax = PartyCount(party);
            L0075: compare(ax, 0x0001);
            L0078: if (result.notequal) goto L00A1;
            L007A: AddEncounter(party, 0x27, 0x01);
            L008C: AddEncounter(party, 0x25, 0x05);
            L009E: goto L0176;
            L00A1: ax = PartyCount(party);
            L00A9: compare(ax, 0x0002);
            L00AC: if (result.notequal) goto L010A;
            L00AE: AddEncounter(party, 0x27, 0x01);
            L00C0: AddEncounter(party, 0x26, 0x02);
            L00D2: AddEncounter(party, 0x28, 0x03);
            L00E4: AddEncounter(party, 0x25, 0x05);
            L00F6: AddEncounter(party, 0x25, 0x06);
            L0108: goto L0176;
            L010A: AddEncounter(party, 0x27, 0x01);
            L011C: AddEncounter(party, 0x28, 0x02);
            L012E: AddEncounter(party, 0x26, 0x03);
            L0140: AddEncounter(party, 0x28, 0x04);
            L0152: AddEncounter(party, 0x27, 0x05);
            L0164: AddEncounter(party, 0x25, 0x06);
            L0176: // RETURN;
        }

        private override MapEventHandler MapEvent31 => FnTELMESGA_31;
        private void FnTELMESGA_31(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0B62); // There is a teleport in the south wall.
            L0010: // RETURN;
        }

        private override MapEventHandler MapEvent32 => FnTELMESGB_32;
        private void FnTELMESGB_32(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0B89); // There is a teleport to the south.
            L0010: // RETURN;
        }

        private override MapEventHandler MapEvent33 => FnTELMESSC_33;
        private void FnTELMESSC_33(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0BAB); // There is a teleport to the north.
            L0010: // RETURN;
        }

        private override MapEventHandler MapEvent34 => FnGOLDAENC_34;
        private void FnGOLDAENC_34(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x02, 0x38);
            L0014: compare(ax, 0x0001);
            L0017: if (result.notequal) goto L003A;
            L0019: AddTreasure(party, 0x01F4, 0x00, 0x00, 0x00, 0x00, 0xB5);
            L0038: goto L006F;
            L003A: AddTreasure(party, 0x1388, 0x00, 0x00, 0x00, 0xAB, 0xA8);
            L005A: SetState00(party, 0x02, 0x1F, 0x01);
            L006F: ShowMessage(party, String0BCD); // Banshees haunt this room.
            L007C: ax = PartyCount(party);
            L0084: compare(ax, 0x0001);
            L0087: if (result.notequal) goto L009E;
            L0089: AddEncounter(party, 0x0E, 0x01);
            L009B: goto L013D;
            L009E: ax = PartyCount(party);
            L00A6: compare(ax, 0x0002);
            L00A9: if (result.notequal) goto L00E3;
            L00AB: AddEncounter(party, 0x0E, 0x01);
            L00BD: AddEncounter(party, 0x0E, 0x02);
            L00CF: AddEncounter(party, 0x0E, 0x03);
            L00E1: goto L013D;
            L00E3: AddEncounter(party, 0x0F, 0x01);
            L00F5: AddEncounter(party, 0x10, 0x02);
            L0107: AddEncounter(party, 0x0F, 0x03);
            L0119: AddEncounter(party, 0x11, 0x05);
            L012B: AddEncounter(party, 0x10, 0x06);
            L013D: // RETURN;
        }

        private override MapEventHandler MapEvent35 => FnGOLDBENC_35;
        private void FnGOLDBENC_35(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0BE7); // Deinons protect a chest.
            L0010: ax = CheckState04(party, 0x02, 0x39);
            L0021: compare(ax, 0x0001);
            L0024: if (result.notequal) goto L0047;
            L0026: AddTreasure(party, 0x00C8, 0x00, 0x00, 0x00, 0x00, 0x04);
            L0045: goto L007C;
            L0047: AddTreasure(party, 0x1770, 0x00, 0x00, 0x00, 0xB6, 0xCE);
            L0067: SetState00(party, 0x02, 0x20, 0x01);
            L007C: ax = PartyCount(party);
            L0084: compare(ax, 0x0001);
            L0087: if (result.notequal) goto L009E;
            L0089: AddEncounter(party, 0x1E, 0x01);
            L009B: goto L015F;
            L009E: ax = PartyCount(party);
            L00A6: compare(ax, 0x0002);
            L00A9: if (result.notequal) goto L00D2;
            L00AB: AddEncounter(party, 0x1E, 0x01);
            L00BD: AddEncounter(party, 0x1E, 0x02);
            L00CF: goto L015F;
            L00D2: ax = PartyCount(party);
            L00DA: compare(ax, 0x0003);
            L00DD: if (result.notequal) goto L0117;
            L00DF: AddEncounter(party, 0x1E, 0x01);
            L00F1: AddEncounter(party, 0x1E, 0x02);
            L0103: AddEncounter(party, 0x1E, 0x04);
            L0115: goto L015F;
            L0117: AddEncounter(party, 0x1E, 0x01);
            L0129: AddEncounter(party, 0x1E, 0x02);
            L013B: AddEncounter(party, 0x1E, 0x03);
            L014D: AddEncounter(party, 0x1E, 0x04);
            L015F: // RETURN;
        }

        private override MapEventHandler MapEvent36 => FnBACKROTR_36;
        private void FnBACKROTR_36(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState0C(party, 0x00, 0x02);
            L0015: if (result.notequal) goto L001A;
            L0017: goto L00EF;
            L001A: SetState00(party, 0x00, 0x02, 0x01);
            L002E: ax = GetFacing24(party);
            L0035: bx = ax;
            L0037: compare(bx, 0x03);
            L003A: if (result.unsigned_equal_or_less_than) goto L003F;
            L003C: goto L00CA;
            L003F: bx = bx * 2;
            L0041: goto mem[0x2657+bx];
            L0046: Push(01);
            L004A: ax = GetNextTile20(party);
            L0051: SetMoveMap(party, PopStack(), ax, 0x01, 0x04);
            L0065: goto L00EF;
            L0068: Push(03);
            L006C: ax = GetNextTile20(party);
            L0073: SetMoveMap(party, PopStack(), ax, 0x01, 0x04);
            L0087: goto L00EF;
            L0089: PushStack(0x00);
            L008C: ax = GetNextTile20(party);
            L0093: SetMoveMap(party, PopStack(), ax, 0x01, 0x04);
            L00A7: goto L00EF;
            L00A9: Push(02);
            L00AD: ax = GetNextTile20(party);
            L00B4: SetMoveMap(party, PopStack(), ax, 0x01, 0x04);
            L00C8: goto L00EF;
            L00CA: ax = GetFacing24(party);
            L00D1: PushStack(ax);
            L00D2: ax = GetNextTile20(party);
            L00D9: SetMoveMap(party, PopStack(), ax, 0x01, 0x04);
            L00ED: goto L00EF;
            L00EF: // RETURN;
2657  00F1        0F 26 CE 25 EF 25 AC 25 
        }

        private override MapEventHandler MapEvent37 => FnSTRSMESA_37;
        private void FnSTRSMESA_37(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0C00); // Stairs through the east gateway lead upstairs.
            L0010: // RETURN;
        }

        private override MapEventHandler MapEvent38 => FnSTRSMESB_38;
        private void FnSTRSMESB_38(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0C2F); // There are stairs to the north beyond the gateway.
            L0010: // RETURN;
        }

        private override MapEventHandler MapEvent39 => FnPLATFMMS_39;
        private void FnPLATFMMS_39(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0C61); // There is an elevator platform to the north.
            L0010: // RETURN;
        }

        private override MapEventHandler MapEvent3A => FnSTRSMESS_3A;
        private void FnSTRSMESS_3A(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0C8D); // Stairs through the west gateway lead down a level.
            L0010: // RETURN;
        }

        private override MapEventHandler MapEvent3B => FnNPCCHATA_3B;
        private void FnNPCCHATA_3B(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0CC0); // You encounter a Human Wizard.
            L0010: ShowPortrait(party, 0x002B);
            L001D: ax = UnknownFunctionEC(party, 0x000F);
            L002A: compare(ax, 0x000A);
            L002D: if (result.unsigned_greater_than) goto L003E;
            L002F: ShowMessage(party, String0CDE); // This is the lowest level of Cleowyn's Palace, yet you are merely at the beginning of the dungeon proper.
            L003C: goto L004B;
            L003E: ShowMessage(party, String0D47); // The Human Wizard chortles softly.
            L004B: // RETURN;
        }

        private override MapEventHandler MapEvent3C => FnNPCCHATB_3C;
        private void FnNPCCHATB_3C(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0D69); // You encounter a Gnome Thief.
            L0010: ShowPortrait(party, 0x0024);
            L001D: ax = UnknownFunctionEC(party, 0x000F);
            L002A: compare(ax, 0x0009);
            L002D: if (result.unsigned_greater_than) goto L003E;
            L002F: ShowMessage(party, String0D86); // In the king's quarters is an elevator that will lift you up to the King's Palace. Cleowyn used this elevator to  by-pass the traps around his throne.
            L003C: goto L004B;
            L003E: ShowMessage(party, String0E1C); // The Gnome Thief tiptoes away as you draw near.
            L004B: // RETURN;
        }

        private override MapEventHandler MapEvent3D => FnNPCCHATC_3D;
        private void FnNPCCHATC_3D(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0E4B); // You encounter a Gnome Barbarian.
            L0010: ShowPortrait(party, 0x0019);
            L001D: ax = UnknownFunctionEC(party, 0x000F);
            L002A: compare(ax, 0x0005);
            L002D: if (result.unsigned_greater_than) goto L003E;
            L002F: ShowMessage(party, String0E6C); // The name of the Elemental bound by the wizard Arnakkian is En-li-kil. This Elemental commands Time itself.
            L003C: goto L0058;
            L003E: DoDamage90(party, 0x004B);
            L004B: ShowMessage(party, String0ED7); // The Gnome Barbarian warns you to stay away.
            L0058: // RETURN;
        }

        private override MapEventHandler MapEvent3E => FnSTRSTELE_3E;
        private void FnSTRSTELE_3E(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetMoveMap(party, 0x03, 0xE0, 0x03, 0x03);
            L001E: // RETURN;
        }

    }
}
