#pragma warning disable
using System.Collections.Generic;
using XPT.WorldData;
using XPT.WorldData.Yserbius;

namespace XPT.Scripts.Yserbius.Maps {
    class YserMap13 : AMapScripted {
        protected override int MapIndex => 13;
        protected override int RandomEncounterChance => 10;
        protected override int RandomEncounterExtraCount => 0;

        public YserMap13() {
            MapEvent01 = FnTELOA_01;
            MapEvent02 = FnNOMAP_02;
            MapEvent03 = FnGATEMSG_03;
            MapEvent04 = FnTELOB_04;
            MapEvent05 = FnXANITH_05;
            MapEvent06 = FnSECA_06;
            MapEvent07 = FnMSGA_07;
            MapEvent08 = FnCLUEA_08;
            MapEvent09 = FnGOODIEA_09;
            MapEvent0A = FnFTNA_0A;
            MapEvent0B = FnTELEA_0B;
            MapEvent0C = FnSECB_0C;
            MapEvent0D = FnGOODIEB_0D;
            MapEvent0E = FnHEALDOWN_0E;
            MapEvent0F = FnBONES_0F;
            MapEvent10 = FnILL_10;
            MapEvent11 = FnLOCKP_11;
            MapEvent12 = FnFTNB_12;
            MapEvent13 = FnTELEB_13;
            MapEvent14 = FnDEATH_14;
            MapEvent15 = FnTOMB_15;
            MapEvent16 = FnLIGHT_16;
            MapEvent17 = FnTELEC_17;
            MapEvent18 = FnGOODIEC_18;
            MapEvent19 = FnGOODIED_19;
            MapEvent1A = FnTOMBONE_1A;
            MapEvent1B = FnBONESTWO_1B;
            MapEvent1C = FnTOMBTHRE_1C;
            MapEvent1D = FnPCBAT_1D;
            MapEvent1E = FnTOMLTE_1E;
            MapEvent1F = FnHANDHLDR_1F;
            MapEvent20 = FnTEXTA_20;
            MapEvent21 = FnTEXTB_21;
            MapEvent22 = FnTEXTC_22;
            MapEvent23 = FnPARTYCT_23;
            MapEvent24 = FnITADOOR_24;
            MapEvent25 = FnITBDOOR_25;
            MapEvent26 = FnCLUEB_26;
            MapEvent27 = FnTEXTD_27;
            MapEvent28 = FnTEXTE_28;
            MapEvent29 = FnCLUEC_29;
            MapEvent2A = FnTEXTF_2A;
            MapEvent2B = FnTEXTG_2B;
            MapEvent2C = FnSLIP_2C;
            MapEvent2D = FnTELOC_2D;
            MapEvent2E = FnTEXTH_2E;
            MapEvent2F = FnTEXTI_2F;
            MapEvent30 = FnILLHOLDR_30;
            MapEvent31 = FnFTNC_31;
            MapEvent32 = FnMDAMON_32;
            MapEvent33 = FnMEDBMON_33;
            MapEvent34 = FnMEDCMON_34;
            MapEvent35 = FnEZAMON_35;
            MapEvent36 = FnHARDA_36;
            MapEvent37 = FnWRNING_37;
            MapEvent38 = FnCGRT_38;
            MapEvent39 = FnSPCLU_39;
        }
        
        // === Strings ================================================
        private const string String03FC = "To Carriage House";
        private const string String040E = "Darkness envelops you as you enter the Graveyard. You can barely read the sign which says, 'NorthEast Gate.'";
        private const string String047B = "All that you can see on the door ahead is Sn k  P t.";
        private const string String04B0 = "You meet Xanith the Cartographer, who is trying to map the cemetery.";
        private const string String04F5 = "'Ah, more adventurers on the way to my shop! Have you mastered the dungeon thus far?";
        private const string String054A = "I hope you've found the secret clues that equal the number of Snicker's brothers.";
        private const string String059C = "If you have not, my assistants' payments will be of no value to you.'";
        private const string String05E2 = "The tomb door opens.";
        private const string String05F7 = "You see the NorthEast Gate to the East.";
        private const string String061F = "A Gravedigger appears and wags a bony finger at you.";
        private const string String0654 = "'All tombs do not contain treasure, you know. Some harbor grave rewards.'";
        private const string String069E = "Disturbed graveyard spirits attack you.";
        private const string String06C6 = "Angel Fountain replenishes your Health and Mana.";
        private const string String06F7 = "The shadows of death that clutch at you evaporate as you are spirited to safety.";
        private const string String0748 = "You discover a long forgotten door.";
        private const string String076C = "You disturb the souls of the entombed.";
        private const string String0793 = "A clumsy fall into an open grave injures you.";
        private const string String07C1 = "Scattered bones are all that's left of looted tombs.";
        private const string String07F6 = "You have successfully unlocked the tomb door.";
        private const string String0824 = "The door to the old tomb is locked.";
        private const string String0848 = "Skeletal Fountain gives you the Furtiveness Skill.";
        private const string String087B = "The waters of Skeletal Fountain quench your thirst.";
        private const string String08AF = "Skeletal Fountain gives you the Pickpocket Skill.";
        private const string String08E1 = "Skeletal Fountain gives you the power to refresh your party.";
        private const string String091E = "The howling wind uproots you and carries you off.";
        private const string String0950 = "Graverobbers, hearing your approach, ambush you. Sharp steel slices across your torso!";
        private const string String09A7 = "Searching the musty tomb unearths a few items concealed behind some rubble.";
        private const string String09F3 = "You are rewarded for your insight.";
        private const string String0A16 = "The tomb appears to be a good hiding place, but your search this time is futile.";
        private const string String0A67 = "The torch flares, lighting your lantern. You catch a brief glimpse of the graveyard before the wind douses your flame.";
        private const string String0ADE = "The torch does not cast enough illumination to light your path, nor can it be removed.";
        private const string String0B35 = "A portable source of light would be particularly useful in the Graveyard.";
        private const string String0B7F = "You become dizzy and sense that you are no longer inside the tomb.";
        private const string String0BC2 = "You stumble upon grave robbers ransacking a tomb.";
        private const string String0BF4 = "You encounter scavengers.";
        private const string String0C0E = "The worn tombstone bears the inscription, 'Wilthorg Zerium.'";
        private const string String0C4B = "You stumble upon the remains of Yartor Megilthorn.";
        private const string String0C7E = "The inscription on the tombstone has been eroded beyond recognition by the elements.";
        private const string String0CD3 = "The magical aura emanating from the tomb lights your lantern for a brief moment.";
        private const string String0D24 = "You overhear a group of adventurers discussing the strange flickering of their lantern in the tomb.";
        private const string String0D88 = "The volcanic activity has weakened some of the walls and tomb doors in this area.";
        private const string String0DDA = "A ghostly voice whispers, 'To the South you will meet four Spirits. Each will offer you a gift.";
        private const string String0E3A = "Choose wisely for you will be able to accept only one gift. Once your decision is made, enter the door of your choice.'";
        private const string String0EB2 = "The sorrowful wind whispers -";
        private const string String0ED0 = "'The Spirit to the East offers the gift of increased Strength.'";
        private const string String0F10 = "You've already chosen your gift.";
        private const string String0F31 = "The Spirit of a Warrior endows you with increased Strength.";
        private const string String0F6D = "You may rejoin your party.";
        private const string String0F88 = "The Luminous Lantern glows feebly for a few moments.";
        private const string String0FBD = "You barely detect a rusty bolt that locks the mildewed door.";
        private const string String0FFA = "A moment later, the bolt is thrown and the door is open.";
        private const string String1033 = "A locked door bars your way. Perhaps if you had a bit of light you could determine the cause.";
        private const string String1091 = "A large sign warns -";
        private const string String10A6 = "'DO NOT ENTER unless you have all four map pieces or have completed the Queen's map quest. Proceed through this door alone and rejoin your party on the other side.'";
        private const string String114B = "Your entry is barred.";
        private const string String1161 = "'Word has it that pieces of the map are scattered throughout the levels of the dungeon.'";
        private const string String11BA = "A haunted voice quavers -";
        private const string String11D4 = "'The Spirit to the East will offer the gift of increased Defense.'";
        private const string String1217 = "The Spirit of a Guard endows you with increased Defense.";
        private const string String1250 = "'Trust the wrong thief with your goods and you may end up here permanently.'";
        private const string String129D = "A distant wraith wails -";
        private const string String12B6 = "'The Spirit to the East blesses with the gift of increased Agility.'";
        private const string String12FB = "The Spirit of an Athlete endows you with increased Agility.";
        private const string String1337 = "The ground gives way and you slide into The Crypt.";
        private const string String136A = "As you approach the portal to the Cartography Shop, your Skeleton Key tumbles to the ground and is lost in the mud.";
        private const string String13DE = "The portal marks the entrance to the Cartography Shop.";
        private const string String1415 = "A nearby owl hoots -";
        private const string String142A = "'The Spirit to the East can give you a gift that increases Initiative.'";
        private const string String1472 = "The Spirit of a Cavalier endows you with increased Initiative.";
        private const string String14B1 = "You blink as you see a shadowy figure seemingly walking through a solid wall.";
        private const string String14FF = "The waters of Twilight Fountain heal your wounds.";
        private const string String1531 = "You hear the sound of looting somewhere nearby.";
        private const string String1561 = "A luminescent message magically appears on the door.";
        private const string String1596 = "'You have discovered the secret of the spirits and have received their blessing! Continue your search, champion. The graveyard offers passages to the clever.'";
        private const string String1635 = "'Ah, I see you haven't been blessed by the spirits yet!";
        private const string String166D = "Walk cautiously, my friend. The graveyard is as dangerous as it is rewarding. The benevolent spirits await thee!'";
        
