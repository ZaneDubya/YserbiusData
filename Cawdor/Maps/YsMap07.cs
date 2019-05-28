#pragma warning disable
using System.Collections.Generic;
using XPT.WorldData;
using XPT.WorldData.Yserbius;

namespace XPT.Scripts.Yserbius.Maps {
    class YserMap07 : AMapScripted {
        protected override int MapIndex => 7;
        protected override int RandomEncounterChance => 10;
        protected override int RandomEncounterExtraCount => 0;

        public YserMap07() {
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
            MapEvent27 = Fn_27;
            MapEvent28 = Fn_28;
            MapEvent29 = Fn_29;
            MapEvent2A = Fn_2A;
            MapEvent33 = Fn_33;
            MapEvent34 = Fn_34;
            MapEvent35 = Fn_35;
            MapEvent36 = Fn_36;
            MapEvent37 = Fn_37;
            MapEvent38 = Fn_38;
        }
        
        // === Strings ================================================
        private const string String0140 = "This way to the Foyer of Cawdor.";
        private const string String0161 = "*";
        private const string String0163 = "'Ah, most stalwart and worthy, friend beyond all measure, it gladdens my heart to see you return to me once more yet hale and hearty.'";
        private const string String01EA = "He looks down at your feet.";
        private const string String0206 = "'And with such clean shoes, too.'";
        private const string String0228 = "'Get thee hence!  Away with thee.  Thou hast heard my instructions once already this day.  Go thou and prosper.  And WIPE YOUR FEET next time!'";
        private const string String02B8 = "An old gnome barbarian peers at you from behind a cluttered desk.";
        private const string String02FA = "'My aged heart so fills with happiness at thy return, my lord, that it would burst, were it not for fear of what may happen to thee beyond these portals.  Do be careful.";
        private const string String03A4 = "The old gnome looks down expectantly at your feet.";
        private const string String03D7 = "You wipe them on the doormat.  What could it hurt?";
        private const string String040A = "The gnome smiles broadly and winks at you.";
        private const string String0435 = "'New blood, eh?  Care to sign in?  Of COURSE not! You're a BARBARIAN; you can't read!  Heh heh.  And you know what happens if you learn how to read?  They stick you behind this ruddy desk!";
        private const string String04F2 = "Now here's the rules o' the room.  Anything friendly won't attack.  Anything unfriendly's fair game.  Clean out enough unfriendlies and you might get rewarded.  Questions?  Tough!  And stop tracking all that mud through here!'";
        private const string String05D5 = "Zwounds!  This must be the largest room you've ever seen! You hear echoing the sounds of a dozen combats, the cries of the chase and the wounded, the far off tinkling of fountains, and the crushing of a thousand discarded chicken bones underfoot.";
        private const string String06CC = "You see the remains of a massive and somehow familiar battle here.  By Jove!  You were the one that left this area in such an untidy state!";
        private const string String0758 = "With a cry of gleeful abandon, you are beset!";
        private const string String0786 = "The abandon was gleeful because they outnumber you!";
        private const string String07BA = "You hear some footsteps running away.";
        private const string String07E0 = "You hear some footsteps running towards you.";
        private const string String080D = "You turn to look, but can only see their backs as they continue away from you.  It looks like they were chasing something large and reptilian. ";
        private const string String089D = "You find a few lightly incinerated dwarves.";
        private const string String08C9 = "'Oh!  Beg your pardon.  I thought you were someone else.  By the by, have you chappies seen a large group, oh, say eighty.... No, that's not right.  Let me count.";
        private const string String096C = "There were eighty, but I caught some by the healing fountain, and a few more by the mana fountain.  Anyway, it is still a large group of dwarves carrying a ten foot diameter golden egg.  Ring any bells?  Hoy!  There they go.  Ta!'";
        private const string String0A53 = "'Hate to be a bother, but have you seen a bunch of dwarves, minding their own business, not stealing any dragon eggs or - '";
        private const string String0ACF = "The dwarf pauses as dwarven screams of terror waft gently through the night.";
        private const string String0B1C = "'No need after all.  I can hear where they are.  Thanks muchly.'";
        private const string String0B5D = "The dwarf carefully slinks away in the opposite direction.";
        private const string String0B98 = "A somewhat battered gang of dwarves rushes to the attack.";
        private const string String0BD2 = "Hmm.  Broken bodkins, smashed short swords, damaged daggers: somebody fought a bunch of thieves here.  In fact, as memory serves, that somebody was you.";
        private const string String0C6B = "Some thieves look up from their looting and decide to join the side of the unfriendlies!";
        private const string String0CC4 = "And some friends of theirs decide to help!";
        private const string String0CEF = "A voice whispers from thin air....";
        private const string String0D12 = "'I'm sorry, but there's nothing else I can do for you here.'";
        private const string String0D4F = "'Huzzah!  Thou hast done so well hitherto that I can safely reward thee.  I think me knowledge of the spell of shielding will best serve thee now.'";
        private const string String0DE3 = "You realize that you now know that spell!";
        private const string String0E0D = "Galatea draws you aside for a private message.";
        private const string String0E3C = "'I praise thee and acknowledge thee, child of innocence and slaughter.  And I reward thee with the skill of Stamina.'";
        private const string String0EB2 = "'Thou hast already received all the rewards thou hast earned and that I can safely grant thee here, lest my sisters notice and suspect the usage of my power.'";
        private const string String0F51 = "Galatea pulls your party's barbarians aside for a few private words, and then returns.";
        private const string String0FA8 = "'Thou art surviving, which is the important thing.  Take thee this item which mayhaps will help thee to continue doing so.'";
        private const string String1024 = "'Thou hast earned no further rewards from me, flibbertigibbet!'";
        private const string String1064 = "A human thief shakes his head at you and whispers.";
        private const string String1097 = "'Not now, friend.  I fear we're being watched.'";
        private const string String10C7 = "A human thief jauntily looks you up and down.";
        private const string String10F5 = "'I think me I have found a fellow quester.  Look, you, I dare not divulge all, nor can I abide whilst we convince each other of our bona fides, but I will give thee this hint:'";
        private const string String11A6 = "'There was a sage who knew an elf Who knew a man, who knew myself, From whom I learned the sage once said That Malcolm's rest is colored red.'";
        private const string String1235 = "You remember this battlefield.  You slowly release a deep breath as you recall the bloodshed that happened here.";
        private const string String12A6 = "Once again into the breech!";
        private const string String12C2 = "You remember that unholy alliance of elves, dwarves and gnomes you fought here.";
        private const string String1312 = "A well organized force of inhumans marches towards you.";
        private const string String134A = "The stench of death still permeates this place.";
        private const string String137A = "You find something useful discarded amongst the rubble.";
        private const string String13B2 = "Perhaps the only clean piece of floor in this entire area reminds you fondly of the grateful tears the gnome barbarian choked back when you returned the missing doormat.";
        private const string String145C = "Whoa, Nessie!  As you tug from underneath this big pile of stuff, something remarkably intact goes sliding away.";
        private const string String14CD = "And you don't even want to think what kind of sludge was responsible for making it so slippery.";
        private const string String152D = "An unseemly pile of rubbish lies in the corner of this great room.";
        private const string String1570 = "'Be hanged, thou kidney brains, aye, thou puny piz - wait.  Can it be?  Hast thou found and returned to me my long lost doormat?'";
        private const string String15F2 = "The gnome takes the doormat with a tenderness exceeding the way most mothers handle their mewling and puking infants.  He pats a cloud of dust from it and lays it reverently upon the floor.";
        private const string String16B0 = "'Words fail.  I am but a rock, unable to convey my great gratitude.  But allow me to attempt a small compensation for the risks thou hast undertaken for me, my lord.  This scroll will be useful for an adventurer such as thyself.  Take it, and with it, my undying gratitude.'";
        private const string String17C3 = "'Tis a tale told by an idiot, full of sound and fury, signifying nothing,' you quote to yourself, remembering the battle that happened here.";
        private const string String1850 = "The corpses are still warm, lying here.";
        private const string String1878 = "This is another fine mess you've gotten yourself in to.";
        private const string String18B0 = "Hammers and tongs!  An enormous red dragon rears up and addresses to you.";
        private const string String18FA = "'Hmm.  There are two ways this could go.  We could have similar senses of humor, and part friends, or I could just eat thee.  So.  Wouldst hear a joke about a stupid green dragon named Gwalter the Dim?'";
        private const string String19C5 = "'Ah!  Wouldst hear another story from the life of Gwalter the Dim, green dragon?'";
        private const string String1A17 = "You quickly nod.";
        private const string String1A28 = "'Gwalter the Dim, a very stupid dragon by red lights, went visiting a much brighter red dragon who lived in a cave near a clearing in the woods.  Gwalter came in to land, and could not stop himself in time:  base over apex, into the woods, clattering and crashing and thoroughly discommoding the passersby.'";
        private const string String1B5C = "'Gwalter's friend rushed up to him and asked why he landed so badly.  Gwalter said, 'Tis your own fault for clearing such a short landing site, no matter how wide it is.'";
        private const string String1C07 = "The dragon's guffaws reverberate throughout the room as he flies off.  Forcing laughter may have hurt, but being eaten would have hurt more.";
        private const string String1C94 = "There's another desk here, with a human clad in some natty furs sitting behind it.";
        private const string String1CE7 = "'By my stars and garters!  I have had my eye on thee, and that is quite a lot of unfriendlies thou hast eliminated.  I think me I have a special reward for such an enterprising soul as thyself.'";
        private const string String1DAA = "'Now don't go spending all that in one place, now. Hah!  I almost forgot!  There IS only one place to spend all that, hereabouts!'";
        private const string String1E2D = "'Ye'll have to do more than that in the way of cleaning up this place if ye want ME to reward ye!'";
        private const string String1E90 = "Thou art the veriest varlot that e'er found a rose in a cesspool.  'Tis the long lost door mat!";
        private const string String1EF0 = "A huge and unhealthy looking pile or rubbish lies to the north.";
        private const string String1F30 = "A huge and unhealthy looking pile or rubbish lies to the west.  It's smelly, too.  Be grateful you don't have the new NoseBlaster card in your computer.";
        private const string String1FC9 = "The magic of the cool waters heals your wounds.";
        private const string String1FF9 = "The waters offer no refreshment.";
        private const string String201A = "The magic of the cool waters restores your mana.";
        
