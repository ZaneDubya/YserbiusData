#pragma warning disable
using System.Collections.Generic;
using XPT.WorldData;
using XPT.WorldData.Yserbius;

namespace XPT.Scripts.Yserbius.Maps {
    class YserMap10 : AMapScripted {
        protected override int MapIndex => 10;
        protected override int RandomEncounterChance => 10;
        protected override int RandomEncounterExtraCount => 0;

        public YserMap10() {
            MapEvent01 = FnWIZARD_01;
            MapEvent02 = FnCLERIC_02;
            MapEvent03 = FnTELEA_03;
            MapEvent04 = FnAZAP_04;
            MapEvent05 = FnTHIEF_05;
            MapEvent06 = FnCLUEA_06;
            MapEvent07 = FnTEXTA_07;
            MapEvent08 = FnFTN_08;
            MapEvent09 = FnITEMADR_09;
            MapEvent0A = FnTELEC_0A;
            MapEvent0B = FnFTNA_0B;
            MapEvent0C = FnCLUEB_0C;
            MapEvent0E = FnTELED_0E;
            MapEvent10 = FnSECA_10;
            MapEvent13 = FnTELEF_13;
            MapEvent14 = FnMANADOWN_14;
            MapEvent15 = FnITEMA_15;
            MapEvent16 = FnKEY_16;
            MapEvent17 = FnFELLOW_17;
            MapEvent1A = FnBZAP_1A;
            MapEvent1C = FnHEALDOWN_1C;
            MapEvent1D = FnITEMC_1D;
            MapEvent1F = FnTELEG_1F;
            MapEvent22 = FnWIZDOOR_22;
            MapEvent23 = FnWIZTELE_23;
            MapEvent25 = FnFTNB_25;
            MapEvent26 = FnCLEDR_26;
            MapEvent27 = FnCLETELE_27;
            MapEvent28 = FnITEMCDR_28;
            MapEvent29 = FnITEMBDR_29;
            MapEvent2A = FnTHDR_2A;
            MapEvent2B = FnTHTELE_2B;
            MapEvent2C = FnTELEH_2C;
            MapEvent2D = FnLOCK_2D;
            MapEvent2E = FnSTRENGTH_2E;
            MapEvent2F = FnCLUEE_2F;
            MapEvent30 = FnRADR_30;
            MapEvent31 = FnRATELE_31;
            MapEvent32 = FnTELEI_32;
            MapEvent33 = FnKNDR_33;
            MapEvent34 = FnKNTELE_34;
            MapEvent35 = FnITEMD_35;
            MapEvent36 = FnITEMB_36;
            MapEvent37 = FnGOODIEA_37;
            MapEvent38 = FnTELEJ_38;
            MapEvent39 = FnBADOOR_39;
            MapEvent3A = FnBATELE_3A;
            MapEvent3B = FnFELLDOOR_3B;
            MapEvent3D = FnKNIGHT_3D;
            MapEvent3F = FnTELEK_3F;
            MapEvent41 = FnRANGER_41;
            MapEvent43 = FnBARB_43;
            MapEvent44 = FnEZA_44;
            MapEvent45 = FnMEDA_45;
            MapEvent46 = FnHRDA_46;
            MapEvent47 = FnEZB_47;
            MapEvent49 = FnMEDB_49;
            MapEvent4A = FnEZC_4A;
            MapEvent4B = FnMEDC_4B;
            MapEvent4C = Fn_4C;
        }
        
        // === Strings ================================================
        private const string String03FC = "Only Wizards gain their reward here.";
        private const string String0421 = "Only Clerics gain their reward here.";
        private const string String0446 = "The trap is disarmed.";
        private const string String045C = "A trap unleashes a shower of arrows at you.";
        private const string String0488 = "Only Thieves gain their reward here.";
        private const string String04AD = "A message on the wall - 'One of your party members must stay in the Armory until light is shed on your purpose. He who remains must at least lead once upon your return. Then, you may alter your formation.'";
        private const string String057B = "Do not proceed north unless you have disarmed the traps.";
        private const string String05B4 = "The waters of Grimoire Fountain have no affect.";
        private const string String05E4 = "The magical waters of Grimoire Fountain enlighten you in the art of healing.";
        private const string String0631 = "The magical waters of Grimoire Fountain turn cold as you acquire the Hail spell.";
        private const string String0682 = "The magical waters of Grimoire Fountain envelop you in a mystic aura which whispers its secrets in your ear.";
        private const string String06EF = "The magical waters of Grimoire Fountain envelop you in a shroud of light.";
        private const string String0739 = "The door swings open.";
        private const string String074F = "The door to the south is locked.";
        private const string String0770 = "The piercing waters of Saber Fountain restore you to full health.";
        private const string String07B2 = "Debris litters the floor, a result of the prodding and poking of the walls by adventurers searching for secret doors.";
        private const string String0828 = "A hidden door appears.";
        private const string String083F = "You detect a secret door.";
        private const string String0859 = "Miasmal gases seep up through the floor, sapping your mana.";
        private const string String0895 = "You bump into a shield in the center of the room.";
        private const string String08C7 = "It falls and hits a switch which unlocks a door and disarms traps.";
        private const string String090A = "The armorer has taken your key and forged you another. It can be found from whence the original came. This key will enable you to access new doors.";
        private const string String099E = "The Fellowship Key unlocks the door.";
        private const string String09C3 = "The door is locked. On the door is a plaque, showing two arms clasped in friendship.";
        private const string String0A18 = "Your helm protects you from the poisonous darts.";
        private const string String0A49 = "Your helm is no protection from the poisonous darts that hit you.";
        private const string String0A8B = "A loose shield that is mounted on the wall falls and smacks you on the head.";
        private const string String0AD8 = "Your foot brushes a stick, which you see is actually a wand.";
        private const string String0B15 = "As it begins to glow, you hear the unlocking of a door.";
        private const string String0B4D = "The silvery waters of Trident Fountain replenish your mana.";
        private const string String0B89 = "The silvery waters of Trident Fountain replenish your mana and empower you with the Resist spell.";
        private const string String0BEB = "The silvery waters of Trident Fountain replenish your mana and empower you with the Shield spell.";
        private const string String0C4D = "The door is open.";
        private const string String0C5F = "The magic wand sign on the door has been zapped.";
        private const string String0C90 = "The door is locked.";
        private const string String0CA4 = "Upon the door is the sign of a magic wand. If the wand is zapped, the door will open.";
        private const string String0CFA = "Someone has scrawled under the sign - 'When the wand is zapped, stay in the area until you open the door.'";
        private const string String0D65 = "The guard sees your Spidersilk Helm and lets you enter.";
        private const string String0D9D = "You see a guard at the door wiping tiny spiders from his helmet:";
        private const string String0DDE = "'My hat's off to you,' he says, barking a shrill laugh.";
        private const string String0E16 = "'The right helm lets you pass. The wrong helm won't.'";
        private const string String0E4C = "You skillfully unlock the door.";
        private const string String0E6C = "After considerable effort, you manage to force open the door.";
        private const string String0EAA = "You are not strong enough to open the door.";
        private const string String0ED6 = "You cannot find the strength to push open the door.";
        private const string String0F0A = "A knight mumbles to himself -";
        private const string String0F28 = "'Confusing li'l thief. He's obviously been in the lower depths of this bizarre Night Elf kingdom.'";
        private const string String0F8B = "The knight notices you and turns to you.";
        private const string String0FB4 = "'The dralks...or some such thing, they are what these Elves worship.'";
        private const string String0FFA = "To The Vault.";
        private const string String1008 = "A Lantern lies on the floor. It will help during your future explorations. Mark well that it was here when you needed it!";
        private const string String1082 = "The Troll Cleric, seeing you are well protected, decides to leave.";
        private const string String10C5 = "A Troll Cleric grabs your arm -";
        private const string String10E5 = "'You will want this helm of protection to safeguard you on your journey.";
        private const string String112E = "It's sure to impress some of the guards you'll meet in your journeys.";
        private const string String1174 = "No need to thank me. I've taken..er..accepted your generous donation already.'";
        private const string String11C3 = "A band of Night Elves tries to steal your armor.";
        private const string String11F4 = "Fellowship Meeting Hall";
        private const string String120C = "Only Knights gain their reward here.";
        private const string String1231 = "Only Rangers gain their reward here.";
        private const string String1256 = "Only Barbarians gain their reward here.";
        private const string String127E = "Congratulations, you have found a secret armory room.";
        private const string String12B4 = "In exchange, you must sacrifice the bone and your Fellowship!";
        private const string String12F2 = "This Guild armor and experience will help you on your journey.";
        private const string String1331 = "The room appears to have been looted.";
        private const string String1357 = "Here's a replacement for your lost armor.";
        private const string String1381 = "Your Skeleton Key unlocks the door.";
        private const string String13A5 = "The door is locked. Someone has painted a skull and crossed arm bones on the door.";
        
