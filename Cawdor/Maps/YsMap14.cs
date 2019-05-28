#pragma warning disable
using System.Collections.Generic;
using XPT.WorldData;
using XPT.WorldData.Yserbius;

namespace XPT.Scripts.Yserbius.Maps {
    class YserMap14 : AMapScripted {
        protected override int MapIndex => 14;
        protected override int RandomEncounterChance => 10;
        protected override int RandomEncounterExtraCount => 1;

        public YserMap14() {
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
        }
        
        // === Strings ================================================
        private const string String0140 = "A cold breeze sends shivers down your spine.";
        private const string String016D = "You've uncovered a hidden door!";
        private const string String018D = "You have unlocked the hidden door!";
        private const string String01B0 = "Your wooden lockpick is no more.  It has ceased to key.  It's a stick.  Bereft of heft, it rests in pieces.  This is an ex-lockpick.";
        private const string String0235 = "You detect a hidden door, but it is locked.";
        private const string String0261 = "That was a stiff lock, but you finally got it open.";
        private const string String0295 = "Funny how an irksome little lock on a flimsy little door can keep out a big strong person like you.";
        private const string String02F9 = "You move warily in case there is an ambush ahead.";
        private const string String032B = "You hear some footsteps running away.";
        private const string String0351 = "You hear someone running towards you.";
        private const string String0377 = "A gremlin thief examines you carefully.";
        private const string String039F = "'Welcome, cuz.  To enter the thief's quarter you must seek out the Northbound secret door on the Western wall, or the Westbound secret door on the Northern Wall.  Au revoir....'";
        private const string String0451 = "'I know that thou art new here, so I will give you this free advise.  This room is intended for thieves.  You are no thief.  A word to the wise....'";
        private const string String04E6 = "The gremlin wanders off warily.";
        private const string String0506 = "A harpy flaps toward you.";
        private const string String0520 = "'Two-legged unwinged type, I am misplaced.  Can you give me directions to the music room?  I need to take some, ah, harp lessons.'";
        private const string String05A3 = "You point a direction other than your intended path, grateful that you will not have to fight her.  She flies off.";
        private const string String0616 = "Once upon a midnight past you were well met at midnight.  But it will never be dark enough so that Rory can brighten it again.";
        private const string String0695 = "'Well met at midnight.  I can caution thee that without a thief, or some other means of detection, thou wilt have difficulty in fully navigating this room.  May fortune favor thy footsteps....'";
        private const string String0757 = "He saunters off, smiling.";
        private const string String0771 = "A somewhat sweaty horde o'halflings decides, rather insultingly, that they are bigger than you are.";
        private const string String07D5 = "A gremlin wizard and a gremlin cleric courteously hold open a very thick door for you.  'Allow us,' they say.  'There are so many undead in here it is a pleasure to let in fresh clerics.'";
        private const string String0891 = "Struggle though you will, you are unable to open the door that leads to the Music Room.";
        private const string String08E9 = "Two elves, a barbarian and a ranger by their appearance, courteously hold open a secret door for you.  'Watch out for the boars in here,' they warn you.  'Some of the most deadly go on two legs.'";
        private const string String09AD = "The door to the Library refuses to budge.";
        private const string String09D7 = "'Now listen up, 'cause I'm only going to say this once.  This is the cloak room, known for cloak and dagger stuff, which means thieves.";
        private const string String0A5F = "If you can prove yourself by getting into the guild hall, well and good.  But if you embarass yourself in the guild hall, well, they toast tenderfeet here.";
        private const string String0AFB = "The guild master is having a big meeting right now and nothing livens a meeting like a display of precision dagger throwing.  So watch your back, leave the masters alone, and don't go triggering any traps.'";
        private const string String0BCA = "The thief departs.";
        private const string String0BDD = "'Psst!  Aye, thou art the ones I have sought.  I send thee greetings and warnings from Galatea.";
        private const string String0C3D = "The Masters of the Thieves's Guild in Cawdor (TGIC) (tm) worry that their collusions with our common foes will be exposed.  They have set mighty traps for thee, but that which they have baited the trap with, Lugh's Spear, is well worth the effort.";
        private const string String0D35 = "Beware the halflings; they are the most dangerous of the bodyguards!  The choice is thine, an thou hast any choice.  Grace go with thee!'";
        private const string String0DBF = "A sign over the door reads: 'Ye Cat Dragged Inn'";
        private const string String0DF0 = "A sign over the door reads: 'Ye Cat Dragged Out'";
        private const string String0E21 = "A sign over the door reads: 'Ye Cat's Own Chamber'";
        private const string String0E54 = "A halfling peers at you cautiously.";
        private const string String0E78 = "'That be a private meeting in there, that be.  A fellow might walk in there clad in armor, but get carried out clad in pine, an thou dost catch my drift.'";
        private const string String0F13 = "That will be the last time they underestimate you!";
        private const string String0F46 = "If you weren't too busy being damaged, you would notice that one of these guys has pulled a lever and a thick wall slid down to cover the door.";
        private const string String0FD6 = "This time you attacked before the guard could seal the door!  Good going!";
        private const string String1020 = "Not another ambush!  Yow!";
        private const string String103A = "You dive to the left and avoid the poisoned arrows.";
        private const string String106E = "Make that MOST of the poisoned arrows.";
        private const string String1095 = "You dive to the right and avoid the poisoned arrows.";
        private const string String10CA = "Now you understand!  When your mother told you that whenever you were in a strange building you should always check your tracks, she didn't mean wipe your feet; she meant watch out for ambushes.";
        private const string String118D = "Funny, but you would not expect vampires to poison the blood they would soon be drinking, but judging by those dripping quarrels, if they had surprised you, they would have poisoned you.";
        private const string String1248 = "All that remains of your battle here are some damaged dentures.  I guess they don't make vampires like they used to.";
        private const string String12BD = "All that remains of your battle here is a badly damaged kilt.";
        private const string String12FB = "That's not the Highland Fling those orcs are doing.  It looks more like the dagger fling, or perhaps the sword dance!";
        private const string String1371 = "Dare I say it?  You have found the regenerating skeletons in the closet!";
        private const string String13BA = "Who would have thought that undead could have the intelligence to set an ambush?  Obviously not you, because they caught you flatfooted.";
        private const string String1443 = "'Tis a bunch o'wraiths holding a wrap party!";
        private const string String1470 = "You want to have a little talk with whoever is making all these undead.";
        private const string String14B8 = "The friendly thief's warning about the guildmaster's intentions cause you to enter the room dodging.  This reduces the amount of damage you take.";
        private const string String154A = "As a conoisseur of combat, you can appreciate a well planned ambush.  You would appreciate it more if you weren't the target.";
        private const string String15C8 = "The guildmaster's area is quiet.  We had some really scary music composed to play now, but after six beta testers took an axe to their speakers upon hearing it, we decided to leave well enough alone.";
        private const string String1690 = "You're just grateful that the baron efforts here didn't bear fruit.";
        private const string String16D4 = "It's time to grin and baron it.";
        private const string String16F4 = "You're glad those undead didn't turn you into their deathday present.";
        private const string String173A = "It could be worse.  There could be more of them.  They could be tougher.  You could be wounded....";
        private const string String179D = "Oh, right, you're now about to be wounded.";
        private const string String17C8 = "You know, I wonder if other big groups of adventurers feel the same way you do when they see you coming.  Well, however they felt, they kept coming, until there were no more to come.";
        private const string String187F = "Funny how a great bunch of guys will send a round of drinks your way in the Rampant Cat Inn but send a round of missiles your way once they're in here.";
        private const string String1917 = "'You know, vampires are the best reason you can think of for tighter immigration laws.  Let's send those Transylvanians back where they belong!";
        private const string String19A7 = "You know, with all these vampires here, this must be your lucky day.  What?  You say you're not a coffin salesman?  Then I guess it's your unlucky day.";
        private const string String1A3F = "A group of thieves are talking amongst themselves.";
        private const string String1A72 = "You eavesdrop unobtrusively.  One of them said, 'Aye, someone used Ohthere's Dagger to walk over the Dissolving Pool upstairs.  Were it not for the guards, they would have won the Leaden - '";
        private const string String1B31 = "They notice you listening and immediately stop talking.  They stare at you until you walk away.";
        private const string String1B91 = "The thieves stop talking at your approach, and stare at you until you walk away.";
        private const string String1BE2 = "You eavesdrop unobtrusively.  One of them said, 'Things are all topsy-turvy upstairs.  In the kitchen they have sealed up the chimney, so thou mayst die without knowing thou wert being poi - '";
        private const string String1CA3 = "You eavesdrop unobtrusively.  You overhear: '... so in the Library I finally deciphered an ancient tome that told me that I could protect myself against poison by using any of the gloves or gauntlets save - ";
        private const string String1D73 = "You eavesdrop unobtrusively.  You overhear: ";
        private const string String1DA0 = "'... and by my troth, those gorgons can paralyze thee just by touch!  But I found that the pungent punch of that bud of great worth, equipped as a ring but used as a pomade, ready to hand, to wit, the - Hoi!  This is a private conversation, cousin!'";
        private const string String1E9A = "You find the shards of a broken mirror, evidently smashed by the guildmaster lest you use it to divine secrets he was willing to die to protect.";
        private const string String1F2B = "You think you have rearranged the shards into something that makes sense.  The words you read are: 'poisoned dagger Gorgon's Garlic,' but you do not know what else to make of them.";
        private const string String1FE0 = "A drunken thief wobbles towards you, singing.";
        private const string String200E = "'Oh, the master has a mirror, ";
        private const string String202D = "T'was stolen from a saint. ";
        private const string String2049 = "And though they use it now for ill,";
        private const string String206D = "It does not feel their taint.";
        private const string String208B = "It tries to help those true of heart,";
        private const string String20B1 = "And hinder those who ain't....'";
        private const string String20D1 = "The thief staggers off.";
        private const string String20E9 = "A halfling thief gasps his last breath.";
        private const string String2111 = "'The mirror!  Dost thou understand?  I delayed the one whose task was to smash it.  There may yet be a message for thee, for thee....'  You hear the death rattle in his throat.  Before you can try healing or resuscitating him, his body turns to vapor.  He is gone.";
        private const string String221A = "It sure figures that sneaky folks like these thieves would put Lugh's Spear in a secret closet, unguarded.";
        private const string String2285 = "This closet is empty.";
        private const string String229B = "A group of folks are talking amongst themselves.";
        private const string String22CC = "You eavesdrop unobtrusively.  The halfling cleric looks very familiar, for some reason, although far less clerical with collar loosened and tankard at hand.";
        private const string String2369 = "'Indeed, I have sold forty-seven lucky pig's feet so far.  Tis the perfect, scam, cuz, for by the time the buyer learns that they do not work, the dragon has eaten him!'";
        
