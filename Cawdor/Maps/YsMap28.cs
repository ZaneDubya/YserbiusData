#pragma warning disable
using System.Collections.Generic;
using XPT.WorldData;
using XPT.WorldData.Yserbius;

namespace XPT.Scripts.Yserbius.Maps {
    class YserMap28 : AMapScripted {
        protected override int MapIndex => 28;
        protected override int RandomEncounterChance => 11;
        protected override int RandomEncounterExtraCount => 1;

        public YserMap28() {
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
            MapEvent33 = Fn_33;
        }
        
        // === Strings ================================================
        private const string String0140 = "A cold breeze sends shivers down your spine.";
        private const string String016D = "You've uncovered a hidden door!";
        private const string String018D = "You have unlocked the hidden door!";
        private const string String01B0 = "Your lockpick is no more.  It has ceased to key.  It's a stick.  Bereft of heft, it rests in pieces.  This is an ex-lockpick.";
        private const string String022E = "You detect a hidden door, but it is locked.";
        private const string String025A = "That was a stiff lock, but you finally got it open.";
        private const string String028E = "Funny how an irksome little lock on a flimsy little door can keep out a big strong person like you.";
        private const string String02F2 = "You find some tracks indicating that something headed off this way.";
        private const string String0336 = "Obviously, their mothers never taught them the importance of a doormat.";
        private const string String037E = "Neither did the gnome barbarian downstairs.";
        private const string String03AA = "In fact, if you didn't think you were getting close, you would definitely be getting bored.";
        private const string String0406 = "You hear some footsteps running away.";
        private const string String042C = "You hear someone running towards you.";
        private const string String0452 = "*";
        private const string String0454 = "A gargantuan gang of gremlins runs past you. One of them falls out and talks briefly.";
        private const string String04AA = "'Hide me!  Protect me!  Save me!  A press gang snapped me up and I cannot take any more of this!'";
        private const string String050C = "A burly sergeant wraps a whip around the gremlin's neck, jerking him back into the squad.  You decide not to interfere.";
        private const string String0584 = "The dragon examines you with a baleful eye.  It has seen better days.";
        private const string String05CA = "'Wouldst thou help a wyrm in need of a reviving morsel?  Thou hast two legs; surely thou couldst spare me one.  Wouldst thou resist my efforts to consume thee, then?  I feared so.  Were I not wounded, though...'  It limps off.";
        private const string String06AD = "'I think we have met before.  In sooth, did I not offer thee some dragonish drachmas?  Howsomever, now that I am equipped with Brunanburh's bow I find my relationships with dragons much improved.  I doubt that the wyrms would say the same, though.'";
        private const string String07A6 = "The halfling struts off, smiling.";
        private const string String07C8 = "A somewhat battered gang o'gremlins decides, rather insultingly, that they are bigger than you are.";
        private const string String082C = "This door leads to Alchemia.";
        private const string String0849 = "This door leads back into The Ruined Room.";
        private const string String0874 = "Rory's face is streaked with dust.  He pats several huge clouds off his clothes before greeting you.";
        private const string String08D9 = "'Welcome to the Attic.  It is a dusty place of small interest.  What little I have learned I will divulge to thee.'";
        private const string String094D = "'Most of this room is storage, and although there are one or two things worth detecting for, none are worth overly much.'";
        private const string String09C7 = "'Many of the doors are locked, and the locks are most difficult to pick.  Thou wilt need the nimblest of fingers and the finest of picks, or a goodly supply of skeleton keys.'";
        private const string String0A77 = "'There are dragons and medusae nesting to the south, and the dust does make tracking rather easy.  Still, getting to the southmost wall is not easy.'";
        private const string String0B0D = "'I am bound for Alchemia, which is another kettle of fish entirely, or so I have been told.'";
        private const string String0B6A = "'Ah, you have found me out!'  Rory grins bashfully.  'But it was in no wise my intent to keep a secret from thee.";
        private const string String0BDC = "'I only recently learned that the milk of human kindness is not only a might heal, but that its beneficence extends to your entire party.'";
        private const string String0C67 = "'Since I have improved upon both the picks and my skill with them since we last spoke, I have found a large supply of this milk, and do merely return to replenish my pack.'";
        private const string String0D14 = "'Where?  Why, to the south, and warded well, but not so well as to prevent me from ah, how to say, claiming my spoils?  Through the secret door and turn left.'";
        private const string String0DB4 = "Dusty, musty, and dry: yup, it smells like an attic.";
        private const string String0DE9 = "In the dusty floor you see one halfling foot print, and cannot but wonder if it is Rory's.";
        private const string String0E44 = "Aye, that was a nasty group you fought here.  But they are here to fight no more.";
        private const string String0E96 = "Well, this sure looks like a lair, but whoever was in it got while the getting was good.";
        private const string String0EEF = "Egads!  They were waiting for you with open arms and loaded crossbows!";
        private const string String0F36 = "You have already cleaned out this lair.  No need to fear any further ambushes, at least for today.";
        private const string String0F99 = "Congratulations!  By tracking carefully and by possessing the critical item needed to cow these wyrms, you are going to have a much easier time with this battle!";
        private const string String103B = "Although the notion of a cowed wyrm is a bit much for you to imagine all at once.";
        private const string String108D = "You carefully sneak up to the door.  You can almost feel it pulse with their breathing.  You take a deep breath in preparation, and charge!";
        private const string String1119 = "Well, wouldn't you rather I described your entrance as a heroic charge rather than a cautious peeking around the door?  I know I would!";
        private const string String11A1 = "Your froggy toe begins to pulse, as if detecting those beasts against which it is purposed.  Hearing them prepare for you, you charge to the attack!";
        private const string String1236 = "And next time, maybe you won't have to charge through sheets of flame!";
        private const string String127D = "Everything's perfectly normal, if you call receiving a sudden faceful of mana sucking poison normal.  No, wait.  It will come to you if you just give it a second.  Eureka!";
        private const string String1329 = "It's one of those, what do they call it?  Deathtraps!  That's the ticket!";
        private const string String1373 = "Fortunately for you nobody's left to wyrm the ambush.";
        private const string String13A9 = "There they are, ready and waiting!";
        private const string String13CC = "The lair is empty.";
        private const string String13DF = "Ah ha!  Medusa ho!  And no, that is most definitely not street slang!  Boy, I always have to watch what I say around you, don't I?";
        private const string String1462 = "Medusae ho!  You charge into their ambush, having little choice in the matter!";
        private const string String14B1 = "There are some footprints in the dust leading to the east on the southern side of the partition.";
        private const string String1512 = "This closet appears much the same as the last time you were here.";
        private const string String1554 = "You now know exactly how many snake steaks there are in a medusa's coif; exactly one fenny filet's worth!";
        private const string String15BE = "'Beat it, kid, you bother me.'";
        private const string String15DD = "The minotaur is calling out, and there is rather a long line waiting in front of him.  You step in line and listen to his patter.";
        private const string String165F = "'Step right up, step right up, the freshest dairy product known to cow.  Yes indeed, the fabled milk of human kindness, just five hundred smackeroos and a suitable container.'";
        private const string String170F = "'One to a customer, no need to shove, there's plenty more where that came from.  Hey there, whippersnapper, what's your hurry?  Everyone gets their turn.'";
        private const string String17AA = "'I said suitable, and those lousy bottles are at least a pants leg shy.  Come back with a bottle that held something that won't spoil the ineluctable flavor of the milk and you'll get some.'";
        private const string String1869 = "'Now off with you.  I've got paying customers waiting, and the line isn't moving with you parked here!  Begone, rapscallion!'";
        private const string String18E7 = "'It's been a business doing kefir with you.  Be sure and keep that bottle sealed until you use it.  Why, just last week the seal dropped a bottle and it took a set of superhuman lungs to retrieve it!'";
        private const string String19B0 = "This guy's weird (heck, this whole game is listing about three degrees to port) but the milk of human kindness is well worth the effort.";
        private const string String1A39 = "A miserly mob of 'Mc's' decides they can take your milk from you!";
        private const string String1A7B = "A menacing mob of 'Mc's' decides that they can use their milk of human kindness to defeat you!";
        private const string String1ADA = "You really put those dukes up to a fight!";
        private const string String1B04 = "A terrible team of trolls decides that you are interupting their services.  Or, knowing trolls, maybe they are just a might peckish.";
        private const string String1B89 = "You really showed them who was in con-troll!";
        private const string String1BB6 = "Eewwe!  Evil Ectoplasmic Entities!  And you just had your armor deslimed!";
        private const string String1C00 = "You already ended those entity's enmity entirely!";
        private const string String1C32 = "Are those but phantoms of the mind, or are they real?  Either way, they are trying to kill you!";
        private const string String1C92 = "They called themselves powerful protoplasmic phantoms, but you thought they fought like normal run of the mill protoplasmic phantoms.  Or maybe you're just getting good at this!";
        private const string String1D44 = "A veritable village of vampires has decided that you are the blood bank.  And they intend to make a withdrawal!";
        private const string String1DB4 = "You really showed them that the blood bank was closed.";
        private const string String1DEB = "This room is so dusty that you can barely breath.  In fact, the dust is chokingly thick!";
        private const string String1E44 = "You find an old dressmaker's dummy.";
        private const string String1E68 = "You find an empty trunk.  Not an elephant's, either.";
        private const string String1E9D = "You find a cigar box full of old baseball cards.  However, since you don't know what a baseball card is, you ignore it.";
        private const string String1F15 = "You find an old sled.  Evidently it didn't go into the furnace after all.";
        private const string String1F5F = "You find a pair of red sequined dancing shoes.";
        private const string String1F8E = "You find a thing shaped like a four battery flashlight.  When you twist it a beam of gleaming light extends out about four feet, making a funny humming noise.  You decide it's worthless in a fantasy game, and discard it.";
        private const string String206B = "You find an old blonde fright wig and a rubber horn.  And two hard-boiled eggs.";
        private const string String20BB = "You find a large warhammer with adornments of lightning worked into it, but you're not strong enough to lift it.";
        private const string String212C = "You find a black cricket bat.";
        private const string String214A = "You find a philosopher's stone.  Not being a philosopher, you leave it behind.";
        private const string String2199 = "You find a pair of x-ray glasses.  At your first glance you can see through the armor and clothes of a member of the opposite sex three rooms away.  You blush beet red and quickly take them off.";
        private const string String225C = "You find a Walther PPK.  You use it to crack a walnut.  It doesn't do a very good job, so you abandon it.";
        private const string String22C6 = "You find a black cape with a strange serpentine emblem on it.  You decide to leave it here.";
        private const string String2322 = "You find a long cherry wood pipe and some pipe tobacco stuffed inside a slipper.  However, you don't smoke, or at least you restrict your smoking to the aftermath of being fireballed.";
        private const string String23DA = "You find an ornate, gilded bottle.  You shake it a few times to see if it's empty, thoroughly smashing the genie inside.  There will be no wishes for you today!";
        private const string String247B = "You find a pair of old football shoes.";
        private const string String24A2 = "You find a set of tiki lamps.  They don't taste very good, so you leave them behind.";
        private const string String24F7 = "You find a set of oars, but, and this is indeed a sad commentary on your life, no boat to row.";
        private const string String2556 = "You find an old orange life preserver.  Funny, it didn't seem to do much for the stiff wearing it.";
        private const string String25B9 = "You find an old bowling ball.";
        private const string String25D7 = "You find a carton full of baby pictures.  Yes, wraiths are just as ugly as babies as they are fully grown.  You leave it.";
        private const string String2651 = "There is a sign on the wall that reads: 'The Wizards of Cawdor (WoC) have thoroughly examined the room at the end of this hall.  It contains nothing of value or interest for you, and will almost certainly kill you.  Enter at your own risk.'";
        private const string String2742 = "Not a very cheery message, is it?  And everybody knows that wizards never lie.  I hear there's a new Mead Hall that just opened downstairs.  Suppose we go there instead?";
        
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
0042  0036 C4 5E 06  les bx, [bp+0x6]
0045  0039 26 FF 5F 54  call far word [es:bx+0x54]
            L003D: cx = PopStack(player);
            L003E: cx = PopStack(player);
            L003F: RefreshCompareFlags(ax);
            L0041: if (JumpNotEqual) goto L008D;
            L0043: PushStack(player, 0x61);
            L0047: PushStack(player, ax);
0054  0048 C4 5E 06  les bx, [bp+0x6]
0057  004B 26 FF 5F 54  call far word [es:bx+0x54]
            L004F: cx = PopStack(player);
            L0050: cx = PopStack(player);
            L0051: RefreshCompareFlags(ax);
            L0053: if (JumpNotEqual) goto L008D;
            L0055: PushStack(player, 0x93);
            L0059: PushStack(player, ax);
0066  005A C4 5E 06  les bx, [bp+0x6]
0069  005D 26 FF 5F 54  call far word [es:bx+0x54]
            L0061: cx = PopStack(player);
            L0062: cx = PopStack(player);
            L0063: RefreshCompareFlags(ax);
            L0065: if (JumpNotEqual) goto L008D;
            L0067: PushStack(player, 0x86);
            L006B: PushStack(player, ax);
0078  006C C4 5E 06  les bx, [bp+0x6]
007B  006F 26 FF 5F 54  call far word [es:bx+0x54]
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
00D8  00CC C4 5E 06  les bx, [bp+0x6]
00DB  00CF 26 FF 5F 2C  call far word [es:bx+0x2c]
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
0146  0029 C4 5E 06  les bx, [bp+0x6]
0149  002C 26 FF 5F 54  call far word [es:bx+0x54]
            L0030: cx = PopStack(player);
            L0031: cx = PopStack(player);
            L0032: RefreshCompareFlags(ax);
            L0034: if (JumpNotEqual) goto L0083;
            L0036: PushStack(player, 0x61);
            L003A: PushStack(player, ax);
0158  003B C4 5E 06  les bx, [bp+0x6]
015B  003E 26 FF 5F 54  call far word [es:bx+0x54]
            L0042: cx = PopStack(player);
            L0043: cx = PopStack(player);
            L0044: RefreshCompareFlags(ax);
            L0046: if (JumpNotEqual) goto L0083;
            L0048: PushStack(player, 0x93);
            L004C: PushStack(player, ax);
016A  004D C4 5E 06  les bx, [bp+0x6]
016D  0050 26 FF 5F 54  call far word [es:bx+0x54]
            L0054: cx = PopStack(player);
            L0055: cx = PopStack(player);
            L0056: RefreshCompareFlags(ax);
            L0058: if (JumpNotEqual) goto L0083;
            L005A: PushStack(player, 0x86);
            L005E: PushStack(player, ax);
017C  005F C4 5E 06  les bx, [bp+0x6]
017F  0062 26 FF 5F 54  call far word [es:bx+0x54]
            L0066: cx = PopStack(player);
            L0067: cx = PopStack(player);
            L0068: RefreshCompareFlags(ax);
            L006A: if (JumpNotEqual) goto L0083;
            L006C: ax = IsFlagOn(player, 0x00, 0x01);
            L007E: if (JumpNotEqual) goto L0083;
            L0080: goto L01ED;
            L0083: SetWallObject(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L00A1: PushStack(player, 0x01);
            L00A5: PushStack(player, ax);
            L00A6: PushStack(player, 0x00);
01C6  00A9 C4 5E 06  les bx, [bp+0x6]
01C9  00AC 26 FF 1F  call far word [es:bx]
01CC  00AF 83 C4 06  add sp, 0x6
            L00B2: PushStack(player, 0x68);
            L00B6: PushStack(player, ax);
01D4  00B7 C4 5E 06  les bx, [bp+0x6]
01D7  00BA 26 FF 5F 54  call far word [es:bx+0x54]
            L00BE: cx = PopStack(player);
            L00BF: cx = PopStack(player);
            L00C0: RefreshCompareFlags(ax);
            L00C2: if (JumpEqual) goto L00E4;
            L00C4: ax = HasItem(player, 0xDC);
            L00D2: if (JumpNotEqual) goto L011C;
            L00D4: ax = HasItem(player, 0xDD);
            L00E2: if (JumpNotEqual) goto L011C;
            L00E4: Compare(GetSkillLevel(player, 0x0E), 0x000B);
            L00F3: if (JumpBelow) goto L010A;
            L00F5: ax = HasUsedItem(player, 0xDC, 0xDD);
            L0108: if (JumpNotEqual) goto L011C;
            L010A: PushStack(player, 0xC0);
            L010E: PushStack(player, ax);
022C  010F C4 5E 06  les bx, [bp+0x6]
022F  0112 26 FF 5F 54  call far word [es:bx+0x54]
            L0116: cx = PopStack(player);
            L0117: cx = PopStack(player);
            L0118: RefreshCompareFlags(ax);
            L011A: if (JumpEqual) goto L012F;
            L011C: ShowMessage(player, String018D); // You have unlocked the hidden door!
0246  0129 B8 01 00  mov ax, 0x1
            L012C: goto L01EF;
            L012F: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L014C: ax = HasUsedItem(player, 0xC1, 0xC3);
            L015F: if (JumpNotEqual) goto L0176;
            L0161: ax = HasUsedItem(player, 0xDA, 0xDB);
            L0174: if (JumpEqual) goto L01C1;
            L0176: RemoveItem(player, 0xC1);
            L0182: RemoveItem(player, 0xC2);
            L018E: RemoveItem(player, 0xC3);
            L019A: RemoveItem(player, 0xDA);
            L01A6: RemoveItem(player, 0xDB);
            L01B2: ShowMessage(player, String01B0); // Your lockpick is no more.  It has ceased to key.  It's a stick.  Bereft of heft, it rests in pieces.  This is an ex-lockpick.
            L01BF: goto L020A;
            L01C1: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L01DE: ShowMessage(player, String022E); // You detect a hidden door, but it is locked.
            L01EB: goto L020A;
            L01ED: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L020A: return; // RETURN;
        }

