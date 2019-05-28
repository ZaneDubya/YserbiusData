#pragma warning disable
using System.Collections.Generic;
using XPT.WorldData;
using XPT.WorldData.Yserbius;

namespace XPT.Scripts.Yserbius.Maps {
    class YserMap26 : AMapScripted {
        protected override int MapIndex => 26;
        protected override int RandomEncounterChance => 10;
        protected override int RandomEncounterExtraCount => 0;

        public YserMap26() {
            MapEvent01 = FnTE_01;
            MapEvent02 = FnTA_02;
            MapEvent03 = FnT_03;
            MapEvent04 = FnTC_04;
            MapEvent05 = FnTD_05;
            MapEvent06 = FnTK_06;
            MapEvent07 = FnWTONEA_07;
            MapEvent08 = FnTTENB_08;
            MapEvent09 = FnLEIGHTA_09;
            MapEvent0A = FnWTONEB_0A;
            MapEvent0B = FnTF_0B;
            MapEvent0C = FnLTFOUR_0C;
            MapEvent0D = FnTGG_0D;
            MapEvent0E = FnTFIX_0E;
            MapEvent0F = FnGENTXT_0F;
            MapEvent10 = FnTOONE_10;
            MapEvent11 = FnWPTONE_11;
            MapEvent12 = FnTTHREE_12;
            MapEvent13 = FnTHH_13;
            MapEvent14 = FnWTPTWO_14;
            MapEvent15 = FnWTPTHRE_15;
            MapEvent16 = FnTOTHRE_16;
            MapEvent17 = FnTPWFOUR_17;
            MapEvent18 = FnWTNINEA_18;
            MapEvent19 = FnWWARN_19;
            MapEvent1A = FnTTENA_1A;
            MapEvent1B = FnTEE_1B;
            MapEvent1C = FnTFF_1C;
            MapEvent1D = FnTII_1D;
            MapEvent1E = FnLHALF_1E;
            MapEvent1F = FnLSAFE_1F;
            MapEvent20 = FnLQRTR_20;
            MapEvent21 = FnLAVADEAD_21;
            MapEvent22 = FnWQRTR_22;
            MapEvent23 = FnWSAFE_23;
            MapEvent24 = FnWDEAD_24;
            MapEvent25 = FnWHALF_25;
            MapEvent26 = FnDOORTXT_26;
            MapEvent27 = FnENCT_27;
            MapEvent28 = FnILL_28;
            MapEvent29 = FnILLWALL_29;
            MapEvent2A = FnTKTEXT_2A;
            MapEvent2B = FnHELLENT_2B;
            MapEvent2C = FnQUITTEXT_2C;
            MapEvent2D = FnTPORTWP_2D;
            MapEvent2E = FnHVNNPC_2E;
            MapEvent2F = FnELETEXT_2F;
            MapEvent30 = FnFLAGD_30;
            MapEvent31 = FnFLAGC_31;
            MapEvent32 = FnFLAGE_32;
            MapEvent33 = FnGUARDD_33;
            MapEvent34 = FnGUARDB_34;
            MapEvent35 = FnWEAPON_35;
            MapEvent36 = FnGUARDA_36;
            MapEvent37 = FnDEMONIA_37;
            MapEvent38 = FnFTNFM_38;
            MapEvent39 = FnFTNFN_39;
            MapEvent3A = FnFTNFOZ_3A;
            MapEvent3B = FnFTNFAN_3B;
            MapEvent3C = FnFTNWATER_3C;
            MapEvent3D = FnFTNCZ_3D;
            MapEvent3E = FnFTNFC_3E;
            MapEvent3F = FnFTNFD_3F;
            MapEvent40 = FnFTNFE_40;
            MapEvent41 = FnFTNFBF_41;
            MapEvent42 = FnBATTLEC_42;
            MapEvent43 = FnOUTTXT_43;
            MapEvent44 = FnBATTLEA_44;
            MapEvent45 = FnSETBB_45;
            MapEvent46 = FnLAVABAT_46;
            MapEvent47 = FnBATTLEB_47;
            MapEvent48 = FnSETBD_48;
            MapEvent49 = FnSETBE_49;
            MapEvent4A = FnFTNFP_4A;
            MapEvent4C = FnWBATTB_4C;
            MapEvent4D = FnWBATC_4D;
            MapEvent4E = FnPIT_4E;
            MapEvent4F = FnTLAVTXT_4F;
            MapEvent50 = FnLTEXT_50;
            MapEvent51 = FnENC_51;
            MapEvent52 = FnTXTSP_52;
        }
        
        // === Strings ================================================
        private const string String03FC = "Proceed in single file.";
        private const string String0414 = "The portal to your fate lies elsewhere.";
        private const string String043C = "You slide down a lava tube.";
        private const string String0458 = "An overheated potion explodes and sends you flying.";
        private const string String048C = "The constant crashing of waves appears to be making the walls crumble.";
        private const string String04D3 = "You are caught in a whirlpool.";
        private const string String04F2 = "A flood of water carries you off.";
        private const string String0514 = "A hurricane force wind catapults you.";
        private const string String053A = "You stare ahead in disbelief as a crashing wave sweeps other adventurers to their deaths.";
        private const string String0594 = "You slip on a loose rock and are injured.";
        private const string String05BE = "Molten lava sears you.";
        private const string String05D5 = "You fall to your death in the lava.";
        private const string String05F9 = "The turbulence of the water weakens you.";
        private const string String0622 = "A violent wave crashes against you.";
        private const string String0646 = "You feel a ferocious bite on your leg.";
        private const string String066D = "'Argggh! I died in one of these fountains, yet the party just there was unharmed.'";
        private const string String06C0 = "You push against the dam and the rocks move.";
        private const string String06ED = "If you have correctly thrown the switches, continue alone through the teleport to the south. To continue searching for the switches, walk through the portal to the east.";
        private const string String0797 = "Pluthros has imprisoned Celestia.  She holds the medallion which will aid in his defeat.  Chaos and Harmony are working against each other to possess this medallion.";
        private const string String083D = "Both must find and set three switches in the correct order.  These switches will either lock or open Celestia's cell.";
        private const string String08B3 = "Beware!  There are many switches, choose wisely!";
        private const string String08E4 = "Master Switch Area.  Beyond the teleport, all lock switches will be reset.";
        private const string String092F = "Worthy adventurers!  Be it known that Thorzil has been seen wreaking havoc with the fountains.";
        private const string String098E = "We hear he hides a worthy treasure, one that will aid in the killing of the Dralkarian Juvalad who reigns over us.  Explore and find him!";
        private const string String0A18 = "Beware all who walk through this door.  Malos has controlled the elements and has created havoc along these paths.  It is rumored that he hides the one thing that will do him harm.";
        private const string String0ACD = "You slip by the sleeping guard and throw the lock switch on the wall.";
        private const string String0B13 = "You find the room empty.";
        private const string String0B2C = "The guard quickly draws his weapon and slashes you. As he laughs at his success, you reach behind him and throw the lock switch.";
        private const string String0BAD = "You rest in the empty room.";
        private const string String0BC9 = "You find nothing unusual in the alcove.";
        private const string String0BF1 = "Malos has again attempted to hide the Ice Flame.";
        private const string String0C22 = "You see the sparkle of a weapon embedded in the crusted lava. It surprises you how easily the weapon comes free and you recall a rumor about a special weapon that might aid you in defeating the Dralkarian Malos.";
        private const string String0CF6 = "As you reach behind the guard to throw the lock switch, he lunges forward and wounds you.";
        private const string String0D50 = "The restorative but turbulent waters of Demonia Fountain cause your weapon to glow with the colors of the rainbow.";
        private const string String0DC3 = "The turbulent waters of Demonia Fountain heal your wounds and restore your mana.";
        private const string String0E14 = "The crystal blue waters of Paradise Fountain heal and restore you.";
        private const string String0E57 = "Thorzil's trap causes the fountain to collapse around you.";
        private const string String0E92 = "You cannot avoid the death trap set by Thorzil!";
        private const string String0EC2 = "The fresh waters of Lingolf Fountain heal you and restore your mana.  There is no sign of Thorzil.";
        private const string String0F25 = "The caustic waters of the fountain have been poisoned.";
        private const string String0F5C = "The poisoned waters make you ill.";
        private const string String0F7E = "You hear the sound of flowing water where none was before.";
        private const string String0FB9 = "The calm waters rejuvenate you.";
        private const string String0FD9 = "You find Thorzil hiding in the fountain and nab him.  In order to spare his life, he offers to activate the portal to his poison stash and promises you a sure fire method of defeating Juvalad.";
        private const string String109A = "The waters have already been poisoned.";
        private const string String10C1 = "The cool waters of Elysia Fountain soothe you.";
        private const string String10F0 = "You step into a fountain with discolored waters and feel your health diminish.";
        private const string String113F = "You see what once was a fountain and sense impending danger.";
        private const string String117C = "The destruction of the fountain reminds you of Thorzil.";
        private const string String11B4 = "Some fountains seem unnaturally quiet all of a sudden.";
        private const string String11EB = "You attack the guards in order to throw the lock switch in the room.";
        private const string String1230 = "Your attempt to throw the lock switch is futile.";
        private const string String1261 = "You are attacked by the guards! However, you manage to throw the switch on the wall.";
        private const string String12B6 = "The lock switch is blocked by the guards who attack.";
        private const string String12EB = "You quickly spot the lock switch on the wall and throw it before the guards attack.";
        private const string String133F = "The guards spot you and block the lock switch.";
        private const string String136E = "The crystal blue waters of the fountain heal and restore you.";
        private const string String13AC = "You fall into a bottomless pit.";
        private const string String13CC = "Enter to meet your Fate!";
        private const string String13E5 = "You watch in horror as the lava engulfs the party ahead.";
        private const string String141E = "'Please help me! I've been injured. My payment will be a secret that you need to know.'";
        private const string String1476 = "You aid the ailing dwarf and listen to her story...";
        private const string String14AA = "'I've heard that the guardians here use magic to hide some of the fountains from Thorzil. They reappear from time to time and you must visit them!'";
        private const string String153E = "As you turn to leave your hear the hideous laughter of Pluthros.";
        private const string String157F = "'Fools! You will never complete your task! I have again foiled your attempt at the correct switches!'";
        
