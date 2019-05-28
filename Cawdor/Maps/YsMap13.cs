#pragma warning disable
using System.Collections.Generic;
using XPT.WorldData;
using XPT.WorldData.Yserbius;

namespace XPT.Scripts.Yserbius.Maps {
    class YserMap13 : AMapScripted {
        protected override int MapIndex => 13;
        protected override int RandomEncounterChance => 10;
        protected override int RandomEncounterExtraCount => 0;

        public YserMap13() {
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
        }
        
        // === Strings ================================================
        private const string String0140 = "Ah!  Here's where Malcolm's good stuff was kept!";
        private const string String0171 = "You've picked the lock. Proceed.";
        private const string String0192 = "Funny how an irksome little lock on a flimsy little door can keep out a big strong person like you.";
        private const string String01F6 = "There are significant marks indicating many beings went north from here, and recently.";
        private const string String024D = "You hear some folks walking towards you.";
        private const string String0276 = "'Pardon us, good gentles.  We seek a multi-headed hydra we have heard tell was to be found hereabouts.  We need a a baritone and soprano for our choir, and can only afford to pay one more person.  Knowest thou where the hydra can be found?'";
        private const string String0367 = "You tell her you cannot help her.";
        private const string String0389 = "'Oh.'  She droops and rejoins her troop.  As they wander off, you hear one of them say, 'I still say that if the medusa's snakes could whistle in turn, then she would suffice!'  You see the others beating at the speaker with their hats as they round a corner.";
        private const string String048D = "You hear someone running towards you.";
        private const string String04B3 = "An obviously perturbed human wizard runs toward you.";
        private const string String04E8 = "'As thou values thy life!  Leave this place, lest sweet reason leave thee.  Augh!  The bagpipes echo yet in my brain!'";
        private const string String055F = "He runs off, clutching his ears.";
        private const string String0580 = "The dragon greets you heartily.";
        private const string String05A0 = "'Ah!  Thou art one of those small two legged folks.  I heard that one of thy ilk seeks a dragon to provide wind for a pipe organ.  Art thou the one?'";
        private const string String0636 = "You politely inform the dragon that you do not wish him to play with your organs, and wish him luck in finding employment.";
        private const string String06B1 = "Never again will Rory play a tune in this room or any other.";
        private const string String06EE = "'Well met, gentle beings.  I have found many undead hereabouts, but as thou hast already heard, I am well equipped with items proof against the undying.";
        private const string String0787 = "Oh, and tread softly in the auditorium, lest the organ begin its tune of death.";
        private const string String07D7 = "The halfling struts off, smiling.";
        private const string String07F9 = "*";
        private const string String07FB = "A slew of short sorcerors decide that you are an easier target than the undead.";
        private const string String084B = "This door leads to the Ballroom.";
        private const string String086C = "'Two trolls, a knight and a cleric by their garb, courteously hold open a secret door for you.  'Watch your back in here,' they caution you.  'There is many a dagger in amongst the cloaks.'";
        private const string String092A = "The door to the Cloak Room refuses to budge.";
        private const string String0957 = "An enormous fur clad humanoid rises from the basin.";
        private const string String098B = "'I, Mannanan Mac Lir, am not so trusting as that penitent pest.  Before I will grant thee my aid, thou must prove thy worth by deciphering this puzzle:";
        private const string String0A23 = "'The door to my watery sanctuary is South, and North, and South again, thricely done, starting from where mine own tale has been writ and stored, and then back into the widdershins corner from where thou didst arrive.";
        private const string String0AFD = "But not always do my directions coincide with the compass; thou must know the labels to find me.  Show thy wit to be all encompassing, and my aid thou shalt have, in full measure.'";
        private const string String0BB2 = "Mannanan sinks back into the roiling waters.";
        private const string String0BDF = "Again Mannanan Mac Lir rises from the waters.";
        private const string String0C0D = "'Do you think I am some cur, to come at thy beck and call!  I have told thee what thou must do: find my tome, go South, North, South, thrice, and then into the widdershins corner, to come to a place where I can deal with thee more directly.  I shall take my ring until that time, if it ever comes!'";
        private const string String0D38 = "He takes his ring, roughly, and sinks back into the churning basin.";
        private const string String0D7C = "This was a nasty place for an ambush, wasn't it?";
        private const string String0DAD = "This must be where they clean the instruments.  Many shelves hold rags, and in the corner is a basin full of dirty water large enough to completely immerse a tuba, assuming one had a tuba that one wanted to immerse.";
        private const string String0E85 = "The room is full of debris and has many hiding places.";
        private const string String0EBC = "You think an ambush has been prepared to the north.";
        private const string String0EF0 = "Sometimes it pays to be cautious and check for tracks.  This was one of those times.";
        private const string String0F45 = "From the now visible crossbows and ballistae, you are awfully glad they did not get the drop on you.";
        private const string String0FAA = "If you had bolted from this battle, you would have really gotten bolted!";
        private const string String0FF3 = "A cold breeze sends shivers down your spine.";
        private const string String1020 = "It would be awfully convenient for those skeletons to be travelling with their own bandages, if they had any skin left to bandage!";
        private const string String10A3 = "And if there is any loose blood flowing, you can count on these suckers to slurp it up!";
        private const string String10FB = "All that remains from your battle here is a dirty pile of gauze.";
        private const string String113C = "Hooves and horns!  'Tis Malcolm's ghost!  Have at!";
        private const string String116F = "Not so fast!  This door is locked, and it it's not going to unlock itself unless you say please.  Or, in your case, pretty please.";
        private const string String11F2 = "You rush forward to face Malcolm's shade!";
        private const string String121C = "Malcolm's lair certainly was well stocked.";
        private const string String1247 = "You rush forward to meet Malcolm's shade!";
        private const string String1271 = "'If you are going to fight undead, it is a lot more profitable to fight undead kings,' you think to yourself.";
        private const string String12DF = "You find a veritable king's ransom.  Of course, back before he died, Malcolm was a veritable king.";
        private const string String1342 = "All that remains of your battle here are some bones, and occasional pieces of skin.";
        private const string String1396 = "A large group of spell casters decides to start waving their wands in your direction.";
        private const string String13EC = "No, not that kind of wand!  Does this look like CasinoLand?";
        private const string String1428 = "Somehow, the crunch of combat is not as satisfying when you are fighting fellow adventurers.";
        private const string String1485 = "Why is it that so many adventurers are attacking you on sight?  Could it be a personal hygiene problem?";
        private const string String14ED = "Magic can compensate for size in a big way.  You are just grateful that the way you fought them wasn't quite big enough.";
        private const string String1566 = "It looks like it's about time to gremlin and bear it.";
        private const string String159C = "All that remains of your battle here is a holey tooth.  No, I don't mean sanctified.";
        private const string String15F1 = "You were warned this was a den of undead.  If you didn't stock up on your garlic you have nobody to blame but yourself.";
        private const string String1669 = "You didn't mind these clerics blessing you, but when they tried to bless you upside your head, you had no choice but to show them the error of their ways, in accordance with the old adage: she whose blesses last blesses last.";
        private const string String174B = "You've heard of religious fervor, but these clerics seem a bit extreme!";
        private const string String1793 = "'I prefer my ribs inanimate,' you think to yourself as you recall this battleground.";
        private const string String17E8 = "Oh the knee bone's connected to the thigh bone, and these bones are connected to the banshees.";
        private const string String1847 = "Ah hah!  It must be the large pipe organ to the north that is attracting all these monster to this large auditorium.";
        private const string String18BC = "North of here are the columns of the organ.  They are dusty and covered by spider webs.  Some of the pipes look old and fragile; others look old and well-made.";
        private const string String195C = "It's obvious that this organ has been badly abused and will never play again.";
        private const string String19AA = "There are no more succubus pipes here.  But at least there are no more spiders, either.";
        private const string String1A02 = "As you fumble with the organ (can I say that on INN?) you feel something magical tingle as you grasp and attempt to retrieve it.";
        private const string String1A83 = "But a small venomous spider shows her disapproval of your disturbing her web, and bites! Your hand jerks reflexively and the item you had grasped flies to the south.";
        private const string String1B29 = "Congratulations!  You found a set of Succubus Pipes!";
        private const string String1B5E = "To the north is the organ's keyboard.  Its hard wooden bench looks dusty and uncomfortable.";
        private const string String1BBA = "A minotaur, seated at a set of drums, stops his banging long enough to point one of his sticks at you.  The stick has the word 'Alcuin' engraved on it.";
        private const string String1C52 = "'I can detect honest folk who will not attack out of hand.  But I must learn this passage before the big concert.  Please do not let the door hit thee on the way out.'";
        private const string String1CFA = "A rather haggard halfling waves a bandaged hand at you.";
        private const string String1D32 = "'I heard that an old bard hid his pipes of control in the pipes near here, but all I got for my efforts was a visit from a venomous old tomnoddy.  Never again will I believe every bit of legend I hear.'";
        private const string String1DFD = "There is no need for thee to return hence.  I am too small to eat, too poor to rob, and too morose to be good company.  Prithee, depart; leave me to ponder my failures and plot my future course.";
        private const string String1EC0 = "An orc is carefully playing a bagpipe.  What other instrument would you expect an orc to be playing, if not a well-known implement of torture.";
        private const string String1F4F = "'Ah, some fine bonny music lovers!  I knew if I but played long enough that I would attract refined folk in search of a concert.  I have no chairs for ye, and my repertoire includes the complete works of Grashnok of the Bloody Lobes, so I know ye'll be wanting at least half a score intermissions.'";
        private const string String207A = "You stammer your apologies and look for the exit.";
        private const string String20AC = "An orc is carefully playing a buzzy.  Of course, except to another buzzy player it is impossible to know whether he is playing it well or poorly.  Without stopping, he passes you a note.";
        private const string String2167 = "That is, a piece of paper; you'll gladly skip the other notes he is passing you.  The note reads:";
        private const string String21C9 = "'Lady Macbeth's Ghost is guarded by fiercesome beasts.  It is foretold that before she can be defeated you must first fight three of the clawed, four of the hooved, and finally the winged.";
        private const string String2286 = "Without stopping, the orc nods at you, and at the door.";
        private const string String22BE = "'Gadzooks, but it has been an interminable wait here.  I have already finished exploring the Ballroom and the Music Room, and I hope I do not have to wait all knight to get into the Cloak Room.'";
        private const string String2381 = "'Many thanks for thy kind offer, but Sir Colin de Waggonnes has assured me that he will join me at this hour.  I feel honor bound to wait for him rather than accompany thee.  God'ee a good'un, cousin.";
        private const string String244A = "A pile of skeletons stops playing themselves like xylophones in order to start beating you like drums.  What's worse, they seem to be regenerating.";
        
