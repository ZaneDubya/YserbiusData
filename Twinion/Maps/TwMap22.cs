#pragma warning disable
using System.Collections.Generic;
using XPT.WorldData;
using XPT.WorldData.Yserbius;

namespace XPT.Scripts.Twinion.Maps {
    class TwMap22 : AMapScripted {
        protected override int MapIndex => 22;
        protected override int RandomEncounterChance => 12;
        protected override int RandomEncounterExtraCount => 2;

        public TwMap22() {
            MapEvent01 = FnTELEPRTA_01;
            MapEvent03 = FnTELEPTAB_03;
            MapEvent04 = FnMESSAB_04;
            MapEvent05 = FnTELEPTCD_05;
            MapEvent06 = FnMESCD_06;
            MapEvent07 = FnTELEPTEF_07;
            MapEvent08 = FnMESSEF_08;
            MapEvent09 = FnTELEPTGH_09;
            MapEvent0A = FnMESSGH_0A;
            MapEvent0B = FnTELEEAST_0B;
            MapEvent0C = FnPIT_0C;
            MapEvent0D = FnFAKEPIT_0D;
            MapEvent0E = FnEXITTLPT_0E;
            MapEvent0F = FnHIDDENDR_0F;
            MapEvent10 = FnTELEPTII_10;
            MapEvent11 = FnCLDORFLA_11;
            MapEvent12 = FnTELEPTKK_12;
            MapEvent13 = FnCLDORFLB_13;
            MapEvent14 = FnCLDORFLC_14;
            MapEvent15 = FnCLDORFLD_15;
            MapEvent16 = FnTELEPTOO_16;
            MapEvent17 = FnFLAGDORA_17;
            MapEvent18 = FnFLAGDORB_18;
            MapEvent19 = FnFLAGDORC_19;
            MapEvent1A = FnFLAGDORD_1A;
            MapEvent1B = FnLKPKDOOR_1B;
            MapEvent1C = FnNPCDOOR_1C;
            MapEvent1D = FnNPCCLUE_1D;
            MapEvent1E = FnNPCSTART_1E;
            MapEvent1F = FnNPCKEYA_1F;
            MapEvent20 = FnNPCEND_20;
            MapEvent21 = FnFLGDOORB_21;
            MapEvent22 = FnFLGDOORC_22;
            MapEvent23 = FnFLGDOORD_23;
            MapEvent24 = FnENDQUEST_24;
            MapEvent25 = FnMONENCA_25;
            MapEvent26 = FnMONENCB_26;
            MapEvent27 = FnMONENCC_27;
            MapEvent28 = FnOPENWALL_28;
            MapEvent29 = FnMONENCD_29;
            MapEvent2A = FnMONENCE_2A;
            MapEvent2B = FnMONENCF_2B;
            MapEvent2C = FnMONENCG_2C;
            MapEvent2D = FnMONENCH_2D;
            MapEvent2E = FnMONENCI_2E;
            MapEvent2F = FnMONENCJ_2F;
            MapEvent30 = FnUNITYRNG_30;
            MapEvent31 = FnNOMAPS_31;
            MapEvent32 = FnPARTPITB_32;
            MapEvent33 = FnPARTPITC_33;
            MapEvent34 = FnPARTPITD_34;
            MapEvent35 = FnPARTPITE_35;
            MapEvent36 = FnPARTPITF_36;
            MapEvent37 = FnPARTPITG_37;
            MapEvent38 = FnPARTPITI_38;
            MapEvent39 = FnNEWTLPTA_39;
            MapEvent3A = FnNEWTLPTB_3A;
            MapEvent3B = FnNEWTLPTC_3B;
            MapEvent3C = FnNEWTLPTD_3C;
            MapEvent3D = FnNEWTLPTE_3D;
            MapEvent3E = FnBLCKDOOR_3E;
            MapEvent3F = FnTELEPITA_3F;
            MapEvent40 = FnTELEPITB_40;
            MapEvent41 = FnTELEPITC_41;
            MapEvent42 = FnCLFLGA_42;
            MapEvent43 = FnCLFLGB_43;
            MapEvent44 = FnCLFLGC_44;
            MapEvent45 = FnCLFLGD_45;
            MapEvent46 = FnOPENWSDR_46;
        }
        