        // === Functions ================================================
        private void Fn_01(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFlag(player, 0x02, 0x52, 0x01);
            L0018: Compare(GetFacing(player), 0x0002);
            L0022: if (JumpNotEqual) goto L0031;
            L0024: ShowMessage(player, String0140); // This way to the Foyer of Cawdor.
            L0031: return; // RETURN;
        }

        private void Fn_02(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0019);
            L0010: Compare(GetFlag(player, 0x03, 0x01), 0x0001);
            L0024: if (JumpEqual) goto L0029;
            L0026: goto L00B3;
            L0029: Compare(GetFlag(player, 0x02, 0x07), 0x0001);
            L003D: if (JumpNotEqual) goto L0086;
            L003F: ShowMessage(player, String0161); // *
            L004C: ShowMessage(player, String0161); // *
            L0059: ShowMessage(player, String0161); // *
            L0066: ShowMessage(player, String0163); // 'Ah, most stalwart and worthy, friend beyond all measure, it gladdens my heart to see you return to me once more yet hale and hearty.'
            L0073: ShowMessage(player, String01EA); // He looks down at your feet.
00BE  0080 B8 06 02  mov ax, 0x206
            L0083: goto L014B;
            L0086: ShowMessage(player, String0161); // *
            L0093: ShowMessage(player, String0161); // *
            L00A0: ShowMessage(player, String0161); // *
00EB  00AD B8 28 02  mov ax, 0x228
            L00B0: goto L014B;
            L00B3: PushStack(player, 0x01);
            L00B7: PushStack(player, ax);
            L00B8: PushStack(player, 0x03);
00FA  00BC C4 5E 06  les bx, [bp+0x6]
00FD  00BF 26 FF 1F  call far word [es:bx]
0100  00C2 83 C4 06  add sp, 0x6
            L00C5: ShowMessage(player, String0161); // *
            L00D2: ShowMessage(player, String0161); // *
            L00DF: ShowMessage(player, String0161); // *
            L00EC: ShowMessage(player, String02B8); // An old gnome barbarian peers at you from behind a cluttered desk.
            L00F9: Compare(GetFlag(player, 0x02, 0x07), 0x0001);
            L010D: if (JumpNotEqual) goto L013B;
            L010F: ShowMessage(player, String02FA); // 'My aged heart so fills with happiness at thy return, my lord, that it would burst, were it not for fear of what may happen to thee beyond these portals.  Do be careful.
            L011C: ShowMessage(player, String03A4); // The old gnome looks down expectantly at your feet.
            L0129: ShowMessage(player, String03D7); // You wipe them on the doormat.  What could it hurt?
0174  0136 B8 0A 04  mov ax, 0x40a
            L0139: goto L014B;
            L013B: ShowMessage(player, String0435); // 'New blood, eh?  Care to sign in?  Of COURSE not! You're a BARBARIAN; you can't read!  Heh heh.  And you know what happens if you learn how to read?  They stick you behind this ruddy desk!
            L0148: ShowMessage(player, String04F2); // Now here's the rules o' the room.  Anything friendly won't attack.  Anything unfriendly's fair game.  Clean out enough unfriendlies and you might get rewarded.  Questions?  Tough!  And stop tracking all that mud through here!'
            L0155: return; // RETURN;
        }

        private void Fn_03(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFloorPassable(player, 0x00, GetCurrentTile(player));
            L0017: return; // RETURN;
        }

        private void Fn_04(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFacing(player));
            L000C: if (JumpNotEqual) goto L0042;
            L000E: ShowMessage(player, String0161); // *
            L001B: ShowMessage(player, String0161); // *
            L0028: ShowMessage(player, String0161); // *
            L0035: ShowMessage(player, String05D5); // Zwounds!  This must be the largest room you've ever seen! You hear echoing the sounds of a dozen combats, the cries of the chase and the wounded, the far off tinkling of fountains, and the crushing of a thousand discarded chicken bones underfoot.
            L0042: return; // RETURN;
        }

        private void Fn_05(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x02));
            L0016: if (JumpEqual) goto L0028;
            L0018: ShowMessage(player, String06CC); // You see the remains of a massive and somehow familiar battle here.  By Jove!  You were the one that left this area in such an untidy state!
            L0025: goto L00E2;
            L0028: SetFlag(player, 0x03, 0x02, 0x03);
            L003D: ShowMessage(player, String0758); // With a cry of gleeful abandon, you are beset!
            L004A: Compare(PartyCount(player), 0x0002);
            L0055: if (JumpBelowOrEqual) goto L0064;
            L0057: ShowMessage(player, String0786); // The abandon was gleeful because they outnumber you!
            L0064: PushStack(player, 0xBC);
            L0068: PushStack(player, 0x00);
            L006B: PushStack(player, ax);
            L006C: PushStack(player, ax);
            L006D: PushStack(player, 0xB8);
            L0071: PushStack(player, 0x6D);
