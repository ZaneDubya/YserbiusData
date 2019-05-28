#pragma warning disable
using System.Collections.Generic;
using XPT.WorldData;
using XPT.WorldData.Yserbius;

namespace XPT.Scripts.Yserbius.Maps {
    class YserMap04 : AMapScripted {
        protected override int MapIndex => 4;
        protected override int RandomEncounterChance => 10;
        protected override int RandomEncounterExtraCount => 0;

        public YserMap04() {
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
            MapEvent19 = Fn_19;
        }
        
        // === Strings ================================================
        private const string String0140 = "This way to the Foyer of Cawdor.";
        private const string String0161 = "*";
        private const string String0163 = "An old wizard draws you aside for a private word.";
        private const string String0195 = "'Come in, come in!  I know I've not seen the likes of thee hitherto, but I can spot a fellow dabbler in the mystical arts from, well, six feet off, if not more.";
        private const string String0236 = "I have a boon to grant thee, fellow mage.  Think not that just those skulkers know their way around the hidden mysteries of the universe, and the detection thereof.  Behold!'";
        private const string String02E5 = "The wizard gestures and suddenly you have an intuitive, if unpractised, knowledge of detection.";
        private const string String0345 = "'And to aid thee, a riddle: ";
        private const string String0362 = "What did the gaffer like to ogle?  Figure that one out and thou shalt know how to navigate this room.";
        private const string String03C8 = "Now go forth and do me proud, young, uh, being.'";
        private const string String03F9 = "'It gladdens an old wizard's heart to see a youngster do so well.  Clearly thou hast solved my riddle: widow shins.  Here, let me find thee a suitable reward.  Hmm.  Coffee candy?  I think not.  A new robe?  Kids nowadays always hate getting clothes.  I guess I shall just write a check, same as always.'";
        private const string String052A = "'Look not so disappointed.  The real reward is the spell knowledge I shall now impart to thee.  Behold! Thou dost know the spell of resist!'";
        private const string String05B7 = "'Generous to a fault, am I not?  I guess that makes thee the fault to which I am generous.  Hah!  Enough of this fiddle faddle!  I have work to do!'";
        private const string String064C = "'Back again?  Do I look generous?  Dost thou mistake a kindly countenance for true affection?  Dost thou think coffee candies GROW ON TREES!  Get thee gone, sniveler!'";
        private const string String06F4 = "As you slink away, you hear him muttering.";
        private const string String071F = "'Hmm.  A coffee candy tree.  That IS good!  I must remember to write that one down.  Curses!  Why can I never find a quill when I need one?'";
        private const string String07AC = "'Back so - ah.  I see thou art ill beset by the slings and arrows of outrageous fortune.  Would that I can give thee greater assistance, but perchance this nice coffee candy will sooth thy mind and smooth thy furrowed brow.'";
        private const string String088D = "The candy is tasty, but does nothing great for you otherwise.";
        private const string String08CB = "All right, I lied.  Those are very potent candies.  Thou art healed.  But thou wilt have a hard time getting to sleep tonight.";
        private const string String094A = "'I see thou art just passing through.  May fortune smile upon thee, and may all thy baths be hot.  Ooh!  I do like that cool dry wit.  Where is my quill and ink?'";
        private const string String09ED = "En garde!";
        private const string String09F7 = "You remember the cats you faced here.  Some of them were hep cats, of course.";
        private const string String0A45 = "I know not whether you solved the wizard's riddle or are just lucky, but either way you have uncovered a hidden door.";
        private const string String0ABB = "You think that something magical is going on here.";
        private const string String0AEE = "You feel a hot wind sweep by you, as if flames were fanned by huge winds.";
        private const string String0B38 = "You hear some footsteps running towards you.";
        private const string String0B65 = "A galloping group of gremlins rushes past. One of them falls out and talks briefly.";
        private const string String0BB9 = "'Well met at midnight.  I can see that thou art honourable beings who - uh - we shall talk anon.'";
        private const string String0C1B = "He turns and runs, followed soon thereafter by a low flying dragon.";
        private const string String0C5F = "You find some grotesquely gashed gremlins.";
        private const string String0C8A = "The dragon inhales deeply, preparatory to breathing on you, but pauses.";
        private const string String0CD2 = "'I remember thee from somewhere.  Ah!  The egg.  I managed to get it back.  But this time 'tis CASH!  Worth far more than mere eggs.  'Tis past time we rid this world of all beings under, say, ten feet tall.  Meaning no offense, of course.'";
        private const string String0DC3 = "You didn't fall off the watermelon wagon yesterday.  'None taken,' you tell the dragon, as it flies off in pursuit of the gremlins.";
        private const string String0E47 = "'Prithee pardon.  Some gruesome gremlins have purloined my portfolio, but I now see that thou art not the thief.  But be warned: an I learn thou hast my letter of credit, I shall retrieve it, will thee or nill thee.'";
        private const string String0F20 = "You breath a sigh of relief as you realize the dragon did not notice your own significant chunk of change.  You look for anyone to whom you owe money so that you might pay off that debt before the dragon returns, but luck is not with you today.";
        private const string String1015 = "'As I suspected!  That large letter of credit has my name upon it!  Deny it not!  I shall be magnanimous and assume that thou didst but find it upon thy path and held it for me.  Dost thou care to argue about it?'";
        private const string String10EB = "You do not argue.  It's only money.";
        private const string String110F = "'I said I am keeping an eye on thee, and a watchful eye it is.  An thou dost find my stolen gold, I shall expect thee to yield it to me with grace, lest I anger.'";
        private const string String11B2 = "You don't want to see the dragon angered.";
        private const string String11DC = "Trust me on this.";
        private const string String11EE = "A somewhat battered clutch of clerics decides, rather insultingly, that they are bigger than you are.";
        private const string String1254 = "Hmm....  Maybe they are!";
        private const string String126D = "You think you saw something out of the corner of your eye.";
        private const string String12A8 = "Your left eye.";
        private const string String12B7 = "Your right eye.";
        private const string String12C7 = "Something tricksome bewilders you here.";
        private const string String12EF = "A voice whispers from thin air....";
        private const string String1312 = "'I'm sorry, but there's nothing else I can do for you here.'";
        private const string String134F = "'Huzzah!  Thou hast done so well hitherto that I can safely reward thee.  I think me knowledge of the spell of shielding will best serve thee now.'";
        private const string String13E3 = "You realize that you now know that spell!";
        private const string String140D = "Galatea takes you aside so that only you can hear her remarks.";
        private const string String144C = "'Most cleverly deciphered, oh thou conjurer and caster.  To best aid thee as thou dost continue on this, the quest for my salvation, then I think me the skill of reverie will serve thee well.'";
        private const string String150D = "'Thou hast already received all the rewards thou hast earned and that I can safely grant thee here, lest my sisters notice and suspect the usage of my power.'";
        private const string String15AC = "Galatea pulls your party's wizards aside for a few private words, and then returns.";
        private const string String1600 = "'Thou art surviving, which is the important thing.  Take thee this item which mayhaps will help thee to continue doing so.'";
        private const string String167C = "'Thou hast earned no further rewards from me, baconbrains.'";
        private const string String16B8 = "An elven ranger greets you.";
        private const string String16D4 = "'Glad am I to see a friendly face.  I thank thee for treating with courtesy, not combat.  Therefore shall I reward thee with full knowledge of that which I have learned.";
        private const string String177E = "Primus, there is a daft dragon who will take thy auric ingots, and take them roughly an thou dost resist, as my good brother learned with finality and fatality.";
        private const string String181F = "Secondus, I now know me of a sovereign weapon against the winged wyrms: the Brunanburh Bow.  An I had such, along with a Shield Wall and Alfred's Hat, or mayhaps Drakesbane or The Dagda's Harp, or e'en the Adamant Gauntlets, and I would have taught yon wyrm a slow and painful lesson!";
        private const string String193C = "Ah!  I have my breath back, and I think I know where my path to vengeance begins.  Fare thee well.";
        private const string String199F = "The remains of the ambush you fought hereabouts have covered several nearby squares.";
        private const string String19F4 = "Sigh.... they were waiting for you with a volley of arrows and spells.  'I didn't need that,' you think, as you rush to the attack.";
        private const string String1A78 = "Lots of spells: you really didn't need that!";
        private const string String1AA5 = "You remember the waves of foes that you fought in this area.  You were lucky to survive; aye, and skillful, too.";
        private const string String1B16 = "Damnation, but there are a lot of them!";
        private const string String1B3E = "Make that an awful lot of them.";
        private const string String1B5E = "You wanted them.  Now you get them.";
        private const string String1B82 = "You can still smell the remains of the battle you fought in this vicinity.";
        private const string String1BCD = "What an ambush.  You were lucky to survive.";
        private const string String1BF9 = "Not another ambush!  They were ready for you.";
        private const string String1C27 = "Ready, and well prepared.";
        private const string String1C41 = "For a second, you thought there was a teleportal here.  I wonder what might have made it go away.";
        private const string String1CA3 = "You smile, grimly: you, at least, walked away from this killing place.";
        private const string String1CEA = "Just once you wish you weren't outnumbered.";
        private const string String1D16 = "And outgunned.";
        private const string String1D25 = "You think you see the flicker of magical lights ahead of you.";
        private const string String1D63 = "You've uncovered a hidden door!";
        private const string String1D83 = "'I said I am keeping an eye on thee, and a watchful eye it is.  An thou dost find my stolen horde, I shall expect thee to yield it to me with grace, lest I anger.'";
        
