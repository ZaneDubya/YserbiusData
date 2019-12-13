#pragma warning disable
using System.Collections.Generic;
using XPT.WorldData;
using XPT.WorldData.Yserbius;

namespace XPT.Scripts.Twinion.Maps {
    class TwMap09 : AMapScripted {
        protected override int MapIndex => 9;
        protected override int RandomEncounterChance => 10;
        protected override int RandomEncounterExtraCount => 0;

        public TwMap09() {
            MapEvent01 = FnNPCENC_01;
            MapEvent02 = FnFTNM_02;
            MapEvent03 = FnCLUEB_03;
            MapEvent04 = FnCLUEC_04;
            MapEvent05 = FnTAPA_05;
            MapEvent06 = FnTAPB_06;
            MapEvent07 = FnCLUED_07;
            MapEvent08 = FnTAPC_08;
            MapEvent09 = FnTAPD_09;
            MapEvent0A = FnTAPE_0A;
            MapEvent0B = FnTELEA_0B;
            MapEvent0C = FnSECA_0C;
            MapEvent0D = FnCLUEE_0D;
            MapEvent0E = FnTAPF_0E;
            MapEvent0F = FnTAPG_0F;
            MapEvent10 = FnITDRA_10;
            MapEvent11 = FnTAPH_11;
            MapEvent12 = FnNPCSHLD_12;
            MapEvent13 = FnTELEB_13;
            MapEvent14 = FnMANADOWN_14;
            MapEvent15 = FnSECMS_15;
            MapEvent16 = FnMAPEXP_16;
            MapEvent17 = FnTELEC_17;
            MapEvent18 = FnCLUEG_18;
            MapEvent19 = FnTELED_19;
            MapEvent1A = FnBROHRS_1A;
            MapEvent1B = FnTELOA_1B;
            MapEvent1D = FnITDRB_1D;
            MapEvent1E = FnTELEE_1E;
            MapEvent1F = FnFTNH_1F;
            MapEvent21 = FnCLUEH_21;
            MapEvent22 = FnTELEF_22;
            MapEvent23 = FnCLUEI_23;
            MapEvent25 = FnTELEG_25;
            MapEvent26 = FnCLUEK_26;
            MapEvent27 = FnSTONEBTL_27;
            MapEvent28 = FnTOOL_28;
            MapEvent29 = FnTOOLMSG_29;
            MapEvent2A = FnTNEPRES_2A;
            MapEvent2C = FnGARDMSG_2C;
            MapEvent2D = FnGARD_2D;
            MapEvent2E = FnHLTHDWN_2E;
            MapEvent2F = FnFTNMH_2F;
            MapEvent30 = FnCLUEL_30;
            MapEvent31 = FnHARMDR_31;
            MapEvent32 = FnCLUEM_32;
            MapEvent33 = FnCHADR_33;
            MapEvent34 = FnDRMSG_34;
            MapEvent35 = FnHARMMSG_35;
            MapEvent36 = FnCHAMSG_36;
            MapEvent37 = FnMEDA_37;
            MapEvent38 = FnMEDB_38;
            MapEvent39 = FnMEDC_39;
            MapEvent3A = FnMEDD_3A;
            MapEvent3B = FnHRDA_3B;
            MapEvent3C = FnEZA_3C;
            MapEvent3D = FnEZB_3D;
            MapEvent3E = FnHRDB_3E;
            MapEvent3F = Fn_3F;
        }
        
        // === Strings ================================================
        private const string String03FC = "You come across an aging magician. 'Be sure to open all doors in the dungeon. I have learned many a spell by being curious.'";
        private const string String0479 = "Windward Fountain restores your mana.";
        private const string String049F = "A wizard rushes by you laughing and shouting, 'Now they will all be clueless.'";
        private const string String04EE = "A sign on the wall reminds you, 'Some rooms should be accessed only by certain guilds, races or alignments. Oft times you could lose something of value by not heeding a warning.'";
        private const string String05A1 = "The message on the plaque says 'Use the Pearl third.'";
        private const string String05D7 = "Runes in the Human tongue are etched here.";
        private const string String0602 = "The message on the plaque says 'If given a choice, use the Pearl second.'";
        private const string String064C = "You see a royal insignia of the Halflings.";
        private const string String0677 = "You see a badly wounded barbarian. 'Heed my words... grave robbing can be hazardous to your health.'";
        private const string String06DC = "The message on the plaque says 'If given a choice, use the Pearl first.'";
        private const string String0725 = "The etchings on the plaque seem familiar.";
        private const string String074F = "The message on the plaque says 'Use Dabelais' payment first.'";
        private const string String078D = "Elven runes abound here.";
        private const string String07A6 = "The message on the plaque says 'Use Dabelais' payment second.'";
        private const string String07E5 = "You don't understand the language on the plaque.";
        private const string String0816 = "A door suddenly appears.";
        private const string String082F = "As the winds swirl around, you hear a ghostly voice whispering something about benevolent spirits endowing you with certain attributes.";
        private const string String08B7 = "The message on the plaque says 'Use the Coral before the Topaz.'";
        private const string String08F8 = "Some guttural language pervades here.";
        private const string String091E = "The message on the plaque says 'If given a choice, use the Opal third.'";
        private const string String0966 = "Only Gnomes can read this.";
        private const string String0981 = "The Maze Key opens the door.";
        private const string String099E = "The door is locked. Engraved on the lock are the words -";
        private const string String09D7 = "'Manufactured by";
        private const string String09E8 = "Aeowyn's Slateworks.";
        private const string String09FD = "Zembolinee Bromerique,";
        private const string String0A14 = "Esquire.'";
        private const string String0A1E = "The message on the plaque says 'Use Tyndil's payment first.'";
        private const string String0A5B = "Ah, you recognize but don't understand the Dwarven runes.";
        private const string String0A95 = "Flashing his black and white shield at you the thief states, 'It's aMAZEing how this shield guards against the dangers of this maze.'";
        private const string String0B1B = "Your guardian protects you from the mist.";
        private const string String0B45 = "A mist surrounds you absorbing some of your mana.";
        private const string String0B77 = "You stop and contemplate your luck in having found items which assist you in locating secret passages. These items have become handy.";
        private const string String0BFD = "You wander past a group of adventurers all lugging ropes and you wonder about their destination.";
        private const string String0C5E = "You pass a knight who, as he hurries by, calls out - ";
        private const string String0C94 = "'I have traversed the Night Elves' Domain and have found the locations of Snicker's three brothers. Now off to find the item they desire!'";
        private const string String0D1F = "The Stone of Awareness makes a door visible.";
        private const string String0D4C = "The waters of Leeward Fountain heal your wounds.";
        private const string String0D7D = "You pass a lost knight who toys with a stone.";
        private const string String0DAB = "The knight suddenly snarls at you, 'This is not it!";
        private const string String0DDF = "The stone I seek will let me find what is otherwise undetectable in this area of the dungeon!'";
        private const string String0E3E = "You stumble upon a cleric who says gravely, 'Not all fountains are good for your health.'";
        private const string String0E98 = "You come across a worn journal telling an adventurer's story about becoming more skilled after scaling cliffs.";
        private const string String0F07 = "Golems attack you for your stone.";
        private const string String0F29 = "You see golems looking at a stone.";
        private const string String0F4C = "You find a bag with 25,000 gold pieces.";
        private const string String0F74 = "You are jumped by chaotic adventurers who steal 2,000 gold pieces.";
        private const string String0FB7 = "The fog lifts and you see the door to the Tool Shed.";
        private const string String0FEC = "Nasty looking monsters attack you for your key.";
        private const string String101C = "Vicious monsters stand guard over an S-shaped key.";
        private const string String104F = "The fog lifts and you see the door to the Gardener's Shed.";
        private const string String108A = "You are jumped by harmonic adventurers who steal 2,000 gold pieces.";
        private const string String10CE = "Your guardian protects you from injury.";
        private const string String10F6 = "A loose brick falls from the maze wall and injures you.";
        private const string String112E = "The swirling waters of the Whirlwind Pool increase your health and mana.";
        private const string String1177 = "Inside a quest bag you find a scribbled note to another adventurer...";
        private const string String11BD = "'Rumor has it that treasure might still be hidden in a safe.'";
        private const string String11FB = "You see a shield on the floor, but the way is blocked.";
        private const string String1232 = "You lose experience for not heeding warnings.";
        private const string String1260 = "'Excuse me? I'm trying to find the Ballroom. I must be completely lost.";
        private const string String12A8 = "Oh, if you ever find yourself in the Ballroom, make sure you have your musical key ready.'";
        private const string String1303 = "You see a shield on the floor, but the way to it is blocked.";
        private const string String1340 = "The door to the north bears a sign - 'Harmony Only.' The door to the west bears a sign - 'Chaos Only.'";
        private const string String13A7 = "A secret message for Harmonics only is posted on the door. 'Do not enter the Tool Shed.'";
        private const string String1400 = "A secret message for Chaotics only is posted on the door. 'Do not enter the Gardener's Shed.'";
        private const string String145E = "You find a Map etched on a piece of slate. It must be one of the four maps Queen Aeowyn sent you to find.";
        private const string String14C8 = "Your Maze Key and Stone of Awareness dissipate as you grab it.";
        private const string String1507 = "The room is empty.";
        
