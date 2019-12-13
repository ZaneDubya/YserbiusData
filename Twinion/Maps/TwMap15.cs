#pragma warning disable
using System.Collections.Generic;
using XPT.WorldData;
using XPT.WorldData.Yserbius;

namespace XPT.Scripts.Twinion.Maps {
    class TwMap15 : AMapScripted {
        protected override int MapIndex => 15;
        protected override int RandomEncounterChance => 10;
        protected override int RandomEncounterExtraCount => 0;

        public TwMap15() {
            MapEvent01 = FnSECGNO_01;
            MapEvent02 = FnSECA_02;
            MapEvent03 = FnTELEA_03;
            MapEvent04 = FnWEAPA_04;
            MapEvent05 = FnTEXTWA_05;
            MapEvent06 = FnSECHALF_06;
            MapEvent07 = FnSECMSG_07;
            MapEvent08 = FnTELEB_08;
            MapEvent09 = FnMAPE_09;
            MapEvent0A = FnTELEC_0A;
            MapEvent0B = FnTELED_0B;
            MapEvent0C = FnSECB_0C;
            MapEvent0D = FnTEXTWB_0D;
            MapEvent0E = FnGENTXT_0E;
            MapEvent0F = FnSECD_0F;
            MapEvent10 = FnSECHUME_10;
            MapEvent11 = FnFTNORC_11;
            MapEvent12 = FnFTNDWF_12;
            MapEvent13 = FnTELEE_13;
            MapEvent14 = FnJOLLYCLU_14;
            MapEvent17 = FnTELEF_17;
            MapEvent18 = FnHEALDOWN_18;
            MapEvent19 = FnSECTRO_19;
            MapEvent1A = FnGOODIEA_1A;
            MapEvent1B = FnGOLDDOWN_1B;
            MapEvent1C = FnNPCCLUEA_1C;
            MapEvent1D = FnNPCCLUEB_1D;
            MapEvent1E = FnTELEG_1E;
            MapEvent1F = FnNPCCLUEC_1F;
            MapEvent21 = FnSECGRE_21;
            MapEvent22 = FnGOODIEB_22;
            MapEvent23 = FnSECORC_23;
            MapEvent24 = FnTEXTWC_24;
            MapEvent25 = FnMANADOWN_25;
            MapEvent27 = FnFTNELF_27;
            MapEvent29 = FnTELEH_29;
            MapEvent2C = FnGOODIEC_2C;
            MapEvent2D = FnTELEI_2D;
            MapEvent2E = FnSECELF_2E;
            MapEvent2F = FnSECDWF_2F;
            MapEvent30 = FnTEXTWD_30;
            MapEvent35 = FnFTN_35;
            MapEvent36 = FnTELEJ_36;
            MapEvent37 = FnPLUSGOLD_37;
            MapEvent39 = FnSECQ_39;
            MapEvent3C = FnFTNGNO_3C;
            MapEvent3E = FnBOTLDOWN_3E;
            MapEvent3F = FnMEDA_3F;
            MapEvent40 = FnEZA_40;
            MapEvent42 = FnMEDB_42;
            MapEvent43 = FnMEDC_43;
            MapEvent44 = FnHRDB_44;
            MapEvent46 = Fn_46;
        }
        
        // === Strings ================================================
        private const string String03FC = "You spot a hidden door.";
        private const string String0414 = "Use Kalydor's payment first.";
        private const string String0431 = "The clutter of spent crystal balls littering the ground reminds you that many times a door can be detected by using magic.";
        private const string String04AC = "Use the Topaz before the Ebony.";
        private const string String04CC = "A group of vicious monsters appears to guard this area.";
        private const string String0504 = "With a gleam in his eyes, a halfling approaches you.";
        private const string String0539 = "'Well! It took me a lot of crystal balls to find out that most of these secret passages are actually illusionary walls!";
        private const string String05B1 = "But not all was in vain, I did find some secret doors and they led me..well, I'll let you find that out. I wonder who built this place.'";
        private const string String063A = "With that, he returns to contemplating his maps.";
        private const string String066B = "The waters of Orc Spring refresh and invigorate you.";
        private const string String06A0 = "The waters of Orc Spring have no affect.";
        private const string String06C9 = "The waters of Dwarf Spring refresh and invigorate you.";
        private const string String0700 = "The waters of Dwarf Spring have no affect.";
        private const string String072B = "A gnome with a merry gleam in his eye greets your with a chuckle. 'You are much too serious, my friend! Keep searching, you will find what you seek, I swear!'";
        private const string String07CA = "He becomes serious for a moment and says, 'Ah, the wonders and dangers that await you. Within the depths I have seen feuding dragons, each on opposite sides of a tunnel.";
        private const string String0874 = "Magic permeates that place, so be sure you are protected. There is also a place called Hopeless Hallways and...wait, I shall let you return to your search. That story can wait.'";
        private const string String0926 = "With that he chuckles and walks away.";
        private const string String094C = "A herd of horses stampedes past your party, injuring you.";
        private const string String0986 = "A band of adventurers bickers over treasure.";
        private const string String09B3 = "Your pockets feel lighter because your horse lost.";
        private const string String09E6 = "'I found a place deep in the dungeon where babble rules. After exploring the place for quite some time, I stumbled upon some wall switches.";
        private const string String0A72 = "Walking into a wall changes its switch. I would still be down there if I hadn't figured out what words I was supposed to spell.'";
        private const string String0AF3 = "'A word of warning from a seasoned soldier -";
        private const string String0B20 = "Deep in the dungeon is a place where Harmony and Chaos are united.";
        private const string String0B63 = "Do not be overly concerned about being weakened by a burned hand. Eventually, it will be healed and you will receive a great blessing.'";
        private const string String0BEB = "'I've been wandering for days here and in the adjoining Rat Race. I feel like some mouse being led through a maze!";
        private const string String0C5E = "My fellow mages have warned me that I must find the two places open only to members of my Race.";
        private const string String0CBE = "Until I find them, I will not be able to get into the nether regions of this dungeon.'";
        private const string String0D15 = "Adventurers trick you into joining a battle and then turn on you.";
        private const string String0D57 = "Use Syrene's payment first.";
        private const string String0D73 = "Your long journey has taken a toll on you and you feel your mana decrease.";
        private const string String0DBE = "The waters of Elf Spring refresh and invigorate you.";
        private const string String0DF3 = "The waters of Elf Spring have no affect.";
        private const string String0E1C = "Dragons turn toward you and attack!";
        private const string String0E40 = "The sparkling waters of Universal Spring refresh and invigorate you.";
        private const string String0E85 = "The sparkling waters of Universal Spring endow you with the Resist spell.";
        private const string String0ECF = "The sparkling waters of Universal Spring endow you with the Poison Cloud spell.";
        private const string String0F1F = "You find an empty quest bag.";
        private const string String0F3C = "Congratulations, your horse finished first. You collect your winnings.";
        private const string String0F83 = "You successfully unlock the door.";
        private const string String0FA5 = "You see a door appear in the wall, but it is locked.";
        private const string String0FDA = "The waters of Gnome Spring refresh and invigorate you.";
        private const string String1011 = "The waters of Gnome Spring have no affect.";
        private const string String103C = "You stumble while searching the dark room, and one of your potions crashes to the floor.";
        private const string String1095 = "You fall clumsily in the dark room and manage to hurt yourself.";
        private const string String10D5 = "The door springs open.";
        private const string String10EC = "You see a skull and crossbones scratched into the door.";
        private const string String1124 = "The room is empty.";
        private const string String1137 = "You glimpse a scrap of leather on the floor.";
        private const string String1164 = "It is a Leather Map and is one of the four Queen Aeowyn sent you to find.";
        
