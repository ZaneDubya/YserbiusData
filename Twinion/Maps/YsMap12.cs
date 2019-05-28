#pragma warning disable
using System.Collections.Generic;
using XPT.WorldData;
using XPT.WorldData.Yserbius;

namespace XPT.Scripts.Yserbius.Maps {
    class YserMap12 : AMapScripted {
        protected override int MapIndex => 12;
        protected override int RandomEncounterChance => 10;
        protected override int RandomEncounterExtraCount => 0;

        public YserMap12() {
            MapEvent01 = FnTELEA_01;
            MapEvent02 = FnGOODIEA_02;
            MapEvent04 = FnRIDDLEAR_04;
            MapEvent05 = FnTELEB_05;
            MapEvent06 = FnTELEC_06;
            MapEvent07 = FnTELED_07;
            MapEvent08 = FnTYNDIL_08;
            MapEvent09 = FnKALYDOR_09;
            MapEvent0A = FnTELEEE_0A;
            MapEvent0B = FnGNOMEDR_0B;
            MapEvent0C = FnHALFLING_0C;
            MapEvent0D = FnORC_0D;
            MapEvent0E = FnTROLL_0E;
            MapEvent0F = FnCARTOG_0F;
            MapEvent10 = FnRIDDLEB_10;
            MapEvent11 = FnTELEF_11;
            MapEvent12 = FnRIDDLEC_12;
            MapEvent13 = FnQUEEN_13;
            MapEvent14 = FnPARTYCK_14;
            MapEvent15 = FnELF_15;
            MapEvent16 = FnDWARF_16;
            MapEvent17 = FnTELEG_17;
            MapEvent18 = FnRIDDLED_18;
            MapEvent19 = FnTELEH_19;
            MapEvent1A = FnGREMLIN_1A;
            MapEvent1B = FnHUMAN_1B;
            MapEvent1C = FnOUTTEXT_1C;
            MapEvent1E = FnTELEI_1E;
            MapEvent23 = FnMANADOWN_23;
            MapEvent28 = FnRIDDLEE_28;
            MapEvent29 = FnTELEJ_29;
            MapEvent2A = FnTELEK_2A;
            MapEvent2F = FnRIDDLEF_2F;
            MapEvent34 = FnRIDDLEG_34;
            MapEvent39 = FnCLUEB_39;
            MapEvent3A = FnCLUEC_3A;
            MapEvent3C = FnTELEL_3C;
            MapEvent3D = FnSECA_3D;
            MapEvent3E = FnTELEM_3E;
            MapEvent3F = FnDABELAIS_3F;
            MapEvent41 = FnSYRENE_41;
            MapEvent42 = FnRIDDLEH_42;
            MapEvent43 = FnRIDDLEH_43;
            MapEvent44 = FnTELEN_44;
            MapEvent45 = FnTELEO_45;
            MapEvent46 = FnTELEP_46;
            MapEvent47 = FnFTNA_47;
            MapEvent4B = FnHRDA_4B;
            MapEvent4D = FnHRDB_4D;
            MapEvent4F = FnMEDD_4F;
            MapEvent50 = FnHRDC_50;
            MapEvent51 = Fn_51;
        }
        
        // === Strings ================================================
        private const string String03FC = "You enter a room where golems await you.";
        private const string String0425 = "A bard sings his tale in the Cloister.";
        private const string String044C = "If true, continue south. If false, walk west.";
        private const string String047A = "Tyndil is not in his office.";
        private const string String0497 = "The crafty Tyndil invites you into his office.";
        private const string String04C6 = "'I offer a precious token in exchange for a mere glance at your map pieces. Thank you!'";
        private const string String051E = "Kalydor is not in his office.";
        private const string String053C = "Kalydor's excitement is obvious.";
        private const string String055D = "'Take this precious bauble in exchange for one look at your map pieces. Ah, yes, very good!'";
        private const string String05BA = "This portal will send you to the Main Entrance.";
        private const string String05EA = "You've unlocked this door!";
        private const string String0605 = "Now proceed to the next lock.";
        private const string String0623 = "Use the correct token to unlock this door.";
        private const string String064E = "'Intrepid Gnome, if you have read the secret clues, use your tokens as the keys.'";
        private const string String06A0 = "The doors remain open for you.";
        private const string String06BF = "'Worthy Halfling, if you have read the secret clues, use your tokens as the keys.'";
        private const string String0712 = "'Brave Orc, if you have read the secret clues, use your tokens as the keys.'";
        private const string String075F = "'Courageous Troll, if you have read the secret clues, use the tokens as the keys.'";
        private const string String07B2 = "Xanith smiles as you draw near.";
        private const string String07D2 = "'I see you have mastered my riddles. To the west are some doors. Proceed alone through the door designated for your race.'";
        private const string String084D = "'You must use your tokens in the order you were told, lest dire consequences befall you!'";
        private const string String08A7 = "Angel Fountain is in Cliffhanger. If true, continue south. If false, walk north.";
        private const string String08F8 = "To the Graveyard.";
        private const string String090A = "The Emerald Lockpick is exchanged for the Diamond Lockpick. If true, take the door to the south. If false, take the door to the east.";
        private const string String0990 = "Queen Aeowyn materializes in the room.";
        private const string String09B7 = "'Greetings, my Champion. Now we may bond these fragments together in this magical space.'";
        private const string String0A11 = "Aeowyn examines the pieces closely and then arranges them on the floor in a peculiar order.";
        private const string String0A6D = "'Ahh...look!' You watch as the tokens release their magical properties and fuse together the map pieces.";
        private const string String0AD6 = "'Now, take this map and use it as the key through the northern gateway opposite the Night Elves' portal in the Main Entrance.";
        private const string String0B54 = "Fare thee well.' The Queen then vanishes.";
        private const string String0B7E = "A quiet breezes wafts through this area.";
        private const string String0BA7 = "You must enter here alone!";
        private const string String0BC2 = "Proceed.";
        private const string String0BCB = "'Fearless Elf, if you have read the secret clues, use your tokens as the keys.'";
        private const string String0C1B = "'Valiant Dwarf, if you have read the secret clues, use your tokens as the keys.'";
        private const string String0C6C = "The Vault is found in Twinion Keep. If true, continue east. If false, walk west.";
        private const string String0CBD = "'Hardy Gremlin, if you have read the secret clues, use your tokens as the keys.'";
        private const string String0D0E = "'Adventurous Human, if you have read the secret clues, use the tokens as the keys.'";
        private const string String0D62 = "To go back and search for your clues, exit here.";
        private const string String0D93 = "The musty smell of old maps is overpowering. You sense your mana being leeched away.";
        private const string String0DE8 = "The only way to Race Track is from Rat Race. If true, continue north. If false, walk east.";
        private const string String0E43 = "Harmonics should visit the Tool Shed for a reward. If true, continue west. If false, walk east.";
        private const string String0EA3 = "Smug owns a Pawn Shop. If true, continue west. If false, walk south.";
        private const string String0EE8 = "A book on the table reads, 'Futility is the price you pay for returning to the Cartography Shop ere you know the riddles' answers.'";
        private const string String0F6C = "A path of correct answers will lead you directly to the Cartographer.";
        private const string String0FB2 = "A secret door is revealed.";
        private const string String0FCD = "Dabelais is not in his office.";
        private const string String0FEC = "Dabelais looks up and says, 'Accept this token as payment for showing me your map pieces.'";
        private const string String1047 = "Syrene is not in her office.";
        private const string String1064 = "Syrene greets you. 'Adventurers, I offer a token for a glance at your map pieces.'";
        private const string String10B7 = "Unity Fountain is found in Rat Race. If true, continue east. If false, walk west.";
        private const string String1109 = "Fellowship Fountain is found in the Armory. If true, continue south. If false, walk north.";
        private const string String1164 = "The twinkling waters of NorthStar Fountain restore your mana.";
        private const string String11A2 = "The twinkling waters of NorthStar Fountain restore your mana and increase your Strength and Initiative.";
        private const string String120A = "You failed to use the correct item.";
        
        // === Functions ================================================
        private void FnTELEA_01(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x05, 0x02, 0xF0, 0x03, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnGOODIEA_02(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String03FC); // You enter a room where golems await you.
            L0010: ax = HasItem(player, 0xCD);
            L001E: if (JumpNotEqual) goto L0030;
            L0020: ax = HasItem(player, 0x29);
            L002E: if (JumpEqual) goto L0042;
005E  0030 B8 DC 05  mov ax, 0x5dc
            L0033: PushStack(player, ax);
            L0034: PushStack(player, 0x00);
            L0037: PushStack(player, ax);
            L0038: PushStack(player, ax);
            L0039: PushStack(player, 0x9D);
006B  003D B8 2D 00  mov ax, 0x2d
            L0040: goto L0052;
0070  0042 B8 B8 0B  mov ax, 0xbb8
            L0045: PushStack(player, ax);
            L0046: PushStack(player, 0x00);
            L0049: PushStack(player, ax);
            L004A: PushStack(player, ax);
            L004B: PushStack(player, 0x29);
            L004F: PushStack(player, 0xCD);
0081  0053 C4 5E 06  les bx, [bp+0x6]
0084  0056 26 FF 9F D8 00  call far word [es:bx+0xd8]
0089  005B 83 C4 0C  add sp, 0xc
            L005E: Compare(PartyCount(player), 0x0001);
            L0069: if (JumpNotEqual) goto L0086;
            L006B: AddEncounter(player, 0x01, 0x07);
            L007D: PushStack(player, 0x08);
00AF  0081 B8 02 00  mov ax, 0x2
            L0084: goto L00FD;
            L0086: Compare(PartyCount(player), 0x0002);
            L0091: if (JumpNotEqual) goto L00AE;
            L0093: AddEncounter(player, 0x01, 0x07);
            L00A5: PushStack(player, 0x09);
00D7  00A9 B8 02 00  mov ax, 0x2
            L00AC: goto L00EB;
            L00AE: AddEncounter(player, 0x01, 0x07);
            L00C0: AddEncounter(player, 0x02, 0x07);
            L00D2: AddEncounter(player, 0x03, 0x08);
            L00E4: AddEncounter(player, 0x05, 0x09);
            L00F6: AddEncounter(player, 0x06, 0x09);
            L0108: return; // RETURN;
        }

