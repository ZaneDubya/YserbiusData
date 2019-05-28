#pragma warning disable
using System.Collections.Generic;
using XPT.WorldData;
using XPT.WorldData.Yserbius;

namespace XPT.Scripts.Yserbius.Maps {
    class YserMap25 : AMapScripted {
        protected override int MapIndex => 25;
        protected override int RandomEncounterChance => 15;
        protected override int RandomEncounterExtraCount => 2;

        public YserMap25() {
            MapEvent01 = Fn_01;
            MapEvent02 = Fn_02;
            MapEvent03 = Fn_03;
            MapEvent04 = Fn_04;
            MapEvent05 = Fn_05;
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
        }
        
        // === Strings ================================================
        private const string String0140 = "You find a leather-bound journal on the desk.  It seems the Wyrd Sisters could use their powers to travel forward and backward in time, committing atrocities untold throughout the ages.";
        private const string String01FA = "You're not exactly sure what it means, but in another 700 years Cassandra will be responsible for cancelling 'Star Trek.'";
        private const string String0274 = "You have no idea why Galatea is proud of having broken up the Beetles.  You've stomped on many an insect without feeling any special pride.";
        private const string String0300 = "This page is written in a language you do not recognise.";
        private const string String0339 = "Cassandra was the one that gave Nero a box of safety matches without telling him to close the cover before striking.";
        private const string String03AE = "Deirdre invented pay privies.  Curse her black heart!";
        private const string String03E4 = "Again you are unclear about what this means, but Deirdre seems responsible for 'Ishtar,' 'Hudson Hawk,' and several Police Academy sequels.";
        private const string String0470 = "Cassandra mentions Tiny Tim.";
        private const string String048D = "Galatea takes great pride in the divide error on the Pentium chip.";
        private const string String04D0 = "Deirdre was responsible for the complete disappearance of 'Leisure Suit Larry Four.'";
        private const string String0525 = "They mutated the giant rat of Sumatra.";
        private const string String054C = "Cassandra invented the designated hitter and astroturf.  Whatever they are.";
        private const string String0598 = "Deirdre invented the English method of measuring distance.  Cassandra did metric.";
        private const string String05EA = "Galatea invented Roman numerals.";
        private const string String060B = "Galatea invented light beer.  You are surprised she mentions that; nearly everyone you know likes Pilsner.";
        private const string String0676 = "None of the witches invented spam, but they would love the autograph of whoever did.";
        private const string String06CB = "Cassandra is responsible for the new luggage system at Denver Airport.";
        private const string String0712 = "Deirdre created cold fusion and the comet Kahoutek.";
        private const string String0746 = "You have no idea what a telescope is, let alone a Hubbell Space Telescope, but Cassandra could not hold her pen steady from the laughing when she recorded it.";
        private const string String07E5 = "Galatea will someday convince the great lady Rose Anne that she can sing.";
        private const string String082F = "It took the collaborative efforts of all three witches combined to invent airplane food.";
        private const string String0888 = "Cassandra invents homework.  Galatea invents housework.  Deirdre invents busywork.";
        private const string String08DB = "Deirdre invented disco.  Galatea helped.";
        private const string String0904 = "Galatea was responsible for the great cricket strike of 1994-1995.";
        private const string String0947 = "Cassandra invented reverse Polish notation.";
        private const string String0973 = "Deirdre convinced one Michael, from Jordan, that he was a cricket player.";
        private const string String09BD = "Galatea invented betamax, quadrophonic, and eight track tapes.";
        private const string String09FC = "This writing is obscure, but it seems that Deirdre will harm the monarch Martin Mac sorely by altering his staff during the final round of a tourney to win the Holy Grail.";
        private const string String0AA8 = "It seems to have been Cassandra's control spell that convinced a Mr. Lincoln to go to the Ford Theatre.";
        private const string String0B10 = "All three working together in huge collaborative effort make a major start on inventing advertising, but they must leave it to future villains to perfect it.";
        private const string String0BAE = "I'll do you a favor; this is the last non-blank page you will want to find here.";
        private const string String0BFF = "You feel a terminal case of boredom coming on.";
        private const string String0C2E = "This page is blank.";
        private const string String0C42 = "You have unlocked the hidden door!";
        private const string String0C65 = "Your lockpick is no more.  It has ceased to key.  It's a stick.  Bereft of heft, it rests in pieces.  This is an ex-lockpick.";
        private const string String0CE3 = "You detect a hidden door, but it is locked.";
        private const string String0D0F = "That was a stiff lock, but you finally got it open.";
        private const string String0D43 = "Funny how an irksome little lock on a flimsy little door can keep out a big strong person like you.";
        private const string String0DA7 = "Cautious is as cautious does.  Or, to put it another way, you know what lies ahead of you; better not to walk right into it.";
        private const string String0E24 = "This door leads to stairs going up.  There's a trap door at the top of the stairs, with a hint of light outlining its seams.";
        private const string String0EA1 = "*";
        private const string String0EA3 = "A shimmering spell brings Galatea's image before you.";
        private const string String0ED9 = "'My glorious hero!  I am at last dead, and thou hast all my best wishes and benifences.";
        private const string String0F31 = "The residue of evil still resides here.  A few of the more powerful creatures may still return from whence they skulked, nursing their wounds, and thou mayest choose to seek them out lest they serve as hazards to others.";
        private const string String100E = "My final spell shall inscribe thy name for all time amongst the greatest heroes of our ages.  A thousand thanks, do not suffice for my gratitude!";
        private const string String10A0 = "An thou so choosest, thou wilt find many doors open to thee that hitherto kept thee out.  But whether thou dost tarry here or not, thou shalt always know that thou wert mine own hero and Savior.'";
        private const string String1164 = "The spell again brings Galatea's image before you.";
        private const string String1197 = "Some evil still resides here.  Creatures may still return from whence they skulked, nursing their wounds and their grudges, and thou mayest choose to seek them out lest they serve as hazards to others.";
        private const string String1261 = "You feel refreshed, as if somehow Galatea's sacrifice has sanctified this room.  The room remains empty save for the desk along the north wall.";
        private const string String12F1 = "Not only did the Wyrd Sisters live messy, but they died messy, too!";
        private const string String1335 = "If you've seen one witch's lair, you've seen them all.  Well, actually not.  Some witches live in very nice lairs, with well-shrubbed gardens.";
        private const string String13C4 = "The Wyrd Sisters had the second largest collection of human skulls you've ever seen.";
        private const string String1419 = "Judging by the labels on the boxes, the Wyrd Sisters also had a thriving business counterfeiting pieces of the True Cross.";
        private const string String1494 = "For some strange reason, the Wyrd Sisters have many boxes full of merchandise from a Beatles Reunion Tour.";
        private const string String14FF = "Gosh!  The Wyrd Sisters were Avon Ladies!  That must be how Shakespeare knew about them, Stratford and all.";
        private const string String156B = "They were waiting for you!";
        private const string String1586 = "There really are quite a lot of them!";
        private const string String15AC = "All that remains of your combat here is a small pool of burnt oil and some grungy spare parts.";
        private const string String160B = "You take four deep slow quiet breaths to prepare, and then charge!";
        private const string String164E = "Unfortunately, you are charging down a hallway liberally littered with caltrops!";
        private const string String169F = "An old, quavering voice whispers from thin air.";
        private const string String16CF = "'Well done, young questor.  Thou hast summoned me from afar to aid thee, as was foretold.  I lack the power to take thee very far, but every step I enable thee to bypass is a fiercesome monster avoided.'";
        private const string String179B = "'Now may fortune favor thee.'";
        private const string String17B9 = "A beatific figure, old, wise, and happy, appears before you.";
        private const string String17F6 = "'I am Aldhelm.  All this reappearing and miracle working and transporting really takes it out of a saint.  Thy need is for an angel, not a saint, but they are always so busy, guarding this, dancing on the heads of pins.";
        private const string String18D2 = "Ah well.  What I can do, I do.  Bon chance, young friend.'";
        private const string String190D = "A voice, thin and reedy, calls out to you as if from a great distance.";
        private const string String1954 = "'It takes all my power to speak to thee hear, as poorly equipped as thou art.  And yet I, Aldhelm, can give thee one bit of advice.";
        private const string String19D8 = "There are portals, well hidden and well sealed, that will greatly speed thy passage north through the Crypt.  An thou canst make use of them, then thou wilt find thy life much easier.";
        private const string String1A90 = "A resonant voice speaks to you from thin air.";
        private const string String1ABE = "'I am Alfred, late the king of this land.  Thou hast shown courage in facing thy travails, and wisdom in gathering the items thou needst to summon me.";
        private const string String1B55 = "Hear me!  The Serpentine Crypt is a death trap, pure and simple.  I will now let you bypass some, but only some, of its length.  Help given once may yet be given again there, but thou shouldst neither expect nor seek it.";
        private const string String1C32 = "And I can advise thee in this small matter: Cassandra is the mightiest of the Wyrd Sisters.  Thou shouldst focus thy efforts on her first.  Good luck!'";
        private const string String1CCA = "Hey!  You just got some free tickets to a giant's game.  And you get to be the ball!";
        private const string String1D1F = "And they even brought their own impires.";
        private const string String1D48 = "All that remains of your battle here is a broken club and some spilled beer.";
        private const string String1D95 = "The good news is that the wraiths and vampires are arguing about who gets dibs on your corpse.  The bad news is that they are attacking while arguing!";
        private const string String1E2C = "'The undead you fought here should have spent less time arguing and more time fighting,' you think to yourself.";
        
