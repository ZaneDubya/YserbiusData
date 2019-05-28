#pragma warning disable
using System.Collections.Generic;
using XPT.WorldData;
using XPT.WorldData.Yserbius;

namespace XPT.Scripts.Yserbius.Maps {
    class YserMap02 : AMapScripted {
        protected override int MapIndex => 2;
        protected override int RandomEncounterChance => 10;
        protected override int RandomEncounterExtraCount => 0;

        public YserMap02() {
            MapEvent01 = FnTOMAINXT_01;
            MapEvent02 = FnTOPORTST_02;
            MapEvent03 = FnTOLWRHAF_03;
            MapEvent04 = FnTOUPRHAF_04;
            MapEvent05 = FnMAZEMES_05;
            MapEvent06 = FnGNRICCLU_06;
            MapEvent07 = FnINONLY_07;
            MapEvent08 = FnOUTONLY_08;
            MapEvent09 = FnPORTTEST_09;
            MapEvent0B = FnPITQST_0B;
            MapEvent0C = FnCOILMESS_0C;
            MapEvent0D = FnHEALFNT_0D;
            MapEvent0F = FnGULDSPC_0F;
            MapEvent14 = FnEZBATONE_14;
            MapEvent15 = FnEZBATTWO_15;
            MapEvent16 = FnEZBATTRE_16;
            MapEvent17 = FnEZBATFOR_17;
            MapEvent18 = FnEZBATFIV_18;
            MapEvent19 = FnSECRET_19;
            MapEvent1A = FnQSTBAT_1A;
            MapEvent1B = FnEOGTELE_1B;
            MapEvent1C = FnREMOVEIT_1C;
            MapEvent1D = FnPFLAG_1D;
            MapEvent1E = FnSETFLAG_1E;
            MapEvent1F = FnWAYSOUTH_1F;
            MapEvent20 = FnTOLFTGNT_20;
            MapEvent21 = FnTOWESTCR_21;
            MapEvent22 = FnBACKWARD_22;
            MapEvent23 = FnHINTONE_23;
            MapEvent24 = FnHINTTWO_24;
            MapEvent25 = FnHINTTHRE_25;
            MapEvent26 = FnHINTFOR_26;
            MapEvent27 = FnHNTTOXIT_27;
            MapEvent28 = FnHNTTOGNT_28;
            MapEvent29 = FnRETURME_29;
            MapEvent2A = FnLOCKPICK_2A;
            MapEvent2B = FnFLAGSETR_2B;
            MapEvent2C = FnSNRIVER_2C;
            MapEvent2D = FnTOGNTWST_2D;
        }
        
