#pragma warning disable
using System.Collections.Generic;
using XPT.WorldData;
using XPT.WorldData.Yserbius;

namespace XPT.Scripts.Yserbius.Maps {
    class YserMap29 : AMapScripted {
        protected override int MapIndex => 29;
        protected override int RandomEncounterChance => 10;
        protected override int RandomEncounterExtraCount => 1;

        public YserMap29() {
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
            MapEvent22 = Fn_22;
            MapEvent23 = Fn_23;
            MapEvent24 = Fn_24;
            MapEvent25 = Fn_25;
            MapEvent26 = Fn_26;
            MapEvent27 = Fn_27;
            MapEvent28 = Fn_28;
        }
        
        // === Strings ================================================
        private const string String0140 = "A cold breeze sends shivers down your spine.";
        private const string String016D = "You've uncovered a hidden door!";
        private const string String018D = "You have unlocked the hidden door!";
        private const string String01B0 = "Your lockpick is no more.  It has ceased to key.  It's a stick.  Bereft of heft, it rests in pieces.  This is an ex-lockpick.";
        private const string String022E = "You detect a hidden door, but it is locked.";
        private const string String025A = "That was a stiff lock, but you finally got it open.";
        private const string String028E = "Funny how an irksome little lock on a flimsy little door can keep out a big strong person like you.";
        private const string String02F2 = "You find some tracks indicating that something, or someone, headed off to the northeast from here.";
        private const string String0355 = "You hear some footsteps running away.";
        private const string String037B = "You hear someone strolling towards you.";
        private const string String03A3 = "The gnome greets you heartily.";
        private const string String03C2 = "'I know not whether thou art a wizard, but I can see by the sharpness of thy ascending tool that thou art wise indeed.  Good day!'";
        private const string String0445 = "'A word to the wise for thee.  We wizards know full well the importance of proper filing, an thou intends to assay the most difficult tasks.  Good day.'";
        private const string String04DE = "The dragon examines you with a hint of recognition.";
        private const string String0512 = "'Ah!  Whither hast thou been? I have heard yet another green dragon joke, and my thoughts turned to thee.  Wouldst hear it?'";
        private const string String058F = "You nod.";
        private const string String0598 = "'What is the difference between the village idiot and a green dragon?'";
        private const string String05DF = "You ask what.";
        private const string String05ED = "'The idiot's breath only smells like flames!'";
        private const string String061B = "The dragon lies on the floor, laughing uncontrollably.  You would shake your head, but prudence dictates a quiet retreat.";
        private const string String0695 = "'Ah, my friend!  Look not so worried.  I am sure I will hear or devise another green dragon joke before long!'";
        private const string String0704 = "It wouldn't do to say this, but the prospect of yet another dragon joke is why you looked so worried.";
        private const string String076A = "A downtrodden halfling knight ambles aimlessly by you.";
        private const string String07A1 = "'Serves me right to expect anything cobbled together from horseshoes to bear my weight,' she mutters as she passes.";
        private const string String0815 = "A tame trio of trolls decides that you just might be those guys about whom all those nasty rumors are flying, and leave you alone.";
        private const string String0898 = "Hey!  It's not as though it were me who is spreading all those rumors!";
        private const string String08DF = "A large troll ranger, with flat feet and the ever constant expression of disdain common to all jailers, steps forward to greet you.";
        private const string String0963 = "'Not so fast, yonker, not so fast.  These here are the drunk tanks.  Everyone in them was put there for a reason, most for fighting drunk.  So.  Dost thou want to be fighting drunks?'";
        private const string String0A1B = "'Consider thyself warned; the doors in swing easy, but the doors out require proof that thou art no longer drunk.'";
        private const string String0A8E = "'Tis not my task to prevent thee, but unless thou hast great skill with a lockpick, or enough sobriety to teleport, once within thou shalt not without.'";
        private const string String0B27 = "You see the guard eying you through slitted lids from a chair leaning against the wall.  He taps his billy club meaningfully, but does not intercede.";
        private const string String0BBD = "This door leads to The Attic.";
        private const string String0BDB = "There is a hole in the floor.  It makes you nervous.";
        private const string String0C10 = "You can now scramble down to the next level.";
        private const string String0C3D = "You take back what you said about Cawdor Keep being well maintained.  This place is awash in debris.  Walls have collapsed, burying doors and passages.  This room did not get its fair share of the redecoration budget.";
        private const string String0D17 = "In fact, there is even a hole in the floor - oh, wait.  That's a hole you climbed up.  Never mind.";
        private const string String0D7A = "Oh, great!  The wall swivelled open and you wound up here.  if I know that ^$%^& game designer, you're going to have to test a lot of walls to get through here.";
        private const string String0E1B = "Yes, this is a drunk tank, reeking of stale odors and lousy hygiene.  Fortunately in cyberspace nobody has to smell.";
        private const string String0E90 = "That is, until version 6.947c with the smellovision interface.";
        private const string String0ECF = "That is, unless they activate the hacker detection, which will spin the CD-ROM fast enough to meltdown.  Then they'll smell a big fat repair bill, mark my words!";
        private const string String0F71 = "So you better watch out; big brother is just a few macros away!";
        private const string String0FB1 = "And if you try connecting your nostrils to your serial port with a ribbon cable we will not be responsible for the results.";
        private const string String102D = "Besides, the parallel port works better.";
        private const string String1056 = "Well, you could hardly think of a better spot for a wall to swivel open.";
        private const string String109F = "Hmm.  If you can just squeeze through all this debris, you might be able to make it through into the Aerie.";
        private const string String110B = "It's times like these that really make you regret that extra banger you had last week at the Rounders tourney, but after a tight squeeze you make it through.";
        private const string String11A9 = "There might be a hole here, but unless someone widens it from the other side (or narrows you) you won't pass it.";
        private const string String121A = "A slightly sooty orc barbarian approaches you, shaking her head in disgust.";
        private const string String1266 = "'When I do lay hands upon that crusty botch of nature that did sell me this so-called lucky pig's foot, I shall show him an altogether new an unnatural way to store it!'";
        private const string String1310 = "'Not only did it fail utterly to hold the wyrms in abeyance, but the stench did blind and confuse me so that I know not how to return to the lower levels!'";
        private const string String13AC = "You give her directions to some stairs.";
        private const string String13D4 = "'I do thank thee and commend thee, good gentles, and warn thee against the cuzeners of Cawdor.'  She departs.";
        private const string String1442 = "'Greetings, greetings!'  Rory's grip is strong and his smile friendly.  'I have finished cataloging yet more of the effects of items, and will gladly share them with thee.";
        private const string String14EE = "'In this room, in the third row from the right and slightly more than halfway down, there is a nest of bats.";
        private const string String155B = "'An thou hast the Wool of Bat, then they will be greatly cowed by thee, and the more easily subdued.";
        private const string String15C0 = "'Then over on the left hand wall, near the center, a group of mummy's live.  Or unlive, an thou dost prefer.";
        private const string String162D = "'An thou hast the Witches Mummy, then thou wilt find them the more easily subdued.  But soft!'  He swivels his head as if to hear a distant sound.";
        private const string String16C0 = "'Ah, I am hearing things, and I am using thee as a pleasant diversion from my real task.  Wish me luck, good friend.  The road grows ever steeper, and I must see it through.'";
        private const string String176F = "Oh wretched woe.  You remember meeting Rory here, once upon a happier time.  Ah, well.  A hero's work is never done.  Onwards!";
        private const string String17EE = "A sooty smokey orc knight greets you.";
        private const string String1814 = "'Zwounds!  Good gentle, fear for thy soul, for I have seen the devil's own falconry, bats breathing flames, through this very door.  May thou have better success with them than Sherman, may he rest in peace.'";
        private const string String18E5 = "That knight wasn't kidding.  Batten down the hatches!";
        private const string String191B = "You must possess an awesome fastball, for all that you survey here is a pile of broken bats.";
        private const string String1978 = "Someone here sure suffered from battle fatigue.  You are just glad it wasn't you.";
        private const string String19CA = "Hmm.  Cloth sheets, no fashion sense, completely lacking in social graces.  Yup, these must be the witches mummies.";
        private const string String1A3E = "You proved you were old enough to go without your mummy here.";
        private const string String1A7C = "A badly bruised halfling ranger greets you.";
        private const string String1AA8 = "'By all the twists of unfortunate fate!  I thought the mummies in here would cut me to ribbons!  Forewarned if forearmed, but until I have something to tame them I'm not coming back!'";
        private const string String1B60 = "Well, they may not be the mummies you expected, but they definitely are undead!";
        private const string String1BB0 = "This area is still.  Quiet.  And rich in calcium.";
        private const string String1BE2 = "It's some benighted knights.";
        private const string String1BFF = "Those knights went nighty night.";
        private const string String1C20 = "And they weren't wearing naughty nighties, neither.";
        private const string String1C54 = "It's some wobbly wizards.  And they may not be sober enough for teleports, but they look plenty ready to cast some other spells.";
        private const string String1CD5 = "Those wizards went away.";
        private const string String1CEE = "Heck, if I was dressed like them I'd leave too.";
        private const string String1D1E = "It's some maudlin mages.  Um, make that maddened mages!";
        private const string String1D56 = "Those drunken wizards have been dispelled.";
        private const string String1D81 = "And datspelled and deotherspelled, too.";
        private const string String1DA9 = "The only thing worse than a nasty drunk is a nasty drunken priestess who wants to practise ritual sacrifices on you.";
        private const string String1E1E = "You sure poached those priestesses.";
        private const string String1E42 = "Although they had started cooking with a low blue flame long before you arrived.";
        private const string String1E93 = "It's some groggy goblins!";
        private const string String1EAD = "Those boozy barbarians were easy to polish off.";
        private const string String1EDD = "Easier than getting barbarian stain off your second best tunic's going to be, I'm afraid.";
        private const string String1F37 = "It's a bunch of boozy bloodsuckers!  And some friends!  Hey!  You didn't know undead had friends?  You didn't even know that they drank.";
        private const string String1FC0 = "It serves those vampires right for drinking blood in the drunk tank.";
        private const string String2005 = "And those drunks weren't even a very good vintage!";
        
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
003E  0036 C4 5E 06  les bx, [bp+0x6]
0041  0039 26 FF 5F 54  call far word [es:bx+0x54]
            L003D: cx = PopStack(player);
            L003E: cx = PopStack(player);
            L003F: RefreshCompareFlags(ax);
            L0041: if (JumpNotEqual) goto L008D;
            L0043: PushStack(player, 0x61);
            L0047: PushStack(player, ax);
0050  0048 C4 5E 06  les bx, [bp+0x6]
0053  004B 26 FF 5F 54  call far word [es:bx+0x54]
            L004F: cx = PopStack(player);
            L0050: cx = PopStack(player);
            L0051: RefreshCompareFlags(ax);
            L0053: if (JumpNotEqual) goto L008D;
            L0055: PushStack(player, 0x93);
            L0059: PushStack(player, ax);
0062  005A C4 5E 06  les bx, [bp+0x6]
0065  005D 26 FF 5F 54  call far word [es:bx+0x54]
            L0061: cx = PopStack(player);
            L0062: cx = PopStack(player);
            L0063: RefreshCompareFlags(ax);
            L0065: if (JumpNotEqual) goto L008D;
            L0067: PushStack(player, 0x86);
            L006B: PushStack(player, ax);
0074  006C C4 5E 06  les bx, [bp+0x6]
0077  006F 26 FF 5F 54  call far word [es:bx+0x54]
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
00D4  00CC C4 5E 06  les bx, [bp+0x6]
00D7  00CF 26 FF 5F 2C  call far word [es:bx+0x2c]
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
0142  0029 C4 5E 06  les bx, [bp+0x6]
0145  002C 26 FF 5F 54  call far word [es:bx+0x54]
            L0030: cx = PopStack(player);
            L0031: cx = PopStack(player);
            L0032: RefreshCompareFlags(ax);
            L0034: if (JumpNotEqual) goto L0083;
            L0036: PushStack(player, 0x61);
            L003A: PushStack(player, ax);
0154  003B C4 5E 06  les bx, [bp+0x6]
0157  003E 26 FF 5F 54  call far word [es:bx+0x54]
            L0042: cx = PopStack(player);
            L0043: cx = PopStack(player);
            L0044: RefreshCompareFlags(ax);
            L0046: if (JumpNotEqual) goto L0083;
            L0048: PushStack(player, 0x93);
            L004C: PushStack(player, ax);
0166  004D C4 5E 06  les bx, [bp+0x6]
0169  0050 26 FF 5F 54  call far word [es:bx+0x54]
            L0054: cx = PopStack(player);
            L0055: cx = PopStack(player);
            L0056: RefreshCompareFlags(ax);
            L0058: if (JumpNotEqual) goto L0083;
            L005A: PushStack(player, 0x86);
            L005E: PushStack(player, ax);
0178  005F C4 5E 06  les bx, [bp+0x6]
017B  0062 26 FF 5F 54  call far word [es:bx+0x54]
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
01C2  00A9 C4 5E 06  les bx, [bp+0x6]
01C5  00AC 26 FF 1F  call far word [es:bx]
01C8  00AF 83 C4 06  add sp, 0x6
            L00B2: PushStack(player, 0x68);
            L00B6: PushStack(player, ax);
01D0  00B7 C4 5E 06  les bx, [bp+0x6]
01D3  00BA 26 FF 5F 54  call far word [es:bx+0x54]
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
0228  010F C4 5E 06  les bx, [bp+0x6]
022B  0112 26 FF 5F 54  call far word [es:bx+0x54]
            L0116: cx = PopStack(player);
            L0117: cx = PopStack(player);
            L0118: RefreshCompareFlags(ax);
            L011A: if (JumpEqual) goto L012F;
            L011C: ShowMessage(player, String018D); // You have unlocked the hidden door!
0242  0129 B8 01 00  mov ax, 0x1
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
0300  0008 C4 5E 06  les bx, [bp+0x6]
0303  000B 26 FF 5F 54  call far word [es:bx+0x54]
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
0363  006B C4 5E 06  les bx, [bp+0x6]
0366  006E 26 FF 5F 54  call far word [es:bx+0x54]
            L0072: cx = PopStack(player);
            L0073: cx = PopStack(player);
            L0074: RefreshCompareFlags(ax);
            L0076: if (JumpNotEqual) goto L009F;
            L0078: ax = HasUsedItem(player, 0xDA, 0xDD);
            L008B: if (JumpNotEqual) goto L009F;
            L008D: PushStack(player, 0xC0);
            L0091: PushStack(player, ax);
038A  0092 C4 5E 06  les bx, [bp+0x6]
038D  0095 26 FF 5F 54  call far word [es:bx+0x54]
            L0099: cx = PopStack(player);
            L009A: cx = PopStack(player);
            L009B: RefreshCompareFlags(ax);
            L009D: if (JumpEqual) goto L00CD;
            L009F: ShowMessage(player, String025A); // That was a stiff lock, but you finally got it open.
            L00AC: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L00CA: goto L0152;
            L00CD: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L00EA: ax = HasUsedItem(player, 0xC1, 0xC3);
            L00FD: if (JumpEqual) goto L0128;
            L00FF: RemoveItem(player, 0xC1);
            L010B: RemoveItem(player, 0xC2);
            L0117: RemoveItem(player, 0xC3);
041B  0123 B8 B0 01  mov ax, 0x1b0
            L0126: goto L0148;
            L0128: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0145: ShowMessage(player, String028E); // Funny how an irksome little lock on a flimsy little door can keep out a big strong person like you.
            L0152: return; // RETURN;
        }

