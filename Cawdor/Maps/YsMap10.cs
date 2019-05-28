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
            MapEvent01 = Fn_01;
            MapEvent02 = Fn_02;
            MapEvent03 = Fn_03;
            MapEvent04 = Fn_04;
            MapEvent05 = Fn_05;
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
        }
        
        // === Strings ================================================
        private const string String0140 = "A stray breeze kicks up the scent of fermentation.";
        private const string String0173 = "You've uncovered a hidden door!";
        private const string String0193 = "You have unlocked the hidden door!";
        private const string String01B6 = "There is a door here, but it is locked.";
        private const string String01DE = "You've picked the lock. Proceed.";
        private const string String01FF = "Funny how an irksome little lock on a flimsy little door can keep out a big strong person like you.";
        private const string String0263 = "You find some tracks indicating that something headed off this way.";
        private const string String02A7 = "You hear some hooves running away.";
        private const string String02CA = "You hear someone running towards you.";
        private const string String02F0 = "*";
        private const string String02F2 = "The knight tenses, but relaxes when he sees you take a friendly posture.";
        private const string String033B = "'I can share some news with thee.  A friend of mine was able to use Lodbrok's Blade to send several of the undead kings to their true deaths, but not Lady Macbeth.  He never solved the animal riddle of The Bestiary.'";
        private const string String0414 = "He limps off.";
        private const string String0422 = "'Nay!  Put down thy blades.  I am not here to fight thee.  I was told that there were vats full of gold in the Brewery, but all I have found are vats full of ale.  Hast thou?'";
        private const string String04D2 = "You shake your head.";
        private const string String04E7 = "'No, I did not really expect thee to tell me where the liquid gold can be found.'  She departs.";
        private const string String0547 = "Some maddened minotaurs decide that you are trespassing.  They will prosecute you themselves.";
        private const string String05A5 = "Here is yet another spot that poor Rory sought dragons.  If only he had not found them.";
        private const string String05FD = "'Again our paths cross!  This a pleasant spot for a halfling, no?  But let me warn you:  if you do proceed northwards you will want as many items against undead as you can wield.  Me?  I'm looking for dragons.  Be seeing you!'";
        private const string String06E0 = "The halfling struts off, smiling.";
        private const string String0702 = "A puny pack o'piglets decides, rather insultingly, that they are bigger than you are.";
        private const string String0758 = "Okay, so it's not such a puny pack.";
        private const string String077C = "Boy, is that a heady smell!  This large room is filled with vats.  You suspect that someday whatever is in those vats will turn into ale.  Medieval water quality and sanitation being what it is, it is far safer to drink small ale (low alcohol) than water these days.";
        private const string String0887 = "To the east is The Gallery.";
        private const string String08A3 = "There is no obvious way to get into that vat.  Besides, doing so would probably kill you.";
        private const string String08FD = "These vats don't reverberate as much as the ones in the other room, but there's still no way in.";
        private const string String095E = "You find some footprints heading to the north.";
        private const string String098D = "You find some footprints heading to the west.";
        private const string String09BB = "No, you're not the only one who finds that odd.";
        private const string String09EB = "This room has not as heavy an odor as the other rooms you've encountered in the brewery.";
        private const string String0A44 = "If you work on this seam you might just....";
        private const string String0A70 = "Yes!  You have managed to pry open a secret door.";
        private const string String0AA2 = "There's a short little tunnel through here.";
        private const string String0ACE = "You follow the tunnel back into the vat.";
        private const string String0AF7 = "Boy, is that a heady smell!  This large room is dominated by one big vat in the center, but there is a pile of smaller vats in the northeast corner.  The smell is almost thick enough to chew.";
        private const string String0BB7 = "Jehosophat!  That has to be the biggest barrel o'brew you've ever seen!  Some smaller vats are piled in the northeast corner of the room.";
        private const string String0C41 = "'Not so fast!  I be the bouncer of this, The Raging Boar Inn, and we have a few ground rules.  There's to be no pinching of the employees.  There's to be no pinching of the silverware.  In fact, no pinching!  Any questions?'";
        private const string String0D22 = "You shake your head.  You can live with that.";
        private const string String0D50 = "Thankee kindly for frequenting the Boar.";
        private const string String0D79 = "The dairy man, er, pig, does not want to talk to you.";
        private const string String0DAF = "'One at a time!  One at a time!  I must respect the ancient traditions of my family and not sell thee any more until thou hast used the first one, preferably against someone named Macbeth.  Get thee gone!";
        private const string String0E7C = "'Excellent!  Excellent!  Thou hast come with that which I require!  The deal is done!'  You shake hands, uh, paws, uh, appendages on the deal.";
        private const string String0F0B = "Folly!  Folly!  I cannot trade my dairywares unless thou brings me something of great value in exchange!  Return when thou dost wish to trade, no sooner!";
        private const string String0FA5 = "It looks like you have found the raging boars!";
        private const string String0FD4 = "And, sadly, they have found you.";
        private const string String0FF5 = "Boy, was there some shakin' and bacon here.";
        private const string String1021 = "I guess we know what they meant by pigs having wings.";
        private const string String1057 = "All that remains from your battle here is an overcooked pork rind.";
        private const string String109A = "While you are wondering if the phrase 'silly Scottish pig dogs' is copyrighted, a group of them attack!";
        private const string String1102 = "All that remains from your battle here is a broken dog collar and a nice leatherette chew toy.";
        private const string String1161 = "Ee aiyee aiyo!  You have NO interest in eating any of the eggs from those chickens!";
        private const string String11B5 = "You must have fought enough cholesterol here to clog Loch Lomond.";
        private const string String11F7 = "It looks like a happy horde of harpies.  And to think that when you came in here, you thought Harp meant lager, not monster.";
        private const string String1274 = "Or maybe, at the worst, a Marx brothers movie.";
        private const string String12A3 = "All that remains from your ferocious fight is a feather and a few faintly fetid fumes.";
        private const string String12FA = "You know, with all these barrels, this place does kind of remind you of a labyrinth.";
        private const string String134F = "All that remains from your battle here is a broken axe handle and one shredded black glove.";
        private const string String13AB = "You were warned there would be bodyguards.  You just didn't know how unfriendly they would be.  A wave of magic flashes over you.";
        private const string String142D = "'Just another example of pigs a'dragon,' you say as you survey the remains of this battle.";
        private const string String1488 = "A badly battered knight grimaces as you pass.";
        private const string String14B6 = "'I must warn thee, friends.  In the last room down the hall is a man with an endless supply of a priceless treasure, but if thou canst not defeat the pigs at the top of the hall thou wilt surely not defeat his bodyguards.";
        private const string String1594 = "The sign on the door to the west reads, 'In this room, pigs have wings.'";
        private const string String15DD = "The sign on the door to the west reads, 'In this room you can find silly Scottish pig dogs.";
        private const string String1639 = "The sign on the door to the west reads, 'Old MacDonald's Room";
        private const string String1677 = "The sign on the door has been torn in twain.  The part that remains says, 'Harp....'";
        private const string String16CC = "The sign on the door has been torn in twain.  The part that remains says, '....ease'";
        private const string String1721 = "'No guts, no glory,' you tell yourself, hoping that you are ready to face Fleance.";
        
        // === Functions ================================================
        private void Fn_01(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0140); // A stray breeze kicks up the scent of fermentation.
            L0010: Compare(HasUsedSkill(player, 0x0D), 0x0003);
            L001F: if (JumpNotBelow) goto L0067;
            L0021: RefreshCompareFlags(HasUsedSpell(player, 0x17));
            L002F: if (JumpNotEqual) goto L0067;
            L0031: PushStack(player, 0xA7);
            L0035: PushStack(player, ax);
003A  0036 C4 5E 06  les bx, [bp+0x6]
003D  0039 26 FF 5F 54  call far word [es:bx+0x54]
            L003D: cx = PopStack(player);
            L003E: cx = PopStack(player);
            L003F: RefreshCompareFlags(ax);
            L0041: if (JumpNotEqual) goto L0067;
            L0043: PushStack(player, 0x93);
            L0047: PushStack(player, ax);
004C  0048 C4 5E 06  les bx, [bp+0x6]
004F  004B 26 FF 5F 54  call far word [es:bx+0x54]
            L004F: cx = PopStack(player);
            L0050: cx = PopStack(player);
            L0051: RefreshCompareFlags(ax);
            L0053: if (JumpNotEqual) goto L0067;
            L0055: PushStack(player, 0x86);
            L0059: PushStack(player, ax);
005E  005A C4 5E 06  les bx, [bp+0x6]
0061  005D 26 FF 5F 54  call far word [es:bx+0x54]
            L0061: cx = PopStack(player);
            L0062: cx = PopStack(player);
            L0063: RefreshCompareFlags(ax);
            L0065: if (JumpEqual) goto L00A7;
            L0067: ShowMessage(player, String0173); // You've uncovered a hidden door!
            L0074: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0092: PushStack(player, GetFacing(player));
            L009A: PushStack(player, GetCurrentTile(player));