        // === Functions ================================================
        private void Fn_01(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0140); // A cold breeze sends shivers down your spine.
            L0010: Compare(HasUsedSkill(player, 0x0D), 0x0006);
            L001F: if (JumpNotBelow) goto L009F;
            L0021: RefreshCompareFlags(HasUsedSpell(player, 0x17));
            L002F: if (JumpNotEqual) goto L009F;
            L0031: PushStack(player, 0xA7);
            L0035: PushStack(player, ax);
0039  0036 C4 5E 06  les bx, [bp+0x6]
003C  0039 26 FF 5F 54  call far word [es:bx+0x54]
            L003D: cx = PopStack(player);
            L003E: cx = PopStack(player);
            L003F: RefreshCompareFlags(ax);
            L0041: if (JumpNotEqual) goto L009F;
            L0043: PushStack(player, 0x67);
            L0047: PushStack(player, ax);
004B  0048 C4 5E 06  les bx, [bp+0x6]
004E  004B 26 FF 5F 54  call far word [es:bx+0x54]
            L004F: cx = PopStack(player);
            L0050: cx = PopStack(player);
            L0051: RefreshCompareFlags(ax);
            L0053: if (JumpNotEqual) goto L009F;
            L0055: PushStack(player, 0x61);
            L0059: PushStack(player, ax);
005D  005A C4 5E 06  les bx, [bp+0x6]
0060  005D 26 FF 5F 54  call far word [es:bx+0x54]
            L0061: cx = PopStack(player);
            L0062: cx = PopStack(player);
            L0063: RefreshCompareFlags(ax);
            L0065: if (JumpNotEqual) goto L009F;
            L0067: PushStack(player, 0x93);
            L006B: PushStack(player, ax);
006F  006C C4 5E 06  les bx, [bp+0x6]
0072  006F 26 FF 5F 54  call far word [es:bx+0x54]
            L0073: cx = PopStack(player);
            L0074: cx = PopStack(player);
            L0075: RefreshCompareFlags(ax);
            L0077: if (JumpNotEqual) goto L009F;
            L0079: PushStack(player, 0x86);
            L007D: PushStack(player, ax);
0081  007E C4 5E 06  les bx, [bp+0x6]
0084  0081 26 FF 5F 54  call far word [es:bx+0x54]
            L0085: cx = PopStack(player);
            L0086: cx = PopStack(player);
            L0087: RefreshCompareFlags(ax);
            L0089: if (JumpNotEqual) goto L009F;
            L008B: ax = IsFlagOn(player, 0x00, 0x01);
            L009D: if (JumpEqual) goto L00E7;
            L009F: SetWallObject(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L00BD: ShowMessage(player, String016D); // You've uncovered a hidden door!
            L00CA: PushStack(player, 0x01);
            L00CE: PushStack(player, GetFacing(player));
            L00D6: PushStack(player, GetCurrentTile(player));
00E1  00DE C4 5E 06  les bx, [bp+0x6]
00E4  00E1 26 FF 5F 2C  call far word [es:bx+0x2c]
            L00E5: goto L011E;
            L00E7: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0104: SetWallObject(player, 0x00, GetCurrentTile(player), GetFacing(player));
            L0121: return; // RETURN;
        }

        private void Fn_02(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, 0x0D), 0x0009);
            L0012: if (JumpBelow) goto L0017;
            L0014: goto L0098;
            L0017: RefreshCompareFlags(HasUsedSpell(player, 0x17));
            L0025: if (JumpNotEqual) goto L0098;
            L0027: PushStack(player, 0xA7);
            L002B: PushStack(player, ax);
0152  002C C4 5E 06  les bx, [bp+0x6]
0155  002F 26 FF 5F 54  call far word [es:bx+0x54]
            L0033: cx = PopStack(player);
            L0034: cx = PopStack(player);
            L0035: RefreshCompareFlags(ax);
            L0037: if (JumpNotEqual) goto L0098;
            L0039: PushStack(player, 0x67);
            L003D: PushStack(player, ax);
0164  003E C4 5E 06  les bx, [bp+0x6]
0167  0041 26 FF 5F 54  call far word [es:bx+0x54]
            L0045: cx = PopStack(player);
            L0046: cx = PopStack(player);
            L0047: RefreshCompareFlags(ax);
            L0049: if (JumpNotEqual) goto L0098;
            L004B: PushStack(player, 0x61);
            L004F: PushStack(player, ax);
0176  0050 C4 5E 06  les bx, [bp+0x6]
0179  0053 26 FF 5F 54  call far word [es:bx+0x54]
            L0057: cx = PopStack(player);
            L0058: cx = PopStack(player);
            L0059: RefreshCompareFlags(ax);
            L005B: if (JumpNotEqual) goto L0098;
            L005D: PushStack(player, 0x93);
            L0061: PushStack(player, ax);
0188  0062 C4 5E 06  les bx, [bp+0x6]
018B  0065 26 FF 5F 54  call far word [es:bx+0x54]
            L0069: cx = PopStack(player);
            L006A: cx = PopStack(player);
            L006B: RefreshCompareFlags(ax);
            L006D: if (JumpNotEqual) goto L0098;
            L006F: PushStack(player, 0x86);
            L0073: PushStack(player, ax);
019A  0074 C4 5E 06  les bx, [bp+0x6]
019D  0077 26 FF 5F 54  call far word [es:bx+0x54]
            L007B: cx = PopStack(player);
            L007C: cx = PopStack(player);
            L007D: RefreshCompareFlags(ax);
            L007F: if (JumpNotEqual) goto L0098;
            L0081: ax = IsFlagOn(player, 0x00, 0x01);
            L0093: if (JumpNotEqual) goto L0098;
            L0095: goto L0214;
            L0098: SetWallObject(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L00B6: PushStack(player, 0x01);
            L00BA: PushStack(player, ax);
            L00BB: PushStack(player, 0x00);
01E4  00BE C4 5E 06  les bx, [bp+0x6]
01E7  00C1 26 FF 1F  call far word [es:bx]
01EA  00C4 83 C4 06  add sp, 0x6
            L00C7: PushStack(player, 0x68);
            L00CB: PushStack(player, ax);
01F2  00CC C4 5E 06  les bx, [bp+0x6]
01F5  00CF 26 FF 5F 54  call far word [es:bx+0x54]
            L00D3: cx = PopStack(player);
            L00D4: cx = PopStack(player);
            L00D5: RefreshCompareFlags(ax);
            L00D7: if (JumpEqual) goto L013F;
            L00D9: ax = HasItem(player, 0xC2);
            L00E7: if (JumpEqual) goto L00EC;
            L00E9: goto L018C;
            L00EC: ax = HasItem(player, 0xC3);
            L00FA: if (JumpEqual) goto L00FF;
            L00FC: goto L018C;
            L00FF: ax = HasItem(player, 0xDA);
            L010D: if (JumpNotEqual) goto L018C;
            L010F: ax = HasItem(player, 0xDB);
            L011D: if (JumpNotEqual) goto L018C;
            L011F: ax = HasItem(player, 0xDC);
            L012D: if (JumpNotEqual) goto L018C;
            L012F: ax = HasItem(player, 0xDD);
            L013D: if (JumpNotEqual) goto L018C;
            L013F: Compare(GetSkillLevel(player, 0x0E), 0x0006);
            L014E: if (JumpBelow) goto L017A;
            L0150: ax = HasUsedItem(player, 0xC2, 0xC3);
            L0163: if (JumpNotEqual) goto L018C;
            L0165: ax = HasUsedItem(player, 0xDA, 0xDD);
            L0178: if (JumpNotEqual) goto L018C;
            L017A: PushStack(player, 0xC0);
            L017E: PushStack(player, ax);
02A5  017F C4 5E 06  les bx, [bp+0x6]
02A8  0182 26 FF 5F 54  call far word [es:bx+0x54]
            L0186: cx = PopStack(player);
            L0187: cx = PopStack(player);
            L0188: RefreshCompareFlags(ax);
            L018A: if (JumpEqual) goto L019E;
            L018C: ShowMessage(player, String018D); // You have unlocked the hidden door!
02BF  0199 B8 01 00  mov ax, 0x1
            L019C: goto L0216;
            L019E: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L01BB: PushStack(player, 0xC1);
            L01BF: PushStack(player, ax);
02E6  01C0 C4 5E 06  les bx, [bp+0x6]
02E9  01C3 26 FF 5F 54  call far word [es:bx+0x54]
            L01C7: cx = PopStack(player);
            L01C8: cx = PopStack(player);
            L01C9: RefreshCompareFlags(ax);
            L01CB: if (JumpEqual) goto L01E8;
            L01CD: RemoveItem(player, 0xC1);
            L01D9: ShowMessage(player, String01B0); // Your wooden lockpick is no more.  It has ceased to key.  It's a stick.  Bereft of heft, it rests in pieces.  This is an ex-lockpick.
            L01E6: goto L0231;
            L01E8: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0205: ShowMessage(player, String0235); // You detect a hidden door, but it is locked.
            L0212: goto L0231;
            L0214: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0231: return; // RETURN;
        }

