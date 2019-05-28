#pragma warning disable
using System.Collections.Generic;
using XPT.WorldData;
using XPT.WorldData.Yserbius;

namespace XPT.Scripts.Yserbius.Maps {
    class YserMap19 : AMapScripted {
        protected override int MapIndex => 19;
        protected override int RandomEncounterChance => 10;
        protected override int RandomEncounterExtraCount => 1;

        public YserMap19() {
            MapEvent03 = Fn_03;
            MapEvent04 = Fn_04;
            MapEvent05 = Fn_05;
            MapEvent06 = Fn_06;
            MapEvent08 = Fn_08;
            MapEvent0A = Fn_0A;
            MapEvent0B = FnINTOX_0B;
            MapEvent0C = Fn_0C;
            MapEvent0E = Fn_0E;
            MapEvent0F = Fn_0F;
            MapEvent10 = Fn_10;
            MapEvent11 = Fn_11;
            MapEvent12 = Fn_12;
            MapEvent13 = Fn_13;
            MapEvent14 = Fn_14;
            MapEvent15 = Fn_15;
            MapEvent16 = FnTOXIC_16;
            MapEvent17 = FnSOPORIFC_17;
            MapEvent18 = FnDEADLY_18;
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
            MapEvent28 = FnROSES_28;
            MapEvent29 = FnADDICTVE_29;
            MapEvent2A = Fn_2A;
            MapEvent2B = Fn_2B;
            MapEvent2C = Fn_2C;
            MapEvent2D = Fn_2D;
            MapEvent2E = Fn_2E;
            MapEvent2F = Fn_2F;
        }
        
        // === Strings ================================================
        private const string String0140 = "That was a stiff lock, but you finally got it open.";
        private const string String0174 = "Your lockpick is no more.  It has ceased to key.  It's a stick.  Bereft of heft, it rests in pieces.  This is an ex-lockpick.";
        private const string String01F2 = "Funny how an irksome little lock on a flimsy little door can keep out a big strong person like you.";
        private const string String0256 = "You find some tracks indicating that something headed off this way.";
        private const string String029A = "You hear some footsteps running away.";
        private const string String02C0 = "You hear someone walking towards you.";
        private const string String02E6 = "'Pardon us, good gentle.  We seek the legendary Gaelic Garlic.  Naturally, we assumed it to be growing here in the Conservatory, yet we have failed completely to find it.  Canst thou direct us to some?'";
        private const string String03B1 = "You advise them to look in the Sanctum Sanctorum on the second level.  She thanks you profusely and rushes off.";
        private const string String0421 = "You tell her you cannot help her.  She thanks you for your time and departs dejectedly.";
        private const string String0479 = "The dragon is laughing.  Loudly.";
        private const string String049A = "'I just glanced out a window, and saw irrefutable evidence that green dragons are the most bacon-brained beings on the planet.";
        private const string String0519 = "Knowest thou of the statue of a green dragon atop The Rampant Cat Inn?  Well, a green now sits nearby, busily flirting with yon statue!  Heaven forfend, but my sides may burst!";
        private const string String05CA = "The dragon wanders off, chortling.";
        private const string String05ED = "You would just as soon have lost the race to the wyrd sisters if Rory would thereby have survived it.";
        private const string String0653 = "Rory greets you cheerfully.";
        private const string String066F = "Good day!  I see thou art still on the quest, and I think that we might be pursuing the same grail.  Still, 'tis friendly if not chivalric to aid those in honorable pursuit of a prize.";
        private const string String0728 = "I must caution thee:  there are many giants and golems here.  Thou mayest well desire to equip thyself appropriately.";
        private const string String079E = "A bunch of barbarians decides that - no, it's impossible to know why barbarians choose to do anything.  Be that as it may, they are choosing to attack you.";
        private const string String083A = "A cold breeze sends shivers down your spine.";
        private const string String0867 = "I'd talk about your 'catlike tread' but this isn't a Gilbert and Sullivan game.  However, you do manage to avoid being ambushed.";
        private const string String08E8 = "I'd talk about your 'catlike tread' but it would be sarcastic.";
        private const string String0927 = "Thieves and murderers, every last one of them.  Well, they're ex-thieves now.";
        private const string String0975 = "The sign over the door reads:  'Danger!  Poisonous and carnivorous plants within!  Posted No Hunting!  No trespassing!  Survivors may be prosecuted!'";
        private const string String0A0B = "Yeah, sure, as if a dumb old sign is going to frighten off an experienced adventurer like you.";
        private const string String0A6A = "The sign over the door reads:  'Warning.  Highly intoxicating plants and fumes within.  Enter at your own risk.";
        private const string String0ADA = "'There is one, and only one, good thing about being here.  There was no way on earth those dragons could have set an ambush for you.  Of course, just getting here was like an ambush in and of itself.";
        private const string String0BA2 = "'Welcome back to the Conservatory.  One hopes that thy last visit here was pleasant, and that this visit will be more so.  Again, I must warn thee about the hazards of touching unfamiliar plants.";
        private const string String0C66 = "Why, just the other day poor Lefty MacGonigle - ah, but it is impolite to gossip.  Good day.'";
        private const string String0CC4 = "You know how attached plants can become to someone who feeds them.'";
        private const string String0D08 = "Why, one of my Jovian Gremlin Traps has eaten so many adventurers her arteries are clogging, poor dear.'";
        private const string String0D71 = "My black-eyed susans turned blue after eating too many elves.'";
        private const string String0DB0 = "My witch hazel has started casting spells, it has consumed so many witches.'";
        private const string String0DFD = "Not that adventurers make poor fertilizer, but there are so many with scruples about what has fed the plants they eat.'";
        private const string String0E75 = "Some of the more finicky plants have yet to find a wine that goes well with troll, poor babies.'";
        private const string String0ED6 = "The catnip has become so attuned to fresh meat that it has taken to nipping the poor little kitties.'";
        private const string String0F3C = "I'm afraid I'll have to rename my Queen Anne's Lace to Queen Anne Slays.'";
        private const string String0F86 = "The attacks on innocent passersby have become so severe that I have had to rename the African Violets as African Violence.'";
        private const string String1002 = "To all appearances this is a prim and proper gremlin lady, but judging by the outline and sway there is a large, heavy, rectangular object in her reticule.";
        private const string String109E = "'Welcome to the Conservatory.  I am Althea Cadbury, chief docent.  It is my pleasant task to inform and instruct visitors here about the manners and mores of The Conservatory.";
        private const string String114E = "One should try and maintain a polite and decorous demeanor lest one disturb the plants.  Some of the plants respond poorly when disturbed.  Just last week we failed utterly to persuade a Jovian Man-Eater to return someone who disturbed it, may he rest in peace.";
        private const string String1254 = "Keep loud noises to a minimum, and wander at thine own risk.'";
        private const string String1292 = "'One hopes thou hast found thy time here in the Conservatory to thy liking.  Good day.'";
        private const string String12EA = "'And if one chooses to engage in combat here, there will be an effort to keep the noise to a minimum, won't there?'  She hefts her reticule menacingly.  You quickly nod your agreement.";
        private const string String13A3 = "This door leads back to The Chambers.";
        private const string String13C9 = "Three halflings catch the door before it closes.";
        private const string String13FA = "'Well met!  There are enough undead in there for all of us, and some giants and dragons as well.  May providence smile upon thy works.'";
        private const string String1482 = "The door to the Cabinet refuses to budge.";
        private const string String14AC = "The good news is that they are not nearly as large as the Colossus of Rhodes.  The bad news is that they are a lot more mobile than the Colossus of Rhodes.";
        private const string String1548 = "You may only have been knee high to those giants, but they're knee high to you now.  Next time they'll need a grave deeper than six feet.";
        private const string String15D2 = "Uh oh!  You think you've found the source of the corrosion!";
        private const string String160E = "They warned you about the living plants, but you thought haggis was an animal product.  Well, at least part animal.";
        private const string String1682 = "Yikes!  These guys are prepared for you!";
        private const string String16AB = "That's fewer thieves left in the world to pick your pockets, as if anyone could pick your pockets here.";
        private const string String1713 = "Oh, dear.  It's just a little ol' lich and a great gushing ghost.  Nothing to worry about, really.";
        private const string String1776 = "Ho hum.  More dead undead.  Hardly worth the bother.";
        private const string String17AB = "Oops!  This ambush was so well set up even a high tracking skill couldn't detect it.  They must have rangers and halflings on their side.";
        private const string String1835 = "Rather nasty of them to wait for you just outside the deadly room.  Well, you showed them the true meaning of nasty, didn't you.";
        private const string String18B6 = "The sign over the door reads:  'Warning.  Highly toxic plants and fumes within.  Enter at your own risk.";
        private const string String191F = "The sign over the door reads:  'Warning.  Highly soporific plants and fumes within.  Enter at your own risk.";
        private const string String198C = "The sign over the door reads:  'Warning! As thou dost value thy life and thy sanity, thou shouldst - oh, fie upon it!  Thou didst not believe me heretofore, and thou wilt not believe me now.'";
        private const string String1A4C = "The sign over the door reads:  'Psst.  Those other times I told thee of the dangers within those rooms.  They were nothing.  Bagatelles.  The merest discomfitures.";
        private const string String1AF0 = "But this room.  Hoo boy!  Is it a doozy or what?  Thou art so young.  Why throw thy life away now?";
        private const string String1B53 = "Your hands shake noticeably.  You realize you lack the composure to use either spells or skills in here, and that the sharp acidic air is definitely doing bad things to your hair.";
        private const string String1C07 = "Yes, this is an unpleasantly murky room.  The fumes in here could disorient a dragon, and you are no dragon.";
        private const string String1C74 = "You retrieve your fallen shrubbery.";
        private const string String1C98 = "It's so thick in here that even a two bagger would only need one bag.  It's so dark that even a medusa would look good.  It's so black that you need to light a torch just to be able to recognise black.";
        private const string String1D62 = "Aside from all that, it's not such a bad place to be.";
        private const string String1D98 = "The bad news is that you've found the source of the smell: some large, bushy, thick foliage lining this wall.  It looks like hemp with an attitude.  What?  And there isn't any good news.";
        private const string String1E53 = "TIMBER!  An enormous branch of shrubbery topples slowly over your shoulder.  You adroitly manage to avoid being injured in its fall.";
        private const string String1ED8 = "The fumes here make it impossible for you to concentrate enough to cast spells.";
        private const string String1F28 = "Not only are these fumes disorienting, but they are also making your eyes water and your lungs hurt.";
        private const string String1F8D = "What the heck are these flowers anyway?  You think you can recognise two types of lotuses and three varieties of poppies, but, let's face it, you are no druid.  In any case, if you stay here too much longer you will stay here for way too much longer.";
        private const string String2088 = "There is a mildly corrosive stench in the air, but it's nothing that will kill you any time soon.  You hope!";
        private const string String20F5 = "You make a mental note to have a serious conversation with the chef.  Heartburn is one thing, but to have dinner try and eat you?  We're talking major undercooking here!";
        private const string String219F = "You think that maybe something is wrong with you, but you just can't make yourself care enough to deal with it.";
        private const string String220F = "No, really, it's just a flesh wound.  You can survive it.";
        private const string String2249 = "How odd!  Although mentally you feel fine, and you are quite certain you can cast spells if need be, your hand eye coordination has quite disappeared and you are sure you are completely lacking your skills!";
        private const string String2318 = "If only you could bottle this, you could be a really big hit at the parties back home.";
        private const string String236F = "Yes, you have indeed lost your skills and coordination.  In fact, it might be a good idea to depart lest it be permanent.";
        private const string String23E9 = "You decide to put the toxic room high on your list of places never to come back to.";
        private const string String243D = "This room is very humid and warmer than the others.  It appears to be full of orchids of many different varieties.";
        private const string String24B0 = "This room smells sweet and looks beautiful with many different roses.  You feel better just stepping in here.";
        private const string String251E = "A sign over the door reads:  'Warning: The exotic plants within can have both therapeutic and, after longer exposure, addictive effects.  Strictly limit your time in here.'";
        private const string String25CB = "You stagger as you leave the room.  Your head throbs with pain, and your eyes water shut.  You must have stayed in the room too long.";
        private const string String2651 = "Boy, do you feel great in here!  You cannot recall ever feeling so alive, so vibrant.";
        private const string String26A7 = "Hold!  Have you suddenly caught the flux, the dropsy, the ague?  Your eyes hurt and your temples throb.  Something is wrong here.";
        private const string String2729 = "This hot dry room is filled with strange and bristly plants, cacti that, to your knowledge, Scotland has never seen before.";
        private const string String27A5 = "The hot dry air feels good, as if cleansing your system of toxins you didn't know you had in you.";
        private const string String2807 = "The hot dry air feels good, as if cleansing your system of poisins you didn't know you had in you.";
        private const string String286A = "When you're as big as these guys are, it's not that hard to sneak up on them and avoid any ambushes.";
        private const string String28CF = "Boy!  You think that it would be impossible for guys this big to avoid getting spotted and spring an ambush on you, but somehow they managed it.";
        private const string String2960 = "I'd tell you how, but you hurt enough already.";
        private const string String298F = "You shudder involuntarily as you realize that the giants used human skins as part of their clothing.  This is not your idea of a toga party.";
        private const string String2A1C = "Hey!  They must use these automatons to prune the plants in the more toxic rooms here in the Conservatory!  ";
        private const string String2A89 = "You pat yourself on the back for figuring that out, but don't pat too long; you seem to have activated them, and they seem to think you're a plant!";
        private const string String2B1D = "Unless these golems are self-repairing, a lot of plants are going to go unpruned here.";
        private const string String2B74 = "Hail!  I am Random Illyricon, Conservatory gardener.  Heed the warnings over the doors.";
        private const string String2BCC = "An thou wouldst aid me in my vengeance against that pennypinching backbeating shade of Macbeth's, find thee 'The Prunes of Cawdor' and use them belowground.  Heh!";
        
