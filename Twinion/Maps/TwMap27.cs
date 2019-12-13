#pragma warning disable
using System.Collections.Generic;
using XPT.WorldData;
using XPT.WorldData.Yserbius;

namespace XPT.Scripts.Twinion.Maps {
    class TwMap27 : AMapScripted {
        protected override int MapIndex => 27;
        protected override int RandomEncounterChance => 5;
        protected override int RandomEncounterExtraCount => 0;

        public TwMap27() {
            MapEvent01 = FnTE_01;
            MapEvent02 = FnTOFOUR_02;
            MapEvent03 = FnTC_03;
            MapEvent04 = FnTAA_04;
            MapEvent05 = FnTEIGHTA_05;
            MapEvent06 = FnTEIGHTB_06;
            MapEvent07 = FnTTWO_07;
            MapEvent08 = FnTBB_08;
            MapEvent09 = FnTSIXW_09;
            MapEvent0A = FnTB_0A;
            MapEvent0B = FnTCC_0B;
            MapEvent0C = FnTPRTEE_0C;
            MapEvent0D = FnTTENC_0D;
            MapEvent0E = FnTDD_0E;
            MapEvent0F = FnTH_0F;
            MapEvent10 = FnCLUE_10;
            MapEvent11 = FnWEIGHT_11;
            MapEvent12 = FnLNINE_12;
            MapEvent14 = FnLEIGHT_14;
            MapEvent17 = FnTOTWO_17;
            MapEvent18 = FnLAVAA_18;
            MapEvent19 = FnLAVAB_19;
            MapEvent1A = FnLAVAHALF_1A;
            MapEvent1B = FnLAVADEAD_1B;
            MapEvent1C = FnPIT_1C;
            MapEvent1D = FnWHALF_1D;
            MapEvent1E = FnWQRTRA_1E;
            MapEvent1F = FnWQRTRB_1F;
            MapEvent20 = FnWDEAD_20;
            MapEvent21 = FnILL_21;
            MapEvent22 = FnWARN_22;
            MapEvent23 = FnBLOC_23;
            MapEvent24 = FnNPCA_24;
            MapEvent25 = FnNPCB_25;
            MapEvent26 = FnNPCC_26;
            MapEvent27 = FnRUNE_27;
            MapEvent28 = FnFTNFFFG_28;
            MapEvent29 = FnFTNDZ_29;
            MapEvent2A = FnFTNI_2A;
            MapEvent2B = FnFTNAN_2B;
            MapEvent2C = FnFTNEZ_2C;
            MapEvent2D = FnFTNHZ_2D;
            MapEvent2E = FnFTNBF_2E;
            MapEvent2F = FnFTNKZ_2F;
            MapEvent30 = FnWFT_30;
            MapEvent31 = FnGUARDC_31;
            MapEvent32 = FnGUARDE_32;
            MapEvent33 = FnHOPESFRY_33;
            MapEvent34 = FnWEAPONE_34;
            MapEvent35 = FnWEAPTWO_35;
            MapEvent36 = FnSHADFALL_36;
            MapEvent37 = FnSETBA_37;
            MapEvent38 = FnSETBB_38;
            MapEvent39 = FnBATD_39;
            MapEvent3A = FnSETBC_3A;
            MapEvent3B = FnBATE_3B;
            MapEvent3C = FnSETBD_3C;
            MapEvent3D = FnSETBE_3D;
            MapEvent3E = FnSEBF_3E;
            MapEvent3F = FnSETBG_3F;
            MapEvent40 = FnSETBH_40;
            MapEvent41 = FnPARTYCT_41;
            MapEvent42 = FnTELEWP_42;
            MapEvent43 = FnOUTTEXT_43;
            MapEvent44 = FnCHK_44;
            MapEvent45 = FnPTYCHK_45;
            MapEvent46 = FnSICCLU_46;
            MapEvent47 = FnTXTSP_47;
        }
        
        // === Strings ================================================
        private const string String03FC = "The ebb tide drags you downstream.";
        private const string String041F = "A huge sea bird picks you up.";
        private const string String043D = "The portal to your fate lies elsewhere.";
        private const string String0465 = "The walls along this corridor seem weakened by the lava.";
        private const string String049E = "A cyclone races across the water lifting you.";
        private const string String04CC = "The lava erupts and uproots you.";
        private const string String04ED = "Malos senses your presence and throws you off track.";
        private const string String0522 = "The hot lava sears you.";
        private const string String053A = "The lava crust breaks under your weight and you are injured.";
        private const string String0577 = "A fountain of lava engulfs you.";
        private const string String0597 = "You step into a bottomless pit and fall to your death.";
        private const string String05CE = "You are able to kill a creature that attacks you, but you are injured.";
        private const string String0615 = "A whirlpool dashes you against some rocks.";
        private const string String0640 = "A water creature drags you to your death.";
        private const string String066A = "A water creature emerges from the depths and destroys the party ahead.";
        private const string String06B1 = "The undertow prevents you from crossing the water.";
        private const string String06E4 = "I must find Thorzil!  His poison stash must be close to the way out.";
        private const string String0729 = "'The elemental path is ever changing. Trust not the discoveries of your brethren for yours may differ in location and occurence.'";
        private const string String07AB = "A warrior barges past 'The fountains must hold a secret.'";
        private const string String07E5 = "You see runes on the wall.";
        private const string String0800 = "Pluthros sees all and may deviously change the order of the switches every time you return to Ashakkar.";
        private const string String0868 = "The crystal blue waters of the fountain heal and restore you.";
        private const string String08A6 = "Juvalad senses your presence and throws you off course.";
        private const string String08DE = "You find Thorzil hiding in the fountain and nab him. In order to spare his life, he offers to activate the previously disguised portal to his poison stash and promises you a sure fire method of defeating Juvalad.";
        private const string String09B3 = "You secure him to the fountain and begin your search for the portal.";
        private const string String09F8 = "The waters have already been poisoned by Thorzil. You feel your health diminish before you can cure.";
        private const string String0A5D = "Thorzil has poisoned the waters of Avalonian Fountain.  You become gravely weak.";
        private const string String0AAE = "You hear the sound of flowing water where none was before.";
        private const string String0AE9 = "You find Thorzil hiding in what was a fountain and nab him. In order to spare his life, he offers to activate the previously disguised portal to his poison stash and promises you a sure fire method of defeating Juvalad.";
        private const string String0BC5 = "What was once a fountain is now dry.";
        private const string String0BEA = "The waters of Tribute Fountain have a tart taste and you become ill.";
        private const string String0C2F = "You see the rubble of what was once a fountain.";
        private const string String0C5F = "Some fountains seem unnaturally quiet all of a sudden.";
        private const string String0C96 = "What used to be a fountain is now a dry basin.";
        private const string String0CC5 = "The soothing waters swirl around you as you feel your health and mana increase.";
        private const string String0D15 = "The guard notices your full purse and helps himself to your gold. As he fumbles with your money, you lean over and throw the switch on the wall.";
        private const string String0DA6 = "The vacant room was once a guard shack.";
        private const string String0DCE = "The kaalroth guard watches in amazement as your weapon glows with the colors of the rainbow.";
        private const string String0E2B = "While his eyes are fixated, you lean over and throw the switch, hoping that it unlocks Celestia's cell.";
        private const string String0E93 = "With nothing to distract the kaalroth guard, he immediately attacks and kills you for your intrusion.";
        private const string String0EF9 = "The guard room is now an abandoned storage area.";
        private const string String0F2A = "The room shows signs of someone leaving in a hurry.";
        private const string String0F5E = "You have thrown the correct switches to unlock the cell, but it appears that Celestia is gone.  Your eyes fall upon the medallion which she coveted.";
        private const string String0FF3 = "Your cunning tactics have freed Celestia from her prison.";
        private const string String102D = "As a reward she gives you Hope's Fury which she explains is a medallion that will help protect you in your fight against the Dralkarian Pluthros.";
        private const string String10BF = "Your treachery has lead you to Celestia's cell.  You have successfully thrown the switches to lock her in.";
        private const string String112A = "You reach and grab the medallion from around her neck.  You now possess Hope's Fury and move on to meet the Dralkarian Pluthros.";
        private const string String11AB = "Nasty monsters still roam the empty corridor.";
        private const string String11D9 = "You see monsters guarding another flask and realize that Thorzil must have had more poison hidden.";
        private const string String123C = "Thorzil leads you to where he has hidden the poison. The monsters guarding the stash immediately attack in order to prevent you from taking their keep.";
        private const string String12D4 = "Thorzil leads you to where he has hidden the poison. He bids you to kill the guards in order to gain the possession which will aid you in killing Juvalad.";
        private const string String136F = "Thorzil has moved his poison stash.";
        private const string String1393 = "You are ambushed by the guards protecting the lock switch on the wall.  You must successfully destroy them in order to throw the switch.";
        private const string String141C = "You have no chance to get near the switch in the guardhouse.";
        private const string String1459 = "You are ambushed by the guards protecting the lock switch on the wall. You must successfully destroy them in order to throw the switch.";
        private const string String14E1 = "You may continue your quest.";
        private const string String14FE = "Proceed single file to sneak past Juvalad's gate guards.";
        private const string String1537 = "Proceed south to meet your fate.";
        private const string String1558 = "Thorzil appears before you.";
        private const string String1574 = "'You have done well so far weaklings! But I shall finish my work without your interference!'";
        private const string String15D1 = "Thorzil manages to get away, but not without leaving his mark.";
        private const string String1610 = "Enter to meet your Fate!";
        private const string String1629 = "You see the sparkle of a weapon embedded in the crusted lava. It surprises you how easily the weapon comes free and you recall a rumor about a special weapon that might aid you in defeating Malos.";
        private const string String16EE = "You find nothing unusual in the alcove.";
        private const string String1716 = "Malos has again attempted to hide the Ice Flame.";
        private const string String1747 = "As you turn to leave your hear the hideous laughter of Pluthros.";
        private const string String1788 = "'Fools! You will never complete your task! I have again foiled your attempt at the correct switches!'";
        
