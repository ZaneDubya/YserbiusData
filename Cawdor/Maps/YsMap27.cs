#pragma warning disable
using System.Collections.Generic;
using XPT.WorldData;
using XPT.WorldData.Yserbius;

namespace XPT.Scripts.Yserbius.Maps {
    class YserMap27 : AMapScripted {
        protected override int MapIndex => 27;
        protected override int RandomEncounterChance => 5;
        protected override int RandomEncounterExtraCount => 0;

        public YserMap27() {
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
            MapEvent33 = Fn_33;
            MapEvent34 = Fn_34;
            MapEvent35 = Fn_35;
            MapEvent36 = Fn_36;
            MapEvent37 = Fn_37;
            MapEvent38 = Fn_38;
            MapEvent39 = Fn_39;
            MapEvent3A = Fn_3A;
            MapEvent3B = Fn_3B;
            MapEvent3C = Fn_3C;
        }
        
        // === Strings ================================================
        private const string String0140 = "You hear some footsteps running away.";
        private const string String0166 = "You hear someone strolling towards you.";
        private const string String018E = "The gremlin greets you heartily.";
        private const string String01AF = "'I just received the strangest prophecy in Astrologia.  But I think I see through some of it.  The deadly herbs are in Althea's demesne.  I should go look her up.'";
        private const string String0253 = "She remains standing there, lost in thought.";
        private const string String0280 = "The dragon examines you with a hint of recognition.";
        private const string String02B4 = "'Ah!  Whither hast thou been? I have heard yet another green dragon joke, and my thoughts turned to thee.  Wouldst hear it?'";
        private const string String0331 = "You nod.  Or is it more of a shrug?";
        private const string String0355 = "'Why is a green dragon's head like the lower left store room in here?'";
        private const string String039C = "You ask why.";
        private const string String03A9 = "'They're both filled with large round hard useless objects!'";
        private const string String03E6 = "'Aren't they both filled with rocks?' you ask politely.";
        private const string String041E = "'That too!'  The dragon falls over, laughing uncontrollably.  You would shake your head, but prudence dictates a quiet retreat.";
        private const string String049E = "'Ah, my friend!  Look not so worried.  I am sure I will hear or devise another green dragon joke before long!'";
        private const string String050D = "It wouldn't do to say this, but the prospect of yet another dragon joke is why you looked so worried.";
        private const string String0573 = "A downtrodden halfling knight ambles aimlessly by you.";
        private const string String05AA = "'Serves me right to expect anything cobbled together from horseshoes to bear my weight,' she mutters as she passes.";
        private const string String061E = "A boisterous band of burglars decides, reasonably, that they are bigger than you are.";
        private const string String0674 = "A cold breeze sends shivers down your spine.";
        private const string String06A1 = "This door leads to the Nasty Little Maze.";
        private const string String06CB = "This door leads to the Astrologia.";
        private const string String06EE = "Rory's clothes are sweat stained, and his brow furrowed.  Still, a smile crosses his face as he greets you.";
        private const string String075A = "'Ah, 'tis good to have a chance for a breather, for this is a fractious place created by a devious and disturbed mind.";
        private const string String07D1 = "'It is called the Parapets, but insofar as I can determine it is a loathsome play on words, for many are the corners filled with pairs of groups of great beasts.";
        private const string String0873 = "'I know not what manner of being keeps drakes, wolves, medusae, or minotaurs for pets, and I do not care to meet him.";
        private const string String08E9 = "'I can say this; the tongue of dog, tooth of wolf, and scale of dragon, have been most useful here.  But I have yet to find that which cows the medusae or minotaurs.";
        private const string String098F = "'I'm for the lower levels and regrouping.  Good luck, and watch thy back!'";
        private const string String09DA = "The howls of a hundred creatures echo through the parapets.";
        private const string String0A16 = "Once upon a time Rory gave you some good advice here, but his days as your adviser are ended.";
        private const string String0A74 = "The torches are smoky, creating an eery mood in here.";
        private const string String0AAA = "The windows are hinged, allowing easy opening for airing the place out or, more likely, for firing ranged weapons and dumping noxious compounds on an enemy.";
        private const string String0B47 = "If they were just a little more corroded, though, leaning out could well prove fatal.";
        private const string String0B9D = "The caption reads:  'The late William o'the Dales, undisputed record holder and winner of the 1168 ballista catch.'";
        private const string String0C11 = "The caption reads:  'Jonny of the Mountain Hall, who once slew a trio of giants with but a single toss of his mighty hammer.'";
        private const string String0C8F = "The caption reads:  'Richard of the Storm, who did devise a formula for capturing the Greek Fire.  All we ever found was the hilt of his dagger.  Requiescat en Pacem.'";
        private const string String0D37 = "The caption reads:  'Edward of the White Cathedral, who first poured heated pitch on those outside the keep.  It worked so well when the Picts attacked that the survivors of the first spill forgave him.'";
        private const string String0E03 = "The caption reads:  'Eric the Steady, son of Eric the Sufferer, who proved that a truly strong troll can catch and hold a 2800 pound boulder.  For 1.2 seconds.  Before being squashed.";
        private const string String0EBB = "The caption reads:  'Deborah of the Marble Chapel, who asked the innocent question that exposed a plot long buried.'";
        private const string String0F30 = "The caption reads:  'Jimmy of the Blood, as noted a painter as he was a general.'";
        private const string String0F82 = "The caption reads:  'Geordie the Skunkcatcher, who shot the sheriff and escaped to tell about it.'";
        private const string String0FE5 = "The caption reads:  'Scotty the Smith, who proved that a truly inspired archer, from these very parapets, can indeed place an arrow into the heart of a general atop Stormcrow hill.'";
        private const string String109B = "The caption reads:  'Mandy of the Inks, who demonstrated that by predesignating targets and marking their aims afore the battle, one can have great success at shooting during the battle.'";
        private const string String1157 = "The caption reads:  'Richard of the Irish River, who demonstrated that not only does fine wine raise the will to fight, but that at need and sufficient height an empty wine bottle can kill.'";
        private const string String1216 = "The caption reads:  'Mickey of the Upper Dells, who most cunningly proved that a boulder is better than a pebble when stoning an enemy.'";
        private const string String129F = "The caption reads:  'Clifford the Quiet, master of the crossbow and the galley oar.'";
        private const string String12F4 = "The caption reads:  'Cynthia of the Cats, creator of the pegasus brigade and discoverer of the remarkable fertilizing qualities of pegasus droppings.  Retired.'";
        private const string String1395 = "The caption reads:  'Richard, son of the Emerald Isles, who showed that a bag of gems might buy what an army could not take.'";
        private const string String1413 = "The caption reads:  'Molly of the Concentric Circles, who in giving her life did ensure Scotty's fame.'";
        private const string String147B = "You see a large storage area.  The smell in here is unpleasant, and the sounds are noisome and diverse.  On either wall is a plaque explaining where various armaments are stored.";
        private const string String152E = "That is, assuming any armaments remain.";
        private const string String1556 = "The storage area remains as you left it.";
        private const string String157F = "The plaque explains that quarrels and bolts were stored in the lower right area, stones and rocks in the lower left, oil and pitch in the upper right, and 'nasties, heh heh' in the upper left.";
        private const string String1640 = "But judging from the sounds nearby, the equipment rooms have been taken over by rude and unpleasant creatures who did not bother to update the plaques.  Shame on them!";
        private const string String16E8 = "From the sounds on the other side of this door, you prepare yourself for immediate battle after going though it.";
        private const string String1759 = "Ayee!  It's the flock of killer goats!";
        private const string String1780 = "Oh, all right, I'll admit they sure look like minotaurs, but believe me, they sure smell like goats.";
        private const string String17E5 = "Your epic struggle with the bovine goats left goatees scattered all over the place (heh heh).";
        private const string String1843 = "You think you hear the sounds of a baying wolf through this door, and prepare yourself for combat.";
        private const string String18A6 = "Hmm.  Bay o'wolf.  Maybe there's a story in there.";
        private const string String18D9 = "My goodness!  Look at all those wolves packed in here.  Hmm.  Wolvespacked.  Maybe there's a story there.";
        private const string String1943 = "You find the signs of your battle with the wolves all over this area.";
        private const string String1989 = "You've already performed all the dentistry possible here, with complete disregard for the wolf's place on the endangered species list.";
        private const string String1A10 = "You think you hear the growls of a great mastiff, a giant hound, through the door.";
        private const string String1A63 = "Hmm.  The Hound of - naw, there's no way to fit any decent story into that title.";
        private const string String1AB5 = "Have you ever heard of puppy love.  Well, these dogs haven't!  Watch out!";
        private const string String1AFF = "Reminders of your battle in this area still dog your footsteps.  Yuk.";
        private const string String1B45 = "You've already taught those puppies the value of love.  Tough love.  Really really tough love.";
        private const string String1BA4 = "You hear a lot of hissing through this door, as if a veritable snakepit.  You'd put on your hightop boots, if you had any.";
        private const string String1C1F = "See!  High topped boots wouldn't have helped you anyways!";
        private const string String1C59 = "Boy, the snake skins sure got spattered everywhere.";
        private const string String1C8D = "Hmm.  You probably could get some high topped snake skin boots made, if you knew a cobbler.  But any cobblers left around here have already been eaten by the halflings.";
        private const string String1D36 = "'Look, friend, I've been told to keep everyone out of this room.  There are dragons in here, large violent firebreathing, uh....'";
        private const string String1DB8 = "His voice trails off as he hears your party mutter 'Cool!' 'About time!' 'Let's break some drake!' and other inappropriate epithets, combined with a loosening of your weapons.";
        private const string String1E68 = "'Well, I am not about to stand in your way,' he continues, 'but never let it be said that thou wert unwarned.'";
        private const string String1ED7 = "'I am glad thou hast heeded my warning,' says the elf.";
        private const string String1F0E = "'And for thy wisdom, a small reward.'";
        private const string String1F34 = "You wave various trophies taken from the drakes in the cleric's face.  When adventurers are as tough as you've become, you don't need to be courteous.";
        private const string String1FCB = "The elf shakes his head, sadly.";
        private const string String1FEB = "Naw.  It couldn't be.  But you'd swear that you heard some faint voices quietly chanting 'munchies' repeatedly.";
        private const string String205B = "Uh oh!  Why do you suddenly feel like a snack pack?";
        private const string String208F = "You see some spattered pieces of dragon.";
        private const string String20B8 = "I guess sometimes the snackees win!";
        private const string String20DC = "The elf looks you very seriously in the eye.";
        private const string String2109 = "'Some battles cannot be won,' he says.  'An thou dost enter here, it is upon thy head.'";
        private const string String2161 = "'There are not just drakes within, but they are equipped with the most puissant weapons of the old magics, weapons designed to destroy armies.'";
        private const string String21F1 = "'I do beg of thee, leave off.  This is not the place for aught but heroes from the age of legend.'";
        private const string String2254 = "'Thou hast been warned,' the elf says.";
        private const string String227B = "'Some battles just needed someone tougher to fight them,' you tell the elf, a broad smile on your face.";
        private const string String22E3 = "Hmm.  Could the sudden wave of fatigue be being hit by 'nasties' or is it just the realization that there are a whole lot of dragons in front of you?";
        private const string String2379 = "Well, you're just as happy not to have to go through that all over again.  Dragons are bad enough, but setting them up with 'nasties' for an ambush was too much.";
        private const string String241B = "If you intended to pick a quarrel, you've come to the right place.  It's a shame that they were all designed for larger bows than you bear.";
        private const string String24A7 = "There are many useless sharp pointy things here.  Useless to you, anyways.";
        private const string String24F2 = "If you intended to pick a quarry, you've come to the right place.  It's a shame that they were all designed for catapults.  Besides, your backpack is only rated for 200 pounds.";
        private const string String25A3 = "And never you mind how all that gold fits in there.  We'll just call it magic and leave well enough alone.";
        private const string String260E = "There are many useless round hard things here.  Useless to you, anyways.";
        private const string String2657 = "If you intended to pick a barrel, you've come to the right place.  It's a shame that they were all designed for boiling pots, and are far too large to carry.";
        private const string String26F5 = "If you ever need oil, tar, or pitch, you know where to get some.";
        private const string String2736 = "Okay.  The place reeks.  Your head hurts, and you're not sure of your ability to cast spells.";
        private const string String2794 = "Other than that, this place isn't nasty at all.";
        private const string String27C4 = "This is a nasty place.";
        private const string String27DB = "This is a very nasty place.";
        
