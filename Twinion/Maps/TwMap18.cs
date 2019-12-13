#pragma warning disable
using System.Collections.Generic;
using XPT.WorldData;
using XPT.WorldData.Yserbius;

namespace XPT.Scripts.Twinion.Maps {
    class TwMap18 : AMapScripted {
        protected override int MapIndex => 18;
        protected override int RandomEncounterChance => 10;
        protected override int RandomEncounterExtraCount => 1;

        public TwMap18() {
            MapEvent01 = FnMEDA_01;
            MapEvent02 = FnMEDB_02;
            MapEvent03 = FnASPBTL_03;
            MapEvent04 = FnMEDC_04;
            MapEvent05 = FnHRDA_05;
            MapEvent06 = FnHRDB_06;
            MapEvent07 = FnMEDD_07;
            MapEvent08 = FnRUBY_08;
            MapEvent09 = FnMEDE_09;
            MapEvent0A = FnTELOA_0A;
            MapEvent0B = FnTELOAMSG_0B;
            MapEvent0C = FnHRDC_0C;
            MapEvent0D = FnHRDD_0D;
            MapEvent0E = FnEZA_0E;
            MapEvent0F = FnTEXT_0F;
            MapEvent10 = FnTELOB_10;
            MapEvent11 = FnNPCA_11;
            MapEvent12 = FnNPCB_12;
            MapEvent13 = FnPCDOOR_13;
            MapEvent14 = FnNOJOIN_14;
            MapEvent15 = FnCHCKCHRM_15;
        }
        
        // === Strings ================================================
        private const string String03FC = "The Snake Charm rattles at the Giant Asp as you approach.";
        private const string String0436 = "'Kill me if you can, foolish mortals-s-s.'";
        private const string String0461 = "You find nothing of interest.";
        private const string String047F = "You find a brilliant, red Ruby Lockpick.";
        private const string String04A8 = "Your Snake Charm falls to the ground and shatters.";
        private const string String04DB = "You discover the treasure trove of the Giant Asp and what it fought so hard to protect.";
        private const string String0533 = "As you lean forward to grab a glowing red Ruby Lockpick, the 25,000 in gold and the other assorted treasures, your Snake Charm falls to the ground and shatters.";
        private const string String05D4 = "Opening the door to the south reveals a shaft lined with rough walls. You use the notches as footholds to climb to the top.";
        private const string String0650 = "You see a warning sign -";
        private const string String0669 = "'Proceed at your own risk!!!'";
        private const string String0687 = "'If you don't have THE powerful talisman - you'll know what it is when it saves your worthless lives - go no further!'";
        private const string String06FE = "An exhausted Barbarian sighs, 'This place isn't the Rat Race Track, is it?";
        private const string String0749 = "I got a great tip from an Elf Thief about a special weapon to be found in a Rat Race or Race Track or Tracking Race Rats or something like that.";
        private const string String07DA = "Just my luck! All I found while I was searching was a curious piece of leather.'";
        private const string String082B = "A medusa studies you with icy eyes.";
        private const string String084F = "'If I had more time I'd kill you, but I seek greater reward.";
        private const string String088C = "Rumor of a dragon feud has reached me, and I must be off.";
        private const string String08C6 = "I will leave you as food for my pets.'";
        private const string String08ED = "Wicked hisses issue forth from the other side.";
        private const string String091C = "You must squeeze through this narrow opening one at a time.";
        private const string String0958 = "The Giant Asp laughs at your feeble attempts to kill him.";
        private const string String0992 = "'You are not protected by that curs-s-sed S-s-snake Charm!'";
        private const string String09CE = "The Giant Asp slays you with one mighty blow.";
        private const string String09FC = "The Giant Asp sees your Snake Charm and shrinks back.";
        private const string String0A32 = "'Curs-s-se you and that curs-s-sed S-s-snake Charm!";
        private const string String0A66 = "Follow me if you dare, mortals-s-s.'";
        
