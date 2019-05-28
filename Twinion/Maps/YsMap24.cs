#pragma warning disable
using System.Collections.Generic;
using XPT.WorldData;
using XPT.WorldData.Yserbius;

namespace XPT.Scripts.Yserbius.Maps {
    class YserMap24 : AMapScripted {
        protected override int MapIndex => 24;
        protected override int RandomEncounterChance => 15;
        protected override int RandomEncounterExtraCount => 2;

        public YserMap24() {
            MapEvent01 = FnTRANPRTA_01;
            MapEvent02 = FnTRANPRTB_02;
            MapEvent03 = FnTELEPRTC_03;
            MapEvent04 = FnTELEPRTD_04;
            MapEvent05 = FnTELEPRTE_05;
            MapEvent06 = FnTELEPRTF_06;
            MapEvent07 = FnTELEPRTF_07;
            MapEvent08 = FnTELEPRTG_08;
            MapEvent09 = FnTELEPRTI_09;
            MapEvent0A = FnFLAGDORA_0A;
            MapEvent0B = FnFLAGDORB_0B;
            MapEvent0C = FnFLAGDORC_0C;
            MapEvent0D = FnFLAGDORD_0D;
            MapEvent0E = FnFLAGDORE_0E;
            MapEvent0F = FnFLAGDORF_0F;
            MapEvent10 = FnFLAGDORG_10;
            MapEvent12 = FnFLAGDORI_12;
            MapEvent13 = FnSWCHDORB_13;
            MapEvent14 = FnSCHDORC_14;
            MapEvent15 = FnSWCHDORD_15;
            MapEvent16 = FnOPENDORJ_16;
            MapEvent17 = FnNEXTDORJ_17;
            MapEvent18 = FnOPENDORK_18;
            MapEvent19 = FnNEXTDORK_19;
            MapEvent1A = FnOPENDORL_1A;
            MapEvent1B = FnNEXTDORL_1B;
            MapEvent1C = FnOPENDORM_1C;
            MapEvent1D = FnNEXTDORM_1D;
            MapEvent1E = FnFLGDRBTP_1E;
            MapEvent1F = FnFLGDRCTP_1F;
            MapEvent20 = FnCLUETAPS_20;
            MapEvent21 = FnCHAOSDOR_21;
            MapEvent22 = FnHARMRDOR_22;
            MapEvent23 = FnDOORMESS_23;
            MapEvent24 = FnPAYOFF_24;
            MapEvent25 = FnKILLHARM_25;
            MapEvent26 = FnKILLCHAO_26;
            MapEvent27 = FnNPCCLUE_27;
            MapEvent28 = FnNPCCLUE_28;
            MapEvent29 = FnRUNECLUE_29;
            MapEvent2A = FnNPCCLUEB_2A;
            MapEvent2B = FnCLUE_2B;
            MapEvent2C = FnNPCCLUE_2C;
            MapEvent2E = FnNPCENCA_2E;
            MapEvent2F = FnNPCENCB_2F;
            MapEvent30 = FnMONSTERA_30;
            MapEvent31 = FnMONSTERB_31;
            MapEvent32 = FnSPECMONC_32;
            MapEvent33 = FnMONSTERD_33;
            MapEvent34 = FnMONSTERE_34;
            MapEvent35 = FnSPECMONF_35;
            MapEvent36 = FnSPECMONG_36;
            MapEvent37 = FnPAYOFFA_37;
            MapEvent38 = FnPAYOFFB_38;
            MapEvent39 = FnSHORTCUT_39;
            MapEvent3A = FnNOJOIN_3A;
        }
        
        // === Strings ================================================
        private const string String03FC = "Pandemonium ahead!";
        private const string String040F = "This will take you into sheer Pandemonium!";
        private const string String043A = "The door opens as you step forward.";
        private const string String045E = "A sign on the door -";
        private const string String0473 = "'Those blessed by the Fountain of the Better End may pass.'";
        private const string String04AF = "The door opens at your touch.";
        private const string String04CD = "The door does not budge.";
        private const string String04E6 = "The door is ajar.";
        private const string String04F8 = "The door will not open.";
        private const string String0510 = "The door is already open.";
        private const string String052A = "Touching the Unity Ring unlocks the door.";
        private const string String0554 = "The door is locked.";
        private const string String0568 = "The door lock springs open.";
        private const string String0584 = "The door does not open.";
        private const string String059C = "You find a secret door in the wall.";
        private const string String05C0 = "The door swings open.";
        private const string String05D6 = "Your burned hand swells in pain as you approach the open door.";
        private const string String0615 = "The Unity Ring burns the word 'Chaos' into your hand.";
        private const string String064B = "You are weakened by the agony of being branded.";
        private const string String067B = "Despite the pain, you manage to unlock the door.";
        private const string String06AC = "The heavy door does not budge.";
        private const string String06CB = "The door ahead is open.";
        private const string String06E3 = "Your charred hand throbs painfully as you open the door.";
        private const string String071C = "The Unity Ring burns the word 'Harmony' into your hand.";
        private const string String0754 = "You almost faint at the pain.";
        private const string String0772 = "Still, you manage to open the lock.";
        private const string String0796 = "A voice whispers -";
        private const string String07A9 = "'Onward, champion of Chaos! The next door will open safely for you.'";
        private const string String07EE = "A kind voice whispers -";
        private const string String0806 = "'Enter alone, you who have Unity in your heart.'";
        private const string String0837 = "A voice croaks -";
        private const string String0848 = "'Be careful, vile toady to Harmony, for without Unity you will suffer.'";
        private const string String0890 = "The door refuses to open.";
        private const string String08AA = "'Forward, champion of Harmony! The next door will open safely for you.'";
        private const string String08F2 = "'Enter alone, you with Unity in your heart.'";
        private const string String091F = "'Tread carefully, Chaotic bootlick, for without Unity you will suffer.'";
        private const string String0967 = "The door knob will not move.";
        private const string String0984 = "The way is already open for you.";
        private const string String09A5 = "You have taken the first step toward Unity!";
        private const string String09D1 = "You have the Ring that Unifies Chaos and Harmony.";
        private const string String0A03 = "Use it when you reach the last door.";
        private const string String0A28 = "'To complete your quest, you must have the Unity Ring.";
        private const string String0A5F = "The ring lies where the Clerics hold sway.";
        private const string String0A8A = "The way is now open to the inner path of the Clerics' way. Return to the Hopeless Hallways and seek the hidden door.";
        private const string String0AFF = "A lamp will light your way...if you look carefully.'";
        private const string String0B34 = "Continue, adventurer.";
        private const string String0B4A = "The second step toward Unity is complete. The third step can be found three rooms to the west. Retrace your path.";
        private const string String0BBC = "A heavenly voice proclaims -";
        private const string String0BD9 = "'This is the Door of Chaos.";
        private const string String0BF5 = "You must suffer much along the way, Beloved of Chaos, before the diverse ways are united.";
        private const string String0C4F = "Do not take the lowly spawn of Harmony with you, or they will die.'";
        private const string String0C93 = "A majestic voice announces -";
        private const string String0CB0 = "'The way is clear for wedded Harmony and Chaos to proceed.'";
        private const string String0CEC = "A celestial voice chimes out -";
        private const string String0D0B = "'This is the Door of Chaos. The child of Harmony should not yet pass this door.";
        private const string String0D5B = "Great woe awaits the child of Harmony who does not obey!'";
        private const string String0D95 = "You see a door upon which 'Chaos' is carved.";
        private const string String0DC2 = "'This is the Door of Harmony.";
        private const string String0DE0 = "You must suffer much along the way, Beloved of Harmony, before the diverse ways are united.";
        private const string String0E3C = "Do not yet take the lowly spawn of Chaos with you, or they will die.'";
        private const string String0E82 = "'The way is clear for wedded Harmony and Chaos to proceed together.'";
        private const string String0EC7 = "'This is the Door of Harmony. The child of Chaos should not yet pass this door.";
        private const string String0F17 = "Great woe awaits the child of Chaos who will not obey!'";
        private const string String0F4F = "You see a door upon which 'Harmony' is carved.";
        private const string String0F7E = "Beyond the door you hear a low rumbling.";
        private const string String0FA7 = "The room is empty.";
        private const string String0FBA = "Your burned hand is instantly healed.";
        private const string String0FE0 = "Your body tingles with new power.";
        private const string String1002 = "'United in your heart are the powers of Chaos and Harmony!";
        private const string String103D = "Find the Dralkarians and use your unified skills against them!'";
        private const string String107D = "An angry voice fills your head -";
        private const string String109E = "'Hated Harmonic! Die for disobeying the elders who created these caverns!";
        private const string String10E8 = "We strip from you more strength than you can bear to lose!'";
        private const string String1124 = "A booming voice surrounds you -";
        private const string String1144 = "'Die, thou miscreant spawn of Harmony! You may not traverse the way of Chaos yet!'";
        private const string String1197 = "'Hated Chaotic! Die for disobeying the elders who created these caverns!";
        private const string String11E0 = "'Die, thou miscreant spawn of Chaos! You may not traverse the way of Harmony yet!'";
        private const string String1233 = "'To finish this quest, you will have to visit places in the Hopeless Hallways you have not been able to enter.'";
        private const string String12A3 = "'You will have to detect the opening to the first secret room in Hopeless Hallways. It leads to the ring.'";
        private const string String130E = "'There is a place where what you walk on makes no difference...at times! I enjoyed my lava stroll.'";
        private const string String1372 = "'Do NOT enter a place antithetical to your affiliation until you are told to do so.'";
        private const string String13C7 = "'Once you get to the end of Concordia, you can use a shortcut teleport in the Hopeless Hallways.'";
        private const string String1429 = "'Beyond the realm of Pandemonium are the pathways to the Dralkarians.'";
        private const string String1470 = "'You believer in Harmony, do not enter the Chaos Door until the path is cleared.'";
        private const string String14C2 = "'You follower of Chaos, do not enter the Harmony Door until the path is cleared.'";
        private const string String1514 = "'The way is clear for one who has united Harmony and Chaos. Find the Dralkarians and defeat them, as you have been bid.'";
        private const string String158D = "'To find the Doors of Harmony and Chaos requires patience.";
        private const string String15C8 = "The walls around you lead one way and many ways.";
        private const string String15F9 = "May you be wise enough to find the true way.'";
        private const string String1627 = "'You have started along the right path leading to the Doors of Chaos and Harmony.";
        private const string String1679 = "Much you must suffer before you reach the final exit!'";
        private const string String16B0 = "The room has been looted.";
        private const string String16CA = "A soft voice whispers -";
        private const string String16E2 = "'Well done, child of Harmony. Behold your reward!'";
        private const string String1715 = "'Well done, child of Chaos. Behold your reward!'";
        private const string String1746 = "Enter one at a time.";
        