        // === Functions ================================================
        private void FnTE_01(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x0B, 0x01, 0x39, 0x03, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnTOFOUR_02(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFlag(player, 0x02, 0x9E, 0x00);
            L0017: SetFlag(player, 0x02, 0x9F, 0x00);
            L002B: SetFlag(player, 0x02, 0xA1, 0x00);
            L003F: SetFlag(player, 0x02, 0xA0, 0x00);
            L0053: SetFlag(player, 0x02, 0xA7, 0x00);
            L0067: SetFlag(player, 0x02, 0xA2, 0x00);
            L007B: SetFlag(player, 0x02, 0xA3, 0x00);
            L008F: SetFlag(player, 0x02, 0xA4, 0x00);
            L00A3: SetFlag(player, 0x02, 0xA5, 0x00);
            L00B7: SetFlag(player, 0x02, 0xA6, 0x00);
            L00CB: SetFlag(player, 0x02, 0xA8, 0x00);
            L00DF: TeleportParty(player, 0x0B, 0x04, 0x45, 0x00, isForwardMove);
            L00F9: return; // RETURN;
        }

        private void FnTC_03(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x0B, 0x01, 0x6C, 0x00, isForwardMove);
            L001D: return; // RETURN;
        }

        private void FnTAA_04(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x0B, 0x02, 0xAF, 0x00, isForwardMove);
            L001D: return; // RETURN;
        }

        private void FnTEIGHTA_05(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x02);
            L0007: PushStack(player, 0x00);
0171  000A C4 5E 06  les bx, [bp+0x6]
0174  000D 26 FF 5F 04  call far word [es:bx+0x4]
            L0011: cx = PopStack(player);
            L0012: cx = PopStack(player);
            L0013: RefreshCompareFlags(ax);
            L0015: if (JumpNotEqual) goto L008A;
            L0017: Compare(GetGuild(player), 0x0004);
            L0021: if (JumpEqual) goto L003B;
            L0023: Compare(GetGuild(player), 0x0003);
            L002D: if (JumpEqual) goto L003B;
            L002F: Compare(GetGuild(player), 0x0001);
            L0039: if (JumpNotEqual) goto L0076;
            L003B: Compare(GetCurrentTile(player), 0x0041);
            L0045: if (JumpEqual) goto L0053;
            L0047: Compare(ax, 0x00E1);
            L004A: if (JumpEqual) goto L0053;
            L004C: Compare(ax, 0x00F7);
            L004F: if (JumpEqual) goto L005B;
            L0051: goto L0076;
            L0053: PushStack(player, 0x00);
01BD  0056 B8 7F 00  mov ax, 0x7f
            L0059: goto L0062;
            L005B: TeleportParty(player, 0x0B, 0x01, 0x9A, 0x01, isForwardMove);
            L0076: SetFlag(player, 0x00, 0x02, 0x01);
            L008A: return; // RETURN;
        }

        private void FnTEIGHTB_06(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x02);
            L0007: PushStack(player, 0x00);
01FD  000A C4 5E 06  les bx, [bp+0x6]
0200  000D 26 FF 5F 04  call far word [es:bx+0x4]
            L0011: cx = PopStack(player);
            L0012: cx = PopStack(player);
            L0013: RefreshCompareFlags(ax);
            L0015: if (JumpNotEqual) goto L0089;
            L0017: Compare(GetGuild(player), 0x0002);
            L0021: if (JumpEqual) goto L003A;
            L0023: Compare(GetGuild(player), 0x0005);
            L002D: if (JumpEqual) goto L003A;
            L002F: RefreshCompareFlags(GetGuild(player));
            L0038: if (JumpNotEqual) goto L0075;
            L003A: Compare(GetCurrentTile(player), 0x0043);
            L0044: if (JumpEqual) goto L0052;
            L0046: Compare(ax, 0x00C3);
            L0049: if (JumpEqual) goto L0052;
            L004B: Compare(ax, 0x00CC);
            L004E: if (JumpEqual) goto L005A;
            L0050: goto L0075;
            L0052: PushStack(player, 0x00);
