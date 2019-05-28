#pragma warning disable
using System.Collections.Generic;
using XPT.WorldData;
using XPT.WorldData.Yserbius;

namespace XPT.Scripts.Yserbius.Maps {
    class YserMap14 : AMapScripted {
        protected override int MapIndex => 14;
        protected override int RandomEncounterChance => 10;
        protected override int RandomEncounterExtraCount => 1;

        public YserMap14() {
            MapEvent01 = FnTHRUWALL_01;
            MapEvent02 = FnCLUEA_02;
            MapEvent03 = FnTELEA_03;
            MapEvent04 = FnLAVADIE_04;
            MapEvent05 = FnFNTM_05;
            MapEvent06 = FnTELOA_06;
            MapEvent07 = FnHURTPIT_07;
            MapEvent08 = FnCLUEB_08;
            MapEvent09 = FnSELOCKA_09;
            MapEvent0A = FnTELEB_0A;
            MapEvent0B = FnTELEC_0B;
            MapEvent0C = FnTELOB_0C;
            MapEvent0D = FnTELED_0D;
            MapEvent0E = FnKEYA_0E;
            MapEvent0F = FnMEDGDA_0F;
            MapEvent10 = FnCLUEC_10;
            MapEvent11 = FnGLDDRA_11;
            MapEvent12 = FnTELOC_12;
            MapEvent13 = FnPITTEXT_13;
            MapEvent14 = FnMEDGDB_14;
            MapEvent15 = FnCLUED_15;
            MapEvent16 = FnDEATHPIT_16;
            MapEvent17 = FnTEXTA_17;
            MapEvent18 = FnMEDGDC_18;
            MapEvent19 = FnTELOD_19;
            MapEvent1B = FnTELOE_1B;
            MapEvent1C = FnCLUETP_1C;
            MapEvent1D = FnTELOF_1D;
            MapEvent1F = FnSECDR_1F;
            MapEvent20 = FnTPRTVLT_20;
            MapEvent21 = FnSETEXT_21;
            MapEvent22 = FnTAPA_22;
            MapEvent23 = FnTAPB_23;
            MapEvent24 = FnTAPC_24;
            MapEvent25 = FnTELOG_25;
            MapEvent26 = FnTELOH_26;
            MapEvent27 = FnPCPICK_27;
            MapEvent28 = FnTAPD_28;
            MapEvent29 = FnKEYB_29;
            MapEvent2A = FnGLDDRB_2A;
            MapEvent2B = FnFTNH_2B;
            MapEvent2C = FnCLUEE_2C;
            MapEvent2D = FnRUBYA_2D;
            MapEvent2E = FnTELOI_2E;
            MapEvent2F = FnTAPE_2F;
            MapEvent30 = FnFTNP_30;
            MapEvent31 = FnCLUEF_31;
            MapEvent32 = FnSCHARM_32;
            MapEvent33 = FnSMIRK_33;
            MapEvent34 = FnTAPF_34;
            MapEvent35 = FnTAPG_35;
            MapEvent36 = FnTAPH_36;
            MapEvent37 = FnTELOJ_37;
            MapEvent38 = FnFTNMH_38;
            MapEvent39 = FnCLUCLU_39;
            MapEvent3A = FnDTHDR_3A;
            MapEvent3B = FnCLUEG_3B;
            MapEvent3C = FnLJ_3C;
            MapEvent3D = FnTELOK_3D;
            MapEvent40 = FnTEXTB_40;
            MapEvent41 = FnMEDA_41;
            MapEvent42 = FnMEDB_42;
            MapEvent43 = FnMEDC_43;
            MapEvent44 = FnHRDA_44;
            MapEvent45 = FnEZA_45;
            MapEvent46 = FnHRDB_46;
            MapEvent48 = Fn_48;
        }
        
        // === Strings ================================================
        private const string String03FC = "A voice from the shadows whispers, 'Ah, another adventurer seeking to be the Queen's Champion, no doubt.";
        private const string String0465 = "One tip, youngling, there's a magical force that returns most Quest items back to where they came should you accidentally drop them.'";
        private const string String04EB = "You step into the hot lava.";
        private const string String0507 = "The sweet waters of the Fountain of Nectar restore your mana.";
        private const string String0545 = "Pass through this portal to Tipekans.";
        private const string String056B = "The pit isn't as deep as you feared, but you injure your ankle.";
        private const string String05AB = "You see a dwarf shaking her head. She turns to you and says, 'The graveyard is very dark. You must rely upon your wits and skills to get you through.";
        private const string String0641 = "Having something that sheds a little light for you wouldn't hurt, either.'";
        private const string String068C = "You successfully pick the lock.";
        private const string String06AC = "A locked door appears in the wall.";
        private const string String06CF = "The room is empty.";
        private const string String06E2 = "You find a key which may open seemingly impassable doors in your race to finish Queen Aeowyn's Map Quest.";
        private const string String074C = "The key is made of bone and features a skull and crossed arm bones.";
        private const string String0790 = "Your Guildmaster left you a special key that will give you access to magical armor.";
        private const string String07E4 = "The key is made of bone. The grasp is shaped like a skull and the shaft like two crossed, bony arms.";
        private const string String0849 = "The room is bare.";
        private const string String085B = "You walk into a lair.";
        private const string String0871 = "A cleric pulls you aside and whispers, 'It is rumored that there are areas in the dungeon that can be accessed only by certain races or guilds.'";
        private const string String0902 = "A sign on the door says, 'BARBARIANS ONLY.'";
        private const string String092E = "A sign reads 'This path leads to Lake Despair.'";
        private const string String095E = "The opening of the ground may have affected the stability of the walls.";
        private const string String09A6 = "While admiring the plaques you are attacked.";
        private const string String09D3 = "You see a plaque on the wall. 'Welcome to the Gallery. Our ancient plaques are informative as well as decorative.'";
        private const string String0A46 = "You fall into the Snake Pit and to your death.";
        private const string String0A75 = "You have entered the Cloister. Enjoy your respite on your way to the Gallery.";
        private const string String0AC3 = "You are attacked by raptors!";
        private const string String0AE0 = "Dark Alley awaits the unwary traveler. Step cautiously as you wander through the darkness.";
        private const string String0B3B = "To the Vineyard.";
        private const string String0B4C = "You find a scrap of paper on the floor with a lost and found message: 'Reward offered for the return of a jeweled lockpick to Tipekans.'";
        private const string String0BD5 = "To the Statuary";
        private const string String0BE5 = "A door appears in the wall.";
        private const string String0C01 = "To the Vault";
        private const string String0C0E = "Some of the walls appear to have been reconstructed.";
        private const string String0C43 = "The message on the plaque says, 'Use Tyndil's payment first.'";
        private const string String0C81 = "The plaque is worn and unreadable.";
        private const string String0CA4 = "The message on the plaque says, 'Save your Coral for last.'";
        private const string String0CE0 = "The plaque is cracked down the center.";
        private const string String0D07 = "The message on the plaque says, 'Use your Ebony before your Opal.'";
        private const string String0D4A = "You cannot read the plaque.";
        private const string String0D66 = "The eerie sounds coming from the Graveyard make you wonder if you should step through this teleport.";
        private const string String0DCB = "Through this teleport you will find the Breezeway.";
        private const string String0DFE = "'Alone I said! It took me a long time to tunnel through this wall and it's only large enough for one!'";
        private const string String0E65 = "Smirk grabs you by the collar before you can sneak through the door. 'Have you no sense? Return when you have the item I desire!'";
        private const string String0EE7 = "The message on the plaque says, 'Don't give up your Pearl until last.'";
        private const string String0F2E = "This plaque appears chipped.";
        private const string String0F4B = "A sign on the door says, 'RANGERS ONLY.'";
        private const string String0F74 = "Journey's End Fountain endows you with the Archery skill.";
        private const string String0FAE = "Journey's End Fountain endows you with the Athletics skill.";
        private const string String0FEA = "Journey's End Fountain endows you with the Bless spell.";
        private const string String1022 = "Journey's End Fountain is dry.";
        private const string String1041 = "You meet a Cavalier who says, 'I've heard tell of a special lantern that has proven very helpful in opening a certain door.";
        private const string String10BD = "The door is somewhere in the dark, or so I'm told.'";
        private const string String10F1 = "Smirk waves you inside.";
        private const string String1109 = "The entrance to Smirk's Emporium is locked.";
        private const string String1135 = "The message on the plaque says, 'Use Syrene's payment as your last choice.'";
        private const string String1181 = "The stagnant waters of the Trough are poisonous!";
        private const string String11B2 = "A monk breaks his silence and whispers, 'Search well, for there are places in the dungeon where your attributes can be enhanced.'";
        private const string String1234 = "The Luminous Lantern fades and disappears as you catch a glimpse of a magical talisman.";
        private const string String128C = "The room is too dark for you to see. A portable light would prove most useful here,";
        private const string String12E0 = "I see you have brought the lockpick.  Continue through the door to the east alone and you will find your promised reward.";
        private const string String135A = "Smirk cautions you not to go beyond this point without the lockpick.";
        private const string String139F = "The message on the plaque says, 'If given a choice, use the Opal second.'";
        private const string String13E9 = "The message on the plaque says, 'Use your Opal before your Coral.'";
        private const string String142C = "The etchings on the plaque are unintelligible.";
        private const string String145B = "The message on the plaque says, 'Use Tyndil's payment third.'";
        private const string String1499 = "You see nothing of interest on the plaque.";
        private const string String14C4 = "Equestrian Fountain rejuvenates your health and mana.";
        private const string String14FA = "'Once you have the four map pieces the Queen seeks, make sure you know the order of the jewels before you seek your reward.";
        private const string String1576 = "Three clues are available for each race. I have found two and am now after the third. You must read all three clues, or you will not be rewarded.'";
        private const string String1609 = "You are killed by Smirk who mistakes you for a robber.";
        private const string String1640 = "Back door to Smirk's Emporium.";
        private const string String165F = "'I was told that in this area there are hidden rooms. A few rooms are available only to specific guilds.";
        private const string String16C8 = "Beyond one hidden door is a second secretive door. That door leads to... Well, I think you should discover where that door leads.'";
        private const string String174B = "You see a group of monsters tearing at a life jacket.";
        private const string String1781 = "You can see it's a long, hard climb up to Cliffhanger.";
        private const string String17B8 = "The Wine Cellar is dark and damp.";
        private const string String17DA = "The waters of Journey's End Fountain are refreshing.";
        
