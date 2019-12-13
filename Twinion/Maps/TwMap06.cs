#pragma warning disable
using System.Collections.Generic;
using XPT.WorldData;
using XPT.WorldData.Yserbius;

namespace XPT.Scripts.Twinion.Maps {
    class TwMap06 : AMapScripted {
        protected override int MapIndex => 6;
        protected override int RandomEncounterChance => 10;
        protected override int RandomEncounterExtraCount => 0;

        public TwMap06() {
            MapEvent01 = FnCOLUMN_01;
            MapEvent02 = FnQUADONE_02;
            MapEvent03 = FnQUADTWO_03;
            MapEvent04 = FnQUADTHRE_04;
            MapEvent05 = FnQUADFOUR_05;
            MapEvent06 = FnEXITAREA_06;
            MapEvent07 = FnEGRESS_07;
            MapEvent08 = FnMOVESTRN_08;
            MapEvent09 = FnMOVEMAGC_09;
            MapEvent0A = FnPITS_0A;
            MapEvent0B = FnFLAGTST_0B;
            MapEvent0C = FnBATONE_0C;
            MapEvent0D = FnBATTWO_0D;
            MapEvent0E = FnBATTHREE_0E;
            MapEvent0F = FnBATFOUR_0F;
            MapEvent10 = FnWAITONE_10;
            MapEvent11 = FnQTBATONE_11;
            MapEvent12 = FnQTBATTWO_12;
            MapEvent13 = FnQTBATTRE_13;
            MapEvent14 = FnQTBATFOR_14;
            MapEvent15 = FnROSTER_15;
            MapEvent16 = FnQCBATONE_16;
            MapEvent17 = FnQCBATTWO_17;
            MapEvent18 = FnQCBATTRE_18;
            MapEvent19 = FnQCBATFOR_19;
            MapEvent1A = FnQDBATONE_1A;
            MapEvent1B = FnQDBATTWO_1B;
            MapEvent1C = FnQDBATTRE_1C;
            MapEvent1D = FnQDBATFOR_1D;
            MapEvent1E = FnSTASHONE_1E;
            MapEvent1F = FnSTASHTWO_1F;
            MapEvent20 = FnSTASHTRE_20;
            MapEvent21 = FnSTASHFOR_21;
            MapEvent22 = FnDESCRIPA_22;
            MapEvent23 = FnDESCRIPB_23;
            MapEvent24 = FnDESCRIPC_24;
            MapEvent25 = FnDESCRIPD_25;
            MapEvent26 = FnROOMDESC_26;
            MapEvent27 = FnCLEARSTR_27;
            MapEvent28 = FnCLEARMAG_28;
            MapEvent29 = FnRANGTHIF_29;
            MapEvent2A = FnHAILFNTN_2A;
            MapEvent2B = FnCLERICFN_2B;
            MapEvent2C = FnWHATNOW_2C;
            MapEvent2D = FnBLOCKWAL_2D;
            MapEvent2E = FnTOQUENAQ_2E;
            MapEvent2F = FnTOCORE_2F;
        }
        
        // === Strings ================================================
        private const string String03FC = "To the first Arena.";
        private const string String0410 = "To the second Arena.";
        private const string String0425 = "To the third Arena.";
        private const string String0439 = "To the fourth Arena.";
        private const string String044E = "To the way out.";
        private const string String045E = "This leads to the Queen's Palace.";
        private const string String0480 = "There are more Arenas to complete when you feel ready. You may proceed now.";
        private const string String04CC = "You're strong enough to move the column and get around it.";
        private const string String0507 = "Your abilities will allow you to squeeze through a narrow gap between the columns.";
        private const string String055A = "Blessed are the Magi! For your wisdom is obvious; this magical pillar slides away allowing you to pass.";
        private const string String05C2 = "You plummet to your death!";
        private const string String05DD = "Well done! Proceed to the exit. The end of these Proving Grounds is near!";
        private const string String0627 = "Your accomplishment deserves the attributed reward. This experience will aid you in reaching the next level.";
        private const string String0694 = "There's nothing more for you here.";
        private const string String06B7 = "Magi hurl spells at you!";
        private const string String06D0 = "Arrows rain down upon you from an attacking party of Archers.";
        private const string String070E = "Quarrelsome thieves charge you.";
        private const string String072E = "A party of warriors intend to prevent you from completing this arena.";
        private const string String0774 = "A nervous wizard chatters at you.";
        private const string String0796 = "'There are so many of them. So many...";
        private const string String07BD = "She said I would get great rewards for doing all four, but I know that only one would suffice.'";
        private const string String081D = "Knights and their squires charge you.";
        private const string String0843 = "Gladiators and scavenging rogues take the offensive.";
        private const string String0878 = "A hulking colossus towers over you.";
        private const string String089C = "An odd array of mage and muscle stands before you.";
        private const string String08CF = "A roster listing various guilds and names is posted here. Hmmm..your name does not appear on the list!";
        private const string String0936 = "Warring gladiators challenge you.";
        private const string String0958 = "Swords and sorcery are unleashed against you.";
        private const string String0986 = "The air is filled with bursts of magic as a party of enchanters attacks.";
        private const string String09CF = "Undead magi encircle you!";
        private const string String09E9 = "Spirits of magi and bones of thieves charge you.";
        private const string String0A1A = "Long dead gladiators rise from the dust to attack you!";
        private const string String0A51 = "Assorted undead heroes challenge you at this exit.";
        private const string String0A84 = "You find some useful items.";
        private const string String0AA0 = "The sounds of distant combats echo off the surrounding pillars as you enter the first Arena.";
        private const string String0AFD = "Snarls from giants and orcish grunts greet you here in the second Arena.";
        private const string String0B46 = "Bursts of magic light momentarily limn the silhouettes of the combatants in this third Arena.";
        private const string String0BA4 = "Anguished howls and death wails greet the wary visitor to this fourth Arena.";
        private const string String0BF1 = "The huge columns of this room act more as barriers than supports.";
        private const string String0C33 = "Through the gaps between columns you see bloody combats in what appear to be four different Arenas.";
        private const string String0C97 = "A bubbling fountain offers knowledge and refreshment.";
        private const string String0CCD = "The waters offer you refreshment, but nothing more.";
        private const string String0D01 = "There are more Arenas to complete when you feel ready. You may proceed for now.";
        private const string String0D51 = "Markings here read- 'One way! To The Queen's Aqueduct.'";
        private const string String0D89 = "One way! Back to the Coliseum's Core.";
        
