namespace ZCF.Scripts.Maps {
    class YserMap12 : ACanoMapScript {
        // === Strings ================================================
        private const string String03FC = "You see a switch on the wall and throw it. You hear the sound of locks opening.";
        private const string String044C = "You see a switch on the wall and throw it. You hear the sound of locks opening.";
        private const string String049C = "You see a switch on the wall and throw it. You hear the sound of locks opening.";
        private const string String04EC = "You see a switch on the wall and throw it. You hear the sound of locks opening.";
        private const string String053C = "The door is unlocked.";
        private const string String0552 = "The door is sealed shut. There is no lock on the outside.";
        private const string String058C = "The door is unlocked.";
        private const string String05A2 = "The door is sealed shut. There is no lock on the outside.";
        private const string String05DC = "The door is unlocked.";
        private const string String05F2 = "The door is sealed shut. There is no lock on the outside.";
        private const string String062C = "The door is unlocked.";
        private const string String0642 = "The door is sealed shut. There is no lock on the outside.";
        private const string String067C = "A door appears in the south wall.";
        private const string String069E = "Monsters attack you.";
        private const string String06B3 = "A key dangles from a spider's mandible.";
        private const string String06DB = "Silver Ogres spring a trap.";
        private const string String06F7 = "A Silver Ogre plays with an unusual key.";
        private const string String0720 = "Lizardites have made this room their home.";
        private const string String074B = "A Lizardite holds a key shaped like the rune sign for I.";
        private const string String0784 = "The tapestry contains runes...";
        private const string String07A3 = "Take the Crown, Robe and Scepter to the Mausoleum of Cleowyn. Use them in the correct niches to open the true path to the king's tomb.";
        private const string String082A = "There are runes on this tapestry...";
        private const string String084E = "Go west, but not farthest west, and give the Crown when you can go no more. Go east, but not farthest east, and give the Robe when you can go no more. When Crown and Robe are given, continue to the door of the tomb. Give the Scepter there to be rewarded.";
        private const string String094D = "You encounter Bugbears.";
        private const string String0965 = "Bugbears stand near some gold.";
        private const string String0984 = "Dire Wolves scratch the floor impatiently.";
        private const string String09AF = "A Dire Wolf plays with a coin purse.";
        private const string String09D4 = "You suddenly feel nervous.";
        private const string String09EF = "Hungry lions prowl the area.";
        private const string String0A0C = "The floor crawls with Leeches.";
        private const string String0A2B = "Leeches swarm over a magic wand.";
        private const string String0A4C = "Giants interrupt your search.";
        private const string String0A6A = "A Giant wears a medallion around his neck.";
        private const string String0A95 = "You disturb a nest of Cockatrices.";
        private const string String0AB8 = "You see a vial in a Cockatrice nest.";
        private const string String0ADD = "Silver Ogres suddenly appear around you.";
        private const string String0B06 = "The lead Silver Ogre wields a powerful morningstar.";
        private const string String0B3A = "You disturb some sleeping Giants.";
        private const string String0B5C = "A gleaming sword lies on the floor between you and a group of Giants.";
        private const string String0BA2 = "Dark shadows coalesce into Bugbears.";
        private const string String0BC7 = "A Bugbear guards some chainmail.";
        private const string String0BE8 = "You enter a roosting area for Cockatrices.";
        private const string String0C13 = "In a Cockatrice nest you see luminous chainmail.";
        private const string String0C44 = "Dire Wolves encircle you.";
        private const string String0C5E = "Dire Wolves seem fascinated by a shiny shield.";
        private const string String0C8D = "Loud hisses alert you to danger.";
        private const string String0CAE = "Lizardites move between you and a piece of armor on the floor.";
        private const string String0CED = "The door is unlocked.";
        private const string String0D03 = "The door is sealed shut. You see what appears to be the bas relief of a royal ring ";
        private const string String0D57 = "The stairs through the north gateway lead up. The gateway to the east leads to THE GREAT CORRIDOR.";
        private const string String0DBA = "The stairs past the south gateway lead up a level.";
        private const string String0DED = "There are stairs through the the north gateway.";
        private const string String0E1D = "There are stairs beyond the west gateway.";
        private const string String0E47 = "You encounter a Human Barbarian.";
        private const string String0E68 = "The opening and closing of secret doors in this area give me a headache. I simply cannot puzzle out the correct sequence of opening the doors. I wish my map of this area were more complete.";
        private const string String0F26 = "By the way, if you don't have the king's ring, you won't get anywhere in this crazy place.";
        private const string String0F81 = "The Human Barbarian pays you no attention as he puzzles over a map.";
        private const string String0FC5 = "You encounter a Gnome Wizard.";
        private const string String0FE3 = "Once you find a key in this area, seek the hidden door and follow your destiny. The door appears only when you have the right key. Where it leads I do not know.";
        private const string String1084 = "The Gnome Wizard is too intent on drawing runes in the dust to talk to you.";
        private const string String10D0 = "You encounter an Orc Knight.";
        private const string String10ED = "There are many ways into King Cleowyn's Mausoleum, but few are rewarding. The most direct ways are the most challenging. Do not continue unless you have what the king demands.";
        private const string String119D = "The Orc Knight dismisses you as low-level buffoons.";
        private const string String11D1 = "You encounter a Halfling Thief.";
        private const string String11F1 = "Beneath the king's living quarters is an area known as the Thieves' Maze. Only an experienced thief - or a hero who has a thief's skills - will pick his way through this intricate maze.";
        private const string String12AB = "The Halfling Thief steals some gold and runs away.";
        
        // === Functions ================================================
        private override MapEventHandler MapEvent01 => FnSTRSTELE_01;
        private void FnSTRSTELE_01(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetMoveMap(party, 0x01, 0x1F, 0x02, 0x02);
            L001E: // RETURN;
        }