        // === Functions ================================================
        private void FnNPCENC_01(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x002C);
            L0010: ShowMessage(player, String03FC); // You come across an aging magician. 'Be sure to open all doors in the dungeon. I have learned many a spell by being curious.'
            L001D: return; // RETURN;
        }

        private void FnFTNM_02(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0042);
            L0010: ShowMessage(player, String0479); // Windward Fountain restores your mana.
            L001D: AddMana(player, 0x2710);
            L002A: return; // RETURN;
        }

        private void FnCLUEB_03(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x002E);
            L0010: ShowMessage(player, String049F); // A wizard rushes by you laughing and shouting, 'Now they will all be clueless.'
            L001D: return; // RETURN;
        }

        private void FnCLUEC_04(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String04EE); // A sign on the wall reminds you, 'Some rooms should be accessed only by certain guilds, races or alignments. Oft times you could lose something of value by not heeding a warning.'
            L0010: return; // RETURN;
        }

        private void FnTAPA_05(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetRace(player));
            L000C: if (JumpNotEqual) goto L0013;
0094  000E B8 A1 05  mov ax, 0x5a1
            L0011: goto L0016;
            L0013: ShowMessage(player, String05D7); // Runes in the Human tongue are etched here.
            L0020: return; // RETURN;
        }

        private void FnTAPB_06(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetRace(player), 0x0006);
            L000D: if (JumpNotEqual) goto L0014;
00B7  000F B8 02 06  mov ax, 0x602
            L0012: goto L0017;
            L0014: ShowMessage(player, String064C); // You see a royal insignia of the Halflings.
            L0021: return; // RETURN;
        }

        private void FnCLUED_07(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0016);
            L0010: ShowMessage(player, String0677); // You see a badly wounded barbarian. 'Heed my words... grave robbing can be hazardous to your health.'
            L001D: return; // RETURN;
        }

        private void FnTAPC_08(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetRace(player), 0x0007);
            L000D: if (JumpNotEqual) goto L0014;
00F9  000F B8 DC 06  mov ax, 0x6dc
            L0012: goto L0017;
            L0014: ShowMessage(player, String0725); // The etchings on the plaque seem familiar.
            L0021: return; // RETURN;
        }

        private void FnTAPD_09(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetRace(player), 0x0002);
            L000D: if (JumpNotEqual) goto L0014;
011C  000F B8 4F 07  mov ax, 0x74f
            L0012: goto L0017;
            L0014: ShowMessage(player, String078D); // Elven runes abound here.
            L0021: return; // RETURN;
        }

        private void FnTAPE_0A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetRace(player), 0x0003);
            L000D: if (JumpNotEqual) goto L0014;
013F  000F B8 A6 07  mov ax, 0x7a6
            L0012: goto L0017;
            L0014: ShowMessage(player, String07E5); // You don't understand the language on the plaque.
            L0021: return; // RETURN;
        }

        private void FnTELEA_0B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x04, 0x02, 0xA2, 0x01, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnSECA_0C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, 0x0D), 0x0006);
            L0012: if (JumpNotBelow) goto L006C;
            L0014: RefreshCompareFlags(HasUsedSpell(player, 0x17));
            L0022: if (JumpNotEqual) goto L006C;
            L0024: PushStack(player, 0x68);
            L0028: PushStack(player, ax);
019C  0029 C4 5E 06  les bx, [bp+0x6]
019F  002C 26 FF 5F 54  call far word [es:bx+0x54]
            L0030: cx = PopStack(player);
            L0031: cx = PopStack(player);
            L0032: RefreshCompareFlags(ax);
            L0034: if (JumpNotEqual) goto L006C;
            L0036: PushStack(player, 0x6E);
            L003A: PushStack(player, ax);
01AE  003B C4 5E 06  les bx, [bp+0x6]
01B1  003E 26 FF 5F 54  call far word [es:bx+0x54]
            L0042: cx = PopStack(player);
            L0043: cx = PopStack(player);
            L0044: RefreshCompareFlags(ax);
            L0046: if (JumpNotEqual) goto L006C;
            L0048: PushStack(player, 0x90);
            L004C: PushStack(player, ax);
