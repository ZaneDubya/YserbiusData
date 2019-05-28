#pragma warning disable
using System.Collections.Generic;
using XPT.WorldData;
using XPT.WorldData.Yserbius;

namespace XPT.Scripts.Yserbius.Maps {
    class YserMap30 : AMapScripted {
        protected override int MapIndex => 30;
        protected override int RandomEncounterChance => 27;
        protected override int RandomEncounterExtraCount => 2;

        public YserMap30() {
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
            MapEvent0C = FnNVIL_0C;
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
        }
        
        // === Strings ================================================
        private const string String0140 = "A brawny blacksmith works at his anvil.  To the south you see a hotly glowing furnace.  He offers a large calloused hand in greeting.";
        private const string String01C6 = "'Good grip on thee, eh?  I am Braddock Smith, and a better one thou wilt not find hereabouts.  And there be no friendlier one alive, mark my words.'  His words are kindly spoken, but shouted so loud as to hurt your ears.";
        private const string String02A3 = "'I am all but deaf, which may account for my pleasure in working here, where conversation is banned by my work.  So my labor has a caveat, if not a price.'";
        private const string String033F = "'Bring me that which thou wouldst have me fix, and the tool that thou wouldst have me use, and I will do the work anon for but five pieces of gold.  My tools are scattered hereabouts.  Seek and thou shalt find.'";
        private const string String0413 = "'And I do toss lesser samples of my work hither and yon, so if thou dost stumble upon anything like that around here, why, 'tis thine, with my blessing.'";
        private const string String04AD = "'Canst not expect a friendlier forger than that, no?'  He returns to his hammering with a smile.";
        private const string String050E = "You make some feeble motions and gestures which would not earn you many points at charades.  Braddock, however, understands you.";
        private const string String058F = "'Eureka!' cries Braddock.  'Thou dost want me to conjoin these three horseshoes with thy stout rope!'";
        private const string String05F5 = "'I am truly sorry, but I do not know what I could make out of so few horseshoes.'";
        private const string String0647 = "'I am truly sorry, but I do not know what I could make out of just one horseshoe.'";
        private const string String069A = "You make some gestures that border so closely on the obscene that we are not allowed to describe or detail them further.  After all, this isn't the Internet.";
        private const string String0738 = "But Braddock seems to understand what you want.";
        private const string String0768 = "'Ah hah!  Yon dull hook does not match the bite of thy sharp wit!  Give me but a few seconds and I shall improve it.'";
        private const string String07DE = "It takes far less than one hundred strokes before Braddock understands that you would like these fibres made into rope.";
        private const string String0856 = "'Ah hah!  I do have the hang of it!  Thou dost wish to have that which in turn may give thee the hang of it!'";
        private const string String08C4 = "'Thou wilt have to wait until I have fixed this leftward tendency in Farmer Joan's plow.  We all want to see Joan plow right.'";
        private const string String0943 = "'I must finish affixing these arrowheads to their shafts with this wire.  I believe in wiring a head for arrow's salvation.'";
        private const string String09C0 = "'Prithee, but I must first finish patching this soup pot.  Master Whitchurch has a huge joint of beef he would make into soup.'";
        private const string String0A40 = "*** Warning!  Warning! ***";
        private const string String0A5B = "We must apologise, but the rest of this well-aged joke must be censored.";
        private const string String0AA4 = "'I beg thy pardon, but for the good of all Scotland I must needs patch Mistress Sly's chastity belt afore the lads who are restraining her tire of their tasks.'";
        private const string String0B45 = "'Bide a wee.  Master Foote would have his blade polished afore the guild meeting tomorrow.  It will not take long, for Foote keeps his weapon in good repair.'";
        private const string String0BE4 = "'I must beg off for the nonce, for I have been commissioned by the Bright family butchers to sharpen all their blades.  And know you: the Brights have some of the dullest blades in Scotland.'";
        private const string String0CA4 = "'Hold!  Mistress Styx has enlisted me to sharpen her fine embroidery needles.  'Twill not take long, but cannot be delayed.'";
        private const string String0D21 = "'Glad would I be to help thee now, but when a lass as comely as Mistress Perchworthy needs her fishing hooks and cleaning knives sharpened, well, I am but trollish.'";
        private const string String0DC7 = "'Nay not!  The gauntlets that are all that do restrain the wandering fingers of Guildmaster Ticklebottom are in disarray, and I will have the good will of half the women hereabouts an I do repair them.'";
        private const string String0E92 = "'Prithee pardon, but the good Mistress Catherine Bright has broken her rolling pin against her slothful drunken spouse's head.'";
        private const string String0F12 = "'She has promised me a fresh gooseberry pie an I do repair it today, and all hereabouts do know she has the best touch with goose, uh, berries, in Inverness.'";
        private const string String0FB1 = "Yowee!  This forge is hot!";
        private const string String0FCC = "This area has been set up for a blacksmith.  Directly in front of you a mighty artisan works a blade on his anvil.  To the south heat pours from a forge.  Tools of the trade are scattered about.";
        private const string String108F = "Braddock whistles almost, but not quite, in tune with the ringing his hammer makes.";
        private const string String10E3 = "The forge is as you left it.";
        private const string String1100 = "This room is filled with saddles, blankets, bridles, stirrups, and all manner of gear needed to ride a horse.";
        private const string String116E = "Why, there's even a bearskin rug for those of you into bear back riding!";
        private const string String11B7 = "The tack room is as you left it.";
        private const string String11D8 = "You hear some footsteps running away.";
        private const string String11FE = "You hear someone running towards you.";
        private const string String1224 = "A gargantuan gang of gremlins runs past you. One of them falls out and talks briefly.";
        private const string String127A = "'Hide me!  Protect me!  Save me!  A press gang snapped me up and I cannot take any more of this!'";
        private const string String12DC = "A burly sergeant wraps a whip around the gremlin's neck, jerking him back into the squad.  You decide not to interfere.";
        private const string String1354 = "The dragon examines you with a baleful eye.  It has seen better days.";
        private const string String139A = "'Wouldst thou help a wyrm in need of a reviving morsel?  Thou hast two legs; surely thou couldst spare me one.  Wouldst thou resist my efforts to consume thee, then?  I feared so.  Were I not wounded, though...'  It limps off.";
        private const string String147D = "'I think we have met before.  In sooth, did I not offer thee some dragonish drachmas?  Howsomever, now that I am equipped with Brunanburh's bow I find my relationships with dragons much improved.  I doubt that the wyrms would say the same, though.'";
        private const string String1576 = "The halfling struts off, smiling.";
        private const string String1598 = "A somewhat battered gang o'gremlins decides, rather insultingly, that they are bigger than you are.";
        private const string String15FC = "A cold breeze sends shivers down your spine.";
        private const string String1629 = "This door leads back to The Foyer of Cawdor.";
        private const string String1656 = "This room is filled with all manner of brushes, combs, and buckets.  A fountain bubbles freshly in the corner, supplying water for the buckets and, via troughs, for the horse stalls hereabouts.";
        private const string String1718 = "You have the uncomfortable feeling that if you stay around here too long someone is going to make you start using all this cleaning equipment.";
        private const string String17A7 = "The grooming room is as you left it.";
        private const string String17CC = "There.  You're wet now.  I still have no T-Shirt art, so you'll just have to be satisfied with using your ImagiNation.";
        private const string String1843 = "This is just the kind of behavior that can get you drummed out of the FBI (Filthy Barbarians, Indeed!).";
        private const string String18AB = "The banging is much louder here.";
        private const string String18CC = "Holy Mother of Pearl!  The entire wall swiveled sideways and, well, here you are!";
        private const string String191E = "This room is filled with everything a thirteenth century veterinarian could want to treat a sick horse.  Aside from shelves stocked full of remedies, there are also restraints, slings, picks, files, and bandages.";
        private const string String19F3 = "Kind of makes you think that healthy as a horse is an exaggeration, doesn't it.";
        private const string String1A43 = "The veterinarium is as you left it.";
        private const string String1A67 = "You glance over the Dutch door to see a dark but empty stall.";
        private const string String1AA5 = "You are too short to see over the dutch door, but the stall sounds quiet.";
        private const string String1AEF = "You think you see something small flitting around near the back of the stall.";
        private const string String1B3D = "You are too short to see over the dutch door, but you think you hear the sounds of movement.";
        private const string String1B9A = "There is nothing still lurking in these shadows.  Or, rather, if there is still something lurking, it is darned good at lurking and shows no inclination to stop.";
        private const string String1C3C = "No need to panic.  It's only bats.  Big, bloodthirsty bats, but still only bats.";
        private const string String1C8D = "No more bats here, or at least no more bats with a taste for flesh.";
        private const string String1CD1 = "You're not sure, but you think they're humming 'The Battle Hymn of the Republic.'";
        private const string String1D23 = "This stall has been thoroughly debatted.";
        private const string String1D4C = "You better batten down your hatches.";
        private const string String1D71 = "The stall is no longer occupied.";
        private const string String1D92 = "Uh oh!  Prepare to be battered!";
        private const string String1DB2 = "It's quiet here.  Almost too quiet.  Almost, but not quite.";
        private const string String1DEE = "'Tis a batty batch!";
        private const string String1E02 = "The only time you ever saw a stall this empty, you were trying to convince the birthday boy not to go home before his surprise party was set up.";
        private const string String1E93 = "You better get ready for the bloodbat!";
        private const string String1EBA = "I know, I know, it's dreadful, but how many bad bat jokes must one man write?";
        private const string String1F08 = "This box has been thoroughly decatted.";
        private const string String1F2F = "Did I say small and flitting?  Boy, I better make that appointment with the optometrist soon!";
        private const string String1F8D = "No, I guess there wasn't anything flitting around back here.";
        private const string String1FCA = "It's incredible, I know, but somehow those bats are about 83 percent teeth!";
        private const string String2016 = "The cat's away.  I guess you can play.";
        private const string String203D = "This must be the downhill end of the Stables, because it looks like all the world's cats have flowed down here.  And let me tell you, they did not want to have their nap interrupted!";
        private const string String20F4 = "You stumble over something.";
        private const string String2110 = "This appears to be a hay storage area.  It is full of horse forage.  At the end of the large room there used to be double doors, but they have been blocked by a landslide outside.";
        private const string String21C4 = "There used to be double doors leading out from here, but they are blocked by large quantities of dirt and rocks.  Whether this was a landslide or just deliberate mischief is unknowable.";
        private const string String227E = "The back door to the stables is still blocked.";
        private const string String22AD = "Nope, that's one thoroughly blocked door.";
        private const string String22D7 = "In regard to the matter of the unblocking of the back door, I'm afraid I have nothing to report.";
        private const string String2338 = "Wow!  Ahead of you the gates of heaven shine brightly.  Eternal joy awaits you!  Hosanna!  Hosanna!";
        private const string String239C = "No, I was just putting you on.  The door's still blocked.";
        private const string String23D6 = "Lovely view, if you like rocks.";
        private const string String23F6 = "Some good workmanship went into these doors.  Shame that better workmanship went into the rocks that are blocking it.";
        private const string String246C = "I have bad news and I have good news.  The bad news is that the dreaded Heiser gang is just outside, ready to carve you up.  The good news is, the door is still blocked.";
        private const string String2516 = "I have reviewed your plan to clear the door.  I'll let you invent tempered steel, the internal combustion engine, and vulcanized tires.  I am too kind.";
        private const string String25AE = "However, the gas station is right out.";
        private const string String25D5 = "Let me give you a broad hint.  When we wrote this game we just didn't think that anyone would want to spend their time moving dirt.  The door's blocked and it's going to stay blocked!";
        private const string String268D = "In utter frustration you take a running charge at the pile of rubble blocking the door.";
        private const string String26E5 = "That hurt.  But at least you now know that the door is safe from the likes of you!";
        private const string String2738 = "All right already!  You have proven your diligence.  Here is a small reward.  Now stop bothering the nice door; what did it ever do to you?";
        private const string String27C4 = "There used to be windows opening to the south from here, but they have been smashed by a huge pile of rubble just outside.";
        private const string String283F = "The windows are still blocked.  Hey, if there wasn't some serious disrepair here and there we'd have named this place The Fixed of Cawdor.";
        private const string String28CA = "You find an assortment of files.";
        private const string String28EB = "Not that I know what you might want to do with it, but here's one that looks interesting.";
        private const string String2945 = "You find an assortment of saws.  You'd take that nice electric table saw, but you haven't seen an electrical outlet since entering Cawdor.";
        private const string String29D0 = "Neither have you found any gasoline for that chainsaw.";
        private const string String2A07 = "In general disappointment you test the handsaws.  Much to your surprise, you find one with a good heft.  Life isn't all bad after all.";
        private const string String2A8E = "You find an assortment of grommeting tools and riveting punches.  This one seems marginally more useful than the others.";
        private const string String2B07 = "You find an assortment of implements for cleaning, roughening, smoothing, and polishing.";
        private const string String2B60 = "You find enough grips, clamps, and pliers to handle the even the spikiest hairdo!";
        private const string String2BB2 = "In fact, these are the very 'Tongs of Terror' that Master Hieronymous Snivel will be wielding on innocent toothache victims a few years hence.";
        private const string String2C41 = "You find an assortment of hammers, mallets, and other tools for beating and straightening metal.";
        private const string String2CA2 = "This place has all the familiar odors of a well kept stable: horses, leather, hay, sweat.  Somewhere to the south someone is banging, making a lot of noise.";
        private const string String2D3F = "I said familiar, not pleasant.";
        
