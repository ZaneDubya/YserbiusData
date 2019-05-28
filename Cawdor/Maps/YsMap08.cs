#pragma warning disable
using System.Collections.Generic;
using XPT.WorldData;
using XPT.WorldData.Yserbius;

namespace XPT.Scripts.Yserbius.Maps {
    class YserMap08 : AMapScripted {
        protected override int MapIndex => 8;
        protected override int RandomEncounterChance => 10;
        protected override int RandomEncounterExtraCount => 0;

        public YserMap08() {
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
            MapEvent0C = Fn_0C;
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
        }
        
        // === Strings ================================================
        private const string String0140 = "It sure is drafty in here.";
        private const string String015B = "You've uncovered a hidden door!";
        private const string String017B = "You have unlocked the hidden door!";
        private const string String019E = "You detect a hidden door, but it is locked.";
        private const string String01CA = "You've picked the lock. Proceed.";
        private const string String01EB = "Funny how an irksome little lock on a flimsy little door can keep out a big strong person like you.";
        private const string String024F = "You are watching out for ambushes.";
        private const string String0272 = "AMBUSH!  Something ghostly and ghastly cast a fireball at you and then retreated!";
        private const string String02C4 = "Some faint tracks lure you onward.";
        private const string String02E7 = "You find some marks, but you are not adequately skilled to correctly interpret them.";
        private const string String033C = "This way to the Foyer of Cawdor.";
        private const string String035D = "You try squeezing down this narrow corridor, but it's so tight that - aargh!  You've been impaled on your companion's weapon!";
        private const string String03DB = "*";
        private const string String03DD = "Galatea greets you. 'My sisters oft frequent these higher levels.  Our chance of detection doth grow.";
        private const string String0443 = "As I wish that thou shalt come to end my unending life of drudgery, and to free those I have enslaved o'er the many centuries, I must hope that thou shalt grow wise in the ways of combat.  There is much to battle here.  I shall begin by rewarding thee in experience.'";
        private const string String054F = "'I think me that proficiency with a bow will best serve thee now.'  You now know that skill!";
        private const string String05AC = "'Thou art, by thy nature, less proficient with tools and weapons of complexity.  An thou art to progress in combat ways, thou shouldst know of the simplest combat weapons, those of the martial artist.  Behold!'  You know the martial arts skill!";
        private const string String06A1 = "'I think me thou art long past time to know the combat ways of quarterstaves.' You realize that you now know that skill!";
        private const string String071A = "'As thou art naturally a leader, it is now time that thou dost know how to inflict confusion on thy enemies.  Behold!'  You now know the Bard skill!";
        private const string String07AF = "'As thou art a woodsman, thou shouldst learn how to stalk thine foes, to increase the force of thy blows against them.' You know how to be furtive!";
        private const string String0843 = "'Some of thy gifts and rewards are hidden behind cloaks of repetition and drudgery, to deceive my less patient sisters.  Thou hast not explored fully the runed area of the Foyer, wherein a gift can be won, an thou art adequately patient.";
        private const string String0931 = "Use that gift in The Runed Room, where I have placed hints more obvious, an thou hast the skill to decipher them.'";
        private const string String09A4 = "'Thou mayst find my clues to thee in The Runed Room more direct, since my sisters lack the wit and wherewithal to decipher them.'";
        private const string String0A26 = "'I hope that thou didst have the wisdom and patience to decipher the clues I had hidden for thee in The Runed Room, but an thou hast not, then thou shalt have to proceed using what means thou dost possess.'";
        private const string String0AF5 = "She smiles.  'Even the most casual stroll through Fleance's lair, aye, and all his undead brethren, can bring great reward.  So leave not the Ruins precipitously!'";
        private const string String0B99 = "Galatea gets a distant look in her eyes.  'I dare no longer stay.  Good fortune!'  She disappears.";
        private const string String0BFC = "It looks like someone is investigating your meeting with Galatea here earlier!";
        private const string String0C4B = "This narrow corridor forces you to proceed single file.";
        private const string String0C83 = "Galatea's voice whispers, 'It is not safe to assay the next level leaving the Ghost of Fleance behind thee.'";
        private const string String0CF0 = "'Two elves, a thief and a ranger by their appearance, courteously hold open a secret door for you.  'There is no harm in my holding the door open for you,' he says.";
        private const string String0D95 = "Search though you may, you can not find the door that you know is right here!";
        private const string String0DE3 = "'Two elves, a ranger and a barbarian by their appearance, courteously hold open a very thick door for you.  'There is no harm in our holding the door open for you,' they say.";
        private const string String0E92 = "Struggle though you will, the door to the Brewery will not open.";
        private const string String0ED3 = "Ware!";
        private const string String0ED9 = "All that remains from your battle here is a badly abused magic wand.";
        private const string String0F1E = "The good news is these guys will have to bend down to hit you.  The bad news is that they are very flexible.";
        private const string String0F8B = "In fact, it looks like a veritable dancing troop of damaging titans.";
        private const string String0FD0 = "All that remains from your battle here is a piece of scorched tutu.  Makes you wonder, doesn't it.";
        private const string String1033 = "At least you can tell that those brain pans can't possibly hold enough brains to know how to cast spells against you. ";
        private const string String10AA = "All that remains from your battle here is a broken club and a scrap of fur.";
        private const string String10F6 = "Someone went to a lot of effort to defend this spot.";
        private const string String112B = "This many golems is enough to make one glum.";
        private const string String1158 = "The frightening thought is not that someone can make such horrid humanoids.  The frightening thought is that they can give them spellcasting abilities.  You feel fortunate to have survived.";
        private const string String1216 = "'Tis a veritable gaggle of giants and gremlins.";
        private const string String1246 = "The bones that remain here are big or small, but none are sized in-between.";
        private const string String1292 = "It looks like you're facing the Picts of the litter.";
        private const string String12C7 = "This place was thoroughly depicted earlier.";
        private const string String12F3 = "Oh my singed tailfeathers!  They got you from behind!";
        private const string String1329 = "And getting you from in front doesn't look much better, either.";
        private const string String1369 = "Your bones still ache from the battle you fought here.";
        private const string String13A0 = "You hear some footsteps running away.";
        private const string String13C6 = "You hear someone running towards you.";
        private const string String13EC = "A gargantuan gang of gremlins runs past you. One of them falls out and talks briefly.";
        private const string String1442 = "'Hide me!  Protect me!  Save me!  A press gang snapped me up and I cannot take any more of this!'";
        private const string String14A4 = "A burly sergeant wraps a whip around the gremlin's neck, jerking him back into the squad.  You decide not to interfere.";
        private const string String151C = "The dragon examines you with a baleful eye.  It has seen better days.";
        private const string String1562 = "'Wouldst thou help a wyrm in need of a reviving morsel?  Thou hast two legs; surely thou couldst spare me one.  Wouldst thou resist my efforts to consume thee, then?  I feared so.  Were I not wounded, though...'  It limps off.";
        private const string String1645 = "'I think we have met before.  In sooth, did I not offer thee some dragonish drachmas?  Howsomever, now that I am equipped with Brunanburh's bow I find my relationships with dragons much improved.  I doubt that the wyrms would say the same, though.'";
        private const string String173E = "The halfling struts off, smiling.";
        private const string String1760 = "It was here that you once met Rory Applebush.  You sigh deeply with the memory.";
        private const string String17B0 = "A somewhat battered gang o'gremlins decides, rather insultingly, that they are bigger than you are.";
        private const string String1814 = "'She said thou wouldst be coming, but we must take care.  The walls have ears.  That said, I can only suggest that thou shouldst seek thy doom in the other rooms on this level, and to be as constant as a clock.'  With a wink and a nod, the elf departs.";
        private const string String1911 = "The narrow corridor to the south forces you to enter it single file.";
        private const string String1956 = "You move vewwy vewwy quiet.  You found some twacks, hehehehehehe.";
        private const string String1998 = "This appears to be what's left of a large picture gallery.  Many holes in the wall and piles of marble dust provide mute testimony to its ransacking.";
        private const string String1A2E = "Sometimes barbarians can be so barbaric!";
        private const string String1A57 = "Obviously some civil libertarians were offended by all the pictures that were hung here.";
        private const string String1AB0 = "Whoever did this may not have known art, but they sure knew what they did not like!";
        private const string String1B04 = "Considering that Monet won't be born for another six centuries, this was not a complete catastrophe.";
        private const string String1B69 = "You find a portrait of the woman who posed for the Venus de Milo!  How about that!  She really had no arms!";
        private const string String1BD5 = "You find Rosetta's stone.  Sadly, Rosetta seems to have broken it against Edith's head.";
        private const string String1C2D = "You find some pre-Columbian artifacts.  In fact, you yourself are a pre-Columbian artifact!";
        private const string String1C89 = "Nine hundred years from now, this empty gallery with broken walls will be considered a classic example of destructionist art.";
        private const string String1D07 = "You know, this would be a decent fixer upper if there were just more foot traffic.";
        private const string String1D5A = "You find a post-it reminding someone to change the notation from mostly harmless to quite dangerous, actually.";
        private const string String1DC9 = "You see Fleance peering in at you, and charge!";
        private const string String1DF8 = "You feel like you are being watched.";
        private const string String1E1D = "Heck with bobbing and weaving.  You see Fleance peering in at you, and charge!";
        private const string String1E6C = "You bob and weave cautiously forward.";
        private const string String1E92 = "You see Fleance's Ghost up ahead of you, and charge!";
        private const string String1EC7 = "Wait for it.";
        private const string String1ED4 = "You find something inscribed in blood above what appears to be a finger bone in the wall to the north.";
        private const string String1F3B = "It reads, 'I sought Fleance'";
        private const string String1F58 = "'But now I die'";
        private const string String1F68 = "'Caught by ill chance'";
        private const string String1F7F = "'With no Hawk's Eye.'";
        private const string String1F95 = "You knew this was coming.";
        private const string String1FAF = "It appears that your moves were fancier than Fleance's.";
        private const string String1FE7 = "You find some useful things in Fleance's lair.";
        private const string String2016 = "This part of Fleance's lair is empty.  Almost too empty.  Well, okay, you're here, so it's not too empty.";
        