01C0  004D C4 5E 06  les bx, [bp+0x6]
01C3  0050 26 FF 5F 54  call far word [es:bx+0x54]
            L0054: cx = PopStack(player);
            L0055: cx = PopStack(player);
            L0056: RefreshCompareFlags(ax);
            L0058: if (JumpNotEqual) goto L006C;
            L005A: PushStack(player, 0xA4);
            L005E: PushStack(player, ax);
01D2  005F C4 5E 06  les bx, [bp+0x6]
01D5  0062 26 FF 5F 54  call far word [es:bx+0x54]
            L0066: cx = PopStack(player);
            L0067: cx = PopStack(player);
            L0068: RefreshCompareFlags(ax);
            L006A: if (JumpEqual) goto L0093;
            L006C: ShowMessage(player, String0816); // A door suddenly appears.
01EC  0079 FF 76 08  push word [bp+0x8]
01EF  007C FF 76 06  push word [bp+0x6]
01F2  007F 0E     push cs
01F3  0080 E8 38 13  call 0x13bb
            L0083: // NOP
            L0084: cx = PopStack(player);
            L0085: cx = PopStack(player);
01F9  0086 FF 76 08  push word [bp+0x8]
01FC  0089 FF 76 06  push word [bp+0x6]
01FF  008C 0E     push cs
0200  008D E8 E6 12  call 0x1376
            L0090: // NOP
            L0091: goto L009E;
0206  0093 FF 76 08  push word [bp+0x8]
0209  0096 FF 76 06  push word [bp+0x6]
020C  0099 0E     push cs
020D  009A E8 FC 12  call 0x1399
            L009D: // NOP
            L009E: cx = PopStack(player);
            L009F: cx = PopStack(player);
            L00A0: return; // RETURN;
        }

        private void FnCLUEE_0D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String082F); // As the winds swirl around, you hear a ghostly voice whispering something about benevolent spirits endowing you with certain attributes.
            L0010: return; // RETURN;
        }

        private void FnTAPF_0E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetRace(player), 0x0001);
            L000D: if (JumpNotEqual) goto L0014;
0236  000F B8 B7 08  mov ax, 0x8b7
            L0012: goto L0017;
            L0014: ShowMessage(player, String08F8); // Some guttural language pervades here.
            L0021: return; // RETURN;
        }

        private void FnTAPG_0F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetRace(player), 0x0005);
            L000D: if (JumpNotEqual) goto L0014;
0259  000F B8 1E 09  mov ax, 0x91e
            L0012: goto L0017;
            L0014: ShowMessage(player, String0966); // Only Gnomes can read this.
            L0021: return; // RETURN;
        }

        private void FnITDRA_10(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0xD2);
            L0007: PushStack(player, ax);
0275  0008 C4 5E 06  les bx, [bp+0x6]
0278  000B 26 FF 5F 54  call far word [es:bx+0x54]
            L000F: cx = PopStack(player);
            L0010: cx = PopStack(player);
            L0011: RefreshCompareFlags(ax);
            L0013: if (JumpEqual) goto L0034;
0282  0015 FF 76 08  push word [bp+0x8]
0285  0018 FF 76 06  push word [bp+0x6]
0288  001B 0E     push cs
0289  001C E8 5D 12  call 0x127c
            L001F: // NOP
            L0020: cx = PopStack(player);
            L0021: cx = PopStack(player);
028F  0022 FF 76 08  push word [bp+0x8]
0292  0025 FF 76 06  push word [bp+0x6]
0295  0028 0E     push cs
0296  0029 E8 95 12  call 0x12c1
            L002C: // NOP
            L002D: cx = PopStack(player);
            L002E: cx = PopStack(player);
029C  002F B8 81 09  mov ax, 0x981
            L0032: goto L0078;
02A1  0034 FF 76 08  push word [bp+0x8]
02A4  0037 FF 76 06  push word [bp+0x6]
02A7  003A 0E     push cs
02A8  003B E8 61 12  call 0x129f
            L003E: // NOP
            L003F: cx = PopStack(player);
            L0040: cx = PopStack(player);
            L0041: ShowMessage(player, String099E); // The door is locked. Engraved on the lock are the words -
            L004E: ShowMessage(player, String09D7); // 'Manufactured by
            L005B: ShowMessage(player, String09E8); // Aeowyn's Slateworks.
            L0068: ShowMessage(player, String09FD); // Zembolinee Bromerique,
            L0075: ShowMessage(player, String0A14); // Esquire.'
            L0082: return; // RETURN;
        }

        private void FnTAPH_11(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetRace(player), 0x0004);
            L000D: if (JumpNotEqual) goto L0014;
0300  000F B8 1E 0A  mov ax, 0xa1e
            L0012: goto L0017;
            L0014: ShowMessage(player, String0A5B); // Ah, you recognize but don't understand the Dwarven runes.
            L0021: return; // RETURN;
        }

        private void FnNPCSHLD_12(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0023);
            L0010: ShowMessage(player, String0A95); // Flashing his black and white shield at you the thief states, 'It's aMAZEing how this shield guards against the dangers of this maze.'
            L001D: return; // RETURN;
        }

        private void FnTELEB_13(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x04, 0x02, 0xB9, 0x00, isForwardMove);
            L001D: return; // RETURN;
        }

        private void FnMANADOWN_14(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0x58);
            L0011: if (JumpNotEqual) goto L0023;
            L0013: ax = HasItem(player, 0x57);
            L0021: if (JumpEqual) goto L0031;
0375  0023 B8 1B 0B  mov ax, 0xb1b
            L0026: PushStack(player, ax);
0379  0027 C4 5E 06  les bx, [bp+0x6]
037C  002A 26 FF 9F F8 00  call far word [es:bx+0xf8]
            L002F: goto L004A;
            L0031: ShowMessage(player, String0B45); // A mist surrounds you absorbing some of your mana.
            L003E: AddMana(player, 0xFF9C);
            L004B: return; // RETURN;
        }

        private void FnSECMS_15(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0B77); // You stop and contemplate your luck in having found items which assist you in locating secret passages. These items have become handy.
            L0010: return; // RETURN;
        }

        private void FnMAPEXP_16(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0x42), 0x0001);
            L0017: if (JumpNotEqual) goto L0051;
            L0019: ax = HasItem(player, 0xD3);
            L0027: if (JumpEqual) goto L0043;
03DA  0029 FF 76 08  push word [bp+0x8]
03DD  002C FF 76 06  push word [bp+0x6]
03E0  002F 0E     push cs
03E1  0030 E8 A0 11  call 0x11d3
            L0033: // NOP
            L0034: cx = PopStack(player);
            L0035: cx = PopStack(player);
03E7  0036 FF 76 08  push word [bp+0x8]
03EA  0039 FF 76 06  push word [bp+0x6]
03ED  003C 0E     push cs
03EE  003D E8 60 11  call 0x11a0
            L0040: // NOP
            L0041: goto L00AC;
            L0043: GiveItem(player, 0xD3);
            L004F: goto L0094;
            L0051: ax = HasItem(player, 0xD2);
            L005F: if (JumpEqual) goto L00A1;
            L0061: GiveItem(player, 0xD3);
            L006D: AddExperience(player, 0x00030D40);
            L007F: SetFlag(player, 0x02, 0x42, 0x01);
