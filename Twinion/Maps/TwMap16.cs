#pragma warning disable
using System.Collections.Generic;
using XPT.WorldData;
using XPT.WorldData.Yserbius;

namespace XPT.Scripts.Twinion.Maps {
    class TwMap16 : AMapScripted {
        protected override int MapIndex => 16;
        protected override int RandomEncounterChance => 10;
        protected override int RandomEncounterExtraCount => 1;

        public TwMap16() {
            MapEvent01 = FnSECGREM_01;
            MapEvent02 = FnSECA_02;
            MapEvent03 = FnSECB_03;
            MapEvent04 = FnGENTXT_04;
            MapEvent05 = FnTELOA_05;
            MapEvent06 = FnCLUEMAP_06;
            MapEvent07 = FnTEXTWE_07;
            MapEvent08 = FnWEAPE_08;
            MapEvent09 = FnSECE_09;
            MapEvent0A = FnFTNUNI_0A;
            MapEvent0B = FnTHIEF_0B;
            MapEvent0C = FnLADY_0C;
            MapEvent0D = FnSECHUM_0D;
            MapEvent0E = FnTELOB_0E;
            MapEvent0F = FnNPCCLUEA_0F;
            MapEvent10 = FnNPCCLUEB_10;
            MapEvent11 = FnWATER_11;
            MapEvent13 = FnMAPA_13;
            MapEvent16 = FnTELOD_16;
            MapEvent17 = FnGOODIEA_17;
            MapEvent19 = FnSECELF_19;
            MapEvent1A = FnSECDWA_1A;
            MapEvent1F = FnTEXTWF_1F;
            MapEvent21 = FnFTNGREM_21;
            MapEvent25 = FnSECGNO_25;
            MapEvent28 = FnTEXTWG_28;
            MapEvent2B = FnFTNHALF_2B;
            MapEvent2D = FnTELOE_2D;
            MapEvent2F = FnTELOF_2F;
            MapEvent30 = FnFTNTR_30;
            MapEvent31 = FnFTNHUM_31;
            MapEvent33 = FnTELOG_33;
            MapEvent35 = FnSECHALF_35;
            MapEvent38 = FnGOODIEB_38;
            MapEvent39 = FnSECTRO_39;
            MapEvent3A = FnTEXTWH_3A;
            MapEvent3E = FnSECORC_3E;
            MapEvent45 = FnSECMSG_45;
            MapEvent46 = FnGOODIEC_46;
            MapEvent48 = FnMEDA_48;
            MapEvent49 = FnEZA_49;
            MapEvent4A = FnHRDA_4A;
            MapEvent4B = FnEZB_4B;
            MapEvent4D = FnMEDD_4D;
            MapEvent4E = FnEZC_4E;
            MapEvent4F = FnMEDB_4F;
            MapEvent50 = Fn_50;
        }
        
        // === Strings ================================================
        private const string String03FC = "You find a cleverly disguised door.";
        private const string String0420 = "You are surprised by a group of monsters who attack!";
        private const string String0455 = "'At last! I've found my weapon, a clue and a map piece!'";
        private const string String048E = "The elf looks at you with a broad grin, 'It's my fourth and final piece you know. Now all I have to do is find my way out of here.'";
        private const string String0512 = "She slips a Skeleton Key into her bag and turns to leave. 'Good luck in your search!'";
        private const string String0568 = "Use the Ebony before the Coral.";
        private const string String0588 = "You successfully unlock the door.";
        private const string String05AA = "You see a door appear in the wall, but it is locked.";
        private const string String05DF = "The crystal waters of Unity Fountain teach you the Staff skill.";
        private const string String061F = "The crystal waters of Unity Fountain heal and restore mana for all races.";
        private const string String0669 = "The crystal waters of Unity Fountain teach you the Bless spell.";
        private const string String06A9 = "The crystal waters of Unity Fountain teaches you the Rune Reading skill.";
        private const string String06F2 = "A thief emerges from the shadows.";
        private const string String0714 = "'Psssst...let me give you some advice. Some of the walls in these rooms have been weakened. Just push and see!'";
        private const string String0784 = "As he walks off winking, he looks back and says, 'Oh, I hope you visited Snicker again. He has appropriated a Ring of Thieves which will come in handy in here. It will show you unseen pathways.'";
        private const string String0847 = "'Hehehehehe!  A champion you wish to be, yet things you must learn. Some doors here are to deceive, not to open. Learn it well.";
        private const string String08C7 = "By the way, you did bring your reforged Skeleton Key with you, didn't you?'";
        private const string String0913 = "'My brother thief forgot to mention that neither word uses the first letter.";
        private const string String0960 = "The second and last are most important.";
        private const string String0988 = "Oh, and the one that uses the last also lacks two letters. But it will become obvious to you when time and place are right.'";
        private const string String0A05 = "'Ah-h-h! This dungeon has driven me half-mad!";
        private const string String0A33 = "Further down I found this nexus area that was nothing but doors, doors, doors!";
        private const string String0A82 = "Fortunately, almost all that opened - notice I say 'almost' - required no special key or lockpick or skill.";
        private const string String0AEE = "Still, if I could get my hands around the neck of the maniac who designed that place, I would... Oh, how I would love to squeeze and squeeze until the eyes popped out!'";
        private const string String0B97 = "You feel nauseous as you step through the stagnant puddle of water.";
        private const string String0BDB = "You feel a chill as you stumble upon ice monsters.";
        private const string String0C0E = "Use the Coral third.";
        private const string String0C23 = "The waters of Gremlin Fountain refresh you and restore your mana.";
        private const string String0C65 = "The waters of Gremlin Fountain have no affect.";
        private const string String0C94 = "The waters of Halfling Fountain refresh and replenish you.";
        private const string String0CCF = "The waters of Halfling Fountain have no affect.";
        private const string String0CFF = "The waters of Troll Fountain invigorate you and restore your mana.";
        private const string String0D42 = "The waters of Troll Fountain have no affect.";
        private const string String0D6F = "The waters of Human Fountain rejuvenate you.";
        private const string String0D9C = "The waters of Human Fountain have no affect.";
        private const string String0DC9 = "As you approach a battle, the combatants turn and attack you.";
        private const string String0E07 = "Use the Opal before the Coral.";
        private const string String0E26 = "You watch as passers-by clutch their magic-casting rings and uncover secret passages.";
        private const string String0E7C = "A party of lost adventurers arguing about directions turns and attacks.";
        private const string String0EC4 = "The door springs open.";
        private const string String0EDB = "You see a skull and crossbones scratched into the door.";
        private const string String0F13 = "You glimpse a scrap of leather on the floor.";
        private const string String0F40 = "It is a Leather Map and is one of the four Queen Aeowyn sent you to find.";
        private const string String0F8A = "The room is empty.";
        
