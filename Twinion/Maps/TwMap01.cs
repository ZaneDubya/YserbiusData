#pragma warning disable
using System.Collections.Generic;
using XPT.WorldData;
using XPT.WorldData.Yserbius;

namespace XPT.Scripts.Twinion.Maps {
    class TwMap01 : AMapScripted {
        protected override int MapIndex => 1;
        protected override int RandomEncounterChance => 10;
        protected override int RandomEncounterExtraCount => 0;

        public TwMap01() {
            MapEvent01 = FnTOMAINEN_01;
            MapEvent02 = FnTOGAUNTL_02;
            MapEvent03 = FnLVLENT_03;
            MapEvent04 = FnTOSNKRIV_04;
            MapEvent05 = FnMAGICPIT_05;
            MapEvent06 = FnONEWAY_06;
            MapEvent07 = FnLOCKPICK_07;
            MapEvent08 = FnTHIEFONL_08;
            MapEvent0A = FnNOJOIN_0A;
            MapEvent0B = FnDETECT_0B;
            MapEvent0C = FnCOILONE_0C;
            MapEvent0D = FnBATCAVE_0D;
            MapEvent0E = FnGUANO_0E;
            MapEvent0F = FnENTERBAT_0F;
            MapEvent10 = FnBATSTASH_10;
            MapEvent11 = FnPITMESS_11;
            MapEvent12 = FnNPCINHAL_12;
            MapEvent13 = FnTHIEFTRS_13;
            MapEvent14 = FnTHIEFTRB_14;
            MapEvent15 = FnEZBATONE_15;
            MapEvent16 = FnEZBATTWO_16;
            MapEvent17 = FnPFBATONE_17;
            MapEvent18 = FnBATTHREE_18;
            MapEvent19 = FnTONECRNR_19;
            MapEvent1A = FnFNTNONE_1A;
            MapEvent1B = FnFNTNTWO_1B;
            MapEvent1C = FnBIZARRE_1C;
            MapEvent1D = FnDRAGTHRU_1D;
            MapEvent1E = FnLETSPORT_1E;
            MapEvent1F = FnTONWCRNR_1F;
            MapEvent20 = FnTOMIDWST_20;
            MapEvent21 = FnSETFLAGW_21;
            MapEvent22 = FnWESTTXT_22;
            MapEvent23 = FnEASTTXT_23;
            MapEvent24 = FnPORTTONE_24;
            MapEvent25 = FnSTATEZRO_25;
            MapEvent26 = FnTEXT_26;
            MapEvent27 = FnLOCKTOBR_27;
            MapEvent28 = FnGAINWISD_28;
            MapEvent29 = FnTEXTFORF_29;
            MapEvent2A = FnFLAMEDOR_2A;
            MapEvent2B = FnFLAMDOOR_2B;
            MapEvent2C = FnMYSINCLU_2C;
        }
        
        // === Strings ================================================
        private const string String03FC = "The Door Reads: 'To Main Entrance.'";
        private const string String0420 = "This will take you to the Gauntlet!";
        private const string String0444 = "HAIL! This is Gauntlet Gauche. Swirling waters and magical pits will be your guides to the gauntlet sought in Gauntlet Droit.";
        private const string String04C2 = "A magical Gauntlet has been thrown down in the Coil Maze. This path will offer you a second ingress to that phase.";
        private const string String0535 = "ONE WAY";
        private const string String053D = "You've picked the lock. Proceed.";
        private const string String055E = "A locked door impedes your progress here.";
        private const string String0588 = "Well done, sly thief. You may proceed.";
        private const string String05AF = "Only a masterful thief can open this door.";
        private const string String05DA = "Small pinholes of light seep through the cracks in the wall here.";
        private const string String061C = "You've uncovered a hidden door!";
        private const string String063C = "You hear roaring waters on the other side of this gateway.";
        private const string String0677 = "The narrow door forces you to disband and enter alone.";
        private const string String06AE = "Flickering torches offer dim light, allowing you to see your way from here.";
        private const string String06FA = "The bats seem to have calmed down here.";
        private const string String0722 = "You must wade through a pool of guano here. The noxious odors are damaging to you.";
        private const string String0775 = "Eastward, an ornate hallway has been infested with various kinds of bats. They cling to the ceiling and issue shrill chirps to the point of madness.";
        private const string String080A = "A thick layer of leathery wings blocks out the light in the eastern hall. You will be unable to map the area. Proceed with caution!";
        private const string String088E = "A stash of booty and coins comprises the bats' treasure room.";
        private const string String08CC = "There's nothing more here.";
        private const string String08E7 = "The floor is filled with glowing pits. These will provide you with shortcuts to various areas of this level.";
        private const string String0954 = "Continue, if you dare to chance it.";
        private const string String0978 = "'Greetings to you! This is one of two mazes which comprise the Gauntlet quest.";
        private const string String09C7 = "Explore the area thoroughly, there are many shortcuts to help you here.'";
        private const string String0A10 = "'Might I be of service again?";
        private const string String0A2E = "In the north is a series of pits that will offer you rapid progression.";
        private const string String0A76 = "The bats in the north east are horrible, but rewarding.'";
        private const string String0AAF = "'You want more info?...Hmmm, let's see...ah yes! How could I have forgotten!";
        private const string String0AFC = "Find your way to the south and east. The Snake River will grant you a quick way to the Coil Maze.'";
        private const string String0B5F = "'I can offer you no more advice. It's up to you which path you choose. But in time, all things come upon themselves.'";
        private const string String0BD5 = "You come across a stash of useful items!";
        private const string String0BFE = "The magical waters are refreshing.";
        private const string String0C21 = "Clear blue waters restore your mana!";
        private const string String0C46 = "You've done something bizarre! Here's your reward!";
        private const string String0C79 = "The magic waters pull you onward!";
        private const string String0C9B = "An unstable platform forces you to stand alone at the western edge of Snake River.";
        private const string String0CEE = "You are at the eastern end of Snake River.";
        private const string String0D19 = "Magical forces hurl water southward and around the bend. The overwhelming noise is hypnotic and painful.";
        private const string String0D82 = "Look at me again to gain more information!";
        private const string String0DAD = "The door to the west is locked, but no lockpick can help you here! You must learn to use what is at hand in a more creative fashion.";
        private const string String0E32 = "You must use something...something that could hack the lock off the door. Do not constrain yourself from using your belongings in a new way!";
        private const string String0EBF = "Use a weapon, a sword or an axe, some form of blade or bludgeon, and you will be able to knock the lock off.";
        private const string String0F2C = "You've broken the lock! You may now enter and gain experience from your actions!";
        private const string String0F7D = "Well done! Gain in experience and line your pockets with gold! Remember, there are more ways to use what you have than you remember.";
        private const string String1002 = "You've gained all you can from this test. You are welcome to bash the magical lock as often as you wish.";
        private const string String106B = "The door to the east is locked, but no lockpick can help you here! You must learn to use what is at hand in a more creative fashion.";
        private const string String10F0 = "You must use something...something that could fire the lock off the door. Do not constrain yourself from using your belongings in a new way!";
        private const string String117D = "Use a scroll that would cast a magical force, capable of incinerating or blowing the door away!";
        private const string String11DD = "You've incinerated the door! Now you may enter and gain wisdom from your accomplishment.";
        private const string String1236 = "You've gained all you can from this test. You are welcome to destroy the magical door as often as you wish.";
        private const string String12A2 = "You pass by a dwarf regaling some companions. 'I was trying to find a way across Lake Deluge or Desperate - something like that.";
        private const string String1323 = "Anyway, I stepped on a spot and I tell you, if I hadn't had the Life Jacket, I wouldn't be here today!'";
        private const string String138B = "A barbarian is lamenting with a companion over something he lost. 'I know I had it not long ago! That knight told us we needed the key to enter those secret rooms.";
        private const string String142F = "We must find it! Hmmm, we did search that place on Lake Despair. Let's try looking back there.'";
        private const string String148F = "With that, they hurry off to other adventures.";
        private const string String14BE = "A thief emerges from the shadows, 'There's an area in the Night Elves' Domain where the magic used to construct the walls will drive you to the fringe of madness!";
        private const string String1561 = "Never have I seen the likes of these magical walls. I saw nothing, yet my path was blocked! Fret not, there is a hidden exit...though I fear this is not the last of the nightmare.";
        
