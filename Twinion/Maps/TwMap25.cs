#pragma warning disable
using System.Collections.Generic;
using XPT.WorldData;
using XPT.WorldData.Yserbius;

namespace XPT.Scripts.Twinion.Maps {
    class TwMap25 : AMapScripted {
        protected override int MapIndex => 25;
        protected override int RandomEncounterChance => 15;
        protected override int RandomEncounterExtraCount => 2;

        public TwMap25() {
            MapEvent01 = FnTIN_01;
            MapEvent02 = FnELEM_02;
            MapEvent03 = FnTTHREE_03;
            MapEvent04 = FnTFOUR_04;
            MapEvent05 = FnPHYS_05;
            MapEvent06 = FnTONE_06;
            MapEvent07 = FnHEAVEN_07;
            MapEvent08 = FnTSIX_08;
            MapEvent09 = FnHELL_09;
            MapEvent0A = FnASTRAL_0A;
            MapEvent0B = FnTSEVEN_0B;
            MapEvent0C = FnTTWO_0C;
            MapEvent0D = FnTTEN_0D;
            MapEvent0E = FnTFIVE_0E;
            MapEvent0F = FnGOODA_0F;
            MapEvent10 = FnMANAZAP_10;
            MapEvent11 = FnBLOCK_11;
            MapEvent12 = FnNOSKSP_12;
            MapEvent13 = FnGOODB_13;
            MapEvent14 = FnWQRTR_14;
            MapEvent16 = FnBAWTR_16;
            MapEvent18 = FnDEADPIT_18;
            MapEvent1A = FnGOODC_1A;
            MapEvent1B = FnAAWTR_1B;
            MapEvent1D = FnXWALLW_1D;
            MapEvent1E = FnLQRTR_1E;
            MapEvent1F = FnGOODD_1F;
            MapEvent20 = FnXWALL_20;
            MapEvent21 = FnFLAGDR_21;
            MapEvent22 = FnAAQRTR_22;
            MapEvent23 = FnBAQRTR_23;
            MapEvent24 = FnBEDLAM_24;
            MapEvent25 = FnZWALL_25;
            MapEvent26 = FnSTARBRST_26;
            MapEvent29 = FnHEAZAP_29;
            MapEvent2A = FnGOODE_2A;
            MapEvent2B = FnMANAFTN_2B;
            MapEvent2C = FnWALLA_2C;
            MapEvent2D = FnWALLB_2D;
            MapEvent2E = FnWALLC_2E;
            MapEvent2F = FnWALLD_2F;
            MapEvent30 = FnGOODF_30;
            MapEvent31 = FnNPCA_31;
            MapEvent32 = FnNPCB_32;
            MapEvent33 = FnNPCC_33;
            MapEvent34 = FnCLUED_34;
            MapEvent35 = FnNPCE_35;
            MapEvent37 = FnBATTLEA_37;
            MapEvent38 = FnBATTLEB_38;
            MapEvent39 = FnBATTLEC_39;
            MapEvent3A = FnBATTLED_3A;
            MapEvent3B = FnBATTLEE_3B;
            MapEvent3C = FnBATTLEC_3C;
            MapEvent3D = FnBATTLEF_3D;
            MapEvent3E = FnPARTYCT_3E;
            MapEvent3F = FnNORTH_3F;
            MapEvent40 = FnEAST_40;
            MapEvent41 = FnWEST_41;
            MapEvent42 = FnSOUTH_42;
            MapEvent43 = FnSW_43;
            MapEvent44 = FnEASTWEST_44;
            MapEvent45 = FnNTWEST_45;
            MapEvent46 = FnNTHSTH_46;
            MapEvent47 = FnEASTSTH_47;
            MapEvent48 = FnNTHEAST_48;
            MapEvent49 = FnNTEASTH_49;
            MapEvent4A = FnEASTHWE_4A;
            MapEvent4B = FnNTEAWEST_4B;
            MapEvent4C = FnNTSTHWE_4C;
            MapEvent4D = FnZWALLW_4D;
            MapEvent4E = FnXWALLS_4E;
            MapEvent4F = FnZWALLWB_4F;
            MapEvent50 = FnXWALLNW_50;
            MapEvent51 = FnXWSZWE_51;
            MapEvent52 = FnZWALLSTH_52;
            MapEvent53 = FnZWALLN_53;
            MapEvent54 = FnELEMTX_54;
            MapEvent55 = FnPHYTEX_55;
            MapEvent56 = FnHVENTXT_56;
            MapEvent57 = FnHELLTXT_57;
            MapEvent58 = FnASTTXT_58;
        }
        
