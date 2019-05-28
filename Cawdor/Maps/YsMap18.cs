#pragma warning disable
using System.Collections.Generic;
using XPT.WorldData;
using XPT.WorldData.Yserbius;

namespace XPT.Scripts.Yserbius.Maps {
    class YserMap18 : AMapScripted {
        protected override int MapIndex => 18;
        protected override int RandomEncounterChance => 10;
        protected override int RandomEncounterExtraCount => 1;

        public YserMap18() {
            MapEvent01 = Fn_01;
            MapEvent02 = Fn_02;
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
            MapEvent33 = Fn_33;
            MapEvent34 = Fn_34;
            MapEvent35 = Fn_35;
            MapEvent36 = Fn_36;
        }
        
        // === Strings ================================================
        private const string String0140 = "How many treasures do you expect to find in a garbage heap?  I mean, if you get the reputation as the kind of adventurer who thinks garbage is treasure you can count on a lot fewer free drinks in the Rampant Cat Inn, I am sure.";
        private const string String0224 = "Duck!";
        private const string String022A = "Well, you probably wouldn't have ducked if I'd said 'Sticks!'  In any case, a set of spring propelled sticks came flying out of this hidden closet to land to the west.";
        private const string String02D2 = "It was a garbage heap when you walked in, and it will be a garbage heap after you walk out.";
        private const string String032E = "How useful!  'Tis a set of Alcuin's Sticks. But consider the moral implications.  Someone left these sticks here for an emergency, spring loaded for immediate grasping and usage.";
        private const string String03E1 = "If you take them, you could be responsible for their owners' death!";
        private const string String0425 = "This slows you down for about 0.2 seconds.  Knowing Cawdor as you do by now, the original owner is probably long dead!";
        private const string String049C = "You find some tracks indicating that something headed off this way.";
        private const string String04E0 = "You hear some footsteps running away.";
        private const string String0506 = "You hear someone ambling towards you.";
        private const string String052C = "'By the sun and the moon, what kind of lunatic designed this place?  Everything is small doors and, struggle though I will, I lack all notion of how to find the lair of Banquo's ghost.  Canst thou help me?'";
        private const string String05FB = "You tell her the entrance to Banquo's lair is in the northwest corner of the Kitchen.  She thanks you graciously and departs.";
        private const string String0679 = "You shrug, not knowing where to find Banquo's ghost yourself.";
        private const string String06B7 = "'Alas.  It is no more than I expected,' she says.";
        private const string String06E9 = "'I say, chaps, be a good fellow and point me in the direction of the kitchen.  My cousins Carmen and Darryl said that there is an infinitude of food there, but I've been wandering this trackless place for hours trying to find it!'";
        private const string String07D0 = "You suggest that the dragon strive ever southeastward, comforted by the knowledge that you won't have to be in the kitchen when the dragon arrives there.";
        private const string String086A = "It was just like Rory to chase Banquo's ghost into a pit, wasn't it.  At least his warning was timely, even though his death was not.";
        private const string String08F0 = "Rory is limping somewhat.";
        private const string String090A = "Well met!  I must say, there are many advantages to being discorporeal.";
        private const string String0952 = "I chased Banquo's ghost straight into his hidey hole, but whereas he floated down and flew off, I fell like a, well, like a halfling, and turned my ankle, preventing my pursuit. ";
        private const string String0A05 = "It's back to the kitchen for me, if I can just find it!";
        private const string String0A3D = "A bunch of barbarians decides that - no, it's impossible to know why barbarians choose to do anything.  Be that as it may, they are choosing to attack you.";
        private const string String0AD9 = "A cold breeze sends shivers down your spine.";
        private const string String0B06 = "Psst!  Cuz.  Pay little attention to that old fool.  Thou art here for the loot.  I can give thee some advice.  Herein thou mayst find Fleance's Flail, Oswy's Javelin, the Camlunn Crossbow, Edwin's Defender, the Phrygian Cap, and Aldhelm's Harp and Gauntlets.";
        private const string String0C0A = "Where?  What beings guard them?  Why, an I knew that, I could take them for myself.  Why am I telling thee this?  Could it be the gold pieces I lifted from thy purse, cuz?  Anon!'";
        private const string String0CBE = "He scampers off.";
        private const string String0CCF = "Hah!  You got them before their ambush was ready!";
        private const string String0D01 = "Oh dear.  Perhaps you could do something to prevent every group of monsters you meet from ambushing you.";
        private const string String0D6A = "No signs remain of your battle here save for a discarded mallet and a slightly singed magic wand.";
        private const string String0DCC = "This cabinet is empty.";
        private const string String0DE3 = "There is Banquo's Ghost.  Get him while he's hot!";
        private const string String0E15 = "That was quite a host Banquo had.  It was a good thing that you were up to his brand of 'hospitality.'";
        private const string String0E7C = "Ouch!  The ambush is bad enough, but Banquo's Ghost is shaking his gory locks at you.  Have at him!";
        private const string String0EE0 = "Judging from the ambush he had arranged, it was a good thing you caught Banquo unawares.  If that was fighting him unawares, you most definitely did not want to fight him prepared.";
        private const string String0F95 = "You realize now that the horridly debilitating effects of the Dissolving Pool were what prevented you from reacting swiftly enough to avoid this ambush.  Next time - ah, who wants to fight Banquo again?";
        private const string String1060 = "This must have been Banquo's escape route.  It's a good thing you didn't give him the chance to use it.  But from the sharp spikes you're encountering as you fall, it's a bad thing you are using it now!";
        private const string String112B = "'Hmmph.  Adventurers!  Ah, well.  The Wizard's Guild has thoroughly investigated this room.  An thou hast not yet faced Banquo's ghost, thou shalt not do so from here.";
        private const string String11D3 = "There are many private lockers here, some well and thoroughly trapped, so burgle at thy own risk.";
        private const string String1235 = "The door to the Kitchen is on the south wall near the east wall, and the door to the Conservatory is on the east wall nearer the south wall than the north, but more towards the middle.  Now be off with thee!";
        private const string String1305 = "Three halflings, two of whom look badly wounded and in serious need of a smithy, hold the door open for you.";
        private const string String1372 = "'Go on in, go on in,' they say.  'But do not travel this path in ignorance.  There are more fiercesome beasts within than yet we have encountered, and lacking the wherewithal to withstand the Dissolving Pool we were forced to flee Banquo's unknightly assault.";
        private const string String1476 = "Mayhaps thou wilt receive better fortune than we had, cousin.";
        private const string String14B4 = "Struggle though you will, you are unable to open the door that leads to the Kitchen.";
        private const string String1509 = "Three halflings catch the door before it closes.";
        private const string String153A = "'Well met!  There are enough undead in there for all of us, and some giants and dragons as well.  May providence smile upon thy works.'";
        private const string String15C2 = "The door to the Conservatory refuses to budge.";
        private const string String15F1 = "I guess this large cabinet is empty.";
        private const string String1616 = "All that you find in this cabinet is a punctured peruke.";
        private const string String164F = "All that you find in this cabinet are some barbarian's unmentionables.  And believe you me, the way they smell is unmentionable.  This is a family network, you know!";
        private const string String16F5 = "Some imps must have been living here, because you find a broken pitchfork.  It has some magical engraving on it, but the piece you have left is too incomplete to decipher.";
        private const string String17A1 = "You find a scrap of parchment.  It reads, 'Ware the Haggis of Horror, for it is to be feared above all the other slimes.  It can dissolve - oh no!  It can dissolve me!'";
        private const string String184A = "Evidently the writer of this parchment was dissatisfied with the conclusion of his investigations.";
        private const string String18AD = "You find a soiled toga with the runes for the letters 'K' and 'D' on its back.";
        private const string String18FC = "This room must be the garbage dump for this level.  There are more broken things in here than you can shake a stick at.  In fact, shaking a stick at them is probably what broke most of them!";
        private const string String19BB = "Evidently a bunch of bats made this their lair for a while, but you don't guano know how you can tell.";
        private const string String1A22 = "Uggh!  A herd of pigs must have been living here, and the smell's enough to drop a rhino in its tracks!  You barely make it to the door.";
        private const string String1AAB = "You find some old celtic symbols scrawled upon a wall, but they are too faded to decipher.";
        private const string String1B06 = "A ratty piece of cloth is draped on the north wall.";
        private const string String1B3A = "Woe is me!  My parents visited Cawdor Castle and got eaten by a dragon, and all I inherited was this crummy old tunic.";
        private const string String1BB1 = "That pile of cloth in the corner is either some leftovers from a mummy, some discarded bandages, or some red handkerchiefs.  You decide that you really don't want to know which.";
        private const string String1C63 = "You find the remains of a halfling, with a crude note pinned to his chest.  It reads, 'He stole the silverware.";
        private const string String1CD3 = "Great Bats o'Fire!  Those bats are breathing flames!  'Tis a shame they appear to have no taste for roast pork.";
        private const string String1D43 = "You are still a tad puzzled that that razorback was able to fight so well with Oswy's Javelin stuck in him.  But you're also greatful that the guardians of that javelin were not able to wield it against you.";
        private const string String1E13 = "You find a scorched rabbit's foot.  You know, if it wasn't lucky for the rabbit, why would it be lucky for anyone else?";
        private const string String1E8B = "You find a holey shield.  No, I don't mean sanctified.";
        private const string String1EC2 = "A rift appears in the fabric of space and time, and, with corruscating effects too spectacular for this game's budget, a man appears.";
        private const string String1F48 = "He says, 'I'm Jimmy Hoffa.  So, like, they got Teamsters here?'  You suggest he try the Cat Dragged Inn one level down.  'Tanks,' he says, tipping you a worthless piece of green paper for your troubles.  He departs.";
        private const string String2020 = "You find a worthless piece of green paper with indecipherable runes on it.  You decide to leave it here to confuse you the next time you come here.";
        private const string String20B4 = "I'd try and describe the moldy pile of dragon droppings you find here, but the English language doesn't have the right words.  If only you spoke bloodhound.";
        private const string String2151 = "You think about retrieving the broken shovel you left behind, but decide wisely that it's not your job.";
        private const string String21B9 = "You find a discarded potion bottle.  Fortunately, you don't know of any conceivable use for Eau d'Troll, so you wisely leave it behind.";
        private const string String2241 = "You find a few harpy feathers.  They might be worth something if only you could force yourself to pick them up.";
        private const string String22B1 = "You find a broken shield.";
        private const string String22CB = "You find a nice bunch of flowers arranged nicely in a vase.";
        private const string String2307 = "You find a scrap of paper.  It has a picture of the Mongol hordes on the front, and on the back is written, 'I visited Ulan Bator and was tortured by Genghis Khan.  Wish you were here.  Wish I wasn't!'";
        private const string String23D1 = "You find a scrap of paper offering you a ten percent discount on having your scales polished at Smaug's Buff and Wax.  Lo, how the mighty have fallen.";
        private const string String2468 = "You find the worn nub of a candle.";
        private const string String248B = "Uh oh!  These guys can and are using Camlunn's crossbow, because that's a quarrel sticking out of you!";
        private const string String24F2 = "Those thieves proved rather quarrelsome, but you managed to prevail.";
        private const string String2537 = "What?  You expected every pun to be a gem?  Try Quest for Glory I VGA if that's what you want.";
        private const string String2596 = "Yikes!  Those imps and picts are prepared!";
        private const string String25C1 = "Strike another blow for moving cautiously!  Because you spotted their tracks, they couldn't spring that ambush on you!";
        private const string String2638 = "You went to all this trouble fighting imps and picts and gosh all, and you can't use this stupid shield after all, even if your name was Edwin.";
        private const string String26C8 = "Hey!  This Edwin's defender is one snazzy shield!  It's almost enough to make up for the fact that now everyone calls you Edwin!";
        private const string String2749 = "You must have found the guardians of the Phrygian Caps, because those elves are wearing them!";
        private const string String27A7 = "All that remains of your battle here is a broken noseguard.";
        private const string String27E3 = "Yes, these are the folks with Aldhelm's Harp.  You can tell because they are using it to lob fireballs at you!";
        private const string String2852 = "You've heard many a bard play sweet music, but the fireballs from Aldhelm's Harp that you won here sizzle with a sweet sound all their own.";
        private const string String28DE = "You find several empty wineskins and, scrawled on the wall, the words, 'Oberon's a real fairy.'";
        private const string String293E = "You find a scrap of paper reading, 'Fine fresh firewood, only a farthing for a firtle of faggots.  See S. Stump at the Greenbriar Market.";
        private const string String29C8 = "You find some old rocks.  Or maybe it's dwarven waybread.  The two are generally interchangeable.";
        private const string String2A2A = "Ah, the flotsam and jetsam of a thousand worlds could have drifted the tides of time and space to wind up here.  But didn't.";
        private const string String2AA7 = "You find a broken shovel.";
        private const string String2AC1 = "You think about using it on the dragon droppings, but wisely decide that it's not your job.";
        private const string String2B1D = "You find a broken bhodhron.  Alas, 'twill beat no more.";
        private const string String2B55 = "You find some discarded bagpipes.  In a fit of incredible wisdom, you decide not to fiddle with them.  Either they wouldn't play, which would be bad, or they would play, which would be worse.";
        private const string String2C15 = "There's something so delightful about liberating someone's ill-gotten booty.  You assume any ghost's booty is going to be ill-gotten.";
        
