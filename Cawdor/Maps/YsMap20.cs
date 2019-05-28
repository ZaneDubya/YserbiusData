#pragma warning disable
using System.Collections.Generic;
using XPT.WorldData;
using XPT.WorldData.Yserbius;

namespace XPT.Scripts.Yserbius.Maps {
    class YserMap20 : AMapScripted {
        protected override int MapIndex => 20;
        protected override int RandomEncounterChance => 12;
        protected override int RandomEncounterExtraCount => 2;

        public YserMap20() {
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
            MapEvent27 = Fn_27;
            MapEvent28 = Fn_28;
            MapEvent29 = Fn_29;
            MapEvent2A = Fn_2A;
            MapEvent2B = Fn_2B;
            MapEvent2C = Fn_2C;
            MapEvent2D = Fn_2D;
            MapEvent2F = Fn_2F;
        }
        
        // === Strings ================================================
        private const string String0140 = "A cold breeze sends shivers down your spine.";
        private const string String016D = "You've uncovered a hidden door!";
        private const string String018D = "You have unlocked the hidden door!";
        private const string String01B0 = "Your lockpick is no more.  It has ceased to key.  It's a stick.  Bereft of heft, it rests in pieces.  This is an ex-lockpick.";
        private const string String022E = "You detect a hidden door, but it is locked.";
        private const string String025A = "That was a stiff lock, but you finally got it open.";
        private const string String028E = "Funny how an irksome little lock on a flimsy little door can keep out a big strong person like you.";
        private const string String02F2 = "You find some tracks indicating that something headed off this way.";
        private const string String0336 = "You hear some footsteps running away.";
        private const string String035C = "You hear someone running towards you.";
        private const string String0382 = "*";
        private const string String0384 = "A comely lady approaches.";
        private const string String039E = "'Hast thou found the herd of unicorns?  There must be a large herd to generate so many unicorn horn helms?  Why dost thou snigger so?  Dost thou suggest I am not adequately pure to find a unicorn?'";
        private const string String0464 = "Examining the way she easily handles her claymore, you stifle your snickers and assure here that she is purity personified.";
        private const string String04E0 = "'Woe betides me!  I have lost my good cousin.  I have been told that she is here, or in the Aerie, but when I seek her here I am told she is there, and there here.  Knowest thou where Ermintrude Wyrm hast been seen?'";
        private const string String05B9 = "You don't know, but you tell the dragon that you will relay the message if you see her.  ";
        private const string String0613 = "Why is it that Macduff's shade can still walk here, but Rory's can not?";
        private const string String065B = "'Ah, friends.  This is indeed a place for the likes of me, what with its many secrets and even more locks.  I have heard that one may even find an adamantine lockpick nearabouts.";
        private const string String070E = "But keep alert!  Macduff's shade haunts the south west corner.  Of course, I was too stealthy to be caught by him.";
        private const string String0781 = "Rory struts off, smiling.";
        private const string String079B = "Do you know how you can tell the difference between Scottish and English reivers?  Why are you bothering when they are attacking!";
        private const string String081D = "The doorway is so narrow that it forces you to pass it single file.";
        private const string String0861 = "You take the stairs down one level.";
        private const string String0885 = "You suddenly feel better, as if someone were helping you from afar.";
        private const string String08C9 = "You are being ambushed by Macduff's ghost!";
        private const string String08F4 = "'Hah!  I knew that meddlesome witch would betray herself here!  Yield thee, coward, and live to be the show and gaze o' the time.  Else within my sword's reach set thee; if thou 'scape, hell forgive me too!'";
        private const string String09C4 = "You know, them's fighting words.  You attack!";
        private const string String09F2 = "This time you have got the drop on Macduff's Ghost!";
        private const string String0A26 = "The carnage from your epic battle with the mighty Macduff is scattered over this entire area.";
        private const string String0A84 = "This is an enormous throne room with only two obvious doors, one each on the north and south walls.";
        private const string String0AE8 = "If the folks who built Cawdor Keep had the cautious minds typical of their countrymen, there will be many secret doors hidden from which guards could strike swiftly against invaders.";
        private const string String0B9F = "Every time you see the throne room you are impressed.";
        private const string String0BD5 = "A large mixed motley group claims to be the 'official' bailiffs of this hall.  They start arguing about which of your goods to confiscate for trespass, and decide instead to simply apply 'Jeddart' justice.";
        private const string String0CA3 = "Which is to say, kill you first and then quibble about your goods!";
        private const string String0CE6 = "'Justice was served,' you think to yourself, as you observe the remains of the 'bailiffs.'";
        private const string String0D41 = "A friendly group of giants smiles down at you.";
        private const string String0D70 = "I guess if you were hungry and dinner came strolling up, you would smile too.";
        private const string String0DBE = "All that remains of your battle here is the crushed remains of a silver hand.";
        private const string String0E0C = "Now that you mention it, Cawdor sure has one heck of an efficient set of scavengers, doesn't it!";
        private const string String0E6D = "The people who ruled here must have been real pigs.  In fact, here come some of their descendants!";
        private const string String0ED0 = "If you could only learn to drive pigs like these before you, like the swineherding spellcasters in back, you'd have a lot easier time with battles.";
        private const string String0F64 = "All that remains of your battle here is a fractured tusk and a splintered staff.";
        private const string String0FB5 = "With all the secret and locked doors in here, you knew it was just a matter of time before you ran into some halfling thieves.";
        private const string String1034 = "It's a good thing you were looking for them.";
        private const string String1061 = "It's a shame you weren't looking for them.";
        private const string String108C = "Groups this large are easy to spot.";
        private const string String10B0 = "All that remains of your battle here is a broken toe-nail and a pipe full of weed.";
        private const string String1103 = "Don't worry.  Cyberweed is not a controlled substance, and in cyberspace there's no such thing as second hand smoke.";
        private const string String1178 = "The good news is that dragons rarely travel in pairs.  The bad news is that these dragons are travelling in packs of three!";
        private const string String11F4 = "Some days the dragon wins.  This wasn't one of them.";
        private const string String1229 = "The good news is that there is not an actual king on the throne here.  The bad news is that it's a bunch of those thrice bedratted halflings with an ambush all arranged!";
        private const string String12D3 = "Your battle here proved the old adage: 'You can never hold a throne if your feet don't reach the floor.'";
        private const string String133C = "'Huzzah for thy masterful turn of arms against Macduff's shade.  I will permit myself a smidgeon of hope that at last the evil that resides herein may be ended.";
        private const string String13DD = "Now attend!  Macbeth's Ghost dost reside in the Aerie, surrounded by all manners of flying beasts, including flying undead.  The undying also greatly inhabit Astrologia and Alchemia.";
        private const string String1494 = "May thy sword arm never tire!'";
        private const string String14B3 = "He departs.";
        private const string String14BF = "'Hist!  Attend!  I have little time.  Macbeth's Ghost dost reside in the Aerie, surrounded by all manners of flying beasts, including several undead.  And flying undying also greatly inhabit Astrologia and Alchemia.";
        private const string String1597 = "May thy sword arm never tire.'";
        private const string String15B6 = "The plaque reads: 'Here be Evilwillit Armstrong, wanted for stealing two oxen, one young and one mature milk cow, six chickens, a brace of ducks, a fine nanny and her kid, thirty-five ewes, one ram...";
        private const string String167F = "... a workable feather mattress, a good iron skillet, a long wooden spoon, and several unpermissioned kisses from Laird-give-me-little Eliot and her eldest daughter Sweet-milk.'";
        private const string String1731 = "The plaque reads: 'Here be Bangtail Bobby Bell.  On the charge fyled against her of stealing three horses from Skinabake Armstrong she has been found foul conditionally.'";
        private const string String17DC = "The plaque reads: 'This be Laird-give-me-little Eliot, found guilty of overswearing to the amount of twenty-nine sheep.'";
        private const string String1855 = "The plaque reads: 'This be Curst Clem Croser, found guilty of kidnapping and holding for ransom Wanton Sim Scott.'";
        private const string String18C8 = "The plaque reads: 'This be David-no-good-priest Armstrong, found guilty of failure to light his beacon at night while the Carleton's were reiving.'";
        private const string String195C = "The plaque reads: 'This be Winking Warren Scott, found guilty of playing tables with false dice.";
        private const string String19BD = "The plaque reads: 'This be Curst Conan Burns, found guilty of using Black Magics and cheating at cards.'";
        private const string String1A26 = "The plaque reads: 'This be Winking Sean Wilkinson, found guilty of abusing and ill-using Sore John Graham's spades.'";
        private const string String1A9B = "The plaque reads: 'This be Winking William Musgrave, found guilty of sharping, gulling, and gambling on chess.'";
        private const string String1B0B = "The plaque reads: 'This be Winking Cynthia Turner, found guilty of balderdash in the first degree.'";
        private const string String1B6F = "The plaque reads: 'This be Winking Stephen Laidlaw, found guilty of abuse of bagels.'";
        private const string String1BC5 = "The plaque reads: 'This be Winking Jeanne Burns, found guilty of overindulgence in cards.'";
        private const string String1C20 = "The plaque reads: 'This be Winking George Matthews, found guilty of crimes too numerous to mention.'";
        private const string String1C85 = "The plaque reads: 'Here be Winking Dicky Armstrong, found guilty of abuse of poetic license.'";
        private const string String1CE3 = "The plaque reads: 'Here be Winking Gloria Graham, found guilty of animal husbandry.'";
        private const string String1D38 = "The plaque reads: 'Here be Winking Timothy Irvine, found guilty of consorting with undead.'";
        private const string String1D94 = "The plaque reads: 'Here be Winking Claudia Nixon, found guilty of cavorting with monsters.'";
        private const string String1DF0 = "The plaque reads: 'Here be Winking Danny Robson, found guilty of poaching insects.'";
        private const string String1E44 = "And a few goodies, too!";
        private const string String1E5C = "'Good gentle, couldst assist a humble servant of his majesty's office of assizes?  Upon our plans we show one higher level than this, and yet I can find no stairs!'";
        private const string String1F01 = "You know of no stairs either, and tell him so.  In fact, judging from the windows, this is the top floor.";
        private const string String1F6B = "'Certes, they are upon my charts and papers, so they must be here somewhere.  Forgive my interruption.'  He goes back to searching the wall.";
        private const string String1FF8 = "There sure are a lot of stairs here!";
        
