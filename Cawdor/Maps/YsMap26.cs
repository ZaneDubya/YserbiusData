#pragma warning disable
using System.Collections.Generic;
using XPT.WorldData;
using XPT.WorldData.Yserbius;

namespace XPT.Scripts.Yserbius.Maps {
    class YserMap26 : AMapScripted {
        protected override int MapIndex => 26;
        protected override int RandomEncounterChance => 10;
        protected override int RandomEncounterExtraCount => 0;

        public YserMap26() {
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
            MapEvent2E = Fn_2E;
            MapEvent2F = Fn_2F;
            MapEvent30 = Fn_30;
            MapEvent31 = Fn_31;
            MapEvent32 = Fn_32;
        }
        
        // === Strings ================================================
        private const string String0140 = "A cold breeze sends shivers down your spine.";
        private const string String016D = "You've uncovered a hidden door!";
        private const string String018D = "You have unlocked the hidden door!";
        private const string String01B0 = "Your lockpick is no more.  It has ceased to key.  It's a stick.  Bereft of heft, it rests in pieces.  This is an ex-lockpick.";
        private const string String022E = "You detect a hidden door, but it is locked.";
        private const string String025A = "That was a stiff lock, but you finally got it open.";
        private const string String028E = "And what have we here?  You have found the stairs up!";
        private const string String02C4 = "Funny how an irksome little lock on a flimsy little door can keep out a big strong person like you.";
        private const string String0328 = "You find some tracks indicating that something, or someone, headed off to the northeast from here.";
        private const string String038B = "You hear some footsteps running away.";
        private const string String03B1 = "You hear someone running towards you.";
        private const string String03D7 = "The dwarf thief eyes you suspiciously.";
        private const string String03FE = "'Hmm.  I'm not sure I like the likes of thee.  I'll give thee this one word, and just the one: keep thy hooks sharp, an thou intends an ascent.'";
        private const string String048F = "The dragon examines you with a hint of recognition.";
        private const string String04C3 = "'Ah!  Whither hast thou been? I have heard yet another green dragon joke, and my thoughts turned to thee.  Wouldst hear it?'";
        private const string String0540 = "You nod.";
        private const string String0549 = "'How many green dragons does it take to screw in a lightbulb?  Give up?'";
        private const string String0592 = "'None!  Green dragons are too stupid to believe in technology!  Ah, hah!'";
        private const string String05DC = "'Well, it's better than having to fight him,' you think to yourself, 'and he does get a good time out of it.'";
        private const string String064A = "'Ah, my friend!  Look not so worried.  I am sure I will hear or devise another green dragon joke before long!'";
        private const string String06B9 = "It wouldn't do to say this, but the prospect of yet another dragon joke is why you looked so worried.";
        private const string String071F = "A downtrodden halfling knight ambles aimlessly by you.";
        private const string String0756 = "'Serves me right to expect anything cobbled together from horseshoes to bear my weight,' she mutters as she passes.";
        private const string String07CA = "A threatening trio of trolls decides, rather reasonably, that they are bigger than you are.";
        private const string String0826 = "On second thought, they decide that maybe there are more important factors than size.  Their not recognising your armor and weapons has something to do with that.";
        private const string String08C9 = "You return to the Great Hall";
        private const string String08E6 = "This door leads to the Parapets.";
        private const string String0907 = "There is a hole in the ceiling.  It makes you nervous.";
        private const string String093E = "You can now scramble up to the next level.";
        private const string String0969 = "You see a familiar figure.";
        private const string String0984 = "'Welcome to the Nasty Little Maze.  I am considered the nastiest littlest barbarian and have the unpleasant duty of having to give messages to the likes of thee.'";
        private const string String0A27 = "'I have but two words for thee.  The first is that not all is as it appears, especially on the shortest of walls.  And no, that is not a heightist statement.'";
        private const string String0AC6 = "'The second is that skill alone will not enable thee to rise to the occasion.  If thou wouldst soar with eagles, then thou must needs have wings, or something else that will enable thy ascent.'";
        private const string String0B88 = "Much to your astonishment, he winks at you.";
        private const string String0BB4 = "'And I do thank thee again for the return of the doormat,' he whispers.";
        private const string String0BFC = "'I'd thank thee aloud, but ofttimes these interactions are monitored by clairaudience spells.  I dasn't show favoritism, or at least be seen to.'";
        private const string String0C8E = "'I can tell thee that thou wilt need rope to ascend, and thou wilt need to use tools in the Conservatory and Braddock's help in the stables to get rope.'";
        private const string String0D28 = "'But rope alone will not suffice; I can but recommend seeking Braddock's aid and Braddock's items an thou desirest to proceed.'";
        private const string String0DA8 = "'I do believe that aught else thou wilt need for a grappling hook to affix to that rope can be found in the stables.'";
        private const string String0E1E = "'Hmmmm.'";
        private const string String0E27 = "He looks dubiously at your grappling hook.";
        private const string String0E52 = "'I suppose it will bear thy weight.  Still, I think me it could be improved, somehow.  But that is the gnome in me.'";
        private const string String0EC7 = "'Now that is a fine device thou hast there.  I would trust my own weight to it.  May it bring thee success in thy endeavors!'";
        private const string String0F45 = "He leans back, stops whispering, and commands 'Now go away!  I have more important things to do than to hobnob with the likes of thee!'";
        private const string String0FCD = "'Hmm.  I think me thou art well and truly equipped for the rigors that await thee.  How truly unbarbarian of thee.  Now get thee hence!'";
        private const string String1056 = "'There is some troll cleric that has given good advice over in Astrologia, an thou dost find my clues obscure.  But I wager me that hers will be twice as obscure!  Now go away!'";
        private const string String1108 = "Oh, great!  The wall swivelled open and you wound up here.  If I know that ^$%^& game designer, you're going to have to test a lot of walls to get through here.";
        private const string String11A9 = "You use several colorful phrases and the odd splendid gesture.  The phrases I am allowed to repeat include low down, ill plaited, badly woven, good for nothing son of a beech.";
        private const string String1259 = "I assume you meant the beech as in tree as in plant you got the rope from.  If you meant some other kind of a beech, keep it to yourself or we could both get in trouble.";
        private const string String1303 = "Curses notwithstanding, your grappling hook finds no purchase here.  The rocky floors and walls up above are proof against its rather dull points.";
        private const string String1396 = "Well, you could hardly think of a better spot for a wall to swivel open.";
        private const string String13DF = "'Greetings, greetings!'  Rory's grip is strong and his smile friendly.  'I have finished cataloging some of the more esoteric effects of items, and will gladly share them with thee.'";
        private const string String1496 = "'Although these items have great potency when used for their spells, they also vastly enhance the damage done with a weapon against their purposed opponents.'";
        private const string String1535 = "'The Fillet of a Fenny Snake, Eye of Newt, Toe of Frog, Adder Fork, Blindworm Sting, Lizard Leg, and Howlet Wing, as well as the Scale of Dragon, affect Dragons.'";
        private const string String15D8 = "'The Wool of Bat, Tongue of Dog, Tooth of Wolf, and Gall of Goat affect Mammals.  But I am not sure that all of the above get recognised as mammals.  My researches are not complete, for which I apologise.'";
        private const string String16A6 = "'I recommend that when thou knowest thy foe, mayhaps as in The Aerie or The Attic, then have thy fighters equip these items instead of rings.  He who slays first slays best, eh?'";
        private const string String1759 = "A sooty smokey orc knight greets you.";
        private const string String177F = "'Zwounds!  Good gentle, fear for thy life, an thou dost assay this door without something that grants mastery of wyrms, something from their head, that doth break their spirit.  For they are numerous within, and doughty.'";
        private const string String185D = "That knight wasn't kidding.  Wyrms ahoy!";
        private const string String1886 = "It appears you have totally dewyrmed this area.";
        private const string String18B6 = "I'm afraid you needed the other wyrm mastery item that came from a dragon's head.";
        private const string String1908 = "There were reasons why that orc was draggin' his body away from here.  With that armor on, he was going to become one smoked sausage to these wyrms!";
        private const string String199D = "A badly bruised dwarf knight greets you.";
        private const string String19C6 = "'By all the winds and zephyrs!  The dragons that nest in here are too tough for me to fight until I find something that will tame the winds they raise with their wings!'";
        private const string String1A70 = "Well, blow me down!  And that's just what these dragons are going to try to do!";
        private const string String1AC0 = "This area is still.  Quiet.  Almost too quiet.";
        private const string String1AEF = "These dragons sure treated that dwarf like some kind of fly by knight operation.  I bet you can prove that you're rather more substantial.  Attack!";
        private const string String1B83 = "A badly battered barbarian greets you.";
        private const string String1BAA = "'By my femurs and patellae!  Thou dost not wish to pass this door unless thou hast some defense against the fiercesome kicks of the wyrms within.  I can say that they really kicked my, uh, well, mayhaps I cannot say'";
        private const string String1C83 = "Ye gods!  These dragons are having a soccer match, and they've cast you as the ball.  Beware!";
        private const string String1CE1 = "Naw, it's not too quiet, I'm just messing with your mind.  Believe me, too quiet is far far better than the alternative: too noisy.";
        private const string String1D65 = "Boy, do I ever get a kick from saying that!";
        private const string String1D91 = "You might call this coroner's corner, because all these undead have you cornered!";
        private const string String1DE3 = "This corner is still.  Quiet.  Quiet as the grave.";
        private const string String1E16 = "Okay, it's moderately loud, but well insulated.";
        private const string String1E46 = "All these spellcasters spell trouble for you, with a capital rouble!";
        private const string String1E8B = "Or maybe they spell trouble M-E-D-U-S-A-E!";
        private const string String1EB6 = "The spellcasters you met here were casting you as the targets, but now it's a pleasant enough spot to cast aside your worries.";
        private const string String1F35 = "Of course, that concept isn't cast in iron!";
        private const string String1F61 = "Good thing you were moving cautiously, because this was one heck of a fine spot for an ambush!";
        private const string String1FC0 = "Did you know that in Alchemia and Astrologia, if you have the right connections, you can get potions that will remove your enemy's mana?  Here!  Let me show you what I mean!";
        private const string String206E = "How did those guys get the right connections?  Well they bribed (Hork) certain (Hork) people (Hork) with lots and lots of chocolate.  Fortunately for you, Dinky is unbribeable.";
        private const string String211F = "All that remains of your battle here is a chocolate bar wrapper.";
        private const string String2160 = "Like I said, it's a REALLY good thing for you that Dinky is unbribeable, at least until you can figure out how to get chocolate into cyberspace.";
        private const string String21F1 = "On the other hand, his wife is eminently bribeable and she can browbeat him into doing almost anything (hint hint).";
        private const string String2265 = "Unfortunately, after just two steps the stairwell has collapsed in a big pile of rubble.";
        
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
0044  0036 C4 5E 06  les bx, [bp+0x6]
0047  0039 26 FF 5F 54  call far word [es:bx+0x54]
            L003D: cx = PopStack(player);
            L003E: cx = PopStack(player);
            L003F: RefreshCompareFlags(ax);
            L0041: if (JumpNotEqual) goto L008D;
            L0043: PushStack(player, 0x61);
            L0047: PushStack(player, ax);
0056  0048 C4 5E 06  les bx, [bp+0x6]
0059  004B 26 FF 5F 54  call far word [es:bx+0x54]
            L004F: cx = PopStack(player);
            L0050: cx = PopStack(player);
            L0051: RefreshCompareFlags(ax);
            L0053: if (JumpNotEqual) goto L008D;
            L0055: PushStack(player, 0x93);
            L0059: PushStack(player, ax);
0068  005A C4 5E 06  les bx, [bp+0x6]
006B  005D 26 FF 5F 54  call far word [es:bx+0x54]
            L0061: cx = PopStack(player);
            L0062: cx = PopStack(player);
            L0063: RefreshCompareFlags(ax);
            L0065: if (JumpNotEqual) goto L008D;
            L0067: PushStack(player, 0x86);
            L006B: PushStack(player, ax);
007A  006C C4 5E 06  les bx, [bp+0x6]
007D  006F 26 FF 5F 54  call far word [es:bx+0x54]
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
00DA  00CC C4 5E 06  les bx, [bp+0x6]
00DD  00CF 26 FF 5F 2C  call far word [es:bx+0x2c]
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
0148  0029 C4 5E 06  les bx, [bp+0x6]
014B  002C 26 FF 5F 54  call far word [es:bx+0x54]
            L0030: cx = PopStack(player);
            L0031: cx = PopStack(player);
            L0032: RefreshCompareFlags(ax);
            L0034: if (JumpNotEqual) goto L0083;
            L0036: PushStack(player, 0x61);
            L003A: PushStack(player, ax);
015A  003B C4 5E 06  les bx, [bp+0x6]
015D  003E 26 FF 5F 54  call far word [es:bx+0x54]
            L0042: cx = PopStack(player);
            L0043: cx = PopStack(player);
            L0044: RefreshCompareFlags(ax);
            L0046: if (JumpNotEqual) goto L0083;
            L0048: PushStack(player, 0x93);
            L004C: PushStack(player, ax);
016C  004D C4 5E 06  les bx, [bp+0x6]
016F  0050 26 FF 5F 54  call far word [es:bx+0x54]
            L0054: cx = PopStack(player);
            L0055: cx = PopStack(player);
            L0056: RefreshCompareFlags(ax);
            L0058: if (JumpNotEqual) goto L0083;
            L005A: PushStack(player, 0x86);
            L005E: PushStack(player, ax);
017E  005F C4 5E 06  les bx, [bp+0x6]
0181  0062 26 FF 5F 54  call far word [es:bx+0x54]
            L0066: cx = PopStack(player);
            L0067: cx = PopStack(player);
            L0068: RefreshCompareFlags(ax);
            L006A: if (JumpNotEqual) goto L0083;
            L006C: ax = IsFlagOn(player, 0x00, 0x01);
            L007E: if (JumpNotEqual) goto L0083;
            L0080: goto L01C0;
            L0083: SetWallObject(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L00A1: PushStack(player, 0x01);
            L00A5: PushStack(player, ax);
            L00A6: PushStack(player, 0x00);
01C8  00A9 C4 5E 06  les bx, [bp+0x6]
01CB  00AC 26 FF 1F  call far word [es:bx]
01CE  00AF 83 C4 06  add sp, 0x6
            L00B2: PushStack(player, 0x68);
            L00B6: PushStack(player, ax);
01D6  00B7 C4 5E 06  les bx, [bp+0x6]
01D9  00BA 26 FF 5F 54  call far word [es:bx+0x54]
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
022E  010F C4 5E 06  les bx, [bp+0x6]
0231  0112 26 FF 5F 54  call far word [es:bx+0x54]
            L0116: cx = PopStack(player);
            L0117: cx = PopStack(player);
            L0118: RefreshCompareFlags(ax);
            L011A: if (JumpEqual) goto L012F;
            L011C: ShowMessage(player, String018D); // You have unlocked the hidden door!
0248  0129 B8 01 00  mov ax, 0x1
            L012C: goto L01C2;
            L012F: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L014C: ax = HasUsedItem(player, 0xC1, 0xC3);
            L015F: if (JumpEqual) goto L0194;
            L0161: RemoveItem(player, 0xC1);
            L016D: RemoveItem(player, 0xC2);
            L0179: RemoveItem(player, 0xC3);
            L0185: ShowMessage(player, String01B0); // Your lockpick is no more.  It has ceased to key.  It's a stick.  Bereft of heft, it rests in pieces.  This is an ex-lockpick.
            L0192: goto L01DD;
            L0194: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L01B1: ShowMessage(player, String022E); // You detect a hidden door, but it is locked.
            L01BE: goto L01DD;
            L01C0: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L01DD: return; // RETURN;
        }