        // === Functions ================================================
        private void FnWIZARD_01(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: // make space for tmp on stack: sp -= 2
            L0005: dx = GetFlag(player, 0x02, 0x45) + GetFlag(player, 0x02, 0x47);
            L002B: tmp = dx;
            L002E: Compare(GetGuild(player), 0x0005);
            L0038: if (JumpEqual) goto L003D;
            L003A: goto L00C1;
0045  003D FF 76 08  push word [bp+0x8]
0048  0040 FF 76 06  push word [bp+0x6]
004B  0043 0E     push cs
004C  0044 E8 0D 16  call 0x1654
            L0047: // NOP
            L0048: cx = PopStack(player);
            L0049: cx = PopStack(player);
            L004A: Compare(tmp, 0x0001);
            L0050: if (JumpEqual) goto L005E;
            L0052: Compare(ax, 0x0002);
            L0055: if (JumpEqual) goto L0078;
            L0057: Compare(ax, 0x0003);
            L005A: if (JumpEqual) goto L00B2;
            L005C: goto L00CE;
0066  005E FF 76 08  push word [bp+0x8]
0069  0061 FF 76 06  push word [bp+0x6]
006C  0064 0E     push cs
006D  0065 E8 23 16  call 0x168b
            L0068: // NOP
            L0069: cx = PopStack(player);
            L006A: cx = PopStack(player);
            L006B: PushStack(player, 0x7C);
0077  006F C4 5E 06  les bx, [bp+0x6]
007A  0072 26 FF 5F 48  call far word [es:bx+0x48]
            L0076: goto L00CD;
            L0078: ax = HasItem(player, 0x7C);
            L0086: if (JumpEqual) goto L0097;
0090  0088 FF 76 08  push word [bp+0x8]
0093  008B FF 76 06  push word [bp+0x6]
0096  008E 0E     push cs
0097  008F E8 31 16  call 0x16c3
            L0092: // NOP
            L0093: cx = PopStack(player);
            L0094: cx = PopStack(player);
            L0095: goto L00CE;
            L0097: GiveItem(player, 0x7C);
00AB  00A3 FF 76 08  push word [bp+0x8]
00AE  00A6 FF 76 06  push word [bp+0x6]
00B1  00A9 0E     push cs
00B2  00AA E8 28 16  call 0x16d5
            L00AD: // NOP
            L00AE: cx = PopStack(player);
            L00AF: cx = PopStack(player);
            L00B0: goto L00CE;
00BA  00B2 FF 76 08  push word [bp+0x8]
00BD  00B5 FF 76 06  push word [bp+0x6]
00C0  00B8 0E     push cs
00C1  00B9 E8 07 16  call 0x16c3
            L00BC: // NOP
            L00BD: cx = PopStack(player);
            L00BE: cx = PopStack(player);
            L00BF: goto L00CE;
            L00C1: ShowMessage(player, String03FC); // Only Wizards gain their reward here.
            L00CE: // restore stack ptr: sp = bp;
            L00D0: return; // RETURN;
        }

        private void FnCLERIC_02(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: // make space for tmp on stack: sp -= 2
            L0005: dx = GetFlag(player, 0x02, 0x45) + GetFlag(player, 0x02, 0x47);
            L002B: tmp = dx;
            L002E: Compare(GetGuild(player), 0x0004);
            L0038: if (JumpEqual) goto L003D;
            L003A: goto L00C1;
0117  003D FF 76 08  push word [bp+0x8]
011A  0040 FF 76 06  push word [bp+0x6]
011D  0043 0E     push cs
011E  0044 E8 3B 15  call 0x1582
            L0047: // NOP
            L0048: cx = PopStack(player);
            L0049: cx = PopStack(player);
            L004A: Compare(tmp, 0x0001);
            L0050: if (JumpEqual) goto L005E;
            L0052: Compare(ax, 0x0002);
            L0055: if (JumpEqual) goto L0078;
            L0057: Compare(ax, 0x0003);
            L005A: if (JumpEqual) goto L00B2;
            L005C: goto L00CE;
0138  005E FF 76 08  push word [bp+0x8]
013B  0061 FF 76 06  push word [bp+0x6]
013E  0064 0E     push cs
013F  0065 E8 51 15  call 0x15b9
            L0068: // NOP
            L0069: cx = PopStack(player);
            L006A: cx = PopStack(player);
            L006B: PushStack(player, 0x7B);
0149  006F C4 5E 06  les bx, [bp+0x6]
014C  0072 26 FF 5F 48  call far word [es:bx+0x48]
            L0076: goto L00CD;
            L0078: ax = HasItem(player, 0x7B);
            L0086: if (JumpEqual) goto L0097;
0162  0088 FF 76 08  push word [bp+0x8]
0165  008B FF 76 06  push word [bp+0x6]
0168  008E 0E     push cs
0169  008F E8 5F 15  call 0x15f1
            L0092: // NOP
            L0093: cx = PopStack(player);
            L0094: cx = PopStack(player);
            L0095: goto L00CE;
            L0097: GiveItem(player, 0x7B);
017D  00A3 FF 76 08  push word [bp+0x8]
0180  00A6 FF 76 06  push word [bp+0x6]
0183  00A9 0E     push cs
0184  00AA E8 56 15  call 0x1603
            L00AD: // NOP
            L00AE: cx = PopStack(player);
            L00AF: cx = PopStack(player);
            L00B0: goto L00CE;
018C  00B2 FF 76 08  push word [bp+0x8]
018F  00B5 FF 76 06  push word [bp+0x6]
0192  00B8 0E     push cs
0193  00B9 E8 35 15  call 0x15f1
            L00BC: // NOP
            L00BD: cx = PopStack(player);
            L00BE: cx = PopStack(player);
            L00BF: goto L00CE;
            L00C1: ShowMessage(player, String0421); // Only Clerics gain their reward here.
            L00CE: // restore stack ptr: sp = bp;
            L00D0: return; // RETURN;
        }