        private void Fn_03(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x68);
            L0007: PushStack(player, ax);
0361  0008 C4 5E 06  les bx, [bp+0x6]
0364  000B 26 FF 5F 54  call far word [es:bx+0x54]
            L000F: cx = PopStack(player);
            L0010: cx = PopStack(player);
            L0011: RefreshCompareFlags(ax);
            L0013: if (JumpEqual) goto L007B;
            L0015: ax = HasItem(player, 0xC2);
            L0023: if (JumpEqual) goto L0028;
            L0025: goto L00C8;
            L0028: ax = HasItem(player, 0xC3);
            L0036: if (JumpEqual) goto L003B;
            L0038: goto L00C8;
            L003B: ax = HasItem(player, 0xDA);
            L0049: if (JumpNotEqual) goto L00C8;
            L004B: ax = HasItem(player, 0xDB);
            L0059: if (JumpNotEqual) goto L00C8;
            L005B: ax = HasItem(player, 0xDC);
            L0069: if (JumpNotEqual) goto L00C8;
            L006B: ax = HasItem(player, 0xDD);
            L0079: if (JumpNotEqual) goto L00C8;
            L007B: Compare(GetSkillLevel(player, 0x0E), 0x0006);
            L008A: if (JumpBelow) goto L00B6;
            L008C: ax = HasUsedItem(player, 0xC2, 0xC3);
            L009F: if (JumpNotEqual) goto L00C8;
            L00A1: ax = HasUsedItem(player, 0xDA, 0xDD);
            L00B4: if (JumpNotEqual) goto L00C8;
            L00B6: PushStack(player, 0xC0);
            L00BA: PushStack(player, ax);
0414  00BB C4 5E 06  les bx, [bp+0x6]
0417  00BE 26 FF 5F 54  call far word [es:bx+0x54]
            L00C2: cx = PopStack(player);
            L00C3: cx = PopStack(player);
            L00C4: RefreshCompareFlags(ax);
            L00C6: if (JumpEqual) goto L00F5;
            L00C8: ShowMessage(player, String0261); // That was a stiff lock, but you finally got it open.
            L00D5: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L00F3: goto L015F;
            L00F5: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0112: PushStack(player, 0xC1);
            L0116: PushStack(player, ax);
0470  0117 C4 5E 06  les bx, [bp+0x6]
0473  011A 26 FF 5F 54  call far word [es:bx+0x54]
            L011E: cx = PopStack(player);
            L011F: cx = PopStack(player);
            L0120: RefreshCompareFlags(ax);
            L0122: if (JumpEqual) goto L0135;
            L0124: RemoveItem(player, 0xC1);
0489  0130 B8 B0 01  mov ax, 0x1b0
            L0133: goto L0155;
            L0135: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0152: ShowMessage(player, String0295); // Funny how an irksome little lock on a flimsy little door can keep out a big strong person like you.
            L015F: return; // RETURN;
        }

        private void Fn_04(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, 0x0B), 0x0001);
            L0012: if (JumpNotBelow) goto L004A;
            L0014: PushStack(player, 0xA6);
            L0018: PushStack(player, ax);
04D3  0019 C4 5E 06  les bx, [bp+0x6]
04D6  001C 26 FF 5F 54  call far word [es:bx+0x54]
            L0020: cx = PopStack(player);
            L0021: cx = PopStack(player);
            L0022: RefreshCompareFlags(ax);
            L0024: if (JumpNotEqual) goto L004A;
            L0026: PushStack(player, 0x62);
            L002A: PushStack(player, ax);
04E5  002B C4 5E 06  les bx, [bp+0x6]
04E8  002E 26 FF 5F 54  call far word [es:bx+0x54]
            L0032: cx = PopStack(player);
            L0033: cx = PopStack(player);
            L0034: RefreshCompareFlags(ax);
            L0036: if (JumpNotEqual) goto L004A;
            L0038: PushStack(player, 0x8F);
            L003C: PushStack(player, ax);
04F7  003D C4 5E 06  les bx, [bp+0x6]
04FA  0040 26 FF 5F 54  call far word [es:bx+0x54]
            L0044: cx = PopStack(player);
            L0045: cx = PopStack(player);
            L0046: RefreshCompareFlags(ax);
            L0048: if (JumpEqual) goto L006C;
            L004A: ShowMessage(player, String02F9); // You move warily in case there is an ambush ahead.
            L0057: SetFlag(player, 0x03, 0x09, 0x01);
            L006C: return; // RETURN;
        }

        private void Fn_05(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si, di);
            L0005: di = 0;
            L0007: si = 0;
            L0009: ax = GetFlag(player, 0x03, 0x08);
0542  001A 8B F8  mov di, ax
0544  001C 47     inc di
0545  001D 8B F7  mov si, di
            L001F: Compare(si, 0x13);
            L0022: if (JumpLessOrEqual) goto L002B;
054C  0024 8B C6  mov ax, si
            L0026: si = ax + 0xFFEC;
            L002B: Compare(si, 0x0E);
            L002E: if (JumpLessOrEqual) goto L0037;
0558  0030 8B C6  mov ax, si
            L0032: si = ax + 0xFFF1;
            L0037: Compare(si, 0x09);
            L003A: if (JumpLessOrEqual) goto L0043;
0564  003C 8B C6  mov ax, si
            L003E: si = ax + 0xFFF6;
            L0043: Compare(si, 0x04);
            L0046: if (JumpLessOrEqual) goto L004F;
0570  0048 8B C6  mov ax, si
            L004A: si = ax + 0xFFFB;
0577  004F 0B F6  or si, si
0579  0051 7D 02  jge 0x55
            L0053: si = 0;
            L0055: Compare(si, 0x1D);
            L0058: if (JumpLessOrEqual) goto L005C;
            L005A: si = 0;
0584  005C 83 FF 1E  cmp di, 0x1e
            L005F: if (JumpLessOrEqual) goto L0063;
            L0061: di = 0;
058B  0063 57     push di
            L0064: PushStack(player, 0x08);
            L0068: PushStack(player, 0x03);
0594  006C C4 5E 06  les bx, [bp+0x6]
0597  006F 26 FF 1F  call far word [es:bx]
059A  0072 83 C4 06  add sp, 0x6
059D  0075 83 FF 1A  cmp di, 0x1a
            L0078: if (JumpNotEqual) goto L007F;
05A2  007A B8 01 00  mov ax, 0x1
            L007D: goto L0081;
            L007F: PushStack(player, 0x00);
05AA  0082 83 FF 14  cmp di, 0x14
            L0085: if (JumpNotEqual) goto L008C;
05AF  0087 B8 01 00  mov ax, 0x1
            L008A: goto L008E;
05B4  008C 33 C0  xor ax, ax
            L008E: dx = PopStack(player);
05B7  008F 0B D0  or dx, ax
            L0091: PushStack(player, dx);
05BA  0092 83 FF 0E  cmp di, 0xe
            L0095: if (JumpNotEqual) goto L009C;
05BF  0097 B8 01 00  mov ax, 0x1
            L009A: goto L009E;
05C4  009C 33 C0  xor ax, ax
            L009E: dx = PopStack(player);
05C7  009F 0B D0  or dx, ax
            L00A1: PushStack(player, dx);
05CA  00A2 83 FF 08  cmp di, 0x8
            L00A5: if (JumpNotEqual) goto L00AC;
05CF  00A7 B8 01 00  mov ax, 0x1
            L00AA: goto L00AE;