        // === Functions ================================================
        private void Fn_03(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x68);
            L0007: PushStack(player, ax);
0021  0008 C4 5E 06  les bx, [bp+0x6]
0024  000B 26 FF 5F 54  call far word [es:bx+0x54]
            L000F: cx = PopStack(player);
            L0010: cx = PopStack(player);
            L0011: RefreshCompareFlags(ax);
            L0013: if (JumpEqual) goto L007B;
            L0015: ax = HasItem(player, 0xC2);
            L0023: if (JumpEqual) goto L0028;
            L0025: goto L00C5;
            L0028: ax = HasItem(player, 0xC3);
            L0036: if (JumpEqual) goto L003B;
            L0038: goto L00C5;
            L003B: ax = HasItem(player, 0xDA);
            L0049: if (JumpNotEqual) goto L00C5;
            L004B: ax = HasItem(player, 0xDB);
            L0059: if (JumpNotEqual) goto L00C5;
            L005B: ax = HasItem(player, 0xDC);
            L0069: if (JumpNotEqual) goto L00C5;
            L006B: ax = HasItem(player, 0xDD);
            L0079: if (JumpNotEqual) goto L00C5;
            L007B: Compare(GetSkillLevel(player, 0x0E), 0x0009);
            L008A: if (JumpBelow) goto L00B3;
            L008C: PushStack(player, 0xC3);
            L0090: PushStack(player, ax);
00AA  0091 C4 5E 06  les bx, [bp+0x6]
00AD  0094 26 FF 5F 54  call far word [es:bx+0x54]
            L0098: cx = PopStack(player);
            L0099: cx = PopStack(player);
            L009A: RefreshCompareFlags(ax);
            L009C: if (JumpNotEqual) goto L00C5;
            L009E: ax = HasUsedItem(player, 0xDA, 0xDD);
            L00B1: if (JumpNotEqual) goto L00C5;
            L00B3: PushStack(player, 0xC0);
            L00B7: PushStack(player, ax);
00D1  00B8 C4 5E 06  les bx, [bp+0x6]
00D4  00BB 26 FF 5F 54  call far word [es:bx+0x54]
            L00BF: cx = PopStack(player);
            L00C0: cx = PopStack(player);
            L00C1: RefreshCompareFlags(ax);
            L00C3: if (JumpEqual) goto L00F2;
            L00C5: ShowMessage(player, String0140); // That was a stiff lock, but you finally got it open.
            L00D2: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L00F0: goto L016B;
            L00F2: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L010F: ax = HasUsedItem(player, 0xC1, 0xC2);
            L0122: if (JumpEqual) goto L0141;
            L0124: RemoveItem(player, 0xC1);
            L0130: RemoveItem(player, 0xC2);
0155  013C B8 74 01  mov ax, 0x174
            L013F: goto L0161;
            L0141: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L015E: ShowMessage(player, String01F2); // Funny how an irksome little lock on a flimsy little door can keep out a big strong person like you.
            L016B: return; // RETURN;
        }