        // === Functions ================================================
        private void FnTELOA_01(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x06, 0x01, 0x84, 0x03, isForwardMove);
            L001E: ShowMessage(player, String03FC); // To Carriage House
            L002B: return; // RETURN;
        }

        private void FnNOMAP_02(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
003F  0003 C4 5E 06  les bx, [bp+0x6]
0042  0006 26 FF 9F E8 00  call far word [es:bx+0xe8]
            L000B: return; // RETURN;
        }

        private void FnGATEMSG_03(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String040E); // Darkness envelops you as you enter the Graveyard. You can barely read the sign which says, 'NorthEast Gate.'
            L0010: return; // RETURN;
        }

        private void FnTELOB_04(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x07, 0x02, 0x4B, 0x00, isForwardMove);
            L001D: ShowMessage(player, String047B); // All that you can see on the door ahead is Sn k  P t.
            L002A: return; // RETURN;
        }

        private void FnXANITH_05(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x002C);
            L0010: ShowMessage(player, String04B0); // You meet Xanith the Cartographer, who is trying to map the cemetery.
            L001D: ShowMessage(player, String04F5); // 'Ah, more adventurers on the way to my shop! Have you mastered the dungeon thus far?
            L002A: ShowMessage(player, String054A); // I hope you've found the secret clues that equal the number of Snicker's brothers.
            L0037: ShowMessage(player, String059C); // If you have not, my assistants' payments will be of no value to you.'
            L0044: return; // RETURN;
        }

        private void FnSECA_06(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, 0x0D), 0x0006);
            L0012: if (JumpNotBelow) goto L006C;
            L0014: RefreshCompareFlags(HasUsedSpell(player, 0x17));
            L0022: if (JumpNotEqual) goto L006C;
            L0024: PushStack(player, 0x68);
            L0028: PushStack(player, ax);
00F6  0029 C4 5E 06  les bx, [bp+0x6]
00F9  002C 26 FF 5F 54  call far word [es:bx+0x54]
            L0030: cx = PopStack(player);
            L0031: cx = PopStack(player);
            L0032: RefreshCompareFlags(ax);
            L0034: if (JumpNotEqual) goto L006C;
            L0036: PushStack(player, 0x6E);
            L003A: PushStack(player, ax);
0108  003B C4 5E 06  les bx, [bp+0x6]
010B  003E 26 FF 5F 54  call far word [es:bx+0x54]
            L0042: cx = PopStack(player);
            L0043: cx = PopStack(player);
            L0044: RefreshCompareFlags(ax);
            L0046: if (JumpNotEqual) goto L006C;
            L0048: PushStack(player, 0x90);
            L004C: PushStack(player, ax);
011A  004D C4 5E 06  les bx, [bp+0x6]
011D  0050 26 FF 5F 54  call far word [es:bx+0x54]
            L0054: cx = PopStack(player);
            L0055: cx = PopStack(player);
            L0056: RefreshCompareFlags(ax);
            L0058: if (JumpNotEqual) goto L006C;
            L005A: PushStack(player, 0xA4);
            L005E: PushStack(player, ax);
012C  005F C4 5E 06  les bx, [bp+0x6]
012F  0062 26 FF 5F 54  call far word [es:bx+0x54]
            L0066: cx = PopStack(player);
            L0067: cx = PopStack(player);
            L0068: RefreshCompareFlags(ax);
            L006A: if (JumpEqual) goto L0093;
            L006C: ShowMessage(player, String05E2); // The tomb door opens.
0146  0079 FF 76 08  push word [bp+0x8]
0149  007C FF 76 06  push word [bp+0x6]
014C  007F 0E     push cs
014D  0080 E8 09 15  call 0x158c
            L0083: // NOP
            L0084: cx = PopStack(player);
            L0085: cx = PopStack(player);
0153  0086 FF 76 08  push word [bp+0x8]
0156  0089 FF 76 06  push word [bp+0x6]
0159  008C 0E     push cs
015A  008D E8 B7 14  call 0x1547
            L0090: // NOP
            L0091: goto L009E;
0160  0093 FF 76 08  push word [bp+0x8]
0163  0096 FF 76 06  push word [bp+0x6]
0166  0099 0E     push cs
0167  009A E8 CD 14  call 0x156a
            L009D: // NOP
            L009E: cx = PopStack(player);
            L009F: cx = PopStack(player);
            L00A0: return; // RETURN;
        }

        private void FnMSGA_07(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0172  0003 FF 76 08  push word [bp+0x8]
0175  0006 FF 76 06  push word [bp+0x6]
0178  0009 0E     push cs
0179  000A E8 C0 FE  call 0xfecd
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: ShowMessage(player, String05F7); // You see the NorthEast Gate to the East.
            L001C: return; // RETURN;
        }

        private void FnCLUEA_08(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x001E);
            L0010: ShowMessage(player, String061F); // A Gravedigger appears and wags a bony finger at you.
            L001D: ShowMessage(player, String0654); // 'All tombs do not contain treasure, you know. Some harbor grave rewards.'
            L002A: return; // RETURN;
        }

        private void FnGOODIEA_09(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String069E); // Disturbed graveyard spirits attack you.
            L0010: ax = HasItem(player, 0x69);
            L001E: if (JumpEqual) goto L0032;
01D9  0020 B8 DC 05  mov ax, 0x5dc
            L0023: PushStack(player, ax);
            L0024: PushStack(player, 0x00);
            L0027: PushStack(player, ax);
            L0028: PushStack(player, ax);
            L0029: PushStack(player, 0x9C);
01E6  002D B8 B6 00  mov ax, 0xb6
            L0030: goto L0045;
01EB  0032 B8 B8 0B  mov ax, 0xbb8
            L0035: PushStack(player, ax);
            L0036: PushStack(player, 0x00);
            L0039: PushStack(player, ax);
            L003A: PushStack(player, 0xB6);
            L003E: PushStack(player, 0xCC);
            L0042: PushStack(player, 0x69);
01FF  0046 C4 5E 06  les bx, [bp+0x6]
0202  0049 26 FF 9F D8 00  call far word [es:bx+0xd8]
0207  004E 83 C4 0C  add sp, 0xc
            L0051: Compare(PartyCount(player), 0x0001);
            L005C: if (JumpNotEqual) goto L0079;
            L005E: AddEncounter(player, 0x01, 0x03);
            L0070: PushStack(player, 0x22);
022D  0074 B8 05 00  mov ax, 0x5
            L0077: goto L00F0;
            L0079: Compare(PartyCount(player), 0x0002);
            L0084: if (JumpNotEqual) goto L00B3;
            L0086: AddEncounter(player, 0x01, 0x19);
            L0098: AddEncounter(player, 0x02, 0x1B);
            L00AA: PushStack(player, 0x1B);