        private void Fn_03(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetSkillLevel(player, 0x0E), 0x000B);
            L0012: if (JumpBelow) goto L0029;
            L0014: ax = HasUsedItem(player, 0xDC, 0xDD);
            L0027: if (JumpNotEqual) goto L003B;
            L0029: PushStack(player, 0xC0);
            L002D: PushStack(player, ax);
0357  002E C4 5E 06  les bx, [bp+0x6]
035A  0031 26 FF 5F 54  call far word [es:bx+0x54]
            L0035: cx = PopStack(player);
            L0036: cx = PopStack(player);
            L0037: RefreshCompareFlags(ax);
            L0039: if (JumpEqual) goto L0069;
            L003B: ShowMessage(player, String025A); // That was a stiff lock, but you finally got it open.
            L0048: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0066: goto L011B;
            L0069: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0086: ax = HasUsedItem(player, 0xC1, 0xC3);
            L0099: if (JumpNotEqual) goto L00B0;
            L009B: ax = HasUsedItem(player, 0xDA, 0xDB);
            L00AE: if (JumpEqual) goto L00F1;
            L00B0: RemoveItem(player, 0xC1);
            L00BC: RemoveItem(player, 0xC2);
            L00C8: RemoveItem(player, 0xC3);
            L00D4: RemoveItem(player, 0xDA);
            L00E0: RemoveItem(player, 0xDB);
0415  00EC B8 B0 01  mov ax, 0x1b0
            L00EF: goto L0111;
            L00F1: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L010E: ShowMessage(player, String028E); // Funny how an irksome little lock on a flimsy little door can keep out a big strong person like you.
            L011B: return; // RETURN;
        }