0248  0055 B8 7F 00  mov ax, 0x7f
            L0058: goto L0061;
            L005A: TeleportParty(player, 0x0B, 0x01, 0x9A, 0x01, isForwardMove);
            L0075: SetFlag(player, 0x00, 0x02, 0x01);
            L0089: return; // RETURN;
        }

        private void FnTTWO_07(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String03FC); // The ebb tide drags you downstream.
            L0010: TeleportParty(player, 0x0B, 0x01, 0xF4, 0x03, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnTBB_08(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x0B, 0x01, 0x4D, 0x03, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnTSIXW_09(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String041F); // A huge sea bird picks you up.
            L0010: TeleportParty(player, 0x0B, 0x01, 0x25, 0x02, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnTB_0A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x0B, 0x02, 0xEA, 0x02, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnTCC_0B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x0B, 0x01, 0xCC, 0x01, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnTPRTEE_0C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x0B, 0x01, 0xF1, 0x03, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnTTENC_0D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetGuild(player), 0x0005);
            L000D: if (JumpEqual) goto L001A;
            L000F: RefreshCompareFlags(GetGuild(player));
            L0018: if (JumpNotEqual) goto L0044;
0372  001A FF 76 08  push word [bp+0x8]
0375  001D FF 76 06  push word [bp+0x6]
0378  0020 0E     push cs
0379  0021 E8 3B 18  call 0x185f
            L0024: // NOP
            L0025: cx = PopStack(player);
            L0026: cx = PopStack(player);
            L0027: TeleportParty(player, 0x0B, 0x04, 0xB5, 0x02, isForwardMove);
            L0042: goto L0051;
            L0044: ShowMessage(player, String043D); // The portal to your fate lies elsewhere.
            L0051: return; // RETURN;
        }

        private void FnTDD_0E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x0B, 0x01, 0xE6, 0x02, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnTH_0F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x0B, 0x02, 0x3B, 0x02, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnCLUE_10(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0465); // The walls along this corridor seem weakened by the lava.
            L0010: return; // RETURN;
        }

        private void FnWEIGHT_11(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String049E); // A cyclone races across the water lifting you.
            L0010: TeleportParty(player, 0x0B, 0x01, 0x7F, 0x00, isForwardMove);
            L002A: return; // RETURN;
        }

        private void FnLNINE_12(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String04CC); // The lava erupts and uproots you.
            L0010: TeleportParty(player, 0x0B, 0x01, 0xF4, 0x03, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnLEIGHT_14(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String04ED); // Malos senses your presence and throws you off track.
            L0010: TeleportParty(player, 0x0B, 0x01, 0x7F, 0x00, isForwardMove);
            L002A: return; // RETURN;
        }

        private void FnTOTWO_17(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x0B, 0x04, 0xBB, 0x02, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnLAVAA_18(ServerPlayer player, bool isForwardMove) {
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
04E6  0035 C4 5E 06  les bx, [bp+0x6]
04E9  0038 26 FF 5F 04  call far word [es:bx+0x4]
            L003C: cx = PopStack(player);
            L003D: cx = PopStack(player);
            L003E: RefreshCompareFlags(ax);
            L0040: if (JumpNotEqual) goto L0070;
            L0042: ShowMessage(player, String0522); // The hot lava sears you.
0500  004F FF 76 08  push word [bp+0x8]
0503  0052 FF 76 06  push word [bp+0x6]
0506  0055 0E     push cs
0507  0056 E8 2C 17  call 0x1785
            L0059: // NOP
            L005A: cx = PopStack(player);
            L005B: cx = PopStack(player);
            L005C: SetFlag(player, 0x00, 0x02, 0x01);
            L0070: return; // RETURN;
        }

        private void FnLAVAB_19(ServerPlayer player, bool isForwardMove) {
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
0559  0036 C4 5E 06  les bx, [bp+0x6]
055C  0039 26 FF 5F 04  call far word [es:bx+0x4]
            L003D: cx = PopStack(player);
            L003E: cx = PopStack(player);
            L003F: RefreshCompareFlags(ax);
            L0041: if (JumpNotEqual) goto L0071;
            L0043: ShowMessage(player, String0522); // The hot lava sears you.
0573  0050 FF 76 08  push word [bp+0x8]
0576  0053 FF 76 06  push word [bp+0x6]
0579  0056 0E     push cs
057A  0057 E8 B9 16  call 0x1713
            L005A: // NOP
            L005B: cx = PopStack(player);
            L005C: cx = PopStack(player);
            L005D: SetFlag(player, 0x00, 0x02, 0x01);
            L0071: return; // RETURN;
        }

        private void FnLAVAHALF_1A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetNoHealZone(player);
            L000B: PushStack(player, 0x02);
            L000F: PushStack(player, 0x00);
05A8  0012 C4 5E 06  les bx, [bp+0x6]
05AB  0015 26 FF 5F 04  call far word [es:bx+0x4]
            L0019: cx = PopStack(player);
            L001A: cx = PopStack(player);
            L001B: RefreshCompareFlags(ax);
            L001D: if (JumpNotEqual) goto L0057;
            L001F: ShowMessage(player, String053A); // The lava crust breaks under your weight and you are injured.
            L002C: ax = GetMaxHits(player);
            L0033: bx = 0x0002;
            L0036: dx = ax % bx; ax = ax / bx;
            L0039: DamagePlayer(player, ax);
            L0043: SetFlag(player, 0x00, 0x02, 0x01);
            L0057: return; // RETURN;
        }

        private void FnLAVADEAD_1B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0577); // A fountain of lava engulfs you.
05FF  0010 FF 76 08  push word [bp+0x8]
0602  0013 FF 76 06  push word [bp+0x6]
0605  0016 0E     push cs
0606  0017 E8 C0 15  call 0x15da
            L001A: // NOP
            L001B: cx = PopStack(player);
            L001C: cx = PopStack(player);
            L001D: return; // RETURN;
        }

        private void FnPIT_1C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0597); // You step into a bottomless pit and fall to your death.
061E  0010 FF 76 08  push word [bp+0x8]
0621  0013 FF 76 06  push word [bp+0x6]
0624  0016 0E     push cs
0625  0017 E8 A1 15  call 0x15bb
            L001A: // NOP
            L001B: cx = PopStack(player);
            L001C: cx = PopStack(player);
            L001D: return; // RETURN;
        }

        private void FnWHALF_1D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetNoHealZone(player);
            L000B: PushStack(player, 0x02);
            L000F: PushStack(player, 0x00);
063F  0012 C4 5E 06  les bx, [bp+0x6]
0642  0015 26 FF 5F 04  call far word [es:bx+0x4]
            L0019: cx = PopStack(player);
            L001A: cx = PopStack(player);
            L001B: RefreshCompareFlags(ax);
            L001D: if (JumpNotEqual) goto L0057;
            L001F: ShowMessage(player, String05CE); // You are able to kill a creature that attacks you, but you are injured.
            L002C: ax = GetMaxHits(player);
            L0033: bx = 0x0002;
            L0036: dx = ax % bx; ax = ax / bx;
            L0039: DamagePlayer(player, ax);
            L0043: SetFlag(player, 0x00, 0x02, 0x01);
            L0057: return; // RETURN;
        }

        private void FnWQRTRA_1E(ServerPlayer player, bool isForwardMove) {
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
06BB  0035 C4 5E 06  les bx, [bp+0x6]
06BE  0038 26 FF 5F 04  call far word [es:bx+0x4]
            L003C: cx = PopStack(player);
            L003D: cx = PopStack(player);
            L003E: RefreshCompareFlags(ax);
            L0040: if (JumpNotEqual) goto L0070;
            L0042: ShowMessage(player, String0615); // A whirlpool dashes you against some rocks.
06D5  004F FF 76 08  push word [bp+0x8]
06D8  0052 FF 76 06  push word [bp+0x6]
06DB  0055 0E     push cs
06DC  0056 E8 57 15  call 0x15b0
            L0059: // NOP
            L005A: cx = PopStack(player);
            L005B: cx = PopStack(player);
            L005C: SetFlag(player, 0x00, 0x02, 0x01);
            L0070: return; // RETURN;
        }

        private void FnWQRTRB_1F(ServerPlayer player, bool isForwardMove) {
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
072E  0036 C4 5E 06  les bx, [bp+0x6]
0731  0039 26 FF 5F 04  call far word [es:bx+0x4]
            L003D: cx = PopStack(player);
            L003E: cx = PopStack(player);
            L003F: RefreshCompareFlags(ax);
            L0041: if (JumpNotEqual) goto L0071;
            L0043: ShowMessage(player, String0615); // A whirlpool dashes you against some rocks.
0748  0050 FF 76 08  push word [bp+0x8]
074B  0053 FF 76 06  push word [bp+0x6]
074E  0056 0E     push cs
074F  0057 E8 E4 14  call 0x153e
            L005A: // NOP
            L005B: cx = PopStack(player);
            L005C: cx = PopStack(player);
            L005D: SetFlag(player, 0x00, 0x02, 0x01);
            L0071: return; // RETURN;
        }

        private void FnWDEAD_20(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0640); // A water creature drags you to your death.
077B  0010 FF 76 08  push word [bp+0x8]
077E  0013 FF 76 06  push word [bp+0x6]
0781  0016 0E     push cs
0782  0017 E8 44 14  call 0x145e
            L001A: // NOP
            L001B: cx = PopStack(player);
            L001C: cx = PopStack(player);
            L001D: return; // RETURN;
        }

        private void FnILL_21(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
078D  0003 FF 76 08  push word [bp+0x8]
0790  0006 FF 76 06  push word [bp+0x6]
0793  0009 0E     push cs
0794  000A E8 5A 14  call 0x1467
            L000D: // NOP
            L000E: cx = PopStack(player);
            L000F: cx = PopStack(player);
            L0010: return; // RETURN;
        }

        private void FnWARN_22(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String066A); // A water creature emerges from the depths and destroys the party ahead.
            L0010: return; // RETURN;
        }

        private void FnBLOC_23(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String06B1); // The undertow prevents you from crossing the water.
