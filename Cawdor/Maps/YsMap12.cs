#pragma warning disable
using System.Collections.Generic;
using XPT.WorldData;
using XPT.WorldData.Yserbius;

namespace XPT.Scripts.Yserbius.Maps {
    class YserMap12 : AMapScripted {
        protected override int MapIndex => 12;
        protected override int RandomEncounterChance => 10;
        protected override int RandomEncounterExtraCount => 0;

        public YserMap12() {
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
        private const string String0140 = "It sure is drafty in here.";
        private const string String015B = "You've uncovered a hidden door!";
        private const string String017B = "You have unlocked the hidden door!";
        private const string String019E = "You detect a hidden door, but it is locked.";
        private const string String01CA = "You've picked the lock. Proceed.";
        private const string String01EB = "Funny how an irksome little lock on a flimsy little door can keep out a big strong person like you.";
        private const string String024F = "You are watching out for ambushes.";
        private const string String0272 = "AMBUSH!  Something ghostly and ghastly cast a fireball at you and then retreated!";
        private const string String02C4 = "We did damage - did we get Ambush msg?";
        private const string String02EB = "Some faint tracks lure you onward.";
        private const string String030E = "This way to The Gallery.";
        private const string String0327 = "You try squeezing down this narrow corridor, but it's so tight that - aargh!  You've been impaled on your companion's weapon!";
        private const string String03A5 = "Galatea greets you. 'Thou hast matched my hopes and exceeded my expectations, and earned thereby many rewards.  I shall begin by granting thee abilities and experience.'";
        private const string String044F = "'As thy foes grow ever more canny and cunning, thou shouldst know how to minimize the damage from their spells.'  You now know how to deflect magic!";
        private const string String04E4 = "'Child of nature, thou wilt find it easy to learn and to use a skill of natural healing, of binding thy own wounds or those of thy companions.Behold!'  You know the binding skill!";
        private const string String0598 = "'As thou dost learn more puissant and costly spells, so shouldst thou also know better how to replenish the mana on which thou dost draw to cast them.  Behold!'  You now know how to enter a deep trance!";
        private const string String0663 = "'As thou must face ever greater evils, thou shouldst know better how to use thy body, both to cause damage and to avoid damage.  Behold!'  You now know the athletics skill!";
        private const string String0710 = "'I must speak plain, for thou hast avoided the meaning I tried to impart thee before.";
        private const string String0766 = "There is a fountain in the Foyer.  An thou dost enter it thrice, then thou shalt be granted the skill of reading runes.  That skill will prove most educational an thou dost ply it in The Runed Room.'";
        private const string String082E = "'I am most pleased that thou didst learn the secret of the Runed Fountain.";
        private const string String0879 = "For the skill thou hast shown at deciphering my riddles I do grant thee an extra portion of experience I withhold from thy less persistent comrades.  But I refer thee to study of The Runed Room.'";
        private const string String093D = "'Thou hast been truly diligent in thy pursuit of knowledge and the study of runes.  I am most pleased with thee, and do grant thee a reward commensurate with my pleasure.'";
        private const string String09E9 = "'On this level is The Library.  Not all the wisdom in The Library is obvious, either to find or to decipher.  But there is much to learn about the hidden powers of certain objects, an thou dost invest the effort.";
        private const string String0ABE = "Also hereon is Malcolm's Ghost, who will not be as easily cowed as was Fleance.'";
        private const string String0B0F = "'To survive and thrive on these more difficult levels, thou shouldst know ever mightier spells.  I hereby grant thee the spell known, simply, as Blast.'";
        private const string String0BA8 = "Galatea gets a distant look in her eyes.  'I dare no longer stay.  Good fortune!'  She disappears.";
        private const string String0C0B = "It looks like someone is investigating yourmeeting with Galatea here earlier!";
        private const string String0C59 = "This narrow corridor forces you to proceed single file.";
        private const string String0C91 = "There are stairs leading up at the end of this hallway.";
        private const string String0CC9 = "'It is not safe to assay the higher levels while leaving Malcolm's ghost behind thee,' Galatea whispers.";
        private const string String0D32 = "Two elves, a barbarian and a ranger by their appearance, courteously hold open a secret door for you.  'Watch out for the boars in here,' they warn you.  'Some of the most deadly go on two legs.'";
        private const string String0DF6 = "The door to the Library refuses to budge.";
        private const string String0E20 = "It is eerily quiet here.";
        private const string String0E39 = "A gremlin wizard and a gremlin cleric courteously hold open a very thick door for you.  'Allow us,' they say.  'There are so many undead in here it is a pleasure to let in fresh clerics.'";
        private const string String0EF5 = "Struggle though you will, you are unable to open the door that leads to the Music Room.";
        private const string String0F4D = "'Good gentles, could you please give a lost soul some directions?  My mission is rather confused.  I must go to Elsinore Castle for an omelet and danish, or something like that.  Do you know where that is?'";
        private const string String101C = "You shake your head.";
        private const string String1031 = "'Ah, well, that's afterlife, as they say.  No rest for the Yorick.  Be seeing you....'  The skeleton departs.";
        private const string String109F = "A horde of harpies were waiting for you!";
        private const string String10C8 = "Along with some impertinent imps.";
        private const string String10EA = "'Huzzah!  Thou hast completely, if temporarily, rid this room of agents of my sisters, and I have drawn the duty to investigate!";
        private const string String116B = "I can now give thee this ring.  An thou dost use it while in water, then thou canst summon Mannanan Mac Lir, who will give thee aid of another sort.'";
        private const string String1201 = "'I have healed thee and granted thee another reward of experience, but our time together grows short.  I must urge thee to leave this area now.' She disappears.";
        private const string String12A2 = "All that remains from your battle here is a smelly old tailfeather.";
        private const string String12E6 = "They say that the bigger they are, the harder they fall.  The problem is, they just might fall on you.";
        private const string String134D = "In fact, even near you might be close enough!";
        private const string String137B = "All that remains from your battle here is the third largest splinter you've ever seen.";
        private const string String13D2 = "You would call them male chauvinist pigs, but half of them seem to be sows.";
        private const string String141E = "And the larger half at that!";
        private const string String143B = "All that remains from your battle here is an empty bag of pork rinds.";
        private const string String1481 = "It looks like dragons all the way down!";
        private const string String14A9 = "You remember almost becoming wyrm food here.";
        private const string String14D6 = "You liked it better on the lower levels when all the dragons did was steal from you.";
        private const string String152B = "Some adventurers are friendly.  These aren't.";
        private const string String1559 = "You sure taught those guys a lesson!";
        private const string String157E = "How could they have ambushed you here?";
        private const string String15A5 = "Oh, they have halflings.  Halflings could ambush the devil before he knew they were dead.";
        private const string String15FF = "And the gnomes aren't slouches, either.";
        private const string String1627 = "Your bones still ache from the battle you fought here.";
        private const string String165E = "You hear some footsteps running away.";
        private const string String1684 = "You hear someone running towards you.";
        private const string String16AA = "*";
        private const string String16AC = "'Have you seen my crumhorn?  I know I left it here somewhere.  If I find it not, then I cannot play for Her Ladyship!  Fie!  Thou art no use to me!'  The gremlin rushes off.";
        private const string String175A = "'I seek Hamlet, the Dane.  Lost, am I, and bound by an idle curse to this blasted heath.  If thou dost find the Prince of Denmark, give him his father's warning, that his uncle, now the king, means him no good.'";
        private const string String182E = "It was Rory who told you about Manannan's summoning, but Manannan himself cannot bring Rory back to life.";
        private const string String1898 = "'A marvelous day, friends, 'tis it not?  I have learned two pieces of news that I will share with thee.";
        private const string String1900 = "The first is that Manannan Mac Lir can be summoned with an item thou canst obtain in this very Ballroom.  The second is that thou must be bloody, bold, and resolute to so obtain it.  Good fortune!'";
        private const string String19C6 = "The halfling struts off, smiling.";
        private const string String19E8 = "A pummelled posse of imps decides, rather insultingly, that they are bigger than you are.";
        private const string String1A42 = "'Galatea forgot to mention that you will need Ohthere's Dagger to survive the waters flowing fromManannan's holy fountain.  You must seek that amulet amongst Ohthere's maps.'";
        private const string String1AF1 = "The elf departs.";
        private const string String1B02 = "'Galatea sends her best wishes, and commends to thee the wisdom of fighting the seven battles of power in the Ballroom.  An thou dost conclude all seven, and return to the site of any, she will be able to come to you with more aid than hitherto.'";
        private const string String1BF9 = "The narrow corridor to the south forces you to enter it single file.";
        private const string String1C3E = "The door to the west reads: 'Donalbain's Chamber.'";
        private const string String1C71 = "The door to the west reads: 'Malcolm's Chamber.'";
        private const string String1CA2 = "The door to the west reads: 'Duncan's Chamber.'";
        private const string String1CD2 = "The door to the north reads: 'Lenox's Chamber.'";
        private const string String1D02 = "The door to the north reads: 'Macbeth's Box.'";
        private const string String1D30 = "The door to the north reads: 'Private.'";
        private const string String1D58 = "The door to the east reads: 'Banquo's Box.'";
        private const string String1D84 = "The door to the east reads: 'Macduff's Chamber.'";
        private const string String1DB5 = "The door to the east reads: 'Rosse's Room.'";
        private const string String1DE1 = "The door to the east reads: 'Menteth's Chamber.'";
        private const string String1E12 = "The door to the west reads: 'Angus's Area.'";
        private const string String1E3E = "The door to the south reads: 'Cathness's Chamber.'";
        private const string String1E71 = "The door to the south reads: 'Angus's Area.'";
        private const string String1E9E = "The door to the south reads: 'Powder Room.'";
        
        // === Functions ================================================
        private void Fn_01(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0140); // It sure is drafty in here.
            L0010: Compare(HasUsedSkill(player, 0x0D), 0x0006);
            L001F: if (JumpNotBelow) goto L008B;
            L0021: RefreshCompareFlags(HasUsedSpell(player, 0x17));
            L002F: if (JumpNotEqual) goto L008B;
            L0031: PushStack(player, 0xA7);
            L0035: PushStack(player, ax);
0040  0036 C4 5E 06  les bx, [bp+0x6]
0043  0039 26 FF 5F 54  call far word [es:bx+0x54]
            L003D: cx = PopStack(player);
            L003E: cx = PopStack(player);
            L003F: RefreshCompareFlags(ax);
            L0041: if (JumpNotEqual) goto L008B;
            L0043: PushStack(player, 0x67);
            L0047: PushStack(player, ax);
0052  0048 C4 5E 06  les bx, [bp+0x6]
0055  004B 26 FF 5F 54  call far word [es:bx+0x54]
            L004F: cx = PopStack(player);
            L0050: cx = PopStack(player);
            L0051: RefreshCompareFlags(ax);
            L0053: if (JumpNotEqual) goto L008B;
            L0055: PushStack(player, 0x61);
            L0059: PushStack(player, ax);
0064  005A C4 5E 06  les bx, [bp+0x6]
0067  005D 26 FF 5F 54  call far word [es:bx+0x54]
            L0061: cx = PopStack(player);
            L0062: cx = PopStack(player);
            L0063: RefreshCompareFlags(ax);
            L0065: if (JumpNotEqual) goto L008B;
            L0067: PushStack(player, 0x93);
            L006B: PushStack(player, ax);
0076  006C C4 5E 06  les bx, [bp+0x6]
0079  006F 26 FF 5F 54  call far word [es:bx+0x54]
            L0073: cx = PopStack(player);
            L0074: cx = PopStack(player);
            L0075: RefreshCompareFlags(ax);
            L0077: if (JumpNotEqual) goto L008B;
            L0079: PushStack(player, 0x86);
            L007D: PushStack(player, ax);
0088  007E C4 5E 06  les bx, [bp+0x6]
008B  0081 26 FF 5F 54  call far word [es:bx+0x54]
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
            L0003: Compare(HasUsedSkill(player, 0x0D), 0x0006);
            L0012: if (JumpBelow) goto L0017;
            L0014: goto L0098;
            L0017: RefreshCompareFlags(HasUsedSpell(player, 0x17));
            L0025: if (JumpNotEqual) goto L0098;
            L0027: PushStack(player, 0xA7);
            L002B: PushStack(player, ax);
0148  002C C4 5E 06  les bx, [bp+0x6]
014B  002F 26 FF 5F 54  call far word [es:bx+0x54]
            L0033: cx = PopStack(player);
            L0034: cx = PopStack(player);
            L0035: RefreshCompareFlags(ax);
            L0037: if (JumpNotEqual) goto L0098;
            L0039: PushStack(player, 0x67);
            L003D: PushStack(player, ax);
015A  003E C4 5E 06  les bx, [bp+0x6]
015D  0041 26 FF 5F 54  call far word [es:bx+0x54]
            L0045: cx = PopStack(player);
            L0046: cx = PopStack(player);
            L0047: RefreshCompareFlags(ax);
            L0049: if (JumpNotEqual) goto L0098;
            L004B: PushStack(player, 0x61);
            L004F: PushStack(player, ax);
016C  0050 C4 5E 06  les bx, [bp+0x6]
016F  0053 26 FF 5F 54  call far word [es:bx+0x54]
            L0057: cx = PopStack(player);
            L0058: cx = PopStack(player);
            L0059: RefreshCompareFlags(ax);
            L005B: if (JumpNotEqual) goto L0098;
            L005D: PushStack(player, 0x93);
            L0061: PushStack(player, ax);
017E  0062 C4 5E 06  les bx, [bp+0x6]
0181  0065 26 FF 5F 54  call far word [es:bx+0x54]
            L0069: cx = PopStack(player);
            L006A: cx = PopStack(player);
            L006B: RefreshCompareFlags(ax);
            L006D: if (JumpNotEqual) goto L0098;
            L006F: PushStack(player, 0x86);
            L0073: PushStack(player, ax);
0190  0074 C4 5E 06  les bx, [bp+0x6]
0193  0077 26 FF 5F 54  call far word [es:bx+0x54]
            L007B: cx = PopStack(player);
            L007C: cx = PopStack(player);
            L007D: RefreshCompareFlags(ax);
            L007F: if (JumpNotEqual) goto L0098;
            L0081: ax = IsFlagOn(player, 0x00, 0x01);
            L0093: if (JumpNotEqual) goto L0098;
            L0095: goto L01CD;
            L0098: SetWallObject(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L00B6: PushStack(player, 0x01);
            L00BA: PushStack(player, ax);
            L00BB: PushStack(player, 0x00);
01DA  00BE C4 5E 06  les bx, [bp+0x6]
01DD  00C1 26 FF 1F  call far word [es:bx]
01E0  00C4 83 C4 06  add sp, 0x6
            L00C7: PushStack(player, 0x68);
            L00CB: PushStack(player, ax);
01E8  00CC C4 5E 06  les bx, [bp+0x6]
01EB  00CF 26 FF 5F 54  call far word [es:bx+0x54]
            L00D3: cx = PopStack(player);
            L00D4: cx = PopStack(player);
            L00D5: RefreshCompareFlags(ax);
            L00D7: if (JumpEqual) goto L012C;
            L00D9: ax = HasItem(player, 0xC3);
            L00E7: if (JumpEqual) goto L00EC;
            L00E9: goto L0176;
            L00EC: ax = HasItem(player, 0xDA);
            L00FA: if (JumpNotEqual) goto L0176;
            L00FC: ax = HasItem(player, 0xDB);
            L010A: if (JumpNotEqual) goto L0176;
            L010C: ax = HasItem(player, 0xDC);
            L011A: if (JumpNotEqual) goto L0176;
            L011C: ax = HasItem(player, 0xDD);
            L012A: if (JumpNotEqual) goto L0176;
            L012C: Compare(GetSkillLevel(player, 0x0E), 0x0006);
            L013B: if (JumpBelow) goto L0164;
            L013D: PushStack(player, 0xC3);
            L0141: PushStack(player, ax);
025E  0142 C4 5E 06  les bx, [bp+0x6]
0261  0145 26 FF 5F 54  call far word [es:bx+0x54]
            L0149: cx = PopStack(player);
            L014A: cx = PopStack(player);
            L014B: RefreshCompareFlags(ax);
            L014D: if (JumpNotEqual) goto L0176;
            L014F: ax = HasUsedItem(player, 0xDA, 0xDD);
            L0162: if (JumpNotEqual) goto L0176;
            L0164: PushStack(player, 0xC0);
            L0168: PushStack(player, ax);
0285  0169 C4 5E 06  les bx, [bp+0x6]
0288  016C 26 FF 5F 54  call far word [es:bx+0x54]
            L0170: cx = PopStack(player);
            L0171: cx = PopStack(player);
            L0172: RefreshCompareFlags(ax);
            L0174: if (JumpEqual) goto L01BE;
            L0176: ShowMessage(player, String017B); // You have unlocked the hidden door!
            L0183: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L01A1: PushStack(player, GetFacing(player));
            L01A9: PushStack(player, GetCurrentTile(player));
            L01B1: PushStack(player, 0x01);
02D1  01B5 C4 5E 06  les bx, [bp+0x6]
02D4  01B8 26 FF 5F 30  call far word [es:bx+0x30]
            L01BC: goto L01E7;
            L01BE: ShowMessage(player, String019E); // You detect a hidden door, but it is locked.
            L01CB: goto L01CD;
            L01CD: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L01EA: return; // RETURN;
        }

        private void Fn_03(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x68);
            L0007: PushStack(player, ax);
0310  0008 C4 5E 06  les bx, [bp+0x6]
0313  000B 26 FF 5F 54  call far word [es:bx+0x54]
            L000F: cx = PopStack(player);
            L0010: cx = PopStack(player);
            L0011: RefreshCompareFlags(ax);
            L0013: if (JumpEqual) goto L0068;
            L0015: ax = HasItem(player, 0xC3);
            L0023: if (JumpEqual) goto L0028;
            L0025: goto L00B2;
            L0028: ax = HasItem(player, 0xDA);
            L0036: if (JumpNotEqual) goto L00B2;
            L0038: ax = HasItem(player, 0xDB);
            L0046: if (JumpNotEqual) goto L00B2;
            L0048: ax = HasItem(player, 0xDC);
            L0056: if (JumpNotEqual) goto L00B2;
            L0058: ax = HasItem(player, 0xDD);
            L0066: if (JumpNotEqual) goto L00B2;
            L0068: Compare(GetSkillLevel(player, 0x0E), 0x0006);
            L0077: if (JumpBelow) goto L00A0;
            L0079: PushStack(player, 0xC3);
            L007D: PushStack(player, ax);
0386  007E C4 5E 06  les bx, [bp+0x6]
0389  0081 26 FF 5F 54  call far word [es:bx+0x54]
            L0085: cx = PopStack(player);
            L0086: cx = PopStack(player);
            L0087: RefreshCompareFlags(ax);
            L0089: if (JumpNotEqual) goto L00B2;
            L008B: ax = HasUsedItem(player, 0xDA, 0xDD);
            L009E: if (JumpNotEqual) goto L00B2;
            L00A0: PushStack(player, 0xC0);
            L00A4: PushStack(player, ax);
03AD  00A5 C4 5E 06  les bx, [bp+0x6]
03B0  00A8 26 FF 5F 54  call far word [es:bx+0x54]
            L00AC: cx = PopStack(player);
            L00AD: cx = PopStack(player);
            L00AE: RefreshCompareFlags(ax);
            L00B0: if (JumpEqual) goto L00DF;
            L00B2: ShowMessage(player, String01CA); // You've picked the lock. Proceed.
            L00BF: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L00DD: goto L0109;
            L00DF: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L00FC: ShowMessage(player, String01EB); // Funny how an irksome little lock on a flimsy little door can keep out a big strong person like you.
            L0109: return; // RETURN;
        }