00A6  00A2 B8 01 00  mov ax, 0x1
            L00A5: goto L00D6;
            L00A7: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L00C4: SetWallObject(player, 0x00, GetCurrentTile(player), GetFacing(player));
            L00E1: return; // RETURN;
        }

        private void Fn_02(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFlag(player, 0x02, 0x17, 0x01);
            L0018: Compare(GetFlag(player, 0x03, 0x11), 0x0001);
            L002C: if (JumpNotEqual) goto L004C;
            L002E: TeleportParty(player, 0x05, 0x01, 0xFA, 0x03, isForwardMove);
            L0049: goto L0287;
            L004C: Compare(GetFacing(player), 0x0003);
            L0056: if (JumpEqual) goto L005B;
            L0058: goto L025B;
            L005B: Compare(HasUsedSkill(player, 0x0D), 0x0004);
            L006A: if (JumpBelow) goto L006F;
            L006C: goto L00F9;
            L006F: RefreshCompareFlags(HasUsedSpell(player, 0x17));
            L007D: if (JumpNotEqual) goto L00F9;
            L007F: PushStack(player, 0xA7);
            L0083: PushStack(player, ax);
016B  0084 C4 5E 06  les bx, [bp+0x6]
016E  0087 26 FF 5F 54  call far word [es:bx+0x54]
            L008B: cx = PopStack(player);
            L008C: cx = PopStack(player);
            L008D: RefreshCompareFlags(ax);
            L008F: if (JumpNotEqual) goto L00F9;
            L0091: PushStack(player, 0x93);
            L0095: PushStack(player, ax);
017D  0096 C4 5E 06  les bx, [bp+0x6]
0180  0099 26 FF 5F 54  call far word [es:bx+0x54]
            L009D: cx = PopStack(player);
            L009E: cx = PopStack(player);
            L009F: RefreshCompareFlags(ax);
            L00A1: if (JumpNotEqual) goto L00F9;
            L00A3: PushStack(player, 0x86);
            L00A7: PushStack(player, ax);
018F  00A8 C4 5E 06  les bx, [bp+0x6]
0192  00AB 26 FF 5F 54  call far word [es:bx+0x54]
            L00AF: cx = PopStack(player);
            L00B0: cx = PopStack(player);
            L00B1: RefreshCompareFlags(ax);
            L00B3: if (JumpNotEqual) goto L00F9;
            L00B5: PushStack(player, 0x01);
            L00B9: PushStack(player, 0x00);
01A3  00BC C4 5E 06  les bx, [bp+0x6]
01A6  00BF 26 FF 5F 04  call far word [es:bx+0x4]
            L00C3: cx = PopStack(player);
            L00C4: cx = PopStack(player);
            L00C5: Compare(ax, 0x0001);
            L00C8: if (JumpEqual) goto L00F9;
            L00CA: Compare(GetFlag(player, 0x02, 0x24), 0x0001);
            L00DE: if (JumpEqual) goto L00F9;
            L00E0: Compare(GetFlag(player, 0x02, 0x14), 0x0001);
            L00F4: if (JumpEqual) goto L00F9;
            L00F6: goto L025B;
            L00F9: SetWallObject(player, 0x01, GetCurrentTile(player), 0x03);
            L0113: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0130: PushStack(player, 0x01);
            L0134: PushStack(player, ax);
            L0135: PushStack(player, 0x00);
021F  0138 C4 5E 06  les bx, [bp+0x6]
0222  013B 26 FF 1F  call far word [es:bx]
0225  013E 83 C4 06  add sp, 0x6
            L0141: PushStack(player, 0x68);
            L0145: PushStack(player, ax);
022D  0146 C4 5E 06  les bx, [bp+0x6]
0230  0149 26 FF 5F 54  call far word [es:bx+0x54]
            L014D: cx = PopStack(player);
            L014E: cx = PopStack(player);
            L014F: RefreshCompareFlags(ax);
            L0151: if (JumpEqual) goto L01CC;
            L0153: ax = HasItem(player, 0xC1);
            L0161: if (JumpEqual) goto L0166;
            L0163: goto L0219;
            L0166: ax = HasItem(player, 0xC2);
            L0174: if (JumpEqual) goto L0179;
            L0176: goto L0219;
            L0179: ax = HasItem(player, 0xC3);
            L0187: if (JumpEqual) goto L018C;
            L0189: goto L0219;
            L018C: ax = HasItem(player, 0xDA);
            L019A: if (JumpNotEqual) goto L0219;
            L019C: ax = HasItem(player, 0xDB);
            L01AA: if (JumpNotEqual) goto L0219;
            L01AC: ax = HasItem(player, 0xDC);
            L01BA: if (JumpNotEqual) goto L0219;
            L01BC: ax = HasItem(player, 0xDD);
            L01CA: if (JumpNotEqual) goto L0219;
            L01CC: Compare(GetSkillLevel(player, 0x0E), 0x0006);
            L01DB: if (JumpBelow) goto L0207;
            L01DD: ax = HasUsedItem(player, 0xC1, 0xC3);
            L01F0: if (JumpNotEqual) goto L0219;
            L01F2: ax = HasUsedItem(player, 0xDA, 0xDD);
            L0205: if (JumpNotEqual) goto L0219;
            L0207: PushStack(player, 0xC0);
            L020B: PushStack(player, ax);
02F3  020C C4 5E 06  les bx, [bp+0x6]
02F6  020F 26 FF 5F 54  call far word [es:bx+0x54]
            L0213: cx = PopStack(player);
            L0214: cx = PopStack(player);
            L0215: RefreshCompareFlags(ax);
            L0217: if (JumpEqual) goto L0233;
            L0219: ShowMessage(player, String0193); // You have unlocked the hidden door!
            L0226: PushStack(player, 0x01);
            L022A: PushStack(player, 0x11);
0315  022E B8 03 00  mov ax, 0x3
            L0231: goto L027D;
            L0233: SetWallPassable(player, GetCurrentTile(player), 0x03, 0x00);
            L024C: ShowMessage(player, String01B6); // There is a door here, but it is locked.
            L0259: goto L0287;
            L025B: SetWallPassable(player, GetCurrentTile(player), 0x03, 0x00);
            L0274: PushStack(player, 0x00);
            L0277: PushStack(player, 0x01);
            L027B: PushStack(player, 0x00);
0365  027E C4 5E 06  les bx, [bp+0x6]
0368  0281 26 FF 1F  call far word [es:bx]
036B  0284 83 C4 06  add sp, 0x6
            L0287: return; // RETURN;
        }

        private void Fn_03(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x68);
            L0007: PushStack(player, ax);
0378  0008 C4 5E 06  les bx, [bp+0x6]
037B  000B 26 FF 5F 54  call far word [es:bx+0x54]
            L000F: cx = PopStack(player);
            L0010: cx = PopStack(player);
            L0011: RefreshCompareFlags(ax);
            L0013: if (JumpEqual) goto L008E;
            L0015: ax = HasItem(player, 0xC1);
            L0023: if (JumpEqual) goto L0028;
            L0025: goto L00DB;
            L0028: ax = HasItem(player, 0xC2);
            L0036: if (JumpEqual) goto L003B;
            L0038: goto L00DB;
            L003B: ax = HasItem(player, 0xC3);
            L0049: if (JumpEqual) goto L004E;
            L004B: goto L00DB;
            L004E: ax = HasItem(player, 0xDA);
            L005C: if (JumpNotEqual) goto L00DB;
            L005E: ax = HasItem(player, 0xDB);
            L006C: if (JumpNotEqual) goto L00DB;
            L006E: ax = HasItem(player, 0xDC);
            L007C: if (JumpNotEqual) goto L00DB;
            L007E: ax = HasItem(player, 0xDD);
            L008C: if (JumpNotEqual) goto L00DB;
            L008E: Compare(GetSkillLevel(player, 0x0E), 0x0001);
            L009D: if (JumpBelow) goto L00C9;
            L009F: ax = HasUsedItem(player, 0xC1, 0xC3);
            L00B2: if (JumpNotEqual) goto L00DB;
            L00B4: ax = HasUsedItem(player, 0xDA, 0xDD);
            L00C7: if (JumpNotEqual) goto L00DB;
            L00C9: PushStack(player, 0xC0);
            L00CD: PushStack(player, ax);
043E  00CE C4 5E 06  les bx, [bp+0x6]
0441  00D1 26 FF 5F 54  call far word [es:bx+0x54]
            L00D5: cx = PopStack(player);
            L00D6: cx = PopStack(player);
            L00D7: RefreshCompareFlags(ax);
            L00D9: if (JumpEqual) goto L0108;
            L00DB: ShowMessage(player, String01DE); // You've picked the lock. Proceed.
            L00E8: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0106: goto L0132;
            L0108: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0125: ShowMessage(player, String01FF); // Funny how an irksome little lock on a flimsy little door can keep out a big strong person like you.
            L0132: return; // RETURN;
        }

        private void Fn_04(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, 0x0B), 0x0001);
            L0012: if (JumpNotBelow) goto L004A;
            L0014: PushStack(player, 0xA6);
            L0018: PushStack(player, ax);
04BD  0019 C4 5E 06  les bx, [bp+0x6]
04C0  001C 26 FF 5F 54  call far word [es:bx+0x54]
            L0020: cx = PopStack(player);
            L0021: cx = PopStack(player);
            L0022: RefreshCompareFlags(ax);
            L0024: if (JumpNotEqual) goto L004A;
            L0026: PushStack(player, 0x62);
            L002A: PushStack(player, ax);