        private void FnTELEA_03(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x04, 0x03, 0xC9, 0x03, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnAZAP_04(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetNoHealZone(player);
            L000B: PushStack(player, 0x04);
            L000F: PushStack(player, 0x00);
01DE  0012 C4 5E 06  les bx, [bp+0x6]
01E1  0015 26 FF 5F 04  call far word [es:bx+0x4]
            L0019: cx = PopStack(player);
            L001A: cx = PopStack(player);
            L001B: RefreshCompareFlags(ax);
            L001D: if (JumpNotEqual) goto L007C;
            L001F: Compare(GetFlag(player, 0x03, 0x02), 0x0001);
            L0033: if (JumpNotEqual) goto L0044;
            L0035: ShowMessage(player, String0446); // The trap is disarmed.
            L0042: goto L007C;
            L0044: ax = GetMaxHits(player);
            L004B: bx = 0x0002;
            L004E: dx = ax % bx; ax = ax / bx;
            L0051: DamagePlayer(player, ax);
            L005B: ShowMessage(player, String045C); // A trap unleashes a shower of arrows at you.
            L0068: SetFlag(player, 0x00, 0x04, 0x01);
            L007C: return; // RETURN;
        }

        private void FnTHIEF_05(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: // make space for tmp on stack: sp -= 2
            L0005: dx = GetFlag(player, 0x02, 0x45) + GetFlag(player, 0x02, 0x47);
            L002B: tmp = dx;
            L002E: Compare(GetGuild(player), 0x0003);
            L0038: if (JumpEqual) goto L003D;
            L003A: goto L00C1;
0287  003D FF 76 08  push word [bp+0x8]
028A  0040 FF 76 06  push word [bp+0x6]
028D  0043 0E     push cs
028E  0044 E8 CB 13  call 0x1412
            L0047: // NOP
            L0048: cx = PopStack(player);
            L0049: cx = PopStack(player);
            L004A: Compare(tmp, 0x0001);
            L0050: if (JumpEqual) goto L005E;
            L0052: Compare(ax, 0x0002);
            L0055: if (JumpEqual) goto L0078;
            L0057: Compare(ax, 0x0003);
            L005A: if (JumpEqual) goto L00B2;
            L005C: goto L00CE;
02A8  005E FF 76 08  push word [bp+0x8]
02AB  0061 FF 76 06  push word [bp+0x6]
02AE  0064 0E     push cs
02AF  0065 E8 E1 13  call 0x1449
            L0068: // NOP
            L0069: cx = PopStack(player);
            L006A: cx = PopStack(player);
            L006B: PushStack(player, 0x7A);
02B9  006F C4 5E 06  les bx, [bp+0x6]
02BC  0072 26 FF 5F 48  call far word [es:bx+0x48]
            L0076: goto L00CD;
            L0078: ax = HasItem(player, 0x7A);
            L0086: if (JumpEqual) goto L0097;
02D2  0088 FF 76 08  push word [bp+0x8]
02D5  008B FF 76 06  push word [bp+0x6]
02D8  008E 0E     push cs
02D9  008F E8 EF 13  call 0x1481
            L0092: // NOP
            L0093: cx = PopStack(player);
            L0094: cx = PopStack(player);
            L0095: goto L00CE;
            L0097: GiveItem(player, 0x7A);
02ED  00A3 FF 76 08  push word [bp+0x8]
02F0  00A6 FF 76 06  push word [bp+0x6]
02F3  00A9 0E     push cs
02F4  00AA E8 E6 13  call 0x1493
            L00AD: // NOP
            L00AE: cx = PopStack(player);
            L00AF: cx = PopStack(player);
            L00B0: goto L00CE;
02FC  00B2 FF 76 08  push word [bp+0x8]
02FF  00B5 FF 76 06  push word [bp+0x6]
0302  00B8 0E     push cs
0303  00B9 E8 C5 13  call 0x1481
            L00BC: // NOP
            L00BD: cx = PopStack(player);
            L00BE: cx = PopStack(player);
            L00BF: goto L00CE;
            L00C1: ShowMessage(player, String0488); // Only Thieves gain their reward here.
            L00CE: // restore stack ptr: sp = bp;
            L00D0: return; // RETURN;
        }

        private void FnCLUEA_06(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String04AD); // A message on the wall - 'One of your party members must stay in the Armory until light is shed on your purpose. He who remains must at least lead once upon your return. Then, you may alter your formation.'
            L0010: return; // RETURN;
        }

        private void FnTEXTA_07(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String057B); // Do not proceed north unless you have disarmed the traps.
            L0010: return; // RETURN;
        }

        private void FnFTN_08(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0042);
            L0010: Compare(GetFlag(player, 0x02, 0x63), 0x0001);
            L0024: if (JumpNotEqual) goto L002C;
0366  0026 B8 B4 05  mov ax, 0x5b4
            L0029: goto L00FB;
            L002C: Compare(GetGuild(player), 0x0001);
            L0036: if (JumpNotEqual) goto L0064;
            L0038: SetFlag(player, 0x02, 0x63, 0x01);
            L004D: SetSpellLevel(player, 0x14, 0x01);
039E  005E B8 E4 05  mov ax, 0x5e4
            L0061: goto L00FB;
            L0064: Compare(GetGuild(player), 0x0003);
            L006E: if (JumpNotEqual) goto L009B;
            L0070: SetFlag(player, 0x02, 0x63, 0x01);
            L0085: SetSpellLevel(player, 0x07, 0x01);
03D6  0096 B8 31 06  mov ax, 0x631
            L0099: goto L00FB;
            L009B: Compare(GetGuild(player), 0x0005);
            L00A5: if (JumpNotEqual) goto L00D2;
            L00A7: SetFlag(player, 0x02, 0x63, 0x01);
            L00BC: SetSpellLevel(player, 0x0C, 0x01);
040D  00CD B8 82 06  mov ax, 0x682
            L00D0: goto L00FB;
            L00D2: SetFlag(player, 0x02, 0x63, 0x01);
            L00E7: SetSpellLevel(player, 0x0D, 0x01);
            L00F8: ShowMessage(player, String06EF); // The magical waters of Grimoire Fountain envelop you in a shroud of light.
            L0105: return; // RETURN;
        }

        private void FnITEMADR_09(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x02), 0x0001);
            L0017: if (JumpNotEqual) goto L0035;
0460  0019 FF 76 08  push word [bp+0x8]
0463  001C FF 76 06  push word [bp+0x6]
0466  001F 0E     push cs
0467  0020 E8 9A 12  call 0x12bd
            L0023: // NOP
            L0024: cx = PopStack(player);
            L0025: cx = PopStack(player);
            L0026: ShowMessage(player, String0739); // The door swings open.
            L0033: goto L004F;
            L0035: ShowMessage(player, String074F); // The door to the south is locked.
0489  0042 FF 76 08  push word [bp+0x8]
048C  0045 FF 76 06  push word [bp+0x6]
048F  0048 0E     push cs
0490  0049 E8 B2 12  call 0x12fe
            L004C: // NOP
            L004D: cx = PopStack(player);
            L004E: cx = PopStack(player);
            L004F: return; // RETURN;
        }

        private void FnTELEC_0A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x04, 0x03, 0x71, 0x02, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnFTNA_0B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0042);
            L0010: HealPlayer(player, GetMaxHits(player));
            L0021: ShowMessage(player, String0770); // The piercing waters of Saber Fountain restore you to full health.
            L002E: return; // RETURN;
        }

        private void FnCLUEB_0C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String07B2); // Debris litters the floor, a result of the prodding and poking of the walls by adventurers searching for secret doors.
            L0010: return; // RETURN;
        }

        private void FnTELED_0E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x04, 0x03, 0xF5, 0x00, isForwardMove);
            L001D: return; // RETURN;
        }

        private void FnSECA_10(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: // make space for tmp on stack: sp -= 2
            L0005: Compare(HasUsedSkill(player, 0x0D), 0x0005);
            L0014: if (JumpNotBelow) goto L006E;
            L0016: RefreshCompareFlags(HasUsedSpell(player, 0x17));
            L0024: if (JumpNotEqual) goto L006E;
            L0026: PushStack(player, 0x68);
            L002A: PushStack(player, ax);
054E  002B C4 5E 06  les bx, [bp+0x6]
0551  002E 26 FF 5F 54  call far word [es:bx+0x54]
            L0032: cx = PopStack(player);
            L0033: cx = PopStack(player);
            L0034: RefreshCompareFlags(ax);
            L0036: if (JumpNotEqual) goto L006E;
            L0038: PushStack(player, 0x6E);
            L003C: PushStack(player, ax);
0560  003D C4 5E 06  les bx, [bp+0x6]
0563  0040 26 FF 5F 54  call far word [es:bx+0x54]
            L0044: cx = PopStack(player);
            L0045: cx = PopStack(player);
            L0046: RefreshCompareFlags(ax);
            L0048: if (JumpNotEqual) goto L006E;
            L004A: PushStack(player, 0x90);
            L004E: PushStack(player, ax);
0572  004F C4 5E 06  les bx, [bp+0x6]
0575  0052 26 FF 5F 54  call far word [es:bx+0x54]
            L0056: cx = PopStack(player);
            L0057: cx = PopStack(player);
            L0058: RefreshCompareFlags(ax);
            L005A: if (JumpNotEqual) goto L006E;
            L005C: PushStack(player, 0xA4);
            L0060: PushStack(player, ax);
0584  0061 C4 5E 06  les bx, [bp+0x6]
0587  0064 26 FF 5F 54  call far word [es:bx+0x54]
            L0068: cx = PopStack(player);
            L0069: cx = PopStack(player);
            L006A: RefreshCompareFlags(ax);
            L006C: if (JumpEqual) goto L00AF;
            L006E: ax = GetCurrentTile(player);
0598  0075 89 46 FE  mov [bp-0x2], ax
059B  0078 B9 04 00  mov cx, 0x4
            L007B: bx = 0x05E3;
05A1  007E 2E 8B 07  mov ax, [cs:bx]
05A4  0081 3B 46 FE  cmp ax, [bp-0x2]
            L0084: if (JumpEqual) goto L008C;
05A9  0086 43     inc bx
05AA  0087 43     inc bx
05AB  0088 E2 F4  loop 0x7e
            L008A: goto L00AA;
05AF  008C 2E FF 67 08  jmp word [cs:bx+0x8]
            L0090: ShowMessage(player, String0828); // A hidden door appears.
05C0  009D FF 76 08  push word [bp+0x8]
05C3  00A0 FF 76 06  push word [bp+0x6]
05C6  00A3 0E     push cs
05C7  00A4 E8 3A 11  call 0x11e1
            L00A7: // NOP
            L00A8: goto L00BA;
05CD  00AA B8 3F 08  mov ax, 0x83f
            L00AD: goto L0093;
05D2  00AF FF 76 08  push word [bp+0x8]
05D5  00B2 FF 76 06  push word [bp+0x6]
05D8  00B5 0E     push cs
05D9  00B6 E8 69 11  call 0x1222
            L00B9: // NOP
            L00BA: cx = PopStack(player);
            L00BB: cx = PopStack(player);
            L00BC: // restore stack ptr: sp = bp;
            L00BE: return; // RETURN;
            // Extra data: 36 00 4D 00 57 00 E2 00 B3 05 B3 05 B3 05 B3 05 
        }

        private void FnTELEF_13(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x04, 0x03, 0xC7, 0x01, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnMANADOWN_14(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddMana(player, 0xFF38);
            L0010: ShowMessage(player, String0859); // Miasmal gases seep up through the floor, sapping your mana.
            L001D: return; // RETURN;
        }

        private void FnITEMA_15(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFlag(player, 0x03, 0x02, 0x01);
            L0018: ShowMessage(player, String0895); // You bump into a shield in the center of the room.
            L0025: ShowMessage(player, String08C7); // It falls and hits a switch which unlocks a door and disarms traps.
            L0032: return; // RETURN;
        }

        private void FnKEY_16(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0x45), 0x0001);
            L0017: if (JumpNotEqual) goto L0026;
            L0019: ShowMessage(player, String090A); // The armorer has taken your key and forged you another. It can be found from whence the original came. This key will enable you to access new doors.
            L0026: return; // RETURN;
        }

        private void FnFELLOW_17(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0xD8);
            L0007: PushStack(player, ax);
