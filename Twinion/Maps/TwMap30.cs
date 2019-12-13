#pragma warning disable
using System.Collections.Generic;
using XPT.WorldData;
using XPT.WorldData.Yserbius;

namespace XPT.Scripts.Twinion.Maps {
    class TwMap30 : AMapScripted {
        protected override int MapIndex => 30;
        protected override int RandomEncounterChance => 27;
        protected override int RandomEncounterExtraCount => 2;

        public TwMap30() {
            MapEvent01 = FnCOMONDOR_01;
            MapEvent02 = FnENTRANCE_02;
            MapEvent03 = FnDISPELL_03;
            MapEvent04 = FnDESCRIPA_04;
            MapEvent05 = FnSECRTDOR_05;
            MapEvent06 = FnHALLDESC_06;
            MapEvent07 = FnROOMTELE_07;
            MapEvent08 = FnTWINROOM_08;
            MapEvent09 = FnLRGROOM_09;
            MapEvent0A = FnITEMSBAT_0A;
            MapEvent0B = FnDISPSTAT_0B;
            MapEvent0C = FnSTATBATL_0C;
            MapEvent0D = FnNPCONE_0D;
            MapEvent0E = FnNPCTWO_0E;
            MapEvent0F = FnSMALBAT_0F;
            MapEvent10 = FnNPCBATTL_10;
            MapEvent11 = FnDRAGBATL_11;
            MapEvent12 = FnRAITHBAT_12;
            MapEvent13 = FnDRAGTWO_13;
            MapEvent14 = FnWAYOUT_14;
            MapEvent15 = FnSOUTHWST_15;
            MapEvent16 = FnHUGEBTLA_16;
            MapEvent17 = FnHUGBTLB_17;
            MapEvent18 = FnSTATBTLB_18;
            MapEvent19 = FnWISENPC_19;
            MapEvent1A = FnPETRIFY_1A;
            MapEvent1B = FnFIRBURST_1B;
            MapEvent1C = FnGUARDIAN_1C;
            MapEvent1D = FnTOEGRESS_1D;
            MapEvent1E = FnWAYOUTM_1E;
            MapEvent1F = FnPOISON_1F;
            MapEvent20 = FnMEDBATLA_20;
            MapEvent21 = FnMEDBATLB_21;
            MapEvent22 = FnHERMTNPC_22;
            MapEvent23 = FnTOCNTUP_23;
            MapEvent24 = FnDRAGBATA_24;
            MapEvent25 = FnBIGBATL_25;
            MapEvent26 = FnSWITCH_26;
            MapEvent27 = FnSOUTHEAS_27;
            MapEvent28 = FnNORTHEAS_28;
            MapEvent29 = FnMIDWEST_29;
            MapEvent2A = FnNPCBATLB_2A;
            MapEvent2B = FnDRAGDEN_2B;
            MapEvent2D = FnNOMAPS_2D;
            MapEvent2E = FnSETFLAG_2E;
        }
        
        // === Strings ================================================
        private const string String03FC = "This teleport will only take you to the main entrance.";
        private const string String0433 = "You dispel the wall!";
        private const string String0448 = "The item's powers have faded!";
        private const string String0466 = "Now, take this portal back to the rod's source; and try to find a pathway...again.";
        private const string String04B9 = "This wall seems to shimmer, yet it is solid.";
        private const string String04E6 = "The tedious journey to this place has made you tired.";
        private const string String051C = "Even so, some walls here seem to fade and shimmer as being pulled upon by unseen forces.";
        private const string String0575 = "Grinding sounds of stone echo through these odd shadowy halls. The scent of powerful magics fills your nostrils and fires your mind.";
        private const string String05FA = "The messages of the two old men prove to be the key to opening this secret wall!";
        private const string String064B = "Hmmm...seems like you're missing part of the ritual.  Another may know the second half; then you may find a way through here!";
        private const string String06C9 = "This enormous hallway seems to be devoid of any useful purpose. It's as though the walls here are only boundaries of internally hidden rooms.";
        private const string String0757 = "Magical energy radiates from all around you.";
        private const string String0784 = "These mystical teleports project dazzling colors of light that refract and reflect off of each other with blinding beauty.";
        private const string String07FF = "Three shafts of pure light pour down from above onto the Rod of Dissemination, restoring its magical properties.";
        private const string String0870 = "Two small dwellings stand opposite each other in this small room. Strange mumblings are coming from the southern one.";
        private const string String08E6 = "Northward, however, you can just make out low hissing sounds and snarls.";
        private const string String092F = "Deep sorrowful moans surround you in this dingy place.";
        private const string String0966 = "Odd shadows flicker and fold in on one another against the walls.  The shadows themselves seem alive.";
        private const string String09CC = "Stains of combat cover the floor, but there is nothing of interest here... except a few Erebus fiends!";
        private const string String0A33 = "A large Erebus Fiend orders his minions to attack you, as he waves a mystical staff about and sends magical flames at you from his fingertips!";
        private const string String0AC2 = "The statue seems to shimmer, yet it is apparently solid.";
        private const string String0AFB = "You dispel the statue!";
        private const string String0B12 = "The item's powers have faded and pull you back to their source.";
        private const string String0B52 = "By dispelling this statue you've released the imprisoned creature! It intends to reward you with death!";
        private const string String0BBA = "A sinewy beast stares angrily at you for your intrusion into his home.";
        private const string String0C01 = "'You have no business here. Leave before I become enraged and destroy you!'";
        private const string String0C4D = "'Ahh, you've met my twin, I see.";
        private const string String0C6E = "Say his chant in time with mine, and at the wall, the ingress shall be thine.'";
        private const string String0CBD = "Ieoa then turns away pleased with his 'creativity'%.";
        private const string String0CF2 = "Ieoa has left the dungeon.";
        private const string String0D0D = "'Away with you, go bother my brother to the west.'";
        private const string String0D40 = "'Did you enjoy your talk with Ieoa?";
        private const string String0D64 = "My verse shan't be before if you wish to find the door. Seek Ieoa, the twin; with his rhyme you begin.'";
        private const string String0DCC = "Aoei then turns away pleased with his 'creativity'%.";
        private const string String0E01 = "Aoei has left the dungeon.";
        private const string String0E1C = "You happen across some feuding Kaalroths that dismiss their argument for some tasty combat.";
        private const string String0E78 = "A warring party of Night Elf Pilgrims drags you into the fray.";
        private const string String0EB7 = "You suddenly feel out matched as a small nest of dragons charges at you!";
        private const string String0F00 = "Shimmering moans and shadowy figures surround you!";
        private const string String0F33 = "A huge Red Dragon sends a barrage of flames towards you!";
        private const string String0F6C = "This jeweled teleport will send you to the final confrontation. The Queen awaits.";
        private const string String0FBE = "Perhaps the way out is near!!!";
        private const string String0FDD = "An arsenal of creatures bars your way here.";
        private const string String1009 = "Servants of Dissemination attack!";
        private const string String102B = "The marble statue crumbles away, releasing an ominous beast of power.";
        private const string String1071 = "'I am frozen in time here! I tried to use the Portal without the proper knowledge!";
        private const string String10C4 = "Learn from me! Do not use the Portal below!'";
        private const string String10F1 = "You've sprung an ancient trap that seems not to have harmed you...much.";
        private const string String1139 = "A dragon's face is carved on the wall where the torch here hangs. As you walk by the wall it comes to life and spews waves of fire over you!";
        private const string String11C6 = "The carved dragon on the wall remains silent.";
        private const string String11F4 = "'You must defeat us to proceed! We are everlasting forces here!'";
        private const string String1235 = "This MUST lead out of this level.";
        private const string String1257 = "The end must be near; you can see huge forces of creatures moving about nearby.";
        private const string String12A7 = "Waste not your charges on futile walls!";
        private const string String12CF = "The Guardians here launch a spread of evil magic towards you. The mysterious vapors envelop your body as a ring of opaque fog.";
        private const string String134E = "Creatures surprise you!";
        private const string String1366 = "You surprise some beasts examining an interesting sword.";
        private const string String139F = "An old hermit squints at you, 'The Portal you seek cannot be entered yet.  Your task will end in futility!";
        private const string String140A = "You must gain in ways before you gain the wisdom.'";
        private const string String143D = "The rantings of a fool, eh?";
        private const string String1459 = "This portal, however, you can enter.";
        private const string String147E = "Some young dragons are scrounging for food, they notice you and attempt to make you their meal.";
        private const string String14DE = "You've happened upon some very unpleasant sorts!";
        private const string String150F = "A lever here is marked DO NOT TOUCH!";
        private const string String1534 = "Using your better judgement, you move the lever.";
        private const string String1565 = "You hear clicks and sliding noises of stone on stone echo through nearby corridors.";
        private const string String15B9 = "You decidedly move the switch again, thinking it best not to fiddle with things so well marked.";
        private const string String1619 = "A glowing teleport stands ready.";
        private const string String163A = "A war party of adventurers prepare an offensive.";
        private const string String166B = "It's unusually dim in this room.  It appears as though a violent battle has recently taken place;";
        private const string String16CD = "seeing that charred remains litter the floor and scorch marked stone decorates the walls!";
        private const string String1727 = "The Rod of Dissemination ignites with magical fury! Use it to blaze your own pathway through these magical walls.";
        
