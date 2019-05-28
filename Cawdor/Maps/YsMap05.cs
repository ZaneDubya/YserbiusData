#pragma warning disable
using System.Collections.Generic;
using XPT.WorldData;
using XPT.WorldData.Yserbius;

namespace XPT.Scripts.Yserbius.Maps {
    class YserMap05 : AMapScripted {
        protected override int MapIndex => 5;
        protected override int RandomEncounterChance => 10;
        protected override int RandomEncounterExtraCount => 0;

        public YserMap05() {
            MapEvent01 = Fn_01;
            MapEvent02 = Fn_02;
            MapEvent03 = Fn_03;
            MapEvent04 = Fn_04;
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
            MapEvent14 = Fn_14;
            MapEvent15 = Fn_15;
            MapEvent16 = Fn_16;
            MapEvent17 = Fn_17;
            MapEvent18 = Fn_18;
            MapEvent1B = Fn_1B;
            MapEvent1C = Fn_1C;
            MapEvent1D = Fn_1D;
            MapEvent1E = Fn_1E;
            MapEvent1F = Fn_1F;
        }
        
        // === Strings ================================================
        private const string String0140 = "This way to the Foyer of Cawdor.";
        private const string String0161 = "*";
        private const string String0163 = "Roxanna greets you fondly.  'It speaks well of thee that thou dost return to diminish the population of rude and unchivalrous beings that have inhabited this place since thy last visit.  May fortune favor thee!";
        private const string String0236 = "Roxanna greets you.  'Gentle sir, I can show my gratitude for thy aid in placating the foul inhabitants of this place.  I have an item which once daily grants me a powerful heal spell.'";
        private const string String02F0 = "You are healed!";
        private const string String0300 = "'Godspeed thee on thy missions here!'";
        private const string String0326 = "Roxanna nods as you pass, but says nothing.";
        private const string String0352 = "'I salute thee, for thou hast proven thyself to be of gentle mien and noble heart.  I am pleased to grant thee an award which, mayhaps, will aid thee in thy future chivalric endeavors.";
        private const string String040B = "Roxanne draws you aside and whispers to you.";
        private const string String0438 = "'Thou now knowest how to deflect magical assaults' she whispers.";
        private const string String0479 = "She steps forward and speaks loudly again.";
        private const string String04A4 = "Roxanne draws your party's knights aside for a few private words, and then returns.";
        private const string String04F8 = "She clasps your forearm, the old style of shaking hands.  'Now I must return to my duties.  Fare thee well!'";
        private const string String0565 = "'I appreciate thy efforts against the unholy creatures residing here, but I lack the means to reward thee for thy efforts.  This will have to suffice.'";
        private const string String05FD = "'Thou art needed elsewhere.  Farewell....'";
        private const string String0628 = "'I am Roxanna, the guardian of this gate.  I am charged to prevent the escape of the foul beasts that reside herein.  I thank thee for assisting me by battling the foul and fell beasts that live here.";
        private const string String06F1 = "Incoming!";
        private const string String06FB = "You give silent thanks that you were the one who survived the battle here.";
        private const string String0746 = "You think the tool will enable you to proceed discreetly.";
        private const string String0780 = "A familiar voice whispers to you.";
        private const string String07A2 = "'Before thou dost assay the ultimate combat in this place, thou hadst best prove thy mettle against the lesser creatures and citizens found hereabouts.";
        private const string String083A = "You see a heavily scarred and well equipped halfling striding confidently towards you.  He is wearing Gorgon's Gauntlets and carrying Macduff's Maul.";
        private const string String08D0 = "He says, 'Thou wouldst not think it to look at me, but singlehandedly have I slain sixteen giants, and I seek number seventeen.  Poach not on my self-appointed terrain, sir knight!'";
        private const string String0986 = "You wisely decide to let him go his own way.";
        private const string String09B3 = "A small but sturdy halfling knight greets you.";
        private const string String09E2 = "'Good morning, neighbor.  I am sworn to vengeance against Magog, a giant who has terrorised one halfling village too many.  To defeat him, I seek Swithun's Staff?  Know you where I might find one?'";
        private const string String0AA8 = "You shake your head.  He sighs and wanders off.";
        private const string String0AD8 = "A small, smiling halfling knight, carrying a Lozenge Spear, greets you.";
        private const string String0B20 = "'What ho!  Fellow knight, art thou sworn against the tall, that is to say, art thou on a quest against giantkind?'";
        private const string String0B93 = "You politely indicate that you are not.";
        private const string String0BBB = "'Very well, then, but an thou findest one so pledged, do send him to me!'  The halfling walks off.";
        private const string String0C1E = "A dwarf holds up her hand in greeting.";
        private const string String0C45 = "'I say, friend!  I am in a bit of a bother.";
        private const string String0C71 = "Knowest thou whether the Antlered Helm or Ironside's Headgear is the more effective defense against giants?  I have both and I must decide which to use.'";
        private const string String0D0B = "You tell her you don't know.";
        private const string String0D28 = "'Ah, well, empirical evidence it must be, then.'  She departs.";
        private const string String0D67 = "This must be the main minotaur migration mob!";
        private const string String0D95 = "This is the remains of a smithy.  A cracked anvil, some broken bellows, shattered shields, and splintered swords, are but some of the debris you see.";
        private const string String0E2B = "The smithy remains as when you last saw it.";
        private const string String0E57 = "A voice whispers from thin air....";
        private const string String0E7A = "'I'm sorry, but there's nothing else I can do for you here.'";
        private const string String0EB7 = "'Huzzah!  Thou hast done so well hitherto that I can safely reward thee.  I think me knowledge of the spell of shielding will best serve thee now.'";
        private const string String0F4B = "You realize that you now know that spell!";
        private const string String0F75 = "'Henceforth thy journey will become increasingly perilous.  It behooves me to teach thee a swifter way to retreat to places where thou may replenish thy supplies and renew thy strength and vigor.'";
        private const string String103A = "You now know the spell of teleport.";
        private const string String105E = "'I applaud and praise thee, who hast risked life and limb on my behalf.  As thy journey waxes ever more perilous, it behooves me to teach thee a swifter way to retreat to places where thou may replenish thy supplies and renew thy strength and vigor.";
        private const string String1158 = "'Thou hast received all the rewards I can safely grant thee here, lest my sisters notice and suspect me.'";
        private const string String11C2 = "'Thou art surviving, which is the important thing.  Take thee this item which mayhaps will help thee to continue doing so.'";
        private const string String123E = "'Thou hast earned no further rewards from me, good ticklebrain.'";
        private const string String127F = "A jauntily clad halfling greets you.";
        private const string String12A4 = "'Good gentle folk, let me not delay thee o'ermuch.";
        private const string String12D7 = "I have but this word to put in thy ear.  Ask not from whence I did learn of it, but I have been charged with the task of spreading this missive as far as I might, and thou art now my spreadee.";
        private const string String1398 = "Hark thee and mark thee: there are many most potent items consisting of a body part of a creature.  For example, the Eye of Newt, the Toe of Frog, et al.";
        private const string String1432 = "These items all are of immense power and restrictions.  They can slay most any creature, but use them with care: once used, once useless.";
        private const string String14BC = "An thou dost pass these words along, I shall stand in thy debt.'  The halfling hurries off.";
        private const string String1518 = "It was here that you learned that Rory, amongst others, was on your quest.  You promise yourself that your next toast of good brown ale will be for lost friends.";
        private const string String15BA = "You're just glad you're not the janitor, what with all these minotaur morsels lying around here.";
        private const string String161B = "Uh oh.  Those minotaurs look angry, and that's no bull.";
        private const string String1653 = "Maybe the spellcasters moving them along have something to do with that.";
        private const string String169C = "There's something grotesquely comforting about having survived a combat.";
        private const string String16E5 = "There's a thin thin line between a smiling and a snarling face and - yup! - these guys are snarling!";
        private const string String174A = "And in desperate need of orthodontia.";
        private const string String1770 = "There are enough feline allergens here to make all of Edinburgh sneeze!";
        private const string String17B8 = "Man!  Those cats are so big, their purring sounds like buzzsaws!  Not that they're purring right now, either.";
        private const string String1826 = "Unless they're purring in anticipation of a filling meal: hero tartar!";
        private const string String186D = "'If you are going to have to fight, it's a lot more pleasant having fought someone with a hefty purse,' you think to yourself, recalling the battle here.";
        private const string String1907 = "Ah, heck!  You thought this was a good spot for an ambush.  Evidently, so did they.";
        private const string String195B = "You know, those thievish skills and lockpicks may have something going for them after all.";
        private const string String19B6 = "'Some battles were meant to be run away from. 'Tis a shame that some can't be run away from.";
        private const string String1A13 = "Carefully using the tool, you managed to open the door without much noise.";
        private const string String1A5E = "The door made a lot of noise as you came through.";
        private const string String1A90 = "You think this used to be a barracks before someone reduced all the beds to kindling.";
        private const string String1AE6 = "The barracks is as you last saw it.";
        private const string String1B0A = "You smile, grimly: you, at least, walked away from this killing place.";
        private const string String1B51 = "Again with the fighting?  Why is it that nobody here wants to make love, not war?";
        private const string String1BA3 = "Even make 'like' would be a pleasant change!";
        private const string String1BD0 = "This appears to have been a library, but all the furniture has been smashed or burned, and only the scattered remains of some books indicate what it used to be.";
        private const string String1C71 = "The library is as you last saw it.";
        private const string String1C94 = "This must have been some kind of laundry room.  The broken tubs could have been baths, but you spot a washboard that is just a little too rough for skin in the corner.";
        private const string String1D3C = "The laundry is as you last saw it.";
        private const string String1D5F = "The tile floors and deep basins indicate that this could only have been the communal baths.";
        private const string String1DBB = "There is still no hot water in these baths.";
        private const string String1DE7 = "This was some important person's private quarters.  You can see the four posts which are all that remain intact of what was once a luxurious bed.  A wardrobe is smashed to bits.  Whoever searched here was thorough, if not neat.";
        private const string String1ECB = "These quarters are as you last saw them.";
        private const string String1EF4 = "Yup, that's a wash tub.";
        private const string String1F0C = "Yup, that's a bath tub.";
        private const string String1F24 = "All right, I know it's a picture of a fountain, but we didn't have the world's biggest art budget.  Work with me, people, work with me!";
        private const string String1FAC = "Fortunately your clothes got squeaky clean down in the dissolving pool.  Not to mention your skin!";
        private const string String200F = "You find a washer repairman, sobbing because it's just too low tech to break.";
        private const string String205D = "Well, that water does look awfully inviting, but your equipment might rust.";
        private const string String20A9 = "They must pay a lot to some dragons to heat up the water in here.";
        private const string String20EB = "Why look!  You've never seen indoor running water before!  And considering 13th century hygiene, you can understand why water would want to flee from the likes of you.";
        private const string String2193 = "You don't know about this.  Every time you see a quantity of steaming hot water that large, you can't but help worry that someone is planning a meal around adventurer soup.";
        private const string String2240 = "Hey!  Nobody's gonna fool YOU that easily!  You know full well that there's an extra ten gold piece charge for the first person to use the hot water.";
        private const string String22D6 = "You wisely refuse to use any communal washing facilities 600 years before Marx invented communism.  You don't want to run any risks of getting blamed for anything, do you?";
        private const string String2382 = "Judging from the smell, the last person to use this was a barbarian.  All thoughts of using it yourself before the next refill flee from your mind.";
        private const string String2416 = "You're just glad you're not the one responsible for filling this thing!";
        private const string String245E = "This room has been mistreated so badly you have no idea what its purpose used to be.";
        private const string String24B3 = "This was, perhaps, the commanding officer's private bath.  The tile is good, and there is only one tub and one sink.  But it's just a guess.";
        private const string String2540 = "The bath tub still steams invitingly.";
        private const string String2566 = "You lament the chipped and cracked tile.  Why must vandals be so, well, vandalous?";
        private const string String25B9 = "You spot a loose tile.  After some effort, you pry it loose.  It appears whoever occupied this room decided to stash some cash here, just in case.";
        private const string String264C = "You chuckle to yourself and decide it was here in case you came along.";
        private const string String2693 = "The loose tile is empty.";
        private const string String26AC = "Maybe this was an armory.  Those poles could have been for polearms, those clumps of metal might have been arrowheads, and maybe those were swords.  Maybe.";
        private const string String2748 = "The armory is as uninteresting as ever.";
        private const string String2770 = "Mind you, there's nothing remaining that would give a clue, but from the rank odors that years of vacancy cannot remove, you suspect this once was a tannery.";
        