        private void Fn_04(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: si = 0;
            L0006: si = GetFlag(player, 0x03, 0x0B);
            L0019: Compare(HasUsedSkill(player, 0x0B), 0x0009);
            L0028: if (JumpNotBelow) goto L0051;
            L002A: PushStack(player, 0x62);
            L002E: PushStack(player, ax);
0475  002F C4 5E 06  les bx, [bp+0x6]
0478  0032 26 FF 5F 54  call far word [es:bx+0x54]
            L0036: cx = PopStack(player);
            L0037: cx = PopStack(player);
            L0038: RefreshCompareFlags(ax);
            L003A: if (JumpNotEqual) goto L0051;
            L003C: PushStack(player, 0x8F);
            L0040: PushStack(player, ax);
0487  0041 C4 5E 06  les bx, [bp+0x6]
048A  0044 26 FF 5F 54  call far word [es:bx+0x54]
            L0048: cx = PopStack(player);
            L0049: cx = PopStack(player);
            L004A: RefreshCompareFlags(ax);
            L004C: if (JumpNotEqual) goto L0051;
            L004E: goto L00E2;
            L0051: si = si + 1;
            L0052: ShowMessage(player, String02F2); // You find some tracks indicating that something headed off this way.
            L005F: SetFlag(player, 0x03, 0x09, 0x01);
            L0074: Compare(si, 0x02);
            L0077: if (JumpNotEqual) goto L0086;
            L0079: ShowMessage(player, String0336); // Obviously, their mothers never taught them the importance of a doormat.
            L0086: Compare(si, 0x04);
            L0089: if (JumpNotEqual) goto L0098;
            L008B: ShowMessage(player, String037E); // Neither did the gnome barbarian downstairs.
            L0098: Compare(si, 0x05);
            L009B: if (JumpNotEqual) goto L00AC;
            L009D: ShowMessage(player, String03AA); // In fact, if you didn't think you were getting close, you would definitely be getting bored.
            L00AA: si = 0;
            L00AC: Compare(GetCurrentTile(player), 0x00F6);
            L00B6: if (JumpBelowOrEqual) goto L00CC;
            L00B8: SetFlag(player, 0xC4, 0xB8, si);
            L00CA: goto L00E2;
            L00CC: SetFlag(player, 0x03, 0x0B, 0x00);
            L00E0: si = 0;
            L00E2: return; // RETURN (restoring si);
        }