04CF  002B C4 5E 06  les bx, [bp+0x6]
04D2  002E 26 FF 5F 54  call far word [es:bx+0x54]
            L0032: cx = PopStack(player);
            L0033: cx = PopStack(player);
            L0034: RefreshCompareFlags(ax);
            L0036: if (JumpNotEqual) goto L004A;
            L0038: PushStack(player, 0x8F);
            L003C: PushStack(player, ax);
04E1  003D C4 5E 06  les bx, [bp+0x6]
04E4  0040 26 FF 5F 54  call far word [es:bx+0x54]
            L0044: cx = PopStack(player);
            L0045: cx = PopStack(player);
            L0046: RefreshCompareFlags(ax);
            L0048: if (JumpEqual) goto L0057;
            L004A: ShowMessage(player, String0263); // You find some tracks indicating that something headed off this way.
            L0057: return; // RETURN;
        }

        private void Fn_05(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si, di);
            L0005: di = 0;
            L0007: si = 0;
            L0009: ax = GetFlag(player, 0x03, 0x08);
0517  001A 8B F8  mov di, ax
0519  001C 47     inc di
051A  001D 8B F7  mov si, di
            L001F: Compare(si, 0x13);
            L0022: if (JumpLessOrEqual) goto L002B;
0521  0024 8B C6  mov ax, si
            L0026: si = ax + 0xFFEC;
            L002B: Compare(si, 0x0E);
            L002E: if (JumpLessOrEqual) goto L0037;
052D  0030 8B C6  mov ax, si
            L0032: si = ax + 0xFFF1;
            L0037: Compare(si, 0x09);
            L003A: if (JumpLessOrEqual) goto L0043;
0539  003C 8B C6  mov ax, si
            L003E: si = ax + 0xFFF6;
            L0043: Compare(si, 0x04);
            L0046: if (JumpLessOrEqual) goto L004F;
0545  0048 8B C6  mov ax, si
            L004A: si = ax + 0xFFFB;
054C  004F 0B F6  or si, si
054E  0051 7D 02  jge 0x55
            L0053: si = 0;
            L0055: Compare(si, 0x1D);
            L0058: if (JumpLessOrEqual) goto L005C;
            L005A: si = 0;
0559  005C 83 FF 1E  cmp di, 0x1e
            L005F: if (JumpLessOrEqual) goto L0063;
            L0061: di = 0;
0560  0063 57     push di
            L0064: PushStack(player, 0x08);
            L0068: PushStack(player, 0x03);
0569  006C C4 5E 06  les bx, [bp+0x6]
056C  006F 26 FF 1F  call far word [es:bx]
056F  0072 83 C4 06  add sp, 0x6
0572  0075 83 FF 1A  cmp di, 0x1a
            L0078: if (JumpNotEqual) goto L007F;
0577  007A B8 01 00  mov ax, 0x1
            L007D: goto L0081;
            L007F: PushStack(player, 0x00);
057F  0082 83 FF 14  cmp di, 0x14
            L0085: if (JumpNotEqual) goto L008C;
0584  0087 B8 01 00  mov ax, 0x1
            L008A: goto L008E;
0589  008C 33 C0  xor ax, ax
            L008E: dx = PopStack(player);
058C  008F 0B D0  or dx, ax
            L0091: PushStack(player, dx);
058F  0092 83 FF 0E  cmp di, 0xe
            L0095: if (JumpNotEqual) goto L009C;
0594  0097 B8 01 00  mov ax, 0x1
            L009A: goto L009E;
0599  009C 33 C0  xor ax, ax
            L009E: dx = PopStack(player);
059C  009F 0B D0  or dx, ax
            L00A1: PushStack(player, dx);
059F  00A2 83 FF 08  cmp di, 0x8
            L00A5: if (JumpNotEqual) goto L00AC;
05A4  00A7 B8 01 00  mov ax, 0x1
            L00AA: goto L00AE;
05A9  00AC 33 C0  xor ax, ax
            L00AE: dx = PopStack(player);
05AC  00AF 0B D0  or dx, ax
            L00B1: PushStack(player, dx);
05AF  00B2 83 FF 02  cmp di, 0x2
            L00B5: if (JumpNotEqual) goto L00BC;
05B4  00B7 B8 01 00  mov ax, 0x1
            L00BA: goto L00BE;
05B9  00BC 33 C0  xor ax, ax
            L00BE: dx = PopStack(player);
05BC  00BF 0B D0  or dx, ax
            L00C1: if (JumpNotEqual) goto L00C6;
            L00C3: goto L0317;
            L00C6: bx = si;
            L00C8: Compare(bx, 0x04);
            L00CB: if (JumpBelowOrEqual) goto L00D0;
            L00CD: goto L0317;
            L00D0: switch (bx) {
                case 0:
                    goto L00D7;
                case 1:
                    goto L00E7;
                case 2:
                    goto L0147;
                case 3:
                    goto L01E8;
                case 4:
                    goto L024B;
            }
            L00D7: ShowMessage(player, String02A7); // You hear some hooves running away.
            L00E4: goto L0317;
            L00E7: ShowMessage(player, String02CA); // You hear someone running towards you.
            L00F4: ShowPortrait(player, 0x001A);
            L0101: ShowMessage(player, String02F0); // *
            L010E: ShowMessage(player, String02F0); // *
            L011B: ShowMessage(player, String02F0); // *
            L0128: ShowMessage(player, String02F2); // The knight tenses, but relaxes when he sees you take a friendly posture.
            L0135: ShowMessage(player, String033B); // 'I can share some news with thee.  A friend of mine was able to use Lodbrok's Blade to send several of the undead kings to their true deaths, but not Lady Macbeth.  He never solved the animal riddle of The Bestiary.'
063F  0142 B8 14 04  mov ax, 0x414
            L0145: goto L00DA;
            L0147: ax = CheckLevel(player, 0x0008);
            L0155: if (JumpEqual) goto L0184;
            L0157: ShowPortrait(player, 0x000E);
            L0164: ShowMessage(player, String0422); // 'Nay!  Put down thy blades.  I am not here to fight thee.  I was told that there were vats full of gold in the Brewery, but all I have found are vats full of ale.  Hast thou?'
            L0171: ShowMessage(player, String04D2); // You shake your head.
067B  017E B8 E7 04  mov ax, 0x4e7
            L0181: goto L00DA;
            L0184: ShowMessage(player, String0547); // Some maddened minotaurs decide that you are trespassing.  They will prosecute you themselves.
            L0191: PushStack(player, 0xB6);
            L0195: PushStack(player, 0x00);
            L0198: PushStack(player, ax);
            L0199: PushStack(player, ax);
            L019A: PushStack(player, ax);
            L019B: PushStack(player, 0xB9);
069C  019F C4 5E 06  les bx, [bp+0x6]
069F  01A2 26 FF 9F D8 00  call far word [es:bx+0xd8]
06A4  01A7 83 C4 0C  add sp, 0xc
            L01AA: AddEncounter(player, 0x01, 0x14);
            L01BC: AddEncounter(player, 0x02, 0x15);
            L01CE: Compare(PartyCount(player), 0x0003);
            L01D9: if (JumpAbove) goto L01DE;
            L01DB: goto L0317;
            L01DE: PushStack(player, 0x14);
06DF  01E2 B8 03 00  mov ax, 0x3
            L01E5: goto L030C;
            L01E8: Compare(GetFlag(player, 0x02, 0x47), 0x0001);
            L01FC: if (JumpNotEqual) goto L0204;
06FB  01FE B8 A5 05  mov ax, 0x5a5
            L0201: goto L00DA;
            L0204: ShowPortrait(player, 0x0025);
            L0211: ShowMessage(player, String02F0); // *
            L021E: ShowMessage(player, String02F0); // *
            L022B: ShowMessage(player, String02F0); // *
            L0238: ShowMessage(player, String05FD); // 'Again our paths cross!  This a pleasant spot for a halfling, no?  But let me warn you:  if you do proceed northwards you will want as many items against undead as you can wield.  Me?  I'm looking for dragons.  Be seeing you!'
0742  0245 B8 E0 06  mov ax, 0x6e0
            L0248: goto L00DA;
            L024B: ShowMessage(player, String02F0); // *
            L0258: ShowMessage(player, String02F0); // *
            L0265: ShowMessage(player, String02F0); // *
            L0272: ShowMessage(player, String0702); // A puny pack o'piglets decides, rather insultingly, that they are bigger than you are.
            L027F: Compare(PartyCount(player), 0x0002);
            L028A: if (JumpBelowOrEqual) goto L0299;
            L028C: ShowMessage(player, String0758); // Okay, so it's not such a puny pack.
            L0299: PushStack(player, 0x5D);
            L029D: PushStack(player, 0x00);
            L02A0: PushStack(player, ax);
            L02A1: PushStack(player, ax);
            L02A2: PushStack(player, 0xB6);
            L02A6: PushStack(player, 0xBD);