        // === Functions ================================================
        private void Fn_01(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0140); // A cold breeze sends shivers down your spine.
            L0010: Compare(HasUsedSkill(player, 0x0D), 0x000B);
            L001F: if (JumpNotBelow) goto L008D;
            L0021: RefreshCompareFlags(HasUsedSpell(player, 0x17));
            L002F: if (JumpNotEqual) goto L008D;
            L0031: PushStack(player, 0x67);
            L0035: PushStack(player, ax);
0043  0036 C4 5E 06  les bx, [bp+0x6]
0046  0039 26 FF 5F 54  call far word [es:bx+0x54]
            L003D: cx = PopStack(player);
            L003E: cx = PopStack(player);
            L003F: RefreshCompareFlags(ax);
            L0041: if (JumpNotEqual) goto L008D;
            L0043: PushStack(player, 0x61);
            L0047: PushStack(player, ax);
0055  0048 C4 5E 06  les bx, [bp+0x6]
0058  004B 26 FF 5F 54  call far word [es:bx+0x54]
            L004F: cx = PopStack(player);
            L0050: cx = PopStack(player);
            L0051: RefreshCompareFlags(ax);
            L0053: if (JumpNotEqual) goto L008D;
            L0055: PushStack(player, 0x93);
            L0059: PushStack(player, ax);
0067  005A C4 5E 06  les bx, [bp+0x6]
006A  005D 26 FF 5F 54  call far word [es:bx+0x54]
            L0061: cx = PopStack(player);
            L0062: cx = PopStack(player);
            L0063: RefreshCompareFlags(ax);
            L0065: if (JumpNotEqual) goto L008D;
            L0067: PushStack(player, 0x86);
            L006B: PushStack(player, ax);
0079  006C C4 5E 06  les bx, [bp+0x6]
007C  006F 26 FF 5F 54  call far word [es:bx+0x54]
            L0073: cx = PopStack(player);
            L0074: cx = PopStack(player);
            L0075: RefreshCompareFlags(ax);
            L0077: if (JumpNotEqual) goto L008D;
            L0079: ax = IsFlagOn(player, 0x00, 0x01);
            L008B: if (JumpEqual) goto L00D5;
            L008D: SetWallObject(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L00AB: ShowMessage(player, String016D); // You've uncovered a hidden door!
            L00B8: PushStack(player, 0x01);
            L00BC: PushStack(player, GetFacing(player));
            L00C4: PushStack(player, GetCurrentTile(player));
00D9  00CC C4 5E 06  les bx, [bp+0x6]
00DC  00CF 26 FF 5F 2C  call far word [es:bx+0x2c]
            L00D3: goto L010C;
            L00D5: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L00F2: SetWallObject(player, 0x00, GetCurrentTile(player), GetFacing(player));
            L010F: return; // RETURN;
        }

