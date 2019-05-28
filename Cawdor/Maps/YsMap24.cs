#pragma warning disable
using System.Collections.Generic;
using XPT.WorldData;
using XPT.WorldData.Yserbius;

namespace XPT.Scripts.Yserbius.Maps {
    class YserMap24 : AMapScripted {
        protected override int MapIndex => 24;
        protected override int RandomEncounterChance => 15;
        protected override int RandomEncounterExtraCount => 2;

        public YserMap24() {
            MapEvent02 = Fn_02;
            MapEvent04 = Fn_04;
            MapEvent06 = Fn_06;
            MapEvent07 = Fn_07;
            MapEvent08 = Fn_08;
            MapEvent09 = Fn_09;
            MapEvent0A = Fn_0A;
            MapEvent0B = Fn_0B;
            MapEvent0C = Fn_0C;
            MapEvent0D = Fn_0D;
            MapEvent0E = Fn_0E;
            MapEvent0F = Fn_0F;
            MapEvent10 = Fn_10;
            MapEvent11 = Fn_11;
            MapEvent12 = Fn_12;
            MapEvent13 = Fn_13;
            MapEvent14 = Fn_14;
            MapEvent15 = Fn_15;
            MapEvent16 = Fn_16;
            MapEvent17 = Fn_17;
            MapEvent18 = Fn_18;
            MapEvent19 = Fn_19;
            MapEvent1A = Fn_1A;
            MapEvent1B = Fn_1B;
            MapEvent1C = Fn_1C;
            MapEvent1D = Fn_1D;
            MapEvent1E = Fn_1E;
            MapEvent1F = Fn_1F;
            MapEvent20 = Fn_20;
            MapEvent21 = Fn_21;
            MapEvent22 = Fn_22;
            MapEvent23 = Fn_23;
            MapEvent24 = Fn_24;
            MapEvent25 = Fn_25;
            MapEvent26 = Fn_26;
            MapEvent27 = Fn_27;
            MapEvent28 = Fn_28;
            MapEvent29 = Fn_29;
            MapEvent2A = Fn_2A;
            MapEvent2B = Fn_2B;
            MapEvent2C = Fn_2C;
            MapEvent2D = Fn_2D;
            MapEvent2E = Fn_2E;
            MapEvent2F = Fn_2F;
            MapEvent30 = Fn_30;
            MapEvent31 = Fn_31;
            MapEvent32 = Fn_32;
        }
        
        // === Strings ================================================
        private const string String0140 = "You have unlocked the hidden door.";
        private const string String0163 = "You detect a hidden door, but it is locked.";
        private const string String018F = "Your lockpick is no more.  It has ceased to key.  It's a stick.  Bereft of heft, it rests in pieces.  This is an ex-lockpick.";
        private const string String020D = "You return to The Runed Room.";
        private const string String022B = "Out out, brief candle.  Light's but a making shadow; a poor photon, that glints and flashes its hour upon the gaze, and then is seen no more.";
        private const string String02B9 = "In other words, it got dark.";
        private const string String02D6 = "Your sputtering little candle provides barely enough illumination, but it won't last forever.";
        private const string String0334 = "It sure is dark down here.  There's no way you'll be able to spot an ambush or protect yourself fully while it's so dark.  In fact, yup, that hurt!";
        private const string String03C8 = "Darn useful items, these lanterns.  Getting one was a bright idea.";
        private const string String040B = "It sure is dark down here.";
        private const string String0426 = "Darn useful items, these lanterns.";
        private const string String0449 = "In fact, you deserve a reward for thinking of it.";
        private const string String047B = "This room is empty.  But you hear movement around you.";
        private const string String04B2 = "The boars have run away from the Prunes of Cawdor!";
        private const string String04E5 = "You have already cleaned out the sty.";
        private const string String050B = "The minotaurs have run away from the Prunes of Cawdor!";
        private const string String0542 = "You have already cleaned out the barn.";
        private const string String0569 = "The slimes have run away from the Prunes of Cawdor!";
        private const string String059D = "You have already cleaned out the drains.";
        private const string String05C6 = "The bats have run away from the Prunes of Cawdor!";
        private const string String05F8 = "You have already cleaned out the cave.";
        private const string String061F = "The medusa have run away from the Prunes of Cawdor!";
        private const string String0653 = "You have already cleaned out the pit.";
        private const string String0679 = "The brinded cats have run away from the Prunes of Cawdor!";
        private const string String06B3 = "You have already cleaned out the pride.";
        private const string String06DB = "The harpies have run away from the Prunes of Cawdor!";
        private const string String0710 = "You have already cleaned out the roost.";
        private const string String0738 = "The hell hounds have run away from the Prunes of Cawdor!";
        private const string String0771 = "You have already cleaned out the kennels.";
        private const string String079B = "The beasts have run from the Prunes of Cawdor.";
        private const string String07CA = "Isn't that a tasteful turn of phrase?";
        private const string String07F0 = "'Screw your courage to the sticking place and you'll not fail!  Avaunt!";
        private const string String0838 = "That was no way to treat a lady.  Then again, she wasn't much of a lady, was she?";
        private const string String088A = "This section of the bestiary is better lit with torches.";
        private const string String08C3 = "They may have left the door open, but they sure didn't leave it unguarded!";
        private const string String090E = "Those wyrms won't be dragon you into their petty squabbles again.";
        private const string String0950 = "I guess they are calling it the bestiary for a reason!";
        private const string String0987 = "Bowser won't be playing any more.  Heh heh.";
        private const string String09B3 = "You wouldn't have thought this corridor left enough room for harpies to fly.  But they're managing it!";
        private const string String0A1A = "You made sure that those bats won't ever get tangled in anyone's hair ever again.";
        private const string String0A6C = "Tchee!  You joined this quest for the glory and the greater good, but these guys seem you're just in it to rob them of their share of the treasure.  En garde!";
        private const string String0B0B = "Turns out that you did reduce their share of the treasure.  Serves them right for attacking you.";
        private const string String0B6C = "An old, quavering voice whispers from thin air.";
        private const string String0B9C = "'Well done, young questor.  Thou hast summoned me from afar to aid thee, as was foretold.  I will take thee to the beginning of the path thou must walk, bypassing many a beast and battle.'";
        private const string String0C59 = "'And a bit of advice.  Light is cheap, and life more cheaply ended for one who walks in darkness.  As my life was spent enlightening people, I suggest that thou dost visit the store ere returning to this dark and darksome place.'";
        private const string String0D3F = "'Now may fortune favor thee.'";
        private const string String0D5D = "You don't know which is worse: the slimy snakes, or the snaky slimes!";
        private const string String0DA3 = "You're not exactly sure what it was you faced here, but whatever it was, it was green.";
        private const string String0DFA = "A resonant voice speaks to you from thin air.";
        private const string String0E28 = "'I am Alfred, late the king of this land.  Hear me!  The Serpentine Crypt is a death trap, pure and simple.  I will now let you bypass some of its length.";
        private const string String0EC3 = "Help given once may yet be given again there, but thou shouldst neither expect nor seek it.  And I can advice thee in this small matter: Cassandra is the mightiest of the Wyrd Sisters.  Thou shouldst focus thy efforts on her first.  Good luck!'";
        private const string String0FB8 = "The door refuses to budge.  You feel a mystical link between this door and some entity near here, one you have not yet defeated.";
        private const string String1039 = "Rory's body remains imbedded in the ceiling, a grim reminder of what must be faced down here.";
        private const string String1097 = "Something up above catches your eye.  You look up, and see your old friend Rory Applebush, the cheerful halfling you half expected to find juggling the Wyrd Sisters's eyeteeth, imbedded in the ceiling.";
        private const string String1161 = "The stone has melted, sealing him in, unretrievable.  He died in agony.  Nobody said this quest would be easy.  Nobody said it would be this hard, either.";
        private const string String11FC = "'Turn back!  No quest is worth the risk of facing what Rory faced.  Merciful heavens, but thou must turn back.'  He rushes up the stairs.";
        private const string String1286 = "'Drat this place!  This infernal blackness forced me to use my candle, which did not last long.  A hundred curses upon the darkness!'";
        private const string String130C = "'I have learned something of the bestiary.  It is my secret, but I will tell thee this much.  The Wyrd Sisters do breed the beasts in lairs.  Seal the lairs and thou need not face the beasts.'";
        private const string String13CD = "'There is a path that includes the cats and the pigs off to the West.  It involves doubling back, thou, and I've not completed it nor seen where a harpier might be found.  Yet!'";
        private const string String147F = "'The end of the path lies three rooms to the west of where we must enter the maze!  I will try backtracking!'";
        private const string String14ED = "'The prophecy about Aldhelm is true!  I need not face Rory's unyielding gaze as I enter this room, but I must always face it on the way out, alas.";
        private const string String1580 = "'Alcuin spoke to me!  I now know the path!  I refer thee to the Library, to Astrologia, an thou dost not yet know the way to find her Ladyship.";
        private const string String1610 = "'I seek a way to free Rory's corpse.  At the least he deserves a decent burial.  But the dragon's flames were hot enough to melt the very stone.  I know not what Rory said, but it must have infuriated the wyrm!'";
        
        // === Functions ================================================
        private void Fn_02(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, 0x0D), 0x000B);
            L0012: if (JumpAbove) goto L003B;
            L0014: RefreshCompareFlags(HasUsedSpell(player, 0x17));
            L0022: if (JumpNotEqual) goto L003B;
            L0024: ax = IsFlagOn(player, 0x00, 0x01);
            L0036: if (JumpNotEqual) goto L003B;
            L0038: goto L0173;
            L003B: SetWallObject(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L0059: PushStack(player, 0x01);
            L005D: PushStack(player, ax);
            L005E: PushStack(player, 0x00);
006A  0061 C4 5E 06  les bx, [bp+0x6]
006D  0064 26 FF 1F  call far word [es:bx]
0070  0067 83 C4 06  add sp, 0x6
            L006A: Compare(HasUsedSkill(player, 0x0E), 0x000B);
            L0079: if (JumpBelowOrEqual) goto L009B;
            L007B: ax = HasItem(player, 0xDC);
            L0089: if (JumpNotEqual) goto L00C1;
            L008B: ax = HasItem(player, 0xDD);
            L0099: if (JumpNotEqual) goto L00C1;
            L009B: Compare(GetSkillLevel(player, 0x0E), 0x000B);
            L00AA: if (JumpBelowOrEqual) goto L00D4;
            L00AC: ax = HasUsedItem(player, 0xDC, 0xDD);
            L00BF: if (JumpEqual) goto L00D4;
            L00C1: ShowMessage(player, String0140); // You have unlocked the hidden door.
00D7  00CE B8 01 00  mov ax, 0x1
            L00D1: goto L0175;
            L00D4: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L00F1: ShowMessage(player, String0163); // You detect a hidden door, but it is locked.
            L00FE: ax = HasUsedItem(player, 0xC1, 0xC3);
            L0111: if (JumpNotEqual) goto L0128;
            L0113: ax = HasUsedItem(player, 0xDA, 0xDB);
            L0126: if (JumpEqual) goto L0190;
            L0128: RemoveItem(player, 0xC1);
            L0134: RemoveItem(player, 0xC2);
            L0140: RemoveItem(player, 0xC3);
            L014C: RemoveItem(player, 0xDA);
            L0158: RemoveItem(player, 0xDB);
            L0164: ShowMessage(player, String018F); // Your lockpick is no more.  It has ceased to key.  It's a stick.  Bereft of heft, it rests in pieces.  This is an ex-lockpick.
            L0171: goto L0190;
            L0173: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0190: return; // RETURN;
        }