        // === Functions ================================================
        private void FnTE_01(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x0B, 0x01, 0x39, 0x03, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnTA_02(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0xAA), 0x0001);
            L0017: if (JumpEqual) goto L0045;
            L0019: Compare(GetFlag(player, 0x02, 0xAC), 0x0001);
            L002D: if (JumpEqual) goto L0045;
            L002F: Compare(GetFlag(player, 0x02, 0xAD), 0x0001);
            L0043: if (JumpNotEqual) goto L0047;
            L0045: goto L005C;
            L0047: SetFlag(player, 0x02, 0xAB, 0x01);
            L005C: TeleportParty(player, 0x0B, 0x01, 0x82, 0x03, isForwardMove);
            L0077: return; // RETURN;
        }

        private void FnT_03(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0xAB), 0x0001);
            L0017: if (JumpEqual) goto L0045;
            L0019: Compare(GetFlag(player, 0x02, 0xAC), 0x0001);
            L002D: if (JumpEqual) goto L0045;
            L002F: Compare(GetFlag(player, 0x02, 0xAD), 0x0001);
            L0043: if (JumpNotEqual) goto L0047;
            L0045: goto L005C;
            L0047: SetFlag(player, 0x02, 0xAA, 0x01);
            L005C: TeleportParty(player, 0x0B, 0x02, 0xEA, 0x02, isForwardMove);
            L0077: return; // RETURN;
        }

        private void FnTC_04(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0xAB), 0x0001);
            L0017: if (JumpEqual) goto L0045;
            L0019: Compare(GetFlag(player, 0x02, 0xAA), 0x0001);
            L002D: if (JumpEqual) goto L0045;
            L002F: Compare(GetFlag(player, 0x02, 0xAD), 0x0001);
            L0043: if (JumpNotEqual) goto L0047;
            L0045: goto L005C;
            L0047: SetFlag(player, 0x02, 0xAC, 0x01);
            L005C: TeleportParty(player, 0x0B, 0x02, 0x5D, 0x00, isForwardMove);
            L0076: return; // RETURN;
        }

        private void FnTD_05(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0xAB), 0x0001);
            L0017: if (JumpEqual) goto L0045;
            L0019: Compare(GetFlag(player, 0x02, 0xAA), 0x0001);
            L002D: if (JumpEqual) goto L0045;
            L002F: Compare(GetFlag(player, 0x02, 0xAC), 0x0001);
            L0043: if (JumpNotEqual) goto L0047;
            L0045: goto L005C;
            L0047: SetFlag(player, 0x02, 0xAD, 0x01);
            L005C: TeleportParty(player, 0x0B, 0x02, 0x2F, 0x00, isForwardMove);
            L0076: return; // RETURN;
        }

        private void FnTK_06(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L0066;
            L0010: Compare(GetFlag(player, 0x02, 0xB0), 0x0003);
            L0024: if (JumpEqual) goto L003C;
            L0026: Compare(GetFlag(player, 0x02, 0xAE), 0x0003);
            L003A: if (JumpNotEqual) goto L0059;
            L003C: TeleportParty(player, 0x0B, 0x02, 0xF1, 0x02, isForwardMove);
            L0057: goto L0080;
            L0059: PushStack(player, 0x03);
            L005D: PushStack(player, 0x39);
0268  0061 B8 01 00  mov ax, 0x1
            L0064: goto L0047;
            L0066: ShowMessage(player, String03FC); // Proceed in single file.
027A  0073 FF 76 08  push word [bp+0x8]
027D  0076 FF 76 06  push word [bp+0x6]
0280  0079 0E     push cs
0281  007A E8 02 1B  call 0x1b7f
            L007D: // NOP
            L007E: cx = PopStack(player);
            L007F: cx = PopStack(player);
            L0080: return; // RETURN;
        }

        private void FnWTONEA_07(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: // make space for tmp on stack: sp -= 2
            L0005: PushStack(player, 0x02);
            L0009: PushStack(player, 0x00);
0295  000C C4 5E 06  les bx, [bp+0x6]
0298  000F 26 FF 5F 04  call far word [es:bx+0x4]
            L0013: cx = PopStack(player);
            L0014: cx = PopStack(player);
            L0015: RefreshCompareFlags(ax);
            L0017: if (JumpEqual) goto L001C;
            L0019: goto L00B3;
            L001C: Compare(GetGuild(player), 0x0004);
            L0026: if (JumpEqual) goto L0040;
            L0028: Compare(GetGuild(player), 0x0003);
            L0032: if (JumpEqual) goto L0040;
            L0034: Compare(GetGuild(player), 0x0001);
            L003E: if (JumpNotEqual) goto L009F;
            L0040: ax = GetCurrentTile(player);
02D0  0047 89 46 FE  mov [bp-0x2], ax
02D3  004A B9 04 00  mov cx, 0x4
            L004D: bx = 0x0340;
02D9  0050 2E 8B 07  mov ax, [cs:bx]
02DC  0053 3B 46 FE  cmp ax, [bp-0x2]
            L0056: if (JumpEqual) goto L005E;
02E1  0058 43     inc bx
02E2  0059 43     inc bx
02E3  005A E2 F4  loop 0x50
            L005C: goto L009F;
02E7  005E 2E FF 67 08  jmp word [cs:bx+0x8]
            L0062: PushStack(player, 0x01);
            L0066: PushStack(player, 0x67);
02F3  006A B8 02 00  mov ax, 0x2
            L006D: goto L008F;
            L006F: PushStack(player, 0x02);
            L0073: PushStack(player, 0x94);
0300  0077 B8 02 00  mov ax, 0x2
            L007A: goto L008F;
            L007C: PushStack(player, 0x01);
0309  0080 B8 4C 00  mov ax, 0x4c
            L0083: goto L008B;
            L0085: TeleportParty(player, 0x0B, 0x01, 0x7F, 0x00, isForwardMove);
            L009F: SetFlag(player, 0x00, 0x02, 0x01);
            L00B3: // restore stack ptr: sp = bp;
            L00B5: return; // RETURN;
            // Extra data: 1F 00 73 00 AC 00 B4 00 EB 02 F8 02 05 03 0E 03 
        }

        private void FnTTENB_08(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetGuild(player), 0x0002);
            L000D: if (JumpEqual) goto L001B;
            L000F: Compare(GetGuild(player), 0x0003);
            L0019: if (JumpNotEqual) goto L0045;
036B  001B FF 76 08  push word [bp+0x8]
036E  001E FF 76 06  push word [bp+0x6]
0371  0021 0E     push cs
0372  0022 E8 B1 1A  call 0x1ad6
            L0025: // NOP
            L0026: cx = PopStack(player);
            L0027: cx = PopStack(player);
            L0028: TeleportParty(player, 0x0B, 0x04, 0xB5, 0x03, isForwardMove);
            L0043: goto L0052;
            L0045: ShowMessage(player, String0414); // The portal to your fate lies elsewhere.
            L0052: return; // RETURN;
        }

        private void FnLEIGHTA_09(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String043C); // You slide down a lava tube.
            L0010: TeleportParty(player, 0x0B, 0x01, 0x7F, 0x00, isForwardMove);
            L002A: return; // RETURN;
        }

        private void FnWTONEB_0A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: // make space for tmp on stack: sp -= 2
            L0005: PushStack(player, 0x02);
            L0009: PushStack(player, 0x00);
03DC  000C C4 5E 06  les bx, [bp+0x6]
03DF  000F 26 FF 5F 04  call far word [es:bx+0x4]
            L0013: cx = PopStack(player);
            L0014: cx = PopStack(player);
            L0015: RefreshCompareFlags(ax);
            L0017: if (JumpEqual) goto L001C;
            L0019: goto L00B2;
            L001C: Compare(GetGuild(player), 0x0002);
            L0026: if (JumpEqual) goto L003F;
            L0028: Compare(GetGuild(player), 0x0005);
            L0032: if (JumpEqual) goto L003F;
            L0034: RefreshCompareFlags(GetGuild(player));
            L003D: if (JumpNotEqual) goto L009E;
            L003F: ax = GetCurrentTile(player);
0416  0046 89 46 FE  mov [bp-0x2], ax
0419  0049 B9 04 00  mov cx, 0x4
            L004C: bx = 0x0486;
041F  004F 2E 8B 07  mov ax, [cs:bx]
0422  0052 3B 46 FE  cmp ax, [bp-0x2]
            L0055: if (JumpEqual) goto L005D;
