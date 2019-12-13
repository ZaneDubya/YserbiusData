#pragma warning disable
using System.Collections.Generic;
using XPT.WorldData;
using XPT.WorldData.Yserbius;

namespace XPT.Scripts.Twinion.Maps {
    class TwMap00 : AMapScripted {
        protected override int MapIndex => 0;
        protected override int RandomEncounterChance => 0;
        protected override int RandomEncounterExtraCount => 0;

        public TwMap00() {
            MapEvent01 = FnEXIT_01;
            MapEvent02 = FnTOCHALNG_02;
            MapEvent03 = FnTOEZQEST_03;
            MapEvent04 = FnTOUPRLVL_04;
            MapEvent05 = FnTOMAPQST_05;
            MapEvent06 = FnTODRAKS_06;
            MapEvent07 = FnAXSTOLOW_07;
            MapEvent08 = FnAXSTODRK_08;
            MapEvent09 = FnSTRIPEM_09;
            MapEvent0A = FnYOURHERE_0A;
            MapEvent0B = FnURHERE_0B;
            MapEvent0C = FnNOJOIN_0C;
            MapEvent0D = FnQUEENY_0D;
            MapEvent0E = FnNOMAPS_0E;
            MapEvent0F = FnSTOPHERE_0F;
            MapEvent11 = FnNOTHING_11;
            MapEvent12 = FnTOTWELVE_12;
            MapEvent13 = FnTODISSEM_13;
            MapEvent14 = FnTOTHEEND_14;
        }
        
        // === Strings ================================================
        private const string String03FC = "This Gateway leads out of the Dungeon.";
        private const string String0423 = "The door is marked: 'To Gauntlet Gauche.'";
        private const string String044D = "Herein lies Gauntlet Droit.";
        private const string String0469 = "To the first level of Her Majesty's proving grounds...The Queen's Aqueduct.";
        private const string String04B5 = "Enter the Kingdom of the Night Elves... ";
        private const string String04DE = "               ....and beware.";
        private const string String04FD = "Here you enter the Dralkarians' Lair.";
        private const string String0523 = "As you unlock the door with Her Majesty's key, the lock on the door as well as the key vanish!";
        private const string String0582 = "Now the door will remain unlocked.";
        private const string String05A5 = "The Queen's key is needed to unlock this door.";
        private const string String05D4 = "Only more experienced heroes may venture beyond this gateway. And even then, you must enter alone!";
        private const string String0637 = "Find your fate in the portal east of here.";
        private const string String0662 = "Your map begins to glow with an eerie green light. The light then fades to red followed by blue and finally brilliant yellow.";
        private const string String06E0 = "The magical light of this most curious map dispels the door's magic!";
        private const string String0725 = "The map, drained of its powers, crumbles into the nothingness from which it came.";
        private const string String0777 = "You must journey northward alone!";
        private const string String0799 = "Destiny awaits. It will be here for you when you are ready.";
        private const string String07D5 = "Northward lies the passage of Fate.";
        private const string String07F9 = "A maniacal fiend appears; removes an item you stole from him; and kills you outright.";
        private const string String084F = "Welcome, brave Champions. To the west lies Gauntlet Gauche: one of the two maps that interweave a simple quest.";
        private const string String08BF = "Eastward lies Gauntlet Droit. There you will find challenges and helpful friends to start you on your way.";
        private const string String092A = "These two maps comprise the Gauntlet... A simple quest that you'd be wise to undertake before all else.";
        private const string String0992 = "Northward is the entrance to the Queen's Proving Grounds. You begin there in Her Majesty's Aqueduct.";
        private const string String09F7 = "That will start your ascent to greater challenges. Fare well wherever you fare.";
        private const string String0A47 = "The Queen is here:";
        private const string String0A5A = "'Loyal Champions! A magnificent achievement!";
        private const string String0A87 = "Now, as to the markings here at this secret entrance...";
        private const string String0ABF = "This will take you into the lowest depths!";
        private const string String0AEA = "Together, we will breach the gates of time and march into a new world of wonders! But only together.";
        private const string String0B4F = "Each of the vile deities whom the Night Elves worship wears a magical ring. You must get each ring from its owner!";
        private const string String0BC2 = "Together, the rings are the keys that will allow us to enter the Portal of Time. And then, loyal Champions, I know not where we shall step through into Immortality.";
        private const string String0C67 = "Go, now! I shall be with thee! I will come to thee when I can. Fare thee well!'";
        private const string String0CB7 = "Let us not dally...northward, onward to destiny.";
        private const string String0CE8 = "Your experience is not suited for the horrors through here. Seek thee more knowledge then return.";
        private const string String0D4A = "Only more experienced heroes may venture beyond this gateway. And even then, you must have completed the Queen's proving grounds and acquired Her key!";
        private const string String0DE1 = "A mystic portal appears, granting you an ingress to the chambers of time.";
        private const string String0E2B = "Go from here to the depths of time! Enter into the deepest wells of your destiny! This will take you to the start of Dissemination.";
        private const string String0EAF = "You must enter alone!";
        private const string String0EC5 = "A portal forms in the wall before you! Iridescent light filters into the room, surrounding you with a vapor of magic.";
        private const string String0F3B = "THIS portal will take you into the final challenge...your Fate is at hand.";
        private const string String0F86 = "In time, this ingress shall grant you passage; but only alone and after you've earned the right, may you proceed.";
        