06A0  0008 C4 5E 06  les bx, [bp+0x6]
06A3  000B 26 FF 5F 54  call far word [es:bx+0x54]
            L000F: cx = PopStack(player);
            L0010: cx = PopStack(player);
            L0011: RefreshCompareFlags(ax);
            L0013: if (JumpEqual) goto L0027;
06AD  0015 FF 76 08  push word [bp+0x8]
06B0  0018 FF 76 06  push word [bp+0x6]
06B3  001B 0E     push cs
06B4  001C E8 4D 10  call 0x106c
            L001F: // NOP
            L0020: cx = PopStack(player);
            L0021: cx = PopStack(player);
06BA  0022 B8 9E 09  mov ax, 0x99e
            L0025: goto L0037;
06BF  0027 FF 76 08  push word [bp+0x8]
06C2  002A FF 76 06  push word [bp+0x6]
06C5  002D 0E     push cs
06C6  002E E8 7C 10  call 0x10ad
            L0031: // NOP
            L0032: cx = PopStack(player);
            L0033: cx = PopStack(player);
            L0034: ShowMessage(player, String09C3); // The door is locked. On the door is a plaque, showing two arms clasped in friendship.
            L0041: return; // RETURN;
        }

        private void FnBZAP_1A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0x67);
            L0011: if (JumpEqual) goto L0018;
06F8  0013 B8 18 0A  mov ax, 0xa18
            L0016: goto L004A;
            L0018: ax = GetMaxHits(player);
            L001F: bx = 0x0002;
            L0022: dx = ax % bx; ax = ax / bx;
            L0025: PushStack(player, ax);
            L0026: PushStack(player, 0x05);
            L002A: PushStack(player, 0x01);
0713  002E C4 5E 06  les bx, [bp+0x6]
0716  0031 26 FF 9F 9C 00  call far word [es:bx+0x9c]
071B  0036 83 C4 06  add sp, 0x6
071E  0039 C4 5E 06  les bx, [bp+0x6]
0721  003C 26 FF 5F 3C  call far word [es:bx+0x3c]
0725  0040 C4 5E 06  les bx, [bp+0x6]
0728  0043 26 FF 5F 40  call far word [es:bx+0x40]
            L0047: ShowMessage(player, String0A49); // Your helm is no protection from the poisonous darts that hit you.
            L0054: return; // RETURN;
        }

        private void FnHEALDOWN_1C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x04);
            L0007: PushStack(player, 0x00);
074A  000A C4 5E 06  les bx, [bp+0x6]
074D  000D 26 FF 5F 04  call far word [es:bx+0x4]
            L0011: cx = PopStack(player);
            L0012: cx = PopStack(player);
            L0013: RefreshCompareFlags(ax);
            L0015: if (JumpNotEqual) goto L004F;
            L0017: ax = GetMaxHits(player);
            L001E: bx = 0x000A;
            L0021: dx = ax % bx; ax = ax / bx;
            L0024: DamagePlayer(player, ax);
            L002E: ShowMessage(player, String0A8B); // A loose shield that is mounted on the wall falls and smacks you on the head.
            L003B: SetFlag(player, 0x00, 0x04, 0x01);
            L004F: return; // RETURN;
        }

        private void FnITEMC_1D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x01);
            L0007: PushStack(player, 0x03);
            L000B: PushStack(player, ax);
079D  000C C4 5E 06  les bx, [bp+0x6]
07A0  000F 26 FF 1F  call far word [es:bx]
07A3  0012 83 C4 06  add sp, 0x6
            L0015: ShowMessage(player, String0AD8); // Your foot brushes a stick, which you see is actually a wand.
            L0022: ShowMessage(player, String0B15); // As it begins to glow, you hear the unlocking of a door.
            L002F: return; // RETURN;
        }

        private void FnTELEG_1F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x04, 0x03, 0xC8, 0x02, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnWIZDOOR_22(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetGuild(player), 0x0005);
            L000D: if (JumpNotEqual) goto L001C;
0800  000F FF 76 08  push word [bp+0x8]
0803  0012 FF 76 06  push word [bp+0x6]
0806  0015 0E     push cs
0807  0016 E8 5D 0F  call 0xf76
            L0019: // NOP
            L001A: cx = PopStack(player);
            L001B: cx = PopStack(player);
            L001C: return; // RETURN;
        }

        private void FnWIZTELE_23(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x04, 0x03, 0x10, 0x02, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnFTNB_25(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0042);
            L0010: Compare(GetFlag(player, 0x02, 0x46), 0x0001);
            L0024: if (JumpNotEqual) goto L0038;
            L0026: AddMana(player, 0x2710);
0867  0033 B8 4D 0B  mov ax, 0xb4d
            L0036: goto L0090;
            L0038: SetFlag(player, 0x02, 0x46, 0x01);
            L004D: AddMana(player, 0x2710);
            L005A: Compare(GetGuild(player), 0x0003);
            L0064: if (JumpNotEqual) goto L007C;
            L0066: SetSpellLevel(player, 0x15, 0x01);
08AB  0077 B8 89 0B  mov ax, 0xb89
            L007A: goto L0090;
            L007C: SetSpellLevel(player, 0x0F, 0x01);
            L008D: ShowMessage(player, String0BEB); // The silvery waters of Trident Fountain replenish your mana and empower you with the Shield spell.
            L009A: return; // RETURN;
        }

        private void FnCLEDR_26(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetGuild(player), 0x0004);
            L000D: if (JumpNotEqual) goto L001C;
08DF  000F FF 76 08  push word [bp+0x8]
08E2  0012 FF 76 06  push word [bp+0x6]
08E5  0015 0E     push cs
08E6  0016 E8 7E 0E  call 0xe97
            L0019: // NOP
            L001A: cx = PopStack(player);
            L001B: cx = PopStack(player);
            L001C: return; // RETURN;
        }

        private void FnCLETELE_27(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x04, 0x03, 0x18, 0x00, isForwardMove);
            L001D: return; // RETURN;
        }

        private void FnITEMCDR_28(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x03);
            L0007: PushStack(player, ax);
