#pragma warning disable
using System;
using System.Collections.Generic;
using XPT.Legacy;
using XPT.Legacy.Entities;

namespace XPT.Legacy.Maps {
    class YserMap21 : AMapScripted {

        protected override int MapIndex => 21;
        protected override int RandomEncounterChance => 0;
        protected override int RandomEncounterExtraCount => 0;

        public YserMap21() {
            MapEvent01 = FnPIT_01;
            MapEvent02 = FnENCGUARD_02;
            MapEvent03 = FnENCEARTH_03;
            MapEvent04 = FnGUARDIAN_04;
            MapEvent05 = FnEARTHELE_05;
            MapEvent06 = FnPLATA_06;
            MapEvent07 = FnPLATB_07;
            MapEvent08 = FnYBOXA_08;
            MapEvent09 = FnYBOXB_09;
            MapEvent0A = FnYBOXC_0A;
            MapEvent0B = FnYBOXD_0B;
            MapEvent0C = FnYBOXE_0C;
            MapEvent0D = FnYBOXF_0D;
            MapEvent0E = FnXBOXG_0E;
            MapEvent0F = FnXBOXH_0F;
            MapEvent10 = FnXBOXI_10;
            MapEvent11 = FnXBOXJ_11;
            MapEvent12 = FnXBOXK_12;
            MapEvent13 = FnXBOXL_13;
            MapEvent14 = FnXBOXM_14;
            MapEvent15 = FnPITAJ_15;
            MapEvent16 = FnPITAK_16;
            MapEvent17 = FnPITAL_17;
            MapEvent18 = FnPITAM_18;
            MapEvent19 = FnPITBG_19;
            MapEvent1A = FnPITBI_1A;
            MapEvent1B = FnPITBJ_1B;
            MapEvent1C = FnPITBK_1C;
            MapEvent1D = FnPITBL_1D;
            MapEvent1E = FnPITBM_1E;
            MapEvent1F = FnPITCG_1F;
            MapEvent20 = FnPITCH_20;
            MapEvent21 = FnPITCI_21;
            MapEvent22 = FnPITCJ_22;
            MapEvent23 = FnPITCK_23;
            MapEvent24 = FnPITCL_24;
            MapEvent25 = FnPITCM_25;
            MapEvent26 = FnPITDG_26;
            MapEvent27 = FnPITDH_27;
            MapEvent28 = FnPITDI_28;
            MapEvent29 = FnPITDJ_29;
            MapEvent2A = FnPITDK_2A;
            MapEvent2B = FnPITDL_2B;
            MapEvent2C = FnPITDM_2C;
            MapEvent2D = FnPITEG_2D;
            MapEvent2E = FnPITEH_2E;
            MapEvent2F = FnPITEI_2F;
            MapEvent30 = FnPITEJ_30;
            MapEvent31 = FnPITEK_31;
            MapEvent32 = FnPITFG_32;
            MapEvent33 = FnPITFH_33;
            MapEvent34 = FnPITFI_34;
            MapEvent35 = FnPITFJ_35;
            MapEvent36 = FnPITFK_36;
            MapEvent37 = FnPITFL_37;
            MapEvent38 = FnPITFM_38;
            MapEvent39 = FnENCPITBJ_39;
            MapEvent3A = FnENCPITDI_3A;
            MapEvent3B = FnPITENCDK_3B;
            MapEvent3C = FnPITENCBL_3C;
            MapEvent3D = FnDOORARNK_3D;
            MapEvent3E = FnTELEARNK_3E;
            MapEvent3F = FnSETEKILL_3F;
        }
        
        // === Strings ================================================
        private const string String03FC = "You step into a bottomless pit and die.";
        private const string String0424 = "Guardians stand ready.  'We are sworn to defend Arnakkian.'";
        private const string String0460 = "Earth Elemental Andreas rises from his mountainous perch.";
        private const string String049A = "Enlikil's Phantasm Guardians stand watch over the entrance to Arnakkian's Tomb.";
        private const string String04EA = "The earth elemental palace is filled with a bounty of priceless gems.  It seems to shake with great power.";
        private const string String0555 = "The Endless Void has ruptured your dimension and forms a chasm between here and a distant platform.";
        private const string String05B8 = "Heroes who work together can bridge the gap of time. A yellow gem shall suffice if you are alone.";
        private const string String05FC = "Quiet solitude fills the chasm.  You are on the other side.";
        private const string String0737 = "You step over the edge and into oblivion.";
        private const string String1147 = "Andreas no longer defends this door.";
        private const string String116C = "The Earth Elemental holds power over this door.";
        private const string String119C = "A magic field grabs you and teleports you down into Arnakkian's tomb.  The laugh of an ancient archmage fills the chamber.";