        // === Strings ================================================
        private const string String03FC = "You quickly jump out of the way of a falling boulder.";
        private const string String0432 = "The alcove is empty.";
        private const string String0447 = "Next to the obvious remains of a long time dead adventurer you are surprised to find some items intact.";
        private const string String04AF = "Your constant running into invisible walls has taken a toll on your mana.";
        private const string String04F9 = "You see nothing of interest here.";
        private const string String051B = "You encounter a wizard selling scrolls.";
        private const string String0543 = "'I see that you will be in need of magic as you travel through this area.  I accept your payment for these scrolls. May they aid you in your journey.'";
        private const string String05DA = "The water drains your energy as you wade through it.";
        private const string String060F = "A water monster attacks you, but you manage to get away with minimal damage.";
        private const string String065C = "You fall into a bottomless pit.";
        private const string String067C = "The water flows briskly around you.";
        private const string String06A0 = "You see something bobbing in the water and grab it.";
        private const string String06D4 = "The heat of the surrounding lava makes you weak.";
        private const string String0705 = "You find nothing.";
        private const string String0717 = "Protruding from the hardened lava you find a bag.  You free it and pocket the contents.";
        private const string String076F = "You see a sign on the door. 'Adventurers!  Proceed through this door individually if you possess the magical Starburst.'";
        private const string String07E8 = "You must find the magical Starburst to gain entry.";
        private const string String081B = "Your heavy step causes a crack in the hardened lava and the still molten lava below splashes up and injures you.";
        private const string String088C = "The swirling waters of Bedlam Whirlpool heal your wounds.";
        private const string String08C6 = "The crusted lava allows for easy passage.";
        private const string String08F0 = "You help a Cleric free his trapped foot from a crack in the lava. 'Thank you for helping me. Please accept this talisman with my gratitude. May it aid you in your travels.";
        private const string String099C = "It has gotten me out of a few rocky situations.'";
        private const string String09CD = "You cut yourself on the jagged rock wall.";
        private const string String09F7 = "You see a hole in the wall.";
        private const string String0A13 = "You see forgotten items resting on a ledge in the wall.";
        private const string String0A4B = "The Lava Pool of Confusion restores your mana.";
        private const string String0A7A = "You find that a boulder has blocked your path.";
        private const string String0AA9 = "The magical Starburst shatters the boulder.";
        private const string String0AD5 = "You cannot budge the boulder.";
        private const string String0AF3 = "The ground shows signs of damage from heavy boulders falling.";
        private const string String0B31 = "There is nothing but rubble on the ground.";
        private const string String0B5C = "Upon searching the alcove you move a rock and discover treasure.";
        private const string String0B9D = "You encounter a Gnome Wizard who stops you in your path. ";
        private const string String0BD7 = "'This place is pandemonium.  My skills and spells are useless in places.'";
        private const string String0C21 = "'You have come to the area where you must decide which path to follow in your search for each of the Dralkarians.  Guard well your magical Starburst for it will grant you passage to the portals.'";
        private const string String0CE5 = "'May your choices be wise and your journeys successful.'";
        private const string String0D1E = "A thief pulls you aside. 'Pssst....I found a way to walk over the lava.  Just be sure it's crusted over.  Shhhhh, don't tell a soul.'";
        private const string String0DA4 = "You see a hand written note on the back of a scroll.  It warns that what may harm one, may not harm another.";
        private const string String0E11 = "'The time has come for you to begin your journey to meet the Dralkarians. You must travel through Pandemonium in order to seek the portals to the final paths. Of the 5 portals you shall make your choice.'";
        private const string String0EDE = "Now you may proceed to pick the path of your choice.";
        private const string String0F13 = "Proceed through this door and accept the challenge of the elements in order to gain access to Malos, the Dralkarian who controls the elements. Be aware that all Quest items gained from other paths will be taken from you.";
        private const string String0FF0 = "Step through this door to overcome physical obstacles on your path to Corpeus, the Dralkarian who guards the gate. Be aware that all Quest items gained from other paths will be taken from you.";
        private const string String10B1 = "This door will lead you to the path through Enakkar in your search for the Dralkarian Juvalad. Be aware that all Quest items from other paths will be taken from you.";
        private const string String1157 = "Through this door is Ashakkar. Succeed in your quest and you will find the Dralkarian Pluthros.  Be aware that all Quest items from other paths will be taken from you.";
        private const string String11FF = "Inside, a portal will teleport you to the astral path in order to find the Dralkarian guard Astelligus. Be aware that all Quest items from other paths will be taken from you.";
        
        // === Functions ================================================
        private void FnTIN_01(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x0A, 0x03, 0x9F, 0x01, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnELEM_02(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x0B, 0x01, 0xAF, 0x03, isForwardMove);
            L001E: RemoveItem(player, 0xC6);
            L002A: RemoveItem(player, 0xCA);
            L0036: RemoveItem(player, 0xEE);
            L0042: RemoveItem(player, 0xEF);
            L004E: return; // RETURN;
        }

        private void FnTTHREE_03(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x0A, 0x03, 0x2E, 0x03, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnTFOUR_04(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x0A, 0x03, 0xB0, 0x01, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnPHYS_05(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x0B, 0x03, 0x10, 0x03, isForwardMove);
            L001E: RemoveItem(player, 0xC9);
            L002A: RemoveItem(player, 0xC6);
            L0036: RemoveItem(player, 0xCA);
            L0042: RemoveItem(player, 0xEE);
            L004E: return; // RETURN;
        }

        private void FnTONE_06(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x0A, 0x03, 0xAC, 0x03, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnHEAVEN_07(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x0B, 0x01, 0xF1, 0x03, isForwardMove);
            L001E: RemoveItem(player, 0xC9);
            L002A: RemoveItem(player, 0xC6);
            L0036: RemoveItem(player, 0xEE);
            L0042: RemoveItem(player, 0xEF);
            L004E: return; // RETURN;
        }

        private void FnTSIX_08(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x0A, 0x03, 0x6E, 0x00, isForwardMove);
            L001D: return; // RETURN;
        }

        private void FnHELL_09(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x0B, 0x01, 0x28, 0x01, isForwardMove);
            L001E: RemoveItem(player, 0xC9);
            L002A: RemoveItem(player, 0xCA);
            L0036: RemoveItem(player, 0xEE);
            L0042: RemoveItem(player, 0xEF);
            L004E: return; // RETURN;
        }

        private void FnASTRAL_0A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x0B, 0x03, 0xF0, 0x02, isForwardMove);
            L001E: RemoveItem(player, 0xCA);
            L002A: RemoveItem(player, 0xC9);
            L0036: RemoveItem(player, 0xC6);
            L0042: RemoveItem(player, 0xEF);
            L004E: return; // RETURN;
        }

        private void FnTSEVEN_0B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String03FC); // You quickly jump out of the way of a falling boulder.
            L0010: TeleportParty(player, 0x0A, 0x03, 0xE9, 0x03, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnTTWO_0C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x0A, 0x03, 0x13, 0x02, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnTTEN_0D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x02);
            L0007: PushStack(player, 0x00);
0294  000A C4 5E 06  les bx, [bp+0x6]
0297  000D 26 FF 5F 04  call far word [es:bx+0x4]
            L0011: cx = PopStack(player);
            L0012: cx = PopStack(player);
            L0013: RefreshCompareFlags(ax);
            L0015: if (JumpNotEqual) goto L005B;
            L0017: Compare(GetFlag(player, 0x03, 0x01), 0x0001);
            L002B: if (JumpNotEqual) goto L005B;
            L002D: TeleportParty(player, 0x0A, 0x03, 0x23, 0x00, isForwardMove);
            L0047: SetFlag(player, 0x00, 0x02, 0x01);
            L005B: return; // RETURN;
        }

        private void FnTFIVE_0E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x0A, 0x03, 0x53, 0x01, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnGOODA_0F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0xB3), 0x0001);
            L0017: if (JumpNotEqual) goto L001E;
0320  0019 B8 32 04  mov ax, 0x432
            L001C: goto L005A;
            L001E: SetFlag(player, 0x02, 0xB3, 0x01);
            L0033: GiveItem(player, 0xB8);
            L003F: GiveItem(player, 0xB8);
            L004B: GiveItem(player, 0xAF);
            L0057: ShowMessage(player, String0447); // Next to the obvious remains of a long time dead adventurer you are surprised to find some items intact.
            L0064: return; // RETURN;
        }

        private void FnMANAZAP_10(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddMana(player, 0xFF38);
            L0010: ShowMessage(player, String04AF); // Your constant running into invisible walls has taken a toll on your mana.
            L001D: SetWallPassable(player, GetCurrentTile(player), 0x01, 0x00);
            L0036: return; // RETURN;
        }

        private void FnBLOCK_11(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0020: return; // RETURN;
        }

        private void FnNOSKSP_12(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
03CA  0003 C4 5E 06  les bx, [bp+0x6]
03CD  0006 26 FF 5F 3C  call far word [es:bx+0x3c]
03D1  000A C4 5E 06  les bx, [bp+0x6]
03D4  000D 26 FF 5F 40  call far word [es:bx+0x40]
            L0011: return; // RETURN;
        }

        private void FnGOODB_13(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0xB4), 0x0001);
            L0017: if (JumpNotEqual) goto L001E;