0427  0057 43     inc bx
0428  0058 43     inc bx
0429  0059 E2 F4  loop 0x4f
            L005B: goto L009E;
042D  005D 2E FF 67 08  jmp word [cs:bx+0x8]
            L0061: PushStack(player, 0x01);
            L0065: PushStack(player, 0x67);
0439  0069 B8 02 00  mov ax, 0x2
            L006C: goto L008E;
            L006E: PushStack(player, 0x02);
            L0072: PushStack(player, 0x94);
0446  0076 B8 02 00  mov ax, 0x2
            L0079: goto L008E;
            L007B: PushStack(player, 0x01);
044F  007F B8 4C 00  mov ax, 0x4c
            L0082: goto L008A;
            L0084: TeleportParty(player, 0x0B, 0x01, 0x7F, 0x00, isForwardMove);
            L009E: SetFlag(player, 0x00, 0x02, 0x01);
            L00B2: // restore stack ptr: sp = bp;
            L00B4: return; // RETURN;
            // Extra data: 2B 00 8A 00 94 00 C2 00 31 04 4B 04 3E 04 54 04 
        }

        private void FnTF_0B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0xB0), 0x0003);
            L0017: if (JumpEqual) goto L002F;
            L0019: Compare(GetFlag(player, 0x02, 0xAE), 0x0003);
            L002D: if (JumpNotEqual) goto L003B;
            L002F: PushStack(player, 0x02);
            L0033: PushStack(player, 0x00);
04CC  0036 B8 01 00  mov ax, 0x1
            L0039: goto L0046;
            L003B: TeleportParty(player, 0x0B, 0x02, 0x23, 0x03, isForwardMove);
            L0056: return; // RETURN;
        }

        private void FnLTFOUR_0C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0458); // An overheated potion explodes and sends you flying.
            L0010: TeleportParty(player, 0x0B, 0x02, 0x32, 0x02, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnTGG_0D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x0B, 0x02, 0xF0, 0x03, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnTFIX_0E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x0B, 0x01, 0x28, 0x01, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnGENTXT_0F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String048C); // The constant crashing of waves appears to be making the walls crumble.
            L0010: return; // RETURN;
        }

        private void FnTOONE_10(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x0B, 0x04, 0xBB, 0x03, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnWPTONE_11(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x0B, 0x01, 0x9D, 0x01, isForwardMove);
            L001E: ShowMessage(player, String04D3); // You are caught in a whirlpool.
            L002B: return; // RETURN;
        }

        private void FnTTHREE_12(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String04F2); // A flood of water carries you off.
            L0010: TeleportParty(player, 0x0B, 0x02, 0xB8, 0x00, isForwardMove);
            L002A: return; // RETURN;
        }

        private void FnTHH_13(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0xA8), 0x0001);
            L0017: if (JumpNotEqual) goto L0022;
            L0019: PushStack(player, 0x03);
0603  001D B8 2B 00  mov ax, 0x2b
            L0020: goto L0029;
            L0022: TeleportParty(player, 0x0B, 0x02, 0xA4, 0x02, isForwardMove);
            L003D: return; // RETURN;
        }

        private void FnWTPTWO_14(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x0B, 0x01, 0xAD, 0x02, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnWTPTHRE_15(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x0B, 0x01, 0xAE, 0x02, isForwardMove);
            L001E: ShowMessage(player, String04D3); // You are caught in a whirlpool.
            L002B: return; // RETURN;
        }

        private void FnTOTHRE_16(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x0B, 0x04, 0x45, 0x02, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnTPWFOUR_17(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x0B, 0x01, 0xAF, 0x03, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnWTNINEA_18(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0514); // A hurricane force wind catapults you.
            L0010: TeleportParty(player, 0x0B, 0x01, 0x3A, 0x01, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnWWARN_19(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String053A); // You stare ahead in disbelief as a crashing wave sweeps other adventurers to their deaths.
            L0010: return; // RETURN;
        }

        private void FnTTENA_1A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetGuild(player), 0x0004);
            L000D: if (JumpEqual) goto L001B;
            L000F: Compare(GetGuild(player), 0x0001);
            L0019: if (JumpNotEqual) goto L0045;
070C  001B FF 76 08  push word [bp+0x8]
070F  001E FF 76 06  push word [bp+0x6]
0712  0021 0E     push cs
0713  0022 E8 10 17  call 0x1735
            L0025: // NOP
            L0026: cx = PopStack(player);
            L0027: cx = PopStack(player);
            L0028: TeleportParty(player, 0x0B, 0x04, 0xB5, 0x02, isForwardMove);
            L0043: goto L0052;
            L0045: ShowMessage(player, String0414); // The portal to your fate lies elsewhere.
            L0052: return; // RETURN;
        }

        private void FnTEE_1B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x0B, 0x01, 0xF1, 0x03, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnTFF_1C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x0B, 0x02, 0xA4, 0x02, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnTII_1D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x0B, 0x02, 0xB0, 0x03, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnLHALF_1E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetNoHealZone(player);
            L000B: PushStack(player, 0x02);
            L000F: PushStack(player, 0x00);
07B7  0012 C4 5E 06  les bx, [bp+0x6]
07BA  0015 26 FF 5F 04  call far word [es:bx+0x4]
            L0019: cx = PopStack(player);
            L001A: cx = PopStack(player);
            L001B: RefreshCompareFlags(ax);
            L001D: if (JumpNotEqual) goto L0057;
            L001F: ShowMessage(player, String0594); // You slip on a loose rock and are injured.
            L002C: ax = GetMaxHits(player);
            L0033: bx = 0x0002;
            L0036: dx = ax % bx; ax = ax / bx;
            L0039: DamagePlayer(player, ax);
            L0043: SetFlag(player, 0x00, 0x02, 0x01);
            L0057: return; // RETURN;
        }

        private void FnLSAFE_1F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetGuild(player), 0x0002);
            L000D: if (JumpEqual) goto L0026;
            L000F: Compare(GetGuild(player), 0x0005);
            L0019: if (JumpEqual) goto L0026;
            L001B: RefreshCompareFlags(GetGuild(player));
            L0024: if (JumpNotEqual) goto L0070;
            L0026: SetNoHealZone(player);
            L002E: PushStack(player, 0x02);
            L0032: PushStack(player, 0x00);
0833  0035 C4 5E 06  les bx, [bp+0x6]
0836  0038 26 FF 5F 04  call far word [es:bx+0x4]
            L003C: cx = PopStack(player);
            L003D: cx = PopStack(player);
            L003E: RefreshCompareFlags(ax);
            L0040: if (JumpNotEqual) goto L0070;
            L0042: ShowMessage(player, String05BE); // Molten lava sears you.
084D  004F FF 76 08  push word [bp+0x8]
0850  0052 FF 76 06  push word [bp+0x6]
0853  0055 0E     push cs
0854  0056 E8 51 15  call 0x15aa
            L0059: // NOP
            L005A: cx = PopStack(player);
            L005B: cx = PopStack(player);
            L005C: SetFlag(player, 0x00, 0x02, 0x01);
            L0070: return; // RETURN;
        }

        private void FnLQRTR_20(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetGuild(player), 0x0004);
            L000D: if (JumpEqual) goto L0027;
            L000F: Compare(GetGuild(player), 0x0003);
            L0019: if (JumpEqual) goto L0027;
            L001B: Compare(GetGuild(player), 0x0001);
            L0025: if (JumpNotEqual) goto L0071;
            L0027: SetNoHealZone(player);
            L002F: PushStack(player, 0x02);
            L0033: PushStack(player, 0x00);
08A6  0036 C4 5E 06  les bx, [bp+0x6]
08A9  0039 26 FF 5F 04  call far word [es:bx+0x4]
            L003D: cx = PopStack(player);
            L003E: cx = PopStack(player);
            L003F: RefreshCompareFlags(ax);
            L0041: if (JumpNotEqual) goto L0071;
            L0043: ShowMessage(player, String05BE); // Molten lava sears you.
08C0  0050 FF 76 08  push word [bp+0x8]
08C3  0053 FF 76 06  push word [bp+0x6]
08C6  0056 0E     push cs
08C7  0057 E8 DE 14  call 0x1538
            L005A: // NOP
            L005B: cx = PopStack(player);
            L005C: cx = PopStack(player);
            L005D: SetFlag(player, 0x00, 0x02, 0x01);
            L0071: return; // RETURN;
        }

        private void FnLAVADEAD_21(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String05D5); // You fall to your death in the lava.
08F3  0010 FF 76 08  push word [bp+0x8]
08F6  0013 FF 76 06  push word [bp+0x6]
08F9  0016 0E     push cs
08FA  0017 E8 3E 14  call 0x1458
            L001A: // NOP
            L001B: cx = PopStack(player);
            L001C: cx = PopStack(player);
            L001D: return; // RETURN;
        }

        private void FnWQRTR_22(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetGuild(player), 0x0004);
            L000D: if (JumpEqual) goto L0027;
            L000F: Compare(GetGuild(player), 0x0003);
            L0019: if (JumpEqual) goto L0027;
            L001B: Compare(GetGuild(player), 0x0001);
            L0025: if (JumpNotEqual) goto L0071;
            L0027: SetNoHealZone(player);
            L002F: PushStack(player, 0x02);
            L0033: PushStack(player, 0x00);