        private void Fn_04(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x01));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00ED;
            L001B: PushStack(player, 0x02);
            L001F: PushStack(player, 0x00);
0435  0022 C4 5E 06  les bx, [bp+0x6]
0438  0025 26 FF 5F 04  call far word [es:bx+0x4]
            L0029: cx = PopStack(player);
            L002A: cx = PopStack(player);
            L002B: RefreshCompareFlags(ax);
            L002D: if (JumpEqual) goto L0032;
            L002F: goto L00ED;
            L0032: Compare(HasUsedSkill(player, 0x0B), 0x0003);
            L0041: if (JumpAbove) goto L0079;
            L0043: PushStack(player, 0xA6);
            L0047: PushStack(player, ax);
045B  0048 C4 5E 06  les bx, [bp+0x6]
045E  004B 26 FF 5F 54  call far word [es:bx+0x54]
            L004F: cx = PopStack(player);
            L0050: cx = PopStack(player);
            L0051: RefreshCompareFlags(ax);
            L0053: if (JumpNotEqual) goto L0079;
            L0055: PushStack(player, 0x62);
            L0059: PushStack(player, ax);
046D  005A C4 5E 06  les bx, [bp+0x6]
0470  005D 26 FF 5F 54  call far word [es:bx+0x54]
            L0061: cx = PopStack(player);
            L0062: cx = PopStack(player);
            L0063: RefreshCompareFlags(ax);
            L0065: if (JumpNotEqual) goto L0079;
            L0067: PushStack(player, 0x8F);
            L006B: PushStack(player, ax);
047F  006C C4 5E 06  les bx, [bp+0x6]
0482  006F 26 FF 5F 54  call far word [es:bx+0x54]
            L0073: cx = PopStack(player);
            L0074: cx = PopStack(player);
            L0075: RefreshCompareFlags(ax);
            L0077: if (JumpEqual) goto L00A5;
            L0079: ShowMessage(player, String024F); // You are watching out for ambushes.
            L0086: PushStack(player, 0x01);
            L008A: PushStack(player, ax);
            L008B: PushStack(player, 0x03);
04A2  008F C4 5E 06  les bx, [bp+0x6]
04A5  0092 26 FF 1F  call far word [es:bx]
04A8  0095 83 C4 06  add sp, 0x6
            L0098: PushStack(player, 0x01);
            L009C: PushStack(player, 0x02);
04B3  00A0 33 C0  xor ax, ax
            L00A2: goto L0164;
            L00A5: SetFlag(player, 0x03, 0x01, 0x00);
            L00B9: ShowMessage(player, String0272); // AMBUSH!  Something ghostly and ghastly cast a fireball at you and then retreated!
            L00C6: ax = GetMaxHits(player);
            L00CD: bx = 0x0004;
            L00D0: dx = ax % bx; ax = ax / bx;
            L00D3: DamagePlayer(player, ax);
            L00DD: ShowMessage(player, String02C4); // We did damage - did we get Ambush msg?
            L00EA: goto L016E;
            L00ED: Compare(HasUsedSkill(player, 0x0B), 0x0003);
            L00FC: if (JumpAbove) goto L0134;
            L00FE: PushStack(player, 0xA6);
            L0102: PushStack(player, ax);
0516  0103 C4 5E 06  les bx, [bp+0x6]
0519  0106 26 FF 5F 54  call far word [es:bx+0x54]
            L010A: cx = PopStack(player);
            L010B: cx = PopStack(player);
            L010C: RefreshCompareFlags(ax);
            L010E: if (JumpNotEqual) goto L0134;
            L0110: PushStack(player, 0x62);
            L0114: PushStack(player, ax);
0528  0115 C4 5E 06  les bx, [bp+0x6]
052B  0118 26 FF 5F 54  call far word [es:bx+0x54]
            L011C: cx = PopStack(player);
            L011D: cx = PopStack(player);
            L011E: RefreshCompareFlags(ax);
            L0120: if (JumpNotEqual) goto L0134;
            L0122: PushStack(player, 0x8F);
            L0126: PushStack(player, ax);
053A  0127 C4 5E 06  les bx, [bp+0x6]
053D  012A 26 FF 5F 54  call far word [es:bx+0x54]
            L012E: cx = PopStack(player);
            L012F: cx = PopStack(player);
            L0130: RefreshCompareFlags(ax);
            L0132: if (JumpEqual) goto L015A;
            L0134: ShowMessage(player, String02EB); // Some faint tracks lure you onward.
            L0141: SetFlag(player, 0x00, 0x02, 0x01);
0568  0155 B8 01 00  mov ax, 0x1
            L0158: goto L015C;
            L015A: SetFlag(player, 0x03, 0x01, 0x00);
            L016E: return; // RETURN;
        }

        private void Fn_05(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x04, 0x01, 0xF9, 0x03, isForwardMove);
            L001E: return; // RETURN;
        }

        private void Fn_06(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String030E); // This way to The Gallery.
            L0010: return; // RETURN;
        }

        private void Fn_07(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetNoJoinArea(player);
            L000B: Compare(PartyCount(player), 0x0001);
            L0016: if (JumpBelowOrEqual) goto L0039;
            L0018: ShowMessage(player, String0327); // You try squeezing down this narrow corridor, but it's so tight that - aargh!  You've been impaled on your companion's weapon!
            L0025: DamagePlayer(player, GetMaxHits(player));
            L0036: goto L02C4;
            L0039: RefreshCompareFlags(GetFlag(player, 0x02, 0x2C));
            L004C: if (JumpEqual) goto L0051;
            L004E: goto L0269;
            L0051: SetFlag(player, 0x02, 0x2C, 0x01);
            L0066: ShowMessage(player, String03A5); // Galatea greets you. 'Thou hast matched my hopes and exceeded my expectations, and earned thereby many rewards.  I shall begin by granting thee abilities and experience.'
            L0073: Compare(GetGuild(player), 0x0005);
            L007D: if (JumpEqual) goto L008B;
            L007F: Compare(GetGuild(player), 0x0003);
            L0089: if (JumpNotEqual) goto L00B9;
            L008B: RefreshCompareFlags(GetSkillLevel(player, 0x11));
            L0099: if (JumpNotEqual) goto L00B9;
            L009B: ShowMessage(player, String044F); // 'As thy foes grow ever more canny and cunning, thou shouldst know how to minimize the damage from their spells.'  You now know how to deflect magic!
            L00A8: SetSkillLevel(player, 0x11, 0x01);
            L00B9: RefreshCompareFlags(GetGuild(player));
            L00C2: if (JumpNotEqual) goto L00F2;
            L00C4: RefreshCompareFlags(GetSkillLevel(player, 0x06));
            L00D2: if (JumpNotEqual) goto L00F2;
            L00D4: ShowMessage(player, String04E4); // 'Child of nature, thou wilt find it easy to learn and to use a skill of natural healing, of binding thy own wounds or those of thy companions.Behold!'  You know the binding skill!
            L00E1: SetSkillLevel(player, 0x06, 0x01);
            L00F2: Compare(GetGuild(player), 0x0004);
            L00FC: if (JumpNotEqual) goto L012C;
            L00FE: RefreshCompareFlags(GetSkillLevel(player, 0x17));
            L010C: if (JumpNotEqual) goto L012C;
            L010E: ShowMessage(player, String0598); // 'As thou dost learn more puissant and costly spells, so shouldst thou also know better how to replenish the mana on which thou dost draw to cast them.  Behold!'  You now know how to enter a deep trance!
            L011B: SetSkillLevel(player, 0x17, 0x01);
            L012C: Compare(GetGuild(player), 0x0001);
            L0136: if (JumpEqual) goto L0144;
            L0138: Compare(GetGuild(player), 0x0002);
            L0142: if (JumpNotEqual) goto L0170;
            L0144: RefreshCompareFlags(GetSkillLevel(player, 0x00));
            L0151: if (JumpNotEqual) goto L0170;
            L0153: ShowMessage(player, String0663); // 'As thou must face ever greater evils, thou shouldst know better how to use thy body, both to cause damage and to avoid damage.  Behold!'  You now know the athletics skill!
            L0160: SetSkillLevel(player, 0x00, 0x01);
            L0170: RefreshCompareFlags(GetSkillLevel(player, 0x14));
            L017E: if (JumpNotEqual) goto L01A2;
            L0180: ShowMessage(player, String0710); // 'I must speak plain, for thou hast avoided the meaning I tried to impart thee before.
            L018D: ShowMessage(player, String0766); // There is a fountain in the Foyer.  An thou dost enter it thrice, then thou shalt be granted the skill of reading runes.  That skill will prove most educational an thou dost ply it in The Runed Room.'
074F  019A B8 04 00  mov ax, 0x4
0752  019D BA E0 93  mov dx, 0x93e0
            L01A0: goto L01EC;
            L01A2: RefreshCompareFlags(GetFlag(player, 0x02, 0x1F));
            L01B5: if (JumpNotEqual) goto L01D9;
            L01B7: ShowMessage(player, String082E); // 'I am most pleased that thou didst learn the secret of the Runed Fountain.
            L01C4: ShowMessage(player, String0879); // For the skill thou hast shown at deciphering my riddles I do grant thee an extra portion of experience I withhold from thy less persistent comrades.  But I refer thee to study of The Runed Room.'
0786  01D1 B8 09 00  mov ax, 0x9
0789  01D4 BA C0 27  mov dx, 0x27c0
            L01D7: goto L01EC;
            L01D9: ShowMessage(player, String093D); // 'Thou hast been truly diligent in thy pursuit of knowledge and the study of runes.  I am most pleased with thee, and do grant thee a reward commensurate with my pleasure.'
            L01E6: AddExperience(player, 0x000DBBA0);
            L01F8: ShowMessage(player, String09E9); // 'On this level is The Library.  Not all the wisdom in The Library is obvious, either to find or to decipher.  But there is much to learn about the hidden powers of certain objects, an thou dost invest the effort.
            L0205: ShowMessage(player, String0ABE); // Also hereon is Malcolm's Ghost, who will not be as easily cowed as was Fleance.'
            L0212: RefreshCompareFlags(GetFlag(player, 0x02, 0x0A));
            L0225: if (JumpNotEqual) goto L025A;
            L0227: ShowMessage(player, String0B0F); // 'To survive and thrive on these more difficult levels, thou shouldst know ever mightier spells.  I hereby grant thee the spell known, simply, as Blast.'
            L0234: SetSpellLevel(player, 0x01, 0x03);
            L0245: SetFlag(player, 0x02, 0x0A, 0x01);
080F  025A B8 A8 0B  mov ax, 0xba8
            L025D: PushStack(player, ax);
0813  025E C4 5E 06  les bx, [bp+0x6]
0816  0261 26 FF 9F F8 00  call far word [es:bx+0xf8]
            L0266: goto L0035;
            L0269: RefreshCompareFlags(GetFlag(player, 0x02, 0x2B));
            L027C: if (JumpNotEqual) goto L02C4;
            L027E: ShowMessage(player, String0C0B); // It looks like someone is investigating yourmeeting with Galatea here earlier!
            L028B: SetFlag(player, 0x02, 0x2B, 0x01);
            L02A0: AddEncounter(player, 0x01, 0x16);
            L02B2: AddEncounter(player, 0x05, 0x18);
            L02C4: return; // RETURN;
        }

        private void Fn_08(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetNoJoinArea(player);
            L000B: Compare(PartyCount(player), 0x0001);
            L0016: if (JumpBelowOrEqual) goto L0039;
            L0018: ShowMessage(player, String0327); // You try squeezing down this narrow corridor, but it's so tight that - aargh!  You've been impaled on your companion's weapon!
            L0025: DamagePlayer(player, GetMaxHits(player));
            L0036: goto L00FA;
            L0039: SetNoJoinArea(player);
            L0041: RefreshCompareFlags(GetFlag(player, 0x03, 0x0D));
            L0054: if (JumpNotEqual) goto L0078;
            L0056: SetFlag(player, 0x03, 0x0D, 0x01);
            L006B: ShowMessage(player, String0C59); // This narrow corridor forces you to proceed single file.
            L0078: RefreshCompareFlags(GetFlag(player, 0x02, 0x2A));
            L008B: if (JumpNotEqual) goto L00B9;
            L008D: SetWallObject(player, 0x00, 0xF9, 0x01);
            L00A2: SetWallPassable(player, 0xF9, 0x01, 0x00);
            L00B7: goto L00D2;
            L00B9: Compare(GetFacing(player), 0x0001);
            L00C3: if (JumpNotEqual) goto L00D2;
            L00C5: ShowMessage(player, String0C91); // There are stairs leading up at the end of this hallway.
            L00D2: SetFlag(player, 0x02, 0x2D, 0x00);
            L00E6: SetFlag(player, 0x02, 0x2E, 0x00);
            L00FA: return; // RETURN;
        }

        private void Fn_09(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetNoJoinArea(player);
            L000B: Compare(PartyCount(player), 0x0001);
            L0016: if (JumpBelowOrEqual) goto L0037;
            L0018: ShowMessage(player, String0327); // You try squeezing down this narrow corridor, but it's so tight that - aargh!  You've been impaled on your companion's weapon!
            L0025: PushStack(player, GetMaxHits(player));
09A4  002D C4 5E 06  les bx, [bp+0x6]
09A7  0030 26 FF 9F 90 00  call far word [es:bx+0x90]
            L0035: goto L0076;
            L0037: Compare(GetFlag(player, 0x02, 0x2A), 0x0001);
            L004B: if (JumpNotEqual) goto L006A;
            L004D: TeleportParty(player, 0x06, 0x03, 0xFA, 0x03, isForwardMove);
            L0068: goto L0077;
            L006A: ShowMessage(player, String0CC9); // 'It is not safe to assay the higher levels while leaving Malcolm's ghost behind thee,' Galatea whispers.
            L0077: return; // RETURN;
        }

        private void Fn_0A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x00);