03F3  0019 B8 F9 04  mov ax, 0x4f9
            L001C: goto L0086;
            L001E: ShowPortrait(player, 0x002C);
            L002B: SetFlag(player, 0x02, 0xB4, 0x01);
            L0040: GiveItem(player, 0xAB);
            L004C: GiveItem(player, 0xAA);
            L0058: GiveItem(player, 0xB3);
            L0064: ModifyGold(player, 0xFFFFF0BA);
            L0076: ShowMessage(player, String051B); // You encounter a wizard selling scrolls.
            L0083: ShowMessage(player, String0543); // 'I see that you will be in need of magic as you travel through this area.  I accept your payment for these scrolls. May they aid you in your journey.'
            L0090: return; // RETURN;
        }

        private void FnWQRTR_14(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetWallPassable(player, GetCurrentTile(player), 0x03, 0x00);
            L001C: SetWallPassable(player, GetCurrentTile(player), 0x01, 0x00);
            L0035: SetNoHealZone(player);
            L003D: PushStack(player, 0x02);
            L0041: PushStack(player, 0x00);
04B0  0044 C4 5E 06  les bx, [bp+0x6]
04B3  0047 26 FF 5F 04  call far word [es:bx+0x4]
            L004B: cx = PopStack(player);
            L004C: cx = PopStack(player);
            L004D: RefreshCompareFlags(ax);
            L004F: if (JumpNotEqual) goto L0089;
            L0051: ShowMessage(player, String05DA); // The water drains your energy as you wade through it.
            L005E: ax = GetMaxHits(player);
            L0065: bx = 0x0004;
            L0068: dx = ax % bx; ax = ax / bx;
            L006B: DamagePlayer(player, ax);
            L0075: SetFlag(player, 0x00, 0x02, 0x01);
            L0089: return; // RETURN;
        }

        private void FnBAWTR_16(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetWallPassable(player, GetCurrentTile(player), 0x02, 0x00);
            L001C: SetWallPassable(player, GetCurrentTile(player), ax, 0x00);
            L0032: SetNoHealZone(player);
            L003A: PushStack(player, 0x02);
            L003E: PushStack(player, 0x00);
053D  0041 C4 5E 06  les bx, [bp+0x6]
0540  0044 26 FF 5F 04  call far word [es:bx+0x4]
            L0048: cx = PopStack(player);
            L0049: cx = PopStack(player);
            L004A: RefreshCompareFlags(ax);
            L004C: if (JumpNotEqual) goto L00AA;
            L004E: Compare(GetGuild(player), 0x0002);
            L0058: if (JumpEqual) goto L0072;
            L005A: Compare(GetGuild(player), 0x0004);
            L0064: if (JumpEqual) goto L0072;
            L0066: Compare(GetGuild(player), 0x0005);
            L0070: if (JumpNotEqual) goto L00AA;
            L0072: ShowMessage(player, String060F); // A water monster attacks you, but you manage to get away with minimal damage.
            L007F: ax = GetMaxHits(player);
            L0086: bx = 0x0004;
            L0089: dx = ax % bx; ax = ax / bx;
            L008C: DamagePlayer(player, ax);
            L0096: SetFlag(player, 0x00, 0x02, 0x01);
            L00AA: return; // RETURN;
        }

        private void FnDEADPIT_18(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String065C); // You fall into a bottomless pit.
            L0010: DamagePlayer(player, GetMaxHits(player));
            L0021: return; // RETURN;
        }

        private void FnGOODC_1A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetWallPassable(player, GetCurrentTile(player), 0x03, 0x00);
            L001C: SetWallPassable(player, GetCurrentTile(player), ax, 0x00);
            L0032: Compare(GetFlag(player, 0x02, 0xB6), 0x0001);
            L0046: if (JumpNotEqual) goto L004D;
061D  0048 B8 7C 06  mov ax, 0x67c
            L004B: goto L0071;
            L004D: SetFlag(player, 0x02, 0xB6, 0x01);
            L0062: GiveItem(player, 0xCE);
            L006E: ShowMessage(player, String06A0); // You see something bobbing in the water and grab it.
            L007B: return; // RETURN;
        }

        private void FnAAWTR_1B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetWallPassable(player, GetCurrentTile(player), 0x03, 0x00);
            L001C: SetWallPassable(player, GetCurrentTile(player), 0x01, 0x00);
            L0035: SetNoHealZone(player);
            L003D: PushStack(player, 0x02);
            L0041: PushStack(player, 0x00);
0696  0044 C4 5E 06  les bx, [bp+0x6]
0699  0047 26 FF 5F 04  call far word [es:bx+0x4]
            L004B: cx = PopStack(player);
            L004C: cx = PopStack(player);
            L004D: RefreshCompareFlags(ax);
            L004F: if (JumpNotEqual) goto L00AC;
            L0051: Compare(GetGuild(player), 0x0003);
            L005B: if (JumpEqual) goto L0074;
            L005D: RefreshCompareFlags(GetGuild(player));
            L0066: if (JumpEqual) goto L0074;
            L0068: Compare(GetGuild(player), 0x0001);
            L0072: if (JumpNotEqual) goto L00AC;
            L0074: ShowMessage(player, String060F); // A water monster attacks you, but you manage to get away with minimal damage.
            L0081: ax = GetMaxHits(player);
            L0088: bx = 0x0004;
            L008B: dx = ax % bx; ax = ax / bx;
            L008E: DamagePlayer(player, ax);
            L0098: SetFlag(player, 0x00, 0x02, 0x01);
            L00AC: return; // RETURN;
        }

        private void FnXWALLW_1D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0xF0);
            L0011: if (JumpEqual) goto L0018;
0718  0013 B8 01 00  mov ax, 0x1
            L0016: goto L001A;
            L0018: SetWallPassable(player, GetCurrentTile(player), 0x03, 0x00);
            L0031: return; // RETURN;
        }

        private void FnLQRTR_1E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetWallPassable(player, GetCurrentTile(player), 0x03, 0x00);
            L001C: SetWallPassable(player, GetCurrentTile(player), 0x01, 0x00);
            L0035: SetNoHealZone(player);
            L003D: PushStack(player, 0x02);
            L0041: PushStack(player, 0x00);