0445  0094 FF 76 08  push word [bp+0x8]
0448  0097 FF 76 06  push word [bp+0x6]
044B  009A 0E     push cs
044C  009B E8 7B 10  call 0x1119
            L009E: // NOP
            L009F: goto L0034;
0452  00A1 FF 76 08  push word [bp+0x8]
0455  00A4 FF 76 06  push word [bp+0x6]
0458  00A7 0E     push cs
0459  00A8 E8 28 11  call 0x11d3
            L00AB: // NOP
            L00AC: cx = PopStack(player);
            L00AD: cx = PopStack(player);
            L00AE: return; // RETURN;
        }

        private void FnTELEC_17(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x04, 0x02, 0xD0, 0x03, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnCLUEG_18(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0BFD); // You wander past a group of adventurers all lugging ropes and you wonder about their destination.
            L0010: return; // RETURN;
        }

        private void FnTELED_19(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x04, 0x02, 0xFF, 0x00, isForwardMove);
            L001D: return; // RETURN;
        }

        private void FnBROHRS_1A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x001D);
            L0010: ShowMessage(player, String0C5E); // You pass a knight who, as he hurries by, calls out - 
            L001D: ShowMessage(player, String0C94); // 'I have traversed the Night Elves' Domain and have found the locations of Snicker's three brothers. Now off to find the item they desire!'
            L002A: return; // RETURN;
        }

        private void FnTELOA_1B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x04, 0x01, 0xAA, 0x03, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnITDRB_1D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0xCF);
            L0011: if (JumpEqual) goto L003C;
0516  0013 FF 76 08  push word [bp+0x8]
0519  0016 FF 76 06  push word [bp+0x6]
051C  0019 0E     push cs
051D  001A E8 C9 0F  call 0xfe6
            L001D: // NOP
            L001E: cx = PopStack(player);
            L001F: cx = PopStack(player);
0523  0020 FF 76 08  push word [bp+0x8]
0526  0023 FF 76 06  push word [bp+0x6]
0529  0026 0E     push cs
052A  0027 E8 01 10  call 0x102b
            L002A: // NOP
            L002B: cx = PopStack(player);
            L002C: cx = PopStack(player);
            L002D: ShowMessage(player, String0D1F); // The Stone of Awareness makes a door visible.
            L003A: goto L0049;
053F  003C FF 76 08  push word [bp+0x8]
0542  003F FF 76 06  push word [bp+0x6]
0545  0042 0E     push cs
0546  0043 E8 C3 0F  call 0x1009
            L0046: // NOP
            L0047: cx = PopStack(player);
            L0048: cx = PopStack(player);
            L0049: return; // RETURN;
        }

        private void FnTELEE_1E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x04, 0x02, 0x21, 0x02, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnFTNH_1F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0042);
            L0010: HealPlayer(player, GetMaxHits(player));
            L0021: ShowMessage(player, String0D4C); // The waters of Leeward Fountain heal your wounds.
            L002E: return; // RETURN;
        }

        private void FnCLUEH_21(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x001C);
            L0010: ShowMessage(player, String0D7D); // You pass a lost knight who toys with a stone.
            L001D: ShowMessage(player, String0DAB); // The knight suddenly snarls at you, 'This is not it!
            L002A: ShowMessage(player, String0DDF); // The stone I seek will let me find what is otherwise undetectable in this area of the dungeon!'
            L0037: return; // RETURN;
        }

        private void FnTELEF_22(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x04, 0x02, 0xE9, 0x02, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnCLUEI_23(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0028);
            L0010: ShowMessage(player, String0E3E); // You stumble upon a cleric who says gravely, 'Not all fountains are good for your health.'
            L001D: return; // RETURN;
        }

        private void FnTELEG_25(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x04, 0x02, 0xE3, 0x02, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnCLUEK_26(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0E98); // You come across a worn journal telling an adventurer's story about becoming more skilled after scaling cliffs.
            L0010: return; // RETURN;
        }

        private void FnSTONEBTL_27(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0xCF);
            L0011: if (JumpEqual) goto L0034;
0665  0013 B8 DC 05  mov ax, 0x5dc
            L0016: PushStack(player, ax);
            L0017: PushStack(player, 0x00);
            L001A: PushStack(player, ax);
            L001B: PushStack(player, ax);
            L001C: PushStack(player, 0xB6);
            L0020: PushStack(player, 0x9F);
0676  0024 C4 5E 06  les bx, [bp+0x6]
0679  0027 26 FF 9F D8 00  call far word [es:bx+0xd8]
067E  002C 83 C4 0C  add sp, 0xc
0681  002F B8 07 0F  mov ax, 0xf07
            L0032: goto L0050;
0686  0034 B8 AC 0D  mov ax, 0xdac
            L0037: PushStack(player, ax);
            L0038: PushStack(player, 0x00);
            L003B: PushStack(player, ax);
            L003C: PushStack(player, ax);
            L003D: PushStack(player, ax);
            L003E: PushStack(player, 0xCF);
0694  0042 C4 5E 06  les bx, [bp+0x6]
0697  0045 26 FF 9F D8 00  call far word [es:bx+0xd8]
069C  004A 83 C4 0C  add sp, 0xc
            L004D: ShowMessage(player, String0F29); // You see golems looking at a stone.
            L005A: Compare(PartyCount(player), 0x0001);
            L0065: if (JumpNotEqual) goto L0083;
            L0067: AddEncounter(player, 0x01, 0x0D);
            L0079: PushStack(player, 0x0C);
06CF  007D B8 02 00  mov ax, 0x2
            L0080: goto L0108;
            L0083: Compare(PartyCount(player), 0x0002);
            L008E: if (JumpNotEqual) goto L00B9;
            L0090: AddEncounter(player, 0x01, 0x0B);
            L00A2: AddEncounter(player, 0x02, 0x0C);
0706  00B4 B8 0E 00  mov ax, 0xe
            L00B7: goto L0104;
            L00B9: AddEncounter(player, 0x01, 0x0B);
            L00CB: AddEncounter(player, 0x02, 0x0B);
            L00DD: AddEncounter(player, 0x03, 0x0D);
            L00EF: AddEncounter(player, 0x05, 0x1D);
            L0101: AddEncounter(player, 0x06, 0x1E);
            L0113: return; // RETURN;
        }

        private void FnTOOL_28(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0x43), 0x0001);
            L0017: if (JumpNotEqual) goto L0029;