        // === Functions ================================================
        private void FnCOMONDOR_01(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0021: return; // RETURN;
        }

        private void FnENTRANCE_02(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String03FC); // This teleport will only take you to the main entrance.
            L0010: PushStack(player, 0x01);
            L0014: PushStack(player, 0x13);
            L0018: PushStack(player, 0x01);
            L001C: PushStack(player, ax);
0049  001D C4 5E 06  les bx, [bp+0x6]
004C  0020 26 FF 9F BC 00  call far word [es:bx+0xbc]
0051  0025 83 C4 08  add sp, 0x8
            L0028: return; // RETURN;
        }

        private void FnDISPELL_03(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: si = GetFlag(player, 0x02, 0xC4);
            L0017: PushStack(player, 0x02);
            L001B: PushStack(player, 0x00);
0074  001E C4 5E 06  les bx, [bp+0x6]
0077  0021 26 FF 5F 04  call far word [es:bx+0x4]
            L0025: cx = PopStack(player);
            L0026: cx = PopStack(player);
            L0027: RefreshCompareFlags(ax);
            L0029: if (JumpEqual) goto L002E;
            L002B: goto L013C;
            L002E: ax = IsFlagOn(player, 0x02, 0xC4);
            L0041: if (JumpNotEqual) goto L0046;
            L0043: goto L018A;
            L0046: PushStack(player, 0xFD);
            L004A: PushStack(player, ax);
00A1  004B C4 5E 06  les bx, [bp+0x6]
00A4  004E 26 FF 5F 54  call far word [es:bx+0x54]
            L0052: cx = PopStack(player);
            L0053: cx = PopStack(player);
            L0054: RefreshCompareFlags(ax);
            L0056: if (JumpNotEqual) goto L005B;
            L0058: goto L012D;
            L005B: Compare(si, 0x0C);
00B4  005E 7D 5F  jge 0xbf
            L0060: ShowMessage(player, String0433); // You dispel the wall!
            L006D: si = si + 1;
            L006E: SetFlag(player, 0xC4, 0xB8, si);
            L0080: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L009E: PushStack(player, 0x01);
            L00A2: PushStack(player, GetFacing(player));
            L00AA: PushStack(player, GetCurrentTile(player));
0108  00B2 C4 5E 06  les bx, [bp+0x6]
010B  00B5 26 FF 5F 28  call far word [es:bx+0x28]
010F  00B9 83 C4 06  add sp, 0x6
            L00BC: goto L018A;
            L00BF: ShowMessage(player, String0448); // The item's powers have faded!
            L00CC: ShowMessage(player, String0466); // Now, take this portal back to the rod's source; and try to find a pathway...again.
            L00D9: SetFlag(player, 0x00, 0x02, 0x01);
            L00ED: SetWallObject(player, 0x02, GetCurrentTile(player), GetFacing(player));
            L010B: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
017E  0128 33 C0  xor ax, ax
            L012A: goto L00A1;
            L012D: ShowMessage(player, String04B9); // This wall seems to shimmer, yet it is solid.
            L013A: goto L018A;
            L013C: PushStack(player, 0x02);
            L0140: PushStack(player, 0x00);
0199  0143 C4 5E 06  les bx, [bp+0x6]
019C  0146 26 FF 5F 04  call far word [es:bx+0x4]
            L014A: cx = PopStack(player);
            L014B: cx = PopStack(player);
            L014C: Compare(ax, 0x0001);
            L014F: if (JumpNotEqual) goto L018A;
            L0151: SetWallObject(player, 0x02, GetCurrentTile(player), GetFacing(player));
            L016F: TeleportParty(player, 0x0C, 0x01, 0x48, 0x03, isForwardMove);
            L018A: return; // RETURN (restoring si);
        }