0267  00AE B8 03 00  mov ax, 0x3
            L00B1: goto L00F0;
            L00B3: AddEncounter(player, 0x01, 0x1C);
            L00C5: AddEncounter(player, 0x02, 0x0B);
            L00D7: AddEncounter(player, 0x03, 0x1B);
            L00E9: AddEncounter(player, 0x04, 0x08);
            L00FB: return; // RETURN;
        }

        private void FnFTNA_0A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
02B9  0003 FF 76 08  push word [bp+0x8]
02BC  0006 FF 76 06  push word [bp+0x6]
02BF  0009 0E     push cs
02C0  000A E8 79 FD  call 0xfd86
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: ShowPortrait(player, 0x0042);
            L001C: HealPlayer(player, GetMaxHits(player));
            L002D: AddMana(player, 0x2710);
            L003A: ShowMessage(player, String06C6); // Angel Fountain replenishes your Health and Mana.
            L0047: return; // RETURN;
        }

        private void FnTELEA_0B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0302  0003 FF 76 08  push word [bp+0x8]
0305  0006 FF 76 06  push word [bp+0x6]
0308  0009 0E     push cs
0309  000A E8 30 FD  call 0xfd3d
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: TeleportParty(player, 0x05, 0x03, 0x1C, 0x03, isForwardMove);
            L002A: ShowMessage(player, String06F7); // The shadows of death that clutch at you evaporate as you are spirited to safety.
            L0037: return; // RETURN;
        }

        private void FnSECB_0C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, 0x0D), 0x0006);
            L0012: if (JumpNotBelow) goto L006C;
            L0014: RefreshCompareFlags(HasUsedSpell(player, 0x17));
            L0022: if (JumpNotEqual) goto L006C;
            L0024: PushStack(player, 0x68);
            L0028: PushStack(player, ax);
0361  0029 C4 5E 06  les bx, [bp+0x6]
0364  002C 26 FF 5F 54  call far word [es:bx+0x54]
            L0030: cx = PopStack(player);
            L0031: cx = PopStack(player);
            L0032: RefreshCompareFlags(ax);
            L0034: if (JumpNotEqual) goto L006C;
            L0036: PushStack(player, 0x6E);
            L003A: PushStack(player, ax);
0373  003B C4 5E 06  les bx, [bp+0x6]
0376  003E 26 FF 5F 54  call far word [es:bx+0x54]
            L0042: cx = PopStack(player);
            L0043: cx = PopStack(player);
            L0044: RefreshCompareFlags(ax);
            L0046: if (JumpNotEqual) goto L006C;
            L0048: PushStack(player, 0x90);
            L004C: PushStack(player, ax);
0385  004D C4 5E 06  les bx, [bp+0x6]
0388  0050 26 FF 5F 54  call far word [es:bx+0x54]
            L0054: cx = PopStack(player);
            L0055: cx = PopStack(player);
            L0056: RefreshCompareFlags(ax);
            L0058: if (JumpNotEqual) goto L006C;
            L005A: PushStack(player, 0xA4);
            L005E: PushStack(player, ax);
0397  005F C4 5E 06  les bx, [bp+0x6]
039A  0062 26 FF 5F 54  call far word [es:bx+0x54]
            L0066: cx = PopStack(player);
            L0067: cx = PopStack(player);
            L0068: RefreshCompareFlags(ax);
            L006A: if (JumpEqual) goto L0093;
            L006C: ShowMessage(player, String0748); // You discover a long forgotten door.
03B1  0079 FF 76 08  push word [bp+0x8]
03B4  007C FF 76 06  push word [bp+0x6]
03B7  007F 0E     push cs
03B8  0080 E8 9E 12  call 0x1321
            L0083: // NOP
            L0084: cx = PopStack(player);
            L0085: cx = PopStack(player);
03BE  0086 FF 76 08  push word [bp+0x8]
03C1  0089 FF 76 06  push word [bp+0x6]
03C4  008C 0E     push cs
03C5  008D E8 4C 12  call 0x12dc
            L0090: // NOP
            L0091: goto L009E;
03CB  0093 FF 76 08  push word [bp+0x8]
03CE  0096 FF 76 06  push word [bp+0x6]
03D1  0099 0E     push cs
03D2  009A E8 62 12  call 0x12ff
            L009D: // NOP
            L009E: cx = PopStack(player);
            L009F: cx = PopStack(player);
            L00A0: return; // RETURN;
        }

        private void FnGOODIEB_0D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String076C); // You disturb the souls of the entombed.
            L0010: ax = HasItem(player, 0x30);
            L001E: if (JumpNotEqual) goto L0030;
            L0020: ax = HasItem(player, 0x8F);
            L002E: if (JumpEqual) goto L0042;
040A  0030 B8 E8 03  mov ax, 0x3e8
            L0033: PushStack(player, ax);
            L0034: PushStack(player, 0x00);
            L0037: PushStack(player, ax);
            L0038: PushStack(player, ax);
            L0039: PushStack(player, 0x50);
0417  003D B8 8B 00  mov ax, 0x8b
            L0040: goto L0055;
041C  0042 B8 B8 0B  mov ax, 0xbb8
            L0045: PushStack(player, ax);
            L0046: PushStack(player, 0x00);
            L0049: PushStack(player, ax);
            L004A: PushStack(player, 0xA7);
            L004E: PushStack(player, 0x30);
            L0052: PushStack(player, 0x8F);
0430  0056 C4 5E 06  les bx, [bp+0x6]
0433  0059 26 FF 9F D8 00  call far word [es:bx+0xd8]
0438  005E 83 C4 0C  add sp, 0xc
            L0061: Compare(PartyCount(player), 0x0001);
            L006C: if (JumpNotEqual) goto L008A;
            L006E: AddEncounter(player, 0x01, 0x06);
            L0080: PushStack(player, 0x22);
045E  0084 B8 02 00  mov ax, 0x2
            L0087: goto L0113;
            L008A: Compare(PartyCount(player), 0x0002);
            L0095: if (JumpNotEqual) goto L00C4;
            L0097: AddEncounter(player, 0x01, 0x02);
            L00A9: AddEncounter(player, 0x02, 0x05);
            L00BB: PushStack(player, 0x1C);
0499  00BF B8 03 00  mov ax, 0x3
            L00C2: goto L0113;
            L00C4: AddEncounter(player, 0x01, 0x02);
            L00D6: AddEncounter(player, 0x02, 0x03);
            L00E8: AddEncounter(player, 0x03, 0x19);
            L00FA: AddEncounter(player, 0x05, 0x1A);
            L010C: AddEncounter(player, 0x06, 0x1C);
            L011E: return; // RETURN;
        }

        private void FnHEALDOWN_0E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
04FD  0003 FF 76 08  push word [bp+0x8]
0500  0006 FF 76 06  push word [bp+0x6]
0503  0009 0E     push cs
0504  000A E8 35 FB  call 0xfb42
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: PushStack(player, 0x01);
            L0013: PushStack(player, 0x00);
0510  0016 C4 5E 06  les bx, [bp+0x6]
0513  0019 26 FF 5F 04  call far word [es:bx+0x4]
            L001D: cx = PopStack(player);
            L001E: cx = PopStack(player);
            L001F: RefreshCompareFlags(ax);
            L0021: if (JumpNotEqual) goto L0058;
            L0023: ax = GetCurrentHits(player);
            L002A: bx = 0x0004;
            L002D: dx = ax % bx; ax = ax / bx;
            L0030: DamagePlayer(player, ax);
            L003A: ShowMessage(player, String0793); // A clumsy fall into an open grave injures you.
            L0047: PushStack(player, 0x01);
            L004B: PushStack(player, ax);
            L004C: PushStack(player, 0x00);
0549  004F C4 5E 06  les bx, [bp+0x6]
054C  0052 26 FF 1F  call far word [es:bx]
054F  0055 83 C4 06  add sp, 0x6
            L0058: return; // RETURN;
        }

        private void FnBONES_0F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0557  0003 FF 76 08  push word [bp+0x8]