        // === Functions ================================================
        private void Fn_02(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFlag(player, 0x02, 0x2A, 0x01);
            L0018: Compare(GetFlag(player, 0x03, 0x0A), 0x0001);
            L002C: if (JumpNotEqual) goto L009D;
            L002E: RefreshCompareFlags(GetFlag(player, 0x03, 0x14));
            L0041: if (JumpNotEqual) goto L009D;
            L0043: ax = HasItem(player, 0xE8);
            L0051: if (JumpNotEqual) goto L009D;
            L0053: ax = HasItem(player, 0xE9);
            L0061: if (JumpNotEqual) goto L009D;
            L0063: GiveItem(player, 0xE8);
            L006F: GiveItem(player, 0xE9);
            L007B: ShowMessage(player, String0140); // Ah!  Here's where Malcolm's good stuff was kept!
            L0088: SetFlag(player, 0x03, 0x14, 0x01);
            L009D: return; // RETURN;
        }

        private void Fn_03(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x68);
            L0007: PushStack(player, ax);
00BA  0008 C4 5E 06  les bx, [bp+0x6]
00BD  000B 26 FF 5F 54  call far word [es:bx+0x54]
            L000F: cx = PopStack(player);
            L0010: cx = PopStack(player);
            L0011: RefreshCompareFlags(ax);
            L0013: if (JumpEqual) goto L008E;
            L0015: ax = HasItem(player, 0xC1);
            L0023: if (JumpEqual) goto L0028;
            L0025: goto L00DB;
            L0028: ax = HasItem(player, 0xC2);
            L0036: if (JumpEqual) goto L003B;
            L0038: goto L00DB;
            L003B: ax = HasItem(player, 0xC3);
            L0049: if (JumpEqual) goto L004E;
            L004B: goto L00DB;
            L004E: ax = HasItem(player, 0xDA);
            L005C: if (JumpNotEqual) goto L00DB;
            L005E: ax = HasItem(player, 0xDB);
            L006C: if (JumpNotEqual) goto L00DB;
            L006E: ax = HasItem(player, 0xDC);
            L007C: if (JumpNotEqual) goto L00DB;
            L007E: ax = HasItem(player, 0xDD);
            L008C: if (JumpNotEqual) goto L00DB;
            L008E: Compare(GetSkillLevel(player, 0x0E), 0x0006);
            L009D: if (JumpBelow) goto L00C9;
            L009F: ax = HasUsedItem(player, 0xC1, 0xC3);
            L00B2: if (JumpNotEqual) goto L00DB;
            L00B4: ax = HasUsedItem(player, 0xDA, 0xDD);
            L00C7: if (JumpNotEqual) goto L00DB;
            L00C9: PushStack(player, 0xC0);
            L00CD: PushStack(player, ax);
0180  00CE C4 5E 06  les bx, [bp+0x6]
0183  00D1 26 FF 5F 54  call far word [es:bx+0x54]
            L00D5: cx = PopStack(player);
            L00D6: cx = PopStack(player);
            L00D7: RefreshCompareFlags(ax);
            L00D9: if (JumpEqual) goto L0108;
            L00DB: ShowMessage(player, String0171); // You've picked the lock. Proceed.
            L00E8: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0106: goto L0132;
            L0108: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0125: ShowMessage(player, String0192); // Funny how an irksome little lock on a flimsy little door can keep out a big strong person like you.
            L0132: return; // RETURN;
        }

        private void Fn_04(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, 0x0B), 0x0005);
            L0012: if (JumpNotBelow) goto L004A;
            L0014: PushStack(player, 0xA6);
            L0018: PushStack(player, ax);
01FF  0019 C4 5E 06  les bx, [bp+0x6]
0202  001C 26 FF 5F 54  call far word [es:bx+0x54]
            L0020: cx = PopStack(player);
            L0021: cx = PopStack(player);
            L0022: RefreshCompareFlags(ax);
            L0024: if (JumpNotEqual) goto L004A;
            L0026: PushStack(player, 0x62);
            L002A: PushStack(player, ax);
0211  002B C4 5E 06  les bx, [bp+0x6]
0214  002E 26 FF 5F 54  call far word [es:bx+0x54]
            L0032: cx = PopStack(player);
            L0033: cx = PopStack(player);
            L0034: RefreshCompareFlags(ax);
            L0036: if (JumpNotEqual) goto L004A;
            L0038: PushStack(player, 0x8F);
            L003C: PushStack(player, ax);
0223  003D C4 5E 06  les bx, [bp+0x6]
0226  0040 26 FF 5F 54  call far word [es:bx+0x54]
            L0044: cx = PopStack(player);
            L0045: cx = PopStack(player);
            L0046: RefreshCompareFlags(ax);
            L0048: if (JumpEqual) goto L006C;
            L004A: ShowMessage(player, String01F6); // There are significant marks indicating many beings went north from here, and recently.
            L0057: SetFlag(player, 0x03, 0x09, 0x01);
            L006C: return; // RETURN;
        }

        private void Fn_05(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si, di);
            L0005: di = 0;
            L0007: si = 0;
            L0009: ax = GetFlag(player, 0x03, 0x08);