07BE  0010 FF 76 08  push word [bp+0x8]
07C1  0013 FF 76 06  push word [bp+0x6]
07C4  0016 0E     push cs
07C5  0017 E8 4C 14  call 0x1466
            L001A: // NOP
            L001B: cx = PopStack(player);
            L001C: cx = PopStack(player);
            L001D: return; // RETURN;
        }

        private void FnNPCA_24(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0029);
            L0010: ShowMessage(player, String06E4); // I must find Thorzil!  His poison stash must be close to the way out.
            L001D: return; // RETURN;
        }

        private void FnNPCB_25(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x02, 0xB2));
            L0016: if (JumpNotEqual) goto L0032;
            L0018: ShowPortrait(player, 0x0016);
            L0025: ShowMessage(player, String0729); // 'The elemental path is ever changing. Trust not the discoveries of your brethren for yours may differ in location and occurence.'
            L0032: return; // RETURN;
        }

        private void FnNPCC_26(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0x9E), 0x0001);
            L0017: if (JumpNotEqual) goto L0033;
            L0019: ShowPortrait(player, 0x0014);
            L0026: ShowMessage(player, String07AB); // A warrior barges past 'The fountains must hold a secret.'
            L0033: return; // RETURN;
        }

        private void FnRUNE_27(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String07E5); // You see runes on the wall.
            L0010: ShowRunes(player, String0800); // Pluthros sees all and may deviously change the order of the switches every time you return to Ashakkar.
            L001D: return; // RETURN;
        }

        private void FnFTNFFFG_28(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0x9E), 0x0001);
            L0017: if (JumpEqual) goto L001C;
            L0019: goto L0099;
            L001B: // NOP
0890  001C FF 76 08  push word [bp+0x8]
0893  001F FF 76 06  push word [bp+0x6]
0896  0022 0E     push cs
0897  0023 E8 45 13  call 0x136b
            L0026: // NOP
            L0027: cx = PopStack(player);
            L0028: cx = PopStack(player);
            L0029: Compare(GetFlag(player, 0x02, 0x9F), 0x0001);
            L003D: if (JumpEqual) goto L0055;
            L003F: Compare(GetFlag(player, 0x02, 0xA1), 0x0001);
            L0053: if (JumpNotEqual) goto L0071;
            L0055: ShowMessage(player, String0868); // The crystal blue waters of the fountain heal and restore you.
08D6  0062 FF 76 08  push word [bp+0x8]
08D9  0065 FF 76 06  push word [bp+0x6]
08DC  0068 0E     push cs
08DD  0069 E8 7A 13  call 0x13e6
            L006C: // NOP
            L006D: cx = PopStack(player);
            L006E: cx = PopStack(player);
            L006F: goto L0099;
            L0071: ShowMessage(player, String08A6); // Juvalad senses your presence and throws you off course.
            L007E: TeleportParty(player, 0x0A, 0x03, 0x9F, 0x01, isForwardMove);
            L0099: return; // RETURN;
        }

        private void FnFTNDZ_29(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x02);
            L0007: PushStack(player, 0x00);
0919  000A C4 5E 06  les bx, [bp+0x6]
091C  000D 26 FF 5F 04  call far word [es:bx+0x4]
            L0011: cx = PopStack(player);
            L0012: cx = PopStack(player);
            L0013: RefreshCompareFlags(ax);
            L0015: if (JumpEqual) goto L001A;
            L0017: goto L0102;
0929  001A FF 76 08  push word [bp+0x8]
092C  001D FF 76 06  push word [bp+0x6]
092F  0020 0E     push cs
0930  0021 E8 AC 12  call 0x12d0
            L0024: // NOP
            L0025: cx = PopStack(player);
            L0026: cx = PopStack(player);
            L0027: SetFlag(player, 0x02, 0xA7, 0x01);
            L003C: Compare(GetFlag(player, 0x02, 0xA3), 0x0001);
            L0050: if (JumpEqual) goto L0055;
            L0052: goto L00D4;
            L0055: Compare(GetFlag(player, 0x02, 0xA4), 0x0001);
            L0069: if (JumpNotEqual) goto L00D4;
            L006B: Compare(GetFlag(player, 0x02, 0xA5), 0x0001);
            L007F: if (JumpNotEqual) goto L00D4;
            L0081: Compare(GetFlag(player, 0x02, 0xA6), 0x0001);
            L0095: if (JumpNotEqual) goto L00D4;
            L0097: Compare(GetFlag(player, 0x02, 0xA0), 0x0001);
            L00AB: if (JumpNotEqual) goto L00D4;
            L00AD: ShowMessage(player, String08DE); // You find Thorzil hiding in the fountain and nab him. In order to spare his life, he offers to activate the previously disguised portal to his poison stash and promises you a sure fire method of defeating Juvalad.
            L00BA: ShowMessage(player, String09B3); // You secure him to the fountain and begin your search for the portal.
            L00C7: PushStack(player, 0x01);
            L00CB: PushStack(player, 0xA8);
09DE  00CF B8 02 00  mov ax, 0x2
            L00D2: goto L00F8;
            L00D4: ShowMessage(player, String09F8); // The waters have already been poisoned by Thorzil. You feel your health diminish before you can cure.
09F0  00E1 FF 76 08  push word [bp+0x8]
09F3  00E4 FF 76 06  push word [bp+0x6]
09F6  00E7 0E     push cs
09F7  00E8 E8 3C 12  call 0x1327
            L00EB: // NOP
            L00EC: cx = PopStack(player);
            L00ED: cx = PopStack(player);
            L00EE: SetFlag(player, 0x00, 0x02, 0x01);
            L0102: return; // RETURN;
        }

        private void FnFTNI_2A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0A16  0003 FF 76 08  push word [bp+0x8]
0A19  0006 FF 76 06  push word [bp+0x6]
0A1C  0009 0E     push cs
0A1D  000A E8 BF 11  call 0x11cc
            L000D: // NOP
            L000E: cx = PopStack(player);
            L000F: cx = PopStack(player);
            L0010: Compare(GetFlag(player, 0x02, 0xA0), 0x0001);
            L0024: if (JumpNotEqual) goto L0042;
            L0026: ShowMessage(player, String0868); // The crystal blue waters of the fountain heal and restore you.
0A46  0033 FF 76 08  push word [bp+0x8]
0A49  0036 FF 76 06  push word [bp+0x6]
0A4C  0039 0E     push cs
0A4D  003A E8 0A 12  call 0x1247
            L003D: // NOP
            L003E: cx = PopStack(player);
            L003F: cx = PopStack(player);
            L0040: goto L006A;
            L0042: ShowMessage(player, String08A6); // Juvalad senses your presence and throws you off course.
            L004F: TeleportParty(player, 0x0A, 0x03, 0x9F, 0x01, isForwardMove);
            L006A: return; // RETURN;
        }

        private void FnFTNAN_2B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x01);
            L0007: PushStack(player, 0x00);
0A89  000A C4 5E 06  les bx, [bp+0x6]
0A8C  000D 26 FF 5F 04  call far word [es:bx+0x4]
            L0011: cx = PopStack(player);
            L0012: cx = PopStack(player);
            L0013: RefreshCompareFlags(ax);
            L0015: if (JumpEqual) goto L001A;
            L0017: goto L00A5;
0A99  001A FF 76 08  push word [bp+0x8]
0A9C  001D FF 76 06  push word [bp+0x6]
0A9F  0020 0E     push cs
0AA0  0021 E8 3C 11  call 0x1160
            L0024: // NOP
            L0025: cx = PopStack(player);
            L0026: cx = PopStack(player);
            L0027: ShowMessage(player, String0A5D); // Thorzil has poisoned the waters of Avalonian Fountain.  You become gravely weak.
0AB3  0034 FF 76 08  push word [bp+0x8]
0AB6  0037 FF 76 06  push word [bp+0x6]
0AB9  003A 0E     push cs
0ABA  003B E8 C0 11  call 0x11fe
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
            L0098: ShowMessage(player, String0AAE); // You hear the sound of flowing water where none was before.
            L00A5: return; // RETURN;
        }

        private void FnFTNEZ_2C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFlag(player, 0x02, 0xA4, 0x01);
            L0018: Compare(GetFlag(player, 0x02, 0xA3), 0x0001);
            L002C: if (JumpEqual) goto L0031;
            L002E: goto L00CA;
            L0031: Compare(GetFlag(player, 0x02, 0xA7), 0x0001);
            L0045: if (JumpEqual) goto L004A;
            L0047: goto L00CA;
            L004A: Compare(GetFlag(player, 0x02, 0xA5), 0x0001);
            L005E: if (JumpNotEqual) goto L00CA;
            L0060: Compare(GetFlag(player, 0x02, 0xA6), 0x0001);
            L0074: if (JumpNotEqual) goto L00CA;
            L0076: Compare(GetFlag(player, 0x02, 0xA1), 0x0001);
            L008A: if (JumpNotEqual) goto L00CA;