        // === Functions ================================================
        private void FnCOLUMN_01(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFloorPassable(player, 0x00, GetCurrentTile(player));
            L0017: return; // RETURN;
        }

        private void FnQUADONE_02(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String03FC); // To the first Arena.
            L0010: TeleportParty(player, 0x03, 0x01, 0x0F, 0x01, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnQUADTWO_03(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0410); // To the second Arena.
            L0010: TeleportParty(player, 0x03, 0x01, 0x00, 0x33, isForwardMove);
            L002A: return; // RETURN;
        }

        private void FnQUADTHRE_04(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0425); // To the third Arena.
            L0010: TeleportParty(player, 0x03, 0x01, 0xD0, 0x02, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnQUADFOUR_05(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0439); // To the fourth Arena.
            L0010: TeleportParty(player, 0x03, 0x01, 0xCF, 0x01, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnEXITAREA_06(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String044E); // To the way out.
            L0010: TeleportParty(player, 0x03, 0x01, 0x7C, 0x01, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnEGRESS_07(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String045E); // This leads to the Queen's Palace.
            L0010: Compare(GetFlag(player, 0x02, 0x17), 0x0004);
            L0024: if (JumpNotBelow) goto L0033;
            L0026: ShowMessage(player, String0480); // There are more Arenas to complete when you feel ready. You may proceed now.
            L0033: TeleportParty(player, 0x03, 0x02, 0x80, 0x02, isForwardMove);
            L004E: return; // RETURN;
        }

        private void FnMOVESTRN_08(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetGuild(player), 0x0003);
            L000D: if (JumpEqual) goto L0044;
            L000F: Compare(CheckStrength(player), 0x0012);
            L001E: if (JumpBelow) goto L0025;
0178  0020 B8 CC 04  mov ax, 0x4cc
            L0023: goto L0047;
            L0025: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0042: goto L005E;
            L0044: ShowMessage(player, String0507); // Your abilities will allow you to squeeze through a narrow gap between the columns.
            L0051: XCall Fn1686
            L005C: cx = PopStack(player);
            L005D: cx = PopStack(player);
            L005E: return; // RETURN;
        }

        private void FnMOVEMAGC_09(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetGuild(player), 0x0005);
            L000D: if (JumpEqual) goto L001B;
            L000F: Compare(GetGuild(player), 0x0004);
            L0019: if (JumpNotEqual) goto L0037;
            L001B: ShowMessage(player, String055A); // Blessed are the Magi! For your wisdom is obvious; this magical pillar slides away allowing you to pass.
            L0028: XCall Fn16C4
            L0033: cx = PopStack(player);
            L0034: cx = PopStack(player);
            L0035: goto L0065;
            L0037: Compare(GetGuild(player), 0x0003);
            L0041: if (JumpNotEqual) goto L0048;
01FB  0043 B8 07 05  mov ax, 0x507
            L0046: goto L001E;
            L0048: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0065: return; // RETURN;
        }

        private void FnPITS_0A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String05C2); // You plummet to your death!
            L0010: DamagePlayer(player, GetMaxHits(player));
            L0021: return; // RETURN;
        }

        private void FnFLAGTST_0B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0245  0003 83 EC 04  sub sp, 0x4
0248  0006 56     push si
0249  0007 C7 46 FE 00 00  mov word [bp-0x2], 0x0
024E  000C C7 46 FC 00 00  mov word [bp-0x4], 0x0
            L0011: dx = GetFlag(player, 0x02, 0x12) + GetFlag(player, 0x02, 0x13);
            L0037: dx = dx + GetFlag(player, 0x02, 0x14);
            L004C: dx = dx + GetFlag(player, 0x02, 0x15);
02A3  0061 8B F2  mov si, dx
            L0063: Compare(GetFlag(player, 0x02, 0x17), si);
            L0076: if (JumpNotBelow) goto L00D8;
            L0078: ShowMessage(player, String05DD); // Well done! Proceed to the exit. The end of these Proving Grounds is near!
            L0085: bx = si;
            L0087: bx = bx - 1;
            L0088: Compare(bx, 0x03);
            L008B: if (JumpAbove) goto L00A4;
            L008D: switch (bx) {
                case 0:
                    goto L0094;
                case 1:
                    goto L0096;
                case 2:
                    goto L0098;
                case 3:
                    goto L009A;
                case 4:
                    goto L8913;
                case 5:
                    goto LB6AA;
                case 6:
                    goto LFFFFFDBF;
                case 7:
                    goto LC20E;
                case 8:
                    goto L041C;
                case 9:
                    goto LFCE4;
                case 10:
                    goto L221D;
                case 11:
                    goto LC20E;
                case 12:
                    goto L041C;
                case 13:
                    goto LFCE4;
                case 14:
                    goto L1E1D;
                case 15:
                    goto LC20E;
                case 16:
                    goto L041C;
                case 17:
                    goto LFCE4;
                case 18:
                    goto L2A1D;
                case 19:
                    goto LC241;
                case 20:
                    goto LC1C4;
                case 21:
                    goto L041C;
                case 22:
                    goto LFCE4;
                case 23:
                    goto L221D;
                case 24:
                    goto LC20E;
                case 25:
                    goto L041C;
                case 26:
                    goto LFCE4;
                case 27:
                    goto L1E1D;
                case 28:
                    goto LB60E;
                case 29:
                    goto LFFFFFDBF;
                case 30:
                    goto LC20E;
                case 31:
                    goto L041C;
                case 32:
                    goto LFCE4;
                case 33:
                    goto L2E1D;
                case 34:
                    goto LC241;
                case 35:
                    goto L5AC4;
            }
            L0094: goto L009A;
            L0096: goto L009A;
            L0098: goto L009A;
02DC  009A C7 46 FE 00 00  mov word [bp-0x2], 0x0
02E1  009F C7 46 FC 98 3A  mov word [bp-0x4], 0x3a98
            L00A4: SetFlag(player, 0xC4, 0xB8, si);
02F8  00B6 FF 76 FE  push word [bp-0x2]
02FB  00B9 FF 76 FC  push word [bp-0x4]
02FE  00BC C4 5E 06  les bx, [bp+0x6]
0301  00BF 26 FF 9F 98 00  call far word [es:bx+0x98]
            L00C4: cx = PopStack(player);
            L00C5: cx = PopStack(player);
            L00C6: XCall Fn013C
            L00D1: cx = PopStack(player);
            L00D2: cx = PopStack(player);