026E  001A 8B F8  mov di, ax
0270  001C 47     inc di
0271  001D 8B F7  mov si, di
            L001F: Compare(si, 0x13);
            L0022: if (JumpLessOrEqual) goto L002B;
0278  0024 8B C6  mov ax, si
            L0026: si = ax + 0xFFEC;
            L002B: Compare(si, 0x0E);
            L002E: if (JumpLessOrEqual) goto L0037;
0284  0030 8B C6  mov ax, si
            L0032: si = ax + 0xFFF1;
            L0037: Compare(si, 0x09);
            L003A: if (JumpLessOrEqual) goto L0043;
0290  003C 8B C6  mov ax, si
            L003E: si = ax + 0xFFF6;
            L0043: Compare(si, 0x04);
            L0046: if (JumpLessOrEqual) goto L004F;
029C  0048 8B C6  mov ax, si
            L004A: si = ax + 0xFFFB;
02A3  004F 0B F6  or si, si
02A5  0051 7D 02  jge 0x55
            L0053: si = 0;
            L0055: Compare(si, 0x1D);
            L0058: if (JumpLessOrEqual) goto L005C;
            L005A: si = 0;
02B0  005C 83 FF 1E  cmp di, 0x1e
            L005F: if (JumpLessOrEqual) goto L0063;
            L0061: di = 0;
02B7  0063 57     push di
            L0064: PushStack(player, 0x08);
            L0068: PushStack(player, 0x03);
02C0  006C C4 5E 06  les bx, [bp+0x6]
02C3  006F 26 FF 1F  call far word [es:bx]
02C6  0072 83 C4 06  add sp, 0x6
02C9  0075 83 FF 1A  cmp di, 0x1a
            L0078: if (JumpNotEqual) goto L007F;
02CE  007A B8 01 00  mov ax, 0x1
            L007D: goto L0081;
            L007F: PushStack(player, 0x00);
02D6  0082 83 FF 14  cmp di, 0x14
            L0085: if (JumpNotEqual) goto L008C;
02DB  0087 B8 01 00  mov ax, 0x1
            L008A: goto L008E;
02E0  008C 33 C0  xor ax, ax
            L008E: dx = PopStack(player);
02E3  008F 0B D0  or dx, ax
            L0091: PushStack(player, dx);
02E6  0092 83 FF 0E  cmp di, 0xe
            L0095: if (JumpNotEqual) goto L009C;
02EB  0097 B8 01 00  mov ax, 0x1
            L009A: goto L009E;
02F0  009C 33 C0  xor ax, ax
            L009E: dx = PopStack(player);
02F3  009F 0B D0  or dx, ax
            L00A1: PushStack(player, dx);
02F6  00A2 83 FF 08  cmp di, 0x8
            L00A5: if (JumpNotEqual) goto L00AC;
02FB  00A7 B8 01 00  mov ax, 0x1
            L00AA: goto L00AE;
0300  00AC 33 C0  xor ax, ax
            L00AE: dx = PopStack(player);
0303  00AF 0B D0  or dx, ax
            L00B1: PushStack(player, dx);
0306  00B2 83 FF 02  cmp di, 0x2
            L00B5: if (JumpNotEqual) goto L00BC;
030B  00B7 B8 01 00  mov ax, 0x1
            L00BA: goto L00BE;
0310  00BC 33 C0  xor ax, ax
            L00BE: dx = PopStack(player);
0313  00BF 0B D0  or dx, ax
            L00C1: if (JumpNotEqual) goto L00C6;
            L00C3: goto L0288;
            L00C6: bx = si;
            L00C8: Compare(bx, 0x04);
            L00CB: if (JumpBelowOrEqual) goto L00D0;
            L00CD: goto L0288;
            L00D0: switch (bx) {
                case 0:
                    goto L00D7;
                case 1:
                    goto L011B;
                case 2:
                    goto L0154;
                case 3:
                    goto L0180;
                case 4:
                    goto L01C9;
            }
            L00D7: ShowMessage(player, String024D); // You hear some folks walking towards you.
            L00E4: ShowPortrait(player, 0x001D);
            L00F1: ShowMessage(player, String0276); // 'Pardon us, good gentles.  We seek a multi-headed hydra we have heard tell was to be found hereabouts.  We need a a baritone and soprano for our choir, and can only afford to pay one more person.  Knowest thou where the hydra can be found?'
            L00FE: ShowMessage(player, String0367); // You tell her you cannot help her.
            L010B: ShowMessage(player, String0389); // 'Oh.'  She droops and rejoins her troop.  As they wander off, you hear one of them say, 'I still say that if the medusa's snakes could whistle in turn, then she would suffice!'  You see the others beating at the speaker with their hats as they round a corner.
            L0118: goto L0288;
            L011B: ShowMessage(player, String048D); // You hear someone running towards you.
            L0128: ShowPortrait(player, 0x002B);
            L0135: ShowMessage(player, String04B3); // An obviously perturbed human wizard runs toward you.
            L0142: ShowMessage(player, String04E8); // 'As thou values thy life!  Leave this place, lest sweet reason leave thee.  Augh!  The bagpipes echo yet in my brain!'
03A3  014F B8 5F 05  mov ax, 0x55f
            L0152: goto L010E;
            L0154: ShowPortrait(player, 0x000E);
            L0161: ShowMessage(player, String0580); // The dragon greets you heartily.
            L016E: ShowMessage(player, String05A0); // 'Ah!  Thou art one of those small two legged folks.  I heard that one of thy ilk seeks a dragon to provide wind for a pipe organ.  Art thou the one?'
03CF  017B B8 36 06  mov ax, 0x636
            L017E: goto L010E;
            L0180: Compare(GetFlag(player, 0x02, 0x47), 0x0001);
            L0194: if (JumpNotEqual) goto L019C;
03EA  0196 B8 B1 06  mov ax, 0x6b1
            L0199: goto L010E;
            L019C: ShowPortrait(player, 0x0025);
            L01A9: ShowMessage(player, String06EE); // 'Well met, gentle beings.  I have found many undead hereabouts, but as thou hast already heard, I am well equipped with items proof against the undying.
            L01B6: ShowMessage(player, String0787); // Oh, and tread softly in the auditorium, lest the organ begin its tune of death.
0417  01C3 B8 D7 07  mov ax, 0x7d7
            L01C6: goto L010E;
            L01C9: ShowPortrait(player, 0x002E);
            L01D6: ShowMessage(player, String07F9); // *
            L01E3: ShowMessage(player, String07F9); // *
            L01F0: ShowMessage(player, String07F9); // *
            L01FD: ShowMessage(player, String07FB); // A slew of short sorcerors decide that you are an easier target than the undead.
045E  020A B8 25 01  mov ax, 0x125
            L020D: PushStack(player, ax);
            L020E: PushStack(player, 0x00);
            L0211: PushStack(player, ax);
            L0212: PushStack(player, ax);
            L0213: PushStack(player, 0x5F);
            L0217: PushStack(player, 0xBE);
046F  021B C4 5E 06  les bx, [bp+0x6]
0472  021E 26 FF 9F D8 00  call far word [es:bx+0xd8]
0477  0223 83 C4 0C  add sp, 0xc
            L0226: AddEncounter(player, 0x01, 0x1C);
            L0238: Compare(PartyCount(player), 0x0001);
            L0243: if (JumpBelowOrEqual) goto L0257;
            L0245: AddEncounter(player, 0x05, 0x1C);
            L0257: Compare(PartyCount(player), 0x0002);
            L0262: if (JumpBelowOrEqual) goto L0288;
            L0264: AddEncounter(player, 0x02, 0x1C);
            L0276: AddEncounter(player, 0x06, 0x1C);
            L0288: return; // RETURN (restoring si, di);
        }

        private void Fn_06(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String084B); // This door leads to the Ballroom.
            L0010: TeleportParty(player, 0x05, 0x02, 0xB0, 0x02, isForwardMove);
            L002B: return; // RETURN;
        }

        private void Fn_07(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x04);