0267  0075 C4 5E 06  les bx, [bp+0x6]
026A  0078 26 FF 9F D8 00  call far word [es:bx+0xd8]
026F  007D 83 C4 0C  add sp, 0xc
            L0080: AddEncounter(player, 0x01, 0x28);
            L0092: Compare(PartyCount(player), 0x0001);
            L009D: if (JumpBelowOrEqual) goto L00B1;
            L009F: AddEncounter(player, 0x02, 0x27);
            L00B1: Compare(PartyCount(player), 0x0002);
            L00BC: if (JumpBelowOrEqual) goto L00E2;
            L00BE: AddEncounter(player, 0x03, 0x26);
            L00D0: AddEncounter(player, 0x04, 0x25);
            L00E2: return; // RETURN;
        }

        private void Fn_06(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si, di);
            L0005: di = 0;
            L0007: si = 0;
            L0009: ax = GetFlag(player, 0x03, 0x0C);
02F0  001A 8B F8  mov di, ax
02F2  001C 47     inc di
02F3  001D 8B F7  mov si, di
            L001F: Compare(si, 0x13);
            L0022: if (JumpLessOrEqual) goto L002B;
02FA  0024 8B C6  mov ax, si
            L0026: si = ax + 0xFFEC;
            L002B: Compare(si, 0x0E);
            L002E: if (JumpLessOrEqual) goto L0037;
0306  0030 8B C6  mov ax, si
            L0032: si = ax + 0xFFF1;
            L0037: Compare(si, 0x09);
            L003A: if (JumpLessOrEqual) goto L0043;
0312  003C 8B C6  mov ax, si
            L003E: si = ax + 0xFFF6;
            L0043: Compare(si, 0x04);
            L0046: if (JumpLessOrEqual) goto L004F;
031E  0048 8B C6  mov ax, si
            L004A: si = ax + 0xFFFB;
0325  004F 0B F6  or si, si
0327  0051 7D 02  jge 0x55
            L0053: si = 0;
            L0055: Compare(si, 0x1D);
            L0058: if (JumpLessOrEqual) goto L005C;
            L005A: si = 0;
0332  005C 83 FF 18  cmp di, 0x18
            L005F: if (JumpLessOrEqual) goto L0063;
            L0061: di = 0;
0339  0063 57     push di
            L0064: PushStack(player, 0x0C);
            L0068: PushStack(player, 0x03);
0342  006C C4 5E 06  les bx, [bp+0x6]
0345  006F 26 FF 1F  call far word [es:bx]
0348  0072 83 C4 06  add sp, 0x6
034B  0075 83 FF 1A  cmp di, 0x1a
            L0078: if (JumpNotEqual) goto L007F;
0350  007A B8 01 00  mov ax, 0x1
            L007D: goto L0081;
            L007F: PushStack(player, 0x00);
0358  0082 83 FF 14  cmp di, 0x14
            L0085: if (JumpNotEqual) goto L008C;
035D  0087 B8 01 00  mov ax, 0x1
            L008A: goto L008E;
0362  008C 33 C0  xor ax, ax
            L008E: dx = PopStack(player);
0365  008F 0B D0  or dx, ax
            L0091: PushStack(player, dx);
0368  0092 83 FF 0E  cmp di, 0xe
            L0095: if (JumpNotEqual) goto L009C;
036D  0097 B8 01 00  mov ax, 0x1
            L009A: goto L009E;
0372  009C 33 C0  xor ax, ax
            L009E: dx = PopStack(player);
0375  009F 0B D0  or dx, ax
            L00A1: PushStack(player, dx);
0378  00A2 83 FF 08  cmp di, 0x8
            L00A5: if (JumpNotEqual) goto L00AC;
037D  00A7 B8 01 00  mov ax, 0x1
            L00AA: goto L00AE;
0382  00AC 33 C0  xor ax, ax
            L00AE: dx = PopStack(player);
0385  00AF 0B D0  or dx, ax
            L00B1: PushStack(player, dx);
0388  00B2 83 FF 02  cmp di, 0x2
            L00B5: if (JumpNotEqual) goto L00BC;
038D  00B7 B8 01 00  mov ax, 0x1
            L00BA: goto L00BE;
0392  00BC 33 C0  xor ax, ax
            L00BE: dx = PopStack(player);
0395  00BF 0B D0  or dx, ax
            L00C1: if (JumpNotEqual) goto L00C6;
            L00C3: goto L02A5;
            L00C6: bx = si;
            L00C8: Compare(bx, 0x04);
            L00CB: if (JumpBelowOrEqual) goto L00D0;
            L00CD: goto L02A5;
            L00D0: switch (bx) {
                case 0:
                    goto L00D7;
                case 1:
                    goto L00E7;
                case 2:
                    goto L00F9;
                case 3:
                    goto L01BE;
                case 4:
                    goto L021F;
            }
            L00D7: ShowMessage(player, String07BA); // You hear some footsteps running away.
            L00E4: goto L02A5;
            L00E7: ShowMessage(player, String07E0); // You hear some footsteps running towards you.
03CA  00F4 B8 0D 08  mov ax, 0x80d
            L00F7: goto L00DA;
            L00F9: Compare(GetFlag(player, 0x03, 0x0D), 0x0001);
            L010D: if (JumpEqual) goto L0123;
            L010F: RefreshCompareFlags(GetFlag(player, 0x03, 0x00));
            L0121: if (JumpEqual) goto L0128;
03F9  0123 B8 9D 08  mov ax, 0x89d
            L0126: goto L00DA;
            L0128: ShowPortrait(player, 0x000E);
            L0135: SetFlag(player, 0x02, 0x4C, 0x01);
            L014A: ShowMessage(player, String0161); // *
            L0157: ShowMessage(player, String0161); // *
            L0164: ShowMessage(player, String0161); // *
            L0171: ShowMessage(player, String08C9); // 'Oh!  Beg your pardon.  I thought you were someone else.  By the by, have you chappies seen a large group, oh, say eighty.... No, that's not right.  Let me count.
            L017E: ShowMessage(player, String096C); // There were eighty, but I caught some by the healing fountain, and a few more by the mana fountain.  Anyway, it is still a large group of dwarves carrying a ten foot diameter golden egg.  Ring any bells?  Hoy!  There they go.  Ta!'
            L018B: Compare(GetFlag(player, 0x03, 0x0D), 0x0002);
            L019F: if (JumpNotEqual) goto L01A6;
0477  01A1 B8 03 00  mov ax, 0x3
            L01A4: goto L01A9;
            L01A6: SetFlag(player, 0x03, 0x0D, 0x01);
            L01BB: goto L02A5;
            L01BE: ShowPortrait(player, 0x0023);
            L01CB: ShowMessage(player, String0161); // *
            L01D8: ShowMessage(player, String0161); // *
            L01E5: ShowMessage(player, String0161); // *
            L01F2: ShowMessage(player, String0A53); // 'Hate to be a bother, but have you seen a bunch of dwarves, minding their own business, not stealing any dragon eggs or - '
            L01FF: ShowMessage(player, String0ACF); // The dwarf pauses as dwarven screams of terror waft gently through the night.
            L020C: ShowMessage(player, String0B1C); // 'No need after all.  I can hear where they are.  Thanks muchly.'