        // === Functions ================================================
        private void Fn_05(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si, di);
            L0005: di = 0;
            L0007: si = 0;
            L0009: ax = GetFlag(player, 0x03, 0x08);
0035  001A 8B F8  mov di, ax
0037  001C 47     inc di
0038  001D 8B F7  mov si, di
            L001F: Compare(si, 0x13);
            L0022: if (JumpLessOrEqual) goto L002B;
003F  0024 8B C6  mov ax, si
            L0026: si = ax + 0xFFEC;
            L002B: Compare(si, 0x0E);
            L002E: if (JumpLessOrEqual) goto L0037;
004B  0030 8B C6  mov ax, si
            L0032: si = ax + 0xFFF1;
            L0037: Compare(si, 0x09);
            L003A: if (JumpLessOrEqual) goto L0043;
0057  003C 8B C6  mov ax, si
            L003E: si = ax + 0xFFF6;
            L0043: Compare(si, 0x04);
            L0046: if (JumpLessOrEqual) goto L004F;
0063  0048 8B C6  mov ax, si
            L004A: si = ax + 0xFFFB;
006A  004F 0B F6  or si, si
006C  0051 7D 02  jge 0x55
            L0053: si = 0;
            L0055: Compare(si, 0x1D);
            L0058: if (JumpLessOrEqual) goto L005C;
            L005A: si = 0;
0077  005C 83 FF 1E  cmp di, 0x1e
            L005F: if (JumpLessOrEqual) goto L0063;
            L0061: di = 0;
007E  0063 57     push di
            L0064: PushStack(player, 0x08);
            L0068: PushStack(player, 0x03);
0087  006C C4 5E 06  les bx, [bp+0x6]
008A  006F 26 FF 1F  call far word [es:bx]
008D  0072 83 C4 06  add sp, 0x6
0090  0075 83 FF 1A  cmp di, 0x1a
            L0078: if (JumpNotEqual) goto L007F;
0095  007A B8 01 00  mov ax, 0x1
            L007D: goto L0081;
            L007F: PushStack(player, 0x00);
009D  0082 83 FF 14  cmp di, 0x14
            L0085: if (JumpNotEqual) goto L008C;
00A2  0087 B8 01 00  mov ax, 0x1
            L008A: goto L008E;
00A7  008C 33 C0  xor ax, ax
            L008E: dx = PopStack(player);
00AA  008F 0B D0  or dx, ax
            L0091: PushStack(player, dx);
00AD  0092 83 FF 0E  cmp di, 0xe
            L0095: if (JumpNotEqual) goto L009C;
00B2  0097 B8 01 00  mov ax, 0x1
            L009A: goto L009E;
00B7  009C 33 C0  xor ax, ax
            L009E: dx = PopStack(player);
00BA  009F 0B D0  or dx, ax
            L00A1: PushStack(player, dx);
00BD  00A2 83 FF 08  cmp di, 0x8
            L00A5: if (JumpNotEqual) goto L00AC;
00C2  00A7 B8 01 00  mov ax, 0x1
            L00AA: goto L00AE;
00C7  00AC 33 C0  xor ax, ax
            L00AE: dx = PopStack(player);
00CA  00AF 0B D0  or dx, ax
            L00B1: PushStack(player, dx);
00CD  00B2 83 FF 02  cmp di, 0x2
            L00B5: if (JumpNotEqual) goto L00BC;
00D2  00B7 B8 01 00  mov ax, 0x1
            L00BA: goto L00BE;
00D7  00BC 33 C0  xor ax, ax
            L00BE: dx = PopStack(player);
00DA  00BF 0B D0  or dx, ax
            L00C1: if (JumpNotEqual) goto L00C6;
            L00C3: goto L0283;
            L00C6: bx = si;
            L00C8: Compare(bx, 0x04);
            L00CB: if (JumpBelowOrEqual) goto L00D0;
            L00CD: goto L0283;
            L00D0: switch (bx) {
                case 0:
                    goto L00D7;
                case 1:
                    goto L00E7;
                case 2:
                    goto L0120;
                case 3:
                    goto L01D8;
                case 4:
                    goto L01F8;
            }
            L00D7: ShowMessage(player, String0140); // You hear some footsteps running away.
            L00E4: goto L0283;
            L00E7: ShowMessage(player, String0166); // You hear someone strolling towards you.
            L00F4: ShowPortrait(player, 0x002E);
            L0101: ShowMessage(player, String018E); // The gremlin greets you heartily.
            L010E: ShowMessage(player, String01AF); // 'I just received the strangest prophecy in Astrologia.  But I think I see through some of it.  The deadly herbs are in Althea's demesne.  I should go look her up.'
0136  011B B8 53 02  mov ax, 0x253
            L011E: goto L00DA;
            L0120: ShowPortrait(player, 0x000E);
            L012D: RefreshCompareFlags(GetFlag(player, 0x02, 0x65));
            L0140: if (JumpEqual) goto L0145;
            L0142: goto L01C5;
            L0145: ShowMessage(player, String0280); // The dragon examines you with a hint of recognition.
            L0152: ShowMessage(player, String02B4); // 'Ah!  Whither hast thou been? I have heard yet another green dragon joke, and my thoughts turned to thee.  Wouldst hear it?'
            L015F: ShowMessage(player, String0331); // You nod.  Or is it more of a shrug?
            L016C: ShowMessage(player, String0355); // 'Why is a green dragon's head like the lower left store room in here?'
            L0179: ShowMessage(player, String039C); // You ask why.
            L0186: ShowMessage(player, String03A9); // 'They're both filled with large round hard useless objects!'
            L0193: ShowMessage(player, String03E6); // 'Aren't they both filled with rocks?' you ask politely.
            L01A0: ShowMessage(player, String041E); // 'That too!'  The dragon falls over, laughing uncontrollably.  You would shake your head, but prudence dictates a quiet retreat.
            L01AD: SetFlag(player, 0x02, 0x65, 0x01);
            L01C2: goto L0283;
            L01C5: ShowMessage(player, String049E); // 'Ah, my friend!  Look not so worried.  I am sure I will hear or devise another green dragon joke before long!'
01ED  01D2 B8 0D 05  mov ax, 0x50d
            L01D5: goto L00DA;
            L01D8: ShowPortrait(player, 0x001D);
            L01E5: ShowMessage(player, String0573); // A downtrodden halfling knight ambles aimlessly by you.
020D  01F2 B8 AA 05  mov ax, 0x5aa
            L01F5: goto L00DA;
            L01F8: ShowMessage(player, String061E); // A boisterous band of burglars decides, reasonably, that they are bigger than you are.
0220  0205 B8 A9 04  mov ax, 0x4a9
            L0208: PushStack(player, ax);
            L0209: PushStack(player, 0x00);
            L020C: PushStack(player, ax);
            L020D: PushStack(player, ax);
            L020E: PushStack(player, 0xCD);
            L0212: PushStack(player, 0xBE);
0231  0216 C4 5E 06  les bx, [bp+0x6]
0234  0219 26 FF 9F D8 00  call far word [es:bx+0xd8]
0239  021E 83 C4 0C  add sp, 0xc
            L0221: AddEncounter(player, 0x01, 0x19);
            L0233: Compare(PartyCount(player), 0x0001);
            L023E: if (JumpBelowOrEqual) goto L0252;
            L0240: AddEncounter(player, 0x05, 0x19);
            L0252: Compare(PartyCount(player), 0x0002);
            L025D: if (JumpBelowOrEqual) goto L0283;
            L025F: AddEncounter(player, 0x02, 0x19);
            L0271: AddEncounter(player, 0x06, 0x19);
            L0283: return; // RETURN (restoring si, di);
        }

