#pragma warning disable
using System.Collections.Generic;
using XPT.WorldData;
using XPT.WorldData.Yserbius;

namespace XPT.Scripts.Yserbius.Maps {
    class YserMap23 : AMapScripted {
        protected override int MapIndex => 23;
        protected override int RandomEncounterChance => 22;
        protected override int RandomEncounterExtraCount => 2;

        public YserMap23() {
            MapEvent01 = Fn_01;
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
            MapEvent19 = Fn_19;
            MapEvent1B = Fn_1B;
            MapEvent1C = Fn_1C;
            MapEvent1D = Fn_1D;
            MapEvent1E = Fn_1E;
            MapEvent1F = Fn_1F;
            MapEvent20 = Fn_20;
        }
        
        // === Strings ================================================
        private const string String0140 = "In a hidden wall recess with a sign reading 'For 'Emergency Use' you find a bottle labelled 'Woad Wine.'";
        private const string String01A9 = "You call this an emergency?  It's not like your poisoned or anything.  Oh, all right, take the wine and stop whining.";
        private const string String021F = "The way you've been blundering around here, you better believe this is an emergency....";
        private const string String0277 = "Now, now.  Don't take it personally.  You're really a very good player.  I was just teasing you.  There's no need to hit that complain button.  I'm sorry.  Really I am!";
        private const string String0320 = "Lessee.  Something's sucking the very mana out of you, and you don't know why.  Yup, this is an emergency.";
        private const string String038B = "Well, I'm not going to tell you how to play.  But I think your parents raised a good little adventurer who wouldn't take emergency supplies unless you really needed them.";
        private const string String0436 = "So if you want to risk breaking dear old mumsy's heart, that's up to you.";
        private const string String0480 = "Take the potion, take the potion!  Believe you me, any second now you're going to need it!";
        private const string String04DB = "Go ahead!  Drink up, me hearties!  I get 5000 gold pieces for each replacement bottle.  Wassail!";
        private const string String053C = "Look, in Scotland in the 1200's Woad wine is not a controlled substance.  Enjoy!";
        private const string String058D = "Yucko!  They must not have a potion rotation policy.  This potion is spoiled.";
        private const string String05DB = "The way they suck mana out of you around here, you feel like a sponge run over by a steam roller.  So don't turn your nose up at available supplies.";
        private const string String0670 = "It's alright to drink that.  Nobody's watching but us RAM chips.";
        private const string String06B1 = "The emergency supply cabinet is empty.";
        private const string String06D8 = "A nice Northlands Nun clutches you by the shoulders.  Her unblinking gaze causes you to feel fainthearted.  Then you hear her intone: ";
        private const string String075F = "'I saw thee in a place disturbed.";
        private const string String0781 = "A brush with quite a deadly herb.";
        private const string String07A3 = "A hoof now tamed that once was wild.";
        private const string String07C8 = "A nasty little maze defiled.";
        private const string String07E5 = "To snare the song that thy heart sings";
        private const string String080C = "Thus must thou seek out higher things.'";
        private const string String0834 = "In retrospect, you're not sure just how nice she was.";
        private const string String086A = "The writing on the the door to the south reads: 'Professor Simon Charlatanus, Chairman of the School of Astrology.'  The door to the west reads: 'Authorized Personnel Only.'  Officious words for the thirteenth century, aren't they.";
        private const string String0952 = "You hear some footsteps running away.";
        private const string String0978 = "A passing soothsayer lays his hands on your forehead and walks away shaking his head sadly.  You feel tired.";
        private const string String09E5 = "You have walked into a negatively charged ley line.  Can that take it out of you or what?  I hate when that happens!";
        private const string String0A5A = "A fortune teller dances up to you seductively, takes your palm, grimaces, and rushes away, leaving you perplexed and with a headache.";
        private const string String0AE0 = "You know how good you feel if you stumble across a positively charged ley line?  You know know how much better you feel if you find the intersection of two such ley lines?";
        private const string String0B8C = "You know how much it would hurt if they were negatively charged ley lines.  No, really!  You know!";
        private const string String0BEF = "You pass by an ornate arcane metallic plate that cheerfully sucks some mana out of you.";
        private const string String0C47 = "At least it thanked you for your donation.";
        private const string String0C72 = "'Care to try these exquisitely loaded dice, squire?'";
        private const string String0CA7 = "What could it hurt?  They seem heavier than you expected.  You give them a roll.  It's a seven!";
        private const string String0D07 = "The dwarf snatches the dice, squints at them distrustfully, and departs.";
        private const string String0D50 = "'A thousand pardons, humanoid, but hast thou seen a dwarf peddling loaded dice hereabouts.  He is a thief of great subtlety, for the dice - wait!  You there!  Halt!'";
        private const string String0DF6 = "The dragon rushes off.";
        private const string String0E0D = "'Alagests?  Tomes?  Celestiae?  Horoscopes?  Orreries?  Pieces of the true cross?  Isn't there anything you want to buy?'";
        private const string String0E87 = "Actually, you were rather interested in an orrery until she peddled a piece of the true cross.";
        private const string String0EE6 = "You find a gold piece.  How nice.";
        private const string String0F08 = "A cold breeze sends shivers down your spine.";
        private const string String0F35 = "You return to The Great Hall.";
        private const string String0F53 = "You join a long but fast moving queue.";
        private const string String0F7A = "'Hurry up.  Hurry up.  Stand on the mark.  Touch the plate.  Let the ley lines flow through you.  That's enough!  Now make a donation.  Very good.  Move along!";
        private const string String101A = "Wow!  Do you feel magically recharged!  You leave the gnome 500 gold pieces and resolve to remember this spot.";
        private const string String1089 = "'Greedyguts!  One visit per day!  Move along!'";
        private const string String10B8 = "Perhaps you can come back after this gnome's shift is over.  But from the muttering of the folks immediately behind you, you decide to migrate.";
        private const string String1148 = "There is nothing useful in this pile of rubble.";
        private const string String1178 = "The sign on the door reads:  'Lillibeth Armstrong, Deputy Chairperson of the Department of Astrology.'  You didn't know they had political correctness in the 13th century.";
        private const string String1224 = "Then again, someone powerful enough to be the deputy chairperson could probably turn you into a newt if you called her a man.";
        private const string String12A2 = "'I say, couldst thou be a chap and direct me towards Lillibeth Armstrong?  She turned me into a newt and promised to turn me back today.'";
        private const string String132C = "The dragon sees you staring at him and looks down at himself.";
        private const string String136A = "'No, really she did!  I'm just a REALLY big newt!'";
        private const string String139D = "You apologise for not knowing her whereabouts and leave before he can see your smile.";
        private const string String13F3 = "Yikes!  Those cobra headed medusae have spit poison upon you!";
        private const string String1431 = "If you'd killed them a little less thoroughly you probably could have made some change by selling minotaur and medusa parts over in alchemia.  Not that that was any reason to pull your blows!";
        private const string String14F1 = "A bunch of folks huddle over an ancient prophecy, glance at you, look at the alagest again, nod, and decide that you look enough like the picture to attack!";
        private const string String158E = "You know, this could really make you regret the fact that your face looks familiar to everyone.";
        private const string String15EE = "Hmm.  Maybe your picture really is in a bunch of old predictions.  It would explain why so many folks attack you on sight.  Perhaps you should change hairstyles.";
        private const string String1690 = "You can call them goblins.  Or you can call them orcs.  Or you can call them kobolds.  Or you can call them hobgoblins.  But you better not call them friendly!";
        private const string String1730 = "In fact, downright unfriendly seems about the right term for them!";
        private const string String1773 = "All that remains of your battle here is a few goblin gobbets.";
        private const string String17B1 = "Psst!  Yes, I mean you!  I have a secret for you.  In case you hadn't figured it out, Cawdor is haunted!";
        private const string String181A = "That was some nasty battle you had here.  Fortunately your dry cleaner knows how to remove ectoplasm stains.";
        private const string String1887 = "You knew vampires liked to suck blood.  You didn't know that the vampires around here like to suck mana instead.";
        private const string String18F8 = "And you hate those liches to pieces!  Sheesh!";
        private const string String1926 = "Your battle here explains why greensleeves is such a popular song: it's from all the ectoplasm!";
        private const string String1986 = "The Carlisle Rugby Team has decided you're their next match!  And these guys play for keeps!";
        private const string String19E3 = "The big one's battle cry is, 'Scrum and get it!'";
        private const string String1A14 = "All that remains of your scrimmage here is the deflated bladder that used to be the ball.";
        private const string String1A6E = "Ordinarily you believe in respecting other people's religious beliefs.  But these priestesses believe in raising undead to kill unbelievers!";
        private const string String1AFB = "They also believe in unfair numbers, sucking mana, and using poison.";
        private const string String1B40 = "It's a shame: you fought all these skeletons, and not a single skeleton key ring out of it.";
        private const string String1B9C = "A troll cleric lays a hand upon thy forehead and rolls her eyes back into her head.  In a quavering, eery voice she makes her pronouncement.";
        private const string String1C29 = "'I sense a power of goodness in thee.  Aldhelm's grace could fall upon thee!  An thou dost invoke of spirit of Aldhelm as thou dost descend beneath the Ruins, then Aldhelm will guide thee in safety and surety.  But thou must gather sufficient of Aldhelm to summon Aldhelm.";
        private const string String1D3A = "Her eyes refocus.  Blushing, she departs.";
        private const string String1D64 = "You overhear a snippet of conversation.";
        private const string String1D8C = "'....their party leader, somehow, invoked Alcuin's spirit, who in his goodness did defeat the evil locks that were upon the door.";
        private const string String1E0E = "Then the sisters did attack in such wise and vigor as to thwart my further observ....'";
        private const string String1E65 = "A gremlin wizard appears before you, gazing deep into your eyes.";
        private const string String1EA6 = "'Hear me and heed me!  Thou hast the flavor of greatness in thy soul.";
        private const string String1EEC = "Deep within the Bestiary, after thou hast defeated the eight foretold, an thou dost invoke the spirit of Alfred the Great, so shall he heal thee.  But thou must catch his spirit's attention when thou dost approach him.";
        private const string String1FC7 = "Nay, I will not explain!  An thou canst not decipher this plain prophecy, then thou art not so great as I think.'  She departs.";
        private const string String2047 = "An astrologer is lecturing his pupils as they walk by.";
        private const string String207E = "'...shall be the counting of the cats, and the counting of the cats shall be three.  But greater than the cats is the hedgepig, who shall count once more than the....";
        private const string String2125 = "An astrologer is instructing a customer in the proper reading of a chart as they walk past.";
        private const string String2181 = "'...must always take care to interpret these wisely.  Thy chart in the near future shows a path fraught both with peril and excitement, for women will respond with favor upon thy wooing.  Heed both the portents and....'";
        private const string String225D = "A customer pleads with his astrologer for aid.";
        private const string String228C = "'...not tell me that merely smiling at Rowena Sly would lead to her six large swineherding brothers demanding our immediate betrothal!  Will the stench of the sty ever be free from my nostrils?  There must be some way I can avoid....'";
        private const string String2377 = "An astrologer is walking past, reading aloud, his head buried in a dusty tome.";
        private const string String23C6 = "'Mewed?  That must be a reference to defeat, death, destruction, for brinded cats are the most fierce of all the felines.";
        private const string String2440 = "Thrice is obvious enough.  And whining and cries must likewise refer to combat with four hedgepigs and a harpier.";
        private const string String24B2 = "But where can one insure eight consecutive battles of the proper form?  And why would any man of science choose such an empirical approach....'";
        private const string String2542 = "An astrologer lectures her pupil.";
        private const string String2564 = "'six planets are Venus, Earth, Mars, Luna, Jupiter, and Saturn.  I care not that thy calculations gain historical accuracy if thou dost assume nine planets circling the sun.";
        private const string String2612 = "Wouldst thou regress the science of astrology back a millenium?  Count the six, and cease thy false beliefs that any do circle the sun, for the Earth is the center of the universe!'";
        private const string String26C8 = "'I care not a fig if Caesar's death was predictable.  Professor Charlatanus is a staunch anti-Caesarian who made his career by showing the soothsayer's errors.";
        private const string String2768 = "This is academia!  New ideas lead to loss of grants and sinecures.  We are not here to research more accurate astrological methods.  We are here to receive our degrees and further the existing dogma....'";
        private const string String2834 = "Two astrologers converse.";
        private const string String284E = "'Well, I foresee that thou shalt not be given consort an thou dost not return with two loaves of fresh bread and some stewing meat,' she says.";
        private const string String28DD = "'Well, I foresee that thou shalt spend the night under the loquat tree and thou dost treat me so rudely,' he rejoins.";
        private const string String2953 = "'Well, I foretell that thou wilt be eating thy own cooking, and no doubt dying young from it, an thou dost refuse to aid in our lavendry,' she shouts.";
        private const string String29EA = "'Balderdash!  I foresee that thou shalt starve in the streets an thou dost treat me so,' he replies.";
        private const string String2A4F = "You know, it's amazing how accurate these astrological predictions can get these days.  The science has really taken off with the perfection of the abacus.";
        private const string String2AEB = "Two astrologers are laughing as they walk past.";
        private const string String2B1B = "'...his star charts?'";
        private const string String2B31 = "'Aye!  I put Jupiter in Libra, and Mars in Capricorn, and the fool drew up a chart for old Stowlugs Elliot predicting a good night for reiving.  ";
        private const string String2BC3 = "The Elliots were overtaken and outnumbered by a hot trod, and barely one in ten escaped.  So Stowlugs is seeking....'";
        private const string String2C39 = "An astrologer is being carried off.";
        private const string String2C5D = "'...you must see, Master Elliot, that it was a good night for reiving metaphysically, a sign from above that thou should cease reiving.'";
        private const string String2CE6 = "'I can agree with all that thou dost say, but on behalf of my captured kinsmen I am about to give thee thine own sign from above, and it will be far more physical than meta.'  Stowlugs pats his sword.";
        private const string String2DAF = "Gee!  Astrology is a cutthroat business?";
        private const string String2DD8 = "An astrologer is talking to his owl familiar as they walk past.";
        private const string String2E18 = "'...a great rocket I shall launch thee into the Celestium, wherein you shall be able to see and record the most accurate star charts yet made.";
        private const string String2EA7 = "Thy nephew Owlbert is purely mistaken.  The air is thin, but every fool knows that thou wilt be sustained by the music of the spheres.  Think of the adventure!";
        private const string String2F47 = "An astrologer is talking to his slightly singed owl familiar as they walk past.";
        private const string String2F97 = "'...sometimes rockets explode.  It was thine own fault for not flapping thy wings and aiding the rocket's flight.";
        private const string String3009 = "Thy tailfeathers will grow back!  Cease thy prattling!  Of course thou must flap.  Every fool knows that if you run backwards on a boat, then the boat moves forward faster.  So thou must fly downwards with....'";
        