0BB2  008C FF 76 08  push word [bp+0x8]
0BB5  008F FF 76 06  push word [bp+0x6]
0BB8  0092 0E     push cs
0BB9  0093 E8 23 10  call 0x10b9
            L0096: // NOP
            L0097: cx = PopStack(player);
            L0098: cx = PopStack(player);
            L0099: ShowMessage(player, String0AE9); // You find Thorzil hiding in what was a fountain and nab him. In order to spare his life, he offers to activate the previously disguised portal to his poison stash and promises you a sure fire method of defeating Juvalad.
            L00A6: ShowMessage(player, String09B3); // You secure him to the fountain and begin your search for the portal.
            L00B3: SetFlag(player, 0x02, 0xA8, 0x01);
            L00C8: goto L00D7;
            L00CA: ShowMessage(player, String0BC5); // What was once a fountain is now dry.
            L00D7: return; // RETURN;
        }

        private void FnFTNHZ_2D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x02);
            L0007: PushStack(player, 0x00);
0C09  000A C4 5E 06  les bx, [bp+0x6]
0C0C  000D 26 FF 5F 04  call far word [es:bx+0x4]
            L0011: cx = PopStack(player);
            L0012: cx = PopStack(player);
            L0013: RefreshCompareFlags(ax);
            L0015: if (JumpNotEqual) goto L0068;
            L0017: Compare(GetFlag(player, 0x02, 0x9E), 0x0001);
            L002B: if (JumpNotEqual) goto L0068;
0C2C  002D FF 76 08  push word [bp+0x8]
0C2F  0030 FF 76 06  push word [bp+0x6]
0C32  0033 0E     push cs
0C33  0034 E8 A9 0F  call 0xfe0
            L0037: // NOP
            L0038: cx = PopStack(player);
            L0039: cx = PopStack(player);
            L003A: ShowMessage(player, String0BEA); // The waters of Tribute Fountain have a tart taste and you become ill.
0C46  0047 FF 76 08  push word [bp+0x8]
0C49  004A FF 76 06  push word [bp+0x6]
0C4C  004D 0E     push cs
0C4D  004E E8 E6 0F  call 0x1037
            L0051: // NOP
            L0052: cx = PopStack(player);
            L0053: cx = PopStack(player);
            L0054: SetFlag(player, 0x00, 0x02, 0x01);
            L0068: return; // RETURN;
        }

        private void FnFTNBF_2E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFlag(player, 0x02, 0x9E, 0x00);
            L0017: ShowMessage(player, String0C2F); // You see the rubble of what was once a fountain.
            L0024: ShowMessage(player, String0C5F); // Some fountains seem unnaturally quiet all of a sudden.
            L0031: return; // RETURN;
        }

        private void FnFTNKZ_2F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0x9E), 0x0001);
            L0017: if (JumpNotEqual) goto L003B;
            L0019: SetFlag(player, 0x02, 0xA3, 0x01);
            L002E: ShowMessage(player, String0C96); // What used to be a fountain is now a dry basin.
            L003B: return; // RETURN;
        }

        private void FnWFT_30(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0CC5); // The soothing waters swirl around you as you feel your health and mana increase.
0CE9  0010 FF 76 08  push word [bp+0x8]
0CEC  0013 FF 76 06  push word [bp+0x6]
0CEF  0016 0E     push cs
0CF0  0017 E8 67 0F  call 0xf81
            L001A: // NOP
            L001B: cx = PopStack(player);
            L001C: cx = PopStack(player);
            L001D: return; // RETURN;
        }

        private void FnGUARDC_31(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetAlignment(player));
            L000D: if (JumpEqual) goto L0012;
            L000F: goto L00FD;
            L0012: ShowPortrait(player, 0x0012);
            L001F: ModifyGold(player, 0xFFFF78BA);
            L0031: ShowMessage(player, String0D15); // The guard notices your full purse and helps himself to your gold. As he fumbles with your money, you lean over and throw the switch on the wall.
            L003E: Compare(GetFlag(player, 0x02, 0xAE), 0x0002);
            L0052: if (JumpNotEqual) goto L0097;
            L0054: Compare(GetFlag(player, 0x02, 0xAD), 0x0001);
            L0068: if (JumpEqual) goto L0080;
            L006A: Compare(GetFlag(player, 0x02, 0xAB), 0x0001);
            L007E: if (JumpNotEqual) goto L0097;
            L0080: SetFlag(player, 0x02, 0xAE, 0x03);
            L0095: goto L010A;
            L0097: Compare(GetFlag(player, 0x02, 0xAE), 0x0001);
            L00AB: if (JumpNotEqual) goto L00C8;
            L00AD: Compare(GetFlag(player, 0x02, 0xAA), 0x0001);
            L00C1: if (JumpNotEqual) goto L00C8;
0DBB  00C3 B8 02 00  mov ax, 0x2
            L00C6: goto L0083;
            L00C8: RefreshCompareFlags(GetFlag(player, 0x02, 0xAE));
            L00DB: if (JumpNotEqual) goto L00F8;
            L00DD: Compare(GetFlag(player, 0x02, 0xAC), 0x0001);
            L00F1: if (JumpNotEqual) goto L00F8;
0DEB  00F3 B8 01 00  mov ax, 0x1
            L00F6: goto L0083;
0DF0  00F8 B8 05 00  mov ax, 0x5
            L00FB: goto L0083;
            L00FD: ShowMessage(player, String0DA6); // The vacant room was once a guard shack.
            L010A: return; // RETURN;
        }

        private void FnGUARDE_32(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetAlignment(player));
            L000D: if (JumpNotEqual) goto L0060;
            L000F: ShowPortrait(player, 0x0007);
            L001C: Compare(GetFlag(player, 0x02, 0xAF), 0x0001);
            L0030: if (JumpNotEqual) goto L0044;
            L0032: ShowMessage(player, String0DCE); // The kaalroth guard watches in amazement as your weapon glows with the colors of the rainbow.
0E43  003F B8 2B 0E  mov ax, 0xe2b
            L0042: goto L0063;
            L0044: ShowMessage(player, String0E93); // With nothing to distract the kaalroth guard, he immediately attacks and kills you for your intrusion.
0E55  0051 FF 76 08  push word [bp+0x8]
0E58  0054 FF 76 06  push word [bp+0x6]
0E5B  0057 0E     push cs
0E5C  0058 E8 6A 0D  call 0xdc5
            L005B: // NOP
            L005C: cx = PopStack(player);
            L005D: cx = PopStack(player);
            L005E: goto L006D;
            L0060: ShowMessage(player, String0EF9); // The guard room is now an abandoned storage area.
            L006D: return; // RETURN;
        }

        private void FnHOPESFRY_33(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0xB1), 0x0001);
            L0017: if (JumpNotEqual) goto L0041;
            L0019: ax = HasItem(player, 0xC6);
            L0027: if (JumpEqual) goto L002F;
0E9C  0029 B8 2A 0F  mov ax, 0xf2a
            L002C: goto L00E2;
            L002F: GiveItem(player, 0xC6);
0EAE  003B B8 5E 0F  mov ax, 0xf5e
            L003E: goto L00E2;
            L0041: ShowPortrait(player, 0x0028);
            L004E: RefreshCompareFlags(GetAlignment(player));
            L0058: if (JumpNotEqual) goto L009F;
            L005A: SetFlag(player, 0x02, 0xB1, 0x01);
            L006F: AddExperience(player, 0x000B71B0);
            L0081: GiveItem(player, 0xC6);
            L008D: ShowMessage(player, String0FF3); // Your cunning tactics have freed Celestia from her prison.