077C  0044 C4 5E 06  les bx, [bp+0x6]
077F  0047 26 FF 5F 04  call far word [es:bx+0x4]
            L004B: cx = PopStack(player);
            L004C: cx = PopStack(player);
            L004D: RefreshCompareFlags(ax);
            L004F: if (JumpNotEqual) goto L0089;
            L0051: ShowMessage(player, String06D4); // The heat of the surrounding lava makes you weak.
            L005E: ax = GetMaxHits(player);
            L0065: bx = 0x0004;
            L0068: dx = ax % bx; ax = ax / bx;
            L006B: DamagePlayer(player, ax);
            L0075: SetFlag(player, 0x00, 0x02, 0x01);
            L0089: return; // RETURN;
        }

        private void FnGOODD_1F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetWallPassable(player, GetCurrentTile(player), 0x03, 0x00);
            L001C: SetWallPassable(player, GetCurrentTile(player), 0x01, 0x00);
            L0035: SetWallPassable(player, GetCurrentTile(player), 0x02, 0x00);
            L004E: Compare(GetFlag(player, 0x02, 0xB7), 0x0001);
            L0062: if (JumpNotEqual) goto L0069;
0827  0064 B8 05 07  mov ax, 0x705
            L0067: goto L00B1;
            L0069: SetFlag(player, 0x02, 0xB7, 0x01);
            L007E: GiveItem(player, 0x0E);
            L008A: GiveItem(player, 0x98);
            L0096: GiveItem(player, 0xBC);
            L00A2: GiveItem(player, 0x90);
            L00AE: ShowMessage(player, String0717); // Protruding from the hardened lava you find a bag.  You free it and pocket the contents.
            L00BB: return; // RETURN;
        }

        private void FnXWALL_20(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0xF0);
            L0011: if (JumpEqual) goto L0018;
0893  0013 B8 01 00  mov ax, 0x1
            L0016: goto L001A;
            L0018: SetWallPassable(player, GetCurrentTile(player), 0x01, 0x00);
            L0031: return; // RETURN;
        }

        private void FnFLAGDR_21(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String076F); // You see a sign on the door. 'Adventurers!  Proceed through this door individually if you possess the magical Starburst.'
            L0010: Compare(PartyCount(player), 0x0001);
            L001B: if (JumpNotEqual) goto L005E;
            L001D: ax = HasItem(player, 0xF0);
            L002B: if (JumpEqual) goto L0032;
08E0  002D B8 01 00  mov ax, 0x1
            L0030: goto L0060;
            L0032: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L004F: ShowMessage(player, String07E8); // You must find the magical Starburst to gain entry.
            L005C: goto L007B;
            L005E: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L007B: return; // RETURN;
        }

        private void FnAAQRTR_22(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetWallPassable(player, GetCurrentTile(player), 0x03, 0x00);
            L001C: SetWallPassable(player, GetCurrentTile(player), ax, 0x00);
            L0032: SetNoHealZone(player);
            L003A: PushStack(player, 0x02);
            L003E: PushStack(player, 0x00);
0971  0041 C4 5E 06  les bx, [bp+0x6]
0974  0044 26 FF 5F 04  call far word [es:bx+0x4]
            L0048: cx = PopStack(player);
            L0049: cx = PopStack(player);
            L004A: RefreshCompareFlags(ax);
            L004C: if (JumpNotEqual) goto L00A9;
            L004E: Compare(GetGuild(player), 0x0003);
            L0058: if (JumpEqual) goto L0071;
            L005A: RefreshCompareFlags(GetGuild(player));
            L0063: if (JumpEqual) goto L0071;
            L0065: Compare(GetGuild(player), 0x0001);
            L006F: if (JumpNotEqual) goto L00A9;
            L0071: ShowMessage(player, String081B); // Your heavy step causes a crack in the hardened lava and the still molten lava below splashes up and injures you.
            L007E: ax = GetMaxHits(player);
            L0085: bx = 0x0004;
            L0088: dx = ax % bx; ax = ax / bx;
            L008B: DamagePlayer(player, ax);
            L0095: SetFlag(player, 0x00, 0x02, 0x01);
            L00A9: return; // RETURN;
        }

        private void FnBAQRTR_23(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetWallPassable(player, GetCurrentTile(player), 0x03, 0x00);
            L001C: SetNoHealZone(player);
            L0024: PushStack(player, 0x02);
            L0028: PushStack(player, 0x00);
0A06  002B C4 5E 06  les bx, [bp+0x6]
0A09  002E 26 FF 5F 04  call far word [es:bx+0x4]
            L0032: cx = PopStack(player);
            L0033: cx = PopStack(player);
            L0034: RefreshCompareFlags(ax);
            L0036: if (JumpNotEqual) goto L0094;
            L0038: Compare(GetGuild(player), 0x0002);
            L0042: if (JumpEqual) goto L005C;
            L0044: Compare(GetGuild(player), 0x0004);
            L004E: if (JumpEqual) goto L005C;
            L0050: Compare(GetGuild(player), 0x0005);
            L005A: if (JumpNotEqual) goto L0094;
            L005C: ShowMessage(player, String081B); // Your heavy step causes a crack in the hardened lava and the still molten lava below splashes up and injures you.
            L0069: ax = GetMaxHits(player);
            L0070: bx = 0x0004;
            L0073: dx = ax % bx; ax = ax / bx;
            L0076: DamagePlayer(player, ax);
            L0080: SetFlag(player, 0x00, 0x02, 0x01);
            L0094: return; // RETURN;
        }

        private void FnBEDLAM_24(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String088C); // The swirling waters of Bedlam Whirlpool heal your wounds.
            L0010: HealPlayer(player, GetMaxHits(player));
            L0021: return; // RETURN;
        }

        private void FnZWALL_25(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0xF0);
            L0011: if (JumpEqual) goto L0017;
0AA7  0013 33 C0  xor ax, ax
            L0015: goto L001A;
            L0017: SetWallPassable(player, GetCurrentTile(player), 0x02, 0x01);
            L0031: return; // RETURN;
        }

        private void FnSTARBRST_26(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0xF0);
            L0011: if (JumpEqual) goto L0021;
0ADA  0013 B8 C6 08  mov ax, 0x8c6
            L0016: PushStack(player, ax);
