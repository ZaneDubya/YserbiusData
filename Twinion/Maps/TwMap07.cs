#pragma warning disable
using System.Collections.Generic;
using XPT.WorldData;
using XPT.WorldData.Yserbius;

namespace XPT.Scripts.Twinion.Maps {
    class TwMap07 : AMapScripted {
        protected override int MapIndex => 7;
        protected override int RandomEncounterChance => 10;
        protected override int RandomEncounterExtraCount => 0;

        public TwMap07() {
            MapEvent01 = FnQUEENAEO_01;
            MapEvent02 = FnTOMAPONE_02;
            MapEvent03 = FnSTATUES_03;
            MapEvent04 = FnRIVER_04;
            MapEvent05 = FnFNTNNULL_05;
            MapEvent06 = FnREGPIT_06;
            MapEvent07 = FnXKEYDR_07;
            MapEvent08 = FnHINTEDDR_08;
            MapEvent09 = FnGETHINT_09;
            MapEvent0A = FnDESCRIP_0A;
            MapEvent0B = FnLABMESS_0B;
            MapEvent0C = FnROWAMES_0C;
            MapEvent0D = FnROWBMESS_0D;
            MapEvent0E = FnROWCMESS_0E;
            MapEvent0F = FnTXTART_0F;
            MapEvent10 = FnPATHMESS_10;
            MapEvent11 = FnFIREPIT_11;
            MapEvent12 = FnOWNRISK_12;
            MapEvent13 = FnGASTRAP_13;
            MapEvent14 = FnDARTTRAP_14;
            MapEvent15 = FnHANDWEAP_15;
            MapEvent16 = FnNOMAPS_16;
            MapEvent17 = FnFAKEDOOR_17;
            MapEvent18 = FnROTEONE_18;
            MapEvent19 = FnROTETWO_19;
            MapEvent1A = FnQUEENMES_1A;
            MapEvent1B = FnDESCRIPB_1B;
            MapEvent1C = FnGRUNTBAT_1C;
            MapEvent1D = FnSAILIRON_1D;
            MapEvent1E = FnGUARDS_1E;
            MapEvent1F = FnTOUGHBAT_1F;
            MapEvent20 = FnEZBAT_20;
            MapEvent21 = FnMEDBAT_21;
            MapEvent22 = FnREFEREE_22;
            MapEvent23 = FnNOMAPBAT_23;
            MapEvent24 = FnMONSTERA_24;
            MapEvent25 = FnMONSTERB_25;
            MapEvent26 = FnNPCCLUE_26;
            MapEvent27 = FnHEALALL_27;
            MapEvent28 = FnMANARST_28;
            MapEvent29 = FnPICONE_29;
            MapEvent2A = FnPICTWO_2A;
            MapEvent2B = FnPICTHREE_2B;
            MapEvent2C = FnPICFOUR_2C;
            MapEvent2D = FnPICFIVE_2D;
            MapEvent2E = FnPICSIX_2E;
            MapEvent2F = FnPICMESS_2F;
            MapEvent34 = FnRIVSPEC_34;
            MapEvent35 = FnMAPSMESS_35;
            MapEvent36 = FnTOMAIN_36;
            MapEvent37 = FnEOGTELE_37;
            MapEvent38 = FnEOGTWO_38;
            MapEvent39 = FnSPECPIT_39;
            MapEvent3A = FnSECRETDR_3A;
            MapEvent3B = FnDIDTHIS_3B;
            MapEvent3C = FnFIREBALL_3C;
            MapEvent3D = FnLORDGNOG_3D;
            MapEvent3E = FnLGFLAG_3E;
            MapEvent3F = FnTOSTART_3F;
        }
        
