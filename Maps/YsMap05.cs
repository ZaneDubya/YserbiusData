namespace ZCF.Scripts.Maps {
    class YserMap05 : ACanoMapScript {
        // === Strings ================================================
        private const string String03FC = "You successfully picked the locked door.";
        private const string String0425 = "The door is locked.";
        private const string String0439 = "Dire Wolves prowl the area.";
        private const string String0455 = "A Dire Wolf holds something in its mouth.";
        private const string String047F = "Copper Ogres are huddled around a small fire.";
        private const string String04AD = "Copper Ogres are counting gold they have stolen.";
        private const string String04DE = "This room is the lair of Mountain Lions.";
        private const string String0507 = "Mountain Lions chew on a small bag.";
        private const string String052B = "You hear the angry snapping of pincers.";
        private const string String0553 = "As you step forward to pick up some gold on the floor...";
        private const string String058C = "Imps spring an ambush on you.";
        private const string String05AA = "You see gold on the floor and something hiding in the shadows.";
        private const string String05E9 = "You turn as you hear bones rattling.";
        private const string String060E = "A skeleton has a coin bag tied to its belt.";
        private const string String063A = "You stumble upon an almost empty nesting area.";
        private const string String0669 = "Angry hissing distracts you as you reach down for some gold coins.";
        private const string String06AC = "You encounter Rogues.";
        private const string String06C2 = "The rooms in the center of this area once housed the king's soldiers.";
        private const string String0708 = "The Rogues laugh at you and attack.";
        private const string String072C = "You are waylaid by Rogues.";
        private const string String0747 = "You surprise some Rogues.";
        private const string String0761 = "You successfully picked the locked door.";
        private const string String078A = "The door is locked.";
        private const string String079E = "The gateway leads to THE DUNGEON ENTRANCE.";
        private const string String07C9 = "There is a sign on the east door - STAY OUT!";
        private const string String07F6 = "Through the gateway you see stairs leading downwards.The stairs are rather long, at least 2 levels.";
        private const string String085A = "There is a teleport in the south wall.";
        private const string String0881 = "There is a teleport in the north wall.";
        private const string String08A8 = "Through the north gateway you see stairs leading down to the next level.";
        private const string String08F1 = "You encounter a Human Barbarian.";
        private const string String0912 = "This area is called the Soldiers' Quarters. Why it is so named is beyond me. I've wandered these halls for weeks and have found nothing resembling living quarters, much less any soldiers.";
        private const string String09CE = "The Human Barbarian is trying to count his fingers and so neglects to answer.";
        private const string String0A1C = "You encounter a Gremlin Wizard.";
        private const string String0A3C = "The volcano Yserbius roils the sea and makes it unnavigable. We are doomed to live out our miserable lives, unknown to other peoples. I would give my left eyetooth for a way to escape this dull island.";
        private const string String0B06 = "The Gremlin Wizards squeals in terror and flees.";
        private const string String0B37 = "You encounter a Troll Ranger.";
        private const string String0B55 = "Unless you have especially sharp eyes for traps, you should heed the sign at the end of the corridor. This bum leg of mine is proof of that sign's warning.";
        private const string String0BF1 = "The Troll Ranger snarls a curse at you and limps away.";
        private const string String0C28 = "You encounter an Elf Cleric.";
        private const string String0C45 = "You may think you are limited only to those skills you acquire through your Guild. I know there are places in this dungeon where you may acquire new and different skills.";
        private const string String0CF0 = "The Elf Cleric gives you gold to leave him in peace.";
        private const string String0D25 = "You encounter a Troll Knight.";
        private const string String0D43 = "Under Cleowyn's palace is a strange maze. The maze is infested with thieves, and they seem to be the only ones who know how to get through the thing.";
        private const string String0DD9 = "The Troll Knight is lost in thought and does not hear you.";
        private const string String0E14 = "You encounter an Orc Barbarian.";
        private const string String0E34 = "A dwarf knight told me he encountered polar bears and ice lions deep in the dungeon. Whoever heard of polar bears and ice lions living inside an active volcano?";
        private const string String0ED5 = "The Orc Barbarian watches you impassively, refusing to talk.";
        
        // === Functions ================================================
        private override MapEventHandler MapEvent01 => TOEXIT_01;
        private void TOEXIT_01(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetMoveMap(party, 0x03, 0x85, 0x01, 0x01);
            L001E: // RETURN;
        }

        private override MapEventHandler MapEvent02 => TOTREAS_02;
        private void TOTREAS_02(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetMoveMap(party, 0x02, 0xA0, 0x05, 0x01);
            L001E: // RETURN;
        }

        private override MapEventHandler MapEvent03 => STAIRSD_03;
        private void STAIRSD_03(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetMoveMap(party, 0x02, 0x81, 0x01, 0x02);
            L001E: // RETURN;
        }

        private override MapEventHandler MapEvent04 => TELPORTS_04;
        private void TELPORTS_04(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetMoveMap(party, 0x01, 0xCD, 0x06, 0x01);
            L001E: // RETURN;
        }

        private override MapEventHandler MapEvent05 => TELPORTN_05;
        private void TELPORTN_05(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetMoveMap(party, 0x01, 0x3C, 0x06, 0x01);
            L001E: // RETURN;
        }

        private override MapEventHandler MapEvent06 => TELEPORT_06;
        private void TELEPORT_06(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetMoveMap(party, 0x02, 0xCA, 0x02, 0x03);
            L001E: // RETURN;
        }

        private override MapEventHandler MapEvent07 => TELPORTW_07;
        private void TELPORTW_07(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetMoveMap(party, 0x01, 0x77, 0x06, 0x01);
            L001E: // RETURN;
        }

        private override MapEventHandler MapEvent08 => TELPORTE_08;
        private void TELPORTE_08(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetMoveMap(party, 0x03, 0x9E, 0x06, 0x01);
            L001E: // RETURN;
        }

        private override MapEventHandler MapEvent09 => LKPKDOOR_09;
        private void LKPKDOOR_09(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = UsedItem54(party, 0xC0, 0xC4);
            L0016: if (result.notequal) goto L0029;
            L0018: ax = UsedSkill58(party, 0x0E) // returns 0 if did not use, compares to 2nd op if did use;
            L0024: compare(ax, 0x0005);
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
            L0065: ShowMessage(party, String03FC); // You successfully picked the locked door.
            L0072: goto L009E;
            L0074: PushStack(0x00);
            L0077: ax = GetFacing24(party);
            L007E: PushStack(ax);
            L007F: ax = GetNextTile20(party);
            L0086: PushStack(ax);
            L0087: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L0091: ShowMessage(party, String0425); // The door is locked.
            L009E: // RETURN;
        }

        private override MapEventHandler MapEvent0A => ITEMCENC_0A;
        private void ITEMCENC_0A(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem50(party, 0x27);
            L0011: if (result.equal) goto L0041;
            L0013: ShowMessage(party, String0439); // Dire Wolves prowl the area.
            L0020: AddTreasure(party, 0x01F4, 0x00, 0x00, 0x00, 0x00, 0xB5);
            L003F: goto L006D;
            L0041: AddTreasure(party, 0x03E8, 0x00, 0x00, 0x00, 0x00, 0x27);
            L0060: ShowMessage(party, String0455); // A Dire Wolf holds something in its mouth.
            L006D: ax = PartyCount(party);
            L0075: compare(ax, 0x0001);
            L0078: if (result.equal) goto L0087;
            L007A: ax = PartyCount(party);
            L0082: compare(ax, 0x0002);
            L0085: if (result.notequal) goto L009B;
            L0087: AddEncounter(party, 0x27, 0x01);
            L0099: goto L00D1;
            L009B: AddEncounter(party, 0x27, 0x01);
            L00AD: AddEncounter(party, 0x27, 0x02);
            L00BF: AddEncounter(party, 0x28, 0x03);
            L00D1: // RETURN;
        }

        private override MapEventHandler MapEvent0B => GOLDAENC_0B;
        private void GOLDAENC_0B(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x02, 0x0C);
            L0014: compare(ax, 0x0001);
            L0017: if (result.notequal) goto L0048;
            L0019: ShowMessage(party, String047F); // Copper Ogres are huddled around a small fire.
            L0026: AddTreasure(party, 0x0032, 0x00, 0x00, 0x00, 0xB5, 0x12);
            L0046: goto L0089;
            L0048: AddTreasure(party, 0x07D0, 0x00, 0x00, 0x00, 0x00, 0xB5);
            L0067: ShowMessage(party, String04AD); // Copper Ogres are counting gold they have stolen.
            L0074: SetState00(party, 0x02, 0x0C, 0x01);
            L0089: ax = PartyCount(party);
            L0091: compare(ax, 0x0001);
            L0094: if (result.notequal) goto L00AB;
            L0096: AddEncounter(party, 0x1A, 0x01);
            L00A8: goto L016C;
            L00AB: ax = PartyCount(party);
            L00B3: compare(ax, 0x0002);
            L00B6: if (result.notequal) goto L00DF;
            L00B8: AddEncounter(party, 0x19, 0x01);
            L00CA: AddEncounter(party, 0x1A, 0x02);
            L00DC: goto L016C;
            L00DF: ax = PartyCount(party);
            L00E7: compare(ax, 0x0003);
            L00EA: if (result.notequal) goto L0124;
            L00EC: AddEncounter(party, 0x1A, 0x01);
            L00FE: AddEncounter(party, 0x19, 0x02);
            L0110: AddEncounter(party, 0x1A, 0x03);
            L0122: goto L016C;
            L0124: AddEncounter(party, 0x1B, 0x01);
            L0136: AddEncounter(party, 0x1A, 0x02);
            L0148: AddEncounter(party, 0x19, 0x03);
            L015A: AddEncounter(party, 0x1A, 0x04);
            L016C: // RETURN;
        }

        private override MapEventHandler MapEvent0C => GOLDBENC_0C;
        private void GOLDBENC_0C(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x02, 0x0D);
            L0014: compare(ax, 0x0001);
            L0017: if (result.notequal) goto L0047;
            L0019: ShowMessage(party, String04DE); // This room is the lair of Mountain Lions.
            L0026: AddTreasure(party, 0x0000, 0x00, 0x00, 0x00, 0xCB, 0x35);
            L0045: goto L0088;
            L0047: AddTreasure(party, 0x01F4, 0x00, 0x00, 0x00, 0x00, 0xB5);
            L0066: ShowMessage(party, String0507); // Mountain Lions chew on a small bag.
            L0073: SetState00(party, 0x02, 0x0D, 0x01);
            L0088: ax = PartyCount(party);
            L0090: compare(ax, 0x0001);
            L0093: if (result.notequal) goto L00AA;
            L0095: AddEncounter(party, 0x1C, 0x01);
            L00A7: goto L018F;
            L00AA: ax = PartyCount(party);
            L00B2: compare(ax, 0x0002);
            L00B5: if (result.notequal) goto L00DE;
            L00B7: AddEncounter(party, 0x1C, 0x01);
            L00C9: AddEncounter(party, 0x1C, 0x02);
            L00DB: goto L018F;
            L00DE: ax = PartyCount(party);
            L00E6: compare(ax, 0x0003);
            L00E9: if (result.notequal) goto L0135;
            L00EB: AddEncounter(party, 0x1C, 0x01);
            L00FD: AddEncounter(party, 0x1C, 0x02);
            L010F: AddEncounter(party, 0x1C, 0x03);
            L0121: AddEncounter(party, 0x1C, 0x04);
            L0133: goto L018F;
            L0135: AddEncounter(party, 0x1C, 0x01);
            L0147: AddEncounter(party, 0x1C, 0x02);
            L0159: AddEncounter(party, 0x1C, 0x03);
            L016B: AddEncounter(party, 0x1C, 0x04);
            L017D: AddEncounter(party, 0x1C, 0x05);
            L018F: // RETURN;
        }

        private override MapEventHandler MapEvent0D => GOLDCENC_0D;
        private void GOLDCENC_0D(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x02, 0x0E);
            L0014: compare(ax, 0x0001);
            L0017: if (result.notequal) goto L0047;
            L0019: ShowMessage(party, String052B); // You hear the angry snapping of pincers.
            L0026: AddTreasure(party, 0x0032, 0x00, 0x00, 0x00, 0x00, 0xCB);
            L0045: goto L0088;
            L0047: AddTreasure(party, 0x02EE, 0x00, 0x00, 0x00, 0x00, 0xCE);
            L0066: ShowMessage(party, String0553); // As you step forward to pick up some gold on the floor...
            L0073: SetState00(party, 0x02, 0x0E, 0x01);
            L0088: ax = PartyCount(party);
            L0090: compare(ax, 0x0001);
            L0093: if (result.notequal) goto L00A9;
            L0095: AddEncounter(party, 0x09, 0x01);
            L00A7: goto L0124;
            L00A9: ax = PartyCount(party);
            L00B1: compare(ax, 0x0002);
            L00B4: if (result.notequal) goto L00DC;
            L00B6: AddEncounter(party, 0x08, 0x01);
            L00C8: AddEncounter(party, 0x09, 0x02);
            L00DA: goto L0124;
            L00DC: AddEncounter(party, 0x08, 0x01);
            L00EE: AddEncounter(party, 0x08, 0x02);
            L0100: AddEncounter(party, 0x09, 0x03);
            L0112: AddEncounter(party, 0x09, 0x04);
            L0124: // RETURN;
        }

        private override MapEventHandler MapEvent0E => GOLDDENC_0E;
        private void GOLDDENC_0E(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x02, 0x0F);
            L0014: compare(ax, 0x0001);
            L0017: if (result.notequal) goto L0047;
            L0019: ShowMessage(party, String058C); // Imps spring an ambush on you.
            L0026: AddTreasure(party, 0x0014, 0x00, 0x00, 0x00, 0x00, 0xB5);
            L0045: goto L0088;
            L0047: AddTreasure(party, 0x04B0, 0x00, 0x00, 0x00, 0x00, 0xCE);
            L0066: ShowMessage(party, String05AA); // You see gold on the floor and something hiding in the shadows.
            L0073: SetState00(party, 0x02, 0x0F, 0x01);
            L0088: ax = PartyCount(party);
            L0090: compare(ax, 0x0001);
            L0093: if (result.notequal) goto L00BC;
            L0095: AddEncounter(party, 0x12, 0x01);
            L00A7: AddEncounter(party, 0x12, 0x02);
            L00B9: goto L017A;
            L00BC: ax = PartyCount(party);
            L00C4: compare(ax, 0x0002);
            L00C7: if (result.equal) goto L00D6;
            L00C9: ax = PartyCount(party);
            L00D1: compare(ax, 0x0003);
            L00D4: if (result.notequal) goto L0120;
            L00D6: AddEncounter(party, 0x11, 0x01);
            L00E8: AddEncounter(party, 0x11, 0x02);
            L00FA: AddEncounter(party, 0x12, 0x03);
            L010C: AddEncounter(party, 0x12, 0x04);
            L011E: goto L017A;
            L0120: AddEncounter(party, 0x12, 0x01);
            L0132: AddEncounter(party, 0x12, 0x02);
            L0144: AddEncounter(party, 0x11, 0x03);
            L0156: AddEncounter(party, 0x11, 0x05);
            L0168: AddEncounter(party, 0x11, 0x06);
            L017A: // RETURN;
        }

        private override MapEventHandler MapEvent0F => GOLDEENC_0F;
        private void GOLDEENC_0F(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x02, 0x10);
            L0014: compare(ax, 0x0001);
            L0017: if (result.notequal) goto L0047;
            L0019: ShowMessage(party, String05E9); // You turn as you hear bones rattling.
            L0026: AddTreasure(party, 0x0050, 0x00, 0x00, 0x00, 0x00, 0xB5);
            L0045: goto L0088;
            L0047: AddTreasure(party, 0x0FA0, 0x00, 0x00, 0x00, 0x00, 0xD1);
            L0066: ShowMessage(party, String060E); // A skeleton has a coin bag tied to its belt.
            L0073: SetState00(party, 0x02, 0x10, 0x01);
            L0088: ax = PartyCount(party);
            L0090: compare(ax, 0x0001);
            L0093: if (result.notequal) goto L00BC;
            L0095: AddEncounter(party, 0x15, 0x01);
            L00A7: AddEncounter(party, 0x15, 0x02);
            L00B9: goto L01B3;
            L00BC: ax = PartyCount(party);
            L00C4: compare(ax, 0x0002);
            L00C7: if (result.notequal) goto L0102;
            L00C9: AddEncounter(party, 0x15, 0x01);
            L00DB: AddEncounter(party, 0x15, 0x02);
            L00ED: AddEncounter(party, 0x15, 0x03);
            L00FF: goto L01B3;
            L0102: ax = PartyCount(party);
            L010A: compare(ax, 0x0003);
            L010D: if (result.notequal) goto L0159;
            L010F: AddEncounter(party, 0x15, 0x01);
            L0121: AddEncounter(party, 0x15, 0x02);
            L0133: AddEncounter(party, 0x15, 0x03);
            L0145: AddEncounter(party, 0x15, 0x04);
            L0157: goto L01B3;
            L0159: AddEncounter(party, 0x15, 0x01);
            L016B: AddEncounter(party, 0x15, 0x02);
            L017D: AddEncounter(party, 0x15, 0x03);
            L018F: AddEncounter(party, 0x15, 0x04);
            L01A1: AddEncounter(party, 0x15, 0x05);
            L01B3: // RETURN;
        }

        private override MapEventHandler MapEvent10 => GOLDFENC_10;
        private void GOLDFENC_10(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x02, 0x11);
            L0014: compare(ax, 0x0001);
            L0017: if (result.notequal) goto L0047;
            L0019: ShowMessage(party, String063A); // You stumble upon an almost empty nesting area.
            L0026: AddTreasure(party, 0x0000, 0x00, 0x00, 0x00, 0x00, 0xCB);
            L0044: goto L0122;
            L0047: AddTreasure(party, 0x05DC, 0x00, 0x00, 0x00, 0x00, 0xCB);
            L0066: ShowMessage(party, String0669); // Angry hissing distracts you as you reach down for some gold coins.
            L0073: SetState00(party, 0x02, 0x11, 0x01);
            L0088: ax = PartyCount(party);
            L0090: compare(ax, 0x0001);
            L0093: if (result.equal) goto L00A2;
            L0095: ax = PartyCount(party);
            L009D: compare(ax, 0x0002);
            L00A0: if (result.notequal) goto L00C8;
            L00A2: AddEncounter(party, 0x07, 0x01);
            L00B4: AddEncounter(party, 0x06, 0x02);
            L00C6: goto L0122;
            L00C8: AddEncounter(party, 0x06, 0x01);
            L00DA: AddEncounter(party, 0x06, 0x02);
            L00EC: AddEncounter(party, 0x07, 0x03);
            L00FE: AddEncounter(party, 0x07, 0x04);
            L0110: AddEncounter(party, 0x06, 0x05);
            L0122: // RETURN;
        }

        private override MapEventHandler MapEvent13 => TUFMNSTR_13;
        private void TUFMNSTR_13(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String06AC); // You encounter Rogues.
            L0010: ax = UnknownFunctionEC(party, 0x000F);
            L001D: compare(ax, 0x0002);
            L0020: if (result.unsigned_greater_than) goto L0031;
            L0022: ShowMessage(party, String06C2); // The rooms in the center of this area once housed the king's soldiers.
            L002F: goto L003E;
            L0031: ShowMessage(party, String0708); // The Rogues laugh at you and attack.
            L003E: ax = PartyCount(party);
            L0046: compare(ax, 0x0001);
            L0049: if (result.equal) goto L0058;
            L004B: ax = PartyCount(party);
            L0053: compare(ax, 0x0002);
            L0056: if (result.notequal) goto L007F;
            L0058: AddEncounter(party, 0x1F, 0x01);
            L006A: AddEncounter(party, 0x20, 0x02);
            L007C: goto L0142;
            L007F: ax = PartyCount(party);
            L0087: compare(ax, 0x0003);
            L008A: if (result.notequal) goto L00D6;
            L008C: AddEncounter(party, 0x1F, 0x01);
            L009E: AddEncounter(party, 0x1F, 0x02);
            L00B0: AddEncounter(party, 0x20, 0x05);
            L00C2: AddEncounter(party, 0x21, 0x06);
            L00D4: goto L0142;
            L00D6: AddEncounter(party, 0x1F, 0x01);
            L00E8: AddEncounter(party, 0x1F, 0x02);
            L00FA: AddEncounter(party, 0x20, 0x03);
            L010C: AddEncounter(party, 0x20, 0x04);
            L011E: AddEncounter(party, 0x21, 0x05);
            L0130: AddEncounter(party, 0x21, 0x05);
            L0142: // RETURN;
        }

        private override MapEventHandler MapEvent15 => ITEMAENC_15;
        private void ITEMAENC_15(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem50(party, 0x03);
            L0011: if (result.equal) goto L0065;
            L0013: ax = HasItem50(party, 0x4F);
            L0021: if (result.equal) goto L0044;
            L0023: AddTreasure(party, 0x0064, 0x00, 0x00, 0x00, 0x00, 0xCE);
            L0042: goto L0063;
            L0044: AddTreasure(party, 0x03E8, 0x00, 0x00, 0x00, 0x00, 0x4F);
            L0063: goto L00B6;
            L0065: ax = HasItem50(party, 0x4F);
            L0073: if (result.equal) goto L0096;
            L0075: AddTreasure(party, 0x03E8, 0x00, 0x00, 0x00, 0x00, 0x04);
            L0094: goto L00B6;
            L0096: AddTreasure(party, 0x03E8, 0x00, 0x00, 0x00, 0x4F, 0x04);
            L00B6: ShowMessage(party, String072C); // You are waylaid by Rogues.
            L00C3: ax = PartyCount(party);
            L00CB: compare(ax, 0x0001);
            L00CE: if (result.notequal) goto L00E5;
            L00D0: AddEncounter(party, 0x1F, 0x01);
            L00E2: goto L01A6;
            L00E5: ax = PartyCount(party);
            L00ED: compare(ax, 0x0002);
            L00F0: if (result.notequal) goto L0119;
            L00F2: AddEncounter(party, 0x20, 0x01);
            L0104: AddEncounter(party, 0x21, 0x02);
            L0116: goto L01A6;
            L0119: ax = PartyCount(party);
            L0121: compare(ax, 0x0003);
            L0124: if (result.notequal) goto L015E;
            L0126: AddEncounter(party, 0x1F, 0x01);
            L0138: AddEncounter(party, 0x20, 0x02);
            L014A: AddEncounter(party, 0x21, 0x03);
            L015C: goto L01A6;
            L015E: AddEncounter(party, 0x1F, 0x01);
            L0170: AddEncounter(party, 0x1F, 0x02);
            L0182: AddEncounter(party, 0x20, 0x03);
            L0194: AddEncounter(party, 0x21, 0x05);
            L01A6: // RETURN;
        }

        private override MapEventHandler MapEvent16 => ITEMBENC_16;
        private void ITEMBENC_16(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem50(party, 0x0F);
            L0011: if (result.equal) goto L0066;
            L0013: ax = HasItem50(party, 0x7B);
            L0021: if (result.equal) goto L0045;
            L0023: AddTreasure(party, 0x0064, 0x00, 0x00, 0x00, 0xCE, 0xCC);
            L0043: goto L0064;
            L0045: AddTreasure(party, 0x03E8, 0x00, 0x00, 0x00, 0x00, 0x7B);
            L0064: goto L00B7;
            L0066: ax = HasItem50(party, 0x7B);
            L0074: if (result.equal) goto L0097;
            L0076: AddTreasure(party, 0x03E8, 0x00, 0x00, 0x00, 0x00, 0x0F);
            L0095: goto L00B7;
            L0097: AddTreasure(party, 0x03E8, 0x00, 0x00, 0x00, 0x7B, 0x0F);
            L00B7: ShowMessage(party, String0747); // You surprise some Rogues.
            L00C4: ax = PartyCount(party);
            L00CC: compare(ax, 0x0001);
            L00CF: if (result.notequal) goto L00E6;
            L00D1: AddEncounter(party, 0x23, 0x01);
            L00E3: goto L01CB;
            L00E6: ax = PartyCount(party);
            L00EE: compare(ax, 0x0002);
            L00F1: if (result.notequal) goto L011A;
            L00F3: AddEncounter(party, 0x22, 0x01);
            L0105: AddEncounter(party, 0x23, 0x02);
            L0117: goto L01CB;
            L011A: ax = PartyCount(party);
            L0122: compare(ax, 0x0003);
            L0125: if (result.notequal) goto L0171;
            L0127: AddEncounter(party, 0x22, 0x01);
            L0139: AddEncounter(party, 0x22, 0x02);
            L014B: AddEncounter(party, 0x23, 0x03);
            L015D: AddEncounter(party, 0x23, 0x04);
            L016F: goto L01CB;
            L0171: AddEncounter(party, 0x23, 0x01);
            L0183: AddEncounter(party, 0x23, 0x02);
            L0195: AddEncounter(party, 0x23, 0x03);
            L01A7: AddEncounter(party, 0x22, 0x04);
            L01B9: AddEncounter(party, 0x21, 0x05);
            L01CB: // RETURN;
        }

        private override MapEventHandler MapEvent18 => LKPKDOOR_18;
        private void LKPKDOOR_18(Party party) {
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
            L0065: ShowMessage(party, String0761); // You successfully picked the locked door.
            L0072: goto L009E;
            L0074: PushStack(0x00);
            L0077: ax = GetFacing24(party);
            L007E: PushStack(ax);
            L007F: ax = GetNextTile20(party);
            L0086: PushStack(ax);
            L0087: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L0091: ShowMessage(party, String078A); // The door is locked.
            L009E: // RETURN;
        }

        private override MapEventHandler MapEvent19 => GATEMESA_19;
        private void GATEMESA_19(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String079E); // The gateway leads to THE DUNGEON ENTRANCE.
            L0010: // RETURN;
        }

        private override MapEventHandler MapEvent1A => GATEMESB_1A;
        private void GATEMESB_1A(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String07C9); // There is a sign on the east door - STAY OUT!
            L0010: // RETURN;
        }

        private override MapEventHandler MapEvent1F => TELEMESC_1F;
        private void TELEMESC_1F(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String07F6); // Through the gateway you see stairs leading downwards.The stairs are rather long, at least 2 levels.
            L0010: // RETURN;
        }

        private override MapEventHandler MapEvent20 => TELEMESD_20;
        private void TELEMESD_20(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String085A); // There is a teleport in the south wall.
            L0010: // RETURN;
        }

        private override MapEventHandler MapEvent21 => TELEMESE_21;
        private void TELEMESE_21(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0881); // There is a teleport in the north wall.
            L0010: // RETURN;
        }

        private override MapEventHandler MapEvent22 => STRSMESB_22;
        private void STRSMESB_22(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String08A8); // Through the north gateway you see stairs leading down to the next level.
            L0010: // RETURN;
        }

        private override MapEventHandler MapEvent23 => NPCCHATA_23;
        private void NPCCHATA_23(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(party, 0x0016);
            L0010: ShowMessage(party, String08F1); // You encounter a Human Barbarian.
            L001D: ax = UnknownFunctionEC(party, 0x000F);
            L002A: compare(ax, 0x000B);
            L002D: if (result.unsigned_greater_than) goto L003E;
            L002F: ShowMessage(party, String0912); // This area is called the Soldiers' Quarters. Why it is so named is beyond me. I've wandered these halls for weeks and have found nothing resembling living quarters, much less any soldiers.
            L003C: goto L004B;
            L003E: ShowMessage(party, String09CE); // The Human Barbarian is trying to count his fingers and so neglects to answer.
            L004B: // RETURN;
        }

        private override MapEventHandler MapEvent24 => NPCCHATB_24;
        private void NPCCHATB_24(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0A1C); // You encounter a Gremlin Wizard.
            L0010: ShowPortrait(party, 0x002E);
            L001D: ax = UnknownFunctionEC(party, 0x000F);
            L002A: compare(ax, 0x000A);
            L002D: if (result.unsigned_greater_than) goto L003E;
            L002F: ShowMessage(party, String0A3C); // The volcano Yserbius roils the sea and makes it unnavigable. We are doomed to live out our miserable lives, unknown to other peoples. I would give my left eyetooth for a way to escape this dull island.
            L003C: goto L004B;
            L003E: ShowMessage(party, String0B06); // The Gremlin Wizards squeals in terror and flees.
            L004B: // RETURN;
        }

        private override MapEventHandler MapEvent25 => NPCCHATC_25;
        private void NPCCHATC_25(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0B37); // You encounter a Troll Ranger.
            L0010: ShowPortrait(party, 0x0020);
            L001D: ax = UnknownFunctionEC(party, 0x000F);
            L002A: compare(ax, 0x0007);
            L002D: if (result.unsigned_greater_than) goto L003E;
            L002F: ShowMessage(party, String0B55); // Unless you have especially sharp eyes for traps, you should heed the sign at the end of the corridor. This bum leg of mine is proof of that sign's warning.
            L003C: goto L004B;
            L003E: ShowMessage(party, String0BF1); // The Troll Ranger snarls a curse at you and limps away.
            L004B: // RETURN;
        }

        private override MapEventHandler MapEvent26 => NPCCHATD_26;
        private void NPCCHATD_26(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0C28); // You encounter an Elf Cleric.
            L0010: ShowPortrait(party, 0x0027);
            L001D: ax = UnknownFunctionEC(party, 0x000F);
            L002A: compare(ax, 0x000C);
            L002D: if (result.unsigned_greater_than) goto L003E;
            L002F: ShowMessage(party, String0C45); // You may think you are limited only to those skills you acquire through your Guild. I know there are places in this dungeon where you may acquire new and different skills.
            L003C: goto L005C;
            L003E: ModifyGold(party, 0x0008);
            L004F: ShowMessage(party, String0CF0); // The Elf Cleric gives you gold to leave him in peace.
            L005C: // RETURN;
        }

        private override MapEventHandler MapEvent27 => NPCCHATE_27;
        private void NPCCHATE_27(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0D25); // You encounter a Troll Knight.
            L0010: ShowPortrait(party, 0x001B);
            L001D: ax = UnknownFunctionEC(party, 0x000F);
            L002A: compare(ax, 0x0007);
            L002D: if (result.unsigned_greater_than) goto L003E;
            L002F: ShowMessage(party, String0D43); // Under Cleowyn's palace is a strange maze. The maze is infested with thieves, and they seem to be the only ones who know how to get through the thing.
            L003C: goto L004B;
            L003E: ShowMessage(party, String0DD9); // The Troll Knight is lost in thought and does not hear you.
            L004B: // RETURN;
        }

        private override MapEventHandler MapEvent28 => NPCCHATF_28;
        private void NPCCHATF_28(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0E14); // You encounter an Orc Barbarian.
            L0010: ShowPortrait(party, 0x0017);
            L001D: ax = UnknownFunctionEC(party, 0x000F);
            L002A: compare(ax, 0x0009);
            L002D: if (result.unsigned_greater_than) goto L003E;
            L002F: ShowMessage(party, String0E34); // A dwarf knight told me he encountered polar bears and ice lions deep in the dungeon. Whoever heard of polar bears and ice lions living inside an active volcano?
            L003C: goto L004B;
            L003E: ShowMessage(party, String0ED5); // The Orc Barbarian watches you impassively, refusing to talk.
            L004B: // RETURN;
        }

    }
}
