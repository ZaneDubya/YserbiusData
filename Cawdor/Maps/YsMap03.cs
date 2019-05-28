#pragma warning disable
using System.Collections.Generic;
using XPT.WorldData;
using XPT.WorldData.Yserbius;

namespace XPT.Scripts.Yserbius.Maps {
    class YserMap03 : AMapScripted {
        protected override int MapIndex => 3;
        protected override int RandomEncounterChance => 10;
        protected override int RandomEncounterExtraCount => 0;

        public YserMap03() {
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
            MapEvent11 = Fn_11;
            MapEvent12 = Fn_12;
            MapEvent15 = Fn_15;
            MapEvent1E = Fn_1E;
            MapEvent1F = Fn_1F;
            MapEvent20 = Fn_20;
            MapEvent21 = Fn_21;
            MapEvent22 = Fn_22;
            MapEvent23 = Fn_23;
            MapEvent24 = Fn_24;
            MapEvent25 = Fn_25;
            MapEvent26 = Fn_26;
            MapEvent2B = Fn_2B;
            MapEvent2C = Fn_2C;
            MapEvent2D = Fn_2D;
            MapEvent2E = Fn_2E;
            MapEvent2F = Fn_2F;
        }
        
        // === Strings ================================================
        private const string String0140 = "This way to the Foyer of Cawdor.";
        private const string String0161 = "'Impressive.  Thou hast proven thyself far too lucky to be other than skilled.  I guess the best thing to do is give you something else exemplifying a ranger.'";
        private const string String0201 = "Welcome back.  But you will have to do a bit more if you expect another hunting bow out of me.";
        private const string String0260 = "The elf smiles at you and writes something in a log book on the desk.  'Lost again?'  Suddenly that smile doesn't seem very friendly.";
        private const string String02E6 = "An elvish ranger scopes you out from behind a cluttered desk, picks up a well-frayed script, and begins reciting.";
        private const string String0358 = "'Well met, friend.  These are the ranger proving grounds.  An thou shows thy worth through thy canny cunning and the skill that epitomizes rangers, to wit, tracking, then mayhaps I shall reward thee.";
        private const string String0420 = "If thou art nobly skilled, then thou shalt find me not unstinting.  An thou proves thyself to be easily derailed, which is to say thrown off track, then thou shalt receive naught.'";
        private const string String04D5 = "You find some hairs that have scraped off something heading to the east. ";
        private const string String051F = "Spoor.  Palpable spoor!";
        private const string String0537 = "You wish someone would do something about all the nasty litterbugs around here.";
        private const string String0587 = "You remember following these tracks before.";
        private const string String05B3 = "The floor is filled with fur left over from your recent battle here.";
        private const string String05F8 = "It looks like something nested here recently, but fled at your approach.";
        private const string String0641 = "With a bullish bellow you are beset!";
        private const string String0666 = "You hear some footsteps running away.";
        private const string String068C = "You hear some footsteps running towards you.";
        private const string String06B9 = "Ah, yes, 'tis another halfling mob.  But Rory will never again greet you here.";
        private const string String0708 = "*";
        private const string String070A = "A huge unruly mob of halflings runs past you.  One of them falls out and talks briefly.";
        private const string String0762 = "'Felicitations, salutations.  Would there perchance be an opening in your party for an industrious and upright - OOPS!'";
        private const string String07DA = "He turns and runs, followed soon thereafter by a low flying dragon.";
        private const string String081E = "You find a few slightly singed halflings.";
        private const string String0848 = "The dragon inhales deeply, preparatory to breathing on you, but pauses.";
        private const string String0890 = "'I remember you from somewhere.  The egg!  I managed to get it back.  But this time it's GOLD.  Worth far more than mere eggs.  Beware of halflings, is all I can say!  Must fly!  Be seeing you.";
        private const string String0952 = "'I beg your pardon.  Some horrid halfling stole gold piece 184,293 from my horde.  It was one of my favorites, and I want it back.  I can tell by smell that you are not the thief.  Or at least that thief.  Be warned!  I'll be watching you!";
        private const string String0A42 = "'Ah!  Civilized companionship at last.  I say, would you fellows be able to sell me a small bite to eat?'  He holds up a large gold coin, with 184,293 stamped on it.";
        private const string String0AE8 = "You hear some nearby halfling screams.  This halfling shudders visibly.";
        private const string String0B30 = "'I do believe that is my call.  Perhaps we can do business some other time, wyrm willing.'";
        private const string String0B8B = "The halfling carefully slinks away in the opposite direction.";
        private const string String0BC9 = "A somewhat battered gang o'gremlins decides, rather insultingly, that they are bigger than you are.";
        private const string String0C2D = "Hmm.  Broken bodkins, smashed short swords, damaged daggers: somebody fought a bunch of thieves here.  In fact, as memory serves, that somebody was you.";
        private const string String0CC6 = "Be hanged! Those tracks were hard to follow because they were made by some fairly skillful thieves!Alas, t'will serve naught but to fight it out.";
        private const string String0D58 = "No matter how many of them there are.";
        private const string String0D7E = "Whoever was just here beat a strategic withdrawal. Perhaps you should try to act more rangerly to catch up with them.";
        private const string String0DF4 = "A voice whispers from thin air....";
        private const string String0E17 = "'Prithee pardon, but there is naught I can do for thee here and now.'";
        private const string String0E5D = "'Huzzah!  Thou hast done so well hitherto that I can safely reward thee.  I think me knowledge of the spell of shielding will best serve thee now.'";
        private const string String0EF1 = "You realize that you now know that spell!";
        private const string String0F1B = "Galatea takes you aside so that only you can hear her remarks.";
        private const string String0F5A = "'Well met, honored hunter!  May thy arrows fly swift and true.  An thou dost continue on this, the quest for my salvation, then I think me the skill of binding will serve thee well.'";
        private const string String1011 = "'Thou hast already received all the rewards thou hast earned and that I can safely grant thee here, lest my sisters notice and suspect the usage of my power.'";
        private const string String10B0 = "Galatea pulls your party's rangers aside for a few private words, and then returns.";
        private const string String1104 = "'Thou art surviving, which is the important thing.  Take thee this item which mayhaps will help thee to continue doing so.'";
        private const string String1180 = "'Thou hast earned no further rewards from me, piglet.'";
        private const string String11B7 = "A human thief skeptically examines you.";
        private const string String11DF = "'Galatea is indeed testing my limits if she thinks I will gladly and fully aid such as thyself.  Naetheless, I have my orders, and will obey.  Attend:'";
        private const string String1277 = "'Glamis's bane was no swimmer.'";
        private const string String1297 = "'Tis all, tis enough: begone!'";
        private const string String12B6 = "Hmm.  Wounded whiskers, cracked claws, and fricassed fur suggests someone fought some big cats here. Ring any bells?";
        private const string String132B = "The good news is you caught those cats.  The bad news is that you were only tracking a fraction of them, and didn't notice their master's tracks at all.";
        private const string String13C4 = "And the really bad news is that their masters were waiting for you with fireballs!";
        private const string String1417 = "You remember the waves of foes that you fought here.  You were lucky to survive; aye, and skillful, too.";
        private const string String1480 = "Damnation, but there are a lot of them!";
        private const string String14A8 = "Make that an awful lot of them.";
        private const string String14C8 = "Judging from the smell, you deftly managed to avoid walking into a huge band of orcs.  Lucky you.";
        private const string String152A = "An old soldier always revisits his battlegrounds with nostalgia, but this battle was too recent for you to recall it fondly.";
        private const string String15A7 = "You wanted them.  Now you get them.";
        private const string String15CB = "The stench of death still permeates this place.";
        private const string String15FB = "You find something useful discarded amongst the rubble.";
        private const string String1633 = "By all the felines and canines!  An enormous red dragon rears up and speaks to you.";
        private const string String1687 = "'Hmm.  There are two ways this could go.  We could have similar senses of humor, and part friends, or I could just eat thee.  So.  Wouldst hear a joke about a stupid green dragon named Gwalter the Dim?'";
        private const string String1752 = "'Ah!  I remember thee.  As I recall, thou didst enjoy my last joke.  Wouldst thou hear another?'";
        private const string String17B3 = "You quickly nod.";
        private const string String17C4 = "'Gwalter was dim, but doughty.  Did you ever hear how he defeated all the knights of King Arthur's round table?  He demanded a great ransom from Arthur, lest he eat that good monarch.  Arthur told Gwalter that his ransom was on the corner of the table.  Gwalter looked for weeks, and Arthur made his escape.  Get it?'";
        private const string String1902 = "You laugh politely.";
        private const string String1916 = "'Good enough.  But remember; 'tis only the green drakes that exhibit such stupidity.  I shall remember thee.'";
        private const string String1984 = "The dragon departs.";
        private const string String1998 = "You smile, grimly: you, at least, walked away from this killing place.";
        private const string String19DF = "Someone's darned untidy, leaving corpses all over the place like this.";
        private const string String1A26 = "Just once you wish you weren't outnumbered.";
        private const string String1A52 = "I have good news and bad news.  By wandering around making so much noise you convinced the occupants that you were too tough to fight.  Yes, that is both the good news and the bad news.";
        private const string String1B0C = "You find some hairs that have scraped off something heading to the south. ";
        private const string String1B57 = "It's messes like this that will lead to the invention of the vacuum cleaner.";
        private const string String1BA4 = "To continue following these tracks, go west, young man!  Or woman, dwarf, troll, or whatever the case may be.";
        private const string String1C12 = "What an untidy floor.";
        private const string String1C28 = "View halloo!  They are just north of you!";
        private const string String1C52 = "You find some slender scratches indicating some ferocious felines were heading north.";
        private const string String1CA8 = "The stone floor seems smoother than usual around here.";
        private const string String1CDF = "You find some slender scratches indicating some ferocious felines were heading eastward.";
        private const string String1D38 = "You remember following these paw prints before.";
        private const string String1D68 = "You find some faint marks indicating a small mixed force recently moved stealthily northwards from here. ";
        private const string String1DD2 = "Funny.  The wall is slightly discolored here.";
        private const string String1E00 = "These eastbound tracks are easily followed.  'I wonder an they be a small army, incapable of moving in obscurement, or doughty warriors hoping to lure us into a fatal attack,' you think to yourself.";
        private const string String1EC7 = "'Or maybe 'tis but a bluff.'";
        private const string String1EE4 = "And you know, palping all this spoor is beginning to disgust you a bit.";
        private const string String1F2C = "You stumble slightly.";
        private const string String1F42 = "After much chin rubbing, pate scratching, and head shaking, your party's tracker decides that recently someone moved south from here.  And moved well.";
        private const string String1FD9 = "This is not easy to interpret, but you finally decide that the frayed thread you found indicates a party moving south.";
        private const string String2050 = "You think you - naw, you didn't.";
        private const string String2071 = "A large group of people made these northbound tracks.";
        