        // === Functions ================================================
        private void FnSECGNO_01(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetRace(player), 0x0005);
            L000D: if (JumpNotEqual) goto L001C;
001D  000F FF 76 08  push word [bp+0x8]
0020  0012 FF 76 06  push word [bp+0x6]
0023  0015 0E     push cs
0024  0016 E8 6B 11  call 0x1184
            L0019: // NOP
            L001A: cx = PopStack(player);
            L001B: cx = PopStack(player);
            L001C: return; // RETURN;
        }

        private void FnSECA_02(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, 0x0D), 0x0006);
            L0012: if (JumpNotBelow) goto L006C;
            L0014: RefreshCompareFlags(HasUsedSpell(player, 0x17));
            L0022: if (JumpNotEqual) goto L006C;
            L0024: PushStack(player, 0x68);
            L0028: PushStack(player, ax);
0055  0029 C4 5E 06  les bx, [bp+0x6]
0058  002C 26 FF 5F 54  call far word [es:bx+0x54]
            L0030: cx = PopStack(player);
            L0031: cx = PopStack(player);
            L0032: RefreshCompareFlags(ax);
            L0034: if (JumpNotEqual) goto L006C;
            L0036: PushStack(player, 0x6E);
            L003A: PushStack(player, ax);
0067  003B C4 5E 06  les bx, [bp+0x6]
006A  003E 26 FF 5F 54  call far word [es:bx+0x54]
            L0042: cx = PopStack(player);
            L0043: cx = PopStack(player);
            L0044: RefreshCompareFlags(ax);
            L0046: if (JumpNotEqual) goto L006C;
            L0048: PushStack(player, 0x90);
            L004C: PushStack(player, ax);
0079  004D C4 5E 06  les bx, [bp+0x6]
007C  0050 26 FF 5F 54  call far word [es:bx+0x54]
            L0054: cx = PopStack(player);
            L0055: cx = PopStack(player);
            L0056: RefreshCompareFlags(ax);
            L0058: if (JumpNotEqual) goto L006C;
            L005A: PushStack(player, 0xA4);
            L005E: PushStack(player, ax);
008B  005F C4 5E 06  les bx, [bp+0x6]
008E  0062 26 FF 5F 54  call far word [es:bx+0x54]
            L0066: cx = PopStack(player);
            L0067: cx = PopStack(player);
            L0068: RefreshCompareFlags(ax);
            L006A: if (JumpEqual) goto L0093;
            L006C: ShowMessage(player, String03FC); // You spot a hidden door.
00A5  0079 FF 76 08  push word [bp+0x8]
00A8  007C FF 76 06  push word [bp+0x6]
00AB  007F 0E     push cs
00AC  0080 E8 A6 11  call 0x1229
            L0083: // NOP
            L0084: cx = PopStack(player);
            L0085: cx = PopStack(player);
00B2  0086 FF 76 08  push word [bp+0x8]
00B5  0089 FF 76 06  push word [bp+0x6]
00B8  008C 0E     push cs
00B9  008D E8 DE 11  call 0x126e
            L0090: // NOP
            L0091: goto L009E;