        private void FnRIDDLEAR_04(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0425); // A bard sings his tale in the Cloister.
            L0010: ShowMessage(player, String044C); // If true, continue south. If false, walk west.
            L001D: return; // RETURN;
        }

        private void FnTELEB_05(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x05, 0x02, 0x5D, 0x01, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnTELEC_06(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x05, 0x02, 0xA5, 0x03, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnTELED_07(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x05, 0x02, 0x45, 0x00, isForwardMove);
            L001D: return; // RETURN;
        }

        private void FnTYNDIL_08(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: // make space for tmp on stack: sp -= 2
01C0  0005 56     push si
            L0006: si = 0;
            L0008: ax = GetRace(player);
01CA  000F 89 46 FE  mov [bp-0x2], ax
            L0012: RefreshCompareFlags(ax);
            L0014: if (JumpEqual) goto L0018;
            L0016: goto L001D;
            L0018: si = 0x00E2;
            L001B: goto L0020;
            L001D: si = 0x00E6;
01DB  0020 56     push si
01DC  0021 C4 5E 06  les bx, [bp+0x6]
01DF  0024 26 FF 5F 50  call far word [es:bx+0x50]
            L0028: cx = PopStack(player);
            L0029: RefreshCompareFlags(ax);
            L002B: if (JumpNotEqual) goto L0043;
            L002D: Compare(GetFlag(player, 0x02, 0x3C), 0x0001);
            L0041: if (JumpNotEqual) goto L0048;
01FE  0043 B8 7A 04  mov ax, 0x47a
            L0046: goto L006E;
0203  0048 56     push si
0204  0049 C4 5E 06  les bx, [bp+0x6]
0207  004C 26 FF 5F 48  call far word [es:bx+0x48]
            L0050: cx = PopStack(player);
            L0051: ShowPortrait(player, 0x002D);
            L005E: ShowMessage(player, String0497); // The crafty Tyndil invites you into his office.
            L006B: ShowMessage(player, String04C6); // 'I offer a precious token in exchange for a mere glance at your map pieces. Thank you!'
0233  0078 5E     pop si
            L0079: // restore stack ptr: sp = bp;
            L007B: return; // RETURN;
        }

        private void FnKALYDOR_09(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: // make space for tmp on stack: sp -= 2
023D  0005 56     push si
            L0006: si = 0;
            L0008: ax = GetRace(player);
0247  000F 89 46 FE  mov [bp-0x2], ax
            L0012: Compare(ax, 0x0005);
            L0015: if (JumpEqual) goto L001E;
            L0017: Compare(ax, 0x0007);
            L001A: if (JumpEqual) goto L001E;
            L001C: goto L0023;
            L001E: si = 0x00E2;
            L0021: goto L0026;
            L0023: si = 0x00E3;
025E  0026 56     push si
025F  0027 C4 5E 06  les bx, [bp+0x6]
0262  002A 26 FF 5F 50  call far word [es:bx+0x50]
            L002E: cx = PopStack(player);
            L002F: RefreshCompareFlags(ax);
            L0031: if (JumpNotEqual) goto L0049;
            L0033: Compare(GetFlag(player, 0x02, 0x3C), 0x0001);
            L0047: if (JumpNotEqual) goto L004E;
0281  0049 B8 1E 05  mov ax, 0x51e
            L004C: goto L0074;
            L004E: ShowPortrait(player, 0x001A);
0293  005B 56     push si
0294  005C C4 5E 06  les bx, [bp+0x6]
0297  005F 26 FF 5F 48  call far word [es:bx+0x48]
            L0063: cx = PopStack(player);
            L0064: ShowMessage(player, String053C); // Kalydor's excitement is obvious.
            L0071: ShowMessage(player, String055D); // 'Take this precious bauble in exchange for one look at your map pieces. Ah, yes, very good!'
02B6  007E 5E     pop si
            L007F: // restore stack ptr: sp = bp;
            L0081: return; // RETURN;
        }

        private void FnTELEEE_0A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String05BA); // This portal will send you to the Main Entrance.
            L0010: PushStack(player, 0x03);
            L0014: PushStack(player, 0xCC);
            L0018: PushStack(player, 0x01);
            L001C: PushStack(player, ax);
02D8  001D C4 5E 06  les bx, [bp+0x6]
02DB  0020 26 FF 9F BC 00  call far word [es:bx+0xbc]
02E0  0025 83 C4 08  add sp, 0x8
            L0028: return; // RETURN;
        }

        private void FnGNOMEDR_0B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
02E8  0003 83 EC 08  sub sp, 0x8
02EB  0006 56     push si
02EC  0007 57     push di
            L0008: si = 0;
02EF  000A C7 46 FE 01 00  mov word [bp-0x2], 0x1
            L000F: di = 0;
02F6  0011 C7 46 FC 00 00  mov word [bp-0x4], 0x0
02FB  0016 C7 46 FA FE 00  mov word [bp-0x6], 0xfe
            L001B: RefreshCompareFlags(GetFlag(player, 0x02, 0x3C));
            L002E: if (JumpEqual) goto L0033;
            L0030: goto L0144;
            L0033: Compare(PartyCount(player), 0x0001);
            L003E: if (JumpEqual) goto L0043;
            L0040: goto L012A;
            L0043: Compare(GetRace(player), 0x0005);
            L004D: if (JumpEqual) goto L0052;
            L004F: goto L012A;
            L0052: ax = GetCurrentTile(player);
033E  0059 89 46 F8  mov [bp-0x8], ax
0341  005C 8B 5E F8  mov bx, [bp-0x8]
0344  005F 83 EB 71  sub bx, 0x71
            L0062: Compare(bx, 0x03);
            L0065: if (JumpAbove) goto L00A0;
            L0067: switch (bx) {
                case 0:
                    goto L0095;
                case 1:
                    goto L0088;
                case 2:
                    goto L007B;
                case 3:
                    goto L006E;
            }
            L006E: si = 0x00E5;
            L0071: di = 0x00E4;
0359  0074 C7 46 FC E6 00  mov word [bp-0x4], 0xe6
            L0079: goto L00A0;
            L007B: si = 0x00E2;
            L007E: di = 0x00E1;
0366  0081 C7 46 FC E3 00  mov word [bp-0x4], 0xe3
            L0086: goto L00A0;
            L0088: si = 0x00E6;
            L008B: di = 0x00E5;
0373  008E C7 46 FC E7 00  mov word [bp-0x4], 0xe7
            L0093: goto L00A0;
            L0095: si = 0x00E4;
            L0098: di = 0x00E3;
0380  009B C7 46 FC E5 00  mov word [bp-0x4], 0xe5
0385  00A0 57     push di
0386  00A1 FF 76 FE  push word [bp-0x2]
0389  00A4 C4 5E 06  les bx, [bp+0x6]
038C  00A7 26 FF 5F 54  call far word [es:bx+0x54]
            L00AB: cx = PopStack(player);
            L00AC: cx = PopStack(player);
            L00AD: RefreshCompareFlags(ax);
            L00AF: if (JumpNotEqual) goto L00C4;
0396  00B1 FF 76 FA  push word [bp-0x6]
0399  00B4 FF 76 FC  push word [bp-0x4]
039C  00B7 C4 5E 06  les bx, [bp+0x6]
039F  00BA 26 FF 5F 54  call far word [es:bx+0x54]
            L00BE: cx = PopStack(player);
            L00BF: cx = PopStack(player);
            L00C0: RefreshCompareFlags(ax);
            L00C2: if (JumpEqual) goto L00D2;
03A9  00C4 FF 76 08  push word [bp+0x8]
03AC  00C7 FF 76 06  push word [bp+0x6]
03AF  00CA 0E     push cs
03B0  00CB E8 91 14  call 0x155f
            L00CE: // NOP
            L00CF: goto L015C;
03B7  00D2 56     push si
03B8  00D3 56     push si
03B9  00D4 C4 5E 06  les bx, [bp+0x6]
03BC  00D7 26 FF 5F 54  call far word [es:bx+0x54]
            L00DB: cx = PopStack(player);
            L00DC: cx = PopStack(player);
            L00DD: RefreshCompareFlags(ax);
            L00DF: if (JumpEqual) goto L0125;
            L00E1: PushStack(player, 0x01);
            L00E5: PushStack(player, 0x00);
03CD  00E8 FF 76 F8  push word [bp-0x8]
            L00EB: SetWallPassable(player, PopStack(player), PopStack(player), PopStack(player));
            L00F5: PushStack(player, 0x00);
03DD  00F8 FF 76 F8  push word [bp-0x8]
            L00FB: SetWallObject(player, 0x01, PopStack(player), PopStack(player));
            L0109: ShowMessage(player, String05EA); // You've unlocked this door!
            L0116: ShowMessage(player, String0605); // Now proceed to the next lock.
            L0123: goto L015E;
040A  0125 B8 23 06  mov ax, 0x623
            L0128: goto L012D;
            L012A: ShowMessage(player, String064E); // 'Intrepid Gnome, if you have read the secret clues, use your tokens as the keys.'