07A7  02AA C4 5E 06  les bx, [bp+0x6]
07AA  02AD 26 FF 9F D8 00  call far word [es:bx+0xd8]
07AF  02B2 83 C4 0C  add sp, 0xc
            L02B5: AddEncounter(player, 0x01, 0x18);
            L02C7: Compare(PartyCount(player), 0x0001);
            L02D2: if (JumpBelowOrEqual) goto L02E6;
            L02D4: AddEncounter(player, 0x02, 0x18);
            L02E6: Compare(PartyCount(player), 0x0002);
            L02F1: if (JumpBelowOrEqual) goto L0317;
            L02F3: AddEncounter(player, 0x03, 0x18);
            L0305: AddEncounter(player, 0x04, 0x18);
            L0317: return; // RETURN (restoring si, di);
        }

        private void Fn_06(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x0A));
            L0016: if (JumpNotEqual) goto L004F;
            L0018: SetFlag(player, 0x02, 0x17, 0x01);
            L002D: SetFlag(player, 0x03, 0x0A, 0x01);
            L0042: ShowMessage(player, String077C); // Boy, is that a heady smell!  This large room is filled with vats.  You suspect that someday whatever is in those vats will turn into ale.  Medieval water quality and sanitation being what it is, it is far safer to drink small ale (low alcohol) than water these days.
            L004F: Compare(GetFacing(player), 0x0002);
            L0059: if (JumpNotEqual) goto L0068;
            L005B: ShowMessage(player, String0887); // To the east is The Gallery.
            L0068: return; // RETURN;
        }

        private void Fn_07(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String08A3); // There is no obvious way to get into that vat.  Besides, doing so would probably kill you.
            L0010: return; // RETURN;
        }

        private void Fn_08(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x04, 0x01, 0xC0, 0x02, isForwardMove);
            L001E: return; // RETURN;
        }

        private void Fn_09(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String08FD); // These vats don't reverberate as much as the ones in the other room, but there's still no way in.
            L0010: return; // RETURN;
        }

        private void Fn_0A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, 0x0B), 0x0001);
            L0012: if (JumpNotBelow) goto L004A;
            L0014: PushStack(player, 0xA6);
            L0018: PushStack(player, ax);
08E9  0019 C4 5E 06  les bx, [bp+0x6]
08EC  001C 26 FF 5F 54  call far word [es:bx+0x54]
            L0020: cx = PopStack(player);
            L0021: cx = PopStack(player);
            L0022: RefreshCompareFlags(ax);
            L0024: if (JumpNotEqual) goto L004A;
            L0026: PushStack(player, 0x62);
            L002A: PushStack(player, ax);
08FB  002B C4 5E 06  les bx, [bp+0x6]
08FE  002E 26 FF 5F 54  call far word [es:bx+0x54]
            L0032: cx = PopStack(player);
            L0033: cx = PopStack(player);
            L0034: RefreshCompareFlags(ax);
            L0036: if (JumpNotEqual) goto L004A;
            L0038: PushStack(player, 0x8F);
            L003C: PushStack(player, ax);
090D  003D C4 5E 06  les bx, [bp+0x6]
0910  0040 26 FF 5F 54  call far word [es:bx+0x54]
            L0044: cx = PopStack(player);
            L0045: cx = PopStack(player);
            L0046: RefreshCompareFlags(ax);
            L0048: if (JumpEqual) goto L005C;
            L004A: ShowMessage(player, String095E); // You find some footprints heading to the north.
0927  0057 B8 01 00  mov ax, 0x1
            L005A: goto L005E;
            L005C: SetFlag(player, 0x03, 0x09, 0x00);
            L0070: return; // RETURN;
        }

        private void Fn_0B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, 0x0B), 0x0001);
            L0012: if (JumpNotBelow) goto L004A;
            L0014: PushStack(player, 0xA6);
            L0018: PushStack(player, ax);
095B  0019 C4 5E 06  les bx, [bp+0x6]
095E  001C 26 FF 5F 54  call far word [es:bx+0x54]
            L0020: cx = PopStack(player);
            L0021: cx = PopStack(player);
            L0022: RefreshCompareFlags(ax);
            L0024: if (JumpNotEqual) goto L004A;
            L0026: PushStack(player, 0x62);
            L002A: PushStack(player, ax);
096D  002B C4 5E 06  les bx, [bp+0x6]
0970  002E 26 FF 5F 54  call far word [es:bx+0x54]
            L0032: cx = PopStack(player);
            L0033: cx = PopStack(player);
            L0034: RefreshCompareFlags(ax);
            L0036: if (JumpNotEqual) goto L004A;
            L0038: PushStack(player, 0x8F);
            L003C: PushStack(player, ax);
097F  003D C4 5E 06  les bx, [bp+0x6]
0982  0040 26 FF 5F 54  call far word [es:bx+0x54]
            L0044: cx = PopStack(player);
            L0045: cx = PopStack(player);
            L0046: RefreshCompareFlags(ax);
            L0048: if (JumpEqual) goto L0087;
            L004A: ShowMessage(player, String098D); // You find some footprints heading to the west.
            L0057: SetFlag(player, 0x03, 0x09, 0x01);
            L006C: Compare(GetCurrentTile(player), 0x0016);
            L0076: if (JumpNotEqual) goto L009B;
            L0078: ShowMessage(player, String09BB); // No, you're not the only one who finds that odd.
            L0085: goto L009B;
            L0087: SetFlag(player, 0x03, 0x09, 0x00);
            L009B: RefreshCompareFlags(GetFlag(player, 0x03, 0x0C));
            L00AE: if (JumpNotEqual) goto L00D2;
            L00B0: ShowMessage(player, String09EB); // This room has not as heavy an odor as the other rooms you've encountered in the brewery.
            L00BD: SetFlag(player, 0x03, 0x0C, 0x01);
            L00D2: return; // RETURN;
        }

        private void Fn_0C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0x23), 0x0001);
            L0017: if (JumpEqual) goto L0089;
            L0019: Compare(HasUsedSkill(player, 0x0D), 0x0003);
            L0028: if (JumpNotBelow) goto L0073;
            L002A: RefreshCompareFlags(HasUsedSpell(player, 0x17));
            L0038: if (JumpNotEqual) goto L0073;
            L003A: PushStack(player, 0xA7);
            L003E: PushStack(player, ax);
0A55  003F C4 5E 06  les bx, [bp+0x6]
0A58  0042 26 FF 5F 54  call far word [es:bx+0x54]
            L0046: cx = PopStack(player);
            L0047: cx = PopStack(player);
            L0048: RefreshCompareFlags(ax);
            L004A: if (JumpNotEqual) goto L0073;
            L004C: PushStack(player, 0x93);
            L0050: PushStack(player, ax);
0A67  0051 C4 5E 06  les bx, [bp+0x6]
0A6A  0054 26 FF 5F 54  call far word [es:bx+0x54]
            L0058: cx = PopStack(player);
            L0059: cx = PopStack(player);
            L005A: RefreshCompareFlags(ax);
            L005C: if (JumpNotEqual) goto L0073;
            L005E: PushStack(player, 0x86);
            L0062: PushStack(player, ax);
0A79  0063 C4 5E 06  les bx, [bp+0x6]
0A7C  0066 26 FF 5F 54  call far word [es:bx+0x54]
            L006A: cx = PopStack(player);
            L006B: cx = PopStack(player);
            L006C: RefreshCompareFlags(ax);
            L006E: if (JumpNotEqual) goto L0073;
            L0070: goto L00F4;
            L0073: Compare(GetFlag(player, 0x03, 0x09), 0x0001);
            L0087: if (JumpNotEqual) goto L00F4;
            L0089: ShowMessage(player, String0A44); // If you work on this seam you might just....
            L0096: ShowMessage(player, String0A70); // Yes!  You have managed to pry open a secret door.
            L00A3: SetFlag(player, 0x02, 0x23, 0x01);
            L00B8: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L00D6: SetWallObject(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L00F4: return; // RETURN;
        }

        private void Fn_0D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFlag(player, 0x03, 0x09, 0x00);
            L0017: return; // RETURN;
        }

        private void Fn_0E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0AA2); // There's a short little tunnel through here.
            L0010: TeleportParty(player, 0x04, 0x03, 0x13, 0x00, isForwardMove);
            L002A: return; // RETURN;
        }

        private void Fn_0F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0ACE); // You follow the tunnel back into the vat.
            L0010: TeleportParty(player, 0x04, 0x03, 0x15, 0x02, isForwardMove);
            L002B: return; // RETURN;
        }

        private void Fn_10(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFlag(player, 0x02, 0x21, 0x01);
            L0018: Compare(GetFlag(player, 0x02, 0x18), 0x0001);
            L002C: if (JumpEqual) goto L0044;
            L002E: Compare(GetFlag(player, 0x02, 0x21), 0x0001);
            L0042: if (JumpNotEqual) goto L006F;
            L0044: SetWallPassable(player, 0x0D, 0x02, 0x01);
            L005A: PushStack(player, 0x02);
            L005E: PushStack(player, 0x0D);
            L0062: PushStack(player, 0x01);
0BE4  0066 C4 5E 06  les bx, [bp+0x6]
0BE7  0069 26 FF 5F 30  call far word [es:bx+0x30]
            L006D: goto L0096;
            L006F: SetWallObject(player, 0x00, 0x0D, 0x02);
            L0084: SetWallPassable(player, 0x0D, 0x02, 0x00);
            L0099: RefreshCompareFlags(GetFlag(player, 0x03, 0x0A));
            L00AC: if (JumpNotEqual) goto L00E7;
            L00AE: SetFlag(player, 0x03, 0x0A, 0x01);
            L00C3: SetFlag(player, 0x03, 0x0B, 0x01);
            L00D8: ShowMessage(player, String0AF7); // Boy, is that a heady smell!  This large room is dominated by one big vat in the center, but there is a pile of smaller vats in the northeast corner.  The smell is almost thick enough to chew.
            L00E5: goto L011E;
            L00E7: RefreshCompareFlags(GetFlag(player, 0x03, 0x0B));
            L00FA: if (JumpNotEqual) goto L011E;
            L00FC: ShowMessage(player, String0BB7); // Jehosophat!  That has to be the biggest barrel o'brew you've ever seen!  Some smaller vats are piled in the northeast corner of the room.
            L0109: SetFlag(player, 0x03, 0x0B, 0x01);
            L011E: return; // RETURN;
        }

        private void Fn_11(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0x14), 0x0001);
            L0017: if (JumpNotEqual) goto L001C;
            L0019: goto L00BF;
            L001C: Compare(GetFlag(player, 0x03, 0x01), 0x0001);
            L0030: if (JumpEqual) goto L0035;
            L0032: goto L00FF;
            L0035: Compare(GetFlag(player, 0x03, 0x02), 0x0001);
            L0049: if (JumpEqual) goto L004E;
            L004B: goto L00FF;
            L004E: PushStack(player, 0x03);
            L0052: PushStack(player, ax);
