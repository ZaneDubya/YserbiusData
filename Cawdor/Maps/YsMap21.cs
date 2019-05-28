#pragma warning disable
using System.Collections.Generic;
using XPT.WorldData;
using XPT.WorldData.Yserbius;

namespace XPT.Scripts.Yserbius.Maps {
    class YserMap21 : AMapScripted {
        protected override int MapIndex => 21;
        protected override int RandomEncounterChance => 0;
        protected override int RandomEncounterExtraCount => 0;

        public YserMap21() {
            MapEvent01 = Fn_01;
            MapEvent02 = Fn_02;
            MapEvent03 = Fn_03;
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
        }
        
        // === Strings ================================================
        private const string String0140 = "In a hidden wall recess with a sign reading 'For 'Emergency Use' you find a dusty bottle-shaped imprint labelled 'Juniper Juice.  But no bottle.'";
        private const string String01D2 = "Well, if you really think this is an emergency....";
        private const string String0205 = "The way you've been blundering around here, you better believe this is an emergency....";
        private const string String025D = "Now, now.  Don't take it personally.  You're really a very good player.  I was just teasing you.  There's no need to hit that complain button.  I'm sorry.  Really I am!";
        private const string String0306 = "Lessee.  You're in a room full of poisons and crazed alchemists.  Yup, this is an emergency.";
        private const string String0363 = "Well, I'm not going to tell you how to play.  But I think your parents raised a good little adventurer who wouldn't take emergency supplies unless you really needed them.";
        private const string String040E = "So if you want to risk breaking dear old mumsy's heart, that's up to you.";
        private const string String0458 = "Take the potion, take the potion!  Believe you me, any second now you're going to need it!";
        private const string String04B3 = "Go ahead!  Drink up, me hearties!  I get 5000 gold pieces for each replacement bottle.  Wassail!";
        private const string String0514 = "You know, from what I've heard, Juniper Juice is more commonly known as gin.  Of course, in cyberspace there are no hangovers, so enjoy!";
        private const string String059D = "You think I left all this Juniper Juice lying around just for you?  Think how many corpses there would be in here if we didn't have all these antidotes at hand.";
        private const string String063E = "Ninety-nine bottles of juice in the wall.  Ninety-nine bottles of juice.  Take one down, pass it around.  Still ninety-nine bottles of juice in the wall.";
        private const string String06D8 = "Heh heh.  The bottle SAYS it's Juniper Juice.  But can you believe everything you read?  Doesn't that cork look just a little discolored?";
        private const string String0762 = "Oh, I forgot: we didn't draw any cork closeups.  I guess it must be good.  You can trust me, can't you?";
        private const string String07CA = "The emergency supply cabinet is empty.";
        private const string String07F1 = "You mangled your skeleton keys, but the door is unlocked.  Now for Macbeth!";
        private const string String083D = "You have unlocked the hidden door.  Now for Macbeth!";
        private const string String0872 = "You detect a hidden door, but it is locked.";
        private const string String089E = "Your lockpick is no more.  It has ceased to key.  It's a stick.  Bereft of heft, it rests in pieces.  This is an ex-lockpick.";
        private const string String091C = "That was a stiff lock, but you finally got it open.";
        private const string String0950 = "This classroom, for so it is labelled, is probably locked for a reason.  I mean a reason other than to annoy you.";
        private const string String09C2 = "You hear some footsteps running away.";
        private const string String09E8 = "You've wandered into a cloud of noxious gas!  You've been poisoned.";
        private const string String0A2C = "You've wandered into a patch of a nasty poison gas!  You've been poisoned.";
        private const string String0A77 = "Hoo boy!  This was one super stinkerino cloud of gas!  Have you ever been poisoned!";
        private const string String0ACB = "Sulfur and brimstone!  The poor fool that brewed up this batch of noxious clouds must have died in the process, because you can barely fight off the effects!";
        private const string String0B69 = "A cold breeze sends shivers down your spine.";
        private const string String0B96 = "You squeeze into the attic.";
        private const string String0BB2 = "This large room once was set up as an auditorium.  There is a smashed podium and much rubble of laboratory equipment to the north.";
        private const string String0C35 = "Although the benches have been removed, you can see marks showing where they had been fastened to the floor.  Stained glass windows along the north wall let in some light and fresh air.";
        private const string String0CEF = "There is nothing useful in this pile of rubble.";
        private const string String0D1F = "Someone must have really hated this class, because he reduced the podium to kindling.";
        private const string String0D75 = "Things like this should be going down drains, not up your armor!";
        private const string String0DB6 = "Oh, great.  Those liches are letting the slimes run interference for them!";
        private const string String0E01 = "Those key lime blancmanges you fought here may have looked like dessert, but you wouldn't want to eat them.";
        private const string String0E6D = "You knew there were crazed alchemists about.  You may have found their ringleaders.";
        private const string String0EC1 = "They thought they could ring your chimes, but you managed to disband them.";
        private const string String0F0C = "It figures the undead would be immune to the poison clouds around here.  What didn't figure was that they would learn how to use poison themselves!";
        private const string String0FA0 = "In fact, they are out in force!";
        private const string String0FC0 = "All that remains of your battle here is a yukky lump of ectoplasm.";
        private const string String1003 = "It kind of reminds you of the key lime blancmange you fought here a bit ago.";
        private const string String1050 = "If potions gone wrong account for the existence of of these half humans, you're going to strongly consider leaving this room while you're still you!";
        private const string String10E5 = "All that remains of your battle here is a cloven hoof and a forked tongue.";
        private const string String1130 = "Gee.  In all the fairy tales you heard when you were growing up, there were good fairies and kindly old wizards.  These guys obviously didn't hear the same stories.";
        private const string String11D5 = "The guys you fought here came a reiving a little far north of where they live.  And they won't be going home.";
        private const string String1243 = "You overhear a snippet of conversation as two knights stroll by.";
        private const string String1284 = "'...southwest corner.  We tried an assault in force, but Macbeth's defenses were most puissant and we lost many brave knights.  I think me there must be another way to....'";
        private const string String1331 = "It's poison using folks like these that give elves a bad name.";
        private const string String1370 = "Oh, sure, they haven't had a bad name so far, but if you survive you're sure going to warn all your friends!";
        private const string String13DD = "She who lived by the sword died by your sword.";
        private const string String140C = "You wish that whoever was burying these undead would do a better job of it next time!";
        private const string String1462 = "The only good undead is an un-undead undead.  And you made some good undead here.";
        private const string String14B4 = "You overhear a snippet of conversation as two trolls limp past.  The speaker leans heavily on the other one.";
        private const string String1521 = "'...odds blood!  I did but wander too near to suit the madman, and was wounded nigh unto death by his defenders!  No parley, no opportunity to....";
        private const string String15B4 = "An alchemist is lecturing his pupils as they walk by.";
        private const string String15EA = "'...three parts hemlock, and a gill of powdered bone of a murderer.  Mix them with a cup of dragon's blood, and set them to simmer for at least six hours, adding water....'";
        private const string String1697 = "'God ye a good 'un, gentle friends.  I must say, hitherto I drastically underestimated the value of Juniper Juice, but I must admit that were it not for the plentiful compartments well-stocked hereabouts, I'd be a dead Hob.'";
        private const string String1778 = "The halfling wanders off, coughing.";
        private const string String179C = "An alchemist is instructing a customer in the proper application of a potion as they walk past.";
        private const string String17FC = "'...then you must cover yourselves in good goose grease and climb atop the hill nigh onto the cemetary.";
        private const string String1864 = "There you must howl at the moon fiercely, and then moon the moon most vigorously, with many a bounce.  Then return to thy home swinging a dead rat....'";
        private const string String18FC = "Some cures are worse than the disease.";
        private const string String1923 = "A customer pleads with his alchemist for a cure.";
        private const string String1954 = "'...know I swung a dead cat over my head.  I know 'twas not thy fault for the potion's misuse.  But as I value my life, Master Phickett, I must have redress.";
        private const string String19F2 = "I till my fields and she is upon me.  At the Rampant Cat Inn she is upon me.  Even when I do visit the privy....'";
        private const string String1A64 = "An alchemist is walking past, reading aloud, his head buried in a dusty tome.";
        private const string String1AB2 = "'...reserving the juice for gravy.  For the stuffing, for every five pounds of bird use one quarter loaf of bread, four handfuls of clean mushrooms, one cup of plums or prunes, a dozen chestnuts, a bay leaf, half a gill of stock....'";
        private const string String1B9C = "Even alchemists have to eat.";
        private const string String1BB9 = "An alchemist instructs her pupil.";
        private const string String1BDB = "'I care not that thou gavest the dragon's blood to that charlatan, Hippocrates Phickett!  Thou didst check out the blood and thou must replace it!";
        private const string String1C6E = "So pop along to the Aerie next door and bring us back half a barrel of fresh dragon's blood, or thou wilt be drinking experimentals until thy face melts!'";
        private const string String1D09 = "'...on earth possessed thee to promise the dragon a constant supply of dragon flagon in exchange for his blood?  Do you think we care for thy piddling little life?";
        private const string String1DAD = "This is a business, not a playground!  Stop snivelling!  All undergraduates must replace any used supplies.  It is in thy enrollment papers!  We care not that thou didst not apply lemon juice to expose the secret writing!  'Ods bodkins!'";
        private const string String1E9B = "Two alchemists converse.";
        private const string String1EB4 = "'...s'truth!  I replaced his sandalwood incense with poison ivy.  Did his spell work?  Do eggs bounce?";
        private const string String1F1B = "He has such a rash that he is red as an imp from scratching!  And he attributes it all to supernatural inter....'";
        private const string String1F8D = "Life's one big prank at Alchemical U.";
        private const string String1FB3 = "An alchemist rushes past, talking to himself and scratching vigorously.";
        private const string String1FFB = "'...not have been a piece of the true cross.  It must have been a false piece of the true cross.  None would dare sabotage such an expensive attempt to create a philosopher's stone.";
        private const string String20B1 = "But what can I use in its stead?  Perhaps the hem of a saint's cloak.  But which saint?'";
        private const string String210A = "Two alchemists are laughing loudly as they walk past.";
        private const string String2140 = "'...ments!  Elements, by all the saints in heaven!  And molecules, she called them.  Miniscule particles too small to be seen.  She called for purifying.  Purifying!";
        private const string String21E6 = "God's teeth!  Isn't unicorn scat already pure?  And then she said there is a tonic, and something subby tonic.  Most of us were rolling in the aisles by....'";
        private const string String2284 = "It all sounds rather silly, doesn't it?";
        private const string String22AC = "Two alchemists are arguing loudly as they walk past.";
        private const string String22E1 = "'...ments!  Elements, from the Greek!  Thou art a full professor; I assume a certain degree of education!";
        private const string String234B = "I made a microscope from pieces of curved glass and discovered that all that our gross senses perceive is in turn composed of smaller parts.  Yes, glass!";
        private const string String23E5 = "Curved glass!  Heaven take me an I bear false witness!  Oh!  Men!'";
        private const string String2428 = "An alchemist is talking to his owl familiar as they walk past.";
        private const string String2467 = "'...I know it is storming outside.  That is the point!  You must fly into the teeth of the storm trailing this silver wire.  When lightning strikes the wire, it will conduct electricity.  What?";
        private const string String2529 = "No, lightning will not hurt you!  Lightning doesn't hurt birds; every fool knows that!  I care not about your old fowl's tale about your uncle Owlfred!  Were you there?  Then....'";
        private const string String25DD = "An alchemist is talking to his slightly singed owl familiar as they walk past.";
        private const string String262C = "'...It must not have been natural lightning, I tell you!  Oh, thou and thy uncle Owlfred again.  Thy tailfeathers will grow back!";
        private const string String26AE = "Cease thy prattling!  If thou hadst not dropped the wire, then I would not need to repeat this experiment.  No, I am not going to find a sea bird familiar.  Every fool knows that wet feathers help birds fly!  Wouldst thou....'";
        private const string String2791 = "This closet has many containers of powdered bones.";
        private const string String27C4 = "This closet has many flasks full of various animal organs.";
        private const string String27FF = "This closet has many pouches filled with hair from many famous (or infamous) people.";
        private const string String2854 = "This closet has many samples of clothes once worn by sundry and diverse types of people.";
        private const string String28AD = "This closet is filled with a lumberyard's worth of pieces of the true cross.";
        private const string String28FA = "This closet has many containers of powdered flowers.";
        private const string String292F = "This closet has samples of spoor, skin, feathers, and fur from many different animals.";
        private const string String2986 = "This closet has dozens of lodestones of differing strengths and effectiveness.";
        private const string String29D5 = "All right.  So the label was wrong.  Take it up with the Alchemists Guild.  This closet was doubtlessly locked because it is full of shavings and samples of many precious metals and gems.";
        private const string String2A91 = "If you had a good fence you might be able to make some money here, but Cawdor isn't that kind of game.";
        private const string String2AF8 = "This closet is full of books and manuscripts, many of which bear burns and stains.";
        private const string String2B4B = "This closet has many empty containers and a large, oft-used wash tub.";
        private const string String2B91 = "You are grateful for the fresh air.  The weather outside is cold and blustery, but refreshing all the same.";
        private const string String2BFD = "This is one nasty little corridor.  Huge clouds of fumes are wafting in through overhead vents, as if it is intended to poison anyone who walks in here.  Like you, for instance!";
        