0315  00D3 B8 27 06  mov ax, 0x627
            L00D6: goto L0125;
            L00D8: Compare(GetFlag(player, 0x02, 0x17), si);
            L00EB: if (JumpNotEqual) goto L0115;
            L00ED: Compare(GetFlag(player, 0x02, 0x17), 0x0004);
            L0101: if (JumpNotBelow) goto L0115;
            L0103: XCall Fn013C
            L010E: cx = PopStack(player);
            L010F: cx = PopStack(player);
0352  0110 B8 80 04  mov ax, 0x480
            L0113: goto L0125;
            L0115: XCall Fn013C
            L0120: cx = PopStack(player);
            L0121: cx = PopStack(player);
            L0122: ShowMessage(player, String0694); // There's nothing more for you here.
0371  012F 5E     pop si
            L0130: // restore stack ptr: sp = bp;
            L0132: return; // RETURN;
        }

        private void FnBATONE_0C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: ShowMessage(player, String06B7); // Magi hurl spells at you!
            L0011: Compare(PartyCount(player), 0x0001);
            L001C: if (JumpNotEqual) goto L0045;
            L001E: AddEncounter(player, 0x01, 0x27);
            L0030: AddEncounter(player, 0x05, 0x28);
            L0042: goto L00E4;
            L0045: Compare(PartyCount(player), 0x0002);
            L0050: if (JumpNotEqual) goto L006D;
            L0052: AddEncounter(player, 0x01, 0x27);
            L0064: PushStack(player, 0x27);
0427  0068 B8 02 00  mov ax, 0x2
            L006B: goto L0025;
            L006D: Compare(PartyCount(player), 0x0003);
            L0078: if (JumpNotEqual) goto L00B0;
            L007A: si = 0x0001;
            L007D: goto L008F;
            L007F: AddEncounter(player, si, 0x27);
            L008E: si = si + 1;
            L008F: Compare(si, 0x03);
            L0092: if (JumpLessOrEqual) goto L007F;
            L0094: si = 0x0005;
            L0097: goto L00A9;
            L0099: AddEncounter(player, si, 0x28);
            L00A8: si = si + 1;
            L00A9: Compare(si, 0x06);
            L00AC: if (JumpLessOrEqual) goto L0099;
            L00AE: goto L00E4;
            L00B0: si = 0x0001;
            L00B3: goto L00C5;
            L00B5: AddEncounter(player, si, 0x27);
            L00C4: si = si + 1;
            L00C5: Compare(si, 0x03);
            L00C8: if (JumpLessOrEqual) goto L00B5;
            L00CA: si = 0x0004;
            L00CD: goto L00DF;
            L00CF: AddEncounter(player, si, 0x28);
            L00DE: si = si + 1;
            L00DF: Compare(si, 0x06);
            L00E2: if (JumpLessOrEqual) goto L00CF;
            L00E4: return; // RETURN (restoring si);
        }

        private void FnBATTWO_0D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: ShowMessage(player, String06D0); // Arrows rain down upon you from an attacking party of Archers.
            L0011: Compare(PartyCount(player), 0x0001);
            L001C: if (JumpNotEqual) goto L0045;
            L001E: AddEncounter(player, 0x01, 0x1F);
            L0030: AddEncounter(player, 0x05, 0x20);
            L0042: goto L00E4;
            L0045: Compare(PartyCount(player), 0x0002);
            L0050: if (JumpNotEqual) goto L006D;
            L0052: AddEncounter(player, 0x01, 0x1F);
            L0064: PushStack(player, 0x1F);
050E  0068 B8 02 00  mov ax, 0x2
            L006B: goto L0025;
            L006D: Compare(PartyCount(player), 0x0003);
            L0078: if (JumpNotEqual) goto L00B0;
            L007A: si = 0x0001;
            L007D: goto L008F;
            L007F: AddEncounter(player, si, 0x1F);
            L008E: si = si + 1;
            L008F: Compare(si, 0x02);
            L0092: if (JumpLessOrEqual) goto L007F;
            L0094: si = 0x0003;
            L0097: goto L00A9;
            L0099: AddEncounter(player, si, 0x20);
            L00A8: si = si + 1;
            L00A9: Compare(si, 0x05);
            L00AC: if (JumpLessOrEqual) goto L0099;
            L00AE: goto L00E4;
            L00B0: si = 0x0001;
            L00B3: goto L00C5;
            L00B5: AddEncounter(player, si, 0x20);
            L00C4: si = si + 1;
            L00C5: Compare(si, 0x03);
            L00C8: if (JumpLessOrEqual) goto L00B5;
            L00CA: si = 0x0004;
            L00CD: goto L00DF;
            L00CF: AddEncounter(player, si, 0x1F);
            L00DE: si = si + 1;
            L00DF: Compare(si, 0x06);
            L00E2: if (JumpLessOrEqual) goto L00CF;
            L00E4: return; // RETURN (restoring si);
        }

        private void FnBATTHREE_0E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String070E); // Quarrelsome thieves charge you.
            L0010: Compare(PartyCount(player), 0x0001);
            L001B: if (JumpNotEqual) goto L0039;
            L001D: AddEncounter(player, 0x01, 0x23);
            L002F: PushStack(player, 0x24);
05C0  0033 B8 05 00  mov ax, 0x5
            L0036: goto L012F;
            L0039: Compare(PartyCount(player), 0x0002);
            L0044: if (JumpNotEqual) goto L0074;
            L0046: AddEncounter(player, 0x01, 0x23);
            L0058: AddEncounter(player, 0x02, 0x24);
            L006A: PushStack(player, 0x25);
05FB  006E B8 05 00  mov ax, 0x5
            L0071: goto L012F;
            L0074: Compare(PartyCount(player), 0x0003);
            L007F: if (JumpNotEqual) goto L00CE;
            L0081: AddEncounter(player, 0x01, 0x23);
            L0093: AddEncounter(player, 0x02, 0x23);
            L00A5: AddEncounter(player, 0x03, 0x24);
            L00B7: AddEncounter(player, 0x05, 0x25);
0656  00C9 B8 24 00  mov ax, 0x24
            L00CC: goto L012B;
            L00CE: AddEncounter(player, 0x01, 0x23);
            L00E0: AddEncounter(player, 0x02, 0x23);
            L00F2: AddEncounter(player, 0x03, 0x24);
            L0104: AddEncounter(player, 0x04, 0x24);
            L0116: AddEncounter(player, 0x05, 0x25);
            L0128: AddEncounter(player, 0x06, 0x25);
            L013A: return; // RETURN;
        }

        private void FnBATFOUR_0F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x02, 0x12));
            L0016: if (JumpNotEqual) goto L002D;
            L0018: SetFlag(player, 0x02, 0x12, 0x01);
            L002D: ShowMessage(player, String072E); // A party of warriors intend to prevent you from completing this arena.
            L003A: Compare(PartyCount(player), 0x0001);
            L0045: if (JumpNotEqual) goto L0063;
            L0047: AddEncounter(player, 0x01, 0x1E);
            L0059: PushStack(player, 0x28);