0915  0008 C4 5E 06  les bx, [bp+0x6]
0918  000B 26 FF 5F 04  call far word [es:bx+0x4]
            L000F: cx = PopStack(player);
            L0010: cx = PopStack(player);
            L0011: Compare(ax, 0x0001);
            L0014: if (JumpNotEqual) goto L003F;
0923  0016 FF 76 08  push word [bp+0x8]
0926  0019 FF 76 06  push word [bp+0x6]
0929  001C 0E     push cs
092A  001D E8 D7 0D  call 0xdf7
            L0020: // NOP
            L0021: cx = PopStack(player);
            L0022: cx = PopStack(player);
            L0023: ShowMessage(player, String0C4D); // The door is open.
            L0030: ShowMessage(player, String0C5F); // The magic wand sign on the door has been zapped.
            L003D: goto L0073;
            L003F: ShowMessage(player, String0C90); // The door is locked.
            L004C: ShowMessage(player, String0CA4); // Upon the door is the sign of a magic wand. If the wand is zapped, the door will open.
            L0059: ShowMessage(player, String0CFA); // Someone has scrawled under the sign - 'When the wand is zapped, stay in the area until you open the door.'
0973  0066 FF 76 08  push word [bp+0x8]
0976  0069 FF 76 06  push word [bp+0x6]
0979  006C 0E     push cs
097A  006D E8 C8 0D  call 0xe38
            L0070: // NOP
            L0071: cx = PopStack(player);
            L0072: cx = PopStack(player);
            L0073: return; // RETURN;
        }

        private void FnITEMBDR_29(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0x67);
            L0011: if (JumpEqual) goto L0025;
0995  0013 FF 76 08  push word [bp+0x8]
0998  0016 FF 76 06  push word [bp+0x6]
099B  0019 0E     push cs
099C  001A E8 65 0D  call 0xd82
            L001D: // NOP
            L001E: cx = PopStack(player);
            L001F: cx = PopStack(player);
09A2  0020 B8 65 0D  mov ax, 0xd65
            L0023: goto L005C;
09A7  0025 FF 76 08  push word [bp+0x8]
09AA  0028 FF 76 06  push word [bp+0x6]
09AD  002B 0E     push cs
09AE  002C E8 94 0D  call 0xdc3
            L002F: // NOP
            L0030: cx = PopStack(player);
            L0031: cx = PopStack(player);
            L0032: ShowPortrait(player, 0x0016);
            L003F: ShowMessage(player, String0D9D); // You see a guard at the door wiping tiny spiders from his helmet:
            L004C: ShowMessage(player, String0DDE); // 'My hat's off to you,' he says, barking a shrill laugh.
            L0059: ShowMessage(player, String0E16); // 'The right helm lets you pass. The wrong helm won't.'
            L0066: return; // RETURN;
        }

        private void FnTHDR_2A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetGuild(player), 0x0003);
            L000D: if (JumpNotEqual) goto L001C;
09F9  000F FF 76 08  push word [bp+0x8]
09FC  0012 FF 76 06  push word [bp+0x6]
09FF  0015 0E     push cs
0A00  0016 E8 64 0D  call 0xd7d
            L0019: // NOP
            L001A: cx = PopStack(player);
            L001B: cx = PopStack(player);
            L001C: return; // RETURN;
        }

        private void FnTHTELE_2B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x04, 0x03, 0x1E, 0x03, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnTELEH_2C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x04, 0x01, 0x3A, 0x01, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnLOCK_2D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0xC0);
            L0007: PushStack(player, ax);
0A50  0008 C4 5E 06  les bx, [bp+0x6]
0A53  000B 26 FF 5F 54  call far word [es:bx+0x54]
            L000F: cx = PopStack(player);
            L0010: cx = PopStack(player);
            L0011: RefreshCompareFlags(ax);
            L0013: if (JumpNotEqual) goto L0038;
            L0015: PushStack(player, 0x6F);
            L0019: PushStack(player, ax);
0A62  001A C4 5E 06  les bx, [bp+0x6]
0A65  001D 26 FF 5F 54  call far word [es:bx+0x54]
            L0021: cx = PopStack(player);
            L0022: cx = PopStack(player);
            L0023: RefreshCompareFlags(ax);
            L0025: if (JumpNotEqual) goto L0038;
            L0027: Compare(HasUsedSkill(player, 0x0E), 0x0006);
            L0036: if (JumpBelow) goto L0054;
            L0038: ShowMessage(player, String0E4C); // You skillfully unlock the door.
0A8D  0045 FF 76 08  push word [bp+0x8]
0A90  0048 FF 76 06  push word [bp+0x6]
0A93  004B 0E     push cs
0A94  004C E8 6D 0C  call 0xcbc
            L004F: // NOP
            L0050: cx = PopStack(player);
            L0051: cx = PopStack(player);
            L0052: goto L006E;
0A9C  0054 FF 76 08  push word [bp+0x8]
0A9F  0057 FF 76 06  push word [bp+0x6]
0AA2  005A 0E     push cs
0AA3  005B E8 9F 0C  call 0xcfd
            L005E: // NOP
            L005F: cx = PopStack(player);
            L0060: cx = PopStack(player);
            L0061: ShowMessage(player, String0C90); // The door is locked.
            L006E: return; // RETURN;
        }

        private void FnSTRENGTH_2E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetGuild(player));
            L000C: if (JumpEqual) goto L001A;
            L000E: Compare(GetGuild(player), 0x0001);
            L0018: if (JumpNotEqual) goto L003F;
            L001A: Compare(CheckStrength(player), 0x0018);
            L0029: if (JumpBelow) goto L003D;
0AE3  002B FF 76 08  push word [bp+0x8]
0AE6  002E FF 76 06  push word [bp+0x6]
0AE9  0031 0E     push cs
0AEA  0032 E8 17 0C  call 0xc4c
            L0035: // NOP
            L0036: cx = PopStack(player);
            L0037: cx = PopStack(player);
0AF0  0038 B8 6C 0E  mov ax, 0xe6c
            L003B: goto L009F;
            L003D: goto L006A;
            L003F: Compare(GetGuild(player), 0x0004);
            L0049: if (JumpEqual) goto L0057;
            L004B: Compare(GetGuild(player), 0x0002);
            L0055: if (JumpNotEqual) goto L007C;
            L0057: Compare(CheckStrength(player), 0x0014);
            L0066: if (JumpBelow) goto L006A;
            L0068: goto L002B;
0B22  006A FF 76 08  push word [bp+0x8]
0B25  006D FF 76 06  push word [bp+0x6]
0B28  0070 0E     push cs
0B29  0071 E8 19 0C  call 0xc8d
            L0074: // NOP
            L0075: cx = PopStack(player);
            L0076: cx = PopStack(player);
0B2F  0077 B8 AA 0E  mov ax, 0xeaa
            L007A: goto L009F;
            L007C: Compare(CheckStrength(player), 0x000F);
            L008B: if (JumpBelow) goto L008F;
            L008D: goto L002B;
0B47  008F FF 76 08  push word [bp+0x8]
0B4A  0092 FF 76 06  push word [bp+0x6]
0B4D  0095 0E     push cs
0B4E  0096 E8 F4 0B  call 0xc8d
            L0099: // NOP
            L009A: cx = PopStack(player);
            L009B: cx = PopStack(player);
            L009C: ShowMessage(player, String0ED6); // You cannot find the strength to push open the door.
            L00A9: return; // RETURN;
        }

        private void FnCLUEE_2F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x001C);
            L0010: ShowMessage(player, String0F0A); // A knight mumbles to himself -
            L001D: ShowMessage(player, String0F28); // 'Confusing li'l thief. He's obviously been in the lower depths of this bizarre Night Elf kingdom.'
            L002A: ShowMessage(player, String0F8B); // The knight notices you and turns to you.
            L0037: ShowMessage(player, String0FB4); // 'The dralks...or some such thing, they are what these Elves worship.'
            L0044: return; // RETURN;
        }

        private void FnRADR_30(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetGuild(player), 0x0002);
            L000D: if (JumpNotEqual) goto L001C;