        // === Functions ================================================
        private void FnMEDA_01(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L0062;
            L0010: AddEncounter(player, 0x01, 0x19);
            L0022: AddEncounter(player, 0x02, 0x19);
            L0034: AddEncounter(player, 0x03, 0x19);
            L0046: AddEncounter(player, 0x04, 0x19);
            L0058: PushStack(player, 0x01);
0067  005C B8 05 00  mov ax, 0x5
            L005F: goto L011A;
            L0062: Compare(PartyCount(player), 0x0002);
            L006D: if (JumpNotEqual) goto L00B9;
            L006F: AddEncounter(player, 0x01, 0x19);
            L0081: AddEncounter(player, 0x02, 0x19);
            L0093: AddEncounter(player, 0x03, 0x19);
            L00A5: PushStack(player, 0x05);
            L00A9: PushStack(player, ax);
00B5  00AA C4 5E 06  les bx, [bp+0x6]
00B8  00AD 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L00B2: cx = PopStack(player);
            L00B3: cx = PopStack(player);
00BF  00B4 B8 07 00  mov ax, 0x7
            L00B7: goto L0116;
            L00B9: AddEncounter(player, 0x01, 0x19);
            L00CB: AddEncounter(player, 0x02, 0x19);
            L00DD: AddEncounter(player, 0x03, 0x04);
            L00EF: AddEncounter(player, 0x04, 0x07);
            L0101: AddEncounter(player, 0x05, 0x08);
            L0113: AddEncounter(player, 0x06, 0x09);
            L0125: return; // RETURN;
        }

        private void FnMEDB_02(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L002C;
            L0010: AddEncounter(player, 0x01, 0x02);
            L0022: PushStack(player, 0x0E);
0158  0026 B8 02 00  mov ax, 0x2
            L0029: goto L00C7;
            L002C: Compare(PartyCount(player), 0x0002);
            L0037: if (JumpNotEqual) goto L0066;
            L0039: AddEncounter(player, 0x01, 0x03);
            L004B: AddEncounter(player, 0x02, 0x05);
            L005D: PushStack(player, 0x0E);
0193  0061 B8 03 00  mov ax, 0x3
            L0064: goto L00C7;
            L0066: AddEncounter(player, 0x01, 0x04);
            L0078: AddEncounter(player, 0x02, 0x07);
            L008A: AddEncounter(player, 0x03, 0x08);
            L009C: AddEncounter(player, 0x04, 0x0D);
            L00AE: AddEncounter(player, 0x05, 0x11);
            L00C0: AddEncounter(player, 0x06, 0x13);
            L00D2: return; // RETURN;
        }

        private void FnASPBTL_03(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String03FC); // The Snake Charm rattles at the Giant Asp as you approach.
            L0010: ShowMessage(player, String0436); // 'Kill me if you can, foolish mortals-s-s.'
            L001D: Compare(PartyCount(player), 0x0001);
            L0028: if (JumpNotEqual) goto L0042;
            L002A: PushStack(player, 0x01);
            L002E: PushStack(player, ax);
0235  002F C4 5E 06  les bx, [bp+0x6]
0238  0032 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L0037: cx = PopStack(player);
            L0038: cx = PopStack(player);
            L0039: PushStack(player, 0x18);
0243  003D B8 05 00  mov ax, 0x5
            L0040: goto L00B9;
            L0042: Compare(PartyCount(player), 0x0002);
            L004D: if (JumpNotEqual) goto L006A;
            L004F: AddEncounter(player, 0x01, 0x03);
            L0061: PushStack(player, 0x06);
026B  0065 B8 02 00  mov ax, 0x2
            L0068: goto L00A7;
            L006A: AddEncounter(player, 0x01, 0x03);
            L007C: AddEncounter(player, 0x02, 0x04);
            L008E: AddEncounter(player, 0x04, 0x08);
            L00A0: AddEncounter(player, 0x05, 0x0A);
            L00B2: AddEncounter(player, 0x06, 0x18);
            L00C4: return; // RETURN;
        }

        private void FnMEDC_04(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L002C;
            L0010: AddEncounter(player, 0x01, 0x0E);
            L0022: PushStack(player, 0x13);
02F2  0026 B8 02 00  mov ax, 0x2
            L0029: goto L00C7;
            L002C: Compare(PartyCount(player), 0x0002);
            L0037: if (JumpNotEqual) goto L0078;
            L0039: AddEncounter(player, 0x01, 0x0E);
            L004B: AddEncounter(player, 0x02, 0x11);
            L005D: AddEncounter(player, 0x03, 0x15);
            L006F: PushStack(player, 0x17);
033F  0073 B8 05 00  mov ax, 0x5
            L0076: goto L00C7;
            L0078: AddEncounter(player, 0x01, 0x0D);
            L008A: AddEncounter(player, 0x02, 0x0E);
            L009C: AddEncounter(player, 0x03, 0x13);
            L00AE: AddEncounter(player, 0x05, 0x14);
            L00C0: AddEncounter(player, 0x06, 0x16);
            L00D2: return; // RETURN;
        }

