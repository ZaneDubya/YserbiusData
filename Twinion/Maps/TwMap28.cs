#pragma warning disable
using System.Collections.Generic;
using XPT.WorldData;
using XPT.WorldData.Yserbius;

namespace XPT.Scripts.Twinion.Maps {
    class TwMap28 : AMapScripted {
        protected override int MapIndex => 28;
        protected override int RandomEncounterChance => 11;
        protected override int RandomEncounterExtraCount => 1;

        public TwMap28() {
            MapEvent01 = FnASTRAL_01;
            MapEvent02 = FnCOMMONDR_02;
            MapEvent03 = FnTOPHYSND_03;
            MapEvent05 = FnPOOLS_05;
            MapEvent06 = FnLAVAS_06;
            MapEvent07 = FnFAKEDOOR_07;
            MapEvent09 = FnTOPLANAR_09;
            MapEvent0A = FnASTRITEM_0A;
            MapEvent0B = FnNIMBUS_0B;
            MapEvent0C = FnCASEONE_0C;
            MapEvent0D = FnCASETWO_0D;
            MapEvent0E = FnCASETHRE_0E;
            MapEvent0F = FnCASEFOUR_0F;
            MapEvent10 = FnCASEFIVE_10;
            MapEvent11 = FnAFTERALL_11;
            MapEvent12 = FnASTRBATA_12;
            MapEvent13 = FnASTRBATB_13;
            MapEvent14 = FnASTBATC_14;
            MapEvent15 = FnATBATD_15;
            MapEvent16 = FnSWIRLAST_16;
            MapEvent17 = FnATRNPCA_17;
            MapEvent18 = FnASTRNPCB_18;
            MapEvent19 = FnASTRBATE_19;
            MapEvent1A = FnASTRFNTA_1A;
            MapEvent1B = FnASTRFNTB_1B;
            MapEvent1C = FnGASTRAP_1C;
            MapEvent1D = FnGASENC_1D;
            MapEvent1E = FnPETRIFY_1E;
            MapEvent1F = FnPHYMESS_1F;
            MapEvent20 = FnPOOLSMES_20;
            MapEvent21 = FnLAVAMESS_21;
            MapEvent22 = FnLAVAENCA_22;
            MapEvent23 = FnLAVAENCB_23;
            MapEvent24 = FnLAVAENCC_24;
            MapEvent25 = FnLAVAENCD_25;
            MapEvent26 = FnPHYSITEM_26;
            MapEvent27 = FnTORCHMES_27;
            MapEvent2A = FnPHYSBATA_2A;
            MapEvent2B = FnPHYSBATB_2B;
            MapEvent2C = FnGUARDS_2C;
            MapEvent2D = FnLASTHALL_2D;
            MapEvent2E = FnTOSWITCH_2E;
            MapEvent2F = FnCASEPHYS_2F;
            MapEvent31 = FnPHYSFNT_31;
            MapEvent32 = FnCASETTRP_32;
            MapEvent36 = FnGRATOK_36;
            MapEvent37 = FnDAMGPOOL_37;
            MapEvent38 = FnWATRFITA_38;
            MapEvent39 = FnWATRFITB_39;
            MapEvent3A = FnNOZONE_3A;
            MapEvent3B = FnNOMAPS_3B;
            MapEvent3C = FnHALLTEXT_3C;
            MapEvent3D = FnBLOCKWAL_3D;
            MapEvent3E = FnNOASMAP_3E;
            MapEvent3F = FnSETFLAG_3F;
            MapEvent40 = FnWORDONE_40;
            MapEvent41 = FnWORDTWO_41;
            MapEvent42 = FnWORTHREE_42;
            MapEvent43 = FnWRDFOUR_43;
            MapEvent44 = FnWRDFIVE_44;
            MapEvent45 = FnWRDSIX_45;
            MapEvent46 = FnPORTBACK_46;
            MapEvent47 = FnSETFLAG_47;
            MapEvent48 = FnPORTBACK_48;
            MapEvent4B = FnTORCHROM_4B;
        }
        
        // === Strings ================================================
        private const string String03FC = "Astral material permeates this place";
        private const string String0421 = "This teleport is riddled with archaic markings.";
        private const string String0451 = "The clear waters let you see treasure in the pool's bottom.";
        private const string String048D = "The pool's waters are cloudy, perhaps they will be clear later.";
        private const string String04CD = "The seething lava scorches you.";
        private const string String04ED = "To Astelligus!";
        private const string String04FC = "The Nimbus of the Fates is in a glass case on the southern wall. You need only defeat those who guard it.";
        private const string String0566 = "You take the Nimbus of the Fates.";
        private const string String0588 = "With it, you may face Astelligus.";
        private const string String05AA = "Gain in experience from your accomplishment!";
        private const string String05D7 = "'You shall not pass!'";
        private const string String05ED = "Guardians of the Winds defend the Eye; the compass that will guide you towards the Nimbus.";
        private const string String0648 = "Restless entities battle eternally here.";
        private const string String0671 = "An astral wind rips through you.";
        private const string String0692 = "'The Wind Knights hath no fury in this domain! The four winds here are reversed!'";
        private const string String06E4 = "'Feuding entities battle the winds. Direction is the key to the portals here.";
        private const string String0732 = "I offer you this, the first letter of each direction is visible when you see in the past!";
        private const string String078C = "Do not think that you must move in a different direction each move the second time through...see in the past!'";
        private const string String07FB = "The Fountain of Faith speaks: ";
        private const string String081A = "'See in the past...past tense of SEE!'";
        private const string String0841 = "The Fountain of Lies ";
        private const string String0857 = "whispers: 'See in the past? Ha! Look towards the future!'";
        private const string String0891 = "Noxious gas fills the room";
        private const string String08AC = "Powerful beasts battle here for amphoras!!";
        private const string String08D7 = "Screams of some ghostly spirit echo within these walls.";
        private const string String090F = "Hail all who seek Corpeus of the Physical plane.";
        private const string String0940 = "This pathway will lead to his Hall.";
        private const string String0964 = "You can taste the stale air that fills this area. The floor here is covered with stagnant pools of strange liquids.";
        private const string String09D8 = "The heat overwhelms you here.";
        private const string String09F6 = "The flickering torches cast eerie shadows.";
        private const string String0A21 = "Jeweled torch-lamps are affixed to the walls here as switches. Each has three settings. You must know the pattern to set the correct sequence.";
        private const string String0AB0 = "To Corpeus.";
        private const string String0ABC = "TO TORCH ROOM";
        private const string String0ACA = "A magical portal appears in the wall!";
        private const string String0AF0 = "You must enter alone!";
        private const string String0B06 = "The Fountain of Corpeus raises your physical prowess and enhances your agility!";
        private const string String0B56 = "The waters heal you.";
        private const string String0B6B = "Your keen senses allow you to avoid a devastating trap.";
        private const string String0BA3 = "The torch here explodes with fire!";
        private const string String0BC6 = "You clumsily set off a gas trap.";
        private const string String0BE7 = "A refreshing shower of magical waters is a nice change to these fiendish traps!";
        private const string String0C37 = "A mental blast of power is thrust upon you!";
        private const string String0C63 = "'Ahh, welcome to the Physical path. I am Gratok, allow me to guide you.";
        private const string String0CAB = "Go now to the west then to the south. Search the walls for the portals. I will see you there.'";
        private const string String0D0A = "'We meet again. Now, northward, portals here will open when you have completed certain actions.";
        private const string String0D6A = "Remember to search the walls!'";
        private const string String0D89 = "'Servitude is my destiny now. For I had created this pathway in honor of Corpeus. Now I am doomed to help those who would seek him.'";
        private const string String0E0E = "'Well done. You must find the room where torches are switches. Set them as I say, then return to the starting hallway.";
        private const string String0E85 = "Time follows death from life'";
        private const string String0EA3 = "'Time wastes. Past the Guardians to the east of stagnation lies the torch room. You must know the combination to proceed there.'";
        private const string String0F24 = "'WELL DONE! Off you go to the next phase. Water leads to magic sands.'";
        private const string String0F6B = "'You must try again. This portal will take you to the start of this level.'";
        private const string String0FB7 = "Now you may enter the torch room again.";
        private const string String0FDF = "'Onward! You've earned the next series by conquering the Hall.";
        private const string String101E = "Magic lava leads to death.'";
        private const string String103A = "'Do as I say. My familiars will guide you.'";
        private const string String1066 = "The magical fluids drain you.";
        private const string String1084 = "Medusas guard this gateway!";
        private const string String10A0 = "This hallway is laden with traps. You are powerless and confused.";
        private const string String10E2 = "You manage to avoid the trap!";
        private const string String1100 = "A whirlwind of magic rushes through the hallway draining and dragging you!";
        private const string String114B = "Back to the beginning! You must try again.";
        private const string String1176 = "This hallway is of lethal cunning. Only the most ingenious and powerful heroes will survive.";
        private const string String11D3 = "'I can not help you here. I offer you this warning:'";
        private const string String1208 = "'Farewell!'";
        private const string String1214 = "An unseen force holds you back!";
        private const string String1234 = "A dragon's face carved on the wall here animates and spews forth dragon's breath!";
        private const string String1286 = "Deadly poisons drip onto you from above.";
        private const string String12AF = "North";
        private const string String12B5 = "West";
        private const string String12BA = "East";
        private const string String12BF = "South";
        private const string String12C5 = "'You must remain in this hallway until your task has been completed!'";
        private const string String130B = "-Center-";
        private const string String1314 = "There is nothing here.";
        private const string String132B = "DEATH";
        private const string String1331 = "WATER";
        private const string String1337 = "LIFE";
        private const string String133C = "SANDS";
        private const string String1342 = "TO";
        private const string String1345 = "FOLLOWS";
        private const string String134D = "TIME";
        private const string String1352 = "MAGIC";
        private const string String1358 = "LAVA";
        private const string String135D = "FROM";
        private const string String1362 = "OF";
        private const string String1365 = "LEADS";
        private const string String136B = "This portal is the only way back to the start of this level. Use it only if you have set the switches.";
        private const string String13D2 = "Gain experience for your accomplishment!";
        private const string String13FB = "Magical words emblazoned on the door glow as you approach: 'Torch Room'.";
        private const string String1444 = "The door is sealed...you will be told when to return to the Torch Room.";
        
        // === Functions ================================================
        private void FnASTRAL_01(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String03FC); // Astral material permeates this place
            L0010: return; // RETURN;
        }

        private void FnCOMMONDR_02(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0021: return; // RETURN;
        }