        // === Strings ================================================
        private const string String03FC = "Through here is the Main Entrance.";
        private const string String041F = "Now, enter the Coil Maze, and retrieve the Gauntlet.";
        private const string String0454 = "To the North side....";
        private const string String046A = "The sign here reads: The gauntlet has been thrown down in the Coil Maze.";
        private const string String04B3 = "Now you must return it to its birth place, to solve this quest and complete this most simple phase.";
        private const string String0517 = "Depart not from the path which Fate has assigned you! You shall come full circle in time. And begin here what ends asunder.";
        private const string String0593 = "This way to the Great Egress.";
        private const string String05B1 = "The Great Egress...";
        private const string String05C5 = "As you see, not all teleports lead to a different dungeon.";
        private const string String0600 = "You've won the challenge of the Gauntlet. I shall send you to its end.";
        private const string String0647 = "A wind whistles, 'Bring me the gauntlet from the maze south of here....'";
        private const string String0690 = "A forceful wind pushes your party back from the ancient forge. It howls, 'You must each step forth alone!'";
        private const string String06FB = "Here you enter the Coils of the Maze...";
        private const string String0723 = "The refreshing waters heal your wounds.";
        private const string String074B = "The fountain does nothing for you.";
        private const string String076E = "Well done, great Barbarian!";
        private const string String078A = "Well done, noble Knight!";
        private const string String07A3 = "Well done, loyal Ranger!";
        private const string String07BC = "Well done, master Thief!";
        private const string String07D5 = "Well done, master Wizard!";
        private const string String07EF = "Well done, devout Cleric!";
        private const string String0809 = "Take this spell and this skill as rewards for your questing; and gain experience from your actions.";
        private const string String086D = "You've already received your rewards.";
        private const string String0893 = "Mages hurl magic at you!";
        private const string String08AC = "You come across some ancient Wizards!";
        private const string String08D2 = "And their familiars!";
        private const string String08E7 = "Some Berserkers turn to attack!";
        private const string String0907 = "Berserkers fighting over a spherical crystal draw you into the fray!";
        private const string String094C = "You encounter some novice adventurers.";
        private const string String0973 = "Wizards and Brigands traveling together challenge you to combat!  The wager is your life for their potion!";
        private const string String09DE = "Young thieves jump you!";
        private const string String09F6 = "A thief tucks a sheet of paper under his jacket as he and his colleagues hear you approach.";
        private const string String0A52 = "Small pinholes of light seep through the cracks in the wall here.";
        private const string String0A94 = "You've uncovered a hidden door!";
        private const string String0AB4 = "Rogues rush out at you from the shadows.";
        private const string String0ADD = "You spot the Lava Glove on the rogue leader's hand, as he signals his henchmen to attack!";
        private const string String0B37 = "This is the nexus point from where you start your final journey...";
        private const string String0B7A = "What a magnificent carving, you must come back and examine it more closely when you have time.";
        private const string String0BD9 = "But right now there's too much to do.";
        private const string String0BFF = "Swords and sorcery come rushing at you!";
        private const string String0C27 = "Duelists and Wizards attack as you approach.";
        private const string String0C54 = "This seems an odd place for a teleport.";
        private const string String0C7C = "Into the corner with you.";
        private const string String0C96 = "The Gauntlet is a useful item. But first you must enter the coils to retrieve it.";
        private const string String0CE8 = "The rewards are worthwhile, if you are careful and search all the corners.";
        private const string String0D33 = "Welcome to the southern half of The Gauntlet.";
        private const string String0D61 = "Feel free to explore the coils while you are here.";
        private const string String0D94 = "They can be found to the north by going east and south of where you are.";
        private const string String0DDD = "There must be a portal tucked away in some distant corner.";
        private const string String0E18 = "To the northeast, there lies such a portal.";
        private const string String0E44 = "Westward, an ancient foundry, now extinct, lies at the bottom of a shaft. It was here that the Lava Glove was born...and here it must return once you've retrieved it.";
        private const string String0EEB = "You've picked the lock. Proceed.";
        private const string String0F0C = "A locked door impedes your progress here.";
        private const string String0F36 = "Well done! Now, to the ancient foundry near the heart of this level. You must step onto the foundry in the center to return the Gauntlet!";
        private const string String0FC0 = "Hurry, your rewards await!";
        private const string String0FDB = "Magical waters spill out of the southern portal here; culminating in a small puddle on the floor.";
        private const string String103D = "To the Snake River.";
        private const string String1051 = "Your party must split and enter this narrow portal one by one to proceed.";
        
        // === Functions ================================================
        private void FnTOMAINXT_01(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String03FC); // Through here is the Main Entrance.
            L0010: PushStack(player, 0x00);
            L0013: PushStack(player, 0x8C);
            L0017: PushStack(player, 0x01);
            L001B: PushStack(player, ax);
0027  001C C4 5E 06  les bx, [bp+0x6]
002A  001F 26 FF 9F BC 00  call far word [es:bx+0xbc]
002F  0024 83 C4 08  add sp, 0x8
            L0027: return; // RETURN;
        }

        private void FnTOPORTST_02(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x01, 0x03, 0x9F, 0x01, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnTOLWRHAF_03(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String041F); // Now, enter the Coil Maze, and retrieve the Gauntlet.
            L0010: TeleportParty(player, 0x01, 0x03, 0xF7, 0x00, isForwardMove);
            L002A: return; // RETURN;
        }

        private void FnTOUPRHAF_04(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0454); // To the North side....
            L0010: TeleportParty(player, 0x01, 0x03, 0x9B, 0x03, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnMAZEMES_05(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String046A); // The sign here reads: The gauntlet has been thrown down in the Coil Maze.
            L0010: ShowMessage(player, String04B3); // Now you must return it to its birth place, to solve this quest and complete this most simple phase.
            L001D: return; // RETURN;
        }

        private void FnGNRICCLU_06(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0517); // Depart not from the path which Fate has assigned you! You shall come full circle in time. And begin here what ends asunder.
            L0010: return; // RETURN;
        }

        private void FnINONLY_07(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0593); // This way to the Great Egress.
            L0010: return; // RETURN;
        }

        private void FnOUTONLY_08(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String05B1); // The Great Egress...
            L0010: return; // RETURN;
        }

        private void FnPORTTEST_09(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String05C5); // As you see, not all teleports lead to a different dungeon.
            L0010: return; // RETURN;
        }

        private void FnPITQST_0B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: Compare(PartyCount(player), 0x0001);
            L000F: if (JumpEqual) goto L0014;
            L0011: goto L0090;
            L0013: // NOP
            L0014: ax = HasItem(player, 0xC8);
            L0022: if (JumpNotEqual) goto L003A;
            L0024: Compare(GetFlag(player, 0x02, 0x80), 0x0002);
            L0038: if (JumpNotEqual) goto L008B;
            L003A: RemoveItem(player, 0xC8);
            L0046: ShowMessage(player, String0600); // You've won the challenge of the Gauntlet. I shall send you to its end.
            L0053: bx = GetGuild(player);
            L005C: Compare(bx, 0x05);
            L005F: if (JumpAbove) goto L0084;
            L0061: switch (bx) {
                case 0:
                    goto L0068;
                case 1:
                    goto L006D;
                case 2:
                    goto L0072;
                case 3:
                    goto L0077;
                case 4:
                    goto L0081;
                case 5:
                    goto L007C;
            }
            L0068: si = 0x001F;
            L006B: goto L0084;
            L006D: si = 0x002F;
            L0070: goto L0084;
            L0072: si = 0x003F;
            L0075: goto L0084;
            L0077: si = 0x004F;
            L007A: goto L0084;
            L007C: si = 0x005F;
            L007F: goto L0084;
            L0081: si = 0x006F;
            L0084: PushStack(player, 0x02);