        // === Functions ================================================
        private void Fn_01(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: // make space for tmp on stack: sp -= 2
0011  0005 56     push si
            L0006: si = GetFlag(player, 0x02, 0x59);
            L0019: si = si + 1;
            L001A: RefreshCompareFlags(GetFlag(player, 0x03, 0x0A));
            L002D: if (JumpNotEqual) goto L0051;
            L002F: SetFlag(player, 0x03, 0x0A, 0x01);
            L0044: ShowMessage(player, String0140); // You find a leather-bound journal on the desk.  It seems the Wyrd Sisters could use their powers to travel forward and backward in time, committing atrocities untold throughout the ages.
            L0051: Compare(HasUsedSkill(player, 0x0D), 0x0001);
            L0060: if (JumpBelow) goto L0065;
            L0062: goto L00E6;
            L0065: RefreshCompareFlags(HasUsedSpell(player, 0x17));
            L0073: if (JumpNotEqual) goto L00E6;
            L0075: PushStack(player, 0x67);
            L0079: PushStack(player, ax);
0086  007A C4 5E 06  les bx, [bp+0x6]
0089  007D 26 FF 5F 54  call far word [es:bx+0x54]
            L0081: cx = PopStack(player);
            L0082: cx = PopStack(player);
            L0083: RefreshCompareFlags(ax);
            L0085: if (JumpNotEqual) goto L00E6;
            L0087: PushStack(player, 0x61);
            L008B: PushStack(player, ax);
0098  008C C4 5E 06  les bx, [bp+0x6]
009B  008F 26 FF 5F 54  call far word [es:bx+0x54]
            L0093: cx = PopStack(player);
            L0094: cx = PopStack(player);
            L0095: RefreshCompareFlags(ax);
            L0097: if (JumpNotEqual) goto L00E6;
            L0099: PushStack(player, 0x93);
            L009D: PushStack(player, ax);
00AA  009E C4 5E 06  les bx, [bp+0x6]
00AD  00A1 26 FF 5F 54  call far word [es:bx+0x54]
            L00A5: cx = PopStack(player);
            L00A6: cx = PopStack(player);
            L00A7: RefreshCompareFlags(ax);
            L00A9: if (JumpNotEqual) goto L00E6;
            L00AB: PushStack(player, 0x86);
            L00AF: PushStack(player, ax);
00BC  00B0 C4 5E 06  les bx, [bp+0x6]
00BF  00B3 26 FF 5F 54  call far word [es:bx+0x54]
            L00B7: cx = PopStack(player);
            L00B8: cx = PopStack(player);
            L00B9: RefreshCompareFlags(ax);
            L00BB: if (JumpNotEqual) goto L00E6;
            L00BD: PushStack(player, 0xA7);
            L00C1: PushStack(player, ax);
00CE  00C2 C4 5E 06  les bx, [bp+0x6]
00D1  00C5 26 FF 5F 54  call far word [es:bx+0x54]
            L00C9: cx = PopStack(player);
            L00CA: cx = PopStack(player);
            L00CB: RefreshCompareFlags(ax);
            L00CD: if (JumpNotEqual) goto L00E6;
            L00CF: ax = IsFlagOn(player, 0x00, 0x01);
            L00E1: if (JumpNotEqual) goto L00E6;
            L00E3: goto L01F0;
            L00E6: SetFlag(player, 0xC4, 0xB8, si);
            L00F8: PushStack(player, 0x00);
            L00FB: PushStack(player, 0x01);
            L00FF: PushStack(player, 0x00);
010E  0102 C4 5E 06  les bx, [bp+0x6]
0111  0105 26 FF 1F  call far word [es:bx]
0114  0108 83 C4 06  add sp, 0x6
0117  010B 89 76 FE  mov [bp-0x2], si
011A  010E B9 21 00  mov cx, 0x21
            L0111: bx = 0x0201;
0120  0114 2E 8B 07  mov ax, [cs:bx]
0123  0117 3B 46 FE  cmp ax, [bp-0x2]
            L011A: if (JumpEqual) goto L0123;
0128  011C 43     inc bx
0129  011D 43     inc bx
012A  011E E2 F4  loop 0x114
            L0120: goto L01E3;
012F  0123 2E FF 67 42  jmp word [cs:bx+0x42]
0133  0127 B8 FA 01  mov ax, 0x1fa
            L012A: goto L01E6;
0139  012D B8 74 02  mov ax, 0x274
            L0130: goto L01E6;
            L0133: goto L0153;
0141  0135 B8 39 03  mov ax, 0x339
            L0138: goto L01E6;
0147  013B B8 AE 03  mov ax, 0x3ae
            L013E: goto L01E6;
014D  0141 B8 E4 03  mov ax, 0x3e4
            L0144: goto L01E6;
0153  0147 B8 70 04  mov ax, 0x470
            L014A: goto L01E6;
0159  014D B8 8D 04  mov ax, 0x48d
            L0150: goto L01E6;
015F  0153 B8 00 03  mov ax, 0x300
            L0156: goto L01E6;
0165  0159 B8 D0 04  mov ax, 0x4d0
            L015C: goto L01E6;
016B  015F B8 25 05  mov ax, 0x525
            L0162: goto L01E6;
0171  0165 B8 4C 05  mov ax, 0x54c
            L0168: goto L01E6;
            L016A: // NOP
0177  016B B8 98 05  mov ax, 0x598
            L016E: goto L01E6;
            L0170: // NOP
017D  0171 B8 EA 05  mov ax, 0x5ea
            L0174: goto L01E6;
            L0176: // NOP
0183  0177 B8 0B 06  mov ax, 0x60b
            L017A: goto L01E6;
0188  017C B8 76 06  mov ax, 0x676
            L017F: goto L01E6;
018D  0181 B8 CB 06  mov ax, 0x6cb
            L0184: goto L01E6;
0192  0186 B8 12 07  mov ax, 0x712
            L0189: goto L01E6;
0197  018B B8 46 07  mov ax, 0x746
            L018E: goto L01E6;
019C  0190 B8 E5 07  mov ax, 0x7e5
            L0193: goto L01E6;
01A1  0195 B8 2F 08  mov ax, 0x82f
            L0198: goto L01E6;
01A6  019A B8 88 08  mov ax, 0x888
            L019D: goto L01E6;
01AB  019F B8 DB 08  mov ax, 0x8db
            L01A2: goto L01E6;
01B0  01A4 B8 04 09  mov ax, 0x904
            L01A7: goto L01E6;
01B5  01A9 B8 47 09  mov ax, 0x947
            L01AC: goto L01E6;
01BA  01AE B8 73 09  mov ax, 0x973
            L01B1: goto L01E6;
01BF  01B3 B8 BD 09  mov ax, 0x9bd
            L01B6: goto L01E6;
01C4  01B8 B8 FC 09  mov ax, 0x9fc
            L01BB: goto L01E6;
01C9  01BD B8 A8 0A  mov ax, 0xaa8
            L01C0: goto L01E6;
01CE  01C2 B8 10 0B  mov ax, 0xb10
            L01C5: goto L01E6;
01D3  01C7 B8 AE 0B  mov ax, 0xbae
            L01CA: goto L01E6;
01D8  01CC B8 FF 0B  mov ax, 0xbff
            L01CF: goto L01E6;
            L01D1: PushStack(player, GetMaxHits(player));
01E5  01D9 C4 5E 06  les bx, [bp+0x6]
01E8  01DC 26 FF 9F 90 00  call far word [es:bx+0x90]
            L01E1: goto L01EF;
            L01E3: ShowMessage(player, String0C2E); // This page is blank.
01FC  01F0 5E     pop si
            L01F1: // restore stack ptr: sp = bp;
            L01F3: return; // RETURN;
            // Extra data: 01 00 02 00 03 00 04 00 05 00 06 00 07 00 08 00 09 00 0A 00 0B 00 0C 00 0D 00 0E 00 0F 00 11 00 12 00 13 00 15 00 16 00 18 00 19 00 1B 00 1D 00 1E 00 1F 00 21 00 22 00 24 00 2F 00 3C 00 7E 00 7F 00 33 01 39 01 3F 01 41 01 47 01 4D 01 53 01 59 01 5F 01 65 01 6B 01 71 01 77 01 7D 01 83 01 88 01 8D 01 92 01 97 01 9C 01 A1 01 A6 01 AB 01 B0 01 B5 01 BA 01 BF 01 C4 01 C9 01 CE 01 D3 01 D8 01 DD 01 
        }