0780  0019 FF 76 08  push word [bp+0x8]
0783  001C FF 76 06  push word [bp+0x6]
0786  001F 0E     push cs
0787  0020 E8 FA 0D  call 0xe1d
            L0023: // NOP
            L0024: cx = PopStack(player);
            L0025: cx = PopStack(player);
            L0026: goto L00B6;
            L0029: Compare(GetAlignment(player), 0x0001);
            L0034: if (JumpNotEqual) goto L0082;
            L0036: ModifyGold(player, 0x61A8);
            L0047: SetFlag(player, 0x02, 0x43, 0x01);
            L005C: ShowMessage(player, String0F4C); // You find a bag with 25,000 gold pieces.
            L0069: GiveItem(player, 0x33);
            L0075: PushStack(player, 0x46);
07E0  0079 C4 5E 06  les bx, [bp+0x6]
07E3  007C 26 FF 5F 48  call far word [es:bx+0x48]
            L0080: goto L00B5;
            L0082: ModifyGold(player, 0xFFFF30BA);
            L0094: SetFlag(player, 0x02, 0x43, 0x01);
            L00A9: ShowMessage(player, String0F74); // You are jumped by chaotic adventurers who steal 2,000 gold pieces.
            L00B6: return; // RETURN;
        }

        private void FnTOOLMSG_29(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0x57);
            L0011: if (JumpNotEqual) goto L0023;
            L0013: ax = HasItem(player, 0x58);
            L0021: if (JumpEqual) goto L004C;
0842  0023 FF 76 08  push word [bp+0x8]
0845  0026 FF 76 06  push word [bp+0x6]
0848  0029 0E     push cs
0849  002A E8 9D 0C  call 0xcca
            L002D: // NOP
            L002E: cx = PopStack(player);
            L002F: cx = PopStack(player);
084F  0030 FF 76 08  push word [bp+0x8]
0852  0033 FF 76 06  push word [bp+0x6]
0855  0036 0E     push cs
0856  0037 E8 D5 0C  call 0xd0f
            L003A: // NOP
            L003B: cx = PopStack(player);
            L003C: cx = PopStack(player);
            L003D: ShowMessage(player, String0FB7); // The fog lifts and you see the door to the Tool Shed.
            L004A: goto L0059;
086B  004C FF 76 08  push word [bp+0x8]
086E  004F FF 76 06  push word [bp+0x6]
0871  0052 0E     push cs
0872  0053 E8 97 0C  call 0xced
            L0056: // NOP
            L0057: cx = PopStack(player);
            L0058: cx = PopStack(player);
            L0059: return; // RETURN;
        }

        private void FnTNEPRES_2A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0xD9);
            L0011: if (JumpEqual) goto L0034;
088D  0013 B8 DC 05  mov ax, 0x5dc
            L0016: PushStack(player, ax);
            L0017: PushStack(player, 0x00);
            L001A: PushStack(player, ax);
            L001B: PushStack(player, ax);
            L001C: PushStack(player, 0xC4);
            L0020: PushStack(player, 0x9E);
089E  0024 C4 5E 06  les bx, [bp+0x6]
08A1  0027 26 FF 9F D8 00  call far word [es:bx+0xd8]
08A6  002C 83 C4 0C  add sp, 0xc
08A9  002F B8 EC 0F  mov ax, 0xfec
            L0032: goto L0056;
08AE  0034 B8 B8 0B  mov ax, 0xbb8
            L0037: PushStack(player, ax);
            L0038: PushStack(player, 0x00);
            L003B: PushStack(player, ax);
            L003C: PushStack(player, 0xC4);
            L0040: PushStack(player, 0xCC);
            L0044: PushStack(player, 0xD9);
08C2  0048 C4 5E 06  les bx, [bp+0x6]
08C5  004B 26 FF 9F D8 00  call far word [es:bx+0xd8]
08CA  0050 83 C4 0C  add sp, 0xc
            L0053: ShowMessage(player, String101C); // Vicious monsters stand guard over an S-shaped key.
            L0060: Compare(PartyCount(player), 0x0001);
            L006B: if (JumpNotEqual) goto L0086;
            L006D: PushStack(player, 0x01);
            L0071: PushStack(player, ax);
08EC  0072 C4 5E 06  les bx, [bp+0x6]
08EF  0075 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L007A: cx = PopStack(player);
            L007B: cx = PopStack(player);
            L007C: PushStack(player, 0x04);
08FA  0080 B8 02 00  mov ax, 0x2
            L0083: goto L0108;
            L0086: Compare(PartyCount(player), 0x0002);
            L0091: if (JumpNotEqual) goto L00BC;
            L0093: AddEncounter(player, 0x01, 0x02);
            L00A5: AddEncounter(player, 0x02, 0x1B);
0931  00B7 B8 05 00  mov ax, 0x5
            L00BA: goto L0104;
            L00BC: AddEncounter(player, 0x01, 0x02);
            L00CE: PushStack(player, 0x02);
            L00D2: PushStack(player, ax);
094D  00D3 C4 5E 06  les bx, [bp+0x6]
0950  00D6 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L00DB: cx = PopStack(player);
            L00DC: cx = PopStack(player);
            L00DD: AddEncounter(player, 0x04, 0x03);
            L00EF: AddEncounter(player, 0x05, 0x1A);
            L0101: AddEncounter(player, 0x06, 0x1B);
            L0113: return; // RETURN;
        }

        private void FnGARDMSG_2C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0x57);
            L0011: if (JumpNotEqual) goto L0023;
            L0013: ax = HasItem(player, 0x58);
            L0021: if (JumpEqual) goto L004C;
09B7  0023 FF 76 08  push word [bp+0x8]
09BA  0026 FF 76 06  push word [bp+0x6]
09BD  0029 0E     push cs
09BE  002A E8 28 0B  call 0xb55
            L002D: // NOP
            L002E: cx = PopStack(player);
            L002F: cx = PopStack(player);
09C4  0030 FF 76 08  push word [bp+0x8]
09C7  0033 FF 76 06  push word [bp+0x6]
09CA  0036 0E     push cs
09CB  0037 E8 60 0B  call 0xb9a
            L003A: // NOP
            L003B: cx = PopStack(player);
            L003C: cx = PopStack(player);
            L003D: ShowMessage(player, String104F); // The fog lifts and you see the door to the Gardener's Shed.
            L004A: goto L0059;
09E0  004C FF 76 08  push word [bp+0x8]
09E3  004F FF 76 06  push word [bp+0x6]
09E6  0052 0E     push cs
09E7  0053 E8 22 0B  call 0xb78
            L0056: // NOP
            L0057: cx = PopStack(player);
            L0058: cx = PopStack(player);
            L0059: return; // RETURN;
        }

        private void FnGARD_2D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0x44), 0x0001);
            L0017: if (JumpNotEqual) goto L0029;