        private void FnTOPHYSND_03(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0421); // This teleport is riddled with archaic markings.
            L0010: TeleportParty(player, 0x0B, 0x04, 0x3C, 0x03, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnPOOLS_05(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0076  0003 83 EC 06  sub sp, 0x6
0079  0006 56     push si
007A  0007 57     push di
            L0008: di = 0;
007D  000A C7 46 FE 00 00  mov word [bp-0x2], 0x0
0082  000F C7 46 FC 00 00  mov word [bp-0x4], 0x0
            L0014: si = GetFlag(player, 0x02, 0x71);
009A  0027 FF 76 08  push word [bp+0x8]
009D  002A FF 76 06  push word [bp+0x6]
00A0  002D 0E     push cs
00A1  002E E8 99 1E  call 0x1eca
            L0031: // NOP
            L0032: cx = PopStack(player);
            L0033: cx = PopStack(player);
            L0034: RefreshCompareFlags(GetCurrentHits(player));
            L003D: if (JumpAbove) goto L0042;
            L003F: goto L0116;
00B5  0042 FF 76 08  push word [bp+0x8]
00B8  0045 FF 76 06  push word [bp+0x6]
00BB  0048 0E     push cs
00BC  0049 E8 AC 1E  call 0x1ef8
            L004C: // NOP
            L004D: cx = PopStack(player);
            L004E: cx = PopStack(player);
            L004F: ax = GetCurrentTile(player);
00C9  0056 89 46 FA  mov [bp-0x6], ax
00CC  0059 B9 04 00  mov cx, 0x4
            L005C: bx = 0x018F;
00D2  005F 2E 8B 07  mov ax, [cs:bx]
00D5  0062 3B 46 FA  cmp ax, [bp-0x6]
            L0065: if (JumpEqual) goto L006D;
00DA  0067 43     inc bx
00DB  0068 43     inc bx
00DC  0069 E2 F4  loop 0x5f
            L006B: goto L00B2;
00E0  006D 2E FF 67 08  jmp word [cs:bx+0x8]
            L0071: si = 0x0001;
            L0074: di = 0x00BB;
00EA  0077 C7 46 FE 5C 00  mov word [bp-0x2], 0x5c
            L007C: goto L00B2;
            L007E: si = 0x0002;
            L0081: di = 0x00BD;
00F7  0084 C7 46 FE 10 00  mov word [bp-0x2], 0x10
00FC  0089 C7 46 FC E8 03  mov word [bp-0x4], 0x3e8
            L008E: goto L00B2;
            L0090: si = 0x0003;
            L0093: di = 0x006C;
0109  0096 C7 46 FE CE 00  mov word [bp-0x2], 0xce
010E  009B C7 46 FC B8 0B  mov word [bp-0x4], 0xbb8
            L00A0: goto L00B2;
            L00A2: si = 0x0004;
            L00A5: di = 0x0008;
011B  00A8 C7 46 FE 4D 00  mov word [bp-0x2], 0x4d
0120  00AD C7 46 FC A2 FE  mov word [bp-0x4], 0xfea2
            L00B2: Compare(GetFlag(player, 0x02, 0x71), si);
            L00C5: if (JumpNotEqual) goto L0109;
            L00C7: ShowMessage(player, String0451); // The clear waters let you see treasure in the pool's bottom.
0147  00D4 57     push di
0148  00D5 C4 5E 06  les bx, [bp+0x6]
014B  00D8 26 FF 5F 48  call far word [es:bx+0x48]
            L00DC: cx = PopStack(player);
0150  00DD FF 76 FE  push word [bp-0x2]
0153  00E0 C4 5E 06  les bx, [bp+0x6]
0156  00E3 26 FF 5F 48  call far word [es:bx+0x48]
            L00E7: cx = PopStack(player);
015B  00E8 FF 76 FC  push word [bp-0x4]
015E  00EB C4 5E 06  les bx, [bp+0x6]
0161  00EE 26 FF 9F B4 00  call far word [es:bx+0xb4]
            L00F3: cx = PopStack(player);
            L00F4: si = si + 1;
            L00F5: SetFlag(player, 0xC4, 0xB8, si);
            L0107: goto L0116;
            L0109: ShowMessage(player, String048D); // The pool's waters are cloudy, perhaps they will be clear later.
0189  0116 5F     pop di
018A  0117 5E     pop si
            L0118: // restore stack ptr: sp = bp;
            L011A: return; // RETURN;
            // Extra data: 02 00 03 00 06 00 16 00 E4 00 F1 00 03 01 15 01 
        }

        private void FnLAVAS_06(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
01A2  0003 FF 76 08  push word [bp+0x8]
01A5  0006 FF 76 06  push word [bp+0x6]
01A8  0009 0E     push cs
01A9  000A E8 BF 1D  call 0x1dcc
            L000D: // NOP
            L000E: cx = PopStack(player);
            L000F: cx = PopStack(player);
            L0010: SetNoHealZone(player);
            L0018: PushStack(player, 0x01);
            L001C: PushStack(player, 0x00);
01BE  001F C4 5E 06  les bx, [bp+0x6]
01C1  0022 26 FF 5F 04  call far word [es:bx+0x4]
            L0026: cx = PopStack(player);
            L0027: cx = PopStack(player);
            L0028: RefreshCompareFlags(ax);
            L002A: if (JumpNotEqual) goto L005D;
            L002C: ax = GetCurrentHits(player);
            L0033: bx = 0x0008;
            L0036: dx = ax % bx; ax = ax / bx;
            L0039: DamagePlayer(player, ax);
            L0043: ShowMessage(player, String04CD); // The seething lava scorches you.
01EF  0050 FF 76 08  push word [bp+0x8]
01F2  0053 FF 76 06  push word [bp+0x6]
01F5  0056 0E     push cs
01F6  0057 E8 2E 1D  call 0x1d88
            L005A: // NOP
            L005B: cx = PopStack(player);
            L005C: cx = PopStack(player);
            L005D: return; // RETURN;
        }

        private void FnFAKEDOOR_07(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0020: return; // RETURN;
        }

        private void FnTOPLANAR_09(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String04ED); // To Astelligus!
            L0010: TeleportParty(player, 0x0B, 0x04, 0x72, 0x02, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnASTRITEM_0A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: RefreshCompareFlags(GetFlag(player, 0x02, 0x72));
            L0017: if (JumpNotEqual) goto L0045;
            L0019: ax = HasItem(player, 0xEE);
            L0027: if (JumpEqual) goto L0038;
027B  0029 FF 76 08  push word [bp+0x8]
027E  002C FF 76 06  push word [bp+0x6]
0281  002F 0E     push cs
0282  0030 E8 D4 1C  call 0x1d07
            L0033: // NOP
            L0034: cx = PopStack(player);
            L0035: cx = PopStack(player);
            L0036: goto L0045;
            L0038: ShowMessage(player, String04FC); // The Nimbus of the Fates is in a glass case on the southern wall. You need only defeat those who guard it.
            L0045: Compare(PartyCount(player), 0x0001);
            L0050: if (JumpEqual) goto L0059;
            L0052: Compare(ax, 0x0002);
            L0055: if (JumpEqual) goto L0059;
            L0057: goto L0075;
            L0059: si = 0x0001;
            L005C: goto L006E;
            L005E: AddEncounter(player, si, 0x28);
            L006D: si = si + 1;
            L006E: Compare(si, 0x02);
            L0071: if (JumpLessOrEqual) goto L005E;
            L0073: goto L008F;
            L0075: si = 0x0001;
            L0078: goto L008A;
            L007A: AddEncounter(player, si, 0x28);
            L0089: si = si + 1;
            L008A: Compare(si, 0x05);
            L008D: if (JumpLessOrEqual) goto L007A;
            L008F: return; // RETURN (restoring si);
        }

        private void FnNIMBUS_0B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x02, 0x72));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00C8;
            L001B: ax = HasItem(player, 0xEE);
            L0029: if (JumpEqual) goto L002E;
            L002B: goto L00C8;
            L002E: ax = HasItem(player, 0xEE);
            L003C: if (JumpEqual) goto L0041;
            L003E: goto L00D5;
            L0041: ShowMessage(player, String0566); // You take the Nimbus of the Fates.
            L004E: ShowMessage(player, String0588); // With it, you may face Astelligus.
            L005B: GiveItem(player, 0xEE);
            L0067: RefreshCompareFlags(GetFlag(player, 0x02, 0x74));
            L007A: if (JumpEqual) goto L0092;
            L007C: Compare(GetFlag(player, 0x02, 0x74), 0x0001);
            L0090: if (JumpNotEqual) goto L00D5;
            L0092: ShowMessage(player, String05AA); // Gain in experience from your accomplishment!
            L009F: AddExperience(player, 0x0009EB10);
            L00B1: SetFlag(player, 0x02, 0x74, 0x02);
            L00C6: goto L00D5;
03AC  00C8 FF 76 08  push word [bp+0x8]
03AF  00CB FF 76 06  push word [bp+0x6]
03B2  00CE 0E     push cs
03B3  00CF E8 A3 1B  call 0x1c75
            L00D2: // NOP
            L00D3: cx = PopStack(player);
            L00D4: cx = PopStack(player);
            L00D5: return; // RETURN;
        }

        private void FnCASEONE_0C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
03BE  0003 83 EC 04  sub sp, 0x4
03C1  0006 56     push si
03C2  0007 57     push di
03C3  0008 FF 76 08  push word [bp+0x8]
03C6  000B FF 76 06  push word [bp+0x6]
03C9  000E 0E     push cs
03CA  000F E8 DC 1A  call 0x1aee
            L0012: // NOP
            L0013: cx = PopStack(player);
            L0014: cx = PopStack(player);
03D0  0015 C4 5E 06  les bx, [bp+0x6]
03D3  0018 26 FF 9F B8 00  call far word [es:bx+0xb8]
            L001D: RefreshCompareFlags(ax);
            L001F: if (JumpNotEqual) goto L0024;
            L0021: goto L015B;
            L0024: bx = GetFacing(player);
            L002D: Compare(bx, 0x03);
            L0030: if (JumpBelowOrEqual) goto L0035;
            L0032: goto L0108;
            L0035: switch (bx) {
                case 0:
                    goto L00AF;
                case 1:
                    goto L004F;
                case 2:
                    goto L00AA;
                case 3:
                    goto L003C;
            }
            L003C: si = 0x0099;
            L003F: di = 0x009D;
03FD  0042 C7 46 FE 02 00  mov word [bp-0x2], 0x2
0402  0047 C7 46 FC 03 00  mov word [bp-0x4], 0x3
            L004C: goto L0108;
            L004F: si = 0x00D9;
            L0052: Compare(GetFlag(player, 0x02, 0x74), 0x0002);
            L0066: if (JumpEqual) goto L0078;
            L0068: ax = HasItem(player, 0xEE);
            L0076: if (JumpEqual) goto L009E;
            L0078: PushStack(player, GetFlag(player, 0x03, 0x1B));
            L008A: ax = GetCurrentTile(player);
            L0091: dx = PopStack(player);
044D  0092 3B D0  cmp dx, ax
            L0094: if (JumpNotEqual) goto L009B;
            L0096: di = 0x009D;
            L0099: goto L009E;
            L009B: di = 0x00DE;
0459  009E C7 46 FE 00 00  mov word [bp-0x2], 0x0
045E  00A3 C7 46 FC 01 00  mov word [bp-0x4], 0x1
            L00A8: goto L0108;
            L00AA: si = 0x00D9;
            L00AD: goto L003F;
            L00AF: Compare(GetFlag(player, 0x02, 0x74), 0x0001);
            L00C3: if (JumpBelowOrEqual) goto L00D5;
            L00C5: ax = HasItem(player, 0xEE);
            L00D3: if (JumpNotEqual) goto L00FB;
            L00D5: PushStack(player, GetFlag(player, 0x03, 0x1B));
            L00E7: ax = GetCurrentTile(player);
            L00EE: dx = PopStack(player);
04AA  00EF 3B D0  cmp dx, ax
            L00F1: if (JumpNotEqual) goto L00F8;
            L00F3: si = 0x00E8;
            L00F6: goto L00FB;
            L00F8: si = 0x00D9;
            L00FB: di = 0x0099;
04B9  00FE C7 46 FE 03 00  mov word [bp-0x2], 0x3
04BE  0103 C7 46 FC 00 00  mov word [bp-0x4], 0x0
            L0108: Compare(GetFlag(player, 0x02, 0x74), 0x0001);
            L011C: if (JumpBelowOrEqual) goto L012E;
            L011E: ax = HasItem(player, 0xEE);
            L012C: if (JumpNotEqual) goto L0134;
04E9  012E FF 76 FE  push word [bp-0x2]
04EC  0131 56     push si
            L0132: goto L0148;
            L0134: ax = HasItem(player, 0xEE);
            L0142: if (JumpEqual) goto L015B;
04FF  0144 FF 76 FC  push word [bp-0x4]
0502  0147 57     push di
            L0148: PushStack(player, 0x03);
            L014C: PushStack(player, 0x0B);
050B  0150 C4 5E 06  les bx, [bp+0x6]
050E  0153 26 FF 9F BC 00  call far word [es:bx+0xbc]
0513  0158 83 C4 08  add sp, 0x8
0516  015B 5F     pop di
0517  015C 5E     pop si
            L015D: // restore stack ptr: sp = bp;
            L015F: return; // RETURN;
        }

        private void FnCASETWO_0D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0527  0003 83 EC 04  sub sp, 0x4
052A  0006 56     push si
052B  0007 57     push di
052C  0008 FF 76 08  push word [bp+0x8]
052F  000B FF 76 06  push word [bp+0x6]
0532  000E 0E     push cs
0533  000F E8 73 19  call 0x1985
            L0012: // NOP
            L0013: cx = PopStack(player);
            L0014: cx = PopStack(player);
            L0015: bx = GetFacing(player);
            L001E: Compare(bx, 0x03);
            L0021: if (JumpBelowOrEqual) goto L0026;
            L0023: goto L009C;
            L0025: // NOP
            L0026: switch (bx) {
                case 0:
                    goto L002D;
                case 1:
                    goto L006C;
                case 2:
                    goto L003F;
                case 3:
                    goto L0071;
            }
            L002D: si = 0x0099;
            L0030: di = 0x009D;
0557  0033 C7 46 FE 02 00  mov word [bp-0x2], 0x2
055C  0038 C7 46 FC 03 00  mov word [bp-0x4], 0x3
            L003D: goto L009C;
            L003F: di = 0x0099;
            L0042: Compare(GetFlag(player, 0x03, 0x1B), 0x00FF);
            L0056: if (JumpNotEqual) goto L005D;
            L0058: si = 0x009D;
            L005B: goto L0060;
            L005D: si = 0x00D9;
0584  0060 C7 46 FE 00 00  mov word [bp-0x2], 0x0
0589  0065 C7 46 FC 01 00  mov word [bp-0x4], 0x1
            L006A: goto L009C;
            L006C: si = 0x00ED;
            L006F: goto L0030;
            L0071: Compare(GetFlag(player, 0x03, 0x1B), 0x00FF);
            L0085: if (JumpNotEqual) goto L008C;
            L0087: di = 0x00AC;
            L008A: goto L008F;
            L008C: di = 0x00CF;
            L008F: si = 0x0099;
05B6  0092 C7 46 FE 03 00  mov word [bp-0x2], 0x3
05BB  0097 C7 46 FC 00 00  mov word [bp-0x4], 0x0
            L009C: Compare(GetFlag(player, 0x02, 0x74), 0x0001);
            L00B0: if (JumpBelowOrEqual) goto L00C2;
            L00B2: ax = HasItem(player, 0xEE);
            L00C0: if (JumpNotEqual) goto L00C8;
05E6  00C2 FF 76 FE  push word [bp-0x2]
05E9  00C5 56     push si
            L00C6: goto L00CC;
05EC  00C8 FF 76 FC  push word [bp-0x4]
05EF  00CB 57     push di
            L00CC: PushStack(player, 0x03);
            L00D0: PushStack(player, 0x0B);
05F8  00D4 C4 5E 06  les bx, [bp+0x6]
05FB  00D7 26 FF 9F BC 00  call far word [es:bx+0xbc]
0600  00DC 83 C4 08  add sp, 0x8
0603  00DF 5F     pop di
0604  00E0 5E     pop si
            L00E1: // restore stack ptr: sp = bp;
            L00E3: return; // RETURN;
        }

        private void FnCASETHRE_0E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0614  0003 83 EC 04  sub sp, 0x4
0617  0006 56     push si
0618  0007 57     push di
0619  0008 FF 76 08  push word [bp+0x8]
061C  000B FF 76 06  push word [bp+0x6]
061F  000E 0E     push cs
0620  000F E8 86 18  call 0x1898
            L0012: // NOP
            L0013: cx = PopStack(player);
            L0014: cx = PopStack(player);
            L0015: bx = GetFacing(player);
            L001E: Compare(bx, 0x03);
            L0021: if (JumpAbove) goto L007E;
            L0023: switch (bx) {
                case 0:
                    goto L006E;
                case 1:
                    goto L002A;
                case 2:
                    goto L0069;
                case 3:
                    goto L003C;
            }
            L002A: si = 0x00E8;
            L002D: di = 0x009D;
0641  0030 C7 46 FE 02 00  mov word [bp-0x2], 0x2
0646  0035 C7 46 FC 03 00  mov word [bp-0x4], 0x3
            L003A: goto L007E;
            L003C: di = 0x00D9;
            L003F: Compare(GetFlag(player, 0x03, 0x1B), 0x00FF);
            L0053: if (JumpNotEqual) goto L005A;
            L0055: si = 0x00A8;
            L0058: goto L005D;
            L005A: si = 0x0099;
066E  005D C7 46 FE 00 00  mov word [bp-0x2], 0x0
0673  0062 C7 46 FC 01 00  mov word [bp-0x4], 0x1
            L0067: goto L007E;
            L0069: si = 0x00D9;
            L006C: goto L002D;
            L006E: si = 0x00DE;
            L0071: di = 0x0099;
0685  0074 C7 46 FE 03 00  mov word [bp-0x2], 0x3
068A  0079 C7 46 FC 00 00  mov word [bp-0x4], 0x0
            L007E: Compare(GetFlag(player, 0x02, 0x74), 0x0001);
            L0092: if (JumpBelowOrEqual) goto L00A4;
            L0094: ax = HasItem(player, 0xEE);
            L00A2: if (JumpNotEqual) goto L00AA;
06B5  00A4 FF 76 FE  push word [bp-0x2]
06B8  00A7 56     push si
            L00A8: goto L00AE;
06BB  00AA FF 76 FC  push word [bp-0x4]
06BE  00AD 57     push di
            L00AE: PushStack(player, 0x03);
            L00B2: PushStack(player, 0x0B);
06C7  00B6 C4 5E 06  les bx, [bp+0x6]
06CA  00B9 26 FF 9F BC 00  call far word [es:bx+0xbc]
06CF  00BE 83 C4 08  add sp, 0x8
06D2  00C1 5F     pop di
06D3  00C2 5E     pop si
            L00C3: // restore stack ptr: sp = bp;
            L00C5: return; // RETURN;
        }

        private void FnCASEFOUR_0F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
