#pragma warning disable
using System.Collections.Generic;
using XPT.WorldData;
using XPT.WorldData.Yserbius;

namespace XPT.Scripts.Yserbius.Maps {
    class YserMap22 : AMapScripted {
        protected override int MapIndex => 22;
        protected override int RandomEncounterChance => 12;
        protected override int RandomEncounterExtraCount => 2;

        public YserMap22() {
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
        }
        
        // === Strings ================================================
        private const string String0140 = "A cold breeze sends shivers down your spine.";
        private const string String016D = "You've uncovered a hidden door!";
        private const string String018D = "You have unlocked the hidden door!";
        private const string String01B0 = "Your lockpick is no more.  It has ceased to key.  It's a stick.  Bereft of heft, it rests in pieces.  This is an ex-lockpick.";
        private const string String022E = "You detect a hidden door, but it is locked.";
        private const string String025A = "You hunker down and try to concentrate on your skills while you are still being attacked and damaged by a hail of arrows and spells.  But at least you are presenting a smaller target while you are hunkered down.";
        private const string String032E = "That was a stiff lock, but you finally got it open.";
        private const string String0362 = "Funny how an irksome little lock on a flimsy little door can keep out a big strong person like you.";
        private const string String03C6 = "You find some tracks indicating that something headed off this way.";
        private const string String040A = "You hear some wings flapping away.";
        private const string String042D = "You see some people running towards you.";
        private const string String0456 = "*";
        private const string String0458 = "'Come along!  I am Simon's Richard and you are late for your exercise class.";
        private const string String04A5 = "Wearing all that extra weight can build muscle mass, but there is no replacement for aerobic exercise if you are going to successfully flee a dragon!'";
        private const string String053C = "You say you did not sign up for any exercise classes.  He goes off in search of someone else to sign up.";
        private const string String05A5 = "The dragon sniffs you expectantly.";
        private const string String05C8 = "'I seek Richie Whitcomb, a halfling of no honor.  He got me drunk and wrote up an innocent tale of dropping diamonds down the volcano I lived in without mentioning that the volcano was extinct.";
        private const string String068A = "I must say, that is a halfling with a short life expectancy.'";
        private const string String06C8 = "You recall Rory's fey prophecy made on this very spot.  It was true: he could not conclude the quest.";
        private const string String072E = "'This was tough, very tough, old friend.  I know not if I can pursue this quest to its conclusion.";
        private const string String0791 = "I return to the guild hall in search of healing of mind and body.  And 'ware low flying dragons!";
        private const string String07F2 = "Rory staggers off.";
        private const string String0805 = "You know the old saying: diamonds are forever.  Well, these thieves have examined your booty bags and decided that the saying really is: diamonds are for reivers!";
        private const string String08A8 = "Made you look!  Made you look!";
        private const string String08C7 = "Ah ha!  Now I know that you check for secret doors where I leave friendly messages.  Starting with next level, you're on your own.";
        private const string String094A = "You find a secret door!  Unfortunately it's mouse sized and you won't fit through it.";
        private const string String09A0 = "Yup, that's a wall!";
        private const string String09B4 = "For a second you pierce the veils of illusion that cloak all our so-called reality.  You are at one with the universe.  You understand the world and your place in it.";
        private const string String0A5B = "Life is precious, beautiful, and fragile.  Then you blink, and realize that it's only a wall after all.";
        private const string String0AC3 = "You scrape at the wall and discover that before it was painted brown, it had been painted a truly revolting shade of mauve!";
        private const string String0B3F = "Well, maybe you don't consider that important, but it gives you some idea of just what kind of lunatics run this place!";
        private const string String0BB7 = "You find an old, unused, arrow slit.  You pry it open to peer through.  Shortly thereafter you find a nice new arrow!";
        private const string String0C2D = "Someone has been using this wall to record heights.  You now know the virtually useless fact that the last time Peregrine Bertie was measured here, he was five feet eight and one half inches tall.";
        private const string String0CF2 = "Sherlock Holmes would be able to read these scratches and announce that a red scaled dragon swallowed a harpy exactly seven feet off the ground here 77 days ago.  But Sherlock would never visit such a silly place.";
        private const string String0DC8 = "Above a plaster patch mark you find written the phrase 'I love Thisbe.'";
        private const string String0E10 = "Don't worry; this is as obscure as I can get without too many complaints.";
        private const string String0E5A = "There is a residue of noxious gas leaking from the door to the east.";
        private const string String0E9F = "The door in front of you clicks locked.  Something to the south also made a clicking sound.  It's not so easy to breech Macbeth's defenses.";
        private const string String0F2B = "You hear a click to the south.";
        private const string String0F4A = "There are broken windows and crumbling walls along the north and west walls of the Aerie.  Many claw marks show on the window sills and the floors near the windows.";
        private const string String0FEF = "'Huzzah!  Huzzah!  And thrice Huzzah!  Thou hast climbed to the topmost peak of Cawdor, and my sisters have fled to the dubious safety of the tombs.  Return thee to The Runed Room.'";
        private const string String10A5 = "'I will leave the most secret door ajar so that thou wilt be able to follow us and end at last our unholy lives.'";
        private const string String1117 = "This door leads to Alchemia.";
        private const string String1134 = "This door seems blocked, but after some pushing you are able to clear it, though there seems to be nothing but rubble on the other side.";
        private const string String11BD = "A sign over the door reads:  'Warning!  This area is heavily patrolled and off limits to all!  Enter and your still bleeding corpse will be fed to the dragons.'";
        private const string String125E = "This reminds you of an old gym coach whose welcome mat had that phrase upon it.";
        private const string String12AE = "Boy, this window is awful ricket-AIYEEEEE!!!!!";
        private const string String12DD = "As you fall to your death, you decide to take any future warnings a bit more seriously.";
        private const string String1335 = "***";
        private const string String1339 = "Okay, he may have been a traitor, a murderer, a regicide, and a thorough villain, but Macbeth sure had some cool stuff.  That Healing Locket can heal entire parties in combat!";
        private const string String13E9 = "Except for the sound of a door slamming as Macbeth's troops swiftly advance to the rear, this place is silent.";
        private const string String1458 = "You have hit the special effects jackpot.  Blinding sheets of flame and lightning and entire barnyard's worth of large bovine creatures are launched towards you.";
        private const string String14FA = "A small fortune could have been made had you brought enough barbecue sauce.";
        private const string String1546 = "Fortunately for the janitors the flames and lightning disintegrate the bovines.";
        private const string String1596 = "INN's Community standards prevent us from displaying the gore, but believe you me, it is significant!";
        private const string String15FC = "Oh, all right, most of the critters in this volley are really death dealing ducks and kamikaze chickens, but since we can't show it to you we decided to at least sound impressive!";
        private const string String16B0 = "No wonder the British have such a reputation for bad cooking.  They didn't even skin the cattle before cooking them.";
        private const string String1725 = "You think this is bad?  You're lucky!  The cattle are absorbing most of the magic before it reaches you, and the magic is burning away most of the cattle before they reach you.";
        private const string String17D6 = "Holey Holsteins!  You've heard of flying cows, but you've never had a herd of flying cows drop on you before!";
        private const string String1844 = "As several tons of flaming death splatter on and around you, you ask yourself whether it's too late to listen to your mother and start a career as a garlic monger.";
        private const string String18E8 = "Your doctor warned you that too much red meat would be bad for you.  He was right.";
        private const string String193B = "Hey, the bovines are just as unhappy about it as you are!";
        private const string String1975 = "A corruscating volley of magical spells, a rain of arrows, and a slew of taunts strike at and near you, causing serious damage.";
        private const string String19F5 = "As you leisurely examine the defenses of this place, you realize that it would have been awfully tough to take by direct assault.";
        private const string String1A77 = "A few half-hearted arrows, quarrels, sticks, and stones strike at and near you, causing some minor damage.";
        private const string String1AE2 = "You see all the bones and bloodstains and realize two important things:  a lot of people died trying to take this place, and Macbeth did not much care about housekeeping.";
        private const string String1B8D = "Curses!  The door in front of you is solidly barred.";
        private const string String1BC2 = "You hear a click to the north.";
        private const string String1BE1 = "Mortar and stone!  Was that east wall here a moment ago?";
        private const string String1C1A = "Macbeth's ghost greets you with a heavy claymore and a fine battle cry.";
        private const string String1C62 = "'I will try the last: before my ghostly body I throw my warlike shield.  Lay on!  Lay on!  And damn'd be him that first doth cry I yield!'";
        private const string String1CED = "Somehow you expected a battle with Macbeth to have left more traces.";
        private const string String1D32 = "The sign over the double doors reads: 'Here there be dragons.'";
        private const string String1D71 = "Like the door sign said, here there be dragons!";
        private const string String1DA1 = "Huh!  Dragons.  They weren't so tough after all.";
        private const string String1DD2 = "Ghosties and ghoulies and vamps, oh my!";
        private const string String1DFA = "You came, you saw, you mashed some ectoplasm!";
        private const string String1E28 = "A bunch of little folks with big aspirations decide that you are just their size.";
        private const string String1E7A = "Although there are enough of them that I bet they have you outweighed if not outvolumed.";
        private const string String1ED3 = "The race may not be to the swift, nor the battle to the big, but you showed a bunch of little guys that that was the way to bet!";
        private const string String1F54 = "Now you know what the sign over the door meant: be on guard against all these imps before they drive you batty!";
        private const string String1FC4 = "All that remains of your battle here is a cloven hoof and a forked tongue.";
        private const string String200F = "The sign over the door reads: 'The Imperial Guard.'";
        private const string String2043 = "I guess you do look like an easier target than the dragons, imps, and other nasties that live here.";
        private const string String20A7 = "You weren't an easier target after all than the dragons, imps, and other nasties that live here.  Heh heh.";
        private const string String2112 = "It's a harrying horde of harpies.  And you without your stinger missiles.";
        private const string String215C = "You didn't need late twentieth century technology to defeat those harpies after all.  It's a good thing, too: just inventing a time machine would probably have taken you longer than your lifespan.";
        private const string String2221 = "The sign over the door reads: 'A Den of Antiquity'";
        private const string String2254 = "When these dragons said they wanted their privacy, they weren't kidding!";
        private const string String229D = "Boy, did you fight a lot of big dragons here!  There are more left wings scattered about than at any hockey game!";
        private const string String230F = "The sign over the door reads, 'You better have a good enough reason to die for before you come in here!'";
        private const string String2378 = "Hey!  You didn't hear any doors click!";
        private const string String239F = "The door in front of you clicks locked.  Something to the north also made a clicking sound.  It's not so easy to breech Macbeth's defenses.";
        