09F6  0006 C4 5E 06  les bx, [bp+0x6]
09F9  0009 26 FF 9F B0 00  call far word [es:bx+0xb0]
            L000E: cx = PopStack(player);
            L000F: RefreshCompareFlags(ax);
            L0011: if (JumpEqual) goto L0024;
            L0013: PushStack(player, 0x02);
0A07  0017 C4 5E 06  les bx, [bp+0x6]
0A0A  001A 26 FF 9F B0 00  call far word [es:bx+0xb0]
            L001F: cx = PopStack(player);
            L0020: RefreshCompareFlags(ax);
            L0022: if (JumpNotEqual) goto L0050;
            L0024: Compare(GetFlag(player, 0x02, 0x14), 0x0001);
            L0038: if (JumpEqual) goto L0050;
            L003A: Compare(GetFlag(player, 0x02, 0x1C), 0x0001);
            L004E: if (JumpNotEqual) goto L00B0;
            L0050: ShowPortrait(player, 0x0018);
            L005D: ShowMessage(player, String0D32); // Two elves, a barbarian and a ranger by their appearance, courteously hold open a secret door for you.  'Watch out for the boars in here,' they warn you.  'Some of the most deadly go on two legs.'
            L006A: SetFlag(player, 0x02, 0x2D, 0x00);
            L007E: SetFlag(player, 0x02, 0x2E, 0x01);
            L0093: TeleportParty(player, 0x06, 0x02, 0xFC, 0x03, isForwardMove);
            L00AE: goto L00BD;
            L00B0: ShowMessage(player, String0DF6); // The door to the Library refuses to budge.
            L00BD: return; // RETURN;
        }

        private void Fn_0B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0E20); // It is eerily quiet here.
            L0010: return; // RETURN;
        }

        private void Fn_0C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x05);