        private void Fn_04(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String020D); // You return to The Runed Room.
            L0010: TeleportParty(player, 0x01, 0x02, 0x9F, 0x00, isForwardMove);
            L002A: return; // RETURN;
        }

        private void Fn_06(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: return; // RETURN;
            // Extra data: 55 8B EC 56 B8 A3 00 50 C4 5E 06 26 FF 5F 50 59 0B C0 74 03 E9 AB 00 B8 C8 00 50 C4 5E 06 26 FF 5F 50 59 0B C0 74 78 B8 44 00 50 B8 02 00 50 C4 5E 06 26 FF 5F 04 59 59 8B F0 46 83 FE 0A 7E 3D 33 C0 50 B8 44 00 50 B8 02 00 50 C4 5E 06 26 FF 1F 83 C4 06 B8 C8 00 50 C4 5E 06 26 FF 5F 4C 59 B8 2B 02 50 C4 5E 06 26 FF 9F F8 00 59 B8 B9 02 50 C4 5E 06 26 FF 9F F8 00 59 E9 B8 00 B8 D6 02 50 C4 5E 06 26 FF 9F F8 00 59 56 B8 44 00 50 B8 02 00 50 C4 5E 06 26 FF 1F 83 C4 06 E9 96 00 C4 5E 06 26 FF 9F E8 00 B8 34 03 50 C4 5E 06 26 FF 9F F8 00 59 B8 F4 01 50 C4 5E 06 26 FF 9F 90 00 EB B7 B8 19 00 50 B8 03 00 50 C4 5E 06 26 FF 5F 04 59 59 0B C0 75 22 B8 C8 03 50 C4 5E 06 26 FF 9F F8 00 59 B8 01 00 50 B8 19 00 50 B8 03 00 50 C4 5E 06 26 FF 1F 83 C4 06 B8 45 00 50 B8 02 00 50 C4 5E 06 26 FF 5F 04 59 59 0B C0 75 27 B8 01 00 50 B8 45 00 50 B8 02 00 50 C4 5E 06 26 FF 1F 83 C4 06 B8 09 00 BA C0 27 50 52 C4 5E 06 26 FF 9F 98 00 59 59 B8 E2 00 50 50 C4 5E 06 26 FF 5F 54 59 59 0B C0 74 05 B8 01 00 EB 02 33 C0 50 B8 17 00 50 B8 03 00 50 C4 5E 06 26 FF 1F 83 C4 06 5E 5D CB 
        }

        private void Fn_07(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
033C  0003 FF 76 08  push word [bp+0x8]
033F  0006 FF 76 06  push word [bp+0x6]
0342  0009 0E     push cs
0343  000A E8 90 FE  call 0xfe9d
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: return; // RETURN;
        }

        private void Fn_08(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: ax = HasItem(player, 0xA3);
            L0012: if (JumpEqual) goto L0017;
            L0014: goto L00A2;
            L0017: ax = HasItem(player, 0xC8);
            L0025: if (JumpEqual) goto L0095;
            L0027: si = GetFlag(player, 0x02, 0x44);
            L003A: si = si + 1;
            L003B: Compare(si, 0x0A);
            L003E: if (JumpLessOrEqual) goto L0073;
            L0040: SetFlag(player, 0x02, 0x44, 0x00);
            L0054: RemoveItem(player, 0xC8);
            L0060: ShowMessage(player, String022B); // Out out, brief candle.  Light's but a making shadow; a poor photon, that glints and flashes its hour upon the gaze, and then is seen no more.
03B7  006D B8 B9 02  mov ax, 0x2b9
            L0070: goto L0118;
            L0073: ShowMessage(player, String02D6); // Your sputtering little candle provides barely enough illumination, but it won't last forever.
            L0080: SetFlag(player, 0xC4, 0xB8, si);
            L0092: goto L0122;
03DF  0095 C4 5E 06  les bx, [bp+0x6]
03E2  0098 26 FF 9F E8 00  call far word [es:bx+0xe8]
03E7  009D B8 0B 04  mov ax, 0x40b
            L00A0: goto L0118;
            L00A2: RefreshCompareFlags(GetFlag(player, 0x03, 0x19));
            L00B5: if (JumpNotEqual) goto L00D9;
            L00B7: ShowMessage(player, String0426); // Darn useful items, these lanterns.
            L00C4: SetFlag(player, 0x03, 0x19, 0x01);
            L00D9: RefreshCompareFlags(GetFlag(player, 0x02, 0x45));
            L00EC: if (JumpNotEqual) goto L0122;
            L00EE: SetFlag(player, 0x02, 0x45, 0x01);
            L0103: AddExperience(player, 0x000927C0);
            L0115: ShowMessage(player, String0449); // In fact, you deserve a reward for thinking of it.
            L0122: return; // RETURN (restoring si);
            // Extra data: 55 8B EC B8 7B 04 50 C4 5E 06 26 FF 9F F8 00 59 B8 01 00 50 B8 02 00 50 33 C0 50 C4 5E 06 26 FF 1F 83 C4 06 5D CB 
        }

        private void Fn_09(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0498  0003 FF 76 08  push word [bp+0x8]
049B  0006 FF 76 06  push word [bp+0x6]
049E  0009 0E     push cs
049F  000A E8 34 FD  call 0xfd41
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: Compare(GetFlag(player, 0x02, 0x57), 0x00D5);
            L0023: if (JumpNotEqual) goto L002A;
04BA  0025 B8 D4 00  mov ax, 0xd4
            L0028: goto L002C;
            L002A: SetFlag(player, 0x02, 0x57, 0x00);
            L003E: RefreshCompareFlags(GetFlag(player, 0x03, 0x14));
            L0051: if (JumpEqual) goto L0056;
            L0053: goto L010D;
            L0056: SetFlag(player, 0x03, 0x14, 0x01);
            L006B: PushStack(player, 0x64);
            L006F: PushStack(player, 0x00);
            L0072: PushStack(player, ax);
            L0073: PushStack(player, ax);
            L0074: PushStack(player, 0xCD);
            L0078: PushStack(player, 0xBA);
0511  007C C4 5E 06  les bx, [bp+0x6]
0514  007F 26 FF 9F D8 00  call far word [es:bx+0xd8]
0519  0084 83 C4 0C  add sp, 0xc
            L0087: AddEncounter(player, 0x05, 0x23);
            L0099: AddEncounter(player, 0x01, 0x11);
            L00AB: Compare(PartyCount(player), 0x0002);
            L00B6: if (JumpBelowOrEqual) goto L00DC;
            L00B8: AddEncounter(player, 0x02, 0x11);
            L00CA: AddEncounter(player, 0x06, 0x23);
            L00DC: Compare(PartyCount(player), 0x0003);
            L00E7: if (JumpBelowOrEqual) goto L0119;
            L00E9: AddEncounter(player, 0x03, 0x24);
            L00FB: PushStack(player, 0x24);
            L00FF: PushStack(player, 0x04);
0598  0103 C4 5E 06  les bx, [bp+0x6]
059B  0106 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L010B: goto L0117;
05A2  010D FF 76 08  push word [bp+0x8]
05A5  0110 FF 76 06  push word [bp+0x6]
05A8  0113 0E     push cs
05A9  0114 E8 C3 FE  call 0xffda
            L0117: cx = PopStack(player);
            L0118: cx = PopStack(player);
            L0119: return; // RETURN;
        }

        private void Fn_0A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
05B3  0003 FF 76 08  push word [bp+0x8]
05B6  0006 FF 76 06  push word [bp+0x6]
05B9  0009 0E     push cs
05BA  000A E8 19 FC  call 0xfc26
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: Compare(GetFlag(player, 0x02, 0x57), 0x00B8);
            L0023: if (JumpNotEqual) goto L002A;
05D5  0025 B8 B7 00  mov ax, 0xb7
            L0028: goto L002C;
            L002A: SetFlag(player, 0x02, 0x57, 0x00);
            L003E: RefreshCompareFlags(GetFlag(player, 0x03, 0x11));
            L0051: if (JumpEqual) goto L0056;
            L0053: goto L00E1;
0606  0056 B8 90 01  mov ax, 0x190
            L0059: PushStack(player, ax);
            L005A: PushStack(player, 0x00);
            L005D: PushStack(player, ax);
            L005E: PushStack(player, ax);
            L005F: PushStack(player, 0xCE);
            L0063: PushStack(player, 0xBB);
0617  0067 C4 5E 06  les bx, [bp+0x6]
061A  006A 26 FF 9F D8 00  call far word [es:bx+0xd8]
061F  006F 83 C4 0C  add sp, 0xc
            L0072: AddEncounter(player, 0x01, 0x1A);
            L0084: Compare(PartyCount(player), 0x0001);
            L008F: if (JumpBelowOrEqual) goto L00A3;
            L0091: AddEncounter(player, 0x02, 0x19);
            L00A3: Compare(PartyCount(player), 0x0002);
            L00AE: if (JumpBelowOrEqual) goto L00C2;
            L00B0: AddEncounter(player, 0x03, 0x19);
            L00C2: Compare(PartyCount(player), 0x0003);
            L00CD: if (JumpBelowOrEqual) goto L00ED;
            L00CF: PushStack(player, 0x1A);
            L00D3: PushStack(player, 0x04);
0687  00D7 C4 5E 06  les bx, [bp+0x6]
068A  00DA 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L00DF: goto L00EB;
0691  00E1 FF 76 08  push word [bp+0x8]
0694  00E4 FF 76 06  push word [bp+0x6]
0697  00E7 0E     push cs
0698  00E8 E8 D4 FD  call 0xfebf
            L00EB: cx = PopStack(player);
            L00EC: cx = PopStack(player);
            L00ED: return; // RETURN;
        }

        private void Fn_0B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
06A2  0003 FF 76 08  push word [bp+0x8]
06A5  0006 FF 76 06  push word [bp+0x6]
06A8  0009 0E     push cs
06A9  000A E8 2A FB  call 0xfb37
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: Compare(GetFlag(player, 0x02, 0x57), 0x00B7);
            L0023: if (JumpNotEqual) goto L002A;
06C4  0025 B8 A7 00  mov ax, 0xa7
            L0028: goto L002C;
            L002A: SetFlag(player, 0x02, 0x57, 0x00);
            L003E: RefreshCompareFlags(GetFlag(player, 0x03, 0x11));
            L0051: if (JumpEqual) goto L0056;
            L0053: goto L00E1;
06F5  0056 B8 90 01  mov ax, 0x190
            L0059: PushStack(player, ax);
            L005A: PushStack(player, 0x00);
            L005D: PushStack(player, ax);
            L005E: PushStack(player, ax);
            L005F: PushStack(player, 0xCE);
            L0063: PushStack(player, 0xBB);
0706  0067 C4 5E 06  les bx, [bp+0x6]
0709  006A 26 FF 9F D8 00  call far word [es:bx+0xd8]
070E  006F 83 C4 0C  add sp, 0xc
            L0072: AddEncounter(player, 0x01, 0x1A);
            L0084: Compare(PartyCount(player), 0x0001);
            L008F: if (JumpBelowOrEqual) goto L00A3;
            L0091: AddEncounter(player, 0x02, 0x19);
            L00A3: Compare(PartyCount(player), 0x0002);
            L00AE: if (JumpBelowOrEqual) goto L00C2;
            L00B0: AddEncounter(player, 0x03, 0x19);
            L00C2: Compare(PartyCount(player), 0x0003);
            L00CD: if (JumpBelowOrEqual) goto L00ED;
            L00CF: PushStack(player, 0x1A);
            L00D3: PushStack(player, 0x04);
0776  00D7 C4 5E 06  les bx, [bp+0x6]
0779  00DA 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L00DF: goto L00EB;
0780  00E1 FF 76 08  push word [bp+0x8]
0783  00E4 FF 76 06  push word [bp+0x6]
0786  00E7 0E     push cs
0787  00E8 E8 E5 FC  call 0xfdd0
            L00EB: cx = PopStack(player);
            L00EC: cx = PopStack(player);
            L00ED: return; // RETURN;
        }

        private void Fn_0C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0791  0003 FF 76 08  push word [bp+0x8]