        // === Functions ================================================
        private void FnTOMAINEN_01(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String03FC); // The Door Reads: 'To Main Entrance.'
            L0010: PushStack(player, 0x02);
            L0014: PushStack(player, 0x83);
            L0018: PushStack(player, 0x01);
            L001C: PushStack(player, ax);
0022  001D C4 5E 06  les bx, [bp+0x6]
0025  0020 26 FF 9F BC 00  call far word [es:bx+0xbc]
002A  0025 83 C4 08  add sp, 0x8
            L0028: return; // RETURN;
        }

        private void FnTOGAUNTL_02(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0420); // This will take you to the Gauntlet!
            L0010: TeleportParty(player, 0x01, 0x03, 0xD4, 0x03, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnLVLENT_03(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0021: ShowMessage(player, String0444); // HAIL! This is Gauntlet Gauche. Swirling waters and magical pits will be your guides to the gauntlet sought in Gauntlet Droit.
            L002E: ShowMessage(player, String04C2); // A magical Gauntlet has been thrown down in the Coil Maze. This path will offer you a second ingress to that phase.
            L003B: return; // RETURN;
        }

        private void FnTOSNKRIV_04(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x01, 0x02, 0xF5, 0x02, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnMAGICPIT_05(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: // make space for tmp on stack: sp -= 2
00BE  0005 56     push si
            L0006: ax = GetCurrentTile(player);
00C6  000D 89 46 FE  mov [bp-0x2], ax
00C9  0010 B9 06 00  mov cx, 0x6
            L0013: bx = 0x0119;
00CF  0016 2E 8B 07  mov ax, [cs:bx]
00D2  0019 3B 46 FE  cmp ax, [bp-0x2]
            L001C: if (JumpEqual) goto L0024;
00D7  001E 43     inc bx
00D8  001F 43     inc bx
00D9  0020 E2 F4  loop 0x16
            L0022: goto L0043;
00DD  0024 2E FF 67 0C  jmp word [cs:bx+0xc]
            L0028: si = 0x000F;
            L002B: goto L0043;
            L002D: si = 0x007F;
            L0030: goto L0043;
            L0032: si = 0x00BF;
            L0035: goto L0043;
            L0037: si = 0;
            L0039: goto L0043;
            L003B: si = 0x0070;
            L003E: goto L0043;
            L0040: si = 0x00F0;
            L0043: PushStack(player, 0x01);
0100  0047 56     push si
            L0048: PushStack(player, 0x02);
            L004C: PushStack(player, 0x01);
0109  0050 C4 5E 06  les bx, [bp+0x6]
010C  0053 26 FF 9F BC 00  call far word [es:bx+0xbc]
0111  0058 83 C4 08  add sp, 0x8
0114  005B 5E     pop si
            L005C: // restore stack ptr: sp = bp;
            L005E: return; // RETURN;
            // Extra data: 08 00 09 00 18 00 19 00 28 00 29 00 F0 00 E1 00 F4 00 E6 00 F9 00 EB 00 
        }

        private void FnONEWAY_06(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0535); // ONE WAY
            L0010: return; // RETURN;
        }

        private void FnLOCKPICK_07(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasUsedItem(player, 0xBE, 0xC0);
            L0016: if (JumpNotEqual) goto L0029;
            L0018: Compare(HasUsedSkill(player, 0x0E), 0x0001);
            L0027: if (JumpBelowOrEqual) goto L0056;
            L0029: ShowMessage(player, String053D); // You've picked the lock. Proceed.
            L0036: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0054: goto L0080;
            L0056: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0073: ShowMessage(player, String055E); // A locked door impedes your progress here.
            L0080: return; // RETURN;
        }

        private void FnTHIEFONL_08(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetGuild(player), 0x0003);
            L000D: if (JumpNotEqual) goto L0084;
            L000F: ax = HasUsedItem(player, 0xBE, 0xC0);
            L0022: if (JumpNotEqual) goto L0035;
            L0024: Compare(HasUsedSkill(player, 0x0E), 0x0001);
            L0033: if (JumpBelowOrEqual) goto L0062;
            L0035: ShowMessage(player, String0588); // Well done, sly thief. You may proceed.
            L0042: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0060: goto L00AE;
            L0062: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
0244  007F B8 5E 05  mov ax, 0x55e
            L0082: goto L00A4;
            L0084: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L00A1: ShowMessage(player, String05AF); // Only a masterful thief can open this door.
            L00AE: return; // RETURN;
        }

        private void FnNOJOIN_0A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetNoJoinArea(player);
            L000B: return; // RETURN;
        }

        private void FnDETECT_0B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String05DA); // Small pinholes of light seep through the cracks in the wall here.
            L0010: Compare(HasUsedSkill(player, 0x0D), 0x0001);
            L001F: if (JumpNotBelow) goto L0079;
            L0021: RefreshCompareFlags(HasUsedSpell(player, 0x17));
            L002F: if (JumpNotEqual) goto L0079;
            L0031: PushStack(player, 0xA4);
            L0035: PushStack(player, ax);
