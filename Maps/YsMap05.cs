#pragma warning disable
using XPT.WorldData;

namespace XPT.Scripts.Yserbius.Maps {
    class YserMap05 : AMapScripted {
        protected override int MapIndex => 5;
        
        public YserMap05() {
            MapEvent01 = FnTOEXIT_01;
            MapEvent02 = FnTOTREAS_02;
            MapEvent03 = FnSTAIRSD_03;
            MapEvent04 = FnTELPORTS_04;
            MapEvent05 = FnTELPORTN_05;
            MapEvent06 = FnTELEPORT_06;
            MapEvent07 = FnTELPORTW_07;
            MapEvent08 = FnTELPORTE_08;
            MapEvent09 = FnLKPKDOOR_09;
            MapEvent0A = FnITEMCENC_0A;
            MapEvent0B = FnGOLDAENC_0B;
            MapEvent0C = FnGOLDBENC_0C;
            MapEvent0D = FnGOLDCENC_0D;
            MapEvent0E = FnGOLDDENC_0E;
            MapEvent0F = FnGOLDEENC_0F;
            MapEvent10 = FnGOLDFENC_10;
            MapEvent13 = FnTUFMNSTR_13;
            MapEvent15 = FnITEMAENC_15;
            MapEvent16 = FnITEMBENC_16;
            MapEvent18 = FnLKPKDOOR_18;
            MapEvent19 = FnGATEMESA_19;
            MapEvent1A = FnGATEMESB_1A;
            MapEvent1F = FnTELEMESC_1F;
            MapEvent20 = FnTELEMESD_20;
            MapEvent21 = FnTELEMESE_21;
            MapEvent22 = FnSTRSMESB_22;
            MapEvent23 = FnNPCCHATA_23;
            MapEvent24 = FnNPCCHATB_24;
            MapEvent25 = FnNPCCHATC_25;
            MapEvent26 = FnNPCCHATD_26;
            MapEvent27 = FnNPCCHATE_27;
            MapEvent28 = FnNPCCHATF_28;
        }
        
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
        private void FnTOEXIT_01(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(party, 0x01, 0x01, 0x85, 0x03, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnTOTREAS_02(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(party, 0x01, 0x05, 0xA0, 0x02, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnSTAIRSD_03(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(party, 0x02, 0x01, 0x81, 0x02, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnTELPORTS_04(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(party, 0x01, 0x06, 0xCD, 0x01, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnTELPORTN_05(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(party, 0x01, 0x06, 0x3C, 0x01, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnTELEPORT_06(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(party, 0x03, 0x02, 0xCA, 0x02, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnTELPORTW_07(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(party, 0x01, 0x06, 0x77, 0x01, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnTELPORTE_08(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(party, 0x01, 0x06, 0x9E, 0x03, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnLKPKDOOR_09(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasUsedItem(party, 0xC0, 0xC4);
            L0016: if (JumpNotEqual) goto L0029;
            L0018: ax = HasUsedSkill(party, 0x0E); // returns 0 if did not use, compares to 2nd op if did use;
            L0024: Compare(ax, 0x0005);
            L0027: if (JumpBelow) goto L0074;
            L0029: PushStack(party, 0x01);
            L002D: ax = GetFacing(party);
            L0034: PushStack(party, ax);
            L0035: ax = GetCurrentTile(party);
            L003C: PushStack(party, ax);
            L003D: SetWallPassable(party, PopStack(party), PopStack(party), PopStack(party));
            L0047: ax = GetFacing(party);
            L004E: PushStack(party, ax);
            L004F: ax = GetCurrentTile(party);
            L0056: PushStack(party, ax);
            L0057: PushStack(party, 0x01);
            L005B: SetWallObject(party, PopStack(party), PopStack(party), PopStack(party));
            L0065: ShowMessage(party, String03FC); // You successfully picked the locked door.
            L0072: goto L009E;
            L0074: PushStack(party, 0x00);
            L0077: ax = GetFacing(party);
            L007E: PushStack(party, ax);
            L007F: ax = GetCurrentTile(party);
            L0086: PushStack(party, ax);
            L0087: SetWallPassable(party, PopStack(party), PopStack(party), PopStack(party));
            L0091: ShowMessage(party, String0425); // The door is locked.
            L009E: return; // RETURN;
        }

        private void FnITEMCENC_0A(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(party, 0x27);
            L0011: if (JumpEqual) goto L0041;
            L0013: ShowMessage(party, String0439); // Dire Wolves prowl the area.
            L0020: AddTreasure(party, 0x01F4, 0x00, 0x00, 0x00, 0x00, 0xB5);
            L003F: goto L006D;
            L0041: AddTreasure(party, 0x03E8, 0x00, 0x00, 0x00, 0x00, 0x27);
            L0060: ShowMessage(party, String0455); // A Dire Wolf holds something in its mouth.
            L006D: ax = PartyCount(party);
            L0075: Compare(ax, 0x0001);
            L0078: if (JumpEqual) goto L0087;
            L007A: ax = PartyCount(party);
            L0082: Compare(ax, 0x0002);
            L0085: if (JumpNotEqual) goto L009B;
            L0087: AddEncounter(party, 0x01, 0x27);
            L0099: goto L00D1;
            L009B: AddEncounter(party, 0x01, 0x27);
            L00AD: AddEncounter(party, 0x02, 0x27);
            L00BF: AddEncounter(party, 0x03, 0x28);
            L00D1: return; // RETURN;
        }

        private void FnGOLDAENC_0B(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = GetState(party, 0x02, 0x0C);
            L0014: Compare(ax, 0x0001);
            L0017: if (JumpNotEqual) goto L0048;
            L0019: ShowMessage(party, String047F); // Copper Ogres are huddled around a small fire.
            L0026: AddTreasure(party, 0x0032, 0x00, 0x00, 0x00, 0xB5, 0x12);
            L0046: goto L0089;
            L0048: AddTreasure(party, 0x07D0, 0x00, 0x00, 0x00, 0x00, 0xB5);
            L0067: ShowMessage(party, String04AD); // Copper Ogres are counting gold they have stolen.
            L0074: SetState(party, 0x02, 0x0C, 0x01);
            L0089: ax = PartyCount(party);
            L0091: Compare(ax, 0x0001);
            L0094: if (JumpNotEqual) goto L00AB;
            L0096: AddEncounter(party, 0x01, 0x1A);
            L00A8: goto L016C;
            L00AB: ax = PartyCount(party);
            L00B3: Compare(ax, 0x0002);
            L00B6: if (JumpNotEqual) goto L00DF;
            L00B8: AddEncounter(party, 0x01, 0x19);
            L00CA: AddEncounter(party, 0x02, 0x1A);
            L00DC: goto L016C;
            L00DF: ax = PartyCount(party);
            L00E7: Compare(ax, 0x0003);
            L00EA: if (JumpNotEqual) goto L0124;
            L00EC: AddEncounter(party, 0x01, 0x1A);
            L00FE: AddEncounter(party, 0x02, 0x19);
            L0110: AddEncounter(party, 0x03, 0x1A);
            L0122: goto L016C;
            L0124: AddEncounter(party, 0x01, 0x1B);
            L0136: AddEncounter(party, 0x02, 0x1A);
            L0148: AddEncounter(party, 0x03, 0x19);
            L015A: AddEncounter(party, 0x04, 0x1A);
            L016C: return; // RETURN;
        }

        private void FnGOLDBENC_0C(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = GetState(party, 0x02, 0x0D);
            L0014: Compare(ax, 0x0001);
            L0017: if (JumpNotEqual) goto L0047;
            L0019: ShowMessage(party, String04DE); // This room is the lair of Mountain Lions.
            L0026: AddTreasure(party, 0x0000, 0x00, 0x00, 0x00, 0xCB, 0x35);
            L0045: goto L0088;
            L0047: AddTreasure(party, 0x01F4, 0x00, 0x00, 0x00, 0x00, 0xB5);
            L0066: ShowMessage(party, String0507); // Mountain Lions chew on a small bag.
            L0073: SetState(party, 0x02, 0x0D, 0x01);
            L0088: ax = PartyCount(party);
            L0090: Compare(ax, 0x0001);
            L0093: if (JumpNotEqual) goto L00AA;
            L0095: AddEncounter(party, 0x01, 0x1C);
            L00A7: goto L018F;
            L00AA: ax = PartyCount(party);
            L00B2: Compare(ax, 0x0002);
            L00B5: if (JumpNotEqual) goto L00DE;
            L00B7: AddEncounter(party, 0x01, 0x1C);
            L00C9: AddEncounter(party, 0x02, 0x1C);
            L00DB: goto L018F;
            L00DE: ax = PartyCount(party);
            L00E6: Compare(ax, 0x0003);
            L00E9: if (JumpNotEqual) goto L0135;
            L00EB: AddEncounter(party, 0x01, 0x1C);
            L00FD: AddEncounter(party, 0x02, 0x1C);
            L010F: AddEncounter(party, 0x03, 0x1C);
            L0121: AddEncounter(party, 0x04, 0x1C);
            L0133: goto L018F;
            L0135: AddEncounter(party, 0x01, 0x1C);
            L0147: AddEncounter(party, 0x02, 0x1C);
            L0159: AddEncounter(party, 0x03, 0x1C);
            L016B: AddEncounter(party, 0x04, 0x1C);
            L017D: AddEncounter(party, 0x05, 0x1C);
            L018F: return; // RETURN;
        }

        private void FnGOLDCENC_0D(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = GetState(party, 0x02, 0x0E);
            L0014: Compare(ax, 0x0001);
            L0017: if (JumpNotEqual) goto L0047;
            L0019: ShowMessage(party, String052B); // You hear the angry snapping of pincers.
            L0026: AddTreasure(party, 0x0032, 0x00, 0x00, 0x00, 0x00, 0xCB);
            L0045: goto L0088;
            L0047: AddTreasure(party, 0x02EE, 0x00, 0x00, 0x00, 0x00, 0xCE);
            L0066: ShowMessage(party, String0553); // As you step forward to pick up some gold on the floor...
            L0073: SetState(party, 0x02, 0x0E, 0x01);
            L0088: ax = PartyCount(party);
            L0090: Compare(ax, 0x0001);
            L0093: if (JumpNotEqual) goto L00A9;
            L0095: AddEncounter(party, 0x01, 0x09);
            L00A7: goto L0124;
            L00A9: ax = PartyCount(party);
            L00B1: Compare(ax, 0x0002);
            L00B4: if (JumpNotEqual) goto L00DC;
            L00B6: AddEncounter(party, 0x01, 0x08);
            L00C8: AddEncounter(party, 0x02, 0x09);
            L00DA: goto L0124;
            L00DC: AddEncounter(party, 0x01, 0x08);
            L00EE: AddEncounter(party, 0x02, 0x08);
            L0100: AddEncounter(party, 0x03, 0x09);
            L0112: AddEncounter(party, 0x04, 0x09);
            L0124: return; // RETURN;
        }

        private void FnGOLDDENC_0E(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = GetState(party, 0x02, 0x0F);
            L0014: Compare(ax, 0x0001);
            L0017: if (JumpNotEqual) goto L0047;
            L0019: ShowMessage(party, String058C); // Imps spring an ambush on you.
            L0026: AddTreasure(party, 0x0014, 0x00, 0x00, 0x00, 0x00, 0xB5);
            L0045: goto L0088;
            L0047: AddTreasure(party, 0x04B0, 0x00, 0x00, 0x00, 0x00, 0xCE);
            L0066: ShowMessage(party, String05AA); // You see gold on the floor and something hiding in the shadows.
            L0073: SetState(party, 0x02, 0x0F, 0x01);
            L0088: ax = PartyCount(party);
            L0090: Compare(ax, 0x0001);
            L0093: if (JumpNotEqual) goto L00BC;
            L0095: AddEncounter(party, 0x01, 0x12);
            L00A7: AddEncounter(party, 0x02, 0x12);
            L00B9: goto L017A;
            L00BC: ax = PartyCount(party);
            L00C4: Compare(ax, 0x0002);
            L00C7: if (JumpEqual) goto L00D6;
            L00C9: ax = PartyCount(party);
            L00D1: Compare(ax, 0x0003);
            L00D4: if (JumpNotEqual) goto L0120;
            L00D6: AddEncounter(party, 0x01, 0x11);
            L00E8: AddEncounter(party, 0x02, 0x11);
            L00FA: AddEncounter(party, 0x03, 0x12);
            L010C: AddEncounter(party, 0x04, 0x12);
            L011E: goto L017A;
            L0120: AddEncounter(party, 0x01, 0x12);
            L0132: AddEncounter(party, 0x02, 0x12);
            L0144: AddEncounter(party, 0x03, 0x11);
            L0156: AddEncounter(party, 0x05, 0x11);
            L0168: AddEncounter(party, 0x06, 0x11);
            L017A: return; // RETURN;
        }

        private void FnGOLDEENC_0F(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = GetState(party, 0x02, 0x10);
            L0014: Compare(ax, 0x0001);
            L0017: if (JumpNotEqual) goto L0047;
            L0019: ShowMessage(party, String05E9); // You turn as you hear bones rattling.
            L0026: AddTreasure(party, 0x0050, 0x00, 0x00, 0x00, 0x00, 0xB5);
            L0045: goto L0088;
            L0047: AddTreasure(party, 0x0FA0, 0x00, 0x00, 0x00, 0x00, 0xD1);
            L0066: ShowMessage(party, String060E); // A skeleton has a coin bag tied to its belt.
            L0073: SetState(party, 0x02, 0x10, 0x01);
            L0088: ax = PartyCount(party);
            L0090: Compare(ax, 0x0001);
            L0093: if (JumpNotEqual) goto L00BC;
            L0095: AddEncounter(party, 0x01, 0x15);
            L00A7: AddEncounter(party, 0x02, 0x15);
            L00B9: goto L01B3;
            L00BC: ax = PartyCount(party);
            L00C4: Compare(ax, 0x0002);
            L00C7: if (JumpNotEqual) goto L0102;
            L00C9: AddEncounter(party, 0x01, 0x15);
            L00DB: AddEncounter(party, 0x02, 0x15);
            L00ED: AddEncounter(party, 0x03, 0x15);
            L00FF: goto L01B3;
            L0102: ax = PartyCount(party);
            L010A: Compare(ax, 0x0003);
            L010D: if (JumpNotEqual) goto L0159;
            L010F: AddEncounter(party, 0x01, 0x15);
            L0121: AddEncounter(party, 0x02, 0x15);
            L0133: AddEncounter(party, 0x03, 0x15);
            L0145: AddEncounter(party, 0x04, 0x15);
            L0157: goto L01B3;
            L0159: AddEncounter(party, 0x01, 0x15);
            L016B: AddEncounter(party, 0x02, 0x15);
            L017D: AddEncounter(party, 0x03, 0x15);
            L018F: AddEncounter(party, 0x04, 0x15);
            L01A1: AddEncounter(party, 0x05, 0x15);
            L01B3: return; // RETURN;
        }

        private void FnGOLDFENC_10(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = GetState(party, 0x02, 0x11);
            L0014: Compare(ax, 0x0001);
            L0017: if (JumpNotEqual) goto L0047;
            L0019: ShowMessage(party, String063A); // You stumble upon an almost empty nesting area.
            L0026: AddTreasure(party, 0x0000, 0x00, 0x00, 0x00, 0x00, 0xCB);
            L0044: goto L0122;
            L0047: AddTreasure(party, 0x05DC, 0x00, 0x00, 0x00, 0x00, 0xCB);
            L0066: ShowMessage(party, String0669); // Angry hissing distracts you as you reach down for some gold coins.
            L0073: SetState(party, 0x02, 0x11, 0x01);
            L0088: ax = PartyCount(party);
            L0090: Compare(ax, 0x0001);
            L0093: if (JumpEqual) goto L00A2;
            L0095: ax = PartyCount(party);
            L009D: Compare(ax, 0x0002);
            L00A0: if (JumpNotEqual) goto L00C8;
            L00A2: AddEncounter(party, 0x01, 0x07);
            L00B4: AddEncounter(party, 0x02, 0x06);
            L00C6: goto L0122;
            L00C8: AddEncounter(party, 0x01, 0x06);
            L00DA: AddEncounter(party, 0x02, 0x06);
            L00EC: AddEncounter(party, 0x03, 0x07);
            L00FE: AddEncounter(party, 0x04, 0x07);
            L0110: AddEncounter(party, 0x05, 0x06);
            L0122: return; // RETURN;
        }

        private void FnTUFMNSTR_13(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String06AC); // You encounter Rogues.
            L0010: ax = GetRandom(party, 0x000F);
            L001D: Compare(ax, 0x0002);
            L0020: if (JumpAbove) goto L0031;
            L0022: ShowMessage(party, String06C2); // The rooms in the center of this area once housed the king's soldiers.
            L002F: goto L003E;
            L0031: ShowMessage(party, String0708); // The Rogues laugh at you and attack.
            L003E: ax = PartyCount(party);
            L0046: Compare(ax, 0x0001);
            L0049: if (JumpEqual) goto L0058;
            L004B: ax = PartyCount(party);
            L0053: Compare(ax, 0x0002);
            L0056: if (JumpNotEqual) goto L007F;
            L0058: AddEncounter(party, 0x01, 0x1F);
            L006A: AddEncounter(party, 0x02, 0x20);
            L007C: goto L0142;
            L007F: ax = PartyCount(party);
            L0087: Compare(ax, 0x0003);
            L008A: if (JumpNotEqual) goto L00D6;
            L008C: AddEncounter(party, 0x01, 0x1F);
            L009E: AddEncounter(party, 0x02, 0x1F);
            L00B0: AddEncounter(party, 0x05, 0x20);
            L00C2: AddEncounter(party, 0x06, 0x21);
            L00D4: goto L0142;
            L00D6: AddEncounter(party, 0x01, 0x1F);
            L00E8: AddEncounter(party, 0x02, 0x1F);
            L00FA: AddEncounter(party, 0x03, 0x20);
            L010C: AddEncounter(party, 0x04, 0x20);
            L011E: AddEncounter(party, 0x05, 0x21);
            L0130: AddEncounter(party, 0x05, 0x21);
            L0142: return; // RETURN;
        }

        private void FnITEMAENC_15(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(party, 0x03);
            L0011: if (JumpEqual) goto L0065;
            L0013: ax = HasItem(party, 0x4F);
            L0021: if (JumpEqual) goto L0044;
            L0023: AddTreasure(party, 0x0064, 0x00, 0x00, 0x00, 0x00, 0xCE);
            L0042: goto L0063;
            L0044: AddTreasure(party, 0x03E8, 0x00, 0x00, 0x00, 0x00, 0x4F);
            L0063: goto L00B6;
            L0065: ax = HasItem(party, 0x4F);
            L0073: if (JumpEqual) goto L0096;
            L0075: AddTreasure(party, 0x03E8, 0x00, 0x00, 0x00, 0x00, 0x04);
            L0094: goto L00B6;
            L0096: AddTreasure(party, 0x03E8, 0x00, 0x00, 0x00, 0x4F, 0x04);
            L00B6: ShowMessage(party, String072C); // You are waylaid by Rogues.
            L00C3: ax = PartyCount(party);
            L00CB: Compare(ax, 0x0001);
            L00CE: if (JumpNotEqual) goto L00E5;
            L00D0: AddEncounter(party, 0x01, 0x1F);
            L00E2: goto L01A6;
            L00E5: ax = PartyCount(party);
            L00ED: Compare(ax, 0x0002);
            L00F0: if (JumpNotEqual) goto L0119;
            L00F2: AddEncounter(party, 0x01, 0x20);
            L0104: AddEncounter(party, 0x02, 0x21);
            L0116: goto L01A6;
            L0119: ax = PartyCount(party);
            L0121: Compare(ax, 0x0003);
            L0124: if (JumpNotEqual) goto L015E;
            L0126: AddEncounter(party, 0x01, 0x1F);
            L0138: AddEncounter(party, 0x02, 0x20);
            L014A: AddEncounter(party, 0x03, 0x21);
            L015C: goto L01A6;
            L015E: AddEncounter(party, 0x01, 0x1F);
            L0170: AddEncounter(party, 0x02, 0x1F);
            L0182: AddEncounter(party, 0x03, 0x20);
            L0194: AddEncounter(party, 0x05, 0x21);
            L01A6: return; // RETURN;
        }

        private void FnITEMBENC_16(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(party, 0x0F);
            L0011: if (JumpEqual) goto L0066;
            L0013: ax = HasItem(party, 0x7B);
            L0021: if (JumpEqual) goto L0045;
            L0023: AddTreasure(party, 0x0064, 0x00, 0x00, 0x00, 0xCE, 0xCC);
            L0043: goto L0064;
            L0045: AddTreasure(party, 0x03E8, 0x00, 0x00, 0x00, 0x00, 0x7B);
            L0064: goto L00B7;
            L0066: ax = HasItem(party, 0x7B);
            L0074: if (JumpEqual) goto L0097;
            L0076: AddTreasure(party, 0x03E8, 0x00, 0x00, 0x00, 0x00, 0x0F);
            L0095: goto L00B7;
            L0097: AddTreasure(party, 0x03E8, 0x00, 0x00, 0x00, 0x7B, 0x0F);
            L00B7: ShowMessage(party, String0747); // You surprise some Rogues.
            L00C4: ax = PartyCount(party);
            L00CC: Compare(ax, 0x0001);
            L00CF: if (JumpNotEqual) goto L00E6;
            L00D1: AddEncounter(party, 0x01, 0x23);
            L00E3: goto L01CB;
            L00E6: ax = PartyCount(party);
            L00EE: Compare(ax, 0x0002);
            L00F1: if (JumpNotEqual) goto L011A;
            L00F3: AddEncounter(party, 0x01, 0x22);
            L0105: AddEncounter(party, 0x02, 0x23);
            L0117: goto L01CB;
            L011A: ax = PartyCount(party);
            L0122: Compare(ax, 0x0003);
            L0125: if (JumpNotEqual) goto L0171;
            L0127: AddEncounter(party, 0x01, 0x22);
            L0139: AddEncounter(party, 0x02, 0x22);
            L014B: AddEncounter(party, 0x03, 0x23);
            L015D: AddEncounter(party, 0x04, 0x23);
            L016F: goto L01CB;
            L0171: AddEncounter(party, 0x01, 0x23);
            L0183: AddEncounter(party, 0x02, 0x23);
            L0195: AddEncounter(party, 0x03, 0x23);
            L01A7: AddEncounter(party, 0x04, 0x22);
            L01B9: AddEncounter(party, 0x05, 0x21);
            L01CB: return; // RETURN;
        }

        private void FnLKPKDOOR_18(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasUsedItem(party, 0xC1, 0xC4);
            L0016: if (JumpNotEqual) goto L0029;
            L0018: ax = HasUsedSkill(party, 0x0E); // returns 0 if did not use, compares to 2nd op if did use;
            L0024: Compare(ax, 0x0006);
            L0027: if (JumpBelow) goto L0074;
            L0029: PushStack(party, 0x01);
            L002D: ax = GetFacing(party);
            L0034: PushStack(party, ax);
            L0035: ax = GetCurrentTile(party);
            L003C: PushStack(party, ax);
            L003D: SetWallPassable(party, PopStack(party), PopStack(party), PopStack(party));
            L0047: ax = GetFacing(party);
            L004E: PushStack(party, ax);
            L004F: ax = GetCurrentTile(party);
            L0056: PushStack(party, ax);
            L0057: PushStack(party, 0x01);
            L005B: SetWallObject(party, PopStack(party), PopStack(party), PopStack(party));
            L0065: ShowMessage(party, String0761); // You successfully picked the locked door.
            L0072: goto L009E;
            L0074: PushStack(party, 0x00);
            L0077: ax = GetFacing(party);
            L007E: PushStack(party, ax);
            L007F: ax = GetCurrentTile(party);
            L0086: PushStack(party, ax);
            L0087: SetWallPassable(party, PopStack(party), PopStack(party), PopStack(party));
            L0091: ShowMessage(party, String078A); // The door is locked.
            L009E: return; // RETURN;
        }

        private void FnGATEMESA_19(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String079E); // The gateway leads to THE DUNGEON ENTRANCE.
            L0010: return; // RETURN;
        }

        private void FnGATEMESB_1A(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String07C9); // There is a sign on the east door - STAY OUT!
            L0010: return; // RETURN;
        }

        private void FnTELEMESC_1F(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String07F6); // Through the gateway you see stairs leading downwards.The stairs are rather long, at least 2 levels.
            L0010: return; // RETURN;
        }

        private void FnTELEMESD_20(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String085A); // There is a teleport in the south wall.
            L0010: return; // RETURN;
        }

        private void FnTELEMESE_21(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0881); // There is a teleport in the north wall.
            L0010: return; // RETURN;
        }

        private void FnSTRSMESB_22(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String08A8); // Through the north gateway you see stairs leading down to the next level.
            L0010: return; // RETURN;
        }

        private void FnNPCCHATA_23(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(party, 0x0016);
            L0010: ShowMessage(party, String08F1); // You encounter a Human Barbarian.
            L001D: ax = GetRandom(party, 0x000F);
            L002A: Compare(ax, 0x000B);
            L002D: if (JumpAbove) goto L003E;
            L002F: ShowMessage(party, String0912); // This area is called the Soldiers' Quarters. Why it is so named is beyond me. I've wandered these halls for weeks and have found nothing resembling living quarters, much less any soldiers.
            L003C: goto L004B;
            L003E: ShowMessage(party, String09CE); // The Human Barbarian is trying to count his fingers and so neglects to answer.
            L004B: return; // RETURN;
        }

        private void FnNPCCHATB_24(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0A1C); // You encounter a Gremlin Wizard.
            L0010: ShowPortrait(party, 0x002E);
            L001D: ax = GetRandom(party, 0x000F);
            L002A: Compare(ax, 0x000A);
            L002D: if (JumpAbove) goto L003E;
            L002F: ShowMessage(party, String0A3C); // The volcano Yserbius roils the sea and makes it unnavigable. We are doomed to live out our miserable lives, unknown to other peoples. I would give my left eyetooth for a way to escape this dull island.
            L003C: goto L004B;
            L003E: ShowMessage(party, String0B06); // The Gremlin Wizards squeals in terror and flees.
            L004B: return; // RETURN;
        }

        private void FnNPCCHATC_25(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0B37); // You encounter a Troll Ranger.
            L0010: ShowPortrait(party, 0x0020);
            L001D: ax = GetRandom(party, 0x000F);
            L002A: Compare(ax, 0x0007);
            L002D: if (JumpAbove) goto L003E;
            L002F: ShowMessage(party, String0B55); // Unless you have especially sharp eyes for traps, you should heed the sign at the end of the corridor. This bum leg of mine is proof of that sign's warning.
            L003C: goto L004B;
            L003E: ShowMessage(party, String0BF1); // The Troll Ranger snarls a curse at you and limps away.
            L004B: return; // RETURN;
        }

        private void FnNPCCHATD_26(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0C28); // You encounter an Elf Cleric.
            L0010: ShowPortrait(party, 0x0027);
            L001D: ax = GetRandom(party, 0x000F);
            L002A: Compare(ax, 0x000C);
            L002D: if (JumpAbove) goto L003E;
            L002F: ShowMessage(party, String0C45); // You may think you are limited only to those skills you acquire through your Guild. I know there are places in this dungeon where you may acquire new and different skills.
            L003C: goto L005C;
            L003E: ModifyGold(party, 0x0008);
            L004F: ShowMessage(party, String0CF0); // The Elf Cleric gives you gold to leave him in peace.
            L005C: return; // RETURN;
        }

        private void FnNPCCHATE_27(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0D25); // You encounter a Troll Knight.
            L0010: ShowPortrait(party, 0x001B);
            L001D: ax = GetRandom(party, 0x000F);
            L002A: Compare(ax, 0x0007);
            L002D: if (JumpAbove) goto L003E;
            L002F: ShowMessage(party, String0D43); // Under Cleowyn's palace is a strange maze. The maze is infested with thieves, and they seem to be the only ones who know how to get through the thing.
            L003C: goto L004B;
            L003E: ShowMessage(party, String0DD9); // The Troll Knight is lost in thought and does not hear you.
            L004B: return; // RETURN;
        }

        private void FnNPCCHATF_28(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0E14); // You encounter an Orc Barbarian.
            L0010: ShowPortrait(party, 0x0017);
            L001D: ax = GetRandom(party, 0x000F);
            L002A: Compare(ax, 0x0009);
            L002D: if (JumpAbove) goto L003E;
            L002F: ShowMessage(party, String0E34); // A dwarf knight told me he encountered polar bears and ice lions deep in the dungeon. Whoever heard of polar bears and ice lions living inside an active volcano?
            L003C: goto L004B;
            L003E: ShowMessage(party, String0ED5); // The Orc Barbarian watches you impassively, refusing to talk.
            L004B: return; // RETURN;
        }

    }
}