00BF  0093 FF 76 08  push word [bp+0x8]
00C2  0096 FF 76 06  push word [bp+0x6]
00C5  0099 0E     push cs
00C6  009A E8 AF 11  call 0x124c
            L009D: // NOP
            L009E: cx = PopStack(player);
            L009F: cx = PopStack(player);
            L00A0: return; // RETURN;
        }

        private void FnTELEA_03(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x06, 0x03, 0xA4, 0x03, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnWEAPA_04(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: // make space for tmp on stack: sp -= 2
00F3  0005 56     push si
00F4  0006 57     push di
            L0007: di = 0;
            L0009: si = 0;
            L000B: ax = HasItem(player, 0x3A);
            L0019: if (JumpNotEqual) goto L002B;
            L001B: ax = HasItem(player, 0x0D);
            L0029: if (JumpEqual) goto L002E;
            L002B: goto L00AA;
            L002D: // NOP
            L002E: Compare(GetGuild(player), 0x0001);
            L0038: if (JumpEqual) goto L0046;
            L003A: Compare(ax, 0x0003);
            L003D: if (JumpEqual) goto L0046;
            L003F: Compare(ax, 0x0005);
            L0042: if (JumpEqual) goto L0046;
            L0044: goto L004B;
            L0046: di = 0x000D;
            L0049: goto L004E;
            L004B: di = 0x003A;
            L004E: ax = GetCurrentTile(player);
0143  0055 89 46 FE  mov [bp-0x2], ax
0146  0058 B9 04 00  mov cx, 0x4
            L005B: bx = 0x024C;
014C  005E 2E 8B 07  mov ax, [cs:bx]
014F  0061 3B 46 FE  cmp ax, [bp-0x2]
            L0064: if (JumpEqual) goto L006C;
0154  0066 43     inc bx
0155  0067 43     inc bx
0156  0068 E2 F4  loop 0x5e
            L006A: goto L0081;
015A  006C 2E FF 67 08  jmp word [cs:bx+0x8]
            L0070: si = 0x0006;
            L0073: goto L0081;
            L0075: si = 0;
            L0077: goto L0081;
            L0079: si = 0x0001;
            L007C: goto L0081;
            L007E: si = 0x0004;
            L0081: Compare(GetRace(player), si);
            L008A: if (JumpNotEqual) goto L00AA;
017A  008C B8 B8 0B  mov ax, 0xbb8
            L008F: PushStack(player, ax);
            L0090: PushStack(player, 0x00);
            L0093: PushStack(player, ax);
            L0094: PushStack(player, 0xB6);
            L0098: PushStack(player, 0xC0);
018A  009C 57     push di
018B  009D C4 5E 06  les bx, [bp+0x6]
018E  00A0 26 FF 9F D8 00  call far word [es:bx+0xd8]
0193  00A5 83 C4 0C  add sp, 0xc
            L00A8: goto L00B7;
0198  00AA FF 76 08  push word [bp+0x8]
019B  00AD FF 76 06  push word [bp+0x6]
019E  00B0 0E     push cs
019F  00B1 E8 1B 11  call 0x11cf
            L00B4: // NOP
            L00B5: cx = PopStack(player);
            L00B6: cx = PopStack(player);
            L00B7: Compare(PartyCount(player), 0x0001);
            L00C2: if (JumpEqual) goto L00CB;
            L00C4: Compare(ax, 0x0002);
            L00C7: if (JumpEqual) goto L00E6;
            L00C9: goto L0110;
            L00CB: AddEncounter(player, 0x01, 0x09);
            L00DD: PushStack(player, 0x1E);
01CF  00E1 B8 02 00  mov ax, 0x2
            L00E4: goto L014D;
            L00E6: AddEncounter(player, 0x01, 0x09);
            L00F8: AddEncounter(player, 0x02, 0x09);
            L010A: PushStack(player, 0x05);
            L010E: goto L014D;
            L0110: AddEncounter(player, 0x01, 0x09);
            L0122: AddEncounter(player, 0x02, 0x09);
            L0134: AddEncounter(player, 0x05, 0x1B);
            L0146: AddEncounter(player, 0x06, 0x1B);
0246  0158 5F     pop di
0247  0159 5E     pop si
            L015A: // restore stack ptr: sp = bp;
            L015C: return; // RETURN;
            // Extra data: 15 00 1E 00 A3 00 C9 00 5E 01 63 01 67 01 6C 01 
        }

        private void FnTEXTWA_05(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetRace(player), 0x0006);
            L000D: if (JumpNotEqual) goto L001C;
            L000F: ShowMessage(player, String0414); // Use Kalydor's payment first.
            L001C: return; // RETURN;
        }

        private void FnSECHALF_06(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetRace(player), 0x0006);
            L000D: if (JumpNotEqual) goto L001C;
0289  000F FF 76 08  push word [bp+0x8]
028C  0012 FF 76 06  push word [bp+0x6]
028F  0015 0E     push cs
0290  0016 E8 FF 0E  call 0xf18
            L0019: // NOP
            L001A: cx = PopStack(player);
            L001B: cx = PopStack(player);
            L001C: return; // RETURN;
        }

        private void FnSECMSG_07(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0431); // The clutter of spent crystal balls littering the ground reminds you that many times a door can be detected by using magic.
            L0010: return; // RETURN;
        }

        private void FnTELEB_08(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x06, 0x03, 0x2F, 0x00, isForwardMove);
            L001D: return; // RETURN;
        }

        private void FnMAPE_09(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: // make space for tmp on stack: sp -= 2
02CE  0005 56     push si
            L0006: ax = GetCurrentTile(player);
02D6  000D 89 46 FE  mov [bp-0x2], ax
02D9  0010 B9 04 00  mov cx, 0x4
            L0013: bx = 0x037D;
02DF  0016 2E 8B 07  mov ax, [cs:bx]
02E2  0019 3B 46 FE  cmp ax, [bp-0x2]
            L001C: if (JumpEqual) goto L0024;
02E7  001E 43     inc bx
02E8  001F 43     inc bx
02E9  0020 E2 F4  loop 0x16
            L0022: goto L003A;
02ED  0024 2E FF 67 08  jmp word [cs:bx+0x8]
            L0028: si = 0x0005;
            L002B: goto L003A;
            L002D: si = 0x0003;
            L0030: goto L003A;
            L0032: si = 0x0007;
            L0035: goto L003A;
            L0037: si = 0x0002;
            L003A: ax = HasItem(player, 0xD5);
            L0048: if (JumpEqual) goto L004C;
            L004A: goto L00A2;
            L004C: Compare(GetRace(player), si);
            L0055: if (JumpNotEqual) goto L00A2;
            L0057: RefreshCompareFlags(GetFlag(player, 0x02, 0x51));
            L006A: if (JumpNotEqual) goto L00A0;
            L006C: SetFlag(player, 0x02, 0x51, 0x01);
            L0081: AddExperience(player, 0x00030D40);
035C  0093 FF 76 08  push word [bp+0x8]
035F  0096 FF 76 06  push word [bp+0x6]
0362  0099 0E     push cs
0363  009A E8 A1 0E  call 0xf3e
            L009D: // NOP
            L009E: goto L00AD;
            L00A0: goto L0093;
036B  00A2 FF 76 08  push word [bp+0x8]
036E  00A5 FF 76 06  push word [bp+0x6]
0371  00A8 0E     push cs
0372  00A9 E8 80 0E  call 0xf2c
            L00AC: // NOP
            L00AD: cx = PopStack(player);
            L00AE: cx = PopStack(player);
0378  00AF 5E     pop si
            L00B0: // restore stack ptr: sp = bp;
            L00B2: return; // RETURN;
            // Extra data: 22 00 5B 00 74 00 CC 00 F1 02 F6 02 FB 02 00 03 
        }

        private void FnTELEC_0A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x06, 0x03, 0x0B, 0x02, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnTELED_0B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x06, 0x03, 0x4A, 0x00, isForwardMove);
            L001D: return; // RETURN;
        }

        private void FnSECB_0C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0021: return; // RETURN;
        }

        private void FnTEXTWB_0D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetRace(player));
            L000C: if (JumpNotEqual) goto L001B;
            L000E: ShowMessage(player, String04AC); // Use the Topaz before the Ebony.
            L001B: return; // RETURN;
        }

        private void FnGENTXT_0E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String04CC); // A group of vicious monsters appears to guard this area.
            L0010: return; // RETURN;
        }

        private void FnSECD_0F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0029);
            L0010: ShowMessage(player, String0504); // With a gleam in his eyes, a halfling approaches you.
            L001D: ShowMessage(player, String0539); // 'Well! It took me a lot of crystal balls to find out that most of these secret passages are actually illusionary walls!
            L002A: ShowMessage(player, String05B1); // But not all was in vain, I did find some secret doors and they led me..well, I'll let you find that out. I wonder who built this place.'
            L0037: ShowMessage(player, String063A); // With that, he returns to contemplating his maps.
            L0044: return; // RETURN;
        }

        private void FnSECHUME_10(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetRace(player));
            L000C: if (JumpNotEqual) goto L001B;