        // === Strings ================================================
        private const string String03FC = "The path to glory lies eastward.";
        private const string String041D = "The second path points east.";
        private const string String043A = "A third path is to the east.";
        private const string String0457 = "Behold, the last path awaits you.";
        private const string String0479 = "This pit is particularly fatal.";
        private const string String0499 = "The pit you step on is an illusion.";
        private const string String04BD = "I am the lamp.";
        private const string String04CC = "Throwing a trip mechanism opens a secret entrance.";
        private const string String04FF = "Walk to the next door southeast of here.";
        private const string String0528 = "Do not leave the map until you have the ring.";
        private const string String0556 = "The next door is to the southeast.";
        private const string String0579 = "The next door is west northwest.";
        private const string String059A = "You must find the last door on your own!";
        private const string String05C3 = "The door unlocks as you approach.";
        private const string String05E5 = "Nothing you try opens the door.";
        private const string String0605 = "The door swings open.";
        private const string String061B = "The door does not budge.";
        private const string String0634 = "The lock on the door clicks open.";
        private const string String0656 = "You push against the door, but nothing happens.";
        private const string String0686 = "The doorknob twists easily at your touch.";
        private const string String06B0 = "The heavy door will not move.";
        private const string String06CE = "The lock pops open at your deft touch.";
        private const string String06F5 = "The door lock looks particularly nasty.";
        private const string String071D = "Finish Concordia and you may pass.";
        private const string String0740 = "The words of the Elf Cleric come to mind as you stare at the star-shaped keyhole in the door.";
        private const string String079E = "A brilliant glow effuses from the keyhole.";
        private const string String07C9 = "Then there is a click, and the door opens.";
        private const string String07F4 = "The star-shaped keyhole glows and the lock clicks open.";
        private const string String082C = "The keyhole in the door is shaped like a radiant star.";
        private const string String0863 = "The room is empty.";
        private const string String0876 = "A Halfling Cleric bows politely.";
        private const string String0897 = "'From south to north four times the pathway eastward lies.";
        private const string String08D2 = "Farthest east and north is your reward.";
        private const string String08FA = "But once may the brave heart succeed and then the way is forever closed.'";
        private const string String0944 = "You see a torn robe on the floor.";
        private const string String0966 = "A Troll Cleric approaches.";
        private const string String0981 = "'Beyond the many doors is a quest that will test the bravest of heroes.";
        private const string String09C9 = "Find my fellow clerics to start the quest.";
        private const string String09F4 = "Also, know that the nature of pits may change as you succeed.'";
        private const string String0A33 = "The room is bare.";
        private const string String0A45 = "An Elf Cleric steps out of the shadows.";
        private const string String0A6D = "'Back again? I said to look for the star-hole door.'";
        private const string String0AA2 = "'I give you the key to the star-hole door. Think of the shining sun and the way to the quest will be open.'";
        private const string String0B0E = "In the distance you hear the growl of monsters.";
        private const string String0B3E = "'As I said earlier, the first door will now open for you.'";
        private const string String0B79 = "You interrupt the meditations of an Elf Cleric.";
        private const string String0BA9 = "'The first door will now open for you.'";
        private const string String0BD1 = "Know that the next door is now open.";
        private const string String0BF6 = "The acid waters of the Fountain of the Bitter End at first burn your mouth.";
        private const string String0C42 = "After a moment the acid taste changes to sweet water.";
        private const string String0C78 = "You have transformed the Fountain of the Bitter End into the Fountain of the Better End.";
        private const string String0CD1 = "You feel ready to take on whole armies.";
        private const string String0CF9 = "The Fountain of the Better End is dry.";
        private const string String0D20 = "The floor of the room is bare.";
        private const string String0D3F = "On the floor is a ring bearing the ";
        private const string String0D63 = "linked symbols of Chaos and Harmony.";
        private const string String0D88 = "You place the Unity Ring on your finger.";
        private const string String0DB1 = "The pit swallows you up and spits you out at...";
        private const string String0DE1 = "The pit is only a painted illusion.";
        private const string String0E05 = "An endless pit to death...";
        private const string String0E20 = "The pit you step on is a simple illusion.";
        private const string String0E4A = "This pit leads to...";
        private const string String0E5F = "The pit is a simple illusion.";
        private const string String0E7D = "The pit is just an illusion.";
        private const string String0E9A = "The pit drops you off at...";
        private const string String0EB6 = "You step on an illusionary pit.";
        private const string String0ED6 = "The pit is a far step to...";
        private const string String0EF2 = "The pit is a clever illusion.";
        private const string String0F10 = "You step into an endless pit to...";
        private const string String0F33 = "The pit is an illusion.";
        private const string String0F4B = "The pit you step into leads...";
        private const string String0F6A = "A return to Dragon's Ire.";
        private const string String0F84 = "Hocus Pocus is just ahead.";
        private const string String0F9F = "In the distance you hear babbling.";
        private const string String0FC2 = "Step through to Concordia.";
        private const string String0FDD = "Pandemonium awaits!";
        private const string String0FF1 = "Who hath tasted of the Fountain of the Better End may no longer pass.";
        private const string String1037 = "Pass through the door.";
        private const string String104E = "One adventurer at a time may pass through this door.";
        private const string String1083 = "The pit drops you into darkness.";
        private const string String10A4 = "The pit is an endless abyss to...";
        private const string String10C6 = "On the door is a picture of a Cleric.";
        private const string String10EC = "Proceed.";
        
        // === Functions ================================================
        private void FnTELEPRTA_01(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x08, 0x01, 0xA0, 0x02, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnTELEPTAB_03(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x09, 0x02, 0x00, 0x33, isForwardMove);
            L001D: return; // RETURN;
        }

        private void FnMESSAB_04(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowRunes(player, String03FC); // The path to glory lies eastward.
            L0010: return; // RETURN;
        }

        private void FnTELEPTCD_05(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x09, 0x02, 0x04, 0x02, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnMESCD_06(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowRunes(player, String041D); // The second path points east.
            L0010: return; // RETURN;
        }

        private void FnTELEPTEF_07(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x09, 0x02, 0x08, 0x02, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnMESSEF_08(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowRunes(player, String043A); // A third path is to the east.
            L0010: return; // RETURN;
        }

        private void FnTELEPTGH_09(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x09, 0x02, 0x0C, 0x02, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnMESSGH_0A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowRunes(player, String0457); // Behold, the last path awaits you.
            L0010: return; // RETURN;
        }

        private void FnTELEEAST_0B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x09, 0x02, 0xE9, 0x02, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnPIT_0C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0479); // This pit is particularly fatal.
            L0010: DamagePlayer(player, GetMaxHits(player));
            L0021: return; // RETURN;
        }

        private void FnFAKEPIT_0D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0499); // The pit you step on is an illusion.
            L0010: return; // RETURN;
        }

        private void FnEXITTLPT_0E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x09, 0x02, 0x79, 0x03, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnHIDDENDR_0F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0x95), 0x0001);
            L0017: if (JumpEqual) goto L001C;
            L0019: goto L00D2;
            L001C: ShowMessage(player, String04BD); // I am the lamp.
            L0029: Compare(HasUsedSkill(player, 0x0D), 0x000C);
            L0038: if (JumpNotBelow) goto L0092;
            L003A: RefreshCompareFlags(HasUsedSpell(player, 0x17));
            L0048: if (JumpNotEqual) goto L0092;
            L004A: PushStack(player, 0x68);
            L004E: PushStack(player, ax);
01B5  004F C4 5E 06  les bx, [bp+0x6]
01B8  0052 26 FF 5F 54  call far word [es:bx+0x54]
            L0056: cx = PopStack(player);
            L0057: cx = PopStack(player);
            L0058: RefreshCompareFlags(ax);
            L005A: if (JumpNotEqual) goto L0092;
            L005C: PushStack(player, 0x6E);
            L0060: PushStack(player, ax);