        // === Functions ================================================
        private void Fn_01(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFlag(player, 0x02, 0x50, 0x01);
            L0018: Compare(GetFacing(player), 0x0001);
            L0022: if (JumpNotEqual) goto L0031;
            L0024: ShowMessage(player, String0140); // This way to the Foyer of Cawdor.
            L0031: return; // RETURN;
        }

        private void Fn_02(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x001B);
            L0010: PushStack(player, 0x02);
            L0014: PushStack(player, ax);
0056  0015 C4 5E 06  les bx, [bp+0x6]
0059  0018 26 FF 5F 04  call far word [es:bx+0x4]
            L001C: cx = PopStack(player);
            L001D: cx = PopStack(player);
            L001E: Compare(ax, 0x0001);
            L0021: if (JumpEqual) goto L0026;
            L0023: goto L0124;
            L0026: RefreshCompareFlags(GetFlag(player, 0x03, 0x01));
            L0039: if (JumpNotEqual) goto L008A;
            L003B: RefreshCompareFlags(GetFlag(player, 0x03, 0x0A));
            L004E: if (JumpNotEqual) goto L008A;
            L0050: ShowMessage(player, String0161); // *
            L005D: ShowMessage(player, String0161); // *
            L006A: ShowMessage(player, String0161); // *
            L0077: ShowMessage(player, String0163); // Roxanna greets you fondly.  'It speaks well of thee that thou dost return to diminish the population of rude and unchivalrous beings that have inhabited this place since thy last visit.  May fortune favor thee!
00C5  0084 B8 02 00  mov ax, 0x2
            L0087: goto L03F0;
            L008A: Compare(GetFlag(player, 0x03, 0x01), 0x0002);
            L009E: if (JumpNotEqual) goto L0114;
            L00A0: ShowMessage(player, String0161); // *
            L00AD: ShowMessage(player, String0161); // *
            L00BA: ShowMessage(player, String0161); // *
            L00C7: ShowMessage(player, String0236); // Roxanna greets you.  'Gentle sir, I can show my gratitude for thy aid in placating the foul inhabitants of this place.  I have an item which once daily grants me a powerful heal spell.'
            L00D4: ShowMessage(player, String02F0); // You are healed!
            L00E1: HealPlayer(player, GetMaxHits(player));
            L00F2: PushStack(player, 0x01);
            L00F6: PushStack(player, ax);
            L00F7: PushStack(player, 0x03);
013C  00FB C4 5E 06  les bx, [bp+0x6]
013F  00FE 26 FF 1F  call far word [es:bx]
0142  0101 83 C4 06  add sp, 0x6
            L0104: ShowMessage(player, String0300); // 'Godspeed thee on thy missions here!'
            L0111: goto L0402;
            L0114: ShowMessage(player, String0326); // Roxanna nods as you pass, but says nothing.
            L0121: goto L0402;
            L0124: RefreshCompareFlags(GetFlag(player, 0x03, 0x02));
            L0137: if (JumpNotEqual) goto L013C;
            L0139: goto L02B7;
            L013C: PushStack(player, 0x03);
            L0140: PushStack(player, ax);
0182  0141 C4 5E 06  les bx, [bp+0x6]
0185  0144 26 FF 5F 04  call far word [es:bx+0x4]
            L0148: cx = PopStack(player);
            L0149: cx = PopStack(player);
            L014A: RefreshCompareFlags(ax);
            L014C: if (JumpNotEqual) goto L0151;
            L014E: goto L02B7;
            L0151: RefreshCompareFlags(GetFlag(player, 0x03, 0x04));
            L0164: if (JumpNotEqual) goto L0169;
            L0166: goto L02B7;
            L0169: RefreshCompareFlags(GetFlag(player, 0x03, 0x05));
            L017C: if (JumpNotEqual) goto L0181;
            L017E: goto L02B7;
            L0181: RefreshCompareFlags(GetFlag(player, 0x03, 0x06));
            L0194: if (JumpNotEqual) goto L0199;
            L0196: goto L02B7;
            L0199: RefreshCompareFlags(GetFlag(player, 0x03, 0x07));
            L01AC: if (JumpNotEqual) goto L01B1;
            L01AE: goto L02B7;
            L01B1: PushStack(player, 0x02);
            L01B5: PushStack(player, ax);
01F7  01B6 C4 5E 06  les bx, [bp+0x6]
01FA  01B9 26 FF 5F 04  call far word [es:bx+0x4]
            L01BD: cx = PopStack(player);
            L01BE: cx = PopStack(player);
            L01BF: RefreshCompareFlags(ax);
            L01C1: if (JumpEqual) goto L01DC;
            L01C3: Compare(GetFlag(player, 0x03, 0x0D), 0x0001);
            L01D7: if (JumpEqual) goto L01DC;
            L01D9: goto L02B7;
            L01DC: ShowMessage(player, String0161); // *
            L01E9: ShowMessage(player, String0161); // *
            L01F6: ShowMessage(player, String0161); // *
            L0203: ShowMessage(player, String0352); // 'I salute thee, for thou hast proven thyself to be of gentle mien and noble heart.  I am pleased to grant thee an award which, mayhaps, will aid thee in thy future chivalric endeavors.
            L0210: GiveItem(player, 0xBD);
            L021C: AddExperience(player, 0x00000FA0);
            L022D: RefreshCompareFlags(GetSkillLevel(player, 0x11));
            L023B: if (JumpNotEqual) goto L0281;
            L023D: Compare(GetGuild(player), 0x0001);
            L0247: if (JumpNotEqual) goto L0281;
            L0249: SetSkillLevel(player, 0x11, 0x01);
            L025A: ShowMessage(player, String040B); // Roxanne draws you aside and whispers to you.
            L0267: ShowMessage(player, String0438); // 'Thou now knowest how to deflect magical assaults' she whispers.
            L0274: ShowMessage(player, String0479); // She steps forward and speaks loudly again.
            L0281: PushStack(player, 0x01);
02C6  0285 C4 5E 06  les bx, [bp+0x6]
02C9  0288 26 FF 9F B0 00  call far word [es:bx+0xb0]
            L028D: cx = PopStack(player);
            L028E: RefreshCompareFlags(ax);
            L0290: if (JumpEqual) goto L029F;
            L0292: ShowMessage(player, String04A4); // Roxanne draws your party's knights aside for a few private words, and then returns.
            L029F: ShowMessage(player, String04F8); // She clasps your forearm, the old style of shaking hands.  'Now I must return to my duties.  Fare thee well!'
            L02AC: PushStack(player, 0x01);
            L02B0: PushStack(player, 0x02);
            L02B4: goto L03F8;
            L02B7: RefreshCompareFlags(GetFlag(player, 0x03, 0x02));
            L02CA: if (JumpNotEqual) goto L02CF;
            L02CC: goto L03B9;
            L02CF: PushStack(player, 0x03);
            L02D3: PushStack(player, ax);
0315  02D4 C4 5E 06  les bx, [bp+0x6]
0318  02D7 26 FF 5F 04  call far word [es:bx+0x4]
            L02DB: cx = PopStack(player);
            L02DC: cx = PopStack(player);
            L02DD: RefreshCompareFlags(ax);
            L02DF: if (JumpNotEqual) goto L02E4;
            L02E1: goto L03B9;
            L02E4: RefreshCompareFlags(GetFlag(player, 0x03, 0x04));
            L02F7: if (JumpNotEqual) goto L02FC;
            L02F9: goto L03B9;
            L02FC: RefreshCompareFlags(GetFlag(player, 0x03, 0x05));
            L030F: if (JumpNotEqual) goto L0314;
            L0311: goto L03B9;
            L0314: RefreshCompareFlags(GetFlag(player, 0x03, 0x06));
            L0327: if (JumpNotEqual) goto L032C;
            L0329: goto L03B9;
            L032C: RefreshCompareFlags(GetFlag(player, 0x03, 0x07));
            L033F: if (JumpEqual) goto L03B9;
            L0341: ShowMessage(player, String0161); // *
            L034E: ShowMessage(player, String0161); // *
            L035B: ShowMessage(player, String0161); // *
            L0368: ShowMessage(player, String0565); // 'I appreciate thy efforts against the unholy creatures residing here, but I lack the means to reward thee for thy efforts.  This will have to suffice.'
            L0375: AddExperience(player, 0x000003E8);
            L0386: GiveItem(player, 0xBD);
            L0392: ShowMessage(player, String05FD); // 'Thou art needed elsewhere.  Farewell....'
            L039F: PushStack(player, 0x01);
            L03A3: PushStack(player, 0x03);
            L03A7: PushStack(player, 0x01);
            L03AB: PushStack(player, ax);
03ED  03AC C4 5E 06  les bx, [bp+0x6]
03F0  03AF 26 FF 9F BC 00  call far word [es:bx+0xbc]
03F5  03B4 83 C4 08  add sp, 0x8
            L03B7: goto L0402;
            L03B9: ShowMessage(player, String0161); // *
            L03C6: ShowMessage(player, String0161); // *
            L03D3: ShowMessage(player, String0161); // *
            L03E0: ShowMessage(player, String0628); // 'I am Roxanna, the guardian of this gate.  I am charged to prevent the escape of the foul beasts that reside herein.  I thank thee for assisting me by battling the foul and fell beasts that live here.
            L03ED: SetFlag(player, 0x03, 0x01, 0x01);
            L0402: return; // RETURN;
        }