041C  0137 FF 76 08  push word [bp+0x8]
041F  013A FF 76 06  push word [bp+0x6]
0422  013D 0E     push cs
0423  013E E8 41 14  call 0x1582
            L0141: // NOP
            L0142: goto L015C;
            L0144: ShowMessage(player, String06A0); // The doors remain open for you.
0436  0151 FF 76 08  push word [bp+0x8]
0439  0154 FF 76 06  push word [bp+0x6]
043C  0157 0E     push cs
043D  0158 E8 49 14  call 0x15a4
            L015B: // NOP
            L015C: cx = PopStack(player);
            L015D: cx = PopStack(player);
0443  015E 5F     pop di
0444  015F 5E     pop si
            L0160: // restore stack ptr: sp = bp;
            L0162: return; // RETURN;
        }

        private void FnHALFLING_0C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0454  0003 83 EC 08  sub sp, 0x8
0457  0006 56     push si
0458  0007 57     push di
            L0008: si = 0;
045B  000A C7 46 FE 01 00  mov word [bp-0x2], 0x1
            L000F: di = 0;
0462  0011 C7 46 FC 00 00  mov word [bp-0x4], 0x0
0467  0016 C7 46 FA FE 00  mov word [bp-0x6], 0xfe
            L001B: RefreshCompareFlags(GetFlag(player, 0x02, 0x3C));
            L002E: if (JumpEqual) goto L0033;
            L0030: goto L0144;
            L0033: Compare(PartyCount(player), 0x0001);
            L003E: if (JumpEqual) goto L0043;
            L0040: goto L012A;
            L0043: Compare(GetRace(player), 0x0006);
            L004D: if (JumpEqual) goto L0052;
            L004F: goto L012A;
            L0052: ax = GetCurrentTile(player);
04AA  0059 89 46 F8  mov [bp-0x8], ax
04AD  005C 8B 5E F8  mov bx, [bp-0x8]
04B0  005F 83 EB 41  sub bx, 0x41
            L0062: Compare(bx, 0x03);
            L0065: if (JumpAbove) goto L00A0;
            L0067: switch (bx) {
                case 0:
                    goto L0095;
                case 1:
                    goto L0088;
                case 2:
                    goto L007B;
                case 3:
                    goto L006E;
            }
            L006E: si = 0x00E3;
            L0071: di = 0x00E2;
04C5  0074 C7 46 FC E4 00  mov word [bp-0x4], 0xe4
            L0079: goto L00A0;
            L007B: si = 0x00E4;
            L007E: di = 0x00E3;
04D2  0081 C7 46 FC E5 00  mov word [bp-0x4], 0xe5
            L0086: goto L00A0;
            L0088: si = 0x00E5;
            L008B: di = 0x00E4;
04DF  008E C7 46 FC E6 00  mov word [bp-0x4], 0xe6
            L0093: goto L00A0;
            L0095: si = 0x00E6;
            L0098: di = 0x00E5;
04EC  009B C7 46 FC E7 00  mov word [bp-0x4], 0xe7
04F1  00A0 57     push di
04F2  00A1 FF 76 FE  push word [bp-0x2]
04F5  00A4 C4 5E 06  les bx, [bp+0x6]
04F8  00A7 26 FF 5F 54  call far word [es:bx+0x54]
            L00AB: cx = PopStack(player);
            L00AC: cx = PopStack(player);
            L00AD: RefreshCompareFlags(ax);
            L00AF: if (JumpNotEqual) goto L00C4;
0502  00B1 FF 76 FA  push word [bp-0x6]
0505  00B4 FF 76 FC  push word [bp-0x4]
0508  00B7 C4 5E 06  les bx, [bp+0x6]
050B  00BA 26 FF 5F 54  call far word [es:bx+0x54]
            L00BE: cx = PopStack(player);
            L00BF: cx = PopStack(player);
            L00C0: RefreshCompareFlags(ax);
            L00C2: if (JumpEqual) goto L00D2;
0515  00C4 FF 76 08  push word [bp+0x8]
0518  00C7 FF 76 06  push word [bp+0x6]
051B  00CA 0E     push cs
051C  00CB E8 25 13  call 0x13f3
            L00CE: // NOP
            L00CF: goto L015C;
0523  00D2 56     push si
0524  00D3 56     push si
0525  00D4 C4 5E 06  les bx, [bp+0x6]
0528  00D7 26 FF 5F 54  call far word [es:bx+0x54]
            L00DB: cx = PopStack(player);
            L00DC: cx = PopStack(player);
            L00DD: RefreshCompareFlags(ax);
            L00DF: if (JumpEqual) goto L0125;
            L00E1: PushStack(player, 0x01);
            L00E5: PushStack(player, 0x00);
0539  00E8 FF 76 F8  push word [bp-0x8]
            L00EB: SetWallPassable(player, PopStack(player), PopStack(player), PopStack(player));
            L00F5: PushStack(player, 0x00);
0549  00F8 FF 76 F8  push word [bp-0x8]
            L00FB: SetWallObject(player, 0x01, PopStack(player), PopStack(player));
            L0109: ShowMessage(player, String05EA); // You've unlocked this door!
            L0116: ShowMessage(player, String0605); // Now proceed to the next lock.
            L0123: goto L015E;
0576  0125 B8 23 06  mov ax, 0x623
            L0128: goto L012D;
            L012A: ShowMessage(player, String06BF); // 'Worthy Halfling, if you have read the secret clues, use your tokens as the keys.'
0588  0137 FF 76 08  push word [bp+0x8]
058B  013A FF 76 06  push word [bp+0x6]
058E  013D 0E     push cs
058F  013E E8 D5 12  call 0x1416
            L0141: // NOP
            L0142: goto L015C;
            L0144: ShowMessage(player, String06A0); // The doors remain open for you.
05A2  0151 FF 76 08  push word [bp+0x8]
05A5  0154 FF 76 06  push word [bp+0x6]
05A8  0157 0E     push cs
05A9  0158 E8 DD 12  call 0x1438
            L015B: // NOP
            L015C: cx = PopStack(player);
            L015D: cx = PopStack(player);
05AF  015E 5F     pop di
05B0  015F 5E     pop si
            L0160: // restore stack ptr: sp = bp;
            L0162: return; // RETURN;
        }

        private void FnORC_0D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
05C0  0003 83 EC 08  sub sp, 0x8
05C3  0006 56     push si
05C4  0007 57     push di
            L0008: si = 0;
05C7  000A C7 46 FE 01 00  mov word [bp-0x2], 0x1
            L000F: di = 0;
05CE  0011 C7 46 FC 00 00  mov word [bp-0x4], 0x0
05D3  0016 C7 46 FA FE 00  mov word [bp-0x6], 0xfe
            L001B: RefreshCompareFlags(GetFlag(player, 0x02, 0x3C));
            L002E: if (JumpEqual) goto L0033;
            L0030: goto L0144;
            L0033: Compare(PartyCount(player), 0x0001);
            L003E: if (JumpEqual) goto L0043;
            L0040: goto L012A;
            L0043: Compare(GetRace(player), 0x0001);
            L004D: if (JumpEqual) goto L0052;
            L004F: goto L012A;
            L0052: ax = GetCurrentTile(player);
0616  0059 89 46 F8  mov [bp-0x8], ax
0619  005C 8B 5E F8  mov bx, [bp-0x8]
061C  005F 83 EB 51  sub bx, 0x51
            L0062: Compare(bx, 0x03);
            L0065: if (JumpAbove) goto L00A0;
            L0067: switch (bx) {
                case 0:
                    goto L0095;
                case 1:
                    goto L0088;
                case 2:
                    goto L007B;
                case 3:
                    goto L006E;
            }
            L006E: si = 0x00E4;
            L0071: di = 0x00E3;
0631  0074 C7 46 FC E5 00  mov word [bp-0x4], 0xe5
            L0079: goto L00A0;
            L007B: si = 0x00E6;
            L007E: di = 0x00E5;
063E  0081 C7 46 FC E7 00  mov word [bp-0x4], 0xe7
            L0086: goto L00A0;
            L0088: si = 0x00E2;
            L008B: di = 0x00E1;
064B  008E C7 46 FC E3 00  mov word [bp-0x4], 0xe3
            L0093: goto L00A0;
            L0095: si = 0x00E3;
            L0098: di = 0x00E2;
0658  009B C7 46 FC E4 00  mov word [bp-0x4], 0xe4
065D  00A0 57     push di
065E  00A1 FF 76 FE  push word [bp-0x2]
0661  00A4 C4 5E 06  les bx, [bp+0x6]
0664  00A7 26 FF 5F 54  call far word [es:bx+0x54]
            L00AB: cx = PopStack(player);
            L00AC: cx = PopStack(player);
            L00AD: RefreshCompareFlags(ax);
            L00AF: if (JumpNotEqual) goto L00C4;
066E  00B1 FF 76 FA  push word [bp-0x6]
0671  00B4 FF 76 FC  push word [bp-0x4]
0674  00B7 C4 5E 06  les bx, [bp+0x6]
0677  00BA 26 FF 5F 54  call far word [es:bx+0x54]
            L00BE: cx = PopStack(player);
            L00BF: cx = PopStack(player);
            L00C0: RefreshCompareFlags(ax);
            L00C2: if (JumpEqual) goto L00D2;
0681  00C4 FF 76 08  push word [bp+0x8]
0684  00C7 FF 76 06  push word [bp+0x6]
0687  00CA 0E     push cs
0688  00CB E8 B9 11  call 0x1287
            L00CE: // NOP
            L00CF: goto L015C;