        private void Fn_02(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, 0x0D), 0x000B);
            L0012: if (JumpAbove) goto L002B;
            L0014: ax = IsFlagOn(player, 0x00, 0x01);
            L0026: if (JumpNotEqual) goto L002B;
            L0028: goto L015A;
            L002B: SetWallObject(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L0049: PushStack(player, 0x01);
            L004D: PushStack(player, ax);
            L004E: PushStack(player, 0x00);
02D6  0051 C4 5E 06  les bx, [bp+0x6]
02D9  0054 26 FF 1F  call far word [es:bx]
02DC  0057 83 C4 06  add sp, 0x6
            L005A: Compare(GetSkillLevel(player, 0x0E), 0x000B);
            L0069: if (JumpBelowOrEqual) goto L0090;
            L006B: PushStack(player, 0xDD);
            L006F: PushStack(player, ax);
02F5  0070 C4 5E 06  les bx, [bp+0x6]
02F8  0073 26 FF 5F 54  call far word [es:bx+0x54]
            L0077: cx = PopStack(player);
            L0078: cx = PopStack(player);
            L0079: RefreshCompareFlags(ax);
            L007B: if (JumpEqual) goto L0090;
            L007D: ShowMessage(player, String0C42); // You have unlocked the hidden door!
030F  008A B8 01 00  mov ax, 0x1
            L008D: goto L015C;
            L0090: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L00AD: ax = HasUsedItem(player, 0xC1, 0xC3);
            L00C0: if (JumpNotEqual) goto L00D7;
            L00C2: ax = HasUsedItem(player, 0xDA, 0xDC);
            L00D5: if (JumpEqual) goto L012E;
            L00D7: RemoveItem(player, 0xC1);
            L00E3: RemoveItem(player, 0xC2);
            L00EF: RemoveItem(player, 0xC3);
            L00FB: RemoveItem(player, 0xDA);
            L0107: RemoveItem(player, 0xDB);
            L0113: RemoveItem(player, 0xDC);
            L011F: ShowMessage(player, String0C65); // Your lockpick is no more.  It has ceased to key.  It's a stick.  Bereft of heft, it rests in pieces.  This is an ex-lockpick.
            L012C: goto L0177;
            L012E: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L014B: ShowMessage(player, String0CE3); // You detect a hidden door, but it is locked.
            L0158: goto L0177;
            L015A: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0177: return; // RETURN;
        }