        // === Functions ================================================
        private void FnSECGREM_01(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetRace(player), 0x0007);
            L000D: if (JumpNotEqual) goto L001C;
001C  000F FF 76 08  push word [bp+0x8]
001F  0012 FF 76 06  push word [bp+0x6]
0022  0015 0E     push cs
0023  0016 E8 D0 12  call 0x12e9
            L0019: // NOP
            L001A: cx = PopStack(player);
            L001B: cx = PopStack(player);
            L001C: return; // RETURN;
        }

        private void FnSECA_02(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0021: return; // RETURN;
        }

        private void FnSECB_03(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, 0x0D), 0x0006);
            L0012: if (JumpNotBelow) goto L006C;
            L0014: RefreshCompareFlags(HasUsedSpell(player, 0x17));
            L0022: if (JumpNotEqual) goto L006C;
            L0024: PushStack(player, 0x68);
            L0028: PushStack(player, ax);
0077  0029 C4 5E 06  les bx, [bp+0x6]
007A  002C 26 FF 5F 54  call far word [es:bx+0x54]
            L0030: cx = PopStack(player);
            L0031: cx = PopStack(player);
            L0032: RefreshCompareFlags(ax);
            L0034: if (JumpNotEqual) goto L006C;
            L0036: PushStack(player, 0x6E);
            L003A: PushStack(player, ax);
0089  003B C4 5E 06  les bx, [bp+0x6]
008C  003E 26 FF 5F 54  call far word [es:bx+0x54]
            L0042: cx = PopStack(player);
            L0043: cx = PopStack(player);
            L0044: RefreshCompareFlags(ax);
            L0046: if (JumpNotEqual) goto L006C;
            L0048: PushStack(player, 0x90);
            L004C: PushStack(player, ax);
009B  004D C4 5E 06  les bx, [bp+0x6]
009E  0050 26 FF 5F 54  call far word [es:bx+0x54]
            L0054: cx = PopStack(player);
            L0055: cx = PopStack(player);
            L0056: RefreshCompareFlags(ax);
            L0058: if (JumpNotEqual) goto L006C;
            L005A: PushStack(player, 0xA4);
            L005E: PushStack(player, ax);
00AD  005F C4 5E 06  les bx, [bp+0x6]
00B0  0062 26 FF 5F 54  call far word [es:bx+0x54]
            L0066: cx = PopStack(player);
            L0067: cx = PopStack(player);
            L0068: RefreshCompareFlags(ax);
            L006A: if (JumpEqual) goto L0093;
            L006C: ShowMessage(player, String03FC); // You find a cleverly disguised door.
00C7  0079 FF 76 08  push word [bp+0x8]
00CA  007C FF 76 06  push word [bp+0x6]
00CD  007F 0E     push cs
00CE  0080 E8 4E 13  call 0x13d1
            L0083: // NOP
            L0084: cx = PopStack(player);
            L0085: cx = PopStack(player);
00D4  0086 FF 76 08  push word [bp+0x8]
00D7  0089 FF 76 06  push word [bp+0x6]
00DA  008C 0E     push cs
00DB  008D E8 DB 12  call 0x136b
            L0090: // NOP
            L0091: goto L009E;
00E1  0093 FF 76 08  push word [bp+0x8]
00E4  0096 FF 76 06  push word [bp+0x6]
00E7  0099 0E     push cs
00E8  009A E8 F1 12  call 0x138e
            L009D: // NOP
            L009E: cx = PopStack(player);
            L009F: cx = PopStack(player);
            L00A0: return; // RETURN;
        }

        private void FnGENTXT_04(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0420); // You are surprised by a group of monsters who attack!
            L0010: return; // RETURN;
        }

        private void FnTELOA_05(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x06, 0x02, 0xA0, 0x02, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnCLUEMAP_06(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x02, 0x51));
            L0016: if (JumpNotEqual) goto L004C;
            L0018: ShowPortrait(player, 0x0018);
            L0025: ShowMessage(player, String0455); // 'At last! I've found my weapon, a clue and a map piece!'
            L0032: ShowMessage(player, String048E); // The elf looks at you with a broad grin, 'It's my fourth and final piece you know. Now all I have to do is find my way out of here.'
            L003F: ShowMessage(player, String0512); // She slips a Skeleton Key into her bag and turns to leave. 'Good luck in your search!'
            L004C: return; // RETURN;
        }

        private void FnTEXTWE_07(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetRace(player), 0x0007);
            L000D: if (JumpNotEqual) goto L001C;
            L000F: ShowMessage(player, String0568); // Use the Ebony before the Coral.
            L001C: return; // RETURN;
        }

        private void FnWEAPE_08(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: // make space for tmp on stack: sp -= 2
0193  0005 56     push si
0194  0006 57     push di
            L0007: di = 0;
            L0009: si = 0;
            L000B: ax = HasItem(player, 0x3A);
            L0019: if (JumpNotEqual) goto L002B;
            L001B: ax = HasItem(player, 0x0D);
            L0029: if (JumpEqual) goto L002E;
            L002B: goto L00AB;
            L002D: // NOP
            L002E: Compare(GetGuild(player), 0x0001);
            L0038: if (JumpEqual) goto L0046;
            L003A: Compare(ax, 0x0003);
            L003D: if (JumpEqual) goto L0046;
            L003F: Compare(ax, 0x0005);
            L0042: if (JumpEqual) goto L0046;
            L0044: goto L004B;
            L0046: di = 0x000D;
            L0049: goto L004E;
            L004B: di = 0x003A;
            L004E: ax = GetCurrentTile(player);
01E3  0055 89 46 FE  mov [bp-0x2], ax
01E6  0058 B9 04 00  mov cx, 0x4
            L005B: bx = 0x02D8;
01EC  005E 2E 8B 07  mov ax, [cs:bx]
01EF  0061 3B 46 FE  cmp ax, [bp-0x2]
            L0064: if (JumpEqual) goto L006C;
01F4  0066 43     inc bx
01F5  0067 43     inc bx
01F6  0068 E2 F4  loop 0x5e
            L006A: goto L0082;
01FA  006C 2E FF 67 08  jmp word [cs:bx+0x8]
            L0070: si = 0x0007;
            L0073: goto L0082;
            L0075: si = 0x0002;
            L0078: goto L0082;
            L007A: si = 0x0005;
            L007D: goto L0082;
            L007F: si = 0x0003;
            L0082: Compare(GetRace(player), si);
            L008B: if (JumpNotEqual) goto L00AB;
021B  008D B8 B8 0B  mov ax, 0xbb8
            L0090: PushStack(player, ax);
            L0091: PushStack(player, 0x00);
            L0094: PushStack(player, ax);
            L0095: PushStack(player, 0xB6);
            L0099: PushStack(player, 0xC0);
022B  009D 57     push di
022C  009E C4 5E 06  les bx, [bp+0x6]
022F  00A1 26 FF 9F D8 00  call far word [es:bx+0xd8]
0234  00A6 83 C4 0C  add sp, 0xc
            L00A9: goto L00B8;
0239  00AB FF 76 08  push word [bp+0x8]
023C  00AE FF 76 06  push word [bp+0x6]
023F  00B1 0E     push cs
0240  00B2 E8 BB 11  call 0x1270
            L00B5: // NOP
            L00B6: cx = PopStack(player);
            L00B7: cx = PopStack(player);
            L00B8: Compare(PartyCount(player), 0x0001);
            L00C3: if (JumpEqual) goto L00CC;
            L00C5: Compare(ax, 0x0002);
            L00C8: if (JumpEqual) goto L00D5;
            L00CA: goto L00FF;
            L00CC: PushStack(player, 0x1A);
025E  00D0 B8 01 00  mov ax, 0x1
            L00D3: goto L0139;
            L00D5: AddEncounter(player, 0x01, 0x02);
            L00E7: PushStack(player, 0x02);
            L00EB: PushStack(player, ax);
027A  00EC C4 5E 06  les bx, [bp+0x6]
027D  00EF 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L00F4: cx = PopStack(player);
            L00F5: cx = PopStack(player);
            L00F6: PushStack(player, 0x19);
0288  00FA B8 05 00  mov ax, 0x5
            L00FD: goto L0139;
            L00FF: AddEncounter(player, 0x01, 0x02);
            L0111: PushStack(player, 0x02);
            L0115: PushStack(player, ax);
02A4  0116 C4 5E 06  les bx, [bp+0x6]
02A7  0119 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L011E: cx = PopStack(player);
            L011F: cx = PopStack(player);
            L0120: AddEncounter(player, 0x05, 0x19);
            L0132: AddEncounter(player, 0x06, 0x1A);
02D2  0144 5F     pop di
02D3  0145 5E     pop si
            L0146: // restore stack ptr: sp = bp;
            L0148: return; // RETURN;
            // Extra data: 18 00 61 00 8A 00 D6 00 FE 01 03 02 08 02 0D 02 
        }

        private void FnSECE_09(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, 0x0D), 0x0006);
            L0012: if (JumpNotBelow) goto L0083;
            L0014: RefreshCompareFlags(HasUsedSpell(player, 0x17));
            L0022: if (JumpNotEqual) goto L0083;
            L0024: PushStack(player, 0x68);
            L0028: PushStack(player, ax);