0AC8  0007 C4 5E 06  les bx, [bp+0x6]
0ACB  000A 26 FF 9F B0 00  call far word [es:bx+0xb0]
            L000F: cx = PopStack(player);
            L0010: RefreshCompareFlags(ax);
            L0012: if (JumpEqual) goto L0025;
            L0014: PushStack(player, 0x04);
0AD9  0018 C4 5E 06  les bx, [bp+0x6]
0ADC  001B 26 FF 9F B0 00  call far word [es:bx+0xb0]
            L0020: cx = PopStack(player);
            L0021: RefreshCompareFlags(ax);
            L0023: if (JumpNotEqual) goto L0051;
            L0025: Compare(GetFlag(player, 0x02, 0x14), 0x0001);
            L0039: if (JumpEqual) goto L0051;
            L003B: Compare(GetFlag(player, 0x02, 0x1A), 0x0001);
            L004F: if (JumpNotEqual) goto L00CE;
            L0051: ShowPortrait(player, 0x002E);
            L005E: ShowMessage(player, String0E39); // A gremlin wizard and a gremlin cleric courteously hold open a very thick door for you.  'Allow us,' they say.  'There are so many undead in here it is a pleasure to let in fresh clerics.'
            L006B: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0089: SetFlag(player, 0x02, 0x2D, 0x01);
            L009E: SetFlag(player, 0x02, 0x2E, 0x00);
            L00B2: TeleportParty(player, 0x05, 0x03, 0xBF, 0x00, isForwardMove);
            L00CC: goto L00DB;
            L00CE: ShowMessage(player, String0EF5); // Struggle though you will, you are unable to open the door that leads to the Music Room.
            L00DB: return; // RETURN;
        }

        private void Fn_0D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x03);
            L0007: PushStack(player, ax);
0BA6  0008 C4 5E 06  les bx, [bp+0x6]
0BA9  000B 26 FF 5F 04  call far word [es:bx+0x4]
            L000F: cx = PopStack(player);
            L0010: cx = PopStack(player);
            L0011: RefreshCompareFlags(ax);
            L0013: if (JumpNotEqual) goto L005B;
            L0015: PushStack(player, 0x01);
            L0019: PushStack(player, 0x03);
            L001D: PushStack(player, ax);