        // === Functions ================================================
        private void FnTRANPRTA_01(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x09, 0x02, 0x78, 0x00, isForwardMove);
            L001D: return; // RETURN;
        }

        private void FnTRANPRTB_02(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x0A, 0x02, 0xE1, 0x02, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnTELEPRTC_03(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = IsFlagOn(player, 0x02, 0x36);
            L0016: if (JumpEqual) goto L003F;
            L0018: Compare(PartyCount(player), 0x0001);
            L0023: if (JumpNotEqual) goto L003F;
            L0025: ShowMessage(player, String03FC); // Pandemonium ahead!
            L0032: PushStack(player, 0x01);
            L0036: PushStack(player, 0x9F);
0084  003A B8 03 00  mov ax, 0x3
            L003D: goto L004A;
            L003F: TeleportParty(player, 0x0A, 0x02, 0xE1, 0x02, isForwardMove);
            L005A: return; // RETURN;
        }

        private void FnTELEPRTD_04(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x0A, 0x02, 0xE1, 0x02, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnTELEPRTE_05(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x0A, 0x02, 0xE1, 0x02, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnTELEPRTF_06(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x09, 0x01, 0xF7, 0x03, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnTELEPRTF_07(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x08, 0x01, 0xE1, 0x00, isForwardMove);
            L001D: return; // RETURN;
        }

        private void FnTELEPRTG_08(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String040F); // This will take you into sheer Pandemonium!
            L0010: TeleportParty(player, 0x0A, 0x03, 0x9F, 0x01, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnTELEPRTI_09(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x0A, 0x02, 0xE1, 0x02, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnFLAGDORA_0A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = IsFlagOn(player, 0x02, 0x96);
            L0016: if (JumpEqual) goto L003E;
            L0018: ShowMessage(player, String043A); // The door opens as you step forward.
            L0025: SetWallPassable(player, GetCurrentTile(player), ax, 0x01);
            L003C: goto L0058;
            L003E: ShowMessage(player, String045E); // A sign on the door -
            L004B: ShowMessage(player, String0473); // 'Those blessed by the Fountain of the Better End may pass.'
            L0058: return; // RETURN;
        }

        private void FnFLAGDORB_0B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0xCB), 0x0001);
            L0017: if (JumpNotEqual) goto L0042;
            L0019: ShowMessage(player, String04AF); // The door opens at your touch.
            L0026: SetWallPassable(player, GetCurrentTile(player), 0x03, 0x01);
            L0040: goto L004F;
            L0042: ShowMessage(player, String04CD); // The door does not budge.
            L004F: return; // RETURN;
        }

        private void FnFLAGDORC_0C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0xCC), 0x0001);
            L0017: if (JumpNotEqual) goto L0042;
            L0019: ShowMessage(player, String04E6); // The door is ajar.
            L0026: SetWallPassable(player, GetCurrentTile(player), 0x03, 0x01);
            L0040: goto L004F;
            L0042: ShowMessage(player, String04F8); // The door will not open.
            L004F: return; // RETURN;
        }

        private void FnFLAGDORD_0D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0xCD), 0x0001);
            L0017: if (JumpNotEqual) goto L0042;
            L0019: ShowMessage(player, String0510); // The door is already open.
            L0026: SetWallPassable(player, GetCurrentTile(player), 0x03, 0x01);
            L0040: goto L009C;
            L0042: PushStack(player, 0xFE);
            L0046: PushStack(player, ax);
02B5  0047 C4 5E 06  les bx, [bp+0x6]
02B8  004A 26 FF 5F 54  call far word [es:bx+0x54]
            L004E: cx = PopStack(player);
            L004F: cx = PopStack(player);
            L0050: RefreshCompareFlags(ax);
            L0052: if (JumpEqual) goto L008F;
            L0054: ShowMessage(player, String052A); // Touching the Unity Ring unlocks the door.
            L0061: SetWallPassable(player, GetCurrentTile(player), 0x03, 0x01);
            L007B: PushStack(player, 0x01);
            L007F: PushStack(player, 0xCD);
            L0083: PushStack(player, 0x02);