        private void Fn_04(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, 0x0B), 0x0009);
            L0012: if (JumpNotBelow) goto L0038;
            L0014: PushStack(player, 0x62);
            L0018: PushStack(player, ax);
0465  0019 C4 5E 06  les bx, [bp+0x6]
0468  001C 26 FF 5F 54  call far word [es:bx+0x54]
            L0020: cx = PopStack(player);
            L0021: cx = PopStack(player);
            L0022: RefreshCompareFlags(ax);
            L0024: if (JumpNotEqual) goto L0038;
            L0026: PushStack(player, 0x8F);
            L002A: PushStack(player, ax);
0477  002B C4 5E 06  les bx, [bp+0x6]
047A  002E 26 FF 5F 54  call far word [es:bx+0x54]
            L0032: cx = PopStack(player);
            L0033: cx = PopStack(player);
            L0034: RefreshCompareFlags(ax);
            L0036: if (JumpEqual) goto L005A;
            L0038: ShowMessage(player, String02F2); // You find some tracks indicating that something, or someone, headed off to the northeast from here.
            L0045: SetFlag(player, 0x03, 0x09, 0x01);
            L005A: return; // RETURN;
        }

        private void Fn_05(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si, di);
            L0005: di = 0;
            L0007: si = 0;
            L0009: ax = GetFlag(player, 0x02, 0x53);