0BB8  000F FF 76 08  push word [bp+0x8]
0BBB  0012 FF 76 06  push word [bp+0x6]
0BBE  0015 0E     push cs
0BBF  0016 E8 A5 0B  call 0xbbe
            L0019: // NOP
            L001A: cx = PopStack(player);
            L001B: cx = PopStack(player);
            L001C: return; // RETURN;
        }

        private void FnRATELE_31(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x04, 0x03, 0xE1, 0x01, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnTELEI_32(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0FFA); // To The Vault.
            L0010: TeleportParty(player, 0x05, 0x01, 0x46, 0x02, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnKNDR_33(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetGuild(player), 0x0001);
            L000D: if (JumpNotEqual) goto L001C;
0C23  000F FF 76 08  push word [bp+0x8]
0C26  0012 FF 76 06  push word [bp+0x6]
0C29  0015 0E     push cs
0C2A  0016 E8 3A 0B  call 0xb53
            L0019: // NOP
            L001A: cx = PopStack(player);
            L001B: cx = PopStack(player);
            L001C: return; // RETURN;
        }

        private void FnKNTELE_34(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x04, 0x03, 0xF8, 0x03, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnITEMD_35(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFlag(player, 0x03, 0x02, 0x00);
            L0017: PushStack(player, 0x00);
            L001A: PushStack(player, 0x03);
            L001E: PushStack(player, ax);
0C71  001F C4 5E 06  les bx, [bp+0x6]
0C74  0022 26 FF 1F  call far word [es:bx]
0C77  0025 83 C4 06  add sp, 0x6
            L0028: ax = HasItem(player, 0xD1);
            L0036: if (JumpEqual) goto L0047;
0C8A  0038 FF 76 08  push word [bp+0x8]
0C8D  003B FF 76 06  push word [bp+0x6]
0C90  003E 0E     push cs
0C91  003F E8 37 0A  call 0xa79
            L0042: // NOP
            L0043: cx = PopStack(player);
            L0044: cx = PopStack(player);
            L0045: goto L0060;
            L0047: GiveItem(player, 0xD1);
            L0053: ShowMessage(player, String1008); // A Lantern lies on the floor. It will help during your future explorations. Mark well that it was here when you needed it!
            L0060: return; // RETURN;
        }

        private void FnITEMB_36(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0028);
            L0010: ax = HasItem(player, 0x67);
            L001E: if (JumpEqual) goto L0025;
0CD4  0020 B8 82 10  mov ax, 0x1082
            L0023: goto L006D;
            L0025: GiveItem(player, 0x67);
            L0031: ModifyGold(player, 0xFFFF78BA);
            L0043: ShowMessage(player, String10C5); // A Troll Cleric grabs your arm -
            L0050: ShowMessage(player, String10E5); // 'You will want this helm of protection to safeguard you on your journey.
            L005D: ShowMessage(player, String112E); // It's sure to impress some of the guards you'll meet in your journeys.
            L006A: ShowMessage(player, String1174); // No need to thank me. I've taken..er..accepted your generous donation already.'
            L0077: return; // RETURN;
        }

        private void FnGOODIEA_37(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String11C3); // A band of Night Elves tries to steal your armor.
            L0010: ax = HasItem(player, 0x9B);
            L001E: if (JumpNotEqual) goto L0030;
            L0020: ax = HasItem(player, 0xA1);
            L002E: if (JumpEqual) goto L0042;
0D5D  0030 B8 DC 05  mov ax, 0x5dc
            L0033: PushStack(player, ax);
            L0034: PushStack(player, 0x00);
            L0037: PushStack(player, ax);
            L0038: PushStack(player, ax);
            L0039: PushStack(player, 0xB0);
0D6A  003D B8 B6 00  mov ax, 0xb6
            L0040: goto L0052;
0D6F  0042 B8 B8 0B  mov ax, 0xbb8
            L0045: PushStack(player, ax);
            L0046: PushStack(player, 0x00);
            L0049: PushStack(player, ax);
            L004A: PushStack(player, ax);
            L004B: PushStack(player, 0xA1);
            L004F: PushStack(player, 0x9B);
0D80  0053 C4 5E 06  les bx, [bp+0x6]
0D83  0056 26 FF 9F D8 00  call far word [es:bx+0xd8]
0D88  005B 83 C4 0C  add sp, 0xc
            L005E: Compare(PartyCount(player), 0x0001);
            L0069: if (JumpNotEqual) goto L0087;
            L006B: AddEncounter(player, 0x01, 0x03);
            L007D: PushStack(player, 0x04);
0DAE  0081 B8 02 00  mov ax, 0x2
            L0084: goto L011F;
            L0087: Compare(PartyCount(player), 0x0002);
            L0092: if (JumpNotEqual) goto L00D0;
            L0094: AddEncounter(player, 0x01, 0x03);
            L00A6: AddEncounter(player, 0x02, 0x03);
            L00B8: AddEncounter(player, 0x03, 0x05);
            L00CA: PushStack(player, 0x04);
            L00CE: goto L011F;
            L00D0: AddEncounter(player, 0x01, 0x03);
            L00E2: AddEncounter(player, 0x02, 0x03);
            L00F4: AddEncounter(player, 0x03, 0x05);
            L0106: AddEncounter(player, 0x05, 0x04);
            L0118: AddEncounter(player, 0x06, 0x04);
            L012A: return; // RETURN;
        }

        private void FnTELEJ_38(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x05, 0x01, 0xEE, 0x00, isForwardMove);
            L001D: return; // RETURN;
        }

        private void FnBADOOR_39(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetGuild(player));
            L000C: if (JumpNotEqual) goto L001B;
0E86  000E FF 76 08  push word [bp+0x8]
0E89  0011 FF 76 06  push word [bp+0x6]
0E8C  0014 0E     push cs
0E8D  0015 E8 D7 08  call 0x8ef
            L0018: // NOP
            L0019: cx = PopStack(player);
            L001A: cx = PopStack(player);
            L001B: return; // RETURN;
        }

        private void FnBATELE_3A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x04, 0x03, 0xEE, 0x01, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnFELLDOOR_3B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String11F4); // Fellowship Meeting Hall
            L0010: return; // RETURN;
        }

        private void FnKNIGHT_3D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: // make space for tmp on stack: sp -= 2
            L0005: dx = GetFlag(player, 0x02, 0x45) + GetFlag(player, 0x02, 0x47);
            L002B: tmp = dx;
            L002E: Compare(GetGuild(player), 0x0001);
            L0038: if (JumpEqual) goto L003D;
            L003A: goto L00C1;
0F09  003D FF 76 08  push word [bp+0x8]
0F0C  0040 FF 76 06  push word [bp+0x6]
0F0F  0043 0E     push cs
0F10  0044 E8 49 07  call 0x790
            L0047: // NOP
            L0048: cx = PopStack(player);
            L0049: cx = PopStack(player);
            L004A: Compare(tmp, 0x0001);
            L0050: if (JumpEqual) goto L005E;
            L0052: Compare(ax, 0x0002);
            L0055: if (JumpEqual) goto L0078;
            L0057: Compare(ax, 0x0003);
            L005A: if (JumpEqual) goto L00B2;
            L005C: goto L00CE;
0F2A  005E FF 76 08  push word [bp+0x8]
0F2D  0061 FF 76 06  push word [bp+0x6]
0F30  0064 0E     push cs
0F31  0065 E8 5F 07  call 0x7c7
            L0068: // NOP
            L0069: cx = PopStack(player);
            L006A: cx = PopStack(player);
            L006B: PushStack(player, 0x78);
0F3B  006F C4 5E 06  les bx, [bp+0x6]
0F3E  0072 26 FF 5F 48  call far word [es:bx+0x48]
            L0076: goto L00CD;
            L0078: ax = HasItem(player, 0x78);
            L0086: if (JumpEqual) goto L0097;
0F54  0088 FF 76 08  push word [bp+0x8]
0F57  008B FF 76 06  push word [bp+0x6]
0F5A  008E 0E     push cs
0F5B  008F E8 6D 07  call 0x7ff
            L0092: // NOP
            L0093: cx = PopStack(player);
            L0094: cx = PopStack(player);
            L0095: goto L00CE;
            L0097: GiveItem(player, 0x78);