0726  005D B8 05 00  mov ax, 0x5
            L0060: goto L0159;
            L0063: Compare(PartyCount(player), 0x0002);
            L006E: if (JumpNotEqual) goto L009E;
            L0070: AddEncounter(player, 0x01, 0x1E);
            L0082: AddEncounter(player, 0x02, 0x1C);
            L0094: PushStack(player, 0x21);
0761  0098 B8 05 00  mov ax, 0x5
            L009B: goto L0159;
            L009E: Compare(PartyCount(player), 0x0003);
            L00A9: if (JumpNotEqual) goto L00F8;
            L00AB: AddEncounter(player, 0x01, 0x21);
            L00BD: AddEncounter(player, 0x02, 0x1D);
            L00CF: AddEncounter(player, 0x03, 0x27);
            L00E1: AddEncounter(player, 0x05, 0x28);
07BC  00F3 B8 1C 00  mov ax, 0x1c
            L00F6: goto L0155;
            L00F8: AddEncounter(player, 0x01, 0x26);
            L010A: AddEncounter(player, 0x02, 0x27);
            L011C: AddEncounter(player, 0x03, 0x28);
            L012E: AddEncounter(player, 0x04, 0x21);
            L0140: AddEncounter(player, 0x05, 0x21);
            L0152: AddEncounter(player, 0x06, 0x21);
            L0164: return; // RETURN;
        }

        private void FnWAITONE_10(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x002B);
            L0010: ShowMessage(player, String0774); // A nervous wizard chatters at you.
            L001D: ShowMessage(player, String0796); // 'There are so many of them. So many...
            L002A: ShowMessage(player, String07BD); // She said I would get great rewards for doing all four, but I know that only one would suffice.'
            L0037: return; // RETURN;
        }

        private void FnQTBATONE_11(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: ShowMessage(player, String081D); // Knights and their squires charge you.
            L0011: Compare(PartyCount(player), 0x0001);
            L001C: if (JumpEqual) goto L0025;
            L001E: Compare(ax, 0x0002);
            L0021: if (JumpEqual) goto L004B;
            L0023: goto L0067;
            L0025: AddEncounter(player, 0x01, 0x22);
            L0037: AddEncounter(player, 0x05, 0x1B);
            L0049: goto L009B;
            L004B: si = 0x0001;
            L004E: goto L0060;
            L0050: AddEncounter(player, si, 0x22);
            L005F: si = si + 1;
            L0060: Compare(si, 0x03);
            L0063: if (JumpLessOrEqual) goto L0050;
            L0065: goto L009B;
            L0067: si = 0x0001;
            L006A: goto L007C;
            L006C: AddEncounter(player, si, 0x1B);
            L007B: si = si + 1;
            L007C: Compare(si, 0x03);
            L007F: if (JumpLessOrEqual) goto L006C;
            L0081: si = 0x0004;
            L0084: goto L0096;
            L0086: AddEncounter(player, si, 0x22);
            L0095: si = si + 1;
            L0096: Compare(si, 0x06);
            L0099: if (JumpLessOrEqual) goto L0086;
            L009B: return; // RETURN (restoring si);
        }

        private void FnQTBATTWO_12(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: ShowMessage(player, String0843); // Gladiators and scavenging rogues take the offensive.
            L0011: Compare(PartyCount(player), 0x0001);
            L001C: if (JumpEqual) goto L0025;
            L001E: Compare(ax, 0x0002);
            L0021: if (JumpEqual) goto L004B;
            L0023: goto L0067;
            L0025: AddEncounter(player, 0x01, 0x19);
            L0037: AddEncounter(player, 0x05, 0x19);
            L0049: goto L009B;
            L004B: si = 0x0001;
            L004E: goto L0060;
            L0050: AddEncounter(player, si, 0x1A);
            L005F: si = si + 1;
            L0060: Compare(si, 0x03);
            L0063: if (JumpLessOrEqual) goto L0050;
            L0065: goto L009B;
            L0067: si = 0x0001;
            L006A: goto L007C;
            L006C: AddEncounter(player, si, 0x19);
            L007B: si = si + 1;
            L007C: Compare(si, 0x04);
            L007F: if (JumpLessOrEqual) goto L006C;
            L0081: si = 0x0005;
            L0084: goto L0096;
            L0086: AddEncounter(player, si, 0x1A);
            L0095: si = si + 1;
            L0096: Compare(si, 0x06);
            L0099: if (JumpLessOrEqual) goto L0086;
            L009B: return; // RETURN (restoring si);
        }

        private void FnQTBATTRE_13(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: ShowMessage(player, String0878); // A hulking colossus towers over you.
            L0011: Compare(PartyCount(player), 0x0001);
            L001C: if (JumpEqual) goto L0025;
            L001E: Compare(ax, 0x0002);
            L0021: if (JumpEqual) goto L0039;
            L0023: goto L0055;
            L0025: AddEncounter(player, 0x01, 0x26);
            L0037: goto L006F;
            L0039: si = 0x0001;
            L003C: goto L004E;
            L003E: AddEncounter(player, si, 0x26);
            L004D: si = si + 1;
            L004E: Compare(si, 0x02);
            L0051: if (JumpLessOrEqual) goto L003E;
            L0053: goto L006F;
            L0055: si = 0x0001;
            L0058: goto L006A;
            L005A: AddEncounter(player, si, 0x26);
            L0069: si = si + 1;
            L006A: Compare(si, 0x04);
            L006D: if (JumpLessOrEqual) goto L005A;
            L006F: return; // RETURN (restoring si);
        }

        private void FnQTBATFOR_14(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x02, 0x13));
            L0016: if (JumpNotEqual) goto L002D;
            L0018: SetFlag(player, 0x02, 0x13, 0x01);
            L002D: ShowMessage(player, String089C); // An odd array of mage and muscle stands before you.
            L003A: Compare(PartyCount(player), 0x0001);
            L0045: if (JumpNotEqual) goto L0063;
            L0047: AddEncounter(player, 0x01, 0x26);
            L0059: PushStack(player, 0x28);