        private void Fn_03(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x68);
            L0007: PushStack(player, ax);
0306  0008 C4 5E 06  les bx, [bp+0x6]
0309  000B 26 FF 5F 54  call far word [es:bx+0x54]
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
0369  006B C4 5E 06  les bx, [bp+0x6]
036C  006E 26 FF 5F 54  call far word [es:bx+0x54]
            L0072: cx = PopStack(player);
            L0073: cx = PopStack(player);
            L0074: RefreshCompareFlags(ax);
            L0076: if (JumpNotEqual) goto L009F;
            L0078: ax = HasUsedItem(player, 0xDA, 0xDD);
            L008B: if (JumpNotEqual) goto L009F;
            L008D: PushStack(player, 0xC0);
            L0091: PushStack(player, ax);
0390  0092 C4 5E 06  les bx, [bp+0x6]
0393  0095 26 FF 5F 54  call far word [es:bx+0x54]
            L0099: cx = PopStack(player);
            L009A: cx = PopStack(player);
            L009B: RefreshCompareFlags(ax);
            L009D: if (JumpEqual) goto L00DA;
            L009F: ShowMessage(player, String025A); // That was a stiff lock, but you finally got it open.
            L00AC: ShowMessage(player, String028E); // And what have we here?  You have found the stairs up!
            L00B9: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L00D7: goto L015F;
            L00DA: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L00F7: ax = HasUsedItem(player, 0xC1, 0xC3);
            L010A: if (JumpEqual) goto L0135;
            L010C: RemoveItem(player, 0xC1);
            L0118: RemoveItem(player, 0xC2);
            L0124: RemoveItem(player, 0xC3);
042E  0130 B8 B0 01  mov ax, 0x1b0
            L0133: goto L0155;
            L0135: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0152: ShowMessage(player, String02C4); // Funny how an irksome little lock on a flimsy little door can keep out a big strong person like you.
            L015F: return; // RETURN;
        }