        // === Functions ================================================
        private void FnEXIT_01(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String03FC); // This Gateway leads out of the Dungeon.
            L0010: ExitDungeon(player, isForwardMove);
            L0018: return; // RETURN;
        }

        private void FnTOCHALNG_02(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0423); // The door is marked: 'To Gauntlet Gauche.'
            L0010: TeleportParty(player, 0x01, 0x02, 0x7F, 0x00, isForwardMove);
            L002A: return; // RETURN;
        }

        private void FnTOEZQEST_03(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String044D); // Herein lies Gauntlet Droit.
            L0010: TeleportParty(player, 0x01, 0x03, 0x50, 0x02, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnTOUPRLVL_04(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0469); // To the first level of Her Majesty's proving grounds...The Queen's Aqueduct.
            L0010: TeleportParty(player, 0x02, 0x01, 0xF8, 0x03, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnTOMAPQST_05(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String04B5); // Enter the Kingdom of the Night Elves... 
            L0010: ShowMessage(player, String04DE); //                ....and beware.
            L001D: TeleportParty(player, 0x04, 0x01, 0xF0, 0x03, isForwardMove);
            L0038: return; // RETURN;
        }

        private void FnTODRAKS_06(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String04FD); // Here you enter the Dralkarians' Lair.
            L0010: TeleportParty(player, 0x08, 0x01, 0x70, 0x02, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnAXSTOLOW_07(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckLevel(player, 0x000C);
            L0011: if (JumpNotEqual) goto L0016;
            L0013: goto L00B7;
            L0016: Compare(PartyCount(player), 0x0001);
            L0021: if (JumpEqual) goto L0026;
            L0023: goto L00B7;
            L0026: Compare(GetFlag(player, 0x02, 0x00), 0x0001);
            L0039: if (JumpNotEqual) goto L004B;
            L003B: XCall 0x009E
            L0046: cx = PopStack(player);
            L0047: cx = PopStack(player);
            L0048: goto L00E1;
            L004B: PushStack(player, 0xEA);
            L004F: PushStack(player, ax);
015F  0050 C4 5E 06  les bx, [bp+0x6]
0162  0053 26 FF 5F 54  call far word [es:bx+0x54]
            L0057: cx = PopStack(player);
            L0058: cx = PopStack(player);
            L0059: RefreshCompareFlags(ax);
            L005B: if (JumpEqual) goto L00B2;
            L005D: ShowMessage(player, String0523); // As you unlock the door with Her Majesty's key, the lock on the door as well as the key vanish!
            L006A: ShowMessage(player, String0582); // Now the door will remain unlocked.
            L0077: SetFlag(player, 0x02, 0x00, 0x01);
            L008B: RemoveItem(player, 0xEA);
            L0097: RemoveItem(player, 0xE0);
01B2  00A3 FF 76 08  push word [bp+0x8]
01B5  00A6 FF 76 06  push word [bp+0x6]
01B8  00A9 0E     push cs
01B9  00AA E8 36 00  call 0xe3
            L00AD: // NOP
            L00AE: cx = PopStack(player);
            L00AF: cx = PopStack(player);
            L00B0: goto L00E1;
01C1  00B2 B8 A5 05  mov ax, 0x5a5
            L00B5: goto L00BA;
            L00B7: ShowMessage(player, String05D4); // Only more experienced heroes may venture beyond this gateway. And even then, you must enter alone!
            L00C4: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L00E1: return; // RETURN;
            // Extra data: 55 8B EC B8 37 06 50 C4 5E 06 26 FF 9F F8 00 59 B8 01 00 50 B8 02 00 50 C4 5E 06 26 FF 5F 20 50 C4 5E 06 26 FF 5F 2C 83 C4 06 5D CB 
        }

        private void FnAXSTODRK_08(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckLevel(player, 0x0017);
            L0011: if (JumpNotEqual) goto L0016;
            L0013: goto L00FA;
            L0016: Compare(PartyCount(player), 0x0001);
            L0021: if (JumpEqual) goto L0026;
            L0023: goto L00CE;
            L0026: Compare(GetFlag(player, 0x02, 0x01), 0x0001);
            L003A: if (JumpEqual) goto L0052;
            L003C: Compare(GetFlag(player, 0x02, 0x01), 0x0002);
            L0050: if (JumpNotEqual) goto L0060;
0270  0052 FF 76 08  push word [bp+0x8]
0273  0055 FF 76 06  push word [bp+0x6]
0276  0058 0E     push cs
0277  0059 E8 DC 00  call 0x138
            L005C: // NOP
            L005D: goto L0105;
            L0060: RefreshCompareFlags(GetFlag(player, 0x02, 0x01));
            L0073: if (JumpNotEqual) goto L00CC;
            L0075: ax = HasItem(player, 0xEB);
            L0083: if (JumpEqual) goto L00CC;
            L0085: ShowMessage(player, String0662); // Your map begins to glow with an eerie green light. The light then fades to red followed by blue and finally brilliant yellow.
            L0092: ShowMessage(player, String06E0); // The magical light of this most curious map dispels the door's magic!
            L009F: ShowMessage(player, String0725); // The map, drained of its powers, crumbles into the nothingness from which it came.
            L00AC: PushStack(player, 0x01);
            L00B0: PushStack(player, ax);
            L00B1: PushStack(player, 0x02);
02D3  00B5 C4 5E 06  les bx, [bp+0x6]
02D6  00B8 26 FF 1F  call far word [es:bx]
02D9  00BB 83 C4 06  add sp, 0x6
            L00BE: RemoveItem(player, 0xEB);
            L00CA: goto L0052;
            L00CC: goto L00FA;
            L00CE: ShowMessage(player, String0777); // You must journey northward alone!
            L00DB: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L00F8: goto L0107;
0318  00FA FF 76 08  push word [bp+0x8]
031B  00FD FF 76 06  push word [bp+0x6]
031E  0100 0E     push cs
031F  0101 E8 05 00  call 0x109
            L0104: // NOP
            L0105: cx = PopStack(player);
            L0106: cx = PopStack(player);
            L0107: return; // RETURN;
            // Extra data: 55 8B EC B8 99 07 50 C4 5E 06 26 FF 9F F8 00 59 33 C0 50 C4 5E 06 26 FF 5F 24 50 C4 5E 06 26 FF 5F 20 50 C4 5E 06 26 FF 5F 2C 83 C4 06 5D CB 55 8B EC B8 D5 07 50 C4 5E 06 26 FF 9F F8 00 59 B8 01 00 50 C4 5E 06 26 FF 5F 24 50 C4 5E 06 26 FF 5F 20 50 C4 5E 06 26 FF 5F 2C 83 C4 06 C4 5E 06 26 FF 5F 24 50 C4 5E 06 26 FF 5F 20 50 B8 01 00 50 C4 5E 06 26 FF 5F 30 83 C4 06 5D CB 
        }

        private void FnSTRIPEM_09(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0x71);
            L0011: if (JumpEqual) goto L0083;
            L0013: ax = GetFlag(player, 0x02, 0x39);
03C8  0024 F7 D8  neg ax
03CA  0026 1B C0  sbb ax, ax
03CC  0028 40     inc ax
03CD  0029 A9 04 00  test ax, 0x4
            L002C: if (JumpEqual) goto L0083;
03D2  002E B8 F9 07  mov ax, 0x7f9
            L0031: PushStack(player, ax);
03D6  0032 C4 5E 06  les bx, [bp+0x6]
03D9  0035 26 FF 9F F8 00  call far word [es:bx+0xf8]
            L003A: goto L0047;
            L003C: RemoveItem(player, 0x71);
            L0048: ax = HasItem(player, 0x71);
            L0056: if (JumpNotEqual) goto L003C;
            L0058: ModifyGold(player, 0xFFFFF0BA);
            L006A: DamagePlayer(player, GetMaxHits(player));
            L007B: ExitDungeon(player, isForwardMove);
            L0083: return; // RETURN;
        }

        private void FnYOURHERE_0A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0021: ShowMessage(player, String084F); // Welcome, brave Champions. To the west lies Gauntlet Gauche: one of the two maps that interweave a simple quest.
            L002E: ShowMessage(player, String08BF); // Eastward lies Gauntlet Droit. There you will find challenges and helpful friends to start you on your way.
            L003B: ShowMessage(player, String092A); // These two maps comprise the Gauntlet... A simple quest that you'd be wise to undertake before all else.
            L0048: return; // RETURN;
        }

        private void FnURHERE_0B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0021: ShowMessage(player, String0992); // Northward is the entrance to the Queen's Proving Grounds. You begin there in Her Majesty's Aqueduct.
            L002E: ShowMessage(player, String09F7); // That will start your ascent to greater challenges. Fare well wherever you fare.
            L003B: return; // RETURN;
        }

        private void FnNOJOIN_0C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetNoJoinArea(player);
            L000B: return; // RETURN;
        }

        private void FnQUEENY_0D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