        // === Functions ================================================
        private void Fn_01(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: si = 0;
            L0006: si = GetFlag(player, 0x02, 0x5A);
            L0019: ShowPortrait(player, 0x0020);
0034  0026 0B F6  or si, si
            L0028: if (JumpNotEqual) goto L0090;
            L002A: SetFlag(player, 0x02, 0x5A, 0x01);
            L003F: ShowMessage(player, String0140); // A brawny blacksmith works at his anvil.  To the south you see a hotly glowing furnace.  He offers a large calloused hand in greeting.
            L004C: ShowMessage(player, String01C6); // 'Good grip on thee, eh?  I am Braddock Smith, and a better one thou wilt not find hereabouts.  And there be no friendlier one alive, mark my words.'  His words are kindly spoken, but shouted so loud as to hurt your ears.
            L0059: ShowMessage(player, String02A3); // 'I am all but deaf, which may account for my pleasure in working here, where conversation is banned by my work.  So my labor has a caveat, if not a price.'
            L0066: ShowMessage(player, String033F); // 'Bring me that which thou wouldst have me fix, and the tool that thou wouldst have me use, and I will do the work anon for but five pieces of gold.  My tools are scattered hereabouts.  Seek and thou shalt find.'
            L0073: ShowMessage(player, String0413); // 'And I do toss lesser samples of my work hither and yon, so if thou dost stumble upon anything like that around here, why, 'tis thine, with my blessing.'
            L0080: ShowMessage(player, String04AD); // 'Canst not expect a friendlier forger than that, no?'  He returns to his hammering with a smile.
            L008D: goto L02C1;
            L0090: ax = HasItem(player, 0xD2);
            L009E: if (JumpNotEqual) goto L00A3;
            L00A0: goto L0172;
            L00A3: ax = HasItem(player, 0xE0);
            L00B1: if (JumpNotEqual) goto L00B6;
            L00B3: goto L0172;
            L00B6: ax = HasItem(player, 0xE3);
            L00C4: if (JumpNotEqual) goto L00C9;
            L00C6: goto L0172;
            L00C9: RemoveItem(player, 0xD2);
            L00D5: ax = HasItem(player, 0xD2);
            L00E3: if (JumpEqual) goto L015F;
            L00E5: RemoveItem(player, 0xD2);
            L00F1: ax = HasItem(player, 0xD2);
            L00FF: if (JumpEqual) goto L0145;
            L0101: ShowMessage(player, String050E); // You make some feeble motions and gestures which would not earn you many points at charades.  Braddock, however, understands you.
            L010E: ShowMessage(player, String058F); // 'Eureka!' cries Braddock.  'Thou dost want me to conjoin these three horseshoes with thy stout rope!'
            L011B: RemoveItem(player, 0xD2);
            L0127: RemoveItem(player, 0xE0);
            L0133: RemoveItem(player, 0xE3);
014D  013F B8 D3 00  mov ax, 0xd3
            L0142: goto L022B;
            L0145: ShowMessage(player, String05F5); // 'I am truly sorry, but I do not know what I could make out of so few horseshoes.'
            L0152: PushStack(player, 0xD2);
0164  0156 C4 5E 06  les bx, [bp+0x6]
0167  0159 26 FF 5F 48  call far word [es:bx+0x48]
            L015D: goto L016B;
            L015F: ShowMessage(player, String0647); // 'I am truly sorry, but I do not know what I could make out of just one horseshoe.'
017A  016C B8 D2 00  mov ax, 0xd2
            L016F: goto L022B;
            L0172: ax = HasItem(player, 0xD3);
            L0180: if (JumpEqual) goto L01D6;
            L0182: ax = HasItem(player, 0xD6);
            L0190: if (JumpEqual) goto L01D6;
            L0192: ShowMessage(player, String069A); // You make some gestures that border so closely on the obscene that we are not allowed to describe or detail them further.  After all, this isn't the Internet.
            L019F: ShowMessage(player, String0738); // But Braddock seems to understand what you want.
            L01AC: ShowMessage(player, String0768); // 'Ah hah!  Yon dull hook does not match the bite of thy sharp wit!  Give me but a few seconds and I shall improve it.'
            L01B9: RemoveItem(player, 0xD3);
            L01C5: RemoveItem(player, 0xD6);
01DF  01D1 B8 D4 00  mov ax, 0xd4
            L01D4: goto L022B;
            L01D6: ax = HasItem(player, 0xD5);
            L01E4: if (JumpEqual) goto L0236;
            L01E6: ax = HasItem(player, 0xDF);
            L01F4: if (JumpEqual) goto L0236;
            L01F6: ShowMessage(player, String07DE); // It takes far less than one hundred strokes before Braddock understands that you would like these fibres made into rope.
            L0203: ShowMessage(player, String0856); // 'Ah hah!  I do have the hang of it!  Thou dost wish to have that which in turn may give thee the hang of it!'
            L0210: RemoveItem(player, 0xD5);
            L021C: RemoveItem(player, 0xDF);
            L0228: PushStack(player, 0xE0);
023A  022C C4 5E 06  les bx, [bp+0x6]
023D  022F 26 FF 5F 48  call far word [es:bx+0x48]
            L0233: goto L008C;
            L0236: bx = si;
            L0238: bx = bx - 1;
            L0239: Compare(bx, 0x09);
            L023C: if (JumpAbove) goto L02A6;
            L023E: switch (bx) {
                case 0:
                    goto L0245;
                case 1:
                    goto L024A;
                case 2:
                    goto L024F;
                case 3:
                    goto L026E;
                case 4:
                    goto L0273;
                case 5:
                    goto L0278;
                case 6:
                    goto L027D;
                case 7:
                    goto L0282;
                case 8:
                    goto L0287;
                case 9:
                    goto L028C;
            }
0253  0245 B8 C4 08  mov ax, 0x8c4
            L0248: goto L029C;
0258  024A B8 43 09  mov ax, 0x943
            L024D: goto L029C;
            L024F: ShowMessage(player, String09C0); // 'Prithee, but I must first finish patching this soup pot.  Master Whitchurch has a huge joint of beef he would make into soup.'
            L025C: ShowMessage(player, String0A40); // *** Warning!  Warning! ***
0277  0269 B8 5B 0A  mov ax, 0xa5b
            L026C: goto L029C;
027C  026E B8 A4 0A  mov ax, 0xaa4
            L0271: goto L029C;
0281  0273 B8 45 0B  mov ax, 0xb45
            L0276: goto L029C;
0286  0278 B8 E4 0B  mov ax, 0xbe4
            L027B: goto L029C;
028B  027D B8 A4 0C  mov ax, 0xca4
            L0280: goto L029C;
0290  0282 B8 21 0D  mov ax, 0xd21
            L0285: goto L029C;
0295  0287 B8 C7 0D  mov ax, 0xdc7
            L028A: goto L029C;
            L028C: ShowMessage(player, String0E92); // 'Prithee pardon, but the good Mistress Catherine Bright has broken her rolling pin against her slothful drunken spouse's head.'
            L0299: ShowMessage(player, String0F12); // 'She has promised me a fresh gooseberry pie an I do repair it today, and all hereabouts do know she has the best touch with goose, uh, berries, in Inverness.'
            L02A6: si = si + 1;
            L02A7: Compare(si, 0x0A);
            L02AA: if (JumpLessOrEqual) goto L02AF;
            L02AC: si = 0x0001;
            L02AF: SetFlag(player, 0xC4, 0xB8, si);
            L02C1: return; // RETURN (restoring si);
        }