        // === Functions ================================================
        private void Fn_01(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFlag(player, 0x02, 0x4F, 0x01);
            L0018: Compare(GetFacing(player), 0x0001);
            L0022: if (JumpNotEqual) goto L0031;
            L0024: ShowMessage(player, String0140); // This way to the Foyer of Cawdor.
            L0031: return; // RETURN;
        }

        private void Fn_02(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x002B);
            L0010: RefreshCompareFlags(GetSkillLevel(player, 0x0D));
            L001E: if (JumpEqual) goto L0023;
            L0020: goto L00C8;
            L0023: Compare(GetGuild(player), 0x0005);
            L002D: if (JumpEqual) goto L0032;
            L002F: goto L00C8;
            L0032: ShowMessage(player, String0161); // *
            L003F: ShowMessage(player, String0161); // *
            L004C: ShowMessage(player, String0161); // *
            L0059: ShowMessage(player, String0163); // An old wizard draws you aside for a private word.
            L0066: ShowMessage(player, String0195); // 'Come in, come in!  I know I've not seen the likes of thee hitherto, but I can spot a fellow dabbler in the mystical arts from, well, six feet off, if not more.
            L0073: ShowMessage(player, String0236); // I have a boon to grant thee, fellow mage.  Think not that just those skulkers know their way around the hidden mysteries of the universe, and the detection thereof.  Behold!'
            L0080: SetSkillLevel(player, 0x0D, 0x01);
            L0091: ShowMessage(player, String02E5); // The wizard gestures and suddenly you have an intuitive, if unpractised, knowledge of detection.
            L009E: ShowMessage(player, String0345); // 'And to aid thee, a riddle: 
            L00AB: ShowMessage(player, String0362); // What did the gaffer like to ogle?  Figure that one out and thou shalt know how to navigate this room.
            L00B8: ShowMessage(player, String03C8); // Now go forth and do me proud, young, uh, being.'
            L00C5: goto L03BB;
            L00C8: RefreshCompareFlags(GetFlag(player, 0x03, 0x02));
            L00DB: if (JumpNotEqual) goto L00E0;
            L00DD: goto L01E6;
            L00E0: PushStack(player, 0x03);
            L00E4: PushStack(player, ax);
011F  00E5 C4 5E 06  les bx, [bp+0x6]
0122  00E8 26 FF 5F 04  call far word [es:bx+0x4]
            L00EC: cx = PopStack(player);
            L00ED: cx = PopStack(player);
            L00EE: RefreshCompareFlags(ax);
            L00F0: if (JumpNotEqual) goto L00F5;
            L00F2: goto L01E6;
            L00F5: RefreshCompareFlags(GetFlag(player, 0x03, 0x04));
            L0108: if (JumpNotEqual) goto L010D;
            L010A: goto L01E6;
            L010D: RefreshCompareFlags(GetFlag(player, 0x03, 0x05));
            L0120: if (JumpNotEqual) goto L0125;
            L0122: goto L01E6;
            L0125: RefreshCompareFlags(GetFlag(player, 0x03, 0x06));
            L0138: if (JumpNotEqual) goto L013D;
            L013A: goto L01E6;
            L013D: RefreshCompareFlags(GetFlag(player, 0x03, 0x07));
            L0150: if (JumpNotEqual) goto L0155;
            L0152: goto L01E6;
            L0155: RefreshCompareFlags(GetFlag(player, 0x02, 0x08));
            L0168: if (JumpEqual) goto L016D;
            L016A: goto L01E6;
            L016C: // NOP
            L016D: ShowMessage(player, String0161); // *
            L017A: ShowMessage(player, String0161); // *
            L0187: ShowMessage(player, String0161); // *
            L0194: ShowMessage(player, String03F9); // 'It gladdens an old wizard's heart to see a youngster do so well.  Clearly thou hast solved my riddle: widow shins.  Here, let me find thee a suitable reward.  Hmm.  Coffee candy?  I think not.  A new robe?  Kids nowadays always hate getting clothes.  I guess I shall just write a check, same as always.'
            L01A1: GiveItem(player, 0xBD);
            L01AD: ShowMessage(player, String052A); // 'Look not so disappointed.  The real reward is the spell knowledge I shall now impart to thee.  Behold! Thou dost know the spell of resist!'
            L01BA: PushStack(player, 0x01);
            L01BE: PushStack(player, 0x15);
01FC  01C2 C4 5E 06  les bx, [bp+0x6]
01FF  01C5 26 FF 5F 6C  call far word [es:bx+0x6c]
            L01C9: cx = PopStack(player);
            L01CA: cx = PopStack(player);
            L01CB: SetFlag(player, 0x02, 0x08, 0x01);
021A  01E0 B8 B7 05  mov ax, 0x5b7
            L01E3: goto L00BB;
            L01E6: Compare(GetFlag(player, 0x03, 0x01), 0x0002);
            L01FA: if (JumpNotEqual) goto L01FF;
            L01FC: goto L0289;
            L01FF: RefreshCompareFlags(GetFlag(player, 0x03, 0x02));
            L0212: if (JumpNotEqual) goto L0217;
            L0214: goto L02F2;
            L0217: PushStack(player, 0x03);
            L021B: PushStack(player, ax);
0256  021C C4 5E 06  les bx, [bp+0x6]
0259  021F 26 FF 5F 04  call far word [es:bx+0x4]
            L0223: cx = PopStack(player);
            L0224: cx = PopStack(player);
            L0225: RefreshCompareFlags(ax);
            L0227: if (JumpNotEqual) goto L022C;
            L0229: goto L02F2;
            L022C: RefreshCompareFlags(GetFlag(player, 0x03, 0x04));
            L023F: if (JumpNotEqual) goto L0244;
            L0241: goto L02F2;
            L0244: RefreshCompareFlags(GetFlag(player, 0x03, 0x05));
            L0257: if (JumpNotEqual) goto L025C;
            L0259: goto L02F2;
            L025C: RefreshCompareFlags(GetFlag(player, 0x03, 0x06));
            L026F: if (JumpNotEqual) goto L0274;
            L0271: goto L02F2;
            L0273: // NOP
            L0274: RefreshCompareFlags(GetFlag(player, 0x03, 0x07));
            L0287: if (JumpEqual) goto L02F2;
            L0289: ShowMessage(player, String0161); // *
            L0296: ShowMessage(player, String0161); // *
            L02A3: ShowMessage(player, String0161); // *
            L02B0: ShowMessage(player, String064C); // 'Back again?  Do I look generous?  Dost thou mistake a kindly countenance for true affection?  Dost thou think coffee candies GROW ON TREES!  Get thee gone, sniveler!'
            L02BD: ShowMessage(player, String06F4); // As you slink away, you hear him muttering.
            L02CA: ShowMessage(player, String071F); // 'Hmm.  A coffee candy tree.  That IS good!  I must remember to write that one down.  Curses!  Why can I never find a quill when I need one?'
            L02D7: PushStack(player, 0x01);
            L02DB: PushStack(player, 0x07);
            L02DF: PushStack(player, 0x02);
            L02E3: PushStack(player, ax);
031E  02E4 C4 5E 06  les bx, [bp+0x6]
0321  02E7 26 FF 9F BC 00  call far word [es:bx+0xbc]
0326  02EC 83 C4 08  add sp, 0x8
            L02EF: goto L03BB;
            L02F2: Compare(GetFlag(player, 0x03, 0x01), 0x0001);
            L0306: if (JumpNotEqual) goto L0375;
            L0308: ShowMessage(player, String0161); // *
            L0315: ShowMessage(player, String0161); // *
            L0322: ShowMessage(player, String0161); // *
            L032F: ShowMessage(player, String07AC); // 'Back so - ah.  I see thou art ill beset by the slings and arrows of outrageous fortune.  Would that I can give thee greater assistance, but perchance this nice coffee candy will sooth thy mind and smooth thy furrowed brow.'
            L033C: ShowMessage(player, String088D); // The candy is tasty, but does nothing great for you otherwise.
            L0349: SetFlag(player, 0x03, 0x01, 0x02);
            L035E: HealPlayer(player, GetMaxHits(player));
03A9  036F B8 CB 08  mov ax, 0x8cb
            L0372: goto L00BB;
            L0375: ShowMessage(player, String0161); // *
            L0382: ShowMessage(player, String0161); // *
            L038F: ShowMessage(player, String0161); // *
            L039C: ShowMessage(player, String094A); // 'I see thou art just passing through.  May fortune smile upon thee, and may all thy baths be hot.  Ooh!  I do like that cool dry wit.  Where is my quill and ink?'
            L03A9: PushStack(player, 0x01);
            L03AD: PushStack(player, ax);
            L03AE: PushStack(player, 0x03);
03EC  03B2 C4 5E 06  les bx, [bp+0x6]
03EF  03B5 26 FF 1F  call far word [es:bx]
03F2  03B8 83 C4 06  add sp, 0x6
            L03BB: return; // RETURN;
        }