0794  0006 FF 76 06  push word [bp+0x6]
0797  0009 0E     push cs
0798  000A E8 3B FA  call 0xfa48
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: Compare(GetFlag(player, 0x02, 0x57), 0x00A7);
            L0023: if (JumpNotEqual) goto L002A;
07B3  0025 B8 A6 00  mov ax, 0xa6
            L0028: goto L002C;
            L002A: SetFlag(player, 0x02, 0x57, 0x00);
            L003E: RefreshCompareFlags(GetFlag(player, 0x03, 0x11));
            L0051: if (JumpEqual) goto L0056;
            L0053: goto L00E1;
07E4  0056 B8 90 01  mov ax, 0x190
            L0059: PushStack(player, ax);
            L005A: PushStack(player, 0x00);
            L005D: PushStack(player, ax);
            L005E: PushStack(player, ax);
            L005F: PushStack(player, 0xCE);
            L0063: PushStack(player, 0xBB);
07F5  0067 C4 5E 06  les bx, [bp+0x6]
07F8  006A 26 FF 9F D8 00  call far word [es:bx+0xd8]
07FD  006F 83 C4 0C  add sp, 0xc
            L0072: AddEncounter(player, 0x01, 0x1A);
            L0084: Compare(PartyCount(player), 0x0001);
            L008F: if (JumpBelowOrEqual) goto L00A3;
            L0091: AddEncounter(player, 0x02, 0x19);
            L00A3: Compare(PartyCount(player), 0x0002);
            L00AE: if (JumpBelowOrEqual) goto L00C2;
            L00B0: AddEncounter(player, 0x03, 0x19);
            L00C2: Compare(PartyCount(player), 0x0003);
            L00CD: if (JumpBelowOrEqual) goto L00ED;
            L00CF: PushStack(player, 0x1A);
            L00D3: PushStack(player, 0x04);
0865  00D7 C4 5E 06  les bx, [bp+0x6]
0868  00DA 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L00DF: goto L00EB;
086F  00E1 FF 76 08  push word [bp+0x8]
0872  00E4 FF 76 06  push word [bp+0x6]
0875  00E7 0E     push cs
0876  00E8 E8 F6 FB  call 0xfce1
            L00EB: cx = PopStack(player);
            L00EC: cx = PopStack(player);
            L00ED: return; // RETURN;
        }

        private void Fn_0D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0880  0003 FF 76 08  push word [bp+0x8]
0883  0006 FF 76 06  push word [bp+0x6]
0886  0009 0E     push cs
0887  000A E8 4C F9  call 0xf959
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: Compare(GetFlag(player, 0x02, 0x57), 0x00A6);
            L0023: if (JumpNotEqual) goto L002A;
08A2  0025 B8 A5 00  mov ax, 0xa5
            L0028: goto L002C;
            L002A: SetFlag(player, 0x02, 0x57, 0x00);
            L003E: RefreshCompareFlags(GetFlag(player, 0x03, 0x0F));
            L0051: if (JumpEqual) goto L0056;
            L0053: goto L00E1;
08D3  0056 B8 90 01  mov ax, 0x190
            L0059: PushStack(player, ax);
            L005A: PushStack(player, 0x00);
            L005D: PushStack(player, ax);
            L005E: PushStack(player, ax);
            L005F: PushStack(player, 0xCE);
            L0063: PushStack(player, 0xBB);
08E4  0067 C4 5E 06  les bx, [bp+0x6]
08E7  006A 26 FF 9F D8 00  call far word [es:bx+0xd8]
08EC  006F 83 C4 0C  add sp, 0xc
            L0072: AddEncounter(player, 0x01, 0x1D);
            L0084: Compare(PartyCount(player), 0x0001);
            L008F: if (JumpBelowOrEqual) goto L00A3;
            L0091: AddEncounter(player, 0x02, 0x1E);
            L00A3: Compare(PartyCount(player), 0x0002);
            L00AE: if (JumpBelowOrEqual) goto L00C2;
            L00B0: AddEncounter(player, 0x03, 0x1D);
            L00C2: Compare(PartyCount(player), 0x0003);
            L00CD: if (JumpBelowOrEqual) goto L00ED;
            L00CF: PushStack(player, 0x1E);
            L00D3: PushStack(player, 0x04);
0954  00D7 C4 5E 06  les bx, [bp+0x6]
0957  00DA 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L00DF: goto L00EB;
095E  00E1 FF 76 08  push word [bp+0x8]
0961  00E4 FF 76 06  push word [bp+0x6]
0964  00E7 0E     push cs
0965  00E8 E8 07 FB  call 0xfbf2
            L00EB: cx = PopStack(player);
            L00EC: cx = PopStack(player);
            L00ED: return; // RETURN;
        }

        private void Fn_0E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
096F  0003 FF 76 08  push word [bp+0x8]
0972  0006 FF 76 06  push word [bp+0x6]
0975  0009 0E     push cs
0976  000A E8 5D F8  call 0xf86a
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: Compare(GetFlag(player, 0x02, 0x57), 0x00A5);
            L0023: if (JumpNotEqual) goto L002A;
0991  0025 B8 B5 00  mov ax, 0xb5
            L0028: goto L002C;
            L002A: SetFlag(player, 0x02, 0x57, 0x00);
            L003E: RefreshCompareFlags(GetFlag(player, 0x03, 0x0F));
            L0051: if (JumpEqual) goto L0056;
            L0053: goto L00E1;
09C2  0056 B8 90 01  mov ax, 0x190
            L0059: PushStack(player, ax);
            L005A: PushStack(player, 0x00);
            L005D: PushStack(player, ax);
            L005E: PushStack(player, ax);
            L005F: PushStack(player, 0xCE);
            L0063: PushStack(player, 0xBB);
09D3  0067 C4 5E 06  les bx, [bp+0x6]
09D6  006A 26 FF 9F D8 00  call far word [es:bx+0xd8]
09DB  006F 83 C4 0C  add sp, 0xc
            L0072: AddEncounter(player, 0x01, 0x1D);
            L0084: Compare(PartyCount(player), 0x0001);
            L008F: if (JumpBelowOrEqual) goto L00A3;
            L0091: AddEncounter(player, 0x02, 0x1E);
            L00A3: Compare(PartyCount(player), 0x0002);
            L00AE: if (JumpBelowOrEqual) goto L00C2;
            L00B0: AddEncounter(player, 0x03, 0x1D);
            L00C2: Compare(PartyCount(player), 0x0003);
            L00CD: if (JumpBelowOrEqual) goto L00ED;
            L00CF: PushStack(player, 0x1E);
            L00D3: PushStack(player, 0x04);
0A43  00D7 C4 5E 06  les bx, [bp+0x6]
0A46  00DA 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L00DF: goto L00EB;
0A4D  00E1 FF 76 08  push word [bp+0x8]
0A50  00E4 FF 76 06  push word [bp+0x6]
0A53  00E7 0E     push cs
0A54  00E8 E8 18 FA  call 0xfb03
            L00EB: cx = PopStack(player);
            L00EC: cx = PopStack(player);
            L00ED: return; // RETURN;
        }

        private void Fn_0F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0A5E  0003 FF 76 08  push word [bp+0x8]
0A61  0006 FF 76 06  push word [bp+0x6]
0A64  0009 0E     push cs
0A65  000A E8 6E F7  call 0xf77b
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: Compare(GetFlag(player, 0x02, 0x57), 0x00B5);
            L0023: if (JumpNotEqual) goto L002A;
0A80  0025 B8 C5 00  mov ax, 0xc5
            L0028: goto L002C;
            L002A: SetFlag(player, 0x02, 0x57, 0x00);
            L003E: RefreshCompareFlags(GetFlag(player, 0x03, 0x0F));
            L0051: if (JumpEqual) goto L0056;
            L0053: goto L00E1;
0AB1  0056 B8 90 01  mov ax, 0x190
            L0059: PushStack(player, ax);
            L005A: PushStack(player, 0x00);
            L005D: PushStack(player, ax);
            L005E: PushStack(player, ax);
            L005F: PushStack(player, 0xCE);
            L0063: PushStack(player, 0xBB);
0AC2  0067 C4 5E 06  les bx, [bp+0x6]
0AC5  006A 26 FF 9F D8 00  call far word [es:bx+0xd8]
0ACA  006F 83 C4 0C  add sp, 0xc
            L0072: AddEncounter(player, 0x01, 0x1D);
            L0084: Compare(PartyCount(player), 0x0001);
            L008F: if (JumpBelowOrEqual) goto L00A3;
            L0091: AddEncounter(player, 0x02, 0x1E);
            L00A3: Compare(PartyCount(player), 0x0002);
            L00AE: if (JumpBelowOrEqual) goto L00C2;
            L00B0: AddEncounter(player, 0x03, 0x1D);
            L00C2: Compare(PartyCount(player), 0x0003);
            L00CD: if (JumpBelowOrEqual) goto L00ED;
            L00CF: PushStack(player, 0x1E);
            L00D3: PushStack(player, 0x04);
0B32  00D7 C4 5E 06  les bx, [bp+0x6]
0B35  00DA 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L00DF: goto L00EB;
0B3C  00E1 FF 76 08  push word [bp+0x8]
0B3F  00E4 FF 76 06  push word [bp+0x6]
0B42  00E7 0E     push cs
0B43  00E8 E8 29 F9  call 0xfa14
            L00EB: cx = PopStack(player);
            L00EC: cx = PopStack(player);
            L00ED: return; // RETURN;
        }

        private void Fn_10(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0B4D  0003 FF 76 08  push word [bp+0x8]
0B50  0006 FF 76 06  push word [bp+0x6]
0B53  0009 0E     push cs
0B54  000A E8 7F F6  call 0xf68c
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: Compare(GetFlag(player, 0x02, 0x57), 0x00C5);
            L0023: if (JumpNotEqual) goto L002A;
0B6F  0025 B8 D5 00  mov ax, 0xd5
            L0028: goto L002C;
            L002A: SetFlag(player, 0x02, 0x57, 0x00);
            L003E: RefreshCompareFlags(GetFlag(player, 0x03, 0x0F));
            L0051: if (JumpEqual) goto L0056;
            L0053: goto L00E1;
0BA0  0056 B8 90 01  mov ax, 0x190
            L0059: PushStack(player, ax);
            L005A: PushStack(player, 0x00);
            L005D: PushStack(player, ax);
            L005E: PushStack(player, ax);
            L005F: PushStack(player, 0xCE);
            L0063: PushStack(player, 0xBB);
0BB1  0067 C4 5E 06  les bx, [bp+0x6]
0BB4  006A 26 FF 9F D8 00  call far word [es:bx+0xd8]
0BB9  006F 83 C4 0C  add sp, 0xc
            L0072: AddEncounter(player, 0x01, 0x1D);
            L0084: Compare(PartyCount(player), 0x0001);
            L008F: if (JumpBelowOrEqual) goto L00A3;
            L0091: AddEncounter(player, 0x02, 0x1E);
            L00A3: Compare(PartyCount(player), 0x0002);
            L00AE: if (JumpBelowOrEqual) goto L00C2;
            L00B0: AddEncounter(player, 0x03, 0x1D);
            L00C2: Compare(PartyCount(player), 0x0003);
            L00CD: if (JumpBelowOrEqual) goto L00ED;
            L00CF: PushStack(player, 0x1E);
            L00D3: PushStack(player, 0x04);
0C21  00D7 C4 5E 06  les bx, [bp+0x6]
0C24  00DA 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L00DF: goto L00EB;
0C2B  00E1 FF 76 08  push word [bp+0x8]
0C2E  00E4 FF 76 06  push word [bp+0x6]
0C31  00E7 0E     push cs
0C32  00E8 E8 3A F8  call 0xf925
            L00EB: cx = PopStack(player);
            L00EC: cx = PopStack(player);
            L00ED: return; // RETURN;
        }

        private void Fn_11(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0C3C  0003 FF 76 08  push word [bp+0x8]
0C3F  0006 FF 76 06  push word [bp+0x6]
0C42  0009 0E     push cs
0C43  000A E8 90 F5  call 0xf59d
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: Compare(GetFlag(player, 0x02, 0x57), 0x00D4);
            L0023: if (JumpEqual) goto L003B;
            L0025: Compare(GetFlag(player, 0x02, 0x46), 0x0001);
            L0039: if (JumpNotEqual) goto L00A3;
            L003B: ax = HasItem(player, 0xE7);
            L0049: if (JumpEqual) goto L0068;
            L004B: TeleportParty(player, 0x0A, 0x02, 0xE4, 0x01, isForwardMove);
            L0066: goto L00D4;
            L0068: ax = CheckLevel(player, 0x0046);
            L0076: if (JumpEqual) goto L0081;
            L0078: PushStack(player, 0x02);
0CB5  007C B8 E7 00  mov ax, 0xe7
            L007F: goto L0052;
            L0081: ax = CheckLevel(player, 0x0032);
            L008F: if (JumpEqual) goto L009A;
            L0091: PushStack(player, 0x02);
0CCE  0095 B8 E6 00  mov ax, 0xe6
            L0098: goto L0052;
            L009A: PushStack(player, 0x02);
0CD7  009E B8 E5 00  mov ax, 0xe5
            L00A1: goto L0052;
            L00A3: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L00C0: SetFlag(player, 0x02, 0x57, 0x00);
            L00D4: return; // RETURN;
        }

        private void Fn_12(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0001);
            L0010: PushStack(player, 0x02);
            L0014: PushStack(player, 0x00);
