#pragma warning disable
using System.Collections.Generic;
using XPT.WorldData;
using XPT.WorldData.Yserbius;

namespace XPT.Scripts.Yserbius.Maps {
    class YserMap23 : AMapScripted {
        protected override int MapIndex => 23;
        protected override int RandomEncounterChance => 22;
        protected override int RandomEncounterExtraCount => 2;

        public YserMap23() {
            MapEvent01 = FnCOMNDOOR_01;
            MapEvent02 = FnHUMAN_02;
            MapEvent0A = FnTOCENTER_0A;
            MapEvent0B = FnBABLEMES_0B;
            MapEvent0C = FnTOPRIOR_0C;
            MapEvent0D = FnHUMANNPC_0D;
            MapEvent15 = FnTOELF_15;
            MapEvent1D = FnEOGTELE_1D;
            MapEvent1E = FnSWITCHA_1E;
            MapEvent1F = FnSWITCHB_1F;
            MapEvent20 = FnSWITCHC_20;
            MapEvent21 = FnSWITCHD_21;
            MapEvent22 = FnSWITCHE_22;
            MapEvent23 = FnSWITCHF_23;
            MapEvent24 = FnSWITCHG_24;
            MapEvent25 = FnSWITCHH_25;
            MapEvent26 = FnRESET_26;
            MapEvent27 = FnTNXTLEVL_27;
            MapEvent28 = FnENDMESS_28;
            MapEvent29 = FnTRAPMESS_29;
            MapEvent2A = FnNPCSBATB_2A;
            MapEvent2B = FnNPCSBATC_2B;
            MapEvent2C = FnKAALONE_2C;
            MapEvent2D = FnKAALTWO_2D;
            MapEvent2E = FnMIXEDONE_2E;
            MapEvent2F = FnROOMMES_2F;
            MapEvent30 = FnGOLGAORE_30;
            MapEvent31 = FnROGUEONE_31;
            MapEvent32 = FnROGUETWO_32;
            MapEvent33 = FnROGUETRE_33;
            MapEvent34 = FnROGUEFOR_34;
            MapEvent35 = FnBATSONE_35;
            MapEvent36 = FnCASETRAP_36;
            MapEvent37 = FnBABLBATL_37;
            MapEvent38 = FnEGRESNPC_38;
            MapEvent39 = FnSWTCHNPC_39;
            MapEvent3A = FnFNTHEAL_3A;
            MapEvent3B = FnSETRACE_3B;
            MapEvent3C = FnONEATTIM_3C;
        }
        
        // === Strings ================================================
        private const string String03FC = "'Babble is surely what is to be had if you take the words at face value.";
        private const string String0445 = "You now know the Common tongue.'";
        private const string String0466 = "'The letters are the keys; the switches set the words; you must spell inside the words.";
        private const string String04BE = "You now know Orc.'";
        private const string String04D1 = "'This mountain of lava sets one stage; the other has befriended thee.";
        private const string String0517 = "You are now fluent with the Elven tongue.'";
        private const string String0542 = "'Ignore the last till second; see the second first.";
        private const string String0576 = "You are now the Troll language incarnate.'";
        private const string String05A1 = "'With hallowed halls the dead king lies, his offspring now rules the mount.";
        private const string String05ED = "You now know Dwarf.'";
        private const string String0602 = "'As the last, let the good Queen shine; in a second the lava spouts.";
        private const string String0647 = "You are now able to mumble Halfling.'";
        private const string String066D = "'Read it friend, two names are there if only you can see the clues.";
        private const string String06B1 = "You now know Gnome.'";
        private const string String06C6 = "'The King is dead; long live the Queen!";
        private const string String06EE = "You now speak Gremlin - but only when you must.'";
        private const string String071F = "You must enter the room alone.";
        private const string String073E = "Enter now the legacy of babel's nexus.";
        private const string String0765 = "Back to the upper level.";
        private const string String077E = "A Human is here.";
        private const string String078F = "An Orc is here.";
        private const string String079F = "A Troll is here.";
        private const string String07B0 = "An Elf is here.";
        private const string String07C0 = "A Halfling is here.";
        private const string String07D4 = "A Gremlin is here.";
        private const string String07E7 = "A Dwarf Wizard is here.";
        private const string String07FF = "A Gnome is here.";
        private const string String0810 = "'You know all that you need. Go to the northeast room. Find your fate and unlock the gate.'";
        private const string String086C = "lies the teleport that will take you to the next scholar. Go, it will now be unlocked.'";
        private const string String08C4 = "'I can do nothing more for you. Learn all of the languages; then read the plaques in the northeast.'";
        private const string String0929 = "nemo me impune lacessit";
        private const string String0941 = "fortuna favet fortibus";
        private const string String0958 = "vox populi, vox Dei";
        private const string String096C = "vox et praeterea nihil";
        private const string String0983 = "quem Deus vult perdere, prius dementat";
        private const string String09AA = "lasciate ogni speranza";
        private const string String09C1 = "finis coronat opus";
        private const string String09D4 = "flat justitia, ruat coelum";
        private const string String09EF = "'To the southeast ";
        private const string String0A02 = "'Go to the northeast ";
        private const string String0A18 = "'Somewhere in the center ";
        private const string String0A32 = "'Now, just south of the scholar's rooms ";
        private const string String0A5B = "'One south of where we are ";
        private const string String0A77 = "'At the southern edge ";
        private const string String0A8E = "'In the northwest ";
        private const string String0AA1 = "'In the east ";
        private const string String0AAF = "HUMAN";
        private const string String0AB5 = "GREMLIN";
        private const string String0ABD = "HALFLING";
        private const string String0AC6 = "DWARF";
        private const string String0ACC = "TROLL";
        private const string String0AD2 = "ORC";
        private const string String0AD6 = "GNOME";
        private const string String0ADC = "ELF";
        private const string String0AE0 = "A gateway is here.";
        private const string String0AF3 = "This portal will lead to the name marked upon it. Return once you are told by those that babble in the west.";
        private const string String0B60 = "At present, it will only take you to the heart of this maze.";
        private const string String0B9D = "This wall glows with power, beckoning you to enter.";
        private const string String0BD1 = "Alone! You must use this gateway alone.";
        private const string String0BF9 = "EREBUS";
        private const string String0C00 = "MAGMA";
        private const string String0C06 = "sculpsit";
        private const string String0C0F = "ASP";
        private const string String0C13 = "LONGBOW";
        private const string String0C1B = "tant mieux";
        private const string String0C26 = "ELEMENTAL";
        private const string String0C30 = "ISLAND";
        private const string String0C37 = "obiit";
        private const string String0C3D = "HARMONY";
        private const string String0C45 = "GUILD";
        private const string String0C4B = "peccavi";
        private const string String0C53 = "CHAOTIC";
        private const string String0C5B = "MYTH";
        private const string String0C60 = "l'onconnu";
        private const string String0C6A = "VOLCANO";
        private const string String0C72 = "ABYSS";
        private const string String0C78 = "fiat lux";
        private const string String0C81 = "TWINION";
        private const string String0C89 = "LEGEND";
        private const string String0C90 = "a priori";
        private const string String0C99 = "WIZARD";
        private const string String0CA0 = "PALACE";
        private const string String0CA7 = "ad finem";
        private const string String0CB0 = "-OFF-";
        private const string String0CB6 = "Your experience increases along with your gold and your strength!";
        private const string String0CF8 = "You've set the first word. On to the next. Here's a taste of experience, gold and a little initiative!";
        private const string String0D5F = "You've spelled the words. Now through the exit and onward to your Fate!";
        private const string String0DA7 = "Nothing happens.";
        private const string String0DB8 = "The magical winds sweep you up and pull you down through the opening into Concordia.";
        private const string String0E0D = "You may enter only if alone!";
        private const string String0E2A = "Only alone may you pass through.";
        private const string String0E4B = "You have already solved this puzzle!";
        private const string String0E70 = "Proceed to your exit.";
        private const string String0E86 = "You have proven your knowledge of the major languages. Now read the plaques and set the switches. Then you may proceed.";
        private const string String0EFE = "You need to learn more about languages before you can tackle this puzzle.";
        private const string String0F48 = "'Beware! Beware! The traps here are of fiendish conception! They change whence you step them again although they are the same tile! Beware!'";
        private const string String0FD5 = "Night Elf berserkers scream wildly as they attack.";
        private const string String1008 = "Two Erebus fiends hiss as you approach.";
        private const string String1030 = "Hulking Kaalroths launch a fierce magical attack.";
        private const string String1062 = "'You've slain many of our friends. It is your time now!'";
        private const string String109B = "Wizards and their servants are tending the fallen Golems you killed!";
        private const string String10E0 = "Huge golems lumber forward to block your path.";
        private const string String110F = "The floor here shows traces of recent activity by huge creatures.";
        private const string String1151 = "An eerie sense of magic surrounds you.";
        private const string String1178 = "Something is different! You'd better check this area again.";
        private const string String11B4 = "A horde of Golems stir to life as they sense your approach!";
        private const string String11F0 = "Babbling rogues, driven mad from their quests, see you as their next prey.";
        private const string String123B = "'OUT! Keep out of our domain!'";
        private const string String125A = "A Night Elf warrior holds his forces at the ready.";
        private const string String128D = "'Leave this place and do not return. Abandon your quest for our Dralkarians.";
        private const string String12DA = "This shall be your only warning.'";
        private const string String12FC = "More Night Elves have been called to defend their domain.";
        private const string String1336 = "Babbling creatures begin feuding and draw you into their fray.";
        private const string String1375 = "A slew of bats rush through this hallway.";
        private const string String139F = "You spring a trap laced with poisoned darts.";
        private const string String13CC = "You trigger some mage's trap. A cloud of acid surrounds you!!";
        private const string String140A = "Fireballs slam into you as you set off another fiendish trap.";
        private const string String1448 = "You clumsily set off a gas trap.";
        private const string String1469 = "A fierce whirlwind strikes you from some unseen sorcerer's hand!";
        private const string String14AA = "Well-trained Night Elves guard these corridors.";
        private const string String14DA = "An ancient Knight whispers, 'The leader must be removed to see the summit. And even though the spells of royalty be at the end, they shall be the first.'";
        private const string String1574 = "'The nine switches are used to open the way down to the next area. You must learn which switches to turn on.";
        private const string String15E1 = "Having the nine switches set in unison will unlock the way for you.'";
        private const string String1626 = "The cool waters satisfy and enrich you.";
        private const string String164E = "A maniacal fiend appears; removes an item you stole from him; and kills you outright.";
        private const string String16A4 = "The door glows with a magical force.";
        private const string String16C9 = "You may proceed alone.";
        private const string String16E0 = "You must enter here one at a time.";
        