02F5  0087 C4 5E 06  les bx, [bp+0x6]
02F8  008A 26 FF 1F  call far word [es:bx]
            L008D: goto L003D;
            L008F: ShowMessage(player, String0554); // The door is locked.
            L009C: return; // RETURN;
        }

        private void FnFLAGDORE_0E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0xC0);
            L0007: PushStack(player, ax);
0314  0008 C4 5E 06  les bx, [bp+0x6]
0317  000B 26 FF 5F 54  call far word [es:bx+0x54]
            L000F: cx = PopStack(player);
            L0010: cx = PopStack(player);
            L0011: RefreshCompareFlags(ax);
            L0013: if (JumpNotEqual) goto L0026;
            L0015: Compare(HasUsedSkill(player, 0x0E), 0x000C);
            L0024: if (JumpBelow) goto L0049;
            L0026: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
0350  0044 B8 68 05  mov ax, 0x568
            L0047: goto L004C;
            L0049: ShowMessage(player, String0584); // The door does not open.
            L0056: return; // RETURN;
        }

        private void FnFLAGDORF_0F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, 0x0D), 0x000C);
            L0012: if (JumpNotBelow) goto L006C;
            L0014: RefreshCompareFlags(HasUsedSpell(player, 0x17));
            L0022: if (JumpNotEqual) goto L006C;
            L0024: PushStack(player, 0x68);
            L0028: PushStack(player, ax);
038D  0029 C4 5E 06  les bx, [bp+0x6]
0390  002C 26 FF 5F 54  call far word [es:bx+0x54]
            L0030: cx = PopStack(player);
            L0031: cx = PopStack(player);
            L0032: RefreshCompareFlags(ax);
            L0034: if (JumpNotEqual) goto L006C;
            L0036: PushStack(player, 0x6E);
            L003A: PushStack(player, ax);
039F  003B C4 5E 06  les bx, [bp+0x6]
03A2  003E 26 FF 5F 54  call far word [es:bx+0x54]
            L0042: cx = PopStack(player);
            L0043: cx = PopStack(player);
            L0044: RefreshCompareFlags(ax);
            L0046: if (JumpNotEqual) goto L006C;
            L0048: PushStack(player, 0x90);
            L004C: PushStack(player, ax);
03B1  004D C4 5E 06  les bx, [bp+0x6]
03B4  0050 26 FF 5F 54  call far word [es:bx+0x54]
            L0054: cx = PopStack(player);
            L0055: cx = PopStack(player);
            L0056: RefreshCompareFlags(ax);
            L0058: if (JumpNotEqual) goto L006C;
            L005A: PushStack(player, 0xA4);
            L005E: PushStack(player, ax);
03C3  005F C4 5E 06  les bx, [bp+0x6]
03C6  0062 26 FF 5F 54  call far word [es:bx+0x54]
            L0066: cx = PopStack(player);
            L0067: cx = PopStack(player);
            L0068: RefreshCompareFlags(ax);
            L006A: if (JumpEqual) goto L00B5;
            L006C: ShowMessage(player, String059C); // You find a secret door in the wall.
            L0079: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0097: SetWallObject(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L00B5: return; // RETURN;
        }

        private void FnFLAGDORG_10(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = IsFlagOn(player, 0x02, 0x36);
            L0016: if (JumpEqual) goto L0046;
            L0018: ShowMessage(player, String05C0); // The door swings open.
            L0025: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0043: goto L010E;
            L0046: PushStack(player, 0xFE);
            L004A: PushStack(player, ax);
0466  004B C4 5E 06  les bx, [bp+0x6]
0469  004E 26 FF 5F 54  call far word [es:bx+0x54]
            L0052: cx = PopStack(player);
            L0053: cx = PopStack(player);
            L0054: RefreshCompareFlags(ax);
            L0056: if (JumpNotEqual) goto L005B;
            L0058: goto L0101;
            L005B: ax = IsFlagOn(player, 0x02, 0x37);
            L006E: if (JumpNotEqual) goto L0073;
            L0070: goto L010E;
            L0073: ax = IsFlagOn(player, 0x02, 0x38);
            L0086: if (JumpEqual) goto L008D;
04A3  0088 B8 D6 05  mov ax, 0x5d6
            L008B: goto L001B;
            L008D: ShowMessage(player, String0615); // The Unity Ring burns the word 'Chaos' into your hand.
            L009A: ShowMessage(player, String064B); // You are weakened by the agony of being branded.
            L00A7: ShowMessage(player, String067B); // Despite the pain, you manage to unlock the door.
            L00B4: SetFlag(player, 0x02, 0x38, 0x01);
            L00C9: AddExperience(player, 0x000249F0);
            L00DB: ModifyAttribute(player, 0x00, 0xFFFE);
            L00EC: ModifyAttribute(player, 0x01, 0xFFFE);
            L00FE: goto L0025;
            L0101: ShowMessage(player, String06AC); // The heavy door does not budge.
            L010E: return; // RETURN;
        }

        private void FnFLAGDORI_12(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = IsFlagOn(player, 0x02, 0x36);
            L0016: if (JumpEqual) goto L0046;
            L0018: ShowMessage(player, String06CB); // The door ahead is open.
            L0025: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0043: goto L010E;
            L0046: PushStack(player, 0xFE);
            L004A: PushStack(player, ax);
057B  004B C4 5E 06  les bx, [bp+0x6]
057E  004E 26 FF 5F 54  call far word [es:bx+0x54]
            L0052: cx = PopStack(player);
            L0053: cx = PopStack(player);
            L0054: RefreshCompareFlags(ax);
            L0056: if (JumpNotEqual) goto L005B;
            L0058: goto L0101;
            L005B: ax = IsFlagOn(player, 0x02, 0x35);
            L006E: if (JumpNotEqual) goto L0073;
            L0070: goto L010E;
            L0073: ax = IsFlagOn(player, 0x02, 0x38);
            L0086: if (JumpEqual) goto L008D;
05B8  0088 B8 E3 06  mov ax, 0x6e3
            L008B: goto L001B;
            L008D: ShowMessage(player, String071C); // The Unity Ring burns the word 'Harmony' into your hand.
            L009A: ShowMessage(player, String0754); // You almost faint at the pain.
            L00A7: ShowMessage(player, String0772); // Still, you manage to open the lock.
            L00B4: SetFlag(player, 0x02, 0x38, 0x01);
            L00C9: AddExperience(player, 0x000249F0);
            L00DB: ModifyAttribute(player, 0x00, 0xFFFE);
            L00EC: ModifyAttribute(player, 0x01, 0xFFFE);
            L00FE: goto L0025;
            L0101: ShowMessage(player, String0554); // The door is locked.
            L010E: return; // RETURN;
        }

        private void FnSWCHDORB_13(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0021: SetFlag(player, 0x02, 0xCE, 0x01);
            L0036: SetFlag(player, 0x02, 0xCF, 0x00);
            L004A: SetFlag(player, 0x02, 0xD0, 0x00);
            L005E: return; // RETURN;
        }

        private void FnSCHDORC_14(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0021: SetFlag(player, 0x02, 0xCF, 0x01);
            L0036: SetFlag(player, 0x02, 0xCE, 0x00);
            L004A: SetFlag(player, 0x02, 0xD0, 0x00);
            L005E: return; // RETURN;
        }

        private void FnSWCHDORD_15(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0021: SetFlag(player, 0x02, 0xD0, 0x01);
            L0036: SetFlag(player, 0x02, 0xCE, 0x00);
            L004A: SetFlag(player, 0x02, 0xCF, 0x00);
            L005E: return; // RETURN;
        }

        private void FnOPENDORJ_16(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = IsFlagOn(player, 0x02, 0xCF);
            L0016: if (JumpEqual) goto L0032;
            L0018: SetWallPassable(player, GetCurrentTile(player), 0x03, 0x01);
            L0032: return; // RETURN;
        }

        private void FnNEXTDORJ_17(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = IsFlagOn(player, 0x02, 0xD0);
            L0016: if (JumpEqual) goto L0032;
            L0018: SetWallPassable(player, GetCurrentTile(player), 0x02, 0x01);
            L0032: return; // RETURN;
        }

        private void FnOPENDORK_18(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetAlignment(player), 0x0001);
            L000E: if (JumpNotEqual) goto L005B;
            L0010: ax = IsFlagOn(player, 0x02, 0xD0);
            L0023: if (JumpEqual) goto L005B;
            L0025: ShowMessage(player, String0796); // A voice whispers -
            L0032: ShowMessage(player, String07A9); // 'Onward, champion of Chaos! The next door will open safely for you.'
            L003F: SetWallPassable(player, GetCurrentTile(player), 0x03, 0x01);
            L0059: goto L00D0;
            L005B: ax = IsFlagOn(player, 0x02, 0x36);
            L006E: if (JumpEqual) goto L008F;
            L0070: Compare(PartyCount(player), 0x0001);
            L007B: if (JumpNotEqual) goto L008F;
            L007D: ShowMessage(player, String07EE); // A kind voice whispers -