        private void Fn_06(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0674); // A cold breeze sends shivers down your spine.
            L0010: return; // RETURN;
        }

        private void Fn_07(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String06A1); // This door leads to the Nasty Little Maze.
            L0010: TeleportParty(player, 0x0B, 0x01, 0x0B, 0x01, isForwardMove);
            L002B: return; // RETURN;
        }

        private void Fn_08(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String06CB); // This door leads to the Astrologia.
            L0010: TeleportParty(player, 0x0A, 0x01, 0x70, 0x02, isForwardMove);
            L002B: return; // RETURN;
        }

        private void Fn_09(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x02, 0x47));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L009D;
            L001B: RefreshCompareFlags(GetFlag(player, 0x03, 0x0A));
            L002E: if (JumpNotEqual) goto L0098;
            L0030: SetFlag(player, 0x03, 0x0A, 0x01);
            L0045: ShowPortrait(player, 0x0025);
            L0052: ShowMessage(player, String06EE); // Rory's clothes are sweat stained, and his brow furrowed.  Still, a smile crosses his face as he greets you.
            L005F: ShowMessage(player, String075A); // 'Ah, 'tis good to have a chance for a breather, for this is a fractious place created by a devious and disturbed mind.
            L006C: ShowMessage(player, String07D1); // 'It is called the Parapets, but insofar as I can determine it is a loathsome play on words, for many are the corners filled with pairs of groups of great beasts.
            L0079: ShowMessage(player, String0873); // 'I know not what manner of being keeps drakes, wolves, medusae, or minotaurs for pets, and I do not care to meet him.
            L0086: ShowMessage(player, String08E9); // 'I can say this; the tongue of dog, tooth of wolf, and scale of dragon, have been most useful here.  But I have yet to find that which cows the medusae or minotaurs.
03AB  0093 B8 8F 09  mov ax, 0x98f
            L0096: goto L00A0;