        // === Functions ================================================
        private void Fn_01(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0140); // It sure is drafty in here.
            L0010: Compare(HasUsedSkill(player, 0x0D), 0x0002);
            L001F: if (JumpNotBelow) goto L008B;
            L0021: RefreshCompareFlags(HasUsedSpell(player, 0x17));
            L002F: if (JumpNotEqual) goto L008B;
            L0031: PushStack(player, 0xA7);
            L0035: PushStack(player, ax);
0036  0036 C4 5E 06  les bx, [bp+0x6]
0039  0039 26 FF 5F 54  call far word [es:bx+0x54]
            L003D: cx = PopStack(player);
            L003E: cx = PopStack(player);
            L003F: RefreshCompareFlags(ax);
            L0041: if (JumpNotEqual) goto L008B;
            L0043: PushStack(player, 0x67);
            L0047: PushStack(player, ax);
0048  0048 C4 5E 06  les bx, [bp+0x6]
004B  004B 26 FF 5F 54  call far word [es:bx+0x54]
            L004F: cx = PopStack(player);
            L0050: cx = PopStack(player);
            L0051: RefreshCompareFlags(ax);
            L0053: if (JumpNotEqual) goto L008B;
            L0055: PushStack(player, 0x61);
            L0059: PushStack(player, ax);
005A  005A C4 5E 06  les bx, [bp+0x6]
005D  005D 26 FF 5F 54  call far word [es:bx+0x54]
            L0061: cx = PopStack(player);
            L0062: cx = PopStack(player);
            L0063: RefreshCompareFlags(ax);
            L0065: if (JumpNotEqual) goto L008B;
            L0067: PushStack(player, 0x93);
            L006B: PushStack(player, ax);
006C  006C C4 5E 06  les bx, [bp+0x6]
006F  006F 26 FF 5F 54  call far word [es:bx+0x54]
            L0073: cx = PopStack(player);
            L0074: cx = PopStack(player);
            L0075: RefreshCompareFlags(ax);
            L0077: if (JumpNotEqual) goto L008B;
            L0079: PushStack(player, 0x86);
            L007D: PushStack(player, ax);
007E  007E C4 5E 06  les bx, [bp+0x6]
0081  0081 26 FF 5F 54  call far word [es:bx+0x54]
            L0085: cx = PopStack(player);
            L0086: cx = PopStack(player);
            L0087: RefreshCompareFlags(ax);
            L0089: if (JumpEqual) goto L00D6;
            L008B: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L00A9: SetWallObject(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L00C7: ShowMessage(player, String015B); // You've uncovered a hidden door!
            L00D4: goto L0110;
            L00D6: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L00F3: SetWallObject(player, 0x00, GetCurrentTile(player), GetFacing(player));
            L0110: return; // RETURN;
        }

        private void Fn_02(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, 0x0D), 0x0002);
            L0012: if (JumpBelow) goto L0017;
            L0014: goto L0098;
            L0017: RefreshCompareFlags(HasUsedSpell(player, 0x17));
            L0025: if (JumpNotEqual) goto L0098;
            L0027: PushStack(player, 0xA7);
            L002B: PushStack(player, ax);
013E  002C C4 5E 06  les bx, [bp+0x6]
0141  002F 26 FF 5F 54  call far word [es:bx+0x54]
            L0033: cx = PopStack(player);
            L0034: cx = PopStack(player);
            L0035: RefreshCompareFlags(ax);
            L0037: if (JumpNotEqual) goto L0098;
            L0039: PushStack(player, 0x67);
            L003D: PushStack(player, ax);
0150  003E C4 5E 06  les bx, [bp+0x6]
0153  0041 26 FF 5F 54  call far word [es:bx+0x54]
            L0045: cx = PopStack(player);
            L0046: cx = PopStack(player);
            L0047: RefreshCompareFlags(ax);
            L0049: if (JumpNotEqual) goto L0098;
            L004B: PushStack(player, 0x61);
            L004F: PushStack(player, ax);
0162  0050 C4 5E 06  les bx, [bp+0x6]
0165  0053 26 FF 5F 54  call far word [es:bx+0x54]
            L0057: cx = PopStack(player);
            L0058: cx = PopStack(player);
            L0059: RefreshCompareFlags(ax);
            L005B: if (JumpNotEqual) goto L0098;
            L005D: PushStack(player, 0x93);
            L0061: PushStack(player, ax);
0174  0062 C4 5E 06  les bx, [bp+0x6]
0177  0065 26 FF 5F 54  call far word [es:bx+0x54]
            L0069: cx = PopStack(player);
            L006A: cx = PopStack(player);
            L006B: RefreshCompareFlags(ax);
            L006D: if (JumpNotEqual) goto L0098;
            L006F: PushStack(player, 0x86);
            L0073: PushStack(player, ax);
0186  0074 C4 5E 06  les bx, [bp+0x6]
0189  0077 26 FF 5F 54  call far word [es:bx+0x54]
            L007B: cx = PopStack(player);
            L007C: cx = PopStack(player);
            L007D: RefreshCompareFlags(ax);
            L007F: if (JumpNotEqual) goto L0098;
            L0081: ax = IsFlagOn(player, 0x00, 0x01);
            L0093: if (JumpNotEqual) goto L0098;
            L0095: goto L01C0;
            L0098: SetWallObject(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L00B6: PushStack(player, 0x01);
            L00BA: PushStack(player, ax);
            L00BB: PushStack(player, 0x00);
01D0  00BE C4 5E 06  les bx, [bp+0x6]
01D3  00C1 26 FF 1F  call far word [es:bx]
01D6  00C4 83 C4 06  add sp, 0x6
            L00C7: PushStack(player, 0x68);
            L00CB: PushStack(player, ax);
01DE  00CC C4 5E 06  les bx, [bp+0x6]
01E1  00CF 26 FF 5F 54  call far word [es:bx+0x54]
            L00D3: cx = PopStack(player);
            L00D4: cx = PopStack(player);
            L00D5: RefreshCompareFlags(ax);
            L00D7: if (JumpEqual) goto L0152;
            L00D9: ax = HasItem(player, 0xC1);
            L00E7: if (JumpEqual) goto L00EC;
            L00E9: goto L019F;
            L00EC: ax = HasItem(player, 0xC2);
            L00FA: if (JumpEqual) goto L00FF;
            L00FC: goto L019F;
            L00FF: ax = HasItem(player, 0xC3);
            L010D: if (JumpEqual) goto L0112;
            L010F: goto L019F;
            L0112: ax = HasItem(player, 0xDA);
            L0120: if (JumpNotEqual) goto L019F;
            L0122: ax = HasItem(player, 0xDB);
            L0130: if (JumpNotEqual) goto L019F;
            L0132: ax = HasItem(player, 0xDC);
            L0140: if (JumpNotEqual) goto L019F;
            L0142: ax = HasItem(player, 0xDD);
            L0150: if (JumpNotEqual) goto L019F;
            L0152: Compare(GetSkillLevel(player, 0x0E), 0x0006);
            L0161: if (JumpBelow) goto L018D;
            L0163: ax = HasUsedItem(player, 0xC1, 0xC3);
            L0176: if (JumpNotEqual) goto L019F;
            L0178: ax = HasUsedItem(player, 0xDA, 0xDD);
            L018B: if (JumpNotEqual) goto L019F;
            L018D: PushStack(player, 0xC0);
            L0191: PushStack(player, ax);
02A4  0192 C4 5E 06  les bx, [bp+0x6]
02A7  0195 26 FF 5F 54  call far word [es:bx+0x54]
            L0199: cx = PopStack(player);
            L019A: cx = PopStack(player);
            L019B: RefreshCompareFlags(ax);
            L019D: if (JumpEqual) goto L01B1;
            L019F: ShowMessage(player, String017B); // You have unlocked the hidden door!
02BE  01AC B8 01 00  mov ax, 0x1
            L01AF: goto L01C2;
            L01B1: ShowMessage(player, String019E); // You detect a hidden door, but it is locked.
            L01BE: goto L01C0;
            L01C0: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L01DD: return; // RETURN;
        }

        private void Fn_03(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x68);
            L0007: PushStack(player, ax);
02F9  0008 C4 5E 06  les bx, [bp+0x6]
02FC  000B 26 FF 5F 54  call far word [es:bx+0x54]
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
            L008E: Compare(GetSkillLevel(player, 0x0E), 0x0003);
            L009D: if (JumpBelow) goto L00C9;
            L009F: ax = HasUsedItem(player, 0xC1, 0xC3);
            L00B2: if (JumpNotEqual) goto L00DB;
            L00B4: ax = HasUsedItem(player, 0xDA, 0xDD);
            L00C7: if (JumpNotEqual) goto L00DB;
            L00C9: PushStack(player, 0xC0);
            L00CD: PushStack(player, ax);
03BF  00CE C4 5E 06  les bx, [bp+0x6]
03C2  00D1 26 FF 5F 54  call far word [es:bx+0x54]
            L00D5: cx = PopStack(player);
            L00D6: cx = PopStack(player);
            L00D7: RefreshCompareFlags(ax);
            L00D9: if (JumpEqual) goto L0108;
            L00DB: ShowMessage(player, String01CA); // You've picked the lock. Proceed.
            L00E8: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0106: goto L0132;
            L0108: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0125: ShowMessage(player, String01EB); // Funny how an irksome little lock on a flimsy little door can keep out a big strong person like you.
            L0132: return; // RETURN;
        }

        private void Fn_04(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x03);
            L0007: PushStack(player, ax);