0852  008A B8 06 08  mov ax, 0x806
            L008D: goto L0035;
            L008F: RefreshCompareFlags(GetAlignment(player));
            L0099: if (JumpNotEqual) goto L00C3;
            L009B: ax = IsFlagOn(player, 0x02, 0xD0);
            L00AE: if (JumpEqual) goto L00C3;
            L00B0: ShowMessage(player, String0837); // A voice croaks -
0885  00BD B8 48 08  mov ax, 0x848
            L00C0: goto L0035;
            L00C3: ShowMessage(player, String0890); // The door refuses to open.
            L00D0: return; // RETURN;
        }

        private void FnNEXTDORK_19(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = IsFlagOn(player, 0x02, 0xCE);
            L0016: if (JumpNotEqual) goto L002D;
            L0018: ax = IsFlagOn(player, 0x02, 0xD0);
            L002B: if (JumpEqual) goto L0036;
            L002D: PushStack(player, 0x01);
08CB  0031 B8 02 00  mov ax, 0x2
            L0034: goto L0051;
            L0036: ax = IsFlagOn(player, 0x02, 0xCF);
            L0049: if (JumpEqual) goto L0064;
            L004B: SetWallPassable(player, GetCurrentTile(player), 0x00, 0x01);
            L0064: return; // RETURN;
        }

        private void FnOPENDORL_1A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetAlignment(player));
            L000D: if (JumpNotEqual) goto L005A;
            L000F: ax = IsFlagOn(player, 0x02, 0xD0);
            L0022: if (JumpEqual) goto L005A;
            L0024: ShowMessage(player, String0796); // A voice whispers -
            L0031: ShowMessage(player, String08AA); // 'Forward, champion of Harmony! The next door will open safely for you.'
            L003E: SetWallPassable(player, GetCurrentTile(player), 0x03, 0x01);
            L0058: goto L00D0;
            L005A: ax = IsFlagOn(player, 0x02, 0x36);
            L006D: if (JumpEqual) goto L008E;
            L006F: Compare(PartyCount(player), 0x0001);
            L007A: if (JumpNotEqual) goto L008E;
            L007C: ShowMessage(player, String07EE); // A kind voice whispers -
0989  0089 B8 F2 08  mov ax, 0x8f2
            L008C: goto L0034;
            L008E: Compare(GetAlignment(player), 0x0001);
            L0099: if (JumpNotEqual) goto L00C3;
            L009B: ax = IsFlagOn(player, 0x02, 0xD0);
            L00AE: if (JumpEqual) goto L00C3;
            L00B0: ShowMessage(player, String0837); // A voice croaks -
09BD  00BD B8 1F 09  mov ax, 0x91f
            L00C0: goto L0034;
            L00C3: ShowMessage(player, String0967); // The door knob will not move.
            L00D0: return; // RETURN;
        }

        private void FnNEXTDORL_1B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = IsFlagOn(player, 0x02, 0xCF);
            L0016: if (JumpNotEqual) goto L002D;
            L0018: ax = IsFlagOn(player, 0x02, 0xD0);
            L002B: if (JumpEqual) goto L0035;
            L002D: PushStack(player, 0x01);
0A03  0031 33 C0  xor ax, ax
            L0033: goto L0051;
            L0035: ax = IsFlagOn(player, 0x02, 0xCE);
            L0048: if (JumpEqual) goto L0064;
            L004A: SetWallPassable(player, GetCurrentTile(player), 0x02, 0x01);
            L0064: return; // RETURN;
        }

        private void FnOPENDORM_1C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = IsFlagOn(player, 0x02, 0xCE);
            L0016: if (JumpEqual) goto L0032;
            L0018: SetWallPassable(player, GetCurrentTile(player), 0x03, 0x01);
            L0032: return; // RETURN;
        }

        private void FnNEXTDORM_1D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = IsFlagOn(player, 0x02, 0xCF);
            L0016: if (JumpEqual) goto L0031;
            L0018: SetWallPassable(player, GetCurrentTile(player), 0x00, 0x01);
            L0031: return; // RETURN;
        }

        private void FnFLGDRBTP_1E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = IsFlagOn(player, 0x02, 0xCB);
            L0016: if (JumpNotEqual) goto L0042;
            L0018: ax = IsFlagOn(player, 0x02, 0xCC);
            L002B: if (JumpNotEqual) goto L0042;
            L002D: ax = IsFlagOn(player, 0x02, 0xCD);
            L0040: if (JumpEqual) goto L0050;
0AE1  0042 B8 84 09  mov ax, 0x984
            L0045: PushStack(player, ax);