01A1  0088 56     push si
            L0089: goto L00A5;
01A4  008B B8 47 06  mov ax, 0x647
            L008E: goto L0093;
            L0090: ShowMessage(player, String0690); // A forceful wind pushes your party back from the ancient forge. It howls, 'You must each step forth alone!'
            L009D: TeleportParty(player, 0x01, 0x03, 0x78, 0x02, isForwardMove);
            L00B8: return; // RETURN (restoring si);
        }

        private void FnCOILMESS_0C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String06FB); // Here you enter the Coils of the Maze...
            L0010: return; // RETURN;
        }

        private void FnHEALFNT_0D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0042);
            L0010: ax = CheckLevel(player, 0x000A);
            L001E: if (JumpEqual) goto L0022;
            L0020: goto L0056;
            L0022: PushStack(player, GetCurrentHits(player));
            L002A: ax = GetMaxHits(player);
            L0031: dx = PopStack(player);
0224  0032 3B D0  cmp dx, ax
            L0034: if (JumpNotBelow) goto L0056;
            L0036: ShowMessage(player, String0723); // The refreshing waters heal your wounds.
            L0043: HealPlayer(player, GetMaxHits(player));
            L0054: goto L0063;
0248  0056 FF 76 08  push word [bp+0x8]
024B  0059 FF 76 06  push word [bp+0x6]
024E  005C 0E     push cs
024F  005D E8 05 00  call 0x65
            L0060: // NOP
            L0061: cx = PopStack(player);
            L0062: cx = PopStack(player);
            L0063: return; // RETURN;
            // Extra data: 55 8B EC B8 4B 07 50 C4 5E 06 26 FF 9F F8 00 59 5D CB 
        }

        private void FnGULDSPC_0F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0271  0003 83 EC 04  sub sp, 0x4
0274  0006 56     push si
0275  0007 57     push di
            L0008: PushStack(player, 0x02);
            L000C: PushStack(player, ax);
027B  000D C4 5E 06  les bx, [bp+0x6]
027E  0010 26 FF 5F 04  call far word [es:bx+0x4]
            L0014: cx = PopStack(player);
            L0015: cx = PopStack(player);
            L0016: RefreshCompareFlags(ax);
            L0018: if (JumpEqual) goto L001D;
            L001A: goto L0142;
            L001D: ax = GetCurrentTile(player);
0292  0024 89 46 FE  mov [bp-0x2], ax
0295  0027 B9 06 00  mov cx, 0x6
            L002A: bx = 0x03C3;
029B  002D 2E 8B 07  mov ax, [cs:bx]
029E  0030 3B 46 FE  cmp ax, [bp-0x2]
            L0033: if (JumpEqual) goto L003C;
02A3  0035 43     inc bx
02A4  0036 43     inc bx
02A5  0037 E2 F4  loop 0x2d
            L0039: goto L00D5;
02AA  003C 2E FF 67 0C  jmp word [cs:bx+0xc]
            L0040: ShowMessage(player, String076E); // Well done, great Barbarian!
            L004D: si = 0x0008;
            L0050: di = 0x000B;
02C1  0053 C7 46 FC BE 00  mov word [bp-0x4], 0xbe
            L0058: goto L00D5;
            L005A: // NOP
            L005B: ShowMessage(player, String078A); // Well done, noble Knight!
            L0068: si = 0x0016;
            L006B: di = 0x0003;
02DC  006E C7 46 FC A4 00  mov word [bp-0x4], 0xa4
            L0073: goto L00D5;
            L0075: ShowMessage(player, String07A3); // Well done, loyal Ranger!
            L0082: si = 0x0007;
            L0085: di = 0x0009;
02F6  0088 C7 46 FC 43 00  mov word [bp-0x4], 0x43
            L008D: goto L00D5;
            L008F: ShowMessage(player, String07BC); // Well done, master Thief!
            L009C: si = 0x0008;
            L009F: di = 0;