        private void Fn_03(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x02));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L0107;
            L001B: SetFlag(player, 0x03, 0x02, 0x01);
            L0030: ShowMessage(player, String09ED); // En garde!
            L003D: RefreshCompareFlags(GetFlag(player, 0x02, 0x41));
            L0050: if (JumpNotEqual) goto L0075;
            L0052: SetFlag(player, 0x02, 0x41, 0x01);
            L0067: PushStack(player, 0x7D);
            L006B: PushStack(player, 0x00);
            L006E: PushStack(player, ax);
            L006F: PushStack(player, ax);
0467  0070 B8 BE 00  mov ax, 0xbe
            L0073: goto L0081;
            L0075: PushStack(player, 0x7D);
            L0079: PushStack(player, 0x00);
            L007C: PushStack(player, ax);
            L007D: PushStack(player, ax);
            L007E: PushStack(player, 0xBD);
            L0082: PushStack(player, 0xA0);
047D  0086 C4 5E 06  les bx, [bp+0x6]
0480  0089 26 FF 9F D8 00  call far word [es:bx+0xd8]
0485  008E 83 C4 0C  add sp, 0xc
            L0091: AddEncounter(player, 0x01, 0x19);
            L00A3: AddEncounter(player, 0x02, 0x26);
            L00B5: Compare(PartyCount(player), 0x0001);
            L00C0: if (JumpBelowOrEqual) goto L00D4;
            L00C2: AddEncounter(player, 0x03, 0x27);
            L00D4: Compare(PartyCount(player), 0x0002);
            L00DF: if (JumpBelowOrEqual) goto L0114;
            L00E1: AddEncounter(player, 0x04, 0x26);
            L00F3: AddEncounter(player, 0x05, 0x27);
            L0105: goto L0114;
            L0107: ShowMessage(player, String09F7); // You remember the cats you faced here.  Some of them were hep cats, of course.
            L0114: return; // RETURN;
        }

        private void Fn_04(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFlag(player, 0x03, 0x0B, 0x01);
            L0018: return; // RETURN;
        }

        private void Fn_05(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x0B));
            L0016: if (JumpNotEqual) goto L008A;
            L0018: ShowMessage(player, String0161); // *
            L0025: ShowMessage(player, String0161); // *
            L0032: ShowMessage(player, String0161); // *
            L003F: ShowMessage(player, String0A45); // I know not whether you solved the wizard's riddle or are just lucky, but either way you have uncovered a hidden door.
            L004C: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L006A: SetWallObject(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L0088: goto L0097;
            L008A: ShowMessage(player, String0ABB); // You think that something magical is going on here.
            L0097: return; // RETURN;
        }

        private void Fn_06(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si, di);
            L0005: di = 0;
            L0007: si = 0;
            L0009: ax = GetFlag(player, 0x03, 0x08);
05DA  001A 8B F8  mov di, ax
05DC  001C 47     inc di
05DD  001D 8B F7  mov si, di
            L001F: Compare(si, 0x13);
            L0022: if (JumpLessOrEqual) goto L002B;
05E4  0024 8B C6  mov ax, si
            L0026: si = ax + 0xFFEC;
            L002B: Compare(si, 0x0E);
            L002E: if (JumpLessOrEqual) goto L0037;
05F0  0030 8B C6  mov ax, si
            L0032: si = ax + 0xFFF1;
            L0037: Compare(si, 0x09);
            L003A: if (JumpLessOrEqual) goto L0043;
05FC  003C 8B C6  mov ax, si
            L003E: si = ax + 0xFFF6;
            L0043: Compare(si, 0x04);
            L0046: if (JumpLessOrEqual) goto L004F;
0608  0048 8B C6  mov ax, si
            L004A: si = ax + 0xFFFB;
060F  004F 0B F6  or si, si
0611  0051 7D 02  jge 0x55
            L0053: si = 0;
            L0055: Compare(si, 0x1D);
            L0058: if (JumpLessOrEqual) goto L005C;
            L005A: si = 0;
061C  005C 83 FF 18  cmp di, 0x18
            L005F: if (JumpLessOrEqual) goto L0063;
            L0061: di = 0;
0623  0063 57     push di
            L0064: PushStack(player, 0x08);
            L0068: PushStack(player, 0x03);
062C  006C C4 5E 06  les bx, [bp+0x6]
062F  006F 26 FF 1F  call far word [es:bx]
0632  0072 83 C4 06  add sp, 0x6
0635  0075 83 FF 1A  cmp di, 0x1a
            L0078: if (JumpNotEqual) goto L007F;