0311  0029 C4 5E 06  les bx, [bp+0x6]
0314  002C 26 FF 5F 54  call far word [es:bx+0x54]
            L0030: cx = PopStack(player);
            L0031: cx = PopStack(player);
            L0032: RefreshCompareFlags(ax);
            L0034: if (JumpNotEqual) goto L0083;
            L0036: PushStack(player, 0x6E);
            L003A: PushStack(player, ax);
0323  003B C4 5E 06  les bx, [bp+0x6]
0326  003E 26 FF 5F 54  call far word [es:bx+0x54]
            L0042: cx = PopStack(player);
            L0043: cx = PopStack(player);
            L0044: RefreshCompareFlags(ax);
            L0046: if (JumpNotEqual) goto L0083;
            L0048: PushStack(player, 0x90);
            L004C: PushStack(player, ax);
0335  004D C4 5E 06  les bx, [bp+0x6]
0338  0050 26 FF 5F 54  call far word [es:bx+0x54]
            L0054: cx = PopStack(player);
            L0055: cx = PopStack(player);
            L0056: RefreshCompareFlags(ax);
            L0058: if (JumpNotEqual) goto L0083;
            L005A: PushStack(player, 0xA4);
            L005E: PushStack(player, ax);
0347  005F C4 5E 06  les bx, [bp+0x6]
034A  0062 26 FF 5F 54  call far word [es:bx+0x54]
            L0066: cx = PopStack(player);
            L0067: cx = PopStack(player);
            L0068: RefreshCompareFlags(ax);
            L006A: if (JumpNotEqual) goto L0083;
            L006C: ax = IsFlagOn(player, 0x00, 0x01);
            L007E: if (JumpNotEqual) goto L0083;
            L0080: goto L0119;
            L0083: PushStack(player, 0x01);
            L0087: PushStack(player, ax);
            L0088: PushStack(player, 0x00);
0373  008B C4 5E 06  les bx, [bp+0x6]
0376  008E 26 FF 1F  call far word [es:bx]
0379  0091 83 C4 06  add sp, 0x6
            L0094: PushStack(player, 0xC0);
            L0098: PushStack(player, ax);
0381  0099 C4 5E 06  les bx, [bp+0x6]
0384  009C 26 FF 5F 54  call far word [es:bx+0x54]
            L00A0: cx = PopStack(player);
            L00A1: cx = PopStack(player);
            L00A2: RefreshCompareFlags(ax);
            L00A4: if (JumpNotEqual) goto L00C9;
            L00A6: PushStack(player, 0x6F);
            L00AA: PushStack(player, ax);
0393  00AB C4 5E 06  les bx, [bp+0x6]
0396  00AE 26 FF 5F 54  call far word [es:bx+0x54]
            L00B2: cx = PopStack(player);
            L00B3: cx = PopStack(player);
            L00B4: RefreshCompareFlags(ax);
            L00B6: if (JumpNotEqual) goto L00C9;
            L00B8: Compare(HasUsedSkill(player, 0x0E), 0x0008);
            L00C7: if (JumpBelow) goto L00F0;
            L00C9: ShowMessage(player, String0588); // You successfully unlock the door.
03BE  00D6 FF 76 08  push word [bp+0x8]
03C1  00D9 FF 76 06  push word [bp+0x6]
03C4  00DC 0E     push cs
03C5  00DD E8 57 10  call 0x1137
            L00E0: // NOP
            L00E1: cx = PopStack(player);
            L00E2: cx = PopStack(player);
03CB  00E3 FF 76 08  push word [bp+0x8]
03CE  00E6 FF 76 06  push word [bp+0x6]
03D1  00E9 0E     push cs
03D2  00EA E8 E4 0F  call 0x10d1
            L00ED: // NOP
            L00EE: goto L0124;