04C2  001A 8B F8  mov di, ax
04C4  001C 47     inc di
04C5  001D 8B F7  mov si, di
            L001F: Compare(si, 0x13);
            L0022: if (JumpLessOrEqual) goto L002B;
04CC  0024 8B C6  mov ax, si
            L0026: si = ax + 0xFFEC;
            L002B: Compare(si, 0x0E);
            L002E: if (JumpLessOrEqual) goto L0037;
04D8  0030 8B C6  mov ax, si
            L0032: si = ax + 0xFFF1;
            L0037: Compare(si, 0x09);
            L003A: if (JumpLessOrEqual) goto L0043;
04E4  003C 8B C6  mov ax, si
            L003E: si = ax + 0xFFF6;
            L0043: Compare(si, 0x04);
            L0046: if (JumpLessOrEqual) goto L004F;
04F0  0048 8B C6  mov ax, si
            L004A: si = ax + 0xFFFB;
04F7  004F 0B F6  or si, si
04F9  0051 7D 02  jge 0x55
            L0053: si = 0;
            L0055: Compare(si, 0x1D);
            L0058: if (JumpLessOrEqual) goto L005C;
            L005A: si = 0;
0504  005C 83 FF 1E  cmp di, 0x1e
            L005F: if (JumpLessOrEqual) goto L0063;
            L0061: di = 0;
050B  0063 57     push di
            L0064: PushStack(player, 0x53);
            L0068: PushStack(player, 0x02);
0514  006C C4 5E 06  les bx, [bp+0x6]
0517  006F 26 FF 1F  call far word [es:bx]
051A  0072 83 C4 06  add sp, 0x6
051D  0075 83 FF 1A  cmp di, 0x1a
            L0078: if (JumpNotEqual) goto L007F;
0522  007A B8 01 00  mov ax, 0x1
            L007D: goto L0081;
            L007F: PushStack(player, 0x00);
052A  0082 83 FF 14  cmp di, 0x14
            L0085: if (JumpNotEqual) goto L008C;
052F  0087 B8 01 00  mov ax, 0x1
            L008A: goto L008E;
0534  008C 33 C0  xor ax, ax
            L008E: dx = PopStack(player);
0537  008F 0B D0  or dx, ax
            L0091: PushStack(player, dx);
053A  0092 83 FF 0E  cmp di, 0xe
            L0095: if (JumpNotEqual) goto L009C;
053F  0097 B8 01 00  mov ax, 0x1
            L009A: goto L009E;
0544  009C 33 C0  xor ax, ax
            L009E: dx = PopStack(player);
0547  009F 0B D0  or dx, ax
            L00A1: PushStack(player, dx);
054A  00A2 83 FF 08  cmp di, 0x8
            L00A5: if (JumpNotEqual) goto L00AC;
054F  00A7 B8 01 00  mov ax, 0x1
            L00AA: goto L00AE;
0554  00AC 33 C0  xor ax, ax
            L00AE: dx = PopStack(player);
0557  00AF 0B D0  or dx, ax
            L00B1: PushStack(player, dx);
055A  00B2 83 FF 02  cmp di, 0x2
            L00B5: if (JumpNotEqual) goto L00BC;
055F  00B7 B8 01 00  mov ax, 0x1
            L00BA: goto L00BE;
0564  00BC 33 C0  xor ax, ax
            L00BE: dx = PopStack(player);
0567  00BF 0B D0  or dx, ax
            L00C1: if (JumpNotEqual) goto L00C6;
            L00C3: goto L020C;
            L00C6: bx = si;
            L00C8: Compare(bx, 0x04);
            L00CB: if (JumpBelowOrEqual) goto L00D0;
            L00CD: goto L020C;
            L00D0: switch (bx) {
                case 0:
                    goto L00D7;
                case 1:
                    goto L00DD;
                case 2:
                    goto L0120;
                case 3:
                    goto L01C6;
                case 4:
                    goto L01E5;
            }