0D26  0017 C4 5E 06  les bx, [bp+0x6]
0D29  001A 26 FF 5F 04  call far word [es:bx+0x4]
            L001E: cx = PopStack(player);
            L001F: cx = PopStack(player);
            L0020: Compare(ax, 0x0001);
            L0023: if (JumpNotEqual) goto L003A;
            L0025: SetFlag(player, 0x03, 0x0E, 0x01);
            L003A: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0058: return; // RETURN;
        }

        private void Fn_13(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0002);
            L0010: PushStack(player, 0x02);
            L0014: PushStack(player, 0x00);
0D80  0017 C4 5E 06  les bx, [bp+0x6]
0D83  001A 26 FF 5F 04  call far word [es:bx+0x4]
            L001E: cx = PopStack(player);
            L001F: cx = PopStack(player);
            L0020: Compare(ax, 0x0001);
            L0023: if (JumpNotEqual) goto L003A;
            L0025: SetFlag(player, 0x03, 0x0E, 0x02);
            L003A: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0058: return; // RETURN;
        }

        private void Fn_14(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0005);
            L0010: PushStack(player, 0x02);
            L0014: PushStack(player, 0x00);
0DDA  0017 C4 5E 06  les bx, [bp+0x6]
0DDD  001A 26 FF 5F 04  call far word [es:bx+0x4]
            L001E: cx = PopStack(player);
            L001F: cx = PopStack(player);
            L0020: Compare(ax, 0x0001);
            L0023: if (JumpNotEqual) goto L003A;
            L0025: SetFlag(player, 0x03, 0x0E, 0x05);
            L003A: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0058: return; // RETURN;
        }

        private void Fn_15(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x000D);
            L0010: PushStack(player, 0x02);
            L0014: PushStack(player, 0x00);
0E34  0017 C4 5E 06  les bx, [bp+0x6]
0E37  001A 26 FF 5F 04  call far word [es:bx+0x4]
            L001E: cx = PopStack(player);
            L001F: cx = PopStack(player);
            L0020: Compare(ax, 0x0001);
            L0023: if (JumpNotEqual) goto L003A;
            L0025: SetFlag(player, 0x03, 0x0E, 0x0D);
            L003A: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0058: return; // RETURN;
        }

        private void Fn_16(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0010);
            L0010: PushStack(player, 0x02);
            L0014: PushStack(player, 0x00);
0E8E  0017 C4 5E 06  les bx, [bp+0x6]
0E91  001A 26 FF 5F 04  call far word [es:bx+0x4]
            L001E: cx = PopStack(player);
            L001F: cx = PopStack(player);
            L0020: Compare(ax, 0x0001);
            L0023: if (JumpNotEqual) goto L003A;
            L0025: SetFlag(player, 0x03, 0x0E, 0x10);
            L003A: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0058: return; // RETURN;
        }

        private void Fn_17(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x000F);
            L0010: PushStack(player, 0x02);
            L0014: PushStack(player, 0x00);
0EE8  0017 C4 5E 06  les bx, [bp+0x6]
0EEB  001A 26 FF 5F 04  call far word [es:bx+0x4]
            L001E: cx = PopStack(player);
            L001F: cx = PopStack(player);
            L0020: Compare(ax, 0x0001);
            L0023: if (JumpNotEqual) goto L003A;
            L0025: SetFlag(player, 0x03, 0x0E, 0x0F);
            L003A: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0058: return; // RETURN;
        }

        private void Fn_18(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0006);
            L0010: PushStack(player, 0x02);
            L0014: PushStack(player, 0x00);
0F42  0017 C4 5E 06  les bx, [bp+0x6]
0F45  001A 26 FF 5F 04  call far word [es:bx+0x4]
            L001E: cx = PopStack(player);
            L001F: cx = PopStack(player);
            L0020: Compare(ax, 0x0001);
            L0023: if (JumpNotEqual) goto L003A;
            L0025: SetFlag(player, 0x03, 0x0E, 0x06);
            L003A: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0058: return; // RETURN;
        }

        private void Fn_19(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0003);
            L0010: PushStack(player, 0x02);
            L0014: PushStack(player, 0x00);
0F9C  0017 C4 5E 06  les bx, [bp+0x6]
0F9F  001A 26 FF 5F 04  call far word [es:bx+0x4]
            L001E: cx = PopStack(player);
            L001F: cx = PopStack(player);
            L0020: Compare(ax, 0x0001);
            L0023: if (JumpNotEqual) goto L003A;
            L0025: SetFlag(player, 0x03, 0x0E, 0x03);
            L003A: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0058: return; // RETURN;
        }

        private void Fn_1A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFlag(player, 0x02, 0x57, 0x00);
            L0017: return; // RETURN;
        }

        private void Fn_1B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x17), 0x0001);
            L0017: if (JumpNotEqual) goto L004F;
            L0019: SetFlag(player, 0x03, 0x0F, 0x01);
            L002E: ShowMessage(player, String04B2); // The boars have run away from the Prunes of Cawdor!
            L003B: SetFlag(player, 0x03, 0x17, 0x00);
            L004F: RefreshCompareFlags(GetFlag(player, 0x03, 0x0F));
            L0062: if (JumpEqual) goto L0067;
            L0064: goto L0120;
            L0067: SetFlag(player, 0x03, 0x0F, 0x01);
            L007C: PushStack(player, 0x64);
            L0080: PushStack(player, 0x00);
            L0083: PushStack(player, ax);
            L0084: PushStack(player, ax);
            L0085: PushStack(player, 0xCD);
            L0089: PushStack(player, 0xBA);
1085  008D C4 5E 06  les bx, [bp+0x6]
1088  0090 26 FF 9F D8 00  call far word [es:bx+0xd8]
108D  0095 83 C4 0C  add sp, 0xc
            L0098: AddEncounter(player, 0x01, 0x15);
            L00AA: AddEncounter(player, 0x02, 0x15);
            L00BC: Compare(PartyCount(player), 0x0002);
            L00C7: if (JumpBelowOrEqual) goto L00ED;
            L00C9: AddEncounter(player, 0x03, 0x1D);
            L00DB: AddEncounter(player, 0x04, 0x1D);
            L00ED: Compare(PartyCount(player), 0x0003);
            L00F8: if (JumpBelowOrEqual) goto L012D;
            L00FA: AddEncounter(player, 0x05, 0x1D);
            L010C: AddEncounter(player, 0x06, 0x1D);
            L011E: goto L012D;
            L0120: ShowMessage(player, String04E5); // You have already cleaned out the sty.
1125  012D FF 76 08  push word [bp+0x8]
1128  0130 FF 76 06  push word [bp+0x6]
112B  0133 0E     push cs
112C  0134 E8 A7 F0  call 0xf1de
            L0137: cx = PopStack(player);
            L0138: cx = PopStack(player);
            L0139: return; // RETURN;
        }

        private void Fn_1C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x17), 0x0001);
            L0017: if (JumpNotEqual) goto L004F;
            L0019: SetFlag(player, 0x03, 0x15, 0x01);
            L002E: ShowMessage(player, String050B); // The minotaurs have run away from the Prunes of Cawdor!
            L003B: SetFlag(player, 0x03, 0x17, 0x00);
            L004F: RefreshCompareFlags(GetFlag(player, 0x03, 0x15));
            L0062: if (JumpEqual) goto L0067;
            L0064: goto L0120;
            L0067: SetFlag(player, 0x03, 0x15, 0x01);
            L007C: PushStack(player, 0x64);
            L0080: PushStack(player, 0x00);
            L0083: PushStack(player, ax);
            L0084: PushStack(player, ax);
            L0085: PushStack(player, 0xCD);
            L0089: PushStack(player, 0xBA);
11C0  008D C4 5E 06  les bx, [bp+0x6]
11C3  0090 26 FF 9F D8 00  call far word [es:bx+0xd8]
11C8  0095 83 C4 0C  add sp, 0xc
            L0098: AddEncounter(player, 0x01, 0x16);
            L00AA: AddEncounter(player, 0x02, 0x16);
            L00BC: Compare(PartyCount(player), 0x0002);
            L00C7: if (JumpBelowOrEqual) goto L00ED;
            L00C9: AddEncounter(player, 0x03, 0x1C);
            L00DB: AddEncounter(player, 0x04, 0x1C);
            L00ED: Compare(PartyCount(player), 0x0003);
            L00F8: if (JumpBelowOrEqual) goto L012D;
            L00FA: AddEncounter(player, 0x05, 0x1C);
            L010C: AddEncounter(player, 0x06, 0x1C);
            L011E: goto L012D;
            L0120: ShowMessage(player, String0542); // You have already cleaned out the barn.
1260  012D FF 76 08  push word [bp+0x8]
1263  0130 FF 76 06  push word [bp+0x6]
1266  0133 0E     push cs
1267  0134 E8 6C EF  call 0xf0a3
            L0137: cx = PopStack(player);
            L0138: cx = PopStack(player);
            L0139: return; // RETURN;
        }

        private void Fn_1D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x17), 0x0001);
            L0017: if (JumpNotEqual) goto L004F;
            L0019: SetFlag(player, 0x03, 0x10, 0x01);
            L002E: ShowMessage(player, String0569); // The slimes have run away from the Prunes of Cawdor!
            L003B: SetFlag(player, 0x03, 0x17, 0x00);
            L004F: RefreshCompareFlags(GetFlag(player, 0x03, 0x10));
            L0062: if (JumpEqual) goto L0067;
            L0064: goto L0120;
            L0067: SetFlag(player, 0x03, 0x10, 0x01);
            L007C: PushStack(player, 0x64);
            L0080: PushStack(player, 0x00);
            L0083: PushStack(player, ax);
            L0084: PushStack(player, ax);
            L0085: PushStack(player, 0xCD);
            L0089: PushStack(player, 0xBA);