04EF  0219 B8 5D 0B  mov ax, 0xb5d
            L021C: goto L00DA;
            L021F: ShowPortrait(player, 0x001C);
            L022C: ShowMessage(player, String0B98); // A somewhat battered gang of dwarves rushes to the attack.
            L0239: PushStack(player, 0x55);
            L023D: PushStack(player, 0x00);
            L0240: PushStack(player, ax);
            L0241: PushStack(player, ax);
            L0242: PushStack(player, 0x8C);
            L0246: PushStack(player, 0xBD);
0520  024A C4 5E 06  les bx, [bp+0x6]
0523  024D 26 FF 9F D8 00  call far word [es:bx+0xd8]
0528  0252 83 C4 0C  add sp, 0xc
            L0255: AddEncounter(player, 0x01, 0x23);
            L0267: Compare(PartyCount(player), 0x0001);
            L0272: if (JumpBelowOrEqual) goto L0286;
            L0274: AddEncounter(player, 0x02, 0x1E);
            L0286: Compare(PartyCount(player), 0x0002);
            L0291: if (JumpBelowOrEqual) goto L02A5;
            L0293: AddEncounter(player, 0x03, 0x1C);
            L02A5: return; // RETURN (restoring si, di);
        }

        private void Fn_07(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x03);
            L0007: PushStack(player, ax);
0591  0008 C4 5E 06  les bx, [bp+0x6]
0594  000B 26 FF 5F 04  call far word [es:bx+0x4]
            L000F: cx = PopStack(player);
            L0010: cx = PopStack(player);
            L0011: RefreshCompareFlags(ax);
            L0013: if (JumpEqual) goto L0025;
            L0015: ShowMessage(player, String0BD2); // Hmm.  Broken bodkins, smashed short swords, damaged daggers: somebody fought a bunch of thieves here.  In fact, as memory serves, that somebody was you.
            L0022: goto L00D9;
            L0025: PushStack(player, 0x03);
            L0029: PushStack(player, ax);
            L002A: PushStack(player, ax);
05B4  002B C4 5E 06  les bx, [bp+0x6]
05B7  002E 26 FF 1F  call far word [es:bx]
05BA  0031 83 C4 06  add sp, 0x6
            L0034: ShowMessage(player, String0C6B); // Some thieves look up from their looting and decide to join the side of the unfriendlies!
            L0041: Compare(PartyCount(player), 0x0002);
            L004C: if (JumpBelowOrEqual) goto L005B;
            L004E: ShowMessage(player, String0CC4); // And some friends of theirs decide to help!
            L005B: PushStack(player, 0xBC);
            L005F: PushStack(player, 0x00);
            L0062: PushStack(player, ax);
            L0063: PushStack(player, ax);
            L0064: PushStack(player, 0xB8);
            L0068: PushStack(player, 0x8D);
05F5  006C C4 5E 06  les bx, [bp+0x6]
05F8  006F 26 FF 9F D8 00  call far word [es:bx+0xd8]
05FD  0074 83 C4 0C  add sp, 0xc
            L0077: AddEncounter(player, 0x01, 0x24);
            L0089: Compare(PartyCount(player), 0x0001);
            L0094: if (JumpBelowOrEqual) goto L00A8;
            L0096: AddEncounter(player, 0x02, 0x22);
            L00A8: Compare(PartyCount(player), 0x0002);
            L00B3: if (JumpBelowOrEqual) goto L00D9;
            L00B5: AddEncounter(player, 0x03, 0x24);
            L00C7: AddEncounter(player, 0x04, 0x22);
            L00D9: return; // RETURN;
        }

        private void Fn_08(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0x06), 0x0001);
            L0017: if (JumpEqual) goto L002F;
            L0019: Compare(GetFlag(player, 0x03, 0x0E), 0x0001);
            L002D: if (JumpNotEqual) goto L0042;
            L002F: ShowMessage(player, String0CEF); // A voice whispers from thin air....
06A0  003C B8 12 0D  mov ax, 0xd12
            L003F: goto L036A;
            L0042: ShowPortrait(player, 0x0015);
            L004F: SetFlag(player, 0x03, 0x0E, 0x01);
            L0064: SetFlag(player, 0x02, 0x00, 0x01);
            L0078: Compare(GetFlag(player, 0x02, 0x01), 0x0001);
            L008C: if (JumpEqual) goto L0091;
            L008E: goto L024D;
            L0091: PushStack(player, 0x02);
            L0095: PushStack(player, ax);
06FA  0096 C4 5E 06  les bx, [bp+0x6]
06FD  0099 26 FF 5F 04  call far word [es:bx+0x4]
            L009D: cx = PopStack(player);
            L009E: cx = PopStack(player);
            L009F: Compare(ax, 0x0001);
            L00A2: if (JumpEqual) goto L00A7;
            L00A4: goto L024D;
            L00A7: Compare(GetFlag(player, 0x02, 0x03), 0x0001);
            L00BB: if (JumpEqual) goto L00C0;
            L00BD: goto L024D;
            L00C0: Compare(GetFlag(player, 0x02, 0x05), 0x0001);
            L00D4: if (JumpEqual) goto L00D9;
            L00D6: goto L024D;
            L00D9: Compare(GetFlag(player, 0x02, 0x04), 0x0001);
            L00ED: if (JumpEqual) goto L00F2;
            L00EF: goto L024D;
            L00F2: RefreshCompareFlags(GetFlag(player, 0x02, 0x06));
            L0105: if (JumpEqual) goto L010A;
            L0107: goto L024D;
            L010A: RefreshCompareFlags(GetFlag(player, 0x03, 0x02));
            L011D: if (JumpNotEqual) goto L0122;
            L011F: goto L024D;
            L0122: PushStack(player, 0x03);
            L0126: PushStack(player, ax);
078B  0127 C4 5E 06  les bx, [bp+0x6]
078E  012A 26 FF 5F 04  call far word [es:bx+0x4]
            L012E: cx = PopStack(player);
            L012F: cx = PopStack(player);
            L0130: RefreshCompareFlags(ax);
            L0132: if (JumpNotEqual) goto L0137;
            L0134: goto L024D;
            L0137: RefreshCompareFlags(GetFlag(player, 0x03, 0x04));
            L014A: if (JumpNotEqual) goto L014F;
            L014C: goto L024D;
            L014F: RefreshCompareFlags(GetFlag(player, 0x03, 0x05));
            L0162: if (JumpNotEqual) goto L0167;
            L0164: goto L024D;
            L0167: RefreshCompareFlags(GetFlag(player, 0x03, 0x06));
            L017A: if (JumpNotEqual) goto L017F;
            L017C: goto L024D;
            L017F: RefreshCompareFlags(GetFlag(player, 0x03, 0x07));
            L0192: if (JumpNotEqual) goto L0197;
            L0194: goto L024D;
            L0197: ShowMessage(player, String0161); // *
            L01A4: ShowMessage(player, String0161); // *
            L01B1: ShowMessage(player, String0161); // *
            L01BE: ShowMessage(player, String0D4F); // 'Huzzah!  Thou hast done so well hitherto that I can safely reward thee.  I think me knowledge of the spell of shielding will best serve thee now.'
            L01CB: ShowMessage(player, String0DE3); // You realize that you now know that spell!
            L01D8: SetSpellLevel(player, 0x0F, 0x01);
            L01E9: SetFlag(player, 0x02, 0x06, 0x01);
            L01FE: RefreshCompareFlags(GetSkillLevel(player, 0x09));
            L020C: if (JumpEqual) goto L0211;
            L020E: goto L0374;
            L0211: RefreshCompareFlags(GetGuild(player));
            L021A: if (JumpEqual) goto L021F;
            L021C: goto L0374;
            L021F: ShowMessage(player, String0E0D); // Galatea draws you aside for a private message.
            L022C: ShowMessage(player, String0E3C); // 'I praise thee and acknowledge thee, child of innocence and slaughter.  And I reward thee with the skill of Stamina.'
            L0239: SetSkillLevel(player, 0x09, 0x01);
            L024A: goto L0374;
            L024D: RefreshCompareFlags(GetSkillLevel(player, 0x09));
            L025B: if (JumpEqual) goto L0260;
            L025D: goto L02E9;
            L0260: RefreshCompareFlags(GetGuild(player));
            L0269: if (JumpNotEqual) goto L02E9;
            L026B: RefreshCompareFlags(GetFlag(player, 0x03, 0x02));
            L027E: if (JumpEqual) goto L02E9;
            L0280: PushStack(player, 0x03);
            L0284: PushStack(player, ax);