        private void Fn_05(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si, di);
            L0005: di = 0;
            L0007: si = 0;
            L0009: ax = GetFlag(player, 0x03, 0x08);
0545  001A 8B F8  mov di, ax
0547  001C 47     inc di
0548  001D 8B F7  mov si, di
            L001F: Compare(si, 0x13);
            L0022: if (JumpLessOrEqual) goto L002B;
054F  0024 8B C6  mov ax, si
            L0026: si = ax + 0xFFEC;
            L002B: Compare(si, 0x0E);
            L002E: if (JumpLessOrEqual) goto L0037;
055B  0030 8B C6  mov ax, si
            L0032: si = ax + 0xFFF1;
            L0037: Compare(si, 0x09);
            L003A: if (JumpLessOrEqual) goto L0043;
0567  003C 8B C6  mov ax, si
            L003E: si = ax + 0xFFF6;
            L0043: Compare(si, 0x04);
            L0046: if (JumpLessOrEqual) goto L004F;
0573  0048 8B C6  mov ax, si
            L004A: si = ax + 0xFFFB;
057A  004F 0B F6  or si, si
057C  0051 7D 02  jge 0x55
            L0053: si = 0;
            L0055: Compare(si, 0x1D);
            L0058: if (JumpLessOrEqual) goto L005C;
            L005A: si = 0;
0587  005C 83 FF 1E  cmp di, 0x1e
            L005F: if (JumpLessOrEqual) goto L0063;
            L0061: di = 0;
058E  0063 57     push di
            L0064: PushStack(player, 0x08);
            L0068: PushStack(player, 0x03);
0597  006C C4 5E 06  les bx, [bp+0x6]
059A  006F 26 FF 1F  call far word [es:bx]
059D  0072 83 C4 06  add sp, 0x6
05A0  0075 83 FF 1A  cmp di, 0x1a
            L0078: if (JumpNotEqual) goto L007F;
05A5  007A B8 01 00  mov ax, 0x1
            L007D: goto L0081;
            L007F: PushStack(player, 0x00);
05AD  0082 83 FF 14  cmp di, 0x14
            L0085: if (JumpNotEqual) goto L008C;
05B2  0087 B8 01 00  mov ax, 0x1
            L008A: goto L008E;
05B7  008C 33 C0  xor ax, ax
            L008E: dx = PopStack(player);
05BA  008F 0B D0  or dx, ax
            L0091: PushStack(player, dx);
05BD  0092 83 FF 0E  cmp di, 0xe
            L0095: if (JumpNotEqual) goto L009C;
05C2  0097 B8 01 00  mov ax, 0x1
            L009A: goto L009E;
05C7  009C 33 C0  xor ax, ax
            L009E: dx = PopStack(player);
05CA  009F 0B D0  or dx, ax
            L00A1: PushStack(player, dx);
05CD  00A2 83 FF 08  cmp di, 0x8
            L00A5: if (JumpNotEqual) goto L00AC;
05D2  00A7 B8 01 00  mov ax, 0x1
            L00AA: goto L00AE;
05D7  00AC 33 C0  xor ax, ax
            L00AE: dx = PopStack(player);
05DA  00AF 0B D0  or dx, ax
            L00B1: PushStack(player, dx);
05DD  00B2 83 FF 02  cmp di, 0x2
            L00B5: if (JumpNotEqual) goto L00BC;
05E2  00B7 B8 01 00  mov ax, 0x1
            L00BA: goto L00BE;
05E7  00BC 33 C0  xor ax, ax
            L00BE: dx = PopStack(player);
05EA  00BF 0B D0  or dx, ax
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
            L00D7: ShowMessage(player, String0406); // You hear some footsteps running away.
            L00E4: goto L026D;
            L00E7: ShowMessage(player, String042C); // You hear someone running towards you.
            L00F4: ShowPortrait(player, 0x0026);
            L0101: ShowMessage(player, String0452); // *
            L010E: ShowMessage(player, String0452); // *
            L011B: ShowMessage(player, String0452); // *
            L0128: ShowMessage(player, String0454); // A gargantuan gang of gremlins runs past you. One of them falls out and talks briefly.
            L0135: ShowMessage(player, String04AA); // 'Hide me!  Protect me!  Save me!  A press gang snapped me up and I cannot take any more of this!'
066D  0142 B8 0C 05  mov ax, 0x50c
            L0145: goto L00DA;
            L0147: ShowPortrait(player, 0x000E);
            L0154: ShowMessage(player, String0584); // The dragon examines you with a baleful eye.  It has seen better days.
068C  0161 B8 CA 05  mov ax, 0x5ca
            L0164: goto L00DA;
            L0167: ShowPortrait(player, 0x0025);
            L0174: ShowMessage(player, String0452); // *
            L0181: ShowMessage(player, String0452); // *
            L018E: ShowMessage(player, String0452); // *
            L019B: ShowMessage(player, String06AD); // 'I think we have met before.  In sooth, did I not offer thee some dragonish drachmas?  Howsomever, now that I am equipped with Brunanburh's bow I find my relationships with dragons much improved.  I doubt that the wyrms would say the same, though.'
06D3  01A8 B8 A6 07  mov ax, 0x7a6
            L01AB: goto L00DA;
            L01AE: ShowPortrait(player, 0x0026);
            L01BB: ShowMessage(player, String0452); // *
            L01C8: ShowMessage(player, String0452); // *
            L01D5: ShowMessage(player, String0452); // *
            L01E2: ShowMessage(player, String07C8); // A somewhat battered gang o'gremlins decides, rather insultingly, that they are bigger than you are.
            L01EF: PushStack(player, 0x5D);
            L01F3: PushStack(player, 0x00);
            L01F6: PushStack(player, ax);
            L01F7: PushStack(player, ax);
            L01F8: PushStack(player, 0xB6);
            L01FC: PushStack(player, 0xBD);
072B  0200 C4 5E 06  les bx, [bp+0x6]
072E  0203 26 FF 9F D8 00  call far word [es:bx+0xd8]
0733  0208 83 C4 0C  add sp, 0xc
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
            L0003: ShowMessage(player, String0140); // A cold breeze sends shivers down your spine.
            L0010: return; // RETURN;
        }

        private void Fn_07(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String082C); // This door leads to Alchemia.
            L0010: TeleportParty(player, 0x09, 0x01, 0xFB, 0x03, isForwardMove);
            L002B: return; // RETURN;
        }

        private void Fn_08(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0849); // This door leads back into The Ruined Room.
            L0010: TeleportParty(player, 0x0B, 0x04, 0x3F, 0x00, isForwardMove);
            L002A: return; // RETURN;
        }

        private void Fn_09(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x02, 0x47));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L0100;
            L001B: RefreshCompareFlags(GetFlag(player, 0x02, 0x63));
            L002E: if (JumpNotEqual) goto L0098;
            L0030: SetFlag(player, 0x02, 0x63, 0x01);
            L0045: ShowPortrait(player, 0x0025);
            L0052: ShowMessage(player, String0874); // Rory's face is streaked with dust.  He pats several huge clouds off his clothes before greeting you.
            L005F: ShowMessage(player, String08D9); // 'Welcome to the Attic.  It is a dusty place of small interest.  What little I have learned I will divulge to thee.'
            L006C: ShowMessage(player, String094D); // 'Most of this room is storage, and although there are one or two things worth detecting for, none are worth overly much.'
            L0079: ShowMessage(player, String09C7); // 'Many of the doors are locked, and the locks are most difficult to pick.  Thou wilt need the nimblest of fingers and the finest of picks, or a goodly supply of skeleton keys.'
            L0086: ShowMessage(player, String0A77); // 'There are dragons and medusae nesting to the south, and the dust does make tracking rather easy.  Still, getting to the southmost wall is not easy.'
08A4  0093 B8 0D 0B  mov ax, 0xb0d
            L0096: goto L0103;
            L0098: RefreshCompareFlags(GetFlag(player, 0x03, 0x0A));
            L00AB: if (JumpNotEqual) goto L00FB;
            L00AD: SetFlag(player, 0x03, 0x0A, 0x01);
            L00C2: ShowPortrait(player, 0x0025);
            L00CF: ShowMessage(player, String0B6A); // 'Ah, you have found me out!'  Rory grins bashfully.  'But it was in no wise my intent to keep a secret from thee.
            L00DC: ShowMessage(player, String0BDC); // 'I only recently learned that the milk of human kindness is not only a might heal, but that its beneficence extends to your entire party.'
            L00E9: ShowMessage(player, String0C67); // 'Since I have improved upon both the picks and my skill with them since we last spoke, I have found a large supply of this milk, and do merely return to replenish my pack.'
0907  00F6 B8 14 0D  mov ax, 0xd14
            L00F9: goto L0103;
090C  00FB B8 B4 0D  mov ax, 0xdb4
            L00FE: goto L0103;
            L0100: ShowMessage(player, String0DE9); // In the dusty floor you see one halfling foot print, and cannot but wonder if it is Rory's.
            L010D: return; // RETURN;
        }

        private void Fn_0A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFlag(player, 0x03, 0x09, 0x00);
            L0017: return; // RETURN;
        }

        private void Fn_0B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x09), 0x0001);
            L0017: if (JumpEqual) goto L001C;
            L0019: goto L00BD;
            L001C: RefreshCompareFlags(GetFlag(player, 0x03, 0x01));
            L002F: if (JumpEqual) goto L0034;
            L0031: goto L00BD;
096D  0034 B8 DC 04  mov ax, 0x4dc
            L0037: PushStack(player, ax);
            L0038: PushStack(player, 0x00);
            L003B: PushStack(player, ax);
            L003C: PushStack(player, ax);
            L003D: PushStack(player, 0xBB);
            L0041: PushStack(player, 0xEE);
097E  0045 C4 5E 06  les bx, [bp+0x6]
0981  0048 26 FF 9F D8 00  call far word [es:bx+0xd8]
0986  004D 83 C4 0C  add sp, 0xc
            L0050: PushStack(player, 0x01);
            L0054: PushStack(player, ax);
            L0055: PushStack(player, 0x03);
0992  0059 C4 5E 06  les bx, [bp+0x6]
0995  005C 26 FF 1F  call far word [es:bx]
0998  005F 83 C4 06  add sp, 0x6
            L0062: AddEncounter(player, 0x01, 0x19);
            L0074: AddEncounter(player, 0x05, 0x1C);
            L0086: AddEncounter(player, 0x02, 0x1A);
            L0098: AddEncounter(player, 0x06, 0x1C);
            L00AA: Compare(PartyCount(player), 0x0002);
            L00B5: if (JumpAbove) goto L00BA;
            L00B7: goto L01E2;
            L00BA: goto L01BE;
            L00BD: Compare(GetFlag(player, 0x03, 0x01), 0x0001);
            L00D1: if (JumpNotEqual) goto L00E3;
            L00D3: ShowMessage(player, String0E44); // Aye, that was a nasty group you fought here.  But they are here to fight no more.
            L00E0: goto L01E2;
            L00E3: ax = CheckLevel(player, 0x0028);
            L00F1: if (JumpEqual) goto L00F8;
0A2C  00F3 B8 96 0E  mov ax, 0xe96
            L00F6: goto L00D6;
            L00F8: ShowMessage(player, String0EEF); // Egads!  They were waiting for you with open arms and loaded crossbows!
            L0105: ax = GetMaxHits(player);
            L010C: bx = 0x0003;
            L010F: dx = ax % bx; ax = ax / bx;
            L0112: DamagePlayer(player, ax);
            L011C: PushStack(player, 0x01);
            L0120: PushStack(player, ax);
            L0121: PushStack(player, 0x03);
0A5E  0125 C4 5E 06  les bx, [bp+0x6]
0A61  0128 26 FF 1F  call far word [es:bx]
0A64  012B 83 C4 06  add sp, 0x6
            L012E: AddMana(player, 0xF060);
            L013B: PushStack(player, 0x01);
            L013F: PushStack(player, ax);
            L0140: PushStack(player, 0x03);