        private void Fn_04(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, 0x0B), 0x0009);
            L0012: if (JumpNotBelow) goto L0038;
            L0014: PushStack(player, 0x62);
            L0018: PushStack(player, ax);
019F  0019 C4 5E 06  les bx, [bp+0x6]
01A2  001C 26 FF 5F 54  call far word [es:bx+0x54]
            L0020: cx = PopStack(player);
            L0021: cx = PopStack(player);
            L0022: RefreshCompareFlags(ax);
            L0024: if (JumpNotEqual) goto L0038;
            L0026: PushStack(player, 0x8F);
            L002A: PushStack(player, ax);
01B1  002B C4 5E 06  les bx, [bp+0x6]
01B4  002E 26 FF 5F 54  call far word [es:bx+0x54]
            L0032: cx = PopStack(player);
            L0033: cx = PopStack(player);
            L0034: RefreshCompareFlags(ax);
            L0036: if (JumpEqual) goto L005A;
            L0038: ShowMessage(player, String0256); // You find some tracks indicating that something headed off this way.
            L0045: SetFlag(player, 0x03, 0x09, 0x01);
            L005A: return; // RETURN;
        }

        private void Fn_05(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si, di);
            L0005: di = 0;
            L0007: si = 0;
            L0009: ax = GetFlag(player, 0x03, 0x08);
01FC  001A 8B F8  mov di, ax
01FE  001C 47     inc di
01FF  001D 8B F7  mov si, di
            L001F: Compare(si, 0x13);
            L0022: if (JumpLessOrEqual) goto L002B;
0206  0024 8B C6  mov ax, si
            L0026: si = ax + 0xFFEC;
            L002B: Compare(si, 0x0E);
            L002E: if (JumpLessOrEqual) goto L0037;
0212  0030 8B C6  mov ax, si
            L0032: si = ax + 0xFFF1;
            L0037: Compare(si, 0x09);
            L003A: if (JumpLessOrEqual) goto L0043;
021E  003C 8B C6  mov ax, si
            L003E: si = ax + 0xFFF6;
            L0043: Compare(si, 0x04);
            L0046: if (JumpLessOrEqual) goto L004F;
022A  0048 8B C6  mov ax, si
            L004A: si = ax + 0xFFFB;
0231  004F 0B F6  or si, si
0233  0051 7D 02  jge 0x55
            L0053: si = 0;
            L0055: Compare(si, 0x1D);
            L0058: if (JumpLessOrEqual) goto L005C;
            L005A: si = 0;
023E  005C 83 FF 1E  cmp di, 0x1e
            L005F: if (JumpLessOrEqual) goto L0063;
            L0061: di = 0;
0245  0063 57     push di
            L0064: PushStack(player, 0x08);
            L0068: PushStack(player, 0x03);
024E  006C C4 5E 06  les bx, [bp+0x6]
0251  006F 26 FF 1F  call far word [es:bx]
0254  0072 83 C4 06  add sp, 0x6
0257  0075 83 FF 1A  cmp di, 0x1a
            L0078: if (JumpNotEqual) goto L007F;
025C  007A B8 01 00  mov ax, 0x1
            L007D: goto L0081;
            L007F: PushStack(player, 0x00);
0264  0082 83 FF 14  cmp di, 0x14
            L0085: if (JumpNotEqual) goto L008C;
0269  0087 B8 01 00  mov ax, 0x1
            L008A: goto L008E;
026E  008C 33 C0  xor ax, ax
            L008E: dx = PopStack(player);
0271  008F 0B D0  or dx, ax
            L0091: PushStack(player, dx);
0274  0092 83 FF 0E  cmp di, 0xe
            L0095: if (JumpNotEqual) goto L009C;
0279  0097 B8 01 00  mov ax, 0x1
            L009A: goto L009E;
027E  009C 33 C0  xor ax, ax
            L009E: dx = PopStack(player);
0281  009F 0B D0  or dx, ax
            L00A1: PushStack(player, dx);
0284  00A2 83 FF 08  cmp di, 0x8
            L00A5: if (JumpNotEqual) goto L00AC;
0289  00A7 B8 01 00  mov ax, 0x1
            L00AA: goto L00AE;
028E  00AC 33 C0  xor ax, ax
            L00AE: dx = PopStack(player);
0291  00AF 0B D0  or dx, ax
            L00B1: PushStack(player, dx);
0294  00B2 83 FF 02  cmp di, 0x2
            L00B5: if (JumpNotEqual) goto L00BC;
0299  00B7 B8 01 00  mov ax, 0x1
            L00BA: goto L00BE;
029E  00BC 33 C0  xor ax, ax
            L00BE: dx = PopStack(player);
02A1  00BF 0B D0  or dx, ax
            L00C1: if (JumpNotEqual) goto L00C6;
            L00C3: goto L0249;
            L00C6: bx = si;
            L00C8: Compare(bx, 0x04);
            L00CB: if (JumpBelowOrEqual) goto L00D0;
            L00CD: goto L0249;
            L00D0: switch (bx) {
                case 0:
                    goto L00D7;
                case 1:
                    goto L00E7;
                case 2:
                    goto L012E;
                case 3:
                    goto L0168;
                case 4:
                    goto L01B1;
            }
            L00D7: ShowMessage(player, String029A); // You hear some footsteps running away.
            L00E4: goto L0249;
            L00E7: ShowMessage(player, String02C0); // You hear someone walking towards you.
            L00F4: ShowPortrait(player, 0x001D);
            L0101: ShowMessage(player, String02E6); // 'Pardon us, good gentle.  We seek the legendary Gaelic Garlic.  Naturally, we assumed it to be growing here in the Conservatory, yet we have failed completely to find it.  Canst thou direct us to some?'
            L010E: Compare(GetFlag(player, 0x02, 0x10), 0x0001);
            L0122: if (JumpNotEqual) goto L0129;
0306  0124 B8 B1 03  mov ax, 0x3b1
            L0127: goto L00DA;
030B  0129 B8 21 04  mov ax, 0x421
            L012C: goto L00DA;
            L012E: ShowPortrait(player, 0x000E);
            L013B: ShowMessage(player, String0479); // The dragon is laughing.  Loudly.
            L0148: ShowMessage(player, String049A); // 'I just glanced out a window, and saw irrefutable evidence that green dragons are the most bacon-brained beings on the planet.
            L0155: ShowMessage(player, String0519); // Knowest thou of the statue of a green dragon atop The Rampant Cat Inn?  Well, a green now sits nearby, busily flirting with yon statue!  Heaven forfend, but my sides may burst!
0344  0162 B8 CA 05  mov ax, 0x5ca
            L0165: goto L00DA;
            L0168: Compare(GetFlag(player, 0x02, 0x47), 0x0001);
            L017C: if (JumpNotEqual) goto L0184;
0360  017E B8 ED 05  mov ax, 0x5ed
            L0181: goto L00DA;
            L0184: ShowPortrait(player, 0x0025);
            L0191: ShowMessage(player, String0653); // Rory greets you cheerfully.
            L019E: ShowMessage(player, String066F); // Good day!  I see thou art still on the quest, and I think that we might be pursuing the same grail.  Still, 'tis friendly if not chivalric to aid those in honorable pursuit of a prize.
038D  01AB B8 28 07  mov ax, 0x728
            L01AE: goto L00DA;
            L01B1: ShowPortrait(player, 0x0017);
            L01BE: ShowMessage(player, String079E); // A bunch of barbarians decides that - no, it's impossible to know why barbarians choose to do anything.  Be that as it may, they are choosing to attack you.