        private void Fn_04(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, 0x0B), 0x0009);
            L0012: if (JumpNotBelow) goto L0038;
            L0014: PushStack(player, 0x62);
            L0018: PushStack(player, ax);
0478  0019 C4 5E 06  les bx, [bp+0x6]
047B  001C 26 FF 5F 54  call far word [es:bx+0x54]
            L0020: cx = PopStack(player);
            L0021: cx = PopStack(player);
            L0022: RefreshCompareFlags(ax);
            L0024: if (JumpNotEqual) goto L0038;
            L0026: PushStack(player, 0x8F);
            L002A: PushStack(player, ax);
048A  002B C4 5E 06  les bx, [bp+0x6]
048D  002E 26 FF 5F 54  call far word [es:bx+0x54]
            L0032: cx = PopStack(player);
            L0033: cx = PopStack(player);
            L0034: RefreshCompareFlags(ax);
            L0036: if (JumpEqual) goto L005A;
            L0038: ShowMessage(player, String0328); // You find some tracks indicating that something, or someone, headed off to the northeast from here.
            L0045: SetFlag(player, 0x03, 0x09, 0x01);
            L005A: return; // RETURN;
        }

        private void Fn_05(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si, di);
            L0005: di = 0;
            L0007: si = 0;
            L0009: ax = GetFlag(player, 0x02, 0x53);
04D5  001A 8B F8  mov di, ax
04D7  001C 47     inc di
04D8  001D 8B F7  mov si, di
            L001F: Compare(si, 0x13);
            L0022: if (JumpLessOrEqual) goto L002B;
04DF  0024 8B C6  mov ax, si
            L0026: si = ax + 0xFFEC;
            L002B: Compare(si, 0x0E);
            L002E: if (JumpLessOrEqual) goto L0037;
04EB  0030 8B C6  mov ax, si
            L0032: si = ax + 0xFFF1;
            L0037: Compare(si, 0x09);
            L003A: if (JumpLessOrEqual) goto L0043;
04F7  003C 8B C6  mov ax, si
            L003E: si = ax + 0xFFF6;
            L0043: Compare(si, 0x04);
            L0046: if (JumpLessOrEqual) goto L004F;
0503  0048 8B C6  mov ax, si
            L004A: si = ax + 0xFFFB;
050A  004F 0B F6  or si, si
050C  0051 7D 02  jge 0x55
            L0053: si = 0;
            L0055: Compare(si, 0x1D);
            L0058: if (JumpLessOrEqual) goto L005C;
            L005A: si = 0;
0517  005C 83 FF 1E  cmp di, 0x1e
            L005F: if (JumpLessOrEqual) goto L0063;
            L0061: di = 0;
051E  0063 57     push di
            L0064: PushStack(player, 0x53);
            L0068: PushStack(player, 0x02);
0527  006C C4 5E 06  les bx, [bp+0x6]
052A  006F 26 FF 1F  call far word [es:bx]
052D  0072 83 C4 06  add sp, 0x6
0530  0075 83 FF 1A  cmp di, 0x1a
            L0078: if (JumpNotEqual) goto L007F;
0535  007A B8 01 00  mov ax, 0x1
            L007D: goto L0081;
            L007F: PushStack(player, 0x00);
053D  0082 83 FF 14  cmp di, 0x14
            L0085: if (JumpNotEqual) goto L008C;
0542  0087 B8 01 00  mov ax, 0x1
            L008A: goto L008E;
0547  008C 33 C0  xor ax, ax
            L008E: dx = PopStack(player);
054A  008F 0B D0  or dx, ax
            L0091: PushStack(player, dx);
054D  0092 83 FF 0E  cmp di, 0xe
            L0095: if (JumpNotEqual) goto L009C;
0552  0097 B8 01 00  mov ax, 0x1
            L009A: goto L009E;
0557  009C 33 C0  xor ax, ax
            L009E: dx = PopStack(player);
055A  009F 0B D0  or dx, ax
            L00A1: PushStack(player, dx);
055D  00A2 83 FF 08  cmp di, 0x8
            L00A5: if (JumpNotEqual) goto L00AC;
0562  00A7 B8 01 00  mov ax, 0x1
            L00AA: goto L00AE;
0567  00AC 33 C0  xor ax, ax
            L00AE: dx = PopStack(player);
056A  00AF 0B D0  or dx, ax
            L00B1: PushStack(player, dx);
056D  00B2 83 FF 02  cmp di, 0x2
            L00B5: if (JumpNotEqual) goto L00BC;
0572  00B7 B8 01 00  mov ax, 0x1
            L00BA: goto L00BE;
0577  00BC 33 C0  xor ax, ax
            L00BE: dx = PopStack(player);
057A  00BF 0B D0  or dx, ax
            L00C1: if (JumpNotEqual) goto L00C6;
            L00C3: goto L01F6;
            L00C6: bx = si;
            L00C8: Compare(bx, 0x04);
            L00CB: if (JumpBelowOrEqual) goto L00D0;
            L00CD: goto L01F6;
            L00D0: switch (bx) {
                case 0:
                    goto L00D7;
                case 1:
                    goto L00DD;
                case 2:
                    goto L010A;
                case 3:
                    goto L01B0;
                case 4:
                    goto L01CF;
            }
0592  00D7 B8 8B 03  mov ax, 0x38b
            L00DA: goto L01EC;
            L00DD: ShowMessage(player, String03B1); // You hear someone running towards you.
            L00EA: ShowPortrait(player, 0x0023);
            L00F7: ShowMessage(player, String03D7); // The dwarf thief eyes you suspiciously.
05BF  0104 B8 FE 03  mov ax, 0x3fe
            L0107: goto L01EC;
            L010A: ShowPortrait(player, 0x000E);
            L0117: RefreshCompareFlags(GetFlag(player, 0x02, 0x55));
            L012A: if (JumpNotEqual) goto L019E;
            L012C: ShowMessage(player, String048F); // The dragon examines you with a hint of recognition.
            L0139: ShowMessage(player, String04C3); // 'Ah!  Whither hast thou been? I have heard yet another green dragon joke, and my thoughts turned to thee.  Wouldst hear it?'
            L0146: ShowMessage(player, String0540); // You nod.
            L0153: ShowMessage(player, String0549); // 'How many green dragons does it take to screw in a lightbulb?  Give up?'
            L0160: ShowMessage(player, String0540); // You nod.
            L016D: ShowMessage(player, String0592); // 'None!  Green dragons are too stupid to believe in technology!  Ah, hah!'
            L017A: ShowMessage(player, String05DC); // 'Well, it's better than having to fight him,' you think to yourself, 'and he does get a good time out of it.'
            L0187: SetFlag(player, 0x02, 0x55, 0x01);
            L019C: goto L01F6;
            L019E: ShowMessage(player, String064A); // 'Ah, my friend!  Look not so worried.  I am sure I will hear or devise another green dragon joke before long!'
0666  01AB B8 B9 06  mov ax, 0x6b9
            L01AE: goto L01EC;
            L01B0: ShowPortrait(player, 0x001D);
            L01BD: ShowMessage(player, String071F); // A downtrodden halfling knight ambles aimlessly by you.