        private void Fn_02(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0FB1); // Yowee!  This forge is hot!
            L0010: DamagePlayer(player, 0x0005);
            L001D: return; // RETURN;
        }

        private void Fn_03(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x02));
            L0016: if (JumpNotEqual) goto L0057;
            L0018: SetFlag(player, 0x03, 0x02, 0x01);
            L002D: RefreshCompareFlags(GetFacing(player));
            L0036: if (JumpNotEqual) goto L006F;
            L0038: RefreshCompareFlags(GetFlag(player, 0x02, 0x5A));
            L004B: if (JumpNotEqual) goto L0052;
0352  004D B8 CC 0F  mov ax, 0xfcc
            L0050: goto L0065;
0357  0052 B8 8F 10  mov ax, 0x108f
            L0055: goto L0065;
            L0057: RefreshCompareFlags(GetFacing(player));
            L0060: if (JumpNotEqual) goto L006F;
            L0062: ShowMessage(player, String10E3); // The forge is as you left it.
            L006F: return; // RETURN;
        }

        private void Fn_04(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x03);
            L0007: PushStack(player, ax);
037E  0008 C4 5E 06  les bx, [bp+0x6]
0381  000B 26 FF 5F 04  call far word [es:bx+0x4]
            L000F: cx = PopStack(player);
            L0010: cx = PopStack(player);
            L0011: RefreshCompareFlags(ax);
            L0013: if (JumpNotEqual) goto L0039;
            L0015: PushStack(player, 0x01);
            L0019: PushStack(player, 0x03);
            L001D: PushStack(player, ax);