01C7  0061 C4 5E 06  les bx, [bp+0x6]
01CA  0064 26 FF 5F 54  call far word [es:bx+0x54]
            L0068: cx = PopStack(player);
            L0069: cx = PopStack(player);
            L006A: RefreshCompareFlags(ax);
            L006C: if (JumpNotEqual) goto L0092;
            L006E: PushStack(player, 0x90);
            L0072: PushStack(player, ax);
01D9  0073 C4 5E 06  les bx, [bp+0x6]
01DC  0076 26 FF 5F 54  call far word [es:bx+0x54]
            L007A: cx = PopStack(player);
            L007B: cx = PopStack(player);
            L007C: RefreshCompareFlags(ax);
            L007E: if (JumpNotEqual) goto L0092;
            L0080: PushStack(player, 0xA4);
            L0084: PushStack(player, ax);
01EB  0085 C4 5E 06  les bx, [bp+0x6]
01EE  0088 26 FF 5F 54  call far word [es:bx+0x54]
            L008C: cx = PopStack(player);
            L008D: cx = PopStack(player);
            L008E: RefreshCompareFlags(ax);
            L0090: if (JumpEqual) goto L00DF;
            L0092: ShowMessage(player, String04CC); // Throwing a trip mechanism opens a secret entrance.
            L009F: SetWallPassable(player, GetCurrentTile(player), ax, 0x01);
            L00B6: SetWallObject(player, 0x01, GetCurrentTile(player), 0x01);
            L00D0: goto L00DF;
            L00D2: ShowMessage(player, String04BD); // I am the lamp.
            L00DF: return; // RETURN;
        }

        private void FnTELEPTII_10(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x09, 0x02, 0x32, 0x03, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnCLDORFLA_11(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String04FF); // Walk to the next door southeast of here.
            L0010: ShowMessage(player, String0528); // Do not leave the map until you have the ring.
            L001D: SetFlag(player, 0x03, 0x05, 0x01);
            L0032: return; // RETURN;
        }

        private void FnTELEPTKK_12(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x09, 0x02, 0x64, 0x02, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnCLDORFLB_13(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0556); // The next door is to the southeast.
            L0010: SetFlag(player, 0x03, 0x06, 0x01);
            L0025: return; // RETURN;
        }

        private void FnCLDORFLC_14(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0579); // The next door is west northwest.
            L0010: SetFlag(player, 0x03, 0x07, 0x01);
            L0025: return; // RETURN;
        }

        private void FnCLDORFLD_15(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String059A); // You must find the last door on your own!
            L0010: SetFlag(player, 0x03, 0x08, 0x01);
            L0025: return; // RETURN;
        }

        private void FnTELEPTOO_16(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x09, 0x02, 0xB4, 0x01, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnFLAGDORA_17(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0x98), 0x0001);
            L0017: if (JumpNotEqual) goto L0054;
            L0019: ShowMessage(player, String05C3); // The door unlocks as you approach.
            L0026: PushStack(player, 0x01);
            L002A: PushStack(player, ax);
            L002B: PushStack(player, 0x03);
037F  002F C4 5E 06  les bx, [bp+0x6]
0382  0032 26 FF 1F  call far word [es:bx]
0385  0035 83 C4 06  add sp, 0x6
            L0038: SetWallPassable(player, GetCurrentTile(player), 0x03, 0x01);
            L0052: goto L0061;
            L0054: ShowMessage(player, String05E5); // Nothing you try opens the door.
            L0061: return; // RETURN;
        }

        private void FnFLAGDORB_18(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0x99), 0x0001);
            L0017: if (JumpEqual) goto L0045;
            L0019: Compare(GetFlag(player, 0x02, 0x9A), 0x0001);
            L002D: if (JumpEqual) goto L0045;
            L002F: Compare(GetFlag(player, 0x02, 0x9B), 0x0001);
            L0043: if (JumpNotEqual) goto L0082;
            L0045: ShowMessage(player, String0605); // The door swings open.
            L0052: SetFlag(player, 0x03, 0x02, 0x01);
            L0067: SetWallPassable(player, GetCurrentTile(player), 0x00, 0x01);
            L0080: goto L008F;
            L0082: ShowMessage(player, String061B); // The door does not budge.
            L008F: return; // RETURN;
        }

        private void FnFLAGDORC_19(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0x9A), 0x0001);
            L0017: if (JumpNotEqual) goto L0054;
            L0019: ShowMessage(player, String0634); // The lock on the door clicks open.
            L0026: PushStack(player, 0x01);
            L002A: PushStack(player, 0x03);
            L002E: PushStack(player, ax);
0473  002F C4 5E 06  les bx, [bp+0x6]
0476  0032 26 FF 1F  call far word [es:bx]
0479  0035 83 C4 06  add sp, 0x6
            L0038: SetWallPassable(player, GetCurrentTile(player), 0x02, 0x01);
            L0052: goto L0061;
            L0054: ShowMessage(player, String0656); // You push against the door, but nothing happens.
            L0061: return; // RETURN;
        }

        private void FnFLAGDORD_1A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0x9B), 0x0001);
            L0017: if (JumpNotEqual) goto L0056;
            L0019: ShowMessage(player, String0686); // The doorknob twists easily at your touch.
            L0026: SetFlag(player, 0x03, 0x04, 0x01);
            L003B: SetWallPassable(player, GetCurrentTile(player), 0x00, 0x01);
            L0054: goto L0063;
            L0056: ShowMessage(player, String06B0); // The heavy door will not move.
            L0063: return; // RETURN;
        }

        private void FnLKPKDOOR_1B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = IsFlagOn(player, 0x02, 0x36);
            L0016: if (JumpNotEqual) goto L001B;
            L0018: goto L0098;
            L001A: // NOP
            L001B: ax = HasUsedItem(player, 0xBF, 0xC0);
            L002E: if (JumpNotEqual) goto L0053;
            L0030: PushStack(player, 0x6F);
            L0034: PushStack(player, ax);