03D8  00F0 FF 76 08  push word [bp+0x8]
03DB  00F3 FF 76 06  push word [bp+0x6]
03DE  00F6 0E     push cs
03DF  00F7 E8 FA 0F  call 0x10f4
            L00FA: // NOP
            L00FB: cx = PopStack(player);
            L00FC: cx = PopStack(player);
03E5  00FD FF 76 08  push word [bp+0x8]
03E8  0100 FF 76 06  push word [bp+0x6]
03EB  0103 0E     push cs
03EC  0104 E8 30 10  call 0x1137
            L0107: // NOP
            L0108: cx = PopStack(player);
            L0109: cx = PopStack(player);
            L010A: ShowMessage(player, String05AA); // You see a door appear in the wall, but it is locked.
            L0117: goto L0126;
0401  0119 FF 76 08  push word [bp+0x8]
0404  011C FF 76 06  push word [bp+0x6]
0407  011F 0E     push cs
0408  0120 E8 D1 0F  call 0x10f4
            L0123: // NOP
            L0124: cx = PopStack(player);
            L0125: cx = PopStack(player);
            L0126: return; // RETURN;
        }

        private void FnFTNUNI_0A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0042);
            L0010: RefreshCompareFlags(GetGuild(player));
            L0019: if (JumpEqual) goto L003F;
            L001B: Compare(GetGuild(player), 0x0004);
            L0025: if (JumpEqual) goto L003F;
            L0027: Compare(GetGuild(player), 0x0002);
            L0031: if (JumpEqual) goto L003F;
            L0033: Compare(GetGuild(player), 0x0001);
            L003D: if (JumpNotEqual) goto L0090;
            L003F: RefreshCompareFlags(GetSkillLevel(player, 0x15));
            L004D: if (JumpNotEqual) goto L0073;
045F  004F FF 76 08  push word [bp+0x8]
0462  0052 FF 76 06  push word [bp+0x6]
0465  0055 0E     push cs
0466  0056 E8 2D 0F  call 0xf86
            L0059: // NOP
            L005A: cx = PopStack(player);
            L005B: cx = PopStack(player);
            L005C: SetSkillLevel(player, 0x15, 0x01);
047D  006D B8 DF 05  mov ax, 0x5df
            L0070: goto L013A;
            L0073: ShowMessage(player, String061F); // The crystal waters of Unity Fountain heal and restore mana for all races.
0490  0080 FF 76 08  push word [bp+0x8]
0493  0083 FF 76 06  push word [bp+0x6]
0496  0086 0E     push cs
0497  0087 E8 FC 0E  call 0xf86
            L008A: // NOP
            L008B: cx = PopStack(player);
            L008C: cx = PopStack(player);
            L008D: goto L0144;
            L0090: Compare(GetGuild(player), 0x0005);
            L009A: if (JumpNotEqual) goto L00EB;
            L009C: RefreshCompareFlags(GetFlag(player, 0x02, 0xD6));
            L00AF: if (JumpNotEqual) goto L00E9;
04C1  00B1 FF 76 08  push word [bp+0x8]
04C4  00B4 FF 76 06  push word [bp+0x6]
04C7  00B7 0E     push cs
04C8  00B8 E8 CB 0E  call 0xf86
            L00BB: // NOP
            L00BC: cx = PopStack(player);
            L00BD: cx = PopStack(player);
            L00BE: SetSpellLevel(player, 0x12, 0x01);
            L00CF: SetFlag(player, 0x02, 0xD6, 0x01);
04F4  00E4 B8 69 06  mov ax, 0x669
            L00E7: goto L013A;
            L00E9: goto L012A;
            L00EB: Compare(GetGuild(player), 0x0003);
            L00F5: if (JumpNotEqual) goto L0144;
            L00F7: RefreshCompareFlags(GetSkillLevel(player, 0x14));
            L0105: if (JumpNotEqual) goto L012A;
0517  0107 FF 76 08  push word [bp+0x8]
051A  010A FF 76 06  push word [bp+0x6]
051D  010D 0E     push cs
051E  010E E8 75 0E  call 0xf86
            L0111: // NOP
            L0112: cx = PopStack(player);
            L0113: cx = PopStack(player);
            L0114: SetSkillLevel(player, 0x14, 0x01);
0535  0125 B8 A9 06  mov ax, 0x6a9
            L0128: goto L013A;
053A  012A FF 76 08  push word [bp+0x8]
053D  012D FF 76 06  push word [bp+0x6]
0540  0130 0E     push cs
0541  0131 E8 52 0E  call 0xf86
            L0134: // NOP
            L0135: cx = PopStack(player);
            L0136: cx = PopStack(player);
            L0137: ShowMessage(player, String061F); // The crystal waters of Unity Fountain heal and restore mana for all races.
            L0144: return; // RETURN;
        }

        private void FnTHIEF_0B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x02, 0x51));
            L0016: if (JumpNotEqual) goto L004C;
            L0018: ShowPortrait(player, 0x0026);
            L0025: ShowMessage(player, String06F2); // A thief emerges from the shadows.
            L0032: ShowMessage(player, String0714); // 'Psssst...let me give you some advice. Some of the walls in these rooms have been weakened. Just push and see!'
            L003F: ShowMessage(player, String0784); // As he walks off winking, he looks back and says, 'Oh, I hope you visited Snicker again. He has appropriated a Ring of Thieves which will come in handy in here. It will show you unseen pathways.'
            L004C: return; // RETURN;
        }

        private void FnLADY_0C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x02, 0x51));
            L0016: if (JumpNotEqual) goto L003F;
            L0018: ShowPortrait(player, 0x002C);
            L0025: ShowMessage(player, String0847); // 'Hehehehehe!  A champion you wish to be, yet things you must learn. Some doors here are to deceive, not to open. Learn it well.
            L0032: ShowMessage(player, String08C7); // By the way, you did bring your reforged Skeleton Key with you, didn't you?'
            L003F: return; // RETURN;
        }

        private void FnSECHUM_0D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetRace(player));
            L000C: if (JumpNotEqual) goto L001B;