12FB  008D C4 5E 06  les bx, [bp+0x6]
12FE  0090 26 FF 9F D8 00  call far word [es:bx+0xd8]
1303  0095 83 C4 0C  add sp, 0xc
            L0098: AddEncounter(player, 0x01, 0x17);
            L00AA: AddEncounter(player, 0x02, 0x1B);
            L00BC: Compare(PartyCount(player), 0x0002);
            L00C7: if (JumpBelowOrEqual) goto L00ED;
            L00C9: AddEncounter(player, 0x03, 0x17);
            L00DB: AddEncounter(player, 0x04, 0x1B);
            L00ED: Compare(PartyCount(player), 0x0003);
            L00F8: if (JumpBelowOrEqual) goto L012D;
            L00FA: AddEncounter(player, 0x05, 0x1B);
            L010C: AddEncounter(player, 0x06, 0x1B);
            L011E: goto L012D;
            L0120: ShowMessage(player, String059D); // You have already cleaned out the drains.
139B  012D FF 76 08  push word [bp+0x8]
139E  0130 FF 76 06  push word [bp+0x6]
13A1  0133 0E     push cs
13A2  0134 E8 31 EE  call 0xef68
            L0137: cx = PopStack(player);
            L0138: cx = PopStack(player);
            L0139: return; // RETURN;
        }

        private void Fn_1E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x17), 0x0001);
            L0017: if (JumpNotEqual) goto L004F;
            L0019: SetFlag(player, 0x03, 0x13, 0x01);
            L002E: ShowMessage(player, String05C6); // The bats have run away from the Prunes of Cawdor!
            L003B: SetFlag(player, 0x03, 0x17, 0x00);
            L004F: RefreshCompareFlags(GetFlag(player, 0x03, 0x13));
            L0062: if (JumpEqual) goto L0067;
            L0064: goto L0120;
            L0067: SetFlag(player, 0x03, 0x13, 0x01);
            L007C: PushStack(player, 0x64);
            L0080: PushStack(player, 0x00);
            L0083: PushStack(player, ax);
            L0084: PushStack(player, ax);
            L0085: PushStack(player, 0xCD);
            L0089: PushStack(player, 0xBA);
1436  008D C4 5E 06  les bx, [bp+0x6]
1439  0090 26 FF 9F D8 00  call far word [es:bx+0xd8]
143E  0095 83 C4 0C  add sp, 0xc
            L0098: AddEncounter(player, 0x01, 0x12);
            L00AA: AddEncounter(player, 0x02, 0x25);
            L00BC: Compare(PartyCount(player), 0x0002);
            L00C7: if (JumpBelowOrEqual) goto L00ED;
            L00C9: AddEncounter(player, 0x03, 0x12);
            L00DB: AddEncounter(player, 0x04, 0x12);
            L00ED: Compare(PartyCount(player), 0x0003);
            L00F8: if (JumpBelowOrEqual) goto L012D;
            L00FA: AddEncounter(player, 0x05, 0x25);
            L010C: AddEncounter(player, 0x06, 0x25);
            L011E: goto L012D;
            L0120: ShowMessage(player, String05F8); // You have already cleaned out the cave.
14D6  012D FF 76 08  push word [bp+0x8]
14D9  0130 FF 76 06  push word [bp+0x6]
14DC  0133 0E     push cs
14DD  0134 E8 F6 EC  call 0xee2d
            L0137: cx = PopStack(player);
            L0138: cx = PopStack(player);
            L0139: return; // RETURN;
        }

        private void Fn_1F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x17), 0x0001);
            L0017: if (JumpNotEqual) goto L004F;
            L0019: SetFlag(player, 0x03, 0x16, 0x01);
            L002E: ShowMessage(player, String061F); // The medusa have run away from the Prunes of Cawdor!
            L003B: SetFlag(player, 0x03, 0x17, 0x00);
            L004F: RefreshCompareFlags(GetFlag(player, 0x03, 0x16));
            L0062: if (JumpEqual) goto L0067;
            L0064: goto L0120;
            L0067: SetFlag(player, 0x03, 0x16, 0x01);
            L007C: PushStack(player, 0x64);
            L0080: PushStack(player, 0x00);
            L0083: PushStack(player, ax);
            L0084: PushStack(player, ax);
            L0085: PushStack(player, 0xCD);
            L0089: PushStack(player, 0xBA);
1571  008D C4 5E 06  les bx, [bp+0x6]
1574  0090 26 FF 9F D8 00  call far word [es:bx+0xd8]
1579  0095 83 C4 0C  add sp, 0xc
            L0098: AddEncounter(player, 0x01, 0x14);
            L00AA: AddEncounter(player, 0x02, 0x1F);
            L00BC: Compare(PartyCount(player), 0x0002);
            L00C7: if (JumpBelowOrEqual) goto L00ED;
            L00C9: AddEncounter(player, 0x03, 0x14);
            L00DB: AddEncounter(player, 0x04, 0x1F);
            L00ED: Compare(PartyCount(player), 0x0003);
            L00F8: if (JumpBelowOrEqual) goto L012D;
            L00FA: AddEncounter(player, 0x05, 0x14);
            L010C: AddEncounter(player, 0x06, 0x1F);
            L011E: goto L012D;
            L0120: ShowMessage(player, String0653); // You have already cleaned out the pit.
1611  012D FF 76 08  push word [bp+0x8]
1614  0130 FF 76 06  push word [bp+0x6]
1617  0133 0E     push cs
1618  0134 E8 BB EB  call 0xecf2
            L0137: cx = PopStack(player);
            L0138: cx = PopStack(player);
            L0139: return; // RETURN;
        }

        private void Fn_20(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x17), 0x0001);
            L0017: if (JumpNotEqual) goto L004F;
            L0019: SetFlag(player, 0x03, 0x11, 0x01);
            L002E: ShowMessage(player, String0679); // The brinded cats have run away from the Prunes of Cawdor!
            L003B: SetFlag(player, 0x03, 0x17, 0x00);
            L004F: RefreshCompareFlags(GetFlag(player, 0x03, 0x11));
            L0062: if (JumpEqual) goto L0067;
            L0064: goto L0120;
            L0067: SetFlag(player, 0x03, 0x11, 0x01);
            L007C: PushStack(player, 0x64);
            L0080: PushStack(player, 0x00);
            L0083: PushStack(player, ax);
            L0084: PushStack(player, ax);
            L0085: PushStack(player, 0xCD);
            L0089: PushStack(player, 0xBA);
16AC  008D C4 5E 06  les bx, [bp+0x6]
16AF  0090 26 FF 9F D8 00  call far word [es:bx+0xd8]
16B4  0095 83 C4 0C  add sp, 0xc
            L0098: AddEncounter(player, 0x01, 0x18);
            L00AA: AddEncounter(player, 0x02, 0x18);
            L00BC: Compare(PartyCount(player), 0x0002);
            L00C7: if (JumpBelowOrEqual) goto L00ED;
            L00C9: AddEncounter(player, 0x03, 0x18);
            L00DB: AddEncounter(player, 0x04, 0x19);
            L00ED: Compare(PartyCount(player), 0x0003);
            L00F8: if (JumpBelowOrEqual) goto L012D;
            L00FA: AddEncounter(player, 0x05, 0x18);
            L010C: AddEncounter(player, 0x06, 0x19);
            L011E: goto L012D;
            L0120: ShowMessage(player, String06B3); // You have already cleaned out the pride.
174C  012D FF 76 08  push word [bp+0x8]
174F  0130 FF 76 06  push word [bp+0x6]
1752  0133 0E     push cs
1753  0134 E8 80 EA  call 0xebb7
            L0137: cx = PopStack(player);
            L0138: cx = PopStack(player);
            L0139: return; // RETURN;
        }

        private void Fn_21(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x17), 0x0001);
            L0017: if (JumpNotEqual) goto L004F;
            L0019: SetFlag(player, 0x03, 0x14, 0x01);
            L002E: ShowMessage(player, String06DB); // The harpies have run away from the Prunes of Cawdor!
            L003B: SetFlag(player, 0x03, 0x17, 0x00);
            L004F: RefreshCompareFlags(GetFlag(player, 0x03, 0x14));
            L0062: if (JumpEqual) goto L0067;
            L0064: goto L0120;
            L0067: SetFlag(player, 0x03, 0x14, 0x01);
            L007C: PushStack(player, 0x64);
            L0080: PushStack(player, 0x00);
            L0083: PushStack(player, ax);
            L0084: PushStack(player, ax);
            L0085: PushStack(player, 0xCD);
            L0089: PushStack(player, 0xBA);
17E7  008D C4 5E 06  les bx, [bp+0x6]
17EA  0090 26 FF 9F D8 00  call far word [es:bx+0xd8]
17EF  0095 83 C4 0C  add sp, 0xc
            L0098: AddEncounter(player, 0x05, 0x24);
            L00AA: AddEncounter(player, 0x01, 0x24);
            L00BC: Compare(PartyCount(player), 0x0002);
            L00C7: if (JumpBelowOrEqual) goto L00ED;
            L00C9: AddEncounter(player, 0x02, 0x24);
            L00DB: AddEncounter(player, 0x06, 0x23);
            L00ED: Compare(PartyCount(player), 0x0003);
            L00F8: if (JumpBelowOrEqual) goto L012D;
            L00FA: AddEncounter(player, 0x03, 0x24);
            L010C: AddEncounter(player, 0x04, 0x24);
            L011E: goto L012D;
            L0120: ShowMessage(player, String0710); // You have already cleaned out the roost.
1887  012D FF 76 08  push word [bp+0x8]
188A  0130 FF 76 06  push word [bp+0x6]
188D  0133 0E     push cs
188E  0134 E8 45 E9  call 0xea7c
            L0137: cx = PopStack(player);
            L0138: cx = PopStack(player);
            L0139: return; // RETURN;
        }

        private void Fn_22(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x17), 0x0001);
            L0017: if (JumpNotEqual) goto L004F;
            L0019: SetFlag(player, 0x03, 0x12, 0x01);
            L002E: ShowMessage(player, String0738); // The hell hounds have run away from the Prunes of Cawdor!
            L003B: SetFlag(player, 0x03, 0x17, 0x00);
            L004F: RefreshCompareFlags(GetFlag(player, 0x03, 0x12));
            L0062: if (JumpEqual) goto L0067;
            L0064: goto L0120;
            L0067: SetFlag(player, 0x03, 0x12, 0x01);
            L007C: PushStack(player, 0x64);
            L0080: PushStack(player, 0x00);
            L0083: PushStack(player, ax);
            L0084: PushStack(player, ax);
            L0085: PushStack(player, 0xCD);
            L0089: PushStack(player, 0xBA);
1922  008D C4 5E 06  les bx, [bp+0x6]
1925  0090 26 FF 9F D8 00  call far word [es:bx+0xd8]
192A  0095 83 C4 0C  add sp, 0xc
            L0098: AddEncounter(player, 0x01, 0x13);
            L00AA: AddEncounter(player, 0x05, 0x20);
            L00BC: Compare(PartyCount(player), 0x0002);
            L00C7: if (JumpBelowOrEqual) goto L00ED;
            L00C9: AddEncounter(player, 0x02, 0x13);
            L00DB: AddEncounter(player, 0x05, 0x20);
            L00ED: Compare(PartyCount(player), 0x0003);
            L00F8: if (JumpBelowOrEqual) goto L012D;
            L00FA: AddEncounter(player, 0x03, 0x13);
            L010C: AddEncounter(player, 0x04, 0x20);
            L011E: goto L012D;
            L0120: ShowMessage(player, String0771); // You have already cleaned out the kennels.