        // === Functions ================================================
        private void Fn_01(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0x36), 0x0001);
            L0017: if (JumpNotEqual) goto L001F;
0024  0019 B8 40 01  mov ax, 0x140
            L001C: goto L00CD;
            L001F: Compare(HasUsedSkill(player, 0x0D), 0x0009);
            L002E: if (JumpNotBelow) goto L0088;
            L0030: RefreshCompareFlags(HasUsedSpell(player, 0x17));
            L003E: if (JumpNotEqual) goto L0088;
            L0040: PushStack(player, 0x67);
            L0044: PushStack(player, ax);
0050  0045 C4 5E 06  les bx, [bp+0x6]
0053  0048 26 FF 5F 54  call far word [es:bx+0x54]
            L004C: cx = PopStack(player);
            L004D: cx = PopStack(player);
            L004E: RefreshCompareFlags(ax);
            L0050: if (JumpNotEqual) goto L0088;
            L0052: PushStack(player, 0x61);
            L0056: PushStack(player, ax);
0062  0057 C4 5E 06  les bx, [bp+0x6]
0065  005A 26 FF 5F 54  call far word [es:bx+0x54]
            L005E: cx = PopStack(player);
            L005F: cx = PopStack(player);
            L0060: RefreshCompareFlags(ax);
            L0062: if (JumpNotEqual) goto L0088;
            L0064: PushStack(player, 0x93);
            L0068: PushStack(player, ax);
0074  0069 C4 5E 06  les bx, [bp+0x6]
0077  006C 26 FF 5F 54  call far word [es:bx+0x54]
            L0070: cx = PopStack(player);
            L0071: cx = PopStack(player);
            L0072: RefreshCompareFlags(ax);
            L0074: if (JumpNotEqual) goto L0088;
            L0076: PushStack(player, 0x86);
            L007A: PushStack(player, ax);
0086  007B C4 5E 06  les bx, [bp+0x6]
0089  007E 26 FF 5F 54  call far word [es:bx+0x54]
            L0082: cx = PopStack(player);
            L0083: cx = PopStack(player);
            L0084: RefreshCompareFlags(ax);
            L0086: if (JumpEqual) goto L00CA;
            L0088: ShowMessage(player, String0224); // Duck!
            L0095: ShowMessage(player, String022A); // Well, you probably wouldn't have ducked if I'd said 'Sticks!'  In any case, a set of spring propelled sticks came flying out of this hidden closet to land to the west.
            L00A2: SetFlag(player, 0x03, 0x12, 0x01);
            L00B7: AddExperience(player, 0x00002710);
            L00C8: goto L00D7;
            L00CA: ShowMessage(player, String02D2); // It was a garbage heap when you walked in, and it will be a garbage heap after you walk out.
            L00D7: return; // RETURN;
        }

        private void Fn_02(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x12), 0x0001);
            L0017: if (JumpNotEqual) goto L0060;
            L0019: SetFlag(player, 0x03, 0x12, 0x00);
            L002D: ShowMessage(player, String032E); // How useful!  'Tis a set of Alcuin's Sticks. But consider the moral implications.  Someone left these sticks here for an emergency, spring loaded for immediate grasping and usage.
            L003A: ShowMessage(player, String03E1); // If you take them, you could be responsible for their owners' death!
            L0047: ShowMessage(player, String0425); // This slows you down for about 0.2 seconds.  Knowing Cawdor as you do by now, the original owner is probably long dead!
            L0054: GiveItem(player, 0x86);
            L0060: return; // RETURN;
        }

        private void Fn_04(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, 0x0B), 0x0009);
            L0012: if (JumpNotBelow) goto L0038;
            L0014: PushStack(player, 0x62);
            L0018: PushStack(player, ax);