0CF1  0053 C4 5E 06  les bx, [bp+0x6]
0CF4  0056 26 FF 5F 04  call far word [es:bx+0x4]
            L005A: cx = PopStack(player);
            L005B: cx = PopStack(player);
            L005C: Compare(ax, 0x0001);
            L005F: if (JumpEqual) goto L0064;
            L0061: goto L00FF;
            L0064: Compare(GetFlag(player, 0x03, 0x04), 0x0001);
            L0078: if (JumpEqual) goto L007D;
            L007A: goto L00FF;
            L007D: Compare(GetFlag(player, 0x03, 0x05), 0x0001);
            L0091: if (JumpNotEqual) goto L00FF;
            L0093: Compare(GetFlag(player, 0x03, 0x06), 0x0001);
            L00A7: if (JumpNotEqual) goto L00FF;
            L00A9: Compare(GetFlag(player, 0x03, 0x07), 0x0001);
            L00BD: if (JumpNotEqual) goto L00FF;
            L00BF: SetFlag(player, 0x02, 0x17, 0x01);
            L00D4: SetWallPassable(player, 0x1E, 0x03, 0x01);
            L00EA: PushStack(player, 0x03);
            L00EE: PushStack(player, 0x1E);
            L00F2: PushStack(player, 0x01);
0D94  00F6 C4 5E 06  les bx, [bp+0x6]
0D97  00F9 26 FF 5F 30  call far word [es:bx+0x30]
            L00FD: goto L0126;
            L00FF: SetWallObject(player, 0x00, 0x1E, 0x03);
            L0114: SetWallPassable(player, 0x1E, 0x03, 0x00);
            L0129: return; // RETURN;
        }

        private void Fn_12(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0003);
            L0010: RefreshCompareFlags(GetFlag(player, 0x03, 0x0D));
            L0023: if (JumpNotEqual) goto L004C;
            L0025: SetFlag(player, 0x03, 0x0D, 0x01);
            L003A: ShowMessage(player, String0C41); // 'Not so fast!  I be the bouncer of this, The Raging Boar Inn, and we have a few ground rules.  There's to be no pinching of the employees.  There's to be no pinching of the silverware.  In fact, no pinching!  Any questions?'
0E10  0047 B8 22 0D  mov ax, 0xd22
            L004A: goto L005B;
            L004C: Compare(GetFacing(player), 0x0002);
            L0056: if (JumpNotEqual) goto L0065;
            L0058: ShowMessage(player, String0D50); // Thankee kindly for frequenting the Boar.
            L0065: return; // RETURN;
        }

        private void Fn_13(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x10));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00CF;
            L001B: Compare(GetFlag(player, 0x03, 0x0F), 0x0001);
            L002F: if (JumpNotEqual) goto L0055;
            L0031: ShowMessage(player, String0D79); // The dairy man, er, pig, does not want to talk to you.
            L003E: SetFlag(player, 0x03, 0x10, 0x01);
            L0053: goto L00CF;
            L0055: SetFlag(player, 0x03, 0x0F, 0x01);
            L006A: ShowPortrait(player, 0x0005);
            L0077: ax = HasItem(player, 0xEE);
            L0085: if (JumpEqual) goto L008C;
0EB7  0087 B8 AF 0D  mov ax, 0xdaf
            L008A: goto L00C5;
            L008C: ax = HasItem(player, 0xBF);
            L009A: if (JumpEqual) goto L00C2;
            L009C: ShowMessage(player, String0E7C); // 'Excellent!  Excellent!  Thou hast come with that which I require!  The deal is done!'  You shake hands, uh, paws, uh, appendages on the deal.
            L00A9: RemoveItem(player, 0xBF);
            L00B5: PushStack(player, 0xEE);
0EE9  00B9 C4 5E 06  les bx, [bp+0x6]
0EEC  00BC 26 FF 5F 48  call far word [es:bx+0x48]
            L00C0: goto L00CE;
            L00C2: ShowMessage(player, String0F0B); // Folly!  Folly!  I cannot trade my dairywares unless thou brings me something of great value in exchange!  Return when thou dost wish to trade, no sooner!
            L00CF: return; // RETURN;
        }

        private void Fn_14(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x01));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L01C5;
            L001B: PushStack(player, 0x01);
            L001F: PushStack(player, ax);
            L0020: PushStack(player, 0x03);
0F25  0024 C4 5E 06  les bx, [bp+0x6]
0F28  0027 26 FF 1F  call far word [es:bx]
0F2B  002A 83 C4 06  add sp, 0x6
            L002D: ShowMessage(player, String0FA5); // It looks like you have found the raging boars!
            L003A: Compare(PartyCount(player), 0x0003);
            L0045: if (JumpBelowOrEqual) goto L0054;
            L0047: ShowMessage(player, String0FD4); // And, sadly, they have found you.
            L0054: Compare(GetFlag(player, 0x03, 0x02), 0x0001);
            L0068: if (JumpEqual) goto L006D;
            L006A: goto L011B;
            L006D: PushStack(player, 0x03);
            L0071: PushStack(player, ax);
0F73  0072 C4 5E 06  les bx, [bp+0x6]
0F76  0075 26 FF 5F 04  call far word [es:bx+0x4]
            L0079: cx = PopStack(player);
            L007A: cx = PopStack(player);
            L007B: Compare(ax, 0x0001);
            L007E: if (JumpEqual) goto L0083;
            L0080: goto L011B;
            L0083: Compare(GetFlag(player, 0x03, 0x04), 0x0001);
            L0097: if (JumpEqual) goto L009C;
            L0099: goto L011B;
            L009C: Compare(GetFlag(player, 0x03, 0x05), 0x0001);
            L00B0: if (JumpNotEqual) goto L011B;
            L00B2: Compare(GetFlag(player, 0x03, 0x06), 0x0001);
            L00C6: if (JumpNotEqual) goto L011B;
            L00C8: Compare(GetFlag(player, 0x03, 0x07), 0x0001);
            L00DC: if (JumpNotEqual) goto L011B;
            L00DE: ax = HasItem(player, 0xFD);
            L00EC: if (JumpNotEqual) goto L011B;
            L00EE: ax = IsFlagOn(player, 0x02, 0x21);
            L0101: if (JumpEqual) goto L011B;
1004  0103 B8 DD 01  mov ax, 0x1dd
            L0106: PushStack(player, ax);
            L0107: PushStack(player, 0x00);
            L010A: PushStack(player, 0xFD);
            L010E: PushStack(player, 0xCC);
            L0112: PushStack(player, 0xB9);
1017  0116 B8 FD 00  mov ax, 0xfd
            L0119: goto L0131;
            L011B: AddTreasure(player, 0x007D, 0x00, 0xA7, 0xB9, 0x8D, 0x05);
            L013D: AddEncounter(player, 0x01, 0x1D);
            L014F: AddEncounter(player, 0x02, 0x1E);
            L0161: Compare(PartyCount(player), 0x0002);
            L016C: if (JumpBelowOrEqual) goto L0192;
            L016E: AddEncounter(player, 0x03, 0x1F);
            L0180: AddEncounter(player, 0x04, 0x1F);
            L0192: Compare(PartyCount(player), 0x0003);
            L019D: if (JumpBelowOrEqual) goto L01D2;
            L019F: AddEncounter(player, 0x05, 0x1F);
            L01B1: AddEncounter(player, 0x06, 0x1F);
            L01C3: goto L01D2;
            L01C5: ShowMessage(player, String0FF5); // Boy, was there some shakin' and bacon here.
            L01D2: return; // RETURN;
        }

        private void Fn_15(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x02));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L0171;
            L001B: SetFlag(player, 0x03, 0x02, 0x01);
            L0030: ShowMessage(player, String1021); // I guess we know what they meant by pigs having wings.
            L003D: Compare(GetFlag(player, 0x03, 0x01), 0x0001);
            L0051: if (JumpEqual) goto L0056;
            L0053: goto L0104;
            L0056: PushStack(player, 0x03);
            L005A: PushStack(player, ax);