0A73  005D B8 05 00  mov ax, 0x5
            L0060: goto L0159;
            L0063: Compare(PartyCount(player), 0x0002);
            L006E: if (JumpNotEqual) goto L009E;
            L0070: AddEncounter(player, 0x01, 0x26);
            L0082: AddEncounter(player, 0x02, 0x27);
            L0094: PushStack(player, 0x28);
0AAE  0098 B8 05 00  mov ax, 0x5
            L009B: goto L0159;
            L009E: Compare(PartyCount(player), 0x0003);
            L00A9: if (JumpNotEqual) goto L00F8;
            L00AB: AddEncounter(player, 0x01, 0x26);
            L00BD: AddEncounter(player, 0x02, 0x26);
            L00CF: AddEncounter(player, 0x03, 0x27);
            L00E1: AddEncounter(player, 0x05, 0x28);
0B09  00F3 B8 28 00  mov ax, 0x28
            L00F6: goto L0155;
            L00F8: AddEncounter(player, 0x01, 0x26);
            L010A: AddEncounter(player, 0x02, 0x26);
            L011C: AddEncounter(player, 0x03, 0x28);
            L012E: AddEncounter(player, 0x04, 0x28);
            L0140: AddEncounter(player, 0x05, 0x27);
            L0152: AddEncounter(player, 0x06, 0x27);
            L0164: return; // RETURN;
        }

        private void FnROSTER_15(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String08CF); // A roster listing various guilds and names is posted here. Hmmm..your name does not appear on the list!
            L0010: return; // RETURN;
        }

        private void FnQCBATONE_16(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L002B;
            L0010: AddEncounter(player, 0x01, 0x1D);
            L0022: PushStack(player, 0x20);
0BB4  0026 B8 05 00  mov ax, 0x5
            L0029: goto L009E;
            L002B: Compare(PartyCount(player), 0x0002);
            L0036: if (JumpNotEqual) goto L0061;
            L0038: AddEncounter(player, 0x01, 0x1D);
            L004A: AddEncounter(player, 0x02, 0x20);
0BEA  005C B8 22 00  mov ax, 0x22
            L005F: goto L0025;
            L0061: AddEncounter(player, 0x01, 0x1D);
            L0073: AddEncounter(player, 0x02, 0x20);
            L0085: AddEncounter(player, 0x03, 0x22);
            L0097: AddEncounter(player, 0x04, 0x27);
            L00A9: return; // RETURN;
        }

        private void FnQCBATTWO_17(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0936); // Warring gladiators challenge you.
            L0010: Compare(PartyCount(player), 0x0001);
            L001B: if (JumpNotEqual) goto L0039;
            L001D: AddEncounter(player, 0x01, 0x03);
            L002F: PushStack(player, 0x1A);
0C6C  0033 B8 05 00  mov ax, 0x5
            L0036: goto L00BF;
            L0039: Compare(PartyCount(player), 0x0002);
            L0044: if (JumpNotEqual) goto L0061;
            L0046: AddEncounter(player, 0x01, 0x03);
            L0058: PushStack(player, 0x03);
0C95  005C B8 02 00  mov ax, 0x2
            L005F: goto L0024;
            L0061: AddEncounter(player, 0x01, 0x1A);
            L0073: AddEncounter(player, 0x02, 0x03);
            L0085: PushStack(player, 0x03);
            L0089: PushStack(player, ax);
0CC3  008A C4 5E 06  les bx, [bp+0x6]
0CC6  008D 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L0092: cx = PopStack(player);
            L0093: cx = PopStack(player);
            L0094: AddEncounter(player, 0x04, 0x1A);
            L00A6: AddEncounter(player, 0x05, 0x1A);
            L00B8: AddEncounter(player, 0x06, 0x03);
            L00CA: return; // RETURN;
        }

        private void FnQCBATTRE_18(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0958); // Swords and sorcery are unleashed against you.
            L0010: Compare(PartyCount(player), 0x0001);
            L001B: if (JumpNotEqual) goto L0039;
            L001D: AddEncounter(player, 0x01, 0x04);
            L002F: PushStack(player, 0x07);
0D38  0033 B8 05 00  mov ax, 0x5
            L0036: goto L010C;
            L0039: Compare(PartyCount(player), 0x0002);
            L0044: if (JumpNotEqual) goto L0074;
            L0046: AddEncounter(player, 0x01, 0x04);
            L0058: AddEncounter(player, 0x02, 0x07);
            L006A: PushStack(player, 0x07);
0D73  006E B8 05 00  mov ax, 0x5
            L0071: goto L010C;
            L0074: Compare(PartyCount(player), 0x0003);
            L007F: if (JumpNotEqual) goto L00AE;
            L0081: AddEncounter(player, 0x01, 0x04);
            L0093: AddEncounter(player, 0x02, 0x04);
            L00A5: PushStack(player, 0x07);
0DAE  00A9 B8 03 00  mov ax, 0x3
            L00AC: goto L00E8;
            L00AE: AddEncounter(player, 0x01, 0x04);
            L00C0: AddEncounter(player, 0x02, 0x04);
            L00D2: AddEncounter(player, 0x03, 0x04);
            L00E4: PushStack(player, 0x04);
            L00E8: PushStack(player, ax);
0DEE  00E9 C4 5E 06  les bx, [bp+0x6]
0DF1  00EC 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L00F1: cx = PopStack(player);
            L00F2: cx = PopStack(player);
            L00F3: AddEncounter(player, 0x05, 0x07);
            L0105: AddEncounter(player, 0x06, 0x07);
            L0117: return; // RETURN;
        }

        private void FnQCBATFOR_19(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x02, 0x14));
            L0016: if (JumpNotEqual) goto L002D;
            L0018: SetFlag(player, 0x02, 0x14, 0x01);
            L002D: ShowMessage(player, String0986); // The air is filled with bursts of magic as a party of enchanters attacks.
            L003A: Compare(PartyCount(player), 0x0001);
            L0045: if (JumpNotEqual) goto L0063;
            L0047: AddEncounter(player, 0x01, 0x10);
            L0059: PushStack(player, 0x14);
0E7B  005D B8 05 00  mov ax, 0x5
            L0060: goto L0159;
            L0063: Compare(PartyCount(player), 0x0002);
            L006E: if (JumpNotEqual) goto L009E;
            L0070: AddEncounter(player, 0x01, 0x10);
            L0082: AddEncounter(player, 0x02, 0x14);
            L0094: PushStack(player, 0x17);