0472  000E FF 76 08  push word [bp+0x8]
0475  0011 FF 76 06  push word [bp+0x6]
0478  0014 0E     push cs
0479  0015 E8 16 0D  call 0xd2e
            L0018: // NOP
            L0019: cx = PopStack(player);
            L001A: cx = PopStack(player);
            L001B: return; // RETURN;
        }

        private void FnFTNORC_11(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetRace(player), 0x0001);
            L000D: if (JumpNotEqual) goto L0021;
0490  000F FF 76 08  push word [bp+0x8]
0493  0012 FF 76 06  push word [bp+0x6]
0496  0015 0E     push cs
0497  0016 E8 98 0D  call 0xdb1
            L0019: // NOP
            L001A: cx = PopStack(player);
            L001B: cx = PopStack(player);
049D  001C B8 6B 06  mov ax, 0x66b
            L001F: goto L0024;
            L0021: ShowMessage(player, String06A0); // The waters of Orc Spring have no affect.
            L002E: return; // RETURN;
        }

        private void FnFTNDWF_12(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetRace(player), 0x0004);
            L000D: if (JumpNotEqual) goto L0021;
04C0  000F FF 76 08  push word [bp+0x8]
04C3  0012 FF 76 06  push word [bp+0x6]
04C6  0015 0E     push cs
04C7  0016 E8 68 0D  call 0xd81
            L0019: // NOP
            L001A: cx = PopStack(player);
            L001B: cx = PopStack(player);
04CD  001C B8 C9 06  mov ax, 0x6c9
            L001F: goto L0024;
            L0021: ShowMessage(player, String0700); // The waters of Dwarf Spring have no affect.
            L002E: return; // RETURN;
        }

        private void FnTELEE_13(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x06, 0x03, 0x7E, 0x02, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnJOLLYCLU_14(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x002D);
            L0010: ShowMessage(player, String072B); // A gnome with a merry gleam in his eye greets your with a chuckle. 'You are much too serious, my friend! Keep searching, you will find what you seek, I swear!'
            L001D: ShowMessage(player, String07CA); // He becomes serious for a moment and says, 'Ah, the wonders and dangers that await you. Within the depths I have seen feuding dragons, each on opposite sides of a tunnel.
            L002A: ShowMessage(player, String0874); // Magic permeates that place, so be sure you are protected. There is also a place called Hopeless Hallways and...wait, I shall let you return to your search. That story can wait.'
            L0037: ShowMessage(player, String0926); // With that he chuckles and walks away.
            L0044: return; // RETURN;
        }

        private void FnTELEF_17(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x06, 0x03, 0x6A, 0x03, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnHEALDOWN_18(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x02);
            L0007: PushStack(player, 0x00);
057B  000A C4 5E 06  les bx, [bp+0x6]
057E  000D 26 FF 5F 04  call far word [es:bx+0x4]
            L0011: cx = PopStack(player);
            L0012: cx = PopStack(player);
            L0013: RefreshCompareFlags(ax);
            L0015: if (JumpNotEqual) goto L004F;
            L0017: ax = GetMaxHits(player);
            L001E: bx = 0x0004;
            L0021: dx = ax % bx; ax = ax / bx;
            L0024: DamagePlayer(player, ax);
            L002E: ShowMessage(player, String094C); // A herd of horses stampedes past your party, injuring you.
            L003B: SetFlag(player, 0x00, 0x02, 0x01);
            L004F: return; // RETURN;
        }

        private void FnSECTRO_19(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetRace(player), 0x0003);
            L000D: if (JumpNotEqual) goto L001C;
05D1  000F FF 76 08  push word [bp+0x8]
05D4  0012 FF 76 06  push word [bp+0x6]
05D7  0015 0E     push cs
05D8  0016 E8 B7 0B  call 0xbd0
            L0019: // NOP
            L001A: cx = PopStack(player);
            L001B: cx = PopStack(player);
            L001C: return; // RETURN;
        }

        private void FnGOODIEA_1A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
05E3  0003 B8 D0 07  mov ax, 0x7d0
            L0006: PushStack(player, ax);
            L0007: PushStack(player, 0x00);
            L000A: PushStack(player, ax);
            L000B: PushStack(player, ax);
            L000C: PushStack(player, 0x8C);
            L0010: PushStack(player, 0xBA);
05F4  0014 C4 5E 06  les bx, [bp+0x6]
05F7  0017 26 FF 9F D8 00  call far word [es:bx+0xd8]
05FC  001C 83 C4 0C  add sp, 0xc
            L001F: ShowMessage(player, String0986); // A band of adventurers bickers over treasure.
            L002C: Compare(PartyCount(player), 0x0001);
            L0037: if (JumpNotEqual) goto L0055;
            L0039: AddEncounter(player, 0x01, 0x15);
            L004B: PushStack(player, 0x21);
062F  004F B8 02 00  mov ax, 0x2
            L0052: goto L00F0;
            L0055: Compare(PartyCount(player), 0x0002);
            L0060: if (JumpNotEqual) goto L008F;
            L0062: AddEncounter(player, 0x01, 0x15);
            L0074: AddEncounter(player, 0x02, 0x16);
            L0086: PushStack(player, 0x21);