0394  001E C4 5E 06  les bx, [bp+0x6]
0397  0021 26 FF 1F  call far word [es:bx]
039A  0024 83 C4 06  add sp, 0x6
            L0027: ShowMessage(player, String1100); // This room is filled with saddles, blankets, bridles, stirrups, and all manner of gear needed to ride a horse.
03AA  0034 B8 6E 11  mov ax, 0x116e
            L0037: goto L003C;
            L0039: ShowMessage(player, String11B7); // The tack room is as you left it.
            L0046: return; // RETURN;
        }

        private void Fn_05(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si, di);
            L0005: di = 0;
            L0007: si = 0;
            L0009: ax = GetFlag(player, 0x03, 0x01);
03D8  001A 8B F8  mov di, ax
03DA  001C 47     inc di
03DB  001D 8B F7  mov si, di
            L001F: Compare(si, 0x13);
            L0022: if (JumpLessOrEqual) goto L002B;
03E2  0024 8B C6  mov ax, si
            L0026: si = ax + 0xFFEC;
            L002B: Compare(si, 0x0E);
            L002E: if (JumpLessOrEqual) goto L0037;
03EE  0030 8B C6  mov ax, si
            L0032: si = ax + 0xFFF1;
            L0037: Compare(si, 0x09);
            L003A: if (JumpLessOrEqual) goto L0043;
03FA  003C 8B C6  mov ax, si
            L003E: si = ax + 0xFFF6;
            L0043: Compare(si, 0x04);
            L0046: if (JumpLessOrEqual) goto L004F;
0406  0048 8B C6  mov ax, si
            L004A: si = ax + 0xFFFB;
040D  004F 0B F6  or si, si
040F  0051 7D 02  jge 0x55
            L0053: si = 0;
            L0055: Compare(si, 0x1D);
            L0058: if (JumpLessOrEqual) goto L005C;
            L005A: si = 0;
041A  005C 83 FF 1E  cmp di, 0x1e
            L005F: if (JumpLessOrEqual) goto L0063;
            L0061: di = 0;
0421  0063 57     push di
            L0064: PushStack(player, 0x01);
            L0068: PushStack(player, 0x03);
042A  006C C4 5E 06  les bx, [bp+0x6]
042D  006F 26 FF 1F  call far word [es:bx]
0430  0072 83 C4 06  add sp, 0x6
0433  0075 83 FF 1A  cmp di, 0x1a
            L0078: if (JumpNotEqual) goto L007F;