        private override MapEventHandler MapEvent02 => FnTOCORDOR_02;
        private void FnTOCORDOR_02(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetMoveMap(party, 0x02, 0x10, 0x03, 0x03);
            L001E: // RETURN;
        }

        private override MapEventHandler MapEvent03 => FnSTRSTELE_03;
        private void FnSTRSTELE_03(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetMoveMap(party, 0x02, 0xD3, 0x03, 0x02);
            L001E: // RETURN;
        }

        private override MapEventHandler MapEvent04 => FnSTRSTELE_04;
        private void FnSTRSTELE_04(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetMoveMap(party, 0x00, 0xC6, 0x04, 0x02);
            L001D: // RETURN;
        }

        private override MapEventHandler MapEvent05 => FnSTRSTELE_05;
        private void FnSTRSTELE_05(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetMoveMap(party, 0x01, 0xDC, 0x05, 0x02);
            L001E: // RETURN;
        }

        private override MapEventHandler MapEvent06 => FnNDORSWCH_06;
        private void FnNDORSWCH_06(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String03FC); // You see a switch on the wall and throw it. You hear the sound of locks opening.
            L0010: SetState00(party, 0x01, 0x01, 0x01);
            L0025: SetState00(party, 0x01, 0x02, 0x00);
            L0039: SetState00(party, 0x01, 0x03, 0x00);
            L004D: SetState00(party, 0x01, 0x04, 0x00);
            L0061: SetMove2C(party, 0x01, 0x01, 0x77);
            L0077: SetMove28(party, 0x01, 0x01, 0x77);
            L008D: // RETURN;
        }