05D4  00AC 33 C0  xor ax, ax
            L00AE: dx = PopStack(player);
05D7  00AF 0B D0  or dx, ax
            L00B1: PushStack(player, dx);
05DA  00B2 83 FF 02  cmp di, 0x2
            L00B5: if (JumpNotEqual) goto L00BC;
05DF  00B7 B8 01 00  mov ax, 0x1
            L00BA: goto L00BE;
05E4  00BC 33 C0  xor ax, ax
            L00BE: dx = PopStack(player);
05E7  00BF 0B D0  or dx, ax
            L00C1: if (JumpNotEqual) goto L00C6;
            L00C3: goto L022A;
            L00C6: bx = si;
            L00C8: Compare(bx, 0x04);
            L00CB: if (JumpBelowOrEqual) goto L00D0;
            L00CD: goto L022A;
            L00D0: switch (bx) {
                case 0:
                    goto L00D7;
                case 1:
                    goto L00E7;
                case 2:
                    goto L0136;
                case 3:
                    goto L0163;
                case 4:
                    goto L019F;
            }
            L00D7: ShowMessage(player, String032B); // You hear some footsteps running away.
            L00E4: goto L022A;
            L00E7: ShowMessage(player, String0351); // You hear someone running towards you.
            L00F4: ShowPortrait(player, 0x0026);
            L0101: ShowMessage(player, String0377); // A gremlin thief examines you carefully.
            L010E: PushStack(player, 0x03);
063A  0112 C4 5E 06  les bx, [bp+0x6]
063D  0115 26 FF 9F B0 00  call far word [es:bx+0xb0]
            L011A: cx = PopStack(player);
            L011B: RefreshCompareFlags(ax);
            L011D: if (JumpEqual) goto L0124;
0647  011F B8 9F 03  mov ax, 0x39f
            L0122: goto L00DA;
            L0124: ShowMessage(player, String0451); // 'I know that thou art new here, so I will give you this free advise.  This room is intended for thieves.  You are no thief.  A word to the wise....'
0659  0131 B8 E6 04  mov ax, 0x4e6
            L0134: goto L00DA;
            L0136: ShowPortrait(player, 0x000F);
            L0143: ShowMessage(player, String0506); // A harpy flaps toward you.
            L0150: ShowMessage(player, String0520); // 'Two-legged unwinged type, I am misplaced.  Can you give me directions to the music room?  I need to take some, ah, harp lessons.'
0685  015D B8 A3 05  mov ax, 0x5a3
            L0160: goto L00DA;
            L0163: Compare(GetFlag(player, 0x02, 0x47), 0x0001);
            L0177: if (JumpNotEqual) goto L017F;
06A1  0179 B8 16 06  mov ax, 0x616
            L017C: goto L00DA;
            L017F: ShowPortrait(player, 0x0025);
            L018C: ShowMessage(player, String0695); // 'Well met at midnight.  I can caution thee that without a thief, or some other means of detection, thou wilt have difficulty in fully navigating this room.  May fortune favor thy footsteps....'
06C1  0199 B8 57 07  mov ax, 0x757
            L019C: goto L00DA;
            L019F: ShowMessage(player, String0771); // A somewhat sweaty horde o'halflings decides, rather insultingly, that they are bigger than you are.
06D4  01AC B8 25 01  mov ax, 0x125
            L01AF: PushStack(player, ax);
            L01B0: PushStack(player, 0x00);
            L01B3: PushStack(player, ax);
            L01B4: PushStack(player, ax);
            L01B5: PushStack(player, 0xBA);
            L01B9: PushStack(player, 0xBE);
06E5  01BD C4 5E 06  les bx, [bp+0x6]
06E8  01C0 26 FF 9F D8 00  call far word [es:bx+0xd8]
06ED  01C5 83 C4 0C  add sp, 0xc
            L01C8: AddEncounter(player, 0x01, 0x1D);
            L01DA: Compare(PartyCount(player), 0x0001);
            L01E5: if (JumpBelowOrEqual) goto L01F9;
            L01E7: AddEncounter(player, 0x05, 0x1D);
            L01F9: Compare(PartyCount(player), 0x0002);
            L0204: if (JumpBelowOrEqual) goto L022A;
            L0206: AddEncounter(player, 0x02, 0x1D);
            L0218: AddEncounter(player, 0x06, 0x1D);
            L022A: return; // RETURN (restoring si, di);
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
            L0003: PushStack(player, 0x05);
0779  0007 C4 5E 06  les bx, [bp+0x6]
077C  000A 26 FF 9F B0 00  call far word [es:bx+0xb0]
            L000F: cx = PopStack(player);
            L0010: RefreshCompareFlags(ax);
            L0012: if (JumpEqual) goto L0025;
            L0014: PushStack(player, 0x04);
078A  0018 C4 5E 06  les bx, [bp+0x6]
078D  001B 26 FF 9F B0 00  call far word [es:bx+0xb0]
            L0020: cx = PopStack(player);
            L0021: RefreshCompareFlags(ax);
            L0023: if (JumpNotEqual) goto L0051;
            L0025: Compare(GetFlag(player, 0x02, 0x14), 0x0001);
            L0039: if (JumpEqual) goto L0051;
            L003B: Compare(GetFlag(player, 0x02, 0x1A), 0x0001);
            L004F: if (JumpNotEqual) goto L0088;
            L0051: ShowPortrait(player, 0x002E);
            L005E: ShowMessage(player, String07D5); // A gremlin wizard and a gremlin cleric courteously hold open a very thick door for you.  'Allow us,' they say.  'There are so many undead in here it is a pleasure to let in fresh clerics.'
            L006B: TeleportParty(player, 0x05, 0x03, 0x0C, 0x01, isForwardMove);
            L0086: goto L0095;
            L0088: ShowMessage(player, String0891); // Struggle though you will, you are unable to open the door that leads to the Music Room.
            L0095: return; // RETURN;
        }

        private void Fn_08(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x00);
080F  0006 C4 5E 06  les bx, [bp+0x6]
0812  0009 26 FF 9F B0 00  call far word [es:bx+0xb0]
            L000E: cx = PopStack(player);
            L000F: RefreshCompareFlags(ax);
            L0011: if (JumpEqual) goto L0024;
            L0013: PushStack(player, 0x02);
0820  0017 C4 5E 06  les bx, [bp+0x6]
0823  001A 26 FF 9F B0 00  call far word [es:bx+0xb0]
            L001F: cx = PopStack(player);
            L0020: RefreshCompareFlags(ax);
            L0022: if (JumpNotEqual) goto L0050;
            L0024: Compare(GetFlag(player, 0x02, 0x14), 0x0001);
            L0038: if (JumpEqual) goto L0050;
            L003A: Compare(GetFlag(player, 0x02, 0x1C), 0x0001);
            L004E: if (JumpNotEqual) goto L0087;
            L0050: ShowPortrait(player, 0x0018);
            L005D: ShowMessage(player, String08E9); // Two elves, a barbarian and a ranger by their appearance, courteously hold open a secret door for you.  'Watch out for the boars in here,' they warn you.  'Some of the most deadly go on two legs.'
            L006A: TeleportParty(player, 0x06, 0x02, 0x90, 0x02, isForwardMove);
            L0085: goto L0094;
            L0087: ShowMessage(player, String09AD); // The door to the Library refuses to budge.
            L0094: return; // RETURN;
        }

        private void Fn_09(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x14));
            L0016: if (JumpNotEqual) goto L0083;
            L0018: ShowPortrait(player, 0x0023);
            L0025: SetFlag(player, 0x02, 0x1B, 0x01);
            L003A: SetFlag(player, 0x03, 0x14, 0x01);
            L004F: ShowMessage(player, String09D7); // 'Now listen up, 'cause I'm only going to say this once.  This is the cloak room, known for cloak and dagger stuff, which means thieves.
            L005C: ShowMessage(player, String0A5F); // If you can prove yourself by getting into the guild hall, well and good.  But if you embarass yourself in the guild hall, well, they toast tenderfeet here.
            L0069: ShowMessage(player, String0AFB); // The guild master is having a big meeting right now and nothing livens a meeting like a display of precision dagger throwing.  So watch your back, leave the masters alone, and don't go triggering any traps.'
            L0076: ShowMessage(player, String0BCA); // The thief departs.
            L0083: return; // RETURN;
        }

        private void Fn_0A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x0A));
            L0016: if (JumpNotEqual) goto L006E;
            L0018: ShowPortrait(player, 0x0025);
            L0025: SetFlag(player, 0x03, 0x0A, 0x01);
            L003A: ShowMessage(player, String0BDD); // 'Psst!  Aye, thou art the ones I have sought.  I send thee greetings and warnings from Galatea.
            L0047: ShowMessage(player, String0C3D); // The Masters of the Thieves's Guild in Cawdor (TGIC) (tm) worry that their collusions with our common foes will be exposed.  They have set mighty traps for thee, but that which they have baited the trap with, Lugh's Spear, is well worth the effort.
            L0054: ShowMessage(player, String0D35); // Beware the halflings; they are the most dangerous of the bodyguards!  The choice is thine, an thou hast any choice.  Grace go with thee!'
            L0061: ShowMessage(player, String0BCA); // The thief departs.
            L006E: return; // RETURN;
        }

        private void Fn_0B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0DBF); // A sign over the door reads: 'Ye Cat Dragged Inn'
            L0010: return; // RETURN;
        }

        private void Fn_0C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0DF0); // A sign over the door reads: 'Ye Cat Dragged Out'
            L0010: return; // RETURN;
        }

        private void Fn_0D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0E21); // A sign over the door reads: 'Ye Cat's Own Chamber'
            L0010: return; // RETURN;
        }

        private void Fn_0E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0025);
            L0010: ShowMessage(player, String0E54); // A halfling peers at you cautiously.
            L001D: ShowMessage(player, String0E78); // 'That be a private meeting in there, that be.  A fellow might walk in there clad in armor, but get carried out clad in pine, an thou dost catch my drift.'
            L002A: SetFlag(player, 0x03, 0x09, 0x00);
            L003E: return; // RETURN;
        }

        private void Fn_0F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x0B), 0x0001);
            L0017: if (JumpNotEqual) goto L0029;
            L0019: ShowMessage(player, String0F13); // That will be the last time they underestimate you!
            L0026: goto L01FA;
            L0029: SetFlag(player, 0x03, 0x0B, 0x01);
            L003E: RefreshCompareFlags(GetFlag(player, 0x03, 0x0D));
            L0051: if (JumpNotEqual) goto L0086;
            L0053: SetWallObject(player, 0x00, GetCurrentTile(player), 0x00);
            L006B: SetWallPassable(player, GetCurrentTile(player), ax, 0x00);