03AD  01CB B8 89 01  mov ax, 0x189
            L01CE: PushStack(player, ax);
            L01CF: PushStack(player, 0x00);
            L01D2: PushStack(player, ax);
            L01D3: PushStack(player, ax);
            L01D4: PushStack(player, 0xB0);
            L01D8: PushStack(player, 0xBE);
03BE  01DC C4 5E 06  les bx, [bp+0x6]
03C1  01DF 26 FF 9F D8 00  call far word [es:bx+0xd8]
03C6  01E4 83 C4 0C  add sp, 0xc
            L01E7: AddEncounter(player, 0x01, 0x19);
            L01F9: Compare(PartyCount(player), 0x0001);
            L0204: if (JumpBelowOrEqual) goto L0218;
            L0206: AddEncounter(player, 0x05, 0x1A);
            L0218: Compare(PartyCount(player), 0x0002);
            L0223: if (JumpBelowOrEqual) goto L0249;
            L0225: AddEncounter(player, 0x02, 0x1B);
            L0237: AddEncounter(player, 0x06, 0x1B);
            L0249: return; // RETURN (restoring si, di);
        }

        private void Fn_06(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String083A); // A cold breeze sends shivers down your spine.
            L0010: return; // RETURN;
        }

        private void Fn_08(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x0C));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L011C;
            L001B: SetFlag(player, 0x03, 0x0C, 0x01);
            L0030: Compare(GetFlag(player, 0x03, 0x09), 0x0001);
            L0044: if (JumpNotEqual) goto L0054;
0496  0046 B8 67 08  mov ax, 0x867
            L0049: PushStack(player, ax);
049A  004A C4 5E 06  les bx, [bp+0x6]
049D  004D 26 FF 9F F8 00  call far word [es:bx+0xf8]
            L0052: goto L006D;
            L0054: ShowMessage(player, String08E8); // I'd talk about your 'catlike tread' but it would be sarcastic.
            L0061: DamagePlayer(player, 0x0258);
            L006E: SetFlag(player, 0x03, 0x09, 0x00);
04D2  0082 B8 A1 03  mov ax, 0x3a1
            L0085: PushStack(player, ax);
            L0086: PushStack(player, 0x00);
            L0089: PushStack(player, ax);
            L008A: PushStack(player, 0xBA);
            L008E: PushStack(player, 0x9C);
            L0092: PushStack(player, 0x63);
04E6  0096 C4 5E 06  les bx, [bp+0x6]
04E9  0099 26 FF 9F D8 00  call far word [es:bx+0xd8]
04EE  009E 83 C4 0C  add sp, 0xc
            L00A1: AddEncounter(player, 0x01, 0x19);
            L00B3: AddEncounter(player, 0x02, 0x1B);
            L00C5: AddEncounter(player, 0x05, 0x1A);
            L00D7: Compare(PartyCount(player), 0x0002);
            L00E2: if (JumpBelowOrEqual) goto L0129;
            L00E4: AddEncounter(player, 0x06, 0x1B);
            L00F6: AddEncounter(player, 0x04, 0x1A);
            L0108: AddEncounter(player, 0x03, 0x19);
            L011A: goto L0129;
            L011C: ShowMessage(player, String0927); // Thieves and murderers, every last one of them.  Well, they're ex-thieves now.
            L0129: return; // RETURN;
        }

        private void Fn_0A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0975); // The sign over the door reads:  'Danger!  Poisonous and carnivorous plants within!  Posted No Hunting!  No trespassing!  Survivors may be prosecuted!'
            L0010: ShowMessage(player, String0A0B); // Yeah, sure, as if a dumb old sign is going to frighten off an experienced adventurer like you.
            L001D: return; // RETURN;
        }

        private void FnINTOX_0B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0A6A); // The sign over the door reads:  'Warning.  Highly intoxicating plants and fumes within.  Enter at your own risk.
            L0010: return; // RETURN;
        }

        private void Fn_0C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x01));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00E0;
            L001B: PushStack(player, 0x01);
            L001F: PushStack(player, ax);
            L0020: PushStack(player, 0x03);
05D5  0024 C4 5E 06  les bx, [bp+0x6]
05D8  0027 26 FF 1F  call far word [es:bx]
05DB  002A 83 C4 06  add sp, 0x6
05DE  002D C4 5E 06  les bx, [bp+0x6]
05E1  0030 26 FF 5F 40  call far word [es:bx+0x40]
05E5  0034 C4 5E 06  les bx, [bp+0x6]
05E8  0037 26 FF 5F 3C  call far word [es:bx+0x3c]
            L003B: ShowMessage(player, String0ADA); // 'There is one, and only one, good thing about being here.  There was no way on earth those dragons could have set an ambush for you.  Of course, just getting here was like an ambush in and of itself.
05F9  0048 B8 90 26  mov ax, 0x2690
            L004B: PushStack(player, ax);
            L004C: PushStack(player, 0x00);
            L004F: PushStack(player, ax);
            L0050: PushStack(player, 0x96);
            L0054: PushStack(player, 0x89);
            L0058: PushStack(player, 0x0F);
060D  005C C4 5E 06  les bx, [bp+0x6]
0610  005F 26 FF 9F D8 00  call far word [es:bx+0xd8]
0615  0064 83 C4 0C  add sp, 0xc
            L0067: AddEncounter(player, 0x01, 0x25);
            L0079: AddEncounter(player, 0x05, 0x26);
            L008B: AddEncounter(player, 0x02, 0x25);
            L009D: AddEncounter(player, 0x06, 0x26);
            L00AF: Compare(PartyCount(player), 0x0002);
            L00BA: if (JumpBelowOrEqual) goto L00E0;
            L00BC: AddEncounter(player, 0x03, 0x25);
            L00CE: AddEncounter(player, 0x04, 0x25);
            L00E0: return; // RETURN;
        }

        private void Fn_0E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: si = 0;
            L0006: si = GetFlag(player, 0x02, 0x32);
            L0019: si = si + 1;
            L001A: Compare(si, 0x0A);
            L001D: if (JumpLessOrEqual) goto L0022;
            L001F: si = 0x0001;
            L0022: ShowPortrait(player, 0x002E);
            L002F: RefreshCompareFlags(GetFlag(player, 0x03, 0x0A));
            L0042: if (JumpEqual) goto L0047;
            L0044: goto L0121;
            L0047: SetFlag(player, 0x03, 0x0A, 0x01);
            L005C: Compare(GetFlag(player, 0x02, 0x6F), 0x0001);
            L0070: if (JumpNotEqual) goto L00DF;
            L0072: ShowMessage(player, String0BA2); // 'Welcome back to the Conservatory.  One hopes that thy last visit here was pleasant, and that this visit will be more so.  Again, I must warn thee about the hazards of touching unfamiliar plants.
            L007F: SetFlag(player, 0xC4, 0xB8, si);
            L0091: bx = si;
            L0093: bx = bx - 1;
            L0094: Compare(bx, 0x09);
            L0097: if (JumpBelowOrEqual) goto L009C;
            L0099: goto L01BC;
            L009C: switch (bx) {
                case 0:
                    goto L00A3;
                case 1:
                    goto L00A9;
                case 2:
                    goto L00AF;
                case 3:
                    goto L00B5;
                case 4:
                    goto L00BB;
                case 5:
                    goto L00C1;
                case 6:
                    goto L00C7;
                case 7:
                    goto L00CD;
                case 8:
                    goto L00D3;
                case 9:
                    goto L00D9;
            }
073B  00A3 B8 66 0C  mov ax, 0xc66
            L00A6: goto L01B2;
0741  00A9 B8 C4 0C  mov ax, 0xcc4
            L00AC: goto L01B2;
0747  00AF B8 08 0D  mov ax, 0xd08
            L00B2: goto L01B2;
074D  00B5 B8 71 0D  mov ax, 0xd71
            L00B8: goto L01B2;
0753  00BB B8 B0 0D  mov ax, 0xdb0
            L00BE: goto L01B2;
0759  00C1 B8 FD 0D  mov ax, 0xdfd
            L00C4: goto L01B2;
075F  00C7 B8 75 0E  mov ax, 0xe75
            L00CA: goto L01B2;
0765  00CD B8 D6 0E  mov ax, 0xed6
            L00D0: goto L01B2;
076B  00D3 B8 3C 0F  mov ax, 0xf3c
            L00D6: goto L01B2;