        private void FnHRDA_05(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L002C;
            L0010: AddEncounter(player, 0x01, 0x0B);
            L0022: PushStack(player, 0x10);
03C6  0026 B8 02 00  mov ax, 0x2
            L0029: goto L00C3;
            L002C: Compare(PartyCount(player), 0x0002);
            L0037: if (JumpNotEqual) goto L0074;
            L0039: AddEncounter(player, 0x01, 0x0B);
            L004B: AddEncounter(player, 0x02, 0x0C);
            L005D: AddEncounter(player, 0x04, 0x10);
040F  006F B8 15 00  mov ax, 0x15
            L0072: goto L00BF;
            L0074: AddEncounter(player, 0x01, 0x0A);
            L0086: AddEncounter(player, 0x02, 0x0D);
            L0098: AddEncounter(player, 0x04, 0x10);
            L00AA: AddEncounter(player, 0x05, 0x14);
            L00BC: AddEncounter(player, 0x06, 0x16);
            L00CE: return; // RETURN;
        }

        private void FnHRDB_06(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L004C;
            L0010: AddEncounter(player, 0x01, 0x17);
            L0022: AddEncounter(player, 0x02, 0x0B);
            L0034: AddEncounter(player, 0x05, 0x19);
04B6  0046 B8 19 00  mov ax, 0x19
            L0049: goto L0103;
            L004C: Compare(PartyCount(player), 0x0002);
            L0057: if (JumpNotEqual) goto L00A6;
            L0059: AddEncounter(player, 0x01, 0x07);
            L006B: AddEncounter(player, 0x02, 0x16);
            L007D: AddEncounter(player, 0x03, 0x19);
            L008F: AddEncounter(player, 0x05, 0x0F);
0511  00A1 B8 0C 00  mov ax, 0xc
            L00A4: goto L0103;
            L00A6: AddEncounter(player, 0x01, 0x08);
            L00B8: AddEncounter(player, 0x02, 0x0A);
            L00CA: AddEncounter(player, 0x03, 0x0C);
            L00DC: AddEncounter(player, 0x04, 0x0F);
            L00EE: AddEncounter(player, 0x05, 0x14);
            L0100: AddEncounter(player, 0x06, 0x15);
            L0112: return; // RETURN;
        }

        private void FnMEDD_07(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L002C;
            L0010: AddEncounter(player, 0x01, 0x12);
            L0022: PushStack(player, 0x11);
05AA  0026 B8 02 00  mov ax, 0x2
            L0029: goto L00B5;
            L002C: Compare(PartyCount(player), 0x0002);
            L0037: if (JumpNotEqual) goto L0066;
            L0039: AddEncounter(player, 0x01, 0x08);
            L004B: AddEncounter(player, 0x02, 0x08);
            L005D: PushStack(player, 0x11);
05E5  0061 B8 04 00  mov ax, 0x4
            L0064: goto L00A3;
            L0066: AddEncounter(player, 0x01, 0x08);
            L0078: AddEncounter(player, 0x02, 0x08);
            L008A: AddEncounter(player, 0x04, 0x12);
            L009C: AddEncounter(player, 0x05, 0x13);
            L00AE: AddEncounter(player, 0x06, 0x13);
            L00C0: return; // RETURN;
        }