0541  0035 C4 5E 06  les bx, [bp+0x6]
0544  0038 26 FF 5F 54  call far word [es:bx+0x54]
            L003C: cx = PopStack(player);
            L003D: cx = PopStack(player);
            L003E: RefreshCompareFlags(ax);
            L0040: if (JumpNotEqual) goto L0053;
            L0042: Compare(HasUsedSkill(player, 0x0E), 0x000A);
            L0051: if (JumpBelow) goto L0076;
            L0053: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
057D  0071 B8 CE 06  mov ax, 0x6ce
            L0074: goto L009B;
            L0076: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
059F  0093 B8 F5 06  mov ax, 0x6f5
            L0096: goto L009B;
            L0098: ShowMessage(player, String071D); // Finish Concordia and you may pass.
            L00A5: return; // RETURN;
        }

        private void FnNPCDOOR_1C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0x97), 0x0001);
            L0017: if (JumpNotEqual) goto L0059;
            L0019: ShowMessage(player, String0740); // The words of the Elf Cleric come to mind as you stare at the star-shaped keyhole in the door.
            L0026: ShowMessage(player, String079E); // A brilliant glow effuses from the keyhole.
            L0033: ShowMessage(player, String07C9); // Then there is a click, and the door opens.
            L0040: SetWallPassable(player, GetCurrentTile(player), ax, 0x01);
            L0057: goto L0081;
            L0059: Compare(GetFlag(player, 0x02, 0x36), 0x0001);
            L006D: if (JumpNotEqual) goto L0074;
0622  006F B8 F4 07  mov ax, 0x7f4
            L0072: goto L0036;
            L0074: ShowMessage(player, String082C); // The keyhole in the door is shaped like a radiant star.
            L0081: return; // RETURN;
        }

        private void FnNPCCLUE_1D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = IsFlagOn(player, 0x02, 0x96);
            L0016: if (JumpEqual) goto L001D;
064E  0018 B8 63 08  mov ax, 0x863
            L001B: goto L0054;
            L001D: ShowPortrait(player, 0x0029);
            L002A: ShowMessage(player, String0876); // A Halfling Cleric bows politely.
            L0037: ShowMessage(player, String0897); // 'From south to north four times the pathway eastward lies.
            L0044: ShowMessage(player, String08D2); // Farthest east and north is your reward.
            L0051: ShowMessage(player, String08FA); // But once may the brave heart succeed and then the way is forever closed.'
            L005E: return; // RETURN;
        }

        private void FnNPCSTART_1E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = IsFlagOn(player, 0x02, 0x96);
            L0016: if (JumpEqual) goto L001D;
06AE  0018 B8 44 09  mov ax, 0x944
            L001B: goto L0054;
            L001D: ShowPortrait(player, 0x0028);
            L002A: ShowMessage(player, String0966); // A Troll Cleric approaches.
            L0037: ShowMessage(player, String0981); // 'Beyond the many doors is a quest that will test the bravest of heroes.
            L0044: ShowMessage(player, String09C9); // Find my fellow clerics to start the quest.
            L0051: ShowMessage(player, String09F4); // Also, know that the nature of pits may change as you succeed.'
            L005E: return; // RETURN;
        }

        private void FnNPCKEYA_1F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = IsFlagOn(player, 0x02, 0x96);
            L0016: if (JumpEqual) goto L0027;
            L0018: ShowMessage(player, String0A33); // The room is bare.
            L0025: goto L007D;
            L0027: ShowPortrait(player, 0x0027);
            L0034: ShowMessage(player, String0A45); // An Elf Cleric steps out of the shadows.
            L0041: ax = IsFlagOn(player, 0x02, 0x97);
            L0054: if (JumpEqual) goto L005B;
074C  0056 B8 6D 0A  mov ax, 0xa6d
            L0059: goto L001B;
            L005B: ShowMessage(player, String0AA2); // 'I give you the key to the star-hole door. Think of the shining sun and the way to the quest will be open.'
            L0068: SetFlag(player, 0x02, 0x97, 0x01);
            L007D: return; // RETURN;
        }

        private void FnNPCEND_20(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = IsFlagOn(player, 0x02, 0x96);
            L0016: if (JumpEqual) goto L0027;
            L0018: ShowMessage(player, String0B0E); // In the distance you hear the growl of monsters.
            L0025: goto L007D;
            L0027: ShowPortrait(player, 0x0027);
            L0034: ax = IsFlagOn(player, 0x02, 0x98);
            L0047: if (JumpEqual) goto L004E;
07BE  0049 B8 3E 0B  mov ax, 0xb3e
            L004C: goto L001B;
            L004E: ShowMessage(player, String0B79); // You interrupt the meditations of an Elf Cleric.
            L005B: ShowMessage(player, String0BA9); // 'The first door will now open for you.'
            L0068: SetFlag(player, 0x02, 0x98, 0x01);
            L007D: return; // RETURN;
        }

        private void FnFLGDOORB_21(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0BD1); // Know that the next door is now open.
            L0010: SetFlag(player, 0x02, 0x99, 0x01);
            L0025: return; // RETURN;
        }

        private void FnFLGDOORC_22(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0BD1); // Know that the next door is now open.
            L0010: SetFlag(player, 0x02, 0x9A, 0x01);
            L0025: SetFlag(player, 0x02, 0x99, 0x00);
            L0039: return; // RETURN;
        }

        private void FnFLGDOORD_23(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0BD1); // Know that the next door is now open.
            L0010: SetFlag(player, 0x02, 0x9B, 0x01);
            L0025: SetFlag(player, 0x02, 0x9A, 0x00);
            L0039: return; // RETURN;
        }

        private void FnENDQUEST_24(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x02, 0x96));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00F7;
            L001B: SetFlag(player, 0x02, 0x96, 0x01);
            L0030: ShowPortrait(player, 0x0042);
            L003D: ShowMessage(player, String0BF6); // The acid waters of the Fountain of the Bitter End at first burn your mouth.
            L004A: ShowMessage(player, String0C42); // After a moment the acid taste changes to sweet water.
            L0057: ShowMessage(player, String0C78); // You have transformed the Fountain of the Bitter End into the Fountain of the Better End.
            L0064: ShowMessage(player, String0CD1); // You feel ready to take on whole armies.
            L0071: PushStack(player, 0x03);
            L0075: PushStack(player, ax);