0BBC  001E C4 5E 06  les bx, [bp+0x6]
0BBF  0021 26 FF 1F  call far word [es:bx]
0BC2  0024 83 C4 06  add sp, 0x6
            L0027: ShowPortrait(player, 0x0008);
            L0034: ShowMessage(player, String0F4D); // 'Good gentles, could you please give a lost soul some directions?  My mission is rather confused.  I must go to Elsinore Castle for an omelet and danish, or something like that.  Do you know where that is?'
            L0041: ShowMessage(player, String101C); // You shake your head.
            L004E: ShowMessage(player, String1031); // 'Ah, well, that's afterlife, as they say.  No rest for the Yorick.  Be seeing you....'  The skeleton departs.
            L005B: return; // RETURN;
        }

        private void Fn_0E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x04));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L0102;
            L001B: SetFlag(player, 0x03, 0x04, 0x01);
            L0030: ShowMessage(player, String109F); // A horde of harpies were waiting for you!
            L003D: Compare(PartyCount(player), 0x0002);
            L0048: if (JumpBelowOrEqual) goto L0057;
            L004A: ShowMessage(player, String10C8); // Along with some impertinent imps.
0C52  0057 B8 45 01  mov ax, 0x145
            L005A: PushStack(player, ax);
            L005B: PushStack(player, 0x00);
            L005E: PushStack(player, ax);
            L005F: PushStack(player, 0xB9);
            L0063: PushStack(player, 0xBE);
            L0067: PushStack(player, 0x06);
0C66  006B C4 5E 06  les bx, [bp+0x6]
0C69  006E 26 FF 9F D8 00  call far word [es:bx+0xd8]
0C6E  0073 83 C4 0C  add sp, 0xc
            L0076: AddEncounter(player, 0x01, 0x20);
            L0088: AddEncounter(player, 0x02, 0x21);
            L009A: Compare(PartyCount(player), 0x0002);
            L00A5: if (JumpBelowOrEqual) goto L00CB;
            L00A7: AddEncounter(player, 0x05, 0x24);
            L00B9: AddEncounter(player, 0x06, 0x25);
            L00CB: Compare(PartyCount(player), 0x0003);
            L00D6: if (JumpAbove) goto L00DB;
            L00D8: goto L0243;
            L00DB: AddEncounter(player, 0x04, 0x20);
            L00ED: AddEncounter(player, 0x03, 0x20);
            L00FF: goto L0243;
            L0102: Compare(GetFlag(player, 0x03, 0x04), 0x0001);
            L0116: if (JumpEqual) goto L011B;
            L0118: goto L0236;
            L011B: Compare(GetFlag(player, 0x03, 0x05), 0x0001);
            L012F: if (JumpEqual) goto L0134;
            L0131: goto L0236;
            L0134: Compare(GetFlag(player, 0x03, 0x06), 0x0001);
            L0148: if (JumpEqual) goto L014D;
            L014A: goto L0236;
            L014D: Compare(GetFlag(player, 0x03, 0x07), 0x0001);
            L0161: if (JumpEqual) goto L0166;
            L0163: goto L0236;
            L0166: Compare(GetFlag(player, 0x03, 0x08), 0x0001);
            L017A: if (JumpEqual) goto L017F;
            L017C: goto L0236;
            L017F: Compare(GetFlag(player, 0x03, 0x09), 0x0001);
            L0193: if (JumpEqual) goto L0198;
            L0195: goto L0236;
            L0198: Compare(GetFlag(player, 0x03, 0x0A), 0x0001);
            L01AC: if (JumpEqual) goto L01B1;
            L01AE: goto L0236;
            L01B1: RefreshCompareFlags(GetFlag(player, 0x03, 0x0F));
            L01C4: if (JumpNotEqual) goto L0236;
            L01C6: GiveItem(player, 0xD9);
            L01D2: SetFlag(player, 0x03, 0x0F, 0x01);
            L01E7: ShowPortrait(player, 0x0015);
            L01F4: ShowMessage(player, String10EA); // 'Huzzah!  Thou hast completely, if temporarily, rid this room of agents of my sisters, and I have drawn the duty to investigate!
            L0201: ShowMessage(player, String116B); // I can now give thee this ring.  An thou dost use it while in water, then thou canst summon Mannanan Mac Lir, who will give thee aid of another sort.'
            L020E: AddExperience(player, 0x000493E0);
            L0220: HealPlayer(player, GetMaxHits(player));
0E2C  0231 B8 01 12  mov ax, 0x1201
            L0234: goto L0239;
            L0236: ShowMessage(player, String12A2); // All that remains from your battle here is a smelly old tailfeather.
            L0243: return; // RETURN;
        }

        private void Fn_0F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x05));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00FC;
            L001B: SetFlag(player, 0x03, 0x05, 0x01);
            L0030: ShowMessage(player, String12E6); // They say that the bigger they are, the harder they fall.  The problem is, they just might fall on you.
            L003D: Compare(PartyCount(player), 0x0003);
            L0048: if (JumpBelowOrEqual) goto L0057;
            L004A: ShowMessage(player, String134D); // In fact, even near you might be close enough!
0E97  0057 B8 E7 01  mov ax, 0x1e7
            L005A: PushStack(player, ax);
            L005B: PushStack(player, 0x00);
            L005E: PushStack(player, ax);
            L005F: PushStack(player, ax);
            L0060: PushStack(player, ax);
            L0061: PushStack(player, 0xBA);
0EA5  0065 C4 5E 06  les bx, [bp+0x6]
0EA8  0068 26 FF 9F D8 00  call far word [es:bx+0xd8]
0EAD  006D 83 C4 0C  add sp, 0xc
            L0070: AddEncounter(player, 0x01, 0x1E);
            L0082: AddEncounter(player, 0x02, 0x1F);
            L0094: Compare(PartyCount(player), 0x0002);
            L009F: if (JumpBelowOrEqual) goto L00C5;
            L00A1: AddEncounter(player, 0x03, 0x1F);
            L00B3: AddEncounter(player, 0x04, 0x1F);
            L00C5: Compare(PartyCount(player), 0x0003);
            L00D0: if (JumpAbove) goto L00D5;
            L00D2: goto L023D;
            L00D5: AddEncounter(player, 0x05, 0x1E);
            L00E7: AddEncounter(player, 0x06, 0x1E);
            L00F9: goto L023D;
            L00FC: Compare(GetFlag(player, 0x03, 0x04), 0x0001);
            L0110: if (JumpEqual) goto L0115;
            L0112: goto L0230;
            L0115: Compare(GetFlag(player, 0x03, 0x05), 0x0001);
            L0129: if (JumpEqual) goto L012E;
            L012B: goto L0230;
            L012E: Compare(GetFlag(player, 0x03, 0x06), 0x0001);
            L0142: if (JumpEqual) goto L0147;
            L0144: goto L0230;
            L0147: Compare(GetFlag(player, 0x03, 0x07), 0x0001);
            L015B: if (JumpEqual) goto L0160;
            L015D: goto L0230;
            L0160: Compare(GetFlag(player, 0x03, 0x08), 0x0001);
            L0174: if (JumpEqual) goto L0179;
            L0176: goto L0230;
            L0179: Compare(GetFlag(player, 0x03, 0x09), 0x0001);
            L018D: if (JumpEqual) goto L0192;
            L018F: goto L0230;
            L0192: Compare(GetFlag(player, 0x03, 0x0A), 0x0001);
            L01A6: if (JumpEqual) goto L01AB;
            L01A8: goto L0230;
            L01AB: RefreshCompareFlags(GetFlag(player, 0x03, 0x0F));
            L01BE: if (JumpNotEqual) goto L0230;
            L01C0: GiveItem(player, 0xD9);
            L01CC: SetFlag(player, 0x03, 0x0F, 0x01);
            L01E1: ShowPortrait(player, 0x0015);
            L01EE: ShowMessage(player, String10EA); // 'Huzzah!  Thou hast completely, if temporarily, rid this room of agents of my sisters, and I have drawn the duty to investigate!
            L01FB: ShowMessage(player, String116B); // I can now give thee this ring.  An thou dost use it while in water, then thou canst summon Mannanan Mac Lir, who will give thee aid of another sort.'
            L0208: AddExperience(player, 0x000493E0);
            L021A: HealPlayer(player, GetMaxHits(player));
106B  022B B8 01 12  mov ax, 0x1201
            L022E: goto L0233;
            L0230: ShowMessage(player, String137B); // All that remains from your battle here is the third largest splinter you've ever seen.
            L023D: return; // RETURN;
        }

        private void Fn_10(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x06));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L0102;
            L001B: SetFlag(player, 0x03, 0x06, 0x01);
            L0030: ShowMessage(player, String13D2); // You would call them male chauvinist pigs, but half of them seem to be sows.
            L003D: Compare(PartyCount(player), 0x0003);
            L0048: if (JumpBelowOrEqual) goto L0057;
            L004A: ShowMessage(player, String141E); // And the larger half at that!
10D6  0057 B8 71 02  mov ax, 0x271
            L005A: PushStack(player, ax);
            L005B: PushStack(player, 0x00);
            L005E: PushStack(player, ax);
            L005F: PushStack(player, 0xBA);
            L0063: PushStack(player, 0xDB);
            L0067: PushStack(player, 0xCC);