0438  007A B8 01 00  mov ax, 0x1
            L007D: goto L0081;
            L007F: PushStack(player, 0x00);
0440  0082 83 FF 14  cmp di, 0x14
            L0085: if (JumpNotEqual) goto L008C;
0445  0087 B8 01 00  mov ax, 0x1
            L008A: goto L008E;
044A  008C 33 C0  xor ax, ax
            L008E: dx = PopStack(player);
044D  008F 0B D0  or dx, ax
            L0091: PushStack(player, dx);
0450  0092 83 FF 0E  cmp di, 0xe
            L0095: if (JumpNotEqual) goto L009C;
0455  0097 B8 01 00  mov ax, 0x1
            L009A: goto L009E;
045A  009C 33 C0  xor ax, ax
            L009E: dx = PopStack(player);
045D  009F 0B D0  or dx, ax
            L00A1: PushStack(player, dx);
0460  00A2 83 FF 08  cmp di, 0x8
            L00A5: if (JumpNotEqual) goto L00AC;
0465  00A7 B8 01 00  mov ax, 0x1
            L00AA: goto L00AE;
046A  00AC 33 C0  xor ax, ax
            L00AE: dx = PopStack(player);
046D  00AF 0B D0  or dx, ax
            L00B1: PushStack(player, dx);
0470  00B2 83 FF 02  cmp di, 0x2
            L00B5: if (JumpNotEqual) goto L00BC;
0475  00B7 B8 01 00  mov ax, 0x1
            L00BA: goto L00BE;
047A  00BC 33 C0  xor ax, ax
            L00BE: dx = PopStack(player);
047D  00BF 0B D0  or dx, ax
            L00C1: if (JumpNotEqual) goto L00C6;
            L00C3: goto L026D;
            L00C6: bx = si;
            L00C8: Compare(bx, 0x04);
            L00CB: if (JumpBelowOrEqual) goto L00D0;
            L00CD: goto L026D;
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
                    goto L01AE;
            }
            L00D7: ShowMessage(player, String11D8); // You hear some footsteps running away.
            L00E4: goto L026D;
            L00E7: ShowMessage(player, String11FE); // You hear someone running towards you.
            L00F4: ShowPortrait(player, 0x0026);
            L0101: ShowMessage(player, String0A59);
            L010E: ShowMessage(player, String0A59);
            L011B: ShowMessage(player, String0A59);
            L0128: ShowMessage(player, String1224); // A gargantuan gang of gremlins runs past you. One of them falls out and talks briefly.
            L0135: ShowMessage(player, String127A); // 'Hide me!  Protect me!  Save me!  A press gang snapped me up and I cannot take any more of this!'
0500  0142 B8 DC 12  mov ax, 0x12dc
            L0145: goto L00DA;
            L0147: ShowPortrait(player, 0x000E);
            L0154: ShowMessage(player, String1354); // The dragon examines you with a baleful eye.  It has seen better days.
051F  0161 B8 9A 13  mov ax, 0x139a
            L0164: goto L00DA;
            L0167: ShowPortrait(player, 0x0025);
            L0174: ShowMessage(player, String0A59);
            L0181: ShowMessage(player, String0A59);
            L018E: ShowMessage(player, String0A59);
            L019B: ShowMessage(player, String147D); // 'I think we have met before.  In sooth, did I not offer thee some dragonish drachmas?  Howsomever, now that I am equipped with Brunanburh's bow I find my relationships with dragons much improved.  I doubt that the wyrms would say the same, though.'
0566  01A8 B8 76 15  mov ax, 0x1576
            L01AB: goto L00DA;
            L01AE: ShowPortrait(player, 0x0026);
            L01BB: ShowMessage(player, String0A59);
            L01C8: ShowMessage(player, String0A59);
            L01D5: ShowMessage(player, String0A59);
            L01E2: ShowMessage(player, String1598); // A somewhat battered gang o'gremlins decides, rather insultingly, that they are bigger than you are.
            L01EF: PushStack(player, 0x5D);
            L01F3: PushStack(player, 0x00);
            L01F6: PushStack(player, ax);
            L01F7: PushStack(player, ax);
            L01F8: PushStack(player, 0xB6);
            L01FC: PushStack(player, 0xBD);
05BE  0200 C4 5E 06  les bx, [bp+0x6]
05C1  0203 26 FF 9F D8 00  call far word [es:bx+0xd8]
05C6  0208 83 C4 0C  add sp, 0xc
            L020B: AddEncounter(player, 0x01, 0x19);
            L021D: Compare(PartyCount(player), 0x0001);
            L0228: if (JumpBelowOrEqual) goto L023C;
            L022A: AddEncounter(player, 0x05, 0x1A);
            L023C: Compare(PartyCount(player), 0x0002);
            L0247: if (JumpBelowOrEqual) goto L026D;
            L0249: AddEncounter(player, 0x02, 0x19);
            L025B: AddEncounter(player, 0x06, 0x1A);
            L026D: return; // RETURN (restoring si, di);
        }

        private void Fn_06(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String15FC); // A cold breeze sends shivers down your spine.
            L0010: return; // RETURN;
        }

        private void Fn_07(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1629); // This door leads back to The Foyer of Cawdor.
            L0010: PushStack(player, 0x03);
            L0014: PushStack(player, 0xFD);
            L0018: PushStack(player, 0x01);
            L001C: PushStack(player, ax);
0668  001D C4 5E 06  les bx, [bp+0x6]
066B  0020 26 FF 9F BC 00  call far word [es:bx+0xbc]
0670  0025 83 C4 08  add sp, 0x8
            L0028: return; // RETURN;
        }

        private void Fn_08(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x04));
            L0016: if (JumpNotEqual) goto L003F;
            L0018: SetFlag(player, 0x03, 0x04, 0x01);
            L002D: ShowMessage(player, String1656); // This room is filled with all manner of brushes, combs, and buckets.  A fountain bubbles freshly in the corner, supplying water for the buckets and, via troughs, for the horse stalls hereabouts.
06AF  003A B8 18 17  mov ax, 0x1718
            L003D: goto L0042;
            L003F: ShowMessage(player, String17A7); // The grooming room is as you left it.
            L004C: return; // RETURN;
        }

        private void Fn_09(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String17CC); // There.  You're wet now.  I still have no T-Shirt art, so you'll just have to be satisfied with using your ImagiNation.
            L0010: SetFlag(player, 0x02, 0x5B, 0x01);
            L0025: PushStack(player, 0x00);