042D  0008 C4 5E 06  les bx, [bp+0x6]
0430  000B 26 FF 5F 04  call far word [es:bx+0x4]
            L000F: cx = PopStack(player);
            L0010: cx = PopStack(player);
            L0011: RefreshCompareFlags(ax);
            L0013: if (JumpEqual) goto L0018;
            L0015: goto L01CC;
            L0018: RefreshCompareFlags(GetFlag(player, 0x03, 0x01));
            L002B: if (JumpEqual) goto L0030;
            L002D: goto L0116;
            L0030: PushStack(player, 0x02);
            L0034: PushStack(player, 0x00);
045C  0037 C4 5E 06  les bx, [bp+0x6]
045F  003A 26 FF 5F 04  call far word [es:bx+0x4]
            L003E: cx = PopStack(player);
            L003F: cx = PopStack(player);
            L0040: RefreshCompareFlags(ax);
            L0042: if (JumpEqual) goto L0047;
            L0044: goto L0116;
            L0047: Compare(HasUsedSkill(player, 0x0B), 0x0004);
            L0056: if (JumpAbove) goto L008E;
            L0058: PushStack(player, 0xA6);
            L005C: PushStack(player, ax);
0482  005D C4 5E 06  les bx, [bp+0x6]
0485  0060 26 FF 5F 54  call far word [es:bx+0x54]
            L0064: cx = PopStack(player);
            L0065: cx = PopStack(player);
            L0066: RefreshCompareFlags(ax);
            L0068: if (JumpNotEqual) goto L008E;
            L006A: PushStack(player, 0x62);
            L006E: PushStack(player, ax);
0494  006F C4 5E 06  les bx, [bp+0x6]
0497  0072 26 FF 5F 54  call far word [es:bx+0x54]
            L0076: cx = PopStack(player);
            L0077: cx = PopStack(player);
            L0078: RefreshCompareFlags(ax);
            L007A: if (JumpNotEqual) goto L008E;
            L007C: PushStack(player, 0x8F);
            L0080: PushStack(player, ax);
04A6  0081 C4 5E 06  les bx, [bp+0x6]
04A9  0084 26 FF 5F 54  call far word [es:bx+0x54]
            L0088: cx = PopStack(player);
            L0089: cx = PopStack(player);
            L008A: RefreshCompareFlags(ax);
            L008C: if (JumpEqual) goto L00C4;
            L008E: ShowMessage(player, String024F); // You are watching out for ambushes.
            L009B: PushStack(player, 0x01);
            L009F: PushStack(player, ax);
            L00A0: PushStack(player, 0x03);
04C9  00A4 C4 5E 06  les bx, [bp+0x6]
04CC  00A7 26 FF 1F  call far word [es:bx]
04CF  00AA 83 C4 06  add sp, 0x6
            L00AD: SetFlag(player, 0x00, 0x02, 0x01);
            L00C1: goto L01CC;
            L00C4: RefreshCompareFlags(GetFlag(player, 0x03, 0x10));
            L00D7: if (JumpEqual) goto L00DC;
            L00D9: goto L01CC;
            L00DC: SetFlag(player, 0x03, 0x01, 0x00);
            L00F0: ShowMessage(player, String0272); // AMBUSH!  Something ghostly and ghastly cast a fireball at you and then retreated!
            L00FD: ax = GetMaxHits(player);
            L0104: bx = 0x0005;
            L0107: dx = ax % bx; ax = ax / bx;
            L010A: PushStack(player, ax);
0530  010B C4 5E 06  les bx, [bp+0x6]
0533  010E 26 FF 9F 90 00  call far word [es:bx+0x90]
            L0113: goto L01CB;
            L0116: Compare(HasUsedSkill(player, 0x0B), 0x0004);
            L0125: if (JumpAbove) goto L015D;
            L0127: PushStack(player, 0xA6);
            L012B: PushStack(player, ax);
0551  012C C4 5E 06  les bx, [bp+0x6]
0554  012F 26 FF 5F 54  call far word [es:bx+0x54]
            L0133: cx = PopStack(player);
            L0134: cx = PopStack(player);
            L0135: RefreshCompareFlags(ax);
            L0137: if (JumpNotEqual) goto L015D;
            L0139: PushStack(player, 0x62);
            L013D: PushStack(player, ax);
0563  013E C4 5E 06  les bx, [bp+0x6]
0566  0141 26 FF 5F 54  call far word [es:bx+0x54]
            L0145: cx = PopStack(player);
            L0146: cx = PopStack(player);
            L0147: RefreshCompareFlags(ax);
            L0149: if (JumpNotEqual) goto L015D;
            L014B: PushStack(player, 0x8F);
            L014F: PushStack(player, ax);
0575  0150 C4 5E 06  les bx, [bp+0x6]
0578  0153 26 FF 5F 54  call far word [es:bx+0x54]
            L0157: cx = PopStack(player);
            L0158: cx = PopStack(player);
            L0159: RefreshCompareFlags(ax);
            L015B: if (JumpEqual) goto L0189;
            L015D: ShowMessage(player, String02C4); // Some faint tracks lure you onward.
            L016A: SetFlag(player, 0x00, 0x02, 0x01);
            L017E: PushStack(player, 0x01);
            L0182: PushStack(player, ax);
05A8  0183 B8 03 00  mov ax, 0x3
            L0186: goto L00B7;
            L0189: SetFlag(player, 0x03, 0x01, 0x00);
            L019D: Compare(HasUsedSkill(player, 0x0B), 0x0003);
            L01AC: if (JumpNotBelow) goto L01CC;
            L01AE: Compare(HasUsedSkill(player, 0x0B), 0x0001);
            L01BD: if (JumpBelow) goto L01CC;
            L01BF: ShowMessage(player, String02E7); // You find some marks, but you are not adequately skilled to correctly interpret them.
            L01CC: return; // RETURN;
        }

        private void Fn_05(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x03);
            L0007: PushStack(player, 0xFB);
            L000B: PushStack(player, 0x01);
            L000F: PushStack(player, ax);