0A8B  0081 B8 46 0F  mov ax, 0xf46
            L0084: goto L0089;
            L0086: ShowMessage(player, String0FD6); // This time you attacked before the guard could seal the door!  Good going!
            L0093: RefreshCompareFlags(GetFlag(player, 0x03, 0x09));
            L00A6: if (JumpNotEqual) goto L00F9;
            L00A8: RefreshCompareFlags(GetFlag(player, 0x03, 0x0D));
            L00BB: if (JumpNotEqual) goto L00F9;
            L00BD: ShowMessage(player, String1020); // Not another ambush!  Yow!
0AD4  00CA B8 90 01  mov ax, 0x190
            L00CD: PushStack(player, ax);
            L00CE: PushStack(player, 0x0A);
            L00D2: PushStack(player, 0x01);
0AE0  00D6 C4 5E 06  les bx, [bp+0x6]
0AE3  00D9 26 FF 9F 9C 00  call far word [es:bx+0x9c]
0AE8  00DE 83 C4 06  add sp, 0x6
            L00E1: ax = GetMaxHits(player);
            L00E8: bx = 0x0002;
            L00EB: dx = ax % bx; ax = ax / bx;
            L00EE: PushStack(player, ax);
0AF9  00EF C4 5E 06  les bx, [bp+0x6]
0AFC  00F2 26 FF 9F 90 00  call far word [es:bx+0x90]
            L00F7: goto L0140;
            L00F9: ShowMessage(player, String103A); // You dive to the left and avoid the poisoned arrows.
            L0106: ax = GetMaxHits(player);
            L010D: bx = 0x0004;
            L0110: dx = ax % bx; ax = ax / bx;
            L0113: DamagePlayer(player, ax);
            L011D: PushStack(player, 0xC8);
            L0121: PushStack(player, 0x05);
            L0125: PushStack(player, 0x01);
0B33  0129 C4 5E 06  les bx, [bp+0x6]
0B36  012C 26 FF 9F 9C 00  call far word [es:bx+0x9c]
0B3B  0131 83 C4 06  add sp, 0x6
            L0134: ShowMessage(player, String106E); // Make that MOST of the poisoned arrows.
            L0141: SetFlag(player, 0x03, 0x09, 0x00);
0B5F  0155 B8 E8 01  mov ax, 0x1e8
            L0158: PushStack(player, ax);
            L0159: PushStack(player, 0x00);
            L015C: PushStack(player, ax);
            L015D: PushStack(player, 0xBA);
            L0161: PushStack(player, 0x61);
            L0165: PushStack(player, 0x08);
0B73  0169 C4 5E 06  les bx, [bp+0x6]
0B76  016C 26 FF 9F D8 00  call far word [es:bx+0xd8]
0B7B  0171 83 C4 0C  add sp, 0xc
            L0174: AddEncounter(player, 0x01, 0x26);
            L0186: AddEncounter(player, 0x05, 0x27);
            L0198: AddEncounter(player, 0x02, 0x28);
            L01AA: Compare(PartyCount(player), 0x0001);
            L01B5: if (JumpBelowOrEqual) goto L01DB;
            L01B7: AddEncounter(player, 0x06, 0x27);
            L01C9: AddEncounter(player, 0x04, 0x28);
            L01DB: Compare(PartyCount(player), 0x0002);
            L01E6: if (JumpBelowOrEqual) goto L01FA;
            L01E8: AddEncounter(player, 0x03, 0x28);
            L01FA: return; // RETURN;
        }

        private void Fn_10(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x0D), 0x0001);
            L0017: if (JumpNotEqual) goto L0029;
            L0019: ShowMessage(player, String0F13); // That will be the last time they underestimate you!
            L0026: goto L01F7;
            L0029: SetFlag(player, 0x03, 0x0D, 0x01);
            L003E: RefreshCompareFlags(GetFlag(player, 0x03, 0x0B));
            L0051: if (JumpNotEqual) goto L0086;
            L0053: SetWallObject(player, 0x00, GetCurrentTile(player), 0x00);
            L006B: SetWallPassable(player, GetCurrentTile(player), ax, 0x00);
0C87  0081 B8 46 0F  mov ax, 0xf46
            L0084: goto L0089;
            L0086: ShowMessage(player, String0FD6); // This time you attacked before the guard could seal the door!  Good going!
            L0093: RefreshCompareFlags(GetFlag(player, 0x03, 0x09));
            L00A6: if (JumpNotEqual) goto L00F9;
            L00A8: RefreshCompareFlags(GetFlag(player, 0x03, 0x0B));
            L00BB: if (JumpNotEqual) goto L00F9;
            L00BD: ShowMessage(player, String1020); // Not another ambush!  Yow!
0CD0  00CA B8 90 01  mov ax, 0x190
            L00CD: PushStack(player, ax);
            L00CE: PushStack(player, 0x0A);
            L00D2: PushStack(player, 0x01);
0CDC  00D6 C4 5E 06  les bx, [bp+0x6]
0CDF  00D9 26 FF 9F 9C 00  call far word [es:bx+0x9c]
0CE4  00DE 83 C4 06  add sp, 0x6
            L00E1: ax = GetMaxHits(player);
            L00E8: bx = 0x0002;
            L00EB: dx = ax % bx; ax = ax / bx;
            L00EE: PushStack(player, ax);
0CF5  00EF C4 5E 06  les bx, [bp+0x6]
0CF8  00F2 26 FF 9F 90 00  call far word [es:bx+0x90]
            L00F7: goto L0140;
            L00F9: ShowMessage(player, String1095); // You dive to the right and avoid the poisoned arrows.
            L0106: ax = GetMaxHits(player);
            L010D: bx = 0x0004;
            L0110: dx = ax % bx; ax = ax / bx;
            L0113: DamagePlayer(player, ax);
            L011D: PushStack(player, 0xC8);
            L0121: PushStack(player, 0x05);
            L0125: PushStack(player, 0x01);
0D2F  0129 C4 5E 06  les bx, [bp+0x6]
0D32  012C 26 FF 9F 9C 00  call far word [es:bx+0x9c]
0D37  0131 83 C4 06  add sp, 0x6
            L0134: ShowMessage(player, String106E); // Make that MOST of the poisoned arrows.
            L0141: SetFlag(player, 0x03, 0x09, 0x00);
0D5B  0155 B8 E8 01  mov ax, 0x1e8
            L0158: PushStack(player, ax);
            L0159: PushStack(player, 0x00);
            L015C: PushStack(player, ax);
            L015D: PushStack(player, ax);
            L015E: PushStack(player, 0xBB);
            L0162: PushStack(player, 0x9C);