04C0  0003 C4 5E 06  les bx, [bp+0x6]
04C3  0006 26 FF 5F 40  call far word [es:bx+0x40]
            L000A: ax = CheckLevel(player, 0x0017);
            L0018: if (JumpNotEqual) goto L001D;
            L001A: goto L00E6;
            L001D: Compare(GetFlag(player, 0x02, 0x01), 0x0001);
            L0031: if (JumpEqual) goto L0036;
            L0033: goto L00C2;
            L0036: ShowPortrait(player, 0x0015);
            L0043: ShowMessage(player, String0A47); // The Queen is here:
            L0050: ShowMessage(player, String0A5A); // 'Loyal Champions! A magnificent achievement!
            L005D: ShowMessage(player, String0A87); // Now, as to the markings here at this secret entrance...
            L006A: ShowMessage(player, String0ABF); // This will take you into the lowest depths!
            L0077: ShowMessage(player, String0AEA); // Together, we will breach the gates of time and march into a new world of wonders! But only together.
            L0084: ShowMessage(player, String0B4F); // Each of the vile deities whom the Night Elves worship wears a magical ring. You must get each ring from its owner!
            L0091: ShowMessage(player, String0BC2); // Together, the rings are the keys that will allow us to enter the Portal of Time. And then, loyal Champions, I know not where we shall step through into Immortality.
            L009E: ShowMessage(player, String0C67); // Go, now! I shall be with thee! I will come to thee when I can. Fare thee well!'
            L00AB: SetFlag(player, 0x02, 0x01, 0x02);
            L00C0: goto L010B;
            L00C2: RefreshCompareFlags(GetFlag(player, 0x02, 0x20));
            L00D5: if (JumpNotEqual) goto L010B;
            L00D7: ShowMessage(player, String0CB7); // Let us not dally...northward, onward to destiny.
            L00E4: goto L010B;
            L00E6: ShowMessage(player, String0CE8); // Your experience is not suited for the horrors through here. Seek thee more knowledge then return.
            L00F3: PushStack(player, 0x01);
            L00F7: PushStack(player, 0xCE);
            L00FB: PushStack(player, 0x01);
            L00FF: PushStack(player, ax);