06EB  0028 C4 5E 06  les bx, [bp+0x6]
06EE  002B 26 FF 9F B0 00  call far word [es:bx+0xb0]
            L0030: cx = PopStack(player);
            L0031: RefreshCompareFlags(ax);
            L0033: if (JumpEqual) goto L0042;
            L0035: ShowMessage(player, String1843); // This is just the kind of behavior that can get you drummed out of the FBI (Filthy Barbarians, Indeed!).
            L0042: return; // RETURN;
        }

        private void Fn_0A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String18AB); // The banging is much louder here.
            L0010: TeleportParty(player, 0x0C, 0x01, 0xA8, 0x01, isForwardMove);
            L002B: return; // RETURN;
        }

        private void Fn_0B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String18AB); // The banging is much louder here.
            L0010: return; // RETURN;
        }

        private void FnNVIL_0C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x06));
            L0016: if (JumpNotEqual) goto L0046;
            L0018: Compare(GetFacing(player), 0x0001);
            L0022: if (JumpNotEqual) goto L0046;
            L0024: SetFlag(player, 0x03, 0x06, 0x01);
            L0039: ShowMessage(player, String18CC); // Holy Mother of Pearl!  The entire wall swiveled sideways and, well, here you are!
            L0046: return; // RETURN;
        }

        private void Fn_0D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFlag(player, 0x03, 0x06, 0x01);
            L0018: return; // RETURN;
        }

        private void Fn_0E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x05));
            L0016: if (JumpNotEqual) goto L003F;
            L0018: SetFlag(player, 0x03, 0x05, 0x01);
            L002D: ShowMessage(player, String191E); // This room is filled with everything a thirteenth century veterinarian could want to treat a sick horse.  Aside from shelves stocked full of remedies, there are also restraints, slings, picks, files, and bandages.
07E2  003A B8 F3 19  mov ax, 0x19f3
            L003D: goto L0042;
            L003F: ShowMessage(player, String1A43); // The veterinarium is as you left it.
            L004C: return; // RETURN;
        }

        private void Fn_0F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetRace(player), 0x0001);
            L000D: if (JumpEqual) goto L0032;
            L000F: Compare(GetRace(player), 0x0002);
            L0019: if (JumpEqual) goto L0032;
            L001B: Compare(GetRace(player), 0x0003);
            L0025: if (JumpEqual) goto L0032;
            L0027: RefreshCompareFlags(GetRace(player));
            L0030: if (JumpNotEqual) goto L0037;
0828  0032 B8 67 1A  mov ax, 0x1a67
            L0035: goto L003A;
            L0037: ShowMessage(player, String1AA5); // You are too short to see over the dutch door, but the stall sounds quiet.
            L0044: return; // RETURN;
        }

        private void Fn_10(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetRace(player), 0x0001);
            L000D: if (JumpEqual) goto L0032;
            L000F: Compare(GetRace(player), 0x0002);
            L0019: if (JumpEqual) goto L0032;
            L001B: Compare(GetRace(player), 0x0003);
            L0025: if (JumpEqual) goto L0032;
            L0027: RefreshCompareFlags(GetRace(player));
            L0030: if (JumpNotEqual) goto L0037;