        // === Functions ================================================
        private void Fn_01(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: PushStack(player, 0x02);
            L0008: PushStack(player, 0x00);
0017  000B C4 5E 06  les bx, [bp+0x6]
001A  000E 26 FF 5F 04  call far word [es:bx+0x4]
            L0012: cx = PopStack(player);
            L0013: cx = PopStack(player);
            L0014: RefreshCompareFlags(ax);
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L0118;
            L001B: ShowMessage(player, String0140); // In a hidden wall recess with a sign reading 'For 'Emergency Use' you find a bottle labelled 'Woad Wine.'
            L0028: SetFlag(player, 0x00, 0x02, 0x01);
            L003C: GiveItem(player, 0xCD);
            L0048: si = GetFlag(player, 0x03, 0x08);
            L005B: Compare(si, 0x1E);
            L005E: if (JumpLess) goto L0062;
            L0060: si = 0;
            L0062: Compare(si, 0x14);
            L0065: if (JumpLessOrEqual) goto L006E;
0073  0067 8B C6  mov ax, si
            L0069: si = ax + 0xFFEC;
            L006E: Compare(si, 0x0A);
            L0071: if (JumpLess) goto L007A;
007F  0073 8B C6  mov ax, si
            L0075: si = ax + 0xFFF6;
            L007A: SetFlag(player, 0xC4, 0xB8, si);
            L008C: bx = si;
            L008E: Compare(bx, 0x09);
            L0091: if (JumpBelowOrEqual) goto L0096;
            L0093: goto L0125;
            L0096: switch (bx) {
                case 0:
                    goto L009D;
                case 1:
                    goto L00A3;
                case 2:
                    goto L00B5;
                case 3:
                    goto L00BA;
                case 4:
                    goto L00CC;
                case 5:
                    goto L00D1;
                case 6:
                    goto L00D6;
                case 7:
                    goto L00DB;
                case 8:
                    goto L010E;
                case 9:
                    goto L0113;
            }
00A9  009D B8 A9 01  mov ax, 0x1a9
            L00A0: goto L011B;
            L00A2: // NOP
            L00A3: ShowMessage(player, String021F); // The way you've been blundering around here, you better believe this is an emergency....
00BC  00B0 B8 77 02  mov ax, 0x277
            L00B3: goto L011B;
00C1  00B5 B8 20 03  mov ax, 0x320
            L00B8: goto L011B;
            L00BA: ShowMessage(player, String038B); // Well, I'm not going to tell you how to play.  But I think your parents raised a good little adventurer who wouldn't take emergency supplies unless you really needed them.
00D3  00C7 B8 36 04  mov ax, 0x436
            L00CA: goto L011B;
00D8  00CC B8 80 04  mov ax, 0x480
            L00CF: goto L011B;
00DD  00D1 B8 DB 04  mov ax, 0x4db
            L00D4: goto L011B;
00E2  00D6 B8 3C 05  mov ax, 0x53c
            L00D9: goto L011B;
            L00DB: ShowMessage(player, String058D); // Yucko!  They must not have a potion rotation policy.  This potion is spoiled.
            L00E8: AddMana(player, 0xF830);
            L00F5: PushStack(player, 0xC8);
            L00F9: PushStack(player, 0x03);
            L00FD: PushStack(player, 0x01);
010D  0101 C4 5E 06  les bx, [bp+0x6]
0110  0104 26 FF 9F 9C 00  call far word [es:bx+0x9c]
0115  0109 83 C4 06  add sp, 0x6
            L010C: goto L0125;
011A  010E B8 DB 05  mov ax, 0x5db
            L0111: goto L011B;
011F  0113 B8 70 06  mov ax, 0x670
            L0116: goto L011B;
            L0118: ShowMessage(player, String06B1); // The emergency supply cabinet is empty.
            L0125: return; // RETURN (restoring si);
        }