068F  00D2 56     push si
0690  00D3 56     push si
0691  00D4 C4 5E 06  les bx, [bp+0x6]
0694  00D7 26 FF 5F 54  call far word [es:bx+0x54]
            L00DB: cx = PopStack(player);
            L00DC: cx = PopStack(player);
            L00DD: RefreshCompareFlags(ax);
            L00DF: if (JumpEqual) goto L0125;
            L00E1: PushStack(player, 0x01);
            L00E5: PushStack(player, 0x00);
06A5  00E8 FF 76 F8  push word [bp-0x8]
            L00EB: SetWallPassable(player, PopStack(player), PopStack(player), PopStack(player));
            L00F5: PushStack(player, 0x00);
06B5  00F8 FF 76 F8  push word [bp-0x8]
            L00FB: SetWallObject(player, 0x01, PopStack(player), PopStack(player));
            L0109: ShowMessage(player, String05EA); // You've unlocked this door!
            L0116: ShowMessage(player, String0605); // Now proceed to the next lock.
            L0123: goto L015E;
06E2  0125 B8 23 06  mov ax, 0x623
            L0128: goto L012D;
            L012A: ShowMessage(player, String0712); // 'Brave Orc, if you have read the secret clues, use your tokens as the keys.'
06F4  0137 FF 76 08  push word [bp+0x8]
06F7  013A FF 76 06  push word [bp+0x6]
06FA  013D 0E     push cs
06FB  013E E8 69 11  call 0x12aa
            L0141: // NOP
            L0142: goto L015C;
            L0144: ShowMessage(player, String06A0); // The doors remain open for you.
070E  0151 FF 76 08  push word [bp+0x8]
0711  0154 FF 76 06  push word [bp+0x6]
0714  0157 0E     push cs
0715  0158 E8 71 11  call 0x12cc
            L015B: // NOP
            L015C: cx = PopStack(player);
            L015D: cx = PopStack(player);
071B  015E 5F     pop di
071C  015F 5E     pop si
            L0160: // restore stack ptr: sp = bp;
            L0162: return; // RETURN;
        }

        private void FnTROLL_0E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
072C  0003 83 EC 08  sub sp, 0x8
072F  0006 56     push si
0730  0007 57     push di
            L0008: si = 0;
0733  000A C7 46 FE 01 00  mov word [bp-0x2], 0x1
            L000F: di = 0;
073A  0011 C7 46 FC 00 00  mov word [bp-0x4], 0x0
073F  0016 C7 46 FA FE 00  mov word [bp-0x6], 0xfe
            L001B: RefreshCompareFlags(GetFlag(player, 0x02, 0x3C));
            L002E: if (JumpEqual) goto L0033;
            L0030: goto L0144;
            L0033: Compare(PartyCount(player), 0x0001);
            L003E: if (JumpEqual) goto L0043;
            L0040: goto L012A;
            L0043: Compare(GetRace(player), 0x0003);
            L004D: if (JumpEqual) goto L0052;
            L004F: goto L012A;
            L0052: ax = GetCurrentTile(player);
0782  0059 89 46 F8  mov [bp-0x8], ax
0785  005C 8B 5E F8  mov bx, [bp-0x8]
0788  005F 83 EB 61  sub bx, 0x61
            L0062: Compare(bx, 0x03);
            L0065: if (JumpAbove) goto L00A0;
            L0067: switch (bx) {
                case 0:
                    goto L0095;
                case 1:
                    goto L0088;
                case 2:
                    goto L007B;
                case 3:
                    goto L006E;
            }
            L006E: si = 0x00E6;
            L0071: di = 0x00E5;
079D  0074 C7 46 FC E7 00  mov word [bp-0x4], 0xe7
            L0079: goto L00A0;
            L007B: si = 0x00E2;
            L007E: di = 0x00E1;
07AA  0081 C7 46 FC E3 00  mov word [bp-0x4], 0xe3
            L0086: goto L00A0;
            L0088: si = 0x00E3;
            L008B: di = 0x00E2;
07B7  008E C7 46 FC E4 00  mov word [bp-0x4], 0xe4
            L0093: goto L00A0;
            L0095: si = 0x00E4;
            L0098: di = 0x00E3;
07C4  009B C7 46 FC E5 00  mov word [bp-0x4], 0xe5
07C9  00A0 57     push di
07CA  00A1 FF 76 FE  push word [bp-0x2]
07CD  00A4 C4 5E 06  les bx, [bp+0x6]
07D0  00A7 26 FF 5F 54  call far word [es:bx+0x54]
            L00AB: cx = PopStack(player);
            L00AC: cx = PopStack(player);
            L00AD: RefreshCompareFlags(ax);
            L00AF: if (JumpNotEqual) goto L00C4;
07DA  00B1 FF 76 FA  push word [bp-0x6]
07DD  00B4 FF 76 FC  push word [bp-0x4]
07E0  00B7 C4 5E 06  les bx, [bp+0x6]
07E3  00BA 26 FF 5F 54  call far word [es:bx+0x54]
            L00BE: cx = PopStack(player);
            L00BF: cx = PopStack(player);
            L00C0: RefreshCompareFlags(ax);
            L00C2: if (JumpEqual) goto L00D2;
07ED  00C4 FF 76 08  push word [bp+0x8]
07F0  00C7 FF 76 06  push word [bp+0x6]
07F3  00CA 0E     push cs
07F4  00CB E8 4D 10  call 0x111b
            L00CE: // NOP
            L00CF: goto L015C;
07FB  00D2 56     push si
07FC  00D3 56     push si
07FD  00D4 C4 5E 06  les bx, [bp+0x6]
0800  00D7 26 FF 5F 54  call far word [es:bx+0x54]
            L00DB: cx = PopStack(player);
            L00DC: cx = PopStack(player);
            L00DD: RefreshCompareFlags(ax);
            L00DF: if (JumpEqual) goto L0125;
            L00E1: PushStack(player, 0x01);
            L00E5: PushStack(player, 0x00);
0811  00E8 FF 76 F8  push word [bp-0x8]
            L00EB: SetWallPassable(player, PopStack(player), PopStack(player), PopStack(player));
            L00F5: PushStack(player, 0x00);
0821  00F8 FF 76 F8  push word [bp-0x8]
            L00FB: SetWallObject(player, 0x01, PopStack(player), PopStack(player));
            L0109: ShowMessage(player, String05EA); // You've unlocked this door!
            L0116: ShowMessage(player, String0605); // Now proceed to the next lock.
            L0123: goto L015E;
084E  0125 B8 23 06  mov ax, 0x623
            L0128: goto L012D;
            L012A: ShowMessage(player, String075F); // 'Courageous Troll, if you have read the secret clues, use the tokens as the keys.'
0860  0137 FF 76 08  push word [bp+0x8]
0863  013A FF 76 06  push word [bp+0x6]
0866  013D 0E     push cs
0867  013E E8 FD 0F  call 0x113e
            L0141: // NOP
            L0142: goto L015C;
            L0144: ShowMessage(player, String06A0); // The doors remain open for you.
087A  0151 FF 76 08  push word [bp+0x8]
087D  0154 FF 76 06  push word [bp+0x6]
0880  0157 0E     push cs
0881  0158 E8 05 10  call 0x1160
            L015B: // NOP
            L015C: cx = PopStack(player);
            L015D: cx = PopStack(player);