08E9  0285 C4 5E 06  les bx, [bp+0x6]
08EC  0288 26 FF 5F 04  call far word [es:bx+0x4]
            L028C: cx = PopStack(player);
            L028D: cx = PopStack(player);
            L028E: RefreshCompareFlags(ax);
            L0290: if (JumpEqual) goto L02E9;
            L0292: RefreshCompareFlags(GetFlag(player, 0x03, 0x04));
            L02A5: if (JumpEqual) goto L02E9;
            L02A7: RefreshCompareFlags(GetFlag(player, 0x03, 0x05));
            L02BA: if (JumpEqual) goto L02E9;
            L02BC: RefreshCompareFlags(GetFlag(player, 0x03, 0x06));
            L02CF: if (JumpEqual) goto L02E9;
            L02D1: RefreshCompareFlags(GetFlag(player, 0x03, 0x07));
            L02E4: if (JumpEqual) goto L02E9;
            L02E6: goto L021F;
            L02E9: RefreshCompareFlags(GetGuild(player));
            L02F2: if (JumpNotEqual) goto L0306;
            L02F4: ShowMessage(player, String0E0D); // Galatea draws you aside for a private message.
0965  0301 B8 B2 0E  mov ax, 0xeb2
            L0304: goto L036A;
            L0306: PushStack(player, 0x00);
096D  0309 C4 5E 06  les bx, [bp+0x6]
0970  030C 26 FF 9F B0 00  call far word [es:bx+0xb0]
            L0311: cx = PopStack(player);
            L0312: RefreshCompareFlags(ax);
            L0314: if (JumpEqual) goto L0323;
            L0316: ShowMessage(player, String0F51); // Galatea pulls your party's barbarians aside for a few private words, and then returns.
            L0323: RefreshCompareFlags(GetFlag(player, 0x02, 0x73));
            L0336: if (JumpNotEqual) goto L0367;
            L0338: ShowMessage(player, String0FA8); // 'Thou art surviving, which is the important thing.  Take thee this item which mayhaps will help thee to continue doing so.'
            L0345: SetFlag(player, 0x02, 0x73, 0x01);
            L035A: PushStack(player, 0xBD);
09C2  035E C4 5E 06  les bx, [bp+0x6]
09C5  0361 26 FF 5F 48  call far word [es:bx+0x48]
            L0365: goto L0373;
            L0367: ShowMessage(player, String1024); // 'Thou hast earned no further rewards from me, flibbertigibbet!'
            L0374: return; // RETURN;
        }

        private void Fn_09(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0022);
            L0010: ShowMessage(player, String0161); // *
            L001D: ShowMessage(player, String0161); // *
            L002A: ShowMessage(player, String0161); // *
            L0037: Compare(GetFlag(player, 0x03, 0x0D), 0x0002);
            L004B: if (JumpEqual) goto L0063;
            L004D: Compare(GetFlag(player, 0x03, 0x0D), 0x0003);
            L0061: if (JumpNotEqual) goto L007F;
            L0063: ShowMessage(player, String1064); // A human thief shakes his head at you and whispers.
            L0070: ShowMessage(player, String1097); // 'Not now, friend.  I fear we're being watched.'
            L007D: goto L00D6;
            L007F: ShowMessage(player, String10C7); // A human thief jauntily looks you up and down.
            L008C: ShowMessage(player, String10F5); // 'I think me I have found a fellow quester.  Look, you, I dare not divulge all, nor can I abide whilst we convince each other of our bona fides, but I will give thee this hint:'
            L0099: ShowMessage(player, String11A6); // 'There was a sage who knew an elf Who knew a man, who knew myself, From whom I learned the sage once said That Malcolm's rest is colored red.'
            L00A6: Compare(GetFlag(player, 0x03, 0x0D), 0x0001);
            L00BA: if (JumpNotEqual) goto L00C1;
0A96  00BC B8 03 00  mov ax, 0x3
            L00BF: goto L00C4;
            L00C1: SetFlag(player, 0x03, 0x0D, 0x02);
            L00D6: return; // RETURN;
        }

        private void Fn_0A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x04));
            L0016: if (JumpEqual) goto L0028;
            L0018: ShowMessage(player, String06CC); // You see the remains of a massive and somehow familiar battle here.  By Jove!  You were the one that left this area in such an untidy state!
            L0025: goto L00F9;
            L0028: SetFlag(player, 0x03, 0x04, 0x03);
            L003D: ShowMessage(player, String0758); // With a cry of gleeful abandon, you are beset!
            L004A: Compare(PartyCount(player), 0x0002);
            L0055: if (JumpBelowOrEqual) goto L007B;
            L0057: AddEncounter(player, 0x03, 0x20);
            L0069: AddEncounter(player, 0x04, 0x20);
            L007B: PushStack(player, 0xBC);
            L007F: PushStack(player, 0x00);
            L0082: PushStack(player, ax);
            L0083: PushStack(player, ax);
            L0084: PushStack(player, 0xB8);
            L0088: PushStack(player, 0xA0);
0B3E  008C C4 5E 06  les bx, [bp+0x6]
0B41  008F 26 FF 9F D8 00  call far word [es:bx+0xd8]
0B46  0094 83 C4 0C  add sp, 0xc
            L0097: AddEncounter(player, 0x01, 0x19);
            L00A9: Compare(PartyCount(player), 0x0001);
            L00B4: if (JumpBelowOrEqual) goto L00C8;
            L00B6: AddEncounter(player, 0x02, 0x21);
            L00C8: Compare(PartyCount(player), 0x0002);
            L00D3: if (JumpBelowOrEqual) goto L00F9;
            L00D5: AddEncounter(player, 0x03, 0x20);
            L00E7: AddEncounter(player, 0x04, 0x20);
            L00F9: return; // RETURN;
        }

        private void Fn_0B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x05));
            L0016: if (JumpEqual) goto L0028;
            L0018: ShowMessage(player, String1235); // You remember this battlefield.  You slowly release a deep breath as you recall the bloodshed that happened here.
            L0025: goto L00CB;
            L0028: SetFlag(player, 0x03, 0x05, 0x03);
            L003D: ShowMessage(player, String12A6); // Once again into the breech!
            L004A: PushStack(player, 0xBC);
            L004E: PushStack(player, 0x00);
            L0051: PushStack(player, ax);
            L0052: PushStack(player, 0xCB);
            L0056: PushStack(player, 0x13);
            L005A: PushStack(player, 0xA0);