        // === Functions ================================================
        private void FnCOMNDOOR_01(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0021: SetWallObject(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L003F: return; // RETURN;
        }

        private void FnHUMAN_02(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0047  0003 83 EC 06  sub sp, 0x6
004A  0006 56     push si
004B  0007 57     push di
            L0008: Compare(PartyCount(player), 0x0001);
            L0013: if (JumpEqual) goto L0018;
            L0015: goto L0186;
            L0018: ax = GetCurrentTile(player);
0063  001F 89 46 FA  mov [bp-0x6], ax
0066  0022 89 46 FE  mov [bp-0x2], ax
0069  0025 B9 08 00  mov cx, 0x8
            L0028: bx = 0x01F7;
006F  002B 2E 8B 07  mov ax, [cs:bx]
0072  002E 3B 46 FE  cmp ax, [bp-0x2]
            L0031: if (JumpEqual) goto L003A;
0077  0033 43     inc bx
0078  0034 43     inc bx
0079  0035 E2 F4  loop 0x2b
            L0037: goto L0132;
007E  003A 2E FF 67 10  jmp word [cs:bx+0x10]
0082  003E C7 46 FC 16 00  mov word [bp-0x4], 0x16
            L0043: si = 0x002D;
            L0046: di = 0x002E;
            L0049: ShowMessage(player, String03FC); // 'Babble is surely what is to be had if you take the words at face value.
009A  0056 B8 45 04  mov ax, 0x445
            L0059: goto L0128;
00A0  005C C7 46 FC 1E 00  mov word [bp-0x4], 0x1e
            L0061: si = 0x0029;
            L0064: di = 0x002A;
            L0067: ShowMessage(player, String0466); // 'The letters are the keys; the switches set the words; you must spell inside the words.
00B8  0074 B8 BE 04  mov ax, 0x4be
            L0077: goto L0128;
00BE  007A C7 46 FC 18 00  mov word [bp-0x4], 0x18
            L007F: si = 0x002E;
            L0082: di = 0x0028;
            L0085: ShowMessage(player, String04D1); // 'This mountain of lava sets one stage; the other has befriended thee.
00D6  0092 B8 17 05  mov ax, 0x517
            L0095: goto L0128;
00DC  0098 C7 46 FC 1B 00  mov word [bp-0x4], 0x1b
            L009D: si = 0x002A;
            L00A0: di = 0x002B;
            L00A3: ShowMessage(player, String0542); // 'Ignore the last till second; see the second first.
00F4  00B0 B8 76 05  mov ax, 0x576
            L00B3: goto L0128;
            L00B5: // NOP
00FA  00B6 C7 46 FC 2C 00  mov word [bp-0x4], 0x2c
            L00BB: si = 0x0028;
            L00BE: di = 0x0027;
            L00C1: ShowMessage(player, String05A1); // 'With hallowed halls the dead king lies, his offspring now rules the mount.
0112  00CE B8 ED 05  mov ax, 0x5ed
            L00D1: goto L0128;
0117  00D3 C7 46 FC 1D 00  mov word [bp-0x4], 0x1d
            L00D8: si = 0x002B;
            L00DB: di = 0x002C;
            L00DE: ShowMessage(player, String0602); // 'As the last, let the good Queen shine; in a second the lava spouts.
012F  00EB B8 47 06  mov ax, 0x647
            L00EE: goto L0128;
0134  00F0 C7 46 FC 19 00  mov word [bp-0x4], 0x19
            L00F5: si = 0x0027;
            L00F8: di = 0x0029;
            L00FB: ShowMessage(player, String066D); // 'Read it friend, two names are there if only you can see the clues.
014C  0108 B8 B1 06  mov ax, 0x6b1
            L010B: goto L0128;
0151  010D C7 46 FC 26 00  mov word [bp-0x4], 0x26
            L0112: si = 0x002C;
            L0115: di = 0x002D;
            L0118: ShowMessage(player, String06C6); // 'The King is dead; long live the Queen!
            L0125: ShowMessage(player, String06EE); // You now speak Gremlin - but only when you must.'
0176  0132 FF 76 FC  push word [bp-0x4]
0179  0135 C4 5E 06  les bx, [bp+0x6]
017C  0138 26 FF 9F FC 00  call far word [es:bx+0xfc]
            L013D: cx = PopStack(player);
0182  013E 56     push si
            L013F: PushStack(player, 0x02);
0187  0143 C4 5E 06  les bx, [bp+0x6]
018A  0146 26 FF 5F 04  call far word [es:bx+0x4]
            L014A: cx = PopStack(player);
            L014B: cx = PopStack(player);
            L014C: Compare(ax, 0x0001);
            L014F: if (JumpNotEqual) goto L01AD;
0195  0151 57     push di
            L0152: PushStack(player, 0x02);
019A  0156 C4 5E 06  les bx, [bp+0x6]
019D  0159 26 FF 5F 04  call far word [es:bx+0x4]
            L015D: cx = PopStack(player);
            L015E: cx = PopStack(player);
            L015F: RefreshCompareFlags(ax);
            L0161: if (JumpNotEqual) goto L0175;
            L0163: PushStack(player, 0x01);
01AB  0167 57     push di
            L0168: PushStack(player, 0x02);
01B0  016C C4 5E 06  les bx, [bp+0x6]
01B3  016F 26 FF 1F  call far word [es:bx]
01B6  0172 83 C4 06  add sp, 0x6
            L0175: PushStack(player, 0x02);
01BD  0179 56     push si
            L017A: PushStack(player, ax);
01BF  017B C4 5E 06  les bx, [bp+0x6]
01C2  017E 26 FF 1F  call far word [es:bx]
01C5  0181 83 C4 06  add sp, 0x6
            L0184: goto L01AD;
            L0186: ShowMessage(player, String071F); // You must enter the room alone.
            L0193: TeleportParty(player, 0x0A, 0x01, 0x78, 0x00, isForwardMove);
01F1  01AD 5F     pop di
01F2  01AE 5E     pop si
            L01AF: // restore stack ptr: sp = bp;
            L01B1: return; // RETURN;
            // Extra data: 4A 00 4B 00 5A 00 5B 00 6A 00 6B 00 7A 00 7B 00 82 00 A0 00 BE 00 DC 00 FA 00 17 01 34 01 51 01 
        }

        private void FnTOCENTER_0A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x0A, 0x01, 0x88, 0x02, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnBABLEMES_0B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String073E); // Enter now the legacy of babel's nexus.
            L0010: SetFlag(player, 0x03, 0x1C, 0x01);
            L0025: return; // RETURN;
        }

        private void FnTOPRIOR_0C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0765); // Back to the upper level.
            L0010: TeleportParty(player, 0x09, 0x02, 0x78, 0x00, isForwardMove);
            L002A: return; // RETURN;
        }

        private void FnHUMANNPC_0D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
02B0  0003 83 EC 06  sub sp, 0x6
02B3  0006 56     push si
02B4  0007 57     push di
            L0008: dx = GetFlag(player, 0x02, 0x2E) + GetFlag(player, 0x02, 0x27);
            L002E: dx = dx + GetFlag(player, 0x02, 0x29);
            L0043: dx = dx + GetFlag(player, 0x02, 0x2D);
            L0058: dx = dx + GetFlag(player, 0x02, 0x28);
            L006D: dx = dx + GetFlag(player, 0x02, 0x2B);
            L0082: dx = dx + GetFlag(player, 0x02, 0x2A);
            L0097: dx = dx + GetFlag(player, 0x02, 0x2C);
0359  00AC 89 56 FC  mov [bp-0x4], dx
            L00AF: ax = GetCurrentTile(player);
0363  00B6 89 46 FA  mov [bp-0x6], ax
0366  00B9 B9 08 00  mov cx, 0x8
            L00BC: bx = 0x04B6;
036C  00BF 2E 8B 07  mov ax, [cs:bx]
036F  00C2 3B 46 FA  cmp ax, [bp-0x6]
            L00C5: if (JumpEqual) goto L00CE;
0374  00C7 43     inc bx
0375  00C8 43     inc bx
0376  00C9 E2 F4  loop 0xbf
            L00CB: goto L015B;
037B  00CE 2E FF 67 10  jmp word [cs:bx+0x10]
            L00D2: si = 0x0016;
            L00D5: di = 0x002E;
0385  00D8 C7 46 FE 28 00  mov word [bp-0x2], 0x28
038A  00DD B8 7E 07  mov ax, 0x77e
            L00E0: goto L0151;
            L00E2: // NOP
            L00E3: si = 0x001E;
            L00E6: di = 0x002A;
0396  00E9 C7 46 FE 2B 00  mov word [bp-0x2], 0x2b
039B  00EE B8 8F 07  mov ax, 0x78f
            L00F1: goto L0151;
            L00F3: si = 0x001B;
            L00F6: di = 0x002B;
03A6  00F9 C7 46 FE 2C 00  mov word [bp-0x2], 0x2c
03AB  00FE B8 9F 07  mov ax, 0x79f
            L0101: goto L0151;
            L0103: si = 0x0018;
            L0106: di = 0x0028;
03B6  0109 C7 46 FE 27 00  mov word [bp-0x2], 0x27
03BB  010E B8 B0 07  mov ax, 0x7b0
            L0111: goto L0151;
            L0113: si = 0x001D;
            L0116: di = 0x002C;
03C6  0119 C7 46 FE 2D 00  mov word [bp-0x2], 0x2d
03CB  011E B8 C0 07  mov ax, 0x7c0
            L0121: goto L0151;
            L0123: si = 0x0026;
            L0126: di = 0x002D;
03D6  0129 C7 46 FE 2E 00  mov word [bp-0x2], 0x2e
03DB  012E B8 D4 07  mov ax, 0x7d4
            L0131: goto L0151;
            L0133: si = 0x002C;
            L0136: di = 0x0027;
03E6  0139 C7 46 FE 29 00  mov word [bp-0x2], 0x29
03EB  013E B8 E7 07  mov ax, 0x7e7
            L0141: goto L0151;
            L0143: si = 0x0019;
            L0146: di = 0x0029;
03F6  0149 C7 46 FE 2A 00  mov word [bp-0x2], 0x2a
            L014E: ShowMessage(player, String07FF); // A Gnome is here.
0408  015B 56     push si
0409  015C C4 5E 06  les bx, [bp+0x6]
040C  015F 26 FF 9F FC 00  call far word [es:bx+0xfc]
            L0164: cx = PopStack(player);
0412  0165 83 7E FC 10  cmp word [bp-0x4], 0x10
            L0169: if (JumpNotEqual) goto L0171;
0418  016B B8 10 08  mov ax, 0x810
            L016E: goto L01E9;
            L0170: // NOP
041E  0171 57     push di
            L0172: PushStack(player, 0x02);
0423  0176 C4 5E 06  les bx, [bp+0x6]
0426  0179 26 FF 5F 08  call far word [es:bx+0x8]
            L017D: cx = PopStack(player);
            L017E: cx = PopStack(player);
            L017F: RefreshCompareFlags(ax);
            L0181: if (JumpEqual) goto L01AE;
0430  0183 FF 76 FE  push word [bp-0x2]
            L0186: PushStack(player, 0x02);
0437  018A C4 5E 06  les bx, [bp+0x6]
043A  018D 26 FF 5F 04  call far word [es:bx+0x4]
            L0191: cx = PopStack(player);
            L0192: cx = PopStack(player);
            L0193: RefreshCompareFlags(ax);
            L0195: if (JumpNotEqual) goto L01A9;