0685  01CA B8 56 07  mov ax, 0x756
            L01CD: goto L01EC;
            L01CF: ShowPortrait(player, 0x001B);
            L01DC: ShowMessage(player, String07CA); // A threatening trio of trolls decides, rather reasonably, that they are bigger than you are.
            L01E9: ShowMessage(player, String0826); // On second thought, they decide that maybe there are more important factors than size.  Their not recognising your armor and weapons has something to do with that.
            L01F6: return; // RETURN (restoring si, di);
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
            L0003: ShowMessage(player, String08C9); // You return to the Great Hall
            L0010: TeleportParty(player, 0x08, 0x02, 0x60, 0x02, isForwardMove);
            L002B: return; // RETURN;
        }

        private void Fn_08(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String08E6); // This door leads to the Parapets.
            L0010: TeleportParty(player, 0x0B, 0x02, 0xFB, 0x03, isForwardMove);
            L002B: return; // RETURN;
        }

        private void Fn_09(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x02);
            L0007: PushStack(player, 0x00);
0735  000A C4 5E 06  les bx, [bp+0x6]
0738  000D 26 FF 5F 04  call far word [es:bx+0x4]
            L0011: cx = PopStack(player);
            L0012: cx = PopStack(player);
            L0013: Compare(ax, 0x0001);
            L0016: if (JumpNotEqual) goto L0051;
            L0018: PushStack(player, 0x00);
            L001B: PushStack(player, 0x02);
            L001F: PushStack(player, 0x00);
074D  0022 C4 5E 06  les bx, [bp+0x6]
0750  0025 26 FF 1F  call far word [es:bx]
0753  0028 83 C4 06  add sp, 0x6
            L002B: TeleportParty(player, 0x0B, 0x04, GetCurrentTile(player), GetFacing(player), isForwardMove);
            L004E: goto L00DA;
            L0051: PushStack(player, 0x03);
            L0055: PushStack(player, 0x00);
0783  0058 C4 5E 06  les bx, [bp+0x6]
0786  005B 26 FF 5F 04  call far word [es:bx+0x4]
            L005F: cx = PopStack(player);
            L0060: cx = PopStack(player);
            L0061: RefreshCompareFlags(ax);
            L0063: if (JumpNotEqual) goto L0086;
            L0065: ShowMessage(player, String0907); // There is a hole in the ceiling.  It makes you nervous.
            L0072: SetFlag(player, 0x00, 0x03, 0x01);
            L0086: ax = HasUsedItem(player, 0xD3, 0xD4);
            L0099: if (JumpEqual) goto L00DA;
            L009B: SetWallObject(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L00B9: ShowMessage(player, String093E); // You can now scramble up to the next level.
            L00C6: SetFlag(player, 0x00, 0x02, 0x01);
            L00DA: return; // RETURN;
        }

        private void Fn_0A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x0A));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L01BE;
            L001B: ShowPortrait(player, 0x0019);
            L0028: ShowMessage(player, String0969); // You see a familiar figure.
            L0035: ShowMessage(player, String0984); // 'Welcome to the Nasty Little Maze.  I am considered the nastiest littlest barbarian and have the unpleasant duty of having to give messages to the likes of thee.'
            L0042: ShowMessage(player, String0A27); // 'I have but two words for thee.  The first is that not all is as it appears, especially on the shortest of walls.  And no, that is not a heightist statement.'
            L004F: ShowMessage(player, String0AC6); // 'The second is that skill alone will not enable thee to rise to the occasion.  If thou wouldst soar with eagles, then thou must needs have wings, or something else that will enable thy ascent.'
            L005C: Compare(GetFlag(player, 0x02, 0x07), 0x0001);
            L0070: if (JumpEqual) goto L0075;
            L0072: goto L019C;
            L0075: ShowMessage(player, String0B88); // Much to your astonishment, he winks at you.
            L0082: ShowMessage(player, String0BB4); // 'And I do thank thee again for the return of the doormat,' he whispers.
            L008F: ShowMessage(player, String0BFC); // 'I'd thank thee aloud, but ofttimes these interactions are monitored by clairaudience spells.  I dasn't show favoritism, or at least be seen to.'
            L009C: ax = HasItem(player, 0xD5);
            L00AA: if (JumpNotEqual) goto L00F6;
            L00AC: ax = HasItem(player, 0xE0);
            L00BA: if (JumpNotEqual) goto L00F6;
            L00BC: ax = HasItem(player, 0xD3);
            L00CA: if (JumpNotEqual) goto L00F6;
            L00CC: ax = HasItem(player, 0xD4);
            L00DA: if (JumpNotEqual) goto L00F6;
            L00DC: ShowMessage(player, String0C8E); // 'I can tell thee that thou wilt need rope to ascend, and thou wilt need to use tools in the Conservatory and Braddock's help in the stables to get rope.'
            L00E9: ShowMessage(player, String0D28); // 'But rope alone will not suffice; I can but recommend seeking Braddock's aid and Braddock's items an thou desirest to proceed.'
            L00F6: ax = HasItem(player, 0xE0);
            L0104: if (JumpEqual) goto L0133;
            L0106: ax = HasItem(player, 0xD3);
            L0114: if (JumpNotEqual) goto L0133;
            L0116: ax = HasItem(player, 0xD4);
            L0124: if (JumpNotEqual) goto L0133;
            L0126: ShowMessage(player, String0DA8); // 'I do believe that aught else thou wilt need for a grappling hook to affix to that rope can be found in the stables.'
            L0133: ax = HasItem(player, 0xD3);
            L0141: if (JumpEqual) goto L017A;
            L0143: ax = HasItem(player, 0xD4);
            L0151: if (JumpNotEqual) goto L017A;
            L0153: ShowMessage(player, String0E1E); // 'Hmmmm.'
            L0160: ShowMessage(player, String0E27); // He looks dubiously at your grappling hook.
            L016D: ShowMessage(player, String0E52); // 'I suppose it will bear thy weight.  Still, I think me it could be improved, somehow.  But that is the gnome in me.'
            L017A: ax = HasItem(player, 0xD4);
            L0188: if (JumpEqual) goto L0197;
            L018A: ShowMessage(player, String0EC7); // 'Now that is a fine device thou hast there.  I would trust my own weight to it.  May it bring thee success in thy endeavors!'
099E  0197 B8 45 0F  mov ax, 0xf45
            L019A: goto L01B4;
            L019C: ax = HasItem(player, 0xD4);
            L01AA: if (JumpEqual) goto L01B1;
09B3  01AC B8 CD 0F  mov ax, 0xfcd
            L01AF: goto L01B4;
            L01B1: ShowMessage(player, String1056); // 'There is some troll cleric that has given good advice over in Astrologia, an thou dost find my clues obscure.  But I wager me that hers will be twice as obscure!  Now go away!'
            L01BE: return; // RETURN;
        }

        private void Fn_0B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x0B, 0x01, 0x4D, 0x01, isForwardMove);
            L001E: return; // RETURN;
        }

        private void Fn_0C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x0B));
            L0016: if (JumpNotEqual) goto L003A;
            L0018: SetFlag(player, 0x03, 0x0B, 0x01);
            L002D: ShowMessage(player, String1108); // Oh, great!  The wall swivelled open and you wound up here.  If I know that ^$%^& game designer, you're going to have to test a lot of walls to get through here.
            L003A: return; // RETURN;
        }

        private void Fn_0D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x02);
            L0007: PushStack(player, 0x00);
0A2D  000A C4 5E 06  les bx, [bp+0x6]
0A30  000D 26 FF 5F 04  call far word [es:bx+0x4]
            L0011: cx = PopStack(player);
            L0012: cx = PopStack(player);
            L0013: Compare(ax, 0x0001);
            L0016: if (JumpNotEqual) goto L0051;
            L0018: PushStack(player, 0x00);
            L001B: PushStack(player, 0x02);
            L001F: PushStack(player, 0x00);
0A45  0022 C4 5E 06  les bx, [bp+0x6]
0A48  0025 26 FF 1F  call far word [es:bx]
0A4B  0028 83 C4 06  add sp, 0x6
            L002B: TeleportParty(player, 0x0B, 0x04, GetCurrentTile(player), GetFacing(player), isForwardMove);
            L004E: goto L0113;
            L0051: PushStack(player, 0xD3);
            L0055: PushStack(player, ax);