051E  0007 C4 5E 06  les bx, [bp+0x6]
0521  000A 26 FF 9F B0 00  call far word [es:bx+0xb0]
            L000F: cx = PopStack(player);
            L0010: RefreshCompareFlags(ax);
            L0012: if (JumpEqual) goto L0025;
            L0014: PushStack(player, 0x01);
052F  0018 C4 5E 06  les bx, [bp+0x6]
0532  001B 26 FF 9F B0 00  call far word [es:bx+0xb0]
            L0020: cx = PopStack(player);
            L0021: RefreshCompareFlags(ax);
            L0023: if (JumpNotEqual) goto L0051;
            L0025: Compare(GetFlag(player, 0x02, 0x14), 0x0001);
            L0039: if (JumpEqual) goto L0051;
            L003B: Compare(GetFlag(player, 0x02, 0x1B), 0x0001);
            L004F: if (JumpNotEqual) goto L00C4;
            L0051: ShowPortrait(player, 0x001B);
            L005E: ShowMessage(player, String086C); // 'Two trolls, a knight and a cleric by their garb, courteously hold open a secret door for you.  'Watch your back in here,' they caution you.  'There is many a dagger in amongst the cloaks.'
            L006B: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0089: SetWallObject(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L00A7: TeleportParty(player, 0x06, 0x01, 0xFC, 0x03, isForwardMove);
            L00C2: goto L00D1;
            L00C4: ShowMessage(player, String092A); // The door to the Cloak Room refuses to budge.
            L00D1: return; // RETURN;
        }

        private void Fn_08(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x02, 0x2F));
            L0016: if (JumpNotEqual) goto L0090;
            L0018: PushStack(player, 0xD9);
            L001C: PushStack(player, ax);
0607  001D C4 5E 06  les bx, [bp+0x6]
060A  0020 26 FF 5F 54  call far word [es:bx+0x54]
            L0024: cx = PopStack(player);
            L0025: cx = PopStack(player);
            L0026: RefreshCompareFlags(ax);
            L0028: if (JumpEqual) goto L0090;
            L002A: SetFlag(player, 0x02, 0x2F, 0x01);
            L003F: ShowPortrait(player, 0x0016);
            L004C: ShowMessage(player, String0957); // An enormous fur clad humanoid rises from the basin.
            L0059: ShowMessage(player, String098B); // 'I, Mannanan Mac Lir, am not so trusting as that penitent pest.  Before I will grant thee my aid, thou must prove thy worth by deciphering this puzzle:
            L0066: ShowMessage(player, String0A23); // 'The door to my watery sanctuary is South, and North, and South again, thricely done, starting from where mine own tale has been writ and stored, and then back into the widdershins corner from where thou didst arrive.
            L0073: ShowMessage(player, String0AFD); // But not always do my directions coincide with the compass; thou must know the labels to find me.  Show thy wit to be all encompassing, and my aid thou shalt have, in full measure.'
            L0080: ShowMessage(player, String0BB2); // Mannanan sinks back into the roiling waters.
            L008D: goto L0123;
            L0090: PushStack(player, 0xD9);
            L0094: PushStack(player, ax);
067F  0095 C4 5E 06  les bx, [bp+0x6]
0682  0098 26 FF 5F 54  call far word [es:bx+0x54]
            L009C: cx = PopStack(player);
            L009D: cx = PopStack(player);
            L009E: RefreshCompareFlags(ax);
            L00A0: if (JumpNotEqual) goto L00A5;
            L00A2: goto L0123;
            L00A4: // NOP
            L00A5: ShowPortrait(player, 0x0016);
            L00B2: SetFlag(player, 0x02, 0x30, 0x01);
            L00C7: ShowMessage(player, String0BDF); // Again Mannanan Mac Lir rises from the waters.
            L00D4: ShowMessage(player, String0C0D); // 'Do you think I am some cur, to come at thy beck and call!  I have told thee what thou must do: find my tome, go South, North, South, thrice, and then into the widdershins corner, to come to a place where I can deal with thee more directly.  I shall take my ring until that time, if it ever comes!'
            L00E1: RemoveItem(player, 0xD9);
            L00ED: ShowMessage(player, String0D38); // He takes his ring, roughly, and sinks back into the churning basin.
            L00FA: ax = GetCurrentHits(player);
            L0101: bx = 0x0004;
            L0104: dx = ax % bx; ax = ax / bx;
            L0107: DamagePlayer(player, ax);
            L0111: AddExperience(player, 0xFFFFD8F0);
            L0123: return; // RETURN;
        }

        private void Fn_09(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x01), 0x0001);
            L0017: if (JumpNotEqual) goto L0029;
            L0019: ShowMessage(player, String0D7C); // This was a nasty place for an ambush, wasn't it?
            L0026: goto L00D6;
            L0029: RefreshCompareFlags(GetFlag(player, 0x03, 0x12));
            L003C: if (JumpNotEqual) goto L006D;
            L003E: SetFlag(player, 0x03, 0x12, 0x01);
            L0053: ShowMessage(player, String0DAD); // This must be where they clean the instruments.  Many shelves hold rags, and in the corner is a basin full of dirty water large enough to completely immerse a tuba, assuming one had a tuba that one wanted to immerse.
            L0060: ShowMessage(player, String0E85); // The room is full of debris and has many hiding places.
            L006D: Compare(HasUsedSkill(player, 0x0B), 0x0005);
            L007C: if (JumpNotBelow) goto L00B4;
            L007E: PushStack(player, 0xA6);
            L0082: PushStack(player, ax);
0792  0083 C4 5E 06  les bx, [bp+0x6]
0795  0086 26 FF 5F 54  call far word [es:bx+0x54]
            L008A: cx = PopStack(player);
            L008B: cx = PopStack(player);
            L008C: RefreshCompareFlags(ax);
            L008E: if (JumpNotEqual) goto L00B4;
            L0090: PushStack(player, 0x62);
            L0094: PushStack(player, ax);
07A4  0095 C4 5E 06  les bx, [bp+0x6]
07A7  0098 26 FF 5F 54  call far word [es:bx+0x54]
            L009C: cx = PopStack(player);
            L009D: cx = PopStack(player);
            L009E: RefreshCompareFlags(ax);
            L00A0: if (JumpNotEqual) goto L00B4;
            L00A2: PushStack(player, 0x8F);
            L00A6: PushStack(player, ax);
07B6  00A7 C4 5E 06  les bx, [bp+0x6]
07B9  00AA 26 FF 5F 54  call far word [es:bx+0x54]
            L00AE: cx = PopStack(player);
            L00AF: cx = PopStack(player);
            L00B0: RefreshCompareFlags(ax);
            L00B2: if (JumpEqual) goto L00D6;
            L00B4: ShowMessage(player, String0EBC); // You think an ambush has been prepared to the north.
            L00C1: SetFlag(player, 0x03, 0x09, 0x01);
            L00D6: return; // RETURN;
        }

        private void Fn_0A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x01));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L010E;
            L001B: RefreshCompareFlags(GetFlag(player, 0x03, 0x09));
            L002E: if (JumpNotEqual) goto L0055;
            L0030: ShowMessage(player, String0EF0); // Sometimes it pays to be cautious and check for tracks.  This was one of those times.
            L003D: ax = GetMaxHits(player);
            L0044: bx = 0x0002;
            L0047: dx = ax % bx; ax = ax / bx;
            L004A: PushStack(player, ax);
0832  004B C4 5E 06  les bx, [bp+0x6]
0835  004E 26 FF 9F 90 00  call far word [es:bx+0x90]
            L0053: goto L0061;
            L0055: ShowMessage(player, String0F45); // From the now visible crossbows and ballistae, you are awfully glad they did not get the drop on you.
            L0062: PushStack(player, 0x01);
            L0066: PushStack(player, ax);
            L0067: PushStack(player, 0x03);