        // === Functions ================================================
        private void FnTHRUWALL_01(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0021: return; // RETURN;
        }

        private void FnCLUEA_02(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String03FC); // A voice from the shadows whispers, 'Ah, another adventurer seeking to be the Queen's Champion, no doubt.
            L0010: ShowMessage(player, String0465); // One tip, youngling, there's a magical force that returns most Quest items back to where they came should you accidentally drop them.'
            L001D: return; // RETURN;
        }

        private void FnTELEA_03(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x06, 0x01, 0x28, 0x00, isForwardMove);
            L001D: return; // RETURN;
        }

        private void FnLAVADIE_04(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String04EB); // You step into the hot lava.
0080  0010 FF 76 08  push word [bp+0x8]
0083  0013 FF 76 06  push word [bp+0x6]
0086  0016 0E     push cs
0087  0017 E8 E4 15  call 0x15fe
            L001A: // NOP
            L001B: cx = PopStack(player);
            L001C: cx = PopStack(player);
            L001D: return; // RETURN;
        }

        private void FnFNTM_05(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0092  0003 FF 76 08  push word [bp+0x8]
0095  0006 FF 76 06  push word [bp+0x6]
0098  0009 0E     push cs
0099  000A E8 C0 15  call 0x15cd
            L000D: // NOP
            L000E: cx = PopStack(player);
            L000F: cx = PopStack(player);
            L0010: ShowMessage(player, String0507); // The sweet waters of the Fountain of Nectar restore your mana.
            L001D: AddMana(player, 0x2710);
            L002A: return; // RETURN;
        }

        private void FnTELOA_06(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0545); // Pass through this portal to Tipekans.
            L0010: TeleportParty(player, 0x07, 0x01, 0x20, 0x02, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnHURTPIT_07(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x02);
            L0007: PushStack(player, 0x00);
00F2  000A C4 5E 06  les bx, [bp+0x6]
00F5  000D 26 FF 5F 04  call far word [es:bx+0x4]
            L0011: cx = PopStack(player);
            L0012: cx = PopStack(player);
            L0013: RefreshCompareFlags(ax);
            L0015: if (JumpNotEqual) goto L004F;
            L0017: ShowMessage(player, String056B); // The pit isn't as deep as you feared, but you injure your ankle.
            L0024: ax = GetMaxHits(player);
            L002B: bx = 0x000A;
            L002E: dx = ax % bx; ax = ax / bx;
            L0031: DamagePlayer(player, ax);
            L003B: SetFlag(player, 0x00, 0x02, 0x01);
            L004F: return; // RETURN;
        }

        private void FnCLUEB_08(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x002C);
            L0010: ShowMessage(player, String05AB); // You see a dwarf shaking her head. She turns to you and says, 'The graveyard is very dark. You must rely upon your wits and skills to get you through.
            L001D: ShowMessage(player, String0641); // Having something that sheds a little light for you wouldn't hurt, either.'
            L002A: return; // RETURN;
        }

        private void FnSELOCKA_09(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, 0x0D), 0x0006);
            L0012: if (JumpNotBelow) goto L0083;
            L0014: RefreshCompareFlags(HasUsedSpell(player, 0x17));
            L0022: if (JumpNotEqual) goto L0083;
            L0024: PushStack(player, 0x68);
            L0028: PushStack(player, ax);
018E  0029 C4 5E 06  les bx, [bp+0x6]
0191  002C 26 FF 5F 54  call far word [es:bx+0x54]
            L0030: cx = PopStack(player);
            L0031: cx = PopStack(player);
            L0032: RefreshCompareFlags(ax);
            L0034: if (JumpNotEqual) goto L0083;
            L0036: PushStack(player, 0x6E);
            L003A: PushStack(player, ax);
01A0  003B C4 5E 06  les bx, [bp+0x6]
01A3  003E 26 FF 5F 54  call far word [es:bx+0x54]
            L0042: cx = PopStack(player);
            L0043: cx = PopStack(player);
            L0044: RefreshCompareFlags(ax);
            L0046: if (JumpNotEqual) goto L0083;
            L0048: PushStack(player, 0x90);
            L004C: PushStack(player, ax);
01B2  004D C4 5E 06  les bx, [bp+0x6]
01B5  0050 26 FF 5F 54  call far word [es:bx+0x54]
            L0054: cx = PopStack(player);
            L0055: cx = PopStack(player);
            L0056: RefreshCompareFlags(ax);
            L0058: if (JumpNotEqual) goto L0083;
            L005A: PushStack(player, 0xA4);
            L005E: PushStack(player, ax);