        // === Functions ================================================
        private void Fn_01(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: PushStack(player, 0x02);
            L0008: PushStack(player, 0x00);
001A  000B C4 5E 06  les bx, [bp+0x6]
001D  000E 26 FF 5F 04  call far word [es:bx+0x4]
            L0012: cx = PopStack(player);
            L0013: cx = PopStack(player);
            L0014: RefreshCompareFlags(ax);
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00F3;
            L001B: ShowMessage(player, String0140); // In a hidden wall recess with a sign reading 'For 'Emergency Use' you find a dusty bottle-shaped imprint labelled 'Juniper Juice.  But no bottle.'
            L0028: GiveItem(player, 0xC6);
            L0034: SetFlag(player, 0x00, 0x02, 0x01);
            L0048: si = GetFlag(player, 0x03, 0x08);
            L005B: Compare(si, 0x1E);
            L005E: if (JumpLess) goto L0062;
            L0060: si = 0;
            L0062: Compare(si, 0x14);
            L0065: if (JumpLessOrEqual) goto L006E;
0076  0067 8B C6  mov ax, si
            L0069: si = ax + 0xFFEC;
            L006E: Compare(si, 0x0A);
            L0071: if (JumpLess) goto L007A;
0082  0073 8B C6  mov ax, si
            L0075: si = ax + 0xFFF6;
            L007A: SetFlag(player, 0xC4, 0xB8, si);
            L008C: bx = si;
            L008E: Compare(bx, 0x09);
            L0091: if (JumpAbove) goto L0100;
            L0093: switch (bx) {
                case 0:
                    goto L009A;
                case 1:
                    goto L009F;
                case 2:
                    goto L00B1;
                case 3:
                    goto L00B6;
                case 4:
                    goto L00C8;
                case 5:
                    goto L00CD;
                case 6:
                    goto L00D2;
                case 7:
                    goto L00D7;
                case 8:
                    goto L00DC;
                case 9:
                    goto L00E1;
            }
00A9  009A B8 D2 01  mov ax, 0x1d2
            L009D: goto L00F6;
            L009F: ShowMessage(player, String0205); // The way you've been blundering around here, you better believe this is an emergency....
00BB  00AC B8 5D 02  mov ax, 0x25d
            L00AF: goto L00F6;
00C0  00B1 B8 06 03  mov ax, 0x306
            L00B4: goto L00F6;
            L00B6: ShowMessage(player, String0363); // Well, I'm not going to tell you how to play.  But I think your parents raised a good little adventurer who wouldn't take emergency supplies unless you really needed them.
00D2  00C3 B8 0E 04  mov ax, 0x40e
            L00C6: goto L00F6;
00D7  00C8 B8 58 04  mov ax, 0x458
            L00CB: goto L00F6;
00DC  00CD B8 B3 04  mov ax, 0x4b3
            L00D0: goto L00F6;
00E1  00D2 B8 14 05  mov ax, 0x514
            L00D5: goto L00F6;
00E6  00D7 B8 9D 05  mov ax, 0x59d
            L00DA: goto L00F6;
00EB  00DC B8 3E 06  mov ax, 0x63e
            L00DF: goto L00F6;
            L00E1: ShowMessage(player, String06D8); // Heh heh.  The bottle SAYS it's Juniper Juice.  But can you believe everything you read?  Doesn't that cork look just a little discolored?
00FD  00EE B8 62 07  mov ax, 0x762
            L00F1: goto L00F6;
            L00F3: ShowMessage(player, String07CA); // The emergency supply cabinet is empty.
            L0100: return; // RETURN (restoring si);
        }