05BD  0100 C4 5E 06  les bx, [bp+0x6]
05C0  0103 26 FF 9F BC 00  call far word [es:bx+0xbc]
05C5  0108 83 C4 08  add sp, 0x8
            L010B: return; // RETURN;
        }

        private void FnNOMAPS_0E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
05CD  0003 C4 5E 06  les bx, [bp+0x6]
05D0  0006 26 FF 9F E8 00  call far word [es:bx+0xe8]
            L000B: return; // RETURN;
        }

        private void FnSTOPHERE_0F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetNoJoinArea(player);
            L000B: RefreshCompareFlags(GetFlag(player, 0x02, 0x00));
            L001D: if (JumpNotEqual) goto L0044;
            L001F: ShowMessage(player, String0D4A); // Only more experienced heroes may venture beyond this gateway. And even then, you must have completed the Queen's proving grounds and acquired Her key!
            L002C: PushStack(player, 0x02);
            L0030: PushStack(player, 0xC8);
            L0034: PushStack(player, 0x01);
            L0038: PushStack(player, ax);
0610  0039 C4 5E 06  les bx, [bp+0x6]
0613  003C 26 FF 9F BC 00  call far word [es:bx+0xbc]
0618  0041 83 C4 08  add sp, 0x8
            L0044: return; // RETURN;
        }

        private void FnNOTHING_11(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x03);
            L0007: PushStack(player, 0x58);
            L000B: PushStack(player, 0x01);
            L000F: PushStack(player, ax);