1130  005B C4 5E 06  les bx, [bp+0x6]
1133  005E 26 FF 5F 04  call far word [es:bx+0x4]
            L0062: cx = PopStack(player);
            L0063: cx = PopStack(player);
            L0064: Compare(ax, 0x0001);
            L0067: if (JumpEqual) goto L006C;
            L0069: goto L0104;
            L006C: Compare(GetFlag(player, 0x03, 0x04), 0x0001);
            L0080: if (JumpEqual) goto L0085;
            L0082: goto L0104;
            L0085: Compare(GetFlag(player, 0x03, 0x05), 0x0001);
            L0099: if (JumpNotEqual) goto L0104;
            L009B: Compare(GetFlag(player, 0x03, 0x06), 0x0001);
            L00AF: if (JumpNotEqual) goto L0104;
            L00B1: Compare(GetFlag(player, 0x03, 0x07), 0x0001);
            L00C5: if (JumpNotEqual) goto L0104;
            L00C7: ax = HasItem(player, 0xFD);
            L00D5: if (JumpNotEqual) goto L0104;
            L00D7: ax = IsFlagOn(player, 0x02, 0x21);
            L00EA: if (JumpEqual) goto L0104;
11C1  00EC B8 DD 01  mov ax, 0x1dd
            L00EF: PushStack(player, ax);
            L00F0: PushStack(player, 0x00);
            L00F3: PushStack(player, 0xFD);
            L00F7: PushStack(player, 0xCC);
            L00FB: PushStack(player, 0xB9);
11D4  00FF B8 FD 00  mov ax, 0xfd
            L0102: goto L010E;
            L0104: PushStack(player, 0xBB);
            L0108: PushStack(player, 0x00);
            L010B: PushStack(player, ax);
            L010C: PushStack(player, ax);
            L010D: PushStack(player, ax);
            L010E: PushStack(player, ax);
11E4  010F C4 5E 06  les bx, [bp+0x6]
11E7  0112 26 FF 9F D8 00  call far word [es:bx+0xd8]
11EC  0117 83 C4 0C  add sp, 0xc
            L011A: AddEncounter(player, 0x01, 0x20);
            L012C: AddEncounter(player, 0x05, 0x27);
            L013E: Compare(PartyCount(player), 0x0003);
            L0149: if (JumpBelowOrEqual) goto L017E;
            L014B: AddEncounter(player, 0x03, 0x20);
            L015D: AddEncounter(player, 0x06, 0x27);
            L016F: goto L017E;
            L0171: ShowMessage(player, String1057); // All that remains from your battle here is an overcooked pork rind.
            L017E: return; // RETURN;
        }

        private void Fn_16(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x03);
            L0007: PushStack(player, ax);
125D  0008 C4 5E 06  les bx, [bp+0x6]
1260  000B 26 FF 5F 04  call far word [es:bx+0x4]
            L000F: cx = PopStack(player);
            L0010: cx = PopStack(player);
            L0011: RefreshCompareFlags(ax);
            L0013: if (JumpEqual) goto L0018;
            L0015: goto L022C;
            L0018: PushStack(player, 0x01);
            L001C: PushStack(player, 0x03);
            L0020: PushStack(player, ax);
1276  0021 C4 5E 06  les bx, [bp+0x6]
1279  0024 26 FF 1F  call far word [es:bx]
127C  0027 83 C4 06  add sp, 0x6
            L002A: ShowMessage(player, String109A); // While you are wondering if the phrase 'silly Scottish pig dogs' is copyrighted, a group of them attack!
            L0037: Compare(GetFlag(player, 0x03, 0x01), 0x0001);
            L004B: if (JumpEqual) goto L0050;
            L004D: goto L0101;
            L0050: Compare(GetFlag(player, 0x03, 0x02), 0x0001);
            L0064: if (JumpEqual) goto L0069;
            L0066: goto L0101;
            L0069: Compare(GetFlag(player, 0x03, 0x04), 0x0001);
            L007D: if (JumpEqual) goto L0082;
            L007F: goto L0101;
            L0082: Compare(GetFlag(player, 0x03, 0x05), 0x0001);
            L0096: if (JumpNotEqual) goto L0101;
            L0098: Compare(GetFlag(player, 0x03, 0x06), 0x0001);
            L00AC: if (JumpNotEqual) goto L0101;
            L00AE: Compare(GetFlag(player, 0x03, 0x07), 0x0001);
            L00C2: if (JumpNotEqual) goto L0101;
            L00C4: ax = HasItem(player, 0xFD);
            L00D2: if (JumpNotEqual) goto L0101;
            L00D4: ax = IsFlagOn(player, 0x02, 0x21);
            L00E7: if (JumpEqual) goto L0101;
133E  00E9 B8 DD 01  mov ax, 0x1dd
            L00EC: PushStack(player, ax);
            L00ED: PushStack(player, 0x00);
            L00F0: PushStack(player, 0xFD);
            L00F4: PushStack(player, 0xCC);
            L00F8: PushStack(player, 0xB9);
1351  00FC B8 FD 00  mov ax, 0xfd
            L00FF: goto L0114;
            L0101: PushStack(player, 0x7D);
            L0105: PushStack(player, 0x00);
            L0108: PushStack(player, ax);
            L0109: PushStack(player, 0xB9);
            L010D: PushStack(player, 0xAC);
            L0111: PushStack(player, 0x84);
136A  0115 C4 5E 06  les bx, [bp+0x6]
136D  0118 26 FF 9F D8 00  call far word [es:bx+0xd8]
1372  011D 83 C4 0C  add sp, 0xc
            L0120: ax = CheckLevel(player, 0x000C);
            L012E: if (JumpNotEqual) goto L0133;
            L0130: goto L01B2;
            L0133: AddEncounter(player, 0x01, 0x26);
            L0145: AddEncounter(player, 0x02, 0x25);
            L0157: AddEncounter(player, 0x03, 0x21);
            L0169: Compare(PartyCount(player), 0x0003);
            L0174: if (JumpAbove) goto L0179;
            L0176: goto L0239;
            L0179: AddEncounter(player, 0x05, 0x1F);
            L018B: AddEncounter(player, 0x04, 0x20);
            L019D: AddEncounter(player, 0x06, 0x24);
            L01AF: goto L0239;
            L01B2: AddEncounter(player, 0x01, 0x24);
            L01C4: AddEncounter(player, 0x02, 0x1F);
            L01D6: Compare(PartyCount(player), 0x0002);
            L01E1: if (JumpBelowOrEqual) goto L0207;
            L01E3: AddEncounter(player, 0x03, 0x1F);
            L01F5: AddEncounter(player, 0x04, 0x24);
            L0207: Compare(PartyCount(player), 0x0003);
            L0212: if (JumpBelowOrEqual) goto L0239;
            L0214: AddEncounter(player, 0x05, 0x1E);
147B  0226 B8 25 00  mov ax, 0x25
            L0229: goto L01A0;
            L022C: ShowMessage(player, String1102); // All that remains from your battle here is a broken dog collar and a nice leatherette chew toy.
            L0239: return; // RETURN;
        }

        private void Fn_17(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x04));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L0219;
            L001B: SetFlag(player, 0x03, 0x04, 0x01);
            L0030: ShowMessage(player, String1161); // Ee aiyee aiyo!  You have NO interest in eating any of the eggs from those chickens!
            L003D: Compare(GetFlag(player, 0x03, 0x01), 0x0001);
            L0051: if (JumpEqual) goto L0056;
            L0053: goto L0104;
            L0056: Compare(GetFlag(player, 0x03, 0x02), 0x0001);
            L006A: if (JumpEqual) goto L006F;
            L006C: goto L0104;
            L006F: PushStack(player, 0x03);
            L0073: PushStack(player, ax);
1504  0074 C4 5E 06  les bx, [bp+0x6]
1507  0077 26 FF 5F 04  call far word [es:bx+0x4]
            L007B: cx = PopStack(player);
            L007C: cx = PopStack(player);
            L007D: Compare(ax, 0x0001);
            L0080: if (JumpEqual) goto L0085;
            L0082: goto L0104;
            L0085: Compare(GetFlag(player, 0x03, 0x05), 0x0001);
            L0099: if (JumpNotEqual) goto L0104;
            L009B: Compare(GetFlag(player, 0x03, 0x06), 0x0001);
            L00AF: if (JumpNotEqual) goto L0104;
            L00B1: Compare(GetFlag(player, 0x03, 0x07), 0x0001);
            L00C5: if (JumpNotEqual) goto L0104;
            L00C7: ax = HasItem(player, 0xFD);
            L00D5: if (JumpNotEqual) goto L0104;
            L00D7: ax = IsFlagOn(player, 0x02, 0x21);
            L00EA: if (JumpEqual) goto L0104;
157C  00EC B8 DD 01  mov ax, 0x1dd
            L00EF: PushStack(player, ax);
            L00F0: PushStack(player, 0x00);
            L00F3: PushStack(player, 0xFD);
            L00F7: PushStack(player, 0xCC);
            L00FB: PushStack(player, 0xB9);