0A7D  0144 C4 5E 06  les bx, [bp+0x6]
0A80  0147 26 FF 1F  call far word [es:bx]
0A83  014A 83 C4 06  add sp, 0x6
0A86  014D B8 DC 04  mov ax, 0x4dc
            L0150: PushStack(player, ax);
            L0151: PushStack(player, 0x00);
            L0154: PushStack(player, ax);
            L0155: PushStack(player, ax);
            L0156: PushStack(player, 0xBB);
            L015A: PushStack(player, 0xEE);
0A97  015E C4 5E 06  les bx, [bp+0x6]
0A9A  0161 26 FF 9F D8 00  call far word [es:bx+0xd8]
0A9F  0166 83 C4 0C  add sp, 0xc
            L0169: AddEncounter(player, 0x01, 0x19);
            L017B: AddEncounter(player, 0x05, 0x1C);
            L018D: AddEncounter(player, 0x02, 0x1A);
            L019F: AddEncounter(player, 0x06, 0x1C);
            L01B1: Compare(PartyCount(player), 0x0002);
            L01BC: if (JumpBelowOrEqual) goto L01E2;
            L01BE: AddEncounter(player, 0x03, 0x1B);
            L01D0: AddEncounter(player, 0x04, 0x1B);
            L01E2: return; // RETURN;
        }

        private void Fn_0C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x02), 0x0001);
            L0017: if (JumpNotEqual) goto L005A;
            L0019: ShowMessage(player, String0F36); // You have already cleaned out this lair.  No need to fear any further ambushes, at least for today.
            L0026: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0044: PushStack(player, 0x01);
            L0048: PushStack(player, GetFacing(player));
            L0050: ax = GetCurrentTile(player);
            L0057: goto L0175;
            L005A: Compare(GetFlag(player, 0x03, 0x09), 0x0001);
            L006E: if (JumpEqual) goto L0073;
            L0070: goto L00F1;
            L0072: // NOP
            L0073: ax = HasItem(player, 0xF1);
            L0081: if (JumpEqual) goto L00BA;
            L0083: ShowMessage(player, String0F99); // Congratulations!  By tracking carefully and by possessing the critical item needed to cow these wyrms, you are going to have a much easier time with this battle!
            L0090: ShowMessage(player, String103B); // Although the notion of a cowed wyrm is a bit much for you to imagine all at once.
            L009D: TeleportParty(player, 0x0B, 0x03, 0xF0, 0x00, isForwardMove);
            L00B7: goto L0180;
            L00BA: ShowMessage(player, String108D); // You carefully sneak up to the door.  You can almost feel it pulse with their breathing.  You take a deep breath in preparation, and charge!
            L00C7: ShowMessage(player, String1119); // Well, wouldn't you rather I described your entrance as a heroic charge rather than a cautious peeking around the door?  I know I would!
            L00D4: TeleportParty(player, 0x0B, 0x03, 0xF1, 0x00, isForwardMove);
            L00EE: goto L0180;
            L00F1: ax = HasItem(player, 0xF1);
            L00FF: if (JumpEqual) goto L0144;
            L0101: ShowMessage(player, String11A1); // Your froggy toe begins to pulse, as if detecting those beasts against which it is purposed.  Hearing them prepare for you, you charge to the attack!
            L010E: ShowMessage(player, String1236); // And next time, maybe you won't have to charge through sheets of flame!
            L011B: DamagePlayer(player, 0x0FA0);
            L0128: TeleportParty(player, 0x0B, 0x03, 0xF2, 0x00, isForwardMove);
            L0142: goto L0180;
            L0144: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0162: SetWallObject(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L0180: return; // RETURN;
        }

        private void Fn_0D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x02));
            L0016: if (JumpNotEqual) goto L0067;
0CB7  0018 C4 5E 06  les bx, [bp+0x6]
0CBA  001B 26 FF 9F C8 00  call far word [es:bx+0xc8]
            L0020: SetNoHealZone(player);
            L0028: ShowMessage(player, String127D); // Everything's perfectly normal, if you call receiving a sudden faceful of mana sucking poison normal.  No, wait.  It will come to you if you just give it a second.  Eureka!
            L0035: ShowMessage(player, String1329); // It's one of those, what do they call it?  Deathtraps!  That's the ticket!
            L0042: ax = GetMaxHits(player);
            L0049: bx = 0x0002;
            L004C: dx = ax % bx; ax = ax / bx;
            L004F: DamagePlayer(player, ax);
0CF8  0059 B8 78 EC  mov ax, 0xec78
            L005C: PushStack(player, ax);
0CFC  005D C4 5E 06  les bx, [bp+0x6]
0CFF  0060 26 FF 9F B4 00  call far word [es:bx+0xb4]
            L0065: goto L0073;
            L0067: ShowMessage(player, String1373); // Fortunately for you nobody's left to wyrm the ambush.
            L0074: return; // RETURN;
        }

        private void Fn_0E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x02));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00D4;
            L001B: ShowMessage(player, String13A9); // There they are, ready and waiting!
            L0028: SetFlag(player, 0x03, 0x02, 0x01);
0D52  003D B8 AC 0C  mov ax, 0xcac
            L0040: PushStack(player, ax);
            L0041: PushStack(player, 0x00);
            L0044: PushStack(player, ax);
            L0045: PushStack(player, ax);
            L0046: PushStack(player, 0xBB);
            L004A: PushStack(player, 0xEE);
0D63  004E C4 5E 06  les bx, [bp+0x6]
0D66  0051 26 FF 9F D8 00  call far word [es:bx+0xd8]
0D6B  0056 83 C4 0C  add sp, 0xc
            L0059: AddEncounter(player, 0x01, 0x25);
            L006B: AddEncounter(player, 0x05, 0x25);
            L007D: AddEncounter(player, 0x02, 0x25);
            L008F: AddEncounter(player, 0x06, 0x25);
            L00A1: Compare(PartyCount(player), 0x0002);
            L00AC: if (JumpBelowOrEqual) goto L00E1;
            L00AE: AddEncounter(player, 0x03, 0x25);
            L00C0: AddEncounter(player, 0x04, 0x25);
            L00D2: goto L00E1;
            L00D4: ShowMessage(player, String13CC); // The lair is empty.
            L00E1: return; // RETURN;
        }

        private void Fn_0F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x02));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00D4;
            L001B: ShowMessage(player, String13A9); // There they are, ready and waiting!
            L0028: SetFlag(player, 0x03, 0x02, 0x01);
0E35  003D B8 AC 0C  mov ax, 0xcac
            L0040: PushStack(player, ax);
            L0041: PushStack(player, 0x00);
            L0044: PushStack(player, ax);
            L0045: PushStack(player, ax);
            L0046: PushStack(player, 0xBB);
            L004A: PushStack(player, 0xEE);
0E46  004E C4 5E 06  les bx, [bp+0x6]
0E49  0051 26 FF 9F D8 00  call far word [es:bx+0xd8]
0E4E  0056 83 C4 0C  add sp, 0xc
            L0059: AddEncounter(player, 0x01, 0x25);
            L006B: AddEncounter(player, 0x05, 0x25);
            L007D: AddEncounter(player, 0x02, 0x25);
            L008F: AddEncounter(player, 0x06, 0x24);
            L00A1: Compare(PartyCount(player), 0x0002);
            L00AC: if (JumpBelowOrEqual) goto L00E1;
            L00AE: AddEncounter(player, 0x03, 0x24);
            L00C0: AddEncounter(player, 0x04, 0x25);
            L00D2: goto L00E1;
            L00D4: ShowMessage(player, String13CC); // The lair is empty.
            L00E1: return; // RETURN;
        }

        private void Fn_10(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x02));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00D4;
            L001B: ShowMessage(player, String13A9); // There they are, ready and waiting!
            L0028: SetFlag(player, 0x03, 0x02, 0x01);
0F18  003D B8 AC 0C  mov ax, 0xcac
            L0040: PushStack(player, ax);
            L0041: PushStack(player, 0x00);
            L0044: PushStack(player, ax);
            L0045: PushStack(player, ax);
            L0046: PushStack(player, 0xBB);
            L004A: PushStack(player, 0xEE);
0F29  004E C4 5E 06  les bx, [bp+0x6]
0F2C  0051 26 FF 9F D8 00  call far word [es:bx+0xd8]
0F31  0056 83 C4 0C  add sp, 0xc
            L0059: AddEncounter(player, 0x01, 0x25);
            L006B: AddEncounter(player, 0x05, 0x24);
            L007D: AddEncounter(player, 0x02, 0x25);
            L008F: AddEncounter(player, 0x06, 0x24);
            L00A1: Compare(PartyCount(player), 0x0002);
            L00AC: if (JumpBelowOrEqual) goto L00E1;
            L00AE: AddEncounter(player, 0x03, 0x24);
            L00C0: AddEncounter(player, 0x04, 0x24);
            L00D2: goto L00E1;
            L00D4: ShowMessage(player, String13CC); // The lair is empty.
            L00E1: return; // RETURN;
        }

        private void Fn_11(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x02));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00D4;
            L001B: ShowMessage(player, String13A9); // There they are, ready and waiting!
            L0028: SetFlag(player, 0x03, 0x02, 0x01);