        // === Strings ================================================
        private const string String03FC = "You see an empty, cracked throne.";
        private const string String041E = "The Queen is no more.";
        private const string String0434 = "A magnificent queen stands before you.";
        private const string String045B = "Her beauty and strength awe all who see her, woman and man alike. This is Queen Aeowyn.";
        private const string String04B3 = "'My champions, a key awaits you at the palace exit. Use it at the ancient gateway east of the main entrance.";
        private const string String0520 = "Another portal will lead you to the depths of this volcano, where none has dared yet visit.";
        private const string String057C = "I require four pieces of an ancient map! I enjoin you with this task as a test of your loyalty.";
        private const string String05DC = "Reveal your purpose to no one! Go now! Seek the Kingdom of the Night Elves.";
        private const string String0628 = "I will meet you at your quest's end, that we may piece together the maps' meaning.'";
        private const string String067C = "With a royal wave of dismissal, Aeowyn weaves a spell of parting and vanishes.";
        private const string String06CB = "Queen Aeowyn must be off looking for clues.";
        private const string String06F7 = "This leads back to the Coliseum.";
        private const string String0718 = "The warm waters soothe your pains.";
        private const string String073B = "Elaborate fountains mark the entryway to Queen Aeowyn's throne room.";
        private const string String0780 = "You fall into a pit and are impaled on razor sharp spears.";
        private const string String07BB = "The Cross Key unlocks the door!";
        private const string String07DB = "The door's lock is marked with an X.";
        private const string String0800 = "You manage to find the marked stone the old thief mentioned. The door is now open.";
        private const string String0853 = "The stone must be here somewhere.";
        private const string String0875 = "Perhaps you are not skilled enough.";
        private const string String0899 = "Something seems out of place here, but you can't tell what.";
        private const string String08D5 = "The old thief has slipped away into the shadows.";
        private const string String0906 = "An old thief stands to greet you.";
        private const string String0928 = "'Hail! You seem a bit puzzled and a lot lost.";
        private const string String0956 = "There's a wall to the southeast of here.";
        private const string String097F = "There you'll find a stone that is marked with an ancient rune. Try detecting it to continue your way.'";
        private const string String09E6 = "The final problem!";
        private const string String09F9 = "There are short and long pathways to the Queen's chambers.";
        private const string String0A34 = "Each has its own reward. Only one need be solved to continue, but the more explored, the greater the rewards.";
        private const string String0AA2 = "The Queen's Hall of Records.";
        private const string String0ABF = "Studies on Nature and Science.";
        private const string String0ADE = "Classical.";
        private const string String0AE9 = "Irrelevant.";
        private const string String0AF5 = "This book is entitled -CHESS-. It mentions how one space on a board belongs to whatever piece lands on it and captures it.";
        private const string String0B70 = "Another CHESS book- Bishop then Knight then Rook is how you march to face the King.";
        private const string String0BC4 = "CHESS III- Changing from one piece to the next is the key to understanding the mastery of any arena.";
        private const string String0C29 = "You pull a large volume from the shelf and flip randomly through the pages.";
        private const string String0C75 = "Guttural curses and howls of agony from a battlefield to the east chill your bones.";
        private const string String0CC9 = "The fireball travels down the corridor and fizzles.";
        private const string String0CFD = "You launch a fireball across the chasm.";
        private const string String0D25 = "In seconds it turns back upon you!";
        private const string String0D48 = "The fireball flies over the chasm into darkness.";
        private const string String0D79 = "It then comes hurtling back at you, exploding before you can escape its wrath.";
        private const string String0DC8 = "You send a fireball hurtling across the chasm.";
        private const string String0DF7 = "The booming report of an explosion alerts you that some trigger has been switched.";
        private const string String0E4A = "A bridge extends out from this edge of the chasm, allowing you to proceed.";
        private const string String0E95 = "The walls and floors here are scorched and charred with magical fire.";
        private const string String0EDB = "Perhaps you can send some light across the chasm to see if any burning clues are visible.";
        private const string String0F35 = "The bridge you triggered earlier has now vanished.";
        private const string String0F68 = "'Travel through here at your own risk!' Signed-Lord Gnog.";
        private const string String0FA2 = "You set off a poisonous gas trap!";
        private const string String0FC4 = "Another trap is triggered, sending death darts tipped with poison showering down upon you.";
        private const string String101F = "You are unable to map this area.";
        private const string String1040 = "You could have sworn there was a door here a second ago.";
        private const string String1079 = "'Hail, Queen Aeowyn! All would-be champions, approach and report.'";
        private const string String10BC = "The air is thick with the stench of battle and death. This Arena overflows with those who would be the Queen's champions.";
        private const string String1136 = "An enormous Barbarian stands over his most recent kill. He turns and charges at you!";
        private const string String118B = "An ominous Wizard admires the fallen hero he just incinerated. He then fires a barrage of fireballs at you!";
        private const string String11F7 = "One of the Queen's Guards is here. 'No stealing!'";
        private const string String1229 = "I'm sure you'll obey his wish!!";
        private const string String1249 = "The Guard is much more agitated. 'Be off with you! I've no kindness towards loitering fools.'";
        private const string String12A7 = "'ENOUGH! I have had enough of you!'";
        private const string String12CB = "'GUARDS!!!!!'";
        private const string String12D9 = "A mob prepares to attack!";
        private const string String12F3 = "Young warriors leap at you!";
        private const string String130F = "A seasoned party launches an offensive!";
        private const string String1337 = "This place offers a vantage point of the entire combat field.";
        private const string String1375 = "The Master of Arms grins broadly as you enter.";
        private const string String13A4 = "'Here, look, see that? A wizard taking on a warrior!";
        private const string String13D9 = "If that knight were better trained, he'd have known not to challenge while his sword was in its sheath!'";
        private const string String1442 = "The thieves who inhabit this area spring upon you!";
        private const string String1475 = "Vicious beasts snarl at you.";
        private const string String1492 = "Some passing adventurers notice the slain beasts here. They then challenge you to combat.";
        private const string String14EC = "Corpses stripped of all possessions litter this area.";
        private const string String1522 = "Vicious panthers growl as you approach.";
        private const string String154A = "Oozing slime coats the carcasses on the floor. The slime rears up as you approach!";
        private const string String159D = "A slick, viscous fluid covers the area.";
        private const string String15C5 = "'These walls are trickery. You need advice from one wiser than I. Beware of the dark dungeon rooms, for they are impossible to map!!'";
        private const string String164B = "The magic of the cool waters heals your wounds.";
        private const string String167B = "The waters offer no refreshment.";
        private const string String169C = "The magic of the cool waters restores your mana.";
        private const string String16CD = "--Lord Galabryan III--";
        private const string String16E4 = "--King Leowyn--";
        private const string String16F4 = "--King Theowayen--";
        private const string String1707 = "--King Cleowyn--";
        private const string String1718 = "--Arnakkian Slowfoot--";
        private const string String172F = "  --Queen Aeowyn--";
        private const string String1742 = "--recently deceased--";
        private const string String1758 = "  Reserved for:";
        private const string String1768 = "Through here is the Corridor of Ancestry.";
        private const string String1792 = "The Queen's heritage shall not be forgotten.";
        private const string String17BF = "The waters become calm, allowing you to pass.";
        private const string String17ED = "A mystical force prevents you from moving freely, and sends you back to the floor.";
        private const string String1840 = "You are confused and disoriented in this pitch black room.  The torchlight is diffused by some murky smoke.";
        private const string String18AC = "This portal will take you to the main entrance.";
        private const string String18DC = "In a glass case by the door is the key promised you by the Queen.";
        private const string String191E = "Away! You cannot use this teleport!";
        private const string String1942 = "You may proceed.";
        private const string String1953 = "Onward you go to the next teleport.";
        private const string String1977 = "ALONE! ONLY ALONE MAY YOU PROCEED!!!";
        private const string String199C = "The trigger has released a drawbridge of sorts, allowing you to pass over the chasm.";
        private const string String19F1 = "You plummet to your death in the deep chasm.";
        private const string String1A1E = "You discern light seeping through the crack of a secret door!";
        private const string String1A5C = "You've conquered the chasm, I grant you your reward!";
        private const string String1A91 = "Well done! Did you enjoy the Hall of Ancestry!?!";
        private const string String1AC2 = "Impressive, how you managed to pass through the arena!";
        private const string String1AF9 = "The Gauntlet you ran was not as hard as some others!";
        private const string String1B2E = "Now, to my throne room, I will wait for you there!";
        private const string String1B61 = "The steaming fountain's waters offer a powerful source of energy.";
        private const string String1BA3 = "You are scalded by the burning waters.";
        private const string String1BCA = "An elderly wizard sits here, poring over books.";
        private const string String1BFA = "'We meet at last. My envoys have told me so much about you.";
        private const string String1C36 = "They've helped me keep track of your achievements and failures.";
        private const string String1C76 = "Have you enjoyed my traps? Ah, well, some do, some don't.";
        private const string String1CB0 = "Since you've found me, perhaps you'd like to try for a little revenge.";
        private const string String1CF7 = "Come! Let's get on with it.'";
        private const string String1D14 = "To the entrance of the palace.";
        
        // === Functions ================================================
        private void FnQUEENAEO_01(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0x20), 0x0001);
            L0017: if (JumpNotEqual) goto L002C;
            L0019: ShowMessage(player, String03FC); // You see an empty, cracked throne.
0029  0026 B8 1E 04  mov ax, 0x41e
            L0029: goto L00D4;
            L002C: Compare(GetFlag(player, 0x02, 0x21), 0x0001);
            L0040: if (JumpEqual) goto L0045;
            L0042: goto L00D1;
            L0045: ShowPortrait(player, 0x0015);
            L0052: ShowMessage(player, String0434); // A magnificent queen stands before you.
            L005F: ShowMessage(player, String045B); // Her beauty and strength awe all who see her, woman and man alike. This is Queen Aeowyn.
            L006C: ShowMessage(player, String04B3); // 'My champions, a key awaits you at the palace exit. Use it at the ancient gateway east of the main entrance.
            L0079: ShowMessage(player, String0520); // Another portal will lead you to the depths of this volcano, where none has dared yet visit.
            L0086: ShowMessage(player, String057C); // I require four pieces of an ancient map! I enjoin you with this task as a test of your loyalty.
            L0093: ShowMessage(player, String05DC); // Reveal your purpose to no one! Go now! Seek the Kingdom of the Night Elves.
            L00A0: ShowMessage(player, String0628); // I will meet you at your quest's end, that we may piece together the maps' meaning.'
            L00AD: ShowMessage(player, String067C); // With a royal wave of dismissal, Aeowyn weaves a spell of parting and vanishes.
            L00BA: SetFlag(player, 0x02, 0x21, 0x02);
            L00CF: goto L00DE;
            L00D1: ShowMessage(player, String06CB); // Queen Aeowyn must be off looking for clues.
            L00DE: return; // RETURN;
            // Extra data: 55 8B EC 33 C0 50 C4 5E 06 26 FF 5F 24 50 C4 5E 06 26 FF 5F 20 50 C4 5E 06 26 FF 5F 2C 83 C4 06 5D CB 
        }

        private void FnTOMAPONE_02(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String06F7); // This leads back to the Coliseum.
            L0010: TeleportParty(player, 0x03, 0x01, 0x7F, 0x03, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnSTATUES_03(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFloorPassable(player, 0x00, GetCurrentTile(player));
            L0017: return; // RETURN;
        }

        private void FnRIVER_04(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0718); // The warm waters soothe your pains.
            L0010: HealPlayer(player, GetMaxHits(player));
            L0021: return; // RETURN;
        }

        private void FnFNTNNULL_05(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0042);
            L0010: ShowMessage(player, String073B); // Elaborate fountains mark the entryway to Queen Aeowyn's throne room.
            L001D: return; // RETURN;
        }

        private void FnREGPIT_06(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0780); // You fall into a pit and are impaled on razor sharp spears.
            L0010: DamagePlayer(player, GetMaxHits(player));
            L0021: return; // RETURN;
        }

        private void FnXKEYDR_07(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0xF1);
            L0007: PushStack(player, ax);