0938  0036 C4 5E 06  les bx, [bp+0x6]
093B  0039 26 FF 5F 04  call far word [es:bx+0x4]
            L003D: cx = PopStack(player);
            L003E: cx = PopStack(player);
            L003F: RefreshCompareFlags(ax);
            L0041: if (JumpNotEqual) goto L0071;
            L0043: ShowMessage(player, String05F9); // The turbulence of the water weakens you.
0952  0050 FF 76 08  push word [bp+0x8]
0955  0053 FF 76 06  push word [bp+0x6]
0958  0056 0E     push cs
0959  0057 E8 4C 14  call 0x14a6
            L005A: // NOP
            L005B: cx = PopStack(player);
            L005C: cx = PopStack(player);
            L005D: SetFlag(player, 0x00, 0x02, 0x01);
            L0071: return; // RETURN;
        }

        private void FnWSAFE_23(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetGuild(player), 0x0002);
            L000D: if (JumpEqual) goto L0026;
            L000F: Compare(GetGuild(player), 0x0005);
            L0019: if (JumpEqual) goto L0026;
            L001B: RefreshCompareFlags(GetGuild(player));
            L0024: if (JumpNotEqual) goto L0070;
            L0026: SetNoHealZone(player);
            L002E: PushStack(player, 0x02);
            L0032: PushStack(player, 0x00);
09AA  0035 C4 5E 06  les bx, [bp+0x6]
09AD  0038 26 FF 5F 04  call far word [es:bx+0x4]
            L003C: cx = PopStack(player);
            L003D: cx = PopStack(player);
            L003E: RefreshCompareFlags(ax);
            L0040: if (JumpNotEqual) goto L0070;
            L0042: ShowMessage(player, String05F9); // The turbulence of the water weakens you.
09C4  004F FF 76 08  push word [bp+0x8]
09C7  0052 FF 76 06  push word [bp+0x6]
09CA  0055 0E     push cs
09CB  0056 E8 DA 13  call 0x1433
            L0059: // NOP
            L005A: cx = PopStack(player);
            L005B: cx = PopStack(player);
            L005C: SetFlag(player, 0x00, 0x02, 0x01);
            L0070: return; // RETURN;
        }

        private void FnWDEAD_24(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0622); // A violent wave crashes against you.
09F7  0010 FF 76 08  push word [bp+0x8]
09FA  0013 FF 76 06  push word [bp+0x6]
09FD  0016 0E     push cs
09FE  0017 E8 3A 13  call 0x1354
            L001A: // NOP
            L001B: cx = PopStack(player);
            L001C: cx = PopStack(player);
            L001D: return; // RETURN;
        }

        private void FnWHALF_25(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetNoHealZone(player);
            L000B: PushStack(player, 0x02);
            L000F: PushStack(player, 0x00);
0A18  0012 C4 5E 06  les bx, [bp+0x6]
0A1B  0015 26 FF 5F 04  call far word [es:bx+0x4]
            L0019: cx = PopStack(player);
            L001A: cx = PopStack(player);
            L001B: RefreshCompareFlags(ax);
            L001D: if (JumpNotEqual) goto L0057;
            L001F: ShowMessage(player, String0646); // You feel a ferocious bite on your leg.
            L002C: ax = GetMaxHits(player);
            L0033: bx = 0x0002;
            L0036: dx = ax % bx; ax = ax / bx;
            L0039: DamagePlayer(player, ax);
            L0043: SetFlag(player, 0x00, 0x02, 0x01);
            L0057: return; // RETURN;
        }

        private void FnDOORTXT_26(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0xAB), 0x0001);
            L0017: if (JumpEqual) goto L005B;
            L0019: Compare(GetFlag(player, 0x02, 0xAA), 0x0001);
            L002D: if (JumpEqual) goto L005B;
            L002F: Compare(GetFlag(player, 0x02, 0xAC), 0x0001);
            L0043: if (JumpEqual) goto L005B;
            L0045: Compare(GetFlag(player, 0x02, 0xAD), 0x0001);
            L0059: if (JumpNotEqual) goto L0088;
0ABA  005B FF 76 08  push word [bp+0x8]
0ABD  005E FF 76 06  push word [bp+0x6]
0AC0  0061 0E     push cs
0AC1  0062 E8 9F 12  call 0x1304
            L0065: // NOP
            L0066: cx = PopStack(player);
            L0067: cx = PopStack(player);
            L0068: SetWallObject(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L0086: goto L0095;
0AE7  0088 FF 76 08  push word [bp+0x8]
0AEA  008B FF 76 06  push word [bp+0x6]
0AED  008E 0E     push cs
0AEE  008F E8 95 12  call 0x1327
            L0092: // NOP
            L0093: cx = PopStack(player);
            L0094: cx = PopStack(player);
            L0095: return; // RETURN;
        }

        private void FnENCT_27(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x000B);
            L0010: ShowMessage(player, String066D); // 'Argggh! I died in one of these fountains, yet the party just there was unharmed.'
            L001D: return; // RETURN;
        }

        private void FnILL_28(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0B18  0003 FF 76 08  push word [bp+0x8]
0B1B  0006 FF 76 06  push word [bp+0x6]
0B1E  0009 0E     push cs
0B1F  000A E8 41 12  call 0x124e
            L000D: // NOP
            L000E: cx = PopStack(player);
            L000F: cx = PopStack(player);
            L0010: return; // RETURN;
        }

        private void FnILLWALL_29(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String06C0); // You push against the dam and the rocks move.
0B37  0010 FF 76 08  push word [bp+0x8]
0B3A  0013 FF 76 06  push word [bp+0x6]
0B3D  0016 0E     push cs
0B3E  0017 E8 22 12  call 0x123c
            L001A: // NOP
            L001B: cx = PopStack(player);
            L001C: cx = PopStack(player);
            L001D: return; // RETURN;
        }

        private void FnTKTEXT_2A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String06ED); // If you have correctly thrown the switches, continue alone through the teleport to the south. To continue searching for the switches, walk through the portal to the east.
            L0010: return; // RETURN;
        }

        private void FnHELLENT_2B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0797); // Pluthros has imprisoned Celestia.  She holds the medallion which will aid in his defeat.  Chaos and Harmony are working against each other to possess this medallion.
            L0010: ShowMessage(player, String083D); // Both must find and set three switches in the correct order.  These switches will either lock or open Celestia's cell.
            L001D: ShowMessage(player, String08B3); // Beware!  There are many switches, choose wisely!
            L002A: SetFlag(player, 0x02, 0xAB, 0x00);
            L003E: SetFlag(player, 0x02, 0xAA, 0x00);
            L0052: SetFlag(player, 0x02, 0xAC, 0x00);
            L0066: SetFlag(player, 0x02, 0xAD, 0x00);
            L007A: SetFlag(player, 0x02, 0xB0, 0x00);
            L008E: SetFlag(player, 0x02, 0xAE, 0x00);
            L00A2: SetFlag(player, 0x02, 0xAF, 0x00);
            L00B6: return; // RETURN;
        }

        private void FnQUITTEXT_2C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String08E4); // Master Switch Area.  Beyond the teleport, all lock switches will be reset.
            L0010: return; // RETURN;
        }

        private void FnTPORTWP_2D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x0B, 0x01, 0xF4, 0x03, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnHVNNPC_2E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x02, 0xA7));
            L0016: if (JumpNotEqual) goto L003F;
            L0018: ShowPortrait(player, 0x0013);
            L0025: ShowMessage(player, String092F); // Worthy adventurers!  Be it known that Thorzil has been seen wreaking havoc with the fountains.
            L0032: ShowMessage(player, String098E); // We hear he hides a worthy treasure, one that will aid in the killing of the Dralkarian Juvalad who reigns over us.  Explore and find him!
            L003F: return; // RETURN;
        }

        private void FnELETEXT_2F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0A18); // Beware all who walk through this door.  Malos has controlled the elements and has created havoc along these paths.  It is rumored that he hides the one thing that will do him harm.
            L0010: return; // RETURN;
        }

        private void FnFLAGD_30(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x02, 0x9F));
            L0016: if (JumpNotEqual) goto L0057;
            L0018: RefreshCompareFlags(GetFlag(player, 0x02, 0xA0));
            L002B: if (JumpNotEqual) goto L0057;
            L002D: RefreshCompareFlags(GetFlag(player, 0x02, 0xA1));
            L0040: if (JumpNotEqual) goto L0057;
            L0042: SetFlag(player, 0x02, 0xA0, 0x01);
            L0057: return; // RETURN;
        }

        private void FnFLAGC_31(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x02, 0x9F));
            L0016: if (JumpNotEqual) goto L0057;
            L0018: RefreshCompareFlags(GetFlag(player, 0x02, 0xA0));
            L002B: if (JumpNotEqual) goto L0057;
            L002D: RefreshCompareFlags(GetFlag(player, 0x02, 0xA1));
            L0040: if (JumpNotEqual) goto L0057;
            L0042: SetFlag(player, 0x02, 0x9F, 0x01);
            L0057: return; // RETURN;
        }

        private void FnFLAGE_32(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x02, 0x9F));
            L0016: if (JumpNotEqual) goto L0057;
            L0018: RefreshCompareFlags(GetFlag(player, 0x02, 0xA0));
            L002B: if (JumpNotEqual) goto L0057;
            L002D: RefreshCompareFlags(GetFlag(player, 0x02, 0xA1));
            L0040: if (JumpNotEqual) goto L0057;
            L0042: SetFlag(player, 0x02, 0xA1, 0x01);
            L0057: return; // RETURN;
        }

        private void FnGUARDD_33(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetAlignment(player));
            L000D: if (JumpNotEqual) goto L0021;
            L000F: ShowPortrait(player, 0x000D);