0A79  0056 C4 5E 06  les bx, [bp+0x6]
0A7C  0059 26 FF 5F 54  call far word [es:bx+0x54]
            L005D: cx = PopStack(player);
            L005E: cx = PopStack(player);
            L005F: RefreshCompareFlags(ax);
            L0061: if (JumpEqual) goto L008D;
            L0063: ShowMessage(player, String11A9); // You use several colorful phrases and the odd splendid gesture.  The phrases I am allowed to repeat include low down, ill plaited, badly woven, good for nothing son of a beech.
            L0070: ShowMessage(player, String1259); // I assume you meant the beech as in tree as in plant you got the rope from.  If you meant some other kind of a beech, keep it to yourself or we could both get in trouble.
            L007D: ShowMessage(player, String1303); // Curses notwithstanding, your grappling hook finds no purchase here.  The rocky floors and walls up above are proof against its rather dull points.
            L008A: goto L0113;
            L008D: PushStack(player, 0x03);
            L0091: PushStack(player, 0x00);
0AB7  0094 C4 5E 06  les bx, [bp+0x6]
0ABA  0097 26 FF 5F 04  call far word [es:bx+0x4]
            L009B: cx = PopStack(player);
            L009C: cx = PopStack(player);
            L009D: RefreshCompareFlags(ax);
            L009F: if (JumpNotEqual) goto L00C2;
            L00A1: ShowMessage(player, String0907); // There is a hole in the ceiling.  It makes you nervous.
            L00AE: SetFlag(player, 0x00, 0x03, 0x01);
            L00C2: PushStack(player, 0xD4);
            L00C6: PushStack(player, ax);
0AEA  00C7 C4 5E 06  les bx, [bp+0x6]
0AED  00CA 26 FF 5F 54  call far word [es:bx+0x54]
            L00CE: cx = PopStack(player);
            L00CF: cx = PopStack(player);
            L00D0: RefreshCompareFlags(ax);
            L00D2: if (JumpEqual) goto L0113;
            L00D4: SetWallObject(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L00F2: ShowMessage(player, String093E); // You can now scramble up to the next level.
            L00FF: SetFlag(player, 0x00, 0x02, 0x01);
            L0113: return; // RETURN;
        }

        private void Fn_0E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x0B, 0x01, 0x4C, 0x00, isForwardMove);
            L001D: return; // RETURN;
        }

        private void Fn_0F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x0C));
            L0016: if (JumpNotEqual) goto L003A;
            L0018: SetFlag(player, 0x03, 0x0C, 0x01);
            L002D: ShowMessage(player, String1396); // Well, you could hardly think of a better spot for a wall to swivel open.
            L003A: return; // RETURN;
        }

        private void Fn_10(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x0B, 0x01, 0xCB, 0x03, isForwardMove);
            L001E: return; // RETURN;
        }

        private void Fn_11(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x0B, 0x01, 0x9B, 0x03, isForwardMove);
            L001E: return; // RETURN;
        }

        private void Fn_12(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x0B, 0x01, 0xA7, 0x03, isForwardMove);
            L001E: return; // RETURN;
        }

        private void Fn_13(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x0B, 0x01, 0x24, 0x01, isForwardMove);
            L001E: return; // RETURN;
        }

        private void Fn_14(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x0B, 0x01, 0x7B, 0x02, isForwardMove);
            L001E: return; // RETURN;
        }

        private void Fn_15(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x0B, 0x01, 0x4B, 0x00, isForwardMove);
            L001D: return; // RETURN;
        }

        private void Fn_16(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x0B, 0x01, 0x70, 0x03, isForwardMove);
            L001E: return; // RETURN;
        }

        private void Fn_17(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x02, 0x47));
            L0016: if (JumpNotEqual) goto L0090;
            L0018: RefreshCompareFlags(GetFlag(player, 0x03, 0x0D));
            L002B: if (JumpNotEqual) goto L0090;
            L002D: ShowPortrait(player, 0x0025);
            L003A: SetFlag(player, 0x03, 0x0D, 0x01);
            L004F: ShowMessage(player, String13DF); // 'Greetings, greetings!'  Rory's grip is strong and his smile friendly.  'I have finished cataloging some of the more esoteric effects of items, and will gladly share them with thee.'
            L005C: ShowMessage(player, String1496); // 'Although these items have great potency when used for their spells, they also vastly enhance the damage done with a weapon against their purposed opponents.'
            L0069: ShowMessage(player, String1535); // 'The Fillet of a Fenny Snake, Eye of Newt, Toe of Frog, Adder Fork, Blindworm Sting, Lizard Leg, and Howlet Wing, as well as the Scale of Dragon, affect Dragons.'
            L0076: ShowMessage(player, String15D8); // 'The Wool of Bat, Tongue of Dog, Tooth of Wolf, and Gall of Goat affect Mammals.  But I am not sure that all of the above get recognised as mammals.  My researches are not complete, for which I apologise.'
            L0083: ShowMessage(player, String16A6); // 'I recommend that when thou knowest thy foe, mayhaps as in The Aerie or The Attic, then have thy fighters equip these items instead of rings.  He who slays first slays best, eh?'
            L0090: return; // RETURN;
        }

        private void Fn_18(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x0E));
            L0016: if (JumpEqual) goto L002D;
            L0018: RefreshCompareFlags(GetFlag(player, 0x03, 0x0F));
            L002B: if (JumpNotEqual) goto L007E;
            L002D: Compare(GetCurrentTile(player), 0x00D1);
            L0037: if (JumpNotEqual) goto L0042;
            L0039: PushStack(player, 0x01);
0D41  003D B8 0E 00  mov ax, 0xe
            L0040: goto L0049;
            L0042: SetFlag(player, 0x03, 0x0F, 0x01);
            L0057: ShowPortrait(player, 0x001A);
            L0064: ShowMessage(player, String1759); // A sooty smokey orc knight greets you.
            L0071: ShowMessage(player, String177F); // 'Zwounds!  Good gentle, fear for thy life, an thou dost assay this door without something that grants mastery of wyrms, something from their head, that doth break their spirit.  For they are numerous within, and doughty.'
            L007E: return; // RETURN;
        }

        private void Fn_19(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0xF4);
            L0011: if (JumpEqual) goto L001C;
            L0013: PushStack(player, 0x01);
0D9B  0017 B8 E0 00  mov ax, 0xe0
            L001A: goto L0023;
            L001C: TeleportParty(player, 0x0B, 0x01, 0xF0, 0x01, isForwardMove);
            L0037: return; // RETURN;
        }

        private void Fn_1A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0xF0);
            L0011: if (JumpEqual) goto L001C;
            L0013: PushStack(player, 0x01);
0DD4  0017 B8 E0 00  mov ax, 0xe0
            L001A: goto L0023;
            L001C: TeleportParty(player, 0x0B, 0x01, 0xF0, 0x01, isForwardMove);
            L0037: return; // RETURN;
        }

        private void Fn_1B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x01));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00AD;
            L001B: PushStack(player, 0x01);
            L001F: PushStack(player, ax);
            L0020: PushStack(player, 0x03);
0E1A  0024 C4 5E 06  les bx, [bp+0x6]
0E1D  0027 26 FF 1F  call far word [es:bx]
0E20  002A 83 C4 06  add sp, 0x6
            L002D: ShowMessage(player, String185D); // That knight wasn't kidding.  Wyrms ahoy!
0E30  003A B8 EA 2E  mov ax, 0x2eea
            L003D: PushStack(player, ax);
            L003E: PushStack(player, 0x00);
            L0041: PushStack(player, ax);
            L0042: PushStack(player, ax);
            L0043: PushStack(player, 0xBB);
            L0047: PushStack(player, 0xDD);
0E41  004B C4 5E 06  les bx, [bp+0x6]
0E44  004E 26 FF 9F D8 00  call far word [es:bx+0xd8]
0E49  0053 83 C4 0C  add sp, 0xc
            L0056: AddEncounter(player, 0x01, 0x27);
            L0068: AddEncounter(player, 0x05, 0x27);
            L007A: Compare(PartyCount(player), 0x0002);
            L0085: if (JumpBelowOrEqual) goto L00BA;
            L0087: AddEncounter(player, 0x02, 0x27);
            L0099: AddEncounter(player, 0x06, 0x27);
            L00AB: goto L00BA;
            L00AD: ShowMessage(player, String1886); // It appears you have totally dewyrmed this area.
            L00BA: return; // RETURN;
        }

        private void Fn_1C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x01));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00CA;
            L001B: ax = HasItem(player, 0xF0);
            L0029: if (JumpEqual) goto L0038;
            L002B: ShowMessage(player, String18B6); // I'm afraid you needed the other wyrm mastery item that came from a dragon's head.
            L0038: PushStack(player, 0x01);
            L003C: PushStack(player, ax);
            L003D: PushStack(player, 0x03);