        private void Fn_03(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x18));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00BF;
            L001B: SetFlag(player, 0x03, 0x18, 0x01);
            L0030: ShowPortrait(player, 0x0028);
            L003D: ShowMessage(player, String06D8); // A nice Northlands Nun clutches you by the shoulders.  Her unblinking gaze causes you to feel fainthearted.  Then you hear her intone: 
            L004A: ShowMessage(player, String075F); // 'I saw thee in a place disturbed.
            L0057: ShowMessage(player, String0781); // A brush with quite a deadly herb.
            L0064: ShowMessage(player, String07A3); // A hoof now tamed that once was wild.
            L0071: ShowMessage(player, String07C8); // A nasty little maze defiled.
            L007E: ShowMessage(player, String07E5); // To snare the song that thy heart sings
            L008B: ShowMessage(player, String080C); // Thus must thou seek out higher things.'
            L0098: AddMana(player, 0xEC78);
            L00A5: DamagePlayer(player, 0x1F40);
            L00B2: ShowMessage(player, String0834); // In retrospect, you're not sure just how nice she was.
            L00BF: return; // RETURN;
        }

        private void Fn_04(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String086A); // The writing on the the door to the south reads: 'Professor Simon Charlatanus, Chairman of the School of Astrology.'  The door to the west reads: 'Authorized Personnel Only.'  Officious words for the thirteenth century, aren't they.
            L0010: return; // RETURN;
        }

        private void Fn_05(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si, di);
            L0005: di = 0;
            L0007: si = 0;
            L0009: ax = GetFlag(player, 0x02, 0x53);