0ADE  0017 C4 5E 06  les bx, [bp+0x6]
0AE1  001A 26 FF 9F F8 00  call far word [es:bx+0xf8]
            L001F: goto L0053;
            L0021: ShowPortrait(player, 0x0027);
            L002E: ShowMessage(player, String08F0); // You help a Cleric free his trapped foot from a crack in the lava. 'Thank you for helping me. Please accept this talisman with my gratitude. May it aid you in your travels.
            L003B: ShowMessage(player, String099C); // It has gotten me out of a few rocky situations.'
            L0048: GiveItem(player, 0xF0);
            L0054: return; // RETURN;
        }

        private void FnHEAZAP_29(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetWallPassable(player, GetCurrentTile(player), 0x02, 0x00);
            L001C: SetNoHealZone(player);
            L0024: PushStack(player, 0x02);
            L0028: PushStack(player, 0x00);
0B52  002B C4 5E 06  les bx, [bp+0x6]
0B55  002E 26 FF 5F 04  call far word [es:bx+0x4]
            L0032: cx = PopStack(player);
            L0033: cx = PopStack(player);
            L0034: RefreshCompareFlags(ax);
            L0036: if (JumpNotEqual) goto L0070;
            L0038: ShowMessage(player, String09CD); // You cut yourself on the jagged rock wall.
            L0045: ax = GetMaxHits(player);
            L004C: bx = 0x0003;
            L004F: dx = ax % bx; ax = ax / bx;
            L0052: DamagePlayer(player, ax);
            L005C: SetFlag(player, 0x00, 0x02, 0x01);
            L0070: return; // RETURN;
        }

        private void FnGOODE_2A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetWallPassable(player, GetCurrentTile(player), 0x01, 0x00);
            L001C: SetWallPassable(player, GetCurrentTile(player), ax, 0x00);
            L0032: Compare(GetFlag(player, 0x02, 0xB8), 0x0001);
            L0046: if (JumpNotEqual) goto L0056;
0BE1  0048 B8 F7 09  mov ax, 0x9f7
            L004B: PushStack(player, ax);
0BE5  004C C4 5E 06  les bx, [bp+0x6]
0BE8  004F 26 FF 9F F8 00  call far word [es:bx+0xf8]
            L0054: goto L00A7;
            L0056: SetFlag(player, 0x02, 0xB8, 0x01);
            L006B: ShowMessage(player, String0A13); // You see forgotten items resting on a ledge in the wall.
            L0078: GiveItem(player, 0xAD);
            L0084: GiveItem(player, 0x5C);
            L0090: GiveItem(player, 0xA7);
            L009C: GiveItem(player, 0xC3);
            L00A8: return; // RETURN;
        }

        private void FnMANAFTN_2B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetWallPassable(player, GetCurrentTile(player), 0x03, 0x00);
            L001C: SetWallPassable(player, GetCurrentTile(player), 0x02, 0x00);
            L0035: SetWallPassable(player, GetCurrentTile(player), 0x01, 0x00);
            L004E: ShowMessage(player, String0A4B); // The Lava Pool of Confusion restores your mana.
            L005B: AddMana(player, 0x2710);
            L0068: return; // RETURN;
        }

        private void FnWALLA_2C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0xF0);
            L0011: if (JumpNotEqual) goto L0016;
            L0013: goto L00AE;
            L0016: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0033: ShowMessage(player, String0A7A); // You find that a boulder has blocked your path.
            L0040: PushStack(player, 0xF0);
            L0044: PushStack(player, ax);
0CF2  0045 C4 5E 06  les bx, [bp+0x6]
0CF5  0048 26 FF 5F 54  call far word [es:bx+0x54]
            L004C: cx = PopStack(player);
            L004D: cx = PopStack(player);
            L004E: RefreshCompareFlags(ax);
            L0050: if (JumpEqual) goto L00A9;
            L0052: Compare(GetGuild(player), 0x0005);
            L005C: if (JumpEqual) goto L006A;
            L005E: Compare(GetGuild(player), 0x0002);
            L0068: if (JumpNotEqual) goto L00A9;
            L006A: PushStack(player, 0x01);
            L006E: PushStack(player, ax);
            L006F: PushStack(player, 0x03);
0D20  0073 C4 5E 06  les bx, [bp+0x6]
0D23  0076 26 FF 1F  call far word [es:bx]
0D26  0079 83 C4 06  add sp, 0x6
            L007C: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L009A: ShowMessage(player, String0AA9); // The magical Starburst shatters the boulder.
            L00A7: goto L00D9;
0D56  00A9 B8 D5 0A  mov ax, 0xad5
            L00AC: goto L009D;
            L00AE: ShowMessage(player, String0AF3); // The ground shows signs of damage from heavy boulders falling.
            L00BB: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L00D9: return; // RETURN;
        }

        private void FnWALLB_2D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0xF0);
            L0011: if (JumpNotEqual) goto L0016;
            L0013: goto L00AE;
            L0016: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0033: ShowMessage(player, String0A7A); // You find that a boulder has blocked your path.
            L0040: PushStack(player, 0xF0);
            L0044: PushStack(player, ax);
0DCD  0045 C4 5E 06  les bx, [bp+0x6]
0DD0  0048 26 FF 5F 54  call far word [es:bx+0x54]
            L004C: cx = PopStack(player);
            L004D: cx = PopStack(player);
            L004E: RefreshCompareFlags(ax);
            L0050: if (JumpEqual) goto L00A9;
            L0052: Compare(GetGuild(player), 0x0001);
            L005C: if (JumpEqual) goto L006A;
            L005E: Compare(GetGuild(player), 0x0007);
            L0068: if (JumpNotEqual) goto L00A9;
            L006A: PushStack(player, 0x01);
            L006E: PushStack(player, ax);
            L006F: PushStack(player, 0x03);
0DFB  0073 C4 5E 06  les bx, [bp+0x6]
0DFE  0076 26 FF 1F  call far word [es:bx]
0E01  0079 83 C4 06  add sp, 0x6
            L007C: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L009A: ShowMessage(player, String0AA9); // The magical Starburst shatters the boulder.
            L00A7: goto L00D9;
0E31  00A9 B8 D5 0A  mov ax, 0xad5
            L00AC: goto L009D;
            L00AE: ShowMessage(player, String0AF3); // The ground shows signs of damage from heavy boulders falling.
            L00BB: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L00D9: return; // RETURN;
        }

        private void FnWALLC_2E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0xF0);
            L0011: if (JumpNotEqual) goto L0016;
            L0013: goto L00AE;
            L0016: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0033: ShowMessage(player, String0A7A); // You find that a boulder has blocked your path.
            L0040: PushStack(player, 0xF0);
            L0044: PushStack(player, ax);
0EA8  0045 C4 5E 06  les bx, [bp+0x6]
0EAB  0048 26 FF 5F 54  call far word [es:bx+0x54]
            L004C: cx = PopStack(player);
            L004D: cx = PopStack(player);
            L004E: RefreshCompareFlags(ax);
            L0050: if (JumpEqual) goto L00A9;
            L0052: Compare(GetGuild(player), 0x0004);
            L005C: if (JumpEqual) goto L006A;
            L005E: Compare(GetGuild(player), 0x0003);
            L0068: if (JumpNotEqual) goto L00A9;
            L006A: PushStack(player, 0x01);
            L006E: PushStack(player, ax);
            L006F: PushStack(player, 0x03);
0ED6  0073 C4 5E 06  les bx, [bp+0x6]
0ED9  0076 26 FF 1F  call far word [es:bx]
0EDC  0079 83 C4 06  add sp, 0x6
            L007C: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L009A: ShowMessage(player, String0AA9); // The magical Starburst shatters the boulder.
            L00A7: goto L00D9;