        private void FnDESCRIPA_04(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String04E6); // The tedious journey to this place has made you tired.
            L0010: ShowMessage(player, String051C); // Even so, some walls here seem to fade and shimmer as being pulled upon by unseen forces.
            L001D: ShowMessage(player, String0575); // Grinding sounds of stone echo through these odd shadowy halls. The scent of powerful magics fills your nostrils and fires your mind.
            L002A: return; // RETURN;
        }

        private void FnSECRTDOR_05(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0xC5), 0x0001);
            L0017: if (JumpNotEqual) goto L0077;
            L0019: Compare(GetFlag(player, 0x02, 0xC6), 0x0001);
            L002D: if (JumpNotEqual) goto L0077;
            L002F: ShowMessage(player, String05FA); // The messages of the two old men prove to be the key to opening this secret wall!
            L003C: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L005A: PushStack(player, GetFacing(player));
            L0062: PushStack(player, GetCurrentTile(player));
            L006A: PushStack(player, 0x01);
027D  006E C4 5E 06  les bx, [bp+0x6]
0280  0071 26 FF 5F 30  call far word [es:bx+0x30]
            L0075: goto L00CA;
            L0077: Compare(GetFlag(player, 0x02, 0xC5), 0x0001);
            L008B: if (JumpEqual) goto L00A3;
            L008D: Compare(GetFlag(player, 0x02, 0xC6), 0x0001);
            L00A1: if (JumpNotEqual) goto L00CD;
            L00A3: ShowMessage(player, String064B); // Hmmm...seems like you're missing part of the ritual.  Another may know the second half; then you may find a way through here!
            L00B0: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L00CD: return; // RETURN;
        }

        private void FnHALLDESC_06(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String06C9); // This enormous hallway seems to be devoid of any useful purpose. It's as though the walls here are only boundaries of internally hidden rooms.
            L0010: return; // RETURN;
        }

        private void FnROOMTELE_07(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
02F3  0003 C4 5E 06  les bx, [bp+0x6]
02F6  0006 26 FF 9F E8 00  call far word [es:bx+0xe8]
            L000B: SetFlag(player, 0x02, 0xC4, 0x01);
            L0020: ShowMessage(player, String0757); // Magical energy radiates from all around you.
            L002D: ShowMessage(player, String0784); // These mystical teleports project dazzling colors of light that refract and reflect off of each other with blinding beauty.
            L003A: ShowMessage(player, String07FF); // Three shafts of pure light pour down from above onto the Rod of Dissemination, restoring its magical properties.
            L0047: return; // RETURN;
        }

        private void FnTWINROOM_08(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0870); // Two small dwellings stand opposite each other in this small room. Strange mumblings are coming from the southern one.
            L0010: ShowMessage(player, String08E6); // Northward, however, you can just make out low hissing sounds and snarls.
            L001D: return; // RETURN;
        }

        private void FnLRGROOM_09(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String092F); // Deep sorrowful moans surround you in this dingy place.
            L0010: ShowMessage(player, String0966); // Odd shadows flicker and fold in on one another against the walls.  The shadows themselves seem alive.
            L001D: return; // RETURN;
        }

        private void FnITEMSBAT_0A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: ax = HasItem(player, 0xFD);
            L0012: if (JumpEqual) goto L0023;
            L0014: ShowMessage(player, String09CC); // Stains of combat cover the floor, but there is nothing of interest here... except a few Erebus fiends!
            L0021: goto L0094;
            L0023: RefreshCompareFlags(GetFlag(player, 0x02, 0xC3));
            L0036: if (JumpNotEqual) goto L006E;
03AF  0038 B8 10 27  mov ax, 0x2710
            L003B: PushStack(player, ax);
            L003C: PushStack(player, 0x00);
            L003F: PushStack(player, ax);
            L0040: PushStack(player, 0xAB);
            L0044: PushStack(player, 0xCE);
            L0048: PushStack(player, 0xFD);
03C3  004C C4 5E 06  les bx, [bp+0x6]
03C6  004F 26 FF 9F D8 00  call far word [es:bx+0xd8]
03CB  0054 83 C4 0C  add sp, 0xc
            L0057: SetFlag(player, 0x02, 0xC3, 0x01);
            L006C: goto L0087;
03E5  006E B8 88 13  mov ax, 0x1388
            L0071: PushStack(player, ax);
            L0072: PushStack(player, 0x00);
            L0075: PushStack(player, ax);
            L0076: PushStack(player, ax);
            L0077: PushStack(player, ax);
            L0078: PushStack(player, 0xFD);
03F3  007C C4 5E 06  les bx, [bp+0x6]
03F6  007F 26 FF 9F D8 00  call far word [es:bx+0xd8]
03FB  0084 83 C4 0C  add sp, 0xc
03FE  0087 FF 76 08  push word [bp+0x8]
0401  008A FF 76 06  push word [bp+0x6]
0404  008D 0E     push cs
0405  008E E8 85 00  call 0x116
            L0091: // NOP
            L0092: cx = PopStack(player);
            L0093: cx = PopStack(player);
            L0094: Compare(PartyCount(player), 0x0001);
            L009F: if (JumpEqual) goto L00A8;
            L00A1: Compare(ax, 0x0002);
            L00A4: if (JumpEqual) goto L00CB;
            L00A6: goto L00E7;
            L00A8: si = 0x0001;
            L00AB: goto L00BD;
            L00AD: AddEncounter(player, si, 0x19);
            L00BC: si = si + 1;
            L00BD: Compare(si, 0x02);
            L00C0: if (JumpLessOrEqual) goto L00AD;
            L00C2: PushStack(player, 0x1A);
043D  00C6 B8 05 00  mov ax, 0x5
            L00C9: goto L0108;
            L00CB: si = 0x0001;
            L00CE: goto L00E0;
            L00D0: AddEncounter(player, si, 0x19);
            L00DF: si = si + 1;
            L00E0: Compare(si, 0x02);
            L00E3: if (JumpLessOrEqual) goto L00D0;
            L00E5: goto L0101;
            L00E7: si = 0x0001;
            L00EA: goto L00FC;
            L00EC: AddEncounter(player, si, 0x19);
            L00FB: si = si + 1;
            L00FC: Compare(si, 0x04);
            L00FF: if (JumpLessOrEqual) goto L00EC;
            L0101: AddEncounter(player, 0x06, 0x1A);
            L0113: return; // RETURN (restoring si);
            // Extra data: 55 8B EC B8 33 0A 50 C4 5E 06 26 FF 9F F8 00 59 5D CB 
        }

        private void FnDISPSTAT_0B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si, di);
            L0005: ax = GetFlag(player, 0x02, 0xC4);