06E3  0003 83 EC 04  sub sp, 0x4
06E6  0006 56     push si
06E7  0007 57     push di
06E8  0008 FF 76 08  push word [bp+0x8]
06EB  000B FF 76 06  push word [bp+0x6]
06EE  000E 0E     push cs
06EF  000F E8 B7 17  call 0x17c9
            L0012: // NOP
            L0013: cx = PopStack(player);
            L0014: cx = PopStack(player);
            L0015: bx = GetFacing(player);
            L001E: Compare(bx, 0x03);
            L0021: if (JumpBelowOrEqual) goto L0026;
            L0023: goto L00A1;
            L0025: // NOP
            L0026: switch (bx) {
                case 0:
                    goto L0091;
                case 1:
                    goto L003F;
                case 2:
                    goto L0064;
                case 3:
                    goto L002D;
            }
            L002D: si = 0x00E8;
            L0030: di = 0x009D;
0713  0033 C7 46 FE 02 00  mov word [bp-0x2], 0x2
0718  0038 C7 46 FC 03 00  mov word [bp-0x4], 0x3
            L003D: goto L00A1;
            L003F: di = 0x009D;
            L0042: Compare(GetFlag(player, 0x03, 0x1B), 0x00FF);
            L0056: if (JumpNotEqual) goto L005D;
            L0058: si = 0x00C6;
            L005B: goto L0085;
            L005D: si = 0x009E;
            L0060: goto L0085;
            L0062: goto L0085;
            L0064: si = 0x009D;
            L0067: Compare(GetFlag(player, 0x03, 0x1B), 0x00FF);
            L007B: if (JumpNotEqual) goto L0082;
            L007D: di = 0x00AF;
            L0080: goto L0085;
            L0082: di = 0x00E8;
0765  0085 C7 46 FE 00 00  mov word [bp-0x2], 0x0
076A  008A C7 46 FC 01 00  mov word [bp-0x4], 0x1
            L008F: goto L00A1;
            L0091: si = 0x00BB;
            L0094: di = 0x00E4;
0777  0097 C7 46 FE 03 00  mov word [bp-0x2], 0x3
077C  009C C7 46 FC 00 00  mov word [bp-0x4], 0x0
            L00A1: Compare(GetFlag(player, 0x02, 0x74), 0x0001);
            L00B5: if (JumpBelowOrEqual) goto L00C7;
            L00B7: ax = HasItem(player, 0xEE);
            L00C5: if (JumpNotEqual) goto L00CD;
07A7  00C7 FF 76 FE  push word [bp-0x2]
07AA  00CA 56     push si
            L00CB: goto L00D1;
07AD  00CD FF 76 FC  push word [bp-0x4]
07B0  00D0 57     push di
            L00D1: PushStack(player, 0x03);
            L00D5: PushStack(player, 0x0B);
07B9  00D9 C4 5E 06  les bx, [bp+0x6]
07BC  00DC 26 FF 9F BC 00  call far word [es:bx+0xbc]
07C1  00E1 83 C4 08  add sp, 0x8
07C4  00E4 5F     pop di
07C5  00E5 5E     pop si
            L00E6: // restore stack ptr: sp = bp;
            L00E8: return; // RETURN;
        }

        private void FnCASEFIVE_10(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
07D5  0003 83 EC 04  sub sp, 0x4
07D8  0006 56     push si
07D9  0007 57     push di
07DA  0008 FF 76 08  push word [bp+0x8]
07DD  000B FF 76 06  push word [bp+0x6]
07E0  000E 0E     push cs
07E1  000F E8 C5 16  call 0x16d7
            L0012: // NOP
            L0013: cx = PopStack(player);
            L0014: cx = PopStack(player);
            L0015: bx = GetFacing(player);
            L001E: Compare(bx, 0x03);
            L0021: if (JumpAbove) goto L0081;
            L0023: switch (bx) {
                case 0:
                    goto L0071;
                case 1:
                    goto L003C;
                case 2:
                    goto L0044;
                case 3:
                    goto L002A;
            }
            L002A: di = 0x00AC;
            L002D: si = 0x00B7;
0802  0030 C7 46 FE 02 00  mov word [bp-0x2], 0x2
0807  0035 C7 46 FC 03 00  mov word [bp-0x4], 0x3
            L003A: goto L0081;
            L003C: si = 0x00C6;
            L003F: di = 0x00D5;
            L0042: goto L0065;
            L0044: di = 0x009D;
            L0047: Compare(GetFlag(player, 0x03, 0x1B), 0x00FF);
            L005B: if (JumpNotEqual) goto L0062;
            L005D: si = 0x00AF;
            L0060: goto L0065;
            L0062: si = 0x0099;
0837  0065 C7 46 FE 00 00  mov word [bp-0x2], 0x0
083C  006A C7 46 FC 01 00  mov word [bp-0x4], 0x1
            L006F: goto L0081;
            L0071: di = 0x00BB;
            L0074: si = 0x00ED;
0849  0077 C7 46 FE 03 00  mov word [bp-0x2], 0x3
084E  007C C7 46 FC 00 00  mov word [bp-0x4], 0x0
            L0081: Compare(GetFlag(player, 0x02, 0x74), 0x0001);
            L0095: if (JumpBelowOrEqual) goto L00A7;
            L0097: ax = HasItem(player, 0xEE);
            L00A5: if (JumpNotEqual) goto L00AD;
0879  00A7 FF 76 FE  push word [bp-0x2]
087C  00AA 57     push di
            L00AB: goto L00B1;
087F  00AD FF 76 FC  push word [bp-0x4]
0882  00B0 56     push si
            L00B1: PushStack(player, 0x03);
            L00B5: PushStack(player, 0x0B);
088B  00B9 C4 5E 06  les bx, [bp+0x6]
088E  00BC 26 FF 9F BC 00  call far word [es:bx+0xbc]
0893  00C1 83 C4 08  add sp, 0x8
0896  00C4 5F     pop di
0897  00C5 5E     pop si
            L00C6: // restore stack ptr: sp = bp;
            L00C8: return; // RETURN;
        }

        private void FnAFTERALL_11(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, GetCurrentTile(player));
            L000B: PushStack(player, 0x1B);
            L000F: PushStack(player, 0x03);
08B7  0013 C4 5E 06  les bx, [bp+0x6]
08BA  0016 26 FF 1F  call far word [es:bx]
08BD  0019 83 C4 06  add sp, 0x6
            L001C: TeleportParty(player, 0x0B, 0x03, 0xE4, 0x03, isForwardMove);
            L0037: return; // RETURN;
        }

        private void FnASTRBATA_12(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x02, 0x7E));
            L0016: if (JumpNotEqual) goto L0037;
08F5  0018 B8 98 3A  mov ax, 0x3a98
            L001B: PushStack(player, ax);
            L001C: PushStack(player, 0x00);
            L001F: PushStack(player, 0xCE);
            L0023: PushStack(player, 0xB8);
            L0027: PushStack(player, ax);
            L0028: PushStack(player, 0x11);
0909  002C C4 5E 06  les bx, [bp+0x6]
090C  002F 26 FF 9F D8 00  call far word [es:bx+0xd8]
0911  0034 83 C4 0C  add sp, 0xc
            L0037: ShowMessage(player, String05D7); // 'You shall not pass!'
            L0044: AddEncounter(player, 0x01, 0x27);
            L0056: return; // RETURN;
        }

        private void FnASTRBATB_13(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: si = 0x0001;
            L0007: goto L0019;
            L0009: AddEncounter(player, si, 0x26);
            L0018: si = si + 1;
            L0019: Compare(si, 0x02);
            L001C: if (JumpLessOrEqual) goto L0009;
            L001E: return; // RETURN (restoring si);
        }

        private void FnASTBATC_14(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: Compare(GetCurrentTile(player), 0x00BE);
            L000E: if (JumpNotEqual) goto L0076;
            L0010: ax = HasItem(player, 0xF7);
            L001E: if (JumpNotEqual) goto L004C;
0976  0020 B8 B8 0B  mov ax, 0xbb8
            L0023: PushStack(player, ax);
            L0024: PushStack(player, 0x00);
            L0027: PushStack(player, ax);
            L0028: PushStack(player, 0x89);
            L002C: PushStack(player, 0xCE);
            L0030: PushStack(player, 0xF7);
098A  0034 C4 5E 06  les bx, [bp+0x6]
098D  0037 26 FF 9F D8 00  call far word [es:bx+0xd8]
0992  003C 83 C4 0C  add sp, 0xc
            L003F: ShowMessage(player, String05ED); // Guardians of the Winds defend the Eye; the compass that will guide you towards the Nimbus.
            L004C: RefreshCompareFlags(GetFlag(player, 0x02, 0x74));
            L005F: if (JumpNotEqual) goto L0076;
            L0061: SetFlag(player, 0x02, 0x74, 0x01);
            L0076: Compare(PartyCount(player), 0x0003);
            L0081: if (JumpNotBelow) goto L009F;
            L0083: si = 0x0001;
            L0086: goto L0098;
            L0088: AddEncounter(player, si, 0x24);
            L0097: si = si + 1;
            L0098: Compare(si, 0x03);
            L009B: if (JumpLessOrEqual) goto L0088;
            L009D: goto L00B9;
            L009F: si = 0x0001;
            L00A2: goto L00B4;
            L00A4: AddEncounter(player, si, 0x24);
            L00B3: si = si + 1;
            L00B4: Compare(si, 0x06);
            L00B7: if (JumpLessOrEqual) goto L00A4;
            L00B9: return; // RETURN (restoring si);
        }

        private void FnATBATD_15(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: ShowMessage(player, String0648); // Restless entities battle eternally here.
            L0011: Compare(PartyCount(player), 0x0003);
            L001C: if (JumpNotBelow) goto L003A;
            L001E: si = 0x0001;
            L0021: goto L0033;
            L0023: AddEncounter(player, si, 0x23);
            L0032: si = si + 1;
            L0033: Compare(si, 0x03);
            L0036: if (JumpLessOrEqual) goto L0023;
            L0038: goto L0054;
            L003A: si = 0x0001;
            L003D: goto L004F;
            L003F: AddEncounter(player, si, 0x23);
            L004E: si = si + 1;
            L004F: Compare(si, 0x05);
            L0052: if (JumpLessOrEqual) goto L003F;
            L0054: return; // RETURN (restoring si);
        }

        private void FnSWIRLAST_16(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x01);
            L0007: PushStack(player, 0x00);
0A73  000A C4 5E 06  les bx, [bp+0x6]
0A76  000D 26 FF 5F 04  call far word [es:bx+0x4]
            L0011: cx = PopStack(player);
            L0012: cx = PopStack(player);
            L0013: RefreshCompareFlags(ax);
            L0015: if (JumpNotEqual) goto L0048;
            L0017: ShowMessage(player, String0671); // An astral wind rips through you.
            L0024: ax = GetCurrentHits(player);
            L002B: bx = 0x0008;
            L002E: dx = ax % bx; ax = ax / bx;
            L0031: DamagePlayer(player, ax);
0AA4  003B FF 76 08  push word [bp+0x8]
0AA7  003E FF 76 06  push word [bp+0x6]
0AAA  0041 0E     push cs
0AAB  0042 E8 79 14  call 0x14be
            L0045: // NOP
            L0046: cx = PopStack(player);
            L0047: cx = PopStack(player);
            L0048: return; // RETURN;
        }

        private void FnATRNPCA_17(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x04));
            L0016: if (JumpNotEqual) goto L0047;
            L0018: ShowPortrait(player, 0x000B);
            L0025: ShowMessage(player, String0692); // 'The Wind Knights hath no fury in this domain! The four winds here are reversed!'
            L0032: SetFlag(player, 0x03, 0x04, 0x01);
            L0047: return; // RETURN;
        }

        private void FnASTRNPCB_18(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x05));
            L0016: if (JumpNotEqual) goto L0061;
            L0018: ShowPortrait(player, 0x0014);
            L0025: ShowMessage(player, String06E4); // 'Feuding entities battle the winds. Direction is the key to the portals here.
            L0032: ShowMessage(player, String0732); // I offer you this, the first letter of each direction is visible when you see in the past!
            L003F: ShowMessage(player, String078C); // Do not think that you must move in a different direction each move the second time through...see in the past!'
            L004C: SetFlag(player, 0x03, 0x05, 0x01);
            L0061: return; // RETURN;
        }

        private void FnASTRBATE_19(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: Compare(PartyCount(player), 0x0001);
            L000F: if (JumpEqual) goto L0018;
            L0011: Compare(ax, 0x0002);
            L0014: if (JumpEqual) goto L0018;
            L0016: goto L0034;
            L0018: si = 0x0001;
            L001B: goto L002D;
            L001D: AddEncounter(player, si, 0x21);
            L002C: si = si + 1;
            L002D: Compare(si, 0x02);
            L0030: if (JumpLessOrEqual) goto L001D;
            L0032: goto L004E;
            L0034: si = 0x0001;
            L0037: goto L0049;
            L0039: AddEncounter(player, si, 0x22);
            L0048: si = si + 1;
            L0049: Compare(si, 0x05);
            L004C: if (JumpLessOrEqual) goto L0039;
            L004E: return; // RETURN (restoring si);
        }

        private void FnASTRFNTA_1A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0042);
            L0010: ShowMessage(player, String07FB); // The Fountain of Faith speaks: 
            L001D: ShowMessage(player, String081A); // 'See in the past...past tense of SEE!'
            L002A: HealPlayer(player, GetMaxHits(player));
            L003B: return; // RETURN;
        }

        private void FnASTRFNTB_1B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x01);
            L0007: PushStack(player, 0x00);
0BF7  000A C4 5E 06  les bx, [bp+0x6]
0BFA  000D 26 FF 5F 04  call far word [es:bx+0x4]
            L0011: cx = PopStack(player);
            L0012: cx = PopStack(player);
            L0013: RefreshCompareFlags(ax);
            L0015: if (JumpNotEqual) goto L0079;
            L0017: ShowPortrait(player, 0x0042);
            L0024: ShowMessage(player, String0841); // The Fountain of Lies 
            L0031: ShowMessage(player, String0857); // whispers: 'See in the past? Ha! Look towards the future!'
            L003E: ax = GetCurrentHits(player);
            L0045: bx = 0x0008;
            L0048: dx = ax % bx; ax = ax / bx;
            L004B: DamagePlayer(player, ax);
            L0055: PushStack(player, 0xFA);
            L0059: PushStack(player, 0x0A);
            L005D: PushStack(player, 0x01);