086E  0032 B8 EF 1A  mov ax, 0x1aef
            L0035: goto L003A;
            L0037: ShowMessage(player, String1B3D); // You are too short to see over the dutch door, but you think you hear the sounds of movement.
            L0044: return; // RETURN;
        }

        private void Fn_11(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x07), 0x0001);
            L0017: if (JumpNotEqual) goto L0028;
            L0019: ShowMessage(player, String1B9A); // There is nothing still lurking in these shadows.  Or, rather, if there is still something lurking, it is darned good at lurking and shows no inclination to stop.
            L0026: goto L006E;
            L0028: SetFlag(player, 0x03, 0x07, 0x01);
            L003D: ShowMessage(player, String1C3C); // No need to panic.  It's only bats.  Big, bloodthirsty bats, but still only bats.
            L004A: AddEncounter(player, 0x01, 0x22);
            L005C: AddEncounter(player, 0x02, 0x22);
            L006E: return; // RETURN;
        }

        private void Fn_12(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x08), 0x0001);
            L0017: if (JumpNotEqual) goto L0028;
            L0019: ShowMessage(player, String1C8D); // No more bats here, or at least no more bats with a taste for flesh.
            L0026: goto L006E;
            L0028: SetFlag(player, 0x03, 0x08, 0x01);
            L003D: ShowMessage(player, String1CD1); // You're not sure, but you think they're humming 'The Battle Hymn of the Republic.'
            L004A: AddEncounter(player, 0x01, 0x22);
            L005C: AddEncounter(player, 0x02, 0x22);
            L006E: return; // RETURN;
        }

        private void Fn_13(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x09), 0x0001);
            L0017: if (JumpNotEqual) goto L0028;
            L0019: ShowMessage(player, String1D23); // This stall has been thoroughly debatted.
            L0026: goto L006E;
            L0028: SetFlag(player, 0x03, 0x09, 0x01);
            L003D: ShowMessage(player, String1D4C); // You better batten down your hatches.
            L004A: AddEncounter(player, 0x01, 0x22);
            L005C: AddEncounter(player, 0x02, 0x25);
            L006E: return; // RETURN;
        }

        private void Fn_14(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x0A), 0x0001);
            L0017: if (JumpNotEqual) goto L0028;
            L0019: ShowMessage(player, String1D71); // The stall is no longer occupied.
            L0026: goto L006E;
            L0028: SetFlag(player, 0x03, 0x0A, 0x01);
            L003D: ShowMessage(player, String1D92); // Uh oh!  Prepare to be battered!
            L004A: AddEncounter(player, 0x01, 0x22);
            L005C: AddEncounter(player, 0x02, 0x25);
            L006E: return; // RETURN;
        }

        private void Fn_15(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x0B), 0x0001);
            L0017: if (JumpNotEqual) goto L0028;
            L0019: ShowMessage(player, String1DB2); // It's quiet here.  Almost too quiet.  Almost, but not quite.
            L0026: goto L006E;
            L0028: SetFlag(player, 0x03, 0x0B, 0x01);
            L003D: ShowMessage(player, String1DEE); // 'Tis a batty batch!
            L004A: AddEncounter(player, 0x01, 0x22);
            L005C: AddEncounter(player, 0x02, 0x25);
            L006E: return; // RETURN;
        }

        private void Fn_16(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x0C), 0x0001);
            L0017: if (JumpNotEqual) goto L0028;
            L0019: ShowMessage(player, String1E02); // The only time you ever saw a stall this empty, you were trying to convince the birthday boy not to go home before his surprise party was set up.
            L0026: goto L007B;
            L0028: SetFlag(player, 0x03, 0x0C, 0x01);
            L003D: ShowMessage(player, String1E93); // You better get ready for the bloodbat!
            L004A: ShowMessage(player, String1EBA); // I know, I know, it's dreadful, but how many bad bat jokes must one man write?
            L0057: AddEncounter(player, 0x01, 0x22);
            L0069: AddEncounter(player, 0x02, 0x25);
            L007B: return; // RETURN;
        }

        private void Fn_17(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x0D), 0x0001);
            L0017: if (JumpNotEqual) goto L0029;
            L0019: ShowMessage(player, String1F08); // This box has been thoroughly decatted.
            L0026: goto L00DE;
            L0029: SetFlag(player, 0x03, 0x0D, 0x01);
            L003E: ShowMessage(player, String1F2F); // Did I say small and flitting?  Boy, I better make that appointment with the optometrist soon!
            L004B: AddEncounter(player, 0x01, 0x1E);
            L005D: AddEncounter(player, 0x02, 0x20);
            L006F: Compare(PartyCount(player), 0x0001);
            L007A: if (JumpBelowOrEqual) goto L008E;
            L007C: AddEncounter(player, 0x03, 0x19);
            L008E: Compare(PartyCount(player), 0x0002);
            L0099: if (JumpBelowOrEqual) goto L00AD;
            L009B: AddEncounter(player, 0x04, 0x19);
            L00AD: Compare(PartyCount(player), 0x0003);
            L00B8: if (JumpBelowOrEqual) goto L00DE;
            L00BA: AddEncounter(player, 0x05, 0x19);
            L00CC: AddEncounter(player, 0x06, 0x19);
            L00DE: return; // RETURN;
        }

        private void Fn_18(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x0E), 0x0001);
            L0017: if (JumpNotEqual) goto L0028;
            L0019: ShowMessage(player, String1F8D); // No, I guess there wasn't anything flitting around back here.
            L0026: goto L006E;
            L0028: SetFlag(player, 0x03, 0x0E, 0x01);
            L003D: ShowMessage(player, String1FCA); // It's incredible, I know, but somehow those bats are about 83 percent teeth!
            L004A: AddEncounter(player, 0x01, 0x22);
            L005C: AddEncounter(player, 0x02, 0x25);
            L006E: return; // RETURN;
        }

        private void Fn_19(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x0F), 0x0001);
            L0017: if (JumpNotEqual) goto L0028;
            L0019: ShowMessage(player, String2016); // The cat's away.  I guess you can play.
            L0026: goto L009F;
            L0028: SetFlag(player, 0x03, 0x0F, 0x01);
            L003D: ShowMessage(player, String203D); // This must be the downhill end of the Stables, because it looks like all the world's cats have flowed down here.  And let me tell you, they did not want to have their nap interrupted!
            L004A: AddEncounter(player, 0x01, 0x1F);
            L005C: AddEncounter(player, 0x02, 0x1D);
            L006E: Compare(PartyCount(player), 0x0001);
            L0079: if (JumpBelowOrEqual) goto L009F;
            L007B: AddEncounter(player, 0x03, 0x21);
            L008D: AddEncounter(player, 0x04, 0x21);
            L009F: return; // RETURN;
        }

        private void Fn_1A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x14));
            L0016: if (JumpNotEqual) goto L0046;
            L0018: ShowMessage(player, String20F4); // You stumble over something.
            L0025: GiveItem(player, 0xD2);
            L0031: SetFlag(player, 0x03, 0x14, 0x01);
            L0046: return; // RETURN;
        }

        private void Fn_1B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x15));
            L0016: if (JumpNotEqual) goto L0046;
            L0018: ShowMessage(player, String20F4); // You stumble over something.
            L0025: GiveItem(player, 0xD2);
            L0031: SetFlag(player, 0x03, 0x15, 0x01);
            L0046: return; // RETURN;
        }

        private void Fn_1C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x16));
            L0016: if (JumpNotEqual) goto L0046;
            L0018: ShowMessage(player, String20F4); // You stumble over something.
            L0025: GiveItem(player, 0xD2);
            L0031: SetFlag(player, 0x03, 0x16, 0x01);
            L0046: return; // RETURN;
        }

        private void Fn_1D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x17));
            L0016: if (JumpNotEqual) goto L0046;
            L0018: ShowMessage(player, String20F4); // You stumble over something.
            L0025: GiveItem(player, 0xD2);
            L0031: SetFlag(player, 0x03, 0x17, 0x01);
            L0046: return; // RETURN;
        }

        private void Fn_1E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x18));
            L0016: if (JumpNotEqual) goto L0046;
            L0018: ShowMessage(player, String20F4); // You stumble over something.
            L0025: GiveItem(player, 0x01);
            L0031: SetFlag(player, 0x03, 0x18, 0x01);
            L0046: return; // RETURN;
        }

        private void Fn_20(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x11));
            L0016: if (JumpNotEqual) goto L003A;
            L0018: SetFlag(player, 0x03, 0x11, 0x01);
            L002D: ShowMessage(player, String2110); // This appears to be a hay storage area.  It is full of horse forage.  At the end of the large room there used to be double doors, but they have been blocked by a landslide outside.
            L003A: return; // RETURN;
        }

        private void Fn_21(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: si = GetFlag(player, 0x02, 0x5C);
            L0017: RefreshCompareFlags(GetFlag(player, 0x03, 0x12));
            L002A: if (JumpNotEqual) goto L0051;
            L002C: SetFlag(player, 0x03, 0x12, 0x01);
            L0041: ShowMessage(player, String21C4); // There used to be double doors leading out from here, but they are blocked by large quantities of dirt and rocks.  Whether this was a landslide or just deliberate mischief is unknowable.
            L004E: goto L0116;
            L0051: Compare(si, 0x0C);
            L0054: if (JumpLessOrEqual) goto L005B;
0F1F  0056 B8 7E 22  mov ax, 0x227e
            L0059: goto L0044;
            L005B: bx = si;
            L005D: Compare(bx, 0x0A);
            L0060: if (JumpBelowOrEqual) goto L0065;
            L0062: goto L00FB;
            L0065: switch (bx) {
                case 0:
                    goto L006C;
                case 1:
                    goto L007C;
                case 2:
                    goto L0081;
                case 3:
                    goto L0086;
                case 4:
                    goto L0098;
                case 5:
                    goto L009D;
                case 6:
                    goto L00A2;
                case 7:
                    goto L00A7;
                case 8:
                    goto L00B9;
                case 9:
                    goto L00BE;
                case 10:
                    goto L00DD;
            }
            L006C: ShowMessage(player, String227E); // The back door to the stables is still blocked.
            L0079: goto L00FB;
0F45  007C B8 AD 22  mov ax, 0x22ad
            L007F: goto L006F;
0F4A  0081 B8 D7 22  mov ax, 0x22d7
            L0084: goto L006F;
            L0086: ShowMessage(player, String2338); // Wow!  Ahead of you the gates of heaven shine brightly.  Eternal joy awaits you!  Hosanna!  Hosanna!
0F5C  0093 B8 9C 23  mov ax, 0x239c
            L0096: goto L006F;
0F61  0098 B8 D6 23  mov ax, 0x23d6
            L009B: goto L006F;
0F66  009D B8 F6 23  mov ax, 0x23f6
            L00A0: goto L006F;
0F6B  00A2 B8 6C 24  mov ax, 0x246c
            L00A5: goto L006F;
            L00A7: ShowMessage(player, String2516); // I have reviewed your plan to clear the door.  I'll let you invent tempered steel, the internal combustion engine, and vulcanized tires.  I am too kind.
0F7D  00B4 B8 AE 25  mov ax, 0x25ae
            L00B7: goto L006F;
0F82  00B9 B8 D5 25  mov ax, 0x25d5
            L00BC: goto L006F;
            L00BE: ShowMessage(player, String268D); // In utter frustration you take a running charge at the pile of rubble blocking the door.
            L00CB: DamagePlayer(player, 0x0002);
0FA1  00D8 B8 E5 26  mov ax, 0x26e5
            L00DB: goto L006F;
            L00DD: ShowMessage(player, String2738); // All right already!  You have proven your diligence.  Here is a small reward.  Now stop bothering the nice door; what did it ever do to you?
            L00EA: AddExperience(player, 0x000001F4);
            L00FB: si = si + 1;
            L00FC: Compare(si, 0x0A);
            L00FF: if (JumpNotEqual) goto L0104;
            L0101: si = 0x000D;
            L0104: SetFlag(player, 0xC4, 0xB8, si);
            L0116: return; // RETURN (restoring si);
        }

        private void Fn_22(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x13));
            L0016: if (JumpNotEqual) goto L0032;
            L0018: SetFlag(player, 0x03, 0x13, 0x01);