0444  0197 FF 76 08  push word [bp+0x8]
0447  019A FF 76 06  push word [bp+0x6]
044A  019D 0E     push cs
044B  019E E8 88 00  call 0x229
            L01A1: // NOP
            L01A2: cx = PopStack(player);
            L01A3: cx = PopStack(player);
0451  01A4 B8 6C 08  mov ax, 0x86c
            L01A7: goto L01E9;
0456  01A9 B8 C4 08  mov ax, 0x8c4
            L01AC: goto L01E9;
            L01AE: bx = GetRace(player);
            L01B7: Compare(bx, 0x07);
            L01BA: if (JumpAbove) goto L01F3;
            L01BC: switch (bx) {
                case 0:
                    goto L01C3;
                case 1:
                    goto L01E1;
                case 2:
                    goto L01C8;
                case 3:
                    goto L01D2;
                case 4:
                    goto L01CD;
                case 5:
                    goto L01D7;
                case 6:
                    goto L01DC;
                case 7:
                    goto L01E6;
                case 8:
                    goto LFFFFFD53;
                case 9:
                    goto LFFFFFD85;
                case 10:
                    goto LFFFFFDA4;
                case 11:
                    goto LFFFFFDA6;
                case 12:
                    goto LFFFFFDB3;
                case 13:
                    goto LFFFFFDD8;
                case 14:
                    goto LFFFFFDE6;
                case 15:
                    goto LFFFFFDF3;
                case 16:
                    goto L00E3;
                case 17:
                    goto L0123;
                case 18:
                    goto L00F3;
                case 19:
                    goto L00D2;
                case 20:
                    goto L0143;
                case 21:
                    goto L0113;
                case 22:
                    goto L0133;
                case 23:
                    goto L0103;
                case 24:
                    goto L88A8;
                case 25:
                    goto L4A3F;
                case 26:
                    goto LC19F;
                case 27:
                    goto L03B1;
                case 28:
                    goto LFC79;
                case 29:
                    goto L1DB2;
                case 30:
                    goto L43DC;
                case 31:
                    goto LB751;
                case 32:
                    goto LFFFFFD5B;
                case 33:
                    goto L2F0E;
                case 34:
                    goto L2B58;
                case 35:
                    goto L04DE;
                case 36:
                    goto L438E;
                case 37:
                    goto L7251;
                case 38:
                    goto L4059;
                case 39:
                    goto LDF96;
                case 40:
                    goto LE947;
                case 41:
                    goto L2B87;
                case 42:
                    goto L6552;
                case 43:
                    goto LB563;
                case 44:
                    goto L0742;
                case 45:
                    goto L1F3E;
                case 46:
                    goto L000B;
                case 47:
                    goto LE85D;
                case 48:
                    goto LB56F;
                case 49:
                    goto L076B;
                case 50:
                    goto L153E;
                case 51:
                    goto L300B;
                case 52:
                    goto LE85D;
                case 53:
                    goto LB565;
                case 54:
                    goto L07AE;
                case 55:
                    goto L0B3E;
                case 56:
                    goto L750B;
                case 57:
                    goto LE85D;
                case 58:
                    goto LB55B;
                case 59:
                    goto L07E1;
                case 60:
                    goto L013E;
                case 61:
                    goto L9F0B;
                case 62:
                    goto L4D5D;
                case 63:
                    goto L5C17;
                case 64:
                    goto L2359;
                case 65:
                    goto L9D52;
                case 66:
                    goto LFFFFFE4B;
                case 67:
                    goto L88AC;
                case 68:
                    goto L5B38;
                case 69:
                    goto LFFFFFE1E;
                case 70:
                    goto L2F53;
                case 71:
                    goto L4E53;
                case 72:
                    goto L5053;
                case 73:
                    goto L5D53;
                case 74:
                    goto L8253;
                case 75:
                    goto L9053;
                case 76:
                    goto L9D53;
                case 77:
                    goto LFFFFFF53;
                case 78:
                    goto L1358;
                case 79:
                    goto L0458;
                case 80:
                    goto LFA58;
                case 81:
                    goto L1D57;
                case 82:
                    goto L0E58;
                case 83:
                    goto L1858;
                case 84:
                    goto L0958;
            }
0470  01C3 B8 29 09  mov ax, 0x929
            L01C6: goto L01E9;
0475  01C8 B8 41 09  mov ax, 0x941
            L01CB: goto L01E9;
047A  01CD B8 58 09  mov ax, 0x958
            L01D0: goto L01E9;
047F  01D2 B8 6C 09  mov ax, 0x96c
            L01D5: goto L01E9;
0484  01D7 B8 83 09  mov ax, 0x983
            L01DA: goto L01E9;
0489  01DC B8 AA 09  mov ax, 0x9aa
            L01DF: goto L01E9;
048E  01E1 B8 C1 09  mov ax, 0x9c1
            L01E4: goto L01E9;
            L01E6: ShowMessage(player, String09D4); // flat justitia, ruat coelum
04A0  01F3 5F     pop di
04A1  01F4 5E     pop si
            L01F5: // restore stack ptr: sp = bp;
            L01F7: return; // RETURN;
        }

        private void FnTOELF_15(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0577  0003 83 EC 08  sub sp, 0x8
057A  0006 56     push si
057B  0007 57     push di
            L0008: ax = GetCurrentTile(player);
0583  000F 89 46 FA  mov [bp-0x6], ax
0586  0012 89 46 F8  mov [bp-0x8], ax
0589  0015 B9 08 00  mov cx, 0x8
            L0018: bx = 0x06CC;
058F  001B 2E 8B 07  mov ax, [cs:bx]
0592  001E 3B 46 F8  cmp ax, [bp-0x8]
            L0021: if (JumpEqual) goto L002A;
0597  0023 43     inc bx
0598  0024 43     inc bx
0599  0025 E2 F4  loop 0x1b
            L0027: goto L00DE;
059E  002A 2E FF 67 10  jmp word [cs:bx+0x10]
            L002E: si = 0x002E;
            L0031: di = 0;
05A7  0033 C7 46 FE 00 00  mov word [bp-0x2], 0x0
05AC  0038 C7 46 FC 5A 00  mov word [bp-0x4], 0x5a
05B1  003D B8 AF 0A  mov ax, 0xaaf
            L0040: goto L00D4;
            L0043: si = 0x002D;
            L0046: di = 0x0001;
05BD  0049 C7 46 FE 00 00  mov word [bp-0x2], 0x0
05C2  004E C7 46 FC 4A 00  mov word [bp-0x4], 0x4a
05C7  0053 B8 B5 0A  mov ax, 0xab5
            L0056: goto L00D4;
            L0058: // NOP
            L0059: si = 0x002C;
            L005C: di = 0x0002;
05D3  005F C7 46 FE 02 00  mov word [bp-0x2], 0x2
05D8  0064 C7 46 FC 7B 00  mov word [bp-0x4], 0x7b
05DD  0069 B8 BD 0A  mov ax, 0xabd
            L006C: goto L00D4;
            L006E: si = 0x0027;
            L0071: di = 0;
05E7  0073 C7 46 FE 00 00  mov word [bp-0x2], 0x0
05EC  0078 C7 46 FC 7A 00  mov word [bp-0x4], 0x7a
05F1  007D B8 C6 0A  mov ax, 0xac6
            L0080: goto L00D4;
            L0082: si = 0x002B;
            L0085: di = 0x0001;
05FC  0088 C7 46 FE 02 00  mov word [bp-0x2], 0x2
0601  008D C7 46 FC 6B 00  mov word [bp-0x4], 0x6b
0606  0092 B8 CC 0A  mov ax, 0xacc
            L0095: goto L00D4;
            L0097: si = 0x002A;
            L009A: di = 0x0003;
0611  009D C7 46 FE 02 00  mov word [bp-0x2], 0x2
0616  00A2 C7 46 FC 5B 00  mov word [bp-0x4], 0x5b
061B  00A7 B8 D2 0A  mov ax, 0xad2
            L00AA: goto L00D4;
            L00AC: si = 0x0029;
            L00AF: di = 0x0003;
0626  00B2 C7 46 FE 02 00  mov word [bp-0x2], 0x2
062B  00B7 C7 46 FC 4B 00  mov word [bp-0x4], 0x4b
0630  00BC B8 D6 0A  mov ax, 0xad6
            L00BF: goto L00D4;
            L00C1: si = 0x0028;
            L00C4: di = 0x0001;
063B  00C7 C7 46 FE 00 00  mov word [bp-0x2], 0x0
0640  00CC C7 46 FC 6A 00  mov word [bp-0x4], 0x6a
            L00D1: ShowMessage(player, String0ADC); // ELF
0652  00DE 56     push si
            L00DF: PushStack(player, 0x02);
0657  00E3 C4 5E 06  les bx, [bp+0x6]
065A  00E6 26 FF 5F 04  call far word [es:bx+0x4]
            L00EA: cx = PopStack(player);
            L00EB: cx = PopStack(player);
            L00EC: Compare(ax, 0x0001);
            L00EF: if (JumpNotEqual) goto L011D;
0665  00F1 57     push di
            L00F2: SetWallObject(player, 0x02, GetCurrentTile(player), PopStack(player));
            L0108: ShowMessage(player, String0AE0); // A gateway is here.
0689  0115 FF 76 FE  push word [bp-0x2]
068C  0118 FF 76 FC  push word [bp-0x4]
            L011B: goto L013F;
            L011D: ShowMessage(player, String0AF3); // This portal will lead to the name marked upon it. Return once you are told by those that babble in the west.
            L012A: ShowMessage(player, String0B60); // At present, it will only take you to the heart of this maze.
            L0137: TeleportParty(player, 0x0A, 0x01, 0x58, 0x03, isForwardMove);
06C6  0152 5F     pop di
06C7  0153 5E     pop si
            L0154: // restore stack ptr: sp = bp;
            L0156: return; // RETURN;
            // Extra data: 1B 00 35 00 5D 00 77 00 8B 00 95 00 EE 00 FA 00 0B 06 E2 05 20 06 F6 05 35 06 CD 05 A2 05 B7 05 
        }

        private void FnEOGTELE_1D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0xDF), 0x0001);
            L0017: if (JumpNotEqual) goto L0082;
            L0019: Compare(PartyCount(player), 0x0001);
            L0024: if (JumpNotEqual) goto L005A;
            L0026: ShowMessage(player, String0B9D); // This wall glows with power, beckoning you to enter.
            L0033: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0051: PushStack(player, 0x03);
0764  0055 B8 16 00  mov ax, 0x16
            L0058: goto L006E;
            L005A: ShowMessage(player, String0BD1); // Alone! You must use this gateway alone.
            L0067: TeleportParty(player, 0x0A, 0x01, 0xB8, 0x02, isForwardMove);
            L0082: return; // RETURN;
        }

        private void FnSWITCHA_1E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: // make space for tmp on stack: sp -= 2
0798  0005 56     push si
0799  0006 57     push di
            L0007: Compare(GetFlag(player, 0x02, 0x2E), 0x0002);
            L001B: if (JumpEqual) goto L0020;
            L001D: goto L00C3;
            L0020: si = GetFlag(player, 0x03, 0x11);
            L0033: Compare(ax, 0x0001);
            L0036: if (JumpEqual) goto L003F;
            L0038: Compare(ax, 0x0002);
            L003B: if (JumpEqual) goto L0059;
            L003D: goto L0072;
            L003F: ShowMessage(player, String0BF9); // EREBUS
            L004C: di = 0x0001;