0AE5  0046 C4 5E 06  les bx, [bp+0x6]
0AE8  0049 26 FF 9F F4 00  call far word [es:bx+0xf4]
            L004E: goto L0071;
            L0050: SetFlag(player, 0x02, 0xCB, 0x01);
            L0065: ShowMessage(player, String09A5); // You have taken the first step toward Unity!
            L0072: return; // RETURN;
        }

        private void FnFLGDRCTP_1F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0xFE);
            L0011: if (JumpEqual) goto L002F;
            L0013: ShowMessage(player, String09D1); // You have the Ring that Unifies Chaos and Harmony.
            L0020: ShowMessage(player, String0A03); // Use it when you reach the last door.
            L002D: goto L008C;
            L002F: ShowMessage(player, String0A28); // 'To complete your quest, you must have the Unity Ring.
            L003C: ShowMessage(player, String0A5F); // The ring lies where the Clerics hold sway.
            L0049: ShowMessage(player, String0A8A); // The way is now open to the inner path of the Clerics' way. Return to the Hopeless Hallways and seek the hidden door.
            L0056: ShowMessage(player, String0AFF); // A lamp will light your way...if you look carefully.'
            L0063: SetFlag(player, 0x02, 0x95, 0x01);
            L0078: SetFlag(player, 0x02, 0xCF, 0x00);
            L008C: return; // RETURN;
        }

        private void FnCLUETAPS_20(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = IsFlagOn(player, 0x02, 0xCC);
            L0016: if (JumpEqual) goto L0026;
0BB9  0018 B8 34 0B  mov ax, 0xb34
            L001B: PushStack(player, ax);
0BBD  001C C4 5E 06  les bx, [bp+0x6]
0BC0  001F 26 FF 9F F4 00  call far word [es:bx+0xf4]
            L0024: goto L006F;
            L0026: SetFlag(player, 0x02, 0xCC, 0x01);
            L003B: SetFlag(player, 0x02, 0xCB, 0x00);
            L004F: SetFlag(player, 0x02, 0xCD, 0x00);
            L0063: ShowMessage(player, String0B4A); // The second step toward Unity is complete. The third step can be found three rooms to the west. Retrace your path.
            L0070: return; // RETURN;
        }

        private void FnCHAOSDOR_21(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFlag(player, 0x02, 0xD0, 0x00);
            L0017: Compare(GetAlignment(player), 0x0001);
            L0022: if (JumpNotEqual) goto L0069;
            L0024: ax = HasItem(player, 0xFE);
            L0032: if (JumpEqual) goto L0069;
            L0034: ax = IsFlagOn(player, 0x02, 0x37);
            L0047: if (JumpEqual) goto L0069;
            L0049: Compare(PartyCount(player), 0x0001);
            L0054: if (JumpNotEqual) goto L0066;
0C69  0056 FF 76 08  push word [bp+0x8]
0C6C  0059 FF 76 06  push word [bp+0x6]
0C6F  005C 0E     push cs
0C70  005D E8 17 10  call 0x1077
            L0060: // NOP
            L0061: cx = PopStack(player);
            L0062: cx = PopStack(player);
            L0063: goto L01D6;
            L0066: goto L01BB;
            L0069: Compare(GetAlignment(player), 0x0001);
            L0074: if (JumpEqual) goto L0079;
            L0076: goto L0112;
            L0079: ax = HasItem(player, 0xFE);
            L0087: if (JumpNotEqual) goto L008C;
            L0089: goto L0112;
            L008C: ax = IsFlagOn(player, 0x02, 0x37);
            L009F: if (JumpNotEqual) goto L0112;
            L00A1: ShowMessage(player, String0BBC); // A heavenly voice proclaims -
            L00AE: ShowMessage(player, String0BD9); // 'This is the Door of Chaos.
            L00BB: ShowMessage(player, String0BF5); // You must suffer much along the way, Beloved of Chaos, before the diverse ways are united.
            L00C8: ShowMessage(player, String0C4F); // Do not take the lowly spawn of Harmony with you, or they will die.'
            L00D5: SetFlag(player, 0x02, 0x37, 0x01);
            L00EA: SetFlag(player, 0x03, 0x02, 0x01);
            L00FF: Compare(PartyCount(player), 0x0001);
            L010A: if (JumpNotEqual) goto L010F;
            L010C: goto L0056;
            L010F: goto L01BB;
            L0112: ax = IsFlagOn(player, 0x02, 0x36);
            L0125: if (JumpEqual) goto L0153;
            L0127: ShowMessage(player, String0C93); // A majestic voice announces -
            L0134: ShowMessage(player, String0CB0); // 'The way is clear for wedded Harmony and Chaos to proceed.'
            L0141: Compare(PartyCount(player), 0x0001);
            L014C: if (JumpNotEqual) goto L0151;
            L014E: goto L0056;
            L0151: goto L01BB;
            L0153: RefreshCompareFlags(GetAlignment(player));
            L015D: if (JumpNotEqual) goto L01C9;
            L015F: ax = HasItem(player, 0xFE);
            L016D: if (JumpEqual) goto L01C9;
            L016F: ax = IsFlagOn(player, 0x02, 0x35);
            L0182: if (JumpEqual) goto L01C9;
            L0184: ShowMessage(player, String0CEC); // A celestial voice chimes out -
            L0191: ShowMessage(player, String0D0B); // 'This is the Door of Chaos. The child of Harmony should not yet pass this door.
            L019E: ShowMessage(player, String0D5B); // Great woe awaits the child of Harmony who does not obey!'
            L01AB: Compare(PartyCount(player), 0x0001);
            L01B6: if (JumpNotEqual) goto L01BB;
            L01B8: goto L0056;
0DCE  01BB FF 76 08  push word [bp+0x8]
0DD1  01BE FF 76 06  push word [bp+0x6]
0DD4  01C1 0E     push cs
0DD5  01C2 E8 D1 0E  call 0x1096
            L01C5: // NOP
            L01C6: goto L0061;
            L01C9: ShowMessage(player, String0D95); // You see a door upon which 'Chaos' is carved.
            L01D6: return; // RETURN;
        }

        private void FnHARMRDOR_22(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetAlignment(player));
            L000D: if (JumpNotEqual) goto L0054;
            L000F: ax = HasItem(player, 0xFE);
            L001D: if (JumpEqual) goto L0054;
            L001F: ax = IsFlagOn(player, 0x02, 0x35);
            L0032: if (JumpEqual) goto L0054;
            L0034: Compare(PartyCount(player), 0x0001);
            L003F: if (JumpNotEqual) goto L0051;
0E2C  0041 FF 76 08  push word [bp+0x8]
0E2F  0044 FF 76 06  push word [bp+0x6]
0E32  0047 0E     push cs
0E33  0048 E8 54 0E  call 0xe9f
            L004B: // NOP
            L004C: cx = PopStack(player);
            L004D: cx = PopStack(player);
            L004E: goto L01BE;
            L0051: goto L01A3;
            L0054: RefreshCompareFlags(GetAlignment(player));
            L005E: if (JumpEqual) goto L0063;
            L0060: goto L00F9;
            L0063: ax = HasItem(player, 0xFE);
            L0071: if (JumpNotEqual) goto L0076;
            L0073: goto L00F9;
            L0076: ax = IsFlagOn(player, 0x02, 0x35);
            L0089: if (JumpNotEqual) goto L00F9;
            L008B: ShowMessage(player, String0BBC); // A heavenly voice proclaims -
            L0098: ShowMessage(player, String0DC2); // 'This is the Door of Harmony.
            L00A5: ShowMessage(player, String0DE0); // You must suffer much along the way, Beloved of Harmony, before the diverse ways are united.
            L00B2: ShowMessage(player, String0E3C); // Do not yet take the lowly spawn of Chaos with you, or they will die.'
            L00BF: SetFlag(player, 0x02, 0x35, 0x01);
            L00D4: PushStack(player, 0x01);
            L00D8: PushStack(player, ax);
            L00D9: PushStack(player, 0x03);