066A  008A B8 05 00  mov ax, 0x5
            L008D: goto L00F0;
            L008F: AddEncounter(player, 0x01, 0x23);
            L00A1: AddEncounter(player, 0x02, 0x24);
            L00B3: AddEncounter(player, 0x03, 0x25);
            L00C5: AddEncounter(player, 0x04, 0x26);
            L00D7: AddEncounter(player, 0x05, 0x27);
            L00E9: AddEncounter(player, 0x06, 0x28);
            L00FB: return; // RETURN;
        }

        private void FnGOLDDOWN_1B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ModifyGold(player, 0xFFFF30BA);
            L0015: ShowMessage(player, String09B3); // Your pockets feel lighter because your horse lost.
            L0022: return; // RETURN;
        }

        private void FnNPCCLUEA_1C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0023);
            L0010: ShowMessage(player, String09E6); // 'I found a place deep in the dungeon where babble rules. After exploring the place for quite some time, I stumbled upon some wall switches.
            L001D: ShowMessage(player, String0A72); // Walking into a wall changes its switch. I would still be down there if I hadn't figured out what words I was supposed to spell.'
            L002A: return; // RETURN;
        }

        private void FnNPCCLUEB_1D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0016);
            L0010: ShowMessage(player, String0AF3); // 'A word of warning from a seasoned soldier -
            L001D: ShowMessage(player, String0B20); // Deep in the dungeon is a place where Harmony and Chaos are united.
            L002A: ShowMessage(player, String0B63); // Do not be overly concerned about being weakened by a burned hand. Eventually, it will be healed and you will receive a great blessing.'
            L0037: return; // RETURN;
        }

        private void FnTELEG_1E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x06, 0x03, 0x23, 0x00, isForwardMove);
            L001D: return; // RETURN;
        }

        private void FnNPCCLUEC_1F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x002C);
            L0010: ShowMessage(player, String0BEB); // 'I've been wandering for days here and in the adjoining Rat Race. I feel like some mouse being led through a maze!
            L001D: ShowMessage(player, String0C5E); // My fellow mages have warned me that I must find the two places open only to members of my Race.
            L002A: ShowMessage(player, String0CBE); // Until I find them, I will not be able to get into the nether regions of this dungeon.'
            L0037: return; // RETURN;
        }

        private void FnSECGRE_21(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetRace(player), 0x0007);
            L000D: if (JumpNotEqual) goto L001C;
07D2  000F FF 76 08  push word [bp+0x8]
07D5  0012 FF 76 06  push word [bp+0x6]
07D8  0015 0E     push cs
07D9  0016 E8 B6 09  call 0x9cf
            L0019: // NOP
            L001A: cx = PopStack(player);
            L001B: cx = PopStack(player);
            L001C: return; // RETURN;
        }

        private void FnGOODIEB_22(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
07E4  0003 B8 D0 07  mov ax, 0x7d0
            L0006: PushStack(player, ax);
            L0007: PushStack(player, 0x00);
            L000A: PushStack(player, ax);
            L000B: PushStack(player, ax);
            L000C: PushStack(player, 0xA7);
            L0010: PushStack(player, 0x94);
07F5  0014 C4 5E 06  les bx, [bp+0x6]
07F8  0017 26 FF 9F D8 00  call far word [es:bx+0xd8]
07FD  001C 83 C4 0C  add sp, 0xc
            L001F: ShowMessage(player, String0D15); // Adventurers trick you into joining a battle and then turn on you.
            L002C: Compare(PartyCount(player), 0x0001);
            L0037: if (JumpNotEqual) goto L0055;
            L0039: AddEncounter(player, 0x01, 0x23);
            L004B: PushStack(player, 0x23);
0830  004F B8 02 00  mov ax, 0x2
            L0052: goto L00DE;
            L0055: Compare(PartyCount(player), 0x0002);
            L0060: if (JumpNotEqual) goto L008F;
            L0062: AddEncounter(player, 0x01, 0x0F);
            L0074: AddEncounter(player, 0x02, 0x11);
            L0086: PushStack(player, 0x10);
086B  008A B8 04 00  mov ax, 0x4
            L008D: goto L00CC;
            L008F: AddEncounter(player, 0x01, 0x0F);
            L00A1: AddEncounter(player, 0x02, 0x11);
            L00B3: AddEncounter(player, 0x04, 0x10);
            L00C5: AddEncounter(player, 0x05, 0x27);
            L00D7: AddEncounter(player, 0x06, 0x28);
            L00E9: return; // RETURN;
        }

        private void FnSECORC_23(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetRace(player), 0x0001);
            L000D: if (JumpNotEqual) goto L001C;
08DB  000F FF 76 08  push word [bp+0x8]
08DE  0012 FF 76 06  push word [bp+0x6]
08E1  0015 0E     push cs
08E2  0016 E8 AD 08  call 0x8c6
            L0019: // NOP
            L001A: cx = PopStack(player);
            L001B: cx = PopStack(player);
            L001C: return; // RETURN;
        }

        private void FnTEXTWC_24(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetRace(player), 0x0001);
            L000D: if (JumpNotEqual) goto L001C;
            L000F: ShowMessage(player, String0D57); // Use Syrene's payment first.
            L001C: return; // RETURN;
        }

        private void FnMANADOWN_25(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddMana(player, 0xFF38);
            L0010: ShowMessage(player, String0D73); // Your long journey has taken a toll on you and you feel your mana decrease.
            L001D: return; // RETURN;
        }

        private void FnFTNELF_27(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetRace(player), 0x0002);
            L000D: if (JumpNotEqual) goto L0021;
093B  000F FF 76 08  push word [bp+0x8]
093E  0012 FF 76 06  push word [bp+0x6]
0941  0015 0E     push cs
0942  0016 E8 ED 08  call 0x906
            L0019: // NOP
            L001A: cx = PopStack(player);
            L001B: cx = PopStack(player);
0948  001C B8 BE 0D  mov ax, 0xdbe
            L001F: goto L0024;
            L0021: ShowMessage(player, String0DF3); // The waters of Elf Spring have no affect.
            L002E: return; // RETURN;
        }

        private void FnTELEH_29(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x06, 0x03, 0xAF, 0x00, isForwardMove);
            L001D: return; // RETURN;
        }

        private void FnGOODIEC_2C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
098D  0003 B8 D0 07  mov ax, 0x7d0
            L0006: PushStack(player, ax);
            L0007: PushStack(player, 0x00);
            L000A: PushStack(player, ax);
            L000B: PushStack(player, ax);
            L000C: PushStack(player, 0x9B);
            L0010: PushStack(player, 0x9F);