03B0  0098 B8 DA 09  mov ax, 0x9da
            L009B: goto L00A0;
            L009D: ShowMessage(player, String0A16); // Once upon a time Rory gave you some good advice here, but his days as your adviser are ended.
            L00AA: return; // RETURN;
        }

        private void Fn_0A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0A74); // The torches are smoky, creating an eery mood in here.
            L0010: return; // RETURN;
        }

        private void Fn_0B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0AAA); // The windows are hinged, allowing easy opening for airing the place out or, more likely, for firing ranged weapons and dumping noxious compounds on an enemy.
            L0010: ShowMessage(player, String0B47); // If they were just a little more corroded, though, leaning out could well prove fatal.
            L001D: return; // RETURN;
        }

        private void Fn_0C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x001F);
            L0010: ShowMessage(player, String0B9D); // The caption reads:  'The late William o'the Dales, undisputed record holder and winner of the 1168 ballista catch.'
            L001D: return; // RETURN;
        }

        private void Fn_0D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x001C);
            L0010: ShowMessage(player, String0C11); // The caption reads:  'Jonny of the Mountain Hall, who once slew a trio of giants with but a single toss of his mighty hammer.'
            L001D: return; // RETURN;
        }

        private void Fn_0E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x002D);
            L0010: ShowMessage(player, String0C8F); // The caption reads:  'Richard of the Storm, who did devise a formula for capturing the Greek Fire.  All we ever found was the hilt of his dagger.  Requiescat en Pacem.'
            L001D: return; // RETURN;
        }

        private void Fn_0F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x002B);
            L0010: ShowMessage(player, String0D37); // The caption reads:  'Edward of the White Cathedral, who first poured heated pitch on those outside the keep.  It worked so well when the Picts attacked that the survivors of the first spill forgave him.'
            L001D: return; // RETURN;
        }

        private void Fn_10(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0020);
            L0010: ShowMessage(player, String0E03); // The caption reads:  'Eric the Steady, son of Eric the Sufferer, who proved that a truly strong troll can catch and hold a 2800 pound boulder.  For 1.2 seconds.  Before being squashed.
            L001D: return; // RETURN;
        }

        private void Fn_11(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0018);
            L0010: ShowMessage(player, String0EBB); // The caption reads:  'Deborah of the Marble Chapel, who asked the innocent question that exposed a plot long buried.'
            L001D: return; // RETURN;
        }

        private void Fn_12(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0016);
            L0010: ShowMessage(player, String0F30); // The caption reads:  'Jimmy of the Blood, as noted a painter as he was a general.'
            L001D: return; // RETURN;
        }

        private void Fn_13(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x002B);
            L0010: ShowMessage(player, String0F82); // The caption reads:  'Geordie the Skunkcatcher, who shot the sheriff and escaped to tell about it.'
            L001D: return; // RETURN;
        }

        private void Fn_14(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x001A);
            L0010: ShowMessage(player, String0FE5); // The caption reads:  'Scotty the Smith, who proved that a truly inspired archer, from these very parapets, can indeed place an arrow into the heart of a general atop Stormcrow hill.'
            L001D: return; // RETURN;
        }

        private void Fn_15(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0017);
            L0010: ShowMessage(player, String109B); // The caption reads:  'Mandy of the Inks, who demonstrated that by predesignating targets and marking their aims afore the battle, one can have great success at shooting during the battle.'
            L001D: return; // RETURN;
        }

        private void Fn_16(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0027);
            L0010: ShowMessage(player, String1157); // The caption reads:  'Richard of the Irish River, who demonstrated that not only does fine wine raise the will to fight, but that at need and sufficient height an empty wine bottle can kill.'
            L001D: return; // RETURN;
        }

        private void Fn_17(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x002B);
            L0010: ShowMessage(player, String1216); // The caption reads:  'Mickey of the Upper Dells, who most cunningly proved that a boulder is better than a pebble when stoning an enemy.'
            L001D: return; // RETURN;
        }

        private void Fn_18(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0020);
            L0010: ShowMessage(player, String129F); // The caption reads:  'Clifford the Quiet, master of the crossbow and the galley oar.'
            L001D: return; // RETURN;
        }

        private void Fn_19(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0022);
            L0010: ShowMessage(player, String12F4); // The caption reads:  'Cynthia of the Cats, creator of the pegasus brigade and discoverer of the remarkable fertilizing qualities of pegasus droppings.  Retired.'
            L001D: return; // RETURN;
        }

        private void Fn_1A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0025);
            L0010: ShowMessage(player, String1395); // The caption reads:  'Richard, son of the Emerald Isles, who showed that a bag of gems might buy what an army could not take.'
            L001D: return; // RETURN;
        }

        private void Fn_1B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0017);
            L0010: ShowMessage(player, String1413); // The caption reads:  'Molly of the Concentric Circles, who in giving her life did ensure Scotty's fame.'
            L001D: return; // RETURN;
        }

        private void Fn_1C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x0B));
            L0016: if (JumpNotEqual) goto L003F;
            L0018: SetFlag(player, 0x03, 0x0B, 0x01);
            L002D: ShowMessage(player, String147B); // You see a large storage area.  The smell in here is unpleasant, and the sounds are noisome and diverse.  On either wall is a plaque explaining where various armaments are stored.
061F  003A B8 2E 15  mov ax, 0x152e
            L003D: goto L0042;
            L003F: ShowMessage(player, String1556); // The storage area remains as you left it.
            L004C: return; // RETURN;
        }

        private void Fn_1D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String157F); // The plaque explains that quarrels and bolts were stored in the lower right area, stones and rocks in the lower left, oil and pitch in the upper right, and 'nasties, heh heh' in the upper left.
            L0010: ShowMessage(player, String1640); // But judging from the sounds nearby, the equipment rooms have been taken over by rude and unpleasant creatures who did not bother to update the plaques.  Shame on them!
            L001D: return; // RETURN;
        }

        private void Fn_1E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x01), 0x0001);
            L0017: if (JumpNotEqual) goto L0026;
            L0019: PushStack(player, GetFacing(player));
0673  0021 B8 C3 00  mov ax, 0xc3
            L0024: goto L005B;
            L0026: ShowMessage(player, String16E8); // From the sounds on the other side of this door, you prepare yourself for immediate battle after going though it.
            L0033: ax = HasItem(player, 0xFB);
            L0041: if (JumpEqual) goto L0050;
            L0043: PushStack(player, GetFacing(player));
069D  004B B8 D2 00  mov ax, 0xd2
            L004E: goto L005B;
            L0050: PushStack(player, GetFacing(player));
            L0058: PushStack(player, 0xE1);
            L005C: PushStack(player, 0x02);
            L0060: PushStack(player, 0x0B);
06B6  0064 C4 5E 06  les bx, [bp+0x6]
06B9  0067 26 FF 9F BC 00  call far word [es:bx+0xbc]
06BE  006C 83 C4 08  add sp, 0x8
            L006F: return; // RETURN;
        }

        private void Fn_1F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x01));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00E1;
            L001B: PushStack(player, 0x01);
            L001F: PushStack(player, ax);
            L0020: PushStack(player, 0x03);
06E7  0024 C4 5E 06  les bx, [bp+0x6]
06EA  0027 26 FF 1F  call far word [es:bx]
06ED  002A 83 C4 06  add sp, 0x6
            L002D: ShowMessage(player, String1759); // Ayee!  It's the flock of killer goats!
            L003A: ShowMessage(player, String1780); // Oh, all right, I'll admit they sure look like minotaurs, but believe me, they sure smell like goats.
070A  0047 B8 C3 04  mov ax, 0x4c3
            L004A: PushStack(player, ax);
            L004B: PushStack(player, 0x00);
            L004E: PushStack(player, ax);
            L004F: PushStack(player, 0xBB);
            L0053: PushStack(player, 0x88);
            L0057: PushStack(player, 0x68);
071E  005B C4 5E 06  les bx, [bp+0x6]
0721  005E 26 FF 9F D8 00  call far word [es:bx+0xd8]
0726  0063 83 C4 0C  add sp, 0xc
            L0066: AddEncounter(player, 0x01, 0x26);
            L0078: AddEncounter(player, 0x02, 0x27);
            L008A: AddEncounter(player, 0x03, 0x27);
            L009C: AddEncounter(player, 0x04, 0x26);
            L00AE: Compare(PartyCount(player), 0x0002);
            L00B9: if (JumpBelowOrEqual) goto L00EE;
            L00BB: AddEncounter(player, 0x05, 0x27);
            L00CD: AddEncounter(player, 0x06, 0x26);
            L00DF: goto L00EE;
            L00E1: ShowMessage(player, String17E5); // Your epic struggle with the bovine goats left goatees scattered all over the place (heh heh).
            L00EE: return; // RETURN;
        }

        private void Fn_20(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x01));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00E1;
            L001B: PushStack(player, 0x01);
            L001F: PushStack(player, ax);
            L0020: PushStack(player, 0x03);
07D7  0024 C4 5E 06  les bx, [bp+0x6]
07DA  0027 26 FF 1F  call far word [es:bx]
07DD  002A 83 C4 06  add sp, 0x6
            L002D: ShowMessage(player, String1759); // Ayee!  It's the flock of killer goats!
            L003A: ShowMessage(player, String1780); // Oh, all right, I'll admit they sure look like minotaurs, but believe me, they sure smell like goats.
07FA  0047 B8 C3 04  mov ax, 0x4c3
            L004A: PushStack(player, ax);
            L004B: PushStack(player, 0x00);
            L004E: PushStack(player, ax);
            L004F: PushStack(player, 0xBB);
            L0053: PushStack(player, 0x88);
            L0057: PushStack(player, 0x68);