        // === Functions ================================================
        private void Fn_01(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0140); // A cold breeze sends shivers down your spine.
            L0010: Compare(HasUsedSkill(player, 0x0D), 0x0009);
            L001F: if (JumpNotBelow) goto L008D;
            L0021: RefreshCompareFlags(HasUsedSpell(player, 0x17));
            L002F: if (JumpNotEqual) goto L008D;
            L0031: PushStack(player, 0x67);
            L0035: PushStack(player, ax);
0041  0036 C4 5E 06  les bx, [bp+0x6]
0044  0039 26 FF 5F 54  call far word [es:bx+0x54]
            L003D: cx = PopStack(player);
            L003E: cx = PopStack(player);
            L003F: RefreshCompareFlags(ax);
            L0041: if (JumpNotEqual) goto L008D;
            L0043: PushStack(player, 0x61);
            L0047: PushStack(player, ax);
0053  0048 C4 5E 06  les bx, [bp+0x6]
0056  004B 26 FF 5F 54  call far word [es:bx+0x54]
            L004F: cx = PopStack(player);
            L0050: cx = PopStack(player);
            L0051: RefreshCompareFlags(ax);
            L0053: if (JumpNotEqual) goto L008D;
            L0055: PushStack(player, 0x93);
            L0059: PushStack(player, ax);
0065  005A C4 5E 06  les bx, [bp+0x6]
0068  005D 26 FF 5F 54  call far word [es:bx+0x54]
            L0061: cx = PopStack(player);
            L0062: cx = PopStack(player);
            L0063: RefreshCompareFlags(ax);
            L0065: if (JumpNotEqual) goto L008D;
            L0067: PushStack(player, 0x86);
            L006B: PushStack(player, ax);
0077  006C C4 5E 06  les bx, [bp+0x6]
007A  006F 26 FF 5F 54  call far word [es:bx+0x54]
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
00D7  00CC C4 5E 06  les bx, [bp+0x6]
00DA  00CF 26 FF 5F 2C  call far word [es:bx+0x2c]
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
0145  0029 C4 5E 06  les bx, [bp+0x6]
0148  002C 26 FF 5F 54  call far word [es:bx+0x54]
            L0030: cx = PopStack(player);
            L0031: cx = PopStack(player);
            L0032: RefreshCompareFlags(ax);
            L0034: if (JumpNotEqual) goto L0083;
            L0036: PushStack(player, 0x61);
            L003A: PushStack(player, ax);
0157  003B C4 5E 06  les bx, [bp+0x6]
015A  003E 26 FF 5F 54  call far word [es:bx+0x54]
            L0042: cx = PopStack(player);
            L0043: cx = PopStack(player);
            L0044: RefreshCompareFlags(ax);
            L0046: if (JumpNotEqual) goto L0083;
            L0048: PushStack(player, 0x93);
            L004C: PushStack(player, ax);
0169  004D C4 5E 06  les bx, [bp+0x6]
016C  0050 26 FF 5F 54  call far word [es:bx+0x54]
            L0054: cx = PopStack(player);
            L0055: cx = PopStack(player);
            L0056: RefreshCompareFlags(ax);
            L0058: if (JumpNotEqual) goto L0083;
            L005A: PushStack(player, 0x86);
            L005E: PushStack(player, ax);
017B  005F C4 5E 06  les bx, [bp+0x6]
017E  0062 26 FF 5F 54  call far word [es:bx+0x54]
            L0066: cx = PopStack(player);
            L0067: cx = PopStack(player);
            L0068: RefreshCompareFlags(ax);
            L006A: if (JumpNotEqual) goto L0083;
            L006C: ax = IsFlagOn(player, 0x00, 0x01);
            L007E: if (JumpNotEqual) goto L0083;
            L0080: goto L01C1;
            L0083: SetWallObject(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L00A1: PushStack(player, 0x01);
            L00A5: PushStack(player, ax);
            L00A6: PushStack(player, 0x00);
01C5  00A9 C4 5E 06  les bx, [bp+0x6]
01C8  00AC 26 FF 1F  call far word [es:bx]
01CB  00AF 83 C4 06  add sp, 0x6
            L00B2: Compare(GetSkillLevel(player, 0x0E), 0x000C);
            L00C1: if (JumpBelow) goto L0103;
            L00C3: PushStack(player, 0xDD);
            L00C7: PushStack(player, ax);
01E4  00C8 C4 5E 06  les bx, [bp+0x6]
01E7  00CB 26 FF 5F 54  call far word [es:bx+0x54]
            L00CF: cx = PopStack(player);
            L00D0: cx = PopStack(player);
            L00D1: RefreshCompareFlags(ax);
            L00D3: if (JumpEqual) goto L0103;
            L00D5: ShowMessage(player, String018D); // You have unlocked the hidden door!
            L00E2: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0100: goto L01C1;
            L0103: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0120: ax = HasUsedItem(player, 0xC1, 0xC3);
            L0133: if (JumpNotEqual) goto L014A;
            L0135: ax = HasUsedItem(player, 0xDA, 0xDC);
            L0148: if (JumpEqual) goto L0197;
            L014A: RemoveItem(player, 0xC1);
            L0156: RemoveItem(player, 0xC2);
            L0162: RemoveItem(player, 0xC3);
            L016E: RemoveItem(player, 0xDA);
            L017A: RemoveItem(player, 0xDB);
            L0186: RemoveItem(player, 0xDC);
02AE  0192 B8 B0 01  mov ax, 0x1b0
            L0195: goto L01B7;
            L0197: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L01B4: ShowMessage(player, String022E); // You detect a hidden door, but it is locked.
            L01C1: RefreshCompareFlags(GetFlag(player, 0x03, 0x0C));
            L01D4: if (JumpNotEqual) goto L01F2;
            L01D6: DamagePlayer(player, 0x03E8);
            L01E3: ShowMessage(player, String025A); // You hunker down and try to concentrate on your skills while you are still being attacked and damaged by a hail of arrows and spells.  But at least you are presenting a smaller target while you are hunkered down.
            L01F0: goto L020F;
            L01F2: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L020F: return; // RETURN;
        }