        private void Fn_02(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, 0x0D), 0x000B);
            L0012: if (JumpNotBelow) goto L0083;
            L0014: RefreshCompareFlags(HasUsedSpell(player, 0x17));
            L0022: if (JumpNotEqual) goto L0083;
            L0024: PushStack(player, 0x67);
            L0028: PushStack(player, ax);
0147  0029 C4 5E 06  les bx, [bp+0x6]
014A  002C 26 FF 5F 54  call far word [es:bx+0x54]
            L0030: cx = PopStack(player);
            L0031: cx = PopStack(player);
            L0032: RefreshCompareFlags(ax);
            L0034: if (JumpNotEqual) goto L0083;
            L0036: PushStack(player, 0x61);
            L003A: PushStack(player, ax);
0159  003B C4 5E 06  les bx, [bp+0x6]
015C  003E 26 FF 5F 54  call far word [es:bx+0x54]
            L0042: cx = PopStack(player);
            L0043: cx = PopStack(player);
            L0044: RefreshCompareFlags(ax);
            L0046: if (JumpNotEqual) goto L0083;
            L0048: PushStack(player, 0x93);
            L004C: PushStack(player, ax);
016B  004D C4 5E 06  les bx, [bp+0x6]
016E  0050 26 FF 5F 54  call far word [es:bx+0x54]
            L0054: cx = PopStack(player);
            L0055: cx = PopStack(player);
            L0056: RefreshCompareFlags(ax);
            L0058: if (JumpNotEqual) goto L0083;
            L005A: PushStack(player, 0x86);
            L005E: PushStack(player, ax);
017D  005F C4 5E 06  les bx, [bp+0x6]
0180  0062 26 FF 5F 54  call far word [es:bx+0x54]
            L0066: cx = PopStack(player);
            L0067: cx = PopStack(player);
            L0068: RefreshCompareFlags(ax);
            L006A: if (JumpNotEqual) goto L0083;
            L006C: ax = IsFlagOn(player, 0x00, 0x01);
            L007E: if (JumpNotEqual) goto L0083;
            L0080: goto L01B4;
            L0083: SetWallObject(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L00A1: PushStack(player, 0x01);
            L00A5: PushStack(player, ax);
            L00A6: PushStack(player, 0x00);
01C7  00A9 C4 5E 06  les bx, [bp+0x6]
01CA  00AC 26 FF 1F  call far word [es:bx]
01CD  00AF 83 C4 06  add sp, 0x6
            L00B2: PushStack(player, 0x68);
            L00B6: PushStack(player, ax);
01D5  00B7 C4 5E 06  les bx, [bp+0x6]
01D8  00BA 26 FF 5F 54  call far word [es:bx+0x54]
            L00BE: cx = PopStack(player);
            L00BF: cx = PopStack(player);
            L00C0: RefreshCompareFlags(ax);
            L00C2: if (JumpEqual) goto L00E4;
            L00C4: ax = HasItem(player, 0xDC);
            L00D2: if (JumpNotEqual) goto L011C;
            L00D4: ax = HasItem(player, 0xDD);
            L00E2: if (JumpNotEqual) goto L011C;
            L00E4: Compare(GetSkillLevel(player, 0x0E), 0x000A);
            L00F3: if (JumpBelow) goto L010A;
            L00F5: ax = HasUsedItem(player, 0xDC, 0xDD);
            L0108: if (JumpNotEqual) goto L011C;
            L010A: PushStack(player, 0xC0);
            L010E: PushStack(player, ax);
022D  010F C4 5E 06  les bx, [bp+0x6]
0230  0112 26 FF 5F 54  call far word [es:bx+0x54]
            L0116: cx = PopStack(player);
            L0117: cx = PopStack(player);
            L0118: RefreshCompareFlags(ax);
            L011A: if (JumpEqual) goto L012F;
            L011C: ShowMessage(player, String018D); // You have unlocked the hidden door!
0247  0129 B8 01 00  mov ax, 0x1
            L012C: goto L01B6;
            L012F: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L014C: ax = HasUsedItem(player, 0xC1, 0xC2);
            L015F: if (JumpEqual) goto L0188;
            L0161: RemoveItem(player, 0xC1);
            L016D: RemoveItem(player, 0xC2);
            L0179: ShowMessage(player, String01B0); // Your lockpick is no more.  It has ceased to key.  It's a stick.  Bereft of heft, it rests in pieces.  This is an ex-lockpick.
            L0186: goto L01D1;
            L0188: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L01A5: ShowMessage(player, String022E); // You detect a hidden door, but it is locked.
            L01B2: goto L01D1;
            L01B4: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L01D1: return; // RETURN;
        }

        private void Fn_03(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x68);
            L0007: PushStack(player, ax);
02F9  0008 C4 5E 06  les bx, [bp+0x6]
02FC  000B 26 FF 5F 54  call far word [es:bx+0x54]
            L000F: cx = PopStack(player);
            L0010: cx = PopStack(player);
            L0011: RefreshCompareFlags(ax);
            L0013: if (JumpEqual) goto L0055;
            L0015: ax = HasItem(player, 0xDA);
            L0023: if (JumpNotEqual) goto L008D;
            L0025: ax = HasItem(player, 0xDB);
            L0033: if (JumpNotEqual) goto L008D;
            L0035: ax = HasItem(player, 0xDC);
            L0043: if (JumpNotEqual) goto L008D;
            L0045: ax = HasItem(player, 0xDD);
            L0053: if (JumpNotEqual) goto L008D;
            L0055: Compare(GetSkillLevel(player, 0x0E), 0x0009);
            L0064: if (JumpBelow) goto L007B;
            L0066: ax = HasUsedItem(player, 0xDA, 0xDD);
            L0079: if (JumpNotEqual) goto L008D;
            L007B: PushStack(player, 0xC0);
            L007F: PushStack(player, ax);
0371  0080 C4 5E 06  les bx, [bp+0x6]
0374  0083 26 FF 5F 54  call far word [es:bx+0x54]
            L0087: cx = PopStack(player);
            L0088: cx = PopStack(player);
            L0089: RefreshCompareFlags(ax);
            L008B: if (JumpEqual) goto L00BB;
            L008D: ShowMessage(player, String025A); // That was a stiff lock, but you finally got it open.
            L009A: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L00B8: goto L0140;
            L00BB: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L00D8: ax = HasUsedItem(player, 0xC1, 0xC3);
            L00EB: if (JumpEqual) goto L0116;
            L00ED: RemoveItem(player, 0xC1);
            L00F9: RemoveItem(player, 0xC2);
            L0105: RemoveItem(player, 0xC3);
0402  0111 B8 B0 01  mov ax, 0x1b0
            L0114: goto L0136;
            L0116: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0133: ShowMessage(player, String028E); // Funny how an irksome little lock on a flimsy little door can keep out a big strong person like you.
            L0140: return; // RETURN;
        }

        private void Fn_04(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, 0x0B), 0x000B);
            L0012: if (JumpNotBelow) goto L0026;
            L0014: PushStack(player, 0x8F);
            L0018: PushStack(player, ax);
044C  0019 C4 5E 06  les bx, [bp+0x6]
044F  001C 26 FF 5F 54  call far word [es:bx+0x54]
            L0020: cx = PopStack(player);
            L0021: cx = PopStack(player);
            L0022: RefreshCompareFlags(ax);
            L0024: if (JumpEqual) goto L0048;
            L0026: ShowMessage(player, String02F2); // You find some tracks indicating that something headed off this way.
            L0033: SetFlag(player, 0x03, 0x09, 0x01);
            L0048: return; // RETURN;
        }

        private void Fn_05(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si, di);
            L0005: di = 0;
            L0007: si = 0;
            L0009: ax = GetFlag(player, 0x03, 0x08);
0497  001A 8B F8  mov di, ax
0499  001C 47     inc di
049A  001D 8B F7  mov si, di
            L001F: Compare(si, 0x13);
            L0022: if (JumpLessOrEqual) goto L002B;
04A1  0024 8B C6  mov ax, si
            L0026: si = ax + 0xFFEC;
            L002B: Compare(si, 0x0E);
            L002E: if (JumpLessOrEqual) goto L0037;
04AD  0030 8B C6  mov ax, si
            L0032: si = ax + 0xFFF1;
            L0037: Compare(si, 0x09);
            L003A: if (JumpLessOrEqual) goto L0043;
04B9  003C 8B C6  mov ax, si
            L003E: si = ax + 0xFFF6;
            L0043: Compare(si, 0x04);
            L0046: if (JumpLessOrEqual) goto L004F;
04C5  0048 8B C6  mov ax, si
            L004A: si = ax + 0xFFFB;
04CC  004F 0B F6  or si, si
04CE  0051 7D 02  jge 0x55
            L0053: si = 0;
            L0055: Compare(si, 0x1D);
            L0058: if (JumpLessOrEqual) goto L005C;
            L005A: si = 0;