099E  0014 C4 5E 06  les bx, [bp+0x6]
09A1  0017 26 FF 9F D8 00  call far word [es:bx+0xd8]
09A6  001C 83 C4 0C  add sp, 0xc
            L001F: ShowMessage(player, String0E1C); // Dragons turn toward you and attack!
            L002C: Compare(PartyCount(player), 0x0001);
            L0037: if (JumpNotEqual) goto L0055;
            L0039: AddEncounter(player, 0x01, 0x0C);
            L004B: PushStack(player, 0x1C);
09D9  004F B8 02 00  mov ax, 0x2
            L0052: goto L00DA;
            L0055: Compare(PartyCount(player), 0x0002);
            L0060: if (JumpNotEqual) goto L008B;
            L0062: AddEncounter(player, 0x01, 0x0B);
            L0074: AddEncounter(player, 0x02, 0x0B);
0A10  0086 B8 1C 00  mov ax, 0x1c
            L0089: goto L00D6;
            L008B: AddEncounter(player, 0x01, 0x0B);
            L009D: AddEncounter(player, 0x02, 0x0B);
            L00AF: AddEncounter(player, 0x03, 0x1C);
            L00C1: AddEncounter(player, 0x04, 0x1D);
            L00D3: AddEncounter(player, 0x05, 0x1D);
            L00E5: return; // RETURN;
        }

        private void FnTELEI_2D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x06, 0x03, 0xB9, 0x01, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnSECELF_2E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetRace(player), 0x0002);
            L000D: if (JumpNotEqual) goto L001C;
0AA0  000F FF 76 08  push word [bp+0x8]
0AA3  0012 FF 76 06  push word [bp+0x6]
0AA6  0015 0E     push cs
0AA7  0016 E8 E8 06  call 0x701
            L0019: // NOP
            L001A: cx = PopStack(player);
            L001B: cx = PopStack(player);
            L001C: return; // RETURN;
        }

        private void FnSECDWF_2F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetRace(player), 0x0004);
            L000D: if (JumpNotEqual) goto L001C;
0ABE  000F FF 76 08  push word [bp+0x8]
0AC1  0012 FF 76 06  push word [bp+0x6]
0AC4  0015 0E     push cs
0AC5  0016 E8 CA 06  call 0x6e3
            L0019: // NOP
            L001A: cx = PopStack(player);
            L001B: cx = PopStack(player);
            L001C: return; // RETURN;
        }

        private void FnTEXTWD_30(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetRace(player), 0x0004);
            L000D: if (JumpNotEqual) goto L001C;
            L000F: ShowMessage(player, String04AC); // Use the Topaz before the Ebony.
            L001C: return; // RETURN;
        }

        private void FnFTN_35(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0x52), 0x0001);
            L0017: if (JumpNotEqual) goto L002B;
0B18  0019 FF 76 08  push word [bp+0x8]
0B1B  001C FF 76 06  push word [bp+0x6]
0B1E  001F 0E     push cs
0B1F  0020 E8 10 07  call 0x733
            L0023: // NOP
            L0024: cx = PopStack(player);
            L0025: cx = PopStack(player);
0B25  0026 B8 40 0E  mov ax, 0xe40
            L0029: goto L008E;
            L002B: SetFlag(player, 0x02, 0x52, 0x01);
0B3F  0040 FF 76 08  push word [bp+0x8]
0B42  0043 FF 76 06  push word [bp+0x6]
0B45  0046 0E     push cs
0B46  0047 E8 E9 06  call 0x733
            L004A: // NOP
            L004B: cx = PopStack(player);
            L004C: cx = PopStack(player);
            L004D: RefreshCompareFlags(GetGuild(player));
            L0056: if (JumpEqual) goto L0064;
            L0058: Compare(GetGuild(player), 0x0001);
            L0062: if (JumpNotEqual) goto L007A;
            L0064: SetSpellLevel(player, 0x15, 0x01);
0B74  0075 B8 85 0E  mov ax, 0xe85
            L0078: goto L008E;
            L007A: SetSpellLevel(player, 0x0A, 0x01);
            L008B: ShowMessage(player, String0ECF); // The sparkling waters of Universal Spring endow you with the Poison Cloud spell.
            L0098: return; // RETURN;
        }

        private void FnTELEJ_36(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x06, 0x03, 0xF1, 0x00, isForwardMove);
            L001D: return; // RETURN;
        }

        private void FnPLUSGOLD_37(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0x53), 0x0001);
            L0017: if (JumpNotEqual) goto L001E;
0BD1  0019 B8 1F 0F  mov ax, 0xf1f
            L001C: goto L0047;
            L001E: ModifyGold(player, 0xC350);
            L002F: SetFlag(player, 0x02, 0x53, 0x01);
            L0044: ShowMessage(player, String0F3C); // Congratulations, your horse finished first. You collect your winnings.
            L0051: return; // RETURN;
        }

        private void FnSECQ_39(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, 0x0D), 0x0006);
            L0012: if (JumpNotBelow) goto L0083;
            L0014: RefreshCompareFlags(HasUsedSpell(player, 0x17));
            L0022: if (JumpNotEqual) goto L0083;
            L0024: PushStack(player, 0x68);
            L0028: PushStack(player, ax);
0C39  0029 C4 5E 06  les bx, [bp+0x6]
0C3C  002C 26 FF 5F 54  call far word [es:bx+0x54]
            L0030: cx = PopStack(player);
            L0031: cx = PopStack(player);
            L0032: RefreshCompareFlags(ax);
            L0034: if (JumpNotEqual) goto L0083;
            L0036: PushStack(player, 0x6E);
            L003A: PushStack(player, ax);
0C4B  003B C4 5E 06  les bx, [bp+0x6]
0C4E  003E 26 FF 5F 54  call far word [es:bx+0x54]
            L0042: cx = PopStack(player);
            L0043: cx = PopStack(player);
            L0044: RefreshCompareFlags(ax);
            L0046: if (JumpNotEqual) goto L0083;
            L0048: PushStack(player, 0x90);
            L004C: PushStack(player, ax);
0C5D  004D C4 5E 06  les bx, [bp+0x6]
0C60  0050 26 FF 5F 54  call far word [es:bx+0x54]
            L0054: cx = PopStack(player);
            L0055: cx = PopStack(player);
            L0056: RefreshCompareFlags(ax);
            L0058: if (JumpNotEqual) goto L0083;
            L005A: PushStack(player, 0xA4);
            L005E: PushStack(player, ax);