01C4  005F C4 5E 06  les bx, [bp+0x6]
01C7  0062 26 FF 5F 54  call far word [es:bx+0x54]
            L0066: cx = PopStack(player);
            L0067: cx = PopStack(player);
            L0068: RefreshCompareFlags(ax);
            L006A: if (JumpNotEqual) goto L0083;
            L006C: ax = IsFlagOn(player, 0x00, 0x01);
            L007E: if (JumpNotEqual) goto L0083;
            L0080: goto L0111;
            L0083: PushStack(player, 0x01);
            L0087: PushStack(player, ax);
            L0088: PushStack(player, 0x00);
01F0  008B C4 5E 06  les bx, [bp+0x6]
01F3  008E 26 FF 1F  call far word [es:bx]
01F6  0091 83 C4 06  add sp, 0x6
            L0094: PushStack(player, 0xC0);
            L0098: PushStack(player, ax);
01FE  0099 C4 5E 06  les bx, [bp+0x6]
0201  009C 26 FF 5F 54  call far word [es:bx+0x54]
            L00A0: cx = PopStack(player);
            L00A1: cx = PopStack(player);
            L00A2: RefreshCompareFlags(ax);
            L00A4: if (JumpNotEqual) goto L00C9;
            L00A6: PushStack(player, 0x6F);
            L00AA: PushStack(player, ax);
0210  00AB C4 5E 06  les bx, [bp+0x6]
0213  00AE 26 FF 5F 54  call far word [es:bx+0x54]
            L00B2: cx = PopStack(player);
            L00B3: cx = PopStack(player);
            L00B4: RefreshCompareFlags(ax);
            L00B6: if (JumpNotEqual) goto L00C9;
            L00B8: Compare(HasUsedSkill(player, 0x0E), 0x0006);
            L00C7: if (JumpBelow) goto L00F2;
022E  00C9 FF 76 08  push word [bp+0x8]
0231  00CC FF 76 06  push word [bp+0x6]
0234  00CF 0E     push cs
0235  00D0 E8 76 14  call 0x1549
            L00D3: // NOP
            L00D4: cx = PopStack(player);
            L00D5: cx = PopStack(player);
023B  00D6 FF 76 08  push word [bp+0x8]
023E  00D9 FF 76 06  push word [bp+0x6]
0241  00DC 0E     push cs
0242  00DD E8 F4 13  call 0x14d4
            L00E0: // NOP
            L00E1: cx = PopStack(player);
            L00E2: cx = PopStack(player);
            L00E3: ShowMessage(player, String068C); // You successfully pick the lock.
            L00F0: goto L011E;
0257  00F2 FF 76 08  push word [bp+0x8]
025A  00F5 FF 76 06  push word [bp+0x6]
025D  00F8 0E     push cs
025E  00F9 E8 2B 14  call 0x1527
            L00FC: // NOP
            L00FD: cx = PopStack(player);
            L00FE: cx = PopStack(player);
0264  00FF FF 76 08  push word [bp+0x8]
0267  0102 FF 76 06  push word [bp+0x6]
026A  0105 0E     push cs
026B  0106 E8 40 14  call 0x1549
            L0109: // NOP
            L010A: cx = PopStack(player);
            L010B: cx = PopStack(player);
0271  010C B8 AC 06  mov ax, 0x6ac
            L010F: goto L00E6;
0276  0111 FF 76 08  push word [bp+0x8]
0279  0114 FF 76 06  push word [bp+0x6]
027C  0117 0E     push cs
027D  0118 E8 0C 14  call 0x1527
            L011B: // NOP
            L011C: cx = PopStack(player);
            L011D: cx = PopStack(player);
            L011E: return; // RETURN;
        }

        private void FnTELEB_0A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x06, 0x01, 0x0D, 0x02, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnTELEC_0B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x06, 0x01, 0xD2, 0x01, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnTELOB_0C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x05, 0x01, 0x46, 0x02, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnTELED_0D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x06, 0x01, 0x48, 0x03, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnKEYA_0E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetGuild(player));
            L000C: if (JumpNotEqual) goto L0075;
            L000E: ax = HasItem(player, 0xD0);
            L001C: if (JumpEqual) goto L0023;
0323  001E B8 CF 06  mov ax, 0x6cf
            L0021: goto L0078;
            L0023: Compare(GetFlag(player, 0x02, 0x45), 0x0001);
            L0037: if (JumpNotEqual) goto L0057;
            L0039: GiveItem(player, 0xD0);
            L0045: ShowMessage(player, String06E2); // You find a key which may open seemingly impassable doors in your race to finish Queen Aeowyn's Map Quest.
0357  0052 B8 4C 07  mov ax, 0x74c
            L0055: goto L0078;
            L0057: GiveItem(player, 0xD0);
            L0063: ShowMessage(player, String0790); // Your Guildmaster left you a special key that will give you access to magical armor.
0375  0070 B8 E4 07  mov ax, 0x7e4
            L0073: goto L0078;
            L0075: ShowMessage(player, String0849); // The room is bare.
            L0082: return; // RETURN;
        }

        private void FnMEDGDA_0F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String085B); // You walk into a lair.
            L0010: ax = HasItem(player, 0xA6);
            L001E: if (JumpEqual) goto L002E;
03A9  0020 B8 E8 03  mov ax, 0x3e8
            L0023: PushStack(player, ax);
            L0024: PushStack(player, 0x00);
            L0027: PushStack(player, ax);
            L0028: PushStack(player, ax);
03B2  0029 B8 9F 00  mov ax, 0x9f
            L002C: goto L003D;
03B7  002E B8 B8 0B  mov ax, 0xbb8
            L0031: PushStack(player, ax);
            L0032: PushStack(player, 0x00);
            L0035: PushStack(player, ax);
            L0036: PushStack(player, 0xC2);
            L003A: PushStack(player, 0xA6);
            L003E: PushStack(player, 0xC0);
03CB  0042 C4 5E 06  les bx, [bp+0x6]
03CE  0045 26 FF 9F D8 00  call far word [es:bx+0xd8]
03D3  004A 83 C4 0C  add sp, 0xc
            L004D: Compare(PartyCount(player), 0x0001);
            L0058: if (JumpNotEqual) goto L0073;
            L005A: PushStack(player, 0x01);
            L005E: PushStack(player, ax);
03E8  005F C4 5E 06  les bx, [bp+0x6]
03EB  0062 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L0067: cx = PopStack(player);
            L0068: cx = PopStack(player);
            L0069: PushStack(player, 0x19);
03F6  006D B8 02 00  mov ax, 0x2
            L0070: goto L00F3;
            L0073: Compare(PartyCount(player), 0x0002);
            L007E: if (JumpNotEqual) goto L00AD;
            L0080: AddEncounter(player, 0x01, 0x02);
            L0092: AddEncounter(player, 0x02, 0x03);
            L00A4: PushStack(player, 0x01);
0431  00A8 B8 06 00  mov ax, 0x6
            L00AB: goto L00F3;
            L00AD: AddEncounter(player, 0x01, 0x02);
            L00BF: PushStack(player, 0x02);
            L00C3: PushStack(player, ax);
044D  00C4 C4 5E 06  les bx, [bp+0x6]
0450  00C7 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L00CC: cx = PopStack(player);
            L00CD: cx = PopStack(player);
            L00CE: PushStack(player, 0x03);
            L00D2: PushStack(player, ax);
045C  00D3 C4 5E 06  les bx, [bp+0x6]
045F  00D6 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L00DB: cx = PopStack(player);
            L00DC: cx = PopStack(player);
            L00DD: PushStack(player, 0x04);
            L00E1: PushStack(player, ax);