0D6C  0166 C4 5E 06  les bx, [bp+0x6]
0D6F  0169 26 FF 9F D8 00  call far word [es:bx+0xd8]
0D74  016E 83 C4 0C  add sp, 0xc
            L0171: AddEncounter(player, 0x01, 0x26);
            L0183: AddEncounter(player, 0x05, 0x27);
            L0195: AddEncounter(player, 0x02, 0x28);
            L01A7: Compare(PartyCount(player), 0x0001);
            L01B2: if (JumpBelowOrEqual) goto L01D8;
            L01B4: AddEncounter(player, 0x06, 0x27);
            L01C6: AddEncounter(player, 0x04, 0x28);
            L01D8: Compare(PartyCount(player), 0x0002);
            L01E3: if (JumpBelowOrEqual) goto L01F7;
            L01E5: AddEncounter(player, 0x03, 0x28);
            L01F7: return; // RETURN;
        }

        private void Fn_11(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFlag(player, 0x03, 0x09, 0x00);
            L0017: return; // RETURN;
        }

        private void Fn_12(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x01));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L0126;
            L001B: RefreshCompareFlags(GetFlag(player, 0x03, 0x09));
            L002E: if (JumpNotEqual) goto L006D;
            L0030: ShowMessage(player, String10CA); // Now you understand!  When your mother told you that whenever you were in a strange building you should always check your tracks, she didn't mean wipe your feet; she meant watch out for ambushes.
            L003D: ax = GetMaxHits(player);
            L0044: bx = 0x0004;
            L0047: dx = ax % bx; ax = ax / bx;
            L004A: DamagePlayer(player, ax);
            L0054: PushStack(player, 0xC8);
            L0058: PushStack(player, 0x06);
            L005C: PushStack(player, 0x01);
0E78  0060 C4 5E 06  les bx, [bp+0x6]
0E7B  0063 26 FF 9F 9C 00  call far word [es:bx+0x9c]
0E80  0068 83 C4 06  add sp, 0x6
            L006B: goto L007A;
            L006D: ShowMessage(player, String118D); // Funny, but you would not expect vampires to poison the blood they would soon be drinking, but judging by those dripping quarrels, if they had surprised you, they would have poisoned you.
            L007A: PushStack(player, 0x01);
            L007E: PushStack(player, ax);
            L007F: PushStack(player, 0x03);
0E9B  0083 C4 5E 06  les bx, [bp+0x6]
0E9E  0086 26 FF 1F  call far word [es:bx]
0EA1  0089 83 C4 06  add sp, 0x6
0EA4  008C B8 45 01  mov ax, 0x145
            L008F: PushStack(player, ax);
            L0090: PushStack(player, 0x00);
            L0093: PushStack(player, ax);
            L0094: PushStack(player, 0xBA);
            L0098: PushStack(player, 0xF7);
            L009C: PushStack(player, 0x16);
0EB8  00A0 C4 5E 06  les bx, [bp+0x6]
0EBB  00A3 26 FF 9F D8 00  call far word [es:bx+0xd8]
0EC0  00A8 83 C4 0C  add sp, 0xc
            L00AB: AddEncounter(player, 0x01, 0x1F);
            L00BD: AddEncounter(player, 0x05, 0x21);
            L00CF: AddEncounter(player, 0x02, 0x1F);
            L00E1: AddEncounter(player, 0x06, 0x21);
            L00F3: Compare(PartyCount(player), 0x0003);
            L00FE: if (JumpBelowOrEqual) goto L0133;
            L0100: AddEncounter(player, 0x04, 0x1F);
            L0112: AddEncounter(player, 0x03, 0x1F);
            L0124: goto L0133;
            L0126: ShowMessage(player, String1248); // All that remains of your battle here are some damaged dentures.  I guess they don't make vampires like they used to.
            L0133: return; // RETURN;
        }

        private void Fn_13(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x02), 0x0001);
            L0017: if (JumpNotEqual) goto L0029;
            L0019: ShowMessage(player, String12BD); // All that remains of your battle here is a badly damaged kilt.
            L0026: goto L00E3;
            L0029: ShowMessage(player, String12FB); // That's not the Highland Fling those orcs are doing.  It looks more like the dagger fling, or perhaps the sword dance!
            L0036: SetFlag(player, 0x03, 0x02, 0x01);
0F98  004B B8 45 01  mov ax, 0x145
            L004E: PushStack(player, ax);
            L004F: PushStack(player, 0x00);
            L0052: PushStack(player, ax);
            L0053: PushStack(player, 0xCC);
            L0057: PushStack(player, 0xA9);
            L005B: PushStack(player, 0x1D);
0FAC  005F C4 5E 06  les bx, [bp+0x6]
0FAF  0062 26 FF 9F D8 00  call far word [es:bx+0xd8]
0FB4  0067 83 C4 0C  add sp, 0xc
            L006A: AddEncounter(player, 0x01, 0x1A);
            L007C: AddEncounter(player, 0x05, 0x1C);
            L008E: AddEncounter(player, 0x02, 0x1A);
            L00A0: AddEncounter(player, 0x06, 0x1C);
            L00B2: Compare(PartyCount(player), 0x0003);
            L00BD: if (JumpBelowOrEqual) goto L00E3;
            L00BF: AddEncounter(player, 0x04, 0x1C);
            L00D1: AddEncounter(player, 0x03, 0x1C);
            L00E3: return; // RETURN;
        }

        private void Fn_14(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1371); // Dare I say it?  You have found the regenerating skeletons in the closet!
            L0010: AddEncounter(player, 0x01, 0x20);
            L0022: AddEncounter(player, 0x02, 0x20);
            L0034: AddEncounter(player, 0x05, 0x20);
            L0046: AddEncounter(player, 0x06, 0x20);
            L0058: Compare(PartyCount(player), 0x0003);
            L0063: if (JumpBelowOrEqual) goto L0089;
            L0065: AddEncounter(player, 0x03, 0x20);
            L0077: AddEncounter(player, 0x04, 0x20);
            L0089: return; // RETURN;
        }

        private void Fn_15(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x03);
            L0007: PushStack(player, ax);
10C5  0008 C4 5E 06  les bx, [bp+0x6]
10C8  000B 26 FF 5F 04  call far word [es:bx+0x4]
            L000F: cx = PopStack(player);
            L0010: cx = PopStack(player);
            L0011: RefreshCompareFlags(ax);
            L0013: if (JumpEqual) goto L0018;
            L0015: goto L0123;
            L0018: RefreshCompareFlags(GetFlag(player, 0x03, 0x09));
            L002B: if (JumpNotEqual) goto L006A;
            L002D: ShowMessage(player, String13BA); // Who would have thought that undead could have the intelligence to set an ambush?  Obviously not you, because they caught you flatfooted.
            L003A: ax = GetMaxHits(player);
            L0041: bx = 0x0004;
            L0044: dx = ax % bx; ax = ax / bx;
            L0047: DamagePlayer(player, ax);
            L0051: PushStack(player, 0xC8);
            L0055: PushStack(player, 0x06);
            L0059: PushStack(player, 0x01);
111A  005D C4 5E 06  les bx, [bp+0x6]
111D  0060 26 FF 9F 9C 00  call far word [es:bx+0x9c]
1122  0065 83 C4 06  add sp, 0x6
            L0068: goto L0077;
            L006A: ShowMessage(player, String1443); // 'Tis a bunch o'wraiths holding a wrap party!
            L0077: PushStack(player, 0x01);
            L007B: PushStack(player, 0x03);
            L007F: PushStack(player, ax);
113D  0080 C4 5E 06  les bx, [bp+0x6]
1140  0083 26 FF 1F  call far word [es:bx]
1143  0086 83 C4 06  add sp, 0x6
1146  0089 B8 45 01  mov ax, 0x145
            L008C: PushStack(player, ax);
            L008D: PushStack(player, 0x00);
            L0090: PushStack(player, ax);
            L0091: PushStack(player, 0xBA);
            L0095: PushStack(player, 0xF7);
            L0099: PushStack(player, 0x16);
115A  009D C4 5E 06  les bx, [bp+0x6]
115D  00A0 26 FF 9F D8 00  call far word [es:bx+0xd8]
1162  00A5 83 C4 0C  add sp, 0xc
            L00A8: AddEncounter(player, 0x01, 0x24);
            L00BA: AddEncounter(player, 0x05, 0x22);
            L00CC: AddEncounter(player, 0x02, 0x24);
            L00DE: AddEncounter(player, 0x06, 0x22);
            L00F0: Compare(PartyCount(player), 0x0003);
            L00FB: if (JumpBelowOrEqual) goto L0130;
            L00FD: AddEncounter(player, 0x04, 0x22);
            L010F: AddEncounter(player, 0x03, 0x22);
            L0121: goto L0130;
            L0123: ShowMessage(player, String1470); // You want to have a little talk with whoever is making all these undead.
            L0130: return; // RETURN;
        }

        private void Fn_16(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x0C));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L0120;
            L001B: SetFlag(player, 0x03, 0x0C, 0x01);
            L0030: Compare(GetFlag(player, 0x03, 0x0A), 0x0001);
            L0044: if (JumpNotEqual) goto L0062;
            L0046: ax = GetMaxHits(player);
            L004D: bx = 0x0004;
            L0050: dx = ax % bx; ax = ax / bx;
            L0053: DamagePlayer(player, ax);
124C  005D B8 B8 14  mov ax, 0x14b8
            L0060: goto L007C;
            L0062: ax = GetMaxHits(player);
            L0069: bx = 0x0002;
            L006C: dx = ax % bx; ax = ax / bx;
            L006F: DamagePlayer(player, ax);
            L0079: ShowMessage(player, String154A); // As a conoisseur of combat, you can appreciate a well planned ambush.  You would appreciate it more if you weren't the target.