0C0B  005E C4 5E 06  les bx, [bp+0x6]
0C0E  0061 26 FF 9F D8 00  call far word [es:bx+0xd8]
0C13  0066 83 C4 0C  add sp, 0xc
            L0069: AddEncounter(player, 0x01, 0x1D);
            L007B: AddEncounter(player, 0x02, 0x1D);
            L008D: Compare(PartyCount(player), 0x0001);
            L0098: if (JumpBelowOrEqual) goto L00AC;
            L009A: AddEncounter(player, 0x03, 0x1D);
            L00AC: Compare(PartyCount(player), 0x0002);
            L00B7: if (JumpBelowOrEqual) goto L00CB;
            L00B9: AddEncounter(player, 0x04, 0x1B);
            L00CB: return; // RETURN;
        }

        private void Fn_0C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x06), 0x0002);
            L0017: if (JumpNotEqual) goto L001F;
0C93  0019 B8 C2 12  mov ax, 0x12c2
            L001C: goto L0103;
            L001F: RefreshCompareFlags(GetFlag(player, 0x03, 0x06));
            L0032: if (JumpEqual) goto L0037;
            L0034: goto L0100;
            L0037: SetFlag(player, 0x03, 0x06, 0x03);
            L004C: ShowMessage(player, String1312); // A well organized force of inhumans marches towards you.
            L0059: PushStack(player, 0xBC);
            L005D: PushStack(player, 0x00);
            L0060: PushStack(player, ax);
            L0061: PushStack(player, 0x4A);
            L0065: PushStack(player, 0xB8);
            L0069: PushStack(player, 0xA0);
0CE7  006D C4 5E 06  les bx, [bp+0x6]
0CEA  0070 26 FF 9F D8 00  call far word [es:bx+0xd8]
0CEF  0075 83 C4 0C  add sp, 0xc
            L0078: AddEncounter(player, 0x01, 0x19);
            L008A: AddEncounter(player, 0x02, 0x1A);
            L009C: AddEncounter(player, 0x03, 0x1F);
            L00AE: Compare(PartyCount(player), 0x0002);
            L00B9: if (JumpBelowOrEqual) goto L00CD;
            L00BB: AddEncounter(player, 0x04, 0x1A);
            L00CD: Compare(PartyCount(player), 0x0003);
            L00D8: if (JumpBelowOrEqual) goto L010D;
            L00DA: AddEncounter(player, 0x05, 0x1F);
            L00EC: AddEncounter(player, 0x06, 0x1F);
            L00FE: goto L010D;
            L0100: ShowMessage(player, String134A); // The stench of death still permeates this place.
            L010D: return; // RETURN;
        }

        private void Fn_0D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x06), 0x0003);
            L0017: if (JumpNotEqual) goto L002E;
            L0019: SetFlag(player, 0x03, 0x06, 0x01);
            L002E: return; // RETURN;
        }

        private void Fn_0E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0x60);
            L0011: if (JumpNotEqual) goto L002C;
            L0013: ShowMessage(player, String137A); // You find something useful discarded amongst the rubble.
            L0020: GiveItem(player, 0x60);
            L002C: return; // RETURN;
        }

        private void Fn_0F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0x07), 0x0001);
            L0017: if (JumpNotEqual) goto L0046;
            L0019: ShowMessage(player, String0161); // *
            L0026: ShowMessage(player, String0161); // *
            L0033: ShowMessage(player, String0161); // *
0E27  0040 B8 B2 13  mov ax, 0x13b2
            L0043: goto L00FB;
            L0046: Compare(HasUsedSkill(player, 0x0D), 0x0002);
            L0055: if (JumpNotBelow) goto L00C1;
            L0057: RefreshCompareFlags(HasUsedSpell(player, 0x17));
            L0065: if (JumpNotEqual) goto L00C1;
            L0067: PushStack(player, 0xA7);
            L006B: PushStack(player, ax);
0E53  006C C4 5E 06  les bx, [bp+0x6]
0E56  006F 26 FF 5F 54  call far word [es:bx+0x54]
            L0073: cx = PopStack(player);
            L0074: cx = PopStack(player);
            L0075: RefreshCompareFlags(ax);
            L0077: if (JumpNotEqual) goto L00C1;
            L0079: PushStack(player, 0x67);
            L007D: PushStack(player, ax);
0E65  007E C4 5E 06  les bx, [bp+0x6]
0E68  0081 26 FF 5F 54  call far word [es:bx+0x54]
            L0085: cx = PopStack(player);
            L0086: cx = PopStack(player);
            L0087: RefreshCompareFlags(ax);
            L0089: if (JumpNotEqual) goto L00C1;
            L008B: PushStack(player, 0x61);
            L008F: PushStack(player, ax);
0E77  0090 C4 5E 06  les bx, [bp+0x6]
0E7A  0093 26 FF 5F 54  call far word [es:bx+0x54]
            L0097: cx = PopStack(player);
            L0098: cx = PopStack(player);
            L0099: RefreshCompareFlags(ax);
            L009B: if (JumpNotEqual) goto L00C1;
            L009D: PushStack(player, 0x93);
            L00A1: PushStack(player, ax);
0E89  00A2 C4 5E 06  les bx, [bp+0x6]
0E8C  00A5 26 FF 5F 54  call far word [es:bx+0x54]
            L00A9: cx = PopStack(player);
            L00AA: cx = PopStack(player);
            L00AB: RefreshCompareFlags(ax);
            L00AD: if (JumpNotEqual) goto L00C1;
            L00AF: PushStack(player, 0x86);
            L00B3: PushStack(player, ax);
0E9B  00B4 C4 5E 06  les bx, [bp+0x6]
0E9E  00B7 26 FF 5F 54  call far word [es:bx+0x54]
            L00BB: cx = PopStack(player);
            L00BC: cx = PopStack(player);
            L00BD: RefreshCompareFlags(ax);
            L00BF: if (JumpEqual) goto L00F8;
            L00C1: ax = HasItem(player, 0xCF);
            L00CF: if (JumpNotEqual) goto L00F8;
            L00D1: SetFlag(player, 0x03, 0x0F, 0x01);
            L00E6: ShowMessage(player, String145C); // Whoa, Nessie!  As you tug from underneath this big pile of stuff, something remarkably intact goes sliding away.