        private void Fn_02(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, 0x0D), 0x000B);
            L0012: if (JumpBelow) goto L0017;
            L0014: goto L009C;
            L0017: RefreshCompareFlags(HasUsedSpell(player, 0x17));
            L0025: if (JumpNotEqual) goto L009C;
            L0027: PushStack(player, 0x67);
            L002B: PushStack(player, ax);
0152  002C C4 5E 06  les bx, [bp+0x6]
0155  002F 26 FF 5F 54  call far word [es:bx+0x54]
            L0033: cx = PopStack(player);
            L0034: cx = PopStack(player);
            L0035: RefreshCompareFlags(ax);
            L0037: if (JumpNotEqual) goto L009C;
            L0039: PushStack(player, 0x61);
            L003D: PushStack(player, ax);
0164  003E C4 5E 06  les bx, [bp+0x6]
0167  0041 26 FF 5F 54  call far word [es:bx+0x54]
            L0045: cx = PopStack(player);
            L0046: cx = PopStack(player);
            L0047: RefreshCompareFlags(ax);
            L0049: if (JumpNotEqual) goto L009C;
            L004B: PushStack(player, 0x93);
            L004F: PushStack(player, ax);
0176  0050 C4 5E 06  les bx, [bp+0x6]
0179  0053 26 FF 5F 54  call far word [es:bx+0x54]
            L0057: cx = PopStack(player);
            L0058: cx = PopStack(player);
            L0059: RefreshCompareFlags(ax);
            L005B: if (JumpNotEqual) goto L009C;
            L005D: PushStack(player, 0x86);
            L0061: PushStack(player, ax);
0188  0062 C4 5E 06  les bx, [bp+0x6]
018B  0065 26 FF 5F 54  call far word [es:bx+0x54]
            L0069: cx = PopStack(player);
            L006A: cx = PopStack(player);
            L006B: RefreshCompareFlags(ax);
            L006D: if (JumpNotEqual) goto L009C;
            L006F: Compare(GetFlag(player, 0x02, 0x14), 0x0001);
            L0083: if (JumpEqual) goto L009C;
            L0085: ax = IsFlagOn(player, 0x00, 0x01);
            L0097: if (JumpNotEqual) goto L009C;
            L0099: goto L0223;
            L009C: SetWallObject(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L00BA: PushStack(player, 0x01);
            L00BE: PushStack(player, ax);
            L00BF: PushStack(player, 0x00);
01E8  00C2 C4 5E 06  les bx, [bp+0x6]
01EB  00C5 26 FF 1F  call far word [es:bx]
01EE  00C8 83 C4 06  add sp, 0x6
            L00CB: PushStack(player, 0x68);
            L00CF: PushStack(player, ax);
01F6  00D0 C4 5E 06  les bx, [bp+0x6]
01F9  00D3 26 FF 5F 54  call far word [es:bx+0x54]
            L00D7: cx = PopStack(player);
            L00D8: cx = PopStack(player);
            L00D9: RefreshCompareFlags(ax);
            L00DB: if (JumpNotEqual) goto L00EE;
            L00DD: Compare(HasUsedSkill(player, 0x0E), 0x0009);
            L00EC: if (JumpBelowOrEqual) goto L012E;
            L00EE: ax = HasItem(player, 0xDA);
            L00FC: if (JumpNotEqual) goto L017C;
            L00FE: ax = HasItem(player, 0xDB);
            L010C: if (JumpNotEqual) goto L017C;
            L010E: ax = HasItem(player, 0xDC);
            L011C: if (JumpNotEqual) goto L017C;
            L011E: ax = HasItem(player, 0xDD);
            L012C: if (JumpNotEqual) goto L017C;
            L012E: PushStack(player, 0xC0);
            L0132: PushStack(player, ax);
0259  0133 C4 5E 06  les bx, [bp+0x6]
025C  0136 26 FF 5F 54  call far word [es:bx+0x54]
            L013A: cx = PopStack(player);
            L013B: cx = PopStack(player);
            L013C: RefreshCompareFlags(ax);
            L013E: if (JumpNotEqual) goto L017C;
            L0140: Compare(GetFlag(player, 0x02, 0x14), 0x0001);
            L0154: if (JumpEqual) goto L017C;
            L0156: Compare(GetSkillLevel(player, 0x0E), 0x000A);
            L0165: if (JumpBelow) goto L01B1;
            L0167: ax = HasUsedItem(player, 0xDA, 0xDD);
            L017A: if (JumpEqual) goto L01B1;
            L017C: PushStack(player, 0xC0);
            L0180: PushStack(player, ax);
02A7  0181 C4 5E 06  les bx, [bp+0x6]
02AA  0184 26 FF 5F 54  call far word [es:bx+0x54]
            L0188: cx = PopStack(player);
            L0189: cx = PopStack(player);
            L018A: RefreshCompareFlags(ax);
            L018C: if (JumpEqual) goto L019F;
            L018E: RemoveItem(player, 0xC0);
02C0  019A B8 F1 07  mov ax, 0x7f1
            L019D: goto L01A2;
            L019F: ShowMessage(player, String083D); // You have unlocked the hidden door.  Now for Macbeth!
02D2  01AC B8 01 00  mov ax, 0x1
            L01AF: goto L0225;
            L01B1: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L01CE: ShowMessage(player, String0872); // You detect a hidden door, but it is locked.
            L01DB: ax = HasUsedItem(player, 0xC1, 0xC3);
            L01EE: if (JumpEqual) goto L0240;
            L01F0: RemoveItem(player, 0xC1);
            L01FC: RemoveItem(player, 0xC2);
            L0208: RemoveItem(player, 0xC3);
            L0214: ShowMessage(player, String089E); // Your lockpick is no more.  It has ceased to key.  It's a stick.  Bereft of heft, it rests in pieces.  This is an ex-lockpick.
            L0221: goto L0240;
            L0223: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0240: return; // RETURN;
        }