10EA  006B C4 5E 06  les bx, [bp+0x6]
10ED  006E 26 FF 9F D8 00  call far word [es:bx+0xd8]
10F2  0073 83 C4 0C  add sp, 0xc
            L0076: AddEncounter(player, 0x01, 0x23);
            L0088: AddEncounter(player, 0x02, 0x22);
            L009A: Compare(PartyCount(player), 0x0002);
            L00A5: if (JumpBelowOrEqual) goto L00CB;
            L00A7: AddEncounter(player, 0x03, 0x23);
            L00B9: AddEncounter(player, 0x04, 0x22);
            L00CB: Compare(PartyCount(player), 0x0003);
            L00D6: if (JumpAbove) goto L00DB;
            L00D8: goto L0243;
            L00DB: AddEncounter(player, 0x05, 0x23);
            L00ED: AddEncounter(player, 0x06, 0x22);
            L00FF: goto L0243;
            L0102: Compare(GetFlag(player, 0x03, 0x04), 0x0001);
            L0116: if (JumpEqual) goto L011B;
            L0118: goto L0236;
            L011B: Compare(GetFlag(player, 0x03, 0x05), 0x0001);
            L012F: if (JumpEqual) goto L0134;
            L0131: goto L0236;
            L0134: Compare(GetFlag(player, 0x03, 0x06), 0x0001);
            L0148: if (JumpEqual) goto L014D;
            L014A: goto L0236;
            L014D: Compare(GetFlag(player, 0x03, 0x07), 0x0001);
            L0161: if (JumpEqual) goto L0166;
            L0163: goto L0236;
            L0166: Compare(GetFlag(player, 0x03, 0x08), 0x0001);
            L017A: if (JumpEqual) goto L017F;
            L017C: goto L0236;
            L017F: Compare(GetFlag(player, 0x03, 0x09), 0x0001);
            L0193: if (JumpEqual) goto L0198;
            L0195: goto L0236;
            L0198: Compare(GetFlag(player, 0x03, 0x0A), 0x0001);
            L01AC: if (JumpEqual) goto L01B1;
            L01AE: goto L0236;
            L01B1: RefreshCompareFlags(GetFlag(player, 0x03, 0x0F));
            L01C4: if (JumpNotEqual) goto L0236;
            L01C6: GiveItem(player, 0xD9);
            L01D2: SetFlag(player, 0x03, 0x0F, 0x01);
            L01E7: ShowPortrait(player, 0x0015);
            L01F4: ShowMessage(player, String10EA); // 'Huzzah!  Thou hast completely, if temporarily, rid this room of agents of my sisters, and I have drawn the duty to investigate!
            L0201: ShowMessage(player, String116B); // I can now give thee this ring.  An thou dost use it while in water, then thou canst summon Mannanan Mac Lir, who will give thee aid of another sort.'
            L020E: AddExperience(player, 0x000493E0);
            L0220: HealPlayer(player, GetMaxHits(player));
12B0  0231 B8 01 12  mov ax, 0x1201
            L0234: goto L0239;
            L0236: ShowMessage(player, String143B); // All that remains from your battle here is an empty bag of pork rinds.
            L0243: return; // RETURN;
        }

        private void Fn_11(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x07));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00E8;
            L001B: SetFlag(player, 0x03, 0x07, 0x01);
            L0030: ShowMessage(player, String1481); // It looks like dragons all the way down!
1301  003D B8 B9 03  mov ax, 0x3b9
            L0040: PushStack(player, ax);
            L0041: PushStack(player, 0x00);
            L0044: PushStack(player, ax);
            L0045: PushStack(player, 0xBA);
            L0049: PushStack(player, 0x77);
            L004D: PushStack(player, 0xF8);
1315  0051 C4 5E 06  les bx, [bp+0x6]
1318  0054 26 FF 9F D8 00  call far word [es:bx+0xd8]
131D  0059 83 C4 0C  add sp, 0xc
            L005C: AddEncounter(player, 0x01, 0x27);
            L006E: AddEncounter(player, 0x05, 0x26);
            L0080: Compare(PartyCount(player), 0x0002);
            L008B: if (JumpBelowOrEqual) goto L00B1;
            L008D: AddEncounter(player, 0x02, 0x27);
            L009F: AddEncounter(player, 0x06, 0x26);
            L00B1: Compare(PartyCount(player), 0x0003);
            L00BC: if (JumpAbove) goto L00C1;
            L00BE: goto L0229;
            L00C1: AddEncounter(player, 0x04, 0x27);
            L00D3: AddEncounter(player, 0x03, 0x26);
            L00E5: goto L0229;
            L00E8: Compare(GetFlag(player, 0x03, 0x04), 0x0001);
            L00FC: if (JumpEqual) goto L0101;
            L00FE: goto L021C;
            L0101: Compare(GetFlag(player, 0x03, 0x05), 0x0001);
            L0115: if (JumpEqual) goto L011A;
            L0117: goto L021C;
            L011A: Compare(GetFlag(player, 0x03, 0x06), 0x0001);
            L012E: if (JumpEqual) goto L0133;
            L0130: goto L021C;
            L0133: Compare(GetFlag(player, 0x03, 0x07), 0x0001);
            L0147: if (JumpEqual) goto L014C;
            L0149: goto L021C;
            L014C: Compare(GetFlag(player, 0x03, 0x08), 0x0001);
            L0160: if (JumpEqual) goto L0165;
            L0162: goto L021C;
            L0165: Compare(GetFlag(player, 0x03, 0x09), 0x0001);
            L0179: if (JumpEqual) goto L017E;
            L017B: goto L021C;
            L017E: Compare(GetFlag(player, 0x03, 0x0A), 0x0001);
            L0192: if (JumpEqual) goto L0197;
            L0194: goto L021C;
            L0197: RefreshCompareFlags(GetFlag(player, 0x03, 0x0F));
            L01AA: if (JumpNotEqual) goto L021C;
            L01AC: GiveItem(player, 0xD9);
            L01B8: SetFlag(player, 0x03, 0x0F, 0x01);
            L01CD: ShowPortrait(player, 0x0015);
            L01DA: ShowMessage(player, String10EA); // 'Huzzah!  Thou hast completely, if temporarily, rid this room of agents of my sisters, and I have drawn the duty to investigate!
            L01E7: ShowMessage(player, String116B); // I can now give thee this ring.  An thou dost use it while in water, then thou canst summon Mannanan Mac Lir, who will give thee aid of another sort.'
            L01F4: AddExperience(player, 0x000493E0);
            L0206: HealPlayer(player, GetMaxHits(player));
14DB  0217 B8 01 12  mov ax, 0x1201
            L021A: goto L021F;
            L021C: ShowMessage(player, String14A9); // You remember almost becoming wyrm food here.
            L0229: return; // RETURN;
        }

        private void Fn_12(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x08));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00E8;
            L001B: SetFlag(player, 0x03, 0x08, 0x01);
            L0030: ShowMessage(player, String14D6); // You liked it better on the lower levels when all the dragons did was steal from you.
152C  003D B8 32 02  mov ax, 0x232
            L0040: PushStack(player, ax);
            L0041: PushStack(player, 0x00);
            L0044: PushStack(player, ax);
            L0045: PushStack(player, 0x97);
            L0049: PushStack(player, 0x30);
            L004D: PushStack(player, 0xF8);
1540  0051 C4 5E 06  les bx, [bp+0x6]
1543  0054 26 FF 9F D8 00  call far word [es:bx+0xd8]
1548  0059 83 C4 0C  add sp, 0xc
            L005C: AddEncounter(player, 0x01, 0x28);
            L006E: AddEncounter(player, 0x05, 0x28);
            L0080: Compare(PartyCount(player), 0x0002);
            L008B: if (JumpBelowOrEqual) goto L00B1;
            L008D: AddEncounter(player, 0x02, 0x28);
            L009F: AddEncounter(player, 0x06, 0x28);
            L00B1: Compare(PartyCount(player), 0x0003);
            L00BC: if (JumpAbove) goto L00C1;
            L00BE: goto L0229;
            L00C1: AddEncounter(player, 0x04, 0x28);
            L00D3: AddEncounter(player, 0x03, 0x28);
            L00E5: goto L0229;
            L00E8: Compare(GetFlag(player, 0x03, 0x04), 0x0001);
            L00FC: if (JumpEqual) goto L0101;
            L00FE: goto L021C;
            L0101: Compare(GetFlag(player, 0x03, 0x05), 0x0001);
            L0115: if (JumpEqual) goto L011A;
            L0117: goto L021C;
            L011A: Compare(GetFlag(player, 0x03, 0x06), 0x0001);
            L012E: if (JumpEqual) goto L0133;
            L0130: goto L021C;
            L0133: Compare(GetFlag(player, 0x03, 0x07), 0x0001);
            L0147: if (JumpEqual) goto L014C;
            L0149: goto L021C;
            L014C: Compare(GetFlag(player, 0x03, 0x08), 0x0001);
            L0160: if (JumpEqual) goto L0165;
            L0162: goto L021C;
            L0165: Compare(GetFlag(player, 0x03, 0x09), 0x0001);
            L0179: if (JumpEqual) goto L017E;
            L017B: goto L021C;
            L017E: Compare(GetFlag(player, 0x03, 0x0A), 0x0001);
            L0192: if (JumpEqual) goto L0197;
            L0194: goto L021C;
            L0197: RefreshCompareFlags(GetFlag(player, 0x03, 0x0F));
            L01AA: if (JumpNotEqual) goto L021C;
            L01AC: GiveItem(player, 0xD9);
            L01B8: SetFlag(player, 0x03, 0x0F, 0x01);
            L01CD: ShowPortrait(player, 0x0015);
            L01DA: ShowMessage(player, String10EA); // 'Huzzah!  Thou hast completely, if temporarily, rid this room of agents of my sisters, and I have drawn the duty to investigate!
            L01E7: ShowMessage(player, String116B); // I can now give thee this ring.  An thou dost use it while in water, then thou canst summon Mannanan Mac Lir, who will give thee aid of another sort.'
            L01F4: AddExperience(player, 0x000493E0);
            L0206: HealPlayer(player, GetMaxHits(player));