07E2  004F C7 46 FE 00 00  mov word [bp-0x2], 0x0
            L0054: si = 0x0002;
            L0057: goto L0089;
            L0059: ShowMessage(player, String0C00); // MAGMA
            L0066: di = 0;
07FB  0068 C7 46 FE 01 00  mov word [bp-0x2], 0x1
            L006D: si = 0x0003;
            L0070: goto L0089;
0805  0072 FF 76 08  push word [bp+0x8]
0808  0075 FF 76 06  push word [bp+0x6]
080B  0078 0E     push cs
080C  0079 E8 0E 06  call 0x68a
            L007C: // NOP
            L007D: cx = PopStack(player);
            L007E: cx = PopStack(player);
            L007F: di = 0;
0814  0081 C7 46 FE 00 00  mov word [bp-0x2], 0x0
            L0086: si = 0x0001;
081C  0089 57     push di
            L008A: PushStack(player, 0x04);
            L008E: PushStack(player, 0x03);
0825  0092 C4 5E 06  les bx, [bp+0x6]
0828  0095 26 FF 1F  call far word [es:bx]
082B  0098 83 C4 06  add sp, 0x6
082E  009B FF 76 FE  push word [bp-0x2]
            L009E: PushStack(player, 0x09);
            L00A2: PushStack(player, 0x03);
0839  00A6 C4 5E 06  les bx, [bp+0x6]
083C  00A9 26 FF 1F  call far word [es:bx]
083F  00AC 83 C4 06  add sp, 0x6
            L00AF: SetFlag(player, 0xC4, 0xB8, si);
            L00C1: goto L00D0;
            L00C3: ShowMessage(player, String0C06); // sculpsit
0863  00D0 5F     pop di
0864  00D1 5E     pop si
            L00D2: // restore stack ptr: sp = bp;
            L00D4: return; // RETURN;
        }

        private void FnSWITCHB_1F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: // make space for tmp on stack: sp -= 2
086E  0005 56     push si
086F  0006 57     push di
            L0007: Compare(GetFlag(player, 0x02, 0x2C), 0x0002);
            L001B: if (JumpEqual) goto L0020;
            L001D: goto L00BE;
            L0020: si = GetFlag(player, 0x03, 0x12);
            L0033: Compare(ax, 0x0001);
            L0036: if (JumpEqual) goto L003F;
            L0038: Compare(ax, 0x0002);
            L003B: if (JumpEqual) goto L0057;
            L003D: goto L006D;
            L003F: ShowMessage(player, String0C0F); // ASP
            L004C: di = 0x0001;
08B8  004F C7 46 FE 00 00  mov word [bp-0x2], 0x0
            L0054: si = si + 1;
            L0055: goto L0084;
            L0057: ShowMessage(player, String0C13); // LONGBOW
            L0064: di = 0;
08CF  0066 C7 46 FE 01 00  mov word [bp-0x2], 0x1
            L006B: goto L0054;
08D6  006D FF 76 08  push word [bp+0x8]
08D9  0070 FF 76 06  push word [bp+0x6]
08DC  0073 0E     push cs
08DD  0074 E8 3D 05  call 0x5b4
            L0077: // NOP
            L0078: cx = PopStack(player);
            L0079: cx = PopStack(player);
            L007A: di = 0;
08E5  007C C7 46 FE 00 00  mov word [bp-0x2], 0x0
            L0081: si = 0x0001;
08ED  0084 57     push di
            L0085: PushStack(player, 0x08);
            L0089: PushStack(player, 0x03);
08F6  008D C4 5E 06  les bx, [bp+0x6]
08F9  0090 26 FF 1F  call far word [es:bx]
08FC  0093 83 C4 06  add sp, 0x6
08FF  0096 FF 76 FE  push word [bp-0x2]
            L0099: PushStack(player, 0x0C);
            L009D: PushStack(player, 0x03);
090A  00A1 C4 5E 06  les bx, [bp+0x6]
090D  00A4 26 FF 1F  call far word [es:bx]
0910  00A7 83 C4 06  add sp, 0x6
            L00AA: SetFlag(player, 0xC4, 0xB8, si);
            L00BC: goto L00CB;
            L00BE: ShowMessage(player, String0C1B); // tant mieux