0EC8  00DD C4 5E 06  les bx, [bp+0x6]
0ECB  00E0 26 FF 1F  call far word [es:bx]
0ECE  00E3 83 C4 06  add sp, 0x6
            L00E6: Compare(PartyCount(player), 0x0001);
            L00F1: if (JumpNotEqual) goto L00F6;
            L00F3: goto L0041;
            L00F6: goto L01A3;
            L00F9: ax = IsFlagOn(player, 0x02, 0x36);
            L010C: if (JumpEqual) goto L013A;
            L010E: ShowMessage(player, String0C93); // A majestic voice announces -
            L011B: ShowMessage(player, String0E82); // 'The way is clear for wedded Harmony and Chaos to proceed together.'
            L0128: Compare(PartyCount(player), 0x0001);
            L0133: if (JumpNotEqual) goto L0138;
            L0135: goto L0041;
            L0138: goto L01A3;
            L013A: Compare(GetAlignment(player), 0x0001);
            L0145: if (JumpNotEqual) goto L01B1;
            L0147: ax = HasItem(player, 0xFE);
            L0155: if (JumpEqual) goto L01B1;
            L0157: ax = IsFlagOn(player, 0x02, 0x37);
            L016A: if (JumpEqual) goto L01B1;
            L016C: ShowMessage(player, String0CEC); // A celestial voice chimes out -
            L0179: ShowMessage(player, String0EC7); // 'This is the Door of Harmony. The child of Chaos should not yet pass this door.
            L0186: ShowMessage(player, String0F17); // Great woe awaits the child of Chaos who will not obey!'
            L0193: Compare(PartyCount(player), 0x0001);
            L019E: if (JumpNotEqual) goto L01A3;
            L01A0: goto L0041;
0F8E  01A3 FF 76 08  push word [bp+0x8]
0F91  01A6 FF 76 06  push word [bp+0x6]
0F94  01A9 0E     push cs
0F95  01AA E8 11 0D  call 0xebe
            L01AD: // NOP
            L01AE: goto L004C;
            L01B1: ShowMessage(player, String0F4F); // You see a door upon which 'Harmony' is carved.
            L01BE: return; // RETURN;
        }

        private void FnDOORMESS_23(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0F7E); // Beyond the door you hear a low rumbling.
            L0010: return; // RETURN;
        }

        private void FnPAYOFF_24(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0x36), 0x0001);
            L0017: if (JumpNotEqual) goto L0029;
            L0019: ShowMessage(player, String0FA7); // The room is empty.
            L0026: goto L013A;
            L0029: ax = HasItem(player, 0xFE);
            L0037: if (JumpNotEqual) goto L003C;
            L0039: goto L013A;
            L003C: Compare(GetFlag(player, 0x02, 0x35), 0x0001);
            L0050: if (JumpEqual) goto L006B;
            L0052: Compare(GetFlag(player, 0x02, 0x37), 0x0001);
            L0066: if (JumpEqual) goto L006B;
            L0068: goto L013A;
            L006B: ShowMessage(player, String0FBA); // Your burned hand is instantly healed.
            L0078: ShowMessage(player, String0FE0); // Your body tingles with new power.
            L0085: ShowMessage(player, String0796); // A voice whispers -
            L0092: ShowMessage(player, String1002); // 'United in your heart are the powers of Chaos and Harmony!
            L009F: ShowMessage(player, String103D); // Find the Dralkarians and use your unified skills against them!'
            L00AC: RemoveItem(player, 0xFE);
            L00B8: AddExperience(player, 0x000B71B0);
            L00CA: ModifyAttribute(player, 0x00, 0x0004);
            L00DB: ModifyAttribute(player, 0x01, 0x0003);
            L00ED: ModifyAttribute(player, 0x03, 0x0001);
            L00FF: SetFlag(player, 0x02, 0x36, 0x01);
            L0114: SetFlag(player, 0x02, 0x95, 0x00);
            L0128: PushStack(player, 0x01);
            L012C: PushStack(player, 0x03);
            L0130: PushStack(player, ax);
10EE  0131 C4 5E 06  les bx, [bp+0x6]
10F1  0134 26 FF 1F  call far word [es:bx]
10F4  0137 83 C4 06  add sp, 0x6
            L013A: return; // RETURN;
        }

        private void FnKILLHARM_25(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetAlignment(player));
            L000D: if (JumpNotEqual) goto L0088;
            L000F: RefreshCompareFlags(GetFlag(player, 0x02, 0x36));
            L0022: if (JumpNotEqual) goto L0088;
            L0024: RefreshCompareFlags(GetFlag(player, 0x02, 0x34));
            L0037: if (JumpNotEqual) goto L0088;
            L0039: ShowMessage(player, String107D); // An angry voice fills your head -
            L0046: ShowMessage(player, String109E); // 'Hated Harmonic! Die for disobeying the elders who created these caverns!
            L0053: ShowMessage(player, String10E8); // We strip from you more strength than you can bear to lose!'
            L0060: SetFlag(player, 0x02, 0x34, 0x01);
            L0075: ModifyAttribute(player, 0x00, 0xFFFE);
            L0086: goto L00D8;
            L0088: RefreshCompareFlags(GetAlignment(player));
            L0092: if (JumpNotEqual) goto L00E9;
            L0094: RefreshCompareFlags(GetFlag(player, 0x02, 0x36));
            L00A7: if (JumpNotEqual) goto L00E9;
            L00A9: RefreshCompareFlags(GetFlag(player, 0x02, 0x34));
            L00BC: if (JumpEqual) goto L00E9;
            L00BE: ShowMessage(player, String1124); // A booming voice surrounds you -
            L00CB: ShowMessage(player, String1144); // 'Die, thou miscreant spawn of Harmony! You may not traverse the way of Chaos yet!'
            L00D8: DamagePlayer(player, GetMaxHits(player));
            L00E9: return; // RETURN;
        }

        private void FnKILLCHAO_26(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetAlignment(player), 0x0001);
            L000E: if (JumpNotEqual) goto L0089;
            L0010: RefreshCompareFlags(GetFlag(player, 0x02, 0x36));
            L0023: if (JumpNotEqual) goto L0089;
            L0025: RefreshCompareFlags(GetFlag(player, 0x02, 0x32));
            L0038: if (JumpNotEqual) goto L0089;
            L003A: ShowMessage(player, String107D); // An angry voice fills your head -
            L0047: ShowMessage(player, String1197); // 'Hated Chaotic! Die for disobeying the elders who created these caverns!
            L0054: ShowMessage(player, String10E8); // We strip from you more strength than you can bear to lose!'
            L0061: SetFlag(player, 0x02, 0x32, 0x01);
            L0076: ModifyAttribute(player, 0x00, 0xFFFE);
            L0087: goto L00DA;
            L0089: Compare(GetAlignment(player), 0x0001);
            L0094: if (JumpNotEqual) goto L00EB;
            L0096: RefreshCompareFlags(GetFlag(player, 0x02, 0x36));
            L00A9: if (JumpNotEqual) goto L00EB;
            L00AB: RefreshCompareFlags(GetFlag(player, 0x02, 0x32));
            L00BE: if (JumpEqual) goto L00EB;
            L00C0: ShowMessage(player, String1124); // A booming voice surrounds you -
            L00CD: ShowMessage(player, String11E0); // 'Die, thou miscreant spawn of Chaos! You may not traverse the way of Harmony yet!'
            L00DA: DamagePlayer(player, GetMaxHits(player));
            L00EB: return; // RETURN;
        }

        private void FnNPCCLUE_27(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = IsFlagOn(player, 0x02, 0x36);
            L0016: if (JumpNotEqual) goto L0032;
            L0018: ShowPortrait(player, 0x0029);
            L0025: ShowMessage(player, String1233); // 'To finish this quest, you will have to visit places in the Hopeless Hallways you have not been able to enter.'
            L0032: return; // RETURN;
        }

        private void FnNPCCLUE_28(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0xFE);
            L0011: if (JumpNotEqual) goto L002D;
            L0013: ShowPortrait(player, 0x001C);
            L0020: ShowMessage(player, String12A3); // 'You will have to detect the opening to the first secret room in Hopeless Hallways. It leads to the ring.'
            L002D: return; // RETURN;
        }

        private void FnRUNECLUE_29(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0017);
            L0010: ShowMessage(player, String130E); // 'There is a place where what you walk on makes no difference...at times! I enjoyed my lava stroll.'
            L001D: return; // RETURN;
        }

        private void FnNPCCLUEB_2A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x001F);
            L0010: ShowMessage(player, String1372); // 'Do NOT enter a place antithetical to your affiliation until you are told to do so.'
            L001D: return; // RETURN;
        }

        private void FnCLUE_2B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0022);
            L0010: ShowMessage(player, String13C7); // 'Once you get to the end of Concordia, you can use a shortcut teleport in the Hopeless Hallways.'
            L001D: return; // RETURN;
        }

        private void FnNPCCLUE_2C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x001A);
            L0010: ShowMessage(player, String1429); // 'Beyond the realm of Pandemonium are the pathways to the Dralkarians.'
            L001D: return; // RETURN;
        }

        private void FnNPCENCA_2E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x002E);
            L0010: Compare(GetFlag(player, 0x02, 0x35), 0x0001);
            L0024: if (JumpNotEqual) goto L002B;