063A  007A B8 01 00  mov ax, 0x1
            L007D: goto L0081;
            L007F: PushStack(player, 0x00);
0642  0082 83 FF 14  cmp di, 0x14
            L0085: if (JumpNotEqual) goto L008C;
0647  0087 B8 01 00  mov ax, 0x1
            L008A: goto L008E;
064C  008C 33 C0  xor ax, ax
            L008E: dx = PopStack(player);
064F  008F 0B D0  or dx, ax
            L0091: PushStack(player, dx);
0652  0092 83 FF 0E  cmp di, 0xe
            L0095: if (JumpNotEqual) goto L009C;
0657  0097 B8 01 00  mov ax, 0x1
            L009A: goto L009E;
065C  009C 33 C0  xor ax, ax
            L009E: dx = PopStack(player);
065F  009F 0B D0  or dx, ax
            L00A1: PushStack(player, dx);
0662  00A2 83 FF 08  cmp di, 0x8
            L00A5: if (JumpNotEqual) goto L00AC;
0667  00A7 B8 01 00  mov ax, 0x1
            L00AA: goto L00AE;
066C  00AC 33 C0  xor ax, ax
            L00AE: dx = PopStack(player);
066F  00AF 0B D0  or dx, ax
            L00B1: PushStack(player, dx);
0672  00B2 83 FF 02  cmp di, 0x2
            L00B5: if (JumpNotEqual) goto L00BC;
0677  00B7 B8 01 00  mov ax, 0x1
            L00BA: goto L00BE;
067C  00BC 33 C0  xor ax, ax
            L00BE: dx = PopStack(player);
067F  00BF 0B D0  or dx, ax
            L00C1: if (JumpNotEqual) goto L00C6;
            L00C3: goto L03AF;
            L00C6: bx = si;
            L00C8: Compare(bx, 0x04);
            L00CB: if (JumpBelowOrEqual) goto L00D0;
            L00CD: goto L03AF;
            L00D0: switch (bx) {
                case 0:
                    goto L00D7;
                case 1:
                    goto L00E7;
                case 2:
                    goto L0147;
                case 3:
                    goto L0226;
                case 4:
                    goto L02D9;
            }
            L00D7: ShowMessage(player, String0AEE); // You feel a hot wind sweep by you, as if flames were fanned by huge winds.
            L00E4: goto L03AF;
            L00E7: ShowMessage(player, String0161); // *
            L00F4: ShowMessage(player, String0161); // *
            L0101: ShowMessage(player, String0161); // *
            L010E: ShowMessage(player, String0B38); // You hear some footsteps running towards you.
            L011B: ShowPortrait(player, 0x0026);
            L0128: ShowMessage(player, String0B65); // A galloping group of gremlins rushes past. One of them falls out and talks briefly.
            L0135: ShowMessage(player, String0BB9); // 'Well met at midnight.  I can see that thou art honourable beings who - uh - we shall talk anon.'
0702  0142 B8 1B 0C  mov ax, 0xc1b
            L0145: goto L00DA;
            L0147: Compare(GetFlag(player, 0x03, 0x09), 0x0001);
            L015B: if (JumpNotEqual) goto L0163;
071D  015D B8 5F 0C  mov ax, 0xc5f
            L0160: goto L00DA;
            L0163: ShowPortrait(player, 0x000E);
            L0170: ShowMessage(player, String0161); // *
            L017D: ShowMessage(player, String0161); // *
            L018A: ShowMessage(player, String0161); // *
            L0197: ShowMessage(player, String0C8A); // The dragon inhales deeply, preparatory to breathing on you, but pauses.
            L01A4: Compare(GetFlag(player, 0x02, 0x00), 0x0001);
            L01B7: if (JumpNotEqual) goto L01CB;
            L01B9: ShowMessage(player, String0CD2); // 'I remember thee from somewhere.  Ah!  The egg.  I managed to get it back.  But this time 'tis CASH!  Worth far more than mere eggs.  'Tis past time we rid this world of all beings under, say, ten feet tall.  Meaning no offense, of course.'
0786  01C6 B8 C3 0D  mov ax, 0xdc3
            L01C9: goto L01EB;
            L01CB: ShowMessage(player, String0E47); // 'Prithee pardon.  Some gruesome gremlins have purloined my portfolio, but I now see that thou art not the thief.  But be warned: an I learn thou hast my letter of credit, I shall retrieve it, will thee or nill thee.'
            L01D8: ax = HasItem(player, 0xBE);
            L01E6: if (JumpEqual) goto L01F5;
            L01E8: ShowMessage(player, String0F20); // You breath a sigh of relief as you realize the dragon did not notice your own significant chunk of change.  You look for anyone to whom you owe money so that you might pay off that debt before the dragon returns, but luck is not with you today.
            L01F5: RefreshCompareFlags(GetFlag(player, 0x03, 0x09));
            L0208: if (JumpNotEqual) goto L020F;
07CA  020A B8 01 00  mov ax, 0x1
            L020D: goto L0211;
            L020F: SetFlag(player, 0x03, 0x09, 0x00);
            L0223: goto L03AF;
            L0226: ShowPortrait(player, 0x000E);
            L0233: ax = HasItem(player, 0xBE);
            L0241: if (JumpEqual) goto L0292;
            L0243: ShowMessage(player, String0161); // *
            L0250: ShowMessage(player, String0161); // *
            L025D: ShowMessage(player, String0161); // *
            L026A: ShowMessage(player, String1015); // 'As I suspected!  That large letter of credit has my name upon it!  Deny it not!  I shall be magnanimous and assume that thou didst but find it upon thy path and held it for me.  Dost thou care to argue about it?'
            L0277: ShowMessage(player, String10EB); // You do not argue.  It's only money.
            L0284: PushStack(player, 0xBD);
0848  0288 C4 5E 06  les bx, [bp+0x6]
084B  028B 26 FF 5F 4C  call far word [es:bx+0x4c]
            L028F: goto L00E3;
            L0292: ShowMessage(player, String0161); // *
            L029F: ShowMessage(player, String0161); // *
            L02AC: ShowMessage(player, String0161); // *
            L02B9: ShowMessage(player, String110F); // 'I said I am keeping an eye on thee, and a watchful eye it is.  An thou dost find my stolen gold, I shall expect thee to yield it to me with grace, lest I anger.'
            L02C6: ShowMessage(player, String11B2); // You don't want to see the dragon angered.
0893  02D3 B8 DC 11  mov ax, 0x11dc
            L02D6: goto L00DA;
            L02D9: ShowMessage(player, String11EE); // A somewhat battered clutch of clerics decides, rather insultingly, that they are bigger than you are.
            L02E6: PushStack(player, 0x5D);
            L02EA: PushStack(player, 0x00);
            L02ED: PushStack(player, ax);
            L02EE: PushStack(player, ax);
            L02EF: PushStack(player, 0xB6);
            L02F3: PushStack(player, 0xBD);