0FFB  003D B8 AC 0C  mov ax, 0xcac
            L0040: PushStack(player, ax);
            L0041: PushStack(player, 0x00);
            L0044: PushStack(player, ax);
            L0045: PushStack(player, ax);
            L0046: PushStack(player, 0xBB);
            L004A: PushStack(player, 0xEE);
100C  004E C4 5E 06  les bx, [bp+0x6]
100F  0051 26 FF 9F D8 00  call far word [es:bx+0xd8]
1014  0056 83 C4 0C  add sp, 0xc
            L0059: AddEncounter(player, 0x01, 0x23);
            L006B: AddEncounter(player, 0x05, 0x24);
            L007D: AddEncounter(player, 0x02, 0x23);
            L008F: AddEncounter(player, 0x06, 0x24);
            L00A1: Compare(PartyCount(player), 0x0002);
            L00AC: if (JumpBelowOrEqual) goto L00E1;
            L00AE: AddEncounter(player, 0x03, 0x24);
            L00C0: AddEncounter(player, 0x04, 0x24);
            L00D2: goto L00E1;
            L00D4: ShowMessage(player, String13CC); // The lair is empty.
            L00E1: return; // RETURN;
        }

        private void Fn_12(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x03);
            L0007: PushStack(player, ax);
10A9  0008 C4 5E 06  les bx, [bp+0x6]
10AC  000B 26 FF 5F 04  call far word [es:bx+0x4]
            L000F: cx = PopStack(player);
            L0010: cx = PopStack(player);
            L0011: Compare(ax, 0x0001);
            L0014: if (JumpNotEqual) goto L0037;
            L0016: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0034: goto L011A;
            L0037: Compare(GetFlag(player, 0x03, 0x09), 0x0001);
            L004B: if (JumpNotEqual) goto L0074;
            L004D: ax = HasItem(player, 0xEF);
            L005B: if (JumpEqual) goto L0074;
            L005D: ShowMessage(player, String13DF); // Ah ha!  Medusa ho!  And no, that is most definitely not street slang!  Boy, I always have to watch what I say around you, don't I?
            L006A: PushStack(player, 0x02);
110F  006E B8 ED 00  mov ax, 0xed
            L0071: goto L0106;
            L0074: ax = HasItem(player, 0xEF);
            L0082: if (JumpEqual) goto L00B4;
            L0084: ShowMessage(player, String1462); // Medusae ho!  You charge into their ambush, having little choice in the matter!
            L0091: DamagePlayer(player, 0x0BB8);
            L009E: AddMana(player, 0xFC18);
            L00AB: PushStack(player, 0x02);
1150  00AF B8 EE 00  mov ax, 0xee
            L00B2: goto L0106;
            L00B4: Compare(GetFlag(player, 0x03, 0x09), 0x0001);
            L00C8: if (JumpNotEqual) goto L00D8;
116B  00CA B8 62 14  mov ax, 0x1462
            L00CD: PushStack(player, ax);
116F  00CE C4 5E 06  les bx, [bp+0x6]
1172  00D1 26 FF 9F F8 00  call far word [es:bx+0xf8]
            L00D6: goto L00FE;
            L00D8: ShowMessage(player, String1462); // Medusae ho!  You charge into their ambush, having little choice in the matter!
            L00E5: DamagePlayer(player, 0x0BB8);
            L00F2: AddMana(player, 0xFC18);
            L00FF: TeleportParty(player, 0x0B, 0x03, 0xEF, 0x02, isForwardMove);
            L011A: return; // RETURN;
        }

        private void Fn_13(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x0C));
            L0016: if (JumpNotEqual) goto L003C;
            L0018: ShowMessage(player, String14B1); // There are some footprints in the dust leading to the east on the southern side of the partition.
            L0025: SetFlag(player, 0x03, 0x0C, 0x01);
            L003A: goto L0049;
            L003C: ShowMessage(player, String1512); // This closet appears much the same as the last time you were here.
            L0049: return; // RETURN;
        }

        private void Fn_14(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x03);
            L0007: PushStack(player, ax);
1210  0008 C4 5E 06  les bx, [bp+0x6]
1213  000B 26 FF 5F 04  call far word [es:bx+0x4]
            L000F: cx = PopStack(player);
            L0010: cx = PopStack(player);
            L0011: RefreshCompareFlags(ax);
            L0013: if (JumpEqual) goto L0018;
            L0015: goto L00C1;
            L0018: PushStack(player, 0x01);
            L001C: PushStack(player, 0x03);
            L0020: PushStack(player, ax);
1229  0021 C4 5E 06  les bx, [bp+0x6]
122C  0024 26 FF 1F  call far word [es:bx]
122F  0027 83 C4 06  add sp, 0x6
1232  002A B8 DC 04  mov ax, 0x4dc
            L002D: PushStack(player, ax);
            L002E: PushStack(player, 0x00);
            L0031: PushStack(player, ax);
            L0032: PushStack(player, ax);
            L0033: PushStack(player, 0xEF);
            L0037: PushStack(player, 0xEE);
1243  003B C4 5E 06  les bx, [bp+0x6]
1246  003E 26 FF 9F D8 00  call far word [es:bx+0xd8]
124B  0043 83 C4 0C  add sp, 0xc
            L0046: AddEncounter(player, 0x01, 0x26);
            L0058: AddEncounter(player, 0x05, 0x27);
            L006A: AddEncounter(player, 0x02, 0x26);
            L007C: Compare(PartyCount(player), 0x0002);
            L0087: if (JumpBelowOrEqual) goto L00CE;
            L0089: AddEncounter(player, 0x06, 0x27);
            L009B: AddEncounter(player, 0x03, 0x26);
            L00AD: AddEncounter(player, 0x04, 0x26);
            L00BF: goto L00CE;
            L00C1: ShowMessage(player, String1554); // You now know exactly how many snake steaks there are in a medusa's coif; exactly one fenny filet's worth!
            L00CE: return; // RETURN;
        }

        private void Fn_15(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x03);
            L0007: PushStack(player, ax);
12E0  0008 C4 5E 06  les bx, [bp+0x6]
12E3  000B 26 FF 5F 04  call far word [es:bx+0x4]
            L000F: cx = PopStack(player);
            L0010: cx = PopStack(player);
            L0011: RefreshCompareFlags(ax);
            L0013: if (JumpEqual) goto L0018;
            L0015: goto L00C1;
            L0018: PushStack(player, 0x01);
            L001C: PushStack(player, 0x03);
            L0020: PushStack(player, ax);
12F9  0021 C4 5E 06  les bx, [bp+0x6]
12FC  0024 26 FF 1F  call far word [es:bx]
12FF  0027 83 C4 06  add sp, 0x6
1302  002A B8 DC 04  mov ax, 0x4dc
            L002D: PushStack(player, ax);
            L002E: PushStack(player, 0x00);
            L0031: PushStack(player, ax);
            L0032: PushStack(player, ax);
            L0033: PushStack(player, 0xEF);
            L0037: PushStack(player, 0xEE);
1313  003B C4 5E 06  les bx, [bp+0x6]
1316  003E 26 FF 9F D8 00  call far word [es:bx+0xd8]
131B  0043 83 C4 0C  add sp, 0xc
            L0046: AddEncounter(player, 0x01, 0x27);
            L0058: AddEncounter(player, 0x05, 0x28);
            L006A: AddEncounter(player, 0x02, 0x28);
            L007C: AddEncounter(player, 0x06, 0x27);
            L008E: Compare(PartyCount(player), 0x0002);
            L0099: if (JumpBelowOrEqual) goto L00CE;
            L009B: AddEncounter(player, 0x03, 0x28);
            L00AD: AddEncounter(player, 0x04, 0x26);
            L00BF: goto L00CE;
            L00C1: ShowMessage(player, String1554); // You now know exactly how many snake steaks there are in a medusa's coif; exactly one fenny filet's worth!
            L00CE: return; // RETURN;
        }

        private void Fn_16(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x03);
            L0007: PushStack(player, ax);