1706  0217 B8 01 12  mov ax, 0x1201
            L021A: goto L021F;
            L021C: ShowMessage(player, String14A9); // You remember almost becoming wyrm food here.
            L0229: return; // RETURN;
        }

        private void Fn_13(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x09));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00E8;
            L001B: SetFlag(player, 0x03, 0x09, 0x01);
            L0030: ShowMessage(player, String152B); // Some adventurers are friendly.  These aren't.
1757  003D B8 0D 02  mov ax, 0x20d
            L0040: PushStack(player, ax);
            L0041: PushStack(player, 0x00);
            L0044: PushStack(player, ax);
            L0045: PushStack(player, 0xCC);
            L0049: PushStack(player, 0x40);
            L004D: PushStack(player, 0x31);
176B  0051 C4 5E 06  les bx, [bp+0x6]
176E  0054 26 FF 9F D8 00  call far word [es:bx+0xd8]
1773  0059 83 C4 0C  add sp, 0xc
            L005C: AddEncounter(player, 0x01, 0x1D);
            L006E: AddEncounter(player, 0x02, 0x1C);
            L0080: Compare(PartyCount(player), 0x0002);
            L008B: if (JumpBelowOrEqual) goto L009F;
            L008D: AddEncounter(player, 0x03, 0x1D);
            L009F: Compare(PartyCount(player), 0x0003);
            L00AA: if (JumpAbove) goto L00AF;
            L00AC: goto L0229;
            L00AF: AddEncounter(player, 0x04, 0x1D);
            L00C1: AddEncounter(player, 0x05, 0x1B);
            L00D3: AddEncounter(player, 0x06, 0x1B);
            L00E5: goto L0229;
            L00E8: Compare(GetFlag(player, 0x03, 0x04), 0x0001);
            L00FC: if (JumpEqual) goto L0101;
            L00FE: goto L021C;
            L0101: Compare(GetFlag(player, 0x03, 0x05), 0x0001);
            L0115: if (JumpEqual) goto L011A;
            L0117: goto L021C;
            L011A: Compare(GetFlag(player, 0x03, 0x06), 0x0001);
            L012E: if (JumpEqual) goto L0133;
            L0130: goto L021C;
            L0133: Compare(GetFlag(player, 0x03, 0x07), 0x0001);
            L0147: if (JumpEqual) goto L014C;
            L0149: goto L021C;
            L014C: Compare(GetFlag(player, 0x03, 0x08), 0x0001);
            L0160: if (JumpEqual) goto L0165;
            L0162: goto L021C;
            L0165: Compare(GetFlag(player, 0x03, 0x09), 0x0001);
            L0179: if (JumpEqual) goto L017E;
            L017B: goto L021C;
            L017E: Compare(GetFlag(player, 0x03, 0x0A), 0x0001);
            L0192: if (JumpEqual) goto L0197;
            L0194: goto L021C;
            L0197: RefreshCompareFlags(GetFlag(player, 0x03, 0x0F));
            L01AA: if (JumpNotEqual) goto L021C;
            L01AC: GiveItem(player, 0xD9);
            L01B8: SetFlag(player, 0x03, 0x0F, 0x01);
            L01CD: ShowPortrait(player, 0x0015);
            L01DA: ShowMessage(player, String10EA); // 'Huzzah!  Thou hast completely, if temporarily, rid this room of agents of my sisters, and I have drawn the duty to investigate!
            L01E7: ShowMessage(player, String116B); // I can now give thee this ring.  An thou dost use it while in water, then thou canst summon Mannanan Mac Lir, who will give thee aid of another sort.'
            L01F4: AddExperience(player, 0x000493E0);
            L0206: HealPlayer(player, GetMaxHits(player));
1931  0217 B8 01 12  mov ax, 0x1201
            L021A: goto L021F;
            L021C: ShowMessage(player, String1559); // You sure taught those guys a lesson!
            L0229: return; // RETURN;
        }

        private void Fn_14(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x0A));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L0126;
            L001B: SetFlag(player, 0x03, 0x0A, 0x01);
            L0030: ShowMessage(player, String157E); // How could they have ambushed you here?
            L003D: ShowMessage(player, String15A5); // Oh, they have halflings.  Halflings could ambush the devil before he knew they were dead.
            L004A: Compare(PartyCount(player), 0x0003);
            L0055: if (JumpBelowOrEqual) goto L0064;
            L0057: ShowMessage(player, String15FF); // And the gnomes aren't slouches, either.
            L0064: ax = GetMaxHits(player);
            L006B: bx = 0x0003;
            L006E: dx = ax % bx; ax = ax / bx;
            L0071: DamagePlayer(player, ax);
19C0  007B B8 71 02  mov ax, 0x271
            L007E: PushStack(player, ax);
            L007F: PushStack(player, 0x00);
            L0082: PushStack(player, ax);
            L0083: PushStack(player, 0x3F);
            L0087: PushStack(player, 0xAD);
            L008B: PushStack(player, 0x55);
19D4  008F C4 5E 06  les bx, [bp+0x6]
19D7  0092 26 FF 9F D8 00  call far word [es:bx+0xd8]
19DC  0097 83 C4 0C  add sp, 0xc
            L009A: AddEncounter(player, 0x01, 0x19);
            L00AC: AddEncounter(player, 0x05, 0x1A);
            L00BE: Compare(PartyCount(player), 0x0002);
            L00C9: if (JumpBelowOrEqual) goto L00EF;
            L00CB: AddEncounter(player, 0x02, 0x19);
            L00DD: AddEncounter(player, 0x06, 0x1A);
            L00EF: Compare(PartyCount(player), 0x0003);
            L00FA: if (JumpAbove) goto L00FF;
            L00FC: goto L0267;
            L00FF: AddEncounter(player, 0x04, 0x1A);
            L0111: AddEncounter(player, 0x03, 0x1A);
            L0123: goto L0267;
            L0126: Compare(GetFlag(player, 0x03, 0x04), 0x0001);
            L013A: if (JumpEqual) goto L013F;
            L013C: goto L025A;
            L013F: Compare(GetFlag(player, 0x03, 0x05), 0x0001);
            L0153: if (JumpEqual) goto L0158;
            L0155: goto L025A;
            L0158: Compare(GetFlag(player, 0x03, 0x06), 0x0001);
            L016C: if (JumpEqual) goto L0171;
            L016E: goto L025A;
            L0171: Compare(GetFlag(player, 0x03, 0x07), 0x0001);
            L0185: if (JumpEqual) goto L018A;
            L0187: goto L025A;
            L018A: Compare(GetFlag(player, 0x03, 0x08), 0x0001);
            L019E: if (JumpEqual) goto L01A3;
            L01A0: goto L025A;
            L01A3: Compare(GetFlag(player, 0x03, 0x09), 0x0001);
            L01B7: if (JumpEqual) goto L01BC;
            L01B9: goto L025A;
            L01BC: Compare(GetFlag(player, 0x03, 0x0A), 0x0001);
            L01D0: if (JumpEqual) goto L01D5;
            L01D2: goto L025A;
            L01D5: RefreshCompareFlags(GetFlag(player, 0x03, 0x0F));
            L01E8: if (JumpNotEqual) goto L025A;
            L01EA: GiveItem(player, 0xD9);
            L01F6: SetFlag(player, 0x03, 0x0F, 0x01);
            L020B: ShowPortrait(player, 0x0015);
            L0218: ShowMessage(player, String10EA); // 'Huzzah!  Thou hast completely, if temporarily, rid this room of agents of my sisters, and I have drawn the duty to investigate!
            L0225: ShowMessage(player, String116B); // I can now give thee this ring.  An thou dost use it while in water, then thou canst summon Mannanan Mac Lir, who will give thee aid of another sort.'
            L0232: AddExperience(player, 0x000493E0);
            L0244: HealPlayer(player, GetMaxHits(player));
1B9A  0255 B8 01 12  mov ax, 0x1201
            L0258: goto L025D;
            L025A: ShowMessage(player, String1627); // Your bones still ache from the battle you fought here.
            L0267: return; // RETURN;
        }

        private void Fn_15(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si, di);
            L0005: di = 0;
            L0007: si = 0;
            L0009: ax = GetFlag(player, 0x03, 0x0B);
1BC8  001A 8B F8  mov di, ax
1BCA  001C 47     inc di
1BCB  001D 8B F7  mov si, di
            L001F: Compare(si, 0x13);
            L0022: if (JumpLessOrEqual) goto L002B;
1BD2  0024 8B C6  mov ax, si
            L0026: si = ax + 0xFFEC;
            L002B: Compare(si, 0x0E);
            L002E: if (JumpLessOrEqual) goto L0037;
1BDE  0030 8B C6  mov ax, si
            L0032: si = ax + 0xFFF1;
            L0037: Compare(si, 0x09);
            L003A: if (JumpLessOrEqual) goto L0043;
1BEA  003C 8B C6  mov ax, si
            L003E: si = ax + 0xFFF6;
            L0043: Compare(si, 0x04);
            L0046: if (JumpLessOrEqual) goto L004F;