0852  006B C4 5E 06  les bx, [bp+0x6]
0855  006E 26 FF 1F  call far word [es:bx]
0858  0071 83 C4 06  add sp, 0x6
085B  0074 B8 45 01  mov ax, 0x145
            L0077: PushStack(player, ax);
            L0078: PushStack(player, 0x00);
            L007B: PushStack(player, ax);
            L007C: PushStack(player, 0xBA);
            L0080: PushStack(player, 0xF9);
            L0084: PushStack(player, 0x0B);
086F  0088 C4 5E 06  les bx, [bp+0x6]
0872  008B 26 FF 9F D8 00  call far word [es:bx+0xd8]
0877  0090 83 C4 0C  add sp, 0xc
            L0093: AddEncounter(player, 0x01, 0x1F);
            L00A5: AddEncounter(player, 0x05, 0x25);
            L00B7: AddEncounter(player, 0x02, 0x1F);
            L00C9: AddEncounter(player, 0x06, 0x25);
            L00DB: Compare(PartyCount(player), 0x0003);
            L00E6: if (JumpBelowOrEqual) goto L011B;
            L00E8: AddEncounter(player, 0x04, 0x25);
            L00FA: AddEncounter(player, 0x03, 0x1F);
            L010C: goto L011B;
            L010E: ShowMessage(player, String0FAA); // If you had bolted from this battle, you would have really gotten bolted!
            L011B: return; // RETURN;
        }

        private void Fn_0B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0FF3); // A cold breeze sends shivers down your spine.
            L0010: return; // RETURN;
        }

        private void Fn_0C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x11));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00FE;
            L001B: SetFlag(player, 0x03, 0x11, 0x01);
            L0030: ShowMessage(player, String1020); // It would be awfully convenient for those skeletons to be travelling with their own bandages, if they had any skin left to bandage!
            L003D: Compare(PartyCount(player), 0x0003);
            L0048: if (JumpBelowOrEqual) goto L0057;
            L004A: ShowMessage(player, String10A3); // And if there is any loose blood flowing, you can count on these suckers to slurp it up!
096D  0057 B8 45 01  mov ax, 0x145
            L005A: PushStack(player, ax);
            L005B: PushStack(player, 0x00);
            L005E: PushStack(player, ax);
            L005F: PushStack(player, 0xB9);
            L0063: PushStack(player, 0xC0);
            L0067: PushStack(player, 0x06);
0981  006B C4 5E 06  les bx, [bp+0x6]
0984  006E 26 FF 9F D8 00  call far word [es:bx+0xd8]
0989  0073 83 C4 0C  add sp, 0xc
            L0076: AddEncounter(player, 0x01, 0x20);
            L0088: AddEncounter(player, 0x02, 0x21);
            L009A: Compare(PartyCount(player), 0x0002);
            L00A5: if (JumpBelowOrEqual) goto L00CB;
            L00A7: AddEncounter(player, 0x05, 0x24);
            L00B9: AddEncounter(player, 0x06, 0x25);
            L00CB: Compare(PartyCount(player), 0x0003);
            L00D6: if (JumpBelowOrEqual) goto L010B;
            L00D8: AddEncounter(player, 0x04, 0x23);
            L00EA: AddEncounter(player, 0x03, 0x23);
            L00FC: goto L010B;
            L00FE: ShowMessage(player, String10FB); // All that remains from your battle here is a dirty pile of gauze.
            L010B: return; // RETURN;
        }

        private void Fn_0D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x0A), 0x0001);
            L0017: if (JumpNotEqual) goto L003A;
            L0019: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0037: goto L01F1;
            L003A: PushStack(player, 0x68);
            L003E: PushStack(player, ax);
0A62  003F C4 5E 06  les bx, [bp+0x6]
0A65  0042 26 FF 5F 54  call far word [es:bx+0x54]
            L0046: cx = PopStack(player);
            L0047: cx = PopStack(player);
            L0048: RefreshCompareFlags(ax);
            L004A: if (JumpNotEqual) goto L004F;
            L004C: goto L00CE;
            L004F: ax = HasItem(player, 0xC1);
            L005D: if (JumpEqual) goto L0062;
            L005F: goto L0133;
            L0062: ax = HasItem(player, 0xC2);
            L0070: if (JumpEqual) goto L0075;
            L0072: goto L0133;
            L0075: ax = HasItem(player, 0xC3);
            L0083: if (JumpEqual) goto L0088;
            L0085: goto L0133;
            L0088: ax = HasItem(player, 0xDA);
            L0096: if (JumpEqual) goto L009B;
            L0098: goto L0133;
            L009B: ax = HasItem(player, 0xDB);
            L00A9: if (JumpEqual) goto L00AE;
            L00AB: goto L0133;
            L00AE: ax = HasItem(player, 0xDC);
            L00BC: if (JumpNotEqual) goto L0133;
            L00BE: ax = HasItem(player, 0xDD);
            L00CC: if (JumpNotEqual) goto L0133;
            L00CE: Compare(GetSkillLevel(player, 0x0E), 0x0006);
            L00DD: if (JumpBelow) goto L0109;
            L00DF: ax = HasUsedItem(player, 0xC1, 0xC3);
            L00F2: if (JumpNotEqual) goto L0133;
            L00F4: ax = HasUsedItem(player, 0xDA, 0xDD);
            L0107: if (JumpNotEqual) goto L0133;
            L0109: PushStack(player, 0xC0);
            L010D: PushStack(player, ax);
0B31  010E C4 5E 06  les bx, [bp+0x6]
0B34  0111 26 FF 5F 54  call far word [es:bx+0x54]
            L0115: cx = PopStack(player);
            L0116: cx = PopStack(player);
            L0117: RefreshCompareFlags(ax);
            L0119: if (JumpNotEqual) goto L0133;
            L011B: PushStack(player, 0x01);
            L011F: PushStack(player, 0x00);
0B45  0122 C4 5E 06  les bx, [bp+0x6]
0B48  0125 26 FF 5F 04  call far word [es:bx+0x4]
            L0129: cx = PopStack(player);
            L012A: cx = PopStack(player);
            L012B: Compare(ax, 0x0001);
            L012E: if (JumpEqual) goto L0133;
            L0130: goto L01C7;
            L0133: PushStack(player, 0x01);
            L0137: PushStack(player, ax);
            L0138: PushStack(player, 0x00);
0B5E  013B C4 5E 06  les bx, [bp+0x6]
0B61  013E 26 FF 1F  call far word [es:bx]
0B64  0141 83 C4 06  add sp, 0x6
            L0144: RefreshCompareFlags(GetFlag(player, 0x03, 0x13));
            L0157: if (JumpNotEqual) goto L017B;
            L0159: SetFlag(player, 0x03, 0x13, 0x01);
            L016E: ShowMessage(player, String113C); // Hooves and horns!  'Tis Malcolm's ghost!  Have at!
            L017B: ax = HasItem(player, 0xEB);
            L0189: if (JumpEqual) goto L0193;
            L018B: PushStack(player, 0x00);
0BB1  018E B8 09 00  mov ax, 0x9
            L0191: goto L01B1;
            L0193: ax = CheckLevel(player, 0x0019);
            L01A1: if (JumpEqual) goto L01AB;
            L01A3: PushStack(player, 0x00);
0BC9  01A6 B8 0A 00  mov ax, 0xa
            L01A9: goto L01B1;
            L01AB: TeleportParty(player, 0x05, 0x03, 0x1A, 0x00, isForwardMove);
            L01C5: goto L01F1;
            L01C7: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L01E4: ShowMessage(player, String116F); // Not so fast!  This door is locked, and it it's not going to unlock itself unless you say please.  Or, in your case, pretty please.
            L01F1: return; // RETURN;
        }

        private void Fn_0E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x0A));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00C2;
            L001B: SetFlag(player, 0x03, 0x0A, 0x01);
            L0030: SetFlag(player, 0x03, 0x0B, 0x01);
            L0045: ShowMessage(player, String11F2); // You rush forward to face Malcolm's shade!