023A  001A 8B F8  mov di, ax
023C  001C 47     inc di
023D  001D 8B F7  mov si, di
            L001F: Compare(si, 0x13);
            L0022: if (JumpLessOrEqual) goto L002B;
0244  0024 8B C6  mov ax, si
            L0026: si = ax + 0xFFEC;
            L002B: Compare(si, 0x09);
            L002E: if (JumpLessOrEqual) goto L0037;
0250  0030 8B C6  mov ax, si
            L0032: si = ax + 0xFFF6;
0257  0037 0B F6  or si, si
0259  0039 7D 02  jge 0x3d
            L003B: si = 0;
            L003D: Compare(si, 0x1D);
            L0040: if (JumpLessOrEqual) goto L0044;
            L0042: si = 0;
0264  0044 83 FF 1E  cmp di, 0x1e
            L0047: if (JumpLessOrEqual) goto L004B;
            L0049: di = 0;
026B  004B 57     push di
            L004C: PushStack(player, 0x53);
            L0050: PushStack(player, 0x02);
0274  0054 C4 5E 06  les bx, [bp+0x6]
0277  0057 26 FF 1F  call far word [es:bx]
027A  005A 83 C4 06  add sp, 0x6
            L005D: bx = si;
            L005F: Compare(bx, 0x09);
            L0062: if (JumpBelowOrEqual) goto L0067;
            L0064: goto L018C;
            L0067: switch (bx) {
                case 0:
                    goto L006E;
                case 1:
                    goto L007D;
                case 2:
                    goto L0090;
                case 3:
                    goto L00A3;
                case 4:
                    goto L00B6;
                case 5:
                    goto L00D6;
                case 6:
                    goto L00E8;
                case 7:
                    goto L0121;
                case 8:
                    goto L0141;
                case 9:
                    goto L0161;
            }
028E  006E B8 52 09  mov ax, 0x952
            L0071: PushStack(player, ax);
0292  0072 C4 5E 06  les bx, [bp+0x6]
0295  0075 26 FF 9F F8 00  call far word [es:bx+0xf8]
            L007A: goto L018B;
            L007D: ShowMessage(player, String0978); // A passing soothsayer lays his hands on your forehead and walks away shaking his head sadly.  You feel tired.
02AA  008A B8 44 FD  mov ax, 0xfd44
            L008D: goto L0182;
            L0090: ShowMessage(player, String09E5); // You have walked into a negatively charged ley line.  Can that take it out of you or what?  I hate when that happens!
02BD  009D B8 88 FA  mov ax, 0xfa88
            L00A0: goto L0182;
            L00A3: ShowMessage(player, String0A5A); // A fortune teller dances up to you seductively, takes your palm, grimaces, and rushes away, leaving you perplexed and with a headache.
02D0  00B0 B8 CC F7  mov ax, 0xf7cc
            L00B3: goto L0182;
            L00B6: ShowMessage(player, String0AE0); // You know how good you feel if you stumble across a positively charged ley line?  You know know how much better you feel if you find the intersection of two such ley lines?
            L00C3: ShowMessage(player, String0B8C); // You know how much it would hurt if they were negatively charged ley lines.  No, really!  You know!
02F0  00D0 B8 60 F0  mov ax, 0xf060
            L00D3: goto L0182;
            L00D6: ShowMessage(player, String0BEF); // You pass by an ornate arcane metallic plate that cheerfully sucks some mana out of you.
0303  00E3 B8 47 0C  mov ax, 0xc47
            L00E6: goto L0112;
            L00E8: ShowPortrait(player, 0x0023);
            L00F5: ShowMessage(player, String0C72); // 'Care to try these exquisitely loaded dice, squire?'
            L0102: ShowMessage(player, String0CA7); // What could it hurt?  They seem heavier than you expected.  You give them a roll.  It's a seven!
            L010F: ShowMessage(player, String0D07); // The dwarf snatches the dice, squints at them distrustfully, and departs.
033C  011C B8 70 FE  mov ax, 0xfe70
            L011F: goto L0182;
            L0121: ShowPortrait(player, 0x000E);
            L012E: ShowMessage(player, String0D50); // 'A thousand pardons, humanoid, but hast thou seen a dwarf peddling loaded dice hereabouts.  He is a thief of great subtlety, for the dice - wait!  You there!  Halt!'
035B  013B B8 F6 0D  mov ax, 0xdf6
            L013E: goto L0071;
            L0141: ShowPortrait(player, 0x0024);
            L014E: ShowMessage(player, String0E0D); // 'Alagests?  Tomes?  Celestiae?  Horoscopes?  Orreries?  Pieces of the true cross?  Isn't there anything you want to buy?'
037B  015B B8 87 0E  mov ax, 0xe87
            L015E: goto L0071;
            L0161: ShowMessage(player, String0EE6); // You find a gold piece.  How nice.
            L016E: ModifyGold(player, 0x0001);
            L017F: AddMana(player, 0xF830);
            L018C: return; // RETURN (restoring si, di);
        }

        private void Fn_06(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0F08); // A cold breeze sends shivers down your spine.
            L0010: return; // RETURN;
        }

        private void Fn_07(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0F35); // You return to The Great Hall.
            L0010: TeleportParty(player, 0x08, 0x02, 0x0B, 0x01, isForwardMove);
            L002B: return; // RETURN;
        }

        private void Fn_08(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFlag(player, 0x02, 0x24, 0x01);
            L0018: return; // RETURN;
        }

        private void Fn_09(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x002D);
            L0010: ShowMessage(player, String0F53); // You join a long but fast moving queue.
            L001D: RefreshCompareFlags(GetFlag(player, 0x03, 0x0A));
            L0030: if (JumpNotEqual) goto L0078;
            L0032: ShowMessage(player, String0F7A); // 'Hurry up.  Hurry up.  Stand on the mark.  Touch the plate.  Let the ley lines flow through you.  That's enough!  Now make a donation.  Very good.  Move along!
            L003F: SetFlag(player, 0x03, 0x0A, 0x01);
            L0054: AddMana(player, 0x1388);
            L0061: ModifyGold(player, 0xFFFF0CBA);