0EB6  0098 B8 05 00  mov ax, 0x5
            L009B: goto L0159;
            L009E: Compare(PartyCount(player), 0x0003);
            L00A9: if (JumpNotEqual) goto L00F8;
            L00AB: AddEncounter(player, 0x01, 0x10);
            L00BD: AddEncounter(player, 0x02, 0x17);
            L00CF: AddEncounter(player, 0x03, 0x14);
            L00E1: AddEncounter(player, 0x05, 0x17);
0F11  00F3 B8 10 00  mov ax, 0x10
            L00F6: goto L0155;
            L00F8: AddEncounter(player, 0x01, 0x10);
            L010A: AddEncounter(player, 0x02, 0x10);
            L011C: AddEncounter(player, 0x03, 0x17);
            L012E: AddEncounter(player, 0x04, 0x17);
            L0140: AddEncounter(player, 0x05, 0x14);
            L0152: AddEncounter(player, 0x06, 0x14);
            L0164: return; // RETURN;
        }

        private void FnQDBATONE_1A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String09CF); // Undead magi encircle you!
            L0010: Compare(PartyCount(player), 0x0001);
            L001B: if (JumpNotEqual) goto L0039;
            L001D: AddEncounter(player, 0x01, 0x11);
            L002F: PushStack(player, 0x11);
0FB7  0033 B8 05 00  mov ax, 0x5
            L0036: goto L011D;
            L0039: Compare(PartyCount(player), 0x0002);
            L0044: if (JumpNotEqual) goto L0074;
            L0046: AddEncounter(player, 0x01, 0x11);
            L0058: AddEncounter(player, 0x02, 0x13);
            L006A: PushStack(player, 0x13);
0FF2  006E B8 05 00  mov ax, 0x5
            L0071: goto L011D;
            L0074: Compare(PartyCount(player), 0x0003);
            L007F: if (JumpNotEqual) goto L00BC;
            L0081: AddEncounter(player, 0x01, 0x11);
            L0093: AddEncounter(player, 0x02, 0x11);
            L00A5: AddEncounter(player, 0x03, 0x13);
103B  00B7 B8 13 00  mov ax, 0x13
            L00BA: goto L0107;
            L00BC: AddEncounter(player, 0x01, 0x11);
            L00CE: AddEncounter(player, 0x02, 0x11);
            L00E0: AddEncounter(player, 0x03, 0x13);
            L00F2: AddEncounter(player, 0x04, 0x13);
            L0104: AddEncounter(player, 0x05, 0x11);
            L0116: AddEncounter(player, 0x06, 0x13);
            L0128: return; // RETURN;
        }

        private void FnQDBATTWO_1B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: ShowMessage(player, String09E9); // Spirits of magi and bones of thieves charge you.
            L0011: Compare(PartyCount(player), 0x0001);
            L001C: if (JumpNotEqual) goto L0045;
            L001E: AddEncounter(player, 0x01, 0x15);
            L0030: AddEncounter(player, 0x05, 0x0D);
            L0042: goto L00E4;
            L0045: Compare(PartyCount(player), 0x0002);
            L0050: if (JumpNotEqual) goto L006D;
            L0052: AddEncounter(player, 0x01, 0x0D);
            L0064: PushStack(player, 0x15);
1116  0068 B8 02 00  mov ax, 0x2
            L006B: goto L0025;
            L006D: Compare(PartyCount(player), 0x0003);
            L0078: if (JumpNotEqual) goto L00B0;
            L007A: si = 0x0001;
            L007D: goto L008F;
            L007F: AddEncounter(player, si, 0x0D);
            L008E: si = si + 1;
            L008F: Compare(si, 0x03);
            L0092: if (JumpLessOrEqual) goto L007F;
            L0094: si = 0x0005;
            L0097: goto L00A9;
            L0099: AddEncounter(player, si, 0x15);
            L00A8: si = si + 1;
            L00A9: Compare(si, 0x06);
            L00AC: if (JumpLessOrEqual) goto L0099;
            L00AE: goto L00E4;
            L00B0: si = 0x0001;
            L00B3: goto L00C5;
            L00B5: AddEncounter(player, si, 0x0D);
            L00C4: si = si + 1;
            L00C5: Compare(si, 0x03);
            L00C8: if (JumpLessOrEqual) goto L00B5;
            L00CA: si = 0x0004;
            L00CD: goto L00DF;
            L00CF: AddEncounter(player, si, 0x15);
            L00DE: si = si + 1;
            L00DF: Compare(si, 0x06);
            L00E2: if (JumpLessOrEqual) goto L00CF;
            L00E4: return; // RETURN (restoring si);
        }

        private void FnQDBATTRE_1C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0A1A); // Long dead gladiators rise from the dust to attack you!
            L0010: Compare(PartyCount(player), 0x0001);
            L001B: if (JumpNotEqual) goto L0039;
            L001D: AddEncounter(player, 0x01, 0x0B);
            L002F: PushStack(player, 0x0B);
11C8  0033 B8 05 00  mov ax, 0x5
            L0036: goto L012F;
            L0039: Compare(PartyCount(player), 0x0002);
            L0044: if (JumpNotEqual) goto L0074;
            L0046: AddEncounter(player, 0x01, 0x0B);
            L0058: AddEncounter(player, 0x02, 0x09);
            L006A: PushStack(player, 0x09);
1203  006E B8 05 00  mov ax, 0x5
            L0071: goto L012F;
            L0074: Compare(PartyCount(player), 0x0003);
            L007F: if (JumpNotEqual) goto L00CE;
            L0081: AddEncounter(player, 0x01, 0x0B);
            L0093: AddEncounter(player, 0x02, 0x0B);
            L00A5: AddEncounter(player, 0x03, 0x09);
            L00B7: AddEncounter(player, 0x05, 0x0B);
125E  00C9 B8 09 00  mov ax, 0x9
            L00CC: goto L012B;
            L00CE: AddEncounter(player, 0x01, 0x09);
            L00E0: AddEncounter(player, 0x02, 0x09);
            L00F2: AddEncounter(player, 0x03, 0x0B);
            L0104: AddEncounter(player, 0x04, 0x0B);
            L0116: AddEncounter(player, 0x05, 0x09);
            L0128: AddEncounter(player, 0x06, 0x0B);
            L013A: return; // RETURN;
        }

        private void FnQDBATFOR_1D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x02, 0x15));
            L0016: if (JumpNotEqual) goto L002D;
            L0018: SetFlag(player, 0x02, 0x15, 0x01);
            L002D: ShowMessage(player, String0A51); // Assorted undead heroes challenge you at this exit.
            L003A: Compare(PartyCount(player), 0x0001);
            L0045: if (JumpNotEqual) goto L0063;
            L0047: AddEncounter(player, 0x01, 0x09);
            L0059: PushStack(player, 0x0B);