0934  00CB 5F     pop di
0935  00CC 5E     pop si
            L00CD: // restore stack ptr: sp = bp;
            L00CF: return; // RETURN;
        }

        private void FnSWITCHC_20(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: // make space for tmp on stack: sp -= 2
093F  0005 56     push si
0940  0006 57     push di
            L0007: Compare(GetFlag(player, 0x02, 0x27), 0x0002);
            L001B: if (JumpEqual) goto L0020;
            L001D: goto L00BE;
            L0020: si = GetFlag(player, 0x03, 0x13);
            L0033: Compare(ax, 0x0001);
            L0036: if (JumpEqual) goto L003F;
            L0038: Compare(ax, 0x0002);
            L003B: if (JumpEqual) goto L0057;
            L003D: goto L006D;
            L003F: ShowMessage(player, String0C26); // ELEMENTAL
            L004C: di = 0x0001;
0989  004F C7 46 FE 00 00  mov word [bp-0x2], 0x0
            L0054: si = si + 1;
            L0055: goto L0084;
            L0057: ShowMessage(player, String0C30); // ISLAND
            L0064: di = 0;
09A0  0066 C7 46 FE 01 00  mov word [bp-0x2], 0x1
            L006B: goto L0054;
09A7  006D FF 76 08  push word [bp+0x8]
09AA  0070 FF 76 06  push word [bp+0x6]
09AD  0073 0E     push cs
09AE  0074 E8 6C 04  call 0x4e3
            L0077: // NOP
            L0078: cx = PopStack(player);
            L0079: cx = PopStack(player);
            L007A: di = 0;
09B6  007C C7 46 FE 00 00  mov word [bp-0x2], 0x0
            L0081: si = 0x0001;
09BE  0084 57     push di
            L0085: PushStack(player, 0x10);
            L0089: PushStack(player, 0x03);
09C7  008D C4 5E 06  les bx, [bp+0x6]
09CA  0090 26 FF 1F  call far word [es:bx]
09CD  0093 83 C4 06  add sp, 0x6
09D0  0096 FF 76 FE  push word [bp-0x2]
            L0099: PushStack(player, 0x02);
            L009D: PushStack(player, 0x03);
09DB  00A1 C4 5E 06  les bx, [bp+0x6]
09DE  00A4 26 FF 1F  call far word [es:bx]
09E1  00A7 83 C4 06  add sp, 0x6
            L00AA: SetFlag(player, 0xC4, 0xB8, si);
            L00BC: goto L00CB;
            L00BE: ShowMessage(player, String0C37); // obiit
0A05  00CB 5F     pop di
0A06  00CC 5E     pop si
            L00CD: // restore stack ptr: sp = bp;
            L00CF: return; // RETURN;
        }

        private void FnSWITCHD_21(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: // make space for tmp on stack: sp -= 2
0A10  0005 56     push si
0A11  0006 57     push di
            L0007: Compare(GetFlag(player, 0x02, 0x29), 0x0002);
            L001B: if (JumpEqual) goto L0020;
            L001D: goto L00BE;
            L0020: si = GetFlag(player, 0x03, 0x14);
            L0033: Compare(ax, 0x0001);
            L0036: if (JumpEqual) goto L003F;
            L0038: Compare(ax, 0x0002);
            L003B: if (JumpEqual) goto L0057;
            L003D: goto L006D;
            L003F: ShowMessage(player, String0C3D); // HARMONY
            L004C: di = 0x0001;
0A5A  004F C7 46 FE 00 00  mov word [bp-0x2], 0x0
            L0054: si = si + 1;
            L0055: goto L0084;
            L0057: ShowMessage(player, String0C45); // GUILD
            L0064: di = 0;
0A71  0066 C7 46 FE 01 00  mov word [bp-0x2], 0x1
            L006B: goto L0054;
0A78  006D FF 76 08  push word [bp+0x8]
0A7B  0070 FF 76 06  push word [bp+0x6]
0A7E  0073 0E     push cs
0A7F  0074 E8 9B 03  call 0x412
            L0077: // NOP
            L0078: cx = PopStack(player);
            L0079: cx = PopStack(player);
            L007A: di = 0;
0A87  007C C7 46 FE 00 00  mov word [bp-0x2], 0x0
            L0081: si = 0x0001;
0A8F  0084 57     push di
            L0085: PushStack(player, 0x0D);
            L0089: PushStack(player, 0x03);
0A98  008D C4 5E 06  les bx, [bp+0x6]
0A9B  0090 26 FF 1F  call far word [es:bx]
0A9E  0093 83 C4 06  add sp, 0x6
0AA1  0096 FF 76 FE  push word [bp-0x2]
            L0099: PushStack(player, 0x07);
            L009D: PushStack(player, 0x03);
0AAC  00A1 C4 5E 06  les bx, [bp+0x6]
0AAF  00A4 26 FF 1F  call far word [es:bx]
0AB2  00A7 83 C4 06  add sp, 0x6
            L00AA: SetFlag(player, 0xC4, 0xB8, si);
            L00BC: goto L00CB;
            L00BE: ShowMessage(player, String0C4B); // peccavi
0AD6  00CB 5F     pop di
0AD7  00CC 5E     pop si
            L00CD: // restore stack ptr: sp = bp;
            L00CF: return; // RETURN;
        }

        private void FnSWITCHE_22(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: // make space for tmp on stack: sp -= 2
0AE1  0005 56     push si
0AE2  0006 57     push di
            L0007: Compare(GetFlag(player, 0x02, 0x2D), 0x0002);
            L001B: if (JumpEqual) goto L0020;
            L001D: goto L00BE;
            L0020: si = GetFlag(player, 0x03, 0x15);
            L0033: Compare(ax, 0x0001);
            L0036: if (JumpEqual) goto L003F;
            L0038: Compare(ax, 0x0002);
            L003B: if (JumpEqual) goto L0057;
            L003D: goto L006D;
            L003F: ShowMessage(player, String0C53); // CHAOTIC
            L004C: di = 0x0001;
0B2B  004F C7 46 FE 00 00  mov word [bp-0x2], 0x0
            L0054: si = si + 1;
            L0055: goto L0084;
            L0057: ShowMessage(player, String0C5B); // MYTH
            L0064: di = 0;
0B42  0066 C7 46 FE 01 00  mov word [bp-0x2], 0x1
            L006B: goto L0054;
0B49  006D FF 76 08  push word [bp+0x8]
0B4C  0070 FF 76 06  push word [bp+0x6]
0B4F  0073 0E     push cs
0B50  0074 E8 CA 02  call 0x341
            L0077: // NOP
            L0078: cx = PopStack(player);
            L0079: cx = PopStack(player);
            L007A: di = 0;
0B58  007C C7 46 FE 00 00  mov word [bp-0x2], 0x0
            L0081: si = 0x0001;
0B60  0084 57     push di
            L0085: PushStack(player, 0x0F);
            L0089: PushStack(player, 0x03);
0B69  008D C4 5E 06  les bx, [bp+0x6]
0B6C  0090 26 FF 1F  call far word [es:bx]
0B6F  0093 83 C4 06  add sp, 0x6
0B72  0096 FF 76 FE  push word [bp-0x2]
            L0099: PushStack(player, 0x01);
            L009D: PushStack(player, 0x03);
0B7D  00A1 C4 5E 06  les bx, [bp+0x6]
0B80  00A4 26 FF 1F  call far word [es:bx]
0B83  00A7 83 C4 06  add sp, 0x6
            L00AA: SetFlag(player, 0xC4, 0xB8, si);
            L00BC: goto L00CB;
            L00BE: ShowMessage(player, String0C60); // l'onconnu
0BA7  00CB 5F     pop di
0BA8  00CC 5E     pop si
            L00CD: // restore stack ptr: sp = bp;
            L00CF: return; // RETURN;
        }

        private void FnSWITCHF_23(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: // make space for tmp on stack: sp -= 2
0BB2  0005 56     push si
0BB3  0006 57     push di
            L0007: Compare(GetFlag(player, 0x02, 0x2A), 0x0002);
            L001B: if (JumpEqual) goto L0020;
            L001D: goto L00BE;
            L0020: si = GetFlag(player, 0x03, 0x16);
            L0033: Compare(ax, 0x0001);
            L0036: if (JumpEqual) goto L003F;
            L0038: Compare(ax, 0x0002);
            L003B: if (JumpEqual) goto L0057;
            L003D: goto L006D;
            L003F: ShowMessage(player, String0C6A); // VOLCANO
            L004C: di = 0x0001;
0BFC  004F C7 46 FE 00 00  mov word [bp-0x2], 0x0
            L0054: si = si + 1;
            L0055: goto L0084;
            L0057: ShowMessage(player, String0C72); // ABYSS
            L0064: di = 0;
0C13  0066 C7 46 FE 01 00  mov word [bp-0x2], 0x1
            L006B: goto L0054;
0C1A  006D FF 76 08  push word [bp+0x8]
0C1D  0070 FF 76 06  push word [bp+0x6]
0C20  0073 0E     push cs
0C21  0074 E8 F9 01  call 0x270
            L0077: // NOP
            L0078: cx = PopStack(player);
            L0079: cx = PopStack(player);
            L007A: di = 0;
0C29  007C C7 46 FE 00 00  mov word [bp-0x2], 0x0
            L0081: si = 0x0001;
0C31  0084 57     push di
            L0085: PushStack(player, 0x0B);
            L0089: PushStack(player, 0x03);
0C3A  008D C4 5E 06  les bx, [bp+0x6]
0C3D  0090 26 FF 1F  call far word [es:bx]
0C40  0093 83 C4 06  add sp, 0x6
0C43  0096 FF 76 FE  push word [bp-0x2]
            L0099: PushStack(player, 0x05);
            L009D: PushStack(player, 0x03);
0C4E  00A1 C4 5E 06  les bx, [bp+0x6]
0C51  00A4 26 FF 1F  call far word [es:bx]
0C54  00A7 83 C4 06  add sp, 0x6
            L00AA: SetFlag(player, 0xC4, 0xB8, si);
            L00BC: goto L00CB;
            L00BE: ShowMessage(player, String0C78); // fiat lux
0C78  00CB 5F     pop di
0C79  00CC 5E     pop si
            L00CD: // restore stack ptr: sp = bp;
            L00CF: return; // RETURN;
        }

        private void FnSWITCHG_24(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: // make space for tmp on stack: sp -= 2
0C83  0005 56     push si
0C84  0006 57     push di
            L0007: Compare(GetFlag(player, 0x02, 0x2B), 0x0002);
            L001B: if (JumpEqual) goto L0020;
            L001D: goto L00BB;
            L0020: si = GetFlag(player, 0x03, 0x17);
            L0033: Compare(ax, 0x0001);
            L0036: if (JumpEqual) goto L003F;
            L0038: Compare(ax, 0x0002);
            L003B: if (JumpEqual) goto L0057;
            L003D: goto L006D;
            L003F: ShowMessage(player, String0C81); // TWINION
            L004C: di = 0x0001;
0CCD  004F C7 46 FE 00 00  mov word [bp-0x2], 0x0
            L0054: si = si + 1;
            L0055: goto L0084;
            L0057: ShowMessage(player, String0C89); // LEGEND
            L0064: di = 0;
0CE4  0066 C7 46 FE 01 00  mov word [bp-0x2], 0x1
            L006B: goto L0054;
0CEB  006D FF 76 08  push word [bp+0x8]
0CEE  0070 FF 76 06  push word [bp+0x6]
0CF1  0073 0E     push cs
0CF2  0074 E8 28 01  call 0x19f
            L0077: // NOP
            L0078: cx = PopStack(player);
            L0079: cx = PopStack(player);
            L007A: di = 0;
0CFA  007C C7 46 FE 00 00  mov word [bp-0x2], 0x0
            L0081: si = 0x0001;
0D02  0084 57     push di
            L0085: PushStack(player, 0x0E);
            L0089: PushStack(player, 0x03);
0D0B  008D C4 5E 06  les bx, [bp+0x6]
0D0E  0090 26 FF 1F  call far word [es:bx]
0D11  0093 83 C4 06  add sp, 0x6
0D14  0096 FF 76 FE  push word [bp-0x2]
            L0099: PushStack(player, 0x03);
            L009D: PushStack(player, ax);
0D1C  009E C4 5E 06  les bx, [bp+0x6]
0D1F  00A1 26 FF 1F  call far word [es:bx]
0D22  00A4 83 C4 06  add sp, 0x6
            L00A7: SetFlag(player, 0xC4, 0xB8, si);
            L00B9: goto L00C8;
            L00BB: ShowMessage(player, String0C90); // a priori
0D46  00C8 5F     pop di
0D47  00C9 5E     pop si
            L00CA: // restore stack ptr: sp = bp;
            L00CC: return; // RETURN;
        }

        private void FnSWITCHH_25(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: // make space for tmp on stack: sp -= 2
0D51  0005 56     push si
0D52  0006 57     push di
            L0007: Compare(GetFlag(player, 0x02, 0x28), 0x0002);
            L001B: if (JumpEqual) goto L0020;
            L001D: goto L00BE;
            L0020: si = GetFlag(player, 0x03, 0x18);
            L0033: Compare(ax, 0x0001);
            L0036: if (JumpEqual) goto L003F;
            L0038: Compare(ax, 0x0002);
            L003B: if (JumpEqual) goto L0057;
            L003D: goto L006D;
            L003F: ShowMessage(player, String0C99); // WIZARD
            L004C: di = 0x0001;
0D9B  004F C7 46 FE 00 00  mov word [bp-0x2], 0x0
            L0054: si = si + 1;
            L0055: goto L0084;
            L0057: ShowMessage(player, String0CA0); // PALACE
            L0064: di = 0;
0DB2  0066 C7 46 FE 01 00  mov word [bp-0x2], 0x1
            L006B: goto L0054;
0DB9  006D FF 76 08  push word [bp+0x8]
0DBC  0070 FF 76 06  push word [bp+0x6]
0DBF  0073 0E     push cs
0DC0  0074 E8 5A 00  call 0xd1
            L0077: // NOP
            L0078: cx = PopStack(player);
            L0079: cx = PopStack(player);
            L007A: di = 0;
0DC8  007C C7 46 FE 00 00  mov word [bp-0x2], 0x0
            L0081: si = 0x0001;
0DD0  0084 57     push di
            L0085: PushStack(player, 0x06);
            L0089: PushStack(player, 0x03);
0DD9  008D C4 5E 06  les bx, [bp+0x6]
0DDC  0090 26 FF 1F  call far word [es:bx]
0DDF  0093 83 C4 06  add sp, 0x6
0DE2  0096 FF 76 FE  push word [bp-0x2]
            L0099: PushStack(player, 0x0A);
            L009D: PushStack(player, 0x03);
0DED  00A1 C4 5E 06  les bx, [bp+0x6]
0DF0  00A4 26 FF 1F  call far word [es:bx]
0DF3  00A7 83 C4 06  add sp, 0x6
            L00AA: SetFlag(player, 0xC4, 0xB8, si);
            L00BC: goto L00CB;
            L00BE: ShowMessage(player, String0CA7); // ad finem
0E17  00CB 5F     pop di
0E18  00CC 5E     pop si
            L00CD: // restore stack ptr: sp = bp;
            L00CF: return; // RETURN;
            // Extra data: 55 8B EC B8 B0 0C 50 C4 5E 06 26 FF 9F F8 00 59 5D CB 
        }

        private void FnRESET_26(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0E32  0003 83 EC 04  sub sp, 0x4
0E35  0006 56     push si
0E36  0007 57     push di
            L0008: RefreshCompareFlags(GetFlag(player, 0x02, 0xC8));
            L001B: if (JumpEqual) goto L0020;
            L001D: goto L02C8;
            L0020: ax = GetFlag(player, 0x02, 0xC7);
0E60  0031 8B F8  mov di, ax
0E62  0033 0B FF  or di, di
            L0035: if (JumpNotEqual) goto L003A;
            L0037: di = 0x0001;
0E69  003A 8B C7  mov ax, di
            L003C: Compare(ax, 0x0001);
            L003F: if (JumpNotEqual) goto L0044;
            L0041: goto L01C4;
            L0044: Compare(ax, 0x0002);
            L0047: if (JumpEqual) goto L004C;
            L0049: goto L02D5;
            L004C: dx = GetFlag(player, 0x03, 0x10) + GetFlag(player, 0x03, 0x0F);
            L0072: dx = dx + GetFlag(player, 0x03, 0x09);
            L0087: dx = dx + GetFlag(player, 0x03, 0x0A);
            L009C: dx = dx + GetFlag(player, 0x03, 0x0B);
            L00B1: dx = dx + GetFlag(player, 0x03, 0x0C);
            L00C6: dx = dx + GetFlag(player, 0x03, 0x0D);
            L00DB: dx = dx + GetFlag(player, 0x03, 0x0E);
0F1F  00F0 89 56 FC  mov [bp-0x4], dx
0F22  00F3 83 7E FC 06  cmp word [bp-0x4], 0x6
            L00F7: if (JumpEqual) goto L00FC;
            L00F9: goto L01B6;
            L00FC: ShowMessage(player, String0CB6); // Your experience increases along with your gold and your strength!
0F38  0109 B8 03 00  mov ax, 0x3
0F3B  010C BA 90 D0  mov dx, 0xd090
            L010F: PushStack(player, ax);
            L0110: PushStack(player, dx);
0F40  0111 C4 5E 06  les bx, [bp+0x6]
0F43  0114 26 FF 9F AC 00  call far word [es:bx+0xac]
            L0119: cx = PopStack(player);
            L011A: cx = PopStack(player);
            L011B: ModifyAttribute(player, 0x00, 0x0003);
            L012C: AddExperience(player, 0x000B71B0);
            L013E: SetFlag(player, 0x02, 0xC7, 0x03);
            L0153: SetFlag(player, 0x02, 0xC8, 0x01);
            L0168: SetFloorObject(player, 0x01, 0x0B);
            L0179: si = 0x0027;
            L017C: goto L0191;
            L017E: PushStack(player, 0x04);
0FB1  0182 56     push si
            L0183: PushStack(player, 0x02);
0FB6  0187 C4 5E 06  les bx, [bp+0x6]
0FB9  018A 26 FF 1F  call far word [es:bx]
0FBC  018D 83 C4 06  add sp, 0x6
            L0190: si = si + 1;
            L0191: Compare(si, 0x2E);
            L0194: if (JumpLessOrEqual) goto L017E;
            L0196: si = 0x0017;
            L0199: goto L01AE;
            L019B: PushStack(player, 0x01);
0FCE  019F 56     push si
            L01A0: SetWallObject(player, 0x00, PopStack(player), PopStack(player));
            L01AD: si = si + 1;
            L01AE: Compare(si, 0x1F);
            L01B1: if (JumpLessOrEqual) goto L019B;
            L01B3: goto L02C8;
0FE5  01B6 FF 76 08  push word [bp+0x8]
0FE8  01B9 FF 76 06  push word [bp+0x6]
0FEB  01BC 0E     push cs
0FEC  01BD E8 2D 01  call 0x2ed
            L01C0: // NOP
            L01C1: goto L02D3;
            L01C4: dx = GetFlag(player, 0x03, 0x01) + GetFlag(player, 0x03, 0x02);
            L01EA: PushStack(player, dx);
            L01EB: PushStack(player, 0x03);
            L01EF: PushStack(player, ax);
101F  01F0 C4 5E 06  les bx, [bp+0x6]
1022  01F3 26 FF 5F 04  call far word [es:bx+0x4]
            L01F7: cx = PopStack(player);
            L01F8: cx = PopStack(player);
            L01F9: dx = PopStack(player);
            L01FA: dx = dx + ax;
            L01FC: dx = dx + GetFlag(player, 0x03, 0x04);
            L0211: dx = dx + GetFlag(player, 0x03, 0x05);
            L0226: dx = dx + GetFlag(player, 0x03, 0x06);
            L023B: dx = dx + GetFlag(player, 0x03, 0x07);
            L0250: dx = dx + GetFlag(player, 0x03, 0x08);
            L0265: tmp = dx;
            L0268: Compare(tmp, 0xFE);
            L026C: if (JumpNotEqual) goto L02C5;
            L026E: ShowMessage(player, String0CF8); // You've set the first word. On to the next. Here's a taste of experience, gold and a little initiative!
            L027B: PushStack(player, 0x03);
            L027F: PushStack(player, ax);
10AF  0280 C4 5E 06  les bx, [bp+0x6]
10B2  0283 26 FF 9F A8 00  call far word [es:bx+0xa8]
            L0288: cx = PopStack(player);
            L0289: cx = PopStack(player);
10B9  028A B8 02 00  mov ax, 0x2
10BC  028D BA 98 AB  mov dx, 0xab98
            L0290: PushStack(player, ax);
            L0291: PushStack(player, dx);
10C1  0292 C4 5E 06  les bx, [bp+0x6]
10C4  0295 26 FF 9F AC 00  call far word [es:bx+0xac]
            L029A: cx = PopStack(player);
            L029B: cx = PopStack(player);
            L029C: AddExperience(player, 0x000AAE60);
            L02AE: SetFlag(player, 0x02, 0xC7, 0x02);
            L02C3: goto L02D5;
            L02C5: goto L01B6;
10F7  02C8 FF 76 08  push word [bp+0x8]
10FA  02CB FF 76 06  push word [bp+0x6]
10FD  02CE 0E     push cs
10FE  02CF E8 09 00  call 0x2db
            L02D2: // NOP
            L02D3: cx = PopStack(player);
            L02D4: cx = PopStack(player);
1104  02D5 5F     pop di
1105  02D6 5E     pop si
            L02D7: // restore stack ptr: sp = bp;
            L02D9: return; // RETURN;
            // Extra data: 55 8B EC B8 5F 0D 50 C4 5E 06 26 FF 9F F8 00 59 5D CB 55 8B EC B8 A7 0D 50 C4 5E 06 26 FF 9F F8 00 59 5D CB 
        }

        private void FnTNXTLEVL_27(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0xC8), 0x0001);
            L0017: if (JumpNotEqual) goto L005F;
            L0019: Compare(PartyCount(player), 0x0001);
            L0024: if (JumpNotEqual) goto L0050;
            L0026: ShowMessage(player, String0DB8); // The magical winds sweep you up and pull you down through the opening into Concordia.
            L0033: TeleportParty(player, 0x0A, 0x02, 0xE1, 0x02, isForwardMove);
            L004E: goto L006F;
            L0050: ShowMessage(player, String0E0D); // You may enter only if alone!
            L005D: goto L005F;
            L005F: SetFloorObject(player, 0x00, 0x0B);
            L006F: return; // RETURN;
        }

        private void FnENDMESS_28(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: // make space for tmp on stack: sp -= 2
11A4  0005 56     push si
            L0006: RefreshCompareFlags(GetFlag(player, 0x02, 0x26));
            L0019: if (JumpEqual) goto L001E;
            L001B: goto L01B6;
            L001E: Compare(PartyCount(player), 0x0001);
            L0029: if (JumpEqual) goto L0056;
            L002B: ShowMessage(player, String0E2A); // Only alone may you pass through.
            L0038: TeleportParty(player, 0x0A, 0x01, 0x06, 0x02, isForwardMove);
            L0053: goto L01B6;
            L0056: Compare(GetFlag(player, 0x02, 0xC8), 0x0001);
            L006A: if (JumpNotEqual) goto L00B7;
            L006C: ShowMessage(player, String0E4B); // You have already solved this puzzle!
            L0079: ShowMessage(player, String0E70); // Proceed to your exit.
            L0086: SetFloorObject(player, 0x01, 0x0B);
            L0097: si = 0x0017;
            L009A: goto L00AF;
            L009C: PushStack(player, 0x01);
123F  00A0 56     push si
            L00A1: SetWallObject(player, 0x00, PopStack(player), PopStack(player));
            L00AE: si = si + 1;
            L00AF: Compare(si, 0x1F);
            L00B2: if (JumpLessOrEqual) goto L009C;
            L00B4: goto L01B6;
            L00B7: dx = GetFlag(player, 0x02, 0x2E) + GetFlag(player, 0x02, 0x29);
            L00DD: dx = dx + GetFlag(player, 0x02, 0x2C);
            L00F2: dx = dx + GetFlag(player, 0x02, 0x2B);
            L0107: dx = dx + GetFlag(player, 0x02, 0x2A);
            L011C: dx = dx + GetFlag(player, 0x02, 0x2D);
            L0131: dx = dx + GetFlag(player, 0x02, 0x28);
            L0146: dx = dx + GetFlag(player, 0x02, 0x27);
            L015B: tmp = dx;
            L015E: Compare(tmp, 0xFE);
            L0162: if (JumpEqual) goto L017A;
            L0164: Compare(GetFlag(player, 0x02, 0x26), 0x0001);
            L0178: if (JumpNotEqual) goto L01A9;
            L017A: RefreshCompareFlags(GetFlag(player, 0x02, 0x26));
            L018D: if (JumpNotEqual) goto L01A4;
            L018F: SetFlag(player, 0x02, 0x26, 0x01);
1343  01A4 B8 86 0E  mov ax, 0xe86
            L01A7: goto L01AC;
            L01A9: ShowMessage(player, String0EFE); // You need to learn more about languages before you can tackle this puzzle.
1355  01B6 5E     pop si
            L01B7: // restore stack ptr: sp = bp;
            L01B9: return; // RETURN;
        }

        private void FnTRAPMESS_29(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x1D));
            L0016: if (JumpNotEqual) goto L0047;
            L0018: ShowPortrait(player, 0x000B);
            L0025: ShowMessage(player, String0F48); // 'Beware! Beware! The traps here are of fiendish conception! They change whence you step them again although they are the same tile! Beware!'
            L0032: SetFlag(player, 0x03, 0x1D, 0x01);
            L0047: return; // RETURN;
        }

        private void FnNPCSBATB_2A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si, di);
            L0005: di = 0;
            L0007: ax = CheckLevel(player, 0x0023);
            L0015: if (JumpEqual) goto L001A;
            L0017: di = 0x0001;
            L001A: ShowMessage(player, String0FD5); // Night Elf berserkers scream wildly as they attack.
            L0027: ax = HasItem(player, 0x0C);
            L0035: if (JumpEqual) goto L0049;