        private override MapEventHandler MapEvent07 => FnEDORSWCH_07;
        private void FnEDORSWCH_07(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String044C); // You see a switch on the wall and throw it. You hear the sound of locks opening.
            L0010: SetState00(party, 0x01, 0x01, 0x00);
            L0024: SetState00(party, 0x01, 0x02, 0x00);
            L0038: SetState00(party, 0x01, 0x03, 0x01);
            L004D: SetState00(party, 0x01, 0x04, 0x00);
            L0061: SetMove2C(party, 0x01, 0x00, 0x77);
            L0076: SetMove28(party, 0x01, 0x00, 0x77);
            L008B: // RETURN;
        }

        private override MapEventHandler MapEvent08 => FnEDORSWCH_08;
        private void FnEDORSWCH_08(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String049C); // You see a switch on the wall and throw it. You hear the sound of locks opening.
            L0010: SetState00(party, 0x01, 0x01, 0x00);
            L0024: SetState00(party, 0x01, 0x02, 0x01);
            L0039: SetState00(party, 0x01, 0x03, 0x00);
            L004D: SetState00(party, 0x01, 0x04, 0x00);
            L0061: SetMove2C(party, 0x01, 0x03, 0x77);
            L0077: SetMove28(party, 0x01, 0x03, 0x77);
            L008D: // RETURN;
        }

        private override MapEventHandler MapEvent09 => FnWDORSWCH_09;
        private void FnWDORSWCH_09(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String04EC); // You see a switch on the wall and throw it. You hear the sound of locks opening.
            L0010: SetState00(party, 0x01, 0x01, 0x00);
            L0024: SetState00(party, 0x01, 0x02, 0x00);
            L0038: SetState00(party, 0x01, 0x03, 0x00);
            L004C: SetState00(party, 0x01, 0x04, 0x01);
            L0061: SetMove2C(party, 0x01, 0x02, 0x77);
            L0077: SetMove28(party, 0x01, 0x02, 0x77);
            L008D: // RETURN;
        }

        private override MapEventHandler MapEvent0A => FnNSWCHDOR_0A;
        private void FnNSWCHDOR_0A(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x01, 0x01);
            L0014: compare(ax, 0x0001);
            L0017: if (result.notequal) goto L005C;
            L0019: ShowMessage(party, String053C); // The door is unlocked.
            L0026: Push(03);
            L002A: ax = GetNextTile20(party);
            L0031: PushStack(ax);
            L0032: Push(01);
            L0036: SetUnblocked30(party);
            L0040: Push(01);
            L0044: Push(03);
            L0048: ax = GetNextTile20(party);
            L004F: PushStack(ax);
            L0050: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L005A: goto L0082;
            L005C: ShowMessage(party, String0552); // The door is sealed shut. There is no lock on the outside.
            L0069: PushStack(0x00);
            L006C: Push(03);
            L0070: ax = GetNextTile20(party);
            L0077: PushStack(ax);
            L0078: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L0082: // RETURN;
        }

        private override MapEventHandler MapEvent0B => FnESWCHDOR_0B;
        private void FnESWCHDOR_0B(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x01, 0x03);
            L0014: compare(ax, 0x0001);
            L0017: if (result.notequal) goto L005C;
            L0019: ShowMessage(party, String058C); // The door is unlocked.
            L0026: Push(02);
            L002A: ax = GetNextTile20(party);
            L0031: PushStack(ax);
            L0032: Push(01);
            L0036: SetUnblocked30(party);
            L0040: Push(01);
            L0044: Push(02);
            L0048: ax = GetNextTile20(party);
            L004F: PushStack(ax);
            L0050: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L005A: goto L0082;
            L005C: ShowMessage(party, String05A2); // The door is sealed shut. There is no lock on the outside.
            L0069: PushStack(0x00);
            L006C: Push(02);
            L0070: ax = GetNextTile20(party);
            L0077: PushStack(ax);
            L0078: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L0082: // RETURN;
        }

        private override MapEventHandler MapEvent0C => FnSSWCHDOR_0C;
        private void FnSSWCHDOR_0C(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x01, 0x02);
            L0014: compare(ax, 0x0001);
            L0017: if (result.notequal) goto L005C;
            L0019: ShowMessage(party, String05DC); // The door is unlocked.
            L0026: Push(01);
            L002A: ax = GetNextTile20(party);
            L0031: PushStack(ax);
            L0032: Push(01);
            L0036: SetUnblocked30(party);
            L0040: Push(01);
            L0044: Push(01);
            L0048: ax = GetNextTile20(party);
            L004F: PushStack(ax);
            L0050: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L005A: goto L0082;
            L005C: ShowMessage(party, String05F2); // The door is sealed shut. There is no lock on the outside.
            L0069: PushStack(0x00);
            L006C: Push(01);
            L0070: ax = GetNextTile20(party);
            L0077: PushStack(ax);
            L0078: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L0082: // RETURN;
        }

        private override MapEventHandler MapEvent0D => FnWSWCHDOR_0D;
        private void FnWSWCHDOR_0D(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x01, 0x04);
            L0014: compare(ax, 0x0001);
            L0017: if (result.notequal) goto L005A;
            L0019: ShowMessage(party, String062C); // The door is unlocked.
            L0026: PushStack(0x00);
            L0029: ax = GetNextTile20(party);
            L0030: PushStack(ax);
            L0031: Push(01);
            L0035: SetUnblocked30(party);
            L003F: Push(01);
            L0043: PushStack(0x00);
            L0046: ax = GetNextTile20(party);
            L004D: PushStack(ax);
            L004E: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L0058: goto L007F;
            L005A: ShowMessage(party, String0642); // The door is sealed shut. There is no lock on the outside.
            L0067: PushStack(0x00);
            L006A: PushStack(0x00);
            L006D: ax = GetNextTile20(party);
            L0074: PushStack(ax);
            L0075: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L007F: // RETURN;
        }

        private override MapEventHandler MapEvent0E => FnALLSWDOR_0E;
        private void FnALLSWDOR_0E(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem50(party, 0xDA);
            L0011: if (result.notequal) goto L0033;
            L0013: ax = HasItem50(party, 0xDB);
            L0021: if (result.notequal) goto L0033;
            L0023: ax = HasItem50(party, 0xDC);
            L0031: if (result.equal) goto L0076;
            L0033: ShowMessage(party, String067C); // A door appears in the south wall.
            L0040: Push(01);
            L0044: ax = GetNextTile20(party);
            L004B: PushStack(ax);
            L004C: Push(01);
            L0050: SetUnblocked30(party);
            L005A: Push(01);
            L005E: Push(01);
            L0062: ax = GetNextTile20(party);
            L0069: PushStack(ax);
            L006A: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L0074: goto L008F;
            L0076: PushStack(0x00);
            L0079: Push(01);
            L007D: ax = GetNextTile20(party);
            L0084: PushStack(ax);
            L0085: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L008F: // RETURN;
        }

        private override MapEventHandler MapEvent0F => FnWKEYENC_0F;
        private void FnWKEYENC_0F(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem50(party, 0xDA);
            L0011: if (result.equal) goto L0041;
            L0013: AddTreasure(party, 0x03E8, 0x00, 0x00, 0x00, 0x00, 0xBE);
            L0032: ShowMessage(party, String069E); // Monsters attack you.
            L003F: goto L006E;
            L0041: AddTreasure(party, 0x03E8, 0x00, 0x00, 0x00, 0xCF, 0xDA);
            L0061: ShowMessage(party, String06B3); // A key dangles from a spider's mandible.
            L006E: ax = PartyCount(party);
            L0076: compare(ax, 0x0001);
            L0079: if (result.equal) goto L0088;
            L007B: ax = PartyCount(party);
            L0083: compare(ax, 0x0002);
            L0086: if (result.notequal) goto L00D2;
            L0088: AddEncounter(party, 0x1C, 0x01);
            L009A: AddEncounter(party, 0x1C, 0x02);
            L00AC: AddEncounter(party, 0x19, 0x03);
            L00BE: AddEncounter(party, 0x19, 0x04);
            L00D0: goto L013E;
            L00D2: AddEncounter(party, 0x1A, 0x01);
            L00E4: AddEncounter(party, 0x1A, 0x02);
            L00F6: AddEncounter(party, 0x1C, 0x03);
            L0108: AddEncounter(party, 0x1C, 0x04);
            L011A: AddEncounter(party, 0x1A, 0x05);
            L012C: AddEncounter(party, 0x1A, 0x06);
            L013E: // RETURN;
        }

        private override MapEventHandler MapEvent10 => FnCKEYENC_10;
        private void FnCKEYENC_10(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem50(party, 0xDB);
            L0011: if (result.equal) goto L0041;
            L0013: AddTreasure(party, 0x03E8, 0x00, 0x00, 0x00, 0x00, 0xB6);
            L0032: ShowMessage(party, String06DB); // Silver Ogres spring a trap.
            L003F: goto L006F;
            L0041: AddTreasure(party, 0x05DC, 0x00, 0x00, 0xCC, 0xD1, 0xDB);
            L0062: ShowMessage(party, String06F7); // A Silver Ogre plays with an unusual key.
            L006F: ax = PartyCount(party);
            L0077: compare(ax, 0x0001);
            L007A: if (result.equal) goto L0089;
            L007C: ax = PartyCount(party);
            L0084: compare(ax, 0x0002);
            L0087: if (result.notequal) goto L00AF;
            L0089: AddEncounter(party, 0x21, 0x01);
            L009B: AddEncounter(party, 0x21, 0x02);
            L00AD: goto L011B;
            L00AF: AddEncounter(party, 0x23, 0x01);
            L00C1: AddEncounter(party, 0x23, 0x02);
            L00D3: AddEncounter(party, 0x24, 0x03);
            L00E5: AddEncounter(party, 0x24, 0x04);
            L00F7: AddEncounter(party, 0x22, 0x05);
            L0109: AddEncounter(party, 0x22, 0x06);
            L011B: // RETURN;
        }

        private override MapEventHandler MapEvent11 => FnEKEYENC_11;
        private void FnEKEYENC_11(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem50(party, 0xDC);
            L0011: if (result.equal) goto L0041;
            L0013: AddTreasure(party, 0x0320, 0x00, 0x00, 0x00, 0x00, 0xB6);
            L0032: ShowMessage(party, String0720); // Lizardites have made this room their home.
            L003F: goto L006E;
            L0041: AddTreasure(party, 0x07D0, 0x00, 0x00, 0x00, 0xB6, 0xDC);
            L0061: ShowMessage(party, String074B); // A Lizardite holds a key shaped like the rune sign for I.
            L006E: ax = PartyCount(party);
            L0076: compare(ax, 0x0001);
            L0079: if (result.equal) goto L0088;
            L007B: ax = PartyCount(party);
            L0083: compare(ax, 0x0002);
            L0086: if (result.notequal) goto L00D2;
            L0088: AddEncounter(party, 0x27, 0x01);
            L009A: AddEncounter(party, 0x27, 0x02);
            L00AC: AddEncounter(party, 0x28, 0x03);
            L00BE: AddEncounter(party, 0x28, 0x04);
            L00D0: goto L013E;
            L00D2: AddEncounter(party, 0x28, 0x01);
            L00E4: AddEncounter(party, 0x28, 0x02);
            L00F6: AddEncounter(party, 0x27, 0x03);
            L0108: AddEncounter(party, 0x27, 0x04);
            L011A: AddEncounter(party, 0x28, 0x05);
            L012C: AddEncounter(party, 0x28, 0x06);
            L013E: // RETURN;
        }

        private override MapEventHandler MapEvent12 => FnRUNECLUE_12;
        private void FnRUNECLUE_12(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0784); // The tapestry contains runes...
            L0010: ShowRunes(party, String07A3); // Take the Crown, Robe and Scepter to the Mausoleum of Cleowyn. Use them in the correct niches to open the true path to the king's tomb.
            L001D: // RETURN;
        }

        private override MapEventHandler MapEvent13 => FnCLUEB_13;
        private void FnCLUEB_13(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String082A); // There are runes on this tapestry...
            L0010: ShowRunes(party, String084E); // Go west, but not farthest west, and give the Crown when you can go no more. Go east, but not farthest east, and give the Robe when you can go no more. When Crown and Robe are given, continue to the door of the tomb. Give the Scepter there to be rewarded.
            L001D: // RETURN;
        }

        private override MapEventHandler MapEvent14 => FnTUFMNSTR_14;
        private void FnTUFMNSTR_14(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = PartyCount(party);
            L000B: compare(ax, 0x0001);
            L000E: if (result.notequal) goto L0037;
            L0010: AddEncounter(party, 0x1D, 0x01);
            L0022: AddEncounter(party, 0x1F, 0x02);
            L0034: goto L0176;
            L0037: ax = PartyCount(party);
            L003F: compare(ax, 0x0002);
            L0042: if (result.notequal) goto L00A1;
            L0044: AddEncounter(party, 0x1E, 0x01);
            L0056: AddEncounter(party, 0x1E, 0x02);
            L0068: AddEncounter(party, 0x1F, 0x03);
            L007A: AddEncounter(party, 0x1F, 0x04);
            L008C: AddEncounter(party, 0x20, 0x05);
            L009E: goto L0176;
            L00A1: ax = PartyCount(party);
            L00A9: compare(ax, 0x0003);
            L00AC: if (result.notequal) goto L010A;
            L00AE: AddEncounter(party, 0x1F, 0x01);
            L00C0: AddEncounter(party, 0x20, 0x02);
            L00D2: AddEncounter(party, 0x1F, 0x03);
            L00E4: AddEncounter(party, 0x20, 0x04);
            L00F6: AddEncounter(party, 0x1E, 0x05);
            L0108: goto L0176;
            L010A: AddEncounter(party, 0x20, 0x01);
            L011C: AddEncounter(party, 0x20, 0x02);
            L012E: AddEncounter(party, 0x1F, 0x03);
            L0140: AddEncounter(party, 0x1F, 0x04);
            L0152: AddEncounter(party, 0x1F, 0x05);
            L0164: AddEncounter(party, 0x1F, 0x06);
            L0176: // RETURN;
        }

        private override MapEventHandler MapEvent17 => FnGOLDAENC_17;
        private void FnGOLDAENC_17(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x02, 0x1F);
            L0014: compare(ax, 0x0001);
            L0017: if (result.notequal) goto L0048;
            L0019: AddTreasure(party, 0x0384, 0x00, 0x00, 0x00, 0xB6, 0xD0);
            L0039: ShowMessage(party, String094D); // You encounter Bugbears.
            L0046: goto L0089;
            L0048: AddTreasure(party, 0x0E10, 0x00, 0x00, 0x00, 0x00, 0xB7);
            L0067: SetState00(party, 0x02, 0x1F, 0x01);
            L007C: ShowMessage(party, String0965); // Bugbears stand near some gold.
            L0089: ax = PartyCount(party);
            L0091: compare(ax, 0x0001);
            L0094: if (result.notequal) goto L00AB;
            L0096: AddEncounter(party, 0x01, 0x01);
            L00A8: goto L016C;
            L00AB: ax = PartyCount(party);
            L00B3: compare(ax, 0x0002);
            L00B6: if (result.notequal) goto L00DF;
            L00B8: AddEncounter(party, 0x01, 0x01);
            L00CA: AddEncounter(party, 0x02, 0x02);
            L00DC: goto L016C;
            L00DF: ax = PartyCount(party);
            L00E7: compare(ax, 0x0003);
            L00EA: if (result.notequal) goto L0124;
            L00EC: AddEncounter(party, 0x01, 0x01);
            L00FE: AddEncounter(party, 0x02, 0x02);
            L0110: AddEncounter(party, 0x03, 0x03);
            L0122: goto L016C;
            L0124: AddEncounter(party, 0x02, 0x01);
            L0136: AddEncounter(party, 0x03, 0x02);
            L0148: AddEncounter(party, 0x03, 0x03);
            L015A: AddEncounter(party, 0x02, 0x04);
            L016C: // RETURN;
        }

        private override MapEventHandler MapEvent18 => FnGOLDBENC_18;
        private void FnGOLDBENC_18(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x02, 0x20);
            L0014: compare(ax, 0x0001);
            L0017: if (result.notequal) goto L0047;
            L0019: AddTreasure(party, 0x0320, 0x00, 0x00, 0x00, 0x00, 0xB7);
            L0038: ShowMessage(party, String0984); // Dire Wolves scratch the floor impatiently.
            L0045: goto L0088;
            L0047: AddTreasure(party, 0x0FA0, 0x00, 0x00, 0x00, 0x00, 0x8E);
            L0066: SetState00(party, 0x02, 0x20, 0x01);
            L007B: ShowMessage(party, String09AF); // A Dire Wolf plays with a coin purse.
            L0088: ax = PartyCount(party);
            L0090: compare(ax, 0x0001);
            L0093: if (result.equal) goto L00A2;
            L0095: ax = PartyCount(party);
            L009D: compare(ax, 0x0002);
            L00A0: if (result.notequal) goto L00C8;
            L00A2: AddEncounter(party, 0x0E, 0x01);
            L00B4: AddEncounter(party, 0x0E, 0x02);
            L00C6: goto L0110;
            L00C8: AddEncounter(party, 0x10, 0x01);
            L00DA: AddEncounter(party, 0x10, 0x02);
            L00EC: AddEncounter(party, 0x0E, 0x03);
            L00FE: AddEncounter(party, 0x0F, 0x04);
            L0110: // RETURN;
        }

        private override MapEventHandler MapEvent19 => FnGOLDCENC_19;
        private void FnGOLDCENC_19(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x02, 0x21);
            L0014: compare(ax, 0x0001);
            L0017: if (result.notequal) goto L0047;
            L0019: AddTreasure(party, 0x02EE, 0x00, 0x00, 0x00, 0x00, 0xD1);
            L0038: ShowMessage(party, String09D4); // You suddenly feel nervous.
            L0045: goto L0088;
            L0047: AddTreasure(party, 0x157C, 0x00, 0x00, 0x00, 0x00, 0xCC);
            L0066: SetState00(party, 0x02, 0x21, 0x01);
            L007B: ShowMessage(party, String09EF); // Hungry lions prowl the area.
            L0088: ax = PartyCount(party);
            L0090: compare(ax, 0x0001);
            L0093: if (result.equal) goto L00A2;
            L0095: ax = PartyCount(party);
            L009D: compare(ax, 0x0002);
            L00A0: if (result.notequal) goto L00C9;
            L00A2: AddEncounter(party, 0x13, 0x01);
            L00B4: AddEncounter(party, 0x14, 0x02);
            L00C6: goto L0156;
            L00C9: ax = PartyCount(party);
            L00D1: compare(ax, 0x0003);
            L00D4: if (result.notequal) goto L010E;
            L00D6: AddEncounter(party, 0x14, 0x01);
            L00E8: AddEncounter(party, 0x14, 0x02);
            L00FA: AddEncounter(party, 0x15, 0x03);
            L010C: goto L0156;
            L010E: AddEncounter(party, 0x15, 0x01);
            L0120: AddEncounter(party, 0x15, 0x02);
            L0132: AddEncounter(party, 0x16, 0x03);
            L0144: AddEncounter(party, 0x16, 0x04);
            L0156: // RETURN;
        }

        private override MapEventHandler MapEvent1A => FnITEMCENC_1A;
        private void FnITEMCENC_1A(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem50(party, 0xC6);
            L0011: if (result.equal) goto L0041;
            L0013: AddTreasure(party, 0x00FA, 0x00, 0x00, 0x00, 0x00, 0xCD);
            L0032: ShowMessage(party, String0A0C); // The floor crawls with Leeches.
            L003F: goto L006D;
            L0041: AddTreasure(party, 0x03E8, 0x00, 0x00, 0x00, 0x00, 0xC6);
            L0060: ShowMessage(party, String0A2B); // Leeches swarm over a magic wand.
            L006D: ax = PartyCount(party);
            L0075: compare(ax, 0x0001);
            L0078: if (result.notequal) goto L00A1;
            L007A: AddEncounter(party, 0x1B, 0x01);
            L008C: AddEncounter(party, 0x1B, 0x02);
            L009E: goto L0164;
            L00A1: ax = PartyCount(party);
            L00A9: compare(ax, 0x0002);
            L00AC: if (result.notequal) goto L00F8;
            L00AE: AddEncounter(party, 0x1C, 0x01);
            L00C0: AddEncounter(party, 0x1C, 0x02);
            L00D2: AddEncounter(party, 0x1B, 0x03);
            L00E4: AddEncounter(party, 0x1B, 0x04);
            L00F6: goto L0164;
            L00F8: AddEncounter(party, 0x16, 0x01);
            L010A: AddEncounter(party, 0x16, 0x02);
            L011C: AddEncounter(party, 0x1C, 0x03);
            L012E: AddEncounter(party, 0x1C, 0x04);
            L0140: AddEncounter(party, 0x1B, 0x05);
            L0152: AddEncounter(party, 0x1B, 0x06);
            L0164: // RETURN;
        }

        private override MapEventHandler MapEvent1B => FnITEMBENC_1B;
        private void FnITEMBENC_1B(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem50(party, 0x96);
            L0011: if (result.equal) goto L0040;
            L0013: AddTreasure(party, 0x0000, 0x00, 0x00, 0x00, 0x00, 0xCF);
            L0031: ShowMessage(party, String0A4C); // Giants interrupt your search.
            L003E: goto L006B;
            L0040: AddTreasure(party, 0x0000, 0x00, 0x00, 0x00, 0x00, 0x96);
            L005E: ShowMessage(party, String0A6A); // A Giant wears a medallion around his neck.
            L006B: ax = PartyCount(party);
            L0073: compare(ax, 0x0001);
            L0076: if (result.notequal) goto L008D;
            L0078: AddEncounter(party, 0x25, 0x01);
            L008A: goto L013E;
            L008D: ax = PartyCount(party);
            L0095: compare(ax, 0x0002);
            L0098: if (result.notequal) goto L00D2;
            L009A: AddEncounter(party, 0x25, 0x01);
            L00AC: AddEncounter(party, 0x26, 0x02);
            L00BE: AddEncounter(party, 0x25, 0x03);
            L00D0: goto L013E;
            L00D2: AddEncounter(party, 0x25, 0x01);
            L00E4: AddEncounter(party, 0x25, 0x02);
            L00F6: AddEncounter(party, 0x26, 0x03);
            L0108: AddEncounter(party, 0x26, 0x04);
            L011A: AddEncounter(party, 0x25, 0x05);
            L012C: AddEncounter(party, 0x26, 0x06);
            L013E: // RETURN;
        }

        private override MapEventHandler MapEvent1C => FnITEMCENC_1C;
        private void FnITEMCENC_1C(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem50(party, 0xD1);
            L0011: if (result.equal) goto L0041;
            L0013: AddTreasure(party, 0x012C, 0x00, 0x00, 0x00, 0x00, 0xB5);
            L0032: ShowMessage(party, String0A95); // You disturb a nest of Cockatrices.
            L003F: goto L006D;
            L0041: AddTreasure(party, 0x05DC, 0x00, 0x00, 0x00, 0x00, 0xD1);
            L0060: ShowMessage(party, String0AB8); // You see a vial in a Cockatrice nest.
            L006D: ax = PartyCount(party);
            L0075: compare(ax, 0x0001);
            L0078: if (result.equal) goto L0087;
            L007A: ax = PartyCount(party);
            L0082: compare(ax, 0x0002);
            L0085: if (result.notequal) goto L00AD;
            L0087: AddEncounter(party, 0x08, 0x01);
            L0099: AddEncounter(party, 0x07, 0x02);
            L00AB: goto L00F5;
            L00AD: AddEncounter(party, 0x09, 0x01);
            L00BF: AddEncounter(party, 0x09, 0x02);
            L00D1: AddEncounter(party, 0x0C, 0x05);
            L00E3: AddEncounter(party, 0x0A, 0x06);
            L00F5: // RETURN;
        }

        private override MapEventHandler MapEvent1D => FnWEAPAENC_1D;
        private void FnWEAPAENC_1D(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem50(party, 0x2A);
            L0011: if (result.equal) goto L0041;
            L0013: AddTreasure(party, 0x012C, 0x00, 0x00, 0x00, 0x00, 0xBD);
            L0032: ShowMessage(party, String0ADD); // Silver Ogres suddenly appear around you.
            L003F: goto L006D;
            L0041: AddTreasure(party, 0x07D0, 0x00, 0x00, 0x00, 0x00, 0x2A);
            L0060: ShowMessage(party, String0B06); // The lead Silver Ogre wields a powerful morningstar.
            L006D: ax = PartyCount(party);
            L0075: compare(ax, 0x0001);
            L0078: if (result.equal) goto L0087;
            L007A: ax = PartyCount(party);
            L0082: compare(ax, 0x0002);
            L0085: if (result.notequal) goto L00AE;
            L0087: AddEncounter(party, 0x21, 0x01);
            L0099: AddEncounter(party, 0x22, 0x02);
            L00AB: goto L013B;
            L00AE: ax = PartyCount(party);
            L00B6: compare(ax, 0x0003);
            L00B9: if (result.notequal) goto L00F3;
            L00BB: AddEncounter(party, 0x21, 0x01);
            L00CD: AddEncounter(party, 0x22, 0x02);
            L00DF: AddEncounter(party, 0x23, 0x03);
            L00F1: goto L013B;
            L00F3: AddEncounter(party, 0x21, 0x01);
            L0105: AddEncounter(party, 0x22, 0x02);
            L0117: AddEncounter(party, 0x23, 0x03);
            L0129: AddEncounter(party, 0x24, 0x04);
            L013B: // RETURN;
        }

        private override MapEventHandler MapEvent1E => FnWEAPBENC_1E;
        private void FnWEAPBENC_1E(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem50(party, 0x10);
            L0011: if (result.equal) goto L0041;
            L0013: AddTreasure(party, 0x012C, 0x00, 0x00, 0x00, 0x00, 0xCE);
            L0032: ShowMessage(party, String0B3A); // You disturb some sleeping Giants.
            L003F: goto L006D;
            L0041: AddTreasure(party, 0x03E8, 0x00, 0x00, 0x00, 0x00, 0x10);
            L0060: ShowMessage(party, String0B5C); // A gleaming sword lies on the floor between you and a group of Giants.
            L006D: ax = PartyCount(party);
            L0075: compare(ax, 0x0001);
            L0078: if (result.notequal) goto L008F;
            L007A: AddEncounter(party, 0x25, 0x01);
            L008C: goto L012E;
            L008F: ax = PartyCount(party);
            L0097: compare(ax, 0x0002);
            L009A: if (result.notequal) goto L00D4;
            L009C: AddEncounter(party, 0x25, 0x01);
            L00AE: AddEncounter(party, 0x26, 0x02);
            L00C0: AddEncounter(party, 0x21, 0x04);
            L00D2: goto L012E;
            L00D4: AddEncounter(party, 0x25, 0x01);
            L00E6: AddEncounter(party, 0x25, 0x02);
            L00F8: AddEncounter(party, 0x26, 0x03);
            L010A: AddEncounter(party, 0x26, 0x04);
            L011C: AddEncounter(party, 0x25, 0x05);
            L012E: // RETURN;
        }

        private override MapEventHandler MapEvent1F => FnARMRAENC_1F;
        private void FnARMRAENC_1F(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem50(party, 0x67);
            L0011: if (result.equal) goto L0041;
            L0013: AddTreasure(party, 0x01F4, 0x00, 0x00, 0x00, 0x00, 0xD0);
            L0032: ShowMessage(party, String0BA2); // Dark shadows coalesce into Bugbears.
            L003F: goto L006D;
            L0041: AddTreasure(party, 0x07D0, 0x00, 0x00, 0x00, 0x00, 0x67);
            L0060: ShowMessage(party, String0BC7); // A Bugbear guards some chainmail.
            L006D: ax = PartyCount(party);
            L0075: compare(ax, 0x0001);
            L0078: if (result.notequal) goto L00A1;
            L007A: AddEncounter(party, 0x01, 0x01);
            L008C: AddEncounter(party, 0x01, 0x02);
            L009E: goto L0164;
            L00A1: ax = PartyCount(party);
            L00A9: compare(ax, 0x0002);
            L00AC: if (result.notequal) goto L00F8;
            L00AE: AddEncounter(party, 0x02, 0x01);
            L00C0: AddEncounter(party, 0x02, 0x02);
            L00D2: AddEncounter(party, 0x03, 0x03);
            L00E4: AddEncounter(party, 0x03, 0x04);
            L00F6: goto L0164;
            L00F8: AddEncounter(party, 0x02, 0x01);
            L010A: AddEncounter(party, 0x03, 0x02);
            L011C: AddEncounter(party, 0x03, 0x03);
            L012E: AddEncounter(party, 0x02, 0x04);
            L0140: AddEncounter(party, 0x04, 0x05);
            L0152: AddEncounter(party, 0x05, 0x06);
            L0164: // RETURN;
        }

        private override MapEventHandler MapEvent20 => FnARMRBENC_20;
        private void FnARMRBENC_20(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem50(party, 0x7E);
            L0011: if (result.equal) goto L0042;
            L0013: AddTreasure(party, 0x0320, 0x00, 0x00, 0x00, 0xCF, 0xCD);
            L0033: ShowMessage(party, String0BE8); // You enter a roosting area for Cockatrices.
            L0040: goto L006E;
            L0042: AddTreasure(party, 0x0BB8, 0x00, 0x00, 0x00, 0x00, 0x7E);
            L0061: ShowMessage(party, String0C13); // In a Cockatrice nest you see luminous chainmail.
            L006E: ax = PartyCount(party);
            L0076: compare(ax, 0x0001);
            L0079: if (result.equal) goto L0088;
            L007B: ax = PartyCount(party);
            L0083: compare(ax, 0x0002);
            L0086: if (result.notequal) goto L00AF;
            L0088: AddEncounter(party, 0x08, 0x01);
            L009A: AddEncounter(party, 0x07, 0x02);
            L00AC: goto L013C;
            L00AF: ax = PartyCount(party);
            L00B7: compare(ax, 0x0003);
            L00BA: if (result.notequal) goto L00F4;
            L00BC: AddEncounter(party, 0x07, 0x01);
            L00CE: AddEncounter(party, 0x08, 0x02);
            L00E0: AddEncounter(party, 0x09, 0x05);
            L00F2: goto L013C;
            L00F4: AddEncounter(party, 0x08, 0x01);
            L0106: AddEncounter(party, 0x09, 0x02);
            L0118: AddEncounter(party, 0x0A, 0x05);
            L012A: AddEncounter(party, 0x0A, 0x06);
            L013C: // RETURN;
        }

        private override MapEventHandler MapEvent21 => FnSHLDAENC_21;
        private void FnSHLDAENC_21(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem50(party, 0x59);
            L0011: if (result.equal) goto L0041;
            L0013: AddTreasure(party, 0x0064, 0x00, 0x00, 0x00, 0x00, 0xC0);
            L0032: ShowMessage(party, String0C44); // Dire Wolves encircle you.
            L003F: goto L006D;
            L0041: AddTreasure(party, 0x03E8, 0x00, 0x00, 0x00, 0x00, 0x59);
            L0060: ShowMessage(party, String0C5E); // Dire Wolves seem fascinated by a shiny shield.
            L006D: ax = PartyCount(party);
            L0075: compare(ax, 0x0001);
            L0078: if (result.equal) goto L0087;
            L007A: ax = PartyCount(party);
            L0082: compare(ax, 0x0002);
            L0085: if (result.notequal) goto L00BF;
            L0087: AddEncounter(party, 0x0E, 0x01);
            L0099: AddEncounter(party, 0x0D, 0x02);
            L00AB: AddEncounter(party, 0x0F, 0x03);
            L00BD: goto L0119;
            L00BF: AddEncounter(party, 0x0F, 0x01);
            L00D1: AddEncounter(party, 0x10, 0x02);
            L00E3: AddEncounter(party, 0x10, 0x03);
            L00F5: AddEncounter(party, 0x0F, 0x04);
            L0107: AddEncounter(party, 0x11, 0x05);
            L0119: // RETURN;
        }

        private override MapEventHandler MapEvent22 => FnSLDBENC_22;
        private void FnSLDBENC_22(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem50(party, 0x81);
            L0011: if (result.equal) goto L0041;
            L0013: AddTreasure(party, 0x00C8, 0x00, 0x00, 0x00, 0x00, 0xC5);
            L0032: ShowMessage(party, String0C8D); // Loud hisses alert you to danger.
            L003F: goto L006D;
            L0041: AddTreasure(party, 0x0384, 0x00, 0x00, 0x00, 0x00, 0x81);
            L0060: ShowMessage(party, String0CAE); // Lizardites move between you and a piece of armor on the floor.
            L006D: ax = PartyCount(party);
            L0075: compare(ax, 0x0001);
            L0078: if (result.equal) goto L0087;
            L007A: ax = PartyCount(party);
            L0082: compare(ax, 0x0002);
            L0085: if (result.notequal) goto L00AD;
            L0087: AddEncounter(party, 0x27, 0x01);
            L0099: AddEncounter(party, 0x28, 0x02);
            L00AB: goto L00F5;
            L00AD: AddEncounter(party, 0x27, 0x01);
            L00BF: AddEncounter(party, 0x27, 0x02);
            L00D1: AddEncounter(party, 0x28, 0x03);
            L00E3: AddEncounter(party, 0x28, 0x04);
            L00F5: // RETURN;
        }

        private override MapEventHandler MapEvent23 => FnKINGDOOR_23;
        private void FnKINGDOOR_23(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem50(party, 0xF8);
            L0011: if (result.equal) goto L005E;
            L0013: ShowMessage(party, String0CED); // The door is unlocked.
            L0020: ax = GetFacing24(party);
            L0027: PushStack(ax);
            L0028: ax = GetNextTile20(party);
            L002F: PushStack(ax);
            L0030: Push(01);
            L0034: SetUnblocked30(party);
            L003E: Push(01);
            L0042: ax = GetFacing24(party);
            L0049: PushStack(ax);
            L004A: ax = GetNextTile20(party);
            L0051: PushStack(ax);
            L0052: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L005C: goto L0088;
            L005E: PushStack(0x00);
            L0061: ax = GetFacing24(party);
            L0068: PushStack(ax);
            L0069: ax = GetNextTile20(party);
            L0070: PushStack(ax);
            L0071: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L007B: ShowMessage(party, String0D03); // The door is sealed shut. You see what appears to be the bas relief of a royal ring 
            L0088: // RETURN;
        }

        private override MapEventHandler MapEvent24 => FnSTRGATEM_24;
        private void FnSTRGATEM_24(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0D57); // The stairs through the north gateway lead up. The gateway to the east leads to THE GREAT CORRIDOR.
            L0010: // RETURN;
        }

        private override MapEventHandler MapEvent25 => FnSTRSMESS_25;
        private void FnSTRSMESS_25(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0DBA); // The stairs past the south gateway lead up a level.
            L0010: // RETURN;
        }

        private override MapEventHandler MapEvent26 => FnSTRSMESS_26;
        private void FnSTRSMESS_26(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0DED); // There are stairs through the the north gateway.
            L0010: // RETURN;
        }

        private override MapEventHandler MapEvent27 => FnSTRSMESS_27;
        private void FnSTRSMESS_27(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0E1D); // There are stairs beyond the west gateway.
            L0010: // RETURN;
        }

        private override MapEventHandler MapEvent29 => FnNPCCHATA_29;
        private void FnNPCCHATA_29(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0E47); // You encounter a Human Barbarian.
            L0010: ShowPortrait(party, 0x0016);
            L001D: ax = UnknownFunctionEC(party, 0x000F);
            L002A: compare(ax, 0x000C);
            L002D: if (result.unsigned_greater_than) goto L004B;
            L002F: ShowMessage(party, String0E68); // The opening and closing of secret doors in this area give me a headache. I simply cannot puzzle out the correct sequence of opening the doors. I wish my map of this area were more complete.
            L003C: ShowMessage(party, String0F26); // By the way, if you don't have the king's ring, you won't get anywhere in this crazy place.
            L0049: goto L0058;
            L004B: ShowMessage(party, String0F81); // The Human Barbarian pays you no attention as he puzzles over a map.
            L0058: // RETURN;
        }

        private override MapEventHandler MapEvent2A => FnNPCCHATB_2A;
        private void FnNPCCHATB_2A(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0FC5); // You encounter a Gnome Wizard.
            L0010: ShowPortrait(party, 0x002D);
            L001D: ax = UnknownFunctionEC(party, 0x000F);
            L002A: compare(ax, 0x000A);
            L002D: if (result.unsigned_greater_than) goto L003E;
            L002F: ShowMessage(party, String0FE3); // Once you find a key in this area, seek the hidden door and follow your destiny. The door appears only when you have the right key. Where it leads I do not know.
            L003C: goto L004B;
            L003E: ShowMessage(party, String1084); // The Gnome Wizard is too intent on drawing runes in the dust to talk to you.
            L004B: // RETURN;
        }

        private override MapEventHandler MapEvent2B => FnNPCCHATC_2B;
        private void FnNPCCHATC_2B(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String10D0); // You encounter an Orc Knight.
            L0010: ShowPortrait(party, 0x001A);
            L001D: ax = UnknownFunctionEC(party, 0x000F);
            L002A: compare(ax, 0x0009);
            L002D: if (result.unsigned_greater_than) goto L003E;
            L002F: ShowMessage(party, String10ED); // There are many ways into King Cleowyn's Mausoleum, but few are rewarding. The most direct ways are the most challenging. Do not continue unless you have what the king demands.
            L003C: goto L004B;
            L003E: ShowMessage(party, String119D); // The Orc Knight dismisses you as low-level buffoons.
            L004B: // RETURN;
        }

        private override MapEventHandler MapEvent2C => FnNPCCHATD_2C;
        private void FnNPCCHATD_2C(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String11D1); // You encounter a Halfling Thief.
            L0010: ShowPortrait(party, 0x0025);
            L001D: ax = UnknownFunctionEC(party, 0x000F);
            L002A: compare(ax, 0x0008);
            L002D: if (result.unsigned_greater_than) goto L003E;
            L002F: ShowMessage(party, String11F1); // Beneath the king's living quarters is an area known as the Thieves' Maze. Only an experienced thief - or a hero who has a thief's skills - will pick his way through this intricate maze.
            L003C: goto L005D;
            L003E: ShowMessage(party, String12AB); // The Halfling Thief steals some gold and runs away.
            L004B: ModifyGold(party, 0xFFFFCEBA);
            L005D: // RETURN;
        }

    }
}