132E  005D B8 05 00  mov ax, 0x5
            L0060: goto L0139;
            L0063: Compare(PartyCount(player), 0x0002);
            L006E: if (JumpNotEqual) goto L009E;
            L0070: AddEncounter(player, 0x01, 0x09);
            L0082: AddEncounter(player, 0x02, 0x0B);
            L0094: PushStack(player, 0x15);
1369  0098 B8 05 00  mov ax, 0x5
            L009B: goto L0139;
            L009E: Compare(PartyCount(player), 0x0003);
            L00A9: if (JumpNotEqual) goto L00D8;
            L00AB: AddEncounter(player, 0x01, 0x09);
            L00BD: AddEncounter(player, 0x02, 0x0D);
            L00CF: PushStack(player, 0x11);
13A4  00D3 B8 03 00  mov ax, 0x3
            L00D6: goto L0115;
            L00D8: AddEncounter(player, 0x01, 0x09);
            L00EA: AddEncounter(player, 0x02, 0x0B);
            L00FC: AddEncounter(player, 0x03, 0x0D);
            L010E: AddEncounter(player, 0x04, 0x11);
            L0120: AddEncounter(player, 0x05, 0x15);
            L0132: AddEncounter(player, 0x06, 0x15);
            L0144: return; // RETURN;
        }

        private void FnSTASHONE_1E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: SetFlag(player, 0x02, 0x18, 0x01);
            L0019: dx = GetFlag(player, 0x02, 0x18) + GetFlag(player, 0x02, 0x19);
            L003F: dx = dx + GetFlag(player, 0x02, 0x1A);
            L0054: dx = dx + GetFlag(player, 0x02, 0x1B);
1480  0069 8B F2  mov si, dx
            L006B: Compare(GetFlag(player, 0x02, 0x1C), si);
            L007E: if (JumpNotBelow) goto L009F;
            L0080: SetFlag(player, 0xC4, 0xB8, si);
            L0092: XCall Fn01E6
            L009D: cx = PopStack(player);
            L009E: cx = PopStack(player);
            L009F: return; // RETURN (restoring si);
        }

        private void FnSTASHTWO_1F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: SetFlag(player, 0x02, 0x19, 0x01);
            L0019: dx = GetFlag(player, 0x02, 0x18) + GetFlag(player, 0x02, 0x19);
            L003F: dx = dx + GetFlag(player, 0x02, 0x1A);
            L0054: dx = dx + GetFlag(player, 0x02, 0x1B);
1522  0069 8B F2  mov si, dx
            L006B: Compare(GetFlag(player, 0x02, 0x1C), si);
            L007E: if (JumpNotBelow) goto L009F;
            L0080: SetFlag(player, 0xC4, 0xB8, si);
            L0092: XCall Fn0144
            L009D: cx = PopStack(player);
            L009E: cx = PopStack(player);
            L009F: return; // RETURN (restoring si);
        }

        private void FnSTASHTRE_20(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: SetFlag(player, 0x02, 0x1A, 0x01);
            L0019: dx = GetFlag(player, 0x02, 0x18) + GetFlag(player, 0x02, 0x19);
            L003F: dx = dx + GetFlag(player, 0x02, 0x1A);
            L0054: dx = dx + GetFlag(player, 0x02, 0x1B);
15C4  0069 8B F2  mov si, dx
            L006B: Compare(GetFlag(player, 0x02, 0x1C), si);
            L007E: if (JumpNotBelow) goto L009F;
            L0080: SetFlag(player, 0xC4, 0xB8, si);
            L0092: XCall Fn00A2
            L009D: cx = PopStack(player);
            L009E: cx = PopStack(player);
            L009F: return; // RETURN (restoring si);
            // Extra data: 55 8B EC 83 EC 08 56 57 B8 1C 00 50 B8 02 00 50 C4 5E 06 26 FF 5F 04 59 59 89 46 F8 8B 5E F8 4B 83 FB 03 77 61 D1 E3 2E FF A7 CE 16 BE CC 00 BF 15 00 C7 46 FE 60 00 C7 46 FC BB 00 C7 46 FA F4 01 EB 43 BE B6 00 BF 20 00 C7 46 FE 5F 00 C7 46 FC 8B 00 C7 46 FA 58 02 EB 2C BE 07 00 BF 63 00 C7 46 FE BD 00 C7 46 FC 76 00 C7 46 FA BC 02 EB 15 BE 1D 00 BF 75 00 C7 46 FE 8C 00 C7 46 FC A4 00 C7 46 FA 20 03 B8 84 0A 50 C4 5E 06 26 FF 9F F8 00 59 56 C4 5E 06 26 FF 5F 48 59 57 C4 5E 06 26 FF 5F 48 59 FF 76 FE C4 5E 06 26 FF 5F 48 59 FF 76 FC C4 5E 06 26 FF 5F 48 59 8B 46 FA 99 52 50 C4 5E 06 26 FF 9F AC 00 59 59 5F 5E 8B E5 5D CB 29 16 40 16 57 16 6E 16 
        }

        private void FnSTASHFOR_21(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: SetFlag(player, 0x02, 0x1B, 0x01);
            L0019: dx = GetFlag(player, 0x02, 0x18) + GetFlag(player, 0x02, 0x19);
            L003F: dx = dx + GetFlag(player, 0x02, 0x1A);
            L0054: dx = dx + GetFlag(player, 0x02, 0x1B);
173F  0069 8B F2  mov si, dx
            L006B: Compare(GetFlag(player, 0x02, 0x1C), si);
            L007E: if (JumpNotBelow) goto L009E;
            L0080: SetFlag(player, 0xC4, 0xB8, si);
1768  0092 FF 76 08  push word [bp+0x8]
176B  0095 FF 76 06  push word [bp+0x6]
176E  0098 0E     push cs
176F  0099 E8 8B FE  call 0xff27
            L009C: cx = PopStack(player);
            L009D: cx = PopStack(player);
            L009E: return; // RETURN (restoring si);
        }

        private void FnDESCRIPA_22(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0AA0); // The sounds of distant combats echo off the surrounding pillars as you enter the first Arena.
            L0010: return; // RETURN;
        }

        private void FnDESCRIPB_23(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0AFD); // Snarls from giants and orcish grunts greet you here in the second Arena.
            L0010: return; // RETURN;
        }

        private void FnDESCRIPC_24(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0B46); // Bursts of magic light momentarily limn the silhouettes of the combatants in this third Arena.
            L0010: return; // RETURN;
        }

        private void FnDESCRIPD_25(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0BA4); // Anguished howls and death wails greet the wary visitor to this fourth Arena.
            L0010: return; // RETURN;
        }

        private void FnROOMDESC_26(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0BF1); // The huge columns of this room act more as barriers than supports.
            L0010: ShowMessage(player, String0C33); // Through the gaps between columns you see bloody combats in what appear to be four different Arenas.
            L001D: return; // RETURN;
        }

        private void FnCLEARSTR_27(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFloorPassable(player, 0x8B, 0x01);
            L0014: SetFloorPassable(player, 0xBA, 0x01);
            L0025: SetFloorPassable(player, 0xC7, 0x01);
            L0036: SetFloorPassable(player, 0xE9, 0x01);
            L0047: SetFloorPassable(player, 0xB0, 0x01);
            L0058: SetFloorPassable(player, 0x83, 0x01);
            L0069: SetFloorPassable(player, 0x40, 0x01);
            L007A: SetFloorPassable(player, 0x26, 0x01);
            L008B: SetFloorPassable(player, 0x38, 0x01);
            L009C: return; // RETURN;
        }

        private void FnCLEARMAG_28(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFloorPassable(player, 0xF6, 0x01);
            L0014: SetFloorPassable(player, 0xC8, 0x01);
            L0025: SetFloorPassable(player, 0x9B, 0x01);
            L0036: SetFloorPassable(player, 0x4B, 0x01);
            L0047: SetFloorPassable(player, 0x19, 0x01);
            L0058: SetFloorPassable(player, 0x65, 0x01);
            L0069: SetFloorPassable(player, 0x49, 0x01);
            L007A: return; // RETURN;
        }

        private void FnRANGTHIF_29(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetGuild(player), 0x0002);
            L000D: if (JumpNotEqual) goto L003D;
            L000F: RefreshCompareFlags(GetSkillLevel(player, 0x13));
            L001D: if (JumpNotEqual) goto L003D;
            L001F: SetSkillLevel(player, 0x13, 0x01);
            L0030: XCall Fn006A
            L003B: goto L0066;
            L003D: Compare(GetGuild(player), 0x0003);
            L0047: if (JumpNotEqual) goto L005B;
            L0049: RefreshCompareFlags(GetSkillLevel(player, 0x13));
            L0057: if (JumpNotEqual) goto L005B;
            L0059: goto L001F;
            L005B: XCall Fn00A0
            L0066: cx = PopStack(player);
            L0067: cx = PopStack(player);
            L0068: return; // RETURN;
            // Extra data: 55 8B EC B8 42 00 50 C4 5E 06 26 FF 9F FC 00 59 B8 97 0C 50 C4 5E 06 26 FF 9F F8 00 59 C4 5E 06 26 FF 5F 74 BB 04 00 99 F7 FB 50 C4 5E 06 26 FF 9F 94 00 59 5D CB 55 8B EC B8 42 00 50 C4 5E 06 26 FF 9F FC 00 59 B8 CD 0C 50 C4 5E 06 26 FF 9F F8 00 59 5D CB 
        }

        private void FnHAILFNTN_2A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetGuild(player), 0x0005);
            L000D: if (JumpEqual) goto L001B;
            L000F: Compare(GetGuild(player), 0x0004);
            L0019: if (JumpNotEqual) goto L0064;
            L001B: RefreshCompareFlags(GetFlag(player, 0x02, 0xDA));
            L002E: if (JumpNotEqual) goto L0070;
            L0030: SetSpellLevel(player, 0x07, 0x01);