0C68  0052 B8 30 75  mov ax, 0x7530
            L0055: PushStack(player, ax);
            L0056: PushStack(player, 0x00);
            L0059: PushStack(player, ax);
            L005A: PushStack(player, ax);
            L005B: PushStack(player, ax);
            L005C: PushStack(player, 0xBA);
0C76  0060 C4 5E 06  les bx, [bp+0x6]
0C79  0063 26 FF 9F D8 00  call far word [es:bx+0xd8]
0C7E  0068 83 C4 0C  add sp, 0xc
            L006B: AddEncounter(player, 0x01, 0x20);
            L007D: AddEncounter(player, 0x05, 0x26);
            L008F: Compare(PartyCount(player), 0x0002);
            L009A: if (JumpBelowOrEqual) goto L0116;
            L009C: AddEncounter(player, 0x02, 0x21);
            L00AE: AddEncounter(player, 0x06, 0x21);
            L00C0: goto L0116;
            L00C2: RefreshCompareFlags(GetFlag(player, 0x03, 0x0B));
            L00D5: if (JumpNotEqual) goto L0116;
            L00D7: SetFlag(player, 0x03, 0x0B, 0x01);
            L00EC: ShowMessage(player, String121C); // Malcolm's lair certainly was well stocked.
            L00F9: ModifyGold(player, 0x9C40);
            L010A: GiveItem(player, 0xBA);
            L0116: return; // RETURN;
        }

        private void Fn_0F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x0A));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00F3;
            L001B: SetFlag(player, 0x03, 0x0A, 0x01);
            L0030: SetFlag(player, 0x03, 0x0C, 0x01);
            L0045: ShowMessage(player, String1247); // You rush forward to meet Malcolm's shade!
0D80  0052 B8 30 75  mov ax, 0x7530
            L0055: PushStack(player, ax);
            L0056: PushStack(player, 0x00);
            L0059: PushStack(player, ax);
            L005A: PushStack(player, ax);
            L005B: PushStack(player, ax);
            L005C: PushStack(player, 0xBA);
0D8E  0060 C4 5E 06  les bx, [bp+0x6]
0D91  0063 26 FF 9F D8 00  call far word [es:bx+0xd8]
0D96  0068 83 C4 0C  add sp, 0xc
            L006B: AddEncounter(player, 0x01, 0x20);
            L007D: AddEncounter(player, 0x05, 0x27);
            L008F: Compare(PartyCount(player), 0x0001);
            L009A: if (JumpBelowOrEqual) goto L00C0;
            L009C: AddEncounter(player, 0x02, 0x23);
            L00AE: AddEncounter(player, 0x06, 0x23);
            L00C0: Compare(PartyCount(player), 0x0003);
            L00CB: if (JumpBelowOrEqual) goto L0147;
            L00CD: AddEncounter(player, 0x03, 0x23);
            L00DF: AddEncounter(player, 0x04, 0x23);
            L00F1: goto L0147;
            L00F3: RefreshCompareFlags(GetFlag(player, 0x03, 0x0C));
            L0106: if (JumpNotEqual) goto L0147;
            L0108: SetFlag(player, 0x03, 0x0C, 0x01);
            L011D: ShowMessage(player, String1271); // 'If you are going to fight undead, it is a lot more profitable to fight undead kings,' you think to yourself.
            L012A: ModifyGold(player, 0xB798);
            L013B: GiveItem(player, 0xCC);
            L0147: return; // RETURN;
        }

        private void Fn_10(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x0A));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00F3;
            L001B: SetFlag(player, 0x03, 0x0A, 0x01);
            L0030: SetFlag(player, 0x03, 0x0D, 0x01);
            L0045: ShowMessage(player, String1247); // You rush forward to meet Malcolm's shade!
0EC9  0052 B8 30 75  mov ax, 0x7530
            L0055: PushStack(player, ax);
            L0056: PushStack(player, 0x00);
            L0059: PushStack(player, ax);
            L005A: PushStack(player, ax);
            L005B: PushStack(player, ax);
            L005C: PushStack(player, 0xBA);
0ED7  0060 C4 5E 06  les bx, [bp+0x6]
0EDA  0063 26 FF 9F D8 00  call far word [es:bx+0xd8]
0EDF  0068 83 C4 0C  add sp, 0xc
            L006B: AddEncounter(player, 0x01, 0x20);
            L007D: AddEncounter(player, 0x05, 0x28);
            L008F: Compare(PartyCount(player), 0x0001);
            L009A: if (JumpBelowOrEqual) goto L00C0;
            L009C: AddEncounter(player, 0x02, 0x24);
            L00AE: AddEncounter(player, 0x06, 0x24);
            L00C0: Compare(PartyCount(player), 0x0003);
            L00CB: if (JumpBelowOrEqual) goto L0147;
            L00CD: AddEncounter(player, 0x03, 0x24);
            L00DF: AddEncounter(player, 0x04, 0x24);
            L00F1: goto L0147;
            L00F3: RefreshCompareFlags(GetFlag(player, 0x03, 0x0D));
            L0106: if (JumpNotEqual) goto L0147;
            L0108: SetFlag(player, 0x03, 0x0D, 0x01);
            L011D: ShowMessage(player, String12DF); // You find a veritable king's ransom.  Of course, back before he died, Malcolm was a veritable king.
            L012A: ModifyGold(player, 0xC350);
            L013B: GiveItem(player, 0xAD);
            L0147: return; // RETURN;
        }

        private void Fn_11(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x02), 0x0001);
            L0017: if (JumpNotEqual) goto L0029;
            L0019: ShowMessage(player, String1342); // All that remains of your battle here are some bones, and occasional pieces of skin.
            L0026: goto L00F0;
            L0029: ShowMessage(player, String1396); // A large group of spell casters decides to start waving their wands in your direction.
            L0036: ShowMessage(player, String13EC); // No, not that kind of wand!  Does this look like CasinoLand?
            L0043: SetFlag(player, 0x03, 0x02, 0x01);
1018  0058 B8 45 01  mov ax, 0x145
            L005B: PushStack(player, ax);
            L005C: PushStack(player, 0x00);
            L005F: PushStack(player, ax);
            L0060: PushStack(player, 0xCC);
            L0064: PushStack(player, 0x3E);
            L0068: PushStack(player, 0x1E);
102C  006C C4 5E 06  les bx, [bp+0x6]
102F  006F 26 FF 9F D8 00  call far word [es:bx+0xd8]
1034  0074 83 C4 0C  add sp, 0xc
            L0077: AddEncounter(player, 0x01, 0x22);
            L0089: AddEncounter(player, 0x05, 0x1B);
            L009B: AddEncounter(player, 0x02, 0x22);
            L00AD: AddEncounter(player, 0x06, 0x1C);
            L00BF: Compare(PartyCount(player), 0x0003);
            L00CA: if (JumpBelowOrEqual) goto L00F0;
            L00CC: AddEncounter(player, 0x04, 0x22);
            L00DE: AddEncounter(player, 0x03, 0x22);
            L00F0: return; // RETURN;
        }

        private void Fn_12(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x03);
            L0007: PushStack(player, ax);
10BA  0008 C4 5E 06  les bx, [bp+0x6]
10BD  000B 26 FF 5F 04  call far word [es:bx+0x4]
            L000F: cx = PopStack(player);
            L0010: cx = PopStack(player);
            L0011: Compare(ax, 0x0001);
            L0014: if (JumpNotEqual) goto L0026;
            L0016: ShowMessage(player, String1428); // Somehow, the crunch of combat is not as satisfying when you are fighting fellow adventurers.
            L0023: goto L00DD;
            L0026: ShowMessage(player, String1485); // Why is it that so many adventurers are attacking you on sight?  Could it be a personal hygiene problem?
            L0033: PushStack(player, 0x01);
            L0037: PushStack(player, 0x03);
            L003B: PushStack(player, ax);