055A  0006 FF 76 06  push word [bp+0x6]
055D  0009 0E     push cs
055E  000A E8 DB FA  call 0xfae8
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: ShowMessage(player, String07C1); // Scattered bones are all that's left of looted tombs.
            L001C: return; // RETURN;
        }

        private void FnILL_10(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0575  0003 FF 76 08  push word [bp+0x8]
0578  0006 FF 76 06  push word [bp+0x6]
057B  0009 0E     push cs
057C  000A E8 95 10  call 0x10a2
            L000D: // NOP
            L000E: cx = PopStack(player);
            L000F: cx = PopStack(player);
            L0010: return; // RETURN;
        }

        private void FnLOCKP_11(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0xC0);
            L0007: PushStack(player, ax);
058C  0008 C4 5E 06  les bx, [bp+0x6]
058F  000B 26 FF 5F 54  call far word [es:bx+0x54]
            L000F: cx = PopStack(player);
            L0010: cx = PopStack(player);
            L0011: RefreshCompareFlags(ax);
            L0013: if (JumpNotEqual) goto L0038;
            L0015: PushStack(player, 0x6F);
            L0019: PushStack(player, ax);
059E  001A C4 5E 06  les bx, [bp+0x6]
05A1  001D 26 FF 5F 54  call far word [es:bx+0x54]
            L0021: cx = PopStack(player);
            L0022: cx = PopStack(player);
            L0023: RefreshCompareFlags(ax);
            L0025: if (JumpNotEqual) goto L0038;
            L0027: Compare(HasUsedSkill(player, 0x0E), 0x000B);
            L0036: if (JumpBelow) goto L0061;
            L0038: ShowMessage(player, String07F6); // You have successfully unlocked the tomb door.
05C9  0045 FF 76 08  push word [bp+0x8]
05CC  0048 FF 76 06  push word [bp+0x6]
05CF  004B 0E     push cs
05D0  004C E8 86 10  call 0x10d5
            L004F: // NOP
            L0050: cx = PopStack(player);
            L0051: cx = PopStack(player);
05D6  0052 FF 76 08  push word [bp+0x8]
05D9  0055 FF 76 06  push word [bp+0x6]
05DC  0058 0E     push cs
05DD  0059 E8 34 10  call 0x1090
            L005C: // NOP
            L005D: cx = PopStack(player);
            L005E: cx = PopStack(player);
            L005F: goto L0088;
05E5  0061 FF 76 08  push word [bp+0x8]
05E8  0064 FF 76 06  push word [bp+0x6]
05EB  0067 0E     push cs
05EC  0068 E8 48 10  call 0x10b3
            L006B: // NOP
            L006C: cx = PopStack(player);
            L006D: cx = PopStack(player);
05F2  006E FF 76 08  push word [bp+0x8]
05F5  0071 FF 76 06  push word [bp+0x6]
05F8  0074 0E     push cs
05F9  0075 E8 5D 10  call 0x10d5
            L0078: // NOP
            L0079: cx = PopStack(player);
            L007A: cx = PopStack(player);
            L007B: ShowMessage(player, String0824); // The door to the old tomb is locked.
            L0088: return; // RETURN;
        }

        private void FnFTNB_12(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0611  0003 FF 76 08  push word [bp+0x8]
0614  0006 FF 76 06  push word [bp+0x6]
0617  0009 0E     push cs
0618  000A E8 21 FA  call 0xfa2e
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: ShowPortrait(player, 0x0042);
            L001C: RefreshCompareFlags(GetGuild(player));
            L0025: if (JumpEqual) goto L003F;
            L0027: Compare(GetGuild(player), 0x0001);
            L0031: if (JumpEqual) goto L003F;
            L0033: Compare(GetGuild(player), 0x0003);
            L003D: if (JumpNotEqual) goto L0069;
            L003F: RefreshCompareFlags(GetSkillLevel(player, 0x0A));
            L004D: if (JumpNotEqual) goto L0066;
            L004F: SetSkillLevel(player, 0x0A, 0x01);
066E  0060 B8 48 08  mov ax, 0x848
            L0063: goto L00F8;
            L0066: goto L00F5;
            L0069: Compare(GetGuild(player), 0x0002);
            L0073: if (JumpEqual) goto L0081;
            L0075: Compare(GetGuild(player), 0x0005);
            L007F: if (JumpNotEqual) goto L00A9;
            L0081: RefreshCompareFlags(GetSkillLevel(player, 0x0F));
            L008F: if (JumpNotEqual) goto L00A7;
            L0091: SetSkillLevel(player, 0x0F, 0x01);
06B0  00A2 B8 AF 08  mov ax, 0x8af
            L00A5: goto L00F8;
            L00A7: goto L00F5;
            L00A9: Compare(GetGuild(player), 0x0004);
            L00B3: if (JumpNotEqual) goto L0102;
            L00B5: RefreshCompareFlags(GetFlag(player, 0x02, 0xD7));
            L00C8: if (JumpNotEqual) goto L00F5;
            L00CA: SetSpellLevel(player, 0x10, 0x01);
            L00DB: SetFlag(player, 0x02, 0xD7, 0x01);
06FE  00F0 B8 E1 08  mov ax, 0x8e1
            L00F3: goto L00F8;
            L00F5: ShowMessage(player, String087B); // The waters of Skeletal Fountain quench your thirst.
            L0102: return; // RETURN;
        }

        private void FnTELEB_13(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0715  0003 FF 76 08  push word [bp+0x8]
0718  0006 FF 76 06  push word [bp+0x6]
071B  0009 0E     push cs
071C  000A E8 1D F9  call 0xf92a
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: ShowMessage(player, String091E); // The howling wind uproots you and carries you off.
            L001C: TeleportParty(player, 0x05, 0x03, 0xCA, 0x03, isForwardMove);
            L0037: return; // RETURN;
        }

        private void FnDEATH_14(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
074F  0004 FF 76 08  push word [bp+0x8]
0752  0007 FF 76 06  push word [bp+0x6]
0755  000A 0E     push cs
0756  000B E8 E3 F8  call 0xf8f1
            L000E: cx = PopStack(player);
            L000F: cx = PopStack(player);
            L0010: PushStack(player, 0x01);
            L0014: PushStack(player, 0x00);
0762  0017 C4 5E 06  les bx, [bp+0x6]
0765  001A 26 FF 5F 04  call far word [es:bx+0x4]
            L001E: cx = PopStack(player);
            L001F: cx = PopStack(player);
            L0020: RefreshCompareFlags(ax);
            L0022: if (JumpNotEqual) goto L0062;
            L0024: ShowMessage(player, String0950); // Graverobbers, hearing your approach, ambush you. Sharp steel slices across your torso!
            L0031: Compare(GetCurrentHits(player), 0x03E8);
            L003B: if (JumpBelowOrEqual) goto L0062;
            L003D: DamagePlayer(player, GetCurrentHits(player) + 0xFE0C);
            L0051: PushStack(player, 0x01);
            L0055: PushStack(player, ax);
            L0056: PushStack(player, 0x00);
07A4  0059 C4 5E 06  les bx, [bp+0x6]
07A7  005C 26 FF 1F  call far word [es:bx]
07AA  005F 83 C4 06  add sp, 0x6
            L0062: Compare(PartyCount(player), 0x0001);
            L006D: if (JumpEqual) goto L0071;
            L006F: goto L008D;
            L0071: si = 0x0001;
            L0074: goto L0086;
            L0076: AddEncounter(player, si, 0x17);
            L0085: si = si + 1;
            L0086: Compare(si, 0x03);
            L0089: if (JumpLessOrEqual) goto L0076;
            L008B: goto L00A7;
            L008D: si = 0x0001;
            L0090: goto L00A2;
            L0092: AddEncounter(player, si, 0x18);
            L00A1: si = si + 1;
            L00A2: Compare(si, 0x06);
            L00A5: if (JumpLessOrEqual) goto L0092;
            L00A7: return; // RETURN (restoring si);
        }

        private void FnTOMB_15(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
07F8  0003 C4 5E 06  les bx, [bp+0x6]
07FB  0006 26 FF 9F E8 00  call far word [es:bx+0xe8]
            L000B: Compare(GetFlag(player, 0x02, 0x50), 0x0001);
            L001F: if (JumpEqual) goto L0024;
            L0021: goto L012F;
            L0024: ShowMessage(player, String09A7); // Searching the musty tomb unearths a few items concealed behind some rubble.
            L0031: ShowMessage(player, String09F3); // You are rewarded for your insight.
            L003E: Compare(GetGuild(player), 0x0005);
            L0048: if (JumpEqual) goto L0056;
            L004A: Compare(GetGuild(player), 0x0004);
            L0054: if (JumpNotEqual) goto L00A3;
            L0056: AddExperience(player, 0x00003A98);
            L0067: GiveItem(player, 0x37);
            L0073: GiveItem(player, 0xBC);
            L007F: GiveItem(player, 0xB7);
            L008B: SetFlag(player, 0x02, 0x50, 0x02);
            L00A0: goto L013C;
            L00A3: Compare(GetGuild(player), 0x0003);
            L00AD: if (JumpEqual) goto L00BB;
            L00AF: Compare(GetGuild(player), 0x0002);
            L00B9: if (JumpNotEqual) goto L00E9;
            L00BB: AddExperience(player, 0x00003A98);
            L00CC: GiveItem(player, 0x33);
            L00D8: GiveItem(player, 0xBC);
08D9  00E4 B8 AD 00  mov ax, 0xad
            L00E7: goto L0082;
            L00E9: RefreshCompareFlags(GetGuild(player));
            L00F2: if (JumpEqual) goto L0100;
            L00F4: Compare(GetGuild(player), 0x0001);
            L00FE: if (JumpNotEqual) goto L013C;
            L0100: AddExperience(player, 0x00003A98);
            L0111: GiveItem(player, 0x16);
            L011D: GiveItem(player, 0xBC);
091E  0129 B8 AC 00  mov ax, 0xac
            L012C: goto L0082;
            L012F: ShowMessage(player, String0A16); // The tomb appears to be a good hiding place, but your search this time is futile.
            L013C: return; // RETURN;
        }

        private void FnLIGHT_16(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0xD1);
            L0011: if (JumpEqual) goto L0018;