0EDA  00F3 B8 CD 14  mov ax, 0x14cd
            L00F6: goto L00FB;
            L00F8: ShowMessage(player, String152D); // An unseemly pile of rubbish lies in the corner of this great room.
            L0105: return; // RETURN;
        }

        private void Fn_10(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0x07), 0x0001);
            L0017: if (JumpNotEqual) goto L001C;
            L0019: goto L00C8;
            L001C: ax = HasItem(player, 0xCF);
            L002A: if (JumpNotEqual) goto L002F;
            L002C: goto L00C8;
            L002F: ShowPortrait(player, 0x0019);
            L003C: ShowMessage(player, String0161); // *
            L0049: ShowMessage(player, String0161); // *
            L0056: ShowMessage(player, String0161); // *
            L0063: ShowMessage(player, String1570); // 'Be hanged, thou kidney brains, aye, thou puny piz - wait.  Can it be?  Hast thou found and returned to me my long lost doormat?'
            L0070: ShowMessage(player, String15F2); // The gnome takes the doormat with a tenderness exceeding the way most mothers handle their mewling and puking infants.  He pats a cloud of dust from it and lays it reverently upon the floor.
            L007D: RemoveItem(player, 0xCF);
            L0089: AddExperience(player, 0x00000BB8);
            L009A: ShowMessage(player, String16B0); // 'Words fail.  I am but a rock, unable to convey my great gratitude.  But allow me to attempt a small compensation for the risks thou hast undertaken for me, my lord.  This scroll will be useful for an adventurer such as thyself.  Take it, and with it, my undying gratitude.'
            L00A7: GiveItem(player, 0xA9);
            L00B3: SetFlag(player, 0x02, 0x07, 0x01);
            L00C8: return; // RETURN;
        }

        private void Fn_11(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x07), 0x0001);
            L0017: if (JumpNotEqual) goto L0050;
            L0019: ShowMessage(player, String0161); // *
            L0026: ShowMessage(player, String0161); // *
            L0033: ShowMessage(player, String0161); // *
            L0040: ShowMessage(player, String17C3); // 'Tis a tale told by an idiot, full of sound and fury, signifying nothing,' you quote to yourself, remembering the battle that happened here.
            L004D: goto L012F;
            L0050: Compare(GetFlag(player, 0x03, 0x07), 0x0002);
            L0064: if (JumpNotEqual) goto L006B;
101E  0066 B8 50 18  mov ax, 0x1850
            L0069: goto L0043;
            L006B: SetFlag(player, 0x03, 0x07, 0x03);
            L0080: ShowMessage(player, String1878); // This is another fine mess you've gotten yourself in to.
1045  008D B8 1E 02  mov ax, 0x21e
            L0090: PushStack(player, ax);
            L0091: PushStack(player, 0x00);
            L0094: PushStack(player, ax);
            L0095: PushStack(player, ax);
            L0096: PushStack(player, 0xCB);
            L009A: PushStack(player, 0xB9);
1056  009E C4 5E 06  les bx, [bp+0x6]
1059  00A1 26 FF 9F D8 00  call far word [es:bx+0xd8]
105E  00A6 83 C4 0C  add sp, 0xc
            L00A9: AddEncounter(player, 0x01, 0x25);
            L00BB: AddEncounter(player, 0x02, 0x25);
            L00CD: AddEncounter(player, 0x05, 0x26);
            L00DF: Compare(PartyCount(player), 0x0002);
            L00EA: if (JumpBelowOrEqual) goto L00FE;
            L00EC: AddEncounter(player, 0x06, 0x26);
            L00FE: Compare(PartyCount(player), 0x0003);
            L0109: if (JumpBelowOrEqual) goto L012F;
            L010B: AddEncounter(player, 0x03, 0x28);
            L011D: AddEncounter(player, 0x04, 0x28);
            L012F: return; // RETURN;
        }

        private void Fn_12(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x07), 0x0001);
            L0017: if (JumpNotEqual) goto L002E;
            L0019: SetFlag(player, 0x03, 0x07, 0x02);
            L002E: return; // RETURN;
        }

        private void Fn_13(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x02, 0x4B));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00F6;
            L001B: SetFlag(player, 0x02, 0x4B, 0x01);
            L0030: ShowPortrait(player, 0x000E);
            L003D: ShowMessage(player, String0161); // *
            L004A: ShowMessage(player, String0161); // *
            L0057: ShowMessage(player, String0161); // *
            L0064: ShowMessage(player, String18B0); // Hammers and tongs!  An enormous red dragon rears up and addresses to you.
            L0071: RefreshCompareFlags(GetFlag(player, 0x02, 0x4A));
            L0084: if (JumpNotEqual) goto L00B5;
            L0086: RefreshCompareFlags(GetFlag(player, 0x02, 0x54));
            L0099: if (JumpNotEqual) goto L00B5;
            L009B: RefreshCompareFlags(GetFlag(player, 0x02, 0x49));
            L00AE: if (JumpNotEqual) goto L00B5;
11C9  00B0 B8 FA 18  mov ax, 0x18fa
            L00B3: goto L00B8;
            L00B5: ShowMessage(player, String19C5); // 'Ah!  Wouldst hear another story from the life of Gwalter the Dim, green dragon?'
            L00C2: ShowMessage(player, String1A17); // You quickly nod.
            L00CF: ShowMessage(player, String1A28); // 'Gwalter the Dim, a very stupid dragon by red lights, went visiting a much brighter red dragon who lived in a cave near a clearing in the woods.  Gwalter came in to land, and could not stop himself in time:  base over apex, into the woods, clattering and crashing and thoroughly discommoding the passersby.'
            L00DC: ShowMessage(player, String1B5C); // 'Gwalter's friend rushed up to him and asked why he landed so badly.  Gwalter said, 'Tis your own fault for clearing such a short landing site, no matter how wide it is.'
            L00E9: ShowMessage(player, String1C07); // The dragon's guffaws reverberate throughout the room as he flies off.  Forcing laughter may have hurt, but being eaten would have hurt more.
            L00F6: return; // RETURN;
        }

        private void Fn_14(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0016);
            L0010: ShowMessage(player, String0161); // *
            L001D: ShowMessage(player, String0161); // *
            L002A: ShowMessage(player, String0161); // *
            L0037: ShowMessage(player, String1C94); // There's another desk here, with a human clad in some natty furs sitting behind it.
            L0044: Compare(GetFlag(player, 0x03, 0x02), 0x0001);
            L0058: if (JumpEqual) goto L005D;
            L005A: goto L0188;
            L005D: PushStack(player, 0x03);
            L0061: PushStack(player, ax);
1273  0062 C4 5E 06  les bx, [bp+0x6]
1276  0065 26 FF 5F 04  call far word [es:bx+0x4]
            L0069: cx = PopStack(player);
            L006A: cx = PopStack(player);
            L006B: Compare(ax, 0x0001);
            L006E: if (JumpEqual) goto L0073;
            L0070: goto L0188;
            L0073: Compare(GetFlag(player, 0x03, 0x04), 0x0001);
            L0087: if (JumpEqual) goto L008C;
            L0089: goto L0188;
            L008C: Compare(GetFlag(player, 0x03, 0x05), 0x0001);
            L00A0: if (JumpEqual) goto L00A5;
            L00A2: goto L0188;
            L00A5: Compare(GetFlag(player, 0x03, 0x06), 0x0001);
            L00B9: if (JumpEqual) goto L00BE;
            L00BB: goto L0188;
            L00BE: Compare(GetFlag(player, 0x03, 0x07), 0x0001);
            L00D2: if (JumpEqual) goto L00D7;
            L00D4: goto L0188;
            L00D7: ShowMessage(player, String1CE7); // 'By my stars and garters!  I have had my eye on thee, and that is quite a lot of unfriendlies thou hast eliminated.  I think me I have a special reward for such an enterprising soul as thyself.'
            L00E4: AddExperience(player, 0x000007D0);
            L00F5: GiveItem(player, 0xBD);
            L0101: ShowMessage(player, String1DAA); // 'Now don't go spending all that in one place, now. Hah!  I almost forgot!  There IS only one place to spend all that, hereabouts!'
            L010E: PushStack(player, 0x02);
            L0112: PushStack(player, ax);
            L0113: PushStack(player, 0x03);
1328  0117 C4 5E 06  les bx, [bp+0x6]
132B  011A 26 FF 1F  call far word [es:bx]
132E  011D 83 C4 06  add sp, 0x6
            L0120: PushStack(player, 0x02);
            L0124: PushStack(player, 0x03);
            L0128: PushStack(player, ax);