10EE  003C C4 5E 06  les bx, [bp+0x6]
10F1  003F 26 FF 1F  call far word [es:bx]
10F4  0042 83 C4 06  add sp, 0x6
10F7  0045 B8 45 01  mov ax, 0x145
            L0048: PushStack(player, ax);
            L0049: PushStack(player, 0x00);
            L004C: PushStack(player, ax);
            L004D: PushStack(player, 0xCC);
            L0051: PushStack(player, 0x78);
            L0055: PushStack(player, 0x85);
110B  0059 C4 5E 06  les bx, [bp+0x6]
110E  005C 26 FF 9F D8 00  call far word [es:bx+0xd8]
1113  0061 83 C4 0C  add sp, 0xc
            L0064: AddEncounter(player, 0x01, 0x19);
            L0076: AddEncounter(player, 0x05, 0x1D);
            L0088: AddEncounter(player, 0x02, 0x19);
            L009A: AddEncounter(player, 0x06, 0x1E);
            L00AC: Compare(PartyCount(player), 0x0003);
            L00B7: if (JumpBelowOrEqual) goto L00DD;
            L00B9: AddEncounter(player, 0x04, 0x19);
            L00CB: AddEncounter(player, 0x03, 0x19);
            L00DD: return; // RETURN;
        }

        private void Fn_13(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x04), 0x0001);
            L0017: if (JumpNotEqual) goto L0029;
            L0019: ShowMessage(player, String14ED); // Magic can compensate for size in a big way.  You are just grateful that the way you fought them wasn't quite big enough.
            L0026: goto L00E3;
            L0029: ShowMessage(player, String1566); // It looks like it's about time to gremlin and bear it.
            L0036: SetFlag(player, 0x03, 0x04, 0x01);
11DC  004B B8 45 01  mov ax, 0x145
            L004E: PushStack(player, ax);
            L004F: PushStack(player, 0x00);
            L0052: PushStack(player, ax);
            L0053: PushStack(player, 0xBA);
            L0057: PushStack(player, 0x86);
            L005B: PushStack(player, 0x4D);
11F0  005F C4 5E 06  les bx, [bp+0x6]
11F3  0062 26 FF 9F D8 00  call far word [es:bx+0xd8]
11F8  0067 83 C4 0C  add sp, 0xc
            L006A: AddEncounter(player, 0x01, 0x1A);
            L007C: AddEncounter(player, 0x05, 0x1A);
            L008E: AddEncounter(player, 0x02, 0x1A);
            L00A0: AddEncounter(player, 0x06, 0x1A);
            L00B2: Compare(PartyCount(player), 0x0003);
            L00BD: if (JumpBelowOrEqual) goto L00E3;
            L00BF: AddEncounter(player, 0x04, 0x1A);
            L00D1: AddEncounter(player, 0x03, 0x1A);
            L00E3: return; // RETURN;
        }

        private void Fn_14(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x05), 0x0001);
            L0017: if (JumpNotEqual) goto L0029;
            L0019: ShowMessage(player, String159C); // All that remains of your battle here is a holey tooth.  No, I don't mean sanctified.
            L0026: goto L00E3;
            L0029: ShowMessage(player, String15F1); // You were warned this was a den of undead.  If you didn't stock up on your garlic you have nobody to blame but yourself.
            L0036: SetFlag(player, 0x03, 0x05, 0x01);
12C1  004B B8 A9 01  mov ax, 0x1a9
            L004E: PushStack(player, ax);
            L004F: PushStack(player, 0x00);
            L0052: PushStack(player, ax);
            L0053: PushStack(player, 0xC9);
            L0057: PushStack(player, 0xB5);
            L005B: PushStack(player, 0x74);
12D5  005F C4 5E 06  les bx, [bp+0x6]
12D8  0062 26 FF 9F D8 00  call far word [es:bx+0xd8]
12DD  0067 83 C4 0C  add sp, 0xc
            L006A: AddEncounter(player, 0x01, 0x23);
            L007C: AddEncounter(player, 0x05, 0x25);
            L008E: AddEncounter(player, 0x02, 0x23);
            L00A0: AddEncounter(player, 0x06, 0x25);
            L00B2: Compare(PartyCount(player), 0x0003);
            L00BD: if (JumpBelowOrEqual) goto L00E3;
            L00BF: AddEncounter(player, 0x04, 0x25);
            L00D1: AddEncounter(player, 0x03, 0x25);
            L00E3: return; // RETURN;
        }

        private void Fn_15(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x06), 0x0001);
            L0017: if (JumpNotEqual) goto L0029;
            L0019: ShowMessage(player, String1669); // You didn't mind these clerics blessing you, but when they tried to bless you upside your head, you had no choice but to show them the error of their ways, in accordance with the old adage: she whose blesses last blesses last.
            L0026: goto L00E6;
            L0029: ShowMessage(player, String174B); // You've heard of religious fervor, but these clerics seem a bit extreme!
            L0036: SetFlag(player, 0x03, 0x06, 0x01);
            L004B: AddTreasure(player, 0x0145, 0x00, 0x78, 0xCC, 0xAA, 0x62);
            L006D: AddEncounter(player, 0x01, 0x1E);
            L007F: AddEncounter(player, 0x05, 0x22);
            L0091: AddEncounter(player, 0x02, 0x1E);
            L00A3: AddEncounter(player, 0x06, 0x19);
            L00B5: Compare(PartyCount(player), 0x0003);
            L00C0: if (JumpBelowOrEqual) goto L00E6;
            L00C2: AddEncounter(player, 0x04, 0x19);
            L00D4: AddEncounter(player, 0x03, 0x1A);
            L00E6: return; // RETURN;
        }

        private void Fn_16(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x07), 0x0001);
            L0017: if (JumpNotEqual) goto L0029;
            L0019: ShowMessage(player, String1793); // 'I prefer my ribs inanimate,' you think to yourself as you recall this battleground.
            L0026: goto L00E3;
            L0029: ShowMessage(player, String17E8); // Oh the knee bone's connected to the thigh bone, and these bones are connected to the banshees.
            L0036: SetFlag(player, 0x03, 0x07, 0x01);
148E  004B B8 45 01  mov ax, 0x145
            L004E: PushStack(player, ax);
            L004F: PushStack(player, 0x00);
            L0052: PushStack(player, ax);
            L0053: PushStack(player, 0xC0);
            L0057: PushStack(player, 0x99);
            L005B: PushStack(player, 0x77);
14A2  005F C4 5E 06  les bx, [bp+0x6]
14A5  0062 26 FF 9F D8 00  call far word [es:bx+0xd8]
14AA  0067 83 C4 0C  add sp, 0xc
            L006A: AddEncounter(player, 0x01, 0x24);
            L007C: AddEncounter(player, 0x05, 0x25);
            L008E: AddEncounter(player, 0x02, 0x24);
            L00A0: AddEncounter(player, 0x06, 0x25);
            L00B2: Compare(PartyCount(player), 0x0003);
            L00BD: if (JumpBelowOrEqual) goto L00E3;
            L00BF: AddEncounter(player, 0x04, 0x25);
            L00D1: AddEncounter(player, 0x03, 0x25);
            L00E3: return; // RETURN;
        }

        private void Fn_17(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x0E));
            L0016: if (JumpNotEqual) goto L003A;
            L0018: SetFlag(player, 0x03, 0x0E, 0x01);
            L002D: ShowMessage(player, String1847); // Ah hah!  It must be the large pipe organ to the north that is attracting all these monster to this large auditorium.
            L003A: return; // RETURN;
        }

        private void Fn_18(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String18BC); // North of here are the columns of the organ.  They are dusty and covered by spider webs.  Some of the pipes look old and fragile; others look old and well-made.
            L0010: return; // RETURN;
        }

        private void Fn_19(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String195C); // It's obvious that this organ has been badly abused and will never play again.
            L0010: Compare(GetFlag(player, 0x02, 0x31), 0x0001);
            L0024: if (JumpNotEqual) goto L002C;