0EF3  0041 C4 5E 06  les bx, [bp+0x6]
0EF6  0044 26 FF 1F  call far word [es:bx]
0EF9  0047 83 C4 06  add sp, 0x6
            L004A: ShowMessage(player, String185D); // That knight wasn't kidding.  Wyrms ahoy!
0F09  0057 B8 EA 2E  mov ax, 0x2eea
            L005A: PushStack(player, ax);
            L005B: PushStack(player, 0x00);
            L005E: PushStack(player, ax);
            L005F: PushStack(player, ax);
            L0060: PushStack(player, 0xBB);
            L0064: PushStack(player, 0xDD);
0F1A  0068 C4 5E 06  les bx, [bp+0x6]
0F1D  006B 26 FF 9F D8 00  call far word [es:bx+0xd8]
0F22  0070 83 C4 0C  add sp, 0xc
            L0073: AddEncounter(player, 0x01, 0x28);
            L0085: AddEncounter(player, 0x05, 0x28);
            L0097: Compare(PartyCount(player), 0x0002);
            L00A2: if (JumpBelowOrEqual) goto L00D7;
            L00A4: AddEncounter(player, 0x02, 0x28);
            L00B6: AddEncounter(player, 0x06, 0x28);
            L00C8: goto L00D7;
            L00CA: ShowMessage(player, String1886); // It appears you have totally dewyrmed this area.
            L00D7: return; // RETURN;
        }

        private void Fn_1D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x02));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00B0;
            L001B: SetFlag(player, 0x03, 0x02, 0x01);
            L0030: ShowMessage(player, String1908); // There were reasons why that orc was draggin' his body away from here.  With that armor on, he was going to become one smoked sausage to these wyrms!
0FC8  003D B8 EA 2E  mov ax, 0x2eea
            L0040: PushStack(player, ax);
            L0041: PushStack(player, 0x00);
            L0044: PushStack(player, ax);
            L0045: PushStack(player, ax);
            L0046: PushStack(player, 0xBB);
            L004A: PushStack(player, 0xDD);
0FD9  004E C4 5E 06  les bx, [bp+0x6]
0FDC  0051 26 FF 9F D8 00  call far word [es:bx+0xd8]
0FE1  0056 83 C4 0C  add sp, 0xc
            L0059: AddEncounter(player, 0x01, 0x27);
            L006B: AddEncounter(player, 0x05, 0x27);
            L007D: Compare(PartyCount(player), 0x0002);
            L0088: if (JumpBelowOrEqual) goto L00BD;
            L008A: AddEncounter(player, 0x02, 0x27);
            L009C: AddEncounter(player, 0x06, 0x27);
            L00AE: goto L00BD;
            L00B0: ShowMessage(player, String1886); // It appears you have totally dewyrmed this area.
            L00BD: return; // RETURN;
        }

        private void Fn_1E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x02));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00CD;
            L001B: ax = HasItem(player, 0xF4);
            L0029: if (JumpEqual) goto L0038;
            L002B: ShowMessage(player, String18B6); // I'm afraid you needed the other wyrm mastery item that came from a dragon's head.
            L0038: SetFlag(player, 0x03, 0x02, 0x01);
            L004D: ShowMessage(player, String1908); // There were reasons why that orc was draggin' his body away from here.  With that armor on, he was going to become one smoked sausage to these wyrms!
10A4  005A B8 EA 2E  mov ax, 0x2eea
            L005D: PushStack(player, ax);
            L005E: PushStack(player, 0x00);
            L0061: PushStack(player, ax);
            L0062: PushStack(player, ax);
            L0063: PushStack(player, 0xBB);
            L0067: PushStack(player, 0xDD);
10B5  006B C4 5E 06  les bx, [bp+0x6]
10B8  006E 26 FF 9F D8 00  call far word [es:bx+0xd8]
10BD  0073 83 C4 0C  add sp, 0xc
            L0076: AddEncounter(player, 0x01, 0x28);
            L0088: AddEncounter(player, 0x05, 0x28);
            L009A: Compare(PartyCount(player), 0x0002);
            L00A5: if (JumpBelowOrEqual) goto L00DA;
            L00A7: AddEncounter(player, 0x02, 0x28);
            L00B9: AddEncounter(player, 0x06, 0x28);
            L00CB: goto L00DA;
            L00CD: ShowMessage(player, String1886); // It appears you have totally dewyrmed this area.
            L00DA: return; // RETURN;
        }

        private void Fn_1F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x10));
            L0016: if (JumpNotEqual) goto L0054;
            L0018: SetFlag(player, 0x03, 0x10, 0x01);
            L002D: ShowPortrait(player, 0x001C);
            L003A: ShowMessage(player, String199D); // A badly bruised dwarf knight greets you.
            L0047: ShowMessage(player, String19C6); // 'By all the winds and zephyrs!  The dragons that nest in here are too tough for me to fight until I find something that will tame the winds they raise with their wings!'
            L0054: return; // RETURN;
        }

        private void Fn_20(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0xF7);
            L0011: if (JumpEqual) goto L001B;
            L0013: PushStack(player, 0x02);
1193  0017 33 C0  xor ax, ax
            L0019: goto L0022;
            L001B: TeleportParty(player, 0x0B, 0x01, 0x01, 0x02, isForwardMove);
            L0036: return; // RETURN;
        }

        private void Fn_21(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x03);
            L0007: PushStack(player, ax);
11BC  0008 C4 5E 06  les bx, [bp+0x6]
11BF  000B 26 FF 5F 04  call far word [es:bx+0x4]
            L000F: cx = PopStack(player);
            L0010: cx = PopStack(player);
            L0011: RefreshCompareFlags(ax);
            L0013: if (JumpEqual) goto L0018;
            L0015: goto L00AA;
            L0018: PushStack(player, 0x01);
            L001C: PushStack(player, 0x03);
            L0020: PushStack(player, ax);
11D5  0021 C4 5E 06  les bx, [bp+0x6]
11D8  0024 26 FF 1F  call far word [es:bx]
11DB  0027 83 C4 06  add sp, 0x6
            L002A: ShowMessage(player, String1A70); // Well, blow me down!  And that's just what these dragons are going to try to do!
11EB  0037 B8 EA 2E  mov ax, 0x2eea
            L003A: PushStack(player, ax);
            L003B: PushStack(player, 0x00);
            L003E: PushStack(player, ax);
            L003F: PushStack(player, ax);
            L0040: PushStack(player, 0xBB);
            L0044: PushStack(player, 0xDD);
11FC  0048 C4 5E 06  les bx, [bp+0x6]
11FF  004B 26 FF 9F D8 00  call far word [es:bx+0xd8]
1204  0050 83 C4 0C  add sp, 0xc
            L0053: AddEncounter(player, 0x01, 0x28);
            L0065: AddEncounter(player, 0x05, 0x28);
            L0077: Compare(PartyCount(player), 0x0002);
            L0082: if (JumpBelowOrEqual) goto L00B7;
            L0084: AddEncounter(player, 0x02, 0x28);
            L0096: AddEncounter(player, 0x06, 0x28);
            L00A8: goto L00B7;
            L00AA: ShowMessage(player, String1AC0); // This area is still.  Quiet.  Almost too quiet.
            L00B7: return; // RETURN;
        }

        private void Fn_22(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x03);
            L0007: PushStack(player, ax);
1275  0008 C4 5E 06  les bx, [bp+0x6]
1278  000B 26 FF 5F 04  call far word [es:bx+0x4]
            L000F: cx = PopStack(player);
            L0010: cx = PopStack(player);
            L0011: RefreshCompareFlags(ax);
            L0013: if (JumpEqual) goto L0018;
            L0015: goto L00AA;
            L0018: PushStack(player, 0x01);
            L001C: PushStack(player, 0x03);
            L0020: PushStack(player, ax);
128E  0021 C4 5E 06  les bx, [bp+0x6]
1291  0024 26 FF 1F  call far word [es:bx]
1294  0027 83 C4 06  add sp, 0x6
            L002A: ShowMessage(player, String1AEF); // These dragons sure treated that dwarf like some kind of fly by knight operation.  I bet you can prove that you're rather more substantial.  Attack!