0887  015E 5F     pop di
0888  015F 5E     pop si
            L0160: // restore stack ptr: sp = bp;
            L0162: return; // RETURN;
        }

        private void FnCARTOG_0F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x002C);
            L0010: ShowMessage(player, String07B2); // Xanith smiles as you draw near.
            L001D: ShowMessage(player, String07D2); // 'I see you have mastered my riddles. To the west are some doors. Proceed alone through the door designated for your race.'
            L002A: ShowMessage(player, String084D); // 'You must use your tokens in the order you were told, lest dire consequences befall you!'
            L0037: return; // RETURN;
        }

        private void FnRIDDLEB_10(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String08A7); // Angel Fountain is in Cliffhanger. If true, continue south. If false, walk north.
            L0010: return; // RETURN;
        }

        private void FnTELEF_11(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x05, 0x03, 0x2F, 0x03, isForwardMove);
            L001E: ShowMessage(player, String08F8); // To the Graveyard.
            L002B: return; // RETURN;
        }

        private void FnRIDDLEC_12(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String090A); // The Emerald Lockpick is exchanged for the Diamond Lockpick. If true, take the door to the south. If false, take the door to the east.
            L0010: return; // RETURN;
        }

        private void FnQUEEN_13(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x02, 0x3C));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L0117;
            L001B: ShowPortrait(player, 0x0015);
            L0028: ShowMessage(player, String0990); // Queen Aeowyn materializes in the room.
            L0035: ShowMessage(player, String09B7); // 'Greetings, my Champion. Now we may bond these fragments together in this magical space.'
            L0042: ShowMessage(player, String0A11); // Aeowyn examines the pieces closely and then arranges them on the floor in a peculiar order.
            L004F: ShowMessage(player, String0A6D); // 'Ahh...look!' You watch as the tokens release their magical properties and fuse together the map pieces.
            L005C: ShowMessage(player, String0AD6); // 'Now, take this map and use it as the key through the northern gateway opposite the Night Elves' portal in the Main Entrance.
            L0069: ShowMessage(player, String0B54); // Fare thee well.' The Queen then vanishes.
            L0076: SetFlag(player, 0x02, 0x3C, 0x01);
            L008B: RemoveItem(player, 0xD5);
            L0097: RemoveItem(player, 0xD4);
            L00A3: RemoveItem(player, 0xD3);
            L00AF: RemoveItem(player, 0xD6);
            L00BB: RemoveItem(player, 0xE2);
            L00C7: RemoveItem(player, 0xE5);
            L00D3: RemoveItem(player, 0xE6);
            L00DF: RemoveItem(player, 0xE4);
            L00EB: RemoveItem(player, 0xE3);
            L00F7: GiveItem(player, 0xEB);
            L0103: AddExperience(player, 0x002625A0);
            L0115: goto L0124;
            L0117: ShowMessage(player, String0B7E); // A quiet breezes wafts through this area.
            L0124: return; // RETURN;
        }

        private void FnPARTYCK_14(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: // make space for tmp on stack: sp -= 2
0A4A  0005 56     push si
0A4B  0006 C4 5E 06  les bx, [bp+0x6]
0A4E  0009 26 FF 5F 40  call far word [es:bx+0x40]
            L000D: Compare(PartyCount(player), 0x0001);
            L0018: if (JumpBelowOrEqual) goto L007B;
            L001A: ax = GetRace(player);
0A66  0021 89 46 FE  mov [bp-0x2], ax
0A69  0024 8B 5E FE  mov bx, [bp-0x2]
            L0027: Compare(bx, 0x07);
            L002A: if (JumpAbove) goto L0059;
            L002C: switch (bx) {
                case 0:
                    goto L0056;
                case 1:
                    goto L0038;
                case 2:
                    goto L0047;
                case 3:
                    goto L003D;
                case 4:
                    goto L004C;
                case 5:
                    goto L0042;
                case 6:
                    goto L0033;
                case 7:
                    goto L0051;
            }
            L0033: si = 0x0044;
            L0036: goto L0059;
            L0038: si = 0x0054;
            L003B: goto L0059;
            L003D: si = 0x0064;
            L0040: goto L0059;
            L0042: si = 0x0074;
            L0045: goto L0059;
            L0047: si = 0x0084;
            L004A: goto L0059;
            L004C: si = 0x0094;
            L004F: goto L0059;
            L0051: si = 0x00A4;
            L0054: goto L0059;
            L0056: si = 0x00B4;
            L0059: ShowMessage(player, String0BA7); // You must enter here alone!
            L0066: PushStack(player, 0x02);
0AAF  006A 56     push si
            L006B: PushStack(player, ax);
            L006C: PushStack(player, 0x05);
0AB5  0070 C4 5E 06  les bx, [bp+0x6]
0AB8  0073 26 FF 9F BC 00  call far word [es:bx+0xbc]
0ABD  0078 83 C4 08  add sp, 0x8
0AC0  007B 5E     pop si
            L007C: // restore stack ptr: sp = bp;
            L007E: return; // RETURN;
        }

        private void FnELF_15(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0AD8  0003 83 EC 08  sub sp, 0x8
0ADB  0006 56     push si
0ADC  0007 57     push di
            L0008: si = 0;
0ADF  000A C7 46 FE 01 00  mov word [bp-0x2], 0x1
            L000F: di = 0;
0AE6  0011 C7 46 FC 00 00  mov word [bp-0x4], 0x0
0AEB  0016 C7 46 FA FE 00  mov word [bp-0x6], 0xfe
            L001B: RefreshCompareFlags(GetFlag(player, 0x02, 0x3C));
            L002E: if (JumpEqual) goto L0033;
            L0030: goto L0145;
            L0033: Compare(PartyCount(player), 0x0001);
            L003E: if (JumpEqual) goto L0043;
            L0040: goto L012B;
            L0043: Compare(GetRace(player), 0x0002);
            L004D: if (JumpEqual) goto L0052;
            L004F: goto L012B;
            L0052: ax = GetCurrentTile(player);
0B2E  0059 89 46 F8  mov [bp-0x8], ax
0B31  005C 8B 5E F8  mov bx, [bp-0x8]
0B34  005F 81 EB 81 00  sub bx, 0x81
            L0063: Compare(bx, 0x03);
            L0066: if (JumpAbove) goto L00A1;
            L0068: switch (bx) {
                case 0:
                    goto L0096;
                case 1:
                    goto L0089;
                case 2:
                    goto L007C;
                case 3:
                    goto L006F;
            }
            L006F: si = 0x00E5;
            L0072: di = 0x00E4;
0B4A  0075 C7 46 FC E6 00  mov word [bp-0x4], 0xe6
            L007A: goto L00A1;
            L007C: si = 0x00E6;
            L007F: di = 0x00E5;
0B57  0082 C7 46 FC E7 00  mov word [bp-0x4], 0xe7
            L0087: goto L00A1;
            L0089: si = 0x00E2;
            L008C: di = 0x00E1;
0B64  008F C7 46 FC E3 00  mov word [bp-0x4], 0xe3
            L0094: goto L00A1;
            L0096: si = 0x00E3;
            L0099: di = 0x00E2;
0B71  009C C7 46 FC E4 00  mov word [bp-0x4], 0xe4
0B76  00A1 57     push di
0B77  00A2 FF 76 FE  push word [bp-0x2]
0B7A  00A5 C4 5E 06  les bx, [bp+0x6]
0B7D  00A8 26 FF 5F 54  call far word [es:bx+0x54]
            L00AC: cx = PopStack(player);
            L00AD: cx = PopStack(player);
            L00AE: RefreshCompareFlags(ax);
            L00B0: if (JumpNotEqual) goto L00C5;
0B87  00B2 FF 76 FA  push word [bp-0x6]
0B8A  00B5 FF 76 FC  push word [bp-0x4]
0B8D  00B8 C4 5E 06  les bx, [bp+0x6]
0B90  00BB 26 FF 5F 54  call far word [es:bx+0x54]
            L00BF: cx = PopStack(player);
            L00C0: cx = PopStack(player);
            L00C1: RefreshCompareFlags(ax);
            L00C3: if (JumpEqual) goto L00D3;
0B9A  00C5 FF 76 08  push word [bp+0x8]
0B9D  00C8 FF 76 06  push word [bp+0x6]
0BA0  00CB 0E     push cs
0BA1  00CC E8 A0 0C  call 0xd6f
            L00CF: // NOP
            L00D0: goto L015D;
0BA8  00D3 56     push si
0BA9  00D4 56     push si
0BAA  00D5 C4 5E 06  les bx, [bp+0x6]
0BAD  00D8 26 FF 5F 54  call far word [es:bx+0x54]
            L00DC: cx = PopStack(player);
            L00DD: cx = PopStack(player);
            L00DE: RefreshCompareFlags(ax);
            L00E0: if (JumpEqual) goto L0126;
            L00E2: PushStack(player, 0x01);
            L00E6: PushStack(player, 0x00);
0BBE  00E9 FF 76 F8  push word [bp-0x8]
            L00EC: SetWallPassable(player, PopStack(player), PopStack(player), PopStack(player));
            L00F6: PushStack(player, 0x00);
0BCE  00F9 FF 76 F8  push word [bp-0x8]
            L00FC: SetWallObject(player, 0x01, PopStack(player), PopStack(player));
            L010A: ShowMessage(player, String05EA); // You've unlocked this door!
            L0117: ShowMessage(player, String0BC2); // Proceed.
            L0124: goto L015F;
0BFB  0126 B8 23 06  mov ax, 0x623
            L0129: goto L012E;
            L012B: ShowMessage(player, String0BCB); // 'Fearless Elf, if you have read the secret clues, use your tokens as the keys.'
0C0D  0138 FF 76 08  push word [bp+0x8]
0C10  013B FF 76 06  push word [bp+0x6]
0C13  013E 0E     push cs
0C14  013F E8 50 0C  call 0xd92
            L0142: // NOP
            L0143: goto L015D;
            L0145: ShowMessage(player, String06A0); // The doors remain open for you.
0C27  0152 FF 76 08  push word [bp+0x8]
0C2A  0155 FF 76 06  push word [bp+0x6]
0C2D  0158 0E     push cs
0C2E  0159 E8 58 0C  call 0xdb4
            L015C: // NOP
            L015D: cx = PopStack(player);
            L015E: cx = PopStack(player);
0C34  015F 5F     pop di
0C35  0160 5E     pop si
            L0161: // restore stack ptr: sp = bp;
            L0163: return; // RETURN;
        }

        private void FnDWARF_16(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0C45  0003 83 EC 08  sub sp, 0x8
0C48  0006 56     push si
0C49  0007 57     push di
            L0008: si = 0;
0C4C  000A C7 46 FE 01 00  mov word [bp-0x2], 0x1
            L000F: di = 0;
0C53  0011 C7 46 FC 00 00  mov word [bp-0x4], 0x0
0C58  0016 C7 46 FA FE 00  mov word [bp-0x6], 0xfe
            L001B: RefreshCompareFlags(GetFlag(player, 0x02, 0x3C));
            L002E: if (JumpEqual) goto L0033;
            L0030: goto L0145;
            L0033: Compare(PartyCount(player), 0x0001);
            L003E: if (JumpEqual) goto L0043;
            L0040: goto L012B;
            L0043: Compare(GetRace(player), 0x0004);
            L004D: if (JumpEqual) goto L0052;
            L004F: goto L012B;
            L0052: ax = GetCurrentTile(player);
0C9B  0059 89 46 F8  mov [bp-0x8], ax
0C9E  005C 8B 5E F8  mov bx, [bp-0x8]
0CA1  005F 81 EB 91 00  sub bx, 0x91
            L0063: Compare(bx, 0x03);
            L0066: if (JumpAbove) goto L00A1;
            L0068: switch (bx) {
                case 0:
                    goto L0096;
                case 1:
                    goto L0089;
                case 2:
                    goto L007C;
                case 3:
                    goto L006F;
            }
            L006F: si = 0x00E6;
            L0072: di = 0x00E5;
0CB7  0075 C7 46 FC E7 00  mov word [bp-0x4], 0xe7
            L007A: goto L00A1;
            L007C: si = 0x00E3;
            L007F: di = 0x00E2;
0CC4  0082 C7 46 FC E4 00  mov word [bp-0x4], 0xe4
            L0087: goto L00A1;
            L0089: si = 0x00E5;
            L008C: di = 0x00E4;
0CD1  008F C7 46 FC E6 00  mov word [bp-0x4], 0xe6
            L0094: goto L00A1;
            L0096: si = 0x00E2;
            L0099: di = 0x00E1;
0CDE  009C C7 46 FC E3 00  mov word [bp-0x4], 0xe3
0CE3  00A1 57     push di
0CE4  00A2 FF 76 FE  push word [bp-0x2]
0CE7  00A5 C4 5E 06  les bx, [bp+0x6]
0CEA  00A8 26 FF 5F 54  call far word [es:bx+0x54]
            L00AC: cx = PopStack(player);
            L00AD: cx = PopStack(player);
            L00AE: RefreshCompareFlags(ax);
            L00B0: if (JumpNotEqual) goto L00C5;
0CF4  00B2 FF 76 FA  push word [bp-0x6]
0CF7  00B5 FF 76 FC  push word [bp-0x4]
0CFA  00B8 C4 5E 06  les bx, [bp+0x6]
0CFD  00BB 26 FF 5F 54  call far word [es:bx+0x54]
            L00BF: cx = PopStack(player);
            L00C0: cx = PopStack(player);
            L00C1: RefreshCompareFlags(ax);
            L00C3: if (JumpEqual) goto L00D3;
0D07  00C5 FF 76 08  push word [bp+0x8]
0D0A  00C8 FF 76 06  push word [bp+0x6]
0D0D  00CB 0E     push cs
0D0E  00CC E8 33 0B  call 0xc02
            L00CF: // NOP
            L00D0: goto L015D;
0D15  00D3 56     push si
0D16  00D4 56     push si
0D17  00D5 C4 5E 06  les bx, [bp+0x6]
0D1A  00D8 26 FF 5F 54  call far word [es:bx+0x54]
            L00DC: cx = PopStack(player);
            L00DD: cx = PopStack(player);
            L00DE: RefreshCompareFlags(ax);
            L00E0: if (JumpEqual) goto L0126;
            L00E2: PushStack(player, 0x01);
            L00E6: PushStack(player, 0x00);
0D2B  00E9 FF 76 F8  push word [bp-0x8]
            L00EC: SetWallPassable(player, PopStack(player), PopStack(player), PopStack(player));
            L00F6: PushStack(player, 0x00);
0D3B  00F9 FF 76 F8  push word [bp-0x8]
            L00FC: SetWallObject(player, 0x01, PopStack(player), PopStack(player));
            L010A: ShowMessage(player, String05EA); // You've unlocked this door!
            L0117: ShowMessage(player, String0BC2); // Proceed.
            L0124: goto L015F;
0D68  0126 B8 23 06  mov ax, 0x623
            L0129: goto L012E;
            L012B: ShowMessage(player, String0C1B); // 'Valiant Dwarf, if you have read the secret clues, use your tokens as the keys.'
0D7A  0138 FF 76 08  push word [bp+0x8]
0D7D  013B FF 76 06  push word [bp+0x6]
0D80  013E 0E     push cs
0D81  013F E8 E3 0A  call 0xc25
            L0142: // NOP
            L0143: goto L015D;
            L0145: ShowMessage(player, String06A0); // The doors remain open for you.
0D94  0152 FF 76 08  push word [bp+0x8]
0D97  0155 FF 76 06  push word [bp+0x6]
0D9A  0158 0E     push cs
0D9B  0159 E8 EB 0A  call 0xc47
            L015C: // NOP
            L015D: cx = PopStack(player);
            L015E: cx = PopStack(player);
0DA1  015F 5F     pop di
0DA2  0160 5E     pop si
            L0161: // restore stack ptr: sp = bp;
            L0163: return; // RETURN;
        }

        private void FnTELEG_17(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x05, 0x03, 0xE9, 0x01, isForwardMove);
            L001E: ShowMessage(player, String08F8); // To the Graveyard.
            L002B: return; // RETURN;
        }

        private void FnRIDDLED_18(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0C6C); // The Vault is found in Twinion Keep. If true, continue east. If false, walk west.
            L0010: return; // RETURN;
        }

        private void FnTELEH_19(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x05, 0x02, 0x97, 0x03, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnGREMLIN_1A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0E11  0003 83 EC 08  sub sp, 0x8
0E14  0006 56     push si
0E15  0007 57     push di
            L0008: si = 0;
0E18  000A C7 46 FE 01 00  mov word [bp-0x2], 0x1
            L000F: di = 0;
0E1F  0011 C7 46 FC 00 00  mov word [bp-0x4], 0x0
0E24  0016 C7 46 FA FE 00  mov word [bp-0x6], 0xfe
            L001B: RefreshCompareFlags(GetFlag(player, 0x02, 0x3C));
            L002E: if (JumpEqual) goto L0033;
            L0030: goto L0145;
            L0033: Compare(PartyCount(player), 0x0001);
            L003E: if (JumpEqual) goto L0043;
            L0040: goto L012B;
            L0043: Compare(GetRace(player), 0x0007);
            L004D: if (JumpEqual) goto L0052;
            L004F: goto L012B;
            L0052: ax = GetCurrentTile(player);
0E67  0059 89 46 F8  mov [bp-0x8], ax
0E6A  005C 8B 5E F8  mov bx, [bp-0x8]
0E6D  005F 81 EB A1 00  sub bx, 0xa1
            L0063: Compare(bx, 0x03);
            L0066: if (JumpAbove) goto L00A1;
            L0068: switch (bx) {
                case 0:
                    goto L0096;
                case 1:
                    goto L0089;
                case 2:
                    goto L007C;
                case 3:
                    goto L006F;
            }
            L006F: si = 0x00E4;
            L0072: di = 0x00E3;
0E83  0075 C7 46 FC E5 00  mov word [bp-0x4], 0xe5
            L007A: goto L00A1;
            L007C: si = 0x00E5;
            L007F: di = 0x00E4;
0E90  0082 C7 46 FC E6 00  mov word [bp-0x4], 0xe6
            L0087: goto L00A1;
            L0089: si = 0x00E6;
            L008C: di = 0x00E5;
0E9D  008F C7 46 FC E7 00  mov word [bp-0x4], 0xe7
            L0094: goto L00A1;
            L0096: si = 0x00E2;
            L0099: di = 0x00E1;
0EAA  009C C7 46 FC E3 00  mov word [bp-0x4], 0xe3
0EAF  00A1 57     push di
0EB0  00A2 FF 76 FE  push word [bp-0x2]
0EB3  00A5 C4 5E 06  les bx, [bp+0x6]
0EB6  00A8 26 FF 5F 54  call far word [es:bx+0x54]
            L00AC: cx = PopStack(player);
            L00AD: cx = PopStack(player);
            L00AE: RefreshCompareFlags(ax);
            L00B0: if (JumpNotEqual) goto L00C5;
0EC0  00B2 FF 76 FA  push word [bp-0x6]
0EC3  00B5 FF 76 FC  push word [bp-0x4]
0EC6  00B8 C4 5E 06  les bx, [bp+0x6]
0EC9  00BB 26 FF 5F 54  call far word [es:bx+0x54]
            L00BF: cx = PopStack(player);
            L00C0: cx = PopStack(player);
            L00C1: RefreshCompareFlags(ax);
            L00C3: if (JumpEqual) goto L00D3;
0ED3  00C5 FF 76 08  push word [bp+0x8]
0ED6  00C8 FF 76 06  push word [bp+0x6]
0ED9  00CB 0E     push cs
0EDA  00CC E8 67 09  call 0xa36
            L00CF: // NOP
            L00D0: goto L015D;
0EE1  00D3 56     push si
0EE2  00D4 56     push si
0EE3  00D5 C4 5E 06  les bx, [bp+0x6]
0EE6  00D8 26 FF 5F 54  call far word [es:bx+0x54]
            L00DC: cx = PopStack(player);
            L00DD: cx = PopStack(player);
            L00DE: RefreshCompareFlags(ax);
            L00E0: if (JumpEqual) goto L0126;
            L00E2: PushStack(player, 0x01);
            L00E6: PushStack(player, 0x00);
0EF7  00E9 FF 76 F8  push word [bp-0x8]
            L00EC: SetWallPassable(player, PopStack(player), PopStack(player), PopStack(player));
            L00F6: PushStack(player, 0x00);
0F07  00F9 FF 76 F8  push word [bp-0x8]
            L00FC: SetWallObject(player, 0x01, PopStack(player), PopStack(player));
            L010A: ShowMessage(player, String05EA); // You've unlocked this door!
            L0117: ShowMessage(player, String0BC2); // Proceed.
            L0124: goto L015F;
0F34  0126 B8 23 06  mov ax, 0x623
            L0129: goto L012E;
            L012B: ShowMessage(player, String0CBD); // 'Hardy Gremlin, if you have read the secret clues, use your tokens as the keys.'
0F46  0138 FF 76 08  push word [bp+0x8]
0F49  013B FF 76 06  push word [bp+0x6]
0F4C  013E 0E     push cs
0F4D  013F E8 17 09  call 0xa59
            L0142: // NOP
            L0143: goto L015D;
            L0145: ShowMessage(player, String06A0); // The doors remain open for you.
0F60  0152 FF 76 08  push word [bp+0x8]
0F63  0155 FF 76 06  push word [bp+0x6]
0F66  0158 0E     push cs
0F67  0159 E8 1F 09  call 0xa7b
            L015C: // NOP
            L015D: cx = PopStack(player);
            L015E: cx = PopStack(player);
0F6D  015F 5F     pop di
0F6E  0160 5E     pop si
            L0161: // restore stack ptr: sp = bp;
            L0163: return; // RETURN;
        }

        private void FnHUMAN_1B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0F7E  0003 83 EC 08  sub sp, 0x8