0603  0010 C4 5E 06  les bx, [bp+0x6]
0606  0013 26 FF 9F BC 00  call far word [es:bx+0xbc]
060B  0018 83 C4 08  add sp, 0x8
            L001B: return; // RETURN;
        }

        private void Fn_06(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String033C); // This way to the Foyer of Cawdor.
            L0010: return; // RETURN;
        }

        private void Fn_07(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetNoJoinArea(player);
            L000B: Compare(PartyCount(player), 0x0001);
            L0016: if (JumpBelowOrEqual) goto L0039;
            L0018: ShowMessage(player, String035D); // You try squeezing down this narrow corridor, but it's so tight that - aargh!  You've been impaled on your companion's weapon!
            L0025: DamagePlayer(player, GetMaxHits(player));
            L0036: goto L02B0;
            L0039: RefreshCompareFlags(GetFlag(player, 0x02, 0x1D));
            L004C: if (JumpEqual) goto L0051;
            L004E: goto L0258;
            L0051: SetFlag(player, 0x02, 0x1D, 0x01);
            L0066: ShowMessage(player, String03DB); // *
            L0073: ShowMessage(player, String03DB); // *
            L0080: ShowMessage(player, String03DB); // *
            L008D: ShowPortrait(player, 0x0015);
            L009A: ShowMessage(player, String03DD); // Galatea greets you. 'My sisters oft frequent these higher levels.  Our chance of detection doth grow.
            L00A7: ShowMessage(player, String0443); // As I wish that thou shalt come to end my unending life of drudgery, and to free those I have enslaved o'er the many centuries, I must hope that thou shalt grow wise in the ways of combat.  There is much to battle here.  I shall begin by rewarding thee in experience.'
            L00B4: AddExperience(player, 0x000186A0);
            L00C6: Compare(GetGuild(player), 0x0003);
            L00D0: if (JumpNotEqual) goto L0100;
            L00D2: RefreshCompareFlags(GetSkillLevel(player, 0x08));
            L00E0: if (JumpNotEqual) goto L0100;
            L00E2: ShowMessage(player, String054F); // 'I think me that proficiency with a bow will best serve thee now.'  You now know that skill!
            L00EF: SetSkillLevel(player, 0x08, 0x01);
            L0100: RefreshCompareFlags(GetGuild(player));
            L0109: if (JumpNotEqual) goto L0139;
            L010B: RefreshCompareFlags(GetSkillLevel(player, 0x10));
            L0119: if (JumpNotEqual) goto L0139;
            L011B: ShowMessage(player, String05AC); // 'Thou art, by thy nature, less proficient with tools and weapons of complexity.  An thou art to progress in combat ways, thou shouldst know of the simplest combat weapons, those of the martial artist.  Behold!'  You know the martial arts skill!
            L0128: SetSkillLevel(player, 0x10, 0x01);
            L0139: Compare(GetGuild(player), 0x0004);
            L0143: if (JumpNotEqual) goto L0173;
            L0145: RefreshCompareFlags(GetSkillLevel(player, 0x15));
            L0153: if (JumpNotEqual) goto L0173;
            L0155: ShowMessage(player, String06A1); // 'I think me thou art long past time to know the combat ways of quarterstaves.' You realize that you now know that skill!
            L0162: SetSkillLevel(player, 0x15, 0x01);
            L0173: Compare(GetGuild(player), 0x0001);
            L017D: if (JumpEqual) goto L018B;
            L017F: Compare(GetGuild(player), 0x0005);
            L0189: if (JumpNotEqual) goto L01B9;
            L018B: RefreshCompareFlags(GetSkillLevel(player, 0x0C));
            L0199: if (JumpNotEqual) goto L01B9;
            L019B: ShowMessage(player, String071A); // 'As thou art naturally a leader, it is now time that thou dost know how to inflict confusion on thy enemies.  Behold!'  You now know the Bard skill!
            L01A8: SetSkillLevel(player, 0x0C, 0x01);
            L01B9: Compare(GetGuild(player), 0x0002);
            L01C3: if (JumpNotEqual) goto L01F3;
            L01C5: RefreshCompareFlags(GetSkillLevel(player, 0x0A));
            L01D3: if (JumpNotEqual) goto L01F3;
            L01D5: ShowMessage(player, String07AF); // 'As thou art a woodsman, thou shouldst learn how to stalk thine foes, to increase the force of thy blows against them.' You know how to be furtive!
            L01E2: SetSkillLevel(player, 0x0A, 0x01);
            L01F3: RefreshCompareFlags(GetSkillLevel(player, 0x14));
            L0201: if (JumpNotEqual) goto L0215;
            L0203: ShowMessage(player, String0843); // 'Some of thy gifts and rewards are hidden behind cloaks of repetition and drudgery, to deceive my less patient sisters.  Thou hast not explored fully the runed area of the Foyer, wherein a gift can be won, an thou art adequately patient.
0832  0210 B8 31 09  mov ax, 0x931
            L0213: goto L0232;
            L0215: RefreshCompareFlags(GetFlag(player, 0x02, 0x1F));
            L0228: if (JumpNotEqual) goto L022F;
084C  022A B8 A4 09  mov ax, 0x9a4
            L022D: goto L0232;
            L022F: ShowMessage(player, String0A26); // 'I hope that thou didst have the wisdom and patience to decipher the clues I had hidden for thee in The Runed Room, but an thou hast not, then thou shalt have to proceed using what means thou dost possess.'
            L023C: ShowMessage(player, String0AF5); // She smiles.  'Even the most casual stroll through Fleance's lair, aye, and all his undead brethren, can bring great reward.  So leave not the Ruins precipitously!'
086B  0249 B8 99 0B  mov ax, 0xb99
            L024C: PushStack(player, ax);
086F  024D C4 5E 06  les bx, [bp+0x6]
0872  0250 26 FF 9F F8 00  call far word [es:bx+0xf8]
            L0255: goto L0035;
            L0258: RefreshCompareFlags(GetFlag(player, 0x02, 0x1E));
            L026B: if (JumpNotEqual) goto L02B0;
            L026D: ShowMessage(player, String0BFC); // It looks like someone is investigating your meeting with Galatea here earlier!
            L027A: SetFlag(player, 0x02, 0x1E, 0x01);
            L028F: PushStack(player, 0x01);
            L0293: PushStack(player, ax);
08B6  0294 C4 5E 06  les bx, [bp+0x6]
08B9  0297 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L029C: cx = PopStack(player);
            L029D: cx = PopStack(player);
            L029E: AddEncounter(player, 0x05, 0x01);
            L02B0: return; // RETURN;
        }

        private void Fn_08(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetNoJoinArea(player);
            L000B: SetFlag(player, 0x02, 0x15, 0x01);
            L0020: Compare(PartyCount(player), 0x0001);
            L002B: if (JumpBelowOrEqual) goto L004E;
            L002D: ShowMessage(player, String035D); // You try squeezing down this narrow corridor, but it's so tight that - aargh!  You've been impaled on your companion's weapon!
            L003A: DamagePlayer(player, GetMaxHits(player));
            L004B: goto L00FE;
            L004E: RefreshCompareFlags(GetFlag(player, 0x03, 0x0D));
            L0061: if (JumpNotEqual) goto L0085;
            L0063: SetFlag(player, 0x03, 0x0D, 0x01);
            L0078: ShowMessage(player, String0C4B); // This narrow corridor forces you to proceed single file.
            L0085: RefreshCompareFlags(GetFlag(player, 0x02, 0x26));
            L0098: if (JumpNotEqual) goto L00D6;
            L009A: PushStack(player, 0x03);
            L009E: PushStack(player, ax);
0973  009F C4 5E 06  les bx, [bp+0x6]
0976  00A2 26 FF 5F 04  call far word [es:bx+0x4]
            L00A6: cx = PopStack(player);
            L00A7: cx = PopStack(player);
            L00A8: RefreshCompareFlags(ax);
            L00AA: if (JumpNotEqual) goto L00D6;
            L00AC: SetWallPassable(player, 0xF9, 0x01, 0x00);
            L00C1: SetWallObject(player, 0x00, 0xF9, 0x01);
            L00D6: SetFlag(player, 0x02, 0x20, 0x00);
            L00EA: SetFlag(player, 0x02, 0x21, 0x00);
            L00FE: return; // RETURN;
        }

        private void Fn_09(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0x26), 0x0001);
            L0017: if (JumpEqual) goto L002C;
            L0019: PushStack(player, 0x03);
            L001D: PushStack(player, ax);
09F2  001E C4 5E 06  les bx, [bp+0x6]
09F5  0021 26 FF 5F 04  call far word [es:bx+0x4]
            L0025: cx = PopStack(player);
            L0026: cx = PopStack(player);
            L0027: Compare(ax, 0x0001);
            L002A: if (JumpNotEqual) goto L005E;
            L002C: SetFlag(player, 0x02, 0x26, 0x01);
            L0041: TeleportParty(player, 0x05, 0x02, 0xFA, 0x03, isForwardMove);
            L005C: goto L006B;
            L005E: ShowMessage(player, String0C83); // Galatea's voice whispers, 'It is not safe to assay the next level leaving the Ghost of Fleance behind thee.'
            L006B: return; // RETURN;
        }

        private void Fn_0A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x03);
0A48  0007 C4 5E 06  les bx, [bp+0x6]
0A4B  000A 26 FF 9F B0 00  call far word [es:bx+0xb0]
            L000F: cx = PopStack(player);
            L0010: RefreshCompareFlags(ax);
            L0012: if (JumpEqual) goto L0025;
            L0014: PushStack(player, 0x02);
0A59  0018 C4 5E 06  les bx, [bp+0x6]
0A5C  001B 26 FF 9F B0 00  call far word [es:bx+0xb0]
            L0020: cx = PopStack(player);
            L0021: RefreshCompareFlags(ax);
            L0023: if (JumpNotEqual) goto L0054;
            L0025: Compare(GetFlag(player, 0x02, 0x14), 0x0001);
            L0039: if (JumpEqual) goto L0054;
            L003B: Compare(GetFlag(player, 0x02, 0x16), 0x0001);
            L004F: if (JumpEqual) goto L0054;
            L0051: goto L00F0;
            L0054: ShowPortrait(player, 0x001F);
            L0061: ShowMessage(player, String0CF0); // 'Two elves, a thief and a ranger by their appearance, courteously hold open a secret door for you.  'There is no harm in my holding the door open for you,' he says.
            L006E: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L008C: SetWallObject(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L00AA: SetFlag(player, 0x02, 0x20, 0x00);
            L00BE: SetFlag(player, 0x02, 0x21, 0x01);
            L00D3: TeleportParty(player, 0x04, 0x02, 0xFD, 0x03, isForwardMove);
            L00EE: goto L0113;
            L00F0: Compare(GetFlag(player, 0x03, 0x02), 0x0001);
            L0104: if (JumpNotEqual) goto L0113;
            L0106: ShowMessage(player, String0D95); // Search though you may, you can not find the door that you know is right here!
            L0113: return; // RETURN;
        }

        private void Fn_0C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x00);
0B61  0006 C4 5E 06  les bx, [bp+0x6]
0B64  0009 26 FF 9F B0 00  call far word [es:bx+0xb0]
            L000E: cx = PopStack(player);
            L000F: RefreshCompareFlags(ax);
            L0011: if (JumpEqual) goto L0024;
            L0013: PushStack(player, 0x02);
0B72  0017 C4 5E 06  les bx, [bp+0x6]
0B75  001A 26 FF 9F B0 00  call far word [es:bx+0xb0]
            L001F: cx = PopStack(player);
            L0020: RefreshCompareFlags(ax);
            L0022: if (JumpNotEqual) goto L0093;
            L0024: PushStack(player, 0x00);
0B82  0027 C4 5E 06  les bx, [bp+0x6]
0B85  002A 26 FF 9F B0 00  call far word [es:bx+0xb0]
            L002F: cx = PopStack(player);
            L0030: RefreshCompareFlags(ax);
            L0032: if (JumpEqual) goto L0045;
            L0034: PushStack(player, 0x05);
0B93  0038 C4 5E 06  les bx, [bp+0x6]
0B96  003B 26 FF 9F B0 00  call far word [es:bx+0xb0]
            L0040: cx = PopStack(player);
            L0041: RefreshCompareFlags(ax);
            L0043: if (JumpNotEqual) goto L0093;
            L0045: PushStack(player, 0x05);
0BA4  0049 C4 5E 06  les bx, [bp+0x6]
0BA7  004C 26 FF 9F B0 00  call far word [es:bx+0xb0]
            L0051: cx = PopStack(player);
            L0052: RefreshCompareFlags(ax);
            L0054: if (JumpEqual) goto L0067;
            L0056: PushStack(player, 0x02);
0BB5  005A C4 5E 06  les bx, [bp+0x6]
0BB8  005D 26 FF 9F B0 00  call far word [es:bx+0xb0]
            L0062: cx = PopStack(player);
            L0063: RefreshCompareFlags(ax);
            L0065: if (JumpNotEqual) goto L0093;
            L0067: Compare(GetFlag(player, 0x02, 0x14), 0x0001);
            L007B: if (JumpEqual) goto L0093;
            L007D: Compare(GetFlag(player, 0x02, 0x17), 0x0001);
            L0091: if (JumpNotEqual) goto L0110;
            L0093: ShowPortrait(player, 0x0018);
            L00A0: ShowMessage(player, String0DE3); // 'Two elves, a ranger and a barbarian by their appearance, courteously hold open a very thick door for you.  'There is no harm in our holding the door open for you,' they say.
            L00AD: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L00CB: SetFlag(player, 0x02, 0x20, 0x01);
            L00E0: SetFlag(player, 0x02, 0x21, 0x00);
            L00F4: TeleportParty(player, 0x04, 0x03, 0xCF, 0x00, isForwardMove);
            L010E: goto L011D;
            L0110: ShowMessage(player, String0E92); // Struggle though you will, the door to the Brewery will not open.
            L011D: return; // RETURN;
        }

        private void Fn_0E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x04));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00E4;
            L001B: SetFlag(player, 0x03, 0x04, 0x01);
            L0030: ShowMessage(player, String0ED3); // Ware!
            L003D: PushStack(player, 0x7D);
            L0041: PushStack(player, 0x00);
            L0044: PushStack(player, ax);
            L0045: PushStack(player, 0xB9);
            L0049: PushStack(player, 0xBD);
            L004D: PushStack(player, 0x05);