02BD  0036 C4 5E 06  les bx, [bp+0x6]
02C0  0039 26 FF 5F 54  call far word [es:bx+0x54]
            L003D: cx = PopStack(player);
            L003E: cx = PopStack(player);
            L003F: RefreshCompareFlags(ax);
            L0041: if (JumpNotEqual) goto L0079;
            L0043: PushStack(player, 0x6E);
            L0047: PushStack(player, ax);
02CF  0048 C4 5E 06  les bx, [bp+0x6]
02D2  004B 26 FF 5F 54  call far word [es:bx+0x54]
            L004F: cx = PopStack(player);
            L0050: cx = PopStack(player);
            L0051: RefreshCompareFlags(ax);
            L0053: if (JumpNotEqual) goto L0079;
            L0055: PushStack(player, 0x90);
            L0059: PushStack(player, ax);
02E1  005A C4 5E 06  les bx, [bp+0x6]
02E4  005D 26 FF 5F 54  call far word [es:bx+0x54]
            L0061: cx = PopStack(player);
            L0062: cx = PopStack(player);
            L0063: RefreshCompareFlags(ax);
            L0065: if (JumpNotEqual) goto L0079;
            L0067: PushStack(player, 0x68);
            L006B: PushStack(player, ax);
02F3  006C C4 5E 06  les bx, [bp+0x6]
02F6  006F 26 FF 5F 54  call far word [es:bx+0x54]
            L0073: cx = PopStack(player);
            L0074: cx = PopStack(player);
            L0075: RefreshCompareFlags(ax);
            L0077: if (JumpEqual) goto L00C1;
            L0079: SetWallObject(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L0097: ShowMessage(player, String061C); // You've uncovered a hidden door!
            L00A4: PushStack(player, 0x01);
            L00A8: PushStack(player, GetFacing(player));
            L00B0: PushStack(player, GetCurrentTile(player));
033F  00B8 C4 5E 06  les bx, [bp+0x6]
0342  00BB 26 FF 5F 2C  call far word [es:bx+0x2c]
            L00BF: goto L00F8;
            L00C1: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L00DE: SetWallObject(player, 0x00, GetCurrentTile(player), GetFacing(player));
            L00FB: return; // RETURN;
        }

        private void FnCOILONE_0C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L0033;
            L0010: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
03B2  002E B8 3C 06  mov ax, 0x63c
            L0031: goto L0053;
            L0033: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0050: ShowMessage(player, String0677); // The narrow door forces you to disband and enter alone.
            L005D: return; // RETURN;
        }

        private void FnBATCAVE_0D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: // make space for tmp on stack: sp -= 2
03E8  0005 56     push si
            L0006: si = GetFlag(player, 0x03, 0x02);
            L0019: ax = GetCurrentTile(player);
0403  0020 89 46 FE  mov [bp-0x2], ax
0406  0023 B9 05 00  mov cx, 0x5
            L0026: bx = 0x04CE;
040C  0029 2E 8B 07  mov ax, [cs:bx]
040F  002C 3B 46 FE  cmp ax, [bp-0x2]
            L002F: if (JumpEqual) goto L0038;
0414  0031 43     inc bx
0415  0032 43     inc bx
0416  0033 E2 F4  loop 0x29
            L0035: goto L00CD;
041B  0038 2E FF 67 0A  jmp word [cs:bx+0xa]
041F  003C C4 5E 06  les bx, [bp+0x6]
0422  003F 26 FF 9F E8 00  call far word [es:bx+0xe8]
            L0044: Compare(si, 0x5E);
            L0047: if (JumpGreater) goto L005A;
042C  0049 0B F6  or si, si
            L004B: if (JumpEqual) goto L005A;
            L004D: XCall Fn0111
            L0058: goto L00CB;
043D  005A B8 07 00  mov ax, 0x7
            L005D: goto L00BE;
0442  005F C4 5E 06  les bx, [bp+0x6]
0445  0062 26 FF 9F E8 00  call far word [es:bx+0xe8]
            L0067: Compare(si, 0x4F);
            L006A: if (JumpGreater) goto L0072;
044F  006C 0B F6  or si, si
            L006E: if (JumpEqual) goto L0072;
            L0070: goto L004D;
            L0072: goto L005A;
0457  0074 C4 5E 06  les bx, [bp+0x6]
045A  0077 26 FF 9F E8 00  call far word [es:bx+0xe8]
            L007C: Compare(si, 0x3F);
            L007F: if (JumpGreater) goto L0087;
0464  0081 0B F6  or si, si
            L0083: if (JumpEqual) goto L0087;
            L0085: goto L004D;
            L0087: goto L00BB;
            L0089: XCall Fn00FF
            L0094: cx = PopStack(player);
            L0095: cx = PopStack(player);
            L0096: Compare(si, 0x2E);
            L0099: if (JumpGreater) goto L00A1;
047E  009B 0B F6  or si, si
            L009D: if (JumpEqual) goto L00A1;
            L009F: goto L004D;
            L00A1: goto L005A;
            L00A3: XCall Fn00FF
            L00AE: cx = PopStack(player);
            L00AF: cx = PopStack(player);
            L00B0: Compare(si, 0x2F);
            L00B3: if (JumpNotEqual) goto L00BB;
0498  00B5 0B F6  or si, si
            L00B7: if (JumpEqual) goto L00BB;
            L00B9: goto L004D;
            L00BB: AddEncounter(player, 0x01, 0x03);
            L00CD: PushStack(player, GetCurrentTile(player));
            L00D5: PushStack(player, 0x02);
            L00D9: PushStack(player, 0x03);
04C0  00DD C4 5E 06  les bx, [bp+0x6]
04C3  00E0 26 FF 1F  call far word [es:bx]
04C6  00E3 83 C4 06  add sp, 0x6
04C9  00E6 5E     pop si
            L00E7: // restore stack ptr: sp = bp;
            L00E9: return; // RETURN;
            // Extra data: 2E 00 2F 00 3F 00 4F 00 5E 00 6C 04 86 04 57 04 42 04 1F 04 55 8B EC B8 AE 06 50 C4 5E 06 26 FF 9F F8 00 59 5D CB 55 8B EC B8 FA 06 50 C4 5E 06 26 FF 9F F8 00 59 5D CB 
        }

        private void FnGUANO_0E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0509  0003 C4 5E 06  les bx, [bp+0x6]
050C  0006 26 FF 9F E8 00  call far word [es:bx+0xe8]
            L000B: PushStack(player, 0x01);
            L000F: PushStack(player, 0x00);