        private void Fn_03(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x02));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00E1;
            L001B: SetFlag(player, 0x03, 0x02, 0x01);
            L0030: ShowMessage(player, String06F1); // Incoming!
            L003D: PushStack(player, 0x90);
            L0041: PushStack(player, 0x00);
            L0044: PushStack(player, ax);
            L0045: PushStack(player, ax);
            L0046: PushStack(player, 0xB8);
            L004A: PushStack(player, 0xA0);
0493  004E C4 5E 06  les bx, [bp+0x6]
0496  0051 26 FF 9F D8 00  call far word [es:bx+0xd8]
049B  0056 83 C4 0C  add sp, 0xc
            L0059: AddEncounter(player, 0x01, 0x19);
            L006B: AddEncounter(player, 0x05, 0x1B);
            L007D: Compare(PartyCount(player), 0x0002);
            L0088: if (JumpBelowOrEqual) goto L00AE;
            L008A: AddEncounter(player, 0x02, 0x1A);
            L009C: AddEncounter(player, 0x06, 0x1B);
            L00AE: Compare(PartyCount(player), 0x0003);
            L00B9: if (JumpBelowOrEqual) goto L00EE;
            L00BB: AddEncounter(player, 0x04, 0x1C);
            L00CD: AddEncounter(player, 0x03, 0x1D);
            L00DF: goto L00EE;
            L00E1: ShowMessage(player, String06FB); // You give silent thanks that you were the one who survived the battle here.
            L00EE: return; // RETURN;
        }

        private void Fn_04(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x02), 0x0001);
            L0017: if (JumpNotEqual) goto L006E;
            L0019: PushStack(player, 0x03);
            L001D: PushStack(player, ax);
0553  001E C4 5E 06  les bx, [bp+0x6]
0556  0021 26 FF 5F 04  call far word [es:bx+0x4]
            L0025: cx = PopStack(player);
            L0026: cx = PopStack(player);
            L0027: Compare(ax, 0x0001);
            L002A: if (JumpNotEqual) goto L006E;
            L002C: Compare(GetFlag(player, 0x03, 0x04), 0x0001);
            L0040: if (JumpNotEqual) goto L006E;
            L0042: Compare(GetFlag(player, 0x03, 0x05), 0x0001);
            L0056: if (JumpNotEqual) goto L006E;
            L0058: Compare(GetFlag(player, 0x03, 0x06), 0x0001);
            L006C: if (JumpEqual) goto L0097;
            L006E: PushStack(player, 0x02);
            L0072: PushStack(player, ax);
05A8  0073 C4 5E 06  les bx, [bp+0x6]
05AB  0076 26 FF 5F 04  call far word [es:bx+0x4]
            L007A: cx = PopStack(player);
            L007B: cx = PopStack(player);
            L007C: Compare(ax, 0x0001);
            L007F: if (JumpEqual) goto L0097;
            L0081: PushStack(player, 0x02);
            L0085: PushStack(player, ax);