0F81  0006 56     push si
0F82  0007 57     push di
            L0008: si = 0;
0F85  000A C7 46 FE 01 00  mov word [bp-0x2], 0x1
            L000F: di = 0;
0F8C  0011 C7 46 FC 00 00  mov word [bp-0x4], 0x0
0F91  0016 C7 46 FA FE 00  mov word [bp-0x6], 0xfe
            L001B: RefreshCompareFlags(GetFlag(player, 0x02, 0x3C));
            L002E: if (JumpEqual) goto L0033;
            L0030: goto L0144;
            L0033: Compare(PartyCount(player), 0x0001);
            L003E: if (JumpEqual) goto L0043;
            L0040: goto L012A;
            L0043: RefreshCompareFlags(GetRace(player));
            L004C: if (JumpEqual) goto L0051;
            L004E: goto L012A;
            L0051: ax = GetCurrentTile(player);
0FD3  0058 89 46 F8  mov [bp-0x8], ax
0FD6  005B 8B 5E F8  mov bx, [bp-0x8]
0FD9  005E 81 EB B1 00  sub bx, 0xb1
            L0062: Compare(bx, 0x03);
            L0065: if (JumpAbove) goto L00A0;
            L0067: switch (bx) {
                case 0:
                    goto L0095;
                case 1:
                    goto L0088;
                case 2:
                    goto L007B;
                case 3:
                    goto L006E;
            }
            L006E: si = 0x00E2;
            L0071: di = 0x00E1;