0518  0012 C4 5E 06  les bx, [bp+0x6]
051B  0015 26 FF 5F 04  call far word [es:bx+0x4]
            L0019: cx = PopStack(player);
            L001A: cx = PopStack(player);
            L001B: RefreshCompareFlags(ax);
            L001D: if (JumpNotEqual) goto L005F;
            L001F: ax = GetMaxHits(player);
            L0026: bx = 0x0006;
            L0029: dx = ax % bx; ax = ax / bx;
            L002C: DamagePlayer(player, ax);
            L0036: RefreshCompareFlags(GetCurrentHits(player));
            L003F: if (JumpBelowOrEqual) goto L005F;
            L0041: ShowMessage(player, String0722); // You must wade through a pool of guano here. The noxious odors are damaging to you.
            L004E: PushStack(player, 0x01);
            L0052: PushStack(player, ax);
            L0053: PushStack(player, 0x00);
055C  0056 C4 5E 06  les bx, [bp+0x6]
055F  0059 26 FF 1F  call far word [es:bx]
0562  005C 83 C4 06  add sp, 0x6
            L005F: return; // RETURN;
        }

        private void FnENTERBAT_0F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFlag(player, 0x03, 0x02, 0x64);
            L0018: ShowMessage(player, String0775); // Eastward, an ornate hallway has been infested with various kinds of bats. They cling to the ceiling and issue shrill chirps to the point of madness.
            L0025: ShowMessage(player, String080A); // A thick layer of leathery wings blocks out the light in the eastern hall. You will be unable to map the area. Proceed with caution!
            L0032: return; // RETURN;
        }

        private void FnBATSTASH_10(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
059E  0003 C4 5E 06  les bx, [bp+0x6]
05A1  0006 26 FF 9F E8 00  call far word [es:bx+0xe8]
            L000B: RefreshCompareFlags(GetFlag(player, 0x02, 0x82));
            L001E: if (JumpNotEqual) goto L0096;
            L0020: ShowMessage(player, String088E); // A stash of booty and coins comprises the bats' treasure room.
            L002D: GiveItem(player, 0x12);
            L0039: GiveItem(player, 0x4D);
            L0045: GiveItem(player, 0xBE);
            L0051: GiveItem(player, 0xB5);
            L005D: ModifyGold(player, 0x012C);
            L006E: AddExperience(player, 0x000000FA);
            L007F: SetFlag(player, 0x02, 0x82, 0x01);
            L0094: goto L00A3;
            L0096: ShowMessage(player, String08CC); // There's nothing more here.
            L00A3: return; // RETURN;
        }

        private void FnPITMESS_11(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x03);
            L0007: PushStack(player, ax);
0648  0008 C4 5E 06  les bx, [bp+0x6]
064B  000B 26 FF 5F 04  call far word [es:bx+0x4]
            L000F: cx = PopStack(player);
            L0010: cx = PopStack(player);
            L0011: RefreshCompareFlags(ax);
            L0013: if (JumpNotEqual) goto L0041;
            L0015: ShowMessage(player, String08E7); // The floor is filled with glowing pits. These will provide you with shortcuts to various areas of this level.
            L0022: ShowMessage(player, String0954); // Continue, if you dare to chance it.
            L002F: PushStack(player, 0x01);
            L0033: PushStack(player, 0x03);
            L0037: PushStack(player, ax);
0678  0038 C4 5E 06  les bx, [bp+0x6]
067B  003B 26 FF 1F  call far word [es:bx]
067E  003E 83 C4 06  add sp, 0x6
            L0041: return; // RETURN;
        }

        private void FnNPCINHAL_12(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: si = GetFlag(player, 0x03, 0x05);
069A  0017 C4 5E 06  les bx, [bp+0x6]
069D  001A 26 FF 5F 10  call far word [es:bx+0x10]
            L001E: PushStack(player, ax);
            L001F: ax = GetCurrentTile(player);
            L0026: dx = PopStack(player);
06AA  0027 3B D0  cmp dx, ax
            L0029: if (JumpNotEqual) goto L002E;
            L002B: goto L0118;
06B1  002E 0B F6  or si, si
            L0030: if (JumpNotEqual) goto L0035;
            L0032: si = 0x0001;
06B8  0035 8B C6  mov ax, si
            L0037: Compare(ax, 0x0001);
            L003A: if (JumpEqual) goto L0049;
            L003C: Compare(ax, 0x0002);
            L003F: if (JumpEqual) goto L0076;
            L0041: Compare(ax, 0x0003);
            L0044: if (JumpEqual) goto L00AF;
            L0046: goto L00D9;
            L0049: XCall Fn011B
            L0054: cx = PopStack(player);
            L0055: cx = PopStack(player);
            L0056: ShowMessage(player, String0978); // 'Greetings to you! This is one of two mazes which comprise the Gauntlet quest.
            L0063: ShowMessage(player, String09C7); // Explore the area thoroughly, there are many shortcuts to help you here.'
            L0070: si = 0x0002;
            L0073: goto L00F6;
            L0076: XCall Fn011B
            L0081: cx = PopStack(player);
            L0082: cx = PopStack(player);
            L0083: ShowMessage(player, String0A10); // 'Might I be of service again?
            L0090: ShowMessage(player, String0A2E); // In the north is a series of pits that will offer you rapid progression.
            L009D: ShowMessage(player, String0A76); // The bats in the north east are horrible, but rewarding.'
            L00AA: si = 0x0003;
            L00AD: goto L00F6;
            L00AF: XCall Fn011B
            L00BA: cx = PopStack(player);
            L00BB: cx = PopStack(player);
            L00BC: ShowMessage(player, String0AAF); // 'You want more info?...Hmmm, let's see...ah yes! How could I have forgotten!
            L00C9: ShowMessage(player, String0AFC); // Find your way to the south and east. The Snake River will grant you a quick way to the Coil Maze.'
            L00D6: si = 0x0004;
            L00D9: XCall Fn011B
            L00E4: cx = PopStack(player);
            L00E5: cx = PopStack(player);
            L00E6: ShowMessage(player, String0B5F); // 'I can offer you no more advice. It's up to you which path you choose. But in time, all things come upon themselves.'
            L00F3: si = 0x0001;
            L00F6: SetFlag(player, 0xC4, 0xB8, si);
            L0108: PushStack(player, GetCurrentTile(player));
0793  0110 C4 5E 06  les bx, [bp+0x6]
0796  0113 26 FF 5F 1C  call far word [es:bx+0x1c]
            L0117: cx = PopStack(player);
            L0118: return; // RETURN (restoring si);
            // Extra data: 55 8B EC B8 2B 00 50 C4 5E 06 26 FF 9F FC 00 59 5D CB 
        }

        private void FnTHIEFTRS_13(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x02, 0x8A));
            L0016: if (JumpEqual) goto L0052;
            L0018: Compare(GetFlag(player, 0x02, 0x8A), 0x0002);
            L002C: if (JumpNotEqual) goto L0031;
            L002E: goto L0123;
            L0031: PushStack(player, GetFlag(player, 0x02, 0x8A));
            L0043: ax = GetCurrentTile(player);
            L004A: dx = PopStack(player);