0DBC  001C B8 CD 0A  mov ax, 0xacd
            L001F: goto L0024;
            L0021: ShowMessage(player, String0B13); // You find the room empty.
            L002E: return; // RETURN;
        }

        private void FnGUARDB_34(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetAlignment(player));
            L000D: if (JumpEqual) goto L0012;
            L000F: goto L00E7;
            L0012: ShowPortrait(player, 0x0011);
            L001F: ShowMessage(player, String0B2C); // The guard quickly draws his weapon and slashes you. As he laughs at his success, you reach behind him and throw the lock switch.
            L002C: ax = GetMaxHits(player);
            L0033: bx = 0x0005;
            L0036: dx = ax % bx; ax = ax / bx;
            L0039: DamagePlayer(player, ax);
            L0043: Compare(GetFlag(player, 0x02, 0xAE), 0x0001);
            L0057: if (JumpNotEqual) goto L009C;
            L0059: Compare(GetFlag(player, 0x02, 0xAC), 0x0001);
            L006D: if (JumpEqual) goto L0085;
            L006F: Compare(GetFlag(player, 0x02, 0xAB), 0x0001);
            L0083: if (JumpNotEqual) goto L009C;
            L0085: SetFlag(player, 0x02, 0xAE, 0x02);
            L009A: goto L00F4;
            L009C: RefreshCompareFlags(GetFlag(player, 0x02, 0xAE));
            L00AF: if (JumpNotEqual) goto L00E2;
            L00B1: Compare(GetFlag(player, 0x02, 0xAD), 0x0001);
            L00C5: if (JumpEqual) goto L00DD;
            L00C7: Compare(GetFlag(player, 0x02, 0xAA), 0x0001);
            L00DB: if (JumpNotEqual) goto L00E2;
0EAD  00DD B8 01 00  mov ax, 0x1
            L00E0: goto L0088;
0EB2  00E2 B8 05 00  mov ax, 0x5
            L00E5: goto L0088;
            L00E7: ShowMessage(player, String0BAD); // You rest in the empty room.
            L00F4: return; // RETURN;
        }

        private void FnWEAPON_35(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetGuild(player), 0x0005);
            L000D: if (JumpEqual) goto L001B;
            L000F: Compare(GetGuild(player), 0x0002);
            L0019: if (JumpNotEqual) goto L0095;
            L001B: Compare(GetFlag(player, 0x02, 0xB2), 0x0001);
            L002F: if (JumpNotEqual) goto L005D;
            L0031: ax = HasItem(player, 0xC9);
            L003F: if (JumpEqual) goto L0043;
            L0041: goto L0095;
            L0043: ShowMessage(player, String0BF1); // Malos has again attempted to hide the Ice Flame.
            L0050: PushStack(player, 0xC9);
0F1A  0054 C4 5E 06  les bx, [bp+0x6]
0F1D  0057 26 FF 5F 48  call far word [es:bx+0x48]
            L005B: goto L00A1;
            L005D: SetFlag(player, 0x02, 0xB2, 0x01);
            L0072: AddExperience(player, 0x000B71B0);
            L0084: GiveItem(player, 0xC9);
0F56  0090 B8 22 0C  mov ax, 0xc22
            L0093: goto L0098;
            L0095: ShowMessage(player, String0BC9); // You find nothing unusual in the alcove.
            L00A2: return; // RETURN;
        }

        private void FnGUARDA_36(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetAlignment(player));
            L000D: if (JumpEqual) goto L0012;
            L000F: goto L00F8;
            L0012: ShowPortrait(player, 0x0019);
            L001F: ShowMessage(player, String0CF6); // As you reach behind the guard to throw the lock switch, he lunges forward and wounds you.
0F96  002C FF 76 08  push word [bp+0x8]
0F99  002F FF 76 06  push word [bp+0x6]
0F9C  0032 0E     push cs
0F9D  0033 E8 08 0E  call 0xe3e
            L0036: // NOP
            L0037: cx = PopStack(player);
            L0038: cx = PopStack(player);
            L0039: Compare(GetFlag(player, 0x02, 0xAE), 0x0002);
            L004D: if (JumpNotEqual) goto L0092;
            L004F: Compare(GetFlag(player, 0x02, 0xAC), 0x0001);
            L0063: if (JumpEqual) goto L007B;
            L0065: Compare(GetFlag(player, 0x02, 0xAA), 0x0001);
            L0079: if (JumpNotEqual) goto L0092;
            L007B: SetFlag(player, 0x02, 0xAE, 0x03);
            L0090: goto L0105;
            L0092: RefreshCompareFlags(GetFlag(player, 0x02, 0xAE));
            L00A5: if (JumpNotEqual) goto L00C2;
            L00A7: Compare(GetFlag(player, 0x02, 0xAB), 0x0001);
            L00BB: if (JumpNotEqual) goto L00C2;
1027  00BD B8 01 00  mov ax, 0x1
            L00C0: goto L007E;
            L00C2: Compare(GetFlag(player, 0x02, 0xAE), 0x0001);
            L00D6: if (JumpNotEqual) goto L00F3;
            L00D8: Compare(GetFlag(player, 0x02, 0xAD), 0x0001);
            L00EC: if (JumpNotEqual) goto L00F3;
1058  00EE B8 02 00  mov ax, 0x2
            L00F1: goto L007E;
105D  00F3 B8 05 00  mov ax, 0x5
            L00F6: goto L007E;
            L00F8: ShowMessage(player, String0B13); // You find the room empty.
            L0105: return; // RETURN;
        }

        private void FnDEMONIA_37(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
1074  0003 FF 76 08  push word [bp+0x8]
1077  0006 FF 76 06  push word [bp+0x6]
107A  0009 0E     push cs
107B  000A E8 D3 0C  call 0xce0
            L000D: // NOP
            L000E: cx = PopStack(player);
            L000F: cx = PopStack(player);
1081  0010 FF 76 08  push word [bp+0x8]
1084  0013 FF 76 06  push word [bp+0x6]
1087  0016 0E     push cs
1088  0017 E8 41 0D  call 0xd5b
            L001A: // NOP
            L001B: cx = PopStack(player);
            L001C: cx = PopStack(player);
            L001D: RefreshCompareFlags(GetAlignment(player));
            L0027: if (JumpNotEqual) goto L0043;
            L0029: SetFlag(player, 0x02, 0xAF, 0x01);
10AF  003E B8 50 0D  mov ax, 0xd50
            L0041: goto L0046;
            L0043: ShowMessage(player, String0DC3); // The turbulent waters of Demonia Fountain heal your wounds and restore your mana.
            L0050: return; // RETURN;
        }

        private void FnFTNFM_38(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
10C6  0003 FF 76 08  push word [bp+0x8]
10C9  0006 FF 76 06  push word [bp+0x6]
10CC  0009 0E     push cs
10CD  000A E8 81 0C  call 0xc8e
            L000D: // NOP
            L000E: cx = PopStack(player);
            L000F: cx = PopStack(player);
            L0010: Compare(GetFlag(player, 0x02, 0xA1), 0x0001);
            L0024: if (JumpEqual) goto L003C;
            L0026: Compare(GetFlag(player, 0x02, 0x9F), 0x0001);
            L003A: if (JumpNotEqual) goto L0056;
            L003C: ShowMessage(player, String0E14); // The crystal blue waters of Paradise Fountain heal and restore you.
110C  0049 FF 76 08  push word [bp+0x8]
110F  004C FF 76 06  push word [bp+0x6]
1112  004F 0E     push cs
1113  0050 E8 B6 0C  call 0xd09
            L0053: // NOP
            L0054: goto L006E;
            L0056: ShowMessage(player, String0E57); // Thorzil's trap causes the fountain to collapse around you.
1126  0063 FF 76 08  push word [bp+0x8]
1129  0066 FF 76 06  push word [bp+0x6]
112C  0069 0E     push cs
112D  006A E8 0B 0C  call 0xc78
            L006D: // NOP
            L006E: cx = PopStack(player);
            L006F: cx = PopStack(player);
            L0070: return; // RETURN;
        }

        private void FnFTNFN_39(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
1138  0003 FF 76 08  push word [bp+0x8]
113B  0006 FF 76 06  push word [bp+0x6]
113E  0009 0E     push cs
113F  000A E8 0F 0C  call 0xc1c
            L000D: // NOP
            L000E: cx = PopStack(player);
            L000F: cx = PopStack(player);
            L0010: Compare(GetFlag(player, 0x02, 0xA1), 0x0001);
            L0024: if (JumpEqual) goto L003C;
            L0026: Compare(GetFlag(player, 0x02, 0x9F), 0x0001);
            L003A: if (JumpNotEqual) goto L0056;
            L003C: ShowMessage(player, String0E92); // You cannot avoid the death trap set by Thorzil!
117E  0049 FF 76 08  push word [bp+0x8]
1181  004C FF 76 06  push word [bp+0x6]
1184  004F 0E     push cs
1185  0050 E8 B3 0B  call 0xc06
            L0053: // NOP
            L0054: goto L006E;
            L0056: ShowMessage(player, String0EC2); // The fresh waters of Lingolf Fountain heal you and restore your mana.  There is no sign of Thorzil.
1198  0063 FF 76 08  push word [bp+0x8]
119B  0066 FF 76 06  push word [bp+0x6]
119E  0069 0E     push cs
119F  006A E8 2A 0C  call 0xc97
            L006D: // NOP
            L006E: cx = PopStack(player);
            L006F: cx = PopStack(player);
            L0070: return; // RETURN;
        }

        private void FnFTNFOZ_3A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x01);
            L0007: PushStack(player, 0x00);