19F8  0041 FF 76 08  push word [bp+0x8]
19FB  0044 FF 76 06  push word [bp+0x6]
19FE  0047 0E     push cs
19FF  0048 E8 60 FF  call 0xffab
            L004B: cx = PopStack(player);
            L004C: cx = PopStack(player);
            L004D: SetFlag(player, 0x02, 0xDA, 0x01);
            L0062: goto L0070;
1A1B  0064 FF 76 08  push word [bp+0x8]
1A1E  0067 FF 76 06  push word [bp+0x6]
1A21  006A 0E     push cs
1A22  006B E8 73 FF  call 0xffe1
            L006E: cx = PopStack(player);
            L006F: cx = PopStack(player);
            L0070: return; // RETURN;
        }

        private void FnCLERICFN_2B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetGuild(player), 0x0004);
            L000D: if (JumpNotEqual) goto L0055;
            L000F: RefreshCompareFlags(GetFlag(player, 0x02, 0xD4));
            L0022: if (JumpNotEqual) goto L0055;
            L0024: PushStack(player, 0x01);
            L0028: PushStack(player, 0x00);
1A54  002B C4 5E 06  les bx, [bp+0x6]
1A57  002E 26 FF 5F 68  call far word [es:bx+0x68]
            L0032: cx = PopStack(player);
            L0033: cx = PopStack(player);
            L0034: SetFlag(player, 0x02, 0xD4, 0x01);
1A72  0049 FF 76 08  push word [bp+0x8]
1A75  004C FF 76 06  push word [bp+0x6]
1A78  004F 0E     push cs
1A79  0050 E8 E6 FE  call 0xff39
            L0053: goto L005F;
1A7E  0055 FF 76 08  push word [bp+0x8]
1A81  0058 FF 76 06  push word [bp+0x6]
1A84  005B 0E     push cs
1A85  005C E8 10 FF  call 0xff6f
            L005F: cx = PopStack(player);
            L0060: cx = PopStack(player);
            L0061: return; // RETURN;
        }

        private void FnWHATNOW_2C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0x17), 0x0004);
            L0017: if (JumpNotBelow) goto L001E;
1AA5  0019 B8 01 0D  mov ax, 0xd01
            L001C: goto L0021;
            L001E: ShowMessage(player, String0694); // There's nothing more for you here.
            L002B: return; // RETURN;
        }

        private void FnBLOCKWAL_2D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0020: return; // RETURN;
        }

        private void FnTOQUENAQ_2E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0D51); // Markings here read- 'One way! To The Queen's Aqueduct.'
            L0010: TeleportParty(player, 0x02, 0x01, 0x05, 0x01, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnTOCORE_2F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0D89); // One way! Back to the Coliseum's Core.
            L0010: TeleportParty(player, 0x03, 0x01, 0x88, 0x01, isForwardMove);
            L002B: return; // RETURN;
        }

    }
}