0490  0073 B8 1A 10  mov ax, 0x101a
            L0076: goto L0088;
            L0078: ShowMessage(player, String1089); // 'Greedyguts!  One visit per day!  Move along!'
            L0085: ShowMessage(player, String10B8); // Perhaps you can come back after this gnome's shift is over.  But from the muttering of the folks immediately behind you, you decide to migrate.
            L0092: return; // RETURN;
        }

        private void Fn_0A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1148); // There is nothing useful in this pile of rubble.
            L0010: return; // RETURN;
        }

        private void Fn_0B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1178); // The sign on the door reads:  'Lillibeth Armstrong, Deputy Chairperson of the Department of Astrology.'  You didn't know they had political correctness in the 13th century.
            L0010: ShowMessage(player, String1224); // Then again, someone powerful enough to be the deputy chairperson could probably turn you into a newt if you called her a man.
            L001D: return; // RETURN;
        }

        private void Fn_0C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x0B));
            L0016: if (JumpNotEqual) goto L0059;
            L0018: ShowPortrait(player, 0x000E);
            L0025: ShowMessage(player, String12A2); // 'I say, couldst thou be a chap and direct me towards Lillibeth Armstrong?  She turned me into a newt and promised to turn me back today.'
            L0032: ShowMessage(player, String132C); // The dragon sees you staring at him and looks down at himself.
            L003F: ShowMessage(player, String136A); // 'No, really she did!  I'm just a REALLY big newt!'
            L004C: ShowMessage(player, String139D); // You apologise for not knowing her whereabouts and leave before he can see your smile.
            L0059: return; // RETURN;
        }

        private void Fn_0D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x06));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00FB;
            L001B: SetFlag(player, 0x03, 0x06, 0x01);
056D  0030 B8 E8 03  mov ax, 0x3e8
            L0033: PushStack(player, ax);
            L0034: PushStack(player, 0x05);
            L0038: PushStack(player, 0x01);
0579  003C C4 5E 06  les bx, [bp+0x6]
057C  003F 26 FF 9F 9C 00  call far word [es:bx+0x9c]
0581  0044 83 C4 06  add sp, 0x6
            L0047: ShowMessage(player, String13F3); // Yikes!  Those cobra headed medusae have spit poison upon you!
0591  0054 B8 1C 0C  mov ax, 0xc1c
            L0057: PushStack(player, ax);
            L0058: PushStack(player, 0x00);
            L005B: PushStack(player, ax);
            L005C: PushStack(player, 0xBB);
            L0060: PushStack(player, 0xF4);
            L0064: PushStack(player, 0x82);
05A5  0068 C4 5E 06  les bx, [bp+0x6]
05A8  006B 26 FF 9F D8 00  call far word [es:bx+0xd8]
05AD  0070 83 C4 0C  add sp, 0xc
            L0073: AddEncounter(player, 0x01, 0x27);
            L0085: AddEncounter(player, 0x05, 0x26);
            L0097: Compare(PartyCount(player), 0x0002);
            L00A2: if (JumpBelowOrEqual) goto L00C8;
            L00A4: AddEncounter(player, 0x02, 0x27);
            L00B6: AddEncounter(player, 0x06, 0x26);
            L00C8: Compare(PartyCount(player), 0x0003);
            L00D3: if (JumpBelowOrEqual) goto L0108;
            L00D5: AddEncounter(player, 0x03, 0x27);
            L00E7: AddEncounter(player, 0x04, 0x26);
            L00F9: goto L0108;
            L00FB: ShowMessage(player, String1431); // If you'd killed them a little less thoroughly you probably could have made some change by selling minotaur and medusa parts over in alchemia.  Not that that was any reason to pull your blows!
            L0108: return; // RETURN;
        }

        private void Fn_0E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x07));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L0115;
            L001B: SetFlag(player, 0x03, 0x07, 0x01);
0677  0030 B8 E8 03  mov ax, 0x3e8
            L0033: PushStack(player, ax);
            L0034: PushStack(player, 0x05);
            L0038: PushStack(player, 0x01);
0683  003C C4 5E 06  les bx, [bp+0x6]
0686  003F 26 FF 9F 9C 00  call far word [es:bx+0x9c]
068B  0044 83 C4 06  add sp, 0x6
            L0047: ShowMessage(player, String14F1); // A bunch of folks huddle over an ancient prophecy, glance at you, look at the alagest again, nod, and decide that you look enough like the picture to attack!
            L0054: Compare(PartyCount(player), 0x0002);
            L005F: if (JumpBelowOrEqual) goto L006E;
            L0061: ShowMessage(player, String158E); // You know, this could really make you regret the fact that your face looks familiar to everyone.
06B5  006E B8 6F 06  mov ax, 0x66f
            L0071: PushStack(player, ax);
            L0072: PushStack(player, 0x00);
            L0075: PushStack(player, ax);
            L0076: PushStack(player, 0xFA);
            L007A: PushStack(player, 0xAE);
            L007E: PushStack(player, 0x93);
06C9  0082 C4 5E 06  les bx, [bp+0x6]
06CC  0085 26 FF 9F D8 00  call far word [es:bx+0xd8]
06D1  008A 83 C4 0C  add sp, 0xc
            L008D: AddEncounter(player, 0x01, 0x22);
            L009F: AddEncounter(player, 0x02, 0x23);
            L00B1: AddEncounter(player, 0x05, 0x21);
            L00C3: Compare(PartyCount(player), 0x0002);
            L00CE: if (JumpBelowOrEqual) goto L00F4;
            L00D0: AddEncounter(player, 0x04, 0x23);
            L00E2: AddEncounter(player, 0x03, 0x22);
            L00F4: Compare(PartyCount(player), 0x0003);
            L00FF: if (JumpBelowOrEqual) goto L0122;
            L0101: AddEncounter(player, 0x06, 0x21);
            L0113: goto L0122;
            L0115: ShowMessage(player, String15EE); // Hmm.  Maybe your picture really is in a bunch of old predictions.  It would explain why so many folks attack you on sight.  Perhaps you should change hairstyles.
            L0122: return; // RETURN;
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
078F  0024 C4 5E 06  les bx, [bp+0x6]
0792  0027 26 FF 1F  call far word [es:bx]
0795  002A 83 C4 06  add sp, 0x6
            L002D: ShowMessage(player, String1690); // You can call them goblins.  Or you can call them orcs.  Or you can call them kobolds.  Or you can call them hobgoblins.  But you better not call them friendly!
            L003A: Compare(PartyCount(player), 0x0003);
            L0045: if (JumpBelowOrEqual) goto L0054;
            L0047: ShowMessage(player, String1730); // In fact, downright unfriendly seems about the right term for them!
07BF  0054 B8 4F 03  mov ax, 0x34f
            L0057: PushStack(player, ax);
            L0058: PushStack(player, 0x00);
            L005B: PushStack(player, ax);
            L005C: PushStack(player, 0xBA);
            L0060: PushStack(player, 0x68);
            L0064: PushStack(player, 0x23);