04D9  005C 83 FF 1E  cmp di, 0x1e
            L005F: if (JumpLessOrEqual) goto L0063;
            L0061: di = 0;
04E0  0063 57     push di
            L0064: PushStack(player, 0x08);
            L0068: PushStack(player, 0x03);
04E9  006C C4 5E 06  les bx, [bp+0x6]
04EC  006F 26 FF 1F  call far word [es:bx]
04EF  0072 83 C4 06  add sp, 0x6
04F2  0075 83 FF 1A  cmp di, 0x1a
            L0078: if (JumpNotEqual) goto L007F;
04F7  007A B8 01 00  mov ax, 0x1
            L007D: goto L0081;
            L007F: PushStack(player, 0x00);
04FF  0082 83 FF 14  cmp di, 0x14
            L0085: if (JumpNotEqual) goto L008C;
0504  0087 B8 01 00  mov ax, 0x1
            L008A: goto L008E;
0509  008C 33 C0  xor ax, ax
            L008E: dx = PopStack(player);
050C  008F 0B D0  or dx, ax
            L0091: PushStack(player, dx);
050F  0092 83 FF 0E  cmp di, 0xe
            L0095: if (JumpNotEqual) goto L009C;
0514  0097 B8 01 00  mov ax, 0x1
            L009A: goto L009E;
0519  009C 33 C0  xor ax, ax
            L009E: dx = PopStack(player);
051C  009F 0B D0  or dx, ax
            L00A1: PushStack(player, dx);
051F  00A2 83 FF 08  cmp di, 0x8
            L00A5: if (JumpNotEqual) goto L00AC;
0524  00A7 B8 01 00  mov ax, 0x1
            L00AA: goto L00AE;
0529  00AC 33 C0  xor ax, ax
            L00AE: dx = PopStack(player);
052C  00AF 0B D0  or dx, ax
            L00B1: PushStack(player, dx);
052F  00B2 83 FF 02  cmp di, 0x2
            L00B5: if (JumpNotEqual) goto L00BC;
0534  00B7 B8 01 00  mov ax, 0x1
            L00BA: goto L00BE;
0539  00BC 33 C0  xor ax, ax
            L00BE: dx = PopStack(player);
053C  00BF 0B D0  or dx, ax
            L00C1: if (JumpNotEqual) goto L00C6;
            L00C3: goto L0289;
            L00C6: bx = si;
            L00C8: Compare(bx, 0x04);
            L00CB: if (JumpBelowOrEqual) goto L00D0;
            L00CD: goto L0289;
            L00D0: switch (bx) {
                case 0:
                    goto L00D7;
                case 1:
                    goto L00E7;
                case 2:
                    goto L0147;
                case 3:
                    goto L0167;
                case 4:
                    goto L01D7;
            }
            L00D7: ShowMessage(player, String0336); // You hear some footsteps running away.
            L00E4: goto L0289;
            L00E7: ShowMessage(player, String035C); // You hear someone running towards you.
            L00F4: ShowPortrait(player, 0x001B);
            L0101: ShowMessage(player, String0382); // *
            L010E: ShowMessage(player, String0382); // *
            L011B: ShowMessage(player, String0382); // *
            L0128: ShowMessage(player, String0384); // A comely lady approaches.
            L0135: ShowMessage(player, String039E); // 'Hast thou found the herd of unicorns?  There must be a large herd to generate so many unicorn horn helms?  Why dost thou snigger so?  Dost thou suggest I am not adequately pure to find a unicorn?'
05BF  0142 B8 64 04  mov ax, 0x464
            L0145: goto L00DA;
            L0147: ShowPortrait(player, 0x000E);
            L0154: ShowMessage(player, String04E0); // 'Woe betides me!  I have lost my good cousin.  I have been told that she is here, or in the Aerie, but when I seek her here I am told she is there, and there here.  Knowest thou where Ermintrude Wyrm hast been seen?'
05DE  0161 B8 B9 05  mov ax, 0x5b9
            L0164: goto L00DA;
            L0167: Compare(GetFlag(player, 0x02, 0x47), 0x0001);
            L017B: if (JumpNotEqual) goto L0183;
05FA  017D B8 13 06  mov ax, 0x613
            L0180: goto L00DA;
            L0183: ShowPortrait(player, 0x0025);
            L0190: ShowMessage(player, String0382); // *
            L019D: ShowMessage(player, String0382); // *
            L01AA: ShowMessage(player, String0382); // *
            L01B7: ShowMessage(player, String065B); // 'Ah, friends.  This is indeed a place for the likes of me, what with its many secrets and even more locks.  I have heard that one may even find an adamantine lockpick nearabouts.
            L01C4: ShowMessage(player, String070E); // But keep alert!  Macduff's shade haunts the south west corner.  Of course, I was too stealthy to be caught by him.
064E  01D1 B8 81 07  mov ax, 0x781
            L01D4: goto L00DA;
            L01D7: ShowMessage(player, String0382); // *
            L01E4: ShowMessage(player, String0382); // *
            L01F1: ShowMessage(player, String0382); // *
            L01FE: ShowMessage(player, String079B); // Do you know how you can tell the difference between Scottish and English reivers?  Why are you bothering when they are attacking!
0688  020B B8 ED 01  mov ax, 0x1ed
            L020E: PushStack(player, ax);
            L020F: PushStack(player, 0x00);
            L0212: PushStack(player, ax);
            L0213: PushStack(player, ax);
            L0214: PushStack(player, 0xAA);
            L0218: PushStack(player, 0xBF);
0699  021C C4 5E 06  les bx, [bp+0x6]
069C  021F 26 FF 9F D8 00  call far word [es:bx+0xd8]
06A1  0224 83 C4 0C  add sp, 0xc
            L0227: AddEncounter(player, 0x01, 0x19);
            L0239: Compare(PartyCount(player), 0x0019);
            L0244: if (JumpBelowOrEqual) goto L0258;
            L0246: AddEncounter(player, 0x05, 0x19);
            L0258: Compare(PartyCount(player), 0x0002);
            L0263: if (JumpBelowOrEqual) goto L0289;
            L0265: AddEncounter(player, 0x02, 0x19);
            L0277: AddEncounter(player, 0x06, 0x19);
            L0289: return; // RETURN (restoring si, di);
        }

        private void Fn_06(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0140); // A cold breeze sends shivers down your spine.
            L0010: return; // RETURN;
        }

        private void Fn_07(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpBelowOrEqual) goto L001F;
            L0010: ShowMessage(player, String081D); // The doorway is so narrow that it forces you to pass it single file.
            L001D: goto L0047;
            L001F: ShowMessage(player, String0861); // You take the stairs down one level.
            L002C: TeleportParty(player, 0x06, 0x03, 0xF9, 0x03, isForwardMove);
            L0047: return; // RETURN;
        }

        private void Fn_08(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetNoJoinArea(player);
            L000B: RefreshCompareFlags(GetFlag(player, 0x02, 0x21));
            L001E: if (JumpNotEqual) goto L007D;
            L0020: RefreshCompareFlags(GetFlag(player, 0x02, 0x27));
            L0033: if (JumpNotEqual) goto L007D;
            L0035: RefreshCompareFlags(GetFlag(player, 0x03, 0x0A));
            L0048: if (JumpNotEqual) goto L007D;
            L004A: SetFlag(player, 0x02, 0x21, 0x01);
            L005F: ShowMessage(player, String0885); // You suddenly feel better, as if someone were helping you from afar.
            L006C: HealPlayer(player, GetMaxHits(player));
            L007D: return; // RETURN;
        }

        private void Fn_09(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x0A));
            L0016: if (JumpNotEqual) goto L0053;
            L0018: ax = HasItem(player, 0xEA);
            L0026: if (JumpEqual) goto L0031;
            L0028: PushStack(player, 0x02);