057F  00D7 B8 55 03  mov ax, 0x355
            L00DA: goto L0202;
            L00DD: ShowMessage(player, String037B); // You hear someone strolling towards you.
            L00EA: ShowPortrait(player, 0x002D);
            L00F7: ShowMessage(player, String03A3); // The gnome greets you heartily.
            L0104: ax = HasItem(player, 0xD4);
            L0112: if (JumpEqual) goto L011A;
05BC  0114 B8 C2 03  mov ax, 0x3c2
            L0117: goto L0202;
05C2  011A B8 45 04  mov ax, 0x445
            L011D: goto L0202;
            L0120: ShowPortrait(player, 0x000E);
            L012D: RefreshCompareFlags(GetFlag(player, 0x02, 0x56));
            L0140: if (JumpNotEqual) goto L01B4;
            L0142: ShowMessage(player, String04DE); // The dragon examines you with a hint of recognition.
            L014F: ShowMessage(player, String0512); // 'Ah!  Whither hast thou been? I have heard yet another green dragon joke, and my thoughts turned to thee.  Wouldst hear it?'
            L015C: ShowMessage(player, String058F); // You nod.
            L0169: ShowMessage(player, String0598); // 'What is the difference between the village idiot and a green dragon?'
            L0176: ShowMessage(player, String05DF); // You ask what.
            L0183: ShowMessage(player, String05ED); // 'The idiot's breath only smells like flames!'
            L0190: ShowMessage(player, String061B); // The dragon lies on the floor, laughing uncontrollably.  You would shake your head, but prudence dictates a quiet retreat.
            L019D: SetFlag(player, 0x02, 0x56, 0x01);
            L01B2: goto L020C;
            L01B4: ShowMessage(player, String0695); // 'Ah, my friend!  Look not so worried.  I am sure I will hear or devise another green dragon joke before long!'
0669  01C1 B8 04 07  mov ax, 0x704
            L01C4: goto L0202;
            L01C6: ShowPortrait(player, 0x001D);
            L01D3: ShowMessage(player, String076A); // A downtrodden halfling knight ambles aimlessly by you.
0688  01E0 B8 A1 07  mov ax, 0x7a1
            L01E3: goto L0202;
            L01E5: ShowPortrait(player, 0x001B);
            L01F2: ShowMessage(player, String0815); // A tame trio of trolls decides that you just might be those guys about whom all those nasty rumors are flying, and leave you alone.
            L01FF: ShowMessage(player, String0898); // Hey!  It's not as though it were me who is spreading all those rumors!
            L020C: return; // RETURN (restoring si, di);
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
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x10));
            L0016: if (JumpNotEqual) goto L0066;
            L0018: SetFlag(player, 0x03, 0x10, 0x01);
            L002D: ShowPortrait(player, 0x0020);
            L003A: ShowMessage(player, String08DF); // A large troll ranger, with flat feet and the ever constant expression of disdain common to all jailers, steps forward to greet you.
            L0047: ShowMessage(player, String0963); // 'Not so fast, yonker, not so fast.  These here are the drunk tanks.  Everyone in them was put there for a reason, most for fighting drunk.  So.  Dost thou want to be fighting drunks?'
            L0054: ShowMessage(player, String0A1B); // 'Consider thyself warned; the doors in swing easy, but the doors out require proof that thou art no longer drunk.'
0735  0061 B8 8E 0A  mov ax, 0xa8e
            L0064: goto L0069;
            L0066: ShowMessage(player, String0B27); // You see the guard eying you through slitted lids from a chair leaning against the wall.  He taps his billy club meaningfully, but does not intercede.
            L0073: return; // RETURN;
        }

        private void Fn_08(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0BBD); // This door leads to The Attic.
            L0010: TeleportParty(player, 0x0B, 0x03, 0x30, 0x02, isForwardMove);
            L002B: return; // RETURN;
        }

        private void Fn_09(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x02);
            L0007: PushStack(player, 0x00);
0780  000A C4 5E 06  les bx, [bp+0x6]
0783  000D 26 FF 5F 04  call far word [es:bx+0x4]
            L0011: cx = PopStack(player);
            L0012: cx = PopStack(player);
            L0013: Compare(ax, 0x0001);
            L0016: if (JumpNotEqual) goto L0051;
            L0018: PushStack(player, 0x00);
            L001B: PushStack(player, 0x02);
            L001F: PushStack(player, 0x00);
0798  0022 C4 5E 06  les bx, [bp+0x6]
079B  0025 26 FF 1F  call far word [es:bx]
079E  0028 83 C4 06  add sp, 0x6
            L002B: TeleportParty(player, 0x0B, 0x01, GetCurrentTile(player), GetFacing(player), isForwardMove);
            L004E: goto L00DA;
            L0051: PushStack(player, 0x03);
            L0055: PushStack(player, 0x00);
07CE  0058 C4 5E 06  les bx, [bp+0x6]
07D1  005B 26 FF 5F 04  call far word [es:bx+0x4]
            L005F: cx = PopStack(player);
            L0060: cx = PopStack(player);
            L0061: RefreshCompareFlags(ax);
            L0063: if (JumpNotEqual) goto L0086;
            L0065: ShowMessage(player, String0BDB); // There is a hole in the floor.  It makes you nervous.
            L0072: SetFlag(player, 0x00, 0x03, 0x01);
            L0086: ax = HasUsedItem(player, 0xD3, 0xD4);
            L0099: if (JumpEqual) goto L00DA;
            L009B: SetWallObject(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L00B9: ShowMessage(player, String0C10); // You can now scramble down to the next level.
            L00C6: SetFlag(player, 0x00, 0x02, 0x01);
            L00DA: return; // RETURN;
        }

        private void Fn_0A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x02);
            L0007: PushStack(player, 0x00);
085C  000A C4 5E 06  les bx, [bp+0x6]
085F  000D 26 FF 5F 04  call far word [es:bx+0x4]
            L0011: cx = PopStack(player);
            L0012: cx = PopStack(player);
            L0013: Compare(ax, 0x0001);
            L0016: if (JumpNotEqual) goto L0051;
            L0018: PushStack(player, 0x00);
            L001B: PushStack(player, 0x02);
            L001F: PushStack(player, 0x00);
0874  0022 C4 5E 06  les bx, [bp+0x6]
0877  0025 26 FF 1F  call far word [es:bx]
087A  0028 83 C4 06  add sp, 0x6
            L002B: TeleportParty(player, 0x0B, 0x01, GetCurrentTile(player), GetFacing(player), isForwardMove);
            L004E: goto L0121;
            L0051: RefreshCompareFlags(GetFlag(player, 0x03, 0x0A));
            L0064: if (JumpNotEqual) goto L0098;
            L0066: SetFlag(player, 0x03, 0x0A, 0x01);
            L007B: ShowMessage(player, String0C3D); // You take back what you said about Cawdor Keep being well maintained.  This place is awash in debris.  Walls have collapsed, burying doors and passages.  This room did not get its fair share of the redecoration budget.
            L0088: ShowMessage(player, String0D17); // In fact, there is even a hole in the floor - oh, wait.  That's a hole you climbed up.  Never mind.
            L0095: goto L0121;
            L0098: PushStack(player, 0x03);
            L009C: PushStack(player, 0x00);