        private void Fn_03(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x68);
            L0007: PushStack(player, ax);
0335  0008 C4 5E 06  les bx, [bp+0x6]
0338  000B 26 FF 5F 54  call far word [es:bx+0x54]
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
0398  006B C4 5E 06  les bx, [bp+0x6]
039B  006E 26 FF 5F 54  call far word [es:bx+0x54]
            L0072: cx = PopStack(player);
            L0073: cx = PopStack(player);
            L0074: RefreshCompareFlags(ax);
            L0076: if (JumpNotEqual) goto L009F;
            L0078: ax = HasUsedItem(player, 0xDA, 0xDD);
            L008B: if (JumpNotEqual) goto L009F;
            L008D: PushStack(player, 0xC0);
            L0091: PushStack(player, ax);
03BF  0092 C4 5E 06  les bx, [bp+0x6]
03C2  0095 26 FF 5F 54  call far word [es:bx+0x54]
            L0099: cx = PopStack(player);
            L009A: cx = PopStack(player);
            L009B: RefreshCompareFlags(ax);
            L009D: if (JumpEqual) goto L00CD;
            L009F: ShowMessage(player, String032E); // That was a stiff lock, but you finally got it open.
            L00AC: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L00CA: goto L0152;
            L00CD: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L00EA: ax = HasUsedItem(player, 0xC1, 0xC3);
            L00FD: if (JumpEqual) goto L0128;
            L00FF: RemoveItem(player, 0xC1);
            L010B: RemoveItem(player, 0xC2);
            L0117: RemoveItem(player, 0xC3);
0450  0123 B8 B0 01  mov ax, 0x1b0
            L0126: goto L0148;
            L0128: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0145: ShowMessage(player, String0362); // Funny how an irksome little lock on a flimsy little door can keep out a big strong person like you.
            L0152: return; // RETURN;
        }

        private void Fn_04(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, 0x0B), 0x0009);
            L0012: if (JumpNotBelow) goto L0038;
            L0014: PushStack(player, 0x62);
            L0018: PushStack(player, ax);
049A  0019 C4 5E 06  les bx, [bp+0x6]
049D  001C 26 FF 5F 54  call far word [es:bx+0x54]
            L0020: cx = PopStack(player);
            L0021: cx = PopStack(player);
            L0022: RefreshCompareFlags(ax);
            L0024: if (JumpNotEqual) goto L0038;
            L0026: PushStack(player, 0x8F);
            L002A: PushStack(player, ax);
04AC  002B C4 5E 06  les bx, [bp+0x6]
04AF  002E 26 FF 5F 54  call far word [es:bx+0x54]
            L0032: cx = PopStack(player);
            L0033: cx = PopStack(player);
            L0034: RefreshCompareFlags(ax);
            L0036: if (JumpEqual) goto L005A;
            L0038: ShowMessage(player, String03C6); // You find some tracks indicating that something headed off this way.
            L0045: SetFlag(player, 0x03, 0x09, 0x01);
            L005A: return; // RETURN;
        }

        private void Fn_05(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si, di);
            L0005: di = 0;
            L0007: si = 0;
            L0009: ax = GetFlag(player, 0x03, 0x08);
04F7  001A 8B F8  mov di, ax
04F9  001C 47     inc di
04FA  001D 8B F7  mov si, di
            L001F: Compare(si, 0x13);
            L0022: if (JumpLessOrEqual) goto L002B;
0501  0024 8B C6  mov ax, si
            L0026: si = ax + 0xFFEC;
            L002B: Compare(si, 0x0E);
            L002E: if (JumpLessOrEqual) goto L0037;
050D  0030 8B C6  mov ax, si
            L0032: si = ax + 0xFFF1;
            L0037: Compare(si, 0x09);
            L003A: if (JumpLessOrEqual) goto L0043;
0519  003C 8B C6  mov ax, si
            L003E: si = ax + 0xFFF6;
            L0043: Compare(si, 0x04);
            L0046: if (JumpLessOrEqual) goto L004F;
0525  0048 8B C6  mov ax, si
            L004A: si = ax + 0xFFFB;
052C  004F 0B F6  or si, si
052E  0051 7D 02  jge 0x55
            L0053: si = 0;
            L0055: Compare(si, 0x1D);
            L0058: if (JumpLessOrEqual) goto L005C;
            L005A: si = 0;
0539  005C 83 FF 1E  cmp di, 0x1e
            L005F: if (JumpLessOrEqual) goto L0063;
            L0061: di = 0;
0540  0063 57     push di
            L0064: PushStack(player, 0x08);
            L0068: PushStack(player, 0x03);
0549  006C C4 5E 06  les bx, [bp+0x6]
054C  006F 26 FF 1F  call far word [es:bx]
054F  0072 83 C4 06  add sp, 0x6
0552  0075 83 FF 1A  cmp di, 0x1a
            L0078: if (JumpNotEqual) goto L007F;
0557  007A B8 01 00  mov ax, 0x1
            L007D: goto L0081;
            L007F: PushStack(player, 0x00);
055F  0082 83 FF 14  cmp di, 0x14
            L0085: if (JumpNotEqual) goto L008C;
0564  0087 B8 01 00  mov ax, 0x1
            L008A: goto L008E;
0569  008C 33 C0  xor ax, ax
            L008E: dx = PopStack(player);
056C  008F 0B D0  or dx, ax
            L0091: PushStack(player, dx);
056F  0092 83 FF 0E  cmp di, 0xe
            L0095: if (JumpNotEqual) goto L009C;
0574  0097 B8 01 00  mov ax, 0x1
            L009A: goto L009E;
0579  009C 33 C0  xor ax, ax
            L009E: dx = PopStack(player);
057C  009F 0B D0  or dx, ax
            L00A1: PushStack(player, dx);
057F  00A2 83 FF 08  cmp di, 0x8
            L00A5: if (JumpNotEqual) goto L00AC;
0584  00A7 B8 01 00  mov ax, 0x1
            L00AA: goto L00AE;
0589  00AC 33 C0  xor ax, ax
            L00AE: dx = PopStack(player);
058C  00AF 0B D0  or dx, ax
            L00B1: PushStack(player, dx);
058F  00B2 83 FF 02  cmp di, 0x2
            L00B5: if (JumpNotEqual) goto L00BC;
0594  00B7 B8 01 00  mov ax, 0x1
            L00BA: goto L00BE;
0599  00BC 33 C0  xor ax, ax
            L00BE: dx = PopStack(player);
059C  00BF 0B D0  or dx, ax
            L00C1: if (JumpNotEqual) goto L00C6;
            L00C3: goto L023B;
            L00C6: bx = si;
            L00C8: Compare(bx, 0x04);
            L00CB: if (JumpBelowOrEqual) goto L00D0;
            L00CD: goto L023B;
            L00D0: switch (bx) {
                case 0:
                    goto L00D7;
                case 1:
                    goto L00E7;
                case 2:
                    goto L0147;
                case 3:
                    goto L0174;
                case 4:
                    goto L01BD;
            }
            L00D7: ShowMessage(player, String040A); // You hear some wings flapping away.
            L00E4: goto L023B;
            L00E7: ShowMessage(player, String042D); // You see some people running towards you.
            L00F4: ShowPortrait(player, 0x0026);
            L0101: ShowMessage(player, String0456); // *
            L010E: ShowMessage(player, String0456); // *
            L011B: ShowMessage(player, String0456); // *
            L0128: ShowMessage(player, String0458); // 'Come along!  I am Simon's Richard and you are late for your exercise class.
            L0135: ShowMessage(player, String04A5); // Wearing all that extra weight can build muscle mass, but there is no replacement for aerobic exercise if you are going to successfully flee a dragon!'
061F  0142 B8 3C 05  mov ax, 0x53c
            L0145: goto L00DA;
            L0147: ShowPortrait(player, 0x000E);
            L0154: ShowMessage(player, String05A5); // The dragon sniffs you expectantly.
            L0161: ShowMessage(player, String05C8); // 'I seek Richie Whitcomb, a halfling of no honor.  He got me drunk and wrote up an innocent tale of dropping diamonds down the volcano I lived in without mentioning that the volcano was extinct.
064B  016E B8 8A 06  mov ax, 0x68a
            L0171: goto L00DA;
            L0174: Compare(GetFlag(player, 0x02, 0x47), 0x0001);
            L0188: if (JumpNotEqual) goto L0190;