04B5  0016 8B F8  mov di, ax
            L0018: ShowMessage(player, String0AC2); // The statue seems to shimmer, yet it is apparently solid.
            L0025: ax = IsFlagOn(player, 0x02, 0xC4);
            L0038: if (JumpNotEqual) goto L003D;
            L003A: goto L0125;
            L003D: PushStack(player, 0xFD);
            L0041: PushStack(player, ax);
04E1  0042 C4 5E 06  les bx, [bp+0x6]
04E4  0045 26 FF 5F 54  call far word [es:bx+0x54]
            L0049: cx = PopStack(player);
            L004A: cx = PopStack(player);
            L004B: RefreshCompareFlags(ax);
            L004D: if (JumpNotEqual) goto L0052;
            L004F: goto L0125;
04F1  0052 83 FF 0C  cmp di, 0xc
            L0055: if (JumpLess) goto L005A;
            L0057: goto L00F0;
            L005A: ShowMessage(player, String0AFB); // You dispel the statue!
0506  0067 47     inc di
0507  0068 57     push di
            L0069: PushStack(player, 0xC4);
            L006D: PushStack(player, 0x02);
0510  0071 C4 5E 06  les bx, [bp+0x6]
0513  0074 26 FF 1F  call far word [es:bx]
0516  0077 83 C4 06  add sp, 0x6
            L007A: Compare(GetFacing(player), 0x0003);
            L0084: if (JumpNotEqual) goto L0092;
            L0086: si = GetCurrentTile(player) + 0xFFF0;
            L0092: Compare(GetFacing(player), 0x0002);
            L009C: if (JumpNotEqual) goto L00A8;
            L009E: ax = GetCurrentTile(player);
0544  00A5 40     inc ax
            L00A6: si = ax;
            L00A8: Compare(GetFacing(player), 0x0001);
            L00B2: if (JumpNotEqual) goto L00C0;
            L00B4: si = GetCurrentTile(player) + 0x0010;
            L00C0: RefreshCompareFlags(GetFacing(player));
            L00C9: if (JumpNotEqual) goto L00D5;
            L00CB: ax = GetCurrentTile(player);
0571  00D2 48     dec ax
            L00D3: si = ax;
            L00D5: PushStack(player, 0x01);
0578  00D9 56     push si
0579  00DA C4 5E 06  les bx, [bp+0x6]
057C  00DD 26 FF 5F 34  call far word [es:bx+0x34]
            L00E1: cx = PopStack(player);
            L00E2: cx = PopStack(player);
0582  00E3 56     push si
            L00E4: PushStack(player, 0x00);
0586  00E7 C4 5E 06  les bx, [bp+0x6]
0589  00EA 26 FF 5F 38  call far word [es:bx+0x38]
            L00EE: goto L0123;
            L00F0: ShowMessage(player, String0B12); // The item's powers have faded and pull you back to their source.
            L00FD: TeleportParty(player, 0x0C, 0x01, 0x48, 0x03, isForwardMove);
            L0118: PushStack(player, 0x00);
05BA  011B 56     push si
05BB  011C C4 5E 06  les bx, [bp+0x6]
05BE  011F 26 FF 5F 34  call far word [es:bx+0x34]
            L0123: cx = PopStack(player);
            L0124: cx = PopStack(player);
            L0125: return; // RETURN (restoring si, di);
        }

        private void FnSTATBATL_0C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0B52); // By dispelling this statue you've released the imprisoned creature! It intends to reward you with death!
            L0010: AddEncounter(player, 0x01, 0x1B);
            L0022: return; // RETURN;
        }

        private void FnNPCONE_0D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x02, 0xC5));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00E6;
            L001B: RefreshCompareFlags(GetFlag(player, 0x03, 0x01));
            L002E: if (JumpNotEqual) goto L006F;
            L0030: ShowPortrait(player, 0x0007);
            L003D: ShowMessage(player, String0BBA); // A sinewy beast stares angrily at you for your intrusion into his home.
            L004A: ShowMessage(player, String0C01); // 'You have no business here. Leave before I become enraged and destroy you!'
            L0057: SetFlag(player, 0x03, 0x01, 0x02);
            L006C: goto L00F3;
            L006F: Compare(GetFlag(player, 0x03, 0x02), 0x0001);
            L0083: if (JumpEqual) goto L009A;
            L0085: ax = IsFlagOn(player, 0x02, 0xC6);
            L0098: if (JumpEqual) goto L00F3;
            L009A: ShowPortrait(player, 0x0007);
            L00A7: ShowMessage(player, String0C4D); // 'Ahh, you've met my twin, I see.
            L00B4: ShowMessage(player, String0C6E); // Say his chant in time with mine, and at the wall, the ingress shall be thine.'
            L00C1: ShowMessage(player, String0CBD); // Ieoa then turns away pleased with his 'creativity'%.
            L00CE: SetFlag(player, 0x02, 0xC5, 0x01);
            L00E3: goto L0057;
            L00E6: ShowMessage(player, String0CF2); // Ieoa has left the dungeon.
            L00F3: return; // RETURN;
        }

        private void FnNPCTWO_0E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0007);
            L0010: RefreshCompareFlags(GetFlag(player, 0x02, 0xC6));
            L0023: if (JumpEqual) goto L0028;
            L0025: goto L00F7;
            L0028: RefreshCompareFlags(GetFlag(player, 0x03, 0x02));
            L003B: if (JumpNotEqual) goto L0098;
            L003D: ShowMessage(player, String0BBA); // A sinewy beast stares angrily at you for your intrusion into his home.
            L004A: ShowMessage(player, String0D0D); // 'Away with you, go bother my brother to the west.'
            L0057: SetFlag(player, 0x03, 0x02, 0x01);
            L006C: RefreshCompareFlags(GetFlag(player, 0x03, 0x01));
            L007F: if (JumpEqual) goto L0084;
            L0081: goto L0104;
            L0084: PushStack(player, 0x01);
            L0088: PushStack(player, ax);
            L0089: PushStack(player, 0x03);