07D3  0068 C4 5E 06  les bx, [bp+0x6]
07D6  006B 26 FF 9F D8 00  call far word [es:bx+0xd8]
07DB  0070 83 C4 0C  add sp, 0xc
            L0073: AddEncounter(player, 0x01, 0x19);
            L0085: AddEncounter(player, 0x02, 0x1A);
            L0097: Compare(PartyCount(player), 0x0001);
            L00A2: if (JumpBelowOrEqual) goto L00C8;
            L00A4: AddEncounter(player, 0x03, 0x19);
            L00B6: AddEncounter(player, 0x04, 0x1A);
            L00C8: Compare(PartyCount(player), 0x0003);
            L00D3: if (JumpBelowOrEqual) goto L0108;
            L00D5: AddEncounter(player, 0x05, 0x1A);
            L00E7: AddEncounter(player, 0x06, 0x19);
            L00F9: goto L0108;
            L00FB: ShowMessage(player, String1773); // All that remains of your battle here is a few goblin gobbets.
            L0108: return; // RETURN;
        }

        private void Fn_10(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x02));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00F6;
            L001B: SetFlag(player, 0x03, 0x02, 0x01);
            L0030: ShowMessage(player, String17B1); // Psst!  Yes, I mean you!  I have a secret for you.  In case you hadn't figured it out, Cawdor is haunted!
08B2  003D B8 BF 01  mov ax, 0x1bf
            L0040: PushStack(player, ax);
            L0041: PushStack(player, 0x00);
            L0044: PushStack(player, ax);
            L0045: PushStack(player, 0x94);
            L0049: PushStack(player, 0xCD);
            L004D: PushStack(player, 0x45);
08C6  0051 C4 5E 06  les bx, [bp+0x6]
08C9  0054 26 FF 9F D8 00  call far word [es:bx+0xd8]
08CE  0059 83 C4 0C  add sp, 0xc
            L005C: AddEncounter(player, 0x01, 0x1D);
            L006E: AddEncounter(player, 0x02, 0x1E);
            L0080: AddEncounter(player, 0x05, 0x24);
            L0092: Compare(PartyCount(player), 0x0002);
            L009D: if (JumpBelowOrEqual) goto L00C3;
            L009F: AddEncounter(player, 0x03, 0x1D);
            L00B1: AddEncounter(player, 0x06, 0x24);
            L00C3: Compare(PartyCount(player), 0x0003);
            L00CE: if (JumpBelowOrEqual) goto L0103;
            L00D0: AddEncounter(player, 0x04, 0x1E);
            L00E2: AddEncounter(player, 0x03, 0x22);
            L00F4: goto L0103;
            L00F6: ShowMessage(player, String181A); // That was some nasty battle you had here.  Fortunately your dry cleaner knows how to remove ectoplasm stains.
            L0103: return; // RETURN;
        }

        private void Fn_11(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x03);
            L0007: PushStack(player, ax);
0982  0008 C4 5E 06  les bx, [bp+0x6]
0985  000B 26 FF 5F 04  call far word [es:bx+0x4]
            L000F: cx = PopStack(player);
            L0010: cx = PopStack(player);
            L0011: RefreshCompareFlags(ax);
            L0013: if (JumpEqual) goto L0018;
            L0015: goto L0105;
            L0018: PushStack(player, 0x01);
            L001C: PushStack(player, 0x03);
            L0020: PushStack(player, ax);
099B  0021 C4 5E 06  les bx, [bp+0x6]
099E  0024 26 FF 1F  call far word [es:bx]
09A1  0027 83 C4 06  add sp, 0x6
            L002A: AddMana(player, 0xF830);
            L0037: ShowMessage(player, String1887); // You knew vampires liked to suck blood.  You didn't know that the vampires around here like to suck mana instead.
            L0044: Compare(PartyCount(player), 0x0003);
            L004F: if (JumpBelowOrEqual) goto L005E;
            L0051: ShowMessage(player, String18F8); // And you hate those liches to pieces!  Sheesh!
09D8  005E B8 47 03  mov ax, 0x347
            L0061: PushStack(player, ax);
            L0062: PushStack(player, 0x00);
            L0065: PushStack(player, ax);
            L0066: PushStack(player, 0xED);
            L006A: PushStack(player, 0xDD);
            L006E: PushStack(player, 0x69);
09EC  0072 C4 5E 06  les bx, [bp+0x6]
09EF  0075 26 FF 9F D8 00  call far word [es:bx+0xd8]
09F4  007A 83 C4 0C  add sp, 0xc
            L007D: AddEncounter(player, 0x01, 0x1F);
            L008F: AddEncounter(player, 0x02, 0x1F);
            L00A1: Compare(PartyCount(player), 0x0002);
            L00AC: if (JumpBelowOrEqual) goto L00D2;
            L00AE: AddEncounter(player, 0x04, 0x1F);
            L00C0: AddEncounter(player, 0x03, 0x1F);
            L00D2: Compare(PartyCount(player), 0x0003);
            L00DD: if (JumpBelowOrEqual) goto L0112;
            L00DF: AddEncounter(player, 0x05, 0x24);
            L00F1: AddEncounter(player, 0x06, 0x24);
            L0103: goto L0112;
            L0105: ShowMessage(player, String1926); // Your battle here explains why greensleeves is such a popular song: it's from all the ectoplasm!
            L0112: return; // RETURN;
        }

        private void Fn_12(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x04));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00FB;
            L001B: SetFlag(player, 0x03, 0x04, 0x01);
            L0030: ShowMessage(player, String1986); // The Carlisle Rugby Team has decided you're their next match!  And these guys play for keeps!
            L003D: Compare(PartyCount(player), 0x0003);
            L0048: if (JumpBelowOrEqual) goto L0057;
            L004A: ShowMessage(player, String19E3); // The big one's battle cry is, 'Scrum and get it!'
            L0057: PushStack(player, 0xD4);
            L005B: PushStack(player, 0x00);
            L005E: PushStack(player, ax);
            L005F: PushStack(player, ax);
            L0060: PushStack(player, 0x66);
            L0064: PushStack(player, 0x56);
0AF6  0068 C4 5E 06  les bx, [bp+0x6]
0AF9  006B 26 FF 9F D8 00  call far word [es:bx+0xd8]
0AFE  0070 83 C4 0C  add sp, 0xc
            L0073: AddEncounter(player, 0x01, 0x28);
            L0085: AddEncounter(player, 0x02, 0x1B);
            L0097: AddEncounter(player, 0x05, 0x1C);
            L00A9: Compare(PartyCount(player), 0x0002);
            L00B4: if (JumpBelowOrEqual) goto L00DA;
            L00B6: AddEncounter(player, 0x06, 0x1C);
            L00C8: AddEncounter(player, 0x03, 0x1B);
            L00DA: Compare(PartyCount(player), 0x0003);
            L00E5: if (JumpBelowOrEqual) goto L0108;
            L00E7: AddEncounter(player, 0x04, 0x28);
            L00F9: goto L0108;
            L00FB: ShowMessage(player, String1A14); // All that remains of your scrimmage here is the deflated bladder that used to be the ball.
            L0108: return; // RETURN;
        }

        private void Fn_13(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x05));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L0112;
            L001B: SetFlag(player, 0x03, 0x05, 0x01);
            L0030: ShowMessage(player, String1A6E); // Ordinarily you believe in respecting other people's religious beliefs.  But these priestesses believe in raising undead to kill unbelievers!
            L003D: Compare(PartyCount(player), 0x0003);
            L0048: if (JumpBelowOrEqual) goto L007B;
            L004A: ShowMessage(player, String1AFB); // They also believe in unfair numbers, sucking mana, and using poison.
            L0057: AddMana(player, 0xF830);