19C2  012D FF 76 08  push word [bp+0x8]
19C5  0130 FF 76 06  push word [bp+0x6]
19C8  0133 0E     push cs
19C9  0134 E8 0A E8  call 0xe941
            L0137: cx = PopStack(player);
            L0138: cx = PopStack(player);
            L0139: return; // RETURN;
        }

        private void Fn_23(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: // make space for tmp on stack: sp -= 2
            L0005: Compare(GetCurrentTile(player), 0x00B8);
            L000F: if (JumpNotEqual) goto L0016;
19E1  0011 B8 B8 00  mov ax, 0xb8
            L0014: goto L0018;
            L0016: SetFlag(player, 0x02, 0x57, 0x00);
            L002A: ax = GetFlag(player, 0x03, 0x0E);
1A0B  003B 89 46 FE  mov [bp-0x2], ax
1A0E  003E FF 76 08  push word [bp+0x8]
1A11  0041 FF 76 06  push word [bp+0x6]
1A14  0044 0E     push cs
1A15  0045 E8 BE E7  call 0xe806
            L0048: cx = PopStack(player);
            L0049: cx = PopStack(player);
            L004A: Compare(GetFlag(player, 0x03, 0x17), 0x0001);
            L005E: if (JumpNotEqual) goto L0091;
            L0060: SetFlag(player, 0x03, 0x17, 0x00);
            L0074: ShowMessage(player, String079B); // The beasts have run from the Prunes of Cawdor.
            L0081: ShowMessage(player, String07CA); // Isn't that a tasteful turn of phrase?
            L008E: goto L0490;
1A61  0091 8B 5E FE  mov bx, [bp-0x2]
            L0094: bx = bx - 1;
            L0095: Compare(bx, 0x0F);
            L0098: if (JumpBelowOrEqual) goto L009D;
            L009A: goto L0484;
            L009D: switch (bx) {
                case 0:
                    goto L00A4;
                case 1:
                    goto L012C;
                case 2:
                    goto L01A7;
                case 3:
                    goto L0484;
                case 4:
                    goto L0222;
                case 5:
                    goto L029D;
                case 6:
                    goto L0484;
                case 7:
                    goto L0484;
                case 8:
                    goto L0484;
                case 9:
                    goto L0484;
                case 10:
                    goto L0484;
                case 11:
                    goto L0484;
                case 12:
                    goto L0318;
                case 13:
                    goto L0484;
                case 14:
                    goto L0393;
                case 15:
                    goto L040D;
            }
            L00A4: RefreshCompareFlags(GetFlag(player, 0x03, 0x11));
            L00B7: if (JumpNotEqual) goto L0129;
1A89  00B9 B8 90 01  mov ax, 0x190
            L00BC: PushStack(player, ax);
            L00BD: PushStack(player, 0x00);
            L00C0: PushStack(player, ax);
            L00C1: PushStack(player, ax);
            L00C2: PushStack(player, 0xCE);
            L00C6: PushStack(player, 0xBB);
1A9A  00CA C4 5E 06  les bx, [bp+0x6]
1A9D  00CD 26 FF 9F D8 00  call far word [es:bx+0xd8]
1AA2  00D2 83 C4 0C  add sp, 0xc
            L00D5: AddEncounter(player, 0x01, 0x18);
            L00E7: Compare(PartyCount(player), 0x0002);
            L00F2: if (JumpBelowOrEqual) goto L0106;
            L00F4: AddEncounter(player, 0x02, 0x18);
            L0106: Compare(PartyCount(player), 0x0003);
            L0111: if (JumpAbove) goto L0116;
            L0113: goto L0490;
            L0116: PushStack(player, 0x18);
            L011A: PushStack(player, 0x03);
1AEE  011E C4 5E 06  les bx, [bp+0x6]
1AF1  0121 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L0126: goto L048E;
            L0129: goto L0484;
            L012C: RefreshCompareFlags(GetFlag(player, 0x03, 0x10));
            L013F: if (JumpNotEqual) goto L01A4;
1B11  0141 B8 90 01  mov ax, 0x190
            L0144: PushStack(player, ax);
            L0145: PushStack(player, 0x00);
            L0148: PushStack(player, ax);
            L0149: PushStack(player, ax);
            L014A: PushStack(player, 0xCE);
            L014E: PushStack(player, 0xBB);
1B22  0152 C4 5E 06  les bx, [bp+0x6]
1B25  0155 26 FF 9F D8 00  call far word [es:bx+0xd8]
1B2A  015A 83 C4 0C  add sp, 0xc
            L015D: AddEncounter(player, 0x01, 0x17);
            L016F: Compare(PartyCount(player), 0x0002);
            L017A: if (JumpBelowOrEqual) goto L018E;
            L017C: AddEncounter(player, 0x02, 0x17);
            L018E: Compare(PartyCount(player), 0x0003);
            L0199: if (JumpAbove) goto L019E;
            L019B: goto L0490;
1B6E  019E B8 17 00  mov ax, 0x17
            L01A1: goto L0119;
            L01A4: goto L0484;
            L01A7: RefreshCompareFlags(GetFlag(player, 0x03, 0x15));
            L01BA: if (JumpNotEqual) goto L021F;
1B8C  01BC B8 90 01  mov ax, 0x190
            L01BF: PushStack(player, ax);
            L01C0: PushStack(player, 0x00);
            L01C3: PushStack(player, ax);
            L01C4: PushStack(player, ax);
            L01C5: PushStack(player, 0xCE);
            L01C9: PushStack(player, 0xBB);
1B9D  01CD C4 5E 06  les bx, [bp+0x6]
1BA0  01D0 26 FF 9F D8 00  call far word [es:bx+0xd8]
1BA5  01D5 83 C4 0C  add sp, 0xc
            L01D8: AddEncounter(player, 0x01, 0x16);
            L01EA: Compare(PartyCount(player), 0x0002);
            L01F5: if (JumpBelowOrEqual) goto L0209;
            L01F7: AddEncounter(player, 0x02, 0x16);
            L0209: Compare(PartyCount(player), 0x0003);
            L0214: if (JumpAbove) goto L0219;
            L0216: goto L0490;
1BE9  0219 B8 16 00  mov ax, 0x16
            L021C: goto L0119;
            L021F: goto L0484;
            L0222: RefreshCompareFlags(GetFlag(player, 0x03, 0x0F));
            L0235: if (JumpNotEqual) goto L029A;
1C07  0237 B8 90 01  mov ax, 0x190
            L023A: PushStack(player, ax);
            L023B: PushStack(player, 0x00);
            L023E: PushStack(player, ax);
            L023F: PushStack(player, ax);
            L0240: PushStack(player, 0xCE);
            L0244: PushStack(player, 0xBB);
1C18  0248 C4 5E 06  les bx, [bp+0x6]
1C1B  024B 26 FF 9F D8 00  call far word [es:bx+0xd8]
1C20  0250 83 C4 0C  add sp, 0xc
            L0253: AddEncounter(player, 0x01, 0x15);
            L0265: Compare(PartyCount(player), 0x0002);
            L0270: if (JumpBelowOrEqual) goto L0284;
            L0272: AddEncounter(player, 0x02, 0x15);
            L0284: Compare(PartyCount(player), 0x0003);
            L028F: if (JumpAbove) goto L0294;
            L0291: goto L0490;
1C64  0294 B8 15 00  mov ax, 0x15
            L0297: goto L0119;
            L029A: goto L0484;
            L029D: RefreshCompareFlags(GetFlag(player, 0x03, 0x16));
            L02B0: if (JumpNotEqual) goto L0315;
1C82  02B2 B8 90 01  mov ax, 0x190
            L02B5: PushStack(player, ax);
            L02B6: PushStack(player, 0x00);
            L02B9: PushStack(player, ax);
            L02BA: PushStack(player, ax);
            L02BB: PushStack(player, 0xCE);
            L02BF: PushStack(player, 0xBB);
1C93  02C3 C4 5E 06  les bx, [bp+0x6]
1C96  02C6 26 FF 9F D8 00  call far word [es:bx+0xd8]
1C9B  02CB 83 C4 0C  add sp, 0xc
            L02CE: AddEncounter(player, 0x01, 0x14);
            L02E0: Compare(PartyCount(player), 0x0002);
            L02EB: if (JumpBelowOrEqual) goto L02FF;
            L02ED: AddEncounter(player, 0x02, 0x14);
            L02FF: Compare(PartyCount(player), 0x0003);
            L030A: if (JumpAbove) goto L030F;
            L030C: goto L0490;
1CDF  030F B8 14 00  mov ax, 0x14
            L0312: goto L0119;
            L0315: goto L0484;
            L0318: RefreshCompareFlags(GetFlag(player, 0x03, 0x12));
            L032B: if (JumpNotEqual) goto L0390;
1CFD  032D B8 90 01  mov ax, 0x190
            L0330: PushStack(player, ax);
            L0331: PushStack(player, 0x00);
            L0334: PushStack(player, ax);
            L0335: PushStack(player, ax);
            L0336: PushStack(player, 0xCE);
            L033A: PushStack(player, 0xBB);
1D0E  033E C4 5E 06  les bx, [bp+0x6]
1D11  0341 26 FF 9F D8 00  call far word [es:bx+0xd8]
1D16  0346 83 C4 0C  add sp, 0xc
            L0349: AddEncounter(player, 0x01, 0x13);
            L035B: Compare(PartyCount(player), 0x0002);
            L0366: if (JumpBelowOrEqual) goto L037A;
            L0368: AddEncounter(player, 0x02, 0x13);
            L037A: Compare(PartyCount(player), 0x0003);
            L0385: if (JumpAbove) goto L038A;
            L0387: goto L0490;
1D5A  038A B8 13 00  mov ax, 0x13
            L038D: goto L0119;
            L0390: goto L0484;
            L0393: RefreshCompareFlags(GetFlag(player, 0x03, 0x14));
            L03A6: if (JumpNotEqual) goto L040B;
1D78  03A8 B8 90 01  mov ax, 0x190
            L03AB: PushStack(player, ax);
            L03AC: PushStack(player, 0x00);
            L03AF: PushStack(player, ax);
            L03B0: PushStack(player, ax);
            L03B1: PushStack(player, 0xCE);
            L03B5: PushStack(player, 0xBB);
1D89  03B9 C4 5E 06  les bx, [bp+0x6]
1D8C  03BC 26 FF 9F D8 00  call far word [es:bx+0xd8]
1D91  03C1 83 C4 0C  add sp, 0xc
            L03C4: AddEncounter(player, 0x01, 0x11);
            L03D6: Compare(PartyCount(player), 0x0002);
            L03E1: if (JumpBelowOrEqual) goto L03F5;
            L03E3: AddEncounter(player, 0x02, 0x11);
            L03F5: Compare(PartyCount(player), 0x0003);
            L0400: if (JumpAbove) goto L0405;
            L0402: goto L0490;
1DD5  0405 B8 11 00  mov ax, 0x11
            L0408: goto L0119;
            L040B: goto L0484;
            L040D: RefreshCompareFlags(GetFlag(player, 0x03, 0x13));
            L0420: if (JumpNotEqual) goto L0482;
1DF2  0422 B8 90 01  mov ax, 0x190
            L0425: PushStack(player, ax);
            L0426: PushStack(player, 0x00);
            L0429: PushStack(player, ax);
            L042A: PushStack(player, ax);
            L042B: PushStack(player, 0xCE);
            L042F: PushStack(player, 0xBB);
1E03  0433 C4 5E 06  les bx, [bp+0x6]
1E06  0436 26 FF 9F D8 00  call far word [es:bx+0xd8]
1E0B  043B 83 C4 0C  add sp, 0xc
            L043E: AddEncounter(player, 0x01, 0x12);
            L0450: Compare(PartyCount(player), 0x0002);
            L045B: if (JumpBelowOrEqual) goto L046F;
            L045D: AddEncounter(player, 0x02, 0x12);
            L046F: Compare(PartyCount(player), 0x0003);
            L047A: if (JumpBelowOrEqual) goto L0490;
1E4C  047C B8 12 00  mov ax, 0x12
            L047F: goto L0119;
            L0482: goto L0484;
1E54  0484 FF 76 08  push word [bp+0x8]
1E57  0487 FF 76 06  push word [bp+0x6]
1E5A  048A 0E     push cs
1E5B  048B E8 11 E6  call 0xea9f
            L048E: cx = PopStack(player);
            L048F: cx = PopStack(player);
            L0490: SetFlag(player, 0x00, 0x02, 0x01);
            L04A4: // restore stack ptr: sp = bp;
            L04A6: return; // RETURN;
        }

        private void Fn_24(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
1E9B  0003 FF 76 08  push word [bp+0x8]
1E9E  0006 FF 76 06  push word [bp+0x6]
1EA1  0009 0E     push cs
1EA2  000A E8 31 E3  call 0xe33e
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: Compare(GetFlag(player, 0x02, 0x57), 0x00D5);
            L0023: if (JumpNotEqual) goto L002A;
1EBD  0025 B8 D4 00  mov ax, 0xd4
            L0028: goto L002C;
            L002A: SetFlag(player, 0x02, 0x57, 0x00);
            L003E: return; // RETURN;
        }

        private void Fn_25(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x05));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00E8;
            L001B: ShowMessage(player, String07F0); // 'Screw your courage to the sticking place and you'll not fail!  Avaunt!
            L0028: SetFlag(player, 0x03, 0x05, 0x01);