08B7  02F7 C4 5E 06  les bx, [bp+0x6]
08BA  02FA 26 FF 9F D8 00  call far word [es:bx+0xd8]
08BF  02FF 83 C4 0C  add sp, 0xc
            L0302: Compare(PartyCount(player), 0x0002);
            L030D: if (JumpBelowOrEqual) goto L031C;
            L030F: ShowMessage(player, String1254); // Hmm....  Maybe they are!
            L031C: AddEncounter(player, 0x01, 0x09);
            L032E: Compare(PartyCount(player), 0x0001);
            L0339: if (JumpBelowOrEqual) goto L034D;
            L033B: AddEncounter(player, 0x05, 0x09);
            L034D: Compare(PartyCount(player), 0x0002);
            L0358: if (JumpBelowOrEqual) goto L037E;
            L035A: AddEncounter(player, 0x02, 0x09);
            L036C: AddEncounter(player, 0x06, 0x09);
            L037E: Compare(PartyCount(player), 0x0002);
            L0389: if (JumpBelowOrEqual) goto L03AF;
            L038B: AddEncounter(player, 0x03, 0x09);
            L039D: AddEncounter(player, 0x04, 0x09);
            L03AF: return; // RETURN (restoring si, di);
        }

        private void Fn_07(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x0B));
            L0016: if (JumpNotEqual) goto L0052;
            L0018: Compare(GetFacing(player), 0x0003);
            L0022: if (JumpEqual) goto L006B;
            L0024: ShowMessage(player, String126D); // You think you saw something out of the corner of your eye.
            L0031: Compare(GetFacing(player), 0x0002);
            L003B: if (JumpNotEqual) goto L0042;
09BA  003D B8 A8 12  mov ax, 0x12a8
            L0040: goto L0061;
            L0042: RefreshCompareFlags(GetFacing(player));
            L004B: if (JumpNotEqual) goto L006B;
09CA  004D B8 B7 12  mov ax, 0x12b7
            L0050: goto L0061;
            L0052: Compare(GetFacing(player), 0x0003);
            L005C: if (JumpEqual) goto L006B;
            L005E: ShowMessage(player, String12C7); // Something tricksome bewilders you here.
            L006B: return; // RETURN;
        }

        private void Fn_08(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0x06), 0x0001);
            L0017: if (JumpEqual) goto L002F;
            L0019: Compare(GetFlag(player, 0x03, 0x0A), 0x0001);
            L002D: if (JumpNotEqual) goto L0069;
            L002F: ShowMessage(player, String0161); // *
            L003C: ShowMessage(player, String0161); // *
            L0049: ShowMessage(player, String0161); // *
            L0056: ShowMessage(player, String12EF); // A voice whispers from thin air....
0A4D  0063 B8 12 13  mov ax, 0x1312
            L0066: goto L03D6;
            L0069: ShowPortrait(player, 0x0015);
            L0076: SetFlag(player, 0x03, 0x0A, 0x01);
            L008B: SetFlag(player, 0x02, 0x05, 0x01);
            L00A0: Compare(GetFlag(player, 0x02, 0x00), 0x0001);
            L00B3: if (JumpEqual) goto L00B8;
            L00B5: goto L029C;
            L00B8: Compare(GetFlag(player, 0x02, 0x01), 0x0001);
            L00CC: if (JumpEqual) goto L00D1;
            L00CE: goto L029C;
            L00D1: PushStack(player, 0x02);
            L00D5: PushStack(player, ax);
0AC0  00D6 C4 5E 06  les bx, [bp+0x6]
0AC3  00D9 26 FF 5F 04  call far word [es:bx+0x4]
            L00DD: cx = PopStack(player);
            L00DE: cx = PopStack(player);
            L00DF: Compare(ax, 0x0001);
            L00E2: if (JumpEqual) goto L00E7;
            L00E4: goto L029C;
            L00E7: Compare(GetFlag(player, 0x02, 0x03), 0x0001);
            L00FB: if (JumpEqual) goto L0100;
            L00FD: goto L029C;
            L0100: Compare(GetFlag(player, 0x02, 0x04), 0x0001);
            L0114: if (JumpEqual) goto L0119;
            L0116: goto L029C;
            L0119: RefreshCompareFlags(GetFlag(player, 0x02, 0x06));
            L012C: if (JumpEqual) goto L0131;
            L012E: goto L029C;
            L0131: ShowMessage(player, String0161); // *
            L013E: ShowMessage(player, String0161); // *
            L014B: ShowMessage(player, String0161); // *
            L0158: ShowMessage(player, String134F); // 'Huzzah!  Thou hast done so well hitherto that I can safely reward thee.  I think me knowledge of the spell of shielding will best serve thee now.'
            L0165: ShowMessage(player, String13E3); // You realize that you now know that spell!
            L0172: SetSpellLevel(player, 0x0F, 0x01);
            L0183: SetFlag(player, 0x02, 0x06, 0x01);
            L0198: RefreshCompareFlags(GetSkillLevel(player, 0x13));
            L01A6: if (JumpEqual) goto L01AB;
            L01A8: goto L03E0;
            L01AB: Compare(GetGuild(player), 0x0005);
            L01B5: if (JumpEqual) goto L01BA;
            L01B7: goto L03E0;
            L01BA: RefreshCompareFlags(GetFlag(player, 0x03, 0x02));
            L01CD: if (JumpNotEqual) goto L01D2;
            L01CF: goto L03E0;
            L01D2: PushStack(player, 0x03);
            L01D6: PushStack(player, ax);
0BC1  01D7 C4 5E 06  les bx, [bp+0x6]
0BC4  01DA 26 FF 5F 04  call far word [es:bx+0x4]
            L01DE: cx = PopStack(player);
            L01DF: cx = PopStack(player);
            L01E0: RefreshCompareFlags(ax);
            L01E2: if (JumpNotEqual) goto L01E7;
            L01E4: goto L03E0;
            L01E7: RefreshCompareFlags(GetFlag(player, 0x03, 0x04));
            L01FA: if (JumpNotEqual) goto L01FF;
            L01FC: goto L03E0;
            L01FF: RefreshCompareFlags(GetFlag(player, 0x03, 0x05));
            L0212: if (JumpNotEqual) goto L0217;
            L0214: goto L03E0;
            L0217: RefreshCompareFlags(GetFlag(player, 0x03, 0x06));
            L022A: if (JumpNotEqual) goto L022F;
            L022C: goto L03E0;
            L022F: RefreshCompareFlags(GetFlag(player, 0x03, 0x07));
            L0242: if (JumpNotEqual) goto L0247;
            L0244: goto L03E0;
            L0247: ShowMessage(player, String0161); // *
            L0254: ShowMessage(player, String0161); // *
            L0261: ShowMessage(player, String0161); // *
            L026E: ShowMessage(player, String140D); // Galatea takes you aside so that only you can hear her remarks.
            L027B: ShowMessage(player, String144C); // 'Most cleverly deciphered, oh thou conjurer and caster.  To best aid thee as thou dost continue on this, the quest for my salvation, then I think me the skill of reverie will serve thee well.'
            L0288: SetSkillLevel(player, 0x13, 0x01);
            L0299: goto L03E0;
            L029C: RefreshCompareFlags(GetSkillLevel(player, 0x13));
            L02AA: if (JumpEqual) goto L02AF;
            L02AC: goto L0339;
            L02AF: Compare(GetGuild(player), 0x0005);
            L02B9: if (JumpNotEqual) goto L0339;
            L02BB: RefreshCompareFlags(GetFlag(player, 0x03, 0x02));
            L02CE: if (JumpEqual) goto L0339;
            L02D0: PushStack(player, 0x03);
            L02D4: PushStack(player, ax);