13B0  0008 C4 5E 06  les bx, [bp+0x6]
13B3  000B 26 FF 5F 04  call far word [es:bx+0x4]
            L000F: cx = PopStack(player);
            L0010: cx = PopStack(player);
            L0011: RefreshCompareFlags(ax);
            L0013: if (JumpEqual) goto L0018;
            L0015: goto L00C1;
            L0018: PushStack(player, 0x01);
            L001C: PushStack(player, 0x03);
            L0020: PushStack(player, ax);
13C9  0021 C4 5E 06  les bx, [bp+0x6]
13CC  0024 26 FF 1F  call far word [es:bx]
13CF  0027 83 C4 06  add sp, 0x6
13D2  002A B8 DC 04  mov ax, 0x4dc
            L002D: PushStack(player, ax);
            L002E: PushStack(player, 0x00);
            L0031: PushStack(player, ax);
            L0032: PushStack(player, ax);
            L0033: PushStack(player, 0xEF);
            L0037: PushStack(player, 0xEE);
13E3  003B C4 5E 06  les bx, [bp+0x6]
13E6  003E 26 FF 9F D8 00  call far word [es:bx+0xd8]
13EB  0043 83 C4 0C  add sp, 0xc
            L0046: AddEncounter(player, 0x01, 0x28);
            L0058: AddEncounter(player, 0x05, 0x28);
            L006A: AddEncounter(player, 0x02, 0x28);
            L007C: AddEncounter(player, 0x06, 0x28);
            L008E: Compare(PartyCount(player), 0x0002);
            L0099: if (JumpBelowOrEqual) goto L00CE;
            L009B: AddEncounter(player, 0x03, 0x28);
            L00AD: AddEncounter(player, 0x04, 0x28);
            L00BF: goto L00CE;
            L00C1: ShowMessage(player, String1554); // You now know exactly how many snake steaks there are in a medusa's coif; exactly one fenny filet's worth!
            L00CE: return; // RETURN;
        }

        private void Fn_17(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0003);
            L0010: Compare(GetFlag(player, 0x03, 0x0D), 0x0001);
            L0024: if (JumpNotEqual) goto L002C;
149E  0026 B8 BE 15  mov ax, 0x15be
            L0029: goto L010E;
            L002C: ShowMessage(player, String15DD); // The minotaur is calling out, and there is rather a long line waiting in front of him.  You step in line and listen to his patter.
            L0039: ShowMessage(player, String165F); // 'Step right up, step right up, the freshest dairy product known to cow.  Yes indeed, the fabled milk of human kindness, just five hundred smackeroos and a suitable container.'
            L0046: ShowMessage(player, String170F); // 'One to a customer, no need to shove, there's plenty more where that came from.  Hey there, whippersnapper, what's your hurry?  Everyone gets their turn.'
            L0053: ax = HasItem(player, 0xCB);
            L0061: if (JumpEqual) goto L00A4;
            L0063: RemoveItem(player, 0xCB);
            L006F: GiveItem(player, 0xEE);
            L007B: ModifyGold(player, 0xFFFF0CBA);
            L008D: SetFlag(player, 0x03, 0x0D, 0x01);
            L00A2: goto L00E8;
            L00A4: ax = HasItem(player, 0xCC);
            L00B2: if (JumpEqual) goto L00B9;
152C  00B4 B8 CC 00  mov ax, 0xcc
            L00B7: goto L0066;
            L00B9: ax = HasItem(player, 0xCD);
            L00C7: if (JumpEqual) goto L00CE;
1541  00C9 B8 CD 00  mov ax, 0xcd
            L00CC: goto L0066;
            L00CE: ShowMessage(player, String17AA); // 'I said suitable, and those lousy bottles are at least a pants leg shy.  Come back with a bottle that held something that won't spoil the ineluctable flavor of the milk and you'll get some.'
            L00DB: ShowMessage(player, String1869); // 'Now off with you.  I've got paying customers waiting, and the line isn't moving with you parked here!  Begone, rapscallion!'
            L00E8: Compare(GetFlag(player, 0x03, 0x0D), 0x0001);
            L00FC: if (JumpNotEqual) goto L0118;
            L00FE: ShowMessage(player, String18E7); // 'It's been a business doing kefir with you.  Be sure and keep that bottle sealed until you use it.  Why, just last week the seal dropped a bottle and it took a set of superhuman lungs to retrieve it!'
            L010B: ShowMessage(player, String19B0); // This guy's weird (heck, this whole game is listing about three degrees to port) but the milk of human kindness is well worth the effort.
            L0118: return; // RETURN;
        }

        private void Fn_18(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x04));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00FC;
            L001B: SetFlag(player, 0x03, 0x04, 0x01);
            L0030: Compare(GetFlag(player, 0x03, 0x0D), 0x0001);
            L0044: if (JumpNotEqual) goto L004B;
15D8  0046 B8 39 1A  mov ax, 0x1a39
            L0049: goto L004E;
            L004B: ShowMessage(player, String1A7B); // A menacing mob of 'Mc's' decides that they can use their milk of human kindness to defeat you!
15EA  0058 B8 45 03  mov ax, 0x345
            L005B: PushStack(player, ax);
            L005C: PushStack(player, 0x00);
            L005F: PushStack(player, ax);
            L0060: PushStack(player, ax);
            L0061: PushStack(player, 0xBA);
            L0065: PushStack(player, 0xEE);
15FB  0069 C4 5E 06  les bx, [bp+0x6]
15FE  006C 26 FF 9F D8 00  call far word [es:bx+0xd8]
1603  0071 83 C4 0C  add sp, 0xc
            L0074: AddEncounter(player, 0x01, 0x21);
            L0086: AddEncounter(player, 0x02, 0x22);
            L0098: Compare(PartyCount(player), 0x0001);
            L00A3: if (JumpBelowOrEqual) goto L00C9;
            L00A5: AddEncounter(player, 0x03, 0x22);
            L00B7: AddEncounter(player, 0x04, 0x21);
            L00C9: Compare(PartyCount(player), 0x0002);
            L00D4: if (JumpBelowOrEqual) goto L0109;
            L00D6: AddEncounter(player, 0x05, 0x22);
            L00E8: AddEncounter(player, 0x06, 0x21);
            L00FA: goto L0109;
            L00FC: ShowMessage(player, String1ADA); // You really put those dukes up to a fight!
            L0109: return; // RETURN;
        }

        private void Fn_19(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x05));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00E1;
            L001B: SetFlag(player, 0x03, 0x05, 0x01);
            L0030: ShowMessage(player, String1B04); // A terrible team of trolls decides that you are interupting their services.  Or, knowing trolls, maybe they are just a might peckish.
16DA  003D B8 45 03  mov ax, 0x345
            L0040: PushStack(player, ax);
            L0041: PushStack(player, 0x00);
            L0044: PushStack(player, ax);
            L0045: PushStack(player, ax);
            L0046: PushStack(player, 0xBA);
            L004A: PushStack(player, 0xEE);
16EB  004E C4 5E 06  les bx, [bp+0x6]
16EE  0051 26 FF 9F D8 00  call far word [es:bx+0xd8]
16F3  0056 83 C4 0C  add sp, 0xc
            L0059: AddEncounter(player, 0x01, 0x20);
            L006B: AddEncounter(player, 0x02, 0x20);
            L007D: Compare(PartyCount(player), 0x0001);
            L0088: if (JumpBelowOrEqual) goto L00AE;
            L008A: AddEncounter(player, 0x03, 0x20);
            L009C: AddEncounter(player, 0x04, 0x20);
            L00AE: Compare(PartyCount(player), 0x0002);
            L00B9: if (JumpBelowOrEqual) goto L00EE;
            L00BB: AddEncounter(player, 0x05, 0x20);
            L00CD: AddEncounter(player, 0x06, 0x20);
            L00DF: goto L00EE;
            L00E1: ShowMessage(player, String1B89); // You really showed them who was in con-troll!
            L00EE: return; // RETURN;
        }

        private void Fn_1A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x06));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00E1;
            L001B: SetFlag(player, 0x03, 0x06, 0x01);
            L0030: ShowMessage(player, String1BB6); // Eewwe!  Evil Ectoplasmic Entities!  And you just had your armor deslimed!
17CA  003D B8 45 03  mov ax, 0x345
            L0040: PushStack(player, ax);
            L0041: PushStack(player, 0x00);
            L0044: PushStack(player, ax);
            L0045: PushStack(player, ax);
            L0046: PushStack(player, 0xBA);
            L004A: PushStack(player, 0xEE);