030F  00A1 C7 46 FC 73 00  mov word [bp-0x4], 0x73
            L00A6: goto L00D5;
            L00A8: ShowMessage(player, String07D5); // Well done, master Wizard!
            L00B5: si = 0x0011;
            L00B8: di = 0x0014;
            L00BB: goto L00D0;
            L00BD: ShowMessage(player, String07EF); // Well done, devout Cleric!
            L00CA: si = 0x0014;
            L00CD: di = 0x0008;
033E  00D0 C7 46 FC 2B 00  mov word [bp-0x4], 0x2b
            L00D5: PushStack(player, 0x01);
            L00D9: PushStack(player, 0x02);
            L00DD: PushStack(player, ax);
034C  00DE C4 5E 06  les bx, [bp+0x6]
034F  00E1 26 FF 1F  call far word [es:bx]
0352  00E4 83 C4 06  add sp, 0x6
            L00E7: SetFlag(player, 0x02, 0x80, 0x02);
            L00FC: ShowMessage(player, String0809); // Take this spell and this skill as rewards for your questing; and gain experience from your actions.
            L0109: AddExperience(player, 0x000003E8);
            L011A: PushStack(player, 0x01);
038C  011E 56     push si
038D  011F C4 5E 06  les bx, [bp+0x6]
0390  0122 26 FF 5F 60  call far word [es:bx+0x60]
            L0126: cx = PopStack(player);
            L0127: cx = PopStack(player);
            L0128: PushStack(player, 0x01);
039A  012C 57     push di
039B  012D C4 5E 06  les bx, [bp+0x6]
039E  0130 26 FF 5F 68  call far word [es:bx+0x68]
            L0134: cx = PopStack(player);
            L0135: cx = PopStack(player);
03A4  0136 FF 76 FC  push word [bp-0x4]
03A7  0139 C4 5E 06  les bx, [bp+0x6]
03AA  013C 26 FF 5F 48  call far word [es:bx+0x48]
            L0140: goto L014E;
            L0142: ShowMessage(player, String086D); // You've already received your rewards.