        // === Functions ================================================
        private void Fn_01(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFlag(player, 0x02, 0x4E, 0x01);
            L0018: Compare(GetFacing(player), 0x0001);
            L0022: if (JumpNotEqual) goto L0031;
            L0024: ShowMessage(player, String0140); // This way to the Foyer of Cawdor.
            L0031: return; // RETURN;
        }

        private void Fn_02(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x001F);
            L0010: RefreshCompareFlags(GetFlag(player, 0x03, 0x02));
            L0023: if (JumpNotEqual) goto L0028;
            L0025: goto L00DE;
            L0028: PushStack(player, 0x03);
            L002C: PushStack(player, ax);
0067  002D C4 5E 06  les bx, [bp+0x6]
006A  0030 26 FF 5F 04  call far word [es:bx+0x4]
            L0034: cx = PopStack(player);
            L0035: cx = PopStack(player);
            L0036: RefreshCompareFlags(ax);
            L0038: if (JumpNotEqual) goto L003D;
            L003A: goto L00DE;
            L003D: RefreshCompareFlags(GetFlag(player, 0x03, 0x04));
            L0050: if (JumpNotEqual) goto L0055;
            L0052: goto L00DE;
            L0055: RefreshCompareFlags(GetFlag(player, 0x03, 0x05));
            L0068: if (JumpEqual) goto L00DE;
            L006A: RefreshCompareFlags(GetFlag(player, 0x03, 0x06));
            L007D: if (JumpEqual) goto L00DE;
            L007F: RefreshCompareFlags(GetFlag(player, 0x03, 0x07));
            L0092: if (JumpEqual) goto L00DE;
            L0094: RefreshCompareFlags(GetFlag(player, 0x03, 0x12));
            L00A7: if (JumpNotEqual) goto L00D9;
            L00A9: ShowMessage(player, String0161); // 'Impressive.  Thou hast proven thyself far too lucky to be other than skilled.  I guess the best thing to do is give you something else exemplifying a ranger.'
            L00B6: GiveItem(player, 0x3B);
            L00C2: SetFlag(player, 0x03, 0x12, 0x01);
            L00D7: goto L0132;
0113  00D9 B8 01 02  mov ax, 0x201
            L00DC: goto L0128;
            L00DE: Compare(GetFlag(player, 0x03, 0x01), 0x0001);
            L00F2: if (JumpNotEqual) goto L00F9;
012E  00F4 B8 60 02  mov ax, 0x260
            L00F7: goto L0128;
            L00F9: PushStack(player, 0x01);
            L00FD: PushStack(player, ax);
            L00FE: PushStack(player, 0x03);
013C  0102 C4 5E 06  les bx, [bp+0x6]
013F  0105 26 FF 1F  call far word [es:bx]
0142  0108 83 C4 06  add sp, 0x6
            L010B: ShowMessage(player, String02E6); // An elvish ranger scopes you out from behind a cluttered desk, picks up a well-frayed script, and begins reciting.
            L0118: ShowMessage(player, String0358); // 'Well met, friend.  These are the ranger proving grounds.  An thou shows thy worth through thy canny cunning and the skill that epitomizes rangers, to wit, tracking, then mayhaps I shall reward thee.
            L0125: ShowMessage(player, String0420); // If thou art nobly skilled, then thou shalt find me not unstinting.  An thou proves thyself to be easily derailed, which is to say thrown off track, then thou shalt receive naught.'
            L0132: return; // RETURN;
        }

        private void Fn_03(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x02));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00AC;
            L001B: Compare(HasUsedSkill(player, 0x0B), 0x0001);
            L002A: if (JumpNotBelow) goto L0062;
            L002C: PushStack(player, 0xA6);
            L0030: PushStack(player, ax);
019F  0031 C4 5E 06  les bx, [bp+0x6]
01A2  0034 26 FF 5F 54  call far word [es:bx+0x54]
            L0038: cx = PopStack(player);
            L0039: cx = PopStack(player);
            L003A: RefreshCompareFlags(ax);
            L003C: if (JumpNotEqual) goto L0062;
            L003E: PushStack(player, 0x62);
            L0042: PushStack(player, ax);
01B1  0043 C4 5E 06  les bx, [bp+0x6]
01B4  0046 26 FF 5F 54  call far word [es:bx+0x54]
            L004A: cx = PopStack(player);
            L004B: cx = PopStack(player);
            L004C: RefreshCompareFlags(ax);
            L004E: if (JumpNotEqual) goto L0062;
            L0050: PushStack(player, 0x8F);
            L0054: PushStack(player, ax);
01C3  0055 C4 5E 06  les bx, [bp+0x6]
01C6  0058 26 FF 5F 54  call far word [es:bx+0x54]
            L005C: cx = PopStack(player);
            L005D: cx = PopStack(player);
            L005E: RefreshCompareFlags(ax);
            L0060: if (JumpEqual) goto L0078;
            L0062: ShowMessage(player, String04D5); // You find some hairs that have scraped off something heading to the east. 
            L006F: PushStack(player, 0x01);
01E1  0073 B8 0B 00  mov ax, 0xb
            L0076: goto L00D6;
            L0078: Compare(GetFlag(player, 0x03, 0x0B), 0x0001);
            L008C: if (JumpNotEqual) goto L009D;
            L008E: ShowMessage(player, String051F); // Spoor.  Palpable spoor!
            L009B: goto L00E4;
            L009D: ShowMessage(player, String0537); // You wish someone would do something about all the nasty litterbugs around here.
            L00AA: goto L00E4;
            L00AC: ShowMessage(player, String0587); // You remember following these tracks before.
            L00B9: Compare(GetFlag(player, 0x03, 0x02), 0x0003);
            L00CD: if (JumpNotEqual) goto L00E4;
            L00CF: SetFlag(player, 0x03, 0x02, 0x01);
            L00E4: return; // RETURN;
        }

        private void Fn_04(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFlag(player, 0x03, 0x0B, 0x00);
            L0017: Compare(GetFlag(player, 0x03, 0x02), 0x0003);
            L002B: if (JumpNotEqual) goto L0042;
            L002D: SetFlag(player, 0x03, 0x02, 0x01);
            L0042: return; // RETURN;
        }

        private void Fn_05(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x02));
            L0016: if (JumpEqual) goto L0028;
            L0018: ShowMessage(player, String05B3); // The floor is filled with fur left over from your recent battle here.
            L0025: goto L00F4;
            L0028: RefreshCompareFlags(GetFlag(player, 0x03, 0x0B));
            L003B: if (JumpNotEqual) goto L0042;
02D5  003D B8 F8 05  mov ax, 0x5f8
            L0040: goto L001B;
            L0042: SetFlag(player, 0x03, 0x02, 0x03);
            L0057: ShowMessage(player, String0641); // With a bullish bellow you are beset!
            L0064: PushStack(player, 0x7D);
            L0068: PushStack(player, 0x00);
            L006B: PushStack(player, ax);
            L006C: PushStack(player, ax);
            L006D: PushStack(player, 0xCB);
            L0071: PushStack(player, 0xA0);
030D  0075 C4 5E 06  les bx, [bp+0x6]
0310  0078 26 FF 9F D8 00  call far word [es:bx+0xd8]
0315  007D 83 C4 0C  add sp, 0xc
            L0080: AddEncounter(player, 0x01, 0x19);
            L0092: AddEncounter(player, 0x02, 0x20);
            L00A4: Compare(PartyCount(player), 0x0001);
            L00AF: if (JumpBelowOrEqual) goto L00C3;
            L00B1: AddEncounter(player, 0x05, 0x20);
            L00C3: Compare(PartyCount(player), 0x0002);
            L00CE: if (JumpBelowOrEqual) goto L00F4;
            L00D0: AddEncounter(player, 0x04, 0x28);
            L00E2: AddEncounter(player, 0x06, 0x1F);
            L00F4: return; // RETURN;
        }

        private void Fn_06(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si, di);
            L0005: di = 0;
            L0007: si = 0;
            L0009: ax = GetFlag(player, 0x03, 0x08);
03A8  001A 8B F8  mov di, ax
03AA  001C 47     inc di
03AB  001D 8B F7  mov si, di
            L001F: Compare(si, 0x13);
            L0022: if (JumpLessOrEqual) goto L002B;
03B2  0024 8B C6  mov ax, si
            L0026: si = ax + 0xFFEC;
            L002B: Compare(si, 0x0E);
            L002E: if (JumpLessOrEqual) goto L0037;
03BE  0030 8B C6  mov ax, si
            L0032: si = ax + 0xFFF1;
            L0037: Compare(si, 0x09);
            L003A: if (JumpLessOrEqual) goto L0043;