158F  00FF B8 FD 00  mov ax, 0xfd
            L0102: goto L0117;
1594  0104 B8 B9 03  mov ax, 0x3b9
            L0107: PushStack(player, ax);
            L0108: PushStack(player, 0x00);
            L010B: PushStack(player, ax);
            L010C: PushStack(player, 0xB9);
            L0110: PushStack(player, 0xB6);
            L0114: PushStack(player, 0x92);
15A8  0118 C4 5E 06  les bx, [bp+0x6]
15AB  011B 26 FF 9F D8 00  call far word [es:bx+0xd8]
15B0  0120 83 C4 0C  add sp, 0xc
            L0123: ax = CheckLevel(player, 0x000C);
            L0131: if (JumpEqual) goto L01B1;
            L0133: AddEncounter(player, 0x01, 0x1C);
            L0145: AddEncounter(player, 0x02, 0x23);
            L0157: AddEncounter(player, 0x03, 0x21);
            L0169: Compare(PartyCount(player), 0x0003);
            L0174: if (JumpAbove) goto L0179;
            L0176: goto L0226;
            L0179: AddEncounter(player, 0x04, 0x1B);
            L018B: AddEncounter(player, 0x05, 0x20);
            L019D: AddEncounter(player, 0x06, 0x22);
            L01AF: goto L0226;
            L01B1: AddEncounter(player, 0x01, 0x22);
            L01C3: AddEncounter(player, 0x02, 0x1A);
            L01D5: Compare(PartyCount(player), 0x0002);
            L01E0: if (JumpBelowOrEqual) goto L0206;
            L01E2: AddEncounter(player, 0x03, 0x1B);
            L01F4: AddEncounter(player, 0x04, 0x1D);
            L0206: Compare(PartyCount(player), 0x0003);
            L0211: if (JumpBelowOrEqual) goto L0226;
16A3  0213 B8 1E 00  mov ax, 0x1e
            L0216: goto L018E;
            L0219: ShowMessage(player, String11B5); // You must have fought enough cholesterol here to clog Loch Lomond.
            L0226: return; // RETURN;
        }

        private void Fn_18(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x05));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L01C8;
            L001B: SetFlag(player, 0x03, 0x05, 0x01);
            L0030: ShowMessage(player, String11F7); // It looks like a happy horde of harpies.  And to think that when you came in here, you thought Harp meant lager, not monster.
            L003D: Compare(PartyCount(player), 0x0003);
            L0048: if (JumpBelowOrEqual) goto L0057;
            L004A: ShowMessage(player, String1274); // Or maybe, at the worst, a Marx brothers movie.
            L0057: Compare(GetFlag(player, 0x03, 0x01), 0x0001);
            L006B: if (JumpEqual) goto L0070;
            L006D: goto L011E;
            L0070: Compare(GetFlag(player, 0x03, 0x02), 0x0001);
            L0084: if (JumpEqual) goto L0089;
            L0086: goto L011E;
            L0089: PushStack(player, 0x03);
            L008D: PushStack(player, ax);
1746  008E C4 5E 06  les bx, [bp+0x6]
1749  0091 26 FF 5F 04  call far word [es:bx+0x4]
            L0095: cx = PopStack(player);
            L0096: cx = PopStack(player);
            L0097: Compare(ax, 0x0001);
            L009A: if (JumpEqual) goto L009F;
            L009C: goto L011E;
            L009F: Compare(GetFlag(player, 0x03, 0x04), 0x0001);
            L00B3: if (JumpNotEqual) goto L011E;
            L00B5: Compare(GetFlag(player, 0x03, 0x06), 0x0001);
            L00C9: if (JumpNotEqual) goto L011E;
            L00CB: Compare(GetFlag(player, 0x03, 0x07), 0x0001);
            L00DF: if (JumpNotEqual) goto L011E;
            L00E1: ax = HasItem(player, 0xFD);
            L00EF: if (JumpNotEqual) goto L011E;
            L00F1: ax = IsFlagOn(player, 0x02, 0x21);
            L0104: if (JumpEqual) goto L011E;
17BE  0106 B8 DD 01  mov ax, 0x1dd
            L0109: PushStack(player, ax);
            L010A: PushStack(player, 0x00);
            L010D: PushStack(player, 0xFD);
            L0111: PushStack(player, 0xCC);
            L0115: PushStack(player, 0xB9);
17D1  0119 B8 FD 00  mov ax, 0xfd
            L011C: goto L0134;
            L011E: AddTreasure(player, 0x007D, 0x00, 0xCC, 0xB9, 0x8C, 0x2B);
            L0140: AddEncounter(player, 0x01, 0x19);
            L0152: AddEncounter(player, 0x05, 0x1A);
            L0164: Compare(PartyCount(player), 0x0002);
            L016F: if (JumpBelowOrEqual) goto L0195;
            L0171: AddEncounter(player, 0x02, 0x1B);
            L0183: AddEncounter(player, 0x06, 0x1C);
            L0195: Compare(PartyCount(player), 0x0003);
            L01A0: if (JumpBelowOrEqual) goto L01D5;
            L01A2: AddEncounter(player, 0x04, 0x19);
            L01B4: AddEncounter(player, 0x03, 0x1A);
            L01C6: goto L01D5;
            L01C8: ShowMessage(player, String12A3); // All that remains from your ferocious fight is a feather and a few faintly fetid fumes.
            L01D5: return; // RETURN;
        }

        private void Fn_19(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x06));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L0187;
            L001B: SetFlag(player, 0x03, 0x06, 0x01);
            L0030: ShowMessage(player, String12FA); // You know, with all these barrels, this place does kind of remind you of a labyrinth.
            L003D: Compare(GetFlag(player, 0x03, 0x01), 0x0001);
            L0051: if (JumpEqual) goto L0056;
            L0053: goto L0104;
            L0056: Compare(GetFlag(player, 0x03, 0x02), 0x0001);
            L006A: if (JumpEqual) goto L006F;
            L006C: goto L0104;
            L006F: PushStack(player, 0x03);
            L0073: PushStack(player, ax);
1903  0074 C4 5E 06  les bx, [bp+0x6]
1906  0077 26 FF 5F 04  call far word [es:bx+0x4]
            L007B: cx = PopStack(player);
            L007C: cx = PopStack(player);
            L007D: Compare(ax, 0x0001);
            L0080: if (JumpEqual) goto L0085;
            L0082: goto L0104;
            L0085: Compare(GetFlag(player, 0x03, 0x04), 0x0001);
            L0099: if (JumpNotEqual) goto L0104;
            L009B: Compare(GetFlag(player, 0x03, 0x05), 0x0001);
            L00AF: if (JumpNotEqual) goto L0104;
            L00B1: Compare(GetFlag(player, 0x03, 0x07), 0x0001);
            L00C5: if (JumpNotEqual) goto L0104;
            L00C7: ax = HasItem(player, 0xFD);
            L00D5: if (JumpNotEqual) goto L0104;
            L00D7: ax = IsFlagOn(player, 0x02, 0x21);
            L00EA: if (JumpEqual) goto L0104;
197B  00EC B8 DD 01  mov ax, 0x1dd
            L00EF: PushStack(player, ax);
            L00F0: PushStack(player, 0x00);
            L00F3: PushStack(player, 0xFD);
            L00F7: PushStack(player, 0xCC);
            L00FB: PushStack(player, 0xB9);
198E  00FF B8 FD 00  mov ax, 0xfd
            L0102: goto L0117;
            L0104: PushStack(player, 0x7D);
            L0108: PushStack(player, 0x00);
            L010B: PushStack(player, ax);
            L010C: PushStack(player, 0x71);
            L0110: PushStack(player, 0x76);
            L0114: PushStack(player, 0x70);
19A7  0118 C4 5E 06  les bx, [bp+0x6]
19AA  011B 26 FF 9F D8 00  call far word [es:bx+0xd8]
19AF  0120 83 C4 0C  add sp, 0xc
            L0123: AddEncounter(player, 0x01, 0x22);
            L0135: AddEncounter(player, 0x02, 0x23);
            L0147: Compare(PartyCount(player), 0x0002);
            L0152: if (JumpBelowOrEqual) goto L0166;
            L0154: AddEncounter(player, 0x03, 0x22);
            L0166: Compare(PartyCount(player), 0x0003);
            L0171: if (JumpBelowOrEqual) goto L0194;
            L0173: AddEncounter(player, 0x04, 0x23);
            L0185: goto L0194;
            L0187: ShowMessage(player, String134F); // All that remains from your battle here is a broken axe handle and one shredded black glove.
            L0194: return; // RETURN;
        }

        private void Fn_1A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x07));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L01E6;
            L001B: SetFlag(player, 0x03, 0x07, 0x01);
            L0030: ShowMessage(player, String13AB); // You were warned there would be bodyguards.  You just didn't know how unfriendly they would be.  A wave of magic flashes over you.
            L003D: ax = GetMaxHits(player);
            L0044: bx = 0x0004;
            L0047: dx = ax % bx; ax = ax / bx;
            L004A: DamagePlayer(player, ax);
            L0054: Compare(GetFlag(player, 0x03, 0x01), 0x0001);
            L0068: if (JumpEqual) goto L006D;
            L006A: goto L011B;
            L006D: Compare(GetFlag(player, 0x03, 0x02), 0x0001);
            L0081: if (JumpEqual) goto L0086;
            L0083: goto L011B;
            L0086: PushStack(player, 0x03);
            L008A: PushStack(player, ax);