1025  002D B8 C4 27  mov ax, 0x27c4
            L0030: goto L0035;
            L0032: ShowMessage(player, String283F); // The windows are still blocked.  Hey, if there wasn't some serious disrepair here and there we'd have named this place The Fixed of Cawdor.
            L003F: return; // RETURN;
        }

        private void Fn_23(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String28CA); // You find an assortment of files.
            L0010: ax = HasItem(player, 0xD3);
            L001E: if (JumpEqual) goto L0039;
            L0020: ShowMessage(player, String28EB); // Not that I know what you might want to do with it, but here's one that looks interesting.
            L002D: GiveItem(player, 0xD6);
            L0039: return; // RETURN;
        }

        private void Fn_24(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String2945); // You find an assortment of saws.  You'd take that nice electric table saw, but you haven't seen an electrical outlet since entering Cawdor.
            L0010: ShowMessage(player, String29D0); // Neither have you found any gasoline for that chainsaw.
            L001D: ShowMessage(player, String2A07); // In general disappointment you test the handsaws.  Much to your surprise, you find one with a good heft.  Life isn't all bad after all.
            L002A: GiveItem(player, 0xD7);
            L0036: return; // RETURN;
        }

        private void Fn_25(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String2A8E); // You find an assortment of grommeting tools and riveting punches.  This one seems marginally more useful than the others.
            L0010: GiveItem(player, 0xDE);
            L001C: return; // RETURN;
        }

        private void Fn_26(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String2B07); // You find an assortment of implements for cleaning, roughening, smoothing, and polishing.
            L0010: ax = HasItem(player, 0xD5);
            L001E: if (JumpEqual) goto L0039;
            L0020: ShowMessage(player, String28EB); // Not that I know what you might want to do with it, but here's one that looks interesting.
            L002D: GiveItem(player, 0xDF);
            L0039: return; // RETURN;
        }

        private void Fn_27(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String2B60); // You find enough grips, clamps, and pliers to handle the even the spikiest hairdo!
            L0010: ax = HasItem(player, 0xD2);
            L001E: if (JumpEqual) goto L0049;
            L0020: ax = HasItem(player, 0xE0);
            L002E: if (JumpEqual) goto L0049;
            L0030: ShowMessage(player, String2BB2); // In fact, these are the very 'Tongs of Terror' that Master Hieronymous Snivel will be wielding on innocent toothache victims a few years hence.
            L003D: GiveItem(player, 0xE3);
            L0049: return; // RETURN;
        }

        private void Fn_28(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String2C41); // You find an assortment of hammers, mallets, and other tools for beating and straightening metal.
            L0010: GiveItem(player, 0xE4);
            L001C: return; // RETURN;
        }

        private void Fn_29(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x19));
            L0016: if (JumpNotEqual) goto L0047;
            L0018: SetFlag(player, 0x03, 0x19, 0x01);
            L002D: ShowMessage(player, String2CA2); // This place has all the familiar odors of a well kept stable: horses, leather, hay, sweat.  Somewhere to the south someone is banging, making a lot of noise.
            L003A: ShowMessage(player, String2D3F); // I said familiar, not pleasant.
            L0047: return; // RETURN;
        }

    }
}