        private void Fn_03(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x68);
            L0007: PushStack(player, ax);
0406  0008 C4 5E 06  les bx, [bp+0x6]
0409  000B 26 FF 5F 54  call far word [es:bx+0x54]
            L000F: cx = PopStack(player);
            L0010: cx = PopStack(player);
            L0011: RefreshCompareFlags(ax);
            L0013: if (JumpEqual) goto L0055;
            L0015: ax = HasItem(player, 0xDA);
            L0023: if (JumpNotEqual) goto L009F;
            L0025: ax = HasItem(player, 0xDB);
            L0033: if (JumpNotEqual) goto L009F;
            L0035: ax = HasItem(player, 0xDC);
            L0043: if (JumpNotEqual) goto L009F;
            L0045: ax = HasItem(player, 0xDD);
            L0053: if (JumpNotEqual) goto L009F;
            L0055: Compare(GetSkillLevel(player, 0x0E), 0x0009);
            L0064: if (JumpBelow) goto L008D;
            L0066: PushStack(player, 0xC3);
            L006A: PushStack(player, ax);
0469  006B C4 5E 06  les bx, [bp+0x6]
046C  006E 26 FF 5F 54  call far word [es:bx+0x54]
            L0072: cx = PopStack(player);
            L0073: cx = PopStack(player);
            L0074: RefreshCompareFlags(ax);
            L0076: if (JumpNotEqual) goto L009F;
            L0078: ax = HasUsedItem(player, 0xDA, 0xDD);
            L008B: if (JumpNotEqual) goto L009F;
            L008D: PushStack(player, 0xC0);
            L0091: PushStack(player, ax);
0490  0092 C4 5E 06  les bx, [bp+0x6]
0493  0095 26 FF 5F 54  call far word [es:bx+0x54]
            L0099: cx = PopStack(player);
            L009A: cx = PopStack(player);
            L009B: RefreshCompareFlags(ax);
            L009D: if (JumpEqual) goto L00CD;
            L009F: ShowMessage(player, String0D0F); // That was a stiff lock, but you finally got it open.
            L00AC: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L00CA: goto L0152;
            L00CD: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L00EA: ax = HasUsedItem(player, 0xC1, 0xC3);
            L00FD: if (JumpEqual) goto L0128;
            L00FF: RemoveItem(player, 0xC1);
            L010B: RemoveItem(player, 0xC2);
            L0117: RemoveItem(player, 0xC3);
0521  0123 B8 65 0C  mov ax, 0xc65
            L0126: goto L0148;
            L0128: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0145: ShowMessage(player, String0D43); // Funny how an irksome little lock on a flimsy little door can keep out a big strong person like you.
            L0152: return; // RETURN;
        }

        private void Fn_04(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, 0x0B), 0x000B);
            L0012: if (JumpBelowOrEqual) goto L0036;
            L0014: ShowMessage(player, String0DA7); // Cautious is as cautious does.  Or, to put it another way, you know what lies ahead of you; better not to walk right into it.
            L0021: SetFlag(player, 0x03, 0x09, 0x01);
            L0036: return; // RETURN;
        }

        private void Fn_05(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0E24); // This door leads to stairs going up.  There's a trap door at the top of the stairs, with a hint of light outlining its seams.
            L0010: PushStack(player, 0x01);
            L0014: PushStack(player, 0xE7);
            L0018: PushStack(player, 0x01);
            L001C: PushStack(player, ax);