0907  0076 C4 5E 06  les bx, [bp+0x6]
090A  0079 26 FF 9F A8 00  call far word [es:bx+0xa8]
            L007E: cx = PopStack(player);
            L007F: cx = PopStack(player);
            L0080: PushStack(player, 0x02);
            L0084: PushStack(player, ax);
0916  0085 C4 5E 06  les bx, [bp+0x6]
0919  0088 26 FF 9F A8 00  call far word [es:bx+0xa8]
            L008D: cx = PopStack(player);
            L008E: cx = PopStack(player);
            L008F: AddExperience(player, 0x000B71B0);
            L00A1: SetFlag(player, 0x02, 0x99, 0x02);
            L00B6: SetFlag(player, 0x02, 0x9A, 0x02);
            L00CB: SetFlag(player, 0x02, 0x9B, 0x02);
            L00E0: SetFlag(player, 0x02, 0x97, 0x02);
            L00F5: goto L0104;
            L00F7: ShowMessage(player, String0CF9); // The Fountain of the Better End is dry.
            L0104: return; // RETURN;
        }

        private void FnMONENCA_25(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L003A;
            L0010: AddEncounter(player, 0x01, 0x16);
            L0022: AddEncounter(player, 0x02, 0x15);
09CB  0034 B8 1B 00  mov ax, 0x1b
            L0037: goto L00DF;
            L003A: Compare(PartyCount(player), 0x0002);
            L0045: if (JumpNotEqual) goto L0082;
            L0047: AddEncounter(player, 0x01, 0x1E);
            L0059: AddEncounter(player, 0x02, 0x1F);
            L006B: AddEncounter(player, 0x03, 0x1D);
0A14  007D B8 1A 00  mov ax, 0x1a
            L0080: goto L00DF;
            L0082: AddEncounter(player, 0x01, 0x03);
            L0094: AddEncounter(player, 0x02, 0x03);
            L00A6: AddEncounter(player, 0x03, 0x24);
            L00B8: AddEncounter(player, 0x04, 0x25);
            L00CA: AddEncounter(player, 0x05, 0x18);
            L00DC: AddEncounter(player, 0x06, 0x18);
            L00EE: return; // RETURN;
        }

        private void FnMONENCB_26(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L002C;
            L0010: AddEncounter(player, 0x01, 0x1B);
            L0022: PushStack(player, 0x1C);
0AAD  0026 B8 02 00  mov ax, 0x2
            L0029: goto L0102;
            L002C: Compare(PartyCount(player), 0x0002);
            L0037: if (JumpNotEqual) goto L0067;
            L0039: AddEncounter(player, 0x01, 0x23);
            L004B: AddEncounter(player, 0x02, 0x24);
            L005D: PushStack(player, 0x0C);
0AE8  0061 B8 06 00  mov ax, 0x6
            L0064: goto L0102;
            L0067: Compare(PartyCount(player), 0x0003);
            L0072: if (JumpNotEqual) goto L00B3;
            L0074: AddEncounter(player, 0x01, 0x20);
            L0086: AddEncounter(player, 0x02, 0x22);
            L0098: AddEncounter(player, 0x03, 0x22);
            L00AA: PushStack(player, 0x20);
0B35  00AE B8 04 00  mov ax, 0x4
            L00B1: goto L0102;
            L00B3: AddEncounter(player, 0x01, 0x20);
            L00C5: AddEncounter(player, 0x02, 0x22);
            L00D7: AddEncounter(player, 0x03, 0x22);
            L00E9: AddEncounter(player, 0x04, 0x20);
            L00FB: AddEncounter(player, 0x05, 0x28);
            L010D: return; // RETURN;
        }

        private void FnMONENCC_27(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpEqual) goto L001D;
            L0010: Compare(PartyCount(player), 0x0002);
            L001B: if (JumpNotEqual) goto L004B;
            L001D: AddEncounter(player, 0x01, 0x1F);
            L002F: AddEncounter(player, 0x02, 0x1D);
            L0041: PushStack(player, 0x0D);
0BDB  0045 B8 05 00  mov ax, 0x5
            L0048: goto L0106;
            L004B: Compare(PartyCount(player), 0x0003);
            L0056: if (JumpNotEqual) goto L00A5;
            L0058: AddEncounter(player, 0x01, 0x12);
            L006A: AddEncounter(player, 0x02, 0x13);
            L007C: AddEncounter(player, 0x03, 0x13);
            L008E: AddEncounter(player, 0x05, 0x1A);
0C36  00A0 B8 1C 00  mov ax, 0x1c
            L00A3: goto L0102;
            L00A5: AddEncounter(player, 0x01, 0x17);
            L00B7: AddEncounter(player, 0x02, 0x17);
            L00C9: AddEncounter(player, 0x03, 0x1F);
            L00DB: AddEncounter(player, 0x04, 0x1E);
            L00ED: AddEncounter(player, 0x05, 0x1A);
            L00FF: AddEncounter(player, 0x06, 0x1A);
            L0111: return; // RETURN;
        }

        private void FnOPENWALL_28(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0021: return; // RETURN;
        }

        private void FnMONENCD_29(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L002C;
            L0010: AddEncounter(player, 0x01, 0x1D);
            L0022: PushStack(player, 0x1A);
0CF2  0026 B8 02 00  mov ax, 0x2
            L0029: goto L00B5;
            L002C: Compare(PartyCount(player), 0x0002);
            L0037: if (JumpNotEqual) goto L0054;
            L0039: AddEncounter(player, 0x01, 0x1D);
            L004B: PushStack(player, 0x1D);
0D1B  004F B8 02 00  mov ax, 0x2
            L0052: goto L0091;
            L0054: AddEncounter(player, 0x01, 0x1D);
            L0066: AddEncounter(player, 0x02, 0x1D);
            L0078: AddEncounter(player, 0x03, 0x1D);
            L008A: AddEncounter(player, 0x04, 0x1D);
            L009C: AddEncounter(player, 0x05, 0x1A);
            L00AE: AddEncounter(player, 0x06, 0x1A);
            L00C0: return; // RETURN;
        }

        private void FnMONENCE_2A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L002C;
            L0010: AddEncounter(player, 0x01, 0x20);
            L0022: PushStack(player, 0x20);