0CBF  02D5 C4 5E 06  les bx, [bp+0x6]
0CC2  02D8 26 FF 5F 04  call far word [es:bx+0x4]
            L02DC: cx = PopStack(player);
            L02DD: cx = PopStack(player);
            L02DE: RefreshCompareFlags(ax);
            L02E0: if (JumpEqual) goto L0339;
            L02E2: RefreshCompareFlags(GetFlag(player, 0x03, 0x04));
            L02F5: if (JumpEqual) goto L0339;
            L02F7: RefreshCompareFlags(GetFlag(player, 0x03, 0x05));
            L030A: if (JumpEqual) goto L0339;
            L030C: RefreshCompareFlags(GetFlag(player, 0x03, 0x06));
            L031F: if (JumpEqual) goto L0339;
            L0321: RefreshCompareFlags(GetFlag(player, 0x03, 0x07));
            L0334: if (JumpEqual) goto L0339;
            L0336: goto L0247;
            L0339: Compare(GetGuild(player), 0x0005);
            L0343: if (JumpNotEqual) goto L0371;
            L0345: ShowMessage(player, String0161); // *
            L0352: ShowMessage(player, String0161); // *
            L035F: ShowMessage(player, String0161); // *
0D56  036C B8 0D 15  mov ax, 0x150d
            L036F: goto L03D6;
            L0371: PushStack(player, 0x05);
0D5F  0375 C4 5E 06  les bx, [bp+0x6]
0D62  0378 26 FF 9F B0 00  call far word [es:bx+0xb0]
            L037D: cx = PopStack(player);
            L037E: RefreshCompareFlags(ax);
            L0380: if (JumpEqual) goto L038F;
            L0382: ShowMessage(player, String15AC); // Galatea pulls your party's wizards aside for a few private words, and then returns.
            L038F: RefreshCompareFlags(GetFlag(player, 0x02, 0x70));
            L03A2: if (JumpNotEqual) goto L03D3;
            L03A4: ShowMessage(player, String1600); // 'Thou art surviving, which is the important thing.  Take thee this item which mayhaps will help thee to continue doing so.'
            L03B1: SetFlag(player, 0x02, 0x70, 0x01);
            L03C6: PushStack(player, 0xBD);
0DB4  03CA C4 5E 06  les bx, [bp+0x6]
0DB7  03CD 26 FF 5F 48  call far word [es:bx+0x48]
            L03D1: goto L03DF;
            L03D3: ShowMessage(player, String167C); // 'Thou hast earned no further rewards from me, baconbrains.'
            L03E0: return; // RETURN;
        }

        private void Fn_09(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x0C));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00BA;
            L001B: SetFlag(player, 0x03, 0x0C, 0x01);
            L0030: ShowPortrait(player, 0x001F);
            L003D: ShowMessage(player, String16B8); // An elven ranger greets you.
            L004A: ShowMessage(player, String0161); // *
            L0057: ShowMessage(player, String0161); // *
            L0064: ShowMessage(player, String0161); // *
            L0071: ShowMessage(player, String16D4); // 'Glad am I to see a friendly face.  I thank thee for treating with courtesy, not combat.  Therefore shall I reward thee with full knowledge of that which I have learned.
            L007E: ShowMessage(player, String177E); // Primus, there is a daft dragon who will take thy auric ingots, and take them roughly an thou dost resist, as my good brother learned with finality and fatality.
            L008B: ShowMessage(player, String181F); // Secondus, I now know me of a sovereign weapon against the winged wyrms: the Brunanburh Bow.  An I had such, along with a Shield Wall and Alfred's Hat, or mayhaps Drakesbane or The Dagda's Harp, or e'en the Adamant Gauntlets, and I would have taught yon wyrm a slow and painful lesson!
            L0098: ShowMessage(player, String193C); // Ah!  I have my breath back, and I think I know where my path to vengeance begins.  Fare thee well.
            L00A5: SetFlag(player, 0x02, 0x09, 0x01);
            L00BA: return; // RETURN;
        }

        private void Fn_0A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x04));
            L0016: if (JumpEqual) goto L0028;
            L0018: ShowMessage(player, String199F); // The remains of the ambush you fought hereabouts have covered several nearby squares.
            L0025: goto L0129;
            L0028: SetFlag(player, 0x03, 0x04, 0x01);
            L003D: ShowMessage(player, String19F4); // Sigh.... they were waiting for you with a volley of arrows and spells.  'I didn't need that,' you think, as you rush to the attack.
            L004A: Compare(PartyCount(player), 0x0003);
            L0055: if (JumpBelowOrEqual) goto L0070;
            L0057: ShowMessage(player, String1A78); // Lots of spells: you really didn't need that!
            L0064: ax = GetCurrentHits(player);
            L006B: bx = 0x0003;
            L006E: goto L007A;
            L0070: ax = GetCurrentHits(player);
            L0077: bx = 0x0005;
            L007A: dx = ax % bx; ax = ax / bx;
            L007D: DamagePlayer(player, ax);
            L0087: PushStack(player, 0xCF);
            L008B: PushStack(player, 0x00);
            L008E: PushStack(player, ax);
            L008F: PushStack(player, ax);
            L0090: PushStack(player, 0xB9);
            L0094: PushStack(player, 0xCB);
0F20  0098 C4 5E 06  les bx, [bp+0x6]
0F23  009B 26 FF 9F D8 00  call far word [es:bx+0xd8]
0F28  00A0 83 C4 0C  add sp, 0xc
            L00A3: AddEncounter(player, 0x01, 0x19);
            L00B5: AddEncounter(player, 0x05, 0x1D);
            L00C7: Compare(PartyCount(player), 0x0002);
            L00D2: if (JumpBelowOrEqual) goto L00F8;
            L00D4: AddEncounter(player, 0x02, 0x19);
            L00E6: AddEncounter(player, 0x06, 0x1A);
            L00F8: Compare(PartyCount(player), 0x0003);
            L0103: if (JumpBelowOrEqual) goto L0129;
            L0105: AddEncounter(player, 0x03, 0x22);
            L0117: AddEncounter(player, 0x04, 0x22);
            L0129: return; // RETURN;
        }

        private void Fn_0B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x05));
            L0016: if (JumpEqual) goto L0028;
            L0018: ShowMessage(player, String1AA5); // You remember the waves of foes that you fought in this area.  You were lucky to survive; aye, and skillful, too.
            L0025: goto L0109;
            L0028: SetFlag(player, 0x03, 0x05, 0x01);
            L003D: ShowMessage(player, String1B16); // Damnation, but there are a lot of them!
            L004A: Compare(PartyCount(player), 0x0002);
            L0055: if (JumpBelowOrEqual) goto L0064;
            L0057: ShowMessage(player, String1B3E); // Make that an awful lot of them.
            L0064: PushStack(player, 0xBC);
            L0068: PushStack(player, 0x00);
            L006B: PushStack(player, ax);
            L006C: PushStack(player, 0xCB);
            L0070: PushStack(player, 0xB8);
            L0074: PushStack(player, 0xA0);
102B  0078 C4 5E 06  les bx, [bp+0x6]
102E  007B 26 FF 9F D8 00  call far word [es:bx+0xd8]
1033  0080 83 C4 0C  add sp, 0xc
            L0083: AddEncounter(player, 0x01, 0x19);
            L0095: AddEncounter(player, 0x02, 0x23);
            L00A7: Compare(PartyCount(player), 0x0001);
            L00B2: if (JumpBelowOrEqual) goto L00C6;
            L00B4: AddEncounter(player, 0x05, 0x1D);
            L00C6: Compare(PartyCount(player), 0x0002);
            L00D1: if (JumpBelowOrEqual) goto L0109;
            L00D3: AddEncounter(player, 0x03, 0x22);
            L00E5: AddEncounter(player, 0x04, 0x1E);
            L00F7: AddEncounter(player, 0x06, 0x22);
            L0109: return; // RETURN;
        }

        private void Fn_0C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x06));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00E4;
            L001B: SetFlag(player, 0x03, 0x06, 0x01);
            L0030: ShowMessage(player, String1B5E); // You wanted them.  Now you get them.
            L003D: PushStack(player, 0xBC);
            L0041: PushStack(player, 0x00);
            L0044: PushStack(player, ax);
            L0045: PushStack(player, 0x71);
            L0049: PushStack(player, 0x03);
            L004D: PushStack(player, 0xA0);