1275  0086 B8 45 01  mov ax, 0x145
            L0089: PushStack(player, ax);
            L008A: PushStack(player, 0x00);
            L008D: PushStack(player, ax);
            L008E: PushStack(player, 0xBA);
            L0092: PushStack(player, 0xFC);
            L0096: PushStack(player, 0x52);
1289  009A C4 5E 06  les bx, [bp+0x6]
128C  009D 26 FF 9F D8 00  call far word [es:bx+0xd8]
1291  00A2 83 C4 0C  add sp, 0xc
            L00A5: AddEncounter(player, 0x01, 0x28);
            L00B7: AddEncounter(player, 0x05, 0x27);
            L00C9: AddEncounter(player, 0x02, 0x28);
            L00DB: AddEncounter(player, 0x06, 0x27);
            L00ED: Compare(PartyCount(player), 0x0001);
            L00F8: if (JumpBelowOrEqual) goto L012D;
            L00FA: AddEncounter(player, 0x04, 0x28);
            L010C: AddEncounter(player, 0x03, 0x28);
            L011E: goto L012D;
            L0120: ShowMessage(player, String15C8); // The guildmaster's area is quiet.  We had some really scary music composed to play now, but after six beta testers took an axe to their speakers upon hearing it, we decided to leave well enough alone.
            L012D: return; // RETURN;
        }

        private void Fn_17(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x04), 0x0001);
            L0017: if (JumpNotEqual) goto L0029;
            L0019: ShowMessage(player, String1690); // You're just grateful that the baron efforts here didn't bear fruit.
            L0026: goto L00E6;
            L0029: ShowMessage(player, String16D4); // It's time to grin and baron it.
            L0036: SetFlag(player, 0x03, 0x04, 0x01);
            L004B: AddTreasure(player, 0x0145, 0x00, 0xC5, 0xBA, 0xB1, 0xAD);
            L006D: AddEncounter(player, 0x01, 0x1D);
            L007F: AddEncounter(player, 0x05, 0x1C);
            L0091: AddEncounter(player, 0x02, 0x1D);
            L00A3: AddEncounter(player, 0x06, 0x1A);
            L00B5: Compare(PartyCount(player), 0x0003);
            L00C0: if (JumpBelowOrEqual) goto L00E6;
            L00C2: AddEncounter(player, 0x04, 0x1A);
            L00D4: AddEncounter(player, 0x03, 0x1A);
            L00E6: return; // RETURN;
        }

        private void Fn_18(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x05), 0x0001);
            L0017: if (JumpNotEqual) goto L0029;
            L0019: ShowMessage(player, String16F4); // You're glad those undead didn't turn you into their deathday present.
            L0026: goto L00F0;
            L0029: ShowMessage(player, String173A); // It could be worse.  There could be more of them.  They could be tougher.  You could be wounded....
            L0036: ShowMessage(player, String179D); // Oh, right, you're now about to be wounded.
            L0043: SetFlag(player, 0x03, 0x05, 0x01);
145E  0058 B8 A9 01  mov ax, 0x1a9
            L005B: PushStack(player, ax);
            L005C: PushStack(player, 0x00);
            L005F: PushStack(player, ax);
            L0060: PushStack(player, 0xC9);
            L0064: PushStack(player, 0xB4);
            L0068: PushStack(player, 0xB2);
1472  006C C4 5E 06  les bx, [bp+0x6]
1475  006F 26 FF 9F D8 00  call far word [es:bx+0xd8]
147A  0074 83 C4 0C  add sp, 0xc
            L0077: AddEncounter(player, 0x01, 0x23);
            L0089: AddEncounter(player, 0x05, 0x22);
            L009B: AddEncounter(player, 0x02, 0x23);
            L00AD: AddEncounter(player, 0x06, 0x22);
            L00BF: Compare(PartyCount(player), 0x0003);
            L00CA: if (JumpBelowOrEqual) goto L00F0;
            L00CC: AddEncounter(player, 0x04, 0x21);
            L00DE: AddEncounter(player, 0x03, 0x21);
            L00F0: return; // RETURN;
        }

        private void Fn_19(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x06), 0x0001);
            L0017: if (JumpNotEqual) goto L0029;
            L0019: ShowMessage(player, String17C8); // You know, I wonder if other big groups of adventurers feel the same way you do when they see you coming.  Well, however they felt, they kept coming, until there were no more to come.
            L0026: goto L00E6;
            L0029: ShowMessage(player, String187F); // Funny how a great bunch of guys will send a round of drinks your way in the Rampant Cat Inn but send a round of missiles your way once they're in here.
            L0036: SetFlag(player, 0x03, 0x06, 0x01);
            L004B: AddTreasure(player, 0x0145, 0x00, 0x2D, 0xCC, 0x99, 0x9E);
            L006D: AddEncounter(player, 0x01, 0x1B);
            L007F: AddEncounter(player, 0x05, 0x25);
            L0091: AddEncounter(player, 0x02, 0x19);
            L00A3: AddEncounter(player, 0x06, 0x1E);
            L00B5: Compare(PartyCount(player), 0x0003);
            L00C0: if (JumpBelowOrEqual) goto L00E6;
            L00C2: AddEncounter(player, 0x04, 0x19);
            L00D4: AddEncounter(player, 0x03, 0x1B);
            L00E6: return; // RETURN;
        }

        private void Fn_1A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x07), 0x0001);
            L0017: if (JumpNotEqual) goto L0029;
            L0019: ShowMessage(player, String1917); // 'You know, vampires are the best reason you can think of for tighter immigration laws.  Let's send those Transylvanians back where they belong!
            L0026: goto L00E3;
            L0029: ShowMessage(player, String19A7); // You know, with all these vampires here, this must be your lucky day.  What?  You say you're not a coffin salesman?  Then I guess it's your unlucky day.
            L0036: SetFlag(player, 0x03, 0x07, 0x01);
162B  004B B8 45 01  mov ax, 0x145
            L004E: PushStack(player, ax);
            L004F: PushStack(player, 0x00);
            L0052: PushStack(player, ax);
            L0053: PushStack(player, 0xC0);
            L0057: PushStack(player, 0xF1);
            L005B: PushStack(player, 0x77);
163F  005F C4 5E 06  les bx, [bp+0x6]
1642  0062 26 FF 9F D8 00  call far word [es:bx+0xd8]
1647  0067 83 C4 0C  add sp, 0xc
            L006A: AddEncounter(player, 0x01, 0x1F);
            L007C: AddEncounter(player, 0x05, 0x18);
            L008E: AddEncounter(player, 0x02, 0x1F);
            L00A0: AddEncounter(player, 0x06, 0x18);
            L00B2: Compare(PartyCount(player), 0x0003);
            L00BD: if (JumpBelowOrEqual) goto L00E3;
            L00BF: AddEncounter(player, 0x04, 0x17);
            L00D1: AddEncounter(player, 0x03, 0x1F);
            L00E3: return; // RETURN;
        }

        private void Fn_1B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0023);
            L0010: ShowMessage(player, String1A3F); // A group of thieves are talking amongst themselves.
            L001D: RefreshCompareFlags(GetFlag(player, 0x03, 0x0E));
            L0030: if (JumpNotEqual) goto L0059;
            L0032: SetFlag(player, 0x03, 0x0E, 0x01);
            L0047: ShowMessage(player, String1A72); // You eavesdrop unobtrusively.  One of them said, 'Aye, someone used Ohthere's Dagger to walk over the Dissolving Pool upstairs.  Were it not for the guards, they would have won the Leaden - '
1719  0054 B8 31 1B  mov ax, 0x1b31
            L0057: goto L005C;
            L0059: ShowMessage(player, String1B91); // The thieves stop talking at your approach, and stare at you until you walk away.
            L0066: return; // RETURN;
        }

        private void Fn_1C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0024);
            L0010: ShowMessage(player, String1A3F); // A group of thieves are talking amongst themselves.
            L001D: RefreshCompareFlags(GetFlag(player, 0x03, 0x0F));
            L0030: if (JumpNotEqual) goto L0059;
            L0032: SetFlag(player, 0x03, 0x0F, 0x01);
            L0047: ShowMessage(player, String1BE2); // You eavesdrop unobtrusively.  One of them said, 'Things are all topsy-turvy upstairs.  In the kitchen they have sealed up the chimney, so thou mayst die without knowing thou wert being poi - '
1781  0054 B8 31 1B  mov ax, 0x1b31
            L0057: goto L005C;
            L0059: ShowMessage(player, String1B91); // The thieves stop talking at your approach, and stare at you until you walk away.
            L0066: return; // RETURN;
        }

        private void Fn_1D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0024);
            L0010: ShowMessage(player, String1A3F); // A group of thieves are talking amongst themselves.
            L001D: RefreshCompareFlags(GetFlag(player, 0x03, 0x10));
            L0030: if (JumpNotEqual) goto L0059;
            L0032: SetFlag(player, 0x03, 0x10, 0x01);
            L0047: ShowMessage(player, String1CA3); // You eavesdrop unobtrusively.  You overhear: '... so in the Library I finally deciphered an ancient tome that told me that I could protect myself against poison by using any of the gloves or gauntlets save - 