0164  0019 C4 5E 06  les bx, [bp+0x6]
0167  001C 26 FF 5F 54  call far word [es:bx+0x54]
            L0020: cx = PopStack(player);
            L0021: cx = PopStack(player);
            L0022: RefreshCompareFlags(ax);
            L0024: if (JumpNotEqual) goto L0038;
            L0026: PushStack(player, 0x8F);
            L002A: PushStack(player, ax);
0176  002B C4 5E 06  les bx, [bp+0x6]
0179  002E 26 FF 5F 54  call far word [es:bx+0x54]
            L0032: cx = PopStack(player);
            L0033: cx = PopStack(player);
            L0034: RefreshCompareFlags(ax);
            L0036: if (JumpEqual) goto L005A;
            L0038: ShowMessage(player, String049C); // You find some tracks indicating that something headed off this way.
            L0045: SetFlag(player, 0x03, 0x09, 0x01);
            L005A: return; // RETURN;
        }

        private void Fn_05(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si, di);
            L0005: di = 0;
            L0007: si = 0;
            L0009: ax = GetFlag(player, 0x03, 0x08);
01C1  001A 8B F8  mov di, ax
01C3  001C 47     inc di
01C4  001D 8B F7  mov si, di
            L001F: Compare(si, 0x13);
            L0022: if (JumpLessOrEqual) goto L002B;
01CB  0024 8B C6  mov ax, si
            L0026: si = ax + 0xFFEC;
            L002B: Compare(si, 0x0E);
            L002E: if (JumpLessOrEqual) goto L0037;
01D7  0030 8B C6  mov ax, si
            L0032: si = ax + 0xFFF1;
            L0037: Compare(si, 0x09);
            L003A: if (JumpLessOrEqual) goto L0043;
01E3  003C 8B C6  mov ax, si
            L003E: si = ax + 0xFFF6;
            L0043: Compare(si, 0x04);
            L0046: if (JumpLessOrEqual) goto L004F;
01EF  0048 8B C6  mov ax, si
            L004A: si = ax + 0xFFFB;
01F6  004F 0B F6  or si, si
01F8  0051 7D 02  jge 0x55
            L0053: si = 0;
            L0055: Compare(si, 0x1D);
            L0058: if (JumpLessOrEqual) goto L005C;
            L005A: si = 0;
0203  005C 83 FF 1E  cmp di, 0x1e
            L005F: if (JumpLessOrEqual) goto L0063;
            L0061: di = 0;
020A  0063 57     push di
            L0064: PushStack(player, 0x08);
            L0068: PushStack(player, 0x03);
0213  006C C4 5E 06  les bx, [bp+0x6]
0216  006F 26 FF 1F  call far word [es:bx]
0219  0072 83 C4 06  add sp, 0x6
021C  0075 83 FF 1A  cmp di, 0x1a
            L0078: if (JumpNotEqual) goto L007F;
0221  007A B8 01 00  mov ax, 0x1
            L007D: goto L0081;
            L007F: PushStack(player, 0x00);
0229  0082 83 FF 14  cmp di, 0x14
            L0085: if (JumpNotEqual) goto L008C;
022E  0087 B8 01 00  mov ax, 0x1
            L008A: goto L008E;
0233  008C 33 C0  xor ax, ax
            L008E: dx = PopStack(player);
0236  008F 0B D0  or dx, ax
            L0091: PushStack(player, dx);
0239  0092 83 FF 0E  cmp di, 0xe
            L0095: if (JumpNotEqual) goto L009C;
023E  0097 B8 01 00  mov ax, 0x1
            L009A: goto L009E;
0243  009C 33 C0  xor ax, ax
            L009E: dx = PopStack(player);
0246  009F 0B D0  or dx, ax
            L00A1: PushStack(player, dx);
0249  00A2 83 FF 08  cmp di, 0x8
            L00A5: if (JumpNotEqual) goto L00AC;
024E  00A7 B8 01 00  mov ax, 0x1
            L00AA: goto L00AE;
0253  00AC 33 C0  xor ax, ax
            L00AE: dx = PopStack(player);
0256  00AF 0B D0  or dx, ax
            L00B1: PushStack(player, dx);
0259  00B2 83 FF 02  cmp di, 0x2
            L00B5: if (JumpNotEqual) goto L00BC;
025E  00B7 B8 01 00  mov ax, 0x1
            L00BA: goto L00BE;
0263  00BC 33 C0  xor ax, ax
            L00BE: dx = PopStack(player);