03CA  003C 8B C6  mov ax, si
            L003E: si = ax + 0xFFF6;
            L0043: Compare(si, 0x04);
            L0046: if (JumpLessOrEqual) goto L004F;
03D6  0048 8B C6  mov ax, si
            L004A: si = ax + 0xFFFB;
03DD  004F 0B F6  or si, si
03DF  0051 7D 02  jge 0x55
            L0053: si = 0;
            L0055: Compare(si, 0x1D);
            L0058: if (JumpLessOrEqual) goto L005C;
            L005A: si = 0;
03EA  005C 83 FF 18  cmp di, 0x18
            L005F: if (JumpLessOrEqual) goto L0063;
            L0061: di = 0;
03F1  0063 57     push di
            L0064: PushStack(player, 0x08);
            L0068: PushStack(player, 0x03);
03FA  006C C4 5E 06  les bx, [bp+0x6]
03FD  006F 26 FF 1F  call far word [es:bx]
0400  0072 83 C4 06  add sp, 0x6
0403  0075 83 FF 1A  cmp di, 0x1a
            L0078: if (JumpNotEqual) goto L007F;
0408  007A B8 01 00  mov ax, 0x1
            L007D: goto L0081;
            L007F: PushStack(player, 0x00);
0410  0082 83 FF 14  cmp di, 0x14
            L0085: if (JumpNotEqual) goto L008C;
0415  0087 B8 01 00  mov ax, 0x1
            L008A: goto L008E;
041A  008C 33 C0  xor ax, ax
            L008E: dx = PopStack(player);
041D  008F 0B D0  or dx, ax
            L0091: PushStack(player, dx);
0420  0092 83 FF 0E  cmp di, 0xe
            L0095: if (JumpNotEqual) goto L009C;
0425  0097 B8 01 00  mov ax, 0x1
            L009A: goto L009E;
042A  009C 33 C0  xor ax, ax
            L009E: dx = PopStack(player);
042D  009F 0B D0  or dx, ax
            L00A1: PushStack(player, dx);
0430  00A2 83 FF 08  cmp di, 0x8
            L00A5: if (JumpNotEqual) goto L00AC;
0435  00A7 B8 01 00  mov ax, 0x1
            L00AA: goto L00AE;
043A  00AC 33 C0  xor ax, ax
            L00AE: dx = PopStack(player);
043D  00AF 0B D0  or dx, ax
            L00B1: PushStack(player, dx);
0440  00B2 83 FF 02  cmp di, 0x2
            L00B5: if (JumpNotEqual) goto L00BC;
0445  00B7 B8 01 00  mov ax, 0x1
            L00BA: goto L00BE;
044A  00BC 33 C0  xor ax, ax
            L00BE: dx = PopStack(player);
044D  00BF 0B D0  or dx, ax
            L00C1: if (JumpNotEqual) goto L00C6;
            L00C3: goto L0357;
            L00C6: bx = si;
            L00C8: Compare(bx, 0x04);
            L00CB: if (JumpBelowOrEqual) goto L00D0;
            L00CD: goto L0357;
            L00D0: switch (bx) {
                case 0:
                    goto L00D7;
                case 1:
                    goto L00E7;
                case 2:
                    goto L0163;
                case 3:
                    goto L0256;
                case 4:
                    goto L02B7;
            }
            L00D7: ShowMessage(player, String0666); // You hear some footsteps running away.
            L00E4: goto L0357;
            L00E7: ShowMessage(player, String068C); // You hear some footsteps running towards you.
            L00F4: Compare(GetFlag(player, 0x02, 0x47), 0x0001);
            L0108: if (JumpNotEqual) goto L010F;
0498  010A B8 B9 06  mov ax, 0x6b9
            L010D: goto L00DA;
            L010F: ShowPortrait(player, 0x0025);
            L011C: ShowMessage(player, String0708); // *
            L0129: ShowMessage(player, String0708); // *
            L0136: ShowMessage(player, String0708); // *
            L0143: ShowMessage(player, String070A); // A huge unruly mob of halflings runs past you.  One of them falls out and talks briefly.
            L0150: ShowMessage(player, String0762); // 'Felicitations, salutations.  Would there perchance be an opening in your party for an industrious and upright - OOPS!'
04EB  015D B8 DA 07  mov ax, 0x7da
            L0160: goto L00DA;
            L0163: Compare(GetFlag(player, 0x03, 0x09), 0x0001);
            L0177: if (JumpEqual) goto L018D;
            L0179: RefreshCompareFlags(GetFlag(player, 0x03, 0x00));
            L018B: if (JumpEqual) goto L0193;
051B  018D B8 1E 08  mov ax, 0x81e
            L0190: goto L00DA;
            L0193: ShowPortrait(player, 0x000E);
            L01A0: ShowMessage(player, String0848); // The dragon inhales deeply, preparatory to breathing on you, but pauses.
            L01AD: Compare(GetFlag(player, 0x02, 0x4C), 0x0001);
            L01C1: if (JumpNotEqual) goto L01EF;
            L01C3: ShowMessage(player, String0708); // *
            L01D0: ShowMessage(player, String0708); // *
            L01DD: ShowMessage(player, String0708); // *
0578  01EA B8 90 08  mov ax, 0x890
            L01ED: goto L0219;
            L01EF: ShowMessage(player, String0708); // *
            L01FC: ShowMessage(player, String0708); // *
            L0209: ShowMessage(player, String0708); // *
            L0216: ShowMessage(player, String0952); // 'I beg your pardon.  Some horrid halfling stole gold piece 184,293 from my horde.  It was one of my favorites, and I want it back.  I can tell by smell that you are not the thief.  Or at least that thief.  Be warned!  I'll be watching you!
            L0223: Compare(GetFlag(player, 0x03, 0x09), 0x0002);
            L0237: if (JumpNotEqual) goto L023E;
05C7  0239 B8 03 00  mov ax, 0x3
            L023C: goto L0241;
            L023E: SetFlag(player, 0x03, 0x09, 0x01);
            L0253: goto L0357;
            L0256: ShowPortrait(player, 0x0025);
            L0263: ShowMessage(player, String0708); // *
            L0270: ShowMessage(player, String0708); // *
            L027D: ShowMessage(player, String0708); // *
            L028A: ShowMessage(player, String0A42); // 'Ah!  Civilized companionship at last.  I say, would you fellows be able to sell me a small bite to eat?'  He holds up a large gold coin, with 184,293 stamped on it.
            L0297: ShowMessage(player, String0AE8); // You hear some nearby halfling screams.  This halfling shudders visibly.
            L02A4: ShowMessage(player, String0B30); // 'I do believe that is my call.  Perhaps we can do business some other time, wyrm willing.'
063F  02B1 B8 8B 0B  mov ax, 0xb8b
            L02B4: goto L00DA;
            L02B7: ShowMessage(player, String0708); // *
            L02C4: ShowMessage(player, String0708); // *
            L02D1: ShowMessage(player, String0708); // *
            L02DE: ShowMessage(player, String0BC9); // A somewhat battered gang o'gremlins decides, rather insultingly, that they are bigger than you are.
            L02EB: PushStack(player, 0x5D);
            L02EF: PushStack(player, 0x00);
            L02F2: PushStack(player, ax);
            L02F3: PushStack(player, ax);
            L02F4: PushStack(player, 0xB6);
            L02F8: PushStack(player, 0xBD);
068A  02FC C4 5E 06  les bx, [bp+0x6]
068D  02FF 26 FF 9F D8 00  call far word [es:bx+0xd8]
0692  0304 83 C4 0C  add sp, 0xc
            L0307: AddEncounter(player, 0x01, 0x23);
            L0319: Compare(PartyCount(player), 0x0001);
            L0324: if (JumpBelowOrEqual) goto L0338;
            L0326: AddEncounter(player, 0x02, 0x1A);
            L0338: Compare(PartyCount(player), 0x0002);
            L0343: if (JumpBelowOrEqual) goto L0357;
            L0345: AddEncounter(player, 0x03, 0x23);
            L0357: return; // RETURN (restoring si, di);
        }

        private void Fn_07(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x0C), 0x0001);
            L0017: if (JumpEqual) goto L001C;
            L0019: goto L014A;
            L001C: PushStack(player, 0x03);
            L0020: PushStack(player, ax);
0714  0021 C4 5E 06  les bx, [bp+0x6]
0717  0024 26 FF 5F 04  call far word [es:bx+0x4]
            L0028: cx = PopStack(player);
            L0029: cx = PopStack(player);
            L002A: RefreshCompareFlags(ax);
            L002C: if (JumpEqual) goto L005B;
            L002E: ShowMessage(player, String0708); // *
            L003B: ShowMessage(player, String0708); // *
            L0048: ShowMessage(player, String0708); // *
0748  0055 B8 2D 0C  mov ax, 0xc2d
            L0058: goto L0174;
            L005B: PushStack(player, 0x03);
            L005F: PushStack(player, ax);
            L0060: PushStack(player, ax);
0754  0061 C4 5E 06  les bx, [bp+0x6]
0757  0064 26 FF 1F  call far word [es:bx]
075A  0067 83 C4 06  add sp, 0x6
            L006A: ShowMessage(player, String0708); // *
            L0077: ShowMessage(player, String0708); // *
            L0084: ShowMessage(player, String0708); // *
            L0091: ShowMessage(player, String0CC6); // Be hanged! Those tracks were hard to follow because they were made by some fairly skillful thieves!Alas, t'will serve naught but to fight it out.
            L009E: Compare(PartyCount(player), 0x0002);
            L00A9: if (JumpBelowOrEqual) goto L00B8;
            L00AB: ShowMessage(player, String0D58); // No matter how many of them there are.
            L00B8: PushStack(player, 0x93);
            L00BC: PushStack(player, 0x00);
            L00BF: PushStack(player, ax);
            L00C0: PushStack(player, ax);
            L00C1: PushStack(player, 0xB8);
            L00C5: PushStack(player, 0x8D);