081A  002C B8 EB 00  mov ax, 0xeb
            L002F: goto L005A;
            L0031: ax = CheckLevel(player, 0x001E);
            L003F: if (JumpEqual) goto L004A;
            L0041: PushStack(player, 0x02);
0833  0045 B8 FB 00  mov ax, 0xfb
            L0048: goto L005A;
            L004A: PushStack(player, 0x02);
083C  004E B8 FA 00  mov ax, 0xfa
            L0051: goto L005A;
            L0053: TeleportParty(player, 0x08, 0x02, 0xEA, 0x02, isForwardMove);
            L006E: return; // RETURN;
        }

        private void Fn_0A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x02, 0x27));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L0171;
            L001B: SetFlag(player, 0x03, 0x0A, 0x01);
            L0030: SetFlag(player, 0x02, 0x27, 0x01);
            L0045: ax = GetMaxHits(player);
            L004C: bx = 0x0003;
            L004F: dx = ax % bx; ax = ax / bx;
            L0052: DamagePlayer(player, ax);
            L005C: ShowMessage(player, String08C9); // You are being ambushed by Macduff's ghost!
            L0069: ShowMessage(player, String08F4); // 'Hah!  I knew that meddlesome witch would betray herself here!  Yield thee, coward, and live to be the show and gaze o' the time.  Else within my sword's reach set thee; if thou 'scape, hell forgive me too!'
            L0076: ShowMessage(player, String09C4); // You know, them's fighting words.  You attack!
            L0083: SetFlag(player, 0x03, 0x0A, 0x01);
            L0098: ax = HasItem(player, 0xEA);
            L00A6: if (JumpEqual) goto L00E2;
            L00A8: AddTreasure(player, 0x0B6D, 0x00, 0x81, 0xBB, 0xCE, 0x24);
            L00CA: AddEncounter(player, 0x01, 0x25);
093A  00DC B8 26 00  mov ax, 0x26
            L00DF: goto L0162;
            L00E2: ax = CheckLevel(player, 0x001E);
            L00F0: if (JumpEqual) goto L012B;
            L00F2: AddTreasure(player, 0x0B6D, 0x00, 0x81, 0xBB, 0xCE, 0x24);
            L0114: AddEncounter(player, 0x01, 0x1F);
0984  0126 B8 28 00  mov ax, 0x28
            L0129: goto L0162;
            L012B: AddTreasure(player, 0x0B6D, 0x00, 0x81, 0xBB, 0xCE, 0x24);
            L014D: AddEncounter(player, 0x01, 0x1D);
            L015F: AddEncounter(player, 0x05, 0x27);
            L0171: return; // RETURN;
        }

        private void Fn_0B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x0A));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00DA;
            L001B: SetFlag(player, 0x03, 0x0A, 0x02);
            L0030: SetFlag(player, 0x02, 0x27, 0x01);
            L0045: ShowMessage(player, String09F2); // This time you have got the drop on Macduff's Ghost!
            L0052: AddEncounter(player, 0x01, 0x25);
            L0064: AddEncounter(player, 0x05, 0x26);
            L0076: Compare(PartyCount(player), 0x0002);
            L0081: if (JumpBelowOrEqual) goto L00A7;
            L0083: AddEncounter(player, 0x02, 0x08);
            L0095: AddEncounter(player, 0x06, 0x08);
            L00A7: Compare(PartyCount(player), 0x0003);
            L00B2: if (JumpBelowOrEqual) goto L00E7;
            L00B4: AddEncounter(player, 0x03, 0x08);
            L00C6: AddEncounter(player, 0x04, 0x08);
            L00D8: goto L00E7;
            L00DA: ShowMessage(player, String0A26); // The carnage from your epic battle with the mighty Macduff is scattered over this entire area.
            L00E7: return; // RETURN;
        }

        private void Fn_0C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x0A));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00DA;
            L001B: SetFlag(player, 0x03, 0x0A, 0x02);
            L0030: SetFlag(player, 0x02, 0x27, 0x01);
            L0045: ShowMessage(player, String09F2); // This time you have got the drop on Macduff's Ghost!
            L0052: AddEncounter(player, 0x01, 0x1D);
            L0064: AddEncounter(player, 0x05, 0x27);
            L0076: Compare(PartyCount(player), 0x0002);
            L0081: if (JumpBelowOrEqual) goto L00A7;
            L0083: AddEncounter(player, 0x02, 0x05);
            L0095: AddEncounter(player, 0x06, 0x05);
            L00A7: Compare(PartyCount(player), 0x0003);
            L00B2: if (JumpBelowOrEqual) goto L00E7;
            L00B4: AddEncounter(player, 0x03, 0x05);
            L00C6: AddEncounter(player, 0x04, 0x05);
            L00D8: goto L00E7;
            L00DA: ShowMessage(player, String0A26); // The carnage from your epic battle with the mighty Macduff is scattered over this entire area.
            L00E7: return; // RETURN;
        }

        private void Fn_0D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x0A));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00DA;
            L001B: SetFlag(player, 0x03, 0x0A, 0x02);
            L0030: SetFlag(player, 0x02, 0x27, 0x01);
            L0045: ShowMessage(player, String09F2); // This time you have got the drop on Macduff's Ghost!
            L0052: AddEncounter(player, 0x01, 0x1F);
            L0064: AddEncounter(player, 0x05, 0x28);
            L0076: Compare(PartyCount(player), 0x0002);
            L0081: if (JumpBelowOrEqual) goto L00A7;
            L0083: AddEncounter(player, 0x02, 0x07);
            L0095: AddEncounter(player, 0x06, 0x07);
            L00A7: Compare(PartyCount(player), 0x0003);
            L00B2: if (JumpBelowOrEqual) goto L00E7;
            L00B4: AddEncounter(player, 0x03, 0x07);
            L00C6: AddEncounter(player, 0x04, 0x07);
            L00D8: goto L00E7;
            L00DA: ShowMessage(player, String0A26); // The carnage from your epic battle with the mighty Macduff is scattered over this entire area.
            L00E7: return; // RETURN;
        }

        private void Fn_0E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x0B));
            L0016: if (JumpNotEqual) goto L003F;
            L0018: SetFlag(player, 0x03, 0x0B, 0x01);
            L002D: ShowMessage(player, String0A84); // This is an enormous throne room with only two obvious doors, one each on the north and south walls.
0CC6  003A B8 E8 0A  mov ax, 0xae8
            L003D: goto L0042;
            L003F: ShowMessage(player, String0B9F); // Every time you see the throne room you are impressed.
            L004C: return; // RETURN;
        }

        private void Fn_0F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x01));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00EE;
            L001B: PushStack(player, 0x01);
            L001F: PushStack(player, ax);
            L0020: PushStack(player, 0x03);