0FEF  0074 C7 46 FC E3 00  mov word [bp-0x4], 0xe3
            L0079: goto L00A0;
            L007B: si = 0x00E3;
            L007E: di = 0x00E2;
0FFC  0081 C7 46 FC E4 00  mov word [bp-0x4], 0xe4
            L0086: goto L00A0;
            L0088: si = 0x00E4;
            L008B: di = 0x00E3;
1009  008E C7 46 FC E5 00  mov word [bp-0x4], 0xe5
            L0093: goto L00A0;
            L0095: si = 0x00E5;
            L0098: di = 0x00E4;
1016  009B C7 46 FC E6 00  mov word [bp-0x4], 0xe6
101B  00A0 57     push di
101C  00A1 FF 76 FE  push word [bp-0x2]
101F  00A4 C4 5E 06  les bx, [bp+0x6]
1022  00A7 26 FF 5F 54  call far word [es:bx+0x54]
            L00AB: cx = PopStack(player);
            L00AC: cx = PopStack(player);
            L00AD: RefreshCompareFlags(ax);
            L00AF: if (JumpNotEqual) goto L00C4;
102C  00B1 FF 76 FA  push word [bp-0x6]
102F  00B4 FF 76 FC  push word [bp-0x4]
1032  00B7 C4 5E 06  les bx, [bp+0x6]
1035  00BA 26 FF 5F 54  call far word [es:bx+0x54]
            L00BE: cx = PopStack(player);
            L00BF: cx = PopStack(player);
            L00C0: RefreshCompareFlags(ax);
            L00C2: if (JumpEqual) goto L00D2;
103F  00C4 FF 76 08  push word [bp+0x8]
1042  00C7 FF 76 06  push word [bp+0x6]
1045  00CA 0E     push cs
1046  00CB E8 FB 07  call 0x8c9
            L00CE: // NOP
            L00CF: goto L015C;
104D  00D2 56     push si
104E  00D3 56     push si
104F  00D4 C4 5E 06  les bx, [bp+0x6]
1052  00D7 26 FF 5F 54  call far word [es:bx+0x54]
            L00DB: cx = PopStack(player);
            L00DC: cx = PopStack(player);
            L00DD: RefreshCompareFlags(ax);
            L00DF: if (JumpEqual) goto L0125;
            L00E1: PushStack(player, 0x01);
            L00E5: PushStack(player, 0x00);
1063  00E8 FF 76 F8  push word [bp-0x8]
            L00EB: SetWallPassable(player, PopStack(player), PopStack(player), PopStack(player));
            L00F5: PushStack(player, 0x00);
1073  00F8 FF 76 F8  push word [bp-0x8]
            L00FB: SetWallObject(player, 0x01, PopStack(player), PopStack(player));
            L0109: ShowMessage(player, String05EA); // You've unlocked this door!
            L0116: ShowMessage(player, String0BC2); // Proceed.
            L0123: goto L015E;
10A0  0125 B8 23 06  mov ax, 0x623
            L0128: goto L012D;
            L012A: ShowMessage(player, String0D0E); // 'Adventurous Human, if you have read the secret clues, use the tokens as the keys.'
10B2  0137 FF 76 08  push word [bp+0x8]
10B5  013A FF 76 06  push word [bp+0x6]
10B8  013D 0E     push cs
10B9  013E E8 AB 07  call 0x8ec
            L0141: // NOP
            L0142: goto L015C;
            L0144: ShowMessage(player, String06A0); // The doors remain open for you.
10CC  0151 FF 76 08  push word [bp+0x8]
10CF  0154 FF 76 06  push word [bp+0x6]
10D2  0157 0E     push cs
10D3  0158 E8 B3 07  call 0x90e
            L015B: // NOP
            L015C: cx = PopStack(player);
            L015D: cx = PopStack(player);
10D9  015E 5F     pop di
10DA  015F 5E     pop si
            L0160: // restore stack ptr: sp = bp;
            L0162: return; // RETURN;
        }

        private void FnOUTTEXT_1C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0D62); // To go back and search for your clues, exit here.
            L0010: return; // RETURN;
        }

        private void FnTELEI_1E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x05, 0x02, 0x21, 0x03, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnMANADOWN_23(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0D93); // The musty smell of old maps is overpowering. You sense your mana being leeched away.
            L0010: AddMana(player, 0xFF38);
            L001D: return; // RETURN;
        }

        private void FnRIDDLEE_28(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0DE8); // The only way to Race Track is from Rat Race. If true, continue north. If false, walk east.
            L0010: return; // RETURN;
        }

        private void FnTELEJ_29(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x05, 0x02, 0xC2, 0x02, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnTELEK_2A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x05, 0x02, 0x3B, 0x01, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnRIDDLEF_2F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0E43); // Harmonics should visit the Tool Shed for a reward. If true, continue west. If false, walk east.
            L0010: return; // RETURN;
        }

        private void FnRIDDLEG_34(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0EA3); // Smug owns a Pawn Shop. If true, continue west. If false, walk south.
            L0010: return; // RETURN;
        }

        private void FnCLUEB_39(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0EE8); // A book on the table reads, 'Futility is the price you pay for returning to the Cartography Shop ere you know the riddles' answers.'
            L0010: return; // RETURN;
        }

        private void FnCLUEC_3A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0F6C); // A path of correct answers will lead you directly to the Cartographer.
            L0010: return; // RETURN;
        }

        private void FnTELEL_3C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x05, 0x02, 0x2D, 0x01, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnSECA_3D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, 0x0D), 0x0008);
            L0012: if (JumpNotBelow) goto L006C;
            L0014: RefreshCompareFlags(HasUsedSpell(player, 0x17));
            L0022: if (JumpNotEqual) goto L006C;
            L0024: PushStack(player, 0x68);
            L0028: PushStack(player, ax);
1289  0029 C4 5E 06  les bx, [bp+0x6]
128C  002C 26 FF 5F 54  call far word [es:bx+0x54]
            L0030: cx = PopStack(player);
            L0031: cx = PopStack(player);
            L0032: RefreshCompareFlags(ax);
            L0034: if (JumpNotEqual) goto L006C;
            L0036: PushStack(player, 0x6E);
            L003A: PushStack(player, ax);
129B  003B C4 5E 06  les bx, [bp+0x6]
129E  003E 26 FF 5F 54  call far word [es:bx+0x54]
            L0042: cx = PopStack(player);
            L0043: cx = PopStack(player);
            L0044: RefreshCompareFlags(ax);
            L0046: if (JumpNotEqual) goto L006C;
            L0048: PushStack(player, 0x90);
            L004C: PushStack(player, ax);
12AD  004D C4 5E 06  les bx, [bp+0x6]
12B0  0050 26 FF 5F 54  call far word [es:bx+0x54]
            L0054: cx = PopStack(player);
            L0055: cx = PopStack(player);
            L0056: RefreshCompareFlags(ax);
            L0058: if (JumpNotEqual) goto L006C;
            L005A: PushStack(player, 0xA4);
            L005E: PushStack(player, ax);
12BF  005F C4 5E 06  les bx, [bp+0x6]
12C2  0062 26 FF 5F 54  call far word [es:bx+0x54]
            L0066: cx = PopStack(player);
            L0067: cx = PopStack(player);
            L0068: RefreshCompareFlags(ax);
            L006A: if (JumpEqual) goto L00A4;
            L006C: ShowMessage(player, String0FB2); // A secret door is revealed.
            L0079: SetWallObject(player, 0x01, GetCurrentTile(player), GetFacing(player));
12F7  0097 FF 76 08  push word [bp+0x8]
12FA  009A FF 76 06  push word [bp+0x6]
12FD  009D 0E     push cs
12FE  009E E8 88 05  call 0x629
            L00A1: // NOP
            L00A2: goto L00AF;