13DB  0026 B8 70 14  mov ax, 0x1470
            L0029: goto L007E;
            L002B: Compare(GetFlag(player, 0x02, 0x37), 0x0001);
            L003F: if (JumpNotEqual) goto L0046;
13F6  0041 B8 C2 14  mov ax, 0x14c2
            L0044: goto L007E;
            L0046: Compare(GetFlag(player, 0x02, 0x36), 0x0001);
            L005A: if (JumpNotEqual) goto L0061;
1411  005C B8 14 15  mov ax, 0x1514
            L005F: goto L007E;
            L0061: ShowMessage(player, String158D); // 'To find the Doors of Harmony and Chaos requires patience.
            L006E: ShowMessage(player, String15C8); // The walls around you lead one way and many ways.
            L007B: ShowMessage(player, String15F9); // May you be wise enough to find the true way.'
            L0088: return; // RETURN;
        }

        private void FnNPCENCB_2F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0025);
            L0010: ShowMessage(player, String1627); // 'You have started along the right path leading to the Doors of Chaos and Harmony.
            L001D: ShowMessage(player, String1679); // Much you must suffer before you reach the final exit!'
            L002A: return; // RETURN;
        }

        private void FnMONSTERA_30(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L003E;
            L0010: AddEncounter(player, 0x01, 0x03);
            L0022: AddEncounter(player, 0x02, 0x0B);
            L0034: PushStack(player, 0x1A);
14A3  0038 B8 05 00  mov ax, 0x5
            L003B: goto L00E7;
            L003E: Compare(PartyCount(player), 0x0002);
            L0049: if (JumpNotEqual) goto L0086;
            L004B: AddEncounter(player, 0x01, 0x04);
            L005D: AddEncounter(player, 0x02, 0x07);
            L006F: AddEncounter(player, 0x05, 0x01);
14EC  0081 B8 05 00  mov ax, 0x5
            L0084: goto L00E3;
            L0086: AddEncounter(player, 0x01, 0x03);
            L0098: AddEncounter(player, 0x02, 0x04);
            L00AA: AddEncounter(player, 0x03, 0x09);
            L00BC: AddEncounter(player, 0x04, 0x08);
            L00CE: AddEncounter(player, 0x05, 0x19);
            L00E0: AddEncounter(player, 0x06, 0x02);
            L00F2: return; // RETURN;
        }

        private void FnMONSTERB_31(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L003E;
            L0010: AddEncounter(player, 0x01, 0x0D);
            L0022: AddEncounter(player, 0x02, 0x0D);
            L0034: PushStack(player, 0x1B);
1597  0038 B8 05 00  mov ax, 0x5
            L003B: goto L00D5;
            L003E: Compare(PartyCount(player), 0x0002);
            L0049: if (JumpNotEqual) goto L0086;
            L004B: AddEncounter(player, 0x01, 0x1D);
            L005D: AddEncounter(player, 0x02, 0x1D);
            L006F: AddEncounter(player, 0x05, 0x1E);
15E0  0081 B8 1E 00  mov ax, 0x1e
            L0084: goto L00D1;
            L0086: AddEncounter(player, 0x01, 0x1F);
            L0098: AddEncounter(player, 0x02, 0x1F);
            L00AA: AddEncounter(player, 0x03, 0x1F);
            L00BC: AddEncounter(player, 0x05, 0x22);
            L00CE: AddEncounter(player, 0x06, 0x22);
            L00E0: return; // RETURN;
        }

        private void FnSPECMONC_32(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L003E;
            L0010: AddEncounter(player, 0x01, 0x0D);
            L0022: AddEncounter(player, 0x02, 0x11);
            L0034: PushStack(player, 0x12);
1679  0038 B8 06 00  mov ax, 0x6
            L003B: goto L00D5;
            L003E: Compare(PartyCount(player), 0x0002);
            L0049: if (JumpNotEqual) goto L0086;
            L004B: AddEncounter(player, 0x01, 0x21);
            L005D: AddEncounter(player, 0x02, 0x21);
            L006F: AddEncounter(player, 0x05, 0x22);
16C2  0081 B8 22 00  mov ax, 0x22
            L0084: goto L0037;
            L0086: AddEncounter(player, 0x01, 0x22);
            L0098: AddEncounter(player, 0x02, 0x22);
            L00AA: AddEncounter(player, 0x03, 0x21);
            L00BC: AddEncounter(player, 0x04, 0x21);
            L00CE: AddEncounter(player, 0x05, 0x23);
            L00E0: return; // RETURN;
        }

        private void FnMONSTERD_33(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L002C;
            L0010: AddEncounter(player, 0x01, 0x15);
            L0022: PushStack(player, 0x17);
1749  0026 B8 02 00  mov ax, 0x2
            L0029: goto L00D9;
            L002C: Compare(PartyCount(player), 0x0002);
            L0037: if (JumpNotEqual) goto L0078;
            L0039: AddEncounter(player, 0x01, 0x1B);
            L004B: AddEncounter(player, 0x02, 0x1B);
            L005D: AddEncounter(player, 0x03, 0x21);
            L006F: PushStack(player, 0x21);
1796  0073 B8 04 00  mov ax, 0x4
            L0076: goto L00D9;
            L0078: AddEncounter(player, 0x01, 0x0D);
            L008A: AddEncounter(player, 0x02, 0x0E);
            L009C: AddEncounter(player, 0x03, 0x20);
            L00AE: AddEncounter(player, 0x04, 0x20);
            L00C0: AddEncounter(player, 0x05, 0x1E);
            L00D2: AddEncounter(player, 0x06, 0x1E);
            L00E4: return; // RETURN;
        }

        private void FnMONSTERE_34(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L003E;
            L0010: AddEncounter(player, 0x01, 0x20);
            L0022: AddEncounter(player, 0x02, 0x20);
            L0034: PushStack(player, 0x21);
1841  0038 B8 04 00  mov ax, 0x4
            L003B: goto L00E7;
            L003E: Compare(PartyCount(player), 0x0002);
            L0049: if (JumpNotEqual) goto L0086;
            L004B: AddEncounter(player, 0x01, 0x1D);
            L005D: AddEncounter(player, 0x02, 0x1D);
            L006F: AddEncounter(player, 0x05, 0x22);
188A  0081 B8 22 00  mov ax, 0x22
            L0084: goto L00E3;
            L0086: AddEncounter(player, 0x01, 0x15);
            L0098: AddEncounter(player, 0x02, 0x15);
            L00AA: AddEncounter(player, 0x03, 0x1C);
            L00BC: AddEncounter(player, 0x04, 0x1C);
            L00CE: AddEncounter(player, 0x05, 0x17);
            L00E0: AddEncounter(player, 0x06, 0x18);
            L00F2: return; // RETURN;
        }

        private void FnSPECMONF_35(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0x86);
            L0011: if (JumpNotEqual) goto L0023;
            L0013: ax = HasItem(player, 0x6D);
            L0021: if (JumpEqual) goto L002F;
            L0023: PushStack(player, 0x00);
            L0026: PushStack(player, ax);
            L0027: PushStack(player, ax);
            L0028: PushStack(player, ax);
            L0029: PushStack(player, ax);