05F3  000E FF 76 08  push word [bp+0x8]
05F6  0011 FF 76 06  push word [bp+0x6]
05F9  0014 0E     push cs
05FA  0015 E8 F9 0C  call 0xd11
            L0018: // NOP
            L0019: cx = PopStack(player);
            L001A: cx = PopStack(player);
            L001B: return; // RETURN;
        }

        private void FnTELOB_0E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x06, 0x02, 0x20, 0x02, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnNPCCLUEA_0F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0023);
            L0010: ShowMessage(player, String0913); // 'My brother thief forgot to mention that neither word uses the first letter.
            L001D: ShowMessage(player, String0960); // The second and last are most important.
            L002A: ShowMessage(player, String0988); // Oh, and the one that uses the last also lacks two letters. But it will become obvious to you when time and place are right.'
            L0037: return; // RETURN;
        }

        private void FnNPCCLUEB_10(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0021);
            L0010: ShowMessage(player, String0A05); // 'Ah-h-h! This dungeon has driven me half-mad!
            L001D: ShowMessage(player, String0A33); // Further down I found this nexus area that was nothing but doors, doors, doors!
            L002A: ShowMessage(player, String0A82); // Fortunately, almost all that opened - notice I say 'almost' - required no special key or lockpick or skill.
            L0037: ShowMessage(player, String0AEE); // Still, if I could get my hands around the neck of the maniac who designed that place, I would... Oh, how I would love to squeeze and squeeze until the eyes popped out!'
            L0044: return; // RETURN;
        }

        private void FnWATER_11(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetNoHealZone(player);
            L000B: PushStack(player, 0x02);
            L000F: PushStack(player, 0x00);
06B3  0012 C4 5E 06  les bx, [bp+0x6]
06B6  0015 26 FF 5F 04  call far word [es:bx+0x4]
            L0019: cx = PopStack(player);
            L001A: cx = PopStack(player);
            L001B: RefreshCompareFlags(ax);
            L001D: if (JumpNotEqual) goto L0057;
            L001F: ax = GetMaxHits(player);
            L0026: bx = 0x0004;
            L0029: dx = ax % bx; ax = ax / bx;
            L002C: DamagePlayer(player, ax);
            L0036: ShowMessage(player, String0B97); // You feel nauseous as you step through the stagnant puddle of water.
            L0043: SetFlag(player, 0x00, 0x02, 0x01);
            L0057: return; // RETURN;
        }

        private void FnMAPA_13(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: // make space for tmp on stack: sp -= 2
0704  0005 56     push si
            L0006: ax = GetCurrentTile(player);
070C  000D 89 46 FE  mov [bp-0x2], ax
070F  0010 B9 04 00  mov cx, 0x4
            L0013: bx = 0x07B2;
0715  0016 2E 8B 07  mov ax, [cs:bx]
0718  0019 3B 46 FE  cmp ax, [bp-0x2]
            L001C: if (JumpEqual) goto L0024;
071D  001E 43     inc bx
071E  001F 43     inc bx
071F  0020 E2 F4  loop 0x16
            L0022: goto L0039;
0723  0024 2E FF 67 08  jmp word [cs:bx+0x8]
            L0028: si = 0;
            L002A: goto L0039;
            L002C: si = 0x0006;
            L002F: goto L0039;
            L0031: si = 0x0001;
            L0034: goto L0039;
            L0036: si = 0x0004;
            L0039: ax = HasItem(player, 0xD5);
            L0047: if (JumpEqual) goto L004B;
            L0049: goto L00A1;
            L004B: Compare(GetRace(player), si);
            L0054: if (JumpNotEqual) goto L00A1;
            L0056: RefreshCompareFlags(GetFlag(player, 0x02, 0x51));
            L0069: if (JumpNotEqual) goto L009F;
            L006B: SetFlag(player, 0x02, 0x51, 0x01);
            L0080: AddExperience(player, 0x00030D40);
0791  0092 FF 76 08  push word [bp+0x8]
0794  0095 FF 76 06  push word [bp+0x6]
0797  0098 0E     push cs
0798  0099 E8 BE 0B  call 0xc5a
            L009C: // NOP
            L009D: goto L00AC;
            L009F: goto L0092;
07A0  00A1 FF 76 08  push word [bp+0x8]
07A3  00A4 FF 76 06  push word [bp+0x6]
07A6  00A7 0E     push cs
07A7  00A8 E8 DA 0B  call 0xc85
            L00AB: // NOP
            L00AC: cx = PopStack(player);
            L00AD: cx = PopStack(player);
07AD  00AE 5E     pop si
            L00AF: // restore stack ptr: sp = bp;
            L00B1: return; // RETURN;
            // Extra data: 3A 00 57 00 B1 00 DC 00 27 07 35 07 2B 07 30 07 
        }

        private void FnTELOD_16(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x06, 0x02, 0x69, 0x01, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnGOODIEA_17(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
07EF  0003 B8 C4 09  mov ax, 0x9c4
            L0006: PushStack(player, ax);
            L0007: PushStack(player, 0x00);
            L000A: PushStack(player, ax);
            L000B: PushStack(player, ax);
            L000C: PushStack(player, 0xCC);
            L0010: PushStack(player, 0xB3);
0800  0014 C4 5E 06  les bx, [bp+0x6]
0803  0017 26 FF 9F D8 00  call far word [es:bx+0xd8]
0808  001C 83 C4 0C  add sp, 0xc
            L001F: ShowMessage(player, String0BDB); // You feel a chill as you stumble upon ice monsters.
            L002C: Compare(PartyCount(player), 0x0001);
            L0037: if (JumpNotEqual) goto L0043;
            L0039: PushStack(player, 0x11);
0829  003D B8 01 00  mov ax, 0x1
            L0040: goto L00CC;
            L0043: Compare(PartyCount(player), 0x0002);
            L004E: if (JumpNotEqual) goto L007D;
            L0050: AddEncounter(player, 0x01, 0x0E);
            L0062: AddEncounter(player, 0x02, 0x0E);
            L0074: PushStack(player, 0x1F);
0864  0078 B8 03 00  mov ax, 0x3
            L007B: goto L00CC;
            L007D: AddEncounter(player, 0x01, 0x0D);
            L008F: AddEncounter(player, 0x02, 0x0E);
            L00A1: AddEncounter(player, 0x03, 0x1F);
            L00B3: AddEncounter(player, 0x05, 0x20);
            L00C5: AddEncounter(player, 0x06, 0x20);
            L00D7: return; // RETURN;
        }

        private void FnSECELF_19(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetRace(player), 0x0002);
            L000D: if (JumpNotEqual) goto L001C;
08D9  000F FF 76 08  push word [bp+0x8]
08DC  0012 FF 76 06  push word [bp+0x6]
08DF  0015 0E     push cs
08E0  0016 E8 13 0A  call 0xa2c
            L0019: // NOP
            L001A: cx = PopStack(player);
            L001B: cx = PopStack(player);
            L001C: return; // RETURN;
        }

        private void FnSECDWA_1A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetRace(player), 0x0004);
            L000D: if (JumpNotEqual) goto L001C;