0A08  0019 FF 76 08  push word [bp+0x8]
0A0B  001C FF 76 06  push word [bp+0x6]
0A0E  001F 0E     push cs
0A0F  0020 E8 72 0B  call 0xb95
            L0023: // NOP
            L0024: cx = PopStack(player);
            L0025: cx = PopStack(player);
            L0026: goto L00B5;
            L0029: RefreshCompareFlags(GetAlignment(player));
            L0033: if (JumpNotEqual) goto L0081;
            L0035: ModifyGold(player, 0x61A8);
            L0046: SetFlag(player, 0x02, 0x44, 0x01);
            L005B: ShowMessage(player, String0F4C); // You find a bag with 25,000 gold pieces.
            L0068: GiveItem(player, 0x21);
            L0074: PushStack(player, 0x04);
0A67  0078 C4 5E 06  les bx, [bp+0x6]
0A6A  007B 26 FF 5F 48  call far word [es:bx+0x48]
            L007F: goto L00B4;
            L0081: ModifyGold(player, 0xFFFF30BA);
            L0093: SetFlag(player, 0x02, 0x44, 0x01);
            L00A8: ShowMessage(player, String108A); // You are jumped by harmonic adventurers who steal 2,000 gold pieces.
            L00B5: return; // RETURN;
        }

        private void FnHLTHDWN_2E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0x58);
            L0011: if (JumpNotEqual) goto L0023;
            L0013: ax = HasItem(player, 0x57);
            L0021: if (JumpEqual) goto L0032;
            L0023: ShowMessage(player, String10CE); // Your guardian protects you from injury.
            L0030: goto L007B;
            L0032: PushStack(player, 0x01);
            L0036: PushStack(player, 0x00);
0ADF  0039 C4 5E 06  les bx, [bp+0x6]
0AE2  003C 26 FF 5F 04  call far word [es:bx+0x4]
            L0040: cx = PopStack(player);
            L0041: cx = PopStack(player);
            L0042: RefreshCompareFlags(ax);
            L0044: if (JumpNotEqual) goto L007B;
            L0046: ax = GetMaxHits(player);
            L004D: bx = 0x0005;
            L0050: dx = ax % bx; ax = ax / bx;
            L0053: DamagePlayer(player, ax);
            L005D: ShowMessage(player, String10F6); // A loose brick falls from the maze wall and injures you.
            L006A: PushStack(player, 0x01);
            L006E: PushStack(player, ax);
            L006F: PushStack(player, 0x00);
0B18  0072 C4 5E 06  les bx, [bp+0x6]
0B1B  0075 26 FF 1F  call far word [es:bx]
0B1E  0078 83 C4 06  add sp, 0x6
            L007B: return; // RETURN;
        }

        private void FnFTNMH_2F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: HealPlayer(player, GetMaxHits(player));
            L0014: AddMana(player, 0x2710);
            L0021: ShowMessage(player, String112E); // The swirling waters of the Whirlwind Pool increase your health and mana.
            L002E: return; // RETURN;
        }

        private void FnCLUEL_30(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1177); // Inside a quest bag you find a scribbled note to another adventurer...
            L0010: ShowMessage(player, String11BD); // 'Rumor has it that treasure might still be hidden in a safe.'
            L001D: return; // RETURN;
        }

        private void FnHARMDR_31(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0x58);
            L0011: if (JumpEqual) goto L0031;
0B85  0013 B8 E8 03  mov ax, 0x3e8
            L0016: PushStack(player, ax);
            L0017: PushStack(player, 0x00);
            L001A: PushStack(player, ax);
            L001B: PushStack(player, ax);
            L001C: PushStack(player, 0xCC);
            L0020: PushStack(player, 0xC2);
0B96  0024 C4 5E 06  les bx, [bp+0x6]
0B99  0027 26 FF 9F D8 00  call far word [es:bx+0xd8]
0B9E  002C 83 C4 0C  add sp, 0xc
            L002F: goto L0099;
            L0031: RefreshCompareFlags(GetAlignment(player));
            L003B: if (JumpNotEqual) goto L0061;
0BAF  003D B8 B8 0B  mov ax, 0xbb8
            L0040: PushStack(player, ax);
            L0041: PushStack(player, 0x00);
            L0044: PushStack(player, ax);
            L0045: PushStack(player, 0xCC);
            L0049: PushStack(player, 0xC3);
            L004D: PushStack(player, 0x58);
0BC3  0051 C4 5E 06  les bx, [bp+0x6]
0BC6  0054 26 FF 9F D8 00  call far word [es:bx+0xd8]
0BCB  0059 83 C4 0C  add sp, 0xc
0BCE  005C B8 FB 11  mov ax, 0x11fb
            L005F: goto L008F;
            L0061: AddExperience(player, 0xFFFFEC78);
            L0073: PushStack(player, 0x01);
            L0077: PushStack(player, 0x00);
            L007A: PushStack(player, ax);
            L007B: PushStack(player, ax);
            L007C: PushStack(player, ax);
            L007D: PushStack(player, 0xCB);
0BF3  0081 C4 5E 06  les bx, [bp+0x6]
0BF6  0084 26 FF 9F D8 00  call far word [es:bx+0xd8]
0BFB  0089 83 C4 0C  add sp, 0xc
            L008C: ShowMessage(player, String1232); // You lose experience for not heeding warnings.
            L0099: Compare(PartyCount(player), 0x0001);
            L00A4: if (JumpNotEqual) goto L00C2;
            L00A6: AddEncounter(player, 0x01, 0x06);
            L00B8: PushStack(player, 0x08);
0C2E  00BC B8 02 00  mov ax, 0x2
            L00BF: goto L0147;
            L00C2: Compare(PartyCount(player), 0x0002);
            L00CD: if (JumpNotEqual) goto L00F8;
            L00CF: AddEncounter(player, 0x01, 0x07);
            L00E1: AddEncounter(player, 0x02, 0x07);
0C65  00F3 B8 09 00  mov ax, 0x9
            L00F6: goto L0143;
            L00F8: AddEncounter(player, 0x01, 0x07);
            L010A: AddEncounter(player, 0x02, 0x07);
            L011C: AddEncounter(player, 0x04, 0x08);
            L012E: AddEncounter(player, 0x05, 0x08);
            L0140: AddEncounter(player, 0x06, 0x1C);
            L0152: return; // RETURN;
        }

        private void FnCLUEM_32(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0021);
            L0010: ShowMessage(player, String1260); // 'Excuse me? I'm trying to find the Ballroom. I must be completely lost.
            L001D: ShowMessage(player, String12A8); // Oh, if you ever find yourself in the Ballroom, make sure you have your musical key ready.'
            L002A: return; // RETURN;
        }

        private void FnCHADR_33(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0x57);
            L0011: if (JumpEqual) goto L0031;
0D05  0013 B8 E8 03  mov ax, 0x3e8
            L0016: PushStack(player, ax);
            L0017: PushStack(player, 0x00);
            L001A: PushStack(player, ax);
            L001B: PushStack(player, ax);
            L001C: PushStack(player, 0xCC);
            L0020: PushStack(player, 0xC2);