046B  00E2 C4 5E 06  les bx, [bp+0x6]
046E  00E5 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L00EA: cx = PopStack(player);
            L00EB: cx = PopStack(player);
            L00EC: AddEncounter(player, 0x05, 0x1B);
            L00FE: return; // RETURN;
        }

        private void FnCLUEC_10(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0029);
            L0010: ShowMessage(player, String0871); // A cleric pulls you aside and whispers, 'It is rumored that there are areas in the dungeon that can be accessed only by certain races or guilds.'
            L001D: return; // RETURN;
        }

        private void FnGLDDRA_11(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetGuild(player));
            L000C: if (JumpNotEqual) goto L0035;
            L000E: ShowMessage(player, String0902); // A sign on the door says, 'BARBARIANS ONLY.'
04C3  001B FF 76 08  push word [bp+0x8]
04C6  001E FF 76 06  push word [bp+0x6]
04C9  0021 0E     push cs
04CA  0022 E8 E1 11  call 0x1206
            L0025: // NOP
            L0026: cx = PopStack(player);
            L0027: cx = PopStack(player);
04D0  0028 FF 76 08  push word [bp+0x8]
04D3  002B FF 76 06  push word [bp+0x6]
04D6  002E 0E     push cs
04D7  002F E8 5F 11  call 0x1191
            L0032: // NOP
            L0033: goto L0040;
04DD  0035 FF 76 08  push word [bp+0x8]
04E0  0038 FF 76 06  push word [bp+0x6]
04E3  003B 0E     push cs
04E4  003C E8 A5 11  call 0x11e4
            L003F: // NOP
            L0040: cx = PopStack(player);
            L0041: cx = PopStack(player);
            L0042: return; // RETURN;
        }

        private void FnTELOC_12(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String092E); // A sign reads 'This path leads to Lake Despair.'
            L0010: TeleportParty(player, 0x05, 0x01, 0x10, 0x03, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnPITTEXT_13(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String095E); // The opening of the ground may have affected the stability of the walls.
0529  0010 FF 76 08  push word [bp+0x8]
052C  0013 FF 76 06  push word [bp+0x6]
052F  0016 0E     push cs
0530  0017 E8 06 11  call 0x1120
            L001A: // NOP
            L001B: cx = PopStack(player);
            L001C: cx = PopStack(player);
            L001D: return; // RETURN;
        }

        private void FnMEDGDB_14(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String09A6); // While admiring the plaques you are attacked.
            L0010: ax = HasItem(player, 0xCD);
            L001E: if (JumpEqual) goto L0032;
0558  0020 B8 DC 05  mov ax, 0x5dc
            L0023: PushStack(player, ax);
            L0024: PushStack(player, 0x00);
            L0027: PushStack(player, ax);
            L0028: PushStack(player, ax);
            L0029: PushStack(player, 0xA5);
0565  002D B8 CC 00  mov ax, 0xcc
            L0030: goto L0042;
056A  0032 B8 B8 0B  mov ax, 0xbb8
            L0035: PushStack(player, ax);
            L0036: PushStack(player, 0x00);
            L0039: PushStack(player, ax);
            L003A: PushStack(player, ax);
            L003B: PushStack(player, 0x9F);
            L003F: PushStack(player, 0xCD);
057B  0043 C4 5E 06  les bx, [bp+0x6]
057E  0046 26 FF 9F D8 00  call far word [es:bx+0xd8]
0583  004B 83 C4 0C  add sp, 0xc
            L004E: Compare(PartyCount(player), 0x0001);
            L0059: if (JumpNotEqual) goto L0064;
            L005B: PushStack(player, 0x08);
0597  005F B8 01 00  mov ax, 0x1
            L0062: goto L00DB;
            L0064: Compare(PartyCount(player), 0x0002);
            L006F: if (JumpNotEqual) goto L008C;
            L0071: AddEncounter(player, 0x01, 0x05);
            L0083: PushStack(player, 0x07);
05BF  0087 B8 02 00  mov ax, 0x2
            L008A: goto L00DB;
            L008C: AddEncounter(player, 0x01, 0x05);
            L009E: AddEncounter(player, 0x02, 0x06);
            L00B0: AddEncounter(player, 0x04, 0x07);
            L00C2: AddEncounter(player, 0x05, 0x09);
            L00D4: AddEncounter(player, 0x06, 0x09);
            L00E6: return; // RETURN;
        }

        private void FnCLUED_15(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String09D3); // You see a plaque on the wall. 'Welcome to the Gallery. Our ancient plaques are informative as well as decorative.'
            L0010: return; // RETURN;
        }

        private void FnDEATHPIT_16(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0A46); // You fall into the Snake Pit and to your death.
0642  0010 FF 76 08  push word [bp+0x8]
0645  0013 FF 76 06  push word [bp+0x6]
0648  0016 0E     push cs
0649  0017 E8 22 10  call 0x103c
            L001A: // NOP
            L001B: cx = PopStack(player);
            L001C: cx = PopStack(player);
            L001D: return; // RETURN;
        }

        private void FnTEXTA_17(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0A75); // You have entered the Cloister. Enjoy your respite on your way to the Gallery.
            L0010: return; // RETURN;
        }

        private void FnMEDGDC_18(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0AC3); // You are attacked by raptors!
            L0010: ax = HasItem(player, 0xB7);
            L001E: if (JumpEqual) goto L0035;
0683  0020 B8 DC 05  mov ax, 0x5dc
            L0023: PushStack(player, ax);
            L0024: PushStack(player, 0x00);
            L0027: PushStack(player, ax);
            L0028: PushStack(player, 0x90);
            L002C: PushStack(player, 0x9D);
0693  0030 B8 B6 00  mov ax, 0xb6
            L0033: goto L004B;
            L0035: AddTreasure(player, 0x0BB8, 0x00, 0x90, 0x9C, 0xA0, 0xB7);
            L0057: Compare(PartyCount(player), 0x0001);
            L0062: if (JumpNotEqual) goto L007F;
            L0064: AddEncounter(player, 0x01, 0x0F);
            L0076: PushStack(player, 0x20);
06DD  007A B8 05 00  mov ax, 0x5
            L007D: goto L00F6;
            L007F: Compare(PartyCount(player), 0x0002);
            L008A: if (JumpNotEqual) goto L00A7;
            L008C: AddEncounter(player, 0x01, 0x0F);
            L009E: PushStack(player, 0x11);
0705  00A2 B8 02 00  mov ax, 0x2
            L00A5: goto L00E4;
            L00A7: AddEncounter(player, 0x01, 0x10);
            L00B9: AddEncounter(player, 0x02, 0x10);
            L00CB: AddEncounter(player, 0x03, 0x11);
            L00DD: AddEncounter(player, 0x04, 0x11);
            L00EF: AddEncounter(player, 0x06, 0x20);
            L0101: return; // RETURN;
        }

        private void FnTELOD_19(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0AE0); // Dark Alley awaits the unwary traveler. Step cautiously as you wander through the darkness.
            L0010: TeleportParty(player, 0x05, 0x01, 0xB6, 0x01, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnTELOE_1B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0B3B); // To the Vineyard.
            L0010: TeleportParty(player, 0x04, 0x01, 0x39, 0x01, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnCLUETP_1C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0B4C); // You find a scrap of paper on the floor with a lost and found message: 'Reward offered for the return of a jeweled lockpick to Tipekans.'
            L0010: return; // RETURN;
        }

        private void FnTELOF_1D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0BD5); // To the Statuary
            L0010: TeleportParty(player, 0x05, 0x01, 0xC7, 0x02, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnSECDR_1F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, 0x0D), 0x0006);
            L0012: if (JumpNotBelow) goto L006C;
            L0014: RefreshCompareFlags(HasUsedSpell(player, 0x17));
            L0022: if (JumpNotEqual) goto L006C;
            L0024: PushStack(player, 0x68);
            L0028: PushStack(player, ax);