080E  005B C4 5E 06  les bx, [bp+0x6]
0811  005E 26 FF 9F D8 00  call far word [es:bx+0xd8]
0816  0063 83 C4 0C  add sp, 0xc
            L0066: AddEncounter(player, 0x01, 0x28);
            L0078: AddEncounter(player, 0x02, 0x27);
            L008A: AddEncounter(player, 0x03, 0x28);
            L009C: AddEncounter(player, 0x04, 0x27);
            L00AE: Compare(PartyCount(player), 0x0002);
            L00B9: if (JumpBelowOrEqual) goto L00EE;
            L00BB: AddEncounter(player, 0x05, 0x28);
            L00CD: AddEncounter(player, 0x06, 0x28);
            L00DF: goto L00EE;
            L00E1: ShowMessage(player, String17E5); // Your epic struggle with the bovine goats left goatees scattered all over the place (heh heh).
            L00EE: return; // RETURN;
        }

        private void Fn_21(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x02), 0x0001);
            L0017: if (JumpNotEqual) goto L0026;
            L0019: PushStack(player, GetFacing(player));
08C4  0021 B8 33 00  mov ax, 0x33
            L0024: goto L0068;
            L0026: ShowMessage(player, String1843); // You think you hear the sounds of a baying wolf through this door, and prepare yourself for combat.
            L0033: ShowMessage(player, String18A6); // Hmm.  Bay o'wolf.  Maybe there's a story in there.
            L0040: ax = HasItem(player, 0xF9);
            L004E: if (JumpEqual) goto L005D;
            L0050: PushStack(player, GetFacing(player));
08FB  0058 B8 11 00  mov ax, 0x11
            L005B: goto L0068;
            L005D: PushStack(player, GetFacing(player));
            L0065: PushStack(player, 0x22);
            L0069: PushStack(player, 0x02);
            L006D: PushStack(player, 0x0B);
0914  0071 C4 5E 06  les bx, [bp+0x6]
0917  0074 26 FF 9F BC 00  call far word [es:bx+0xbc]
091C  0079 83 C4 08  add sp, 0x8
            L007C: return; // RETURN;
        }

        private void Fn_22(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x02));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00D7;
            L001B: SetFlag(player, 0x03, 0x02, 0x01);
            L0030: ShowMessage(player, String18D9); // My goodness!  Look at all those wolves packed in here.  Hmm.  Wolvespacked.  Maybe there's a story there.
095E  003D B8 C3 04  mov ax, 0x4c3
            L0040: PushStack(player, ax);
            L0041: PushStack(player, 0x00);
            L0044: PushStack(player, ax);
            L0045: PushStack(player, 0xBB);
            L0049: PushStack(player, 0x8A);
            L004D: PushStack(player, 0xF9);
0972  0051 C4 5E 06  les bx, [bp+0x6]
0975  0054 26 FF 9F D8 00  call far word [es:bx+0xd8]
097A  0059 83 C4 0C  add sp, 0xc
            L005C: AddEncounter(player, 0x01, 0x22);
            L006E: AddEncounter(player, 0x02, 0x22);
            L0080: AddEncounter(player, 0x03, 0x22);
            L0092: AddEncounter(player, 0x04, 0x22);
            L00A4: Compare(PartyCount(player), 0x0002);
            L00AF: if (JumpBelowOrEqual) goto L00F1;
            L00B1: AddEncounter(player, 0x05, 0x22);
            L00C3: AddEncounter(player, 0x06, 0x22);
            L00D5: goto L00F1;
            L00D7: ShowMessage(player, String1943); // You find the signs of your battle with the wolves all over this area.
            L00E4: ShowMessage(player, String1989); // You've already performed all the dentistry possible here, with complete disregard for the wolf's place on the endangered species list.
            L00F1: return; // RETURN;
        }

        private void Fn_23(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x02));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00D7;
            L001B: SetFlag(player, 0x03, 0x02, 0x01);
            L0030: ShowMessage(player, String18D9); // My goodness!  Look at all those wolves packed in here.  Hmm.  Wolvespacked.  Maybe there's a story there.
0A51  003D B8 C3 04  mov ax, 0x4c3
            L0040: PushStack(player, ax);
            L0041: PushStack(player, 0x00);
            L0044: PushStack(player, ax);
            L0045: PushStack(player, 0xBB);
            L0049: PushStack(player, 0x8A);
            L004D: PushStack(player, 0xF9);
0A65  0051 C4 5E 06  les bx, [bp+0x6]
0A68  0054 26 FF 9F D8 00  call far word [es:bx+0xd8]
0A6D  0059 83 C4 0C  add sp, 0xc
            L005C: AddEncounter(player, 0x01, 0x20);
            L006E: AddEncounter(player, 0x02, 0x21);
            L0080: AddEncounter(player, 0x03, 0x20);
            L0092: AddEncounter(player, 0x04, 0x21);
            L00A4: Compare(PartyCount(player), 0x0002);
            L00AF: if (JumpBelowOrEqual) goto L00F1;
            L00B1: AddEncounter(player, 0x05, 0x20);
            L00C3: AddEncounter(player, 0x06, 0x21);
            L00D5: goto L00F1;
            L00D7: ShowMessage(player, String1943); // You find the signs of your battle with the wolves all over this area.
            L00E4: ShowMessage(player, String1989); // You've already performed all the dentistry possible here, with complete disregard for the wolf's place on the endangered species list.
            L00F1: return; // RETURN;
        }

        private void Fn_24(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x03);
            L0007: PushStack(player, ax);
0B0F  0008 C4 5E 06  les bx, [bp+0x6]
0B12  000B 26 FF 5F 04  call far word [es:bx+0x4]
            L000F: cx = PopStack(player);
            L0010: cx = PopStack(player);
            L0011: Compare(ax, 0x0001);
            L0014: if (JumpNotEqual) goto L0023;
            L0016: PushStack(player, GetFacing(player));
0B25  001E B8 3C 00  mov ax, 0x3c
            L0021: goto L0065;
            L0023: ShowMessage(player, String1A10); // You think you hear the growls of a great mastiff, a giant hound, through the door.
            L0030: ShowMessage(player, String1A63); // Hmm.  The Hound of - naw, there's no way to fit any decent story into that title.
            L003D: ax = HasItem(player, 0xF3);
            L004B: if (JumpEqual) goto L005A;
            L004D: PushStack(player, GetFacing(player));
0B5C  0055 B8 2D 00  mov ax, 0x2d
            L0058: goto L0065;
            L005A: PushStack(player, GetFacing(player));
            L0062: PushStack(player, 0x1E);
            L0066: PushStack(player, 0x02);
            L006A: PushStack(player, 0x0B);
0B75  006E C4 5E 06  les bx, [bp+0x6]
0B78  0071 26 FF 9F BC 00  call far word [es:bx+0xbc]
0B7D  0076 83 C4 08  add sp, 0x8
            L0079: return; // RETURN;
        }

        private void Fn_25(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x03);
            L0007: PushStack(player, ax);
0B8A  0008 C4 5E 06  les bx, [bp+0x6]
0B8D  000B 26 FF 5F 04  call far word [es:bx+0x4]
            L000F: cx = PopStack(player);
            L0010: cx = PopStack(player);
            L0011: RefreshCompareFlags(ax);
            L0013: if (JumpEqual) goto L0018;
            L0015: goto L00CE;
            L0018: PushStack(player, 0x01);
            L001C: PushStack(player, 0x03);
            L0020: PushStack(player, ax);
0BA3  0021 C4 5E 06  les bx, [bp+0x6]
0BA6  0024 26 FF 1F  call far word [es:bx]
0BA9  0027 83 C4 06  add sp, 0x6
            L002A: ShowMessage(player, String1AB5); // Have you ever heard of puppy love.  Well, these dogs haven't!  Watch out!