0F0C  00A9 B8 D5 0A  mov ax, 0xad5
            L00AC: goto L009D;
            L00AE: ShowMessage(player, String0AF3); // The ground shows signs of damage from heavy boulders falling.
            L00BB: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L00D9: return; // RETURN;
        }

        private void FnWALLD_2F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0xF0);
            L0011: if (JumpNotEqual) goto L0016;
            L0013: goto L00AD;
            L0016: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0033: ShowMessage(player, String0A7A); // You find that a boulder has blocked your path.
            L0040: PushStack(player, 0xF0);
            L0044: PushStack(player, ax);
0F83  0045 C4 5E 06  les bx, [bp+0x6]
0F86  0048 26 FF 5F 54  call far word [es:bx+0x54]
            L004C: cx = PopStack(player);
            L004D: cx = PopStack(player);
            L004E: RefreshCompareFlags(ax);
            L0050: if (JumpEqual) goto L00A8;
            L0052: Compare(GetGuild(player), 0x0006);
            L005C: if (JumpEqual) goto L0069;
            L005E: RefreshCompareFlags(GetGuild(player));
            L0067: if (JumpNotEqual) goto L00A8;
            L0069: PushStack(player, 0x01);
            L006D: PushStack(player, ax);
            L006E: PushStack(player, 0x03);
0FB0  0072 C4 5E 06  les bx, [bp+0x6]
0FB3  0075 26 FF 1F  call far word [es:bx]
0FB6  0078 83 C4 06  add sp, 0x6
            L007B: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0099: ShowMessage(player, String0AA9); // The magical Starburst shatters the boulder.
            L00A6: goto L00D8;
0FE6  00A8 B8 D5 0A  mov ax, 0xad5
            L00AB: goto L009C;
            L00AD: ShowMessage(player, String0AF3); // The ground shows signs of damage from heavy boulders falling.
            L00BA: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L00D8: return; // RETURN;
        }

        private void FnGOODF_30(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetWallPassable(player, GetCurrentTile(player), 0x03, 0x00);
            L001C: SetWallPassable(player, GetCurrentTile(player), ax, 0x00);
            L0032: Compare(GetFlag(player, 0x02, 0xB9), 0x0001);
            L0046: if (JumpNotEqual) goto L0056;
1060  0048 B8 31 0B  mov ax, 0xb31
            L004B: PushStack(player, ax);
1064  004C C4 5E 06  les bx, [bp+0x6]
1067  004F 26 FF 9F F8 00  call far word [es:bx+0xf8]
            L0054: goto L00A7;
            L0056: SetFlag(player, 0x02, 0xB9, 0x01);
            L006B: ShowMessage(player, String0B5C); // Upon searching the alcove you move a rock and discover treasure.
            L0078: GiveItem(player, 0x88);
            L0084: GiveItem(player, 0xBC);
            L0090: GiveItem(player, 0x97);
            L009C: GiveItem(player, 0xA4);
            L00A8: return; // RETURN;
        }

        private void FnNPCA_31(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x002D);
            L0010: ShowMessage(player, String0B9D); // You encounter a Gnome Wizard who stops you in your path. 
            L001D: ShowMessage(player, String0BD7); // 'This place is pandemonium.  My skills and spells are useless in places.'
            L002A: return; // RETURN;
        }

        private void FnNPCB_32(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0012);
            L0010: ShowMessage(player, String0C21); // 'You have come to the area where you must decide which path to follow in your search for each of the Dralkarians.  Guard well your magical Starburst for it will grant you passage to the portals.'
            L001D: ShowMessage(player, String0CE5); // 'May your choices be wise and your journeys successful.'
            L002A: return; // RETURN;
        }

        private void FnNPCC_33(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0026);
            L0010: ShowMessage(player, String0D1E); // A thief pulls you aside. 'Pssst....I found a way to walk over the lava.  Just be sure it's crusted over.  Shhhhh, don't tell a soul.'
            L001D: return; // RETURN;
        }

        private void FnCLUED_34(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetWallPassable(player, GetCurrentTile(player), 0x03, 0x00);
            L001C: SetWallPassable(player, GetCurrentTile(player), 0x01, 0x00);
            L0035: SetWallPassable(player, GetCurrentTile(player), ax, 0x00);
            L004B: ShowMessage(player, String0DA4); // You see a hand written note on the back of a scroll.  It warns that what may harm one, may not harm another.
            L0058: return; // RETURN;
        }

        private void FnNPCE_35(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0014);
            L0010: ShowMessage(player, String0E11); // 'The time has come for you to begin your journey to meet the Dralkarians. You must travel through Pandemonium in order to seek the portals to the final paths. Of the 5 portals you shall make your choice.'
            L001D: return; // RETURN;
        }

        private void FnBATTLEA_37(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L0025;
            L0010: PushStack(player, 0x01);
            L0014: PushStack(player, ax);
11CC  0015 C4 5E 06  les bx, [bp+0x6]
11CF  0018 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L001D: cx = PopStack(player);
            L001E: cx = PopStack(player);
11D6  001F B8 02 00  mov ax, 0x2
            L0022: goto L00B3;
            L0025: Compare(PartyCount(player), 0x0002);
            L0030: if (JumpNotEqual) goto L006B;
            L0032: PushStack(player, 0x01);
            L0036: PushStack(player, ax);
11EE  0037 C4 5E 06  les bx, [bp+0x6]
11F1  003A 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L003F: cx = PopStack(player);
            L0040: cx = PopStack(player);
            L0041: PushStack(player, 0x02);
            L0045: PushStack(player, ax);
11FD  0046 C4 5E 06  les bx, [bp+0x6]
1200  0049 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L004E: cx = PopStack(player);
            L004F: cx = PopStack(player);
            L0050: AddEncounter(player, 0x05, 0x03);
            L0062: PushStack(player, 0x03);
121D  0066 B8 06 00  mov ax, 0x6
            L0069: goto L00B7;
            L006B: PushStack(player, 0x01);
            L006F: PushStack(player, ax);
1227  0070 C4 5E 06  les bx, [bp+0x6]
122A  0073 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L0078: cx = PopStack(player);
            L0079: cx = PopStack(player);
            L007A: AddEncounter(player, 0x02, 0x01);
            L008C: AddEncounter(player, 0x03, 0x02);
            L009E: AddEncounter(player, 0x04, 0x02);
            L00B0: AddEncounter(player, 0x05, 0x03);
            L00C2: return; // RETURN;
        }

        private void FnBATTLEB_38(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L002C;
            L0010: AddEncounter(player, 0x01, 0x20);
            L0022: PushStack(player, 0x21);
12A1  0026 B8 02 00  mov ax, 0x2
            L0029: goto L00C7;
            L002C: Compare(PartyCount(player), 0x0002);
            L0037: if (JumpNotEqual) goto L0078;
            L0039: AddEncounter(player, 0x01, 0x1F);
            L004B: AddEncounter(player, 0x02, 0x1F);
            L005D: AddEncounter(player, 0x03, 0x20);
            L006F: PushStack(player, 0x21);
12EE  0073 B8 04 00  mov ax, 0x4
            L0076: goto L00C7;
            L0078: AddEncounter(player, 0x01, 0x1F);
            L008A: AddEncounter(player, 0x02, 0x1F);
            L009C: AddEncounter(player, 0x03, 0x21);
            L00AE: AddEncounter(player, 0x04, 0x21);
            L00C0: AddEncounter(player, 0x06, 0x22);
            L00D2: return; // RETURN;
        }

        private void FnBATTLEC_39(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L003A;
            L0010: AddEncounter(player, 0x01, 0x11);
            L0022: AddEncounter(player, 0x02, 0x13);
1383  0034 B8 1E 00  mov ax, 0x1e
            L0037: goto L00CD;
            L003A: Compare(PartyCount(player), 0x0002);
            L0045: if (JumpNotEqual) goto L0082;
            L0047: AddEncounter(player, 0x01, 0x13);
            L0059: AddEncounter(player, 0x02, 0x14);
            L006B: AddEncounter(player, 0x05, 0x1E);
13CC  007D B8 1C 00  mov ax, 0x1c
            L0080: goto L00CD;
            L0082: AddEncounter(player, 0x01, 0x11);
            L0094: AddEncounter(player, 0x02, 0x11);
            L00A6: AddEncounter(player, 0x04, 0x1E);
            L00B8: AddEncounter(player, 0x05, 0x1C);
            L00CA: AddEncounter(player, 0x06, 0x1D);
            L00DC: return; // RETURN;
        }

        private void FnBATTLED_3A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L002C;
            L0010: AddEncounter(player, 0x01, 0x1A);
            L0022: PushStack(player, 0x26);