11B1  000A C4 5E 06  les bx, [bp+0x6]
11B4  000D 26 FF 5F 04  call far word [es:bx+0x4]
            L0011: cx = PopStack(player);
            L0012: cx = PopStack(player);
            L0013: RefreshCompareFlags(ax);
            L0015: if (JumpNotEqual) goto L0053;
11BE  0017 FF 76 08  push word [bp+0x8]
11C1  001A FF 76 06  push word [bp+0x6]
11C4  001D 0E     push cs
11C5  001E E8 89 0B  call 0xbaa
            L0021: // NOP
            L0022: cx = PopStack(player);
            L0023: cx = PopStack(player);
            L0024: SetFlag(player, 0x02, 0xA5, 0x01);
            L0039: ShowMessage(player, String0F25); // The caustic waters of the fountain have been poisoned.
11ED  0046 FF 76 08  push word [bp+0x8]
11F0  0049 FF 76 06  push word [bp+0x6]
11F3  004C 0E     push cs
11F4  004D E8 F8 0B  call 0xc48
            L0050: // NOP
            L0051: cx = PopStack(player);
            L0052: cx = PopStack(player);
            L0053: return; // RETURN;
        }

        private void FnFTNFAN_3B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x01);
            L0007: PushStack(player, 0x00);
1206  000A C4 5E 06  les bx, [bp+0x6]
1209  000D 26 FF 5F 04  call far word [es:bx+0x4]
            L0011: cx = PopStack(player);
            L0012: cx = PopStack(player);
            L0013: RefreshCompareFlags(ax);
            L0015: if (JumpEqual) goto L001A;
            L0017: goto L00A5;
1216  001A FF 76 08  push word [bp+0x8]
1219  001D FF 76 06  push word [bp+0x6]
121C  0020 0E     push cs
121D  0021 E8 31 0B  call 0xb55
            L0024: // NOP
            L0025: cx = PopStack(player);
            L0026: cx = PopStack(player);
            L0027: ShowMessage(player, String0F5C); // The poisoned waters make you ill.
1230  0034 FF 76 08  push word [bp+0x8]
1233  0037 FF 76 06  push word [bp+0x6]
1236  003A 0E     push cs
1237  003B E8 B5 0B  call 0xbf3
            L003E: // NOP
            L003F: cx = PopStack(player);
            L0040: cx = PopStack(player);
            L0041: Compare(GetFlag(player, 0x02, 0xA7), 0x0001);
            L0055: if (JumpNotEqual) goto L00A5;
            L0057: Compare(GetFlag(player, 0x02, 0xA4), 0x0001);
            L006B: if (JumpNotEqual) goto L00A5;
            L006D: Compare(GetFlag(player, 0x02, 0xA5), 0x0001);
            L0081: if (JumpNotEqual) goto L00A5;
            L0083: SetFlag(player, 0x02, 0x9E, 0x01);
            L0098: ShowMessage(player, String0F7E); // You hear the sound of flowing water where none was before.
            L00A5: return; // RETURN;
        }

        private void FnFTNWATER_3C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0FB9); // The calm waters rejuvenate you.
12B3  0010 FF 76 08  push word [bp+0x8]
12B6  0013 FF 76 06  push word [bp+0x6]
12B9  0016 0E     push cs
12BA  0017 E8 0F 0B  call 0xb29
            L001A: // NOP
            L001B: cx = PopStack(player);
            L001C: cx = PopStack(player);
            L001D: return; // RETURN;
        }

        private void FnFTNCZ_3D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0x9E), 0x0001);
            L0017: if (JumpEqual) goto L001C;
            L0019: goto L0117;
12DE  001C FF 76 08  push word [bp+0x8]
12E1  001F FF 76 06  push word [bp+0x6]
12E4  0022 0E     push cs
12E5  0023 E8 69 0A  call 0xa8f
            L0026: // NOP
            L0027: cx = PopStack(player);
            L0028: cx = PopStack(player);
            L0029: SetFlag(player, 0x02, 0xA6, 0x01);
            L003E: Compare(GetFlag(player, 0x02, 0xA3), 0x0001);
            L0052: if (JumpEqual) goto L0057;
            L0054: goto L00E9;
            L0057: Compare(GetFlag(player, 0x02, 0xA4), 0x0001);
            L006B: if (JumpNotEqual) goto L00E9;
            L006D: Compare(GetFlag(player, 0x02, 0xA5), 0x0001);
            L0081: if (JumpNotEqual) goto L00E9;
            L0083: Compare(GetFlag(player, 0x02, 0xA6), 0x0001);
            L0097: if (JumpNotEqual) goto L00E9;
            L0099: Compare(GetFlag(player, 0x02, 0xA7), 0x0001);
            L00AD: if (JumpNotEqual) goto L00E9;
            L00AF: Compare(GetFlag(player, 0x02, 0x9F), 0x0001);
            L00C3: if (JumpNotEqual) goto L00E9;
            L00C5: ShowMessage(player, String0FD9); // You find Thorzil hiding in the fountain and nab him.  In order to spare his life, he offers to activate the portal to his poison stash and promises you a sure fire method of defeating Juvalad.
            L00D2: SetFlag(player, 0x02, 0xA8, 0x01);
            L00E7: goto L0117;
            L00E9: PushStack(player, 0x01);
            L00ED: PushStack(player, 0x00);
13B2  00F0 C4 5E 06  les bx, [bp+0x6]
13B5  00F3 26 FF 5F 04  call far word [es:bx+0x4]
            L00F7: cx = PopStack(player);
            L00F8: cx = PopStack(player);
            L00F9: RefreshCompareFlags(ax);
            L00FB: if (JumpNotEqual) goto L0117;
            L00FD: ShowMessage(player, String109A); // The waters have already been poisoned.
13CC  010A FF 76 08  push word [bp+0x8]
13CF  010D FF 76 06  push word [bp+0x6]
13D2  0110 0E     push cs
13D3  0111 E8 19 0A  call 0xb2d
            L0114: // NOP
            L0115: cx = PopStack(player);
            L0116: cx = PopStack(player);
            L0117: return; // RETURN;
        }

        private void FnFTNFC_3E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
13DE  0003 FF 76 08  push word [bp+0x8]
13E1  0006 FF 76 06  push word [bp+0x6]
13E4  0009 0E     push cs
13E5  000A E8 69 09  call 0x976
            L000D: // NOP
            L000E: cx = PopStack(player);
            L000F: cx = PopStack(player);
            L0010: ShowMessage(player, String10C1); // The cool waters of Elysia Fountain soothe you.
13F8  001D FF 76 08  push word [bp+0x8]
13FB  0020 FF 76 06  push word [bp+0x6]
13FE  0023 0E     push cs
13FF  0024 E8 CA 09  call 0x9f1
            L0027: // NOP
            L0028: cx = PopStack(player);
            L0029: cx = PopStack(player);
            L002A: return; // RETURN;
        }

        private void FnFTNFD_3F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x02);
            L0007: PushStack(player, 0x00);
1411  000A C4 5E 06  les bx, [bp+0x6]
1414  000D 26 FF 5F 04  call far word [es:bx+0x4]
            L0011: cx = PopStack(player);
            L0012: cx = PopStack(player);
            L0013: RefreshCompareFlags(ax);
            L0015: if (JumpNotEqual) goto L0052;
141E  0017 FF 76 08  push word [bp+0x8]
1421  001A FF 76 06  push word [bp+0x6]
1424  001D 0E     push cs
1425  001E E8 29 09  call 0x94a
            L0021: // NOP
            L0022: cx = PopStack(player);
            L0023: cx = PopStack(player);
            L0024: ShowMessage(player, String10F0); // You step into a fountain with discolored waters and feel your health diminish.