13DA  0037 B8 E8 03  mov ax, 0x3e8
            L003A: PushStack(player, ax);
            L003B: PushStack(player, 0x00);
            L003E: PushStack(player, ax);
            L003F: PushStack(player, ax);
            L0040: PushStack(player, 0x6C);
13E7  0044 B8 B6 00  mov ax, 0xb6
            L0047: goto L0056;
13EC  0049 B8 DC 05  mov ax, 0x5dc
            L004C: PushStack(player, ax);
            L004D: PushStack(player, 0x00);
            L0050: PushStack(player, ax);
            L0051: PushStack(player, ax);
            L0052: PushStack(player, ax);
            L0053: PushStack(player, 0x0C);
13FA  0057 C4 5E 06  les bx, [bp+0x6]
13FD  005A 26 FF 9F D8 00  call far word [es:bx+0xd8]
1402  005F 83 C4 0C  add sp, 0xc
1405  0062 8B C7  mov ax, di
            L0064: Compare(ax, 0x0001);
            L0067: if (JumpEqual) goto L006B;
            L0069: goto L00A1;
            L006B: si = 0x0001;
            L006E: goto L0080;
            L0070: AddEncounter(player, si, 0x24);
            L007F: si = si + 1;
            L0080: Compare(si, 0x02);
            L0083: if (JumpLessOrEqual) goto L0070;
            L0085: si = 0x0005;
            L0088: goto L009A;
            L008A: AddEncounter(player, si, 0x25);
            L0099: si = si + 1;
            L009A: Compare(si, 0x06);
            L009D: if (JumpLessOrEqual) goto L008A;
            L009F: goto L00D5;
            L00A1: si = 0x0001;
            L00A4: goto L00B6;
            L00A6: AddEncounter(player, si, 0x24);
            L00B5: si = si + 1;
            L00B6: Compare(si, 0x02);
            L00B9: if (JumpLessOrEqual) goto L00A6;
            L00BB: si = 0x0005;
            L00BE: goto L00D0;
            L00C0: AddEncounter(player, si, 0x25);
            L00CF: si = si + 1;
            L00D0: Compare(si, 0x06);
            L00D3: if (JumpLessOrEqual) goto L00C0;
            L00D5: return; // RETURN (restoring si, di);
        }

        private void FnNPCSBATC_2B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: RefreshCompareFlags(GetFlag(player, 0x03, 0x1C));
            L0017: if (JumpNotEqual) goto L0040;
            L0019: ShowMessage(player, String1008); // Two Erebus fiends hiss as you approach.
            L0026: si = 0x0001;
            L0029: goto L003B;
            L002B: AddEncounter(player, si, 0x28);
            L003A: si = si + 1;
            L003B: Compare(si, 0x02);
            L003E: if (JumpLessOrEqual) goto L002B;
            L0040: return; // RETURN (restoring si);
        }

        private void FnKAALONE_2C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: ShowMessage(player, String1030); // Hulking Kaalroths launch a fierce magical attack.
            L0011: Compare(PartyCount(player), 0x0001);
            L001C: if (JumpEqual) goto L0025;
            L001E: Compare(ax, 0x0002);
            L0021: if (JumpEqual) goto L0041;
            L0023: goto L005D;
            L0025: si = 0x0001;
            L0028: goto L003A;
            L002A: AddEncounter(player, si, 0x1C);
            L0039: si = si + 1;
            L003A: Compare(si, 0x02);
            L003D: if (JumpLessOrEqual) goto L002A;
            L003F: goto L0091;
            L0041: si = 0x0001;
            L0044: goto L0056;
            L0046: AddEncounter(player, si, 0x1C);
            L0055: si = si + 1;
            L0056: Compare(si, 0x03);
            L0059: if (JumpLessOrEqual) goto L0046;
            L005B: goto L0091;
            L005D: si = 0x0001;
            L0060: goto L0072;
            L0062: AddEncounter(player, si, 0x1C);
            L0071: si = si + 1;
            L0072: Compare(si, 0x04);
            L0075: if (JumpLessOrEqual) goto L0062;
            L0077: si = 0x0005;
            L007A: goto L008C;
            L007C: AddEncounter(player, si, 0x1D);
            L008B: si = si + 1;
            L008C: Compare(si, 0x06);
            L008F: if (JumpLessOrEqual) goto L007C;
            L0091: return; // RETURN (restoring si);
        }

        private void FnKAALTWO_2D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: ShowMessage(player, String1062); // 'You've slain many of our friends. It is your time now!'
            L0011: si = 0x0001;
            L0014: goto L0026;
            L0016: AddEncounter(player, si, 0x1A);
            L0025: si = si + 1;
            L0026: Compare(si, 0x02);
            L0029: if (JumpLessOrEqual) goto L0016;
            L002B: return; // RETURN (restoring si);
        }

        private void FnMIXEDONE_2E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: Compare(GetFlag(player, 0x03, 0x1A), 0x0002);
            L0018: if (JumpEqual) goto L001D;
            L001A: goto L00D6;
            L001D: ShowMessage(player, String109B); // Wizards and their servants are tending the fallen Golems you killed!
            L002A: Compare(PartyCount(player), 0x0001);
            L0035: if (JumpEqual) goto L003F;
            L0037: Compare(ax, 0x0002);
            L003A: if (JumpEqual) goto L006E;
            L003C: goto L0137;
            L003F: AddEncounter(player, 0x01, 0x19);
            L0051: si = 0x0005;
            L0054: goto L0066;
            L0056: AddEncounter(player, si, 0x1E);
            L0065: si = si + 1;
            L0066: Compare(si, 0x06);
            L0069: if (JumpLessOrEqual) goto L0056;
            L006B: goto L0137;
            L006E: si = 0x0001;
            L0071: goto L0083;
            L0073: AddEncounter(player, si, 0x19);
            L0082: si = si + 1;
            L0083: Compare(si, 0x02);
            L0086: if (JumpLessOrEqual) goto L0073;
            L0088: si = 0x0005;
            L008B: goto L009D;
            L008D: AddEncounter(player, si, 0x1E);
            L009C: si = si + 1;
            L009D: Compare(si, 0x06);
            L00A0: if (JumpLessOrEqual) goto L008D;
            L00A2: goto L0137;
            L00A5: AddEncounter(player, si, 0x19);
            L00B4: si = si + 1;
            L00B5: Compare(si, 0x04);
            L00B8: if (JumpLessOrEqual) goto L00A5;
            L00BA: si = 0x0005;
            L00BD: goto L00CF;
            L00BF: AddEncounter(player, si, 0x1E);
            L00CE: si = si + 1;
            L00CF: Compare(si, 0x06);
            L00D2: if (JumpLessOrEqual) goto L00BF;
            L00D4: goto L0137;
            L00D6: Compare(GetFlag(player, 0x03, 0x1A), 0x0001);
            L00EA: if (JumpNotEqual) goto L0115;
            L00EC: ShowMessage(player, String10E0); // Huge golems lumber forward to block your path.
            L00F9: si = 0x0001;
            L00FC: goto L010E;
            L00FE: AddEncounter(player, si, 0x19);
            L010D: si = si + 1;
            L010E: Compare(si, 0x03);
            L0111: if (JumpLessOrEqual) goto L00FE;
            L0113: goto L0137;
            L0115: ShowMessage(player, String110F); // The floor here shows traces of recent activity by huge creatures.
            L0122: SetFlag(player, 0x03, 0x1A, 0x01);
            L0137: return; // RETURN (restoring si);
        }

        private void FnROOMMES_2F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0x28), 0x0001);
            L0017: if (JumpNotEqual) goto L0033;
            L0019: ShowMessage(player, String1151); // An eerie sense of magic surrounds you.
            L0026: ShowMessage(player, String1178); // Something is different! You'd better check this area again.
            L0033: return; // RETURN;
        }

        private void FnGOLGAORE_30(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: ShowMessage(player, String11B4); // A horde of Golems stir to life as they sense your approach!
            L0011: si = 0x0001;
            L0014: goto L0026;
            L0016: AddEncounter(player, si, 0x1F);
            L0025: si = si + 1;
            L0026: Compare(si, 0x04);
            L0029: if (JumpLessOrEqual) goto L0016;
            L002B: return; // RETURN (restoring si);
        }

        private void FnROGUEONE_31(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: ShowMessage(player, String11F0); // Babbling rogues, driven mad from their quests, see you as their next prey.
            L0011: Compare(PartyCount(player), 0x0001);
            L001C: if (JumpEqual) goto L0025;
            L001E: Compare(ax, 0x0002);
            L0021: if (JumpEqual) goto L004B;
            L0023: goto L0081;
            L0025: AddEncounter(player, 0x01, 0x20);
            L0037: AddEncounter(player, 0x02, 0x21);
            L0049: goto L00B5;
            L004B: si = 0x0001;
            L004E: goto L0060;
            L0050: AddEncounter(player, si, 0x20);
            L005F: si = si + 1;
            L0060: Compare(si, 0x02);
            L0063: if (JumpLessOrEqual) goto L0050;
            L0065: si = 0x0005;
            L0068: goto L007A;
            L006A: AddEncounter(player, si, 0x21);
            L0079: si = si + 1;
            L007A: Compare(si, 0x06);
            L007D: if (JumpLessOrEqual) goto L006A;
            L007F: goto L00B5;
            L0081: si = 0x0001;
            L0084: goto L0096;
            L0086: AddEncounter(player, si, 0x20);
            L0095: si = si + 1;
            L0096: Compare(si, 0x04);
            L0099: if (JumpLessOrEqual) goto L0086;
            L009B: si = 0x0005;
            L009E: goto L00B0;
            L00A0: AddEncounter(player, si, 0x21);
            L00AF: si = si + 1;
            L00B0: Compare(si, 0x06);
            L00B3: if (JumpLessOrEqual) goto L00A0;
            L00B5: return; // RETURN (restoring si);
        }

        private void FnROGUETWO_32(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: Compare(GetFlag(player, 0x03, 0x1B), 0x0001);
            L0018: if (JumpNotEqual) goto L0090;
            L001A: ShowMessage(player, String123B); // 'OUT! Keep out of our domain!'
            L0027: Compare(PartyCount(player), 0x0001);
            L0032: if (JumpEqual) goto L003B;
            L0034: Compare(ax, 0x0002);
            L0037: if (JumpEqual) goto L0058;
            L0039: goto L0074;
            L003B: si = 0x0001;
            L003E: goto L0050;
            L0040: AddEncounter(player, si, 0x22);
            L004F: si = si + 1;
            L0050: Compare(si, 0x02);
            L0053: if (JumpLessOrEqual) goto L0040;
            L0055: goto L00D9;
            L0058: si = 0x0001;
            L005B: goto L006D;
            L005D: AddEncounter(player, si, 0x22);
            L006C: si = si + 1;
            L006D: Compare(si, 0x04);
            L0070: if (JumpLessOrEqual) goto L005D;
            L0072: goto L00D9;
            L0074: si = 0x0001;
            L0077: goto L0089;
            L0079: AddEncounter(player, si, 0x22);
            L0088: si = si + 1;
            L0089: Compare(si, 0x06);
            L008C: if (JumpLessOrEqual) goto L0079;
            L008E: goto L00D9;
            L0090: ShowPortrait(player, 0x0014);
            L009D: ShowMessage(player, String125A); // A Night Elf warrior holds his forces at the ready.
            L00AA: ShowMessage(player, String128D); // 'Leave this place and do not return. Abandon your quest for our Dralkarians.
            L00B7: ShowMessage(player, String12DA); // This shall be your only warning.'
            L00C4: SetFlag(player, 0x03, 0x1B, 0x01);
            L00D9: return; // RETURN (restoring si);
        }

        private void FnROGUETRE_33(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: ShowMessage(player, String12FC); // More Night Elves have been called to defend their domain.
            L0011: Compare(PartyCount(player), 0x0001);
            L001C: if (JumpEqual) goto L0025;
            L001E: Compare(ax, 0x0002);
            L0021: if (JumpEqual) goto L0041;
            L0023: goto L005D;
            L0025: si = 0x0001;
            L0028: goto L003A;
            L002A: AddEncounter(player, si, 0x23);
            L0039: si = si + 1;
            L003A: Compare(si, 0x02);
            L003D: if (JumpLessOrEqual) goto L002A;
            L003F: goto L0077;
            L0041: si = 0x0001;
            L0044: goto L0056;
            L0046: AddEncounter(player, si, 0x23);
            L0055: si = si + 1;
            L0056: Compare(si, 0x04);
            L0059: if (JumpLessOrEqual) goto L0046;
            L005B: goto L0077;
            L005D: si = 0x0001;
            L0060: goto L0072;
            L0062: AddEncounter(player, si, 0x23);
            L0071: si = si + 1;
            L0072: Compare(si, 0x06);
            L0075: if (JumpLessOrEqual) goto L0062;
            L0077: return; // RETURN (restoring si);
        }

        private void FnROGUEFOR_34(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1336); // Babbling creatures begin feuding and draw you into their fray.
            L0010: AddEncounter(player, 0x01, 0x25);
            L0022: AddEncounter(player, 0x02, 0x26);
            L0034: return; // RETURN;
        }

        private void FnBATSONE_35(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: ShowMessage(player, String1375); // A slew of bats rush through this hallway.
            L0011: Compare(PartyCount(player), 0x0001);
            L001C: if (JumpEqual) goto L0025;
            L001E: Compare(ax, 0x0002);
            L0021: if (JumpEqual) goto L0041;
            L0023: goto L005D;
            L0025: si = 0x0001;
            L0028: goto L003A;
            L002A: AddEncounter(player, si, 0x27);
            L0039: si = si + 1;
            L003A: Compare(si, 0x02);
            L003D: if (JumpLessOrEqual) goto L002A;
            L003F: goto L0077;
            L0041: si = 0x0001;
            L0044: goto L0056;
            L0046: AddEncounter(player, si, 0x27);
            L0055: si = si + 1;
            L0056: Compare(si, 0x04);
            L0059: if (JumpLessOrEqual) goto L0046;
            L005B: goto L0077;
            L005D: si = 0x0001;
            L0060: goto L0072;
            L0062: AddEncounter(player, si, 0x27);
            L0071: si = si + 1;
            L0072: Compare(si, 0x06);
            L0075: if (JumpLessOrEqual) goto L0062;
            L0077: return; // RETURN (restoring si);
        }

        private void FnCASETRAP_36(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: si = GetFlag(player, 0x03, 0x19);
            L0017: PushStack(player, 0x01);
            L001B: PushStack(player, 0x00);
19FA  001E C4 5E 06  les bx, [bp+0x6]
19FD  0021 26 FF 5F 04  call far word [es:bx+0x4]
            L0025: cx = PopStack(player);
            L0026: cx = PopStack(player);
            L0027: RefreshCompareFlags(ax);
            L0029: if (JumpEqual) goto L002E;
            L002B: goto L018E;
            L002E: bx = si;
            L0030: bx = bx - 1;
            L0031: Compare(bx, 0x03);
            L0034: if (JumpBelowOrEqual) goto L0039;
            L0036: goto L0121;
            L0039: switch (bx) {
                case 0:
                    goto L0040;
                case 1:
                    goto L0086;
                case 2:
                    goto L00BE;
                case 3:
                    goto L00DA;
            }
            L0040: ax = GetCurrentHits(player);
            L0047: bx = 0x0006;
            L004A: dx = ax % bx; ax = ax / bx;
            L004D: DamagePlayer(player, ax);
            L0057: PushStack(player, 0x64);
            L005B: PushStack(player, 0x0F);
            L005F: PushStack(player, 0x01);
1A3F  0063 C4 5E 06  les bx, [bp+0x6]
1A42  0066 26 FF 9F 9C 00  call far word [es:bx+0x9c]
1A47  006B 83 C4 06  add sp, 0x6
1A4A  006E C4 5E 06  les bx, [bp+0x6]
1A4D  0071 26 FF 5F 40  call far word [es:bx+0x40]
            L0075: ShowMessage(player, String139F); // You spring a trap laced with poisoned darts.
            L0082: si = si + 1;
            L0083: goto L0157;
            L0086: ax = GetCurrentHits(player);
            L008D: bx = 0x0005;
            L0090: dx = ax % bx; ax = ax / bx;
            L0093: DamagePlayer(player, ax);
            L009D: ShowMessage(player, String13CC); // You trigger some mage's trap. A cloud of acid surrounds you!!
            L00AA: ModifyGold(player, 0xFFFF30BA);
            L00BC: goto L0082;
            L00BE: ax = GetCurrentHits(player);
            L00C5: bx = 0x0004;
            L00C8: dx = ax % bx; ax = ax / bx;
            L00CB: DamagePlayer(player, ax);
1AB1  00D5 B8 0A 14  mov ax, 0x140a
            L00D8: goto L0078;
            L00DA: PushStack(player, 0xC8);
            L00DE: PushStack(player, 0x0F);
            L00E2: PushStack(player, 0x01);
1AC2  00E6 C4 5E 06  les bx, [bp+0x6]
1AC5  00E9 26 FF 9F 9C 00  call far word [es:bx+0x9c]
1ACA  00EE 83 C4 06  add sp, 0x6
1ACD  00F1 B8 0C FE  mov ax, 0xfe0c
            L00F4: PushStack(player, ax);
1AD1  00F5 C4 5E 06  les bx, [bp+0x6]
1AD4  00F8 26 FF 9F B4 00  call far word [es:bx+0xb4]
            L00FD: goto L010A;
            L00FF: RemoveItem(player, 0xC2);
            L010B: ax = HasItem(player, 0xC2);
            L0119: if (JumpNotEqual) goto L00FF;
1AF7  011B B8 48 14  mov ax, 0x1448
            L011E: goto L0078;
            L0121: ax = GetMaxHits(player);
            L0128: bx = 0x0005;
            L012B: dx = ax % bx; ax = ax / bx;
            L012E: DamagePlayer(player, ax);
            L0138: SetNoHealZone(player);
            L0140: si = 0x0001;
1B1F  0143 C4 5E 06  les bx, [bp+0x6]
1B22  0146 26 FF 5F 40  call far word [es:bx+0x40]
            L014A: ShowMessage(player, String1469); // A fierce whirlwind strikes you from some unseen sorcerer's hand!
            L0157: SetFlag(player, 0xC4, 0xB8, si);
            L0169: PushStack(player, 0x01);
            L016D: PushStack(player, ax);
            L016E: PushStack(player, 0x00);
1B4D  0171 C4 5E 06  les bx, [bp+0x6]
1B50  0174 26 FF 1F  call far word [es:bx]
1B53  0177 83 C4 06  add sp, 0x6
            L017A: SetFlag(player, 0x03, 0x1C, 0x00);
            L018E: return; // RETURN (restoring si);
        }

        private void FnBABLBATL_37(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: ShowMessage(player, String14AA); // Well-trained Night Elves guard these corridors.
            L0011: Compare(PartyCount(player), 0x0001);
            L001C: if (JumpEqual) goto L0025;
            L001E: Compare(ax, 0x0002);
            L0021: if (JumpEqual) goto L0041;
            L0023: goto L0077;
            L0025: si = 0x0001;
            L0028: goto L003A;
            L002A: AddEncounter(player, si, 0x22);
            L0039: si = si + 1;
            L003A: Compare(si, 0x03);
            L003D: if (JumpLessOrEqual) goto L002A;
            L003F: goto L0091;
            L0041: si = 0x0001;
            L0044: goto L0056;
            L0046: AddEncounter(player, si, 0x22);
            L0055: si = si + 1;
            L0056: Compare(si, 0x02);
            L0059: if (JumpLessOrEqual) goto L0046;
            L005B: si = 0x0005;
            L005E: goto L0070;
            L0060: AddEncounter(player, si, 0x22);
            L006F: si = si + 1;
            L0070: Compare(si, 0x06);
            L0073: if (JumpLessOrEqual) goto L0060;
            L0075: goto L0091;
            L0077: si = 0x0001;
            L007A: goto L008C;
            L007C: AddEncounter(player, si, 0x22);
            L008B: si = si + 1;
            L008C: Compare(si, 0x06);
            L008F: if (JumpLessOrEqual) goto L007C;
            L0091: return; // RETURN (restoring si);
        }

        private void FnEGRESNPC_38(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x001C);
            L0010: ShowMessage(player, String14DA); // An ancient Knight whispers, 'The leader must be removed to see the summit. And even though the spells of royalty be at the end, they shall be the first.'
            L001D: return; // RETURN;
        }

        private void FnSWTCHNPC_39(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x001E);
            L0010: ShowMessage(player, String1574); // 'The nine switches are used to open the way down to the next area. You must learn which switches to turn on.
            L001D: ShowMessage(player, String15E1); // Having the nine switches set in unison will unlock the way for you.'
            L002A: return; // RETURN;
        }

        private void FnFNTHEAL_3A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0042);
            L0010: ShowMessage(player, String1626); // The cool waters satisfy and enrich you.
            L001D: HealPlayer(player, GetMaxHits(player));
            L002E: AddMana(player, 0x09C4);
            L003B: return; // RETURN;
        }

        private void FnSETRACE_3B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: // make space for tmp on stack: sp -= 2