0CD0  0051 C4 5E 06  les bx, [bp+0x6]
0CD3  0054 26 FF 9F D8 00  call far word [es:bx+0xd8]
0CD8  0059 83 C4 0C  add sp, 0xc
            L005C: AddEncounter(player, 0x01, 0x19);
            L006E: AddEncounter(player, 0x05, 0x1A);
            L0080: Compare(PartyCount(player), 0x0002);
            L008B: if (JumpBelowOrEqual) goto L00B1;
            L008D: AddEncounter(player, 0x02, 0x19);
            L009F: AddEncounter(player, 0x06, 0x1A);
            L00B1: Compare(PartyCount(player), 0x0003);
            L00BC: if (JumpBelowOrEqual) goto L00F1;
            L00BE: AddEncounter(player, 0x04, 0x19);
            L00D0: AddEncounter(player, 0x03, 0x19);
            L00E2: goto L00F1;
            L00E4: ShowMessage(player, String0ED9); // All that remains from your battle here is a badly abused magic wand.
            L00F1: return; // RETURN;
        }

        private void Fn_0F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x05));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00F5;
            L001B: SetFlag(player, 0x03, 0x05, 0x01);
            L0030: ShowMessage(player, String0F1E); // The good news is these guys will have to bend down to hit you.  The bad news is that they are very flexible.
            L003D: Compare(PartyCount(player), 0x0003);
            L0048: if (JumpBelowOrEqual) goto L0057;
            L004A: ShowMessage(player, String0F8B); // In fact, it looks like a veritable dancing troop of damaging titans.
            L0057: PushStack(player, 0xBB);
            L005B: PushStack(player, 0x00);
            L005E: PushStack(player, ax);
            L005F: PushStack(player, ax);
            L0060: PushStack(player, ax);
            L0061: PushStack(player, ax);
0DD4  0062 C4 5E 06  les bx, [bp+0x6]
0DD7  0065 26 FF 9F D8 00  call far word [es:bx+0xd8]
0DDC  006A 83 C4 0C  add sp, 0xc
            L006D: AddEncounter(player, 0x01, 0x1B);
            L007F: AddEncounter(player, 0x02, 0x20);
            L0091: Compare(PartyCount(player), 0x0002);
            L009C: if (JumpBelowOrEqual) goto L00C2;
            L009E: AddEncounter(player, 0x03, 0x21);
            L00B0: AddEncounter(player, 0x04, 0x22);
            L00C2: Compare(PartyCount(player), 0x0003);
            L00CD: if (JumpBelowOrEqual) goto L0102;
            L00CF: AddEncounter(player, 0x05, 0x21);
            L00E1: AddEncounter(player, 0x06, 0x22);
            L00F3: goto L0102;
            L00F5: ShowMessage(player, String0FD0); // All that remains from your battle here is a piece of scorched tutu.  Makes you wonder, doesn't it.
            L0102: return; // RETURN;
        }

        private void Fn_10(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x06));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00E4;
            L001B: SetFlag(player, 0x03, 0x06, 0x01);
            L0030: ShowMessage(player, String1033); // At least you can tell that those brain pans can't possibly hold enough brains to know how to cast spells against you. 
            L003D: PushStack(player, 0x7D);
            L0041: PushStack(player, 0x00);
            L0044: PushStack(player, ax);
            L0045: PushStack(player, 0xB9);
            L0049: PushStack(player, 0xAC);
            L004D: PushStack(player, 0x27);
0EC7  0051 C4 5E 06  les bx, [bp+0x6]
0ECA  0054 26 FF 9F D8 00  call far word [es:bx+0xd8]
0ECF  0059 83 C4 0C  add sp, 0xc
            L005C: AddEncounter(player, 0x01, 0x23);
            L006E: AddEncounter(player, 0x02, 0x24);
            L0080: Compare(PartyCount(player), 0x0002);
            L008B: if (JumpBelowOrEqual) goto L00B1;
            L008D: AddEncounter(player, 0x03, 0x24);
            L009F: AddEncounter(player, 0x04, 0x25);
            L00B1: Compare(PartyCount(player), 0x0003);
            L00BC: if (JumpBelowOrEqual) goto L00F1;
            L00BE: AddEncounter(player, 0x05, 0x23);
            L00D0: AddEncounter(player, 0x06, 0x25);
            L00E2: goto L00F1;
            L00E4: ShowMessage(player, String10AA); // All that remains from your battle here is a broken club and a scrap of fur.
            L00F1: return; // RETURN;
        }

        private void Fn_11(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x07));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00FE;
            L001B: SetFlag(player, 0x03, 0x07, 0x01);
            L0030: ShowMessage(player, String10F6); // Someone went to a lot of effort to defend this spot.
            L003D: Compare(PartyCount(player), 0x0003);
            L0048: if (JumpBelowOrEqual) goto L0057;
            L004A: ShowMessage(player, String112B); // This many golems is enough to make one glum.
0FC0  0057 B8 B9 03  mov ax, 0x3b9
            L005A: PushStack(player, ax);
            L005B: PushStack(player, 0x00);
            L005E: PushStack(player, ax);
            L005F: PushStack(player, 0xB9);
            L0063: PushStack(player, 0xB6);
            L0067: PushStack(player, 0x2E);
0FD4  006B C4 5E 06  les bx, [bp+0x6]
0FD7  006E 26 FF 9F D8 00  call far word [es:bx+0xd8]
0FDC  0073 83 C4 0C  add sp, 0xc
            L0076: AddEncounter(player, 0x01, 0x1D);
            L0088: AddEncounter(player, 0x05, 0x1C);
            L009A: Compare(PartyCount(player), 0x0002);
            L00A5: if (JumpBelowOrEqual) goto L00CB;
            L00A7: AddEncounter(player, 0x02, 0x1D);
            L00B9: AddEncounter(player, 0x06, 0x1E);
            L00CB: Compare(PartyCount(player), 0x0003);
            L00D6: if (JumpBelowOrEqual) goto L010B;
            L00D8: AddEncounter(player, 0x04, 0x1F);
            L00EA: AddEncounter(player, 0x03, 0x1F);
            L00FC: goto L010B;
            L00FE: ShowMessage(player, String1158); // The frightening thought is not that someone can make such horrid humanoids.  The frightening thought is that they can give them spellcasting abilities.  You feel fortunate to have survived.
            L010B: return; // RETURN;
        }

        private void Fn_12(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x08));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00E4;
            L001B: SetFlag(player, 0x03, 0x08, 0x01);
            L0030: ShowMessage(player, String1216); // 'Tis a veritable gaggle of giants and gremlins.
10B3  003D B8 32 02  mov ax, 0x232
            L0040: PushStack(player, ax);
            L0041: PushStack(player, 0x00);
            L0044: PushStack(player, ax);
            L0045: PushStack(player, 0x98);
            L0049: PushStack(player, 0x5B);
            L004D: PushStack(player, 0x91);
10C7  0051 C4 5E 06  les bx, [bp+0x6]
10CA  0054 26 FF 9F D8 00  call far word [es:bx+0xd8]
10CF  0059 83 C4 0C  add sp, 0xc
            L005C: AddEncounter(player, 0x01, 0x1B);
            L006E: AddEncounter(player, 0x05, 0x1A);
            L0080: Compare(PartyCount(player), 0x0002);
            L008B: if (JumpBelowOrEqual) goto L00B1;
            L008D: AddEncounter(player, 0x02, 0x1B);
            L009F: AddEncounter(player, 0x06, 0x1A);
            L00B1: Compare(PartyCount(player), 0x0003);
            L00BC: if (JumpBelowOrEqual) goto L00F1;
            L00BE: AddEncounter(player, 0x04, 0x1B);
            L00D0: AddEncounter(player, 0x03, 0x1A);
            L00E2: goto L00F1;
            L00E4: ShowMessage(player, String1246); // The bones that remain here are big or small, but none are sized in-between.
            L00F1: return; // RETURN;
        }

        private void Fn_13(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x09));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00D2;
            L001B: SetFlag(player, 0x03, 0x09, 0x01);
            L0030: ShowMessage(player, String1292); // It looks like you're facing the Picts of the litter.
            L003D: PushStack(player, 0x7D);
            L0041: PushStack(player, 0x00);
            L0044: PushStack(player, ax);
            L0045: PushStack(player, 0x13);
            L0049: PushStack(player, 0x8F);
            L004D: PushStack(player, 0x5C);