1BF6  0048 8B C6  mov ax, si
            L004A: si = ax + 0xFFFB;
1BFD  004F 0B F6  or si, si
1BFF  0051 7D 02  jge 0x55
            L0053: si = 0;
            L0055: Compare(si, 0x1D);
            L0058: if (JumpLessOrEqual) goto L005C;
            L005A: si = 0;
1C0A  005C 83 FF 1E  cmp di, 0x1e
            L005F: if (JumpLessOrEqual) goto L0063;
            L0061: di = 0;
1C11  0063 57     push di
            L0064: PushStack(player, 0x0B);
            L0068: PushStack(player, 0x03);
1C1A  006C C4 5E 06  les bx, [bp+0x6]
1C1D  006F 26 FF 1F  call far word [es:bx]
1C20  0072 83 C4 06  add sp, 0x6
1C23  0075 83 FF 1A  cmp di, 0x1a
            L0078: if (JumpNotEqual) goto L007F;
1C28  007A B8 01 00  mov ax, 0x1
            L007D: goto L0081;
            L007F: PushStack(player, 0x00);
1C30  0082 83 FF 14  cmp di, 0x14
            L0085: if (JumpNotEqual) goto L008C;
1C35  0087 B8 01 00  mov ax, 0x1
            L008A: goto L008E;
1C3A  008C 33 C0  xor ax, ax
            L008E: dx = PopStack(player);
1C3D  008F 0B D0  or dx, ax
            L0091: PushStack(player, dx);
1C40  0092 83 FF 0E  cmp di, 0xe
            L0095: if (JumpNotEqual) goto L009C;
1C45  0097 B8 01 00  mov ax, 0x1
            L009A: goto L009E;
1C4A  009C 33 C0  xor ax, ax
            L009E: dx = PopStack(player);
1C4D  009F 0B D0  or dx, ax
            L00A1: PushStack(player, dx);
1C50  00A2 83 FF 08  cmp di, 0x8
            L00A5: if (JumpNotEqual) goto L00AC;
1C55  00A7 B8 01 00  mov ax, 0x1
            L00AA: goto L00AE;
1C5A  00AC 33 C0  xor ax, ax
            L00AE: dx = PopStack(player);
1C5D  00AF 0B D0  or dx, ax
            L00B1: PushStack(player, dx);
1C60  00B2 83 FF 02  cmp di, 0x2
            L00B5: if (JumpNotEqual) goto L00BC;
1C65  00B7 B8 01 00  mov ax, 0x1
            L00BA: goto L00BE;
1C6A  00BC 33 C0  xor ax, ax
            L00BE: dx = PopStack(player);
1C6D  00BF 0B D0  or dx, ax
            L00C1: if (JumpNotEqual) goto L00C6;
            L00C3: goto L0263;
            L00C6: bx = si;
            L00C8: Compare(bx, 0x04);
            L00CB: if (JumpBelowOrEqual) goto L00D0;
            L00CD: goto L0263;
            L00D0: switch (bx) {
                case 0:
                    goto L00D7;
                case 1:
                    goto L00E7;
                case 2:
                    goto L012D;
                case 3:
                    goto L013F;
                case 4:
                    goto L01AE;
            }
            L00D7: ShowMessage(player, String165E); // You hear some footsteps running away.
            L00E4: goto L0263;
            L00E7: ShowMessage(player, String1684); // You hear someone running towards you.
            L00F4: ShowPortrait(player, 0x0026);
            L0101: ShowMessage(player, String16AA); // *
            L010E: ShowMessage(player, String16AA); // *
            L011B: ShowMessage(player, String16AA); // *
1CD6  0128 B8 AC 16  mov ax, 0x16ac
            L012B: goto L00DA;
            L012D: ShowPortrait(player, 0x0009);
1CE8  013A B8 5A 17  mov ax, 0x175a
            L013D: goto L00DA;
            L013F: Compare(GetFlag(player, 0x02, 0x47), 0x0001);
            L0153: if (JumpNotEqual) goto L015A;
1D03  0155 B8 2E 18  mov ax, 0x182e
            L0158: goto L00DA;
            L015A: ShowPortrait(player, 0x0025);
            L0167: ShowMessage(player, String16AA); // *
            L0174: ShowMessage(player, String16AA); // *
            L0181: ShowMessage(player, String16AA); // *
            L018E: ShowMessage(player, String1898); // 'A marvelous day, friends, 'tis it not?  I have learned two pieces of news that I will share with thee.
            L019B: ShowMessage(player, String1900); // The first is that Manannan Mac Lir can be summoned with an item thou canst obtain in this very Ballroom.  The second is that thou must be bloody, bold, and resolute to so obtain it.  Good fortune!'
1D56  01A8 B8 C6 19  mov ax, 0x19c6
            L01AB: goto L00DA;
            L01AE: ShowMessage(player, String16AA); // *
            L01BB: ShowMessage(player, String16AA); // *
            L01C8: ShowMessage(player, String16AA); // *
            L01D5: ShowMessage(player, String19E8); // A pummelled posse of imps decides, rather insultingly, that they are bigger than you are.
            L01E2: PushStack(player, 0xC1);
            L01E6: PushStack(player, 0x00);
            L01E9: PushStack(player, ax);
            L01EA: PushStack(player, 0xCC);
            L01EE: PushStack(player, 0x4C);
            L01F2: PushStack(player, 0xB9);
1DA4  01F6 C4 5E 06  les bx, [bp+0x6]
1DA7  01F9 26 FF 9F D8 00  call far word [es:bx+0xd8]
1DAC  01FE 83 C4 0C  add sp, 0xc
            L0201: AddEncounter(player, 0x01, 0x18);
            L0213: Compare(PartyCount(player), 0x0001);
            L021E: if (JumpBelowOrEqual) goto L0232;
            L0220: AddEncounter(player, 0x05, 0x18);
            L0232: Compare(PartyCount(player), 0x0002);
            L023D: if (JumpBelowOrEqual) goto L0263;
            L023F: AddEncounter(player, 0x02, 0x18);
            L0251: AddEncounter(player, 0x06, 0x18);
            L0263: return; // RETURN (restoring si, di);
        }

        private void Fn_16(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x0C));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L0099;
            L001A: // NOP
            L001B: SetFlag(player, 0x03, 0x0C, 0x01);
            L0030: ShowPortrait(player, 0x0027);
            L003D: ShowMessage(player, String16AA); // *
            L004A: ShowMessage(player, String16AA); // *
            L0057: ShowMessage(player, String16AA); // *
            L0064: Compare(GetFlag(player, 0x03, 0x0F), 0x0001);
            L0078: if (JumpNotEqual) goto L007F;
1E99  007A B8 42 1A  mov ax, 0x1a42
            L007D: goto L0082;
            L007F: ShowMessage(player, String1B02); // 'Galatea sends her best wishes, and commends to thee the wisdom of fighting the seven battles of power in the Ballroom.  An thou dost conclude all seven, and return to the site of any, she will be able to come to you with more aid than hitherto.'
            L008C: ShowMessage(player, String1AF1); // The elf departs.
            L0099: return; // RETURN;
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
            L004A: ShowMessage(player, String1BF9); // The narrow corridor to the south forces you to enter it single file.
            L0057: PushStack(player, 0x01);
            L005B: PushStack(player, 0x0E);
            L005F: PushStack(player, 0x03);
1F1D  0063 C4 5E 06  les bx, [bp+0x6]
1F20  0066 26 FF 1F  call far word [es:bx]
            L0069: goto L007F;
            L006B: SetWallPassable(player, GetCurrentTile(player), ax, 0x01);
            L0082: return; // RETURN;
        }

        private void Fn_18(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1C3E); // The door to the west reads: 'Donalbain's Chamber.'
            L0010: return; // RETURN;
        }

        private void Fn_19(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1C71); // The door to the west reads: 'Malcolm's Chamber.'
            L0010: return; // RETURN;
        }

        private void Fn_1A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1CA2); // The door to the west reads: 'Duncan's Chamber.'
            L0010: return; // RETURN;
        }

        private void Fn_1B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1CD2); // The door to the north reads: 'Lenox's Chamber.'
            L0010: return; // RETURN;
        }

        private void Fn_1C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1D02); // The door to the north reads: 'Macbeth's Box.'
            L0010: return; // RETURN;
        }

        private void Fn_1D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1D30); // The door to the north reads: 'Private.'
            L0010: return; // RETURN;
        }

        private void Fn_1E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1D58); // The door to the east reads: 'Banquo's Box.'
            L0010: return; // RETURN;
        }

        private void Fn_1F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1D84); // The door to the east reads: 'Macduff's Chamber.'
            L0010: return; // RETURN;
        }

        private void Fn_20(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1DB5); // The door to the east reads: 'Rosse's Room.'
            L0010: return; // RETURN;
        }

        private void Fn_21(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1DE1); // The door to the east reads: 'Menteth's Chamber.'
            L0010: return; // RETURN;
        }

        private void Fn_22(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1E12); // The door to the west reads: 'Angus's Area.'
            L0010: return; // RETURN;
        }

        private void Fn_23(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1E3E); // The door to the south reads: 'Cathness's Chamber.'
            L0010: return; // RETURN;
        }

        private void Fn_24(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1E71); // The door to the south reads: 'Angus's Area.'
            L0010: return; // RETURN;
        }

        private void Fn_25(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1E9E); // The door to the south reads: 'Powder Room.'
            L0010: return; // RETURN;
        }

    }
}