08F7  000F FF 76 08  push word [bp+0x8]
08FA  0012 FF 76 06  push word [bp+0x6]
08FD  0015 0E     push cs
08FE  0016 E8 F5 09  call 0xa0e
            L0019: // NOP
            L001A: cx = PopStack(player);
            L001B: cx = PopStack(player);
            L001C: return; // RETURN;
        }

        private void FnTEXTWF_1F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetRace(player), 0x0002);
            L000D: if (JumpNotEqual) goto L001C;
            L000F: ShowMessage(player, String0C0E); // Use the Coral third.
            L001C: return; // RETURN;
        }

        private void FnFTNGREM_21(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0042);
            L0010: Compare(GetRace(player), 0x0007);
            L001A: if (JumpNotEqual) goto L002E;
0959  001C FF 76 08  push word [bp+0x8]
095C  001F FF 76 06  push word [bp+0x6]
095F  0022 0E     push cs
0960  0023 E8 33 0A  call 0xa59
            L0026: // NOP
            L0027: cx = PopStack(player);
            L0028: cx = PopStack(player);
0966  0029 B8 23 0C  mov ax, 0xc23
            L002C: goto L0031;
            L002E: ShowMessage(player, String0C65); // The waters of Gremlin Fountain have no affect.
            L003B: return; // RETURN;
        }

        private void FnSECGNO_25(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetRace(player), 0x0005);
            L000D: if (JumpNotEqual) goto L001C;
0998  000F FF 76 08  push word [bp+0x8]
099B  0012 FF 76 06  push word [bp+0x6]
099E  0015 0E     push cs
099F  0016 E8 54 09  call 0x96d
            L0019: // NOP
            L001A: cx = PopStack(player);
            L001B: cx = PopStack(player);
            L001C: return; // RETURN;
        }

        private void FnTEXTWG_28(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetRace(player), 0x0005);
            L000D: if (JumpNotEqual) goto L001C;
            L000F: ShowMessage(player, String0568); // Use the Ebony before the Coral.
            L001C: return; // RETURN;
        }

        private void FnFTNHALF_2B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0042);
            L0010: Compare(GetRace(player), 0x0006);
            L001A: if (JumpNotEqual) goto L002E;
09F5  001C FF 76 08  push word [bp+0x8]
09F8  001F FF 76 06  push word [bp+0x6]
09FB  0022 0E     push cs
09FC  0023 E8 97 09  call 0x9bd
            L0026: // NOP
            L0027: cx = PopStack(player);
            L0028: cx = PopStack(player);
0A02  0029 B8 94 0C  mov ax, 0xc94
            L002C: goto L0031;
            L002E: ShowMessage(player, String0CCF); // The waters of Halfling Fountain have no affect.
            L003B: return; // RETURN;
        }

        private void FnTELOE_2D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x06, 0x01, 0x59, 0x01, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnTELOF_2F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x06, 0x03, 0x0B, 0x02, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnFTNTR_30(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0042);
            L0010: Compare(GetRace(player), 0x0003);
            L001A: if (JumpNotEqual) goto L002E;
0A7C  001C FF 76 08  push word [bp+0x8]
0A7F  001F FF 76 06  push word [bp+0x6]
0A82  0022 0E     push cs
0A83  0023 E8 10 09  call 0x936
            L0026: // NOP
            L0027: cx = PopStack(player);
            L0028: cx = PopStack(player);
0A89  0029 B8 FF 0C  mov ax, 0xcff
            L002C: goto L0031;
            L002E: ShowMessage(player, String0D42); // The waters of Troll Fountain have no affect.
            L003B: return; // RETURN;
        }

        private void FnFTNHUM_31(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0042);
            L0010: RefreshCompareFlags(GetRace(player));
            L0019: if (JumpNotEqual) goto L002D;
0AB8  001B FF 76 08  push word [bp+0x8]
0ABB  001E FF 76 06  push word [bp+0x6]
0ABE  0021 0E     push cs
0ABF  0022 E8 D4 08  call 0x8f9
            L0025: // NOP
            L0026: cx = PopStack(player);
            L0027: cx = PopStack(player);
0AC5  0028 B8 6F 0D  mov ax, 0xd6f
            L002B: goto L0030;
            L002D: ShowMessage(player, String0D9C); // The waters of Human Fountain have no affect.
            L003A: return; // RETURN;
        }

        private void FnTELOG_33(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x06, 0x02, 0xA0, 0x02, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnSECHALF_35(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetRace(player), 0x0006);
            L000D: if (JumpNotEqual) goto L001C;
0B12  000F FF 76 08  push word [bp+0x8]
0B15  0012 FF 76 06  push word [bp+0x6]
0B18  0015 0E     push cs
0B19  0016 E8 DA 07  call 0x7f3
            L0019: // NOP
            L001A: cx = PopStack(player);
            L001B: cx = PopStack(player);
            L001C: return; // RETURN;
        }

        private void FnGOODIEB_38(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0B2E  0003 B8 DC 05  mov ax, 0x5dc
            L0006: PushStack(player, ax);
            L0007: PushStack(player, 0x00);
            L000A: PushStack(player, ax);
            L000B: PushStack(player, ax);
            L000C: PushStack(player, 0xC2);
            L0010: PushStack(player, 0x9F);
0B3F  0014 C4 5E 06  les bx, [bp+0x6]
0B42  0017 26 FF 9F D8 00  call far word [es:bx+0xd8]
0B47  001C 83 C4 0C  add sp, 0xc
            L001F: ShowMessage(player, String0DC9); // As you approach a battle, the combatants turn and attack you.
            L002C: Compare(PartyCount(player), 0x0001);
            L0037: if (JumpNotEqual) goto L0063;
            L0039: AddEncounter(player, 0x01, 0x05);
            L004B: AddEncounter(player, 0x02, 0x24);
0B88  005D B8 24 00  mov ax, 0x24
            L0060: goto L00E8;
            L0063: Compare(PartyCount(player), 0x0002);
            L006E: if (JumpNotEqual) goto L009D;
            L0070: AddEncounter(player, 0x01, 0x05);
            L0082: AddEncounter(player, 0x02, 0x06);
            L0094: PushStack(player, 0x14);
0BC3  0098 B8 05 00  mov ax, 0x5
            L009B: goto L0052;
            L009D: AddEncounter(player, 0x01, 0x1B);
            L00AF: AddEncounter(player, 0x02, 0x1B);
            L00C1: AddEncounter(player, 0x03, 0x1C);
            L00D3: AddEncounter(player, 0x05, 0x23);
            L00E5: AddEncounter(player, 0x06, 0x25);
            L00F7: return; // RETURN;
        }

        private void FnSECTRO_39(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetRace(player), 0x0003);
            L000D: if (JumpNotEqual) goto L001C;