11BA  0051 C4 5E 06  les bx, [bp+0x6]
11BD  0054 26 FF 9F D8 00  call far word [es:bx+0xd8]
11C2  0059 83 C4 0C  add sp, 0xc
            L005C: AddEncounter(player, 0x01, 0x23);
            L006E: AddEncounter(player, 0x02, 0x24);
            L0080: Compare(PartyCount(player), 0x0002);
            L008B: if (JumpBelowOrEqual) goto L009F;
            L008D: AddEncounter(player, 0x03, 0x23);
            L009F: Compare(PartyCount(player), 0x0003);
            L00AA: if (JumpBelowOrEqual) goto L00DF;
            L00AC: AddEncounter(player, 0x04, 0x24);
            L00BE: AddEncounter(player, 0x05, 0x25);
            L00D0: goto L00DF;
            L00D2: ShowMessage(player, String12C7); // This place was thoroughly depicted earlier.
            L00DF: return; // RETURN;
        }

        private void Fn_14(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x0A));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L0180;
            L001B: SetFlag(player, 0x03, 0x0A, 0x01);
            L0030: ShowMessage(player, String12F3); // Oh my singed tailfeathers!  They got you from behind!
            L003D: ax = GetMaxHits(player);
            L0044: bx = 0x0004;
            L0047: dx = ax % bx; ax = ax / bx;
            L004A: DamagePlayer(player, ax);
            L0054: Compare(PartyCount(player), 0x0003);
            L005F: if (JumpBelowOrEqual) goto L006E;
            L0061: ShowMessage(player, String1329); // And getting you from in front doesn't look much better, either.
            L006E: AddTreasure(player, 0x007D, 0x00, 0x72, 0x1B, 0xC7, 0x8E);
            L0090: AddEncounter(player, 0x01, 0x25);
            L00A2: AddEncounter(player, 0x05, 0x1C);
            L00B4: ax = CheckLevel(player, 0x000C);
            L00C2: if (JumpEqual) goto L012B;
            L00C4: Compare(PartyCount(player), 0x0002);
            L00CF: if (JumpBelowOrEqual) goto L00F5;
            L00D1: AddEncounter(player, 0x02, 0x25);
            L00E3: AddEncounter(player, 0x06, 0x1E);
            L00F5: Compare(PartyCount(player), 0x0003);
            L0100: if (JumpAbove) goto L0105;
            L0102: goto L018D;
            L0105: AddEncounter(player, 0x04, 0x25);
            L0117: AddEncounter(player, 0x03, 0x1C);
            L0129: goto L018D;
            L012B: Compare(PartyCount(player), 0x0002);
            L0136: if (JumpBelowOrEqual) goto L015C;
            L0138: AddEncounter(player, 0x02, 0x23);
            L014A: AddEncounter(player, 0x06, 0x1E);
            L015C: Compare(PartyCount(player), 0x0003);
            L0167: if (JumpBelowOrEqual) goto L018D;
            L0169: AddEncounter(player, 0x04, 0x1F);
13C5  017B B8 1F 00  mov ax, 0x1f
            L017E: goto L011A;
            L0180: ShowMessage(player, String1369); // Your bones still ache from the battle you fought here.
            L018D: return; // RETURN;
        }

        private void Fn_15(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si, di);
            L0005: di = 0;
            L0007: si = 0;
            L0009: ax = GetFlag(player, 0x03, 0x0B);
13F3  001A 8B F8  mov di, ax
13F5  001C 47     inc di
13F6  001D 8B F7  mov si, di
            L001F: Compare(si, 0x13);
            L0022: if (JumpLessOrEqual) goto L002B;
13FD  0024 8B C6  mov ax, si
            L0026: si = ax + 0xFFEC;
            L002B: Compare(si, 0x0E);
            L002E: if (JumpLessOrEqual) goto L0037;
1409  0030 8B C6  mov ax, si
            L0032: si = ax + 0xFFF1;
            L0037: Compare(si, 0x09);
            L003A: if (JumpLessOrEqual) goto L0043;
1415  003C 8B C6  mov ax, si
            L003E: si = ax + 0xFFF6;
            L0043: Compare(si, 0x04);
            L0046: if (JumpLessOrEqual) goto L004F;
1421  0048 8B C6  mov ax, si
            L004A: si = ax + 0xFFFB;
1428  004F 0B F6  or si, si
142A  0051 7D 02  jge 0x55
            L0053: si = 0;
            L0055: Compare(si, 0x1D);
            L0058: if (JumpLessOrEqual) goto L005C;
            L005A: si = 0;
1435  005C 83 FF 1E  cmp di, 0x1e
            L005F: if (JumpLessOrEqual) goto L0063;
            L0061: di = 0;
143C  0063 57     push di
            L0064: PushStack(player, 0x0B);
            L0068: PushStack(player, 0x03);
1445  006C C4 5E 06  les bx, [bp+0x6]
1448  006F 26 FF 1F  call far word [es:bx]
144B  0072 83 C4 06  add sp, 0x6
144E  0075 83 FF 1A  cmp di, 0x1a
            L0078: if (JumpNotEqual) goto L007F;
1453  007A B8 01 00  mov ax, 0x1
            L007D: goto L0081;
            L007F: PushStack(player, 0x00);
145B  0082 83 FF 14  cmp di, 0x14
            L0085: if (JumpNotEqual) goto L008C;
1460  0087 B8 01 00  mov ax, 0x1
            L008A: goto L008E;
1465  008C 33 C0  xor ax, ax
            L008E: dx = PopStack(player);
1468  008F 0B D0  or dx, ax
            L0091: PushStack(player, dx);
146B  0092 83 FF 0E  cmp di, 0xe
            L0095: if (JumpNotEqual) goto L009C;
1470  0097 B8 01 00  mov ax, 0x1
            L009A: goto L009E;
1475  009C 33 C0  xor ax, ax
            L009E: dx = PopStack(player);
1478  009F 0B D0  or dx, ax
            L00A1: PushStack(player, dx);
147B  00A2 83 FF 08  cmp di, 0x8
            L00A5: if (JumpNotEqual) goto L00AC;
1480  00A7 B8 01 00  mov ax, 0x1
            L00AA: goto L00AE;
1485  00AC 33 C0  xor ax, ax
            L00AE: dx = PopStack(player);
1488  00AF 0B D0  or dx, ax
            L00B1: PushStack(player, dx);
148B  00B2 83 FF 02  cmp di, 0x2
            L00B5: if (JumpNotEqual) goto L00BC;
1490  00B7 B8 01 00  mov ax, 0x1
            L00BA: goto L00BE;
1495  00BC 33 C0  xor ax, ax
            L00BE: dx = PopStack(player);
1498  00BF 0B D0  or dx, ax
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
                    goto L00E7;
                case 2:
                    goto L0147;
                case 3:
                    goto L0167;
                case 4:
                    goto L01C9;
            }
            L00D7: ShowMessage(player, String13A0); // You hear some footsteps running away.
            L00E4: goto L0288;
            L00E7: ShowMessage(player, String13C6); // You hear someone running towards you.
            L00F4: ShowPortrait(player, 0x0026);
            L0101: ShowMessage(player, String03DB); // *
            L010E: ShowMessage(player, String03DB); // *
            L011B: ShowMessage(player, String03DB); // *
            L0128: ShowMessage(player, String13EC); // A gargantuan gang of gremlins runs past you. One of them falls out and talks briefly.
            L0135: ShowMessage(player, String1442); // 'Hide me!  Protect me!  Save me!  A press gang snapped me up and I cannot take any more of this!'
151B  0142 B8 A4 14  mov ax, 0x14a4
            L0145: goto L00DA;
            L0147: ShowPortrait(player, 0x000E);
            L0154: ShowMessage(player, String151C); // The dragon examines you with a baleful eye.  It has seen better days.
153A  0161 B8 62 15  mov ax, 0x1562
            L0164: goto L00DA;
            L0167: RefreshCompareFlags(GetFlag(player, 0x02, 0x47));
            L017A: if (JumpNotEqual) goto L01C3;
            L017C: ShowPortrait(player, 0x0025);
            L0189: ShowMessage(player, String03DB); // *
            L0196: ShowMessage(player, String03DB); // *
            L01A3: ShowMessage(player, String03DB); // *
            L01B0: ShowMessage(player, String1645); // 'I think we have met before.  In sooth, did I not offer thee some dragonish drachmas?  Howsomever, now that I am equipped with Brunanburh's bow I find my relationships with dragons much improved.  I doubt that the wyrms would say the same, though.'
1596  01BD B8 3E 17  mov ax, 0x173e
            L01C0: goto L00DA;
159C  01C3 B8 60 17  mov ax, 0x1760
            L01C6: goto L00DA;
            L01C9: ShowPortrait(player, 0x0026);
            L01D6: ShowMessage(player, String03DB); // *
            L01E3: ShowMessage(player, String03DB); // *
            L01F0: ShowMessage(player, String03DB); // *
            L01FD: ShowMessage(player, String17B0); // A somewhat battered gang o'gremlins decides, rather insultingly, that they are bigger than you are.
            L020A: PushStack(player, 0x5D);
            L020E: PushStack(player, 0x00);
            L0211: PushStack(player, ax);
            L0212: PushStack(player, ax);
            L0213: PushStack(player, 0xB6);
            L0217: PushStack(player, 0xBD);
15F4  021B C4 5E 06  les bx, [bp+0x6]
15F7  021E 26 FF 9F D8 00  call far word [es:bx+0xd8]
15FC  0223 83 C4 0C  add sp, 0xc
            L0226: AddEncounter(player, 0x01, 0x19);
            L0238: Compare(PartyCount(player), 0x0001);
            L0243: if (JumpBelowOrEqual) goto L0257;
            L0245: AddEncounter(player, 0x05, 0x1A);
            L0257: Compare(PartyCount(player), 0x0002);
            L0262: if (JumpBelowOrEqual) goto L0288;
            L0264: AddEncounter(player, 0x02, 0x19);
            L0276: AddEncounter(player, 0x06, 0x1A);
            L0288: return; // RETURN (restoring si, di);
        }

        private void Fn_16(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x0C));
            L0016: if (JumpNotEqual) goto L006E;
            L0018: SetFlag(player, 0x03, 0x0C, 0x01);
            L002D: ShowPortrait(player, 0x0027);
            L003A: ShowMessage(player, String03DB); // *
            L0047: ShowMessage(player, String03DB); // *
            L0054: ShowMessage(player, String03DB); // *
            L0061: ShowMessage(player, String1814); // 'She said thou wouldst be coming, but we must take care.  The walls have ears.  That said, I can only suggest that thou shouldst seek thy doom in the other rooms on this level, and to be as constant as a clock.'  With a wink and a nod, the elf departs.
            L006E: return; // RETURN;
        }

        private void Fn_17(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpBelowOrEqual) goto L006B;
            L0010: SetWallPassable(player, GetCurrentTile(player), 0x01, 0x00);
            L0029: Compare(GetFacing(player), 0x0001);
            L0033: if (JumpEqual) goto L004A;
            L0035: RefreshCompareFlags(GetFlag(player, 0x03, 0x0E));
            L0048: if (JumpNotEqual) goto L0082;
            L004A: ShowMessage(player, String1911); // The narrow corridor to the south forces you to enter it single file.
            L0057: PushStack(player, 0x01);
            L005B: PushStack(player, 0x0E);
            L005F: PushStack(player, 0x03);