07BC  00C9 C4 5E 06  les bx, [bp+0x6]
07BF  00CC 26 FF 9F D8 00  call far word [es:bx+0xd8]
07C4  00D1 83 C4 0C  add sp, 0xc
            L00D4: AddEncounter(player, 0x01, 0x19);
            L00E6: AddEncounter(player, 0x02, 0x1A);
            L00F8: Compare(PartyCount(player), 0x0001);
            L0103: if (JumpBelowOrEqual) goto L0117;
            L0105: AddEncounter(player, 0x03, 0x21);
            L0117: Compare(PartyCount(player), 0x0002);
            L0122: if (JumpBelowOrEqual) goto L017E;
            L0124: AddEncounter(player, 0x04, 0x24);
            L0136: AddEncounter(player, 0x05, 0x25);
            L0148: goto L017E;
            L014A: ShowMessage(player, String0708); // *
            L0157: ShowMessage(player, String0708); // *
            L0164: ShowMessage(player, String0708); // *
            L0171: ShowMessage(player, String0D7E); // Whoever was just here beat a strategic withdrawal. Perhaps you should try to act more rangerly to catch up with them.
            L017E: return; // RETURN;
        }

        private void Fn_08(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0x06), 0x0001);
            L0017: if (JumpNotEqual) goto L001C;
            L0019: goto L00AD;
            L001C: Compare(GetFlag(player, 0x03, 0x0A), 0x0001);
            L0030: if (JumpEqual) goto L00AD;
            L0032: RefreshCompareFlags(GetFlag(player, 0x03, 0x02));
            L0045: if (JumpEqual) goto L00AD;
            L0047: PushStack(player, 0x03);
            L004B: PushStack(player, ax);
08BF  004C C4 5E 06  les bx, [bp+0x6]
08C2  004F 26 FF 5F 04  call far word [es:bx+0x4]
            L0053: cx = PopStack(player);
            L0054: cx = PopStack(player);
            L0055: RefreshCompareFlags(ax);
            L0057: if (JumpEqual) goto L00AD;
            L0059: RefreshCompareFlags(GetFlag(player, 0x03, 0x04));
            L006C: if (JumpEqual) goto L00AD;
            L006E: RefreshCompareFlags(GetFlag(player, 0x03, 0x05));
            L0081: if (JumpEqual) goto L00AD;
            L0083: RefreshCompareFlags(GetFlag(player, 0x03, 0x06));
            L0096: if (JumpEqual) goto L00AD;
            L0098: RefreshCompareFlags(GetFlag(player, 0x03, 0x07));
            L00AB: if (JumpNotEqual) goto L00C0;
            L00AD: ShowMessage(player, String0DF4); // A voice whispers from thin air....
092D  00BA B8 17 0E  mov ax, 0xe17
            L00BD: goto L03A0;
            L00C0: ShowPortrait(player, 0x0015);
            L00CD: SetFlag(player, 0x03, 0x0A, 0x01);
            L00E2: SetFlag(player, 0x02, 0x03, 0x01);
            L00F7: Compare(GetFlag(player, 0x02, 0x00), 0x0001);
            L010A: if (JumpEqual) goto L010F;
            L010C: goto L0266;
            L010F: Compare(GetFlag(player, 0x02, 0x01), 0x0001);
            L0123: if (JumpEqual) goto L0128;
            L0125: goto L0266;
            L0128: PushStack(player, 0x02);
            L012C: PushStack(player, ax);
09A0  012D C4 5E 06  les bx, [bp+0x6]
09A3  0130 26 FF 5F 04  call far word [es:bx+0x4]
            L0134: cx = PopStack(player);
            L0135: cx = PopStack(player);
            L0136: Compare(ax, 0x0001);
            L0139: if (JumpEqual) goto L013E;
            L013B: goto L0266;
            L013E: Compare(GetFlag(player, 0x02, 0x05), 0x0001);
            L0152: if (JumpEqual) goto L0157;
            L0154: goto L0266;
            L0157: Compare(GetFlag(player, 0x02, 0x04), 0x0001);
            L016B: if (JumpEqual) goto L0170;
            L016D: goto L0266;
            L0170: RefreshCompareFlags(GetFlag(player, 0x02, 0x06));
            L0183: if (JumpEqual) goto L0188;
            L0185: goto L0266;
            L0188: ShowMessage(player, String0708); // *
            L0195: ShowMessage(player, String0708); // *
            L01A2: ShowMessage(player, String0708); // *
            L01AF: ShowMessage(player, String0E5D); // 'Huzzah!  Thou hast done so well hitherto that I can safely reward thee.  I think me knowledge of the spell of shielding will best serve thee now.'
            L01BC: ShowMessage(player, String0EF1); // You realize that you now know that spell!
            L01C9: SetSpellLevel(player, 0x0F, 0x01);
            L01DA: SetFlag(player, 0x02, 0x06, 0x01);
            L01EF: RefreshCompareFlags(GetSkillLevel(player, 0x06));
            L01FD: if (JumpEqual) goto L0202;
            L01FF: goto L03AA;
            L0202: Compare(GetGuild(player), 0x0002);
            L020C: if (JumpEqual) goto L0211;
            L020E: goto L03AA;
            L0211: ShowMessage(player, String0708); // *
            L021E: ShowMessage(player, String0708); // *
            L022B: ShowMessage(player, String0708); // *
            L0238: ShowMessage(player, String0F1B); // Galatea takes you aside so that only you can hear her remarks.
            L0245: ShowMessage(player, String0F5A); // 'Well met, honored hunter!  May thy arrows fly swift and true.  An thou dost continue on this, the quest for my salvation, then I think me the skill of binding will serve thee well.'
            L0252: SetSkillLevel(player, 0x06, 0x01);
            L0263: goto L03AA;
            L0266: RefreshCompareFlags(GetSkillLevel(player, 0x06));
            L0274: if (JumpEqual) goto L0279;
            L0276: goto L0303;
            L0279: Compare(GetGuild(player), 0x0002);
            L0283: if (JumpNotEqual) goto L0303;
            L0285: RefreshCompareFlags(GetFlag(player, 0x03, 0x02));
            L0298: if (JumpEqual) goto L0303;
            L029A: PushStack(player, 0x03);
            L029E: PushStack(player, ax);
0B12  029F C4 5E 06  les bx, [bp+0x6]
0B15  02A2 26 FF 5F 04  call far word [es:bx+0x4]
            L02A6: cx = PopStack(player);
            L02A7: cx = PopStack(player);
            L02A8: RefreshCompareFlags(ax);
            L02AA: if (JumpEqual) goto L0303;
            L02AC: RefreshCompareFlags(GetFlag(player, 0x03, 0x04));
            L02BF: if (JumpEqual) goto L0303;
            L02C1: RefreshCompareFlags(GetFlag(player, 0x03, 0x05));
            L02D4: if (JumpEqual) goto L0303;
            L02D6: RefreshCompareFlags(GetFlag(player, 0x03, 0x06));
            L02E9: if (JumpEqual) goto L0303;
            L02EB: RefreshCompareFlags(GetFlag(player, 0x03, 0x07));
            L02FE: if (JumpEqual) goto L0303;
            L0300: goto L0211;
            L0303: Compare(GetGuild(player), 0x0002);
            L030D: if (JumpNotEqual) goto L033B;
            L030F: ShowMessage(player, String0708); // *
            L031C: ShowMessage(player, String0708); // *
            L0329: ShowMessage(player, String0708); // *
0BA9  0336 B8 11 10  mov ax, 0x1011
            L0339: goto L03A0;
            L033B: PushStack(player, 0x02);
0BB2  033F C4 5E 06  les bx, [bp+0x6]
0BB5  0342 26 FF 9F B0 00  call far word [es:bx+0xb0]
            L0347: cx = PopStack(player);
            L0348: RefreshCompareFlags(ax);
            L034A: if (JumpEqual) goto L0359;
            L034C: ShowMessage(player, String10B0); // Galatea pulls your party's rangers aside for a few private words, and then returns.
            L0359: RefreshCompareFlags(GetFlag(player, 0x02, 0x70));
            L036C: if (JumpNotEqual) goto L039D;
            L036E: ShowMessage(player, String1104); // 'Thou art surviving, which is the important thing.  Take thee this item which mayhaps will help thee to continue doing so.'
            L037B: SetFlag(player, 0x02, 0x70, 0x01);
            L0390: PushStack(player, 0x90);
0C07  0394 C4 5E 06  les bx, [bp+0x6]
0C0A  0397 26 FF 5F 48  call far word [es:bx+0x48]
            L039B: goto L03A9;
            L039D: ShowMessage(player, String1180); // 'Thou hast earned no further rewards from me, piglet.'
            L03AA: return; // RETURN;
        }

        private void Fn_09(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x11));
            L0016: if (JumpNotEqual) goto L001B;
            L0018: goto L0098;
            L001A: // NOP
            L001B: SetFlag(player, 0x03, 0x11, 0x01);
            L0030: ShowPortrait(player, 0x0022);
            L003D: ShowMessage(player, String0708); // *
            L004A: ShowMessage(player, String0708); // *
            L0057: ShowMessage(player, String0708); // *
            L0064: ShowMessage(player, String11B7); // A human thief skeptically examines you.
            L0071: ShowMessage(player, String11DF); // 'Galatea is indeed testing my limits if she thinks I will gladly and fully aid such as thyself.  Naetheless, I have my orders, and will obey.  Attend:'
            L007E: ShowMessage(player, String1277); // 'Glamis's bane was no swimmer.'
            L008B: ShowMessage(player, String1297); // 'Tis all, tis enough: begone!'
            L0098: return; // RETURN;
        }

        private void Fn_0A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x0D), 0x0001);
            L0017: if (JumpEqual) goto L001C;
            L0019: goto L0192;
            L001C: RefreshCompareFlags(GetFlag(player, 0x03, 0x04));
            L002F: if (JumpEqual) goto L005E;
            L0031: ShowMessage(player, String0708); // *
            L003E: ShowMessage(player, String0708); // *
            L004B: ShowMessage(player, String0708); // *