08F1  009F C4 5E 06  les bx, [bp+0x6]
08F4  00A2 26 FF 5F 04  call far word [es:bx+0x4]
            L00A6: cx = PopStack(player);
            L00A7: cx = PopStack(player);
            L00A8: RefreshCompareFlags(ax);
            L00AA: if (JumpNotEqual) goto L00CD;
            L00AC: SetFlag(player, 0x00, 0x03, 0x01);
            L00C0: ShowMessage(player, String0BDB); // There is a hole in the floor.  It makes you nervous.
            L00CD: ax = HasUsedItem(player, 0xD3, 0xD4);
            L00E0: if (JumpEqual) goto L0121;
            L00E2: SetWallObject(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L0100: ShowMessage(player, String0C10); // You can now scramble down to the next level.
            L010D: SetFlag(player, 0x00, 0x02, 0x01);
            L0121: return; // RETURN;
        }

        private void Fn_0B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x0B, 0x04, 0x6F, 0x03, isForwardMove);
            L001E: return; // RETURN;
        }

        private void Fn_0C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x0B));
            L0016: if (JumpNotEqual) goto L003A;
            L0018: SetFlag(player, 0x03, 0x0B, 0x01);
            L002D: ShowMessage(player, String0D7A); // Oh, great!  The wall swivelled open and you wound up here.  if I know that ^$%^& game designer, you're going to have to test a lot of walls to get through here.
            L003A: return; // RETURN;
        }

        private void Fn_0D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: si = GetFlag(player, 0x02, 0x53);
            L0017: ShowMessage(player, String0E1B); // Yes, this is a drunk tank, reeking of stale odors and lousy hygiene.  Fortunately in cyberspace nobody has to smell.
            L0024: Compare(GetFlag(player, 0x02, 0x53), 0x001C);
            L0038: if (JumpNotEqual) goto L005A;
            L003A: ShowMessage(player, String0E90); // That is, until version 6.947c with the smellovision interface.
            L0047: si = si + 1;
            L0048: SetFlag(player, 0xC4, 0xB8, si);
            L005A: Compare(GetFlag(player, 0x02, 0x53), 0x000E);
            L006E: if (JumpNotEqual) goto L009D;
            L0070: ShowMessage(player, String0ECF); // That is, unless they activate the hacker detection, which will spin the CD-ROM fast enough to meltdown.  Then they'll smell a big fat repair bill, mark my words!
            L007D: ShowMessage(player, String0F71); // So you better watch out; big brother is just a few macros away!
            L008A: si = si + 1;
            L008B: SetFlag(player, 0xC4, 0xB8, si);
            L009D: Compare(GetFlag(player, 0x02, 0x53), 0x0001);
            L00B1: if (JumpNotEqual) goto L00E0;
            L00B3: ShowMessage(player, String0FB1); // And if you try connecting your nostrils to your serial port with a ribbon cable we will not be responsible for the results.
            L00C0: ShowMessage(player, String102D); // Besides, the parallel port works better.
            L00CD: si = si + 1;
            L00CE: SetFlag(player, 0xC4, 0xB8, si);
            L00E0: return; // RETURN (restoring si);
        }

        private void Fn_0E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x02, 0x23));
            L0016: if (JumpNotEqual) goto L002D;
            L0018: SetWallPassable(player, 0x02, 0x03, 0x00);
            L002D: return; // RETURN;
        }

        private void Fn_0F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x0C));
            L0016: if (JumpNotEqual) goto L003A;
            L0018: SetFlag(player, 0x03, 0x0C, 0x01);
            L002D: ShowMessage(player, String1056); // Well, you could hardly think of a better spot for a wall to swivel open.
            L003A: return; // RETURN;
        }

        private void Fn_10(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0x23), 0x0001);
            L0017: if (JumpNotEqual) goto L0046;
            L0019: TeleportParty(player, 0x09, 0x02, 0xF2, 0x03, isForwardMove);
            L0034: ShowMessage(player, String109F); // Hmm.  If you can just squeeze through all this debris, you might be able to make it through into the Aerie.
0B60  0041 B8 0B 11  mov ax, 0x110b
            L0044: goto L0062;
            L0046: SetWallPassable(player, GetCurrentTile(player), 0x03, 0x00);
            L005F: ShowMessage(player, String11A9); // There might be a hole here, but unless someone widens it from the other side (or narrows you) you won't pass it.
            L006C: return; // RETURN;
        }

        private void Fn_11(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x13));
            L0016: if (JumpNotEqual) goto L007B;
            L0018: SetFlag(player, 0x03, 0x13, 0x01);
            L002D: ShowPortrait(player, 0x0017);
            L003A: ShowMessage(player, String121A); // A slightly sooty orc barbarian approaches you, shaking her head in disgust.
            L0047: ShowMessage(player, String1266); // 'When I do lay hands upon that crusty botch of nature that did sell me this so-called lucky pig's foot, I shall show him an altogether new an unnatural way to store it!'
            L0054: ShowMessage(player, String1310); // 'Not only did it fail utterly to hold the wyrms in abeyance, but the stench did blind and confuse me so that I know not how to return to the lower levels!'
            L0061: ShowMessage(player, String13AC); // You give her directions to some stairs.
            L006E: ShowMessage(player, String13D4); // 'I do thank thee and commend thee, good gentles, and warn thee against the cuzeners of Cawdor.'  She departs.
            L007B: return; // RETURN;
        }

        private void Fn_17(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x02, 0x47));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L009B;
            L001B: RefreshCompareFlags(GetFlag(player, 0x03, 0x0D));
            L002E: if (JumpEqual) goto L0033;
            L0030: goto L00D2;
            L0033: ShowPortrait(player, 0x0025);
            L0040: SetFlag(player, 0x03, 0x0D, 0x01);
            L0055: ShowMessage(player, String1442); // 'Greetings, greetings!'  Rory's grip is strong and his smile friendly.  'I have finished cataloging yet more of the effects of items, and will gladly share them with thee.
            L0062: ShowMessage(player, String14EE); // 'In this room, in the third row from the right and slightly more than halfway down, there is a nest of bats.
            L006F: ShowMessage(player, String155B); // 'An thou hast the Wool of Bat, then they will be greatly cowed by thee, and the more easily subdued.
            L007C: ShowMessage(player, String15C0); // 'Then over on the left hand wall, near the center, a group of mummy's live.  Or unlive, an thou dost prefer.
            L0089: ShowMessage(player, String162D); // 'An thou hast the Witches Mummy, then thou wilt find them the more easily subdued.  But soft!'  He swivels his head as if to hear a distant sound.