01B8  0008 C4 5E 06  les bx, [bp+0x6]
01BB  000B 26 FF 5F 54  call far word [es:bx+0x54]
            L000F: cx = PopStack(player);
            L0010: cx = PopStack(player);
            L0011: RefreshCompareFlags(ax);
            L0013: if (JumpEqual) goto L0060;
            L0015: ShowMessage(player, String07BB); // The Cross Key unlocks the door!
            L0022: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0040: SetWallObject(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L005E: goto L0079;
            L0060: ShowMessage(player, String07DB); // The door's lock is marked with an X.
021D  006D FF 76 08  push word [bp+0x8]
0220  0070 FF 76 06  push word [bp+0x6]
0223  0073 0E     push cs
0224  0074 E8 BC FE  call 0xff33
            L0077: cx = PopStack(player);
            L0078: cx = PopStack(player);
            L0079: return; // RETURN;
        }

        private void FnHINTEDDR_08(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0x1D), 0x0001);
            L0017: if (JumpEqual) goto L001C;
            L0019: goto L00E2;
            L001C: Compare(HasUsedSkill(player, 0x0D), 0x0009);
            L002B: if (JumpNotBelow) goto L0085;
            L002D: RefreshCompareFlags(HasUsedSpell(player, 0x17));
            L003B: if (JumpNotEqual) goto L0085;
            L003D: PushStack(player, 0x68);
            L0041: PushStack(player, ax);
026D  0042 C4 5E 06  les bx, [bp+0x6]
0270  0045 26 FF 5F 54  call far word [es:bx+0x54]
            L0049: cx = PopStack(player);
            L004A: cx = PopStack(player);
            L004B: RefreshCompareFlags(ax);
            L004D: if (JumpNotEqual) goto L0085;
            L004F: PushStack(player, 0x6E);
            L0053: PushStack(player, ax);
027F  0054 C4 5E 06  les bx, [bp+0x6]
0282  0057 26 FF 5F 54  call far word [es:bx+0x54]
            L005B: cx = PopStack(player);
            L005C: cx = PopStack(player);
            L005D: RefreshCompareFlags(ax);
            L005F: if (JumpNotEqual) goto L0085;
            L0061: PushStack(player, 0x90);
            L0065: PushStack(player, ax);
0291  0066 C4 5E 06  les bx, [bp+0x6]
0294  0069 26 FF 5F 54  call far word [es:bx+0x54]
            L006D: cx = PopStack(player);
            L006E: cx = PopStack(player);
            L006F: RefreshCompareFlags(ax);
            L0071: if (JumpNotEqual) goto L0085;
            L0073: PushStack(player, 0xA4);
            L0077: PushStack(player, ax);
02A3  0078 C4 5E 06  les bx, [bp+0x6]
02A6  007B 26 FF 5F 54  call far word [es:bx+0x54]
            L007F: cx = PopStack(player);
            L0080: cx = PopStack(player);
            L0081: RefreshCompareFlags(ax);
            L0083: if (JumpEqual) goto L00D0;
            L0085: ShowMessage(player, String0800); // You manage to find the marked stone the old thief mentioned. The door is now open.
            L0092: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L00B0: SetWallObject(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L00CE: goto L00FB;
            L00D0: ShowMessage(player, String0853); // The stone must be here somewhere.
0308  00DD B8 75 08  mov ax, 0x875
            L00E0: goto L00E5;
            L00E2: ShowMessage(player, String0899); // Something seems out of place here, but you can't tell what.
031A  00EF FF 76 08  push word [bp+0x8]
031D  00F2 FF 76 06  push word [bp+0x6]
0320  00F5 0E     push cs
0321  00F6 E8 BF FD  call 0xfeb8
            L00F9: cx = PopStack(player);
            L00FA: cx = PopStack(player);
            L00FB: return; // RETURN;
        }

        private void FnGETHINT_09(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0x1D), 0x0001);
            L0017: if (JumpNotEqual) goto L0028;
            L0019: ShowMessage(player, String08D5); // The old thief has slipped away into the shadows.
            L0026: goto L007E;
            L0028: ShowPortrait(player, 0x0022);
            L0035: ShowMessage(player, String0906); // An old thief stands to greet you.
            L0042: ShowMessage(player, String0928); // 'Hail! You seem a bit puzzled and a lot lost.
            L004F: ShowMessage(player, String0956); // There's a wall to the southeast of here.
            L005C: ShowMessage(player, String097F); // There you'll find a stone that is marked with an ancient rune. Try detecting it to continue your way.'
            L0069: SetFlag(player, 0x02, 0x1D, 0x01);
            L007E: return; // RETURN;
        }

        private void FnDESCRIP_0A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String09E6); // The final problem!
            L0010: ShowMessage(player, String09F9); // There are short and long pathways to the Queen's chambers.
            L001D: ShowMessage(player, String0A34); // Each has its own reward. Only one need be solved to continue, but the more explored, the greater the rewards.
            L002A: return; // RETURN;
        }

        private void FnLABMESS_0B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowRunes(player, String0AA2); // The Queen's Hall of Records.
            L0010: return; // RETURN;
        }

        private void FnROWAMES_0C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowRunes(player, String0ABF); // Studies on Nature and Science.
            L0010: return; // RETURN;
        }

        private void FnROWBMESS_0D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowRunes(player, String0ADE); // Classical.
            L0010: return; // RETURN;
        }

        private void FnROWCMESS_0E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowRunes(player, String0AE9); // Irrelevant.
            L0010: return; // RETURN;
        }

        private void FnTXTART_0F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: // make space for tmp on stack: sp -= 2
            L0005: ax = GetCurrentTile(player);
0428  000C 89 46 FE  mov [bp-0x2], ax
042B  000F B9 06 00  mov cx, 0x6
            L0012: bx = 0x04B9;
0431  0015 2E 8B 07  mov ax, [cs:bx]
0434  0018 3B 46 FE  cmp ax, [bp-0x2]
            L001B: if (JumpEqual) goto L0023;
0439  001D 43     inc bx
043A  001E 43     inc bx
043B  001F E2 F4  loop 0x15
            L0021: goto L0099;
043F  0023 2E FF 67 0C  jmp word [cs:bx+0xc]
            L0027: Compare(GetFacing(player), 0x0003);
            L0031: if (JumpNotEqual) goto L0099;
            L0033: goto L008C;
            L0035: Compare(GetFacing(player), 0x0001);
            L003F: if (JumpNotEqual) goto L0099;
            L0041: ShowRunes(player, String0AF5); // This book is entitled -CHESS-. It mentions how one space on a board belongs to whatever piece lands on it and captures it.
            L004E: goto L0099;
            L0050: Compare(GetFacing(player), 0x0001);
            L005A: if (JumpNotEqual) goto L0099;
0478  005C B8 70 0B  mov ax, 0xb70
            L005F: goto L0044;
            L0061: Compare(GetFacing(player), 0x0003);
            L006B: if (JumpNotEqual) goto L0099;
            L006D: goto L008C;
            L006F: Compare(GetFacing(player), 0x0001);
            L0079: if (JumpNotEqual) goto L0099;