0C4E  0061 C4 5E 06  les bx, [bp+0x6]
0C51  0064 26 FF 9F 9C 00  call far word [es:bx+0x9c]
0C56  0069 83 C4 06  add sp, 0x6
0C59  006C FF 76 08  push word [bp+0x8]
0C5C  006F FF 76 06  push word [bp+0x6]
0C5F  0072 0E     push cs
0C60  0073 E8 C4 12  call 0x133a
            L0076: // NOP
            L0077: cx = PopStack(player);
            L0078: cx = PopStack(player);
            L0079: return; // RETURN;
        }

        private void FnGASTRAP_1C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x01);
            L0007: PushStack(player, 0x00);
0C72  000A C4 5E 06  les bx, [bp+0x6]
0C75  000D 26 FF 5F 04  call far word [es:bx+0x4]
            L0011: cx = PopStack(player);
            L0012: cx = PopStack(player);
            L0013: RefreshCompareFlags(ax);
            L0015: if (JumpNotEqual) goto L005F;
            L0017: ShowMessage(player, String0891); // Noxious gas fills the room
            L0024: ax = GetMaxHits(player);
            L002B: bx = 0x0006;
            L002E: dx = ax % bx; ax = ax / bx;
            L0031: DamagePlayer(player, ax);
            L003B: PushStack(player, 0xFA);
            L003F: PushStack(player, 0x05);
            L0043: PushStack(player, 0x01);
0CAF  0047 C4 5E 06  les bx, [bp+0x6]
0CB2  004A 26 FF 9F 9C 00  call far word [es:bx+0x9c]
0CB7  004F 83 C4 06  add sp, 0x6
0CBA  0052 FF 76 08  push word [bp+0x8]
0CBD  0055 FF 76 06  push word [bp+0x6]
0CC0  0058 0E     push cs
0CC1  0059 E8 63 12  call 0x12bf
            L005C: // NOP
            L005D: cx = PopStack(player);
            L005E: cx = PopStack(player);
            L005F: return; // RETURN;
        }

        private void FnGASENC_1D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0CCC  0003 83 EC 0C  sub sp, 0xc
0CCF  0006 56     push si
0CD0  0007 57     push di
            L0008: di = 0;
0CD3  000A C7 46 FE 00 00  mov word [bp-0x2], 0x0
0CD8  000F C7 46 FC 00 00  mov word [bp-0x4], 0x0
0CDD  0014 C7 46 FA 00 00  mov word [bp-0x6], 0x0
0CE2  0019 C7 46 F8 00 00  mov word [bp-0x8], 0x0
0CE7  001E C7 46 F6 00 00  mov word [bp-0xa], 0x0
0CEC  0023 C7 46 F4 00 00  mov word [bp-0xc], 0x0
            L0028: PushStack(player, 0x03);
            L002C: PushStack(player, ax);
0CF6  002D C4 5E 06  les bx, [bp+0x6]
0CF9  0030 26 FF 5F 04  call far word [es:bx+0x4]
            L0034: cx = PopStack(player);
            L0035: cx = PopStack(player);
            L0036: si = ax;
            L0038: Compare(si, 0x01);
0D04  003B 7D 03  jge 0x40
            L003D: si = 0x0001;
            L0040: bx = si;
            L0042: bx = bx - 1;
            L0043: Compare(bx, 0x04);
            L0046: if (JumpBelowOrEqual) goto L004B;
            L0048: goto L0154;
            L004B: switch (bx) {
                case 0:
                    goto L0052;
                case 1:
                    goto L00A3;
                case 2:
                    goto L00BB;
                case 3:
                    goto L0128;
                case 4:
                    goto L0144;
            }
            L0052: di = 0x0020;
0D1E  0055 C7 46 FE 1F 00  mov word [bp-0x2], 0x1f
0D23  005A C7 46 F4 02 00  mov word [bp-0xc], 0x2
            L005F: si = 0x0002;
            L0062: RefreshCompareFlags(GetFlag(player, 0x02, 0x7F));
            L0075: if (JumpNotEqual) goto L009B;
0D40  0077 C7 46 FC B8 00  mov word [bp-0x4], 0xb8
0D45  007C C7 46 FA CE 00  mov word [bp-0x6], 0xce
0D4A  0081 C7 46 F8 5A 00  mov word [bp-0x8], 0x5a
            L0086: SetFlag(player, 0x02, 0x7F, 0x01);
0D64  009B C7 46 F6 88 13  mov word [bp-0xa], 0x1388
            L00A0: goto L0154;
            L00A3: di = 0x0002;
0D6F  00A6 C7 46 FE 01 00  mov word [bp-0x2], 0x1
0D74  00AB C7 46 F4 02 00  mov word [bp-0xc], 0x2
            L00B0: si = 0x0003;
0D7C  00B3 C7 46 FC 0C 00  mov word [bp-0x4], 0xc
            L00B8: goto L013D;
0D84  00BB C7 46 F4 02 00  mov word [bp-0xc], 0x2
            L00C0: si = 0x0004;
            L00C3: Compare(GetFlag(player, 0x02, 0x7F), 0x0001);
            L00D7: if (JumpNotEqual) goto L0114;
            L00D9: ShowMessage(player, String08AC); // Powerful beasts battle here for amphoras!!
            L00E6: di = 0x001F;
0DB2  00E9 C7 46 FE 1E 00  mov word [bp-0x2], 0x1e
0DB7  00EE C7 46 FC B8 00  mov word [bp-0x4], 0xb8
0DBC  00F3 C7 46 FA B8 00  mov word [bp-0x6], 0xb8
0DC1  00F8 C7 46 F8 B8 00  mov word [bp-0x8], 0xb8
            L00FD: SetFlag(player, 0x02, 0x7F, 0x02);
            L0112: goto L0154;
            L0114: di = 0x0020;
0DE0  0117 C7 46 FE 20 00  mov word [bp-0x2], 0x20
0DE5  011C C7 46 FC B7 00  mov word [bp-0x4], 0xb7
0DEA  0121 C7 46 FA 10 00  mov word [bp-0x6], 0x10
            L0126: goto L0154;
            L0128: di = 0x0005;
0DF4  012B C7 46 FE 05 00  mov word [bp-0x2], 0x5
            L0130: si = 0x0005;
0DFC  0133 C7 46 FC CE 00  mov word [bp-0x4], 0xce
0E01  0138 C7 46 FA CD 00  mov word [bp-0x6], 0xcd
0E06  013D C7 46 F6 C4 09  mov word [bp-0xa], 0x9c4
            L0142: goto L0154;
            L0144: di = 0x0003;
0E10  0147 C7 46 FE 03 00  mov word [bp-0x2], 0x3
0E15  014C C7 46 F4 02 00  mov word [bp-0xc], 0x2
            L0151: si = 0x0002;
0E1D  0154 FF 76 F6  push word [bp-0xa]
            L0157: PushStack(player, 0x00);
            L015A: PushStack(player, ax);
0E24  015B FF 76 F8  push word [bp-0x8]
0E27  015E FF 76 FA  push word [bp-0x6]
0E2A  0161 FF 76 FC  push word [bp-0x4]
0E2D  0164 C4 5E 06  les bx, [bp+0x6]
0E30  0167 26 FF 9F D8 00  call far word [es:bx+0xd8]
0E35  016C 83 C4 0C  add sp, 0xc
0E38  016F 57     push di
            L0170: PushStack(player, 0x01);
0E3D  0174 C4 5E 06  les bx, [bp+0x6]
0E40  0177 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L017C: cx = PopStack(player);
            L017D: cx = PopStack(player);
0E47  017E 83 7E F4 00  cmp word [bp-0xc], 0x0
            L0182: if (JumpEqual) goto L0194;
0E4D  0184 FF 76 FE  push word [bp-0x2]
0E50  0187 FF 76 F4  push word [bp-0xc]
0E53  018A C4 5E 06  les bx, [bp+0x6]
0E56  018D 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L0192: cx = PopStack(player);
            L0193: cx = PopStack(player);
0E5D  0194 56     push si
            L0195: PushStack(player, 0x03);
            L0199: PushStack(player, ax);
0E63  019A C4 5E 06  les bx, [bp+0x6]
0E66  019D 26 FF 1F  call far word [es:bx]
0E69  01A0 83 C4 06  add sp, 0x6
0E6C  01A3 5F     pop di
0E6D  01A4 5E     pop si
            L01A5: // restore stack ptr: sp = bp;
            L01A7: return; // RETURN;
        }

        private void FnPETRIFY_1E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String08D7); // Screams of some ghostly spirit echo within these walls.
            L0010: return; // RETURN;
        }

        private void FnPHYMESS_1F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String090F); // Hail all who seek Corpeus of the Physical plane.
            L0010: ShowMessage(player, String0940); // This pathway will lead to his Hall.
            L001D: return; // RETURN;
        }

        private void FnPOOLSMES_20(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0964); // You can taste the stale air that fills this area. The floor here is covered with stagnant pools of strange liquids.
            L0010: RefreshCompareFlags(GetFlag(player, 0x02, 0x71));
            L0023: if (JumpNotEqual) goto L003A;
            L0025: SetFlag(player, 0x02, 0x71, 0x01);
            L003A: return; // RETURN;
        }

        private void FnLAVAMESS_21(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x01);
            L0007: PushStack(player, 0x00);
0EF3  000A C4 5E 06  les bx, [bp+0x6]
0EF6  000D 26 FF 5F 04  call far word [es:bx+0x4]
            L0011: cx = PopStack(player);
            L0012: cx = PopStack(player);
            L0013: RefreshCompareFlags(ax);
            L0015: if (JumpNotEqual) goto L0048;
            L0017: ShowMessage(player, String09D8); // The heat overwhelms you here.
            L0024: ax = GetCurrentHits(player);
            L002B: bx = 0x0008;
            L002E: dx = ax % bx; ax = ax / bx;
            L0031: DamagePlayer(player, ax);