0266  00BF 0B D0  or dx, ax
            L00C1: if (JumpNotEqual) goto L00C6;
            L00C3: goto L024B;
            L00C6: bx = si;
            L00C8: Compare(bx, 0x04);
            L00CB: if (JumpBelowOrEqual) goto L00D0;
            L00CD: goto L024B;
            L00D0: switch (bx) {
                case 0:
                    goto L00D7;
                case 1:
                    goto L00E7;
                case 2:
                    goto L013B;
                case 3:
                    goto L015A;
                case 4:
                    goto L01B0;
            }
            L00D7: ShowMessage(player, String04E0); // You hear some footsteps running away.
            L00E4: goto L024B;
            L00E7: ShowMessage(player, String0506); // You hear someone ambling towards you.
            L00F4: ShowPortrait(player, 0x001D);
            L0101: ShowMessage(player, String052C); // 'By the sun and the moon, what kind of lunatic designed this place?  Everything is small doors and, struggle though I will, I lack all notion of how to find the lair of Banquo's ghost.  Canst thou help me?'
            L010E: Compare(GetFlag(player, 0x02, 0x29), 0x0001);
            L0122: if (JumpNotEqual) goto L0129;
02CB  0124 B8 FB 05  mov ax, 0x5fb
            L0127: goto L00DA;
            L0129: ShowMessage(player, String0679); // You shrug, not knowing where to find Banquo's ghost yourself.
02DD  0136 B8 B7 06  mov ax, 0x6b7
            L0139: goto L00DA;
            L013B: ShowPortrait(player, 0x000E);
            L0148: ShowMessage(player, String06E9); // 'I say, chaps, be a good fellow and point me in the direction of the kitchen.  My cousins Carmen and Darryl said that there is an infinitude of food there, but I've been wandering this trackless place for hours trying to find it!'
02FC  0155 B8 D0 07  mov ax, 0x7d0
            L0158: goto L00DA;
            L015A: Compare(GetFlag(player, 0x02, 0x47), 0x0001);
            L016E: if (JumpNotEqual) goto L0176;
0317  0170 B8 6A 08  mov ax, 0x86a
            L0173: goto L00DA;
            L0176: ShowPortrait(player, 0x0025);
            L0183: ShowMessage(player, String08F0); // Rory is limping somewhat.
            L0190: ShowMessage(player, String090A); // Well met!  I must say, there are many advantages to being discorporeal.
            L019D: ShowMessage(player, String0952); // I chased Banquo's ghost straight into his hidey hole, but whereas he floated down and flew off, I fell like a, well, like a halfling, and turned my ankle, preventing my pursuit. 
0351  01AA B8 05 0A  mov ax, 0xa05
            L01AD: goto L00DA;
            L01B0: ShowPortrait(player, 0x0017);
            L01BD: ShowMessage(player, String0A3D); // A bunch of barbarians decides that - no, it's impossible to know why barbarians choose to do anything.  Be that as it may, they are choosing to attack you.
0371  01CA B8 89 01  mov ax, 0x189
            L01CD: PushStack(player, ax);
            L01CE: PushStack(player, 0x00);
            L01D1: PushStack(player, ax);
            L01D2: PushStack(player, 0x20);
            L01D6: PushStack(player, 0xB0);
            L01DA: PushStack(player, 0xBE);
0385  01DE C4 5E 06  les bx, [bp+0x6]
0388  01E1 26 FF 9F D8 00  call far word [es:bx+0xd8]
038D  01E6 83 C4 0C  add sp, 0xc
            L01E9: AddEncounter(player, 0x01, 0x19);
            L01FB: Compare(PartyCount(player), 0x0001);
            L0206: if (JumpBelowOrEqual) goto L021A;
            L0208: AddEncounter(player, 0x05, 0x1A);
            L021A: Compare(PartyCount(player), 0x0002);
            L0225: if (JumpBelowOrEqual) goto L024B;
            L0227: AddEncounter(player, 0x02, 0x1B);
            L0239: AddEncounter(player, 0x06, 0x1B);
            L024B: return; // RETURN (restoring si, di);
        }

        private void Fn_06(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0AD9); // A cold breeze sends shivers down your spine.
            L0010: return; // RETURN;
        }

        private void Fn_07(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x03);
0419  0007 C4 5E 06  les bx, [bp+0x6]
041C  000A 26 FF 9F B0 00  call far word [es:bx+0xb0]
            L000F: cx = PopStack(player);
            L0010: RefreshCompareFlags(ax);
            L0012: if (JumpNotEqual) goto L0017;
            L0014: goto L009D;
            L0017: RefreshCompareFlags(GetFlag(player, 0x03, 0x0B));
            L002A: if (JumpNotEqual) goto L009D;
            L002C: Compare(GetFlag(player, 0x03, 0x0A), 0x0001);
            L0040: if (JumpNotEqual) goto L009D;
            L0042: ShowPortrait(player, 0x0026);
            L004F: SetFlag(player, 0x03, 0x0B, 0x01);
            L0064: ShowMessage(player, String0B06); // Psst!  Cuz.  Pay little attention to that old fool.  Thou art here for the loot.  I can give thee some advice.  Herein thou mayst find Fleance's Flail, Oswy's Javelin, the Camlunn Crossbow, Edwin's Defender, the Phrygian Cap, and Aldhelm's Harp and Gauntlets.
            L0071: ShowMessage(player, String0C0A); // Where?  What beings guard them?  Why, an I knew that, I could take them for myself.  Why am I telling thee this?  Could it be the gold pieces I lifted from thy purse, cuz?  Anon!'
            L007E: ShowMessage(player, String0CBE); // He scampers off.
            L008B: ModifyGold(player, 0xFFFF0CBA);
            L009D: return; // RETURN;
        }

        private void Fn_08(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x0C));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L0129;
            L001B: SetFlag(player, 0x03, 0x0C, 0x01);
            L0030: Compare(GetFlag(player, 0x03, 0x09), 0x0001);
            L0044: if (JumpNotEqual) goto L0054;
04F7  0046 B8 CF 0C  mov ax, 0xccf
            L0049: PushStack(player, ax);
04FB  004A C4 5E 06  les bx, [bp+0x6]
04FE  004D 26 FF 9F F8 00  call far word [es:bx+0xf8]
            L0052: goto L006D;
            L0054: ShowMessage(player, String0D01); // Oh dear.  Perhaps you could do something to prevent every group of monsters you meet from ambushing you.
            L0061: DamagePlayer(player, 0x0258);
            L006E: SetFlag(player, 0x03, 0x09, 0x00);
0533  0082 B8 89 07  mov ax, 0x789
            L0085: PushStack(player, ax);
            L0086: PushStack(player, 0x00);
            L0089: PushStack(player, ax);
            L008A: PushStack(player, 0xBA);
            L008E: PushStack(player, 0xCD);
            L0092: PushStack(player, 0x88);
0547  0096 C4 5E 06  les bx, [bp+0x6]
054A  0099 26 FF 9F D8 00  call far word [es:bx+0xd8]
054F  009E 83 C4 0C  add sp, 0xc
            L00A1: AddEncounter(player, 0x01, 0x19);
            L00B3: AddEncounter(player, 0x02, 0x19);
            L00C5: AddEncounter(player, 0x05, 0x1C);
            L00D7: Compare(PartyCount(player), 0x0001);
            L00E2: if (JumpBelowOrEqual) goto L00F6;
            L00E4: AddEncounter(player, 0x06, 0x1C);
            L00F6: Compare(PartyCount(player), 0x0002);
            L0101: if (JumpBelowOrEqual) goto L0136;
            L0103: AddEncounter(player, 0x04, 0x1C);
            L0115: AddEncounter(player, 0x03, 0x1C);
            L0127: goto L0136;
            L0129: ShowMessage(player, String0D6A); // No signs remain of your battle here save for a discarded mallet and a slightly singed magic wand.
            L0136: return; // RETURN;
        }

        private void Fn_09(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0DCC); // This cabinet is empty.
            L0010: return; // RETURN;
        }

        private void Fn_0A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x01));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00F4;
            L001B: PushStack(player, 0x01);
            L001F: PushStack(player, ax);
            L0020: PushStack(player, 0x03);