1742  0063 C4 5E 06  les bx, [bp+0x6]
1745  0066 26 FF 1F  call far word [es:bx]
            L0069: goto L007F;
            L006B: SetWallPassable(player, GetCurrentTile(player), ax, 0x01);
            L0082: return; // RETURN;
        }

        private void Fn_18(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, 0x0B), 0x0003);
            L0012: if (JumpAbove) goto L004A;
            L0014: PushStack(player, 0xA6);
            L0018: PushStack(player, ax);
177C  0019 C4 5E 06  les bx, [bp+0x6]
177F  001C 26 FF 5F 54  call far word [es:bx+0x54]
            L0020: cx = PopStack(player);
            L0021: cx = PopStack(player);
            L0022: RefreshCompareFlags(ax);
            L0024: if (JumpNotEqual) goto L004A;
            L0026: PushStack(player, 0x62);
            L002A: PushStack(player, ax);
178E  002B C4 5E 06  les bx, [bp+0x6]
1791  002E 26 FF 5F 54  call far word [es:bx+0x54]
            L0032: cx = PopStack(player);
            L0033: cx = PopStack(player);
            L0034: RefreshCompareFlags(ax);
            L0036: if (JumpNotEqual) goto L004A;
            L0038: PushStack(player, 0x8F);
            L003C: PushStack(player, ax);
17A0  003D C4 5E 06  les bx, [bp+0x6]
17A3  0040 26 FF 5F 54  call far word [es:bx+0x54]
            L0044: cx = PopStack(player);
            L0045: cx = PopStack(player);
            L0046: RefreshCompareFlags(ax);
            L0048: if (JumpEqual) goto L0061;
            L004A: PushStack(player, 0x01);
            L004E: PushStack(player, ax);
            L004F: PushStack(player, 0x03);
17B6  0053 C4 5E 06  les bx, [bp+0x6]
17B9  0056 26 FF 1F  call far word [es:bx]
17BC  0059 83 C4 06  add sp, 0x6
17BF  005C B8 56 19  mov ax, 0x1956
            L005F: goto L0086;
            L0061: Compare(HasUsedSkill(player, 0x0B), 0x0004);
            L0070: if (JumpNotBelow) goto L0090;
            L0072: Compare(HasUsedSkill(player, 0x0B), 0x0001);
            L0081: if (JumpBelow) goto L0090;
            L0083: ShowMessage(player, String02E7); // You find some marks, but you are not adequately skilled to correctly interpret them.
            L0090: return; // RETURN;
        }

        private void Fn_19(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetNoJoinArea(player);
            L000B: Compare(PartyCount(player), 0x0001);
            L0016: if (JumpBelowOrEqual) goto L0036;
            L0018: ShowMessage(player, String035D); // You try squeezing down this narrow corridor, but it's so tight that - aargh!  You've been impaled on your companion's weapon!
            L0025: DamagePlayer(player, GetMaxHits(player));
            L0036: return; // RETURN;
        }

        private void Fn_1A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFlag(player, 0x02, 0x15, 0x01);
            L0018: return; // RETURN;
        }

        private void Fn_1B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: RefreshCompareFlags(GetFlag(player, 0x03, 0x0F));
            L0017: if (JumpEqual) goto L001C;
            L0019: goto L00B6;
            L001C: si = GetFlag(player, 0x02, 0x58);
            L002F: si = si + 1;
            L0030: SetFlag(player, 0x03, 0x0F, 0x01);
            L0045: ShowMessage(player, String1998); // This appears to be what's left of a large picture gallery.  Many holes in the wall and piles of marble dust provide mute testimony to its ransacking.
            L0052: Compare(si, 0x0A);
            L0055: if (JumpLessOrEqual) goto L005B;
            L0057: si = 0;
            L0059: goto L00A4;
            L005B: bx = si;
            L005D: bx = bx - 1;
            L005E: Compare(bx, 0x09);
            L0061: if (JumpAbove) goto L00A4;
            L0063: switch (bx) {
                case 0:
                    goto L006A;
                case 1:
                    goto L006F;
                case 2:
                    goto L0074;
                case 3:
                    goto L0079;
                case 4:
                    goto L007E;
                case 5:
                    goto L0083;
                case 6:
                    goto L0088;
                case 7:
                    goto L008D;
                case 8:
                    goto L0092;
                case 9:
                    goto L0097;
            }
18B1  006A B8 2E 1A  mov ax, 0x1a2e
            L006D: goto L009A;
18B6  006F B8 57 1A  mov ax, 0x1a57
            L0072: goto L009A;
18BB  0074 B8 B0 1A  mov ax, 0x1ab0
            L0077: goto L009A;
18C0  0079 B8 04 1B  mov ax, 0x1b04
            L007C: goto L009A;
18C5  007E B8 69 1B  mov ax, 0x1b69
            L0081: goto L009A;
18CA  0083 B8 D5 1B  mov ax, 0x1bd5
            L0086: goto L009A;
18CF  0088 B8 2D 1C  mov ax, 0x1c2d
            L008B: goto L009A;
18D4  008D B8 89 1C  mov ax, 0x1c89
            L0090: goto L009A;
18D9  0092 B8 07 1D  mov ax, 0x1d07
            L0095: goto L009A;
            L0097: ShowMessage(player, String1D5A); // You find a post-it reminding someone to change the notation from mostly harmless to quite dangerous, actually.
            L00A4: SetFlag(player, 0xC4, 0xB8, si);
            L00B6: return; // RETURN (restoring si);
        }

        private void Fn_1C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x10), 0x0001);
            L0017: if (JumpEqual) goto L003E;
            L0019: PushStack(player, 0x03);
            L001D: PushStack(player, 0x00);
1934  0020 C4 5E 06  les bx, [bp+0x6]
1937  0023 26 FF 5F 04  call far word [es:bx+0x4]
            L0027: cx = PopStack(player);
            L0028: cx = PopStack(player);
            L0029: Compare(ax, 0x0001);
            L002C: if (JumpEqual) goto L003E;
            L002E: ax = HasItem(player, 0xFD);
            L003C: if (JumpEqual) goto L0068;
            L003E: ShowMessage(player, String1DC9); // You see Fleance peering in at you, and charge!
            L004B: TeleportParty(player, 0x04, 0x01, 0x04, 0x03, isForwardMove);
            L0066: goto L0086;
            L0068: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0086: return; // RETURN;
        }

        private void Fn_1D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x10), 0x0001);
            L0017: if (JumpEqual) goto L002E;
            L0019: PushStack(player, 0x04);
            L001D: PushStack(player, 0x00);
19BC  0020 C4 5E 06  les bx, [bp+0x6]
19BF  0023 26 FF 5F 04  call far word [es:bx+0x4]
            L0027: cx = PopStack(player);
            L0028: cx = PopStack(player);
            L0029: Compare(ax, 0x0001);
            L002C: if (JumpNotEqual) goto L0058;
            L002E: ShowMessage(player, String1DC9); // You see Fleance peering in at you, and charge!
            L003B: TeleportParty(player, 0x04, 0x01, 0x05, 0x03, isForwardMove);
            L0056: goto L00D3;
            L0058: Compare(GetFlag(player, 0x03, 0x01), 0x0001);
            L006C: if (JumpNotEqual) goto L00B5;
            L006E: SetFlag(player, 0x03, 0x10, 0x01);
            L0083: ax = CheckLevel(player, 0x0014);
            L0091: if (JumpNotEqual) goto L00B3;
            L0093: ShowMessage(player, String1DF8); // You feel like you are being watched.
            L00A0: PushStack(player, 0x01);
            L00A4: PushStack(player, 0x04);
            L00A8: PushStack(player, 0x00);
1A47  00AB C4 5E 06  les bx, [bp+0x6]
1A4A  00AE 26 FF 1F  call far word [es:bx]
            L00B1: goto L00D0;
            L00B3: goto L00B5;
            L00B5: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L00D3: return; // RETURN;
        }

        private void Fn_1E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x10), 0x0001);
            L0017: if (JumpEqual) goto L0044;
            L0019: PushStack(player, 0x05);
            L001D: PushStack(player, 0x00);
1A91  0020 C4 5E 06  les bx, [bp+0x6]
1A94  0023 26 FF 5F 04  call far word [es:bx+0x4]
            L0027: cx = PopStack(player);
            L0028: cx = PopStack(player);
            L0029: Compare(ax, 0x0001);
            L002C: if (JumpEqual) goto L0044;
            L002E: Compare(GetFlag(player, 0x02, 0x14), 0x0001);
            L0042: if (JumpNotEqual) goto L006E;
            L0044: ShowMessage(player, String1E1D); // Heck with bobbing and weaving.  You see Fleance peering in at you, and charge!
            L0051: TeleportParty(player, 0x04, 0x01, 0x05, 0x03, isForwardMove);
            L006C: goto L00D7;
            L006E: Compare(GetFlag(player, 0x03, 0x01), 0x0001);
            L0082: if (JumpNotEqual) goto L00B9;
            L0084: ShowMessage(player, String1E6C); // You bob and weave cautiously forward.
            L0091: SetFlag(player, 0x00, 0x05, 0x01);
            L00A5: PushStack(player, 0x01);
            L00A9: PushStack(player, 0x10);
            L00AD: PushStack(player, 0x03);