0DB4  0026 B8 02 00  mov ax, 0x2
            L0029: goto L00B5;
            L002C: Compare(PartyCount(player), 0x0002);
            L0037: if (JumpNotEqual) goto L0066;
            L0039: AddEncounter(player, 0x01, 0x20);
            L004B: AddEncounter(player, 0x02, 0x20);
            L005D: PushStack(player, 0x22);
0DEF  0061 B8 05 00  mov ax, 0x5
            L0064: goto L00A3;
            L0066: AddEncounter(player, 0x01, 0x20);
            L0078: AddEncounter(player, 0x02, 0x20);
            L008A: AddEncounter(player, 0x03, 0x21);
            L009C: AddEncounter(player, 0x04, 0x22);
            L00AE: AddEncounter(player, 0x06, 0x22);
            L00C0: return; // RETURN;
        }

        private void FnMONENCF_2B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L002C;
            L0010: AddEncounter(player, 0x01, 0x20);
            L0022: PushStack(player, 0x04);
0E76  0026 B8 02 00  mov ax, 0x2
            L0029: goto L0101;
            L002C: Compare(PartyCount(player), 0x0002);
            L0037: if (JumpNotEqual) goto L0054;
            L0039: AddEncounter(player, 0x01, 0x20);
            L004B: PushStack(player, 0x20);
0E9F  004F B8 02 00  mov ax, 0x2
            L0052: goto L008C;
            L0054: Compare(PartyCount(player), 0x0003);
            L005F: if (JumpNotEqual) goto L00A0;
            L0061: AddEncounter(player, 0x01, 0x20);
            L0073: AddEncounter(player, 0x02, 0x20);
            L0085: AddEncounter(player, 0x03, 0x25);
            L0097: PushStack(player, 0x25);
0EEB  009B B8 04 00  mov ax, 0x4
            L009E: goto L0101;
            L00A0: AddEncounter(player, 0x01, 0x22);
            L00B2: AddEncounter(player, 0x02, 0x22);
            L00C4: AddEncounter(player, 0x03, 0x24);
            L00D6: AddEncounter(player, 0x04, 0x24);
            L00E8: AddEncounter(player, 0x05, 0x26);
            L00FA: AddEncounter(player, 0x06, 0x26);
            L010C: return; // RETURN;
        }

        private void FnMONENCG_2C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L002C;
            L0010: AddEncounter(player, 0x01, 0x20);
            L0022: PushStack(player, 0x21);
0F84  0026 B8 02 00  mov ax, 0x2
            L0029: goto L0134;
            L002C: Compare(PartyCount(player), 0x0002);
            L0037: if (JumpNotEqual) goto L0075;
            L0039: AddEncounter(player, 0x01, 0x22);
            L004B: AddEncounter(player, 0x02, 0x22);
            L005D: AddEncounter(player, 0x05, 0x23);
0FCD  006F B8 09 00  mov ax, 0x9
            L0072: goto L0130;
            L0075: Compare(PartyCount(player), 0x0003);
            L0080: if (JumpNotEqual) goto L00D3;
            L0082: AddEncounter(player, 0x01, 0x21);
            L0094: AddEncounter(player, 0x02, 0x21);
            L00A6: AddEncounter(player, 0x03, 0x23);
            L00B8: AddEncounter(player, 0x04, 0x23);
            L00CA: PushStack(player, 0x22);
102C  00CE B8 05 00  mov ax, 0x5
            L00D1: goto L0134;
            L00D3: AddEncounter(player, 0x01, 0x26);
            L00E5: AddEncounter(player, 0x02, 0x26);
            L00F7: AddEncounter(player, 0x03, 0x26);
            L0109: AddEncounter(player, 0x04, 0x26);
            L011B: AddEncounter(player, 0x05, 0x18);
            L012D: AddEncounter(player, 0x06, 0x18);
            L013F: return; // RETURN;
        }

        private void FnMONENCH_2D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L002C;
            L0010: AddEncounter(player, 0x01, 0x23);
            L0022: PushStack(player, 0x09);
10C5  0026 B8 02 00  mov ax, 0x2
            L0029: goto L00D5;
            L002C: Compare(PartyCount(player), 0x0002);
            L0037: if (JumpNotEqual) goto L0074;
            L0039: AddEncounter(player, 0x01, 0x23);
            L004B: AddEncounter(player, 0x02, 0x03);
            L005D: AddEncounter(player, 0x05, 0x07);
110E  006F B8 09 00  mov ax, 0x9
            L0072: goto L00D1;
            L0074: AddEncounter(player, 0x01, 0x04);
            L0086: AddEncounter(player, 0x02, 0x04);
            L0098: AddEncounter(player, 0x03, 0x05);
            L00AA: AddEncounter(player, 0x04, 0x05);
            L00BC: AddEncounter(player, 0x05, 0x18);
            L00CE: AddEncounter(player, 0x06, 0x18);
            L00E0: return; // RETURN;
        }

        private void FnMONENCI_2E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L002C;
            L0010: AddEncounter(player, 0x01, 0x26);
            L0022: PushStack(player, 0x26);
11A7  0026 B8 02 00  mov ax, 0x2
            L0029: goto L00C4;
            L002C: Compare(PartyCount(player), 0x0002);
            L0037: if (JumpNotEqual) goto L0066;
            L0039: AddEncounter(player, 0x01, 0x26);
            L004B: AddEncounter(player, 0x02, 0x26);
            L005D: PushStack(player, 0x27);
11E2  0061 B8 05 00  mov ax, 0x5
            L0064: goto L00C4;
            L0066: PushStack(player, 0x01);
            L006A: PushStack(player, ax);