0F24  003B FF 76 08  push word [bp+0x8]
0F27  003E FF 76 06  push word [bp+0x6]
0F2A  0041 0E     push cs
0F2B  0042 E8 F9 0F  call 0x103e
            L0045: // NOP
            L0046: cx = PopStack(player);
            L0047: cx = PopStack(player);
            L0048: return; // RETURN;
        }

        private void FnLAVAENCA_22(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: Compare(GetFlag(player, 0x03, 0x06), 0x0001);
            L0018: if (JumpEqual) goto L003A;
            L001A: ax = HasItem(player, 0x29);
            L0028: if (JumpNotEqual) goto L003A;
            L002A: ax = HasItem(player, 0x56);
            L0038: if (JumpEqual) goto L0049;
0F6D  003A B8 D0 07  mov ax, 0x7d0
            L003D: PushStack(player, ax);
            L003E: PushStack(player, 0x00);
            L0041: PushStack(player, ax);
            L0042: PushStack(player, ax);
            L0043: PushStack(player, ax);
0F77  0044 B8 0A 00  mov ax, 0xa
            L0047: goto L005C;
0F7C  0049 B8 E8 03  mov ax, 0x3e8
            L004C: PushStack(player, ax);
            L004D: PushStack(player, 0x00);
            L0050: PushStack(player, ax);
            L0051: PushStack(player, 0x69);
            L0055: PushStack(player, 0x56);
            L0059: PushStack(player, 0x29);
0F90  005D C4 5E 06  les bx, [bp+0x6]
0F93  0060 26 FF 9F D8 00  call far word [es:bx+0xd8]
0F98  0065 83 C4 0C  add sp, 0xc
            L0068: Compare(PartyCount(player), 0x0001);
            L0073: if (JumpEqual) goto L007C;
            L0075: Compare(ax, 0x0002);
            L0078: if (JumpEqual) goto L007C;
            L007A: goto L0098;
            L007C: si = 0x0001;
            L007F: goto L0091;
            L0081: AddEncounter(player, si, 0x19);
            L0090: si = si + 1;
            L0091: Compare(si, 0x02);
            L0094: if (JumpLessOrEqual) goto L0081;
            L0096: goto L00B2;
            L0098: si = 0x0001;
            L009B: goto L00AD;
            L009D: AddEncounter(player, si, 0x19);
            L00AC: si = si + 1;
            L00AD: Compare(si, 0x05);
            L00B0: if (JumpLessOrEqual) goto L009D;
            L00B2: return; // RETURN (restoring si);
        }

        private void FnLAVAENCB_23(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: Compare(PartyCount(player), 0x0001);
            L000F: if (JumpEqual) goto L0018;
            L0011: Compare(ax, 0x0002);
            L0014: if (JumpEqual) goto L0018;
            L0016: goto L0034;
            L0018: si = 0x0001;
            L001B: goto L002D;
            L001D: AddEncounter(player, si, 0x16);
            L002C: si = si + 1;
            L002D: Compare(si, 0x02);
            L0030: if (JumpLessOrEqual) goto L001D;
            L0032: goto L004E;
            L0034: si = 0x0001;
            L0037: goto L0049;
            L0039: AddEncounter(player, si, 0x16);
            L0048: si = si + 1;
            L0049: Compare(si, 0x05);
            L004C: if (JumpLessOrEqual) goto L0039;
            L004E: return; // RETURN (restoring si);
        }

        private void FnLAVAENCC_24(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: Compare(PartyCount(player), 0x0001);
            L000F: if (JumpEqual) goto L0013;
            L0011: goto L002F;
            L0013: si = 0x0001;
            L0016: goto L0028;
            L0018: AddEncounter(player, si, 0x17);
            L0027: si = si + 1;
            L0028: Compare(si, 0x02);
            L002B: if (JumpLessOrEqual) goto L0018;
            L002D: goto L0049;
            L002F: si = 0x0001;
            L0032: goto L0044;
            L0034: AddEncounter(player, si, 0x17);
            L0043: si = si + 1;
            L0044: Compare(si, 0x03);
            L0047: if (JumpLessOrEqual) goto L0034;
            L0049: return; // RETURN (restoring si);
        }

        private void FnLAVAENCD_25(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: Compare(PartyCount(player), 0x0001);
            L000F: if (JumpEqual) goto L0018;
            L0011: Compare(ax, 0x0002);
            L0014: if (JumpEqual) goto L0018;
            L0016: goto L0034;
            L0018: si = 0x0001;
            L001B: goto L002D;
            L001D: AddEncounter(player, si, 0x18);
            L002C: si = si + 1;
            L002D: Compare(si, 0x02);
            L0030: if (JumpLessOrEqual) goto L001D;
            L0032: goto L004E;
            L0034: si = 0x0001;
            L0037: goto L0049;
            L0039: AddEncounter(player, si, 0x18);
            L0048: si = si + 1;
            L0049: Compare(si, 0x05);
            L004C: if (JumpLessOrEqual) goto L0039;
            L004E: return; // RETURN (restoring si);
        }

        private void FnPHYSITEM_26(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: RefreshCompareFlags(GetFlag(player, 0x02, 0x75));
            L0017: if (JumpNotEqual) goto L001E;
10EF  0019 B8 98 3A  mov ax, 0x3a98
            L001C: goto L0031;
            L001E: ax = HasItem(player, 0xEF);
            L002C: if (JumpNotEqual) goto L0047;
1104  002E B8 AC 0D  mov ax, 0xdac
            L0031: PushStack(player, ax);
            L0032: PushStack(player, 0x00);
            L0035: PushStack(player, ax);
            L0036: PushStack(player, ax);
            L0037: PushStack(player, ax);
            L0038: PushStack(player, 0xEF);
1112  003C C4 5E 06  les bx, [bp+0x6]
1115  003F 26 FF 9F D8 00  call far word [es:bx+0xd8]
111A  0044 83 C4 0C  add sp, 0xc
            L0047: Compare(PartyCount(player), 0x0001);
            L0052: if (JumpEqual) goto L005B;
            L0054: Compare(ax, 0x0002);
            L0057: if (JumpEqual) goto L0077;
            L0059: goto L0093;
            L005B: si = 0x0001;
            L005E: goto L0070;
            L0060: AddEncounter(player, si, 0x1E);
            L006F: si = si + 1;
            L0070: Compare(si, 0x02);
            L0073: if (JumpLessOrEqual) goto L0060;
            L0075: goto L00BA;
            L0077: si = 0x0001;
            L007A: goto L008C;
            L007C: AddEncounter(player, si, 0x1E);
            L008B: si = si + 1;
            L008C: Compare(si, 0x03);
            L008F: if (JumpLessOrEqual) goto L007C;
            L0091: goto L00BA;
1169  0093 FF 76 08  push word [bp+0x8]
116C  0096 FF 76 06  push word [bp+0x6]
116F  0099 0E     push cs
1170  009A E8 F8 0D  call 0xe95
            L009D: // NOP
            L009E: cx = PopStack(player);
            L009F: cx = PopStack(player);
            L00A0: si = 0x0001;
            L00A3: goto L00B5;
            L00A5: AddEncounter(player, si, 0x1E);
            L00B4: si = si + 1;
            L00B5: Compare(si, 0x04);
            L00B8: if (JumpLessOrEqual) goto L00A5;
            L00BA: AddEncounter(player, 0x06, 0x1A);
            L00CC: return; // RETURN (restoring si);
        }

        private void FnTORCHMES_27(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
11A8  0003 C4 5E 06  les bx, [bp+0x6]
11AB  0006 26 FF 5F 10  call far word [es:bx+0x10]
            L000A: Compare(ax, 0x0001);
            L000D: if (JumpEqual) goto L0011;
            L000F: goto L0020;
            L0011: ShowMessage(player, String09F6); // The flickering torches cast eerie shadows.
            L001E: goto L0034;
            L0020: ShowMessage(player, String0A21); // Jeweled torch-lamps are affixed to the walls here as switches. Each has three settings. You must know the pattern to set the correct sequence.
11D2  002D C4 5E 06  les bx, [bp+0x6]
11D5  0030 26 FF 5F 14  call far word [es:bx+0x14]
            L0034: return; // RETURN;
        }

        private void FnPHYSBATA_2A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: Compare(PartyCount(player), 0x0001);
            L000F: if (JumpEqual) goto L0018;
            L0011: Compare(ax, 0x0002);
            L0014: if (JumpEqual) goto L0034;
            L0016: goto L0050;
            L0018: si = 0x0001;
            L001B: goto L002D;
            L001D: AddEncounter(player, si, 0x1E);
            L002C: si = si + 1;
            L002D: Compare(si, 0x02);
            L0030: if (JumpLessOrEqual) goto L001D;
            L0032: goto L006A;
            L0034: si = 0x0001;
            L0037: goto L0049;
            L0039: AddEncounter(player, si, 0x1E);
            L0048: si = si + 1;
            L0049: Compare(si, 0x04);
            L004C: if (JumpLessOrEqual) goto L0039;
            L004E: goto L006A;
            L0050: si = 0x0001;
            L0053: goto L0065;
            L0055: AddEncounter(player, si, 0x1E);
            L0064: si = si + 1;
            L0065: Compare(si, 0x06);
            L0068: if (JumpLessOrEqual) goto L0055;
            L006A: return; // RETURN (restoring si);
        }

        private void FnPHYSBATB_2B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: Compare(PartyCount(player), 0x0001);
            L000F: if (JumpEqual) goto L0018;
            L0011: Compare(ax, 0x0002);
            L0014: if (JumpEqual) goto L0034;
            L0016: goto L0050;
            L0018: si = 0x0001;
            L001B: goto L002D;
            L001D: AddEncounter(player, si, 0x1C);
            L002C: si = si + 1;
            L002D: Compare(si, 0x02);
            L0030: if (JumpLessOrEqual) goto L001D;
            L0032: goto L006A;
            L0034: si = 0x0001;
            L0037: goto L0049;
            L0039: AddEncounter(player, si, 0x1C);
            L0048: si = si + 1;
            L0049: Compare(si, 0x04);
            L004C: if (JumpLessOrEqual) goto L0039;
            L004E: goto L006A;
            L0050: si = 0x0001;
            L0053: goto L0065;
            L0055: AddEncounter(player, si, 0x1C);
            L0064: si = si + 1;
            L0065: Compare(si, 0x06);
            L0068: if (JumpLessOrEqual) goto L0055;
            L006A: return; // RETURN (restoring si);
        }

        private void FnGUARDS_2C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: Compare(PartyCount(player), 0x0001);
            L000F: if (JumpEqual) goto L0018;
            L0011: Compare(ax, 0x0002);
            L0014: if (JumpEqual) goto L0034;
            L0016: goto L0050;
            L0018: si = 0x0001;
            L001B: goto L002D;
            L001D: AddEncounter(player, si, 0x1D);
            L002C: si = si + 1;
            L002D: Compare(si, 0x02);
            L0030: if (JumpLessOrEqual) goto L001D;
            L0032: goto L006A;
            L0034: si = 0x0001;
            L0037: goto L0049;
            L0039: AddEncounter(player, si, 0x1D);
            L0048: si = si + 1;
            L0049: Compare(si, 0x03);
            L004C: if (JumpLessOrEqual) goto L0039;
            L004E: goto L006A;
            L0050: si = 0x0001;
            L0053: goto L0065;
            L0055: AddEncounter(player, si, 0x1D);
            L0064: si = si + 1;
            L0065: Compare(si, 0x05);
            L0068: if (JumpLessOrEqual) goto L0055;
            L006A: return; // RETURN (restoring si);
        }

        private void FnLASTHALL_2D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0AB0); // To Corpeus.
            L0010: return; // RETURN;
        }

        private void FnTOSWITCH_2E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0ABC); // TO TORCH ROOM
            L0010: TeleportParty(player, 0x0B, 0x03, 0x18, 0x02, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnCASEPHYS_2F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
136E  0003 83 EC 06  sub sp, 0x6
1371  0006 56     push si
1372  0007 57     push di
            L0008: si = GetFlag(player, 0x02, 0x70);
            L001B: SetNoJoinArea(player);
            L0023: ax = GetCurrentTile(player);
1395  002A 89 46 FA  mov [bp-0x6], ax
1398  002D B9 04 00  mov cx, 0x4
            L0030: bx = 0x148D;
139E  0033 2E 8B 07  mov ax, [cs:bx]
13A1  0036 3B 46 FA  cmp ax, [bp-0x6]
            L0039: if (JumpEqual) goto L0041;
13A6  003B 43     inc bx
13A7  003C 43     inc bx
13A8  003D E2 F4  loop 0x33
            L003F: goto L0089;
13AC  0041 2E FF 67 08  jmp word [cs:bx+0x8]
            L0045: si = 0x0001;
            L0048: di = 0;
13B5  004A C7 46 FE 02 00  mov word [bp-0x2], 0x2
13BA  004F C7 46 FC 32 00  mov word [bp-0x4], 0x32
            L0054: goto L0089;
            L0056: si = 0x0002;
            L0059: di = 0x0002;
13C7  005C C7 46 FE 00 00  mov word [bp-0x2], 0x0
13CC  0061 C7 46 FC 4A 00  mov word [bp-0x4], 0x4a
            L0066: goto L0089;
            L0068: si = 0x0003;
            L006B: di = 0;
13D8  006D C7 46 FE 02 00  mov word [bp-0x2], 0x2
13DD  0072 C7 46 FC 7B 00  mov word [bp-0x4], 0x7b
            L0077: goto L0089;
            L0079: si = 0x0004;
            L007C: di = 0x0002;
13EA  007F C7 46 FE 02 00  mov word [bp-0x2], 0x2
13EF  0084 C7 46 FC 73 00  mov word [bp-0x4], 0x73
            L0089: Compare(GetFlag(player, 0x02, 0x70), si);
            L009C: if (JumpBelow) goto L00F9;
            L009E: ShowMessage(player, String0ACA); // A magical portal appears in the wall!
1416  00AB 57     push di
            L00AC: SetWallObject(player, 0x02, GetCurrentTile(player), PopStack(player));
            L00C2: Compare(PartyCount(player), 0x0001);
            L00CD: if (JumpNotEqual) goto L00EA;
143A  00CF FF 76 FE  push word [bp-0x2]
143D  00D2 FF 76 FC  push word [bp-0x4]
            L00D5: PushStack(player, 0x03);
            L00D9: PushStack(player, 0x0B);
1448  00DD C4 5E 06  les bx, [bp+0x6]
144B  00E0 26 FF 9F BC 00  call far word [es:bx+0xbc]
1450  00E5 83 C4 08  add sp, 0x8
            L00E8: goto L011C;
            L00EA: ShowMessage(player, String0AF0); // You must enter alone!
            L00F7: goto L011C;
1464  00F9 57     push di
            L00FA: SetWallObject(player, 0x00, GetCurrentTile(player), PopStack(player));
147A  010F FF 76 08  push word [bp+0x8]
147D  0112 FF 76 06  push word [bp+0x6]
1480  0115 0E     push cs
1481  0116 E8 D5 0A  call 0xbee
            L0119: // NOP
            L011A: cx = PopStack(player);
            L011B: cx = PopStack(player);
1487  011C 5F     pop di
1488  011D 5E     pop si
            L011E: // restore stack ptr: sp = bp;
            L0120: return; // RETURN;
            // Extra data: 71 00 81 00 91 00 A1 00 E4 13 D3 13 C1 13 B0 13 
        }

        private void FnPHYSFNT_31(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0042);
            L0010: RefreshCompareFlags(GetFlag(player, 0x02, 0xC1));
            L0023: if (JumpNotEqual) goto L0069;
            L0025: ShowMessage(player, String0B06); // The Fountain of Corpeus raises your physical prowess and enhances your agility!
            L0032: ModifyAttribute(player, 0x00, 0x0001);
            L0043: PushStack(player, 0x02);
            L0047: PushStack(player, ax);