0F0D  009A B8 2D 10  mov ax, 0x102d
            L009D: goto L00E2;
            L009F: SetFlag(player, 0x02, 0xB1, 0x01);
            L00B4: AddExperience(player, 0x000B71B0);
            L00C6: GiveItem(player, 0xC6);
            L00D2: ShowMessage(player, String10BF); // Your treachery has lead you to Celestia's cell.  You have successfully thrown the switches to lock her in.
            L00DF: ShowMessage(player, String112A); // You reach and grab the medallion from around her neck.  You now possess Hope's Fury and move on to meet the Dralkarian Pluthros.
            L00EC: return; // RETURN;
        }

        private void FnWEAPONE_34(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetGuild(player), 0x0001);
            L000D: if (JumpEqual) goto L001B;
            L000F: Compare(GetGuild(player), 0x0003);
            L0019: if (JumpNotEqual) goto L005D;
            L001B: Compare(GetFlag(player, 0x02, 0xB2), 0x0001);
            L002F: if (JumpNotEqual) goto L0050;
            L0031: ax = HasItem(player, 0xC9);
            L003F: if (JumpEqual) goto L0043;
            L0041: goto L005D;
0FA4  0043 FF 76 08  push word [bp+0x8]
0FA7  0046 FF 76 06  push word [bp+0x6]
0FAA  0049 0E     push cs
0FAB  004A E8 5D 0D  call 0xdaa
            L004D: // NOP
            L004E: goto L0068;
0FB1  0050 FF 76 08  push word [bp+0x8]
0FB4  0053 FF 76 06  push word [bp+0x6]
0FB7  0056 0E     push cs
0FB8  0057 E8 F9 0C  call 0xd53
            L005A: // NOP
            L005B: goto L0068;
0FBE  005D FF 76 08  push word [bp+0x8]
0FC1  0060 FF 76 06  push word [bp+0x6]
0FC4  0063 0E     push cs
0FC5  0064 E8 31 0D  call 0xd98
            L0067: // NOP
            L0068: cx = PopStack(player);
            L0069: cx = PopStack(player);
            L006A: return; // RETURN;
        }

        private void FnWEAPTWO_35(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetGuild(player), 0x0004);
            L000D: if (JumpEqual) goto L001A;
            L000F: RefreshCompareFlags(GetGuild(player));
            L0018: if (JumpNotEqual) goto L005C;
            L001A: Compare(GetFlag(player, 0x02, 0xB2), 0x0001);
            L002E: if (JumpNotEqual) goto L004F;
            L0030: ax = HasItem(player, 0xC9);
            L003E: if (JumpEqual) goto L0042;
            L0040: goto L005C;
100F  0042 FF 76 08  push word [bp+0x8]
1012  0045 FF 76 06  push word [bp+0x6]
1015  0048 0E     push cs
1016  0049 E8 F2 0C  call 0xd3e
            L004C: // NOP
            L004D: goto L0067;
101C  004F FF 76 08  push word [bp+0x8]
101F  0052 FF 76 06  push word [bp+0x6]
1022  0055 0E     push cs
1023  0056 E8 8E 0C  call 0xce7
            L0059: // NOP
            L005A: goto L0067;
1029  005C FF 76 08  push word [bp+0x8]
102C  005F FF 76 06  push word [bp+0x6]
102F  0062 0E     push cs
1030  0063 E8 C6 0C  call 0xd2c
            L0066: // NOP
            L0067: cx = PopStack(player);
            L0068: cx = PopStack(player);
            L0069: return; // RETURN;
        }

        private void FnSHADFALL_36(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0xA9), 0x0001);
            L0017: if (JumpNotEqual) goto L005E;
            L0019: ax = HasItem(player, 0xCA);
            L0027: if (JumpEqual) goto L002F;
1061  0029 B8 AB 11  mov ax, 0x11ab
            L002C: goto L00EB;
            L002F: ShowMessage(player, String11D9); // You see monsters guarding another flask and realize that Thorzil must have had more poison hidden.
1074  003C B8 88 13  mov ax, 0x1388
            L003F: PushStack(player, ax);
            L0040: PushStack(player, 0x00);
            L0043: PushStack(player, ax);
            L0044: PushStack(player, 0xA8);
            L0048: PushStack(player, 0xB7);
            L004C: PushStack(player, 0xCA);
1088  0050 C4 5E 06  les bx, [bp+0x6]
108B  0053 26 FF 9F D8 00  call far word [es:bx+0xd8]
1090  0058 83 C4 0C  add sp, 0xc
            L005B: goto L00F5;
            L005E: Compare(GetFlag(player, 0x02, 0xA8), 0x0001);
            L0072: if (JumpNotEqual) goto L0085;
            L0074: RefreshCompareFlags(GetAlignment(player));
            L007E: if (JumpNotEqual) goto L0085;
10B8  0080 B8 3C 12  mov ax, 0x123c
            L0083: goto L00AB;
            L0085: Compare(GetFlag(player, 0x02, 0xA8), 0x0001);
            L0099: if (JumpNotEqual) goto L00E8;
            L009B: Compare(GetAlignment(player), 0x0001);
            L00A6: if (JumpNotEqual) goto L00E8;
            L00A8: ShowMessage(player, String12D4); // Thorzil leads you to where he has hidden the poison. He bids you to kill the guards in order to gain the possession which will aid you in killing Juvalad.
            L00B5: SetFlag(player, 0x02, 0xA9, 0x01);
            L00CA: AddExperience(player, 0x000B71B0);
1114  00DC B8 10 27  mov ax, 0x2710
            L00DF: PushStack(player, ax);
            L00E0: PushStack(player, 0x00);
            L00E3: PushStack(player, ax);
            L00E4: PushStack(player, ax);
            L00E5: goto L004B;
            L00E8: ShowMessage(player, String136F); // Thorzil has moved his poison stash.
            L00F5: Compare(PartyCount(player), 0x0001);
            L0100: if (JumpNotEqual) goto L011E;
            L0102: AddEncounter(player, 0x01, 0x07);
            L0114: PushStack(player, 0x08);
1150  0118 B8 02 00  mov ax, 0x2
            L011B: goto L01B5;
            L011E: Compare(PartyCount(player), 0x0002);
            L0129: if (JumpNotEqual) goto L0154;
            L012B: AddEncounter(player, 0x01, 0x0C);
            L013D: AddEncounter(player, 0x02, 0x0C);