0497  007B B8 C4 0B  mov ax, 0xbc4
            L007E: goto L0044;
            L0080: Compare(GetFacing(player), 0x0003);
            L008A: if (JumpNotEqual) goto L0099;
            L008C: XCall Fn00B5
            L0097: cx = PopStack(player);
            L0098: cx = PopStack(player);
            L0099: // restore stack ptr: sp = bp;
            L009B: return; // RETURN;
            // Extra data: 11 00 12 00 21 00 22 00 31 00 32 00 8B 04 9C 04 7D 04 6C 04 43 04 51 04 55 8B EC B8 29 0C 50 C4 5E 06 26 FF 9F F8 00 59 5D CB 
        }

        private void FnPATHMESS_10(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0C75); // Guttural curses and howls of agony from a battlefield to the east chill your bones.
            L0010: return; // RETURN;
        }

        private void FnFIREPIT_11(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: // make space for tmp on stack: sp -= 2
            L0005: RefreshCompareFlags(GetFlag(player, 0x02, 0x1E));
            L0018: if (JumpEqual) goto L001D;
            L001A: goto L01CB;
            L001D: PushStack(player, 0x0F);
            L0021: PushStack(player, ax);
0517  0022 C4 5E 06  les bx, [bp+0x6]
051A  0025 26 FF 5F 54  call far word [es:bx+0x54]
            L0029: cx = PopStack(player);
            L002A: cx = PopStack(player);
            L002B: RefreshCompareFlags(ax);
            L002D: if (JumpEqual) goto L0032;
            L002F: goto L00C8;
            L0032: PushStack(player, 0x05);
            L0036: PushStack(player, ax);
052C  0037 C4 5E 06  les bx, [bp+0x6]
052F  003A 26 FF 5F 54  call far word [es:bx+0x54]
            L003E: cx = PopStack(player);
            L003F: cx = PopStack(player);
            L0040: RefreshCompareFlags(ax);
            L0042: if (JumpEqual) goto L0047;
            L0044: goto L00C8;
            L0047: PushStack(player, 0x27);
            L004B: PushStack(player, ax);
0541  004C C4 5E 06  les bx, [bp+0x6]
0544  004F 26 FF 5F 54  call far word [es:bx+0x54]
            L0053: cx = PopStack(player);
            L0054: cx = PopStack(player);
            L0055: RefreshCompareFlags(ax);
            L0057: if (JumpNotEqual) goto L00C8;
            L0059: PushStack(player, 0x36);
            L005D: PushStack(player, ax);
0553  005E C4 5E 06  les bx, [bp+0x6]
0556  0061 26 FF 5F 54  call far word [es:bx+0x54]
            L0065: cx = PopStack(player);
            L0066: cx = PopStack(player);
            L0067: RefreshCompareFlags(ax);
            L0069: if (JumpNotEqual) goto L00C8;
            L006B: PushStack(player, 0x47);
            L006F: PushStack(player, ax);
0565  0070 C4 5E 06  les bx, [bp+0x6]
0568  0073 26 FF 5F 54  call far word [es:bx+0x54]
            L0077: cx = PopStack(player);
            L0078: cx = PopStack(player);
            L0079: RefreshCompareFlags(ax);
            L007B: if (JumpNotEqual) goto L00C8;
            L007D: PushStack(player, 0x55);
            L0081: PushStack(player, ax);
0577  0082 C4 5E 06  les bx, [bp+0x6]
057A  0085 26 FF 5F 54  call far word [es:bx+0x54]
            L0089: cx = PopStack(player);
            L008A: cx = PopStack(player);
            L008B: RefreshCompareFlags(ax);
            L008D: if (JumpNotEqual) goto L00C8;
            L008F: PushStack(player, 0x92);
            L0093: PushStack(player, ax);
0589  0094 C4 5E 06  les bx, [bp+0x6]
058C  0097 26 FF 5F 54  call far word [es:bx+0x54]
            L009B: cx = PopStack(player);
            L009C: cx = PopStack(player);
            L009D: RefreshCompareFlags(ax);
            L009F: if (JumpNotEqual) goto L00C8;
            L00A1: PushStack(player, 0x9F);
            L00A5: PushStack(player, ax);
059B  00A6 C4 5E 06  les bx, [bp+0x6]
059E  00A9 26 FF 5F 54  call far word [es:bx+0x54]
            L00AD: cx = PopStack(player);
            L00AE: cx = PopStack(player);
            L00AF: RefreshCompareFlags(ax);
            L00B1: if (JumpNotEqual) goto L00C8;
            L00B3: PushStack(player, 0xAF);
            L00B7: PushStack(player, ax);
05AD  00B8 C4 5E 06  les bx, [bp+0x6]
05B0  00BB 26 FF 5F 54  call far word [es:bx+0x54]
            L00BF: cx = PopStack(player);
            L00C0: cx = PopStack(player);
            L00C1: RefreshCompareFlags(ax);
            L00C3: if (JumpNotEqual) goto L00C8;
            L00C5: goto L01B8;
            L00C8: ax = GetCurrentTile(player);
05C4  00CF 89 46 FE  mov [bp-0x2], ax
05C7  00D2 B9 04 00  mov cx, 0x4
            L00D5: bx = 0x06F6;
05CD  00D8 2E 8B 07  mov ax, [cs:bx]
05D0  00DB 3B 46 FE  cmp ax, [bp-0x2]
            L00DE: if (JumpEqual) goto L00E7;
05D5  00E0 43     inc bx
05D6  00E1 43     inc bx
05D7  00E2 E2 F4  loop 0xd8
            L00E4: goto L01FD;
05DC  00E7 2E FF 67 08  jmp word [cs:bx+0x8]
            L00EB: ShowMessage(player, String0CC9); // The fireball travels down the corridor and fizzles.
            L00F8: goto L01FD;
            L00FB: ShowMessage(player, String0CFD); // You launch a fireball across the chasm.
            L0108: ShowMessage(player, String0D25); // In seconds it turns back upon you!
            L0115: ax = GetCurrentHits(player);
            L011C: bx = 0x0006;
            L011F: dx = ax % bx; ax = ax / bx;
            L0122: DamagePlayer(player, ax);
            L012C: goto L01FD;
            L012F: ShowMessage(player, String0D48); // The fireball flies over the chasm into darkness.
            L013C: ShowMessage(player, String0D79); // It then comes hurtling back at you, exploding before you can escape its wrath.
            L0149: ax = GetMaxHits(player);
            L0150: bx = 0x0008;
            L0153: dx = ax % bx; ax = ax / bx;
            L0156: DamagePlayer(player, ax);
            L0160: goto L01FD;
            L0163: ShowMessage(player, String0DC8); // You send a fireball hurtling across the chasm.
            L0170: ShowMessage(player, String0DF7); // The booming report of an explosion alerts you that some trigger has been switched.
            L017D: ShowMessage(player, String0E4A); // A bridge extends out from this edge of the chasm, allowing you to proceed.
            L018A: SetFlag(player, 0x02, 0x1E, 0x01);
            L019F: SetFloorPassable(player, 0x2A, 0x01);
            L01B0: PushStack(player, 0x2A);
06A9  01B4 33 C0  xor ax, ax
            L01B6: goto L01F3;
            L01B8: ShowMessage(player, String0E95); // The walls and floors here are scorched and charred with magical fire.
06BA  01C5 B8 DB 0E  mov ax, 0xedb
            L01C8: goto L00EE;
            L01CB: ShowMessage(player, String0F35); // The bridge you triggered earlier has now vanished.
            L01D8: SetFlag(player, 0x02, 0x1E, 0x00);
            L01EC: SetFloorObject(player, 0x01, 0x2A);
            L01FD: // restore stack ptr: sp = bp;
            L01FF: return; // RETURN;
            // Extra data: 09 00 18 00 19 00 29 00 E0 05 F0 05 24 06 58 06 
        }

        private void FnOWNRISK_12(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0F68); // 'Travel through here at your own risk!' Signed-Lord Gnog.
            L0010: return; // RETURN;
        }

        private void FnGASTRAP_13(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x01);
            L0007: PushStack(player, 0x00);
0722  000A C4 5E 06  les bx, [bp+0x6]
0725  000D 26 FF 5F 04  call far word [es:bx+0x4]
            L0011: cx = PopStack(player);
            L0012: cx = PopStack(player);
            L0013: RefreshCompareFlags(ax);
            L0015: if (JumpNotEqual) goto L0048;
            L0017: ShowMessage(player, String0FA2); // You set off a poisonous gas trap!
            L0024: PushStack(player, 0x46);
            L0028: PushStack(player, 0x08);
            L002C: PushStack(player, 0x01);
0748  0030 C4 5E 06  les bx, [bp+0x6]
074B  0033 26 FF 9F 9C 00  call far word [es:bx+0x9c]
0750  0038 83 C4 06  add sp, 0x6
            L003B: XCall Fn00B0
            L0046: cx = PopStack(player);
            L0047: cx = PopStack(player);
            L0048: return; // RETURN;
        }

        private void FnDARTTRAP_14(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x01);
            L0007: PushStack(player, 0x00);