0CB9  0096 B8 C0 16  mov ax, 0x16c0
            L0099: goto L00C8;
            L009B: RefreshCompareFlags(GetFlag(player, 0x03, 0x0D));
            L00AE: if (JumpNotEqual) goto L00D2;
            L00B0: SetFlag(player, 0x03, 0x0D, 0x01);
            L00C5: ShowMessage(player, String176F); // Oh wretched woe.  You remember meeting Rory here, once upon a happier time.  Ah, well.  A hero's work is never done.  Onwards!
            L00D2: return; // RETURN;
        }

        private void Fn_18(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x0E));
            L0016: if (JumpNotEqual) goto L0054;
            L0018: SetFlag(player, 0x03, 0x0E, 0x01);
            L002D: ShowPortrait(player, 0x001A);
            L003A: ShowMessage(player, String17EE); // A sooty smokey orc knight greets you.
            L0047: ShowMessage(player, String1814); // 'Zwounds!  Good gentle, fear for thy soul, for I have seen the devil's own falconry, bats breathing flames, through this very door.  May thou have better success with them than Sherman, may he rest in peace.'
            L0054: return; // RETURN;
        }

        private void Fn_19(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0xF2);
            L0011: if (JumpEqual) goto L001C;
            L0013: PushStack(player, 0x01);
0D64  0017 B8 AC 00  mov ax, 0xac
            L001A: goto L0023;
            L001C: TeleportParty(player, 0x0B, 0x04, 0x9C, 0x01, isForwardMove);
            L0037: return; // RETURN;
        }

        private void Fn_1A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0xF2);
            L0011: if (JumpEqual) goto L001C;
            L0013: PushStack(player, 0x03);
0D9D  0017 B8 AC 00  mov ax, 0xac
            L001A: goto L0023;
            L001C: TeleportParty(player, 0x0B, 0x04, 0x9C, 0x03, isForwardMove);
            L0037: return; // RETURN;
        }

        private void Fn_1B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x01));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00C2;
            L001B: PushStack(player, 0x01);
            L001F: PushStack(player, ax);
            L0020: PushStack(player, 0x03);
0DE3  0024 C4 5E 06  les bx, [bp+0x6]
0DE6  0027 26 FF 1F  call far word [es:bx]
0DE9  002A 83 C4 06  add sp, 0x6
            L002D: SetFlag(player, 0x03, 0x0E, 0x01);
            L0042: ShowMessage(player, String18E5); // That knight wasn't kidding.  Batten down the hatches!
0E0E  004F B8 4A 1F  mov ax, 0x1f4a
            L0052: PushStack(player, ax);
            L0053: PushStack(player, 0x00);
            L0056: PushStack(player, ax);
            L0057: PushStack(player, ax);
            L0058: PushStack(player, 0xCE);
            L005C: PushStack(player, 0xDD);
0E1F  0060 C4 5E 06  les bx, [bp+0x6]
0E22  0063 26 FF 9F D8 00  call far word [es:bx+0xd8]
0E27  0068 83 C4 0C  add sp, 0xc
            L006B: AddEncounter(player, 0x01, 0x27);
            L007D: AddEncounter(player, 0x05, 0x27);
            L008F: Compare(PartyCount(player), 0x0002);
            L009A: if (JumpBelowOrEqual) goto L00CF;
            L009C: AddEncounter(player, 0x02, 0x26);
            L00AE: AddEncounter(player, 0x06, 0x27);
            L00C0: goto L00CF;
            L00C2: ShowMessage(player, String191B); // You must possess an awesome fastball, for all that you survey here is a pile of broken bats.
            L00CF: return; // RETURN;
        }

        private void Fn_1C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x01));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00C2;
            L001B: PushStack(player, 0x01);
            L001F: PushStack(player, ax);
            L0020: PushStack(player, 0x03);
0EB4  0024 C4 5E 06  les bx, [bp+0x6]
0EB7  0027 26 FF 1F  call far word [es:bx]
0EBA  002A 83 C4 06  add sp, 0x6
            L002D: SetFlag(player, 0x03, 0x0E, 0x01);
            L0042: ShowMessage(player, String18E5); // That knight wasn't kidding.  Batten down the hatches!
0EDF  004F B8 4A 1F  mov ax, 0x1f4a
            L0052: PushStack(player, ax);
            L0053: PushStack(player, 0x00);
            L0056: PushStack(player, ax);
            L0057: PushStack(player, ax);
            L0058: PushStack(player, 0xCE);
            L005C: PushStack(player, 0xDD);
0EF0  0060 C4 5E 06  les bx, [bp+0x6]
0EF3  0063 26 FF 9F D8 00  call far word [es:bx+0xd8]
0EF8  0068 83 C4 0C  add sp, 0xc
            L006B: AddEncounter(player, 0x01, 0x28);
            L007D: AddEncounter(player, 0x05, 0x28);
            L008F: Compare(PartyCount(player), 0x0002);
            L009A: if (JumpBelowOrEqual) goto L00CF;
            L009C: AddEncounter(player, 0x02, 0x28);
            L00AE: AddEncounter(player, 0x06, 0x27);
            L00C0: goto L00CF;
            L00C2: ShowMessage(player, String1978); // Someone here sure suffered from battle fatigue.  You are just glad it wasn't you.
            L00CF: return; // RETURN;
        }

        private void Fn_1D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x02));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00B0;
            L001B: SetFlag(player, 0x03, 0x02, 0x01);
            L0030: ShowMessage(player, String19CA); // Hmm.  Cloth sheets, no fashion sense, completely lacking in social graces.  Yup, these must be the witches mummies.
0F9E  003D B8 EA 2E  mov ax, 0x2eea
            L0040: PushStack(player, ax);
            L0041: PushStack(player, 0x00);
            L0044: PushStack(player, ax);
            L0045: PushStack(player, ax);
            L0046: PushStack(player, 0xCE);
            L004A: PushStack(player, 0xDD);
0FAF  004E C4 5E 06  les bx, [bp+0x6]
0FB2  0051 26 FF 9F D8 00  call far word [es:bx+0xd8]
0FB7  0056 83 C4 0C  add sp, 0xc
            L0059: AddEncounter(player, 0x01, 0x21);
            L006B: AddEncounter(player, 0x05, 0x22);
            L007D: Compare(PartyCount(player), 0x0002);
            L0088: if (JumpBelowOrEqual) goto L00BD;
            L008A: AddEncounter(player, 0x02, 0x21);
            L009C: AddEncounter(player, 0x06, 0x22);
            L00AE: goto L00BD;
            L00B0: ShowMessage(player, String1A3E); // You proved you were old enough to go without your mummy here.
            L00BD: return; // RETURN;
        }

        private void Fn_1E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x02));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00B0;
            L001B: SetFlag(player, 0x03, 0x02, 0x01);
            L0030: ShowMessage(player, String19CA); // Hmm.  Cloth sheets, no fashion sense, completely lacking in social graces.  Yup, these must be the witches mummies.
105D  003D B8 EA 2E  mov ax, 0x2eea
            L0040: PushStack(player, ax);
            L0041: PushStack(player, 0x00);
            L0044: PushStack(player, ax);
            L0045: PushStack(player, ax);
            L0046: PushStack(player, 0xCE);
            L004A: PushStack(player, 0xDD);