        private void Fn_03(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x68);
            L0007: PushStack(player, ax);
0370  0008 C4 5E 06  les bx, [bp+0x6]
0373  000B 26 FF 5F 54  call far word [es:bx+0x54]
            L000F: cx = PopStack(player);
            L0010: cx = PopStack(player);
            L0011: RefreshCompareFlags(ax);
            L0013: if (JumpNotEqual) goto L0026;
            L0015: Compare(HasUsedSkill(player, 0x0E), 0x0009);
            L0024: if (JumpBelowOrEqual) goto L006C;
            L0026: ax = HasItem(player, 0xDA);
            L0034: if (JumpEqual) goto L0039;
            L0036: goto L00CC;
            L0039: ax = HasItem(player, 0xDB);
            L0047: if (JumpEqual) goto L004C;
            L0049: goto L00CC;
            L004C: ax = HasItem(player, 0xDC);
            L005A: if (JumpNotEqual) goto L00CC;
            L005C: ax = HasItem(player, 0xDD);
            L006A: if (JumpNotEqual) goto L00CC;
            L006C: Compare(GetSkillLevel(player, 0x0E), 0x0009);
            L007B: if (JumpBelow) goto L00A4;
            L007D: PushStack(player, 0xC3);
            L0081: PushStack(player, ax);
03EA  0082 C4 5E 06  les bx, [bp+0x6]
03ED  0085 26 FF 5F 54  call far word [es:bx+0x54]
            L0089: cx = PopStack(player);
            L008A: cx = PopStack(player);
            L008B: RefreshCompareFlags(ax);
            L008D: if (JumpNotEqual) goto L00CC;
            L008F: ax = HasUsedItem(player, 0xDA, 0xDD);
            L00A2: if (JumpNotEqual) goto L00CC;
            L00A4: Compare(GetFlag(player, 0x02, 0x14), 0x0001);
            L00B8: if (JumpEqual) goto L00CC;
            L00BA: PushStack(player, 0xC0);
            L00BE: PushStack(player, ax);
0427  00BF C4 5E 06  les bx, [bp+0x6]
042A  00C2 26 FF 5F 54  call far word [es:bx+0x54]
            L00C6: cx = PopStack(player);
            L00C7: cx = PopStack(player);
            L00C8: RefreshCompareFlags(ax);
            L00CA: if (JumpEqual) goto L00FA;
            L00CC: ShowMessage(player, String091C); // That was a stiff lock, but you finally got it open.
            L00D9: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L00F7: goto L017F;
            L00FA: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0117: ax = HasUsedItem(player, 0xC1, 0xC3);
            L012A: if (JumpEqual) goto L0155;
            L012C: RemoveItem(player, 0xC1);
            L0138: RemoveItem(player, 0xC2);
            L0144: RemoveItem(player, 0xC3);
04B8  0150 B8 9E 08  mov ax, 0x89e
            L0153: goto L0175;
            L0155: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0172: ShowMessage(player, String0950); // This classroom, for so it is labelled, is probably locked for a reason.  I mean a reason other than to annoy you.
            L017F: return; // RETURN;
        }

        private void Fn_05(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si, di);
            L0005: di = 0;
            L0007: si = 0;
            L0009: ax = GetFlag(player, 0x02, 0x53);
0508  001A 8B F8  mov di, ax
050A  001C 47     inc di
050B  001D 8B F7  mov si, di
            L001F: Compare(si, 0x13);
            L0022: if (JumpLessOrEqual) goto L002B;
0512  0024 8B C6  mov ax, si
            L0026: si = ax + 0xFFEC;
            L002B: Compare(si, 0x0E);
            L002E: if (JumpLessOrEqual) goto L0037;
051E  0030 8B C6  mov ax, si
            L0032: si = ax + 0xFFF1;
            L0037: Compare(si, 0x09);
            L003A: if (JumpLessOrEqual) goto L0043;
052A  003C 8B C6  mov ax, si
            L003E: si = ax + 0xFFF6;
            L0043: Compare(si, 0x04);
            L0046: if (JumpLessOrEqual) goto L004F;
0536  0048 8B C6  mov ax, si
            L004A: si = ax + 0xFFFB;
053D  004F 0B F6  or si, si
053F  0051 7D 02  jge 0x55
            L0053: si = 0;
            L0055: Compare(si, 0x1D);
            L0058: if (JumpLessOrEqual) goto L005C;
            L005A: si = 0;
054A  005C 83 FF 1E  cmp di, 0x1e
            L005F: if (JumpLessOrEqual) goto L0063;
            L0061: di = 0;
0551  0063 57     push di
            L0064: PushStack(player, 0x53);
            L0068: PushStack(player, 0x02);
055A  006C C4 5E 06  les bx, [bp+0x6]
055D  006F 26 FF 1F  call far word [es:bx]
0560  0072 83 C4 06  add sp, 0x6
0563  0075 83 FF 1A  cmp di, 0x1a
            L0078: if (JumpNotEqual) goto L007F;
0568  007A B8 01 00  mov ax, 0x1
            L007D: goto L0081;
            L007F: PushStack(player, 0x00);
0570  0082 83 FF 14  cmp di, 0x14
            L0085: if (JumpNotEqual) goto L008C;
0575  0087 B8 01 00  mov ax, 0x1
            L008A: goto L008E;
057A  008C 33 C0  xor ax, ax
            L008E: dx = PopStack(player);
057D  008F 0B D0  or dx, ax
            L0091: PushStack(player, dx);
0580  0092 83 FF 0E  cmp di, 0xe
            L0095: if (JumpNotEqual) goto L009C;
0585  0097 B8 01 00  mov ax, 0x1
            L009A: goto L009E;
058A  009C 33 C0  xor ax, ax
            L009E: dx = PopStack(player);
058D  009F 0B D0  or dx, ax
            L00A1: PushStack(player, dx);
0590  00A2 83 FF 08  cmp di, 0x8
            L00A5: if (JumpNotEqual) goto L00AC;
0595  00A7 B8 01 00  mov ax, 0x1
            L00AA: goto L00AE;
059A  00AC 33 C0  xor ax, ax
            L00AE: dx = PopStack(player);
059D  00AF 0B D0  or dx, ax
            L00B1: PushStack(player, dx);
05A0  00B2 83 FF 02  cmp di, 0x2
            L00B5: if (JumpNotEqual) goto L00BC;
05A5  00B7 B8 01 00  mov ax, 0x1
            L00BA: goto L00BE;
05AA  00BC 33 C0  xor ax, ax
            L00BE: dx = PopStack(player);
05AD  00BF 0B D0  or dx, ax
            L00C1: if (JumpNotEqual) goto L00C6;
            L00C3: goto L0181;
            L00C6: bx = si;
            L00C8: Compare(bx, 0x04);
            L00CB: if (JumpBelowOrEqual) goto L00D0;
            L00CD: goto L0181;
            L00D0: switch (bx) {
                case 0:
                    goto L00D7;
                case 1:
                    goto L00E7;
                case 2:
                    goto L010A;
                case 3:
                    goto L012D;
                case 4:
                    goto L0150;
            }
            L00D7: ShowMessage(player, String09C2); // You hear some footsteps running away.
            L00E4: goto L0181;
            L00E7: ShowMessage(player, String09E8); // You've wandered into a cloud of noxious gas!  You've been poisoned.
            L00F4: DamagePlayer(player, 0x01F4);
05EF  0101 B8 F4 01  mov ax, 0x1f4
            L0104: PushStack(player, ax);
05F3  0105 B8 03 00  mov ax, 0x3
            L0108: goto L0171;
            L010A: ShowMessage(player, String0A2C); // You've wandered into a patch of a nasty poison gas!  You've been poisoned.
            L0117: DamagePlayer(player, 0x03E8);
0612  0124 B8 E8 03  mov ax, 0x3e8
            L0127: PushStack(player, ax);
0616  0128 B8 04 00  mov ax, 0x4
            L012B: goto L0171;
            L012D: ShowMessage(player, String0A77); // Hoo boy!  This was one super stinkerino cloud of gas!  Have you ever been poisoned!
            L013A: DamagePlayer(player, 0x05DC);
0635  0147 B8 DC 05  mov ax, 0x5dc
            L014A: PushStack(player, ax);
0639  014B B8 05 00  mov ax, 0x5
            L014E: goto L0171;
            L0150: ShowMessage(player, String0ACB); // Sulfur and brimstone!  The poor fool that brewed up this batch of noxious clouds must have died in the process, because you can barely fight off the effects!
            L015D: DamagePlayer(player, 0x07D0);
0658  016A B8 D0 07  mov ax, 0x7d0
            L016D: PushStack(player, ax);
            L016E: PushStack(player, 0x06);
            L0172: PushStack(player, 0x01);