110F  0051 C4 5E 06  les bx, [bp+0x6]
1112  0054 26 FF 9F D8 00  call far word [es:bx+0xd8]
1117  0059 83 C4 0C  add sp, 0xc
            L005C: AddEncounter(player, 0x01, 0x19);
            L006E: AddEncounter(player, 0x02, 0x23);
            L0080: AddEncounter(player, 0x03, 0x1C);
            L0092: Compare(PartyCount(player), 0x0002);
            L009D: if (JumpBelowOrEqual) goto L00B1;
            L009F: AddEncounter(player, 0x04, 0x20);
            L00B1: Compare(PartyCount(player), 0x0003);
            L00BC: if (JumpBelowOrEqual) goto L00F1;
            L00BE: AddEncounter(player, 0x05, 0x28);
            L00D0: AddEncounter(player, 0x06, 0x28);
            L00E2: goto L00F1;
            L00E4: ShowMessage(player, String1B82); // You can still smell the remains of the battle you fought in this vicinity.
            L00F1: return; // RETURN;
        }

        private void Fn_0D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x07), 0x0001);
            L0017: if (JumpNotEqual) goto L0029;
            L0019: ShowMessage(player, String1BCD); // What an ambush.  You were lucky to survive.
            L0026: goto L011E;
            L0029: SetFlag(player, 0x03, 0x07, 0x01);
            L003E: ShowMessage(player, String1BF9); // Not another ambush!  They were ready for you.
            L004B: Compare(PartyCount(player), 0x0002);
            L0056: if (JumpBelowOrEqual) goto L0065;
            L0058: ShowMessage(player, String1C27); // Ready, and well prepared.
            L0065: ax = GetCurrentHits(player);
            L006C: bx = 0x0003;
            L006F: dx = ax % bx; ax = ax / bx;
            L0072: DamagePlayer(player, ax);
122D  007C B8 1E 02  mov ax, 0x21e
            L007F: PushStack(player, ax);
            L0080: PushStack(player, 0x00);
            L0083: PushStack(player, ax);
            L0084: PushStack(player, ax);
            L0085: PushStack(player, 0xCB);
            L0089: PushStack(player, 0xB9);
123E  008D C4 5E 06  les bx, [bp+0x6]
1241  0090 26 FF 9F D8 00  call far word [es:bx+0xd8]
1246  0095 83 C4 0C  add sp, 0xc
            L0098: AddEncounter(player, 0x01, 0x19);
            L00AA: AddEncounter(player, 0x02, 0x14);
            L00BC: AddEncounter(player, 0x05, 0x22);
            L00CE: Compare(PartyCount(player), 0x0001);
            L00D9: if (JumpBelowOrEqual) goto L00ED;
            L00DB: AddEncounter(player, 0x06, 0x22);
            L00ED: Compare(PartyCount(player), 0x0002);
            L00F8: if (JumpBelowOrEqual) goto L011E;
            L00FA: AddEncounter(player, 0x03, 0x14);
            L010C: AddEncounter(player, 0x04, 0x14);
            L011E: return; // RETURN;
        }

        private void Fn_0E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFlag(player, 0x03, 0x0B, 0x00);
            L0017: return; // RETURN;
        }

        private void Fn_0F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x0B));
            L0016: if (JumpNotEqual) goto L0031;
            L0018: PushStack(player, 0x00);
            L001B: PushStack(player, 0xF2);
            L001F: PushStack(player, 0x02);
            L0023: PushStack(player, ax);
130E  0024 C4 5E 06  les bx, [bp+0x6]
1311  0027 26 FF 9F BC 00  call far word [es:bx+0xbc]
1316  002C 83 C4 08  add sp, 0x8
            L002F: goto L007E;
            L0031: SetWallObject(player, 0x00, GetCurrentTile(player), 0x01);
            L004A: ShowMessage(player, String0161); // *
            L0057: ShowMessage(player, String0161); // *
            L0064: ShowMessage(player, String0161); // *
            L0071: ShowMessage(player, String1C41); // For a second, you thought there was a teleportal here.  I wonder what might have made it go away.
            L007E: return; // RETURN;
        }

        private void Fn_10(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x00);
            L0006: PushStack(player, 0xF9);
            L000A: PushStack(player, 0x02);
            L000E: PushStack(player, ax);
1379  000F C4 5E 06  les bx, [bp+0x6]
137C  0012 26 FF 9F BC 00  call far word [es:bx+0xbc]
1381  0017 83 C4 08  add sp, 0x8
            L001A: return; // RETURN;
        }

        private void Fn_11(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x03);
            L0007: PushStack(player, ax);
138E  0008 C4 5E 06  les bx, [bp+0x6]
1391  000B 26 FF 5F 04  call far word [es:bx+0x4]
            L000F: cx = PopStack(player);
            L0010: cx = PopStack(player);
            L0011: Compare(ax, 0x0001);
            L0014: if (JumpNotEqual) goto L0026;
            L0016: ShowMessage(player, String1CA3); // You smile, grimly: you, at least, walked away from this killing place.
            L0023: goto L0101;
            L0026: PushStack(player, 0x01);
            L002A: PushStack(player, 0x03);
            L002E: PushStack(player, ax);
13B5  002F C4 5E 06  les bx, [bp+0x6]
13B8  0032 26 FF 1F  call far word [es:bx]
13BB  0035 83 C4 06  add sp, 0x6
            L0038: ShowMessage(player, String1CEA); // Just once you wish you weren't outnumbered.
            L0045: Compare(PartyCount(player), 0x0003);
            L0050: if (JumpBelowOrEqual) goto L005F;
            L0052: ShowMessage(player, String1D16); // And outgunned.
13E5  005F B8 1E 02  mov ax, 0x21e
            L0062: PushStack(player, ax);
            L0063: PushStack(player, 0x00);
            L0066: PushStack(player, ax);
            L0067: PushStack(player, ax);
            L0068: PushStack(player, 0xCB);
            L006C: PushStack(player, 0xB8);
13F6  0070 C4 5E 06  les bx, [bp+0x6]
13F9  0073 26 FF 9F D8 00  call far word [es:bx+0xd8]
13FE  0078 83 C4 0C  add sp, 0xc
            L007B: AddEncounter(player, 0x01, 0x19);
            L008D: AddEncounter(player, 0x02, 0x1B);
            L009F: AddEncounter(player, 0x05, 0x22);
            L00B1: Compare(PartyCount(player), 0x0002);
            L00BC: if (JumpBelowOrEqual) goto L00D0;
            L00BE: AddEncounter(player, 0x06, 0x22);
            L00D0: Compare(PartyCount(player), 0x0003);
            L00DB: if (JumpBelowOrEqual) goto L0101;
            L00DD: AddEncounter(player, 0x03, 0x1F);
            L00EF: AddEncounter(player, 0x04, 0x1F);
            L0101: return; // RETURN;
        }

        private void Fn_12(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x0B));
            L0016: if (JumpNotEqual) goto L0053;
            L0018: SetWallObject(player, 0x01, 0xF1, 0x01);
            L002E: Compare(GetFacing(player), 0x0001);
            L0038: if (JumpEqual) goto L0046;
            L003A: Compare(GetFacing(player), 0x0002);
            L0044: if (JumpNotEqual) goto L0053;
            L0046: ShowMessage(player, String1D25); // You think you see the flicker of magical lights ahead of you.
            L0053: return; // RETURN;
        }

        private void Fn_14(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x0B));
            L0016: if (JumpNotEqual) goto L0031;
            L0018: SetWallObject(player, 0x01, GetCurrentTile(player), 0x00);
            L0031: return; // RETURN;
        }

        private void Fn_15(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x01);
            L0007: PushStack(player, 0x07);
            L000B: PushStack(player, 0x01);
            L000F: PushStack(player, ax);