1B22  00B1 C4 5E 06  les bx, [bp+0x6]
1B25  00B4 26 FF 1F  call far word [es:bx]
            L00B7: goto L00D4;
            L00B9: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L00D7: return; // RETURN;
        }

        private void Fn_1F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x10), 0x0001);
            L0017: if (JumpEqual) goto L0044;
            L0019: PushStack(player, 0x06);
            L001D: PushStack(player, 0x00);
1B6A  0020 C4 5E 06  les bx, [bp+0x6]
1B6D  0023 26 FF 5F 04  call far word [es:bx+0x4]
            L0027: cx = PopStack(player);
            L0028: cx = PopStack(player);
            L0029: Compare(ax, 0x0001);
            L002C: if (JumpEqual) goto L0044;
            L002E: Compare(GetFlag(player, 0x02, 0x14), 0x0001);
            L0042: if (JumpNotEqual) goto L006F;
            L0044: ShowMessage(player, String1E92); // You see Fleance's Ghost up ahead of you, and charge!
            L0051: TeleportParty(player, 0x04, 0x01, 0x06, 0x03, isForwardMove);
            L006C: goto L00FE;
            L006F: Compare(GetFlag(player, 0x03, 0x01), 0x0001);
            L0083: if (JumpNotEqual) goto L00BD;
            L0085: ShowMessage(player, String1EC7); // Wait for it.
            L0092: SetFlag(player, 0x00, 0x06, 0x01);
            L00A6: SetFlag(player, 0x03, 0x10, 0x01);
            L00BB: goto L00FE;
            L00BD: ShowMessage(player, String1ED4); // You find something inscribed in blood above what appears to be a finger bone in the wall to the north.
            L00CA: ShowMessage(player, String1F3B); // It reads, 'I sought Fleance'
            L00D7: ShowMessage(player, String1F58); // 'But now I die'
            L00E4: ShowMessage(player, String1F68); // 'Caught by ill chance'
            L00F1: ShowMessage(player, String1F7F); // 'With no Hawk's Eye.'
            L00FE: return; // RETURN;
        }

        private void Fn_20(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x03);
            L0007: PushStack(player, ax);
1C52  0008 C4 5E 06  les bx, [bp+0x6]
1C55  000B 26 FF 5F 04  call far word [es:bx+0x4]
            L000F: cx = PopStack(player);
            L0010: cx = PopStack(player);
            L0011: RefreshCompareFlags(ax);
            L0013: if (JumpEqual) goto L0018;
            L0015: goto L00DB;
            L0018: ShowMessage(player, String1F95); // You knew this was coming.
            L0025: PushStack(player, 0x01);
            L0029: PushStack(player, 0x03);
            L002D: PushStack(player, ax);
1C78  002E C4 5E 06  les bx, [bp+0x6]
1C7B  0031 26 FF 1F  call far word [es:bx]
1C7E  0034 83 C4 06  add sp, 0x6
1C81  0037 B8 C4 07  mov ax, 0x7c4
            L003A: PushStack(player, ax);
            L003B: PushStack(player, 0x00);
            L003E: PushStack(player, ax);
            L003F: PushStack(player, ax);
            L0040: PushStack(player, 0xCC);
            L0044: PushStack(player, 0xB9);
1C92  0048 C4 5E 06  les bx, [bp+0x6]
1C95  004B 26 FF 9F D8 00  call far word [es:bx+0xd8]
1C9A  0050 83 C4 0C  add sp, 0xc
            L0053: AddEncounter(player, 0x01, 0x26);
            L0065: AddEncounter(player, 0x02, 0x25);
            L0077: Compare(PartyCount(player), 0x0002);
            L0082: if (JumpBelowOrEqual) goto L00FD;
            L0084: AddEncounter(player, 0x03, 0x24);
            L0096: AddEncounter(player, 0x04, 0x23);
            L00A8: Compare(PartyCount(player), 0x0003);
            L00B3: if (JumpBelowOrEqual) goto L00FD;
            L00B5: AddEncounter(player, 0x05, 0x1F);
            L00C7: AddEncounter(player, 0x06, 0x1F);
            L00D9: goto L00FD;
            L00DB: SetFlag(player, 0x02, 0x26, 0x01);
            L00F0: ShowMessage(player, String1FAF); // It appears that your moves were fancier than Fleance's.
            L00FD: return; // RETURN;
        }

        private void Fn_21(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x03);
            L0007: PushStack(player, ax);
1D51  0008 C4 5E 06  les bx, [bp+0x6]
1D54  000B 26 FF 5F 04  call far word [es:bx+0x4]
            L000F: cx = PopStack(player);
            L0010: cx = PopStack(player);
            L0011: RefreshCompareFlags(ax);
            L0013: if (JumpEqual) goto L0018;
            L0015: goto L00DB;
            L0018: ShowMessage(player, String1F95); // You knew this was coming.
            L0025: PushStack(player, 0x01);
            L0029: PushStack(player, 0x03);
            L002D: PushStack(player, ax);
1D77  002E C4 5E 06  les bx, [bp+0x6]
1D7A  0031 26 FF 1F  call far word [es:bx]
1D7D  0034 83 C4 06  add sp, 0x6
1D80  0037 B8 C4 07  mov ax, 0x7c4
            L003A: PushStack(player, ax);
            L003B: PushStack(player, 0x00);
            L003E: PushStack(player, ax);
            L003F: PushStack(player, ax);
            L0040: PushStack(player, 0xCC);
            L0044: PushStack(player, 0xB9);
1D91  0048 C4 5E 06  les bx, [bp+0x6]
1D94  004B 26 FF 9F D8 00  call far word [es:bx+0xd8]
1D99  0050 83 C4 0C  add sp, 0xc
            L0053: AddEncounter(player, 0x01, 0x27);
            L0065: AddEncounter(player, 0x02, 0x25);
            L0077: AddEncounter(player, 0x03, 0x24);
            L0089: Compare(PartyCount(player), 0x0002);
            L0094: if (JumpBelowOrEqual) goto L00FD;
            L0096: AddEncounter(player, 0x04, 0x23);
            L00A8: AddEncounter(player, 0x05, 0x1F);
            L00BA: Compare(PartyCount(player), 0x0003);
            L00C5: if (JumpBelowOrEqual) goto L00FD;
            L00C7: AddEncounter(player, 0x06, 0x1F);
            L00D9: goto L00FD;
            L00DB: SetFlag(player, 0x02, 0x26, 0x01);
            L00F0: ShowMessage(player, String1FAF); // It appears that your moves were fancier than Fleance's.
            L00FD: return; // RETURN;
        }

        private void Fn_22(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x03);
            L0007: PushStack(player, ax);
1E50  0008 C4 5E 06  les bx, [bp+0x6]
1E53  000B 26 FF 5F 04  call far word [es:bx+0x4]
            L000F: cx = PopStack(player);
            L0010: cx = PopStack(player);
            L0011: RefreshCompareFlags(ax);
            L0013: if (JumpEqual) goto L0018;
            L0015: goto L00CE;
            L0018: ShowMessage(player, String1F95); // You knew this was coming.
            L0025: PushStack(player, 0x01);
            L0029: PushStack(player, 0x03);
            L002D: PushStack(player, ax);
1E76  002E C4 5E 06  les bx, [bp+0x6]
1E79  0031 26 FF 1F  call far word [es:bx]
1E7C  0034 83 C4 06  add sp, 0x6
1E7F  0037 B8 C4 07  mov ax, 0x7c4
            L003A: PushStack(player, ax);
            L003B: PushStack(player, 0x00);
            L003E: PushStack(player, ax);
            L003F: PushStack(player, ax);
            L0040: PushStack(player, 0xCC);
            L0044: PushStack(player, 0xB9);
1E90  0048 C4 5E 06  les bx, [bp+0x6]
1E93  004B 26 FF 9F D8 00  call far word [es:bx+0xd8]
1E98  0050 83 C4 0C  add sp, 0xc
            L0053: AddEncounter(player, 0x01, 0x28);
            L0065: AddEncounter(player, 0x02, 0x25);
            L0077: AddEncounter(player, 0x03, 0x24);
            L0089: AddEncounter(player, 0x04, 0x23);
            L009B: Compare(PartyCount(player), 0x0002);
            L00A6: if (JumpBelowOrEqual) goto L00F0;
            L00A8: AddEncounter(player, 0x05, 0x1F);
            L00BA: AddEncounter(player, 0x06, 0x1F);
            L00CC: goto L00F0;
            L00CE: SetFlag(player, 0x02, 0x26, 0x01);
            L00E3: ShowMessage(player, String1FAF); // It appears that your moves were fancier than Fleance's.
            L00F0: return; // RETURN;
        }

        private void Fn_23(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x01);
            L0007: PushStack(player, 0x03);
            L000B: PushStack(player, ax);
1F46  000C C4 5E 06  les bx, [bp+0x6]
1F49  000F 26 FF 1F  call far word [es:bx]
1F4C  0012 83 C4 06  add sp, 0x6
            L0015: return; // RETURN;
        }

        private void Fn_24(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x11));
            L0016: if (JumpNotEqual) goto L006B;
            L0018: GiveItem(player, 0xEB);
            L0024: GiveItem(player, 0xB9);
            L0030: GiveItem(player, 0xCC);
            L003C: SetFlag(player, 0x02, 0x26, 0x01);
            L0051: SetFlag(player, 0x03, 0x11, 0x01);
1FB7  0066 B8 E7 1F  mov ax, 0x1fe7
            L0069: goto L006E;
            L006B: ShowMessage(player, String2016); // This part of Fleance's lair is empty.  Almost too empty.  Well, okay, you're here, so it's not too empty.
            L0078: return; // RETURN;
        }

    }
}