07FB  004B 3B D0  cmp dx, ax
            L004D: if (JumpNotEqual) goto L0052;
            L004F: goto L0123;
            L0052: ShowMessage(player, String0BD5); // You come across a stash of useful items!
            L005F: Compare(GetGuild(player), 0x0003);
            L0069: if (JumpNotEqual) goto L00B3;
            L006B: GiveItem(player, 0x40);
            L0077: GiveItem(player, 0xA4);
            L0083: GiveItem(player, 0x8A);
            L008F: GiveItem(player, 0xB5);
            L009B: ModifyGold(player, 0x00FA);
085C  00AC 33 C0  xor ax, ax
085E  00AE BA 64 00  mov dx, 0x64
            L00B1: goto L00E1;
            L00B3: GiveItem(player, 0xCB);
            L00BF: GiveItem(player, 0xB5);
            L00CB: ModifyGold(player, 0x0064);
            L00DC: AddExperience(player, 0x00000032);
            L00ED: Compare(GetFlag(player, 0x02, 0x8A), 0x00E6);
            L0101: if (JumpNotEqual) goto L011A;
            L0103: SetFlag(player, 0x02, 0x8A, 0x02);
            L0118: goto L0130;
            L011A: ax = GetCurrentTile(player);
            L0121: goto L0106;
            L0123: ShowMessage(player, String08CC); // There's nothing more here.
            L0130: return; // RETURN;
        }

        private void FnTHIEFTRB_14(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x02, 0x8A));
            L0016: if (JumpEqual) goto L0052;
            L0018: Compare(GetFlag(player, 0x02, 0x8A), 0x0002);
            L002C: if (JumpNotEqual) goto L0031;
            L002E: goto L0123;
            L0031: PushStack(player, GetFlag(player, 0x02, 0x8A));
            L0043: ax = GetCurrentTile(player);
            L004A: dx = PopStack(player);
092D  004B 3B D0  cmp dx, ax
            L004D: if (JumpNotEqual) goto L0052;
            L004F: goto L0123;
            L0052: ShowMessage(player, String0BD5); // You come across a stash of useful items!
            L005F: Compare(GetGuild(player), 0x0003);
            L0069: if (JumpNotEqual) goto L00B3;
            L006B: GiveItem(player, 0xA3);
            L0077: GiveItem(player, 0x9F);
            L0083: GiveItem(player, 0x8D);
            L008F: GiveItem(player, 0xB5);
            L009B: ModifyGold(player, 0x00FA);
098E  00AC 33 C0  xor ax, ax
0990  00AE BA 64 00  mov dx, 0x64
            L00B1: goto L00E1;
            L00B3: GiveItem(player, 0xCB);
            L00BF: GiveItem(player, 0xB5);
            L00CB: ModifyGold(player, 0x0064);
            L00DC: AddExperience(player, 0x00000032);
            L00ED: Compare(GetFlag(player, 0x02, 0x8A), 0x009F);
            L0101: if (JumpNotEqual) goto L011A;
            L0103: SetFlag(player, 0x02, 0x8A, 0x02);
            L0118: goto L0130;
            L011A: ax = GetCurrentTile(player);
            L0121: goto L0106;
            L0123: ShowMessage(player, String08CC); // There's nothing more here.
            L0130: return; // RETURN;
        }

        private void FnEZBATONE_15(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(player, 0x01, 0x1E);
            L0015: AddEncounter(player, 0x02, 0x1D);
            L0027: return; // RETURN;
        }

        private void FnEZBATTWO_16(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(player, 0x01, 0x22);
            L0015: AddEncounter(player, 0x02, 0x23);
            L0027: return; // RETURN;
        }

        private void FnPFBATONE_17(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: RefreshCompareFlags(GetFlag(player, 0x03, 0x06));
            L0017: if (JumpNotEqual) goto L0054;
            L0019: PushStack(player, 0x19);
            L001D: PushStack(player, 0x00);
            L0020: PushStack(player, ax);
            L0021: PushStack(player, ax);
            L0022: PushStack(player, 0xA4);
            L0026: PushStack(player, 0xB5);
0A90  002A C4 5E 06  les bx, [bp+0x6]
0A93  002D 26 FF 9F D8 00  call far word [es:bx+0xd8]
0A98  0032 83 C4 0C  add sp, 0xc
            L0035: si = 0x0001;
            L0038: goto L004A;
            L003A: AddEncounter(player, si, 0x27);
            L0049: si = si + 1;
            L004A: Compare(si, 0x02);
            L004D: if (JumpLessOrEqual) goto L003A;
0AB5  004F B8 01 00  mov ax, 0x1
            L0052: goto L00BB;
            L0054: Compare(GetFlag(player, 0x03, 0x06), 0x0001);
            L0068: if (JumpNotEqual) goto L0089;
            L006A: si = 0x0001;
            L006D: goto L007F;
            L006F: AddEncounter(player, si, 0x1A);
            L007E: si = si + 1;
            L007F: Compare(si, 0x03);
            L0082: if (JumpLessOrEqual) goto L006F;
0AEA  0084 B8 02 00  mov ax, 0x2
            L0087: goto L00BB;
            L0089: Compare(GetFlag(player, 0x03, 0x06), 0x0002);
            L009D: if (JumpNotEqual) goto L00CD;
            L009F: si = 0x0001;
            L00A2: goto L00B4;
            L00A4: AddEncounter(player, si, 0x20);
            L00B3: si = si + 1;
            L00B4: Compare(si, 0x05);
            L00B7: if (JumpLessOrEqual) goto L00A4;
            L00B9: SetFlag(player, 0x03, 0x06, 0x00);
            L00CD: return; // RETURN (restoring si);
        }

        private void FnBATTHREE_18(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: Compare(PartyCount(player), 0x0001);
            L000F: if (JumpEqual) goto L0018;
            L0011: Compare(ax, 0x0002);
            L0014: if (JumpEqual) goto L002C;
            L0016: goto L0048;
            L0018: AddEncounter(player, 0x01, 0x26);
            L002A: goto L0062;
            L002C: si = 0x0001;
            L002F: goto L0041;
            L0031: AddEncounter(player, si, 0x19);
            L0040: si = si + 1;
            L0041: Compare(si, 0x03);
            L0044: if (JumpLessOrEqual) goto L0031;
            L0046: goto L0062;
            L0048: si = 0x0001;
            L004B: goto L005D;
            L004D: AddEncounter(player, si, 0x23);
            L005C: si = si + 1;
            L005D: Compare(si, 0x05);
            L0060: if (JumpLessOrEqual) goto L004D;
            L0062: return; // RETURN (restoring si);
        }

        private void FnTONECRNR_19(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x01, 0x02, 0x0F, 0x00, isForwardMove);
            L001D: return; // RETURN;
        }

        private void FnFNTNONE_1A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0042);
            L0010: ShowMessage(player, String0BFE); // The magical waters are refreshing.
            L001D: HealPlayer(player, GetCurrentHits(player));
            L002E: return; // RETURN;
        }

        private void FnFNTNTWO_1B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0042);
            L0010: ShowMessage(player, String0C21); // Clear blue waters restore your mana!
            L001D: AddMana(player, 0x0064);
            L002A: return; // RETURN;
        }

        private void FnBIZARRE_1C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: Compare(GetFlag(player, 0x03, 0x04), 0x0032);
            L0018: if (JumpNotEqual) goto L0083;
            L001A: RefreshCompareFlags(GetFlag(player, 0x02, 0x8B));
            L002D: if (JumpNotEqual) goto L0083;
            L002F: ShowMessage(player, String0C46); // You've done something bizarre! Here's your reward!
            L003C: GiveItem(player, 0x29);
            L0048: GiveItem(player, 0xBA);
            L0054: AddExperience(player, 0x000003E8);
            L0065: ModifyGold(player, 0x03E8);
            L0076: PushStack(player, 0x01);
            L007A: PushStack(player, 0x8B);