0C33  000F FF 76 08  push word [bp+0x8]
0C36  0012 FF 76 06  push word [bp+0x6]
0C39  0015 0E     push cs
0C3A  0016 E8 B9 06  call 0x6d2
            L0019: // NOP
            L001A: cx = PopStack(player);
            L001B: cx = PopStack(player);
            L001C: return; // RETURN;
        }

        private void FnTEXTWH_3A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetRace(player), 0x0003);
            L000D: if (JumpNotEqual) goto L001C;
            L000F: ShowMessage(player, String0E07); // Use the Opal before the Coral.
            L001C: return; // RETURN;
        }

        private void FnSECORC_3E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetRace(player), 0x0001);
            L000D: if (JumpNotEqual) goto L001C;
0C7E  000F FF 76 08  push word [bp+0x8]
0C81  0012 FF 76 06  push word [bp+0x6]
0C84  0015 0E     push cs
0C85  0016 E8 6E 06  call 0x687
            L0019: // NOP
            L001A: cx = PopStack(player);
            L001B: cx = PopStack(player);
            L001C: return; // RETURN;
        }

        private void FnSECMSG_45(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0E26); // You watch as passers-by clutch their magic-casting rings and uncover secret passages.
            L0010: return; // RETURN;
        }

        private void FnGOODIEC_46(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0E7C); // A party of lost adventurers arguing about directions turns and attacks.
            L0010: ax = HasItem(player, 0xA6);
            L001E: if (JumpEqual) goto L0035;
0CDD  0020 B8 D0 07  mov ax, 0x7d0
            L0023: PushStack(player, ax);
            L0024: PushStack(player, 0x00);
            L0027: PushStack(player, ax);
            L0028: PushStack(player, 0xB6);
            L002C: PushStack(player, 0xA1);
0CED  0030 B8 BA 00  mov ax, 0xba
            L0033: goto L0048;
0CF2  0035 B8 B8 0B  mov ax, 0xbb8
            L0038: PushStack(player, ax);
            L0039: PushStack(player, 0x00);
            L003C: PushStack(player, ax);
            L003D: PushStack(player, 0xB6);
            L0041: PushStack(player, 0xA6);
            L0045: PushStack(player, 0x24);
0D06  0049 C4 5E 06  les bx, [bp+0x6]
0D09  004C 26 FF 9F D8 00  call far word [es:bx+0xd8]
0D0E  0051 83 C4 0C  add sp, 0xc
            L0054: Compare(PartyCount(player), 0x0001);
            L005F: if (JumpNotEqual) goto L007D;
            L0061: AddEncounter(player, 0x01, 0x14);
            L0073: PushStack(player, 0x1D);
0D34  0077 B8 05 00  mov ax, 0x5
            L007A: goto L0114;
            L007D: Compare(PartyCount(player), 0x0002);
            L0088: if (JumpNotEqual) goto L00C5;
            L008A: AddEncounter(player, 0x01, 0x22);
            L009C: AddEncounter(player, 0x02, 0x24);
            L00AE: AddEncounter(player, 0x03, 0x24);
0D7D  00C0 B8 18 00  mov ax, 0x18
            L00C3: goto L0110;
            L00C5: AddEncounter(player, 0x01, 0x22);
            L00D7: AddEncounter(player, 0x02, 0x24);
            L00E9: AddEncounter(player, 0x03, 0x25);
            L00FB: AddEncounter(player, 0x05, 0x27);
            L010D: AddEncounter(player, 0x06, 0x28);
            L011F: return; // RETURN;
        }

        private void FnMEDA_48(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L002B;
            L0010: AddEncounter(player, 0x01, 0x1F);
            L0022: PushStack(player, 0x21);
0E09  0026 B8 02 00  mov ax, 0x2
            L0029: goto L00A2;
            L002B: Compare(PartyCount(player), 0x0002);
            L0036: if (JumpNotEqual) goto L0053;
            L0038: AddEncounter(player, 0x01, 0x11);
            L004A: PushStack(player, 0x0D);
0E31  004E B8 02 00  mov ax, 0x2
            L0051: goto L0090;
            L0053: AddEncounter(player, 0x01, 0x0D);
            L0065: AddEncounter(player, 0x02, 0x0E);
            L0077: AddEncounter(player, 0x03, 0x12);
            L0089: AddEncounter(player, 0x05, 0x20);
            L009B: AddEncounter(player, 0x06, 0x20);
            L00AD: return; // RETURN;
        }

        private void FnEZA_49(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L002C;
            L0010: AddEncounter(player, 0x01, 0x03);
            L0022: PushStack(player, 0x01);
0EB8  0026 B8 02 00  mov ax, 0x2
            L0029: goto L00B2;
            L002C: Compare(PartyCount(player), 0x0002);
            L0037: if (JumpNotEqual) goto L0078;
            L0039: AddEncounter(player, 0x01, 0x03);
            L004B: AddEncounter(player, 0x02, 0x03);
            L005D: AddEncounter(player, 0x03, 0x02);
            L006F: PushStack(player, 0x01);
0F05  0073 B8 04 00  mov ax, 0x4
            L0076: goto L00B2;
            L0078: AddEncounter(player, 0x01, 0x02);
            L008A: PushStack(player, 0x02);
            L008E: PushStack(player, ax);
0F21  008F C4 5E 06  les bx, [bp+0x6]
0F24  0092 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L0097: cx = PopStack(player);
            L0098: cx = PopStack(player);
            L0099: AddEncounter(player, 0x05, 0x19);
            L00AB: AddEncounter(player, 0x06, 0x01);
            L00BD: return; // RETURN;
        }

        private void FnHRDA_4A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L001A;
            L0010: PushStack(player, 0x0B);
0F65  0014 B8 01 00  mov ax, 0x1
            L0017: goto L009F;
            L001A: Compare(PartyCount(player), 0x0002);
            L0025: if (JumpNotEqual) goto L0050;
            L0027: AddEncounter(player, 0x01, 0x09);
            L0039: AddEncounter(player, 0x02, 0x09);