1AB0  008B C4 5E 06  les bx, [bp+0x6]
1AB3  008E 26 FF 5F 04  call far word [es:bx+0x4]
            L0092: cx = PopStack(player);
            L0093: cx = PopStack(player);
            L0094: Compare(ax, 0x0001);
            L0097: if (JumpEqual) goto L009C;
            L0099: goto L011B;
            L009C: Compare(GetFlag(player, 0x03, 0x04), 0x0001);
            L00B0: if (JumpNotEqual) goto L011B;
            L00B2: Compare(GetFlag(player, 0x03, 0x05), 0x0001);
            L00C6: if (JumpNotEqual) goto L011B;
            L00C8: Compare(GetFlag(player, 0x03, 0x06), 0x0001);
            L00DC: if (JumpNotEqual) goto L011B;
            L00DE: ax = HasItem(player, 0xFD);
            L00EC: if (JumpNotEqual) goto L011B;
            L00EE: ax = IsFlagOn(player, 0x02, 0x21);
            L0101: if (JumpEqual) goto L011B;
1B28  0103 B8 DD 01  mov ax, 0x1dd
            L0106: PushStack(player, ax);
            L0107: PushStack(player, 0x00);
            L010A: PushStack(player, 0xFD);
            L010E: PushStack(player, 0xCC);
            L0112: PushStack(player, 0xB9);
1B3B  0116 B8 FD 00  mov ax, 0xfd
            L0119: goto L0152;
            L011B: ax = HasItem(player, 0xF0);
            L0129: if (JumpNotEqual) goto L013F;
            L012B: PushStack(player, 0xF5);
            L012F: PushStack(player, 0x00);
            L0132: PushStack(player, 0xCC);
            L0136: PushStack(player, 0xB9);
1B5F  013A B8 F0 00  mov ax, 0xf0
            L013D: goto L014E;
            L013F: PushStack(player, 0xF5);
            L0143: PushStack(player, 0x00);
            L0146: PushStack(player, ax);
            L0147: PushStack(player, 0xCC);
            L014B: PushStack(player, 0xB9);
            L014F: PushStack(player, 0x2B);
1B78  0153 C4 5E 06  les bx, [bp+0x6]
1B7B  0156 26 FF 9F D8 00  call far word [es:bx+0xd8]
1B80  015B 83 C4 0C  add sp, 0xc
            L015E: AddEncounter(player, 0x01, 0x20);
            L0170: AddEncounter(player, 0x05, 0x28);
            L0182: Compare(PartyCount(player), 0x0001);
            L018D: if (JumpBelowOrEqual) goto L01B3;
            L018F: AddEncounter(player, 0x02, 0x21);
            L01A1: AddEncounter(player, 0x06, 0x28);
            L01B3: Compare(PartyCount(player), 0x0003);
            L01BE: if (JumpBelowOrEqual) goto L01F3;
            L01C0: AddEncounter(player, 0x03, 0x21);
            L01D2: AddEncounter(player, 0x04, 0x20);
            L01E4: goto L01F3;
            L01E6: ShowMessage(player, String142D); // 'Just another example of pigs a'dragon,' you say as you survey the remains of this battle.
            L01F3: return; // RETURN;
        }

        private void Fn_1B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x0E));
            L0016: if (JumpNotEqual) goto L0054;
            L0018: ShowPortrait(player, 0x001A);
            L0025: SetFlag(player, 0x03, 0x0E, 0x01);
            L003A: ShowMessage(player, String1488); // A badly battered knight grimaces as you pass.
            L0047: ShowMessage(player, String14B6); // 'I must warn thee, friends.  In the last room down the hall is a man with an endless supply of a priceless treasure, but if thou canst not defeat the pigs at the top of the hall thou wilt surely not defeat his bodyguards.
            L0054: return; // RETURN;
        }

        private void Fn_1C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1594); // The sign on the door to the west reads, 'In this room, pigs have wings.'
            L0010: return; // RETURN;
        }

        private void Fn_1D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String15DD); // The sign on the door to the west reads, 'In this room you can find silly Scottish pig dogs.
            L0010: return; // RETURN;
        }

        private void Fn_1E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1639); // The sign on the door to the west reads, 'Old MacDonald's Room
            L0010: return; // RETURN;
        }

        private void Fn_1F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1677); // The sign on the door has been torn in twain.  The part that remains says, 'Harp....'
            L0010: return; // RETURN;
        }

        private void Fn_20(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x05, 0x01, 0xFA, 0x03, isForwardMove);
            L001E: return; // RETURN;
        }

        private void Fn_21(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String16CC); // The sign on the door has been torn in twain.  The part that remains says, '....ease'
            L0010: return; // RETURN;
        }

        private void Fn_22(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFlag(player, 0x02, 0x20, 0x00);
            L0017: SetFlag(player, 0x02, 0x21, 0x00);
            L002B: return; // RETURN;
        }

        private void Fn_23(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1721); // 'No guts, no glory,' you tell yourself, hoping that you are ready to face Fleance.
            L0010: return; // RETURN;
        }

        private void Fn_24(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x04, 0x01, 0x00, 0x33, isForwardMove);
            L001D: return; // RETURN;
        }

        private void Fn_25(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, 0x0B), 0x0001);
            L0012: if (JumpNotBelow) goto L004A;
            L0014: PushStack(player, 0xA6);
            L0018: PushStack(player, ax);
1D61  0019 C4 5E 06  les bx, [bp+0x6]
1D64  001C 26 FF 5F 54  call far word [es:bx+0x54]
            L0020: cx = PopStack(player);
            L0021: cx = PopStack(player);
            L0022: RefreshCompareFlags(ax);
            L0024: if (JumpNotEqual) goto L004A;
            L0026: PushStack(player, 0x62);
            L002A: PushStack(player, ax);
1D73  002B C4 5E 06  les bx, [bp+0x6]
1D76  002E 26 FF 5F 54  call far word [es:bx+0x54]
            L0032: cx = PopStack(player);
            L0033: cx = PopStack(player);
            L0034: RefreshCompareFlags(ax);
            L0036: if (JumpNotEqual) goto L004A;
            L0038: PushStack(player, 0x8F);
            L003C: PushStack(player, ax);
1D85  003D C4 5E 06  les bx, [bp+0x6]
1D88  0040 26 FF 5F 54  call far word [es:bx+0x54]
            L0044: cx = PopStack(player);
            L0045: cx = PopStack(player);
            L0046: RefreshCompareFlags(ax);
            L0048: if (JumpEqual) goto L0079;
            L004A: ShowMessage(player, String098D); // You find some footprints heading to the west.
            L0057: SetFlag(player, 0x03, 0x09, 0x01);
            L006C: ShowMessage(player, String09BB); // No, you're not the only one who finds that odd.
            L0079: return; // RETURN;
        }

        private void Fn_26(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0x14), 0x0001);
            L0017: if (JumpNotEqual) goto L001C;
            L0019: goto L00BF;
            L001C: Compare(GetFlag(player, 0x03, 0x01), 0x0001);
            L0030: if (JumpEqual) goto L0035;
            L0032: goto L00FF;
            L0035: Compare(GetFlag(player, 0x03, 0x02), 0x0001);
            L0049: if (JumpEqual) goto L004E;
            L004B: goto L00FF;
            L004E: PushStack(player, 0x03);
            L0052: PushStack(player, ax);
1E16  0053 C4 5E 06  les bx, [bp+0x6]
1E19  0056 26 FF 5F 04  call far word [es:bx+0x4]
            L005A: cx = PopStack(player);
            L005B: cx = PopStack(player);
            L005C: Compare(ax, 0x0001);
            L005F: if (JumpEqual) goto L0064;
            L0061: goto L00FF;
            L0064: Compare(GetFlag(player, 0x03, 0x04), 0x0001);
            L0078: if (JumpEqual) goto L007D;
            L007A: goto L00FF;
            L007D: Compare(GetFlag(player, 0x03, 0x05), 0x0001);
            L0091: if (JumpNotEqual) goto L00FF;
            L0093: Compare(GetFlag(player, 0x03, 0x06), 0x0001);
            L00A7: if (JumpNotEqual) goto L00FF;
            L00A9: Compare(GetFlag(player, 0x03, 0x07), 0x0001);
            L00BD: if (JumpNotEqual) goto L00FF;
            L00BF: SetFlag(player, 0x02, 0x17, 0x01);
            L00D4: SetWallPassable(player, 0x0D, 0x02, 0x01);
            L00EA: PushStack(player, 0x02);
            L00EE: PushStack(player, 0x0D);
            L00F2: PushStack(player, 0x01);
1EB9  00F6 C4 5E 06  les bx, [bp+0x6]
1EBC  00F9 26 FF 5F 30  call far word [es:bx+0x30]
            L00FD: goto L0126;
            L00FF: SetWallObject(player, 0x00, 0x0D, 0x02);
            L0114: SetWallPassable(player, 0x0D, 0x02, 0x00);
            L0129: return; // RETURN;
        }

    }
}