0667  018A B8 C8 06  mov ax, 0x6c8
            L018D: goto L00DA;
            L0190: ShowPortrait(player, 0x0025);
            L019D: ShowMessage(player, String072E); // 'This was tough, very tough, old friend.  I know not if I can pursue this quest to its conclusion.
            L01AA: ShowMessage(player, String0791); // I return to the guild hall in search of healing of mind and body.  And 'ware low flying dragons!
0694  01B7 B8 F2 07  mov ax, 0x7f2
            L01BA: goto L00DA;
            L01BD: ShowMessage(player, String0805); // You know the old saying: diamonds are forever.  Well, these thieves have examined your booty bags and decided that the saying really is: diamonds are for reivers!
            L01CA: PushStack(player, 0x5D);
            L01CE: PushStack(player, 0x00);
            L01D1: PushStack(player, ax);
            L01D2: PushStack(player, ax);
            L01D3: PushStack(player, 0x94);
            L01D7: PushStack(player, 0xBF);
06B8  01DB C4 5E 06  les bx, [bp+0x6]
06BB  01DE 26 FF 9F D8 00  call far word [es:bx+0xd8]
06C0  01E3 83 C4 0C  add sp, 0xc
            L01E6: AddEncounter(player, 0x01, 0x1A);
            L01F8: AddEncounter(player, 0x05, 0x19);
            L020A: Compare(PartyCount(player), 0x0002);
            L0215: if (JumpBelowOrEqual) goto L023B;
            L0217: AddEncounter(player, 0x02, 0x1A);
            L0229: AddEncounter(player, 0x06, 0x19);
            L023B: return; // RETURN (restoring si, di);
        }

        private void Fn_06(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si, di);
            L0005: ax = GetFlag(player, 0x02, 0x53);
073C  0016 8B F8  mov di, ax
073E  0018 47     inc di
073F  0019 8B F7  mov si, di
            L001B: Compare(si, 0x13);
            L001E: if (JumpLessOrEqual) goto L0027;
0746  0020 8B C6  mov ax, si
            L0022: si = ax + 0xFFEC;
            L0027: Compare(si, 0x09);
            L002A: if (JumpLessOrEqual) goto L0033;
0752  002C 8B C6  mov ax, si
            L002E: si = ax + 0xFFF6;
0759  0033 0B F6  or si, si
075B  0035 7D 02  jge 0x39
            L0037: si = 0;
            L0039: Compare(si, 0x1D);
            L003C: if (JumpLessOrEqual) goto L0040;
            L003E: si = 0;
0766  0040 83 FF 1D  cmp di, 0x1d
            L0043: if (JumpLessOrEqual) goto L0047;
            L0045: di = 0;
076D  0047 57     push di
            L0048: PushStack(player, 0x53);
            L004C: PushStack(player, 0x02);
0776  0050 C4 5E 06  les bx, [bp+0x6]
0779  0053 26 FF 1F  call far word [es:bx]
077C  0056 83 C4 06  add sp, 0x6
            L0059: ShowMessage(player, String0140); // A cold breeze sends shivers down your spine.
            L0066: Compare(HasUsedSkill(player, 0x0D), 0x0001);
            L0075: if (JumpNotBelow) goto L00E4;
            L0077: RefreshCompareFlags(HasUsedSpell(player, 0x17));
            L0085: if (JumpNotEqual) goto L00E4;
            L0087: PushStack(player, 0x67);
            L008B: PushStack(player, ax);
07B2  008C C4 5E 06  les bx, [bp+0x6]
07B5  008F 26 FF 5F 54  call far word [es:bx+0x54]
            L0093: cx = PopStack(player);
            L0094: cx = PopStack(player);
            L0095: RefreshCompareFlags(ax);
            L0097: if (JumpNotEqual) goto L00E4;
            L0099: PushStack(player, 0x61);
            L009D: PushStack(player, ax);
07C4  009E C4 5E 06  les bx, [bp+0x6]
07C7  00A1 26 FF 5F 54  call far word [es:bx+0x54]
            L00A5: cx = PopStack(player);
            L00A6: cx = PopStack(player);
            L00A7: RefreshCompareFlags(ax);
            L00A9: if (JumpNotEqual) goto L00E4;
            L00AB: PushStack(player, 0x93);
            L00AF: PushStack(player, ax);
07D6  00B0 C4 5E 06  les bx, [bp+0x6]
07D9  00B3 26 FF 5F 54  call far word [es:bx+0x54]
            L00B7: cx = PopStack(player);
            L00B8: cx = PopStack(player);
            L00B9: RefreshCompareFlags(ax);
            L00BB: if (JumpNotEqual) goto L00E4;
            L00BD: PushStack(player, 0x86);
            L00C1: PushStack(player, ax);
07E8  00C2 C4 5E 06  les bx, [bp+0x6]
07EB  00C5 26 FF 5F 54  call far word [es:bx+0x54]
            L00C9: cx = PopStack(player);
            L00CA: cx = PopStack(player);
            L00CB: RefreshCompareFlags(ax);
            L00CD: if (JumpNotEqual) goto L00E4;
            L00CF: PushStack(player, 0xA7);
            L00D3: PushStack(player, ax);
07FA  00D4 C4 5E 06  les bx, [bp+0x6]
07FD  00D7 26 FF 5F 54  call far word [es:bx+0x54]
            L00DB: cx = PopStack(player);
            L00DC: cx = PopStack(player);
            L00DD: RefreshCompareFlags(ax);
            L00DF: if (JumpNotEqual) goto L00E4;
            L00E1: goto L018F;
            L00E4: bx = si;
            L00E6: Compare(bx, 0x09);
            L00E9: if (JumpBelowOrEqual) goto L00EE;
            L00EB: goto L018F;
            L00EE: switch (bx) {
                case 0:
                    goto L00F5;
                case 1:
                    goto L00FB;
                case 2:
                    goto L0101;
                case 3:
                    goto L0107;
                case 4:
                    goto L010D;
                case 5:
                    goto L011F;
                case 6:
                    goto L0131;
                case 7:
                    goto L014C;
                case 8:
                    goto L0170;
                case 9:
                    goto L0175;
            }
081B  00F5 B8 A8 08  mov ax, 0x8a8
            L00F8: goto L0185;
0821  00FB B8 C7 08  mov ax, 0x8c7
            L00FE: goto L0185;
0827  0101 B8 4A 09  mov ax, 0x94a
            L0104: goto L0185;
            L0106: // NOP
082D  0107 B8 A0 09  mov ax, 0x9a0
            L010A: goto L0185;
            L010C: // NOP
            L010D: ShowMessage(player, String09B4); // For a second you pierce the veils of illusion that cloak all our so-called reality.  You are at one with the universe.  You understand the world and your place in it.
0840  011A B8 5B 0A  mov ax, 0xa5b
            L011D: goto L0185;
            L011F: ShowMessage(player, String0AC3); // You scrape at the wall and discover that before it was painted brown, it had been painted a truly revolting shade of mauve!
0852  012C B8 3F 0B  mov ax, 0xb3f
            L012F: goto L0185;
            L0131: ShowMessage(player, String0BB7); // You find an old, unused, arrow slit.  You pry it open to peer through.  Shortly thereafter you find a nice new arrow!
            L013E: PushStack(player, 0x32);
0868  0142 C4 5E 06  les bx, [bp+0x6]
086B  0145 26 FF 9F 90 00  call far word [es:bx+0x90]
            L014A: goto L018E;
            L014C: ShowMessage(player, String0C2D); // Someone has been using this wall to record heights.  You now know the virtually useless fact that the last time Peregrine Bertie was measured here, he was five feet eight and one half inches tall.
            L0159: SetFlag(player, 0x02, 0x3D, 0x01);
            L016E: goto L018F;
0896  0170 B8 F2 0C  mov ax, 0xcf2
            L0173: goto L0185;
            L0175: ShowMessage(player, String0DC8); // Above a plaster patch mark you find written the phrase 'I love Thisbe.'
            L0182: ShowMessage(player, String0E10); // Don't worry; this is as obscure as I can get without too many complaints.
            L018F: return; // RETURN (restoring si, di);
        }

        private void Fn_07(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0E5A); // There is a residue of noxious gas leaking from the door to the east.
08DD  0010 B8 F4 01  mov ax, 0x1f4
            L0013: PushStack(player, ax);
            L0014: PushStack(player, 0x05);
            L0018: PushStack(player, 0x01);