14EA  0048 C4 5E 06  les bx, [bp+0x6]
14ED  004B 26 FF 9F A8 00  call far word [es:bx+0xa8]
            L0050: cx = PopStack(player);
            L0051: cx = PopStack(player);
            L0052: SetFlag(player, 0x02, 0xC1, 0x01);
            L0067: goto L0087;
            L0069: ShowMessage(player, String0B56); // The waters heal you.
            L0076: HealPlayer(player, GetMaxHits(player));
            L0087: return; // RETURN;
        }

        private void FnCASETTRP_32(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: si = GetFlag(player, 0x03, 0x02);
            L0017: PushStack(player, 0x01);
            L001B: PushStack(player, 0x00);
1549  001E C4 5E 06  les bx, [bp+0x6]
154C  0021 26 FF 5F 04  call far word [es:bx+0x4]
            L0025: cx = PopStack(player);
            L0026: cx = PopStack(player);
            L0027: RefreshCompareFlags(ax);
            L0029: if (JumpEqual) goto L002E;
            L002B: goto L0201;
            L002E: Compare(GetGuild(player), 0x0003);
            L0038: if (JumpEqual) goto L0046;
            L003A: Compare(GetGuild(player), 0x0002);
            L0044: if (JumpNotEqual) goto L004C;
1571  0046 B8 6B 0B  mov ax, 0xb6b
            L0049: goto L01D8;
            L004C: bx = si;
            L004E: bx = bx - 1;
            L004F: Compare(bx, 0x04);
            L0052: if (JumpBelowOrEqual) goto L0057;
            L0054: goto L01B0;
            L0057: switch (bx) {
                case 0:
                    goto L005E;
                case 1:
                    goto L00A0;
                case 2:
                    goto L00DC;
                case 3:
                    goto L0104;
                case 4:
                    goto L0155;
            }
            L005E: ax = GetCurrentHits(player);
            L0065: bx = 0x0006;
            L0068: dx = ax % bx; ax = ax / bx;
            L006B: DamagePlayer(player, ax);
15A0  0075 FF 76 08  push word [bp+0x8]
15A3  0078 FF 76 06  push word [bp+0x6]
15A6  007B 0E     push cs
15A7  007C E8 D4 09  call 0xa53
            L007F: // NOP
            L0080: cx = PopStack(player);
            L0081: cx = PopStack(player);
15AD  0082 FF 76 08  push word [bp+0x8]
15B0  0085 FF 76 06  push word [bp+0x6]
15B3  0088 0E     push cs
15B4  0089 E8 B4 09  call 0xa40
            L008C: // NOP
            L008D: cx = PopStack(player);
            L008E: cx = PopStack(player);
            L008F: ShowMessage(player, String0BA3); // The torch here explodes with fire!
            L009C: si = si + 1;
            L009D: goto L01E2;
            L00A0: DamagePlayer(player, GetCurrentHits(player) + 0xF830);
            L00B4: PushStack(player, 0x64);
            L00B8: PushStack(player, 0x0F);
            L00BC: PushStack(player, 0x01);
15EB  00C0 C4 5E 06  les bx, [bp+0x6]
15EE  00C3 26 FF 9F 9C 00  call far word [es:bx+0x9c]
15F3  00C8 83 C4 06  add sp, 0x6
15F6  00CB FF 76 08  push word [bp+0x8]
15F9  00CE FF 76 06  push word [bp+0x6]
15FC  00D1 0E     push cs
15FD  00D2 E8 97 08  call 0x96c
            L00D5: // NOP
            L00D6: cx = PopStack(player);
            L00D7: cx = PopStack(player);
            L00D8: si = si + 1;
            L00D9: goto L01E2;
            L00DC: ax = GetCurrentHits(player);
            L00E3: bx = 0x0002;
            L00E6: dx = ax % bx; ax = ax / bx;
            L00E9: DamagePlayer(player, ax);
161E  00F3 FF 76 08  push word [bp+0x8]
1621  00F6 FF 76 06  push word [bp+0x6]
1624  00F9 0E     push cs
1625  00FA E8 5D 08  call 0x95a
            L00FD: // NOP
            L00FE: cx = PopStack(player);
            L00FF: cx = PopStack(player);
            L0100: si = si + 1;
            L0101: goto L01E2;
            L0104: PushStack(player, 0x00);
            L0107: PushStack(player, 0x0A);
            L010B: PushStack(player, 0x02);
163A  010F C4 5E 06  les bx, [bp+0x6]
163D  0112 26 FF 9F 9C 00  call far word [es:bx+0x9c]
1642  0117 83 C4 06  add sp, 0x6
1645  011A B8 30 F8  mov ax, 0xf830
            L011D: PushStack(player, ax);
1649  011E C4 5E 06  les bx, [bp+0x6]
164C  0121 26 FF 9F B4 00  call far word [es:bx+0xb4]
            L0126: goto L0133;
            L0128: RemoveItem(player, 0xAB);
            L0134: ax = HasItem(player, 0xAB);
            L0142: if (JumpNotEqual) goto L0128;
            L0144: ShowMessage(player, String0BC6); // You clumsily set off a gas trap.
            L0151: si = si + 1;
            L0152: goto L01E2;
            L0155: ShowMessage(player, String0BE7); // A refreshing shower of magical waters is a nice change to these fiendish traps!
            L0162: AddMana(player, 0x00C8);
            L016F: ax = GetMaxHits(player);
            L0176: bx = 0x0004;
            L0179: dx = ax % bx; ax = ax / bx;
            L017C: HealPlayer(player, ax);
            L0186: PushStack(player, 0x01);
16B5  018A C4 5E 06  les bx, [bp+0x6]
16B8  018D 26 FF 9F A0 00  call far word [es:bx+0xa0]
            L0192: cx = PopStack(player);
            L0193: PushStack(player, 0x02);
16C2  0197 C4 5E 06  les bx, [bp+0x6]
16C5  019A 26 FF 9F A0 00  call far word [es:bx+0xa0]
            L019F: cx = PopStack(player);
            L01A0: PushStack(player, 0x04);
16CF  01A4 C4 5E 06  les bx, [bp+0x6]
16D2  01A7 26 FF 9F A0 00  call far word [es:bx+0xa0]
            L01AC: cx = PopStack(player);
            L01AD: si = si + 1;
            L01AE: goto L01E2;
16DB  01B0 FF 76 08  push word [bp+0x8]
16DE  01B3 FF 76 06  push word [bp+0x6]
16E1  01B6 0E     push cs
16E2  01B7 E8 58 08  call 0xa12
            L01BA: // NOP
            L01BB: cx = PopStack(player);
            L01BC: cx = PopStack(player);
            L01BD: SetNoHealZone(player);
            L01C5: si = 0x0001;
16F3  01C8 FF 76 08  push word [bp+0x8]
16F6  01CB FF 76 06  push word [bp+0x6]
16F9  01CE 0E     push cs
16FA  01CF E8 6E 08  call 0xa40
            L01D2: // NOP
            L01D3: cx = PopStack(player);
            L01D4: cx = PopStack(player);
            L01D5: ShowMessage(player, String0C37); // A mental blast of power is thrust upon you!
            L01E2: SetFlag(player, 0xC4, 0xB8, si);
171F  01F4 FF 76 08  push word [bp+0x8]
1722  01F7 FF 76 06  push word [bp+0x6]
1725  01FA 0E     push cs
1726  01FB E8 FE 07  call 0x9fc
            L01FE: // NOP
            L01FF: cx = PopStack(player);
            L0200: cx = PopStack(player);
            L0201: return; // RETURN (restoring si);
        }

        private void FnGRATOK_36(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: // make space for tmp on stack: sp -= 2
174D  0005 56     push si
174E  0006 57     push di
            L0007: ShowPortrait(player, 0x002D);
            L0014: ax = GetFlag(player, 0x02, 0x77);
176D  0025 8B F8  mov di, ax
            L0027: ax = GetCurrentTile(player);
1776  002E 89 46 FE  mov [bp-0x2], ax
1779  0031 B9 08 00  mov cx, 0x8
            L0034: bx = 0x18F0;
177F  0037 2E 8B 07  mov ax, [cs:bx]
1782  003A 3B 46 FE  cmp ax, [bp-0x2]
            L003D: if (JumpEqual) goto L0046;
1787  003F 43     inc bx
1788  0040 43     inc bx
1789  0041 E2 F4  loop 0x37
            L0043: goto L017D;
178E  0046 2E FF 67 10  jmp word [cs:bx+0x10]
            L004A: si = 0x0001;
1795  004D 3B FE  cmp di, si
            L004F: if (JumpLess) goto L0054;
            L0051: goto L017D;
            L0054: ShowMessage(player, String0C63); // 'Ahh, welcome to the Physical path. I am Gratok, allow me to guide you.
17A9  0061 B8 AB 0C  mov ax, 0xcab
            L0064: goto L0173;
            L0067: si = 0x0002;
17B2  006A 3B FE  cmp di, si
            L006C: if (JumpLess) goto L0071;
            L006E: goto L017D;
            L0071: ShowMessage(player, String0D0A); // 'We meet again. Now, northward, portals here will open when you have completed certain actions.
            L007E: ShowMessage(player, String0D6A); // Remember to search the walls!'
            L008B: RefreshCompareFlags(GetFlag(player, 0x02, 0x70));
            L009E: if (JumpEqual) goto L00A3;
            L00A0: goto L017D;
            L00A3: SetFlag(player, 0x02, 0x70, 0x01);
            L00B8: goto L017D;
            L00BB: si = 0x0003;
1806  00BE 3B FE  cmp di, si
            L00C0: if (JumpLess) goto L00C5;
            L00C2: goto L017D;
180D  00C5 B8 89 0D  mov ax, 0xd89
            L00C8: goto L0173;
            L00CB: si = 0x0004;
1816  00CE 3B FE  cmp di, si
            L00D0: if (JumpLessOrEqual) goto L00D5;
            L00D2: goto L017D;
            L00D5: ShowMessage(player, String0E0E); // 'Well done. You must find the room where torches are switches. Set them as I say, then return to the starting hallway.
182A  00E2 B8 85 0E  mov ax, 0xe85
            L00E5: goto L0173;
            L00E8: si = 0x0005;
1833  00EB 3B FE  cmp di, si
            L00ED: if (JumpLessOrEqual) goto L00F2;
            L00EF: goto L017D;
183A  00F2 B8 A3 0E  mov ax, 0xea3
            L00F5: goto L0173;
            L00F7: // NOP
            L00F8: Compare(GetFlag(player, 0x02, 0x75), 0x0001);
            L010C: if (JumpEqual) goto L0124;
            L010E: Compare(GetFlag(player, 0x02, 0x75), 0x0002);
            L0122: if (JumpNotEqual) goto L017D;
            L0124: ShowMessage(player, String0F24); // 'WELL DONE! Off you go to the next phase. Water leads to magic sands.'
            L0131: PushStack(player, 0x02);
187D  0135 B8 75 00  mov ax, 0x75
            L0138: goto L00AA;
1883  013B 8B F7  mov si, di
            L013D: RefreshCompareFlags(GetFlag(player, 0x02, 0x75));
            L0150: if (JumpNotEqual) goto L0157;
189A  0152 B8 6B 0F  mov ax, 0xf6b
            L0155: goto L0173;
189F  0157 B8 B7 0F  mov ax, 0xfb7
            L015A: goto L0173;
            L015C: si = 0x0008;
18A7  015F 3B FE  cmp di, si
            L0161: if (JumpGreater) goto L017D;
            L0163: ShowMessage(player, String0FDF); // 'Onward! You've earned the next series by conquering the Hall.
            L0170: ShowMessage(player, String101E); // Magic lava leads to death.'
18C5  017D 3B FE  cmp di, si
18C7  017F 7D 14  jge 0x195
            L0181: SetFlag(player, 0xC4, 0xB8, si);
            L0193: goto L0195;
18DD  0195 FF 76 08  push word [bp+0x8]
18E0  0198 FF 76 06  push word [bp+0x6]
18E3  019B 0E     push cs
18E4  019C E8 29 00  call 0x1c8
            L019F: // NOP
            L01A0: cx = PopStack(player);
            L01A1: cx = PopStack(player);
18EA  01A2 5F     pop di
18EB  01A3 5E     pop si
            L01A4: // restore stack ptr: sp = bp;
            L01A6: return; // RETURN;
            // Extra data: 0B 00 1A 00 37 00 57 00 62 00 76 00 B1 00 E0 00 40 18 83 18 03 18 13 18 92 17 30 18 AF 17 A4 18 55 8B EC B8 3A 10 50 C4 5E 06 26 FF 9F F8 00 59 5D CB 
        }

        private void FnDAMGPOOL_37(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
1925  0003 FF 76 08  push word [bp+0x8]
1928  0006 FF 76 06  push word [bp+0x6]
192B  0009 0E     push cs
192C  000A E8 0E 06  call 0x61b
            L000D: // NOP
            L000E: cx = PopStack(player);
            L000F: cx = PopStack(player);
1932  0010 FF 76 08  push word [bp+0x8]
1935  0013 FF 76 06  push word [bp+0x6]
1938  0016 0E     push cs
1939  0017 E8 2F 06  call 0x649
            L001A: // NOP
            L001B: cx = PopStack(player);
            L001C: cx = PopStack(player);
            L001D: ShowMessage(player, String1066); // The magical fluids drain you.
            L002A: return; // RETURN;
        }

        private void FnWATRFITA_38(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: ShowMessage(player, String1084); // Medusas guard this gateway!
            L0011: Compare(PartyCount(player), 0x0001);
            L001C: if (JumpEqual) goto L0025;
            L001E: Compare(ax, 0x0002);
            L0021: if (JumpEqual) goto L0041;
            L0023: goto L005D;
            L0025: si = 0x0001;
            L0028: goto L003A;
            L002A: AddEncounter(player, si, 0x1B);
            L0039: si = si + 1;
            L003A: Compare(si, 0x02);
            L003D: if (JumpLessOrEqual) goto L002A;
            L003F: goto L0077;
            L0041: si = 0x0001;
            L0044: goto L0056;
            L0046: AddEncounter(player, si, 0x1B);
            L0055: si = si + 1;
            L0056: Compare(si, 0x03);
            L0059: if (JumpLessOrEqual) goto L0046;
            L005B: goto L0077;
            L005D: si = 0x0001;
            L0060: goto L0072;
            L0062: AddEncounter(player, si, 0x1B);
            L0071: si = si + 1;
            L0072: Compare(si, 0x05);
            L0075: if (JumpLessOrEqual) goto L0062;
            L0077: return; // RETURN (restoring si);
        }

        private void FnWATRFITB_39(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: Compare(PartyCount(player), 0x0001);
            L000F: if (JumpEqual) goto L0018;
            L0011: Compare(ax, 0x0002);
            L0014: if (JumpEqual) goto L0018;
            L0016: goto L0034;
            L0018: si = 0x0001;
            L001B: goto L002D;
            L001D: AddEncounter(player, si, 0x13);
            L002C: si = si + 1;
            L002D: Compare(si, 0x02);
            L0030: if (JumpLessOrEqual) goto L001D;
            L0032: goto L004E;
            L0034: si = 0x0001;
            L0037: goto L0049;
            L0039: AddEncounter(player, si, 0x13);
            L0048: si = si + 1;
            L0049: Compare(si, 0x05);
            L004C: if (JumpLessOrEqual) goto L0039;
            L004E: return; // RETURN (restoring si);
        }

        private void FnNOZONE_3A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: ShowMessage(player, String10A0); // This hallway is laden with traps. You are powerless and confused.
1A2A  0011 FF 76 08  push word [bp+0x8]
1A2D  0014 FF 76 06  push word [bp+0x6]
1A30  0017 0E     push cs
1A31  0018 E8 4A 05  call 0x565
            L001B: // NOP
            L001C: cx = PopStack(player);
            L001D: cx = PopStack(player);
1A37  001E FF 76 08  push word [bp+0x8]
1A3A  0021 FF 76 06  push word [bp+0x6]
1A3D  0024 0E     push cs
1A3E  0025 E8 2A 05  call 0x552
            L0028: // NOP
            L0029: cx = PopStack(player);
            L002A: cx = PopStack(player);
            L002B: si = GetFlag(player, 0x03, 0x01);
1A57  003E FF 76 08  push word [bp+0x8]
1A5A  0041 FF 76 06  push word [bp+0x6]
1A5D  0044 0E     push cs
1A5E  0045 E8 48 04  call 0x490
            L0048: // NOP
            L0049: cx = PopStack(player);
            L004A: cx = PopStack(player);
            L004B: PushStack(player, 0x01);
            L004F: PushStack(player, 0x00);
1A6B  0052 C4 5E 06  les bx, [bp+0x6]
1A6E  0055 26 FF 5F 04  call far word [es:bx+0x4]
            L0059: cx = PopStack(player);
            L005A: cx = PopStack(player);
            L005B: RefreshCompareFlags(ax);
            L005D: if (JumpEqual) goto L0062;
            L005F: goto L0156;
            L0062: Compare(GetGuild(player), 0x0003);
            L006C: if (JumpNotEqual) goto L007E;
            L006E: ShowMessage(player, String10E2); // You manage to avoid the trap!
            L007B: goto L0137;
1A97  007E 8B C6  mov ax, si
            L0080: Compare(ax, 0x0001);
            L0083: if (JumpEqual) goto L008C;
            L0085: Compare(ax, 0x0002);
            L0088: if (JumpEqual) goto L00C7;
            L008A: goto L00E4;
            L008C: ax = GetCurrentHits(player);
            L0093: bx = 0x0006;
            L0096: dx = ax % bx; ax = ax / bx;
            L0099: DamagePlayer(player, ax);
            L00A3: PushStack(player, 0x64);
            L00A7: PushStack(player, 0x05);
            L00AB: PushStack(player, 0x01);
1AC8  00AF C4 5E 06  les bx, [bp+0x6]
1ACB  00B2 26 FF 9F 9C 00  call far word [es:bx+0x9c]
1AD0  00B7 83 C4 06  add sp, 0x6
1AD3  00BA FF 76 08  push word [bp+0x8]
1AD6  00BD FF 76 06  push word [bp+0x6]
1AD9  00C0 0E     push cs
1ADA  00C1 E8 BA 03  call 0x47e
            L00C4: // NOP
            L00C5: goto L00DF;
            L00C7: DamagePlayer(player, 0x015E);