05A7  001D C4 5E 06  les bx, [bp+0x6]
05AA  0020 26 FF 9F BC 00  call far word [es:bx+0xbc]
05AF  0025 83 C4 08  add sp, 0x8
            L0028: return; // RETURN;
        }

        private void Fn_09(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x02, 0x14));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00E9;
            L001B: SetFlag(player, 0x02, 0x14, 0x01);
            L0030: ShowPortrait(player, 0x0015);
            L003D: ShowMessage(player, String0EA1); // *
            L004A: ShowMessage(player, String0EA1); // *
            L0057: ShowMessage(player, String0EA1); // *
            L0064: HealPlayer(player, GetMaxHits(player));
            L0075: AddMana(player, 0x2710);
            L0082: AddExperience(player, 0x00989680);
0657  0094 B8 0F 00  mov ax, 0xf
065A  0097 BA 40 42  mov dx, 0x4240
            L009A: PushStack(player, ax);
            L009B: PushStack(player, dx);
065F  009C C4 5E 06  les bx, [bp+0x6]
0662  009F 26 FF 9F AC 00  call far word [es:bx+0xac]
            L00A4: cx = PopStack(player);
            L00A5: cx = PopStack(player);
            L00A6: ShowMessage(player, String0EA3); // A shimmering spell brings Galatea's image before you.
            L00B3: ShowMessage(player, String0ED9); // 'My glorious hero!  I am at last dead, and thou hast all my best wishes and benifences.
            L00C0: ShowMessage(player, String0F31); // The residue of evil still resides here.  A few of the more powerful creatures may still return from whence they skulked, nursing their wounds, and thou mayest choose to seek them out lest they serve as hazards to others.
            L00CD: ShowMessage(player, String100E); // My final spell shall inscribe thy name for all time amongst the greatest heroes of our ages.  A thousand thanks, do not suffice for my gratitude!
069D  00DA B8 A0 10  mov ax, 0x10a0
            L00DD: PushStack(player, ax);
06A1  00DE C4 5E 06  les bx, [bp+0x6]
06A4  00E1 26 FF 9F F8 00  call far word [es:bx+0xf8]
            L00E6: goto L01B2;
            L00E9: RefreshCompareFlags(GetFlag(player, 0x03, 0x0C));
            L00FC: if (JumpEqual) goto L0101;
            L00FE: goto L0188;
            L0101: SetFlag(player, 0x03, 0x0C, 0x01);
            L0116: ShowPortrait(player, 0x0015);
            L0123: ShowMessage(player, String0EA1); // *
            L0130: ShowMessage(player, String0EA1); // *
            L013D: ShowMessage(player, String0EA1); // *
            L014A: HealPlayer(player, GetMaxHits(player));
            L015B: AddMana(player, 0x2710);
            L0168: ShowMessage(player, String1164); // The spell again brings Galatea's image before you.
            L0175: ShowMessage(player, String0ED9); // 'My glorious hero!  I am at last dead, and thou hast all my best wishes and benifences.