076E  008D C4 5E 06  les bx, [bp+0x6]
0771  0090 26 FF 1F  call far word [es:bx]
0774  0093 83 C4 06  add sp, 0x6
            L0096: goto L0104;
            L0098: Compare(GetFlag(player, 0x03, 0x01), 0x0002);
            L00AC: if (JumpNotEqual) goto L0104;
            L00AE: ShowMessage(player, String0D40); // 'Did you enjoy your talk with Ieoa?
            L00BB: ShowMessage(player, String0D64); // My verse shan't be before if you wish to find the door. Seek Ieoa, the twin; with his rhyme you begin.'
            L00C8: ShowMessage(player, String0DCC); // Aoei then turns away pleased with his 'creativity'%.
            L00D5: SetFlag(player, 0x03, 0x02, 0x01);
            L00EA: PushStack(player, 0x01);
            L00EE: PushStack(player, 0xC6);
07D3  00F2 B8 02 00  mov ax, 0x2
            L00F5: goto L008C;
            L00F7: ShowMessage(player, String0E01); // Aoei has left the dungeon.
            L0104: return; // RETURN;
        }

        private void FnSMALBAT_0F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: ShowMessage(player, String0E1C); // You happen across some feuding Kaalroths that dismiss their argument for some tasty combat.
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
            L003F: goto L0077;
            L0041: si = 0x0001;
            L0044: goto L0056;
            L0046: AddEncounter(player, si, 0x1C);
            L0055: si = si + 1;
            L0056: Compare(si, 0x03);
            L0059: if (JumpLessOrEqual) goto L0046;
            L005B: goto L0077;
            L005D: si = 0x0001;
            L0060: goto L0072;
            L0062: AddEncounter(player, si, 0x1C);
            L0071: si = si + 1;
            L0072: Compare(si, 0x05);
            L0075: if (JumpLessOrEqual) goto L0062;
            L0077: return; // RETURN (restoring si);
        }

        private void FnNPCBATTL_10(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: ShowMessage(player, String0E78); // A warring party of Night Elf Pilgrims drags you into the fray.
            L0011: Compare(PartyCount(player), 0x0001);
            L001C: if (JumpEqual) goto L0025;
            L001E: Compare(ax, 0x0002);
            L0021: if (JumpEqual) goto L0041;
            L0023: goto L005D;
            L0025: si = 0x0001;
            L0028: goto L003A;
            L002A: AddEncounter(player, si, 0x1D);
            L0039: si = si + 1;
            L003A: Compare(si, 0x02);
            L003D: if (JumpLessOrEqual) goto L002A;
            L003F: goto L0077;
            L0041: si = 0x0001;
            L0044: goto L0056;
            L0046: AddEncounter(player, si, 0x1D);
            L0055: si = si + 1;
            L0056: Compare(si, 0x03);
            L0059: if (JumpLessOrEqual) goto L0046;
            L005B: goto L0077;
            L005D: si = 0x0001;
            L0060: goto L0072;
            L0062: AddEncounter(player, si, 0x1D);
            L0071: si = si + 1;
            L0072: Compare(si, 0x05);
            L0075: if (JumpLessOrEqual) goto L0062;
            L0077: return; // RETURN (restoring si);
        }

        private void FnDRAGBATL_11(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: ShowMessage(player, String0EB7); // You suddenly feel out matched as a small nest of dragons charges at you!
            L0011: Compare(PartyCount(player), 0x0001);
            L001C: if (JumpEqual) goto L0025;
            L001E: Compare(ax, 0x0002);
            L0021: if (JumpEqual) goto L0041;
            L0023: goto L005D;
            L0025: si = 0x0001;
            L0028: goto L003A;
            L002A: AddEncounter(player, si, 0x1E);
            L0039: si = si + 1;
            L003A: Compare(si, 0x02);
            L003D: if (JumpLessOrEqual) goto L002A;
            L003F: goto L0077;
            L0041: si = 0x0001;
            L0044: goto L0056;
            L0046: AddEncounter(player, si, 0x1E);
            L0055: si = si + 1;
            L0056: Compare(si, 0x03);
            L0059: if (JumpLessOrEqual) goto L0046;
            L005B: goto L0077;
            L005D: si = 0x0001;
            L0060: goto L0072;
            L0062: AddEncounter(player, si, 0x1E);
            L0071: si = si + 1;
            L0072: Compare(si, 0x05);
            L0075: if (JumpLessOrEqual) goto L0062;
            L0077: return; // RETURN (restoring si);
        }

        private void FnRAITHBAT_12(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: ShowMessage(player, String0F00); // Shimmering moans and shadowy figures surround you!
            L0011: Compare(PartyCount(player), 0x0001);
            L001C: if (JumpEqual) goto L0025;
            L001E: Compare(ax, 0x0002);
            L0021: if (JumpEqual) goto L0041;
            L0023: goto L005D;
            L0025: si = 0x0001;
            L0028: goto L003A;
            L002A: AddEncounter(player, si, 0x1F);
            L0039: si = si + 1;
            L003A: Compare(si, 0x02);
            L003D: if (JumpLessOrEqual) goto L002A;
            L003F: goto L0077;
            L0041: si = 0x0001;
            L0044: goto L0056;
            L0046: AddEncounter(player, si, 0x1F);
            L0055: si = si + 1;
            L0056: Compare(si, 0x03);
            L0059: if (JumpLessOrEqual) goto L0046;
            L005B: goto L0077;
            L005D: si = 0x0001;
            L0060: goto L0072;
            L0062: AddEncounter(player, si, 0x1F);
            L0071: si = si + 1;
            L0072: Compare(si, 0x05);
            L0075: if (JumpLessOrEqual) goto L0062;
            L0077: return; // RETURN (restoring si);
        }

        private void FnDRAGTWO_13(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0F33); // A huge Red Dragon sends a barrage of flames towards you!
            L0010: ax = CheckLevel(player, 0x0030);
            L001E: if (JumpEqual) goto L0025;
09EF  0020 B8 20 00  mov ax, 0x20
            L0023: goto L003D;
            L0025: ax = CheckLevel(player, 0x0024);
            L0033: if (JumpEqual) goto L003A;