0CFE  0024 C4 5E 06  les bx, [bp+0x6]
0D01  0027 26 FF 1F  call far word [es:bx]
0D04  002A 83 C4 06  add sp, 0x6
            L002D: ShowMessage(player, String0BD5); // A large mixed motley group claims to be the 'official' bailiffs of this hall.  They start arguing about which of your goods to confiscate for trespass, and decide instead to simply apply 'Jeddart' justice.
            L003A: ShowMessage(player, String0CA3); // Which is to say, kill you first and then quibble about your goods!
0D21  0047 B8 4F 03  mov ax, 0x34f
            L004A: PushStack(player, ax);
            L004B: PushStack(player, 0x00);
            L004E: PushStack(player, ax);
            L004F: PushStack(player, 0xBA);
            L0053: PushStack(player, 0xCD);
            L0057: PushStack(player, 0x44);
0D35  005B C4 5E 06  les bx, [bp+0x6]
0D38  005E 26 FF 9F D8 00  call far word [es:bx+0xd8]
0D3D  0063 83 C4 0C  add sp, 0xc
            L0066: AddEncounter(player, 0x01, 0x1B);
            L0078: AddEncounter(player, 0x05, 0x1C);
            L008A: Compare(PartyCount(player), 0x0001);
            L0095: if (JumpBelowOrEqual) goto L00BB;
            L0097: AddEncounter(player, 0x02, 0x22);
            L00A9: AddEncounter(player, 0x06, 0x1A);
            L00BB: Compare(PartyCount(player), 0x0003);
            L00C6: if (JumpBelowOrEqual) goto L00FB;
            L00C8: AddEncounter(player, 0x04, 0x22);
            L00DA: AddEncounter(player, 0x03, 0x22);
            L00EC: goto L00FB;
            L00EE: ShowMessage(player, String0CE6); // 'Justice was served,' you think to yourself, as you observe the remains of the 'bailiffs.'
            L00FB: return; // RETURN;
        }

        private void Fn_10(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x02));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00F1;
            L001B: SetFlag(player, 0x03, 0x02, 0x01);
            L0030: ShowMessage(player, String0D41); // A friendly group of giants smiles down at you.
            L003D: ShowMessage(player, String0D70); // I guess if you were hungry and dinner came strolling up, you would smile too.
0E21  004A B8 BF 01  mov ax, 0x1bf
            L004D: PushStack(player, ax);
            L004E: PushStack(player, 0x00);
            L0051: PushStack(player, ax);
            L0052: PushStack(player, 0xBB);
            L0056: PushStack(player, 0xCD);
            L005A: PushStack(player, 0x53);
0E35  005E C4 5E 06  les bx, [bp+0x6]
0E38  0061 26 FF 9F D8 00  call far word [es:bx+0xd8]
0E3D  0066 83 C4 0C  add sp, 0xc
            L0069: AddEncounter(player, 0x01, 0x20);
            L007B: AddEncounter(player, 0x02, 0x21);
            L008D: Compare(PartyCount(player), 0x0002);
            L0098: if (JumpBelowOrEqual) goto L00BE;
            L009A: AddEncounter(player, 0x05, 0x20);
            L00AC: AddEncounter(player, 0x06, 0x21);
            L00BE: Compare(PartyCount(player), 0x0003);
            L00C9: if (JumpBelowOrEqual) goto L010B;
            L00CB: AddEncounter(player, 0x04, 0x20);
            L00DD: AddEncounter(player, 0x03, 0x21);
            L00EF: goto L010B;
            L00F1: ShowMessage(player, String0DBE); // All that remains of your battle here is the crushed remains of a silver hand.
            L00FE: ShowMessage(player, String0E0C); // Now that you mention it, Cawdor sure has one heck of an efficient set of scavengers, doesn't it!
            L010B: return; // RETURN;
        }

        private void Fn_11(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x03);
            L0007: PushStack(player, ax);
0EEC  0008 C4 5E 06  les bx, [bp+0x6]
0EEF  000B 26 FF 5F 04  call far word [es:bx+0x4]
            L000F: cx = PopStack(player);
            L0010: cx = PopStack(player);
            L0011: RefreshCompareFlags(ax);
            L0013: if (JumpEqual) goto L0018;
            L0015: goto L00F8;
            L0018: PushStack(player, 0x01);
            L001C: PushStack(player, 0x03);
            L0020: PushStack(player, ax);
0F05  0021 C4 5E 06  les bx, [bp+0x6]
0F08  0024 26 FF 1F  call far word [es:bx]
0F0B  0027 83 C4 06  add sp, 0x6
            L002A: ShowMessage(player, String0E6D); // The people who ruled here must have been real pigs.  In fact, here come some of their descendants!
            L0037: Compare(PartyCount(player), 0x0003);
            L0042: if (JumpBelowOrEqual) goto L0051;
            L0044: ShowMessage(player, String0ED0); // If you could only learn to drive pigs like these before you, like the swineherding spellcasters in back, you'd have a lot easier time with battles.
0F35  0051 B8 47 03  mov ax, 0x347
            L0054: PushStack(player, ax);
            L0055: PushStack(player, 0x00);
            L0058: PushStack(player, ax);
            L0059: PushStack(player, 0xBA);
            L005D: PushStack(player, 0xCD);
            L0061: PushStack(player, 0x10);
0F49  0065 C4 5E 06  les bx, [bp+0x6]
0F4C  0068 26 FF 9F D8 00  call far word [es:bx+0xd8]
0F51  006D 83 C4 0C  add sp, 0xc
            L0070: AddEncounter(player, 0x01, 0x1E);
            L0082: AddEncounter(player, 0x02, 0x1E);
            L0094: Compare(PartyCount(player), 0x0002);
            L009F: if (JumpBelowOrEqual) goto L00C5;
            L00A1: AddEncounter(player, 0x04, 0x1E);
            L00B3: AddEncounter(player, 0x03, 0x1E);
            L00C5: Compare(PartyCount(player), 0x0003);
            L00D0: if (JumpBelowOrEqual) goto L0105;
            L00D2: AddEncounter(player, 0x05, 0x19);
            L00E4: AddEncounter(player, 0x06, 0x19);
            L00F6: goto L0105;
            L00F8: ShowMessage(player, String0F64); // All that remains of your battle here is a fractured tusk and a splintered staff.
            L0105: return; // RETURN;
        }

        private void Fn_12(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x04));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00F8;
            L001B: SetFlag(player, 0x03, 0x04, 0x01);
            L0030: ShowMessage(player, String0E6D); // The people who ruled here must have been real pigs.  In fact, here come some of their descendants!
            L003D: Compare(PartyCount(player), 0x0003);
            L0048: if (JumpBelowOrEqual) goto L0057;
            L004A: ShowMessage(player, String0ED0); // If you could only learn to drive pigs like these before you, like the swineherding spellcasters in back, you'd have a lot easier time with battles.
            L0057: PushStack(player, 0xD4);
            L005B: PushStack(player, 0x00);
            L005E: PushStack(player, ax);
            L005F: PushStack(player, ax);
            L0060: PushStack(player, ax);
            L0061: PushStack(player, 0x36);