076C  000A C4 5E 06  les bx, [bp+0x6]
076F  000D 26 FF 5F 04  call far word [es:bx+0x4]
            L0011: cx = PopStack(player);
            L0012: cx = PopStack(player);
            L0013: RefreshCompareFlags(ax);
            L0015: if (JumpNotEqual) goto L005F;
            L0017: ShowMessage(player, String0FC4); // Another trap is triggered, sending death darts tipped with poison showering down upon you.
            L0024: PushStack(player, 0x3C);
            L0028: PushStack(player, 0x05);
            L002C: PushStack(player, 0x01);
0792  0030 C4 5E 06  les bx, [bp+0x6]
0795  0033 26 FF 9F 9C 00  call far word [es:bx+0x9c]
079A  0038 83 C4 06  add sp, 0x6
            L003B: ax = GetCurrentHits(player);
            L0042: bx = 0x0006;
            L0045: dx = ax % bx; ax = ax / bx;
            L0048: DamagePlayer(player, ax);
            L0052: XCall Fn0066
            L005D: cx = PopStack(player);
            L005E: cx = PopStack(player);
            L005F: return; // RETURN;
        }

        private void FnHANDWEAP_15(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: return; // RETURN;
            // Extra data: 55 8B EC B8 01 00 50 50 33 C0 50 C4 5E 06 26 FF 1F 83 C4 06 5D CB 
        }

        private void FnNOMAPS_16(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
07E1  0003 C4 5E 06  les bx, [bp+0x6]
07E4  0006 26 FF 9F E8 00  call far word [es:bx+0xe8]
            L000B: ShowMessage(player, String101F); // You are unable to map this area.
            L0018: return; // RETURN;
        }

        private void FnFAKEDOOR_17(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1040); // You could have sworn there was a door here a second ago.
0808  0010 FF 76 08  push word [bp+0x8]
080B  0013 FF 76 06  push word [bp+0x6]
080E  0016 0E     push cs
080F  0017 E8 D1 F8  call 0xf8eb
            L001A: cx = PopStack(player);
            L001B: cx = PopStack(player);
            L001C: SetWallObject(player, 0x00, GetCurrentTile(player), GetFacing(player));
            L0039: return; // RETURN;
        }

        private void FnROTEONE_18(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x01);
            L0007: PushStack(player, 0x00);
083D  000A C4 5E 06  les bx, [bp+0x6]
0840  000D 26 FF 5F 04  call far word [es:bx+0x4]
            L0011: cx = PopStack(player);
            L0012: cx = PopStack(player);
            L0013: RefreshCompareFlags(ax);
            L0015: if (JumpNotEqual) goto L0050;
            L0017: bx = GetFacing(player);
            L0020: Compare(bx, 0x03);
            L0023: if (JumpAbove) goto L0050;
            L0025: switch (bx) {
                case 0:
                    goto L0037;
                case 1:
                    goto L0030;
                case 2:
                    goto L0032;
                case 3:
                    goto L002C;
            }
085F  002C 33 C0  xor ax, ax
            L002E: goto L003A;
            L0030: goto L0037;
0865  0032 B8 01 00  mov ax, 0x1
            L0035: goto L003A;
            L0037: PushStack(player, 0x02);
086E  003B C4 5E 06  les bx, [bp+0x6]
0871  003E 26 FF 9F CC 00  call far word [es:bx+0xcc]
            L0043: cx = PopStack(player);
0877  0044 FF 76 08  push word [bp+0x8]
087A  0047 FF 76 06  push word [bp+0x6]
087D  004A 0E     push cs
087E  004B E8 47 FF  call 0xff95
            L004E: cx = PopStack(player);
            L004F: cx = PopStack(player);
            L0050: return; // RETURN;
        }

        private void FnROTETWO_19(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x01);
            L0007: PushStack(player, 0x00);
0897  000A C4 5E 06  les bx, [bp+0x6]
089A  000D 26 FF 5F 04  call far word [es:bx+0x4]
            L0011: cx = PopStack(player);
            L0012: cx = PopStack(player);
            L0013: RefreshCompareFlags(ax);
            L0015: if (JumpNotEqual) goto L0053;
            L0017: bx = GetFacing(player);
            L0020: Compare(bx, 0x03);
            L0023: if (JumpAbove) goto L0053;
            L0025: switch (bx) {
                case 0:
                    goto L003A;
                case 1:
                    goto L0031;
                case 2:
                    goto L0035;
                case 3:
                    goto L002C;
            }
08B9  002C B8 01 00  mov ax, 0x1
            L002F: goto L003D;
08BE  0031 33 C0  xor ax, ax
            L0033: goto L003D;
08C2  0035 B8 03 00  mov ax, 0x3
            L0038: goto L003D;
            L003A: PushStack(player, 0x02);
08CB  003E C4 5E 06  les bx, [bp+0x6]
08CE  0041 26 FF 9F CC 00  call far word [es:bx+0xcc]
            L0046: cx = PopStack(player);
08D4  0047 FF 76 08  push word [bp+0x8]
08D7  004A FF 76 06  push word [bp+0x6]
08DA  004D 0E     push cs
08DB  004E E8 EA FE  call 0xff3b
            L0051: cx = PopStack(player);
            L0052: cx = PopStack(player);
            L0053: return; // RETURN;
        }

        private void FnQUEENMES_1A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1079); // 'Hail, Queen Aeowyn! All would-be champions, approach and report.'
            L0010: return; // RETURN;
        }

        private void FnDESCRIPB_1B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String10BC); // The air is thick with the stench of battle and death. This Arena overflows with those who would be the Queen's champions.
            L0010: return; // RETURN;
        }

        private void FnGRUNTBAT_1C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1136); // An enormous Barbarian stands over his most recent kill. He turns and charges at you!
            L0010: AddEncounter(player, 0x01, 0x23);
            L0022: return; // RETURN;
        }

        private void FnSAILIRON_1D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String118B); // An ominous Wizard admires the fallen hero he just incinerated. He then fires a barrage of fireballs at you!
            L0010: ax = GetCurrentHits(player);
            L0017: bx = 0x0006;
            L001A: dx = ax % bx; ax = ax / bx;
            L001D: DamagePlayer(player, ax);
            L0027: AddEncounter(player, 0x01, 0x24);
            L0039: return; // RETURN;
        }

        private void FnGUARDS_1E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: RefreshCompareFlags(GetFlag(player, 0x03, 0x05));
            L0017: if (JumpNotEqual) goto L0046;
            L0019: ShowPortrait(player, 0x001C);
            L0026: ShowMessage(player, String11F7); // One of the Queen's Guards is here. 'No stealing!'
            L0033: ShowMessage(player, String1229); // I'm sure you'll obey his wish!!
09AD  0040 B8 01 00  mov ax, 0x1
            L0043: goto L00CD;
            L0046: Compare(GetFlag(player, 0x03, 0x05), 0x0001);
            L005A: if (JumpNotEqual) goto L007B;
            L005C: ShowPortrait(player, 0x001C);
            L0069: ShowMessage(player, String1249); // The Guard is much more agitated. 'Be off with you! I've no kindness towards loitering fools.'
09E3  0076 B8 02 00  mov ax, 0x2
            L0079: goto L00CD;
            L007B: ShowMessage(player, String12A7); // 'ENOUGH! I have had enough of you!'
            L0088: ShowMessage(player, String12CB); // 'GUARDS!!!!!'
            L0095: PushStack(player, 0x00);
            L0098: PushStack(player, ax);
            L0099: PushStack(player, ax);
            L009A: PushStack(player, 0xB6);
            L009E: PushStack(player, 0x43);
            L00A2: PushStack(player, 0x03);