0BB9  0037 B8 C3 04  mov ax, 0x4c3
            L003A: PushStack(player, ax);
            L003B: PushStack(player, 0x00);
            L003E: PushStack(player, ax);
            L003F: PushStack(player, 0xBB);
            L0043: PushStack(player, 0xF3);
            L0047: PushStack(player, ax);
0BCA  0048 C4 5E 06  les bx, [bp+0x6]
0BCD  004B 26 FF 9F D8 00  call far word [es:bx+0xd8]
0BD2  0050 83 C4 0C  add sp, 0xc
            L0053: AddEncounter(player, 0x01, 0x24);
            L0065: AddEncounter(player, 0x02, 0x23);
            L0077: AddEncounter(player, 0x03, 0x24);
            L0089: AddEncounter(player, 0x04, 0x23);
            L009B: Compare(PartyCount(player), 0x0002);
            L00A6: if (JumpBelowOrEqual) goto L00E8;
            L00A8: AddEncounter(player, 0x05, 0x24);
            L00BA: AddEncounter(player, 0x06, 0x23);
            L00CC: goto L00E8;
            L00CE: ShowMessage(player, String1AFF); // Reminders of your battle in this area still dog your footsteps.  Yuk.
            L00DB: ShowMessage(player, String1B45); // You've already taught those puppies the value of love.  Tough love.  Really really tough love.
            L00E8: return; // RETURN;
        }

        private void Fn_26(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x03);
            L0007: PushStack(player, ax);
0C74  0008 C4 5E 06  les bx, [bp+0x6]
0C77  000B 26 FF 5F 04  call far word [es:bx+0x4]
            L000F: cx = PopStack(player);
            L0010: cx = PopStack(player);
            L0011: RefreshCompareFlags(ax);
            L0013: if (JumpEqual) goto L0018;
            L0015: goto L00CE;
            L0018: PushStack(player, 0x01);
            L001C: PushStack(player, 0x03);
            L0020: PushStack(player, ax);
0C8D  0021 C4 5E 06  les bx, [bp+0x6]
0C90  0024 26 FF 1F  call far word [es:bx]
0C93  0027 83 C4 06  add sp, 0x6
            L002A: ShowMessage(player, String1AB5); // Have you ever heard of puppy love.  Well, these dogs haven't!  Watch out!
0CA3  0037 B8 C3 04  mov ax, 0x4c3
            L003A: PushStack(player, ax);
            L003B: PushStack(player, 0x00);
            L003E: PushStack(player, ax);
            L003F: PushStack(player, 0xBB);
            L0043: PushStack(player, 0xF3);
            L0047: PushStack(player, ax);
0CB4  0048 C4 5E 06  les bx, [bp+0x6]
0CB7  004B 26 FF 9F D8 00  call far word [es:bx+0xd8]
0CBC  0050 83 C4 0C  add sp, 0xc
            L0053: AddEncounter(player, 0x01, 0x25);
            L0065: AddEncounter(player, 0x02, 0x25);
            L0077: AddEncounter(player, 0x03, 0x25);
            L0089: AddEncounter(player, 0x04, 0x25);
            L009B: Compare(PartyCount(player), 0x0002);
            L00A6: if (JumpBelowOrEqual) goto L00E8;
            L00A8: AddEncounter(player, 0x05, 0x25);
            L00BA: AddEncounter(player, 0x06, 0x25);
            L00CC: goto L00E8;
            L00CE: ShowMessage(player, String1AFF); // Reminders of your battle in this area still dog your footsteps.  Yuk.
            L00DB: ShowMessage(player, String1B45); // You've already taught those puppies the value of love.  Tough love.  Really really tough love.
            L00E8: return; // RETURN;
        }

        private void Fn_27(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x04), 0x0001);
            L0017: if (JumpNotEqual) goto L0026;
            L0019: PushStack(player, GetFacing(player));
0D77  0021 B8 CC 00  mov ax, 0xcc
            L0024: goto L005B;
            L0026: ShowMessage(player, String1BA4); // You hear a lot of hissing through this door, as if a veritable snakepit.  You'd put on your hightop boots, if you had any.
            L0033: ax = HasItem(player, 0xF5);
            L0041: if (JumpEqual) goto L0050;
            L0043: PushStack(player, GetFacing(player));
0DA1  004B B8 DD 00  mov ax, 0xdd
            L004E: goto L005B;
            L0050: PushStack(player, GetFacing(player));
            L0058: PushStack(player, 0xEE);
            L005C: PushStack(player, 0x02);
            L0060: PushStack(player, 0x0B);
0DBA  0064 C4 5E 06  les bx, [bp+0x6]
0DBD  0067 26 FF 9F BC 00  call far word [es:bx+0xbc]
0DC2  006C 83 C4 08  add sp, 0x8
            L006F: return; // RETURN;
        }

        private void Fn_28(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x04));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00D4;
            L001B: SetFlag(player, 0x03, 0x04, 0x01);
            L0030: ShowMessage(player, String1C1F); // See!  High topped boots wouldn't have helped you anyways!
0E04  003D B8 C3 04  mov ax, 0x4c3
            L0040: PushStack(player, ax);
            L0041: PushStack(player, 0x00);
            L0044: PushStack(player, ax);
            L0045: PushStack(player, 0xBB);
            L0049: PushStack(player, 0xF5);
            L004D: PushStack(player, ax);
0E15  004E C4 5E 06  les bx, [bp+0x6]
0E18  0051 26 FF 9F D8 00  call far word [es:bx+0xd8]
0E1D  0056 83 C4 0C  add sp, 0xc
            L0059: AddEncounter(player, 0x01, 0x1A);
            L006B: AddEncounter(player, 0x02, 0x1B);
            L007D: AddEncounter(player, 0x03, 0x1A);
            L008F: AddEncounter(player, 0x04, 0x1B);
            L00A1: Compare(PartyCount(player), 0x0002);
            L00AC: if (JumpBelowOrEqual) goto L00EE;
            L00AE: AddEncounter(player, 0x05, 0x1A);
            L00C0: AddEncounter(player, 0x06, 0x1B);
            L00D2: goto L00EE;
            L00D4: ShowMessage(player, String1C59); // Boy, the snake skins sure got spattered everywhere.
            L00E1: ShowMessage(player, String1C8D); // Hmm.  You probably could get some high topped snake skin boots made, if you knew a cobbler.  But any cobblers left around here have already been eaten by the halflings.
            L00EE: return; // RETURN;
        }

        private void Fn_29(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x04));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00D4;
            L001B: SetFlag(player, 0x03, 0x04, 0x01);
            L0030: ShowMessage(player, String1C1F); // See!  High topped boots wouldn't have helped you anyways!
0EF4  003D B8 C3 04  mov ax, 0x4c3
            L0040: PushStack(player, ax);
            L0041: PushStack(player, 0x00);
            L0044: PushStack(player, ax);
            L0045: PushStack(player, 0xBB);
            L0049: PushStack(player, 0xF5);
            L004D: PushStack(player, ax);
0F05  004E C4 5E 06  les bx, [bp+0x6]
0F08  0051 26 FF 9F D8 00  call far word [es:bx+0xd8]
0F0D  0056 83 C4 0C  add sp, 0xc
            L0059: AddEncounter(player, 0x01, 0x1C);
            L006B: AddEncounter(player, 0x02, 0x1C);
            L007D: AddEncounter(player, 0x03, 0x1C);
            L008F: AddEncounter(player, 0x04, 0x1C);
            L00A1: Compare(PartyCount(player), 0x0002);
            L00AC: if (JumpBelowOrEqual) goto L00EE;
            L00AE: AddEncounter(player, 0x05, 0x1C);
            L00C0: AddEncounter(player, 0x06, 0x1C);
            L00D2: goto L00EE;
            L00D4: ShowMessage(player, String1C59); // Boy, the snake skins sure got spattered everywhere.
            L00E1: ShowMessage(player, String1C8D); // Hmm.  You probably could get some high topped snake skin boots made, if you knew a cobbler.  But any cobblers left around here have already been eaten by the halflings.
            L00EE: return; // RETURN;
        }

        private void Fn_2A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0027);
            L0010: RefreshCompareFlags(GetFlag(player, 0x03, 0x05));
            L0023: if (JumpEqual) goto L0028;
            L0025: goto L00C4;
            L0028: RefreshCompareFlags(GetFlag(player, 0x03, 0x0C));
            L003B: if (JumpNotEqual) goto L0072;
            L003D: SetFlag(player, 0x03, 0x0C, 0x01);
            L0052: ShowMessage(player, String1D36); // 'Look, friend, I've been told to keep everyone out of this room.  There are dragons in here, large violent firebreathing, uh....'
            L005F: ShowMessage(player, String1DB8); // His voice trails off as he hears your party mutter 'Cool!' 'About time!' 'Let's break some drake!' and other inappropriate epithets, combined with a loosening of your weapons.