0771  00D9 B8 86 0F  mov ax, 0xf86
            L00DC: goto L01B2;
            L00DF: SetFlag(player, 0x02, 0x6F, 0x01);
            L00F4: ShowMessage(player, String1002); // To all appearances this is a prim and proper gremlin lady, but judging by the outline and sway there is a large, heavy, rectangular object in her reticule.
            L0101: ShowMessage(player, String109E); // 'Welcome to the Conservatory.  I am Althea Cadbury, chief docent.  It is my pleasant task to inform and instruct visitors here about the manners and mores of The Conservatory.
            L010E: ShowMessage(player, String114E); // One should try and maintain a polite and decorous demeanor lest one disturb the plants.  Some of the plants respond poorly when disturbed.  Just last week we failed utterly to persuade a Jovian Man-Eater to return someone who disturbed it, may he rest in peace.
07B3  011B B8 54 12  mov ax, 0x1254
            L011E: goto L01B2;
            L0121: ShowMessage(player, String1292); // 'One hopes thou hast found thy time here in the Conservatory to thy liking.  Good day.'
            L012E: Compare(GetFlag(player, 0x03, 0x02), 0x0001);
            L0142: if (JumpEqual) goto L01AF;
            L0144: PushStack(player, 0x03);
            L0148: PushStack(player, ax);
07E1  0149 C4 5E 06  les bx, [bp+0x6]
07E4  014C 26 FF 5F 04  call far word [es:bx+0x4]
            L0150: cx = PopStack(player);
            L0151: cx = PopStack(player);
            L0152: Compare(ax, 0x0001);
            L0155: if (JumpEqual) goto L01AF;
            L0157: Compare(GetFlag(player, 0x03, 0x04), 0x0001);
            L016B: if (JumpEqual) goto L01AF;
            L016D: Compare(GetFlag(player, 0x03, 0x05), 0x0001);
            L0181: if (JumpEqual) goto L01AF;
            L0183: Compare(GetFlag(player, 0x03, 0x06), 0x0001);
            L0197: if (JumpEqual) goto L01AF;
            L0199: Compare(GetFlag(player, 0x03, 0x07), 0x0001);
            L01AD: if (JumpNotEqual) goto L01BC;
            L01AF: ShowMessage(player, String12EA); // 'And if one chooses to engage in combat here, there will be an effort to keep the noise to a minimum, won't there?'  She hefts her reticule menacingly.  You quickly nod your agreement.
            L01BC: return; // RETURN (restoring si);
        }

        private void Fn_0F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String13A3); // This door leads back to The Chambers.
            L0010: TeleportParty(player, 0x06, 0x03, 0x0D, 0x01, isForwardMove);
            L002B: return; // RETURN;
        }

        private void Fn_10(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x04);
089F  0007 C4 5E 06  les bx, [bp+0x6]
08A2  000A 26 FF 9F B0 00  call far word [es:bx+0xb0]
            L000F: cx = PopStack(player);
            L0010: RefreshCompareFlags(ax);
            L0012: if (JumpEqual) goto L0035;
            L0014: PushStack(player, 0x00);
08AF  0017 C4 5E 06  les bx, [bp+0x6]
08B2  001A 26 FF 9F B0 00  call far word [es:bx+0xb0]
            L001F: cx = PopStack(player);
            L0020: RefreshCompareFlags(ax);
            L0022: if (JumpEqual) goto L0035;
            L0024: PushStack(player, 0x03);
08C0  0028 C4 5E 06  les bx, [bp+0x6]
08C3  002B 26 FF 9F B0 00  call far word [es:bx+0xb0]
            L0030: cx = PopStack(player);
            L0031: RefreshCompareFlags(ax);
            L0033: if (JumpNotEqual) goto L0064;
            L0035: Compare(GetFlag(player, 0x02, 0x14), 0x0001);
            L0049: if (JumpEqual) goto L0064;
            L004B: Compare(GetFlag(player, 0x02, 0x1F), 0x0001);
            L005F: if (JumpEqual) goto L0064;
            L0061: goto L00E3;
            L0064: ShowPortrait(player, 0x0029);
            L0071: ShowMessage(player, String13C9); // Three halflings catch the door before it closes.
            L007E: ShowMessage(player, String13FA); // 'Well met!  There are enough undead in there for all of us, and some giants and dragons as well.  May providence smile upon thy works.'
            L008B: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L00A9: SetWallObject(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L00C7: TeleportParty(player, 0x07, 0x02, 0xAF, 0x00, isForwardMove);
            L00E1: goto L00F0;
            L00E3: ShowMessage(player, String1482); // The door to the Cabinet refuses to budge.
            L00F0: return; // RETURN;
        }

        private void Fn_11(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x03);
            L0007: PushStack(player, ax);
0992  0008 C4 5E 06  les bx, [bp+0x6]
0995  000B 26 FF 5F 04  call far word [es:bx+0x4]
            L000F: cx = PopStack(player);
            L0010: cx = PopStack(player);
            L0011: RefreshCompareFlags(ax);
            L0013: if (JumpEqual) goto L0018;
            L0015: goto L00DE;
            L0018: PushStack(player, 0x01);
            L001C: PushStack(player, 0x03);
            L0020: PushStack(player, ax);
09AB  0021 C4 5E 06  les bx, [bp+0x6]
09AE  0024 26 FF 1F  call far word [es:bx]
09B1  0027 83 C4 06  add sp, 0x6
            L002A: ShowMessage(player, String14AC); // The good news is that they are not nearly as large as the Colossus of Rhodes.  The bad news is that they are a lot more mobile than the Colossus of Rhodes.
09C1  0037 B8 4F 03  mov ax, 0x34f
            L003A: PushStack(player, ax);
            L003B: PushStack(player, 0x00);
            L003E: PushStack(player, ax);
            L003F: PushStack(player, 0xBA);
            L0043: PushStack(player, 0xCD);
            L0047: PushStack(player, 0x18);
09D5  004B C4 5E 06  les bx, [bp+0x6]
09D8  004E 26 FF 9F D8 00  call far word [es:bx+0xd8]
09DD  0053 83 C4 0C  add sp, 0xc
            L0056: AddEncounter(player, 0x01, 0x21);
            L0068: AddEncounter(player, 0x02, 0x20);
            L007A: AddEncounter(player, 0x05, 0x20);
            L008C: Compare(PartyCount(player), 0x0001);
            L0097: if (JumpBelowOrEqual) goto L00AB;
            L0099: AddEncounter(player, 0x06, 0x20);
            L00AB: Compare(PartyCount(player), 0x0002);
            L00B6: if (JumpBelowOrEqual) goto L00EB;
            L00B8: AddEncounter(player, 0x04, 0x20);
            L00CA: AddEncounter(player, 0x03, 0x21);
            L00DC: goto L00EB;
            L00DE: ShowMessage(player, String1548); // You may only have been knee high to those giants, but they're knee high to you now.  Next time they'll need a grave deeper than six feet.
            L00EB: return; // RETURN;
        }

        private void Fn_12(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x04));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00E8;
            L001B: SetFlag(player, 0x03, 0x04, 0x01);
            L0030: ShowMessage(player, String15D2); // Uh oh!  You think you've found the source of the corrosion!
            L003D: DamagePlayer(player, 0x0064);
0AC1  004A B8 4F 03  mov ax, 0x34f
            L004D: PushStack(player, ax);
            L004E: PushStack(player, 0x00);
            L0051: PushStack(player, ax);
            L0052: PushStack(player, ax);
            L0053: PushStack(player, ax);
            L0054: PushStack(player, ax);
0ACC  0055 C4 5E 06  les bx, [bp+0x6]
0ACF  0058 26 FF 9F D8 00  call far word [es:bx+0xd8]
0AD4  005D 83 C4 0C  add sp, 0xc
            L0060: AddEncounter(player, 0x01, 0x22);
            L0072: AddEncounter(player, 0x02, 0x22);
            L0084: AddEncounter(player, 0x05, 0x22);
            L0096: Compare(PartyCount(player), 0x0002);
            L00A1: if (JumpBelowOrEqual) goto L00B5;
            L00A3: AddEncounter(player, 0x06, 0x22);
            L00B5: Compare(PartyCount(player), 0x0003);
            L00C0: if (JumpBelowOrEqual) goto L00F5;
            L00C2: AddEncounter(player, 0x04, 0x22);
            L00D4: AddEncounter(player, 0x03, 0x22);
            L00E6: goto L00F5;
            L00E8: ShowMessage(player, String160E); // They warned you about the living plants, but you thought haggis was an animal product.  Well, at least part animal.
            L00F5: return; // RETURN;
        }

        private void Fn_13(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x05));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00E4;
            L001B: SetFlag(player, 0x03, 0x05, 0x01);
            L0030: ShowMessage(player, String1682); // Yikes!  These guys are prepared for you!