133A  0129 C4 5E 06  les bx, [bp+0x6]
133D  012C 26 FF 1F  call far word [es:bx]
1340  012F 83 C4 06  add sp, 0x6
            L0132: SetFlag(player, 0x03, 0x04, 0x02);
            L0147: SetFlag(player, 0x03, 0x05, 0x02);
            L015C: SetFlag(player, 0x03, 0x06, 0x02);
            L0171: SetFlag(player, 0x03, 0x07, 0x02);
            L0186: goto L0195;
            L0188: ShowMessage(player, String1E2D); // 'Ye'll have to do more than that in the way of cleaning up this place if ye want ME to reward ye!'
            L0195: return; // RETURN;
        }

        private void Fn_15(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x02);
            L0007: PushStack(player, 0x90);
            L000B: PushStack(player, 0x01);
            L000F: PushStack(player, ax);
13B8  0010 C4 5E 06  les bx, [bp+0x6]
13BB  0013 26 FF 9F BC 00  call far word [es:bx+0xbc]
13C0  0018 83 C4 08  add sp, 0x8
            L001B: return; // RETURN;
        }

        private void Fn_16(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFlag(player, 0x02, 0x52, 0x01);
            L0018: return; // RETURN;
        }

        private void Fn_17(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x0F), 0x0001);
            L0017: if (JumpNotEqual) goto L0053;
            L0019: GiveItem(player, 0xCF);
            L0025: SetFlag(player, 0x03, 0x0F, 0x00);
            L0039: SetFlag(player, 0x02, 0x07, 0x02);
142D  004E B8 90 1E  mov ax, 0x1e90
            L0051: goto L0062;
            L0053: Compare(GetFacing(player), 0x0003);
            L005D: if (JumpNotEqual) goto L006C;
            L005F: ShowMessage(player, String1EF0); // A huge and unhealthy looking pile or rubbish lies to the north.
            L006C: return; // RETURN;
        }

        private void Fn_18(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x0F), 0x0001);
            L0017: if (JumpNotEqual) goto L0053;
            L0019: GiveItem(player, 0xCF);
            L0025: SetFlag(player, 0x03, 0x0F, 0x00);
            L0039: SetFlag(player, 0x02, 0x07, 0x02);
149B  004E B8 90 1E  mov ax, 0x1e90
            L0051: goto L0061;
            L0053: RefreshCompareFlags(GetFacing(player));
            L005C: if (JumpNotEqual) goto L006B;
            L005E: ShowMessage(player, String1F30); // A huge and unhealthy looking pile or rubbish lies to the west.  It's smelly, too.  Be grateful you don't have the new NoseBlaster card in your computer.
            L006B: return; // RETURN;
        }

        private void Fn_27(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: ShowPortrait(player, 0x0042);
            L0011: si = 0;
            L0013: Compare(GetFlag(player, 0x03, 0x08), 0x0004);
            L0027: if (JumpNotBelow) goto L006F;
            L0029: si = GetFlag(player, 0x03, 0x08);
            L003C: ShowMessage(player, String1FC9); // The magic of the cool waters heals your wounds.
            L0049: HealPlayer(player, GetMaxHits(player));
            L005A: si = si + 1;
            L005B: SetFlag(player, 0xC4, 0xB8, si);
            L006D: goto L007C;
            L006F: ShowMessage(player, String1FF9); // The waters offer no refreshment.
            L007C: return; // RETURN (restoring si);
        }

        private void Fn_28(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: ShowPortrait(player, 0x0042);
            L0011: si = 0;
            L0013: Compare(GetFlag(player, 0x03, 0x0A), 0x0004);
            L0027: if (JumpNotBelow) goto L006B;
            L0029: si = GetFlag(player, 0x03, 0x0A);
            L003C: ShowMessage(player, String201A); // The magic of the cool waters restores your mana.
            L0049: AddMana(player, 0x03E8);
            L0056: si = si + 1;
            L0057: SetFlag(player, 0xC4, 0xB8, si);
            L0069: goto L0078;
            L006B: ShowMessage(player, String1FF9); // The waters offer no refreshment.
            L0078: return; // RETURN (restoring si);
        }

        private void Fn_29(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: ShowPortrait(player, 0x0042);
            L0011: si = 0;
            L0013: Compare(GetFlag(player, 0x03, 0x0B), 0x0004);
            L0027: if (JumpNotBelow) goto L006B;
            L0029: si = GetFlag(player, 0x03, 0x0B);
            L003C: ShowMessage(player, String201A); // The magic of the cool waters restores your mana.
            L0049: AddMana(player, 0x03E8);
            L0056: si = si + 1;
            L0057: SetFlag(player, 0xC4, 0xB8, si);
            L0069: goto L0078;
            L006B: ShowMessage(player, String1FF9); // The waters offer no refreshment.
            L0078: return; // RETURN (restoring si);
        }

        private void Fn_2A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: ShowPortrait(player, 0x0042);
            L0011: si = 0;
            L0013: Compare(GetFlag(player, 0x03, 0x09), 0x0004);
            L0027: if (JumpNotBelow) goto L006F;
            L0029: si = GetFlag(player, 0x03, 0x09);
            L003C: ShowMessage(player, String1FC9); // The magic of the cool waters heals your wounds.
            L0049: HealPlayer(player, GetMaxHits(player));
            L005A: si = si + 1;
            L005B: SetFlag(player, 0xC4, 0xB8, si);
            L006D: goto L007C;
            L006F: ShowMessage(player, String1FF9); // The waters offer no refreshment.
            L007C: return; // RETURN (restoring si);
        }

        private void Fn_33(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x02), 0x0003);
            L0017: if (JumpNotEqual) goto L002E;
            L0019: SetFlag(player, 0x03, 0x02, 0x01);
            L002E: return; // RETURN;
        }

        private void Fn_34(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x03);
            L0007: PushStack(player, ax);
1754  0008 C4 5E 06  les bx, [bp+0x6]
1757  000B 26 FF 5F 04  call far word [es:bx+0x4]
            L000F: cx = PopStack(player);
            L0010: cx = PopStack(player);
            L0011: Compare(ax, 0x0003);
            L0014: if (JumpNotEqual) goto L0028;
            L0016: PushStack(player, 0x01);
            L001A: PushStack(player, 0x03);
            L001E: PushStack(player, ax);
176B  001F C4 5E 06  les bx, [bp+0x6]
176E  0022 26 FF 1F  call far word [es:bx]
1771  0025 83 C4 06  add sp, 0x6
            L0028: return; // RETURN;
        }

        private void Fn_35(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x04), 0x0003);
            L0017: if (JumpNotEqual) goto L002E;
            L0019: SetFlag(player, 0x03, 0x04, 0x01);
            L002E: return; // RETURN;
        }

        private void Fn_36(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x05), 0x0003);
            L0017: if (JumpNotEqual) goto L002E;
            L0019: SetFlag(player, 0x03, 0x05, 0x01);
            L002E: return; // RETURN;
        }

        private void Fn_37(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x06), 0x0003);
            L0017: if (JumpNotEqual) goto L002E;
            L0019: SetFlag(player, 0x03, 0x06, 0x01);
            L002E: return; // RETURN;
        }

        private void Fn_38(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x07), 0x0003);
            L0017: if (JumpNotEqual) goto L002E;
            L0019: SetFlag(player, 0x03, 0x07, 0x01);
            L002E: return; // RETURN;
        }

    }
}