0A13  00A6 C4 5E 06  les bx, [bp+0x6]
0A16  00A9 26 FF 9F D8 00  call far word [es:bx+0xd8]
0A1B  00AE 83 C4 0C  add sp, 0xc
            L00B1: si = 0x0001;
            L00B4: goto L00C6;
            L00B6: AddEncounter(player, si, 0x28);
            L00C5: si = si + 1;
            L00C6: Compare(si, 0x06);
            L00C9: if (JumpLessOrEqual) goto L00B6;
            L00CB: SetFlag(player, 0x03, 0x05, 0x00);
            L00DF: return; // RETURN (restoring si);
        }

        private void FnTOUGHBAT_1F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String12D9); // A mob prepares to attack!
            L0010: AddEncounter(player, 0x01, 0x0A);
            L0022: AddEncounter(player, 0x02, 0x0B);
            L0034: AddEncounter(player, 0x03, 0x14);
            L0046: AddEncounter(player, 0x04, 0x11);
            L0058: AddEncounter(player, 0x05, 0x21);
            L006A: AddEncounter(player, 0x06, 0x21);
            L007C: return; // RETURN;
        }

        private void FnEZBAT_20(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String12F3); // Young warriors leap at you!
            L0010: AddEncounter(player, 0x01, 0x1F);
            L0022: AddEncounter(player, 0x02, 0x20);
            L0034: AddEncounter(player, 0x03, 0x1F);
            L0046: AddEncounter(player, 0x04, 0x20);
            L0058: return; // RETURN;
        }

        private void FnMEDBAT_21(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String130F); // A seasoned party launches an offensive!
            L0010: AddEncounter(player, 0x01, 0x19);
            L0022: AddEncounter(player, 0x02, 0x1A);
            L0034: AddEncounter(player, 0x03, 0x1B);
            L0046: AddEncounter(player, 0x04, 0x1C);
            L0058: AddEncounter(player, 0x05, 0x1D);
            L006A: AddEncounter(player, 0x06, 0x1E);
            L007C: return; // RETURN;
        }

        private void FnREFEREE_22(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x001C);
            L0010: ShowMessage(player, String1337); // This place offers a vantage point of the entire combat field.
            L001D: ShowMessage(player, String1375); // The Master of Arms grins broadly as you enter.
            L002A: ShowMessage(player, String13A4); // 'Here, look, see that? A wizard taking on a warrior!
            L0037: ShowMessage(player, String13D9); // If that knight were better trained, he'd have known not to challenge while his sword was in its sheath!'
            L0044: return; // RETURN;
        }

        private void FnNOMAPBAT_23(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0BEE  0003 C4 5E 06  les bx, [bp+0x6]
0BF1  0006 26 FF 9F E8 00  call far word [es:bx+0xe8]
            L000B: ShowMessage(player, String1442); // The thieves who inhabit this area spring upon you!
            L0018: AddEncounter(player, 0x01, 0x20);
            L002A: AddEncounter(player, 0x02, 0x20);
            L003C: AddEncounter(player, 0x03, 0x1C);
            L004E: AddEncounter(player, 0x04, 0x1C);
            L0060: return; // RETURN;
        }

        private void FnMONSTERA_24(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: RefreshCompareFlags(GetFlag(player, 0x03, 0x01));
            L0017: if (JumpNotEqual) goto L006E;
            L0019: ShowMessage(player, String1475); // Vicious beasts snarl at you.
            L0026: Compare(PartyCount(player), 0x0003);
            L0031: if (JumpNotBelow) goto L004F;
            L0033: si = 0x0001;
            L0036: goto L0048;
            L0038: AddEncounter(player, si, 0x27);
            L0047: si = si + 1;
            L0048: Compare(si, 0x02);
            L004B: if (JumpLessOrEqual) goto L0038;
            L004D: goto L0069;
            L004F: si = 0x0001;
            L0052: goto L0064;
            L0054: AddEncounter(player, si, 0x27);
            L0063: si = si + 1;
            L0064: Compare(si, 0x05);
            L0067: if (JumpLessOrEqual) goto L0054;
0CB6  0069 B8 01 00  mov ax, 0x1
            L006C: goto L00DB;
            L006E: Compare(GetFlag(player, 0x03, 0x01), 0x0001);
            L0082: if (JumpNotEqual) goto L00CC;
            L0084: ShowMessage(player, String1492); // Some passing adventurers notice the slain beasts here. They then challenge you to combat.
            L0091: PushStack(player, 0xFA);
            L0095: PushStack(player, 0x00);
            L0098: PushStack(player, ax);
            L0099: PushStack(player, ax);
            L009A: PushStack(player, 0xB5);
            L009E: PushStack(player, 0x08);
0CEF  00A2 C4 5E 06  les bx, [bp+0x6]
0CF2  00A5 26 FF 9F D8 00  call far word [es:bx+0xd8]
0CF7  00AA 83 C4 0C  add sp, 0xc
            L00AD: si = 0x0001;
            L00B0: goto L00C2;
            L00B2: AddEncounter(player, si, 0x24);
            L00C1: si = si + 1;
            L00C2: Compare(si, 0x04);
            L00C5: if (JumpLessOrEqual) goto L00B2;
0D14  00C7 B8 02 00  mov ax, 0x2
            L00CA: goto L00DB;
            L00CC: ShowMessage(player, String14EC); // Corpses stripped of all possessions litter this area.
            L00D9: SetFlag(player, 0x03, 0x01, 0x00);
            L00ED: return; // RETURN (restoring si);
        }

        private void FnMONSTERB_25(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: RefreshCompareFlags(GetFlag(player, 0x03, 0x02));
            L0017: if (JumpNotEqual) goto L0045;
            L0019: ShowMessage(player, String1522); // Vicious panthers growl as you approach.
            L0026: si = 0x0001;
            L0029: goto L003B;
            L002B: AddEncounter(player, si, 0x26);
            L003A: si = si + 1;
            L003B: Compare(si, 0x04);
            L003E: if (JumpLessOrEqual) goto L002B;
0D7D  0040 B8 01 00  mov ax, 0x1
            L0043: goto L0096;
            L0045: Compare(GetFlag(player, 0x03, 0x02), 0x0001);
            L0059: if (JumpNotEqual) goto L0087;
            L005B: ShowMessage(player, String154A); // Oozing slime coats the carcasses on the floor. The slime rears up as you approach!
            L0068: si = 0x0001;
            L006B: goto L007D;
            L006D: AddEncounter(player, si, 0x25);
            L007C: si = si + 1;
            L007D: Compare(si, 0x04);
            L0080: if (JumpLessOrEqual) goto L006D;
0DBF  0082 B8 02 00  mov ax, 0x2
            L0085: goto L0096;
            L0087: ShowMessage(player, String159D); // A slick, viscous fluid covers the area.
            L0094: SetFlag(player, 0x03, 0x02, 0x00);
            L00A8: return; // RETURN (restoring si);
        }

        private void FnNPCCLUE_26(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0028);
            L0010: ShowMessage(player, String15C5); // 'These walls are trickery. You need advice from one wiser than I. Beware of the dark dungeon rooms, for they are impossible to map!!'
            L001D: return; // RETURN;
        }

        private void FnHEALALL_27(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: ShowPortrait(player, 0x0042);
            L0011: si = 0;
            L0013: PushStack(player, 0x03);
            L0017: PushStack(player, ax);
0E1F  0018 C4 5E 06  les bx, [bp+0x6]
0E22  001B 26 FF 5F 04  call far word [es:bx+0x4]
            L001F: cx = PopStack(player);
            L0020: cx = PopStack(player);
            L0021: Compare(ax, 0x0003);
            L0024: if (JumpNotBelow) goto L0069;
            L0026: si = GetFlag(player, 0x03, 0x04);
            L0039: ShowMessage(player, String164B); // The magic of the cool waters heals your wounds.
            L0046: HealPlayer(player, GetMaxHits(player));
            L0057: si = si + 1;
0E5F  0058 56     push si
            L0059: PushStack(player, 0x03);
            L005D: PushStack(player, ax);
0E65  005E C4 5E 06  les bx, [bp+0x6]
0E68  0061 26 FF 1F  call far word [es:bx]
0E6B  0064 83 C4 06  add sp, 0x6
            L0067: goto L0076;
            L0069: ShowMessage(player, String167B); // The waters offer no refreshment.
            L0076: return; // RETURN (restoring si);
        }

        private void FnMANARST_28(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: ShowPortrait(player, 0x0042);
            L0011: si = 0;
            L0013: Compare(GetFlag(player, 0x03, 0x04), 0x0003);
            L0027: if (JumpNotBelow) goto L006B;
            L0029: si = GetFlag(player, 0x03, 0x04);
            L003C: ShowMessage(player, String169C); // The magic of the cool waters restores your mana.
            L0049: AddMana(player, 0x03E8);
            L0056: si = si + 1;
            L0057: SetFlag(player, 0xC4, 0xB8, si);
            L0069: goto L0078;
            L006B: ShowMessage(player, String167B); // The waters offer no refreshment.
            L0078: return; // RETURN (restoring si);
        }

        private void FnPICONE_29(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0019);
            L0010: ShowMessage(player, String16CD); // --Lord Galabryan III--
            L001D: return; // RETURN;
        }

        private void FnPICTWO_2A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x001C);
            L0010: ShowMessage(player, String16E4); // --King Leowyn--
            L001D: return; // RETURN;
        }

        private void FnPICTHREE_2B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0016);
            L0010: ShowMessage(player, String16F4); // --King Theowayen--
            L001D: return; // RETURN;
        }

        private void FnPICFOUR_2C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x001C);
            L0010: ShowMessage(player, String1707); // --King Cleowyn--
            L001D: return; // RETURN;
        }

        private void FnPICFIVE_2D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x002B);
            L0010: ShowMessage(player, String1718); // --Arnakkian Slowfoot--
            L001D: return; // RETURN;
        }

        private void FnPICSIX_2E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0x20), 0x0001);
            L0017: if (JumpNotEqual) goto L0038;
            L0019: ShowPortrait(player, 0x0015);
            L0026: ShowMessage(player, String172F); //   --Queen Aeowyn--