1AED  00D4 FF 76 08  push word [bp+0x8]
1AF0  00D7 FF 76 06  push word [bp+0x6]
1AF3  00DA 0E     push cs
1AF4  00DB E8 8E 03  call 0x46c
            L00DE: // NOP
            L00DF: cx = PopStack(player);
            L00E0: cx = PopStack(player);
            L00E1: si = si + 1;
            L00E2: goto L0137;
            L00E4: ax = GetCurrentHits(player);
            L00EB: bx = 0x0008;
            L00EE: dx = ax % bx; ax = ax / bx;
            L00F1: DamagePlayer(player, ax);
            L00FB: AddMana(player, 0xFF6A);
            L0108: si = 0x0001;
            L010B: ShowMessage(player, String1100); // A whirlwind of magic rushes through the hallway draining and dragging you!
            L0118: TeleportParty(player, 0x0B, 0x03, GetCurrentTile(player), 0x02, isForwardMove);
            L0137: SetFlag(player, 0xC4, 0xB8, si);
1B62  0149 FF 76 08  push word [bp+0x8]
1B65  014C FF 76 06  push word [bp+0x6]
1B68  014F 0E     push cs
1B69  0150 E8 BB 03  call 0x50e
            L0153: // NOP
            L0154: cx = PopStack(player);
            L0155: cx = PopStack(player);
            L0156: return; // RETURN (restoring si);
        }

        private void FnNOMAPS_3B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
1B75  0003 FF 76 08  push word [bp+0x8]
1B78  0006 FF 76 06  push word [bp+0x6]
1B7B  0009 0E     push cs
1B7C  000A E8 2A 03  call 0x337
            L000D: // NOP
            L000E: cx = PopStack(player);
            L000F: cx = PopStack(player);
1B82  0010 FF 76 08  push word [bp+0x8]
1B85  0013 FF 76 06  push word [bp+0x6]
1B88  0016 0E     push cs
1B89  0017 E8 F2 03  call 0x40c
            L001A: // NOP
            L001B: cx = PopStack(player);
            L001C: cx = PopStack(player);
            L001D: PushStack(player, 0x01);
            L0021: PushStack(player, 0x00);
1B96  0024 C4 5E 06  les bx, [bp+0x6]
1B99  0027 26 FF 5F 04  call far word [es:bx+0x4]
            L002B: cx = PopStack(player);
            L002C: cx = PopStack(player);
            L002D: RefreshCompareFlags(ax);
            L002F: if (JumpEqual) goto L0034;
            L0031: goto L011F;
            L0034: bx = GetFacing(player);
            L003D: Compare(bx, 0x03);
            L0040: if (JumpAbove) goto L00BC;
            L0042: switch (bx) {
                case 0:
                    goto L0081;
                case 1:
                    goto L0058;
                case 2:
                    goto L009D;
                case 3:
                    goto L0049;
            }
            L0049: PushStack(player, 0x02);
1BBF  004D C4 5E 06  les bx, [bp+0x6]
1BC2  0050 26 FF 9F CC 00  call far word [es:bx+0xcc]
            L0055: cx = PopStack(player);
            L0056: goto L00BC;
            L0058: PushStack(player, 0x02);
1BCE  005C C4 5E 06  les bx, [bp+0x6]
1BD1  005F 26 FF 9F CC 00  call far word [es:bx+0xcc]
            L0064: cx = PopStack(player);
            L0065: PushStack(player, 0x01);
1BDB  0069 C4 5E 06  les bx, [bp+0x6]
1BDE  006C 26 FF 9F CC 00  call far word [es:bx+0xcc]
            L0071: cx = PopStack(player);
            L0072: PushStack(player, 0x03);
1BE8  0076 C4 5E 06  les bx, [bp+0x6]
1BEB  0079 26 FF 9F CC 00  call far word [es:bx+0xcc]
            L007E: cx = PopStack(player);
            L007F: goto L009D;
            L0081: PushStack(player, 0x03);
1BF7  0085 C4 5E 06  les bx, [bp+0x6]
1BFA  0088 26 FF 9F CC 00  call far word [es:bx+0xcc]
            L008D: cx = PopStack(player);
            L008E: PushStack(player, 0x01);
1C04  0092 C4 5E 06  les bx, [bp+0x6]
1C07  0095 26 FF 9F CC 00  call far word [es:bx+0xcc]
            L009A: cx = PopStack(player);
            L009B: goto L0049;
            L009D: TeleportParty(player, 0x0B, 0x03, GetCurrentTile(player), 0x03, isForwardMove);
1C2E  00BC FF 76 08  push word [bp+0x8]
1C31  00BF FF 76 06  push word [bp+0x6]
1C34  00C2 0E     push cs
1C35  00C3 E8 EF 02  call 0x3b5
            L00C6: // NOP
            L00C7: cx = PopStack(player);
            L00C8: cx = PopStack(player);
            L00C9: Compare(GetCurrentTile(player), 0x00B3);
            L00D3: if (JumpNotEqual) goto L011F;
            L00D5: RefreshCompareFlags(GetFlag(player, 0x03, 0x19));
            L00E8: if (JumpNotEqual) goto L011F;
1C5C  00EA FF 76 08  push word [bp+0x8]
1C5F  00ED FF 76 06  push word [bp+0x6]
1C62  00F0 0E     push cs
1C63  00F1 E8 9D 02  call 0x391
            L00F4: // NOP
            L00F5: cx = PopStack(player);
            L00F6: cx = PopStack(player);
            L00F7: ShowMessage(player, String114B); // Back to the beginning! You must try again.
            L0104: TeleportParty(player, 0x0B, 0x03, 0x7B, 0x02, isForwardMove);
            L011F: return; // RETURN;
        }

        private void FnHALLTEXT_3C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
1C9E  0003 FF 76 08  push word [bp+0x8]
1CA1  0006 FF 76 06  push word [bp+0x6]
1CA4  0009 0E     push cs
1CA5  000A E8 D6 02  call 0x2e3
            L000D: // NOP
            L000E: cx = PopStack(player);
            L000F: cx = PopStack(player);
            L0010: ShowMessage(player, String1176); // This hallway is of lethal cunning. Only the most ingenious and powerful heroes will survive.
            L001D: RefreshCompareFlags(GetFlag(player, 0x03, 0x19));
            L0030: if (JumpNotEqual) goto L007B;
            L0032: SetFlag(player, 0x03, 0x19, 0x01);
            L0047: ShowPortrait(player, 0x002D);
            L0054: ShowMessage(player, String11D3); // 'I can not help you here. I offer you this warning:'
1CFC  0061 FF 76 08  push word [bp+0x8]
1CFF  0064 FF 76 06  push word [bp+0x6]
1D02  0067 0E     push cs
1D03  0068 E8 FD 01  call 0x268
            L006B: // NOP
            L006C: cx = PopStack(player);
            L006D: cx = PopStack(player);
            L006E: ShowMessage(player, String1208); // 'Farewell!'
            L007B: return; // RETURN;
        }

        private void FnBLOCKWAL_3D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0020: ShowMessage(player, String1214); // An unseen force holds you back!
            L002D: return; // RETURN;
        }

        private void FnNOASMAP_3E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
1D4A  0003 83 EC 06  sub sp, 0x6
1D4D  0006 56     push si
1D4E  0007 57     push di
            L0008: ax = GetFlag(player, 0x03, 0x1B);
1D60  0019 89 46 FE  mov [bp-0x2], ax
            L001C: ax = GetFlag(player, 0x02, 0x74);
1D74  002D 8B F8  mov di, ax
1D76  002F FF 76 08  push word [bp+0x8]
1D79  0032 FF 76 06  push word [bp+0x6]
1D7C  0035 0E     push cs
1D7D  0036 E8 FE 01  call 0x237
            L0039: // NOP
            L003A: cx = PopStack(player);
            L003B: cx = PopStack(player);
1D83  003C C4 5E 06  les bx, [bp+0x6]
1D86  003F 26 FF 9F B8 00  call far word [es:bx+0xb8]
            L0044: RefreshCompareFlags(ax);
            L0046: if (JumpNotEqual) goto L004B;
            L0048: goto L0110;
1D92  004B 83 FF 01  cmp di, 0x1
            L004E: if (JumpLessOrEqual) goto L0060;
            L0050: ax = HasItem(player, 0xEE);
            L005E: if (JumpNotEqual) goto L0095;
            L0060: ax = GetCurrentTile(player);
1DAE  0067 89 46 FC  mov [bp-0x4], ax
1DB1  006A B9 05 00  mov cx, 0x5
            L006D: bx = 0x1E71;
1DB7  0070 2E 8B 07  mov ax, [cs:bx]
1DBA  0073 3B 46 FC  cmp ax, [bp-0x4]
            L0076: if (JumpEqual) goto L007E;
1DBF  0078 43     inc bx
1DC0  0079 43     inc bx
1DC1  007A E2 F4  loop 0x70
            L007C: goto L00D1;
1DC5  007E 2E FF 67 0A  jmp word [cs:bx+0xa]
            L0082: si = 0x00EC;
            L0085: goto L00D1;
            L0087: goto L00CE;
            L0089: si = 0x00E8;
            L008C: goto L00D1;
            L008E: si = 0x00D9;
            L0091: goto L00D1;
            L0093: goto L00C0;
1DDC  0095 83 FF 02  cmp di, 0x2
            L0098: if (JumpLess) goto L00D1;
            L009A: ax = GetCurrentTile(player);
1DE8  00A1 89 46 FA  mov [bp-0x6], ax
1DEB  00A4 B9 05 00  mov cx, 0x5
            L00A7: bx = 0x1E5D;
1DF1  00AA 2E 8B 07  mov ax, [cs:bx]
1DF4  00AD 3B 46 FA  cmp ax, [bp-0x6]
            L00B0: if (JumpEqual) goto L00B8;
1DF9  00B2 43     inc bx
1DFA  00B3 43     inc bx
1DFB  00B4 E2 F4  loop 0xaa
            L00B6: goto L00D1;
1DFF  00B8 2E FF 67 0A  jmp word [cs:bx+0xa]
            L00BC: goto L0082;
            L00BE: goto L0082;
            L00C0: si = 0x0099;
            L00C3: goto L00D1;
            L00C5: si = 0;
            L00C7: goto L00D1;
            L00C9: si = 0x009D;
            L00CC: goto L00D1;
            L00CE: si = 0x00E4;
1E18  00D1 81 7E FE FF 00  cmp word [bp-0x2], 0xff
            L00D6: if (JumpEqual) goto L00DD;
1E1F  00D8 39 76 FE  cmp [bp-0x2], si
            L00DB: if (JumpEqual) goto L00E2;
1E24  00DD B8 FF 00  mov ax, 0xff
            L00E0: goto L00FE;
            L00E2: Compare(GetFlag(player, 0x03, 0x1B), si);
            L00F5: if (JumpNotEqual) goto L0110;
            L00F7: PushStack(player, GetCurrentTile(player));
            L00FF: PushStack(player, 0x1B);
            L0103: PushStack(player, 0x03);