061F  0024 C4 5E 06  les bx, [bp+0x6]
0622  0027 26 FF 1F  call far word [es:bx]
0625  002A 83 C4 06  add sp, 0x6
            L002D: SetFlag(player, 0x02, 0x1F, 0x01);
            L0042: SetFlag(player, 0x02, 0x29, 0x01);
            L0057: SetFlag(player, 0x03, 0x10, 0x01);
            L006C: ShowMessage(player, String0DE3); // There is Banquo's Ghost.  Get him while he's hot!
            L0079: AddEncounter(player, 0x01, 0x25);
            L008B: AddEncounter(player, 0x05, 0x26);
            L009D: AddEncounter(player, 0x02, 0x25);
            L00AF: AddEncounter(player, 0x06, 0x25);
            L00C1: Compare(PartyCount(player), 0x0002);
            L00CC: if (JumpBelowOrEqual) goto L0117;
            L00CE: AddEncounter(player, 0x03, 0x25);
            L00E0: AddEncounter(player, 0x04, 0x25);
            L00F2: goto L0117;
            L00F4: Compare(GetFlag(player, 0x03, 0x10), 0x0001);
            L0108: if (JumpNotEqual) goto L0117;
            L010A: ShowMessage(player, String0E15); // That was quite a host Banquo had.  It was a good thing that you were up to his brand of 'hospitality.'
            L0117: return; // RETURN;
        }

        private void Fn_0B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x01));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L0101;
            L001B: PushStack(player, 0x01);
            L001F: PushStack(player, ax);
            L0020: PushStack(player, 0x03);
0738  0024 C4 5E 06  les bx, [bp+0x6]
073B  0027 26 FF 1F  call far word [es:bx]
073E  002A 83 C4 06  add sp, 0x6
            L002D: SetFlag(player, 0x02, 0x1F, 0x01);
            L0042: SetFlag(player, 0x02, 0x29, 0x01);
            L0057: SetFlag(player, 0x03, 0x0F, 0x01);
            L006C: ShowMessage(player, String0E7C); // Ouch!  The ambush is bad enough, but Banquo's Ghost is shaking his gory locks at you.  Have at him!
            L0079: DamagePlayer(player, 0x03E8);
            L0086: AddEncounter(player, 0x01, 0x25);
            L0098: AddEncounter(player, 0x05, 0x27);
            L00AA: AddEncounter(player, 0x02, 0x25);
            L00BC: AddEncounter(player, 0x06, 0x25);
            L00CE: Compare(PartyCount(player), 0x0002);
            L00D9: if (JumpBelowOrEqual) goto L0124;
            L00DB: AddEncounter(player, 0x03, 0x25);
            L00ED: AddEncounter(player, 0x04, 0x25);
            L00FF: goto L0124;
            L0101: Compare(GetFlag(player, 0x03, 0x10), 0x0001);
            L0115: if (JumpNotEqual) goto L0124;
            L0117: ShowMessage(player, String0EE0); // Judging from the ambush he had arranged, it was a good thing you caught Banquo unawares.  If that was fighting him unawares, you most definitely did not want to fight him prepared.
            L0124: return; // RETURN;
        }

        private void Fn_0C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x01));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00EC;
            L001B: PushStack(player, 0x01);
            L001F: PushStack(player, ax);
            L0020: PushStack(player, 0x03);
085E  0024 C4 5E 06  les bx, [bp+0x6]
0861  0027 26 FF 1F  call far word [es:bx]
0864  002A 83 C4 06  add sp, 0x6
            L002D: SetFlag(player, 0x02, 0x1F, 0x01);
            L0042: SetFlag(player, 0x02, 0x29, 0x01);
            L0057: ShowMessage(player, String0E7C); // Ouch!  The ambush is bad enough, but Banquo's Ghost is shaking his gory locks at you.  Have at him!
            L0064: DamagePlayer(player, 0x07D0);
            L0071: AddEncounter(player, 0x01, 0x25);
            L0083: AddEncounter(player, 0x05, 0x28);
            L0095: AddEncounter(player, 0x02, 0x25);
            L00A7: AddEncounter(player, 0x06, 0x25);
            L00B9: Compare(PartyCount(player), 0x0002);
            L00C4: if (JumpBelowOrEqual) goto L012A;
            L00C6: AddEncounter(player, 0x03, 0x25);
            L00D8: AddEncounter(player, 0x04, 0x25);
            L00EA: goto L012A;
            L00EC: Compare(GetFlag(player, 0x03, 0x10), 0x0001);
            L0100: if (JumpEqual) goto L0118;
            L0102: Compare(GetFlag(player, 0x03, 0x0F), 0x0001);
            L0116: if (JumpNotEqual) goto L011D;
0952  0118 B8 E0 0E  mov ax, 0xee0
            L011B: goto L0120;
            L011D: ShowMessage(player, String0F95); // You realize now that the horridly debilitating effects of the Dissolving Pool were what prevented you from reacting swiftly enough to avoid this ambush.  Next time - ah, who wants to fight Banquo again?
            L012A: return; // RETURN;
        }

        private void Fn_0D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1060); // This must have been Banquo's escape route.  It's a good thing you didn't give him the chance to use it.  But from the sharp spikes you're encountering as you fall, it's a bad thing you are using it now!
            L0010: DamagePlayer(player, 0x07D0);
            L001D: PushStack(player, GetFacing(player));
            L0025: PushStack(player, 0xD0);
            L0029: PushStack(player, 0x01);
            L002D: PushStack(player, 0x06);
0997  0031 C4 5E 06  les bx, [bp+0x6]
099A  0034 26 FF 9F BC 00  call far word [es:bx+0xbc]
099F  0039 83 C4 08  add sp, 0x8
            L003C: return; // RETURN;
        }

        private void Fn_0E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFlag(player, 0x02, 0x1F, 0x01);
            L0018: RefreshCompareFlags(GetFlag(player, 0x03, 0x0A));
            L002B: if (JumpNotEqual) goto L0076;
            L002D: SetFlag(player, 0x03, 0x0A, 0x01);
            L0042: ShowPortrait(player, 0x002B);
            L004F: ShowMessage(player, String112B); // 'Hmmph.  Adventurers!  Ah, well.  The Wizard's Guild has thoroughly investigated this room.  An thou hast not yet faced Banquo's ghost, thou shalt not do so from here.
            L005C: ShowMessage(player, String11D3); // There are many private lockers here, some well and thoroughly trapped, so burgle at thy own risk.
            L0069: ShowMessage(player, String1235); // The door to the Kitchen is on the south wall near the east wall, and the door to the Conservatory is on the east wall nearer the south wall than the north, but more towards the middle.  Now be off with thee!
            L0076: return; // RETURN;
        }

        private void Fn_0F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x01);