0632  0010 C4 5E 06  les bx, [bp+0x6]
0635  0013 26 FF 9F BC 00  call far word [es:bx+0xbc]
063A  0018 83 C4 08  add sp, 0x8
            L001B: return; // RETURN;
        }

        private void FnTOTWELVE_12(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L007E;
            L0010: ax = CheckLevel(player, 0x0023);
            L001E: if (JumpEqual) goto L007E;
            L0020: Compare(GetFlag(player, 0x02, 0xDF), 0x0001);
            L0034: if (JumpEqual) goto L004C;
            L0036: Compare(GetFlag(player, 0x02, 0xDF), 0x0002);
            L004A: if (JumpNotEqual) goto L007C;
            L004C: SetWallObject(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L006A: ShowMessage(player, String0DE1); // A mystic portal appears, granting you an ingress to the chambers of time.
06B6  0077 B8 01 00  mov ax, 0x1
            L007A: goto L0099;
            L007C: goto L007E;
            L007E: SetWallObject(player, 0x00, 0x01, GetCurrentTile(player));
            L0097: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L00B4: return; // RETURN;
        }

        private void FnTODISSEM_13(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L0059;
            L0010: Compare(GetFlag(player, 0x02, 0xDF), 0x0001);
            L0024: if (JumpEqual) goto L003C;
            L0026: Compare(GetFlag(player, 0x02, 0xDF), 0x0002);
            L003A: if (JumpNotEqual) goto L007E;
            L003C: ShowMessage(player, String0E2B); // Go from here to the depths of time! Enter into the deepest wells of your destiny! This will take you to the start of Dissemination.
            L0049: PushStack(player, 0x00);
            L004C: PushStack(player, 0xFF);
            L0050: PushStack(player, 0x01);
0749  0054 B8 0C 00  mov ax, 0xc
            L0057: goto L0072;
            L0059: ShowMessage(player, String0EAF); // You must enter alone!
            L0066: PushStack(player, 0x03);
            L006A: PushStack(player, 0x13);
            L006E: PushStack(player, 0x01);
            L0072: PushStack(player, ax);
0768  0073 C4 5E 06  les bx, [bp+0x6]
076B  0076 26 FF 9F BC 00  call far word [es:bx+0xbc]
0770  007B 83 C4 08  add sp, 0x8
            L007E: return; // RETURN;
        }

        private void FnTOTHEEND_14(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L004F;
            L0010: ax = IsFlagOn(player, 0x02, 0xC2);
            L0023: if (JumpEqual) goto L0074;
            L0025: ShowMessage(player, String0EC5); // A portal forms in the wall before you! Iridescent light filters into the room, surrounding you with a vapor of magic.
            L0032: ShowMessage(player, String0F3B); // THIS portal will take you into the final challenge...your Fate is at hand.
            L003F: PushStack(player, 0x00);
            L0042: PushStack(player, 0xFF);
            L0046: PushStack(player, 0x02);
07BF  004A B8 0C 00  mov ax, 0xc
            L004D: goto L0068;
            L004F: ShowMessage(player, String0F86); // In time, this ingress shall grant you passage; but only alone and after you've earned the right, may you proceed.
            L005C: PushStack(player, 0x03);
            L0060: PushStack(player, 0x13);
            L0064: PushStack(player, 0x01);
            L0068: PushStack(player, ax);
07DE  0069 C4 5E 06  les bx, [bp+0x6]
07E1  006C 26 FF 9F BC 00  call far word [es:bx+0xbc]
07E6  0071 83 C4 08  add sp, 0x8
            L0074: return; // RETURN;
        }

    }
}