0F6F  00A3 FF 76 08  push word [bp+0x8]
0F72  00A6 FF 76 06  push word [bp+0x6]
0F75  00A9 0E     push cs
0F76  00AA E8 64 07  call 0x811
            L00AD: // NOP
            L00AE: cx = PopStack(player);
            L00AF: cx = PopStack(player);
            L00B0: goto L00CE;
0F7E  00B2 FF 76 08  push word [bp+0x8]
0F81  00B5 FF 76 06  push word [bp+0x6]
0F84  00B8 0E     push cs
0F85  00B9 E8 43 07  call 0x7ff
            L00BC: // NOP
            L00BD: cx = PopStack(player);
            L00BE: cx = PopStack(player);
            L00BF: goto L00CE;
            L00C1: ShowMessage(player, String120C); // Only Knights gain their reward here.
            L00CE: // restore stack ptr: sp = bp;
            L00D0: return; // RETURN;
        }

        private void FnTELEK_3F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x04, 0x03, 0xCE, 0x03, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnRANGER_41(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: // make space for tmp on stack: sp -= 2
            L0005: dx = GetFlag(player, 0x02, 0x45) + GetFlag(player, 0x02, 0x47);
            L002B: tmp = dx;
            L002E: Compare(GetGuild(player), 0x0002);
            L0038: if (JumpEqual) goto L003D;
            L003A: goto L00C1;
1005  003D FF 76 08  push word [bp+0x8]
1008  0040 FF 76 06  push word [bp+0x6]
100B  0043 0E     push cs
100C  0044 E8 4D 06  call 0x694
            L0047: // NOP
            L0048: cx = PopStack(player);
            L0049: cx = PopStack(player);
            L004A: Compare(tmp, 0x0001);
            L0050: if (JumpEqual) goto L005E;
            L0052: Compare(ax, 0x0002);
            L0055: if (JumpEqual) goto L0078;
            L0057: Compare(ax, 0x0003);
            L005A: if (JumpEqual) goto L00B2;
            L005C: goto L00CE;
1026  005E FF 76 08  push word [bp+0x8]
1029  0061 FF 76 06  push word [bp+0x6]
102C  0064 0E     push cs
102D  0065 E8 63 06  call 0x6cb
            L0068: // NOP
            L0069: cx = PopStack(player);
            L006A: cx = PopStack(player);
            L006B: PushStack(player, 0x79);
1037  006F C4 5E 06  les bx, [bp+0x6]
103A  0072 26 FF 5F 48  call far word [es:bx+0x48]
            L0076: goto L00CD;
            L0078: ax = HasItem(player, 0x79);
            L0086: if (JumpEqual) goto L0097;
1050  0088 FF 76 08  push word [bp+0x8]
1053  008B FF 76 06  push word [bp+0x6]
1056  008E 0E     push cs
1057  008F E8 71 06  call 0x703
            L0092: // NOP
            L0093: cx = PopStack(player);
            L0094: cx = PopStack(player);
            L0095: goto L00CE;
            L0097: GiveItem(player, 0x79);
106B  00A3 FF 76 08  push word [bp+0x8]
106E  00A6 FF 76 06  push word [bp+0x6]
1071  00A9 0E     push cs
1072  00AA E8 68 06  call 0x715
            L00AD: // NOP
            L00AE: cx = PopStack(player);
            L00AF: cx = PopStack(player);
            L00B0: goto L00CE;
107A  00B2 FF 76 08  push word [bp+0x8]
107D  00B5 FF 76 06  push word [bp+0x6]
1080  00B8 0E     push cs
1081  00B9 E8 47 06  call 0x703
            L00BC: // NOP
            L00BD: cx = PopStack(player);
            L00BE: cx = PopStack(player);
            L00BF: goto L00CE;
            L00C1: ShowMessage(player, String1231); // Only Rangers gain their reward here.
            L00CE: // restore stack ptr: sp = bp;
            L00D0: return; // RETURN;
        }

        private void FnBARB_43(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: // make space for tmp on stack: sp -= 2
            L0005: dx = GetFlag(player, 0x02, 0x45) + GetFlag(player, 0x02, 0x47);
            L002B: tmp = dx;
            L002E: RefreshCompareFlags(GetGuild(player));
            L0037: if (JumpEqual) goto L003C;
            L0039: goto L00C0;
10DB  003C FF 76 08  push word [bp+0x8]
10DE  003F FF 76 06  push word [bp+0x6]
10E1  0042 0E     push cs
10E2  0043 E8 77 05  call 0x5bd
            L0046: // NOP
            L0047: cx = PopStack(player);
            L0048: cx = PopStack(player);
            L0049: Compare(tmp, 0x0001);
            L004F: if (JumpEqual) goto L005D;
            L0051: Compare(ax, 0x0002);
            L0054: if (JumpEqual) goto L0077;
            L0056: Compare(ax, 0x0003);
            L0059: if (JumpEqual) goto L00B1;
            L005B: goto L00CD;
10FC  005D FF 76 08  push word [bp+0x8]
10FF  0060 FF 76 06  push word [bp+0x6]
1102  0063 0E     push cs
1103  0064 E8 8D 05  call 0x5f4
            L0067: // NOP
            L0068: cx = PopStack(player);
            L0069: cx = PopStack(player);
            L006A: PushStack(player, 0x77);
110D  006E C4 5E 06  les bx, [bp+0x6]
1110  0071 26 FF 5F 48  call far word [es:bx+0x48]
            L0075: goto L00CC;
            L0077: ax = HasItem(player, 0x77);
            L0085: if (JumpEqual) goto L0096;
1126  0087 FF 76 08  push word [bp+0x8]
1129  008A FF 76 06  push word [bp+0x6]
112C  008D 0E     push cs
112D  008E E8 9B 05  call 0x62c
            L0091: // NOP
            L0092: cx = PopStack(player);
            L0093: cx = PopStack(player);
            L0094: goto L00CD;
            L0096: GiveItem(player, 0x77);
1141  00A2 FF 76 08  push word [bp+0x8]
1144  00A5 FF 76 06  push word [bp+0x6]
1147  00A8 0E     push cs
1148  00A9 E8 92 05  call 0x63e
            L00AC: // NOP
            L00AD: cx = PopStack(player);
            L00AE: cx = PopStack(player);
            L00AF: goto L00CD;
1150  00B1 FF 76 08  push word [bp+0x8]
1153  00B4 FF 76 06  push word [bp+0x6]
1156  00B7 0E     push cs
1157  00B8 E8 71 05  call 0x62c
            L00BB: // NOP
            L00BC: cx = PopStack(player);
            L00BD: cx = PopStack(player);
            L00BE: goto L00CD;
            L00C0: ShowMessage(player, String1256); // Only Barbarians gain their reward here.
            L00CD: // restore stack ptr: sp = bp;
            L00CF: return; // RETURN;
        }

        private void FnEZA_44(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L002C;
            L0010: AddEncounter(player, 0x01, 0x07);
            L0022: PushStack(player, 0x07);
1196  0026 B8 02 00  mov ax, 0x2
            L0029: goto L00B5;
            L002C: Compare(PartyCount(player), 0x0002);
            L0037: if (JumpNotEqual) goto L0066;
            L0039: AddEncounter(player, 0x01, 0x09);
            L004B: AddEncounter(player, 0x02, 0x09);
            L005D: PushStack(player, 0x0B);
11D1  0061 B8 03 00  mov ax, 0x3
            L0064: goto L00B5;
            L0066: AddEncounter(player, 0x01, 0x0A);
            L0078: AddEncounter(player, 0x02, 0x0A);
            L008A: AddEncounter(player, 0x03, 0x07);
            L009C: AddEncounter(player, 0x05, 0x0B);
            L00AE: AddEncounter(player, 0x06, 0x0B);
            L00C0: return; // RETURN;
        }

        private void FnMEDA_45(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L002B;
            L0010: AddEncounter(player, 0x01, 0x1F);
            L0022: PushStack(player, 0x20);
1258  0026 B8 02 00  mov ax, 0x2
            L0029: goto L00A2;
            L002B: Compare(PartyCount(player), 0x0002);
            L0036: if (JumpNotEqual) goto L0053;
            L0038: AddEncounter(player, 0x01, 0x1F);
            L004A: PushStack(player, 0x20);
1280  004E B8 02 00  mov ax, 0x2
            L0051: goto L0090;
            L0053: AddEncounter(player, 0x01, 0x1F);
            L0065: AddEncounter(player, 0x02, 0x1F);
            L0077: AddEncounter(player, 0x03, 0x20);
            L0089: AddEncounter(player, 0x04, 0x20);
            L009B: AddEncounter(player, 0x06, 0x21);
            L00AD: return; // RETURN;
        }

        private void FnHRDA_46(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L0029;
            L0010: PushStack(player, 0x01);
            L0014: PushStack(player, ax);
12F6  0015 C4 5E 06  les bx, [bp+0x6]
12F9  0018 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L001D: cx = PopStack(player);
            L001E: cx = PopStack(player);
            L001F: PushStack(player, 0x04);
1304  0023 B8 02 00  mov ax, 0x2
            L0026: goto L00B2;
            L0029: Compare(PartyCount(player), 0x0002);
            L0034: if (JumpNotEqual) goto L0063;
            L0036: AddEncounter(player, 0x01, 0x24);
            L0048: AddEncounter(player, 0x02, 0x03);
            L005A: PushStack(player, 0x27);
133F  005E B8 06 00  mov ax, 0x6
            L0061: goto L00B2;
            L0063: AddEncounter(player, 0x01, 0x24);
            L0075: AddEncounter(player, 0x02, 0x25);
            L0087: AddEncounter(player, 0x03, 0x26);
            L0099: AddEncounter(player, 0x04, 0x27);
            L00AB: AddEncounter(player, 0x05, 0x28);
            L00BD: return; // RETURN;
        }

        private void FnEZB_47(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L001A;
            L0010: PushStack(player, 0x0F);
13B4  0014 B8 01 00  mov ax, 0x1
            L0017: goto L00A3;
            L001A: Compare(PartyCount(player), 0x0002);
            L0025: if (JumpNotEqual) goto L0054;
            L0027: AddEncounter(player, 0x01, 0x0C);
            L0039: AddEncounter(player, 0x02, 0x0C);
            L004B: PushStack(player, 0x0D);
13EF  004F B8 03 00  mov ax, 0x3
            L0052: goto L00A3;
            L0054: AddEncounter(player, 0x01, 0x0C);
            L0066: AddEncounter(player, 0x02, 0x0C);
            L0078: AddEncounter(player, 0x03, 0x0F);
            L008A: AddEncounter(player, 0x05, 0x0D);
            L009C: AddEncounter(player, 0x06, 0x0D);
            L00AE: return; // RETURN;
        }

        private void FnMEDB_49(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L0029;
            L0010: PushStack(player, 0x01);
            L0014: PushStack(player, ax);
146A  0015 C4 5E 06  les bx, [bp+0x6]
146D  0018 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L001D: cx = PopStack(player);
            L001E: cx = PopStack(player);
            L001F: PushStack(player, 0x06);
1478  0023 B8 02 00  mov ax, 0x2
            L0026: goto L00AC;
            L0029: Compare(PartyCount(player), 0x0002);
            L0034: if (JumpNotEqual) goto L0060;
            L0036: PushStack(player, 0x01);
            L003A: PushStack(player, ax);
1490  003B C4 5E 06  les bx, [bp+0x6]
1493  003E 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L0043: cx = PopStack(player);
            L0044: cx = PopStack(player);
            L0045: AddEncounter(player, 0x02, 0x06);
            L0057: PushStack(player, 0x02);
14B0  005B B8 05 00  mov ax, 0x5
            L005E: goto L00AC;
            L0060: PushStack(player, 0x01);
            L0064: PushStack(player, ax);
14BA  0065 C4 5E 06  les bx, [bp+0x6]
14BD  0068 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L006D: cx = PopStack(player);
            L006E: cx = PopStack(player);
            L006F: AddEncounter(player, 0x02, 0x06);
            L0081: AddEncounter(player, 0x03, 0x06);
            L0093: AddEncounter(player, 0x05, 0x03);
            L00A5: AddEncounter(player, 0x06, 0x04);
            L00B7: return; // RETURN;
        }

        private void FnEZC_4A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L001A;
            L0010: PushStack(player, 0x1D);