03BD  014F 5F     pop di
03BE  0150 5E     pop si
            L0151: // restore stack ptr: sp = bp;
            L0153: return; // RETURN;
            // Extra data: 1F 00 2F 00 3F 00 4F 00 5F 00 6F 00 AE 02 C9 02 E3 02 FD 02 16 03 2B 03 
        }

        private void FnEZBATONE_14(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: ax = HasItem(player, 0x8C);
            L0012: if (JumpEqual) goto L0019;
0403  0014 B8 93 08  mov ax, 0x893
            L0017: goto L0035;
            L0019: PushStack(player, 0x23);
            L001D: PushStack(player, 0x00);
            L0020: PushStack(player, ax);
            L0021: PushStack(player, ax);
            L0022: PushStack(player, ax);
            L0023: PushStack(player, 0x8C);
0416  0027 C4 5E 06  les bx, [bp+0x6]
0419  002A 26 FF 9F D8 00  call far word [es:bx+0xd8]
041E  002F 83 C4 0C  add sp, 0xc
            L0032: ShowMessage(player, String08AC); // You come across some ancient Wizards!
            L003F: Compare(PartyCount(player), 0x0001);
            L004A: if (JumpEqual) goto L0053;
            L004C: Compare(ax, 0x0002);
            L004F: if (JumpEqual) goto L0067;
            L0051: goto L0083;
            L0053: AddEncounter(player, 0x01, 0x1B);
            L0065: goto L00C4;
            L0067: si = 0x0001;
            L006A: goto L007C;
            L006C: AddEncounter(player, si, 0x1B);
            L007B: si = si + 1;
            L007C: Compare(si, 0x03);
            L007F: if (JumpLessOrEqual) goto L006C;
            L0081: goto L00C4;
            L0083: ShowMessage(player, String08D2); // And their familiars!
            L0090: si = 0x0001;
            L0093: goto L00A5;
            L0095: AddEncounter(player, si, 0x22);
            L00A4: si = si + 1;
            L00A5: Compare(si, 0x02);
            L00A8: if (JumpLessOrEqual) goto L0095;
            L00AA: si = 0x0003;
            L00AD: goto L00BF;
            L00AF: AddEncounter(player, si, 0x1B);
            L00BE: si = si + 1;
            L00BF: Compare(si, 0x04);
            L00C2: if (JumpLessOrEqual) goto L00AF;
            L00C4: return; // RETURN (restoring si);
        }

        private void FnEZBATTWO_15(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: ax = HasItem(player, 0xA4);
            L0012: if (JumpEqual) goto L0019;
04CA  0014 B8 E7 08  mov ax, 0x8e7
            L0017: goto L0035;
            L0019: PushStack(player, 0x64);
            L001D: PushStack(player, 0x00);
            L0020: PushStack(player, ax);
            L0021: PushStack(player, ax);
            L0022: PushStack(player, ax);
            L0023: PushStack(player, 0xA4);
04DD  0027 C4 5E 06  les bx, [bp+0x6]
04E0  002A 26 FF 9F D8 00  call far word [es:bx+0xd8]
04E5  002F 83 C4 0C  add sp, 0xc
            L0032: ShowMessage(player, String0907); // Berserkers fighting over a spherical crystal draw you into the fray!
            L003F: Compare(PartyCount(player), 0x0001);
            L004A: if (JumpEqual) goto L0053;
            L004C: Compare(ax, 0x0002);
            L004F: if (JumpEqual) goto L0067;
            L0051: goto L0083;
            L0053: AddEncounter(player, 0x01, 0x1F);
            L0065: goto L00B7;
            L0067: si = 0x0001;
            L006A: goto L007C;
            L006C: AddEncounter(player, si, 0x20);
            L007B: si = si + 1;
            L007C: Compare(si, 0x02);
            L007F: if (JumpLessOrEqual) goto L006C;
            L0081: goto L00B7;
            L0083: si = 0x0001;
            L0086: goto L0098;
            L0088: AddEncounter(player, si, 0x20);
            L0097: si = si + 1;
            L0098: Compare(si, 0x02);
            L009B: if (JumpLessOrEqual) goto L0088;
            L009D: si = 0x0003;
            L00A0: goto L00B2;
            L00A2: AddEncounter(player, si, 0x21);
            L00B1: si = si + 1;
            L00B2: Compare(si, 0x04);
            L00B5: if (JumpLessOrEqual) goto L00A2;
            L00B7: return; // RETURN (restoring si);
        }

        private void FnEZBATTRE_16(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: ax = HasItem(player, 0xB5);
            L0012: if (JumpEqual) goto L0023;
            L0014: ShowMessage(player, String094C); // You encounter some novice adventurers.
            L0021: goto L0049;
            L0023: ShowMessage(player, String0973); // Wizards and Brigands traveling together challenge you to combat!  The wager is your life for their potion!
            L0030: PushStack(player, 0x64);
            L0034: PushStack(player, 0x00);
            L0037: PushStack(player, ax);
            L0038: PushStack(player, ax);
            L0039: PushStack(player, ax);
            L003A: PushStack(player, 0xB5);
05AE  003E C4 5E 06  les bx, [bp+0x6]
05B1  0041 26 FF 9F D8 00  call far word [es:bx+0xd8]
05B6  0046 83 C4 0C  add sp, 0xc
            L0049: Compare(PartyCount(player), 0x0001);
            L0054: if (JumpEqual) goto L005D;
            L0056: Compare(ax, 0x0002);
            L0059: if (JumpEqual) goto L0071;
            L005B: goto L008C;
            L005D: AddEncounter(player, 0x01, 0x19);
            L006F: goto L00C0;
            L0071: AddEncounter(player, 0x01, 0x19);
            L0083: PushStack(player, 0x1A);
05F7  0087 B8 02 00  mov ax, 0x2
            L008A: goto L0064;
            L008C: si = 0x0001;
            L008F: goto L00A1;
            L0091: AddEncounter(player, si, 0x1A);
            L00A0: si = si + 1;
            L00A1: Compare(si, 0x02);
            L00A4: if (JumpLessOrEqual) goto L0091;
            L00A6: si = 0x0005;
            L00A9: goto L00BB;
            L00AB: AddEncounter(player, si, 0x19);
            L00BA: si = si + 1;
            L00BB: Compare(si, 0x06);
            L00BE: if (JumpLessOrEqual) goto L00AB;
            L00C0: return; // RETURN (restoring si);
        }

        private void FnEZBATFOR_17(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: Compare(PartyCount(player), 0x0001);
            L000F: if (JumpEqual) goto L0018;
            L0011: Compare(ax, 0x0002);
            L0014: if (JumpEqual) goto L002C;
            L0016: goto L0048;
            L0018: AddEncounter(player, 0x01, 0x23);
            L002A: goto L007C;
            L002C: si = 0x0001;
            L002F: goto L0041;
            L0031: AddEncounter(player, si, 0x23);
            L0040: si = si + 1;
            L0041: Compare(si, 0x02);
            L0044: if (JumpLessOrEqual) goto L0031;
            L0046: goto L007C;
            L0048: si = 0x0001;
            L004B: goto L005D;
            L004D: AddEncounter(player, si, 0x19);
            L005C: si = si + 1;
            L005D: Compare(si, 0x02);
            L0060: if (JumpLessOrEqual) goto L004D;
            L0062: si = 0x0003;
            L0065: goto L0077;
            L0067: AddEncounter(player, si, 0x23);
            L0076: si = si + 1;
            L0077: Compare(si, 0x05);
            L007A: if (JumpLessOrEqual) goto L0067;
            L007C: return; // RETURN (restoring si);
        }

        private void FnEZBATFIV_18(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0xB9);
            L0011: if (JumpEqual) goto L0018;