0946  0013 B8 67 0A  mov ax, 0xa67
            L0016: goto L0034;
094B  0018 FF 76 08  push word [bp+0x8]
094E  001B FF 76 06  push word [bp+0x6]
0951  001E 0E     push cs
0952  001F E8 E7 F6  call 0xf709
            L0022: cx = PopStack(player);
            L0023: cx = PopStack(player);
            L0024: ShowMessage(player, String0ADE); // The torch does not cast enough illumination to light your path, nor can it be removed.
            L0031: ShowMessage(player, String0B35); // A portable source of light would be particularly useful in the Graveyard.
            L003E: return; // RETURN;
        }

        private void FnTELEC_17(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0976  0003 FF 76 08  push word [bp+0x8]
0979  0006 FF 76 06  push word [bp+0x6]
097C  0009 0E     push cs
097D  000A E8 BC F6  call 0xf6c9
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: ShowMessage(player, String0B7F); // You become dizzy and sense that you are no longer inside the tomb.
            L001C: TeleportParty(player, 0x05, 0x03, 0x45, 0x02, isForwardMove);
            L0037: return; // RETURN;
        }

        private void FnGOODIEC_18(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0BC2); // You stumble upon grave robbers ransacking a tomb.
            L0010: ax = HasItem(player, 0x47);
            L001E: if (JumpEqual) goto L002E;
09CC  0020 B8 DC 05  mov ax, 0x5dc
            L0023: PushStack(player, ax);
            L0024: PushStack(player, 0x00);
            L0027: PushStack(player, ax);
            L0028: PushStack(player, ax);
09D5  0029 B8 8C 00  mov ax, 0x8c
            L002C: goto L003D;
09DA  002E B8 C4 09  mov ax, 0x9c4
            L0031: PushStack(player, ax);
            L0032: PushStack(player, 0x00);
            L0035: PushStack(player, ax);
            L0036: PushStack(player, 0x4F);
            L003A: PushStack(player, 0x47);
            L003E: PushStack(player, 0xBA);
09EE  0042 C4 5E 06  les bx, [bp+0x6]
09F1  0045 26 FF 9F D8 00  call far word [es:bx+0xd8]
09F6  004A 83 C4 0C  add sp, 0xc
            L004D: Compare(PartyCount(player), 0x0001);
            L0058: if (JumpNotEqual) goto L0076;
            L005A: AddEncounter(player, 0x01, 0x18);
            L006C: PushStack(player, 0x27);
0A1C  0070 B8 02 00  mov ax, 0x2
            L0073: goto L00FF;
            L0076: Compare(PartyCount(player), 0x0002);
            L0081: if (JumpNotEqual) goto L00B0;
            L0083: AddEncounter(player, 0x01, 0x17);
            L0095: AddEncounter(player, 0x02, 0x18);
            L00A7: PushStack(player, 0x27);
0A57  00AB B8 03 00  mov ax, 0x3
            L00AE: goto L00FF;
            L00B0: AddEncounter(player, 0x01, 0x1F);
            L00C2: AddEncounter(player, 0x02, 0x23);
            L00D4: AddEncounter(player, 0x03, 0x17);
            L00E6: AddEncounter(player, 0x05, 0x18);
            L00F8: AddEncounter(player, 0x06, 0x1B);
            L010A: return; // RETURN;
        }

        private void FnGOODIED_19(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0BF4); // You encounter scavengers.
            L0010: ax = HasItem(player, 0xA6);
            L001E: if (JumpEqual) goto L002E;
0AD8  0020 B8 E8 03  mov ax, 0x3e8
            L0023: PushStack(player, ax);
            L0024: PushStack(player, 0x00);
            L0027: PushStack(player, ax);
            L0028: PushStack(player, ax);
0AE1  0029 B8 A5 00  mov ax, 0xa5
            L002C: goto L003D;
0AE6  002E B8 D0 07  mov ax, 0x7d0
            L0031: PushStack(player, ax);
            L0032: PushStack(player, 0x00);
            L0035: PushStack(player, ax);
            L0036: PushStack(player, 0xAE);
            L003A: PushStack(player, 0xA6);
            L003E: PushStack(player, 0xBA);
0AFA  0042 C4 5E 06  les bx, [bp+0x6]
0AFD  0045 26 FF 9F D8 00  call far word [es:bx+0xd8]
0B02  004A 83 C4 0C  add sp, 0xc
            L004D: Compare(PartyCount(player), 0x0001);
            L0058: if (JumpNotEqual) goto L0076;
            L005A: AddEncounter(player, 0x01, 0x10);
            L006C: PushStack(player, 0x1D);
0B28  0070 B8 02 00  mov ax, 0x2
            L0073: goto L00FF;
            L0076: Compare(PartyCount(player), 0x0002);
            L0081: if (JumpNotEqual) goto L00B0;
            L0083: AddEncounter(player, 0x01, 0x0F);
            L0095: AddEncounter(player, 0x02, 0x12);
            L00A7: PushStack(player, 0x13);
0B63  00AB B8 05 00  mov ax, 0x5
            L00AE: goto L00FF;
            L00B0: AddEncounter(player, 0x01, 0x0F);
            L00C2: AddEncounter(player, 0x02, 0x12);
            L00D4: AddEncounter(player, 0x03, 0x1E);
            L00E6: AddEncounter(player, 0x04, 0x1E);
            L00F8: AddEncounter(player, 0x06, 0x21);
            L010A: return; // RETURN;
        }

        private void FnTOMBONE_1A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0BC7  0003 FF 76 08  push word [bp+0x8]
0BCA  0006 FF 76 06  push word [bp+0x6]
0BCD  0009 0E     push cs
0BCE  000A E8 6B F4  call 0xf478
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: ShowMessage(player, String0C0E); // The worn tombstone bears the inscription, 'Wilthorg Zerium.'
            L001C: return; // RETURN;
        }

        private void FnBONESTWO_1B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0BE5  0003 FF 76 08  push word [bp+0x8]
0BE8  0006 FF 76 06  push word [bp+0x6]
0BEB  0009 0E     push cs
0BEC  000A E8 4D F4  call 0xf45a
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: ShowMessage(player, String0C4B); // You stumble upon the remains of Yartor Megilthorn.
            L001C: return; // RETURN;
        }

        private void FnTOMBTHRE_1C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0C03  0003 FF 76 08  push word [bp+0x8]