05BB  0086 C4 5E 06  les bx, [bp+0x6]
05BE  0089 26 FF 5F 04  call far word [es:bx+0x4]
            L008D: cx = PopStack(player);
            L008E: cx = PopStack(player);
            L008F: Compare(ax, 0x0002);
            L0092: if (JumpEqual) goto L0097;
            L0094: goto L0130;
            L0097: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L00B5: Compare(GetFlag(player, 0x03, 0x0E), 0x0002);
            L00C9: if (JumpEqual) goto L012B;
            L00CB: ax = HasUsedItem(player, 0xC1, 0xC3);
            L00DE: if (JumpNotEqual) goto L0107;
            L00E0: ax = HasUsedItem(player, 0xDA, 0xDD);
            L00F3: if (JumpNotEqual) goto L0107;
            L00F5: PushStack(player, 0xC0);
            L00F9: PushStack(player, ax);
062F  00FA C4 5E 06  les bx, [bp+0x6]
0632  00FD 26 FF 5F 54  call far word [es:bx+0x54]
            L0101: cx = PopStack(player);
            L0102: cx = PopStack(player);
            L0103: RefreshCompareFlags(ax);
            L0105: if (JumpEqual) goto L012B;
            L0107: ShowMessage(player, String0746); // You think the tool will enable you to proceed discreetly.
            L0114: SetFlag(player, 0x03, 0x0E, 0x03);
            L0129: goto L0171;
0660  012B B8 01 00  mov ax, 0x1
            L012E: goto L0117;
            L0130: ShowMessage(player, String0161); // *
            L013D: ShowMessage(player, String0161); // *
            L014A: ShowMessage(player, String0161); // *
            L0157: ShowMessage(player, String0780); // A familiar voice whispers to you.
            L0164: ShowMessage(player, String07A2); // 'Before thou dost assay the ultimate combat in this place, thou hadst best prove thy mettle against the lesser creatures and citizens found hereabouts.
            L0171: return; // RETURN;
        }

        private void Fn_06(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si, di);
            L0005: di = 0;
            L0007: si = 0;
            L0009: ax = GetFlag(player, 0x03, 0x08);
06C7  001A 8B F8  mov di, ax
06C9  001C 47     inc di
06CA  001D 8B F7  mov si, di
            L001F: Compare(si, 0x13);
            L0022: if (JumpLessOrEqual) goto L002B;
06D1  0024 8B C6  mov ax, si
            L0026: si = ax + 0xFFEC;
            L002B: Compare(si, 0x0E);
            L002E: if (JumpLessOrEqual) goto L0037;
06DD  0030 8B C6  mov ax, si
            L0032: si = ax + 0xFFF1;
            L0037: Compare(si, 0x09);
            L003A: if (JumpLessOrEqual) goto L0043;
06E9  003C 8B C6  mov ax, si
            L003E: si = ax + 0xFFF6;
            L0043: Compare(si, 0x04);
            L0046: if (JumpLessOrEqual) goto L004F;
06F5  0048 8B C6  mov ax, si
            L004A: si = ax + 0xFFFB;
06FC  004F 0B F6  or si, si
06FE  0051 7D 02  jge 0x55
            L0053: si = 0;
            L0055: Compare(si, 0x1D);
            L0058: if (JumpLessOrEqual) goto L005C;
            L005A: si = 0;
0709  005C 83 FF 18  cmp di, 0x18
            L005F: if (JumpLessOrEqual) goto L0063;
            L0061: di = 0;
0710  0063 57     push di
            L0064: PushStack(player, 0x08);
            L0068: PushStack(player, 0x03);
0719  006C C4 5E 06  les bx, [bp+0x6]
071C  006F 26 FF 1F  call far word [es:bx]
071F  0072 83 C4 06  add sp, 0x6
0722  0075 83 FF 1A  cmp di, 0x1a
            L0078: if (JumpNotEqual) goto L007F;
0727  007A B8 01 00  mov ax, 0x1
            L007D: goto L0081;
            L007F: PushStack(player, 0x00);
072F  0082 83 FF 14  cmp di, 0x14
            L0085: if (JumpNotEqual) goto L008C;
0734  0087 B8 01 00  mov ax, 0x1
            L008A: goto L008E;
0739  008C 33 C0  xor ax, ax
            L008E: dx = PopStack(player);
073C  008F 0B D0  or dx, ax
            L0091: PushStack(player, dx);
073F  0092 83 FF 0E  cmp di, 0xe
            L0095: if (JumpNotEqual) goto L009C;
0744  0097 B8 01 00  mov ax, 0x1
            L009A: goto L009E;
0749  009C 33 C0  xor ax, ax
            L009E: dx = PopStack(player);
074C  009F 0B D0  or dx, ax
            L00A1: PushStack(player, dx);
074F  00A2 83 FF 08  cmp di, 0x8
            L00A5: if (JumpNotEqual) goto L00AC;
0754  00A7 B8 01 00  mov ax, 0x1
            L00AA: goto L00AE;
0759  00AC 33 C0  xor ax, ax
            L00AE: dx = PopStack(player);
075C  00AF 0B D0  or dx, ax
            L00B1: PushStack(player, dx);
075F  00B2 83 FF 02  cmp di, 0x2
            L00B5: if (JumpNotEqual) goto L00BC;
0764  00B7 B8 01 00  mov ax, 0x1
            L00BA: goto L00BE;
0769  00BC 33 C0  xor ax, ax
            L00BE: dx = PopStack(player);
076C  00BF 0B D0  or dx, ax
            L00C1: if (JumpNotEqual) goto L00C6;
            L00C3: goto L02C6;
            L00C6: bx = si;
            L00C8: Compare(bx, 0x04);
            L00CB: if (JumpBelowOrEqual) goto L00D0;
            L00CD: goto L02C6;
            L00D0: switch (bx) {
                case 0:
                    goto L00D7;
                case 1:
                    goto L0135;
                case 2:
                    goto L0188;
                case 3:
                    goto L01E9;
                case 4:
                    goto L0257;
            }
            L00D7: ShowPortrait(player, 0x0025);
            L00E4: ShowMessage(player, String0161); // *
            L00F1: ShowMessage(player, String0161); // *
            L00FE: ShowMessage(player, String0161); // *
            L010B: ShowMessage(player, String083A); // You see a heavily scarred and well equipped halfling striding confidently towards you.  He is wearing Gorgon's Gauntlets and carrying Macduff's Maul.
            L0118: ShowMessage(player, String08D0); // He says, 'Thou wouldst not think it to look at me, but singlehandedly have I slain sixteen giants, and I seek number seventeen.  Poach not on my self-appointed terrain, sir knight!'
            L0125: ShowMessage(player, String0986); // You wisely decide to let him go his own way.
            L0132: goto L02C6;
            L0135: ShowPortrait(player, 0x0029);
            L0142: ShowMessage(player, String0161); // *
            L014F: ShowMessage(player, String0161); // *
            L015C: ShowMessage(player, String0161); // *
            L0169: ShowMessage(player, String09B3); // A small but sturdy halfling knight greets you.
            L0176: ShowMessage(player, String09E2); // 'Good morning, neighbor.  I am sworn to vengeance against Magog, a giant who has terrorised one halfling village too many.  To defeat him, I seek Swithun's Staff?  Know you where I might find one?'
0830  0183 B8 A8 0A  mov ax, 0xaa8
            L0186: goto L0128;
            L0188: ShowPortrait(player, 0x001D);
            L0195: ShowMessage(player, String0161); // *
            L01A2: ShowMessage(player, String0161); // *
            L01AF: ShowMessage(player, String0161); // *
            L01BC: ShowMessage(player, String0AD8); // A small, smiling halfling knight, carrying a Lozenge Spear, greets you.
            L01C9: ShowMessage(player, String0B20); // 'What ho!  Fellow knight, art thou sworn against the tall, that is to say, art thou on a quest against giantkind?'
            L01D6: ShowMessage(player, String0B93); // You politely indicate that you are not.