0D16  0024 C4 5E 06  les bx, [bp+0x6]
0D19  0027 26 FF 9F D8 00  call far word [es:bx+0xd8]
0D1E  002C 83 C4 0C  add sp, 0xc
            L002F: goto L009A;
            L0031: Compare(GetAlignment(player), 0x0001);
            L003C: if (JumpNotEqual) goto L0062;
0D30  003E B8 B8 0B  mov ax, 0xbb8
            L0041: PushStack(player, ax);
            L0042: PushStack(player, 0x00);
            L0045: PushStack(player, ax);
            L0046: PushStack(player, 0xCC);
            L004A: PushStack(player, 0xC3);
            L004E: PushStack(player, 0x57);
0D44  0052 C4 5E 06  les bx, [bp+0x6]
0D47  0055 26 FF 9F D8 00  call far word [es:bx+0xd8]
0D4C  005A 83 C4 0C  add sp, 0xc
0D4F  005D B8 03 13  mov ax, 0x1303
            L0060: goto L0090;
            L0062: AddExperience(player, 0xFFFFEC78);
            L0074: PushStack(player, 0x01);
            L0078: PushStack(player, 0x00);
            L007B: PushStack(player, ax);
            L007C: PushStack(player, ax);
            L007D: PushStack(player, ax);
            L007E: PushStack(player, 0xCB);
0D74  0082 C4 5E 06  les bx, [bp+0x6]
0D77  0085 26 FF 9F D8 00  call far word [es:bx+0xd8]
0D7C  008A 83 C4 0C  add sp, 0xc
            L008D: ShowMessage(player, String1232); // You lose experience for not heeding warnings.
            L009A: Compare(PartyCount(player), 0x0001);
            L00A5: if (JumpNotEqual) goto L00C3;
            L00A7: AddEncounter(player, 0x01, 0x06);
            L00B9: PushStack(player, 0x08);
0DAF  00BD B8 02 00  mov ax, 0x2
            L00C0: goto L0148;
            L00C3: Compare(PartyCount(player), 0x0002);
            L00CE: if (JumpNotEqual) goto L00F9;
            L00D0: AddEncounter(player, 0x01, 0x07);
            L00E2: AddEncounter(player, 0x02, 0x07);
0DE6  00F4 B8 09 00  mov ax, 0x9
            L00F7: goto L0144;
            L00F9: AddEncounter(player, 0x01, 0x07);
            L010B: AddEncounter(player, 0x02, 0x07);
            L011D: AddEncounter(player, 0x04, 0x08);
            L012F: AddEncounter(player, 0x05, 0x08);
            L0141: AddEncounter(player, 0x06, 0x1C);
            L0153: return; // RETURN;
        }

        private void FnDRMSG_34(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1340); // The door to the north bears a sign - 'Harmony Only.' The door to the west bears a sign - 'Chaos Only.'
            L0010: return; // RETURN;
        }

        private void FnHARMMSG_35(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetAlignment(player));
            L000D: if (JumpNotEqual) goto L001C;
            L000F: ShowMessage(player, String13A7); // A secret message for Harmonics only is posted on the door. 'Do not enter the Tool Shed.'
            L001C: return; // RETURN;
        }

        private void FnCHAMSG_36(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetAlignment(player), 0x0001);
            L000E: if (JumpNotEqual) goto L001D;
            L0010: ShowMessage(player, String1400); // A secret message for Chaotics only is posted on the door. 'Do not enter the Gardener's Shed.'
            L001D: return; // RETURN;
        }

        private void FnMEDA_37(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L002C;
            L0010: AddEncounter(player, 0x01, 0x22);
            L0022: PushStack(player, 0x27);
0EBC  0026 B8 02 00  mov ax, 0x2
            L0029: goto L00B5;
            L002C: Compare(PartyCount(player), 0x0002);
            L0037: if (JumpNotEqual) goto L0066;
            L0039: AddEncounter(player, 0x01, 0x11);
            L004B: AddEncounter(player, 0x02, 0x22);
            L005D: PushStack(player, 0x24);
0EF7  0061 B8 06 00  mov ax, 0x6
            L0064: goto L00B5;
            L0066: AddEncounter(player, 0x01, 0x11);
            L0078: AddEncounter(player, 0x02, 0x21);
            L008A: AddEncounter(player, 0x03, 0x25);
            L009C: AddEncounter(player, 0x04, 0x26);
            L00AE: AddEncounter(player, 0x05, 0x25);
            L00C0: return; // RETURN;
        }

        private void FnMEDB_38(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L0029;
            L0010: PushStack(player, 0x01);
            L0014: PushStack(player, ax);
0F6D  0015 C4 5E 06  les bx, [bp+0x6]
0F70  0018 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L001D: cx = PopStack(player);
            L001E: cx = PopStack(player);
            L001F: PushStack(player, 0x08);
0F7B  0023 B8 02 00  mov ax, 0x2
            L0026: goto L00AE;
            L0029: Compare(PartyCount(player), 0x0002);
            L0034: if (JumpNotEqual) goto L005F;
            L0036: AddEncounter(player, 0x01, 0x08);
            L0048: AddEncounter(player, 0x02, 0x09);
0FB2  005A B8 1A 00  mov ax, 0x1a
            L005D: goto L00AA;
            L005F: AddEncounter(player, 0x01, 0x1A);
            L0071: AddEncounter(player, 0x02, 0x1A);
            L0083: AddEncounter(player, 0x03, 0x1B);
            L0095: AddEncounter(player, 0x05, 0x08);
            L00A7: AddEncounter(player, 0x06, 0x1C);
            L00B9: return; // RETURN;
        }

        private void FnMEDC_39(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L002C;
            L0010: AddEncounter(player, 0x01, 0x0A);
            L0022: PushStack(player, 0x0D);
1039  0026 B8 02 00  mov ax, 0x2
            L0029: goto L00B5;
            L002C: Compare(PartyCount(player), 0x0002);
            L0037: if (JumpNotEqual) goto L0066;
            L0039: AddEncounter(player, 0x01, 0x0B);
            L004B: AddEncounter(player, 0x02, 0x0D);
            L005D: PushStack(player, 0x28);
1074  0061 B8 05 00  mov ax, 0x5
            L0064: goto L00B5;
            L0066: AddEncounter(player, 0x01, 0x0B);
            L0078: AddEncounter(player, 0x02, 0x0D);
            L008A: AddEncounter(player, 0x04, 0x0E);
            L009C: AddEncounter(player, 0x05, 0x1F);
            L00AE: AddEncounter(player, 0x06, 0x28);
            L00C0: return; // RETURN;
        }

        private void FnMEDD_3A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L002C;
            L0010: AddEncounter(player, 0x01, 0x27);
            L0022: PushStack(player, 0x11);