0BAB  003D B8 4F 03  mov ax, 0x34f
            L0040: PushStack(player, ax);
            L0041: PushStack(player, 0x00);
            L0044: PushStack(player, ax);
            L0045: PushStack(player, 0xBA);
            L0049: PushStack(player, 0xCD);
            L004D: PushStack(player, 0x32);
0BBF  0051 C4 5E 06  les bx, [bp+0x6]
0BC2  0054 26 FF 9F D8 00  call far word [es:bx+0xd8]
0BC7  0059 83 C4 0C  add sp, 0xc
            L005C: AddEncounter(player, 0x01, 0x27);
            L006E: AddEncounter(player, 0x02, 0x28);
            L0080: AddEncounter(player, 0x05, 0x27);
            L0092: Compare(PartyCount(player), 0x0001);
            L009D: if (JumpBelowOrEqual) goto L00B1;
            L009F: AddEncounter(player, 0x06, 0x27);
            L00B1: Compare(PartyCount(player), 0x0002);
            L00BC: if (JumpBelowOrEqual) goto L00F1;
            L00BE: AddEncounter(player, 0x04, 0x28);
            L00D0: AddEncounter(player, 0x03, 0x28);
            L00E2: goto L00F1;
            L00E4: ShowMessage(player, String16AB); // That's fewer thieves left in the world to pick your pockets, as if anyone could pick your pockets here.
            L00F1: return; // RETURN;
        }

        private void Fn_14(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x06));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00F4;
            L001B: SetFlag(player, 0x03, 0x06, 0x01);
            L0030: SetNoHealZone(player);
0C99  0038 C4 5E 06  les bx, [bp+0x6]
0C9C  003B 26 FF 9F C8 00  call far word [es:bx+0xc8]
            L0040: ShowMessage(player, String1713); // Oh, dear.  It's just a little ol' lich and a great gushing ghost.  Nothing to worry about, really.
0CAE  004D B8 07 06  mov ax, 0x607
            L0050: PushStack(player, ax);
            L0051: PushStack(player, 0x00);
            L0054: PushStack(player, ax);
            L0055: PushStack(player, 0x8A);
            L0059: PushStack(player, 0xCD);
            L005D: PushStack(player, 0x43);
0CC2  0061 C4 5E 06  les bx, [bp+0x6]
0CC5  0064 26 FF 9F D8 00  call far word [es:bx+0xd8]
0CCA  0069 83 C4 0C  add sp, 0xc
            L006C: AddEncounter(player, 0x01, 0x24);
            L007E: AddEncounter(player, 0x02, 0x24);
            L0090: AddEncounter(player, 0x05, 0x23);
            L00A2: Compare(PartyCount(player), 0x0001);
            L00AD: if (JumpBelowOrEqual) goto L00C1;
            L00AF: AddEncounter(player, 0x06, 0x23);
            L00C1: Compare(PartyCount(player), 0x0002);
            L00CC: if (JumpBelowOrEqual) goto L0101;
            L00CE: AddEncounter(player, 0x04, 0x23);
            L00E0: AddEncounter(player, 0x03, 0x24);
            L00F2: goto L0101;
            L00F4: ShowMessage(player, String1776); // Ho hum.  More dead undead.  Hardly worth the bother.
            L0101: return; // RETURN;
        }

        private void Fn_15(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x07));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00E4;
            L001B: SetFlag(player, 0x03, 0x07, 0x01);
            L0030: ShowMessage(player, String17AB); // Oops!  This ambush was so well set up even a high tracking skill couldn't detect it.  They must have rangers and halflings on their side.
            L003D: DamagePlayer(player, 0x07D0);
0DAE  004A B8 89 07  mov ax, 0x789
            L004D: PushStack(player, ax);
            L004E: PushStack(player, 0x00);
            L0051: PushStack(player, ax);
            L0052: PushStack(player, 0xBA);
            L0056: PushStack(player, 0xCD);
            L005A: PushStack(player, 0x4E);
0DC2  005E C4 5E 06  les bx, [bp+0x6]
0DC5  0061 26 FF 9F D8 00  call far word [es:bx+0xd8]
0DCA  0066 83 C4 0C  add sp, 0xc
            L0069: AddEncounter(player, 0x01, 0x1C);
            L007B: AddEncounter(player, 0x02, 0x1D);
            L008D: AddEncounter(player, 0x05, 0x1E);
            L009F: AddEncounter(player, 0x06, 0x1F);
            L00B1: Compare(PartyCount(player), 0x0003);
            L00BC: if (JumpBelowOrEqual) goto L00F1;
            L00BE: AddEncounter(player, 0x04, 0x1D);
            L00D0: AddEncounter(player, 0x03, 0x1D);
            L00E2: goto L00F1;
            L00E4: ShowMessage(player, String1835); // Rather nasty of them to wait for you just outside the deadly room.  Well, you showed them the true meaning of nasty, didn't you.
            L00F1: return; // RETURN;
        }

        private void FnTOXIC_16(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String18B6); // The sign over the door reads:  'Warning.  Highly toxic plants and fumes within.  Enter at your own risk.
            L0010: return; // RETURN;
        }

        private void FnSOPORIFC_17(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String191F); // The sign over the door reads:  'Warning.  Highly soporific plants and fumes within.  Enter at your own risk.
            L0010: return; // RETURN;
        }

        private void FnDEADLY_18(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0E7E  0003 C4 5E 06  les bx, [bp+0x6]
0E81  0006 26 FF 5F 3C  call far word [es:bx+0x3c]
0E85  000A C4 5E 06  les bx, [bp+0x6]
0E88  000D 26 FF 5F 40  call far word [es:bx+0x40]
            L0011: Compare(GetFlag(player, 0x03, 0x0D), 0x0001);
            L0025: if (JumpNotEqual) goto L002C;
0EA2  0027 B8 8C 19  mov ax, 0x198c
            L002A: goto L0051;
            L002C: SetFlag(player, 0x03, 0x0D, 0x01);
            L0041: ShowMessage(player, String1A4C); // The sign over the door reads:  'Psst.  Those other times I told thee of the dangers within those rooms.  They were nothing.  Bagatelles.  The merest discomfitures.
            L004E: ShowMessage(player, String1AF0); // But this room.  Hoo boy!  Is it a doozy or what?  Thou art so young.  Why throw thy life away now?
            L005B: return; // RETURN;
        }

        private void Fn_19(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0EDB  0003 C4 5E 06  les bx, [bp+0x6]
0EDE  0006 26 FF 5F 40  call far word [es:bx+0x40]
0EE2  000A C4 5E 06  les bx, [bp+0x6]
0EE5  000D 26 FF 5F 3C  call far word [es:bx+0x3c]
            L0011: DamagePlayer(player, 0x0064);
            L001E: ShowMessage(player, String1B53); // Your hands shake noticeably.  You realize you lack the composure to use either spells or skills in here, and that the sharp acidic air is definitely doing bad things to your hair.
            L002B: return; // RETURN;
        }

        private void Fn_1A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0F08  0003 C4 5E 06  les bx, [bp+0x6]
0F0B  0006 26 FF 5F 40  call far word [es:bx+0x40]
0F0F  000A C4 5E 06  les bx, [bp+0x6]
0F12  000D 26 FF 5F 3C  call far word [es:bx+0x3c]
            L0011: DamagePlayer(player, 0x012C);
            L001E: ShowMessage(player, String1C07); // Yes, this is an unpleasantly murky room.  The fumes in here could disorient a dragon, and you are no dragon.
            L002B: return; // RETURN;
        }

        private void Fn_1B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0F35  0003 C4 5E 06  les bx, [bp+0x6]