0BFC  0064 B8 20 03  mov ax, 0x320
            L0067: PushStack(player, ax);
            L0068: PushStack(player, 0x05);
            L006C: PushStack(player, 0x01);
0C08  0070 C4 5E 06  les bx, [bp+0x6]
0C0B  0073 26 FF 9F 9C 00  call far word [es:bx+0x9c]
0C10  0078 83 C4 06  add sp, 0x6
0C13  007B B8 BC 04  mov ax, 0x4bc
            L007E: PushStack(player, ax);
            L007F: PushStack(player, 0x00);
            L0082: PushStack(player, ax);
            L0083: PushStack(player, ax);
            L0084: PushStack(player, 0xCE);
            L0088: PushStack(player, 0x37);
0C24  008C C4 5E 06  les bx, [bp+0x6]
0C27  008F 26 FF 9F D8 00  call far word [es:bx+0xd8]
0C2C  0094 83 C4 0C  add sp, 0xc
            L0097: AddEncounter(player, 0x01, 0x25);
            L00A9: AddEncounter(player, 0x02, 0x25);
            L00BB: AddEncounter(player, 0x05, 0x20);
            L00CD: Compare(PartyCount(player), 0x0003);
            L00D8: if (JumpBelowOrEqual) goto L011F;
            L00DA: AddEncounter(player, 0x06, 0x20);
            L00EC: AddEncounter(player, 0x03, 0x25);
            L00FE: AddEncounter(player, 0x04, 0x20);
            L0110: goto L011F;
            L0112: ShowMessage(player, String1B40); // It's a shame: you fought all these skeletons, and not a single skeleton key ring out of it.
            L011F: return; // RETURN;
        }

        private void Fn_14(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x15));
            L0016: if (JumpNotEqual) goto L0076;
            L0018: SetFlag(player, 0x03, 0x15, 0x01);
            L002D: SetFlag(player, 0x02, 0x3E, 0x01);
            L0042: ShowPortrait(player, 0x0028);
            L004F: ShowMessage(player, String1B9C); // A troll cleric lays a hand upon thy forehead and rolls her eyes back into her head.  In a quavering, eery voice she makes her pronouncement.
            L005C: ShowMessage(player, String1C29); // 'I sense a power of goodness in thee.  Aldhelm's grace could fall upon thee!  An thou dost invoke of spirit of Aldhelm as thou dost descend beneath the Ruins, then Aldhelm will guide thee in safety and surety.  But thou must gather sufficient of Aldhelm to summon Aldhelm.
            L0069: ShowMessage(player, String1D3A); // Her eyes refocus.  Blushing, she departs.
            L0076: return; // RETURN;
        }

        private void Fn_15(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x16));
            L0016: if (JumpNotEqual) goto L0076;
            L0018: SetFlag(player, 0x03, 0x16, 0x01);
            L002D: SetFlag(player, 0x02, 0x40, 0x01);
            L0042: ShowPortrait(player, 0x002E);
            L004F: ShowMessage(player, String1D64); // You overhear a snippet of conversation.
            L005C: ShowMessage(player, String1D8C); // '....their party leader, somehow, invoked Alcuin's spirit, who in his goodness did defeat the evil locks that were upon the door.
            L0069: ShowMessage(player, String1E0E); // Then the sisters did attack in such wise and vigor as to thwart my further observ....'
            L0076: return; // RETURN;
        }

        private void Fn_16(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x17));
            L0016: if (JumpNotEqual) goto L0083;
            L0018: SetFlag(player, 0x03, 0x17, 0x01);
            L002D: SetFlag(player, 0x02, 0x3F, 0x01);
            L0042: ShowPortrait(player, 0x002E);
            L004F: ShowMessage(player, String1E65); // A gremlin wizard appears before you, gazing deep into your eyes.
            L005C: ShowMessage(player, String1EA6); // 'Hear me and heed me!  Thou hast the flavor of greatness in thy soul.
            L0069: ShowMessage(player, String1EEC); // Deep within the Bestiary, after thou hast defeated the eight foretold, an thou dost invoke the spirit of Alfred the Great, so shall he heal thee.  But thou must catch his spirit's attention when thou dost approach him.
            L0076: ShowMessage(player, String1FC7); // Nay, I will not explain!  An thou canst not decipher this plain prophecy, then thou art not so great as I think.'  She departs.
            L0083: return; // RETURN;
        }

        private void Fn_17(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x0B, 0x02, 0x7F, 0x00, isForwardMove);
            L001D: return; // RETURN;
        }

        private void Fn_19(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x0E));
            L0016: if (JumpNotEqual) goto L0054;
            L0018: SetFlag(player, 0x03, 0x0E, 0x01);
            L002D: ShowPortrait(player, 0x002D);
            L003A: ShowMessage(player, String2047); // An astrologer is lecturing his pupils as they walk by.
            L0047: ShowMessage(player, String207E); // '...shall be the counting of the cats, and the counting of the cats shall be three.  But greater than the cats is the hedgepig, who shall count once more than the....
            L0054: return; // RETURN;
        }

        private void Fn_1B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: // make space for tmp on stack: sp -= 2
            L0005: RefreshCompareFlags(GetFlag(player, 0x03, 0x0F));
            L0018: if (JumpNotEqual) goto L008F;
            L001A: ax = GetFlag(player, 0x03, 0x08);
0ED8  002B 89 46 FE  mov [bp-0x2], ax
            L002E: SetFlag(player, 0x03, 0x0F, 0x01);
            L0043: Compare(tmp, 0xFE);
0EF4  0047 7D 1F  jge 0x68
            L0049: ShowPortrait(player, 0x002B);
            L0056: ShowMessage(player, String2125); // An astrologer is instructing a customer in the proper reading of a chart as they walk past.