0D11  0058 B8 B6 12  mov ax, 0x12b6
            L005B: goto L01BC;
            L005E: SetFlag(player, 0x03, 0x04, 0x03);
            L0073: ShowMessage(player, String0708); // *
            L0080: ShowMessage(player, String0708); // *
            L008D: ShowMessage(player, String0708); // *
            L009A: ShowMessage(player, String132B); // The good news is you caught those cats.  The bad news is that you were only tracking a fraction of them, and didn't notice their master's tracks at all.
            L00A7: Compare(PartyCount(player), 0x0002);
            L00B2: if (JumpBelowOrEqual) goto L00D8;
            L00B4: ShowMessage(player, String13C4); // And the really bad news is that their masters were waiting for you with fireballs!
            L00C1: ax = GetCurrentHits(player);
            L00C8: bx = 0x0005;
            L00CB: dx = ax % bx; ax = ax / bx;
            L00CE: DamagePlayer(player, ax);
            L00D8: PushStack(player, 0x93);
            L00DC: PushStack(player, 0x00);
            L00DF: PushStack(player, ax);
            L00E0: PushStack(player, ax);
            L00E1: PushStack(player, 0xB8);
            L00E5: PushStack(player, 0x3C);
0DA2  00E9 C4 5E 06  les bx, [bp+0x6]
0DA5  00EC 26 FF 9F D8 00  call far word [es:bx+0xd8]
0DAA  00F1 83 C4 0C  add sp, 0xc
            L00F4: AddEncounter(player, 0x01, 0x19);
            L0106: AddEncounter(player, 0x02, 0x1D);
            L0118: Compare(PartyCount(player), 0x0001);
            L0123: if (JumpBelowOrEqual) goto L0149;
            L0125: AddEncounter(player, 0x03, 0x1C);
            L0137: AddEncounter(player, 0x04, 0x1D);
            L0149: Compare(PartyCount(player), 0x0002);
            L0154: if (JumpBelowOrEqual) goto L01C6;
            L0156: AddEncounter(player, 0x05, 0x1B);
            L0168: AddEncounter(player, 0x06, 0x1B);
            L017A: ax = GetCurrentHits(player);
            L0181: bx = 0x0005;
            L0184: dx = ax % bx; ax = ax / bx;
            L0187: PushStack(player, ax);
0E41  0188 C4 5E 06  les bx, [bp+0x6]
0E44  018B 26 FF 9F 90 00  call far word [es:bx+0x90]
            L0190: goto L01C5;
            L0192: ShowMessage(player, String0708); // *
            L019F: ShowMessage(player, String0708); // *
            L01AC: ShowMessage(player, String0708); // *
            L01B9: ShowMessage(player, String0D7E); // Whoever was just here beat a strategic withdrawal. Perhaps you should try to act more rangerly to catch up with them.
            L01C6: return; // RETURN;
        }

        private void Fn_0B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x0E));
            L0016: if (JumpNotEqual) goto L001B;
            L0018: goto L0119;
            L001B: RefreshCompareFlags(GetFlag(player, 0x03, 0x05));
            L002E: if (JumpEqual) goto L0036;
0EB1  0030 B8 17 14  mov ax, 0x1417
            L0033: goto L011C;
            L0036: SetFlag(player, 0x03, 0x05, 0x03);
            L004B: ShowMessage(player, String1480); // Damnation, but there are a lot of them!
            L0058: Compare(PartyCount(player), 0x0002);
            L0063: if (JumpBelowOrEqual) goto L0072;
            L0065: ShowMessage(player, String14A8); // Make that an awful lot of them.
            L0072: PushStack(player, 0xBC);
            L0076: PushStack(player, 0x00);
            L0079: PushStack(player, ax);
            L007A: PushStack(player, 0xCB);
            L007E: PushStack(player, 0x4A);
            L0082: PushStack(player, 0xA0);
0F07  0086 C4 5E 06  les bx, [bp+0x6]
0F0A  0089 26 FF 9F D8 00  call far word [es:bx+0xd8]
0F0F  008E 83 C4 0C  add sp, 0xc
            L0091: AddEncounter(player, 0x01, 0x19);
            L00A3: AddEncounter(player, 0x02, 0x22);
            L00B5: Compare(PartyCount(player), 0x0001);
            L00C0: if (JumpBelowOrEqual) goto L00D4;
            L00C2: AddEncounter(player, 0x03, 0x1E);
            L00D4: Compare(PartyCount(player), 0x0002);
            L00DF: if (JumpBelowOrEqual) goto L0126;
            L00E1: AddEncounter(player, 0x04, 0x1E);
            L00F3: AddEncounter(player, 0x05, 0x22);
            L0105: AddEncounter(player, 0x06, 0x22);
            L0117: goto L0126;
            L0119: ShowMessage(player, String14C8); // Judging from the smell, you deftly managed to avoid walking into a huge band of orcs.  Lucky you.
            L0126: return; // RETURN;
        }

        private void Fn_0C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x06), 0x0002);
            L0017: if (JumpNotEqual) goto L0046;
            L0019: ShowMessage(player, String0708); // *
            L0026: ShowMessage(player, String0708); // *
            L0033: ShowMessage(player, String0708); // *
0FE9  0040 B8 2A 15  mov ax, 0x152a
            L0043: goto L012A;
            L0046: RefreshCompareFlags(GetFlag(player, 0x03, 0x06));
            L0059: if (JumpEqual) goto L005E;
            L005B: goto L0127;
            L005E: SetFlag(player, 0x03, 0x06, 0x03);
            L0073: ShowMessage(player, String15A7); // You wanted them.  Now you get them.
            L0080: PushStack(player, 0xBC);
            L0084: PushStack(player, 0x00);
            L0087: PushStack(player, ax);
            L0088: PushStack(player, 0x07);
            L008C: PushStack(player, 0x4A);
            L0090: PushStack(player, 0xA0);
103D  0094 C4 5E 06  les bx, [bp+0x6]
1040  0097 26 FF 9F D8 00  call far word [es:bx+0xd8]
1045  009C 83 C4 0C  add sp, 0xc
            L009F: AddEncounter(player, 0x01, 0x19);
            L00B1: AddEncounter(player, 0x02, 0x23);
            L00C3: AddEncounter(player, 0x03, 0x26);
            L00D5: Compare(PartyCount(player), 0x0002);
            L00E0: if (JumpBelowOrEqual) goto L00F4;
            L00E2: AddEncounter(player, 0x04, 0x27);
            L00F4: Compare(PartyCount(player), 0x0003);
            L00FF: if (JumpBelowOrEqual) goto L0134;
            L0101: AddEncounter(player, 0x05, 0x19);
            L0113: AddEncounter(player, 0x06, 0x19);
            L0125: goto L0134;
            L0127: ShowMessage(player, String15CB); // The stench of death still permeates this place.
            L0134: return; // RETURN;
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
            L0003: ax = HasItem(player, 0xB8);
            L0011: if (JumpNotEqual) goto L002C;
            L0013: ShowMessage(player, String15FB); // You find something useful discarded amongst the rubble.
            L0020: GiveItem(player, 0xB8);
            L002C: return; // RETURN;
        }

        private void Fn_0F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x02, 0x54));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L0103;
            L001B: SetFlag(player, 0x02, 0x54, 0x01);
            L0030: ShowPortrait(player, 0x000E);
            L003D: ShowMessage(player, String0708); // *
            L004A: ShowMessage(player, String0708); // *
            L0057: ShowMessage(player, String0708); // *
            L0064: ShowMessage(player, String1633); // By all the felines and canines!  An enormous red dragon rears up and speaks to you.
            L0071: RefreshCompareFlags(GetFlag(player, 0x02, 0x49));
            L0084: if (JumpNotEqual) goto L00B5;
            L0086: RefreshCompareFlags(GetFlag(player, 0x02, 0x4A));
            L0099: if (JumpNotEqual) goto L00B5;
            L009B: RefreshCompareFlags(GetFlag(player, 0x02, 0x4B));
            L00AE: if (JumpNotEqual) goto L00B5;
11ED  00B0 B8 87 16  mov ax, 0x1687
            L00B3: goto L00B8;
            L00B5: ShowMessage(player, String1752); // 'Ah!  I remember thee.  As I recall, thou didst enjoy my last joke.  Wouldst thou hear another?'
            L00C2: ShowMessage(player, String17B3); // You quickly nod.
            L00CF: ShowMessage(player, String17C4); // 'Gwalter was dim, but doughty.  Did you ever hear how he defeated all the knights of King Arthur's round table?  He demanded a great ransom from Arthur, lest he eat that good monarch.  Arthur told Gwalter that his ransom was on the corner of the table.  Gwalter looked for weeks, and Arthur made his escape.  Get it?'
            L00DC: ShowMessage(player, String1902); // You laugh politely.
            L00E9: ShowMessage(player, String1916); // 'Good enough.  But remember; 'tis only the green drakes that exhibit such stupidity.  I shall remember thee.'
            L00F6: ShowMessage(player, String1984); // The dragon departs.
            L0103: return; // RETURN;
            // Extra data: 55 8B EC 5D CB 
        }

        private void Fn_11(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x07), 0x0001);
            L0017: if (JumpNotEqual) goto L001F;