1453  0026 B8 05 00  mov ax, 0x5
            L0029: goto L00C7;
            L002C: Compare(PartyCount(player), 0x0002);
            L0037: if (JumpNotEqual) goto L0078;
            L0039: AddEncounter(player, 0x01, 0x1A);
            L004B: AddEncounter(player, 0x02, 0x1B);
            L005D: AddEncounter(player, 0x03, 0x1C);
            L006F: PushStack(player, 0x26);
14A0  0073 B8 04 00  mov ax, 0x4
            L0076: goto L00C7;
            L0078: AddEncounter(player, 0x01, 0x1A);
            L008A: AddEncounter(player, 0x02, 0x1A);
            L009C: AddEncounter(player, 0x04, 0x1B);
            L00AE: AddEncounter(player, 0x05, 0x25);
            L00C0: AddEncounter(player, 0x06, 0x26);
            L00D2: return; // RETURN;
        }

        private void FnBATTLEE_3B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L002C;
            L0010: AddEncounter(player, 0x01, 0x27);
            L0022: PushStack(player, 0x28);
1527  0026 B8 05 00  mov ax, 0x5
            L0029: goto L00B5;
            L002C: Compare(PartyCount(player), 0x0002);
            L0037: if (JumpNotEqual) goto L0066;
            L0039: AddEncounter(player, 0x01, 0x27);
            L004B: AddEncounter(player, 0x02, 0x27);
            L005D: PushStack(player, 0x28);
1562  0061 B8 03 00  mov ax, 0x3
            L0064: goto L00A3;
            L0066: AddEncounter(player, 0x01, 0x28);
            L0078: AddEncounter(player, 0x02, 0x28);
            L008A: AddEncounter(player, 0x03, 0x27);
            L009C: AddEncounter(player, 0x05, 0x19);
            L00AE: AddEncounter(player, 0x06, 0x19);
            L00C0: return; // RETURN;
        }

        private void FnBATTLEC_3C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetWallPassable(player, GetCurrentTile(player), 0x02, 0x00);
            L001C: Compare(PartyCount(player), 0x0001);
            L0027: if (JumpNotEqual) goto L002F;
            L0029: PushStack(player, 0x01);
            L002D: goto L008E;
            L002F: Compare(PartyCount(player), 0x0002);
            L003A: if (JumpNotEqual) goto L0054;
            L003C: PushStack(player, 0x01);
            L0040: PushStack(player, ax);
1604  0041 C4 5E 06  les bx, [bp+0x6]
1607  0044 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L0049: cx = PopStack(player);
            L004A: cx = PopStack(player);
            L004B: PushStack(player, 0x03);
1612  004F B8 02 00  mov ax, 0x2
            L0052: goto L008E;
            L0054: PushStack(player, 0x01);
            L0058: PushStack(player, ax);
161C  0059 C4 5E 06  les bx, [bp+0x6]
161F  005C 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L0061: cx = PopStack(player);
            L0062: cx = PopStack(player);
            L0063: AddEncounter(player, 0x02, 0x04);
            L0075: AddEncounter(player, 0x05, 0x21);
            L0087: AddEncounter(player, 0x06, 0x21);
            L0099: return; // RETURN;
        }

        private void FnBATTLEF_3D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L001A;
            L0010: PushStack(player, 0x0D);
1672  0014 B8 01 00  mov ax, 0x1
            L0017: goto L00B5;
            L001A: Compare(PartyCount(player), 0x0002);
            L0025: if (JumpNotEqual) goto L0066;
            L0027: AddEncounter(player, 0x01, 0x0C);
            L0039: AddEncounter(player, 0x02, 0x0D);
            L004B: AddEncounter(player, 0x03, 0x24);
            L005D: PushStack(player, 0x24);