1927  002A B8 CE 00  mov ax, 0xce
            L002D: goto L003C;
            L002F: PushStack(player, 0x00);
            L0032: PushStack(player, ax);
            L0033: PushStack(player, ax);
            L0034: PushStack(player, ax);
            L0035: PushStack(player, 0x6D);
            L0039: PushStack(player, 0x86);
193A  003D C4 5E 06  les bx, [bp+0x6]
193D  0040 26 FF 9F D8 00  call far word [es:bx+0xd8]
1942  0045 83 C4 0C  add sp, 0xc
            L0048: Compare(PartyCount(player), 0x0001);
            L0053: if (JumpNotEqual) goto L0070;
            L0055: AddEncounter(player, 0x01, 0x28);
            L0067: PushStack(player, 0x24);
1968  006B B8 05 00  mov ax, 0x5
            L006E: goto L00E7;
            L0070: Compare(PartyCount(player), 0x0002);
            L007B: if (JumpNotEqual) goto L0098;
            L007D: AddEncounter(player, 0x01, 0x27);
            L008F: PushStack(player, 0x28);
1990  0093 B8 02 00  mov ax, 0x2
            L0096: goto L00D5;
            L0098: AddEncounter(player, 0x01, 0x27);
            L00AA: AddEncounter(player, 0x02, 0x28);
            L00BC: AddEncounter(player, 0x03, 0x26);
            L00CE: AddEncounter(player, 0x05, 0x24);
            L00E0: AddEncounter(player, 0x06, 0x25);
            L00F2: return; // RETURN;
        }

        private void FnSPECMONG_36(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0x27);
            L0011: if (JumpNotEqual) goto L0023;
            L0013: ax = HasItem(player, 0x4A);
            L0021: if (JumpEqual) goto L002F;
            L0023: PushStack(player, 0x00);
            L0026: PushStack(player, ax);
            L0027: PushStack(player, ax);
            L0028: PushStack(player, ax);
            L0029: PushStack(player, ax);
1A1B  002A B8 B8 00  mov ax, 0xb8
            L002D: goto L003C;
            L002F: PushStack(player, 0x00);
            L0032: PushStack(player, ax);
            L0033: PushStack(player, ax);
            L0034: PushStack(player, ax);
            L0035: PushStack(player, 0x4A);
            L0039: PushStack(player, 0x27);
1A2E  003D C4 5E 06  les bx, [bp+0x6]
1A31  0040 26 FF 9F D8 00  call far word [es:bx+0xd8]
1A36  0045 83 C4 0C  add sp, 0xc
            L0048: Compare(PartyCount(player), 0x0001);
            L0053: if (JumpNotEqual) goto L0070;
            L0055: AddEncounter(player, 0x01, 0x28);
            L0067: PushStack(player, 0x24);
1A5C  006B B8 05 00  mov ax, 0x5
            L006E: goto L00E7;
            L0070: Compare(PartyCount(player), 0x0002);
            L007B: if (JumpNotEqual) goto L0098;
            L007D: AddEncounter(player, 0x01, 0x27);
            L008F: PushStack(player, 0x28);
1A84  0093 B8 02 00  mov ax, 0x2
            L0096: goto L00D5;
            L0098: AddEncounter(player, 0x01, 0x27);
            L00AA: AddEncounter(player, 0x02, 0x28);
            L00BC: AddEncounter(player, 0x03, 0x26);
            L00CE: AddEncounter(player, 0x05, 0x24);
            L00E0: AddEncounter(player, 0x06, 0x25);
            L00F2: return; // RETURN;
        }

        private void FnPAYOFFA_37(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0x33), 0x0001);
            L0017: if (JumpEqual) goto L0039;
            L0019: ax = HasItem(player, 0x21);
            L0027: if (JumpNotEqual) goto L0039;
            L0029: ax = HasItem(player, 0x89);
            L0037: if (JumpEqual) goto L0048;
            L0039: ShowMessage(player, String16B0); // The room has been looted.
            L0046: goto L00A7;
            L0048: RefreshCompareFlags(GetAlignment(player));
            L0052: if (JumpNotEqual) goto L00A7;
            L0054: ShowMessage(player, String16CA); // A soft voice whispers -
            L0061: ShowMessage(player, String16E2); // 'Well done, child of Harmony. Behold your reward!'
            L006E: GiveItem(player, 0x21);
            L007A: GiveItem(player, 0x89);
            L0086: GiveItem(player, 0x46);
            L0092: SetFlag(player, 0x02, 0x33, 0x01);
            L00A7: return; // RETURN;
        }

        private void FnPAYOFFB_38(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0x31), 0x0001);
            L0017: if (JumpEqual) goto L0039;
            L0019: ax = HasItem(player, 0x39);
            L0027: if (JumpNotEqual) goto L0039;
            L0029: ax = HasItem(player, 0x0C);
            L0037: if (JumpEqual) goto L0048;
            L0039: ShowMessage(player, String0FA7); // The room is empty.
            L0046: goto L00A8;
            L0048: Compare(GetAlignment(player), 0x0001);
            L0053: if (JumpNotEqual) goto L00A8;
            L0055: ShowMessage(player, String16CA); // A soft voice whispers -
            L0062: ShowMessage(player, String1715); // 'Well done, child of Chaos. Behold your reward!'
            L006F: GiveItem(player, 0x39);
            L007B: GiveItem(player, 0x0C);
            L0087: GiveItem(player, 0x3B);
            L0093: SetFlag(player, 0x02, 0x31, 0x01);
            L00A8: return; // RETURN;
        }

        private void FnSHORTCUT_39(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = IsFlagOn(player, 0x02, 0x36);
            L0016: if (JumpEqual) goto L0043;
            L0018: Compare(PartyCount(player), 0x0001);
            L0023: if (JumpNotEqual) goto L0043;
            L0025: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0043: return; // RETURN;
        }

        private void FnNOJOIN_3A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetNoJoinArea(player);
            L000B: return; // RETURN;
            // Extra data: 55 8B EC B8 01 00 50 B8 03 00 50 C4 5E 06 26 FF 5F 20 50 C4 5E 06 26 FF 5F 2C 83 C4 06 5D CB 55 8B EC B8 46 17 50 C4 5E 06 26 FF 9F F8 00 59 5D CB 
        }

    }
}