1304  00A4 FF 76 08  push word [bp+0x8]
1307  00A7 FF 76 06  push word [bp+0x6]
130A  00AA 0E     push cs
130B  00AB E8 59 05  call 0x607
            L00AE: // NOP
            L00AF: cx = PopStack(player);
            L00B0: cx = PopStack(player);
            L00B1: return; // RETURN;
        }

        private void FnTELEM_3E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x05, 0x02, 0x23, 0x00, isForwardMove);
            L001D: return; // RETURN;
        }

        private void FnDABELAIS_3F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: // make space for tmp on stack: sp -= 2
1337  0005 56     push si
            L0006: si = 0;
            L0008: ax = GetRace(player);
1341  000F 89 46 FE  mov [bp-0x2], ax
            L0012: Compare(ax, 0x0001);
            L0015: if (JumpEqual) goto L001E;
            L0017: Compare(ax, 0x0003);
            L001A: if (JumpEqual) goto L001E;
            L001C: goto L0023;
            L001E: si = 0x00E2;
            L0021: goto L0026;
            L0023: si = 0x00E5;
1358  0026 56     push si
1359  0027 C4 5E 06  les bx, [bp+0x6]
135C  002A 26 FF 5F 50  call far word [es:bx+0x50]
            L002E: cx = PopStack(player);
            L002F: RefreshCompareFlags(ax);
            L0031: if (JumpNotEqual) goto L0049;
            L0033: Compare(GetFlag(player, 0x02, 0x3C), 0x0001);
            L0047: if (JumpNotEqual) goto L004E;
137B  0049 B8 CD 0F  mov ax, 0xfcd
            L004C: goto L0067;
1380  004E 56     push si
1381  004F C4 5E 06  les bx, [bp+0x6]
1384  0052 26 FF 5F 48  call far word [es:bx+0x48]
            L0056: cx = PopStack(player);
            L0057: ShowPortrait(player, 0x0027);
            L0064: ShowMessage(player, String0FEC); // Dabelais looks up and says, 'Accept this token as payment for showing me your map pieces.'
13A3  0071 5E     pop si
            L0072: // restore stack ptr: sp = bp;
            L0074: return; // RETURN;
        }

        private void FnSYRENE_41(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: // make space for tmp on stack: sp -= 2
13B2  0005 56     push si
            L0006: si = 0;
            L0008: ax = GetRace(player);
13BC  000F 89 46 FE  mov [bp-0x2], ax
            L0012: Compare(ax, 0x0002);
            L0015: if (JumpEqual) goto L001E;
            L0017: Compare(ax, 0x0004);
            L001A: if (JumpEqual) goto L001E;
            L001C: goto L0023;
            L001E: si = 0x00E2;
            L0021: goto L0026;
            L0023: si = 0x00E4;
13D3  0026 56     push si
13D4  0027 C4 5E 06  les bx, [bp+0x6]
13D7  002A 26 FF 5F 50  call far word [es:bx+0x50]
            L002E: cx = PopStack(player);
            L002F: RefreshCompareFlags(ax);
            L0031: if (JumpNotEqual) goto L0049;
            L0033: Compare(GetFlag(player, 0x02, 0x3C), 0x0001);
            L0047: if (JumpNotEqual) goto L004E;
13F6  0049 B8 47 10  mov ax, 0x1047
            L004C: goto L0067;
            L004E: ShowPortrait(player, 0x001E);
1408  005B 56     push si
1409  005C C4 5E 06  les bx, [bp+0x6]
140C  005F 26 FF 5F 48  call far word [es:bx+0x48]
            L0063: cx = PopStack(player);
            L0064: ShowMessage(player, String1064); // Syrene greets you. 'Adventurers, I offer a token for a glance at your map pieces.'
141E  0071 5E     pop si
            L0072: // restore stack ptr: sp = bp;
            L0074: return; // RETURN;
        }

        private void FnRIDDLEH_42(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String10B7); // Unity Fountain is found in Rat Race. If true, continue east. If false, walk west.
            L0010: return; // RETURN;
        }

        private void FnRIDDLEH_43(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1109); // Fellowship Fountain is found in the Armory. If true, continue south. If false, walk north.
            L0010: return; // RETURN;
        }

        private void FnTELEN_44(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x05, 0x02, 0x0F, 0x01, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnTELEO_45(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x05, 0x02, 0x58, 0x01, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnTELEP_46(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String08F8); // To the Graveyard.
            L0010: TeleportParty(player, 0x05, 0x03, 0xE1, 0x00, isForwardMove);
            L002A: return; // RETURN;
        }

        private void FnFTNA_47(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0042);
            L0010: Compare(GetFlag(player, 0x02, 0x4F), 0x0001);
            L0024: if (JumpNotEqual) goto L0041;
            L0026: ShowMessage(player, String1164); // The twinkling waters of NorthStar Fountain restore your mana.
14E6  0033 B8 10 27  mov ax, 0x2710
            L0036: PushStack(player, ax);
14EA  0037 C4 5E 06  les bx, [bp+0x6]
14ED  003A 26 FF 9F B4 00  call far word [es:bx+0xb4]
            L003F: goto L0092;
            L0041: AddMana(player, 0x2710);
            L004E: ModifyAttribute(player, 0x03, 0x0002);
            L0060: ModifyAttribute(player, 0x00, 0x0001);
            L0071: SetFlag(player, 0x02, 0x4F, 0x01);
            L0086: ShowMessage(player, String11A2); // The twinkling waters of NorthStar Fountain restore your mana and increase your Strength and Initiative.
            L0093: return; // RETURN;
        }

        private void FnHRDA_4B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L002B;
            L0010: AddEncounter(player, 0x01, 0x1A);
            L0022: PushStack(player, 0x1F);
157D  0026 B8 02 00  mov ax, 0x2
            L0029: goto L0068;
            L002B: AddEncounter(player, 0x01, 0x1B);
            L003D: AddEncounter(player, 0x02, 0x1B);
            L004F: AddEncounter(player, 0x03, 0x1F);
            L0061: AddEncounter(player, 0x06, 0x1E);
            L0073: return; // RETURN;
        }

        private void FnHRDB_4D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L002C;
            L0010: AddEncounter(player, 0x01, 0x06);
            L0022: PushStack(player, 0x07);
15F7  0026 B8 02 00  mov ax, 0x2
            L0029: goto L00C7;
            L002C: Compare(PartyCount(player), 0x0002);
            L0037: if (JumpNotEqual) goto L0078;
            L0039: AddEncounter(player, 0x01, 0x06);
            L004B: AddEncounter(player, 0x02, 0x06);
            L005D: AddEncounter(player, 0x03, 0x07);
            L006F: PushStack(player, 0x28);
1644  0073 B8 04 00  mov ax, 0x4
            L0076: goto L00C7;
            L0078: AddEncounter(player, 0x01, 0x09);
            L008A: AddEncounter(player, 0x02, 0x09);
            L009C: AddEncounter(player, 0x03, 0x19);
            L00AE: AddEncounter(player, 0x04, 0x19);
            L00C0: AddEncounter(player, 0x05, 0x0B);
            L00D2: return; // RETURN;
        }

        private void FnMEDD_4F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L002B;
            L0010: AddEncounter(player, 0x01, 0x23);
            L0022: PushStack(player, 0x1B);
16D0  0026 B8 02 00  mov ax, 0x2
            L0029: goto L00A2;
            L002B: Compare(PartyCount(player), 0x0002);
            L0036: if (JumpNotEqual) goto L0065;
            L0038: AddEncounter(player, 0x01, 0x23);
            L004A: AddEncounter(player, 0x02, 0x24);
            L005C: PushStack(player, 0x1C);
170A  0060 B8 03 00  mov ax, 0x3
            L0063: goto L00A2;
            L0065: AddEncounter(player, 0x01, 0x23);
            L0077: AddEncounter(player, 0x02, 0x24);
            L0089: AddEncounter(player, 0x03, 0x1D);
            L009B: AddEncounter(player, 0x04, 0x1E);
            L00AD: return; // RETURN;
        }

        private void FnHRDC_50(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L002C;
            L0010: AddEncounter(player, 0x01, 0x06);
            L0022: PushStack(player, 0x24);
177F  0026 B8 02 00  mov ax, 0x2
            L0029: goto L00D9;
            L002C: Compare(PartyCount(player), 0x0002);
            L0037: if (JumpNotEqual) goto L0078;
            L0039: AddEncounter(player, 0x01, 0x06);
            L004B: AddEncounter(player, 0x02, 0x05);
            L005D: AddEncounter(player, 0x03, 0x0E);
            L006F: PushStack(player, 0x20);
17CC  0073 B8 05 00  mov ax, 0x5
            L0076: goto L00D9;
            L0078: AddEncounter(player, 0x01, 0x08);
            L008A: AddEncounter(player, 0x02, 0x08);
            L009C: AddEncounter(player, 0x03, 0x19);
            L00AE: AddEncounter(player, 0x04, 0x19);
            L00C0: AddEncounter(player, 0x05, 0x20);
            L00D2: AddEncounter(player, 0x06, 0x20);
            L00E4: return; // RETURN;
        }

        private void Fn_51(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: return; // RETURN;
            // Extra data: 55 8B EC B8 0A 12 50 C4 5E 06 26 FF 9F F8 00 59 C4 5E 06 26 FF 5F 74 50 C4 5E 06 26 FF 9F 90 00 59 5D CB 55 8B EC 33 C0 50 C4 5E 06 26 FF 5F 24 50 C4 5E 06 26 FF 5F 20 50 C4 5E 06 26 FF 5F 2C 83 C4 06 5D CB 55 8B EC B8 01 00 50 C4 5E 06 26 FF 5F 24 50 C4 5E 06 26 FF 5F 20 50 C4 5E 06 26 FF 5F 2C 83 C4 06 5D CB 
        }

    }
}