12A4  0037 B8 EA 2E  mov ax, 0x2eea
            L003A: PushStack(player, ax);
            L003B: PushStack(player, 0x00);
            L003E: PushStack(player, ax);
            L003F: PushStack(player, ax);
            L0040: PushStack(player, 0xBB);
            L0044: PushStack(player, 0xDD);
12B5  0048 C4 5E 06  les bx, [bp+0x6]
12B8  004B 26 FF 9F D8 00  call far word [es:bx+0xd8]
12BD  0050 83 C4 0C  add sp, 0xc
            L0053: AddEncounter(player, 0x01, 0x27);
            L0065: AddEncounter(player, 0x05, 0x27);
            L0077: Compare(PartyCount(player), 0x0002);
            L0082: if (JumpBelowOrEqual) goto L00B7;
            L0084: AddEncounter(player, 0x02, 0x27);
            L0096: AddEncounter(player, 0x06, 0x27);
            L00A8: goto L00B7;
            L00AA: ShowMessage(player, String1AC0); // This area is still.  Quiet.  Almost too quiet.
            L00B7: return; // RETURN;
        }

        private void Fn_23(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0xF6);
            L0011: if (JumpEqual) goto L001C;
            L0013: PushStack(player, 0x02);
133D  0017 B8 17 00  mov ax, 0x17
            L001A: goto L0023;
            L001C: TeleportParty(player, 0x0B, 0x01, 0x18, 0x02, isForwardMove);
            L0037: return; // RETURN;
        }

        private void Fn_24(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x11));
            L0016: if (JumpNotEqual) goto L0054;
            L0018: SetFlag(player, 0x03, 0x11, 0x01);
            L002D: ShowPortrait(player, 0x0018);
            L003A: ShowMessage(player, String1B83); // A badly battered barbarian greets you.
            L0047: ShowMessage(player, String1BAA); // 'By my femurs and patellae!  Thou dost not wish to pass this door unless thou hast some defense against the fiercesome kicks of the wyrms within.  I can say that they really kicked my, uh, well, mayhaps I cannot say'
            L0054: return; // RETURN;
        }

        private void Fn_25(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x04));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00B4;
            L001B: SetFlag(player, 0x03, 0x04, 0x01);
            L0030: ShowMessage(player, String1C83); // Ye gods!  These dragons are having a soccer match, and they've cast you as the ball.  Beware!
13F2  003D B8 EA 2E  mov ax, 0x2eea
            L0040: PushStack(player, ax);
            L0041: PushStack(player, 0x00);
            L0044: PushStack(player, ax);
            L0045: PushStack(player, ax);
            L0046: PushStack(player, 0xBB);
            L004A: PushStack(player, 0xDD);
1403  004E C4 5E 06  les bx, [bp+0x6]
1406  0051 26 FF 9F D8 00  call far word [es:bx+0xd8]
140B  0056 83 C4 0C  add sp, 0xc
            L0059: AddEncounter(player, 0x01, 0x28);
            L006B: AddEncounter(player, 0x05, 0x28);
            L007D: Compare(PartyCount(player), 0x0002);
            L0088: if (JumpAbove) goto L008D;
            L008A: goto L0152;
            L008D: AddEncounter(player, 0x02, 0x28);
            L009F: AddEncounter(player, 0x06, 0x28);
            L00B1: goto L0152;
            L00B4: ShowMessage(player, String1AC0); // This area is still.  Quiet.  Almost too quiet.
            L00C1: Compare(GetFlag(player, 0x02, 0x53), 0x0001);
            L00D5: if (JumpEqual) goto L0145;
            L00D7: Compare(GetFlag(player, 0x02, 0x53), 0x000A);
            L00EB: if (JumpEqual) goto L0145;
            L00ED: Compare(GetFlag(player, 0x02, 0x53), 0x000C);
            L0101: if (JumpEqual) goto L0145;
            L0103: Compare(GetFlag(player, 0x02, 0x53), 0x000E);
            L0117: if (JumpEqual) goto L0145;
            L0119: Compare(GetFlag(player, 0x02, 0x53), 0x001B);
            L012D: if (JumpEqual) goto L0145;
            L012F: Compare(GetFlag(player, 0x02, 0x53), 0x001C);
            L0143: if (JumpNotEqual) goto L0152;
            L0145: ShowMessage(player, String1CE1); // Naw, it's not too quiet, I'm just messing with your mind.  Believe me, too quiet is far far better than the alternative: too noisy.
            L0152: return; // RETURN;
        }

        private void Fn_26(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x04));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00B4;
            L001B: SetFlag(player, 0x03, 0x04, 0x01);
            L0030: ShowMessage(player, String1AEF); // These dragons sure treated that dwarf like some kind of fly by knight operation.  I bet you can prove that you're rather more substantial.  Attack!
1546  003D B8 EA 2E  mov ax, 0x2eea
            L0040: PushStack(player, ax);
            L0041: PushStack(player, 0x00);
            L0044: PushStack(player, ax);
            L0045: PushStack(player, ax);
            L0046: PushStack(player, 0xBB);
            L004A: PushStack(player, 0xDD);
1557  004E C4 5E 06  les bx, [bp+0x6]
155A  0051 26 FF 9F D8 00  call far word [es:bx+0xd8]
155F  0056 83 C4 0C  add sp, 0xc
            L0059: AddEncounter(player, 0x01, 0x27);
            L006B: AddEncounter(player, 0x05, 0x27);
            L007D: Compare(PartyCount(player), 0x0002);
            L0088: if (JumpAbove) goto L008D;
            L008A: goto L0152;
            L008D: AddEncounter(player, 0x02, 0x27);
            L009F: AddEncounter(player, 0x06, 0x27);
            L00B1: goto L0152;
            L00B4: ShowMessage(player, String1AC0); // This area is still.  Quiet.  Almost too quiet.
            L00C1: Compare(GetFlag(player, 0x02, 0x53), 0x0001);
            L00D5: if (JumpEqual) goto L0145;
            L00D7: Compare(GetFlag(player, 0x02, 0x53), 0x000A);
            L00EB: if (JumpEqual) goto L0145;
            L00ED: Compare(GetFlag(player, 0x02, 0x53), 0x000C);
            L0101: if (JumpEqual) goto L0145;
            L0103: Compare(GetFlag(player, 0x02, 0x53), 0x000E);
            L0117: if (JumpEqual) goto L0145;
            L0119: Compare(GetFlag(player, 0x02, 0x53), 0x001B);
            L012D: if (JumpEqual) goto L0145;
            L012F: Compare(GetFlag(player, 0x02, 0x53), 0x001C);
            L0143: if (JumpNotEqual) goto L0152;
            L0145: ShowMessage(player, String1D65); // Boy, do I ever get a kick from saying that!
            L0152: return; // RETURN;
        }

        private void Fn_27(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x05));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00D8;
            L001B: SetFlag(player, 0x03, 0x05, 0x01);
            L0030: ShowMessage(player, String1D91); // You might call this coroner's corner, because all these undead have you cornered!
169A  003D B8 EA 2E  mov ax, 0x2eea
            L0040: PushStack(player, ax);
            L0041: PushStack(player, 0x00);
            L0044: PushStack(player, ax);
            L0045: PushStack(player, ax);
            L0046: PushStack(player, 0xBB);
            L004A: PushStack(player, 0xDD);