1F15  003D B8 10 27  mov ax, 0x2710
            L0040: PushStack(player, ax);
            L0041: PushStack(player, 0xE7);
            L0045: PushStack(player, 0xE8);
            L0049: PushStack(player, 0xE7);
            L004D: PushStack(player, 0xED);
            L0051: PushStack(player, 0xE8);
1F2D  0055 C4 5E 06  les bx, [bp+0x6]
1F30  0058 26 FF 9F D8 00  call far word [es:bx+0xd8]
1F35  005D 83 C4 0C  add sp, 0xc
            L0060: AddEncounter(player, 0x01, 0x26);
            L0072: AddEncounter(player, 0x05, 0x25);
            L0084: Compare(PartyCount(player), 0x0002);
            L008F: if (JumpBelowOrEqual) goto L00B5;
            L0091: AddEncounter(player, 0x06, 0x25);
            L00A3: AddEncounter(player, 0x02, 0x20);
            L00B5: Compare(PartyCount(player), 0x0003);
            L00C0: if (JumpBelowOrEqual) goto L00F5;
            L00C2: AddEncounter(player, 0x03, 0x20);
            L00D4: AddEncounter(player, 0x04, 0x20);
            L00E6: goto L00F5;
            L00E8: ShowMessage(player, String0838); // That was no way to treat a lady.  Then again, she wasn't much of a lady, was she?
            L00F5: return; // RETURN;
        }

        private void Fn_26(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x05));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00E8;
            L001B: ShowMessage(player, String07F0); // 'Screw your courage to the sticking place and you'll not fail!  Avaunt!
            L0028: SetFlag(player, 0x03, 0x05, 0x01);
200C  003D B8 10 27  mov ax, 0x2710
            L0040: PushStack(player, ax);
            L0041: PushStack(player, 0xE7);
            L0045: PushStack(player, 0xE8);
            L0049: PushStack(player, 0xE7);
            L004D: PushStack(player, 0xED);
            L0051: PushStack(player, 0xE8);
2024  0055 C4 5E 06  les bx, [bp+0x6]
2027  0058 26 FF 9F D8 00  call far word [es:bx+0xd8]
202C  005D 83 C4 0C  add sp, 0xc
            L0060: AddEncounter(player, 0x01, 0x27);
            L0072: AddEncounter(player, 0x05, 0x23);
            L0084: Compare(PartyCount(player), 0x0002);
            L008F: if (JumpBelowOrEqual) goto L00B5;
            L0091: AddEncounter(player, 0x06, 0x25);
            L00A3: AddEncounter(player, 0x02, 0x24);
            L00B5: Compare(PartyCount(player), 0x0003);
            L00C0: if (JumpBelowOrEqual) goto L00F5;
            L00C2: AddEncounter(player, 0x03, 0x20);
            L00D4: AddEncounter(player, 0x04, 0x20);
            L00E6: goto L00F5;
            L00E8: ShowMessage(player, String0838); // That was no way to treat a lady.  Then again, she wasn't much of a lady, was she?
            L00F5: return; // RETURN;
        }

        private void Fn_27(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x05));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00E8;
            L001B: ShowMessage(player, String07F0); // 'Screw your courage to the sticking place and you'll not fail!  Avaunt!
            L0028: SetFlag(player, 0x03, 0x05, 0x01);
2103  003D B8 10 27  mov ax, 0x2710
            L0040: PushStack(player, ax);
            L0041: PushStack(player, 0xE7);
            L0045: PushStack(player, 0xE8);
            L0049: PushStack(player, 0xE7);
            L004D: PushStack(player, 0xED);
            L0051: PushStack(player, 0xE8);
211B  0055 C4 5E 06  les bx, [bp+0x6]
211E  0058 26 FF 9F D8 00  call far word [es:bx+0xd8]
2123  005D 83 C4 0C  add sp, 0xc
            L0060: AddEncounter(player, 0x01, 0x28);
            L0072: AddEncounter(player, 0x05, 0x22);
            L0084: Compare(PartyCount(player), 0x0002);
            L008F: if (JumpBelowOrEqual) goto L00B5;
            L0091: AddEncounter(player, 0x06, 0x25);
            L00A3: AddEncounter(player, 0x02, 0x20);
            L00B5: Compare(PartyCount(player), 0x0003);
            L00C0: if (JumpBelowOrEqual) goto L00F5;
            L00C2: AddEncounter(player, 0x03, 0x21);
            L00D4: AddEncounter(player, 0x04, 0x21);
            L00E6: goto L00F5;
            L00E8: ShowMessage(player, String0838); // That was no way to treat a lady.  Then again, she wasn't much of a lady, was she?
            L00F5: return; // RETURN;
        }

        private void Fn_28(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x05));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00DB;
            L001B: ShowMessage(player, String07F0); // 'Screw your courage to the sticking place and you'll not fail!  Avaunt!
            L0028: SetFlag(player, 0x03, 0x05, 0x01);
21FA  003D B8 10 27  mov ax, 0x2710
            L0040: PushStack(player, ax);
            L0041: PushStack(player, 0xE7);
            L0045: PushStack(player, 0xE8);
            L0049: PushStack(player, 0xE7);
            L004D: PushStack(player, 0xED);
            L0051: PushStack(player, 0xE8);
2212  0055 C4 5E 06  les bx, [bp+0x6]
2215  0058 26 FF 9F D8 00  call far word [es:bx+0xd8]
221A  005D 83 C4 0C  add sp, 0xc
            L0060: AddEncounter(player, 0x01, 0x28);
            L0072: AddEncounter(player, 0x05, 0x22);
            L0084: AddEncounter(player, 0x06, 0x24);
            L0096: AddEncounter(player, 0x02, 0x22);
            L00A8: Compare(PartyCount(player), 0x0003);
            L00B3: if (JumpBelowOrEqual) goto L00E8;
            L00B5: AddEncounter(player, 0x03, 0x24);
            L00C7: AddEncounter(player, 0x04, 0x24);
            L00D9: goto L00E8;
            L00DB: ShowMessage(player, String0838); // That was no way to treat a lady.  Then again, she wasn't much of a lady, was she?
            L00E8: return; // RETURN;
        }

        private void Fn_29(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFlag(player, 0x02, 0x46, 0x01);
            L0018: ShowMessage(player, String088A); // This section of the bestiary is better lit with torches.
            L0025: return; // RETURN;
        }

        private void Fn_2A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
22D1  0003 FF 76 08  push word [bp+0x8]
22D4  0006 FF 76 06  push word [bp+0x6]
22D7  0009 0E     push cs
22D8  000A E8 FB DE  call 0xdf08
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: RefreshCompareFlags(GetFlag(player, 0x03, 0x06));
            L0022: if (JumpEqual) goto L0027;
            L0024: goto L0101;
            L0027: SetFlag(player, 0x03, 0x06, 0x01);
            L003C: ShowMessage(player, String08C3); // They may have left the door open, but they sure didn't leave it unguarded!
2317  0049 B8 A7 05  mov ax, 0x5a7
            L004C: PushStack(player, ax);
            L004D: PushStack(player, 0x86);
            L0051: PushStack(player, 0xDD);
            L0055: PushStack(player, 0x88);
            L0059: PushStack(player, 0xCD);
            L005D: PushStack(player, 0x55);
232F  0061 C4 5E 06  les bx, [bp+0x6]
2332  0064 26 FF 9F D8 00  call far word [es:bx+0xd8]
2337  0069 83 C4 0C  add sp, 0xc
            L006C: AddEncounter(player, 0x01, 0x21);
            L007E: Compare(PartyCount(player), 0x0001);
            L0089: if (JumpBelowOrEqual) goto L00AF;
            L008B: AddEncounter(player, 0x02, 0x22);
            L009D: AddEncounter(player, 0x03, 0x21);
            L00AF: Compare(PartyCount(player), 0x0002);
            L00BA: if (JumpBelowOrEqual) goto L00CE;
            L00BC: AddEncounter(player, 0x04, 0x22);
            L00CE: Compare(PartyCount(player), 0x0003);
            L00D9: if (JumpBelowOrEqual) goto L010E;
            L00DB: AddEncounter(player, 0x05, 0x21);
            L00ED: AddEncounter(player, 0x06, 0x22);
            L00FF: goto L010E;
            L0101: ShowMessage(player, String090E); // Those wyrms won't be dragon you into their petty squabbles again.
            L010E: return; // RETURN;
        }

        private void Fn_2B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
23E1  0003 FF 76 08  push word [bp+0x8]
23E4  0006 FF 76 06  push word [bp+0x6]
23E7  0009 0E     push cs
23E8  000A E8 EB DD  call 0xddf8
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: RefreshCompareFlags(GetFlag(player, 0x03, 0x07));
            L0022: if (JumpEqual) goto L0027;
            L0024: goto L0100;
            L0027: SetFlag(player, 0x03, 0x07, 0x01);
            L003C: ShowMessage(player, String0950); // I guess they are calling it the bestiary for a reason!
            L0049: AddTreasure(player, 0x05A7, 0x00, 0x89, 0x6A, 0xCD, 0x38);
            L006B: AddEncounter(player, 0x01, 0x20);
            L007D: Compare(PartyCount(player), 0x0001);
            L0088: if (JumpBelowOrEqual) goto L00AE;
            L008A: AddEncounter(player, 0x02, 0x1D);
            L009C: AddEncounter(player, 0x03, 0x1D);
            L00AE: Compare(PartyCount(player), 0x0002);
            L00B9: if (JumpBelowOrEqual) goto L00CD;
            L00BB: AddEncounter(player, 0x04, 0x20);
            L00CD: Compare(PartyCount(player), 0x0003);
            L00D8: if (JumpBelowOrEqual) goto L010D;
            L00DA: AddEncounter(player, 0x05, 0x1D);
            L00EC: AddEncounter(player, 0x06, 0x20);
            L00FE: goto L010D;
            L0100: ShowMessage(player, String0987); // Bowser won't be playing any more.  Heh heh.
            L010D: return; // RETURN;
        }

        private void Fn_2C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