        private void FnRUBY_08(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0xD7);
            L0011: if (JumpNotEqual) goto L0016;
            L0013: goto L010D;
            L0016: Compare(GetFlag(player, 0x02, 0x57), 0x0001);
            L002A: if (JumpNotEqual) goto L007E;
            L002C: ax = HasItem(player, 0xDD);
            L003A: if (JumpEqual) goto L0057;
            L003C: ShowMessage(player, String0461); // You find nothing of interest.
            L0049: PushStack(player, 0xD7);
0693  004D C4 5E 06  les bx, [bp+0x6]
0696  0050 26 FF 5F 4C  call far word [es:bx+0x4c]
            L0054: goto L0119;
            L0057: ShowMessage(player, String047F); // You find a brilliant, red Ruby Lockpick.
            L0064: ShowMessage(player, String04A8); // Your Snake Charm falls to the ground and shatters.
            L0071: PushStack(player, 0xDD);
06BB  0075 C4 5E 06  les bx, [bp+0x6]
06BE  0078 26 FF 5F 48  call far word [es:bx+0x48]
            L007C: goto L0048;
            L007E: ShowMessage(player, String04DB); // You discover the treasure trove of the Giant Asp and what it fought so hard to protect.
            L008B: ShowMessage(player, String0533); // As you lean forward to grab a glowing red Ruby Lockpick, the 25,000 in gold and the other assorted treasures, your Snake Charm falls to the ground and shatters.
            L0098: GiveItem(player, 0xDD);
            L00A4: GiveItem(player, 0xB8);
            L00B0: GiveItem(player, 0x93);
            L00BC: GiveItem(player, 0xAD);
            L00C8: AddExperience(player, 0x0000C350);
            L00D9: ModifyGold(player, 0x61A8);
            L00EA: RemoveItem(player, 0xD7);
            L00F6: SetFlag(player, 0x02, 0x57, 0x01);
            L010B: goto L011A;
            L010D: ShowMessage(player, String0461); // You find nothing of interest.
            L011A: return; // RETURN;
        }

        private void FnMEDE_09(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L002C;
            L0010: AddEncounter(player, 0x01, 0x11);
            L0022: PushStack(player, 0x12);
0788  0026 B8 02 00  mov ax, 0x2
            L0029: goto L00C7;
            L002C: Compare(PartyCount(player), 0x0002);
            L0037: if (JumpNotEqual) goto L0078;
            L0039: AddEncounter(player, 0x01, 0x11);
            L004B: AddEncounter(player, 0x02, 0x13);
            L005D: AddEncounter(player, 0x03, 0x13);
            L006F: PushStack(player, 0x14);
07D5  0073 B8 04 00  mov ax, 0x4
            L0076: goto L00C7;
            L0078: AddEncounter(player, 0x01, 0x13);
            L008A: AddEncounter(player, 0x02, 0x13);
            L009C: AddEncounter(player, 0x03, 0x14);
            L00AE: AddEncounter(player, 0x05, 0x15);
            L00C0: AddEncounter(player, 0x06, 0x17);
            L00D2: return; // RETURN;
        }

        private void FnTELOA_0A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x04, 0x01, 0xF1, 0x02, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnTELOAMSG_0B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String05D4); // Opening the door to the south reveals a shaft lined with rough walls. You use the notches as footholds to climb to the top.
            L0010: return; // RETURN;
        }

        private void FnHRDC_0C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L003E;
            L0010: AddEncounter(player, 0x01, 0x02);
            L0022: AddEncounter(player, 0x02, 0x06);
            L0034: PushStack(player, 0x0D);
08A0  0038 B8 03 00  mov ax, 0x3
            L003B: goto L00E8;
            L003E: Compare(PartyCount(player), 0x0002);
            L0049: if (JumpNotEqual) goto L0087;
            L004B: PushStack(player, 0x01);
            L004F: PushStack(player, ax);
08B8  0050 C4 5E 06  les bx, [bp+0x6]
08BB  0053 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L0058: cx = PopStack(player);
            L0059: cx = PopStack(player);
            L005A: AddEncounter(player, 0x02, 0x04);
            L006C: AddEncounter(player, 0x03, 0x06);
            L007E: PushStack(player, 0x0E);
08EA  0082 B8 04 00  mov ax, 0x4
            L0085: goto L00E8;
            L0087: AddEncounter(player, 0x01, 0x04);
            L0099: AddEncounter(player, 0x02, 0x07);
            L00AB: AddEncounter(player, 0x03, 0x08);
            L00BD: AddEncounter(player, 0x04, 0x0E);
            L00CF: AddEncounter(player, 0x05, 0x13);
            L00E1: AddEncounter(player, 0x06, 0x13);
            L00F3: return; // RETURN;
        }

        private void FnHRDD_0D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L002C;
            L0010: AddEncounter(player, 0x01, 0x0E);
            L0022: PushStack(player, 0x13);
0983  0026 B8 02 00  mov ax, 0x2
            L0029: goto L00C7;
            L002C: Compare(PartyCount(player), 0x0002);
            L0037: if (JumpNotEqual) goto L0078;
            L0039: AddEncounter(player, 0x01, 0x17);
            L004B: AddEncounter(player, 0x02, 0x16);
            L005D: AddEncounter(player, 0x04, 0x15);
            L006F: PushStack(player, 0x0E);