0F10  0063 B8 81 21  mov ax, 0x2181
            L0066: goto L0085;
            L0068: ShowPortrait(player, 0x0016);
            L0075: ShowMessage(player, String225D); // A customer pleads with his astrologer for aid.
            L0082: ShowMessage(player, String228C); // '...not tell me that merely smiling at Rowena Sly would lead to her six large swineherding brothers demanding our immediate betrothal!  Will the stench of the sty ever be free from my nostrils?  There must be some way I can avoid....'
            L008F: // restore stack ptr: sp = bp;
            L0091: return; // RETURN;
        }

        private void Fn_1C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x10));
            L0016: if (JumpNotEqual) goto L006E;
            L0018: SetFlag(player, 0x03, 0x10, 0x01);
            L002D: ShowPortrait(player, 0x002B);
            L003A: ShowMessage(player, String2377); // An astrologer is walking past, reading aloud, his head buried in a dusty tome.
            L0047: ShowMessage(player, String23C6); // 'Mewed?  That must be a reference to defeat, death, destruction, for brinded cats are the most fierce of all the felines.
            L0054: ShowMessage(player, String2440); // Thrice is obvious enough.  And whining and cries must likewise refer to combat with four hedgepigs and a harpier.
            L0061: ShowMessage(player, String24B2); // But where can one insure eight consecutive battles of the proper form?  And why would any man of science choose such an empirical approach....'
            L006E: return; // RETURN;
        }

        private void Fn_1D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: // make space for tmp on stack: sp -= 2
            L0005: RefreshCompareFlags(GetFlag(player, 0x03, 0x12));
            L0018: if (JumpEqual) goto L001D;
            L001A: goto L00AC;
            L001D: ax = GetFlag(player, 0x03, 0x08);
0FDE  002E 89 46 FE  mov [bp-0x2], ax
            L0031: SetFlag(player, 0x03, 0x12, 0x01);
            L0046: Compare(tmp, 0xFE);
0FFA  004A 7D 2C  jge 0x78
            L004C: ShowPortrait(player, 0x002E);
            L0059: ShowMessage(player, String2542); // An astrologer lectures her pupil.
            L0066: ShowMessage(player, String2564); // 'six planets are Venus, Earth, Mars, Luna, Jupiter, and Saturn.  I care not that thy calculations gain historical accuracy if thou dost assume nine planets circling the sun.
1023  0073 B8 12 26  mov ax, 0x2612
            L0076: goto L00A2;
            L0078: ShowPortrait(player, 0x002E);
            L0085: ShowMessage(player, String2542); // An astrologer lectures her pupil.
            L0092: ShowMessage(player, String26C8); // 'I care not a fig if Caesar's death was predictable.  Professor Charlatanus is a staunch anti-Caesarian who made his career by showing the soothsayer's errors.
            L009F: ShowMessage(player, String2768); // This is academia!  New ideas lead to loss of grants and sinecures.  We are not here to research more accurate astrological methods.  We are here to receive our degrees and further the existing dogma....'
            L00AC: // restore stack ptr: sp = bp;
            L00AE: return; // RETURN;
        }

        private void Fn_1E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: // make space for tmp on stack: sp -= 2
            L0005: RefreshCompareFlags(GetFlag(player, 0x03, 0x12));
            L0018: if (JumpEqual) goto L001D;
            L001A: goto L00B9;
            L001D: ax = GetFlag(player, 0x03, 0x08);
108E  002E 89 46 FE  mov [bp-0x2], ax
            L0031: SetFlag(player, 0x03, 0x12, 0x01);
            L0046: Compare(tmp, 0xFE);
10AA  004A 7D 2C  jge 0x78
            L004C: ShowPortrait(player, 0x002E);
            L0059: ShowMessage(player, String2834); // Two astrologers converse.
            L0066: ShowMessage(player, String284E); // 'Well, I foresee that thou shalt not be given consort an thou dost not return with two loaves of fresh bread and some stewing meat,' she says.
10D3  0073 B8 DD 28  mov ax, 0x28dd
            L0076: goto L00AF;
            L0078: ShowPortrait(player, 0x002B);
            L0085: ShowMessage(player, String2834); // Two astrologers converse.
            L0092: ShowMessage(player, String2953); // 'Well, I foretell that thou wilt be eating thy own cooking, and no doubt dying young from it, an thou dost refuse to aid in our lavendry,' she shouts.
            L009F: ShowMessage(player, String29EA); // 'Balderdash!  I foresee that thou shalt starve in the streets an thou dost treat me so,' he replies.
            L00AC: ShowMessage(player, String2A4F); // You know, it's amazing how accurate these astrological predictions can get these days.  The science has really taken off with the perfection of the abacus.
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
114B  002E 89 46 FE  mov [bp-0x2], ax
            L0031: SetFlag(player, 0x03, 0x13, 0x01);
            L0046: Compare(tmp, 0xFE);
1167  004A 7D 39  jge 0x85
            L004C: ShowPortrait(player, 0x002C);
            L0059: ShowMessage(player, String2AEB); // Two astrologers are laughing as they walk past.
            L0066: ShowMessage(player, String2B1B); // '...his star charts?'
            L0073: ShowMessage(player, String2B31); // 'Aye!  I put Jupiter in Libra, and Mars in Capricorn, and the fool drew up a chart for old Stowlugs Elliot predicting a good night for reiving.  
119D  0080 B8 C3 2B  mov ax, 0x2bc3
            L0083: goto L00BC;
            L0085: ShowPortrait(player, 0x0027);
            L0092: ShowMessage(player, String2C39); // An astrologer is being carried off.
            L009F: ShowMessage(player, String2C5D); // '...you must see, Master Elliot, that it was a good night for reiving metaphysically, a sign from above that thou should cease reiving.'
            L00AC: ShowMessage(player, String2CE6); // 'I can agree with all that thou dost say, but on behalf of my captured kinsmen I am about to give thee thine own sign from above, and it will be far more physical than meta.'  Stowlugs pats his sword.
            L00B9: ShowMessage(player, String2DAF); // Gee!  Astrology is a cutthroat business?
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
1215  002E 89 46 FE  mov [bp-0x2], ax
            L0031: SetFlag(player, 0x03, 0x14, 0x01);
            L0046: Compare(tmp, 0xFE);
1231  004A 7D 2C  jge 0x78
            L004C: ShowPortrait(player, 0x0027);
            L0059: ShowMessage(player, String2DD8); // An astrologer is talking to his owl familiar as they walk past.
            L0066: ShowMessage(player, String2E18); // '...a great rocket I shall launch thee into the Celestium, wherein you shall be able to see and record the most accurate star charts yet made.
125A  0073 B8 A7 2E  mov ax, 0x2ea7
            L0076: goto L00A2;
            L0078: ShowPortrait(player, 0x0027);
            L0085: ShowMessage(player, String2F47); // An astrologer is talking to his slightly singed owl familiar as they walk past.
            L0092: ShowMessage(player, String2F97); // '...sometimes rockets explode.  It was thine own fault for not flapping thy wings and aiding the rocket's flight.
            L009F: ShowMessage(player, String3009); // Thy tailfeathers will grow back!  Cease thy prattling!  Of course thou must flap.  Every fool knows that if you run backwards on a boat, then the boat moves forward faster.  So thou must fly downwards with....'
            L00AC: // restore stack ptr: sp = bp;
            L00AE: return; // RETURN;
        }

    }
}