1E4E  0107 C4 5E 06  les bx, [bp+0x6]
1E51  010A 26 FF 1F  call far word [es:bx]
1E54  010D 83 C4 06  add sp, 0x6
1E57  0110 5F     pop di
1E58  0111 5E     pop si
            L0112: // restore stack ptr: sp = bp;
            L0114: return; // RETURN;
            // Extra data: 99 00 9D 00 D9 00 E4 00 E8 00 10 1E 15 1E 0C 1E 05 1E 07 1E 99 00 9D 00 D9 00 E4 00 E8 00 D5 1D DA 1D D0 1D C9 1D CE 1D 55 8B EC B8 34 12 50 C4 5E 06 26 FF 9F F8 00 59 5D CB 55 8B EC B8 86 12 50 C4 5E 06 26 FF 9F F8 00 59 5D CB 55 8B EC C4 5E 06 26 FF 5F 7C 3D 02 00 74 10 B8 F7 00 50 C4 5E 06 26 FF 5F 50 59 0B C0 74 31 C4 5E 06 26 FF 5F 24 8B D8 83 FB 03 77 23 D1 E3 2E FF A7 FB 1E B8 AF 12 EB 0D B8 B5 12 EB 08 B8 BA 12 EB 03 B8 BF 12 50 C4 5E 06 26 FF 9F F8 00 59 5D CB E2 1E EC 1E E7 1E DD 1E 55 8B EC B8 C5 12 50 C4 5E 06 26 FF 9F F8 00 59 5D CB 55 8B EC B8 0B 13 50 C4 5E 06 26 FF 9F F8 00 59 5D CB 55 8B EC B8 01 00 50 50 33 C0 50 C4 5E 06 26 FF 1F 83 C4 06 5D CB 55 8B EC C4 5E 06 26 FF 5F 74 BB 06 00 99 F7 FB 50 C4 5E 06 26 FF 9F 90 00 59 5D CB 55 8B EC B8 14 13 50 C4 5E 06 26 FF 9F F8 00 59 5D CB 55 8B EC C4 5E 06 26 FF 5F 40 C4 5E 06 26 FF 5F 3C 5D CB 55 8B EC C4 5E 06 26 FF 9F E8 00 5D CB 
        }

        private void FnSETFLAG_3F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFlag(player, 0x02, 0x7E, 0x01);
            L0018: return; // RETURN;
        }

        private void FnWORDONE_40(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: // make space for tmp on stack: sp -= 2
1FAA  0005 56     push si
1FAB  0006 57     push di
            L0007: si = GetFlag(player, 0x03, 0x13);
            L001A: Compare(ax, 0x0001);
            L001D: if (JumpEqual) goto L0026;
            L001F: Compare(ax, 0x0002);
            L0022: if (JumpEqual) goto L0040;
            L0024: goto L0059;
            L0026: ShowMessage(player, String132B); // DEATH
            L0033: di = 0x0003;
1FDB  0036 C7 46 FE 00 00  mov word [bp-0x2], 0x0
            L003B: si = 0x0002;
            L003E: goto L006F;
            L0040: ShowMessage(player, String1331); // WATER
            L004D: di = 0;
1FF4  004F C7 46 FE 06 00  mov word [bp-0x2], 0x6
            L0054: si = 0x0003;
            L0057: goto L006F;
1FFE  0059 FF 76 08  push word [bp+0x8]
2001  005C FF 76 06  push word [bp+0x6]
2004  005F 0E     push cs
2005  0060 E8 0D FF  call 0xff70
            L0063: cx = PopStack(player);
            L0064: cx = PopStack(player);
            L0065: di = 0;
200C  0067 C7 46 FE 00 00  mov word [bp-0x2], 0x0
            L006C: si = 0x0001;
2014  006F 57     push di
            L0070: PushStack(player, 0x07);
            L0074: PushStack(player, 0x03);
201D  0078 C4 5E 06  les bx, [bp+0x6]
2020  007B 26 FF 1F  call far word [es:bx]
2023  007E 83 C4 06  add sp, 0x6
2026  0081 FF 76 FE  push word [bp-0x2]
            L0084: PushStack(player, 0x08);
            L0088: PushStack(player, 0x03);
2031  008C C4 5E 06  les bx, [bp+0x6]
2034  008F 26 FF 1F  call far word [es:bx]
2037  0092 83 C4 06  add sp, 0x6
            L0095: SetFlag(player, 0xC4, 0xB8, si);
204C  00A7 5F     pop di
204D  00A8 5E     pop si
            L00A9: // restore stack ptr: sp = bp;
            L00AB: return; // RETURN;
        }

        private void FnWORDTWO_41(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: // make space for tmp on stack: sp -= 2
2057  0005 56     push si
2058  0006 57     push di
            L0007: si = GetFlag(player, 0x03, 0x14);
            L001A: Compare(ax, 0x0001);
            L001D: if (JumpEqual) goto L0026;
            L001F: Compare(ax, 0x0002);
            L0022: if (JumpEqual) goto L0040;
            L0024: goto L0059;
            L0026: ShowMessage(player, String1337); // LIFE
            L0033: di = 0x0005;
2088  0036 C7 46 FE 00 00  mov word [bp-0x2], 0x0
            L003B: si = 0x0002;
            L003E: goto L006F;
            L0040: ShowMessage(player, String133C); // SANDS
            L004D: di = 0;
20A1  004F C7 46 FE 0A 00  mov word [bp-0x2], 0xa
            L0054: si = 0x0003;
            L0057: goto L006F;
20AB  0059 FF 76 08  push word [bp+0x8]
20AE  005C FF 76 06  push word [bp+0x6]
20B1  005F 0E     push cs
20B2  0060 E8 60 FE  call 0xfec3
            L0063: cx = PopStack(player);
            L0064: cx = PopStack(player);
            L0065: di = 0;
20B9  0067 C7 46 FE 00 00  mov word [bp-0x2], 0x0
            L006C: si = 0x0001;
20C1  006F 57     push di
            L0070: PushStack(player, 0x09);
            L0074: PushStack(player, 0x03);
20CA  0078 C4 5E 06  les bx, [bp+0x6]
20CD  007B 26 FF 1F  call far word [es:bx]
20D0  007E 83 C4 06  add sp, 0x6
20D3  0081 FF 76 FE  push word [bp-0x2]
            L0084: PushStack(player, 0x0A);
            L0088: PushStack(player, 0x03);
20DE  008C C4 5E 06  les bx, [bp+0x6]
20E1  008F 26 FF 1F  call far word [es:bx]
20E4  0092 83 C4 06  add sp, 0x6
            L0095: SetFlag(player, 0xC4, 0xB8, si);
20F9  00A7 5F     pop di
20FA  00A8 5E     pop si
            L00A9: // restore stack ptr: sp = bp;
            L00AB: return; // RETURN;
        }

        private void FnWORTHREE_42(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: // make space for tmp on stack: sp -= 2
2104  0005 56     push si
2105  0006 57     push di
            L0007: si = GetFlag(player, 0x03, 0x15);
            L001A: Compare(ax, 0x0001);
            L001D: if (JumpEqual) goto L0026;
            L001F: Compare(ax, 0x0002);
            L0022: if (JumpEqual) goto L0040;
            L0024: goto L0059;
            L0026: ShowMessage(player, String1342); // TO
            L0033: di = 0x0008;
2135  0036 C7 46 FE 00 00  mov word [bp-0x2], 0x0
            L003B: si = 0x0002;
            L003E: goto L006F;
            L0040: ShowMessage(player, String1345); // FOLLOWS
            L004D: di = 0;
214E  004F C7 46 FE 02 00  mov word [bp-0x2], 0x2
            L0054: si = 0x0003;
            L0057: goto L006F;
2158  0059 FF 76 08  push word [bp+0x8]
215B  005C FF 76 06  push word [bp+0x6]
215E  005F 0E     push cs
215F  0060 E8 B3 FD  call 0xfe16
            L0063: cx = PopStack(player);
            L0064: cx = PopStack(player);
            L0065: di = 0;
2166  0067 C7 46 FE 00 00  mov word [bp-0x2], 0x0
            L006C: si = 0x0001;
216E  006F 57     push di
            L0070: PushStack(player, 0x0B);
            L0074: PushStack(player, 0x03);
2177  0078 C4 5E 06  les bx, [bp+0x6]
217A  007B 26 FF 1F  call far word [es:bx]
217D  007E 83 C4 06  add sp, 0x6
2180  0081 FF 76 FE  push word [bp-0x2]
            L0084: PushStack(player, 0x0C);
            L0088: PushStack(player, 0x03);
218B  008C C4 5E 06  les bx, [bp+0x6]
218E  008F 26 FF 1F  call far word [es:bx]
2191  0092 83 C4 06  add sp, 0x6
            L0095: SetFlag(player, 0xC4, 0xB8, si);
21A6  00A7 5F     pop di
21A7  00A8 5E     pop si
            L00A9: // restore stack ptr: sp = bp;
            L00AB: return; // RETURN;
        }

        private void FnWRDFOUR_43(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: // make space for tmp on stack: sp -= 2
21B1  0005 56     push si
21B2  0006 57     push di
            L0007: si = GetFlag(player, 0x03, 0x16);
            L001A: Compare(ax, 0x0001);
            L001D: if (JumpEqual) goto L0026;
            L001F: Compare(ax, 0x0002);
            L0022: if (JumpEqual) goto L0040;
            L0024: goto L0059;
            L0026: ShowMessage(player, String134D); // TIME
            L0033: di = 0x0001;
21E2  0036 C7 46 FE 00 00  mov word [bp-0x2], 0x0
            L003B: si = 0x0002;
            L003E: goto L006F;
            L0040: ShowMessage(player, String1352); // MAGIC
            L004D: di = 0;
21FB  004F C7 46 FE 09 00  mov word [bp-0x2], 0x9
            L0054: si = 0x0003;
            L0057: goto L006F;
2205  0059 FF 76 08  push word [bp+0x8]
2208  005C FF 76 06  push word [bp+0x6]
220B  005F 0E     push cs
220C  0060 E8 06 FD  call 0xfd69
            L0063: cx = PopStack(player);
            L0064: cx = PopStack(player);
            L0065: di = 0;
2213  0067 C7 46 FE 00 00  mov word [bp-0x2], 0x0
            L006C: si = 0x0001;
221B  006F 57     push di
            L0070: PushStack(player, 0x0D);
            L0074: PushStack(player, 0x03);
2224  0078 C4 5E 06  les bx, [bp+0x6]
2227  007B 26 FF 1F  call far word [es:bx]
222A  007E 83 C4 06  add sp, 0x6
222D  0081 FF 76 FE  push word [bp-0x2]
            L0084: PushStack(player, 0x0E);
            L0088: PushStack(player, 0x03);
2238  008C C4 5E 06  les bx, [bp+0x6]
223B  008F 26 FF 1F  call far word [es:bx]
223E  0092 83 C4 06  add sp, 0x6
            L0095: SetFlag(player, 0xC4, 0xB8, si);
2253  00A7 5F     pop di
2254  00A8 5E     pop si
            L00A9: // restore stack ptr: sp = bp;
            L00AB: return; // RETURN;
        }

        private void FnWRDFIVE_44(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: // make space for tmp on stack: sp -= 2
225E  0005 56     push si
225F  0006 57     push di
            L0007: si = GetFlag(player, 0x03, 0x17);
            L001A: Compare(ax, 0x0001);
            L001D: if (JumpEqual) goto L0026;
            L001F: Compare(ax, 0x0002);
            L0022: if (JumpEqual) goto L0040;
            L0024: goto L0059;
            L0026: ShowMessage(player, String1358); // LAVA
            L0033: di = 0x000B;
228F  0036 C7 46 FE 00 00  mov word [bp-0x2], 0x0
            L003B: si = 0x0002;
            L003E: goto L006F;
            L0040: ShowMessage(player, String135D); // FROM
            L004D: di = 0;
22A8  004F C7 46 FE 04 00  mov word [bp-0x2], 0x4
            L0054: si = 0x0003;
            L0057: goto L006F;
22B2  0059 FF 76 08  push word [bp+0x8]
22B5  005C FF 76 06  push word [bp+0x6]
22B8  005F 0E     push cs
22B9  0060 E8 59 FC  call 0xfcbc
            L0063: cx = PopStack(player);
            L0064: cx = PopStack(player);
            L0065: di = 0;
22C0  0067 C7 46 FE 00 00  mov word [bp-0x2], 0x0
            L006C: si = 0x0001;
22C8  006F 57     push di
            L0070: PushStack(player, 0x0F);
            L0074: PushStack(player, 0x03);
22D1  0078 C4 5E 06  les bx, [bp+0x6]
22D4  007B 26 FF 1F  call far word [es:bx]
22D7  007E 83 C4 06  add sp, 0x6
22DA  0081 FF 76 FE  push word [bp-0x2]
            L0084: PushStack(player, 0x10);
            L0088: PushStack(player, 0x03);
22E5  008C C4 5E 06  les bx, [bp+0x6]
22E8  008F 26 FF 1F  call far word [es:bx]
22EB  0092 83 C4 06  add sp, 0x6
            L0095: SetFlag(player, 0xC4, 0xB8, si);
2300  00A7 5F     pop di
2301  00A8 5E     pop si
            L00A9: // restore stack ptr: sp = bp;
            L00AB: return; // RETURN;
        }

        private void FnWRDSIX_45(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: // make space for tmp on stack: sp -= 2
230B  0005 56     push si
230C  0006 57     push di
            L0007: si = GetFlag(player, 0x03, 0x18);
            L001A: Compare(ax, 0x0001);
            L001D: if (JumpEqual) goto L0026;
            L001F: Compare(ax, 0x0002);
            L0022: if (JumpEqual) goto L0040;
            L0024: goto L0059;
            L0026: ShowMessage(player, String1362); // OF
            L0033: di = 0x000C;
233C  0036 C7 46 FE 00 00  mov word [bp-0x2], 0x0
            L003B: si = 0x0002;
            L003E: goto L006F;
            L0040: ShowMessage(player, String1365); // LEADS
            L004D: di = 0;
2355  004F C7 46 FE 07 00  mov word [bp-0x2], 0x7
            L0054: si = 0x0003;
            L0057: goto L006F;
235F  0059 FF 76 08  push word [bp+0x8]
2362  005C FF 76 06  push word [bp+0x6]
2365  005F 0E     push cs
2366  0060 E8 AC FB  call 0xfc0f
            L0063: cx = PopStack(player);
            L0064: cx = PopStack(player);
            L0065: di = 0;
236D  0067 C7 46 FE 00 00  mov word [bp-0x2], 0x0
            L006C: si = 0x0001;
2375  006F 57     push di
            L0070: PushStack(player, 0x11);
            L0074: PushStack(player, 0x03);
237E  0078 C4 5E 06  les bx, [bp+0x6]
2381  007B 26 FF 1F  call far word [es:bx]
2384  007E 83 C4 06  add sp, 0x6
2387  0081 FF 76 FE  push word [bp-0x2]
            L0084: PushStack(player, 0x12);
            L0088: PushStack(player, 0x03);
2392  008C C4 5E 06  les bx, [bp+0x6]
2395  008F 26 FF 1F  call far word [es:bx]
2398  0092 83 C4 06  add sp, 0x6
            L0095: SetFlag(player, 0xC4, 0xB8, si);
23AD  00A7 5F     pop di
23AE  00A8 5E     pop si
            L00A9: // restore stack ptr: sp = bp;
            L00AB: return; // RETURN;
        }

        private void FnPORTBACK_46(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: // make space for tmp on stack: sp -= 2
23B8  0005 56     push si
            L0006: si = 0;
            L0008: dx = GetFlag(player, 0x03, 0x07) + GetFlag(player, 0x03, 0x08);
            L002E: dx = dx + GetFlag(player, 0x03, 0x09);
            L0043: dx = dx + GetFlag(player, 0x03, 0x0A);
            L0058: dx = dx + GetFlag(player, 0x03, 0x0B);
            L006D: dx = dx + GetFlag(player, 0x03, 0x0C);
            L0082: dx = dx + GetFlag(player, 0x03, 0x0D);
            L0097: dx = dx + GetFlag(player, 0x03, 0x0E);
            L00AC: dx = dx + GetFlag(player, 0x03, 0x0F);
            L00C1: dx = dx + GetFlag(player, 0x03, 0x10);
            L00D6: dx = dx + GetFlag(player, 0x03, 0x11);
            L00EB: dx = dx + GetFlag(player, 0x03, 0x12);
            L0100: tmp = dx;
            L0103: Compare(tmp, 0x000F);
            L0109: if (JumpEqual) goto L0117;
            L010B: Compare(ax, 0x0026);
            L010E: if (JumpEqual) goto L0121;
            L0110: Compare(ax, 0x0028);
            L0113: if (JumpEqual) goto L011C;
            L0115: goto L0126;
            L0117: si = 0x0002;
            L011A: goto L0129;
            L011C: si = 0x0003;
            L011F: goto L0129;
            L0121: si = 0x0004;
            L0124: goto L0129;
            L0126: si = 0x0001;
            L0129: Compare(GetFlag(player, 0x02, 0x70), si);
            L013C: if (JumpNotBelow) goto L0150;
            L013E: SetFlag(player, 0xC4, 0xB8, si);
            L0150: ShowMessage(player, String136B); // This portal is the only way back to the start of this level. Use it only if you have set the switches.
            L015D: TeleportParty(player, 0x0B, 0x03, ax, 0x01, isForwardMove);
2528  0175 5E     pop si
            L0176: // restore stack ptr: sp = bp;
            L0178: return; // RETURN;
        }

        private void FnSETFLAG_47(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x02, 0x75));
            L0016: if (JumpNotEqual) goto L004C;
            L0018: AddExperience(player, 0x0009EB10);
            L002A: ShowMessage(player, String13D2); // Gain experience for your accomplishment!
            L0037: SetFlag(player, 0x02, 0x75, 0x01);
            L004C: return; // RETURN;
        }

        private void FnPORTBACK_48(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x02, 0x75));
            L0016: if (JumpNotEqual) goto L0032;
            L0018: TeleportParty(player, 0x0B, 0x03, ax, 0x01, isForwardMove);
            L0030: goto L006E;
            L0032: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0050: PushStack(player, 0x01);
            L0054: PushStack(player, GetFacing(player));
            L005C: PushStack(player, GetCurrentTile(player));
25DF  0064 C4 5E 06  les bx, [bp+0x6]
25E2  0067 26 FF 5F 28  call far word [es:bx+0x28]
25E6  006B 83 C4 06  add sp, 0x6
            L006E: return; // RETURN;
        }

        private void FnTORCHROM_4B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0x77), 0x0004);
            L0017: if (JumpBelow) goto L005A;
            L0019: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0037: SetWallObject(player, 0x01, GetCurrentTile(player), GetFacing(player));
264A  0055 B8 FB 13  mov ax, 0x13fb
            L0058: goto L007A;
            L005A: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0077: ShowMessage(player, String1444); // The door is sealed...you will be told when to return to the Torch Room.
            L0084: return; // RETURN;
        }

    }
}