1187  014F B8 1C 00  mov ax, 0x1c
            L0152: goto L019F;
            L0154: AddEncounter(player, 0x01, 0x0C);
            L0166: AddEncounter(player, 0x02, 0x0C);
            L0178: AddEncounter(player, 0x03, 0x1C);
            L018A: AddEncounter(player, 0x04, 0x1C);
            L019C: AddEncounter(player, 0x05, 0x1D);
            L01AE: AddEncounter(player, 0x06, 0x1D);
            L01C0: return; // RETURN;
        }

        private void FnSETBA_37(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L002C;
            L0010: AddEncounter(player, 0x01, 0x28);
            L0022: PushStack(player, 0x20);
1220  0026 B8 02 00  mov ax, 0x2
            L0029: goto L00C7;
            L002C: Compare(PartyCount(player), 0x0002);
            L0037: if (JumpNotEqual) goto L0078;
            L0039: AddEncounter(player, 0x01, 0x20);
            L004B: AddEncounter(player, 0x02, 0x20);
            L005D: AddEncounter(player, 0x05, 0x21);
            L006F: PushStack(player, 0x22);
126D  0073 B8 06 00  mov ax, 0x6
            L0076: goto L00C7;
            L0078: AddEncounter(player, 0x01, 0x20);
            L008A: AddEncounter(player, 0x02, 0x20);
            L009C: AddEncounter(player, 0x03, 0x21);
            L00AE: AddEncounter(player, 0x04, 0x21);
            L00C0: AddEncounter(player, 0x05, 0x22);
            L00D2: return; // RETURN;
        }

        private void FnSETBB_38(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L002C;
            L0010: AddEncounter(player, 0x01, 0x1D);
            L0022: PushStack(player, 0x1E);
12F4  0026 B8 02 00  mov ax, 0x2
            L0029: goto L00D9;
            L002C: Compare(PartyCount(player), 0x0002);
            L0037: if (JumpNotEqual) goto L0078;
            L0039: AddEncounter(player, 0x01, 0x1E);
            L004B: AddEncounter(player, 0x02, 0x1F);
            L005D: AddEncounter(player, 0x03, 0x08);
            L006F: PushStack(player, 0x08);
1341  0073 B8 04 00  mov ax, 0x4
            L0076: goto L00D9;
            L0078: AddEncounter(player, 0x01, 0x1E);
            L008A: AddEncounter(player, 0x02, 0x1E);
            L009C: AddEncounter(player, 0x03, 0x1F);
            L00AE: AddEncounter(player, 0x04, 0x1F);
            L00C0: AddEncounter(player, 0x05, 0x09);
            L00D2: AddEncounter(player, 0x06, 0x09);
            L00E4: return; // RETURN;
        }

        private void FnBATD_39(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetAlignment(player), 0x0001);
            L000E: if (JumpEqual) goto L0013;
            L0010: goto L00C4;
            L0013: ShowMessage(player, String1393); // You are ambushed by the guards protecting the lock switch on the wall.  You must successfully destroy them in order to throw the switch.
            L0020: Compare(GetFlag(player, 0x02, 0xB0), 0x0001);
            L0034: if (JumpNotEqual) goto L0079;
            L0036: Compare(GetFlag(player, 0x02, 0xAC), 0x0001);
            L004A: if (JumpEqual) goto L0062;
            L004C: Compare(GetFlag(player, 0x02, 0xAB), 0x0001);
            L0060: if (JumpNotEqual) goto L0079;
            L0062: SetFlag(player, 0x02, 0xB0, 0x02);
            L0077: goto L00D1;
            L0079: RefreshCompareFlags(GetFlag(player, 0x02, 0xB0));
            L008C: if (JumpNotEqual) goto L00BF;
            L008E: Compare(GetFlag(player, 0x02, 0xAD), 0x0001);
            L00A2: if (JumpEqual) goto L00BA;
            L00A4: Compare(GetFlag(player, 0x02, 0xAA), 0x0001);
            L00B8: if (JumpNotEqual) goto L00BF;
146E  00BA B8 01 00  mov ax, 0x1
            L00BD: goto L0065;
1473  00BF B8 05 00  mov ax, 0x5
            L00C2: goto L0065;
            L00C4: ShowMessage(player, String141C); // You have no chance to get near the switch in the guardhouse.
            L00D1: Compare(PartyCount(player), 0x0001);
            L00DC: if (JumpNotEqual) goto L00F6;
            L00DE: PushStack(player, 0x01);
            L00E2: PushStack(player, ax);
1497  00E3 C4 5E 06  les bx, [bp+0x6]
149A  00E6 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L00EB: cx = PopStack(player);
            L00EC: cx = PopStack(player);
            L00ED: PushStack(player, 0x06);
14A5  00F1 B8 02 00  mov ax, 0x2
            L00F4: goto L0158;
            L00F6: Compare(PartyCount(player), 0x0002);
            L0101: if (JumpNotEqual) goto L011E;
            L0103: AddEncounter(player, 0x01, 0x03);
            L0115: PushStack(player, 0x03);
14CD  0119 B8 02 00  mov ax, 0x2
            L011C: goto L0146;
            L011E: PushStack(player, 0x01);
            L0122: PushStack(player, ax);
14D7  0123 C4 5E 06  les bx, [bp+0x6]
14DA  0126 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L012B: cx = PopStack(player);
            L012C: cx = PopStack(player);
            L012D: AddEncounter(player, 0x02, 0x01);
            L013F: AddEncounter(player, 0x05, 0x02);
            L0151: AddEncounter(player, 0x06, 0x02);
            L0163: return; // RETURN;
        }

        private void FnSETBC_3A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpEqual) goto L001D;
            L0010: Compare(PartyCount(player), 0x0002);
            L001B: if (JumpNotEqual) goto L005C;
            L001D: AddEncounter(player, 0x01, 0x19);
            L002F: AddEncounter(player, 0x02, 0x19);
            L0041: AddEncounter(player, 0x05, 0x1A);
            L0053: PushStack(player, 0x1B);
1570  0057 B8 06 00  mov ax, 0x6
            L005A: goto L0099;
            L005C: AddEncounter(player, 0x01, 0x1A);
            L006E: AddEncounter(player, 0x02, 0x1A);
            L0080: AddEncounter(player, 0x03, 0x1B);
            L0092: AddEncounter(player, 0x04, 0x1B);
            L00A4: return; // RETURN;
        }

        private void FnBATE_3B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetAlignment(player), 0x0001);
            L000E: if (JumpEqual) goto L0013;
            L0010: goto L00DF;
            L0013: ShowMessage(player, String1459); // You are ambushed by the guards protecting the lock switch on the wall. You must successfully destroy them in order to throw the switch.
            L0020: Compare(GetFlag(player, 0x02, 0xB0), 0x0002);
            L0034: if (JumpNotEqual) goto L0079;
            L0036: Compare(GetFlag(player, 0x02, 0xAD), 0x0001);
            L004A: if (JumpEqual) goto L0062;
            L004C: Compare(GetFlag(player, 0x02, 0xAB), 0x0001);
            L0060: if (JumpNotEqual) goto L0079;
            L0062: SetFlag(player, 0x02, 0xB0, 0x03);
            L0077: goto L00EC;
            L0079: Compare(GetFlag(player, 0x02, 0xB0), 0x0001);
            L008D: if (JumpNotEqual) goto L00AA;
            L008F: Compare(GetFlag(player, 0x02, 0xAA), 0x0001);
            L00A3: if (JumpNotEqual) goto L00AA;
1664  00A5 B8 02 00  mov ax, 0x2
            L00A8: goto L0065;
            L00AA: RefreshCompareFlags(GetFlag(player, 0x02, 0xB0));
            L00BD: if (JumpNotEqual) goto L00DA;
            L00BF: Compare(GetFlag(player, 0x02, 0xAC), 0x0001);
            L00D3: if (JumpNotEqual) goto L00DA;
1694  00D5 B8 01 00  mov ax, 0x1
            L00D8: goto L0065;
1699  00DA B8 05 00  mov ax, 0x5
            L00DD: goto L0065;
            L00DF: ShowMessage(player, String141C); // You have no chance to get near the switch in the guardhouse.
            L00EC: Compare(PartyCount(player), 0x0001);
            L00F7: if (JumpEqual) goto L0106;
            L00F9: Compare(PartyCount(player), 0x0002);
            L0104: if (JumpNotEqual) goto L0133;
            L0106: AddEncounter(player, 0x01, 0x05);
            L0118: AddEncounter(player, 0x02, 0x06);
            L012A: PushStack(player, 0x07);
16ED  012E B8 05 00  mov ax, 0x5
            L0131: goto L0170;
            L0133: AddEncounter(player, 0x01, 0x06);
            L0145: AddEncounter(player, 0x02, 0x06);
            L0157: AddEncounter(player, 0x03, 0x07);
            L0169: AddEncounter(player, 0x04, 0x07);
            L017B: return; // RETURN;
        }

        private void FnSETBD_3C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpEqual) goto L001D;
            L0010: Compare(PartyCount(player), 0x0002);
            L001B: if (JumpNotEqual) goto L0034;
            L001D: AddEncounter(player, 0x01, 0x10);
176B  002F B8 10 00  mov ax, 0x10
            L0032: goto L0049;
            L0034: AddEncounter(player, 0x01, 0x11);
            L0046: AddEncounter(player, 0x02, 0x11);
            L0058: AddEncounter(player, 0x05, 0x11);
            L006A: AddEncounter(player, 0x06, 0x11);
            L007C: return; // RETURN;
        }

        private void FnSETBE_3D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(player, 0x01, 0x17);
            L0015: AddEncounter(player, 0x02, 0x18);
            L0027: AddEncounter(player, 0x03, 0x23);
            L0039: AddEncounter(player, 0x04, 0x23);
            L004B: AddEncounter(player, 0x05, 0x24);
            L005D: AddEncounter(player, 0x06, 0x24);
            L006F: return; // RETURN;
        }

        private void FnSEBF_3E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L002C;
            L0010: AddEncounter(player, 0x01, 0x15);
            L0022: PushStack(player, 0x23);