0A04  0035 B8 18 00  mov ax, 0x18
            L0038: goto L003D;
            L003A: AddEncounter(player, 0x01, 0x17);
            L004C: return; // RETURN;
        }

        private void FnWAYOUT_14(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0F6C); // This jeweled teleport will send you to the final confrontation. The Queen awaits.
            L0010: SetFlag(player, 0x02, 0xC2, 0x01);
            L0025: TeleportParty(player, 0x0C, 0x02, 0xFF, 0x00, isForwardMove);
            L003F: return; // RETURN;
        }

        private void FnSOUTHWST_15(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0FBE); // Perhaps the way out is near!!!
            L0010: TeleportParty(player, 0x0C, 0x01, 0xC1, 0x03, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnHUGEBTLA_16(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: ShowMessage(player, String0FDD); // An arsenal of creatures bars your way here.
            L0011: Compare(PartyCount(player), 0x0001);
            L001C: if (JumpEqual) goto L0025;
            L001E: Compare(ax, 0x0002);
            L0021: if (JumpEqual) goto L0040;
            L0023: goto L005C;
            L0025: AddEncounter(player, 0x01, 0x19);
            L0037: PushStack(player, 0x21);
0AC6  003B B8 05 00  mov ax, 0x5
            L003E: goto L007D;
            L0040: si = 0x0001;
            L0043: goto L0055;
            L0045: AddEncounter(player, si, 0x19);
            L0054: si = si + 1;
            L0055: Compare(si, 0x03);
            L0058: if (JumpLessOrEqual) goto L0045;
            L005A: goto L0076;
            L005C: si = 0x0001;
            L005F: goto L0071;
            L0061: AddEncounter(player, si, 0x1C);
            L0070: si = si + 1;
            L0071: Compare(si, 0x04);
            L0074: if (JumpLessOrEqual) goto L0061;
            L0076: AddEncounter(player, 0x06, 0x21);
            L0088: return; // RETURN (restoring si);
        }

        private void FnHUGBTLB_17(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: ShowMessage(player, String1009); // Servants of Dissemination attack!
            L0011: Compare(PartyCount(player), 0x0001);
            L001C: if (JumpEqual) goto L0025;
            L001E: Compare(ax, 0x0002);
            L0021: if (JumpEqual) goto L0041;
            L0023: goto L0077;
            L0025: si = 0x0001;
            L0028: goto L003A;
            L002A: AddEncounter(player, si, 0x22);
            L0039: si = si + 1;
            L003A: Compare(si, 0x02);
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
            L008C: Compare(si, 0x04);
            L008F: if (JumpLessOrEqual) goto L007C;
            L0091: return; // RETURN (restoring si);
        }

        private void FnSTATBTLB_18(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String102B); // The marble statue crumbles away, releasing an ominous beast of power.
            L0010: AddEncounter(player, 0x01, 0x23);
            L0022: return; // RETURN;
        }

        private void FnWISENPC_19(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x000B);
            L0010: ShowMessage(player, String1071); // 'I am frozen in time here! I tried to use the Portal without the proper knowledge!
            L001D: ShowMessage(player, String10C4); // Learn from me! Do not use the Portal below!'
            L002A: return; // RETURN;
        }

        private void FnPETRIFY_1A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x01);
            L0007: PushStack(player, 0x00);
0C04  000A C4 5E 06  les bx, [bp+0x6]
0C07  000D 26 FF 5F 04  call far word [es:bx+0x4]
            L0011: cx = PopStack(player);
            L0012: cx = PopStack(player);
            L0013: RefreshCompareFlags(ax);
            L0015: if (JumpNotEqual) goto L004C;
            L0017: ShowMessage(player, String10F1); // You've sprung an ancient trap that seems not to have harmed you...much.
            L0024: ax = GetCurrentHits(player);
            L002B: bx = 0x0004;
            L002E: dx = ax % bx; ax = ax / bx;
            L0031: DamagePlayer(player, ax);
            L003B: PushStack(player, 0x01);
            L003F: PushStack(player, ax);
            L0040: PushStack(player, 0x00);
0C3D  0043 C4 5E 06  les bx, [bp+0x6]
0C40  0046 26 FF 1F  call far word [es:bx]
0C43  0049 83 C4 06  add sp, 0x6
            L004C: return; // RETURN;
        }

        private void FnFIRBURST_1B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x01);
            L0007: PushStack(player, 0x00);
0C52  000A C4 5E 06  les bx, [bp+0x6]
0C55  000D 26 FF 5F 04  call far word [es:bx+0x4]
            L0011: cx = PopStack(player);
            L0012: cx = PopStack(player);
            L0013: RefreshCompareFlags(ax);
            L0015: if (JumpNotEqual) goto L006C;
            L0017: PushStack(player, 0x03);
            L001B: PushStack(player, ax);
0C64  001C C4 5E 06  les bx, [bp+0x6]
0C67  001F 26 FF 5F 04  call far word [es:bx+0x4]
            L0023: cx = PopStack(player);
            L0024: cx = PopStack(player);
            L0025: RefreshCompareFlags(ax);
            L0027: if (JumpNotEqual) goto L004E;
            L0029: ShowMessage(player, String1139); // A dragon's face is carved on the wall where the torch here hangs. As you walk by the wall it comes to life and spews waves of fire over you!
            L0036: ax = GetCurrentHits(player);
            L003D: bx = 0x0005;
            L0040: dx = ax % bx; ax = ax / bx;
            L0043: PushStack(player, ax);
0C8C  0044 C4 5E 06  les bx, [bp+0x6]
0C8F  0047 26 FF 9F 90 00  call far word [es:bx+0x90]
            L004C: goto L005A;
            L004E: ShowMessage(player, String11C6); // The carved dragon on the wall remains silent.
            L005B: PushStack(player, 0x01);
            L005F: PushStack(player, ax);
            L0060: PushStack(player, 0x00);
0CAB  0063 C4 5E 06  les bx, [bp+0x6]
0CAE  0066 26 FF 1F  call far word [es:bx]
0CB1  0069 83 C4 06  add sp, 0x6
            L006C: return; // RETURN;
        }

        private void FnGUARDIAN_1C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: ShowMessage(player, String11F4); // 'You must defeat us to proceed! We are everlasting forces here!'
            L0011: Compare(PartyCount(player), 0x0001);
            L001C: if (JumpEqual) goto L0025;
            L001E: Compare(ax, 0x0002);
            L0021: if (JumpEqual) goto L0041;
            L0023: goto L005D;
            L0025: si = 0x0001;
            L0028: goto L003A;
            L002A: AddEncounter(player, si, 0x24);
            L0039: si = si + 1;
            L003A: Compare(si, 0x03);
            L003D: if (JumpLessOrEqual) goto L002A;
            L003F: goto L0077;
            L0041: si = 0x0001;
            L0044: goto L0056;
            L0046: AddEncounter(player, si, 0x24);
            L0055: si = si + 1;
            L0056: Compare(si, 0x04);
            L0059: if (JumpLessOrEqual) goto L0046;
            L005B: goto L0077;
            L005D: si = 0x0001;
            L0060: goto L0072;
            L0062: AddEncounter(player, si, 0x24);
            L0071: si = si + 1;
            L0072: Compare(si, 0x06);
            L0075: if (JumpLessOrEqual) goto L0062;
            L0077: return; // RETURN (restoring si);
        }

        private void FnTOEGRESS_1D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1235); // This MUST lead out of this level.
            L0010: TeleportParty(player, 0x0C, 0x01, 0x98, 0x02, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnWAYOUTM_1E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1257); // The end must be near; you can see huge forces of creatures moving about nearby.
            L0010: ShowMessage(player, String12A7); // Waste not your charges on futile walls!
            L001D: return; // RETURN;
        }

        private void FnPOISON_1F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String12CF); // The Guardians here launch a spread of evil magic towards you. The mysterious vapors envelop your body as a ring of opaque fog.