1438  0031 FF 76 08  push word [bp+0x8]
143B  0034 FF 76 06  push word [bp+0x6]
143E  0037 0E     push cs
143F  0038 E8 66 09  call 0x9a1
            L003B: // NOP
            L003C: cx = PopStack(player);
            L003D: cx = PopStack(player);
            L003E: SetFlag(player, 0x00, 0x02, 0x01);
            L0052: return; // RETURN;
        }

        private void FnFTNFE_40(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String113F); // You see what once was a fountain and sense impending danger.
            L0010: return; // RETURN;
        }

        private void FnFTNFBF_41(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFlag(player, 0x02, 0x9E, 0x00);
            L0017: ShowMessage(player, String117C); // The destruction of the fountain reminds you of Thorzil.
            L0024: ShowMessage(player, String11B4); // Some fountains seem unnaturally quiet all of a sudden.
            L0031: return; // RETURN;
        }

        private void FnBATTLEC_42(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String11EB); // You attack the guards in order to throw the lock switch in the room.
            L0010: Compare(GetAlignment(player), 0x0001);
            L001B: if (JumpEqual) goto L0020;
            L001D: goto L00DF;
            L0020: Compare(GetFlag(player, 0x02, 0xB0), 0x0002);
            L0034: if (JumpNotEqual) goto L0079;
            L0036: Compare(GetFlag(player, 0x02, 0xAC), 0x0001);
            L004A: if (JumpEqual) goto L0062;
            L004C: Compare(GetFlag(player, 0x02, 0xAA), 0x0001);
            L0060: if (JumpNotEqual) goto L0079;
            L0062: SetFlag(player, 0x02, 0xB0, 0x03);
            L0077: goto L00EC;
            L0079: RefreshCompareFlags(GetFlag(player, 0x02, 0xB0));
            L008C: if (JumpNotEqual) goto L00A9;
            L008E: Compare(GetFlag(player, 0x02, 0xAB), 0x0001);
            L00A2: if (JumpNotEqual) goto L00A9;
1544  00A4 B8 01 00  mov ax, 0x1
            L00A7: goto L0065;
            L00A9: Compare(GetFlag(player, 0x02, 0xB0), 0x0001);
            L00BD: if (JumpNotEqual) goto L00DA;
            L00BF: Compare(GetFlag(player, 0x02, 0xAD), 0x0001);
            L00D3: if (JumpNotEqual) goto L00DA;
1575  00D5 B8 02 00  mov ax, 0x2
            L00D8: goto L0065;
157A  00DA B8 05 00  mov ax, 0x5
            L00DD: goto L0065;
            L00DF: ShowMessage(player, String1230); // Your attempt to throw the lock switch is futile.
            L00EC: Compare(PartyCount(player), 0x0001);
            L00F7: if (JumpEqual) goto L0106;
            L00F9: Compare(PartyCount(player), 0x0002);
            L0104: if (JumpNotEqual) goto L0133;
            L0106: AddEncounter(player, 0x01, 0x08);
            L0118: AddEncounter(player, 0x02, 0x08);
            L012A: PushStack(player, 0x09);
15CE  012E B8 03 00  mov ax, 0x3
            L0131: goto L0170;
            L0133: AddEncounter(player, 0x01, 0x08);
            L0145: AddEncounter(player, 0x02, 0x09);
            L0157: AddEncounter(player, 0x03, 0x0A);
            L0169: AddEncounter(player, 0x04, 0x0A);
            L017B: return; // RETURN;
        }

        private void FnOUTTXT_43(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
1620  0003 FF 76 08  push word [bp+0x8]
1623  0006 FF 76 06  push word [bp+0x6]
1626  0009 0E     push cs
1627  000A E8 FC 07  call 0x809
            L000D: // NOP
            L000E: cx = PopStack(player);
            L000F: cx = PopStack(player);
            L0010: return; // RETURN;
        }

        private void FnBATTLEA_44(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetAlignment(player), 0x0001);
            L000E: if (JumpNotEqual) goto L0015;
163F  0010 B8 61 12  mov ax, 0x1261
            L0013: goto L0018;
            L0015: ShowMessage(player, String12B6); // The lock switch is blocked by the guards who attack.
            L0022: Compare(PartyCount(player), 0x0001);
            L002D: if (JumpEqual) goto L003C;
            L002F: Compare(PartyCount(player), 0x0002);
            L003A: if (JumpNotEqual) goto L0057;
            L003C: AddEncounter(player, 0x01, 0x03);
            L004E: PushStack(player, 0x06);
1681  0052 B8 02 00  mov ax, 0x2
            L0055: goto L0094;
            L0057: AddEncounter(player, 0x01, 0x03);
            L0069: AddEncounter(player, 0x02, 0x06);
            L007B: AddEncounter(player, 0x03, 0x0E);
            L008D: AddEncounter(player, 0x04, 0x0F);
            L009F: return; // RETURN;
        }

        private void FnSETBB_45(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpEqual) goto L001D;
            L0010: Compare(PartyCount(player), 0x0002);
            L001B: if (JumpNotEqual) goto L0058;
            L001D: AddEncounter(player, 0x01, 0x20);
            L002F: AddEncounter(player, 0x02, 0x20);
            L0041: AddEncounter(player, 0x05, 0x21);
1723  0053 B8 21 00  mov ax, 0x21
            L0056: goto L00B5;
            L0058: AddEncounter(player, 0x01, 0x20);
            L006A: AddEncounter(player, 0x02, 0x20);
            L007C: AddEncounter(player, 0x03, 0x21);
            L008E: AddEncounter(player, 0x04, 0x21);
            L00A0: AddEncounter(player, 0x05, 0x22);
            L00B2: AddEncounter(player, 0x06, 0x22);
            L00C4: return; // RETURN;
        }

        private void FnLAVABAT_46(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L002C;
            L0010: AddEncounter(player, 0x01, 0x12);
            L0022: PushStack(player, 0x19);
17BC  0026 B8 02 00  mov ax, 0x2
            L0029: goto L00C7;
            L002C: Compare(PartyCount(player), 0x0002);
            L0037: if (JumpNotEqual) goto L0078;
            L0039: AddEncounter(player, 0x01, 0x12);
            L004B: AddEncounter(player, 0x02, 0x12);
            L005D: AddEncounter(player, 0x03, 0x19);
            L006F: PushStack(player, 0x1A);
1809  0073 B8 04 00  mov ax, 0x4
            L0076: goto L00C7;
            L0078: AddEncounter(player, 0x01, 0x12);
            L008A: AddEncounter(player, 0x02, 0x12);
            L009C: AddEncounter(player, 0x03, 0x19);
            L00AE: AddEncounter(player, 0x04, 0x1A);
            L00C0: AddEncounter(player, 0x06, 0x1B);
            L00D2: return; // RETURN;
        }

        private void FnBATTLEB_47(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetAlignment(player), 0x0001);
            L000E: if (JumpNotEqual) goto L0015;
187A  0010 B8 EB 12  mov ax, 0x12eb
            L0013: goto L0018;
            L0015: ShowMessage(player, String133F); // The guards spot you and block the lock switch.
            L0022: Compare(PartyCount(player), 0x0001);
            L002D: if (JumpEqual) goto L003C;
            L002F: Compare(PartyCount(player), 0x0002);
            L003A: if (JumpNotEqual) goto L0066;
            L003C: PushStack(player, 0x01);
            L0040: PushStack(player, ax);
18AB  0041 C4 5E 06  les bx, [bp+0x6]
18AE  0044 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L0049: cx = PopStack(player);
            L004A: cx = PopStack(player);
            L004B: AddEncounter(player, 0x02, 0x01);
            L005D: PushStack(player, 0x03);
18CB  0061 B8 05 00  mov ax, 0x5
            L0064: goto L009D;
            L0066: AddEncounter(player, 0x01, 0x02);
            L0078: PushStack(player, 0x02);
            L007C: PushStack(player, ax);
18E7  007D C4 5E 06  les bx, [bp+0x6]
18EA  0080 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L0085: cx = PopStack(player);
            L0086: cx = PopStack(player);
            L0087: PushStack(player, 0x03);
            L008B: PushStack(player, ax);
18F6  008C C4 5E 06  les bx, [bp+0x6]
18F9  008F 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L0094: cx = PopStack(player);
            L0095: cx = PopStack(player);
            L0096: AddEncounter(player, 0x04, 0x03);
            L00A8: return; // RETURN;
        }

        private void FnSETBD_48(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L002C;
            L0010: AddEncounter(player, 0x01, 0x15);
            L0022: PushStack(player, 0x16);
193A  0026 B8 02 00  mov ax, 0x2
            L0029: goto L00B1;
            L002C: Compare(PartyCount(player), 0x0002);
            L0037: if (JumpNotEqual) goto L0062;
            L0039: AddEncounter(player, 0x01, 0x16);
            L004B: AddEncounter(player, 0x02, 0x17);
1971  005D B8 23 00  mov ax, 0x23
            L0060: goto L00AD;
            L0062: AddEncounter(player, 0x01, 0x16);
            L0074: AddEncounter(player, 0x02, 0x17);
            L0086: AddEncounter(player, 0x03, 0x24);
            L0098: AddEncounter(player, 0x04, 0x24);
            L00AA: AddEncounter(player, 0x05, 0x25);
            L00BC: return; // RETURN;
        }

        private void FnSETBE_49(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpEqual) goto L001D;
            L0010: Compare(PartyCount(player), 0x0002);
            L001B: if (JumpNotEqual) goto L0039;
            L001D: AddEncounter(player, 0x01, 0x05);
            L002F: PushStack(player, 0x23);
1A05  0033 B8 02 00  mov ax, 0x2
            L0036: goto L00E6;
            L0039: Compare(PartyCount(player), 0x0002);
            L0044: if (JumpNotEqual) goto L0085;
            L0046: AddEncounter(player, 0x01, 0x05);
            L0058: AddEncounter(player, 0x02, 0x06);
            L006A: AddEncounter(player, 0x03, 0x23);
            L007C: PushStack(player, 0x24);