0832  0029 C4 5E 06  les bx, [bp+0x6]
0835  002C 26 FF 5F 54  call far word [es:bx+0x54]
            L0030: cx = PopStack(player);
            L0031: cx = PopStack(player);
            L0032: RefreshCompareFlags(ax);
            L0034: if (JumpNotEqual) goto L006C;
            L0036: PushStack(player, 0x6E);
            L003A: PushStack(player, ax);
0844  003B C4 5E 06  les bx, [bp+0x6]
0847  003E 26 FF 5F 54  call far word [es:bx+0x54]
            L0042: cx = PopStack(player);
            L0043: cx = PopStack(player);
            L0044: RefreshCompareFlags(ax);
            L0046: if (JumpNotEqual) goto L006C;
            L0048: PushStack(player, 0x90);
            L004C: PushStack(player, ax);
0856  004D C4 5E 06  les bx, [bp+0x6]
0859  0050 26 FF 5F 54  call far word [es:bx+0x54]
            L0054: cx = PopStack(player);
            L0055: cx = PopStack(player);
            L0056: RefreshCompareFlags(ax);
            L0058: if (JumpNotEqual) goto L006C;
            L005A: PushStack(player, 0xA4);
            L005E: PushStack(player, ax);
0868  005F C4 5E 06  les bx, [bp+0x6]
086B  0062 26 FF 5F 54  call far word [es:bx+0x54]
            L0066: cx = PopStack(player);
            L0067: cx = PopStack(player);
            L0068: RefreshCompareFlags(ax);
            L006A: if (JumpEqual) goto L0093;
            L006C: ShowMessage(player, String0BE5); // A door appears in the wall.
0882  0079 FF 76 08  push word [bp+0x8]
0885  007C FF 76 06  push word [bp+0x6]
0888  007F 0E     push cs
0889  0080 E8 22 0E  call 0xea5
            L0083: // NOP
            L0084: cx = PopStack(player);
            L0085: cx = PopStack(player);
088F  0086 FF 76 08  push word [bp+0x8]
0892  0089 FF 76 06  push word [bp+0x6]
0895  008C 0E     push cs
0896  008D E8 A0 0D  call 0xe30
            L0090: // NOP
            L0091: goto L009E;
089C  0093 FF 76 08  push word [bp+0x8]
089F  0096 FF 76 06  push word [bp+0x6]
08A2  0099 0E     push cs
08A3  009A E8 E6 0D  call 0xe83
            L009D: // NOP
            L009E: cx = PopStack(player);
            L009F: cx = PopStack(player);
            L00A0: return; // RETURN;
        }

        private void FnTPRTVLT_20(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x05, 0x01, 0x08, 0x01, isForwardMove);
            L001E: ShowMessage(player, String0C01); // To the Vault
            L002B: return; // RETURN;
        }

        private void FnSETEXT_21(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0C0E); // Some of the walls appear to have been reconstructed.
            L0010: return; // RETURN;
        }

        private void FnTAPA_22(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetRace(player));
            L000C: if (JumpNotEqual) goto L0013;
08F8  000E B8 43 0C  mov ax, 0xc43
            L0011: goto L0016;
            L0013: ShowMessage(player, String0C81); // The plaque is worn and unreadable.
            L0020: return; // RETURN;
        }

        private void FnTAPB_23(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetRace(player), 0x0004);
            L000D: if (JumpNotEqual) goto L0014;
091B  000F B8 A4 0C  mov ax, 0xca4
            L0012: goto L0017;
            L0014: ShowMessage(player, String0CE0); // The plaque is cracked down the center.
            L0021: return; // RETURN;
        }

        private void FnTAPC_24(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetRace(player), 0x0006);
            L000D: if (JumpNotEqual) goto L0014;
093E  000F B8 07 0D  mov ax, 0xd07
            L0012: goto L0017;
            L0014: ShowMessage(player, String0D4A); // You cannot read the plaque.
            L0021: return; // RETURN;
        }

        private void FnTELOG_25(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0D66); // The eerie sounds coming from the Graveyard make you wonder if you should step through this teleport.
            L0010: TeleportParty(player, 0x05, 0x03, 0x0F, 0x00, isForwardMove);
            L002A: return; // RETURN;
        }

        private void FnTELOH_26(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0DCB); // Through this teleport you will find the Breezeway.
            L0010: TeleportParty(player, 0x04, 0x01, 0x80, 0x03, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnPCPICK_27(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0xDD);
            L0011: if (JumpEqual) goto L0062;
            L0013: Compare(PartyCount(player), 0x0001);
            L001E: if (JumpNotEqual) goto L0040;
            L0020: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L003E: goto L008C;
            L0040: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
0A08  005D B8 FE 0D  mov ax, 0xdfe
            L0060: goto L0082;
            L0062: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L007F: ShowMessage(player, String0E65); // Smirk grabs you by the collar before you can sneak through the door. 'Have you no sense? Return when you have the item I desire!'
            L008C: return; // RETURN;
        }

        private void FnTAPD_28(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetRace(player), 0x0003);
            L000D: if (JumpNotEqual) goto L0014;
0A48  000F B8 E7 0E  mov ax, 0xee7
            L0012: goto L0017;
            L0014: ShowMessage(player, String0F2E); // This plaque appears chipped.
            L0021: return; // RETURN;
        }

        private void FnKEYB_29(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetGuild(player), 0x0002);
            L000D: if (JumpNotEqual) goto L0076;
            L000F: ax = HasItem(player, 0xD0);
            L001D: if (JumpEqual) goto L0024;
0A7B  001F B8 CF 06  mov ax, 0x6cf
            L0022: goto L0079;
            L0024: Compare(GetFlag(player, 0x02, 0x45), 0x0001);
            L0038: if (JumpNotEqual) goto L0058;
            L003A: GiveItem(player, 0xD0);
            L0046: ShowMessage(player, String06E2); // You find a key which may open seemingly impassable doors in your race to finish Queen Aeowyn's Map Quest.
0AAF  0053 B8 4C 07  mov ax, 0x74c
            L0056: goto L0079;
            L0058: GiveItem(player, 0xD0);
            L0064: ShowMessage(player, String0790); // Your Guildmaster left you a special key that will give you access to magical armor.
0ACD  0071 B8 E4 07  mov ax, 0x7e4
            L0074: goto L0079;
            L0076: ShowMessage(player, String0849); // The room is bare.
            L0083: return; // RETURN;
        }

        private void FnGLDDRB_2A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetGuild(player), 0x0002);
            L000D: if (JumpNotEqual) goto L0036;
            L000F: ShowMessage(player, String0F4B); // A sign on the door says, 'RANGERS ONLY.'
0AFD  001C FF 76 08  push word [bp+0x8]
0B00  001F FF 76 06  push word [bp+0x6]
0B03  0022 0E     push cs
0B04  0023 E8 A7 0B  call 0xbcd
            L0026: // NOP
            L0027: cx = PopStack(player);
            L0028: cx = PopStack(player);
0B0A  0029 FF 76 08  push word [bp+0x8]
0B0D  002C FF 76 06  push word [bp+0x6]
0B10  002F 0E     push cs
0B11  0030 E8 25 0B  call 0xb58
            L0033: // NOP
            L0034: goto L0041;
0B17  0036 FF 76 08  push word [bp+0x8]
0B1A  0039 FF 76 06  push word [bp+0x6]
0B1D  003C 0E     push cs
0B1E  003D E8 6B 0B  call 0xbab
            L0040: // NOP
            L0041: cx = PopStack(player);
            L0042: cx = PopStack(player);
            L0043: return; // RETURN;
        }

        private void FnFTNH_2B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0B29  0003 FF 76 08  push word [bp+0x8]