0F9C  004B B8 0C 00  mov ax, 0xc
            L004E: goto L0089;
            L0050: AddEncounter(player, 0x01, 0x09);
            L0062: AddEncounter(player, 0x02, 0x09);
            L0074: AddEncounter(player, 0x03, 0x0C);
            L0086: AddEncounter(player, 0x05, 0x1E);
            L0098: AddEncounter(player, 0x06, 0x1E);
            L00AA: return; // RETURN;
        }

        private void FnEZB_4B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L002B;
            L0010: AddEncounter(player, 0x01, 0x03);
            L0022: PushStack(player, 0x16);
1023  0026 B8 02 00  mov ax, 0x2
            L0029: goto L009F;
            L002B: Compare(PartyCount(player), 0x0002);
            L0036: if (JumpNotEqual) goto L0065;
            L0038: AddEncounter(player, 0x01, 0x03);
            L004A: AddEncounter(player, 0x02, 0x03);
            L005C: PushStack(player, 0x14);
105D  0060 B8 03 00  mov ax, 0x3
            L0063: goto L009F;
            L0065: AddEncounter(player, 0x01, 0x02);
            L0077: PushStack(player, 0x02);
            L007B: PushStack(player, ax);
1079  007C C4 5E 06  les bx, [bp+0x6]
107C  007F 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L0084: cx = PopStack(player);
            L0085: cx = PopStack(player);
            L0086: AddEncounter(player, 0x03, 0x15);
            L0098: AddEncounter(player, 0x04, 0x17);
            L00AA: return; // RETURN;
        }

        private void FnMEDD_4D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L002C;
            L0010: AddEncounter(player, 0x01, 0x16);
            L0022: PushStack(player, 0x24);
10D4  0026 B8 02 00  mov ax, 0x2
            L0029: goto L00B5;
            L002C: Compare(PartyCount(player), 0x0002);
            L0037: if (JumpNotEqual) goto L0078;
            L0039: AddEncounter(player, 0x01, 0x14);
            L004B: AddEncounter(player, 0x02, 0x15);
            L005D: AddEncounter(player, 0x03, 0x1D);
            L006F: PushStack(player, 0x1D);
1121  0073 B8 04 00  mov ax, 0x4
            L0076: goto L00B5;
            L0078: AddEncounter(player, 0x01, 0x22);
            L008A: AddEncounter(player, 0x02, 0x23);
            L009C: AddEncounter(player, 0x05, 0x27);
            L00AE: AddEncounter(player, 0x06, 0x28);
            L00C0: return; // RETURN;
        }

        private void FnEZC_4E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L002C;
            L0010: AddEncounter(player, 0x01, 0x06);
            L0022: PushStack(player, 0x03);
1196  0026 B8 02 00  mov ax, 0x2
            L0029: goto L00B2;
            L002C: Compare(PartyCount(player), 0x0002);
            L0037: if (JumpNotEqual) goto L0063;
            L0039: PushStack(player, 0x01);
            L003D: PushStack(player, ax);
11AE  003E C4 5E 06  les bx, [bp+0x6]
11B1  0041 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L0046: cx = PopStack(player);
            L0047: cx = PopStack(player);
            L0048: AddEncounter(player, 0x02, 0x03);
            L005A: PushStack(player, 0x06);
11CE  005E B8 05 00  mov ax, 0x5
            L0061: goto L00B2;
            L0063: AddEncounter(player, 0x01, 0x06);
            L0075: AddEncounter(player, 0x02, 0x06);
            L0087: AddEncounter(player, 0x03, 0x05);
            L0099: AddEncounter(player, 0x05, 0x02);
            L00AB: AddEncounter(player, 0x06, 0x03);
            L00BD: return; // RETURN;
        }

        private void FnMEDB_4F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L002C;
            L0010: AddEncounter(player, 0x01, 0x08);
            L0022: PushStack(player, 0x1D);
1255  0026 B8 02 00  mov ax, 0x2
            L0029: goto L00B5;
            L002C: Compare(PartyCount(player), 0x0002);
            L0037: if (JumpNotEqual) goto L0066;
            L0039: AddEncounter(player, 0x01, 0x08);
            L004B: AddEncounter(player, 0x02, 0x08);
            L005D: PushStack(player, 0x18);
1290  0061 B8 03 00  mov ax, 0x3
            L0064: goto L00B5;
            L0066: AddEncounter(player, 0x01, 0x08);
            L0078: AddEncounter(player, 0x02, 0x08);
            L008A: AddEncounter(player, 0x03, 0x09);
            L009C: AddEncounter(player, 0x05, 0x16);
            L00AE: AddEncounter(player, 0x06, 0x18);
            L00C0: return; // RETURN;
        }

        private void Fn_50(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: return; // RETURN;
            // Extra data: 55 8B EC B8 45 00 50 B8 02 00 50 C4 5E 06 26 FF 5F 04 59 59 3D 01 00 75 2E B8 D0 00 50 50 C4 5E 06 26 FF 5F 54 59 59 0B C0 74 1C B8 C4 0E 50 C4 5E 06 26 FF 9F F8 00 59 FF 76 08 FF 76 06 0E E8 81 00 90 59 59 EB 1A FF 76 08 FF 76 06 0E E8 95 00 90 59 59 B8 DB 0E 50 C4 5E 06 26 FF 9F F8 00 59 5D CB 55 8B EC B8 D5 00 50 C4 5E 06 26 FF 5F 48 59 B8 13 0F 50 C4 5E 06 26 FF 9F F8 00 59 B8 40 0F 50 C4 5E 06 26 FF 9F F8 00 59 5D CB 55 8B EC B8 8A 0F 50 C4 5E 06 26 FF 9F F8 00 59 5D CB 55 8B EC C4 5E 06 26 FF 5F 74 50 C4 5E 06 26 FF 9F 94 00 59 B8 10 27 50 C4 5E 06 26 FF 9F B4 00 59 5D CB 55 8B EC B8 01 00 50 C4 5E 06 26 FF 5F 24 50 C4 5E 06 26 FF 5F 20 50 C4 5E 06 26 FF 5F 2C 83 C4 06 5D CB 55 8B EC 33 C0 50 C4 5E 06 26 FF 5F 24 50 C4 5E 06 26 FF 5F 20 50 C4 5E 06 26 FF 5F 2C 83 C4 06 5D CB 55 8B EC B8 DC 05 50 33 C0 50 50 50 B8 C0 00 50 B8 B6 00 50 C4 5E 06 26 FF 9F D8 00 83 C4 0C 5D CB 55 8B EC C4 5E 06 26 FF 5F 24 50 C4 5E 06 26 FF 5F 20 50 B8 01 00 50 C4 5E 06 26 FF 5F 30 83 C4 06 5D CB 
        }

    }
}