17E9  0054 B8 31 1B  mov ax, 0x1b31
            L0057: goto L005C;
            L0059: ShowMessage(player, String1B91); // The thieves stop talking at your approach, and stare at you until you walk away.
            L0066: return; // RETURN;
        }

        private void Fn_1E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0022);
            L0010: ShowMessage(player, String1A3F); // A group of thieves are talking amongst themselves.
            L001D: RefreshCompareFlags(GetFlag(player, 0x03, 0x11));
            L0030: if (JumpNotEqual) goto L0066;
            L0032: SetFlag(player, 0x03, 0x11, 0x01);
            L0047: ShowMessage(player, String1D73); // You eavesdrop unobtrusively.  You overhear: 
            L0054: ShowMessage(player, String1DA0); // '... and by my troth, those gorgons can paralyze thee just by touch!  But I found that the pungent punch of that bud of great worth, equipped as a ring but used as a pomade, ready to hand, to wit, the - Hoi!  This is a private conversation, cousin!'
185E  0061 B8 31 1B  mov ax, 0x1b31
            L0064: goto L0069;
            L0066: ShowMessage(player, String1B91); // The thieves stop talking at your approach, and stare at you until you walk away.
            L0073: return; // RETURN;
        }

        private void Fn_1F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1E9A); // You find the shards of a broken mirror, evidently smashed by the guildmaster lest you use it to divine secrets he was willing to die to protect.
            L0010: SetFlag(player, 0x03, 0x13, 0x01);
            L0025: return; // RETURN;
        }

        private void Fn_20(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, 0x0D), 0x000C);
            L0012: if (JumpNotBelow) goto L0080;
            L0014: RefreshCompareFlags(HasUsedSpell(player, 0x17));
            L0022: if (JumpNotEqual) goto L0080;
            L0024: PushStack(player, 0x67);
            L0028: PushStack(player, ax);
18C2  0029 C4 5E 06  les bx, [bp+0x6]
18C5  002C 26 FF 5F 54  call far word [es:bx+0x54]
            L0030: cx = PopStack(player);
            L0031: cx = PopStack(player);
            L0032: RefreshCompareFlags(ax);
            L0034: if (JumpNotEqual) goto L0080;
            L0036: PushStack(player, 0x61);
            L003A: PushStack(player, ax);
18D4  003B C4 5E 06  les bx, [bp+0x6]
18D7  003E 26 FF 5F 54  call far word [es:bx+0x54]
            L0042: cx = PopStack(player);
            L0043: cx = PopStack(player);
            L0044: RefreshCompareFlags(ax);
            L0046: if (JumpNotEqual) goto L0080;
            L0048: PushStack(player, 0x93);
            L004C: PushStack(player, ax);
18E6  004D C4 5E 06  les bx, [bp+0x6]
18E9  0050 26 FF 5F 54  call far word [es:bx+0x54]
            L0054: cx = PopStack(player);
            L0055: cx = PopStack(player);
            L0056: RefreshCompareFlags(ax);
            L0058: if (JumpNotEqual) goto L0080;
            L005A: PushStack(player, 0x86);
            L005E: PushStack(player, ax);
18F8  005F C4 5E 06  les bx, [bp+0x6]
18FB  0062 26 FF 5F 54  call far word [es:bx+0x54]
            L0066: cx = PopStack(player);
            L0067: cx = PopStack(player);
            L0068: RefreshCompareFlags(ax);
            L006A: if (JumpNotEqual) goto L0080;
            L006C: ax = IsFlagOn(player, 0x00, 0x01);
            L007E: if (JumpEqual) goto L00C9;
            L0080: SetWallObject(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L009E: ShowMessage(player, String1F2B); // You think you have rearranged the shards into something that makes sense.  The words you read are: 'poisoned dagger Gorgon's Garlic,' but you do not know what else to make of them.
            L00AB: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L00C9: return; // RETURN;
        }

        private void Fn_21(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x12));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00A5;
            L001B: ShowPortrait(player, 0x0025);
            L0028: SetFlag(player, 0x03, 0x12, 0x01);
            L003D: ShowMessage(player, String1FE0); // A drunken thief wobbles towards you, singing.
            L004A: ShowMessage(player, String200E); // 'Oh, the master has a mirror, 
            L0057: ShowMessage(player, String202D); // T'was stolen from a saint. 
            L0064: ShowMessage(player, String2049); // And though they use it now for ill,
            L0071: ShowMessage(player, String206D); // It does not feel their taint.
            L007E: ShowMessage(player, String208B); // It tries to help those true of heart,
            L008B: ShowMessage(player, String20B1); // And hinder those who ain't....'
            L0098: ShowMessage(player, String20D1); // The thief staggers off.
            L00A5: return; // RETURN;
        }

        private void Fn_22(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x13));
            L0016: if (JumpNotEqual) goto L0054;
            L0018: SetFlag(player, 0x03, 0x13, 0x01);
            L002D: ShowPortrait(player, 0x0025);
            L003A: ShowMessage(player, String20E9); // A halfling thief gasps his last breath.
            L0047: ShowMessage(player, String2111); // 'The mirror!  Dost thou understand?  I delayed the one whose task was to smash it.  There may yet be a message for thee, for thee....'  You hear the death rattle in his throat.  Before you can try healing or resuscitating him, his body turns to vapor.  He is gone.
            L0054: return; // RETURN;
        }

        private void Fn_23(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0x34);
            L0011: if (JumpNotEqual) goto L0024;
            L0013: GiveItem(player, 0x34);
1A80  001F B8 1A 22  mov ax, 0x221a
            L0022: goto L0027;
            L0024: ShowMessage(player, String2285); // This closet is empty.
            L0031: return; // RETURN;
        }

        private void Fn_24(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x15));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L0129;
            L001B: RefreshCompareFlags(GetFlag(player, 0x03, 0x09));
            L002E: if (JumpNotEqual) goto L006D;
            L0030: ShowMessage(player, String10CA); // Now you understand!  When your mother told you that whenever you were in a strange building you should always check your tracks, she didn't mean wipe your feet; she meant watch out for ambushes.
            L003D: ax = GetMaxHits(player);
            L0044: bx = 0x0004;
            L0047: dx = ax % bx; ax = ax / bx;
            L004A: DamagePlayer(player, ax);
            L0054: PushStack(player, 0xC8);
            L0058: PushStack(player, 0x06);
            L005C: PushStack(player, 0x01);
1AF4  0060 C4 5E 06  les bx, [bp+0x6]
1AF7  0063 26 FF 9F 9C 00  call far word [es:bx+0x9c]
1AFC  0068 83 C4 06  add sp, 0x6
            L006B: goto L007A;
            L006D: ShowMessage(player, String118D); // Funny, but you would not expect vampires to poison the blood they would soon be drinking, but judging by those dripping quarrels, if they had surprised you, they would have poisoned you.
            L007A: SetFlag(player, 0x03, 0x15, 0x01);
1B23  008F B8 45 01  mov ax, 0x145
            L0092: PushStack(player, ax);
            L0093: PushStack(player, 0x00);
            L0096: PushStack(player, ax);
            L0097: PushStack(player, 0xBA);
            L009B: PushStack(player, 0xF7);
            L009F: PushStack(player, 0x16);
1B37  00A3 C4 5E 06  les bx, [bp+0x6]
1B3A  00A6 26 FF 9F D8 00  call far word [es:bx+0xd8]
1B3F  00AB 83 C4 0C  add sp, 0xc
            L00AE: AddEncounter(player, 0x01, 0x1F);
            L00C0: AddEncounter(player, 0x05, 0x21);
            L00D2: AddEncounter(player, 0x02, 0x1F);
            L00E4: AddEncounter(player, 0x06, 0x21);
            L00F6: Compare(PartyCount(player), 0x0003);
            L0101: if (JumpBelowOrEqual) goto L0136;
            L0103: AddEncounter(player, 0x04, 0x1F);
            L0115: AddEncounter(player, 0x03, 0x1F);
            L0127: goto L0136;
            L0129: ShowMessage(player, String1248); // All that remains of your battle here are some damaged dentures.  I guess they don't make vampires like they used to.
            L0136: return; // RETURN;
        }

        private void Fn_25(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0029);
            L0010: ShowMessage(player, String229B); // A group of folks are talking amongst themselves.
            L001D: RefreshCompareFlags(GetFlag(player, 0x03, 0x16));
            L0030: if (JumpNotEqual) goto L0066;
            L0032: SetFlag(player, 0x03, 0x16, 0x01);
            L0047: ShowMessage(player, String22CC); // You eavesdrop unobtrusively.  The halfling cleric looks very familiar, for some reason, although far less clerical with collar loosened and tankard at hand.
            L0054: ShowMessage(player, String2369); // 'Indeed, I have sold forty-seven lucky pig's feet so far.  Tis the perfect, scam, cuz, for by the time the buyer learns that they do not work, the dragon has eaten him!'
1C2D  0061 B8 31 1B  mov ax, 0x1b31
            L0064: goto L0069;
            L0066: ShowMessage(player, String1B91); // The thieves stop talking at your approach, and stare at you until you walk away.
            L0073: return; // RETURN;
        }

    }
}