0B2C  0006 FF 76 06  push word [bp+0x6]
0B2F  0009 0E     push cs
0B30  000A E8 29 0B  call 0xb36
            L000D: // NOP
            L000E: cx = PopStack(player);
            L000F: cx = PopStack(player);
            L0010: Compare(GetGuild(player), 0x0005);
            L001A: if (JumpNotEqual) goto L0053;
            L001C: RefreshCompareFlags(GetSkillLevel(player, 0x08));
            L002A: if (JumpNotEqual) goto L0043;
            L002C: SetSkillLevel(player, 0x08, 0x01);
0B63  003D B8 74 0F  mov ax, 0xf74
            L0040: goto L00EF;
0B69  0043 FF 76 08  push word [bp+0x8]
0B6C  0046 FF 76 06  push word [bp+0x6]
0B6F  0049 0E     push cs
0B70  004A E8 B4 0A  call 0xb01
            L004D: // NOP
            L004E: cx = PopStack(player);
            L004F: cx = PopStack(player);
            L0050: goto L00F9;
            L0053: Compare(GetGuild(player), 0x0001);
            L005D: if (JumpEqual) goto L0077;
            L005F: Compare(GetGuild(player), 0x0003);
            L0069: if (JumpEqual) goto L0077;
            L006B: Compare(GetGuild(player), 0x0002);
            L0075: if (JumpNotEqual) goto L009D;
            L0077: RefreshCompareFlags(GetSkillLevel(player, 0x00));
            L0084: if (JumpNotEqual) goto L009B;
            L0086: SetSkillLevel(player, 0x00, 0x01);
0BBC  0096 B8 AE 0F  mov ax, 0xfae
            L0099: goto L00EF;
            L009B: goto L0043;
            L009D: Compare(GetGuild(player), 0x0004);
            L00A7: if (JumpNotEqual) goto L00EC;
            L00A9: RefreshCompareFlags(GetFlag(player, 0x02, 0xD5));
            L00BC: if (JumpNotEqual) goto L00E9;
            L00BE: SetSpellLevel(player, 0x12, 0x01);
            L00CF: SetFlag(player, 0x02, 0xD5, 0x01);
0C0A  00E4 B8 EA 0F  mov ax, 0xfea
            L00E7: goto L00EF;
            L00E9: goto L0043;
            L00EC: ShowMessage(player, String1022); // Journey's End Fountain is dry.
            L00F9: return; // RETURN;
        }

        private void FnCLUEE_2C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x001B);
            L0010: ShowMessage(player, String1041); // You meet a Cavalier who says, 'I've heard tell of a special lantern that has proven very helpful in opening a certain door.
            L001D: ShowMessage(player, String10BD); // The door is somewhere in the dark, or so I'm told.'
            L002A: return; // RETURN;
        }

        private void FnRUBYA_2D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0xDD);
            L0007: PushStack(player, ax);
0C55  0008 C4 5E 06  les bx, [bp+0x6]
0C58  000B 26 FF 5F 54  call far word [es:bx+0x54]
            L000F: cx = PopStack(player);
            L0010: cx = PopStack(player);
            L0011: RefreshCompareFlags(ax);
            L0013: if (JumpEqual) goto L0034;
0C62  0015 FF 76 08  push word [bp+0x8]
0C65  0018 FF 76 06  push word [bp+0x6]
0C68  001B 0E     push cs
0C69  001C E8 CD 09  call 0x9ec
            L001F: // NOP
            L0020: cx = PopStack(player);
            L0021: cx = PopStack(player);
0C6F  0022 FF 76 08  push word [bp+0x8]
0C72  0025 FF 76 06  push word [bp+0x6]
0C75  0028 0E     push cs
0C76  0029 E8 35 0A  call 0xa61
            L002C: // NOP
            L002D: cx = PopStack(player);
            L002E: cx = PopStack(player);
0C7C  002F B8 F1 10  mov ax, 0x10f1
            L0032: goto L0044;
0C81  0034 FF 76 08  push word [bp+0x8]
0C84  0037 FF 76 06  push word [bp+0x6]
0C87  003A 0E     push cs
0C88  003B E8 01 0A  call 0xa3f
            L003E: // NOP
            L003F: cx = PopStack(player);
            L0040: cx = PopStack(player);
            L0041: ShowMessage(player, String1109); // The entrance to Smirk's Emporium is locked.
            L004E: return; // RETURN;
        }

        private void FnTELOI_2E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x07, 0x01, 0xDA, 0x03, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnTAPE_2F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetRace(player), 0x0005);
            L000D: if (JumpNotEqual) goto L0014;
0CCC  000F B8 35 11  mov ax, 0x1135
            L0012: goto L0017;
            L0014: ShowMessage(player, String0C81); // The plaque is worn and unreadable.
            L0021: return; // RETURN;
        }

        private void FnFTNP_30(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x03);
            L0007: PushStack(player, 0x00);
0CEA  000A C4 5E 06  les bx, [bp+0x6]
0CED  000D 26 FF 5F 04  call far word [es:bx+0x4]
            L0011: cx = PopStack(player);
            L0012: cx = PopStack(player);
            L0013: RefreshCompareFlags(ax);
            L0015: if (JumpNotEqual) goto L0066;
0CF7  0017 FF 76 08  push word [bp+0x8]
0CFA  001A FF 76 06  push word [bp+0x6]
0CFD  001D 0E     push cs
0CFE  001E E8 5B 09  call 0x97c
            L0021: // NOP
            L0022: cx = PopStack(player);
            L0023: cx = PopStack(player);
            L0024: ShowMessage(player, String1181); // The stagnant waters of the Trough are poisonous!
            L0031: ax = GetMaxHits(player);
            L0038: bx = 0x000A;
            L003B: dx = ax % bx; ax = ax / bx;
            L003E: PushStack(player, ax);
            L003F: PushStack(player, 0x0A);
            L0043: PushStack(player, 0x01);
0D27  0047 C4 5E 06  les bx, [bp+0x6]
0D2A  004A 26 FF 9F 9C 00  call far word [es:bx+0x9c]
0D2F  004F 83 C4 06  add sp, 0x6
            L0052: SetFlag(player, 0x00, 0x03, 0x01);
            L0066: return; // RETURN;
        }

        private void FnCLUEF_31(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0029);
            L0010: ShowMessage(player, String11B2); // A monk breaks his silence and whispers, 'Search well, for there are places in the dungeon where your attributes can be enhanced.'
            L001D: return; // RETURN;
        }

        private void FnSCHARM_32(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0xD1);
            L0011: if (JumpEqual) goto L0030;
            L0013: RemoveItem(player, 0xD1);
            L001F: GiveItem(player, 0xD7);
0D92  002B B8 34 12  mov ax, 0x1234
            L002E: goto L0033;
            L0030: ShowMessage(player, String128C); // The room is too dark for you to see. A portable light would prove most useful here,
            L003D: return; // RETURN;
        }

        private void FnSMIRK_33(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetNoJoinArea(player);
            L000B: ShowPortrait(player, 0x0025);
            L0018: ax = HasItem(player, 0xDD);
            L0026: if (JumpEqual) goto L002D;
0DCE  0028 B8 E0 12  mov ax, 0x12e0
            L002B: goto L0030;
            L002D: ShowMessage(player, String135A); // Smirk cautions you not to go beyond this point without the lockpick.
            L003A: return; // RETURN;
        }

        private void FnTAPF_34(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetRace(player), 0x0001);
            L000D: if (JumpNotEqual) goto L0014;
0DF1  000F B8 9F 13  mov ax, 0x139f
            L0012: goto L0017;
            L0014: ShowMessage(player, String0CE0); // The plaque is cracked down the center.
            L0021: return; // RETURN;
        }

        private void FnTAPG_35(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetRace(player), 0x0002);
            L000D: if (JumpNotEqual) goto L0014;