0890  01E3 B8 BB 0B  mov ax, 0xbbb
            L01E6: goto L0128;
            L01E9: ShowPortrait(player, 0x002C);
            L01F6: ShowMessage(player, String0161); // *
            L0203: ShowMessage(player, String0161); // *
            L0210: ShowMessage(player, String0161); // *
            L021D: ShowMessage(player, String0C1E); // A dwarf holds up her hand in greeting.
            L022A: ShowMessage(player, String0C45); // 'I say, friend!  I am in a bit of a bother.
            L0237: ShowMessage(player, String0C71); // Knowest thou whether the Antlered Helm or Ironside's Headgear is the more effective defense against giants?  I have both and I must decide which to use.'
            L0244: ShowMessage(player, String0D0B); // You tell her you don't know.
08FE  0251 B8 28 0D  mov ax, 0xd28
            L0254: goto L0128;
            L0257: ShowMessage(player, String0D67); // This must be the main minotaur migration mob!
            L0264: AddEncounter(player, 0x01, 0x0F);
            L0276: Compare(PartyCount(player), 0x0002);
            L0281: if (JumpBelowOrEqual) goto L0295;
            L0283: AddEncounter(player, 0x02, 0x17);
            L0295: Compare(PartyCount(player), 0x0003);
            L02A0: if (JumpBelowOrEqual) goto L02C6;
            L02A2: AddEncounter(player, 0x03, 0x28);
            L02B4: AddEncounter(player, 0x04, 0x28);
            L02C6: return; // RETURN (restoring si, di);
        }

        private void Fn_07(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x09));
            L0016: if (JumpNotEqual) goto L0063;
            L0018: ShowMessage(player, String0161); // *
            L0025: ShowMessage(player, String0161); // *
            L0032: ShowMessage(player, String0161); // *
            L003F: ShowMessage(player, String0D95); // This is the remains of a smithy.  A cracked anvil, some broken bellows, shattered shields, and splintered swords, are but some of the debris you see.
            L004C: SetFlag(player, 0x03, 0x09, 0x01);
            L0061: goto L007C;
            L0063: Compare(GetFacing(player), 0x0001);
            L006D: if (JumpNotEqual) goto L007C;
            L006F: ShowMessage(player, String0E2B); // The smithy remains as when you last saw it.
            L007C: return; // RETURN;
        }

        private void Fn_08(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0x06), 0x0001);
            L0017: if (JumpEqual) goto L002F;
            L0019: Compare(GetFlag(player, 0x03, 0x0A), 0x0001);
            L002D: if (JumpNotEqual) goto L0042;
            L002F: ShowMessage(player, String0E57); // A voice whispers from thin air....
0A3B  003C B8 7A 0E  mov ax, 0xe7a
            L003F: goto L0358;
            L0042: ShowPortrait(player, 0x0015);
            L004F: SetFlag(player, 0x03, 0x0A, 0x01);
            L0064: Compare(GetFlag(player, 0x02, 0x00), 0x0001);
            L0077: if (JumpEqual) goto L007C;
            L0079: goto L01C5;
            L007C: Compare(GetFlag(player, 0x02, 0x05), 0x0001);
            L0090: if (JumpEqual) goto L0095;
            L0092: goto L01C5;
            L0095: Compare(GetFlag(player, 0x02, 0x01), 0x0001);
            L00A9: if (JumpEqual) goto L00AE;
            L00AB: goto L01C5;
            L00AE: Compare(GetFlag(player, 0x02, 0x03), 0x0001);
            L00C2: if (JumpEqual) goto L00C7;
            L00C4: goto L01C5;
            L00C7: Compare(GetFlag(player, 0x02, 0x04), 0x0001);
            L00DB: if (JumpEqual) goto L00E0;
            L00DD: goto L01C5;
            L00E0: ShowMessage(player, String0161); // *
            L00ED: ShowMessage(player, String0161); // *
            L00FA: ShowMessage(player, String0161); // *
            L0107: ShowMessage(player, String0EB7); // 'Huzzah!  Thou hast done so well hitherto that I can safely reward thee.  I think me knowledge of the spell of shielding will best serve thee now.'
            L0114: ShowMessage(player, String0F4B); // You realize that you now know that spell!
            L0121: SetSpellLevel(player, 0x0F, 0x01);
            L0132: SetFlag(player, 0x02, 0x06, 0x01);
            L0147: PushStack(player, 0x02);
            L014B: PushStack(player, ax);
0B4B  014C C4 5E 06  les bx, [bp+0x6]
0B4E  014F 26 FF 5F 04  call far word [es:bx+0x4]
            L0153: cx = PopStack(player);
            L0154: cx = PopStack(player);
            L0155: RefreshCompareFlags(ax);
            L0157: if (JumpNotEqual) goto L0180;
            L0159: PushStack(player, 0x01);
            L015D: PushStack(player, 0x02);
            L0161: PushStack(player, ax);
0B61  0162 C4 5E 06  les bx, [bp+0x6]
0B64  0165 26 FF 1F  call far word [es:bx]
0B67  0168 83 C4 06  add sp, 0x6
            L016B: SetFlag(player, 0x03, 0x0D, 0x01);
            L0180: RefreshCompareFlags(GetFlag(player, 0x02, 0x0D));
            L0193: if (JumpEqual) goto L0198;
            L0195: goto L0362;
            L0198: ShowMessage(player, String0161); // *
            L01A5: ShowMessage(player, String0161); // *
            L01B2: ShowMessage(player, String0161); // *
0BBE  01BF B8 75 0F  mov ax, 0xf75
            L01C2: goto L0291;
            L01C5: RefreshCompareFlags(GetFlag(player, 0x02, 0x0D));
            L01D8: if (JumpEqual) goto L01DD;
            L01DA: goto L02D9;
            L01DD: RefreshCompareFlags(GetFlag(player, 0x03, 0x02));
            L01F0: if (JumpNotEqual) goto L01F5;
            L01F2: goto L02D9;
            L01F5: PushStack(player, 0x03);
            L01F9: PushStack(player, ax);
0BF9  01FA C4 5E 06  les bx, [bp+0x6]
0BFC  01FD 26 FF 5F 04  call far word [es:bx+0x4]
            L0201: cx = PopStack(player);
            L0202: cx = PopStack(player);
            L0203: RefreshCompareFlags(ax);
            L0205: if (JumpNotEqual) goto L020A;
            L0207: goto L02D9;
            L020A: RefreshCompareFlags(GetFlag(player, 0x03, 0x04));
            L021D: if (JumpNotEqual) goto L0222;
            L021F: goto L02D9;
            L0222: RefreshCompareFlags(GetFlag(player, 0x03, 0x05));
            L0235: if (JumpNotEqual) goto L023A;
            L0237: goto L02D9;
            L023A: RefreshCompareFlags(GetFlag(player, 0x03, 0x06));
            L024D: if (JumpNotEqual) goto L0252;
            L024F: goto L02D9;
            L0252: RefreshCompareFlags(GetFlag(player, 0x03, 0x07));
            L0265: if (JumpEqual) goto L02D9;
            L0267: ShowMessage(player, String0161); // *
            L0274: ShowMessage(player, String0161); // *
            L0281: ShowMessage(player, String0161); // *
            L028E: ShowMessage(player, String105E); // 'I applaud and praise thee, who hast risked life and limb on my behalf.  As thy journey waxes ever more perilous, it behooves me to teach thee a swifter way to retreat to places where thou may replenish thy supplies and renew thy strength and vigor.
            L029B: PushStack(player, 0x01);
            L029F: PushStack(player, 0x02);
            L02A3: PushStack(player, ax);
0CA3  02A4 C4 5E 06  les bx, [bp+0x6]
0CA6  02A7 26 FF 1F  call far word [es:bx]
0CA9  02AA 83 C4 06  add sp, 0x6
            L02AD: SetSpellLevel(player, 0x11, 0x01);
            L02BE: SetFlag(player, 0x02, 0x0D, 0x01);
0CD2  02D3 B8 3A 10  mov ax, 0x103a
            L02D6: goto L0358;
            L02D9: Compare(GetGuild(player), 0x0001);
            L02E3: if (JumpNotEqual) goto L0311;
            L02E5: ShowMessage(player, String0161); // *
            L02F2: ShowMessage(player, String0161); // *
            L02FF: ShowMessage(player, String0161); // *