1050  0065 C4 5E 06  les bx, [bp+0x6]
1053  0068 26 FF 9F D8 00  call far word [es:bx+0xd8]
1058  006D 83 C4 0C  add sp, 0xc
            L0070: AddEncounter(player, 0x01, 0x1E);
            L0082: AddEncounter(player, 0x02, 0x1E);
            L0094: Compare(PartyCount(player), 0x0002);
            L009F: if (JumpBelowOrEqual) goto L00C5;
            L00A1: AddEncounter(player, 0x04, 0x1E);
            L00B3: AddEncounter(player, 0x03, 0x1E);
            L00C5: Compare(PartyCount(player), 0x0003);
            L00D0: if (JumpBelowOrEqual) goto L0105;
            L00D2: AddEncounter(player, 0x05, 0x19);
            L00E4: AddEncounter(player, 0x06, 0x19);
            L00F6: goto L0105;
            L00F8: ShowMessage(player, String0F64); // All that remains of your battle here is a fractured tusk and a splintered staff.
            L0105: return; // RETURN;
        }

        private void Fn_13(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x05));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L0143;
            L001B: SetFlag(player, 0x03, 0x05, 0x01);
            L0030: ShowMessage(player, String0FB5); // With all the secret and locked doors in here, you knew it was just a matter of time before you ran into some halfling thieves.
            L003D: Compare(GetFlag(player, 0x03, 0x09), 0x0001);
            L0051: if (JumpNotEqual) goto L0061;
1145  0053 B8 34 10  mov ax, 0x1034
            L0056: PushStack(player, ax);
1149  0057 C4 5E 06  les bx, [bp+0x6]
114C  005A 26 FF 9F F8 00  call far word [es:bx+0xf8]
            L005F: goto L0084;
            L0061: ShowMessage(player, String1061); // It's a shame you weren't looking for them.
            L006E: ax = GetMaxHits(player);
            L0075: bx = 0x0003;
            L0078: dx = ax % bx; ax = ax / bx;
            L007B: DamagePlayer(player, ax);
            L0085: Compare(PartyCount(player), 0x0003);
            L0090: if (JumpBelowOrEqual) goto L009F;
            L0092: ShowMessage(player, String108C); // Groups this large are easy to spot.
            L009F: PushStack(player, 0xD4);
            L00A3: PushStack(player, 0x00);
            L00A6: PushStack(player, ax);
            L00A7: PushStack(player, ax);
            L00A8: PushStack(player, 0xFB);
            L00AC: PushStack(player, 0x36);
11A2  00B0 C4 5E 06  les bx, [bp+0x6]
11A5  00B3 26 FF 9F D8 00  call far word [es:bx+0xd8]
11AA  00B8 83 C4 0C  add sp, 0xc
            L00BB: AddEncounter(player, 0x01, 0x23);
            L00CD: AddEncounter(player, 0x02, 0x18);
            L00DF: AddEncounter(player, 0x03, 0x22);
            L00F1: Compare(PartyCount(player), 0x0002);
            L00FC: if (JumpBelowOrEqual) goto L0110;
            L00FE: AddEncounter(player, 0x04, 0x18);
            L0110: Compare(PartyCount(player), 0x0003);
            L011B: if (JumpBelowOrEqual) goto L015D;
            L011D: AddEncounter(player, 0x05, 0x22);
            L012F: AddEncounter(player, 0x06, 0x23);
            L0141: goto L015D;
            L0143: ShowMessage(player, String10B0); // All that remains of your battle here is a broken toe-nail and a pipe full of weed.
            L0150: ShowMessage(player, String1103); // Don't worry.  Cyberweed is not a controlled substance, and in cyberspace there's no such thing as second hand smoke.
            L015D: return; // RETURN;
        }

        private void Fn_14(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFlag(player, 0x03, 0x09, 0x00);
            L0017: return; // RETURN;
        }

        private void Fn_15(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x06));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00E4;
            L001B: SetFlag(player, 0x03, 0x06, 0x01);
            L0030: ShowMessage(player, String1178); // The good news is that dragons rarely travel in pairs.  The bad news is that these dragons are travelling in packs of three!
12A7  003D B8 28 23  mov ax, 0x2328
            L0040: PushStack(player, ax);
            L0041: PushStack(player, 0x00);
            L0044: PushStack(player, ax);
            L0045: PushStack(player, 0xBB);
            L0049: PushStack(player, 0xCD);
            L004D: PushStack(player, 0x64);
12BB  0051 C4 5E 06  les bx, [bp+0x6]
12BE  0054 26 FF 9F D8 00  call far word [es:bx+0xd8]
12C3  0059 83 C4 0C  add sp, 0xc
            L005C: AddEncounter(player, 0x01, 0x24);
            L006E: AddEncounter(player, 0x05, 0x24);
            L0080: Compare(PartyCount(player), 0x0002);
            L008B: if (JumpBelowOrEqual) goto L00B1;
            L008D: AddEncounter(player, 0x02, 0x24);
            L009F: AddEncounter(player, 0x06, 0x24);
            L00B1: Compare(PartyCount(player), 0x0003);
            L00BC: if (JumpBelowOrEqual) goto L00F1;
            L00BE: AddEncounter(player, 0x03, 0x24);
            L00D0: AddEncounter(player, 0x04, 0x24);
            L00E2: goto L00F1;
            L00E4: ShowMessage(player, String11F4); // Some days the dragon wins.  This wasn't one of them.
            L00F1: return; // RETURN;
        }

        private void Fn_16(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x07));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00FB;
            L001B: SetFlag(player, 0x03, 0x07, 0x01);
            L0030: ShowMessage(player, String1229); // The good news is that there is not an actual king on the throne here.  The bad news is that it's a bunch of those thrice bedratted halflings with an ambush all arranged!
            L003D: ax = GetMaxHits(player);
            L0044: bx = 0x0003;
            L0047: dx = ax % bx; ax = ax / bx;
            L004A: DamagePlayer(player, ax);
13B1  0054 B8 6F 06  mov ax, 0x66f
            L0057: PushStack(player, ax);
            L0058: PushStack(player, 0x00);
            L005B: PushStack(player, ax);
            L005C: PushStack(player, 0xCE);
            L0060: PushStack(player, 0xBA);
            L0064: PushStack(player, 0x93);
13C5  0068 C4 5E 06  les bx, [bp+0x6]
13C8  006B 26 FF 9F D8 00  call far word [es:bx+0xd8]
13CD  0070 83 C4 0C  add sp, 0xc
            L0073: AddEncounter(player, 0x01, 0x23);
            L0085: AddEncounter(player, 0x02, 0x22);
            L0097: AddEncounter(player, 0x05, 0x23);
            L00A9: Compare(PartyCount(player), 0x0002);
            L00B4: if (JumpBelowOrEqual) goto L00DA;
            L00B6: AddEncounter(player, 0x04, 0x22);
            L00C8: AddEncounter(player, 0x03, 0x23);
            L00DA: Compare(PartyCount(player), 0x0003);
            L00E5: if (JumpBelowOrEqual) goto L0108;
            L00E7: AddEncounter(player, 0x06, 0x23);
            L00F9: goto L0108;
            L00FB: ShowMessage(player, String12D3); // Your battle here proved the old adage: 'You can never hold a throne if your feet don't reach the floor.'
            L0108: return; // RETURN;
        }

        private void Fn_17(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x0A, 0x01, 0xFB, 0x03, isForwardMove);
            L001E: return; // RETURN;
        }

        private void Fn_18(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x0B, 0x01, 0x6F, 0x00, isForwardMove);
            L001D: return; // RETURN;
        }

        private void Fn_19(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x0E));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00A4;
            L001B: SetFlag(player, 0x03, 0x0E, 0x01);
            L0030: ShowPortrait(player, 0x0020);
            L003D: GiveItem(player, 0xDD);
            L0049: RefreshCompareFlags(GetFlag(player, 0x03, 0x0A));
            L005C: if (JumpNotEqual) goto L007D;
            L005E: ShowMessage(player, String133C); // 'Huzzah for thy masterful turn of arms against Macduff's shade.  I will permit myself a smidgeon of hope that at last the evil that resides herein may be ended.
            L006B: ShowMessage(player, String13DD); // Now attend!  Macbeth's Ghost dost reside in the Aerie, surrounded by all manners of flying beasts, including flying undead.  The undying also greatly inhabit Astrologia and Alchemia.