0664  0176 C4 5E 06  les bx, [bp+0x6]
0667  0179 26 FF 9F 9C 00  call far word [es:bx+0x9c]
066C  017E 83 C4 06  add sp, 0x6
            L0181: return; // RETURN (restoring si, di);
        }

        private void Fn_06(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0B69); // A cold breeze sends shivers down your spine.
            L0010: return; // RETURN;
        }

        private void Fn_07(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0B96); // You squeeze into the attic.
            L0010: TeleportParty(player, 0x0B, 0x03, 0x0B, 0x01, isForwardMove);
            L002B: return; // RETURN;
        }

        private void Fn_08(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFlag(player, 0x02, 0x22, 0x01);
            L0018: SetFlag(player, 0x02, 0x3A, 0x00);
            L002C: return; // RETURN;
        }

        private void Fn_09(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFlag(player, 0x02, 0x22, 0x01);
            L0018: SetFlag(player, 0x02, 0x3A, 0x00);
            L002C: RefreshCompareFlags(GetFlag(player, 0x03, 0x0A));
            L003F: if (JumpNotEqual) goto L0070;
            L0041: SetFlag(player, 0x03, 0x0A, 0x01);
            L0056: ShowMessage(player, String0BB2); // This large room once was set up as an auditorium.  There is a smashed podium and much rubble of laboratory equipment to the north.
            L0063: ShowMessage(player, String0C35); // Although the benches have been removed, you can see marks showing where they had been fastened to the floor.  Stained glass windows along the north wall let in some light and fresh air.
            L0070: return; // RETURN;
        }

        private void Fn_0A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0CEF); // There is nothing useful in this pile of rubble.
            L0010: return; // RETURN;
        }

        private void Fn_0B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0D1F); // Someone must have really hated this class, because he reduced the podium to kindling.
            L0010: return; // RETURN;
        }

        private void Fn_0C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFlag(player, 0x02, 0x3A, 0x01);
            L0018: TeleportParty(player, 0x09, 0x02, 0xDF, 0x00, isForwardMove);
            L0032: return; // RETURN;
        }

        private void Fn_0D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFlag(player, 0x02, 0x3A, 0x02);
            L0018: TeleportParty(player, 0x09, 0x02, 0xEF, 0x00, isForwardMove);
            L0032: return; // RETURN;
        }

        private void Fn_0E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFlag(player, 0x02, 0x3A, 0x03);
            L0018: TeleportParty(player, 0x09, 0x02, 0xFF, 0x00, isForwardMove);
            L0032: return; // RETURN;
        }

        private void Fn_0F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x01));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00FB;
            L001B: PushStack(player, 0x01);
            L001F: PushStack(player, ax);
            L0020: PushStack(player, 0x03);
0840  0024 C4 5E 06  les bx, [bp+0x6]
0843  0027 26 FF 1F  call far word [es:bx]
0846  002A 83 C4 06  add sp, 0x6
            L002D: ShowMessage(player, String0D75); // Things like this should be going down drains, not up your armor!
            L003A: Compare(PartyCount(player), 0x0003);
            L0045: if (JumpBelowOrEqual) goto L0054;
            L0047: ShowMessage(player, String0DB6); // Oh, great.  Those liches are letting the slimes run interference for them!
0870  0054 B8 4F 03  mov ax, 0x34f
            L0057: PushStack(player, ax);
            L0058: PushStack(player, 0x00);
            L005B: PushStack(player, ax);
            L005C: PushStack(player, 0xBA);
            L0060: PushStack(player, 0x68);
            L0064: PushStack(player, 0x17);
0884  0068 C4 5E 06  les bx, [bp+0x6]
0887  006B 26 FF 9F D8 00  call far word [es:bx+0xd8]
088C  0070 83 C4 0C  add sp, 0xc
            L0073: AddEncounter(player, 0x01, 0x28);
            L0085: AddEncounter(player, 0x02, 0x28);
            L0097: Compare(PartyCount(player), 0x0001);
            L00A2: if (JumpBelowOrEqual) goto L00C8;
            L00A4: AddEncounter(player, 0x03, 0x28);
            L00B6: AddEncounter(player, 0x04, 0x28);
            L00C8: Compare(PartyCount(player), 0x0003);
            L00D3: if (JumpBelowOrEqual) goto L0108;
            L00D5: AddEncounter(player, 0x05, 0x24);
            L00E7: AddEncounter(player, 0x06, 0x24);
            L00F9: goto L0108;
            L00FB: ShowMessage(player, String0E01); // Those key lime blancmanges you fought here may have looked like dessert, but you wouldn't want to eat them.
            L0108: return; // RETURN;
        }

        private void Fn_10(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x02));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00FB;
            L001B: SetFlag(player, 0x03, 0x02, 0x01);
            L0030: ShowMessage(player, String0E6D); // You knew there were crazed alchemists about.  You may have found their ringleaders.
0963  003D B8 F4 01  mov ax, 0x1f4
            L0040: PushStack(player, ax);
            L0041: PushStack(player, 0x05);
            L0045: PushStack(player, 0x01);
096F  0049 C4 5E 06  les bx, [bp+0x6]
0972  004C 26 FF 9F 9C 00  call far word [es:bx+0x9c]
0977  0051 83 C4 06  add sp, 0x6
097A  0054 B8 BF 01  mov ax, 0x1bf
            L0057: PushStack(player, ax);
            L0058: PushStack(player, 0x00);
            L005B: PushStack(player, ax);
            L005C: PushStack(player, 0x94);
            L0060: PushStack(player, 0xCD);
            L0064: PushStack(player, 0x93);
098E  0068 C4 5E 06  les bx, [bp+0x6]
0991  006B 26 FF 9F D8 00  call far word [es:bx+0xd8]
0996  0070 83 C4 0C  add sp, 0xc
            L0073: AddEncounter(player, 0x01, 0x23);
            L0085: AddEncounter(player, 0x02, 0x21);
            L0097: Compare(PartyCount(player), 0x0002);
            L00A2: if (JumpBelowOrEqual) goto L00C8;
            L00A4: AddEncounter(player, 0x05, 0x20);
            L00B6: AddEncounter(player, 0x06, 0x20);
            L00C8: Compare(PartyCount(player), 0x0003);
            L00D3: if (JumpBelowOrEqual) goto L0108;
            L00D5: AddEncounter(player, 0x04, 0x22);
            L00E7: AddEncounter(player, 0x03, 0x22);
            L00F9: goto L0108;
            L00FB: ShowMessage(player, String0EC1); // They thought they could ring your chimes, but you managed to disband them.
            L0108: return; // RETURN;
        }

        private void Fn_11(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x03);
            L0007: PushStack(player, ax);
0A38  0008 C4 5E 06  les bx, [bp+0x6]
0A3B  000B 26 FF 5F 04  call far word [es:bx+0x4]
            L000F: cx = PopStack(player);
            L0010: cx = PopStack(player);
            L0011: RefreshCompareFlags(ax);
            L0013: if (JumpEqual) goto L0018;
            L0015: goto L010F;
            L0018: PushStack(player, 0x01);
            L001C: PushStack(player, 0x03);
            L0020: PushStack(player, ax);
0A51  0021 C4 5E 06  les bx, [bp+0x6]
0A54  0024 26 FF 1F  call far word [es:bx]
0A57  0027 83 C4 06  add sp, 0x6
0A5A  002A B8 F4 01  mov ax, 0x1f4
            L002D: PushStack(player, ax);
            L002E: PushStack(player, 0x05);
            L0032: PushStack(player, 0x01);
0A66  0036 C4 5E 06  les bx, [bp+0x6]
0A69  0039 26 FF 9F 9C 00  call far word [es:bx+0x9c]
0A6E  003E 83 C4 06  add sp, 0x6
            L0041: ShowMessage(player, String0F0C); // It figures the undead would be immune to the poison clouds around here.  What didn't figure was that they would learn how to use poison themselves!
            L004E: Compare(PartyCount(player), 0x0003);
            L0059: if (JumpBelowOrEqual) goto L0068;
            L005B: ShowMessage(player, String0FA0); // In fact, they are out in force!