16BF  0061 B8 04 00  mov ax, 0x4
            L0064: goto L00B5;
            L0066: AddEncounter(player, 0x01, 0x0C);
            L0078: AddEncounter(player, 0x02, 0x0C);
            L008A: AddEncounter(player, 0x03, 0x0D);
            L009C: AddEncounter(player, 0x04, 0x0D);
            L00AE: AddEncounter(player, 0x05, 0x24);
            L00C0: return; // RETURN;
        }

        private void FnPARTYCT_3E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L001F;
            L0010: ShowMessage(player, String0EDE); // Now you may proceed to pick the path of your choice.
            L001D: goto L003A;
            L001F: TeleportParty(player, 0x0A, 0x03, 0x22, 0x02, isForwardMove);
            L003A: return; // RETURN;
        }

        private void FnNORTH_3F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetWallPassable(player, GetCurrentTile(player), 0x03, 0x00);
            L001C: return; // RETURN;
        }

        private void FnEAST_40(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetWallPassable(player, GetCurrentTile(player), 0x02, 0x00);
            L001C: return; // RETURN;
        }

        private void FnWEST_41(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetWallPassable(player, GetCurrentTile(player), ax, 0x00);
            L0019: return; // RETURN;
        }

        private void FnSOUTH_42(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetWallPassable(player, GetCurrentTile(player), 0x01, 0x00);
            L001C: return; // RETURN;
        }

        private void FnSW_43(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetWallPassable(player, GetCurrentTile(player), 0x01, 0x00);
            L001C: SetWallPassable(player, GetCurrentTile(player), ax, 0x00);
            L0032: return; // RETURN;
        }

        private void FnEASTWEST_44(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetWallPassable(player, GetCurrentTile(player), 0x02, 0x00);
            L001C: SetWallPassable(player, GetCurrentTile(player), ax, 0x00);
            L0032: return; // RETURN;
        }

        private void FnNTWEST_45(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetWallPassable(player, GetCurrentTile(player), 0x03, 0x00);
            L001C: SetWallPassable(player, GetCurrentTile(player), ax, 0x00);
            L0032: return; // RETURN;
        }

        private void FnNTHSTH_46(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetWallPassable(player, GetCurrentTile(player), 0x03, 0x00);
            L001C: SetWallPassable(player, GetCurrentTile(player), 0x01, 0x00);
            L0035: return; // RETURN;
        }

        private void FnEASTSTH_47(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetWallPassable(player, GetCurrentTile(player), 0x02, 0x00);
            L001C: SetWallPassable(player, GetCurrentTile(player), 0x01, 0x00);
            L0035: return; // RETURN;
        }

        private void FnNTHEAST_48(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetWallPassable(player, GetCurrentTile(player), 0x03, 0x00);
            L001C: SetWallPassable(player, GetCurrentTile(player), 0x02, 0x00);
            L0035: return; // RETURN;
        }

        private void FnNTEASTH_49(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetWallPassable(player, GetCurrentTile(player), 0x03, 0x00);
            L001C: SetWallPassable(player, GetCurrentTile(player), 0x01, 0x00);
            L0035: SetWallPassable(player, GetCurrentTile(player), 0x02, 0x00);
            L004E: return; // RETURN;
        }

        private void FnEASTHWE_4A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetWallPassable(player, GetCurrentTile(player), 0x02, 0x00);
            L001C: SetWallPassable(player, GetCurrentTile(player), 0x01, 0x00);
            L0035: SetWallPassable(player, GetCurrentTile(player), ax, 0x00);
            L004B: return; // RETURN;
        }

        private void FnNTEAWEST_4B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetWallPassable(player, GetCurrentTile(player), 0x03, 0x00);
            L001C: SetWallPassable(player, GetCurrentTile(player), 0x02, 0x00);
            L0035: SetWallPassable(player, GetCurrentTile(player), ax, 0x00);
            L004B: return; // RETURN;
        }

        private void FnNTSTHWE_4C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetWallPassable(player, GetCurrentTile(player), 0x03, 0x00);
            L001C: SetWallPassable(player, GetCurrentTile(player), 0x01, 0x00);
            L0035: SetWallPassable(player, GetCurrentTile(player), ax, 0x00);
            L004B: return; // RETURN;
        }

        private void FnZWALLW_4D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0xF0);
            L0011: if (JumpEqual) goto L0017;
1A5C  0013 33 C0  xor ax, ax
            L0015: goto L001A;
            L0017: SetWallPassable(player, GetCurrentTile(player), 0x00, 0x01);
            L0030: return; // RETURN;
        }

        private void FnXWALLS_4E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0xF0);
            L0011: if (JumpEqual) goto L0018;
1A8E  0013 B8 01 00  mov ax, 0x1
            L0016: goto L001A;
            L0018: SetWallPassable(player, GetCurrentTile(player), 0x01, 0x00);
            L0031: return; // RETURN;
        }

        private void FnZWALLWB_4F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0xF0);
            L0011: if (JumpEqual) goto L0017;
1AC1  0013 33 C0  xor ax, ax
            L0015: goto L001A;
            L0017: SetWallPassable(player, GetCurrentTile(player), 0x00, 0x01);
            L0030: return; // RETURN;
        }

        private void FnXWALLNW_50(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0xF0);
            L0011: if (JumpEqual) goto L0018;
1AF3  0013 B8 01 00  mov ax, 0x1
            L0016: goto L001A;
            L0018: SetWallPassable(player, GetCurrentTile(player), 0x01, 0x00);
            L0031: return; // RETURN;
        }

        private void FnXWSZWE_51(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0xF0);
            L0011: if (JumpEqual) goto L0031;
            L0013: SetWallPassable(player, GetCurrentTile(player), 0x02, 0x00);
1B3F  002C B8 01 00  mov ax, 0x1
            L002F: goto L004D;
            L0031: SetWallPassable(player, GetCurrentTile(player), 0x02, 0x01);
            L004B: SetWallPassable(player, GetCurrentTile(player), 0x01, 0x00);
            L0064: return; // RETURN;
        }

        private void FnZWALLSTH_52(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0xF0);
            L0011: if (JumpEqual) goto L0017;
1B8C  0013 33 C0  xor ax, ax
            L0015: goto L001A;
            L0017: SetWallPassable(player, GetCurrentTile(player), 0x01, 0x01);
            L0031: return; // RETURN;
        }

        private void FnZWALLN_53(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0xF0);
            L0011: if (JumpEqual) goto L0017;
1BBF  0013 33 C0  xor ax, ax
            L0015: goto L001A;
            L0017: SetWallPassable(player, GetCurrentTile(player), 0x03, 0x01);
            L0031: return; // RETURN;
        }

        private void FnELEMTX_54(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0F13); // Proceed through this door and accept the challenge of the elements in order to gain access to Malos, the Dralkarian who controls the elements. Be aware that all Quest items gained from other paths will be taken from you.
            L0010: return; // RETURN;
        }

        private void FnPHYTEX_55(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0FF0); // Step through this door to overcome physical obstacles on your path to Corpeus, the Dralkarian who guards the gate. Be aware that all Quest items gained from other paths will be taken from you.
            L0010: return; // RETURN;
        }

        private void FnHVENTXT_56(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String10B1); // This door will lead you to the path through Enakkar in your search for the Dralkarian Juvalad. Be aware that all Quest items from other paths will be taken from you.
            L0010: return; // RETURN;
        }

        private void FnHELLTXT_57(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1157); // Through this door is Ashakkar. Succeed in your quest and you will find the Dralkarian Pluthros.  Be aware that all Quest items from other paths will be taken from you.
            L0010: return; // RETURN;
        }

        private void FnASTTXT_58(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String11FF); // Inside, a portal will teleport you to the astral path in order to find the Dralkarian guard Astelligus. Be aware that all Quest items from other paths will be taken from you.
            L0010: return; // RETURN;
        }

    }
}