17DB  004E C4 5E 06  les bx, [bp+0x6]
17DE  0051 26 FF 9F D8 00  call far word [es:bx+0xd8]
17E3  0056 83 C4 0C  add sp, 0xc
            L0059: AddEncounter(player, 0x01, 0x1D);
            L006B: AddEncounter(player, 0x02, 0x1D);
            L007D: Compare(PartyCount(player), 0x0001);
            L0088: if (JumpBelowOrEqual) goto L00AE;
            L008A: AddEncounter(player, 0x03, 0x1D);
            L009C: AddEncounter(player, 0x04, 0x1D);
            L00AE: Compare(PartyCount(player), 0x0002);
            L00B9: if (JumpBelowOrEqual) goto L00EE;
            L00BB: AddEncounter(player, 0x05, 0x1D);
            L00CD: AddEncounter(player, 0x06, 0x1D);
            L00DF: goto L00EE;
            L00E1: ShowMessage(player, String1C00); // You already ended those entity's enmity entirely!
            L00EE: return; // RETURN;
        }

        private void Fn_1B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x07));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00E1;
            L001B: SetFlag(player, 0x03, 0x07, 0x01);
            L0030: ShowMessage(player, String1C32); // Are those but phantoms of the mind, or are they real?  Either way, they are trying to kill you!
18BA  003D B8 45 03  mov ax, 0x345
            L0040: PushStack(player, ax);
            L0041: PushStack(player, 0x00);
            L0044: PushStack(player, ax);
            L0045: PushStack(player, ax);
            L0046: PushStack(player, 0xBA);
            L004A: PushStack(player, 0xEE);
18CB  004E C4 5E 06  les bx, [bp+0x6]
18CE  0051 26 FF 9F D8 00  call far word [es:bx+0xd8]
18D3  0056 83 C4 0C  add sp, 0xc
            L0059: AddEncounter(player, 0x01, 0x1E);
            L006B: AddEncounter(player, 0x02, 0x1E);
            L007D: Compare(PartyCount(player), 0x0001);
            L0088: if (JumpBelowOrEqual) goto L00AE;
            L008A: AddEncounter(player, 0x03, 0x1E);
            L009C: AddEncounter(player, 0x04, 0x1E);
            L00AE: Compare(PartyCount(player), 0x0002);
            L00B9: if (JumpBelowOrEqual) goto L00EE;
            L00BB: AddEncounter(player, 0x05, 0x1E);
            L00CD: AddEncounter(player, 0x06, 0x1E);
            L00DF: goto L00EE;
            L00E1: ShowMessage(player, String1C92); // They called themselves powerful protoplasmic phantoms, but you thought they fought like normal run of the mill protoplasmic phantoms.  Or maybe you're just getting good at this!
            L00EE: return; // RETURN;
        }

        private void Fn_1C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x0E));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00D4;
            L001B: SetFlag(player, 0x03, 0x0E, 0x01);
            L0030: ShowMessage(player, String1D44); // A veritable village of vampires has decided that you are the blood bank.  And they intend to make a withdrawal!
19AA  003D B8 45 03  mov ax, 0x345
            L0040: PushStack(player, ax);
            L0041: PushStack(player, 0x00);
            L0044: PushStack(player, ax);
            L0045: PushStack(player, ax);
            L0046: PushStack(player, 0xBA);
            L004A: PushStack(player, 0xEE);
19BB  004E C4 5E 06  les bx, [bp+0x6]
19BE  0051 26 FF 9F D8 00  call far word [es:bx+0xd8]
19C3  0056 83 C4 0C  add sp, 0xc
            L0059: AddEncounter(player, 0x01, 0x1F);
            L006B: AddEncounter(player, 0x02, 0x1F);
            L007D: AddEncounter(player, 0x03, 0x1F);
            L008F: AddEncounter(player, 0x04, 0x1F);
            L00A1: Compare(PartyCount(player), 0x0002);
            L00AC: if (JumpBelowOrEqual) goto L00E1;
            L00AE: AddEncounter(player, 0x05, 0x1F);
            L00C0: AddEncounter(player, 0x06, 0x1F);
            L00D2: goto L00E1;
            L00D4: ShowMessage(player, String1DB4); // You really showed them that the blood bank was closed.
            L00E1: return; // RETURN;
        }

        private void Fn_1D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
1A53  0003 C4 5E 06  les bx, [bp+0x6]
1A56  0006 26 FF 9F C8 00  call far word [es:bx+0xc8]
            L000B: SetNoHealZone(player);
            L0013: ShowMessage(player, String1DEB); // This room is so dusty that you can barely breath.  In fact, the dust is chokingly thick!
            L0020: DamagePlayer(player, 0x03E8);
            L002D: return; // RETURN;
        }

        private void Fn_1E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1E44); // You find an old dressmaker's dummy.
            L0010: return; // RETURN;
        }

        private void Fn_1F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1E68); // You find an empty trunk.  Not an elephant's, either.
            L0010: return; // RETURN;
        }

        private void Fn_20(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1E9D); // You find a cigar box full of old baseball cards.  However, since you don't know what a baseball card is, you ignore it.
            L0010: return; // RETURN;
        }

        private void Fn_21(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1F15); // You find an old sled.  Evidently it didn't go into the furnace after all.
            L0010: return; // RETURN;
        }

        private void Fn_22(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1F5F); // You find a pair of red sequined dancing shoes.
            L0010: return; // RETURN;
        }

        private void Fn_23(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1F8E); // You find a thing shaped like a four battery flashlight.  When you twist it a beam of gleaming light extends out about four feet, making a funny humming noise.  You decide it's worthless in a fantasy game, and discard it.
            L0010: return; // RETURN;
        }

        private void Fn_24(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String206B); // You find an old blonde fright wig and a rubber horn.  And two hard-boiled eggs.
            L0010: return; // RETURN;
        }

        private void Fn_25(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String20BB); // You find a large warhammer with adornments of lightning worked into it, but you're not strong enough to lift it.
            L0010: return; // RETURN;
        }

        private void Fn_26(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String212C); // You find a black cricket bat.
            L0010: return; // RETURN;
        }

        private void Fn_27(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String214A); // You find a philosopher's stone.  Not being a philosopher, you leave it behind.
            L0010: return; // RETURN;
        }

        private void Fn_28(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String2199); // You find a pair of x-ray glasses.  At your first glance you can see through the armor and clothes of a member of the opposite sex three rooms away.  You blush beet red and quickly take them off.
            L0010: return; // RETURN;
        }

        private void Fn_29(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String225C); // You find a Walther PPK.  You use it to crack a walnut.  It doesn't do a very good job, so you abandon it.
            L0010: return; // RETURN;
        }

        private void Fn_2A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String22C6); // You find a black cape with a strange serpentine emblem on it.  You decide to leave it here.
            L0010: return; // RETURN;
        }

        private void Fn_2B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String2322); // You find a long cherry wood pipe and some pipe tobacco stuffed inside a slipper.  However, you don't smoke, or at least you restrict your smoking to the aftermath of being fireballed.
            L0010: return; // RETURN;
        }

        private void Fn_2C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String23DA); // You find an ornate, gilded bottle.  You shake it a few times to see if it's empty, thoroughly smashing the genie inside.  There will be no wishes for you today!
            L0010: return; // RETURN;
        }

        private void Fn_2D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String247B); // You find a pair of old football shoes.
            L0010: return; // RETURN;
        }

        private void Fn_2E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String24A2); // You find a set of tiki lamps.  They don't taste very good, so you leave them behind.
            L0010: return; // RETURN;
        }

        private void Fn_2F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String24F7); // You find a set of oars, but, and this is indeed a sad commentary on your life, no boat to row.
            L0010: return; // RETURN;
        }

        private void Fn_30(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String2556); // You find an old orange life preserver.  Funny, it didn't seem to do much for the stiff wearing it.
            L0010: return; // RETURN;
        }

        private void Fn_31(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String25B9); // You find an old bowling ball.
            L0010: return; // RETURN;
        }

        private void Fn_32(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String25D7); // You find a carton full of baby pictures.  Yes, wraiths are just as ugly as babies as they are fully grown.  You leave it.
            L0010: return; // RETURN;
        }

        private void Fn_33(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String2651); // There is a sign on the wall that reads: 'The Wizards of Cawdor (WoC) have thoroughly examined the room at the end of this hall.  It contains nothing of value or interest for you, and will almost certainly kill you.  Enter at your own risk.'
            L0010: ShowMessage(player, String2742); // Not a very cheery message, is it?  And everybody knows that wizards never lie.  I hear there's a new Mead Hall that just opened downstairs.  Suppose we go there instead?
            L001D: return; // RETURN;
        }

    }
}