0A98  0068 B8 47 03  mov ax, 0x347
            L006B: PushStack(player, ax);
            L006C: PushStack(player, 0x00);
            L006F: PushStack(player, ax);
            L0070: PushStack(player, 0xBA);
            L0074: PushStack(player, 0xF2);
            L0078: PushStack(player, 0x54);
0AAC  007C C4 5E 06  les bx, [bp+0x6]
0AAF  007F 26 FF 9F D8 00  call far word [es:bx+0xd8]
0AB4  0084 83 C4 0C  add sp, 0xc
            L0087: AddEncounter(player, 0x01, 0x1E);
            L0099: AddEncounter(player, 0x02, 0x1F);
            L00AB: Compare(PartyCount(player), 0x0002);
            L00B6: if (JumpBelowOrEqual) goto L00DC;
            L00B8: AddEncounter(player, 0x04, 0x25);
            L00CA: AddEncounter(player, 0x03, 0x25);
            L00DC: Compare(PartyCount(player), 0x0003);
            L00E7: if (JumpBelowOrEqual) goto L013F;
            L00E9: AddEncounter(player, 0x05, 0x1D);
            L00FB: AddEncounter(player, 0x06, 0x1D);
            L010D: goto L013F;
            L010F: ShowMessage(player, String0FC0); // All that remains of your battle here is a yukky lump of ectoplasm.
            L011C: Compare(GetFlag(player, 0x03, 0x01), 0x0001);
            L0130: if (JumpNotEqual) goto L013F;
            L0132: ShowMessage(player, String1003); // It kind of reminds you of the key lime blancmange you fought here a bit ago.
            L013F: return; // RETURN;
        }

        private void Fn_12(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x04));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00E1;
            L001B: SetFlag(player, 0x03, 0x04, 0x01);
            L0030: ShowMessage(player, String1050); // If potions gone wrong account for the existence of of these half humans, you're going to strongly consider leaving this room while you're still you!
            L003D: PushStack(player, 0xD4);
            L0041: PushStack(player, 0x00);
            L0044: PushStack(player, ax);
            L0045: PushStack(player, ax);
            L0046: PushStack(player, 0x66);
            L004A: PushStack(player, 0x0A);
0BBF  004E C4 5E 06  les bx, [bp+0x6]
0BC2  0051 26 FF 9F D8 00  call far word [es:bx+0xd8]
0BC7  0056 83 C4 0C  add sp, 0xc
            L0059: AddEncounter(player, 0x01, 0x27);
            L006B: AddEncounter(player, 0x02, 0x27);
            L007D: AddEncounter(player, 0x05, 0x26);
            L008F: Compare(PartyCount(player), 0x0002);
            L009A: if (JumpBelowOrEqual) goto L00C0;
            L009C: AddEncounter(player, 0x06, 0x26);
            L00AE: AddEncounter(player, 0x03, 0x27);
            L00C0: Compare(PartyCount(player), 0x0003);
            L00CB: if (JumpBelowOrEqual) goto L00EE;
            L00CD: AddEncounter(player, 0x04, 0x27);
            L00DF: goto L00EE;
            L00E1: ShowMessage(player, String10E5); // All that remains of your battle here is a cloven hoof and a forked tongue.
            L00EE: return; // RETURN;
        }

        private void Fn_13(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x05));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00EB;
            L001B: SetFlag(player, 0x03, 0x05, 0x01);
            L0030: ShowMessage(player, String1130); // Gee.  In all the fairy tales you heard when you were growing up, there were good fairies and kindly old wizards.  These guys obviously didn't hear the same stories.
0C9E  003D B8 20 03  mov ax, 0x320
            L0040: PushStack(player, ax);
            L0041: PushStack(player, 0x05);
            L0045: PushStack(player, 0x01);
0CAA  0049 C4 5E 06  les bx, [bp+0x6]
0CAD  004C 26 FF 9F 9C 00  call far word [es:bx+0x9c]
0CB2  0051 83 C4 06  add sp, 0x6
            L0054: PushStack(player, 0xD4);
            L0058: PushStack(player, 0x00);
            L005B: PushStack(player, ax);
            L005C: PushStack(player, ax);
            L005D: PushStack(player, 0x8B);
            L0061: PushStack(player, 0x22);
0CC6  0065 C4 5E 06  les bx, [bp+0x6]
0CC9  0068 26 FF 9F D8 00  call far word [es:bx+0xd8]
0CCE  006D 83 C4 0C  add sp, 0xc
            L0070: AddEncounter(player, 0x01, 0x19);
            L0082: AddEncounter(player, 0x02, 0x19);
            L0094: AddEncounter(player, 0x05, 0x1B);
            L00A6: AddEncounter(player, 0x06, 0x1C);
            L00B8: Compare(PartyCount(player), 0x0003);
            L00C3: if (JumpBelowOrEqual) goto L00F8;
            L00C5: AddEncounter(player, 0x03, 0x1B);
            L00D7: AddEncounter(player, 0x04, 0x1C);
            L00E9: goto L00F8;
            L00EB: ShowMessage(player, String11D5); // The guys you fought here came a reiving a little far north of where they live.  And they won't be going home.
            L00F8: return; // RETURN;
        }

        private void Fn_14(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x0B));
            L0016: if (JumpNotEqual) goto L0054;
            L0018: SetFlag(player, 0x03, 0x0B, 0x01);
            L002D: ShowPortrait(player, 0x001C);
            L003A: ShowMessage(player, String1243); // You overhear a snippet of conversation as two knights stroll by.
            L0047: ShowMessage(player, String1284); // '...southwest corner.  We tried an assault in force, but Macbeth's defenses were most puissant and we lost many brave knights.  I think me there must be another way to....'
            L0054: return; // RETURN;
        }

        private void Fn_15(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x06));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L0108;
            L001B: SetFlag(player, 0x03, 0x06, 0x01);
0DE1  0030 B8 E8 03  mov ax, 0x3e8
            L0033: PushStack(player, ax);
            L0034: PushStack(player, 0x05);
            L0038: PushStack(player, 0x01);
0DED  003C C4 5E 06  les bx, [bp+0x6]
0DF0  003F 26 FF 9F 9C 00  call far word [es:bx+0x9c]
0DF5  0044 83 C4 06  add sp, 0x6
            L0047: ShowMessage(player, String1331); // It's poison using folks like these that give elves a bad name.
            L0054: ShowMessage(player, String1370); // Oh, sure, they haven't had a bad name so far, but if you survive you're sure going to warn all your friends!
0E12  0061 B8 1C 0C  mov ax, 0xc1c
            L0064: PushStack(player, ax);
            L0065: PushStack(player, 0x00);
            L0068: PushStack(player, ax);
            L0069: PushStack(player, 0xBB);
            L006D: PushStack(player, 0xF4);
            L0071: PushStack(player, 0x80);
0E26  0075 C4 5E 06  les bx, [bp+0x6]
0E29  0078 26 FF 9F D8 00  call far word [es:bx+0xd8]
0E2E  007D 83 C4 0C  add sp, 0xc
            L0080: AddEncounter(player, 0x01, 0x1A);
            L0092: AddEncounter(player, 0x05, 0x1A);
            L00A4: Compare(PartyCount(player), 0x0002);
            L00AF: if (JumpBelowOrEqual) goto L00D5;
            L00B1: AddEncounter(player, 0x02, 0x1A);
            L00C3: AddEncounter(player, 0x06, 0x1A);
            L00D5: Compare(PartyCount(player), 0x0003);
            L00E0: if (JumpBelowOrEqual) goto L0115;
            L00E2: AddEncounter(player, 0x03, 0x1A);
            L00F4: AddEncounter(player, 0x04, 0x1A);
            L0106: goto L0115;
            L0108: ShowMessage(player, String13DD); // She who lived by the sword died by your sword.
            L0115: return; // RETURN;
        }

        private void Fn_16(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x07));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00FB;
            L001B: SetFlag(player, 0x03, 0x07, 0x01);