0FC9  0033 B8 42 17  mov ax, 0x1742
            L0036: goto L0048;
            L0038: ShowMessage(player, String1758); //   Reserved for:
            L0045: ShowMessage(player, String1731);
            L0052: return; // RETURN;
        }

        private void FnPICMESS_2F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1768); // Through here is the Corridor of Ancestry.
            L0010: ShowMessage(player, String1792); // The Queen's heritage shall not be forgotten.
            L001D: return; // RETURN;
        }

        private void FnRIVSPEC_34(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0x21), 0x0002);
            L0017: if (JumpNotEqual) goto L0028;
            L0019: ShowMessage(player, String17BF); // The waters become calm, allowing you to pass.
            L0026: goto L0050;
            L0028: ShowMessage(player, String17ED); // A mystical force prevents you from moving freely, and sends you back to the floor.
            L0035: TeleportParty(player, 0x03, 0x02, 0x8E, 0x02, isForwardMove);
            L0050: return; // RETURN;
        }

        private void FnMAPSMESS_35(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1840); // You are confused and disoriented in this pitch black room.  The torchlight is diffused by some murky smoke.
            L0010: ShowMessage(player, String101F); // You are unable to map this area.
108C  001D C4 5E 06  les bx, [bp+0x6]
108F  0020 26 FF 9F E8 00  call far word [es:bx+0xe8]
            L0025: return; // RETURN;
        }

        private void FnTOMAIN_36(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0x21), 0x0002);
            L0017: if (JumpNotEqual) goto L007F;
            L0019: ShowMessage(player, String18AC); // This portal will take you to the main entrance.
            L0026: ax = HasItem(player, 0xEA);
            L0034: if (JumpNotEqual) goto L004A;
            L0036: RefreshCompareFlags(GetFlag(player, 0x02, 0x00));
            L0048: if (JumpEqual) goto L0064;
            L004A: PushStack(player, 0x02);
            L004E: PushStack(player, 0xCC);
            L0052: PushStack(player, 0x01);
            L0056: PushStack(player, ax);
10ED  0057 C4 5E 06  les bx, [bp+0x6]
10F0  005A 26 FF 9F BC 00  call far word [es:bx+0xbc]
10F5  005F 83 C4 08  add sp, 0x8
            L0062: goto L008C;
            L0064: ShowMessage(player, String18DC); // In a glass case by the door is the key promised you by the Queen.
            L0071: GiveItem(player, 0xEA);
            L007D: goto L004A;
            L007F: ShowMessage(player, String191E); // Away! You cannot use this teleport!
            L008C: return; // RETURN;
        }

        private void FnEOGTELE_37(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0xDF), 0x0001);
            L0017: if (JumpNotEqual) goto L004E;
            L0019: Compare(PartyCount(player), 0x0001);
            L0024: if (JumpNotEqual) goto L004E;
            L0026: ShowMessage(player, String1942); // You may proceed.
            L0033: TeleportParty(player, 0x03, 0x02, 0xBD, 0x02, isForwardMove);
            L004E: return; // RETURN;
        }

        private void FnEOGTWO_38(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L002D;
            L0010: ShowMessage(player, String1953); // Onward you go to the next teleport.
            L001D: PushStack(player, 0x01);
            L0021: PushStack(player, 0x00);
            L0024: PushStack(player, 0x03);
119C  0028 B8 04 00  mov ax, 0x4
            L002B: goto L005F;
            L002D: ShowMessage(player, String1977); // ALONE! ONLY ALONE MAY YOU PROCEED!!!
            L003A: ax = GetMaxHits(player);
            L0041: bx = 0x0002;
            L0044: dx = ax % bx; ax = ax / bx;
            L0047: DamagePlayer(player, ax);
            L0051: TeleportParty(player, 0x03, 0x02, 0x8E, 0x00, isForwardMove);
            L006B: return; // RETURN;
        }

        private void FnSPECPIT_39(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0x1E), 0x0001);
            L0017: if (JumpNotEqual) goto L0049;
            L0019: ShowMessage(player, String199C); // The trigger has released a drawbridge of sorts, allowing you to pass over the chasm.
            L0026: SetFloorPassable(player, 0x2A, 0x01);
            L0037: SetFloorObject(player, 0x00, 0x2A);
            L0047: goto L0067;
            L0049: ShowMessage(player, String19F1); // You plummet to your death in the deep chasm.
            L0056: DamagePlayer(player, GetMaxHits(player));
            L0067: return; // RETURN;
        }

        private void FnSECRETDR_3A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, 0x0D), 0x0009);
            L0012: if (JumpNotBelow) goto L006C;
            L0014: RefreshCompareFlags(HasUsedSpell(player, 0x17));
            L0022: if (JumpNotEqual) goto L006C;
            L0024: PushStack(player, 0x68);
            L0028: PushStack(player, ax);
1273  0029 C4 5E 06  les bx, [bp+0x6]
1276  002C 26 FF 5F 54  call far word [es:bx+0x54]
            L0030: cx = PopStack(player);
            L0031: cx = PopStack(player);
            L0032: RefreshCompareFlags(ax);
            L0034: if (JumpNotEqual) goto L006C;
            L0036: PushStack(player, 0x6E);
            L003A: PushStack(player, ax);
1285  003B C4 5E 06  les bx, [bp+0x6]
1288  003E 26 FF 5F 54  call far word [es:bx+0x54]
            L0042: cx = PopStack(player);
            L0043: cx = PopStack(player);
            L0044: RefreshCompareFlags(ax);
            L0046: if (JumpNotEqual) goto L006C;
            L0048: PushStack(player, 0x90);
            L004C: PushStack(player, ax);
1297  004D C4 5E 06  les bx, [bp+0x6]
129A  0050 26 FF 5F 54  call far word [es:bx+0x54]
            L0054: cx = PopStack(player);
            L0055: cx = PopStack(player);
            L0056: RefreshCompareFlags(ax);
            L0058: if (JumpNotEqual) goto L006C;
            L005A: PushStack(player, 0xA4);
            L005E: PushStack(player, ax);