08E9  001C C4 5E 06  les bx, [bp+0x6]
08EC  001F 26 FF 9F 9C 00  call far word [es:bx+0x9c]
08F1  0024 83 C4 06  add sp, 0x6
            L0027: DamagePlayer(player, 0x01F4);
            L0034: SetFlag(player, 0x03, 0x0E, 0x01);
            L0049: RefreshCompareFlags(GetFlag(player, 0x02, 0x3B));
            L005C: if (JumpNotEqual) goto L0078;
            L005E: SetFlag(player, 0x02, 0x3B, 0x01);
0940  0073 B8 9F 0E  mov ax, 0xe9f
            L0076: goto L00D1;
            L0078: Compare(GetFlag(player, 0x02, 0x3A), 0x0001);
            L008C: if (JumpNotEqual) goto L00A5;
            L008E: SetFlag(player, 0x03, 0x0D, 0x01);
            L00A3: goto L00DB;
            L00A5: SetFlag(player, 0x03, 0x0D, 0x00);
            L00B9: SetFlag(player, 0x02, 0x3A, 0x01);
            L00CE: ShowMessage(player, String0F2B); // You hear a click to the south.
            L00DB: return; // RETURN;
        }

        private void Fn_08(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFlag(player, 0x02, 0x23, 0x01);
            L0018: RefreshCompareFlags(GetFlag(player, 0x03, 0x0A));
            L002B: if (JumpNotEqual) goto L004F;
            L002D: SetFlag(player, 0x03, 0x0A, 0x01);
            L0042: ShowMessage(player, String0F4A); // There are broken windows and crumbling walls along the north and west walls of the Aerie.  Many claw marks show on the window sills and the floors near the windows.
            L004F: Compare(GetFlag(player, 0x03, 0x0C), 0x0002);
            L0063: if (JumpEqual) goto L0068;
            L0065: goto L0106;
            L0068: RefreshCompareFlags(GetFlag(player, 0x02, 0x3C));
            L007B: if (JumpEqual) goto L0080;
            L007D: goto L0106;
            L0080: ShowPortrait(player, 0x0015);
            L008D: SetFlag(player, 0x02, 0x3C, 0x01);
            L00A2: ShowMessage(player, String0FEF); // 'Huzzah!  Huzzah!  And thrice Huzzah!  Thou hast climbed to the topmost peak of Cawdor, and my sisters have fled to the dubious safety of the tombs.  Return thee to The Runed Room.'
            L00AF: ShowMessage(player, String10A5); // 'I will leave the most secret door ajar so that thou wilt be able to follow us and end at last our unholy lives.'
            L00BC: ax = HasItem(player, 0xEC);
            L00CA: if (JumpNotEqual) goto L00D8;
            L00CC: GiveItem(player, 0xEC);
            L00D8: ax = HasItem(player, 0xE7);
            L00E6: if (JumpNotEqual) goto L00F4;
            L00E8: GiveItem(player, 0xE7);
            L00F4: AddExperience(player, 0x004C4B40);
            L0106: return; // RETURN;
        }

        private void Fn_09(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1117); // This door leads to Alchemia.
            L0010: TeleportParty(player, 0x09, 0x01, 0x50, 0x02, isForwardMove);
            L002B: return; // RETURN;
        }

        private void Fn_0A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1134); // This door seems blocked, but after some pushing you are able to clear it, though there seems to be nothing but rubble on the other side.
            L0010: TeleportParty(player, 0x0B, 0x04, 0x02, 0x01, isForwardMove);
            L002B: return; // RETURN;
        }

        private void Fn_0B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x0B));
            L0016: if (JumpNotEqual) goto L0047;
            L0018: SetFlag(player, 0x03, 0x0B, 0x01);
            L002D: ShowMessage(player, String11BD); // A sign over the door reads:  'Warning!  This area is heavily patrolled and off limits to all!  Enter and your still bleeding corpse will be fed to the dragons.'
            L003A: ShowMessage(player, String125E); // This reminds you of an old gym coach whose welcome mat had that phrase upon it.
            L0047: return; // RETURN;
        }

        private void Fn_0C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String12AE); // Boy, this window is awful ricket-AIYEEEEE!!!!!
            L0010: ShowMessage(player, String12DD); // As you fall to your death, you decide to take any future warnings a bit more seriously.
            L001D: DamagePlayer(player, GetMaxHits(player));
            L002E: return; // RETURN;
        }

        private void Fn_0D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x0C), 0x0001);
            L0017: if (JumpNotEqual) goto L0071;
            L0019: GiveItem(player, 0xEC);
            L0025: GiveItem(player, 0xE7);
            L0031: GiveItem(player, 0x09);
            L003D: ShowMessage(player, String1335); // ***
            L004A: ShowMessage(player, String1335); // ***
            L0057: ShowMessage(player, String1335); // ***
            L0064: ShowMessage(player, String1339); // Okay, he may have been a traitor, a murderer, a regicide, and a thorough villain, but Macbeth sure had some cool stuff.  That Healing Locket can heal entire parties in combat!
            L0071: SetFlag(player, 0x03, 0x0C, 0x02);
            L0086: return; // RETURN;
        }

        private void Fn_0E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si, di);
            L0005: ax = GetFlag(player, 0x02, 0x53);
0C23  0016 8B F8  mov di, ax
0C25  0018 47     inc di
0C26  0019 8B F7  mov si, di
            L001B: Compare(si, 0x13);
            L001E: if (JumpLessOrEqual) goto L0027;
0C2D  0020 8B C6  mov ax, si
            L0022: si = ax + 0xFFEC;
            L0027: Compare(si, 0x09);
            L002A: if (JumpLessOrEqual) goto L0033;
0C39  002C 8B C6  mov ax, si
            L002E: si = ax + 0xFFF6;
0C40  0033 0B F6  or si, si
0C42  0035 7D 02  jge 0x39
            L0037: si = 0;
            L0039: Compare(si, 0x1D);
            L003C: if (JumpLessOrEqual) goto L0040;
            L003E: si = 0;
0C4D  0040 83 FF 1D  cmp di, 0x1d
            L0043: if (JumpLessOrEqual) goto L0047;
            L0045: di = 0;
0C54  0047 57     push di
            L0048: PushStack(player, 0x53);
            L004C: PushStack(player, 0x02);
0C5D  0050 C4 5E 06  les bx, [bp+0x6]
0C60  0053 26 FF 1F  call far word [es:bx]
0C63  0056 83 C4 06  add sp, 0x6
            L0059: Compare(GetFlag(player, 0x03, 0x0C), 0x0001);
            L006D: if (JumpEqual) goto L0085;
            L006F: Compare(GetFlag(player, 0x03, 0x0C), 0x0002);
            L0083: if (JumpNotEqual) goto L008A;
0C92  0085 B8 E9 13  mov ax, 0x13e9
            L0088: goto L00E9;
            L008A: ShowMessage(player, String1458); // You have hit the special effects jackpot.  Blinding sheets of flame and lightning and entire barnyard's worth of large bovine creatures are launched towards you.
            L0097: ax = GetMaxHits(player);
0CAB  009E D1 E8  shr ax, 1
0CAD  00A0 48     dec ax
            L00A1: DamagePlayer(player, ax);
            L00AB: bx = si;
            L00AD: Compare(bx, 0x09);
            L00B0: if (JumpAbove) goto L00F3;
            L00B2: switch (bx) {
                case 0:
                    goto L00B9;
                case 1:
                    goto L00BE;
                case 2:
                    goto L00C3;
                case 3:
                    goto L00C8;
                case 4:
                    goto L00CD;
                case 5:
                    goto L00D2;
                case 6:
                    goto L00D7;
                case 7:
                    goto L00DC;
                case 8:
                    goto L00E1;
                case 9:
                    goto L00E6;
            }
0CC6  00B9 B8 FA 14  mov ax, 0x14fa
            L00BC: goto L00E9;
0CCB  00BE B8 46 15  mov ax, 0x1546
            L00C1: goto L00E9;
0CD0  00C3 B8 96 15  mov ax, 0x1596
            L00C6: goto L00E9;
0CD5  00C8 B8 FC 15  mov ax, 0x15fc
            L00CB: goto L00E9;
0CDA  00CD B8 B0 16  mov ax, 0x16b0
            L00D0: goto L00E9;
0CDF  00D2 B8 25 17  mov ax, 0x1725
            L00D5: goto L00E9;
0CE4  00D7 B8 D6 17  mov ax, 0x17d6
            L00DA: goto L00E9;