0D0B  030C B8 58 11  mov ax, 0x1158
            L030F: goto L0358;
            L0311: RefreshCompareFlags(GetFlag(player, 0x02, 0x71));
            L0324: if (JumpNotEqual) goto L0355;
            L0326: ShowMessage(player, String11C2); // 'Thou art surviving, which is the important thing.  Take thee this item which mayhaps will help thee to continue doing so.'
            L0333: SetFlag(player, 0x02, 0x71, 0x01);
            L0348: PushStack(player, 0xBD);
0D4B  034C C4 5E 06  les bx, [bp+0x6]
0D4E  034F 26 FF 5F 48  call far word [es:bx+0x48]
            L0353: goto L0361;
            L0355: ShowMessage(player, String123E); // 'Thou hast earned no further rewards from me, good ticklebrain.'
            L0362: return; // RETURN;
        }

        private void Fn_09(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x02, 0x47));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00E1;
            L001B: RefreshCompareFlags(GetFlag(player, 0x03, 0x0C));
            L002E: if (JumpEqual) goto L0033;
            L0030: goto L00EE;
            L0033: SetFlag(player, 0x03, 0x0C, 0x01);
            L0048: ShowPortrait(player, 0x0025);
            L0055: ShowMessage(player, String0161); // *
            L0062: ShowMessage(player, String0161); // *
            L006F: ShowMessage(player, String0161); // *
            L007C: ShowMessage(player, String127F); // A jauntily clad halfling greets you.
            L0089: ShowMessage(player, String12A4); // 'Good gentle folk, let me not delay thee o'ermuch.
            L0096: ShowMessage(player, String12D7); // I have but this word to put in thy ear.  Ask not from whence I did learn of it, but I have been charged with the task of spreading this missive as far as I might, and thou art now my spreadee.
            L00A3: ShowMessage(player, String1398); // Hark thee and mark thee: there are many most potent items consisting of a body part of a creature.  For example, the Eye of Newt, the Toe of Frog, et al.
            L00B0: ShowMessage(player, String1432); // These items all are of immense power and restrictions.  They can slay most any creature, but use them with care: once used, once useless.
            L00BD: ShowMessage(player, String14BC); // An thou dost pass these words along, I shall stand in thy debt.'  The halfling hurries off.
            L00CA: SetFlag(player, 0x02, 0x09, 0x01);
            L00DF: goto L00EE;
            L00E1: ShowMessage(player, String1518); // It was here that you learned that Rory, amongst others, was on your quest.  You promise yourself that your next toast of good brown ale will be for lost friends.
            L00EE: return; // RETURN;
        }

        private void Fn_0A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x04), 0x0001);
            L0017: if (JumpNotEqual) goto L0029;
            L0019: ShowMessage(player, String15BA); // You're just glad you're not the janitor, what with all these minotaur morsels lying around here.
            L0026: goto L0107;
            L0029: SetFlag(player, 0x03, 0x04, 0x01);
            L003E: ShowMessage(player, String161B); // Uh oh.  Those minotaurs look angry, and that's no bull.
            L004B: Compare(PartyCount(player), 0x0003);
            L0056: if (JumpBelowOrEqual) goto L0065;
            L0058: ShowMessage(player, String1653); // Maybe the spellcasters moving them along have something to do with that.
            L0065: PushStack(player, 0xCF);
            L0069: PushStack(player, 0x00);
            L006C: PushStack(player, ax);
            L006D: PushStack(player, ax);
            L006E: PushStack(player, 0xB8);
            L0072: PushStack(player, 0xCB);
0EC9  0076 C4 5E 06  les bx, [bp+0x6]
0ECC  0079 26 FF 9F D8 00  call far word [es:bx+0xd8]
0ED1  007E 83 C4 0C  add sp, 0xc
            L0081: AddEncounter(player, 0x01, 0x28);
            L0093: AddEncounter(player, 0x02, 0x28);
            L00A5: Compare(PartyCount(player), 0x0002);
            L00B0: if (JumpBelowOrEqual) goto L00D6;
            L00B2: AddEncounter(player, 0x03, 0x28);
            L00C4: AddEncounter(player, 0x04, 0x28);
            L00D6: Compare(PartyCount(player), 0x0003);
            L00E1: if (JumpBelowOrEqual) goto L0107;
            L00E3: AddEncounter(player, 0x05, 0x1F);
            L00F5: AddEncounter(player, 0x06, 0x1F);
            L0107: return; // RETURN;
        }

        private void Fn_0B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x05), 0x0001);
            L0017: if (JumpNotEqual) goto L0029;
            L0019: ShowMessage(player, String169C); // There's something grotesquely comforting about having survived a combat.
            L0026: goto L010A;
            L0029: ShowMessage(player, String16E5); // There's a thin thin line between a smiling and a snarling face and - yup! - these guys are snarling!
            L0036: SetFlag(player, 0x03, 0x05, 0x01);
            L004B: Compare(PartyCount(player), 0x0003);
            L0056: if (JumpBelowOrEqual) goto L0065;
            L0058: ShowMessage(player, String174A); // And in desperate need of orthodontia.
            L0065: PushStack(player, 0xBC);
            L0069: PushStack(player, 0x00);
            L006C: PushStack(player, ax);
            L006D: PushStack(player, 0xCB);
            L0071: PushStack(player, 0xB8);
            L0075: PushStack(player, 0xA0);
0FD5  0079 C4 5E 06  les bx, [bp+0x6]
0FD8  007C 26 FF 9F D8 00  call far word [es:bx+0xd8]
0FDD  0081 83 C4 0C  add sp, 0xc
            L0084: AddEncounter(player, 0x01, 0x1E);
            L0096: AddEncounter(player, 0x02, 0x24);
            L00A8: Compare(PartyCount(player), 0x0002);
            L00B3: if (JumpBelowOrEqual) goto L00C7;
            L00B5: AddEncounter(player, 0x05, 0x1F);
            L00C7: Compare(PartyCount(player), 0x0003);
            L00D2: if (JumpBelowOrEqual) goto L010A;
            L00D4: AddEncounter(player, 0x03, 0x22);
            L00E6: AddEncounter(player, 0x04, 0x21);
            L00F8: AddEncounter(player, 0x06, 0x1B);
            L010A: return; // RETURN;
        }

        private void Fn_0C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x06), 0x0001);
            L0017: if (JumpNotEqual) goto L0029;
            L0019: ShowMessage(player, String1770); // There are enough feline allergens here to make all of Edinburgh sneeze!
            L0026: goto L00DE;
            L0029: ShowMessage(player, String17B8); // Man!  Those cats are so big, their purring sounds like buzzsaws!  Not that they're purring right now, either.
            L0036: SetFlag(player, 0x03, 0x06, 0x01);
            L004B: AddEncounter(player, 0x01, 0x26);
            L005D: AddEncounter(player, 0x02, 0x26);
            L006F: Compare(PartyCount(player), 0x0001);
            L007A: if (JumpBelowOrEqual) goto L008E;
            L007C: AddEncounter(player, 0x03, 0x27);
            L008E: Compare(PartyCount(player), 0x0002);
            L0099: if (JumpBelowOrEqual) goto L00DE;
            L009B: ShowMessage(player, String1826); // Unless they're purring in anticipation of a filling meal: hero tartar!
            L00A8: AddEncounter(player, 0x03, 0x27);
            L00BA: AddEncounter(player, 0x04, 0x27);
            L00CC: AddEncounter(player, 0x06, 0x26);
            L00DE: return; // RETURN;
        }

        private void Fn_0D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x07), 0x0001);
            L0017: if (JumpNotEqual) goto L0029;
            L0019: ShowMessage(player, String186D); // 'If you are going to have to fight, it's a lot more pleasant having fought someone with a hefty purse,' you think to yourself, recalling the battle here.
            L0026: goto L015A;
            L0029: SetFlag(player, 0x03, 0x07, 0x01);
            L003E: RefreshCompareFlags(GetFlag(player, 0x03, 0x0E));
            L0051: if (JumpNotEqual) goto L0079;
            L0053: ShowMessage(player, String1907); // Ah, heck!  You thought this was a good spot for an ambush.  Evidently, so did they.
            L0060: ax = GetCurrentHits(player);
            L0067: bx = 0x0003;
            L006A: dx = ax % bx; ax = ax / bx;
            L006D: DamagePlayer(player, ax);
            L0077: goto L0097;
            L0079: ShowMessage(player, String195B); // You know, those thievish skills and lockpicks may have something going for them after all.
            L0086: AddExperience(player, 0x000001F4);
            L0097: Compare(PartyCount(player), 0x0002);
            L00A2: if (JumpBelowOrEqual) goto L00B1;
            L00A4: ShowMessage(player, String19B6); // 'Some battles were meant to be run away from. 'Tis a shame that some can't be run away from.
            L00B1: SetFlag(player, 0x03, 0x0E, 0x00);