0745  0182 B8 97 11  mov ax, 0x1197
            L0185: goto L00D0;
            L0188: ShowMessage(player, String1261); // You feel refreshed, as if somehow Galatea's sacrifice has sanctified this room.  The room remains empty save for the desk along the north wall.
            L0195: HealPlayer(player, GetMaxHits(player));
            L01A6: AddMana(player, 0x2710);
            L01B3: RefreshCompareFlags(GetFlag(player, 0x02, 0x6A));
            L01C6: if (JumpNotEqual) goto L01DD;
            L01C8: SetFlag(player, 0x02, 0x6A, 0x01);
            L01DD: return; // RETURN;
        }

        private void Fn_0A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x02));
            L0016: if (JumpNotEqual) goto L0065;
            L0018: SetFlag(player, 0x03, 0x02, 0x01);
            L002D: AddEncounter(player, 0x01, 0x20);
            L003F: AddEncounter(player, 0x02, 0x21);
            L0051: AddEncounter(player, 0x03, 0x22);
            L0063: goto L0072;
            L0065: ShowMessage(player, String12F1); // Not only did the Wyrd Sisters live messy, but they died messy, too!
            L0072: return; // RETURN;
        }

        private void Fn_0B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x02));
            L0016: if (JumpNotEqual) goto L0065;
            L0018: SetFlag(player, 0x03, 0x02, 0x01);
            L002D: AddEncounter(player, 0x01, 0x23);
            L003F: AddEncounter(player, 0x02, 0x24);
            L0051: AddEncounter(player, 0x03, 0x25);
            L0063: goto L0072;
            L0065: ShowMessage(player, String1335); // If you've seen one witch's lair, you've seen them all.  Well, actually not.  Some witches live in very nice lairs, with well-shrubbed gardens.
            L0072: return; // RETURN;
        }

        private void Fn_0C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x02));
            L0016: if (JumpNotEqual) goto L0065;
            L0018: SetFlag(player, 0x03, 0x02, 0x01);
            L002D: AddEncounter(player, 0x01, 0x26);
            L003F: AddEncounter(player, 0x02, 0x27);
            L0051: AddEncounter(player, 0x03, 0x28);
            L0063: goto L0072;
            L0065: ShowMessage(player, String13C4); // The Wyrd Sisters had the second largest collection of human skulls you've ever seen.
            L0072: return; // RETURN;
        }

        private void Fn_0D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x02));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00B8;
            L001B: SetFlag(player, 0x03, 0x02, 0x01);
            L0030: AddEncounter(player, 0x01, 0x20);
            L0042: AddEncounter(player, 0x02, 0x21);
            L0054: AddEncounter(player, 0x03, 0x22);
            L0066: Compare(PartyCount(player), 0x0002);
            L0071: if (JumpBelowOrEqual) goto L0085;
            L0073: AddEncounter(player, 0x05, 0x18);
            L0085: Compare(PartyCount(player), 0x0003);
            L0090: if (JumpBelowOrEqual) goto L00C5;
            L0092: AddEncounter(player, 0x06, 0x1C);
            L00A4: AddEncounter(player, 0x04, 0x1C);
            L00B6: goto L00C5;
            L00B8: ShowMessage(player, String1419); // Judging by the labels on the boxes, the Wyrd Sisters also had a thriving business counterfeiting pieces of the True Cross.
            L00C5: return; // RETURN;
        }

        private void Fn_0E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x02));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00B8;
            L001B: SetFlag(player, 0x03, 0x02, 0x01);
            L0030: AddEncounter(player, 0x01, 0x23);
            L0042: AddEncounter(player, 0x02, 0x24);
            L0054: AddEncounter(player, 0x03, 0x25);
            L0066: Compare(PartyCount(player), 0x0002);
            L0071: if (JumpBelowOrEqual) goto L0085;
            L0073: AddEncounter(player, 0x05, 0x1F);
            L0085: Compare(PartyCount(player), 0x0003);
            L0090: if (JumpBelowOrEqual) goto L00C5;
            L0092: AddEncounter(player, 0x06, 0x1F);
            L00A4: AddEncounter(player, 0x04, 0x1F);
            L00B6: goto L00C5;
            L00B8: ShowMessage(player, String1494); // For some strange reason, the Wyrd Sisters have many boxes full of merchandise from a Beatles Reunion Tour.
            L00C5: return; // RETURN;
        }

        private void Fn_0F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x02));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00B8;
            L001B: SetFlag(player, 0x03, 0x02, 0x01);
            L0030: AddEncounter(player, 0x01, 0x26);
            L0042: AddEncounter(player, 0x02, 0x27);
            L0054: AddEncounter(player, 0x03, 0x28);
            L0066: Compare(PartyCount(player), 0x0001);
            L0071: if (JumpBelowOrEqual) goto L0097;
            L0073: AddEncounter(player, 0x05, 0x1B);
            L0085: AddEncounter(player, 0x06, 0x1B);
            L0097: Compare(PartyCount(player), 0x0002);
            L00A2: if (JumpBelowOrEqual) goto L00C5;
            L00A4: AddEncounter(player, 0x04, 0x1B);
            L00B6: goto L00C5;
            L00B8: ShowMessage(player, String14FF); // Gosh!  The Wyrd Sisters were Avon Ladies!  That must be how Shakespeare knew about them, Stratford and all.
            L00C5: return; // RETURN;
        }

        private void Fn_10(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFlag(player, 0x03, 0x09, 0x00);
            L0017: RefreshCompareFlags(GetFlag(player, 0x03, 0x01));
            L002A: if (JumpEqual) goto L002F;
            L002C: goto L0114;
            L002F: ShowMessage(player, String156B); // They were waiting for you!
            L003C: ax = GetMaxHits(player);
            L0043: bx = 0x0003;
            L0046: dx = ax % bx; ax = ax / bx;
            L0049: DamagePlayer(player, ax);
            L0053: AddMana(player, 0xFDA8);
            L0060: PushStack(player, 0x01);
            L0064: PushStack(player, ax);
            L0065: PushStack(player, 0x03);
0BBC  0069 C4 5E 06  les bx, [bp+0x6]
0BBF  006C 26 FF 1F  call far word [es:bx]
0BC2  006F 83 C4 06  add sp, 0x6
            L0072: ShowMessage(player, String1586); // There really are quite a lot of them!
            L007F: AddEncounter(player, 0x01, 0x1E);
            L0091: AddEncounter(player, 0x05, 0x1B);
            L00A3: Compare(PartyCount(player), 0x0001);
            L00AE: if (JumpBelowOrEqual) goto L00C2;
            L00B0: AddEncounter(player, 0x02, 0x1E);
            L00C2: Compare(PartyCount(player), 0x0002);
            L00CD: if (JumpBelowOrEqual) goto L00E1;
            L00CF: AddEncounter(player, 0x06, 0x1B);
            L00E1: Compare(PartyCount(player), 0x0003);
            L00EC: if (JumpBelowOrEqual) goto L0121;
            L00EE: AddEncounter(player, 0x03, 0x1E);
            L0100: AddEncounter(player, 0x04, 0x1B);
            L0112: goto L0121;
            L0114: ShowMessage(player, String15AC); // All that remains of your combat here is a small pool of burnt oil and some grungy spare parts.
            L0121: return; // RETURN;
        }

        private void Fn_11(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFlag(player, 0x03, 0x09, 0x00);
            L0017: RefreshCompareFlags(GetFlag(player, 0x03, 0x01));
            L002A: if (JumpEqual) goto L002F;
            L002C: goto L00C9;
            L002F: PushStack(player, 0x01);
            L0033: PushStack(player, ax);
            L0034: PushStack(player, 0x03);
0CAE  0038 C4 5E 06  les bx, [bp+0x6]
0CB1  003B 26 FF 1F  call far word [es:bx]
0CB4  003E 83 C4 06  add sp, 0x6
            L0041: AddEncounter(player, 0x01, 0x1E);
            L0053: AddEncounter(player, 0x05, 0x1B);
            L0065: Compare(PartyCount(player), 0x0002);
            L0070: if (JumpBelowOrEqual) goto L0096;
            L0072: AddEncounter(player, 0x02, 0x1E);
            L0084: AddEncounter(player, 0x06, 0x1C);
            L0096: Compare(PartyCount(player), 0x0003);
            L00A1: if (JumpBelowOrEqual) goto L00D6;
            L00A3: AddEncounter(player, 0x03, 0x1E);
            L00B5: AddEncounter(player, 0x04, 0x1C);
            L00C7: goto L00D6;
            L00C9: ShowMessage(player, String15AC); // All that remains of your combat here is a small pool of burnt oil and some grungy spare parts.
            L00D6: return; // RETURN;
        }

        private void Fn_12(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String160B); // You take four deep slow quiet breaths to prepare, and then charge!
            L0010: RefreshCompareFlags(GetFlag(player, 0x03, 0x09));
            L0023: if (JumpEqual) goto L0028;
            L0025: goto L00BB;
            L0028: RefreshCompareFlags(GetFlag(player, 0x03, 0x0B));
            L003B: if (JumpNotEqual) goto L0083;
            L003D: ShowMessage(player, String164E); // Unfortunately, you are charging down a hallway liberally littered with caltrops!
            L004A: ax = GetMaxHits(player);
            L0051: bx = 0x0002;
            L0054: dx = ax % bx; ax = ax / bx;
            L0057: DamagePlayer(player, ax);
            L0061: AddMana(player, 0xF830);
            L006E: SetFlag(player, 0x03, 0x0B, 0x01);
            L0083: ax = HasItem(player, 0xEC);
            L0091: if (JumpEqual) goto L009B;
            L0093: PushStack(player, 0x00);