0CE9  00DC B8 44 18  mov ax, 0x1844
            L00DF: goto L00E9;
0CEE  00E1 B8 E8 18  mov ax, 0x18e8
            L00E4: goto L00E9;
            L00E6: ShowMessage(player, String193B); // Hey, the bovines are just as unhappy about it as you are!
            L00F3: return; // RETURN (restoring si, di);
        }

        private void Fn_0F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x0C));
            L0016: if (JumpNotEqual) goto L003D;
            L0018: ShowMessage(player, String1975); // A corruscating volley of magical spells, a rain of arrows, and a slew of taunts strike at and near you, causing serious damage.
            L0025: ax = GetMaxHits(player);
            L002C: bx = 0x0004;
            L002F: dx = ax % bx; ax = ax / bx;
            L0032: PushStack(player, ax);
0D4B  0033 C4 5E 06  les bx, [bp+0x6]
0D4E  0036 26 FF 9F 90 00  call far word [es:bx+0x90]
            L003B: goto L0049;
            L003D: ShowMessage(player, String19F5); // As you leisurely examine the defenses of this place, you realize that it would have been awfully tough to take by direct assault.
            L004A: return; // RETURN;
        }

        private void Fn_10(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x0C));
            L0016: if (JumpNotEqual) goto L0033;
            L0018: ShowMessage(player, String1A77); // A few half-hearted arrows, quarrels, sticks, and stones strike at and near you, causing some minor damage.
0D89  0025 B8 F4 01  mov ax, 0x1f4
            L0028: PushStack(player, ax);
0D8D  0029 C4 5E 06  les bx, [bp+0x6]
0D90  002C 26 FF 9F 90 00  call far word [es:bx+0x90]
            L0031: goto L003F;
            L0033: ShowMessage(player, String1AE2); // You see all the bones and bloodstains and realize two important things:  a lot of people died trying to take this place, and Macbeth did not much care about housekeeping.
            L0040: return; // RETURN;
        }

        private void Fn_11(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x0D), 0x0001);
            L0017: if (JumpEqual) goto L001C;
            L0019: goto L00A4;
            L001C: SetFlag(player, 0x02, 0x3A, 0x00);
            L0030: ax = CheckLevel(player, 0x002A);
            L003E: if (JumpEqual) goto L005C;
            L0040: TeleportParty(player, 0x09, 0x02, 0xDD, 0x00, isForwardMove);
            L005A: goto L00CF;
            L005C: ax = CheckLevel(player, 0x0023);
            L006A: if (JumpEqual) goto L0088;
            L006C: TeleportParty(player, 0x09, 0x02, 0xED, 0x00, isForwardMove);
            L0086: goto L00CF;
            L0088: TeleportParty(player, 0x09, 0x02, 0xFD, 0x00, isForwardMove);
            L00A2: goto L00CF;
            L00A4: ShowMessage(player, String1B8D); // Curses!  The door in front of you is solidly barred.
            L00B1: Compare(GetCurrentTile(player), 0x00FE);
            L00BB: if (JumpNotEqual) goto L00C2;
0E63  00BD B8 C2 1B  mov ax, 0x1bc2
            L00C0: goto L00C5;
            L00C2: ShowMessage(player, String0F2B); // You hear a click to the south.
            L00CF: return; // RETURN;
        }

        private void Fn_12(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x0F));
            L0016: if (JumpNotEqual) goto L003A;
            L0018: ShowMessage(player, String1BE1); // Mortar and stone!  Was that east wall here a moment ago?
            L0025: SetFlag(player, 0x03, 0x0F, 0x01);
            L003A: Compare(GetFlag(player, 0x03, 0x0E), 0x0001);
            L004E: if (JumpNotEqual) goto L005C;
            L0050: Compare(GetCurrentTile(player), 0x00DE);
            L005A: if (JumpNotEqual) goto L00A0;
            L005C: Compare(GetFlag(player, 0x03, 0x0E), 0x0002);
            L0070: if (JumpNotEqual) goto L007E;
            L0072: Compare(GetCurrentTile(player), 0x00EE);
            L007C: if (JumpNotEqual) goto L00A0;
            L007E: Compare(GetFlag(player, 0x03, 0x0E), 0x0003);
            L0092: if (JumpNotEqual) goto L00C8;
            L0094: Compare(GetCurrentTile(player), 0x00FE);
            L009E: if (JumpEqual) goto L00C8;
            L00A0: SetFlag(player, 0x03, 0x0E, 0x00);
            L00B4: SetFlag(player, 0x03, 0x0D, 0x00);
            L00C8: return; // RETURN;
        }

        private void Fn_14(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x0C));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L0101;
            L001B: ShowMessage(player, String1C1A); // Macbeth's ghost greets you with a heavy claymore and a fine battle cry.
            L0028: ShowMessage(player, String1C62); // 'I will try the last: before my ghostly body I throw my warlike shield.  Lay on!  Lay on!  And damn'd be him that first doth cry I yield!'
            L0035: SetFlag(player, 0x03, 0x0C, 0x01);
            L004A: SetFlag(player, 0x02, 0x28, 0x01);
            L005F: DamagePlayer(player, 0x03E8);
            L006C: AddEncounter(player, 0x01, 0x28);
            L007E: AddEncounter(player, 0x02, 0x24);
            L0090: Compare(PartyCount(player), 0x0001);
            L009B: if (JumpBelowOrEqual) goto L00C1;
            L009D: AddEncounter(player, 0x05, 0x20);
            L00AF: AddEncounter(player, 0x06, 0x20);
            L00C1: Compare(PartyCount(player), 0x0002);
            L00CC: if (JumpBelowOrEqual) goto L00E0;
            L00CE: AddEncounter(player, 0x03, 0x24);
            L00E0: Compare(PartyCount(player), 0x0003);
            L00EB: if (JumpBelowOrEqual) goto L010E;
            L00ED: AddEncounter(player, 0x04, 0x24);
            L00FF: goto L010E;
            L0101: ShowMessage(player, String1CED); // Somehow you expected a battle with Macbeth to have left more traces.
            L010E: return; // RETURN;
        }

        private void Fn_15(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x0C));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L0101;
            L001B: ShowMessage(player, String1C1A); // Macbeth's ghost greets you with a heavy claymore and a fine battle cry.
            L0028: ShowMessage(player, String1C62); // 'I will try the last: before my ghostly body I throw my warlike shield.  Lay on!  Lay on!  And damn'd be him that first doth cry I yield!'
            L0035: SetFlag(player, 0x03, 0x0C, 0x01);
            L004A: SetFlag(player, 0x02, 0x28, 0x01);
            L005F: DamagePlayer(player, 0x03E8);
            L006C: AddEncounter(player, 0x01, 0x27);
            L007E: AddEncounter(player, 0x02, 0x0B);
            L0090: Compare(PartyCount(player), 0x0001);
            L009B: if (JumpBelowOrEqual) goto L00C1;
            L009D: AddEncounter(player, 0x05, 0x20);
            L00AF: AddEncounter(player, 0x06, 0x20);
            L00C1: Compare(PartyCount(player), 0x0002);
            L00CC: if (JumpBelowOrEqual) goto L00E0;
            L00CE: AddEncounter(player, 0x03, 0x0B);
            L00E0: Compare(PartyCount(player), 0x0003);
            L00EB: if (JumpBelowOrEqual) goto L010E;
            L00ED: AddEncounter(player, 0x04, 0x24);
            L00FF: goto L010E;
            L0101: ShowMessage(player, String1CED); // Somehow you expected a battle with Macbeth to have left more traces.
            L010E: return; // RETURN;
        }

        private void Fn_16(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x0C));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L0101;
            L001B: ShowMessage(player, String1C1A); // Macbeth's ghost greets you with a heavy claymore and a fine battle cry.
            L0028: ShowMessage(player, String1C62); // 'I will try the last: before my ghostly body I throw my warlike shield.  Lay on!  Lay on!  And damn'd be him that first doth cry I yield!'
            L0035: SetFlag(player, 0x02, 0x28, 0x01);
            L004A: SetFlag(player, 0x03, 0x0C, 0x01);
            L005F: DamagePlayer(player, 0x03E8);
            L006C: AddEncounter(player, 0x01, 0x26);
            L007E: AddEncounter(player, 0x02, 0x25);
            L0090: Compare(PartyCount(player), 0x0001);
            L009B: if (JumpBelowOrEqual) goto L00C1;
            L009D: AddEncounter(player, 0x05, 0x19);
            L00AF: AddEncounter(player, 0x06, 0x19);
            L00C1: Compare(PartyCount(player), 0x0002);
            L00CC: if (JumpBelowOrEqual) goto L00E0;
            L00CE: AddEncounter(player, 0x03, 0x25);
            L00E0: Compare(PartyCount(player), 0x0003);
            L00EB: if (JumpBelowOrEqual) goto L010E;
            L00ED: AddEncounter(player, 0x04, 0x25);
            L00FF: goto L010E;
            L0101: ShowMessage(player, String1CED); // Somehow you expected a battle with Macbeth to have left more traces.
            L010E: return; // RETURN;
        }

        private void Fn_17(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1D32); // The sign over the double doors reads: 'Here there be dragons.'
            L0010: return; // RETURN;
        }

        private void Fn_18(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x01));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00E1;
            L001B: ShowMessage(player, String1D71); // Like the door sign said, here there be dragons!
            L0028: PushStack(player, 0x01);
            L002C: PushStack(player, ax);
            L002D: PushStack(player, 0x03);