0C06  0006 FF 76 06  push word [bp+0x6]
0C09  0009 0E     push cs
0C0A  000A E8 2F F4  call 0xf43c
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: ShowMessage(player, String0C7E); // The inscription on the tombstone has been eroded beyond recognition by the elements.
            L001C: return; // RETURN;
        }

        private void FnPCBAT_1D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0C21  0003 83 EC 04  sub sp, 0x4
0C24  0006 56     push si
0C25  0007 57     push di
            L0008: di = 0;
0C28  000A C7 46 FE 00 00  mov word [bp-0x2], 0x0
            L000F: si = 0;
            L0011: ax = GetFlag(player, 0x03, 0x01);
0C40  0022 89 46 FC  mov [bp-0x4], ax
            L0025: Compare(ax, 0x0001);
            L0028: if (JumpEqual) goto L0036;
            L002A: Compare(ax, 0x0002);
            L002D: if (JumpEqual) goto L0040;
            L002F: Compare(ax, 0x0003);
            L0032: if (JumpEqual) goto L004A;
            L0034: goto L0054;
            L0036: di = 0x0001;
0C57  0039 C7 46 FE 05 00  mov word [bp-0x2], 0x5
            L003E: goto L005C;
            L0040: di = 0x000F;
0C61  0043 C7 46 FE 12 00  mov word [bp-0x2], 0x12
            L0048: goto L005C;
            L004A: di = 0x0007;
0C6B  004D C7 46 FE 08 00  mov word [bp-0x2], 0x8
            L0052: goto L005C;
            L0054: di = 0x0015;
0C75  0057 C7 46 FE 18 00  mov word [bp-0x2], 0x18
            L005C: Compare(PartyCount(player), 0x0001);
            L0067: if (JumpEqual) goto L0070;
            L0069: Compare(ax, 0x0002);
            L006C: if (JumpEqual) goto L0081;
            L006E: goto L0098;
0C8E  0070 57     push di
            L0071: PushStack(player, 0x01);
0C93  0075 C4 5E 06  les bx, [bp+0x6]
0C96  0078 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L007D: cx = PopStack(player);
            L007E: cx = PopStack(player);
            L007F: goto L00C8;
0C9F  0081 57     push di
            L0082: PushStack(player, 0x01);
0CA4  0086 C4 5E 06  les bx, [bp+0x6]
0CA7  0089 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L008E: cx = PopStack(player);
            L008F: cx = PopStack(player);
0CAE  0090 FF 76 FE  push word [bp-0x2]
0CB1  0093 B8 02 00  mov ax, 0x2
            L0096: goto L0074;
            L0098: si = 0x0001;
            L009B: goto L00AA;
0CBB  009D 57     push di
0CBC  009E 56     push si
0CBD  009F C4 5E 06  les bx, [bp+0x6]
0CC0  00A2 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L00A7: cx = PopStack(player);
            L00A8: cx = PopStack(player);
            L00A9: si = si + 1;
            L00AA: Compare(si, 0x02);
            L00AD: if (JumpLessOrEqual) goto L009D;
            L00AF: si = 0x0005;
            L00B2: goto L00C3;
0CD2  00B4 FF 76 FE  push word [bp-0x2]
0CD5  00B7 56     push si
0CD6  00B8 C4 5E 06  les bx, [bp+0x6]
0CD9  00BB 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L00C0: cx = PopStack(player);
            L00C1: cx = PopStack(player);
            L00C2: si = si + 1;
            L00C3: Compare(si, 0x06);
            L00C6: if (JumpLessOrEqual) goto L00B4;
0CE6  00C8 5F     pop di
0CE7  00C9 5E     pop si
            L00CA: // restore stack ptr: sp = bp;
            L00CC: return; // RETURN;
        }

        private void FnTOMLTE_1E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0xD1);
            L0011: if (JumpEqual) goto L0018;
0CFF  0013 B8 D3 0C  mov ax, 0xcd3
            L0016: goto L0027;
0D04  0018 FF 76 08  push word [bp+0x8]
0D07  001B FF 76 06  push word [bp+0x6]
0D0A  001E 0E     push cs
0D0B  001F E8 2E F3  call 0xf350
            L0022: cx = PopStack(player);
            L0023: cx = PopStack(player);
            L0024: ShowMessage(player, String0D24); // You overhear a group of adventurers discussing the strange flickering of their lantern in the tomb.
            L0031: return; // RETURN;
        }

        private void FnHANDHLDR_1F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0D88); // The volcanic activity has weakened some of the walls and tomb doors in this area.
0D2F  0010 FF 76 08  push word [bp+0x8]
0D32  0013 FF 76 06  push word [bp+0x6]
0D35  0016 0E     push cs
0D36  0017 E8 03 F3  call 0xf31d
            L001A: cx = PopStack(player);
            L001B: cx = PopStack(player);
            L001C: return; // RETURN;
        }

        private void FnTEXTA_20(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0D40  0003 FF 76 08  push word [bp+0x8]
0D43  0006 FF 76 06  push word [bp+0x6]
0D46  0009 0E     push cs
0D47  000A E8 F2 F2  call 0xf2ff
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: ShowMessage(player, String0DDA); // A ghostly voice whispers, 'To the South you will meet four Spirits. Each will offer you a gift.
            L001C: ShowMessage(player, String0E3A); // Choose wisely for you will be able to accept only one gift. Once your decision is made, enter the door of your choice.'
            L0029: return; // RETURN;
        }

        private void FnTEXTB_21(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0D6B  0003 FF 76 08  push word [bp+0x8]
0D6E  0006 FF 76 06  push word [bp+0x6]
0D71  0009 0E     push cs
0D72  000A E8 C7 F2  call 0xf2d4
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: ShowMessage(player, String0EB2); // The sorrowful wind whispers -
            L001C: ShowMessage(player, String0ED0); // 'The Spirit to the East offers the gift of increased Strength.'
            L0029: return; // RETURN;
        }

        private void FnTEXTC_22(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0D96  0003 FF 76 08  push word [bp+0x8]
0D99  0006 FF 76 06  push word [bp+0x6]
0D9C  0009 0E     push cs
0D9D  000A E8 9C F2  call 0xf2a9
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: ShowPortrait(player, 0x000B);
            L001C: Compare(GetFlag(player, 0x02, 0x50), 0x0001);
            L0030: if (JumpEqual) goto L0048;
            L0032: Compare(GetFlag(player, 0x02, 0x50), 0x0002);
            L0046: if (JumpNotEqual) goto L0057;
            L0048: ShowMessage(player, String0F10); // You've already chosen your gift.
            L0055: goto L008A;
            L0057: SetFlag(player, 0x02, 0x50, 0x01);
            L006C: ShowMessage(player, String0F31); // The Spirit of a Warrior endows you with increased Strength.
            L0079: ModifyAttribute(player, 0x00, 0x0002);
            L008A: return; // RETURN;
        }

        private void FnPARTYCT_23(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0E22  0003 FF 76 08  push word [bp+0x8]
0E25  0006 FF 76 06  push word [bp+0x6]
0E28  0009 0E     push cs
0E29  000A E8 10 F2  call 0xf21d
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: Compare(PartyCount(player), 0x0001);
            L001A: if (JumpNotEqual) goto L002B;
            L001C: ShowMessage(player, String0F6D); // You may rejoin your party.
            L0029: goto L0046;
            L002B: TeleportParty(player, 0x05, 0x03, 0xC0, 0x03, isForwardMove);
            L0046: return; // RETURN;
        }

        private void FnITADOOR_24(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0xD1);
            L0007: PushStack(player, ax);
0E6F  0008 C4 5E 06  les bx, [bp+0x6]
0E72  000B 26 FF 5F 54  call far word [es:bx+0x54]
            L000F: cx = PopStack(player);
            L0010: cx = PopStack(player);
            L0011: RefreshCompareFlags(ax);
            L0013: if (JumpEqual) goto L004E;
0E7C  0015 FF 76 08  push word [bp+0x8]
0E7F  0018 FF 76 06  push word [bp+0x6]
0E82  001B 0E     push cs
0E83  001C E8 8E 07  call 0x7ad
            L001F: // NOP
            L0020: cx = PopStack(player);
            L0021: cx = PopStack(player);