0E14  000F B8 E9 13  mov ax, 0x13e9
            L0012: goto L0017;
            L0014: ShowMessage(player, String142C); // The etchings on the plaque are unintelligible.
            L0021: return; // RETURN;
        }

        private void FnTAPH_36(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetRace(player), 0x0007);
            L000D: if (JumpNotEqual) goto L0014;
0E37  000F B8 5B 14  mov ax, 0x145b
            L0012: goto L0017;
            L0014: ShowMessage(player, String1499); // You see nothing of interest on the plaque.
            L0021: return; // RETURN;
        }

        private void FnTELOJ_37(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x06, 0x01, 0xA1, 0x00, isForwardMove);
            L001D: return; // RETURN;
        }

        private void FnFTNMH_38(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0E6D  0003 FF 76 08  push word [bp+0x8]
0E70  0006 FF 76 06  push word [bp+0x6]
0E73  0009 0E     push cs
0E74  000A E8 E5 07  call 0x7f2
            L000D: // NOP
            L000E: cx = PopStack(player);
            L000F: cx = PopStack(player);
            L0010: ShowMessage(player, String14C4); // Equestrian Fountain rejuvenates your health and mana.
0E87  001D FF 76 08  push word [bp+0x8]
0E8A  0020 FF 76 06  push word [bp+0x6]
0E8D  0023 0E     push cs
0E8E  0024 E8 40 08  call 0x867
            L0027: // NOP
            L0028: cx = PopStack(player);
            L0029: cx = PopStack(player);
            L002A: return; // RETURN;
        }

        private void FnCLUCLU_39(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x001B);
            L0010: ShowMessage(player, String14FA); // 'Once you have the four map pieces the Queen seeks, make sure you know the order of the jewels before you seek your reward.
            L001D: ShowMessage(player, String1576); // Three clues are available for each race. I have found two and am now after the third. You must read all three clues, or you will not be rewarded.'
            L002A: return; // RETURN;
        }

        private void FnDTHDR_3A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0xDD);
            L0007: PushStack(player, ax);
0ECA  0008 C4 5E 06  les bx, [bp+0x6]
0ECD  000B 26 FF 5F 54  call far word [es:bx+0x54]
            L000F: cx = PopStack(player);
            L0010: cx = PopStack(player);
            L0011: RefreshCompareFlags(ax);
            L0013: if (JumpEqual) goto L002F;
            L0015: ShowMessage(player, String1609); // You are killed by Smirk who mistakes you for a robber.
0EE4  0022 FF 76 08  push word [bp+0x8]
0EE7  0025 FF 76 06  push word [bp+0x6]
0EEA  0028 0E     push cs
0EEB  0029 E8 80 07  call 0x7ac
            L002C: // NOP
            L002D: goto L0047;
            L002F: ShowMessage(player, String1640); // Back door to Smirk's Emporium.
0EFE  003C FF 76 08  push word [bp+0x8]
0F01  003F FF 76 06  push word [bp+0x6]
0F04  0042 0E     push cs
0F05  0043 E8 84 07  call 0x7ca
            L0046: // NOP
            L0047: cx = PopStack(player);
            L0048: cx = PopStack(player);
            L0049: return; // RETURN;
        }

        private void FnCLUEG_3B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x001D);
            L0010: ShowMessage(player, String165F); // 'I was told that in this area there are hidden rooms. A few rooms are available only to specific guilds.
            L001D: ShowMessage(player, String16C8); // Beyond one hidden door is a second secretive door. That door leads to... Well, I think you should discover where that door leads.'
            L002A: return; // RETURN;
        }

        private void FnLJ_3C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0xE1);
            L0011: if (JumpEqual) goto L0031;
0F4C  0013 B8 E8 03  mov ax, 0x3e8
            L0016: PushStack(player, ax);
            L0017: PushStack(player, 0x00);
            L001A: PushStack(player, ax);
            L001B: PushStack(player, ax);
            L001C: PushStack(player, 0x74);
            L0020: PushStack(player, 0x8A);
0F5D  0024 C4 5E 06  les bx, [bp+0x6]
0F60  0027 26 FF 9F D8 00  call far word [es:bx+0xd8]
0F65  002C 83 C4 0C  add sp, 0xc
            L002F: goto L0057;
0F6A  0031 B8 B8 0B  mov ax, 0xbb8
            L0034: PushStack(player, ax);
            L0035: PushStack(player, 0x00);
            L0038: PushStack(player, ax);
            L0039: PushStack(player, ax);
            L003A: PushStack(player, ax);
            L003B: PushStack(player, 0xE1);
0F78  003F C4 5E 06  les bx, [bp+0x6]
0F7B  0042 26 FF 9F D8 00  call far word [es:bx+0xd8]
0F80  0047 83 C4 0C  add sp, 0xc
            L004A: ShowMessage(player, String174B); // You see a group of monsters tearing at a life jacket.
            L0057: Compare(PartyCount(player), 0x0001);
            L0062: if (JumpNotEqual) goto L0080;
            L0064: AddEncounter(player, 0x01, 0x02);
            L0076: PushStack(player, 0x07);
0FB3  007A B8 02 00  mov ax, 0x2
            L007D: goto L0126;
            L0080: Compare(PartyCount(player), 0x0002);
            L008B: if (JumpNotEqual) goto L00C5;
            L008D: PushStack(player, 0x01);
            L0091: PushStack(player, ax);
0FCB  0092 C4 5E 06  les bx, [bp+0x6]
0FCE  0095 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L009A: cx = PopStack(player);
            L009B: cx = PopStack(player);
            L009C: AddEncounter(player, 0x02, 0x03);
            L00AE: AddEncounter(player, 0x05, 0x07);