1526  0010 C4 5E 06  les bx, [bp+0x6]
1529  0013 26 FF 9F BC 00  call far word [es:bx+0xbc]
152E  0018 83 C4 08  add sp, 0x8
            L001B: return; // RETURN;
        }

        private void Fn_16(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFlag(player, 0x03, 0x0B, 0x01);
            L0018: Compare(HasUsedSkill(player, 0x0D), 0x0001);
            L0027: if (JumpNotBelow) goto L0093;
            L0029: RefreshCompareFlags(HasUsedSpell(player, 0x17));
            L0037: if (JumpNotEqual) goto L0093;
            L0039: PushStack(player, 0xA7);
            L003D: PushStack(player, ax);
1571  003E C4 5E 06  les bx, [bp+0x6]
1574  0041 26 FF 5F 54  call far word [es:bx+0x54]
            L0045: cx = PopStack(player);
            L0046: cx = PopStack(player);
            L0047: RefreshCompareFlags(ax);
            L0049: if (JumpNotEqual) goto L0093;
            L004B: PushStack(player, 0x67);
            L004F: PushStack(player, ax);
1583  0050 C4 5E 06  les bx, [bp+0x6]
1586  0053 26 FF 5F 54  call far word [es:bx+0x54]
            L0057: cx = PopStack(player);
            L0058: cx = PopStack(player);
            L0059: RefreshCompareFlags(ax);
            L005B: if (JumpNotEqual) goto L0093;
            L005D: PushStack(player, 0x61);
            L0061: PushStack(player, ax);
1595  0062 C4 5E 06  les bx, [bp+0x6]
1598  0065 26 FF 5F 54  call far word [es:bx+0x54]
            L0069: cx = PopStack(player);
            L006A: cx = PopStack(player);
            L006B: RefreshCompareFlags(ax);
            L006D: if (JumpNotEqual) goto L0093;
            L006F: PushStack(player, 0x93);
            L0073: PushStack(player, ax);
15A7  0074 C4 5E 06  les bx, [bp+0x6]
15AA  0077 26 FF 5F 54  call far word [es:bx+0x54]
            L007B: cx = PopStack(player);
            L007C: cx = PopStack(player);
            L007D: RefreshCompareFlags(ax);
            L007F: if (JumpNotEqual) goto L0093;
            L0081: PushStack(player, 0x86);
            L0085: PushStack(player, ax);
15B9  0086 C4 5E 06  les bx, [bp+0x6]
15BC  0089 26 FF 5F 54  call far word [es:bx+0x54]
            L008D: cx = PopStack(player);
            L008E: cx = PopStack(player);
            L008F: RefreshCompareFlags(ax);
            L0091: if (JumpEqual) goto L00D3;
            L0093: ShowMessage(player, String1D63); // You've uncovered a hidden door!
            L00A0: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L00BE: PushStack(player, GetFacing(player));
            L00C6: PushStack(player, GetCurrentTile(player));
1601  00CE B8 01 00  mov ax, 0x1
            L00D1: goto L0102;
            L00D3: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L00F0: SetWallObject(player, 0x00, GetCurrentTile(player), GetFacing(player));
            L010D: return; // RETURN;
        }

        private void Fn_17(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, 0x0D), 0x0002);
            L0012: if (JumpAbove) goto L007E;
            L0014: RefreshCompareFlags(HasUsedSpell(player, 0x17));
            L0022: if (JumpNotEqual) goto L007E;
            L0024: PushStack(player, 0xA7);
            L0028: PushStack(player, ax);
166B  0029 C4 5E 06  les bx, [bp+0x6]
166E  002C 26 FF 5F 54  call far word [es:bx+0x54]
            L0030: cx = PopStack(player);
            L0031: cx = PopStack(player);
            L0032: RefreshCompareFlags(ax);
            L0034: if (JumpNotEqual) goto L007E;
            L0036: PushStack(player, 0x67);
            L003A: PushStack(player, ax);
167D  003B C4 5E 06  les bx, [bp+0x6]
1680  003E 26 FF 5F 54  call far word [es:bx+0x54]
            L0042: cx = PopStack(player);
            L0043: cx = PopStack(player);
            L0044: RefreshCompareFlags(ax);
            L0046: if (JumpNotEqual) goto L007E;
            L0048: PushStack(player, 0x61);
            L004C: PushStack(player, ax);
168F  004D C4 5E 06  les bx, [bp+0x6]
1692  0050 26 FF 5F 54  call far word [es:bx+0x54]
            L0054: cx = PopStack(player);
            L0055: cx = PopStack(player);
            L0056: RefreshCompareFlags(ax);
            L0058: if (JumpNotEqual) goto L007E;
            L005A: PushStack(player, 0x93);
            L005E: PushStack(player, ax);
16A1  005F C4 5E 06  les bx, [bp+0x6]
16A4  0062 26 FF 5F 54  call far word [es:bx+0x54]
            L0066: cx = PopStack(player);
            L0067: cx = PopStack(player);
            L0068: RefreshCompareFlags(ax);
            L006A: if (JumpNotEqual) goto L007E;
            L006C: PushStack(player, 0x86);
            L0070: PushStack(player, ax);
16B3  0071 C4 5E 06  les bx, [bp+0x6]
16B6  0074 26 FF 5F 54  call far word [es:bx+0x54]
            L0078: cx = PopStack(player);
            L0079: cx = PopStack(player);
            L007A: RefreshCompareFlags(ax);
            L007C: if (JumpEqual) goto L00BE;
            L007E: ShowMessage(player, String1D63); // You've uncovered a hidden door!
            L008B: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L00A9: PushStack(player, GetFacing(player));
            L00B1: PushStack(player, GetCurrentTile(player));
16FB  00B9 B8 01 00  mov ax, 0x1
            L00BC: goto L00ED;
            L00BE: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L00DB: SetWallObject(player, 0x00, GetCurrentTile(player), GetFacing(player));
            L00F8: return; // RETURN;
        }

        private void Fn_19(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x000E);
            L0010: ax = HasItem(player, 0xBE);
            L001E: if (JumpEqual) goto L006E;
            L0020: ShowMessage(player, String0161); // *
            L002D: ShowMessage(player, String0161); // *
            L003A: ShowMessage(player, String0161); // *
            L0047: ShowMessage(player, String1015); // 'As I suspected!  That large letter of credit has my name upon it!  Deny it not!  I shall be magnanimous and assume that thou didst but find it upon thy path and held it for me.  Dost thou care to argue about it?'
            L0054: ShowMessage(player, String10EB); // You do not argue.  It's only money.
            L0061: PushStack(player, 0xBE);
17A6  0065 C4 5E 06  les bx, [bp+0x6]
17A9  0068 26 FF 5F 4C  call far word [es:bx+0x4c]
            L006C: goto L00BB;
            L006E: ShowMessage(player, String0161); // *
            L007B: ShowMessage(player, String0161); // *
            L0088: ShowMessage(player, String0161); // *
            L0095: ShowMessage(player, String1D83); // 'I said I am keeping an eye on thee, and a watchful eye it is.  An thou dost find my stolen horde, I shall expect thee to yield it to me with grace, lest I anger.'
            L00A2: ShowMessage(player, String11B2); // You don't want to see the dragon angered.
            L00AF: ShowMessage(player, String11DC); // Trust me on this.
            L00BC: return; // RETURN;
        }

    }
}