10FB  0026 B8 02 00  mov ax, 0x2
            L0029: goto L00B5;
            L002C: Compare(PartyCount(player), 0x0002);
            L0037: if (JumpNotEqual) goto L0066;
            L0039: AddEncounter(player, 0x01, 0x11);
            L004B: AddEncounter(player, 0x02, 0x11);
            L005D: PushStack(player, 0x13);
1136  0061 B8 03 00  mov ax, 0x3
            L0064: goto L00B5;
            L0066: AddEncounter(player, 0x01, 0x11);
            L0078: AddEncounter(player, 0x02, 0x11);
            L008A: AddEncounter(player, 0x03, 0x13);
            L009C: AddEncounter(player, 0x04, 0x22);
            L00AE: AddEncounter(player, 0x06, 0x23);
            L00C0: return; // RETURN;
        }

        private void FnHRDA_3B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L002C;
            L0010: AddEncounter(player, 0x01, 0x08);
            L0022: PushStack(player, 0x0C);
11BD  0026 B8 02 00  mov ax, 0x2
            L0029: goto L00C7;
            L002C: Compare(PartyCount(player), 0x0002);
            L0037: if (JumpNotEqual) goto L0078;
            L0039: AddEncounter(player, 0x01, 0x08);
            L004B: AddEncounter(player, 0x02, 0x09);
            L005D: AddEncounter(player, 0x03, 0x0D);
            L006F: PushStack(player, 0x1E);
120A  0073 B8 04 00  mov ax, 0x4
            L0076: goto L00C7;
            L0078: AddEncounter(player, 0x01, 0x09);
            L008A: AddEncounter(player, 0x02, 0x1D);
            L009C: AddEncounter(player, 0x03, 0x0D);
            L00AE: AddEncounter(player, 0x05, 0x1C);
            L00C0: AddEncounter(player, 0x06, 0x10);
            L00D2: return; // RETURN;
        }

        private void FnEZA_3C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L0026;
            L0010: PushStack(player, 0x01);
            L0014: PushStack(player, ax);
1280  0015 C4 5E 06  les bx, [bp+0x6]
1283  0018 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L001D: cx = PopStack(player);
            L001E: cx = PopStack(player);
            L001F: PushStack(player, 0x02);
            L0023: goto L00B7;
            L0026: Compare(PartyCount(player), 0x0002);
            L0031: if (JumpNotEqual) goto L006B;
            L0033: PushStack(player, 0x01);
            L0037: PushStack(player, ax);
12A3  0038 C4 5E 06  les bx, [bp+0x6]
12A6  003B 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L0040: cx = PopStack(player);
            L0041: cx = PopStack(player);
            L0042: AddEncounter(player, 0x02, 0x01);
            L0054: AddEncounter(player, 0x05, 0x02);
12D1  0066 B8 03 00  mov ax, 0x3
            L0069: goto L00B3;
            L006B: AddEncounter(player, 0x01, 0x02);
            L007D: PushStack(player, 0x02);
            L0081: PushStack(player, ax);
12ED  0082 C4 5E 06  les bx, [bp+0x6]
12F0  0085 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L008A: cx = PopStack(player);
            L008B: cx = PopStack(player);
            L008C: AddEncounter(player, 0x04, 0x1B);
            L009E: AddEncounter(player, 0x05, 0x04);
            L00B0: AddEncounter(player, 0x06, 0x19);
            L00C2: return; // RETURN;
        }

        private void FnEZB_3D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L002C;
            L0010: AddEncounter(player, 0x01, 0x27);
            L0022: PushStack(player, 0x27);
1355  0026 B8 02 00  mov ax, 0x2
            L0029: goto L00C7;
            L002C: Compare(PartyCount(player), 0x0002);
            L0037: if (JumpNotEqual) goto L0078;
            L0039: AddEncounter(player, 0x01, 0x10);
            L004B: AddEncounter(player, 0x02, 0x10);
            L005D: AddEncounter(player, 0x03, 0x11);
            L006F: PushStack(player, 0x12);
13A2  0073 B8 04 00  mov ax, 0x4
            L0076: goto L00C7;
            L0078: AddEncounter(player, 0x01, 0x24);
            L008A: AddEncounter(player, 0x02, 0x15);
            L009C: AddEncounter(player, 0x03, 0x14);
            L00AE: AddEncounter(player, 0x05, 0x1C);
            L00C0: AddEncounter(player, 0x06, 0x08);
            L00D2: return; // RETURN;
        }

        private void FnHRDB_3E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L002C;
            L0010: AddEncounter(player, 0x01, 0x17);
            L0022: PushStack(player, 0x0D);
1429  0026 B8 02 00  mov ax, 0x2
            L0029: goto L00B5;
            L002C: Compare(PartyCount(player), 0x0002);
            L0037: if (JumpNotEqual) goto L0066;
            L0039: AddEncounter(player, 0x01, 0x1D);
            L004B: AddEncounter(player, 0x02, 0x1D);
            L005D: PushStack(player, 0x17);
1464  0061 B8 05 00  mov ax, 0x5
            L0064: goto L00B5;
            L0066: AddEncounter(player, 0x01, 0x1D);
            L0078: AddEncounter(player, 0x02, 0x1D);
            L008A: AddEncounter(player, 0x03, 0x1E);
            L009C: AddEncounter(player, 0x05, 0x18);
            L00AE: AddEncounter(player, 0x06, 0x26);
            L00C0: return; // RETURN;
        }

        private void Fn_3F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: return; // RETURN;
            // Extra data: 55 8B EC B8 5E 14 50 C4 5E 06 26 FF 9F F8 00 59 B8 C8 14 50 C4 5E 06 26 FF 9F F8 00 59 5D CB 55 8B EC B8 01 00 50 C4 5E 06 26 FF 5F 24 50 C4 5E 06 26 FF 5F 20 50 C4 5E 06 26 FF 5F 2C 83 C4 06 5D CB 55 8B EC 33 C0 50 C4 5E 06 26 FF 5F 24 50 C4 5E 06 26 FF 5F 20 50 C4 5E 06 26 FF 5F 2C 83 C4 06 5D CB 55 8B EC C4 5E 06 26 FF 5F 24 50 C4 5E 06 26 FF 5F 20 50 B8 01 00 50 C4 5E 06 26 FF 5F 30 83 C4 06 5D CB 55 8B EC B8 D2 00 50 C4 5E 06 26 FF 5F 4C 59 B8 CF 00 50 C4 5E 06 26 FF 5F 4C 59 5D CB 55 8B EC C4 5E 06 26 FF 5F 74 50 C4 5E 06 26 FF 9F 90 00 59 5D CB 55 8B EC B8 07 15 50 C4 5E 06 26 FF 9F F8 00 59 5D CB 
        }

    }
}