0C94  007E B8 02 00  mov ax, 0x2
            L0081: goto L00A1;
            L0083: si = GetFlag(player, 0x03, 0x04);
            L0096: si = si + 1;
            L0097: si = ax;
            L0099: SetFlag(player, 0xC4, 0xB8, si);
            L00AB: return; // RETURN (restoring si);
        }

        private void FnDRAGTHRU_1D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0CC7  0003 83 EC 06  sub sp, 0x6
0CCA  0006 56     push si
0CCB  0007 57     push di
            L0008: ax = GetFlag(player, 0x03, 0x01);
0CDD  0019 89 46 FE  mov [bp-0x2], ax
            L001C: ShowMessage(player, String0C79); // The magic waters pull you onward!
            L0029: Compare(tmp, 0xFE);
            L002D: if (JumpNotEqual) goto L0090;
            L002F: ax = GetCurrentTile(player);
0CFA  0036 89 46 FC  mov [bp-0x4], ax
0CFD  0039 B9 0A 00  mov cx, 0xa
            L003C: bx = 0x0E04;
0D03  003F 2E 8B 07  mov ax, [cs:bx]
0D06  0042 3B 46 FC  cmp ax, [bp-0x4]
            L0045: if (JumpEqual) goto L004D;
0D0B  0047 43     inc bx
0D0C  0048 43     inc bx
0D0D  0049 E2 F4  loop 0x3f
            L004B: goto L008E;
0D11  004D 2E FF 67 14  jmp word [cs:bx+0x14]
            L0051: di = 0x00FC;
            L0054: si = 0x0001;
            L0057: goto L00F3;
            L005A: di = 0x00FD;
            L005D: goto L007B;
            L005F: di = 0x00ED;
            L0062: goto L0089;
            L0064: di = 0x00DD;
            L0067: goto L0089;
            L0069: di = 0x00DE;
            L006C: goto L007B;
            L006E: di = 0x00EE;
            L0071: goto L0054;
            L0073: di = 0x00FE;
            L0076: goto L0054;
            L0078: di = 0x00FF;
            L007B: si = 0x0002;
            L007E: goto L00F3;
            L0080: // NOP
            L0081: di = 0x00EF;
            L0084: goto L0089;
            L0086: di = 0x00DF;
            L0089: si = 0x0003;
            L008C: goto L00F3;
            L008E: goto L00F3;
            L0090: Compare(tmp, 0xFE);
            L0094: if (JumpEqual) goto L0099;
            L0096: goto L0112;
            L0098: // NOP
            L0099: ax = GetCurrentTile(player);
0D64  00A0 89 46 FA  mov [bp-0x6], ax
0D67  00A3 B9 0A 00  mov cx, 0xa
            L00A6: bx = 0x0DDC;
0D6D  00A9 2E 8B 07  mov ax, [cs:bx]
0D70  00AC 3B 46 FA  cmp ax, [bp-0x6]
            L00AF: if (JumpEqual) goto L00B7;
0D75  00B1 43     inc bx
0D76  00B2 43     inc bx
0D77  00B3 E2 F4  loop 0xa9
            L00B5: goto L00F3;
0D7B  00B7 2E FF 67 14  jmp word [cs:bx+0x14]
            L00BB: di = 0x00DC;
            L00BE: si = 0x0003;
            L00C1: goto L00F3;
            L00C3: di = 0x00EC;
            L00C6: goto L00BE;
            L00C8: di = 0x00FC;
            L00CB: goto L00E9;
            L00CD: di = 0x00FD;
            L00D0: goto L00F0;
            L00D2: di = 0x00ED;
            L00D5: goto L00F0;
            L00D7: di = 0x00DD;
            L00DA: goto L00E9;
            L00DC: di = 0x00DE;
            L00DF: goto L00BE;
            L00E1: di = 0x00EE;
            L00E4: goto L00BE;
            L00E6: di = 0x00FE;
            L00E9: si = 0;
            L00EB: goto L00F3;
            L00ED: di = 0x00FF;
            L00F0: si = 0x0001;
0DB7  00F3 56     push si
0DB8  00F4 C4 5E 06  les bx, [bp+0x6]
0DBB  00F7 26 FF 9F CC 00  call far word [es:bx+0xcc]
            L00FC: cx = PopStack(player);
0DC1  00FD 56     push si
0DC2  00FE 57     push di
            L00FF: PushStack(player, 0x02);
            L0103: PushStack(player, 0x01);
0DCB  0107 C4 5E 06  les bx, [bp+0x6]
0DCE  010A 26 FF 9F BC 00  call far word [es:bx+0xbc]
0DD3  010F 83 C4 08  add sp, 0x8
0DD6  0112 5F     pop di
0DD7  0113 5E     pop si
            L0114: // restore stack ptr: sp = bp;
            L0116: return; // RETURN;
            // Extra data: DD 00 DE 00 EC 00 ED 00 EE 00 EF 00 FC 00 FD 00 FE 00 FF 00 96 0D 9B 0D 7F 0D 91 0D A0 0D B1 0D 87 0D 8C 0D A5 0D AA 0D DD 00 DE 00 EC 00 ED 00 EE 00 EF 00 FC 00 FD 00 FE 00 FF 00 2D 0D 32 0D 15 0D 28 0D 37 0D 4A 0D 1E 0D 23 0D 3C 0D 45 0D 
        }

        private void FnLETSPORT_1E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0E2F  0003 FF 76 08  push word [bp+0x8]
0E32  0006 FF 76 06  push word [bp+0x6]
0E35  0009 0E     push cs
0E36  000A E8 41 F4  call 0xf44e
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: PushStack(player, 0x01);
            L0013: PushStack(player, ax);
            L0014: PushStack(player, 0x03);