0F38  0006 26 FF 5F 40  call far word [es:bx+0x40]
0F3C  000A C4 5E 06  les bx, [bp+0x6]
0F3F  000D 26 FF 5F 3C  call far word [es:bx+0x3c]
            L0011: DamagePlayer(player, 0x01F4);
            L001E: Compare(GetFlag(player, 0x03, 0x13), 0x0001);
            L0032: if (JumpNotEqual) goto L0055;
            L0034: ShowMessage(player, String1C74); // You retrieve your fallen shrubbery.
            L0041: GiveItem(player, 0xD5);
            L004D: PushStack(player, 0x00);
0F82  0050 B8 13 00  mov ax, 0x13
            L0053: goto L008B;
            L0055: ShowMessage(player, String1C98); // It's so thick in here that even a two bagger would only need one bag.  It's so dark that even a medusa would look good.  It's so black that you need to light a torch just to be able to recognise black.
            L0062: RefreshCompareFlags(GetFlag(player, 0x03, 0x0E));
            L0075: if (JumpNotEqual) goto L0099;
            L0077: ShowMessage(player, String1D62); // Aside from all that, it's not such a bad place to be.
            L0084: SetFlag(player, 0x03, 0x0E, 0x01);
            L0099: return; // RETURN;
        }

        private void Fn_1C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0FD0  0003 C4 5E 06  les bx, [bp+0x6]
0FD3  0006 26 FF 5F 40  call far word [es:bx+0x40]
0FD7  000A C4 5E 06  les bx, [bp+0x6]
0FDA  000D 26 FF 5F 3C  call far word [es:bx+0x3c]
            L0011: DamagePlayer(player, 0x0320);
            L001E: ShowMessage(player, String1D98); // The bad news is that you've found the source of the smell: some large, bushy, thick foliage lining this wall.  It looks like hemp with an attitude.  What?  And there isn't any good news.
            L002B: PushStack(player, 0xD7);
            L002F: PushStack(player, ax);
0FFD  0030 C4 5E 06  les bx, [bp+0x6]
1000  0033 26 FF 5F 54  call far word [es:bx+0x54]
            L0037: cx = PopStack(player);
            L0038: cx = PopStack(player);
            L0039: RefreshCompareFlags(ax);
            L003B: if (JumpEqual) goto L006C;
            L003D: ShowMessage(player, String1E53); // TIMBER!  An enormous branch of shrubbery topples slowly over your shoulder.  You adroitly manage to avoid being injured in its fall.
            L004A: SetFlag(player, 0x03, 0x13, 0x01);
            L005F: DamagePlayer(player, 0x03E8);
            L006C: return; // RETURN;
        }

        private void Fn_1D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFlag(player, 0x03, 0x0D, 0x01);
1053  0018 C4 5E 06  les bx, [bp+0x6]
1056  001B 26 FF 5F 40  call far word [es:bx+0x40]
            L001F: ShowMessage(player, String1ED8); // The fumes here make it impossible for you to concentrate enough to cast spells.
            L002C: return; // RETURN;
        }

        private void Fn_1E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
106C  0003 C4 5E 06  les bx, [bp+0x6]
106F  0006 26 FF 5F 40  call far word [es:bx+0x40]
            L000A: DamagePlayer(player, 0x0032);
            L0017: ShowMessage(player, String1F28); // Not only are these fumes disorienting, but they are also making your eyes water and your lungs hurt.
            L0024: return; // RETURN;
        }

        private void Fn_1F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
1092  0003 C4 5E 06  les bx, [bp+0x6]
1095  0006 26 FF 5F 40  call far word [es:bx+0x40]
            L000A: DamagePlayer(player, 0x00C8);
            L0017: ShowMessage(player, String1F8D); // What the heck are these flowers anyway?  You think you can recognise two types of lotuses and three varieties of poppies, but, let's face it, you are no druid.  In any case, if you stay here too much longer you will stay here for way too much longer.
            L0024: return; // RETURN;
        }

        private void Fn_20(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: DamagePlayer(player, 0x0032);
            L0010: ShowMessage(player, String2088); // There is a mildly corrosive stench in the air, but it's nothing that will kill you any time soon.  You hope!
            L001D: return; // RETURN;
        }

        private void Fn_21(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x02));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00E8;
            L001B: SetFlag(player, 0x03, 0x02, 0x01);
            L0030: ShowMessage(player, String15D2); // Uh oh!  You think you've found the source of the corrosion!
            L003D: DamagePlayer(player, 0x0064);
111E  004A B8 4F 03  mov ax, 0x34f
            L004D: PushStack(player, ax);
            L004E: PushStack(player, 0x00);
            L0051: PushStack(player, ax);
            L0052: PushStack(player, ax);
            L0053: PushStack(player, ax);
            L0054: PushStack(player, ax);
1129  0055 C4 5E 06  les bx, [bp+0x6]
112C  0058 26 FF 9F D8 00  call far word [es:bx+0xd8]
1131  005D 83 C4 0C  add sp, 0xc
            L0060: AddEncounter(player, 0x01, 0x22);
            L0072: AddEncounter(player, 0x02, 0x22);
            L0084: AddEncounter(player, 0x05, 0x22);
            L0096: Compare(PartyCount(player), 0x0002);
            L00A1: if (JumpBelowOrEqual) goto L00B5;
            L00A3: AddEncounter(player, 0x06, 0x22);
            L00B5: Compare(PartyCount(player), 0x0003);
            L00C0: if (JumpBelowOrEqual) goto L00F5;
            L00C2: AddEncounter(player, 0x04, 0x22);
            L00D4: AddEncounter(player, 0x03, 0x22);
            L00E6: goto L00F5;
            L00E8: ShowMessage(player, String20F5); // You make a mental note to have a serious conversation with the chef.  Heartburn is one thing, but to have dinner try and eat you?  We're talking major undercooking here!
            L00F5: return; // RETURN;
        }

        private void Fn_22(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
11CE  0003 C4 5E 06  les bx, [bp+0x6]
11D1  0006 26 FF 9F C8 00  call far word [es:bx+0xc8]
            L000B: SetNoHealZone(player);
            L0013: DamagePlayer(player, 0x0032);
            L0020: ShowMessage(player, String219F); // You think that maybe something is wrong with you, but you just can't make yourself care enough to deal with it.
            L002D: return; // RETURN;
        }

        private void Fn_23(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
11FD  0003 C4 5E 06  les bx, [bp+0x6]
1200  0006 26 FF 9F C8 00  call far word [es:bx+0xc8]
            L000B: SetNoHealZone(player);
            L0013: DamagePlayer(player, 0x0096);
            L0020: ShowMessage(player, String220F); // No, really, it's just a flesh wound.  You can survive it.
            L002D: return; // RETURN;
        }

        private void Fn_24(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
122C  0003 C4 5E 06  les bx, [bp+0x6]
122F  0006 26 FF 5F 3C  call far word [es:bx+0x3c]
            L000A: DamagePlayer(player, 0x0032);
            L0017: ShowMessage(player, String2249); // How odd!  Although mentally you feel fine, and you are quite certain you can cast spells if need be, your hand eye coordination has quite disappeared and you are sure you are completely lacking your skills!
            L0024: ShowMessage(player, String2318); // If only you could bottle this, you could be a really big hit at the parties back home.
            L0031: return; // RETURN;
        }

        private void Fn_25(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
125F  0003 C4 5E 06  les bx, [bp+0x6]
1262  0006 26 FF 5F 3C  call far word [es:bx+0x3c]
            L000A: DamagePlayer(player, 0x0064);
            L0017: ShowMessage(player, String236F); // Yes, you have indeed lost your skills and coordination.  In fact, it might be a good idea to depart lest it be permanent.
            L0024: return; // RETURN;
        }

        private void Fn_26(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
1285  0003 C4 5E 06  les bx, [bp+0x6]
1288  0006 26 FF 5F 3C  call far word [es:bx+0x3c]
            L000A: DamagePlayer(player, 0x00C8);
            L0017: ShowMessage(player, String23E9); // You decide to put the toxic room high on your list of places never to come back to.
            L0024: return; // RETURN;
        }

        private void Fn_27(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String243D); // This room is very humid and warmer than the others.  It appears to be full of orchids of many different varieties.
            L0010: return; // RETURN;
        }

        private void FnROSES_28(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x0F), 0x0001);
            L0017: if (JumpNotEqual) goto L0055;
            L0019: SetFlag(player, 0x03, 0x0F, 0x01);
            L002E: ShowMessage(player, String24B0); // This room smells sweet and looks beautiful with many different roses.  You feel better just stepping in here.
            L003B: HealPlayer(player, 0x000A);
            L0048: AddMana(player, 0x000A);
            L0055: return; // RETURN;
        }

        private void FnADDICTVE_29(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: // make space for tmp on stack: sp -= 2
1316  0005 C7 46 FE 09 00  mov word [bp-0x2], 0x9
            L000A: ShowMessage(player, String251E); // A sign over the door reads:  'Warning: The exotic plants within can have both therapeutic and, after longer exposure, addictive effects.  Strictly limit your time in here.'
            L0017: Compare(GetFlag(player, 0x03, 0x10), 0x000A);
            L002B: if (JumpNotEqual) goto L0068;
            L002D: ShowMessage(player, String25CB); // You stagger as you leave the room.  Your head throbs with pain, and your eyes water shut.  You must have stayed in the room too long.
            L003A: DamagePlayer(player, 0x0708);
            L0047: AddMana(player, 0xFE0C);
1365  0054 FF 76 FE  push word [bp-0x2]
            L0057: PushStack(player, 0x10);
            L005B: PushStack(player, 0x03);
1370  005F C4 5E 06  les bx, [bp+0x6]
1373  0062 26 FF 1F  call far word [es:bx]
1376  0065 83 C4 06  add sp, 0x6
            L0068: // restore stack ptr: sp = bp;
            L006A: return; // RETURN;
        }

        private void Fn_2A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: si = 0;
            L0006: si = GetFlag(player, 0x03, 0x10);
            L0019: Compare(si, 0x0A);