0C6F  005F C4 5E 06  les bx, [bp+0x6]
0C72  0062 26 FF 5F 54  call far word [es:bx+0x54]
            L0066: cx = PopStack(player);
            L0067: cx = PopStack(player);
            L0068: RefreshCompareFlags(ax);
            L006A: if (JumpNotEqual) goto L0083;
            L006C: ax = IsFlagOn(player, 0x00, 0x01);
            L007E: if (JumpNotEqual) goto L0083;
            L0080: goto L0119;
            L0083: PushStack(player, 0x01);
            L0087: PushStack(player, ax);
            L0088: PushStack(player, 0x00);
0C9B  008B C4 5E 06  les bx, [bp+0x6]
0C9E  008E 26 FF 1F  call far word [es:bx]
0CA1  0091 83 C4 06  add sp, 0x6
            L0094: PushStack(player, 0xC0);
            L0098: PushStack(player, ax);
0CA9  0099 C4 5E 06  les bx, [bp+0x6]
0CAC  009C 26 FF 5F 54  call far word [es:bx+0x54]
            L00A0: cx = PopStack(player);
            L00A1: cx = PopStack(player);
            L00A2: RefreshCompareFlags(ax);
            L00A4: if (JumpNotEqual) goto L00C9;
            L00A6: PushStack(player, 0x6F);
            L00AA: PushStack(player, ax);
0CBB  00AB C4 5E 06  les bx, [bp+0x6]
0CBE  00AE 26 FF 5F 54  call far word [es:bx+0x54]
            L00B2: cx = PopStack(player);
            L00B3: cx = PopStack(player);
            L00B4: RefreshCompareFlags(ax);
            L00B6: if (JumpNotEqual) goto L00C9;
            L00B8: Compare(HasUsedSkill(player, 0x0E), 0x0008);
            L00C7: if (JumpBelow) goto L00F0;
            L00C9: ShowMessage(player, String0F83); // You successfully unlock the door.
0CE6  00D6 FF 76 08  push word [bp+0x8]
0CE9  00D9 FF 76 06  push word [bp+0x6]
0CEC  00DC 0E     push cs
0CED  00DD E8 65 05  call 0x645
            L00E0: // NOP
            L00E1: cx = PopStack(player);
            L00E2: cx = PopStack(player);
0CF3  00E3 FF 76 08  push word [bp+0x8]
0CF6  00E6 FF 76 06  push word [bp+0x6]
0CF9  00E9 0E     push cs
0CFA  00EA E8 9D 05  call 0x68a
            L00ED: // NOP
            L00EE: goto L0124;
0D00  00F0 FF 76 08  push word [bp+0x8]
0D03  00F3 FF 76 06  push word [bp+0x6]
0D06  00F6 0E     push cs
0D07  00F7 E8 6E 05  call 0x668
            L00FA: // NOP
            L00FB: cx = PopStack(player);
            L00FC: cx = PopStack(player);
0D0D  00FD FF 76 08  push word [bp+0x8]
0D10  0100 FF 76 06  push word [bp+0x6]
0D13  0103 0E     push cs
0D14  0104 E8 3E 05  call 0x645
            L0107: // NOP
            L0108: cx = PopStack(player);
            L0109: cx = PopStack(player);
            L010A: ShowMessage(player, String0FA5); // You see a door appear in the wall, but it is locked.
            L0117: goto L0126;
0D29  0119 FF 76 08  push word [bp+0x8]
0D2C  011C FF 76 06  push word [bp+0x6]
0D2F  011F 0E     push cs
0D30  0120 E8 45 05  call 0x668
            L0123: // NOP
            L0124: cx = PopStack(player);
            L0125: cx = PopStack(player);
            L0126: return; // RETURN;
        }

        private void FnFTNGNO_3C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetRace(player), 0x0005);
            L000D: if (JumpNotEqual) goto L0021;
0D51  000F FF 76 08  push word [bp+0x8]
0D54  0012 FF 76 06  push word [bp+0x6]
0D57  0015 0E     push cs
0D58  0016 E8 D7 04  call 0x4f0
            L0019: // NOP
            L001A: cx = PopStack(player);
            L001B: cx = PopStack(player);
0D5E  001C B8 DA 0F  mov ax, 0xfda
            L001F: goto L0024;
            L0021: ShowMessage(player, String1011); // The waters of Gnome Spring have no affect.
            L002E: return; // RETURN;
        }

        private void FnBOTLDOWN_3E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x03);
            L0007: PushStack(player, 0x00);
0D81  000A C4 5E 06  les bx, [bp+0x6]
0D84  000D 26 FF 5F 04  call far word [es:bx+0x4]
            L0011: cx = PopStack(player);
            L0012: cx = PopStack(player);
            L0013: RefreshCompareFlags(ax);
            L0015: if (JumpNotEqual) goto L007A;
            L0017: ax = HasItem(player, 0xB7);
            L0025: if (JumpEqual) goto L0042;
            L0027: RemoveItem(player, 0xB7);
            L0033: ShowMessage(player, String103C); // You stumble while searching the dark room, and one of your potions crashes to the floor.
            L0040: goto L007A;
            L0042: ax = GetMaxHits(player);
            L0049: bx = 0x000A;
            L004C: dx = ax % bx; ax = ax / bx;
            L004F: DamagePlayer(player, ax);
            L0059: ShowMessage(player, String1095); // You fall clumsily in the dark room and manage to hurt yourself.
            L0066: SetFlag(player, 0x00, 0x03, 0x01);
            L007A: return; // RETURN;
        }

        private void FnMEDA_3F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L001A;
            L0010: PushStack(player, 0x13);
0E07  0014 B8 01 00  mov ax, 0x1
            L0017: goto L00A3;
            L001A: Compare(PartyCount(player), 0x0002);
            L0025: if (JumpNotEqual) goto L0054;
            L0027: AddEncounter(player, 0x01, 0x0F);
            L0039: AddEncounter(player, 0x02, 0x0F);
            L004B: PushStack(player, 0x14);