0E44  0018 C4 5E 06  les bx, [bp+0x6]
0E47  001B 26 FF 1F  call far word [es:bx]
0E4A  001E 83 C4 06  add sp, 0x6
            L0021: ShowMessage(player, String0C9B); // An unstable platform forces you to stand alone at the western edge of Snake River.
            L002E: return; // RETURN;
        }

        private void FnTONWCRNR_1F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x01, 0x02, 0x00, 0x33, isForwardMove);
            L001D: return; // RETURN;
        }

        private void FnTOMIDWST_20(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x01, 0x02, 0x91, 0x03, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnSETFLAGW_21(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0E9E  0003 FF 76 08  push word [bp+0x8]
0EA1  0006 FF 76 06  push word [bp+0x6]
0EA4  0009 0E     push cs
0EA5  000A E8 D2 F3  call 0xf3df
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: SetFlag(player, 0x03, 0x01, 0x02);
            L0024: ShowMessage(player, String0CEE); // You are at the eastern end of Snake River.
            L0031: return; // RETURN;
            // Extra data: 55 8B EC B8 19 0D 50 C4 5E 06 26 FF 9F F8 00 59 5D CB 
        }

        private void FnWESTTXT_22(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0EE3  0003 FF 76 08  push word [bp+0x8]
0EE6  0006 FF 76 06  push word [bp+0x6]
0EE9  0009 0E     push cs
0EEA  000A E8 E1 FF  call 0xffee
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: return; // RETURN;
        }

        private void FnEASTTXT_23(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0EF4  0003 FF 76 08  push word [bp+0x8]
0EF7  0006 FF 76 06  push word [bp+0x6]
0EFA  0009 0E     push cs
0EFB  000A E8 D0 FF  call 0xffdd
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: return; // RETURN;
        }

        private void FnPORTTONE_24(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x00);
            L0006: PushStack(player, 0x02);
            L000A: PushStack(player, ax);
            L000B: PushStack(player, 0x01);
0F11  000F C4 5E 06  les bx, [bp+0x6]
0F14  0012 26 FF 9F BC 00  call far word [es:bx+0xbc]
0F19  0017 83 C4 08  add sp, 0x8
            L001A: return; // RETURN;
        }

        private void FnSTATEZRO_25(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x00);
0F24  0006 C4 5E 06  les bx, [bp+0x6]
0F27  0009 26 FF 5F 1C  call far word [es:bx+0x1c]
            L000D: cx = PopStack(player);
            L000E: return; // RETURN;
        }

        private void FnTEXT_26(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0D82); // Look at me again to gain more information!
            L0010: RefreshCompareFlags(GetFlag(player, 0x03, 0x07));
            L0023: if (JumpNotEqual) goto L0037;
            L0025: ShowMessage(player, String0DAD); // The door to the west is locked, but no lockpick can help you here! You must learn to use what is at hand in a more creative fashion.
0F60  0032 B8 01 00  mov ax, 0x1
            L0035: goto L0084;
            L0037: Compare(GetFlag(player, 0x03, 0x07), 0x0001);
            L004B: if (JumpNotEqual) goto L005F;
            L004D: ShowMessage(player, String0E32); // You must use something...something that could hack the lock off the door. Do not constrain yourself from using your belongings in a new way!
0F88  005A B8 02 00  mov ax, 0x2
            L005D: goto L0084;
            L005F: Compare(GetFlag(player, 0x03, 0x07), 0x0002);
            L0073: if (JumpNotEqual) goto L0096;
            L0075: ShowMessage(player, String0EBF); // Use a weapon, a sword or an axe, some form of blade or bludgeon, and you will be able to knock the lock off.
            L0082: SetFlag(player, 0x03, 0x07, 0x00);
            L0096: return; // RETURN;
        }

        private void FnLOCKTOBR_27(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasUsedItem(player, 0x01, 0x3E);
            L0016: if (JumpEqual) goto L0043;
            L0018: ShowMessage(player, String0F2C); // You've broken the lock! You may now enter and gain experience from your actions!
            L0025: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0043: return; // RETURN;
        }

        private void FnGAINWISD_28(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x02, 0x67));
            L0016: if (JumpNotEqual) goto L005E;
            L0018: ShowMessage(player, String0F7D); // Well done! Gain in experience and line your pockets with gold! Remember, there are more ways to use what you have than you remember.
            L0025: AddExperience(player, 0x000000C8);
            L0036: ModifyGold(player, 0x0064);
            L0047: SetFlag(player, 0x02, 0x67, 0x01);
            L005C: goto L006B;
            L005E: ShowMessage(player, String1002); // You've gained all you can from this test. You are welcome to bash the magical lock as often as you wish.
            L006B: return; // RETURN;
        }

        private void FnTEXTFORF_29(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0D82); // Look at me again to gain more information!
            L0010: RefreshCompareFlags(GetFlag(player, 0x03, 0x08));
            L0023: if (JumpNotEqual) goto L0037;
            L0025: ShowMessage(player, String106B); // The door to the east is locked, but no lockpick can help you here! You must learn to use what is at hand in a more creative fashion.
10AA  0032 B8 01 00  mov ax, 0x1
            L0035: goto L0084;
            L0037: Compare(GetFlag(player, 0x03, 0x08), 0x0001);
            L004B: if (JumpNotEqual) goto L005F;
            L004D: ShowMessage(player, String10F0); // You must use something...something that could fire the lock off the door. Do not constrain yourself from using your belongings in a new way!
10D2  005A B8 02 00  mov ax, 0x2
            L005D: goto L0084;
            L005F: Compare(GetFlag(player, 0x03, 0x08), 0x0002);
            L0073: if (JumpNotEqual) goto L0096;
            L0075: ShowMessage(player, String117D); // Use a scroll that would cast a magical force, capable of incinerating or blowing the door away!
            L0082: SetFlag(player, 0x03, 0x08, 0x00);
            L0096: return; // RETURN;
        }

        private void FnFLAMEDOR_2A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0xA5);
            L0007: PushStack(player, ax);
1118  0008 C4 5E 06  les bx, [bp+0x6]
111B  000B 26 FF 5F 54  call far word [es:bx+0x54]
            L000F: cx = PopStack(player);
            L0010: cx = PopStack(player);
            L0011: RefreshCompareFlags(ax);
            L0013: if (JumpEqual) goto L0018;
            L0015: goto L00A8;
            L0018: PushStack(player, 0xAA);
            L001C: PushStack(player, ax);