0EF8  0030 B8 E8 03  mov ax, 0x3e8
            L0033: PushStack(player, ax);
            L0034: PushStack(player, 0x05);
            L0038: PushStack(player, 0x01);
0F04  003C C4 5E 06  les bx, [bp+0x6]
0F07  003F 26 FF 9F 9C 00  call far word [es:bx+0x9c]
0F0C  0044 83 C4 06  add sp, 0x6
            L0047: ShowMessage(player, String140C); // You wish that whoever was burying these undead would do a better job of it next time!
0F1C  0054 B8 6F 06  mov ax, 0x66f
            L0057: PushStack(player, ax);
            L0058: PushStack(player, 0x00);
            L005B: PushStack(player, ax);
            L005C: PushStack(player, 0xCE);
            L0060: PushStack(player, 0xAE);
            L0064: PushStack(player, 0x93);
0F30  0068 C4 5E 06  les bx, [bp+0x6]
0F33  006B 26 FF 9F D8 00  call far word [es:bx+0xd8]
0F38  0070 83 C4 0C  add sp, 0xc
            L0073: AddEncounter(player, 0x01, 0x1D);
            L0085: AddEncounter(player, 0x02, 0x1E);
            L0097: AddEncounter(player, 0x05, 0x24);
            L00A9: Compare(PartyCount(player), 0x0002);
            L00B4: if (JumpBelowOrEqual) goto L00DA;
            L00B6: AddEncounter(player, 0x04, 0x1F);
            L00C8: AddEncounter(player, 0x03, 0x1F);
            L00DA: Compare(PartyCount(player), 0x0003);
            L00E5: if (JumpBelowOrEqual) goto L0108;
            L00E7: AddEncounter(player, 0x06, 0x24);
            L00F9: goto L0108;
            L00FB: ShowMessage(player, String1462); // The only good undead is an un-undead undead.  And you made some good undead here.
            L0108: return; // RETURN;
        }

        private void Fn_17(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x09, 0x02, 0x5F, 0x00, isForwardMove);
            L001D: return; // RETURN;
        }

        private void Fn_18(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x0C));
            L0016: if (JumpNotEqual) goto L0054;
            L0018: SetFlag(player, 0x03, 0x0C, 0x01);
            L002D: ShowPortrait(player, 0x0028);
            L003A: ShowMessage(player, String14B4); // You overhear a snippet of conversation as two trolls limp past.  The speaker leans heavily on the other one.
            L0047: ShowMessage(player, String1521); // '...odds blood!  I did but wander too near to suit the madman, and was wounded nigh unto death by his defenders!  No parley, no opportunity to....
            L0054: return; // RETURN;
        }

        private void Fn_19(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x0E));
            L0016: if (JumpNotEqual) goto L0054;
            L0018: SetFlag(player, 0x03, 0x0E, 0x01);
            L002D: ShowPortrait(player, 0x002D);
            L003A: ShowMessage(player, String15B4); // An alchemist is lecturing his pupils as they walk by.
            L0047: ShowMessage(player, String15EA); // '...three parts hemlock, and a gill of powdered bone of a murderer.  Mix them with a cup of dragon's blood, and set them to simmer for at least six hours, adding water....'
            L0054: return; // RETURN;
        }

        private void Fn_1A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x0D));
            L0016: if (JumpNotEqual) goto L0054;
            L0018: SetFlag(player, 0x03, 0x0D, 0x01);
            L002D: ShowPortrait(player, 0x0025);
            L003A: ShowMessage(player, String1697); // 'God ye a good 'un, gentle friends.  I must say, hitherto I drastically underestimated the value of Juniper Juice, but I must admit that were it not for the plentiful compartments well-stocked hereabouts, I'd be a dead Hob.'
            L0047: ShowMessage(player, String1778); // The halfling wanders off, coughing.
            L0054: return; // RETURN;
        }

        private void Fn_1B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: // make space for tmp on stack: sp -= 2
            L0005: RefreshCompareFlags(GetFlag(player, 0x03, 0x0F));
            L0018: if (JumpEqual) goto L001D;
            L001A: goto L00B9;
            L001D: ax = GetFlag(player, 0x03, 0x08);
1121  002E 89 46 FE  mov [bp-0x2], ax
            L0031: SetFlag(player, 0x03, 0x0F, 0x01);
            L0046: Compare(tmp, 0xFE);
113D  004A 7D 2C  jge 0x78
            L004C: ShowPortrait(player, 0x002B);
            L0059: ShowMessage(player, String179C); // An alchemist is instructing a customer in the proper application of a potion as they walk past.
            L0066: ShowMessage(player, String17FC); // '...then you must cover yourselves in good goose grease and climb atop the hill nigh onto the cemetary.
1166  0073 B8 64 18  mov ax, 0x1864
            L0076: goto L00A2;
            L0078: ShowPortrait(player, 0x0016);
            L0085: ShowMessage(player, String1923); // A customer pleads with his alchemist for a cure.
            L0092: ShowMessage(player, String1954); // '...know I swung a dead cat over my head.  I know 'twas not thy fault for the potion's misuse.  But as I value my life, Master Phickett, I must have redress.
            L009F: ShowMessage(player, String19F2); // I till my fields and she is upon me.  At the Rampant Cat Inn she is upon me.  Even when I do visit the privy....'
            L00AC: ShowMessage(player, String18FC); // Some cures are worse than the disease.
            L00B9: // restore stack ptr: sp = bp;
            L00BB: return; // RETURN;
        }

        private void Fn_1C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x10));
            L0016: if (JumpNotEqual) goto L0061;
            L0018: SetFlag(player, 0x03, 0x10, 0x01);
            L002D: ShowPortrait(player, 0x002B);
            L003A: ShowMessage(player, String1A64); // An alchemist is walking past, reading aloud, his head buried in a dusty tome.
            L0047: ShowMessage(player, String1AB2); // '...reserving the juice for gravy.  For the stuffing, for every five pounds of bird use one quarter loaf of bread, four handfuls of clean mushrooms, one cup of plums or prunes, a dozen chestnuts, a bay leaf, half a gill of stock....'
            L0054: ShowMessage(player, String1B9C); // Even alchemists have to eat.
            L0061: return; // RETURN;
        }

        private void Fn_1D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: // make space for tmp on stack: sp -= 2
            L0005: RefreshCompareFlags(GetFlag(player, 0x03, 0x12));
            L0018: if (JumpEqual) goto L001D;
            L001A: goto L009F;
            L001D: ax = GetFlag(player, 0x03, 0x08);
1241  002E 89 46 FE  mov [bp-0x2], ax
            L0031: SetFlag(player, 0x03, 0x12, 0x01);
            L0046: Compare(tmp, 0xFE);
125D  004A 7D 2C  jge 0x78
            L004C: ShowPortrait(player, 0x002E);
            L0059: ShowMessage(player, String1BB9); // An alchemist instructs her pupil.
            L0066: ShowMessage(player, String1BDB); // 'I care not that thou gavest the dragon's blood to that charlatan, Hippocrates Phickett!  Thou didst check out the blood and thou must replace it!
1286  0073 B8 6E 1C  mov ax, 0x1c6e
            L0076: goto L0095;
            L0078: ShowPortrait(player, 0x002E);
            L0085: ShowMessage(player, String1D09); // '...on earth possessed thee to promise the dragon a constant supply of dragon flagon in exchange for his blood?  Do you think we care for thy piddling little life?
            L0092: ShowMessage(player, String1DAD); // This is a business, not a playground!  Stop snivelling!  All undergraduates must replace any used supplies.  It is in thy enrollment papers!  We care not that thou didst not apply lemon juice to expose the secret writing!  'Ods bodkins!'
            L009F: // restore stack ptr: sp = bp;
            L00A1: return; // RETURN;
        }

        private void Fn_1E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: // make space for tmp on stack: sp -= 2
            L0005: RefreshCompareFlags(GetFlag(player, 0x03, 0x12));
            L0018: if (JumpEqual) goto L001D;
            L001A: goto L00B9;
            L001D: ax = GetFlag(player, 0x03, 0x08);