106E  004E C4 5E 06  les bx, [bp+0x6]
1071  0051 26 FF 9F D8 00  call far word [es:bx+0xd8]
1076  0056 83 C4 0C  add sp, 0xc
            L0059: AddEncounter(player, 0x01, 0x22);
            L006B: AddEncounter(player, 0x05, 0x23);
            L007D: Compare(PartyCount(player), 0x0002);
            L0088: if (JumpBelowOrEqual) goto L00BD;
            L008A: AddEncounter(player, 0x02, 0x21);
            L009C: AddEncounter(player, 0x06, 0x23);
            L00AE: goto L00BD;
            L00B0: ShowMessage(player, String1A3E); // You proved you were old enough to go without your mummy here.
            L00BD: return; // RETURN;
        }

        private void Fn_1F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x0F));
            L0016: if (JumpNotEqual) goto L0054;
            L0018: SetFlag(player, 0x03, 0x0F, 0x01);
            L002D: ShowPortrait(player, 0x0021);
            L003A: ShowMessage(player, String1A7C); // A badly bruised halfling ranger greets you.
            L0047: ShowMessage(player, String1AA8); // 'By all the twists of unfortunate fate!  I thought the mummies in here would cut me to ribbons!  Forewarned if forearmed, but until I have something to tame them I'm not coming back!'
            L0054: return; // RETURN;
        }

        private void Fn_20(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0xFA);
            L0011: if (JumpEqual) goto L001C;
            L0013: PushStack(player, 0x02);
114C  0017 B8 81 00  mov ax, 0x81
            L001A: goto L0023;
            L001C: TeleportParty(player, 0x0B, 0x04, 0x82, 0x02, isForwardMove);
            L0037: return; // RETURN;
        }

        private void Fn_22(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x03);
            L0007: PushStack(player, ax);
117B  0008 C4 5E 06  les bx, [bp+0x6]
117E  000B 26 FF 5F 04  call far word [es:bx+0x4]
            L000F: cx = PopStack(player);
            L0010: cx = PopStack(player);
            L0011: RefreshCompareFlags(ax);
            L0013: if (JumpEqual) goto L0018;
            L0015: goto L00B2;
            L0018: PushStack(player, 0x01);
            L001C: PushStack(player, 0x03);
            L0020: PushStack(player, ax);