120D  00C5 B8 1E 02  mov ax, 0x21e
            L00C8: PushStack(player, ax);
            L00C9: PushStack(player, 0x00);
            L00CC: PushStack(player, ax);
            L00CD: PushStack(player, ax);
            L00CE: PushStack(player, 0xCB);
            L00D2: PushStack(player, 0xB9);
121E  00D6 C4 5E 06  les bx, [bp+0x6]
1221  00D9 26 FF 9F D8 00  call far word [es:bx+0xd8]
1226  00DE 83 C4 0C  add sp, 0xc
            L00E1: AddEncounter(player, 0x01, 0x25);
            L00F3: AddEncounter(player, 0x02, 0x25);
            L0105: AddEncounter(player, 0x05, 0x1B);
            L0117: AddEncounter(player, 0x06, 0x1B);
            L0129: Compare(PartyCount(player), 0x0002);
            L0134: if (JumpBelowOrEqual) goto L015A;
            L0136: AddEncounter(player, 0x03, 0x25);
            L0148: AddEncounter(player, 0x04, 0x25);
            L015A: return; // RETURN;
        }

        private void Fn_0E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x07));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00CF;
            L001B: Compare(GetFlag(player, 0x03, 0x0E), 0x0003);
            L002F: if (JumpEqual) goto L0083;
            L0031: Compare(GetFlag(player, 0x03, 0x0E), 0x0001);
            L0045: if (JumpNotEqual) goto L0099;
            L0047: ax = HasUsedItem(player, 0xC1, 0xC3);
            L005A: if (JumpNotEqual) goto L0083;
            L005C: ax = HasUsedItem(player, 0xDA, 0xDD);
            L006F: if (JumpNotEqual) goto L0083;
            L0071: PushStack(player, 0xC0);
            L0075: PushStack(player, ax);
131A  0076 C4 5E 06  les bx, [bp+0x6]
131D  0079 26 FF 5F 54  call far word [es:bx+0x54]
            L007D: cx = PopStack(player);
            L007E: cx = PopStack(player);
            L007F: RefreshCompareFlags(ax);
            L0081: if (JumpEqual) goto L0099;
            L0083: ShowMessage(player, String1A13); // Carefully using the tool, you managed to open the door without much noise.
            L0090: PushStack(player, 0x03);
1338  0094 B8 0E 00  mov ax, 0xe
            L0097: goto L00C1;
            L0099: ShowMessage(player, String1A5E); // The door made a lot of noise as you came through.
            L00A6: SetFlag(player, 0x03, 0x0E, 0x00);
            L00BA: SetFlag(player, 0x03, 0x0F, 0x01);
            L00CF: return; // RETURN;
        }

        private void Fn_0F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFlag(player, 0x03, 0x0E, 0x00);
            L0017: return; // RETURN;
        }

        private void Fn_10(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x10));
            L0016: if (JumpNotEqual) goto L003C;
            L0018: ShowMessage(player, String1A90); // You think this used to be a barracks before someone reduced all the beds to kindling.
            L0025: SetFlag(player, 0x03, 0x10, 0x01);
            L003A: goto L0055;
            L003C: Compare(GetFacing(player), 0x0001);
            L0046: if (JumpNotEqual) goto L0055;
            L0048: ShowMessage(player, String1AE6); // The barracks is as you last saw it.
            L0055: return; // RETURN;
        }

        private void Fn_11(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x03);
            L0007: PushStack(player, ax);
13ED  0008 C4 5E 06  les bx, [bp+0x6]
13F0  000B 26 FF 5F 04  call far word [es:bx+0x4]
            L000F: cx = PopStack(player);
            L0010: cx = PopStack(player);
            L0011: Compare(ax, 0x0001);
            L0014: if (JumpNotEqual) goto L0026;
            L0016: ShowMessage(player, String1B0A); // You smile, grimly: you, at least, walked away from this killing place.
            L0023: goto L00EF;
            L0026: PushStack(player, 0x01);
            L002A: PushStack(player, 0x03);
            L002E: PushStack(player, ax);
1414  002F C4 5E 06  les bx, [bp+0x6]
1417  0032 26 FF 1F  call far word [es:bx]
141A  0035 83 C4 06  add sp, 0x6
            L0038: ShowMessage(player, String1B51); // Again with the fighting?  Why is it that nobody here wants to make love, not war?
            L0045: Compare(PartyCount(player), 0x0003);
            L0050: if (JumpBelowOrEqual) goto L005F;
            L0052: ShowMessage(player, String1BA3); // Even make 'like' would be a pleasant change!
1444  005F B8 1E 02  mov ax, 0x21e
            L0062: PushStack(player, ax);
            L0063: PushStack(player, 0x00);
            L0066: PushStack(player, ax);
            L0067: PushStack(player, ax);
            L0068: PushStack(player, 0xCB);
            L006C: PushStack(player, 0xB8);
1455  0070 C4 5E 06  les bx, [bp+0x6]
1458  0073 26 FF 9F D8 00  call far word [es:bx+0xd8]
145D  0078 83 C4 0C  add sp, 0xc
            L007B: AddEncounter(player, 0x01, 0x20);
            L008D: AddEncounter(player, 0x02, 0x23);
            L009F: Compare(PartyCount(player), 0x0002);
            L00AA: if (JumpBelowOrEqual) goto L00D0;
            L00AC: AddEncounter(player, 0x05, 0x21);
            L00BE: AddEncounter(player, 0x06, 0x21);
            L00D0: Compare(PartyCount(player), 0x0003);
            L00DB: if (JumpBelowOrEqual) goto L00EF;
            L00DD: AddEncounter(player, 0x03, 0x22);
            L00EF: return; // RETURN;
        }

        private void Fn_12(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x11));
            L0016: if (JumpNotEqual) goto L003C;
            L0018: ShowMessage(player, String1BD0); // This appears to have been a library, but all the furniture has been smashed or burned, and only the scattered remains of some books indicate what it used to be.
            L0025: SetFlag(player, 0x03, 0x11, 0x01);
            L003A: goto L0055;
            L003C: Compare(GetFacing(player), 0x0001);
            L0046: if (JumpNotEqual) goto L0055;
            L0048: ShowMessage(player, String1C71); // The library is as you last saw it.
            L0055: return; // RETURN;
        }

        private void Fn_14(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x12));
            L0016: if (JumpNotEqual) goto L003C;
            L0018: ShowMessage(player, String1C94); // This must have been some kind of laundry room.  The broken tubs could have been baths, but you spot a washboard that is just a little too rough for skin in the corner.
            L0025: SetFlag(player, 0x03, 0x12, 0x01);
            L003A: goto L0055;
            L003C: Compare(GetFacing(player), 0x0001);
            L0046: if (JumpNotEqual) goto L0055;
            L0048: ShowMessage(player, String1D3C); // The laundry is as you last saw it.
            L0055: return; // RETURN;
        }

        private void Fn_15(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x01);
            L0007: PushStack(player, 0x03);
            L000B: PushStack(player, 0x01);
            L000F: PushStack(player, ax);