06C5  0013 B8 DE 09  mov ax, 0x9de
            L0016: goto L0034;
            L0018: PushStack(player, 0x64);
            L001C: PushStack(player, 0x00);
            L001F: PushStack(player, ax);
            L0020: PushStack(player, ax);
            L0021: PushStack(player, ax);
            L0022: PushStack(player, 0xB9);
06D8  0026 C4 5E 06  les bx, [bp+0x6]
06DB  0029 26 FF 9F D8 00  call far word [es:bx+0xd8]
06E0  002E 83 C4 0C  add sp, 0xc
            L0031: ShowMessage(player, String09F6); // A thief tucks a sheet of paper under his jacket as he and his colleagues hear you approach.
            L003E: Compare(PartyCount(player), 0x0001);
            L0049: if (JumpEqual) goto L0058;
            L004B: Compare(PartyCount(player), 0x0002);
            L0056: if (JumpNotEqual) goto L0073;
            L0058: AddEncounter(player, 0x01, 0x23);
            L006A: PushStack(player, 0x22);
0720  006E B8 02 00  mov ax, 0x2
            L0071: goto L00B0;
            L0073: AddEncounter(player, 0x01, 0x22);
            L0085: AddEncounter(player, 0x02, 0x23);
            L0097: AddEncounter(player, 0x03, 0x24);
            L00A9: AddEncounter(player, 0x04, 0x25);
            L00BB: return; // RETURN;
        }

        private void FnSECRET_19(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0A52); // Small pinholes of light seep through the cracks in the wall here.
            L0010: Compare(HasUsedSkill(player, 0x0D), 0x0003);
            L001F: if (JumpNotBelow) goto L0079;
            L0021: RefreshCompareFlags(HasUsedSpell(player, 0x17));
            L002F: if (JumpNotEqual) goto L0079;
            L0031: PushStack(player, 0xA4);
            L0035: PushStack(player, ax);
07A5  0036 C4 5E 06  les bx, [bp+0x6]
07A8  0039 26 FF 5F 54  call far word [es:bx+0x54]
            L003D: cx = PopStack(player);
            L003E: cx = PopStack(player);
            L003F: RefreshCompareFlags(ax);
            L0041: if (JumpNotEqual) goto L0079;
            L0043: PushStack(player, 0x6E);
            L0047: PushStack(player, ax);
07B7  0048 C4 5E 06  les bx, [bp+0x6]
07BA  004B 26 FF 5F 54  call far word [es:bx+0x54]
            L004F: cx = PopStack(player);
            L0050: cx = PopStack(player);
            L0051: RefreshCompareFlags(ax);
            L0053: if (JumpNotEqual) goto L0079;
            L0055: PushStack(player, 0x90);
            L0059: PushStack(player, ax);
07C9  005A C4 5E 06  les bx, [bp+0x6]
07CC  005D 26 FF 5F 54  call far word [es:bx+0x54]
            L0061: cx = PopStack(player);
            L0062: cx = PopStack(player);
            L0063: RefreshCompareFlags(ax);
            L0065: if (JumpNotEqual) goto L0079;
            L0067: PushStack(player, 0x68);
            L006B: PushStack(player, ax);
07DB  006C C4 5E 06  les bx, [bp+0x6]
07DE  006F 26 FF 5F 54  call far word [es:bx+0x54]
            L0073: cx = PopStack(player);
            L0074: cx = PopStack(player);
            L0075: RefreshCompareFlags(ax);
            L0077: if (JumpEqual) goto L00C1;
            L0079: SetWallObject(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L0097: ShowMessage(player, String0A94); // You've uncovered a hidden door!
            L00A4: PushStack(player, 0x01);
            L00A8: PushStack(player, GetFacing(player));
            L00B0: PushStack(player, GetCurrentTile(player));
0827  00B8 C4 5E 06  les bx, [bp+0x6]
082A  00BB 26 FF 5F 2C  call far word [es:bx+0x2c]
            L00BF: goto L00F8;
            L00C1: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L00DE: SetWallObject(player, 0x00, GetCurrentTile(player), GetFacing(player));
            L00FB: return; // RETURN;
        }

        private void FnQSTBAT_1A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: ax = HasItem(player, 0xC8);
            L0012: if (JumpEqual) goto L0033;
            L0014: ShowMessage(player, String0AB4); // Rogues rush out at you from the shadows.
            L0021: PushStack(player, 0xFA);
            L0025: PushStack(player, 0x00);
            L0028: PushStack(player, ax);
            L0029: PushStack(player, ax);
            L002A: PushStack(player, 0xB5);
089A  002E B8 03 00  mov ax, 0x3
            L0031: goto L00A9;
            L0033: Compare(GetFlag(player, 0x02, 0x80), 0x0002);
            L0047: if (JumpEqual) goto L005E;
            L0049: RefreshCompareFlags(GetFlag(player, 0x02, 0x80));
            L005C: if (JumpNotEqual) goto L007C;
            L005E: ShowMessage(player, String0ADD); // You spot the Lava Glove on the rogue leader's hand, as he signals his henchmen to attack!