1194  0021 C4 5E 06  les bx, [bp+0x6]
1197  0024 26 FF 1F  call far word [es:bx]
119A  0027 83 C4 06  add sp, 0x6
            L002A: AddEncounter(player, 0x01, 0x25);
            L003C: AddEncounter(player, 0x03, 0x25);
            L004E: AddEncounter(player, 0x04, 0x25);
            L0060: AddEncounter(player, 0x02, 0x25);
            L0072: ShowMessage(player, String1B60); // Well, they may not be the mummies you expected, but they definitely are undead!
            L007F: Compare(PartyCount(player), 0x0003);
            L008A: if (JumpBelowOrEqual) goto L00BF;
            L008C: AddEncounter(player, 0x05, 0x24);
            L009E: AddEncounter(player, 0x06, 0x24);
            L00B0: goto L00BF;
            L00B2: ShowMessage(player, String1BB0); // This area is still.  Quiet.  And rich in calcium.
            L00BF: return; // RETURN;
        }

        private void Fn_23(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x04));
            L0016: if (JumpNotEqual) goto L0095;
            L0018: SetFlag(player, 0x03, 0x04, 0x01);
            L002D: AddEncounter(player, 0x01, 0x1A);
            L003F: AddEncounter(player, 0x05, 0x1A);
            L0051: ShowMessage(player, String1BE2); // It's some benighted knights.
            L005E: Compare(PartyCount(player), 0x0002);
            L0069: if (JumpAbove) goto L006E;
            L006B: goto L0133;
            L006E: AddEncounter(player, 0x02, 0x1A);
            L0080: AddEncounter(player, 0x06, 0x1A);
            L0092: goto L0133;
            L0095: ShowMessage(player, String1BFF); // Those knights went nighty night.
            L00A2: Compare(GetFlag(player, 0x02, 0x53), 0x0002);
            L00B6: if (JumpEqual) goto L0126;
            L00B8: Compare(GetFlag(player, 0x02, 0x53), 0x000A);
            L00CC: if (JumpEqual) goto L0126;
            L00CE: Compare(GetFlag(player, 0x02, 0x53), 0x000C);
            L00E2: if (JumpEqual) goto L0126;
            L00E4: Compare(GetFlag(player, 0x02, 0x53), 0x000F);
            L00F8: if (JumpEqual) goto L0126;
            L00FA: Compare(GetFlag(player, 0x02, 0x53), 0x001B);
            L010E: if (JumpEqual) goto L0126;
            L0110: Compare(GetFlag(player, 0x02, 0x53), 0x001D);
            L0124: if (JumpNotEqual) goto L0133;
            L0126: ShowMessage(player, String1C20); // And they weren't wearing naughty nighties, neither.
            L0133: return; // RETURN;
        }

        private void Fn_24(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x05));
            L0016: if (JumpNotEqual) goto L0095;
            L0018: SetFlag(player, 0x03, 0x05, 0x01);
            L002D: AddEncounter(player, 0x01, 0x1A);
            L003F: AddEncounter(player, 0x05, 0x1A);
            L0051: ShowMessage(player, String1C54); // It's some wobbly wizards.  And they may not be sober enough for teleports, but they look plenty ready to cast some other spells.
            L005E: Compare(PartyCount(player), 0x0002);
            L0069: if (JumpAbove) goto L006E;
            L006B: goto L0133;
            L006E: AddEncounter(player, 0x02, 0x1A);
            L0080: AddEncounter(player, 0x06, 0x1A);
            L0092: goto L0133;
            L0095: ShowMessage(player, String1CD5); // Those wizards went away.
            L00A2: Compare(GetFlag(player, 0x02, 0x53), 0x0002);
            L00B6: if (JumpEqual) goto L0126;
            L00B8: Compare(GetFlag(player, 0x02, 0x53), 0x000A);
            L00CC: if (JumpEqual) goto L0126;
            L00CE: Compare(GetFlag(player, 0x02, 0x53), 0x000C);
            L00E2: if (JumpEqual) goto L0126;
            L00E4: Compare(GetFlag(player, 0x02, 0x53), 0x000F);
            L00F8: if (JumpEqual) goto L0126;
            L00FA: Compare(GetFlag(player, 0x02, 0x53), 0x001B);
            L010E: if (JumpEqual) goto L0126;
            L0110: Compare(GetFlag(player, 0x02, 0x53), 0x001D);
            L0124: if (JumpNotEqual) goto L0133;
            L0126: ShowMessage(player, String1CEE); // Heck, if I was dressed like them I'd leave too.
            L0133: return; // RETURN;
        }

        private void Fn_25(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x06));
            L0016: if (JumpNotEqual) goto L0095;
            L0018: SetFlag(player, 0x03, 0x06, 0x01);
            L002D: AddEncounter(player, 0x01, 0x1B);
            L003F: AddEncounter(player, 0x05, 0x1B);
            L0051: ShowMessage(player, String1D1E); // It's some maudlin mages.  Um, make that maddened mages!
            L005E: Compare(PartyCount(player), 0x0002);
            L0069: if (JumpAbove) goto L006E;
            L006B: goto L0133;
            L006E: AddEncounter(player, 0x02, 0x1B);
            L0080: AddEncounter(player, 0x06, 0x1B);
            L0092: goto L0133;
            L0095: ShowMessage(player, String1D56); // Those drunken wizards have been dispelled.
            L00A2: Compare(GetFlag(player, 0x02, 0x53), 0x0002);
            L00B6: if (JumpEqual) goto L0126;
            L00B8: Compare(GetFlag(player, 0x02, 0x53), 0x000A);
            L00CC: if (JumpEqual) goto L0126;
            L00CE: Compare(GetFlag(player, 0x02, 0x53), 0x000C);
            L00E2: if (JumpEqual) goto L0126;
            L00E4: Compare(GetFlag(player, 0x02, 0x53), 0x000F);
            L00F8: if (JumpEqual) goto L0126;
            L00FA: Compare(GetFlag(player, 0x02, 0x53), 0x001B);
            L010E: if (JumpEqual) goto L0126;
            L0110: Compare(GetFlag(player, 0x02, 0x53), 0x001D);
            L0124: if (JumpNotEqual) goto L0133;
            L0126: ShowMessage(player, String1D81); // And datspelled and deotherspelled, too.
            L0133: return; // RETURN;
        }

        private void Fn_26(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x07));
            L0016: if (JumpNotEqual) goto L0095;
            L0018: SetFlag(player, 0x03, 0x07, 0x01);
            L002D: AddEncounter(player, 0x01, 0x20);
            L003F: AddEncounter(player, 0x05, 0x20);
            L0051: ShowMessage(player, String1DA9); // The only thing worse than a nasty drunk is a nasty drunken priestess who wants to practise ritual sacrifices on you.
            L005E: Compare(PartyCount(player), 0x0002);
            L0069: if (JumpAbove) goto L006E;
            L006B: goto L0133;
            L006E: AddEncounter(player, 0x02, 0x20);
            L0080: AddEncounter(player, 0x06, 0x20);
            L0092: goto L0133;
            L0095: ShowMessage(player, String1E1E); // You sure poached those priestesses.
            L00A2: Compare(GetFlag(player, 0x02, 0x53), 0x0002);
            L00B6: if (JumpEqual) goto L0126;
            L00B8: Compare(GetFlag(player, 0x02, 0x53), 0x000A);
            L00CC: if (JumpEqual) goto L0126;
            L00CE: Compare(GetFlag(player, 0x02, 0x53), 0x000C);
            L00E2: if (JumpEqual) goto L0126;
            L00E4: Compare(GetFlag(player, 0x02, 0x53), 0x000F);
            L00F8: if (JumpEqual) goto L0126;
            L00FA: Compare(GetFlag(player, 0x02, 0x53), 0x001B);
            L010E: if (JumpEqual) goto L0126;
            L0110: Compare(GetFlag(player, 0x02, 0x53), 0x001D);
            L0124: if (JumpNotEqual) goto L0133;
            L0126: ShowMessage(player, String1E42); // Although they had started cooking with a low blue flame long before you arrived.
            L0133: return; // RETURN;
        }

        private void Fn_27(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x11));
            L0016: if (JumpNotEqual) goto L0095;
            L0018: SetFlag(player, 0x03, 0x11, 0x01);
            L002D: AddEncounter(player, 0x01, 0x19);
            L003F: AddEncounter(player, 0x05, 0x19);
            L0051: ShowMessage(player, String1E93); // It's some groggy goblins!
            L005E: Compare(PartyCount(player), 0x0002);
            L0069: if (JumpAbove) goto L006E;
            L006B: goto L0133;
            L006E: AddEncounter(player, 0x02, 0x19);
            L0080: AddEncounter(player, 0x06, 0x19);
            L0092: goto L0133;
            L0095: ShowMessage(player, String1EAD); // Those boozy barbarians were easy to polish off.
            L00A2: Compare(GetFlag(player, 0x02, 0x53), 0x0002);
            L00B6: if (JumpEqual) goto L0126;
            L00B8: Compare(GetFlag(player, 0x02, 0x53), 0x000A);
            L00CC: if (JumpEqual) goto L0126;
            L00CE: Compare(GetFlag(player, 0x02, 0x53), 0x000C);
            L00E2: if (JumpEqual) goto L0126;
            L00E4: Compare(GetFlag(player, 0x02, 0x53), 0x000F);
            L00F8: if (JumpEqual) goto L0126;
            L00FA: Compare(GetFlag(player, 0x02, 0x53), 0x001B);
            L010E: if (JumpEqual) goto L0126;
            L0110: Compare(GetFlag(player, 0x02, 0x53), 0x001D);
            L0124: if (JumpNotEqual) goto L0133;
            L0126: ShowMessage(player, String1EDD); // Easier than getting barbarian stain off your second best tunic's going to be, I'm afraid.
            L0133: return; // RETURN;
        }

        private void Fn_28(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x12));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00BC;
            L001B: SetFlag(player, 0x03, 0x12, 0x01);
            L0030: AddEncounter(player, 0x01, 0x1F);
            L0042: AddEncounter(player, 0x05, 0x1D);
            L0054: AddEncounter(player, 0x03, 0x1E);
            L0066: AddEncounter(player, 0x04, 0x1F);
            L0078: ShowMessage(player, String1F37); // It's a bunch of boozy bloodsuckers!  And some friends!  Hey!  You didn't know undead had friends?  You didn't even know that they drank.
            L0085: Compare(PartyCount(player), 0x0002);
            L0090: if (JumpAbove) goto L0095;
            L0092: goto L015A;
            L0095: AddEncounter(player, 0x02, 0x1E);
            L00A7: AddEncounter(player, 0x06, 0x1D);
            L00B9: goto L015A;
            L00BC: ShowMessage(player, String1FC0); // It serves those vampires right for drinking blood in the drunk tank.
            L00C9: Compare(GetFlag(player, 0x02, 0x53), 0x0002);
            L00DD: if (JumpEqual) goto L014D;
            L00DF: Compare(GetFlag(player, 0x02, 0x53), 0x000A);
            L00F3: if (JumpEqual) goto L014D;
            L00F5: Compare(GetFlag(player, 0x02, 0x53), 0x000C);
            L0109: if (JumpEqual) goto L014D;
            L010B: Compare(GetFlag(player, 0x02, 0x53), 0x000F);
            L011F: if (JumpEqual) goto L014D;
            L0121: Compare(GetFlag(player, 0x02, 0x53), 0x001B);
            L0135: if (JumpEqual) goto L014D;
            L0137: Compare(GetFlag(player, 0x02, 0x53), 0x001D);
            L014B: if (JumpNotEqual) goto L015A;
            L014D: ShowMessage(player, String2005); // And those drunks weren't even a very good vintage!
            L015A: return; // RETURN;
        }

    }
}