12E4  002E 89 46 FE  mov [bp-0x2], ax
            L0031: SetFlag(player, 0x03, 0x12, 0x01);
            L0046: Compare(tmp, 0xFE);
1300  004A 7D 39  jge 0x85
            L004C: ShowPortrait(player, 0x002E);
            L0059: ShowMessage(player, String1E9B); // Two alchemists converse.
            L0066: ShowMessage(player, String1EB4); // '...s'truth!  I replaced his sandalwood incense with poison ivy.  Did his spell work?  Do eggs bounce?
            L0073: ShowMessage(player, String1F1B); // He has such a rash that he is red as an imp from scratching!  And he attributes it all to supernatural inter....'
1336  0080 B8 8D 1F  mov ax, 0x1f8d
            L0083: goto L00AF;
            L0085: ShowPortrait(player, 0x002B);
            L0092: ShowMessage(player, String1FB3); // An alchemist rushes past, talking to himself and scratching vigorously.
            L009F: ShowMessage(player, String1FFB); // '...not have been a piece of the true cross.  It must have been a false piece of the true cross.  None would dare sabotage such an expensive attempt to create a philosopher's stone.
            L00AC: ShowMessage(player, String20B1); // But what can I use in its stead?  Perhaps the hem of a saint's cloak.  But which saint?'
            L00B9: // restore stack ptr: sp = bp;
            L00BB: return; // RETURN;
        }

        private void Fn_1F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: // make space for tmp on stack: sp -= 2
            L0005: RefreshCompareFlags(GetFlag(player, 0x03, 0x13));
            L0018: if (JumpEqual) goto L001D;
            L001A: goto L00C6;
            L001D: ax = GetFlag(player, 0x03, 0x08);
13A1  002E 89 46 FE  mov [bp-0x2], ax
            L0031: SetFlag(player, 0x03, 0x13, 0x01);
            L0046: Compare(tmp, 0xFE);
13BD  004A 7D 39  jge 0x85
            L004C: ShowPortrait(player, 0x0027);
            L0059: ShowMessage(player, String210A); // Two alchemists are laughing loudly as they walk past.
            L0066: ShowMessage(player, String2140); // '...ments!  Elements, by all the saints in heaven!  And molecules, she called them.  Miniscule particles too small to be seen.  She called for purifying.  Purifying!
            L0073: ShowMessage(player, String21E6); // God's teeth!  Isn't unicorn scat already pure?  And then she said there is a tonic, and something subby tonic.  Most of us were rolling in the aisles by....'
13F3  0080 B8 84 22  mov ax, 0x2284
            L0083: goto L00BC;
            L0085: ShowPortrait(player, 0x002C);
            L0092: ShowMessage(player, String22AC); // Two alchemists are arguing loudly as they walk past.
            L009F: ShowMessage(player, String22E1); // '...ments!  Elements, from the Greek!  Thou art a full professor; I assume a certain degree of education!
            L00AC: ShowMessage(player, String234B); // I made a microscope from pieces of curved glass and discovered that all that our gross senses perceive is in turn composed of smaller parts.  Yes, glass!
            L00B9: ShowMessage(player, String23E5); // Curved glass!  Heaven take me an I bear false witness!  Oh!  Men!'
            L00C6: // restore stack ptr: sp = bp;
            L00C8: return; // RETURN;
        }

        private void Fn_20(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: // make space for tmp on stack: sp -= 2
            L0005: RefreshCompareFlags(GetFlag(player, 0x03, 0x14));
            L0018: if (JumpEqual) goto L001D;
            L001A: goto L00AC;
            L001D: ax = GetFlag(player, 0x03, 0x08);
146B  002E 89 46 FE  mov [bp-0x2], ax
            L0031: SetFlag(player, 0x03, 0x14, 0x01);
            L0046: Compare(tmp, 0xFE);
1487  004A 7D 2C  jge 0x78
            L004C: ShowPortrait(player, 0x0027);
            L0059: ShowMessage(player, String2428); // An alchemist is talking to his owl familiar as they walk past.
            L0066: ShowMessage(player, String2467); // '...I know it is storming outside.  That is the point!  You must fly into the teeth of the storm trailing this silver wire.  When lightning strikes the wire, it will conduct electricity.  What?
14B0  0073 B8 29 25  mov ax, 0x2529
            L0076: goto L00A2;
            L0078: ShowPortrait(player, 0x0027);
            L0085: ShowMessage(player, String25DD); // An alchemist is talking to his slightly singed owl familiar as they walk past.
            L0092: ShowMessage(player, String262C); // '...It must not have been natural lightning, I tell you!  Oh, thou and thy uncle Owlfred again.  Thy tailfeathers will grow back!
            L009F: ShowMessage(player, String26AE); // Cease thy prattling!  If thou hadst not dropped the wire, then I would not need to repeat this experiment.  No, I am not going to find a sea bird familiar.  Every fool knows that wet feathers help birds fly!  Wouldst thou....'
            L00AC: // restore stack ptr: sp = bp;
            L00AE: return; // RETURN;
        }

        private void Fn_21(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String2791); // This closet has many containers of powdered bones.
            L0010: return; // RETURN;
        }

        private void Fn_22(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String27C4); // This closet has many flasks full of various animal organs.
            L0010: return; // RETURN;
        }

        private void Fn_23(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String27FF); // This closet has many pouches filled with hair from many famous (or infamous) people.
            L0010: return; // RETURN;
        }

        private void Fn_24(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String2854); // This closet has many samples of clothes once worn by sundry and diverse types of people.
            L0010: return; // RETURN;
        }

        private void Fn_25(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String28AD); // This closet is filled with a lumberyard's worth of pieces of the true cross.
            L0010: return; // RETURN;
        }

        private void Fn_26(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String28FA); // This closet has many containers of powdered flowers.
            L0010: return; // RETURN;
        }

        private void Fn_27(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String292F); // This closet has samples of spoor, skin, feathers, and fur from many different animals.
            L0010: return; // RETURN;
        }

        private void Fn_28(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String2986); // This closet has dozens of lodestones of differing strengths and effectiveness.
            L0010: return; // RETURN;
        }

        private void Fn_29(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String29D5); // All right.  So the label was wrong.  Take it up with the Alchemists Guild.  This closet was doubtlessly locked because it is full of shavings and samples of many precious metals and gems.
            L0010: ShowMessage(player, String2A91); // If you had a good fence you might be able to make some money here, but Cawdor isn't that kind of game.
            L001D: return; // RETURN;
        }

        private void Fn_2A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String2AF8); // This closet is full of books and manuscripts, many of which bear burns and stains.
            L0010: return; // RETURN;
        }

        private void Fn_2B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String2B4B); // This closet has many empty containers and a large, oft-used wash tub.
            L0010: return; // RETURN;
        }

        private void Fn_2C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String2B91); // You are grateful for the fresh air.  The weather outside is cold and blustery, but refreshing all the same.
            L0010: HealPlayer(player, 0x000C);
            L001D: return; // RETURN;
        }

        private void Fn_2D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String2BFD); // This is one nasty little corridor.  Huge clouds of fumes are wafting in through overhead vents, as if it is intended to poison anyone who walks in here.  Like you, for instance!
            L0010: DamagePlayer(player, 0x03E8);
15FC  001D B8 E8 03  mov ax, 0x3e8
            L0020: PushStack(player, ax);
            L0021: PushStack(player, 0x05);
            L0025: PushStack(player, 0x01);
1608  0029 C4 5E 06  les bx, [bp+0x6]
160B  002C 26 FF 9F 9C 00  call far word [es:bx+0x9c]
1610  0031 83 C4 06  add sp, 0x6
            L0034: return; // RETURN;
        }

    }
}