24F0  0003 FF 76 08  push word [bp+0x8]
24F3  0006 FF 76 06  push word [bp+0x6]
24F6  0009 0E     push cs
24F7  000A E8 DC DC  call 0xdce9
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: RefreshCompareFlags(GetFlag(player, 0x03, 0x08));
            L0022: if (JumpEqual) goto L0027;
            L0024: goto L00FD;
            L0027: SetFlag(player, 0x03, 0x08, 0x01);
            L003C: ShowMessage(player, String09B3); // You wouldn't have thought this corridor left enough room for harpies to fly.  But they're managing it!
2536  0049 B8 A7 05  mov ax, 0x5a7
            L004C: PushStack(player, ax);
            L004D: PushStack(player, 0x00);
            L0050: PushStack(player, ax);
            L0051: PushStack(player, 0x68);
            L0055: PushStack(player, 0xCD);
            L0059: PushStack(player, 0x95);
254A  005D C4 5E 06  les bx, [bp+0x6]
254D  0060 26 FF 9F D8 00  call far word [es:bx+0xd8]
2552  0065 83 C4 0C  add sp, 0xc
            L0068: AddEncounter(player, 0x01, 0x23);
            L007A: Compare(PartyCount(player), 0x0001);
            L0085: if (JumpBelowOrEqual) goto L00AB;
            L0087: AddEncounter(player, 0x02, 0x23);
            L0099: AddEncounter(player, 0x03, 0x12);
            L00AB: Compare(PartyCount(player), 0x0002);
            L00B6: if (JumpBelowOrEqual) goto L00CA;
            L00B8: AddEncounter(player, 0x04, 0x12);
            L00CA: Compare(PartyCount(player), 0x0003);
            L00D5: if (JumpBelowOrEqual) goto L010A;
            L00D7: AddEncounter(player, 0x05, 0x12);
            L00E9: AddEncounter(player, 0x06, 0x12);
            L00FB: goto L010A;
            L00FD: ShowMessage(player, String0A1A); // You made sure that those bats won't ever get tangled in anyone's hair ever again.
            L010A: return; // RETURN;
        }

        private void Fn_2D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
25FC  0003 FF 76 08  push word [bp+0x8]
25FF  0006 FF 76 06  push word [bp+0x6]
2602  0009 0E     push cs
2603  000A E8 D0 DB  call 0xdbdd
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: RefreshCompareFlags(GetFlag(player, 0x03, 0x09));
            L0022: if (JumpEqual) goto L0027;
            L0024: goto L00FD;
            L0027: SetFlag(player, 0x03, 0x09, 0x01);
            L003C: ShowMessage(player, String0A6C); // Tchee!  You joined this quest for the glory and the greater good, but these guys seem you're just in it to rob them of their share of the treasure.  En garde!
2642  0049 B8 A7 05  mov ax, 0x5a7
            L004C: PushStack(player, ax);
            L004D: PushStack(player, 0x00);
            L0050: PushStack(player, ax);
            L0051: PushStack(player, 0x93);
            L0055: PushStack(player, 0xCD);
            L0059: PushStack(player, 0x82);
2656  005D C4 5E 06  les bx, [bp+0x6]
2659  0060 26 FF 9F D8 00  call far word [es:bx+0xd8]
265E  0065 83 C4 0C  add sp, 0xc
            L0068: AddEncounter(player, 0x01, 0x0D);
            L007A: Compare(PartyCount(player), 0x0001);
            L0085: if (JumpBelowOrEqual) goto L00AB;
            L0087: AddEncounter(player, 0x02, 0x03);
            L0099: AddEncounter(player, 0x05, 0x0A);
            L00AB: Compare(PartyCount(player), 0x0002);
            L00B6: if (JumpBelowOrEqual) goto L00CA;
            L00B8: AddEncounter(player, 0x04, 0x0E);
            L00CA: Compare(PartyCount(player), 0x0003);
            L00D5: if (JumpBelowOrEqual) goto L010A;
            L00D7: AddEncounter(player, 0x03, 0x10);
            L00E9: AddEncounter(player, 0x06, 0x0F);
            L00FB: goto L010A;
            L00FD: ShowMessage(player, String0B0B); // Turns out that you did reduce their share of the treasure.  Serves them right for attacking you.
            L010A: return; // RETURN;
        }

        private void Fn_2E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0x6A);
            L0011: if (JumpNotEqual) goto L0016;
            L0013: goto L00BB;
            L0016: ax = HasItem(player, 0x86);
            L0024: if (JumpNotEqual) goto L0029;
            L0026: goto L00BB;
            L0029: ax = HasItem(player, 0x93);
            L0037: if (JumpNotEqual) goto L003C;
            L0039: goto L00BB;
            L003C: ShowMessage(player, String0B6C); // An old, quavering voice whispers from thin air.
            L0049: ShowMessage(player, String0B9C); // 'Well done, young questor.  Thou hast summoned me from afar to aid thee, as was foretold.  I will take thee to the beginning of the path thou must walk, bypassing many a beast and battle.'
            L0056: ax = HasItem(player, 0xA3);
            L0064: if (JumpNotEqual) goto L0073;
            L0066: ShowMessage(player, String0C59); // 'And a bit of advice.  Light is cheap, and life more cheaply ended for one who walks in darkness.  As my life was spent enlightening people, I suggest that thou dost visit the store ere returning to this dark and darksome place.'
            L0073: ShowMessage(player, String0D3F); // 'Now may fortune favor thee.'
            L0080: Compare(GetFlag(player, 0x02, 0x46), 0x0001);
            L0094: if (JumpNotEqual) goto L00B3;
            L0096: TeleportParty(player, 0x0A, 0x02, 0xD4, 0x01, isForwardMove);
            L00B1: goto L00D9;
            L00B3: PushStack(player, 0x00);
27BB  00B6 B8 B8 00  mov ax, 0xb8
            L00B9: goto L009D;
            L00BB: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L00D9: return; // RETURN;
        }

        private void Fn_2F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x0A));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00E7;
            L001B: SetFlag(player, 0x03, 0x0A, 0x01);
            L0030: ShowMessage(player, String0D5D); // You don't know which is worse: the slimy snakes, or the snaky slimes!
            L003D: AddTreasure(player, 0x05A7, 0x00, 0xDD, 0x6A, 0xCD, 0x55);
            L005F: AddEncounter(player, 0x01, 0x14);
            L0071: AddEncounter(player, 0x02, 0x17);
            L0083: AddEncounter(player, 0x03, 0x14);
            L0095: Compare(PartyCount(player), 0x0002);
            L00A0: if (JumpBelowOrEqual) goto L00B4;
            L00A2: AddEncounter(player, 0x04, 0x17);
            L00B4: Compare(PartyCount(player), 0x0003);
            L00BF: if (JumpBelowOrEqual) goto L00F4;
            L00C1: AddEncounter(player, 0x05, 0x14);
            L00D3: AddEncounter(player, 0x06, 0x14);
            L00E5: goto L00F4;
            L00E7: ShowMessage(player, String0DA3); // You're not exactly sure what it was you faced here, but whatever it was, it was green.
            L00F4: return; // RETURN;
        }

        private void Fn_30(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0x46), 0x0001);
            L0017: if (JumpEqual) goto L0032;
            L0019: Compare(GetFlag(player, 0x02, 0x14), 0x0001);
            L002D: if (JumpEqual) goto L0032;
            L002F: goto L00AF;
            L0031: // NOP
            L0032: ax = HasItem(player, 0x68);
            L0040: if (JumpEqual) goto L00A6;
            L0042: ax = HasItem(player, 0x89);
            L0050: if (JumpEqual) goto L00A6;
            L0052: ax = HasItem(player, 0x82);
            L0060: if (JumpEqual) goto L00A6;
            L0062: ShowMessage(player, String0DFA); // A resonant voice speaks to you from thin air.
            L006F: ShowMessage(player, String0E28); // 'I am Alfred, late the king of this land.  Hear me!  The Serpentine Crypt is a death trap, pure and simple.  I will now let you bypass some of its length.
            L007C: ShowMessage(player, String0EC3); // Help given once may yet be given again there, but thou shouldst neither expect nor seek it.  And I can advice thee in this small matter: Cassandra is the mightiest of the Wyrd Sisters.  Thou shouldst focus thy efforts on her first.  Good luck!'
            L0089: TeleportParty(player, 0x0A, 0x03, 0xB0, 0x03, isForwardMove);
            L00A4: goto L00D9;
            L00A6: PushStack(player, 0x02);
2980  00AA B8 F0 00  mov ax, 0xf0
            L00AD: goto L0090;
            L00AF: ShowMessage(player, String0FB8); // The door refuses to budge.  You feel a mystical link between this door and some entity near here, one you have not yet defeated.
            L00BC: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L00D9: return; // RETURN;
        }

        private void Fn_31(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
29B4  0003 FF 76 08  push word [bp+0x8]
29B7  0006 FF 76 06  push word [bp+0x6]
29BA  0009 0E     push cs
29BB  000A E8 18 D8  call 0xd825
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: Compare(GetFlag(player, 0x02, 0x47), 0x0001);
            L0023: if (JumpNotEqual) goto L002A;
29D6  0025 B8 39 10  mov ax, 0x1039
            L0028: goto L004F;
            L002A: SetFlag(player, 0x02, 0x47, 0x01);
            L003F: ShowMessage(player, String1097); // Something up above catches your eye.  You look up, and see your old friend Rory Applebush, the cheerful halfling you half expected to find juggling the Wyrd Sisters's eyeteeth, imbedded in the ceiling.
            L004C: ShowMessage(player, String1161); // The stone has melted, sealing him in, unretrievable.  He died in agony.  Nobody said this quest would be easy.  Nobody said it would be this hard, either.
            L0059: return; // RETURN;
        }

        private void Fn_32(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
2A10  0004 FF 76 08  push word [bp+0x8]
2A13  0007 FF 76 06  push word [bp+0x6]
2A16  000A 0E     push cs
2A17  000B E8 BC D7  call 0xd7ca
            L000E: cx = PopStack(player);
            L000F: cx = PopStack(player);
            L0010: RefreshCompareFlags(GetFlag(player, 0x03, 0x18));
            L0023: if (JumpEqual) goto L0028;
            L0025: goto L00AF;
            L0028: SetFlag(player, 0x03, 0x18, 0x01);
            L003D: ShowPortrait(player, 0x0029);
            L004A: si = GetFlag(player, 0x02, 0x48);
            L005D: si = si + 1;
            L005E: SetFlag(player, 0xC4, 0xB8, si);
            L0070: bx = si;
            L0072: bx = bx - 1;
            L0073: Compare(bx, 0x06);
            L0076: if (JumpAbove) goto L00A2;
            L0078: switch (bx) {
                case 0:
                    goto L007F;
                case 1:
                    goto L0084;
                case 2:
                    goto L0089;
                case 3:
                    goto L008E;
                case 4:
                    goto L0093;
                case 5:
                    goto L0098;
                case 6:
                    goto L009D;
            }
2A8B  007F B8 FC 11  mov ax, 0x11fc
            L0082: goto L00A5;
2A90  0084 B8 86 12  mov ax, 0x1286
            L0087: goto L00A5;
2A95  0089 B8 0C 13  mov ax, 0x130c
            L008C: goto L00A5;
2A9A  008E B8 CD 13  mov ax, 0x13cd
            L0091: goto L00A5;
2A9F  0093 B8 7F 14  mov ax, 0x147f
            L0096: goto L00A5;
2AA4  0098 B8 ED 14  mov ax, 0x14ed
            L009B: goto L00A5;
2AA9  009D B8 80 15  mov ax, 0x1580
            L00A0: goto L00A5;
            L00A2: ShowMessage(player, String1610); // 'I seek a way to free Rory's corpse.  At the least he deserves a decent burial.  But the dragon's flames were hot enough to melt the very stone.  I know not what Rory said, but it must have infuriated the wyrm!'
            L00AF: return; // RETURN (restoring si);
        }

    }
}