12A9  005F C4 5E 06  les bx, [bp+0x6]
12AC  0062 26 FF 5F 54  call far word [es:bx+0x54]
            L0066: cx = PopStack(player);
            L0067: cx = PopStack(player);
            L0068: RefreshCompareFlags(ax);
            L006A: if (JumpEqual) goto L00B5;
            L006C: ShowMessage(player, String1A1E); // You discern light seeping through the crack of a secret door!
            L0079: SetWallObject(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L0097: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L00B5: return; // RETURN;
        }

        private void FnDIDTHIS_3B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
1304  0003 83 EC 06  sub sp, 0x6
1307  0006 56     push si
            L0007: si = 0;
130A  0009 C7 46 FE 00 00  mov word [bp-0x2], 0x0
130F  000E C7 46 FC 00 00  mov word [bp-0x4], 0x0
            L0013: ax = GetCurrentTile(player);
131B  001A 89 46 FA  mov [bp-0x6], ax
131E  001D B9 04 00  mov cx, 0x4
            L0020: bx = 0x13E0;
1324  0023 2E 8B 07  mov ax, [cs:bx]
1327  0026 3B 46 FA  cmp ax, [bp-0x6]
            L0029: if (JumpEqual) goto L0031;
132C  002B 43     inc bx
132D  002C 43     inc bx
132E  002D E2 F4  loop 0x23
            L002F: goto L0065;
1332  0031 2E FF 67 08  jmp word [cs:bx+0x8]
            L0035: si = 0x0022;
            L0038: goto L005B;
            L003A: si = 0x0023;
133E  003D C7 46 FE 00 00  mov word [bp-0x2], 0x0
1343  0042 C7 46 FC 98 3A  mov word [bp-0x4], 0x3a98
            L0047: goto L0065;
            L0049: si = 0x0024;
134D  004C C7 46 FE 00 00  mov word [bp-0x2], 0x0
1352  0051 C7 46 FC 20 4E  mov word [bp-0x4], 0x4e20
            L0056: goto L0065;
            L0058: si = 0x0025;
135C  005B C7 46 FE 00 00  mov word [bp-0x2], 0x0
1361  0060 C7 46 FC A8 61  mov word [bp-0x4], 0x61a8
1366  0065 56     push si
            L0066: PushStack(player, 0x02);
136B  006A C4 5E 06  les bx, [bp+0x6]
136E  006D 26 FF 5F 04  call far word [es:bx+0x4]
            L0071: cx = PopStack(player);
            L0072: cx = PopStack(player);
            L0073: RefreshCompareFlags(ax);
            L0075: if (JumpNotEqual) goto L00DA;
            L0077: ShowPortrait(player, 0x0015);
            L0084: XCall Fn00EF
            L008F: cx = PopStack(player);
            L0090: cx = PopStack(player);
            L0091: XCall Fn0175
            L009C: cx = PopStack(player);
            L009D: cx = PopStack(player);
            L009E: XCall Fn0187
            L00A9: cx = PopStack(player);
            L00AA: cx = PopStack(player);
            L00AB: XCall Fn0146
            L00B6: cx = PopStack(player);
            L00B7: cx = PopStack(player);
            L00B8: PushStack(player, 0x01);
13BD  00BC 56     push si
            L00BD: PushStack(player, 0x02);
13C2  00C1 C4 5E 06  les bx, [bp+0x6]
13C5  00C4 26 FF 1F  call far word [es:bx]
13C8  00C7 83 C4 06  add sp, 0x6
13CB  00CA FF 76 FE  push word [bp-0x2]
13CE  00CD FF 76 FC  push word [bp-0x4]
13D1  00D0 C4 5E 06  les bx, [bp+0x6]
13D4  00D3 26 FF 9F 98 00  call far word [es:bx+0x98]
            L00D8: cx = PopStack(player);
            L00D9: cx = PopStack(player);
13DB  00DA 5E     pop si
            L00DB: // restore stack ptr: sp = bp;
            L00DD: return; // RETURN;
            // Extra data: 39 00 5E 00 D9 00 EA 00 3B 13 36 13 4A 13 59 13 55 8B EC 4C 4C C4 5E 06 26 FF 5F 20 89 46 FE B9 04 00 BB 37 14 2E 8B 07 3B 46 FE 74 06 43 43 E2 F4 EB 20 2E FF 67 08 B8 5C 1A EB 0D B8 91 1A EB 08 B8 C2 1A EB 03 B8 F9 1A 50 C4 5E 06 26 FF 9F F8 00 59 8B E5 5D CB 39 00 5E 00 D9 00 EA 00 1C 14 17 14 21 14 26 14 55 8B EC B8 21 00 50 B8 02 00 50 C4 5E 06 26 FF 5F 04 59 59 0B C0 75 15 B8 01 00 50 B8 21 00 50 B8 02 00 50 C4 5E 06 26 FF 1F 83 C4 06 5D CB 55 8B EC B8 2E 1B 50 C4 5E 06 26 FF 9F F8 00 59 5D CB 55 8B EC 5D CB 
        }

        private void FnFIREBALL_3C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x02, 0x89));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00A6;
            L001B: Compare(GetGuild(player), 0x0005);
            L0025: if (JumpEqual) goto L0033;
            L0027: Compare(GetGuild(player), 0x0003);
            L0031: if (JumpNotEqual) goto L0075;
            L0033: SetSpellLevel(player, 0x06, 0x01);
            L0044: ShowPortrait(player, 0x0042);
            L0051: ShowMessage(player, String1B61); // The steaming fountain's waters offer a powerful source of energy.
            L005E: SetFlag(player, 0x02, 0x89, 0x01);
            L0073: goto L00A6;
            L0075: ShowPortrait(player, 0x0042);
            L0082: ShowMessage(player, String1BA3); // You are scalded by the burning waters.
            L008F: ax = GetMaxHits(player);
            L0096: bx = 0x0006;
            L0099: dx = ax % bx; ax = ax / bx;
            L009C: DamagePlayer(player, ax);
            L00A6: return; // RETURN;
        }

        private void FnLORDGNOG_3D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x02, 0x7A));
            L0016: if (JumpNotEqual) goto L0085;
            L0018: ShowMessage(player, String1BCA); // An elderly wizard sits here, poring over books.
            L0025: ShowMessage(player, String1BFA); // 'We meet at last. My envoys have told me so much about you.
            L0032: ShowMessage(player, String1C36); // They've helped me keep track of your achievements and failures.
            L003F: ShowMessage(player, String1C76); // Have you enjoyed my traps? Ah, well, some do, some don't.
            L004C: ShowMessage(player, String1CB0); // Since you've found me, perhaps you'd like to try for a little revenge.
            L0059: ShowMessage(player, String1CF7); // Come! Let's get on with it.'
159B  0066 B8 D0 07  mov ax, 0x7d0
            L0069: PushStack(player, ax);
            L006A: PushStack(player, 0x00);
            L006D: PushStack(player, ax);
            L006E: PushStack(player, 0xBD);
            L0072: PushStack(player, 0x8D);
            L0076: PushStack(player, 0x2D);
15AF  007A C4 5E 06  les bx, [bp+0x6]
15B2  007D 26 FF 9F D8 00  call far word [es:bx+0xd8]
15B7  0082 83 C4 0C  add sp, 0xc
            L0085: AddEncounter(player, 0x01, 0x22);
            L0097: return; // RETURN;
        }

        private void FnLGFLAG_3E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x02, 0x7A));
            L0016: if (JumpNotEqual) goto L002D;
            L0018: SetFlag(player, 0x02, 0x7A, 0x01);
            L002D: return; // RETURN;
        }

        private void FnTOSTART_3F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1D14); // To the entrance of the palace.
            L0010: TeleportParty(player, 0x03, 0x02, 0x80, 0x02, isForwardMove);
            L002B: return; // RETURN;
        }

    }
}