0A23  0007 C4 5E 06  les bx, [bp+0x6]
0A26  000A 26 FF 9F B0 00  call far word [es:bx+0xb0]
            L000F: cx = PopStack(player);
            L0010: RefreshCompareFlags(ax);
            L0012: if (JumpEqual) goto L0036;
            L0014: PushStack(player, 0x04);
0A34  0018 C4 5E 06  les bx, [bp+0x6]
0A37  001B 26 FF 9F B0 00  call far word [es:bx+0xb0]
            L0020: cx = PopStack(player);
            L0021: RefreshCompareFlags(ax);
            L0023: if (JumpEqual) goto L0036;
            L0025: PushStack(player, 0x03);
0A45  0029 C4 5E 06  les bx, [bp+0x6]
0A48  002C 26 FF 9F B0 00  call far word [es:bx+0xb0]
            L0031: cx = PopStack(player);
            L0032: RefreshCompareFlags(ax);
            L0034: if (JumpNotEqual) goto L0062;
            L0036: Compare(GetFlag(player, 0x02, 0x14), 0x0001);
            L004A: if (JumpEqual) goto L0062;
            L004C: Compare(GetFlag(player, 0x02, 0x1E), 0x0001);
            L0060: if (JumpNotEqual) goto L00D1;
            L0062: ShowPortrait(player, 0x001D);
            L006F: ShowMessage(player, String1305); // Three halflings, two of whom look badly wounded and in serious need of a smithy, hold the door open for you.
            L007C: ShowMessage(player, String1372); // 'Go on in, go on in,' they say.  'But do not travel this path in ignorance.  There are more fiercesome beasts within than yet we have encountered, and lacking the wherewithal to withstand the Dissolving Pool we were forced to flee Banquo's unknightly assault.
            L0089: ShowMessage(player, String1476); // Mayhaps thou wilt receive better fortune than we had, cousin.
            L0096: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L00B4: TeleportParty(player, 0x07, 0x01, 0x0C, 0x01, isForwardMove);
            L00CF: goto L00DE;
            L00D1: ShowMessage(player, String14B4); // Struggle though you will, you are unable to open the door that leads to the Kitchen.
            L00DE: return; // RETURN;
        }

        private void Fn_10(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x04);
0B03  0007 C4 5E 06  les bx, [bp+0x6]
0B06  000A 26 FF 9F B0 00  call far word [es:bx+0xb0]
            L000F: cx = PopStack(player);
            L0010: RefreshCompareFlags(ax);
            L0012: if (JumpEqual) goto L0036;
            L0014: PushStack(player, 0x02);
0B14  0018 C4 5E 06  les bx, [bp+0x6]
0B17  001B 26 FF 9F B0 00  call far word [es:bx+0xb0]
            L0020: cx = PopStack(player);
            L0021: RefreshCompareFlags(ax);
            L0023: if (JumpEqual) goto L0036;
            L0025: PushStack(player, 0x03);
0B25  0029 C4 5E 06  les bx, [bp+0x6]
0B28  002C 26 FF 9F B0 00  call far word [es:bx+0xb0]
            L0031: cx = PopStack(player);
            L0032: RefreshCompareFlags(ax);
            L0034: if (JumpNotEqual) goto L0062;
            L0036: Compare(GetFlag(player, 0x02, 0x14), 0x0001);
            L004A: if (JumpEqual) goto L0062;
            L004C: Compare(GetFlag(player, 0x02, 0x6F), 0x0001);
            L0060: if (JumpNotEqual) goto L00A6;
            L0062: ShowPortrait(player, 0x0029);
            L006F: ShowMessage(player, String1509); // Three halflings catch the door before it closes.
            L007C: ShowMessage(player, String153A); // 'Well met!  There are enough undead in there for all of us, and some giants and dragons as well.  May providence smile upon thy works.'
            L0089: TeleportParty(player, 0x08, 0x01, 0xA0, 0x02, isForwardMove);
            L00A4: goto L00D0;
            L00A6: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L00C3: ShowMessage(player, String15C2); // The door to the Conservatory refuses to budge.
            L00D0: return; // RETURN;
        }

        private void Fn_11(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String15F1); // I guess this large cabinet is empty.
            L0010: return; // RETURN;
        }

        private void Fn_12(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1616); // All that you find in this cabinet is a punctured peruke.
            L0010: return; // RETURN;
        }

        private void Fn_13(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String164F); // All that you find in this cabinet are some barbarian's unmentionables.  And believe you me, the way they smell is unmentionable.  This is a family network, you know!
            L0010: return; // RETURN;
        }

        private void Fn_14(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String16F5); // Some imps must have been living here, because you find a broken pitchfork.  It has some magical engraving on it, but the piece you have left is too incomplete to decipher.
            L0010: return; // RETURN;
        }

        private void Fn_15(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String17A1); // You find a scrap of parchment.  It reads, 'Ware the Haggis of Horror, for it is to be feared above all the other slimes.  It can dissolve - oh no!  It can dissolve me!'
            L0010: ShowMessage(player, String184A); // Evidently the writer of this parchment was dissatisfied with the conclusion of his investigations.
            L001D: return; // RETURN;
        }

        private void Fn_16(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String18AD); // You find a soiled toga with the runes for the letters 'K' and 'D' on its back.
            L0010: return; // RETURN;
        }

        private void Fn_17(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String18FC); // This room must be the garbage dump for this level.  There are more broken things in here than you can shake a stick at.  In fact, shaking a stick at them is probably what broke most of them!
            L0010: return; // RETURN;
        }

        private void Fn_18(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String19BB); // Evidently a bunch of bats made this their lair for a while, but you don't guano know how you can tell.
            L0010: return; // RETURN;
        }

        private void Fn_19(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1A22); // Uggh!  A herd of pigs must have been living here, and the smell's enough to drop a rhino in its tracks!  You barely make it to the door.
            L0010: DamagePlayer(player, 0x0064);
            L001D: return; // RETURN;
        }

        private void Fn_1A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1AAB); // You find some old celtic symbols scrawled upon a wall, but they are too faded to decipher.
            L0010: return; // RETURN;
        }

        private void Fn_1B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1B06); // A ratty piece of cloth is draped on the north wall.
            L0010: return; // RETURN;
        }

        private void Fn_1C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowRunes(player, String1B3A); // Woe is me!  My parents visited Cawdor Castle and got eaten by a dragon, and all I inherited was this crummy old tunic.
            L0010: return; // RETURN;
        }

        private void Fn_1D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1BB1); // That pile of cloth in the corner is either some leftovers from a mummy, some discarded bandages, or some red handkerchiefs.  You decide that you really don't want to know which.
            L0010: return; // RETURN;
        }

        private void Fn_1E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1C63); // You find the remains of a halfling, with a crude note pinned to his chest.  It reads, 'He stole the silverware.
            L0010: return; // RETURN;
        }

        private void Fn_1F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x03);
            L0007: PushStack(player, ax);
0CEC  0008 C4 5E 06  les bx, [bp+0x6]
0CEF  000B 26 FF 5F 04  call far word [es:bx+0x4]
            L000F: cx = PopStack(player);
            L0010: cx = PopStack(player);
            L0011: RefreshCompareFlags(ax);
            L0013: if (JumpEqual) goto L0018;
            L0015: goto L00DE;
            L0018: PushStack(player, 0x01);
            L001C: PushStack(player, 0x03);
            L0020: PushStack(player, ax);