1599  0010 C4 5E 06  les bx, [bp+0x6]
159C  0013 26 FF 9F BC 00  call far word [es:bx+0xbc]
15A1  0018 83 C4 08  add sp, 0x8
            L001B: return; // RETURN;
        }

        private void Fn_16(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x13));
            L0016: if (JumpNotEqual) goto L003C;
            L0018: ShowMessage(player, String1D5F); // The tile floors and deep basins indicate that this could only have been the communal baths.
            L0025: SetFlag(player, 0x03, 0x13, 0x01);
            L003A: goto L0055;
            L003C: Compare(GetFacing(player), 0x0001);
            L0046: if (JumpNotEqual) goto L0055;
            L0048: ShowMessage(player, String1DBB); // There is still no hot water in these baths.
            L0055: return; // RETURN;
        }

        private void Fn_17(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x14));
            L0016: if (JumpNotEqual) goto L003C;
            L0018: ShowMessage(player, String1DE7); // This was some important person's private quarters.  You can see the four posts which are all that remain intact of what was once a luxurious bed.  A wardrobe is smashed to bits.  Whoever searched here was thorough, if not neat.
            L0025: SetFlag(player, 0x03, 0x14, 0x01);
            L003A: goto L0055;
            L003C: Compare(GetFacing(player), 0x0001);
            L0046: if (JumpNotEqual) goto L0055;
            L0048: ShowMessage(player, String1ECB); // These quarters are as you last saw them.
            L0055: return; // RETURN;
        }

        private void Fn_18(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: ShowPortrait(player, 0x0042);
            L0011: si = 0;
            L0013: si = GetFlag(player, 0x02, 0x5F);
            L0026: si = si + 1;
            L0027: Compare(si, 0x0A);
            L002A: if (JumpLessOrEqual) goto L002F;
            L002C: si = 0x0001;
            L002F: Compare(GetCurrentTile(player), 0x006F);
            L0039: if (JumpNotEqual) goto L0040;
168F  003B B8 F4 1E  mov ax, 0x1ef4
            L003E: goto L0043;
            L0040: ShowMessage(player, String1F0C); // Yup, that's a bath tub.
            L004D: Compare(si, 0x06);
            L0050: if (JumpNotEqual) goto L005F;
            L0052: ShowMessage(player, String1F24); // All right, I know it's a picture of a fountain, but we didn't have the world's biggest art budget.  Work with me, people, work with me!
            L005F: SetFlag(player, 0xC4, 0xB8, si);
            L0071: bx = si;
            L0073: bx = bx - 1;
            L0074: Compare(bx, 0x09);
            L0077: if (JumpAbove) goto L00BA;
            L0079: switch (bx) {
                case 0:
                    goto L0080;
                case 1:
                    goto L0085;
                case 2:
                    goto L008A;
                case 3:
                    goto L008F;
                case 4:
                    goto L0094;
                case 5:
                    goto L0099;
                case 6:
                    goto L009E;
                case 7:
                    goto L00A3;
                case 8:
                    goto L00A8;
                case 9:
                    goto L00AD;
            }
16D4  0080 B8 AC 1F  mov ax, 0x1fac
            L0083: goto L00B0;
16D9  0085 B8 0F 20  mov ax, 0x200f
            L0088: goto L00B0;
16DE  008A B8 5D 20  mov ax, 0x205d
            L008D: goto L00B0;
16E3  008F B8 A9 20  mov ax, 0x20a9
            L0092: goto L00B0;
16E8  0094 B8 EB 20  mov ax, 0x20eb
            L0097: goto L00B0;
16ED  0099 B8 93 21  mov ax, 0x2193
            L009C: goto L00B0;
16F2  009E B8 40 22  mov ax, 0x2240
            L00A1: goto L00B0;
16F7  00A3 B8 D6 22  mov ax, 0x22d6
            L00A6: goto L00B0;
16FC  00A8 B8 82 23  mov ax, 0x2382
            L00AB: goto L00B0;
            L00AD: ShowMessage(player, String2416); // You're just glad you're not the one responsible for filling this thing!
            L00BA: return; // RETURN (restoring si);
        }

        private void Fn_1B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFacing(player));
            L000C: if (JumpNotEqual) goto L001B;
            L000E: ShowMessage(player, String245E); // This room has been mistreated so badly you have no idea what its purpose used to be.
            L001B: return; // RETURN;
        }

        private void Fn_1C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x15));
            L0016: if (JumpNotEqual) goto L003C;
            L0018: ShowMessage(player, String24B3); // This was, perhaps, the commanding officer's private bath.  The tile is good, and there is only one tub and one sink.  But it's just a guess.
            L0025: SetFlag(player, 0x03, 0x15, 0x01);
            L003A: goto L0055;
            L003C: Compare(GetFacing(player), 0x0001);
            L0046: if (JumpNotEqual) goto L0055;
            L0048: ShowMessage(player, String2540); // The bath tub still steams invitingly.
            L0055: return; // RETURN;
        }

        private void Fn_1D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String2566); // You lament the chipped and cracked tile.  Why must vandals be so, well, vandalous?
            L0010: Compare(HasUsedSkill(player, 0x0D), 0x0004);
            L001F: if (JumpNotBelow) goto L008B;
            L0021: RefreshCompareFlags(HasUsedSpell(player, 0x17));
            L002F: if (JumpNotEqual) goto L008B;
            L0031: PushStack(player, 0xA7);
            L0035: PushStack(player, ax);
17D9  0036 C4 5E 06  les bx, [bp+0x6]
17DC  0039 26 FF 5F 54  call far word [es:bx+0x54]
            L003D: cx = PopStack(player);
            L003E: cx = PopStack(player);
            L003F: RefreshCompareFlags(ax);
            L0041: if (JumpNotEqual) goto L008B;
            L0043: PushStack(player, 0x67);
            L0047: PushStack(player, ax);
17EB  0048 C4 5E 06  les bx, [bp+0x6]
17EE  004B 26 FF 5F 54  call far word [es:bx+0x54]
            L004F: cx = PopStack(player);
            L0050: cx = PopStack(player);
            L0051: RefreshCompareFlags(ax);
            L0053: if (JumpNotEqual) goto L008B;
            L0055: PushStack(player, 0x61);
            L0059: PushStack(player, ax);
17FD  005A C4 5E 06  les bx, [bp+0x6]
1800  005D 26 FF 5F 54  call far word [es:bx+0x54]
            L0061: cx = PopStack(player);
            L0062: cx = PopStack(player);
            L0063: RefreshCompareFlags(ax);
            L0065: if (JumpNotEqual) goto L008B;
            L0067: PushStack(player, 0x93);
            L006B: PushStack(player, ax);
180F  006C C4 5E 06  les bx, [bp+0x6]
1812  006F 26 FF 5F 54  call far word [es:bx+0x54]
            L0073: cx = PopStack(player);
            L0074: cx = PopStack(player);
            L0075: RefreshCompareFlags(ax);
            L0077: if (JumpNotEqual) goto L008B;
            L0079: PushStack(player, 0x86);
            L007D: PushStack(player, ax);
1821  007E C4 5E 06  les bx, [bp+0x6]
1824  0081 26 FF 5F 54  call far word [es:bx+0x54]
            L0085: cx = PopStack(player);
            L0086: cx = PopStack(player);
            L0087: RefreshCompareFlags(ax);
            L0089: if (JumpEqual) goto L00E5;
            L008B: RefreshCompareFlags(GetFlag(player, 0x02, 0x13));
            L009E: if (JumpNotEqual) goto L00D8;
            L00A0: ShowMessage(player, String25B9); // You spot a loose tile.  After some effort, you pry it loose.  It appears whoever occupied this room decided to stash some cash here, just in case.
            L00AD: SetFlag(player, 0x02, 0x13, 0x01);
            L00C2: ModifyGold(player, 0x0341);
1876  00D3 B8 4C 26  mov ax, 0x264c
            L00D6: goto L00DB;
            L00D8: ShowMessage(player, String2693); // The loose tile is empty.
            L00E5: return; // RETURN;
        }

        private void Fn_1E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x16));
            L0016: if (JumpNotEqual) goto L003C;
            L0018: ShowMessage(player, String26AC); // Maybe this was an armory.  Those poles could have been for polearms, those clumps of metal might have been arrowheads, and maybe those were swords.  Maybe.
            L0025: SetFlag(player, 0x03, 0x16, 0x01);
            L003A: goto L0049;
            L003C: ShowMessage(player, String2748); // The armory is as uninteresting as ever.
            L0049: return; // RETURN;
        }

        private void Fn_1F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x17));
            L0016: if (JumpNotEqual) goto L003A;
            L0018: ShowMessage(player, String2770); // Mind you, there's nothing remaining that would give a clue, but from the rank odors that years of vacancy cannot remove, you suspect this once was a tannery.
            L0025: SetFlag(player, 0x03, 0x17, 0x01);
            L003A: return; // RETURN;
        }

    }
}