1265  0019 B8 98 19  mov ax, 0x1998
            L001C: goto L011D;
            L001F: Compare(GetFlag(player, 0x03, 0x07), 0x0002);
            L0033: if (JumpNotEqual) goto L003B;
1281  0035 B8 DF 19  mov ax, 0x19df
            L0038: goto L011D;
            L003B: Compare(GetFlag(player, 0x03, 0x10), 0x0001);
            L004F: if (JumpEqual) goto L0054;
            L0051: goto L011A;
            L0054: SetFlag(player, 0x03, 0x07, 0x03);
            L0069: ShowMessage(player, String1A26); // Just once you wish you weren't outnumbered.
12C2  0076 B8 1E 02  mov ax, 0x21e
            L0079: PushStack(player, ax);
            L007A: PushStack(player, 0x00);
            L007D: PushStack(player, ax);
            L007E: PushStack(player, ax);
            L007F: PushStack(player, 0xCB);
            L0083: PushStack(player, 0xB9);
12D3  0087 C4 5E 06  les bx, [bp+0x6]
12D6  008A 26 FF 9F D8 00  call far word [es:bx+0xd8]
12DB  008F 83 C4 0C  add sp, 0xc
            L0092: AddEncounter(player, 0x01, 0x19);
            L00A4: AddEncounter(player, 0x02, 0x27);
            L00B6: AddEncounter(player, 0x05, 0x17);
            L00C8: Compare(PartyCount(player), 0x0002);
            L00D3: if (JumpBelowOrEqual) goto L00E7;
            L00D5: AddEncounter(player, 0x06, 0x17);
            L00E7: Compare(PartyCount(player), 0x0003);
            L00F2: if (JumpBelowOrEqual) goto L0127;
            L00F4: AddEncounter(player, 0x03, 0x27);
            L0106: AddEncounter(player, 0x04, 0x27);
            L0118: goto L0127;
            L011A: ShowMessage(player, String1A52); // I have good news and bad news.  By wandering around making so much noise you convinced the occupants that you were too tough to fight.  Yes, that is both the good news and the bad news.
            L0127: return; // RETURN;
        }

        private void Fn_12(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x07), 0x0003);
            L0017: if (JumpNotEqual) goto L002E;
            L0019: SetFlag(player, 0x03, 0x07, 0x01);
            L002E: return; // RETURN;
        }

        private void Fn_15(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x01);
            L0007: PushStack(player, 0x0C);
            L000B: PushStack(player, 0x01);
            L000F: PushStack(player, ax);
13BF  0010 C4 5E 06  les bx, [bp+0x6]
13C2  0013 26 FF 9F BC 00  call far word [es:bx+0xbc]
13C7  0018 83 C4 08  add sp, 0x8
            L001B: return; // RETURN;
        }

        private void Fn_1E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x02));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00AC;
            L001B: Compare(HasUsedSkill(player, 0x0B), 0x0001);
            L002A: if (JumpNotBelow) goto L0062;
            L002C: PushStack(player, 0xA6);
            L0030: PushStack(player, ax);
1425  0031 C4 5E 06  les bx, [bp+0x6]
1428  0034 26 FF 5F 54  call far word [es:bx+0x54]
            L0038: cx = PopStack(player);
            L0039: cx = PopStack(player);
            L003A: RefreshCompareFlags(ax);
            L003C: if (JumpNotEqual) goto L0062;
            L003E: PushStack(player, 0x62);
            L0042: PushStack(player, ax);
1437  0043 C4 5E 06  les bx, [bp+0x6]
143A  0046 26 FF 5F 54  call far word [es:bx+0x54]
            L004A: cx = PopStack(player);
            L004B: cx = PopStack(player);
            L004C: RefreshCompareFlags(ax);
            L004E: if (JumpNotEqual) goto L0062;
            L0050: PushStack(player, 0x8F);
            L0054: PushStack(player, ax);
1449  0055 C4 5E 06  les bx, [bp+0x6]
144C  0058 26 FF 5F 54  call far word [es:bx+0x54]
            L005C: cx = PopStack(player);
            L005D: cx = PopStack(player);
            L005E: RefreshCompareFlags(ax);
            L0060: if (JumpEqual) goto L0078;
            L0062: ShowMessage(player, String1B0C); // You find some hairs that have scraped off something heading to the south. 
            L006F: PushStack(player, 0x01);
1467  0073 B8 0B 00  mov ax, 0xb
            L0076: goto L00D6;
            L0078: Compare(GetFlag(player, 0x03, 0x0B), 0x0001);
            L008C: if (JumpNotEqual) goto L009D;
            L008E: ShowMessage(player, String051F); // Spoor.  Palpable spoor!
            L009B: goto L00E4;
            L009D: ShowMessage(player, String1B57); // It's messes like this that will lead to the invention of the vacuum cleaner.
            L00AA: goto L00E4;
            L00AC: ShowMessage(player, String0587); // You remember following these tracks before.
            L00B9: Compare(GetFlag(player, 0x03, 0x02), 0x0003);
            L00CD: if (JumpNotEqual) goto L00E4;
            L00CF: SetFlag(player, 0x03, 0x02, 0x01);
            L00E4: return; // RETURN;
        }

        private void Fn_1F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x03);
            L0007: PushStack(player, ax);
14E2  0008 C4 5E 06  les bx, [bp+0x6]
14E5  000B 26 FF 5F 04  call far word [es:bx+0x4]
            L000F: cx = PopStack(player);
            L0010: cx = PopStack(player);
            L0011: RefreshCompareFlags(ax);
            L0013: if (JumpEqual) goto L0018;
            L0015: goto L00A9;
            L0018: Compare(HasUsedSkill(player, 0x0B), 0x0001);
            L0027: if (JumpNotBelow) goto L005F;
            L0029: PushStack(player, 0xA6);
            L002D: PushStack(player, ax);
1508  002E C4 5E 06  les bx, [bp+0x6]
150B  0031 26 FF 5F 54  call far word [es:bx+0x54]
            L0035: cx = PopStack(player);
            L0036: cx = PopStack(player);
            L0037: RefreshCompareFlags(ax);
            L0039: if (JumpNotEqual) goto L005F;
            L003B: PushStack(player, 0x62);
            L003F: PushStack(player, ax);
151A  0040 C4 5E 06  les bx, [bp+0x6]
151D  0043 26 FF 5F 54  call far word [es:bx+0x54]
            L0047: cx = PopStack(player);
            L0048: cx = PopStack(player);
            L0049: RefreshCompareFlags(ax);
            L004B: if (JumpNotEqual) goto L005F;
            L004D: PushStack(player, 0x8F);
            L0051: PushStack(player, ax);
152C  0052 C4 5E 06  les bx, [bp+0x6]
152F  0055 26 FF 5F 54  call far word [es:bx+0x54]
            L0059: cx = PopStack(player);
            L005A: cx = PopStack(player);
            L005B: RefreshCompareFlags(ax);
            L005D: if (JumpEqual) goto L0075;
            L005F: ShowMessage(player, String1BA4); // To continue following these tracks, go west, young man!  Or woman, dwarf, troll, or whatever the case may be.
            L006C: PushStack(player, 0x01);
154A  0070 B8 0C 00  mov ax, 0xc
            L0073: goto L00D0;
            L0075: Compare(GetFlag(player, 0x03, 0x0C), 0x0001);
            L0089: if (JumpNotEqual) goto L009A;
            L008B: ShowMessage(player, String051F); // Spoor.  Palpable spoor!
            L0098: goto L00DE;
            L009A: ShowMessage(player, String1C12); // What an untidy floor.
            L00A7: goto L00DE;
            L00A9: ShowMessage(player, String0587); // You remember following these tracks before.
            L00B6: PushStack(player, 0x03);
            L00BA: PushStack(player, ax);
1595  00BB C4 5E 06  les bx, [bp+0x6]
1598  00BE 26 FF 5F 04  call far word [es:bx+0x4]
            L00C2: cx = PopStack(player);
            L00C3: cx = PopStack(player);
            L00C4: Compare(ax, 0x0003);
            L00C7: if (JumpNotEqual) goto L00DE;
            L00C9: SetFlag(player, 0x03, 0x03, 0x01);
            L00DE: return; // RETURN;
        }

        private void Fn_20(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x03);
            L0007: PushStack(player, ax);
15C2  0008 C4 5E 06  les bx, [bp+0x6]
15C5  000B 26 FF 5F 04  call far word [es:bx+0x4]
            L000F: cx = PopStack(player);
            L0010: cx = PopStack(player);
            L0011: RefreshCompareFlags(ax);
            L0013: if (JumpEqual) goto L0018;
            L0015: goto L00A9;
            L0018: Compare(HasUsedSkill(player, 0x0B), 0x0002);
            L0027: if (JumpAbove) goto L005F;
            L0029: PushStack(player, 0xA6);
            L002D: PushStack(player, ax);
15E8  002E C4 5E 06  les bx, [bp+0x6]
15EB  0031 26 FF 5F 54  call far word [es:bx+0x54]
            L0035: cx = PopStack(player);
            L0036: cx = PopStack(player);
            L0037: RefreshCompareFlags(ax);
            L0039: if (JumpNotEqual) goto L005F;
            L003B: PushStack(player, 0x62);
            L003F: PushStack(player, ax);
15FA  0040 C4 5E 06  les bx, [bp+0x6]
15FD  0043 26 FF 5F 54  call far word [es:bx+0x54]
            L0047: cx = PopStack(player);
            L0048: cx = PopStack(player);
            L0049: RefreshCompareFlags(ax);
            L004B: if (JumpNotEqual) goto L005F;
            L004D: PushStack(player, 0x8F);
            L0051: PushStack(player, ax);