16AB  004E C4 5E 06  les bx, [bp+0x6]
16AE  0051 26 FF 9F D8 00  call far word [es:bx+0xd8]
16B3  0056 83 C4 0C  add sp, 0xc
            L0059: AddEncounter(player, 0x01, 0x25);
            L006B: AddEncounter(player, 0x05, 0x24);
            L007D: AddEncounter(player, 0x02, 0x1D);
            L008F: AddEncounter(player, 0x03, 0x1E);
            L00A1: Compare(PartyCount(player), 0x0002);
            L00AC: if (JumpAbove) goto L00B1;
            L00AE: goto L0176;
            L00B1: AddEncounter(player, 0x04, 0x1F);
            L00C3: AddEncounter(player, 0x06, 0x24);
            L00D5: goto L0176;
            L00D8: ShowMessage(player, String1DE3); // This corner is still.  Quiet.  Quiet as the grave.
            L00E5: Compare(GetFlag(player, 0x02, 0x53), 0x0001);
            L00F9: if (JumpEqual) goto L0169;
            L00FB: Compare(GetFlag(player, 0x02, 0x53), 0x000A);
            L010F: if (JumpEqual) goto L0169;
            L0111: Compare(GetFlag(player, 0x02, 0x53), 0x000C);
            L0125: if (JumpEqual) goto L0169;
            L0127: Compare(GetFlag(player, 0x02, 0x53), 0x000E);
            L013B: if (JumpEqual) goto L0169;
            L013D: Compare(GetFlag(player, 0x02, 0x53), 0x001B);
            L0151: if (JumpEqual) goto L0169;
            L0153: Compare(GetFlag(player, 0x02, 0x53), 0x001C);
            L0167: if (JumpNotEqual) goto L0176;
            L0169: ShowMessage(player, String1E16); // Okay, it's moderately loud, but well insulated.
            L0176: return; // RETURN;
        }

        private void Fn_28(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x06));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00F2;
            L001B: SetFlag(player, 0x03, 0x06, 0x01);
            L0030: ShowMessage(player, String1E46); // All these spellcasters spell trouble for you, with a capital rouble!
            L003D: Compare(PartyCount(player), 0x0002);
            L0048: if (JumpBelowOrEqual) goto L0057;
            L004A: ShowMessage(player, String1E8B); // Or maybe they spell trouble M-E-D-U-S-A-E!
182C  0057 B8 EA 2E  mov ax, 0x2eea
            L005A: PushStack(player, ax);
            L005B: PushStack(player, 0x00);
            L005E: PushStack(player, ax);
            L005F: PushStack(player, ax);
            L0060: PushStack(player, 0xBB);
            L0064: PushStack(player, 0xDD);
183D  0068 C4 5E 06  les bx, [bp+0x6]
1840  006B 26 FF 9F D8 00  call far word [es:bx+0xd8]
1845  0070 83 C4 0C  add sp, 0xc
            L0073: AddEncounter(player, 0x01, 0x1A);
            L0085: AddEncounter(player, 0x05, 0x1B);
            L0097: AddEncounter(player, 0x02, 0x1A);
            L00A9: AddEncounter(player, 0x06, 0x1C);
            L00BB: Compare(PartyCount(player), 0x0002);
            L00C6: if (JumpAbove) goto L00CB;
            L00C8: goto L01AA;
            L00CB: AddEncounter(player, 0x04, 0x26);
            L00DD: AddEncounter(player, 0x06, 0x26);
            L00EF: goto L01AA;
            L00F2: ShowMessage(player, String1EB6); // The spellcasters you met here were casting you as the targets, but now it's a pleasant enough spot to cast aside your worries.
            L00FF: HealPlayer(player, 0x03E8);
            L010C: Compare(GetFlag(player, 0x02, 0x53), 0x0001);
            L0120: if (JumpEqual) goto L0190;
            L0122: Compare(GetFlag(player, 0x02, 0x53), 0x000A);
            L0136: if (JumpEqual) goto L0190;
            L0138: Compare(GetFlag(player, 0x02, 0x53), 0x000C);
            L014C: if (JumpEqual) goto L0190;
            L014E: Compare(GetFlag(player, 0x02, 0x53), 0x000E);
            L0162: if (JumpEqual) goto L0190;
            L0164: Compare(GetFlag(player, 0x02, 0x53), 0x001B);
            L0178: if (JumpEqual) goto L0190;
            L017A: Compare(GetFlag(player, 0x02, 0x53), 0x001C);
            L018E: if (JumpNotEqual) goto L01AA;
            L0190: ShowMessage(player, String1F35); // Of course, that concept isn't cast in iron!
            L019D: DamagePlayer(player, 0x05DC);
            L01AA: return; // RETURN;
        }

        private void Fn_29(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x07));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L0142;
            L001B: SetFlag(player, 0x03, 0x07, 0x01);
            L0030: Compare(GetFlag(player, 0x03, 0x09), 0x0001);
            L0044: if (JumpNotEqual) goto L0069;
            L0046: ShowMessage(player, String1F61); // Good thing you were moving cautiously, because this was one heck of a fine spot for an ambush!
            L0053: SetFlag(player, 0x03, 0x09, 0x00);
            L0067: goto L00A7;
            L0069: ShowMessage(player, String1FC0); // Did you know that in Alchemia and Astrologia, if you have the right connections, you can get potions that will remove your enemy's mana?  Here!  Let me show you what I mean!
            L0076: ax = GetMaxHits(player);
            L007D: bx = 0x0003;
            L0080: dx = ax % bx; ax = ax / bx;
            L0083: DamagePlayer(player, ax);
            L008D: AddMana(player, 0xF704);
            L009A: ShowMessage(player, String206E); // How did those guys get the right connections?  Well they bribed (Hork) certain (Hork) people (Hork) with lots and lots of chocolate.  Fortunately for you, Dinky is unbribeable.
1A28  00A7 B8 EA 2E  mov ax, 0x2eea
            L00AA: PushStack(player, ax);
            L00AB: PushStack(player, 0x00);
            L00AE: PushStack(player, ax);
            L00AF: PushStack(player, ax);
            L00B0: PushStack(player, 0xBB);
            L00B4: PushStack(player, 0xDD);
1A39  00B8 C4 5E 06  les bx, [bp+0x6]
1A3C  00BB 26 FF 9F D8 00  call far word [es:bx+0xd8]
1A41  00C0 83 C4 0C  add sp, 0xc
            L00C3: AddEncounter(player, 0x01, 0x22);
            L00D5: AddEncounter(player, 0x05, 0x20);
            L00E7: AddEncounter(player, 0x02, 0x23);
            L00F9: AddEncounter(player, 0x06, 0x21);
            L010B: Compare(PartyCount(player), 0x0002);
            L0116: if (JumpAbove) goto L011B;
            L0118: goto L01ED;
            L011B: AddEncounter(player, 0x04, 0x20);
            L012D: AddEncounter(player, 0x06, 0x21);
            L013F: goto L01ED;
            L0142: ShowMessage(player, String211F); // All that remains of your battle here is a chocolate bar wrapper.
            L014F: Compare(GetFlag(player, 0x02, 0x53), 0x0001);
            L0163: if (JumpEqual) goto L01D3;
            L0165: Compare(GetFlag(player, 0x02, 0x53), 0x000A);
            L0179: if (JumpEqual) goto L01D3;
            L017B: Compare(GetFlag(player, 0x02, 0x53), 0x000C);
            L018F: if (JumpEqual) goto L01D3;
            L0191: Compare(GetFlag(player, 0x02, 0x53), 0x000E);
            L01A5: if (JumpEqual) goto L01D3;
            L01A7: Compare(GetFlag(player, 0x02, 0x53), 0x001B);
            L01BB: if (JumpEqual) goto L01D3;
            L01BD: Compare(GetFlag(player, 0x02, 0x53), 0x001C);
            L01D1: if (JumpNotEqual) goto L01ED;
            L01D3: ShowMessage(player, String2160); // Like I said, it's a REALLY good thing for you that Dinky is unbribeable, at least until you can figure out how to get chocolate into cyberspace.
            L01E0: ShowMessage(player, String21F1); // On the other hand, his wife is eminently bribeable and she can browbeat him into doing almost anything (hint hint).
            L01ED: return; // RETURN;
        }

        private void Fn_2A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String2265); // Unfortunately, after just two steps the stairwell has collapsed in a big pile of rubble.
            L0010: return; // RETURN;
        }

        private void Fn_2B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x0B, 0x01, 0x4D, 0x02, isForwardMove);
            L001E: return; // RETURN;
        }

        private void Fn_2C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x0B, 0x01, 0x4C, 0x02, isForwardMove);
            L001E: return; // RETURN;
        }

        private void Fn_2D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x0B, 0x01, 0x7A, 0x00, isForwardMove);
            L001D: return; // RETURN;
        }

        private void Fn_2E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x0B, 0x01, 0xAB, 0x01, isForwardMove);
            L001E: return; // RETURN;
        }

        private void Fn_2F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x0B, 0x01, 0xDB, 0x01, isForwardMove);
            L001E: return; // RETURN;
        }

        private void Fn_30(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x0B, 0x01, 0xB7, 0x01, isForwardMove);
            L001E: return; // RETURN;
        }

        private void Fn_31(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x0B, 0x01, 0x80, 0x01, isForwardMove);
            L001E: return; // RETURN;
        }

        private void Fn_32(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x0B, 0x01, 0x14, 0x03, isForwardMove);
            L001E: return; // RETURN;
        }

    }
}