12B9  0031 C4 5E 06  les bx, [bp+0x6]
12BC  0034 26 FF 1F  call far word [es:bx]
12BF  0037 83 C4 06  add sp, 0x6
12C2  003A B8 16 4B  mov ax, 0x4b16
            L003D: PushStack(player, ax);
            L003E: PushStack(player, 0x00);
            L0041: PushStack(player, ax);
            L0042: PushStack(player, 0xCE);
            L0046: PushStack(player, 0xBB);
            L004A: PushStack(player, 0xF5);
12D6  004E C4 5E 06  les bx, [bp+0x6]
12D9  0051 26 FF 9F D8 00  call far word [es:bx+0xd8]
12DE  0056 83 C4 0C  add sp, 0xc
            L0059: AddEncounter(player, 0x01, 0x24);
            L006B: AddEncounter(player, 0x02, 0x0B);
            L007D: Compare(PartyCount(player), 0x0001);
            L0088: if (JumpBelowOrEqual) goto L00AE;
            L008A: AddEncounter(player, 0x03, 0x0B);
            L009C: AddEncounter(player, 0x04, 0x0B);
            L00AE: Compare(PartyCount(player), 0x0003);
            L00B9: if (JumpBelowOrEqual) goto L00EE;
            L00BB: AddEncounter(player, 0x05, 0x0A);
            L00CD: AddEncounter(player, 0x06, 0x0A);
            L00DF: goto L00EE;
            L00E1: ShowMessage(player, String1DA1); // Huh!  Dragons.  They weren't so tough after all.
            L00EE: return; // RETURN;
        }

        private void Fn_19(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x02));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00E4;
            L001B: SetFlag(player, 0x03, 0x02, 0x01);
            L0030: ShowMessage(player, String1DD2); // Ghosties and ghoulies and vamps, oh my!
13B5  003D B8 A7 05  mov ax, 0x5a7
            L0040: PushStack(player, ax);
            L0041: PushStack(player, 0x00);
            L0044: PushStack(player, ax);
            L0045: PushStack(player, 0x94);
            L0049: PushStack(player, 0xCD);
            L004D: PushStack(player, 0x55);
13C9  0051 C4 5E 06  les bx, [bp+0x6]
13CC  0054 26 FF 9F D8 00  call far word [es:bx+0xd8]
13D1  0059 83 C4 0C  add sp, 0xc
            L005C: AddEncounter(player, 0x01, 0x1D);
            L006E: AddEncounter(player, 0x02, 0x1E);
            L0080: AddEncounter(player, 0x03, 0x1F);
            L0092: Compare(PartyCount(player), 0x0002);
            L009D: if (JumpBelowOrEqual) goto L00B1;
            L009F: AddEncounter(player, 0x04, 0x1D);
            L00B1: Compare(PartyCount(player), 0x0003);
            L00BC: if (JumpBelowOrEqual) goto L00F1;
            L00BE: AddEncounter(player, 0x05, 0x1E);
            L00D0: AddEncounter(player, 0x06, 0x1F);
            L00E2: goto L00F1;
            L00E4: ShowMessage(player, String1DFA); // You came, you saw, you mashed some ectoplasm!
            L00F1: return; // RETURN;
        }

        private void Fn_1A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x03);
            L0007: PushStack(player, ax);
1473  0008 C4 5E 06  les bx, [bp+0x6]
1476  000B 26 FF 5F 04  call far word [es:bx+0x4]
            L000F: cx = PopStack(player);
            L0010: cx = PopStack(player);
            L0011: RefreshCompareFlags(ax);
            L0013: if (JumpEqual) goto L0018;
            L0015: goto L00F8;
            L0018: PushStack(player, 0x01);
            L001C: PushStack(player, 0x03);
            L0020: PushStack(player, ax);
148C  0021 C4 5E 06  les bx, [bp+0x6]
148F  0024 26 FF 1F  call far word [es:bx]
1492  0027 83 C4 06  add sp, 0x6
            L002A: ShowMessage(player, String1E28); // A bunch of little folks with big aspirations decide that you are just their size.
            L0037: Compare(PartyCount(player), 0x0003);
            L0042: if (JumpBelowOrEqual) goto L0051;
            L0044: ShowMessage(player, String1E7A); // Although there are enough of them that I bet they have you outweighed if not outvolumed.
14BC  0051 B8 47 03  mov ax, 0x347
            L0054: PushStack(player, ax);
            L0055: PushStack(player, 0x00);
            L0058: PushStack(player, ax);
            L0059: PushStack(player, 0xBA);
            L005D: PushStack(player, 0xF2);
            L0061: PushStack(player, 0x54);
14D0  0065 C4 5E 06  les bx, [bp+0x6]
14D3  0068 26 FF 9F D8 00  call far word [es:bx+0xd8]
14D8  006D 83 C4 0C  add sp, 0xc
            L0070: AddEncounter(player, 0x01, 0x1B);
            L0082: AddEncounter(player, 0x02, 0x22);
            L0094: Compare(PartyCount(player), 0x0002);
            L009F: if (JumpBelowOrEqual) goto L00C5;
            L00A1: AddEncounter(player, 0x04, 0x1B);
            L00B3: AddEncounter(player, 0x03, 0x22);
            L00C5: Compare(PartyCount(player), 0x0003);
            L00D0: if (JumpBelowOrEqual) goto L0105;
            L00D2: AddEncounter(player, 0x05, 0x1B);
            L00E4: AddEncounter(player, 0x06, 0x22);
            L00F6: goto L0105;
            L00F8: ShowMessage(player, String1ED3); // The race may not be to the swift, nor the battle to the big, but you showed a bunch of little guys that that was the way to bet!
            L0105: return; // RETURN;
        }

        private void Fn_1B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x04));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00E1;
            L001B: SetFlag(player, 0x03, 0x04, 0x01);
            L0030: ShowMessage(player, String1F54); // Now you know what the sign over the door meant: be on guard against all these imps before they drive you batty!
            L003D: PushStack(player, 0xD4);
            L0041: PushStack(player, 0x00);
            L0044: PushStack(player, ax);
            L0045: PushStack(player, ax);
            L0046: PushStack(player, 0x66);
            L004A: PushStack(player, 0x0A);
15C0  004E C4 5E 06  les bx, [bp+0x6]
15C3  0051 26 FF 9F D8 00  call far word [es:bx+0xd8]
15C8  0056 83 C4 0C  add sp, 0xc
            L0059: AddEncounter(player, 0x01, 0x21);
            L006B: AddEncounter(player, 0x02, 0x21);
            L007D: AddEncounter(player, 0x05, 0x20);
            L008F: Compare(PartyCount(player), 0x0002);
            L009A: if (JumpBelowOrEqual) goto L00C0;
            L009C: AddEncounter(player, 0x03, 0x21);
            L00AE: AddEncounter(player, 0x04, 0x21);
            L00C0: Compare(PartyCount(player), 0x0003);
            L00CB: if (JumpBelowOrEqual) goto L00EE;
            L00CD: AddEncounter(player, 0x06, 0x20);
            L00DF: goto L00EE;
            L00E1: ShowMessage(player, String1FC4); // All that remains of your battle here is a cloven hoof and a forked tongue.
            L00EE: return; // RETURN;
        }

        private void Fn_1C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String200F); // The sign over the door reads: 'The Imperial Guard.'
            L0010: return; // RETURN;
        }

        private void Fn_1D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x05));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00D4;
            L001B: SetFlag(player, 0x03, 0x05, 0x01);
            L0030: ShowMessage(player, String2043); // I guess you do look like an easier target than the dragons, imps, and other nasties that live here.
            L003D: PushStack(player, 0xD4);
            L0041: PushStack(player, 0x00);
            L0044: PushStack(player, ax);
            L0045: PushStack(player, ax);
            L0046: PushStack(player, 0x8B);
            L004A: PushStack(player, 0x45);