0DE4  0096 B8 04 00  mov ax, 0x4
            L0099: goto L00F1;
            L009B: ax = CheckLevel(player, 0x003C);
            L00A9: if (JumpEqual) goto L00B3;
            L00AB: PushStack(player, 0x00);
0DFC  00AE B8 06 00  mov ax, 0x6
            L00B1: goto L00F1;
            L00B3: PushStack(player, 0x00);
0E04  00B6 B8 05 00  mov ax, 0x5
            L00B9: goto L00F1;
            L00BB: ax = HasItem(player, 0xEC);
            L00C9: if (JumpEqual) goto L00D3;
            L00CB: PushStack(player, 0x00);
0E1C  00CE B8 01 00  mov ax, 0x1
            L00D1: goto L00F1;
            L00D3: ax = CheckLevel(player, 0x0050);
            L00E1: if (JumpEqual) goto L00EB;
            L00E3: PushStack(player, 0x00);
0E34  00E6 B8 03 00  mov ax, 0x3
            L00E9: goto L00F1;
            L00EB: TeleportParty(player, 0x0A, 0x03, 0x02, 0x00, isForwardMove);
            L0105: return; // RETURN;
        }

        private void Fn_13(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x09));
            L0016: if (JumpNotEqual) goto L0020;
            L0018: PushStack(player, 0x00);