0D05  0021 C4 5E 06  les bx, [bp+0x6]
0D08  0024 26 FF 1F  call far word [es:bx]
0D0B  0027 83 C4 06  add sp, 0x6
            L002A: ShowMessage(player, String1CD3); // Great Bats o'Fire!  Those bats are breathing flames!  'Tis a shame they appear to have no taste for roast pork.
0D1B  0037 B8 4F 03  mov ax, 0x34f
            L003A: PushStack(player, ax);
            L003B: PushStack(player, 0x00);
            L003E: PushStack(player, ax);
            L003F: PushStack(player, 0xBA);
            L0043: PushStack(player, 0xCD);
            L0047: PushStack(player, 0x33);
0D2F  004B C4 5E 06  les bx, [bp+0x6]
0D32  004E 26 FF 9F D8 00  call far word [es:bx+0xd8]
0D37  0053 83 C4 0C  add sp, 0xc
            L0056: AddEncounter(player, 0x01, 0x21);
            L0068: AddEncounter(player, 0x02, 0x21);
            L007A: AddEncounter(player, 0x05, 0x22);
            L008C: Compare(PartyCount(player), 0x0001);
            L0097: if (JumpBelowOrEqual) goto L00AB;
            L0099: AddEncounter(player, 0x06, 0x22);
            L00AB: Compare(PartyCount(player), 0x0002);
            L00B6: if (JumpBelowOrEqual) goto L00EB;
            L00B8: AddEncounter(player, 0x04, 0x22);
            L00CA: AddEncounter(player, 0x03, 0x22);
            L00DC: goto L00EB;
            L00DE: ShowMessage(player, String1D43); // You are still a tad puzzled that that razorback was able to fight so well with Oswy's Javelin stuck in him.  But you're also greatful that the guardians of that javelin were not able to wield it against you.
            L00EB: return; // RETURN;
        }

        private void Fn_20(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1E13); // You find a scorched rabbit's foot.  You know, if it wasn't lucky for the rabbit, why would it be lucky for anyone else?
            L0010: return; // RETURN;
        }

        private void Fn_21(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1E8B); // You find a holey shield.  No, I don't mean sanctified.
            L0010: return; // RETURN;
        }

        private void Fn_22(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x02, 0x37));
            L0016: if (JumpNotEqual) goto L003F;
            L0018: SetFlag(player, 0x02, 0x37, 0x01);
            L002D: ShowMessage(player, String1EC2); // A rift appears in the fabric of space and time, and, with corruscating effects too spectacular for this game's budget, a man appears.
0E2F  003A B8 48 1F  mov ax, 0x1f48
            L003D: goto L0042;
            L003F: ShowMessage(player, String2020); // You find a worthless piece of green paper with indecipherable runes on it.  You decide to leave it here to confuse you the next time you come here.
            L004C: return; // RETURN;
        }

        private void Fn_23(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFlag(player, 0x03, 0x0D, 0x01);
            L0018: ShowMessage(player, String20B4); // I'd try and describe the moldy pile of dragon droppings you find here, but the English language doesn't have the right words.  If only you spoke bloodhound.
            L0025: Compare(GetFlag(player, 0x03, 0x0E), 0x0001);
            L0039: if (JumpNotEqual) goto L0048;
            L003B: ShowMessage(player, String2151); // You think about retrieving the broken shovel you left behind, but decide wisely that it's not your job.
            L0048: return; // RETURN;
        }

        private void Fn_24(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String21B9); // You find a discarded potion bottle.  Fortunately, you don't know of any conceivable use for Eau d'Troll, so you wisely leave it behind.
            L0010: return; // RETURN;
        }

        private void Fn_25(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String2241); // You find a few harpy feathers.  They might be worth something if only you could force yourself to pick them up.
            L0010: return; // RETURN;
        }

        private void Fn_26(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String22B1); // You find a broken shield.
            L0010: return; // RETURN;
        }

        private void Fn_27(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String22CB); // You find a nice bunch of flowers arranged nicely in a vase.
            L0010: return; // RETURN;
        }

        private void Fn_28(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String2307); // You find a scrap of paper.  It has a picture of the Mongol hordes on the front, and on the back is written, 'I visited Ulan Bator and was tortured by Genghis Khan.  Wish you were here.  Wish I wasn't!'
            L0010: return; // RETURN;
        }

        private void Fn_29(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String23D1); // You find a scrap of paper offering you a ten percent discount on having your scales polished at Smaug's Buff and Wax.  Lo, how the mighty have fallen.
            L0010: return; // RETURN;
        }

        private void Fn_2A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String2468); // You find the worn nub of a candle.
            L0010: return; // RETURN;
        }

        private void Fn_2B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x04));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00E4;
            L001B: SetFlag(player, 0x03, 0x04, 0x01);
            L0030: ShowMessage(player, String248B); // Uh oh!  These guys can and are using Camlunn's crossbow, because that's a quarrel sticking out of you!
0F48  003D B8 4F 03  mov ax, 0x34f
            L0040: PushStack(player, ax);
            L0041: PushStack(player, 0x00);
            L0044: PushStack(player, ax);
            L0045: PushStack(player, 0xBA);
            L0049: PushStack(player, 0xC6);
            L004D: PushStack(player, 0x42);
0F5C  0051 C4 5E 06  les bx, [bp+0x6]
0F5F  0054 26 FF 9F D8 00  call far word [es:bx+0xd8]
0F64  0059 83 C4 0C  add sp, 0xc
            L005C: AddEncounter(player, 0x01, 0x1D);
            L006E: AddEncounter(player, 0x02, 0x1D);
            L0080: AddEncounter(player, 0x05, 0x1E);
            L0092: Compare(PartyCount(player), 0x0002);
            L009D: if (JumpBelowOrEqual) goto L00B1;
            L009F: AddEncounter(player, 0x06, 0x1E);
            L00B1: Compare(PartyCount(player), 0x0003);
            L00BC: if (JumpBelowOrEqual) goto L00FE;
            L00BE: AddEncounter(player, 0x04, 0x1D);
            L00D0: AddEncounter(player, 0x03, 0x1D);
            L00E2: goto L00FE;
            L00E4: ShowMessage(player, String24F2); // Those thieves proved rather quarrelsome, but you managed to prevail.
            L00F1: ShowMessage(player, String2537); // What?  You expected every pun to be a gem?  Try Quest for Glory I VGA if that's what you want.
            L00FE: return; // RETURN;
        }

        private void Fn_2C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x05));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L0128;
            L001B: SetFlag(player, 0x03, 0x05, 0x01);
            L0030: RefreshCompareFlags(GetFlag(player, 0x03, 0x09));
            L0043: if (JumpNotEqual) goto L0060;
            L0045: ShowMessage(player, String2596); // Yikes!  Those imps and picts are prepared!
105D  0052 B8 E8 03  mov ax, 0x3e8
            L0055: PushStack(player, ax);
1061  0056 C4 5E 06  les bx, [bp+0x6]
1064  0059 26 FF 9F 90 00  call far word [es:bx+0x90]
            L005E: goto L006C;
            L0060: ShowMessage(player, String25C1); // Strike another blow for moving cautiously!  Because you spotted their tracks, they couldn't spring that ambush on you!
            L006D: SetFlag(player, 0x03, 0x09, 0x00);