151E  0078 B8 94 14  mov ax, 0x1494
            L007B: goto L008D;
            L007D: ShowMessage(player, String14BF); // 'Hist!  Attend!  I have little time.  Macbeth's Ghost dost reside in the Aerie, surrounded by all manners of flying beasts, including several undead.  And flying undying also greatly inhabit Astrologia and Alchemia.
            L008A: ShowMessage(player, String1597); // May thy sword arm never tire.'
            L0097: ShowMessage(player, String14B3); // He departs.
            L00A4: return; // RETURN;
        }

        private void Fn_1A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0016);
            L0010: ShowMessage(player, String15B6); // The plaque reads: 'Here be Evilwillit Armstrong, wanted for stealing two oxen, one young and one mature milk cow, six chickens, a brace of ducks, a fine nanny and her kid, thirty-five ewes, one ram...
            L001D: ShowMessage(player, String167F); // ... a workable feather mattress, a good iron skillet, a long wooden spoon, and several unpermissioned kisses from Laird-give-me-little Eliot and her eldest daughter Sweet-milk.'
            L002A: return; // RETURN;
        }

        private void Fn_1B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0017);
            L0010: ShowMessage(player, String1731); // The plaque reads: 'Here be Bangtail Bobby Bell.  On the charge fyled against her of stealing three horses from Skinabake Armstrong she has been found foul conditionally.'
            L001D: return; // RETURN;
        }

        private void Fn_1C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0018);
            L0010: ShowMessage(player, String17DC); // The plaque reads: 'This be Laird-give-me-little Eliot, found guilty of overswearing to the amount of twenty-nine sheep.'
            L001D: return; // RETURN;
        }

        private void Fn_1D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0019);
            L0010: ShowMessage(player, String1855); // The plaque reads: 'This be Curst Clem Croser, found guilty of kidnapping and holding for ransom Wanton Sim Scott.'
            L001D: return; // RETURN;
        }

        private void Fn_1E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0029);
            L0010: ShowMessage(player, String18C8); // The plaque reads: 'This be David-no-good-priest Armstrong, found guilty of failure to light his beacon at night while the Carleton's were reiving.'
            L001D: return; // RETURN;
        }

        private void Fn_1F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x002B);
            L0010: ShowMessage(player, String195C); // The plaque reads: 'This be Winking Warren Scott, found guilty of playing tables with false dice.
            L001D: return; // RETURN;
        }

        private void Fn_20(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x002B);
            L0010: ShowMessage(player, String19BD); // The plaque reads: 'This be Curst Conan Burns, found guilty of using Black Magics and cheating at cards.'
            L001D: return; // RETURN;
        }

        private void Fn_21(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x002B);
            L0010: ShowMessage(player, String1A26); // The plaque reads: 'This be Winking Sean Wilkinson, found guilty of abusing and ill-using Sore John Graham's spades.'
            L001D: return; // RETURN;
        }

        private void Fn_22(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x002B);
            L0010: ShowMessage(player, String1A9B); // The plaque reads: 'This be Winking William Musgrave, found guilty of sharping, gulling, and gambling on chess.'
            L001D: return; // RETURN;
        }

        private void Fn_23(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x002C);
            L0010: ShowMessage(player, String1B0B); // The plaque reads: 'This be Winking Cynthia Turner, found guilty of balderdash in the first degree.'
            L001D: return; // RETURN;
        }

        private void Fn_24(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x002B);
            L0010: ShowMessage(player, String1B6F); // The plaque reads: 'This be Winking Stephen Laidlaw, found guilty of abuse of bagels.'
            L001D: return; // RETURN;
        }

        private void Fn_25(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x002C);
            L0010: ShowMessage(player, String1BC5); // The plaque reads: 'This be Winking Jeanne Burns, found guilty of overindulgence in cards.'
            L001D: return; // RETURN;
        }

        private void Fn_26(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x002B);
            L0010: ShowMessage(player, String1C20); // The plaque reads: 'This be Winking George Matthews, found guilty of crimes too numerous to mention.'
            L001D: return; // RETURN;
        }

        private void Fn_27(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x002B);
            L0010: ShowMessage(player, String1C85); // The plaque reads: 'Here be Winking Dicky Armstrong, found guilty of abuse of poetic license.'
            L001D: return; // RETURN;
        }

        private void Fn_28(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0022);
            L0010: ShowMessage(player, String1CE3); // The plaque reads: 'Here be Winking Gloria Graham, found guilty of animal husbandry.'
            L001D: return; // RETURN;
        }

        private void Fn_29(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x002B);
            L0010: ShowMessage(player, String1D38); // The plaque reads: 'Here be Winking Timothy Irvine, found guilty of consorting with undead.'
            L001D: return; // RETURN;
        }

        private void Fn_2A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0022);
            L0010: ShowMessage(player, String1D94); // The plaque reads: 'Here be Winking Claudia Nixon, found guilty of cavorting with monsters.'
            L001D: return; // RETURN;
        }

        private void Fn_2B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x002B);
            L0010: ShowMessage(player, String1DF0); // The plaque reads: 'Here be Winking Danny Robson, found guilty of poaching insects.'
            L001D: return; // RETURN;
        }

        private void Fn_2C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0A26); // The carnage from your epic battle with the mighty Macduff is scattered over this entire area.
            L0010: Compare(GetFlag(player, 0x03, 0x0A), 0x0002);
            L0024: if (JumpNotEqual) goto L0063;
            L0026: GiveItem(player, 0x24);
            L0032: GiveItem(player, 0x81);
            L003E: GiveItem(player, 0xCE);
            L004A: GiveItem(player, 0xBB);
            L0056: ShowMessage(player, String1E44); // And a few goodies, too!
            L0063: SetFlag(player, 0x03, 0x0A, 0x01);
            L0078: return; // RETURN;
        }

        private void Fn_2D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x0D));
            L0016: if (JumpNotEqual) goto L0061;
            L0018: SetFlag(player, 0x03, 0x0D, 0x01);
            L002D: ShowPortrait(player, 0x002D);
            L003A: ShowMessage(player, String1E5C); // 'Good gentle, couldst assist a humble servant of his majesty's office of assizes?  Upon our plans we show one higher level than this, and yet I can find no stairs!'
            L0047: ShowMessage(player, String1F01); // You know of no stairs either, and tell him so.  In fact, judging from the windows, this is the top floor.
            L0054: ShowMessage(player, String1F6B); // 'Certes, they are upon my charts and papers, so they must be here somewhere.  Forgive my interruption.'  He goes back to searching the wall.
            L0061: return; // RETURN;
        }

        private void Fn_2F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1FF8); // There sure are a lot of stairs here!
            L0010: return; // RETURN;
        }

    }
}