0E89  0022 FF 76 08  push word [bp+0x8]
0E8C  0025 FF 76 06  push word [bp+0x6]
0E8F  0028 0E     push cs
0E90  0029 E8 C6 07  call 0x7f2
            L002C: // NOP
            L002D: cx = PopStack(player);
            L002E: cx = PopStack(player);
            L002F: ShowMessage(player, String0F88); // The Luminous Lantern glows feebly for a few moments.
            L003C: ShowMessage(player, String0FBD); // You barely detect a rusty bolt that locks the mildewed door.
0EB0  0049 B8 FA 0F  mov ax, 0xffa
            L004C: goto L005E;
0EB5  004E FF 76 08  push word [bp+0x8]
0EB8  0051 FF 76 06  push word [bp+0x6]
0EBB  0054 0E     push cs
0EBC  0055 E8 78 07  call 0x7d0
            L0058: // NOP
            L0059: cx = PopStack(player);
            L005A: cx = PopStack(player);
            L005B: ShowMessage(player, String1033); // A locked door bars your way. Perhaps if you had a bit of light you could determine the cause.
            L0068: return; // RETURN;
        }

        private void FnITBDOOR_25(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1091); // A large sign warns -
            L0010: ShowMessage(player, String10A6); // 'DO NOT ENTER unless you have all four map pieces or have completed the Queen's map quest. Proceed through this door alone and rejoin your party on the other side.'
            L001D: Compare(PartyCount(player), 0x0001);
            L0028: if (JumpNotEqual) goto L009C;
            L002A: ax = HasItem(player, 0xD4);
            L0038: if (JumpEqual) goto L006A;
            L003A: ax = HasItem(player, 0xD6);
            L0048: if (JumpEqual) goto L006A;
            L004A: ax = HasItem(player, 0xD5);
            L0058: if (JumpEqual) goto L006A;
            L005A: ax = HasItem(player, 0xD3);
            L0068: if (JumpNotEqual) goto L0080;
            L006A: Compare(GetFlag(player, 0x02, 0x3C), 0x0001);
            L007E: if (JumpNotEqual) goto L00B6;
0F51  0080 FF 76 08  push word [bp+0x8]
0F54  0083 FF 76 06  push word [bp+0x6]
0F57  0086 0E     push cs
0F58  0087 E8 B9 06  call 0x743
            L008A: // NOP
            L008B: cx = PopStack(player);
            L008C: cx = PopStack(player);
0F5E  008D FF 76 08  push word [bp+0x8]
0F61  0090 FF 76 06  push word [bp+0x6]
0F64  0093 0E     push cs
0F65  0094 E8 F1 06  call 0x788
            L0097: // NOP
            L0098: cx = PopStack(player);
            L0099: cx = PopStack(player);
            L009A: goto L00B6;
0F6D  009C FF 76 08  push word [bp+0x8]
0F70  009F FF 76 06  push word [bp+0x6]
0F73  00A2 0E     push cs
0F74  00A3 E8 C0 06  call 0x766
            L00A6: // NOP
            L00A7: cx = PopStack(player);
            L00A8: cx = PopStack(player);
            L00A9: ShowMessage(player, String114B); // Your entry is barred.
            L00B6: return; // RETURN;
        }

        private void FnCLUEB_26(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x002A);
            L0010: ShowMessage(player, String1161); // 'Word has it that pieces of the map are scattered throughout the levels of the dungeon.'
            L001D: return; // RETURN;
        }

        private void FnTEXTD_27(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0FAB  0003 FF 76 08  push word [bp+0x8]
0FAE  0006 FF 76 06  push word [bp+0x6]
0FB1  0009 0E     push cs
0FB2  000A E8 87 F0  call 0xf094
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: ShowMessage(player, String11BA); // A haunted voice quavers -
            L001C: ShowMessage(player, String11D4); // 'The Spirit to the East will offer the gift of increased Defense.'
            L0029: return; // RETURN;
        }

        private void FnTEXTE_28(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0FD6  0003 FF 76 08  push word [bp+0x8]
0FD9  0006 FF 76 06  push word [bp+0x6]
0FDC  0009 0E     push cs
0FDD  000A E8 5C F0  call 0xf069
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: ShowPortrait(player, 0x000B);
            L001C: Compare(GetFlag(player, 0x02, 0x50), 0x0001);
            L0030: if (JumpEqual) goto L0048;
            L0032: Compare(GetFlag(player, 0x02, 0x50), 0x0002);
            L0046: if (JumpNotEqual) goto L0057;
            L0048: ShowMessage(player, String0F10); // You've already chosen your gift.
            L0055: goto L008B;
            L0057: SetFlag(player, 0x02, 0x50, 0x01);
            L006C: ShowMessage(player, String1217); // The Spirit of a Guard endows you with increased Defense.
            L0079: ModifyAttribute(player, 0x01, 0x0002);
            L008B: return; // RETURN;
        }

        private void FnCLUEC_29(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x001C);
            L0010: ShowMessage(player, String1250); // 'Trust the wrong thief with your goods and you may end up here permanently.'
            L001D: return; // RETURN;
        }

        private void FnTEXTF_2A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
1082  0003 FF 76 08  push word [bp+0x8]
1085  0006 FF 76 06  push word [bp+0x6]
1088  0009 0E     push cs
1089  000A E8 B0 EF  call 0xefbd
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: ShowMessage(player, String129D); // A distant wraith wails -
            L001C: ShowMessage(player, String12B6); // 'The Spirit to the East blesses with the gift of increased Agility.'
            L0029: return; // RETURN;
        }

        private void FnTEXTG_2B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
10AD  0003 FF 76 08  push word [bp+0x8]
10B0  0006 FF 76 06  push word [bp+0x6]
10B3  0009 0E     push cs
10B4  000A E8 85 EF  call 0xef92
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: ShowPortrait(player, 0x000B);
            L001C: Compare(GetFlag(player, 0x02, 0x50), 0x0001);
            L0030: if (JumpEqual) goto L0048;
            L0032: Compare(GetFlag(player, 0x02, 0x50), 0x0002);
            L0046: if (JumpNotEqual) goto L0057;
            L0048: ShowMessage(player, String0F10); // You've already chosen your gift.
            L0055: goto L0088;
            L0057: SetFlag(player, 0x02, 0x50, 0x01);
            L006C: ShowMessage(player, String12FB); // The Spirit of an Athlete endows you with increased Agility.
            L0079: PushStack(player, 0x02);
            L007D: PushStack(player, ax);
1128  007E C4 5E 06  les bx, [bp+0x6]
112B  0081 26 FF 9F A8 00  call far word [es:bx+0xa8]
            L0086: cx = PopStack(player);
            L0087: cx = PopStack(player);
            L0088: return; // RETURN;
        }

        private void FnSLIP_2C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
1137  0003 FF 76 08  push word [bp+0x8]
113A  0006 FF 76 06  push word [bp+0x6]
113D  0009 0E     push cs
113E  000A E8 FB EE  call 0xef08
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: ShowMessage(player, String1337); // The ground gives way and you slide into The Crypt.
            L001C: TeleportParty(player, 0x06, 0x01, 0xDD, 0x01, isForwardMove);
            L0037: return; // RETURN;
        }

        private void FnTELOC_2D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0xD0);
            L0011: if (JumpEqual) goto L002D;
            L0013: ShowMessage(player, String136A); // As you approach the portal to the Cartography Shop, your Skeleton Key tumbles to the ground and is lost in the mud.
            L0020: PushStack(player, 0xD0);
1191  0024 C4 5E 06  les bx, [bp+0x6]
1194  0027 26 FF 5F 4C  call far word [es:bx+0x4c]
            L002B: goto L0039;
            L002D: ShowMessage(player, String13DE); // The portal marks the entrance to the Cartography Shop.
            L003A: TeleportParty(player, 0x05, 0x02, 0xF7, 0x03, isForwardMove);
            L0055: return; // RETURN;
        }

        private void FnTEXTH_2E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