160C  0052 C4 5E 06  les bx, [bp+0x6]
160F  0055 26 FF 5F 54  call far word [es:bx+0x54]
            L0059: cx = PopStack(player);
            L005A: cx = PopStack(player);
            L005B: RefreshCompareFlags(ax);
            L005D: if (JumpEqual) goto L0075;
            L005F: ShowMessage(player, String1C28); // View halloo!  They are just north of you!
            L006C: PushStack(player, 0x01);
162A  0070 B8 0C 00  mov ax, 0xc
            L0073: goto L00D0;
            L0075: Compare(GetFlag(player, 0x03, 0x0C), 0x0001);
            L0089: if (JumpNotEqual) goto L009A;
            L008B: ShowMessage(player, String051F); // Spoor.  Palpable spoor!
            L0098: goto L00DE;
            L009A: ShowMessage(player, String1C12); // What an untidy floor.
            L00A7: goto L00DE;
            L00A9: ShowMessage(player, String0587); // You remember following these tracks before.
            L00B6: PushStack(player, 0x03);
            L00BA: PushStack(player, ax);
1675  00BB C4 5E 06  les bx, [bp+0x6]
1678  00BE 26 FF 5F 04  call far word [es:bx+0x4]
            L00C2: cx = PopStack(player);
            L00C3: cx = PopStack(player);
            L00C4: Compare(ax, 0x0003);
            L00C7: if (JumpNotEqual) goto L00DE;
            L00C9: SetFlag(player, 0x03, 0x03, 0x01);
            L00DE: return; // RETURN;
        }

        private void Fn_21(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFlag(player, 0x03, 0x0C, 0x00);
            L0017: PushStack(player, 0x03);
            L001B: PushStack(player, ax);
16B6  001C C4 5E 06  les bx, [bp+0x6]
16B9  001F 26 FF 5F 04  call far word [es:bx+0x4]
            L0023: cx = PopStack(player);
            L0024: cx = PopStack(player);
            L0025: Compare(ax, 0x0003);
            L0028: if (JumpNotEqual) goto L003C;
            L002A: PushStack(player, 0x01);
            L002E: PushStack(player, 0x03);
            L0032: PushStack(player, ax);
16CD  0033 C4 5E 06  les bx, [bp+0x6]
16D0  0036 26 FF 1F  call far word [es:bx]
16D3  0039 83 C4 06  add sp, 0x6
            L003C: return; // RETURN;
        }

        private void Fn_22(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x04));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00AC;
            L001B: Compare(HasUsedSkill(player, 0x0B), 0x0002);
            L002A: if (JumpAbove) goto L0062;
            L002C: PushStack(player, 0xA6);
            L0030: PushStack(player, ax);
1709  0031 C4 5E 06  les bx, [bp+0x6]
170C  0034 26 FF 5F 54  call far word [es:bx+0x54]
            L0038: cx = PopStack(player);
            L0039: cx = PopStack(player);
            L003A: RefreshCompareFlags(ax);
            L003C: if (JumpNotEqual) goto L0062;
            L003E: PushStack(player, 0x62);
            L0042: PushStack(player, ax);
171B  0043 C4 5E 06  les bx, [bp+0x6]
171E  0046 26 FF 5F 54  call far word [es:bx+0x54]
            L004A: cx = PopStack(player);
            L004B: cx = PopStack(player);
            L004C: RefreshCompareFlags(ax);
            L004E: if (JumpNotEqual) goto L0062;
            L0050: PushStack(player, 0x8F);
            L0054: PushStack(player, ax);
172D  0055 C4 5E 06  les bx, [bp+0x6]
1730  0058 26 FF 5F 54  call far word [es:bx+0x54]
            L005C: cx = PopStack(player);
            L005D: cx = PopStack(player);
            L005E: RefreshCompareFlags(ax);
            L0060: if (JumpEqual) goto L0078;
            L0062: ShowMessage(player, String1C52); // You find some slender scratches indicating some ferocious felines were heading north.
            L006F: PushStack(player, 0x01);
174B  0073 B8 0D 00  mov ax, 0xd
            L0076: goto L00D6;
            L0078: Compare(GetFlag(player, 0x03, 0x0D), 0x0001);
            L008C: if (JumpNotEqual) goto L009D;
            L008E: ShowMessage(player, String051F); // Spoor.  Palpable spoor!
            L009B: goto L00E4;
            L009D: ShowMessage(player, String1CA8); // The stone floor seems smoother than usual around here.
            L00AA: goto L00E4;
            L00AC: ShowMessage(player, String0587); // You remember following these tracks before.
            L00B9: Compare(GetFlag(player, 0x03, 0x04), 0x0003);
            L00CD: if (JumpNotEqual) goto L00E4;
            L00CF: SetFlag(player, 0x03, 0x04, 0x01);
            L00E4: return; // RETURN;
        }

        private void Fn_23(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x04));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00AC;
            L001B: Compare(HasUsedSkill(player, 0x0B), 0x0003);
            L002A: if (JumpAbove) goto L0062;
            L002C: PushStack(player, 0xA6);
            L0030: PushStack(player, ax);
17EF  0031 C4 5E 06  les bx, [bp+0x6]
17F2  0034 26 FF 5F 54  call far word [es:bx+0x54]
            L0038: cx = PopStack(player);
            L0039: cx = PopStack(player);
            L003A: RefreshCompareFlags(ax);
            L003C: if (JumpNotEqual) goto L0062;
            L003E: PushStack(player, 0x62);
            L0042: PushStack(player, ax);
1801  0043 C4 5E 06  les bx, [bp+0x6]
1804  0046 26 FF 5F 54  call far word [es:bx+0x54]
            L004A: cx = PopStack(player);
            L004B: cx = PopStack(player);
            L004C: RefreshCompareFlags(ax);
            L004E: if (JumpNotEqual) goto L0062;
            L0050: PushStack(player, 0x8F);
            L0054: PushStack(player, ax);
1813  0055 C4 5E 06  les bx, [bp+0x6]
1816  0058 26 FF 5F 54  call far word [es:bx+0x54]
            L005C: cx = PopStack(player);
            L005D: cx = PopStack(player);
            L005E: RefreshCompareFlags(ax);
            L0060: if (JumpEqual) goto L0078;
            L0062: ShowMessage(player, String1CDF); // You find some slender scratches indicating some ferocious felines were heading eastward.
            L006F: PushStack(player, 0x01);
1831  0073 B8 0D 00  mov ax, 0xd
            L0076: goto L00D6;
            L0078: Compare(GetFlag(player, 0x03, 0x0D), 0x0001);
            L008C: if (JumpNotEqual) goto L009D;
            L008E: ShowMessage(player, String051F); // Spoor.  Palpable spoor!
            L009B: goto L00E4;
            L009D: ShowMessage(player, String1CA8); // The stone floor seems smoother than usual around here.
            L00AA: goto L00E4;
            L00AC: ShowMessage(player, String1D38); // You remember following these paw prints before.
            L00B9: Compare(GetFlag(player, 0x03, 0x04), 0x0003);
            L00CD: if (JumpNotEqual) goto L00E4;
            L00CF: SetFlag(player, 0x03, 0x04, 0x01);
            L00E4: return; // RETURN;
        }

        private void Fn_24(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFlag(player, 0x03, 0x0D, 0x00);
            L0017: Compare(GetFlag(player, 0x03, 0x04), 0x0003);
            L002B: if (JumpNotEqual) goto L0042;
            L002D: SetFlag(player, 0x03, 0x04, 0x01);
            L0042: return; // RETURN;
        }

        private void Fn_25(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x05));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00AC;
            L001B: Compare(HasUsedSkill(player, 0x0B), 0x0002);
            L002A: if (JumpAbove) goto L0062;
            L002C: PushStack(player, 0xA6);
            L0030: PushStack(player, ax);
1919  0031 C4 5E 06  les bx, [bp+0x6]
191C  0034 26 FF 5F 54  call far word [es:bx+0x54]
            L0038: cx = PopStack(player);
            L0039: cx = PopStack(player);
            L003A: RefreshCompareFlags(ax);
            L003C: if (JumpNotEqual) goto L0062;
            L003E: PushStack(player, 0x62);
            L0042: PushStack(player, ax);
192B  0043 C4 5E 06  les bx, [bp+0x6]
192E  0046 26 FF 5F 54  call far word [es:bx+0x54]
            L004A: cx = PopStack(player);
            L004B: cx = PopStack(player);
            L004C: RefreshCompareFlags(ax);
            L004E: if (JumpNotEqual) goto L0062;
            L0050: PushStack(player, 0x8F);
            L0054: PushStack(player, ax);
193D  0055 C4 5E 06  les bx, [bp+0x6]
1940  0058 26 FF 5F 54  call far word [es:bx+0x54]
            L005C: cx = PopStack(player);
            L005D: cx = PopStack(player);
            L005E: RefreshCompareFlags(ax);
            L0060: if (JumpEqual) goto L0078;
            L0062: ShowMessage(player, String1D68); // You find some faint marks indicating a small mixed force recently moved stealthily northwards from here. 
            L006F: PushStack(player, 0x01);
195B  0073 B8 0E 00  mov ax, 0xe
            L0076: goto L00D6;
            L0078: Compare(GetFlag(player, 0x03, 0x0E), 0x0001);
            L008C: if (JumpNotEqual) goto L009D;
            L008E: ShowMessage(player, String051F); // Spoor.  Palpable spoor!
            L009B: goto L00E4;
            L009D: ShowMessage(player, String1DD2); // Funny.  The wall is slightly discolored here.
            L00AA: goto L00E4;
            L00AC: ShowMessage(player, String0587); // You remember following these tracks before.
            L00B9: Compare(GetFlag(player, 0x03, 0x05), 0x0003);
            L00CD: if (JumpNotEqual) goto L00E4;
            L00CF: SetFlag(player, 0x03, 0x05, 0x01);
            L00E4: return; // RETURN;
        }

        private void Fn_26(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFlag(player, 0x03, 0x0E, 0x00);
            L0017: Compare(GetFlag(player, 0x03, 0x05), 0x0003);
            L002B: if (JumpNotEqual) goto L0042;
            L002D: SetFlag(player, 0x03, 0x05, 0x01);
            L0042: return; // RETURN;
        }

        private void Fn_2B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x07));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L0115;
            L001B: Compare(HasUsedSkill(player, 0x0B), 0x0002);
            L002A: if (JumpAbove) goto L0062;
            L002C: PushStack(player, 0xA6);
            L0030: PushStack(player, ax);