1013  006C B8 68 1E  mov ax, 0x1e68
            L006F: goto L00F6;
            L0072: ShowMessage(player, String1ED7); // 'I am glad thou hast heeded my warning,' says the elf.
            L007F: RefreshCompareFlags(GetFlag(player, 0x03, 0x0D));
            L0092: if (JumpNotEqual) goto L0100;
            L0094: SetFlag(player, 0x03, 0x0D, 0x01);
            L00A9: ShowMessage(player, String1F0E); // 'And for thy wisdom, a small reward.'
105D  00B6 B8 E8 03  mov ax, 0x3e8
            L00B9: PushStack(player, ax);
1061  00BA C4 5E 06  les bx, [bp+0x6]
1064  00BD 26 FF 9F 94 00  call far word [es:bx+0x94]
            L00C2: goto L00FF;
            L00C4: RefreshCompareFlags(GetFlag(player, 0x03, 0x0C));
            L00D7: if (JumpNotEqual) goto L00F3;
            L00D9: SetFlag(player, 0x03, 0x0C, 0x01);
1095  00EE B8 34 1F  mov ax, 0x1f34
            L00F1: goto L00F6;
            L00F3: ShowMessage(player, String1FCB); // The elf shakes his head, sadly.
            L0100: return; // RETURN;
        }

        private void Fn_2B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x05), 0x0001);
            L0017: if (JumpNotEqual) goto L0026;
            L0019: PushStack(player, GetFacing(player));
10CA  0021 B8 A9 00  mov ax, 0xa9
            L0024: goto L005B;
            L0026: ShowMessage(player, String1FEB); // Naw.  It couldn't be.  But you'd swear that you heard some faint voices quietly chanting 'munchies' repeatedly.
            L0033: ax = HasItem(player, 0xF8);
            L0041: if (JumpEqual) goto L0050;
            L0043: PushStack(player, GetFacing(player));
10F4  004B B8 AA 00  mov ax, 0xaa
            L004E: goto L005B;
            L0050: PushStack(player, GetFacing(player));
            L0058: PushStack(player, 0xBB);
            L005C: PushStack(player, 0x02);
            L0060: PushStack(player, 0x0B);
110D  0064 C4 5E 06  les bx, [bp+0x6]
1110  0067 26 FF 9F BC 00  call far word [es:bx+0xbc]
1115  006C 83 C4 08  add sp, 0x8
            L006F: return; // RETURN;
        }

        private void Fn_2C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x05));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00D4;
            L001B: SetFlag(player, 0x03, 0x05, 0x01);
            L0030: ShowMessage(player, String205B); // Uh oh!  Why do you suddenly feel like a snack pack?
1157  003D B8 C3 04  mov ax, 0x4c3
            L0040: PushStack(player, ax);
            L0041: PushStack(player, 0x00);
            L0044: PushStack(player, ax);
            L0045: PushStack(player, 0xBB);
            L0049: PushStack(player, 0xF8);
            L004D: PushStack(player, ax);
1168  004E C4 5E 06  les bx, [bp+0x6]
116B  0051 26 FF 9F D8 00  call far word [es:bx+0xd8]
1170  0056 83 C4 0C  add sp, 0xc
            L0059: AddEncounter(player, 0x01, 0x1D);
            L006B: AddEncounter(player, 0x02, 0x1E);
            L007D: AddEncounter(player, 0x03, 0x1D);
            L008F: AddEncounter(player, 0x04, 0x1E);
            L00A1: Compare(PartyCount(player), 0x0002);
            L00AC: if (JumpBelowOrEqual) goto L00EE;
            L00AE: AddEncounter(player, 0x05, 0x1D);
            L00C0: AddEncounter(player, 0x06, 0x1E);
            L00D2: goto L00EE;
            L00D4: ShowMessage(player, String208F); // You see some spattered pieces of dragon.
            L00E1: ShowMessage(player, String20B8); // I guess sometimes the snackees win!
            L00EE: return; // RETURN;
        }

        private void Fn_2D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x05));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00D4;
            L001B: SetFlag(player, 0x03, 0x05, 0x01);
            L0030: ShowMessage(player, String205B); // Uh oh!  Why do you suddenly feel like a snack pack?
1247  003D B8 C3 04  mov ax, 0x4c3
            L0040: PushStack(player, ax);
            L0041: PushStack(player, 0x00);
            L0044: PushStack(player, ax);
            L0045: PushStack(player, 0xBB);
            L0049: PushStack(player, 0xF8);
            L004D: PushStack(player, ax);
1258  004E C4 5E 06  les bx, [bp+0x6]
125B  0051 26 FF 9F D8 00  call far word [es:bx+0xd8]
1260  0056 83 C4 0C  add sp, 0xc
            L0059: AddEncounter(player, 0x01, 0x1F);
            L006B: AddEncounter(player, 0x02, 0x1F);
            L007D: AddEncounter(player, 0x03, 0x1F);
            L008F: AddEncounter(player, 0x04, 0x1F);
            L00A1: Compare(PartyCount(player), 0x0002);
            L00AC: if (JumpBelowOrEqual) goto L00EE;
            L00AE: AddEncounter(player, 0x05, 0x1F);
            L00C0: AddEncounter(player, 0x06, 0x1F);
            L00D2: goto L00EE;
            L00D4: ShowMessage(player, String208F); // You see some spattered pieces of dragon.
            L00E1: ShowMessage(player, String20B8); // I guess sometimes the snackees win!
            L00EE: return; // RETURN;
        }

        private void Fn_2E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0027);
            L0010: RefreshCompareFlags(GetFlag(player, 0x03, 0x06));
            L0023: if (JumpNotEqual) goto L0080;
            L0025: RefreshCompareFlags(GetFlag(player, 0x03, 0x0E));
            L0038: if (JumpNotEqual) goto L007B;
            L003A: SetFlag(player, 0x03, 0x0E, 0x01);
            L004F: ShowMessage(player, String20DC); // The elf looks you very seriously in the eye.
            L005C: ShowMessage(player, String2109); // 'Some battles cannot be won,' he says.  'An thou dost enter here, it is upon thy head.'
            L0069: ShowMessage(player, String2161); // 'There are not just drakes within, but they are equipped with the most puissant weapons of the old magics, weapons designed to destroy armies.'
1370  0076 B8 F1 21  mov ax, 0x21f1
            L0079: goto L00B2;
1375  007B B8 54 22  mov ax, 0x2254
            L007E: goto L00B2;
            L0080: RefreshCompareFlags(GetFlag(player, 0x03, 0x0E));
            L0093: if (JumpNotEqual) goto L00AF;
            L0095: SetFlag(player, 0x03, 0x0C, 0x01);
13A4  00AA B8 7B 22  mov ax, 0x227b
            L00AD: goto L00B2;
            L00AF: ShowMessage(player, String1FCB); // The elf shakes his head, sadly.
            L00BC: return; // RETURN;
        }

        private void Fn_2F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x06));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00EB;
            L001B: ax = GetMaxHits(player);
            L0022: bx = 0x0002;
            L0025: dx = ax % bx; ax = ax / bx;
            L0028: DamagePlayer(player, ax);
            L0032: AddMana(player, 0xEC79);
            L003F: SetFlag(player, 0x03, 0x06, 0x01);
            L0054: ShowMessage(player, String22E3); // Hmm.  Could the sudden wave of fatigue be being hit by 'nasties' or is it just the realization that there are a whole lot of dragons in front of you?