11EC  006B C4 5E 06  les bx, [bp+0x6]
11EF  006E 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L0073: cx = PopStack(player);
            L0074: cx = PopStack(player);
            L0075: AddEncounter(player, 0x02, 0x05);
            L0087: AddEncounter(player, 0x03, 0x26);
            L0099: AddEncounter(player, 0x04, 0x26);
            L00AB: AddEncounter(player, 0x05, 0x27);
            L00BD: AddEncounter(player, 0x06, 0x28);
            L00CF: return; // RETURN;
        }

        private void FnMONENCJ_2F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L002C;
            L0010: AddEncounter(player, 0x01, 0x20);
            L0022: PushStack(player, 0x21);
1278  0026 B8 02 00  mov ax, 0x2
            L0029: goto L00D5;
            L002C: Compare(PartyCount(player), 0x0002);
            L0037: if (JumpNotEqual) goto L0074;
            L0039: AddEncounter(player, 0x01, 0x21);
            L004B: AddEncounter(player, 0x02, 0x22);
            L005D: AddEncounter(player, 0x05, 0x21);
12C1  006F B8 22 00  mov ax, 0x22
            L0072: goto L00D1;
            L0074: AddEncounter(player, 0x01, 0x22);
            L0086: AddEncounter(player, 0x02, 0x22);
            L0098: AddEncounter(player, 0x03, 0x21);
            L00AA: AddEncounter(player, 0x04, 0x21);
            L00BC: AddEncounter(player, 0x05, 0x23);
            L00CE: AddEncounter(player, 0x06, 0x23);
            L00E0: return; // RETURN;
        }

        private void FnUNITYRNG_30(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x02, 0x36));
            L0016: if (JumpNotEqual) goto L0028;
            L0018: ax = HasItem(player, 0xFE);
            L0026: if (JumpEqual) goto L002D;
135C  0028 B8 20 0D  mov ax, 0xd20
            L002B: goto L0074;
            L002D: GiveItem(player, 0xFE);
            L0039: GiveItem(player, 0x4A);
            L0045: AddExperience(player, 0x00055730);
            L0057: ShowMessage(player, String0D3F); // On the floor is a ring bearing the 
            L0064: ShowMessage(player, String0D63); // linked symbols of Chaos and Harmony.
            L0071: ShowMessage(player, String0D88); // You place the Unity Ring on your finger.
            L007E: return; // RETURN;
        }

        private void FnNOMAPS_31(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
13B7  0003 C4 5E 06  les bx, [bp+0x6]
13BA  0006 26 FF 9F E8 00  call far word [es:bx+0xe8]
            L000B: Compare(GetCurrentTile(player), 0x00E0);
            L0015: if (JumpNotEqual) goto L001F;
            L0017: SetNoJoinArea(player);
            L001F: return; // RETURN;
        }

        private void FnPARTPITB_32(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
13D8  0003 C4 5E 06  les bx, [bp+0x6]
13DB  0006 26 FF 9F B8 00  call far word [es:bx+0xb8]
            L000B: RefreshCompareFlags(ax);
            L000D: if (JumpEqual) goto L005C;
            L000F: Compare(GetFlag(player, 0x02, 0x9B), 0x0001);
            L0023: if (JumpNotEqual) goto L004F;
            L0025: ShowMessage(player, String0DB1); // The pit swallows you up and spits you out at...
            L0032: TeleportParty(player, 0x07, 0x01, 0x20, 0x02, isForwardMove);
            L004D: goto L005C;
            L004F: ShowMessage(player, String0DE1); // The pit is only a painted illusion.
            L005C: return; // RETURN;
        }

        private void FnPARTPITC_33(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0x9A), 0x0001);
            L0017: if (JumpNotEqual) goto L0038;
            L0019: ShowMessage(player, String0E05); // An endless pit to death...
            L0026: PushStack(player, GetMaxHits(player));