0D8C  0010 B8 BC 02  mov ax, 0x2bc
            L0013: PushStack(player, ax);
            L0014: PushStack(player, 0x0A);
            L0018: PushStack(player, 0x01);
0D98  001C C4 5E 06  les bx, [bp+0x6]
0D9B  001F 26 FF 9F 9C 00  call far word [es:bx+0x9c]
0DA0  0024 83 C4 06  add sp, 0x6
            L0027: ModifyAttribute(player, 0x01, 0xFFFF);
            L0039: ModifyAttribute(player, 0x02, 0xFFFF);
            L004B: return; // RETURN;
        }

        private void FnMEDBATLA_20(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: ShowMessage(player, String134E); // Creatures surprise you!
            L0011: PushStack(player, 0x01);
            L0015: PushStack(player, 0x00);
0DE1  0018 C4 5E 06  les bx, [bp+0x6]
0DE4  001B 26 FF 5F 04  call far word [es:bx+0x4]
            L001F: cx = PopStack(player);
            L0020: cx = PopStack(player);
            L0021: RefreshCompareFlags(ax);
            L0023: if (JumpNotEqual) goto L005F;
            L0025: ax = GetCurrentHits(player);
            L002C: bx = 0x0006;
            L002F: dx = ax % bx; ax = ax / bx;
            L0032: DamagePlayer(player, ax);
            L003C: ModifyGold(player, 0xFFFF3CBA);
            L004E: PushStack(player, 0x01);
            L0052: PushStack(player, ax);
            L0053: PushStack(player, 0x00);
0E1F  0056 C4 5E 06  les bx, [bp+0x6]
0E22  0059 26 FF 1F  call far word [es:bx]
0E25  005C 83 C4 06  add sp, 0x6
            L005F: Compare(PartyCount(player), 0x0001);
            L006A: if (JumpEqual) goto L0073;
            L006C: Compare(ax, 0x0002);
            L006F: if (JumpEqual) goto L008F;
            L0071: goto L00AB;
            L0073: si = 0x0001;
            L0076: goto L0088;
            L0078: AddEncounter(player, si, 0x16);
            L0087: si = si + 1;
            L0088: Compare(si, 0x02);
            L008B: if (JumpLessOrEqual) goto L0078;
            L008D: goto L00C5;
            L008F: si = 0x0001;
            L0092: goto L00A4;
            L0094: AddEncounter(player, si, 0x16);
            L00A3: si = si + 1;
            L00A4: Compare(si, 0x04);
            L00A7: if (JumpLessOrEqual) goto L0094;
            L00A9: goto L00C5;
            L00AB: si = 0x0001;
            L00AE: goto L00C0;
            L00B0: AddEncounter(player, si, 0x16);
            L00BF: si = si + 1;
            L00C0: Compare(si, 0x06);
            L00C3: if (JumpLessOrEqual) goto L00B0;
            L00C5: return; // RETURN (restoring si);
        }

        private void FnMEDBATLB_21(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: ShowMessage(player, String1366); // You surprise some beasts examining an interesting sword.
            L0011: RefreshCompareFlags(GetFlag(player, 0x02, 0xD1));
            L0024: if (JumpNotEqual) goto L005B;
0EB7  0026 B8 A8 61  mov ax, 0x61a8
            L0029: PushStack(player, ax);
            L002A: PushStack(player, 0x7F);
            L002E: PushStack(player, 0x18);
            L0032: PushStack(player, 0xB8);
            L0036: PushStack(player, ax);
            L0037: PushStack(player, 0x11);
0ECC  003B C4 5E 06  les bx, [bp+0x6]
0ECF  003E 26 FF 9F D8 00  call far word [es:bx+0xd8]
0ED4  0043 83 C4 0C  add sp, 0xc
            L0046: SetFlag(player, 0x02, 0xD1, 0x01);
            L005B: Compare(PartyCount(player), 0x0001);
            L0066: if (JumpEqual) goto L006F;
            L0068: Compare(ax, 0x0002);
            L006B: if (JumpEqual) goto L008B;
            L006D: goto L00A7;
            L006F: si = 0x0001;
            L0072: goto L0084;
            L0074: AddEncounter(player, si, 0x19);
            L0083: si = si + 1;
            L0084: Compare(si, 0x02);
            L0087: if (JumpLessOrEqual) goto L0074;
            L0089: goto L00C1;
            L008B: si = 0x0001;
            L008E: goto L00A0;
            L0090: AddEncounter(player, si, 0x16);
            L009F: si = si + 1;
            L00A0: Compare(si, 0x03);
            L00A3: if (JumpLessOrEqual) goto L0090;
            L00A5: goto L00C1;
            L00A7: si = 0x0001;
            L00AA: goto L00BC;
            L00AC: AddEncounter(player, si, 0x18);
            L00BB: si = si + 1;
            L00BC: Compare(si, 0x03);
            L00BF: if (JumpLessOrEqual) goto L00AC;
            L00C1: return; // RETURN (restoring si);
        }

        private void FnHERMTNPC_22(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x002D);
            L0010: ShowMessage(player, String139F); // An old hermit squints at you, 'The Portal you seek cannot be entered yet.  Your task will end in futility!
            L001D: ShowMessage(player, String140A); // You must gain in ways before you gain the wisdom.'
            L002A: ShowMessage(player, String143D); // The rantings of a fool, eh?
            L0037: return; // RETURN;
        }

        private void FnTOCNTUP_23(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1459); // This portal, however, you can enter.
            L0010: TeleportParty(player, 0x0C, 0x01, 0x88, 0x03, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnDRAGBATA_24(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: ShowMessage(player, String147E); // Some young dragons are scrounging for food, they notice you and attempt to make you their meal.
            L0011: Compare(PartyCount(player), 0x0001);
            L001C: if (JumpEqual) goto L0025;
            L001E: Compare(ax, 0x0002);
            L0021: if (JumpEqual) goto L0041;
            L0023: goto L005D;
            L0025: si = 0x0001;
            L0028: goto L003A;
            L002A: AddEncounter(player, si, 0x1E);
            L0039: si = si + 1;
            L003A: Compare(si, 0x02);
            L003D: if (JumpLessOrEqual) goto L002A;
            L003F: goto L0077;
            L0041: si = 0x0001;
            L0044: goto L0056;
            L0046: AddEncounter(player, si, 0x1E);
            L0055: si = si + 1;
            L0056: Compare(si, 0x03);
            L0059: if (JumpLessOrEqual) goto L0046;
            L005B: goto L0077;
            L005D: si = 0x0001;
            L0060: goto L0072;
            L0062: AddEncounter(player, si, 0x1E);
            L0071: si = si + 1;
            L0072: Compare(si, 0x05);
            L0075: if (JumpLessOrEqual) goto L0062;
            L0077: return; // RETURN (restoring si);
        }

        private void FnBIGBATL_25(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: ShowMessage(player, String14DE); // You've happened upon some very unpleasant sorts!
            L0011: Compare(PartyCount(player), 0x0001);
            L001C: if (JumpEqual) goto L0025;
            L001E: Compare(ax, 0x0002);
            L0021: if (JumpEqual) goto L0041;
            L0023: goto L005D;
            L0025: si = 0x0001;
            L0028: goto L003A;
            L002A: AddEncounter(player, si, 0x03);
            L0039: si = si + 1;
            L003A: Compare(si, 0x03);
            L003D: if (JumpLessOrEqual) goto L002A;
            L003F: goto L0077;
            L0041: si = 0x0001;
            L0044: goto L0056;
            L0046: AddEncounter(player, si, 0x04);
            L0055: si = si + 1;
            L0056: Compare(si, 0x04);
            L0059: if (JumpLessOrEqual) goto L0046;
            L005B: goto L0077;
            L005D: si = 0x0001;
            L0060: goto L0072;
            L0062: AddEncounter(player, si, 0x06);
            L0071: si = si + 1;
            L0072: Compare(si, 0x06);
            L0075: if (JumpLessOrEqual) goto L0062;
            L0077: return; // RETURN (restoring si);
        }

        private void FnSWITCH_26(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x03);
            L0007: PushStack(player, ax);
10B7  0008 C4 5E 06  les bx, [bp+0x6]
10BA  000B 26 FF 5F 0C  call far word [es:bx+0xc]
            L000F: cx = PopStack(player);
            L0010: cx = PopStack(player);
            L0011: RefreshCompareFlags(ax);
            L0013: if (JumpEqual) goto L0041;
            L0015: ShowMessage(player, String150F); // A lever here is marked DO NOT TOUCH!
            L0022: ShowMessage(player, String1534); // Using your better judgement, you move the lever.
            L002F: ShowMessage(player, String1565); // You hear clicks and sliding noises of stone on stone echo through nearby corridors.
10EB  003C B8 01 00  mov ax, 0x1
            L003F: goto L0050;
            L0041: ShowMessage(player, String15B9); // You decidedly move the switch again, thinking it best not to fiddle with things so well marked.
            L004E: PushStack(player, 0x00);
            L0051: PushStack(player, 0x03);
            L0055: PushStack(player, ax);
1105  0056 C4 5E 06  les bx, [bp+0x6]
1108  0059 26 FF 1F  call far word [es:bx]
110B  005C 83 C4 06  add sp, 0x6
            L005F: return; // RETURN;
        }

        private void FnSOUTHEAS_27(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1619); // A glowing teleport stands ready.
            L0010: TeleportParty(player, 0x0C, 0x01, 0xED, 0x01, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnNORTHEAS_28(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1619); // A glowing teleport stands ready.
            L0010: TeleportParty(player, 0x0C, 0x01, ax, 0x00, isForwardMove);
            L0027: return; // RETURN;
        }

        private void FnMIDWEST_29(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1619); // A glowing teleport stands ready.
            L0010: TeleportParty(player, 0x0C, 0x01, 0x90, 0x03, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnNPCBATLB_2A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String163A); // A war party of adventurers prepare an offensive.
            L0010: Compare(PartyCount(player), 0x0001);
            L001B: if (JumpEqual) goto L0024;
            L001D: Compare(ax, 0x0002);
            L0020: if (JumpEqual) goto L0040;
            L0022: goto L007F;
            L0024: AddEncounter(player, 0x01, 0x0F);
            L0036: PushStack(player, 0x11);