08D7  006B B8 E8 03  mov ax, 0x3e8
            L006E: PushStack(player, ax);
            L006F: PushStack(player, 0x00);
            L0072: PushStack(player, ax);
            L0073: PushStack(player, 0xB6);
08E3  0077 B8 CC 00  mov ax, 0xcc
            L007A: goto L00A5;
            L007C: ax = HasItem(player, 0xC8);
            L008A: if (JumpNotEqual) goto L00B5;
            L008C: ShowMessage(player, String0ADD); // You spot the Lava Glove on the rogue leader's hand, as he signals his henchmen to attack!
            L0099: PushStack(player, 0xFA);
            L009D: PushStack(player, 0x00);
            L00A0: PushStack(player, ax);
            L00A1: PushStack(player, ax);
            L00A2: PushStack(player, 0xB5);
            L00A6: PushStack(player, 0xC8);
0916  00AA C4 5E 06  les bx, [bp+0x6]
0919  00AD 26 FF 9F D8 00  call far word [es:bx+0xd8]
091E  00B2 83 C4 0C  add sp, 0xc
            L00B5: Compare(PartyCount(player), 0x0001);
            L00C0: if (JumpEqual) goto L00C9;
            L00C2: Compare(ax, 0x0002);
            L00C5: if (JumpEqual) goto L00E4;
            L00C7: goto L00FF;
            L00C9: AddEncounter(player, 0x01, 0x1A);
            L00DB: PushStack(player, 0x25);
094B  00DF B8 05 00  mov ax, 0x5
            L00E2: goto L0132;
            L00E4: AddEncounter(player, 0x01, 0x1A);
            L00F6: PushStack(player, 0x1C);
0966  00FA B8 02 00  mov ax, 0x2
            L00FD: goto L0120;
            L00FF: si = 0x0001;
            L0102: goto L0114;
            L0104: AddEncounter(player, si, 0x1A);
            L0113: si = si + 1;
            L0114: Compare(si, 0x04);
            L0117: if (JumpLessOrEqual) goto L0104;
            L0119: AddEncounter(player, 0x05, 0x1D);
            L012B: AddEncounter(player, 0x06, 0x25);
            L013D: return; // RETURN (restoring si);
        }

        private void FnEOGTELE_1B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0xDF), 0x0001);
            L0017: if (JumpNotEqual) goto L0043;
            L0019: ShowMessage(player, String0B37); // This is the nexus point from where you start your final journey...
            L0026: TeleportParty(player, 0x02, 0x03, 0xFF, 0x03, isForwardMove);
            L0041: goto L005D;
            L0043: ShowMessage(player, String0B7A); // What a magnificent carving, you must come back and examine it more closely when you have time.
            L0050: ShowMessage(player, String0BD9); // But right now there's too much to do.
            L005D: return; // RETURN;
        }

        private void FnREMOVEIT_1C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetWallObject(player, 0x00, 0x9D, 0x00);
            L0017: SetWallObject(player, 0x00, 0x7C, 0x00);
            L002B: return; // RETURN;
        }

        private void FnPFLAG_1D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x01));
            L0016: if (JumpNotEqual) goto L0027;
            L0018: ShowMessage(player, String0BFF); // Swords and sorcery come rushing at you!
            L0025: goto L0066;
            L0027: Compare(GetFlag(player, 0x03, 0x01), 0x0001);
            L003B: if (JumpNotEqual) goto L0066;
            L003D: ShowMessage(player, String0C27); // Duelists and Wizards attack as you approach.
            L004A: PushStack(player, 0xC8);
            L004E: PushStack(player, 0x00);
            L0051: PushStack(player, ax);
            L0052: PushStack(player, ax);
            L0053: PushStack(player, 0x2B);
            L0057: PushStack(player, 0x02);
0A93  005B C4 5E 06  les bx, [bp+0x6]
0A96  005E 26 FF 9F D8 00  call far word [es:bx+0xd8]
0A9B  0063 83 C4 0C  add sp, 0xc
            L0066: Compare(PartyCount(player), 0x0001);
            L0071: if (JumpEqual) goto L0080;
            L0073: Compare(PartyCount(player), 0x0002);
            L007E: if (JumpNotEqual) goto L009B;
            L0080: AddEncounter(player, 0x01, 0x26);
            L0092: PushStack(player, 0x27);
0ACE  0096 B8 05 00  mov ax, 0x5
            L0099: goto L00D8;
            L009B: AddEncounter(player, 0x01, 0x27);
            L00AD: AddEncounter(player, 0x02, 0x28);
            L00BF: AddEncounter(player, 0x03, 0x26);
            L00D1: AddEncounter(player, 0x04, 0x27);
            L00E3: return; // RETURN;
        }

        private void FnSETFLAG_1E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: PushStack(player, 0x01);
            L0008: PushStack(player, 0x00);