09D0  0073 B8 06 00  mov ax, 0x6
            L0076: goto L00C7;
            L0078: AddEncounter(player, 0x01, 0x14);
            L008A: AddEncounter(player, 0x02, 0x13);
            L009C: AddEncounter(player, 0x03, 0x13);
            L00AE: AddEncounter(player, 0x04, 0x14);
            L00C0: AddEncounter(player, 0x05, 0x0E);
            L00D2: return; // RETURN;
        }

        private void FnEZA_0E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L002B;
            L0010: AddEncounter(player, 0x01, 0x0C);
            L0022: PushStack(player, 0x10);
0A57  0026 B8 02 00  mov ax, 0x2
            L0029: goto L00A2;
            L002B: Compare(PartyCount(player), 0x0002);
            L0036: if (JumpNotEqual) goto L0065;
            L0038: AddEncounter(player, 0x01, 0x10);
            L004A: AddEncounter(player, 0x02, 0x0F);
            L005C: PushStack(player, 0x0C);
0A91  0060 B8 03 00  mov ax, 0x3
            L0063: goto L00A2;
            L0065: AddEncounter(player, 0x01, 0x0C);
            L0077: AddEncounter(player, 0x02, 0x0F);
            L0089: AddEncounter(player, 0x03, 0x0F);
            L009B: AddEncounter(player, 0x04, 0x10);
            L00AD: return; // RETURN;
        }

        private void FnTEXT_0F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0650); // You see a warning sign -
            L0010: ShowMessage(player, String0669); // 'Proceed at your own risk!!!'
            L001D: ShowMessage(player, String0687); // 'If you don't have THE powerful talisman - you'll know what it is when it saves your worthless lives - go no further!'
            L002A: return; // RETURN;
        }

        private void FnTELOB_10(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x05, 0x03, 0x11, 0x01, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnNPCA_11(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0019);
            L0010: ShowMessage(player, String06FE); // An exhausted Barbarian sighs, 'This place isn't the Rat Race Track, is it?
            L001D: ShowMessage(player, String0749); // I got a great tip from an Elf Thief about a special weapon to be found in a Rat Race or Race Track or Tracking Race Rats or something like that.
            L002A: ShowMessage(player, String07DA); // Just my luck! All I found while I was searching was a curious piece of leather.'
            L0037: return; // RETURN;
        }

        private void FnNPCB_12(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0006);
            L0010: ShowMessage(player, String082B); // A medusa studies you with icy eyes.
            L001D: ShowMessage(player, String084F); // 'If I had more time I'd kill you, but I seek greater reward.
            L002A: ShowMessage(player, String088C); // Rumor of a dragon feud has reached me, and I must be off.
            L0037: ShowMessage(player, String08C6); // I will leave you as food for my pets.'
            L0044: return; // RETURN;
        }

        private void FnPCDOOR_13(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L0033;
            L0010: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
0BD9  002E B8 ED 08  mov ax, 0x8ed
            L0031: goto L0053;
            L0033: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0050: ShowMessage(player, String091C); // You must squeeze through this narrow opening one at a time.
            L005D: return; // RETURN;
        }

        private void FnNOJOIN_14(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetNoJoinArea(player);
            L000B: return; // RETURN;
        }

        private void FnCHCKCHRM_15(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0xD7);
            L0011: if (JumpNotEqual) goto L004C;
            L0013: ShowMessage(player, String0958); // The Giant Asp laughs at your feeble attempts to kill him.
            L0020: ShowMessage(player, String0992); // 'You are not protected by that curs-s-sed S-s-snake Charm!'
            L002D: ShowMessage(player, String09CE); // The Giant Asp slays you with one mighty blow.
            L003A: PushStack(player, GetMaxHits(player));
0C59  0042 C4 5E 06  les bx, [bp+0x6]
0C5C  0045 26 FF 9F 90 00  call far word [es:bx+0x90]
            L004A: goto L0072;
            L004C: ShowMessage(player, String09FC); // The Giant Asp sees your Snake Charm and shrinks back.
            L0059: ShowMessage(player, String0A32); // 'Curs-s-se you and that curs-s-sed S-s-snake Charm!
            L0066: ShowMessage(player, String0A66); // Follow me if you dare, mortals-s-s.'
            L0073: return; // RETURN;
        }

    }
}