1A52  0080 B8 04 00  mov ax, 0x4
            L0083: goto L00E6;
            L0085: AddEncounter(player, 0x01, 0x05);
            L0097: AddEncounter(player, 0x02, 0x05);
            L00A9: AddEncounter(player, 0x03, 0x06);
            L00BB: AddEncounter(player, 0x04, 0x06);
            L00CD: AddEncounter(player, 0x05, 0x24);
            L00DF: AddEncounter(player, 0x06, 0x25);
            L00F1: return; // RETURN;
        }

        private void FnFTNFP_4A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0x9E), 0x0001);
            L0017: if (JumpNotEqual) goto L0086;
1ADE  0019 FF 76 08  push word [bp+0x8]
1AE1  001C FF 76 06  push word [bp+0x6]
1AE4  001F 0E     push cs
1AE5  0020 E8 69 02  call 0x28c
            L0023: // NOP
            L0024: cx = PopStack(player);
            L0025: cx = PopStack(player);
            L0026: Compare(GetFlag(player, 0x02, 0xA1), 0x0001);
            L003A: if (JumpEqual) goto L0052;
            L003C: Compare(GetFlag(player, 0x02, 0x9F), 0x0001);
            L0050: if (JumpNotEqual) goto L006C;
            L0052: ShowMessage(player, String136E); // The crystal blue waters of the fountain heal and restore you.
1B24  005F FF 76 08  push word [bp+0x8]
1B27  0062 FF 76 06  push word [bp+0x6]
1B2A  0065 0E     push cs
1B2B  0066 E8 9E 02  call 0x307
            L0069: // NOP
            L006A: goto L0084;
            L006C: ShowMessage(player, String0E57); // Thorzil's trap causes the fountain to collapse around you.
1B3E  0079 FF 76 08  push word [bp+0x8]
1B41  007C FF 76 06  push word [bp+0x6]
1B44  007F 0E     push cs
1B45  0080 E8 F3 01  call 0x276
            L0083: // NOP
            L0084: cx = PopStack(player);
            L0085: cx = PopStack(player);
            L0086: return; // RETURN;
        }

        private void FnWBATTB_4C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0xB7);
            L0011: if (JumpEqual) goto L0024;
1B65  0013 B8 EE 02  mov ax, 0x2ee
            L0016: PushStack(player, ax);
            L0017: PushStack(player, 0x00);
            L001A: PushStack(player, ax);
            L001B: PushStack(player, 0xCC);
1B71  001F B8 B6 00  mov ax, 0xb6
            L0022: goto L0033;
1B76  0024 B8 E8 03  mov ax, 0x3e8
            L0027: PushStack(player, ax);
            L0028: PushStack(player, 0x00);
            L002B: PushStack(player, ax);
            L002C: PushStack(player, 0xCD);
            L0030: PushStack(player, 0xB7);
            L0034: PushStack(player, 0xB7);
1B8A  0038 C4 5E 06  les bx, [bp+0x6]
1B8D  003B 26 FF 9F D8 00  call far word [es:bx+0xd8]
1B92  0040 83 C4 0C  add sp, 0xc
            L0043: Compare(PartyCount(player), 0x0001);
            L004E: if (JumpNotEqual) goto L006C;
            L0050: AddEncounter(player, 0x01, 0x0F);
            L0062: PushStack(player, 0x11);
1BB8  0066 B8 02 00  mov ax, 0x2
            L0069: goto L0103;
            L006C: Compare(PartyCount(player), 0x0002);
            L0077: if (JumpNotEqual) goto L00B4;
            L0079: AddEncounter(player, 0x01, 0x0F);
            L008B: AddEncounter(player, 0x02, 0x0F);
            L009D: AddEncounter(player, 0x05, 0x1A);
1C01  00AF B8 10 00  mov ax, 0x10
            L00B2: goto L00FF;
            L00B4: AddEncounter(player, 0x01, 0x0F);
            L00C6: AddEncounter(player, 0x02, 0x0F);
            L00D8: AddEncounter(player, 0x03, 0x10);
            L00EA: AddEncounter(player, 0x04, 0x10);
            L00FC: AddEncounter(player, 0x06, 0x11);
            L010E: return; // RETURN;
        }

        private void FnWBATC_4D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L0029;
            L0010: PushStack(player, 0x01);
            L0014: PushStack(player, ax);
1C77  0015 C4 5E 06  les bx, [bp+0x6]
1C7A  0018 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L001D: cx = PopStack(player);
            L001E: cx = PopStack(player);
            L001F: PushStack(player, 0x03);
1C85  0023 B8 02 00  mov ax, 0x2
            L0026: goto L00A8;
            L0029: Compare(PartyCount(player), 0x0002);
            L0034: if (JumpNotEqual) goto L005C;
            L0036: PushStack(player, 0x01);
            L003A: PushStack(player, ax);
1C9D  003B C4 5E 06  les bx, [bp+0x6]
1CA0  003E 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L0043: cx = PopStack(player);
            L0044: cx = PopStack(player);
            L0045: AddEncounter(player, 0x02, 0x01);
1CB9  0057 B8 02 00  mov ax, 0x2
            L005A: goto L0092;
            L005C: PushStack(player, 0x01);
            L0060: PushStack(player, ax);
1CC3  0061 C4 5E 06  les bx, [bp+0x6]
1CC6  0064 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L0069: cx = PopStack(player);
            L006A: cx = PopStack(player);
            L006B: AddEncounter(player, 0x02, 0x01);
            L007D: AddEncounter(player, 0x03, 0x02);
            L008F: AddEncounter(player, 0x05, 0x03);
            L00A1: AddEncounter(player, 0x06, 0x03);
            L00B3: return; // RETURN;
        }

        private void FnPIT_4E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String13AC); // You fall into a bottomless pit.
1D27  0010 FF 76 08  push word [bp+0x8]
1D2A  0013 FF 76 06  push word [bp+0x6]
1D2D  0016 0E     push cs
1D2E  0017 E8 0A 00  call 0x24
            L001A: // NOP
            L001B: cx = PopStack(player);
            L001C: cx = PopStack(player);
            L001D: return; // RETURN;
        }

        private void FnTLAVTXT_4F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: return; // RETURN;
            // Extra data: 55 8B EC C4 5E 06 26 FF 5F 74 50 C4 5E 06 26 FF 9F 90 00 59 5D CB 55 8B EC B8 42 00 50 C4 5E 06 26 FF 9F FC 00 59 5D CB 55 8B EC B8 01 00 50 C4 5E 06 26 FF 5F 24 50 C4 5E 06 26 FF 5F 20 50 C4 5E 06 26 FF 5F 2C 83 C4 06 5D CB 55 8B EC 33 C0 50 C4 5E 06 26 FF 5F 24 50 C4 5E 06 26 FF 5F 20 50 C4 5E 06 26 FF 5F 2C 83 C4 06 5D CB 55 8B EC C4 5E 06 26 FF 5F 74 BB 04 00 99 F7 FB 50 C4 5E 06 26 FF 9F 90 00 59 C4 5E 06 26 FF 9F C4 00 5D CB 55 8B EC C4 5E 06 26 FF 5F 74 50 C4 5E 06 26 FF 9F 94 00 59 B8 10 27 50 C4 5E 06 26 FF 9F B4 00 59 5D CB 55 8B EC C4 5E 06 26 FF 5F 74 BB 05 00 99 F7 FB 50 B8 05 00 50 B8 01 00 50 C4 5E 06 26 FF 9F 9C 00 83 C4 06 B8 01 00 50 50 33 C0 50 C4 5E 06 26 FF 1F 83 C4 06 5D CB 55 8B EC B8 CC 13 50 C4 5E 06 26 FF 9F F8 00 59 5D CB 
        }

        private void FnLTEXT_50(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String13E5); // You watch in horror as the lava engulfs the party ahead.
            L0010: return; // RETURN;
        }

        private void FnENC_51(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0xA5), 0x0001);
            L0017: if (JumpEqual) goto L001C;
            L0019: goto L00A6;
            L001C: Compare(GetFlag(player, 0x02, 0xA7), 0x0001);
            L0030: if (JumpNotEqual) goto L00A6;
            L0032: Compare(GetFlag(player, 0x02, 0xA4), 0x0001);
            L0046: if (JumpNotEqual) goto L00A6;
            L0048: RefreshCompareFlags(GetFlag(player, 0x02, 0xA2));
            L005B: if (JumpNotEqual) goto L00A6;
            L005D: ShowPortrait(player, 0x002C);
            L006A: ShowMessage(player, String141E); // 'Please help me! I've been injured. My payment will be a secret that you need to know.'
            L0077: ShowMessage(player, String1476); // You aid the ailing dwarf and listen to her story...
            L0084: ShowMessage(player, String14AA); // 'I've heard that the guardians here use magic to hide some of the fountains from Thorzil. They reappear from time to time and you must visit them!'
            L0091: SetFlag(player, 0x02, 0xA2, 0x01);
            L00A6: return; // RETURN;
        }

        private void FnTXTSP_52(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0xB0), 0x0005);
            L0017: if (JumpEqual) goto L002F;
            L0019: Compare(GetFlag(player, 0x02, 0xAE), 0x0005);
            L002D: if (JumpNotEqual) goto L0049;
            L002F: ShowMessage(player, String153E); // As you turn to leave your hear the hideous laughter of Pluthros.
            L003C: ShowMessage(player, String157F); // 'Fools! You will never complete your task! I have again foiled your attempt at the correct switches!'
            L0049: return; // RETURN;
        }

    }
}