0B28  000B C4 5E 06  les bx, [bp+0x6]
0B2B  000E 26 FF 5F 04  call far word [es:bx+0x4]
            L0012: cx = PopStack(player);
            L0013: cx = PopStack(player);
            L0014: RefreshCompareFlags(ax);
            L0016: if (JumpNotEqual) goto L0054;
            L0018: si = GetFlag(player, 0x03, 0x01);
            L002B: Compare(si, 0x01);
            L002E: if (JumpGreater) goto L0043;
            L0030: si = si + 1;
            L0031: SetFlag(player, 0xC4, 0xB8, si);
            L0043: PushStack(player, 0x01);
            L0047: PushStack(player, ax);
            L0048: PushStack(player, 0x00);
0B68  004B C4 5E 06  les bx, [bp+0x6]
0B6B  004E 26 FF 1F  call far word [es:bx]
0B6E  0051 83 C4 06  add sp, 0x6
            L0054: return; // RETURN (restoring si);
        }

        private void FnWAYSOUTH_1F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0C54); // This seems an odd place for a teleport.
            L0010: TeleportParty(player, 0x01, 0x03, 0x7B, 0x01, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnTOLFTGNT_20(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x01, 0x03, 0x98, 0x00, isForwardMove);
            L001D: return; // RETURN;
        }

        private void FnTOWESTCR_21(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0C7C); // Into the corner with you.
            L0010: TeleportParty(player, 0x01, 0x03, 0xF0, 0x02, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnBACKWARD_22(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x01, 0x03, 0xFA, 0x03, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnHINTONE_23(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowRunes(player, String0C96); // The Gauntlet is a useful item. But first you must enter the coils to retrieve it.
            L0010: return; // RETURN;
        }

        private void FnHINTTWO_24(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0CE8); // The rewards are worthwhile, if you are careful and search all the corners.
            L0010: return; // RETURN;
        }

        private void FnHINTTHRE_25(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0D33); // Welcome to the southern half of The Gauntlet.
            L0010: ShowMessage(player, String0D61); // Feel free to explore the coils while you are here.
            L001D: return; // RETURN;
        }

        private void FnHINTFOR_26(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowRunes(player, String0D94); // They can be found to the north by going east and south of where you are.
            L0010: return; // RETURN;
        }

        private void FnHNTTOXIT_27(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0DDD); // There must be a portal tucked away in some distant corner.
            L0010: return; // RETURN;
        }

        private void FnHNTTOGNT_28(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowRunes(player, String0E18); // To the northeast, there lies such a portal.
            L0010: return; // RETURN;
        }

        private void FnRETURME_29(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0E44); // Westward, an ancient foundry, now extinct, lies at the bottom of a shaft. It was here that the Lava Glove was born...and here it must return once you've retrieved it.
            L0010: return; // RETURN;
        }

        private void FnLOCKPICK_2A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasUsedItem(player, 0xBE, 0xC0);
            L0016: if (JumpNotEqual) goto L0029;
            L0018: Compare(HasUsedSkill(player, 0x0E), 0x0001);
            L0027: if (JumpBelowOrEqual) goto L0056;
            L0029: ShowMessage(player, String0EEB); // You've picked the lock. Proceed.
            L0036: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0054: goto L0080;
            L0056: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0073: ShowMessage(player, String0F0C); // A locked door impedes your progress here.
            L0080: return; // RETURN;
        }

        private void FnFLAGSETR_2B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0xC8);
            L0011: if (JumpEqual) goto L0057;
            L0013: RefreshCompareFlags(GetFlag(player, 0x02, 0x80));
            L0026: if (JumpNotEqual) goto L0057;
            L0028: SetFlag(player, 0x02, 0x80, 0x01);
            L003D: ShowMessage(player, String0F36); // Well done! Now, to the ancient foundry near the heart of this level. You must step onto the foundry in the center to return the Gauntlet!
            L004A: ShowMessage(player, String0FC0); // Hurry, your rewards await!
            L0057: return; // RETURN;
        }

        private void FnSNRIVER_2C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0FDB); // Magical waters spill out of the southern portal here; culminating in a small puddle on the floor.
            L0010: return; // RETURN;
        }

        private void FnTOGNTWST_2D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L0039;
            L0010: ShowMessage(player, String103D); // To the Snake River.
            L001D: TeleportParty(player, 0x01, 0x02, 0xDF, 0x00, isForwardMove);
            L0037: goto L0065;
            L0039: TeleportParty(player, 0x01, 0x03, GetCurrentTile(player), 0x03, isForwardMove);
            L0058: ShowMessage(player, String1051); // Your party must split and enter this narrow portal one by one to proceed.
            L0065: return; // RETURN;
        }

    }
}