0E70  001B B8 0E 00  mov ax, 0xe
            L001E: goto L0026;
            L0020: TeleportParty(player, 0x0A, 0x03, 0x0D, 0x00, isForwardMove);
            L003A: return; // RETURN;
        }

        private void Fn_14(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x0A, 0x02, 0xFF, 0x02, isForwardMove);
            L001E: return; // RETURN;
        }

        private void Fn_15(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0x6A);
            L0011: if (JumpNotEqual) goto L0016;
            L0013: goto L00A4;
            L0016: ax = HasItem(player, 0x86);
            L0024: if (JumpNotEqual) goto L0029;
            L0026: goto L00A4;
            L0028: // NOP
            L0029: ax = HasItem(player, 0x93);
            L0037: if (JumpEqual) goto L00A4;
            L0039: ShowMessage(player, String0EA1); // *
            L0046: ShowMessage(player, String0EA1); // *
            L0053: ShowMessage(player, String0EA1); // *
            L0060: ShowMessage(player, String169F); // An old, quavering voice whispers from thin air.
            L006D: ShowMessage(player, String16CF); // 'Well done, young questor.  Thou hast summoned me from afar to aid thee, as was foretold.  I lack the power to take thee very far, but every step I enable thee to bypass is a fiercesome monster avoided.'
            L007A: ShowMessage(player, String179B); // 'Now may fortune favor thee.'
            L0087: TeleportParty(player, 0x0A, 0x03, 0x70, 0x03, isForwardMove);
            L00A2: goto L00C2;
            L00A4: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L00C2: return; // RETURN;
        }

        private void Fn_16(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0x38);
            L0011: if (JumpNotEqual) goto L0016;
            L0013: goto L00BB;
            L0016: ax = HasItem(player, 0x88);
            L0024: if (JumpNotEqual) goto L0029;
            L0026: goto L00BB;
            L0029: ax = HasItem(player, 0x95);
            L0037: if (JumpNotEqual) goto L003C;
            L0039: goto L00BB;
            L003C: ShowMessage(player, String0EA1); // *
            L0049: ShowMessage(player, String0EA1); // *
            L0056: ShowMessage(player, String0EA1); // *
            L0063: ShowMessage(player, String17B9); // A beatific figure, old, wise, and happy, appears before you.
            L0070: ShowMessage(player, String17F6); // 'I am Aldhelm.  All this reappearing and miracle working and transporting really takes it out of a saint.  Thy need is for an angel, not a saint, but they are always so busy, guarding this, dancing on the heads of pins.
            L007D: ShowMessage(player, String18D2); // Ah well.  What I can do, I do.  Bon chance, young friend.'
            L008A: SetFlag(player, 0x02, 0x43, 0x01);
            L009F: TeleportParty(player, 0x0A, 0x03, 0x0C, 0x00, isForwardMove);
            L00B9: goto L0130;
            L00BB: ax = HasItem(player, 0x38);
            L00C9: if (JumpNotEqual) goto L00EB;
            L00CB: ax = HasItem(player, 0x88);
            L00D9: if (JumpNotEqual) goto L00EB;
            L00DB: ax = HasItem(player, 0x95);
            L00E9: if (JumpEqual) goto L0112;
            L00EB: ShowMessage(player, String190D); // A voice, thin and reedy, calls out to you as if from a great distance.
            L00F8: ShowMessage(player, String1954); // 'It takes all my power to speak to thee hear, as poorly equipped as thou art.  And yet I, Aldhelm, can give thee one bit of advice.
            L0105: ShowMessage(player, String19D8); // There are portals, well hidden and well sealed, that will greatly speed thy passage north through the Crypt.  An thou canst make use of them, then thou wilt find thy life much easier.
            L0112: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0130: return; // RETURN;
        }

        private void Fn_17(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0x68);
            L0011: if (JumpNotEqual) goto L0016;
            L0013: goto L00B4;
            L0016: ax = HasItem(player, 0x89);
            L0024: if (JumpNotEqual) goto L0029;
            L0026: goto L00B4;
            L0029: ax = HasItem(player, 0x82);
            L0037: if (JumpNotEqual) goto L003C;
            L0039: goto L00B4;
            L003B: // NOP
            L003C: ShowMessage(player, String0EA1); // *
            L0049: ShowMessage(player, String0EA1); // *
            L0056: ShowMessage(player, String0EA1); // *
            L0063: ShowMessage(player, String1A90); // A resonant voice speaks to you from thin air.
            L0070: ShowMessage(player, String1ABE); // 'I am Alfred, late the king of this land.  Thou hast shown courage in facing thy travails, and wisdom in gathering the items thou needst to summon me.
            L007D: ShowMessage(player, String1B55); // Hear me!  The Serpentine Crypt is a death trap, pure and simple.  I will now let you bypass some, but only some, of its length.  Help given once may yet be given again there, but thou shouldst neither expect nor seek it.
            L008A: ShowMessage(player, String1C32); // And I can advise thee in this small matter: Cassandra is the mightiest of the Wyrd Sisters.  Thou shouldst focus thy efforts on her first.  Good luck!'
            L0097: TeleportParty(player, 0x0A, 0x03, 0x30, 0x03, isForwardMove);
            L00B2: goto L00D2;
            L00B4: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L00D2: return; // RETURN;
        }

        private void Fn_18(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x03);
            L0007: PushStack(player, ax);
1183  0008 C4 5E 06  les bx, [bp+0x6]
1186  000B 26 FF 5F 04  call far word [es:bx+0x4]
            L000F: cx = PopStack(player);
            L0010: cx = PopStack(player);
            L0011: RefreshCompareFlags(ax);
            L0013: if (JumpEqual) goto L0018;
            L0015: goto L00CC;
            L0018: PushStack(player, 0x01);
            L001C: PushStack(player, 0x03);
            L0020: PushStack(player, ax);
119C  0021 C4 5E 06  les bx, [bp+0x6]
119F  0024 26 FF 1F  call far word [es:bx]
11A2  0027 83 C4 06  add sp, 0x6
            L002A: ShowMessage(player, String1CCA); // Hey!  You just got some free tickets to a giant's game.  And you get to be the ball!
            L0037: AddEncounter(player, 0x01, 0x1D);
            L0049: AddEncounter(player, 0x02, 0x1D);
            L005B: Compare(PartyCount(player), 0x0002);
            L0066: if (JumpBelowOrEqual) goto L008C;
            L0068: AddEncounter(player, 0x03, 0x1D);
            L007A: AddEncounter(player, 0x04, 0x1D);
            L008C: Compare(PartyCount(player), 0x0003);
            L0097: if (JumpBelowOrEqual) goto L00D9;
            L0099: ShowMessage(player, String1D1F); // And they even brought their own impires.
            L00A6: AddEncounter(player, 0x05, 0x1C);
            L00B8: AddEncounter(player, 0x06, 0x1C);
            L00CA: goto L00D9;
            L00CC: ShowMessage(player, String1D48); // All that remains of your battle here is a broken club and some spilled beer.
            L00D9: return; // RETURN;
        }

        private void Fn_19(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x04));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00D2;
            L001B: SetFlag(player, 0x03, 0x04, 0x01);
            L0030: ShowMessage(player, String1D95); // The good news is that the wraiths and vampires are arguing about who gets dibs on your corpse.  The bad news is that they are attacking while arguing!
            L003D: AddEncounter(player, 0x01, 0x19);
            L004F: AddEncounter(player, 0x05, 0x1A);
            L0061: Compare(PartyCount(player), 0x0002);
            L006C: if (JumpBelowOrEqual) goto L0092;
            L006E: AddEncounter(player, 0x02, 0x19);
            L0080: AddEncounter(player, 0x06, 0x1A);
            L0092: Compare(PartyCount(player), 0x0003);
            L009D: if (JumpBelowOrEqual) goto L00DF;
            L009F: ShowMessage(player, String1D1F); // And they even brought their own impires.
            L00AC: AddEncounter(player, 0x03, 0x19);
            L00BE: AddEncounter(player, 0x04, 0x1A);
            L00D0: goto L00DF;
            L00D2: ShowMessage(player, String1E2C); // 'The undead you fought here should have spent less time arguing and more time fighting,' you think to yourself.
            L00DF: return; // RETURN;
        }

    }
}