0FF9  00C0 B8 08 00  mov ax, 0x8
            L00C3: goto L0122;
            L00C5: AddEncounter(player, 0x01, 0x03);
            L00D7: AddEncounter(player, 0x02, 0x03);
            L00E9: AddEncounter(player, 0x03, 0x01);
            L00FB: AddEncounter(player, 0x04, 0x01);
            L010D: AddEncounter(player, 0x05, 0x08);
            L011F: AddEncounter(player, 0x06, 0x09);
            L0131: return; // RETURN;
        }

        private void FnTELOK_3D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1781); // You can see it's a long, hard climb up to Cliffhanger.
            L0010: TeleportParty(player, 0x04, 0x01, 0x7F, 0x00, isForwardMove);
            L002A: return; // RETURN;
        }

        private void FnTEXTB_40(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String17B8); // The Wine Cellar is dark and damp.
            L0010: return; // RETURN;
        }

        private void FnMEDA_41(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L002C;
            L0010: AddEncounter(player, 0x01, 0x14);
            L0022: PushStack(player, 0x1A);
10DA  0026 B8 02 00  mov ax, 0x2
            L0029: goto L00C7;
            L002C: Compare(PartyCount(player), 0x0002);
            L0037: if (JumpNotEqual) goto L0078;
            L0039: AddEncounter(player, 0x01, 0x1A);
            L004B: AddEncounter(player, 0x02, 0x1A);
            L005D: AddEncounter(player, 0x03, 0x27);
            L006F: PushStack(player, 0x28);
1127  0073 B8 04 00  mov ax, 0x4
            L0076: goto L00C7;
            L0078: AddEncounter(player, 0x01, 0x15);
            L008A: AddEncounter(player, 0x02, 0x26);
            L009C: AddEncounter(player, 0x04, 0x26);
            L00AE: AddEncounter(player, 0x05, 0x27);
            L00C0: AddEncounter(player, 0x06, 0x28);
            L00D2: return; // RETURN;
        }

        private void FnMEDB_42(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L002C;
            L0010: AddEncounter(player, 0x01, 0x0F);
            L0022: PushStack(player, 0x20);
11AE  0026 B8 02 00  mov ax, 0x2
            L0029: goto L00B1;
            L002C: Compare(PartyCount(player), 0x0002);
            L0037: if (JumpNotEqual) goto L0062;
            L0039: AddEncounter(player, 0x01, 0x10);
            L004B: AddEncounter(player, 0x02, 0x11);
11E5  005D B8 0B 00  mov ax, 0xb
            L0060: goto L00AD;
            L0062: AddEncounter(player, 0x01, 0x10);
            L0074: AddEncounter(player, 0x02, 0x10);
            L0086: AddEncounter(player, 0x03, 0x11);
            L0098: AddEncounter(player, 0x05, 0x0E);
            L00AA: AddEncounter(player, 0x06, 0x0A);
            L00BC: return; // RETURN;
        }

        private void FnMEDC_43(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L002C;
            L0010: AddEncounter(player, 0x01, 0x0E);
            L0022: PushStack(player, 0x1C);
126C  0026 B8 02 00  mov ax, 0x2
            L0029: goto L00B5;
            L002C: Compare(PartyCount(player), 0x0002);
            L0037: if (JumpNotEqual) goto L0066;
            L0039: AddEncounter(player, 0x01, 0x0D);
            L004B: AddEncounter(player, 0x02, 0x0E);
            L005D: PushStack(player, 0x1F);
12A7  0061 B8 04 00  mov ax, 0x4
            L0064: goto L00B5;
            L0066: AddEncounter(player, 0x01, 0x0D);
            L0078: AddEncounter(player, 0x02, 0x0D);
            L008A: AddEncounter(player, 0x03, 0x0E);
            L009C: AddEncounter(player, 0x04, 0x0E);
            L00AE: AddEncounter(player, 0x06, 0x21);
            L00C0: return; // RETURN;
        }

        private void FnHRDA_44(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L002C;
            L0010: AddEncounter(player, 0x01, 0x1D);
            L0022: PushStack(player, 0x1D);
132E  0026 B8 02 00  mov ax, 0x2
            L0029: goto L0122;
            L002C: Compare(PartyCount(player), 0x0002);
            L0037: if (JumpNotEqual) goto L0063;
            L0039: AddEncounter(player, 0x01, 0x06);
            L004B: AddEncounter(player, 0x02, 0x07);
1365  005D B8 24 00  mov ax, 0x24
            L0060: goto L011E;
            L0063: Compare(PartyCount(player), 0x0003);
            L006E: if (JumpNotEqual) goto L00C1;
            L0070: AddEncounter(player, 0x01, 0x05);
            L0082: AddEncounter(player, 0x02, 0x06);
            L0094: AddEncounter(player, 0x03, 0x15);
            L00A6: AddEncounter(player, 0x04, 0x13);
            L00B8: PushStack(player, 0x14);
13C4  00BC B8 05 00  mov ax, 0x5
            L00BF: goto L0122;
            L00C1: AddEncounter(player, 0x01, 0x05);
            L00D3: AddEncounter(player, 0x02, 0x06);
            L00E5: AddEncounter(player, 0x03, 0x25);
            L00F7: AddEncounter(player, 0x04, 0x26);
            L0109: AddEncounter(player, 0x05, 0x28);
            L011B: AddEncounter(player, 0x06, 0x28);
            L012D: return; // RETURN;
        }

        private void FnEZA_45(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L0028;
            L0010: PushStack(player, 0x01);
            L0014: PushStack(player, ax);
144C  0015 C4 5E 06  les bx, [bp+0x6]
144F  0018 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L001D: cx = PopStack(player);
            L001E: cx = PopStack(player);
            L001F: PushStack(player, 0x01);
145A  0023 B8 02 00  mov ax, 0x2
            L0026: goto L009C;
            L0028: Compare(PartyCount(player), 0x0002);
            L0033: if (JumpNotEqual) goto L005F;
            L0035: AddEncounter(player, 0x01, 0x02);
            L0047: PushStack(player, 0x02);
            L004B: PushStack(player, ax);
1483  004C C4 5E 06  les bx, [bp+0x6]
1486  004F 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L0054: cx = PopStack(player);
            L0055: cx = PopStack(player);
            L0056: PushStack(player, 0x0F);
1491  005A B8 06 00  mov ax, 0x6
            L005D: goto L009C;
            L005F: AddEncounter(player, 0x01, 0x02);
            L0071: AddEncounter(player, 0x02, 0x03);
            L0083: AddEncounter(player, 0x03, 0x10);
            L0095: AddEncounter(player, 0x04, 0x11);
            L00A7: return; // RETURN;
        }

        private void FnHRDB_46(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L002C;
            L0010: AddEncounter(player, 0x01, 0x14);
            L0022: PushStack(player, 0x28);
1506  0026 B8 02 00  mov ax, 0x2
            L0029: goto L0130;
            L002C: Compare(PartyCount(player), 0x0002);
            L0037: if (JumpNotEqual) goto L0075;
            L0039: AddEncounter(player, 0x01, 0x15);
            L004B: AddEncounter(player, 0x02, 0x15);
            L005D: AddEncounter(player, 0x03, 0x17);
154F  006F B8 28 00  mov ax, 0x28
            L0072: goto L012C;
            L0075: Compare(PartyCount(player), 0x0003);
            L0080: if (JumpNotEqual) goto L00CF;
            L0082: AddEncounter(player, 0x01, 0x23);
            L0094: AddEncounter(player, 0x02, 0x26);
            L00A6: AddEncounter(player, 0x03, 0x25);
            L00B8: AddEncounter(player, 0x05, 0x16);
15AA  00CA B8 18 00  mov ax, 0x18
            L00CD: goto L012C;
            L00CF: AddEncounter(player, 0x01, 0x17);
            L00E1: AddEncounter(player, 0x02, 0x27);
            L00F3: AddEncounter(player, 0x03, 0x24);
            L0105: AddEncounter(player, 0x04, 0x24);
            L0117: AddEncounter(player, 0x05, 0x22);
            L0129: AddEncounter(player, 0x06, 0x22);
            L013B: return; // RETURN;
        }

        private void Fn_48(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: return; // RETURN;
            // Extra data: 55 8B EC B8 DA 17 50 C4 5E 06 26 FF 9F F8 00 59 5D CB 55 8B EC B8 01 00 50 C4 5E 06 26 FF 5F 24 50 C4 5E 06 26 FF 5F 20 50 C4 5E 06 26 FF 5F 2C 83 C4 06 5D CB 55 8B EC B8 42 00 50 C4 5E 06 26 FF 9F FC 00 59 5D CB 55 8B EC C4 5E 06 26 FF 5F 74 50 C4 5E 06 26 FF 9F 90 00 59 C4 5E 06 26 FF 9F C0 00 5D CB 55 8B EC 33 C0 50 C4 5E 06 26 FF 5F 24 50 C4 5E 06 26 FF 5F 20 50 C4 5E 06 26 FF 5F 2C 83 C4 06 5D CB 55 8B EC C4 5E 06 26 FF 5F 24 50 C4 5E 06 26 FF 5F 20 50 B8 01 00 50 C4 5E 06 26 FF 5F 30 83 C4 06 5D CB 55 8B EC C4 5E 06 26 FF 5F 74 50 C4 5E 06 26 FF 9F 94 00 59 B8 10 27 50 C4 5E 06 26 FF 9F B4 00 59 5D CB 
        }

    }
}