1461  002E C4 5E 06  les bx, [bp+0x6]
1464  0031 26 FF 9F 90 00  call far word [es:bx+0x90]
            L0036: goto L0044;
            L0038: ShowMessage(player, String0E20); // The pit you step on is a simple illusion.
            L0045: return; // RETURN;
        }

        private void FnPARTPITD_34(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
147D  0003 C4 5E 06  les bx, [bp+0x6]
1480  0006 26 FF 9F B8 00  call far word [es:bx+0xb8]
            L000B: RefreshCompareFlags(ax);
            L000D: if (JumpEqual) goto L005B;
            L000F: Compare(GetFlag(player, 0x02, 0x99), 0x0001);
            L0023: if (JumpNotEqual) goto L004E;
            L0025: ShowMessage(player, String0E4A); // This pit leads to...
            L0032: TeleportParty(player, 0x09, 0x02, 0x78, 0x00, isForwardMove);
            L004C: goto L005B;
            L004E: ShowMessage(player, String0E5F); // The pit is a simple illusion.
            L005B: return; // RETURN;
        }

        private void FnPARTPITE_35(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
14DA  0003 C4 5E 06  les bx, [bp+0x6]
14DD  0006 26 FF 9F B8 00  call far word [es:bx+0xb8]
            L000B: RefreshCompareFlags(ax);
            L000D: if (JumpEqual) goto L005C;
            L000F: Compare(GetFlag(player, 0x02, 0x9B), 0x0001);
            L0023: if (JumpNotEqual) goto L0034;
            L0025: ShowMessage(player, String0E7D); // The pit is just an illusion.
            L0032: goto L005C;
            L0034: ShowMessage(player, String0E9A); // The pit drops you off at...
            L0041: TeleportParty(player, 0x06, 0x02, 0x30, 0x02, isForwardMove);
            L005C: return; // RETURN;
        }

        private void FnPARTPITF_36(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
1538  0003 C4 5E 06  les bx, [bp+0x6]
153B  0006 26 FF 9F B8 00  call far word [es:bx+0xb8]
            L000B: RefreshCompareFlags(ax);
            L000D: if (JumpEqual) goto L005C;
            L000F: Compare(GetFlag(player, 0x02, 0x9A), 0x0001);
            L0023: if (JumpNotEqual) goto L0034;
            L0025: ShowMessage(player, String0EB6); // You step on an illusionary pit.
            L0032: goto L005C;
            L0034: ShowMessage(player, String0ED6); // The pit is a far step to...
            L0041: TeleportParty(player, 0x05, 0x02, 0xF7, 0x03, isForwardMove);
            L005C: return; // RETURN;
        }

        private void FnPARTPITG_37(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
1596  0003 C4 5E 06  les bx, [bp+0x6]
1599  0006 26 FF 9F B8 00  call far word [es:bx+0xb8]
            L000B: RefreshCompareFlags(ax);
            L000D: if (JumpEqual) goto L006F;
            L000F: Compare(GetFlag(player, 0x02, 0x9A), 0x0001);
            L0023: if (JumpEqual) goto L003B;
            L0025: Compare(GetFlag(player, 0x02, 0x9B), 0x0001);
            L0039: if (JumpNotEqual) goto L004A;
            L003B: ShowMessage(player, String0EF2); // The pit is a clever illusion.
            L0048: goto L006F;
            L004A: ShowMessage(player, String0F10); // You step into an endless pit to...
            L0057: PushStack(player, 0x02);
            L005B: PushStack(player, 0xCC);
            L005F: PushStack(player, 0x01);
            L0063: PushStack(player, ax);
15F7  0064 C4 5E 06  les bx, [bp+0x6]
15FA  0067 26 FF 9F BC 00  call far word [es:bx+0xbc]
15FF  006C 83 C4 08  add sp, 0x8
            L006F: return; // RETURN;
        }

        private void FnPARTPITI_38(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
1607  0003 C4 5E 06  les bx, [bp+0x6]
160A  0006 26 FF 9F B8 00  call far word [es:bx+0xb8]
            L000B: RefreshCompareFlags(ax);
            L000D: if (JumpEqual) goto L0072;
            L000F: Compare(GetFlag(player, 0x02, 0x99), 0x0001);
            L0023: if (JumpEqual) goto L003B;
            L0025: Compare(GetFlag(player, 0x02, 0x9B), 0x0001);
            L0039: if (JumpNotEqual) goto L004A;
            L003B: ShowMessage(player, String0F33); // The pit is an illusion.
            L0048: goto L0072;
            L004A: ShowMessage(player, String0F4B); // The pit you step into leads...
            L0057: TeleportParty(player, 0x03, 0x02, 0x52, 0x02, isForwardMove);
            L0072: return; // RETURN;
        }

        private void FnNEWTLPTA_39(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0F6A); // A return to Dragon's Ire.
            L0010: TeleportParty(player, 0x08, 0x01, 0xA0, 0x02, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnNEWTLPTB_3A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0F84); // Hocus Pocus is just ahead.
            L0010: TeleportParty(player, 0x09, 0x01, 0xA7, 0x01, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnNEWTLPTC_3B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0F9F); // In the distance you hear babbling.
            L0010: TeleportParty(player, 0x0A, 0x01, 0x58, 0x03, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnNEWTLPTD_3C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0FC2); // Step through to Concordia.
            L0010: TeleportParty(player, 0x0A, 0x02, 0xE1, 0x03, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnNEWTLPTE_3D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0FDD); // Pandemonium awaits!
            L0010: TeleportParty(player, 0x0A, 0x03, 0x9F, 0x00, isForwardMove);
            L002A: return; // RETURN;
        }

        private void FnBLCKDOOR_3E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0x96), 0x0001);
            L0017: if (JumpNotEqual) goto L0041;
            L0019: ShowMessage(player, String0FF1); // Who hath tasted of the Fountain of the Better End may no longer pass.
            L0026: SetWallPassable(player, GetCurrentTile(player), 0x02, 0x00);
            L003F: goto L006D;
            L0041: Compare(PartyCount(player), 0x0001);
            L004C: if (JumpNotEqual) goto L0060;
            L004E: ShowMessage(player, String1037); // Pass through the door.
17B3  005B B8 01 00  mov ax, 0x1
            L005E: goto L0028;
            L0060: ShowMessage(player, String104E); // One adventurer at a time may pass through this door.
            L006D: return; // RETURN;
        }

        private void FnTELEPITA_3F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1083); // The pit drops you into darkness.
            L0010: TeleportParty(player, 0x05, 0x03, 0x67, 0x03, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnTELEPITB_40(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0E4A); // This pit leads to...
            L0010: TeleportParty(player, 0x09, 0x02, 0x29, 0x00, isForwardMove);
            L002A: return; // RETURN;
        }

        private void FnTELEPITC_41(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String10A4); // The pit is an endless abyss to...
            L0010: TeleportParty(player, 0x05, 0x02, 0xBD, 0x03, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnCLFLGA_42(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x05), 0x0001);
            L0017: if (JumpNotEqual) goto L003F;
            L0019: ShowMessage(player, String10C6); // On the door is a picture of a Cleric.
            L0026: SetWallPassable(player, GetCurrentTile(player), 0x00, 0x01);
            L003F: return; // RETURN;
        }

        private void FnCLFLGB_43(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x06), 0x0001);
            L0017: if (JumpNotEqual) goto L003D;
            L0019: ShowMessage(player, String10C6); // On the door is a picture of a Cleric.
            L0026: SetWallPassable(player, GetCurrentTile(player), ax, 0x01);
            L003D: return; // RETURN;
        }

        private void FnCLFLGC_44(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x07), 0x0001);
            L0017: if (JumpNotEqual) goto L0040;
            L0019: ShowMessage(player, String10C6); // On the door is a picture of a Cleric.
            L0026: SetWallPassable(player, GetCurrentTile(player), 0x02, 0x01);
            L0040: return; // RETURN;
        }

        private void FnCLFLGD_45(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x08), 0x0001);
            L0017: if (JumpNotEqual) goto L003D;
            L0019: ShowMessage(player, String10C6); // On the door is a picture of a Cleric.
            L0026: SetWallPassable(player, GetCurrentTile(player), ax, 0x01);
            L003D: return; // RETURN;
        }

        private void FnOPENWSDR_46(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0x99), 0x0001);
            L0017: if (JumpNotEqual) goto L003F;
            L0019: ShowMessage(player, String10EC); // Proceed.
            L0026: SetWallPassable(player, GetCurrentTile(player), 0x00, 0x01);
            L003F: return; // RETURN;
        }

    }
}