11C7  0003 FF 76 08  push word [bp+0x8]
11CA  0006 FF 76 06  push word [bp+0x6]
11CD  0009 0E     push cs
11CE  000A E8 6B EE  call 0xee78
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: ShowMessage(player, String1415); // A nearby owl hoots -
            L001C: ShowMessage(player, String142A); // 'The Spirit to the East can give you a gift that increases Initiative.'
            L0029: return; // RETURN;
        }

        private void FnTEXTI_2F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
11F2  0003 FF 76 08  push word [bp+0x8]
11F5  0006 FF 76 06  push word [bp+0x6]
11F8  0009 0E     push cs
11F9  000A E8 40 EE  call 0xee4d
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: ShowPortrait(player, 0x000B);
            L001C: Compare(GetFlag(player, 0x02, 0x50), 0x0001);
            L0030: if (JumpEqual) goto L0048;
            L0032: Compare(GetFlag(player, 0x02, 0x50), 0x0002);
            L0046: if (JumpNotEqual) goto L0057;
            L0048: ShowMessage(player, String0F10); // You've already chosen your gift.
            L0055: goto L008B;
            L0057: SetFlag(player, 0x02, 0x50, 0x01);
            L006C: ShowMessage(player, String1472); // The Spirit of a Cavalier endows you with increased Initiative.
            L0079: ModifyAttribute(player, 0x03, 0x0002);
            L008B: return; // RETURN;
        }

        private void FnILLHOLDR_30(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String14B1); // You blink as you see a shadowy figure seemingly walking through a solid wall.
128C  0010 FF 76 08  push word [bp+0x8]
128F  0013 FF 76 06  push word [bp+0x6]
1292  0016 0E     push cs
1293  0017 E8 A6 ED  call 0xedc0
            L001A: cx = PopStack(player);
            L001B: cx = PopStack(player);
            L001C: return; // RETURN;
        }

        private void FnFTNC_31(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
129D  0003 FF 76 08  push word [bp+0x8]
12A0  0006 FF 76 06  push word [bp+0x6]
12A3  0009 0E     push cs
12A4  000A E8 95 ED  call 0xeda2
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: ShowPortrait(player, 0x0042);
            L001C: HealPlayer(player, GetMaxHits(player));
            L002D: ShowMessage(player, String14FF); // The waters of Twilight Fountain heal your wounds.
            L003A: return; // RETURN;
        }

        private void FnMDAMON_32(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L002B;
            L0010: AddEncounter(player, 0x01, 0x26);
            L0022: PushStack(player, 0x27);
12FC  0026 B8 05 00  mov ax, 0x5
            L0029: goto L009E;
            L002B: Compare(PartyCount(player), 0x0002);
            L0036: if (JumpNotEqual) goto L0061;
            L0038: AddEncounter(player, 0x01, 0x14);
            L004A: AddEncounter(player, 0x02, 0x15);
1332  005C B8 26 00  mov ax, 0x26
            L005F: goto L0025;
            L0061: AddEncounter(player, 0x01, 0x24);
            L0073: AddEncounter(player, 0x02, 0x28);
            L0085: AddEncounter(player, 0x03, 0x26);
            L0097: AddEncounter(player, 0x04, 0x26);
            L00A9: return; // RETURN;
        }

        private void FnMEDBMON_33(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L002B;
            L0010: AddEncounter(player, 0x01, 0x17);
            L0022: PushStack(player, 0x1D);
13A7  0026 B8 05 00  mov ax, 0x5
            L0029: goto L009E;
            L002B: Compare(PartyCount(player), 0x0002);
            L0036: if (JumpNotEqual) goto L0061;
            L0038: AddEncounter(player, 0x01, 0x18);
            L004A: AddEncounter(player, 0x02, 0x18);
13DD  005C B8 12 00  mov ax, 0x12
            L005F: goto L009A;
            L0061: AddEncounter(player, 0x01, 0x17);
            L0073: AddEncounter(player, 0x02, 0x28);
            L0085: AddEncounter(player, 0x03, 0x12);
            L0097: AddEncounter(player, 0x04, 0x10);
            L00A9: return; // RETURN;
        }

        private void FnMEDCMON_34(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L0028;
            L0010: PushStack(player, 0x01);
            L0014: PushStack(player, ax);
1441  0015 C4 5E 06  les bx, [bp+0x6]
1444  0018 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L001D: cx = PopStack(player);
            L001E: cx = PopStack(player);
            L001F: PushStack(player, 0x22);
144F  0023 B8 02 00  mov ax, 0x2
            L0026: goto L0089;
            L0028: Compare(PartyCount(player), 0x0002);
            L0033: if (JumpNotEqual) goto L004C;
            L0035: AddEncounter(player, 0x01, 0x03);
1473  0047 B8 05 00  mov ax, 0x5
            L004A: goto L0022;
            L004C: AddEncounter(player, 0x01, 0x03);
            L005E: AddEncounter(player, 0x02, 0x04);
            L0070: AddEncounter(player, 0x05, 0x1A);
            L0082: AddEncounter(player, 0x06, 0x1A);
            L0094: return; // RETURN;
        }

        private void FnEZAMON_35(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpEqual) goto L001D;
            L0010: Compare(PartyCount(player), 0x0002);
            L001B: if (JumpNotEqual) goto L0038;
            L001D: AddEncounter(player, 0x01, 0x06);
            L002F: PushStack(player, 0x0C);
14F5  0033 B8 02 00  mov ax, 0x2
            L0036: goto L0075;
            L0038: AddEncounter(player, 0x01, 0x07);
            L004A: AddEncounter(player, 0x02, 0x06);
            L005C: AddEncounter(player, 0x03, 0x0D);
            L006E: AddEncounter(player, 0x04, 0x0A);
            L0080: return; // RETURN;
        }

        private void FnHARDA_36(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L002C;
            L0010: AddEncounter(player, 0x01, 0x14);
            L0022: PushStack(player, 0x27);
156A  0026 B8 02 00  mov ax, 0x2
            L0029: goto L00B1;
            L002C: Compare(PartyCount(player), 0x0002);
            L0037: if (JumpNotEqual) goto L0062;
            L0039: AddEncounter(player, 0x01, 0x18);
            L004B: AddEncounter(player, 0x02, 0x17);
15A1  005D B8 27 00  mov ax, 0x27
            L0060: goto L00AD;
            L0062: AddEncounter(player, 0x01, 0x18);
            L0074: AddEncounter(player, 0x02, 0x17);
            L0086: AddEncounter(player, 0x03, 0x24);
            L0098: AddEncounter(player, 0x04, 0x14);
            L00AA: AddEncounter(player, 0x05, 0x20);
            L00BC: return; // RETURN;
        }

        private void FnWRNING_37(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1531); // You hear the sound of looting somewhere nearby.
            L0010: return; // RETURN;
            // Extra data: 55 8B EC B8 01 00 50 C4 5E 06 26 FF 5F 24 50 C4 5E 06 26 FF 5F 20 50 C4 5E 06 26 FF 5F 2C 83 C4 06 5D CB 55 8B EC 33 C0 50 C4 5E 06 26 FF 5F 24 50 C4 5E 06 26 FF 5F 20 50 C4 5E 06 26 FF 5F 2C 83 C4 06 5D CB 55 8B EC C4 5E 06 26 FF 5F 24 50 C4 5E 06 26 FF 5F 20 50 B8 01 00 50 C4 5E 06 26 FF 5F 30 83 C4 06 5D CB 
        }

        private void FnCGRT_38(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0x50), 0x0001);
            L0017: if (JumpNotEqual) goto L0033;
            L0019: ShowMessage(player, String1561); // A luminescent message magically appears on the door.
            L0026: ShowMessage(player, String1596); // 'You have discovered the secret of the spirits and have received their blessing! Continue your search, champion. The graveyard offers passages to the clever.'
            L0033: return; // RETURN;
        }

        private void FnSPCLU_39(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x02, 0x50));
            L0016: if (JumpNotEqual) goto L003F;
            L0018: ShowPortrait(player, 0x001B);
            L0025: ShowMessage(player, String1635); // 'Ah, I see you haven't been blessed by the spirits yet!
            L0032: ShowMessage(player, String166D); // Walk cautiously, my friend. The graveyard is as dangerous as it is rewarding. The benevolent spirits await thee!'
            L003F: return; // RETURN;
        }

    }
}