1A57  0031 C4 5E 06  les bx, [bp+0x6]
1A5A  0034 26 FF 5F 54  call far word [es:bx+0x54]
            L0038: cx = PopStack(player);
            L0039: cx = PopStack(player);
            L003A: RefreshCompareFlags(ax);
            L003C: if (JumpNotEqual) goto L0062;
            L003E: PushStack(player, 0x62);
            L0042: PushStack(player, ax);
1A69  0043 C4 5E 06  les bx, [bp+0x6]
1A6C  0046 26 FF 5F 54  call far word [es:bx+0x54]
            L004A: cx = PopStack(player);
            L004B: cx = PopStack(player);
            L004C: RefreshCompareFlags(ax);
            L004E: if (JumpNotEqual) goto L0062;
            L0050: PushStack(player, 0x8F);
            L0054: PushStack(player, ax);
1A7B  0055 C4 5E 06  les bx, [bp+0x6]
1A7E  0058 26 FF 5F 54  call far word [es:bx+0x54]
            L005C: cx = PopStack(player);
            L005D: cx = PopStack(player);
            L005E: RefreshCompareFlags(ax);
            L0060: if (JumpEqual) goto L00AD;
            L0062: ShowMessage(player, String0708); // *
            L006F: ShowMessage(player, String0708); // *
            L007C: ShowMessage(player, String0708); // *
            L0089: ShowMessage(player, String1E00); // These eastbound tracks are easily followed.  'I wonder an they be a small army, incapable of moving in obscurement, or doughty warriors hoping to lure us into a fatal attack,' you think to yourself.
            L0096: ShowMessage(player, String1EC7); // 'Or maybe 'tis but a bluff.'
            L00A3: PushStack(player, 0x01);
1ACD  00A7 B8 10 00  mov ax, 0x10
            L00AA: goto L013F;
            L00AD: Compare(GetFlag(player, 0x03, 0x10), 0x0001);
            L00C1: if (JumpNotEqual) goto L0106;
            L00C3: ShowMessage(player, String0708); // *
            L00D0: ShowMessage(player, String0708); // *
            L00DD: ShowMessage(player, String0708); // *
            L00EA: ShowMessage(player, String051F); // Spoor.  Palpable spoor!
            L00F7: ShowMessage(player, String1EE4); // And you know, palping all this spoor is beginning to disgust you a bit.
            L0104: goto L014D;
            L0106: ShowMessage(player, String1F2C); // You stumble slightly.
            L0113: goto L014D;
            L0115: ShowMessage(player, String0587); // You remember following these tracks before.
            L0122: Compare(GetFlag(player, 0x03, 0x07), 0x0003);
            L0136: if (JumpNotEqual) goto L014D;
            L0138: SetFlag(player, 0x03, 0x07, 0x01);
            L014D: return; // RETURN;
        }

        private void Fn_2C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x06));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L012E;
            L001B: Compare(HasUsedSkill(player, 0x0B), 0x0002);
            L002A: if (JumpBelowOrEqual) goto L0088;
            L002C: RefreshCompareFlags(GetSkillLevel(player, 0x0B));
            L003A: if (JumpNotEqual) goto L0088;
            L003C: SetFlag(player, 0x03, 0x0F, 0x01);
            L0051: ShowMessage(player, String0708); // *
            L005E: ShowMessage(player, String0708); // *
            L006B: ShowMessage(player, String0708); // *
            L0078: ShowMessage(player, String1F42); // After much chin rubbing, pate scratching, and head shaking, your party's tracker decides that recently someone moved south from here.  And moved well.
            L0085: goto L0166;
            L0088: Compare(HasUsedSkill(player, 0x0B), 0x0002);
            L0097: if (JumpAbove) goto L00CF;
            L0099: PushStack(player, 0xA6);
            L009D: PushStack(player, ax);
1C13  009E C4 5E 06  les bx, [bp+0x6]
1C16  00A1 26 FF 5F 54  call far word [es:bx+0x54]
            L00A5: cx = PopStack(player);
            L00A6: cx = PopStack(player);
            L00A7: RefreshCompareFlags(ax);
            L00A9: if (JumpNotEqual) goto L00CF;
            L00AB: PushStack(player, 0x62);
            L00AF: PushStack(player, ax);
1C25  00B0 C4 5E 06  les bx, [bp+0x6]
1C28  00B3 26 FF 5F 54  call far word [es:bx+0x54]
            L00B7: cx = PopStack(player);
            L00B8: cx = PopStack(player);
            L00B9: RefreshCompareFlags(ax);
            L00BB: if (JumpNotEqual) goto L00CF;
            L00BD: PushStack(player, 0x8F);
            L00C1: PushStack(player, ax);
1C37  00C2 C4 5E 06  les bx, [bp+0x6]
1C3A  00C5 26 FF 5F 54  call far word [es:bx+0x54]
            L00C9: cx = PopStack(player);
            L00CA: cx = PopStack(player);
            L00CB: RefreshCompareFlags(ax);
            L00CD: if (JumpEqual) goto L010C;
            L00CF: ShowMessage(player, String0708); // *
            L00DC: ShowMessage(player, String0708); // *
            L00E9: ShowMessage(player, String0708); // *
            L00F6: ShowMessage(player, String1FD9); // This is not easy to interpret, but you finally decide that the frayed thread you found indicates a party moving south.
            L0103: PushStack(player, 0x01);
1C7C  0107 B8 0F 00  mov ax, 0xf
            L010A: goto L0158;
            L010C: Compare(GetFlag(player, 0x03, 0x0F), 0x0001);
            L0120: if (JumpNotEqual) goto L0128;
1C97  0122 B8 1F 05  mov ax, 0x51f
            L0125: goto L007B;
1C9D  0128 B8 50 20  mov ax, 0x2050
            L012B: goto L007B;
            L012E: ShowMessage(player, String0587); // You remember following these tracks before.
            L013B: Compare(GetFlag(player, 0x03, 0x06), 0x0003);
            L014F: if (JumpNotEqual) goto L0166;
            L0151: SetFlag(player, 0x03, 0x06, 0x01);
            L0166: return; // RETURN;
        }

        private void Fn_2D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFlag(player, 0x03, 0x0F, 0x00);
            L0017: Compare(GetFlag(player, 0x03, 0x06), 0x0003);
            L002B: if (JumpNotEqual) goto L0042;
            L002D: SetFlag(player, 0x03, 0x06, 0x01);
            L0042: return; // RETURN;
        }

        private void Fn_2E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x07));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00AC;
            L001B: Compare(HasUsedSkill(player, 0x0B), 0x0002);
            L002A: if (JumpAbove) goto L0062;
            L002C: PushStack(player, 0xA6);
            L0030: PushStack(player, ax);
1D52  0031 C4 5E 06  les bx, [bp+0x6]
1D55  0034 26 FF 5F 54  call far word [es:bx+0x54]
            L0038: cx = PopStack(player);
            L0039: cx = PopStack(player);
            L003A: RefreshCompareFlags(ax);
            L003C: if (JumpNotEqual) goto L0062;
            L003E: PushStack(player, 0x62);
            L0042: PushStack(player, ax);
1D64  0043 C4 5E 06  les bx, [bp+0x6]
1D67  0046 26 FF 5F 54  call far word [es:bx+0x54]
            L004A: cx = PopStack(player);
            L004B: cx = PopStack(player);
            L004C: RefreshCompareFlags(ax);
            L004E: if (JumpNotEqual) goto L0062;
            L0050: PushStack(player, 0x8F);
            L0054: PushStack(player, ax);
1D76  0055 C4 5E 06  les bx, [bp+0x6]
1D79  0058 26 FF 5F 54  call far word [es:bx+0x54]
            L005C: cx = PopStack(player);
            L005D: cx = PopStack(player);
            L005E: RefreshCompareFlags(ax);
            L0060: if (JumpEqual) goto L0078;
            L0062: ShowMessage(player, String2071); // A large group of people made these northbound tracks.
            L006F: PushStack(player, 0x01);
1D94  0073 B8 10 00  mov ax, 0x10
            L0076: goto L00D6;
            L0078: Compare(GetFlag(player, 0x03, 0x10), 0x0001);
            L008C: if (JumpNotEqual) goto L009D;
            L008E: ShowMessage(player, String051F); // Spoor.  Palpable spoor!
            L009B: goto L00E4;
            L009D: ShowMessage(player, String1F2C); // You stumble slightly.
            L00AA: goto L00E4;
            L00AC: ShowMessage(player, String0587); // You remember following these tracks before.
            L00B9: Compare(GetFlag(player, 0x03, 0x07), 0x0003);
            L00CD: if (JumpNotEqual) goto L00E4;
            L00CF: SetFlag(player, 0x03, 0x07, 0x01);
            L00E4: return; // RETURN;
        }

        private void Fn_2F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFlag(player, 0x03, 0x10, 0x00);
            L0017: Compare(GetFlag(player, 0x03, 0x07), 0x0003);
            L002B: if (JumpNotEqual) goto L0042;
            L002D: SetFlag(player, 0x03, 0x07, 0x01);
            L0042: return; // RETURN;
        }

    }
}
