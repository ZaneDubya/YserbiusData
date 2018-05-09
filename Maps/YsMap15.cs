namespace ZCF.Scripts.Maps {
    class YserMap15 : ACanoMapScript {
        // === Strings ================================================
        private const string String03FC = "A note reads -";
        private const string String040B = "'Only heroes of the thirtieth level or higher may pass this door.'";
        private const string String044E = "The Sunbeam Key reveals a hidden door to the Dwarf Kingdom!";
        private const string String048A = "You skillfully pick the door lock.";
        private const string String04AD = "The door is locked.";
        private const string String04C1 = "Invisible hands take Cleowyn's Crown and place it in a niche in the wall.";
        private const string String050B = "The niche disappears.";
        private const string String0521 = "You hear a rumbling sound in the distance";
        private const string String054B = "There is a niche in the wall which seems designed to hold a crown.";
        private const string String058E = "Returning the Crown of Cleowyn reveals a secret door in the west wall!";
        private const string String05D5 = "Cleowyn's Robe flies out of your hands and into a niche in the wall.";
        private const string String061A = "The niche disappears.";
        private const string String0630 = "You hear a rumbling sound in the distance.";
        private const string String065B = "There is a niche in the wall which seems designed to hold a robe.";
        private const string String069D = "Returning the Robe of Cleowyn reveals a secret door in the east wall.";
        private const string String06E3 = "Cleowyn's Scepter is taken from you by spectral hands and is placed in a niche in the wall.";
        private const string String073F = "The spirit of King Cleowyn whispers -";
        private const string String0765 = "'Well done!  The reward is yours for the taking, if you dare claim it.";
        private const string String07AC = "The door to the tomb opens.";
        private const string String07C8 = "There is a niche in the wall which seems designed to hold a scepter.";
        private const string String080D = "The room you enter is cold as ice.";
        private const string String0830 = "An Ice Lion stands over a torn bag of gold.";
        private const string String085C = "The room stinks of rotten meat.";
        private const string String087C = "Something kicks gold across the floor as it charges you.";
        private const string String08B5 = "Lizardites guard this area.";
        private const string String08D1 = "Giants guard the corridor.";
        private const string String08EC = "There are no remains in the crypt, but you see a note. It reads - 'The bones of the cruel king have been given to the dwarfs to grind into powder. Cursed be ye who dare try to return Cleowyn to his crypt.'";
        private const string String09BA = "As you place Cleowyn's bones in the crypt, Cleowyn's spirit whispers to you -";
        private const string String0A08 = "'My thanks to you. You certainly took your time finding my bones. Here is the Netherworld Medallion. Now go away and don't bother me again.'";
        private const string String0A95 = "There are no remains in the crypt, but you see a note. It reads - 'The bones of the cruel king have been given to the dwarfs to grind into powder. Cursed be ye who dare try to return Cleowyn to his crypt.'";
        private const string String0B63 = "You find the Crypt of King Cleowyn and open it. Inside is the Sword of the Crypt, the Mourning Star, the Bow of Sorrow, and Galabryan Chainmail.";
        private const string String0BF4 = "Polar Bears wander the empty room.";
        private const string String0C17 = "A Polar Bear plays with a pile of stuff.";
        private const string String0C40 = "Hell Wolves snarl at you.";
        private const string String0C5A = "A Hell Wolf kicks an object aside as it leaps at you.";
        private const string String0C90 = "This gateway leads to THE GREAT CORRIDOR.";
        private const string String0CBA = "There is a teleport in the east wall.";
        private const string String0CE0 = "There is a teleport in the west wall.";
        private const string String0D06 = "You encounter a Gremlin Cleric.";
        private const string String0D26 = "Listen carefully, friend. Be careful where you place the possessions Cleowyn demands. Use Crown before Robe before Scepter.";
        private const string String0DA2 = "Someone in your group must always remain in the Mausoleum until all three items are placed and the tomb is opened.";
        private const string String0E15 = "Otherwise, imps will steal the treasures away and hide them again.  They love to torment adventurers and Cleowyn's spirit.";
        private const string String0E90 = "Remember to leave one person at all times and to reform your group before continuing your quest.";
        private const string String0EF1 = "The Gremlin Cleric turns away as you approach her.";
        private const string String0F24 = "You encounter a Halfling Knight.";
        private const string String0F45 = "The longest routes through this Mausoleum are the least rewarding.";
        private const string String0F88 = "The Halfling Knight looks at you once and then continues polishing her shield.";
        private const string String0FD7 = "You encounter an Elf Ranger.";
        private const string String0FF4 = "The night the volcano erupted, the wizard Arnakkian Slowfoot threw a great feast. All who attended died in the eruption. They died at their games of cards and gambling. Some, it is said, were transformed into the monsters who inhabit the dungeon.";
        private const string String10EB = "The Elf Ranger abruptly walks away.";
        private const string String110F = "You encounter a Gnome Barbarian.";
        private const string String1130 = "Cleowyn's bones are guarded by the Snow Elves, I have heard. Whether or not it is worth returning the king's bones to the Mausoleum is much debated, for the imps will seize them again and return them to the elves.";
        private const string String1206 = "The Gnome Barbarian opens his mouth to speak, but he forgets what he planned to say.";
        private const string String125B = "You encounter a Human Thief.";
        private const string String1278 = "If you find King Cleowyn's quarters, you will find a shortcut back to his Palace. Be careful where you tread, lest you leave his quarters unrewarded.";
        private const string String130E = "The Human Thief darts away as you approach.";
        
        // === Functions ================================================
        private override MapEventHandler MapEvent01 => FnTOCORDOR_01;
        private void FnTOCORDOR_01(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetMoveMap(party, 0x01, 0x08, 0x03, 0x03);
            L001E: // RETURN;
        }

        private override MapEventHandler MapEvent02 => FnTELEPORT_02;
        private void FnTELEPORT_02(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckLevel44(party, 0x001E);
            L0011: if (result.equal) goto L0030;
            L0013: SetMoveMap(party, 0x02, 0x7A, 0x01, 0x38);
            L002E: goto L0067;
            L0030: ShowMessage(party, String03FC); // A note reads -
            L003D: ShowMessage(party, String040B); // 'Only heroes of the thirtieth level or higher may pass this door.'
            L004A: PushStack(0x00);
            L004D: ax = GetFacing24(party);
            L0054: PushStack(ax);
            L0055: ax = GetNextTile20(party);
            L005C: PushStack(ax);
            L005D: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L0067: // RETURN;
        }

        private override MapEventHandler MapEvent03 => FnTELEPORT_03;
        private void FnTELEPORT_03(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetMoveMap(party, 0x02, 0x20, 0x04, 0x01);
            L001E: // RETURN;
        }

        private override MapEventHandler MapEvent04 => FnHIDNDOOR_04;
        private void FnHIDNDOOR_04(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem50(party, 0xD4);
            L0011: if (result.equal) goto L0059;
            L0013: Push(01);
            L0017: ax = GetFacing24(party);
            L001E: PushStack(ax);
            L001F: ax = GetNextTile20(party);
            L0026: PushStack(ax);
            L0027: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L0031: PushStack(0x00);
            L0034: ax = GetNextTile20(party);
            L003B: PushStack(ax);
            L003C: Push(01);
            L0040: SetUnblocked30(party);
            L004A: ShowMessage(party, String044E); // The Sunbeam Key reveals a hidden door to the Dwarf Kingdom!
            L0057: goto L0076;
            L0059: PushStack(0x00);
            L005C: ax = GetFacing24(party);
            L0063: PushStack(ax);
            L0064: ax = GetNextTile20(party);
            L006B: PushStack(ax);
            L006C: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L0076: // RETURN;
        }

        private override MapEventHandler MapEvent05 => FnLKPKDOOR_05;
        private void FnLKPKDOOR_05(Party party) {
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
            L0065: ShowMessage(party, String048A); // You skillfully pick the door lock.
            L0072: goto L009E;
            L0074: PushStack(0x00);
            L0077: ax = GetFacing24(party);
            L007E: PushStack(ax);
            L007F: ax = GetNextTile20(party);
            L0086: PushStack(ax);
            L0087: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L0091: ShowMessage(party, String04AD); // The door is locked.
            L009E: // RETURN;
        }

        private override MapEventHandler MapEvent06 => FnCRWNNICH_06;
        private void FnCRWNNICH_06(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem50(party, 0x69);
            L0011: if (result.notequal) goto L0028;
            L0013: ax = CheckState08(party, 0x01, 0x01);
            L0026: if (result.equal) goto L0072;
            L0028: RemoveItem4C(party, 0x69);
            L0034: SetState00(party, 0x01, 0x01, 0x01);
            L0049: ShowMessage(party, String04C1); // Invisible hands take Cleowyn's Crown and place it in a niche in the wall.
            L0056: ShowMessage(party, String050B); // The niche disappears.
            L0063: ShowMessage(party, String0521); // You hear a rumbling sound in the distance
            L0070: goto L007F;
            L0072: ShowMessage(party, String054B); // There is a niche in the wall which seems designed to hold a crown.
            L007F: // RETURN;
        }

        private override MapEventHandler MapEvent07 => FnCRWNDOOR_07;
        private void FnCRWNDOOR_07(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x01, 0x01);
            L0014: compare(ax, 0x0001);
            L0017: if (result.notequal) goto L0064;
            L0019: Push(01);
            L001D: ax = GetFacing24(party);
            L0024: PushStack(ax);
            L0025: ax = GetNextTile20(party);
            L002C: PushStack(ax);
            L002D: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L0037: ax = GetFacing24(party);
            L003E: PushStack(ax);
            L003F: ax = GetNextTile20(party);
            L0046: PushStack(ax);
            L0047: Push(01);
            L004B: SetUnblocked30(party);
            L0055: ShowMessage(party, String058E); // Returning the Crown of Cleowyn reveals a secret door in the west wall!
            L0062: goto L0081;
            L0064: PushStack(0x00);
            L0067: ax = GetFacing24(party);
            L006E: PushStack(ax);
            L006F: ax = GetNextTile20(party);
            L0076: PushStack(ax);
            L0077: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L0081: // RETURN;
        }

        private override MapEventHandler MapEvent08 => FnROBENICH_08;
        private void FnROBENICH_08(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem50(party, 0x78);
            L0011: if (result.equal) goto L0029;
            L0013: ax = CheckState04(party, 0x01, 0x01);
            L0024: compare(ax, 0x0001);
            L0027: if (result.equal) goto L003E;
            L0029: ax = CheckState08(party, 0x01, 0x02);
            L003C: if (result.equal) goto L0088;
            L003E: RemoveItem4C(party, 0x78);
            L004A: SetState00(party, 0x01, 0x02, 0x01);
            L005F: ShowMessage(party, String05D5); // Cleowyn's Robe flies out of your hands and into a niche in the wall.
            L006C: ShowMessage(party, String061A); // The niche disappears.
            L0079: ShowMessage(party, String0630); // You hear a rumbling sound in the distance.
            L0086: goto L00AE;
            L0088: PushStack(0x00);
            L008B: Push(02);
            L008F: ax = GetNextTile20(party);
            L0096: PushStack(ax);
            L0097: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L00A1: ShowMessage(party, String065B); // There is a niche in the wall which seems designed to hold a robe.
            L00AE: // RETURN;
        }

        private override MapEventHandler MapEvent09 => FnROBEDOOR_09;
        private void FnROBEDOOR_09(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x01, 0x02);
            L0014: compare(ax, 0x0001);
            L0017: if (result.notequal) goto L005C;
            L0019: Push(01);
            L001D: Push(02);
            L0021: ax = GetNextTile20(party);
            L0028: PushStack(ax);
            L0029: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L0033: Push(02);
            L0037: ax = GetNextTile20(party);
            L003E: PushStack(ax);
            L003F: Push(01);
            L0043: SetUnblocked30(party);
            L004D: ShowMessage(party, String069D); // Returning the Robe of Cleowyn reveals a secret door in the east wall.
            L005A: goto L0079;
            L005C: PushStack(0x00);
            L005F: ax = GetFacing24(party);
            L0066: PushStack(ax);
            L0067: ax = GetNextTile20(party);
            L006E: PushStack(ax);
            L006F: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L0079: // RETURN;
        }

        private override MapEventHandler MapEvent0A => FnSCEPNICH_0A;
        private void FnSCEPNICH_0A(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem50(party, 0xE3);
            L0011: if (result.equal) goto L003D;
            L0013: ax = CheckState08(party, 0x01, 0x01);
            L0026: if (result.equal) goto L003D;
            L0028: ax = CheckState08(party, 0x01, 0x02);
            L003B: if (result.notequal) goto L0055;
            L003D: ax = CheckState08(party, 0x01, 0x03);
            L0050: if (result.notequal) goto L0055;
            L0052: goto L00E0;
            L0055: RemoveItem4C(party, 0xE3);
            L0061: SetState00(party, 0x01, 0x03, 0x01);
            L0076: Push(01);
            L007A: Push(03);
            L007E: ax = GetNextTile20(party);
            L0085: PushStack(ax);
            L0086: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L0090: Push(03);
            L0094: ax = GetNextTile20(party);
            L009B: PushStack(ax);
            L009C: Push(01);
            L00A0: SetUnblocked30(party);
            L00AA: ShowMessage(party, String06E3); // Cleowyn's Scepter is taken from you by spectral hands and is placed in a niche in the wall.
            L00B7: ShowMessage(party, String073F); // The spirit of King Cleowyn whispers -
            L00C4: ShowMessage(party, String0765); // 'Well done!  The reward is yours for the taking, if you dare claim it.
            L00D1: ShowMessage(party, String07AC); // The door to the tomb opens.
            L00DE: goto L0106;
            L00E0: PushStack(0x00);
            L00E3: Push(03);
            L00E7: ax = GetNextTile20(party);
            L00EE: PushStack(ax);
            L00EF: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L00F9: ShowMessage(party, String07C8); // There is a niche in the wall which seems designed to hold a scepter.
            L0106: // RETURN;
        }

        private override MapEventHandler MapEvent0C => FnGOLDAENC_0C;
        private void FnGOLDAENC_0C(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x02, 0x2C);
            L0014: compare(ax, 0x0001);
            L0017: if (result.notequal) goto L0048;
            L0019: ShowMessage(party, String080D); // The room you enter is cold as ice.
            L0026: AddTreasure(party, 0x008C, 0x00, 0x00, 0x00, 0xA9, 0xCC);
            L0046: goto L008B;
            L0048: AddTreasure(party, 0x0FA0, 0x00, 0x00, 0xCD, 0xB7, 0xD0);
            L0069: SetState00(party, 0x02, 0x2C, 0x01);
            L007E: ShowMessage(party, String0830); // An Ice Lion stands over a torn bag of gold.
            L008B: ax = PartyCount(party);
            L0093: compare(ax, 0x0001);
            L0096: if (result.notequal) goto L00BF;
            L0098: AddEncounter(party, 0x19, 0x01);
            L00AA: AddEncounter(party, 0x19, 0x02);
            L00BC: goto L0182;
            L00BF: ax = PartyCount(party);
            L00C7: compare(ax, 0x0002);
            L00CA: if (result.notequal) goto L0116;
            L00CC: AddEncounter(party, 0x19, 0x01);
            L00DE: AddEncounter(party, 0x19, 0x02);
            L00F0: AddEncounter(party, 0x1A, 0x03);
            L0102: AddEncounter(party, 0x1A, 0x04);
            L0114: goto L0182;
            L0116: AddEncounter(party, 0x1A, 0x01);
            L0128: AddEncounter(party, 0x1A, 0x02);
            L013A: AddEncounter(party, 0x1A, 0x03);
            L014C: AddEncounter(party, 0x1A, 0x04);
            L015E: AddEncounter(party, 0x19, 0x05);
            L0170: AddEncounter(party, 0x19, 0x06);
            L0182: // RETURN;
        }

        private override MapEventHandler MapEvent0D => FnGOLDBENC_0D;
        private void FnGOLDBENC_0D(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x02, 0x2D);
            L0014: compare(ax, 0x0001);
            L0017: if (result.notequal) goto L0048;
            L0019: ShowMessage(party, String085C); // The room stinks of rotten meat.
            L0026: AddTreasure(party, 0x00B4, 0x00, 0x00, 0x00, 0xB6, 0xCF);
            L0046: goto L008A;
            L0048: AddTreasure(party, 0x0BB8, 0x00, 0x00, 0x00, 0xD0, 0xAA);
            L0068: SetState00(party, 0x02, 0x2D, 0x01);
            L007D: ShowMessage(party, String087C); // Something kicks gold across the floor as it charges you.
            L008A: ax = PartyCount(party);
            L0092: compare(ax, 0x0001);
            L0095: if (result.equal) goto L00A4;
            L0097: ax = PartyCount(party);
            L009F: compare(ax, 0x0002);
            L00A2: if (result.notequal) goto L00CB;
            L00A4: AddEncounter(party, 0x23, 0x01);
            L00B6: AddEncounter(party, 0x24, 0x02);
            L00C8: goto L0158;
            L00CB: ax = PartyCount(party);
            L00D3: compare(ax, 0x0003);
            L00D6: if (result.notequal) goto L0110;
            L00D8: AddEncounter(party, 0x23, 0x01);
            L00EA: AddEncounter(party, 0x23, 0x02);
            L00FC: AddEncounter(party, 0x23, 0x03);
            L010E: goto L0158;
            L0110: AddEncounter(party, 0x23, 0x01);
            L0122: AddEncounter(party, 0x24, 0x02);
            L0134: AddEncounter(party, 0x24, 0x03);
            L0146: AddEncounter(party, 0x23, 0x04);
            L0158: // RETURN;
        }

        private override MapEventHandler MapEvent0E => FnSPCMONSA_0E;
        private void FnSPCMONSA_0E(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String08B5); // Lizardites guard this area.
            L0010: ax = PartyCount(party);
            L0018: compare(ax, 0x0001);
            L001B: if (result.notequal) goto L0044;
            L001D: AddEncounter(party, 0x1E, 0x01);
            L002F: AddEncounter(party, 0x1E, 0x02);
            L0041: goto L0107;
            L0044: ax = PartyCount(party);
            L004C: compare(ax, 0x0002);
            L004F: if (result.notequal) goto L009B;
            L0051: AddEncounter(party, 0x1E, 0x01);
            L0063: AddEncounter(party, 0x1E, 0x02);
            L0075: AddEncounter(party, 0x1E, 0x03);
            L0087: AddEncounter(party, 0x1E, 0x04);
            L0099: goto L0107;
            L009B: AddEncounter(party, 0x1E, 0x01);
            L00AD: AddEncounter(party, 0x1E, 0x02);
            L00BF: AddEncounter(party, 0x1E, 0x03);
            L00D1: AddEncounter(party, 0x1E, 0x04);
            L00E3: AddEncounter(party, 0x1E, 0x05);
            L00F5: AddEncounter(party, 0x1E, 0x06);
            L0107: // RETURN;
        }

        private override MapEventHandler MapEvent0F => FnSPCMONSB_0F;
        private void FnSPCMONSB_0F(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String08D1); // Giants guard the corridor.
            L0010: ax = PartyCount(party);
            L0018: compare(ax, 0x0001);
            L001B: if (result.notequal) goto L0032;
            L001D: AddEncounter(party, 0x25, 0x01);
            L002F: goto L0102;
            L0032: ax = PartyCount(party);
            L003A: compare(ax, 0x0002);
            L003D: if (result.equal) goto L004C;
            L003F: ax = PartyCount(party);
            L0047: compare(ax, 0x0003);
            L004A: if (result.notequal) goto L0096;
            L004C: AddEncounter(party, 0x25, 0x01);
            L005E: AddEncounter(party, 0x25, 0x02);
            L0070: AddEncounter(party, 0x25, 0x03);
            L0082: AddEncounter(party, 0x25, 0x05);
            L0094: goto L0102;
            L0096: AddEncounter(party, 0x25, 0x01);
            L00A8: AddEncounter(party, 0x25, 0x02);
            L00BA: AddEncounter(party, 0x25, 0x03);
            L00CC: AddEncounter(party, 0x25, 0x04);
            L00DE: AddEncounter(party, 0x25, 0x05);
            L00F0: AddEncounter(party, 0x25, 0x06);
            L0102: // RETURN;
        }

        private override MapEventHandler MapEvent10 => FnSPCMONSC_10;
        private void FnSPCMONSC_10(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = PartyCount(party);
            L000B: compare(ax, 0x0001);
            L000E: if (result.notequal) goto L0037;
            L0010: AddEncounter(party, 0x27, 0x01);
            L0022: AddEncounter(party, 0x28, 0x05);
            L0034: goto L0176;
            L0037: ax = PartyCount(party);
            L003F: compare(ax, 0x0002);
            L0042: if (result.notequal) goto L008F;
            L0044: AddEncounter(party, 0x27, 0x01);
            L0056: AddEncounter(party, 0x27, 0x02);
            L0068: AddEncounter(party, 0x28, 0x05);
            L007A: AddEncounter(party, 0x28, 0x06);
            L008C: goto L0176;
            L008F: ax = PartyCount(party);
            L0097: compare(ax, 0x0003);
            L009A: if (result.notequal) goto L010A;
            L009C: AddEncounter(party, 0x27, 0x01);
            L00AE: AddEncounter(party, 0x27, 0x02);
            L00C0: AddEncounter(party, 0x27, 0x03);
            L00D2: AddEncounter(party, 0x27, 0x04);
            L00E4: AddEncounter(party, 0x28, 0x05);
            L00F6: AddEncounter(party, 0x28, 0x06);
            L0108: goto L0176;
            L010A: AddEncounter(party, 0x27, 0x01);
            L011C: AddEncounter(party, 0x27, 0x02);
            L012E: AddEncounter(party, 0x28, 0x03);
            L0140: AddEncounter(party, 0x28, 0x04);
            L0152: AddEncounter(party, 0x28, 0x05);
            L0164: AddEncounter(party, 0x28, 0x06);
            L0176: // RETURN;
        }

        private override MapEventHandler MapEvent11 => FnPAYOFENC_11;
        private void FnPAYOFENC_11(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x02, 0x37);
            L0014: compare(ax, 0x0002);
            L0017: if (result.notequal) goto L0029;
            L0019: ShowMessage(party, String08EC); // There are no remains in the crypt, but you see a note. It reads - 'The bones of the cruel king have been given to the dwarfs to grind into powder. Cursed be ye who dare try to return Cleowyn to his crypt.'
            L0026: goto L011D;
            L0029: ax = CheckState04(party, 0x02, 0x37);
            L003A: compare(ax, 0x0001);
            L003D: if (result.notequal) goto L00B9;
            L003F: ax = HasItem50(party, 0xFA);
            L004D: if (result.equal) goto L00AA;
            L004F: RemoveItem4C(party, 0xFA);
            L005B: GiveItem48(party, 0x96);
            L0067: SetState00(party, 0x02, 0x37, 0x02);
            L007C: AddExperience98(party, 0x000B71B0);
            L008E: ShowMessage(party, String09BA); // As you place Cleowyn's bones in the crypt, Cleowyn's spirit whispers to you -
            L009B: ShowMessage(party, String0A08); // 'My thanks to you. You certainly took your time finding my bones. Here is the Netherworld Medallion. Now go away and don't bother me again.'
            L00A8: goto L00B7;
            L00AA: ShowMessage(party, String0A95); // There are no remains in the crypt, but you see a note. It reads - 'The bones of the cruel king have been given to the dwarfs to grind into powder. Cursed be ye who dare try to return Cleowyn to his crypt.'
            L00B7: goto L011D;
            L00B9: SetState00(party, 0x02, 0x37, 0x01);
            L00CE: GiveItem48(party, 0x0A);
            L00DA: GiveItem48(party, 0x21);
            L00E6: GiveItem48(party, 0x48);
            L00F2: GiveItem48(party, 0x7C);
            L00FE: AddExperience98(party, 0x0003D090);
            L0110: ShowMessage(party, String0B63); // You find the Crypt of King Cleowyn and open it. Inside is the Sword of the Crypt, the Mourning Star, the Bow of Sorrow, and Galabryan Chainmail.
            L011D: // RETURN;
        }

        private override MapEventHandler MapEvent12 => FnITEMAENC_12;
        private void FnITEMAENC_12(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x02, 0x67);
            L0014: compare(ax, 0x0001);
            L0017: if (result.notequal) goto L0047;
            L0019: ShowMessage(party, String0BF4); // Polar Bears wander the empty room.
            L0026: AddTreasure(party, 0x00C8, 0x00, 0x00, 0x00, 0x00, 0xB7);
            L0045: goto L008B;
            L0047: SetState00(party, 0x02, 0x67, 0x01);
            L005C: AddTreasure(party, 0x1B58, 0x00, 0xD0, 0xB2, 0xAA, 0xB0);
            L007E: ShowMessage(party, String0C17); // A Polar Bear plays with a pile of stuff.
            L008B: ax = PartyCount(party);
            L0093: compare(ax, 0x0001);
            L0096: if (result.equal) goto L00A5;
            L0098: ax = PartyCount(party);
            L00A0: compare(ax, 0x0002);
            L00A3: if (result.notequal) goto L00CB;
            L00A5: AddEncounter(party, 0x1B, 0x01);
            L00B7: AddEncounter(party, 0x1B, 0x02);
            L00C9: goto L0113;
            L00CB: AddEncounter(party, 0x1B, 0x01);
            L00DD: AddEncounter(party, 0x1B, 0x02);
            L00EF: AddEncounter(party, 0x1B, 0x03);
            L0101: AddEncounter(party, 0x1B, 0x04);
            L0113: // RETURN;
        }

        private override MapEventHandler MapEvent13 => FnITEMBENC_13;
        private void FnITEMBENC_13(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem50(party, 0xA1);
            L0011: if (result.equal) goto L0041;
            L0013: ShowMessage(party, String0C40); // Hell Wolves snarl at you.
            L0020: AddTreasure(party, 0x012C, 0x00, 0x00, 0x00, 0x00, 0xB7);
            L003F: goto L006E;
            L0041: AddTreasure(party, 0x1388, 0x00, 0x00, 0x00, 0xD0, 0xA1);
            L0061: ShowMessage(party, String0C5A); // A Hell Wolf kicks an object aside as it leaps at you.
            L006E: ax = PartyCount(party);
            L0076: compare(ax, 0x0001);
            L0079: if (result.equal) goto L0088;
            L007B: ax = PartyCount(party);
            L0083: compare(ax, 0x0002);
            L0086: if (result.notequal) goto L00AE;
            L0088: AddEncounter(party, 0x1F, 0x01);
            L009A: AddEncounter(party, 0x1F, 0x02);
            L00AC: goto L00F6;
            L00AE: AddEncounter(party, 0x1F, 0x01);
            L00C0: AddEncounter(party, 0x1F, 0x02);
            L00D2: AddEncounter(party, 0x1F, 0x03);
            L00E4: AddEncounter(party, 0x1F, 0x04);
            L00F6: // RETURN;
        }

        private override MapEventHandler MapEvent14 => FnBADMNSTR_14;
        private void FnBADMNSTR_14(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = PartyCount(party);
            L000B: compare(ax, 0x0001);
            L000E: if (result.notequal) goto L0037;
            L0010: AddEncounter(party, 0x1C, 0x01);
            L0022: AddEncounter(party, 0x1E, 0x02);
            L0034: goto L0176;
            L0037: ax = PartyCount(party);
            L003F: compare(ax, 0x0002);
            L0042: if (result.notequal) goto L008F;
            L0044: AddEncounter(party, 0x1D, 0x01);
            L0056: AddEncounter(party, 0x1D, 0x02);
            L0068: AddEncounter(party, 0x1E, 0x03);
            L007A: AddEncounter(party, 0x1E, 0x04);
            L008C: goto L0176;
            L008F: ax = PartyCount(party);
            L0097: compare(ax, 0x0003);
            L009A: if (result.notequal) goto L010A;
            L009C: AddEncounter(party, 0x1C, 0x01);
            L00AE: AddEncounter(party, 0x1C, 0x02);
            L00C0: AddEncounter(party, 0x1D, 0x03);
            L00D2: AddEncounter(party, 0x1D, 0x04);
            L00E4: AddEncounter(party, 0x1E, 0x05);
            L00F6: AddEncounter(party, 0x1E, 0x06);
            L0108: goto L0176;
            L010A: AddEncounter(party, 0x1E, 0x01);
            L011C: AddEncounter(party, 0x1E, 0x02);
            L012E: AddEncounter(party, 0x1E, 0x03);
            L0140: AddEncounter(party, 0x1E, 0x04);
            L0152: AddEncounter(party, 0x1D, 0x05);
            L0164: AddEncounter(party, 0x1D, 0x06);
            L0176: // RETURN;
        }

        private override MapEventHandler MapEvent15 => FnTERMNSTR_15;
        private void FnTERMNSTR_15(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = PartyCount(party);
            L000B: compare(ax, 0x0001);
            L000E: if (result.notequal) goto L0037;
            L0010: AddEncounter(party, 0x1F, 0x01);
            L0022: AddEncounter(party, 0x22, 0x02);
            L0034: goto L0188;
            L0037: ax = PartyCount(party);
            L003F: compare(ax, 0x0002);
            L0042: if (result.notequal) goto L00A1;
            L0044: AddEncounter(party, 0x20, 0x01);
            L0056: AddEncounter(party, 0x22, 0x02);
            L0068: AddEncounter(party, 0x20, 0x03);
            L007A: AddEncounter(party, 0x22, 0x04);
            L008C: AddEncounter(party, 0x21, 0x05);
            L009E: goto L0188;
            L00A1: ax = PartyCount(party);
            L00A9: compare(ax, 0x0003);
            L00AC: if (result.notequal) goto L011C;
            L00AE: AddEncounter(party, 0x21, 0x01);
            L00C0: AddEncounter(party, 0x22, 0x02);
            L00D2: AddEncounter(party, 0x21, 0x03);
            L00E4: AddEncounter(party, 0x22, 0x04);
            L00F6: AddEncounter(party, 0x21, 0x05);
            L0108: AddEncounter(party, 0x22, 0x06);
            L011A: goto L0188;
            L011C: AddEncounter(party, 0x22, 0x01);
            L012E: AddEncounter(party, 0x22, 0x02);
            L0140: AddEncounter(party, 0x22, 0x03);
            L0152: AddEncounter(party, 0x22, 0x04);
            L0164: AddEncounter(party, 0x21, 0x05);
            L0176: AddEncounter(party, 0x21, 0x06);
            L0188: // RETURN;
        }

        private override MapEventHandler MapEvent16 => FnGATEMESS_16;
        private void FnGATEMESS_16(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0C90); // This gateway leads to THE GREAT CORRIDOR.
            L0010: // RETURN;
        }

        private override MapEventHandler MapEvent17 => FnTELEMESA_17;
        private void FnTELEMESA_17(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0CBA); // There is a teleport in the east wall.
            L0010: // RETURN;
        }

        private override MapEventHandler MapEvent18 => FnTELEMESB_18;
        private void FnTELEMESB_18(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TileIsNoJoinArea(party);
            L000B: ShowMessage(party, String0CE0); // There is a teleport in the west wall.
            L0018: // RETURN;
        }

        private override MapEventHandler MapEvent19 => FnNPCCHATA_19;
        private void FnNPCCHATA_19(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0D06); // You encounter a Gremlin Cleric.
            L0010: ShowPortrait(party, 0x002A);
            L001D: ax = UnknownFunctionEC(party, 0x000F);
            L002A: compare(ax, 0x000D);
            L002D: if (result.unsigned_greater_than) goto L0065;
            L002F: ShowMessage(party, String0D26); // Listen carefully, friend. Be careful where you place the possessions Cleowyn demands. Use Crown before Robe before Scepter.
            L003C: ShowMessage(party, String0DA2); // Someone in your group must always remain in the Mausoleum until all three items are placed and the tomb is opened.
            L0049: ShowMessage(party, String0E15); // Otherwise, imps will steal the treasures away and hide them again.  They love to torment adventurers and Cleowyn's spirit.
            L0056: ShowMessage(party, String0E90); // Remember to leave one person at all times and to reform your group before continuing your quest.
            L0063: goto L0072;
            L0065: ShowMessage(party, String0EF1); // The Gremlin Cleric turns away as you approach her.
            L0072: // RETURN;
        }

        private override MapEventHandler MapEvent1A => FnNPCCHATB_1A;
        private void FnNPCCHATB_1A(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0F24); // You encounter a Halfling Knight.
            L0010: ShowPortrait(party, 0x001D);
            L001D: ax = UnknownFunctionEC(party, 0x000F);
            L002A: compare(ax, 0x000C);
            L002D: if (result.unsigned_greater_than) goto L003E;
            L002F: ShowMessage(party, String0F45); // The longest routes through this Mausoleum are the least rewarding.
            L003C: goto L004B;
            L003E: ShowMessage(party, String0F88); // The Halfling Knight looks at you once and then continues polishing her shield.
            L004B: // RETURN;
        }

        private override MapEventHandler MapEvent1B => FnNPCCHATC_1B;
        private void FnNPCCHATC_1B(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0FD7); // You encounter an Elf Ranger.
            L0010: ShowPortrait(party, 0x001F);
            L001D: ax = UnknownFunctionEC(party, 0x000F);
            L002A: compare(ax, 0x000B);
            L002D: if (result.unsigned_greater_than) goto L003E;
            L002F: ShowMessage(party, String0FF4); // The night the volcano erupted, the wizard Arnakkian Slowfoot threw a great feast. All who attended died in the eruption. They died at their games of cards and gambling. Some, it is said, were transformed into the monsters who inhabit the dungeon.
            L003C: goto L004B;
            L003E: ShowMessage(party, String10EB); // The Elf Ranger abruptly walks away.
            L004B: // RETURN;
        }

        private override MapEventHandler MapEvent1C => FnNPCCHATD_1C;
        private void FnNPCCHATD_1C(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String110F); // You encounter a Gnome Barbarian.
            L0010: ShowPortrait(party, 0x0019);
            L001D: ax = UnknownFunctionEC(party, 0x000F);
            L002A: compare(ax, 0x0007);
            L002D: if (result.unsigned_greater_than) goto L003E;
            L002F: ShowMessage(party, String1130); // Cleowyn's bones are guarded by the Snow Elves, I have heard. Whether or not it is worth returning the king's bones to the Mausoleum is much debated, for the imps will seize them again and return them to the elves.
            L003C: goto L004B;
            L003E: ShowMessage(party, String1206); // The Gnome Barbarian opens his mouth to speak, but he forgets what he planned to say.
            L004B: // RETURN;
        }

        private override MapEventHandler MapEvent1D => FnNPCCHATE_1D;
        private void FnNPCCHATE_1D(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String125B); // You encounter a Human Thief.
            L0010: ShowPortrait(party, 0x0022);
            L001D: ax = UnknownFunctionEC(party, 0x000F);
            L002A: compare(ax, 0x0009);
            L002D: if (result.unsigned_greater_than) goto L003E;
            L002F: ShowMessage(party, String1278); // If you find King Cleowyn's quarters, you will find a shortcut back to his Palace. Be careful where you tread, lest you leave his quarters unrewarded.
            L003C: goto L004B;
            L003E: ShowMessage(party, String130E); // The Human Thief darts away as you approach.
            L004B: // RETURN;
        }

        private override MapEventHandler MapEvent1E => FnMINOTAUR_1E;
        private void FnMINOTAUR_1E(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = PartyCount(party);
            L000B: compare(ax, 0x0001);
            L000E: if (result.notequal) goto L0025;
            L0010: AddEncounter(party, 0x26, 0x01);
            L0022: goto L00D6;
            L0025: ax = PartyCount(party);
            L002D: compare(ax, 0x0002);
            L0030: if (result.notequal) goto L006A;
            L0032: AddEncounter(party, 0x26, 0x01);
            L0044: AddEncounter(party, 0x26, 0x02);
            L0056: AddEncounter(party, 0x26, 0x03);
            L0068: goto L00D6;
            L006A: AddEncounter(party, 0x26, 0x01);
            L007C: AddEncounter(party, 0x26, 0x02);
            L008E: AddEncounter(party, 0x26, 0x03);
            L00A0: AddEncounter(party, 0x26, 0x04);
            L00B2: AddEncounter(party, 0x26, 0x05);
            L00C4: AddEncounter(party, 0x26, 0x06);
            L00D6: // RETURN;
        }

    }
}