1419  0061 B8 C3 04  mov ax, 0x4c3
            L0064: PushStack(player, ax);
            L0065: PushStack(player, 0x00);
            L0068: PushStack(player, ax);
            L0069: PushStack(player, 0xBB);
            L006D: PushStack(player, 0xF8);
            L0071: PushStack(player, ax);
142A  0072 C4 5E 06  les bx, [bp+0x6]
142D  0075 26 FF 9F D8 00  call far word [es:bx+0xd8]
1432  007A 83 C4 0C  add sp, 0xc
            L007D: AddEncounter(player, 0x01, 0x1F);
            L008F: AddEncounter(player, 0x02, 0x1F);
            L00A1: AddEncounter(player, 0x03, 0x1F);
            L00B3: AddEncounter(player, 0x04, 0x1F);
            L00C5: AddEncounter(player, 0x05, 0x1F);
            L00D7: AddEncounter(player, 0x06, 0x1F);
            L00E9: goto L00F8;
            L00EB: ShowMessage(player, String2379); // Well, you're just as happy not to have to go through that all over again.  Dragons are bad enough, but setting them up with 'nasties' for an ambush was too much.
            L00F8: return; // RETURN;
        }

        private void Fn_30(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x0F));
            L0016: if (JumpNotEqual) goto L0032;
            L0018: SetFlag(player, 0x03, 0x0F, 0x01);
14DF  002D B8 1B 24  mov ax, 0x241b
            L0030: goto L0035;
            L0032: ShowMessage(player, String24A7); // There are many useless sharp pointy things here.  Useless to you, anyways.
            L003F: return; // RETURN;
        }

        private void Fn_31(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x10));
            L0016: if (JumpNotEqual) goto L003F;
            L0018: SetFlag(player, 0x03, 0x10, 0x01);
            L002D: ShowMessage(player, String24F2); // If you intended to pick a quarry, you've come to the right place.  It's a shame that they were all designed for catapults.  Besides, your backpack is only rated for 200 pounds.
152D  003A B8 A3 25  mov ax, 0x25a3
            L003D: goto L0042;
            L003F: ShowMessage(player, String260E); // There are many useless round hard things here.  Useless to you, anyways.
            L004C: return; // RETURN;
        }

        private void Fn_32(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x11));
            L0016: if (JumpNotEqual) goto L0032;
            L0018: SetFlag(player, 0x03, 0x11, 0x01);
156E  002D B8 57 26  mov ax, 0x2657
            L0030: goto L0035;
            L0032: ShowMessage(player, String26F5); // If you ever need oil, tar, or pitch, you know where to get some.
            L003F: return; // RETURN;
        }

        private void Fn_33(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x12));
            L0016: if (JumpNotEqual) goto L003F;
            L0018: SetFlag(player, 0x03, 0x12, 0x01);
            L002D: ShowMessage(player, String2736); // Okay.  The place reeks.  Your head hurts, and you're not sure of your ability to cast spells.
15BC  003A B8 94 27  mov ax, 0x2794
            L003D: goto L0042;
            L003F: ShowMessage(player, String260E); // There are many useless round hard things here.  Useless to you, anyways.
            L004C: ax = GetMaxHits(player);
            L0053: bx = 0x0003;
            L0056: dx = ax % bx; ax = ax / bx;
            L0059: DamagePlayer(player, ax);
            L0063: AddMana(player, 0xF830);
            L0070: return; // RETURN;
        }

        private void Fn_34(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
15F7  0003 C4 5E 06  les bx, [bp+0x6]
15FA  0006 26 FF 5F 40  call far word [es:bx+0x40]
            L000A: DamagePlayer(player, 0x05A4);
            L0017: ShowMessage(player, String27C4); // This is a nasty place.
            L0024: return; // RETURN;
        }

        private void Fn_35(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddMana(player, 0xFA5C);
            L0010: ShowMessage(player, String27C4); // This is a nasty place.
            L001D: return; // RETURN;
        }

        private void Fn_36(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
163C  0003 C4 5E 06  les bx, [bp+0x6]
163F  0006 26 FF 9F C8 00  call far word [es:bx+0xc8]
            L000B: DamagePlayer(player, 0x05A4);
            L0018: ShowMessage(player, String27C4); // This is a nasty place.
            L0025: return; // RETURN;
        }

        private void Fn_37(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetNoHealZone(player);
166B  000B C4 5E 06  les bx, [bp+0x6]
166E  000E 26 FF 9F C8 00  call far word [es:bx+0xc8]
1673  0013 C4 5E 06  les bx, [bp+0x6]
1676  0016 26 FF 5F 40  call far word [es:bx+0x40]
            L001A: DamagePlayer(player, 0x0A6B);
            L0027: AddMana(player, 0xFA5C);
            L0034: Compare(GetFacing(player), 0x0002);
            L003E: if (JumpNotEqual) goto L0045;
16A0  0040 B8 03 00  mov ax, 0x3
            L0043: goto L0065;
            L0045: Compare(GetFacing(player), 0x0003);
            L004F: if (JumpNotEqual) goto L0056;
16B1  0051 B8 01 00  mov ax, 0x1
            L0054: goto L0065;
            L0056: Compare(GetFacing(player), 0x0001);
            L0060: if (JumpNotEqual) goto L006F;
            L0062: PushStack(player, 0x02);
16C6  0066 C4 5E 06  les bx, [bp+0x6]
16C9  0069 26 FF 9F CC 00  call far word [es:bx+0xcc]
            L006E: cx = PopStack(player);
            L006F: ShowMessage(player, String27DB); // This is a very nasty place.
            L007C: return; // RETURN;
        }

        private void Fn_38(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x01), 0x0001);
            L0017: if (JumpNotEqual) goto L0026;
            L0019: ShowMessage(player, String17E5); // Your epic struggle with the bovine goats left goatees scattered all over the place (heh heh).
            L0026: return; // RETURN;
        }

        private void Fn_39(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x04), 0x0001);
            L0017: if (JumpNotEqual) goto L0033;
            L0019: ShowMessage(player, String1C59); // Boy, the snake skins sure got spattered everywhere.
            L0026: ShowMessage(player, String1C93);
            L0033: return; // RETURN;
        }

        private void Fn_3A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x05), 0x0001);
            L0017: if (JumpNotEqual) goto L0033;
            L0019: ShowMessage(player, String208F); // You see some spattered pieces of dragon.
            L0026: ShowMessage(player, String20B8); // I guess sometimes the snackees win!
            L0033: return; // RETURN;
        }

        private void Fn_3B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x03);
            L0007: PushStack(player, ax);
1778  0008 C4 5E 06  les bx, [bp+0x6]
177B  000B 26 FF 5F 04  call far word [es:bx+0x4]
            L000F: cx = PopStack(player);
            L0010: cx = PopStack(player);
            L0011: Compare(ax, 0x0001);
            L0014: if (JumpNotEqual) goto L0030;
            L0016: ShowMessage(player, String1AFF); // Reminders of your battle in this area still dog your footsteps.  Yuk.
            L0023: ShowMessage(player, String1B45); // You've already taught those puppies the value of love.  Tough love.  Really really tough love.
            L0030: return; // RETURN;
        }

        private void Fn_3C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x02), 0x0001);
            L0017: if (JumpNotEqual) goto L0033;
            L0019: ShowMessage(player, String1943); // You find the signs of your battle with the wolves all over this area.
            L0026: ShowMessage(player, String1989); // You've already performed all the dentistry possible here, with complete disregard for the wolf's place on the endangered species list.
            L0033: return; // RETURN;
        }

    }
}