16C2  004E C4 5E 06  les bx, [bp+0x6]
16C5  0051 26 FF 9F D8 00  call far word [es:bx+0xd8]
16CA  0056 83 C4 0C  add sp, 0xc
            L0059: AddEncounter(player, 0x01, 0x1A);
            L006B: AddEncounter(player, 0x02, 0x1C);
            L007D: AddEncounter(player, 0x05, 0x23);
            L008F: Compare(PartyCount(player), 0x0003);
            L009A: if (JumpBelowOrEqual) goto L00E1;
            L009C: AddEncounter(player, 0x03, 0x1A);
            L00AE: AddEncounter(player, 0x04, 0x1C);
            L00C0: AddEncounter(player, 0x06, 0x23);
            L00D2: goto L00E1;
            L00D4: ShowMessage(player, String20A7); // You weren't an easier target after all than the dragons, imps, and other nasties that live here.  Heh heh.
            L00E1: return; // RETURN;
        }

        private void Fn_1E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x06));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00E4;
            L001B: SetFlag(player, 0x03, 0x06, 0x01);
            L0030: ShowMessage(player, String2112); // It's a harrying horde of harpies.  And you without your stinger missiles.
1794  003D B8 1C 0C  mov ax, 0xc1c
            L0040: PushStack(player, ax);
            L0041: PushStack(player, 0x00);
            L0044: PushStack(player, ax);
            L0045: PushStack(player, 0xBB);
            L0049: PushStack(player, 0xF4);
            L004D: PushStack(player, 0x80);
17A8  0051 C4 5E 06  les bx, [bp+0x6]
17AB  0054 26 FF 9F D8 00  call far word [es:bx+0xd8]
17B0  0059 83 C4 0C  add sp, 0xc
            L005C: AddEncounter(player, 0x01, 0x25);
            L006E: AddEncounter(player, 0x05, 0x25);
            L0080: Compare(PartyCount(player), 0x0002);
            L008B: if (JumpBelowOrEqual) goto L00B1;
            L008D: AddEncounter(player, 0x02, 0x25);
            L009F: AddEncounter(player, 0x06, 0x25);
            L00B1: Compare(PartyCount(player), 0x0003);
            L00BC: if (JumpBelowOrEqual) goto L00F1;
            L00BE: AddEncounter(player, 0x03, 0x25);
            L00D0: AddEncounter(player, 0x04, 0x25);
            L00E2: goto L00F1;
            L00E4: ShowMessage(player, String215C); // You didn't need late twentieth century technology to defeat those harpies after all.  It's a good thing, too: just inventing a time machine would probably have taken you longer than your lifespan.
            L00F1: return; // RETURN;
        }

        private void Fn_1F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String2221); // The sign over the door reads: 'A Den of Antiquity'
            L0010: return; // RETURN;
        }

        private void Fn_20(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x07));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00F1;
            L001B: SetFlag(player, 0x03, 0x07, 0x01);
            L0030: DamagePlayer(player, 0x07D0);
            L003D: ShowMessage(player, String2254); // When these dragons said they wanted their privacy, they weren't kidding!
18A6  004A B8 6F 06  mov ax, 0x66f
            L004D: PushStack(player, ax);
            L004E: PushStack(player, 0x00);
            L0051: PushStack(player, ax);
            L0052: PushStack(player, 0xCE);
            L0056: PushStack(player, 0xAE);
            L005A: PushStack(player, 0x93);
18BA  005E C4 5E 06  les bx, [bp+0x6]
18BD  0061 26 FF 9F D8 00  call far word [es:bx+0xd8]
18C2  0066 83 C4 0C  add sp, 0xc
            L0069: AddEncounter(player, 0x01, 0x24);
            L007B: AddEncounter(player, 0x02, 0x24);
            L008D: AddEncounter(player, 0x05, 0x24);
            L009F: Compare(PartyCount(player), 0x0002);
            L00AA: if (JumpBelowOrEqual) goto L00D0;
            L00AC: AddEncounter(player, 0x04, 0x24);
            L00BE: AddEncounter(player, 0x03, 0x24);
            L00D0: Compare(PartyCount(player), 0x0003);
            L00DB: if (JumpBelowOrEqual) goto L00FE;
            L00DD: AddEncounter(player, 0x06, 0x24);
            L00EF: goto L00FE;
            L00F1: ShowMessage(player, String229D); // Boy, did you fight a lot of big dragons here!  There are more left wings scattered about than at any hockey game!
            L00FE: return; // RETURN;
        }

        private void Fn_21(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String230F); // The sign over the door reads, 'You better have a good enough reason to die for before you come in here!'
            L0010: return; // RETURN;
        }

        private void Fn_22(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0E5A); // There is a residue of noxious gas leaking from the door to the east.
197E  0010 B8 F4 01  mov ax, 0x1f4
            L0013: PushStack(player, ax);
            L0014: PushStack(player, 0x05);
            L0018: PushStack(player, 0x01);
198A  001C C4 5E 06  les bx, [bp+0x6]
198D  001F 26 FF 9F 9C 00  call far word [es:bx+0x9c]
1992  0024 83 C4 06  add sp, 0x6
            L0027: DamagePlayer(player, 0x01F4);
            L0034: SetFlag(player, 0x03, 0x0E, 0x02);
            L0049: RefreshCompareFlags(GetFlag(player, 0x02, 0x3B));
            L005C: if (JumpNotEqual) goto L0078;
            L005E: SetFlag(player, 0x02, 0x3B, 0x01);
19E1  0073 B8 9F 0E  mov ax, 0xe9f
            L0076: goto L00D4;
            L0078: Compare(GetFlag(player, 0x02, 0x3A), 0x0002);
            L008C: if (JumpNotEqual) goto L00A8;
            L008E: SetFlag(player, 0x03, 0x0D, 0x01);
1A11  00A3 B8 78 23  mov ax, 0x2378
            L00A6: goto L00D4;
            L00A8: SetFlag(player, 0x03, 0x0D, 0x00);
            L00BC: SetFlag(player, 0x02, 0x3A, 0x02);
            L00D1: ShowMessage(player, String0F2B); // You hear a click to the south.
            L00DE: return; // RETURN;
        }

        private void Fn_23(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0E5A); // There is a residue of noxious gas leaking from the door to the east.
1A5E  0010 B8 F4 01  mov ax, 0x1f4
            L0013: PushStack(player, ax);
            L0014: PushStack(player, 0x05);
            L0018: PushStack(player, 0x01);
1A6A  001C C4 5E 06  les bx, [bp+0x6]
1A6D  001F 26 FF 9F 9C 00  call far word [es:bx+0x9c]
1A72  0024 83 C4 06  add sp, 0x6
            L0027: DamagePlayer(player, 0x01F4);
            L0034: SetFlag(player, 0x03, 0x0E, 0x03);
            L0049: RefreshCompareFlags(GetFlag(player, 0x02, 0x3B));
            L005C: if (JumpNotEqual) goto L008D;
            L005E: SetFlag(player, 0x02, 0x3B, 0x01);
            L0073: SetFlag(player, 0x02, 0x3A, 0x01);
1AD6  0088 B8 9F 23  mov ax, 0x239f
            L008B: goto L00E9;
            L008D: Compare(GetFlag(player, 0x02, 0x3A), 0x0003);
            L00A1: if (JumpNotEqual) goto L00BD;
            L00A3: SetFlag(player, 0x03, 0x0D, 0x01);
1B06  00B8 B8 78 23  mov ax, 0x2378
            L00BB: goto L00E9;
            L00BD: SetFlag(player, 0x03, 0x0D, 0x00);
            L00D1: SetFlag(player, 0x02, 0x3A, 0x03);
            L00E6: ShowMessage(player, String1BC2); // You hear a click to the north.
            L00F3: return; // RETURN;
        }

    }
}