108C  0081 B8 4F 03  mov ax, 0x34f
            L0084: PushStack(player, ax);
            L0085: PushStack(player, 0x00);
            L0088: PushStack(player, ax);
            L0089: PushStack(player, 0xBA);
            L008D: PushStack(player, 0xCD);
            L0091: PushStack(player, 0x4F);
10A0  0095 C4 5E 06  les bx, [bp+0x6]
10A3  0098 26 FF 9F D8 00  call far word [es:bx+0xd8]
10A8  009D 83 C4 0C  add sp, 0xc
            L00A0: AddEncounter(player, 0x01, 0x1F);
            L00B2: AddEncounter(player, 0x02, 0x1F);
            L00C4: AddEncounter(player, 0x05, 0x20);
            L00D6: Compare(PartyCount(player), 0x0001);
            L00E1: if (JumpBelowOrEqual) goto L00F5;
            L00E3: AddEncounter(player, 0x06, 0x20);
            L00F5: Compare(PartyCount(player), 0x0002);
            L0100: if (JumpBelowOrEqual) goto L0152;
            L0102: AddEncounter(player, 0x04, 0x1F);
            L0114: AddEncounter(player, 0x03, 0x20);
            L0126: goto L0152;
            L0128: Compare(GetGuild(player), 0x0001);
            L0132: if (JumpEqual) goto L0140;
            L0134: Compare(GetGuild(player), 0x0005);
            L013E: if (JumpNotEqual) goto L0145;
114B  0140 B8 38 26  mov ax, 0x2638
            L0143: goto L0148;
            L0145: ShowMessage(player, String26C8); // Hey!  This Edwin's defender is one snazzy shield!  It's almost enough to make up for the fact that now everyone calls you Edwin!
            L0152: return; // RETURN;
        }

        private void Fn_2D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x06));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00E1;
            L001B: SetFlag(player, 0x03, 0x06, 0x01);
            L0030: ShowMessage(player, String2749); // You must have found the guardians of the Phrygian Caps, because those elves are wearing them!
119C  003D B8 07 06  mov ax, 0x607
            L0040: PushStack(player, ax);
            L0041: PushStack(player, 0x00);
            L0044: PushStack(player, ax);
            L0045: PushStack(player, ax);
            L0046: PushStack(player, 0xCD);
            L004A: PushStack(player, 0x65);
11AD  004E C4 5E 06  les bx, [bp+0x6]
11B0  0051 26 FF 9F D8 00  call far word [es:bx+0xd8]
11B5  0056 83 C4 0C  add sp, 0xc
            L0059: AddEncounter(player, 0x01, 0x1B);
            L006B: AddEncounter(player, 0x02, 0x1B);
            L007D: AddEncounter(player, 0x05, 0x1C);
            L008F: Compare(PartyCount(player), 0x0001);
            L009A: if (JumpBelowOrEqual) goto L00AE;
            L009C: AddEncounter(player, 0x06, 0x1C);
            L00AE: Compare(PartyCount(player), 0x0002);
            L00B9: if (JumpBelowOrEqual) goto L00EE;
            L00BB: AddEncounter(player, 0x04, 0x1B);
            L00CD: AddEncounter(player, 0x03, 0x1B);
            L00DF: goto L00EE;
            L00E1: ShowMessage(player, String27A7); // All that remains of your battle here is a broken noseguard.
            L00EE: return; // RETURN;
        }

        private void Fn_2E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x07));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00F1;
            L001B: SetFlag(player, 0x03, 0x07, 0x01);
            L0030: ShowMessage(player, String27E3); // Yes, these are the folks with Aldhelm's Harp.  You can tell because they are using it to lob fireballs at you!
            L003D: DamagePlayer(player, 0x0258);
1299  004A B8 89 07  mov ax, 0x789
            L004D: PushStack(player, ax);
            L004E: PushStack(player, 0x00);
            L0051: PushStack(player, ax);
            L0052: PushStack(player, 0xBA);
            L0056: PushStack(player, 0xCD);
            L005A: PushStack(player, 0x95);
12AD  005E C4 5E 06  les bx, [bp+0x6]
12B0  0061 26 FF 9F D8 00  call far word [es:bx+0xd8]
12B5  0066 83 C4 0C  add sp, 0xc
            L0069: AddEncounter(player, 0x01, 0x1A);
            L007B: AddEncounter(player, 0x02, 0x1A);
            L008D: AddEncounter(player, 0x05, 0x1C);
            L009F: Compare(PartyCount(player), 0x0001);
            L00AA: if (JumpBelowOrEqual) goto L00BE;
            L00AC: AddEncounter(player, 0x06, 0x1C);
            L00BE: Compare(PartyCount(player), 0x0002);
            L00C9: if (JumpBelowOrEqual) goto L00FE;
            L00CB: AddEncounter(player, 0x04, 0x1C);
            L00DD: AddEncounter(player, 0x03, 0x1C);
            L00EF: goto L00FE;
            L00F1: ShowMessage(player, String2852); // You've heard many a bard play sweet music, but the fireballs from Aldhelm's Harp that you won here sizzle with a sweet sound all their own.
            L00FE: return; // RETURN;
        }

        private void Fn_2F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String28DE); // You find several empty wineskins and, scrawled on the wall, the words, 'Oberon's a real fairy.'
            L0010: return; // RETURN;
        }

        private void Fn_30(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String293E); // You find a scrap of paper reading, 'Fine fresh firewood, only a farthing for a firtle of faggots.  See S. Stump at the Greenbriar Market.
            L0010: return; // RETURN;
        }

        private void Fn_31(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String29C8); // You find some old rocks.  Or maybe it's dwarven waybread.  The two are generally interchangeable.
            L0010: return; // RETURN;
        }

        private void Fn_32(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String2A2A); // Ah, the flotsam and jetsam of a thousand worlds could have drifted the tides of time and space to wind up here.  But didn't.
            L0010: return; // RETURN;
        }

        private void Fn_33(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String2AA7); // You find a broken shovel.
            L0010: SetFlag(player, 0x03, 0x0E, 0x01);
            L0025: Compare(GetFlag(player, 0x03, 0x0D), 0x0001);
            L0039: if (JumpNotEqual) goto L0048;
            L003B: ShowMessage(player, String2AC1); // You think about using it on the dragon droppings, but wisely decide that it's not your job.
            L0048: return; // RETURN;
        }

        private void Fn_34(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String2B1D); // You find a broken bhodhron.  Alas, 'twill beat no more.
            L0010: return; // RETURN;
        }

        private void Fn_35(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String2B55); // You find some discarded bagpipes.  In a fit of incredible wisdom, you decide not to fiddle with them.  Either they wouldn't play, which would be bad, or they would play, which would be worse.
            L0010: return; // RETURN;
        }

        private void Fn_36(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x01), 0x0001);
            L0017: if (JumpNotEqual) goto L0085;
            L0019: RefreshCompareFlags(GetFlag(player, 0x03, 0x11));
            L002C: if (JumpNotEqual) goto L0085;
            L002E: SetFlag(player, 0x03, 0x11, 0x01);
            L0043: GiveItem(player, 0xEA);
            L004F: GiveItem(player, 0xBB);
            L005B: GiveItem(player, 0x0E);
            L0067: ModifyGold(player, 0x2690);
            L0078: ShowMessage(player, String2C15); // There's something so delightful about liberating someone's ill-gotten booty.  You assume any ghost's booty is going to be ill-gotten.
            L0085: return; // RETURN;
        }

    }
}