11CD  003A B8 02 00  mov ax, 0x2
            L003D: goto L00CE;
            L0040: AddEncounter(player, 0x01, 0x14);
            L0052: AddEncounter(player, 0x02, 0x12);
            L0064: AddEncounter(player, 0x03, 0x13);
            L0076: PushStack(player, 0x10);
120D  007A B8 04 00  mov ax, 0x4
            L007D: goto L00E0;
            L007F: AddEncounter(player, 0x01, 0x0F);
            L0091: AddEncounter(player, 0x02, 0x14);
            L00A3: AddEncounter(player, 0x03, 0x11);
            L00B5: AddEncounter(player, 0x04, 0x12);
            L00C7: AddEncounter(player, 0x05, 0x13);
            L00D9: AddEncounter(player, 0x06, 0x10);
            L00EB: return; // RETURN;
        }

        private void FnDRAGDEN_2B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String166B); // It's unusually dim in this room.  It appears as though a violent battle has recently taken place;
            L0010: ShowMessage(player, String16CD); // seeing that charred remains litter the floor and scorch marked stone decorates the walls!
            L001D: return; // RETURN;
        }

        private void FnNOMAPS_2D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
12A7  0003 C4 5E 06  les bx, [bp+0x6]
12AA  0006 26 FF 9F E8 00  call far word [es:bx+0xe8]
            L000B: return; // RETURN;
        }

        private void FnSETFLAG_2E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0xFD);
            L0011: if (JumpEqual) goto L004A;
            L0013: RefreshCompareFlags(GetFlag(player, 0x02, 0xC4));
            L0026: if (JumpNotEqual) goto L004A;
            L0028: SetFlag(player, 0x02, 0xC4, 0x01);
            L003D: ShowMessage(player, String1727); // The Rod of Dissemination ignites with magical fury! Use it to blaze your own pathway through these magical walls.
            L004A: return; // RETURN;
        }

    }
}