1399  001C 7D 3C  jge 0x5a
            L001E: si = si + 1;
            L001F: ShowMessage(player, String2651); // Boy, do you feel great in here!  You cannot recall ever feeling so alive, so vibrant.
            L002C: HealPlayer(player, 0x01F4);
            L0039: AddMana(player, 0x0064);
            L0046: SetFlag(player, 0xC4, 0xB8, si);
            L0058: goto L0081;
            L005A: ShowMessage(player, String26A7); // Hold!  Have you suddenly caught the flux, the dropsy, the ague?  Your eyes hurt and your temples throb.  Something is wrong here.
            L0067: DamagePlayer(player, 0x0064);
            L0074: AddMana(player, 0xFFCE);
            L0081: return; // RETURN (restoring si);
        }

        private void Fn_2B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: si = 0;
            L0006: si = GetFlag(player, 0x03, 0x10);
            L0019: ShowMessage(player, String2729); // This hot dry room is filled with strange and bristly plants, cacti that, to your knowledge, Scotland has never seen before.
1427  0026 0B F6  or si, si
            L0028: if (JumpLessOrEqual) goto L004A;
            L002A: ShowMessage(player, String27A5); // The hot dry air feels good, as if cleansing your system of toxins you didn't know you had in you.
1438  0037 4E     dec si
            L0038: SetFlag(player, 0xC4, 0xB8, si);
            L004A: return; // RETURN (restoring si);
        }

        private void Fn_2C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: si = 0;
            L0006: si = GetFlag(player, 0x03, 0x10);
1467  0019 0B F6  or si, si
            L001B: if (JumpLessOrEqual) goto L003D;
            L001D: ShowMessage(player, String2807); // The hot dry air feels good, as if cleansing your system of poisins you didn't know you had in you.
1478  002A 4E     dec si
            L002B: SetFlag(player, 0xC4, 0xB8, si);
            L003D: return; // RETURN (restoring si);
        }

        private void Fn_2D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x11));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L012D;
            L001B: SetFlag(player, 0x03, 0x11, 0x01);
            L0030: Compare(GetFlag(player, 0x03, 0x09), 0x0001);
            L0044: if (JumpNotEqual) goto L005F;
            L0046: SetFlag(player, 0x03, 0x09, 0x00);
14E8  005A B8 6A 28  mov ax, 0x286a
            L005D: goto L007C;
            L005F: DamagePlayer(player, 0x03E8);
            L006C: ShowMessage(player, String28CF); // Boy!  You think that it would be impossible for guys this big to avoid getting spotted and spring an ambush on you, but somehow they managed it.
            L0079: ShowMessage(player, String2960); // I'd tell you how, but you hurt enough already.
1514  0086 B8 4F 03  mov ax, 0x34f
            L0089: PushStack(player, ax);
            L008A: PushStack(player, 0x00);
            L008D: PushStack(player, ax);
            L008E: PushStack(player, 0xBA);
            L0092: PushStack(player, 0xCD);
            L0096: PushStack(player, 0x95);
1528  009A C4 5E 06  les bx, [bp+0x6]
152B  009D 26 FF 9F D8 00  call far word [es:bx+0xd8]
1530  00A2 83 C4 0C  add sp, 0xc
            L00A5: AddEncounter(player, 0x01, 0x20);
            L00B7: AddEncounter(player, 0x02, 0x20);
            L00C9: AddEncounter(player, 0x05, 0x20);
            L00DB: Compare(PartyCount(player), 0x0001);
            L00E6: if (JumpBelowOrEqual) goto L00FA;
            L00E8: AddEncounter(player, 0x06, 0x20);
            L00FA: Compare(PartyCount(player), 0x0002);
            L0105: if (JumpBelowOrEqual) goto L013A;
            L0107: AddEncounter(player, 0x04, 0x20);
            L0119: AddEncounter(player, 0x03, 0x20);
            L012B: goto L013A;
            L012D: ShowMessage(player, String298F); // You shudder involuntarily as you realize that the giants used human skins as part of their clothing.  This is not your idea of a toga party.
            L013A: return; // RETURN;
        }

        private void Fn_2E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x12));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00F1;
            L001B: SetFlag(player, 0x03, 0x12, 0x01);
            L0030: ShowMessage(player, String2A1C); // Hey!  They must use these automatons to prune the plants in the more toxic rooms here in the Conservatory!  
            L003D: ShowMessage(player, String2A89); // You pat yourself on the back for figuring that out, but don't pat too long; you seem to have activated them, and they seem to think you're a plant!
1614  004A B8 4F 03  mov ax, 0x34f
            L004D: PushStack(player, ax);
            L004E: PushStack(player, 0x00);
            L0051: PushStack(player, ax);
            L0052: PushStack(player, 0xBA);
            L0056: PushStack(player, 0xCD);
            L005A: PushStack(player, 0x68);
1628  005E C4 5E 06  les bx, [bp+0x6]
162B  0061 26 FF 9F D8 00  call far word [es:bx+0xd8]
1630  0066 83 C4 0C  add sp, 0xc
            L0069: AddEncounter(player, 0x01, 0x21);
            L007B: AddEncounter(player, 0x02, 0x21);
            L008D: AddEncounter(player, 0x05, 0x21);
            L009F: Compare(PartyCount(player), 0x0001);
            L00AA: if (JumpBelowOrEqual) goto L00BE;
            L00AC: AddEncounter(player, 0x06, 0x21);
            L00BE: Compare(PartyCount(player), 0x0002);
            L00C9: if (JumpBelowOrEqual) goto L00FE;
            L00CB: AddEncounter(player, 0x04, 0x21);
            L00DD: AddEncounter(player, 0x03, 0x21);
            L00EF: goto L00FE;
            L00F1: ShowMessage(player, String2B1D); // Unless these golems are self-repairing, a lot of plants are going to go unpruned here.
            L00FE: return; // RETURN;
        }

        private void Fn_2F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x02, 0x38));
            L0016: if (JumpNotEqual) goto L003F;
            L0018: ShowPortrait(player, 0x001F);
            L0025: ShowMessage(player, String2B74); // Hail!  I am Random Illyricon, Conservatory gardener.  Heed the warnings over the doors.
            L0032: ShowMessage(player, String2BCC); // An thou wouldst aid me in my vengeance against that pennypinching backbeating shade of Macbeth's, find thee 'The Prunes of Cawdor' and use them belowground.  Heh!
            L003F: return; // RETURN;
        }

    }
}