112D  001D C4 5E 06  les bx, [bp+0x6]
1130  0020 26 FF 5F 54  call far word [es:bx+0x54]
            L0024: cx = PopStack(player);
            L0025: cx = PopStack(player);
            L0026: RefreshCompareFlags(ax);
            L0028: if (JumpNotEqual) goto L00A8;
            L002A: PushStack(player, 0xB0);
            L002E: PushStack(player, ax);
113F  002F C4 5E 06  les bx, [bp+0x6]
1142  0032 26 FF 5F 54  call far word [es:bx+0x54]
            L0036: cx = PopStack(player);
            L0037: cx = PopStack(player);
            L0038: RefreshCompareFlags(ax);
            L003A: if (JumpNotEqual) goto L00A8;
            L003C: PushStack(player, 0xB4);
            L0040: PushStack(player, ax);
1151  0041 C4 5E 06  les bx, [bp+0x6]
1154  0044 26 FF 5F 54  call far word [es:bx+0x54]
            L0048: cx = PopStack(player);
            L0049: cx = PopStack(player);
            L004A: RefreshCompareFlags(ax);
            L004C: if (JumpNotEqual) goto L00A8;
            L004E: PushStack(player, 0x47);
            L0052: PushStack(player, ax);
1163  0053 C4 5E 06  les bx, [bp+0x6]
1166  0056 26 FF 5F 54  call far word [es:bx+0x54]
            L005A: cx = PopStack(player);
            L005B: cx = PopStack(player);
            L005C: RefreshCompareFlags(ax);
            L005E: if (JumpNotEqual) goto L00A8;
            L0060: PushStack(player, 0x55);
            L0064: PushStack(player, ax);
1175  0065 C4 5E 06  les bx, [bp+0x6]
1178  0068 26 FF 5F 54  call far word [es:bx+0x54]
            L006C: cx = PopStack(player);
            L006D: cx = PopStack(player);
            L006E: RefreshCompareFlags(ax);
            L0070: if (JumpNotEqual) goto L00A8;
            L0072: PushStack(player, 0x92);
            L0076: PushStack(player, ax);
1187  0077 C4 5E 06  les bx, [bp+0x6]
118A  007A 26 FF 5F 54  call far word [es:bx+0x54]
            L007E: cx = PopStack(player);
            L007F: cx = PopStack(player);
            L0080: RefreshCompareFlags(ax);
            L0082: if (JumpNotEqual) goto L00A8;
            L0084: PushStack(player, 0x9F);
            L0088: PushStack(player, ax);
1199  0089 C4 5E 06  les bx, [bp+0x6]
119C  008C 26 FF 5F 54  call far word [es:bx+0x54]
            L0090: cx = PopStack(player);
            L0091: cx = PopStack(player);
            L0092: RefreshCompareFlags(ax);
            L0094: if (JumpNotEqual) goto L00A8;
            L0096: PushStack(player, 0xAF);
            L009A: PushStack(player, ax);
11AB  009B C4 5E 06  les bx, [bp+0x6]
11AE  009E 26 FF 5F 54  call far word [es:bx+0x54]
            L00A2: cx = PopStack(player);
            L00A3: cx = PopStack(player);
            L00A4: RefreshCompareFlags(ax);
            L00A6: if (JumpEqual) goto L00BA;
            L00A8: ShowMessage(player, String11DD); // You've incinerated the door! Now you may enter and gain wisdom from your accomplishment.
11C5  00B5 B8 01 00  mov ax, 0x1
            L00B8: goto L00BC;
            L00BA: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L00D7: return; // RETURN;
        }

        private void FnFLAMDOOR_2B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x02, 0x9D));
            L0016: if (JumpNotEqual) goto L005E;
            L0018: ShowMessage(player, String0F7D); // Well done! Gain in experience and line your pockets with gold! Remember, there are more ways to use what you have than you remember.
            L0025: AddExperience(player, 0x000000C8);
            L0036: ModifyGold(player, 0x0064);
            L0047: SetFlag(player, 0x02, 0x9D, 0x01);
            L005C: goto L006B;
            L005E: ShowMessage(player, String1236); // You've gained all you can from this test. You are welcome to destroy the magical door as often as you wish.
            L006B: return; // RETURN;
        }

        private void FnMYSINCLU_2C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: si = GetFlag(player, 0x03, 0x09);
126D  0017 C4 5E 06  les bx, [bp+0x6]
1270  001A 26 FF 5F 10  call far word [es:bx+0x10]
            L001E: PushStack(player, ax);
            L001F: ax = GetCurrentTile(player);
            L0026: dx = PopStack(player);
127D  0027 3B D0  cmp dx, ax
            L0029: if (JumpNotEqual) goto L002E;
            L002B: goto L00F4;
1284  002E 0B F6  or si, si
            L0030: if (JumpNotEqual) goto L0035;
            L0032: si = 0x0001;
128B  0035 8B C6  mov ax, si
            L0037: Compare(ax, 0x0001);
            L003A: if (JumpEqual) goto L0043;
            L003C: Compare(ax, 0x0002);
            L003F: if (JumpEqual) goto L006F;
            L0041: goto L00A8;
            L0043: ShowPortrait(player, 0x002C);
            L0050: ShowMessage(player, String12A2); // You pass by a dwarf regaling some companions. 'I was trying to find a way across Lake Deluge or Desperate - something like that.
            L005D: ShowMessage(player, String1323); // Anyway, I stepped on a spot and I tell you, if I hadn't had the Life Jacket, I wouldn't be here today!'
            L006A: si = 0x0002;
            L006D: goto L00D2;
            L006F: ShowPortrait(player, 0x0019);
            L007C: ShowMessage(player, String138B); // A barbarian is lamenting with a companion over something he lost. 'I know I had it not long ago! That knight told us we needed the key to enter those secret rooms.
            L0089: ShowMessage(player, String142F); // We must find it! Hmmm, we did search that place on Lake Despair. Let's try looking back there.'
            L0096: ShowMessage(player, String148F); // With that, they hurry off to other adventures.
            L00A3: si = 0x0003;
            L00A6: goto L00D2;
            L00A8: ShowPortrait(player, 0x0025);
            L00B5: ShowMessage(player, String14BE); // A thief emerges from the shadows, 'There's an area in the Night Elves' Domain where the magic used to construct the walls will drive you to the fringe of madness!
            L00C2: ShowMessage(player, String1561); // Never have I seen the likes of these magical walls. I saw nothing, yet my path was blocked! Fret not, there is a hidden exit...though I fear this is not the last of the nightmare.
            L00CF: si = 0x0001;
            L00D2: SetFlag(player, 0xC4, 0xB8, si);
            L00E4: PushStack(player, GetCurrentTile(player));
1342  00EC C4 5E 06  les bx, [bp+0x6]
1345  00EF 26 FF 5F 1C  call far word [es:bx+0x1c]
            L00F3: cx = PopStack(player);
            L00F4: return; // RETURN (restoring si);
        }

    }
}