159C  0026 B8 AA 19  mov ax, 0x19aa
            L0029: goto L00E0;
            L002C: Compare(HasUsedSkill(player, 0x0D), 0x0006);
            L003B: if (JumpNotBelow) goto L0083;
            L003D: RefreshCompareFlags(HasUsedSpell(player, 0x17));
            L004B: if (JumpNotEqual) goto L0083;
            L004D: PushStack(player, 0xA7);
            L0051: PushStack(player, ax);
15C8  0052 C4 5E 06  les bx, [bp+0x6]
15CB  0055 26 FF 5F 54  call far word [es:bx+0x54]
            L0059: cx = PopStack(player);
            L005A: cx = PopStack(player);
            L005B: RefreshCompareFlags(ax);
            L005D: if (JumpNotEqual) goto L0083;
            L005F: PushStack(player, 0x93);
            L0063: PushStack(player, ax);
15DA  0064 C4 5E 06  les bx, [bp+0x6]
15DD  0067 26 FF 5F 54  call far word [es:bx+0x54]
            L006B: cx = PopStack(player);
            L006C: cx = PopStack(player);
            L006D: RefreshCompareFlags(ax);
            L006F: if (JumpNotEqual) goto L0083;
            L0071: PushStack(player, 0x86);
            L0075: PushStack(player, ax);
15EC  0076 C4 5E 06  les bx, [bp+0x6]
15EF  0079 26 FF 5F 54  call far word [es:bx+0x54]
            L007D: cx = PopStack(player);
            L007E: cx = PopStack(player);
            L007F: RefreshCompareFlags(ax);
            L0081: if (JumpEqual) goto L00EA;
            L0083: Compare(GetFacing(player), 0x0003);
            L008D: if (JumpNotEqual) goto L00EA;
            L008F: SetFlag(player, 0x02, 0x31, 0x01);
            L00A4: SetFlag(player, 0x03, 0x15, 0x01);
            L00B9: PushStack(player, 0xC8);
            L00BD: PushStack(player, 0x32);
            L00C1: PushStack(player, 0x01);
163B  00C5 C4 5E 06  les bx, [bp+0x6]
163E  00C8 26 FF 9F 9C 00  call far word [es:bx+0x9c]
1643  00CD 83 C4 06  add sp, 0x6
            L00D0: ShowMessage(player, String1A02); // As you fumble with the organ (can I say that on INN?) you feel something magical tingle as you grasp and attempt to retrieve it.
            L00DD: ShowMessage(player, String1A83); // But a small venomous spider shows her disapproval of your disturbing her web, and bites! Your hand jerks reflexively and the item you had grasped flies to the south.
            L00EA: return; // RETURN;
        }

        private void Fn_1A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x15), 0x0001);
            L0017: if (JumpNotEqual) goto L0048;
            L0019: ShowMessage(player, String1B29); // Congratulations!  You found a set of Succubus Pipes!
            L0026: GiveItem(player, 0x9C);
            L0032: SetFlag(player, 0x03, 0x15, 0x00);
            L0046: goto L0055;
            L0048: ShowMessage(player, String1B5E); // To the north is the organ's keyboard.  Its hard wooden bench looks dusty and uncomfortable.
            L0055: return; // RETURN;
        }

        private void Fn_1B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0003);
            L0010: ShowMessage(player, String1BBA); // A minotaur, seated at a set of drums, stops his banging long enough to point one of his sticks at you.  The stick has the word 'Alcuin' engraved on it.
            L001D: ShowMessage(player, String1C52); // 'I can detect honest folk who will not attack out of hand.  But I must learn this passage before the big concert.  Please do not let the door hit thee on the way out.'
            L002A: return; // RETURN;
        }

        private void Fn_1C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x001D);
            L0010: ShowMessage(player, String1CFA); // A rather haggard halfling waves a bandaged hand at you.
            L001D: RefreshCompareFlags(GetFlag(player, 0x03, 0x0F));
            L0030: if (JumpNotEqual) goto L004C;
            L0032: SetFlag(player, 0x03, 0x0F, 0x01);
172C  0047 B8 32 1D  mov ax, 0x1d32
            L004A: goto L004F;
            L004C: ShowMessage(player, String1DFD); // There is no need for thee to return hence.  I am too small to eat, too poor to rob, and too morose to be good company.  Prithee, depart; leave me to ponder my failures and plot my future course.
            L0059: return; // RETURN;
        }

        private void Fn_1D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x001A);
            L0010: ShowMessage(player, String1EC0); // An orc is carefully playing a bagpipe.  What other instrument would you expect an orc to be playing, if not a well-known implement of torture.
            L001D: ShowMessage(player, String1F4F); // 'Ah, some fine bonny music lovers!  I knew if I but played long enough that I would attract refined folk in search of a concert.  I have no chairs for ye, and my repertoire includes the complete works of Grashnok of the Bloody Lobes, so I know ye'll be wanting at least half a score intermissions.'
            L002A: ShowMessage(player, String207A); // You stammer your apologies and look for the exit.
            L0037: return; // RETURN;
        }

        private void Fn_1E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x001A);
            L0010: ShowMessage(player, String20AC); // An orc is carefully playing a buzzy.  Of course, except to another buzzy player it is impossible to know whether he is playing it well or poorly.  Without stopping, he passes you a note.
            L001D: ShowMessage(player, String2167); // That is, a piece of paper; you'll gladly skip the other notes he is passing you.  The note reads:
            L002A: ShowMessage(player, String21C9); // 'Lady Macbeth's Ghost is guarded by fiercesome beasts.  It is foretold that before she can be defeated you must first fight three of the clawed, four of the hooved, and finally the winged.
            L0037: ShowMessage(player, String2286); // Without stopping, the orc nods at you, and at the door.
            L0044: return; // RETURN;
        }

        private void Fn_1F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFlag(player, 0x02, 0x1A, 0x01);
            L0018: return; // RETURN;
        }

        private void Fn_20(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0027);
            L0010: RefreshCompareFlags(GetFlag(player, 0x03, 0x10));
            L0023: if (JumpNotEqual) goto L003F;
            L0025: SetFlag(player, 0x03, 0x10, 0x01);
1813  003A B8 BE 22  mov ax, 0x22be
            L003D: goto L0042;
            L003F: ShowMessage(player, String2381); // 'Many thanks for thy kind offer, but Sir Colin de Waggonnes has assured me that he will join me at this hour.  I feel honor bound to wait for him rather than accompany thee.  God'ee a good'un, cousin.
            L004C: return; // RETURN;
        }

        private void Fn_21(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String244A); // A pile of skeletons stops playing themselves like xylophones in order to start beating you like drums.  What's worse, they seem to be regenerating.
            L0010: PushStack(player, 0x05);
            L0014: PushStack(player, 0x00);
            L0017: PushStack(player, ax);
            L0018: PushStack(player, ax);
            L0019: PushStack(player, ax);
            L001A: PushStack(player, 0xC0);
1845  001E C4 5E 06  les bx, [bp+0x6]
1848  0021 26 FF 9F D8 00  call far word [es:bx+0xd8]
184D  0026 83 C4 0C  add sp, 0xc
            L0029: AddEncounter(player, 0x01, 0x21);
            L003B: AddEncounter(player, 0x05, 0x21);
            L004D: AddEncounter(player, 0x02, 0x21);
            L005F: AddEncounter(player, 0x06, 0x21);
            L0071: Compare(PartyCount(player), 0x0002);
            L007C: if (JumpBelowOrEqual) goto L00A2;
            L007E: AddEncounter(player, 0x04, 0x24);
            L0090: AddEncounter(player, 0x03, 0x24);
            L00A2: return; // RETURN;
        }

    }
}