        private int _TileBridgeY = 0, _TileBridgeX = 0;

        // === Functions ================================================
        private void FnPIT_01(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String03FC); // You step into a bottomless pit and die.
            L0010: DamagePlayer(player, GetMaxHits(player));
            L0021: return; // RETURN;
        }

        private void FnENCGUARD_02(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0424); // Guardians stand ready.  'We are sworn to defend Arnakkian.'
            L0010: AddEncounter(player, 0x01, 0x27);
            L0022: AddEncounter(player, 0x02, 0x27);
            L0034: AddEncounter(player, 0x03, 0x27);
            L0046: AddEncounter(player, 0x04, 0x27);
            L0058: AddEncounter(player, 0x05, 0x27);
            L006A: RefreshCompareFlags(GetFlag(player, FlagTypeDungeon, FlagCastleParapetsGuardiansExperience));
            L007D: if (JumpNotEqual) goto L00A6;
            L007F: SetFlag(player, FlagTypeDungeon, FlagCastleParapetsGuardiansExperience, 0x01);
            L0094: AddExperience(player, 0x0007A120);
            L00A6: return; // RETURN;
        }

        private void FnENCEARTH_03(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, FlagTypeMap, 0x01));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L0123;
            L001B: ShowMessage(player, String0460); // Earth Elemental Andreas rises from his mountainous perch.
            L0028: AddEncounter(player, 0x01, 0x04);
            L003A: AddEncounter(player, 0x02, 0x04);
            L004C: AddEncounter(player, 0x03, 0x22);
            L005E: AddEncounter(player, 0x04, 0x0F);
            L0070: AddEncounter(player, 0x05, 0x23);
            L0082: AddEncounter(player, 0x06, 0x28);
            L0094: ax = HasItem(player, 0xE9);
            L00A2: if (JumpEqual) goto L00C6;
            L00A4: AddTreasure(player, 0x0000, 0x00, 0x00, 0x50, 0x50, 0xD0);
            L00C4: goto L0123;
            L00C6: AddTreasure(player, 0x03E8, 0x00, 0x00, 0x88, 0x1D, 0xE9);
            L00E7: RefreshCompareFlags(GetFlag(player, FlagTypeDungeon, FlagCastleParapetsAndreasExperience));
            L00FA: if (JumpNotEqual) goto L0123;
            L00FC: SetFlag(player, FlagTypeDungeon, FlagCastleParapetsAndreasExperience, 0x01);
            L0111: AddExperience(player, 0x0003D090);
            L0123: return; // RETURN;
        }

        private void FnGUARDIAN_04(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String049A); // Enlikil's Phantasm Guardians stand watch over the entrance to Arnakkian's Tomb.
            L0010: return; // RETURN;
        }

        private void FnEARTHELE_05(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, FlagTypeMap, 0x01));
            L0016: if (JumpNotEqual) goto L0025;
            L0018: ShowMessage(player, String04EA); // The earth elemental palace is filled with a bounty of priceless gems.  It seems to shake with great power.
            L0025: return; // RETURN;
        }

        private void FnPLATA_06(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0555); // The Endless Void has ruptured your dimensionand forms a chasm between here and a distant platform.
            L0010: ShowMessage(player, String05B8); // A voice whispers 'Only true friendship can bridge the gap of time.'
            L001D: return; // RETURN;
        }

        private void FnPLATB_07(ServerPlayer player, bool isForwardMove) {
            ShowMessage(player, String05FC); // Quiet solitude fills the chasm.  You are on the other side.
            SetFlag(player, FlagTypeDungeon, FlagMedievaLandsCastleParapetsBridge, 1);
        }

        private void FnYBOXA_08(ServerPlayer player, bool isForwardMove) {
            ShowMessage(player, "The wall glows when you touch it. You feel air rushing past you to the East.");
            SetBridgeVariables(1, _TileBridgeX);
        }

        private void FnYBOXB_09(ServerPlayer player, bool isForwardMove) {
            ShowMessage(player, "The wall glows when you touch it. You feel air rushing past you to the East.");
            SetBridgeVariables(2, _TileBridgeX);
        }

        private void FnYBOXC_0A(ServerPlayer player, bool isForwardMove) {
            ShowMessage(player, "The wall glows when you touch it. You feel air rushing past you to the East.");
            SetBridgeVariables(3, _TileBridgeX);
        }

        private void FnYBOXD_0B(ServerPlayer player, bool isForwardMove) {
            ShowMessage(player, "The wall glows when you touch it. You feel air rushing past you to the East.");
            SetBridgeVariables(4, _TileBridgeX);
        }

        private void FnYBOXE_0C(ServerPlayer player, bool isForwardMove) {
            ShowMessage(player, "The wall glows when you touch it. You feel air rushing past you to the East.");
            SetBridgeVariables(5, _TileBridgeX);
        }

        private void FnYBOXF_0D(ServerPlayer player, bool isForwardMove) {
            ShowMessage(player, "The wall glows when you touch it. You feel air rushing past you to the East.");
            SetBridgeVariables(6, _TileBridgeX);
        }

        private void FnXBOXG_0E(ServerPlayer player, bool isForwardMove) {
            ShowMessage(player, "The wall glows when you touch it. You feel air rushing past you to the North.");
            SetBridgeVariables(_TileBridgeY, 1);
        }

        private void FnXBOXH_0F(ServerPlayer player, bool isForwardMove) {
            ShowMessage(player, "The wall glows when you touch it. You feel air rushing past you to the North.");
            SetBridgeVariables(_TileBridgeY, 2);
        }

        private void FnXBOXI_10(ServerPlayer player, bool isForwardMove) {
            ShowMessage(player, "The wall glows when you touch it. You feel air rushing past you to the North.");
            SetBridgeVariables(_TileBridgeY, 3);
        }

        private void FnXBOXJ_11(ServerPlayer player, bool isForwardMove) {
            ShowMessage(player, "The wall glows when you touch it. You feel air rushing past you to the North.");
            SetBridgeVariables(_TileBridgeY, 4);
        }

        private void FnXBOXK_12(ServerPlayer player, bool isForwardMove) {
            ShowMessage(player, "The wall glows when you touch it. You feel air rushing past you to the North.");
            SetBridgeVariables(_TileBridgeY, 5);
        }

        private void FnXBOXL_13(ServerPlayer player, bool isForwardMove) {
            ShowMessage(player, "The wall glows when you touch it. You feel air rushing past you to the North.");
            SetBridgeVariables(_TileBridgeY, 6);
        }

        private void FnXBOXM_14(ServerPlayer player, bool isForwardMove) {
            ShowMessage(player, "The wall glows when you touch it. You feel air rushing past you to the North.");
            SetBridgeVariables(_TileBridgeY, 7);
        }

        private void SetBridgeVariables(int y, int x) {
            // the first tile is at map position 5, 6
            // this corresponds to tileBridgeX/Y 1/1
            _TileBridgeX = x;
            _TileBridgeY = y;
            int playerX = _TileBridgeX + 5;
            int playerY = _TileBridgeY + 4;
            foreach (ServerPlayer player in Mobiles) {
                if (player.Position.X == playerX) {
                    if (playerY == player.Position.Y - 1) {
                        ShowMessage(player, "A path forms in the air to the North.");
                    }
                    if (playerY == player.Position.Y + 1) {
                        ShowMessage(player, "A path forms in the air to the South.");
                    }
                }
                if (player.Position.Y == playerY) {
                    if (playerX == player.Position.X - 1) {
                        ShowMessage(player, "A path forms in the air to the West.");
                    }
                    if (playerX == player.Position.X + 1) {
                        ShowMessage(player, "A path forms in the air to the East.");
                    }
                }
            }
        }

        private void DoAttemptWalkThroughVoid(ServerPlayer player, int y, int x, string successMessage) {
            // the first tile is at map position 5, 6
            // this corresponds to tileBridgeX/Y 1/1
            if (_TileBridgeX == x && _TileBridgeY == y) {
                ShowMessage(player, successMessage);
                return;
            }
            if (player.PartyLeader.HasItemByTypeIndex(245)) {
                ShowMessage(player, "The yellow rainbow gem illuminates a path through the Void.");
                return;
            }
            ShowMessage(player, String0737); // You step over the edge and into oblivion.
            DamagePlayer(player, GetMaxHits(player));
        }

        private void FnPITAJ_15(ServerPlayer player, bool isForwardMove) {
            DoAttemptWalkThroughVoid(player, 1, 4, "You step on solid air. This was a wise move.");
        }

        private void FnPITAK_16(ServerPlayer player, bool isForwardMove) {
            DoAttemptWalkThroughVoid(player, 1, 5, "You selected your next move wisely.");
        }

        private void FnPITAL_17(ServerPlayer player, bool isForwardMove) {
            DoAttemptWalkThroughVoid(player, 1, 6, "Your next step is a safe one.");
        }

        private void FnPITAM_18(ServerPlayer player, bool isForwardMove) {
            DoAttemptWalkThroughVoid(player, 1, 7, "The step you take is wisely chosen.");
        }

        private void FnPITBG_19(ServerPlayer player, bool isForwardMove) {
            DoAttemptWalkThroughVoid(player, 2, 1, "You take one good step forward.");
        }

        private void FnPITBI_1A(ServerPlayer player, bool isForwardMove) {
            DoAttemptWalkThroughVoid(player, 2, 3, "You safely step forward.");
        }

        private void FnPITBJ_1B(ServerPlayer player, bool isForwardMove) {
            DoAttemptWalkThroughVoid(player, 2, 4, "You take a step in the right direction.");
        }

        private void FnPITBK_1C(ServerPlayer player, bool isForwardMove) {
            DoAttemptWalkThroughVoid(player, 2, 5, "Your move is wise.");
        }

        private void FnPITBL_1D(ServerPlayer player, bool isForwardMove) {
            DoAttemptWalkThroughVoid(player, 2, 6, "You select your next move wisely.");
        }

        private void FnPITBM_1E(ServerPlayer player, bool isForwardMove) {
            DoAttemptWalkThroughVoid(player, 2, 7, "You move forward with confidence.");
        }

        private void FnPITCG_1F(ServerPlayer player, bool isForwardMove) {
            DoAttemptWalkThroughVoid(player, 3, 1, "Your next step is a good one.");
        }

        private void FnPITCH_20(ServerPlayer player, bool isForwardMove) {
            DoAttemptWalkThroughVoid(player, 3, 2, "You move ahead assuredly.");
        }

        private void FnPITCI_21(ServerPlayer player, bool isForwardMove) {
            DoAttemptWalkThroughVoid(player, 3, 3, "You choose your next step correctly.");
        }

        private void FnPITCJ_22(ServerPlayer player, bool isForwardMove) {
            DoAttemptWalkThroughVoid(player, 3, 4, "Your choice of movement saves you.");
        }

        private void FnPITCK_23(ServerPlayer player, bool isForwardMove) {
            DoAttemptWalkThroughVoid(player, 3, 5, "You step in the right direction.");
        }

        private void FnPITCL_24(ServerPlayer player, bool isForwardMove) {
            DoAttemptWalkThroughVoid(player, 3, 6, "You select your next step wisely.");
        }

        private void FnPITCM_25(ServerPlayer player, bool isForwardMove) {
            DoAttemptWalkThroughVoid(player, 3, 7, "Your next step is sagely chosen.");
        }

        private void FnPITDG_26(ServerPlayer player, bool isForwardMove) {
            DoAttemptWalkThroughVoid(player, 4, 1, "You take a wise step forward.");
        }

        private void FnPITDH_27(ServerPlayer player, bool isForwardMove) {
            DoAttemptWalkThroughVoid(player, 4, 2, "You move forward wisely.");
        }

        private void FnPITDI_28(ServerPlayer player, bool isForwardMove) {
            DoAttemptWalkThroughVoid(player, 4, 3, "Your next step is wisely decided.");
        }

        private void FnPITDJ_29(ServerPlayer player, bool isForwardMove) {
            DoAttemptWalkThroughVoid(player, 4, 4, "You step ahead with confidence.");
        }

        private void FnPITDK_2A(ServerPlayer player, bool isForwardMove) {
            DoAttemptWalkThroughVoid(player, 4, 5, "You move forward carefully.");
        }

        private void FnPITDL_2B(ServerPlayer player, bool isForwardMove) {
            DoAttemptWalkThroughVoid(player, 4, 6, "You move ahead.");
        }

        private void FnPITDM_2C(ServerPlayer player, bool isForwardMove) {
            DoAttemptWalkThroughVoid(player, 4, 7, "Your step is wisely selected.");
        }

        private void FnPITEG_2D(ServerPlayer player, bool isForwardMove) {
            DoAttemptWalkThroughVoid(player, 5, 1, "You forge ahead.");
        }

        private void FnPITEH_2E(ServerPlayer player, bool isForwardMove) {
            DoAttemptWalkThroughVoid(player, 5, 2, "You select your next move wisely.");
        }

        private void FnPITEI_2F(ServerPlayer player, bool isForwardMove) {
            DoAttemptWalkThroughVoid(player, 5, 3, "Good sense guides your feet.");
        }

        private void FnPITEJ_30(ServerPlayer player, bool isForwardMove) {
            DoAttemptWalkThroughVoid(player, 5, 4, "You walk ahead.");
        }

        private void FnPITEK_31(ServerPlayer player, bool isForwardMove) {
            DoAttemptWalkThroughVoid(player, 5, 5, "Your next step is assuredly taken.");
        }

        private void FnPITFG_32(ServerPlayer player, bool isForwardMove) {
            DoAttemptWalkThroughVoid(player, 6, 1, "The next step is an intelligent one.");
        }

        private void FnPITFH_33(ServerPlayer player, bool isForwardMove) {
            DoAttemptWalkThroughVoid(player, 6, 2, "You move safely ahead.");
        }

        private void FnPITFI_34(ServerPlayer player, bool isForwardMove) {
            DoAttemptWalkThroughVoid(player, 6, 3, "Your move was correct.");
        }

        private void FnPITFJ_35(ServerPlayer player, bool isForwardMove) {
            DoAttemptWalkThroughVoid(player, 6, 4, "You move forward with confidence.");
        }

        private void FnPITFK_36(ServerPlayer player, bool isForwardMove) {
            DoAttemptWalkThroughVoid(player, 6, 5, "You carefully selected your next step.");
        }

        private void FnPITFL_37(ServerPlayer player, bool isForwardMove) {
            DoAttemptWalkThroughVoid(player, 6, 6, "You make a sage choice.");
        }

        private void FnPITFM_38(ServerPlayer player, bool isForwardMove) {
            DoAttemptWalkThroughVoid(player, 6, 7, "You have made a wise decision.");
        }

        private void FnENCPITBJ_39(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(player, 0x01, 0x19);
            L0015: AddEncounter(player, 0x02, 0x1A);
            L0027: AddEncounter(player, 0x03, 0x1A);
            L0039: AddEncounter(player, 0x04, 0x1B);
            L004B: AddEncounter(player, 0x05, 0x1C);
            L005D: return; // RETURN;
        }

        private void FnENCPITDI_3A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(player, 0x01, 0x1F);
            L0015: AddEncounter(player, 0x02, 0x1F);
            L0027: AddEncounter(player, 0x03, 0x20);
            L0039: AddEncounter(player, 0x04, 0x20);
            L004B: return; // RETURN;
        }

        private void FnPITENCDK_3B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(player, 0x01, 0x1B);
            L0015: AddEncounter(player, 0x02, 0x1B);
            L0027: AddEncounter(player, 0x03, 0x19);
            L0039: AddEncounter(player, 0x04, 0x19);
            L004B: AddEncounter(player, 0x05, 0x1B);
            L005D: AddEncounter(player, 0x06, 0x1B);
            L006F: return; // RETURN;
        }

        private void FnPITENCBL_3C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(player, 0x01, 0x24);
            L0015: AddEncounter(player, 0x02, 0x24);
            L0027: AddEncounter(player, 0x03, 0x24);
            L0039: AddEncounter(player, 0x04, 0x25);
            L004B: AddEncounter(player, 0x05, 0x26);
            L005D: return; // RETURN;
        }

        private void FnDOORARNK_3D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, FlagTypeMap, 0x01));
            L0016: if (JumpEqual) goto L005B;
            L0018: SetWallPassable(player, GetCurrentTile(player), 0x03, 0x01);
            L0032: SetWallItem(player, 0x01, GetCurrentTile(player), 0x03);
            L004C: ShowMessage(player, String1147); // Andreas no longer defends this door.
            L0059: goto L0068;
            L005B: ShowMessage(player, String116C); // The Earth Elemental holds power over this door.
            L0068: return; // RETURN;
        }

        private void FnTELEARNK_3E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String119C); // A magic field grabs you and teleports you down into Arnakkian's tomb.  The laugh of an ancient archmage fills the chamber.
            L0010: TeleportParty(player, 0x34, 0x02, 0x76, 0x03, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnSETEKILL_3F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFlag(player, FlagTypeMap, 0x01, 0x01);
            L0018: return; // RETURN;
        }

    }
}