0E42  004F B8 05 00  mov ax, 0x5
            L0052: goto L00A3;
            L0054: AddEncounter(player, 0x01, 0x10);
            L0066: AddEncounter(player, 0x02, 0x1F);
            L0078: AddEncounter(player, 0x03, 0x21);
            L008A: AddEncounter(player, 0x05, 0x21);
            L009C: AddEncounter(player, 0x06, 0x22);
            L00AE: return; // RETURN;
        }

        private void FnEZA_40(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L002C;
            L0010: AddEncounter(player, 0x01, 0x06);
            L0022: PushStack(player, 0x17);
0EC9  0026 B8 02 00  mov ax, 0x2
            L0029: goto L00B5;
            L002C: Compare(PartyCount(player), 0x0002);
            L0037: if (JumpNotEqual) goto L0078;
            L0039: AddEncounter(player, 0x01, 0x1E);
            L004B: AddEncounter(player, 0x02, 0x1E);
            L005D: AddEncounter(player, 0x05, 0x18);
            L006F: PushStack(player, 0x15);
0F16  0073 B8 06 00  mov ax, 0x6
            L0076: goto L00B5;
            L0078: AddEncounter(player, 0x01, 0x07);
            L008A: AddEncounter(player, 0x02, 0x07);
            L009C: AddEncounter(player, 0x03, 0x15);
            L00AE: AddEncounter(player, 0x05, 0x26);
            L00C0: return; // RETURN;
        }

        private void FnMEDB_42(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L001A;
            L0010: PushStack(player, 0x03);
0F7E  0014 B8 01 00  mov ax, 0x1
            L0017: goto L00A0;
            L001A: Compare(PartyCount(player), 0x0002);
            L0025: if (JumpNotEqual) goto L0054;
            L0027: AddEncounter(player, 0x01, 0x02);
            L0039: AddEncounter(player, 0x02, 0x04);
            L004B: PushStack(player, 0x1A);
0FB9  004F B8 05 00  mov ax, 0x5
            L0052: goto L00A0;
            L0054: AddEncounter(player, 0x01, 0x02);
            L0066: PushStack(player, 0x02);
            L006A: PushStack(player, ax);
0FD5  006B C4 5E 06  les bx, [bp+0x6]
0FD8  006E 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L0073: cx = PopStack(player);
            L0074: cx = PopStack(player);
            L0075: AddEncounter(player, 0x03, 0x01);
            L0087: AddEncounter(player, 0x04, 0x01);
            L0099: AddEncounter(player, 0x06, 0x1A);
            L00AB: return; // RETURN;
        }

        private void FnMEDC_43(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L002B;
            L0010: AddEncounter(player, 0x01, 0x06);
            L0022: PushStack(player, 0x06);
103D  0026 B8 02 00  mov ax, 0x2
            L0029: goto L0090;
            L002B: Compare(PartyCount(player), 0x0002);
            L0036: if (JumpNotEqual) goto L0053;
            L0038: AddEncounter(player, 0x01, 0x06);
            L004A: PushStack(player, 0x06);
1065  004E B8 02 00  mov ax, 0x2
            L0051: goto L007E;
            L0053: AddEncounter(player, 0x01, 0x06);
            L0065: AddEncounter(player, 0x02, 0x06);
            L0077: AddEncounter(player, 0x05, 0x1B);
            L0089: AddEncounter(player, 0x06, 0x1B);
            L009B: return; // RETURN;
        }

        private void FnHRDB_44(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L002C;
            L0010: AddEncounter(player, 0x01, 0x10);
            L0022: PushStack(player, 0x19);
10DA  0026 B8 02 00  mov ax, 0x2
            L0029: goto L00C7;
            L002C: Compare(PartyCount(player), 0x0002);
            L0037: if (JumpNotEqual) goto L0066;
            L0039: AddEncounter(player, 0x01, 0x0F);
            L004B: AddEncounter(player, 0x02, 0x10);
            L005D: PushStack(player, 0x1F);
1115  0061 B8 03 00  mov ax, 0x3
            L0064: goto L00C7;
            L0066: AddEncounter(player, 0x01, 0x10);
            L0078: AddEncounter(player, 0x02, 0x10);
            L008A: AddEncounter(player, 0x03, 0x1F);
            L009C: AddEncounter(player, 0x04, 0x1F);
            L00AE: AddEncounter(player, 0x05, 0x24);
            L00C0: AddEncounter(player, 0x06, 0x25);
            L00D2: return; // RETURN;
        }

        private void Fn_46(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: return; // RETURN;
            // Extra data: 55 8B EC B8 45 00 50 B8 02 00 50 C4 5E 06 26 FF 5F 04 59 59 3D 01 00 75 2E B8 D0 00 50 50 C4 5E 06 26 FF 5F 54 59 59 0B C0 74 1C B8 D5 10 50 C4 5E 06 26 FF 9F F8 00 59 FF 76 08 FF 76 06 0E E8 C6 00 90 59 59 EB 1A FF 76 08 FF 76 06 0E E8 95 00 90 59 59 B8 EC 10 50 C4 5E 06 26 FF 9F F8 00 59 5D CB 55 8B EC B8 24 11 50 C4 5E 06 26 FF 9F F8 00 59 5D CB 55 8B EC B8 37 11 50 C4 5E 06 26 FF 9F F8 00 59 B8 64 11 50 C4 5E 06 26 FF 9F F8 00 59 B8 D5 00 50 C4 5E 06 26 FF 5F 48 59 5D CB 55 8B EC C4 5E 06 26 FF 5F 74 50 C4 5E 06 26 FF 9F 94 00 59 B8 10 27 50 C4 5E 06 26 FF 9F B4 00 59 5D CB 55 8B EC C4 5E 06 26 FF 5F 24 50 C4 5E 06 26 FF 5F 20 50 B8 01 00 50 C4 5E 06 26 FF 5F 30 83 C4 06 5D CB 55 8B EC 33 C0 50 C4 5E 06 26 FF 5F 24 50 C4 5E 06 26 FF 5F 20 50 C4 5E 06 26 FF 5F 2C 83 C4 06 5D CB 55 8B EC B8 01 00 50 C4 5E 06 26 FF 5F 24 50 C4 5E 06 26 FF 5F 20 50 C4 5E 06 26 FF 5F 2C 83 C4 06 5D CB 55 8B EC B8 DC 05 50 33 C0 50 50 50 B8 B6 00 50 B8 C0 00 50 C4 5E 06 26 FF 9F D8 00 83 C4 0C 5D CB 
        }

    }
}