1522  0014 B8 01 00  mov ax, 0x1
            L0017: goto L009F;
            L001A: Compare(PartyCount(player), 0x0002);
            L0025: if (JumpNotEqual) goto L0050;
            L0027: AddEncounter(player, 0x01, 0x14);
            L0039: AddEncounter(player, 0x02, 0x14);
1559  004B B8 15 00  mov ax, 0x15
            L004E: goto L009B;
            L0050: AddEncounter(player, 0x01, 0x14);
            L0062: AddEncounter(player, 0x02, 0x14);
            L0074: AddEncounter(player, 0x03, 0x18);
            L0086: AddEncounter(player, 0x04, 0x18);
            L0098: AddEncounter(player, 0x06, 0x26);
            L00AA: return; // RETURN;
        }

        private void FnMEDC_4B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L0019;
            L0010: PushStack(player, 0x1C);
15CE  0014 B8 01 00  mov ax, 0x1
            L0017: goto L0090;
            L0019: Compare(PartyCount(player), 0x0002);
            L0024: if (JumpNotEqual) goto L0041;
            L0026: AddEncounter(player, 0x01, 0x1C);
            L0038: PushStack(player, 0x1C);
15F6  003C B8 02 00  mov ax, 0x2
            L003F: goto L007E;
            L0041: AddEncounter(player, 0x01, 0x1C);
            L0053: AddEncounter(player, 0x02, 0x1C);
            L0065: AddEncounter(player, 0x04, 0x22);
            L0077: AddEncounter(player, 0x05, 0x23);
            L0089: AddEncounter(player, 0x06, 0x23);
            L009B: return; // RETURN;
        }

        private void Fn_4C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: return; // RETURN;
            // Extra data: 55 8B EC B8 D8 00 50 C4 5E 06 26 FF 5F 4C 59 B8 D0 00 50 C4 5E 06 26 FF 5F 4C 59 B8 7E 12 50 C4 5E 06 26 FF 9F F8 00 59 B8 B4 12 50 C4 5E 06 26 FF 9F F8 00 59 5D CB 55 8B EC 33 C0 BA 50 C3 50 52 C4 5E 06 26 FF 9F 98 00 59 59 B8 01 00 50 B8 45 00 50 B8 02 00 50 C4 5E 06 26 FF 1F 83 C4 06 B8 F2 12 50 C4 5E 06 26 FF 9F F8 00 59 5D CB 55 8B EC B8 31 13 50 C4 5E 06 26 FF 9F F8 00 59 5D CB 55 8B EC B8 57 13 50 C4 5E 06 26 FF 9F F8 00 59 B8 02 00 50 B8 45 00 50 B8 02 00 50 C4 5E 06 26 FF 1F 83 C4 06 5D CB 55 8B EC B8 01 00 50 C4 5E 06 26 FF 5F 24 50 C4 5E 06 26 FF 5F 20 50 C4 5E 06 26 FF 5F 2C 83 C4 06 C4 5E 06 26 FF 5F 24 50 C4 5E 06 26 FF 5F 20 50 B8 01 00 50 C4 5E 06 26 FF 5F 30 83 C4 06 5D CB 55 8B EC 33 C0 50 C4 5E 06 26 FF 5F 24 50 C4 5E 06 26 FF 5F 20 50 C4 5E 06 26 FF 5F 2C 83 C4 06 5D CB 55 8B EC B8 D0 00 50 50 C4 5E 06 26 FF 5F 54 59 59 0B C0 74 41 B8 01 00 50 C4 5E 06 26 FF 5F 24 50 C4 5E 06 26 FF 5F 20 50 C4 5E 06 26 FF 5F 2C 83 C4 06 C4 5E 06 26 FF 5F 24 50 C4 5E 06 26 FF 5F 20 50 B8 01 00 50 C4 5E 06 26 FF 5F 30 83 C4 06 B8 81 13 EB 20 33 C0 50 C4 5E 06 26 FF 5F 24 50 C4 5E 06 26 FF 5F 20 50 C4 5E 06 26 FF 5F 2C 83 C4 06 B8 A5 13 50 C4 5E 06 26 FF 9F F8 00 59 5D CB 
        }

    }
}