1851  0026 B8 02 00  mov ax, 0x2
            L0029: goto L00C3;
            L002C: Compare(PartyCount(player), 0x0002);
            L0037: if (JumpNotEqual) goto L0074;
            L0039: AddEncounter(player, 0x01, 0x23);
            L004B: AddEncounter(player, 0x02, 0x23);
            L005D: AddEncounter(player, 0x05, 0x25);
189A  006F B8 23 00  mov ax, 0x23
            L0072: goto L00BF;
            L0074: AddEncounter(player, 0x01, 0x25);
            L0086: AddEncounter(player, 0x02, 0x25);
            L0098: AddEncounter(player, 0x04, 0x14);
            L00AA: AddEncounter(player, 0x05, 0x24);
            L00BC: AddEncounter(player, 0x06, 0x24);
            L00CE: return; // RETURN;
        }

        private void FnSETBG_3F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpEqual) goto L001D;
            L0010: Compare(PartyCount(player), 0x0002);
            L001B: if (JumpNotEqual) goto L0046;
            L001D: AddEncounter(player, 0x01, 0x23);
            L002F: AddEncounter(player, 0x02, 0x25);
193C  0041 B8 11 00  mov ax, 0x11
            L0044: goto L0091;
            L0046: AddEncounter(player, 0x01, 0x24);
            L0058: AddEncounter(player, 0x02, 0x24);
            L006A: AddEncounter(player, 0x03, 0x12);
            L007C: AddEncounter(player, 0x04, 0x12);
            L008E: AddEncounter(player, 0x05, 0x25);
            L00A0: return; // RETURN;
        }

        private void FnSETBH_40(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpEqual) goto L001D;
            L0010: Compare(PartyCount(player), 0x0002);
            L001B: if (JumpNotEqual) goto L004A;
            L001D: AddEncounter(player, 0x01, 0x05);
            L002F: AddEncounter(player, 0x02, 0x07);
            L0041: PushStack(player, 0x23);
19E2  0045 B8 04 00  mov ax, 0x4
            L0048: goto L0099;
            L004A: AddEncounter(player, 0x01, 0x06);
            L005C: AddEncounter(player, 0x02, 0x06);
            L006E: AddEncounter(player, 0x03, 0x07);
            L0080: AddEncounter(player, 0x04, 0x07);
            L0092: AddEncounter(player, 0x05, 0x24);
            L00A4: return; // RETURN;
        }

        private void FnPARTYCT_41(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L001F;
            L0010: ShowMessage(player, String14E1); // You may continue your quest.
            L001D: goto L003A;
            L001F: TeleportParty(player, 0x0B, 0x01, 0x39, 0x03, isForwardMove);
            L003A: return; // RETURN;
        }

        private void FnTELEWP_42(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x0B, 0x01, 0xF4, 0x03, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnOUTTEXT_43(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
1AA2  0003 FF 76 08  push word [bp+0x8]
1AA5  0006 FF 76 06  push word [bp+0x6]
1AA8  0009 0E     push cs
1AA9  000A E8 0B 01  call 0x118
            L000D: // NOP
            L000E: cx = PopStack(player);
            L000F: cx = PopStack(player);
            L0010: return; // RETURN;
        }

        private void FnCHK_44(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L001D;
1AC1  0010 FF 76 08  push word [bp+0x8]
1AC4  0013 FF 76 06  push word [bp+0x6]
1AC7  0016 0E     push cs
1AC8  0017 E8 26 01  call 0x140
            L001A: // NOP
            L001B: goto L0035;
            L001D: ShowMessage(player, String14FE); // Proceed single file to sneak past Juvalad's gate guards.
1ADB  002A FF 76 08  push word [bp+0x8]
1ADE  002D FF 76 06  push word [bp+0x6]
1AE1  0030 0E     push cs
1AE2  0031 E8 2F 01  call 0x163
            L0034: // NOP
            L0035: cx = PopStack(player);
            L0036: cx = PopStack(player);
            L0037: return; // RETURN;
        }

        private void FnPTYCHK_45(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L0035;
            L0010: Compare(GetFlag(player, 0x02, 0xA8), 0x0001);
            L0024: if (JumpNotEqual) goto L0035;
            L0026: ShowMessage(player, String1537); // Proceed south to meet your fate.
            L0033: goto L0050;
            L0035: TeleportParty(player, 0x0B, 0x01, 0xF1, 0x03, isForwardMove);
            L0050: return; // RETURN;
        }

        private void FnSICCLU_46(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0xA2), 0x0001);
            L0017: if (JumpNotEqual) goto L0079;
            L0019: ShowPortrait(player, 0x0016);
            L0026: ShowMessage(player, String1558); // Thorzil appears before you.
            L0033: ShowMessage(player, String1574); // 'You have done well so far weaklings! But I shall finish my work without your interference!'
            L0040: ShowMessage(player, String15D1); // Thorzil manages to get away, but not without leaving his mark.
            L004D: SetFlag(player, 0x02, 0xA2, 0x02);
            L0062: ax = GetCurrentHits(player);
            L0069: bx = 0x000A;
            L006C: dx = ax % bx; ax = ax / bx;
            L006F: DamagePlayer(player, ax);
            L0079: return; // RETURN;
            // Extra data: 55 8B EC B8 10 16 50 C4 5E 06 26 FF 9F F8 00 59 5D CB 55 8B EC C4 5E 06 26 FF 5F 74 50 C4 5E 06 26 FF 9F 90 00 59 5D CB 55 8B EC B8 42 00 50 C4 5E 06 26 FF 9F FC 00 59 5D CB 55 8B EC B8 01 00 50 C4 5E 06 26 FF 5F 24 50 C4 5E 06 26 FF 5F 20 50 C4 5E 06 26 FF 5F 2C 83 C4 06 5D CB 55 8B EC 33 C0 50 C4 5E 06 26 FF 5F 24 50 C4 5E 06 26 FF 5F 20 50 C4 5E 06 26 FF 5F 2C 83 C4 06 5D CB 55 8B EC C4 5E 06 26 FF 5F 74 BB 04 00 99 F7 FB 50 C4 5E 06 26 FF 9F 90 00 59 C4 5E 06 26 FF 9F C4 00 5D CB 55 8B EC C4 5E 06 26 FF 5F 74 50 C4 5E 06 26 FF 9F 94 00 59 B8 10 27 50 C4 5E 06 26 FF 9F B4 00 59 5D CB 55 8B EC C4 5E 06 26 FF 5F 74 BB 0A 00 99 F7 FB 50 B8 08 00 50 B8 01 00 50 C4 5E 06 26 FF 9F 9C 00 83 C4 06 B8 01 00 50 50 33 C0 50 C4 5E 06 26 FF 1F 83 C4 06 5D CB 55 8B EC B8 01 00 50 B8 B2 00 50 B8 02 00 50 C4 5E 06 26 FF 1F 83 C4 06 B8 0B 00 BA B0 71 50 52 C4 5E 06 26 FF 9F 98 00 59 59 B8 C9 00 50 C4 5E 06 26 FF 5F 48 59 B8 29 16 50 C4 5E 06 26 FF 9F F8 00 59 5D CB 55 8B EC B8 EE 16 50 C4 5E 06 26 FF 9F F8 00 59 5D CB 55 8B EC B8 16 17 50 C4 5E 06 26 FF 9F F8 00 59 B8 C9 00 50 C4 5E 06 26 FF 5F 48 59 5D CB 
        }

        private void FnTXTSP_47(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0xB0), 0x0005);
            L0017: if (JumpEqual) goto L002F;
            L0019: Compare(GetFlag(player, 0x02, 0xAE), 0x0005);
            L002D: if (JumpNotEqual) goto L0049;
            L002F: ShowMessage(player, String1747); // As you turn to leave your hear the hideous laughter of Pluthros.
            L003C: ShowMessage(player, String1788); // 'Fools! You will never complete your task! I have again foiled your attempt at the correct switches!'
            L0049: return; // RETURN;
        }

    }
}