1C96  0005 56     push si
            L0006: ax = GetRace(player);
1C9E  000D 89 46 FE  mov [bp-0x2], ax
1CA1  0010 8B 5E FE  mov bx, [bp-0x2]
            L0013: Compare(bx, 0x07);
            L0016: if (JumpAbove) goto L0045;
            L0018: switch (bx) {
                case 0:
                    goto L001F;
                case 1:
                    goto L0033;
                case 2:
                    goto L0024;
                case 3:
                    goto L0038;
                case 4:
                    goto L0029;
                case 5:
                    goto L002E;
                case 6:
                    goto L003D;
                case 7:
                    goto L0042;
            }
            L001F: si = 0x002E;
            L0022: goto L0045;
            L0024: si = 0x0028;
            L0027: goto L0045;
            L0029: si = 0x0027;
            L002C: goto L0045;
            L002E: si = 0x0029;
            L0031: goto L0045;
            L0033: si = 0x002A;
            L0036: goto L0045;
            L0038: si = 0x002B;
            L003B: goto L0045;
            L003D: si = 0x002C;
            L0040: goto L0045;
            L0042: si = 0x002D;
1CD6  0045 56     push si
            L0046: PushStack(player, 0x02);
1CDB  004A C4 5E 06  les bx, [bp+0x6]
1CDE  004D 26 FF 5F 04  call far word [es:bx+0x4]
            L0051: cx = PopStack(player);
            L0052: cx = PopStack(player);
            L0053: RefreshCompareFlags(ax);
            L0055: if (JumpNotEqual) goto L0069;
            L0057: PushStack(player, 0x01);
1CEC  005B 56     push si
            L005C: PushStack(player, 0x02);
1CF1  0060 C4 5E 06  les bx, [bp+0x6]
1CF4  0063 26 FF 1F  call far word [es:bx]
1CF7  0066 83 C4 06  add sp, 0x6
            L0069: ax = HasItem(player, 0x71);
            L0077: if (JumpEqual) goto L00DB;
            L0079: RefreshCompareFlags(GetFlag(player, 0x02, 0x39));
            L008C: if (JumpNotEqual) goto L00DB;
1D1F  008E B8 4E 16  mov ax, 0x164e
            L0091: PushStack(player, ax);
1D23  0092 C4 5E 06  les bx, [bp+0x6]
1D26  0095 26 FF 9F F8 00  call far word [es:bx+0xf8]
            L009A: goto L00A7;
            L009C: RemoveItem(player, 0x71);
            L00A8: ax = HasItem(player, 0x71);
            L00B6: if (JumpNotEqual) goto L009C;
            L00B8: ModifyGold(player, 0xFFFFF0BA);
            L00CA: DamagePlayer(player, GetMaxHits(player));
1D6C  00DB 5E     pop si
            L00DC: // restore stack ptr: sp = bp;
            L00DE: return; // RETURN;
        }

        private void FnONEATTIM_3C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String16A4); // The door glows with a magical force.
            L0010: Compare(PartyCount(player), 0x0001);
            L001B: if (JumpNotEqual) goto L002F;
            L001D: ShowMessage(player, String16C9); // You may proceed alone.
1DAB  002A B8 01 00  mov ax, 0x1
            L002D: goto L003E;
            L002F: ShowMessage(player, String16E0); // You must enter here one at a time.
            L003C: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0059: return; // RETURN;
        }

    }
}
